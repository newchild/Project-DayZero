using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000110 RID: 272
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x170001DF RID: 479
		internal PrimitiveTypeCode TypeCode
		{
			// Token: 0x06000ACC RID: 2764
			// RVA: 0x0000C72B File Offset: 0x0000A92B
			get;
			// Token: 0x06000ACD RID: 2765
			// RVA: 0x0000C733 File Offset: 0x0000A933
			set;
		}

		// Token: 0x06000ACE RID: 2766
		// RVA: 0x0000C73C File Offset: 0x0000A93C
		public JsonPrimitiveContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Primitive;
			this.TypeCode = ConvertUtils.GetTypeCode(underlyingType);
			this.IsReadOnlyOrFixedSize = true;
		}
	}
}
