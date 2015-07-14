using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200014E RID: 334
	internal sealed class CollectionWrapper<T> : IEnumerable<T>, IEnumerable, ICollection<T>, IList, ICollection, IWrappedCollection
	{
		// Token: 0x0400059A RID: 1434
		private readonly ICollection<T> _genericCollection;

		// Token: 0x04000599 RID: 1433
		private readonly IList _list;

		// Token: 0x0400059B RID: 1435
		private object _syncRoot;

		// Token: 0x17000261 RID: 609
		public virtual int Count
		{
			// Token: 0x06000CFE RID: 3326
			// RVA: 0x0000DC0C File Offset: 0x0000BE0C
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.Count;
				}
				return this._list.Count;
			}
		}

		// Token: 0x17000262 RID: 610
		public virtual bool IsReadOnly
		{
			// Token: 0x06000CFF RID: 3327
			// RVA: 0x0000DC2D File Offset: 0x0000BE2D
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsReadOnly;
			}
		}

		// Token: 0x17000265 RID: 613
		bool ICollection.IsSynchronized
		{
			// Token: 0x06000D0D RID: 3341
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000266 RID: 614
		object ICollection.SyncRoot
		{
			// Token: 0x06000D0E RID: 3342
			// RVA: 0x0000DDEB File Offset: 0x0000BFEB
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x17000263 RID: 611
		bool IList.IsFixedSize
		{
			// Token: 0x06000D08 RID: 3336
			// RVA: 0x0000DD51 File Offset: 0x0000BF51
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsFixedSize;
			}
		}

		// Token: 0x17000264 RID: 612
		object IList.this[int index]
		{
			// Token: 0x06000D0A RID: 3338
			// RVA: 0x0000DD89 File Offset: 0x0000BF89
			get
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				return this._list[index];
			}
			// Token: 0x06000D0B RID: 3339
			// RVA: 0x0000DDAA File Offset: 0x0000BFAA
			set
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				CollectionWrapper<T>.VerifyValueType(value);
				this._list[index] = (T)((object)value);
			}
		}

		// Token: 0x17000267 RID: 615
		public object UnderlyingCollection
		{
			// Token: 0x06000D11 RID: 3345
			// RVA: 0x0000DE6E File Offset: 0x0000C06E
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection;
				}
				return this._list;
			}
		}

		// Token: 0x06000CF8 RID: 3320
		// RVA: 0x0000DB2C File Offset: 0x0000BD2C
		public CollectionWrapper(IList list)
		{
			ValidationUtils.ArgumentNotNull(list, "list");
			if (list is ICollection<T>)
			{
				this._genericCollection = (ICollection<T>)list;
				return;
			}
			this._list = list;
		}

		// Token: 0x06000CF9 RID: 3321
		// RVA: 0x0000DB5B File Offset: 0x0000BD5B
		public CollectionWrapper(ICollection<T> list)
		{
			ValidationUtils.ArgumentNotNull(list, "list");
			this._genericCollection = list;
		}

		// Token: 0x06000CFA RID: 3322
		// RVA: 0x0000DB75 File Offset: 0x0000BD75
		public virtual void Add(T item)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Add(item);
				return;
			}
			this._list.Add(item);
		}

		// Token: 0x06000CFB RID: 3323
		// RVA: 0x0000DB9E File Offset: 0x0000BD9E
		public virtual void Clear()
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Clear();
				return;
			}
			this._list.Clear();
		}

		// Token: 0x06000CFC RID: 3324
		// RVA: 0x0000DBBF File Offset: 0x0000BDBF
		public virtual bool Contains(T item)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Contains(item);
			}
			return this._list.Contains(item);
		}

		// Token: 0x06000CFD RID: 3325
		// RVA: 0x0000DBE7 File Offset: 0x0000BDE7
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.CopyTo(array, arrayIndex);
				return;
			}
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000D01 RID: 3329
		// RVA: 0x0000DC4E File Offset: 0x0000BE4E
		public virtual IEnumerator<T> GetEnumerator()
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.GetEnumerator();
			}
			return Enumerable.Cast<T>(this._list).GetEnumerator();
		}

		// Token: 0x06000D10 RID: 3344
		// RVA: 0x0000DE3C File Offset: 0x0000C03C
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && (!TypeExtensions.IsValueType(typeof(T)) || ReflectionUtils.IsNullableType(typeof(T))));
		}

		// Token: 0x06000D00 RID: 3328
		// RVA: 0x0004A174 File Offset: 0x00048374
		public virtual bool Remove(T item)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Remove(item);
			}
			bool result;
			if (result = this._list.Contains(item))
			{
				this._list.Remove(item);
			}
			return result;
		}

		// Token: 0x06000D0C RID: 3340
		// RVA: 0x0000DDDC File Offset: 0x0000BFDC
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			this.CopyTo((T[])array, arrayIndex);
		}

		// Token: 0x06000D02 RID: 3330
		// RVA: 0x0000DC74 File Offset: 0x0000BE74
		IEnumerator IEnumerable.GetEnumerator()
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.GetEnumerator();
			}
			return this._list.GetEnumerator();
		}

		// Token: 0x06000D03 RID: 3331
		// RVA: 0x0000DC95 File Offset: 0x0000BE95
		int IList.Add(object value)
		{
			CollectionWrapper<T>.VerifyValueType(value);
			this.Add((T)((object)value));
			return this.Count - 1;
		}

		// Token: 0x06000D04 RID: 3332
		// RVA: 0x0000DCB1 File Offset: 0x0000BEB1
		bool IList.Contains(object value)
		{
			return CollectionWrapper<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		// Token: 0x06000D05 RID: 3333
		// RVA: 0x0000DCC9 File Offset: 0x0000BEC9
		int IList.IndexOf(object value)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
			}
			if (CollectionWrapper<T>.IsCompatibleObject(value))
			{
				return this._list.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x06000D07 RID: 3335
		// RVA: 0x0000DD1F File Offset: 0x0000BF1F
		void IList.Insert(int index, object value)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
			}
			CollectionWrapper<T>.VerifyValueType(value);
			this._list.Insert(index, (T)((object)value));
		}

		// Token: 0x06000D09 RID: 3337
		// RVA: 0x0000DD72 File Offset: 0x0000BF72
		void IList.Remove(object value)
		{
			if (CollectionWrapper<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x06000D06 RID: 3334
		// RVA: 0x0000DCFE File Offset: 0x0000BEFE
		void IList.RemoveAt(int index)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
			}
			this._list.RemoveAt(index);
		}

		// Token: 0x06000D0F RID: 3343
		// RVA: 0x0000DE0D File Offset: 0x0000C00D
		private static void VerifyValueType(object value)
		{
			if (!CollectionWrapper<T>.IsCompatibleObject(value))
			{
				throw new ArgumentException(StringUtils.FormatWith("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", CultureInfo.InvariantCulture, value, typeof(T)), "value");
			}
		}
	}
}
