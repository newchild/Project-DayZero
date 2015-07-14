using System;
using System.Threading;

namespace ns50
{
	// Token: 0x020002E7 RID: 743
	internal sealed class Class267 : Class266
	{
		// Token: 0x020002E8 RID: 744
		private sealed class Class269 : IAsyncResult
		{
			// Token: 0x040011C5 RID: 4549
			private object object_0;

			// Token: 0x1700030D RID: 781
			public object AsyncState
			{
				// Token: 0x06001700 RID: 5888
				// RVA: 0x000143DC File Offset: 0x000125DC
				get
				{
					return this.object_0;
				}
			}

			// Token: 0x1700030C RID: 780
			public WaitHandle AsyncWaitHandle
			{
				// Token: 0x06001701 RID: 5889
				// RVA: 0x000060D8 File Offset: 0x000042D8
				get
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x1700030E RID: 782
			public bool CompletedSynchronously
			{
				// Token: 0x06001702 RID: 5890
				// RVA: 0x000060D8 File Offset: 0x000042D8
				get
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x1700030B RID: 779
			public bool IsCompleted
			{
				// Token: 0x06001703 RID: 5891
				// RVA: 0x00006D86 File Offset: 0x00004F86
				get
				{
					return false;
				}
			}
		}

		// Token: 0x040011C4 RID: 4548
		private long long_0;

		// Token: 0x060016FF RID: 5887
		// RVA: 0x000143C5 File Offset: 0x000125C5
		public override string ToString()
		{
			return "udptracker:" + this.long_0;
		}
	}
}
