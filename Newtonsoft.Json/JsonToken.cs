using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000156 RID: 342
	public enum JsonToken
	{
		// Token: 0x040005B3 RID: 1459
		None,
		// Token: 0x040005B4 RID: 1460
		StartObject,
		// Token: 0x040005B5 RID: 1461
		StartArray,
		// Token: 0x040005B6 RID: 1462
		StartConstructor,
		// Token: 0x040005B7 RID: 1463
		PropertyName,
		// Token: 0x040005B8 RID: 1464
		Comment,
		// Token: 0x040005B9 RID: 1465
		Raw,
		// Token: 0x040005BA RID: 1466
		Integer,
		// Token: 0x040005BB RID: 1467
		Float,
		// Token: 0x040005BC RID: 1468
		String,
		// Token: 0x040005BD RID: 1469
		Boolean,
		// Token: 0x040005BE RID: 1470
		Null,
		// Token: 0x040005BF RID: 1471
		Undefined,
		// Token: 0x040005C0 RID: 1472
		EndObject,
		// Token: 0x040005C1 RID: 1473
		EndArray,
		// Token: 0x040005C2 RID: 1474
		EndConstructor,
		// Token: 0x040005C3 RID: 1475
		Date,
		// Token: 0x040005C4 RID: 1476
		Bytes
	}
}
