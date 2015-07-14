using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010D RID: 269
	internal sealed class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x0400046C RID: 1132
		private readonly JsonISerializableContract _contract;

		// Token: 0x0400046D RID: 1133
		private readonly JsonProperty _member;

		// Token: 0x0400046B RID: 1131
		private readonly JsonSerializerInternalReader _reader;

		// Token: 0x06000AB5 RID: 2741
		// RVA: 0x0000C612 File Offset: 0x0000A812
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
			ValidationUtils.ArgumentNotNull(reader, "serializer");
			ValidationUtils.ArgumentNotNull(contract, "contract");
			this._reader = reader;
			this._contract = contract;
			this._member = member;
		}

		// Token: 0x06000AB7 RID: 2743
		// RVA: 0x0004194C File Offset: 0x0003FB4C
		public object Convert(object value, Type type)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			JToken jToken = value as JToken;
			if (jToken == null)
			{
				throw new ArgumentException("Value is not a JToken.", "value");
			}
			return this._reader.CreateISerializableItem(jToken, type, this._contract, this._member);
		}

		// Token: 0x06000AB8 RID: 2744
		// RVA: 0x0000C645 File Offset: 0x0000A845
		public object Convert(object value, TypeCode typeCode)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value is JValue)
			{
				value = ((JValue)value).Value;
			}
			return System.Convert.ChangeType(value, typeCode, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AB6 RID: 2742
		// RVA: 0x0004190C File Offset: 0x0003FB0C
		private T GetTokenValue<T>(object value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			JValue jValue = (JValue)value;
			return (T)((object)System.Convert.ChangeType(jValue.Value, typeof(T), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AB9 RID: 2745
		// RVA: 0x0000C673 File Offset: 0x0000A873
		public bool ToBoolean(object value)
		{
			return this.GetTokenValue<bool>(value);
		}

		// Token: 0x06000ABA RID: 2746
		// RVA: 0x0000C67C File Offset: 0x0000A87C
		public byte ToByte(object value)
		{
			return this.GetTokenValue<byte>(value);
		}

		// Token: 0x06000ABB RID: 2747
		// RVA: 0x0000C685 File Offset: 0x0000A885
		public char ToChar(object value)
		{
			return this.GetTokenValue<char>(value);
		}

		// Token: 0x06000ABC RID: 2748
		// RVA: 0x0000C68E File Offset: 0x0000A88E
		public DateTime ToDateTime(object value)
		{
			return this.GetTokenValue<DateTime>(value);
		}

		// Token: 0x06000ABD RID: 2749
		// RVA: 0x0000C697 File Offset: 0x0000A897
		public decimal ToDecimal(object value)
		{
			return this.GetTokenValue<decimal>(value);
		}

		// Token: 0x06000ABE RID: 2750
		// RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public double ToDouble(object value)
		{
			return this.GetTokenValue<double>(value);
		}

		// Token: 0x06000ABF RID: 2751
		// RVA: 0x0000C6A9 File Offset: 0x0000A8A9
		public short ToInt16(object value)
		{
			return this.GetTokenValue<short>(value);
		}

		// Token: 0x06000AC0 RID: 2752
		// RVA: 0x0000C6B2 File Offset: 0x0000A8B2
		public int ToInt32(object value)
		{
			return this.GetTokenValue<int>(value);
		}

		// Token: 0x06000AC1 RID: 2753
		// RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public long ToInt64(object value)
		{
			return this.GetTokenValue<long>(value);
		}

		// Token: 0x06000AC2 RID: 2754
		// RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		public sbyte ToSByte(object value)
		{
			return this.GetTokenValue<sbyte>(value);
		}

		// Token: 0x06000AC3 RID: 2755
		// RVA: 0x0000C6CD File Offset: 0x0000A8CD
		public float ToSingle(object value)
		{
			return this.GetTokenValue<float>(value);
		}

		// Token: 0x06000AC4 RID: 2756
		// RVA: 0x0000C6D6 File Offset: 0x0000A8D6
		public string ToString(object value)
		{
			return this.GetTokenValue<string>(value);
		}

		// Token: 0x06000AC5 RID: 2757
		// RVA: 0x0000C6DF File Offset: 0x0000A8DF
		public ushort ToUInt16(object value)
		{
			return this.GetTokenValue<ushort>(value);
		}

		// Token: 0x06000AC6 RID: 2758
		// RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public uint ToUInt32(object value)
		{
			return this.GetTokenValue<uint>(value);
		}

		// Token: 0x06000AC7 RID: 2759
		// RVA: 0x0000C6F1 File Offset: 0x0000A8F1
		public ulong ToUInt64(object value)
		{
			return this.GetTokenValue<ulong>(value);
		}
	}
}
