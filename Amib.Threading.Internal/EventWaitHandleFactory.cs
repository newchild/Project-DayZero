using System;
using System.Threading;

namespace Amib.Threading.Internal
{
	// Token: 0x02000318 RID: 792
	public static class EventWaitHandleFactory
	{
		// Token: 0x060017AD RID: 6061
		// RVA: 0x00073A50 File Offset: 0x00071C50
		public static AutoResetEvent CreateAutoResetEvent()
		{
			return new AutoResetEvent(false);
		}

		// Token: 0x060017AE RID: 6062
		// RVA: 0x00073A68 File Offset: 0x00071C68
		public static ManualResetEvent CreateManualResetEvent(bool bool_0)
		{
			return new ManualResetEvent(bool_0);
		}
	}
}
