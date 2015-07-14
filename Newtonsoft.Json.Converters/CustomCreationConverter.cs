using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200002F RID: 47
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x17000033 RID: 51
		public override bool CanWrite
		{
			// Token: 0x0600018D RID: 397
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x0600018C RID: 396
		// RVA: 0x00006D74 File Offset: 0x00004F74
		public override bool CanConvert(Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}

		// Token: 0x0600018B RID: 395
		public abstract T Create(Type objectType);

		// Token: 0x0600018A RID: 394
		// RVA: 0x0002B660 File Offset: 0x00029860
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}
			T t = this.Create(objectType);
			if (t == null)
			{
				throw new JsonSerializationException("No object created.");
			}
			serializer.Populate(reader, t);
			return t;
		}

		// Token: 0x06000189 RID: 393
		// RVA: 0x00006D68 File Offset: 0x00004F68
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotSupportedException("CustomCreationConverter should only be used while deserializing.");
		}
	}
}
