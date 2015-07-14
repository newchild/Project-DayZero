using osu.GameplayElements.HitObjects;
using System;

namespace osu.GameModes.Edit.AiMod.Reports
{
	// Token: 0x02000305 RID: 773
	public sealed class AiReportDifficultyOneObject : AiReportOneObject
	{
		// Token: 0x0600175D RID: 5981
		// RVA: 0x000147F5 File Offset: 0x000129F5
		public AiReportDifficultyOneObject(BeatmapDifficulty difficulty, string condition, HitObjectBase h1) : base(h1, h1.StartTime, null, Severity.Info, difficulty + " criteria: " + condition, 0)
		{
		}
	}
}
