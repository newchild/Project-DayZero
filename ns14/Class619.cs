using System;
using System.Collections.Generic;

namespace ns14
{
	// Token: 0x020004AE RID: 1198
	internal static class Class619
	{
		// Token: 0x020004AF RID: 1199
		private sealed class Class620<T> : IComparer<KeyValuePair<int, T>> where T : IComparable<T>
		{
			// Token: 0x06002636 RID: 9782
			// RVA: 0x000E5BAC File Offset: 0x000E3DAC
			public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
			{
				T value = x.Value;
				int num = value.CompareTo(y.Value);
				if (num == 0)
				{
					return x.Key.CompareTo(y.Key);
				}
				return num;
			}
		}

		// Token: 0x06002634 RID: 9780
		// RVA: 0x000E5AF8 File Offset: 0x000E3CF8
		public static T[] smethod_0<T>(IList<T> ilist_0) where T : IComparable<T>
		{
			KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[ilist_0.Count];
			T[] array2 = new T[ilist_0.Count];
			ilist_0.CopyTo(array2, 0);
			for (int i = 0; i < ilist_0.Count; i++)
			{
				array[i] = new KeyValuePair<int, T>(i, ilist_0[i]);
			}
			Array.Sort<KeyValuePair<int, T>, T>(array, array2, new Class619.Class620<T>());
			return array2;
		}

		// Token: 0x06002635 RID: 9781
		// RVA: 0x000E5B5C File Offset: 0x000E3D5C
		public static bool smethod_1<T>(IList<T> ilist_0, bool bool_0) where T : IComparable<T>
		{
			int i = 1;
			int count = ilist_0.Count;
			while (i < count)
			{
				T t = ilist_0[i - 1];
				int num = t.CompareTo(ilist_0[i]);
				if ((bool_0 && num > 0) || (!bool_0 && num < 0))
				{
					return false;
				}
				i++;
			}
			return true;
		}
	}
}
