using System;

namespace osu
{
	// Token: 0x020006B0 RID: 1712
	internal enum FrameSync
	{
		// Token: 0x0400319D RID: 12701
		VSync = 1,
		// Token: 0x0400319E RID: 12702
		Limit120 = 0,
		// Token: 0x0400319F RID: 12703
		Unlimited = 2,
		// Token: 0x040031A0 RID: 12704
		LowLatencyVSync,
		// Token: 0x040031A1 RID: 12705
		CompletelyUnlimited,
		// Token: 0x040031A2 RID: 12706
		Limit240
	}
}
