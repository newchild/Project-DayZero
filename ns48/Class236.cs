using System;
using System.Threading;

namespace ns48
{
	// Token: 0x020002BC RID: 700
	internal sealed class Class236 : IAsyncResult
	{
		// Token: 0x0400114C RID: 4428
		private bool bool_0;

		// Token: 0x0400114D RID: 4429
		private bool bool_1;

		// Token: 0x0400114E RID: 4430
		private ManualResetEvent manualResetEvent_0;

		// Token: 0x0400114B RID: 4427
		private object object_0;

		// Token: 0x170002FE RID: 766
		public object AsyncState
		{
			// Token: 0x06001688 RID: 5768
			// RVA: 0x00013F3D File Offset: 0x0001213D
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x170002FF RID: 767
		public bool CompletedSynchronously
		{
			// Token: 0x0600168A RID: 5770
			// RVA: 0x00013F4D File Offset: 0x0001214D
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x170002FD RID: 765
		public bool IsCompleted
		{
			// Token: 0x0600168B RID: 5771
			// RVA: 0x00013F55 File Offset: 0x00012155
			get
			{
				return this.bool_1;
			}
		}

		// Token: 0x17000300 RID: 768
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			// Token: 0x06001689 RID: 5769
			// RVA: 0x00013F45 File Offset: 0x00012145
			get
			{
				return this.manualResetEvent_0;
			}
		}
	}
}
