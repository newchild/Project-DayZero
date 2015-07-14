using System;
using System.Collections.Generic;

namespace ns9
{
	// Token: 0x020001CB RID: 459
	internal sealed class Class128 : IComparer<Interface7>
	{
		// Token: 0x04000C60 RID: 3168
		public static readonly Class128 class128_0 = new Class128();

		// Token: 0x0600103C RID: 4156
		// RVA: 0x0000FE80 File Offset: 0x0000E080
		public int Compare(Interface7 x, Interface7 y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x != null)
			{
				if (y == null)
				{
					return -1;
				}
				if (x.Equals(y))
				{
					return 0;
				}
				if (x.imethod_4() < y.imethod_4())
				{
					return -1;
				}
			}
			return 1;
		}
	}
}
