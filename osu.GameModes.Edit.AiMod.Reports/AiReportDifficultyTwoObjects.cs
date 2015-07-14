using osu.GameplayElements.HitObjects;
using System;

namespace osu.GameModes.Edit.AiMod.Reports
{
	// Token: 0x02000307 RID: 775
	public sealed class AiReportDifficultyTwoObjects : AiReportTwoObjects
	{
		// Token: 0x0600175F RID: 5983
		// RVA: 0x00014818 File Offset: 0x00012A18
		public AiReportDifficultyTwoObjects(BeatmapDifficulty difficulty, string condition, HitObjectBase h1, HitObjectBase h2) : base(h1, h2, null, Severity.Info, difficulty + " criteria: " + condition, 0)
		{
		}
	}
}
