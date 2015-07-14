using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns26;
using ns29;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;

namespace ns69
{
	// Token: 0x020003B8 RID: 952
	internal sealed class Class409
	{
		// Token: 0x04001780 RID: 6016
		private bool bool_0;

		// Token: 0x04001781 RID: 6017
		private bool bool_1;

		// Token: 0x04001782 RID: 6018
		internal bool bool_2;

		// Token: 0x04001783 RID: 6019
		private bool bool_3;

		// Token: 0x0400178E RID: 6030
		[CompilerGenerated]
		private Class421 class421_0;

		// Token: 0x04001786 RID: 6022
		private Class531 class531_0;

		// Token: 0x04001787 RID: 6023
		private Class531 class531_1;

		// Token: 0x04001788 RID: 6024
		private Class533 class533_0;

		// Token: 0x04001789 RID: 6025
		private Class538 class538_0;

		// Token: 0x0400178B RID: 6027
		private Class538 class538_1;

		// Token: 0x0400178A RID: 6026
		private Class731[] class731_0;

		// Token: 0x04001784 RID: 6020
		private static readonly Color color_0 = new Color(250, 170, 212);

		// Token: 0x04001785 RID: 6021
		private static readonly Color color_1 = new Color(247, 236, 0);

		// Token: 0x0400178D RID: 6029
		private float float_0;

		// Token: 0x0400178F RID: 6031
		[CompilerGenerated]
		private float float_1;

		// Token: 0x04001790 RID: 6032
		[CompilerGenerated]
		private float float_2;

		// Token: 0x0400178C RID: 6028
		private int int_0;

		// Token: 0x0400177E RID: 6014
		private Keys keys_0;

		// Token: 0x0400177F RID: 6015
		private Keys keys_1;

		// Token: 0x17000366 RID: 870
		internal Keys Key
		{
			// Token: 0x06001D9B RID: 7579
			// RVA: 0x00018632 File Offset: 0x00016832
			get
			{
				return this.keys_0;
			}
			// Token: 0x06001D9C RID: 7580
			// RVA: 0x0001863A File Offset: 0x0001683A
			set
			{
				this.keys_0 = value;
				this.method_21();
			}
		}

		// Token: 0x06001DB1 RID: 7601
		// RVA: 0x000A1454 File Offset: 0x0009F654
		internal Class409(Class421 class421_1, int int_1, float float_3)
		{
			this.method_9(class421_1);
			this.int_0 = int_1;
			this.float_0 = float_3;
			float num = (int_1 > 0) ? (class421_1.class546_0.list_1[int_1 - 1] * float_3) : 0f;
			this.method_11(class421_1.method_23() + class421_1.float_0 + num);
			this.method_13(class421_1.class546_0.list_2[int_1] * float_3);
			class421_1.float_0 += this.method_12() + num;
			if (!class421_1.method_10())
			{
				float num2 = this.method_8().method_20() - Math.Abs(this.method_8().method_27() - this.method_8().method_30());
				if (class421_1.class546_0.list_0[int_1] > 0f)
				{
					this.method_20(new Class531(Class115.class731_0, Enum115.const_5, class421_1.method_45(Origins.BottomLeft), Enum114.const_1, new Vector2(0f, class421_1.method_30()), 0.61f, true, class421_1.class546_0.method_8("ColumnLine", Color.get_White()), null)
					{
						vector2_2 = new Vector2(0.74f * class421_1.class546_0.list_0[int_1], num2 * 1.6f)
					}, class421_1.class911_0);
				}
				this.method_20(new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0f, class421_1.Top), 0.6f, true, class421_1.class546_0.method_8((int_1 + 1).ToString(), Color.get_Black()), null)
				{
					vector2_2 = new Vector2(this.method_12(), class421_1.method_20()),
					float_2 = 1.6f
				}, class421_1.class911_0);
				if ((class421_1.class546_0.list_0[int_1 + 1] > 0f && Class885.class547_0.double_0 >= 2.4) || int_1 == class421_1.class546_0.method_6() - 1)
				{
					this.method_20(new Class531(Class115.class731_0, Enum115.const_5, class421_1.method_45(Origins.BottomLeft), Enum114.const_1, new Vector2(this.method_12() - ((int_1 == class421_1.class546_0.method_6() - 1) ? 0.1f : 0f), class421_1.method_30()), 0.61f, true, class421_1.class546_0.method_8("ColumnLine", Color.get_White()), null)
					{
						vector2_2 = new Vector2(0.74f * class421_1.class546_0.list_0[int_1 + 1], num2 * 1.6f)
					}, class421_1.class911_0);
				}
				Class911 class911_ = class421_1.class546_0.bool_3 ? class421_1.class911_0 : class421_1.class911_2;
				Class731 class = class421_1.class546_0.Load("KeyImage" + int_1, this.method_18(), class421_1.method_7());
				Class531 class2 = new Class531(class, Enum115.const_5, class421_1.method_45(Origins.BottomCentre), Enum114.const_1, new Vector2(this.method_12() / 2f, class421_1.method_27()), 0.92f, true, Color.get_White(), null);
				class2.vector2_2 = new Vector2(this.method_12() * 1.6f / (float)class.method_0(), class421_1.method_31());
				class2.method_43(class421_1.class546_0.method_10("Key", int_1, "", true));
				this.class531_0 = class2;
				this.method_20(this.class531_0, class911_);
				class = class421_1.class546_0.Load("KeyImage" + int_1 + "D", this.method_18() + "D", class421_1.method_7());
				Class531 class3 = new Class531(class, Enum115.const_5, class421_1.method_45(Origins.BottomCentre), Enum114.const_1, new Vector2(this.method_12() / 2f, class421_1.method_27()), 0.925f, true, Color.get_White(), null);
				class3.vector2_2 = new Vector2(this.method_12() * 1.6f / (float)class.method_0(), class421_1.method_31());
				class3.method_43(this.class531_0.method_42());
				class3.float_3 = 0f;
				this.class531_1 = class3;
				this.method_20(this.class531_1, class911_);
				this.class538_0 = new Class538(class421_1.class546_0.method_9("StageLight", "mania-stage-light", class421_1.method_7()), Enum115.const_5, class421_1.method_45(Origins.BottomLeft), Enum114.const_1, new Vector2(0f, class421_1.method_41((float)this.method_8().class546_0.int_1)), 0.72f, true, class421_1.class546_0.method_8("Light" + (int_1 + 1), Color.get_White()));
				this.class538_0.float_3 = 0f;
				this.class538_0.method_53((double)(1000f / (float)class421_1.class546_0.int_5));
				this.class538_0.bool_16 = false;
				this.class538_0.loopTypes_0 = LoopTypes.LoopForever;
				this.class538_0.vector2_2 = new Vector2(this.method_12() * 1.6f / (float)this.class538_0.int_6, class421_1.method_31());
				this.method_20(this.class538_0, class421_1.class911_0);
				this.class533_0 = new Class533("", this.method_12() / 2f, new Vector2(this.method_12() / 2f, class421_1.method_41(480f - (float)this.class531_0.int_1 / 1.6f / 2f)), 0.93f, true, class421_1.class546_0.method_8("KeyWarning", Color.get_Black()))
				{
					bool_16 = true,
					origins_0 = Origins.Centre,
					float_2 = class421_1.method_31()
				};
				this.method_20(this.class533_0, class421_1.class911_2);
				this.class731_0 = class421_1.class546_0.method_9("LightingN", "lightingN", class421_1.method_7());
				Class731[] array = class421_1.class546_0.method_9("LightingL", "lightingL", class421_1.method_7());
				if (array == null || array.Length == 0)
				{
					array = new Class731[this.class731_0.Length];
					this.class731_0.CopyTo(array, 0);
				}
				this.class538_1 = new Class538(array, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(this.method_12() / 2f, class421_1.method_30()), 0.98f, true, Color.get_White());
				this.class538_1.float_2 = this.method_8().class546_0.method_14(int_1) * float_3;
				this.class538_1.float_3 = 0f;
				this.class538_1.bool_7 = true;
				if (array != null)
				{
					this.class538_1.method_53((double)(170f / (float)array.Length));
				}
				this.method_20(this.class538_1, class421_1.class911_2);
			}
		}

		// Token: 0x06001D9D RID: 7581
		// RVA: 0x00018649 File Offset: 0x00016849
		internal Keys method_0()
		{
			return this.keys_1;
		}

		// Token: 0x06001D9E RID: 7582
		// RVA: 0x00018651 File Offset: 0x00016851
		internal void method_1(Keys keys_2)
		{
			this.keys_1 = keys_2;
			this.method_21();
		}

		// Token: 0x06001DA7 RID: 7591
		// RVA: 0x00018699 File Offset: 0x00016899
		[CompilerGenerated]
		internal float method_10()
		{
			return this.float_1;
		}

		// Token: 0x06001DA8 RID: 7592
		// RVA: 0x000186A1 File Offset: 0x000168A1
		[CompilerGenerated]
		private void method_11(float float_3)
		{
			this.float_1 = float_3;
		}

		// Token: 0x06001DA9 RID: 7593
		// RVA: 0x000186AA File Offset: 0x000168AA
		[CompilerGenerated]
		internal float method_12()
		{
			return this.float_2;
		}

		// Token: 0x06001DAA RID: 7594
		// RVA: 0x000186B2 File Offset: 0x000168B2
		[CompilerGenerated]
		private void method_13(float float_3)
		{
			this.float_2 = float_3;
		}

		// Token: 0x06001DAB RID: 7595
		// RVA: 0x000A1298 File Offset: 0x0009F498
		internal int method_14()
		{
			return (int)(((this.int_0 >= this.method_8().class546_0.method_6()) ? ((float)this.int_0 - 0.5f) : (0.5f + (float)this.int_0)) * (512f / (float)this.method_8().class546_0.method_6()));
		}

		// Token: 0x06001DAC RID: 7596
		// RVA: 0x000A12F4 File Offset: 0x0009F4F4
		internal Enum44 method_15()
		{
			int num = this.int_0 - this.method_8().method_0();
			bool flag = this.method_8().method_8() != Enum54.const_0 && this.method_8().method_35();
			Enum54 enum = this.method_8().method_8();
			int num2 = this.method_8().method_38();
			if (flag && enum == Enum54.const_2)
			{
				num2 = this.method_8().method_39() - 1;
			}
			else if (flag)
			{
				num2 = 0;
			}
			if (num == num2)
			{
				return Enum44.const_2;
			}
			if (flag)
			{
				if ((num % 2 == 1 && enum == Enum54.const_2) || (num % 2 == 0 && enum == Enum54.const_1))
				{
					return Enum44.const_1;
				}
			}
			else
			{
				int num3 = (int)Math.Floor((double)((float)this.method_8().method_39() / 2f));
				if ((this.method_8().method_39() % 2 == 1 && (num < num3 || num > num3) && num % 2 == 1) || (this.method_8().method_39() % 2 == 0 && ((num < num3 && num % 2 == 1) || (num >= num3 && num % 2 == 0))))
				{
					return Enum44.const_1;
				}
			}
			return Enum44.const_0;
		}

		// Token: 0x06001DAD RID: 7597
		// RVA: 0x000A13E4 File Offset: 0x0009F5E4
		internal Color method_16()
		{
			switch (this.method_15())
			{
			case Enum44.const_0:
				IL_19:
				return Color.get_White();
			case Enum44.const_1:
				return Class409.color_0;
			case Enum44.const_2:
				return Class409.color_1;
			}
			goto IL_19;
		}

		// Token: 0x06001DAE RID: 7598
		// RVA: 0x000A141C File Offset: 0x0009F61C
		internal string method_17()
		{
			switch (this.method_15())
			{
			case Enum44.const_0:
				IL_19:
				return "1";
			case Enum44.const_1:
				return "2";
			case Enum44.const_2:
				return "S";
			}
			goto IL_19;
		}

		// Token: 0x06001DAF RID: 7599
		// RVA: 0x000186BB File Offset: 0x000168BB
		internal string method_18()
		{
			return "mania-key" + this.method_17();
		}

		// Token: 0x06001DB0 RID: 7600
		// RVA: 0x000186CD File Offset: 0x000168CD
		internal string method_19()
		{
			return "mania-note" + this.method_17();
		}

		// Token: 0x06001D9F RID: 7583
		// RVA: 0x00018660 File Offset: 0x00016860
		internal int method_2()
		{
			return (int)Math.Pow(2.0, (double)this.int_0);
		}

		// Token: 0x06001DB3 RID: 7603
		// RVA: 0x000186E7 File Offset: 0x000168E7
		private void method_20(Class531 class531_2, Class911 class911_0)
		{
			class911_0.Add(class531_2);
			class531_2.vector2_1.X = this.method_10() + class531_2.vector2_1.X;
		}

		// Token: 0x06001DB4 RID: 7604
		// RVA: 0x000A1B28 File Offset: 0x0009FD28
		internal void method_21()
		{
			if (this.method_8().method_10())
			{
				return;
			}
			this.class533_0.Text = Class795.smethod_6(this.Key) + ((this.method_0() != null) ? ("\n" + Class795.smethod_6(this.method_0())) : string.Empty);
			this.class533_0.class26_0.Clear();
			this.class533_0.float_3 = 1f;
			if (!this.method_8().method_6())
			{
				this.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 500, Class115.int_1 + 3500, Enum70.const_0));
			}
		}

		// Token: 0x06001DB5 RID: 7605
		// RVA: 0x000A1BE8 File Offset: 0x0009FDE8
		internal void method_22()
		{
			Class538 class = new Class538(this.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_2, new Vector2(this.method_12() / 2f, this.method_8().method_30()), 0.98f, false, Color.get_White());
			class.float_2 = this.method_8().class546_0.method_13(this.int_0) * this.float_0;
			class.bool_7 = true;
			class.loopTypes_0 = LoopTypes.LoopOnce;
			if (this.class731_0 != null)
			{
				class.method_53((double)(170f / (float)this.class731_0.Length));
			}
			class.method_15(80);
			class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 80, Class331.int_7 + 200, Enum70.const_0));
			this.method_20(class, this.method_8().class911_2);
		}

		// Token: 0x06001DA0 RID: 7584
		// RVA: 0x00018678 File Offset: 0x00016878
		internal bool method_3()
		{
			return this.bool_0;
		}

		// Token: 0x06001DA1 RID: 7585
		// RVA: 0x000A0EEC File Offset: 0x0009F0EC
		internal void method_4(bool bool_4)
		{
			if (this.bool_0 == bool_4)
			{
				return;
			}
			this.bool_0 = bool_4;
			if (this.method_3())
			{
				this.class538_1.method_59();
				this.class538_1.method_14(80, Enum70.const_0);
				return;
			}
			this.class538_1.method_16(120, Enum70.const_0);
		}

		// Token: 0x06001DA2 RID: 7586
		// RVA: 0x00018680 File Offset: 0x00016880
		internal bool method_5()
		{
			return this.bool_3;
		}

		// Token: 0x06001DA3 RID: 7587
		// RVA: 0x000A0F3C File Offset: 0x0009F13C
		internal void method_6(bool bool_4)
		{
			this.bool_2 = this.bool_3;
			if (this.bool_3 == bool_4)
			{
				return;
			}
			this.bool_3 = bool_4;
			if (this.method_8().method_10())
			{
				return;
			}
			if (this.bool_3)
			{
				this.class531_1.method_14(0, Enum70.const_0);
				this.class531_0.method_16(0, Enum70.const_0);
				this.class538_0.method_59();
				this.class538_0.bool_16 = true;
				this.class538_0.vmethod_7(this.class538_0.method_54()[0]);
				this.class538_0.class26_0.Clear();
				this.class538_0.float_3 = 1f;
				this.class538_0.vector2_2.Y = (this.method_8().method_26() ? (-this.method_8().method_31()) : this.method_8().method_31());
				return;
			}
			this.class531_1.class26_0.Clear();
			this.class531_1.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 80, Class331.int_7 + 80, Enum70.const_0));
			this.class531_0.class26_0.Clear();
			this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7 + 80, Class331.int_7 + 80, Enum70.const_0));
			int num = (int)(400.0 * (100.0 / Class331.smethod_11()));
			this.class538_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7, Class331.int_7 + num, Enum70.const_0));
			this.class538_0.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(this.class538_0.vector2_2.X, this.method_8().method_26() ? (-this.method_8().method_31()) : this.method_8().method_31()), new Vector2(this.class538_0.vector2_2.X, 0f), Class331.int_7, Class331.int_7 + num, Enum70.const_0));
		}

		// Token: 0x06001DA4 RID: 7588
		// RVA: 0x000A1168 File Offset: 0x0009F368
		internal void method_7()
		{
			bool flag = false;
			if (!this.bool_1)
			{
				if (this.Key > 300)
				{
					flag = Class569.list_0.Contains(this.Key);
				}
				else
				{
					flag = Class570.smethod_9(this.Key);
				}
				if (this.method_8().method_38() == this)
				{
					if (this.method_0() > 300)
					{
						flag |= Class569.list_0.Contains(this.method_0());
					}
					else
					{
						flag |= Class570.smethod_9(this.method_0());
					}
				}
			}
			if (Class802.smethod_4() && Class802.smethod_5().Count > 0)
			{
				for (int i = 0; i < Class802.smethod_5().Count; i++)
				{
					Vector2 vector = Class802.smethod_5()[i];
					if (vector.X > this.method_10() && vector.X < this.method_10() + this.method_12() && vector.Y > this.method_8().Top && vector.Y < this.method_8().method_25())
					{
						this.bool_1 = true;
						flag = true;
					}
					else
					{
						this.bool_1 = false;
					}
				}
			}
			else
			{
				this.bool_1 = false;
			}
			this.method_6(flag);
		}

		// Token: 0x06001DA5 RID: 7589
		// RVA: 0x00018688 File Offset: 0x00016888
		[CompilerGenerated]
		internal Class421 method_8()
		{
			return this.class421_0;
		}

		// Token: 0x06001DA6 RID: 7590
		// RVA: 0x00018690 File Offset: 0x00016890
		[CompilerGenerated]
		private void method_9(Class421 class421_1)
		{
			this.class421_0 = class421_1;
		}

		// Token: 0x06001DB2 RID: 7602
		// RVA: 0x000186DF File Offset: 0x000168DF
		public static implicit operator int(Class409 class409_0)
		{
			return class409_0.int_0;
		}
	}
}
