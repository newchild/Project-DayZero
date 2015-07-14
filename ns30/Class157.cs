using System;

namespace ns30
{
	// Token: 0x02000206 RID: 518
	internal sealed class Class157
	{
		// Token: 0x04000E09 RID: 3593
		private string string_0;

		// Token: 0x04000E0A RID: 3594
		private string string_1;

		// Token: 0x170002B3 RID: 691
		public string Name
		{
			// Token: 0x06001224 RID: 4644
			// RVA: 0x00011064 File Offset: 0x0000F264
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x170002B4 RID: 692
		public string Value
		{
			// Token: 0x06001225 RID: 4645
			// RVA: 0x0001106C File Offset: 0x0000F26C
			get
			{
				return this.string_1;
			}
		}

		// Token: 0x06001223 RID: 4643
		// RVA: 0x0001104E File Offset: 0x0000F24E
		public Class157(string string_2, string string_3)
		{
			this.string_0 = string_2;
			this.string_1 = string_3;
		}
	}
}
