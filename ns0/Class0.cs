using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	internal sealed class Class0
	{
		// Token: 0x02000003 RID: 3
		internal sealed class Class1
		{
			// Token: 0x0400000A RID: 10
			private bool bool_0;

			// Token: 0x0400000B RID: 11
			private Class0.Class2 class2_0;

			// Token: 0x0400000C RID: 12
			private Class0.Class3 class3_0;

			// Token: 0x0400000E RID: 14
			private Class0.Class4 class4_0;

			// Token: 0x0400000F RID: 15
			private Class0.Class4 class4_1;

			// Token: 0x0400000D RID: 13
			private Class0.Class5 class5_0;

			// Token: 0x04000001 RID: 1
			private static int[] int_0 = new int[]
			{
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				13,
				15,
				17,
				19,
				23,
				27,
				31,
				35,
				43,
				51,
				59,
				67,
				83,
				99,
				115,
				131,
				163,
				195,
				227,
				258
			};

			// Token: 0x04000002 RID: 2
			private static int[] int_1 = new int[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				1,
				1,
				1,
				2,
				2,
				2,
				2,
				3,
				3,
				3,
				3,
				4,
				4,
				4,
				4,
				5,
				5,
				5,
				5,
				0
			};

			// Token: 0x04000003 RID: 3
			private static int[] int_2 = new int[]
			{
				1,
				2,
				3,
				4,
				5,
				7,
				9,
				13,
				17,
				25,
				33,
				49,
				65,
				97,
				129,
				193,
				257,
				385,
				513,
				769,
				1025,
				1537,
				2049,
				3073,
				4097,
				6145,
				8193,
				12289,
				16385,
				24577
			};

			// Token: 0x04000004 RID: 4
			private static int[] int_3 = new int[]
			{
				0,
				0,
				0,
				0,
				1,
				1,
				2,
				2,
				3,
				3,
				4,
				4,
				5,
				5,
				6,
				6,
				7,
				7,
				8,
				8,
				9,
				9,
				10,
				10,
				11,
				11,
				12,
				12,
				13,
				13
			};

			// Token: 0x04000005 RID: 5
			private int int_4;

			// Token: 0x04000006 RID: 6
			private int int_5;

			// Token: 0x04000007 RID: 7
			private int int_6;

			// Token: 0x04000008 RID: 8
			private int int_7;

			// Token: 0x04000009 RID: 9
			private int int_8;

			// Token: 0x06000002 RID: 2
			// RVA: 0x00005D60 File Offset: 0x00003F60
			public Class1(byte[] byte_0)
			{
				this.class2_0 = new Class0.Class2();
				this.class3_0 = new Class0.Class3();
				this.int_4 = 2;
				this.class2_0.method_7(byte_0, 0, byte_0.Length);
			}

			// Token: 0x06000003 RID: 3
			// RVA: 0x00027538 File Offset: 0x00025738
			private bool method_0()
			{
				int i = this.class3_0.method_4();
				while (i >= 258)
				{
					int num;
					switch (this.int_4)
					{
					case 7:
						while (((num = this.class4_0.method_1(this.class2_0)) & -256) == 0)
						{
							this.class3_0.method_0(num);
							if (--i < 258)
							{
								return true;
							}
						}
						if (num >= 257)
						{
							this.int_6 = Class0.Class1.int_0[num - 257];
							this.int_5 = Class0.Class1.int_1[num - 257];
							goto IL_9E;
						}
						if (num < 0)
						{
							return false;
						}
						this.class4_1 = null;
						this.class4_0 = null;
						this.int_4 = 2;
						return true;
					case 8:
						goto IL_9E;
					case 9:
						goto IL_EE;
					case 10:
						break;
					default:
						continue;
					}
					IL_121:
					if (this.int_5 > 0)
					{
						this.int_4 = 10;
						int num2 = this.class2_0.method_0(this.int_5);
						if (num2 < 0)
						{
							return false;
						}
						this.class2_0.method_1(this.int_5);
						this.int_7 += num2;
					}
					this.class3_0.method_2(this.int_6, this.int_7);
					i -= this.int_6;
					this.int_4 = 7;
					continue;
					IL_EE:
					num = this.class4_1.method_1(this.class2_0);
					if (num >= 0)
					{
						this.int_7 = Class0.Class1.int_2[num];
						this.int_5 = Class0.Class1.int_3[num];
						goto IL_121;
					}
					return false;
					IL_9E:
					if (this.int_5 > 0)
					{
						this.int_4 = 8;
						int num3 = this.class2_0.method_0(this.int_5);
						if (num3 < 0)
						{
							return false;
						}
						this.class2_0.method_1(this.int_5);
						this.int_6 += num3;
					}
					this.int_4 = 9;
					goto IL_EE;
				}
				return true;
			}

			// Token: 0x06000004 RID: 4
			// RVA: 0x00027704 File Offset: 0x00025904
			private bool method_1()
			{
				switch (this.int_4)
				{
				case 2:
				{
					if (this.bool_0)
					{
						this.int_4 = 12;
						return false;
					}
					int num = this.class2_0.method_0(3);
					if (num < 0)
					{
						return false;
					}
					this.class2_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class2_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class4_0 = Class0.Class4.class4_0;
						this.class4_1 = Class0.Class4.class4_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class5_0 = new Class0.Class5();
						this.int_4 = 6;
						break;
					}
					return true;
				}
				case 3:
					if ((this.int_8 = this.class2_0.method_0(16)) < 0)
					{
						return false;
					}
					this.class2_0.method_1(16);
					this.int_4 = 4;
					break;
				case 4:
					break;
				case 5:
					goto IL_137;
				case 6:
					if (!this.class5_0.method_0(this.class2_0))
					{
						return false;
					}
					this.class4_0 = this.class5_0.method_1();
					this.class4_1 = this.class5_0.method_2();
					this.int_4 = 7;
					goto IL_1BB;
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_1BB;
				case 11:
					return false;
				case 12:
					return false;
				default:
					return false;
				}
				int num2 = this.class2_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				this.class2_0.method_1(16);
				this.int_4 = 5;
				IL_137:
				int num3 = this.class3_0.method_3(this.class2_0, this.int_8);
				this.int_8 -= num3;
				if (this.int_8 == 0)
				{
					this.int_4 = 2;
					return true;
				}
				return !this.class2_0.method_5();
				IL_1BB:
				return this.method_0();
			}

			// Token: 0x06000005 RID: 5
			// RVA: 0x000278D8 File Offset: 0x00025AD8
			public int method_2(byte[] byte_0, int int_9, int int_10)
			{
				int num = 0;
				while (true)
				{
					if (this.int_4 != 11)
					{
						int num2 = this.class3_0.method_6(byte_0, int_9, int_10);
						int_9 += num2;
						num += num2;
						int_10 -= num2;
						if (int_10 == 0)
						{
							return num;
						}
					}
					if (!this.method_1())
					{
						if (this.class3_0.method_5() <= 0)
						{
							break;
						}
						if (this.int_4 == 11)
						{
							break;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x02000004 RID: 4
		internal sealed class Class2
		{
			// Token: 0x04000010 RID: 16
			private byte[] byte_0;

			// Token: 0x04000011 RID: 17
			private int int_0;

			// Token: 0x04000012 RID: 18
			private int int_1;

			// Token: 0x04000014 RID: 20
			private int int_2;

			// Token: 0x04000013 RID: 19
			private uint uint_0;

			// Token: 0x06000007 RID: 7
			// RVA: 0x000279A8 File Offset: 0x00025BA8
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

			// Token: 0x06000008 RID: 8
			// RVA: 0x00005D95 File Offset: 0x00003F95
			public void method_1(int int_3)
			{
				this.uint_0 >>= int_3;
				this.int_2 -= int_3;
			}

			// Token: 0x06000009 RID: 9
			// RVA: 0x00005DB6 File Offset: 0x00003FB6
			public int method_2()
			{
				return this.int_2;
			}

			// Token: 0x0600000A RID: 10
			// RVA: 0x00005DBE File Offset: 0x00003FBE
			public int method_3()
			{
				return this.int_1 - this.int_0 + (this.int_2 >> 3);
			}

			// Token: 0x0600000B RID: 11
			// RVA: 0x00005DD6 File Offset: 0x00003FD6
			public void method_4()
			{
				this.uint_0 >>= (this.int_2 & 7);
				this.int_2 &= -8;
			}

			// Token: 0x0600000C RID: 12
			// RVA: 0x00005DFF File Offset: 0x00003FFF
			public bool method_5()
			{
				return this.int_0 == this.int_1;
			}

			// Token: 0x0600000D RID: 13
			// RVA: 0x00027A48 File Offset: 0x00025C48
			public int method_6(byte[] byte_1, int int_3, int int_4)
			{
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

			// Token: 0x0600000F RID: 15
			// RVA: 0x00027B18 File Offset: 0x00025D18
			public void method_7(byte[] byte_1, int int_3, int int_4)
			{
				if (this.int_0 < this.int_1)
				{
					throw new InvalidOperationException();
				}
				int num = int_3 + int_4;
				if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
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
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x02000005 RID: 5
		internal sealed class Class3
		{
			// Token: 0x04000017 RID: 23
			private byte[] byte_0 = new byte[Class0.Class3.int_0];

			// Token: 0x04000015 RID: 21
			private static int int_0 = 32768;

			// Token: 0x04000016 RID: 22
			private static int int_1 = Class0.Class3.int_0 - 1;

			// Token: 0x04000018 RID: 24
			private int int_2;

			// Token: 0x04000019 RID: 25
			private int int_3;

			// Token: 0x06000010 RID: 16
			// RVA: 0x00027BA0 File Offset: 0x00025DA0
			public void method_0(int int_4)
			{
				if (this.int_3++ == Class0.Class3.int_0)
				{
					throw new InvalidOperationException();
				}
				this.byte_0[this.int_2++] = (byte)int_4;
				this.int_2 &= Class0.Class3.int_1;
			}

			// Token: 0x06000011 RID: 17
			// RVA: 0x00027BF8 File Offset: 0x00025DF8
			private void method_1(int int_4, int int_5, int int_6)
			{
				while (int_5-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[int_4++];
					this.int_2 &= Class0.Class3.int_1;
					int_4 &= Class0.Class3.int_1;
				}
			}

			// Token: 0x06000012 RID: 18
			// RVA: 0x00027C54 File Offset: 0x00025E54
			public void method_2(int int_4, int int_5)
			{
				if ((this.int_3 += int_4) > Class0.Class3.int_0)
				{
					throw new InvalidOperationException();
				}
				int num = this.int_2 - int_5 & Class0.Class3.int_1;
				int num2 = Class0.Class3.int_0 - int_4;
				if (num > num2 || this.int_2 >= num2)
				{
					this.method_1(num, int_4, int_5);
					return;
				}
				if (int_4 <= int_5)
				{
					Array.Copy(this.byte_0, num, this.byte_0, this.int_2, int_4);
					this.int_2 += int_4;
					return;
				}
				while (int_4-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[num++];
				}
			}

			// Token: 0x06000013 RID: 19
			// RVA: 0x00027D08 File Offset: 0x00025F08
			public int method_3(Class0.Class2 class2_0, int int_4)
			{
				int_4 = Math.Min(Math.Min(int_4, Class0.Class3.int_0 - this.int_3), class2_0.method_3());
				int num = Class0.Class3.int_0 - this.int_2;
				int num2;
				if (int_4 > num)
				{
					num2 = class2_0.method_6(this.byte_0, this.int_2, num);
					if (num2 == num)
					{
						num2 += class2_0.method_6(this.byte_0, 0, int_4 - num);
					}
				}
				else
				{
					num2 = class2_0.method_6(this.byte_0, this.int_2, int_4);
				}
				this.int_2 = (this.int_2 + num2 & Class0.Class3.int_1);
				this.int_3 += num2;
				return num2;
			}

			// Token: 0x06000014 RID: 20
			// RVA: 0x00005E17 File Offset: 0x00004017
			public int method_4()
			{
				return Class0.Class3.int_0 - this.int_3;
			}

			// Token: 0x06000015 RID: 21
			// RVA: 0x00005E25 File Offset: 0x00004025
			public int method_5()
			{
				return this.int_3;
			}

			// Token: 0x06000016 RID: 22
			// RVA: 0x00027DAC File Offset: 0x00025FAC
			public int method_6(byte[] byte_1, int int_4, int int_5)
			{
				int num = this.int_2;
				if (int_5 > this.int_3)
				{
					int_5 = this.int_3;
				}
				else
				{
					num = (this.int_2 - this.int_3 + int_5 & Class0.Class3.int_1);
				}
				int num2 = int_5;
				int num3 = int_5 - num;
				if (num3 > 0)
				{
					Array.Copy(this.byte_0, Class0.Class3.int_0 - num3, byte_1, int_4, num3);
					int_4 += num3;
					int_5 = num;
				}
				Array.Copy(this.byte_0, num - int_5, byte_1, int_4, int_5);
				this.int_3 -= num2;
				if (this.int_3 < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}
		}

		// Token: 0x02000006 RID: 6
		internal sealed class Class4
		{
			// Token: 0x0400001A RID: 26
			private static byte[] byte_0;

			// Token: 0x0400001D RID: 29
			public static Class0.Class4 class4_0;

			// Token: 0x0400001E RID: 30
			public static Class0.Class4 class4_1;

			// Token: 0x0400001B RID: 27
			private static int int_0;

			// Token: 0x0400001C RID: 28
			private short[] short_0;

			// Token: 0x06000019 RID: 25
			// RVA: 0x00027E40 File Offset: 0x00026040
			static Class4()
			{
				Class0.Class4.byte_0 = new byte[]
				{
					0,
					8,
					4,
					12,
					2,
					10,
					6,
					14,
					1,
					9,
					5,
					13,
					3,
					11,
					7,
					15
				};
				Class0.Class4.int_0 = 15;
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				Class0.Class4.class4_0 = new Class0.Class4(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				Class0.Class4.class4_1 = new Class0.Class4(array);
			}

			// Token: 0x0600001A RID: 26
			// RVA: 0x00005E5D File Offset: 0x0000405D
			public Class4(byte[] byte_1)
			{
				this.method_0(byte_1);
			}

			// Token: 0x0600001C RID: 28
			// RVA: 0x00027EF0 File Offset: 0x000260F0
			private void method_0(byte[] byte_1)
			{
				int[] array = new int[Class0.Class4.int_0 + 1];
				int[] array2 = new int[Class0.Class4.int_0 + 1];
				for (int i = 0; i < byte_1.Length; i++)
				{
					int num = (int)byte_1[i];
					if (num > 0)
					{
						array[num]++;
					}
				}
				int num2 = 0;
				int num3 = 512;
				for (int j = 1; j <= Class0.Class4.int_0; j++)
				{
					array2[j] = num2;
					num2 += array[j] << 16 - j;
					if (j >= 10)
					{
						int num4 = array2[j] & 130944;
						int num5 = num2 & 130944;
						num3 += num5 - num4 >> 16 - j;
					}
				}
				this.short_0 = new short[num3];
				int num6 = 512;
				for (int k = Class0.Class4.int_0; k >= 10; k--)
				{
					int num7 = num2 & 130944;
					num2 -= array[k] << 16 - k;
					int num8 = num2 & 130944;
					for (int l = num8; l < num7; l += 128)
					{
						this.short_0[(int)Class0.Class4.smethod_0(l)] = (short)(-num6 << 4 | k);
						num6 += 1 << k - 9;
					}
				}
				for (int m = 0; m < byte_1.Length; m++)
				{
					int num9 = (int)byte_1[m];
					if (num9 != 0)
					{
						num2 = array2[num9];
						int num10 = (int)Class0.Class4.smethod_0(num2);
						if (num9 <= 9)
						{
							do
							{
								this.short_0[num10] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < 512);
						}
						else
						{
							int num11 = (int)this.short_0[num10 & 511];
							int num12 = 1 << (num11 & 15);
							num11 = -(num11 >> 4);
							do
							{
								this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < num12);
						}
						array2[num9] = num2 + (1 << 16 - num9);
					}
				}
			}

			// Token: 0x0600001D RID: 29
			// RVA: 0x000280F4 File Offset: 0x000262F4
			public int method_1(Class0.Class2 class2_0)
			{
				int num;
				if ((num = class2_0.method_0(9)) >= 0)
				{
					int num2;
					if ((num2 = (int)this.short_0[num]) >= 0)
					{
						class2_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num3 = -(num2 >> 4);
					int int_ = num2 & 15;
					if ((num = class2_0.method_0(int_)) >= 0)
					{
						num2 = (int)this.short_0[num3 | num >> 9];
						class2_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num4 = class2_0.method_2();
					num = class2_0.method_0(num4);
					num2 = (int)this.short_0[num3 | num >> 9];
					if ((num2 & 15) <= num4)
					{
						class2_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
				else
				{
					int num5 = class2_0.method_2();
					num = class2_0.method_0(num5);
					int num2 = (int)this.short_0[num];
					if (num2 >= 0 && (num2 & 15) <= num5)
					{
						class2_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
			}

			// Token: 0x0600001B RID: 27
			// RVA: 0x00005E6C File Offset: 0x0000406C
			public static short smethod_0(int int_1)
			{
				return (short)((int)Class0.Class4.byte_0[int_1 & 15] << 12 | (int)Class0.Class4.byte_0[int_1 >> 4 & 15] << 8 | (int)Class0.Class4.byte_0[int_1 >> 8 & 15] << 4 | (int)Class0.Class4.byte_0[int_1 >> 12]);
			}
		}

		// Token: 0x02000007 RID: 7
		internal sealed class Class5
		{
			// Token: 0x04000021 RID: 33
			private byte[] byte_0;

			// Token: 0x04000022 RID: 34
			private byte[] byte_1;

			// Token: 0x0400002A RID: 42
			private byte byte_2;

			// Token: 0x04000023 RID: 35
			private Class0.Class4 class4_0;

			// Token: 0x0400001F RID: 31
			private static readonly int[] int_0 = new int[]
			{
				3,
				3,
				11
			};

			// Token: 0x04000020 RID: 32
			private static readonly int[] int_1 = new int[]
			{
				2,
				3,
				7
			};

			// Token: 0x04000024 RID: 36
			private int int_2;

			// Token: 0x04000025 RID: 37
			private int int_3;

			// Token: 0x04000026 RID: 38
			private int int_4;

			// Token: 0x04000027 RID: 39
			private int int_5;

			// Token: 0x04000028 RID: 40
			private int int_6;

			// Token: 0x04000029 RID: 41
			private int int_7;

			// Token: 0x0400002B RID: 43
			private int int_8;

			// Token: 0x0400002C RID: 44
			private static readonly int[] int_9 = new int[]
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

			// Token: 0x0600001F RID: 31
			// RVA: 0x000281CC File Offset: 0x000263CC
			public bool method_0(Class0.Class2 class2_0)
			{
				while (true)
				{
					switch (this.int_2)
					{
					case 0:
						this.int_3 = class2_0.method_0(5);
						if (this.int_3 >= 0)
						{
							this.int_3 += 257;
							class2_0.method_1(5);
							this.int_2 = 1;
							goto IL_1DD;
						}
						return false;
					case 1:
						goto IL_1DD;
					case 2:
						goto IL_18F;
					case 3:
						goto IL_156;
					case 4:
						break;
					case 5:
						goto IL_2C;
					default:
						continue;
					}
					IL_E1:
					int num;
					while (((num = this.class4_0.method_1(class2_0)) & -16) == 0)
					{
						this.byte_1[this.int_8++] = (this.byte_2 = (byte)num);
						if (this.int_8 == this.int_6)
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
						this.int_7 = num - 16;
						this.int_2 = 5;
						goto IL_2C;
					}
					return false;
					IL_156:
					while (this.int_8 < this.int_5)
					{
						int num2 = class2_0.method_0(3);
						if (num2 < 0)
						{
							return false;
						}
						class2_0.method_1(3);
						this.byte_0[Class0.Class5.int_9[this.int_8]] = (byte)num2;
						this.int_8++;
					}
					this.class4_0 = new Class0.Class4(this.byte_0);
					this.byte_0 = null;
					this.int_8 = 0;
					this.int_2 = 4;
					goto IL_E1;
					IL_2C:
					int num3 = Class0.Class5.int_1[this.int_7];
					int num4 = class2_0.method_0(num3);
					if (num4 < 0)
					{
						return false;
					}
					class2_0.method_1(num3);
					num4 += Class0.Class5.int_0[this.int_7];
					while (num4-- > 0)
					{
						this.byte_1[this.int_8++] = this.byte_2;
					}
					if (this.int_8 == this.int_6)
					{
						break;
					}
					this.int_2 = 4;
					continue;
					IL_18F:
					this.int_5 = class2_0.method_0(4);
					if (this.int_5 >= 0)
					{
						this.int_5 += 4;
						class2_0.method_1(4);
						this.byte_0 = new byte[19];
						this.int_8 = 0;
						this.int_2 = 3;
						goto IL_156;
					}
					return false;
					IL_1DD:
					this.int_4 = class2_0.method_0(5);
					if (this.int_4 >= 0)
					{
						this.int_4++;
						class2_0.method_1(5);
						this.int_6 = this.int_3 + this.int_4;
						this.byte_1 = new byte[this.int_6];
						this.int_2 = 2;
						goto IL_18F;
					}
					return false;
				}
				return true;
			}

			// Token: 0x06000020 RID: 32
			// RVA: 0x00028464 File Offset: 0x00026664
			public Class0.Class4 method_1()
			{
				byte[] destinationArray = new byte[this.int_3];
				Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
				return new Class0.Class4(destinationArray);
			}

			// Token: 0x06000021 RID: 33
			// RVA: 0x00028498 File Offset: 0x00026698
			public Class0.Class4 method_2()
			{
				byte[] destinationArray = new byte[this.int_4];
				Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
				return new Class0.Class4(destinationArray);
			}
		}

		// Token: 0x02000008 RID: 8
		internal sealed class Stream0 : MemoryStream
		{
			// Token: 0x06000025 RID: 37
			// RVA: 0x00005EC8 File Offset: 0x000040C8
			public Stream0(byte[] byte_0) : base(byte_0, false)
			{
			}

			// Token: 0x06000023 RID: 35
			// RVA: 0x00005EA5 File Offset: 0x000040A5
			public int method_0()
			{
				return this.ReadByte() | this.ReadByte() << 8;
			}

			// Token: 0x06000024 RID: 36
			// RVA: 0x00005EB6 File Offset: 0x000040B6
			public int method_1()
			{
				return this.method_0() | this.method_0() << 16;
			}
		}

		// Token: 0x06000001 RID: 1
		// RVA: 0x000273A0 File Offset: 0x000255A0
		public static byte[] smethod_0(byte[] byte_0)
		{
			Class0.Stream0 stream = new Class0.Stream0(byte_0);
			byte[] array = new byte[0];
			int num = stream.method_1();
			if (num == 67324752)
			{
				short num2 = (short)stream.method_0();
				int num3 = stream.method_0();
				int num4 = stream.method_0();
				if (num == 67324752 && num2 == 20 && num3 == 0)
				{
					if (num4 == 8)
					{
						stream.method_1();
						stream.method_1();
						stream.method_1();
						int num5 = stream.method_1();
						int num6 = stream.method_0();
						int num7 = stream.method_0();
						if (num6 > 0)
						{
							byte[] buffer = new byte[num6];
							stream.Read(buffer, 0, num6);
						}
						if (num7 > 0)
						{
							byte[] buffer2 = new byte[num7];
							stream.Read(buffer2, 0, num7);
						}
						byte[] array2 = new byte[stream.Length - stream.Position];
						stream.Read(array2, 0, array2.Length);
						Class0.Class1 class = new Class0.Class1(array2);
						array = new byte[num5];
						class.method_2(array, 0, array.Length);
						goto IL_182;
					}
				}
				throw new FormatException("Wrong Header Signature");
			}
			if (num != 25000571)
			{
				throw new FormatException("Unknown Header");
			}
			int num8 = stream.method_1();
			array = new byte[num8];
			int num10;
			for (int i = 0; i < num8; i += num10)
			{
				int num9 = stream.method_1();
				num10 = stream.method_1();
				byte[] array3 = new byte[num9];
				stream.Read(array3, 0, array3.Length);
				Class0.Class1 class2 = new Class0.Class1(array3);
				class2.method_2(array, i, num10);
			}
			IL_182:
			stream.Close();
			return array;
		}
	}
}
