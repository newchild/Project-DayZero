using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000024 RID: 36
	internal sealed class BsonBinary : BsonValue
	{
		// Token: 0x1700001E RID: 30
		public BsonBinaryType BinaryType
		{
			// Token: 0x060000D2 RID: 210
			// RVA: 0x00006437 File Offset: 0x00004637
			get;
			// Token: 0x060000D3 RID: 211
			// RVA: 0x0000643F File Offset: 0x0000463F
			set;
		}

		// Token: 0x060000D4 RID: 212
		// RVA: 0x00006448 File Offset: 0x00004648
		public BsonBinary(byte[] value, BsonBinaryType binaryType) : base(value, BsonType.Binary)
		{
			this.BinaryType = binaryType;
		}
	}
}
