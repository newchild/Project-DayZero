using System;
using System.Net;
using System.Net.Sockets;

namespace ns30
{
	// Token: 0x0200022D RID: 557
	internal sealed class Class152 : Class151
	{
		// Token: 0x0600139E RID: 5022
		// RVA: 0x00064C18 File Offset: 0x00062E18
		public void method_29(IPAddress ipaddress_0, int int_3)
		{
			bool bool_ = base.method_17();
			base.method_18(false);
			base.method_22(SocketType.Stream, ProtocolType.Tcp);
			base.method_8().vmethod_0(ipaddress_0, int_3);
			if (base.method_7())
			{
				base.Close(false);
			}
			else
			{
				this.bool_0 = true;
				this.vmethod_0();
				base.method_8().vmethod_2();
			}
			base.method_18(bool_);
		}
	}
}
