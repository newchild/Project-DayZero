using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FF RID: 255
	internal sealed class DefaultContractResolverState
	{
		// Token: 0x0400043A RID: 1082
		public Dictionary<ResolverContractKey, JsonContract> ContractCache;

		// Token: 0x0400043B RID: 1083
		public PropertyNameTable NameTable = new PropertyNameTable();
	}
}
