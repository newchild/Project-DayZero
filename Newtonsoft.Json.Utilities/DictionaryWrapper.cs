using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000151 RID: 337
	internal sealed class DictionaryWrapper<TKey, TValue> : IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, ICollection, IDictionary, IWrappedDictionary
	{
		// Token: 0x02000152 RID: 338
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x040005A8 RID: 1448
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			// Token: 0x17000278 RID: 632
			public object Current
			{
				// Token: 0x06000D4F RID: 3407
				// RVA: 0x0004ACD8 File Offset: 0x00048ED8
				get
				{
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> current = this._e.Current;
					object arg_30_0 = current.Key;
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> current2 = this._e.Current;
					return new DictionaryEntry(arg_30_0, current2.Value);
				}
			}

			// Token: 0x17000275 RID: 629
			public DictionaryEntry Entry
			{
				// Token: 0x06000D4C RID: 3404
				// RVA: 0x0000E387 File Offset: 0x0000C587
				get
				{
					return (DictionaryEntry)this.Current;
				}
			}

			// Token: 0x17000276 RID: 630
			public object Key
			{
				// Token: 0x06000D4D RID: 3405
				// RVA: 0x0004ACA0 File Offset: 0x00048EA0
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x17000277 RID: 631
			public object Value
			{
				// Token: 0x06000D4E RID: 3406
				// RVA: 0x0004ACBC File Offset: 0x00048EBC
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x06000D4B RID: 3403
			// RVA: 0x0000E373 File Offset: 0x0000C573
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				ValidationUtils.ArgumentNotNull(e, "e");
				this._e = e;
			}

			// Token: 0x06000D50 RID: 3408
			// RVA: 0x0000E394 File Offset: 0x0000C594
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x06000D51 RID: 3409
			// RVA: 0x0000E3A1 File Offset: 0x0000C5A1
			public void Reset()
			{
				this._e.Reset();
			}
		}

		// Token: 0x040005A4 RID: 1444
		private readonly IDictionary _dictionary;

		// Token: 0x040005A5 RID: 1445
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		// Token: 0x040005A6 RID: 1446
		private object _syncRoot;

		// Token: 0x1700026C RID: 620
		public int Count
		{
			// Token: 0x06000D38 RID: 3384
			// RVA: 0x0000E126 File Offset: 0x0000C326
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Count;
				}
				return this._genericDictionary.Count;
			}
		}

		// Token: 0x1700026D RID: 621
		public bool IsReadOnly
		{
			// Token: 0x06000D39 RID: 3385
			// RVA: 0x0000E147 File Offset: 0x0000C347
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.IsReadOnly;
				}
				return this._genericDictionary.IsReadOnly;
			}
		}

		// Token: 0x1700026B RID: 619
		public TValue this[TKey key]
		{
			// Token: 0x06000D32 RID: 3378
			// RVA: 0x0000E046 File Offset: 0x0000C246
			get
			{
				if (this._dictionary != null)
				{
					return (TValue)((object)this._dictionary[key]);
				}
				return this._genericDictionary[key];
			}
			// Token: 0x06000D33 RID: 3379
			// RVA: 0x0000E073 File Offset: 0x0000C273
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[key] = value;
					return;
				}
				this._genericDictionary[key] = value;
			}
		}

		// Token: 0x17000269 RID: 617
		public ICollection<TKey> Keys
		{
			// Token: 0x06000D2E RID: 3374
			// RVA: 0x0000DFB2 File Offset: 0x0000C1B2
			get
			{
				if (this._dictionary != null)
				{
					return Enumerable.ToList<TKey>(Enumerable.Cast<TKey>(this._dictionary.Keys));
				}
				return this._genericDictionary.Keys;
			}
		}

		// Token: 0x17000272 RID: 626
		bool ICollection.IsSynchronized
		{
			// Token: 0x06000D47 RID: 3399
			// RVA: 0x0000E304 File Offset: 0x0000C504
			get
			{
				return this._dictionary != null && this._dictionary.IsSynchronized;
			}
		}

		// Token: 0x17000273 RID: 627
		object ICollection.SyncRoot
		{
			// Token: 0x06000D48 RID: 3400
			// RVA: 0x0000E31B File Offset: 0x0000C51B
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x1700026F RID: 623
		bool IDictionary.IsFixedSize
		{
			// Token: 0x06000D42 RID: 3394
			// RVA: 0x0000E24E File Offset: 0x0000C44E
			get
			{
				return this._genericDictionary == null && this._dictionary.IsFixedSize;
			}
		}

		// Token: 0x1700026E RID: 622
		object IDictionary.this[object key]
		{
			// Token: 0x06000D3E RID: 3390
			// RVA: 0x0000E19F File Offset: 0x0000C39F
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary[key];
				}
				return this._genericDictionary[(TKey)((object)key)];
			}
			// Token: 0x06000D3F RID: 3391
			// RVA: 0x0000E1CC File Offset: 0x0000C3CC
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[key] = value;
					return;
				}
				this._genericDictionary[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		// Token: 0x17000270 RID: 624
		ICollection IDictionary.Keys
		{
			// Token: 0x06000D43 RID: 3395
			// RVA: 0x0000E265 File Offset: 0x0000C465
			get
			{
				if (this._genericDictionary != null)
				{
					return Enumerable.ToList<TKey>(this._genericDictionary.Keys);
				}
				return this._dictionary.Keys;
			}
		}

		// Token: 0x17000271 RID: 625
		ICollection IDictionary.Values
		{
			// Token: 0x06000D45 RID: 3397
			// RVA: 0x0000E2B4 File Offset: 0x0000C4B4
			get
			{
				if (this._genericDictionary != null)
				{
					return Enumerable.ToList<TValue>(this._genericDictionary.Values);
				}
				return this._dictionary.Values;
			}
		}

		// Token: 0x17000274 RID: 628
		public object UnderlyingDictionary
		{
			// Token: 0x06000D49 RID: 3401
			// RVA: 0x0000E33D File Offset: 0x0000C53D
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary;
				}
				return this._genericDictionary;
			}
		}

		// Token: 0x1700026A RID: 618
		public ICollection<TValue> Values
		{
			// Token: 0x06000D31 RID: 3377
			// RVA: 0x0000E01B File Offset: 0x0000C21B
			get
			{
				if (this._dictionary != null)
				{
					return Enumerable.ToList<TValue>(Enumerable.Cast<TValue>(this._dictionary.Values));
				}
				return this._genericDictionary.Values;
			}
		}

		// Token: 0x06000D2A RID: 3370
		// RVA: 0x0000DF19 File Offset: 0x0000C119
		public DictionaryWrapper(IDictionary dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			this._dictionary = dictionary;
		}

		// Token: 0x06000D2B RID: 3371
		// RVA: 0x0000DF33 File Offset: 0x0000C133
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			this._genericDictionary = dictionary;
		}

		// Token: 0x06000D34 RID: 3380
		// RVA: 0x0000E0A2 File Offset: 0x0000C2A2
		public void Add(KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary != null)
			{
				((IList)this._dictionary).Add(item);
				return;
			}
			if (this._genericDictionary != null)
			{
				this._genericDictionary.Add(item);
			}
		}

		// Token: 0x06000D2C RID: 3372
		// RVA: 0x0000DF4D File Offset: 0x0000C14D
		public void Add(TKey key, TValue value)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(key, value);
				return;
			}
			if (this._genericDictionary == null)
			{
				throw new NotSupportedException();
			}
			this._genericDictionary.Add(key, value);
		}

		// Token: 0x06000D35 RID: 3381
		// RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public void Clear()
		{
			if (this._dictionary != null)
			{
				this._dictionary.Clear();
				return;
			}
			this._genericDictionary.Clear();
		}

		// Token: 0x06000D36 RID: 3382
		// RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary != null)
			{
				return ((IList)this._dictionary).Contains(item);
			}
			return this._genericDictionary.Contains(item);
		}

		// Token: 0x06000D2D RID: 3373
		// RVA: 0x0000DF8A File Offset: 0x0000C18A
		public bool ContainsKey(TKey key)
		{
			if (this._dictionary != null)
			{
				return this._dictionary.Contains(key);
			}
			return this._genericDictionary.ContainsKey(key);
		}

		// Token: 0x06000D37 RID: 3383
		// RVA: 0x0004AB30 File Offset: 0x00048D30
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			if (this._dictionary != null)
			{
				IDictionaryEnumerator enumerator = this._dictionary.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
						array[arrayIndex++] = new KeyValuePair<TKey, TValue>((TKey)((object)dictionaryEntry.Key), (TValue)((object)dictionaryEntry.Value));
					}
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			this._genericDictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000D3B RID: 3387
		// RVA: 0x0004AC4C File Offset: 0x00048E4C
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			if (this._dictionary != null)
			{
				return Enumerable.Select<DictionaryEntry, KeyValuePair<TKey, TValue>>(Enumerable.Cast<DictionaryEntry>(this._dictionary), (DictionaryEntry de) => new KeyValuePair<TKey, TValue>((TKey)((object)de.Key), (TValue)((object)de.Value))).GetEnumerator();
			}
			return this._genericDictionary.GetEnumerator();
		}

		// Token: 0x06000D2F RID: 3375
		// RVA: 0x0000DFDD File Offset: 0x0000C1DD
		public bool Remove(TKey key)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.Remove(key);
			}
			if (this._dictionary.Contains(key))
			{
				this._dictionary.Remove(key);
				return true;
			}
			return false;
		}

		// Token: 0x06000D3A RID: 3386
		// RVA: 0x0004ABC8 File Offset: 0x00048DC8
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.Remove(item);
			}
			if (!this._dictionary.Contains(item.Key))
			{
				return true;
			}
			object objA = this._dictionary[item.Key];
			if (object.Equals(objA, item.Value))
			{
				this._dictionary.Remove(item.Key);
				return true;
			}
			return false;
		}

		// Token: 0x06000D44 RID: 3396
		// RVA: 0x0000E28B File Offset: 0x0000C48B
		public void Remove(object key)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Remove(key);
				return;
			}
			this._genericDictionary.Remove((TKey)((object)key));
		}

		// Token: 0x06000D46 RID: 3398
		// RVA: 0x0000E2DA File Offset: 0x0000C4DA
		void ICollection.CopyTo(Array array, int index)
		{
			if (this._dictionary != null)
			{
				this._dictionary.CopyTo(array, index);
				return;
			}
			this._genericDictionary.CopyTo((KeyValuePair<TKey, TValue>[])array, index);
		}

		// Token: 0x06000D3D RID: 3389
		// RVA: 0x0000E170 File Offset: 0x0000C370
		void IDictionary.Add(object key, object value)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(key, value);
				return;
			}
			this._genericDictionary.Add((TKey)((object)key), (TValue)((object)value));
		}

		// Token: 0x06000D41 RID: 3393
		// RVA: 0x0000E226 File Offset: 0x0000C426
		bool IDictionary.Contains(object key)
		{
			if (this._genericDictionary != null)
			{
				return this._genericDictionary.ContainsKey((TKey)((object)key));
			}
			return this._dictionary.Contains(key);
		}

		// Token: 0x06000D40 RID: 3392
		// RVA: 0x0000E1FB File Offset: 0x0000C3FB
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			if (this._dictionary != null)
			{
				return this._dictionary.GetEnumerator();
			}
			return new DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TKey, TValue>(this._genericDictionary.GetEnumerator());
		}

		// Token: 0x06000D3C RID: 3388
		// RVA: 0x0000E168 File Offset: 0x0000C368
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000D30 RID: 3376
		// RVA: 0x0004AAD4 File Offset: 0x00048CD4
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.TryGetValue(key, out value);
			}
			if (!this._dictionary.Contains(key))
			{
				value = default(TValue);
				return false;
			}
			value = (TValue)((object)this._dictionary[key]);
			return true;
		}
	}
}
