using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200004D RID: 77
	internal sealed class FieldFilter : PathFilter
	{
		// Token: 0x17000050 RID: 80
		public string Name
		{
			// Token: 0x06000227 RID: 551
			// RVA: 0x0000735E File Offset: 0x0000555E
			get;
			// Token: 0x06000228 RID: 552
			// RVA: 0x00007366 File Offset: 0x00005566
			set;
		}

		// Token: 0x06000229 RID: 553
		// RVA: 0x0002D190 File Offset: 0x0002B390
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			FieldFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new FieldFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__errorWhenNoMatch = errorWhenNoMatch;
			return <ExecuteFilter>d__;
		}
	}
}
