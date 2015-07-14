using ns76;
using ns78;
using osu_common;
using System;

namespace ns22
{
	// Token: 0x020004F6 RID: 1270
	internal sealed class Class662 : Class661
	{
		// Token: 0x060028DE RID: 10462
		// RVA: 0x0001F6FB File Offset: 0x0001D8FB
		internal Class662(int int_4, Class861 class861_1, MatchScoringTypes matchScoringTypes_1, PlayModes playModes_1, SlotTeams slotTeams_1) : base(int_4, class861_1, matchScoringTypes_1, playModes_1, slotTeams_1, Mods.None)
		{
			this.class533_2.Text = string.Empty;
		}

		// Token: 0x060028E0 RID: 10464
		// RVA: 0x0001F71B File Offset: 0x0001D91B
		internal override void vmethod_0(Class512 class512_1)
		{
			this.class512_0 = class512_1;
			this.int_3 = class512_1.int_3;
		}

		// Token: 0x060028DF RID: 10463
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_1(string string_1)
		{
		}
	}
}
