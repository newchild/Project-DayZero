using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000095 RID: 149
	internal sealed class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, ILookup<TKey, TElement>, IEnumerable
	{
		// Token: 0x04000280 RID: 640
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> _map;

		// Token: 0x170000A5 RID: 165
		public int Count
		{
			// Token: 0x06000495 RID: 1173
			// RVA: 0x00008D63 File Offset: 0x00006F63
			get
			{
				return this._map.Count;
			}
		}

		// Token: 0x170000A6 RID: 166
		public IEnumerable<TElement> this[TKey key]
		{
			// Token: 0x06000496 RID: 1174
			// RVA: 0x00032D98 File Offset: 0x00030F98
			get
			{
				IGrouping<TKey, TElement> result;
				if (!this._map.TryGetValue(key, out result))
				{
					return Enumerable.Empty<TElement>();
				}
				return result;
			}
		}

		// Token: 0x06000492 RID: 1170
		// RVA: 0x00008D3B File Offset: 0x00006F3B
		internal Lookup(IEqualityComparer<TKey> comparer)
		{
			this._map = new Dictionary<TKey, IGrouping<TKey, TElement>>(comparer);
		}

		// Token: 0x06000493 RID: 1171
		// RVA: 0x00008D4F File Offset: 0x00006F4F
		internal void Add(IGrouping<TKey, TElement> item)
		{
			this._map.Add(item.Key, item);
		}

		// Token: 0x06000498 RID: 1176
		// RVA: 0x00032DBC File Offset: 0x00030FBC
		public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			Lookup<TKey, TElement>.<ApplyResultSelector>d__0<TResult> <ApplyResultSelector>d__ = new Lookup<TKey, TElement>.<ApplyResultSelector>d__0<TResult>(-2);
			<ApplyResultSelector>d__.<>4__this = this;
			<ApplyResultSelector>d__.<>3__resultSelector = resultSelector;
			return <ApplyResultSelector>d__;
		}

		// Token: 0x06000497 RID: 1175
		// RVA: 0x00008D70 File Offset: 0x00006F70
		public bool Contains(TKey key)
		{
			return this._map.ContainsKey(key);
		}

		// Token: 0x06000494 RID: 1172
		// RVA: 0x00032D78 File Offset: 0x00030F78
		internal IEnumerable<TElement> Find(TKey key)
		{
			IGrouping<TKey, TElement> result;
			if (!this._map.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06000499 RID: 1177
		// RVA: 0x00008D7E File Offset: 0x00006F7E
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return this._map.Values.GetEnumerator();
		}

		// Token: 0x0600049A RID: 1178
		// RVA: 0x00008D95 File Offset: 0x00006F95
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
