using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns23;
using ns26;
using ns29;
using ns59;
using ns60;
using ns70;
using ns79;
using ns80;
using ns81;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns61
{
	// Token: 0x02000555 RID: 1365
	internal sealed class Class324 : Class321
	{
		// Token: 0x02000556 RID: 1366
		internal sealed class Class720
		{
			// Token: 0x04002498 RID: 9368
			internal bool bool_0;

			// Token: 0x04002497 RID: 9367
			internal readonly Class531 class531_0;

			// Token: 0x04002496 RID: 9366
			internal readonly int int_0;

			// Token: 0x06002C3B RID: 11323
			// RVA: 0x000219A3 File Offset: 0x0001FBA3
			internal Class720(int int_1, Class531 class531_1)
			{
				this.int_0 = int_1;
				this.class531_0 = class531_1;
			}

			// Token: 0x06002C3C RID: 11324
			// RVA: 0x000219B9 File Offset: 0x0001FBB9
			internal void method_0()
			{
				this.bool_0 = true;
				if (this.class531_0 != null)
				{
					this.class531_0.method_16(40, Enum70.const_0);
				}
			}
		}

		// Token: 0x04002490 RID: 9360
		private bool bool_14 = true;

		// Token: 0x04002493 RID: 9363
		internal bool bool_15;

		// Token: 0x0400248E RID: 9358
		private Class531 class531_3;

		// Token: 0x0400248F RID: 9359
		private Class531 class531_4;

		// Token: 0x04002489 RID: 9353
		private Class536 class536_0;

		// Token: 0x04002491 RID: 9361
		private double double_3;

		// Token: 0x04002492 RID: 9362
		private double double_4;

		// Token: 0x0400248B RID: 9355
		private float float_1;

		// Token: 0x0400248C RID: 9356
		private float float_2;

		// Token: 0x0400248D RID: 9357
		private float float_3;

		// Token: 0x0400248A RID: 9354
		private int int_12;

		// Token: 0x04002494 RID: 9364
		internal readonly List<Class324.Class720> list_11 = new List<Class324.Class720>();

		// Token: 0x04002495 RID: 9365
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x1700039B RID: 923
		public override int ComboNumber
		{
			// Token: 0x06002C27 RID: 11303
			// RVA: 0x00021700 File Offset: 0x0001F900
			get
			{
				return -1;
			}
			// Token: 0x06002C28 RID: 11304
			// RVA: 0x000218AE File Offset: 0x0001FAAE
			set
			{
				base.ComboNumber = -1;
			}
		}

		// Token: 0x1700039A RID: 922
		public override Vector2 EndPosition
		{
			// Token: 0x06002C25 RID: 11301
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x06002C26 RID: 11302
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x06002C23 RID: 11299
		// RVA: 0x0011DD0C File Offset: 0x0011BF0C
		internal Class324(Class297 class297_1, Vector2 vector2_4, int int_13, bool bool_16, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_2, int int_14, double double_5, List<Vector2> list_12, List<HitObjectSoundType> list_13, bool bool_17) : base(class297_1, vector2_4, int_13, bool_16, hitObjectSoundType_0, curveTypes_2, int_14, double_5, list_12, list_13, 0)
		{
			base.vmethod_0(new Color(252, 184, 6));
			this.bool_2 = bool_17;
		}

		// Token: 0x06002C31 RID: 11313
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Draw()
		{
		}

		// Token: 0x06002C22 RID: 11298
		// RVA: 0x0001488D File Offset: 0x00012A8D
		private bool method_32()
		{
			return this.SoundType.IsType(HitObjectSoundType.Finish);
		}

		// Token: 0x06002C2A RID: 11306
		// RVA: 0x0011DDA8 File Offset: 0x0011BFA8
		public double method_33()
		{
			if (this.double_3 == 0.0)
			{
				double num;
				if (this.class297_0.class296_0.int_6 >= 8)
				{
					if (this.class297_0.class296_0.DifficultySliderTickRate != 3.0 && this.class297_0.class296_0.DifficultySliderTickRate != 6.0)
					{
						if (this.class297_0.class296_0.DifficultySliderTickRate != 1.5)
						{
							num = Class331.smethod_22((double)this.StartTime, false) / 8.0;
							goto IL_D7;
						}
					}
					num = Class331.smethod_22((double)this.StartTime, false) / 6.0;
				}
				else
				{
					num = Class331.smethod_22((double)this.StartTime, true) / 8.0;
				}
				IL_D7:
				while (num < 60.0)
				{
					num *= 2.0;
				}
				while (num > 120.0)
				{
					num /= 2.0;
				}
				this.double_3 = num;
			}
			return this.double_3;
		}

		// Token: 0x06002C36 RID: 11318
		// RVA: 0x0011E014 File Offset: 0x0011C214
		internal void method_34(bool bool_16, double double_5)
		{
			if (bool_16 || this.class531_4 == null)
			{
				List<Class304> list_ = this.class297_0.list_3;
				int num = list_.IndexOf(this);
				if (num < list_.Count - 1 && list_[num + 1].vmethod_16() - (this.EndTime + (int)this.method_33()) <= (int)this.method_33())
				{
					this.bool_14 = false;
				}
				float num2 = (!this.SoundType.IsType(HitObjectSoundType.Finish)) ? 0.65f : 1f;
				this.SpatialLength *= (double)this.SegmentCount;
				double num3 = this.class297_0.SliderScoringPointDistance * this.class297_0.class296_0.DifficultySliderTickRate;
				double num4 = this.class297_0.class296_0.method_36((double)this.StartTime, true);
				this.EndTime = this.StartTime + (int)(this.SpatialLength / num3 * num4);
				this.SpatialLength *= double_5;
				this.class531_4 = new Class531(Class885.Load("taiko-roll-middle", Enum112.flag_6), Enum115.const_1, Origins.TopLeft, Enum114.const_1, new Vector2(this.Position.X, this.Position.Y - this.class297_0.HitObjectRadius * num2), Class911.smethod_4((float)(this.EndTime + 10)), false, new Color(252, 184, 6), null);
				this.class531_4.vector2_2 = new Vector2((float)this.SpatialLength * Class115.float_4 / this.class297_0.float_0 * (1f / num2), 1f);
				this.class531_4.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0));
				this.class531_4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime, this.EndTime + this.class297_0.int_10, Enum70.const_0));
				this.class911_0.Add(this.class531_4);
				this.list_1.Add(this.class531_4);
				this.list_0.Add(this.class531_4);
				this.class531_3 = new Class531(Class885.Load("taiko-roll-end", Enum112.flag_6), Enum115.const_1, Origins.TopLeft, Enum114.const_1, new Vector2(this.Position.X, this.Position.Y - this.class297_0.HitObjectRadius * num2), Class911.smethod_4((float)(this.EndTime + 8)), false, new Color(252, 184, 6), null);
				this.class531_3.vector2_5 = new Vector2((float)(-(float)this.SpatialLength) * Class115.float_4 / this.class297_0.float_0 * (1f / num2), 0f);
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime, this.EndTime + this.class297_0.int_10, Enum70.const_0));
				this.class911_0.Add(this.class531_3);
				this.list_1.Add(this.class531_3);
				this.list_0.Add(this.class531_3);
				this.class538_0.class26_0.Add(new Class746(this.class306_0.Position, this.class306_0.Position, this.StartTime - 500, this.EndTime, Enum70.const_0));
				this.class538_1.class26_0.Add(new Class746(this.class306_0.Position, this.class306_0.Position, this.StartTime, this.EndTime, Enum70.const_0));
				this.class536_0 = new Class536("", Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_1, Origins.Centre, Enum114.const_1, Class303.vector2_0, 0.9f, false, Color.get_White(), true);
				this.class536_0.float_2 = 0.8f;
				this.class536_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, this.StartTime, this.StartTime, Enum70.const_0));
				this.class536_0.class26_0.Add(new Class746(TransformationType.Fade, 0.6f, 0f, this.EndTime, this.EndTime + 300, Enum70.const_0));
				this.class911_0.Add(this.class536_0);
				int num5 = 0;
				for (double num6 = (double)this.StartTime; num6 < (double)this.vmethod_15(); num6 += this.method_33())
				{
					if (num6 == (double)this.StartTime)
					{
						this.list_11.Add(new Class324.Class720((int)num6, null));
						num5++;
					}
					else
					{
						bool flag = (this.class297_0.class296_0.DifficultySliderTickRate == 3.0 || this.class297_0.class296_0.DifficultySliderTickRate == 6.0 || this.class297_0.class296_0.DifficultySliderTickRate == 1.5) ? (num5 % 3 == 0) : (num5 % 4 == 0);
						Class531 class = new Class531(Class885.Load("sliderscorepoint", Enum112.flag_6), Enum115.const_1, Origins.Centre, Enum114.const_1, new Vector2(this.Position.X, this.Position.Y), Class911.smethod_4((float)(this.StartTime + 1)), false, flag ? Color.get_Yellow() : Color.get_White(), this);
						if (!flag)
						{
							class.float_2 *= 0.8f;
						}
						Class531 expr_59E_cp_0 = class;
						expr_59E_cp_0.vector2_5.X = expr_59E_cp_0.vector2_5.X - (float)(this.SpatialLength * (double)((float)(num6 - (double)this.StartTime)) / (double)base.Length) * Class115.float_4 / this.class297_0.float_0 / class.float_2 * (1f / num2);
						class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0));
						class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime, this.EndTime + this.class297_0.int_10, Enum70.const_0));
						this.list_11.Add(new Class324.Class720((int)num6, class));
						this.class911_0.Add(class);
						this.list_1.Add(class);
						this.list_0.Add(class);
						num5++;
					}
				}
				if (num2 != 1f)
				{
					foreach (Class531 current in this.list_1)
					{
						current.float_2 *= num2;
					}
				}
				for (int i = 0; i < this.class306_0.list_1.Count; i++)
				{
					Class531 class2 = this.class306_0.list_1[i];
					foreach (Class746 current2 in class2.class26_0)
					{
						if (current2.transformationType_0 == TransformationType.Fade && current2.float_0 == 1f)
						{
							current2.int_0 = this.EndTime;
							current2.int_1 = this.EndTime;
						}
					}
					this.list_1.Add(class2);
					this.list_0.Add(class2);
					this.class911_0.Add(class2);
				}
			}
		}

		// Token: 0x06002C39 RID: 11321
		// RVA: 0x00021972 File Offset: 0x0001FB72
		[CompilerGenerated]
		private bool method_35(Class324.Class720 class720_0)
		{
			return (double)Math.Abs(class720_0.int_0 - Class331.int_7) < this.method_33() / 2.0 && !class720_0.bool_0;
		}

		// Token: 0x06002C3A RID: 11322
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_12(Class746 class746_0)
		{
			return class746_0.byte_0 == 1;
		}

		// Token: 0x06002C2D RID: 11309
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_0(Color color_0)
		{
		}

		// Token: 0x06002C29 RID: 11305
		// RVA: 0x0011DD64 File Offset: 0x0011BF64
		internal override List<Class531> vmethod_13()
		{
			return new List<Class531>
			{
				this.class306_0.list_1[0],
				this.class531_4,
				this.class531_3
			};
		}

		// Token: 0x06002C2F RID: 11311
		// RVA: 0x00021943 File Offset: 0x0001FB43
		internal override int vmethod_15()
		{
			if (!this.bool_14)
			{
				return base.vmethod_15();
			}
			return base.vmethod_15() + (int)this.method_33();
		}

		// Token: 0x06002C30 RID: 11312
		// RVA: 0x00021962 File Offset: 0x0001FB62
		internal override int vmethod_16()
		{
			return base.vmethod_16() - (int)this.method_33();
		}

		// Token: 0x06002C37 RID: 11319
		// RVA: 0x0011E7F8 File Offset: 0x0011C9F8
		internal override Enum61 vmethod_17(Vector2 vector2_4)
		{
			if (this.bool_0)
			{
				return Enum61.flag_5;
			}
			bool flag;
			if (!(flag = Class800.bool_1))
			{
				return Enum61.flag_5;
			}
			double num = this.method_33();
			if (!Class62.bool_15)
			{
				if (this.double_4 == 0.0)
				{
					this.double_4 = (double)this.StartTime;
				}
				else if (Math.Abs((double)Class331.int_7 - (this.double_4 + num)) < num / 2.0)
				{
					this.double_4 += num;
				}
				else if (Math.Abs((double)Class331.int_7 - (this.double_4 + num * 2.0)) < num)
				{
					this.double_4 += num * 2.0;
				}
				else if (Math.Abs((double)Class331.int_7 - (this.double_4 + num * 4.0)) < num)
				{
					this.double_4 += num * 4.0;
				}
				else
				{
					flag = false;
				}
			}
			this.bool_15 = flag;
			if (!flag)
			{
				double num2;
				for (num2 = (double)this.StartTime; num2 < (double)Class331.int_7; num2 += num * 2.0)
				{
				}
				this.double_4 = (double)((int)num2);
				return Enum61.flag_5;
			}
			Class324.Class720 class = this.list_11.Find(new Predicate<Class324.Class720>(this.method_35));
			if (class == null)
			{
				return Enum61.flag_5;
			}
			class.method_0();
			this.int_12++;
			this.class536_0.Text = this.int_12.ToString();
			if (Class331.int_7 < this.EndTime)
			{
				List<Class746> arg_1A4_0 = this.class536_0.class26_0;
				if (Class324.predicate_6 == null)
				{
					Class324.predicate_6 = new Predicate<Class746>(Class324.smethod_12);
				}
				arg_1A4_0.RemoveAll(Class324.predicate_6);
				Class746 class2 = new Class746(TransformationType.Fade, 1f, 0.6f, Class331.int_7, Class331.int_7 + 300, Enum70.const_0);
				class2.byte_0 = 1;
				this.class536_0.class26_0.Add(class2);
			}
			this.float_2 += 2f;
			if (this.method_32())
			{
				return Enum61.flag_27 | Enum61.flag_28;
			}
			return Enum61.flag_27;
		}

		// Token: 0x06002C2E RID: 11310
		// RVA: 0x000218DE File Offset: 0x0001FADE
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			return Enum61.flag_5;
		}

		// Token: 0x06002C2B RID: 11307
		// RVA: 0x0002191C File Offset: 0x0001FB1C
		internal override bool vmethod_20(Vector2 vector2_4, bool bool_16, float float_4)
		{
			return this.vmethod_16() <= Class331.int_7 && this.vmethod_15() >= Class331.int_7 && !this.bool_0;
		}

		// Token: 0x06002C33 RID: 11315
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_21()
		{
		}

		// Token: 0x06002C38 RID: 11320
		// RVA: 0x00021756 File Offset: 0x0001F956
		protected override int vmethod_22()
		{
			return (int)(600.0 / this.class297_0.SliderVelocityAt(this.StartTime) / 0.60000002384185791 * 1000.0);
		}

		// Token: 0x06002C35 RID: 11317
		// RVA: 0x0011DFBC File Offset: 0x0011C1BC
		protected override void vmethod_23()
		{
			this.class306_0 = (Class306)this.class297_0.class494_0.vmethod_0(this.Position, this.StartTime, false, this.SoundType, 0, SampleSet.None, SampleSet.None, Enum38.const_0, 0, "");
			this.class306_0.vmethod_0(this.Colour);
		}

		// Token: 0x06002C34 RID: 11316
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_24(bool bool_16)
		{
		}

		// Token: 0x06002C24 RID: 11300
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_25()
		{
			return true;
		}

		// Token: 0x06002C2C RID: 11308
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override Enum61 vmethod_26()
		{
			return Enum61.flag_5;
		}

		// Token: 0x06002C32 RID: 11314
		// RVA: 0x0011DEC0 File Offset: 0x0011C0C0
		internal override void vmethod_6()
		{
			if (Class115.bool_13)
			{
				if (this.float_3 < this.float_2)
				{
					this.float_3 += 0.4f;
				}
				else
				{
					this.float_3 = this.float_2;
				}
				this.float_1 = Math.Max(0f, 1f - this.float_3 / 10f);
				Color color;
				color..ctor(252, (byte)(184f * this.float_1), (byte)(6f * this.float_1));
				if (this.Colour != color)
				{
					this.class306_0.vmethod_0(this.Colour);
					this.Colour = color;
					this.class531_4.color_0 = color;
					this.class531_3.color_0 = color;
				}
				this.float_2 = Math.Max(0f, this.float_2 - 0.2f);
			}
			base.vmethod_6();
			this.class538_0.method_45(false);
		}
	}
}
