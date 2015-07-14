using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E5 RID: 229
	public sealed class JProperty : JContainer
	{
		// Token: 0x020000E6 RID: 230
		private sealed class JPropertyList : IEnumerable<JToken>, IEnumerable, IList<JToken>, ICollection<JToken>
		{
			// Token: 0x040003D6 RID: 982
			internal JToken _token;

			// Token: 0x17000196 RID: 406
			public int Count
			{
				// Token: 0x06000992 RID: 2450
				// RVA: 0x0000BD4A File Offset: 0x00009F4A
				get
				{
					if (this._token == null)
					{
						return 0;
					}
					return 1;
				}
			}

			// Token: 0x17000197 RID: 407
			public bool IsReadOnly
			{
				// Token: 0x06000993 RID: 2451
				// RVA: 0x00006D86 File Offset: 0x00004F86
				get
				{
					return false;
				}
			}

			// Token: 0x17000198 RID: 408
			public JToken this[int index]
			{
				// Token: 0x06000997 RID: 2455
				// RVA: 0x0000BD7D File Offset: 0x00009F7D
				get
				{
					if (index != 0)
					{
						return null;
					}
					return this._token;
				}
				// Token: 0x06000998 RID: 2456
				// RVA: 0x0000BD65 File Offset: 0x00009F65
				set
				{
					if (index == 0)
					{
						this._token = value;
					}
				}
			}

			// Token: 0x0600098D RID: 2445
			// RVA: 0x0000BD05 File Offset: 0x00009F05
			public void Add(JToken item)
			{
				this._token = item;
			}

			// Token: 0x0600098E RID: 2446
			// RVA: 0x0000BD0E File Offset: 0x00009F0E
			public void Clear()
			{
				this._token = null;
			}

			// Token: 0x0600098F RID: 2447
			// RVA: 0x0000BD17 File Offset: 0x00009F17
			public bool Contains(JToken item)
			{
				return this._token == item;
			}

			// Token: 0x06000990 RID: 2448
			// RVA: 0x0000BD22 File Offset: 0x00009F22
			public void CopyTo(JToken[] array, int arrayIndex)
			{
				if (this._token != null)
				{
					array[arrayIndex] = this._token;
				}
			}

			// Token: 0x0600098B RID: 2443
			// RVA: 0x0003E7C8 File Offset: 0x0003C9C8
			public IEnumerator<JToken> GetEnumerator()
			{
				if (this._token != null)
				{
					yield return this._token;
				}
				yield break;
			}

			// Token: 0x06000994 RID: 2452
			// RVA: 0x0000BD57 File Offset: 0x00009F57
			public int IndexOf(JToken item)
			{
				if (this._token != item)
				{
					return -1;
				}
				return 0;
			}

			// Token: 0x06000995 RID: 2453
			// RVA: 0x0000BD65 File Offset: 0x00009F65
			public void Insert(int index, JToken item)
			{
				if (index == 0)
				{
					this._token = item;
				}
			}

			// Token: 0x06000991 RID: 2449
			// RVA: 0x0000BD35 File Offset: 0x00009F35
			public bool Remove(JToken item)
			{
				if (this._token == item)
				{
					this._token = null;
					return true;
				}
				return false;
			}

			// Token: 0x06000996 RID: 2454
			// RVA: 0x0000BD71 File Offset: 0x00009F71
			public void RemoveAt(int index)
			{
				if (index == 0)
				{
					this._token = null;
				}
			}

			// Token: 0x0600098C RID: 2444
			// RVA: 0x0000BCFD File Offset: 0x00009EFD
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}
		}

		// Token: 0x040003D4 RID: 980
		private readonly JProperty.JPropertyList _content = new JProperty.JPropertyList();

		// Token: 0x040003D5 RID: 981
		private readonly string _name;

		// Token: 0x17000192 RID: 402
		protected override IList<JToken> ChildrenTokens
		{
			// Token: 0x06000975 RID: 2421
			// RVA: 0x0000BBEA File Offset: 0x00009DEA
			get
			{
				return this._content;
			}
		}

		// Token: 0x17000193 RID: 403
		public string Name
		{
			// Token: 0x06000976 RID: 2422
			// RVA: 0x0000BBF2 File Offset: 0x00009DF2
			[DebuggerStepThrough]
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000195 RID: 405
		public override JTokenType Type
		{
			// Token: 0x06000984 RID: 2436
			// RVA: 0x000063AE File Offset: 0x000045AE
			[DebuggerStepThrough]
			get
			{
				return JTokenType.Property;
			}
		}

		// Token: 0x17000194 RID: 404
		public new JToken Value
		{
			// Token: 0x06000977 RID: 2423
			// RVA: 0x0000BBFA File Offset: 0x00009DFA
			[DebuggerStepThrough]
			get
			{
				return this._content._token;
			}
			// Token: 0x06000978 RID: 2424
			// RVA: 0x0003E5AC File Offset: 0x0003C7AC
			set
			{
				base.CheckReentrancy();
				JToken item = value ?? JValue.CreateNull();
				if (this._content._token == null)
				{
					this.InsertItem(0, item, false);
					return;
				}
				this.SetItem(0, item);
			}
		}

		// Token: 0x06000979 RID: 2425
		// RVA: 0x0000BC07 File Offset: 0x00009E07
		public JProperty(JProperty other) : base(other)
		{
			this._name = other.Name;
		}

		// Token: 0x06000985 RID: 2437
		// RVA: 0x0000BCAA File Offset: 0x00009EAA
		internal JProperty(string name)
		{
			ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
		}

		// Token: 0x06000986 RID: 2438
		// RVA: 0x0000BCCF File Offset: 0x00009ECF
		public JProperty(string name, params object[] content) : this(name, content)
		{
		}

		// Token: 0x06000987 RID: 2439
		// RVA: 0x0003E6BC File Offset: 0x0003C8BC
		public JProperty(string name, object content)
		{
			ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
			this.Value = (base.IsMultiContent(content) ? new JArray(content) : JContainer.CreateFromContent(content));
		}

		// Token: 0x06000981 RID: 2433
		// RVA: 0x0000BC38 File Offset: 0x00009E38
		internal override void ClearItems()
		{
			throw new JsonException(StringUtils.FormatWith("Cannot add or remove items from {0}.", CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x06000983 RID: 2435
		// RVA: 0x0000BCA2 File Offset: 0x00009EA2
		internal override JToken CloneToken()
		{
			return new JProperty(this);
		}

		// Token: 0x0600097F RID: 2431
		// RVA: 0x0000BC97 File Offset: 0x00009E97
		internal override bool ContainsItem(JToken item)
		{
			return this.Value == item;
		}

		// Token: 0x06000982 RID: 2434
		// RVA: 0x0003E688 File Offset: 0x0003C888
		internal override bool DeepEquals(JToken node)
		{
			JProperty jProperty = node as JProperty;
			return jProperty != null && this._name == jProperty.Name && base.ContentsEqual(jProperty);
		}

		// Token: 0x06000989 RID: 2441
		// RVA: 0x0000BCD9 File Offset: 0x00009ED9
		internal override int GetDeepHashCode()
		{
			return this._name.GetHashCode() ^ ((this.Value != null) ? this.Value.GetDeepHashCode() : 0);
		}

		// Token: 0x0600097A RID: 2426
		// RVA: 0x0000BC27 File Offset: 0x00009E27
		internal override JToken GetItem(int index)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.Value;
		}

		// Token: 0x0600097E RID: 2430
		// RVA: 0x0000BC58 File Offset: 0x00009E58
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (item != null && item.Type == JTokenType.Comment)
			{
				return;
			}
			if (this.Value != null)
			{
				throw new JsonException(StringUtils.FormatWith("{0} cannot have multiple values.", CultureInfo.InvariantCulture, typeof(JProperty)));
			}
			base.InsertItem(0, item, false);
		}

		// Token: 0x0600098A RID: 2442
		// RVA: 0x0003E740 File Offset: 0x0003C940
		public new static JProperty Load(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JProperty from JsonReader.");
			}
			while (reader.TokenType == JsonToken.Comment)
			{
				reader.Read();
			}
			if (reader.TokenType != JsonToken.PropertyName)
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}", CultureInfo.InvariantCulture, reader.TokenType));
			}
			JProperty jProperty = new JProperty((string)reader.Value);
			jProperty.SetLineInfo(reader as IJsonLineInfo);
			jProperty.ReadTokenFrom(reader);
			return jProperty;
		}

		// Token: 0x06000980 RID: 2432
		// RVA: 0x0003E64C File Offset: 0x0003C84C
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			JProperty jProperty = content as JProperty;
			if (jProperty == null)
			{
				return;
			}
			if (jProperty.Value != null && jProperty.Value.Type != JTokenType.Null)
			{
				this.Value = jProperty.Value;
			}
		}

		// Token: 0x0600097C RID: 2428
		// RVA: 0x0000BC38 File Offset: 0x00009E38
		internal override bool RemoveItem(JToken item)
		{
			throw new JsonException(StringUtils.FormatWith("Cannot add or remove items from {0}.", CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x0600097D RID: 2429
		// RVA: 0x0000BC38 File Offset: 0x00009E38
		internal override void RemoveItemAt(int index)
		{
			throw new JsonException(StringUtils.FormatWith("Cannot add or remove items from {0}.", CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x0600097B RID: 2427
		// RVA: 0x0003E5EC File Offset: 0x0003C7EC
		internal override void SetItem(int index, JToken item)
		{
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (JContainer.IsTokenUnchanged(this.Value, item))
			{
				return;
			}
			if (base.Parent != null)
			{
				((JObject)base.Parent).InternalPropertyChanging(this);
			}
			base.SetItem(0, item);
			if (base.Parent != null)
			{
				((JObject)base.Parent).InternalPropertyChanged(this);
			}
		}

		// Token: 0x06000988 RID: 2440
		// RVA: 0x0003E70C File Offset: 0x0003C90C
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WritePropertyName(this._name);
			JToken value = this.Value;
			if (value != null)
			{
				value.WriteTo(writer, converters);
				return;
			}
			writer.WriteNull();
		}
	}
}
