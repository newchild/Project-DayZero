using System;

namespace ns33
{
	// Token: 0x020001E8 RID: 488
	internal sealed class Class139
	{
		// Token: 0x04000D63 RID: 3427
		internal byte[] byte_0;

		// Token: 0x04000D57 RID: 3415
		internal Class140 class140_0 = new Class140();

		// Token: 0x04000D5C RID: 3420
		internal Class142 class142_0 = new Class142();

		// Token: 0x04000D4F RID: 3407
		internal GClass1 gclass1_0;

		// Token: 0x04000D50 RID: 3408
		internal int[] int_0 = new int[1];

		// Token: 0x04000D51 RID: 3409
		internal int int_1;

		// Token: 0x04000D5E RID: 3422
		internal int int_10;

		// Token: 0x04000D5F RID: 3423
		internal int int_11;

		// Token: 0x04000D60 RID: 3424
		internal int int_12;

		// Token: 0x04000D61 RID: 3425
		internal int int_13;

		// Token: 0x04000D62 RID: 3426
		internal int[] int_14 = new int[1];

		// Token: 0x04000D64 RID: 3428
		internal int int_15;

		// Token: 0x04000D52 RID: 3410
		internal int int_2;

		// Token: 0x04000D53 RID: 3411
		internal int[] int_3;

		// Token: 0x04000D54 RID: 3412
		internal static readonly int[] int_4 = new int[]
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

		// Token: 0x04000D58 RID: 3416
		internal int int_5;

		// Token: 0x04000D59 RID: 3417
		internal int[] int_6;

		// Token: 0x04000D5A RID: 3418
		internal int int_7;

		// Token: 0x04000D5B RID: 3419
		private static readonly int[] int_8 = new int[]
		{
			0,
			1,
			3,
			7,
			15,
			31,
			63,
			127,
			255,
			511,
			1023,
			2047,
			4095,
			8191,
			16383,
			32767,
			65535
		};

		// Token: 0x04000D5D RID: 3421
		internal int int_9;

		// Token: 0x04000D55 RID: 3413
		internal long long_0;

		// Token: 0x04000D56 RID: 3414
		internal object object_0;

		// Token: 0x0600113A RID: 4410
		// RVA: 0x0005B74C File Offset: 0x0005994C
		internal Class139(GClass1 gclass1_1, object object_1, int int_16)
		{
			this.gclass1_0 = gclass1_1;
			this.int_6 = new int[4320];
			this.byte_0 = new byte[int_16];
			this.int_5 = int_16;
			this.object_0 = object_1;
			this.int_11 = 0;
			this.Reset(null);
		}

		// Token: 0x0600113B RID: 4411
		// RVA: 0x0005B7CC File Offset: 0x000599CC
		internal int Flush(int int_16)
		{
			int num = this.gclass1_0.int_3;
			int num2 = this.int_12;
			int num3 = ((num2 <= this.int_15) ? this.int_15 : this.int_5) - num2;
			if (num3 > this.gclass1_0.int_1)
			{
				num3 = this.gclass1_0.int_1;
			}
			if (num3 != 0 && int_16 == -5)
			{
				int_16 = 0;
			}
			this.gclass1_0.int_1 -= num3;
			this.gclass1_0.long_2 += (long)num3;
			if (this.object_0 != null)
			{
				this.gclass1_0.long_0 = (this.long_0 = Class136.smethod_0(this.long_0, this.byte_0, num2, num3));
			}
			Array.Copy(this.byte_0, num2, this.gclass1_0.byte_1, num, num3);
			num += num3;
			num2 += num3;
			if (num2 == this.int_5)
			{
				num2 = 0;
				if (this.int_15 == this.int_5)
				{
					this.int_15 = 0;
				}
				num3 = this.int_15 - num2;
				if (num3 > this.gclass1_0.int_1)
				{
					num3 = this.gclass1_0.int_1;
				}
				if (num3 != 0 && int_16 == -5)
				{
					int_16 = 0;
				}
				this.gclass1_0.int_1 -= num3;
				this.gclass1_0.long_2 += (long)num3;
				if (this.object_0 != null)
				{
					this.gclass1_0.long_0 = (this.long_0 = Class136.smethod_0(this.long_0, this.byte_0, num2, num3));
				}
				Array.Copy(this.byte_0, num2, this.gclass1_0.byte_1, num, num3);
				num += num3;
				num2 += num3;
			}
			this.gclass1_0.int_3 = num;
			this.int_12 = num2;
			return int_16;
		}

		// Token: 0x0600113C RID: 4412
		// RVA: 0x000107E2 File Offset: 0x0000E9E2
		internal void method_0()
		{
			this.Reset(null);
			this.byte_0 = null;
			this.int_6 = null;
		}

		// Token: 0x0600113D RID: 4413
		// RVA: 0x0005B980 File Offset: 0x00059B80
		internal int method_1(int int_16)
		{
			int num = this.gclass1_0.int_2;
			int num2 = this.gclass1_0.int_0;
			int num3 = this.int_1;
			int i = this.int_2;
			int num4 = this.int_15;
			int num5 = (num4 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4);
			int num6;
			while (true)
			{
				int[] array;
				int[] array2;
				switch (this.int_11)
				{
				case 0:
					while (i < 3)
					{
						if (num2 == 0)
						{
							goto IL_9B7;
						}
						int_16 = 0;
						num2--;
						num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
						i += 8;
					}
					num6 = (num3 & 7);
					this.int_9 = (num6 & 1);
					switch (Class143.smethod_0(num6, 1))
					{
					case 0:
						num3 = Class143.smethod_0(num3, 3);
						i -= 3;
						num6 = (i & 7);
						num3 = Class143.smethod_0(num3, num6);
						i -= num6;
						this.int_11 = 1;
						continue;
					case 1:
					{
						array = new int[1];
						array2 = new int[1];
						int[][] array3 = new int[1][];
						int[][] array4 = new int[1][];
						Class142.smethod_0(array, array2, array3, array4, this.gclass1_0);
						this.class140_0.method_1(array[0], array2[0], array3[0], 0, array4[0], 0);
						num3 = Class143.smethod_0(num3, 3);
						i -= 3;
						this.int_11 = 6;
						continue;
					}
					case 2:
						num3 = Class143.smethod_0(num3, 3);
						i -= 3;
						this.int_11 = 3;
						continue;
					case 3:
						goto IL_931;
					default:
						continue;
					}
					break;
				case 1:
				{
					while (i < 32)
					{
						if (num2 == 0)
						{
							goto IL_A86;
						}
						int_16 = 0;
						num2--;
						num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
						i += 8;
					}
					if ((Class143.smethod_0(~num3, 16) & 65535) != (num3 & 65535))
					{
						goto Block_46;
					}
					this.int_10 = (num3 & 65535);
					int arg_759_0 = 0;
					i = 0;
					num3 = arg_759_0;
					this.int_11 = ((this.int_10 != 0) ? 2 : ((this.int_9 != 0) ? 7 : 0));
					continue;
				}
				case 2:
					if (num2 == 0)
					{
						goto IL_B38;
					}
					if (num5 == 0)
					{
						if (num4 == this.int_5 && this.int_12 != 0)
						{
							num4 = 0;
							num5 = ((0 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4));
						}
						if (num5 == 0)
						{
							this.int_15 = num4;
							int_16 = this.Flush(int_16);
							num4 = this.int_15;
							num5 = ((num4 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4));
							if (num4 == this.int_5 && this.int_12 != 0)
							{
								num4 = 0;
								num5 = ((0 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4));
							}
							if (num5 == 0)
							{
								goto IL_ADF;
							}
						}
					}
					int_16 = 0;
					num6 = this.int_10;
					if (num6 > num2)
					{
						num6 = num2;
					}
					if (num6 > num5)
					{
						num6 = num5;
					}
					Array.Copy(this.gclass1_0.byte_0, num, this.byte_0, num4, num6);
					num += num6;
					num2 -= num6;
					num4 += num6;
					num5 -= num6;
					this.int_10 -= num6;
					if (this.int_10 == 0)
					{
						this.int_11 = ((this.int_9 != 0) ? 7 : 0);
						continue;
					}
					continue;
				case 3:
					while (i < 14)
					{
						if (num2 == 0)
						{
							goto IL_C07;
						}
						int_16 = 0;
						num2--;
						num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
						i += 8;
					}
					num6 = (this.int_13 = (num3 & 16383));
					if ((num6 & 31) <= 29 && (num6 >> 5 & 31) <= 29)
					{
						num6 = 258 + (num6 & 31) + (num6 >> 5 & 31);
						if (this.int_3 != null && this.int_3.Length >= num6)
						{
							for (int j = 0; j < num6; j++)
							{
								this.int_3[j] = 0;
							}
						}
						else
						{
							this.int_3 = new int[num6];
						}
						num3 = Class143.smethod_0(num3, 14);
						i -= 14;
						this.int_7 = 0;
						this.int_11 = 4;
						goto IL_437;
					}
					goto IL_B91;
				case 4:
					goto IL_437;
				case 5:
					goto IL_2ED;
				case 6:
					goto IL_58;
				case 7:
					goto IL_EDA;
				case 8:
					goto IL_F83;
				case 9:
					goto IL_FDF;
				}
				goto Block_52;
				while (true)
				{
					IL_2ED:
					num6 = this.int_13;
					if (this.int_7 >= 258 + (num6 & 31) + (num6 >> 5 & 31))
					{
						break;
					}
					num6 = this.int_0[0];
					while (i < num6)
					{
						if (num2 == 0)
						{
							goto IL_E72;
						}
						int_16 = 0;
						num2--;
						num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
						i += 8;
					}
					num6 = this.int_6[(this.int_14[0] + (num3 & Class139.int_8[num6])) * 3 + 1];
					int num7 = this.int_6[(this.int_14[0] + (num3 & Class139.int_8[num6])) * 3 + 2];
					if (num7 < 16)
					{
						num3 = Class143.smethod_0(num3, num6);
						i -= num6;
						this.int_3[this.int_7++] = num7;
					}
					else
					{
						int j = (num7 == 18) ? 7 : (num7 - 14);
						int num8 = (num7 == 18) ? 11 : 3;
						while (i < num6 + j)
						{
							if (num2 == 0)
							{
								goto IL_E19;
							}
							int_16 = 0;
							num2--;
							num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
							i += 8;
						}
						num3 = Class143.smethod_0(num3, num6);
						i -= num6;
						num8 += (num3 & Class139.int_8[j]);
						num3 = Class143.smethod_0(num3, j);
						i -= j;
						j = this.int_7;
						num6 = this.int_13;
						if (j + num8 > 258 + (num6 & 31) + (num6 >> 5 & 31) || (num7 == 16 && j < 1))
						{
							goto IL_D9C;
						}
						num7 = ((num7 == 16) ? this.int_3[j - 1] : 0);
						do
						{
							this.int_3[j++] = num7;
						}
						while (--num8 != 0);
						this.int_7 = j;
					}
				}
				this.int_14[0] = -1;
				array = new int[]
				{
					9
				};
				array2 = new int[]
				{
					6
				};
				int[] array5 = new int[1];
				int[] array6 = new int[1];
				num6 = this.int_13;
				num6 = this.class142_0.method_2(257 + (num6 & 31), 1 + (num6 >> 5 & 31), this.int_3, array, array2, array5, array6, this.int_6, this.gclass1_0);
				if (num6 == 0)
				{
					this.class140_0.method_1(array[0], array2[0], this.int_6, array5[0], this.int_6, array6[0]);
					this.int_11 = 6;
					goto IL_58;
				}
				goto IL_D2A;
				IL_437:
				while (this.int_7 < 4 + Class143.smethod_0(this.int_13, 10))
				{
					while (i < 3)
					{
						if (num2 == 0)
						{
							goto IL_CD1;
						}
						int_16 = 0;
						num2--;
						num3 |= (int)(this.gclass1_0.byte_0[num++] & 255) << i;
						i += 8;
					}
					this.int_3[Class139.int_4[this.int_7++]] = (num3 & 7);
					num3 = Class143.smethod_0(num3, 3);
					i -= 3;
				}
				while (this.int_7 < 19)
				{
					this.int_3[Class139.int_4[this.int_7++]] = 0;
				}
				this.int_0[0] = 7;
				num6 = this.class142_0.method_1(this.int_3, this.int_0, this.int_14, this.int_6, this.gclass1_0);
				if (num6 == 0)
				{
					this.int_7 = 0;
					this.int_11 = 5;
					goto IL_2ED;
				}
				goto IL_C60;
				IL_58:
				this.int_1 = num3;
				this.int_2 = i;
				this.gclass1_0.int_0 = num2;
				this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
				this.gclass1_0.int_2 = num;
				this.int_15 = num4;
				if ((int_16 = this.class140_0.method_2(this, int_16)) != 1)
				{
					break;
				}
				int_16 = 0;
				num = this.gclass1_0.int_2;
				num2 = this.gclass1_0.int_0;
				num3 = this.int_1;
				i = this.int_2;
				num4 = this.int_15;
				num5 = ((num4 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4));
				if (this.int_9 != 0)
				{
					goto IL_ED3;
				}
				this.int_11 = 0;
			}
			return this.Flush(int_16);
			Block_46:
			this.int_11 = 9;
			this.gclass1_0.string_0 = "invalid stored block lengths";
			int_16 = -3;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-3);
			Block_52:
			int_16 = -2;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-2);
			IL_931:
			num3 = Class143.smethod_0(num3, 3);
			i -= 3;
			this.int_11 = 9;
			this.gclass1_0.string_0 = "invalid block type";
			int_16 = -3;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-3);
			IL_9B7:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_A86:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_ADF:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_B38:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_B91:
			this.int_11 = 9;
			this.gclass1_0.string_0 = "too many length or distance symbols";
			int_16 = -3;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-3);
			IL_C07:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_C60:
			int_16 = num6;
			if (int_16 == -3)
			{
				this.int_3 = null;
				this.int_11 = 9;
			}
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_CD1:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_D2A:
			if (num6 == -3)
			{
				this.int_3 = null;
				this.int_11 = 9;
			}
			int_16 = num6;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_D9C:
			this.int_3 = null;
			this.int_11 = 9;
			this.gclass1_0.string_0 = "invalid bit length repeat";
			int_16 = -3;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-3);
			IL_E19:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_E72:
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(int_16);
			IL_ED3:
			this.int_11 = 7;
			IL_EDA:
			this.int_15 = num4;
			int_16 = this.Flush(int_16);
			num4 = this.int_15;
			int arg_F13_0 = (num4 < this.int_12) ? (this.int_12 - num4 - 1) : (this.int_5 - num4);
			if (this.int_12 != this.int_15)
			{
				this.int_1 = num3;
				this.int_2 = i;
				this.gclass1_0.int_0 = num2;
				this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
				this.gclass1_0.int_2 = num;
				this.int_15 = num4;
				return this.Flush(int_16);
			}
			this.int_11 = 8;
			IL_F83:
			int_16 = 1;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(1);
			IL_FDF:
			int_16 = -3;
			this.int_1 = num3;
			this.int_2 = i;
			this.gclass1_0.int_0 = num2;
			this.gclass1_0.long_1 += (long)(num - this.gclass1_0.int_2);
			this.gclass1_0.int_2 = num;
			this.int_15 = num4;
			return this.Flush(-3);
		}

		// Token: 0x0600113E RID: 4414
		// RVA: 0x0005C9CC File Offset: 0x0005ABCC
		internal void Reset(long[] long_1)
		{
			if (long_1 != null)
			{
				long_1[0] = this.long_0;
			}
			if (this.int_11 != 4)
			{
			}
			this.int_11 = 0;
			this.int_2 = 0;
			this.int_1 = 0;
			this.int_15 = 0;
			this.int_12 = 0;
			if (this.object_0 != null)
			{
				this.gclass1_0.long_0 = (this.long_0 = Class136.smethod_0(0L, null, 0, 0));
			}
		}
	}
}
