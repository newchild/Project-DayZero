using ns3;
using ns8;
using osu_common.Bancho;
using System;

namespace ns25
{
	// Token: 0x02000650 RID: 1616
	internal sealed class Class855 : bSerializable
	{
		// Token: 0x04002D66 RID: 11622
		internal Class17 class17_0;

		// Token: 0x04002D67 RID: 11623
		internal DateTime dateTime_0;

		// Token: 0x060031C0 RID: 12736
		// RVA: 0x00024B70 File Offset: 0x00022D70
		public void ReadFromStream(Class32 class32_0)
		{
			this.class17_0 = new Class17(class32_0);
			this.dateTime_0 = class32_0.method_1();
		}

		// Token: 0x060031C1 RID: 12737
		// RVA: 0x00024B8A File Offset: 0x00022D8A
		public void WriteToStream(Class31 class31_0)
		{
			this.class17_0.WriteToStream(class31_0);
			class31_0.Write(this.dateTime_0);
		}
	}
}
