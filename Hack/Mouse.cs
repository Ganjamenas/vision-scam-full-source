using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Debil.Vision.Hack
{
	// Token: 0x02000012 RID: 18
	public static class Mouse
	{
		// Token: 0x0600008E RID: 142
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x0600008F RID: 143
		[DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

		// Token: 0x06000090 RID: 144
		[DllImport("user32.dll")]
		private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

		// Token: 0x06000091 RID: 145 RVA: 0x0000945A File Offset: 0x0000765A
		public static void KeyPress(byte vKeyCode = 34, int sleep = 95)
		{
			Mouse.keybd_event(vKeyCode, 69, 1U, 0);
			Thread.Sleep(sleep);
			Mouse.keybd_event(vKeyCode, 69, 3U, 0);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009476 File Offset: 0x00007676
		public static void RelativeMove(int relx, int rely)
		{
			Mouse.mouse_event(1, relx, rely, 0, 0);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009482 File Offset: 0x00007682
		public static bool IsKeyDown(Keys key)
		{
			return (Mouse.GetAsyncKeyState((int)key) & 32768) > 0;
		}
	}
}
