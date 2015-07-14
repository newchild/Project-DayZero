using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using ns76;
using ns8;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns63
{
	// Token: 0x0200054E RID: 1358
	internal sealed class Class496 : Class494
	{
		// Token: 0x04002483 RID: 9347
		internal Class30 class30_0 = new Class30(1337);

		// Token: 0x0400247E RID: 9342
		private float float_0;

		// Token: 0x0400247F RID: 9343
		private int int_0;

		// Token: 0x04002480 RID: 9344
		private int int_1;

		// Token: 0x04002481 RID: 9345
		private static readonly string[] string_0 = new string[]
		{
			"pear",
			"grapes",
			"apple",
			"orange"
		};

		// Token: 0x04002482 RID: 9346
		private static readonly string[] string_1 = new string[]
		{
			"bananas"
		};

		// Token: 0x06002BDC RID: 11228
		// RVA: 0x000217A6 File Offset: 0x0001F9A6
		public Class496(Class297 class297_1) : base(class297_1)
		{
			this.class30_0.method_0(1337);
		}

		// Token: 0x06002BDE RID: 11230
		// RVA: 0x0011C64C File Offset: 0x0011A84C
		private void method_0(ref Vector2 vector2_0, int int_2)
		{
			if (Class876.smethod_6(this.class297_0.class623_0, Mods.HardRock))
			{
				if (this.float_0 == 0f)
				{
					this.float_0 = vector2_0.X;
					this.int_0 = int_2;
					return;
				}
				float num = this.float_0 - vector2_0.X;
				int num2 = int_2 - this.int_0;
				if (num2 > 1000)
				{
					this.float_0 = vector2_0.X;
					this.int_0 = int_2;
					return;
				}
				if (num == 0f)
				{
					bool flag = this.class30_0.method_5();
					float num3 = (float)Math.Min(20, this.class30_0.method_2(0, num2 / 4));
					if (flag)
					{
						if (vector2_0.X + num3 <= 512f)
						{
							vector2_0.X += num3;
							return;
						}
						vector2_0.X -= num3;
						return;
					}
					else
					{
						if (vector2_0.X - num3 >= 0f)
						{
							vector2_0.X -= num3;
							return;
						}
						vector2_0.X += num3;
						return;
					}
				}
				else
				{
					if (Math.Abs(num) < (float)(num2 / 3))
					{
						if (num > 0f)
						{
							if (vector2_0.X - num > 0f)
							{
								vector2_0.X -= num;
							}
						}
						else if (vector2_0.X - num < 512f)
						{
							vector2_0.X -= num;
						}
					}
					this.float_0 = vector2_0.X;
					this.int_0 = int_2;
				}
			}
		}

		// Token: 0x06002BDF RID: 11231
		// RVA: 0x0011C7B8 File Offset: 0x0011A9B8
		private string method_1()
		{
			string result = Class496.string_0[this.int_1];
			this.int_1 = (this.int_1 + 1) % Class496.string_0.Length;
			return result;
		}

		// Token: 0x06002BE0 RID: 11232
		// RVA: 0x000217CF File Offset: 0x0001F9CF
		internal string method_2()
		{
			return Class496.string_1[this.class30_0.method_2(0, Class496.string_1.Length)];
		}

		// Token: 0x06002BDD RID: 11229
		// RVA: 0x0011C5E8 File Offset: 0x0011A7E8
		internal override Class305 vmethod_0(Vector2 vector2_0, int int_2, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_3, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_4, string string_2)
		{
			this.method_0(ref vector2_0, int_2);
			Class316 class = new Class316(this.class297_0, vector2_0, int_2, bool_0, hitObjectSoundType_0, this.method_1());
			class.Type |= HitObjectType.NewCombo;
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.enum38_0 = enum38_0;
			class.int_3 = int_4;
			class.method_5(string_2);
			return class;
		}

		// Token: 0x06002BE1 RID: 11233
		// RVA: 0x0011C7EC File Offset: 0x0011A9EC
		internal override Class320 vmethod_1(Vector2 vector2_0, int int_2, bool bool_0, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_0, int int_3, double double_0, List<Vector2> list_0, List<HitObjectSoundType> list_1, int int_4, SampleSet sampleSet_0, SampleSet sampleSet_1, List<SampleSet> list_2, List<SampleSet> list_3, Enum38 enum38_0, int int_5, string string_2)
		{
			Class323 class = new Class323(this.class297_0, vector2_0, int_2, bool_0, hitObjectSoundType_0, curveTypes_0, int_3, double_0, list_0, list_1, this.method_1());
			this.float_0 = list_0[list_0.Count - 1].X;
			this.int_0 = class.EndTime;
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.list_9 = list_2;
			class.list_10 = list_3;
			class.enum38_0 = enum38_0;
			class.int_3 = int_5;
			class.method_5(string_2);
			return class;
		}

		// Token: 0x06002BE2 RID: 11234
		// RVA: 0x000217EA File Offset: 0x0001F9EA
		internal override Class325 vmethod_2(int int_2, int int_3, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_4, string string_2)
		{
			return new Class327(this.class297_0, int_2, int_3, hitObjectSoundType_0);
		}

		// Token: 0x06002BE3 RID: 11235
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		internal override Class305 vmethod_3(Vector2 vector2_0, int int_2, int int_3, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_4, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_5, string string_2)
		{
			return null;
		}
	}
}
