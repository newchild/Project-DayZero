using ns24;
using ns55;
using ns56;
using ns57;
using ns58;
using osu.GameModes.Edit.AiMod;
using osu_common;
using System;

namespace ns65
{
	// Token: 0x0200036C RID: 876
	internal static class Class365
	{
		// Token: 0x06001A8F RID: 6799
		// RVA: 0x000825D0 File Offset: 0x000807D0
		internal static AiModRuleset smethod_0()
		{
			switch (Class466.Current.method_5())
			{
			case PlayModes.Taiko:
				return new Class285();
			case PlayModes.CatchTheBeat:
				return new Class284();
			case PlayModes.OsuMania:
				return new Class286();
			default:
				return new Class283();
			}
		}

		// Token: 0x06001A90 RID: 6800
		// RVA: 0x00082614 File Offset: 0x00080814
		internal static AiModRuleset smethod_1()
		{
			switch (Class466.Current.method_5())
			{
			case PlayModes.Taiko:
				return new Class293();
			case PlayModes.OsuMania:
				return new Class292();
			}
			return new Class291();
		}

		// Token: 0x06001A91 RID: 6801
		// RVA: 0x00082654 File Offset: 0x00080854
		internal static AiModRuleset smethod_2()
		{
			switch (Class466.Current.method_5())
			{
			case PlayModes.Taiko:
				return new Class290();
			case PlayModes.CatchTheBeat:
				return new Class288();
			case PlayModes.OsuMania:
				return new Class289();
			default:
				return new Class287();
			}
		}

		// Token: 0x06001A92 RID: 6802
		// RVA: 0x000165C1 File Offset: 0x000147C1
		internal static AiModRuleset smethod_3()
		{
			Class466.Current.method_5();
			return new Class295();
		}

		// Token: 0x06001A93 RID: 6803
		// RVA: 0x000165D3 File Offset: 0x000147D3
		internal static AiModRuleset smethod_4()
		{
			return new Class294();
		}
	}
}
