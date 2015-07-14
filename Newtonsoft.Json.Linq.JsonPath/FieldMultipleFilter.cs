using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200004F RID: 79
	internal sealed class FieldMultipleFilter : PathFilter
	{
		// Token: 0x17000053 RID: 83
		public List<string> Names
		{
			// Token: 0x06000235 RID: 565
			// RVA: 0x000073D6 File Offset: 0x000055D6
			get;
			// Token: 0x06000236 RID: 566
			// RVA: 0x000073DE File Offset: 0x000055DE
			set;
		}

		// Token: 0x06000237 RID: 567
		// RVA: 0x0002D488 File Offset: 0x0002B688
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			FieldMultipleFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new FieldMultipleFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__errorWhenNoMatch = errorWhenNoMatch;
			return <ExecuteFilter>d__;
		}
	}
}
