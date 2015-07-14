using System;
using System.Collections.Generic;

namespace ns8
{
	// Token: 0x0200018A RID: 394
	internal sealed class Class26<T> : List<T>
	{
		// Token: 0x040006F1 RID: 1777
		private IComparer<T> icomparer_0;

		// Token: 0x06000E51 RID: 3665
		// RVA: 0x0000ECAC File Offset: 0x0000CEAC
		public Class26()
		{
		}

		// Token: 0x06000E52 RID: 3666
		// RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		public Class26(List<T> list_0) : base(list_0)
		{
		}

		// Token: 0x06000E53 RID: 3667
		// RVA: 0x0000ECBD File Offset: 0x0000CEBD
		public Class26(int int_0) : base(int_0)
		{
		}

		// Token: 0x06000E54 RID: 3668
		// RVA: 0x0000ECC6 File Offset: 0x0000CEC6
		public Class26(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
		}

		// Token: 0x06000E55 RID: 3669
		// RVA: 0x0004E5EC File Offset: 0x0004C7EC
		public int method_0(T gparam_0)
		{
			int num = (this.icomparer_0 != null) ? base.BinarySearch(gparam_0, this.icomparer_0) : base.BinarySearch(gparam_0);
			if (num < 0)
			{
				num = ~num;
			}
			base.Insert(num, gparam_0);
			return num;
		}
	}
}
