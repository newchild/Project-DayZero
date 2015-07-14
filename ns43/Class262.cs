using System;
using System.Collections.Generic;

namespace ns43
{
	// Token: 0x020002DF RID: 735
	internal sealed class Class262 : Class259
	{
		// Token: 0x020002E0 RID: 736
		private struct Struct45 : IComparer<Class258>
		{
			// Token: 0x0400119D RID: 4509
			private int int_0;

			// Token: 0x060016F3 RID: 5875
			// RVA: 0x00072A34 File Offset: 0x00070C34
			public int Compare(Class258 x, Class258 y)
			{
				if (x == null)
				{
					return this.int_0.CompareTo(y.Index);
				}
				return x.Index.CompareTo(this.int_0);
			}
		}
	}
}
