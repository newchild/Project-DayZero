using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns19;
using ns25;
using ns26;
using ns29;
using ns3;
using ns30;
using ns31;
using ns40;
using ns64;
using ns7;
using ns8;
using ns80;
using ns90;
using osu;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns24
{
	// Token: 0x020003FF RID: 1023
	internal static class Class466
	{
		// Token: 0x02000401 RID: 1025
		[CompilerGenerated]
		private sealed class Class467
		{
			// Token: 0x040019FB RID: 6651
			public long long_0;

			// Token: 0x0600210A RID: 8458
			// RVA: 0x000BFFA0 File Offset: 0x000BE1A0
			public bool method_0(Class296 class296_0)
			{
				return class296_0.bool_4 && this.long_0 - class296_0.long_0 > 864000000000L && (class296_0.int_5 == 0 || class296_0.method_41() == Rankings.N || class296_0.submissionStatus_0 == SubmissionStatus.Unknown);
			}
		}

		// Token: 0x02000402 RID: 1026
		[CompilerGenerated]
		private sealed class Class468
		{
			// Token: 0x040019FD RID: 6653
			private static Comparison<Class296> comparison_0;

			// Token: 0x040019FC RID: 6652
			public List<Class296> list_0;

			// Token: 0x040019FE RID: 6654
			private static Predicate<Class296> predicate_0;

			// Token: 0x0600210C RID: 8460
			// RVA: 0x000BFFEC File Offset: 0x000BE1EC
			public void method_0()
			{
				if (Class466.list_0 == null && Class466.list_1 == null && this.list_0 != null)
				{
					List<Class296> list = new List<Class296>(this.list_0);
					List<Class296> arg_40_0 = list;
					if (Class466.Class468.comparison_0 == null)
					{
						Class466.Class468.comparison_0 = new Comparison<Class296>(Class466.Class468.smethod_0);
					}
					arg_40_0.Sort(Class466.Class468.comparison_0);
					List<Class296> arg_63_0 = list;
					if (Class466.Class468.predicate_0 == null)
					{
						Class466.Class468.predicate_0 = new Predicate<Class296>(Class466.Class468.smethod_1);
					}
					arg_63_0.RemoveAll(Class466.Class468.predicate_0);
					Class466.list_0 = list;
					Class466.smethod_5();
					return;
				}
			}

			// Token: 0x0600210D RID: 8461
			// RVA: 0x0001ACFD File Offset: 0x00018EFD
			private static int smethod_0(Class296 class296_0, Class296 class296_1)
			{
				return class296_0.string_9.CompareTo(class296_1.string_9);
			}

			// Token: 0x0600210E RID: 8462
			// RVA: 0x0001AD10 File Offset: 0x00018F10
			private static bool smethod_1(Class296 class296_0)
			{
				return class296_0.string_3 == null;
			}
		}

		// Token: 0x02000403 RID: 1027
		[CompilerGenerated]
		private sealed class Class469
		{
			// Token: 0x040019FF RID: 6655
			public int int_0;

			// Token: 0x06002110 RID: 8464
			// RVA: 0x0001AD1B File Offset: 0x00018F1B
			public bool method_0(Class296 class296_0)
			{
				return class296_0.int_3 == this.int_0;
			}
		}

		// Token: 0x02000404 RID: 1028
		[CompilerGenerated]
		private sealed class Class470
		{
			// Token: 0x04001A00 RID: 6656
			public string string_0;

			// Token: 0x06002112 RID: 8466
			// RVA: 0x0001AD2B File Offset: 0x00018F2B
			public bool method_0(Class296 class296_0)
			{
				return class296_0.method_3() == this.string_0;
			}
		}

		// Token: 0x02000405 RID: 1029
		[CompilerGenerated]
		private sealed class Class471
		{
			// Token: 0x04001A01 RID: 6657
			public string[] string_0;
		}

		// Token: 0x02000406 RID: 1030
		[CompilerGenerated]
		private sealed class Class472
		{
			// Token: 0x04001A02 RID: 6658
			public Class466.Class471 class471_0;

			// Token: 0x04001A03 RID: 6659
			public int int_0;

			// Token: 0x06002115 RID: 8469
			// RVA: 0x0001AD3E File Offset: 0x00018F3E
			public bool method_0(Class475 class475_0)
			{
				return class475_0.string_0 == this.class471_0.string_0[this.int_0];
			}
		}

		// Token: 0x02000407 RID: 1031
		[CompilerGenerated]
		private sealed class Class473
		{
			// Token: 0x04001A04 RID: 6660
			public int int_0;

			// Token: 0x06002117 RID: 8471
			// RVA: 0x0001AD5D File Offset: 0x00018F5D
			public bool method_0(Class296 class296_0)
			{
				return class296_0.int_3 == this.int_0;
			}
		}

		// Token: 0x02000408 RID: 1032
		[CompilerGenerated]
		private sealed class Class474
		{
			// Token: 0x04001A05 RID: 6661
			public Class296 class296_0;

			// Token: 0x06002119 RID: 8473
			// RVA: 0x0001AD6D File Offset: 0x00018F6D
			public bool method_0(Class296 class296_1)
			{
				return class296_1.method_3() == this.class296_0.method_3();
			}
		}

		// Token: 0x02000400 RID: 1024
		// Token: 0x06002106 RID: 8454
		internal delegate void Delegate33(object object_0, List<Class296> list_0);

		// Token: 0x040019F1 RID: 6641
		private static Action<string> action_0;

		// Token: 0x040019F4 RID: 6644
		[CompilerGenerated]
		private static Action<Class296> action_1;

		// Token: 0x040019F5 RID: 6645
		[CompilerGenerated]
		private static Action<Class296> action_2;

		// Token: 0x040019F7 RID: 6647
		[CompilerGenerated]
		private static Action<Class296> action_3;

		// Token: 0x040019F8 RID: 6648
		[CompilerGenerated]
		private static Action<Class296> action_4;

		// Token: 0x040019DC RID: 6620
		private static bool bool_0;

		// Token: 0x040019DD RID: 6621
		internal static bool bool_1;

		// Token: 0x040019E0 RID: 6624
		private static bool bool_2;

		// Token: 0x040019EA RID: 6634
		private static bool bool_3;

		// Token: 0x040019F2 RID: 6642
		public static bool bool_4 = true;

		// Token: 0x040019EB RID: 6635
		internal static Class296 class296_0;

		// Token: 0x040019F0 RID: 6640
		private static Class296 class296_1;

		// Token: 0x040019E7 RID: 6631
		internal static Class475 class475_0;

		// Token: 0x040019F3 RID: 6643
		[CompilerGenerated]
		private static Class133.Delegate17 delegate17_0;

		// Token: 0x040019E8 RID: 6632
		private static Class466.Delegate33 delegate33_0;

		// Token: 0x040019E2 RID: 6626
		private static Dictionary<string, Class296> dictionary_0;

		// Token: 0x040019E3 RID: 6627
		private static Dictionary<int, Class296> dictionary_1;

		// Token: 0x040019DE RID: 6622
		private static EventHandler eventHandler_0;

		// Token: 0x040019ED RID: 6637
		internal static FileSystemWatcher fileSystemWatcher_0;

		// Token: 0x040019E6 RID: 6630
		internal static int int_0;

		// Token: 0x040019E9 RID: 6633
		public static int int_1;

		// Token: 0x040019EE RID: 6638
		internal static int int_2;

		// Token: 0x040019EF RID: 6639
		internal static int int_3;

		// Token: 0x040019D9 RID: 6617
		internal static List<Class296> list_0;

		// Token: 0x040019DA RID: 6618
		internal static List<Class296> list_1;

		// Token: 0x040019DB RID: 6619
		private static List<Class296> list_2 = new List<Class296>();

		// Token: 0x040019E1 RID: 6625
		internal static List<Class296> list_3;

		// Token: 0x040019E4 RID: 6628
		internal static List<string> list_4 = new List<string>();

		// Token: 0x040019E5 RID: 6629
		internal static List<string> list_5 = new List<string>();

		// Token: 0x040019F6 RID: 6646
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x040019F9 RID: 6649
		[CompilerGenerated]
		private static Predicate<Class296> predicate_1;

		// Token: 0x040019FA RID: 6650
		[CompilerGenerated]
		private static Predicate<Class296> predicate_2;

		// Token: 0x040019EC RID: 6636
		internal static string string_0 = "osu!.db";

		// Token: 0x040019DF RID: 6623
		private static VoidDelegate voidDelegate_0;

		// Token: 0x1700036C RID: 876
		internal static Class296 Current
		{
			// Token: 0x060020E6 RID: 8422
			// RVA: 0x0001AC0B File Offset: 0x00018E0B
			get
			{
				return Class466.class296_1;
			}
		}

		// Token: 0x060020F3 RID: 8435
		// RVA: 0x000BFB80 File Offset: 0x000BDD80
		internal static int Add(Class296 class296_2)
		{
			int num = Class466.list_3.BinarySearch(class296_2);
			if (num >= 0)
			{
				if (Class466.list_3[num].bool_10 == class296_2.bool_10)
				{
					return num;
				}
				Class466.list_3.Insert(num, class296_2);
			}
			else
			{
				Class466.list_3.Insert(~num, class296_2);
			}
			if (class296_2.string_3 != null)
			{
				Class466.dictionary_0[class296_2.string_3] = class296_2;
			}
			if (class296_2.int_2 > 0)
			{
				Class466.dictionary_1[class296_2.int_2] = class296_2;
			}
			return -1;
		}

		// Token: 0x060020DA RID: 8410
		// RVA: 0x000BE7EC File Offset: 0x000BC9EC
		internal static bool Initialize(bool bool_5)
		{
			if (Class466.list_3 != null && Class466.list_3.Count != 0 && !bool_5)
			{
				return false;
			}
			Class466.dictionary_0 = new Dictionary<string, Class296>();
			Class466.dictionary_1 = new Dictionary<int, Class296>();
			Class466.bool_3 = false;
			Class466.class475_0 = new Class475(Class115.class605_0, null);
			if (Class466.smethod_30())
			{
				Class466.smethod_31();
			}
			else
			{
				Class466.list_3 = new List<Class296>();
				Class466.int_0 = 20150414;
			}
			Class466.smethod_10();
			return true;
		}

		// Token: 0x060020FB RID: 8443
		// RVA: 0x0001AC5A File Offset: 0x00018E5A
		internal static void Load(Class296 class296_2)
		{
			if (class296_2 == null)
			{
				return;
			}
			Class466.smethod_21(class296_2);
			Class331.smethod_84(Class466.Current, false, false, true, false);
			Class331.smethod_87();
		}

		// Token: 0x060020EF RID: 8431
		// RVA: 0x000BF784 File Offset: 0x000BD984
		internal static bool Remove(Class296 class296_2)
		{
			if (!Class466.list_3.Remove(class296_2))
			{
				return false;
			}
			if (class296_2.string_3 != null)
			{
				Class466.dictionary_0.Remove(class296_2.string_3);
			}
			if (class296_2.int_2 > 0)
			{
				Class466.dictionary_1.Remove(class296_2.int_2);
			}
			return true;
		}

		// Token: 0x060020D0 RID: 8400
		// RVA: 0x000BE2F8 File Offset: 0x000BC4F8
		internal static void smethod_0(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = Class466.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class466.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060020D1 RID: 8401
		// RVA: 0x000BE32C File Offset: 0x000BC52C
		internal static void smethod_1(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = Class466.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class466.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060020DB RID: 8411
		// RVA: 0x000BE868 File Offset: 0x000BCA68
		private static void smethod_10()
		{
			if (Class466.fileSystemWatcher_0 == null)
			{
				Class466.fileSystemWatcher_0 = new FileSystemWatcher(Class466.smethod_17());
				Class466.fileSystemWatcher_0.IncludeSubdirectories = true;
				Class466.fileSystemWatcher_0.Created += new FileSystemEventHandler(Class466.smethod_13);
				Class466.fileSystemWatcher_0.Deleted += new FileSystemEventHandler(Class466.smethod_13);
				Class466.fileSystemWatcher_0.Renamed += new RenamedEventHandler(Class466.smethod_13);
			}
			Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
		}

		// Token: 0x060020DC RID: 8412
		// RVA: 0x000BE8E4 File Offset: 0x000BCAE4
		internal static void smethod_11(bool bool_5, bool bool_6)
		{
			bool flag;
			if (flag = (Class466.list_4.Count > 0 || Class466.list_5.Count > 0))
			{
				Class466.smethod_36(Class41.GetString(OsuString.BeatmapManager_LoadingNewFilesOnly));
				Class466.smethod_12(true, false);
				if (Class466.bool_0)
				{
					Class466.smethod_4(Class466.list_2);
				}
			}
			if ((!flag && bool_5) || Class466.list_3.Count == 0)
			{
				Class466.smethod_36(Class41.GetString(OsuString.BeatmapManager_ReloadingDatabase));
				Class466.smethod_12(false, !bool_6);
			}
			if (!Class466.bool_0)
			{
				Class466.smethod_3();
				Class466.bool_0 = true;
			}
			Class466.list_4.Clear();
			Class466.list_5.Clear();
			Class466.list_2.Clear();
		}

		// Token: 0x060020DD RID: 8413
		// RVA: 0x000BE994 File Offset: 0x000BCB94
		internal static void smethod_12(bool bool_5, bool bool_6)
		{
			Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
			Class466.bool_2 = bool_6;
			if (!bool_5)
			{
				List<Class296> arg_39_0 = Class466.list_3;
				if (Class466.action_2 == null)
				{
					Class466.action_2 = new Action<Class296>(Class466.smethod_41);
				}
				arg_39_0.ForEach(Class466.action_2);
				Class466.class475_0.list_1.Clear();
				Class466.class475_0.list_0.Clear();
				Class466.int_3 = 0;
				Class466.int_2 = 0;
				Class466.smethod_14(Class466.smethod_17());
				List<Class296> arg_94_0 = Class466.list_3;
				if (Class466.predicate_0 == null)
				{
					Class466.predicate_0 = new Predicate<Class296>(Class466.smethod_42);
				}
				int num = arg_94_0.RemoveAll(Class466.predicate_0);
				if (num > 0)
				{
					Class466.smethod_36(string.Format(Class41.GetString(OsuString.BeatmapManager_RemoveMissingMaps), num));
				}
				Class466.smethod_28();
				Class466.smethod_36(string.Format(Class41.GetString(OsuString.BeatmapManager_LoadedMaps), Class466.list_3.Count));
			}
			else
			{
				for (int i = 0; i < Class466.list_5.Count; i++)
				{
					Predicate<Class296> predicate = null;
					Class466.Class470 class = new Class466.Class470();
					class.string_0 = Class466.list_5[i];
					if (!File.Exists(class.string_0))
					{
						List<Class296> arg_130_0 = Class466.list_3;
						if (predicate == null)
						{
							predicate = new Predicate<Class296>(class.method_0);
						}
						List<Class296> list = arg_130_0.FindAll(predicate);
						List<Class296> arg_154_0 = list;
						if (Class466.action_3 == null)
						{
							Class466.action_3 = new Action<Class296>(Class466.smethod_43);
						}
						arg_154_0.ForEach(Class466.action_3);
					}
					else
					{
						Class475 class2 = Class466.smethod_26(Path.GetDirectoryName(class.string_0), false);
						if (class2 != null)
						{
							Class466.smethod_16(class.string_0, class2);
						}
					}
				}
				for (int j = 0; j < Class466.list_4.Count; j++)
				{
					string text = Class466.list_4[j];
					bool flag = Directory.Exists(text);
					if (!text.StartsWith(Class115.class605_0))
					{
						Class466.smethod_12(false, false);
						return;
					}
					Class475 class3 = Class466.smethod_26(text, false);
					if (class3 != null && (class3.list_1.Count <= 0 || !flag))
					{
						Class466.smethod_27(class3);
						if (flag)
						{
							Class466.smethod_15(class3);
						}
						else if (class3.class475_0 != null)
						{
							class3.class475_0.list_1.Remove(class3);
						}
					}
				}
			}
			if (Class466.Current != null && bool_5)
			{
				Class466.smethod_23(Class466.Current.string_9);
			}
			Class466.bool_3 = true;
			Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
		}

		// Token: 0x060020DE RID: 8414
		// RVA: 0x000BEC08 File Offset: 0x000BCE08
		private static void smethod_13(object sender, FileSystemEventArgs e)
		{
			string directoryName = Path.GetDirectoryName(e.FullPath);
			if (directoryName.Contains("_tmp"))
			{
				return;
			}
			if (e.FullPath.EndsWith(".osz") && directoryName == Class115.class605_0 && e.ChangeType == WatcherChangeTypes.Created)
			{
				if (!Class77.smethod_0())
				{
					Class77.smethod_1(true);
					OsuModes osuModes_ = Class115.osuModes_1;
					switch (osuModes_)
					{
					case OsuModes.SelectEdit:
					case OsuModes.SelectPlay:
						break;
					default:
						switch (osuModes_)
						{
						case OsuModes.MatchSetup:
						case OsuModes.SelectMulti:
							break;
						default:
							return;
						}
						break;
					}
					Class723.smethod_1(Class41.GetString(OsuString.BeatmapManager_NewBeatmapDetected), 2000);
				}
				return;
			}
			if (e.FullPath.EndsWith(".osz2") && !Class466.list_5.Contains(e.FullPath))
			{
				if (!Class77.smethod_0())
				{
					Class77.smethod_1(true);
					OsuModes osuModes_2 = Class115.osuModes_1;
					switch (osuModes_2)
					{
					case OsuModes.SelectEdit:
					case OsuModes.SelectPlay:
						break;
					default:
						switch (osuModes_2)
						{
						case OsuModes.MatchSetup:
						case OsuModes.SelectMulti:
							break;
						default:
							goto IL_106;
						}
						break;
					}
					if (Class466.bool_4)
					{
						Class723.smethod_1(Class41.GetString(OsuString.BeatmapManager_NewBeatmapDetected), 2000);
					}
				}
				IL_106:
				Class466.list_5.Add(e.FullPath);
				return;
			}
			if (!Class466.list_4.Contains(directoryName))
			{
				Class77.smethod_1(true);
				OsuModes osuModes_3 = Class115.osuModes_1;
				switch (osuModes_3)
				{
				case OsuModes.SelectEdit:
				case OsuModes.SelectPlay:
					break;
				default:
					switch (osuModes_3)
					{
					case OsuModes.MatchSetup:
					case OsuModes.SelectMulti:
						break;
					default:
						goto IL_16E;
					}
					break;
				}
				if (Class466.bool_4)
				{
					Class723.smethod_1(Class41.GetString(OsuString.BeatmapManager_SongsFolderChanged), 2000);
				}
				IL_16E:
				Class466.list_4.Add(directoryName);
			}
		}

		// Token: 0x060020DF RID: 8415
		// RVA: 0x0001ABC7 File Offset: 0x00018DC7
		internal static void smethod_14(string string_1)
		{
			Class466.smethod_15(Class466.smethod_26(string_1, false));
		}

		// Token: 0x060020E0 RID: 8416
		// RVA: 0x000BED90 File Offset: 0x000BCF90
		internal static void smethod_15(Class475 class475_1)
		{
			if (class475_1 == null)
			{
				return;
			}
			if (Class115.bool_16 && !Class115.bool_17)
			{
				return;
			}
			int num = 0;
			string string_ = class475_1.string_1;
			if (class475_1 != Class466.class475_0)
			{
				Class466.smethod_36(string_.Replace(Class466.smethod_17(), string.Empty));
			}
			try
			{
				bool flag;
				if (!(flag = (string_ == Class115.class605_0.Value)) && Class466.bool_3 && (Class466.Current == null || Class466.Current.method_3() != string_))
				{
					string b = string_.Replace(Class466.smethod_17(), string.Empty);
					bool flag2 = false;
					foreach (Class296 current in Class466.list_3)
					{
						if (!(current.string_4 != b))
						{
							num++;
							if (!current.bool_10)
							{
								current.bool_6 = false;
								current.method_4(string_);
								class475_1.list_0.Add(current);
								flag2 = true;
							}
						}
					}
					if (flag2)
					{
						Class466.int_3++;
						return;
					}
				}
				string[] files = Directory.GetFiles(string_, "*.osz2");
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (text == "LastUpload.osz2")
					{
						break;
					}
					if (Class466.smethod_16(text, class475_1))
					{
						Class466.int_3++;
					}
				}
				string[] files2 = Directory.GetFiles(string_, "*.osu");
				int j = 0;
				while (j < files2.Length)
				{
					string path = files2[j];
					num++;
					Class296 class = new Class296
					{
						string_9 = Path.GetFileName(path)
					};
					if (!Class466.bool_3)
					{
						goto IL_1E8;
					}
					int num2 = Class466.list_3.BinarySearch(class);
					if (num2 < 0)
					{
						goto IL_1E8;
					}
					Class296 class2 = Class466.list_3[num2];
					if (class2.bool_10)
					{
						goto IL_1E8;
					}
					class2.bool_6 = false;
					class2.bool_4 = true;
					class2.method_4(string_);
					class475_1.list_0.Add(class2);
					IL_23F:
					j++;
					continue;
					IL_1E8:
					class.method_4(string_);
					try
					{
						class.method_11();
					}
					catch (UnauthorizedAccessException)
					{
						goto IL_23F;
					}
					if (class.method_0() || class.bool_4)
					{
						Class466.list_2.Add(class);
						class.bool_13 = true;
						Class466.Add(class);
						Class466.class296_0 = class;
						class475_1.list_0.Add(class);
						goto IL_23F;
					}
					goto IL_23F;
				}
				if (num == 0 && (class475_1 == Class466.class475_0 || class475_1.class475_0 == Class466.class475_0))
				{
					string text2 = null;
					string[] files3 = Directory.GetFiles(string_, "*.mp3", SearchOption.TopDirectoryOnly);
					if (files3.Length > 0)
					{
						text2 = files3[0];
					}
					if (text2 != null)
					{
						string text3 = Class34.smethod_19(text2);
						if (text3 != text2)
						{
							if (text3.Length < 4)
							{
								text3 = "music.mp3";
							}
							if (Class34.smethod_14(text2, text3, true, true))
							{
								text2 = text3;
							}
						}
						Class296 class3 = new Class296();
						class3.string_1 = Path.GetFileName(text2);
						class3.string_9 = Path.GetFileNameWithoutExtension(text2) + ".osu";
						class3.string_6 = Path.GetFileName(text2);
						class3.string_8 = Path.GetFileName(text2);
						class3.string_12 = Path.GetFileName(text2);
						class3.method_1(true);
						class3.bool_4 = false;
						class3.method_4(string_);
						Class296 class4 = class3;
						int num3 = Class466.Add(class4);
						if (num3 >= 0)
						{
							Class466.list_3[num3].bool_6 = false;
						}
						class475_1.list_0.Add(class4);
						Class466.class296_0 = class4;
						Class466.int_2++;
					}
				}
				if (num > 0)
				{
					Class466.int_3++;
				}
				if (flag || num == 0)
				{
					string[] directories = Directory.GetDirectories(string_);
					for (int k = 0; k < directories.Length; k++)
					{
						string string_2 = directories[k];
						Class466.smethod_14(string_2);
					}
				}
			}
			catch (Exception ex)
			{
				Class792.smethod_0("Error while processing " + string_ + "\n" + ex.ToString());
			}
		}

		// Token: 0x060020E1 RID: 8417
		// RVA: 0x000BF1C8 File Offset: 0x000BD3C8
		private static bool smethod_16(string string_1, Class475 class475_1)
		{
			Class178 class = Class134.smethod_0(string_1);
			if (class == null)
			{
				Class723.smethod_5("Error reading " + Path.GetFileName(string_1), Color.get_Red(), 4000, null);
				return false;
			}
			int num = 0;
			string[] array = class.method_16();
			int i = 0;
			while (i < array.Length)
			{
				string text = array[i];
				Class296 class2 = new Class296
				{
					string_9 = text
				};
				if (!Class466.bool_3)
				{
					goto IL_BC;
				}
				int num2 = Class466.list_3.BinarySearch(class2);
				if (num2 < 0)
				{
					goto IL_BC;
				}
				Class296 class3 = Class466.list_3[num2];
				if (!class3.bool_10)
				{
					goto IL_BC;
				}
				class3.bool_6 = false;
				class3.bool_4 = true;
				class3.method_4(string_1);
				class3.bool_10 = true;
				class475_1.list_0.Add(class3);
				num++;
				IL_146:
				i++;
				continue;
				IL_BC:
				class2.int_3 = Convert.ToInt32(class.method_20(Enum9.const_9));
				class2.int_2 = class.method_17(text);
				class2.method_4(string_1);
				class2.bool_10 = true;
				class2.method_1(true);
				class2.bool_4 = true;
				class2.method_11();
				if (!class2.bool_8)
				{
					goto IL_146;
				}
				class2.bool_13 = true;
				Class466.list_2.Add(class2);
				if (class2.method_0() || class2.bool_4)
				{
					Class466.Add(class2);
					Class466.class296_0 = class2;
					class475_1.list_0.Add(class2);
					num++;
					goto IL_146;
				}
				goto IL_146;
			}
			Class134.smethod_2(class);
			return num > 0;
		}

		// Token: 0x060020E2 RID: 8418
		// RVA: 0x0001ABD5 File Offset: 0x00018DD5
		internal static string smethod_17()
		{
			return Class115.class605_0 + Path.DirectorySeparatorChar;
		}

		// Token: 0x060020E3 RID: 8419
		// RVA: 0x0001ABF0 File Offset: 0x00018DF0
		internal static string smethod_18()
		{
			return Class466.smethod_17() + "Failed" + Path.DirectorySeparatorChar;
		}

		// Token: 0x060020E4 RID: 8420
		// RVA: 0x000BF338 File Offset: 0x000BD538
		internal static void smethod_19(Class466.Delegate33 delegate33_1)
		{
			Class466.Delegate33 delegate = Class466.delegate33_0;
			Class466.Delegate33 delegate2;
			do
			{
				delegate2 = delegate;
				Class466.Delegate33 value = (Class466.Delegate33)Delegate.Combine(delegate2, delegate33_1);
				delegate = Interlocked.CompareExchange<Class466.Delegate33>(ref Class466.delegate33_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060020D2 RID: 8402
		// RVA: 0x000BE360 File Offset: 0x000BC560
		internal static void smethod_2(Class296 class296_2)
		{
			Class466.smethod_4(new List<Class296>
			{
				class296_2
			});
		}

		// Token: 0x060020E5 RID: 8421
		// RVA: 0x000BF36C File Offset: 0x000BD56C
		internal static void smethod_20(Class466.Delegate33 delegate33_1)
		{
			Class466.Delegate33 delegate = Class466.delegate33_0;
			Class466.Delegate33 delegate2;
			do
			{
				delegate2 = delegate;
				Class466.Delegate33 value = (Class466.Delegate33)Delegate.Remove(delegate2, delegate33_1);
				delegate = Interlocked.CompareExchange<Class466.Delegate33>(ref Class466.delegate33_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060020E7 RID: 8423
		// RVA: 0x0001AC12 File Offset: 0x00018E12
		internal static void smethod_21(Class296 class296_2)
		{
			if (Class466.class296_1 == class296_2)
			{
				return;
			}
			if (Class466.class296_1 != null)
			{
				Class466.class296_1.Cleanup();
				Class885.smethod_13(true);
			}
			Class466.class296_1 = class296_2;
		}

		// Token: 0x060020E8 RID: 8424
		// RVA: 0x000BF3A0 File Offset: 0x000BD5A0
		internal static double smethod_22(double double_0, double double_1, double double_2, double double_3)
		{
			if (double_0 > 5.0)
			{
				return double_2 + (double_3 - double_2) * (double_0 - 5.0) / 5.0;
			}
			if (double_0 < 5.0)
			{
				return double_2 - (double_2 - double_1) * (5.0 - double_0) / 5.0;
			}
			return double_2;
		}

		// Token: 0x060020E9 RID: 8425
		// RVA: 0x0001AC3A File Offset: 0x00018E3A
		internal static bool smethod_23(string string_1)
		{
			Class466.smethod_21(Class466.smethod_24(string_1));
			return Class466.Current != null;
		}

		// Token: 0x060020EA RID: 8426
		// RVA: 0x000BF400 File Offset: 0x000BD600
		internal static Class296 smethod_24(string string_1)
		{
			Class296 item = new Class296
			{
				string_9 = string_1
			};
			int num = Class466.list_3.BinarySearch(item);
			if (num >= 0)
			{
				return Class466.list_3[num];
			}
			return null;
		}

		// Token: 0x060020EB RID: 8427
		// RVA: 0x000BF43C File Offset: 0x000BD63C
		internal static Class296 smethod_25(string string_1)
		{
			if (string_1 == null)
			{
				return null;
			}
			Class296 result;
			if (!Class466.dictionary_0.TryGetValue(string_1, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060020EC RID: 8428
		// RVA: 0x000BF460 File Offset: 0x000BD660
		internal static Class475 smethod_26(string string_1, bool bool_5)
		{
			Class466.Class471 class = new Class466.Class471();
			if (string_1.EndsWith(".osz") && File.Exists(string_1))
			{
				string_1 = Path.GetDirectoryName(string_1);
			}
			if (string_1.StartsWith(Class115.class605_0))
			{
				string_1 = string_1.Substring(Class115.class605_0.Value.Length);
			}
			string_1 = Class34.smethod_15(string_1).TrimStart(new char[]
			{
				Path.DirectorySeparatorChar
			});
			Class475 class2 = Class466.class475_0;
			if (string_1.Length == 0)
			{
				return class2;
			}
			class.string_0 = string_1.Split(new char[]
			{
				Path.DirectorySeparatorChar
			});
			if (bool_5 && class.string_0.Length < 2)
			{
				Class475 class3 = new Class475(Path.Combine(Class466.smethod_17(), string_1), class2);
				class2.list_1.Add(class3);
				return class3;
			}
			string a;
			if ((a = class.string_0[class.string_0.Length - 1]) != null && (a == "Failed" || a == "SubmissionCache"))
			{
				return null;
			}
			string text = Class115.class605_0;
			Predicate<Class475> predicate = null;
			Class466.Class472 class4 = new Class466.Class472();
			class4.class471_0 = class;
			class4.int_0 = 0;
			while (class4.int_0 < class.string_0.Length)
			{
				List<Class475> arg_145_0 = class2.list_1;
				if (predicate == null)
				{
					predicate = new Predicate<Class475>(class4.method_0);
				}
				Class475 class5 = arg_145_0.Find(predicate);
				text = Path.Combine(text, class.string_0[class4.int_0]);
				if (class5 == null)
				{
					class2.list_1.Add(class5 = new Class475(text, class2));
				}
				class2 = class5;
				class4.int_0++;
			}
			return class2;
		}

		// Token: 0x060020ED RID: 8429
		// RVA: 0x000BF60C File Offset: 0x000BD80C
		private static void smethod_27(Class475 class475_1)
		{
			if (class475_1.list_0.Count > 0)
			{
				List<Class296> arg_34_0 = class475_1.list_0;
				if (Class466.action_4 == null)
				{
					Class466.action_4 = new Action<Class296>(Class466.smethod_44);
				}
				arg_34_0.ForEach(Class466.action_4);
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				foreach (Class296 current in class475_1.list_0)
				{
					if (current.method_0())
					{
						dictionary[current.method_3()] = 1;
					}
					else
					{
						Class466.int_2--;
					}
				}
				Class466.int_3 -= dictionary.Count;
			}
			if (class475_1.list_1.Count > 0)
			{
				class475_1.list_1.ForEach(new Action<Class475>(Class466.smethod_27));
			}
		}

		// Token: 0x060020EE RID: 8430
		// RVA: 0x000BF6F4 File Offset: 0x000BD8F4
		internal static void smethod_28()
		{
			Dictionary<string, Class296> dictionary = new Dictionary<string, Class296>();
			Dictionary<int, Class296> dictionary2 = new Dictionary<int, Class296>();
			foreach (Class296 current in Class466.list_3)
			{
				if (current.string_3 != null)
				{
					dictionary[current.string_3] = current;
				}
				if (current.int_2 > 0)
				{
					dictionary2[current.int_2] = current;
				}
			}
			Class466.dictionary_0 = dictionary;
			Class466.dictionary_1 = dictionary2;
		}

		// Token: 0x060020F0 RID: 8432
		// RVA: 0x000BF7D4 File Offset: 0x000BD9D4
		internal static void smethod_29()
		{
			if (Class115.bool_16 && !Class115.bool_17)
			{
				return;
			}
			try
			{
				using (Stream stream = new Stream17(Class466.string_0))
				{
					using (Class31 class = new Class31(stream))
					{
						class.Write(20150414);
						class.Write(Class466.int_1);
						class.Write(Class809.smethod_4());
						class.Write(Class809.dateTime_0);
						class.Write(Class341.class605_20);
						class.Write<Class296>(Class466.list_3);
						class.Write((int)Class809.class623_0.Value);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060020D3 RID: 8403
		// RVA: 0x000BE380 File Offset: 0x000BC580
		internal static void smethod_3()
		{
			Class466.Class467 class = new Class466.Class467();
			class.long_0 = DateTime.Now.Ticks;
			List<Class296> list_ = Class466.list_3.FindAll(new Predicate<Class296>(class.method_0));
			Class466.smethod_4(list_);
		}

		// Token: 0x060020F1 RID: 8433
		// RVA: 0x000BF8A0 File Offset: 0x000BDAA0
		private static bool smethod_30()
		{
			if (!File.Exists(Class466.string_0) && File.Exists("osu!.db"))
			{
				File.Copy("osu!.db", Class466.string_0);
			}
			if (File.Exists(Class466.string_0))
			{
				try
				{
					using (Stream stream = File.Open(Class466.string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (Class32 class = new Class32(stream))
						{
							Class466.int_0 = class.ReadInt32();
							Class466.int_1 = class.ReadInt32();
							Class809.smethod_5(class.ReadBoolean());
							Class809.dateTime_0 = class.method_1().ToLocalTime();
							string text = class.ReadString();
							if (!Class809.smethod_4() && Class341.class605_20 != text)
							{
								Class341.class605_20 = text;
							}
							Class466.list_3 = (List<Class296>)class.method_2<Class296>();
							if (Class466.int_0 >= 20141028 && !Class809.bool_8 && Class115.smethod_33())
							{
								Class809.class623_0 = (Enum30)class.ReadInt32();
							}
							Class466.smethod_28();
						}
					}
				}
				catch (Exception exception_)
				{
					Class765.smethod_0(new Class764(exception_)
					{
						string_0 = "database-corrupt"
					});
					Class792.smethod_0("The local beatmap database seems corrupt.  Will create from scratch (this may take a while...).");
					try
					{
						string text2 = string.Concat(new object[]
						{
							Class466.string_0,
							".",
							DateTime.Now.Ticks,
							".bak"
						});
						if (File.Exists(Class466.string_0) && !File.Exists(text2))
						{
							File.Move(Class466.string_0, text2);
						}
					}
					catch
					{
					}
				}
			}
			return Class466.list_3 != null;
		}

		// Token: 0x060020F2 RID: 8434
		// RVA: 0x000BFA88 File Offset: 0x000BDC88
		private static void smethod_31()
		{
			Class466.bool_3 = true;
			List<Class296> arg_37_0 = Class466.class475_0.list_0;
			List<Class296> arg_32_0 = Class466.list_3;
			if (Class466.predicate_1 == null)
			{
				Class466.predicate_1 = new Predicate<Class296>(Class466.smethod_45);
			}
			arg_37_0.AddRange(arg_32_0.FindAll(Class466.predicate_1));
			Dictionary<string, Class475> dictionary = new Dictionary<string, Class475>();
			foreach (Class296 current in Class466.list_3)
			{
				Class475 class;
				if (!dictionary.TryGetValue(current.method_3(), out class))
				{
					class = Class466.smethod_26(current.method_3(), true);
					dictionary.Add(current.method_3(), class);
				}
				class.list_0.Add(current);
			}
			List<Class296> arg_C9_0 = Class466.list_3;
			if (Class466.predicate_2 == null)
			{
				Class466.predicate_2 = new Predicate<Class296>(Class466.smethod_46);
			}
			Class466.int_2 = arg_C9_0.FindAll(Class466.predicate_2).Count;
		}

		// Token: 0x060020F4 RID: 8436
		// RVA: 0x000BFC08 File Offset: 0x000BDE08
		public static Class296 smethod_32(int int_4)
		{
			if (int_4 <= 0)
			{
				return null;
			}
			Class296 result;
			if (!Class466.dictionary_1.TryGetValue(int_4, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060020F5 RID: 8437
		// RVA: 0x000BFC30 File Offset: 0x000BDE30
		public static Class296 smethod_33(int int_4)
		{
			Class466.Class473 class = new Class466.Class473();
			class.int_0 = int_4;
			if (class.int_0 <= 0)
			{
				return null;
			}
			return Class466.list_3.Find(new Predicate<Class296>(class.method_0));
		}

		// Token: 0x060020F6 RID: 8438
		// RVA: 0x000BFC6C File Offset: 0x000BDE6C
		public static void smethod_34(Class296 class296_2, bool bool_5)
		{
			Class466.Class474 class = new Class466.Class474();
			class.class296_0 = class296_2;
			Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
			Class331.smethod_91();
			if (bool_5)
			{
				if (class.class296_0.bool_4 && !class.class296_0.method_3().EndsWith(Class115.class605_0) && !class.class296_0.bool_10)
				{
					try
					{
						Class624.smethod_1(class.class296_0.method_3());
						Class466.int_1--;
						goto IL_132;
					}
					catch (Exception)
					{
						goto IL_132;
					}
				}
				try
				{
					if (class.class296_0.bool_10)
					{
						Class331.smethod_90();
						Class331.smethod_91();
						Class134.smethod_2(class.class296_0.method_44());
						Class624.smethod_1(class.class296_0.method_3());
						Class466.int_1--;
					}
					else if (!class.class296_0.method_3().EndsWith(Class115.class605_0))
					{
						Class624.smethod_1(class.class296_0.method_3());
						Class466.int_1--;
					}
					else
					{
						class.class296_0.method_65(class.class296_0.string_1);
					}
					goto IL_132;
				}
				catch
				{
					goto IL_132;
				}
			}
			class.class296_0.method_65(Class466.Current.string_9);
			IL_132:
			List<Class296> list = bool_5 ? Class466.list_3.FindAll(new Predicate<Class296>(class.method_0)) : new List<Class296>
			{
				Class466.Current
			};
			foreach (Class296 current in list)
			{
				Class466.Remove(current);
				Class466.class475_0.list_0.Remove(current);
			}
			Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
			if (Class466.delegate33_0 != null && list.Count > 0)
			{
				Class466.delegate33_0(null, list);
			}
		}

		// Token: 0x060020F7 RID: 8439
		// RVA: 0x000BFE6C File Offset: 0x000BE06C
		public static void smethod_35(Action<string> action_5)
		{
			Action<string> action = Class466.action_0;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value = (Action<string>)Delegate.Combine(action2, action_5);
				action = Interlocked.CompareExchange<Action<string>>(ref Class466.action_0, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x060020F8 RID: 8440
		// RVA: 0x000BFEA0 File Offset: 0x000BE0A0
		private static void smethod_36(string string_1)
		{
			Action<string> action = Class466.action_0;
			if (action != null)
			{
				action(string_1);
			}
		}

		// Token: 0x060020F9 RID: 8441
		// RVA: 0x0001AC52 File Offset: 0x00018E52
		internal static void smethod_37()
		{
			Class466.action_0 = null;
		}

		// Token: 0x060020FA RID: 8442
		// RVA: 0x000BFEC0 File Offset: 0x000BE0C0
		internal static bool smethod_38(Action<string> action_5)
		{
			if (action_5 == null)
			{
				return false;
			}
			Action<string> action = Class466.action_0;
			if (action != null)
			{
				Delegate[] invocationList = action.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					Delegate delegate = invocationList[i];
					if (delegate == action_5)
					{
						return false;
					}
				}
			}
			Class466.smethod_35(action_5);
			return true;
		}

		// Token: 0x060020FC RID: 8444
		// RVA: 0x000BFF10 File Offset: 0x000BE110
		[CompilerGenerated]
		private static void smethod_39(string string_1, Exception exception_0)
		{
			string[] array = string_1.Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				Class466.Class469 class = new Class466.Class469();
				if (text.Length != 0)
				{
					class.int_0 = int.Parse(text);
					List<Class296> arg_6B_0 = Class466.list_3.FindAll(new Predicate<Class296>(class.method_0));
					if (Class466.action_1 == null)
					{
						Class466.action_1 = new Action<Class296>(Class466.smethod_40);
					}
					arg_6B_0.ForEach(Class466.action_1);
				}
			}
			Class466.smethod_8();
		}

		// Token: 0x060020D4 RID: 8404
		// RVA: 0x000BE3C4 File Offset: 0x000BC5C4
		internal static void smethod_4(List<Class296> list_6)
		{
			Class466.Class468 class = new Class466.Class468();
			if (list_6 == null)
			{
				return;
			}
			class.list_0 = new List<Class296>(list_6);
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060020FD RID: 8445
		// RVA: 0x0001AC7A File Offset: 0x00018E7A
		[CompilerGenerated]
		private static void smethod_40(Class296 class296_2)
		{
			class296_2.bool_19 = true;
		}

		// Token: 0x060020FE RID: 8446
		// RVA: 0x0001AC83 File Offset: 0x00018E83
		[CompilerGenerated]
		private static void smethod_41(Class296 class296_2)
		{
			class296_2.bool_6 = true;
			class296_2.bool_8 = false;
		}

		// Token: 0x060020FF RID: 8447
		// RVA: 0x0001AC93 File Offset: 0x00018E93
		[CompilerGenerated]
		private static bool smethod_42(Class296 class296_2)
		{
			return class296_2.bool_6;
		}

		// Token: 0x06002100 RID: 8448
		// RVA: 0x0001AC9B File Offset: 0x00018E9B
		[CompilerGenerated]
		private static void smethod_43(Class296 class296_2)
		{
			Class466.Remove(class296_2);
		}

		// Token: 0x06002101 RID: 8449
		// RVA: 0x0001AC9B File Offset: 0x00018E9B
		[CompilerGenerated]
		private static void smethod_44(Class296 class296_2)
		{
			Class466.Remove(class296_2);
		}

		// Token: 0x06002102 RID: 8450
		// RVA: 0x0001ACA4 File Offset: 0x00018EA4
		[CompilerGenerated]
		private static bool smethod_45(Class296 class296_2)
		{
			return class296_2.method_3().LastIndexOf(Path.DirectorySeparatorChar) < Class466.smethod_17().Length;
		}

		// Token: 0x06002103 RID: 8451
		// RVA: 0x0001ACC2 File Offset: 0x00018EC2
		[CompilerGenerated]
		private static bool smethod_46(Class296 class296_2)
		{
			return !class296_2.method_0();
		}

		// Token: 0x060020D5 RID: 8405
		// RVA: 0x000BE400 File Offset: 0x000BC600
		private static void smethod_5()
		{
			if (Class466.list_0 == null)
			{
				return;
			}
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				Class115.class47_0.method_1(new VoidDelegate(Class466.smethod_5), 4000, false);
				return;
			}
			Class15 class = new Class15(80, 80);
			int count = Class466.list_0.Count;
			if (count < 80)
			{
				Class466.list_1 = new List<Class296>(Class466.list_0);
				Class466.list_0 = null;
			}
			else
			{
				Class466.list_1 = new List<Class296>(Class466.list_0.GetRange(count - 80, 80));
				Class466.list_0.RemoveRange(count - 80, 80);
			}
			foreach (Class296 current in Class466.list_1)
			{
				string fileName = Path.GetFileName(current.string_9);
				if (!string.IsNullOrEmpty(fileName))
				{
					class.list_0.Add(fileName);
				}
			}
			Class809.smethod_34(Enum3.const_68, class);
		}

		// Token: 0x060020D6 RID: 8406
		// RVA: 0x000BE500 File Offset: 0x000BC700
		internal static void smethod_6(Class16 class16_0)
		{
			try
			{
				List<Class296> list = Class466.list_1;
				Class466.list_1 = null;
				long ticks = DateTime.Now.Ticks;
				if (list != null)
				{
					foreach (Class296 current in list)
					{
						current.submissionStatus_0 = SubmissionStatus.NotSubmitted;
						if (Class115.class861_0.Name != current.string_5)
						{
							current.int_3 = -1;
						}
						current.long_0 = ticks;
						current.method_58();
					}
					foreach (Class8 current2 in class16_0.list_0)
					{
						Class296 class = (current2.int_0 >= 0) ? list[current2.int_0] : Class466.smethod_32(current2.int_1);
						if (class != null)
						{
							if (current2.string_0 != class.string_3)
							{
								class.bool_18 = true;
							}
							switch (current2.int_4)
							{
							case 1:
								class.submissionStatus_0 = SubmissionStatus.Ranked;
								break;
							case 2:
								class.submissionStatus_0 = SubmissionStatus.Approved;
								break;
							default:
								class.submissionStatus_0 = SubmissionStatus.Pending;
								break;
							}
							class.int_2 = current2.int_1;
							class.int_3 = current2.int_2;
							class.int_5 = current2.int_3;
							class.rankings_1 = current2.rankings_0;
							class.rankings_0 = current2.rankings_2;
							class.rankings_2 = current2.rankings_1;
							class.rankings_3 = current2.rankings_3;
						}
					}
					if (Class466.eventHandler_0 != null)
					{
						Class466.eventHandler_0(null, null);
					}
					Class466.smethod_5();
				}
			}
			catch (Exception exception_)
			{
				Class765.smethod_0(new Class764(exception_)
				{
					string_0 = "beatmap info reply"
				});
			}
		}

		// Token: 0x060020D7 RID: 8407
		// RVA: 0x000BE724 File Offset: 0x000BC924
		public static void smethod_7(VoidDelegate voidDelegate_1)
		{
			VoidDelegate voidDelegate = Class466.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_1);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class466.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060020D8 RID: 8408
		// RVA: 0x000BE758 File Offset: 0x000BC958
		private static void smethod_8()
		{
			VoidDelegate voidDelegate = Class466.voidDelegate_0;
			if (voidDelegate != null)
			{
				voidDelegate();
			}
			Class466.voidDelegate_0 = null;
		}

		// Token: 0x060020D9 RID: 8409
		// RVA: 0x000BE77C File Offset: 0x000BC97C
		public static void smethod_9()
		{
			if (Class466.bool_1)
			{
				return;
			}
			Class466.bool_1 = true;
			Class723.smethod_1("Loading online favourites...", 1000);
			Class133 class = new Class133(string.Format("http://osu.ppy.sh/web/osu-getfavourites.php?u={0}&h={1}", Class341.class605_20, Class341.class605_17));
			Class133 arg_55_0 = class;
			if (Class466.delegate17_0 == null)
			{
				Class466.delegate17_0 = new Class133.Delegate17(Class466.smethod_39);
			}
			arg_55_0.method_0(Class466.delegate17_0);
			Class169.smethod_0(class);
		}
	}
}
