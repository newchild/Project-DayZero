using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns59;
using ns61;
using ns76;
using ns77;
using ns79;
using ns80;
using osu;
using osu.Audio;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns23
{
	// Token: 0x02000553 RID: 1363
	internal sealed class Class303 : Class297
	{
		// Token: 0x04002485 RID: 9349
		private double double_0;

		// Token: 0x04002484 RID: 9348
		private float float_2;

		// Token: 0x04002486 RID: 9350
		internal static readonly Vector2 vector2_0 = new Vector2(160f, 125f);

		// Token: 0x06002C05 RID: 11269
		// RVA: 0x0001B20E File Offset: 0x0001940E
		internal Class303(bool bool_2) : base(bool_2)
		{
		}

		// Token: 0x06002C06 RID: 11270
		// RVA: 0x00021832 File Offset: 0x0001FA32
		public override void Dispose()
		{
			this.class296_0.DifficultyCircleSize = this.float_2;
			this.class296_0.DifficultySliderMultiplier = this.double_0;
			base.Dispose();
		}

		// Token: 0x06002C07 RID: 11271
		// RVA: 0x0002185C File Offset: 0x0001FA5C
		protected override void vmethod_1()
		{
			this.float_2 = this.class296_0.DifficultyCircleSize;
			this.double_0 = this.class296_0.DifficultySliderMultiplier;
		}

		// Token: 0x06002C11 RID: 11281
		// RVA: 0x00021888 File Offset: 0x0001FA88
		protected override void vmethod_11(Class531 class531_0)
		{
			class531_0.enum115_0 = Enum115.const_1;
			base.vmethod_11(class531_0);
		}

		// Token: 0x06002C12 RID: 11282
		// RVA: 0x0011D91C File Offset: 0x0011BB1C
		protected override Class731[] vmethod_12(string string_0)
		{
			Class731[] array = Class885.smethod_27("taiko-" + string_0, Enum112.flag_6, true);
			if (array == null || array.Length == 0)
			{
				array = Class885.smethod_27(string_0, Enum112.flag_6, true);
			}
			return array;
		}

		// Token: 0x06002C0F RID: 11279
		// RVA: 0x0011D724 File Offset: 0x0011B924
		protected override void vmethod_13(Class531 class531_0)
		{
			class531_0.class26_0.Add(new Class746(new Vector2(320f, 240f), new Vector2(320f, 150f), Class331.int_7, Class331.int_7 + Class297.int_7 * 2, Enum70.const_1));
			class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.4f, 1f, Class331.int_7, Class331.int_7 + Class297.int_7 * 2, Enum70.const_1));
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + Class297.int_7 * 3, (int)((double)Class331.int_7 + (double)Class297.int_7 * 5.5), Enum70.const_0));
		}

		// Token: 0x06002C10 RID: 11280
		// RVA: 0x0011D7E4 File Offset: 0x0011B9E4
		protected override void vmethod_14(Class531 class531_0, bool bool_2, bool bool_3)
		{
			if (bool_2)
			{
				class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.6f, 1.1f, Class331.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 0.8), Enum70.const_0));
				class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 0.9f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 1.2), Enum70.const_0));
				class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.9f, 1f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 1.4), Enum70.const_0));
			}
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Class331.int_7 + Class297.int_7, Enum70.const_0));
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 2.5), Enum70.const_0));
		}

		// Token: 0x06002C0E RID: 11278
		// RVA: 0x0011D124 File Offset: 0x0011B324
		protected override void vmethod_18()
		{
			if (Class115.osuModes_1 == OsuModes.Edit)
			{
				return;
			}
			this.int_14 = this.list_3.Count;
			if (this.int_14 == 0)
			{
				return;
			}
			Vector2 vector = Class303.vector2_0;
			int num = Class115.smethod_43() - 40;
			double num2 = 1.0;
			if (Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.HardRock))
			{
				num = Class115.int_20 - 40;
				this.class911_0.method_18(new RectangleF(0f, 0f, (float)Class115.int_20, (float)Class115.smethod_44()));
			}
			if (Class876.smethod_6(this.class623_0, Mods.HardRock))
			{
				num2 *= (double)(1.4f * (float)Class115.smethod_43() / (float)Class115.int_20);
			}
			else if (Class876.smethod_6(this.class623_0, Mods.Easy))
			{
				num2 *= 0.800000011920929;
			}
			for (int i = 0; i < this.int_14; i++)
			{
				Class304 class = this.list_3[i];
				class.vmethod_5(vector, false);
				double num3 = 300.0;
				double num4 = this.SliderVelocityAt(class.StartTime) * num2;
				if (class is Class324)
				{
					Class324 class2 = (Class324)class;
					class2.method_34(true, num2);
					num3 += class2.SpatialLength;
				}
				int num5 = (int)((double)num / num4 * 1000.0);
				int num6 = (int)(300.0 / num4 * 1000.0);
				Class329 class3 = class as Class329;
				if (class3 != null)
				{
					Class531 class531_ = class3.class531_11;
					class531_.class26_0.Add(new Class746(new Vector2(class531_.vector2_1.X + (float)num, class531_.vector2_1.Y), new Vector2(class531_.vector2_1.X, class531_.vector2_1.Y), class.StartTime - num5, class.StartTime, Enum70.const_0));
					class531_.class26_0.Add(new Class746(new Vector2(class531_.vector2_1.X, class531_.vector2_1.Y), new Vector2(256f, 196f), class.StartTime, class.StartTime + 200, Enum70.const_0));
					class531_.class26_0.Add(new Class746(TransformationType.Scale, 1f, 3f, class.StartTime, class.StartTime + 200, Enum70.const_1));
					class531_.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, class.StartTime, class.StartTime + 200, Enum70.const_0));
				}
				else
				{
					for (int j = 0; j < class.list_1.Count; j++)
					{
						Class531 class4 = class.list_1[j];
						class4.class26_0.Add(new Class746(new Vector2(class4.vector2_1.X + (float)num, class4.vector2_1.Y), new Vector2(class4.vector2_1.X, class4.vector2_1.Y), class.StartTime - num5, class.StartTime, Enum70.const_0));
						class4.class26_0.Add(new Class746(new Vector2(class4.vector2_1.X, class4.vector2_1.Y), new Vector2(class4.vector2_1.X - (float)num3, class4.vector2_1.Y), class.StartTime, class.EndTime + num6, Enum70.const_0));
					}
				}
			}
			int num7 = this.list_3[this.int_14 - 1].EndTime + 1;
			List<Class340> list = this.class296_0.method_7();
			if (list != null && list.Count != 0)
			{
				int num8 = 0;
				double num9 = list[0].double_1;
				double num10 = list[0].double_0 * (double)list[0].enum37_0;
				num9 -= num10 * (double)((int)(num9 / num10));
				if (num9 < 0.0)
				{
					num9 += num10;
				}
				Class731 class731_ = Class885.Load("taiko-barline", Enum112.flag_1);
				while (num9 <= (double)num7)
				{
					Class340 class5 = list[num8];
					if (num9 > class5.double_1 || (class5.enum39_0 & Enum39.flag_2) == Enum39.flag_0)
					{
						Class531 class6 = new Class531(class731_, Enum115.const_1, Origins.Centre, Enum114.const_1, vector, 0.0002f, false, Color.get_White(), null);
						class6.float_2 = 0.88f;
						int num11 = (int)num9;
						double num12 = this.SliderVelocityAt(num11) * num2;
						int num13 = (int)((double)num / num12 * 1000.0);
						int num14 = (int)(300.0 / num12 * 1000.0);
						this.class911_0.Add(class6);
						class6.class26_0.Add(new Class746(new Vector2(class6.vector2_1.X + (float)num, class6.vector2_1.Y), new Vector2(class6.vector2_1.X, class6.vector2_1.Y), num11 - num13, num11, Enum70.const_0));
						class6.class26_0.Add(new Class746(new Vector2(class6.vector2_1.X, class6.vector2_1.Y), new Vector2(class6.vector2_1.X - 300f, class6.vector2_1.Y), num11, num11 + num14, Enum70.const_0));
					}
					double num15 = class5.double_0;
					if (num15 < 800.0)
					{
						num15 *= (double)class5.enum37_0;
					}
					num9 += num15;
					if (num8 + 1 < list.Count && num9 >= list[num8 + 1].double_1)
					{
						num8++;
						num9 = list[num8].double_1;
					}
				}
				return;
			}
		}

		// Token: 0x06002C0D RID: 11277
		// RVA: 0x0011CF64 File Offset: 0x0011B164
		protected override void vmethod_21(Class320 class320_0)
		{
			Class324 class = (Class324)class320_0;
			class.SpatialLength *= 1.3999999761581421;
			double num = class.SpatialLength;
			num *= (double)class.SegmentCount;
			double num2 = this.SliderScoringPointDistance * this.class296_0.DifficultySliderTickRate;
			double num3 = this.class296_0.method_36((double)class.StartTime, true);
			class.EndTime = class.StartTime + (int)(num / num2 * num3);
			double num4 = this.SliderVelocityAt(class.StartTime);
			num3 = this.class296_0.method_36((double)class.StartTime, this.class296_0.int_6 < 8);
			double num5 = Math.Min(num3 / this.class296_0.DifficultySliderTickRate, (double)(class.EndTime - class.StartTime) / (double)class.SegmentCount);
			if (num5 > 0.0 && this.class296_0.method_5() != PlayModes.Taiko && num / num4 * 1000.0 < 2.0 * num3)
			{
				int num6 = 0;
				for (double num7 = (double)class.StartTime; num7 <= (double)class.EndTime + num5 / 8.0; num7 += num5)
				{
					Class305 class304_;
					if (class.bool_10)
					{
						class304_ = this.class494_0.vmethod_0(Vector2.get_Zero(), (int)num7, false, class.SoundType, 0, SampleSet.None, SampleSet.None, Enum38.const_0, 0, "");
					}
					else
					{
						class304_ = this.class494_0.vmethod_0(Vector2.get_Zero(), (int)num7, false, class.list_8[num6], 0, SampleSet.None, SampleSet.None, Enum38.const_0, 0, "");
						num6 = (num6 + 1) % class.list_8.Count;
					}
					this.Add(class304_, false);
				}
				return;
			}
			base.vmethod_21(class);
		}

		// Token: 0x06002C0A RID: 11274
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_22()
		{
			return false;
		}

		// Token: 0x06002C09 RID: 11273
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_5()
		{
			return false;
		}

		// Token: 0x06002C08 RID: 11272
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_6()
		{
			return false;
		}

		// Token: 0x06002C0B RID: 11275
		// RVA: 0x00021880 File Offset: 0x0001FA80
		internal override Class494 vmethod_7()
		{
			return new Class498(this);
		}

		// Token: 0x06002C0C RID: 11276
		// RVA: 0x0011CE00 File Offset: 0x0011B000
		internal override void vmethod_8(bool bool_2, bool bool_3)
		{
			this.class296_0.DifficultyCircleSize = 2f;
			this.class296_0.DifficultySliderMultiplier = this.double_0 * 1.3999999761581421;
			base.vmethod_8(bool_2, bool_3);
			this.float_1 = Class115.float_3 / 8f * 1.42f;
			this.HitObjectRadius = this.float_1 / 2f / Class115.float_1;
			this.float_0 = this.float_1 / (float)Class297.int_5;
			if (this.class911_0 != null)
			{
				this.class911_0.float_4 = this.float_0;
			}
			this.HitWindow50 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 135.0, 95.0, 70.0);
			this.HitWindow100 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 120.0, 80.0, 50.0);
			this.HitWindow300 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 50.0, 35.0, 20.0);
			this.PreEmpt = (int)(600.0 / this.SliderVelocityAt(0) / 0.60000002384185791 * 1000.0);
		}
	}
}
