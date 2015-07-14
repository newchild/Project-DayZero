using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json
{
	// Token: 0x0200001A RID: 26
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x0200001B RID: 27
		protected internal enum State
		{
			// Token: 0x04000060 RID: 96
			Start,
			// Token: 0x04000061 RID: 97
			Complete,
			// Token: 0x04000062 RID: 98
			Property,
			// Token: 0x04000063 RID: 99
			ObjectStart,
			// Token: 0x04000064 RID: 100
			Object,
			// Token: 0x04000065 RID: 101
			ArrayStart,
			// Token: 0x04000066 RID: 102
			Array,
			// Token: 0x04000067 RID: 103
			Closed,
			// Token: 0x04000068 RID: 104
			PostValue,
			// Token: 0x04000069 RID: 105
			ConstructorStart,
			// Token: 0x0400006A RID: 106
			Constructor,
			// Token: 0x0400006B RID: 107
			Error,
			// Token: 0x0400006C RID: 108
			Finished
		}

		// Token: 0x04000055 RID: 85
		private CultureInfo _culture;

		// Token: 0x04000054 RID: 84
		private JsonPosition _currentPosition;

		// Token: 0x04000052 RID: 82
		internal JsonReader.State _currentState;

		// Token: 0x0400005B RID: 91
		private string _dateFormatString;

		// Token: 0x04000059 RID: 89
		internal DateParseHandling _dateParseHandling;

		// Token: 0x04000056 RID: 86
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x0400005A RID: 90
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x04000058 RID: 88
		private bool _hasExceededMaxDepth;

		// Token: 0x04000057 RID: 87
		private int? _maxDepth;

		// Token: 0x04000051 RID: 81
		internal char _quoteChar;

		// Token: 0x04000053 RID: 83
		internal ReadType _readType;

		// Token: 0x0400005C RID: 92
		private readonly List<JsonPosition> _stack;

		// Token: 0x0400004F RID: 79
		private JsonToken _tokenType;

		// Token: 0x04000050 RID: 80
		private object _value;

		// Token: 0x17000004 RID: 4
		public bool CloseInput
		{
			// Token: 0x0600005B RID: 91
			// RVA: 0x00005FB1 File Offset: 0x000041B1
			get;
			// Token: 0x0600005C RID: 92
			// RVA: 0x00005FB9 File Offset: 0x000041B9
			set;
		}

		// Token: 0x17000011 RID: 17
		public CultureInfo Culture
		{
			// Token: 0x06000070 RID: 112
			// RVA: 0x00006057 File Offset: 0x00004257
			get
			{
				return this._culture ?? CultureInfo.InvariantCulture;
			}
			// Token: 0x06000071 RID: 113
			// RVA: 0x00006068 File Offset: 0x00004268
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		protected JsonReader.State CurrentState
		{
			// Token: 0x0600005A RID: 90
			// RVA: 0x00005FA9 File Offset: 0x000041A9
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x1700000A RID: 10
		public string DateFormatString
		{
			// Token: 0x06000067 RID: 103
			// RVA: 0x00006017 File Offset: 0x00004217
			get
			{
				return this._dateFormatString;
			}
			// Token: 0x06000068 RID: 104
			// RVA: 0x0000601F File Offset: 0x0000421F
			set
			{
				this._dateFormatString = value;
			}
		}

		// Token: 0x17000008 RID: 8
		public DateParseHandling DateParseHandling
		{
			// Token: 0x06000063 RID: 99
			// RVA: 0x00005FF5 File Offset: 0x000041F5
			get
			{
				return this._dateParseHandling;
			}
			// Token: 0x06000064 RID: 100
			// RVA: 0x00005FFD File Offset: 0x000041FD
			set
			{
				this._dateParseHandling = value;
			}
		}

		// Token: 0x17000007 RID: 7
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			// Token: 0x06000061 RID: 97
			// RVA: 0x00005FE4 File Offset: 0x000041E4
			get
			{
				return this._dateTimeZoneHandling;
			}
			// Token: 0x06000062 RID: 98
			// RVA: 0x00005FEC File Offset: 0x000041EC
			set
			{
				this._dateTimeZoneHandling = value;
			}
		}

		// Token: 0x1700000F RID: 15
		public virtual int Depth
		{
			// Token: 0x0600006E RID: 110
			// RVA: 0x00028C64 File Offset: 0x00026E64
			get
			{
				int count = this._stack.Count;
				if (!JsonTokenUtils.IsStartToken(this.TokenType) && this._currentPosition.Type != JsonContainerType.None)
				{
					return count + 1;
				}
				return count;
			}
		}

		// Token: 0x17000009 RID: 9
		public FloatParseHandling FloatParseHandling
		{
			// Token: 0x06000065 RID: 101
			// RVA: 0x00006006 File Offset: 0x00004206
			get
			{
				return this._floatParseHandling;
			}
			// Token: 0x06000066 RID: 102
			// RVA: 0x0000600E File Offset: 0x0000420E
			set
			{
				this._floatParseHandling = value;
			}
		}

		// Token: 0x1700000B RID: 11
		public int? MaxDepth
		{
			// Token: 0x06000069 RID: 105
			// RVA: 0x00006028 File Offset: 0x00004228
			get
			{
				return this._maxDepth;
			}
			// Token: 0x0600006A RID: 106
			// RVA: 0x00028C28 File Offset: 0x00026E28
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this._maxDepth = value;
			}
		}

		// Token: 0x17000010 RID: 16
		public virtual string Path
		{
			// Token: 0x0600006F RID: 111
			// RVA: 0x00028C9C File Offset: 0x00026E9C
			get
			{
				if (this._currentPosition.Type == JsonContainerType.None)
				{
					return string.Empty;
				}
				IEnumerable<JsonPosition> positions = (this._currentState == JsonReader.State.ArrayStart || this._currentState == JsonReader.State.ConstructorStart || this._currentState == JsonReader.State.ObjectStart) ? this._stack : Enumerable.Concat<JsonPosition>(this._stack, new JsonPosition[]
				{
					this._currentPosition
				});
				return JsonPosition.BuildPath(positions);
			}
		}

		// Token: 0x17000006 RID: 6
		public virtual char QuoteChar
		{
			// Token: 0x0600005F RID: 95
			// RVA: 0x00005FD3 File Offset: 0x000041D3
			get
			{
				return this._quoteChar;
			}
			// Token: 0x06000060 RID: 96
			// RVA: 0x00005FDB File Offset: 0x000041DB
			protected internal set
			{
				this._quoteChar = value;
			}
		}

		// Token: 0x17000005 RID: 5
		public bool SupportMultipleContent
		{
			// Token: 0x0600005D RID: 93
			// RVA: 0x00005FC2 File Offset: 0x000041C2
			get;
			// Token: 0x0600005E RID: 94
			// RVA: 0x00005FCA File Offset: 0x000041CA
			set;
		}

		// Token: 0x1700000C RID: 12
		public virtual JsonToken TokenType
		{
			// Token: 0x0600006B RID: 107
			// RVA: 0x00006030 File Offset: 0x00004230
			get
			{
				return this._tokenType;
			}
		}

		// Token: 0x1700000D RID: 13
		public virtual object Value
		{
			// Token: 0x0600006C RID: 108
			// RVA: 0x00006038 File Offset: 0x00004238
			get
			{
				return this._value;
			}
		}

		// Token: 0x1700000E RID: 14
		public virtual Type ValueType
		{
			// Token: 0x0600006D RID: 109
			// RVA: 0x00006040 File Offset: 0x00004240
			get
			{
				if (this._value == null)
				{
					return null;
				}
				return this._value.GetType();
			}
		}

		// Token: 0x06000073 RID: 115
		// RVA: 0x00006094 File Offset: 0x00004294
		protected JsonReader()
		{
			this._currentState = JsonReader.State.Start;
			this._stack = new List<JsonPosition>(4);
			this._dateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
			this._dateParseHandling = DateParseHandling.DateTime;
			this._floatParseHandling = FloatParseHandling.Double;
			this.CloseInput = true;
		}

		// Token: 0x06000090 RID: 144
		// RVA: 0x00006170 File Offset: 0x00004370
		public virtual void Close()
		{
			this._currentState = JsonReader.State.Closed;
			this._tokenType = JsonToken.None;
			this._value = null;
		}

		// Token: 0x0600008F RID: 143
		// RVA: 0x0000615C File Offset: 0x0000435C
		protected virtual void Dispose(bool disposing)
		{
			if (this._currentState != JsonReader.State.Closed && disposing)
			{
				this.Close();
			}
		}

		// Token: 0x06000072 RID: 114
		// RVA: 0x00006071 File Offset: 0x00004271
		internal JsonPosition GetPosition(int depth)
		{
			if (depth < this._stack.Count)
			{
				return this._stack[depth];
			}
			return this._currentPosition;
		}

		// Token: 0x0600008D RID: 141
		// RVA: 0x0002973C File Offset: 0x0002793C
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			switch (token)
			{
			case JsonToken.EndObject:
				return JsonContainerType.Object;
			case JsonToken.EndArray:
				return JsonContainerType.Array;
			case JsonToken.EndConstructor:
				return JsonContainerType.Constructor;
			default:
				throw JsonReaderException.Create(this, StringUtils.FormatWith("Not a valid close JsonToken: {0}", CultureInfo.InvariantCulture, token));
			}
		}

		// Token: 0x06000083 RID: 131
		// RVA: 0x000294B4 File Offset: 0x000276B4
		private bool IsWrappedInTypeObject()
		{
			this._readType = ReadType.Read;
			if (this.TokenType != JsonToken.StartObject)
			{
				return false;
			}
			if (!this.ReadInternal())
			{
				throw JsonReaderException.Create(this, "Unexpected end when reading bytes.");
			}
			if (this.Value.ToString() == "$type")
			{
				this.ReadInternal();
				if (this.Value != null && this.Value.ToString().StartsWith("System.Byte[]", StringComparison.Ordinal))
				{
					this.ReadInternal();
					if (this.Value.ToString() == "$value")
					{
						return true;
					}
				}
			}
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading bytes. Unexpected token: {0}.", CultureInfo.InvariantCulture, JsonToken.StartObject));
		}

		// Token: 0x06000076 RID: 118
		// RVA: 0x000060CB File Offset: 0x000042CB
		private JsonContainerType Peek()
		{
			return this._currentPosition.Type;
		}

		// Token: 0x06000075 RID: 117
		// RVA: 0x00028DC4 File Offset: 0x00026FC4
		private JsonContainerType Pop()
		{
			JsonPosition currentPosition;
			if (this._stack.Count > 0)
			{
				currentPosition = this._currentPosition;
				this._currentPosition = this._stack[this._stack.Count - 1];
				this._stack.RemoveAt(this._stack.Count - 1);
			}
			else
			{
				currentPosition = this._currentPosition;
				this._currentPosition = default(JsonPosition);
			}
			if (this._maxDepth.HasValue && this.Depth <= this._maxDepth)
			{
				this._hasExceededMaxDepth = false;
			}
			return currentPosition.Type;
		}

		// Token: 0x06000074 RID: 116
		// RVA: 0x00028D14 File Offset: 0x00026F14
		private void Push(JsonContainerType value)
		{
			this.UpdateScopeWithFinishedValue();
			if (this._currentPosition.Type == JsonContainerType.None)
			{
				this._currentPosition = new JsonPosition(value);
				return;
			}
			this._stack.Add(this._currentPosition);
			this._currentPosition = new JsonPosition(value);
			if (this._maxDepth.HasValue && this.Depth + 1 > this._maxDepth && !this._hasExceededMaxDepth)
			{
				this._hasExceededMaxDepth = true;
				throw JsonReaderException.Create(this, StringUtils.FormatWith("The reader's MaxDepth of {0} has been exceeded.", CultureInfo.InvariantCulture, this._maxDepth));
			}
		}

		// Token: 0x06000077 RID: 119
		public abstract bool Read();

		// Token: 0x0600007A RID: 122
		public abstract byte[] ReadAsBytes();

		// Token: 0x0600007E RID: 126
		// RVA: 0x00028E70 File Offset: 0x00027070
		internal byte[] ReadAsBytesInternal()
		{
			this._readType = ReadType.ReadAsBytes;
			while (this.ReadInternal())
			{
				JsonToken tokenType = this.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (this.IsWrappedInTypeObject())
					{
						byte[] array = this.ReadAsBytes();
						this.ReadInternal();
						this.SetToken(JsonToken.Bytes, array, false);
						return array;
					}
					if (tokenType == JsonToken.String)
					{
						string text = (string)this.Value;
						byte[] array2;
						Guid guid;
						if (text.Length == 0)
						{
							array2 = new byte[0];
						}
						else if (ConvertUtils.TryConvertGuid(text, out guid))
						{
							array2 = guid.ToByteArray();
						}
						else
						{
							array2 = Convert.FromBase64String(text);
						}
						this.SetToken(JsonToken.Bytes, array2, false);
						return array2;
					}
					if (tokenType == JsonToken.Null)
					{
						return null;
					}
					if (tokenType == JsonToken.Bytes)
					{
						if (this.ValueType == typeof(Guid))
						{
							byte[] array3 = ((Guid)this.Value).ToByteArray();
							this.SetToken(JsonToken.Bytes, array3, false);
							return array3;
						}
						return (byte[])this.Value;
					}
					else
					{
						if (tokenType == JsonToken.StartArray)
						{
							List<byte> list = new List<byte>();
							while (this.ReadInternal())
							{
								tokenType = this.TokenType;
								JsonToken jsonToken = tokenType;
								switch (jsonToken)
								{
								case JsonToken.Comment:
									continue;
								case JsonToken.Raw:
									break;
								case JsonToken.Integer:
									list.Add(Convert.ToByte(this.Value, CultureInfo.InvariantCulture));
									continue;
								default:
									if (jsonToken == JsonToken.EndArray)
									{
										byte[] array4 = list.ToArray();
										this.SetToken(JsonToken.Bytes, array4, false);
										return array4;
									}
									break;
								}
								throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected token when reading bytes: {0}.", CultureInfo.InvariantCulture, tokenType));
							}
							throw JsonReaderException.Create(this, "Unexpected end when reading bytes.");
						}
						if (tokenType == JsonToken.EndArray)
						{
							return null;
						}
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading bytes. Unexpected token: {0}.", CultureInfo.InvariantCulture, tokenType));
					}
				}
			}
			this.SetToken(JsonToken.None);
			return null;
		}

		// Token: 0x0600007C RID: 124
		public abstract DateTime? ReadAsDateTime();

		// Token: 0x06000082 RID: 130
		// RVA: 0x00029344 File Offset: 0x00027544
		internal DateTime? ReadAsDateTimeInternal()
		{
			this._readType = ReadType.ReadAsDateTime;
			while (this.ReadInternal())
			{
				if (this.TokenType != JsonToken.Comment)
				{
					if (this.TokenType == JsonToken.Date)
					{
						return new DateTime?((DateTime)this.Value);
					}
					if (this.TokenType == JsonToken.Null)
					{
						return null;
					}
					if (this.TokenType == JsonToken.String)
					{
						string text = (string)this.Value;
						if (string.IsNullOrEmpty(text))
						{
							this.SetToken(JsonToken.Null);
							return null;
						}
						object obj;
						DateTime dateTime;
						if (DateTimeUtils.TryParseDateTime(text, DateParseHandling.DateTime, this.DateTimeZoneHandling, this._dateFormatString, this.Culture, out obj))
						{
							dateTime = (DateTime)obj;
							dateTime = DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
							this.SetToken(JsonToken.Date, dateTime, false);
							return new DateTime?(dateTime);
						}
						if (DateTime.TryParse(text, this.Culture, DateTimeStyles.RoundtripKind, out dateTime))
						{
							dateTime = DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
							this.SetToken(JsonToken.Date, dateTime, false);
							return new DateTime?(dateTime);
						}
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Could not convert string to DateTime: {0}.", CultureInfo.InvariantCulture, this.Value));
					}
					else
					{
						if (this.TokenType == JsonToken.EndArray)
						{
							return null;
						}
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading date. Unexpected token: {0}.", CultureInfo.InvariantCulture, this.TokenType));
					}
				}
			}
			this.SetToken(JsonToken.None);
			return null;
		}

		// Token: 0x0600007B RID: 123
		public abstract decimal? ReadAsDecimal();

		// Token: 0x0600007F RID: 127
		// RVA: 0x00029018 File Offset: 0x00027218
		internal decimal? ReadAsDecimalInternal()
		{
			this._readType = ReadType.ReadAsDecimal;
			while (this.ReadInternal())
			{
				JsonToken tokenType = this.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.Integer)
					{
						if (tokenType != JsonToken.Float)
						{
							if (tokenType == JsonToken.Null)
							{
								return null;
							}
							if (tokenType == JsonToken.String)
							{
								string text = (string)this.Value;
								if (string.IsNullOrEmpty(text))
								{
									this.SetToken(JsonToken.Null);
									return null;
								}
								decimal num;
								if (decimal.TryParse(text, NumberStyles.Number, this.Culture, out num))
								{
									this.SetToken(JsonToken.Float, num, false);
									return new decimal?(num);
								}
								throw JsonReaderException.Create(this, StringUtils.FormatWith("Could not convert string to decimal: {0}.", CultureInfo.InvariantCulture, this.Value));
							}
							else
							{
								if (tokenType == JsonToken.EndArray)
								{
									return null;
								}
								throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading decimal. Unexpected token: {0}.", CultureInfo.InvariantCulture, tokenType));
							}
						}
					}
					if (!(this.Value is decimal))
					{
						this.SetToken(JsonToken.Float, Convert.ToDecimal(this.Value, CultureInfo.InvariantCulture), false);
					}
					return new decimal?((decimal)this.Value);
				}
			}
			this.SetToken(JsonToken.None);
			return null;
		}

		// Token: 0x06000078 RID: 120
		public abstract int? ReadAsInt32();

		// Token: 0x06000080 RID: 128
		// RVA: 0x0002914C File Offset: 0x0002734C
		internal int? ReadAsInt32Internal()
		{
			this._readType = ReadType.ReadAsInt32;
			while (this.ReadInternal())
			{
				JsonToken tokenType = this.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.Integer)
					{
						if (tokenType != JsonToken.Float)
						{
							if (tokenType == JsonToken.Null)
							{
								return null;
							}
							if (tokenType == JsonToken.String)
							{
								string text = (string)this.Value;
								if (string.IsNullOrEmpty(text))
								{
									this.SetToken(JsonToken.Null);
									return null;
								}
								int num;
								if (int.TryParse(text, NumberStyles.Integer, this.Culture, out num))
								{
									this.SetToken(JsonToken.Integer, num, false);
									return new int?(num);
								}
								throw JsonReaderException.Create(this, StringUtils.FormatWith("Could not convert string to integer: {0}.", CultureInfo.InvariantCulture, this.Value));
							}
							else
							{
								if (tokenType == JsonToken.EndArray)
								{
									return null;
								}
								throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading integer. Unexpected token: {0}.", CultureInfo.InvariantCulture, this.TokenType));
							}
						}
					}
					if (!(this.Value is int))
					{
						this.SetToken(JsonToken.Integer, Convert.ToInt32(this.Value, CultureInfo.InvariantCulture), false);
					}
					return new int?((int)this.Value);
				}
			}
			this.SetToken(JsonToken.None);
			return null;
		}

		// Token: 0x06000079 RID: 121
		public abstract string ReadAsString();

		// Token: 0x06000081 RID: 129
		// RVA: 0x00029284 File Offset: 0x00027484
		internal string ReadAsStringInternal()
		{
			this._readType = ReadType.ReadAsString;
			while (this.ReadInternal())
			{
				JsonToken tokenType = this.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType == JsonToken.String)
					{
						return (string)this.Value;
					}
					if (tokenType == JsonToken.Null)
					{
						return null;
					}
					if (JsonTokenUtils.IsPrimitiveToken(tokenType) && this.Value != null)
					{
						string text;
						if (this.Value is IFormattable)
						{
							text = ((IFormattable)this.Value).ToString(null, this.Culture);
						}
						else
						{
							text = this.Value.ToString();
						}
						this.SetToken(JsonToken.String, text, false);
						return text;
					}
					if (tokenType == JsonToken.EndArray)
					{
						return null;
					}
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Error reading string. Unexpected token: {0}.", CultureInfo.InvariantCulture, tokenType));
				}
			}
			this.SetToken(JsonToken.None);
			return null;
		}

		// Token: 0x0600007D RID: 125
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal virtual bool ReadInternal()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600008C RID: 140
		// RVA: 0x00006139 File Offset: 0x00004339
		private void SetFinished()
		{
			if (this.SupportMultipleContent)
			{
				this._currentState = JsonReader.State.Start;
				return;
			}
			this._currentState = JsonReader.State.Finished;
		}

		// Token: 0x06000088 RID: 136
		// RVA: 0x000060F5 File Offset: 0x000042F5
		internal void SetPostValueState(bool updateIndex)
		{
			if (this.Peek() != JsonContainerType.None)
			{
				this._currentState = JsonReader.State.PostValue;
			}
			else
			{
				this.SetFinished();
			}
			if (updateIndex)
			{
				this.UpdateScopeWithFinishedValue();
			}
		}

		// Token: 0x0600008B RID: 139
		// RVA: 0x000296D4 File Offset: 0x000278D4
		protected void SetStateBasedOnCurrent()
		{
			JsonContainerType jsonContainerType = this.Peek();
			switch (jsonContainerType)
			{
			case JsonContainerType.None:
				this.SetFinished();
				return;
			case JsonContainerType.Object:
				this._currentState = JsonReader.State.Object;
				return;
			case JsonContainerType.Array:
				this._currentState = JsonReader.State.Array;
				return;
			case JsonContainerType.Constructor:
				this._currentState = JsonReader.State.Constructor;
				return;
			default:
				throw JsonReaderException.Create(this, StringUtils.FormatWith("While setting the reader state back to current object an unexpected JsonType was encountered: {0}", CultureInfo.InvariantCulture, jsonContainerType));
			}
		}

		// Token: 0x06000085 RID: 133
		// RVA: 0x000060DF File Offset: 0x000042DF
		protected void SetToken(JsonToken newToken)
		{
			this.SetToken(newToken, null, true);
		}

		// Token: 0x06000086 RID: 134
		// RVA: 0x000060EA File Offset: 0x000042EA
		protected void SetToken(JsonToken newToken, object value)
		{
			this.SetToken(newToken, value, true);
		}

		// Token: 0x06000087 RID: 135
		// RVA: 0x000295A8 File Offset: 0x000277A8
		internal void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
			this._tokenType = newToken;
			this._value = value;
			switch (newToken)
			{
			case JsonToken.StartObject:
				this._currentState = JsonReader.State.ObjectStart;
				this.Push(JsonContainerType.Object);
				return;
			case JsonToken.StartArray:
				this._currentState = JsonReader.State.ArrayStart;
				this.Push(JsonContainerType.Array);
				return;
			case JsonToken.StartConstructor:
				this._currentState = JsonReader.State.ConstructorStart;
				this.Push(JsonContainerType.Constructor);
				return;
			case JsonToken.PropertyName:
				this._currentState = JsonReader.State.Property;
				this._currentPosition.PropertyName = (string)value;
				return;
			case JsonToken.Comment:
				break;
			case JsonToken.Raw:
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Null:
			case JsonToken.Undefined:
			case JsonToken.Date:
			case JsonToken.Bytes:
				this.SetPostValueState(updateIndex);
				break;
			case JsonToken.EndObject:
				this.ValidateEnd(JsonToken.EndObject);
				return;
			case JsonToken.EndArray:
				this.ValidateEnd(JsonToken.EndArray);
				return;
			case JsonToken.EndConstructor:
				this.ValidateEnd(JsonToken.EndConstructor);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000084 RID: 132
		// RVA: 0x00029564 File Offset: 0x00027764
		public void Skip()
		{
			if (this.TokenType == JsonToken.PropertyName)
			{
				this.Read();
			}
			if (JsonTokenUtils.IsStartToken(this.TokenType))
			{
				int depth = this.Depth;
				while (this.Read() && depth < this.Depth)
				{
				}
			}
		}

		// Token: 0x0600008E RID: 142
		// RVA: 0x00006153 File Offset: 0x00004353
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06000089 RID: 137
		// RVA: 0x00006117 File Offset: 0x00004317
		private void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				this._currentPosition.Position = this._currentPosition.Position + 1;
			}
		}

		// Token: 0x0600008A RID: 138
		// RVA: 0x0002967C File Offset: 0x0002787C
		private void ValidateEnd(JsonToken endToken)
		{
			JsonContainerType jsonContainerType = this.Pop();
			if (this.GetTypeForCloseToken(endToken) != jsonContainerType)
			{
				throw JsonReaderException.Create(this, StringUtils.FormatWith("JsonToken {0} is not valid for closing JsonType {1}.", CultureInfo.InvariantCulture, endToken, jsonContainerType));
			}
			if (this.Peek() != JsonContainerType.None)
			{
				this._currentState = JsonReader.State.PostValue;
				return;
			}
			this.SetFinished();
		}
	}
}
