using ns18;
using ns24;
using ns3;
using osu_common;
using System;

namespace ns76
{
	// Token: 0x0200055C RID: 1372
	internal static class Class721
	{
		// Token: 0x06002C7C RID: 11388
		// RVA: 0x00021B73 File Offset: 0x0001FD73
		internal static Class512 Create(PlayModes playModes_0, Class296 class296_0)
		{
			return Class721.Create(playModes_0, string.Empty, class296_0);
		}

		// Token: 0x06002C7D RID: 11389
		// RVA: 0x00120B34 File Offset: 0x0011ED34
		internal static Class512 Create(PlayModes playModes_0, string string_0, Class296 class296_0)
		{
			switch (playModes_0)
			{
			case PlayModes.Taiko:
				return new Class515(class296_0, string_0);
			case PlayModes.CatchTheBeat:
				return new Class516(class296_0, string_0);
			case PlayModes.OsuMania:
				return new Class514(class296_0, string_0);
			default:
				if (Class62.smethod_1())
				{
					return new Class513(class296_0, string_0);
				}
				return new Class512(class296_0, string_0);
			}
		}

		// Token: 0x06002C7E RID: 11390
		// RVA: 0x00120B88 File Offset: 0x0011ED88
		public static Class512 Create(PlayModes playModes_0, Struct13 struct13_0, string string_0)
		{
			switch (playModes_0)
			{
			case PlayModes.Taiko:
				return new Class515(struct13_0, string_0);
			case PlayModes.CatchTheBeat:
				return new Class516(struct13_0, string_0);
			case PlayModes.OsuMania:
				return new Class514(struct13_0, string_0);
			default:
				return new Class512(struct13_0, string_0);
			}
		}

		// Token: 0x06002C7F RID: 11391
		// RVA: 0x00120BCC File Offset: 0x0011EDCC
		public static Class512 smethod_0(PlayModes playModes_0, string string_0, Class296 class296_0)
		{
			switch (playModes_0)
			{
			case PlayModes.Taiko:
				return new Class515(string_0, class296_0);
			case PlayModes.CatchTheBeat:
				return new Class516(string_0, class296_0);
			case PlayModes.OsuMania:
				return new Class514(string_0, class296_0);
			default:
				return new Class512(string_0, class296_0);
			}
		}
	}
}
