using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010E RID: 270
	public sealed class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x170001DE RID: 478
		public ObjectConstructor<object> ISerializableCreator
		{
			// Token: 0x06000AC8 RID: 2760
			// RVA: 0x0000C6FA File Offset: 0x0000A8FA
			get;
			// Token: 0x06000AC9 RID: 2761
			// RVA: 0x0000C702 File Offset: 0x0000A902
			set;
		}

		// Token: 0x06000ACA RID: 2762
		// RVA: 0x0000C70B File Offset: 0x0000A90B
		public JsonISerializableContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Serializable;
		}
	}
}
