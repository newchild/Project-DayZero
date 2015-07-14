using ns55;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using System;

namespace ns56
{
	// Token: 0x02000367 RID: 871
	internal sealed class Class288 : Class287
	{
		// Token: 0x17000360 RID: 864
		public override AiModType Type
		{
			// Token: 0x06001A7D RID: 6781
			// RVA: 0x000063AE File Offset: 0x000045AE
			get
			{
				return AiModType.Meta;
			}
		}

		// Token: 0x06001A7F RID: 6783
		// RVA: 0x00016564 File Offset: 0x00014764
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			base.method_1(false);
		}
	}
}
