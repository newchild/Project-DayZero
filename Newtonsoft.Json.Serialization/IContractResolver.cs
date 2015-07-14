using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F7 RID: 247
	public interface IContractResolver
	{
		// Token: 0x06000A1A RID: 2586
		JsonContract ResolveContract(Type type);
	}
}
