using System;
using System.Runtime.InteropServices;

namespace hikssldemo
{
	// Token: 0x02000004 RID: 4
	internal class SslAlermTimer
	{
		// Token: 0x06000009 RID: 9
		[DllImport("User32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x0600000A RID: 10
		[DllImport("User32.dll")]
		public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

		// Token: 0x0600000B RID: 11
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x04000003 RID: 3
		public static int WM_CLICK = 245;
	}
}
