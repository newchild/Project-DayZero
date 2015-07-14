using ns36;
using System;
using System.IO;

namespace ns32
{
	// Token: 0x020001D9 RID: 473
	internal sealed class Stream2 : Stream
	{
		// Token: 0x020001DA RID: 474
		private struct Struct21
		{
			// Token: 0x04000CD3 RID: 3283
			public int int_0;

			// Token: 0x04000CD4 RID: 3284
			public int int_1;

			// Token: 0x04000CD5 RID: 3285
			public int int_2;
		}

		// Token: 0x04000CB1 RID: 3249
		private bool bool_0 = true;

		// Token: 0x04000CB5 RID: 3253
		private bool bool_1;

		// Token: 0x04000CBA RID: 3258
		private bool[] bool_2 = new bool[256];

		// Token: 0x04000CCA RID: 3274
		private bool bool_3;

		// Token: 0x04000CD2 RID: 3282
		private bool bool_4;

		// Token: 0x04000CC0 RID: 3264
		private byte[] byte_0;

		// Token: 0x04000CBC RID: 3260
		private char[] char_0 = new char[256];

		// Token: 0x04000CBD RID: 3261
		private char[] char_1 = new char[256];

		// Token: 0x04000CBE RID: 3262
		private char[] char_2 = new char[18002];

		// Token: 0x04000CBF RID: 3263
		private char[] char_3 = new char[18002];

		// Token: 0x04000CB9 RID: 3257
		private Interface10 interface10_0 = new Class183();

		// Token: 0x04000CB0 RID: 3248
		private readonly int[] int_0 = new int[]
		{
			1,
			4,
			13,
			40,
			121,
			364,
			1093,
			3280,
			9841,
			29524,
			88573,
			265720,
			797161,
			2391484
		};

		// Token: 0x04000CB2 RID: 3250
		private int int_1;

		// Token: 0x04000CC4 RID: 3268
		private int[] int_10;

		// Token: 0x04000CC5 RID: 3269
		private int int_11;

		// Token: 0x04000CC6 RID: 3270
		private int[] int_12 = new int[258];

		// Token: 0x04000CC7 RID: 3271
		private int int_13;

		// Token: 0x04000CC8 RID: 3272
		private int int_14;

		// Token: 0x04000CC9 RID: 3273
		private int int_15;

		// Token: 0x04000CCB RID: 3275
		private int int_16;

		// Token: 0x04000CCC RID: 3276
		private int int_17 = -1;

		// Token: 0x04000CCD RID: 3277
		private int int_18;

		// Token: 0x04000CD0 RID: 3280
		private int int_19;

		// Token: 0x04000CB3 RID: 3251
		private int int_2;

		// Token: 0x04000CB4 RID: 3252
		private int int_3;

		// Token: 0x04000CB6 RID: 3254
		private int int_4;

		// Token: 0x04000CB7 RID: 3255
		private int int_5;

		// Token: 0x04000CB8 RID: 3256
		private int int_6;

		// Token: 0x04000CBB RID: 3259
		private int int_7;

		// Token: 0x04000CC1 RID: 3265
		private int[] int_8;

		// Token: 0x04000CC2 RID: 3266
		private int[] int_9;

		// Token: 0x04000CC3 RID: 3267
		private short[] short_0;

		// Token: 0x04000CD1 RID: 3281
		private Stream stream_0;

		// Token: 0x04000CCE RID: 3278
		private uint uint_0;

		// Token: 0x04000CCF RID: 3279
		private uint uint_1;

		// Token: 0x1700028C RID: 652
		public override bool CanRead
		{
			// Token: 0x060010B9 RID: 4281
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x1700028D RID: 653
		public override bool CanSeek
		{
			// Token: 0x060010BA RID: 4282
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x1700028E RID: 654
		public override bool CanWrite
		{
			// Token: 0x060010BB RID: 4283
			// RVA: 0x0001038E File Offset: 0x0000E58E
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x1700028F RID: 655
		public override long Length
		{
			// Token: 0x060010BC RID: 4284
			// RVA: 0x0001039B File Offset: 0x0000E59B
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x17000290 RID: 656
		public override long Position
		{
			// Token: 0x060010BD RID: 4285
			// RVA: 0x000103A8 File Offset: 0x0000E5A8
			get
			{
				return this.stream_0.Position;
			}
			// Token: 0x060010BE RID: 4286
			// RVA: 0x000103B5 File Offset: 0x0000E5B5
			set
			{
				throw new NotSupportedException("BZip2OutputStream position cannot be set");
			}
		}

		// Token: 0x060010B5 RID: 4277
		// RVA: 0x0001037B File Offset: 0x0000E57B
		public Stream2(Stream stream_1) : this(stream_1, 9)
		{
		}

		// Token: 0x060010B6 RID: 4278
		// RVA: 0x00056D94 File Offset: 0x00054F94
		public Stream2(Stream stream_1, int int_20)
		{
			this.method_6(stream_1);
			this.int_13 = 50;
			if (int_20 > 9)
			{
				int_20 = 9;
			}
			if (int_20 < 1)
			{
				int_20 = 1;
			}
			this.int_3 = int_20;
			this.method_21();
			this.Initialize();
			this.method_3();
		}

		// Token: 0x060010C5 RID: 4293
		// RVA: 0x000103F1 File Offset: 0x0000E5F1
		public override void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060010C8 RID: 4296
		// RVA: 0x00057208 File Offset: 0x00055408
		protected override void Dispose(bool disposing)
		{
			try
			{
				base.Dispose(disposing);
				if (!this.bool_4)
				{
					this.bool_4 = true;
					if (this.int_18 > 0)
					{
						this.method_2();
					}
					this.int_17 = -1;
					this.method_4();
					this.method_5();
					this.Flush();
				}
			}
			finally
			{
				if (disposing && this.method_0())
				{
					this.stream_0.Close();
				}
			}
		}

		// Token: 0x060010B7 RID: 4279
		// RVA: 0x00056E70 File Offset: 0x00055070
		~Stream2()
		{
			this.Dispose(false);
		}

		// Token: 0x060010C9 RID: 4297
		// RVA: 0x00010400 File Offset: 0x0000E600
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x060010CA RID: 4298
		// RVA: 0x0001040D File Offset: 0x0000E60D
		private void Initialize()
		{
			this.int_4 = 0;
			this.int_16 = 0;
			this.method_9(66);
			this.method_9(90);
			this.method_9(104);
			this.method_9(48 + this.int_3);
			this.uint_1 = 0u;
		}

		// Token: 0x060010B8 RID: 4280
		// RVA: 0x00010386 File Offset: 0x0000E586
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060010C6 RID: 4294
		// RVA: 0x00056F8C File Offset: 0x0005518C
		private void method_1()
		{
			this.int_7 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.bool_2[i])
				{
					this.char_0[this.int_7] = (char)i;
					this.char_1[i] = (char)this.int_7;
					this.int_7++;
				}
			}
		}

		// Token: 0x060010D2 RID: 4306
		// RVA: 0x000574C8 File Offset: 0x000556C8
		private void method_10(int int_20)
		{
			this.method_8(8, int_20 >> 24 & 255);
			this.method_8(8, int_20 >> 16 & 255);
			this.method_8(8, int_20 >> 8 & 255);
			this.method_8(8, int_20 & 255);
		}

		// Token: 0x060010D3 RID: 4307
		// RVA: 0x00010473 File Offset: 0x0000E673
		private void method_11(int int_20, int int_21)
		{
			this.method_8(int_20, int_21);
		}

		// Token: 0x060010D4 RID: 4308
		// RVA: 0x00057518 File Offset: 0x00055718
		private void method_12()
		{
			char[][] array = new char[6][];
			for (int i = 0; i < 6; i++)
			{
				array[i] = new char[258];
			}
			int num = 0;
			int num2 = this.int_7 + 2;
			for (int j = 0; j < 6; j++)
			{
				for (int k = 0; k < num2; k++)
				{
					array[j][k] = '\u000f';
				}
			}
			if (this.int_11 <= 0)
			{
				Stream2.smethod_0();
			}
			int num3;
			if (this.int_11 < 200)
			{
				num3 = 2;
			}
			else if (this.int_11 < 600)
			{
				num3 = 3;
			}
			else if (this.int_11 < 1200)
			{
				num3 = 4;
			}
			else if (this.int_11 < 2400)
			{
				num3 = 5;
			}
			else
			{
				num3 = 6;
			}
			int l = num3;
			int num4 = this.int_11;
			int m = 0;
			while (l > 0)
			{
				int num5 = num4 / l;
				int num6 = 0;
				int num7 = m - 1;
				while (num6 < num5 && num7 < num2 - 1)
				{
					num7++;
					num6 += this.int_12[num7];
				}
				if (num7 > m && l != num3 && l != 1 && (num3 - l) % 2 == 1)
				{
					num6 -= this.int_12[num7];
					num7--;
				}
				for (int n = 0; n < num2; n++)
				{
					if (n >= m && n <= num7)
					{
						array[l - 1][n] = '\0';
					}
					else
					{
						array[l - 1][n] = '\u000f';
					}
				}
				l--;
				m = num7 + 1;
				num4 -= num6;
			}
			int[][] array2 = new int[6][];
			for (int num8 = 0; num8 < 6; num8++)
			{
				array2[num8] = new int[258];
			}
			int[] array3 = new int[6];
			short[] array4 = new short[6];
			for (int num9 = 0; num9 < 4; num9++)
			{
				for (int num10 = 0; num10 < num3; num10++)
				{
					array3[num10] = 0;
				}
				for (int num11 = 0; num11 < num3; num11++)
				{
					for (int num12 = 0; num12 < num2; num12++)
					{
						array2[num11][num12] = 0;
					}
				}
				num = 0;
				int num13 = 0;
				int num7;
				for (m = 0; m < this.int_11; m = num7 + 1)
				{
					num7 = m + 50 - 1;
					if (num7 >= this.int_11)
					{
						num7 = this.int_11 - 1;
					}
					for (int num14 = 0; num14 < num3; num14++)
					{
						array4[num14] = 0;
					}
					if (num3 == 6)
					{
						short arg_23C_0 = 0;
						short num15 = 0;
						short num16 = 0;
						short num17 = 0;
						short num18 = 0;
						short num19 = 0;
						short num20 = arg_23C_0;
						for (int num21 = m; num21 <= num7; num21++)
						{
							short num22 = this.short_0[num21];
							num20 += (short)array[0][(int)num22];
							num19 += (short)array[1][(int)num22];
							num18 += (short)array[2][(int)num22];
							num17 += (short)array[3][(int)num22];
							num16 += (short)array[4][(int)num22];
							num15 += (short)array[5][(int)num22];
						}
						array4[0] = num20;
						array4[1] = num19;
						array4[2] = num18;
						array4[3] = num17;
						array4[4] = num16;
						array4[5] = num15;
					}
					else
					{
						for (int num23 = m; num23 <= num7; num23++)
						{
							short num24 = this.short_0[num23];
							for (int num25 = 0; num25 < num3; num25++)
							{
								short[] expr_2EB_cp_0 = array4;
								int expr_2EB_cp_1 = num25;
								expr_2EB_cp_0[expr_2EB_cp_1] += (short)array[num25][(int)num24];
							}
						}
					}
					int num26 = 999999999;
					int num27 = -1;
					for (int num28 = 0; num28 < num3; num28++)
					{
						if ((int)array4[num28] < num26)
						{
							num26 = (int)array4[num28];
							num27 = num28;
						}
					}
					num13 += num26;
					array3[num27]++;
					this.char_2[num] = (char)num27;
					num++;
					for (int num29 = m; num29 <= num7; num29++)
					{
						array2[num27][(int)this.short_0[num29]]++;
					}
				}
				for (int num30 = 0; num30 < num3; num30++)
				{
					Stream2.smethod_1(array[num30], array2[num30], num2, 20);
				}
			}
			if (num3 >= 8)
			{
				Stream2.smethod_0();
			}
			if (num >= 32768 || num > 18002)
			{
				Stream2.smethod_0();
			}
			char[] array5 = new char[6];
			for (int num31 = 0; num31 < num3; num31++)
			{
				array5[num31] = (char)num31;
			}
			for (int num32 = 0; num32 < num; num32++)
			{
				char c = this.char_2[num32];
				int num33 = 0;
				char c2 = array5[0];
				while (c != c2)
				{
					num33++;
					char c3 = c2;
					c2 = array5[num33];
					array5[num33] = c3;
				}
				array5[0] = c2;
				this.char_3[num32] = (char)num33;
			}
			int[][] array6 = new int[6][];
			for (int num34 = 0; num34 < 6; num34++)
			{
				array6[num34] = new int[258];
			}
			for (int num35 = 0; num35 < num3; num35++)
			{
				int num36 = 32;
				int num37 = 0;
				for (int num38 = 0; num38 < num2; num38++)
				{
					if ((int)array[num35][num38] > num37)
					{
						num37 = (int)array[num35][num38];
					}
					if ((int)array[num35][num38] < num36)
					{
						num36 = (int)array[num35][num38];
					}
				}
				if (num37 > 20)
				{
					Stream2.smethod_0();
				}
				if (num36 < 1)
				{
					Stream2.smethod_0();
				}
				Stream2.smethod_2(array6[num35], array[num35], num36, num37, num2);
			}
			bool[] array7 = new bool[16];
			for (int num39 = 0; num39 < 16; num39++)
			{
				array7[num39] = false;
				for (int num40 = 0; num40 < 16; num40++)
				{
					if (this.bool_2[num39 * 16 + num40])
					{
						array7[num39] = true;
					}
				}
			}
			for (int num41 = 0; num41 < 16; num41++)
			{
				if (array7[num41])
				{
					this.method_8(1, 1);
				}
				else
				{
					this.method_8(1, 0);
				}
			}
			for (int num42 = 0; num42 < 16; num42++)
			{
				if (array7[num42])
				{
					for (int num43 = 0; num43 < 16; num43++)
					{
						if (this.bool_2[num42 * 16 + num43])
						{
							this.method_8(1, 1);
						}
						else
						{
							this.method_8(1, 0);
						}
					}
				}
			}
			this.method_8(3, num3);
			this.method_8(15, num);
			for (int num44 = 0; num44 < num; num44++)
			{
				for (int num45 = 0; num45 < (int)this.char_3[num44]; num45++)
				{
					this.method_8(1, 1);
				}
				this.method_8(1, 0);
			}
			for (int num46 = 0; num46 < num3; num46++)
			{
				int num47 = (int)array[num46][0];
				this.method_8(5, num47);
				for (int num48 = 0; num48 < num2; num48++)
				{
					while (num47 < (int)array[num46][num48])
					{
						this.method_8(2, 2);
						num47++;
					}
					while (num47 > (int)array[num46][num48])
					{
						this.method_8(2, 3);
						num47--;
					}
					this.method_8(1, 0);
				}
			}
			int num49 = 0;
			m = 0;
			while (m < this.int_11)
			{
				int num7 = m + 50 - 1;
				if (num7 >= this.int_11)
				{
					num7 = this.int_11 - 1;
				}
				for (int num50 = m; num50 <= num7; num50++)
				{
					this.method_8((int)array[(int)this.char_2[num49]][(int)this.short_0[num50]], array6[(int)this.char_2[num49]][(int)this.short_0[num50]]);
				}
				m = num7 + 1;
				num49++;
			}
			if (num49 != num)
			{
				Stream2.smethod_0();
			}
		}

		// Token: 0x060010D5 RID: 4309
		// RVA: 0x0001047D File Offset: 0x0000E67D
		private void method_13()
		{
			this.method_11(24, this.int_2);
			this.method_22();
			this.method_12();
		}

		// Token: 0x060010D6 RID: 4310
		// RVA: 0x00057C48 File Offset: 0x00055E48
		private void method_14(int int_20, int int_21, int int_22)
		{
			int num = int_21 - int_20 + 1;
			if (num < 2)
			{
				return;
			}
			int i = 0;
			while (this.int_0[i] < num)
			{
				i++;
			}
			for (i--; i >= 0; i--)
			{
				int num2 = this.int_0[i];
				int j = int_20 + num2;
				while (j <= int_21)
				{
					int num3 = this.int_9[j];
					int num4 = j;
					while (this.method_20(this.int_9[num4 - num2] + int_22, num3 + int_22))
					{
						this.int_9[num4] = this.int_9[num4 - num2];
						num4 -= num2;
						if (num4 <= int_20 + num2 - 1)
						{
							break;
						}
					}
					this.int_9[num4] = num3;
					j++;
					if (j > int_21)
					{
						break;
					}
					num3 = this.int_9[j];
					num4 = j;
					while (this.method_20(this.int_9[num4 - num2] + int_22, num3 + int_22))
					{
						this.int_9[num4] = this.int_9[num4 - num2];
						num4 -= num2;
						if (num4 <= int_20 + num2 - 1)
						{
							break;
						}
					}
					this.int_9[num4] = num3;
					j++;
					if (j > int_21)
					{
						break;
					}
					num3 = this.int_9[j];
					num4 = j;
					while (this.method_20(this.int_9[num4 - num2] + int_22, num3 + int_22))
					{
						this.int_9[num4] = this.int_9[num4 - num2];
						num4 -= num2;
						if (num4 <= int_20 + num2 - 1)
						{
							break;
						}
					}
					this.int_9[num4] = num3;
					j++;
					if (this.int_14 > this.int_15 && this.bool_3)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060010D7 RID: 4311
		// RVA: 0x00057DC4 File Offset: 0x00055FC4
		private void method_15(int int_20, int int_21, int int_22)
		{
			while (int_22 > 0)
			{
				int num = this.int_9[int_20];
				this.int_9[int_20] = this.int_9[int_21];
				this.int_9[int_21] = num;
				int_20++;
				int_21++;
				int_22--;
			}
		}

		// Token: 0x060010D8 RID: 4312
		// RVA: 0x00057E0C File Offset: 0x0005600C
		private void method_16(int int_20, int int_21, int int_22)
		{
			Stream2.Struct21[] array = new Stream2.Struct21[1000];
			array[0].int_0 = int_20;
			array[0].int_1 = int_21;
			array[0].int_2 = int_22;
			int i = 1;
			while (i > 0)
			{
				if (i >= 1000)
				{
					Stream2.smethod_0();
				}
				i--;
				int num = array[i].int_0;
				int num2 = array[i].int_1;
				int num3 = array[i].int_2;
				if (num2 - num >= 20 && num3 <= 10)
				{
					int num4 = (int)Stream2.smethod_3(this.byte_0[this.int_9[num] + num3 + 1], this.byte_0[this.int_9[num2] + num3 + 1], this.byte_0[this.int_9[num + num2 >> 1] + num3 + 1]);
					int j;
					int num5 = j = num;
					int num7;
					int num6 = num7 = num2;
					while (true)
					{
						if (j <= num7)
						{
							int num8 = (int)this.byte_0[this.int_9[j] + num3 + 1] - num4;
							if (num8 == 0)
							{
								int num9 = this.int_9[j];
								this.int_9[j] = this.int_9[num5];
								this.int_9[num5] = num9;
								num5++;
								j++;
								continue;
							}
							if (num8 <= 0)
							{
								j++;
								continue;
							}
						}
						while (j <= num7)
						{
							int num8 = (int)this.byte_0[this.int_9[num7] + num3 + 1] - num4;
							if (num8 == 0)
							{
								int num10 = this.int_9[num7];
								this.int_9[num7] = this.int_9[num6];
								this.int_9[num6] = num10;
								num6--;
								num7--;
							}
							else
							{
								if (num8 < 0)
								{
									break;
								}
								num7--;
							}
						}
						if (j > num7)
						{
							break;
						}
						int num11 = this.int_9[j];
						this.int_9[j] = this.int_9[num7];
						this.int_9[num7] = num11;
						j++;
						num7--;
					}
					if (num6 < num5)
					{
						array[i].int_0 = num;
						array[i].int_1 = num2;
						array[i].int_2 = num3 + 1;
						i++;
					}
					else
					{
						int num8 = (num5 - num < j - num5) ? (num5 - num) : (j - num5);
						this.method_15(num, j - num8, num8);
						int num12 = (num2 - num6 < num6 - num7) ? (num2 - num6) : (num6 - num7);
						this.method_15(j, num2 - num12 + 1, num12);
						num8 = num + j - num5 - 1;
						num12 = num2 - (num6 - num7) + 1;
						array[i].int_0 = num;
						array[i].int_1 = num8;
						array[i].int_2 = num3;
						i++;
						array[i].int_0 = num8 + 1;
						array[i].int_1 = num12 - 1;
						array[i].int_2 = num3 + 1;
						i++;
						array[i].int_0 = num12;
						array[i].int_1 = num2;
						array[i].int_2 = num3;
						i++;
					}
				}
				else
				{
					this.method_14(num, num2, num3);
					if (this.int_14 > this.int_15 && this.bool_3)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060010D9 RID: 4313
		// RVA: 0x0005816C File Offset: 0x0005636C
		private void method_17()
		{
			int[] array = new int[256];
			int[] array2 = new int[256];
			bool[] array3 = new bool[256];
			for (int i = 0; i < 20; i++)
			{
				this.byte_0[this.int_1 + i + 2] = this.byte_0[i % (this.int_1 + 1) + 1];
			}
			for (int i = 0; i <= this.int_1 + 20; i++)
			{
				this.int_8[i] = 0;
			}
			this.byte_0[0] = this.byte_0[this.int_1 + 1];
			if (this.int_1 < 4000)
			{
				for (int i = 0; i <= this.int_1; i++)
				{
					this.int_9[i] = i;
				}
				this.bool_3 = false;
				this.int_15 = 0;
				this.int_14 = 0;
				this.method_14(0, this.int_1, 0);
				return;
			}
			int num = 0;
			for (int i = 0; i <= 255; i++)
			{
				array3[i] = false;
			}
			for (int i = 0; i <= 65536; i++)
			{
				this.int_10[i] = 0;
			}
			int num2 = (int)this.byte_0[0];
			for (int i = 0; i <= this.int_1; i++)
			{
				int num3 = (int)this.byte_0[i + 1];
				this.int_10[(num2 << 8) + num3]++;
				num2 = num3;
			}
			for (int i = 1; i <= 65536; i++)
			{
				this.int_10[i] += this.int_10[i - 1];
			}
			num2 = (int)this.byte_0[1];
			int j;
			for (int i = 0; i < this.int_1; i++)
			{
				int num3 = (int)this.byte_0[i + 2];
				j = (num2 << 8) + num3;
				num2 = num3;
				this.int_10[j]--;
				this.int_9[this.int_10[j]] = i;
			}
			j = ((int)this.byte_0[this.int_1 + 1] << 8) + (int)this.byte_0[1];
			this.int_10[j]--;
			this.int_9[this.int_10[j]] = this.int_1;
			for (int i = 0; i <= 255; i++)
			{
				array[i] = i;
			}
			int num4 = 1;
			do
			{
				num4 = 3 * num4 + 1;
			}
			while (num4 <= 256);
			do
			{
				num4 /= 3;
				for (int i = num4; i <= 255; i++)
				{
					int num5 = array[i];
					j = i;
					while (this.int_10[array[j - num4] + 1 << 8] - this.int_10[array[j - num4] << 8] > this.int_10[num5 + 1 << 8] - this.int_10[num5 << 8])
					{
						array[j] = array[j - num4];
						j -= num4;
						if (j <= num4 - 1)
						{
							break;
						}
					}
					array[j] = num5;
				}
			}
			while (num4 != 1);
			for (int i = 0; i <= 255; i++)
			{
				int num6 = array[i];
				for (j = 0; j <= 255; j++)
				{
					int num7 = (num6 << 8) + j;
					if ((this.int_10[num7] & 2097152) != 2097152)
					{
						int num8 = this.int_10[num7] & -2097153;
						int num9 = (this.int_10[num7 + 1] & -2097153) - 1;
						if (num9 > num8)
						{
							this.method_16(num8, num9, 2);
							num += num9 - num8 + 1;
							if (this.int_14 > this.int_15 && this.bool_3)
							{
								return;
							}
						}
						this.int_10[num7] |= 2097152;
					}
				}
				array3[num6] = true;
				if (i < 255)
				{
					int num10 = this.int_10[num6 << 8] & -2097153;
					int num11 = (this.int_10[num6 + 1 << 8] & -2097153) - num10;
					int num12 = 0;
					while (num11 >> num12 > 65534)
					{
						num12++;
					}
					for (j = 0; j < num11; j++)
					{
						int num13 = this.int_9[num10 + j];
						int num14 = j >> num12;
						this.int_8[num13] = num14;
						if (num13 < 20)
						{
							this.int_8[num13 + this.int_1 + 1] = num14;
						}
					}
					if (num11 - 1 >> num12 > 65535)
					{
						Stream2.smethod_0();
					}
				}
				for (j = 0; j <= 255; j++)
				{
					array2[j] = (this.int_10[(j << 8) + num6] & -2097153);
				}
				for (j = (this.int_10[num6 << 8] & -2097153); j < (this.int_10[num6 + 1 << 8] & -2097153); j++)
				{
					num2 = (int)this.byte_0[this.int_9[j]];
					if (!array3[num2])
					{
						this.int_9[array2[num2]] = ((this.int_9[j] == 0) ? this.int_1 : (this.int_9[j] - 1));
						array2[num2]++;
					}
				}
				for (j = 0; j <= 255; j++)
				{
					this.int_10[(j << 8) + num6] |= 2097152;
				}
			}
		}

		// Token: 0x060010DA RID: 4314
		// RVA: 0x000586C4 File Offset: 0x000568C4
		private void method_18()
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 256; i++)
			{
				this.bool_2[i] = false;
			}
			for (int i = 0; i <= this.int_1; i++)
			{
				if (num == 0)
				{
					num = Class180.int_0[num2];
					num2++;
					if (num2 == 512)
					{
						num2 = 0;
					}
				}
				num--;
				byte[] expr_4C_cp_0 = this.byte_0;
				int expr_4C_cp_1 = i + 1;
				expr_4C_cp_0[expr_4C_cp_1] ^= ((num == 1) ? 1 : 0);
				byte[] expr_70_cp_0 = this.byte_0;
				int expr_70_cp_1 = i + 1;
				expr_70_cp_0[expr_70_cp_1] &= 255;
				this.bool_2[(int)this.byte_0[i + 1]] = true;
			}
		}

		// Token: 0x060010DB RID: 4315
		// RVA: 0x00058774 File Offset: 0x00056974
		private void method_19()
		{
			this.int_15 = this.int_13 * this.int_1;
			this.int_14 = 0;
			this.bool_1 = false;
			this.bool_3 = true;
			this.method_17();
			if (this.int_14 > this.int_15 && this.bool_3)
			{
				this.method_18();
				this.int_14 = 0;
				this.int_15 = 0;
				this.bool_1 = true;
				this.bool_3 = false;
				this.method_17();
			}
			this.int_2 = -1;
			for (int i = 0; i <= this.int_1; i++)
			{
				if (this.int_9[i] == 0)
				{
					this.int_2 = i;
					IL_97:
					if (this.int_2 == -1)
					{
						Stream2.smethod_0();
					}
					return;
				}
			}
			goto IL_97;
		}

		// Token: 0x060010C7 RID: 4295
		// RVA: 0x00056FE8 File Offset: 0x000551E8
		private void method_2()
		{
			if (this.int_1 >= this.int_19)
			{
				this.method_4();
				this.method_3();
				this.method_2();
				return;
			}
			this.bool_2[this.int_17] = true;
			for (int i = 0; i < this.int_18; i++)
			{
				this.interface10_0.imethod_0(this.int_17);
			}
			switch (this.int_18)
			{
			case 1:
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				return;
			case 2:
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				return;
			case 3:
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				return;
			default:
				this.bool_2[this.int_18 - 4] = true;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)this.int_17;
				this.int_1++;
				this.byte_0[this.int_1 + 1] = (byte)(this.int_18 - 4);
				return;
			}
		}

		// Token: 0x060010DC RID: 4316
		// RVA: 0x00058828 File Offset: 0x00056A28
		private bool method_20(int int_20, int int_21)
		{
			byte b = this.byte_0[int_20 + 1];
			byte b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			b = this.byte_0[int_20 + 1];
			b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			b = this.byte_0[int_20 + 1];
			b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			b = this.byte_0[int_20 + 1];
			b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			b = this.byte_0[int_20 + 1];
			b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			b = this.byte_0[int_20 + 1];
			b2 = this.byte_0[int_21 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			int_20++;
			int_21++;
			int num = this.int_1 + 1;
			int num2;
			int num3;
			while (true)
			{
				b = this.byte_0[int_20 + 1];
				b2 = this.byte_0[int_21 + 1];
				if (b != b2)
				{
					goto Block_16;
				}
				num2 = this.int_8[int_20];
				num3 = this.int_8[int_21];
				if (num2 != num3)
				{
					break;
				}
				int_20++;
				int_21++;
				b = this.byte_0[int_20 + 1];
				b2 = this.byte_0[int_21 + 1];
				if (b != b2)
				{
					goto Block_8;
				}
				num2 = this.int_8[int_20];
				num3 = this.int_8[int_21];
				if (num2 != num3)
				{
					goto Block_9;
				}
				int_20++;
				int_21++;
				b = this.byte_0[int_20 + 1];
				b2 = this.byte_0[int_21 + 1];
				if (b != b2)
				{
					goto Block_10;
				}
				num2 = this.int_8[int_20];
				num3 = this.int_8[int_21];
				if (num2 != num3)
				{
					goto Block_11;
				}
				int_20++;
				int_21++;
				b = this.byte_0[int_20 + 1];
				b2 = this.byte_0[int_21 + 1];
				if (b != b2)
				{
					goto Block_12;
				}
				num2 = this.int_8[int_20];
				num3 = this.int_8[int_21];
				if (num2 != num3)
				{
					goto Block_13;
				}
				int_20++;
				int_21++;
				if (int_20 > this.int_1)
				{
					int_20 -= this.int_1;
					int_20--;
				}
				if (int_21 > this.int_1)
				{
					int_21 -= this.int_1;
					int_21--;
				}
				num -= 4;
				this.int_14++;
				if (num < 0)
				{
					return false;
				}
			}
			return num2 > num3;
			Block_8:
			return b > b2;
			Block_9:
			return num2 > num3;
			Block_10:
			return b > b2;
			Block_11:
			return num2 > num3;
			Block_12:
			return b > b2;
			Block_13:
			return num2 > num3;
			Block_16:
			return b > b2;
		}

		// Token: 0x060010DD RID: 4317
		// RVA: 0x00058AC4 File Offset: 0x00056CC4
		private void method_21()
		{
			int num = 100000 * this.int_3;
			this.byte_0 = new byte[num + 1 + 20];
			this.int_8 = new int[num + 20];
			this.int_9 = new int[num];
			this.int_10 = new int[65537];
			if (this.byte_0 == null || this.int_8 == null || this.int_9 == null)
			{
			}
			this.short_0 = new short[2 * num];
		}

		// Token: 0x060010DE RID: 4318
		// RVA: 0x00058B40 File Offset: 0x00056D40
		private void method_22()
		{
			char[] array = new char[256];
			this.method_1();
			int num = this.int_7 + 1;
			for (int i = 0; i <= num; i++)
			{
				this.int_12[i] = 0;
			}
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < this.int_7; i++)
			{
				array[i] = (char)i;
			}
			for (int i = 0; i <= this.int_1; i++)
			{
				char c = this.char_1[(int)this.byte_0[this.int_9[i]]];
				int num4 = 0;
				char c2 = array[0];
				while (c != c2)
				{
					num4++;
					char c3 = c2;
					c2 = array[num4];
					array[num4] = c3;
				}
				array[0] = c2;
				if (num4 == 0)
				{
					num3++;
				}
				else
				{
					if (num3 > 0)
					{
						num3--;
						while (true)
						{
							switch (num3 % 2)
							{
							case 0:
								this.short_0[num2] = 0;
								num2++;
								this.int_12[0]++;
								break;
							case 1:
								this.short_0[num2] = 1;
								num2++;
								this.int_12[1]++;
								break;
							}
							if (num3 < 2)
							{
								break;
							}
							num3 = (num3 - 2) / 2;
						}
						num3 = 0;
					}
					this.short_0[num2] = (short)(num4 + 1);
					num2++;
					this.int_12[num4 + 1]++;
				}
			}
			if (num3 > 0)
			{
				num3--;
				while (true)
				{
					switch (num3 % 2)
					{
					case 0:
						this.short_0[num2] = 0;
						num2++;
						this.int_12[0]++;
						break;
					case 1:
						this.short_0[num2] = 1;
						num2++;
						this.int_12[1]++;
						break;
					}
					if (num3 < 2)
					{
						break;
					}
					num3 = (num3 - 2) / 2;
				}
			}
			this.short_0[num2] = (short)num;
			num2++;
			this.int_12[num]++;
			this.int_11 = num2;
		}

		// Token: 0x060010CB RID: 4299
		// RVA: 0x0005727C File Offset: 0x0005547C
		private void method_3()
		{
			this.interface10_0.Reset();
			this.int_1 = -1;
			for (int i = 0; i < 256; i++)
			{
				this.bool_2[i] = false;
			}
			this.int_19 = 100000 * this.int_3 - 20;
		}

		// Token: 0x060010CC RID: 4300
		// RVA: 0x000572CC File Offset: 0x000554CC
		private void method_4()
		{
			if (this.int_1 < 0)
			{
				return;
			}
			this.uint_0 = (uint)this.interface10_0.Value;
			this.uint_1 = (this.uint_1 << 1 | this.uint_1 >> 31);
			this.uint_1 ^= this.uint_0;
			this.method_19();
			this.method_9(49);
			this.method_9(65);
			this.method_9(89);
			this.method_9(38);
			this.method_9(83);
			this.method_9(89);
			this.method_10((int)this.uint_0);
			if (this.bool_1)
			{
				this.method_8(1, 1);
				this.int_16++;
			}
			else
			{
				this.method_8(1, 0);
			}
			this.method_13();
		}

		// Token: 0x060010CD RID: 4301
		// RVA: 0x00057390 File Offset: 0x00055590
		private void method_5()
		{
			this.method_9(23);
			this.method_9(114);
			this.method_9(69);
			this.method_9(56);
			this.method_9(80);
			this.method_9(144);
			this.method_10((int)this.uint_1);
			this.method_7();
		}

		// Token: 0x060010CE RID: 4302
		// RVA: 0x0001044B File Offset: 0x0000E64B
		private void method_6(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.int_6 = 0;
			this.int_5 = 0;
			this.int_4 = 0;
		}

		// Token: 0x060010CF RID: 4303
		// RVA: 0x000573E4 File Offset: 0x000555E4
		private void method_7()
		{
			while (this.int_6 > 0)
			{
				int num = this.int_5 >> 24;
				this.stream_0.WriteByte((byte)num);
				this.int_5 <<= 8;
				this.int_6 -= 8;
				this.int_4++;
			}
		}

		// Token: 0x060010D0 RID: 4304
		// RVA: 0x00057440 File Offset: 0x00055640
		private void method_8(int int_20, int int_21)
		{
			while (this.int_6 >= 8)
			{
				int num = this.int_5 >> 24;
				this.stream_0.WriteByte((byte)num);
				this.int_5 <<= 8;
				this.int_6 -= 8;
				this.int_4++;
			}
			this.int_5 |= int_21 << 32 - this.int_6 - int_20;
			this.int_6 += int_20;
		}

		// Token: 0x060010D1 RID: 4305
		// RVA: 0x00010469 File Offset: 0x0000E669
		private void method_9(int int_20)
		{
			this.method_8(8, int_20);
		}

		// Token: 0x060010C2 RID: 4290
		// RVA: 0x000103E5 File Offset: 0x0000E5E5
		public override int Read(byte[] array, int offset, int count)
		{
			throw new NotSupportedException("BZip2OutputStream Read not supported");
		}

		// Token: 0x060010C1 RID: 4289
		// RVA: 0x000103D9 File Offset: 0x0000E5D9
		public override int ReadByte()
		{
			throw new NotSupportedException("BZip2OutputStream ReadByte not supported");
		}

		// Token: 0x060010BF RID: 4287
		// RVA: 0x000103C1 File Offset: 0x0000E5C1
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("BZip2OutputStream Seek not supported");
		}

		// Token: 0x060010C0 RID: 4288
		// RVA: 0x000103CD File Offset: 0x0000E5CD
		public override void SetLength(long value)
		{
			throw new NotSupportedException("BZip2OutputStream SetLength not supported");
		}

		// Token: 0x060010DF RID: 4319
		// RVA: 0x00010499 File Offset: 0x0000E699
		private static void smethod_0()
		{
			throw new Exception7("BZip2 output stream panic");
		}

		// Token: 0x060010E0 RID: 4320
		// RVA: 0x00058D74 File Offset: 0x00056F74
		private static void smethod_1(char[] char_4, int[] int_20, int int_21, int int_22)
		{
			int[] array = new int[260];
			int[] array2 = new int[516];
			int[] array3 = new int[516];
			for (int i = 0; i < int_21; i++)
			{
				array2[i + 1] = ((int_20[i] == 0) ? 1 : int_20[i]) << 8;
			}
			while (true)
			{
				int num = int_21;
				int j = 0;
				array[0] = 0;
				array2[0] = 0;
				array3[0] = -2;
				for (int k = 1; k <= int_21; k++)
				{
					array3[k] = -1;
					j++;
					array[j] = k;
					int num2 = j;
					int num3 = array[num2];
					while (array2[num3] < array2[array[num2 >> 1]])
					{
						array[num2] = array[num2 >> 1];
						num2 >>= 1;
					}
					array[num2] = num3;
				}
				if (j >= 260)
				{
					Stream2.smethod_0();
				}
				while (j > 1)
				{
					int num4 = array[1];
					array[1] = array[j];
					j--;
					int num5 = 1;
					int num6 = array[1];
					while (true)
					{
						int num7 = num5 << 1;
						if (num7 > j)
						{
							break;
						}
						if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
						{
							num7++;
						}
						if (array2[num6] < array2[array[num7]])
						{
							break;
						}
						array[num5] = array[num7];
						num5 = num7;
					}
					array[num5] = num6;
					int num8 = array[1];
					array[1] = array[j];
					j--;
					num5 = 1;
					num6 = array[1];
					while (true)
					{
						int num7 = num5 << 1;
						if (num7 > j)
						{
							break;
						}
						if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
						{
							num7++;
						}
						if (array2[num6] < array2[array[num7]])
						{
							break;
						}
						array[num5] = array[num7];
						num5 = num7;
					}
					array[num5] = num6;
					num++;
					array3[num4] = (array3[num8] = num);
					array2[num] = ((int)(((long)array2[num4] & 4294967040L) + ((long)array2[num8] & 4294967040L)) | 1 + (((array2[num4] & 255) > (array2[num8] & 255)) ? (array2[num4] & 255) : (array2[num8] & 255)));
					array3[num] = -1;
					j++;
					array[j] = num;
					num5 = j;
					num6 = array[num5];
					while (array2[num6] < array2[array[num5 >> 1]])
					{
						array[num5] = array[num5 >> 1];
						num5 >>= 1;
					}
					array[num5] = num6;
				}
				if (num >= 516)
				{
					Stream2.smethod_0();
				}
				bool flag = false;
				for (int l = 1; l <= int_21; l++)
				{
					int num9 = 0;
					int num10 = l;
					while (array3[num10] >= 0)
					{
						num10 = array3[num10];
						num9++;
					}
					char_4[l - 1] = (char)num9;
					if (num9 > int_22)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					break;
				}
				for (int m = 1; m < int_21; m++)
				{
					int num9 = array2[m] >> 8;
					num9 = 1 + num9 / 2;
					array2[m] = num9 << 8;
				}
			}
		}

		// Token: 0x060010E1 RID: 4321
		// RVA: 0x0005905C File Offset: 0x0005725C
		private static void smethod_2(int[] int_20, char[] char_4, int int_21, int int_22, int int_23)
		{
			int num = 0;
			for (int i = int_21; i <= int_22; i++)
			{
				for (int j = 0; j < int_23; j++)
				{
					if ((int)char_4[j] == i)
					{
						int_20[j] = num;
						num++;
					}
				}
				num <<= 1;
			}
		}

		// Token: 0x060010E2 RID: 4322
		// RVA: 0x00059098 File Offset: 0x00057298
		private static byte smethod_3(byte byte_1, byte byte_2, byte byte_3)
		{
			if (byte_1 > byte_2)
			{
				byte b = byte_1;
				byte_1 = byte_2;
				byte_2 = b;
			}
			if (byte_2 > byte_3)
			{
				byte b = byte_2;
				byte_2 = byte_3;
				byte_3 = b;
			}
			if (byte_1 > byte_2)
			{
				byte_2 = byte_1;
			}
			return byte_2;
		}

		// Token: 0x060010C3 RID: 4291
		// RVA: 0x00056EA0 File Offset: 0x000550A0
		public override void Write(byte[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Offset/count out of range");
			}
			for (int i = 0; i < count; i++)
			{
				this.WriteByte(array[offset + i]);
			}
		}

		// Token: 0x060010C4 RID: 4292
		// RVA: 0x00056F04 File Offset: 0x00055104
		public override void WriteByte(byte value)
		{
			int num = (256 + (int)value) % 256;
			if (this.int_17 != -1)
			{
				if (this.int_17 != num)
				{
					this.method_2();
					this.int_18 = 1;
					this.int_17 = num;
					return;
				}
				this.int_18++;
				if (this.int_18 > 254)
				{
					this.method_2();
					this.int_17 = -1;
					this.int_18 = 0;
					return;
				}
			}
			else
			{
				this.int_17 = num;
				this.int_18++;
			}
		}
	}
}
