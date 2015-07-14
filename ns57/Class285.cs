using ns55;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using System;

namespace ns57
{
	// Token: 0x0200036F RID: 879
	internal sealed class Class285 : Class283
	{
		// Token: 0x17000364 RID: 868
		public override AiModType Type
		{
			// Token: 0x06001A9D RID: 6813
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return AiModType.Compose;
			}
		}

		// Token: 0x06001A9F RID: 6815
		// RVA: 0x0001653C File Offset: 0x0001473C
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			base.method_0(hitObjectManager);
		}
	}
}
