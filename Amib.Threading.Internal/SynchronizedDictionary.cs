using System;
using System.Collections.Generic;

namespace Amib.Threading.Internal
{
	// Token: 0x02000335 RID: 821
	internal sealed class SynchronizedDictionary<TKey, TValue>
	{
		// Token: 0x040012CA RID: 4810
		private readonly Dictionary<TKey, TValue> _dictionary;

		// Token: 0x040012CB RID: 4811
		private readonly object _lock;

		// Token: 0x1700034A RID: 842
		public int Count
		{
			// Token: 0x06001853 RID: 6227
			// RVA: 0x00014E30 File Offset: 0x00013030
			get
			{
				return this._dictionary.Count;
			}
		}

		// Token: 0x17000349 RID: 841
		public TValue this[TKey gparam_0]
		{
			// Token: 0x06001857 RID: 6231
			// RVA: 0x000750C4 File Offset: 0x000732C4
			get
			{
				TValue result;
				lock (this._lock)
				{
					result = this._dictionary[gparam_0];
				}
				return result;
			}
			// Token: 0x06001858 RID: 6232
			// RVA: 0x00075108 File Offset: 0x00073308
			set
			{
				lock (this._lock)
				{
					this._dictionary[gparam_0] = value;
				}
			}
		}

		// Token: 0x1700034C RID: 844
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			// Token: 0x06001859 RID: 6233
			// RVA: 0x00075148 File Offset: 0x00073348
			get
			{
				Dictionary<TKey, TValue>.KeyCollection keys;
				lock (this._lock)
				{
					keys = this._dictionary.Keys;
				}
				return keys;
			}
		}

		// Token: 0x1700034B RID: 843
		public object SyncRoot
		{
			// Token: 0x06001856 RID: 6230
			// RVA: 0x00014E3D File Offset: 0x0001303D
			get
			{
				return this._lock;
			}
		}

		// Token: 0x1700034D RID: 845
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			// Token: 0x0600185A RID: 6234
			// RVA: 0x00075188 File Offset: 0x00073388
			get
			{
				Dictionary<TKey, TValue>.ValueCollection values;
				lock (this._lock)
				{
					values = this._dictionary.Values;
				}
				return values;
			}
		}

		// Token: 0x06001852 RID: 6226
		// RVA: 0x00014E12 File Offset: 0x00013012
		public SynchronizedDictionary()
		{
			this._lock = new object();
			this._dictionary = new Dictionary<TKey, TValue>();
		}

		// Token: 0x0600185B RID: 6235
		// RVA: 0x000751C8 File Offset: 0x000733C8
		public void Clear()
		{
			lock (this._lock)
			{
				this._dictionary.Clear();
			}
		}

		// Token: 0x06001854 RID: 6228
		// RVA: 0x00075040 File Offset: 0x00073240
		public bool Contains(TKey gparam_0)
		{
			bool result;
			lock (this._lock)
			{
				result = this._dictionary.ContainsKey(gparam_0);
			}
			return result;
		}

		// Token: 0x06001855 RID: 6229
		// RVA: 0x00075084 File Offset: 0x00073284
		public void Remove(TKey gparam_0)
		{
			lock (this._lock)
			{
				this._dictionary.Remove(gparam_0);
			}
		}
	}
}
