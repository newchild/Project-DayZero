using ns79;
using System;

namespace ns19
{
	// Token: 0x020003DE RID: 990
	internal sealed class Class439 : IDisposable
	{
		// Token: 0x0400190C RID: 6412
		internal Class911 class911_0;

		// Token: 0x0400190D RID: 6413
		public string string_0;

		// Token: 0x0400190E RID: 6414
		public string string_1;

		// Token: 0x06001FC1 RID: 8129
		// RVA: 0x00019F92 File Offset: 0x00018192
		public void Dispose()
		{
			this.class911_0.Dispose();
		}

		// Token: 0x06001FBF RID: 8127
		// RVA: 0x00019F69 File Offset: 0x00018169
		internal bool method_0()
		{
			return this.class911_0.float_0 > 0f;
		}

		// Token: 0x06001FC0 RID: 8128
		// RVA: 0x00019F7D File Offset: 0x0001817D
		internal void method_1(bool bool_0)
		{
			this.class911_0.float_0 = (float)(bool_0 ? 1 : 0);
		}

		// Token: 0x06001FC2 RID: 8130
		// RVA: 0x00019F9F File Offset: 0x0001819F
		public bool vmethod_0(string string_2)
		{
			return this.string_1.IndexOf(string_2, StringComparison.CurrentCultureIgnoreCase) >= 0 || this.string_0.IndexOf(string_2, StringComparison.CurrentCultureIgnoreCase) >= 0;
		}
	}
}
