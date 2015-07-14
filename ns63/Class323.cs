using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns59;
using ns60;
using ns70;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns63
{
	// Token: 0x02000554 RID: 1364
	internal sealed class Class323 : Class321
	{
		// Token: 0x04002488 RID: 9352
		internal List<Class316> list_11 = new List<Class316>();

		// Token: 0x04002487 RID: 9351
		private readonly string string_1;

		// Token: 0x17000399 RID: 921
		public override int ComboNumber
		{
			// Token: 0x06002C16 RID: 11286
			// RVA: 0x00021700 File Offset: 0x0001F900
			get
			{
				return -1;
			}
			// Token: 0x06002C17 RID: 11287
			// RVA: 0x000218AE File Offset: 0x0001FAAE
			set
			{
				base.ComboNumber = -1;
			}
		}

		// Token: 0x06002C14 RID: 11284
		// RVA: 0x0011D950 File Offset: 0x0011BB50
		internal Class323(Class297 class297_1, Vector2 vector2_4, int int_12, bool bool_14, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_2, int int_13, double double_3, List<Vector2> list_12, List<HitObjectSoundType> list_13, string string_2) : base(class297_1, vector2_4, int_12, bool_14, hitObjectSoundType_0, curveTypes_2, int_13, double_3, list_12, list_13, 0)
		{
			this.string_1 = string_2;
			this.class911_0 = null;
		}

		// Token: 0x06002C1C RID: 11292
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Draw()
		{
		}

		// Token: 0x06002C20 RID: 11296
		// RVA: 0x0011DCDC File Offset: 0x0011BEDC
		internal void method_32(Class316 class316_0, int int_12)
		{
			Struct69 struct = base.method_22(int_12);
			class316_0.sampleSet_0 = struct.sampleSet_0;
			class316_0.sampleSet_1 = struct.sampleSet_1;
		}

		// Token: 0x06002C1A RID: 11290
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_0(Color color_0)
		{
		}

		// Token: 0x06002C21 RID: 11297
		// RVA: 0x0002190F File Offset: 0x0001FB0F
		internal override Enum61 vmethod_17(Vector2 vector2_4)
		{
			if (this.bool_0)
			{
				return Enum61.flag_5;
			}
			return Enum61.flag_5;
		}

		// Token: 0x06002C1B RID: 11291
		// RVA: 0x000218DE File Offset: 0x0001FADE
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			return Enum61.flag_5;
		}

		// Token: 0x06002C18 RID: 11288
		// RVA: 0x000218B7 File Offset: 0x0001FAB7
		internal override bool vmethod_20(Vector2 vector2_4, bool bool_14, float float_1)
		{
			return this.StartTime <= Class331.int_7 && this.EndTime >= Class331.int_7 && !this.bool_0;
		}

		// Token: 0x06002C1E RID: 11294
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_21()
		{
		}

		// Token: 0x06002C1F RID: 11295
		// RVA: 0x0011D990 File Offset: 0x0011BB90
		internal override void vmethod_24(bool bool_14)
		{
			base.vmethod_24(bool_14);
			if (base.Length > 60000)
			{
				throw new ArgumentOutOfRangeException("Slider is too long. (Over 1 minute!)");
			}
			bool flag = this.class297_0.class296_0.method_5() != PlayModes.CatchTheBeat || this.class297_0.class296_0.int_6 >= 14;
			this.list_11.Clear();
			Class316 class = new Class316(this.class297_0, this.Position, this.StartTime, this.NewCombo, this.bool_10 ? this.SoundType : this.list_8[0], this.string_1);
			if (flag)
			{
				this.method_32(class, 0);
			}
			else
			{
				class.sampleSet_1 = ((this.list_10.Count <= 0 || this.list_10[0] == SampleSet.None) ? this.sampleSet_1 : this.list_10[0]);
			}
			class.Type |= HitObjectType.NewCombo;
			this.list_11.Add(class);
			int num = this.StartTime;
			Class496 class2 = this.class297_0.class494_0 as Class496;
			int num2 = 1;
			for (int i = 0; i < this.list_7.Count; i++)
			{
				int num3 = this.list_7[i];
				if (num3 - num > 80)
				{
					float num4;
					for (num4 = (float)(num3 - num); num4 > 100f; num4 /= 2f)
					{
					}
					for (float num5 = (float)num + num4; num5 < (float)num3; num5 += num4)
					{
						Class318 item = new Class318(this.class297_0, this.PositionAtTime((int)num5) + new Vector2((float)class2.class30_0.method_2(-20, 20), 0f), (int)num5, false, this.SoundType, this.string_1);
						this.list_11.Add(item);
					}
				}
				num = num3;
				if (i < this.list_7.Count - 1)
				{
					int num6 = this.list_6.BinarySearch(num3);
					if (num6 >= 0)
					{
						Class316 class3 = new Class316(this.class297_0, (num6 % 2 == 1) ? this.Position : this.vmethod_10(), num3, false, this.bool_10 ? this.SoundType : this.list_8[num6 + 1], this.string_1);
						if (flag)
						{
							this.method_32(class3, num2);
						}
						this.list_11.Add(class3);
						num2++;
					}
					else
					{
						Class319 item2 = new Class319(this.class297_0, this.PositionAtTime(num3), num3, false, this.SoundType, this.string_1);
						this.list_11.Add(item2);
					}
				}
			}
			Class316 class4 = new Class316(this.class297_0, this.EndPosition, this.EndTime, false, this.bool_10 ? this.SoundType : this.list_8[this.list_8.Count - 1], this.string_1);
			if (flag)
			{
				this.method_32(class4, this.list_10.Count - 1);
			}
			else
			{
				class4.sampleSet_1 = ((this.list_10.Count <= 0 || this.list_10[1] == SampleSet.None) ? this.sampleSet_1 : this.list_10[1]);
			}
			this.list_11.Add(class4);
		}

		// Token: 0x06002C15 RID: 11285
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_25()
		{
			return true;
		}

		// Token: 0x06002C19 RID: 11289
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override Enum61 vmethod_26()
		{
			return Enum61.flag_5;
		}

		// Token: 0x06002C1D RID: 11293
		// RVA: 0x000218E8 File Offset: 0x0001FAE8
		internal override void vmethod_6()
		{
			this.vmethod_24(false);
			base.vmethod_6();
			this.class538_0.method_45(false);
			this.class538_0.method_43(false);
		}
	}
}
