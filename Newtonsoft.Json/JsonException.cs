using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x060001D0 RID: 464
		// RVA: 0x00006F93 File Offset: 0x00005193
		public JsonException()
		{
		}

		// Token: 0x060001D1 RID: 465
		// RVA: 0x00006F9B File Offset: 0x0000519B
		public JsonException(string message) : base(message)
		{
		}

		// Token: 0x060001D2 RID: 466
		// RVA: 0x00006FA4 File Offset: 0x000051A4
		public JsonException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060001D3 RID: 467
		// RVA: 0x00006FAE File Offset: 0x000051AE
		public JsonException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060001D4 RID: 468
		// RVA: 0x00006FB8 File Offset: 0x000051B8
		internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message)
		{
			message = JsonPosition.FormatMessage(lineInfo, path, message);
			return new JsonException(message);
		}
	}
}
