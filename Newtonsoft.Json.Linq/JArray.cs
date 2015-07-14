using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E2 RID: 226
	public sealed class JArray : JContainer, IEnumerable<JToken>, IEnumerable, IList<JToken>, ICollection<JToken>
	{
		// Token: 0x040003CB RID: 971
		private readonly List<JToken> _values = new List<JToken>();

		// Token: 0x17000187 RID: 391
		protected override IList<JToken> ChildrenTokens
		{
			// Token: 0x0600091C RID: 2332
			// RVA: 0x0000B7F3 File Offset: 0x000099F3
			get
			{
				return this._values;
			}
		}

		// Token: 0x1700018B RID: 395
		public bool IsReadOnly
		{
			// Token: 0x06000936 RID: 2358
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000189 RID: 393
		public override JToken this[object key]
		{
			// Token: 0x06000929 RID: 2345
			// RVA: 0x0000B85D File Offset: 0x00009A5D
			get
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException(StringUtils.FormatWith("Accessed JArray values with invalid key value: {0}. Array position index expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this.GetItem((int)key);
			}
			// Token: 0x0600092A RID: 2346
			// RVA: 0x0000B899 File Offset: 0x00009A99
			set
			{
				ValidationUtils.ArgumentNotNull(key, "o");
				if (!(key is int))
				{
					throw new ArgumentException(StringUtils.FormatWith("Set JArray values with invalid key value: {0}. Array position index expected.", CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this.SetItem((int)key, value);
			}
		}

		// Token: 0x1700018A RID: 394
		public JToken this[int index]
		{
			// Token: 0x0600092B RID: 2347
			// RVA: 0x0000B2CD File Offset: 0x000094CD
			get
			{
				return this.GetItem(index);
			}
			// Token: 0x0600092C RID: 2348
			// RVA: 0x0000B2D6 File Offset: 0x000094D6
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x17000188 RID: 392
		public override JTokenType Type
		{
			// Token: 0x0600091D RID: 2333
			// RVA: 0x0000B7FB File Offset: 0x000099FB
			get
			{
				return JTokenType.Array;
			}
		}

		// Token: 0x0600091E RID: 2334
		// RVA: 0x0000B7FE File Offset: 0x000099FE
		public JArray()
		{
		}

		// Token: 0x0600091F RID: 2335
		// RVA: 0x0000B811 File Offset: 0x00009A11
		public JArray(JArray other) : base(other)
		{
		}

		// Token: 0x06000920 RID: 2336
		// RVA: 0x0000B825 File Offset: 0x00009A25
		public JArray(params object[] content) : this(content)
		{
		}

		// Token: 0x06000921 RID: 2337
		// RVA: 0x0000B82E File Offset: 0x00009A2E
		public JArray(object content)
		{
			this.Add(content);
		}

		// Token: 0x06000932 RID: 2354
		// RVA: 0x0000B2E0 File Offset: 0x000094E0
		public void Add(JToken item)
		{
			this.Add(item);
		}

		// Token: 0x06000933 RID: 2355
		// RVA: 0x0000B289 File Offset: 0x00009489
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000923 RID: 2339
		// RVA: 0x0000B848 File Offset: 0x00009A48
		internal override JToken CloneToken()
		{
			return new JArray(this);
		}

		// Token: 0x06000934 RID: 2356
		// RVA: 0x0000B2E9 File Offset: 0x000094E9
		public bool Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000935 RID: 2357
		// RVA: 0x0000B2F2 File Offset: 0x000094F2
		public void CopyTo(JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x06000922 RID: 2338
		// RVA: 0x0003DE98 File Offset: 0x0003C098
		internal override bool DeepEquals(JToken node)
		{
			JArray jArray = node as JArray;
			return jArray != null && base.ContentsEqual(jArray);
		}

		// Token: 0x06000926 RID: 2342
		// RVA: 0x0000B850 File Offset: 0x00009A50
		public new static JArray FromObject(object o)
		{
			return JArray.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000927 RID: 2343
		// RVA: 0x0003DF94 File Offset: 0x0003C194
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jToken = JToken.FromObjectInternal(o, jsonSerializer);
			if (jToken.Type != JTokenType.Array)
			{
				throw new ArgumentException(StringUtils.FormatWith("Object serialized to {0}. JArray instance expected.", CultureInfo.InvariantCulture, jToken.Type));
			}
			return (JArray)jToken;
		}

		// Token: 0x06000938 RID: 2360
		// RVA: 0x0000B769 File Offset: 0x00009969
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000931 RID: 2353
		// RVA: 0x000342F0 File Offset: 0x000324F0
		public IEnumerator<JToken> GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x0600092E RID: 2350
		// RVA: 0x0000B2B0 File Offset: 0x000094B0
		public int IndexOf(JToken item)
		{
			return base.IndexOfItem(item);
		}

		// Token: 0x0600092F RID: 2351
		// RVA: 0x0000B2B9 File Offset: 0x000094B9
		public void Insert(int index, JToken item)
		{
			this.InsertItem(index, item, false);
		}

		// Token: 0x06000924 RID: 2340
		// RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		public new static JArray Load(JsonReader reader)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JArray from JsonReader.");
			}
			while (reader.TokenType == JsonToken.Comment)
			{
				reader.Read();
			}
			if (reader.TokenType != JsonToken.StartArray)
			{
				throw JsonReaderException.Create(reader, StringUtils.FormatWith("Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}", CultureInfo.InvariantCulture, reader.TokenType));
			}
			JArray jArray = new JArray();
			jArray.SetLineInfo(reader as IJsonLineInfo);
			jArray.ReadTokenFrom(reader);
			return jArray;
		}

		// Token: 0x0600092D RID: 2349
		// RVA: 0x0003E01C File Offset: 0x0003C21C
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
			IEnumerable enumerable = (base.IsMultiContent(content) || content is JArray) ? ((IEnumerable)content) : null;
			if (enumerable == null)
			{
				return;
			}
			JContainer.MergeEnumerableContent(this, enumerable, settings);
		}

		// Token: 0x06000925 RID: 2341
		// RVA: 0x0003DF38 File Offset: 0x0003C138
		public new static JArray Parse(string json)
		{
			JArray result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JArray jArray = JArray.Load(jsonReader);
				if (jsonReader.Read() && jsonReader.TokenType != JsonToken.Comment)
				{
					throw JsonReaderException.Create(jsonReader, "Additional text found in JSON string after parsing content.");
				}
				result = jArray;
			}
			return result;
		}

		// Token: 0x06000937 RID: 2359
		// RVA: 0x0000B2FC File Offset: 0x000094FC
		public bool Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000930 RID: 2352
		// RVA: 0x0000B2C4 File Offset: 0x000094C4
		public void RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x06000928 RID: 2344
		// RVA: 0x0003DFD8 File Offset: 0x0003C1D8
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartArray();
			for (int i = 0; i < this._values.Count; i++)
			{
				this._values[i].WriteTo(writer, converters);
			}
			writer.WriteEndArray();
		}
	}
}
