using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public sealed class JsonWriterException : JsonException
	{
		// Token: 0x1700013E RID: 318
		public string Path
		{
			// Token: 0x0600077F RID: 1919
			// RVA: 0x0000A688 File Offset: 0x00008888
			get;
			// Token: 0x06000780 RID: 1920
			// RVA: 0x0000A690 File Offset: 0x00008890
			private set;
		}

		// Token: 0x06000781 RID: 1921
		// RVA: 0x0000A699 File Offset: 0x00008899
		public JsonWriterException()
		{
		}

		// Token: 0x06000782 RID: 1922
		// RVA: 0x0000A6A1 File Offset: 0x000088A1
		public JsonWriterException(string message) : base(message)
		{
		}

		// Token: 0x06000783 RID: 1923
		// RVA: 0x0000A6AA File Offset: 0x000088AA
		public JsonWriterException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000784 RID: 1924
		// RVA: 0x0000A6B4 File Offset: 0x000088B4
		public JsonWriterException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000785 RID: 1925
		// RVA: 0x0000A6BE File Offset: 0x000088BE
		internal JsonWriterException(string message, Exception innerException, string path) : base(message, innerException)
		{
			this.Path = path;
		}

		// Token: 0x06000786 RID: 1926
		// RVA: 0x0000A6CF File Offset: 0x000088CF
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			return JsonWriterException.Create(writer.ContainerPath, message, ex);
		}

		// Token: 0x06000787 RID: 1927
		// RVA: 0x0000A6DE File Offset: 0x000088DE
		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			message = JsonPosition.FormatMessage(null, path, message);
			return new JsonWriterException(message, ex, path);
		}
	}
}
