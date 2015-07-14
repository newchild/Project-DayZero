using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns14
{
	// Token: 0x020005CC RID: 1484
	internal sealed class Class794
	{
		// Token: 0x020005CD RID: 1485
		// Token: 0x06002F05 RID: 12037
		private delegate int Delegate39(int int_0, int int_1, ref Class794.Struct56 struct56_0);

		// Token: 0x020005CE RID: 1486
		private struct Struct56
		{
			// Token: 0x0400272F RID: 10031
			public int int_0;

			// Token: 0x04002730 RID: 10032
			private int int_1;

			// Token: 0x04002731 RID: 10033
			public int int_2;

			// Token: 0x04002732 RID: 10034
			private int int_3;

			// Token: 0x04002733 RID: 10035
			private int int_4;
		}

		// Token: 0x0400272C RID: 10028
		internal static bool bool_0;

		// Token: 0x0400272E RID: 10030
		private static Class794.Delegate39 delegate39_0;

		// Token: 0x0400272D RID: 10029
		private static int int_0;

		// Token: 0x06002F00 RID: 12032
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		private static extern int CallNextHookEx(int int_1, int int_2, int int_3, ref Class794.Struct56 struct56_0);

		// Token: 0x06002EFE RID: 12030
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		private static extern int SetWindowsHookExA(int int_1, Class794.Delegate39 delegate39_1, IntPtr intptr_0, int int_2);

		// Token: 0x06002F01 RID: 12033
		// RVA: 0x00131330 File Offset: 0x0012F530
		private static int smethod_0(int int_1, int int_2, ref Class794.Struct56 struct56_0)
		{
			switch (int_2)
			{
			case 256:
			case 257:
			case 260:
			case 261:
				if ((struct56_0.int_0 == 91 || struct56_0.int_0 == 92) && struct56_0.int_2 == 1)
				{
					return 1;
				}
				break;
			}
			return Class794.CallNextHookEx(0, int_1, int_2, ref struct56_0);
		}

		// Token: 0x06002F02 RID: 12034
		// RVA: 0x00131390 File Offset: 0x0012F590
		internal static void smethod_1()
		{
			if (Class794.int_0 != 0)
			{
				return;
			}
			try
			{
				Class794.int_0 = Class794.SetWindowsHookExA(13, Class794.delegate39_0 = new Class794.Delegate39(Class794.smethod_0), Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			}
			catch
			{
			}
			Class794.bool_0 = true;
		}

		// Token: 0x06002F03 RID: 12035
		// RVA: 0x001313F0 File Offset: 0x0012F5F0
		internal static void smethod_2()
		{
			try
			{
				Class794.int_0 = Class794.UnhookWindowsHookEx(Class794.int_0);
				Class794.delegate39_0 = null;
			}
			catch
			{
			}
			Class794.int_0 = 0;
			Class794.bool_0 = false;
		}

		// Token: 0x06002EFF RID: 12031
		[DllImport("user32.dll")]
		private static extern int UnhookWindowsHookEx(int int_1);
	}
}
