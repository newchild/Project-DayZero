using System;

namespace ns30
{
	// Token: 0x02000211 RID: 529
	internal sealed class EventArgs3 : EventArgs
	{
		// Token: 0x04000E52 RID: 3666
		private bool bool_0;

		// Token: 0x04000E53 RID: 3667
		private bool bool_1;

		// Token: 0x04000E56 RID: 3670
		private Class165 class165_0;

		// Token: 0x04000E58 RID: 3672
		private int int_0;

		// Token: 0x04000E54 RID: 3668
		private string string_0;

		// Token: 0x04000E55 RID: 3669
		private string[] string_1;

		// Token: 0x04000E57 RID: 3671
		private string[] string_2;

		// Token: 0x170002C0 RID: 704
		public bool Handled
		{
			// Token: 0x060012D3 RID: 4819
			// RVA: 0x000118FC File Offset: 0x0000FAFC
			get
			{
				return this.bool_1;
			}
		}

		// Token: 0x060012D1 RID: 4817
		// RVA: 0x000118B7 File Offset: 0x0000FAB7
		public EventArgs3(string[] string_3, int int_1, Class165 class165_1, string[] string_4, string string_5, bool bool_2, bool bool_3)
		{
			this.string_1 = string_3;
			this.int_0 = int_1;
			this.class165_0 = class165_1;
			this.string_2 = string_4;
			this.string_0 = string_5;
			this.bool_0 = bool_2;
			this.bool_1 = bool_3;
		}

		// Token: 0x060012D2 RID: 4818
		// RVA: 0x000118F4 File Offset: 0x0000FAF4
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060012D4 RID: 4820
		// RVA: 0x00011904 File Offset: 0x0000FB04
		public string method_1()
		{
			return this.string_0;
		}
	}
}
