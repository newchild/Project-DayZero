using System;

namespace osu.GameplayElements.Beatmaps
{
	// Token: 0x02000308 RID: 776
	public abstract class BeatmapBase : MarshalByRefObject
	{
		// Token: 0x0400121F RID: 4639
		public string Artist = string.Empty;

		// Token: 0x04001220 RID: 4640
		public string ArtistUnicode;

		// Token: 0x04001219 RID: 4633
		public float DifficultyApproachRate = 5f;

		// Token: 0x0400121A RID: 4634
		public float DifficultyCircleSize = 5f;

		// Token: 0x0400121B RID: 4635
		public float DifficultyHpDrainRate = 5f;

		// Token: 0x0400121C RID: 4636
		public float DifficultyOverall = 5f;

		// Token: 0x0400121D RID: 4637
		public double DifficultySliderMultiplier = 1.4;

		// Token: 0x0400121E RID: 4638
		public double DifficultySliderTickRate = 1.0;

		// Token: 0x04001221 RID: 4641
		public string Tags = string.Empty;

		// Token: 0x04001222 RID: 4642
		public string Title = string.Empty;

		// Token: 0x04001223 RID: 4643
		public string TitleUnicode;
	}
}
