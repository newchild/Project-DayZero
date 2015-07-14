using ns34;
using ns39;
using System;

namespace ns38
{
	// Token: 0x02000256 RID: 598
	internal sealed class Class197
	{
		// Token: 0x04000F74 RID: 3956
		private byte[] byte_0;

		// Token: 0x04000F75 RID: 3957
		private byte[] byte_1;

		// Token: 0x04000F7D RID: 3965
		private byte byte_2;

		// Token: 0x04000F76 RID: 3958
		private Class198 class198_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly int[] int_0 = new int[]
		{
			3,
			3,
			11
		};

		// Token: 0x04000F72 RID: 3954
		private static readonly int[] int_1 = new int[]
		{
			2,
			3,
			7
		};

		// Token: 0x04000F73 RID: 3955
		private static readonly int[] int_2 = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000F77 RID: 3959
		private int int_3;

		// Token: 0x04000F78 RID: 3960
		private int int_4;

		// Token: 0x04000F79 RID: 3961
		private int int_5;

		// Token: 0x04000F7A RID: 3962
		private int int_6;

		// Token: 0x04000F7B RID: 3963
		private int int_7;

		// Token: 0x04000F7C RID: 3964
		private int int_8;

		// Token: 0x04000F7E RID: 3966
		private int int_9;

		// Token: 0x060014C6 RID: 5318
		// RVA: 0x0006B730 File Offset: 0x00069930
		public bool method_0(Class201 class201_0)
		{
			while (true)
			{
				switch (this.int_3)
				{
				case 0:
					this.int_4 = class201_0.method_0(5);
					if (this.int_4 >= 0)
					{
						this.int_4 += 257;
						class201_0.method_1(5);
						this.int_3 = 1;
						goto IL_1FD;
					}
					return false;
				case 1:
					goto IL_1FD;
				case 2:
					goto IL_1AF;
				case 3:
					goto IL_176;
				case 4:
					break;
				case 5:
					goto IL_2C;
				default:
					continue;
				}
				IL_F4:
				int num;
				while (((num = this.class198_0.method_1(class201_0)) & -16) == 0)
				{
					this.byte_1[this.int_9++] = (this.byte_2 = (byte)num);
					if (this.int_9 == this.int_7)
					{
						return true;
					}
				}
				if (num >= 0)
				{
					if (num >= 17)
					{
						this.byte_2 = 0;
					}
					else if (this.int_9 == 0)
					{
						goto IL_2A6;
					}
					this.int_8 = num - 16;
					this.int_3 = 5;
					goto IL_2C;
				}
				return false;
				IL_176:
				while (this.int_9 < this.int_6)
				{
					int num2 = class201_0.method_0(3);
					if (num2 < 0)
					{
						return false;
					}
					class201_0.method_1(3);
					this.byte_0[Class197.int_2[this.int_9]] = (byte)num2;
					this.int_9++;
				}
				this.class198_0 = new Class198(this.byte_0);
				this.byte_0 = null;
				this.int_9 = 0;
				this.int_3 = 4;
				goto IL_F4;
				IL_2C:
				int num3 = Class197.int_1[this.int_8];
				int num4 = class201_0.method_0(num3);
				if (num4 < 0)
				{
					return false;
				}
				class201_0.method_1(num3);
				num4 += Class197.int_0[this.int_8];
				if (this.int_9 + num4 > this.int_7)
				{
					break;
				}
				while (num4-- > 0)
				{
					this.byte_1[this.int_9++] = this.byte_2;
				}
				if (this.int_9 == this.int_7)
				{
					return true;
				}
				this.int_3 = 4;
				continue;
				IL_1AF:
				this.int_6 = class201_0.method_0(4);
				if (this.int_6 >= 0)
				{
					this.int_6 += 4;
					class201_0.method_1(4);
					this.byte_0 = new byte[19];
					this.int_9 = 0;
					this.int_3 = 3;
					goto IL_176;
				}
				return false;
				IL_1FD:
				this.int_5 = class201_0.method_0(5);
				if (this.int_5 >= 0)
				{
					this.int_5++;
					class201_0.method_1(5);
					this.int_7 = this.int_4 + this.int_5;
					this.byte_1 = new byte[this.int_7];
					this.int_3 = 2;
					goto IL_1AF;
				}
				return false;
			}
			throw new Exception6();
			IL_2A6:
			throw new Exception6();
		}

		// Token: 0x060014C7 RID: 5319
		// RVA: 0x0006B9F4 File Offset: 0x00069BF4
		public Class198 method_1()
		{
			byte[] destinationArray = new byte[this.int_4];
			Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_4);
			return new Class198(destinationArray);
		}

		// Token: 0x060014C8 RID: 5320
		// RVA: 0x0006BA28 File Offset: 0x00069C28
		public Class198 method_2()
		{
			byte[] destinationArray = new byte[this.int_5];
			Array.Copy(this.byte_1, this.int_4, destinationArray, 0, this.int_5);
			return new Class198(destinationArray);
		}
	}
}
