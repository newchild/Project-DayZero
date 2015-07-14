using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000143 RID: 323
	internal sealed class ThreadSafeStore<TKey, TValue>
	{
		// Token: 0x04000551 RID: 1361
		private readonly Func<TKey, TValue> _creator;

		// Token: 0x0400054F RID: 1359
		private readonly object _lock = new object();

		// Token: 0x04000550 RID: 1360
		private Dictionary<TKey, TValue> _store;

		// Token: 0x06000CCF RID: 3279
		// RVA: 0x0000D9CF File Offset: 0x0000BBCF
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			if (creator == null)
			{
				throw new ArgumentNullException("creator");
			}
			this._creator = creator;
			this._store = new Dictionary<TKey, TValue>();
		}

		// Token: 0x06000CD1 RID: 3281
		// RVA: 0x000492DC File Offset: 0x000474DC
		private TValue AddValue(TKey key)
		{
			TValue tValue = this._creator(key);
			TValue result;
			lock (this._lock)
			{
				if (this._store == null)
				{
					this._store = new Dictionary<TKey, TValue>();
					this._store[key] = tValue;
				}
				else
				{
					TValue tValue2;
					if (this._store.TryGetValue(key, out tValue2))
					{
						result = tValue2;
						return result;
					}
					Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(this._store);
					dictionary[key] = tValue;
					Thread.MemoryBarrier();
					this._store = dictionary;
				}
				result = tValue;
			}
			return result;
		}

		// Token: 0x06000CD0 RID: 3280
		// RVA: 0x000492B4 File Offset: 0x000474B4
		public TValue Get(TKey key)
		{
			TValue result;
			if (!this._store.TryGetValue(key, out result))
			{
				return this.AddValue(key);
			}
			return result;
		}
	}
}
