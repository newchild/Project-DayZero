using System;

namespace Amib.Threading
{
	// Token: 0x02000320 RID: 800
	[Flags]
	public enum CallToPostExecute
	{
		// Token: 0x0400126F RID: 4719
		Never = 0,
		// Token: 0x04001270 RID: 4720
		WhenWorkItemCanceled = 1,
		// Token: 0x04001271 RID: 4721
		WhenWorkItemNotCanceled = 2,
		// Token: 0x04001272 RID: 4722
		Always = 3
	}
}
