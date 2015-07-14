using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public sealed class JsonSchemaException : JsonException
	{
		// Token: 0x1700019B RID: 411
		public int LineNumber
		{
			// Token: 0x060009A8 RID: 2472
			// RVA: 0x0000BDC7 File Offset: 0x00009FC7
			get;
			// Token: 0x060009A9 RID: 2473
			// RVA: 0x0000BDCF File Offset: 0x00009FCF
			private set;
		}

		// Token: 0x1700019C RID: 412
		public int LinePosition
		{
			// Token: 0x060009AA RID: 2474
			// RVA: 0x0000BDD8 File Offset: 0x00009FD8
			get;
			// Token: 0x060009AB RID: 2475
			// RVA: 0x0000BDE0 File Offset: 0x00009FE0
			private set;
		}

		// Token: 0x1700019D RID: 413
		public string Path
		{
			// Token: 0x060009AC RID: 2476
			// RVA: 0x0000BDE9 File Offset: 0x00009FE9
			get;
			// Token: 0x060009AD RID: 2477
			// RVA: 0x0000BDF1 File Offset: 0x00009FF1
			private set;
		}

		// Token: 0x060009AE RID: 2478
		// RVA: 0x0000A699 File Offset: 0x00008899
		public JsonSchemaException()
		{
		}

		// Token: 0x060009AF RID: 2479
		// RVA: 0x0000A6A1 File Offset: 0x000088A1
		public JsonSchemaException(string message) : base(message)
		{
		}

		// Token: 0x060009B0 RID: 2480
		// RVA: 0x0000A6AA File Offset: 0x000088AA
		public JsonSchemaException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060009B1 RID: 2481
		// RVA: 0x0000A6B4 File Offset: 0x000088B4
		public JsonSchemaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060009B2 RID: 2482
		// RVA: 0x0000BDFA File Offset: 0x00009FFA
		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) : base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
			this.LinePosition = linePosition;
		}
	}
}
