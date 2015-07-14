using System;

namespace ns30
{
	// Token: 0x0200020E RID: 526
	internal class Exception2 : Exception
	{
		// Token: 0x04000E4B RID: 3659
		private int int_0;

		// Token: 0x060012C9 RID: 4809
		// RVA: 0x0001182A File Offset: 0x0000FA2A
		public Exception2(string string_0, int int_1) : base(string_0)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060012CA RID: 4810
		// RVA: 0x0001183A File Offset: 0x0000FA3A
		public Exception2(string string_0, int int_1, Exception exception_0) : base(string_0, exception_0)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060012CB RID: 4811
		// RVA: 0x0001184B File Offset: 0x0000FA4B
		public int method_0()
		{
			return this.int_0;
		}
	}
}
