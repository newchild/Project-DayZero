using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000044 RID: 68
	internal sealed class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x040000FB RID: 251
		private static readonly IEqualityComparer<string> Comparer = StringComparer.Ordinal;

		// Token: 0x040000FC RID: 252
		private Dictionary<string, JToken> _dictionary;

		// Token: 0x17000041 RID: 65
		public JToken this[string key]
		{
			// Token: 0x060001EC RID: 492
			// RVA: 0x00007131 File Offset: 0x00005331
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				if (this._dictionary == null)
				{
					throw new KeyNotFoundException();
				}
				return this._dictionary[key];
			}
		}

		// Token: 0x17000042 RID: 66
		public ICollection<string> Keys
		{
			// Token: 0x060001EE RID: 494
			// RVA: 0x00007177 File Offset: 0x00005377
			get
			{
				this.EnsureDictionary();
				return this._dictionary.Keys;
			}
		}

		// Token: 0x17000043 RID: 67
		public ICollection<JToken> Values
		{
			// Token: 0x060001EF RID: 495
			// RVA: 0x0000718A File Offset: 0x0000538A
			get
			{
				this.EnsureDictionary();
				return this._dictionary.Values;
			}
		}

		// Token: 0x060001E0 RID: 480
		// RVA: 0x00007049 File Offset: 0x00005249
		private void AddKey(string key, JToken item)
		{
			this.EnsureDictionary();
			this._dictionary[key] = item;
		}

		// Token: 0x060001E1 RID: 481
		// RVA: 0x0002C54C File Offset: 0x0002A74C
		protected void ChangeItemKey(JToken item, string newKey)
		{
			if (!this.ContainsItem(item))
			{
				throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
			}
			string keyForItem = this.GetKeyForItem(item);
			if (!JPropertyKeyedCollection.Comparer.Equals(keyForItem, newKey))
			{
				if (newKey != null)
				{
					this.AddKey(newKey, item);
				}
				if (keyForItem != null)
				{
					this.RemoveKey(keyForItem);
				}
			}
		}

		// Token: 0x060001E2 RID: 482
		// RVA: 0x0000705E File Offset: 0x0000525E
		protected override void ClearItems()
		{
			base.ClearItems();
			if (this._dictionary != null)
			{
				this._dictionary.Clear();
			}
		}

		// Token: 0x060001F0 RID: 496
		// RVA: 0x0002C660 File Offset: 0x0002A860
		public bool Compare(JPropertyKeyedCollection other)
		{
			if (this == other)
			{
				return true;
			}
			Dictionary<string, JToken> dictionary = this._dictionary;
			Dictionary<string, JToken> dictionary2 = other._dictionary;
			if (dictionary == null && dictionary2 == null)
			{
				return true;
			}
			if (dictionary == null)
			{
				return dictionary2.Count == 0;
			}
			if (dictionary2 == null)
			{
				return dictionary.Count == 0;
			}
			if (dictionary.Count != dictionary2.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, JToken> current in dictionary)
			{
				JToken jToken;
				if (!dictionary2.TryGetValue(current.Key, out jToken))
				{
					bool result = false;
					return result;
				}
				JProperty jProperty = (JProperty)current.Value;
				JProperty jProperty2 = (JProperty)jToken;
				if (jProperty.Value == null)
				{
					bool result = jProperty2.Value == null;
					return result;
				}
				if (!jProperty.Value.DeepEquals(jProperty2.Value))
				{
					bool result = false;
					return result;
				}
			}
			return true;
		}

		// Token: 0x060001E3 RID: 483
		// RVA: 0x00007079 File Offset: 0x00005279
		public bool Contains(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this._dictionary != null && this._dictionary.ContainsKey(key);
		}

		// Token: 0x060001E4 RID: 484
		// RVA: 0x0002C598 File Offset: 0x0002A798
		private bool ContainsItem(JToken item)
		{
			if (this._dictionary == null)
			{
				return false;
			}
			string keyForItem = this.GetKeyForItem(item);
			JToken jToken;
			return this._dictionary.TryGetValue(keyForItem, out jToken);
		}

		// Token: 0x060001E5 RID: 485
		// RVA: 0x0000709F File Offset: 0x0000529F
		private void EnsureDictionary()
		{
			if (this._dictionary == null)
			{
				this._dictionary = new Dictionary<string, JToken>(JPropertyKeyedCollection.Comparer);
			}
		}

		// Token: 0x060001E6 RID: 486
		// RVA: 0x000070B9 File Offset: 0x000052B9
		private string GetKeyForItem(JToken item)
		{
			return ((JProperty)item).Name;
		}

		// Token: 0x060001E7 RID: 487
		// RVA: 0x000070C6 File Offset: 0x000052C6
		protected override void InsertItem(int index, JToken item)
		{
			this.AddKey(this.GetKeyForItem(item), item);
			base.InsertItem(index, item);
		}

		// Token: 0x060001E8 RID: 488
		// RVA: 0x000070DE File Offset: 0x000052DE
		public bool Remove(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this._dictionary != null && this._dictionary.ContainsKey(key) && base.Remove(this._dictionary[key]);
		}

		// Token: 0x060001E9 RID: 489
		// RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		protected override void RemoveItem(int index)
		{
			string keyForItem = this.GetKeyForItem(base.Items[index]);
			this.RemoveKey(keyForItem);
			base.RemoveItem(index);
		}

		// Token: 0x060001EA RID: 490
		// RVA: 0x0000711A File Offset: 0x0000531A
		private void RemoveKey(string key)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Remove(key);
			}
		}

		// Token: 0x060001EB RID: 491
		// RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		protected override void SetItem(int index, JToken item)
		{
			string keyForItem = this.GetKeyForItem(item);
			string keyForItem2 = this.GetKeyForItem(base.Items[index]);
			if (JPropertyKeyedCollection.Comparer.Equals(keyForItem2, keyForItem))
			{
				if (this._dictionary != null)
				{
					this._dictionary[keyForItem] = item;
				}
			}
			else
			{
				this.AddKey(keyForItem, item);
				if (keyForItem2 != null)
				{
					this.RemoveKey(keyForItem2);
				}
			}
			base.SetItem(index, item);
		}

		// Token: 0x060001ED RID: 493
		// RVA: 0x0000715B File Offset: 0x0000535B
		public bool TryGetValue(string key, out JToken value)
		{
			if (this._dictionary == null)
			{
				value = null;
				return false;
			}
			return this._dictionary.TryGetValue(key, out value);
		}
	}
}
