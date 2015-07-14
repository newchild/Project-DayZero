using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000054 RID: 84
	internal sealed class CompositeExpression : QueryExpression
	{
		// Token: 0x17000058 RID: 88
		public List<QueryExpression> Expressions
		{
			// Token: 0x0600025A RID: 602
			// RVA: 0x00007514 File Offset: 0x00005714
			get;
			// Token: 0x0600025B RID: 603
			// RVA: 0x0000751C File Offset: 0x0000571C
			set;
		}

		// Token: 0x0600025C RID: 604
		// RVA: 0x00007525 File Offset: 0x00005725
		public CompositeExpression()
		{
			this.Expressions = new List<QueryExpression>();
		}

		// Token: 0x0600025D RID: 605
		// RVA: 0x0002E730 File Offset: 0x0002C930
		public override bool IsMatch(JToken t)
		{
			bool result;
			switch (base.Operator)
			{
			case QueryOperator.And:
				foreach (QueryExpression current in this.Expressions)
				{
					if (!current.IsMatch(t))
					{
						result = false;
						return result;
					}
				}
				return true;
			case QueryOperator.Or:
				foreach (QueryExpression current2 in this.Expressions)
				{
					if (current2.IsMatch(t))
					{
						result = true;
						return result;
					}
				}
				return false;
			default:
				throw new ArgumentOutOfRangeException();
			}
			return result;
		}
	}
}
