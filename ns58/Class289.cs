using ns24;
using ns55;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common.Helpers;
using System;

namespace ns58
{
	// Token: 0x0200036D RID: 877
	internal sealed class Class289 : Class287
	{
		// Token: 0x06001A95 RID: 6805
		// RVA: 0x00082698 File Offset: 0x00080898
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class296 current = Class466.Current;
			double num = current.method_24();
			if (num < 1.5)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Easy;
			}
			else if (num < 2.5)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Normal;
			}
			else if (num < 4.0)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Hard;
			}
			else if (num < 4.5)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Insane;
			}
			else
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Expert;
			}
			if (Math.Round((double)current.DifficultyHpDrainRate) < 4.0 && this.beatmapDifficulty_0 < BeatmapDifficulty.Hard)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaMania_EasyHpBelow4)));
			}
			else if (Math.Round((double)current.DifficultyHpDrainRate) < 7.0 && this.beatmapDifficulty_0 >= BeatmapDifficulty.Hard)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaMania_HardHpBelow7)));
			}
			double num2 = (double)current.ushort_1 * 1.0 / (double)current.int_11;
			if (num2 < 0.05 && Math.Round((double)current.DifficultyOverall) < 8.0)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaMania_VeryLowSliderOdBelow8)));
			}
			else if (num2 < 0.25 && Math.Round((double)current.DifficultyOverall) < 7.0)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaMania_LowSliderOdBelow7)));
			}
			else if (Math.Round((double)current.DifficultyOverall) < 5.0)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaMania_OdBelow5)));
			}
			if (current.bool_11)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMetaMania_NoManiaLetterbox)));
			}
			if (current.enum65_0 != Enum65.const_0)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMetaMania_NoManiaCountdown)));
			}
			base.method_1(false);
		}
	}
}
