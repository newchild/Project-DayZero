using System;

namespace ns43
{
	// Token: 0x020002DA RID: 730
	internal sealed class Class260 : Class259
	{
		// Token: 0x020002DB RID: 731
		private sealed class Class263 : IComparable<Class260.Class263>
		{
			// Token: 0x04001197 RID: 4503
			public int int_0;

			// Token: 0x04001198 RID: 4504
			public int int_1;

			// Token: 0x04001199 RID: 4505
			public int int_2;

			// Token: 0x060016E1 RID: 5857
			// RVA: 0x00072958 File Offset: 0x00070B58
			public int CompareTo(Class260.Class263 obj)
			{
				int result;
				if ((result = this.int_0.CompareTo(obj.int_0)) != 0)
				{
					return result;
				}
				if ((result = this.int_1.CompareTo(obj.int_1)) != 0)
				{
					return result;
				}
				return this.int_2.CompareTo(obj.int_2);
			}
		}
	}
}
