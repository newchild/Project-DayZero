using System;
using System.Collections;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000150 RID: 336
	internal interface IWrappedDictionary : IEnumerable, ICollection, IDictionary
	{
		// Token: 0x17000268 RID: 616
		object UnderlyingDictionary
		{
			// Token: 0x06000D29 RID: 3369
			get;
		}
	}
}
