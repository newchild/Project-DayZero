using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns8
{
	// Token: 0x0200046B RID: 1131
	internal class Form3 : Form2
	{
		// Token: 0x0600248E RID: 9358
		// RVA: 0x000DD148 File Offset: 0x000DB348
		private void method_9(Control control_0)
		{
			this.BackColor = Color.White;
			foreach (Control control_ in control_0.Controls)
			{
				this.method_9(control_);
			}
		}

		// Token: 0x0600248D RID: 9357
		// RVA: 0x0001CA34 File Offset: 0x0001AC34
		protected override void OnLoad(EventArgs e)
		{
			this.method_9(this);
			base.OnLoad(e);
		}
	}
}
