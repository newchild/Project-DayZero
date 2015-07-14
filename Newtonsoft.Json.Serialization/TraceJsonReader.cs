using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000066 RID: 102
	internal sealed class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x0400019F RID: 415
		private readonly JsonReader _innerReader;

		// Token: 0x040001A1 RID: 417
		private readonly StringWriter _sw;

		// Token: 0x040001A0 RID: 416
		private readonly JsonTextWriter _textWriter;

		// Token: 0x1700007D RID: 125
		public override int Depth
		{
			// Token: 0x060002D1 RID: 721
			// RVA: 0x00007A01 File Offset: 0x00005C01
			get
			{
				return this._innerReader.Depth;
			}
		}

		// Token: 0x17000083 RID: 131
		int IJsonLineInfo.LineNumber
		{
			// Token: 0x060002DA RID: 730
			// RVA: 0x0002F508 File Offset: 0x0002D708
			get
			{
				IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x17000084 RID: 132
		int IJsonLineInfo.LinePosition
		{
			// Token: 0x060002DB RID: 731
			// RVA: 0x0002F52C File Offset: 0x0002D72C
			get
			{
				IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x1700007E RID: 126
		public override string Path
		{
			// Token: 0x060002D2 RID: 722
			// RVA: 0x00007A0E File Offset: 0x00005C0E
			get
			{
				return this._innerReader.Path;
			}
		}

		// Token: 0x1700007F RID: 127
		public override char QuoteChar
		{
			// Token: 0x060002D3 RID: 723
			// RVA: 0x00007A1B File Offset: 0x00005C1B
			get
			{
				return this._innerReader.QuoteChar;
			}
			// Token: 0x060002D4 RID: 724
			// RVA: 0x00007A28 File Offset: 0x00005C28
			protected internal set
			{
				this._innerReader.QuoteChar = value;
			}
		}

		// Token: 0x17000080 RID: 128
		public override JsonToken TokenType
		{
			// Token: 0x060002D5 RID: 725
			// RVA: 0x00007A36 File Offset: 0x00005C36
			get
			{
				return this._innerReader.TokenType;
			}
		}

		// Token: 0x17000081 RID: 129
		public override object Value
		{
			// Token: 0x060002D6 RID: 726
			// RVA: 0x00007A43 File Offset: 0x00005C43
			get
			{
				return this._innerReader.Value;
			}
		}

		// Token: 0x17000082 RID: 130
		public override Type ValueType
		{
			// Token: 0x060002D7 RID: 727
			// RVA: 0x00007A50 File Offset: 0x00005C50
			get
			{
				return this._innerReader.ValueType;
			}
		}

		// Token: 0x060002C9 RID: 713
		// RVA: 0x000079B8 File Offset: 0x00005BB8
		public TraceJsonReader(JsonReader innerReader)
		{
			this._innerReader = innerReader;
			this._sw = new StringWriter(CultureInfo.InvariantCulture);
			this._textWriter = new JsonTextWriter(this._sw);
			this._textWriter.Formatting = Formatting.Indented;
		}

		// Token: 0x060002D8 RID: 728
		// RVA: 0x00007A5D File Offset: 0x00005C5D
		public override void Close()
		{
			this._innerReader.Close();
		}

		// Token: 0x060002CA RID: 714
		// RVA: 0x000079F4 File Offset: 0x00005BF4
		public string GetJson()
		{
			return this._sw.ToString();
		}

		// Token: 0x060002D9 RID: 729
		// RVA: 0x0002F4E4 File Offset: 0x0002D6E4
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
			return jsonLineInfo != null && jsonLineInfo.HasLineInfo();
		}

		// Token: 0x060002CB RID: 715
		// RVA: 0x0002F3C4 File Offset: 0x0002D5C4
		public override bool Read()
		{
			bool result = this._innerReader.Read();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}

		// Token: 0x060002CE RID: 718
		// RVA: 0x0002F454 File Offset: 0x0002D654
		public override byte[] ReadAsBytes()
		{
			byte[] result = this._innerReader.ReadAsBytes();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}

		// Token: 0x060002D0 RID: 720
		// RVA: 0x0002F4B4 File Offset: 0x0002D6B4
		public override DateTime? ReadAsDateTime()
		{
			DateTime? result = this._innerReader.ReadAsDateTime();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}

		// Token: 0x060002CF RID: 719
		// RVA: 0x0002F484 File Offset: 0x0002D684
		public override decimal? ReadAsDecimal()
		{
			decimal? result = this._innerReader.ReadAsDecimal();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}

		// Token: 0x060002CC RID: 716
		// RVA: 0x0002F3F4 File Offset: 0x0002D5F4
		public override int? ReadAsInt32()
		{
			int? result = this._innerReader.ReadAsInt32();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}

		// Token: 0x060002CD RID: 717
		// RVA: 0x0002F424 File Offset: 0x0002D624
		public override string ReadAsString()
		{
			string result = this._innerReader.ReadAsString();
			this._textWriter.WriteToken(this._innerReader, false, false);
			return result;
		}
	}
}
