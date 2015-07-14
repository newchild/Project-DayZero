using ns18;
using ns26;
using ns27;
using ns5;
using ns79;
using ns82;
using ns9;
using System;

namespace ns22
{
	// Token: 0x020003BF RID: 959
	internal sealed class Class107 : Class54
	{
		// Token: 0x040017AA RID: 6058
		private Class883 class883_0;

		// Token: 0x040017AB RID: 6059
		private Class883 class883_1;

		// Token: 0x040017A9 RID: 6057
		private readonly Class911 class911_0;

		// Token: 0x040017AC RID: 6060
		private int? nullable_0;

		// Token: 0x06001DD8 RID: 7640
		// RVA: 0x000188CE File Offset: 0x00016ACE
		protected override void Dispose(bool bool_1)
		{
			this.class911_0.Dispose();
			this.class883_0.Dispose();
			base.Dispose(bool_1);
		}

		// Token: 0x06001DDA RID: 7642
		// RVA: 0x000188F5 File Offset: 0x00016AF5
		internal void Draw()
		{
			if (Class802.smethod_0() && Class72.class10_0 == null && !Class62.bool_16)
			{
				this.class911_0.Draw();
				return;
			}
		}

		// Token: 0x06001DDB RID: 7643
		// RVA: 0x000A2C1C File Offset: 0x000A0E1C
		public override void imethod_2()
		{
			base.imethod_2();
			this.class883_0.SetValue((double)((float)Class331.int_7 / (float)Class331.smethod_31()), true);
			if (!this.nullable_0.HasValue)
			{
				this.class883_1.SetValue(this.class883_0.double_1, true);
				return;
			}
			int value = this.nullable_0.Value;
			int num = Math.Abs(value - Class331.int_7);
			if (num < 100)
			{
				if (Class331.smethod_71() && Class62.bool_8)
				{
					return;
				}
				Class331.smethod_73(1f);
				this.nullable_0 = null;
				return;
			}
			else
			{
				if (value > Class331.int_7)
				{
					Class331.smethod_73(Math.Min(10f, 0.8f + (float)num / 2000f));
					return;
				}
				Class331.smethod_73(Math.Max(-10f, -0.2f - (float)num / 2000f));
				return;
			}
		}

		// Token: 0x06001DD9 RID: 7641
		// RVA: 0x000188ED File Offset: 0x00016AED
		public override void Initialize()
		{
			base.Initialize();
		}
	}
}
