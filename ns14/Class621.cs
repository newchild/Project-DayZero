using ns6;
using System;

namespace ns14
{
	// Token: 0x020004B0 RID: 1200
	internal static class Class621
	{
		// Token: 0x04001F90 RID: 8080
		internal static bool bool_0;

		// Token: 0x06002638 RID: 9784
		// RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		internal static void smethod_0(string string_0)
		{
			if (Class621.bool_0 && Class111.bool_6)
			{
				Class111.smethod_23(string_0);
				return;
			}
		}

		// Token: 0x06002639 RID: 9785
		// RVA: 0x0001DAD7 File Offset: 0x0001BCD7
		internal static void smethod_1(string string_0, string[] string_1)
		{
			Class621.smethod_0(string.Format(string_0, string_1));
		}
	}
}
