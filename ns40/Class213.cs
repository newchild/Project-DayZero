using osu_common;
using System;
using System.Globalization;

namespace ns40
{
	// Token: 0x02000275 RID: 629
	internal static class Class213
	{
		// Token: 0x0400101C RID: 4124
		public static bool bool_0 = false;

		// Token: 0x0400101B RID: 4123
		public static int int_0 = 0;

		// Token: 0x0400101A RID: 4122
		public static NumberFormatInfo numberFormatInfo_0 = new CultureInfo("en-US", false).NumberFormat;

		// Token: 0x060015C7 RID: 5575
		// RVA: 0x0006FAD0 File Offset: 0x0006DCD0
		public static string smethod_0(PlayModes playModes_0)
		{
			switch (playModes_0)
			{
			case PlayModes.Osu:
				IL_18:
				return "osu!";
			case PlayModes.Taiko:
				return "Taiko";
			case PlayModes.CatchTheBeat:
				return "Catch the Beat";
			case PlayModes.OsuMania:
				return "osu!mania";
			}
			goto IL_18;
		}
	}
}
