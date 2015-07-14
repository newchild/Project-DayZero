using osu.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004AA RID: 1194
	internal sealed class Class616 : Button
	{
		// Token: 0x04001F84 RID: 8068
		private static Bitmap bitmap_0;

		// Token: 0x04001F86 RID: 8070
		private bool bool_0;

		// Token: 0x04001F87 RID: 8071
		public bool bool_1 = true;

		// Token: 0x04001F85 RID: 8069
		private Color color_0;

		// Token: 0x06002628 RID: 9768
		// RVA: 0x000E558C File Offset: 0x000E378C
		public Class616()
		{
			if (Class616.bitmap_0 == null)
			{
				Class616.bitmap_0 = Resources.glassbutton;
			}
			base.MouseEnter += new EventHandler(this.Class616_MouseEnter);
			base.MouseLeave += new EventHandler(this.Class616_MouseLeave);
		}

		// Token: 0x0600262D RID: 9773
		// RVA: 0x0001DA69 File Offset: 0x0001BC69
		private void Class616_MouseEnter(object sender, EventArgs e)
		{
			this.bool_0 = true;
			base.Invalidate();
		}

		// Token: 0x0600262E RID: 9774
		// RVA: 0x0001DA78 File Offset: 0x0001BC78
		private void Class616_MouseLeave(object sender, EventArgs e)
		{
			this.bool_0 = false;
			base.Invalidate();
		}

		// Token: 0x06002629 RID: 9769
		// RVA: 0x0001DA49 File Offset: 0x0001BC49
		public Color method_0()
		{
			return this.color_0;
		}

		// Token: 0x0600262A RID: 9770
		// RVA: 0x0001DA51 File Offset: 0x0001BC51
		public void method_1(Color color_1)
		{
			this.color_0 = color_1;
			base.Invalidate();
		}

		// Token: 0x0600262C RID: 9772
		// RVA: 0x000E55DC File Offset: 0x000E37DC
		protected override void OnPaint(PaintEventArgs pevent)
		{
			this.OnPaintBackground(pevent);
			Graphics graphics = pevent.Graphics;
			int width = base.Width;
			int height = base.Height;
			Brush brush = new SolidBrush(this.color_0);
			if (width >= 22 && height >= 22)
			{
				graphics.FillRectangle(brush, 3, 1, width - 6, 1);
				graphics.FillRectangle(brush, 2, 2, width - 4, 1);
				graphics.FillRectangle(brush, 1, 3, width - 2, height - 6);
				graphics.FillRectangle(brush, 2, height - 3, width - 4, 1);
				graphics.FillRectangle(brush, 3, height - 2, width - 6, 1);
				int num = this.bool_0 ? 2 : 1;
				for (int i = 0; i < num; i++)
				{
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(0, 0, 11, 11), new Rectangle(0, 0, 11, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(width - 11, 0, 11, 11), new Rectangle(21, 0, 11, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(0, height - 11, 11, 11), new Rectangle(0, 21, 11, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(width - 11, height - 11, 11, 11), new Rectangle(21, 21, 11, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(11, 0, width - 22, 11), new Rectangle(11, 0, 10, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(0, 11, 11, height - 22), new Rectangle(0, 11, 11, 10), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(11, height - 11, width - 22, 11), new Rectangle(11, 21, 10, 11), GraphicsUnit.Pixel);
					graphics.DrawImage(Class616.bitmap_0, new Rectangle(width - 11, 11, 11, height - 22), new Rectangle(21, 11, 11, 10), GraphicsUnit.Pixel);
				}
				Brush brush2 = new SolidBrush(this.ForeColor);
				Brush brush3 = new SolidBrush(Color.FromArgb(191, 0, 0, 0));
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				Point p = new Point(width / 2, height / 2);
				graphics.DrawString(this.Text, this.Font, brush3, new Point(p.X, p.Y + 1), stringFormat);
				graphics.DrawString(this.Text, this.Font, brush2, p, stringFormat);
				return;
			}
			graphics.FillRectangle(brush, 0, 0, width, height);
		}

		// Token: 0x0600262B RID: 9771
		// RVA: 0x0001DA60 File Offset: 0x0001BC60
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}
	}
}
