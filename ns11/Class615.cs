using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A9 RID: 1193
	internal sealed class Class615 : Panel
	{
		// Token: 0x04001F83 RID: 8067
		private bool bool_0;

		// Token: 0x06002625 RID: 9765
		// RVA: 0x0001DA40 File Offset: 0x0001BC40
		public void method_0(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06002626 RID: 9766
		// RVA: 0x000E5504 File Offset: 0x000E3704
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (this.BackColor.A < 255)
			{
				Graphics graphics = e.Graphics;
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.Clear(Color.FromArgb(0, 0, 0, 0));
				return;
			}
			base.OnPaintBackground(e);
		}

		// Token: 0x06002627 RID: 9767
		// RVA: 0x000E554C File Offset: 0x000E374C
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			int msg = m.Msg;
			if (msg != 132)
			{
				return;
			}
			if (this.bool_0)
			{
				m.Result = (IntPtr)(-1L);
			}
		}
	}
}
