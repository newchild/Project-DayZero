using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A4 RID: 1188
	internal sealed class Class612 : LinkLabel
	{
		// Token: 0x06002607 RID: 9735
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr LoadCursor(IntPtr intptr_0, int int_0);

		// Token: 0x06002608 RID: 9736
		// RVA: 0x0001D88C File Offset: 0x0001BA8C
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			if (base.OverrideCursor == Cursors.Hand)
			{
				base.OverrideCursor = new Cursor(Class612.LoadCursor(IntPtr.Zero, 32649));
			}
		}
	}
}
