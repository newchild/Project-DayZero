using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000049 RID: 73
	internal sealed class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x17000048 RID: 72
		public List<int> Indexes
		{
			// Token: 0x06000207 RID: 519
			// RVA: 0x0000725C File Offset: 0x0000545C
			get;
			// Token: 0x06000208 RID: 520
			// RVA: 0x00007264 File Offset: 0x00005464
			set;
		}

		// Token: 0x06000209 RID: 521
		// RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			ArrayMultipleIndexFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new ArrayMultipleIndexFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__errorWhenNoMatch = errorWhenNoMatch;
			return <ExecuteFilter>d__;
		}
	}
}
