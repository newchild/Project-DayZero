using System;

namespace osu.GameplayElements.HitObjects
{
	// Token: 0x0200030D RID: 781
	[Flags]
	public enum HitObjectType
	{
		// Token: 0x04001239 RID: 4665
		Normal = 1,
		// Token: 0x0400123A RID: 4666
		Slider = 2,
		// Token: 0x0400123B RID: 4667
		NewCombo = 4,
		// Token: 0x0400123C RID: 4668
		NormalNewCombo = 5,
		// Token: 0x0400123D RID: 4669
		SliderNewCombo = 6,
		// Token: 0x0400123E RID: 4670
		Spinner = 8,
		// Token: 0x0400123F RID: 4671
		ColourHax = 112,
		// Token: 0x04001240 RID: 4672
		Hold = 128,
		// Token: 0x04001241 RID: 4673
		ManiaLong = 128
	}
}
