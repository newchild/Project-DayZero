using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000093 RID: 147
	internal interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		// Token: 0x170000A3 RID: 163
		int Count
		{
			// Token: 0x0600048F RID: 1167
			get;
		}

		// Token: 0x170000A4 RID: 164
		IEnumerable<TElement> this[TKey key]
		{
			// Token: 0x06000490 RID: 1168
			get;
		}

		// Token: 0x0600048E RID: 1166
		bool Contains(TKey key);
	}
}
