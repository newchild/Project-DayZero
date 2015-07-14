using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000092 RID: 146
	internal interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x170000A2 RID: 162
		TKey Key
		{
			// Token: 0x0600048D RID: 1165
			get;
		}
	}
}
