using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A5 RID: 1189
	internal sealed class Control0 : UserControl
	{
		// Token: 0x04001F79 RID: 8057
		private Color color_0 = Color.FromArgb(255, 102, 170);

		// Token: 0x04001F74 RID: 8052
		private float float_0;

		// Token: 0x04001F75 RID: 8053
		private float float_1;

		// Token: 0x04001F7A RID: 8058
		private IContainer icontainer_0;

		// Token: 0x04001F76 RID: 8054
		private int int_0;

		// Token: 0x04001F77 RID: 8055
		private int int_1 = 100;

		// Token: 0x04001F78 RID: 8056
		private int int_2;

		// Token: 0x04001F73 RID: 8051
		private Timer timer_0 = new Timer();

		// Token: 0x1700038B RID: 907
		public int Maximum
		{
			// Token: 0x06002610 RID: 9744
			// RVA: 0x0001D905 File Offset: 0x0001BB05
			set
			{
				if (value < this.int_0)
				{
					this.int_0 = value;
				}
				this.int_1 = value;
				if (this.int_2 > this.int_1)
				{
					this.int_2 = this.int_1;
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700038A RID: 906
		public int Minimum
		{
			// Token: 0x0600260F RID: 9743
			// RVA: 0x000E4E60 File Offset: 0x000E3060
			set
			{
				if (value < 0)
				{
					this.int_0 = 0;
				}
				if (value > this.int_1)
				{
					this.int_0 = value;
					this.int_0 = value;
				}
				if (this.int_2 < this.int_0)
				{
					this.int_2 = this.int_0;
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700038C RID: 908
		public int Value
		{
			// Token: 0x06002611 RID: 9745
			// RVA: 0x000E4EB0 File Offset: 0x000E30B0
			set
			{
				int num = this.int_2;
				if (value < this.int_0)
				{
					this.int_2 = this.int_0;
				}
				else if (value > this.int_1)
				{
					this.int_2 = this.int_1;
				}
				else
				{
					this.int_2 = value;
				}
				Rectangle clientRectangle = base.ClientRectangle;
				Rectangle clientRectangle2 = base.ClientRectangle;
				float num2 = (float)(this.int_2 - this.int_0) / (float)(this.int_1 - this.int_0);
				clientRectangle.Width = (int)((float)clientRectangle.Width * num2);
				num2 = (float)(num - this.int_0) / (float)(this.int_1 - this.int_0);
				clientRectangle2.Width = (int)((float)clientRectangle2.Width * num2);
				Rectangle rc = default(Rectangle);
				if (clientRectangle.Width > clientRectangle2.Width)
				{
					rc.X = clientRectangle2.Size.Width;
					rc.Width = clientRectangle.Width - clientRectangle2.Width;
				}
				else
				{
					rc.X = clientRectangle.Size.Width;
					rc.Width = clientRectangle2.Width - clientRectangle.Width;
				}
				rc.Height = base.Height;
				base.Invalidate(rc);
			}
		}

		// Token: 0x0600260A RID: 9738
		// RVA: 0x000E4C90 File Offset: 0x000E2E90
		public Control0()
		{
			this.BackColor = Color.FromArgb(85, 85, 85);
			this.method_3();
			this.timer_0.Interval = 16;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.timer_0.Start();
			this.DoubleBuffered = true;
		}

		// Token: 0x06002613 RID: 9747
		// RVA: 0x0001D94D File Offset: 0x0001BB4D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600260B RID: 9739
		// RVA: 0x0001D8C9 File Offset: 0x0001BAC9
		private float method_0()
		{
			return (float)(this.int_2 - this.int_0) / (float)(this.int_1 - this.int_0);
		}

		// Token: 0x0600260D RID: 9741
		// RVA: 0x0001D8E8 File Offset: 0x0001BAE8
		private float method_1()
		{
			return (float)Math.Max(0.0, Math.Sin((double)this.float_1));
		}

		// Token: 0x06002612 RID: 9746
		// RVA: 0x0001D93E File Offset: 0x0001BB3E
		public void method_2(Color color_1)
		{
			this.color_0 = color_1;
			base.Invalidate();
		}

		// Token: 0x06002614 RID: 9748
		// RVA: 0x0001D96C File Offset: 0x0001BB6C
		private void method_3()
		{
			this.icontainer_0 = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x0600260E RID: 9742
		// RVA: 0x000E4DCC File Offset: 0x000E2FCC
		protected override void OnPaint(PaintEventArgs pevent)
		{
			int alpha = (this.method_0() <= 0f) ? ((int)(255f * this.method_1())) : 255;
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(alpha, this.color_0)))
			{
				RectangleF rect = base.ClientRectangle;
				rect.Width = 1f + rect.Width * this.float_0;
				pevent.Graphics.FillRectangle(solidBrush, rect);
			}
		}

		// Token: 0x0600260C RID: 9740
		// RVA: 0x000E4D1C File Offset: 0x000E2F1C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.method_0() <= 0f)
			{
				this.float_1 += 0.05f;
				this.float_0 = 1f;
				base.Invalidate();
				return;
			}
			if (Math.Abs(this.float_0 - this.method_0()) > 0.005f)
			{
				if (this.float_1 != 0f)
				{
					this.float_0 = (float)((this.method_1() > 0.5f) ? 1 : 0);
					this.float_1 = 0f;
				}
				else
				{
					this.float_0 = this.float_0 * 0.9f + this.method_0() * 0.1f;
				}
				base.Invalidate();
			}
		}
	}
}
