using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000036 RID: 54
	public sealed class VersionConverter : JsonConverter
	{
		// Token: 0x060001B7 RID: 439
		// RVA: 0x00006ECF File Offset: 0x000050CF
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Version);
		}

		// Token: 0x060001B6 RID: 438
		// RVA: 0x0002C280 File Offset: 0x0002A480
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (reader.TokenType == JsonToken.String)
			{
				try
				{
					return new Version((string)reader.Value);
				}
				catch (Exception ex)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error parsing version string: {0}", CultureInfo.InvariantCulture, reader.Value), ex);
				}
			}
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token or value when parsing version. Token: {0}, Value: {1}", CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
		}

		// Token: 0x060001B5 RID: 437
		// RVA: 0x00006EA4 File Offset: 0x000050A4
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			if (!(value is Version))
			{
				throw new JsonSerializationException("Expected Version object value");
			}
			writer.WriteValue(value.ToString());
		}
	}
}
