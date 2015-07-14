using System;
using System.Net.Sockets;

namespace ns51
{
	// Token: 0x020002D5 RID: 725
	internal sealed class Class255 : IDisposable
	{
		// Token: 0x04001191 RID: 4497
		private Socket socket_0;

		// Token: 0x060016D5 RID: 5845
		// RVA: 0x00014223 File Offset: 0x00012423
		public void Dispose()
		{
			((IDisposable)this.socket_0).Dispose();
		}
	}
}
