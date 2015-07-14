using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200001C RID: 28
	public sealed class BsonReader : JsonReader
	{
		// Token: 0x0200001D RID: 29
		private enum BsonReaderState
		{
			// Token: 0x0400007D RID: 125
			Normal,
			// Token: 0x0400007E RID: 126
			ReferenceStart,
			// Token: 0x0400007F RID: 127
			ReferenceRef,
			// Token: 0x04000080 RID: 128
			ReferenceId,
			// Token: 0x04000081 RID: 129
			CodeWScopeStart,
			// Token: 0x04000082 RID: 130
			CodeWScopeCode,
			// Token: 0x04000083 RID: 131
			CodeWScopeScope,
			// Token: 0x04000084 RID: 132
			CodeWScopeScopeObject,
			// Token: 0x04000085 RID: 133
			CodeWScopeScopeEnd
		}

		// Token: 0x0200001E RID: 30
		private sealed class ContainerContext
		{
			// Token: 0x04000087 RID: 135
			public int Length;

			// Token: 0x04000088 RID: 136
			public int Position;

			// Token: 0x04000086 RID: 134
			public readonly BsonType Type;

			// Token: 0x060000B9 RID: 185
			// RVA: 0x00006338 File Offset: 0x00004538
			public ContainerContext(BsonType type)
			{
				this.Type = type;
			}
		}

		// Token: 0x0400006D RID: 109
		private const int MaxCharBytesSize = 128;

		// Token: 0x0400006E RID: 110
		private static readonly byte[] SeqRange1 = new byte[]
		{
			0,
			127
		};

		// Token: 0x0400006F RID: 111
		private static readonly byte[] SeqRange2 = new byte[]
		{
			194,
			223
		};

		// Token: 0x04000070 RID: 112
		private static readonly byte[] SeqRange3 = new byte[]
		{
			224,
			239
		};

		// Token: 0x04000071 RID: 113
		private static readonly byte[] SeqRange4 = new byte[]
		{
			240,
			244
		};

		// Token: 0x04000077 RID: 119
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x04000074 RID: 116
		private byte[] _byteBuffer;

		// Token: 0x04000075 RID: 117
		private char[] _charBuffer;

		// Token: 0x04000078 RID: 120
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x04000076 RID: 118
		private BsonType _currentElementType;

		// Token: 0x0400007B RID: 123
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x0400007A RID: 122
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x04000072 RID: 114
		private readonly BinaryReader _reader;

		// Token: 0x04000079 RID: 121
		private bool _readRootValueAsArray;

		// Token: 0x04000073 RID: 115
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x17000014 RID: 20
		public DateTimeKind DateTimeKindHandling
		{
			// Token: 0x06000095 RID: 149
			// RVA: 0x000061A9 File Offset: 0x000043A9
			get
			{
				return this._dateTimeKindHandling;
			}
			// Token: 0x06000096 RID: 150
			// RVA: 0x000061B1 File Offset: 0x000043B1
			set
			{
				this._dateTimeKindHandling = value;
			}
		}

		// Token: 0x17000012 RID: 18
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			// Token: 0x06000091 RID: 145
			// RVA: 0x00006187 File Offset: 0x00004387
			get
			{
				return this._jsonNet35BinaryCompatibility;
			}
			// Token: 0x06000092 RID: 146
			// RVA: 0x0000618F File Offset: 0x0000438F
			set
			{
				this._jsonNet35BinaryCompatibility = value;
			}
		}

		// Token: 0x17000013 RID: 19
		public bool ReadRootValueAsArray
		{
			// Token: 0x06000093 RID: 147
			// RVA: 0x00006198 File Offset: 0x00004398
			get
			{
				return this._readRootValueAsArray;
			}
			// Token: 0x06000094 RID: 148
			// RVA: 0x000061A0 File Offset: 0x000043A0
			set
			{
				this._readRootValueAsArray = value;
			}
		}

		// Token: 0x06000097 RID: 151
		// RVA: 0x000061BA File Offset: 0x000043BA
		public BsonReader(Stream stream) : this(stream, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000098 RID: 152
		// RVA: 0x000061C5 File Offset: 0x000043C5
		public BsonReader(BinaryReader reader) : this(reader, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000099 RID: 153
		// RVA: 0x000061D0 File Offset: 0x000043D0
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(stream, "stream");
			this._reader = new BinaryReader(stream);
			this._stack = new List<BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x0600009A RID: 154
		// RVA: 0x00006208 File Offset: 0x00004408
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._stack = new List<BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x060000B0 RID: 176
		// RVA: 0x0002A124 File Offset: 0x00028324
		private int BytesInSequence(byte b)
		{
			if (b <= BsonReader.SeqRange1[1])
			{
				return 1;
			}
			if (b >= BsonReader.SeqRange2[0] && b <= BsonReader.SeqRange2[1])
			{
				return 2;
			}
			if (b >= BsonReader.SeqRange3[0] && b <= BsonReader.SeqRange3[1])
			{
				return 3;
			}
			if (b >= BsonReader.SeqRange4[0] && b <= BsonReader.SeqRange4[1])
			{
				return 4;
			}
			return 0;
		}

		// Token: 0x060000A3 RID: 163
		// RVA: 0x00006272 File Offset: 0x00004472
		public override void Close()
		{
			base.Close();
			if (base.CloseInput && this._reader != null)
			{
				this._reader.Close();
			}
		}

		// Token: 0x060000B1 RID: 177
		// RVA: 0x0002A180 File Offset: 0x00028380
		private void EnsureBuffers()
		{
			if (this._byteBuffer == null)
			{
				this._byteBuffer = new byte[128];
			}
			if (this._charBuffer == null)
			{
				int maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
				this._charBuffer = new char[maxCharCount];
			}
		}

		// Token: 0x060000AF RID: 175
		// RVA: 0x0002A0E4 File Offset: 0x000282E4
		private int GetLastFullCharStop(int start)
		{
			int i = start;
			int num = 0;
			while (i >= 0)
			{
				num = this.BytesInSequence(this._byteBuffer[i]);
				if (num == 0)
				{
					i--;
				}
				else
				{
					if (num != 1)
					{
						i--;
					}
					IL_2A:
					if (num == start - i)
					{
						return start;
					}
					return i;
				}
			}
			goto IL_2A;
		}

		// Token: 0x060000AE RID: 174
		// RVA: 0x00029FB8 File Offset: 0x000281B8
		private string GetString(int length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			this.EnsureBuffers();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num3;
			while (true)
			{
				int count = (length - num > 128 - num2) ? (128 - num2) : (length - num);
				num3 = this._reader.Read(this._byteBuffer, num2, count);
				if (num3 == 0)
				{
					goto IL_E1;
				}
				num += num3;
				num3 += num2;
				if (num3 == length)
				{
					break;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(length);
				}
				int chars = Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num3 - 1)
				{
					num2 = num3 - lastFullCharStop - 1;
					Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					num2 = 0;
				}
				if (num >= length)
				{
					goto Block_6;
				}
			}
			int chars2 = Encoding.UTF8.GetChars(this._byteBuffer, 0, num3, this._charBuffer, 0);
			return new string(this._charBuffer, 0, chars2);
			Block_6:
			return stringBuilder.ToString();
			IL_E1:
			throw new EndOfStreamException("Unable to read beyond the end of the stream.");
		}

		// Token: 0x060000B6 RID: 182
		// RVA: 0x0000630E File Offset: 0x0000450E
		private void MovePosition(int count)
		{
			this._currentContext.Position += count;
		}

		// Token: 0x060000A7 RID: 167
		// RVA: 0x00029B78 File Offset: 0x00027D78
		private void PopContext()
		{
			this._stack.RemoveAt(this._stack.Count - 1);
			if (this._stack.Count == 0)
			{
				this._currentContext = null;
				return;
			}
			this._currentContext = this._stack[this._stack.Count - 1];
		}

		// Token: 0x060000A8 RID: 168
		// RVA: 0x00006295 File Offset: 0x00004495
		private void PushContext(BsonReader.ContainerContext newContext)
		{
			this._stack.Add(newContext);
			this._currentContext = newContext;
		}

		// Token: 0x060000A1 RID: 161
		// RVA: 0x00006263 File Offset: 0x00004463
		public override bool Read()
		{
			this._readType = Newtonsoft.Json.ReadType.Read;
			return this.ReadInternal();
		}

		// Token: 0x0600009C RID: 156
		// RVA: 0x0000623B File Offset: 0x0000443B
		public override byte[] ReadAsBytes()
		{
			return base.ReadAsBytesInternal();
		}

		// Token: 0x060000A0 RID: 160
		// RVA: 0x0000625B File Offset: 0x0000445B
		public override DateTime? ReadAsDateTime()
		{
			return base.ReadAsDateTimeInternal();
		}

		// Token: 0x0600009D RID: 157
		// RVA: 0x00006243 File Offset: 0x00004443
		public override decimal? ReadAsDecimal()
		{
			return base.ReadAsDecimalInternal();
		}

		// Token: 0x0600009E RID: 158
		// RVA: 0x0000624B File Offset: 0x0000444B
		public override int? ReadAsInt32()
		{
			return base.ReadAsInt32Internal();
		}

		// Token: 0x0600009F RID: 159
		// RVA: 0x00006253 File Offset: 0x00004453
		public override string ReadAsString()
		{
			return base.ReadAsStringInternal();
		}

		// Token: 0x060000AB RID: 171
		// RVA: 0x00029E28 File Offset: 0x00028028
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			int count = this.ReadInt32();
			binaryType = (BsonBinaryType)this.ReadByte();
			if (binaryType == BsonBinaryType.BinaryOld && !this._jsonNet35BinaryCompatibility)
			{
				count = this.ReadInt32();
			}
			return this.ReadBytes(count);
		}

		// Token: 0x060000A9 RID: 169
		// RVA: 0x000062AA File Offset: 0x000044AA
		private byte ReadByte()
		{
			this.MovePosition(1);
			return this._reader.ReadByte();
		}

		// Token: 0x060000B7 RID: 183
		// RVA: 0x00006323 File Offset: 0x00004523
		private byte[] ReadBytes(int count)
		{
			this.MovePosition(count);
			return this._reader.ReadBytes(count);
		}

		// Token: 0x060000A4 RID: 164
		// RVA: 0x00029850 File Offset: 0x00027A50
		private bool ReadCodeWScope()
		{
			switch (this._bsonReaderState)
			{
			case BsonReader.BsonReaderState.CodeWScopeStart:
				base.SetToken(JsonToken.PropertyName, "$code");
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeCode;
				return true;
			case BsonReader.BsonReaderState.CodeWScopeCode:
				this.ReadInt32();
				base.SetToken(JsonToken.String, this.ReadLengthString());
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScope;
				return true;
			case BsonReader.BsonReaderState.CodeWScopeScope:
			{
				if (base.CurrentState == JsonReader.State.PostValue)
				{
					base.SetToken(JsonToken.PropertyName, "$scope");
					return true;
				}
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScopeObject;
				BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return true;
			}
			case BsonReader.BsonReaderState.CodeWScopeScopeObject:
			{
				bool result;
				if ((result = this.ReadNormal()) && this.TokenType == JsonToken.EndObject)
				{
					this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScopeEnd;
				}
				return result;
			}
			case BsonReader.BsonReaderState.CodeWScopeScopeEnd:
				base.SetToken(JsonToken.EndObject);
				this._bsonReaderState = BsonReader.BsonReaderState.Normal;
				return true;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060000B2 RID: 178
		// RVA: 0x000062BE File Offset: 0x000044BE
		private double ReadDouble()
		{
			this.MovePosition(8);
			return this._reader.ReadDouble();
		}

		// Token: 0x0600009B RID: 155
		// RVA: 0x00029784 File Offset: 0x00027984
		private string ReadElement()
		{
			this._currentElementType = this.ReadType();
			return this.ReadString();
		}

		// Token: 0x060000B3 RID: 179
		// RVA: 0x000062D2 File Offset: 0x000044D2
		private int ReadInt32()
		{
			this.MovePosition(4);
			return this._reader.ReadInt32();
		}

		// Token: 0x060000B4 RID: 180
		// RVA: 0x000062E6 File Offset: 0x000044E6
		private long ReadInt64()
		{
			this.MovePosition(8);
			return this._reader.ReadInt64();
		}

		// Token: 0x060000A2 RID: 162
		// RVA: 0x000297A8 File Offset: 0x000279A8
		internal override bool ReadInternal()
		{
			bool result;
			try
			{
				bool flag;
				switch (this._bsonReaderState)
				{
				case BsonReader.BsonReaderState.Normal:
					flag = this.ReadNormal();
					break;
				case BsonReader.BsonReaderState.ReferenceStart:
				case BsonReader.BsonReaderState.ReferenceRef:
				case BsonReader.BsonReaderState.ReferenceId:
					flag = this.ReadReference();
					break;
				case BsonReader.BsonReaderState.CodeWScopeStart:
				case BsonReader.BsonReaderState.CodeWScopeCode:
				case BsonReader.BsonReaderState.CodeWScopeScope:
				case BsonReader.BsonReaderState.CodeWScopeScopeObject:
				case BsonReader.BsonReaderState.CodeWScopeScopeEnd:
					flag = this.ReadCodeWScope();
					break;
				default:
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected state: {0}", CultureInfo.InvariantCulture, this._bsonReaderState));
				}
				if (!flag)
				{
					base.SetToken(JsonToken.None);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (EndOfStreamException)
			{
				base.SetToken(JsonToken.None);
				result = false;
			}
			return result;
		}

		// Token: 0x060000AD RID: 173
		// RVA: 0x00029F84 File Offset: 0x00028184
		private string ReadLengthString()
		{
			int num = this.ReadInt32();
			this.MovePosition(num);
			string string = this.GetString(num - 1);
			this._reader.ReadByte();
			return string;
		}

		// Token: 0x060000A6 RID: 166
		// RVA: 0x00029A24 File Offset: 0x00027C24
		private bool ReadNormal()
		{
			switch (base.CurrentState)
			{
			case JsonReader.State.Start:
			{
				JsonToken token = (!this._readRootValueAsArray) ? JsonToken.StartObject : JsonToken.StartArray;
				BsonType type = (!this._readRootValueAsArray) ? BsonType.Object : BsonType.Array;
				base.SetToken(token);
				BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(type);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return true;
			}
			case JsonReader.State.Complete:
			case JsonReader.State.Closed:
				return false;
			case JsonReader.State.Property:
				this.ReadType(this._currentElementType);
				return true;
			case JsonReader.State.ObjectStart:
			case JsonReader.State.ArrayStart:
			case JsonReader.State.PostValue:
			{
				BsonReader.ContainerContext currentContext = this._currentContext;
				if (currentContext == null)
				{
					return false;
				}
				int num = currentContext.Length - 1;
				if (currentContext.Position < num)
				{
					if (currentContext.Type == BsonType.Array)
					{
						this.ReadElement();
						this.ReadType(this._currentElementType);
						return true;
					}
					base.SetToken(JsonToken.PropertyName, this.ReadElement());
					return true;
				}
				else
				{
					if (currentContext.Position != num)
					{
						throw JsonReaderException.Create(this, "Read past end of current container context.");
					}
					if (this.ReadByte() != 0)
					{
						throw JsonReaderException.Create(this, "Unexpected end of object byte value.");
					}
					this.PopContext();
					if (this._currentContext != null)
					{
						this.MovePosition(currentContext.Length);
					}
					JsonToken token2 = (currentContext.Type == BsonType.Object) ? JsonToken.EndObject : JsonToken.EndArray;
					base.SetToken(token2);
					return true;
				}
				break;
			}
			case JsonReader.State.ConstructorStart:
			case JsonReader.State.Constructor:
			case JsonReader.State.Error:
			case JsonReader.State.Finished:
				return false;
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x060000A5 RID: 165
		// RVA: 0x00029928 File Offset: 0x00027B28
		private bool ReadReference()
		{
			JsonReader.State currentState = base.CurrentState;
			switch (currentState)
			{
			case JsonReader.State.Property:
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(JsonToken.String, this.ReadLengthString());
					return true;
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(JsonToken.Bytes, this.ReadBytes(12));
					return true;
				}
				throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState);
			case JsonReader.State.ObjectStart:
				base.SetToken(JsonToken.PropertyName, "$ref");
				this._bsonReaderState = BsonReader.BsonReaderState.ReferenceRef;
				return true;
			default:
				if (currentState != JsonReader.State.PostValue)
				{
					throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + base.CurrentState);
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(JsonToken.PropertyName, "$id");
					this._bsonReaderState = BsonReader.BsonReaderState.ReferenceId;
					return true;
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(JsonToken.EndObject);
					this._bsonReaderState = BsonReader.BsonReaderState.Normal;
					return true;
				}
				throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState);
			}
		}

		// Token: 0x060000AC RID: 172
		// RVA: 0x00029E60 File Offset: 0x00028060
		private string ReadString()
		{
			this.EnsureBuffers();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num4;
			while (true)
			{
				int num3 = num2;
				byte b;
				while (num3 < 128 && (b = this._reader.ReadByte()) > 0)
				{
					this._byteBuffer[num3++] = b;
				}
				num4 = num3 - num2;
				num += num4;
				if (num3 < 128 && stringBuilder == null)
				{
					break;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				int chars = Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(256);
				}
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num4 - 1)
				{
					num2 = num4 - lastFullCharStop - 1;
					Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					if (num3 < 128)
					{
						goto IL_105;
					}
					num2 = 0;
				}
			}
			int chars2 = Encoding.UTF8.GetChars(this._byteBuffer, 0, num4, this._charBuffer, 0);
			this.MovePosition(num + 1);
			return new string(this._charBuffer, 0, chars2);
			IL_105:
			this.MovePosition(num + 1);
			return stringBuilder.ToString();
		}

		// Token: 0x060000B5 RID: 181
		// RVA: 0x000062FA File Offset: 0x000044FA
		private BsonType ReadType()
		{
			this.MovePosition(1);
			return (BsonType)this._reader.ReadSByte();
		}

		// Token: 0x060000AA RID: 170
		// RVA: 0x00029BD0 File Offset: 0x00027DD0
		private void ReadType(BsonType type)
		{
			switch (type)
			{
			case BsonType.Number:
			{
				double num = this.ReadDouble();
				if (this._floatParseHandling == FloatParseHandling.Decimal)
				{
					base.SetToken(JsonToken.Float, Convert.ToDecimal(num, CultureInfo.InvariantCulture));
					return;
				}
				base.SetToken(JsonToken.Float, num);
				return;
			}
			case BsonType.String:
			case BsonType.Symbol:
				base.SetToken(JsonToken.String, this.ReadLengthString());
				return;
			case BsonType.Object:
			{
				base.SetToken(JsonToken.StartObject);
				BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return;
			}
			case BsonType.Array:
			{
				base.SetToken(JsonToken.StartArray);
				BsonReader.ContainerContext containerContext2 = new BsonReader.ContainerContext(BsonType.Array);
				this.PushContext(containerContext2);
				containerContext2.Length = this.ReadInt32();
				return;
			}
			case BsonType.Binary:
			{
				BsonBinaryType bsonBinaryType;
				byte[] array = this.ReadBinary(out bsonBinaryType);
				object value = (bsonBinaryType != BsonBinaryType.Uuid) ? array : new Guid(array);
				base.SetToken(JsonToken.Bytes, value);
				return;
			}
			case BsonType.Undefined:
				base.SetToken(JsonToken.Undefined);
				return;
			case BsonType.Oid:
			{
				byte[] value2 = this.ReadBytes(12);
				base.SetToken(JsonToken.Bytes, value2);
				return;
			}
			case BsonType.Boolean:
			{
				bool flag = Convert.ToBoolean(this.ReadByte());
				base.SetToken(JsonToken.Boolean, flag);
				return;
			}
			case BsonType.Date:
			{
				long javaScriptTicks = this.ReadInt64();
				DateTime dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
				DateTime dateTime2;
				switch (this.DateTimeKindHandling)
				{
				case DateTimeKind.Unspecified:
					dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
					goto IL_19D;
				case DateTimeKind.Local:
					dateTime2 = dateTime.ToLocalTime();
					goto IL_19D;
				}
				dateTime2 = dateTime;
				IL_19D:
				base.SetToken(JsonToken.Date, dateTime2);
				return;
			}
			case BsonType.Null:
				base.SetToken(JsonToken.Null);
				return;
			case BsonType.Regex:
			{
				string str = this.ReadString();
				string str2 = this.ReadString();
				string value3 = "/" + str + "/" + str2;
				base.SetToken(JsonToken.String, value3);
				return;
			}
			case BsonType.Reference:
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.ReferenceStart;
				return;
			case BsonType.Code:
				base.SetToken(JsonToken.String, this.ReadLengthString());
				return;
			case BsonType.CodeWScope:
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeStart;
				return;
			case BsonType.Integer:
				base.SetToken(JsonToken.Integer, (long)this.ReadInt32());
				return;
			case BsonType.TimeStamp:
			case BsonType.Long:
				base.SetToken(JsonToken.Integer, this.ReadInt64());
				return;
			default:
				throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + type);
			}
		}
	}
}
