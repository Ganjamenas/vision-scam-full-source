using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace Debil.Vision
{
	// Token: 0x0200000A RID: 10
	internal class InfoManager
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000040A5 File Offset: 0x000022A5
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000040B9 File Offset: 0x000022B9
		public void StartListener()
		{
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000040DC File Offset: 0x000022DC
		private void OnCallBack()
		{
			this.timer.Dispose();
			if (!(this.GetGatewayMAC() == this.lastGateway))
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004158 File Offset: 0x00002358
		public static IPAddress GetDefaultGateway()
		{
			return (from a in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				if (ipproperties == null)
				{
					return null;
				}
				return ipproperties.GatewayAddresses;
			}).Select(delegate(GatewayIPAddressInformation g)
			{
				if (g == null)
				{
					return null;
				}
				return g.Address;
			})
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004224 File Offset: 0x00002424
		private string GetArpTable()
		{
			string drive = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = drive + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader reader = process.StandardOutput)
				{
					result = reader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000042BC File Offset: 0x000024BC
		private string GetGatewayMAC()
		{
			string routerIP = InfoManager.GetDefaultGateway().ToString();
			return new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", routerIP)).Match(this.GetArpTable()).Groups[2].ToString();
		}

		// Token: 0x04000028 RID: 40
		private Timer timer;

		// Token: 0x04000029 RID: 41
		private string lastGateway;
	}
}
