using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns31
{
	// Token: 0x020001D7 RID: 471
	internal static class Class134
	{
		// Token: 0x020001D8 RID: 472
		[CompilerGenerated]
		private sealed class Class135
		{
			// Token: 0x04000CAF RID: 3247
			public string string_0;

			// Token: 0x060010B4 RID: 4276
			// RVA: 0x00010368 File Offset: 0x0000E568
			public bool method_0(Class178 class178_0)
			{
				return class178_0.method_15().Equals(this.string_0);
			}
		}

		// Token: 0x04000CAC RID: 3244
		private static List<Class178> list_0 = new List<Class178>();

		// Token: 0x04000CAD RID: 3245
		private static List<AutoResetEvent> list_1 = new List<AutoResetEvent>();

		// Token: 0x04000CAE RID: 3246
		private static object object_0 = new object();

		// Token: 0x060010AF RID: 4271
		// RVA: 0x0001033E File Offset: 0x0000E53E
		public static Class178 smethod_0(string string_0)
		{
			return Class134.smethod_1(string_0, false, false);
		}

		// Token: 0x060010B0 RID: 4272
		// RVA: 0x00056C98 File Offset: 0x00054E98
		public static Class178 smethod_1(string string_0, bool bool_0, bool bool_1)
		{
			Class178 result;
			lock (Class134.object_0)
			{
				Class134.Class135 class = new Class134.Class135();
				class.string_0 = Path.GetFullPath(string_0);
				Class178 class2 = Class134.list_0.Find(new Predicate<Class178>(class.method_0));
				if (class2 != null && class2.bool_0)
				{
					Class134.smethod_2(class2);
					class2 = null;
				}
				if (class2 == null)
				{
					try
					{
						class2 = new Class178(class.string_0, null, bool_0, bool_1);
					}
					catch (Exception)
					{
						result = null;
						return result;
					}
					Class134.list_0.Add(class2);
				}
				result = class2;
			}
			return result;
		}

		// Token: 0x060010B1 RID: 4273
		// RVA: 0x00056D3C File Offset: 0x00054F3C
		public static void smethod_2(Class178 class178_0)
		{
			lock (Class134.object_0)
			{
				int num = Class134.list_0.IndexOf(class178_0);
				class178_0.Close();
				Class134.list_0.Remove(class178_0);
				if (num == -1)
				{
				}
			}
		}
	}
}
