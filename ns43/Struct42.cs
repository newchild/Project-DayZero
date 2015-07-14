using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ns43
{
	// Token: 0x020002A4 RID: 676
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct Struct42 : IComparer<Struct41>
	{
		// Token: 0x060015F3 RID: 5619
		// RVA: 0x00013797 File Offset: 0x00011997
		public int Compare(Struct41 x, Struct41 y)
		{
			return x.int_0.CompareTo(y.int_0);
		}
	}
}
