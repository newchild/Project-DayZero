using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BE RID: 190
	public sealed class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x06000685 RID: 1669
		// RVA: 0x0003758C File Offset: 0x0003578C
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				if (!ReflectionUtils.IsNullable(objectType))
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot convert null value to {0}.", CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				if (reader.TokenType != JsonToken.StartConstructor || !string.Equals(reader.Value.ToString(), "Date", StringComparison.Ordinal))
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token or value when parsing date. Token: {0}, Value: {1}", CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
				}
				reader.Read();
				if (reader.TokenType != JsonToken.Integer)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token parsing date. Expected Integer, got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
				}
				long javaScriptTicks = (long)reader.Value;
				DateTime dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
				reader.Read();
				if (reader.TokenType != JsonToken.EndConstructor)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token parsing date. Expected EndConstructor, got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
				}
				return dateTime;
			}
		}

		// Token: 0x06000684 RID: 1668
		// RVA: 0x0003753C File Offset: 0x0003573C
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (!(value is DateTime))
			{
				throw new JsonSerializationException("Expected date object value.");
			}
			DateTime dateTime = ((DateTime)value).ToUniversalTime();
			long value2 = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime);
			writer.WriteStartConstructor("Date");
			writer.WriteValue(value2);
			writer.WriteEndConstructor();
		}
	}
}
