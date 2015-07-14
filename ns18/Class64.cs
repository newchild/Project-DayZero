using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns22;
using ns24;
using ns25;
using ns26;
using ns29;
using ns3;
using ns5;
using ns59;
using ns7;
using ns76;
using ns79;
using ns8;
using ns82;
using ns84;
using ns87;
using ns88;
using ns89;
using ns90;
using osu;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns18
{
	// Token: 0x02000512 RID: 1298
	internal sealed class Class64 : Class62
	{
		// Token: 0x02000513 RID: 1299
		[CompilerGenerated]
		private sealed class Class680
		{
			// Token: 0x040022BE RID: 8894
			public Struct13 struct13_0;

			// Token: 0x06002A08 RID: 10760
			// RVA: 0x0010CC48 File Offset: 0x0010AE48
			public void method_0()
			{
				Predicate<Class304> predicate = null;
				if (Class64.class64_0 == null)
				{
					return;
				}
				Class64.class64_0.class668_0.vmethod_6(this.struct13_0);
				if (Class64.bool_55)
				{
					Class64.class657_0.method_1();
				}
				if (Class64.class64_0.class297_0 != null && Class64.class64_0.class297_0.list_3 != null && Class64.class64_0.list_5[(int)this.struct13_0.byte_0] != null)
				{
					List<Class304> arg_8B_0 = Class64.class64_0.class297_0.list_3;
					if (predicate == null)
					{
						predicate = new Predicate<Class304>(this.method_1);
					}
					Class304 class = arg_8B_0.FindLast(predicate);
					if (class != null)
					{
						Class64.class64_0.list_5[(int)this.struct13_0.byte_0].Add(new Vector2((float)this.struct13_0.int_1, (float)Math.Min(1.0, (double)this.struct13_0.int_0 / class.double_0)));
					}
				}
			}

			// Token: 0x06002A09 RID: 10761
			// RVA: 0x000203FC File Offset: 0x0001E5FC
			public bool method_1(Class304 class304_0)
			{
				return this.struct13_0.int_1 < class304_0.EndTime;
			}
		}

		// Token: 0x02000514 RID: 1300
		[CompilerGenerated]
		private sealed class Class681
		{
			// Token: 0x040022BF RID: 8895
			public int int_0;

			// Token: 0x06002A0B RID: 10763
			// RVA: 0x00020411 File Offset: 0x0001E611
			public void method_0()
			{
				if (Class64.class64_0 == null)
				{
					return;
				}
				Class64.class64_0.class668_0.vmethod_10(this.int_0);
			}
		}

		// Token: 0x02000515 RID: 1301
		[CompilerGenerated]
		private sealed class Class682
		{
			// Token: 0x040022C0 RID: 8896
			public int int_0;

			// Token: 0x06002A0D RID: 10765
			// RVA: 0x00020430 File Offset: 0x0001E630
			public void method_0()
			{
				if (Class64.class64_0 == null)
				{
					return;
				}
				Class64.class64_0.class668_0.vmethod_11(this.int_0);
			}
		}

		// Token: 0x040022BC RID: 8892
		[CompilerGenerated]
		private static Action<Class661> action_3;

		// Token: 0x040022A4 RID: 8868
		internal static bool bool_48;

		// Token: 0x040022A5 RID: 8869
		internal static bool bool_49;

		// Token: 0x040022A7 RID: 8871
		internal static bool bool_50;

		// Token: 0x040022AB RID: 8875
		private bool bool_51;

		// Token: 0x040022AC RID: 8876
		internal bool bool_52;

		// Token: 0x040022AD RID: 8877
		private bool bool_53;

		// Token: 0x040022B1 RID: 8881
		private bool bool_54;

		// Token: 0x040022B3 RID: 8883
		internal static bool bool_55;

		// Token: 0x040022B6 RID: 8886
		private bool bool_56;

		// Token: 0x040022B8 RID: 8888
		private bool bool_57;

		// Token: 0x040022BB RID: 8891
		private bool bool_58;

		// Token: 0x040022A6 RID: 8870
		internal static Class10 class10_0;

		// Token: 0x040022AE RID: 8878
		internal Class533 class533_2;

		// Token: 0x040022B0 RID: 8880
		internal static Class64 class64_0;

		// Token: 0x040022B5 RID: 8885
		public static Class657 class657_0;

		// Token: 0x040022AF RID: 8879
		internal Class668 class668_0;

		// Token: 0x040022B2 RID: 8882
		internal int int_35;

		// Token: 0x040022B7 RID: 8887
		private int int_36;

		// Token: 0x040022B9 RID: 8889
		private int int_37;

		// Token: 0x040022A8 RID: 8872
		internal List<Class661> list_4 = new List<Class661>();

		// Token: 0x040022A9 RID: 8873
		internal List<Vector2>[] list_5 = new List<Vector2>[bMatch.smethod_0()];

		// Token: 0x040022AA RID: 8874
		internal static List<Class661> list_6;

		// Token: 0x040022BA RID: 8890
		private string string_1 = "...";

		// Token: 0x040022B4 RID: 8884
		private Struct13 struct13_0;

		// Token: 0x040022BD RID: 8893
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_5;

		// Token: 0x060029E2 RID: 10722
		// RVA: 0x0010C120 File Offset: 0x0010A320
		internal Class64(Class10 class10_1)
		{
			Class64.class10_0 = class10_1;
			Class62.Mode = Class64.class10_0.playMode;
			Class64.bool_55 = class10_1.method_6();
			switch (Class64.class10_0.matchTeamType)
			{
			case MatchTeamTypes.HeadToHead:
				this.class668_0 = new Class671(this);
				break;
			case MatchTeamTypes.TagCoop:
			case MatchTeamTypes.TagTeamVs:
				this.class668_0 = new Class669(this);
				break;
			case MatchTeamTypes.TeamVs:
				this.class668_0 = new Class670(this);
				break;
			}
			Class64.class64_0 = this;
			Class723.smethod_2(null, null);
		}

		// Token: 0x060029E9 RID: 10729
		// RVA: 0x0010C3D4 File Offset: 0x0010A5D4
		protected override void Dispose(bool bool_59)
		{
			Class64.class64_0 = null;
			if (Class64.class657_0 != null)
			{
				Class64.class657_0.method_5();
			}
			this.method_83();
			Class64.list_6 = new List<Class661>(this.list_4);
			this.list_4 = null;
			this.class668_0.Dispose();
			if (Class115.osuModes_1 != OsuModes.RankingTagCoop && Class115.osuModes_1 != OsuModes.RankingTeam && Class115.osuModes_1 != OsuModes.RankingVs)
			{
				Class64.smethod_28();
			}
			base.Dispose(bool_59);
		}

		// Token: 0x060029F1 RID: 10737
		// RVA: 0x0002030C File Offset: 0x0001E50C
		public override void Draw()
		{
			if (Class62.bool_6)
			{
				Class733.bool_1 = false;
			}
			base.Draw();
		}

		// Token: 0x060029F5 RID: 10741
		// RVA: 0x0010C744 File Offset: 0x0010A944
		public override void imethod_2()
		{
			if (!Class809.bool_4 && Class115.enum113_0 == Enum113.const_2)
			{
				Class723.smethod_4(Class41.GetString(OsuString.Lobby_Bancho_Fail));
				Class115.smethod_70(OsuModes.Menu, false);
			}
			if (!Class64.bool_48)
			{
				base.method_45();
				return;
			}
			if (base.method_45())
			{
				return;
			}
			if (!this.bool_56)
			{
				this.bool_56 = true;
				Class723.smethod_2(null, null);
			}
			if (!this.bool_25 && Class331.smethod_79())
			{
				Class723.smethod_2(null, null);
			}
			if (this.bool_52)
			{
				this.class668_0.vmethod_15();
			}
			base.imethod_2();
			if (this.bool_25)
			{
				this.method_84();
			}
			if (Class64.bool_50)
			{
				this.vmethod_25();
			}
			if (this.bool_53 && Class115.enum113_0 == Enum113.const_2)
			{
				base.method_63();
			}
			this.class668_0.vmethod_4();
			this.method_81();
		}

		// Token: 0x060029E7 RID: 10727
		// RVA: 0x0010C258 File Offset: 0x0010A458
		public override void Initialize()
		{
			if (Class64.class10_0 == null)
			{
				Class115.smethod_70(OsuModes.Lobby, false);
				return;
			}
			Class64.list_6 = this.list_4;
			if (Class115.osuModes_2 != OsuModes.Play)
			{
				Class64.bool_48 = false;
				Class64.bool_49 = false;
				Class62.int_9 = 0;
			}
			Class64.bool_50 = false;
			if ((Class64.class10_0.specialModes & MultiSpecialModes.FreeMod) == MultiSpecialModes.None)
			{
				Class876.class623_0 = Class64.class10_0.activeMods;
			}
			base.Initialize();
		}

		// Token: 0x060029E4 RID: 10724
		// RVA: 0x0002026B File Offset: 0x0001E46B
		private void method_80()
		{
			List<Class661> arg_23_0 = this.list_4;
			if (Class64.action_3 == null)
			{
				Class64.action_3 = new Action<Class661>(Class64.smethod_35);
			}
			arg_23_0.ForEach(Class64.action_3);
		}

		// Token: 0x060029F7 RID: 10743
		// RVA: 0x0010C884 File Offset: 0x0010AA84
		private void method_81()
		{
			if (this.bool_57 && Class115.int_1 - this.int_36 >= 400)
			{
				this.bool_57 = false;
				this.int_36 = Class115.int_1;
				Class809.smethod_34(Enum3.const_47, this.struct13_0);
				return;
			}
		}

		// Token: 0x060029F9 RID: 10745
		// RVA: 0x0002035F File Offset: 0x0001E55F
		internal void method_82()
		{
			this.class533_2.Text = this.string_1;
		}

		// Token: 0x060029FE RID: 10750
		// RVA: 0x0010CAC8 File Offset: 0x0010ACC8
		internal void method_83()
		{
			for (int i = this.list_4.Count - 1; i >= 0; i--)
			{
				Class661 class = this.list_4[i];
				if (class != null && class.class512_0 != null)
				{
					class.class512_0.list_0 = this.list_5[i];
				}
			}
		}

		// Token: 0x06002A00 RID: 10752
		// RVA: 0x0002039C File Offset: 0x0001E59C
		internal void method_84()
		{
			if (!this.bool_58)
			{
				Class809.smethod_34(Enum3.const_49, null);
				this.bool_58 = true;
			}
		}

		// Token: 0x060029EA RID: 10730
		// RVA: 0x000202A3 File Offset: 0x0001E4A3
		public static void smethod_28()
		{
			Class47 arg_23_0 = Class115.class47_0;
			if (Class64.voidDelegate_5 == null)
			{
				Class64.voidDelegate_5 = new VoidDelegate(Class64.smethod_36);
			}
			arg_23_0.Add(Class64.voidDelegate_5, false);
		}

		// Token: 0x060029FA RID: 10746
		// RVA: 0x0010CA2C File Offset: 0x0010AC2C
		internal static void smethod_29(Struct13 struct13_1)
		{
			Class64.Class680 class = new Class64.Class680();
			class.struct13_0 = struct13_1;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060029FB RID: 10747
		// RVA: 0x00020372 File Offset: 0x0001E572
		internal static void smethod_30(int int_38)
		{
			Class64.class10_0.slotStatus[int_38] = SlotStatus.flag_8;
			if (Class64.class64_0 != null)
			{
				Class64.class64_0.class668_0.vmethod_14(int_38);
			}
		}

		// Token: 0x060029FC RID: 10748
		// RVA: 0x0010CA60 File Offset: 0x0010AC60
		internal static void smethod_31(int int_38)
		{
			Class64.Class681 class = new Class64.Class681();
			class.int_0 = int_38;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060029FD RID: 10749
		// RVA: 0x0010CA94 File Offset: 0x0010AC94
		internal static void smethod_32(int int_38)
		{
			Class64.Class682 class = new Class64.Class682();
			class.int_0 = int_38;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06002A02 RID: 10754
		// RVA: 0x000203C8 File Offset: 0x0001E5C8
		internal static void smethod_33()
		{
			Class64.bool_49 = true;
		}

		// Token: 0x06002A04 RID: 10756
		// RVA: 0x0010CB88 File Offset: 0x0010AD88
		internal static bool smethod_34(SlotTeams slotTeams_0)
		{
			if (Class64.list_6 == null)
			{
				return false;
			}
			foreach (Class660 current in Class64.list_6)
			{
				if (current != null && current.method_0() == slotTeams_0 && current.bool_3)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002A05 RID: 10757
		// RVA: 0x000203DD File Offset: 0x0001E5DD
		[CompilerGenerated]
		private static void smethod_35(Class661 class661_0)
		{
			if (class661_0 != null)
			{
				class661_0.class531_2.method_16(100, Enum70.const_0);
				class661_0.class531_2.bool_0 = false;
			}
		}

		// Token: 0x06002A06 RID: 10758
		// RVA: 0x0010CBF8 File Offset: 0x0010ADF8
		[CompilerGenerated]
		private static void smethod_36()
		{
			if (Class62.class664_0 != null)
			{
				Class62.class664_0.Dispose();
				Class62.class664_0 = null;
			}
			if (Class64.class657_0 != null)
			{
				Class64.class657_0.Dispose();
				Class64.class657_0 = null;
			}
			Class64.list_6 = null;
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				Class64.class10_0 = null;
			}
		}

		// Token: 0x060029F0 RID: 10736
		// RVA: 0x0010C570 File Offset: 0x0010A770
		protected override void vmethod_11()
		{
			this.int_35 = Class64.class10_0.method_8(Class115.class861_0.int_1);
			if (this.int_35 < 0)
			{
				Class765.smethod_0(new Class764(new Exception(string.Concat(new object[]
				{
					"local user id:",
					Class115.class861_0.int_1,
					"\nMatch contains:",
					Class64.class10_0.slotId[0],
					",",
					Class64.class10_0.slotId[1],
					",",
					Class64.class10_0.slotId[2],
					",",
					Class64.class10_0.slotId[3],
					",",
					Class64.class10_0.slotId[4],
					",",
					Class64.class10_0.slotId[5],
					",",
					Class64.class10_0.slotId[6],
					",",
					Class64.class10_0.slotId[7]
				})))
				{
					string_0 = "local player wasnt in the mp match"
				});
				Class72.smethod_3();
				return;
			}
			this.list_4.Clear();
			Class62.class664_0 = this.class668_0.vmethod_5();
			if (this.class427_0.vmethod_1())
			{
				Class62.class664_0.method_1(true);
			}
			Class62.class664_0.bool_3 = true;
			this.class668_0.vmethod_7();
			if (Class64.bool_55)
			{
				Class64.class657_0 = new Class657(this, Class62.class664_0.class911_0);
			}
			base.vmethod_11();
		}

		// Token: 0x060029E3 RID: 10723
		// RVA: 0x0010C1D4 File Offset: 0x0010A3D4
		internal override bool vmethod_13()
		{
			if (Class62.bool_42)
			{
				base.vmethod_13();
				return true;
			}
			if (Class62.int_9 > 0)
			{
				Class723.smethod_2(null, null);
				this.bool_54 = false;
				this.method_80();
				base.vmethod_13();
				return true;
			}
			if (!this.bool_54 && Class331.int_7 < this.int_24 && this.enum110_0 == Enum110.const_1)
			{
				this.bool_54 = true;
				Class723.smethod_1(Class41.GetString(OsuString.PlayerVs_SkipRequest), 2000);
				Class809.smethod_34(Enum3.const_60, null);
			}
			return false;
		}

		// Token: 0x060029EE RID: 10734
		// RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		protected override bool vmethod_14()
		{
			bool flag = false;
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (Class64.class10_0.slotStatus[i] == SlotStatus.flag_3 || Class64.class10_0.slotStatus[i] == SlotStatus.flag_5 || Class64.class10_0.slotStatus[i] == SlotStatus.flag_6)
				{
					num++;
				}
			}
			if (num < 2)
			{
				this.method_84();
				Class62.class512_0.bool_0 = false;
				Class115.smethod_70(OsuModes.MatchSetup, false);
				flag = true;
			}
			else if (this.bool_51 || !this.class523_0.bool_0)
			{
				Class72.smethod_3();
				flag = true;
			}
			if (flag)
			{
				Class723.smethod_3();
			}
			return flag;
		}

		// Token: 0x060029EF RID: 10735
		// RVA: 0x000202EB File Offset: 0x0001E4EB
		internal override void vmethod_16()
		{
			if (this.vmethod_14())
			{
				return;
			}
			Class723.smethod_4(Class41.GetString(OsuString.PlayerVs_MultiplayerExit));
			this.bool_51 = true;
		}

		// Token: 0x060029F4 RID: 10740
		// RVA: 0x0002034E File Offset: 0x0001E54E
		protected override bool vmethod_17()
		{
			return base.vmethod_17() && Class64.bool_48;
		}

		// Token: 0x060029E6 RID: 10726
		// RVA: 0x00020295 File Offset: 0x0001E495
		protected override void vmethod_18()
		{
			this.method_80();
			base.vmethod_18();
		}

		// Token: 0x06002A03 RID: 10755
		// RVA: 0x000203D0 File Offset: 0x0001E5D0
		internal override Class512 vmethod_19()
		{
			return this.class668_0.vmethod_0();
		}

		// Token: 0x06002A01 RID: 10753
		// RVA: 0x000203B5 File Offset: 0x0001E5B5
		protected override void vmethod_20()
		{
			this.class668_0.vmethod_9();
			base.vmethod_20();
		}

		// Token: 0x060029F3 RID: 10739
		// RVA: 0x00020341 File Offset: 0x0001E541
		protected override bool vmethod_21()
		{
			return this.class668_0.vmethod_2();
		}

		// Token: 0x060029ED RID: 10733
		// RVA: 0x0010C448 File Offset: 0x0010A648
		internal override void vmethod_22()
		{
			if (Class876.smethod_5(Mods.NoFail))
			{
				return;
			}
			if (!this.class668_0.vmethod_1())
			{
				if (!Class62.bool_6)
				{
					Class809.smethod_34(Enum3.const_56, null);
					this.method_84();
					this.class427_0.vmethod_37(false);
				}
				return;
			}
			if (!this.class427_0.vmethod_37(true))
			{
				return;
			}
			if (this.bool_52)
			{
				return;
			}
			this.bool_52 = true;
			Class723.smethod_1(Class41.GetString(OsuString.PlayerVs_FailedButKeepGoing), 3000);
			Class809.smethod_34(Enum3.const_56, null);
			Class62.class512_0.bool_0 = false;
		}

		// Token: 0x060029EC RID: 10732
		// RVA: 0x000202DE File Offset: 0x0001E4DE
		protected override void vmethod_23()
		{
			this.class668_0.vmethod_8();
		}

		// Token: 0x060029F6 RID: 10742
		// RVA: 0x0010C818 File Offset: 0x0010AA18
		protected override void vmethod_24()
		{
			if (Class802.smethod_0())
			{
				return;
			}
			this.struct13_0 = Class62.smethod_8();
			this.struct13_0.bool_0 = !this.bool_52;
			this.struct13_0.int_3 = (int)((this.class304_1 != null) ? this.class304_1.Type : HitObjectType.Normal);
			this.class304_1 = null;
			this.bool_57 = true;
			this.method_81();
		}

		// Token: 0x060029F8 RID: 10744
		// RVA: 0x0010C8D4 File Offset: 0x0010AAD4
		protected override void vmethod_25()
		{
			if (!Class115.bool_13)
			{
				return;
			}
			if (!this.bool_25 && !Class62.bool_6 && (Class872.bool_1 || Class62.class664_0.bool_0))
			{
				if (Class62.class664_0.class911_0.float_0 < 1f)
				{
					Class62.class664_0.class911_0.float_0 = Math.Min(1f, Class62.class664_0.class911_0.float_0 + 0.04f);
				}
			}
			else if (Class62.class664_0.class911_0.float_0 > 0f)
			{
				Class62.class664_0.class911_0.float_0 = Math.Max(0f, Class62.class664_0.class911_0.float_0 - 0.04f);
			}
			if (Class64.bool_50)
			{
				if (Class115.int_1 - this.int_37 < 1000)
				{
					return;
				}
				if (Class331.int_7 - this.class297_0.list_3[0].EndTime < 10000)
				{
					this.class533_2.Text = this.string_1;
					return;
				}
				this.int_37 = Class115.int_1;
				if (Class62.class664_0.vmethod_1(false) || this.class533_2.Text == this.string_1)
				{
					this.class668_0.vmethod_13();
				}
				Class64.bool_50 = false;
			}
		}

		// Token: 0x060029FF RID: 10751
		// RVA: 0x0010CB18 File Offset: 0x0010AD18
		internal override void vmethod_26(bool bool_59)
		{
			if (!Class64.bool_49 && !bool_59)
			{
				if (!this.bool_53)
				{
					this.bool_53 = true;
					this.method_84();
					Class723.smethod_1(Class41.GetString(OsuString.PlayerVs_WaitingForFinish), 300000);
				}
				return;
			}
			Class62.class664_0.vmethod_1(false);
			if (Class64.class657_0 != null)
			{
				Class115.smethod_70(OsuModes.RankingTeam, false);
				Class723.smethod_2(null, null);
				return;
			}
			this.class668_0.vmethod_12();
		}

		// Token: 0x060029F2 RID: 10738
		// RVA: 0x00020321 File Offset: 0x0001E521
		protected override void vmethod_29()
		{
			base.vmethod_29();
			if (Class64.bool_55 && Class64.class657_0 != null)
			{
				Class64.class657_0.Draw();
			}
		}

		// Token: 0x060029E5 RID: 10725
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_30()
		{
			return false;
		}

		// Token: 0x060029E1 RID: 10721
		// RVA: 0x0002025A File Offset: 0x0001E45A
		public override bool vmethod_5()
		{
			return Class64.bool_48 && base.vmethod_5();
		}

		// Token: 0x060029E8 RID: 10728
		// RVA: 0x0010C2C8 File Offset: 0x0010A4C8
		protected override void vmethod_6()
		{
			base.vmethod_6();
			this.class533_2 = new Class533(string.Empty, 80f, new Vector2(10f, 10f), Vector2.get_Zero(), 0f, true, new Color(255, 255, 255, 100), false);
			this.class533_2.enum115_0 = Enum115.const_13;
			this.class533_2.origins_0 = Origins.BottomRight;
			this.class911_4.Add(this.class533_2);
			if (!Class64.bool_48)
			{
				Class723.smethod_1(Class41.GetString(OsuString.PlayerVs_WaitingForPlayers), 300000);
			}
			if (Class64.class10_0.beatmapChecksum != Class466.Current.string_3)
			{
				Class115.smethod_70(OsuModes.Lobby, false);
				return;
			}
			this.class668_0.Initialize();
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				this.list_5[i] = new List<Vector2>();
				if (Class64.class10_0.slotStatus[i] == SlotStatus.flag_8)
				{
					this.class668_0.vmethod_14(i);
				}
			}
		}

		// Token: 0x060029EB RID: 10731
		// RVA: 0x000202CD File Offset: 0x0001E4CD
		protected override bool vmethod_7(bool bool_59)
		{
			Class809.smethod_34(Enum3.const_52, null);
			return base.vmethod_7(bool_59);
		}
	}
}
