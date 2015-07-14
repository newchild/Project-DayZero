using System;
using System.Drawing;

namespace ns8
{
	// Token: 0x02000469 RID: 1129
	internal sealed class EventArgs12 : EventArgs
	{
		// Token: 0x04001E55 RID: 7765
		internal Enum52 enum52_0;

		// Token: 0x04001E56 RID: 7766
		internal readonly Point point_0;

		// Token: 0x0600248C RID: 9356
		// RVA: 0x0001CA1E File Offset: 0x0001AC1E
		internal EventArgs12(Enum52 enum52_1, Point point_1)
		{
			this.enum52_0 = enum52_1;
			this.point_0 = point_1;
		}
	}
}
