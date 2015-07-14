using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000035 RID: 53
	public sealed class StringEnumConverter : JsonConverter
	{
		// Token: 0x17000035 RID: 53
		public bool AllowIntegerValues
		{
			// Token: 0x060001AF RID: 431
			// RVA: 0x00006E84 File Offset: 0x00005084
			get;
			// Token: 0x060001B0 RID: 432
			// RVA: 0x00006E8C File Offset: 0x0000508C
			set;
		}

		// Token: 0x17000034 RID: 52
		public bool CamelCaseText
		{
			// Token: 0x060001AD RID: 429
			// RVA: 0x00006E73 File Offset: 0x00005073
			get;
			// Token: 0x060001AE RID: 430
			// RVA: 0x00006E7B File Offset: 0x0000507B
			set;
		}

		// Token: 0x060001B1 RID: 433
		// RVA: 0x00006E95 File Offset: 0x00005095
		public StringEnumConverter()
		{
			this.AllowIntegerValues = true;
		}

		// Token: 0x060001B4 RID: 436
		// RVA: 0x0002C258 File Offset: 0x0002A458
		public override bool CanConvert(Type objectType)
		{
			Type type = ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
			return TypeExtensions.IsEnum(type);
		}

		// Token: 0x060001B3 RID: 435
		// RVA: 0x0002C14C File Offset: 0x0002A34C
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool isNullable;
			Type type = (isNullable = ReflectionUtils.IsNullableType(objectType)) ? Nullable.GetUnderlyingType(objectType) : objectType;
			if (reader.TokenType != JsonToken.Null)
			{
				try
				{
					if (reader.TokenType == JsonToken.String)
					{
						string enumText = reader.Value.ToString();
						object result = EnumUtils.ParseEnumName(enumText, isNullable, type);
						return result;
					}
					if (reader.TokenType == JsonToken.Integer)
					{
						if (!this.AllowIntegerValues)
						{
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Integer value {0} is not allowed.", CultureInfo.InvariantCulture, reader.Value));
						}
						object result = ConvertUtils.ConvertOrCast(reader.Value, CultureInfo.InvariantCulture, type);
						return result;
					}
				}
				catch (Exception ex)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error converting value {0} to type '{1}'.", CultureInfo.InvariantCulture, MiscellaneousUtils.FormatValueForPrint(reader.Value), objectType), ex);
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token {0} when parsing enum.", CultureInfo.InvariantCulture, reader.TokenType));
			}
			if (!ReflectionUtils.IsNullableType(objectType))
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot convert null value to {0}.", CultureInfo.InvariantCulture, objectType));
			}
			return null;
		}

		// Token: 0x060001B2 RID: 434
		// RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			Enum enum = (Enum)value;
			string text = enum.ToString("G");
			if (!char.IsNumber(text[0]))
			{
				if (text[0] != '-')
				{
					Type type = enum.GetType();
					string value2 = EnumUtils.ToEnumName(type, text, this.CamelCaseText);
					writer.WriteValue(value2);
					return;
				}
			}
			writer.WriteValue(value);
		}
	}
}
