using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json
{
	// Token: 0x02000028 RID: 40
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x02000029 RID: 41
		internal enum State
		{
			// Token: 0x040000B9 RID: 185
			Start,
			// Token: 0x040000BA RID: 186
			Property,
			// Token: 0x040000BB RID: 187
			ObjectStart,
			// Token: 0x040000BC RID: 188
			Object,
			// Token: 0x040000BD RID: 189
			ArrayStart,
			// Token: 0x040000BE RID: 190
			Array,
			// Token: 0x040000BF RID: 191
			ConstructorStart,
			// Token: 0x040000C0 RID: 192
			Constructor,
			// Token: 0x040000C1 RID: 193
			Closed,
			// Token: 0x040000C2 RID: 194
			Error
		}

		// Token: 0x040000AB RID: 171
		private static readonly JsonWriter.State[][] StateArray;

		// Token: 0x040000AC RID: 172
		internal static readonly JsonWriter.State[][] StateArrayTempate;

		// Token: 0x040000B6 RID: 182
		private CultureInfo _culture;

		// Token: 0x040000AE RID: 174
		private JsonPosition _currentPosition;

		// Token: 0x040000AF RID: 175
		private JsonWriter.State _currentState;

		// Token: 0x040000B1 RID: 177
		private DateFormatHandling _dateFormatHandling;

		// Token: 0x040000B5 RID: 181
		private string _dateFormatString;

		// Token: 0x040000B2 RID: 178
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x040000B4 RID: 180
		private FloatFormatHandling _floatFormatHandling;

		// Token: 0x040000B0 RID: 176
		private Formatting _formatting;

		// Token: 0x040000AD RID: 173
		private readonly List<JsonPosition> _stack;

		// Token: 0x040000B3 RID: 179
		private StringEscapeHandling _stringEscapeHandling;

		// Token: 0x17000024 RID: 36
		public bool CloseOutput
		{
			// Token: 0x060000E2 RID: 226
			// RVA: 0x000064C3 File Offset: 0x000046C3
			get;
			// Token: 0x060000E3 RID: 227
			// RVA: 0x000064CB File Offset: 0x000046CB
			set;
		}

		// Token: 0x17000027 RID: 39
		internal string ContainerPath
		{
			// Token: 0x060000E6 RID: 230
			// RVA: 0x000064D4 File Offset: 0x000046D4
			get
			{
				if (this._currentPosition.Type == JsonContainerType.None)
				{
					return string.Empty;
				}
				return JsonPosition.BuildPath(this._stack);
			}
		}

		// Token: 0x1700002F RID: 47
		public CultureInfo Culture
		{
			// Token: 0x060000F5 RID: 245
			// RVA: 0x00006562 File Offset: 0x00004762
			get
			{
				return this._culture ?? CultureInfo.InvariantCulture;
			}
			// Token: 0x060000F6 RID: 246
			// RVA: 0x00006573 File Offset: 0x00004773
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x1700002A RID: 42
		public DateFormatHandling DateFormatHandling
		{
			// Token: 0x060000EA RID: 234
			// RVA: 0x00006505 File Offset: 0x00004705
			get
			{
				return this._dateFormatHandling;
			}
			// Token: 0x060000EB RID: 235
			// RVA: 0x0000650D File Offset: 0x0000470D
			set
			{
				this._dateFormatHandling = value;
			}
		}

		// Token: 0x1700002E RID: 46
		public string DateFormatString
		{
			// Token: 0x060000F3 RID: 243
			// RVA: 0x00006551 File Offset: 0x00004751
			get
			{
				return this._dateFormatString;
			}
			// Token: 0x060000F4 RID: 244
			// RVA: 0x00006559 File Offset: 0x00004759
			set
			{
				this._dateFormatString = value;
			}
		}

		// Token: 0x1700002B RID: 43
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			// Token: 0x060000EC RID: 236
			// RVA: 0x00006516 File Offset: 0x00004716
			get
			{
				return this._dateTimeZoneHandling;
			}
			// Token: 0x060000ED RID: 237
			// RVA: 0x0000651E File Offset: 0x0000471E
			set
			{
				this._dateTimeZoneHandling = value;
			}
		}

		// Token: 0x1700002D RID: 45
		public FloatFormatHandling FloatFormatHandling
		{
			// Token: 0x060000F1 RID: 241
			// RVA: 0x00006540 File Offset: 0x00004740
			get
			{
				return this._floatFormatHandling;
			}
			// Token: 0x060000F2 RID: 242
			// RVA: 0x00006548 File Offset: 0x00004748
			set
			{
				this._floatFormatHandling = value;
			}
		}

		// Token: 0x17000029 RID: 41
		public Formatting Formatting
		{
			// Token: 0x060000E8 RID: 232
			// RVA: 0x000064F4 File Offset: 0x000046F4
			get
			{
				return this._formatting;
			}
			// Token: 0x060000E9 RID: 233
			// RVA: 0x000064FC File Offset: 0x000046FC
			set
			{
				this._formatting = value;
			}
		}

		// Token: 0x17000028 RID: 40
		public string Path
		{
			// Token: 0x060000E7 RID: 231
			// RVA: 0x0002A600 File Offset: 0x00028800
			get
			{
				if (this._currentPosition.Type == JsonContainerType.None)
				{
					return string.Empty;
				}
				IEnumerable<JsonPosition> positions = (this._currentState == JsonWriter.State.ArrayStart || this._currentState == JsonWriter.State.ConstructorStart || this._currentState == JsonWriter.State.ObjectStart) ? this._stack : Enumerable.Concat<JsonPosition>(this._stack, new JsonPosition[]
				{
					this._currentPosition
				});
				return JsonPosition.BuildPath(positions);
			}
		}

		// Token: 0x1700002C RID: 44
		public StringEscapeHandling StringEscapeHandling
		{
			// Token: 0x060000EE RID: 238
			// RVA: 0x00006527 File Offset: 0x00004727
			get
			{
				return this._stringEscapeHandling;
			}
			// Token: 0x060000EF RID: 239
			// RVA: 0x0000652F File Offset: 0x0000472F
			set
			{
				this._stringEscapeHandling = value;
				this.OnStringEscapeHandlingChanged();
			}
		}

		// Token: 0x17000025 RID: 37
		protected internal int Top
		{
			// Token: 0x060000E4 RID: 228
			// RVA: 0x0002A56C File Offset: 0x0002876C
			get
			{
				int num = this._stack.Count;
				if (this.Peek() != JsonContainerType.None)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000026 RID: 38
		public WriteState WriteState
		{
			// Token: 0x060000E5 RID: 229
			// RVA: 0x0002A594 File Offset: 0x00028794
			get
			{
				switch (this._currentState)
				{
				case JsonWriter.State.Start:
					return WriteState.Start;
				case JsonWriter.State.Property:
					return WriteState.Property;
				case JsonWriter.State.ObjectStart:
				case JsonWriter.State.Object:
					return WriteState.Object;
				case JsonWriter.State.ArrayStart:
				case JsonWriter.State.Array:
					return WriteState.Array;
				case JsonWriter.State.ConstructorStart:
				case JsonWriter.State.Constructor:
					return WriteState.Constructor;
				case JsonWriter.State.Closed:
					return WriteState.Closed;
				case JsonWriter.State.Error:
					return WriteState.Error;
				default:
					throw JsonWriterException.Create(this, "Invalid state: " + this._currentState, null);
				}
			}
		}

		// Token: 0x060000E1 RID: 225
		// RVA: 0x0002A34C File Offset: 0x0002854C
		static JsonWriter()
		{
			JsonWriter.StateArrayTempate = new JsonWriter.State[][]
			{
				new JsonWriter.State[]
				{
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.ObjectStart,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.ArrayStart,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.ConstructorStart,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.Property,
					JsonWriter.State.Error,
					JsonWriter.State.Property,
					JsonWriter.State.Property,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.Start,
					JsonWriter.State.Property,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.Object,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.Array,
					JsonWriter.State.Constructor,
					JsonWriter.State.Constructor,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.Start,
					JsonWriter.State.Property,
					JsonWriter.State.ObjectStart,
					JsonWriter.State.Object,
					JsonWriter.State.ArrayStart,
					JsonWriter.State.Array,
					JsonWriter.State.Constructor,
					JsonWriter.State.Constructor,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				},
				new JsonWriter.State[]
				{
					JsonWriter.State.Start,
					JsonWriter.State.Object,
					JsonWriter.State.Error,
					JsonWriter.State.Error,
					JsonWriter.State.Array,
					JsonWriter.State.Array,
					JsonWriter.State.Constructor,
					JsonWriter.State.Constructor,
					JsonWriter.State.Error,
					JsonWriter.State.Error
				}
			};
			JsonWriter.StateArray = JsonWriter.BuildStateArray();
		}

		// Token: 0x060000F7 RID: 247
		// RVA: 0x0000657C File Offset: 0x0000477C
		protected JsonWriter()
		{
			this._stack = new List<JsonPosition>(4);
			this._currentState = JsonWriter.State.Start;
			this._formatting = Formatting.None;
			this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
			this.CloseOutput = true;
		}

		// Token: 0x06000117 RID: 279
		// RVA: 0x0002ABF0 File Offset: 0x00028DF0
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
			JsonWriter.State state = JsonWriter.StateArray[(int)tokenBeingWritten][(int)this._currentState];
			if (state == JsonWriter.State.Error)
			{
				throw JsonWriterException.Create(this, StringUtils.FormatWith("Token {0} in state {1} would result in an invalid JSON object.", CultureInfo.InvariantCulture, tokenBeingWritten.ToString(), this._currentState.ToString()), null);
			}
			if ((this._currentState == JsonWriter.State.Object || this._currentState == JsonWriter.State.Array || this._currentState == JsonWriter.State.Constructor) && tokenBeingWritten != JsonToken.Comment)
			{
				this.WriteValueDelimiter();
			}
			if (this._formatting == Formatting.Indented)
			{
				if (this._currentState == JsonWriter.State.Property)
				{
					this.WriteIndentSpace();
				}
				if (this._currentState == JsonWriter.State.Array || this._currentState == JsonWriter.State.ArrayStart || this._currentState == JsonWriter.State.Constructor || this._currentState == JsonWriter.State.ConstructorStart || (tokenBeingWritten == JsonToken.PropertyName && this._currentState != JsonWriter.State.Start))
				{
					this.WriteIndent();
				}
			}
			this._currentState = state;
		}

		// Token: 0x06000110 RID: 272
		// RVA: 0x0000669D File Offset: 0x0000489D
		private void AutoCompleteAll()
		{
			while (this.Top > 0)
			{
				this.WriteEnd();
			}
		}

		// Token: 0x06000112 RID: 274
		// RVA: 0x0002AACC File Offset: 0x00028CCC
		private void AutoCompleteClose(JsonContainerType type)
		{
			int num = 0;
			if (this._currentPosition.Type == type)
			{
				num = 1;
			}
			else
			{
				int num2 = this.Top - 2;
				for (int i = num2; i >= 0; i--)
				{
					int index = num2 - i;
					if (this._stack[index].Type == type)
					{
						num = i + 2;
						break;
					}
				}
			}
			if (num == 0)
			{
				throw JsonWriterException.Create(this, "No token to close.", null);
			}
			for (int j = 0; j < num; j++)
			{
				JsonToken closeTokenForType = this.GetCloseTokenForType(this.Pop());
				if (this._currentState == JsonWriter.State.Property)
				{
					this.WriteNull();
				}
				if (this._formatting == Formatting.Indented && this._currentState != JsonWriter.State.ObjectStart && this._currentState != JsonWriter.State.ArrayStart)
				{
					this.WriteIndent();
				}
				this.WriteEnd(closeTokenForType);
				JsonContainerType jsonContainerType = this.Peek();
				switch (jsonContainerType)
				{
				case JsonContainerType.None:
					this._currentState = JsonWriter.State.Start;
					break;
				case JsonContainerType.Object:
					this._currentState = JsonWriter.State.Object;
					break;
				case JsonContainerType.Array:
					this._currentState = JsonWriter.State.Array;
					break;
				case JsonContainerType.Constructor:
					this._currentState = JsonWriter.State.Array;
					break;
				default:
					throw JsonWriterException.Create(this, "Unknown JsonType: " + jsonContainerType, null);
				}
			}
		}

		// Token: 0x060000E0 RID: 224
		// RVA: 0x0002A280 File Offset: 0x00028480
		internal static JsonWriter.State[][] BuildStateArray()
		{
			List<JsonWriter.State[]> list = Enumerable.ToList<JsonWriter.State[]>(JsonWriter.StateArrayTempate);
			JsonWriter.State[] item = JsonWriter.StateArrayTempate[0];
			JsonWriter.State[] item2 = JsonWriter.StateArrayTempate[7];
			using (IEnumerator<object> enumerator = EnumUtils.GetValues(typeof(JsonToken)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					JsonToken jsonToken = (JsonToken)enumerator.Current;
					if (list.Count <= (int)jsonToken)
					{
						switch (jsonToken)
						{
						case JsonToken.Integer:
						case JsonToken.Float:
						case JsonToken.String:
						case JsonToken.Boolean:
						case JsonToken.Null:
						case JsonToken.Undefined:
						case JsonToken.Date:
						case JsonToken.Bytes:
							list.Add(item2);
							continue;
						case JsonToken.EndObject:
						case JsonToken.EndArray:
						case JsonToken.EndConstructor:
							IL_82:
							list.Add(item);
							continue;
						}
						goto IL_82;
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060000FD RID: 253
		// RVA: 0x00006607 File Offset: 0x00004807
		public virtual void Close()
		{
			this.AutoCompleteAll();
		}

		// Token: 0x06000145 RID: 325
		// RVA: 0x000068E0 File Offset: 0x00004AE0
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return JsonWriterException.Create(writer, StringUtils.FormatWith("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.", CultureInfo.InvariantCulture, value.GetType()), null);
		}

		// Token: 0x06000143 RID: 323
		// RVA: 0x000068CF File Offset: 0x00004ACF
		private void Dispose(bool disposing)
		{
			if (this._currentState != JsonWriter.State.Closed)
			{
				this.Close();
			}
		}

		// Token: 0x060000FC RID: 252
		public abstract void Flush();

		// Token: 0x06000111 RID: 273
		// RVA: 0x0002AA88 File Offset: 0x00028C88
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			switch (type)
			{
			case JsonContainerType.Object:
				return JsonToken.EndObject;
			case JsonContainerType.Array:
				return JsonToken.EndArray;
			case JsonContainerType.Constructor:
				return JsonToken.EndConstructor;
			default:
				throw JsonWriterException.Create(this, "No close token for type: " + type, null);
			}
		}

		// Token: 0x0600014D RID: 333
		// RVA: 0x0000695B File Offset: 0x00004B5B
		internal void InternalWriteComment()
		{
			this.AutoComplete(JsonToken.Comment);
		}

		// Token: 0x06000147 RID: 327
		// RVA: 0x000068FE File Offset: 0x00004AFE
		internal void InternalWriteEnd(JsonContainerType container)
		{
			this.AutoCompleteClose(container);
		}

		// Token: 0x06000148 RID: 328
		// RVA: 0x00006907 File Offset: 0x00004B07
		internal void InternalWritePropertyName(string name)
		{
			this._currentPosition.PropertyName = name;
			this.AutoComplete(JsonToken.PropertyName);
		}

		// Token: 0x06000149 RID: 329
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x0600014A RID: 330
		// RVA: 0x0000691C File Offset: 0x00004B1C
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(token);
			this.Push(container);
		}

		// Token: 0x0600014B RID: 331
		// RVA: 0x00006932 File Offset: 0x00004B32
		internal void InternalWriteValue(JsonToken token)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(token);
		}

		// Token: 0x0600014C RID: 332
		// RVA: 0x00006941 File Offset: 0x00004B41
		internal void InternalWriteWhitespace(string ws)
		{
			if (ws != null && !StringUtils.IsWhiteSpace(ws))
			{
				throw JsonWriterException.Create(this, "Only white space characters should be used.", null);
			}
		}

		// Token: 0x060000F0 RID: 240
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x060000FB RID: 251
		// RVA: 0x000065FA File Offset: 0x000047FA
		private JsonContainerType Peek()
		{
			return this._currentPosition.Type;
		}

		// Token: 0x060000FA RID: 250
		// RVA: 0x0002A678 File Offset: 0x00028878
		private JsonContainerType Pop()
		{
			JsonPosition currentPosition = this._currentPosition;
			if (this._stack.Count > 0)
			{
				this._currentPosition = this._stack[this._stack.Count - 1];
				this._stack.RemoveAt(this._stack.Count - 1);
			}
			else
			{
				this._currentPosition = default(JsonPosition);
			}
			return currentPosition.Type;
		}

		// Token: 0x060000F9 RID: 249
		// RVA: 0x000065CE File Offset: 0x000047CE
		private void Push(JsonContainerType value)
		{
			if (this._currentPosition.Type != JsonContainerType.None)
			{
				this._stack.Add(this._currentPosition);
			}
			this._currentPosition = new JsonPosition(value);
		}

		// Token: 0x06000146 RID: 326
		// RVA: 0x0002B284 File Offset: 0x00029484
		protected void SetWriteState(JsonToken token, object value)
		{
			switch (token)
			{
			case JsonToken.StartObject:
				this.InternalWriteStart(token, JsonContainerType.Object);
				return;
			case JsonToken.StartArray:
				this.InternalWriteStart(token, JsonContainerType.Array);
				return;
			case JsonToken.StartConstructor:
				this.InternalWriteStart(token, JsonContainerType.Constructor);
				return;
			case JsonToken.PropertyName:
				if (!(value is string))
				{
					throw new ArgumentException("A name is required when setting property name state.", "value");
				}
				this.InternalWritePropertyName((string)value);
				return;
			case JsonToken.Comment:
				this.InternalWriteComment();
				return;
			case JsonToken.Raw:
				this.InternalWriteRaw();
				return;
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Null:
			case JsonToken.Undefined:
			case JsonToken.Date:
			case JsonToken.Bytes:
				this.InternalWriteValue(token);
				return;
			case JsonToken.EndObject:
				this.InternalWriteEnd(JsonContainerType.Object);
				return;
			case JsonToken.EndArray:
				this.InternalWriteEnd(JsonContainerType.Array);
				return;
			case JsonToken.EndConstructor:
				this.InternalWriteEnd(JsonContainerType.Constructor);
				return;
			default:
				throw new ArgumentOutOfRangeException("token");
			}
		}

		// Token: 0x06000142 RID: 322
		// RVA: 0x000068C6 File Offset: 0x00004AC6
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060000F8 RID: 248
		// RVA: 0x000065AC File Offset: 0x000047AC
		internal void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				this._currentPosition.Position = this._currentPosition.Position + 1;
			}
		}

		// Token: 0x06000140 RID: 320
		// RVA: 0x000068B5 File Offset: 0x00004AB5
		public virtual void WriteComment(string text)
		{
			this.InternalWriteComment();
		}

		// Token: 0x0600010E RID: 270
		// RVA: 0x0002A998 File Offset: 0x00028B98
		private void WriteConstructorDate(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonWriterException.Create(this, "Unexpected end when reading date constructor.", null);
			}
			if (reader.TokenType != JsonToken.Integer)
			{
				throw JsonWriterException.Create(this, "Unexpected token when reading date constructor. Expected Integer, got " + reader.TokenType, null);
			}
			long javaScriptTicks = (long)reader.Value;
			DateTime value = DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
			if (!reader.Read())
			{
				throw JsonWriterException.Create(this, "Unexpected end when reading date constructor.", null);
			}
			if (reader.TokenType != JsonToken.EndConstructor)
			{
				throw JsonWriterException.Create(this, "Unexpected token when reading date constructor. Expected EndConstructor, got " + reader.TokenType, null);
			}
			this.WriteValue(value);
		}

		// Token: 0x06000106 RID: 262
		// RVA: 0x0000665A File Offset: 0x0000485A
		public virtual void WriteEnd()
		{
			this.WriteEnd(this.Peek());
		}

		// Token: 0x0600010F RID: 271
		// RVA: 0x0002AA38 File Offset: 0x00028C38
		private void WriteEnd(JsonContainerType type)
		{
			switch (type)
			{
			case JsonContainerType.Object:
				this.WriteEndObject();
				return;
			case JsonContainerType.Array:
				this.WriteEndArray();
				return;
			case JsonContainerType.Constructor:
				this.WriteEndConstructor();
				return;
			default:
				throw JsonWriterException.Create(this, "Unexpected type when writing end: " + type, null);
			}
		}

		// Token: 0x06000113 RID: 275
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000101 RID: 257
		// RVA: 0x0000662C File Offset: 0x0000482C
		public virtual void WriteEndArray()
		{
			this.InternalWriteEnd(JsonContainerType.Array);
		}

		// Token: 0x06000103 RID: 259
		// RVA: 0x0000663F File Offset: 0x0000483F
		public virtual void WriteEndConstructor()
		{
			this.InternalWriteEnd(JsonContainerType.Constructor);
		}

		// Token: 0x060000FF RID: 255
		// RVA: 0x00006619 File Offset: 0x00004819
		public virtual void WriteEndObject()
		{
			this.InternalWriteEnd(JsonContainerType.Object);
		}

		// Token: 0x06000114 RID: 276
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x06000116 RID: 278
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x06000118 RID: 280
		// RVA: 0x000066B1 File Offset: 0x000048B1
		public virtual void WriteNull()
		{
			this.InternalWriteValue(JsonToken.Null);
		}

		// Token: 0x06000104 RID: 260
		// RVA: 0x00006648 File Offset: 0x00004848
		public virtual void WritePropertyName(string name)
		{
			this.InternalWritePropertyName(name);
		}

		// Token: 0x06000105 RID: 261
		// RVA: 0x00006651 File Offset: 0x00004851
		public virtual void WritePropertyName(string name, bool escape)
		{
			this.WritePropertyName(name);
		}

		// Token: 0x0600011A RID: 282
		// RVA: 0x000066C5 File Offset: 0x000048C5
		public virtual void WriteRaw(string json)
		{
			this.InternalWriteRaw();
		}

		// Token: 0x0600011B RID: 283
		// RVA: 0x000066CD File Offset: 0x000048CD
		public virtual void WriteRawValue(string json)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(JsonToken.Undefined);
			this.WriteRaw(json);
		}

		// Token: 0x06000100 RID: 256
		// RVA: 0x00006622 File Offset: 0x00004822
		public virtual void WriteStartArray()
		{
			this.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
		}

		// Token: 0x06000102 RID: 258
		// RVA: 0x00006635 File Offset: 0x00004835
		public virtual void WriteStartConstructor(string name)
		{
			this.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
		}

		// Token: 0x060000FE RID: 254
		// RVA: 0x0000660F File Offset: 0x0000480F
		public virtual void WriteStartObject()
		{
			this.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
		}

		// Token: 0x06000107 RID: 263
		// RVA: 0x00006668 File Offset: 0x00004868
		public void WriteToken(JsonReader reader)
		{
			this.WriteToken(reader, true, true);
		}

		// Token: 0x0600010A RID: 266
		// RVA: 0x00006693 File Offset: 0x00004893
		public void WriteToken(JsonToken token)
		{
			this.WriteTokenInternal(token, null);
		}

		// Token: 0x06000108 RID: 264
		// RVA: 0x00006673 File Offset: 0x00004873
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			this.WriteToken(reader, writeChildren, true);
		}

		// Token: 0x06000109 RID: 265
		// RVA: 0x00006689 File Offset: 0x00004889
		public void WriteToken(JsonToken token, object value)
		{
			this.WriteTokenInternal(token, value);
		}

		// Token: 0x0600010B RID: 267
		// RVA: 0x0002A6E8 File Offset: 0x000288E8
		internal void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate)
		{
			int initialDepth;
			if (reader.TokenType == JsonToken.None)
			{
				initialDepth = -1;
			}
			else if (!JsonTokenUtils.IsStartToken(reader.TokenType))
			{
				initialDepth = reader.Depth + 1;
			}
			else
			{
				initialDepth = reader.Depth;
			}
			this.WriteToken(reader, initialDepth, writeChildren, writeDateConstructorAsDate);
		}

		// Token: 0x0600010C RID: 268
		// RVA: 0x0002A72C File Offset: 0x0002892C
		internal void WriteToken(JsonReader reader, int initialDepth, bool writeChildren, bool writeDateConstructorAsDate)
		{
			do
			{
				if (writeDateConstructorAsDate && reader.TokenType == JsonToken.StartConstructor && string.Equals(reader.Value.ToString(), "Date", StringComparison.Ordinal))
				{
					this.WriteConstructorDate(reader);
				}
				else
				{
					this.WriteTokenInternal(reader.TokenType, reader.Value);
				}
				if (initialDepth - 1 >= reader.Depth - (JsonTokenUtils.IsEndToken(reader.TokenType) ? 1 : 0) || !writeChildren)
				{
					break;
				}
			}
			while (reader.Read());
		}

		// Token: 0x0600010D RID: 269
		// RVA: 0x0002A7A4 File Offset: 0x000289A4
		private void WriteTokenInternal(JsonToken tokenType, object value)
		{
			switch (tokenType)
			{
			case JsonToken.None:
				return;
			case JsonToken.StartObject:
				this.WriteStartObject();
				return;
			case JsonToken.StartArray:
				this.WriteStartArray();
				return;
			case JsonToken.StartConstructor:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteStartConstructor(value.ToString());
				return;
			case JsonToken.PropertyName:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WritePropertyName(value.ToString());
				return;
			case JsonToken.Comment:
				this.WriteComment((value != null) ? value.ToString() : null);
				return;
			case JsonToken.Raw:
				this.WriteRawValue((value != null) ? value.ToString() : null);
				return;
			case JsonToken.Integer:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteValue(Convert.ToInt64(value, CultureInfo.InvariantCulture));
				return;
			case JsonToken.Float:
				ValidationUtils.ArgumentNotNull(value, "value");
				if (value is decimal)
				{
					this.WriteValue((decimal)value);
					return;
				}
				if (value is double)
				{
					this.WriteValue((double)value);
					return;
				}
				if (value is float)
				{
					this.WriteValue((float)value);
					return;
				}
				this.WriteValue(Convert.ToDouble(value, CultureInfo.InvariantCulture));
				return;
			case JsonToken.String:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteValue(value.ToString());
				return;
			case JsonToken.Boolean:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteValue(Convert.ToBoolean(value, CultureInfo.InvariantCulture));
				return;
			case JsonToken.Null:
				this.WriteNull();
				return;
			case JsonToken.Undefined:
				this.WriteUndefined();
				return;
			case JsonToken.EndObject:
				this.WriteEndObject();
				return;
			case JsonToken.EndArray:
				this.WriteEndArray();
				return;
			case JsonToken.EndConstructor:
				this.WriteEndConstructor();
				return;
			case JsonToken.Date:
				ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteValue(Convert.ToDateTime(value, CultureInfo.InvariantCulture));
				return;
			case JsonToken.Bytes:
				ValidationUtils.ArgumentNotNull(value, "value");
				if (value is Guid)
				{
					this.WriteValue((Guid)value);
					return;
				}
				this.WriteValue((byte[])value);
				return;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("TokenType", tokenType, "Unexpected token type.");
			}
		}

		// Token: 0x06000119 RID: 281
		// RVA: 0x000066BB File Offset: 0x000048BB
		public virtual void WriteUndefined()
		{
			this.InternalWriteValue(JsonToken.Undefined);
		}

		// Token: 0x0600011C RID: 284
		// RVA: 0x000066E4 File Offset: 0x000048E4
		public virtual void WriteValue(string value)
		{
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x0600011D RID: 285
		// RVA: 0x000066EE File Offset: 0x000048EE
		public virtual void WriteValue(int value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x0600011E RID: 286
		// RVA: 0x000066EE File Offset: 0x000048EE
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x0600011F RID: 287
		// RVA: 0x000066EE File Offset: 0x000048EE
		public virtual void WriteValue(long value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000120 RID: 288
		// RVA: 0x000066EE File Offset: 0x000048EE
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000121 RID: 289
		// RVA: 0x000066F7 File Offset: 0x000048F7
		public virtual void WriteValue(float value)
		{
			this.InternalWriteValue(JsonToken.Float);
		}

		// Token: 0x06000122 RID: 290
		// RVA: 0x000066F7 File Offset: 0x000048F7
		public virtual void WriteValue(double value)
		{
			this.InternalWriteValue(JsonToken.Float);
		}

		// Token: 0x06000123 RID: 291
		// RVA: 0x00006700 File Offset: 0x00004900
		public virtual void WriteValue(bool value)
		{
			this.InternalWriteValue(JsonToken.Boolean);
		}

		// Token: 0x06000124 RID: 292
		// RVA: 0x000066EE File Offset: 0x000048EE
		public virtual void WriteValue(short value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000125 RID: 293
		// RVA: 0x000066EE File Offset: 0x000048EE
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000126 RID: 294
		// RVA: 0x000066E4 File Offset: 0x000048E4
		public virtual void WriteValue(char value)
		{
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x06000127 RID: 295
		// RVA: 0x000066EE File Offset: 0x000048EE
		public virtual void WriteValue(byte value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000128 RID: 296
		// RVA: 0x000066EE File Offset: 0x000048EE
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
			this.InternalWriteValue(JsonToken.Integer);
		}

		// Token: 0x06000129 RID: 297
		// RVA: 0x000066F7 File Offset: 0x000048F7
		public virtual void WriteValue(decimal value)
		{
			this.InternalWriteValue(JsonToken.Float);
		}

		// Token: 0x0600012A RID: 298
		// RVA: 0x0000670A File Offset: 0x0000490A
		public virtual void WriteValue(DateTime value)
		{
			this.InternalWriteValue(JsonToken.Date);
		}

		// Token: 0x0600012B RID: 299
		// RVA: 0x000066E4 File Offset: 0x000048E4
		public virtual void WriteValue(Guid value)
		{
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x0600012C RID: 300
		// RVA: 0x000066E4 File Offset: 0x000048E4
		public virtual void WriteValue(TimeSpan value)
		{
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x0600012D RID: 301
		// RVA: 0x00006714 File Offset: 0x00004914
		public virtual void WriteValue(int? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600012E RID: 302
		// RVA: 0x00006733 File Offset: 0x00004933
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600012F RID: 303
		// RVA: 0x00006752 File Offset: 0x00004952
		public virtual void WriteValue(long? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000130 RID: 304
		// RVA: 0x00006771 File Offset: 0x00004971
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000131 RID: 305
		// RVA: 0x00006790 File Offset: 0x00004990
		public virtual void WriteValue(float? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000132 RID: 306
		// RVA: 0x000067AF File Offset: 0x000049AF
		public virtual void WriteValue(double? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000133 RID: 307
		// RVA: 0x000067CE File Offset: 0x000049CE
		public virtual void WriteValue(bool? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000134 RID: 308
		// RVA: 0x0002ACC0 File Offset: 0x00028EC0
		public virtual void WriteValue(short? value)
		{
			short? num = value;
			if (!(num.HasValue ? new int?((int)num.GetValueOrDefault()) : null).HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000135 RID: 309
		// RVA: 0x0002AD10 File Offset: 0x00028F10
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
			ushort? num = value;
			if (!(num.HasValue ? new int?((int)num.GetValueOrDefault()) : null).HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000136 RID: 310
		// RVA: 0x0002AD60 File Offset: 0x00028F60
		public virtual void WriteValue(char? value)
		{
			char? c = value;
			if (!(c.HasValue ? new int?((int)c.GetValueOrDefault()) : null).HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000137 RID: 311
		// RVA: 0x0002ADB0 File Offset: 0x00028FB0
		public virtual void WriteValue(byte? value)
		{
			byte? b = value;
			if (!(b.HasValue ? new int?((int)b.GetValueOrDefault()) : null).HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000138 RID: 312
		// RVA: 0x0002AE00 File Offset: 0x00029000
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
			sbyte? b = value;
			if (!(b.HasValue ? new int?((int)b.GetValueOrDefault()) : null).HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x06000139 RID: 313
		// RVA: 0x000067ED File Offset: 0x000049ED
		public virtual void WriteValue(decimal? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600013A RID: 314
		// RVA: 0x0000680C File Offset: 0x00004A0C
		public virtual void WriteValue(DateTime? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600013B RID: 315
		// RVA: 0x0000682B File Offset: 0x00004A2B
		public virtual void WriteValue(Guid? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600013C RID: 316
		// RVA: 0x0000684A File Offset: 0x00004A4A
		public virtual void WriteValue(TimeSpan? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		// Token: 0x0600013D RID: 317
		// RVA: 0x00006869 File Offset: 0x00004A69
		public virtual void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.InternalWriteValue(JsonToken.Bytes);
		}

		// Token: 0x0600013E RID: 318
		// RVA: 0x0000687D File Offset: 0x00004A7D
		public virtual void WriteValue(Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x0600013F RID: 319
		// RVA: 0x00006897 File Offset: 0x00004A97
		public virtual void WriteValue(object value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			JsonWriter.WriteValue(this, ConvertUtils.GetTypeCode(value.GetType()), value);
		}

		// Token: 0x06000144 RID: 324
		// RVA: 0x0002AE50 File Offset: 0x00029050
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
			switch (typeCode)
			{
			case PrimitiveTypeCode.Char:
				writer.WriteValue((char)value);
				return;
			case PrimitiveTypeCode.CharNullable:
				writer.WriteValue((value == null) ? null : new char?((char)value));
				return;
			case PrimitiveTypeCode.Boolean:
				writer.WriteValue((bool)value);
				return;
			case PrimitiveTypeCode.BooleanNullable:
				writer.WriteValue((value == null) ? null : new bool?((bool)value));
				return;
			case PrimitiveTypeCode.SByte:
				writer.WriteValue((sbyte)value);
				return;
			case PrimitiveTypeCode.SByteNullable:
				writer.WriteValue((value == null) ? null : new sbyte?((sbyte)value));
				return;
			case PrimitiveTypeCode.Int16:
				writer.WriteValue((short)value);
				return;
			case PrimitiveTypeCode.Int16Nullable:
				writer.WriteValue((value == null) ? null : new short?((short)value));
				return;
			case PrimitiveTypeCode.UInt16:
				writer.WriteValue((ushort)value);
				return;
			case PrimitiveTypeCode.UInt16Nullable:
				writer.WriteValue((value == null) ? null : new ushort?((ushort)value));
				return;
			case PrimitiveTypeCode.Int32:
				writer.WriteValue((int)value);
				return;
			case PrimitiveTypeCode.Int32Nullable:
				writer.WriteValue((value == null) ? null : new int?((int)value));
				return;
			case PrimitiveTypeCode.Byte:
				writer.WriteValue((byte)value);
				return;
			case PrimitiveTypeCode.ByteNullable:
				writer.WriteValue((value == null) ? null : new byte?((byte)value));
				return;
			case PrimitiveTypeCode.UInt32:
				writer.WriteValue((uint)value);
				return;
			case PrimitiveTypeCode.UInt32Nullable:
				writer.WriteValue((value == null) ? null : new uint?((uint)value));
				return;
			case PrimitiveTypeCode.Int64:
				writer.WriteValue((long)value);
				return;
			case PrimitiveTypeCode.Int64Nullable:
				writer.WriteValue((value == null) ? null : new long?((long)value));
				return;
			case PrimitiveTypeCode.UInt64:
				writer.WriteValue((ulong)value);
				return;
			case PrimitiveTypeCode.UInt64Nullable:
				writer.WriteValue((value == null) ? null : new ulong?((ulong)value));
				return;
			case PrimitiveTypeCode.Single:
				writer.WriteValue((float)value);
				return;
			case PrimitiveTypeCode.SingleNullable:
				writer.WriteValue((value == null) ? null : new float?((float)value));
				return;
			case PrimitiveTypeCode.Double:
				writer.WriteValue((double)value);
				return;
			case PrimitiveTypeCode.DoubleNullable:
				writer.WriteValue((value == null) ? null : new double?((double)value));
				return;
			case PrimitiveTypeCode.DateTime:
				writer.WriteValue((DateTime)value);
				return;
			case PrimitiveTypeCode.DateTimeNullable:
				writer.WriteValue((value == null) ? null : new DateTime?((DateTime)value));
				return;
			case PrimitiveTypeCode.Decimal:
				writer.WriteValue((decimal)value);
				return;
			case PrimitiveTypeCode.DecimalNullable:
				writer.WriteValue((value == null) ? null : new decimal?((decimal)value));
				return;
			case PrimitiveTypeCode.Guid:
				writer.WriteValue((Guid)value);
				return;
			case PrimitiveTypeCode.GuidNullable:
				writer.WriteValue((value == null) ? null : new Guid?((Guid)value));
				return;
			case PrimitiveTypeCode.TimeSpan:
				writer.WriteValue((TimeSpan)value);
				return;
			case PrimitiveTypeCode.TimeSpanNullable:
				writer.WriteValue((value == null) ? null : new TimeSpan?((TimeSpan)value));
				return;
			case PrimitiveTypeCode.Uri:
				writer.WriteValue((Uri)value);
				return;
			case PrimitiveTypeCode.String:
				writer.WriteValue((string)value);
				return;
			case PrimitiveTypeCode.Bytes:
				writer.WriteValue((byte[])value);
				return;
			case PrimitiveTypeCode.DBNull:
				writer.WriteNull();
				return;
			}
			if (value is IConvertible)
			{
				IConvertible convertible = (IConvertible)value;
				TypeInformation typeInformation = ConvertUtils.GetTypeInformation(convertible);
				PrimitiveTypeCode typeCode2 = (typeInformation.TypeCode == PrimitiveTypeCode.Object) ? PrimitiveTypeCode.String : typeInformation.TypeCode;
				Type conversionType = (typeInformation.TypeCode == PrimitiveTypeCode.Object) ? typeof(string) : typeInformation.Type;
				object value2 = convertible.ToType(conversionType, CultureInfo.InvariantCulture);
				JsonWriter.WriteValue(writer, typeCode2, value2);
				return;
			}
			throw JsonWriter.CreateUnsupportedTypeException(writer, value);
		}

		// Token: 0x06000115 RID: 277
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x06000141 RID: 321
		// RVA: 0x000068BD File Offset: 0x00004ABD
		public virtual void WriteWhitespace(string ws)
		{
			this.InternalWriteWhitespace(ws);
		}
	}
}
