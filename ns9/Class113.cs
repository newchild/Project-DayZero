using System;
using System.Collections.Generic;

namespace ns9
{
	// Token: 0x020001B8 RID: 440
	internal sealed class Class113 : IComparer<Interface8>
	{
		// Token: 0x04000BD7 RID: 3031
		public static readonly Class113 class113_0 = new Class113();

		// Token: 0x06000F51 RID: 3921
		// RVA: 0x0000F368 File Offset: 0x0000D568
		public int Compare(Interface8 x, Interface8 y)
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
				if (x.imethod_7() < y.imethod_7())
				{
					return -1;
				}
			}
			return 1;
		}
	}
}
