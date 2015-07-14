using osu.GameplayElements;
using System;
using System.Collections.Generic;

namespace osu.GameModes.Edit.AiMod
{
	// Token: 0x020002FB RID: 763
	public abstract class AiModRuleset : MarshalByRefObject
	{
		// Token: 0x040011FB RID: 4603
		public List<AiReport> Reports;

		// Token: 0x17000314 RID: 788
		public abstract AiModType Type
		{
			// Token: 0x06001748 RID: 5960
			get;
		}

		// Token: 0x06001749 RID: 5961
		// RVA: 0x00014727 File Offset: 0x00012927
		public AiModRuleset()
		{
			this.Reports = new List<AiReport>();
		}

		// Token: 0x0600174A RID: 5962
		// RVA: 0x0001473A File Offset: 0x0001293A
		public List<AiReport> Run(HitObjectManagerBase hitObjectManager)
		{
			this.Reports.Clear();
			this.RunAllRules(hitObjectManager);
			return this.Reports;
		}

		// Token: 0x0600174B RID: 5963
		protected abstract void RunAllRules(HitObjectManagerBase hitObjectManager);
	}
}
