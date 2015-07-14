using ns11;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns14
{
	// Token: 0x020005CA RID: 1482
	internal static class Class792
	{
		// Token: 0x06002EF9 RID: 12025
		// RVA: 0x00023392 File Offset: 0x00021592
		public static DialogResult smethod_0(string string_0)
		{
			return Class792.smethod_1(string_0, "osu!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}

		// Token: 0x06002EFA RID: 12026
		// RVA: 0x00130E14 File Offset: 0x0012F014
		public static DialogResult smethod_1(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
		{
			SplashScreen.smethod_3();
			Form form = new Form();
			form.ShowInTaskbar = false;
			form.Size = new Size(1, 1);
			form.StartPosition = FormStartPosition.Manual;
			Rectangle virtualScreen = SystemInformation.VirtualScreen;
			form.Location = new Point(virtualScreen.Bottom + 10, virtualScreen.Right + 10);
			form.Show();
			form.Focus();
			form.BringToFront();
			form.TopMost = true;
			DialogResult result = MessageBox.Show(form, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
			form.Dispose();
			return result;
		}
	}
}
