using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000158 RID: 344
	[ExtensionAttribute2]
	internal static class CollectionUtils
	{
		// Token: 0x06000D79 RID: 3449
		// RVA: 0x0000E55A File Offset: 0x0000C75A
		[ExtensionAttribute2]
		public static bool AddDistinct<T>(IList<T> list, T value)
		{
			return CollectionUtils.AddDistinct<T>(list, value, EqualityComparer<T>.Default);
		}

		// Token: 0x06000D7A RID: 3450
		// RVA: 0x0000E568 File Offset: 0x0000C768
		[ExtensionAttribute2]
		public static bool AddDistinct<T>(IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			if (CollectionUtils.ContainsValue<T>(list, value, comparer))
			{
				return false;
			}
			list.Add(value);
			return true;
		}

		// Token: 0x06000D75 RID: 3445
		// RVA: 0x0004B714 File Offset: 0x00049914
		[ExtensionAttribute2]
		public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection)
		{
			if (initial == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (collection == null)
			{
				return;
			}
			foreach (T current in collection)
			{
				initial.Add(current);
			}
		}

		// Token: 0x06000D76 RID: 3446
		// RVA: 0x0000E50B File Offset: 0x0000C70B
		[ExtensionAttribute2]
		public static void AddRange<T>(IList<T> initial, IEnumerable collection)
		{
			ValidationUtils.ArgumentNotNull(initial, "initial");
			CollectionUtils.AddRange<T>(initial, Enumerable.Cast<T>(collection));
		}

		// Token: 0x06000D7C RID: 3452
		// RVA: 0x0004B86C File Offset: 0x00049A6C
		[ExtensionAttribute2]
		public static bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			bool result = true;
			foreach (T current in values)
			{
				if (!CollectionUtils.AddDistinct<T>(list, current, comparer))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000D7B RID: 3451
		// RVA: 0x0004B800 File Offset: 0x00049A00
		[ExtensionAttribute2]
		public static bool ContainsValue<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<TSource>.Default;
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			foreach (TSource current in source)
			{
				if (comparer.Equals(current, value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D80 RID: 3456
		// RVA: 0x0004B9C4 File Offset: 0x00049BC4
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
			int num = indices.Length;
			if (num == multidimensionalArray.Rank)
			{
				multidimensionalArray.SetValue(CollectionUtils.JaggedArrayGetValue(values, indices), indices);
				return;
			}
			int length = multidimensionalArray.GetLength(num);
			IList list = (IList)CollectionUtils.JaggedArrayGetValue(values, indices);
			int count = list.Count;
			if (count != length)
			{
				throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
			}
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = indices[i];
			}
			for (int j = 0; j < multidimensionalArray.GetLength(num); j++)
			{
				array[num] = j;
				CollectionUtils.CopyFromJaggedToMultidimensionalArray(values, multidimensionalArray, array);
			}
		}

		// Token: 0x06000D7F RID: 3455
		// RVA: 0x0004B974 File Offset: 0x00049B74
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			IList<int> list = new List<int>();
			IList list2 = values;
			while (true)
			{
				list.Add(list2.Count);
				if (list.Count == dimensionsCount || list2.Count == 0)
				{
					break;
				}
				object obj = list2[0];
				if (!(obj is IList))
				{
					break;
				}
				list2 = (IList)obj;
			}
			return list;
		}

		// Token: 0x06000D7D RID: 3453
		// RVA: 0x0004B8C0 File Offset: 0x00049AC0
		[ExtensionAttribute2]
		public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate)
		{
			int num = 0;
			foreach (T current in collection)
			{
				if (predicate(current))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06000D7E RID: 3454
		// RVA: 0x0004B918 File Offset: 0x00049B18
		[ExtensionAttribute2]
		public static int IndexOf<TSource>(IEnumerable<TSource> list, TSource value, IEqualityComparer<TSource> comparer)
		{
			int num = 0;
			foreach (TSource current in list)
			{
				if (comparer.Equals(current, value))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06000D77 RID: 3447
		// RVA: 0x0000E524 File Offset: 0x0000C724
		public static bool IsDictionaryType(Type type)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			return typeof(IDictionary).IsAssignableFrom(type) || ReflectionUtils.ImplementsGenericDefinition(type, typeof(IDictionary<, >));
		}

		// Token: 0x06000D74 RID: 3444
		// RVA: 0x0000E4FB File Offset: 0x0000C6FB
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return collection == null || collection.Count == 0;
		}

		// Token: 0x06000D81 RID: 3457
		// RVA: 0x0004BA60 File Offset: 0x00049C60
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			IList list = values;
			for (int i = 0; i < indices.Length; i++)
			{
				int index = indices[i];
				if (i == indices.Length - 1)
				{
					return list[index];
				}
				list = (IList)list[index];
			}
			return list;
		}

		// Token: 0x06000D78 RID: 3448
		// RVA: 0x0004B770 File Offset: 0x00049970
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			Type type = typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				collectionItemType
			});
			ConstructorInfo constructorInfo = null;
			ConstructorInfo[] constructors = collectionType.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < constructors.Length; i++)
			{
				ConstructorInfo constructorInfo2 = constructors[i];
				IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
				if (parameters.Count == 1)
				{
					if (type == parameters[0].ParameterType)
					{
						constructorInfo = constructorInfo2;
						return constructorInfo;
					}
					if (constructorInfo == null && type.IsAssignableFrom(parameters[0].ParameterType))
					{
						constructorInfo = constructorInfo2;
					}
				}
			}
			return constructorInfo;
		}

		// Token: 0x06000D82 RID: 3458
		// RVA: 0x0004BAA4 File Offset: 0x00049CA4
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			IList<int> dimensions = CollectionUtils.GetDimensions(values, rank);
			while (dimensions.Count < rank)
			{
				dimensions.Add(0);
			}
			Array array = Array.CreateInstance(type, Enumerable.ToArray<int>(dimensions));
			CollectionUtils.CopyFromJaggedToMultidimensionalArray(values, array, new int[0]);
			return array;
		}
	}
}
