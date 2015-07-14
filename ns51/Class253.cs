using System;
using System.Net.Sockets;

namespace ns51
{
	// Token: 0x020002D3 RID: 723
	internal sealed class Class253 : IDisposable
	{
		// Token: 0x0400118E RID: 4494
		private Socket socket_0;

		// Token: 0x060016D0 RID: 5840
		// RVA: 0x000141EA File Offset: 0x000123EA
		public void Dispose()
		{
			((IDisposable)this.socket_0).Dispose();
		}
	}
}
