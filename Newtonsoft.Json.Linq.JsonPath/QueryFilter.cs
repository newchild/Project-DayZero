using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000056 RID: 86
	internal sealed class QueryFilter : PathFilter
	{
		// Token: 0x1700005B RID: 91
		public QueryExpression Expression
		{
			// Token: 0x06000264 RID: 612
			// RVA: 0x00007562 File Offset: 0x00005762
			get;
			// Token: 0x06000265 RID: 613
			// RVA: 0x0000756A File Offset: 0x0000576A
			set;
		}

		// Token: 0x06000266 RID: 614
		// RVA: 0x0002E928 File Offset: 0x0002CB28
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			QueryFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new QueryFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			return <ExecuteFilter>d__;
		}
	}
}
