using ns29;
using ns79;
using ns9;
using System;

namespace ns17
{
	// Token: 0x0200039D RID: 925
	internal class Class61 : Class55
	{
		// Token: 0x040016B5 RID: 5813
		internal Class911 class911_0 = new Class911(true);

		// Token: 0x06001C91 RID: 7313
		// RVA: 0x0001780B File Offset: 0x00015A0B
		public Class61(Class114 class114_1) : base((class114_1 == null) ? Class115.class115_0 : class114_1)
		{
		}

		// Token: 0x06001C93 RID: 7315
		// RVA: 0x00017837 File Offset: 0x00015A37
		public override void Draw()
		{
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x06001C94 RID: 7316
		// RVA: 0x0001784B File Offset: 0x00015A4B
		public override void imethod_2()
		{
			base.imethod_2();
		}

		// Token: 0x06001C92 RID: 7314
		// RVA: 0x0001782A File Offset: 0x00015A2A
		public override void Initialize()
		{
			base.Initialize();
			Class115.smethod_73();
		}
	}
}
