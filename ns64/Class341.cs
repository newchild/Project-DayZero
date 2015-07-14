using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns19;
using ns24;
using ns26;
using ns27;
using ns29;
using ns41;
using ns6;
using ns8;
using ns81;
using ns82;
using ns84;
using ns90;
using osu;
using osu.GameModes.Other;
using osu.GameModes.Play.Components;
using osu.GameModes.Select;
using osu.GameplayElements.Beatmaps;
using osu.Properties;
using osu_common;
using osu_common.Helpers;
using osu_common.Updater;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns64
{
	// Token: 0x0200034B RID: 843
	internal static class Class341
	{
		// Token: 0x0200034C RID: 844
		[CompilerGenerated]
		private sealed class Class342
		{
			// Token: 0x04001426 RID: 5158
			public bool bool_0;

			// Token: 0x060019A5 RID: 6565
			// RVA: 0x00015D2B File Offset: 0x00013F2B
			public void method_0()
			{
				if (Class115.class80_0 != null)
				{
					Class115.class80_0.method_27(true);
					Class115.class80_0.method_8(this.bool_0);
				}
			}
		}

		// Token: 0x0200034D RID: 845
		[CompilerGenerated]
		private sealed class Class343
		{
			// Token: 0x04001427 RID: 5159
			public FrameSync frameSync_0;

			// Token: 0x060019A7 RID: 6567
			// RVA: 0x00015D4F File Offset: 0x00013F4F
			public void method_0()
			{
				Class341.class605_1.Value = this.frameSync_0;
			}
		}

		// Token: 0x04001422 RID: 5154
		[CompilerGenerated]
		private static Action<Class296> action_0;

		// Token: 0x04001423 RID: 5155
		[CompilerGenerated]
		private static Action<Class296> action_1;

		// Token: 0x0400137B RID: 4987
		private static Class605<FrameSync> class605_0;

		// Token: 0x0400137C RID: 4988
		private static Class605<FrameSync> class605_1;

		// Token: 0x040013E8 RID: 5096
		internal static Class605<string> class605_10;

		// Token: 0x040013E9 RID: 5097
		internal static Class605<string> class605_11;

		// Token: 0x040013EA RID: 5098
		internal static Class605<string> class605_12;

		// Token: 0x040013EB RID: 5099
		internal static Class605<string> class605_13;

		// Token: 0x040013EC RID: 5100
		internal static Class605<string> class605_14;

		// Token: 0x040013ED RID: 5101
		internal static Class605<string> class605_15;

		// Token: 0x040013EE RID: 5102
		internal static Class605<string> class605_16;

		// Token: 0x040013EF RID: 5103
		internal static Class605<string> class605_17;

		// Token: 0x040013F0 RID: 5104
		internal static Class605<string> class605_18;

		// Token: 0x040013F1 RID: 5105
		internal static Class605<string> class605_19;

		// Token: 0x0400137D RID: 4989
		internal static Class605<ProgressBarTypes> class605_2;

		// Token: 0x040013F3 RID: 5107
		internal static Class605<string> class605_20;

		// Token: 0x040013F4 RID: 5108
		internal static Class605<Enum103> class605_21;

		// Token: 0x040013F5 RID: 5109
		internal static Class605<Enum102> class605_22;

		// Token: 0x040013F7 RID: 5111
		internal static Class605<TreeGroupMode> class605_23;

		// Token: 0x040013F8 RID: 5112
		internal static Class605<TreeSortMode> class605_24;

		// Token: 0x040013FE RID: 5118
		public static Class605<ReleaseStream> class605_25;

		// Token: 0x04001403 RID: 5123
		internal static Class605<FrameSync> class605_26;

		// Token: 0x0400137E RID: 4990
		internal static Class605<string> class605_3;

		// Token: 0x040013D9 RID: 5081
		internal static Class605<ImageFileFormat> class605_4;

		// Token: 0x040013DE RID: 5086
		internal static Class605<RankingType> class605_5;

		// Token: 0x040013DF RID: 5087
		internal static Class605<ScaleMode> class605_6;

		// Token: 0x040013E0 RID: 5088
		internal static Class605<ScoreMeterType> class605_7;

		// Token: 0x040013E1 RID: 5089
		internal static Class605<ScreenMode> class605_8;

		// Token: 0x040013E7 RID: 5095
		internal static Class605<string> class605_9;

		// Token: 0x0400137A RID: 4986
		internal static Class606 class606_0;

		// Token: 0x0400137F RID: 4991
		internal static Class606 class606_1;

		// Token: 0x04001388 RID: 5000
		internal static Class606 class606_10;

		// Token: 0x04001389 RID: 5001
		internal static Class606 class606_11;

		// Token: 0x0400138A RID: 5002
		internal static Class606 class606_12;

		// Token: 0x0400138B RID: 5003
		internal static Class606 class606_13;

		// Token: 0x0400138C RID: 5004
		internal static Class606 class606_14;

		// Token: 0x0400138D RID: 5005
		internal static Class606 class606_15;

		// Token: 0x0400138E RID: 5006
		internal static Class606 class606_16;

		// Token: 0x0400138F RID: 5007
		internal static Class606 class606_17;

		// Token: 0x04001390 RID: 5008
		internal static Class606 class606_18;

		// Token: 0x04001391 RID: 5009
		internal static Class606 class606_19;

		// Token: 0x04001380 RID: 4992
		internal static Class606 class606_2;

		// Token: 0x04001392 RID: 5010
		internal static Class606 class606_20;

		// Token: 0x04001393 RID: 5011
		internal static Class606 class606_21;

		// Token: 0x04001394 RID: 5012
		internal static Class606 class606_22;

		// Token: 0x04001395 RID: 5013
		internal static Class606 class606_23;

		// Token: 0x04001396 RID: 5014
		internal static Class606 class606_24;

		// Token: 0x04001397 RID: 5015
		internal static Class606 class606_25;

		// Token: 0x04001398 RID: 5016
		internal static Class606 class606_26;

		// Token: 0x04001399 RID: 5017
		internal static Class606 class606_27;

		// Token: 0x0400139A RID: 5018
		internal static Class606 class606_28;

		// Token: 0x0400139B RID: 5019
		internal static Class606 class606_29;

		// Token: 0x04001381 RID: 4993
		internal static Class606 class606_3;

		// Token: 0x0400139C RID: 5020
		internal static Class606 class606_30;

		// Token: 0x0400139D RID: 5021
		internal static Class606 class606_31;

		// Token: 0x0400139E RID: 5022
		internal static Class606 class606_32;

		// Token: 0x0400139F RID: 5023
		internal static Class606 class606_33;

		// Token: 0x040013A0 RID: 5024
		internal static Class606 class606_34;

		// Token: 0x040013A1 RID: 5025
		internal static Class606 class606_35;

		// Token: 0x040013A2 RID: 5026
		internal static Class606 class606_36;

		// Token: 0x040013A3 RID: 5027
		internal static Class606 class606_37;

		// Token: 0x040013A4 RID: 5028
		internal static Class606 class606_38;

		// Token: 0x040013A5 RID: 5029
		internal static Class606 class606_39;

		// Token: 0x04001382 RID: 4994
		internal static Class606 class606_4;

		// Token: 0x040013A6 RID: 5030
		internal static Class606 class606_40;

		// Token: 0x040013A7 RID: 5031
		internal static Class606 class606_41;

		// Token: 0x040013A8 RID: 5032
		internal static Class606 class606_42;

		// Token: 0x040013A9 RID: 5033
		internal static Class606 class606_43;

		// Token: 0x040013AA RID: 5034
		internal static Class606 class606_44;

		// Token: 0x040013AB RID: 5035
		internal static Class606 class606_45;

		// Token: 0x040013AC RID: 5036
		internal static Class606 class606_46;

		// Token: 0x040013AD RID: 5037
		internal static Class606 class606_47;

		// Token: 0x040013AE RID: 5038
		internal static Class606 class606_48;

		// Token: 0x040013AF RID: 5039
		internal static Class606 class606_49;

		// Token: 0x04001383 RID: 4995
		internal static Class606 class606_5;

		// Token: 0x040013B0 RID: 5040
		internal static Class606 class606_50;

		// Token: 0x040013B1 RID: 5041
		internal static Class606 class606_51;

		// Token: 0x040013B2 RID: 5042
		internal static Class606 class606_52;

		// Token: 0x040013B3 RID: 5043
		internal static Class606 class606_53;

		// Token: 0x040013B4 RID: 5044
		internal static Class606 class606_54;

		// Token: 0x040013B5 RID: 5045
		internal static Class606 class606_55;

		// Token: 0x040013B6 RID: 5046
		internal static Class606 class606_56;

		// Token: 0x040013B7 RID: 5047
		internal static Class606 class606_57;

		// Token: 0x040013B8 RID: 5048
		internal static Class606 class606_58;

		// Token: 0x040013B9 RID: 5049
		internal static Class606 class606_59;

		// Token: 0x04001384 RID: 4996
		internal static Class606 class606_6;

		// Token: 0x040013BA RID: 5050
		internal static Class606 class606_60;

		// Token: 0x040013BB RID: 5051
		internal static Class606 class606_61;

		// Token: 0x040013BC RID: 5052
		internal static Class606 class606_62;

		// Token: 0x040013BD RID: 5053
		internal static Class606 class606_63;

		// Token: 0x040013BE RID: 5054
		internal static Class606 class606_64;

		// Token: 0x040013BF RID: 5055
		internal static Class606 class606_65;

		// Token: 0x040013C0 RID: 5056
		internal static Class606 class606_66;

		// Token: 0x040013C1 RID: 5057
		internal static Class606 class606_67;

		// Token: 0x040013C3 RID: 5059
		internal static Class606 class606_68;

		// Token: 0x040013C4 RID: 5060
		internal static Class606 class606_69;

		// Token: 0x04001385 RID: 4997
		internal static Class606 class606_7;

		// Token: 0x040013C5 RID: 5061
		internal static Class606 class606_70;

		// Token: 0x040013C6 RID: 5062
		internal static Class606 class606_71;

		// Token: 0x040013D2 RID: 5074
		internal static Class606 class606_72;

		// Token: 0x040013D3 RID: 5075
		internal static Class606 class606_73;

		// Token: 0x040013E2 RID: 5090
		internal static Class606 class606_74;

		// Token: 0x040013E3 RID: 5091
		internal static Class606 class606_75;

		// Token: 0x040013E4 RID: 5092
		internal static Class606 class606_76;

		// Token: 0x040013E5 RID: 5093
		internal static Class606 class606_77;

		// Token: 0x040013E6 RID: 5094
		internal static Class606 class606_78;

		// Token: 0x040013F6 RID: 5110
		internal static Class606 class606_79;

		// Token: 0x04001386 RID: 4998
		internal static Class606 class606_8;

		// Token: 0x040013F9 RID: 5113
		internal static Class606 class606_80;

		// Token: 0x040013FA RID: 5114
		internal static Class606 class606_81;

		// Token: 0x040013FC RID: 5116
		internal static Class606 class606_82;

		// Token: 0x040013FD RID: 5117
		internal static Class606 class606_83;

		// Token: 0x040013FF RID: 5119
		public static Class606 class606_84;

		// Token: 0x04001400 RID: 5120
		public static Class606 class606_85;

		// Token: 0x04001402 RID: 5122
		public static Class606 class606_86;

		// Token: 0x04001404 RID: 5124
		internal static Class606 class606_87;

		// Token: 0x04001387 RID: 4999
		internal static Class606 class606_9;

		// Token: 0x040013C2 RID: 5058
		internal static Class607 class607_0;

		// Token: 0x040013C7 RID: 5063
		internal static Class607 class607_1;

		// Token: 0x040013C8 RID: 5064
		internal static Class607 class607_2;

		// Token: 0x040013C9 RID: 5065
		internal static Class607 class607_3;

		// Token: 0x040013FB RID: 5115
		internal static Class607 class607_4;

		// Token: 0x040013CA RID: 5066
		internal static Class608 class608_0;

		// Token: 0x040013CB RID: 5067
		internal static Class608 class608_1;

		// Token: 0x040013D6 RID: 5078
		internal static Class608 class608_10;

		// Token: 0x040013D7 RID: 5079
		internal static Class608 class608_11;

		// Token: 0x040013D8 RID: 5080
		internal static Class608 class608_12;

		// Token: 0x040013DA RID: 5082
		internal static Class608 class608_13;

		// Token: 0x040013DB RID: 5083
		internal static Class608 class608_14;

		// Token: 0x040013DC RID: 5084
		internal static Class608 class608_15;

		// Token: 0x040013DD RID: 5085
		internal static Class608 class608_16;

		// Token: 0x04001401 RID: 5121
		internal static Class608 class608_17;

		// Token: 0x040013CC RID: 5068
		internal static Class608 class608_2;

		// Token: 0x040013CD RID: 5069
		internal static Class608 class608_3;

		// Token: 0x040013CE RID: 5070
		internal static Class608 class608_4;

		// Token: 0x040013CF RID: 5071
		internal static Class608 class608_5;

		// Token: 0x040013D0 RID: 5072
		internal static Class608 class608_6;

		// Token: 0x040013D1 RID: 5073
		internal static Class608 class608_7;

		// Token: 0x040013D4 RID: 5076
		internal static Class608 class608_8;

		// Token: 0x040013D5 RID: 5077
		internal static Class608 class608_9;

		// Token: 0x04001379 RID: 4985
		internal static readonly Dictionary<string, object> dictionary_0;

		// Token: 0x04001405 RID: 5125
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04001406 RID: 5126
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x0400140F RID: 5135
		[CompilerGenerated]
		private static EventHandler eventHandler_10;

		// Token: 0x04001410 RID: 5136
		[CompilerGenerated]
		private static EventHandler eventHandler_11;

		// Token: 0x04001411 RID: 5137
		[CompilerGenerated]
		private static EventHandler eventHandler_12;

		// Token: 0x04001412 RID: 5138
		[CompilerGenerated]
		private static EventHandler eventHandler_13;

		// Token: 0x04001413 RID: 5139
		[CompilerGenerated]
		private static EventHandler eventHandler_14;

		// Token: 0x04001414 RID: 5140
		[CompilerGenerated]
		private static EventHandler eventHandler_15;

		// Token: 0x04001415 RID: 5141
		[CompilerGenerated]
		private static EventHandler eventHandler_16;

		// Token: 0x04001416 RID: 5142
		[CompilerGenerated]
		private static EventHandler eventHandler_17;

		// Token: 0x04001417 RID: 5143
		[CompilerGenerated]
		private static EventHandler eventHandler_18;

		// Token: 0x04001418 RID: 5144
		[CompilerGenerated]
		private static EventHandler eventHandler_19;

		// Token: 0x04001407 RID: 5127
		[CompilerGenerated]
		private static EventHandler eventHandler_2;

		// Token: 0x04001419 RID: 5145
		[CompilerGenerated]
		private static EventHandler eventHandler_20;

		// Token: 0x0400141A RID: 5146
		[CompilerGenerated]
		private static EventHandler eventHandler_21;

		// Token: 0x0400141B RID: 5147
		[CompilerGenerated]
		private static EventHandler eventHandler_22;

		// Token: 0x0400141C RID: 5148
		[CompilerGenerated]
		private static EventHandler eventHandler_23;

		// Token: 0x0400141D RID: 5149
		[CompilerGenerated]
		private static EventHandler eventHandler_24;

		// Token: 0x0400141E RID: 5150
		[CompilerGenerated]
		private static EventHandler eventHandler_25;

		// Token: 0x0400141F RID: 5151
		[CompilerGenerated]
		private static EventHandler eventHandler_26;

		// Token: 0x04001420 RID: 5152
		[CompilerGenerated]
		private static EventHandler eventHandler_27;

		// Token: 0x04001421 RID: 5153
		[CompilerGenerated]
		private static EventHandler eventHandler_28;

		// Token: 0x04001408 RID: 5128
		[CompilerGenerated]
		private static EventHandler eventHandler_3;

		// Token: 0x04001409 RID: 5129
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x0400140A RID: 5130
		[CompilerGenerated]
		private static EventHandler eventHandler_5;

		// Token: 0x0400140B RID: 5131
		[CompilerGenerated]
		private static EventHandler eventHandler_6;

		// Token: 0x0400140C RID: 5132
		[CompilerGenerated]
		private static EventHandler eventHandler_7;

		// Token: 0x0400140D RID: 5133
		[CompilerGenerated]
		private static EventHandler eventHandler_8;

		// Token: 0x0400140E RID: 5134
		[CompilerGenerated]
		private static EventHandler eventHandler_9;

		// Token: 0x040013F2 RID: 5106
		internal static string string_0;

		// Token: 0x04001424 RID: 5156
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04001425 RID: 5157
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x06001972 RID: 6514
		// RVA: 0x00015A76 File Offset: 0x00013C76
		static Class341()
		{
			Class341.dictionary_0 = new Dictionary<string, object>();
			Class341.Initialize();
		}

		// Token: 0x06001973 RID: 6515
		// RVA: 0x000793A8 File Offset: 0x000775A8
		public static void Initialize()
		{
			if (Class341.dictionary_0.Count > 0)
			{
				return;
			}
			Class341.smethod_2("osu!.cfg");
			Class341.smethod_2(Class341.smethod_1());
			Class115.class605_0 = Class341.ReadString("BeatmapDirectory", "Songs");
			Class115.class605_0.Value = Class34.smethod_15(Class115.class605_0.Value);
			if (!Directory.Exists(Class115.class605_0.Value))
			{
				Class115.class605_0.Value = "Songs";
				Class723.smethod_4(Class41.GetString(OsuString.ConfigManager_SongFolderNotFound));
			}
			Class331.class608_2 = Class341.smethod_10("VolumeUniversal", 100, 0, 100);
			Class331.class608_0 = Class341.smethod_10("VolumeEffect", 80, 0, 100);
			Class331.class608_1 = Class341.smethod_10("VolumeMusic", 80, 0, 100);
			Class341.class606_1 = Class341.smethod_9("AllowPublicInvites", true);
			Class341.class606_2 = Class341.smethod_9("AutoChatHide", true);
			Class341.class606_3 = Class341.smethod_9("AutomaticDownload", true);
			Class341.class606_0 = Class341.smethod_9("BlockNonFriendPM", false);
			Class341.class606_4 = Class341.smethod_9("Bloom", false);
			Class341.class606_5 = Class341.smethod_9("BloomSoftening", false);
			Class341.class606_6 = Class341.smethod_9("BossKeyFirstActivation", true);
			Class341.class606_7 = Class341.smethod_9("ChatAudibleHighlight", true);
			Class341.class605_9 = Class341.ReadString("ChatChannels", string.Empty);
			Class341.class606_9 = Class341.smethod_9("ChatFilter", false);
			Class341.class606_10 = Class341.smethod_9("ChatHighlightName", true);
			Class341.class605_10 = Class341.ReadString("ChatLastChannel", string.Empty);
			Class341.class606_11 = Class341.smethod_9("ChatRemoveForeign", false);
			Class341.class605_22 = Class341.smethod_8<Enum102>("ChatSortMode", Enum102.const_1, false);
			Class341.class606_12 = Class341.smethod_9("ComboBurst", true);
			Class341.class606_13 = Class341.smethod_9("ComboFire", false);
			Class341.class607_1 = Class341.smethod_10("ComboFireHeight", 3, -2147483648, 2147483647);
			Class341.class606_14 = Class341.smethod_9("ConfirmExit", false);
			Class341.class606_67 = Class341.smethod_9("AutoSendNowPlaying", true);
			Class341.class607_0 = Class341.ReadDouble("CursorSize", 1.0, 0.5, 2.0);
			Class341.class606_68 = Class341.smethod_9("AutomaticCursorSizing", false);
			Class341.class608_1 = Class341.smethod_10("DimLevel", 30, 0, 100);
			Class341.class608_13 = Class341.smethod_10("Display", 1, -2147483648, 2147483647);
			Class341.class606_15 = Class341.smethod_9("DisplayCityLocation", false);
			Class341.class606_16 = Class341.smethod_9("DistanceSpacingEnabled", true);
			Class341.class608_4 = Class341.smethod_10("EditorTip", 0, -2147483648, 2147483647);
			Class341.class606_17 = Class341.smethod_9("VideoEditor", Class341.class606_69);
			Class341.class606_18 = Class341.smethod_9("EditorDefaultSkin", false);
			Class341.class606_25 = Class341.smethod_9("FastEditor", false);
			Class341.class606_19 = Class341.smethod_9("EditorSnakingSliders", true);
			Class341.class606_20 = Class341.smethod_9("EditorHitAnimations", false);
			Class341.class606_21 = Class341.smethod_9("EditorFollowPoints", true);
			Class341.class606_22 = Class341.smethod_9("EditorStacking", true);
			Class341.class606_26 = Class341.smethod_9("ForceSliderRendering", false);
			Class341.class606_27 = Class341.smethod_9("FpsCounter", false);
			Class341.class605_0 = Class341.smethod_8<FrameSync>("FrameSync", FrameSync.Limit120, false);
			Class341.class605_1 = Class341.smethod_8<FrameSync>("FrameSyncGl", FrameSync.VSync, false);
			Class341.class605_11 = Class341.ReadString("GuideTips", "");
			Class341.class606_23 = Class341.smethod_9("CursorRipple", false);
			Class341.class605_13 = Class341.ReadString("HighlightWords", string.Empty);
			Class341.class606_28 = Class341.smethod_9("HighResolution", false);
			Class341.class606_29 = Class341.smethod_9("HitLighting", true);
			Class341.class606_30 = Class341.smethod_9("IgnoreBarline", false);
			Class341.class606_31 = Class341.smethod_9("IgnoreBeatmapSamples", false);
			Class341.class606_32 = Class341.smethod_9("IgnoreBeatmapSkins", false);
			Class341.class605_14 = Class341.ReadString("IgnoreList", string.Empty);
			Class341.class606_33 = Class341.smethod_9("Joystick", false);
			Class341.class606_34 = Class341.smethod_9("KeyOverlay", false);
			Class341.class605_3 = Class341.ReadString("Language", "unknown");
			Class68.class605_0 = Class341.smethod_8<PlayModes>("LastPlayMode", PlayModes.Osu, false);
			Class341.class605_15 = Class341.ReadString("LastVersion", string.Empty);
			Class341.class605_16 = Class341.ReadString("LastVersionPermissionsFailed", string.Empty);
			Class341.class606_35 = Class341.smethod_9("LoadSubmittedThread", true);
			Class341.class608_14 = Class341.smethod_10("LobbyPlayMode", -1, -2147483648, 2147483647);
			Class341.class606_75 = Class341.smethod_9("ShowInterface", true);
			Class341.class606_36 = Class341.smethod_9("LobbyShowExistingOnly", false);
			Class341.class606_37 = Class341.smethod_9("LobbyShowFriendsOnly", false);
			Class341.class606_38 = Class341.smethod_9("LobbyShowFull", false);
			Class341.class606_39 = Class341.smethod_9("LobbyShowInProgress", true);
			Class341.class606_40 = Class341.smethod_9("LobbyShowPassworded", true);
			Class341.class606_41 = Class341.smethod_9("LogPrivateMessages", false);
			Class341.class606_42 = Class341.smethod_9("LowResolution", false);
			Class341.class608_7 = Class341.smethod_10("ManiaSpeed", 12, 1, 40);
			Class341.class606_72 = Class341.smethod_9("UsePerBeatmapManiaSpeed", true);
			Class341.class606_73 = Class341.smethod_9("ManiaSpeedBPMScale", true);
			Class341.class608_8 = Class341.smethod_10("MenuTip", 0, -2147483648, 2147483647);
			Class341.class606_43 = Class341.smethod_9("MouseDisableButtons", false);
			Class341.class606_44 = Class341.smethod_9("MouseDisableWheel", false);
			Class341.class607_3 = Class341.ReadDouble("MouseSpeed", 1.0, 0.4, 6.0);
			Class341.class608_9 = Class341.smethod_10("Offset", 0, -300, 300);
			Class341.class607_4 = Class341.ReadDouble("ScoreMeterScale", 1.0, 0.5, 2.0);
			Class341.class607_2 = Class341.ReadDouble("DistanceSpacing", 0.8, 0.5, 32.0);
			Class341.class608_2 = Class341.smethod_10("EditorBeatDivisor", 1, 1, 16);
			Class341.class608_3 = Class341.smethod_10("EditorGridSize", 32, 4, 32);
			Class341.class608_5 = Class341.smethod_10("Height", 9999, Class115.bool_16 ? 0 : 240, 9999);
			Class341.class608_11 = Class341.smethod_10("Width", 9999, Class115.bool_16 ? 0 : 320, 9999);
			Class341.class608_6 = Class341.smethod_10("HeightFullscreen", 9999, 240, 9999);
			Class341.class608_0 = Class341.smethod_10("CustomFrameLimit", 240, Class115.bool_16 ? 30 : 240, 1000);
			if (Class341.class608_0.Value == 60 || Class341.class608_0.Value == 120)
			{
				Class341.class608_0.Value = 240;
			}
			Class341.class608_12 = Class341.smethod_10("WidthFullscreen", 9999, 320, 9999);
			Class341.class606_45 = Class341.smethod_9("MsnIntegration", false);
			Class341.class606_46 = Class341.smethod_9("MyPcSucks", false);
			Class341.class606_47 = Class341.smethod_9("NotifyFriends", true);
			Class341.class606_48 = Class341.smethod_9("NotifySubmittedThread", true);
			Class341.class606_50 = Class341.smethod_9("PopupDuringGameplay", true);
			Class341.class605_2 = Class341.smethod_8<ProgressBarTypes>("ProgressBarType", ProgressBarTypes.Pie, false);
			Class341.class605_5 = Class341.smethod_8<RankingType>("RankType", RankingType.Top, false);
			Class341.class608_10 = Class341.smethod_10("RefreshRate", 60, -2147483648, 2147483647);
			Class341.class605_18 = Class341.ReadString("Renderer", "d3d");
			Class341.class605_6 = Class341.smethod_8<ScaleMode>("ScaleMode", ScaleMode.WidescreenConservative, false);
			Class341.class606_53 = Class341.smethod_9("ScoreboardVisible", true);
			Class341.class605_7 = Class341.smethod_8<ScoreMeterType>("ScoreMeter", ScoreMeterType.Error, false);
			Class341.class605_8 = Class341.smethod_8<ScreenMode>("Fullscreen", ScreenMode.BorderlessWindow, false);
			Class341.class608_15 = Class341.smethod_10("ScreenshotId", 0, -2147483648, 2147483647);
			Class341.class606_76 = Class341.smethod_9("MenuSnow", false);
			Class341.class606_77 = Class341.smethod_9("MenuTriangles", true);
			Class341.class606_78 = Class341.smethod_9("SongSelectThumbnails", true);
			Class341.class605_4 = Class341.smethod_8<ImageFileFormat>("ScreenshotFormat", 1, false);
			Class341.class606_54 = Class341.smethod_9("ShowReplayComments", true);
			Class341.class606_55 = Class341.smethod_9("ShowSpectators", true);
			Class341.class606_56 = Class341.smethod_9("ShowStoryboard", true);
			Class341.class605_19 = Class341.ReadString("Skin", "Default");
			Class341.class606_59 = Class341.smethod_9("SkinSamples", true);
			Class341.class606_60 = Class341.smethod_9("SkipTablet", false);
			Class341.class606_61 = Class341.smethod_9("SnakingSliders", true);
			Class341.class606_62 = Class341.smethod_9("Tablet", false);
			Class341.class606_64 = Class341.smethod_9("UpdatePending", false);
			Class341.class605_21 = Class341.smethod_8<Enum103>("UserFilter", Enum103.const_0, false);
			Class341.class606_65 = Class341.smethod_9("UseSkinCursor", false);
			Class341.class606_66 = Class341.smethod_9("UseTaikoSkin", false);
			Class341.class606_69 = Class341.smethod_9("Video", true);
			Class341.class606_70 = Class341.smethod_9("Wiimote", false);
			Class341.class606_71 = Class341.smethod_9("YahooIntegration", false);
			Class341.class606_84 = Class341.smethod_9("MenuMusic", true);
			Class341.class606_85 = Class341.smethod_9("MenuVoice", true);
			Class341.class606_57 = Class341.smethod_9("MenuParallax", true);
			Class341.class606_79 = Class341.smethod_9("RawInput", false);
			Class341.class606_87 = Class341.smethod_9("AbsoluteToOsuWindow", Class341.class606_79.Value);
			Class341.class606_82 = Class341.smethod_9("ShowMenuTips", true);
			Class341.class606_86 = Class341.smethod_9("HiddenShowFirstApproach", true);
			Class341.class606_8 = Class341.smethod_9("ComboColourSliderBall", true);
			Class341.class606_83 = Class341.smethod_9("AlternativeChatFont", false);
			Class606 arg_A09_0 = Class341.class606_83;
			if (Class341.eventHandler_0 == null)
			{
				Class341.eventHandler_0 = new EventHandler(Class341.smethod_15);
			}
			arg_A09_0.imethod_2(Class341.eventHandler_0);
			Class341.class605_17 = Class341.ReadString("Password", string.Empty);
			Class341.class605_20 = Class341.ReadString("Username", string.Empty);
			Class341.class605_12 = Class341.ReadString("AudioDevice", string.Empty);
			Class605<string> arg_A6C_0 = Class341.class605_12;
			if (Class341.eventHandler_1 == null)
			{
				Class341.eventHandler_1 = new EventHandler(Class341.smethod_16);
			}
			arg_A6C_0.imethod_2(Class341.eventHandler_1);
			Class341.class605_25 = Class341.smethod_8<ReleaseStream>("_ReleaseStream", ReleaseStream.Stable, true);
			Class341.class608_17 = Class341.smethod_10("_UpdateFailCount", 0, -2147483648, 2147483647);
			Class605<ReleaseStream> arg_ABE_0 = Class341.class605_25;
			if (Class341.eventHandler_2 == null)
			{
				Class341.eventHandler_2 = new EventHandler(Class341.smethod_17);
			}
			arg_ABE_0.imethod_2(Class341.eventHandler_2);
			Class606 arg_AE5_0 = Class341.class606_67;
			if (Class341.eventHandler_3 == null)
			{
				Class341.eventHandler_3 = new EventHandler(Class341.smethod_18);
			}
			arg_AE5_0.imethod_2(Class341.eventHandler_3);
			Class606 arg_B0C_0 = Class341.class606_55;
			if (Class341.eventHandler_4 == null)
			{
				Class341.eventHandler_4 = new EventHandler(Class341.smethod_19);
			}
			arg_B0C_0.imethod_2(Class341.eventHandler_4);
			Class607 arg_B33_0 = Class341.class607_0;
			if (Class341.eventHandler_5 == null)
			{
				Class341.eventHandler_5 = new EventHandler(Class341.smethod_20);
			}
			arg_B33_0.imethod_2(Class341.eventHandler_5);
			Class341.class606_51 = Class341.smethod_9("SavePassword", !string.IsNullOrEmpty(Class341.class605_17));
			Class606 arg_B7B_0 = Class341.class606_51;
			if (Class341.eventHandler_6 == null)
			{
				Class341.eventHandler_6 = new EventHandler(Class341.smethod_21);
			}
			arg_B7B_0.imethod_2(Class341.eventHandler_6);
			Class341.class606_52 = Class341.smethod_9("SaveUsername", true);
			Class606 arg_BB2_0 = Class341.class606_52;
			if (Class341.eventHandler_7 == null)
			{
				Class341.eventHandler_7 = new EventHandler(Class341.smethod_22);
			}
			arg_BB2_0.imethod_2(Class341.eventHandler_7);
			Class606 arg_BD9_0 = Class341.class606_73;
			if (Class341.eventHandler_8 == null)
			{
				Class341.eventHandler_8 = new EventHandler(Class341.smethod_23);
			}
			arg_BD9_0.imethod_2(Class341.eventHandler_8);
			Class606 arg_C00_0 = Class341.class606_72;
			if (Class341.eventHandler_9 == null)
			{
				Class341.eventHandler_9 = new EventHandler(Class341.smethod_24);
			}
			arg_C00_0.imethod_2(Class341.eventHandler_9);
			if (!Class341.class606_51)
			{
				Class341.dictionary_0["Password"] = string.Empty;
			}
			if (!Class341.class606_52)
			{
				Class341.dictionary_0["Username"] = string.Empty;
			}
			Class341.class605_23 = Class341.smethod_8<TreeGroupMode>("TreeSortMode", TreeGroupMode.Search, false);
			Class341.class605_24 = Class341.smethod_8<TreeSortMode>("TreeSortMode2", TreeSortMode.Title, false);
			Class605<string> arg_C8A_0 = Class341.class605_13;
			if (Class341.eventHandler_10 == null)
			{
				Class341.eventHandler_10 = new EventHandler(Class341.smethod_25);
			}
			arg_C8A_0.imethod_2(Class341.eventHandler_10);
			Class605<string> arg_CB1_0 = Class341.class605_14;
			if (Class341.eventHandler_11 == null)
			{
				Class341.eventHandler_11 = new EventHandler(Class341.smethod_26);
			}
			arg_CB1_0.imethod_2(Class341.eventHandler_11);
			Class802.smethod_29();
			Class605<string> arg_CDE_0 = Class341.class605_3;
			if (Class341.eventHandler_12 == null)
			{
				Class341.eventHandler_12 = new EventHandler(Class341.smethod_27);
			}
			arg_CDE_0.imethod_2(Class341.eventHandler_12);
			Class341.class606_81 = new Class606(false);
			Class341.class606_80 = new Class606(false);
			Class605<string> arg_D1B_0 = Class341.class605_18;
			if (Class341.eventHandler_13 == null)
			{
				Class341.eventHandler_13 = new EventHandler(Class341.smethod_28);
			}
			arg_D1B_0.imethod_2(Class341.eventHandler_13);
			Class606 arg_D42_0 = Class341.class606_81;
			if (Class341.eventHandler_14 == null)
			{
				Class341.eventHandler_14 = new EventHandler(Class341.smethod_29);
			}
			arg_D42_0.imethod_2(Class341.eventHandler_14);
			Class606 arg_D69_0 = Class341.class606_80;
			if (Class341.eventHandler_15 == null)
			{
				Class341.eventHandler_15 = new EventHandler(Class341.smethod_30);
			}
			arg_D69_0.imethod_2(Class341.eventHandler_15);
			Class341.class605_18.method_0();
			Class605<string> arg_D9A_0 = Class341.class605_18;
			if (Class341.eventHandler_16 == null)
			{
				Class341.eventHandler_16 = new EventHandler(Class341.smethod_31);
			}
			arg_D9A_0.imethod_2(Class341.eventHandler_16);
			Class606 arg_DC1_0 = Class341.class606_79;
			if (Class341.eventHandler_17 == null)
			{
				Class341.eventHandler_17 = new EventHandler(Class341.smethod_32);
			}
			arg_DC1_0.imethod_2(Class341.eventHandler_17);
			Class606 arg_DE8_0 = Class341.class606_62;
			if (Class341.eventHandler_18 == null)
			{
				Class341.eventHandler_18 = new EventHandler(Class341.smethod_33);
			}
			arg_DE8_0.imethod_2(Class341.eventHandler_18);
			Class607 arg_E0F_0 = Class341.class607_3;
			if (Class341.eventHandler_19 == null)
			{
				Class341.eventHandler_19 = new EventHandler(Class341.smethod_34);
			}
			arg_E0F_0.imethod_2(Class341.eventHandler_19);
			Class606 arg_E36_0 = Class341.class606_27;
			if (Class341.eventHandler_20 == null)
			{
				Class341.eventHandler_20 = new EventHandler(Class341.smethod_35);
			}
			arg_E36_0.imethod_2(Class341.eventHandler_20);
			Class341.class606_74 = new Class606(false);
			Class605<ScreenMode> arg_E68_0 = Class341.class605_8;
			if (Class341.eventHandler_21 == null)
			{
				Class341.eventHandler_21 = new EventHandler(Class341.smethod_36);
			}
			arg_E68_0.imethod_2(Class341.eventHandler_21);
			Class341.class605_8.method_0();
			Class606 arg_E99_0 = Class341.class606_74;
			if (Class341.eventHandler_22 == null)
			{
				Class341.eventHandler_22 = new EventHandler(Class341.smethod_37);
			}
			arg_E99_0.imethod_2(Class341.eventHandler_22);
			Class605<FrameSync> arg_EC0_0 = Class341.class605_0;
			if (Class341.eventHandler_23 == null)
			{
				Class341.eventHandler_23 = new EventHandler(Class341.smethod_38);
			}
			arg_EC0_0.imethod_2(Class341.eventHandler_23);
			Class341.class605_26 = new Class605<FrameSync>(Class341.class606_80 ? Class341.class605_1 : Class341.class605_0);
			Class605<FrameSync> arg_F0E_0 = Class341.class605_26;
			if (Class341.eventHandler_24 == null)
			{
				Class341.eventHandler_24 = new EventHandler(Class341.smethod_39);
			}
			arg_F0E_0.imethod_2(Class341.eventHandler_24);
			Class606 arg_F35_0 = Class341.class606_4;
			if (Class341.eventHandler_25 == null)
			{
				Class341.eventHandler_25 = new EventHandler(Class341.smethod_40);
			}
			arg_F35_0.imethod_2(Class341.eventHandler_25);
			Class606 arg_F5C_0 = Class341.class606_5;
			if (Class341.eventHandler_26 == null)
			{
				Class341.eventHandler_26 = new EventHandler(Class341.smethod_41);
			}
			arg_F5C_0.imethod_2(Class341.eventHandler_26);
			bool bool_ = false;
			string a;
			if ((a = Class341.class605_3) != null && (a == "zh" || a == "ja" || a == "ko"))
			{
				bool_ = true;
			}
			Class341.class606_58 = Class341.smethod_9("ShowUnicode", bool_);
			Class341.class606_49 = Class341.smethod_9("PermanentSongInfo", false);
			Class341.class606_63 = Class341.smethod_9("Ticker", false);
			Class606 arg_FEC_0 = Class341.class606_63;
			if (Class341.eventHandler_27 == null)
			{
				Class341.eventHandler_27 = new EventHandler(Class341.smethod_42);
			}
			arg_FEC_0.imethod_2(Class341.eventHandler_27);
			Class606 arg_1013_0 = Class341.class606_2;
			if (Class341.eventHandler_28 == null)
			{
				Class341.eventHandler_28 = new EventHandler(Class341.smethod_43);
			}
			arg_1013_0.imethod_2(Class341.eventHandler_28);
			if (Class341.class606_46)
			{
				Class341.class606_13 = false;
				Class341.class606_4 = false;
				Class341.class606_5 = false;
				Class341.class606_29 = false;
				Class341.class606_12 = false;
				Class341.class606_61 = false;
			}
			if (Class341.class605_18 == "opengl" && Class341.class605_8 == ScreenMode.Fullscreen)
			{
				Class341.class605_8.Value = ScreenMode.BorderlessWindow;
			}
			if (Class115.bool_16)
			{
				if (Class115.bool_17)
				{
					Class341.class606_63.Value = true;
					Class341.class608_11.Value = (int)Tournament.vector2_1.X;
					Class341.class608_5.Value = (int)Tournament.vector2_1.Y;
				}
				else
				{
					Class341.class606_63.Value = false;
					Class341.class608_11.Value = (int)Tournament.smethod_1().X;
					Class341.class608_5.Value = (int)Tournament.smethod_1().Y;
				}
				Class341.class606_27.Value = false;
				Class341.class605_19.Value = "User";
				Class341.class606_12.Value = false;
				Class341.class606_13.Value = false;
				Class341.class606_56.Value = false;
				Class341.class605_8.Value = ScreenMode.Windowed;
				Class341.class605_18.Value = "d3d";
				Class341.class605_26.Value = FrameSync.Limit240;
				Class341.class606_47.Value = false;
				Class341.class606_7.Value = false;
				Class341.class606_50.Value = false;
				Class341.class606_3.Value = false;
				Class341.class605_7 = Class341.smethod_8<ScoreMeterType>("ScoreMeter", ScoreMeterType.Colour, false);
				Class341.class607_4 = Class341.ReadDouble("ScoreMeterScale", 1.0, 0.5, 1.7976931348623157E+308);
				Class341.class608_0.Value = Tournament.class43_0.GetValue<int>("fps", 60);
				Class341.class606_32.Value = true;
				Class341.class606_85.Value = false;
				Class331.class608_2.Value = 50;
			}
			Class795.Initialize(false);
			Class111.smethod_69();
		}

		// Token: 0x0600197F RID: 6527
		// RVA: 0x0007AC34 File Offset: 0x00078E34
		private static Class607 ReadDouble(string string_1, double double_0, double double_1, double double_2)
		{
			Class607 class = new Class607(Class341.smethod_12(string_1, double_0))
			{
				double_2 = double_1,
				double_3 = double_2,
				double_1 = double_0
			};
			Class341.dictionary_0[string_1] = class;
			return class;
		}

		// Token: 0x0600197B RID: 6523
		// RVA: 0x00015A87 File Offset: 0x00013C87
		private static Class605<string> ReadString(string string_1, string string_2)
		{
			return Class341.smethod_8<string>(string_1, string_2, false);
		}

		// Token: 0x06001970 RID: 6512
		// RVA: 0x00079378 File Offset: 0x00077578
		internal static bool smethod_0()
		{
			switch (Class341.class605_26.Value)
			{
			case FrameSync.VSync:
			case FrameSync.LowLatencyVSync:
				return true;
			case FrameSync.Unlimited:
				return false;
			}
			return false;
		}

		// Token: 0x06001971 RID: 6513
		// RVA: 0x00015A5B File Offset: 0x00013C5B
		internal static string smethod_1()
		{
			return "osu!." + Class34.smethod_2(Environment.UserName) + ".cfg";
		}

		// Token: 0x0600197D RID: 6525
		// RVA: 0x0007ABB4 File Offset: 0x00078DB4
		private static Class608 smethod_10(string string_1, int int_0, int int_1, int int_2)
		{
			Class608 class = new Class608(Class341.smethod_11(string_1, int_0))
			{
				double_2 = (double)int_1,
				double_3 = (double)int_2,
				double_1 = (double)int_0
			};
			Class341.dictionary_0[string_1] = class;
			return class;
		}

		// Token: 0x0600197E RID: 6526
		// RVA: 0x0007ABF8 File Offset: 0x00078DF8
		private static int smethod_11(string string_1, int int_0)
		{
			int result = int_0;
			object obj;
			if (Class341.dictionary_0.TryGetValue(string_1, out obj) && !int.TryParse(obj.ToString(), NumberStyles.Any, Class115.numberFormatInfo_0, out result))
			{
				result = int_0;
			}
			return result;
		}

		// Token: 0x06001980 RID: 6528
		// RVA: 0x0007AC74 File Offset: 0x00078E74
		private static double smethod_12(string string_1, double double_0)
		{
			double result = double_0;
			object obj;
			if (Class341.dictionary_0.TryGetValue(string_1, out obj) && !double.TryParse(obj.ToString(), NumberStyles.Any, Class115.numberFormatInfo_0, out result))
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x06001981 RID: 6529
		// RVA: 0x00015A91 File Offset: 0x00013C91
		internal static void smethod_13()
		{
			Class341.smethod_2("osu!.cfg");
		}

		// Token: 0x06001982 RID: 6530
		// RVA: 0x0007ACB0 File Offset: 0x00078EB0
		internal static void smethod_14()
		{
			foreach (string current in new List<string>(Class341.dictionary_0.Keys))
			{
				if (current[1] == '_')
				{
					Class341.dictionary_0.Remove(current);
				}
			}
			Class341.smethod_3();
		}

		// Token: 0x06001983 RID: 6531
		// RVA: 0x00015A9D File Offset: 0x00013C9D
		[CompilerGenerated]
		private static void smethod_15(object sender, EventArgs e)
		{
			Class111.smethod_3();
		}

		// Token: 0x06001984 RID: 6532
		// RVA: 0x00015AA4 File Offset: 0x00013CA4
		[CompilerGenerated]
		private static void smethod_16(object sender, EventArgs e)
		{
			if (!Class331.smethod_104(Class341.class605_12.Value))
			{
				Class341.class605_12.Value = Class331.string_2;
			}
		}

		// Token: 0x06001985 RID: 6533
		// RVA: 0x00015AC6 File Offset: 0x00013CC6
		[CompilerGenerated]
		private static void smethod_17(object sender, EventArgs e)
		{
			Class214.Reset(true);
			Class115.enum32_0 = Enum32.const_0;
			if (Class115.int_1 > 0)
			{
				Class115.smethod_0(false, true);
			}
		}

		// Token: 0x06001986 RID: 6534
		// RVA: 0x00015AE3 File Offset: 0x00013CE3
		[CompilerGenerated]
		private static void smethod_18(object sender, EventArgs e)
		{
			if (Class341.class606_67.Value)
			{
				Class341.class606_55.Value = true;
			}
		}

		// Token: 0x06001987 RID: 6535
		// RVA: 0x00015AFC File Offset: 0x00013CFC
		[CompilerGenerated]
		private static void smethod_19(object sender, EventArgs e)
		{
			if (!Class341.class606_55.Value)
			{
				Class341.class606_67.Value = false;
			}
		}

		// Token: 0x06001974 RID: 6516
		// RVA: 0x0007A5D8 File Offset: 0x000787D8
		private static void smethod_2(string string_1)
		{
			if (!File.Exists(string_1))
			{
				return;
			}
			using (StreamReader streamReader = File.OpenText(string_1))
			{
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					if (text.Length != 0 && text[0] != '#')
					{
						string[] array = text.Split(new char[]
						{
							'='
						});
						if (array.Length >= 2)
						{
							Class341.dictionary_0[array[0].Trim()] = array[1].Trim();
						}
					}
				}
			}
		}

		// Token: 0x06001988 RID: 6536
		// RVA: 0x00015B15 File Offset: 0x00013D15
		[CompilerGenerated]
		private static void smethod_20(object sender, EventArgs e)
		{
			Class802.smethod_24();
		}

		// Token: 0x06001989 RID: 6537
		// RVA: 0x00015B1C File Offset: 0x00013D1C
		[CompilerGenerated]
		private static void smethod_21(object sender, EventArgs e)
		{
			if (Class341.class606_51)
			{
				Class341.dictionary_0["Password"] = Class341.class605_17;
				return;
			}
			Class341.dictionary_0["Password"] = string.Empty;
		}

		// Token: 0x0600198A RID: 6538
		// RVA: 0x00015B53 File Offset: 0x00013D53
		[CompilerGenerated]
		private static void smethod_22(object sender, EventArgs e)
		{
			if (Class341.class606_52)
			{
				Class341.dictionary_0["Username"] = Class341.class605_20;
				return;
			}
			Class341.dictionary_0["Username"] = string.Empty;
		}

		// Token: 0x0600198B RID: 6539
		// RVA: 0x00015B8A File Offset: 0x00013D8A
		[CompilerGenerated]
		private static void smethod_23(object sender, EventArgs e)
		{
			if (Class341.class606_72.Value)
			{
				List<Class296> arg_2E_0 = Class466.list_3;
				if (Class341.action_0 == null)
				{
					Class341.action_0 = new Action<Class296>(Class341.smethod_44);
				}
				arg_2E_0.ForEach(Class341.action_0);
			}
		}

		// Token: 0x0600198C RID: 6540
		// RVA: 0x00015BBF File Offset: 0x00013DBF
		[CompilerGenerated]
		private static void smethod_24(object sender, EventArgs e)
		{
			if (!Class341.class606_72.Value)
			{
				List<Class296> arg_2E_0 = Class466.list_3;
				if (Class341.action_1 == null)
				{
					Class341.action_1 = new Action<Class296>(Class341.smethod_45);
				}
				arg_2E_0.ForEach(Class341.action_1);
			}
		}

		// Token: 0x0600198D RID: 6541
		// RVA: 0x00015BF4 File Offset: 0x00013DF4
		[CompilerGenerated]
		private static void smethod_25(object sender, EventArgs e)
		{
			Class111.smethod_67();
		}

		// Token: 0x0600198E RID: 6542
		// RVA: 0x00015BFB File Offset: 0x00013DFB
		[CompilerGenerated]
		private static void smethod_26(object sender, EventArgs e)
		{
			Class111.smethod_68();
		}

		// Token: 0x0600198F RID: 6543
		// RVA: 0x0007AD24 File Offset: 0x00078F24
		[CompilerGenerated]
		private static void smethod_27(object sender, EventArgs e)
		{
			Class341.Class342 class = new Class341.Class342();
			class.bool_0 = (Class115.class80_0 != null && Class115.class80_0.method_7());
			if (Class115.class80_0 != null)
			{
				Class115.class80_0.method_8(false);
			}
			Class115.smethod_11(new VoidDelegate(class.method_0));
			if (Class115.int_1 > 0)
			{
				string arg_8B_0 = Class341.class605_3.Value;
				bool arg_8B_1 = Class341.class605_15 != Class344.smethod_0();
				if (Class341.voidDelegate_0 == null)
				{
					Class341.voidDelegate_0 = new VoidDelegate(Class341.smethod_46);
				}
				Class41.smethod_0(arg_8B_0, arg_8B_1, Class341.voidDelegate_0, Resources.en);
			}
		}

		// Token: 0x06001990 RID: 6544
		// RVA: 0x0007ADC4 File Offset: 0x00078FC4
		[CompilerGenerated]
		private static void smethod_28(object sender, EventArgs e)
		{
			Class341.class606_81.Value = !(Class341.class606_80.Value = (Class341.class605_18 == "opengl"));
		}

		// Token: 0x06001991 RID: 6545
		// RVA: 0x0007AE00 File Offset: 0x00079000
		[CompilerGenerated]
		private static void smethod_29(object sender, EventArgs e)
		{
			if (!Class341.class606_81 && !Class341.class606_80)
			{
				Class341.class606_81.Value = true;
				return;
			}
			Class341.class605_18.Value = (Class341.class606_81 ? "d3d" : "opengl");
		}

		// Token: 0x06001975 RID: 6517
		// RVA: 0x0007A66C File Offset: 0x0007886C
		internal static void smethod_3()
		{
			Class795.smethod_9();
			if (Class111.class594_0 != null)
			{
				string text = string.Empty;
				foreach (Class750 current in Class111.class594_0.list_1)
				{
					Class21 class = current.object_0 as Class21;
					if (class != null)
					{
						text = text + class.string_0 + " ";
					}
				}
				string[] array = Class341.class605_9.Value.Split(new char[]
				{
					' '
				});
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					if (!text.Contains(text2))
					{
						text = text + text2 + " ";
					}
				}
				Class341.dictionary_0["ChatChannels"] = text.Trim();
			}
			if (Class115.bool_16)
			{
				return;
			}
			Class341.smethod_5("osu!." + Class34.smethod_2(Environment.UserName) + ".cfg", false);
			Class341.smethod_5("osu!.cfg", true);
		}

		// Token: 0x06001992 RID: 6546
		// RVA: 0x0007AE54 File Offset: 0x00079054
		[CompilerGenerated]
		private static void smethod_30(object sender, EventArgs e)
		{
			if (!Class341.class606_81 && !Class341.class606_80)
			{
				Class341.class606_80.Value = true;
				return;
			}
			Class341.class605_18.Value = ((!Class341.class606_80) ? "d3d" : "opengl");
		}

		// Token: 0x06001993 RID: 6547
		// RVA: 0x00015C02 File Offset: 0x00013E02
		[CompilerGenerated]
		private static void smethod_31(object sender, EventArgs e)
		{
			if (Class115.int_1 > 0)
			{
				Class115.smethod_85(null);
			}
		}

		// Token: 0x06001994 RID: 6548
		// RVA: 0x0007AEA8 File Offset: 0x000790A8
		[CompilerGenerated]
		private static void smethod_32(object sender, EventArgs e)
		{
			if (!Class341.class606_79)
			{
				if (Class115.smethod_94())
				{
					Class341.class607_3.Value = 1.0;
				}
				return;
			}
			if ((Class567)Class802.smethod_22(typeof(Class567)) == null)
			{
				Class567 class = new Class567();
				class.imethod_0(Class800.smethod_19());
				if (!Class802.smethod_23(class))
				{
					Class723.smethod_1(Class41.GetString(OsuString.Options_Input_RawInputFailed), 5000);
					Class341.class606_79.Value = false;
				}
			}
		}

		// Token: 0x06001995 RID: 6549
		// RVA: 0x0007AF2C File Offset: 0x0007912C
		[CompilerGenerated]
		private static void smethod_33(object sender, EventArgs e)
		{
			Class571 class = Class802.smethod_22(typeof(Class571)) as Class571;
			if (Class341.class606_62.Value && class == null)
			{
				class = new Class571();
				if (!Class802.smethod_23(class))
				{
					Class341.class606_62.Value = false;
					class = null;
				}
			}
			if (class != null)
			{
				class.method_0(Class341.class606_62.Value);
			}
		}

		// Token: 0x06001996 RID: 6550
		// RVA: 0x00015C12 File Offset: 0x00013E12
		[CompilerGenerated]
		private static void smethod_34(object sender, EventArgs e)
		{
			Class802.smethod_29();
		}

		// Token: 0x06001997 RID: 6551
		// RVA: 0x0007AF8C File Offset: 0x0007918C
		[CompilerGenerated]
		private static void smethod_35(object sender, EventArgs e)
		{
			if (Class115.class911_3 != null && Class115.class533_1 != null)
			{
				if (Class341.class606_27)
				{
					Class115.class911_3.Add(Class115.class533_1);
					Class115.class533_1.Text = "...";
					Class115.double_12 = 0.0;
					Class115.double_14 = 0.0;
					return;
				}
				Class115.class911_3.Remove(Class115.class533_1);
			}
		}

		// Token: 0x06001998 RID: 6552
		// RVA: 0x00015C1A File Offset: 0x00013E1A
		[CompilerGenerated]
		private static void smethod_36(object sender, EventArgs e)
		{
			Class341.class606_74.Value = (Class341.class605_8.Value == ScreenMode.Fullscreen);
		}

		// Token: 0x06001999 RID: 6553
		// RVA: 0x0007B000 File Offset: 0x00079200
		[CompilerGenerated]
		private static void smethod_37(object sender, EventArgs e)
		{
			if (Class115.int_1 > 0)
			{
				Class115.smethod_20(null, null, new ScreenMode?((Class115.screenMode_0 == ScreenMode.Fullscreen) ? ScreenMode.Windowed : ScreenMode.Fullscreen), true, false);
			}
		}

		// Token: 0x0600199A RID: 6554
		// RVA: 0x00015C33 File Offset: 0x00013E33
		[CompilerGenerated]
		private static void smethod_38(object sender, EventArgs e)
		{
			if (Class115.class125_0 != null && Class115.class125_0.method_14() != Class341.smethod_0())
			{
				Class115.class125_0.method_15(Class341.smethod_0());
				Class115.class125_0.method_19();
			}
		}

		// Token: 0x0600199B RID: 6555
		// RVA: 0x0007B040 File Offset: 0x00079240
		[CompilerGenerated]
		private static void smethod_39(object sender, EventArgs e)
		{
			if (Class341.class606_80)
			{
				if ((Class341.class605_26.Value == FrameSync.LowLatencyVSync || Class341.class605_26.Value == FrameSync.VSync) != (Class341.class605_1.Value == FrameSync.LowLatencyVSync || Class341.class605_1.Value == FrameSync.VSync))
				{
					Class341.Class343 class = new Class341.Class343();
					class.frameSync_0 = Class341.class605_26.Value;
					Class341.class605_26.Value = Class341.class605_1.Value;
					if (Class115.osuModes_1 == OsuModes.Menu && Class115.int_1 > 0)
					{
						Class115.smethod_85(new VoidDelegate(class.method_0));
						return;
					}
					Class723.smethod_4(Class41.GetString(OsuString.Options_Graphics_RestartRequired));
					return;
				}
				else
				{
					if (Class341.class605_1.Value == Class341.class605_26.Value)
					{
						return;
					}
					Class341.class605_1.Value = Class341.class605_26.Value;
				}
			}
			else
			{
				if (Class341.class605_0.Value == Class341.class605_26.Value)
				{
					return;
				}
				Class341.class605_0.Value = Class341.class605_26.Value;
			}
			if (Class115.int_1 > 0)
			{
				Class115.bool_14 = true;
				string arg = string.Empty;
				switch (Class341.class605_26.Value)
				{
				case FrameSync.Limit120:
					arg = Class41.GetString(OsuString.Options_Graphics_FrameLimiter_120);
					break;
				case FrameSync.VSync:
					arg = Class41.GetString(OsuString.Options_Graphics_FrameLimiter_60);
					break;
				case FrameSync.Unlimited:
					arg = Class41.GetString(OsuString.Options_Graphics_FrameLimiter_UnlimGreen);
					break;
				case FrameSync.LowLatencyVSync:
					arg = Class41.GetString(OsuString.Options_Graphics_FrameLimiter_LowLatency);
					break;
				case FrameSync.CompletelyUnlimited:
					arg = Class41.GetString(OsuString.Options_Graphics_FrameLimiter_Unlim);
					break;
				case FrameSync.Limit240:
					arg = Class341.class608_0 + "fps";
					break;
				}
				Class723.smethod_1(Class41.GetString(OsuString.Options_Graphics_FrameLimiter) + ' ' + arg, 1000);
			}
		}

		// Token: 0x06001976 RID: 6518
		// RVA: 0x0007A790 File Offset: 0x00078990
		internal static void smethod_4()
		{
			List<string> list = new List<string>();
			foreach (string current in Class341.dictionary_0.Keys)
			{
				if (current.StartsWith("h_"))
				{
					list.Add(current);
				}
			}
			foreach (string current2 in list)
			{
				Class341.dictionary_0.Remove(current2);
			}
			Class341.smethod_3();
		}

		// Token: 0x0600199C RID: 6556
		// RVA: 0x00015C66 File Offset: 0x00013E66
		[CompilerGenerated]
		private static void smethod_40(object sender, EventArgs e)
		{
			if (Class341.class606_4 && !Class733.Initialize())
			{
				Class341.class606_4.Value = false;
			}
			if (!Class341.class606_4)
			{
				Class341.class606_5.Value = false;
			}
		}

		// Token: 0x0600199D RID: 6557
		// RVA: 0x00015C9D File Offset: 0x00013E9D
		[CompilerGenerated]
		private static void smethod_41(object sender, EventArgs e)
		{
			if (Class341.class606_5)
			{
				if (!Class341.class606_4)
				{
					Class341.class606_4.Value = true;
				}
				if (!Class341.class606_4)
				{
					Class341.class606_5.Value = false;
				}
			}
		}

		// Token: 0x0600199E RID: 6558
		// RVA: 0x00015CD9 File Offset: 0x00013ED9
		[CompilerGenerated]
		private static void smethod_42(object sender, EventArgs e)
		{
			Class111.smethod_15();
		}

		// Token: 0x0600199F RID: 6559
		// RVA: 0x00015CD9 File Offset: 0x00013ED9
		[CompilerGenerated]
		private static void smethod_43(object sender, EventArgs e)
		{
			Class111.smethod_15();
		}

		// Token: 0x060019A0 RID: 6560
		// RVA: 0x00015CE0 File Offset: 0x00013EE0
		[CompilerGenerated]
		private static void smethod_44(Class296 class296_0)
		{
			class296_0.int_18 = 0;
		}

		// Token: 0x060019A1 RID: 6561
		// RVA: 0x00015CE0 File Offset: 0x00013EE0
		[CompilerGenerated]
		private static void smethod_45(Class296 class296_0)
		{
			class296_0.int_18 = 0;
		}

		// Token: 0x060019A2 RID: 6562
		// RVA: 0x00015CE9 File Offset: 0x00013EE9
		[CompilerGenerated]
		private static void smethod_46()
		{
			Class47 arg_23_0 = Class115.class47_0;
			if (Class341.voidDelegate_1 == null)
			{
				Class341.voidDelegate_1 = new VoidDelegate(Class341.smethod_47);
			}
			arg_23_0.Add(Class341.voidDelegate_1, false);
		}

		// Token: 0x060019A3 RID: 6563
		// RVA: 0x00015D13 File Offset: 0x00013F13
		[CompilerGenerated]
		private static void smethod_47()
		{
			Class115.smethod_70(OsuModes.Menu, true);
			Class341.class605_3.Value = Class41.string_0;
		}

		// Token: 0x06001977 RID: 6519
		// RVA: 0x0007A844 File Offset: 0x00078A44
		private static bool smethod_5(string string_1, bool bool_0)
		{
			bool result;
			try
			{
				using (Stream stream = new Stream17(string_1))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						if (!bool_0)
						{
							string arg = string.IsNullOrEmpty(Class341.class605_20.Value) ? Environment.UserName : Class341.class605_20.Value;
							streamWriter.WriteLine("# " + Class41.GetString(OsuString.ConfigManager_OsuConfigurationFor0), arg);
							streamWriter.WriteLine("# " + Class41.GetString(OsuString.ConfigManager_LastUpdatedOn0), DateTime.Now.ToLongDateString());
							streamWriter.WriteLine();
							streamWriter.WriteLine("# " + Class41.GetString(OsuString.ConfigManager_DoNotShare));
							streamWriter.WriteLine("# " + Class41.GetString(OsuString.ConfigManager_DoNotShare2));
							streamWriter.WriteLine();
						}
						foreach (KeyValuePair<string, object> current in Class341.dictionary_0)
						{
							if (bool_0 == current.Key.Contains("_"))
							{
								streamWriter.WriteLine("{0} = {1}", current.Key, current.Value);
							}
						}
					}
				}
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001978 RID: 6520
		// RVA: 0x0007A9F0 File Offset: 0x00078BF0
		internal static bool smethod_6(Enum40 enum40_0)
		{
			return Class341.class605_11.Value.Length > (int)enum40_0 && Class341.class605_11.Value[(int)enum40_0] == '1';
		}

		// Token: 0x06001979 RID: 6521
		// RVA: 0x0007AA28 File Offset: 0x00078C28
		internal static void smethod_7(Enum40 enum40_0, bool bool_0)
		{
			while (Class341.class605_11.Value.Length <= (int)enum40_0)
			{
				Class605<string> expr_09 = Class341.class605_11;
				expr_09.Value += "0";
			}
			Class341.class605_11.Value = Class341.class605_11.Value.Remove((int)enum40_0, 1).Insert((int)enum40_0, bool_0 ? "1" : "0");
		}

		// Token: 0x0600197A RID: 6522
		// RVA: 0x0007AA98 File Offset: 0x00078C98
		private static Class605<T> smethod_8<T>(string string_1, T gparam_0, bool bool_0) where T : IComparable
		{
			T gparam_ = gparam_0;
			int num = 0;
			object obj;
			if (Class341.dictionary_0.TryGetValue(string_1, out obj))
			{
				if (typeof(T).IsEnum)
				{
					if (int.TryParse(obj.ToString(), NumberStyles.Any, Class115.numberFormatInfo_0, out num))
					{
						if (!bool_0)
						{
							gparam_ = (T)((object)num);
							goto IL_76;
						}
						goto IL_76;
					}
					else
					{
						try
						{
							gparam_ = (T)((object)Enum.Parse(typeof(T), obj.ToString(), true));
							goto IL_76;
						}
						catch
						{
							goto IL_76;
						}
					}
				}
				gparam_ = (T)((object)obj);
			}
			IL_76:
			Class605<T> class = new Class605<T>(gparam_)
			{
				Description = string_1,
				gparam_1 = gparam_0
			};
			Class341.dictionary_0[string_1] = class;
			return class;
		}

		// Token: 0x0600197C RID: 6524
		// RVA: 0x0007AB54 File Offset: 0x00078D54
		private static Class606 smethod_9(string string_1, bool bool_0)
		{
			int num = 0;
			bool bool_ = bool_0;
			object obj;
			if (Class341.dictionary_0.TryGetValue(string_1, out obj) && int.TryParse(obj.ToString(), NumberStyles.Any, Class115.numberFormatInfo_0, out num))
			{
				bool_ = (num == 1);
			}
			Class606 class = new Class606(bool_)
			{
				bool_1 = bool_0
			};
			Class341.dictionary_0[string_1] = class;
			return class;
		}
	}
}
