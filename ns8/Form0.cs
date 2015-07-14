using System;
using System.Windows.Forms;

namespace ns8
{
	// Token: 0x02000189 RID: 393
	internal class Form0 : Form
	{
		// Token: 0x040006F0 RID: 1776
		private bool bool_0;

		// Token: 0x040006EF RID: 1775
		private Timer timer_0;

		// Token: 0x06000E4F RID: 3663
		// RVA: 0x0004E4FC File Offset: 0x0004C6FC
		public Form0()
		{
			base.Opacity = 0.0;
			this.timer_0 = new Timer();
			this.timer_0.Interval = 10;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.timer_0.Start();
		}

		// Token: 0x06000E50 RID: 3664
		// RVA: 0x0004E558 File Offset: 0x0004C758
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!base.IsDisposed)
			{
				if (base.Opacity != 1.0)
				{
					try
					{
						base.Opacity = Math.Min(1.0, base.Opacity + Math.Max(0.0099999997764825821, (1.0 - base.Opacity) * 0.1));
					}
					catch
					{
					}
					return;
				}
			}
			this.timer_0.Stop();
			this.bool_0 = true;
		}
	}
}
