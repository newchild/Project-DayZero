using System;

namespace ns8
{
	// Token: 0x02000194 RID: 404
	internal sealed class Class30
	{
		// Token: 0x04000706 RID: 1798
		private int int_0 = 32;

		// Token: 0x04000701 RID: 1793
		private uint uint_0;

		// Token: 0x04000702 RID: 1794
		private uint uint_1;

		// Token: 0x04000703 RID: 1795
		private uint uint_2;

		// Token: 0x04000704 RID: 1796
		private uint uint_3;

		// Token: 0x04000705 RID: 1797
		private uint uint_4;

		// Token: 0x06000E90 RID: 3728
		// RVA: 0x0000EE96 File Offset: 0x0000D096
		public Class30()
		{
			this.method_0(Environment.TickCount);
		}

		// Token: 0x06000E91 RID: 3729
		// RVA: 0x0000EEB1 File Offset: 0x0000D0B1
		public Class30(int int_1)
		{
			this.method_0(int_1);
		}

		// Token: 0x06000E92 RID: 3730
		// RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		public void method_0(int int_1)
		{
			this.uint_1 = (uint)int_1;
			this.uint_2 = 842502087u;
			this.uint_3 = 3579807591u;
			this.uint_0 = 273326509u;
			this.int_0 = 32;
		}

		// Token: 0x06000E93 RID: 3731
		// RVA: 0x0004F028 File Offset: 0x0004D228
		public uint method_1()
		{
			uint num = this.uint_1 ^ this.uint_1 << 11;
			this.uint_1 = this.uint_2;
			this.uint_2 = this.uint_3;
			this.uint_3 = this.uint_0;
			return this.uint_0 = (this.uint_0 ^ this.uint_0 >> 19 ^ (num ^ num >> 8));
		}

		// Token: 0x06000E94 RID: 3732
		// RVA: 0x0004F08C File Offset: 0x0004D28C
		public int method_2(int int_1, int int_2)
		{
			if (int_1 > int_2)
			{
				throw new ArgumentOutOfRangeException("upperBound", int_2, "upperBound must be >=lowerBound");
			}
			uint num = this.uint_1 ^ this.uint_1 << 11;
			this.uint_1 = this.uint_2;
			this.uint_2 = this.uint_3;
			this.uint_3 = this.uint_0;
			int num2 = int_2 - int_1;
			if (num2 < 0)
			{
				return int_1 + (int)(2.3283064365386963E-10 * (this.uint_0 = (this.uint_0 ^ this.uint_0 >> 19 ^ (num ^ num >> 8))) * (double)((long)int_2 - (long)int_1));
			}
			return int_1 + (int)(4.6566128730773926E-10 * (double)(2147483647u & (this.uint_0 = (this.uint_0 ^ this.uint_0 >> 19 ^ (num ^ num >> 8)))) * (double)num2);
		}

		// Token: 0x06000E95 RID: 3733
		// RVA: 0x0004F15C File Offset: 0x0004D35C
		public double method_3()
		{
			uint num = this.uint_1 ^ this.uint_1 << 11;
			this.uint_1 = this.uint_2;
			this.uint_2 = this.uint_3;
			this.uint_3 = this.uint_0;
			return 4.6566128730773926E-10 * (double)(2147483647u & (this.uint_0 = (this.uint_0 ^ this.uint_0 >> 19 ^ (num ^ num >> 8))));
		}

		// Token: 0x06000E96 RID: 3734
		// RVA: 0x0004F1D0 File Offset: 0x0004D3D0
		public void method_4(byte[] byte_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_2;
			uint num3 = this.uint_3;
			uint num4 = this.uint_0;
			int i = 0;
			while (i < byte_0.Length - 3)
			{
				uint num5 = num ^ num << 11;
				num = num2;
				num2 = num3;
				num3 = num4;
				num4 = (num4 ^ num4 >> 19 ^ (num5 ^ num5 >> 8));
				byte_0[i++] = (byte)(num4 & 255u);
				byte_0[i++] = (byte)((num4 & 65280u) >> 8);
				byte_0[i++] = (byte)((num4 & 16711680u) >> 16);
				byte_0[i++] = (byte)((num4 & 4278190080u) >> 24);
			}
			if (i < byte_0.Length)
			{
				uint num5 = num ^ num << 11;
				num = num2;
				num2 = num3;
				num3 = num4;
				num4 = (num4 ^ num4 >> 19 ^ (num5 ^ num5 >> 8));
				byte_0[i++] = (byte)(num4 & 255u);
				if (i < byte_0.Length)
				{
					byte_0[i++] = (byte)((num4 & 65280u) >> 8);
					if (i < byte_0.Length)
					{
						byte_0[i++] = (byte)((num4 & 16711680u) >> 16);
						if (i < byte_0.Length)
						{
							byte_0[i] = (byte)((num4 & 4278190080u) >> 24);
						}
					}
				}
			}
			this.uint_1 = num;
			this.uint_2 = num2;
			this.uint_3 = num3;
			this.uint_0 = num4;
		}

		// Token: 0x06000E97 RID: 3735
		// RVA: 0x0004F30C File Offset: 0x0004D50C
		public bool method_5()
		{
			if (this.int_0 == 32)
			{
				uint num = this.uint_1 ^ this.uint_1 << 11;
				this.uint_1 = this.uint_2;
				this.uint_2 = this.uint_3;
				this.uint_3 = this.uint_0;
				this.uint_4 = (this.uint_0 = (this.uint_0 ^ this.uint_0 >> 19 ^ (num ^ num >> 8)));
				this.int_0 = 1;
				return (this.uint_4 & 1u) == 1u;
			}
			this.int_0++;
			return ((this.uint_4 >>= 1) & 1u) == 1u;
		}
	}
}
