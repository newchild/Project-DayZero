using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000034 RID: 52
	public sealed class RegexConverter : JsonConverter
	{
		// Token: 0x040000CE RID: 206
		private const string OptionsName = "Options";

		// Token: 0x040000CD RID: 205
		private const string PatternName = "Pattern";

		// Token: 0x060001AB RID: 427
		// RVA: 0x00006E64 File Offset: 0x00005064
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Regex);
		}

		// Token: 0x060001A5 RID: 421
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return (options & flag) == flag;
		}

		// Token: 0x060001A8 RID: 424
		// RVA: 0x00006E30 File Offset: 0x00005030
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.StartObject)
			{
				return this.ReadRegexObject(reader, serializer);
			}
			if (reader.TokenType == JsonToken.String)
			{
				return this.ReadRegexString(reader);
			}
			throw JsonSerializationException.Create(reader, "Unexpected token when reading Regex.");
		}

		// Token: 0x060001AA RID: 426
		// RVA: 0x0002C008 File Offset: 0x0002A208
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			string text = null;
			RegexOptions? regexOptions = null;
			while (reader.Read())
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.PropertyName:
				{
					string a = reader.Value.ToString();
					if (!reader.Read())
					{
						throw JsonSerializationException.Create(reader, "Unexpected end when reading Regex.");
					}
					if (string.Equals(a, "Pattern", StringComparison.OrdinalIgnoreCase))
					{
						text = (string)reader.Value;
					}
					else if (string.Equals(a, "Options", StringComparison.OrdinalIgnoreCase))
					{
						regexOptions = new RegexOptions?(serializer.Deserialize<RegexOptions>(reader));
					}
					else
					{
						reader.Skip();
					}
					break;
				}
				case JsonToken.Comment:
					break;
				default:
					if (tokenType == JsonToken.EndObject)
					{
						if (text == null)
						{
							throw JsonSerializationException.Create(reader, "Error deserializing Regex. No pattern found.");
						}
						return new Regex(text, regexOptions ?? RegexOptions.None);
					}
					break;
				}
			}
			throw JsonSerializationException.Create(reader, "Unexpected end when reading Regex.");
		}

		// Token: 0x060001A9 RID: 425
		// RVA: 0x0002BF5C File Offset: 0x0002A15C
		private object ReadRegexString(JsonReader reader)
		{
			string text = (string)reader.Value;
			int num = text.LastIndexOf('/');
			string pattern = text.Substring(1, num - 1);
			string text2 = text.Substring(num + 1);
			RegexOptions regexOptions = RegexOptions.None;
			string text3 = text2;
			for (int i = 0; i < text3.Length; i++)
			{
				char c = text3[i];
				char c2 = c;
				if (c2 <= 'm')
				{
					if (c2 != 'i')
					{
						if (c2 == 'm')
						{
							regexOptions |= RegexOptions.Multiline;
						}
					}
					else
					{
						regexOptions |= RegexOptions.IgnoreCase;
					}
				}
				else if (c2 != 's')
				{
					if (c2 == 'x')
					{
						regexOptions |= RegexOptions.ExplicitCapture;
					}
				}
				else
				{
					regexOptions |= RegexOptions.Singleline;
				}
			}
			return new Regex(pattern, regexOptions);
		}

		// Token: 0x060001A6 RID: 422
		// RVA: 0x0002BE48 File Offset: 0x0002A048
		private void WriteBson(BsonWriter writer, Regex regex)
		{
			string text = null;
			if (this.HasFlag(regex.Options, RegexOptions.IgnoreCase))
			{
				text += "i";
			}
			if (this.HasFlag(regex.Options, RegexOptions.Multiline))
			{
				text += "m";
			}
			if (this.HasFlag(regex.Options, RegexOptions.Singleline))
			{
				text += "s";
			}
			text += "u";
			if (this.HasFlag(regex.Options, RegexOptions.ExplicitCapture))
			{
				text += "x";
			}
			writer.WriteRegex(regex.ToString(), text);
		}

		// Token: 0x060001A4 RID: 420
		// RVA: 0x0002BE18 File Offset: 0x0002A018
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Regex regex = (Regex)value;
			BsonWriter bsonWriter = writer as BsonWriter;
			if (bsonWriter != null)
			{
				this.WriteBson(bsonWriter, regex);
				return;
			}
			this.WriteJson(writer, regex, serializer);
		}

		// Token: 0x060001A7 RID: 423
		// RVA: 0x0002BEE0 File Offset: 0x0002A0E0
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
			DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Pattern") : "Pattern");
			writer.WriteValue(regex.ToString());
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Options") : "Options");
			serializer.Serialize(writer, regex.Options);
			writer.WriteEndObject();
		}
	}
}
