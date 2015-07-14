using System;

namespace osu.GameModes.Edit.AiMod
{
	// Token: 0x020002FF RID: 767
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class AiModRulesetAttribute : Attribute
	{
		// Token: 0x17000316 RID: 790
		public string EntryType
		{
			// Token: 0x06001750 RID: 5968
			// RVA: 0x0001476D File Offset: 0x0001296D
			get;
			// Token: 0x06001751 RID: 5969
			// RVA: 0x00014775 File Offset: 0x00012975
			private set;
		}

		// Token: 0x17000315 RID: 789
		public string RulesetName
		{
			// Token: 0x0600174E RID: 5966
			// RVA: 0x0001475C File Offset: 0x0001295C
			get;
			// Token: 0x0600174F RID: 5967
			// RVA: 0x00014764 File Offset: 0x00012964
			private set;
		}

		// Token: 0x06001752 RID: 5970
		// RVA: 0x0001477E File Offset: 0x0001297E
		public AiModRulesetAttribute(string pluginName, string entryType)
		{
			this.RulesetName = pluginName;
			this.EntryType = entryType;
		}
	}
}
