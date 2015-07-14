using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200004B RID: 75
	internal sealed class ArraySliceFilter : PathFilter
	{
		// Token: 0x1700004C RID: 76
		public int? End
		{
			// Token: 0x06000217 RID: 535
			// RVA: 0x000072E3 File Offset: 0x000054E3
			get;
			// Token: 0x06000218 RID: 536
			// RVA: 0x000072EB File Offset: 0x000054EB
			set;
		}

		// Token: 0x1700004B RID: 75
		public int? Start
		{
			// Token: 0x06000215 RID: 533
			// RVA: 0x000072D2 File Offset: 0x000054D2
			get;
			// Token: 0x06000216 RID: 534
			// RVA: 0x000072DA File Offset: 0x000054DA
			set;
		}

		// Token: 0x1700004D RID: 77
		public int? Step
		{
			// Token: 0x06000219 RID: 537
			// RVA: 0x000072F4 File Offset: 0x000054F4
			get;
			// Token: 0x0600021A RID: 538
			// RVA: 0x000072FC File Offset: 0x000054FC
			set;
		}

		// Token: 0x0600021B RID: 539
		// RVA: 0x0002CCD4 File Offset: 0x0002AED4
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			ArraySliceFilter.<ExecuteFilter>d__0 <ExecuteFilter>d__ = new ArraySliceFilter.<ExecuteFilter>d__0(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__errorWhenNoMatch = errorWhenNoMatch;
			return <ExecuteFilter>d__;
		}

		// Token: 0x0600021C RID: 540
		// RVA: 0x00007305 File Offset: 0x00005505
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			if (positiveStep)
			{
				return index < stopIndex;
			}
			return index > stopIndex;
		}
	}
}
