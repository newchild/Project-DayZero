using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public sealed class JsonReaderException : JsonException
	{
		// Token: 0x1700013F RID: 319
		public int LineNumber
		{
			// Token: 0x06000788 RID: 1928
			// RVA: 0x0000A6F2 File Offset: 0x000088F2
			get;
			// Token: 0x06000789 RID: 1929
			// RVA: 0x0000A6FA File Offset: 0x000088FA
			private set;
		}

		// Token: 0x17000140 RID: 320
		public int LinePosition
		{
			// Token: 0x0600078A RID: 1930
			// RVA: 0x0000A703 File Offset: 0x00008903
			get;
			// Token: 0x0600078B RID: 1931
			// RVA: 0x0000A70B File Offset: 0x0000890B
			private set;
		}

		// Token: 0x17000141 RID: 321
		public string Path
		{
			// Token: 0x0600078C RID: 1932
			// RVA: 0x0000A714 File Offset: 0x00008914
			get;
			// Token: 0x0600078D RID: 1933
			// RVA: 0x0000A71C File Offset: 0x0000891C
			private set;
		}

		// Token: 0x0600078E RID: 1934
		// RVA: 0x0000A699 File Offset: 0x00008899
		public JsonReaderException()
		{
		}

		// Token: 0x0600078F RID: 1935
		// RVA: 0x0000A6A1 File Offset: 0x000088A1
		public JsonReaderException(string message) : base(message)
		{
		}

		// Token: 0x06000790 RID: 1936
		// RVA: 0x0000A6AA File Offset: 0x000088AA
		public JsonReaderException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000791 RID: 1937
		// RVA: 0x0000A6B4 File Offset: 0x000088B4
		public JsonReaderException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000792 RID: 1938
		// RVA: 0x0000A725 File Offset: 0x00008925
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition) : base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
			this.LinePosition = linePosition;
		}

		// Token: 0x06000793 RID: 1939
		// RVA: 0x0000A746 File Offset: 0x00008946
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return JsonReaderException.Create(reader, message, null);
		}

		// Token: 0x06000794 RID: 1940
		// RVA: 0x0000A750 File Offset: 0x00008950
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return JsonReaderException.Create(reader as IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x06000795 RID: 1941
		// RVA: 0x0003AEB0 File Offset: 0x000390B0
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			message = JsonPosition.FormatMessage(lineInfo, path, message);
			int lineNumber;
			int linePosition;
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				lineNumber = lineInfo.LineNumber;
				linePosition = lineInfo.LinePosition;
			}
			else
			{
				lineNumber = 0;
				linePosition = 0;
			}
			return new JsonReaderException(message, ex, path, lineNumber, linePosition);
		}
	}
}
