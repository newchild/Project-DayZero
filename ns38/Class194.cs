using System;

namespace ns38
{
	// Token: 0x02000253 RID: 595
	internal class Class194
	{
		// Token: 0x04000F58 RID: 3928
		private byte[] byte_0;

		// Token: 0x04000F59 RID: 3929
		private int int_0;

		// Token: 0x04000F5A RID: 3930
		private int int_1;

		// Token: 0x04000F5C RID: 3932
		private int int_2;

		// Token: 0x04000F5B RID: 3931
		private uint uint_0;

		// Token: 0x060014AD RID: 5293
		// RVA: 0x00012900 File Offset: 0x00010B00
		public Class194(int int_3)
		{
			this.byte_0 = new byte[int_3];
		}

		// Token: 0x060014B6 RID: 5302
		// RVA: 0x0006AF34 File Offset: 0x00069134
		public int Flush(byte[] byte_1, int int_3, int int_4)
		{
			if (this.int_2 >= 8)
			{
				this.byte_0[this.int_1++] = (byte)this.uint_0;
				this.uint_0 >>= 8;
				this.int_2 -= 8;
			}
			if (int_4 > this.int_1 - this.int_0)
			{
				int_4 = this.int_1 - this.int_0;
				Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				this.int_0 = 0;
				this.int_1 = 0;
			}
			else
			{
				Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				this.int_0 += int_4;
			}
			return int_4;
		}

		// Token: 0x060014AF RID: 5295
		// RVA: 0x0006ADA0 File Offset: 0x00068FA0
		public void method_0(int int_3)
		{
			this.byte_0[this.int_1++] = (byte)int_3;
			this.byte_0[this.int_1++] = (byte)(int_3 >> 8);
		}

		// Token: 0x060014B0 RID: 5296
		// RVA: 0x0001292B File Offset: 0x00010B2B
		public void method_1(byte[] byte_1, int int_3, int int_4)
		{
			Array.Copy(byte_1, int_3, this.byte_0, this.int_1, int_4);
			this.int_1 += int_4;
		}

		// Token: 0x060014B1 RID: 5297
		// RVA: 0x0001294F File Offset: 0x00010B4F
		public int method_2()
		{
			return this.int_2;
		}

		// Token: 0x060014B2 RID: 5298
		// RVA: 0x0006ADE4 File Offset: 0x00068FE4
		public void method_3()
		{
			if (this.int_2 > 0)
			{
				this.byte_0[this.int_1++] = (byte)this.uint_0;
				if (this.int_2 > 8)
				{
					this.byte_0[this.int_1++] = (byte)(this.uint_0 >> 8);
				}
			}
			this.uint_0 = 0u;
			this.int_2 = 0;
		}

		// Token: 0x060014B3 RID: 5299
		// RVA: 0x0006AE54 File Offset: 0x00069054
		public void method_4(int int_3, int int_4)
		{
			this.uint_0 |= (uint)((uint)int_3 << this.int_2);
			this.int_2 += int_4;
			if (this.int_2 >= 16)
			{
				this.byte_0[this.int_1++] = (byte)this.uint_0;
				this.byte_0[this.int_1++] = (byte)(this.uint_0 >> 8);
				this.uint_0 >>= 16;
				this.int_2 -= 16;
			}
		}

		// Token: 0x060014B4 RID: 5300
		// RVA: 0x0006AEF0 File Offset: 0x000690F0
		public void method_5(int int_3)
		{
			this.byte_0[this.int_1++] = (byte)(int_3 >> 8);
			this.byte_0[this.int_1++] = (byte)int_3;
		}

		// Token: 0x060014B5 RID: 5301
		// RVA: 0x00012957 File Offset: 0x00010B57
		public bool method_6()
		{
			return this.int_1 == 0;
		}

		// Token: 0x060014AE RID: 5294
		// RVA: 0x00012914 File Offset: 0x00010B14
		public void Reset()
		{
			this.int_2 = 0;
			this.int_1 = 0;
			this.int_0 = 0;
		}
	}
}
