using System;

namespace ns37
{
	// Token: 0x0200023E RID: 574
	internal sealed class EventArgs9 : EventArgs
	{
		// Token: 0x04000F0B RID: 3851
		private bool bool_0 = true;

		// Token: 0x04000F09 RID: 3849
		private long long_0;

		// Token: 0x04000F0A RID: 3850
		private long long_1;

		// Token: 0x04000F08 RID: 3848
		private string string_0;

		// Token: 0x06001444 RID: 5188
		// RVA: 0x000125BC File Offset: 0x000107BC
		public EventArgs9(string string_1, long long_2, long long_3)
		{
			this.string_0 = string_1;
			this.long_0 = long_2;
			this.long_1 = long_3;
		}

		// Token: 0x06001445 RID: 5189
		// RVA: 0x000125E0 File Offset: 0x000107E0
		public bool method_0()
		{
			return this.bool_0;
		}
	}
}
