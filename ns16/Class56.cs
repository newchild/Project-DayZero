using ns27;
using ns9;
using System;

namespace ns16
{
	// Token: 0x02000392 RID: 914
	internal sealed class Class56 : Class55
	{
		// Token: 0x04001678 RID: 5752
		private Class110 class110_0;

		// Token: 0x06001C4D RID: 7245
		// RVA: 0x0001755D File Offset: 0x0001575D
		protected override void Dispose(bool bool_2)
		{
			this.class110_0.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06001C4E RID: 7246
		// RVA: 0x00017571 File Offset: 0x00015771
		public override void Draw()
		{
			this.class110_0.Draw();
			base.Draw();
		}

		// Token: 0x06001C4F RID: 7247
		// RVA: 0x00017584 File Offset: 0x00015784
		public override void imethod_2()
		{
			this.class110_0.imethod_2();
			base.imethod_2();
		}
	}
}
