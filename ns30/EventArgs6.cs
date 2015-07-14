using System;

namespace ns30
{
	// Token: 0x02000222 RID: 546
	internal sealed class EventArgs6 : EventArgs
	{
		// Token: 0x04000E9B RID: 3739
		private long long_0;

		// Token: 0x04000E9C RID: 3740
		private long long_1;

		// Token: 0x06001360 RID: 4960
		// RVA: 0x00011FA3 File Offset: 0x000101A3
		public EventArgs6(long long_2, long long_3)
		{
			this.long_0 = long_2;
			this.long_1 = long_3;
		}

		// Token: 0x06001361 RID: 4961
		// RVA: 0x00011FB9 File Offset: 0x000101B9
		public long method_0()
		{
			return this.long_0;
		}

		// Token: 0x06001362 RID: 4962
		// RVA: 0x00011FC1 File Offset: 0x000101C1
		public long method_1()
		{
			return this.long_1;
		}
	}
}
