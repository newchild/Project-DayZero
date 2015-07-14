using System;

namespace osu.GameplayElements.HitObjects
{
	// Token: 0x0200030B RID: 779
	public static class Extensions
	{
		// Token: 0x06001768 RID: 5992
		// RVA: 0x00014837 File Offset: 0x00012A37
		public static bool IsType(this HitObjectType Type, HitObjectType type)
		{
			return (Type & type) > (HitObjectType)0;
		}

		// Token: 0x06001769 RID: 5993
		// RVA: 0x00014837 File Offset: 0x00012A37
		public static bool IsType(this HitObjectSoundType Type, HitObjectSoundType type)
		{
			return (Type & type) > HitObjectSoundType.None;
		}
	}
}
