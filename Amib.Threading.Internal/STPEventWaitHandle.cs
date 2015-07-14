using System;
using System.Threading;

namespace Amib.Threading.Internal
{
	// Token: 0x02000329 RID: 809
	internal static class STPEventWaitHandle
	{
		// Token: 0x06001806 RID: 6150
		// RVA: 0x00014BB0 File Offset: 0x00012DB0
		internal static int WaitAny(WaitHandle[] waitHandle_0, int int_0, bool bool_0)
		{
			return WaitHandle.WaitAny(waitHandle_0, int_0);
		}
	}
}
