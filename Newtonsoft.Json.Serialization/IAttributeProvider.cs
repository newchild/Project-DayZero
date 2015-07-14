using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200005E RID: 94
	public interface IAttributeProvider
	{
		// Token: 0x06000286 RID: 646
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x06000287 RID: 647
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
