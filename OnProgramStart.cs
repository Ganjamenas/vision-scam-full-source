using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

namespace Debil.Vision
{
	// Token: 0x02000006 RID: 6
	internal class OnProgramStart
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000022C4 File Offset: 0x000004C4
		public static void Initialize(string name, string aid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Invalid application information!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			OnProgramStart.AID = aid;
			OnProgramStart.Secret = secret;
			OnProgramStart.Version = version;
			OnProgramStart.Name = name;
			string[] response = new string[0];
			using (WebClient wc = new WebClient())
			{
				
			}
		}

		// Token: 0x04000022 RID: 34
		public static string AID;

		// Token: 0x04000023 RID: 35
		public static string Secret;

		// Token: 0x04000024 RID: 36
		public static string Version;

		// Token: 0x04000025 RID: 37
		public static string Name;

		// Token: 0x04000026 RID: 38
		public static string Salt;
	}
}
