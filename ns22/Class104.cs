using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns29;
using ns70;
using ns79;
using ns9;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020003BC RID: 956
	internal sealed class Class104 : Class103
	{
		// Token: 0x040017A3 RID: 6051
		protected Class531[] class531_0;

		// Token: 0x040017A4 RID: 6052
		protected int int_2;

		// Token: 0x06001DC9 RID: 7625
		// RVA: 0x00018848 File Offset: 0x00016A48
		internal Class104(Class114 class114_1, Class297 class297_1) : base(class114_1, class297_1)
		{
		}

		// Token: 0x06001DCA RID: 7626
		// RVA: 0x000A2278 File Offset: 0x000A0478
		internal override void Initialize()
		{
			float num = (float)(Class115.smethod_43() / 3) * this.vmethod_0();
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomLeft, Enum114.const_1, new Vector2(((float)Class115.smethod_43() - num) / 2f, 480f), 0.8f, true, Color.get_Black(), null);
			class.float_3 = 0.6f;
			class.vector2_2 = new Vector2(num, this.method_2() + 1f) * 1.6f;
			this.class911_0.Add(class);
			int num2 = (int)(num / (this.method_2() + 1f));
			float num3 = (num - (float)num2 * this.method_2() - (float)(num2 - 1)) * 1f / (float)(num2 - 1);
			if (Class115.bool_16)
			{
				num3 *= 3f;
			}
			this.class531_0 = new Class531[num2];
			float num4 = ((float)Class115.smethod_43() - num) / 2f;
			for (int i = 0; i < num2; i++)
			{
				Class531 class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomLeft, Enum114.const_1, new Vector2(num4, 480f), 0.9f, true, Color.get_Black(), null);
				class2.vector2_2 = new Vector2(this.method_2(), this.method_2()) * 1.6f;
				this.class911_0.Add(class2);
				this.class531_0[i] = class2;
				num4 += this.method_2() + 1f + num3;
			}
		}

		// Token: 0x06001DC8 RID: 7624
		// RVA: 0x0001883A File Offset: 0x00016A3A
		protected float method_2()
		{
			return 9f * this.vmethod_0();
		}

		// Token: 0x06001DCB RID: 7627
		// RVA: 0x000A23DC File Offset: 0x000A05DC
		internal void Reset()
		{
			Class531[] array = this.class531_0;
			for (int i = 0; i < array.Length; i++)
			{
				Class531 class = array[i];
				class.float_3 -= 0.08f;
			}
		}

		// Token: 0x06001DCC RID: 7628
		// RVA: 0x000A2414 File Offset: 0x000A0614
		internal override void vmethod_1(Enum61 enum61_0)
		{
			this.int_1 = Class331.int_7 + 4000;
			base.method_1();
			Color color_;
			if (enum61_0 < Enum61.flag_5)
			{
				color_..ctor(255, 9, 9);
			}
			else
			{
				Enum61 enum = enum61_0 & ~(Enum61.flag_28 | Enum61.flag_31 | Enum61.flag_32);
				if (enum <= Enum61.flag_27)
				{
					if (enum <= Enum61.flag_20)
					{
						if (enum != Enum61.flag_10)
						{
							switch (enum)
							{
							case Enum61.flag_14:
							case Enum61.flag_17:
								break;
							default:
								switch (enum)
								{
								case Enum61.flag_15:
								case Enum61.flag_18:
								case Enum61.flag_20:
									goto IL_BA;
								default:
									return;
								}
								break;
							}
						}
						color_ = this.color_2;
						goto IL_178;
					}
					switch (enum)
					{
					case Enum61.flag_16:
					case Enum61.flag_19:
					case Enum61.flag_21:
					case Enum61.flag_22:
						goto IL_FA;
					case Enum61.flag_6 | Enum61.flag_7 | Enum61.flag_16:
						return;
					default:
						if (enum != Enum61.flag_23)
						{
							if (enum != Enum61.flag_27)
							{
								return;
							}
							goto IL_FA;
						}
						break;
					}
					IL_BA:
					color_ = this.color_1;
					goto IL_178;
				}
				if (enum <= Enum61.flag_33)
				{
					if (enum != Enum61.flag_29 && enum != Enum61.flag_30)
					{
						if (enum != Enum61.flag_33)
						{
							return;
						}
						color_..ctor(109, 120, 135);
						goto IL_178;
					}
				}
				else if (enum <= Enum61.flag_35)
				{
					if (enum == Enum61.flag_34)
					{
						color_..ctor(31, 104, 198);
						goto IL_178;
					}
					if (enum != Enum61.flag_35)
					{
						return;
					}
					color_..ctor(121, 208, 32);
					goto IL_178;
				}
				else
				{
					if (enum == Enum61.flag_36)
					{
						color_..ctor(255, 209, 55);
						goto IL_178;
					}
					if (enum != Enum61.flag_37)
					{
						return;
					}
					color_..ctor(255, 133, 0);
					goto IL_178;
				}
				IL_FA:
				color_ = this.color_0;
			}
			IL_178:
			if (this.int_2 >= this.class531_0.Length)
			{
				this.int_2 = 0;
			}
			this.Reset();
			this.class531_0[this.int_2].color_0 = color_;
			this.class531_0[this.int_2].float_3 = 1f;
			this.int_2++;
		}
	}
}
