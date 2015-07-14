using System;

namespace ns9
{
	// Token: 0x020001C9 RID: 457
	internal sealed class EventArgs1 : EventArgs
	{
		// Token: 0x04000C5D RID: 3165
		private Class123 class123_0;

		// Token: 0x0600100F RID: 4111
		// RVA: 0x0000FACD File Offset: 0x0000DCCD
		public EventArgs1(Class123 class123_1)
		{
			this.class123_0 = class123_1;
		}

		// Token: 0x06001010 RID: 4112
		// RVA: 0x0000FADC File Offset: 0x0000DCDC
		public Class123 method_0()
		{
			return this.class123_0;
		}
	}
}
