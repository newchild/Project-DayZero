using ns7;
using System;

namespace ns4
{
	// Token: 0x02000187 RID: 391
	internal sealed class Class24
	{
		// Token: 0x040006E6 RID: 1766
		public bool bool_0;

		// Token: 0x040006E5 RID: 1765
		public Enum2 enum2_0;

		// Token: 0x040006E7 RID: 1767
		public int int_0;

		// Token: 0x040006E8 RID: 1768
		protected string string_0;

		// Token: 0x040006E9 RID: 1769
		public string string_1;

		// Token: 0x06000E49 RID: 3657
		// RVA: 0x0000EC19 File Offset: 0x0000CE19
		public string method_0()
		{
			return this.string_1 + "!cho@ppy.sh";
		}

		// Token: 0x06000E4B RID: 3659
		// RVA: 0x0000EC33 File Offset: 0x0000CE33
		public string method_1()
		{
			if (this.bool_0)
			{
				return "@";
			}
			if (this.enum2_0 == Enum2.const_1)
			{
				return "+";
			}
			return string.Empty;
		}

		// Token: 0x06000E4C RID: 3660
		// RVA: 0x0000EC57 File Offset: 0x0000CE57
		public override string ToString()
		{
			return this.vmethod_0();
		}

		// Token: 0x06000E4A RID: 3658
		// RVA: 0x0000EC2B File Offset: 0x0000CE2B
		public virtual string vmethod_0()
		{
			return this.string_0;
		}
	}
}
