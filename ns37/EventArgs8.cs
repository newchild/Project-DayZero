using System;

namespace ns37
{
	// Token: 0x0200023F RID: 575
	internal sealed class EventArgs8 : EventArgs7
	{
		// Token: 0x04000F0C RID: 3852
		private bool bool_1;

		// Token: 0x06001446 RID: 5190
		// RVA: 0x000125E8 File Offset: 0x000107E8
		public EventArgs8(string string_1, bool bool_2) : base(string_1)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x06001447 RID: 5191
		// RVA: 0x000125F8 File Offset: 0x000107F8
		public bool method_1()
		{
			return this.bool_1;
		}
	}
}
