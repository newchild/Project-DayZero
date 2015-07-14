using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200002E RID: 46
	public sealed class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x06000187 RID: 391
		// RVA: 0x00006D59 File Offset: 0x00004F59
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(BsonObjectId);
		}

		// Token: 0x06000186 RID: 390
		// RVA: 0x0002B614 File Offset: 0x00029814
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.Bytes)
			{
				throw new JsonSerializationException(StringUtils.FormatWith("Expected Bytes but got {0}.", CultureInfo.InvariantCulture, reader.TokenType));
			}
			byte[] value = (byte[])reader.Value;
			return new BsonObjectId(value);
		}

		// Token: 0x06000185 RID: 389
		// RVA: 0x0002B5DC File Offset: 0x000297DC
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			BsonObjectId bsonObjectId = (BsonObjectId)value;
			BsonWriter bsonWriter = writer as BsonWriter;
			if (bsonWriter != null)
			{
				bsonWriter.WriteObjectId(bsonObjectId.Value);
				return;
			}
			writer.WriteValue(bsonObjectId.Value);
		}
	}
}
