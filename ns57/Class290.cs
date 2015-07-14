using ns24;
using ns55;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common.Helpers;
using System;

namespace ns57
{
	// Token: 0x02000370 RID: 880
	internal sealed class Class290 : Class287
	{
		// Token: 0x06001AA1 RID: 6817
		// RVA: 0x00082CD8 File Offset: 0x00080ED8
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class296 current = Class466.Current;
			if (current.bool_11)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMetaTaiko_NoLetterboxTaiko)));
			}
			if (current.bool_21)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMetaTaiko_NoEpilepsyTaiko)));
			}
			if (current.enum65_0 != Enum65.const_0)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMetaTaiko_NoCountdownTaiko)));
			}
			if (current.DifficultySliderMultiplier != 1.4 && current.DifficultySliderMultiplier != 1.6)
			{
				this.Reports.Add(new AiReport(Severity.Info, Class41.GetString(OsuString.AIMetaTaiko_BadSvTaiko)));
			}
			base.method_1(false);
		}
	}
}
