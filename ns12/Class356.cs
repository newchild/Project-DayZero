using osu.GameModes.Edit.AiMod;
using System;
using System.Collections.Generic;
using System.IO;

namespace ns12
{
	// Token: 0x0200035C RID: 860
	internal sealed class Class356 : IDisposable
	{
		// Token: 0x04001504 RID: 5380
		private Dictionary<AiModRulesetAttribute, AppDomain> dictionary_0 = new Dictionary<AiModRulesetAttribute, AppDomain>();

		// Token: 0x04001503 RID: 5379
		internal List<AiModRuleset> list_0 = new List<AiModRuleset>();

		// Token: 0x06001A58 RID: 6744
		// RVA: 0x00016412 File Offset: 0x00014612
		public Class356()
		{
			this.method_0();
		}

		// Token: 0x06001A5D RID: 6749
		// RVA: 0x00016436 File Offset: 0x00014636
		public void Dispose()
		{
			this.method_1();
		}

		// Token: 0x06001A59 RID: 6745
		// RVA: 0x00080D88 File Offset: 0x0007EF88
		internal void method_0()
		{
			this.method_1();
			AppDomain appDomain = AppDomain.CreateDomain("AiModPluginInterface", AppDomain.CurrentDomain.Evidence, new AppDomainSetup
			{
				ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
				PrivateBinPath = "Plugins/AiMod",
				DisallowCodeDownload = true,
				ApplicationName = "AiModPluginInterface"
			});
			if (Directory.Exists("Plugins/AiMod"))
			{
				string[] files = Directory.GetFiles("Plugins/AiMod", "*.dll");
				for (int i = 0; i < files.Length; i++)
				{
					string assFile = files[i];
					LoadAssemblyAttributesProxy loadAssemblyAttributesProxy = appDomain.CreateInstanceAndUnwrap("osu!framework", typeof(LoadAssemblyAttributesProxy).FullName) as LoadAssemblyAttributesProxy;
					AiModRulesetAttribute[] array = loadAssemblyAttributesProxy.LoadAssemblyAttributes(assFile);
					if (array.Length > 0)
					{
						this.list_0.Add(this.method_3(array[0]));
					}
				}
			}
			AppDomain.Unload(appDomain);
		}

		// Token: 0x06001A5A RID: 6746
		// RVA: 0x00080E70 File Offset: 0x0007F070
		internal void method_1()
		{
			if (this.dictionary_0 != null)
			{
				foreach (AppDomain current in this.dictionary_0.Values)
				{
					AppDomain.Unload(current);
				}
				this.dictionary_0.Clear();
			}
		}

		// Token: 0x06001A5B RID: 6747
		// RVA: 0x00080EDC File Offset: 0x0007F0DC
		private AppDomain method_2(AiModRulesetAttribute aiModRulesetAttribute_0)
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup
			{
				ApplicationName = aiModRulesetAttribute_0.RulesetName,
				ConfigurationFile = aiModRulesetAttribute_0.RulesetName + ".dll.config",
				ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
				DisallowCodeDownload = true,
				PrivateBinPath = "Plugins/AiMod"
			};
			return AppDomain.CreateDomain(appDomainSetup.ApplicationName, AppDomain.CurrentDomain.Evidence, appDomainSetup);
		}

		// Token: 0x06001A5C RID: 6748
		// RVA: 0x00080F50 File Offset: 0x0007F150
		private AiModRuleset method_3(AiModRulesetAttribute aiModRulesetAttribute_0)
		{
			AppDomain appDomain;
			if (!this.dictionary_0.TryGetValue(aiModRulesetAttribute_0, out appDomain))
			{
				appDomain = this.method_2(aiModRulesetAttribute_0);
				this.dictionary_0[aiModRulesetAttribute_0] = appDomain;
			}
			return (AiModRuleset)appDomain.CreateInstanceAndUnwrap(aiModRulesetAttribute_0.RulesetName, aiModRulesetAttribute_0.EntryType);
		}
	}
}
