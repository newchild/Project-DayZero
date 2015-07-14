using ns26;
using ns55;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns57
{
	// Token: 0x02000371 RID: 881
	internal sealed class Class293 : Class291
	{
		// Token: 0x04001520 RID: 5408
		[CompilerGenerated]
		private static Predicate<Class340> predicate_0;

		// Token: 0x06001AA2 RID: 6818
		// RVA: 0x0001656D File Offset: 0x0001476D
		internal Class293()
		{
		}

		// Token: 0x06001AA3 RID: 6819
		// RVA: 0x00082D98 File Offset: 0x00080F98
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			List<Class340> arg_22_0 = Class331.smethod_14();
			if (Class293.predicate_0 == null)
			{
				Class293.predicate_0 = new Predicate<Class340>(Class293.smethod_0);
			}
			List<Class340> list = arg_22_0.FindAll(Class293.predicate_0);
			for (int i = 0; i < list.Count; i++)
			{
				if (i < list.Count - 1 && list[i + 1].double_1 - list[i].double_1 < Class331.smethod_22(list[i].double_1, false) * 4.0)
				{
					this.Reports.Add(new AiReport(Severity.Error, Class41.GetString(OsuString.AITimingTaiko_KiaiToggledTooOften)));
				}
			}
			base.RunAllRules(hitObjectManager);
		}

		// Token: 0x06001AA4 RID: 6820
		// RVA: 0x0001663B File Offset: 0x0001483B
		[CompilerGenerated]
		private static bool smethod_0(Class340 class340_0)
		{
			return class340_0.method_2();
		}
	}
}
