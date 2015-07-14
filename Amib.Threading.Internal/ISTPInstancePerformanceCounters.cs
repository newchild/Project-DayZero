using System;

namespace Amib.Threading.Internal
{
	// Token: 0x0200032A RID: 810
	internal interface ISTPInstancePerformanceCounters : IDisposable
	{
		// Token: 0x06001807 RID: 6151
		void SampleThreads(long long_0, long long_1);

		// Token: 0x06001808 RID: 6152
		void SampleWorkItems(long long_0, long long_1);

		// Token: 0x0600180A RID: 6154
		void SampleWorkItemsProcessTime(TimeSpan timeSpan_0);

		// Token: 0x06001809 RID: 6153
		void SampleWorkItemsWaitTime(TimeSpan timeSpan_0);
	}
}
