using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000315 RID: 789
	internal interface IInternalWorkItemResult
	{
		event// Token: 0x14000012 RID: 18
		WorkItemStateCallback OnWorkItemCompleted;

		event// Token: 0x14000011 RID: 17
		WorkItemStateCallback OnWorkItemStarted;
	}
}
