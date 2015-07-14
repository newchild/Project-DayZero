using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public sealed class JsonSerializationException : JsonException
	{
		// Token: 0x060007D4 RID: 2004
		// RVA: 0x0000A699 File Offset: 0x00008899
		public JsonSerializationException()
		{
		}

		// Token: 0x060007D5 RID: 2005
		// RVA: 0x0000A6A1 File Offset: 0x000088A1
		public JsonSerializationException(string message) : base(message)
		{
		}

		// Token: 0x060007D6 RID: 2006
		// RVA: 0x0000A6AA File Offset: 0x000088AA
		public JsonSerializationException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060007D7 RID: 2007
		// RVA: 0x0000A6B4 File Offset: 0x000088B4
		public JsonSerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060007D8 RID: 2008
		// RVA: 0x0000AA4D File Offset: 0x00008C4D
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return JsonSerializationException.Create(reader, message, null);
		}

		// Token: 0x060007D9 RID: 2009
		// RVA: 0x0000AA57 File Offset: 0x00008C57
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			return JsonSerializationException.Create(reader as IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x060007DA RID: 2010
		// RVA: 0x0000AA6C File Offset: 0x00008C6C
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			message = JsonPosition.FormatMessage(lineInfo, path, message);
			return new JsonSerializationException(message, ex);
		}
	}
}
