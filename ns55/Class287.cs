using ns24;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common.Helpers;
using System;

namespace ns55
{
	// Token: 0x02000366 RID: 870
	internal class Class287 : AiModRuleset
	{
		// Token: 0x04001519 RID: 5401
		public BeatmapDifficulty beatmapDifficulty_0;

		// Token: 0x1700035F RID: 863
		public override AiModType Type
		{
			// Token: 0x06001A77 RID: 6775
			// RVA: 0x000063AE File Offset: 0x000045AE
			get
			{
				return AiModType.Meta;
			}
		}

		// Token: 0x06001A7A RID: 6778
		// RVA: 0x00081918 File Offset: 0x0007FB18
		private bool method_0(string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				char c = string_0[i];
				if (c > 'Ā')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001A7B RID: 6779
		// RVA: 0x00081950 File Offset: 0x0007FB50
		protected void method_1(bool bool_0)
		{
			Class296 current = Class466.Current;
			if (!this.method_0(current.Artist))
			{
				this.Reports.Add(new AiReport(Severity.Error, Class41.GetString(OsuString.AIMeta_RomanizedArtistUnicode)));
			}
			if (!this.method_0(current.Title))
			{
				this.Reports.Add(new AiReport(Severity.Error, Class41.GetString(OsuString.AIMeta_RomanizedTitleUnicode)));
			}
			if (bool_0 && (current.float_1 < 0.3f || current.float_1 > 0.9f))
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMeta_IncorrectStackLeniency)));
			}
		}

		// Token: 0x06001A7C RID: 6780
		// RVA: 0x000819F0 File Offset: 0x0007FBF0
		private void method_2()
		{
			double num = Class466.Current.method_14();
			if (num < 2.0)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Easy;
				return;
			}
			if (num < 3.5)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Normal;
				return;
			}
			if (num < 4.5)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Hard;
				return;
			}
			if (num < 5.0)
			{
				this.beatmapDifficulty_0 = BeatmapDifficulty.Insane;
				return;
			}
			this.beatmapDifficulty_0 = BeatmapDifficulty.Expert;
		}

		// Token: 0x06001A79 RID: 6777
		// RVA: 0x0001654D File Offset: 0x0001474D
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			this.method_1(true);
			this.method_2();
		}
	}
}
