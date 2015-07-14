using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns14
{
	// Token: 0x02000495 RID: 1173
	internal sealed class Class601
	{
		// Token: 0x02000496 RID: 1174
		private sealed class Class602
		{
			// Token: 0x060025BC RID: 9660
			[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
			public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);
		}

		// Token: 0x02000497 RID: 1175
		private sealed class Class603
		{
			// Token: 0x02000498 RID: 1176
			[StructLayout(LayoutKind.Sequential)]
			public sealed class Class604
			{
				// Token: 0x04001F47 RID: 8007
				public int int_0;

				// Token: 0x04001F48 RID: 8008
				public int int_1;

				// Token: 0x04001F49 RID: 8009
				public int int_2;

				// Token: 0x04001F4A RID: 8010
				public int int_3;

				// Token: 0x060025C0 RID: 9664
				// RVA: 0x0001D556 File Offset: 0x0001B756
				public Class604(int int_4, int int_5, int int_6, int int_7)
				{
					this.int_0 = int_4;
					this.int_1 = int_5;
					this.int_2 = int_6;
					this.int_3 = int_7;
				}
			}

			// Token: 0x060025BD RID: 9661
			[DllImport("dwmapi.dll", PreserveSig = false)]
			public static extern void DwmExtendFrameIntoClientArea(IntPtr intptr_0, Class601.Class603.Class604 class604_0);

			// Token: 0x060025BE RID: 9662
			[DllImport("dwmapi.dll", PreserveSig = false)]
			public static extern bool DwmIsCompositionEnabled();

			// Token: 0x060025BF RID: 9663
			[DllImport("dwmapi.dll", PreserveSig = false)]
			public static extern void DwmSetWindowAttribute(IntPtr intptr_0, int int_0, ref int int_1, int int_2);
		}

		// Token: 0x060025B5 RID: 9653
		// RVA: 0x0001D4E0 File Offset: 0x0001B6E0
		internal static bool smethod_0()
		{
			return Environment.OSVersion.Version.Major >= 6 && Class601.Class603.DwmIsCompositionEnabled();
		}

		// Token: 0x060025B6 RID: 9654
		// RVA: 0x0001D4FB File Offset: 0x0001B6FB
		internal static bool smethod_1()
		{
			return Environment.OSVersion.Version.Major >= 6 && Application.RenderWithVisualStyles;
		}

		// Token: 0x060025B7 RID: 9655
		// RVA: 0x0001D516 File Offset: 0x0001B716
		internal static void smethod_2(Control control_0, Struct48 struct48_0)
		{
			if (!Class601.smethod_0())
			{
				return;
			}
			Class601.Class603.DwmExtendFrameIntoClientArea(control_0.Handle, new Class601.Class603.Class604(struct48_0.int_0, struct48_0.int_1, struct48_0.int_2, struct48_0.int_3));
		}

		// Token: 0x060025B8 RID: 9656
		// RVA: 0x000E3500 File Offset: 0x000E1700
		internal static void smethod_3(Control control_0)
		{
			if (!Class601.smethod_0())
			{
				return;
			}
			int num = 2;
			Class601.Class603.DwmSetWindowAttribute(control_0.Handle, 2, ref num, 4);
		}

		// Token: 0x060025B9 RID: 9657
		// RVA: 0x000E3528 File Offset: 0x000E1728
		internal static void smethod_4(Control control_0)
		{
			if (!Class601.smethod_0())
			{
				return;
			}
			int num = 0;
			Class601.Class603.DwmSetWindowAttribute(control_0.Handle, 2, ref num, 4);
		}

		// Token: 0x060025BA RID: 9658
		// RVA: 0x000E3550 File Offset: 0x000E1750
		internal static void smethod_5(Control control_0, string string_0, string string_1)
		{
			if (!Application.RenderWithVisualStyles)
			{
				return;
			}
			int num;
			if ((num = Class601.Class602.SetWindowTheme(control_0.Handle, string_0, string_1)) < 0)
			{
				throw new InvalidOperationException("SetWindowTheme failed with error " + num.ToString());
			}
		}

		// Token: 0x060025BB RID: 9659
		// RVA: 0x0001D54C File Offset: 0x0001B74C
		internal static void smethod_6(Control control_0, string string_0)
		{
			Class601.smethod_5(control_0, string_0, null);
		}
	}
}
