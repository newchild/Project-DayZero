using System;
using System.Net.Sockets;
using System.Threading;

namespace ns30
{
	// Token: 0x020001F4 RID: 500
	internal sealed class Class146
	{
		// Token: 0x04000DCD RID: 3533
		public AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);

		// Token: 0x04000DCA RID: 3530
		public Exception exception_0;

		// Token: 0x04000DCB RID: 3531
		public int int_0;

		// Token: 0x04000DCC RID: 3532
		public Socket socket_0;

		// Token: 0x0600117F RID: 4479
		// RVA: 0x00010ABF File Offset: 0x0000ECBF
		public Class146(Socket socket_1)
		{
			this.socket_0 = socket_1;
		}
	}
}
