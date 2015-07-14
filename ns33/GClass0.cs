using System;
using System.Runtime.InteropServices;

namespace ns33
{
	// Token: 0x020001E0 RID: 480
	[ComVisible(true), Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	public sealed class GClass0
	{
		// Token: 0x04000CF4 RID: 3316
		private long long_0;

		// Token: 0x04000CF3 RID: 3315
		private uint uint_0 = 4294967295u;

		// Token: 0x04000CF5 RID: 3317
		private static uint[] uint_1;

		// Token: 0x060010E5 RID: 4325
		// RVA: 0x000592CC File Offset: 0x000574CC
		static GClass0()
		{
			uint num = 3988292384u;
			GClass0.uint_1 = new uint[256];
			for (uint num2 = 0u; num2 < 256u; num2 += 1u)
			{
				uint num3 = num2;
				for (uint num4 = 8u; num4 > 0u; num4 -= 1u)
				{
					if ((num3 & 1u) == 1u)
					{
						num3 = (num3 >> 1 ^ num);
					}
					else
					{
						num3 >>= 1;
					}
				}
				GClass0.uint_1[(int)((UIntPtr)num2)] = num3;
			}
		}

		// Token: 0x060010E6 RID: 4326
		// RVA: 0x00059328 File Offset: 0x00057528
		public void method_0(byte[] byte_0, int int_0, int int_1)
		{
			if (byte_0 == null)
			{
				throw new GException0("The data buffer must not be null.");
			}
			for (int i = 0; i < int_1; i++)
			{
				int num = int_0 + i;
				this.uint_0 = (this.uint_0 >> 8 ^ GClass0.uint_1[(int)((IntPtr)((long)((ulong)((uint)byte_0[num] ^ (this.uint_0 & 255u)))))]);
			}
			this.long_0 += (long)int_1;
		}

		// Token: 0x060010E7 RID: 4327
		// RVA: 0x000104BB File Offset: 0x0000E6BB
		public int method_1()
		{
			return (int)(~(int)this.uint_0);
		}

		// Token: 0x060010E8 RID: 4328
		// RVA: 0x000104C4 File Offset: 0x0000E6C4
		public long method_2()
		{
			return this.long_0;
		}
	}
}
