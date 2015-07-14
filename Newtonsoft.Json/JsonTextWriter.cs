using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json
{
	// Token: 0x020000D1 RID: 209
	public sealed class JsonTextWriter : JsonWriter
	{
		// Token: 0x04000369 RID: 873
		private Base64Encoder _base64Encoder;

		// Token: 0x0400036E RID: 878
		private bool[] _charEscapeFlags;

		// Token: 0x0400036B RID: 875
		private int _indentation;

		// Token: 0x0400036A RID: 874
		private char _indentChar;

		// Token: 0x04000370 RID: 880
		private char[] _indentChars;

		// Token: 0x0400036C RID: 876
		private char _quoteChar;

		// Token: 0x0400036D RID: 877
		private bool _quoteName;

		// Token: 0x0400036F RID: 879
		private char[] _writeBuffer;

		// Token: 0x04000368 RID: 872
		private readonly TextWriter _writer;

		// Token: 0x17000139 RID: 313
		private Base64Encoder Base64Encoder
		{
			// Token: 0x06000748 RID: 1864
			// RVA: 0x0000A28F File Offset: 0x0000848F
			get
			{
				if (this._base64Encoder == null)
				{
					this._base64Encoder = new Base64Encoder(this._writer);
				}
				return this._base64Encoder;
			}
		}

		// Token: 0x1700013A RID: 314
		public int Indentation
		{
			// Token: 0x06000749 RID: 1865
			// RVA: 0x0000A2B0 File Offset: 0x000084B0
			get
			{
				return this._indentation;
			}
			// Token: 0x0600074A RID: 1866
			// RVA: 0x0000A2B8 File Offset: 0x000084B8
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Indentation value must be greater than 0.");
				}
				this._indentation = value;
			}
		}

		// Token: 0x1700013C RID: 316
		public char IndentChar
		{
			// Token: 0x0600074D RID: 1869
			// RVA: 0x0000A2FC File Offset: 0x000084FC
			get
			{
				return this._indentChar;
			}
			// Token: 0x0600074E RID: 1870
			// RVA: 0x0000A304 File Offset: 0x00008504
			set
			{
				if (value != this._indentChar)
				{
					this._indentChar = value;
					this._indentChars = null;
				}
			}
		}

		// Token: 0x1700013B RID: 315
		public char QuoteChar
		{
			// Token: 0x0600074B RID: 1867
			// RVA: 0x0000A2D0 File Offset: 0x000084D0
			get
			{
				return this._quoteChar;
			}
			// Token: 0x0600074C RID: 1868
			// RVA: 0x0000A2D8 File Offset: 0x000084D8
			set
			{
				if (value != '"' && value != '\'')
				{
					throw new ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
				}
				this._quoteChar = value;
				this.UpdateCharEscapeFlags();
			}
		}

		// Token: 0x1700013D RID: 317
		public bool QuoteName
		{
			// Token: 0x0600074F RID: 1871
			// RVA: 0x0000A31D File Offset: 0x0000851D
			get
			{
				return this._quoteName;
			}
			// Token: 0x06000750 RID: 1872
			// RVA: 0x0000A325 File Offset: 0x00008525
			set
			{
				this._quoteName = value;
			}
		}

		// Token: 0x06000751 RID: 1873
		// RVA: 0x0003AA3C File Offset: 0x00038C3C
		public JsonTextWriter(TextWriter textWriter)
		{
			if (textWriter == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			this._writer = textWriter;
			this._quoteChar = '"';
			this._quoteName = true;
			this._indentChar = ' ';
			this._indentation = 2;
			this.UpdateCharEscapeFlags();
		}

		// Token: 0x06000753 RID: 1875
		// RVA: 0x0000A33B File Offset: 0x0000853B
		public override void Close()
		{
			base.Close();
			if (base.CloseOutput && this._writer != null)
			{
				this._writer.Close();
			}
		}

		// Token: 0x0600077C RID: 1916
		// RVA: 0x0000A671 File Offset: 0x00008871
		private void EnsureWriteBuffer()
		{
			if (this._writeBuffer == null)
			{
				this._writeBuffer = new char[35];
			}
		}

		// Token: 0x06000752 RID: 1874
		// RVA: 0x0000A32E File Offset: 0x0000852E
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x0600075A RID: 1882
		// RVA: 0x0000A3E2 File Offset: 0x000085E2
		internal override void OnStringEscapeHandlingChanged()
		{
			this.UpdateCharEscapeFlags();
		}

		// Token: 0x0600075B RID: 1883
		// RVA: 0x0000A3EA File Offset: 0x000085EA
		private void UpdateCharEscapeFlags()
		{
			this._charEscapeFlags = JavaScriptUtils.GetCharEscapeFlags(base.StringEscapeHandling, this._quoteChar);
		}

		// Token: 0x0600077A RID: 1914
		// RVA: 0x0000A628 File Offset: 0x00008828
		public override void WriteComment(string text)
		{
			base.InternalWriteComment();
			this._writer.Write("/*");
			this._writer.Write(text);
			this._writer.Write("*/");
		}

		// Token: 0x06000757 RID: 1879
		// RVA: 0x0003AA88 File Offset: 0x00038C88
		protected override void WriteEnd(JsonToken token)
		{
			switch (token)
			{
			case JsonToken.EndObject:
				this._writer.Write('}');
				return;
			case JsonToken.EndArray:
				this._writer.Write(']');
				return;
			case JsonToken.EndConstructor:
				this._writer.Write(')');
				return;
			default:
				throw JsonWriterException.Create(this, "Invalid JsonToken: " + token, null);
			}
		}

		// Token: 0x06000765 RID: 1893
		// RVA: 0x0000A494 File Offset: 0x00008694
		private void WriteEscapedString(string value, bool quote)
		{
			this.EnsureWriteBuffer();
			JavaScriptUtils.WriteEscapedJavaScriptString(this._writer, value, this._quoteChar, quote, this._charEscapeFlags, base.StringEscapeHandling, ref this._writeBuffer);
		}

		// Token: 0x0600075C RID: 1884
		// RVA: 0x0003AB64 File Offset: 0x00038D64
		protected override void WriteIndent()
		{
			this._writer.WriteLine();
			int i = base.Top * this._indentation;
			if (i > 0)
			{
				if (this._indentChars == null)
				{
					this._indentChars = new string(this._indentChar, 10).ToCharArray();
				}
				while (i > 0)
				{
					int num = Math.Min(i, 10);
					this._writer.Write(this._indentChars, 0, num);
					i -= num;
				}
			}
		}

		// Token: 0x0600075E RID: 1886
		// RVA: 0x0000A412 File Offset: 0x00008612
		protected override void WriteIndentSpace()
		{
			this._writer.Write(' ');
		}

		// Token: 0x0600077D RID: 1917
		// RVA: 0x0003ADB0 File Offset: 0x00038FB0
		private void WriteIntegerValue(long value)
		{
			if (value >= 0L && value <= 9L)
			{
				this._writer.Write((char)(48L + value));
				return;
			}
			ulong uvalue = (ulong)((value < 0L) ? (-(ulong)value) : value);
			if (value < 0L)
			{
				this._writer.Write('-');
			}
			this.WriteIntegerValue(uvalue);
		}

		// Token: 0x0600077E RID: 1918
		// RVA: 0x0003AE20 File Offset: 0x00039020
		private void WriteIntegerValue(ulong uvalue)
		{
			if (uvalue <= 9uL)
			{
				this._writer.Write((char)(48uL + uvalue));
				return;
			}
			this.EnsureWriteBuffer();
			int num = MathUtils.IntLength(uvalue);
			int num2 = 0;
			do
			{
				this._writeBuffer[num - ++num2] = (char)(48uL + uvalue % 10uL);
				uvalue /= 10uL;
			}
			while (uvalue != 0uL);
			this._writer.Write(this._writeBuffer, 0, num2);
		}

		// Token: 0x06000761 RID: 1889
		// RVA: 0x0000A42F File Offset: 0x0000862F
		public override void WriteNull()
		{
			base.InternalWriteValue(JsonToken.Null);
			this.WriteValueInternal(JsonConvert.Null, JsonToken.Null);
		}

		// Token: 0x06000758 RID: 1880
		// RVA: 0x0000A3BF File Offset: 0x000085BF
		public override void WritePropertyName(string name)
		{
			base.InternalWritePropertyName(name);
			this.WriteEscapedString(name, this._quoteName);
			this._writer.Write(':');
		}

		// Token: 0x06000759 RID: 1881
		// RVA: 0x0003AAF0 File Offset: 0x00038CF0
		public override void WritePropertyName(string name, bool escape)
		{
			base.InternalWritePropertyName(name);
			if (escape)
			{
				this.WriteEscapedString(name, this._quoteName);
			}
			else
			{
				if (this._quoteName)
				{
					this._writer.Write(this._quoteChar);
				}
				this._writer.Write(name);
				if (this._quoteName)
				{
					this._writer.Write(this._quoteChar);
				}
			}
			this._writer.Write(':');
		}

		// Token: 0x06000763 RID: 1891
		// RVA: 0x0000A45D File Offset: 0x0000865D
		public override void WriteRaw(string json)
		{
			base.InternalWriteRaw();
			this._writer.Write(json);
		}

		// Token: 0x06000755 RID: 1877
		// RVA: 0x0000A375 File Offset: 0x00008575
		public override void WriteStartArray()
		{
			base.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
			this._writer.Write('[');
		}

		// Token: 0x06000756 RID: 1878
		// RVA: 0x0000A38C File Offset: 0x0000858C
		public override void WriteStartConstructor(string name)
		{
			base.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
			this._writer.Write("new ");
			this._writer.Write(name);
			this._writer.Write('(');
		}

		// Token: 0x06000754 RID: 1876
		// RVA: 0x0000A35E File Offset: 0x0000855E
		public override void WriteStartObject()
		{
			base.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
			this._writer.Write('{');
		}

		// Token: 0x06000762 RID: 1890
		// RVA: 0x0000A446 File Offset: 0x00008646
		public override void WriteUndefined()
		{
			base.InternalWriteValue(JsonToken.Undefined);
			this.WriteValueInternal(JsonConvert.Undefined, JsonToken.Undefined);
		}

		// Token: 0x06000760 RID: 1888
		// RVA: 0x00006AAC File Offset: 0x00004CAC
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000764 RID: 1892
		// RVA: 0x0000A471 File Offset: 0x00008671
		public override void WriteValue(string value)
		{
			base.InternalWriteValue(JsonToken.String);
			if (value == null)
			{
				this.WriteValueInternal(JsonConvert.Null, JsonToken.Null);
				return;
			}
			this.WriteEscapedString(value, true);
		}

		// Token: 0x06000766 RID: 1894
		// RVA: 0x0000A4C1 File Offset: 0x000086C1
		public override void WriteValue(int value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)value);
		}

		// Token: 0x06000767 RID: 1895
		// RVA: 0x0000A4D2 File Offset: 0x000086D2
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)((ulong)value));
		}

		// Token: 0x06000768 RID: 1896
		// RVA: 0x0000A4E3 File Offset: 0x000086E3
		public override void WriteValue(long value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x06000769 RID: 1897
		// RVA: 0x0000A4F3 File Offset: 0x000086F3
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x0600076A RID: 1898
		// RVA: 0x0000A503 File Offset: 0x00008703
		public override void WriteValue(float value)
		{
			base.InternalWriteValue(JsonToken.Float);
			this.WriteValueInternal(JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
		}

		// Token: 0x0600076B RID: 1899
		// RVA: 0x0000A526 File Offset: 0x00008726
		public override void WriteValue(float? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.Float);
			this.WriteValueInternal(JsonConvert.ToString(value.Value, base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
		}

		// Token: 0x0600076C RID: 1900
		// RVA: 0x0000A55F File Offset: 0x0000875F
		public override void WriteValue(double value)
		{
			base.InternalWriteValue(JsonToken.Float);
			this.WriteValueInternal(JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
		}

		// Token: 0x0600076D RID: 1901
		// RVA: 0x0000A582 File Offset: 0x00008782
		public override void WriteValue(double? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.Float);
			this.WriteValueInternal(JsonConvert.ToString(value.Value, base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
		}

		// Token: 0x0600076E RID: 1902
		// RVA: 0x0000A5BB File Offset: 0x000087BB
		public override void WriteValue(bool value)
		{
			base.InternalWriteValue(JsonToken.Boolean);
			this.WriteValueInternal(JsonConvert.ToString(value), JsonToken.Boolean);
		}

		// Token: 0x0600076F RID: 1903
		// RVA: 0x0000A4C1 File Offset: 0x000086C1
		public override void WriteValue(short value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)value);
		}

		// Token: 0x06000770 RID: 1904
		// RVA: 0x0000A4D2 File Offset: 0x000086D2
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)((ulong)value));
		}

		// Token: 0x06000771 RID: 1905
		// RVA: 0x0000A5D3 File Offset: 0x000087D3
		public override void WriteValue(char value)
		{
			base.InternalWriteValue(JsonToken.String);
			this.WriteValueInternal(JsonConvert.ToString(value), JsonToken.String);
		}

		// Token: 0x06000772 RID: 1906
		// RVA: 0x0000A4D2 File Offset: 0x000086D2
		public override void WriteValue(byte value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)((ulong)value));
		}

		// Token: 0x06000773 RID: 1907
		// RVA: 0x0000A4C1 File Offset: 0x000086C1
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.InternalWriteValue(JsonToken.Integer);
			this.WriteIntegerValue((long)value);
		}

		// Token: 0x06000774 RID: 1908
		// RVA: 0x0000A5EB File Offset: 0x000087EB
		public override void WriteValue(decimal value)
		{
			base.InternalWriteValue(JsonToken.Float);
			this.WriteValueInternal(JsonConvert.ToString(value), JsonToken.Float);
		}

		// Token: 0x06000775 RID: 1909
		// RVA: 0x0003ABD4 File Offset: 0x00038DD4
		public override void WriteValue(DateTime value)
		{
			base.InternalWriteValue(JsonToken.Date);
			value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			if (string.IsNullOrEmpty(base.DateFormatString))
			{
				this.EnsureWriteBuffer();
				this._writeBuffer[0] = this._quoteChar;
				int count = DateTimeUtils.WriteDateTimeString(this._writeBuffer, 1, value, null, value.Kind, base.DateFormatHandling);
				this._writeBuffer[count++] = this._quoteChar;
				this._writer.Write(this._writeBuffer, 0, count);
				return;
			}
			this._writer.Write(this._quoteChar);
			this._writer.Write(value.ToString(base.DateFormatString, base.Culture));
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x06000776 RID: 1910
		// RVA: 0x0003ACA8 File Offset: 0x00038EA8
		public override void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.Bytes);
			this._writer.Write(this._quoteChar);
			this.Base64Encoder.Encode(value, 0, value.Length);
			this.Base64Encoder.Flush();
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x06000777 RID: 1911
		// RVA: 0x0003AD04 File Offset: 0x00038F04
		public override void WriteValue(Guid value)
		{
			base.InternalWriteValue(JsonToken.String);
			string value2 = value.ToString("D", CultureInfo.InvariantCulture);
			this._writer.Write(this._quoteChar);
			this._writer.Write(value2);
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x06000778 RID: 1912
		// RVA: 0x0003AD5C File Offset: 0x00038F5C
		public override void WriteValue(TimeSpan value)
		{
			base.InternalWriteValue(JsonToken.String);
			string value2 = value.ToString();
			this._writer.Write(this._quoteChar);
			this._writer.Write(value2);
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x06000779 RID: 1913
		// RVA: 0x0000A601 File Offset: 0x00008801
		public override void WriteValue(Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(JsonToken.String);
			this.WriteEscapedString(value.OriginalString, true);
		}

		// Token: 0x0600075D RID: 1885
		// RVA: 0x0000A403 File Offset: 0x00008603
		protected override void WriteValueDelimiter()
		{
			this._writer.Write(',');
		}

		// Token: 0x0600075F RID: 1887
		// RVA: 0x0000A421 File Offset: 0x00008621
		private void WriteValueInternal(string value, JsonToken token)
		{
			this._writer.Write(value);
		}

		// Token: 0x0600077B RID: 1915
		// RVA: 0x0000A65C File Offset: 0x0000885C
		public override void WriteWhitespace(string ws)
		{
			base.InternalWriteWhitespace(ws);
			this._writer.Write(ws);
		}
	}
}
