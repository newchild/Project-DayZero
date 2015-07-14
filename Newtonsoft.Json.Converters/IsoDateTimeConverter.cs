using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BD RID: 189
	public sealed class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x0400032E RID: 814
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x04000331 RID: 817
		private CultureInfo _culture;

		// Token: 0x04000330 RID: 816
		private string _dateTimeFormat;

		// Token: 0x0400032F RID: 815
		private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;

		// Token: 0x17000102 RID: 258
		public CultureInfo Culture
		{
			// Token: 0x0600067F RID: 1663
			// RVA: 0x00009B53 File Offset: 0x00007D53
			get
			{
				return this._culture ?? CultureInfo.CurrentCulture;
			}
			// Token: 0x06000680 RID: 1664
			// RVA: 0x00009B64 File Offset: 0x00007D64
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x17000101 RID: 257
		public string DateTimeFormat
		{
			// Token: 0x0600067D RID: 1661
			// RVA: 0x00009B34 File Offset: 0x00007D34
			get
			{
				return this._dateTimeFormat ?? string.Empty;
			}
			// Token: 0x0600067E RID: 1662
			// RVA: 0x00009B45 File Offset: 0x00007D45
			set
			{
				this._dateTimeFormat = StringUtils.NullEmptyString(value);
			}
		}

		// Token: 0x17000100 RID: 256
		public DateTimeStyles DateTimeStyles
		{
			// Token: 0x0600067B RID: 1659
			// RVA: 0x00009B23 File Offset: 0x00007D23
			get
			{
				return this._dateTimeStyles;
			}
			// Token: 0x0600067C RID: 1660
			// RVA: 0x00009B2B File Offset: 0x00007D2B
			set
			{
				this._dateTimeStyles = value;
			}
		}

		// Token: 0x06000682 RID: 1666
		// RVA: 0x00037464 File Offset: 0x00035664
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = ReflectionUtils.IsNullableType(objectType);
			if (reader.TokenType == JsonToken.Null)
			{
				if (!ReflectionUtils.IsNullableType(objectType))
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot convert null value to {0}.", CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				if (reader.TokenType == JsonToken.Date)
				{
					return reader.Value;
				}
				if (reader.TokenType != JsonToken.String)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token parsing date. Expected String, got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
				}
				string text = reader.Value.ToString();
				if (string.IsNullOrEmpty(text) && flag)
				{
					return null;
				}
				if (!string.IsNullOrEmpty(this._dateTimeFormat))
				{
					return DateTime.ParseExact(text, this._dateTimeFormat, this.Culture, this._dateTimeStyles);
				}
				return DateTime.Parse(text, this.Culture, this._dateTimeStyles);
			}
		}

		// Token: 0x06000681 RID: 1665
		// RVA: 0x000373E4 File Offset: 0x000355E4
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value is DateTime)
			{
				DateTime dateTime = (DateTime)value;
				if ((this._dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (this._dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
				{
					dateTime = dateTime.ToUniversalTime();
				}
				string value2 = dateTime.ToString(this._dateTimeFormat ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Culture);
				writer.WriteValue(value2);
				return;
			}
			throw new JsonSerializationException(StringUtils.FormatWith("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.", CultureInfo.InvariantCulture, ReflectionUtils.GetObjectType(value)));
		}
	}
}
