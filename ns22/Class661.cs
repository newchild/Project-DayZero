using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns78;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using System;

namespace ns22
{
	// Token: 0x020004F5 RID: 1269
	internal class Class661 : Class660
	{
		// Token: 0x040021EE RID: 8686
		internal Class531 class531_2;

		// Token: 0x040021ED RID: 8685
		internal Class537 class537_0;

		// Token: 0x040021EC RID: 8684
		private readonly Class861 class861_0;

		// Token: 0x060028DD RID: 10461
		// RVA: 0x00101C30 File Offset: 0x000FFE30
		internal Class661(int int_4, Class861 class861_1, MatchScoringTypes matchScoringTypes_1, PlayModes playModes_1, SlotTeams slotTeams_1, Mods mods_1) : base(int_4, class861_1.Name, playModes_1)
		{
			base.method_1(slotTeams_1);
			this.class861_0 = class861_1;
			this.matchScoringTypes_0 = matchScoringTypes_1;
			this.mods_0 = mods_1;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class531 class = this.list_0[i];
				if (i == 0)
				{
					class.vector2_5 -= new Vector2(80f, 0f);
				}
				else
				{
					class.vector2_1 += new Vector2(32.4f, 0f);
				}
			}
			this.class537_0 = new Class537(null, null, 0, this.vector2_0 + new Vector2(16.8f, 12.51f), 0.920001f);
			class861_1.method_3(this.class537_0, 51f);
			this.class537_0.float_3 = 0f;
			this.class531_2 = new Class531(Class885.Load("multi-skipped", Enum112.flag_6), Enum115.const_5, Origins.BottomRight, Enum114.const_0, this.vector2_0 + new Vector2(118f, 30f), this.class531_0.float_0 + 1E-06f, true, Color.get_White(), null);
			this.class531_2.float_3 = 0f;
			this.class531_2.method_8(true);
			this.list_0.Add(this.class531_2);
			this.list_0.Add(this.class537_0);
		}
	}
}
