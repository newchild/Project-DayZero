using ns48;
using System;
using System.Net;
using System.Net.Sockets;

namespace ns43
{
	// Token: 0x020002B9 RID: 697
	internal sealed class Class223 : Class222
	{
		// Token: 0x04001143 RID: 4419
		private static readonly IPAddress ipaddress_0 = IPAddress.Parse("239.192.152.143");

		// Token: 0x04001144 RID: 4420
		private UdpClient udpClient_0;

		// Token: 0x06001684 RID: 5764
		// RVA: 0x00072120 File Offset: 0x00070320
		public override void vmethod_2()
		{
			if (base.vmethod_0() == Enum35.const_2)
			{
				return;
			}
			this.vmethod_1(Enum35.const_2);
			UdpClient udpClient = this.udpClient_0;
			this.udpClient_0 = null;
			if (udpClient != null)
			{
				udpClient.Close();
			}
		}
	}
}
