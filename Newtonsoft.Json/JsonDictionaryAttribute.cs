using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200003F RID: 63
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonDictionaryAttribute : JsonContainerAttribute
	{
		// Token: 0x060001CE RID: 462
		// RVA: 0x00006F82 File Offset: 0x00005182
		public JsonDictionaryAttribute()
		{
		}

		// Token: 0x060001CF RID: 463
		// RVA: 0x00006F8A File Offset: 0x0000518A
		public JsonDictionaryAttribute(string id) : base(id)
		{
		}
	}
}
