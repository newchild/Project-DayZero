using osu_common.Helpers;
using System;

namespace ns14
{
	// Token: 0x020001A9 RID: 425
	internal struct Struct17 : IComparable<Struct17>
	{
		// Token: 0x04000BBD RID: 3005
		public int int_0;

		// Token: 0x04000BBC RID: 3004
		public long long_0;

		// Token: 0x04000BBB RID: 3003
		public VoidDelegate voidDelegate_0;

		// Token: 0x06000EF4 RID: 3828
		// RVA: 0x0000F126 File Offset: 0x0000D326
		public Struct17(VoidDelegate voidDelegate_1, long long_1, int int_1)
		{
			this.voidDelegate_0 = voidDelegate_1;
			this.long_0 = long_1;
			this.int_0 = int_1;
		}

		// Token: 0x06000EF5 RID: 3829
		// RVA: 0x0000F13D File Offset: 0x0000D33D
		public int CompareTo(Struct17 obj)
		{
			if (this.long_0 != obj.long_0)
			{
				return this.long_0.CompareTo(obj.long_0);
			}
			return -1;
		}
	}
}
