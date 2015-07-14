using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000E4 RID: 228
	public sealed class JTokenWriter : JsonWriter
	{
		// Token: 0x040003D3 RID: 979
		private JToken _current;

		// Token: 0x040003D1 RID: 977
		private JContainer _parent;

		// Token: 0x040003D0 RID: 976
		private JContainer _token;

		// Token: 0x040003D2 RID: 978
		private JValue _value;

		// Token: 0x17000190 RID: 400
		public JToken CurrentToken
		{
			// Token: 0x0600094E RID: 2382
			// RVA: 0x0000B926 File Offset: 0x00009B26
			get
			{
				return this._current;
			}
		}

		// Token: 0x17000191 RID: 401
		public JToken Token
		{
			// Token: 0x0600094F RID: 2383
			// RVA: 0x0000B92E File Offset: 0x00009B2E
			get
			{
				if (this._token != null)
				{
					return this._token;
				}
				return this._value;
			}
		}

		// Token: 0x06000951 RID: 2385
		// RVA: 0x0000B966 File Offset: 0x00009B66
		public JTokenWriter()
		{
		}

		// Token: 0x06000950 RID: 2384
		// RVA: 0x0000B945 File Offset: 0x00009B45
		public JTokenWriter(JContainer container)
		{
			ValidationUtils.ArgumentNotNull(container, "container");
			this._token = container;
			this._parent = container;
		}

		// Token: 0x06000955 RID: 2389
		// RVA: 0x0000B989 File Offset: 0x00009B89
		private void AddParent(JContainer container)
		{
			if (this._parent == null)
			{
				this._token = container;
			}
			else
			{
				this._parent.AddAndSkipParentCheck(container);
			}
			this._parent = container;
			this._current = container;
		}

		// Token: 0x0600095B RID: 2395
		// RVA: 0x0000B9FB File Offset: 0x00009BFB
		private void AddValue(object value, JsonToken token)
		{
			this.AddValue(new JValue(value), token);
		}

		// Token: 0x0600095C RID: 2396
		// RVA: 0x0003E510 File Offset: 0x0003C710
		internal void AddValue(JValue value, JsonToken token)
		{
			if (this._parent != null)
			{
				this._parent.Add(value);
				this._current = this._parent.Last;
				if (this._parent.Type == JTokenType.Property)
				{
					this._parent = this._parent.Parent;
					return;
				}
			}
			else
			{
				this._value = (value ?? JValue.CreateNull());
				this._current = this._value;
			}
		}

		// Token: 0x06000953 RID: 2387
		// RVA: 0x0000B96E File Offset: 0x00009B6E
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x06000952 RID: 2386
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void Flush()
		{
		}

		// Token: 0x06000956 RID: 2390
		// RVA: 0x0003E4BC File Offset: 0x0003C6BC
		private void RemoveParent()
		{
			this._current = this._parent;
			this._parent = this._parent.Parent;
			if (this._parent != null && this._parent.Type == JTokenType.Property)
			{
				this._parent = this._parent.Parent;
			}
		}

		// Token: 0x06000961 RID: 2401
		// RVA: 0x0000BA42 File Offset: 0x00009C42
		public override void WriteComment(string text)
		{
			base.WriteComment(text);
			this.AddValue(JValue.CreateComment(text), JsonToken.Comment);
		}

		// Token: 0x06000959 RID: 2393
		// RVA: 0x0000B9DE File Offset: 0x00009BDE
		protected override void WriteEnd(JsonToken token)
		{
			this.RemoveParent();
		}

		// Token: 0x0600095E RID: 2398
		// RVA: 0x0000BA0A File Offset: 0x00009C0A
		public override void WriteNull()
		{
			base.WriteNull();
			this.AddValue(null, JsonToken.Null);
		}

		// Token: 0x0600095A RID: 2394
		// RVA: 0x0000B9E6 File Offset: 0x00009BE6
		public override void WritePropertyName(string name)
		{
			this.AddParent(new JProperty(name));
			base.WritePropertyName(name);
		}

		// Token: 0x06000960 RID: 2400
		// RVA: 0x0000BA2C File Offset: 0x00009C2C
		public override void WriteRaw(string json)
		{
			base.WriteRaw(json);
			this.AddValue(new JRaw(json), JsonToken.Raw);
		}

		// Token: 0x06000957 RID: 2391
		// RVA: 0x0000B9B6 File Offset: 0x00009BB6
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			this.AddParent(new JArray());
		}

		// Token: 0x06000958 RID: 2392
		// RVA: 0x0000B9C9 File Offset: 0x00009BC9
		public override void WriteStartConstructor(string name)
		{
			base.WriteStartConstructor(name);
			this.AddParent(new JConstructor(name));
		}

		// Token: 0x06000954 RID: 2388
		// RVA: 0x0000B976 File Offset: 0x00009B76
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			this.AddParent(new JObject());
		}

		// Token: 0x0600095F RID: 2399
		// RVA: 0x0000BA1B File Offset: 0x00009C1B
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			this.AddValue(null, JsonToken.Undefined);
		}

		// Token: 0x0600095D RID: 2397
		// RVA: 0x00006AAC File Offset: 0x00004CAC
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000962 RID: 2402
		// RVA: 0x0000BA58 File Offset: 0x00009C58
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}

		// Token: 0x06000963 RID: 2403
		// RVA: 0x0000BA6A File Offset: 0x00009C6A
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x06000964 RID: 2404
		// RVA: 0x0000BA80 File Offset: 0x00009C80
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x06000965 RID: 2405
		// RVA: 0x0000BA96 File Offset: 0x00009C96
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x06000966 RID: 2406
		// RVA: 0x0000BAAC File Offset: 0x00009CAC
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x06000967 RID: 2407
		// RVA: 0x0000BAC2 File Offset: 0x00009CC2
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Float);
		}

		// Token: 0x06000968 RID: 2408
		// RVA: 0x0000BAD8 File Offset: 0x00009CD8
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Float);
		}

		// Token: 0x06000969 RID: 2409
		// RVA: 0x0000BAEE File Offset: 0x00009CEE
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Boolean);
		}

		// Token: 0x0600096A RID: 2410
		// RVA: 0x0000BB05 File Offset: 0x00009D05
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x0600096B RID: 2411
		// RVA: 0x0000BB1B File Offset: 0x00009D1B
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x0600096C RID: 2412
		// RVA: 0x0003E580 File Offset: 0x0003C780
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			string value2 = value.ToString(CultureInfo.InvariantCulture);
			this.AddValue(value2, JsonToken.String);
		}

		// Token: 0x0600096D RID: 2413
		// RVA: 0x0000BB31 File Offset: 0x00009D31
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x0600096E RID: 2414
		// RVA: 0x0000BB47 File Offset: 0x00009D47
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Integer);
		}

		// Token: 0x0600096F RID: 2415
		// RVA: 0x0000BB5D File Offset: 0x00009D5D
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Float);
		}

		// Token: 0x06000970 RID: 2416
		// RVA: 0x0000BB73 File Offset: 0x00009D73
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			this.AddValue(value, JsonToken.Date);
		}

		// Token: 0x06000971 RID: 2417
		// RVA: 0x0000BB98 File Offset: 0x00009D98
		public override void WriteValue(byte[] value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.Bytes);
		}

		// Token: 0x06000972 RID: 2418
		// RVA: 0x0000BBAA File Offset: 0x00009DAA
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}

		// Token: 0x06000973 RID: 2419
		// RVA: 0x0000BBC1 File Offset: 0x00009DC1
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}

		// Token: 0x06000974 RID: 2420
		// RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public override void WriteValue(Uri value)
		{
			base.WriteValue(value);
			this.AddValue(value, JsonToken.String);
		}
	}
}
