using System;

namespace ns33
{
	// Token: 0x020001DB RID: 475
	internal sealed class Class136
	{
		// Token: 0x04000CD6 RID: 3286
		private static int int_0 = 65521;

		// Token: 0x04000CD7 RID: 3287
		private static int int_1 = 5552;

		// Token: 0x060010E3 RID: 4323
		// RVA: 0x000590C8 File Offset: 0x000572C8
		internal static long smethod_0(long long_0, byte[] byte_0, int int_2, int int_3)
		{
			if (byte_0 == null)
			{
				return 1L;
			}
			long num = long_0 & 65535L;
			long num2 = long_0 >> 16 & 65535L;
			while (int_3 > 0)
			{
				int i = (int_3 < Class136.int_1) ? int_3 : Class136.int_1;
				int_3 -= i;
				while (i >= 16)
				{
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					num += (long)(byte_0[int_2++] & 255);
					num2 += num;
					i -= 16;
				}
				if (i != 0)
				{
					do
					{
						num += (long)(byte_0[int_2++] & 255);
						num2 += num;
					}
					while (--i != 0);
				}
				num %= (long)Class136.int_0;
				num2 %= (long)Class136.int_0;
			}
			return num2 << 16 | num;
		}
	}
}
