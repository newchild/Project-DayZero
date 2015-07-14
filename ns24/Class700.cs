using System;
using System.Collections.Generic;

namespace ns24
{
	// Token: 0x0200052F RID: 1327
	internal sealed class Class700 : IComparer<Class695>
	{
		// Token: 0x040023BF RID: 9151
		private Comparison<Class296> comparison_0;

		// Token: 0x06002B0A RID: 11018
		// RVA: 0x00020FE6 File Offset: 0x0001F1E6
		internal Class700(Comparison<Class296> comparison_1)
		{
			this.comparison_0 = comparison_1;
		}

		// Token: 0x06002B0B RID: 11019
		// RVA: 0x00020FF5 File Offset: 0x0001F1F5
		public int Compare(Class695 x, Class695 y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x.class296_0 == null)
			{
				return -1;
			}
			if (y.class296_0 == null)
			{
				return 1;
			}
			return this.comparison_0(x.class296_0, y.class296_0);
		}
	}
}
