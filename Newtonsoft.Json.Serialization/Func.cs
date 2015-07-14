using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009A RID: 154
	// Token: 0x060004B8 RID: 1208
	public delegate TResult Func<TResult>();
	// Token: 0x0200009B RID: 155
	// Token: 0x060004BC RID: 1212
	public delegate TResult Func<T, TResult>(T a);
	// Token: 0x0200009C RID: 156
	// Token: 0x060004C0 RID: 1216
	public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
	// Token: 0x0200009D RID: 157
	// Token: 0x060004C4 RID: 1220
	public delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
	// Token: 0x0200009E RID: 158
	// Token: 0x060004C8 RID: 1224
	public delegate TResult Func<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
}
