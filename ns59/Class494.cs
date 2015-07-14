using Microsoft.Xna.Framework;
using ns23;
using ns26;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using System;
using System.Collections.Generic;

namespace ns59
{
	// Token: 0x02000426 RID: 1062
	internal abstract class Class494
	{
		// Token: 0x04001AB0 RID: 6832
		protected readonly Class297 class297_0;

		// Token: 0x06002236 RID: 8758
		// RVA: 0x0001B7A1 File Offset: 0x000199A1
		internal Class494(Class297 class297_1)
		{
			this.class297_0 = class297_1;
		}

		// Token: 0x06002237 RID: 8759
		internal abstract Class305 vmethod_0(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_1, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0);

		// Token: 0x06002238 RID: 8760
		internal abstract Class320 vmethod_1(Vector2 vector2_0, int int_0, bool bool_0, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_0, int int_1, double double_0, List<Vector2> list_0, List<HitObjectSoundType> list_1, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, List<SampleSet> list_2, List<SampleSet> list_3, Enum38 enum38_0, int int_3, string string_0);

		// Token: 0x06002239 RID: 8761
		internal abstract Class325 vmethod_2(int int_0, int int_1, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_2, string string_0);

		// Token: 0x0600223A RID: 8762
		internal abstract Class305 vmethod_3(Vector2 vector2_0, int int_0, int int_1, bool bool_0, HitObjectSoundType hitObjectSoundType_0, int int_2, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_3, string string_0);
	}
}
