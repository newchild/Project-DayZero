using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A8 RID: 1192
	internal sealed class Class614 : Label
	{
		// Token: 0x04001F82 RID: 8066
		private SolidBrush solidBrush_0 = new SolidBrush(Color.White);

		// Token: 0x04001F81 RID: 8065
		private StringFormat stringFormat_0 = new StringFormat();

		// Token: 0x06002623 RID: 9763
		// RVA: 0x000E5424 File Offset: 0x000E3624
		private unsafe void method_0(Bitmap bitmap_0, Color color_0)
		{
			Rectangle rect = new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height);
			int num = bitmap_0.Width * 4;
			int height = bitmap_0.Height;
			BitmapData bitmapData = bitmap_0.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
			int stride = bitmapData.Stride;
			byte r = color_0.R;
			byte g = color_0.G;
			byte b = color_0.B;
			byte* ptr = (byte*)((void*)bitmapData.Scan0);
			for (int i = 0; i < height; i++)
			{
				int num2 = i * stride;
				for (int j = 0; j < num; j += 4)
				{
					byte b2 = ptr[num2 + j + 1];
					ptr[num2 + j] = b;
					ptr[num2 + j + 1] = g;
					ptr[num2 + j + 2] = r;
					ptr[num2 + j + 3] = b2;
				}
			}
			bitmap_0.UnlockBits(bitmapData);
		}

		// Token: 0x06002622 RID: 9762
		// RVA: 0x000E536C File Offset: 0x000E356C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (this.BackColor.A < 255)
			{
				Graphics graphics = pevent.Graphics;
				Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height, PixelFormat.Format32bppArgb);
				Graphics graphics2 = Graphics.FromImage(bitmap);
				graphics2.Clear(Color.Black);
				graphics2.DrawString(this.Text, this.Font, this.solidBrush_0, new PointF(0f, 0f), this.stringFormat_0);
				this.method_0(bitmap, this.ForeColor);
				graphics.DrawImageUnscaled(bitmap, new Point(0, 0));
				return;
			}
			base.OnPaint(pevent);
		}
	}
}
