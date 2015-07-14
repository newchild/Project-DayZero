using System;
using System.Collections;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200014D RID: 333
	internal interface IWrappedCollection : IEnumerable, IList, ICollection
	{
		// Token: 0x17000260 RID: 608
		object UnderlyingCollection
		{
			// Token: 0x06000CF7 RID: 3319
			get;
		}
	}
}
