using System;

namespace ns23
{
	// Token: 0x02000541 RID: 1345
	internal sealed class Exception10 : Exception
	{
		// Token: 0x0400245D RID: 9309
		internal readonly Exception exception_0;

		// Token: 0x0400245C RID: 9308
		internal readonly int int_0;

		// Token: 0x06002B94 RID: 11156
		// RVA: 0x00021515 File Offset: 0x0001F715
		public Exception10(int int_1, Exception exception_1)
		{
			this.int_0 = int_1;
			this.exception_0 = exception_1;
		}
	}
}
