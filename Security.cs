using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

namespace Debil.Vision
{
	// Token: 0x02000008 RID: 8
	internal class Security
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003A30 File Offset: 0x00001C30
		public static string Signature(string value)
		{
			string result;
			using (MD5 md5 = MD5.Create())
			{
				byte[] input = Encoding.UTF8.GetBytes(value);
				result = BitConverter.ToString(md5.ComputeHash(input)).Replace("-", "");
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003A88 File Offset: 0x00001C88
		private static string Session(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003ACC File Offset: 0x00001CCC
		public static string Obfuscate(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003B10 File Offset: 0x00001D10
		public static void Start()
		{
			string drive = Path.GetPathRoot(Environment.SystemDirectory);
			if (Constants.Started)
			{
				MessageBox.Show("A session has already been started, please end the previous one!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				Process.GetCurrentProcess().Kill();
				return;
			}
			using (StreamReader sr = new StreamReader(drive + "Windows\\System32\\drivers\\etc\\hosts"))
			{
				if (sr.ReadToEnd().Contains("api.auth.gg"))
				{
					Constants.Breached = true;
					MessageBox.Show("DNS redirecting has been detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
			new InfoManager().StartListener();
			Constants.Token = Guid.NewGuid().ToString();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Security.PinPublicKey));
			Constants.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(32)));
			Constants.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(16)));
			Constants.IV = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(16)));
			Constants.Key = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(32)));
			Constants.Started = true;
		}


		// Token: 0x06000049 RID: 73 RVA: 0x00003CDE File Offset: 0x00001EDE
		private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return certificate != null && certificate.GetPublicKeyString() == "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public static string Integrity(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003D68 File Offset: 0x00001F68
		public static bool MaliciousCheck(string date)
		{
			DateTime d4 = DateTime.Parse(date);
			DateTime dt2 = DateTime.Now;
			TimeSpan d3 = d4 - dt2;
			if (Convert.ToInt32(d3.Seconds.ToString().Replace("-", "")) >= 5 || Convert.ToInt32(d3.Minutes.ToString().Replace("-", "")) >= 1)
			{
				Constants.Breached = true;
				return true;
			}
			return false;
		}

		// Token: 0x04000027 RID: 39
		private const string _key = "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
	}
}
