using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000027 RID: 39
	internal enum BsonType : sbyte
	{
		// Token: 0x04000097 RID: 151
		Number = 1,
		// Token: 0x04000098 RID: 152
		String,
		// Token: 0x04000099 RID: 153
		Object,
		// Token: 0x0400009A RID: 154
		Array,
		// Token: 0x0400009B RID: 155
		Binary,
		// Token: 0x0400009C RID: 156
		Undefined,
		// Token: 0x0400009D RID: 157
		Oid,
		// Token: 0x0400009E RID: 158
		Boolean,
		// Token: 0x0400009F RID: 159
		Date,
		// Token: 0x040000A0 RID: 160
		Null,
		// Token: 0x040000A1 RID: 161
		Regex,
		// Token: 0x040000A2 RID: 162
		Reference,
		// Token: 0x040000A3 RID: 163
		Code,
		// Token: 0x040000A4 RID: 164
		Symbol,
		// Token: 0x040000A5 RID: 165
		CodeWScope,
		// Token: 0x040000A6 RID: 166
		Integer,
		// Token: 0x040000A7 RID: 167
		TimeStamp,
		// Token: 0x040000A8 RID: 168
		Long,
		// Token: 0x040000A9 RID: 169
		MinKey = -1,
		// Token: 0x040000AA RID: 170
		MaxKey = 127
	}
}
