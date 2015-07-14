using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000094 RID: 148
	internal interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x06000491 RID: 1169
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}
}
