using Newtonsoft.Json.Schema;
using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	public abstract class JsonConverter
	{
		// Token: 0x17000031 RID: 49
		public virtual bool CanRead
		{
			// Token: 0x0600017C RID: 380
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x17000032 RID: 50
		public virtual bool CanWrite
		{
			// Token: 0x0600017D RID: 381
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x0600017A RID: 378
		public abstract bool CanConvert(Type objectType);

		// Token: 0x0600017B RID: 379
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		public virtual JsonSchema GetSchema()
		{
			return null;
		}

		// Token: 0x06000179 RID: 377
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		// Token: 0x06000178 RID: 376
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
	}
}
