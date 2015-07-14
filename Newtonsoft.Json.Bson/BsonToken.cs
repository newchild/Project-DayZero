using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200001F RID: 31
	internal abstract class BsonToken
	{
		// Token: 0x17000017 RID: 23
		public int CalculatedSize
		{
			// Token: 0x060000BD RID: 189
			// RVA: 0x00006358 File Offset: 0x00004558
			get;
			// Token: 0x060000BE RID: 190
			// RVA: 0x00006360 File Offset: 0x00004560
			set;
		}

		// Token: 0x17000016 RID: 22
		public BsonToken Parent
		{
			// Token: 0x060000BB RID: 187
			// RVA: 0x00006347 File Offset: 0x00004547
			get;
			// Token: 0x060000BC RID: 188
			// RVA: 0x0000634F File Offset: 0x0000454F
			set;
		}

		// Token: 0x17000015 RID: 21
		public abstract BsonType Type
		{
			// Token: 0x060000BA RID: 186
			get;
		}
	}
}
