using ns18;
using ns22;
using ns23;
using ns26;
using ns59;
using ns70;
using ns76;
using ns80;
using osu_common;
using System;

namespace ns71
{
	// Token: 0x020003DA RID: 986
	internal sealed class Class430 : Class429
	{
		// Token: 0x06001FAA RID: 8106
		// RVA: 0x00019E31 File Offset: 0x00018031
		public Class430(Class62 class62_1) : base(class62_1)
		{
		}

		// Token: 0x06001FAC RID: 8108
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_20()
		{
		}

		// Token: 0x06001FAD RID: 8109
		// RVA: 0x00019E45 File Offset: 0x00018045
		internal override void vmethod_33()
		{
			if (Class331.bool_0 && Class331.int_7 > this.class62_0.int_25)
			{
				Class331.smethod_59("count", 100, Enum112.flag_5);
			}
			base.vmethod_33();
		}

		// Token: 0x06001FAE RID: 8110
		// RVA: 0x000B4348 File Offset: 0x000B2548
		internal override void vmethod_41(Enum61 enum61_0, Class304 class304_0)
		{
			Enum61 enum = enum61_0;
			if (enum > Enum61.flag_5)
			{
				enum &= Enum61.flag_39;
			}
			if (enum61_0 >= Enum61.flag_5)
			{
				Class512 arg_7F_0 = this.class512_0;
				int arg_7A_0 = this.class512_0.int_0;
				Class413 expr_6A = this.class413_0;
				int val;
				expr_6A.vmethod_1(val = expr_6A.vmethod_0() + 1);
				arg_7F_0.int_0 = Math.Max(arg_7A_0, val);
				this.class512_0.ushort_6 = (ushort)this.class413_0.vmethod_0();
				Class513 class = this.class512_0 as Class513;
				float float_ = ((Class307)class304_0).float_0;
				class.float_0 += float_;
				int num = 0;
				Enum61 enum2 = enum;
				if (enum2 != Enum61.flag_14)
				{
					switch (enum2)
					{
					case Enum61.flag_15:
					case Enum61.flag_18:
					case Enum61.flag_20:
					{
						num = 100;
						Class512 expr_133 = this.class512_0;
						expr_133.ushort_0 += 1;
						break;
					}
					default:
						switch (enum2)
						{
						case Enum61.flag_16:
						case Enum61.flag_19:
						case Enum61.flag_21:
						case Enum61.flag_22:
						{
							num = 300;
							Class512 expr_119 = this.class512_0;
							expr_119.ushort_1 += 1;
							break;
						}
						}
						break;
					}
				}
				else
				{
					num = 50;
					Class512 expr_14D = this.class512_0;
					expr_14D.ushort_2 += 1;
				}
				class304_0.int_5 = num;
				this.class512_0.int_3 += (int)((double)(float_ * (float)num) * Class331.smethod_11() / 120.0);
				return;
			}
			if (Class876.smethod_5(Mods.NoFail))
			{
				Class512 arg_2D_0 = this.class512_0;
				this.class413_0.vmethod_1(0);
				arg_2D_0.ushort_6 = 0;
				Class512 expr_38 = this.class512_0;
				expr_38.ushort_5 += 1;
				return;
			}
			this.class62_0.method_63();
		}

		// Token: 0x06001FAB RID: 8107
		// RVA: 0x00019E3A File Offset: 0x0001803A
		internal override double vmethod_52()
		{
			return 0.0;
		}
	}
}
