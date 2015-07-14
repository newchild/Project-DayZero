using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000DB RID: 219
	public abstract class JContainer : JToken, IEnumerable<JToken>, IEnumerable, IList<JToken>, ICollection<JToken>, IBindingList, IList, ICollection, ITypedList
	{
		// Token: 0x020000DC RID: 220
		private sealed class JTokenReferenceEqualityComparer : IEqualityComparer<JToken>
		{
			// Token: 0x040003B3 RID: 947
			public static readonly JContainer.JTokenReferenceEqualityComparer Instance = new JContainer.JTokenReferenceEqualityComparer();

			// Token: 0x060008B4 RID: 2228
			// RVA: 0x0000B3BA File Offset: 0x000095BA
			public bool Equals(JToken x, JToken y)
			{
				return object.ReferenceEquals(x, y);
			}

			// Token: 0x060008B5 RID: 2229
			// RVA: 0x0000B3C3 File Offset: 0x000095C3
			public int GetHashCode(JToken obj)
			{
				if (obj == null)
				{
					return 0;
				}
				return obj.GetHashCode();
			}
		}

		// Token: 0x040003B0 RID: 944
		internal AddingNewEventHandler _addingNew;

		// Token: 0x040003B2 RID: 946
		private bool _busy;

		// Token: 0x040003AF RID: 943
		internal ListChangedEventHandler _listChanged;

		// Token: 0x040003B1 RID: 945
		private object _syncRoot;

		// Token: 0x14000004 RID: 4
		public event AddingNewEventHandler AddingNew
		{
			// Token: 0x06000859 RID: 2137
			// RVA: 0x0000B0A5 File Offset: 0x000092A5
			add
			{
				this._addingNew = (AddingNewEventHandler)Delegate.Combine(this._addingNew, value);
			}
			// Token: 0x0600085A RID: 2138
			// RVA: 0x0000B0BE File Offset: 0x000092BE
			remove
			{
				this._addingNew = (AddingNewEventHandler)Delegate.Remove(this._addingNew, value);
			}
		}

		// Token: 0x14000003 RID: 3
		public event ListChangedEventHandler ListChanged
		{
			// Token: 0x06000857 RID: 2135
			// RVA: 0x0000B073 File Offset: 0x00009273
			add
			{
				this._listChanged = (ListChangedEventHandler)Delegate.Combine(this._listChanged, value);
			}
			// Token: 0x06000858 RID: 2136
			// RVA: 0x0000B08C File Offset: 0x0000928C
			remove
			{
				this._listChanged = (ListChangedEventHandler)Delegate.Remove(this._listChanged, value);
			}
		}

		// Token: 0x17000162 RID: 354
		protected abstract IList<JToken> ChildrenTokens
		{
			// Token: 0x0600085B RID: 2139
			get;
		}

		// Token: 0x1700016B RID: 363
		public int Count
		{
			// Token: 0x060008A1 RID: 2209
			// RVA: 0x0000B38B File Offset: 0x0000958B
			get
			{
				return this.ChildrenTokens.Count;
			}
		}

		// Token: 0x17000164 RID: 356
		public override JToken First
		{
			// Token: 0x06000864 RID: 2148
			// RVA: 0x0000B11B File Offset: 0x0000931B
			get
			{
				return Enumerable.FirstOrDefault<JToken>(this.ChildrenTokens);
			}
		}

		// Token: 0x17000163 RID: 355
		public override bool HasValues
		{
			// Token: 0x06000862 RID: 2146
			// RVA: 0x0000B10B File Offset: 0x0000930B
			get
			{
				return this.ChildrenTokens.Count > 0;
			}
		}

		// Token: 0x17000165 RID: 357
		public override JToken Last
		{
			// Token: 0x06000865 RID: 2149
			// RVA: 0x0000B128 File Offset: 0x00009328
			get
			{
				return Enumerable.LastOrDefault<JToken>(this.ChildrenTokens);
			}
		}

		// Token: 0x17000167 RID: 359
		bool ICollection<JToken>.IsReadOnly
		{
			// Token: 0x06000892 RID: 2194
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000166 RID: 358
		JToken IList<JToken>.this[int index]
		{
			// Token: 0x0600088C RID: 2188
			// RVA: 0x0000B2CD File Offset: 0x000094CD
			get
			{
				return this.GetItem(index);
			}
			// Token: 0x0600088D RID: 2189
			// RVA: 0x0000B2D6 File Offset: 0x000094D6
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x1700016C RID: 364
		bool ICollection.IsSynchronized
		{
			// Token: 0x060008A2 RID: 2210
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x1700016D RID: 365
		object ICollection.SyncRoot
		{
			// Token: 0x060008A3 RID: 2211
			// RVA: 0x0000B398 File Offset: 0x00009598
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x17000168 RID: 360
		bool IList.IsFixedSize
		{
			// Token: 0x0600089A RID: 2202
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000169 RID: 361
		bool IList.IsReadOnly
		{
			// Token: 0x0600089B RID: 2203
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x1700016A RID: 362
		object IList.this[int index]
		{
			// Token: 0x0600089E RID: 2206
			// RVA: 0x0000B2CD File Offset: 0x000094CD
			get
			{
				return this.GetItem(index);
			}
			// Token: 0x0600089F RID: 2207
			// RVA: 0x0000B37B File Offset: 0x0000957B
			set
			{
				this.SetItem(index, this.EnsureValue(value));
			}
		}

		// Token: 0x1700016E RID: 366
		bool IBindingList.AllowEdit
		{
			// Token: 0x060008A6 RID: 2214
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x1700016F RID: 367
		bool IBindingList.AllowNew
		{
			// Token: 0x060008A7 RID: 2215
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x17000170 RID: 368
		bool IBindingList.AllowRemove
		{
			// Token: 0x060008A8 RID: 2216
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x17000171 RID: 369
		bool IBindingList.IsSorted
		{
			// Token: 0x060008AB RID: 2219
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000172 RID: 370
		ListSortDirection IBindingList.SortDirection
		{
			// Token: 0x060008AE RID: 2222
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x17000173 RID: 371
		PropertyDescriptor IBindingList.SortProperty
		{
			// Token: 0x060008AF RID: 2223
			// RVA: 0x00006D2A File Offset: 0x00004F2A
			get
			{
				return null;
			}
		}

		// Token: 0x17000174 RID: 372
		bool IBindingList.SupportsChangeNotification
		{
			// Token: 0x060008B0 RID: 2224
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x17000175 RID: 373
		bool IBindingList.SupportsSearching
		{
			// Token: 0x060008B1 RID: 2225
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000176 RID: 374
		bool IBindingList.SupportsSorting
		{
			// Token: 0x060008B2 RID: 2226
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x0600085C RID: 2140
		// RVA: 0x0000B0D7 File Offset: 0x000092D7
		internal JContainer()
		{
		}

		// Token: 0x0600085D RID: 2141
		// RVA: 0x0003C704 File Offset: 0x0003A904
		internal JContainer(JContainer other) : this()
		{
			ValidationUtils.ArgumentNotNull(other, "c");
			int num = 0;
			foreach (JToken current in ((IEnumerable<JToken>)other))
			{
				this.AddInternal(num, current, false);
				num++;
			}
		}

		// Token: 0x06000879 RID: 2169
		// RVA: 0x0000B226 File Offset: 0x00009426
		public virtual void Add(object content)
		{
			this.AddInternal(this.ChildrenTokens.Count, content, false);
		}

		// Token: 0x0600087A RID: 2170
		// RVA: 0x0000B23B File Offset: 0x0000943B
		internal void AddAndSkipParentCheck(JToken token)
		{
			this.AddInternal(this.ChildrenTokens.Count, token, true);
		}

		// Token: 0x0600087B RID: 2171
		// RVA: 0x0000B250 File Offset: 0x00009450
		public void AddFirst(object content)
		{
			this.AddInternal(0, content, false);
		}

		// Token: 0x0600087C RID: 2172
		// RVA: 0x0003CC98 File Offset: 0x0003AE98
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
			if (this.IsMultiContent(content))
			{
				IEnumerable enumerable = (IEnumerable)content;
				int num = index;
				IEnumerator enumerator = enumerable.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						this.AddInternal(num, current, skipParentCheck);
						num++;
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
			JToken item = JContainer.CreateFromContent(content);
			this.InsertItem(index, item, skipParentCheck);
		}

		// Token: 0x0600085E RID: 2142
		// RVA: 0x0000B0DF File Offset: 0x000092DF
		internal void CheckReentrancy()
		{
			if (this._busy)
			{
				throw new InvalidOperationException(StringUtils.FormatWith("Cannot change {0} during a collection change event.", CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000866 RID: 2150
		// RVA: 0x0000B135 File Offset: 0x00009335
		public override JEnumerable<JToken> Children()
		{
			return new JEnumerable<JToken>(this.ChildrenTokens);
		}

		// Token: 0x06000873 RID: 2163
		// RVA: 0x0003CB0C File Offset: 0x0003AD0C
		internal virtual void ClearItems()
		{
			this.CheckReentrancy();
			foreach (JToken current in this.ChildrenTokens)
			{
				current.Parent = null;
				current.Previous = null;
				current.Next = null;
			}
			this.ChildrenTokens.Clear();
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
		}

		// Token: 0x06000875 RID: 2165
		// RVA: 0x0000B1E0 File Offset: 0x000093E0
		internal virtual bool ContainsItem(JToken item)
		{
			return this.IndexOfItem(item) != -1;
		}

		// Token: 0x06000863 RID: 2147
		// RVA: 0x0003C7C8 File Offset: 0x0003A9C8
		internal bool ContentsEqual(JContainer container)
		{
			if (container == this)
			{
				return true;
			}
			IList<JToken> childrenTokens = this.ChildrenTokens;
			IList<JToken> childrenTokens2 = container.ChildrenTokens;
			if (childrenTokens.Count != childrenTokens2.Count)
			{
				return false;
			}
			for (int i = 0; i < childrenTokens.Count; i++)
			{
				if (!childrenTokens[i].DeepEquals(childrenTokens2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000886 RID: 2182
		// RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		internal int ContentsHashCode()
		{
			int num = 0;
			foreach (JToken current in this.ChildrenTokens)
			{
				num ^= current.GetDeepHashCode();
			}
			return num;
		}

		// Token: 0x06000876 RID: 2166
		// RVA: 0x0003CBBC File Offset: 0x0003ADBC
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (this.Count > array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (JToken current in this.ChildrenTokens)
			{
				array.SetValue(current, arrayIndex + num);
				num++;
			}
		}

		// Token: 0x0600085F RID: 2143
		// RVA: 0x0000B104 File Offset: 0x00009304
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return new List<JToken>();
		}

		// Token: 0x0600087D RID: 2173
		// RVA: 0x0000B25B File Offset: 0x0000945B
		internal static JToken CreateFromContent(object content)
		{
			if (content is JToken)
			{
				return (JToken)content;
			}
			return new JValue(content);
		}

		// Token: 0x0600087E RID: 2174
		// RVA: 0x0000B272 File Offset: 0x00009472
		public JsonWriter CreateWriter()
		{
			return new JTokenWriter(this);
		}

		// Token: 0x06000868 RID: 2152
		// RVA: 0x0000B14F File Offset: 0x0000934F
		public IEnumerable<JToken> Descendants()
		{
			return this.GetDescendants(false);
		}

		// Token: 0x06000869 RID: 2153
		// RVA: 0x0000B158 File Offset: 0x00009358
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return this.GetDescendants(true);
		}

		// Token: 0x0600086C RID: 2156
		// RVA: 0x0000B189 File Offset: 0x00009389
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			if (item == null)
			{
				return JValue.CreateNull();
			}
			if (skipParentCheck)
			{
				return item;
			}
			if (item.Parent != null || item == this || (item.HasValues && base.Root == item))
			{
				item = item.CloneToken();
			}
			return item;
		}

		// Token: 0x06000894 RID: 2196
		// RVA: 0x0000B305 File Offset: 0x00009505
		private JToken EnsureValue(object value)
		{
			if (value == null)
			{
				return null;
			}
			if (!(value is JToken))
			{
				throw new ArgumentException("Argument is not a JToken.");
			}
			return (JToken)value;
		}

		// Token: 0x0600086A RID: 2154
		// RVA: 0x0003C824 File Offset: 0x0003AA24
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			JContainer.<GetDescendants>d__0 <GetDescendants>d__ = new JContainer.<GetDescendants>d__0(-2);
			<GetDescendants>d__.<>4__this = this;
			<GetDescendants>d__.<>3__self = self;
			return <GetDescendants>d__;
		}

		// Token: 0x06000871 RID: 2161
		// RVA: 0x0000B1D2 File Offset: 0x000093D2
		internal virtual JToken GetItem(int index)
		{
			return this.ChildrenTokens[index];
		}

		// Token: 0x0600086D RID: 2157
		// RVA: 0x0000B1BF File Offset: 0x000093BF
		internal int IndexOfItem(JToken item)
		{
			return CollectionUtils.IndexOf<JToken>(this.ChildrenTokens, item, JContainer.JTokenReferenceEqualityComparer.Instance);
		}

		// Token: 0x0600086E RID: 2158
		// RVA: 0x0003C848 File Offset: 0x0003AA48
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (index > this.ChildrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, skipParentCheck);
			JToken jToken = (index == 0) ? null : this.ChildrenTokens[index - 1];
			JToken jToken2 = (index == this.ChildrenTokens.Count) ? null : this.ChildrenTokens[index];
			this.ValidateToken(item, null);
			item.Parent = this;
			item.Previous = jToken;
			if (jToken != null)
			{
				jToken.Next = item;
			}
			item.Next = jToken2;
			if (jToken2 != null)
			{
				jToken2.Previous = item;
			}
			this.ChildrenTokens.Insert(index, item);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
			}
		}

		// Token: 0x0600086B RID: 2155
		// RVA: 0x0000B161 File Offset: 0x00009361
		internal bool IsMultiContent(object content)
		{
			return content is IEnumerable && !(content is string) && !(content is JToken) && !(content is byte[]);
		}

		// Token: 0x06000877 RID: 2167
		// RVA: 0x0003CC68 File Offset: 0x0003AE68
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			JValue jValue = currentValue as JValue;
			return jValue != null && ((jValue.Type == JTokenType.Null && newValue == null) || jValue.Equals(newValue));
		}

		// Token: 0x06000882 RID: 2178
		// RVA: 0x0000B291 File Offset: 0x00009491
		public void Merge(object content)
		{
			this.MergeItem(content, new JsonMergeSettings());
		}

		// Token: 0x06000883 RID: 2179
		// RVA: 0x0000B29F File Offset: 0x0000949F
		public void Merge(object content, JsonMergeSettings settings)
		{
			this.MergeItem(content, settings);
		}

		// Token: 0x060008B3 RID: 2227
		// RVA: 0x0003D0BC File Offset: 0x0003B2BC
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
			switch (settings.MergeArrayHandling)
			{
			case MergeArrayHandling.Concat:
			{
				IEnumerator enumerator = content.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						JToken content2 = (JToken)enumerator.Current;
						target.Add(content2);
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
				break;
			}
			case MergeArrayHandling.Union:
				break;
			case MergeArrayHandling.Replace:
				goto IL_101;
			case MergeArrayHandling.Merge:
				goto IL_14B;
			default:
				throw new ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
			}
			IDictionary<JToken, bool> dictionary = new Dictionary<JToken, bool>(JToken.EqualityComparer);
			foreach (JToken current in ((IEnumerable<JToken>)target))
			{
				dictionary[current] = true;
			}
			IEnumerator enumerator3 = content.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					JToken jToken = (JToken)enumerator3.Current;
					if (!dictionary.ContainsKey(jToken))
					{
						dictionary[jToken] = true;
						target.Add(jToken);
					}
				}
				return;
			}
			finally
			{
				IDisposable disposable2 = enumerator3 as IDisposable;
				if (disposable2 != null)
				{
					disposable2.Dispose();
				}
			}
			IL_101:
			target.ClearItems();
			IEnumerator enumerator4 = content.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					JToken content3 = (JToken)enumerator4.Current;
					target.Add(content3);
				}
				return;
			}
			finally
			{
				IDisposable disposable3 = enumerator4 as IDisposable;
				if (disposable3 != null)
				{
					disposable3.Dispose();
				}
			}
			IL_14B:
			int num = 0;
			foreach (object current2 in content)
			{
				if (num < target.Count)
				{
					JToken jToken2 = target[num];
					JContainer jContainer = jToken2 as JContainer;
					if (jContainer != null)
					{
						jContainer.Merge(current2, settings);
					}
					else if (current2 != null)
					{
						JToken jToken3 = JContainer.CreateFromContent(current2);
						if (jToken3.Type != JTokenType.Null)
						{
							target[num] = jToken3;
						}
					}
				}
				else
				{
					target.Add(current2);
				}
				num++;
			}
		}

		// Token: 0x06000881 RID: 2177
		internal abstract void MergeItem(object content, JsonMergeSettings settings);

		// Token: 0x06000860 RID: 2144
		// RVA: 0x0003C768 File Offset: 0x0003A968
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			AddingNewEventHandler addingNew = this._addingNew;
			if (addingNew != null)
			{
				addingNew(this, e);
			}
		}

		// Token: 0x06000861 RID: 2145
		// RVA: 0x0003C788 File Offset: 0x0003A988
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			ListChangedEventHandler listChanged = this._listChanged;
			if (listChanged != null)
			{
				this._busy = true;
				try
				{
					listChanged(this, e);
				}
				finally
				{
					this._busy = false;
				}
			}
		}

		// Token: 0x06000885 RID: 2181
		// RVA: 0x0003CD88 File Offset: 0x0003AF88
		internal void ReadContentFrom(JsonReader r)
		{
			ValidationUtils.ArgumentNotNull(r, "r");
			IJsonLineInfo lineInfo = r as IJsonLineInfo;
			JContainer jContainer = this;
			while (true)
			{
				if (jContainer is JProperty && ((JProperty)jContainer).Value != null)
				{
					if (jContainer == this)
					{
						return;
					}
					jContainer = jContainer.Parent;
				}
				switch (r.TokenType)
				{
				case JsonToken.None:
					goto IL_1D1;
				case JsonToken.StartObject:
				{
					JObject jObject = new JObject();
					jObject.SetLineInfo(lineInfo);
					jContainer.Add(jObject);
					jContainer = jObject;
					goto IL_1D1;
				}
				case JsonToken.StartArray:
				{
					JArray jArray = new JArray();
					jArray.SetLineInfo(lineInfo);
					jContainer.Add(jArray);
					jContainer = jArray;
					goto IL_1D1;
				}
				case JsonToken.StartConstructor:
				{
					JConstructor jConstructor = new JConstructor(r.Value.ToString());
					jConstructor.SetLineInfo(lineInfo);
					jContainer.Add(jConstructor);
					jContainer = jConstructor;
					goto IL_1D1;
				}
				case JsonToken.PropertyName:
				{
					string name = r.Value.ToString();
					JProperty jProperty = new JProperty(name);
					jProperty.SetLineInfo(lineInfo);
					JObject jObject2 = (JObject)jContainer;
					JProperty jProperty2 = jObject2.Property(name);
					if (jProperty2 == null)
					{
						jContainer.Add(jProperty);
					}
					else
					{
						jProperty2.Replace(jProperty);
					}
					jContainer = jProperty;
					goto IL_1D1;
				}
				case JsonToken.Comment:
				{
					JValue jValue = JValue.CreateComment(r.Value.ToString());
					jValue.SetLineInfo(lineInfo);
					jContainer.Add(jValue);
					goto IL_1D1;
				}
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Date:
				case JsonToken.Bytes:
				{
					JValue jValue = new JValue(r.Value);
					jValue.SetLineInfo(lineInfo);
					jContainer.Add(jValue);
					goto IL_1D1;
				}
				case JsonToken.Null:
				{
					JValue jValue = JValue.CreateNull();
					jValue.SetLineInfo(lineInfo);
					jContainer.Add(jValue);
					goto IL_1D1;
				}
				case JsonToken.Undefined:
				{
					JValue jValue = JValue.CreateUndefined();
					jValue.SetLineInfo(lineInfo);
					jContainer.Add(jValue);
					goto IL_1D1;
				}
				case JsonToken.EndObject:
					if (jContainer == this)
					{
						return;
					}
					jContainer = jContainer.Parent;
					goto IL_1D1;
				case JsonToken.EndArray:
					if (jContainer == this)
					{
						return;
					}
					jContainer = jContainer.Parent;
					goto IL_1D1;
				case JsonToken.EndConstructor:
					if (jContainer == this)
					{
						return;
					}
					jContainer = jContainer.Parent;
					goto IL_1D1;
				}
				break;
				IL_1D1:
				if (!r.Read())
				{
					return;
				}
			}
			throw new InvalidOperationException(StringUtils.FormatWith("The JsonReader should not be on a token of type {0}.", CultureInfo.InvariantCulture, r.TokenType));
		}

		// Token: 0x06000884 RID: 2180
		// RVA: 0x0003CD18 File Offset: 0x0003AF18
		internal void ReadTokenFrom(JsonReader reader)
		{
			int depth = reader.Depth;
			if (!reader.Read())
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading {0} from JsonReader.", CultureInfo.InvariantCulture, base.GetType().Name));
			}
			this.ReadContentFrom(reader);
			int depth2 = reader.Depth;
			if (depth2 > depth)
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Unexpected end of content while loading {0}.", CultureInfo.InvariantCulture, base.GetType().Name));
			}
		}

		// Token: 0x06000880 RID: 2176
		// RVA: 0x0000B289 File Offset: 0x00009489
		public void RemoveAll()
		{
			this.ClearItems();
		}

		// Token: 0x06000870 RID: 2160
		// RVA: 0x0003C9E0 File Offset: 0x0003ABE0
		internal virtual bool RemoveItem(JToken item)
		{
			int num = this.IndexOfItem(item);
			if (num >= 0)
			{
				this.RemoveItemAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x0600086F RID: 2159
		// RVA: 0x0003C90C File Offset: 0x0003AB0C
		internal virtual void RemoveItemAt(int index)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= this.ChildrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			this.CheckReentrancy();
			JToken jToken = this.ChildrenTokens[index];
			JToken jToken2 = (index == 0) ? null : this.ChildrenTokens[index - 1];
			JToken jToken3 = (index == this.ChildrenTokens.Count - 1) ? null : this.ChildrenTokens[index + 1];
			if (jToken2 != null)
			{
				jToken2.Next = jToken3;
			}
			if (jToken3 != null)
			{
				jToken3.Previous = jToken2;
			}
			jToken.Parent = null;
			jToken.Previous = null;
			jToken.Next = null;
			this.ChildrenTokens.RemoveAt(index);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
			}
		}

		// Token: 0x0600087F RID: 2175
		// RVA: 0x0000B27A File Offset: 0x0000947A
		public void ReplaceAll(object content)
		{
			this.ClearItems();
			this.Add(content);
		}

		// Token: 0x06000874 RID: 2164
		// RVA: 0x0003CB90 File Offset: 0x0003AD90
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			if (existing != null)
			{
				if (existing.Parent == this)
				{
					int index = this.IndexOfItem(existing);
					this.SetItem(index, replacement);
					return;
				}
			}
		}

		// Token: 0x06000872 RID: 2162
		// RVA: 0x0003CA04 File Offset: 0x0003AC04
		internal virtual void SetItem(int index, JToken item)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= this.ChildrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			JToken jToken = this.ChildrenTokens[index];
			if (JContainer.IsTokenUnchanged(jToken, item))
			{
				return;
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, false);
			this.ValidateToken(item, jToken);
			JToken jToken2 = (index == 0) ? null : this.ChildrenTokens[index - 1];
			JToken jToken3 = (index == this.ChildrenTokens.Count - 1) ? null : this.ChildrenTokens[index + 1];
			item.Parent = this;
			item.Previous = jToken2;
			if (jToken2 != null)
			{
				jToken2.Next = item;
			}
			item.Next = jToken3;
			if (jToken3 != null)
			{
				jToken3.Previous = item;
			}
			this.ChildrenTokens[index] = item;
			jToken.Parent = null;
			jToken.Previous = null;
			jToken.Next = null;
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
			}
		}

		// Token: 0x0600088E RID: 2190
		// RVA: 0x0000B2E0 File Offset: 0x000094E0
		void ICollection<JToken>.Add(JToken item)
		{
			this.Add(item);
		}

		// Token: 0x0600088F RID: 2191
		// RVA: 0x0000B289 File Offset: 0x00009489
		void ICollection<JToken>.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000890 RID: 2192
		// RVA: 0x0000B2E9 File Offset: 0x000094E9
		bool ICollection<JToken>.Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000891 RID: 2193
		// RVA: 0x0000B2F2 File Offset: 0x000094F2
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x06000893 RID: 2195
		// RVA: 0x0000B2FC File Offset: 0x000094FC
		bool ICollection<JToken>.Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000889 RID: 2185
		// RVA: 0x0000B2B0 File Offset: 0x000094B0
		int IList<JToken>.IndexOf(JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x0600088A RID: 2186
		// RVA: 0x0000B2B9 File Offset: 0x000094B9
		void IList<JToken>.Insert(int index, JToken item)
		{
			this.InsertItem(index, item, false);
		}

		// Token: 0x0600088B RID: 2187
		// RVA: 0x0000B2C4 File Offset: 0x000094C4
		void IList<JToken>.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x060008A0 RID: 2208
		// RVA: 0x0000B2F2 File Offset: 0x000094F2
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyItemsTo(array, index);
		}

		// Token: 0x06000895 RID: 2197
		// RVA: 0x0000B325 File Offset: 0x00009525
		int IList.Add(object value)
		{
			this.Add(this.EnsureValue(value));
			return this.Count - 1;
		}

		// Token: 0x06000896 RID: 2198
		// RVA: 0x0000B289 File Offset: 0x00009489
		void IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000897 RID: 2199
		// RVA: 0x0000B33C File Offset: 0x0000953C
		bool IList.Contains(object value)
		{
			return this.ContainsItem(this.EnsureValue(value));
		}

		// Token: 0x06000898 RID: 2200
		// RVA: 0x0000B34B File Offset: 0x0000954B
		int IList.IndexOf(object value)
		{
			return this.IndexOfItem(this.EnsureValue(value));
		}

		// Token: 0x06000899 RID: 2201
		// RVA: 0x0000B35A File Offset: 0x0000955A
		void IList.Insert(int index, object value)
		{
			this.InsertItem(index, this.EnsureValue(value), false);
		}

		// Token: 0x0600089C RID: 2204
		// RVA: 0x0000B36B File Offset: 0x0000956B
		void IList.Remove(object value)
		{
			this.RemoveItem(this.EnsureValue(value));
		}

		// Token: 0x0600089D RID: 2205
		// RVA: 0x0000B2C4 File Offset: 0x000094C4
		void IList.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x060008A4 RID: 2212
		// RVA: 0x0000653E File Offset: 0x0000473E
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x060008A5 RID: 2213
		// RVA: 0x0003D03C File Offset: 0x0003B23C
		object IBindingList.AddNew()
		{
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
			this.OnAddingNew(addingNewEventArgs);
			if (addingNewEventArgs.NewObject == null)
			{
				throw new JsonException(StringUtils.FormatWith("Could not determine new value to add to '{0}'.", CultureInfo.InvariantCulture, base.GetType()));
			}
			if (!(addingNewEventArgs.NewObject is JToken))
			{
				throw new JsonException(StringUtils.FormatWith("New item to be added to collection must be compatible with {0}.", CultureInfo.InvariantCulture, typeof(JToken)));
			}
			JToken jToken = (JToken)addingNewEventArgs.NewObject;
			this.Add(jToken);
			return jToken;
		}

		// Token: 0x060008A9 RID: 2217
		// RVA: 0x000071FE File Offset: 0x000053FE
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060008AA RID: 2218
		// RVA: 0x000071FE File Offset: 0x000053FE
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060008AC RID: 2220
		// RVA: 0x0000653E File Offset: 0x0000473E
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x060008AD RID: 2221
		// RVA: 0x000071FE File Offset: 0x000053FE
		void IBindingList.RemoveSort()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000888 RID: 2184
		// RVA: 0x0003D018 File Offset: 0x0003B218
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			ICustomTypeDescriptor customTypeDescriptor = this.First as ICustomTypeDescriptor;
			if (customTypeDescriptor != null)
			{
				return customTypeDescriptor.GetProperties();
			}
			return null;
		}

		// Token: 0x06000887 RID: 2183
		// RVA: 0x0000B2A9 File Offset: 0x000094A9
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}

		// Token: 0x06000878 RID: 2168
		// RVA: 0x0000B1EF File Offset: 0x000093EF
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type == JTokenType.Property)
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not add {0} to {1}.", CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
		}

		// Token: 0x06000867 RID: 2151
		// RVA: 0x0000B142 File Offset: 0x00009342
		public override IEnumerable<T> Values<T>()
		{
			return Extensions.Convert<JToken, T>(this.ChildrenTokens);
		}
	}
}
