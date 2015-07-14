using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns16;
using ns17;
using ns19;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns5;
using ns7;
using ns77;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using osu.Graphics.Sprites;
using osu.Helpers;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace osu.GameModes.Other
{
	// Token: 0x020003B2 RID: 946
	internal sealed class Tournament : Class61
	{
		// Token: 0x020003B4 RID: 948
		[CompilerGenerated]
		private sealed class Class406
		{
			// Token: 0x04001770 RID: 6000
			public Class537 class537_0;

			// Token: 0x04001771 RID: 6001
			public Tournament tournament_0;

			// Token: 0x06001D80 RID: 7552
			// RVA: 0x00018441 File Offset: 0x00016641
			public void method_0()
			{
				this.class537_0.method_46(false, true);
			}
		}

		// Token: 0x020003B5 RID: 949
		[CompilerGenerated]
		private sealed class Class407
		{
			// Token: 0x04001772 RID: 6002
			public Class838 class838_0;

			// Token: 0x04001773 RID: 6003
			public Tournament tournament_0;

			// Token: 0x06001D82 RID: 7554
			// RVA: 0x00018450 File Offset: 0x00016650
			public void method_0(object sender, EventArgs e)
			{
				this.tournament_0.method_8(this.class838_0);
			}
		}

		// Token: 0x020003B6 RID: 950
		[CompilerGenerated]
		private sealed class Class408
		{
			// Token: 0x04001774 RID: 6004
			public int int_0;

			// Token: 0x06001D84 RID: 7556
			// RVA: 0x00018463 File Offset: 0x00016663
			public void method_0(InterProcessOsu.ClientData clientData_0)
			{
				this.int_0 = Math.Min(clientData_0.AudioTime, this.int_0);
			}
		}

		// Token: 0x020003B3 RID: 947
		private enum TourneyState
		{
			// Token: 0x0400176B RID: 5995
			Initialising,
			// Token: 0x0400176C RID: 5996
			Idle,
			// Token: 0x0400176D RID: 5997
			WaitingForClients,
			// Token: 0x0400176E RID: 5998
			Playing,
			// Token: 0x0400176F RID: 5999
			Ranking
		}

		// Token: 0x04001765 RID: 5989
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04001766 RID: 5990
		[CompilerGenerated]
		private static Action<InterProcessOsu> action_1;

		// Token: 0x04001767 RID: 5991
		[CompilerGenerated]
		private static Action<InterProcessOsu> action_2;

		// Token: 0x04001751 RID: 5969
		private bool bool_2;

		// Token: 0x04001761 RID: 5985
		private static bool bool_3;

		// Token: 0x04001755 RID: 5973
		internal static Class43 class43_0 = new Class43("tournament.cfg", false);

		// Token: 0x0400174E RID: 5966
		private Class531 class531_0;

		// Token: 0x0400174F RID: 5967
		private Class531 class531_1;

		// Token: 0x04001746 RID: 5958
		private Class533 class533_0;

		// Token: 0x04001747 RID: 5959
		private Class533 class533_1;

		// Token: 0x04001748 RID: 5960
		private Class533 class533_2;

		// Token: 0x04001749 RID: 5961
		private Class533 class533_3;

		// Token: 0x0400174A RID: 5962
		private Class533 class533_4;

		// Token: 0x0400174B RID: 5963
		private Class533 class533_5;

		// Token: 0x0400174C RID: 5964
		private Class533 class533_6;

		// Token: 0x0400174D RID: 5965
		private Class533 class533_7;

		// Token: 0x0400175A RID: 5978
		private Class838 class838_0;

		// Token: 0x04001759 RID: 5977
		private Class911 class911_1;

		// Token: 0x04001745 RID: 5957
		private static Color color_0 = new Color(255, 255, 255);

		// Token: 0x0400175C RID: 5980
		private static double double_0;

		// Token: 0x04001762 RID: 5986
		private static double double_1;

		// Token: 0x04001763 RID: 5987
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x04001764 RID: 5988
		[CompilerGenerated]
		private static EventHandler eventHandler_5;

		// Token: 0x04001752 RID: 5970
		private static int int_2;

		// Token: 0x04001753 RID: 5971
		private static int int_3;

		// Token: 0x04001756 RID: 5974
		private static int int_4 = Tournament.class43_0.GetValue<int>("TeamSize", 4);

		// Token: 0x04001757 RID: 5975
		private static int int_5 = Tournament.int_4 * 2;

		// Token: 0x0400175E RID: 5982
		private static readonly int int_6 = Tournament.class43_0.GetValue<int>("BufferTotalTime", 3000);

		// Token: 0x0400175F RID: 5983
		private static readonly int int_7 = Tournament.class43_0.GetValue<int>("BufferDangerTime", 1000);

		// Token: 0x04001760 RID: 5984
		private static readonly int int_8 = Tournament.class43_0.GetValue<int>("BufferTimeoutTime", 20000);

		// Token: 0x04001750 RID: 5968
		private List<Class531> list_0;

		// Token: 0x04001758 RID: 5976
		private static List<InterProcessOsu> list_1 = new List<InterProcessOsu>();

		// Token: 0x0400175D RID: 5981
		private List<Class531> list_2;

		// Token: 0x04001768 RID: 5992
		[CompilerGenerated]
		private static Predicate<InterProcessOsu> predicate_0;

		// Token: 0x04001769 RID: 5993
		[CompilerGenerated]
		private static Predicate<InterProcessOsu> predicate_1;

		// Token: 0x04001754 RID: 5972
		private static string string_0;

		// Token: 0x04001744 RID: 5956
		private static Tournament tournament_0;

		// Token: 0x0400175B RID: 5979
		private static Tournament.TourneyState tourneyState_0;

		// Token: 0x04001742 RID: 5954
		internal static Vector2 vector2_0 = new Vector2(1280f, 720f);

		// Token: 0x04001743 RID: 5955
		internal static Vector2 vector2_1 = Tournament.vector2_0 + new Vector2(0f, 200f);

		// Token: 0x06001D5E RID: 7518
		// RVA: 0x0009F0E0 File Offset: 0x0009D2E0
		public Tournament(Class115 class115_0)
		{
			Class533 class = new Class533(string.Empty, 12f, new Vector2(0f, 350f), 1f, true, Color.get_White());
			class.origins_0 = Origins.BottomLeft;
			class.method_58(true);
			class.method_57(new Color(85, 85, 85));
			this.class533_0 = class;
			Class533 class2 = new Class533(string.Empty, 24f, new Vector2(0f, 260f), 1f, true, Tournament.color_0);
			class2.origins_0 = Origins.TopLeft;
			class2.bool_16 = true;
			class2.method_59(true);
			this.class533_1 = class2;
			Class533 class3 = new Class533(string.Empty, 24f, new Vector2(0f, 260f), 1f, true, Tournament.color_0);
			class3.enum115_0 = Enum115.const_7;
			class3.origins_0 = Origins.TopRight;
			class3.bool_16 = true;
			class3.method_59(true);
			this.class533_2 = class3;
			Class533 class4 = new Class533("0", 48f, new Vector2((float)(Class115.smethod_43() / 2 - 15), 280f), 1f, true, Color.get_White());
			class4.origins_0 = Origins.CentreRight;
			class4.bool_16 = true;
			class4.method_59(true);
			this.class533_3 = class4;
			Class533 class5 = new Class533("0", 48f, new Vector2((float)(Class115.smethod_43() / 2 + 15), 280f), 1f, true, Color.get_White());
			class5.origins_0 = Origins.CentreLeft;
			class5.bool_16 = true;
			class5.method_59(true);
			this.class533_4 = class5;
			Class533 class6 = new Class533("warm-up", 26f, new Vector2((float)(Class115.smethod_43() / 2), 300f), 1f, true, Color.get_TransparentWhite());
			class6.method_53(Color.get_Black());
			class6.origins_0 = Origins.TopCentre;
			class6.bool_16 = true;
			this.class533_5 = class6;
			Class533 class7 = new Class533("0000000", 24f, new Vector2(0f, 280f), 1f, true, Tournament.color_0);
			class7.origins_0 = Origins.TopLeft;
			class7.bool_16 = true;
			class7.method_59(true);
			this.class533_6 = class7;
			Class533 class8 = new Class533("0000000", 24f, new Vector2(0f, 280f), 1f, true, Tournament.color_0);
			class8.enum115_0 = Enum115.const_7;
			class8.origins_0 = Origins.TopRight;
			class8.bool_16 = true;
			class8.method_59(true);
			this.class533_7 = class8;
			this.class531_0 = new Class531(null, new Vector2(30f, 280f), 1f, true, Color.get_White())
			{
				origins_0 = Origins.Centre,
				float_2 = 0.3f
			};
			this.class531_1 = new Class531(null, new Vector2(30f, 280f), 1f, true, Color.get_White())
			{
				origins_0 = Origins.Centre,
				enum115_0 = Enum115.const_7,
				float_2 = 0.3f
			};
			this.list_0 = new List<Class531>();
			this.class911_1 = new Class911(true);
			this.list_2 = new List<Class531>();
			base..ctor(class115_0);
		}

		// Token: 0x06001D66 RID: 7526
		// RVA: 0x00018322 File Offset: 0x00016522
		protected override void Dispose(bool bool_4)
		{
			if (Class115.osuModes_1 == OsuModes.Exit)
			{
				this.method_13();
			}
			this.class911_1.Dispose();
			base.Dispose(bool_4);
		}

		// Token: 0x06001D67 RID: 7527
		// RVA: 0x00018344 File Offset: 0x00016544
		public override void Draw()
		{
			base.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06001D6B RID: 7531
		// RVA: 0x0009FF38 File Offset: 0x0009E138
		public override void imethod_2()
		{
			Action<InterProcessOsu.ClientData> action = null;
			Tournament.Class408 class = new Tournament.Class408();
			Tournament.double_0 += Class115.double_9;
			base.imethod_2();
			if (Tournament.smethod_3() != Tournament.TourneyState.Initialising)
			{
				this.method_10();
			}
			if ((Class466.Current == null && Class466.list_3.Count > 0) || this.method_6() == null || Tournament.smethod_3() == Tournament.TourneyState.Initialising || (Tournament.smethod_3() == Tournament.TourneyState.Idle && Class331.enum100_0 == Enum100.const_0))
			{
				Class109.smethod_2();
				if (Class466.Current != null && Tournament.smethod_3() != Tournament.TourneyState.Initialising)
				{
					for (int i = 0; i < Tournament.list_1.Count; i++)
					{
						InterProcessOsu interProcessOsu = Tournament.list_1[i];
						interProcessOsu.method_12(Class466.Current.string_3);
						interProcessOsu.method_9(Class331.int_7);
					}
				}
				return;
			}
			this.method_9();
			class.int_0 = Class331.int_7;
			List<InterProcessOsu.ClientData> list = new List<InterProcessOsu.ClientData>();
			for (int j = 0; j < Tournament.list_1.Count; j++)
			{
				list.Add(Tournament.list_1[j].method_3());
			}
			int num = 2147483647;
			int num2 = 2147483647;
			switch (Tournament.smethod_3())
			{
			case Tournament.TourneyState.Playing:
			{
				for (int k = 0; k < list.Count; k++)
				{
					if (!list[k].SkipCalculations)
					{
						num = Math.Min(list[k].AudioTime, num);
						num2 = Math.Min(list[k].ReplayTime, num2);
					}
				}
				if (num <= 0)
				{
					Class331.smethod_70(0, false, false);
					if (!Class331.smethod_79())
					{
						Class331.smethod_88();
					}
				}
				Tournament.bool_3 = (Tournament.bool_3 ? (Class331.int_7 >= num2 - Tournament.int_6) : (Class331.int_7 >= num2 - Tournament.int_7));
				class.int_0 = (Tournament.bool_3 ? num2 : (num + ((Class331.smethod_67() > 100) ? 140 : 100)));
				bool flag = Tournament.bool_3 || (class.int_0 <= Class331.int_7 && Math.Abs(class.int_0 - Class331.int_7) < 1000);
				if ((Tournament.bool_3 && !Class331.smethod_79()) || !Tournament.bool_3)
				{
					Tournament.double_1 = Tournament.double_0;
				}
				if ((flag && !Class331.smethod_79()) || (!flag && Class331.smethod_79()))
				{
					Class331.smethod_88();
				}
				if (Class331.smethod_79())
				{
					for (int l = 0; l < list.Count; l++)
					{
						if (list[l].AudioTime >= 0)
						{
							if (!list[l].Buffering)
							{
								Tournament.list_1[l].method_7();
							}
							list[l].OverridePause = true;
						}
					}
				}
				if (num > 0 && Math.Abs(Class331.int_7 - num) >= 20)
				{
					Class331.smethod_70(num, false, false);
				}
				break;
			}
			case Tournament.TourneyState.Ranking:
			{
				class.int_0 = 1073741823;
				List<InterProcessOsu.ClientData> arg_2AD_0 = list;
				if (action == null)
				{
					action = new Action<InterProcessOsu.ClientData>(class.method_0);
				}
				arg_2AD_0.ForEach(action);
				class.int_0 += 1000;
				if (Tournament.double_0 > 40000.0)
				{
					List<InterProcessOsu> arg_2F7_0 = Tournament.list_1;
					if (Tournament.action_1 == null)
					{
						Tournament.action_1 = new Action<InterProcessOsu>(Tournament.smethod_8);
					}
					arg_2F7_0.ForEach(Tournament.action_1);
				}
				break;
			}
			}
			Tournament.int_2 = 0;
			Tournament.int_3 = 0;
			for (int m = 0; m < list.Count; m++)
			{
				int score = list[m].Score;
				if (m < Tournament.list_1.Count / 2)
				{
					Tournament.int_2 += score;
				}
				else
				{
					Tournament.int_3 += score;
				}
				OsuModes mode = list[m].Mode;
				if (mode != OsuModes.Rank && list[m].SpectatingID != this.method_6().slotId[m])
				{
					Tournament.list_1[m].method_10(this.method_6().slotId[m]);
				}
				if (mode != OsuModes.Play && Class466.Current != null)
				{
					Tournament.list_1[m].method_12(Class466.Current.string_3);
				}
				if ((Tournament.bool_3 && Math.Abs(Tournament.double_0 - Tournament.double_1) > (double)Tournament.int_8 && list[m].ReplayTime == num2 && !list[m].SkipCalculations) || (list[m].AudioTime >= class.int_0 && list[m].SkipCalculations))
				{
					Tournament.list_1[m].method_8();
					Tournament.double_1 = Tournament.double_0;
				}
				if (list[m].AudioTime > class.int_0 && !list[m].Buffering)
				{
					Tournament.list_1[m].method_7();
				}
				else if (list[m].AudioTime <= class.int_0 && !list[m].OverridePause && list[m].Buffering)
				{
					Tournament.list_1[m].method_7();
				}
				Tournament.list_1[m].method_14(50);
			}
			if (Tournament.smethod_3() == Tournament.TourneyState.Idle)
			{
				this.class533_6.Text = string.Empty;
				this.class533_7.Text = string.Empty;
				return;
			}
			this.class533_6.Text = ((Tournament.int_2 > 0) ? Tournament.int_2.ToString("#,0") : string.Empty);
			this.class533_7.Text = ((Tournament.int_3 > 0) ? Tournament.int_3.ToString("#,0") : string.Empty);
			this.class533_6.color_0 = ((Tournament.int_2 > Tournament.int_3) ? Color.get_YellowGreen() : Color.get_White());
			this.class533_7.color_0 = ((Tournament.int_3 > Tournament.int_2) ? Color.get_YellowGreen() : Color.get_White());
		}

		// Token: 0x06001D5F RID: 7519
		// RVA: 0x0009F40C File Offset: 0x0009D60C
		public override void Initialize()
		{
			VoidDelegate voidDelegate = null;
			Tournament.Class406 class = new Tournament.Class406();
			class.tournament_0 = this;
			Tournament.tournament_0 = this;
			Tournament.string_0 = Tournament.class43_0.GetValue<string>("acronym", "OWC");
			this.class533_6.method_51(new EventHandler(this.method_1));
			this.class533_7.method_51(new EventHandler(this.method_1));
			this.class911_1.Add(this.class533_0);
			this.class911_1.Add(this.class533_1);
			this.class911_1.Add(this.class533_2);
			this.class911_1.Add(this.class531_0);
			this.class911_1.Add(this.class531_1);
			this.class911_1.Add(this.class533_3);
			this.class911_1.Add(this.class533_4);
			this.class911_1.Add(this.class533_6);
			this.class911_1.Add(this.class533_7);
			this.class911_1.Add(this.class533_5);
			int num = Class115.smethod_43() - 200;
			int num2 = 380;
			Class911 arg_17E_0 = this.class911_1;
			string arg_174_0 = "sync music";
			Vector2 arg_174_1 = new Vector2((float)num, 380f);
			Vector2 arg_174_2 = new Vector2(80f, 15f);
			float arg_174_3 = 1f;
			Color arg_174_4 = Color.get_YellowGreen();
			if (Tournament.eventHandler_4 == null)
			{
				Tournament.eventHandler_4 = new EventHandler(Tournament.smethod_5);
			}
			arg_17E_0.Add<Class531>(new Class760(arg_174_0, arg_174_1, arg_174_2, arg_174_3, arg_174_4, Tournament.eventHandler_4, true, false, null).list_0);
			num2 += 16;
			this.class911_1.Add<Class531>(new Class760("toggle warmup", new Vector2((float)num, (float)num2), new Vector2(80f, 15f), 1f, Color.get_YellowGreen(), new EventHandler(this.method_14), true, false, null).list_0);
			num2 += 16;
			this.class911_1.Add<Class531>(new Class760("panic", new Vector2((float)num, (float)num2), new Vector2(80f, 15f), 1f, Color.get_Red(), new EventHandler(this.method_15), true, false, null).list_0);
			num2 += 16;
			Class911 arg_29A_0 = this.class911_1;
			string arg_290_0 = "exit";
			Vector2 arg_290_1 = new Vector2((float)num, (float)num2);
			Vector2 arg_290_2 = new Vector2(80f, 15f);
			float arg_290_3 = 1f;
			Color arg_290_4 = Color.get_Red();
			if (Tournament.eventHandler_5 == null)
			{
				Tournament.eventHandler_5 = new EventHandler(Tournament.smethod_6);
			}
			arg_29A_0.Add<Class531>(new Class760(arg_290_0, arg_290_1, arg_290_2, arg_290_3, arg_290_4, Tournament.eventHandler_5, true, false, null).list_0);
			this.class533_3.bool_1 = true;
			this.class533_4.bool_1 = true;
			this.class533_3.method_2(new EventHandler(this.method_3));
			this.class533_4.method_2(new EventHandler(this.method_3));
			Class466.Initialize(false);
			Class466.smethod_29();
			int num3 = 10000;
			while (!Class809.bool_4 && (num3 -= 50) > 0)
			{
				Thread.Sleep(50);
			}
			if (!Class809.bool_4)
			{
				Class792.smethod_0("tournament server is not available. please contact peppy");
				Class905.smethod_12();
				return;
			}
			Class70.smethod_0();
			this.method_4();
			if (Tournament.list_1.Count == 0)
			{
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_16);
				}
				Class115.smethod_88(voidDelegate, false, ThreadPriority.Normal);
			}
			else if (Class115.osuModes_2 == OsuModes.BeatmapImport)
			{
				foreach (InterProcessOsu current in Tournament.list_1)
				{
					current.method_11();
				}
			}
			class.class537_0 = new Class537(Tournament.class43_0.GetValue<string>("background", "http://dl.dropboxusercontent.com/u/16332218/tourney/default.png"), null, 0, Vector2.get_Zero(), 0f);
			class.class537_0.bool_0 = true;
			class.class537_0.method_55(new VoidDelegate(class.method_0));
			this.class911_1.Add(class.class537_0);
			this.method_5();
			base.Initialize();
		}

		// Token: 0x06001D60 RID: 7520
		// RVA: 0x0009F838 File Offset: 0x0009DA38
		private void method_1(object sender, EventArgs e)
		{
			Class533 class = sender as Class533;
			class.float_2 = 1.05f;
			class.method_26(1f, 100, Enum70.const_0);
		}

		// Token: 0x06001D6F RID: 7535
		// RVA: 0x000A07D0 File Offset: 0x0009E9D0
		private void method_10()
		{
			List<InterProcessOsu> arg_22_0 = Tournament.list_1;
			if (Tournament.predicate_0 == null)
			{
				Tournament.predicate_0 = new Predicate<InterProcessOsu>(Tournament.smethod_10);
			}
			int count = arg_22_0.FindAll(Tournament.predicate_0).Count;
			List<InterProcessOsu> arg_4F_0 = Tournament.list_1;
			if (Tournament.predicate_1 == null)
			{
				Tournament.predicate_1 = new Predicate<InterProcessOsu>(Tournament.smethod_11);
			}
			int count2 = arg_4F_0.FindAll(Tournament.predicate_1).Count;
			if (count2 > 0)
			{
				Tournament.smethod_4(Tournament.TourneyState.Ranking);
				return;
			}
			if (count > 0)
			{
				Tournament.smethod_4(Tournament.TourneyState.Playing);
				return;
			}
			Tournament.smethod_4(Tournament.TourneyState.Idle);
		}

		// Token: 0x06001D70 RID: 7536
		// RVA: 0x000A0854 File Offset: 0x0009EA54
		private InterProcessOsu method_11(int int_9)
		{
			Process.Start(Class905.smethod_1(), "-spectateclient " + int_9);
			InterProcessOsu interProcessOsu = null;
			while (interProcessOsu == null)
			{
				try
				{
					Thread.Sleep(50);
					interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://osu!-spectator-" + int_9 + "/loader");
					interProcessOsu.method_15();
				}
				catch
				{
					interProcessOsu = null;
				}
			}
			this.method_12(int_9, Color.get_YellowGreen());
			return interProcessOsu;
		}

		// Token: 0x06001D71 RID: 7537
		// RVA: 0x000183A9 File Offset: 0x000165A9
		private void method_12(int int_9, Color color_1)
		{
			this.list_0[int_9].color_0 = color_1;
			this.list_0[int_9].method_17(1500);
		}

		// Token: 0x06001D72 RID: 7538
		// RVA: 0x000A08E0 File Offset: 0x0009EAE0
		private void method_13()
		{
			foreach (InterProcessOsu current in Tournament.list_1)
			{
				try
				{
					current.method_2();
				}
				catch
				{
				}
			}
			Tournament.list_1.Clear();
		}

		// Token: 0x06001D74 RID: 7540
		// RVA: 0x000183DB File Offset: 0x000165DB
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06001D75 RID: 7541
		// RVA: 0x000183E3 File Offset: 0x000165E3
		[CompilerGenerated]
		private void method_15(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x06001D77 RID: 7543
		// RVA: 0x000A0950 File Offset: 0x0009EB50
		[CompilerGenerated]
		private void method_16()
		{
			for (int i = 0; i < Tournament.int_5; i++)
			{
				Class531 class = new Class531(Class115.class731_0, Tournament.smethod_2(i, false), 1f, true, Color.get_TransparentWhite())
				{
					vector2_2 = Tournament.smethod_0(),
					enum115_0 = Enum115.const_4
				};
				this.class911_1.Add(class);
				this.list_0.Add(class);
				Tournament.list_1.Add(this.method_11(i));
			}
			Class621.smethod_0("Initialisation Complete!");
			Tournament.smethod_4(Tournament.TourneyState.Idle);
		}

		// Token: 0x06001D7B RID: 7547
		// RVA: 0x0001841D File Offset: 0x0001661D
		[CompilerGenerated]
		private void method_17(object sender, EventArgs e)
		{
			Class77.smethod_3();
			this.bool_2 = false;
		}

		// Token: 0x06001D61 RID: 7521
		// RVA: 0x000182F0 File Offset: 0x000164F0
		private void method_2()
		{
			if (this.class533_5.bool_3)
			{
				this.class533_5.method_16(500, Enum70.const_0);
				return;
			}
			this.class533_5.method_14(500, Enum70.const_0);
		}

		// Token: 0x06001D62 RID: 7522
		// RVA: 0x0009F868 File Offset: 0x0009DA68
		private void method_3(object sender, EventArgs e)
		{
			Class533 class = sender as Class533;
			if (Class800.smethod_3() == 1)
			{
				class.int_0--;
			}
			else
			{
				class.int_0++;
			}
			class.Text = class.int_0.ToString();
			class.float_2 = 1.2f;
			class.method_26(1f, 500, Enum70.const_1);
		}

		// Token: 0x06001D63 RID: 7523
		// RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		private void method_4()
		{
			if (Class70.enum59_0 == Enum59.const_0)
			{
				Class70.smethod_1(false);
				Class70.smethod_0();
			}
			List<Class531> arg_35_0 = this.list_2;
			if (Tournament.action_0 == null)
			{
				Tournament.action_0 = new Action<Class531>(Tournament.smethod_7);
			}
			arg_35_0.ForEach(Tournament.action_0);
			this.list_2.Clear();
			lock (Class70.list_0)
			{
				int num = 380;
				bool flag = false;
				int num2 = 20;
				using (List<Class838>.Enumerator enumerator = Class70.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EventHandler eventHandler = null;
						Tournament.Class407 class = new Tournament.Class407();
						class.tournament_0 = this;
						class.class838_0 = enumerator.Current;
						if ((!flag || class.class838_0.bMatch_0.method_2() >= 5) && class.class838_0.bMatch_0.gameName.StartsWith(Tournament.string_0))
						{
							if (num2-- == 0)
							{
								break;
							}
							Class533 class2 = new Class533(string.Concat(new object[]
							{
								class.class838_0.bMatch_0.matchId,
								" : @",
								class.class838_0.bMatch_0.gameName,
								" (",
								class.class838_0.bMatch_0.beatmapName,
								") ",
								class.class838_0.bMatch_0.method_2(),
								"/",
								class.class838_0.bMatch_0.method_3()
							}), 7f, new Vector2(0f, (float)num), 1f, true, Color.get_White());
							class2.bool_1 = true;
							class2.bool_16 = (class.class838_0.bMatch_0 == this.method_6());
							Class530 arg_1D8_0 = class2;
							if (eventHandler == null)
							{
								eventHandler = new EventHandler(class.method_0);
							}
							arg_1D8_0.method_2(eventHandler);
							this.list_2.Add(class2);
							this.class911_1.Add(class2);
							num += (int)class2.vmethod_11().Y;
						}
					}
				}
				if (num == 380)
				{
					Class533 class3 = new Class533("Make a multiplayer room with format:", 10f, new Vector2(0f, (float)num), 1f, true, Color.get_White());
					this.list_2.Add(class3);
					this.class911_1.Add(class3);
					num += (int)class3.vmethod_11().Y;
					class3 = new Class533(Tournament.string_0 + ": (team 1 name) vs (team 2 name)", 10f, new Vector2(0f, (float)num), 1f, true, Color.get_White());
					class3.bool_16 = true;
					this.list_2.Add(class3);
					this.class911_1.Add(class3);
				}
			}
			Class115.class47_0.method_1(new VoidDelegate(this.method_4), 5000, false);
		}

		// Token: 0x06001D64 RID: 7524
		// RVA: 0x0009FC08 File Offset: 0x0009DE08
		private void method_5()
		{
			if (this.method_6() != null)
			{
				Class809.smethod_34(Enum3.const_93, new Struct12(this.method_6().matchId));
			}
			Class115.class47_0.method_1(new VoidDelegate(this.method_5), 1000, false);
		}

		// Token: 0x06001D68 RID: 7528
		// RVA: 0x00018358 File Offset: 0x00016558
		private bMatch method_6()
		{
			if (this.class838_0 != null)
			{
				return this.class838_0.bMatch_0;
			}
			return null;
		}

		// Token: 0x06001D6C RID: 7532
		// RVA: 0x00018376 File Offset: 0x00016576
		private void method_7()
		{
			Class621.smethod_0("Resetting all clients");
			List<InterProcessOsu> arg_2C_0 = Tournament.list_1;
			if (Tournament.action_2 == null)
			{
				Tournament.action_2 = new Action<InterProcessOsu>(Tournament.smethod_9);
			}
			arg_2C_0.ForEach(Tournament.action_2);
		}

		// Token: 0x06001D6D RID: 7533
		// RVA: 0x000A053C File Offset: 0x0009E73C
		private void method_8(Class838 class838_1)
		{
			this.method_7();
			this.class838_0 = class838_1;
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = class838_1.bMatch_0.gameName;
			int num;
			if ((num = text3.IndexOf(':')) > 0)
			{
				text3 = text3.Substring(num + 1);
			}
			string[] array = text3.Split(new char[]
			{
				'(',
				')',
				'（',
				'）'
			});
			if (array.Length >= 4)
			{
				text = array[1].Trim();
				text2 = array[3].Trim();
			}
			else
			{
				text = "-";
				text2 = "-";
			}
			this.class533_1.Text = text;
			this.class533_2.Text = text2;
			this.class531_0.vmethod_7(Class885.Load("flags/" + text, Enum112.flag_6));
			this.class531_1.vmethod_7(Class885.Load("flags/" + text2, Enum112.flag_6));
			this.class533_1.vector2_1.X = (this.class533_6.vector2_1.X = (float)this.class531_0.int_6 / 1.6f * this.class531_0.float_2 + 10f);
			this.class533_2.vector2_1.X = (this.class533_7.vector2_1.X = (float)this.class531_1.int_6 / 1.6f * this.class531_1.float_2 + 10f);
		}

		// Token: 0x06001D6E RID: 7534
		// RVA: 0x000A06C4 File Offset: 0x0009E8C4
		private void method_9()
		{
			EventHandler eventHandler = null;
			if (Class77.smethod_2())
			{
				return;
			}
			if ((this.method_6().activeMods & Mods.DoubleTime) > Mods.None)
			{
				Class331.smethod_68(150);
			}
			else if ((this.method_6().activeMods & Mods.HalfTime) > Mods.None)
			{
				Class331.smethod_68(75);
			}
			else
			{
				Class331.smethod_68(100);
			}
			if (Class466.Current != null && this.method_6().beatmapChecksum == Class466.Current.string_3)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.method_6().beatmapChecksum))
			{
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
			}
			else
			{
				Class296 class = Class466.smethod_25(this.method_6().beatmapChecksum);
				if (class == null)
				{
					if (this.bool_2)
					{
						return;
					}
					this.bool_2 = true;
					string arg_D2_0 = this.method_6().beatmapChecksum;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(this.method_17);
					}
					Class112.smethod_6(arg_D2_0, eventHandler, null);
					return;
				}
				else
				{
					this.class533_0.Text = "Now Playing: " + class.method_76();
					Class466.Load(class);
					this.method_7();
				}
			}
		}

		// Token: 0x06001D5C RID: 7516
		// RVA: 0x0009F058 File Offset: 0x0009D258
		internal static Vector2 smethod_0()
		{
			switch (Tournament.int_5)
			{
			case 1:
			case 2:
				return new Vector2(Tournament.vector2_0.X / 2f, Tournament.vector2_0.X / 2f / 4f * 3f);
			default:
				return new Vector2(Tournament.vector2_0.X / 4f, Tournament.vector2_0.X / 4f / 4f * 3f);
			}
		}

		// Token: 0x06001D5D RID: 7517
		// RVA: 0x000182D5 File Offset: 0x000164D5
		internal static Vector2 smethod_1()
		{
			return Tournament.smethod_0() - new Vector2(8f, 8f);
		}

		// Token: 0x06001D7C RID: 7548
		// RVA: 0x0001842B File Offset: 0x0001662B
		[CompilerGenerated]
		private static bool smethod_10(InterProcessOsu interProcessOsu_0)
		{
			return interProcessOsu_0.method_15() == OsuModes.Play;
		}

		// Token: 0x06001D7D RID: 7549
		// RVA: 0x00018436 File Offset: 0x00016636
		[CompilerGenerated]
		private static bool smethod_11(InterProcessOsu interProcessOsu_0)
		{
			return interProcessOsu_0.method_15() == OsuModes.Rank;
		}

		// Token: 0x06001D65 RID: 7525
		// RVA: 0x0009FC58 File Offset: 0x0009DE58
		internal static Vector2 smethod_2(int int_9, bool bool_4)
		{
			switch (Tournament.int_5)
			{
			case 1:
			case 2:
				return new Vector2(((int_9 >= 1) ? Tournament.smethod_0().X : 0f) + (float)(bool_4 ? 4 : 0), (float)(bool_4 ? 4 : 0));
			case 3:
			case 4:
				return new Vector2(((int_9 >= 2) ? Tournament.smethod_0().X : 0f) + (float)(bool_4 ? 4 : 0) + Tournament.smethod_0().X, (float)((int_9 % 2 == 1) ? 1 : 0) * Tournament.smethod_0().Y + (float)(bool_4 ? 4 : 0));
			case 6:
				switch (int_9)
				{
				case 0:
					return new Vector2((float)(bool_4 ? 4 : 0) + Tournament.smethod_0().X / 2f, (float)(bool_4 ? 4 : 0));
				case 1:
				case 2:
					return new Vector2((float)(bool_4 ? 4 : 0) + Tournament.smethod_0().X * (float)(int_9 - 1), (float)(bool_4 ? 4 : 0) + Tournament.smethod_0().Y);
				case 3:
					return new Vector2((float)(bool_4 ? 4 : 0) + Tournament.smethod_0().X * 2.5f, (float)(bool_4 ? 4 : 0));
				case 4:
				case 5:
					return new Vector2((float)(bool_4 ? 4 : 0) + Tournament.smethod_0().X * (float)(2 + (int_9 - 4)), (float)(bool_4 ? 4 : 0) + Tournament.smethod_0().Y);
				default:
					return new Vector2(((int_9 >= 4) ? (Tournament.smethod_0().X * 2f) : 0f) + (float)(int_9 % 2) * Tournament.smethod_0().X + (float)(bool_4 ? 4 : 0), (float)((int_9 % 4 > 1) ? 1 : 0) * Tournament.smethod_0().Y + (float)(bool_4 ? 4 : 0));
				}
				break;
			}
			return new Vector2(((int_9 >= 4) ? (Tournament.smethod_0().X * 2f) : 0f) + (float)(int_9 % 2) * Tournament.smethod_0().X + (float)(bool_4 ? 4 : 0), (float)((int_9 % 4 > 1) ? 1 : 0) * Tournament.smethod_0().Y + (float)(bool_4 ? 4 : 0));
		}

		// Token: 0x06001D69 RID: 7529
		// RVA: 0x0001836F File Offset: 0x0001656F
		private static Tournament.TourneyState smethod_3()
		{
			return Tournament.tourneyState_0;
		}

		// Token: 0x06001D6A RID: 7530
		// RVA: 0x0009FE98 File Offset: 0x0009E098
		private static void smethod_4(Tournament.TourneyState tourneyState_1)
		{
			if (Tournament.tourneyState_0 == tourneyState_1)
			{
				return;
			}
			Tournament.tourneyState_0 = tourneyState_1;
			Tournament.TourneyState tourneyState = Tournament.tourneyState_0;
			if (tourneyState == Tournament.TourneyState.Ranking && !Tournament.tournament_0.class533_5.bool_3)
			{
				if (Tournament.int_2 > Tournament.int_3)
				{
					Tournament.tournament_0.class533_3.method_0(true);
				}
				else
				{
					Tournament.tournament_0.class533_4.method_0(true);
				}
			}
			Tournament.double_0 = 0.0;
			Tournament.bool_3 = true;
			Class621.smethod_1("Tournament Manager state changed to {0}", new string[]
			{
				Tournament.tourneyState_0.ToString()
			});
		}

		// Token: 0x06001D73 RID: 7539
		// RVA: 0x000183D4 File Offset: 0x000165D4
		[CompilerGenerated]
		private static void smethod_5(object sender, EventArgs e)
		{
			Class331.smethod_87();
		}

		// Token: 0x06001D76 RID: 7542
		// RVA: 0x000183EB File Offset: 0x000165EB
		[CompilerGenerated]
		private static void smethod_6(object sender, EventArgs e)
		{
			Class115.smethod_69(false);
		}

		// Token: 0x06001D78 RID: 7544
		// RVA: 0x000183F3 File Offset: 0x000165F3
		[CompilerGenerated]
		private static void smethod_7(Class531 class531_2)
		{
			class531_2.method_16(0, Enum70.const_0);
			class531_2.bool_0 = false;
		}

		// Token: 0x06001D79 RID: 7545
		// RVA: 0x00018404 File Offset: 0x00016604
		[CompilerGenerated]
		private static void smethod_8(InterProcessOsu interProcessOsu_0)
		{
			interProcessOsu_0.method_17(OsuModes.Menu);
		}

		// Token: 0x06001D7A RID: 7546
		// RVA: 0x0001840D File Offset: 0x0001660D
		[CompilerGenerated]
		private static void smethod_9(InterProcessOsu interProcessOsu_0)
		{
			interProcessOsu_0.method_10(-1);
			interProcessOsu_0.method_17(OsuModes.Menu);
		}
	}
}
