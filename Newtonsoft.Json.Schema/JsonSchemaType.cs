using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200011D RID: 285
	[Flags]
	public enum JsonSchemaType
	{
		// Token: 0x040004F0 RID: 1264
		None = 0,
		// Token: 0x040004F1 RID: 1265
		String = 1,
		// Token: 0x040004F2 RID: 1266
		Float = 2,
		// Token: 0x040004F3 RID: 1267
		Integer = 4,
		// Token: 0x040004F4 RID: 1268
		Boolean = 8,
		// Token: 0x040004F5 RID: 1269
		Object = 16,
		// Token: 0x040004F6 RID: 1270
		Array = 32,
		// Token: 0x040004F7 RID: 1271
		Null = 64,
		// Token: 0x040004F8 RID: 1272
		Any = 127
	}
}
