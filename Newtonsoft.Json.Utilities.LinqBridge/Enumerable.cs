using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x0200006C RID: 108
	[ExtensionAttribute2]
	internal static class Enumerable
	{
		// Token: 0x0200006D RID: 109
		private static class Futures<T>
		{
			// Token: 0x040001E2 RID: 482
			public static readonly Func<T> Default = () => default(T);

			// Token: 0x040001E3 RID: 483
			public static readonly Func<T> Undefined = delegate
			{
				throw new InvalidOperationException();
			};
		}

		// Token: 0x0200006F RID: 111
		private sealed class Grouping<K, V> : List<V>, IEnumerable<V>, IGrouping<K, V>, IEnumerable
		{
			// Token: 0x17000085 RID: 133
			public K Key
			{
				// Token: 0x060003E4 RID: 996
				// RVA: 0x000086DF File Offset: 0x000068DF
				get;
				// Token: 0x060003E5 RID: 997
				// RVA: 0x000086E7 File Offset: 0x000068E7
				private set;
			}

			// Token: 0x060003E3 RID: 995
			// RVA: 0x000086D0 File Offset: 0x000068D0
			internal Grouping(K key)
			{
				this.Key = key;
			}
		}

		// Token: 0x0200006E RID: 110
		private static class Sequence<T>
		{
			// Token: 0x040001E6 RID: 486
			public static readonly IEnumerable<T> Empty = new T[0];
		}

		// Token: 0x06000356 RID: 854
		// RVA: 0x000303AC File Offset: 0x0002E5AC
		[ExtensionAttribute2]
		public static TSource Aggregate<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TSource, TSource>>(func, "func");
			TSource result;
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					throw new InvalidOperationException();
				}
				result = Enumerable.Aggregate<TSource, TSource>(Enumerable.Skip<TSource>(Enumerable.Renumerable<TSource>(enumerator), 1), enumerator.Current, func);
			}
			return result;
		}

		// Token: 0x06000357 RID: 855
		// RVA: 0x00008273 File Offset: 0x00006473
		[ExtensionAttribute2]
		public static TAccumulate Aggregate<TSource, TAccumulate>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return Enumerable.Aggregate<TSource, TAccumulate, TAccumulate>(source, seed, func, (TAccumulate r) => r);
		}

		// Token: 0x06000358 RID: 856
		// RVA: 0x0003041C File Offset: 0x0002E61C
		[ExtensionAttribute2]
		public static TResult Aggregate<TSource, TAccumulate, TResult>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TAccumulate, TSource, TAccumulate>>(func, "func");
			Enumerable.CheckNotNull<Func<TAccumulate, TResult>>(resultSelector, "resultSelector");
			TAccumulate tAccumulate = seed;
			foreach (TSource current in source)
			{
				tAccumulate = func(tAccumulate, current);
			}
			return resultSelector(tAccumulate);
		}

		// Token: 0x0600035E RID: 862
		// RVA: 0x000304D4 File Offset: 0x0002E6D4
		[ExtensionAttribute2]
		public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, bool>>(predicate, "predicate");
			foreach (TSource current in source)
			{
				if (!predicate(current))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600035F RID: 863
		// RVA: 0x0003053C File Offset: 0x0002E73C
		[ExtensionAttribute2]
		public static bool Any<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			bool result;
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				result = enumerator.MoveNext();
			}
			return result;
		}

		// Token: 0x06000360 RID: 864
		// RVA: 0x000082B6 File Offset: 0x000064B6
		[ExtensionAttribute2]
		public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.Any<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600030F RID: 783
		// RVA: 0x00007F8B File Offset: 0x0000618B
		public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source)
		{
			return source;
		}

		// Token: 0x06000384 RID: 900
		// RVA: 0x00030A80 File Offset: 0x0002EC80
		[ExtensionAttribute2]
		public static double Average(IEnumerable<int> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int>>(source, "source");
			long num = 0L;
			long num2 = 0L;
			checked
			{
				foreach (int current in source)
				{
					num += unchecked((long)current);
					num2 += 1L;
				}
				if (num2 == 0L)
				{
					throw new InvalidOperationException();
				}
				return (double)num / (double)num2;
			}
		}

		// Token: 0x06000388 RID: 904
		// RVA: 0x00030B7C File Offset: 0x0002ED7C
		[ExtensionAttribute2]
		public static double? Average(IEnumerable<int?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int?>>(source, "source");
			long num = 0L;
			long num2 = 0L;
			checked
			{
				foreach (int? current in Enumerable.Where<int?>(source, (int? n) => n.HasValue))
				{
					num += unchecked((long)current.Value);
					num2 += 1L;
				}
				if (num2 == 0L)
				{
					return null;
				}
				double? num3 = new double?((double)num);
				double num4 = (double)num2;
				if (!num3.HasValue)
				{
					return null;
				}
				return new double?(num3.GetValueOrDefault() / num4);
			}
		}

		// Token: 0x06000390 RID: 912
		// RVA: 0x00030D8C File Offset: 0x0002EF8C
		[ExtensionAttribute2]
		public static double Average(IEnumerable<long> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long>>(source, "source");
			long num = 0L;
			long num2 = 0L;
			checked
			{
				foreach (long current in source)
				{
					num += current;
					num2 += 1L;
				}
				if (num2 == 0L)
				{
					throw new InvalidOperationException();
				}
				return (double)num / (double)num2;
			}
		}

		// Token: 0x06000394 RID: 916
		// RVA: 0x00030E94 File Offset: 0x0002F094
		[ExtensionAttribute2]
		public static double? Average(IEnumerable<long?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long?>>(source, "source");
			long num = 0L;
			long num2 = 0L;
			checked
			{
				foreach (long? current in Enumerable.Where<long?>(source, (long? n) => n.HasValue))
				{
					num += current.Value;
					num2 += 1L;
				}
				if (num2 == 0L)
				{
					return null;
				}
				double? num3 = new double?((double)num);
				double num4 = (double)num2;
				if (!num3.HasValue)
				{
					return null;
				}
				return new double?(num3.GetValueOrDefault() / num4);
			}
		}

		// Token: 0x0600039C RID: 924
		// RVA: 0x000310A4 File Offset: 0x0002F2A4
		[ExtensionAttribute2]
		public static float Average(IEnumerable<float> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float>>(source, "source");
			float num = 0f;
			long num2 = 0L;
			foreach (float num3 in source)
			{
				num += num3;
				checked
				{
					num2 += 1L;
				}
			}
			if (num2 == 0L)
			{
				throw new InvalidOperationException();
			}
			return num / (float)num2;
		}

		// Token: 0x060003A0 RID: 928
		// RVA: 0x000311A4 File Offset: 0x0002F3A4
		[ExtensionAttribute2]
		public static float? Average(IEnumerable<float?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float?>>(source, "source");
			float num = 0f;
			long num2 = 0L;
			foreach (float? current in Enumerable.Where<float?>(source, (float? n) => n.HasValue))
			{
				num += current.Value;
				checked
				{
					num2 += 1L;
				}
			}
			if (num2 == 0L)
			{
				return null;
			}
			float? num3 = new float?(num);
			float num4 = (float)num2;
			if (!num3.HasValue)
			{
				return null;
			}
			return new float?(num3.GetValueOrDefault() / num4);
		}

		// Token: 0x060003A8 RID: 936
		// RVA: 0x000313B4 File Offset: 0x0002F5B4
		[ExtensionAttribute2]
		public static double Average(IEnumerable<double> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double>>(source, "source");
			double num = 0.0;
			long num2 = 0L;
			foreach (double num3 in source)
			{
				num += num3;
				checked
				{
					num2 += 1L;
				}
			}
			if (num2 == 0L)
			{
				throw new InvalidOperationException();
			}
			return num / (double)num2;
		}

		// Token: 0x060003AC RID: 940
		// RVA: 0x000314C0 File Offset: 0x0002F6C0
		[ExtensionAttribute2]
		public static double? Average(IEnumerable<double?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double?>>(source, "source");
			double num = 0.0;
			long num2 = 0L;
			foreach (double? current in Enumerable.Where<double?>(source, (double? n) => n.HasValue))
			{
				num += current.Value;
				checked
				{
					num2 += 1L;
				}
			}
			if (num2 == 0L)
			{
				return null;
			}
			double? num3 = new double?(num);
			double num4 = (double)num2;
			if (!num3.HasValue)
			{
				return null;
			}
			return new double?(num3.GetValueOrDefault() / num4);
		}

		// Token: 0x060003B4 RID: 948
		// RVA: 0x000316D4 File Offset: 0x0002F8D4
		[ExtensionAttribute2]
		public static decimal Average(IEnumerable<decimal> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal>>(source, "source");
			decimal d = 0m;
			long num = 0L;
			checked
			{
				foreach (decimal current in source)
				{
					d += current;
					num += 1L;
				}
				if (num == 0L)
				{
					throw new InvalidOperationException();
				}
				return d / num;
			}
		}

		// Token: 0x060003B8 RID: 952
		// RVA: 0x000317E0 File Offset: 0x0002F9E0
		[ExtensionAttribute2]
		public static decimal? Average(IEnumerable<decimal?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal?>>(source, "source");
			decimal num = 0m;
			long num2 = 0L;
			checked
			{
				foreach (decimal? current in Enumerable.Where<decimal?>(source, (decimal? n) => n.HasValue))
				{
					num += current.Value;
					num2 += 1L;
				}
				if (num2 == 0L)
				{
					return null;
				}
				decimal? num3 = new decimal?(num);
				decimal d = num2;
				if (!num3.HasValue)
				{
					return null;
				}
				return new decimal?(num3.GetValueOrDefault() / d);
			}
		}

		// Token: 0x06000385 RID: 901
		// RVA: 0x00008419 File Offset: 0x00006619
		[ExtensionAttribute2]
		public static double Average<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, int>(source, selector));
		}

		// Token: 0x06000389 RID: 905
		// RVA: 0x00008435 File Offset: 0x00006635
		[ExtensionAttribute2]
		public static double? Average<TSource>(IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, int?>(source, selector));
		}

		// Token: 0x06000391 RID: 913
		// RVA: 0x0000846D File Offset: 0x0000666D
		[ExtensionAttribute2]
		public static double Average<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, long>(source, selector));
		}

		// Token: 0x06000395 RID: 917
		// RVA: 0x00008489 File Offset: 0x00006689
		[ExtensionAttribute2]
		public static double? Average<TSource>(IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, long?>(source, selector));
		}

		// Token: 0x0600039D RID: 925
		// RVA: 0x000084C1 File Offset: 0x000066C1
		[ExtensionAttribute2]
		public static float Average<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, float>(source, selector));
		}

		// Token: 0x060003A1 RID: 929
		// RVA: 0x000084DD File Offset: 0x000066DD
		[ExtensionAttribute2]
		public static float? Average<TSource>(IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, float?>(source, selector));
		}

		// Token: 0x060003A9 RID: 937
		// RVA: 0x00008515 File Offset: 0x00006715
		[ExtensionAttribute2]
		public static double Average<TSource>(IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, double>(source, selector));
		}

		// Token: 0x060003AD RID: 941
		// RVA: 0x00008531 File Offset: 0x00006731
		[ExtensionAttribute2]
		public static double? Average<TSource>(IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, double?>(source, selector));
		}

		// Token: 0x060003B5 RID: 949
		// RVA: 0x00008569 File Offset: 0x00006769
		[ExtensionAttribute2]
		public static decimal Average<TSource>(IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, decimal>(source, selector));
		}

		// Token: 0x060003B9 RID: 953
		// RVA: 0x00008585 File Offset: 0x00006785
		[ExtensionAttribute2]
		public static decimal? Average<TSource>(IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			return Enumerable.Average(Enumerable.Select<TSource, decimal?>(source, selector));
		}

		// Token: 0x06000311 RID: 785
		// RVA: 0x00007F95 File Offset: 0x00006195
		[ExtensionAttribute2]
		public static IEnumerable<TResult> Cast<TResult>(IEnumerable source)
		{
			Enumerable.CheckNotNull<IEnumerable>(source, "source");
			return Enumerable.CastYield<TResult>(source);
		}

		// Token: 0x06000312 RID: 786
		// RVA: 0x0002FB68 File Offset: 0x0002DD68
		private static IEnumerable<TResult> CastYield<TResult>(IEnumerable source)
		{
			Enumerable.<CastYield>d__0<TResult> <CastYield>d__ = new Enumerable.<CastYield>d__0<TResult>(-2);
			<CastYield>d__.<>3__source = source;
			return <CastYield>d__;
		}

		// Token: 0x06000381 RID: 897
		// RVA: 0x000083FA File Offset: 0x000065FA
		[DebuggerStepThrough]
		private static void CheckNotNull<T>(T value, string name) where T : class
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		// Token: 0x06000343 RID: 835
		// RVA: 0x00008172 File Offset: 0x00006372
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(first, "first");
			Enumerable.CheckNotNull<IEnumerable<TSource>>(second, "second");
			return Enumerable.ConcatYield<TSource>(first, second);
		}

		// Token: 0x06000344 RID: 836
		// RVA: 0x000301FC File Offset: 0x0002E3FC
		private static IEnumerable<TSource> ConcatYield<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			Enumerable.<ConcatYield>d__63<TSource> <ConcatYield>d__ = new Enumerable.<ConcatYield>d__63<TSource>(-2);
			<ConcatYield>d__.<>3__first = first;
			<ConcatYield>d__.<>3__second = second;
			return <ConcatYield>d__;
		}

		// Token: 0x06000361 RID: 865
		// RVA: 0x000082C4 File Offset: 0x000064C4
		[ExtensionAttribute2]
		public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value)
		{
			return Enumerable.Contains<TSource>(source, value, null);
		}

		// Token: 0x06000362 RID: 866
		// RVA: 0x00030580 File Offset: 0x0002E780
		[ExtensionAttribute2]
		public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			if (comparer == null)
			{
				ICollection<TSource> collection = source as ICollection<TSource>;
				if (collection != null)
				{
					return collection.Contains(value);
				}
			}
			comparer = (comparer ?? EqualityComparer<TSource>.Default);
			return Enumerable.Any<TSource>(source, (TSource item) => comparer.Equals(item, value));
		}

		// Token: 0x0600033F RID: 831
		// RVA: 0x0003017C File Offset: 0x0002E37C
		[ExtensionAttribute2]
		public static int Count<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			ICollection collection = source as ICollection;
			if (collection == null)
			{
				return Enumerable.Aggregate<TSource, int>(source, 0, (int count, TSource item) => checked(count + 1));
			}
			return collection.Count;
		}

		// Token: 0x06000340 RID: 832
		// RVA: 0x00008156 File Offset: 0x00006356
		[ExtensionAttribute2]
		public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.Count<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600035B RID: 859
		// RVA: 0x00030494 File Offset: 0x0002E694
		[ExtensionAttribute2]
		public static IEnumerable<TSource> DefaultIfEmpty<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.DefaultIfEmpty<TSource>(source, default(TSource));
		}

		// Token: 0x0600035C RID: 860
		// RVA: 0x000082A2 File Offset: 0x000064A2
		[ExtensionAttribute2]
		public static IEnumerable<TSource> DefaultIfEmpty<TSource>(IEnumerable<TSource> source, TSource defaultValue)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			return Enumerable.DefaultIfEmptyYield<TSource>(source, defaultValue);
		}

		// Token: 0x0600035D RID: 861
		// RVA: 0x000304B0 File Offset: 0x0002E6B0
		private static IEnumerable<TSource> DefaultIfEmptyYield<TSource>(IEnumerable<TSource> source, TSource defaultValue)
		{
			Enumerable.<DefaultIfEmptyYield>d__7e<TSource> <DefaultIfEmptyYield>d__7e = new Enumerable.<DefaultIfEmptyYield>d__7e<TSource>(-2);
			<DefaultIfEmptyYield>d__7e.<>3__source = source;
			<DefaultIfEmptyYield>d__7e.<>3__defaultValue = defaultValue;
			return <DefaultIfEmptyYield>d__7e;
		}

		// Token: 0x06000347 RID: 839
		// RVA: 0x000081B1 File Offset: 0x000063B1
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.Distinct<TSource>(source, null);
		}

		// Token: 0x06000348 RID: 840
		// RVA: 0x000081BA File Offset: 0x000063BA
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			return Enumerable.DistinctYield<TSource>(source, comparer);
		}

		// Token: 0x06000349 RID: 841
		// RVA: 0x00030220 File Offset: 0x0002E420
		private static IEnumerable<TSource> DistinctYield<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			Enumerable.<DistinctYield>d__6c<TSource> <DistinctYield>d__6c = new Enumerable.<DistinctYield>d__6c<TSource>(-2);
			<DistinctYield>d__6c.<>3__source = source;
			<DistinctYield>d__6c.<>3__comparer = comparer;
			return <DistinctYield>d__6c;
		}

		// Token: 0x06000336 RID: 822
		// RVA: 0x0002FF7C File Offset: 0x0002E17C
		[ExtensionAttribute2]
		public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, null);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list != null)
			{
				return list[index];
			}
			TSource result;
			try
			{
				result = Enumerable.First<TSource>(Enumerable.SkipWhile<TSource>(source, (TSource item, int i) => i < index));
			}
			catch (InvalidOperationException)
			{
				throw new ArgumentOutOfRangeException("index", index, null);
			}
			return result;
		}

		// Token: 0x06000337 RID: 823
		// RVA: 0x00030024 File Offset: 0x0002E224
		[ExtensionAttribute2]
		public static TSource ElementAtOrDefault<TSource>(IEnumerable<TSource> source, int index)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			if (index < 0)
			{
				return default(TSource);
			}
			IList<TSource> list = source as IList<TSource>;
			if (list == null)
			{
				return Enumerable.FirstOrDefault<TSource>(Enumerable.SkipWhile<TSource>(source, (TSource item, int i) => i < index));
			}
			if (index >= list.Count)
			{
				return default(TSource);
			}
			return list[index];
		}

		// Token: 0x06000310 RID: 784
		// RVA: 0x00007F8E File Offset: 0x0000618E
		public static IEnumerable<TResult> Empty<TResult>()
		{
			return Enumerable.Sequence<TResult>.Empty;
		}

		// Token: 0x06000377 RID: 887
		// RVA: 0x0000839F File Offset: 0x0000659F
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Enumerable.Except<TSource>(first, second, null);
		}

		// Token: 0x06000378 RID: 888
		// RVA: 0x000083A9 File Offset: 0x000065A9
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return Enumerable.IntersectExceptImpl<TSource>(first, second, comparer, false);
		}

		// Token: 0x06000328 RID: 808
		// RVA: 0x00008082 File Offset: 0x00006282
		[ExtensionAttribute2]
		public static TSource First<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.FirstImpl<TSource>(source, Enumerable.Futures<TSource>.Undefined);
		}

		// Token: 0x06000329 RID: 809
		// RVA: 0x0000808F File Offset: 0x0000628F
		[ExtensionAttribute2]
		public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.First<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x06000327 RID: 807
		// RVA: 0x0002FE10 File Offset: 0x0002E010
		[ExtensionAttribute2]
		private static TSource FirstImpl<TSource>(IEnumerable<TSource> source, Func<TSource> empty)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			IList<TSource> list = source as IList<TSource>;
			if (list == null)
			{
				TSource result;
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					result = (enumerator.MoveNext() ? enumerator.Current : empty());
				}
				return result;
			}
			if (list.Count <= 0)
			{
				return empty();
			}
			return list[0];
		}

		// Token: 0x0600032A RID: 810
		// RVA: 0x0000809D File Offset: 0x0000629D
		[ExtensionAttribute2]
		public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.FirstImpl<TSource>(source, Enumerable.Futures<TSource>.Default);
		}

		// Token: 0x0600032B RID: 811
		// RVA: 0x000080AA File Offset: 0x000062AA
		[ExtensionAttribute2]
		public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.FirstOrDefault<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600034E RID: 846
		// RVA: 0x00008205 File Offset: 0x00006405
		[ExtensionAttribute2]
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.GroupBy<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x0600034F RID: 847
		// RVA: 0x0000820F File Offset: 0x0000640F
		[ExtensionAttribute2]
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return Enumerable.GroupBy<TSource, TKey, TSource>(source, keySelector, (TSource e) => e, comparer);
		}

		// Token: 0x06000350 RID: 848
		// RVA: 0x00008225 File Offset: 0x00006425
		[ExtensionAttribute2]
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return Enumerable.GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
		}

		// Token: 0x06000352 RID: 850
		// RVA: 0x0000825C File Offset: 0x0000645C
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
		{
			return Enumerable.GroupBy<TSource, TKey, TResult>(source, keySelector, resultSelector, null);
		}

		// Token: 0x06000351 RID: 849
		// RVA: 0x00008230 File Offset: 0x00006430
		[ExtensionAttribute2]
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			Enumerable.CheckNotNull<Func<TSource, TElement>>(elementSelector, "elementSelector");
			return Enumerable.ToLookup<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
		}

		// Token: 0x06000353 RID: 851
		// RVA: 0x000302E8 File Offset: 0x0002E4E8
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			Enumerable.CheckNotNull<Func<TKey, IEnumerable<TSource>, TResult>>(resultSelector, "resultSelector");
			return Enumerable.Select<IGrouping<TKey, TSource>, TResult>(Enumerable.ToLookup<TSource, TKey>(source, keySelector, comparer), (IGrouping<TKey, TSource> g) => resultSelector(g.Key, g));
		}

		// Token: 0x06000354 RID: 852
		// RVA: 0x00008267 File Offset: 0x00006467
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			return Enumerable.GroupBy<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, null);
		}

		// Token: 0x06000355 RID: 853
		// RVA: 0x00030344 File Offset: 0x0002E544
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			Enumerable.CheckNotNull<Func<TSource, TElement>>(elementSelector, "elementSelector");
			Enumerable.CheckNotNull<Func<TKey, IEnumerable<TElement>, TResult>>(resultSelector, "resultSelector");
			return Enumerable.Select<IGrouping<TKey, TElement>, TResult>(Enumerable.ToLookup<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer), (IGrouping<TKey, TElement> g) => resultSelector(g.Key, g));
		}

		// Token: 0x0600037F RID: 895
		// RVA: 0x000083EC File Offset: 0x000065EC
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
		{
			return Enumerable.GroupJoin<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

		// Token: 0x06000380 RID: 896
		// RVA: 0x000309A8 File Offset: 0x0002EBA8
		[ExtensionAttribute2]
		public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TOuter>>(outer, "outer");
			Enumerable.CheckNotNull<IEnumerable<TInner>>(inner, "inner");
			Enumerable.CheckNotNull<Func<TOuter, TKey>>(outerKeySelector, "outerKeySelector");
			Enumerable.CheckNotNull<Func<TInner, TKey>>(innerKeySelector, "innerKeySelector");
			Enumerable.CheckNotNull<Func<TOuter, IEnumerable<TInner>, TResult>>(resultSelector, "resultSelector");
			ILookup<TKey, TInner> lookup = Enumerable.ToLookup<TInner, TKey>(inner, innerKeySelector, comparer);
			return Enumerable.Select<TOuter, TResult>(outer, (TOuter o) => resultSelector(o, lookup[outerKeySelector(o)]));
		}

		// Token: 0x06000375 RID: 885
		// RVA: 0x0000838A File Offset: 0x0000658A
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Intersect<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Enumerable.Intersect<TSource>(first, second, null);
		}

		// Token: 0x06000376 RID: 886
		// RVA: 0x00008394 File Offset: 0x00006594
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Intersect<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return Enumerable.IntersectExceptImpl<TSource>(first, second, comparer, true);
		}

		// Token: 0x06000374 RID: 884
		// RVA: 0x00030790 File Offset: 0x0002E990
		[ExtensionAttribute2]
		private static IEnumerable<TSource> IntersectExceptImpl<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer, bool flag)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(first, "first");
			Enumerable.CheckNotNull<IEnumerable<TSource>>(second, "second");
			List<TSource> list = new List<TSource>();
			Dictionary<TSource, bool> flags = new Dictionary<TSource, bool>(comparer);
			foreach (TSource current in Enumerable.Where<TSource>(first, (TSource k) => !flags.ContainsKey(k)))
			{
				flags.Add(current, !flag);
				list.Add(current);
			}
			foreach (TSource current2 in Enumerable.Where<TSource>(second, new Func<TSource, bool>(flags.ContainsKey)))
			{
				flags[current2] = flag;
			}
			return Enumerable.Where<TSource>(list, (TSource item) => flags[item]);
		}

		// Token: 0x0600037D RID: 893
		// RVA: 0x000083DE File Offset: 0x000065DE
		[ExtensionAttribute2]
		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return Enumerable.Join<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

		// Token: 0x0600037E RID: 894
		// RVA: 0x00030918 File Offset: 0x0002EB18
		[ExtensionAttribute2]
		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TOuter>>(outer, "outer");
			Enumerable.CheckNotNull<IEnumerable<TInner>>(inner, "inner");
			Enumerable.CheckNotNull<Func<TOuter, TKey>>(outerKeySelector, "outerKeySelector");
			Enumerable.CheckNotNull<Func<TInner, TKey>>(innerKeySelector, "innerKeySelector");
			Enumerable.CheckNotNull<Func<TOuter, TInner, TResult>>(resultSelector, "resultSelector");
			ILookup<TKey, TInner> lookup = Enumerable.ToLookup<TInner, TKey>(inner, innerKeySelector, comparer);
			return Enumerable.SelectMany<TOuter, TInner, TResult>(outer, (TOuter o) => lookup[outerKeySelector(o)], (TOuter o, TInner i) => resultSelector(o, i));
		}

		// Token: 0x0600032D RID: 813
		// RVA: 0x000080B8 File Offset: 0x000062B8
		[ExtensionAttribute2]
		public static TSource Last<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.LastImpl<TSource>(source, Enumerable.Futures<TSource>.Undefined);
		}

		// Token: 0x0600032E RID: 814
		// RVA: 0x000080C5 File Offset: 0x000062C5
		[ExtensionAttribute2]
		public static TSource Last<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.Last<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600032C RID: 812
		// RVA: 0x0002FE88 File Offset: 0x0002E088
		[ExtensionAttribute2]
		private static TSource LastImpl<TSource>(IEnumerable<TSource> source, Func<TSource> empty)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			IList<TSource> list = source as IList<TSource>;
			if (list == null)
			{
				TSource result;
				using (IEnumerator<TSource> enumerator = source.GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						result = empty();
					}
					else
					{
						TSource current = enumerator.Current;
						while (enumerator.MoveNext())
						{
							current = enumerator.Current;
						}
						result = current;
					}
				}
				return result;
			}
			if (list.Count <= 0)
			{
				return empty();
			}
			return list[list.Count - 1];
		}

		// Token: 0x0600032F RID: 815
		// RVA: 0x000080D3 File Offset: 0x000062D3
		[ExtensionAttribute2]
		public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.LastImpl<TSource>(source, Enumerable.Futures<TSource>.Default);
		}

		// Token: 0x06000330 RID: 816
		// RVA: 0x000080E0 File Offset: 0x000062E0
		[ExtensionAttribute2]
		public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.LastOrDefault<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x06000341 RID: 833
		// RVA: 0x000301B8 File Offset: 0x0002E3B8
		[ExtensionAttribute2]
		public static long LongCount<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Array array = source as Array;
			if (array == null)
			{
				return Enumerable.Aggregate<TSource, long>(source, 0L, (long count, TSource item) => count + 1L);
			}
			return array.LongLength;
		}

		// Token: 0x06000342 RID: 834
		// RVA: 0x00008164 File Offset: 0x00006364
		[ExtensionAttribute2]
		public static long LongCount<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.LongCount<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600038C RID: 908
		// RVA: 0x00030CC8 File Offset: 0x0002EEC8
		[ExtensionAttribute2]
		public static int? Max(IEnumerable<int?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int?>>(source, "source");
			return Enumerable.MinMaxImpl<int>(Enumerable.Where<int?>(source, (int? x) => x.HasValue), null, (int? max, int? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
		}

		// Token: 0x06000398 RID: 920
		// RVA: 0x00030FE0 File Offset: 0x0002F1E0
		[ExtensionAttribute2]
		public static long? Max(IEnumerable<long?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long?>>(source, "source");
			return Enumerable.MinMaxImpl<long>(Enumerable.Where<long?>(source, (long? x) => x.HasValue), null, (long? max, long? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
		}

		// Token: 0x060003A4 RID: 932
		// RVA: 0x000312EC File Offset: 0x0002F4EC
		[ExtensionAttribute2]
		public static float? Max(IEnumerable<float?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float?>>(source, "source");
			return Enumerable.MinMaxImpl<float>(Enumerable.Where<float?>(source, (float? x) => x.HasValue), null, (float? max, float? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
		}

		// Token: 0x060003B0 RID: 944
		// RVA: 0x0003160C File Offset: 0x0002F80C
		[ExtensionAttribute2]
		public static double? Max(IEnumerable<double?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double?>>(source, "source");
			return Enumerable.MinMaxImpl<double>(Enumerable.Where<double?>(source, (double? x) => x.HasValue), null, (double? max, double? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
		}

		// Token: 0x060003BC RID: 956
		// RVA: 0x00031930 File Offset: 0x0002FB30
		[ExtensionAttribute2]
		public static decimal? Max(IEnumerable<decimal?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal?>>(source, "source");
			return Enumerable.MinMaxImpl<decimal>(Enumerable.Where<decimal?>(source, (decimal? x) => x.HasValue), null, (decimal? max, decimal? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
		}

		// Token: 0x06000369 RID: 873
		// RVA: 0x00030740 File Offset: 0x0002E940
		[ExtensionAttribute2]
		public static TSource Max<TSource>(IEnumerable<TSource> source)
		{
			Comparer<TSource> comparer = Comparer<TSource>.Default;
			return Enumerable.MinMaxImpl<TSource>(source, (TSource x, TSource y) => comparer.Compare(x, y) > 0);
		}

		// Token: 0x0600038D RID: 909
		// RVA: 0x00008451 File Offset: 0x00006651
		[ExtensionAttribute2]
		public static int? Max<TSource>(IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			return Enumerable.Max(Enumerable.Select<TSource, int?>(source, selector));
		}

		// Token: 0x06000399 RID: 921
		// RVA: 0x000084A5 File Offset: 0x000066A5
		[ExtensionAttribute2]
		public static long? Max<TSource>(IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			return Enumerable.Max(Enumerable.Select<TSource, long?>(source, selector));
		}

		// Token: 0x060003A5 RID: 933
		// RVA: 0x000084F9 File Offset: 0x000066F9
		[ExtensionAttribute2]
		public static float? Max<TSource>(IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			return Enumerable.Max(Enumerable.Select<TSource, float?>(source, selector));
		}

		// Token: 0x060003B1 RID: 945
		// RVA: 0x0000854D File Offset: 0x0000674D
		[ExtensionAttribute2]
		public static double? Max<TSource>(IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			return Enumerable.Max(Enumerable.Select<TSource, double?>(source, selector));
		}

		// Token: 0x060003BD RID: 957
		// RVA: 0x000085A1 File Offset: 0x000067A1
		[ExtensionAttribute2]
		public static decimal? Max<TSource>(IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			return Enumerable.Max(Enumerable.Select<TSource, decimal?>(source, selector));
		}

		// Token: 0x0600036A RID: 874
		// RVA: 0x000082E6 File Offset: 0x000064E6
		[ExtensionAttribute2]
		public static TResult Max<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return Enumerable.Max<TResult>(Enumerable.Select<TSource, TResult>(source, selector));
		}

		// Token: 0x0600038A RID: 906
		// RVA: 0x00030C60 File Offset: 0x0002EE60
		[ExtensionAttribute2]
		public static int? Min(IEnumerable<int?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int?>>(source, "source");
			return Enumerable.MinMaxImpl<int>(Enumerable.Where<int?>(source, (int? x) => x.HasValue), null, (int? min, int? x) => min < x);
		}

		// Token: 0x06000396 RID: 918
		// RVA: 0x00030F78 File Offset: 0x0002F178
		[ExtensionAttribute2]
		public static long? Min(IEnumerable<long?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long?>>(source, "source");
			return Enumerable.MinMaxImpl<long>(Enumerable.Where<long?>(source, (long? x) => x.HasValue), null, (long? min, long? x) => min < x);
		}

		// Token: 0x060003A2 RID: 930
		// RVA: 0x00031284 File Offset: 0x0002F484
		[ExtensionAttribute2]
		public static float? Min(IEnumerable<float?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float?>>(source, "source");
			return Enumerable.MinMaxImpl<float>(Enumerable.Where<float?>(source, (float? x) => x.HasValue), null, delegate(float? min, float? x)
			{
				float? num = min;
				float? num2 = x;
				return num.GetValueOrDefault() < num2.GetValueOrDefault() && (num.HasValue & num2.HasValue);
			});
		}

		// Token: 0x060003AE RID: 942
		// RVA: 0x000315A4 File Offset: 0x0002F7A4
		[ExtensionAttribute2]
		public static double? Min(IEnumerable<double?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double?>>(source, "source");
			return Enumerable.MinMaxImpl<double>(Enumerable.Where<double?>(source, (double? x) => x.HasValue), null, delegate(double? min, double? x)
			{
				double? num = min;
				double? num2 = x;
				return num.GetValueOrDefault() < num2.GetValueOrDefault() && (num.HasValue & num2.HasValue);
			});
		}

		// Token: 0x060003BA RID: 954
		// RVA: 0x000318C8 File Offset: 0x0002FAC8
		[ExtensionAttribute2]
		public static decimal? Min(IEnumerable<decimal?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal?>>(source, "source");
			return Enumerable.MinMaxImpl<decimal>(Enumerable.Where<decimal?>(source, (decimal? x) => x.HasValue), null, (decimal? min, decimal? x) => min < x);
		}

		// Token: 0x06000367 RID: 871
		// RVA: 0x00030710 File Offset: 0x0002E910
		[ExtensionAttribute2]
		public static TSource Min<TSource>(IEnumerable<TSource> source)
		{
			Comparer<TSource> comparer = Comparer<TSource>.Default;
			return Enumerable.MinMaxImpl<TSource>(source, (TSource x, TSource y) => comparer.Compare(x, y) < 0);
		}

		// Token: 0x0600038B RID: 907
		// RVA: 0x00008443 File Offset: 0x00006643
		[ExtensionAttribute2]
		public static int? Min<TSource>(IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			return Enumerable.Min(Enumerable.Select<TSource, int?>(source, selector));
		}

		// Token: 0x06000397 RID: 919
		// RVA: 0x00008497 File Offset: 0x00006697
		[ExtensionAttribute2]
		public static long? Min<TSource>(IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			return Enumerable.Min(Enumerable.Select<TSource, long?>(source, selector));
		}

		// Token: 0x060003A3 RID: 931
		// RVA: 0x000084EB File Offset: 0x000066EB
		[ExtensionAttribute2]
		public static float? Min<TSource>(IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			return Enumerable.Min(Enumerable.Select<TSource, float?>(source, selector));
		}

		// Token: 0x060003AF RID: 943
		// RVA: 0x0000853F File Offset: 0x0000673F
		[ExtensionAttribute2]
		public static double? Min<TSource>(IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			return Enumerable.Min(Enumerable.Select<TSource, double?>(source, selector));
		}

		// Token: 0x060003BB RID: 955
		// RVA: 0x00008593 File Offset: 0x00006793
		[ExtensionAttribute2]
		public static decimal? Min<TSource>(IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			return Enumerable.Min(Enumerable.Select<TSource, decimal?>(source, selector));
		}

		// Token: 0x06000368 RID: 872
		// RVA: 0x000082D8 File Offset: 0x000064D8
		[ExtensionAttribute2]
		public static TResult Min<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return Enumerable.Min<TResult>(Enumerable.Select<TSource, TResult>(source, selector));
		}

		// Token: 0x06000365 RID: 869
		// RVA: 0x000306A0 File Offset: 0x0002E8A0
		[ExtensionAttribute2]
		private static TSource MinMaxImpl<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, bool> lesser)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			return Enumerable.Aggregate<TSource>(source, delegate(TSource a, TSource item)
			{
				if (!lesser(a, item))
				{
					return item;
				}
				return a;
			});
		}

		// Token: 0x06000366 RID: 870
		// RVA: 0x000306D8 File Offset: 0x0002E8D8
		[ExtensionAttribute2]
		private static TSource? MinMaxImpl<TSource>(IEnumerable<TSource?> source, TSource? seed, Func<TSource?, TSource?, bool> lesser) where TSource : struct
		{
			Enumerable.CheckNotNull<IEnumerable<TSource?>>(source, "source");
			return Enumerable.Aggregate<TSource?, TSource?>(source, seed, delegate(TSource? a, TSource? item)
			{
				if (!lesser(a, item))
				{
					return item;
				}
				return a;
			});
		}

		// Token: 0x06000313 RID: 787
		// RVA: 0x00007FA8 File Offset: 0x000061A8
		[ExtensionAttribute2]
		public static IEnumerable<TResult> OfType<TResult>(IEnumerable source)
		{
			Enumerable.CheckNotNull<IEnumerable>(source, "source");
			return Enumerable.OfTypeYield<TResult>(source);
		}

		// Token: 0x06000314 RID: 788
		// RVA: 0x0002FB88 File Offset: 0x0002DD88
		private static IEnumerable<TResult> OfTypeYield<TResult>(IEnumerable source)
		{
			Enumerable.<OfTypeYield>d__7<TResult> <OfTypeYield>d__ = new Enumerable.<OfTypeYield>d__7<TResult>(-2);
			<OfTypeYield>d__.<>3__source = source;
			return <OfTypeYield>d__;
		}

		// Token: 0x0600036C RID: 876
		// RVA: 0x000082F4 File Offset: 0x000064F4
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.OrderBy<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x0600036D RID: 877
		// RVA: 0x000082FE File Offset: 0x000064FE
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, false);
		}

		// Token: 0x0600036E RID: 878
		// RVA: 0x0000831F File Offset: 0x0000651F
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.OrderByDescending<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x0600036F RID: 879
		// RVA: 0x00008329 File Offset: 0x00006529
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "keySelector");
			return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, true);
		}

		// Token: 0x06000315 RID: 789
		// RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		public static IEnumerable<int> Range(int start, int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", count, null);
			}
			long num = (long)start + (long)count;
			if (num - 1L >= 2147483647L)
			{
				throw new ArgumentOutOfRangeException("count", count, null);
			}
			return Enumerable.RangeYield(start, num);
		}

		// Token: 0x06000316 RID: 790
		// RVA: 0x0002FC00 File Offset: 0x0002DE00
		private static IEnumerable<int> RangeYield(int start, long end)
		{
			Enumerable.<RangeYield>d__e <RangeYield>d__e = new Enumerable.<RangeYield>d__e(-2);
			<RangeYield>d__e.<>3__start = start;
			<RangeYield>d__e.<>3__end = end;
			return <RangeYield>d__e;
		}

		// Token: 0x0600036B RID: 875
		// RVA: 0x00030770 File Offset: 0x0002E970
		[ExtensionAttribute2]
		private static IEnumerable<T> Renumerable<T>(IEnumerator<T> e)
		{
			Enumerable.<Renumerable>d__92<T> <Renumerable>d__ = new Enumerable.<Renumerable>d__92<T>(-2);
			<Renumerable>d__.<>3__e = e;
			return <Renumerable>d__;
		}

		// Token: 0x06000317 RID: 791
		// RVA: 0x00007FBB File Offset: 0x000061BB
		public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", count, null);
			}
			return Enumerable.RepeatYield<TResult>(element, count);
		}

		// Token: 0x06000318 RID: 792
		// RVA: 0x0002FC24 File Offset: 0x0002DE24
		private static IEnumerable<TResult> RepeatYield<TResult>(TResult element, int count)
		{
			Enumerable.<RepeatYield>d__12<TResult> <RepeatYield>d__ = new Enumerable.<RepeatYield>d__12<TResult>(-2);
			<RepeatYield>d__.<>3__element = element;
			<RepeatYield>d__.<>3__count = count;
			return <RepeatYield>d__;
		}

		// Token: 0x06000338 RID: 824
		// RVA: 0x00008124 File Offset: 0x00006324
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			return Enumerable.ReverseYield<TSource>(source);
		}

		// Token: 0x06000339 RID: 825
		// RVA: 0x000300A4 File Offset: 0x0002E2A4
		private static IEnumerable<TSource> ReverseYield<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.<ReverseYield>d__4c<TSource> <ReverseYield>d__4c = new Enumerable.<ReverseYield>d__4c<TSource>(-2);
			<ReverseYield>d__4c.<>3__source = source;
			return <ReverseYield>d__4c;
		}

		// Token: 0x0600031C RID: 796
		// RVA: 0x0002FCA8 File Offset: 0x0002DEA8
		[ExtensionAttribute2]
		public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			Enumerable.CheckNotNull<Func<TSource, TResult>>(selector, "selector");
			return Enumerable.Select<TSource, TResult>(source, (TSource item, int i) => selector(item));
		}

		// Token: 0x0600031D RID: 797
		// RVA: 0x00007FF9 File Offset: 0x000061F9
		[ExtensionAttribute2]
		public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, int, TResult>>(selector, "selector");
			return Enumerable.SelectYield<TSource, TResult>(source, selector);
		}

		// Token: 0x0600031F RID: 799
		// RVA: 0x0002FD08 File Offset: 0x0002DF08
		[ExtensionAttribute2]
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			Enumerable.CheckNotNull<Func<TSource, IEnumerable<TResult>>>(selector, "selector");
			return Enumerable.SelectMany<TSource, TResult>(source, (TSource item, int i) => selector(item));
		}

		// Token: 0x06000320 RID: 800
		// RVA: 0x00008018 File Offset: 0x00006218
		[ExtensionAttribute2]
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			Enumerable.CheckNotNull<Func<TSource, int, IEnumerable<TResult>>>(selector, "selector");
			return Enumerable.SelectMany<TSource, TResult, TResult>(source, selector, (TSource item, TResult subitem) => subitem);
		}

		// Token: 0x06000321 RID: 801
		// RVA: 0x0002FD44 File Offset: 0x0002DF44
		[ExtensionAttribute2]
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			Enumerable.CheckNotNull<Func<TSource, IEnumerable<TCollection>>>(collectionSelector, "collectionSelector");
			return Enumerable.SelectMany<TSource, TCollection, TResult>(source, (TSource item, int i) => collectionSelector(item), resultSelector);
		}

		// Token: 0x06000322 RID: 802
		// RVA: 0x00008038 File Offset: 0x00006238
		[ExtensionAttribute2]
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, int, IEnumerable<TCollection>>>(collectionSelector, "collectionSelector");
			Enumerable.CheckNotNull<Func<TSource, TCollection, TResult>>(resultSelector, "resultSelector");
			return Enumerable.SelectManyYield<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
		}

		// Token: 0x06000323 RID: 803
		// RVA: 0x0002FD84 File Offset: 0x0002DF84
		[ExtensionAttribute2]
		private static IEnumerable<TResult> SelectManyYield<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			Enumerable.<SelectManyYield>d__31<TSource, TCollection, TResult> <SelectManyYield>d__ = new Enumerable.<SelectManyYield>d__31<TSource, TCollection, TResult>(-2);
			<SelectManyYield>d__.<>3__source = source;
			<SelectManyYield>d__.<>3__collectionSelector = collectionSelector;
			<SelectManyYield>d__.<>3__resultSelector = resultSelector;
			return <SelectManyYield>d__;
		}

		// Token: 0x0600031E RID: 798
		// RVA: 0x0002FCE4 File Offset: 0x0002DEE4
		private static IEnumerable<TResult> SelectYield<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			Enumerable.<SelectYield>d__23<TSource, TResult> <SelectYield>d__ = new Enumerable.<SelectYield>d__23<TSource, TResult>(-2);
			<SelectYield>d__.<>3__source = source;
			<SelectYield>d__.<>3__selector = selector;
			return <SelectYield>d__;
		}

		// Token: 0x06000363 RID: 867
		// RVA: 0x000082CE File Offset: 0x000064CE
		[ExtensionAttribute2]
		public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Enumerable.SequenceEqual<TSource>(first, second, null);
		}

		// Token: 0x06000364 RID: 868
		// RVA: 0x000305F4 File Offset: 0x0002E7F4
		[ExtensionAttribute2]
		public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(first, "frist");
			Enumerable.CheckNotNull<IEnumerable<TSource>>(second, "second");
			comparer = (comparer ?? EqualityComparer<TSource>.Default);
			using (IEnumerator<TSource> enumerator = first.GetEnumerator())
			{
				using (IEnumerator<TSource> enumerator2 = second.GetEnumerator())
				{
					bool result;
					while (enumerator.MoveNext())
					{
						if (!enumerator2.MoveNext())
						{
							result = false;
							return result;
						}
						if (!comparer.Equals(enumerator.Current, enumerator2.Current))
						{
							goto IL_72;
						}
					}
					result = !enumerator2.MoveNext();
					return result;
				}
				IL_72:;
			}
			return false;
		}

		// Token: 0x06000332 RID: 818
		// RVA: 0x000080EE File Offset: 0x000062EE
		[ExtensionAttribute2]
		public static TSource Single<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.SingleImpl<TSource>(source, Enumerable.Futures<TSource>.Undefined);
		}

		// Token: 0x06000333 RID: 819
		// RVA: 0x000080FB File Offset: 0x000062FB
		[ExtensionAttribute2]
		public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.Single<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x06000331 RID: 817
		// RVA: 0x0002FF18 File Offset: 0x0002E118
		[ExtensionAttribute2]
		private static TSource SingleImpl<TSource>(IEnumerable<TSource> source, Func<TSource> empty)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			TSource result;
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					TSource current = enumerator.Current;
					if (enumerator.MoveNext())
					{
						throw new InvalidOperationException();
					}
					result = current;
				}
				else
				{
					result = empty();
				}
			}
			return result;
		}

		// Token: 0x06000334 RID: 820
		// RVA: 0x00008109 File Offset: 0x00006309
		[ExtensionAttribute2]
		public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.SingleImpl<TSource>(source, Enumerable.Futures<TSource>.Default);
		}

		// Token: 0x06000335 RID: 821
		// RVA: 0x00008116 File Offset: 0x00006316
		[ExtensionAttribute2]
		public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return Enumerable.SingleOrDefault<TSource>(Enumerable.Where<TSource>(source, predicate));
		}

		// Token: 0x0600033B RID: 827
		// RVA: 0x000300F0 File Offset: 0x0002E2F0
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count)
		{
			return Enumerable.Where<TSource>(source, (TSource item, int i) => i >= count);
		}

		// Token: 0x0600033C RID: 828
		// RVA: 0x0003011C File Offset: 0x0002E31C
		[ExtensionAttribute2]
		public static IEnumerable<TSource> SkipWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Enumerable.CheckNotNull<Func<TSource, bool>>(predicate, "predicate");
			return Enumerable.SkipWhile<TSource>(source, (TSource item, int i) => predicate(item));
		}

		// Token: 0x0600033D RID: 829
		// RVA: 0x00008137 File Offset: 0x00006337
		[ExtensionAttribute2]
		public static IEnumerable<TSource> SkipWhile<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, int, bool>>(predicate, "predicate");
			return Enumerable.SkipWhileYield<TSource>(source, predicate);
		}

		// Token: 0x0600033E RID: 830
		// RVA: 0x00030158 File Offset: 0x0002E358
		private static IEnumerable<TSource> SkipWhileYield<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Enumerable.<SkipWhileYield>d__5c<TSource> <SkipWhileYield>d__5c = new Enumerable.<SkipWhileYield>d__5c<TSource>(-2);
			<SkipWhileYield>d__5c.<>3__source = source;
			<SkipWhileYield>d__5c.<>3__predicate = predicate;
			return <SkipWhileYield>d__5c;
		}

		// Token: 0x06000382 RID: 898
		// RVA: 0x00030A2C File Offset: 0x0002EC2C
		[ExtensionAttribute2]
		public static int Sum(IEnumerable<int> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int>>(source, "source");
			int num = 0;
			checked
			{
				foreach (int current in source)
				{
					num += current;
				}
				return num;
			}
		}

		// Token: 0x06000386 RID: 902
		// RVA: 0x00030B0C File Offset: 0x0002ED0C
		[ExtensionAttribute2]
		public static int? Sum(IEnumerable<int?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<int?>>(source, "source");
			int num = 0;
			checked
			{
				foreach (int? current in source)
				{
					num += (current ?? 0);
				}
				return new int?(num);
			}
		}

		// Token: 0x0600038E RID: 910
		// RVA: 0x00030D30 File Offset: 0x0002EF30
		[ExtensionAttribute2]
		public static long Sum(IEnumerable<long> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long>>(source, "source");
			long num = 0L;
			checked
			{
				foreach (long current in source)
				{
					num += current;
				}
				return num;
			}
		}

		// Token: 0x06000392 RID: 914
		// RVA: 0x00030E14 File Offset: 0x0002F014
		[ExtensionAttribute2]
		public static long? Sum(IEnumerable<long?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<long?>>(source, "source");
			long num = 0L;
			checked
			{
				foreach (long? current in source)
				{
					num += (current ?? 0L);
				}
				return new long?(num);
			}
		}

		// Token: 0x0600039A RID: 922
		// RVA: 0x00031048 File Offset: 0x0002F248
		[ExtensionAttribute2]
		public static float Sum(IEnumerable<float> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float>>(source, "source");
			float num = 0f;
			foreach (float num2 in source)
			{
				num += num2;
			}
			return num;
		}

		// Token: 0x0600039E RID: 926
		// RVA: 0x0003112C File Offset: 0x0002F32C
		[ExtensionAttribute2]
		public static float? Sum(IEnumerable<float?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<float?>>(source, "source");
			float num = 0f;
			foreach (float? current in source)
			{
				float arg_3E_0 = num;
				float? num2 = current;
				num = arg_3E_0 + (num2.HasValue ? num2.GetValueOrDefault() : 0f);
			}
			return new float?(num);
		}

		// Token: 0x060003A6 RID: 934
		// RVA: 0x00031354 File Offset: 0x0002F554
		[ExtensionAttribute2]
		public static double Sum(IEnumerable<double> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double>>(source, "source");
			double num = 0.0;
			foreach (double num2 in source)
			{
				num += num2;
			}
			return num;
		}

		// Token: 0x060003AA RID: 938
		// RVA: 0x00031440 File Offset: 0x0002F640
		[ExtensionAttribute2]
		public static double? Sum(IEnumerable<double?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<double?>>(source, "source");
			double num = 0.0;
			foreach (double? current in source)
			{
				double arg_46_0 = num;
				double? num2 = current;
				num = arg_46_0 + (num2.HasValue ? num2.GetValueOrDefault() : 0.0);
			}
			return new double?(num);
		}

		// Token: 0x060003B2 RID: 946
		// RVA: 0x00031674 File Offset: 0x0002F874
		[ExtensionAttribute2]
		public static decimal Sum(IEnumerable<decimal> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal>>(source, "source");
			decimal num = 0m;
			foreach (decimal current in source)
			{
				num += current;
			}
			return num;
		}

		// Token: 0x060003B6 RID: 950
		// RVA: 0x00031764 File Offset: 0x0002F964
		[ExtensionAttribute2]
		public static decimal? Sum(IEnumerable<decimal?> source)
		{
			Enumerable.CheckNotNull<IEnumerable<decimal?>>(source, "source");
			decimal num = 0m;
			foreach (decimal? current in source)
			{
				num += (current ?? 0m);
			}
			return new decimal?(num);
		}

		// Token: 0x06000383 RID: 899
		// RVA: 0x0000840B File Offset: 0x0000660B
		[ExtensionAttribute2]
		public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, int>(source, selector));
		}

		// Token: 0x06000387 RID: 903
		// RVA: 0x00008427 File Offset: 0x00006627
		[ExtensionAttribute2]
		public static int? Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, int?>(source, selector));
		}

		// Token: 0x0600038F RID: 911
		// RVA: 0x0000845F File Offset: 0x0000665F
		[ExtensionAttribute2]
		public static long Sum<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, long>(source, selector));
		}

		// Token: 0x06000393 RID: 915
		// RVA: 0x0000847B File Offset: 0x0000667B
		[ExtensionAttribute2]
		public static long? Sum<TSource>(IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, long?>(source, selector));
		}

		// Token: 0x0600039B RID: 923
		// RVA: 0x000084B3 File Offset: 0x000066B3
		[ExtensionAttribute2]
		public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, float>(source, selector));
		}

		// Token: 0x0600039F RID: 927
		// RVA: 0x000084CF File Offset: 0x000066CF
		[ExtensionAttribute2]
		public static float? Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, float?>(source, selector));
		}

		// Token: 0x060003A7 RID: 935
		// RVA: 0x00008507 File Offset: 0x00006707
		[ExtensionAttribute2]
		public static double Sum<TSource>(IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, double>(source, selector));
		}

		// Token: 0x060003AB RID: 939
		// RVA: 0x00008523 File Offset: 0x00006723
		[ExtensionAttribute2]
		public static double? Sum<TSource>(IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, double?>(source, selector));
		}

		// Token: 0x060003B3 RID: 947
		// RVA: 0x0000855B File Offset: 0x0000675B
		[ExtensionAttribute2]
		public static decimal Sum<TSource>(IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, decimal>(source, selector));
		}

		// Token: 0x060003B7 RID: 951
		// RVA: 0x00008577 File Offset: 0x00006777
		[ExtensionAttribute2]
		public static decimal? Sum<TSource>(IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			return Enumerable.Sum(Enumerable.Select<TSource, decimal?>(source, selector));
		}

		// Token: 0x0600033A RID: 826
		// RVA: 0x000300C4 File Offset: 0x0002E2C4
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count)
		{
			return Enumerable.Where<TSource>(source, (TSource item, int i) => i < count);
		}

		// Token: 0x06000324 RID: 804
		// RVA: 0x0002FDB0 File Offset: 0x0002DFB0
		[ExtensionAttribute2]
		public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Enumerable.CheckNotNull<Func<TSource, bool>>(predicate, "predicate");
			return Enumerable.TakeWhile<TSource>(source, (TSource item, int i) => predicate(item));
		}

		// Token: 0x06000325 RID: 805
		// RVA: 0x00008063 File Offset: 0x00006263
		[ExtensionAttribute2]
		public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, int, bool>>(predicate, "predicate");
			return Enumerable.TakeWhileYield<TSource>(source, predicate);
		}

		// Token: 0x06000326 RID: 806
		// RVA: 0x0002FDEC File Offset: 0x0002DFEC
		[ExtensionAttribute2]
		private static IEnumerable<TSource> TakeWhileYield<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			int num = 0;
			foreach (TSource current in source)
			{
				TSource arg_88_1 = current;
				int arg;
				num = (arg = num) + 1;
				if (!predicate(arg_88_1, arg))
				{
					break;
				}
				yield return current;
			}
			yield break;
		}

		// Token: 0x06000370 RID: 880
		// RVA: 0x0000834A File Offset: 0x0000654A
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.ThenBy<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x06000371 RID: 881
		// RVA: 0x00008354 File Offset: 0x00006554
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IOrderedEnumerable<TSource>>(source, "source");
			return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, false);
		}

		// Token: 0x06000372 RID: 882
		// RVA: 0x0000836A File Offset: 0x0000656A
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.ThenByDescending<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x06000373 RID: 883
		// RVA: 0x00008374 File Offset: 0x00006574
		[ExtensionAttribute2]
		public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IOrderedEnumerable<TSource>>(source, "source");
			return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, true);
		}

		// Token: 0x06000346 RID: 838
		// RVA: 0x000081A4 File Offset: 0x000063A4
		[ExtensionAttribute2]
		public static TSource[] ToArray<TSource>(IEnumerable<TSource> source)
		{
			return Enumerable.ToList<TSource>(source).ToArray();
		}

		// Token: 0x06000379 RID: 889
		// RVA: 0x000083B4 File Offset: 0x000065B4
		[ExtensionAttribute2]
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.ToDictionary<TSource, TKey>(source, keySelector, null);
		}

		// Token: 0x0600037A RID: 890
		// RVA: 0x000083BE File Offset: 0x000065BE
		[ExtensionAttribute2]
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return Enumerable.ToDictionary<TSource, TKey, TSource>(source, keySelector, (TSource e) => e);
		}

		// Token: 0x0600037B RID: 891
		// RVA: 0x000083D3 File Offset: 0x000065D3
		[ExtensionAttribute2]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return Enumerable.ToDictionary<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
		}

		// Token: 0x0600037C RID: 892
		// RVA: 0x00030898 File Offset: 0x0002EA98
		[ExtensionAttribute2]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			Enumerable.CheckNotNull<Func<TSource, TElement>>(elementSelector, "elementSelector");
			Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
			foreach (TSource current in source)
			{
				dictionary.Add(keySelector(current), elementSelector(current));
			}
			return dictionary;
		}

		// Token: 0x06000345 RID: 837
		// RVA: 0x00008191 File Offset: 0x00006391
		[ExtensionAttribute2]
		public static List<TSource> ToList<TSource>(IEnumerable<TSource> source)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			return new List<TSource>(source);
		}

		// Token: 0x0600034A RID: 842
		// RVA: 0x000081CE File Offset: 0x000063CE
		[ExtensionAttribute2]
		public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return Enumerable.ToLookup<TSource, TKey, TSource>(source, keySelector, (TSource e) => e, null);
		}

		// Token: 0x0600034B RID: 843
		// RVA: 0x000081E4 File Offset: 0x000063E4
		[ExtensionAttribute2]
		public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return Enumerable.ToLookup<TSource, TKey, TSource>(source, keySelector, (TSource e) => e, comparer);
		}

		// Token: 0x0600034C RID: 844
		// RVA: 0x000081FA File Offset: 0x000063FA
		[ExtensionAttribute2]
		public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return Enumerable.ToLookup<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
		}

		// Token: 0x0600034D RID: 845
		// RVA: 0x00030244 File Offset: 0x0002E444
		[ExtensionAttribute2]
		public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, TKey>>(keySelector, "keySelector");
			Enumerable.CheckNotNull<Func<TSource, TElement>>(elementSelector, "elementSelector");
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			foreach (TSource current in source)
			{
				TKey key = keySelector(current);
				Enumerable.Grouping<TKey, TElement> grouping = (Enumerable.Grouping<TKey, TElement>)lookup.Find(key);
				if (grouping == null)
				{
					grouping = new Enumerable.Grouping<TKey, TElement>(key);
					lookup.Add(grouping);
				}
				grouping.Add(elementSelector(current));
			}
			return lookup;
		}

		// Token: 0x06000359 RID: 857
		// RVA: 0x00008289 File Offset: 0x00006489
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Enumerable.Union<TSource>(first, second, null);
		}

		// Token: 0x0600035A RID: 858
		// RVA: 0x00008293 File Offset: 0x00006493
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return Enumerable.Distinct<TSource>(Enumerable.Concat<TSource>(first, second), comparer);
		}

		// Token: 0x06000319 RID: 793
		// RVA: 0x0002FC48 File Offset: 0x0002DE48
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Enumerable.CheckNotNull<Func<TSource, bool>>(predicate, "predicate");
			return Enumerable.Where<TSource>(source, (TSource item, int i) => predicate(item));
		}

		// Token: 0x0600031A RID: 794
		// RVA: 0x00007FDA File Offset: 0x000061DA
		[ExtensionAttribute2]
		public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Enumerable.CheckNotNull<IEnumerable<TSource>>(source, "source");
			Enumerable.CheckNotNull<Func<TSource, int, bool>>(predicate, "predicate");
			return Enumerable.WhereYield<TSource>(source, predicate);
		}

		// Token: 0x0600031B RID: 795
		// RVA: 0x0002FC84 File Offset: 0x0002DE84
		private static IEnumerable<TSource> WhereYield<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Enumerable.<WhereYield>d__19<TSource> <WhereYield>d__ = new Enumerable.<WhereYield>d__19<TSource>(-2);
			<WhereYield>d__.<>3__source = source;
			<WhereYield>d__.<>3__predicate = predicate;
			return <WhereYield>d__;
		}
	}
}
