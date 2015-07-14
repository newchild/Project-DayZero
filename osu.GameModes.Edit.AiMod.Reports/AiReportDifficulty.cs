using System;

namespace osu.GameModes.Edit.AiMod.Reports
{
	// Token: 0x02000303 RID: 771
	public sealed class AiReportDifficulty : AiReport
	{
		// Token: 0x0600175B RID: 5979
		// RVA: 0x000147B8 File Offset: 0x000129B8
		public AiReportDifficulty(BeatmapDifficulty difficulty, string condition) : base(Severity.Info, difficulty + " criteria: " + condition)
		{
		}
	}
}
