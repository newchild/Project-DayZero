using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns19;
using ns24;
using ns29;
using ns3;
using ns40;
using ns5;
using ns6;
using ns7;
using ns76;
using ns78;
using ns82;
using ns90;
using osu;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000653 RID: 1619
	internal static class Class858
	{
		// Token: 0x02000654 RID: 1620
		[CompilerGenerated]
		private sealed class Class859
		{
			// Token: 0x04002D89 RID: 11657
			public Class861 class861_0;

			// Token: 0x060031E2 RID: 12770
			// RVA: 0x00024D06 File Offset: 0x00022F06
			public void method_0()
			{
				Class858.smethod_8(this.class861_0);
			}
		}

		// Token: 0x02000655 RID: 1621
		[CompilerGenerated]
		private sealed class Class860
		{
			// Token: 0x04002D8A RID: 11658
			public Class861 class861_0;

			// Token: 0x060031E4 RID: 12772
			// RVA: 0x00024D13 File Offset: 0x00022F13
			public void method_0()
			{
				Class858.smethod_8(this.class861_0);
			}
		}

		// Token: 0x04002D76 RID: 11638
		private static bool bool_0;

		// Token: 0x04002D7F RID: 11647
		internal static bool bool_1;

		// Token: 0x04002D80 RID: 11648
		private static bool bool_2;

		// Token: 0x04002D83 RID: 11651
		private static bool bool_3;

		// Token: 0x04002D75 RID: 11637
		internal static Class861 class861_0;

		// Token: 0x04002D78 RID: 11640
		private static Enum0 enum0_0 = Enum0.const_0;

		// Token: 0x04002D81 RID: 11649
		internal static Enum0 enum0_1;

		// Token: 0x04002D7D RID: 11645
		internal static int int_0;

		// Token: 0x04002D82 RID: 11650
		private static int int_1;

		// Token: 0x04002D7A RID: 11642
		public static List<Class861> list_0 = new List<Class861>();

		// Token: 0x04002D7B RID: 11643
		public static List<Class861> list_1 = new List<Class861>();

		// Token: 0x04002D7C RID: 11644
		internal static List<Class14> list_2 = new List<Class14>();

		// Token: 0x04002D77 RID: 11639
		internal static object object_0 = new object();

		// Token: 0x04002D85 RID: 11653
		[CompilerGenerated]
		private static Predicate<Class21> predicate_0;

		// Token: 0x04002D86 RID: 11654
		[CompilerGenerated]
		private static Predicate<Class21> predicate_1;

		// Token: 0x04002D88 RID: 11656
		[CompilerGenerated]
		private static Predicate<Class854> predicate_2;

		// Token: 0x04002D79 RID: 11641
		internal static Queue<Class512> queue_0 = new Queue<Class512>();

		// Token: 0x04002D7E RID: 11646
		internal static Struct13 struct13_0;

		// Token: 0x04002D84 RID: 11652
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04002D87 RID: 11655
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x060031DA RID: 12762
		// RVA: 0x00146A28 File Offset: 0x00144C28
		internal static void Cleanup()
		{
			lock (Class858.object_0)
			{
				Class858.list_0.Clear();
				Class858.smethod_4(false);
				Class858.bool_1 = false;
			}
		}

		// Token: 0x060031D9 RID: 12761
		// RVA: 0x001469FC File Offset: 0x00144BFC
		public static void Reset()
		{
			Class858.list_2 = new List<Class14>();
			Class858.smethod_3(Enum0.const_1, null);
			Class858.smethod_4(false);
		}

		// Token: 0x060031D0 RID: 12752
		// RVA: 0x00146114 File Offset: 0x00144314
		public static void smethod_0(Class13 class13_0)
		{
			Class858.bool_3 = false;
			Class858.enum0_1 = class13_0.enum0_0;
			switch (class13_0.enum0_0)
			{
			case Enum0.const_1:
				Class858.bool_0 = false;
				Class62.int_12 = class13_0.int_0;
				Class858.smethod_6(true);
				break;
			case Enum0.const_2:
				Class62.smethod_3();
				break;
			case Enum0.const_3:
				Class802.bool_17 = true;
				break;
			case Enum0.const_4:
				Class802.bool_17 = true;
				break;
			case Enum0.const_5:
				if (!Class62.bool_11 && Class62.class62_0 != null)
				{
					Class62.class62_0.vmethod_16();
				}
				break;
			case Enum0.const_6:
				if (Class62.bool_11 && Class62.class62_0 != null)
				{
					Class62.class62_0.vmethod_16();
				}
				break;
			case Enum0.const_8:
			{
				Class861 class = Class809.smethod_28(class13_0.int_0, true);
				if (class != null && class.int_1 != Class115.class861_0.int_1)
				{
					Class723.smethod_5("Following host to new user...", Color.get_Green(), 3000, null);
					Class858.smethod_5(class);
				}
				else
				{
					Class858.smethod_4(true);
				}
				break;
			}
			}
			if (!Class858.bool_0 && Class802.class512_0 == null)
			{
				if (class13_0.list_0.Count > 0)
				{
					Class802.int_2 = class13_0.list_0[0].int_0 - 50;
				}
				else
				{
					Class802.int_2 = 1;
				}
				Class62.int_12 = class13_0.int_0;
				Class858.smethod_6(false);
			}
			lock (Class858.object_0)
			{
				if (Class802.class512_0 != null && Class802.class512_0.list_1 != null)
				{
					foreach (Class14 current in class13_0.list_0)
					{
						Class802.class512_0.list_1.Add(current);
					}
					if (class13_0.list_0.Count > 0)
					{
						int index = class13_0.list_0.Count - 1;
						float arg_1DC_0 = class13_0.list_0[index].float_1;
						int arg_1EE_0 = class13_0.list_0[index].int_0;
					}
					if ((Class858.int_0 <= 0 || Class858.int_0 < Class802.int_1 || Class802.class512_0.list_1.Count - 1 < Class858.int_0) && class13_0.struct13_0.int_2 > 0)
					{
						Class858.int_0 = Class802.class512_0.list_1.Count - 1;
						Class858.struct13_0 = class13_0.struct13_0;
					}
				}
			}
			if (Class858.bool_1 && Class858.class861_0 != null && Class858.class861_0.int_1 != Class115.class861_0.int_1 && Class115.int_1 - Class858.int_1 > 10000)
			{
				Class809.smethod_34(Enum3.const_18, new Class13(new List<Class14>(), Enum0.const_8, default(Struct13), Class858.class861_0.int_1));
				Class858.int_1 = Class115.int_1;
			}
		}

		// Token: 0x060031D1 RID: 12753
		// RVA: 0x001463F8 File Offset: 0x001445F8
		public static void smethod_1(Class14 class14_0)
		{
			if (!Class858.bool_1 && Class858.list_2.Count > 0)
			{
				Class858.list_2.Clear();
				return;
			}
			Class858.list_2.Add(class14_0);
			if (Class858.list_2.Count >= 30)
			{
				Class858.smethod_3(Class858.enum0_0, null);
				Class858.enum0_0 = Enum0.const_0;
			}
		}

		// Token: 0x060031DC RID: 12764
		// RVA: 0x00024C89 File Offset: 0x00022E89
		[CompilerGenerated]
		private static bool smethod_10(Class21 class21_0)
		{
			return class21_0.string_0 == "#spectator";
		}

		// Token: 0x060031DD RID: 12765
		// RVA: 0x00024C89 File Offset: 0x00022E89
		[CompilerGenerated]
		private static bool smethod_11(Class21 class21_0)
		{
			return class21_0.string_0 == "#spectator";
		}

		// Token: 0x060031DE RID: 12766
		// RVA: 0x00024C9B File Offset: 0x00022E9B
		[CompilerGenerated]
		private static void smethod_12()
		{
			if (Class111.bool_1)
			{
				Class111.smethod_19();
			}
		}

		// Token: 0x060031DF RID: 12767
		// RVA: 0x00024CA9 File Offset: 0x00022EA9
		[CompilerGenerated]
		private static bool smethod_13(Class854 class854_0)
		{
			return class854_0.class690_0 != null && class854_0.class690_0.int_5 == Class858.class861_0.int_0;
		}

		// Token: 0x060031D2 RID: 12754
		// RVA: 0x00024C2F File Offset: 0x00022E2F
		internal static void smethod_2()
		{
			Class858.bool_3 = true;
			Class47 arg_2E_0 = Class115.class47_0;
			if (Class858.voidDelegate_0 == null)
			{
				Class858.voidDelegate_0 = new VoidDelegate(Class858.smethod_9);
			}
			arg_2E_0.method_1(Class858.voidDelegate_0, 10000, false);
		}

		// Token: 0x060031D3 RID: 12755
		// RVA: 0x00146458 File Offset: 0x00144658
		internal static void smethod_3(Enum0 enum0_2, int? nullable_0)
		{
			if (Class858.bool_1 && !Class802.smethod_0())
			{
				if (enum0_2 == Enum0.const_1)
				{
					lock (Class858.list_0)
					{
						foreach (Class861 current in Class858.list_0)
						{
							current.bool_0 = false;
						}
					}
				}
				Struct13 struct13_ = Class62.smethod_8();
				Class809.smethod_34(Enum3.const_18, new Class13(Class858.list_2, enum0_2, struct13_, nullable_0 ?? Class62.int_12));
				Class858.list_2 = new List<Class14>();
				return;
			}
		}

		// Token: 0x060031D4 RID: 12756
		// RVA: 0x00146524 File Offset: 0x00144724
		public static void smethod_4(bool bool_4)
		{
			if (Class115.class533_0 != null)
			{
				Class115.class533_0.Text = string.Empty;
			}
			if (bool_4 && (Class115.osuModes_1 == OsuModes.Play || (Class115.osuModes_1 != OsuModes.Menu && Class115.bool_16)))
			{
				Class802.smethod_1(false);
				if (Class858.class861_0 == null)
				{
					Class115.smethod_70(OsuModes.SelectPlay, true);
				}
				else
				{
					Class115.smethod_70(OsuModes.Menu, true);
				}
			}
			if (Class858.class861_0 != null)
			{
				lock (Class858.object_0)
				{
					Class809.smethod_34(Enum3.const_17, null);
					Class723.smethod_5("Stopped spectating " + Class858.class861_0.Name, Color.get_Tomato(), 3000, null);
					Class858.class861_0 = null;
					Class802.bool_16 = false;
				}
				List<Class21> arg_C5_0 = Class111.list_1;
				if (Class858.predicate_0 == null)
				{
					Class858.predicate_0 = new Predicate<Class21>(Class858.smethod_10);
				}
				if (arg_C5_0.Exists(Class858.predicate_0))
				{
					List<Class21> arg_EE_0 = Class111.list_1;
					if (Class858.predicate_1 == null)
					{
						Class858.predicate_1 = new Predicate<Class21>(Class858.smethod_11);
					}
					Class111.smethod_11(arg_EE_0.Find(Class858.predicate_1), false, true);
				}
			}
			Class858.list_1.Clear();
			Class858.queue_0.Clear();
			Class115.smethod_78();
			Class802.int_2 = 0;
		}

		// Token: 0x060031D5 RID: 12757
		// RVA: 0x0014665C File Offset: 0x0014485C
		public static bool smethod_5(Class861 class861_1)
		{
			if (class861_1 == null)
			{
				return false;
			}
			if (Class70.enum59_0 != Enum59.const_0)
			{
				Class723.smethod_5("Can't spectate while in multiplayer mode!", Color.get_Tomato(), 3000, null);
				return false;
			}
			bool flag = class861_1 != Class858.class861_0;
			if (class861_1.int_1 == Class115.class861_0.int_1)
			{
				Class858.smethod_4(Class858.class861_0 != null);
				return false;
			}
			lock (Class858.object_0)
			{
				Class858.bool_2 = true;
				if (Class115.osuModes_1 == OsuModes.Edit || Class115.osuModes_1 == OsuModes.Play)
				{
					Class115.smethod_70(OsuModes.Menu, true);
				}
				Class858.class861_0 = class861_1;
				Class802.smethod_1(false);
				Class858.bool_0 = false;
				if (flag)
				{
					Class858.list_1.Clear();
					class861_1.method_18(true, false);
					Class723.smethod_5("Started spectating " + class861_1.Name, Color.get_Green(), 3000, null);
					Class115.smethod_78();
				}
				Class809.smethod_34(Enum3.const_16, new Struct12(class861_1.int_1));
			}
			return true;
		}

		// Token: 0x060031D6 RID: 12758
		// RVA: 0x00146764 File Offset: 0x00144964
		public static void smethod_6(bool bool_4)
		{
			lock (Class858.object_0)
			{
				if (Class858.class861_0 != null)
				{
					Class296 class = Class466.smethod_25(Class858.class861_0.string_2);
					if (!Class115.bool_16 || Class858.enum0_1 != Enum0.const_7)
					{
						if (class != null)
						{
							Class723.smethod_5("Host is playing:" + class.string_6, Color.get_Green(), 1000, null);
							Class466.smethod_21(class);
							Class802.smethod_1(true);
							Class802.bool_17 = false;
							Class802.bool_16 = true;
							Class802.class512_0 = Class721.Create(Class858.class861_0.playModes_0, Class466.Current);
							Class802.class512_0.bool_0 = false;
							Class802.class512_0.class623_0 = Class858.class861_0.mods_0;
							if (bool_4)
							{
								Class802.int_2 = 0;
							}
							if (Class858.bool_2)
							{
								Class47 arg_EA_0 = Class115.class47_0;
								if (Class858.voidDelegate_1 == null)
								{
									Class858.voidDelegate_1 = new VoidDelegate(Class858.smethod_12);
								}
								arg_EA_0.Add(Class858.voidDelegate_1, false);
								Class858.bool_2 = false;
							}
							Class115.smethod_70(OsuModes.Play, true);
						}
						else if (!string.IsNullOrEmpty(Class858.class861_0.string_1))
						{
							if (Class858.class861_0.int_0 > 0 && (Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
							{
								List<Class854> arg_153_0 = Class112.list_0;
								if (Class858.predicate_2 == null)
								{
									Class858.predicate_2 = new Predicate<Class854>(Class858.smethod_13);
								}
								if (arg_153_0.Find(Class858.predicate_2) == null && (Class112.class690_0 == null || Class112.class690_0.int_5 != Class858.class861_0.int_0))
								{
									Class112.smethod_4(LinkId.Beatmap, Class858.class861_0.int_0, new EventHandler(Class858.smethod_7));
								}
							}
							else
							{
								string string_ = string.Format("You don't have the beatmap the host is playing ({0}).", Class858.class861_0.string_1);
								Class723.smethod_4(string_);
							}
							Class809.smethod_34(Enum3.const_21, null);
							Class858.bool_0 = true;
							Class802.smethod_1(false);
							if (Class115.osuModes_1 == OsuModes.Play)
							{
								Class115.smethod_70(OsuModes.Menu, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x060031D7 RID: 12759
		// RVA: 0x0014696C File Offset: 0x00144B6C
		private static void smethod_7(object sender, EventArgs e)
		{
			Class858.Class859 class = new Class858.Class859();
			class.class861_0 = Class858.class861_0;
			if (class.class861_0 == null)
			{
				return;
			}
			Class77.smethod_8(false);
			Class115.class47_0.Add(new VoidDelegate(class.method_0), true);
		}

		// Token: 0x060031D8 RID: 12760
		// RVA: 0x001469B0 File Offset: 0x00144BB0
		private static void smethod_8(Class861 class861_1)
		{
			Class858.Class860 class = new Class858.Class860();
			class.class861_0 = class861_1;
			if (Class115.osuModes_1 != OsuModes.BeatmapImport)
			{
				Class858.smethod_5(class.class861_0);
				return;
			}
			Class115.class47_0.method_1(new VoidDelegate(class.method_0), 100, false);
		}

		// Token: 0x060031DB RID: 12763
		// RVA: 0x00024C64 File Offset: 0x00022E64
		[CompilerGenerated]
		private static void smethod_9()
		{
			if (Class858.bool_3 && Class115.osuModes_1 == OsuModes.Play && Class62.bool_11)
			{
				Class115.smethod_70(OsuModes.Menu, false);
			}
			Class858.bool_3 = false;
		}
	}
}
