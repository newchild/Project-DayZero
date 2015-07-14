using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000097 RID: 151
	internal sealed class OrderedEnumerable<T, K> : IEnumerable<T>, IOrderedEnumerable<T>, IEnumerable
	{
		// Token: 0x0400028A RID: 650
		private readonly List<Comparison<T>> _comparisons;

		// Token: 0x04000289 RID: 649
		private readonly IEnumerable<T> _source;

		// Token: 0x060004A4 RID: 1188
		// RVA: 0x00008DF3 File Offset: 0x00006FF3
		public OrderedEnumerable(IEnumerable<T> source, Func<T, K> keySelector, IComparer<K> comparer, bool descending) : this(source, null, keySelector, comparer, descending)
		{
		}

		// Token: 0x060004A5 RID: 1189
		// RVA: 0x00032F54 File Offset: 0x00031154
		private OrderedEnumerable(IEnumerable<T> source, List<Comparison<T>> comparisons, Func<T, K> keySelector, IComparer<K> comparer, bool descending)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			this._source = source;
			comparer = (comparer ?? Comparer<K>.Default);
			if (comparisons == null)
			{
				comparisons = new List<Comparison<T>>(4);
			}
			comparisons.Add((T x, T y) => (descending ? -1 : 1) * comparer.Compare(keySelector(x), keySelector(y)));
			this._comparisons = comparisons;
		}

		// Token: 0x060004A6 RID: 1190
		// RVA: 0x00008E01 File Offset: 0x00007001
		public IOrderedEnumerable<T> CreateOrderedEnumerable<KK>(Func<T, KK> keySelector, IComparer<KK> comparer, bool descending)
		{
			return new OrderedEnumerable<T, KK>(this._source, this._comparisons, keySelector, comparer, descending);
		}

		// Token: 0x060004A7 RID: 1191
		// RVA: 0x00032FEC File Offset: 0x000311EC
		public IEnumerator<T> GetEnumerator()
		{
			List<Tuple<T, int>> list = Enumerable.ToList<Tuple<T, int>>(Enumerable.Select<T, Tuple<T, int>>(this._source, new Func<T, int, Tuple<T, int>>(OrderedEnumerable<T, K>.TagPosition)));
			list.Sort(delegate(Tuple<T, int> x, Tuple<T, int> y)
			{
				List<Comparison<T>> comparisons = this._comparisons;
				for (int i = 0; i < comparisons.Count; i++)
				{
					int num = comparisons[i](x.First, y.First);
					if (num != 0)
					{
						return num;
					}
				}
				return x.Second.CompareTo(y.Second);
			});
			return Enumerable.Select<Tuple<T, int>, T>(list, new Func<Tuple<T, int>, T>(OrderedEnumerable<T, K>.GetFirst)).GetEnumerator();
		}

		// Token: 0x060004A9 RID: 1193
		// RVA: 0x00008E20 File Offset: 0x00007020
		private static T GetFirst(Tuple<T, int> pv)
		{
			return pv.First;
		}

		// Token: 0x060004AA RID: 1194
		// RVA: 0x00008E29 File Offset: 0x00007029
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060004A8 RID: 1192
		// RVA: 0x00008E17 File Offset: 0x00007017
		private static Tuple<T, int> TagPosition(T e, int i)
		{
			return new Tuple<T, int>(e, i);
		}
	}
}
