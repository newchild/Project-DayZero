using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000058 RID: 88
	internal sealed class ScanFilter : PathFilter
	{
		// Token: 0x1700005E RID: 94
		public string Name
		{
			// Token: 0x06000272 RID: 626
			// RVA: 0x000075DA File Offset: 0x000057DA
			get;
			// Token: 0x06000273 RID: 627
			// RVA: 0x000075E2 File Offset: 0x000057E2
			set;
		}

		// Token: 0x06000274 RID: 628
		// RVA: 0x0002EB08 File Offset: 0x0002CD08
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			ScanFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new ScanFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			return <ExecuteFilter>d__;
		}
	}
}
