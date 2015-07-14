using System;

namespace ns9
{
	// Token: 0x020001BC RID: 444
	internal sealed class EventArgs0 : EventArgs
	{
		// Token: 0x04000BF9 RID: 3065
		private Interface6 interface6_0;

		// Token: 0x06000F90 RID: 3984
		// RVA: 0x0000F5C2 File Offset: 0x0000D7C2
		public EventArgs0(Interface6 interface6_1)
		{
			this.interface6_0 = interface6_1;
		}

		// Token: 0x06000F91 RID: 3985
		// RVA: 0x0000F5D1 File Offset: 0x0000D7D1
		public Interface6 method_0()
		{
			return this.interface6_0;
		}
	}
}
