using System;

namespace Amib.Threading.Internal
{
	// Token: 0x0200032B RID: 811
	internal enum STPPerformanceCounterType
	{
		// Token: 0x04001298 RID: 4760
		ActiveThreads,
		// Token: 0x04001299 RID: 4761
		InUseThreads,
		// Token: 0x0400129A RID: 4762
		OverheadThreads,
		// Token: 0x0400129B RID: 4763
		OverheadThreadsPercent,
		// Token: 0x0400129C RID: 4764
		OverheadThreadsPercentBase,
		// Token: 0x0400129D RID: 4765
		WorkItems,
		// Token: 0x0400129E RID: 4766
		WorkItemsInQueue,
		// Token: 0x0400129F RID: 4767
		WorkItemsProcessed,
		// Token: 0x040012A0 RID: 4768
		WorkItemsQueuedPerSecond,
		// Token: 0x040012A1 RID: 4769
		WorkItemsProcessedPerSecond,
		// Token: 0x040012A2 RID: 4770
		AvgWorkItemWaitTime,
		// Token: 0x040012A3 RID: 4771
		AvgWorkItemWaitTimeBase,
		// Token: 0x040012A4 RID: 4772
		AvgWorkItemProcessTime,
		// Token: 0x040012A5 RID: 4773
		AvgWorkItemProcessTimeBase,
		// Token: 0x040012A6 RID: 4774
		WorkItemsGroups,
		// Token: 0x040012A7 RID: 4775
		LastCounter = 14
	}
}
