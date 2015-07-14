using ns24;
using System;

namespace ns10
{
	// Token: 0x02000663 RID: 1635
	internal sealed class Class865 : IComparable<Class865>
	{
		// Token: 0x04002EFE RID: 12030
		internal Class296 class296_0;

		// Token: 0x04002F01 RID: 12033
		internal double double_0;

		// Token: 0x04002EFF RID: 12031
		internal string string_0;

		// Token: 0x04002F00 RID: 12032
		internal string string_1;

		// Token: 0x060032D2 RID: 13010
		// RVA: 0x00005E0F File Offset: 0x0000400F
		internal Class865()
		{
		}

		// Token: 0x060032D4 RID: 13012
		// RVA: 0x00025931 File Offset: 0x00023B31
		public int CompareTo(Class865 obj)
		{
			return this.double_0.CompareTo(obj.double_0);
		}

		// Token: 0x060032D3 RID: 13011
		// RVA: 0x00025929 File Offset: 0x00023B29
		public override string ToString()
		{
			return this.string_1;
		}
	}
}
