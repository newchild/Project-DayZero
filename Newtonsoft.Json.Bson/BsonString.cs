using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000023 RID: 35
	internal sealed class BsonString : BsonValue
	{
		// Token: 0x1700001C RID: 28
		public int ByteCount
		{
			// Token: 0x060000CD RID: 205
			// RVA: 0x00006404 File Offset: 0x00004604
			get;
			// Token: 0x060000CE RID: 206
			// RVA: 0x0000640C File Offset: 0x0000460C
			set;
		}

		// Token: 0x1700001D RID: 29
		public bool IncludeLength
		{
			// Token: 0x060000CF RID: 207
			// RVA: 0x00006415 File Offset: 0x00004615
			get;
			// Token: 0x060000D0 RID: 208
			// RVA: 0x0000641D File Offset: 0x0000461D
			set;
		}

		// Token: 0x060000D1 RID: 209
		// RVA: 0x00006426 File Offset: 0x00004626
		public BsonString(object value, bool includeLength) : base(value, BsonType.String)
		{
			this.IncludeLength = includeLength;
		}
	}
}
