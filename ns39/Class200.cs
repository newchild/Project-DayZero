using System;

namespace ns39
{
	// Token: 0x0200025B RID: 603
	internal sealed class Class200
	{
		// Token: 0x04000F95 RID: 3989
		private byte[] byte_0 = new byte[32768];

		// Token: 0x04000F96 RID: 3990
		private int int_0;

		// Token: 0x04000F97 RID: 3991
		private int int_1;

		// Token: 0x060014FD RID: 5373
		// RVA: 0x0006C240 File Offset: 0x0006A440
		private void method_0(int int_2, int int_3, int int_4)
		{
			while (int_3-- > 0)
			{
				this.byte_0[this.int_0++] = this.byte_0[int_2++];
				this.int_0 &= 32767;
				int_2 &= 32767;
			}
		}

		// Token: 0x060014FF RID: 5375
		// RVA: 0x0006C354 File Offset: 0x0006A554
		public int method_1(Class201 class201_0, int int_2)
		{
			int_2 = Math.Min(Math.Min(int_2, 32768 - this.int_1), class201_0.method_3());
			int num = 32768 - this.int_0;
			int num2;
			if (int_2 > num)
			{
				num2 = class201_0.method_6(this.byte_0, this.int_0, num);
				if (num2 == num)
				{
					num2 += class201_0.method_6(this.byte_0, 0, int_2 - num);
				}
			}
			else
			{
				num2 = class201_0.method_6(this.byte_0, this.int_0, int_2);
			}
			this.int_0 = (this.int_0 + num2 & 32767);
			this.int_1 += num2;
			return num2;
		}

		// Token: 0x06001500 RID: 5376
		// RVA: 0x00012C74 File Offset: 0x00010E74
		public int method_2()
		{
			return 32768 - this.int_1;
		}

		// Token: 0x06001501 RID: 5377
		// RVA: 0x00012C82 File Offset: 0x00010E82
		public int method_3()
		{
			return this.int_1;
		}

		// Token: 0x06001502 RID: 5378
		// RVA: 0x0006C3F8 File Offset: 0x0006A5F8
		public int method_4(byte[] byte_1, int int_2, int int_3)
		{
			int num = this.int_0;
			if (int_3 > this.int_1)
			{
				int_3 = this.int_1;
			}
			else
			{
				num = (this.int_0 - this.int_1 + int_3 & 32767);
			}
			int num2 = int_3;
			int num3 = int_3 - num;
			if (num3 > 0)
			{
				Array.Copy(this.byte_0, 32768 - num3, byte_1, int_2, num3);
				int_2 += num3;
				int_3 = num;
			}
			Array.Copy(this.byte_0, num - int_3, byte_1, int_2, int_3);
			this.int_1 -= num2;
			if (this.int_1 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}

		// Token: 0x060014FE RID: 5374
		// RVA: 0x0006C29C File Offset: 0x0006A49C
		public void Repeat(int int_2, int int_3)
		{
			if ((this.int_1 += int_2) > 32768)
			{
				throw new InvalidOperationException("Window full");
			}
			int num = this.int_0 - int_3 & 32767;
			int num2 = 32768 - int_2;
			if (num > num2 || this.int_0 >= num2)
			{
				this.method_0(num, int_2, int_3);
				return;
			}
			if (int_2 <= int_3)
			{
				Array.Copy(this.byte_0, num, this.byte_0, this.int_0, int_2);
				this.int_0 += int_2;
				return;
			}
			while (int_2-- > 0)
			{
				this.byte_0[this.int_0++] = this.byte_0[num++];
			}
		}

		// Token: 0x060014FC RID: 5372
		// RVA: 0x0006C1E4 File Offset: 0x0006A3E4
		public void Write(int int_2)
		{
			if (this.int_1++ == 32768)
			{
				throw new InvalidOperationException("Window full");
			}
			this.byte_0[this.int_0++] = (byte)int_2;
			this.int_0 &= 32767;
		}
	}
}
