using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns22;
using ns23;
using ns24;
using ns26;
using ns29;
using ns3;
using ns59;
using ns60;
using ns63;
using ns64;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns89;
using osu;
using osu.GameModes.Play.Components;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns72
{
	// Token: 0x02000509 RID: 1289
	internal sealed class Class431 : Class427
	{
		// Token: 0x0200050A RID: 1290
		[CompilerGenerated]
		private sealed class Class678
		{
			// Token: 0x0400226F RID: 8815
			public Class316 class316_0;

			// Token: 0x06002995 RID: 10645
			// RVA: 0x0001FF15 File Offset: 0x0001E115
			public bool method_0(Class316 class316_1)
			{
				return Vector2.DistanceSquared(class316_1.vector2_1, this.class316_0.vector2_1) < 100f;
			}
		}

		// Token: 0x04002261 RID: 8801
		private bool bool_2;

		// Token: 0x04002264 RID: 8804
		private bool bool_3;

		// Token: 0x04002265 RID: 8805
		internal bool bool_4;

		// Token: 0x04002267 RID: 8807
		internal bool bool_5;

		// Token: 0x04002268 RID: 8808
		internal bool bool_6;

		// Token: 0x04002269 RID: 8809
		private bool bool_7;

		// Token: 0x04002263 RID: 8803
		private Class304 class304_0;

		// Token: 0x0400225A RID: 8794
		private Class416 class416_0;

		// Token: 0x04002256 RID: 8790
		private Class538 class538_0;

		// Token: 0x04002266 RID: 8806
		private Class623<float> class623_0;

		// Token: 0x0400225B RID: 8795
		private Class731[] class731_1;

		// Token: 0x0400225C RID: 8796
		private Class731[] class731_2;

		// Token: 0x0400225D RID: 8797
		private Class731[] class731_3;

		// Token: 0x04002257 RID: 8791
		private float float_0;

		// Token: 0x04002258 RID: 8792
		internal float float_1;

		// Token: 0x04002259 RID: 8793
		private float float_2;

		// Token: 0x0400225E RID: 8798
		internal float float_3;

		// Token: 0x0400225F RID: 8799
		private float float_4 = 1f;

		// Token: 0x04002260 RID: 8800
		private int int_4;

		// Token: 0x04002262 RID: 8802
		private int int_5;

		// Token: 0x0400226B RID: 8811
		private int int_6;

		// Token: 0x04002254 RID: 8788
		private readonly List<Class316> list_0 = new List<Class316>();

		// Token: 0x04002255 RID: 8789
		private readonly List<Class531> list_1 = new List<Class531>();

		// Token: 0x0400226C RID: 8812
		[CompilerGenerated]
		private static Predicate<Class304> predicate_1;

		// Token: 0x0400226D RID: 8813
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x0400226E RID: 8814
		[CompilerGenerated]
		private static Predicate<Class531> predicate_3;

		// Token: 0x0400226A RID: 8810
		private Vector2 vector2_1;

		// Token: 0x0600296D RID: 10605
		// RVA: 0x0001FD4A File Offset: 0x0001DF4A
		internal Class431(Class62 class62_1) : base(class62_1)
		{
		}

		// Token: 0x06002981 RID: 10625
		// RVA: 0x0010608C File Offset: 0x0010428C
		private void method_10()
		{
			Class531 class = new Class531(this.class538_0.vmethod_6(), Enum115.const_0, Origins.Centre, Enum114.const_0, this.class538_0.vector2_1 + new Vector2(0f, (float)this.class538_0.int_1 * 0.18f), 0.84f, false, Class885.smethod_3().method_1(), null);
			class.method_45(this.class538_0.method_44());
			class.bool_7 = true;
			class.float_2 = 0.71f;
			class.method_16(1200, Enum70.const_0);
			class.class26_0.Add(new Class746(TransformationType.Scale, class.float_2, class.float_2 * 1.2f, Class115.int_1, Class115.int_1 + 1200, Enum70.const_2));
			this.class297_0.class911_0.Add(class);
		}

		// Token: 0x06002985 RID: 10629
		// RVA: 0x00106774 File Offset: 0x00104974
		private void method_11(Class304 class304_1)
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				return;
			}
			float num = Class778.smethod_2(((Class316)class304_1).vector2_1.X, -this.float_1 + this.float_2 * 3f, this.float_1 - this.float_2 * 3f);
			if (!(class304_1 is Class319))
			{
				float num2 = Class778.smethod_2((float)this.class413_0.vmethod_0() / 200f, 0.35f, 1.125f);
				Class531 class = new Class531(Class885.Load("scoreboard-explosion-2", Enum112.flag_1), Enum115.const_0, Origins.CentreLeft, Enum114.const_0, class304_1.Position, 0.99f, false, class304_1.Colour, null);
				class.float_1 = -1.57079637f;
				class.method_16(300, Enum70.const_0);
				class.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(1f, 0.9f), new Vector2(16f * num2, 1.1f), Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
				this.class911_2.Add(class);
				class.bool_3 = true;
				class.vector2_0 = new Vector2(num, 0f);
				this.list_1.Add(class);
			}
			Class531 class2 = new Class531(Class885.Load("scoreboard-explosion-1", Enum112.flag_1), Enum115.const_0, Origins.CentreLeft, Enum114.const_0, class304_1.Position, 1f, false, class304_1.Colour, null);
			class2.float_1 = -1.57079637f;
			this.class911_2.Add(class2);
			class2.method_16(700, Enum70.const_0);
			class2.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(0.9f, 1f), new Vector2(0.9f, 1.3f), Class115.int_1, Class115.int_1 + 500, Enum70.const_1));
			class2.bool_3 = true;
			class2.vector2_0 = new Vector2(num, 0f);
			this.list_1.Add(class2);
		}

		// Token: 0x06002986 RID: 10630
		// RVA: 0x00106960 File Offset: 0x00104B60
		private void method_12(bool bool_8)
		{
			if (!this.class297_0.list_3[this.class297_0.int_13].LastInCombo)
			{
				return;
			}
			if (this.class297_0.class304_0 is Class317)
			{
				foreach (Class316 current in this.list_0)
				{
					this.method_13(current, true);
				}
				((Class317)this.class297_0.class304_0).method_10();
				Class531 class = new Class531(Class885.Load("scoreboard-explosion-1", Enum112.flag_1), Enum115.const_0, Origins.CentreLeft, Enum114.const_0, Vector2.get_Zero(), 0.99f, false, Color.get_White(), null);
				class.float_1 = -1.57079637f;
				class.method_16(800, Enum70.const_0);
				class.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(0f, 1.8f), new Vector2(4f, 2.2f), Class115.int_1, Class115.int_1 + 500, Enum70.const_1));
				class.bool_3 = true;
				this.list_1.Add(class);
				this.class911_2.Add(class);
			}
			else
			{
				if (bool_8)
				{
					using (List<Class316>.Enumerator enumerator2 = this.list_0.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Class316 current2 = enumerator2.Current;
							this.method_13(current2, false);
						}
						goto IL_1F9;
					}
				}
				foreach (Class316 current3 in this.list_0)
				{
					foreach (Class531 current4 in current3.list_1)
					{
						Class115.class729_0.Add(current4, null, false);
						current4.method_16(1000, Enum70.const_0);
						current4.bool_0 = false;
					}
				}
			}
			IL_1F9:
			this.list_0.Clear();
		}

		// Token: 0x06002987 RID: 10631
		// RVA: 0x00106BA8 File Offset: 0x00104DA8
		private void method_13(Class316 class316_0, bool bool_8)
		{
			Vector2 value;
			value..ctor(class316_0.vector2_1.X * 4f, (float)(bool_8 ? -400 : -120));
			foreach (Class531 current in class316_0.list_1)
			{
				current.bool_0 = false;
				current.method_16(2000, Enum70.const_0);
				Class115.class729_0.Add(current, new Vector2?(value), false);
			}
		}

		// Token: 0x0600298E RID: 10638
		// RVA: 0x001071E4 File Offset: 0x001053E4
		internal double method_14()
		{
			double num = 0.05;
			double num2 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 195.0, 160.0, 60.0);
			double num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 170.0, 80.0);
			double num4 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 180.0, 80.0);
			double num5 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 8.0, 4.0, 0.0);
			while (true)
			{
				IL_394:
				this.int_1 = 0;
				this.class410_0.Reset();
				this.class413_0.vmethod_1(0);
				Class62.class512_0.int_3 = 0;
				double num6 = this.class410_0.method_2();
				int num7 = this.class297_0.list_3[0].StartTime - this.class297_0.PreEmpt;
				bool flag = false;
				int num8 = 0;
				int count = this.class62_0.class872_0.list_0.Count;
				int num9 = 0;
				int i = 0;
				while (i < this.class297_0.int_14)
				{
					Class304 class = this.class297_0.list_3[i];
					int num10 = num7;
					int num11 = 0;
					if (count > 0 && num9 < count)
					{
						Class702 class2 = this.class62_0.class872_0.list_0[num9];
						if (class2.int_2 >= num10 && class2.int_0 <= class.StartTime)
						{
							num11 = class2.Length;
							num9++;
						}
					}
					this.class410_0.vmethod_11(num * (double)(class.StartTime - num7 - num11));
					num7 = class.EndTime;
					if (this.class410_0.method_2() < num6)
					{
						num6 = this.class410_0.method_2();
					}
					if (this.class410_0.method_2() > num2)
					{
						if (class is Class319)
						{
							this.vmethod_41(Enum61.flag_23, class);
						}
						else if (class is Class318)
						{
							this.vmethod_41(Enum61.flag_10, class);
						}
						else if (class is Class317)
						{
							this.class410_0.vmethod_12(this.double_1 / 2.0);
						}
						else if (i != this.class297_0.int_14 - 1 && !this.class297_0.list_3[i + 1].NewCombo)
						{
							this.vmethod_41(Enum61.flag_16, class);
						}
						else
						{
							this.vmethod_41(Enum61.flag_22, class);
							if (this.class410_0.method_2() < num3 && ++num8 > 2)
							{
								this.double_0 *= 1.07;
								this.double_1 *= 1.03;
								flag = true;
								break;
							}
						}
						if (!(class is Class318) && !(class is Class317))
						{
							this.int_1++;
						}
						class.double_0 = this.class410_0.method_2();
						i++;
						continue;
					}
					flag = true;
					num *= 0.96;
					IL_2D7:
					if (!flag && this.class410_0.method_2() < num4)
					{
						flag = true;
						num *= 0.94;
						this.double_0 *= 1.01;
						this.double_1 *= 1.01;
					}
					double num12 = (this.class410_0.method_4() - 200.0) / (double)this.class297_0.int_14;
					if (!flag && num12 < num5)
					{
						flag = true;
						num *= 0.96;
						this.double_0 *= 1.02;
						this.double_1 *= 1.01;
					}
					if (flag)
					{
						goto IL_394;
					}
					goto IL_416;
				}
				goto IL_2D7;
			}
			IL_416:
			if (Class115.bool_25)
			{
				Class63 class3 = this.class62_0 as Class63;
				if (class3 != null)
				{
					class3.int_38 = Class62.class512_0.int_3;
					class3.int_37 = this.class413_0.vmethod_0();
				}
			}
			return num;
		}

		// Token: 0x06002991 RID: 10641
		// RVA: 0x0001FECD File Offset: 0x0001E0CD
		[CompilerGenerated]
		private void method_15(Class316 class316_0)
		{
			class316_0.vmethod_5(this.class538_0.vector2_1 + class316_0.vector2_1, false);
		}

		// Token: 0x06002992 RID: 10642
		// RVA: 0x0001FEEC File Offset: 0x0001E0EC
		[CompilerGenerated]
		private void method_16(Class531 class531_2)
		{
			class531_2.vector2_1 = this.class538_0.vector2_1 + class531_2.vector2_0;
		}

		// Token: 0x06002979 RID: 10617
		// RVA: 0x00105914 File Offset: 0x00103B14
		private void method_6()
		{
			Class302 class = this.class297_0 as Class302;
			class.method_34(this.float_0);
		}

		// Token: 0x0600297C RID: 10620
		// RVA: 0x001059C4 File Offset: 0x00103BC4
		private void method_7(Class316 class316_0)
		{
			if (class316_0.method_8())
			{
				Class304 class = class316_0.class304_0;
				float num = Math.Abs(class.Position.X - this.class538_0.vector2_1.X);
				float num2 = Math.Max(1f, (float)(class.StartTime - Class331.int_7) - 16.666666f);
				this.method_10();
				this.float_4 = num / num2;
				this.int_4 = ((class.Position.X > this.class538_0.vector2_1.X) ? 1 : -1);
				this.class304_0 = class316_0.class304_0;
			}
		}

		// Token: 0x0600297D RID: 10621
		// RVA: 0x0001FE37 File Offset: 0x0001E037
		private void method_8()
		{
			this.float_4 = 1f;
			this.int_4 = 0;
			this.bool_3 = false;
		}

		// Token: 0x06002980 RID: 10624
		// RVA: 0x00105F10 File Offset: 0x00104110
		private void method_9()
		{
			if (this.bool_7 != (this.float_4 != 1f) && !Class876.smethod_5(Mods.Cinema))
			{
				this.bool_7 = (this.float_4 != 1f);
				this.class538_0.method_39(this.bool_7 ? Class885.smethod_3().color_0 : Color.get_White(), 100, false, Enum70.const_0);
				if (this.class62_0.class872_0.class702_0 != null && this.class62_0.class872_0.class702_0.class531_0 != null)
				{
					this.class62_0.class872_0.class702_0.class531_0.method_39(this.bool_7 ? new Color(100, 100, 100) : Color.get_White(), 100, false, Enum70.const_0);
				}
			}
			if (this.float_4 != 1f && this.class304_0 != null && ((this.int_4 > 0 && this.class538_0.vector2_1.X >= this.class304_0.Position.X) || (this.int_4 < 0 && this.class538_0.vector2_1.X <= this.class304_0.Position.X)))
			{
				this.class538_0.vector2_1.X = this.class304_0.Position.X;
				this.method_8();
				this.bool_3 = true;
				this.method_10();
			}
		}

		// Token: 0x0600298F RID: 10639
		// RVA: 0x0001FEA9 File Offset: 0x0001E0A9
		[CompilerGenerated]
		private static bool smethod_2(Class304 class304_1)
		{
			return !(class304_1 is Class317);
		}

		// Token: 0x06002990 RID: 10640
		// RVA: 0x0001FEB7 File Offset: 0x0001E0B7
		[CompilerGenerated]
		private static bool smethod_3(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement || class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002993 RID: 10643
		// RVA: 0x0001FF0A File Offset: 0x0001E10A
		[CompilerGenerated]
		private static bool smethod_4(Class531 class531_2)
		{
			return !class531_2.bool_3;
		}

		// Token: 0x0600296E RID: 10606
		// RVA: 0x0001FD74 File Offset: 0x0001DF74
		internal override Vector2 vmethod_0()
		{
			return new Vector2(0f, 100f);
		}

		// Token: 0x06002974 RID: 10612
		// RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		internal override bool vmethod_12()
		{
			return Class62.bool_12 || base.vmethod_12() || Class802.smethod_0();
		}

		// Token: 0x06002978 RID: 10616
		// RVA: 0x0001FDDB File Offset: 0x0001DFDB
		protected override void vmethod_17()
		{
			if (Class341.class605_7 != ScoreMeterType.None)
			{
				this.class103_0 = new Class104(Class115.class115_0, this.class297_0);
			}
		}

		// Token: 0x06002977 RID: 10615
		// RVA: 0x00105854 File Offset: 0x00103A54
		internal override void vmethod_22()
		{
			this.int_1 = this.class297_0.int_14;
			this.float_3 = (Class876.smethod_6(this.class512_0.class623_0, Mods.HalfTime) ? 0.75f : (Class876.smethod_6(this.class512_0.class623_0, Mods.DoubleTime) ? 1.5f : 1f));
			this.class410_0.double_1 = this.method_14();
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
			{
				this.class410_0.double_1 *= 0.75;
			}
			this.method_6();
			base.vmethod_22();
		}

		// Token: 0x0600297E RID: 10622
		// RVA: 0x00105A68 File Offset: 0x00103C68
		internal override void vmethod_26()
		{
			this.class731_1 = Class885.smethod_27("fruit-catcher-idle", Enum112.flag_6, true);
			if (this.class731_1 != null && Class885.class547_0.double_0 >= 2.3)
			{
				this.class731_2 = Class885.smethod_27("fruit-catcher-fail", Enum112.flag_6, true);
				this.class731_3 = Class885.smethod_27("fruit-catcher-kiai", Enum112.flag_6, true);
			}
			else
			{
				this.class731_1 = (this.class731_2 = (this.class731_3 = Class885.smethod_27("fruit-ryuuta", Enum112.flag_6, true)));
			}
			this.class538_0 = new Class538(this.class731_1, Enum115.const_0, Origins.Custom, Enum114.const_0, new Vector2(256f, 340f), 0.81f, true, Color.get_White());
			this.class538_0.method_61();
			this.class538_0.vector2_5 = new Vector2((float)(this.class538_0.int_4 / 2), 16f);
			this.class538_0.float_2 = 0.7f;
			this.class623_0 = this.class538_0.vector2_1.X;
			this.class297_0.class911_0.Add(this.class538_0);
			this.float_0 = 305f / Class115.float_1 * this.class297_0.float_0 * 0.7f;
			this.float_1 = this.float_0 / 2f;
			this.float_2 = this.float_0 * 0.1f;
			if (Class341.class606_12)
			{
				if (Class885.class547_0.double_0 >= 2.3)
				{
					this.class731_0 = Class885.smethod_27("comboburst-fruits", Enum112.flag_6, true);
				}
				if (this.class731_0 == null)
				{
					this.class731_0 = Class885.smethod_27("comboburst", Enum112.flag_6, true);
				}
			}
			base.vmethod_26();
		}

		// Token: 0x06002989 RID: 10633
		// RVA: 0x0001FE82 File Offset: 0x0001E082
		internal override Class297 vmethod_27()
		{
			return new Class302(true);
		}

		// Token: 0x0600298A RID: 10634
		// RVA: 0x0001FE8A File Offset: 0x0001E08A
		internal override void vmethod_28()
		{
			this.class416_0 = new Class416(this.class911_1);
			this.class413_0 = this.class416_0;
		}

		// Token: 0x0600298D RID: 10637
		// RVA: 0x00106EF8 File Offset: 0x001050F8
		internal override void vmethod_29()
		{
			Class802.class512_0.list_1 = new List<Class14>();
			List<Class14> list = Class802.class512_0.list_1;
			list.Add(new Class14(-100000, 256f, 490f, pButtonState.None));
			float num = this.float_3 * 0.5f;
			float num2 = this.float_3;
			float num3 = 256f;
			int num4 = 0;
			for (int i = 0; i < this.class297_0.int_14; i++)
			{
				Class304 class = this.class297_0.list_3[i];
				float num5 = Math.Abs(num3 - class.Position.X);
				int num6 = class.StartTime - num4;
				float num7 = num5 / (float)num6;
				bool flag = num7 > num && class.StartTime != 0;
				bool flag2 = num7 > num2 && class.StartTime != 0;
				if (num3 - this.float_1 + this.float_2 < class.Position.X && num3 + this.float_1 - this.float_2 > class.Position.X)
				{
					num4 = class.EndTime;
					list.Add(new Class14(class.StartTime, num3, 490f, pButtonState.None));
				}
				else
				{
					if (class is Class317)
					{
						list.Add(new Class14(class.StartTime, class.Position.X, 490f, pButtonState.Left1));
					}
					else if (flag2)
					{
						list.Add(new Class14(class.StartTime - num6 + 1, num3, 490f, pButtonState.Left1));
						list.Add(new Class14(class.StartTime, class.Position.X, 490f, pButtonState.None));
					}
					else if (flag)
					{
						int num8 = (int)(num5 / num);
						int num9 = num8 - num6;
						int num10 = num9 / 2;
						num8 -= num10;
						float num11 = Class778.smethod_0(num3, class.Position.X, (float)num10 / (float)num6);
						list.Add(new Class14(class.StartTime - num6 + 1, num3, 490f, pButtonState.Left1));
						list.Add(new Class14(class.StartTime - num6 + num10, num11, 490f, pButtonState.None));
						list.Add(new Class14(class.StartTime, class.Position.X, 490f, pButtonState.None));
					}
					else
					{
						int num12 = (int)(num5 / num);
						list.Add(new Class14(class.StartTime - num12, num3, 490f, pButtonState.Right1));
						list.Add(new Class14(class.StartTime, class.Position.X, 490f, pButtonState.None));
					}
					num4 = class.EndTime;
					num3 = class.Position.X;
				}
			}
			Class62.class512_0.list_1 = Class802.class512_0.list_1;
			Class62.class512_0.string_2 = "salad!";
		}

		// Token: 0x0600298B RID: 10635
		// RVA: 0x00106C40 File Offset: 0x00104E40
		internal override void vmethod_31()
		{
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				if (this.class531_0.vmethod_6() == null || this.class911_3.list_2.Count == 0 || (Class115.bool_27 && !this.class531_0.vmethod_6().class748_0.method_0()) || (Class115.bool_26 && this.class531_0.vmethod_6().method_2() == null))
				{
					if (this.vmethod_7())
					{
						this.class512_0.bool_0 = false;
						this.class62_0.method_4();
						Class341.smethod_14();
						Class115.smethod_70(OsuModes.Update, false);
					}
					return;
				}
				this.class531_0.vector2_1 = Class115.smethod_61(this.class538_0.vector2_1) / Class115.float_4;
				if (!Class62.bool_11)
				{
					Class321 class = this.class62_0.class304_0 as Class321;
					if (class != null && class.bool_12)
					{
						if (!this.class531_1.bool_3)
						{
							this.class531_1.float_3 = 0.8f;
						}
					}
					else if (this.class531_1.bool_3)
					{
						this.class531_1.float_3 = 0f;
					}
					if (Class115.bool_13)
					{
						if (Class872.bool_1)
						{
							if (this.class531_0.float_2 < 8f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else if (this.class413_0.vmethod_0() < 100)
						{
							if (this.class531_0.float_2 > 5.2f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 5.2f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else if (this.class413_0.vmethod_0() < 200)
						{
							if (this.class531_0.float_2 > 4.6f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 4.6f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else
						{
							if (this.class531_0.float_2 > 4f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 4f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
					}
				}
				this.class911_3.Draw();
			}
		}

		// Token: 0x06002983 RID: 10627
		// RVA: 0x00106160 File Offset: 0x00104360
		internal override void vmethod_32()
		{
			if (Class62.bool_6)
			{
				return;
			}
			foreach (Class304 current in this.class297_0.list_4)
			{
				Predicate<Class316> predicate = null;
				Class431.Class678 class = new Class431.Class678();
				class.class316_0 = (current as Class316);
				if (class.class316_0 != null && Class331.int_7 >= class.class316_0.StartTime && !class.class316_0.bool_0)
				{
					if (this.class538_0.vector2_1.X - this.float_1 + this.float_2 < class.class316_0.Position.X && this.class538_0.vector2_1.X + this.float_1 - this.float_2 > class.class316_0.Position.X)
					{
						Class62.class62_0.method_68(class.class316_0, new int?((int)(this.class538_0.vector2_1.X - class.class316_0.Position.X)));
						class.class316_0.bool_6 = true;
					}
					else
					{
						class.class316_0.bool_6 = false;
					}
					this.class297_0.vmethod_10(class.class316_0);
					if (class.class316_0.bool_6)
					{
						this.class538_0.method_55((class.class316_0 is Class317 || Class331.smethod_82()) ? this.class731_3 : this.class731_1);
						this.class416_0.class536_1.method_40(class.class316_0.Colour, 300);
						foreach (Class531 current2 in class.class316_0.list_1)
						{
							List<Class746> arg_1DD_0 = current2.class26_0;
							if (Class431.predicate_2 == null)
							{
								Class431.predicate_2 = new Predicate<Class746>(Class431.smethod_3);
							}
							arg_1DD_0.RemoveAll(Class431.predicate_2);
							current2.float_2 *= 0.5f;
						}
						class.class316_0.vector2_1.X = class.class316_0.Position.X - this.class538_0.vector2_1.X;
						class.class316_0.vector2_1.Y = -5f;
						while (true)
						{
							List<Class316> arg_263_0 = this.list_0;
							if (predicate == null)
							{
								predicate = new Predicate<Class316>(class.method_0);
							}
							if (arg_263_0.Find(predicate) == null)
							{
								break;
							}
							Class316 expr_276_cp_0 = class.class316_0;
							expr_276_cp_0.vector2_1.X = expr_276_cp_0.vector2_1.X + (float)Class562.smethod_1(-5, 5);
							Class316 expr_297_cp_0 = class.class316_0;
							expr_297_cp_0.vector2_1.Y = expr_297_cp_0.vector2_1.Y - (float)Class562.smethod_1(0, 5);
						}
						if (class.class316_0 is Class319)
						{
							this.method_11(class.class316_0);
							this.method_13(class.class316_0, false);
						}
						else if (class.class316_0 is Class318)
						{
							this.method_13(class.class316_0, false);
						}
						else
						{
							this.method_11(class.class316_0);
							this.list_0.Add(class.class316_0);
							foreach (Class531 current3 in class.class316_0.list_1)
							{
								current3.bool_0 = true;
							}
						}
						this.method_12(true);
					}
					else
					{
						if (!(class.class316_0 is Class317))
						{
							this.class538_0.method_55(this.class731_2);
						}
						foreach (Class531 current4 in class.class316_0.list_1)
						{
							current4.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 2f, Class331.int_7, Class331.int_7 + 500, Enum70.const_0));
						}
						this.method_12(false);
					}
				}
			}
			base.vmethod_32();
		}

		// Token: 0x06002984 RID: 10628
		// RVA: 0x001065EC File Offset: 0x001047EC
		internal override void vmethod_33()
		{
			this.list_0.ForEach(new Action<Class316>(this.method_15));
			this.list_1.ForEach(new Action<Class531>(this.method_16));
			List<Class531> arg_51_0 = this.list_1;
			if (Class431.predicate_3 == null)
			{
				Class431.predicate_3 = new Predicate<Class531>(Class431.smethod_4);
			}
			arg_51_0.RemoveAll(Class431.predicate_3);
			if (this.bool_4 && Class115.int_1 - this.int_6 > 16)
			{
				Class531 class = new Class531(this.class538_0.vmethod_6(), Enum115.const_0, Origins.TopCentre, Enum114.const_0, this.class538_0.vector2_1, 0.84f, false, this.class538_0.color_0, null);
				class.float_3 = 0.5f;
				class.method_45(this.class538_0.method_44());
				class.bool_7 = true;
				Class531 expr_CF_cp_0 = class;
				expr_CF_cp_0.vector2_5.Y = expr_CF_cp_0.vector2_5.Y + 16f;
				class.float_2 = 0.71f;
				class.method_16((this.class538_0.vector2_1.X != this.vector2_1.X) ? 250 : 100, Enum70.const_0);
				this.class297_0.class911_0.Add(class);
				this.vector2_1 = this.class538_0.vector2_1;
				this.int_6 = Class115.int_1;
			}
			if (this.class538_0.method_54() != this.class731_2)
			{
				this.class538_0.method_55(Class331.smethod_82() ? this.class731_3 : this.class731_1);
			}
		}

		// Token: 0x0600297A RID: 10618
		// RVA: 0x0001FDFF File Offset: 0x0001DFFF
		internal override void vmethod_34()
		{
			if (this.class62_0.bool_30)
			{
				this.class410_0.vmethod_11(this.class410_0.double_1 * (double)(Class331.int_7 - Class331.int_9));
			}
			base.vmethod_34();
		}

		// Token: 0x06002988 RID: 10632
		// RVA: 0x0001FE5A File Offset: 0x0001E05A
		internal override void vmethod_35()
		{
			this.class416_0.method_3(Class115.smethod_59(this.class538_0.vector2_1.X) / Class115.float_4);
		}

		// Token: 0x0600297F RID: 10623
		// RVA: 0x00105C28 File Offset: 0x00103E28
		internal override void vmethod_36()
		{
			if (this.bool_0 && !Class62.bool_11)
			{
				int num = 0;
				if (!Class802.smethod_0())
				{
					Class802.bool_3 |= Class570.smethod_9(Class795.smethod_3(Bindings.FruitsDash));
					Class802.bool_3 |= Class569.smethod_2(Class795.smethod_3(Bindings.FruitsDash));
					Class802.bool_4 |= Class802.bool_3;
					if (Class802.bool_4)
					{
						Class802.buttonState_0 = 1;
					}
				}
				this.bool_4 = (Class802.buttonState_0 == 1);
				if (this.bool_4)
				{
					num += 4;
				}
				float num2 = this.float_3 * this.float_4;
				if (!this.bool_4)
				{
					num2 /= 2f;
				}
				if (!Class802.smethod_0() && !Class62.bool_15)
				{
					if (Class115.double_9 > 33.0)
					{
						return;
					}
					if (Math.Abs(this.class538_0.vector2_1.X - this.class623_0) > 0.01f)
					{
						this.class538_0.vector2_1.X = this.class623_0;
						this.class512_0.bool_0 = false;
					}
					if (this.bool_6 = (Class570.smethod_9(Class795.smethod_3(Bindings.FruitsRight)) || Class569.smethod_2(Class795.smethod_3(Bindings.FruitsRight))))
					{
						num++;
						this.class538_0.vector2_1.X = (float)((double)this.class538_0.vector2_1.X + (double)num2 * Class115.double_9);
						this.class538_0.method_45(false);
					}
					if (this.bool_5 = (Class570.smethod_9(Class795.smethod_3(Bindings.FruitsLeft)) || Class569.smethod_2(Class795.smethod_3(Bindings.FruitsLeft))))
					{
						num += 2;
						this.class538_0.vector2_1.X = (float)((double)this.class538_0.vector2_1.X - (double)num2 * Class115.double_9);
						this.class538_0.method_45(true);
					}
				}
				else
				{
					float x = Class802.vector2_1.X;
					if (Class802.bool_15)
					{
						this.bool_5 = (this.class538_0.vector2_1.X > x);
						this.bool_6 = (this.class538_0.vector2_1.X < x);
					}
					if (this.class538_0.vector2_1.X != x)
					{
						this.class538_0.method_45(this.class538_0.vector2_1.X > x);
						this.class538_0.vector2_1.X = x;
					}
				}
				this.method_9();
				this.bool_2 = (num != this.int_5);
				this.int_5 = num;
				this.class538_0.vector2_1.X = MathHelper.Clamp(this.class538_0.vector2_1.X, 0f, 512f);
				this.class623_0 = this.class538_0.vector2_1.X;
				return;
			}
		}

		// Token: 0x0600297B RID: 10619
		// RVA: 0x0010593C File Offset: 0x00103B3C
		internal override void vmethod_39(Enum61 enum61_0, double double_5, Class304 class304_1)
		{
			if (class304_1 == this.class304_0)
			{
				this.method_8();
				this.class304_0 = null;
			}
			if (enum61_0 != Enum61.flag_10 && double_5 > 0.0)
			{
				this.method_8();
				this.method_7(class304_1 as Class316);
				Class808.smethod_2(Class62.bool_38 ? 64 : 32);
				this.class410_0.vmethod_8();
				if (this.class410_0.method_2() > 180.0)
				{
					this.class410_0.vmethod_9();
				}
				return;
			}
		}

		// Token: 0x0600296F RID: 10607
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_4()
		{
			return true;
		}

		// Token: 0x06002982 RID: 10626
		// RVA: 0x0001FE52 File Offset: 0x0001E052
		internal override bool vmethod_40()
		{
			return this.bool_2;
		}

		// Token: 0x0600298C RID: 10636
		// RVA: 0x00019DBC File Offset: 0x00017FBC
		internal override void vmethod_41(Enum61 enum61_0, Class304 class304_1)
		{
			if (class304_1.LastInCombo && class304_1.bool_0 && enum61_0 != Enum61.flag_5)
			{
				this.class62_0.method_60(enum61_0);
			}
			base.vmethod_41(enum61_0, class304_1);
		}

		// Token: 0x06002971 RID: 10609
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_5()
		{
			return true;
		}

		// Token: 0x06002976 RID: 10614
		// RVA: 0x0001FDCA File Offset: 0x0001DFCA
		internal override bool vmethod_51()
		{
			return Class62.bool_15 || base.vmethod_51();
		}

		// Token: 0x06002970 RID: 10608
		// RVA: 0x0001FD85 File Offset: 0x0001DF85
		internal override Vector2 vmethod_6()
		{
			if (this.class538_0 != null)
			{
				return new Vector2(this.class538_0.vector2_1.X, 9999f);
			}
			return base.vmethod_6();
		}

		// Token: 0x06002972 RID: 10610
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_7()
		{
			return true;
		}

		// Token: 0x06002973 RID: 10611
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06002975 RID: 10613
		// RVA: 0x00105808 File Offset: 0x00103A08
		internal override bool vmethod_9()
		{
			int arg_3D_0 = this.class512_0.vmethod_2();
			List<Class304> arg_33_0 = this.class297_0.list_3;
			if (Class431.predicate_1 == null)
			{
				Class431.predicate_1 = new Predicate<Class304>(Class431.smethod_2);
			}
			return arg_3D_0 == arg_33_0.FindAll(Class431.predicate_1).Count;
		}
	}
}
