using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000047 RID: 71
	internal sealed class ArrayIndexFilter : PathFilter
	{
		// Token: 0x17000045 RID: 69
		public int? Index
		{
			// Token: 0x060001F9 RID: 505
			// RVA: 0x000071D5 File Offset: 0x000053D5
			get;
			// Token: 0x060001FA RID: 506
			// RVA: 0x000071DD File Offset: 0x000053DD
			set;
		}

		// Token: 0x060001FB RID: 507
		// RVA: 0x0002C804 File Offset: 0x0002AA04
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			ArrayIndexFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new ArrayIndexFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__errorWhenNoMatch = errorWhenNoMatch;
			return <ExecuteFilter>d__;
		}
	}
}
