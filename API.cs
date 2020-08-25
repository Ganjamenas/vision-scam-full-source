using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows;

namespace Debil.Vision
{
	// Token: 0x02000007 RID: 7
	internal class API
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002750 File Offset: 0x00000950
		public static void Log(string username, string action)
		{
			
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002920 File Offset: 0x00000B20
		public static bool AIO(string AIO)
		{
			return API.AIOLogin(AIO) || API.AIORegister(AIO);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002938 File Offset: 0x00000B38
		public static bool AIOLogin(string AIO)
		{
			return true;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D34 File Offset: 0x00000F34
		public static bool AIORegister(string AIO)
		{
			

			bool result;
			using (WebClient wc = new WebClient())
			{
				try
				{
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ApplicationSettings.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002FEC File Offset: 0x000011EC
		public static bool Login(string username, string password)
		{
			return true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003404 File Offset: 0x00001604
		public static bool Register(string username, string password, string email, string license)
		{
			return true;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003744 File Offset: 0x00001944
		public static bool ExtendSubscription(string username, string password, string license)
		{
			return true;
		}
	}
}
