using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BA RID: 186
	public sealed class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		// Token: 0x06000678 RID: 1656
		// RVA: 0x00009B0D File Offset: 0x00007D0D
		public bool Equals(JToken x, JToken y)
		{
			return JToken.DeepEquals(x, y);
		}

		// Token: 0x06000679 RID: 1657
		// RVA: 0x00009B16 File Offset: 0x00007D16
		public int GetHashCode(JToken obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetDeepHashCode();
		}
	}
}
