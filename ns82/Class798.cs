using ns29;
using ns90;
using System;

namespace ns82
{
	// Token: 0x020005FB RID: 1531
	internal static class Class798
	{
		// Token: 0x04002B22 RID: 11042
		private static bool bool_0;

		// Token: 0x04002B21 RID: 11041
		private static int int_0;

		// Token: 0x06002F70 RID: 12144
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal static void Check(int int_1)
		{
		}

		// Token: 0x06002F6D RID: 12141
		// RVA: 0x00023573 File Offset: 0x00021773
		internal static void Initialize()
		{
			Class802.smethod_34(Enum96.const_8, new Delegate46(Class798.smethod_0), Enum98.const_8, Enum97.const_2);
		}

		// Token: 0x06002F6E RID: 12142
		// RVA: 0x00023589 File Offset: 0x00021789
		private static bool smethod_0(object object_0, EventArgs eventArgs_0)
		{
			if (Class798.bool_0)
			{
				Class723.smethod_3();
				Class798.bool_0 = false;
			}
			Class798.int_0 = Class115.int_1;
			return false;
		}

		// Token: 0x06002F6F RID: 12143
		// RVA: 0x000235A8 File Offset: 0x000217A8
		internal static void smethod_1()
		{
			Class798.int_0 = Class115.int_1;
		}
	}
}
