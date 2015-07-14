using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E3 RID: 227
	public sealed class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x040003CF RID: 975
		private JToken _current;

		// Token: 0x040003CC RID: 972
		private readonly string _initialPath;

		// Token: 0x040003CE RID: 974
		private JToken _parent;

		// Token: 0x040003CD RID: 973
		private readonly JToken _root;

		// Token: 0x1700018C RID: 396
		public JToken CurrentToken
		{
			// Token: 0x06000939 RID: 2361
			// RVA: 0x0000B8D6 File Offset: 0x00009AD6
			get
			{
				return this._current;
			}
		}

		// Token: 0x1700018D RID: 397
		int IJsonLineInfo.LineNumber
		{
			// Token: 0x0600094B RID: 2379
			// RVA: 0x0003E3F8 File Offset: 0x0003C5F8
			get
			{
				if (base.CurrentState == JsonReader.State.Start)
				{
					return 0;
				}
				IJsonLineInfo current = this._current;
				if (current != null)
				{
					return current.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x1700018E RID: 398
		int IJsonLineInfo.LinePosition
		{
			// Token: 0x0600094C RID: 2380
			// RVA: 0x0003E424 File Offset: 0x0003C624
			get
			{
				if (base.CurrentState == JsonReader.State.Start)
				{
					return 0;
				}
				IJsonLineInfo current = this._current;
				if (current != null)
				{
					return current.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x1700018F RID: 399
		public override string Path
		{
			// Token: 0x0600094D RID: 2381
			// RVA: 0x0003E450 File Offset: 0x0003C650
			get
			{
				string text = base.Path;
				if (!string.IsNullOrEmpty(this._initialPath))
				{
					if (string.IsNullOrEmpty(text))
					{
						return this._initialPath;
					}
					if (!StringUtils.EndsWith(this._initialPath, ']') && !StringUtils.StartsWith(text, '['))
					{
						text = this._initialPath + "." + text;
					}
					else
					{
						text = this._initialPath + text;
					}
				}
				return text;
			}
		}

		// Token: 0x0600093A RID: 2362
		// RVA: 0x0000B8DE File Offset: 0x00009ADE
		public JTokenReader(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			this._root = token;
		}

		// Token: 0x0600093B RID: 2363
		// RVA: 0x0000B8F8 File Offset: 0x00009AF8
		internal JTokenReader(JToken token, string initialPath) : this(token)
		{
			this._initialPath = initialPath;
		}

		// Token: 0x06000945 RID: 2373
		// RVA: 0x0003E124 File Offset: 0x0003C324
		private JsonToken? GetEndToken(JContainer c)
		{
			switch (c.Type)
			{
			case JTokenType.Object:
				return new JsonToken?(JsonToken.EndObject);
			case JTokenType.Array:
				return new JsonToken?(JsonToken.EndArray);
			case JTokenType.Constructor:
				return new JsonToken?(JsonToken.EndConstructor);
			case JTokenType.Property:
				return null;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", c.Type, "Unexpected JContainer type.");
			}
		}

		// Token: 0x0600094A RID: 2378
		// RVA: 0x0003E3CC File Offset: 0x0003C5CC
		bool IJsonLineInfo.HasLineInfo()
		{
			if (base.CurrentState == JsonReader.State.Start)
			{
				return false;
			}
			IJsonLineInfo current = this._current;
			return current != null && current.HasLineInfo();
		}

		// Token: 0x06000942 RID: 2370
		// RVA: 0x00006263 File Offset: 0x00004463
		public override bool Read()
		{
			this._readType = ReadType.Read;
			return this.ReadInternal();
		}

		// Token: 0x0600093C RID: 2364
		// RVA: 0x0000623B File Offset: 0x0000443B
		public override byte[] ReadAsBytes()
		{
			return base.ReadAsBytesInternal();
		}

		// Token: 0x06000940 RID: 2368
		// RVA: 0x0000625B File Offset: 0x0000445B
		public override DateTime? ReadAsDateTime()
		{
			return base.ReadAsDateTimeInternal();
		}

		// Token: 0x0600093D RID: 2365
		// RVA: 0x00006243 File Offset: 0x00004443
		public override decimal? ReadAsDecimal()
		{
			return base.ReadAsDecimalInternal();
		}

		// Token: 0x0600093E RID: 2366
		// RVA: 0x0000624B File Offset: 0x0000444B
		public override int? ReadAsInt32()
		{
			return base.ReadAsInt32Internal();
		}

		// Token: 0x0600093F RID: 2367
		// RVA: 0x00006253 File Offset: 0x00004453
		public override string ReadAsString()
		{
			return base.ReadAsStringInternal();
		}

		// Token: 0x06000941 RID: 2369
		// RVA: 0x0003E050 File Offset: 0x0003C250
		internal override bool ReadInternal()
		{
			if (base.CurrentState == JsonReader.State.Start)
			{
				this._current = this._root;
				this.SetToken(this._current);
				return true;
			}
			if (this._current == null)
			{
				return false;
			}
			JContainer jContainer = this._current as JContainer;
			if (jContainer != null && this._parent != jContainer)
			{
				return this.ReadInto(jContainer);
			}
			return this.ReadOver(this._current);
		}

		// Token: 0x06000946 RID: 2374
		// RVA: 0x0003E18C File Offset: 0x0003C38C
		private bool ReadInto(JContainer c)
		{
			JToken first = c.First;
			if (first == null)
			{
				return this.SetEnd(c);
			}
			this.SetToken(first);
			this._current = first;
			this._parent = c;
			return true;
		}

		// Token: 0x06000943 RID: 2371
		// RVA: 0x0003E0B8 File Offset: 0x0003C2B8
		private bool ReadOver(JToken t)
		{
			if (t == this._root)
			{
				return this.ReadToEnd();
			}
			JToken next = t.Next;
			if (next != null && next != t)
			{
				if (t != t.Parent.Last)
				{
					this._current = next;
					this.SetToken(this._current);
					return true;
				}
			}
			if (t.Parent == null)
			{
				return this.ReadToEnd();
			}
			return this.SetEnd(t.Parent);
		}

		// Token: 0x06000944 RID: 2372
		// RVA: 0x0000B908 File Offset: 0x00009B08
		private bool ReadToEnd()
		{
			this._current = null;
			base.SetToken(JsonToken.None);
			return false;
		}

		// Token: 0x06000949 RID: 2377
		// RVA: 0x0000B919 File Offset: 0x00009B19
		private string SafeToString(object value)
		{
			if (value == null)
			{
				return null;
			}
			return value.ToString();
		}

		// Token: 0x06000947 RID: 2375
		// RVA: 0x0003E1C4 File Offset: 0x0003C3C4
		private bool SetEnd(JContainer c)
		{
			JsonToken? endToken = this.GetEndToken(c);
			if (endToken.HasValue)
			{
				base.SetToken(endToken.Value);
				this._current = c;
				this._parent = c;
				return true;
			}
			return this.ReadOver(c);
		}

		// Token: 0x06000948 RID: 2376
		// RVA: 0x0003E208 File Offset: 0x0003C408
		private void SetToken(JToken token)
		{
			switch (token.Type)
			{
			case JTokenType.Object:
				base.SetToken(JsonToken.StartObject);
				return;
			case JTokenType.Array:
				base.SetToken(JsonToken.StartArray);
				return;
			case JTokenType.Constructor:
				base.SetToken(JsonToken.StartConstructor, ((JConstructor)token).Name);
				return;
			case JTokenType.Property:
				base.SetToken(JsonToken.PropertyName, ((JProperty)token).Name);
				return;
			case JTokenType.Comment:
				base.SetToken(JsonToken.Comment, ((JValue)token).Value);
				return;
			case JTokenType.Integer:
				base.SetToken(JsonToken.Integer, ((JValue)token).Value);
				return;
			case JTokenType.Float:
				base.SetToken(JsonToken.Float, ((JValue)token).Value);
				return;
			case JTokenType.String:
				base.SetToken(JsonToken.String, ((JValue)token).Value);
				return;
			case JTokenType.Boolean:
				base.SetToken(JsonToken.Boolean, ((JValue)token).Value);
				return;
			case JTokenType.Null:
				base.SetToken(JsonToken.Null, ((JValue)token).Value);
				return;
			case JTokenType.Undefined:
				base.SetToken(JsonToken.Undefined, ((JValue)token).Value);
				return;
			case JTokenType.Date:
				base.SetToken(JsonToken.Date, ((JValue)token).Value);
				return;
			case JTokenType.Raw:
				base.SetToken(JsonToken.Raw, ((JValue)token).Value);
				return;
			case JTokenType.Bytes:
				base.SetToken(JsonToken.Bytes, ((JValue)token).Value);
				return;
			case JTokenType.Guid:
				base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
				return;
			case JTokenType.Uri:
				base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
				return;
			case JTokenType.TimeSpan:
				base.SetToken(JsonToken.String, this.SafeToString(((JValue)token).Value));
				return;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", token.Type, "Unexpected JTokenType.");
			}
		}
	}
}
