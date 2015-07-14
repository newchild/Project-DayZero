using ns25;
using ns78;
using ns8;
using osu_common;
using osu_common.Bancho.Objects;
using System;

namespace ns5
{
	// Token: 0x020004D5 RID: 1237
	internal sealed class Class10 : bMatch
	{
		// Token: 0x04002109 RID: 8457
		public Class861[] class861_0;

		// Token: 0x060027E0 RID: 10208
		// RVA: 0x000F85B4 File Offset: 0x000F67B4
		public Class10(bMatch bMatch_0) : this(bMatch_0.matchType, bMatch_0.matchScoringType, bMatch_0.matchTeamType, bMatch_0.playMode, bMatch_0.gameName, bMatch_0.gamePassword, bMatch_0.method_3(), bMatch_0.beatmapName, bMatch_0.beatmapChecksum, bMatch_0.beatmapId, bMatch_0.activeMods, bMatch_0.hostId, bMatch_0.specialModes, bMatch_0.Seed)
		{
			this.slotId = bMatch_0.slotId;
		}

		// Token: 0x060027E2 RID: 10210
		// RVA: 0x000F866C File Offset: 0x000F686C
		internal Class10(Class32 class32_0)
		{
			this.class861_0 = new Class861[bMatch.smethod_0()];
			base..ctor(class32_0);
			this.SendPassword = true;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (this.slotId[i] != -1)
				{
					Class861 class = Class809.smethod_28(this.slotId[i], true);
					if (class != null)
					{
						this.class861_0[i] = class;
					}
				}
				else
				{
					this.class861_0[i] = null;
				}
			}
		}

		// Token: 0x060027E1 RID: 10209
		// RVA: 0x000F8628 File Offset: 0x000F6828
		internal Class10(MatchTypes matchTypes_0, MatchScoringTypes matchScoringTypes_0, MatchTeamTypes matchTeamTypes_0, PlayModes playModes_0, string string_0, string string_1, int int_0, string string_2, string string_3, int int_1, Mods mods_0, int int_2, MultiSpecialModes multiSpecialModes_0, int int_3)
		{
			this.class861_0 = new Class861[bMatch.smethod_0()];
			base..ctor(matchTypes_0, matchScoringTypes_0, matchTeamTypes_0, playModes_0, string_0, string_1, int_0, string_2, string_3, int_1, mods_0, int_2, multiSpecialModes_0, int_3);
			this.SendPassword = true;
		}
	}
}
