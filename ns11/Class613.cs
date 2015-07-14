using osu.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A7 RID: 1191
	internal sealed class Class613 : Panel
	{
		// Token: 0x04001F80 RID: 8064
		private Bitmap bitmap_0;

		// Token: 0x0600261F RID: 9759
		// RVA: 0x0001D9E3 File Offset: 0x0001BBE3
		public Class613()
		{
			this.BackColor = Color.FromArgb(128, 255, 255, 255);
			this.bitmap_0 = Resources.glasscorner;
		}

		// Token: 0x06002620 RID: 9760
		// RVA: 0x000E51F8 File Offset: 0x000E33F8
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.CompositingMode = CompositingMode.SourceCopy;
			graphics.Clear(Color.FromArgb(191, 255, 255, 255));
			int width = base.Width;
			int height = base.Height;
			if (width >= 8 && height >= 8)
			{
				Pen pen = new Pen(Color.FromArgb(223, 255, 255, 255));
				Pen pen2 = new Pen(Color.FromArgb(191, 0, 0, 0));
				Pen pen3 = new Pen(Color.FromArgb(128, 255, 255, 255));
				graphics.DrawRectangle(pen3, 0, 0, width - 1, height - 1);
				graphics.DrawRectangle(pen2, 1, 1, width - 3, height - 3);
				graphics.DrawRectangle(pen, 2, 2, width - 5, height - 5);
				graphics.DrawImage(this.bitmap_0, new Rectangle(0, 0, 4, 4), new Rectangle(0, 0, 4, 4), GraphicsUnit.Pixel);
				graphics.DrawImage(this.bitmap_0, new Rectangle(base.Width - 4, 0, 4, 4), new Rectangle(4, 0, 4, 4), GraphicsUnit.Pixel);
				graphics.DrawImage(this.bitmap_0, new Rectangle(0, base.Height - 4, 4, 4), new Rectangle(0, 4, 4, 4), GraphicsUnit.Pixel);
				graphics.DrawImage(this.bitmap_0, new Rectangle(base.Width - 4, base.Height - 4, 4, 4), new Rectangle(4, 4, 4, 4), GraphicsUnit.Pixel);
				return;
			}
		}
	}
}
