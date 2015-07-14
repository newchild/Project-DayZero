using ns23;
using ns26;
using ns70;
using System;

namespace ns59
{
	// Token: 0x0200041E RID: 1054
	internal abstract class Class305 : Class304
	{
		// Token: 0x04001A82 RID: 6786
		internal Enum61 enum61_0;

		// Token: 0x060021EB RID: 8683
		// RVA: 0x0001B4BA File Offset: 0x000196BA
		protected Class305(Class297 class297_1) : base(class297_1)
		{
		}

		// Token: 0x060021EC RID: 8684
		// RVA: 0x000C87A8 File Offset: 0x000C69A8
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			int int_ = Class331.int_7;
			int num = Math.Abs(int_ - this.StartTime);
			if (num < this.class297_0.HitWindow300)
			{
				this.enum61_0 = Enum61.flag_16;
			}
			else if (num < this.class297_0.HitWindow100)
			{
				this.enum61_0 = Enum61.flag_15;
			}
			else if (num < this.class297_0.HitWindow50)
			{
				this.enum61_0 = Enum61.flag_14;
			}
			else
			{
				this.enum61_0 = Enum61.flag_3;
			}
			if (this.enum61_0 > Enum61.flag_5)
			{
				this.vmethod_12();
			}
			this.vmethod_8(this.enum61_0 > Enum61.flag_5);
			return this.enum61_0;
		}
	}
}
