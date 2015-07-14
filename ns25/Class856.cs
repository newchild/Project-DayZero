using ns14;
using ns29;
using ns3;
using ns7;
using ns8;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000651 RID: 1617
	internal static class Class856
	{
		// Token: 0x02000652 RID: 1618
		[CompilerGenerated]
		private sealed class Class857
		{
			// Token: 0x04002D74 RID: 11636
			public DateTime dateTime_0;

			// Token: 0x060031CF RID: 12751
			// RVA: 0x00024C1C File Offset: 0x00022E1C
			public bool method_0(Class855 class855_0)
			{
				return class855_0.dateTime_0 < this.dateTime_0;
			}
		}

		// Token: 0x04002D6C RID: 11628
		private static bool bool_0;

		// Token: 0x04002D6A RID: 11626
		private static Dictionary<int, Class855> dictionary_0 = new Dictionary<int, Class855>();

		// Token: 0x04002D69 RID: 11625
		private static int int_0;

		// Token: 0x04002D6F RID: 11631
		private static int int_1;

		// Token: 0x04002D70 RID: 11632
		private static int int_2;

		// Token: 0x04002D71 RID: 11633
		private static int int_3;

		// Token: 0x04002D72 RID: 11634
		private static int int_4;

		// Token: 0x04002D73 RID: 11635
		private static int int_5;

		// Token: 0x04002D6B RID: 11627
		private static List<Class855> list_0 = new List<Class855>();

		// Token: 0x04002D6D RID: 11629
		private static List<int> list_1 = new List<int>();

		// Token: 0x04002D6E RID: 11630
		private static List<int> list_2 = new List<int>();

		// Token: 0x04002D68 RID: 11624
		internal static string string_0 = "presence.db";

		// Token: 0x060031C4 RID: 12740
		// RVA: 0x00024BA4 File Offset: 0x00022DA4
		internal static void Initialize()
		{
			if (Class856.bool_0)
			{
				return;
			}
			Class856.smethod_2();
		}

		// Token: 0x060031C3 RID: 12739
		// RVA: 0x00145CE8 File Offset: 0x00143EE8
		internal static void smethod_0()
		{
			if (Class115.bool_16 && !Class115.bool_17)
			{
				return;
			}
			try
			{
				using (Stream stream = new Stream17(Class856.string_0))
				{
					using (Class31 class = new Class31(stream))
					{
						class.Write(20150414);
						class.Write<Class855>(Class856.list_0);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060031C5 RID: 12741
		// RVA: 0x00145D74 File Offset: 0x00143F74
		internal static void smethod_1()
		{
			lock (Class856.dictionary_0)
			{
				Class856.list_2 = new List<int>();
				Class856.list_1 = new List<int>();
			}
		}

		// Token: 0x060031C6 RID: 12742
		// RVA: 0x00145DBC File Offset: 0x00143FBC
		private static void smethod_2()
		{
			if (File.Exists(Class856.string_0))
			{
				Class856.Class857 class = new Class856.Class857();
				try
				{
					using (Stream stream = File.Open(Class856.string_0, FileMode.Open, FileAccess.Read))
					{
						using (Class32 class2 = new Class32(stream))
						{
							Class856.int_0 = class2.ReadInt32();
							Class856.list_0 = (List<Class855>)class2.method_2<Class855>();
						}
					}
				}
				catch (Exception)
				{
				}
				class.dateTime_0 = DateTime.Now.AddHours(-96.0);
				Class856.list_0.RemoveAll(new Predicate<Class855>(class.method_0));
				Class856.smethod_3();
			}
		}

		// Token: 0x060031C7 RID: 12743
		// RVA: 0x00145E8C File Offset: 0x0014408C
		private static void smethod_3()
		{
			foreach (Class855 current in Class856.list_0)
			{
				Class856.dictionary_0[current.class17_0.int_1] = current;
			}
		}

		// Token: 0x060031C8 RID: 12744
		// RVA: 0x00145EF0 File Offset: 0x001440F0
		internal static void smethod_4(Class17 class17_0)
		{
			lock (Class856.dictionary_0)
			{
				Class855 class = Class856.smethod_5(class17_0.int_1, false);
				if (class == null)
				{
					class = new Class855();
					Class856.list_0.Add(class);
					Class856.dictionary_0[class17_0.int_1] = class;
				}
				class.class17_0 = class17_0;
				class.dateTime_0 = DateTime.Now;
				Class856.int_4++;
				Class856.list_1.Remove(class17_0.int_1);
			}
		}

		// Token: 0x060031C9 RID: 12745
		// RVA: 0x00145F84 File Offset: 0x00144184
		internal static Class855 smethod_5(int int_6, bool bool_1)
		{
			Class855 result;
			lock (Class856.dictionary_0)
			{
				Class855 class = null;
				if (Class856.dictionary_0.TryGetValue(int_6, out class))
				{
					Class856.int_1++;
				}
				else
				{
					Class856.int_2++;
				}
				if (bool_1 && (class == null || (DateTime.Now - class.dateTime_0).TotalHours > 24.0))
				{
					Class856.smethod_6(int_6);
				}
				result = class;
			}
			return result;
		}

		// Token: 0x060031CA RID: 12746
		// RVA: 0x00146014 File Offset: 0x00144214
		private static void smethod_6(int int_6)
		{
			lock (Class856.dictionary_0)
			{
				if (int_6 > 0 && !Class856.list_1.Contains(int_6))
				{
					Class856.int_3++;
					bool flag = Class856.list_2.Count == 0;
					Class856.list_1.Add(int_6);
					Class856.list_2.Add(int_6);
					if (flag)
					{
						Class115.class47_0.method_1(new VoidDelegate(Class856.smethod_7), 600, false);
					}
				}
			}
		}

		// Token: 0x060031CB RID: 12747
		// RVA: 0x001460A8 File Offset: 0x001442A8
		private static void smethod_7()
		{
			lock (Class856.dictionary_0)
			{
				if (Class856.list_2.Count > 256)
				{
					Class856.smethod_8();
				}
				else
				{
					Class809.smethod_34(Enum3.const_97, new Struct14(Class856.list_2));
				}
				Class856.list_2 = new List<int>();
			}
		}

		// Token: 0x060031CC RID: 12748
		// RVA: 0x00024BB3 File Offset: 0x00022DB3
		internal static bool smethod_8()
		{
			if (Class856.int_5 > 0 && Class115.int_1 - Class856.int_5 < 300000)
			{
				return false;
			}
			Class856.int_5 = Class115.int_1;
			Class809.smethod_33(Enum3.const_98, Class115.int_1);
			return true;
		}
	}
}
