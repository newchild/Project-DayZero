using ns55;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using System;

namespace ns56
{
	// Token: 0x02000365 RID: 869
	internal sealed class Class284 : Class283
	{
		// Token: 0x1700035E RID: 862
		public override AiModType Type
		{
			// Token: 0x06001A74 RID: 6772
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return AiModType.Compose;
			}
		}

		// Token: 0x06001A76 RID: 6774
		// RVA: 0x0001653C File Offset: 0x0001473C
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			base.method_0(hitObjectManager);
		}
	}
}
