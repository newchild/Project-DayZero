using System;

namespace osu.GameplayElements
{
	// Token: 0x0200067D RID: 1661
	internal enum FileSection
	{
		// Token: 0x0400302F RID: 12335
		Unknown,
		// Token: 0x04003030 RID: 12336
		General,
		// Token: 0x04003031 RID: 12337
		Colours,
		// Token: 0x04003032 RID: 12338
		Editor = 4,
		// Token: 0x04003033 RID: 12339
		Metadata = 8,
		// Token: 0x04003034 RID: 12340
		TimingPoints = 16,
		// Token: 0x04003035 RID: 12341
		Events = 32,
		// Token: 0x04003036 RID: 12342
		HitObjects = 64,
		// Token: 0x04003037 RID: 12343
		Difficulty = 128,
		// Token: 0x04003038 RID: 12344
		Variables = 256,
		// Token: 0x04003039 RID: 12345
		All = 511
	}
}
