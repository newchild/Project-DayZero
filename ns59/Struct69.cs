using ns24;
using ns26;
using ns80;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu_common;
using System;

namespace ns59
{
	// Token: 0x02000685 RID: 1669
	internal struct Struct69
	{
		// Token: 0x04003091 RID: 12433
		public Enum38 enum38_0;

		// Token: 0x0400308E RID: 12430
		public HitObjectSoundType hitObjectSoundType_0;

		// Token: 0x04003092 RID: 12434
		public int int_0;

		// Token: 0x0400308F RID: 12431
		public SampleSet sampleSet_0;

		// Token: 0x04003090 RID: 12432
		public SampleSet sampleSet_1;

		// Token: 0x06003414 RID: 13332
		// RVA: 0x000264D7 File Offset: 0x000246D7
		public Struct69(HitObjectSoundType hitObjectSoundType_1, SampleSet sampleSet_2, Enum38 enum38_1, int int_1, SampleSet sampleSet_3)
		{
			this.hitObjectSoundType_0 = hitObjectSoundType_1;
			this.sampleSet_0 = sampleSet_2;
			this.sampleSet_1 = sampleSet_3;
			this.enum38_0 = enum38_1;
			this.int_0 = int_1;
		}

		// Token: 0x06003415 RID: 13333
		// RVA: 0x000264FE File Offset: 0x000246FE
		public static Struct69 smethod_0(HitObjectSoundType hitObjectSoundType_1, SampleSet sampleSet_2, Enum38 enum38_1, int int_1, SampleSet sampleSet_3)
		{
			if (hitObjectSoundType_1 == HitObjectSoundType.None || (Class885.class547_0.bool_6 && Class466.Current.method_5() != PlayModes.OsuMania))
			{
				hitObjectSoundType_1 |= HitObjectSoundType.Normal;
			}
			return new Struct69(hitObjectSoundType_1, sampleSet_2, enum38_1, int_1, sampleSet_3);
		}

		// Token: 0x06003416 RID: 13334
		// RVA: 0x001661AC File Offset: 0x001643AC
		public override string ToString()
		{
			return string.Format("{1} {2} {3} {4}% - {0}", new object[]
			{
				this.hitObjectSoundType_0,
				this.sampleSet_0,
				this.sampleSet_1,
				this.enum38_0,
				this.int_0
			});
		}
	}
}
