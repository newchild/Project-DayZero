using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000067 RID: 103
	internal sealed class TraceJsonWriter : JsonWriter
	{
		// Token: 0x040001A2 RID: 418
		private readonly JsonWriter _innerWriter;

		// Token: 0x040001A4 RID: 420
		private readonly StringWriter _sw;

		// Token: 0x040001A3 RID: 419
		private readonly JsonTextWriter _textWriter;

		// Token: 0x060002DC RID: 732
		// RVA: 0x0002F550 File Offset: 0x0002D750
		public TraceJsonWriter(JsonWriter innerWriter)
		{
			this._innerWriter = innerWriter;
			this._sw = new StringWriter(CultureInfo.InvariantCulture);
			this._textWriter = new JsonTextWriter(this._sw);
			this._textWriter.Formatting = Formatting.Indented;
			this._textWriter.Culture = innerWriter.Culture;
			this._textWriter.DateFormatHandling = innerWriter.DateFormatHandling;
			this._textWriter.DateFormatString = innerWriter.DateFormatString;
			this._textWriter.DateTimeZoneHandling = innerWriter.DateTimeZoneHandling;
			this._textWriter.FloatFormatHandling = innerWriter.FloatFormatHandling;
		}

		// Token: 0x06000301 RID: 769
		// RVA: 0x00007EE7 File Offset: 0x000060E7
		public override void Close()
		{
			this._textWriter.Close();
			this._innerWriter.Close();
			base.Close();
		}

		// Token: 0x06000302 RID: 770
		// RVA: 0x00007F05 File Offset: 0x00006105
		public override void Flush()
		{
			this._textWriter.Flush();
			this._innerWriter.Flush();
		}

		// Token: 0x060002DD RID: 733
		// RVA: 0x00007A6A File Offset: 0x00005C6A
		public string GetJson()
		{
			return this._sw.ToString();
		}

		// Token: 0x060002F6 RID: 758
		// RVA: 0x00007D89 File Offset: 0x00005F89
		public override void WriteComment(string text)
		{
			this._textWriter.WriteComment(text);
			this._innerWriter.WriteComment(text);
			base.WriteComment(text);
		}

		// Token: 0x060002F8 RID: 760
		// RVA: 0x00007DC8 File Offset: 0x00005FC8
		public override void WriteEndArray()
		{
			this._textWriter.WriteEndArray();
			this._innerWriter.WriteEndArray();
			base.WriteEndArray();
		}

		// Token: 0x060002FA RID: 762
		// RVA: 0x00007E07 File Offset: 0x00006007
		public override void WriteEndConstructor()
		{
			this._textWriter.WriteEndConstructor();
			this._innerWriter.WriteEndConstructor();
			base.WriteEndConstructor();
		}

		// Token: 0x060002FE RID: 766
		// RVA: 0x00007E87 File Offset: 0x00006087
		public override void WriteEndObject()
		{
			this._textWriter.WriteEndObject();
			this._innerWriter.WriteEndObject();
			base.WriteEndObject();
		}

		// Token: 0x060002E7 RID: 743
		// RVA: 0x00007B9D File Offset: 0x00005D9D
		public override void WriteNull()
		{
			this._textWriter.WriteNull();
			this._innerWriter.WriteNull();
			base.WriteUndefined();
		}

		// Token: 0x060002FB RID: 763
		// RVA: 0x00007E25 File Offset: 0x00006025
		public override void WritePropertyName(string name)
		{
			this._textWriter.WritePropertyName(name);
			this._innerWriter.WritePropertyName(name);
			base.WritePropertyName(name);
		}

		// Token: 0x060002FC RID: 764
		// RVA: 0x00007E46 File Offset: 0x00006046
		public override void WritePropertyName(string name, bool escape)
		{
			this._textWriter.WritePropertyName(name, escape);
			this._innerWriter.WritePropertyName(name, escape);
			base.WritePropertyName(name);
		}

		// Token: 0x060002FF RID: 767
		// RVA: 0x00007EA5 File Offset: 0x000060A5
		public override void WriteRaw(string json)
		{
			this._textWriter.WriteRaw(json);
			this._innerWriter.WriteRaw(json);
			base.WriteRaw(json);
		}

		// Token: 0x06000300 RID: 768
		// RVA: 0x00007EC6 File Offset: 0x000060C6
		public override void WriteRawValue(string json)
		{
			this._textWriter.WriteRawValue(json);
			this._innerWriter.WriteRawValue(json);
			base.WriteRawValue(json);
		}

		// Token: 0x060002F7 RID: 759
		// RVA: 0x00007DAA File Offset: 0x00005FAA
		public override void WriteStartArray()
		{
			this._textWriter.WriteStartArray();
			this._innerWriter.WriteStartArray();
			base.WriteStartArray();
		}

		// Token: 0x060002F9 RID: 761
		// RVA: 0x00007DE6 File Offset: 0x00005FE6
		public override void WriteStartConstructor(string name)
		{
			this._textWriter.WriteStartConstructor(name);
			this._innerWriter.WriteStartConstructor(name);
			base.WriteStartConstructor(name);
		}

		// Token: 0x060002FD RID: 765
		// RVA: 0x00007E69 File Offset: 0x00006069
		public override void WriteStartObject()
		{
			this._textWriter.WriteStartObject();
			this._innerWriter.WriteStartObject();
			base.WriteStartObject();
		}

		// Token: 0x060002E6 RID: 742
		// RVA: 0x00007B7F File Offset: 0x00005D7F
		public override void WriteUndefined()
		{
			this._textWriter.WriteUndefined();
			this._innerWriter.WriteUndefined();
			base.WriteUndefined();
		}

		// Token: 0x060002DE RID: 734
		// RVA: 0x00007A77 File Offset: 0x00005C77
		public override void WriteValue(decimal value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002DF RID: 735
		// RVA: 0x00007A98 File Offset: 0x00005C98
		public override void WriteValue(bool value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E0 RID: 736
		// RVA: 0x00007AB9 File Offset: 0x00005CB9
		public override void WriteValue(byte value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E1 RID: 737
		// RVA: 0x00007ADA File Offset: 0x00005CDA
		public override void WriteValue(byte? value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E2 RID: 738
		// RVA: 0x00007AFB File Offset: 0x00005CFB
		public override void WriteValue(char value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E3 RID: 739
		// RVA: 0x00007B1C File Offset: 0x00005D1C
		public override void WriteValue(byte[] value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E4 RID: 740
		// RVA: 0x00007B3D File Offset: 0x00005D3D
		public override void WriteValue(DateTime value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E5 RID: 741
		// RVA: 0x00007B5E File Offset: 0x00005D5E
		public override void WriteValue(double value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E8 RID: 744
		// RVA: 0x00007BBB File Offset: 0x00005DBB
		public override void WriteValue(float value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002E9 RID: 745
		// RVA: 0x00007BDC File Offset: 0x00005DDC
		public override void WriteValue(Guid value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002EA RID: 746
		// RVA: 0x00007BFD File Offset: 0x00005DFD
		public override void WriteValue(int value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002EB RID: 747
		// RVA: 0x00007C1E File Offset: 0x00005E1E
		public override void WriteValue(long value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002EC RID: 748
		// RVA: 0x00007C3F File Offset: 0x00005E3F
		public override void WriteValue(object value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002ED RID: 749
		// RVA: 0x00007C60 File Offset: 0x00005E60
		public override void WriteValue(sbyte value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002EE RID: 750
		// RVA: 0x00007C81 File Offset: 0x00005E81
		public override void WriteValue(short value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002EF RID: 751
		// RVA: 0x00007CA2 File Offset: 0x00005EA2
		public override void WriteValue(string value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F0 RID: 752
		// RVA: 0x00007CC3 File Offset: 0x00005EC3
		public override void WriteValue(TimeSpan value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F1 RID: 753
		// RVA: 0x00007CE4 File Offset: 0x00005EE4
		public override void WriteValue(uint value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F2 RID: 754
		// RVA: 0x00007D05 File Offset: 0x00005F05
		public override void WriteValue(ulong value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F3 RID: 755
		// RVA: 0x00007D26 File Offset: 0x00005F26
		public override void WriteValue(Uri value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F4 RID: 756
		// RVA: 0x00007D47 File Offset: 0x00005F47
		public override void WriteValue(ushort value)
		{
			this._textWriter.WriteValue(value);
			this._innerWriter.WriteValue(value);
			base.WriteValue(value);
		}

		// Token: 0x060002F5 RID: 757
		// RVA: 0x00007D68 File Offset: 0x00005F68
		public override void WriteWhitespace(string ws)
		{
			this._textWriter.WriteWhitespace(ws);
			this._innerWriter.WriteWhitespace(ws);
			base.WriteWhitespace(ws);
		}
	}
}
