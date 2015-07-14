using System;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000053 RID: 83
	internal abstract class QueryExpression
	{
		// Token: 0x17000057 RID: 87
		public QueryOperator Operator
		{
			// Token: 0x06000256 RID: 598
			// RVA: 0x00007503 File Offset: 0x00005703
			get;
			// Token: 0x06000257 RID: 599
			// RVA: 0x0000750B File Offset: 0x0000570B
			set;
		}

		// Token: 0x06000258 RID: 600
		public abstract bool IsMatch(JToken t);
	}
}
