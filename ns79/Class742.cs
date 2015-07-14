using System;
using System.Collections.Generic;

namespace ns79
{
	// Token: 0x02000579 RID: 1401
	internal static class Class742
	{
		// Token: 0x0400257D RID: 9597
		internal static List<Class532> list_0 = new List<Class532>();

		// Token: 0x0400257E RID: 9598
		internal static List<Class532> list_1 = new List<Class532>();

		// Token: 0x06002D0E RID: 11534
		// RVA: 0x00022194 File Offset: 0x00020394
		internal static void Load(Class532 class532_0, bool bool_0)
		{
			if (class532_0 == null)
			{
				return;
			}
			if (bool_0)
			{
				Class742.list_0.Add(class532_0);
				return;
			}
			Class742.list_1.Add(class532_0);
		}

		// Token: 0x06002D0D RID: 11533
		// RVA: 0x00022178 File Offset: 0x00020378
		internal static bool Remove(Class532 class532_0)
		{
			return Class742.list_0.Remove(class532_0) || Class742.list_1.Remove(class532_0);
		}

		// Token: 0x06002D0F RID: 11535
		// RVA: 0x00124A68 File Offset: 0x00122C68
		internal static void smethod_0()
		{
			for (int i = 0; i < Class742.list_0.Count; i++)
			{
				if (Class742.list_0[i].method_49())
				{
					Class742.list_0.RemoveAt(i--);
				}
			}
		}

		// Token: 0x06002D10 RID: 11536
		// RVA: 0x00124AAC File Offset: 0x00122CAC
		public static void smethod_1()
		{
			foreach (Class532 current in Class742.list_0)
			{
				current.method_50();
			}
			foreach (Class532 current2 in Class742.list_1)
			{
				current2.method_50();
			}
			Class742.list_0.Clear();
			Class742.list_1.Clear();
		}
	}
}
