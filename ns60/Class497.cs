using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using System;
using System.Collections.Generic;

namespace ns60
{
	// Token: 0x0200054F RID: 1359
	internal sealed class Class497 : Class494
	{
		// Token: 0x06002BE5 RID: 11237
		// RVA: 0x000217FA File Offset: 0x0001F9FA
		public Class497(Class297 class297_1) : base(class297_1)
		{
		}

		// Token: 0x06002BE6 RID: 11238
		// RVA: 0x0011C8CC File Offset: 0x0011AACC
		internal override Class305 vmethod_0(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_1, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0)
		{
			Class306 class = new Class306(this.class297_0, vector2_0, int_0, bool_0, hitObjectSoundType_0, int_1);
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.enum38_0 = enum38_0;
			class.int_3 = int_2;
			class.method_5(string_0);
			return class;
		}

		// Token: 0x06002BE7 RID: 11239
		// RVA: 0x0011C918 File Offset: 0x0011AB18
		internal override Class320 vmethod_1(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_0, int int_1, double double_0, List<Vector2> list_0, List<HitObjectSoundType> list_1, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, List<SampleSet> list_2, List<SampleSet> list_3, Enum38 enum38_0, int int_3, string string_0)
		{
			Class321 class = new Class321(this.class297_0, vector2_0, int_0, bool_0, hitObjectSoundType_0, curveTypes_0, int_1, double_0, list_0, list_1, int_2);
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.list_9 = list_2;
			class.list_10 = list_3;
			class.enum38_0 = enum38_0;
			class.int_3 = int_3;
			class.method_5(string_0);
			if (class.class306_0 != null)
			{
				Struct69 struct = class.method_22(0);
				class.class306_0.sampleSet_0 = struct.sampleSet_0;
				class.class306_0.sampleSet_1 = struct.sampleSet_1;
			}
			return class;
		}

		// Token: 0x06002BE8 RID: 11240
		// RVA: 0x0011C9B0 File Offset: 0x0011ABB0
		internal override Class325 vmethod_2(int int_0, int int_1, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0)
		{
			Class328 class = new Class328(this.class297_0, int_0, int_1, hitObjectSoundType_0);
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.enum38_0 = enum38_0;
			class.int_3 = int_2;
			class.method_5(string_0);
			return class;
		}

		// Token: 0x06002BE9 RID: 11241
		// RVA: 0x0011C9F8 File Offset: 0x0011ABF8
		internal override Class305 vmethod_3(Vector2 vector2_0, int int_0, int int_1, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_3, string string_0)
		{
			Class308 class = new Class308(this.class297_0, vector2_0, int_0, bool_0, (hitObjectSoundType_0 & HitObjectSoundType.Whistle) > HitObjectSoundType.None, (hitObjectSoundType_0 & HitObjectSoundType.Finish) > HitObjectSoundType.None, (hitObjectSoundType_0 & HitObjectSoundType.Clap) > HitObjectSoundType.None, 0);
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.enum38_0 = enum38_0;
			class.EndTime = int_1;
			class.int_3 = int_3;
			class.method_5(string_0);
			return class;
		}
	}
}
