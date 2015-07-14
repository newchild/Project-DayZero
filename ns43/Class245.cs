using System;
using System.Net.Sockets;

namespace ns43
{
	// Token: 0x020002CB RID: 715
	internal sealed class Class245 : IDisposable
	{
		// Token: 0x04001176 RID: 4470
		private UdpClient udpClient_0;

		// Token: 0x060016B9 RID: 5817
		// RVA: 0x000140C7 File Offset: 0x000122C7
		public void Dispose()
		{
			this.udpClient_0.Close();
		}
	}
}
