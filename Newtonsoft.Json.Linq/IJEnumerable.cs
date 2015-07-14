using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000A5 RID: 165
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x170000AF RID: 175
		IJEnumerable<JToken> this[object key]
		{
			// Token: 0x060004E7 RID: 1255
			get;
		}
	}
}
