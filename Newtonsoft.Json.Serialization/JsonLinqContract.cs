using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010F RID: 271
	public sealed class JsonLinqContract : JsonContract
	{
		// Token: 0x06000ACB RID: 2763
		// RVA: 0x0000C71B File Offset: 0x0000A91B
		public JsonLinqContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Linq;
		}
	}
}
