using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006B RID: 107
	internal static class JsonTokenUtils
	{
		// Token: 0x0600030C RID: 780
		// RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		internal static bool IsEndToken(JsonToken token)
		{
			switch (token)
			{
			case JsonToken.EndObject:
			case JsonToken.EndArray:
			case JsonToken.EndConstructor:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600030E RID: 782
		// RVA: 0x0002FB20 File Offset: 0x0002DD20
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			switch (token)
			{
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Null:
			case JsonToken.Undefined:
			case JsonToken.Date:
			case JsonToken.Bytes:
				return true;
			case JsonToken.EndObject:
			case JsonToken.EndArray:
			case JsonToken.EndConstructor:
				return false;
			}
			return false;
		}

		// Token: 0x0600030D RID: 781
		// RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		internal static bool IsStartToken(JsonToken token)
		{
			switch (token)
			{
			case JsonToken.StartObject:
			case JsonToken.StartArray:
			case JsonToken.StartConstructor:
				return true;
			default:
				return false;
			}
		}
	}
}
