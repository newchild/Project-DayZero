using System;

namespace ns39
{
	// Token: 0x0200025C RID: 604
	internal sealed class Class201
	{
		// Token: 0x04000F98 RID: 3992
		private byte[] byte_0;

		// Token: 0x04000F99 RID: 3993
		private int int_0;

		// Token: 0x04000F9A RID: 3994
		private int int_1;

		// Token: 0x04000F9C RID: 3996
		private int int_2;

		// Token: 0x04000F9B RID: 3995
		private uint uint_0;

		// Token: 0x06001505 RID: 5381
		// RVA: 0x0006C48C File Offset: 0x0006A68C
		public int method_0(int int_3)
		{
			if (this.int_2 < int_3)
			{
				if (this.int_0 == this.int_1)
				{
					return -1;
				}
				this.uint_0 |= (uint)((uint)((int)(this.byte_0[this.int_0++] & 255) | (int)(this.byte_0[this.int_0++] & 255) << 8) << this.int_2);
				this.int_2 += 16;
			}
			return (int)((ulong)this.uint_0 & (ulong)((long)((1 << int_3) - 1)));
		}

		// Token: 0x06001506 RID: 5382
		// RVA: 0x00012CA2 File Offset: 0x00010EA2
		public void method_1(int int_3)
		{
			this.uint_0 >>= int_3;
			this.int_2 -= int_3;
		}

		// Token: 0x06001507 RID: 5383
		// RVA: 0x00012CC3 File Offset: 0x00010EC3
		public int method_2()
		{
			return this.int_2;
		}

		// Token: 0x06001508 RID: 5384
		// RVA: 0x00012CCB File Offset: 0x00010ECB
		public int method_3()
		{
			return this.int_1 - this.int_0 + (this.int_2 >> 3);
		}

		// Token: 0x06001509 RID: 5385
		// RVA: 0x00012CE3 File Offset: 0x00010EE3
		public void method_4()
		{
			this.uint_0 >>= (this.int_2 & 7);
			this.int_2 &= -8;
		}

		// Token: 0x0600150A RID: 5386
		// RVA: 0x00012D0C File Offset: 0x00010F0C
		public bool method_5()
		{
			return this.int_0 == this.int_1;
		}

		// Token: 0x0600150B RID: 5387
		// RVA: 0x0006C52C File Offset: 0x0006A72C
		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			if (int_4 < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			if ((this.int_2 & 7) != 0)
			{
				throw new InvalidOperationException("Bit buffer is not byte aligned!");
			}
			int num = 0;
			while (this.int_2 > 0 && int_4 > 0)
			{
				byte_1[int_3++] = (byte)this.uint_0;
				this.uint_0 >>= 8;
				this.int_2 -= 8;
				int_4--;
				num++;
			}
			if (int_4 == 0)
			{
				return num;
			}
			int num2 = this.int_1 - this.int_0;
			if (int_4 > num2)
			{
				int_4 = num2;
			}
			Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
			this.int_0 += int_4;
			if ((this.int_0 - this.int_1 & 1) != 0)
			{
				this.uint_0 = (uint)(this.byte_0[this.int_0++] & 255);
				this.int_2 = 8;
			}
			return num + int_4;
		}

		// Token: 0x0600150C RID: 5388
		// RVA: 0x0006C620 File Offset: 0x0006A820
		public void method_7(byte[] byte_1, int int_3, int int_4)
		{
			if (byte_1 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (int_3 < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (int_4 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (this.int_0 < this.int_1)
			{
				throw new InvalidOperationException("Old input was not completely processed");
			}
			int num = int_3 + int_4;
			if (int_3 <= num && num <= byte_1.Length)
			{
				if ((int_4 & 1) != 0)
				{
					this.uint_0 |= (uint)((uint)(byte_1[int_3++] & 255) << this.int_2);
					this.int_2 += 8;
				}
				this.byte_0 = byte_1;
				this.int_0 = int_3;
				this.int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException("count");
		}
	}
}
