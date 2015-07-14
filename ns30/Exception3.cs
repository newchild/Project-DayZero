using System;

namespace ns30
{
	// Token: 0x0200020F RID: 527
	internal sealed class Exception3 : Exception2
	{
		// Token: 0x04000E4C RID: 3660
		private string[] string_0;

		// Token: 0x060012CC RID: 4812
		// RVA: 0x00011853 File Offset: 0x0000FA53
		public Exception3(string string_1, int int_1, string[] string_2) : base(string_1, int_1)
		{
			this.string_0 = string_2;
		}
	}
}
