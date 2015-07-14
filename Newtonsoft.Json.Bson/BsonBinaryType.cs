using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000017 RID: 23
	internal enum BsonBinaryType : byte
	{
		// Token: 0x04000043 RID: 67
		Binary,
		// Token: 0x04000044 RID: 68
		Function,
		// Token: 0x04000045 RID: 69
		BinaryOld,
		// Token: 0x04000046 RID: 70
		UuidOld,
		// Token: 0x04000047 RID: 71
		Uuid,
		// Token: 0x04000048 RID: 72
		Md5,
		// Token: 0x04000049 RID: 73
		UserDefined = 128
	}
}
