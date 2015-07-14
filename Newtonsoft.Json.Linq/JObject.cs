using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E0 RID: 224
	public sealed class JObject : JContainer, IEnumerable, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, INotifyPropertyChanged, ICustomTypeDescriptor
	{
		// Token: 0x040003C3 RID: 963
		private readonly JPropertyKeyedCollection _properties = new JPropertyKeyedCollection();

		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1700017E RID: 382
		protected override IList<JToken> ChildrenTokens
		{
			// Token: 0x060008DB RID: 2267
			// RVA: 0x0000B5FE File Offset: 0x000097FE
			get
			{
				return this._properties;
			}
		}

		// Token: 0x17000180 RID: 384
		public override JToken this[object key]
		{
			// Token: 0x060008ED RID: 2285
			// RVA: 0x0003D8F8 File Offset: 0x0003BAF8
			get
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				string text = key as string;
				if (text == null)
				{
					throw new ArgumentException(StringUtils.FormatWith("Accessed JObject values with invalid key value: {0}. Object property name expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this[text];
			}
			// Token: 0x060008EE RID: 2286
			// RVA: 0x0003D93C File Offset: 0x0003BB3C
			set
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				string text = key as string;
				if (text == null)
				{
					throw new ArgumentException(StringUtils.FormatWith("Set JObject values with invalid key value: {0}. Object property name expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this[text] = value;
			}
		}

		// Token: 0x17000181 RID: 385
		public JToken this[string propertyName]
		{
			// Token: 0x060008EF RID: 2287
			// RVA: 0x0003D984 File Offset: 0x0003BB84
			get
			{
				ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
				JProperty jProperty = this.Property(propertyName);
				if (jProperty == null)
				{
					return null;
				}
				return jProperty.Value;
			}
			// Token: 0x060008F0 RID: 2288
			// RVA: 0x0003D9B0 File Offset: 0x0003BBB0
			set
			{
				JProperty jProperty = this.Property(propertyName);
				if (jProperty != null)
				{
					jProperty.Value = value;
					return;
				}
				this.Add(new JProperty(propertyName, value));
				this.OnPropertyChanged(propertyName);
			}
		}

		// Token: 0x17000184 RID: 388
		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			// Token: 0x06000903 RID: 2307
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000182 RID: 386
		ICollection<string> IDictionary<string, JToken>.Keys
		{
			// Token: 0x060008FB RID: 2299
			// RVA: 0x0000B71D File Offset: 0x0000991D
			get
			{
				return this._properties.Keys;
			}
		}

		// Token: 0x17000183 RID: 387
		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			// Token: 0x060008FE RID: 2302
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700017F RID: 383
		public override JTokenType Type
		{
			// Token: 0x060008E9 RID: 2281
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return JTokenType.Object;
			}
		}

		// Token: 0x060008DE RID: 2270
		// RVA: 0x0000B606 File Offset: 0x00009806
		public JObject()
		{
		}

		// Token: 0x060008DF RID: 2271
		// RVA: 0x0000B619 File Offset: 0x00009819
		public JObject(JObject other) : base(other)
		{
		}

		// Token: 0x060008E0 RID: 2272
		// RVA: 0x0000B62D File Offset: 0x0000982D
		public JObject(params object[] content) : this(content)
		{
		}

		// Token: 0x060008E1 RID: 2273
		// RVA: 0x0000B636 File Offset: 0x00009836
		public JObject(object content)
		{
			this.Add(content);
		}

		// Token: 0x060008F9 RID: 2297
		// RVA: 0x0000B700 File Offset: 0x00009900
		public void Add(string propertyName, JToken value)
		{
			this.Add(new JProperty(propertyName, value));
		}

		// Token: 0x060008E8 RID: 2280
		// RVA: 0x0000B691 File Offset: 0x00009891
		internal override JToken CloneToken()
		{
			return new JObject(this);
		}

		// Token: 0x060008E2 RID: 2274
		// RVA: 0x0003D71C File Offset: 0x0003B91C
		internal override bool DeepEquals(JToken node)
		{
			JObject jObject = node as JObject;
			return jObject != null && this._properties.Compare(jObject._properties);
		}

		// Token: 0x060008F3 RID: 2291
		// RVA: 0x0000B6D5 File Offset: 0x000098D5
		public new static JObject FromObject(object o)
		{
			return JObject.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x060008F4 RID: 2292
		// RVA: 0x0003DAC8 File Offset: 0x0003BCC8
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jToken = JToken.FromObjectInternal(o, jsonSerializer);
			if (jToken != null && jToken.Type != JTokenType.Object)
			{
				throw new ArgumentException(StringUtils.FormatWith("Object serialized to {0}. JObject instance expected.", CultureInfo.InvariantCulture, jToken.Type));
			}
			return (JObject)jToken;
		}

		// Token: 0x06000905 RID: 2309
		// RVA: 0x0000B769 File Offset: 0x00009969
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000906 RID: 2310
		// RVA: 0x0003DD14 File Offset: 0x0003BF14
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			JObject.<GetEnumerator>d__2 <GetEnumerator>d__ = new JObject.<GetEnumerator>d__2(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x060008F6 RID: 2294
		// RVA: 0x0000B6E2 File Offset: 0x000098E2
		public JToken GetValue(string propertyName)
		{
			return this.GetValue(propertyName, StringComparison.Ordinal);
		}

		// Token: 0x060008F7 RID: 2295
		// RVA: 0x0003DB54 File Offset: 0x0003BD54
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			if (propertyName == null)
			{
				return null;
			}
			JProperty jProperty = this.Property(propertyName);
			if (jProperty != null)
			{
				return jProperty.Value;
			}
			if (comparison != StringComparison.Ordinal)
			{
				JToken value;
				using (IEnumerator<JToken> enumerator = this._properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						JProperty jProperty2 = (JProperty)enumerator.Current;
						if (string.Equals(jProperty2.Name, propertyName, comparison))
						{
							value = jProperty2.Value;
							return value;
						}
					}
					goto IL_64;
				}
				return value;
			}
			IL_64:
			return null;
		}

		// Token: 0x060008E3 RID: 2275
		// RVA: 0x0000B650 File Offset: 0x00009850
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
			if (item != null && item.Type == JTokenType.Comment)
			{
				return;
			}
			base.InsertItem(index, item, skipParentCheck);
		}

		// Token: 0x060008E6 RID: 2278
		// RVA: 0x0000B668 File Offset: 0x00009868
		internal void InternalPropertyChanged(JProperty childProperty)
		{
			this.OnPropertyChanged(childProperty.Name);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, base.IndexOfItem(childProperty)));
			}
		}

		// Token: 0x060008E7 RID: 2279
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		// Token: 0x060008F1 RID: 2289
		// RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		public new static JObject Load(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JObject from JsonReader.");
			}
			while (reader.TokenType == JsonToken.Comment)
			{
				reader.Read();
			}
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}", CultureInfo.InvariantCulture, reader.TokenType));
			}
			JObject jObject = new JObject();
			jObject.SetLineInfo(reader as IJsonLineInfo);
			jObject.ReadTokenFrom(reader);
			return jObject;
		}

		// Token: 0x060008E5 RID: 2277
		// RVA: 0x0003D7E8 File Offset: 0x0003B9E8
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			JObject jObject = content as JObject;
			if (jObject == null)
			{
				return;
			}
			foreach (KeyValuePair<string, JToken> current in jObject)
			{
				JProperty jProperty = this.Property(current.Key);
				if (jProperty == null)
				{
					this.Add(current.Key, current.Value);
				}
				else if (current.Value != null)
				{
					JContainer jContainer = jProperty.Value as JContainer;
					if (jContainer == null)
					{
						if (current.Value.Type != JTokenType.Null)
						{
							jProperty.Value = current.Value;
						}
					}
					else if (jContainer.Type != current.Value.Type)
					{
						jProperty.Value = current.Value;
					}
					else
					{
						jContainer.Merge(current.Value, settings);
					}
				}
			}
		}

		// Token: 0x06000907 RID: 2311
		// RVA: 0x0000B771 File Offset: 0x00009971
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060008F2 RID: 2290
		// RVA: 0x0003DA6C File Offset: 0x0003BC6C
		public new static JObject Parse(string json)
		{
			JObject result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JObject jObject = JObject.Load(jsonReader);
				if (jsonReader.Read() && jsonReader.TokenType != JsonToken.Comment)
				{
					throw JsonReaderException.Create(jsonReader, "Additional text found in JSON string after parsing content.");
				}
				result = jObject;
			}
			return result;
		}

		// Token: 0x060008EA RID: 2282
		// RVA: 0x0000B699 File Offset: 0x00009899
		public IEnumerable<JProperty> Properties()
		{
			return Enumerable.Cast<JProperty>(this._properties);
		}

		// Token: 0x060008EB RID: 2283
		// RVA: 0x0003D8D0 File Offset: 0x0003BAD0
		public JProperty Property(string name)
		{
			if (name == null)
			{
				return null;
			}
			JToken jToken;
			this._properties.TryGetValue(name, out jToken);
			return (JProperty)jToken;
		}

		// Token: 0x060008EC RID: 2284
		// RVA: 0x0000B6A6 File Offset: 0x000098A6
		public JEnumerable<JToken> PropertyValues()
		{
			return new JEnumerable<JToken>(Enumerable.Select<JProperty, JToken>(this.Properties(), (JProperty p) => p.Value));
		}

		// Token: 0x060008FC RID: 2300
		// RVA: 0x0003DBD8 File Offset: 0x0003BDD8
		public bool Remove(string propertyName)
		{
			JProperty jProperty = this.Property(propertyName);
			if (jProperty == null)
			{
				return false;
			}
			jProperty.Remove();
			return true;
		}

		// Token: 0x060008FF RID: 2303
		// RVA: 0x0000B72A File Offset: 0x0000992A
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
		{
			this.Add(new JProperty(item.Key, item.Value));
		}

		// Token: 0x06000900 RID: 2304
		// RVA: 0x0000B745 File Offset: 0x00009945
		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
			base.RemoveAll();
		}

		// Token: 0x06000901 RID: 2305
		// RVA: 0x0003DC24 File Offset: 0x0003BE24
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			JProperty jProperty = this.Property(item.Key);
			return jProperty != null && jProperty.Value == item.Value;
		}

		// Token: 0x06000902 RID: 2306
		// RVA: 0x0003DC54 File Offset: 0x0003BE54
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
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
			if (base.Count > array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			using (IEnumerator<JToken> enumerator = this._properties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					JProperty jProperty = (JProperty)enumerator.Current;
					array[arrayIndex + num] = new KeyValuePair<string, JToken>(jProperty.Name, jProperty.Value);
					num++;
				}
			}
		}

		// Token: 0x06000904 RID: 2308
		// RVA: 0x0000B74D File Offset: 0x0000994D
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			if (!((ICollection<KeyValuePair<string, JToken>>)this).Contains(item))
			{
				return false;
			}
			((IDictionary<string, JToken>)this).Remove(item.Key);
			return true;
		}

		// Token: 0x060008FA RID: 2298
		// RVA: 0x0000B70F File Offset: 0x0000990F
		bool IDictionary<string, JToken>.ContainsKey(string key)
		{
			return this._properties.Contains(key);
		}

		// Token: 0x0600090A RID: 2314
		// RVA: 0x0000B796 File Offset: 0x00009996
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x0600090B RID: 2315
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x0600090C RID: 2316
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x0600090D RID: 2317
		// RVA: 0x0000B79D File Offset: 0x0000999D
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return new TypeConverter();
		}

		// Token: 0x0600090E RID: 2318
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x0600090F RID: 2319
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000910 RID: 2320
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000912 RID: 2322
		// RVA: 0x0000B7A4 File Offset: 0x000099A4
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000911 RID: 2321
		// RVA: 0x0000B7A4 File Offset: 0x000099A4
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000908 RID: 2312
		// RVA: 0x0000B78D File Offset: 0x0000998D
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000909 RID: 2313
		// RVA: 0x0003DD30 File Offset: 0x0003BF30
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
			foreach (KeyValuePair<string, JToken> current in this)
			{
				propertyDescriptorCollection.Add(new JPropertyDescriptor(current.Key));
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x06000913 RID: 2323
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x060008FD RID: 2301
		// RVA: 0x0003DBFC File Offset: 0x0003BDFC
		public bool TryGetValue(string propertyName, out JToken value)
		{
			JProperty jProperty = this.Property(propertyName);
			if (jProperty == null)
			{
				value = null;
				return false;
			}
			value = jProperty.Value;
			return true;
		}

		// Token: 0x060008F8 RID: 2296
		// RVA: 0x0000B6EC File Offset: 0x000098EC
		public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
		{
			value = this.GetValue(propertyName, comparison);
			return value != null;
		}

		// Token: 0x060008E4 RID: 2276
		// RVA: 0x0003D748 File Offset: 0x0003B948
		internal override void ValidateToken(JToken o, JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type != JTokenType.Property)
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not add {0} to {1}.", CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
			JProperty jProperty = (JProperty)o;
			if (existing != null)
			{
				JProperty jProperty2 = (JProperty)existing;
				if (jProperty.Name == jProperty2.Name)
				{
					return;
				}
			}
			if (this._properties.TryGetValue(jProperty.Name, out existing))
			{
				throw new ArgumentException(StringUtils.FormatWith("Can not add property {0} to {1}. Property with the same name already exists on object.", CultureInfo.InvariantCulture, jProperty.Name, base.GetType()));
			}
		}

		// Token: 0x060008F5 RID: 2293
		// RVA: 0x0003DB10 File Offset: 0x0003BD10
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartObject();
			for (int i = 0; i < this._properties.Count; i++)
			{
				this._properties[i].WriteTo(writer, converters);
			}
			writer.WriteEndObject();
		}
	}
}
