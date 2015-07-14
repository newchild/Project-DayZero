using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200002D RID: 45
	public sealed class BinaryConverter : JsonConverter
	{
		// Token: 0x06000183 RID: 387
		// RVA: 0x00006D30 File Offset: 0x00004F30
		public override bool CanConvert(Type objectType)
		{
			if (objectType != typeof(SqlBinary))
			{
				if (objectType != typeof(SqlBinary?))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000180 RID: 384
		// RVA: 0x0002B448 File Offset: 0x00029648
		private byte[] GetByteArray(object value)
		{
			if (!(value is SqlBinary))
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Unexpected value type when writing binary: {0}", CultureInfo.InvariantCulture, value.GetType()));
			}
			return ((SqlBinary)value).Value;
		}

		// Token: 0x06000182 RID: 386
		// RVA: 0x0002B554 File Offset: 0x00029754
		private byte[] ReadByteArray(JsonReader reader)
		{
			List<byte> list = new List<byte>();
			while (reader.Read())
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.Comment:
					continue;
				case JsonToken.Raw:
					break;
				case JsonToken.Integer:
					list.Add(Convert.ToByte(reader.Value, CultureInfo.InvariantCulture));
					continue;
				default:
					if (tokenType == JsonToken.EndArray)
					{
						return list.ToArray();
					}
					break;
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token when reading bytes: {0}", CultureInfo.InvariantCulture, reader.TokenType));
			}
			throw JsonSerializationException.Create(reader, "Unexpected end when reading bytes.");
		}

		// Token: 0x06000181 RID: 385
		// RVA: 0x0002B488 File Offset: 0x00029688
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			Type type = ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
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
				byte[] value;
				if (reader.TokenType == JsonToken.StartArray)
				{
					value = this.ReadByteArray(reader);
				}
				else
				{
					if (reader.TokenType != JsonToken.String)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected token parsing binary. Expected String or StartArray, got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
					}
					string s = reader.Value.ToString();
					value = Convert.FromBase64String(s);
				}
				if (type == typeof(SqlBinary))
				{
					return new SqlBinary(value);
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected object type when writing binary: {0}", CultureInfo.InvariantCulture, objectType));
			}
		}

		// Token: 0x0600017F RID: 383
		// RVA: 0x0002B420 File Offset: 0x00029620
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			byte[] byteArray = this.GetByteArray(value);
			writer.WriteValue(byteArray);
		}
	}
}
