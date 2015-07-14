using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using System;
using System.Collections.Generic;

namespace ns61
{
	// Token: 0x02000550 RID: 1360
	internal sealed class Class498 : Class494
	{
		// Token: 0x06002BEA RID: 11242
		// RVA: 0x000217FA File Offset: 0x0001F9FA
		public Class498(Class297 class297_1) : base(class297_1)
		{
		}

		// Token: 0x06002BEB RID: 11243
		// RVA: 0x0011CA5C File Offset: 0x0011AC5C
		internal override Class305 vmethod_0(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_1, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0)
		{
			Class340 class = this.class297_0.class296_0.method_39((double)(int_0 + 5));
			bool bool_ = class != null && class.method_2();
			return new Class310(this.class297_0, vector2_0, int_0, bool_0, hitObjectSoundType_0, bool_);
		}

		// Token: 0x06002BEC RID: 11244
		// RVA: 0x0011CA9C File Offset: 0x0011AC9C
		internal override Class320 vmethod_1(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_0, int int_1, double double_0, List<Vector2> list_0, List<HitObjectSoundType> list_1, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, List<SampleSet> list_2, List<SampleSet> list_3, Enum38 enum38_0, int int_3, string string_0)
		{
			Class340 class = this.class297_0.class296_0.method_39((double)(int_0 + 5));
			bool bool_ = class != null && class.method_2();
			return new Class324(this.class297_0, vector2_0, int_0, bool_0, hitObjectSoundType_0, curveTypes_0, int_1, double_0, list_0, list_1, bool_);
		}

		// Token: 0x06002BED RID: 11245
		// RVA: 0x00021803 File Offset: 0x0001FA03
		internal override Class325 vmethod_2(int int_0, int int_1, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0)
		{
			return new Class329(this.class297_0, int_0, int_1, hitObjectSoundType_0);
		}

		// Token: 0x06002BEE RID: 11246
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		internal override Class305 vmethod_3(Vector2 vector2_0, int int_0, int int_1, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_3, string string_0)
		{
			return null;
		}
	}
}
