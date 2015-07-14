using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200017C RID: 380
	internal struct Struct15 : bSerializable
	{
		// Token: 0x04000650 RID: 1616
		public readonly int int_0;

		// Token: 0x04000651 RID: 1617
		public readonly string string_0;

		// Token: 0x06000E2C RID: 3628
		// RVA: 0x0000EAF5 File Offset: 0x0000CCF5
		public Struct15(int int_1, string string_1)
		{
			this.int_0 = int_1;
			this.string_0 = string_1;
		}

		// Token: 0x06000E2D RID: 3629
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E2E RID: 3630
		// RVA: 0x0000EB05 File Offset: 0x0000CD05
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.int_0);
			class31_0.Write(this.string_0);
		}
	}
}
