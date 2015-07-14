using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200002A RID: 42
	public sealed class BsonWriter : JsonWriter
	{
		// Token: 0x040000C5 RID: 197
		private BsonToken _parent;

		// Token: 0x040000C6 RID: 198
		private string _propertyName;

		// Token: 0x040000C4 RID: 196
		private BsonToken _root;

		// Token: 0x040000C3 RID: 195
		private readonly BsonBinaryWriter _writer;

		// Token: 0x17000030 RID: 48
		public DateTimeKind DateTimeKindHandling
		{
			// Token: 0x0600014E RID: 334
			// RVA: 0x00006964 File Offset: 0x00004B64
			get
			{
				return this._writer.DateTimeKindHandling;
			}
			// Token: 0x0600014F RID: 335
			// RVA: 0x00006971 File Offset: 0x00004B71
			set
			{
				this._writer.DateTimeKindHandling = value;
			}
		}

		// Token: 0x06000150 RID: 336
		// RVA: 0x0000697F File Offset: 0x00004B7F
		public BsonWriter(Stream stream)
		{
			ValidationUtils.ArgumentNotNull(stream, "stream");
			this._writer = new BsonBinaryWriter(new BinaryWriter(stream));
		}

		// Token: 0x06000151 RID: 337
		// RVA: 0x000069A3 File Offset: 0x00004BA3
		public BsonWriter(BinaryWriter writer)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = new BsonBinaryWriter(writer);
		}

		// Token: 0x0600015C RID: 348
		// RVA: 0x00006A7A File Offset: 0x00004C7A
		private void AddParent(BsonToken container)
		{
			this.AddToken(container);
			this._parent = container;
		}

		// Token: 0x0600015F RID: 351
		// RVA: 0x0002B358 File Offset: 0x00029558
		internal void AddToken(BsonToken token)
		{
			if (this._parent != null)
			{
				if (this._parent is BsonObject)
				{
					((BsonObject)this._parent).Add(this._propertyName, token);
					this._propertyName = null;
					return;
				}
				((BsonArray)this._parent).Add(token);
				return;
			}
			else
			{
				if (token.Type != BsonType.Object && token.Type != BsonType.Array)
				{
					throw JsonWriterException.Create(this, StringUtils.FormatWith("Error writing {0} value. BSON must start with an Object or Array.", CultureInfo.InvariantCulture, token.Type), null);
				}
				this._parent = token;
				this._root = token;
				return;
			}
		}

		// Token: 0x0600015E RID: 350
		// RVA: 0x00006A9D File Offset: 0x00004C9D
		private void AddValue(object value, BsonType type)
		{
			this.AddToken(new BsonValue(value, type));
		}

		// Token: 0x0600015B RID: 347
		// RVA: 0x00006A57 File Offset: 0x00004C57
		public override void Close()
		{
			base.Close();
			if (base.CloseOutput && this._writer != null)
			{
				this._writer.Close();
			}
		}

		// Token: 0x06000152 RID: 338
		// RVA: 0x000069C2 File Offset: 0x00004BC2
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x0600015D RID: 349
		// RVA: 0x00006A8A File Offset: 0x00004C8A
		private void RemoveParent()
		{
			this._parent = this._parent.Parent;
		}

		// Token: 0x06000154 RID: 340
		// RVA: 0x000069F7 File Offset: 0x00004BF7
		public override void WriteComment(string text)
		{
			throw JsonWriterException.Create(this, "Cannot write JSON comment as BSON.", null);
		}

		// Token: 0x06000153 RID: 339
		// RVA: 0x000069CF File Offset: 0x00004BCF
		protected override void WriteEnd(JsonToken token)
		{
			base.WriteEnd(token);
			this.RemoveParent();
			if (base.Top == 0)
			{
				this._writer.WriteToken(this._root);
			}
		}

		// Token: 0x06000161 RID: 353
		// RVA: 0x00006AB5 File Offset: 0x00004CB5
		public override void WriteNull()
		{
			base.WriteNull();
			this.AddValue(null, BsonType.Null);
		}

		// Token: 0x06000176 RID: 374
		// RVA: 0x00006CCB File Offset: 0x00004ECB
		public void WriteObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value.Length != 12)
			{
				throw JsonWriterException.Create(this, "An object id must be 12 bytes", null);
			}
			base.UpdateScopeWithFinishedValue();
			base.AutoComplete(JsonToken.Undefined);
			this.AddValue(value, BsonType.Oid);
		}

		// Token: 0x0600015A RID: 346
		// RVA: 0x00006A47 File Offset: 0x00004C47
		public override void WritePropertyName(string name)
		{
			base.WritePropertyName(name);
			this._propertyName = name;
		}

		// Token: 0x06000156 RID: 342
		// RVA: 0x00006A13 File Offset: 0x00004C13
		public override void WriteRaw(string json)
		{
			throw JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000157 RID: 343
		// RVA: 0x00006A13 File Offset: 0x00004C13
		public override void WriteRawValue(string json)
		{
			throw JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000177 RID: 375
		// RVA: 0x00006D02 File Offset: 0x00004F02
		public void WriteRegex(string pattern, string options)
		{
			ValidationUtils.ArgumentNotNull(pattern, "pattern");
			base.UpdateScopeWithFinishedValue();
			base.AutoComplete(JsonToken.Undefined);
			this.AddToken(new BsonRegex(pattern, options));
		}

		// Token: 0x06000158 RID: 344
		// RVA: 0x00006A21 File Offset: 0x00004C21
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			this.AddParent(new BsonArray());
		}

		// Token: 0x06000155 RID: 341
		// RVA: 0x00006A05 File Offset: 0x00004C05
		public override void WriteStartConstructor(string name)
		{
			throw JsonWriterException.Create(this, "Cannot write JSON constructor as BSON.", null);
		}

		// Token: 0x06000159 RID: 345
		// RVA: 0x00006A34 File Offset: 0x00004C34
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			this.AddParent(new BsonObject());
		}

		// Token: 0x06000162 RID: 354
		// RVA: 0x00006AC6 File Offset: 0x00004CC6
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			this.AddValue(null, BsonType.Undefined);
		}

		// Token: 0x06000160 RID: 352
		// RVA: 0x00006AAC File Offset: 0x00004CAC
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000163 RID: 355
		// RVA: 0x00006AD6 File Offset: 0x00004CD6
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			if (value == null)
			{
				this.AddValue(null, BsonType.Null);
				return;
			}
			this.AddToken(new BsonString(value, true));
		}

		// Token: 0x06000164 RID: 356
		// RVA: 0x00006AF9 File Offset: 0x00004CF9
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06000165 RID: 357
		// RVA: 0x00006B10 File Offset: 0x00004D10
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			if (value > 2147483647u)
			{
				throw JsonWriterException.Create(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06000166 RID: 358
		// RVA: 0x00006B3C File Offset: 0x00004D3C
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Long);
		}

		// Token: 0x06000167 RID: 359
		// RVA: 0x00006B53 File Offset: 0x00004D53
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			if (value > 9223372036854775807uL)
			{
				throw JsonWriterException.Create(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, BsonType.Long);
		}

		// Token: 0x06000168 RID: 360
		// RVA: 0x00006B83 File Offset: 0x00004D83
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x06000169 RID: 361
		// RVA: 0x00006B99 File Offset: 0x00004D99
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x0600016A RID: 362
		// RVA: 0x00006BAF File Offset: 0x00004DAF
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Boolean);
		}

		// Token: 0x0600016B RID: 363
		// RVA: 0x00006BC5 File Offset: 0x00004DC5
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600016C RID: 364
		// RVA: 0x00006BDC File Offset: 0x00004DDC
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600016D RID: 365
		// RVA: 0x0002B3F0 File Offset: 0x000295F0
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			string value2 = value.ToString(CultureInfo.InvariantCulture);
			this.AddToken(new BsonString(value2, true));
		}

		// Token: 0x0600016E RID: 366
		// RVA: 0x00006BF3 File Offset: 0x00004DF3
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600016F RID: 367
		// RVA: 0x00006C0A File Offset: 0x00004E0A
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06000170 RID: 368
		// RVA: 0x00006C21 File Offset: 0x00004E21
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x06000171 RID: 369
		// RVA: 0x00006C37 File Offset: 0x00004E37
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			this.AddValue(value, BsonType.Date);
		}

		// Token: 0x06000172 RID: 370
		// RVA: 0x00006C5C File Offset: 0x00004E5C
		public override void WriteValue(byte[] value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonBinary(value, BsonBinaryType.Binary));
		}

		// Token: 0x06000173 RID: 371
		// RVA: 0x00006C72 File Offset: 0x00004E72
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonBinary(value.ToByteArray(), BsonBinaryType.Uuid));
		}

		// Token: 0x06000174 RID: 372
		// RVA: 0x00006C8E File Offset: 0x00004E8E
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonString(value.ToString(), true));
		}

		// Token: 0x06000175 RID: 373
		// RVA: 0x00006CB0 File Offset: 0x00004EB0
		public override void WriteValue(Uri value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonString(value.ToString(), true));
		}
	}
}
