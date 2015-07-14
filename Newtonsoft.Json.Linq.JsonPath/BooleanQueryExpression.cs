using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000055 RID: 85
	internal sealed class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x17000059 RID: 89
		public List<PathFilter> Path
		{
			// Token: 0x0600025E RID: 606
			// RVA: 0x00007538 File Offset: 0x00005738
			get;
			// Token: 0x0600025F RID: 607
			// RVA: 0x00007540 File Offset: 0x00005740
			set;
		}

		// Token: 0x1700005A RID: 90
		public JValue Value
		{
			// Token: 0x06000260 RID: 608
			// RVA: 0x00007549 File Offset: 0x00005749
			get;
			// Token: 0x06000261 RID: 609
			// RVA: 0x00007551 File Offset: 0x00005751
			set;
		}

		// Token: 0x06000262 RID: 610
		// RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		public override bool IsMatch(JToken t)
		{
			IEnumerable<JToken> enumerable = JPath.Evaluate(this.Path, t, false);
			foreach (JToken current in enumerable)
			{
				JValue jValue = current as JValue;
				switch (base.Operator)
				{
				case QueryOperator.Equals:
					if (jValue != null && jValue.Equals(this.Value))
					{
						bool result = true;
						return result;
					}
					break;
				case QueryOperator.NotEquals:
					if (jValue != null && !jValue.Equals(this.Value))
					{
						bool result = true;
						return result;
					}
					break;
				case QueryOperator.Exists:
				{
					bool result = true;
					return result;
				}
				case QueryOperator.LessThan:
					if (jValue != null && jValue.CompareTo(this.Value) < 0)
					{
						bool result = true;
						return result;
					}
					break;
				case QueryOperator.LessThanOrEquals:
					if (jValue != null && jValue.CompareTo(this.Value) <= 0)
					{
						bool result = true;
						return result;
					}
					break;
				case QueryOperator.GreaterThan:
					if (jValue != null && jValue.CompareTo(this.Value) > 0)
					{
						bool result = true;
						return result;
					}
					break;
				case QueryOperator.GreaterThanOrEquals:
					if (jValue != null && jValue.CompareTo(this.Value) >= 0)
					{
						bool result = true;
						return result;
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
			}
			return false;
		}
	}
}
