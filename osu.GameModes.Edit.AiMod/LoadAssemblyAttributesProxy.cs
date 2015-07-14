using System;
using System.Reflection;

namespace osu.GameModes.Edit.AiMod
{
	// Token: 0x020002FE RID: 766
	public sealed class LoadAssemblyAttributesProxy : MarshalByRefObject
	{
		// Token: 0x0600174D RID: 5965
		// RVA: 0x0007308C File Offset: 0x0007128C
		public AiModRulesetAttribute[] LoadAssemblyAttributes(string assFile)
		{
			Assembly assembly = Assembly.LoadFrom(assFile);
			return assembly.GetCustomAttributes(typeof(AiModRulesetAttribute), false) as AiModRulesetAttribute[];
		}
	}
}
