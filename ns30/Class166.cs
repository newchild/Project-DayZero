using System;
using System.ComponentModel;

namespace ns30
{
	// Token: 0x02000210 RID: 528
	[TypeConverter(typeof(ExpandableObjectConverter))]
	internal sealed class Class166
	{
		// Token: 0x04000E4D RID: 3661
		private Enum18 enum18_0;

		// Token: 0x04000E4F RID: 3663
		private int int_0;

		// Token: 0x04000E4E RID: 3662
		private string string_0;

		// Token: 0x04000E50 RID: 3664
		private string string_1;

		// Token: 0x04000E51 RID: 3665
		private string string_2;

		// Token: 0x060012CD RID: 4813
		// RVA: 0x00011864 File Offset: 0x0000FA64
		public Class166()
		{
			this.Clear();
		}

		// Token: 0x060012D0 RID: 4816
		// RVA: 0x00011882 File Offset: 0x0000FA82
		public void Clear()
		{
			this.enum18_0 = Enum18.const_1;
			this.string_2 = string.Empty;
			this.string_0 = string.Empty;
			this.string_1 = string.Empty;
			this.int_0 = 8080;
		}

		// Token: 0x060012CE RID: 4814
		// RVA: 0x00011872 File Offset: 0x0000FA72
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060012CF RID: 4815
		// RVA: 0x0001187A File Offset: 0x0000FA7A
		public string method_1()
		{
			return this.string_1;
		}
	}
}
