using ns14;
using System;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004AB RID: 1195
	internal sealed class Class617 : ListView
	{
		// Token: 0x04001F88 RID: 8072
		private bool bool_0;

		// Token: 0x04001F89 RID: 8073
		private bool bool_1;

		// Token: 0x0600262F RID: 9775
		// RVA: 0x0001DA87 File Offset: 0x0001BC87
		public Class617()
		{
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.method_0();
		}

		// Token: 0x06002630 RID: 9776
		// RVA: 0x000E5864 File Offset: 0x000E3A64
		private void method_0()
		{
			if (!this.bool_0 && base.Columns.Count != 0 && this.bool_1)
			{
				float num = Class611.smethod_0(this, false) / 96f;
				foreach (ColumnHeader columnHeader in base.Columns)
				{
					columnHeader.Width = (int)((float)columnHeader.Width * num);
				}
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002632 RID: 9778
		// RVA: 0x0001DAB0 File Offset: 0x0001BCB0
		protected override void OnColumnWidthChanged(ColumnWidthChangedEventArgs e)
		{
			base.OnColumnWidthChanged(e);
			this.bool_1 = true;
		}

		// Token: 0x06002631 RID: 9777
		// RVA: 0x0001DAA1 File Offset: 0x0001BCA1
		protected override void OnLayout(LayoutEventArgs levent)
		{
			base.OnLayout(levent);
			this.method_0();
		}
	}
}
