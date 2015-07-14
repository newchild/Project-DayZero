using ns18;
using ns26;
using ns59;
using ns60;
using System;

namespace ns23
{
	// Token: 0x0200041A RID: 1050
	internal class Class298 : Class297
	{
		// Token: 0x060021B0 RID: 8624
		// RVA: 0x0001B20E File Offset: 0x0001940E
		internal Class298(bool bool_2) : base(bool_2)
		{
		}

		// Token: 0x060021B2 RID: 8626
		// RVA: 0x0001B21F File Offset: 0x0001941F
		internal override void vmethod_16()
		{
			base.vmethod_16();
			if (!Class62.bool_8 && Class331.smethod_30())
			{
				Class331.smethod_94();
			}
		}

		// Token: 0x060021B3 RID: 8627
		// RVA: 0x0001B23A File Offset: 0x0001943A
		protected override void vmethod_17(Class304 class304_2)
		{
			base.vmethod_17(class304_2);
		}

		// Token: 0x060021B1 RID: 8625
		// RVA: 0x0001B217 File Offset: 0x00019417
		internal override Class494 vmethod_7()
		{
			return new Class497(this);
		}
	}
}
