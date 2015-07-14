using osu.GameplayElements.Beatmaps;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;

namespace osu.GameplayElements
{
	// Token: 0x02000309 RID: 777
	public abstract class HitObjectManagerBase : MarshalByRefObject
	{
		// Token: 0x04001224 RID: 4644
		public float HitObjectRadius;

		// Token: 0x04001227 RID: 4647
		public int HitWindow100;

		// Token: 0x04001228 RID: 4648
		public int HitWindow300;

		// Token: 0x04001226 RID: 4646
		public int HitWindow50;

		// Token: 0x04001225 RID: 4645
		public int PreEmpt;

		// Token: 0x04001229 RID: 4649
		public double SliderScoringPointDistance;

		// Token: 0x0400122A RID: 4650
		public double SpinnerRotationRatio;

		// Token: 0x0400122B RID: 4651
		public float StackOffset;

		// Token: 0x06001763 RID: 5987
		public abstract double AdjustDifficulty(double difficulty);

		// Token: 0x06001761 RID: 5985
		public abstract BeatmapBase GetBeatmap();

		// Token: 0x06001762 RID: 5986
		public abstract List<HitObjectBase> GetHitObjects();

		// Token: 0x06001764 RID: 5988
		public abstract double MapDifficultyRange(double difficulty, double min, double mid, double max);

		// Token: 0x06001765 RID: 5989
		public abstract double SliderVelocityAt(int time);
	}
}
