using System;
using System.Collections.Generic;

namespace ns67
{
	// Token: 0x02000373 RID: 883
	internal sealed class Class367 : IComparable<Class367>, IComparer<Class367>
	{
		// Token: 0x04001532 RID: 5426
		internal bool bool_0 = true;

		// Token: 0x0400152F RID: 5423
		internal double double_0;

		// Token: 0x04001530 RID: 5424
		internal double double_1;

		// Token: 0x04001531 RID: 5425
		internal double double_2 = -1.0;

		// Token: 0x04001533 RID: 5427
		internal double double_3 = 1.0;

		// Token: 0x0400152E RID: 5422
		internal int int_0;

		// Token: 0x06001AA8 RID: 6824
		// RVA: 0x00016643 File Offset: 0x00014843
		internal Class367()
		{
		}

		// Token: 0x06001AAB RID: 6827
		// RVA: 0x00083388 File Offset: 0x00081588
		public Class367 Clone()
		{
			return new Class367
			{
				double_3 = this.double_3,
				double_2 = this.double_2,
				bool_0 = this.bool_0,
				double_0 = this.double_0,
				int_0 = this.int_0,
				double_1 = this.double_1
			};
		}

		// Token: 0x06001AA9 RID: 6825
		// RVA: 0x00016670 File Offset: 0x00014870
		public int Compare(Class367 x, Class367 y)
		{
			return y.CompareTo(x);
		}

		// Token: 0x06001AAA RID: 6826
		// RVA: 0x00083338 File Offset: 0x00081538
		public int CompareTo(Class367 obj)
		{
			if (obj.int_0 < this.int_0)
			{
				return 1;
			}
			if (obj.int_0 > this.int_0)
			{
				return -1;
			}
			if (obj.double_0 < this.double_0)
			{
				return 1;
			}
			if (obj.double_0 > this.double_0)
			{
				return -1;
			}
			return 0;
		}
	}
}
