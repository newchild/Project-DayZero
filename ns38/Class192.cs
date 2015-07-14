using ns34;
using System;

namespace ns38
{
	// Token: 0x02000251 RID: 593
	internal sealed class Class192
	{
		// Token: 0x02000252 RID: 594
		private sealed class Class193
		{
			// Token: 0x04000F51 RID: 3921
			public byte[] byte_0;

			// Token: 0x04000F57 RID: 3927
			private Class192 class192_0;

			// Token: 0x04000F52 RID: 3922
			public int int_0;

			// Token: 0x04000F53 RID: 3923
			public int int_1;

			// Token: 0x04000F55 RID: 3925
			private int[] int_2;

			// Token: 0x04000F56 RID: 3926
			private int int_3;

			// Token: 0x04000F50 RID: 3920
			public short[] short_0;

			// Token: 0x04000F54 RID: 3924
			private short[] short_1;

			// Token: 0x060014A3 RID: 5283
			// RVA: 0x00012891 File Offset: 0x00010A91
			public Class193(Class192 class192_1, int int_4, int int_5, int int_6)
			{
				this.class192_0 = class192_1;
				this.int_0 = int_5;
				this.int_3 = int_6;
				this.short_0 = new short[int_4];
				this.int_2 = new int[int_6];
			}

			// Token: 0x060014A5 RID: 5285
			// RVA: 0x000128C8 File Offset: 0x00010AC8
			public void method_0(int int_4)
			{
				this.class192_0.class195_0.method_4((int)this.short_1[int_4] & 65535, (int)this.byte_0[int_4]);
			}

			// Token: 0x060014A6 RID: 5286
			// RVA: 0x000128F0 File Offset: 0x00010AF0
			public void method_1(short[] short_2, byte[] byte_1)
			{
				this.short_1 = short_2;
				this.byte_0 = byte_1;
			}

			// Token: 0x060014A7 RID: 5287
			// RVA: 0x0006A630 File Offset: 0x00068830
			public void method_2()
			{
				int[] array = new int[this.int_3];
				int num = 0;
				this.short_1 = new short[this.short_0.Length];
				for (int i = 0; i < this.int_3; i++)
				{
					array[i] = num;
					num += this.int_2[i] << 15 - i;
				}
				for (int j = 0; j < this.int_1; j++)
				{
					int num2 = (int)this.byte_0[j];
					if (num2 > 0)
					{
						this.short_1[j] = Class192.smethod_0(array[num2 - 1]);
						array[num2 - 1] += 1 << 16 - num2;
					}
				}
			}

			// Token: 0x060014A8 RID: 5288
			// RVA: 0x0006A6DC File Offset: 0x000688DC
			public void method_3()
			{
				int num = this.short_0.Length;
				int[] array = new int[num];
				int i = 0;
				int num2 = 0;
				for (int j = 0; j < num; j++)
				{
					int num3 = (int)this.short_0[j];
					if (num3 != 0)
					{
						int num4 = i++;
						int num5;
						while (num4 > 0 && (int)this.short_0[array[num5 = (num4 - 1) / 2]] > num3)
						{
							array[num4] = array[num5];
							num4 = num5;
						}
						array[num4] = j;
						num2 = j;
					}
				}
				while (i < 2)
				{
					int num6 = (num2 < 2) ? (++num2) : 0;
					array[i++] = num6;
				}
				this.int_1 = Math.Max(num2 + 1, this.int_0);
				int num7 = i;
				int[] array2 = new int[4 * i - 2];
				int[] array3 = new int[2 * i - 1];
				int num8 = num7;
				for (int k = 0; k < i; k++)
				{
					int num9 = array[k];
					array2[2 * k] = num9;
					array2[2 * k + 1] = -1;
					array3[k] = (int)this.short_0[num9] << 8;
					array[k] = k;
				}
				do
				{
					int num10 = array[0];
					int num11 = array[--i];
					int num12 = 0;
					int l;
					for (l = 1; l < i; l = l * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					int num13 = array3[num11];
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
					int num14 = array[0];
					num11 = num8++;
					array2[2 * num11] = num10;
					array2[2 * num11 + 1] = num14;
					int num15 = Math.Min(array3[num10] & 255, array3[num14] & 255);
					num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
					num12 = 0;
					for (l = 1; l < i; l = num12 * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
				}
				while (i > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new Exception6("Heap invariant violated");
				}
				this.method_7(array2);
			}

			// Token: 0x060014A9 RID: 5289
			// RVA: 0x0006A950 File Offset: 0x00068B50
			public int method_4()
			{
				int num = 0;
				for (int i = 0; i < this.short_0.Length; i++)
				{
					num += (int)(this.short_0[i] * (short)this.byte_0[i]);
				}
				return num;
			}

			// Token: 0x060014AA RID: 5290
			// RVA: 0x0006A988 File Offset: 0x00068B88
			public void method_5(Class192.Class193 class193_0)
			{
				int num = -1;
				int i = 0;
				while (i < this.int_1)
				{
					int num2 = 1;
					int num3 = (int)this.byte_0[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							short[] expr_3B_cp_0 = class193_0.short_0;
							int expr_3B_cp_1 = num3;
							expr_3B_cp_0[expr_3B_cp_1] += 1;
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.int_1)
					{
						if (num != (int)this.byte_0[i])
						{
							break;
						}
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						short[] expr_8C_cp_0 = class193_0.short_0;
						int expr_8C_cp_1 = num;
						expr_8C_cp_0[expr_8C_cp_1] += (short)num2;
					}
					else if (num != 0)
					{
						short[] expr_AD_cp_0 = class193_0.short_0;
						int expr_AD_cp_1 = 16;
						expr_AD_cp_0[expr_AD_cp_1] += 1;
					}
					else if (num2 <= 10)
					{
						short[] expr_CF_cp_0 = class193_0.short_0;
						int expr_CF_cp_1 = 17;
						expr_CF_cp_0[expr_CF_cp_1] += 1;
					}
					else
					{
						short[] expr_EC_cp_0 = class193_0.short_0;
						int expr_EC_cp_1 = 18;
						expr_EC_cp_0[expr_EC_cp_1] += 1;
					}
				}
			}

			// Token: 0x060014AB RID: 5291
			// RVA: 0x0006AA9C File Offset: 0x00068C9C
			public void method_6(Class192.Class193 class193_0)
			{
				int num = -1;
				int i = 0;
				while (i < this.int_1)
				{
					int num2 = 1;
					int num3 = (int)this.byte_0[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							class193_0.method_0(num3);
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.int_1)
					{
						if (num != (int)this.byte_0[i])
						{
							break;
						}
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						while (num2-- > 0)
						{
							class193_0.method_0(num);
						}
					}
					else if (num != 0)
					{
						class193_0.method_0(16);
						this.class192_0.class195_0.method_4(num2 - 3, 2);
					}
					else if (num2 <= 10)
					{
						class193_0.method_0(17);
						this.class192_0.class195_0.method_4(num2 - 3, 3);
					}
					else
					{
						class193_0.method_0(18);
						this.class192_0.class195_0.method_4(num2 - 11, 7);
					}
				}
			}

			// Token: 0x060014AC RID: 5292
			// RVA: 0x0006AB98 File Offset: 0x00068D98
			private void method_7(int[] int_4)
			{
				this.byte_0 = new byte[this.short_0.Length];
				int num = int_4.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < this.int_3; i++)
				{
					this.int_2[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int j = num - 1; j >= 0; j--)
				{
					if (int_4[2 * j + 1] != -1)
					{
						int num4 = array[j] + 1;
						if (num4 > this.int_3)
						{
							num4 = this.int_3;
							num3++;
						}
						array[int_4[2 * j]] = (array[int_4[2 * j + 1]] = num4);
					}
					else
					{
						int num5 = array[j];
						this.int_2[num5 - 1]++;
						this.byte_0[int_4[2 * j]] = (byte)array[j];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num6 = this.int_3 - 1;
				while (true)
				{
					if (this.int_2[--num6] != 0)
					{
						do
						{
							this.int_2[num6]--;
							this.int_2[++num6]++;
							num3 -= 1 << this.int_3 - 1 - num6;
						}
						while (num3 > 0 && num6 < this.int_3 - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				this.int_2[this.int_3 - 1] += num3;
				this.int_2[this.int_3 - 2] -= num3;
				int num7 = 2 * num2;
				for (int num8 = this.int_3; num8 != 0; num8--)
				{
					int k = this.int_2[num8 - 1];
					while (k > 0)
					{
						int num9 = 2 * int_4[num7++];
						if (int_4[num9 + 1] == -1)
						{
							this.byte_0[int_4[num9]] = (byte)num8;
							k--;
						}
					}
				}
			}

			// Token: 0x060014A4 RID: 5284
			// RVA: 0x0006A5F8 File Offset: 0x000687F8
			public void Reset()
			{
				for (int i = 0; i < this.short_0.Length; i++)
				{
					this.short_0[i] = 0;
				}
				this.short_1 = null;
				this.byte_0 = null;
			}
		}

		// Token: 0x04000F43 RID: 3907
		private static readonly byte[] byte_0;

		// Token: 0x04000F45 RID: 3909
		private static byte[] byte_1;

		// Token: 0x04000F47 RID: 3911
		private static byte[] byte_2;

		// Token: 0x04000F4D RID: 3917
		private byte[] byte_3;

		// Token: 0x04000F49 RID: 3913
		private Class192.Class193 class193_0;

		// Token: 0x04000F4A RID: 3914
		private Class192.Class193 class193_1;

		// Token: 0x04000F4B RID: 3915
		private Class192.Class193 class193_2;

		// Token: 0x04000F48 RID: 3912
		public Class195 class195_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly int[] int_0;

		// Token: 0x04000F4E RID: 3918
		private int int_1;

		// Token: 0x04000F4F RID: 3919
		private int int_2;

		// Token: 0x04000F44 RID: 3908
		private static short[] short_0;

		// Token: 0x04000F46 RID: 3910
		private static short[] short_1;

		// Token: 0x04000F4C RID: 3916
		private short[] short_2;

		// Token: 0x06001496 RID: 5270
		// RVA: 0x00069F04 File Offset: 0x00068104
		static Class192()
		{
			Class192.int_0 = new int[]
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
			Class192.byte_0 = new byte[]
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
			Class192.short_0 = new short[286];
			Class192.byte_1 = new byte[286];
			int i = 0;
			while (i < 144)
			{
				Class192.short_0[i] = Class192.smethod_0(48 + i << 8);
				Class192.byte_1[i++] = 8;
			}
			while (i < 256)
			{
				Class192.short_0[i] = Class192.smethod_0(256 + i << 7);
				Class192.byte_1[i++] = 9;
			}
			while (i < 280)
			{
				Class192.short_0[i] = Class192.smethod_0(-256 + i << 9);
				Class192.byte_1[i++] = 7;
			}
			while (i < 286)
			{
				Class192.short_0[i] = Class192.smethod_0(-88 + i << 8);
				Class192.byte_1[i++] = 8;
			}
			Class192.short_1 = new short[30];
			Class192.byte_2 = new byte[30];
			for (i = 0; i < 30; i++)
			{
				Class192.short_1[i] = Class192.smethod_0(i << 11);
				Class192.byte_2[i] = 5;
			}
		}

		// Token: 0x06001497 RID: 5271
		// RVA: 0x0006A044 File Offset: 0x00068244
		public Class192(Class195 class195_1)
		{
			this.class195_0 = class195_1;
			this.class193_0 = new Class192.Class193(this, 286, 257, 15);
			this.class193_1 = new Class192.Class193(this, 30, 1, 15);
			this.class193_2 = new Class192.Class193(this, 19, 4, 7);
			this.short_2 = new short[16384];
			this.byte_3 = new byte[16384];
		}

		// Token: 0x06001499 RID: 5273
		// RVA: 0x0006A0B8 File Offset: 0x000682B8
		public void method_0(int int_3)
		{
			this.class193_2.method_2();
			this.class193_0.method_2();
			this.class193_1.method_2();
			this.class195_0.method_4(this.class193_0.int_1 - 257, 5);
			this.class195_0.method_4(this.class193_1.int_1 - 1, 5);
			this.class195_0.method_4(int_3 - 4, 4);
			for (int i = 0; i < int_3; i++)
			{
				this.class195_0.method_4((int)this.class193_2.byte_0[Class192.int_0[i]], 3);
			}
			this.class193_0.method_6(this.class193_2);
			this.class193_1.method_6(this.class193_2);
		}

		// Token: 0x0600149A RID: 5274
		// RVA: 0x0006A178 File Offset: 0x00068378
		public void method_1()
		{
			for (int i = 0; i < this.int_1; i++)
			{
				int num = (int)(this.byte_3[i] & 255);
				int num2 = (int)this.short_2[i];
				if (num2-- != 0)
				{
					int num3 = Class192.smethod_1(num);
					this.class193_0.method_0(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						this.class195_0.method_4(num & (1 << num4) - 1, num4);
					}
					int num5 = Class192.smethod_2(num2);
					this.class193_1.method_0(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						this.class195_0.method_4(num2 & (1 << num4) - 1, num4);
					}
				}
				else
				{
					this.class193_0.method_0(num);
				}
			}
			this.class193_0.method_0(256);
		}

		// Token: 0x0600149B RID: 5275
		// RVA: 0x0006A254 File Offset: 0x00068454
		public void method_2(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			this.class195_0.method_4(bool_0 ? 1 : 0, 3);
			this.class195_0.method_3();
			this.class195_0.method_0(int_4);
			this.class195_0.method_0(~int_4);
			this.class195_0.method_1(byte_4, int_3, int_4);
			this.Reset();
		}

		// Token: 0x0600149C RID: 5276
		// RVA: 0x0006A2B0 File Offset: 0x000684B0
		public void method_3(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			short[] expr_15_cp_0 = this.class193_0.short_0;
			int expr_15_cp_1 = 256;
			expr_15_cp_0[expr_15_cp_1] += 1;
			this.class193_0.method_3();
			this.class193_1.method_3();
			this.class193_0.method_5(this.class193_2);
			this.class193_1.method_5(this.class193_2);
			this.class193_2.method_3();
			int num = 4;
			for (int i = 18; i > num; i--)
			{
				if (this.class193_2.byte_0[Class192.int_0[i]] > 0)
				{
					num = i + 1;
				}
			}
			int num2 = 14 + num * 3 + this.class193_2.method_4() + this.class193_0.method_4() + this.class193_1.method_4() + this.int_2;
			int num3 = this.int_2;
			for (int j = 0; j < 286; j++)
			{
				num3 += (int)(this.class193_0.short_0[j] * (short)Class192.byte_1[j]);
			}
			for (int k = 0; k < 30; k++)
			{
				num3 += (int)(this.class193_1.short_0[k] * (short)Class192.byte_2[k]);
			}
			if (num2 >= num3)
			{
				num2 = num3;
			}
			if (int_3 >= 0 && int_4 + 4 < num2 >> 3)
			{
				this.method_2(byte_4, int_3, int_4, bool_0);
				return;
			}
			if (num2 == num3)
			{
				this.class195_0.method_4(2 + (bool_0 ? 1 : 0), 3);
				this.class193_0.method_1(Class192.short_0, Class192.byte_1);
				this.class193_1.method_1(Class192.short_1, Class192.byte_2);
				this.method_1();
				this.Reset();
				return;
			}
			this.class195_0.method_4(4 + (bool_0 ? 1 : 0), 3);
			this.method_0(num);
			this.method_1();
			this.Reset();
		}

		// Token: 0x0600149D RID: 5277
		// RVA: 0x00012846 File Offset: 0x00010A46
		public bool method_4()
		{
			return this.int_1 >= 16384;
		}

		// Token: 0x0600149E RID: 5278
		// RVA: 0x0006A478 File Offset: 0x00068678
		public bool method_5(int int_3)
		{
			this.short_2[this.int_1] = 0;
			this.byte_3[this.int_1++] = (byte)int_3;
			short[] expr_39_cp_0 = this.class193_0.short_0;
			expr_39_cp_0[int_3] += 1;
			return this.method_4();
		}

		// Token: 0x0600149F RID: 5279
		// RVA: 0x0006A4D4 File Offset: 0x000686D4
		public bool method_6(int int_3, int int_4)
		{
			this.short_2[this.int_1] = (short)int_3;
			this.byte_3[this.int_1++] = (byte)(int_4 - 3);
			int num = Class192.smethod_1(int_4 - 3);
			short[] expr_45_cp_0 = this.class193_0.short_0;
			int expr_45_cp_1 = num;
			expr_45_cp_0[expr_45_cp_1] += 1;
			if (num >= 265 && num < 285)
			{
				this.int_2 += (num - 261) / 4;
			}
			int num2 = Class192.smethod_2(int_3 - 1);
			short[] expr_93_cp_0 = this.class193_1.short_0;
			int expr_93_cp_1 = num2;
			expr_93_cp_0[expr_93_cp_1] += 1;
			if (num2 >= 4)
			{
				this.int_2 += num2 / 2 - 1;
			}
			return this.method_4();
		}

		// Token: 0x06001498 RID: 5272
		// RVA: 0x00012815 File Offset: 0x00010A15
		public void Reset()
		{
			this.int_1 = 0;
			this.int_2 = 0;
			this.class193_0.Reset();
			this.class193_1.Reset();
			this.class193_2.Reset();
		}

		// Token: 0x060014A0 RID: 5280
		// RVA: 0x00012858 File Offset: 0x00010A58
		public static short smethod_0(int int_3)
		{
			return (short)((int)Class192.byte_0[int_3 & 15] << 12 | (int)Class192.byte_0[int_3 >> 4 & 15] << 8 | (int)Class192.byte_0[int_3 >> 8 & 15] << 4 | (int)Class192.byte_0[int_3 >> 12]);
		}

		// Token: 0x060014A1 RID: 5281
		// RVA: 0x0006A5A0 File Offset: 0x000687A0
		private static int smethod_1(int int_3)
		{
			if (int_3 == 255)
			{
				return 285;
			}
			int num = 257;
			while (int_3 >= 8)
			{
				num += 4;
				int_3 >>= 1;
			}
			return num + int_3;
		}

		// Token: 0x060014A2 RID: 5282
		// RVA: 0x0006A5D4 File Offset: 0x000687D4
		private static int smethod_2(int int_3)
		{
			int num = 0;
			while (int_3 >= 4)
			{
				num += 2;
				int_3 >>= 1;
			}
			return num + int_3;
		}
	}
}
