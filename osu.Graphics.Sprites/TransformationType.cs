using System;

namespace osu.Graphics.Sprites
{
	// Token: 0x02000585 RID: 1413
	[Flags]
	internal enum TransformationType
	{
		// Token: 0x040025D3 RID: 9683
		None = 0,
		// Token: 0x040025D4 RID: 9684
		Movement = 1,
		// Token: 0x040025D5 RID: 9685
		Fade = 2,
		// Token: 0x040025D6 RID: 9686
		Scale = 4,
		// Token: 0x040025D7 RID: 9687
		Rotation = 8,
		// Token: 0x040025D8 RID: 9688
		Colour = 16,
		// Token: 0x040025D9 RID: 9689
		ParameterFlipHorizontal = 32,
		// Token: 0x040025DA RID: 9690
		ParameterFlipVertical = 64,
		// Token: 0x040025DB RID: 9691
		MovementX = 128,
		// Token: 0x040025DC RID: 9692
		MovementY = 256,
		// Token: 0x040025DD RID: 9693
		VectorScale = 512,
		// Token: 0x040025DE RID: 9694
		ParameterAdditive = 1024,
		// Token: 0x040025DF RID: 9695
		ClippingWidth = 2048,
		// Token: 0x040025E0 RID: 9696
		ClippingHeight = 4096,
		// Token: 0x040025E1 RID: 9697
		ClipRectangle = 8192
	}
}
