using ns14;
using ns8;
using System;
using System.Collections.Generic;
using System.IO;

namespace ns24
{
	// Token: 0x0200040A RID: 1034
	internal sealed class Class476
	{
		// Token: 0x04001A0E RID: 6670
		private static bool bool_0;

		// Token: 0x04001A0C RID: 6668
		private static int int_0;

		// Token: 0x04001A0D RID: 6669
		private static SortedDictionary<string, List<string>> sortedDictionary_0;

		// Token: 0x04001A0F RID: 6671
		internal static string string_0 = "collection.db";

		// Token: 0x06002122 RID: 8482
		// RVA: 0x0001ADC0 File Offset: 0x00018FC0
		internal static void Remove(string string_1)
		{
			Class476.sortedDictionary_0.Remove(string_1);
			Class476.bool_0 = true;
		}

		// Token: 0x0600211B RID: 8475
		// RVA: 0x0001AD85 File Offset: 0x00018F85
		internal static SortedDictionary<string, List<string>> smethod_0()
		{
			if (Class476.sortedDictionary_0 == null)
			{
				Class476.smethod_3();
			}
			return Class476.sortedDictionary_0;
		}

		// Token: 0x0600211C RID: 8476
		// RVA: 0x000C00EC File Offset: 0x000BE2EC
		internal static List<string> smethod_1(string string_1)
		{
			if (Class476.smethod_0() == null || string_1 == null)
			{
				return null;
			}
			List<string> result;
			if (!Class476.smethod_0().TryGetValue(string_1, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600211D RID: 8477
		// RVA: 0x000C0118 File Offset: 0x000BE318
		internal static List<string> smethod_2(string string_1)
		{
			if (Class476.smethod_0() != null && string_1 != null)
			{
				List<string> list = new List<string>();
				foreach (KeyValuePair<string, List<string>> current in Class476.smethod_0())
				{
					if (current.Value.IndexOf(string_1) >= 0)
					{
						list.Add(current.Key);
					}
				}
				return list;
			}
			return null;
		}

		// Token: 0x0600211E RID: 8478
		// RVA: 0x000C0194 File Offset: 0x000BE394
		internal static void smethod_3()
		{
			if (Class476.sortedDictionary_0 != null)
			{
				return;
			}
			if (Class466.list_3 == null)
			{
				Class466.smethod_12(false, false);
			}
			Class476.sortedDictionary_0 = new SortedDictionary<string, List<string>>();
			bool flag;
			if (flag = File.Exists(Class476.string_0))
			{
				try
				{
					using (Stream stream = File.Open(Class476.string_0, FileMode.Open))
					{
						using (Class32 class = new Class32(stream))
						{
							Class476.int_0 = class.ReadInt32();
							int num = class.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								string key = class.ReadString();
								int num2 = class.ReadInt32();
								List<string> list = new List<string>(num2);
								for (int j = 0; j < num2; j++)
								{
									string text = class.ReadString();
									Class296 class2 = Class466.smethod_25(text);
									if (class2 != null)
									{
										list.Add(text);
									}
								}
								Class476.sortedDictionary_0.Add(key, list);
							}
						}
					}
				}
				catch
				{
					string text2 = string.Concat(new object[]
					{
						Class476.string_0,
						".",
						DateTime.Now.Ticks,
						".bak"
					});
					if (File.Exists(Class476.string_0) && !File.Exists(text2))
					{
						File.Move(Class476.string_0, text2);
					}
				}
			}
			if (!flag)
			{
				Class476.smethod_6(true);
			}
		}

		// Token: 0x0600211F RID: 8479
		// RVA: 0x0001AD98 File Offset: 0x00018F98
		internal static bool smethod_4(string string_1)
		{
			if (!Class476.sortedDictionary_0.ContainsKey(string_1))
			{
				Class476.sortedDictionary_0.Add(string_1, new List<string>());
				Class476.bool_0 = true;
				return true;
			}
			return false;
		}

		// Token: 0x06002120 RID: 8480
		// RVA: 0x000C0310 File Offset: 0x000BE510
		internal static bool smethod_5(string string_1, string string_2)
		{
			Class476.smethod_3();
			List<string> list;
			if (Class476.sortedDictionary_0.ContainsKey(string_1))
			{
				list = Class476.sortedDictionary_0[string_1];
			}
			else
			{
				list = (Class476.sortedDictionary_0[string_1] = new List<string>());
			}
			if (list.Contains(string_2))
			{
				return false;
			}
			list.Add(string_2);
			Class476.bool_0 = true;
			return true;
		}

		// Token: 0x06002121 RID: 8481
		// RVA: 0x000C0368 File Offset: 0x000BE568
		internal static void smethod_6(bool bool_1)
		{
			if (Class476.sortedDictionary_0 != null && (bool_1 || Class476.bool_0))
			{
				Class476.bool_0 = false;
				using (Stream stream = new Stream17(Class476.string_0))
				{
					using (Class31 class = new Class31(stream))
					{
						class.Write(20150414);
						class.Write(Class476.sortedDictionary_0.Count);
						foreach (KeyValuePair<string, List<string>> current in Class476.sortedDictionary_0)
						{
							class.Write(current.Key);
							class.Write(current.Value.Count);
							foreach (string current2 in current.Value)
							{
								class.Write(current2);
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06002123 RID: 8483
		// RVA: 0x0001ADD4 File Offset: 0x00018FD4
		internal static bool smethod_7(string string_1, string string_2)
		{
			Class476.bool_0 = true;
			return Class476.sortedDictionary_0.ContainsKey(string_1) && Class476.sortedDictionary_0[string_1].Remove(string_2);
		}
	}
}
