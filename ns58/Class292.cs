using ns24;
using ns26;
using ns55;
using ns8;
using ns89;
using osu.GameModes.Edit;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns58
{
	// Token: 0x02000369 RID: 873
	internal sealed class Class292 : Class291
	{
		// Token: 0x0400151A RID: 5402
		[CompilerGenerated]
		private static Predicate<Class340> predicate_0;

		// Token: 0x06001A83 RID: 6787
		// RVA: 0x0001656D File Offset: 0x0001476D
		internal Class292()
		{
		}

		// Token: 0x06001A84 RID: 6788
		// RVA: 0x00081ED0 File Offset: 0x000800D0
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class872 class872_ = Editor.editor_0.class872_0;
			if (class872_.list_0.Count > 0)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AITimingMania_NoManiaBreaktime)));
			}
			if (Class466.Current.method_24() < 2.5)
			{
				List<Class340> arg_6B_0 = Class331.smethod_14();
				if (Class292.predicate_0 == null)
				{
					Class292.predicate_0 = new Predicate<Class340>(Class292.smethod_0);
				}
				List<Class340> list = arg_6B_0.FindAll(Class292.predicate_0);
				if (list.Count > 0 && Class466.Current.int_16 / list.Count > 15000)
				{
					this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AITimingMania_TooManySpeedChanges)));
				}
			}
			base.RunAllRules(hitObjectManager);
		}

		// Token: 0x06001A85 RID: 6789
		// RVA: 0x00016575 File Offset: 0x00014775
		[CompilerGenerated]
		private static bool smethod_0(Class340 class340_0)
		{
			return class340_0.double_0 < 0.0 && class340_0.double_0 != -100.0;
		}
	}
}
