using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000332 RID: 818
	internal sealed class LocalSTPInstancePerformanceCounters : IDisposable, ISTPInstancePerformanceCounters
	{
		// Token: 0x040012B3 RID: 4787
		private long _activeThreads;

		// Token: 0x040012B4 RID: 4788
		private long _inUseThreads;

		// Token: 0x040012B6 RID: 4790
		private long _workItemsProcessed;

		// Token: 0x040012B5 RID: 4789
		private long _workItemsQueued;

		// Token: 0x06001830 RID: 6192
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void Dispose()
		{
		}

		// Token: 0x06001831 RID: 6193
		// RVA: 0x00014D11 File Offset: 0x00012F11
		public void SampleThreads(long long_0, long long_1)
		{
			this._activeThreads = long_0;
			this._inUseThreads = long_1;
		}

		// Token: 0x06001832 RID: 6194
		// RVA: 0x00014D21 File Offset: 0x00012F21
		public void SampleWorkItems(long long_0, long long_1)
		{
			this._workItemsQueued = long_0;
			this._workItemsProcessed = long_1;
		}

		// Token: 0x06001834 RID: 6196
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleWorkItemsProcessTime(TimeSpan timeSpan_0)
		{
		}

		// Token: 0x06001833 RID: 6195
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleWorkItemsWaitTime(TimeSpan timeSpan_0)
		{
		}
	}
}
