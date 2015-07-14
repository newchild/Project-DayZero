using Microsoft.Xna.Framework.Graphics;
using ns11;
using ns14;
using ns18;
using ns24;
using ns25;
using ns29;
using ns3;
using ns8;
using ns90;
using osu_common;
using osu_common.Helpers;
using SevenZip.Compression.LZMA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns76
{
	// Token: 0x020006B2 RID: 1714
	internal sealed class Class908
	{
		// Token: 0x020006B3 RID: 1715
		[CompilerGenerated]
		private sealed class Class909
		{
			// Token: 0x040031A8 RID: 12712
			public PlayModes playModes_0;

			// Token: 0x0600356C RID: 13676
			// RVA: 0x000270E1 File Offset: 0x000252E1
			public bool method_0(Class512 class512_0)
			{
				return class512_0.playModes_0 == this.playModes_0;
			}
		}

		// Token: 0x020006B4 RID: 1716
		[CompilerGenerated]
		private sealed class Class910
		{
			// Token: 0x040031A9 RID: 12713
			public string string_0;

			// Token: 0x0600356E RID: 13678
			// RVA: 0x000270F1 File Offset: 0x000252F1
			public bool method_0(Class512 class512_0)
			{
				return class512_0.method_1() == this.string_0;
			}
		}

		// Token: 0x040031A5 RID: 12709
		private static bool bool_0;

		// Token: 0x040031A4 RID: 12708
		internal static Dictionary<string, List<Class512>> dictionary_0;

		// Token: 0x040031A7 RID: 12711
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x040031A3 RID: 12707
		private static int int_0;

		// Token: 0x040031A6 RID: 12710
		internal static string string_0 = "scores.db";

		// Token: 0x06003567 RID: 13671
		// RVA: 0x000270B0 File Offset: 0x000252B0
		internal static void Remove(string string_1)
		{
			Class908.dictionary_0.Remove(string_1);
			Class908.bool_0 = true;
		}

		// Token: 0x06003560 RID: 13664
		// RVA: 0x0016D424 File Offset: 0x0016B624
		internal static List<Class512> smethod_0(string string_1, PlayModes playModes_0)
		{
			Class908.Class909 class = new Class908.Class909();
			class.playModes_0 = playModes_0;
			if (Class908.dictionary_0 == null)
			{
				return null;
			}
			List<Class512> list;
			if (!Class908.dictionary_0.TryGetValue(string_1, out list))
			{
				return null;
			}
			return list.FindAll(new Predicate<Class512>(class.method_0));
		}

		// Token: 0x06003561 RID: 13665
		// RVA: 0x0016D46C File Offset: 0x0016B66C
		internal static void smethod_1()
		{
			if (Class908.dictionary_0 != null)
			{
				return;
			}
			if (Class466.list_3 == null)
			{
				Class466.smethod_12(false, false);
			}
			Class908.dictionary_0 = new Dictionary<string, List<Class512>>();
			bool flag;
			if (!(flag = File.Exists(Class908.string_0)) && File.Exists("scores.db"))
			{
				File.Copy("scores.db", Class908.string_0);
				flag = true;
			}
			if (flag)
			{
				try
				{
					using (Stream stream = File.Open(Class908.string_0, FileMode.Open))
					{
						using (Class32 class = new Class32(stream))
						{
							Class908.int_0 = class.ReadInt32();
							int num = class.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								string text = class.ReadString();
								int num2 = class.ReadInt32();
								List<Class512> list = new List<Class512>(num2);
								for (int j = 0; j < num2; j++)
								{
									Class512 class2 = Class721.Create((PlayModes)class.ReadByte(), null);
									class2.method_23(class);
									if (Class876.smethod_6(class2.class623_0, Mods.Target))
									{
										class2 = new Class513(class2);
									}
									class2.ReadFromStream(class);
									list.Add(class2);
								}
								if (Class466.smethod_25(text) != null)
								{
									Class908.dictionary_0.Add(text, list);
								}
								else
								{
									foreach (Class512 current in list)
									{
										current.method_27();
									}
								}
							}
						}
					}
				}
				catch
				{
					string text2 = string.Concat(new object[]
					{
						Class908.string_0,
						".",
						DateTime.Now.Ticks,
						".bak"
					});
					if (File.Exists(Class908.string_0) && !File.Exists(text2))
					{
						File.Move(Class908.string_0, text2);
					}
				}
			}
			if (Class908.int_0 < 1024 && Directory.GetFiles("Data/r").Length > 0)
			{
				Class115.smethod_6(true);
				Maintenance maintenance = new Maintenance(Enum74.const_1);
				maintenance.ShowDialog(Class115.form_0);
				Class115.smethod_6(false);
			}
			foreach (KeyValuePair<string, List<Class512>> current2 in Class908.dictionary_0)
			{
				if (Class466.smethod_25(current2.Key) == null)
				{
					foreach (Class512 current3 in current2.Value)
					{
						current3.method_27();
					}
				}
			}
			if (!flag)
			{
				Class908.smethod_3(true);
			}
		}

		// Token: 0x06003562 RID: 13666
		// RVA: 0x0016D798 File Offset: 0x0016B998
		internal static int smethod_2(Class512 class512_0, bool bool_1, bool bool_2)
		{
			Class908.smethod_1();
			if (class512_0 == null)
			{
				return -1;
			}
			int num = 0;
			int num2 = 0;
			Class512 class = null;
			Class512 class2 = null;
			List<Class512> list = Class908.smethod_0(class512_0.string_1, Class62.Mode);
			if (list == null)
			{
				list = new List<Class512>();
				Class908.dictionary_0.Add(class512_0.string_1, list);
				Class908.bool_0 = true;
			}
			foreach (Class512 current in list)
			{
				num2++;
				if (current.int_3 >= class512_0.int_3)
				{
					num++;
					if (class == null || current.int_3 < class.int_3)
					{
						class = current;
					}
					if (num >= 40)
					{
						int result = -1;
						return result;
					}
				}
				else if (class2 == null || current.int_3 < class2.int_3)
				{
					class2 = current;
				}
				if (current.method_3() == class512_0.method_3())
				{
					int result = num2;
					return result;
				}
			}
			if (!bool_1)
			{
				List<Class512> list2 = Class908.dictionary_0[class512_0.string_1];
				Class908.bool_0 = true;
				if (class2 != null && num2 >= 40)
				{
					class2.method_27();
					list2.Remove(class2);
				}
				if (bool_2)
				{
					Class908.smethod_6(class512_0, class512_0.method_8());
				}
				int num3 = list2.BinarySearch(class512_0);
				if (num3 < 0)
				{
					num3 = ~num3;
				}
				list2.Insert(num3, class512_0);
			}
			return num + 1;
		}

		// Token: 0x06003563 RID: 13667
		// RVA: 0x0016D8F8 File Offset: 0x0016BAF8
		internal static void smethod_3(bool bool_1)
		{
			if (Class908.dictionary_0 != null && (bool_1 || Class908.bool_0))
			{
				Class908.bool_0 = false;
				using (Stream stream = new Stream17(Class908.string_0))
				{
					using (Class31 class = new Class31(stream))
					{
						class.Write(20150414);
						class.Write(Class908.dictionary_0.Count);
						foreach (KeyValuePair<string, List<Class512>> current in Class908.dictionary_0)
						{
							class.Write(current.Key);
							class.Write(current.Value.Count);
							foreach (Class512 current2 in current.Value)
							{
								current2.method_24();
								current2.WriteToStream(class);
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06003564 RID: 13668
		// RVA: 0x000270A7 File Offset: 0x000252A7
		public static Class512 smethod_4(string string_1)
		{
			return Class908.smethod_5(string_1, true);
		}

		// Token: 0x06003565 RID: 13669
		// RVA: 0x0016DA2C File Offset: 0x0016BC2C
		public static Class512 smethod_5(string string_1, bool bool_1)
		{
			Class908.smethod_1();
			Class512 class = null;
			bool flag = false;
			try
			{
				using (Stream stream = File.Open(string_1, FileMode.Open))
				{
					Class32 class2 = new Class32(stream);
					class = Class721.Create((PlayModes)class2.ReadByte(), null);
					class.method_23(class2);
					if (Class876.smethod_6(class.class623_0, Mods.Target))
					{
						class = new Class513(class);
					}
					class.ReadFromStream(class2);
					if (class.dateTime_0 < DateTime.UtcNow + new TimeSpan(1825, 0, 0, 0))
					{
						flag = true;
					}
				}
			}
			catch
			{
			}
			if (!flag)
			{
				Class512 result;
				try
				{
					using (Stream stream2 = File.Open(string_1, FileMode.Open))
					{
						class = (Class512)Class27.Deserialize(stream2);
					}
					goto IL_C9;
				}
				catch
				{
					Class723.smethod_4(Class41.GetString(OsuString.ScoreManager_ReplayCorrupt));
					result = null;
				}
				return result;
			}
			IL_C9:
			if (class == null)
			{
				Class723.smethod_4(Class41.GetString(OsuString.ScoreManager_ReplayCorrupt));
				return null;
			}
			if (class.dateTime_0.Year > 2050 || class.dateTime_0 == DateTime.MinValue)
			{
				string[] array = string_1.Split(new char[]
				{
					'-'
				});
				if (array.Length > 1)
				{
					long fileTime = 0L;
					if (long.TryParse(array[1].Replace(".osr", string.Empty), out fileTime))
					{
						class.dateTime_0 = DateTime.FromFileTimeUtc(fileTime);
					}
				}
			}
			if (class.dateTime_0.Year > 2050)
			{
				File.Delete(string_1);
				Class723.smethod_4(Class41.GetString(OsuString.ScoreManager_ReplayCorrupt));
				return null;
			}
			if (Class466.smethod_25(class.string_1) == null)
			{
				if (bool_1)
				{
					string arg_1B1_0 = class.string_1;
					EventHandler arg_1B1_1 = null;
					if (Class908.eventHandler_0 == null)
					{
						Class908.eventHandler_0 = new EventHandler(Class908.smethod_8);
					}
					Class112.smethod_6(arg_1B1_0, arg_1B1_1, Class908.eventHandler_0);
				}
				return null;
			}
			Class908.smethod_2(class, false, true);
			return class;
		}

		// Token: 0x06003566 RID: 13670
		// RVA: 0x0016DC30 File Offset: 0x0016BE30
		public static bool smethod_6(Class512 class512_0, string string_1)
		{
			bool flag = string_1 == null;
			if (string_1 == null)
			{
				if (!Directory.Exists("Replays"))
				{
					Directory.CreateDirectory("Replays");
				}
				string_1 = string.Format("{0} - {1} ({2:yyyy-MM-dd}) {3}.osr", new object[]
				{
					class512_0.string_2,
					Class466.Current.string_6,
					class512_0.dateTime_0.ToUniversalTime(),
					class512_0.playModes_0
				});
				string_1 = "Replays\\" + Class34.smethod_1(string_1);
			}
			bool flag2 = true;
			if (class512_0.byte_0 == null)
			{
				if (class512_0.list_1 != null && class512_0.list_1.Count != 0)
				{
					class512_0.byte_0 = SevenZipHelper.Compress(new ASCIIEncoding().GetBytes(class512_0.method_4()));
				}
				else
				{
					flag2 = false;
				}
			}
			if (flag2)
			{
				using (Stream stream = File.Open(string_1, FileMode.Create))
				{
					class512_0.WriteToStream(new Class31(stream));
				}
				if (!flag && class512_0.list_5.Count > 0)
				{
					using (Stream stream2 = File.Open(string_1.Replace(".osr", ".osg"), FileMode.Create))
					{
						using (Class31 class = new Class31(stream2))
						{
							class.Write(20150414);
							class.Write<Struct13>(class512_0.list_5);
						}
					}
				}
			}
			if (flag)
			{
				if (flag2)
				{
					Class723.smethod_5(string.Format(Class41.GetString(OsuString.ScoreManager_SavedReplayToFile), string_1), Color.get_BlueViolet(), 6000, null);
				}
				else
				{
					Class723.smethod_4(Class41.GetString(OsuString.ScoreManager_ReplayFailed));
				}
			}
			return flag2;
		}

		// Token: 0x06003568 RID: 13672
		// RVA: 0x0016DDE8 File Offset: 0x0016BFE8
		internal static void smethod_7(string string_1, string string_2)
		{
			Predicate<Class512> predicate = null;
			Class908.Class910 class = new Class908.Class910();
			class.string_0 = string_2;
			if (Class908.dictionary_0.ContainsKey(string_1))
			{
				List<Class512> list = Class908.dictionary_0[string_1];
				List<Class512> arg_3A_0 = list;
				if (predicate == null)
				{
					predicate = new Predicate<Class512>(class.method_0);
				}
				int num = arg_3A_0.FindIndex(predicate);
				if (num >= 0)
				{
					list.RemoveAt(num);
				}
				Class908.dictionary_0[string_1] = list;
				Class908.bool_0 = true;
			}
		}

		// Token: 0x06003569 RID: 13673
		// RVA: 0x000270C4 File Offset: 0x000252C4
		[CompilerGenerated]
		private static void smethod_8(object sender, EventArgs e)
		{
			Class723.smethod_4(Class41.GetString(OsuString.ScoreManager_DontHaveBeatmap));
		}
	}
}
