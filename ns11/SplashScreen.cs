using ns14;
using ns29;
using ns8;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A6 RID: 1190
	internal sealed class SplashScreen : Form2
	{
		// Token: 0x04001F7D RID: 8061
		private Bitmap bitmap_0;

		// Token: 0x04001F7E RID: 8062
		private bool bool_1 = true;

		// Token: 0x04001F7F RID: 8063
		private IContainer icontainer_0;

		// Token: 0x04001F7C RID: 8060
		private static SplashScreen splashScreen_0;

		// Token: 0x04001F7B RID: 8059
		private Timer timer_1;

		// Token: 0x06002615 RID: 9749
		// RVA: 0x000E4FEC File Offset: 0x000E31EC
		public SplashScreen(Bitmap bitmap_1)
		{
			this.InitializeComponent();
			this.bitmap_0 = bitmap_1;
			SplashScreen.splashScreen_0 = this;
			if (Class601.smethod_0())
			{
				base.Opacity = 0.0;
			}
			this.timer_1 = new Timer();
			this.timer_1.Interval = 30;
			this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
			this.timer_1.Start();
		}

		// Token: 0x0600261C RID: 9756
		// RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600261D RID: 9757
		// RVA: 0x000E5148 File Offset: 0x000E3348
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.ClientSize = new Size(300, 300);
			base.FormBorderStyle = FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SplashScreen";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "osu! (loading)";
			base.ResumeLayout(false);
		}

		// Token: 0x0600261E RID: 9758
		// RVA: 0x000E51B8 File Offset: 0x000E33B8
		[CompilerGenerated]
		private void method_10()
		{
			try
			{
				this.timer_1.Stop();
				base.Close();
				base.Dispose();
				SplashScreen.splashScreen_0 = null;
			}
			catch
			{
			}
		}

		// Token: 0x06002618 RID: 9752
		// RVA: 0x0001D980 File Offset: 0x0001BB80
		private void method_9()
		{
			base.Invoke(new MethodInvoker(this.method_10));
		}

		// Token: 0x0600261A RID: 9754
		// RVA: 0x0001D994 File Offset: 0x0001BB94
		protected override void OnClosing(CancelEventArgs e)
		{
			if (this.timer_1.Enabled)
			{
				e.Cancel = true;
			}
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
			}
			base.OnClosing(e);
		}

		// Token: 0x0600261B RID: 9755
		// RVA: 0x000E50E8 File Offset: 0x000E32E8
		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (this.bool_1)
			{
				this.bool_1 = false;
				base.WindowState = FormWindowState.Minimized;
				base.Show();
				base.WindowState = FormWindowState.Normal;
			}
			pevent.Graphics.DrawImage(this.bitmap_0, new Rectangle(0, 0, this.bitmap_0.Width, this.bitmap_0.Height));
		}

		// Token: 0x06002619 RID: 9753
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06002617 RID: 9751
		// RVA: 0x000E50CC File Offset: 0x000E32CC
		public static void smethod_3()
		{
			SplashScreen splashScreen = SplashScreen.splashScreen_0;
			if (splashScreen != null)
			{
				splashScreen.method_9();
			}
		}

		// Token: 0x06002616 RID: 9750
		// RVA: 0x000E506C File Offset: 0x000E326C
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (base.Opacity < 0.8)
			{
				base.Opacity += (1.0 - base.Opacity) * 0.1;
			}
			if (Class115.form_0 != null && Class115.form_0.Created)
			{
				this.method_9();
			}
		}
	}
}
