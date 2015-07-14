using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000126 RID: 294
	public sealed class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x06000C4C RID: 3148
		// RVA: 0x0000D625 File Offset: 0x0000B825
		public JsonStringContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.String;
		}
	}
}
