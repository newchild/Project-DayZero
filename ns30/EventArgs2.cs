using System;
using System.IO;

namespace ns30
{
	// Token: 0x02000204 RID: 516
	internal sealed class EventArgs2 : EventArgs
	{
		// Token: 0x04000E07 RID: 3591
		private Class147 class147_0;

		// Token: 0x04000E08 RID: 3592
		private Stream stream_0;

		// Token: 0x0600121D RID: 4637
		// RVA: 0x00011030 File Offset: 0x0000F230
		public EventArgs2(Class147 class147_1)
		{
			this.class147_0 = class147_1;
			this.stream_0 = null;
		}

		// Token: 0x0600121E RID: 4638
		// RVA: 0x00011046 File Offset: 0x0000F246
		public Stream method_0()
		{
			return this.stream_0;
		}
	}
}
