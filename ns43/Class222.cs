using ns48;
using System;

namespace ns43
{
	// Token: 0x020002AA RID: 682
	internal abstract class Class222
	{
		// Token: 0x04001106 RID: 4358
		private Enum35 enum35_0;

		// Token: 0x04001105 RID: 4357
		private EventHandler<EventArgs> eventHandler_0;

		// Token: 0x06001608 RID: 5640
		// RVA: 0x0001391C File Offset: 0x00011B1C
		public Enum35 vmethod_0()
		{
			return this.enum35_0;
		}

		// Token: 0x06001609 RID: 5641
		// RVA: 0x00013924 File Offset: 0x00011B24
		protected virtual void vmethod_1(Enum35 enum35_1)
		{
			this.enum35_0 = enum35_1;
			if (this.eventHandler_0 != null)
			{
				Class275.smethod_0<EventArgs>(this.eventHandler_0, this, EventArgs.Empty);
			}
		}

		// Token: 0x0600160A RID: 5642
		public abstract void vmethod_2();
	}
}
