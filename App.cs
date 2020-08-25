using System;
using System.Collections.Generic;

namespace Debil.Vision
{
	// Token: 0x02000002 RID: 2
	internal class App
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				if (User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static string Error = null;

		// Token: 0x04000002 RID: 2
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
