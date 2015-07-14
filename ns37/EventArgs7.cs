using System;

namespace ns37
{
	// Token: 0x0200023D RID: 573
	internal class EventArgs7 : EventArgs
	{
		// Token: 0x04000F07 RID: 3847
		private bool bool_0 = true;

		// Token: 0x04000F06 RID: 3846
		private string string_0;

		// Token: 0x170002D7 RID: 727
		public string Name
		{
			// Token: 0x06001442 RID: 5186
			// RVA: 0x000125AC File Offset: 0x000107AC
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06001441 RID: 5185
		// RVA: 0x00012596 File Offset: 0x00010796
		public EventArgs7(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06001443 RID: 5187
		// RVA: 0x000125B4 File Offset: 0x000107B4
		public bool method_0()
		{
			return this.bool_0;
		}
	}
}
