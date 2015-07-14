using ns36;
using System;
using System.IO;

namespace ns32
{
	// Token: 0x02000238 RID: 568
	internal sealed class Stream10 : Stream
	{
		// Token: 0x04000EDD RID: 3805
		private bool bool_0;

		// Token: 0x04000EE1 RID: 3809
		private bool[] bool_1 = new bool[256];

		// Token: 0x04000EEF RID: 3823
		private bool bool_2;

		// Token: 0x04000EFF RID: 3839
		private bool bool_3 = true;

		// Token: 0x04000EE3 RID: 3811
		private byte[] byte_0 = new byte[256];

		// Token: 0x04000EE4 RID: 3812
		private byte[] byte_1 = new byte[256];

		// Token: 0x04000EE5 RID: 3813
		private byte[] byte_2 = new byte[18002];

		// Token: 0x04000EE6 RID: 3814
		private byte[] byte_3 = new byte[18002];

		// Token: 0x04000EE8 RID: 3816
		private byte[] byte_4;

		// Token: 0x04000EFE RID: 3838
		private byte byte_5;

		// Token: 0x04000EE0 RID: 3808
		private Interface10 interface10_0 = new Class183();

		// Token: 0x04000EDA RID: 3802
		private int int_0;

		// Token: 0x04000EDB RID: 3803
		private int int_1;

		// Token: 0x04000EEC RID: 3820
		private int[][] int_10 = new int[6][];

		// Token: 0x04000EED RID: 3821
		private int[] int_11 = new int[6];

		// Token: 0x04000EF0 RID: 3824
		private int int_12 = -1;

		// Token: 0x04000EF1 RID: 3825
		private int int_13 = 1;

		// Token: 0x04000EF2 RID: 3826
		private int int_14;

		// Token: 0x04000EF3 RID: 3827
		private int int_15;

		// Token: 0x04000EF4 RID: 3828
		private int int_16;

		// Token: 0x04000EF6 RID: 3830
		private int int_17;

		// Token: 0x04000EF7 RID: 3831
		private int int_18;

		// Token: 0x04000EF8 RID: 3832
		private int int_19;

		// Token: 0x04000EDC RID: 3804
		private int int_2;

		// Token: 0x04000EF9 RID: 3833
		private int int_20;

		// Token: 0x04000EFA RID: 3834
		private int int_21;

		// Token: 0x04000EFB RID: 3835
		private int int_22;

		// Token: 0x04000EFC RID: 3836
		private int int_23;

		// Token: 0x04000EFD RID: 3837
		private int int_24;

		// Token: 0x04000EDE RID: 3806
		private int int_3;

		// Token: 0x04000EDF RID: 3807
		private int int_4;

		// Token: 0x04000EE2 RID: 3810
		private int int_5;

		// Token: 0x04000EE7 RID: 3815
		private int[] int_6;

		// Token: 0x04000EE9 RID: 3817
		private int[] int_7 = new int[256];

		// Token: 0x04000EEA RID: 3818
		private int[][] int_8 = new int[6][];

		// Token: 0x04000EEB RID: 3819
		private int[][] int_9 = new int[6][];

		// Token: 0x04000EEE RID: 3822
		private Stream stream_0;

		// Token: 0x04000EF5 RID: 3829
		private uint uint_0;

		// Token: 0x170002CE RID: 718
		public override bool CanRead
		{
			// Token: 0x06001406 RID: 5126
			// RVA: 0x000123E1 File Offset: 0x000105E1
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x170002CF RID: 719
		public override bool CanSeek
		{
			// Token: 0x06001407 RID: 5127
			// RVA: 0x000123EE File Offset: 0x000105EE
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x170002D0 RID: 720
		public override bool CanWrite
		{
			// Token: 0x06001408 RID: 5128
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002D1 RID: 721
		public override long Length
		{
			// Token: 0x06001409 RID: 5129
			// RVA: 0x000123FB File Offset: 0x000105FB
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x170002D2 RID: 722
		public override long Position
		{
			// Token: 0x0600140A RID: 5130
			// RVA: 0x00012408 File Offset: 0x00010608
			get
			{
				return this.stream_0.Position;
			}
			// Token: 0x0600140B RID: 5131
			// RVA: 0x00012415 File Offset: 0x00010615
			set
			{
				throw new NotSupportedException("BZip2InputStream position cannot be set");
			}
		}

		// Token: 0x06001404 RID: 5124
		// RVA: 0x000674B8 File Offset: 0x000656B8
		public Stream10(Stream stream_1)
		{
			for (int i = 0; i < 6; i++)
			{
				this.int_8[i] = new int[258];
				this.int_9[i] = new int[258];
				this.int_10[i] = new int[258];
			}
			this.method_5(stream_1);
			this.Initialize();
			this.method_2();
			this.method_13();
		}

		// Token: 0x06001412 RID: 5138
		// RVA: 0x00012466 File Offset: 0x00010666
		public override void Close()
		{
			if (this.method_0() && this.stream_0 != null)
			{
				this.stream_0.Close();
			}
		}

		// Token: 0x0600140C RID: 5132
		// RVA: 0x00012421 File Offset: 0x00010621
		public override void Flush()
		{
			if (this.stream_0 != null)
			{
				this.stream_0.Flush();
			}
		}

		// Token: 0x06001415 RID: 5141
		// RVA: 0x000676E0 File Offset: 0x000658E0
		private void Initialize()
		{
			char c = this.method_8();
			char c2 = this.method_8();
			char c3 = this.method_8();
			char c4 = this.method_8();
			if (c == 'B' && c2 == 'Z' && c3 == 'h' && c4 >= '1' && c4 <= '9')
			{
				this.method_20((int)(c4 - '0'));
				this.uint_0 = 0u;
				return;
			}
			this.bool_2 = true;
		}

		// Token: 0x06001405 RID: 5125
		// RVA: 0x000123D9 File Offset: 0x000105D9
		public bool method_0()
		{
			return this.bool_3;
		}

		// Token: 0x06001414 RID: 5140
		// RVA: 0x00067684 File Offset: 0x00065884
		private void method_1()
		{
			this.int_5 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.bool_1[i])
				{
					this.byte_0[this.int_5] = (byte)i;
					this.byte_1[i] = (byte)this.int_5;
					this.int_5++;
				}
			}
		}

		// Token: 0x0600141E RID: 5150
		// RVA: 0x00067914 File Offset: 0x00065B14
		private int method_10()
		{
			int num = this.method_7(8);
			num = (num << 8 | this.method_7(8));
			num = (num << 8 | this.method_7(8));
			return num << 8 | this.method_7(8);
		}

		// Token: 0x0600141F RID: 5151
		// RVA: 0x00067950 File Offset: 0x00065B50
		private void method_11()
		{
			char[][] array = new char[6][];
			for (int i = 0; i < 6; i++)
			{
				array[i] = new char[258];
			}
			bool[] array2 = new bool[16];
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (this.method_7(1) == 1);
			}
			for (int k = 0; k < 16; k++)
			{
				if (array2[k])
				{
					for (int l = 0; l < 16; l++)
					{
						this.bool_1[k * 16 + l] = (this.method_7(1) == 1);
					}
				}
				else
				{
					for (int m = 0; m < 16; m++)
					{
						this.bool_1[k * 16 + m] = false;
					}
				}
			}
			this.method_1();
			int num = this.int_5 + 2;
			int num2 = this.method_7(3);
			int num3 = this.method_7(15);
			for (int n = 0; n < num3; n++)
			{
				int num4 = 0;
				while (this.method_7(1) == 1)
				{
					num4++;
				}
				this.byte_3[n] = (byte)num4;
			}
			byte[] array3 = new byte[6];
			for (int num5 = 0; num5 < num2; num5++)
			{
				array3[num5] = (byte)num5;
			}
			for (int num6 = 0; num6 < num3; num6++)
			{
				int num7 = (int)this.byte_3[num6];
				byte b = array3[num7];
				while (num7 > 0)
				{
					array3[num7] = array3[num7 - 1];
					num7--;
				}
				array3[0] = b;
				this.byte_2[num6] = b;
			}
			for (int num8 = 0; num8 < num2; num8++)
			{
				int num9 = this.method_7(5);
				for (int num10 = 0; num10 < num; num10++)
				{
					while (this.method_7(1) == 1)
					{
						if (this.method_7(1) == 0)
						{
							num9++;
						}
						else
						{
							num9--;
						}
					}
					array[num8][num10] = (char)num9;
				}
			}
			for (int num11 = 0; num11 < num2; num11++)
			{
				int num12 = 32;
				int num13 = 0;
				for (int num14 = 0; num14 < num; num14++)
				{
					num13 = Math.Max(num13, (int)array[num11][num14]);
					num12 = Math.Min(num12, (int)array[num11][num14]);
				}
				Stream10.smethod_4(this.int_8[num11], this.int_9[num11], this.int_10[num11], array[num11], num12, num13, num);
				this.int_11[num11] = num12;
			}
		}

		// Token: 0x06001420 RID: 5152
		// RVA: 0x00067B9C File Offset: 0x00065D9C
		private void method_12()
		{
			byte[] array = new byte[256];
			int num = 100000 * this.int_2;
			this.int_1 = this.method_9(24);
			this.method_11();
			int num2 = this.int_5 + 1;
			int num3 = -1;
			int num4 = 0;
			for (int i = 0; i <= 255; i++)
			{
				this.int_7[i] = 0;
			}
			for (int j = 0; j <= 255; j++)
			{
				array[j] = (byte)j;
			}
			this.int_0 = -1;
			if (num4 == 0)
			{
				num3++;
				num4 = 50;
			}
			num4--;
			int num5 = (int)this.byte_2[num3];
			int num6 = this.int_11[num5];
			int k;
			int num7;
			for (k = this.method_7(num6); k > this.int_8[num5][num6]; k = (k << 1 | num7))
			{
				if (num6 > 20)
				{
					throw new Exception7("Bzip data error");
				}
				num6++;
				while (this.int_4 < 1)
				{
					this.method_6();
				}
				num7 = (this.int_3 >> this.int_4 - 1 & 1);
				this.int_4--;
			}
			if (k - this.int_9[num5][num6] >= 0 && k - this.int_9[num5][num6] < 258)
			{
				int num8 = this.int_10[num5][k - this.int_9[num5][num6]];
				while (num8 != num2)
				{
					if (num8 != 0)
					{
						if (num8 != 1)
						{
							this.int_0++;
							if (this.int_0 >= num)
							{
								Stream10.smethod_1();
							}
							byte b = array[num8 - 1];
							this.int_7[(int)this.byte_0[(int)b]]++;
							this.byte_4[this.int_0] = this.byte_0[(int)b];
							for (int l = num8 - 1; l > 0; l--)
							{
								array[l] = array[l - 1];
							}
							array[0] = b;
							if (num4 == 0)
							{
								num3++;
								num4 = 50;
							}
							num4--;
							num5 = (int)this.byte_2[num3];
							num6 = this.int_11[num5];
							for (k = this.method_7(num6); k > this.int_8[num5][num6]; k = (k << 1 | num7))
							{
								num6++;
								while (this.int_4 < 1)
								{
									this.method_6();
								}
								num7 = (this.int_3 >> this.int_4 - 1 & 1);
								this.int_4--;
							}
							num8 = this.int_10[num5][k - this.int_9[num5][num6]];
							continue;
						}
					}
					int m = -1;
					int num9 = 1;
					do
					{
						if (num8 == 0)
						{
							m += num9;
						}
						else if (num8 == 1)
						{
							m += 2 * num9;
						}
						num9 <<= 1;
						if (num4 == 0)
						{
							num3++;
							num4 = 50;
						}
						num4--;
						num5 = (int)this.byte_2[num3];
						num6 = this.int_11[num5];
						for (k = this.method_7(num6); k > this.int_8[num5][num6]; k = (k << 1 | num7))
						{
							num6++;
							while (this.int_4 < 1)
							{
								this.method_6();
							}
							num7 = (this.int_3 >> this.int_4 - 1 & 1);
							this.int_4--;
						}
						num8 = this.int_10[num5][k - this.int_9[num5][num6]];
					}
					while (num8 == 0 || num8 == 1);
					m++;
					byte b2 = this.byte_0[(int)array[0]];
					this.int_7[(int)b2] += m;
					while (m > 0)
					{
						this.int_0++;
						this.byte_4[this.int_0] = b2;
						m--;
					}
					if (this.int_0 >= num)
					{
						Stream10.smethod_1();
					}
				}
				return;
			}
			throw new Exception7("Bzip data error");
		}

		// Token: 0x06001421 RID: 5153
		// RVA: 0x00067F9C File Offset: 0x0006619C
		private void method_13()
		{
			int[] array = new int[257];
			array[0] = 0;
			Array.Copy(this.int_7, 0, array, 1, 256);
			for (int i = 1; i <= 256; i++)
			{
				array[i] += array[i - 1];
			}
			for (int j = 0; j <= this.int_0; j++)
			{
				byte b = this.byte_4[j];
				this.int_6[array[(int)b]] = j;
				array[(int)b]++;
			}
			this.int_20 = this.int_6[this.int_1];
			this.int_17 = 0;
			this.int_23 = 0;
			this.int_19 = 256;
			if (this.bool_0)
			{
				this.int_21 = 0;
				this.int_22 = 0;
				this.method_14();
				return;
			}
			this.method_15();
		}

		// Token: 0x06001422 RID: 5154
		// RVA: 0x00068080 File Offset: 0x00066280
		private void method_14()
		{
			if (this.int_23 <= this.int_0)
			{
				this.int_18 = this.int_19;
				this.int_19 = (int)this.byte_4[this.int_20];
				this.int_20 = this.int_6[this.int_20];
				if (this.int_21 == 0)
				{
					this.int_21 = Class180.int_0[this.int_22];
					this.int_22++;
					if (this.int_22 == 512)
					{
						this.int_22 = 0;
					}
				}
				this.int_21--;
				this.int_19 ^= ((this.int_21 == 1) ? 1 : 0);
				this.int_23++;
				this.int_12 = this.int_19;
				this.int_13 = 3;
				this.interface10_0.imethod_0(this.int_19);
				return;
			}
			this.method_3();
			this.method_2();
			this.method_13();
		}

		// Token: 0x06001423 RID: 5155
		// RVA: 0x0006817C File Offset: 0x0006637C
		private void method_15()
		{
			if (this.int_23 <= this.int_0)
			{
				this.int_18 = this.int_19;
				this.int_19 = (int)this.byte_4[this.int_20];
				this.int_20 = this.int_6[this.int_20];
				this.int_23++;
				this.int_12 = this.int_19;
				this.int_13 = 6;
				this.interface10_0.imethod_0(this.int_19);
				return;
			}
			this.method_3();
			this.method_2();
			this.method_13();
		}

		// Token: 0x06001424 RID: 5156
		// RVA: 0x00068210 File Offset: 0x00066410
		private void method_16()
		{
			if (this.int_19 != this.int_18)
			{
				this.int_13 = 2;
				this.int_17 = 1;
				this.method_14();
				return;
			}
			this.int_17++;
			if (this.int_17 >= 4)
			{
				this.byte_5 = this.byte_4[this.int_20];
				this.int_20 = this.int_6[this.int_20];
				if (this.int_21 == 0)
				{
					this.int_21 = Class180.int_0[this.int_22];
					this.int_22++;
					if (this.int_22 == 512)
					{
						this.int_22 = 0;
					}
				}
				this.int_21--;
				this.byte_5 ^= ((this.int_21 == 1) ? 1 : 0);
				this.int_24 = 0;
				this.int_13 = 4;
				this.method_17();
				return;
			}
			this.int_13 = 2;
			this.method_14();
		}

		// Token: 0x06001425 RID: 5157
		// RVA: 0x00068308 File Offset: 0x00066508
		private void method_17()
		{
			if (this.int_24 < (int)this.byte_5)
			{
				this.int_12 = this.int_19;
				this.interface10_0.imethod_0(this.int_19);
				this.int_24++;
				return;
			}
			this.int_13 = 2;
			this.int_23++;
			this.int_17 = 0;
			this.method_14();
		}

		// Token: 0x06001426 RID: 5158
		// RVA: 0x00068374 File Offset: 0x00066574
		private void method_18()
		{
			if (this.int_19 != this.int_18)
			{
				this.int_13 = 5;
				this.int_17 = 1;
				this.method_15();
				return;
			}
			this.int_17++;
			if (this.int_17 >= 4)
			{
				this.byte_5 = this.byte_4[this.int_20];
				this.int_20 = this.int_6[this.int_20];
				this.int_13 = 7;
				this.int_24 = 0;
				this.method_19();
				return;
			}
			this.int_13 = 5;
			this.method_15();
		}

		// Token: 0x06001427 RID: 5159
		// RVA: 0x00068404 File Offset: 0x00066604
		private void method_19()
		{
			if (this.int_24 < (int)this.byte_5)
			{
				this.int_12 = this.int_19;
				this.interface10_0.imethod_0(this.int_19);
				this.int_24++;
				return;
			}
			this.int_13 = 5;
			this.int_23++;
			this.int_17 = 0;
			this.method_15();
		}

		// Token: 0x06001416 RID: 5142
		// RVA: 0x0006773C File Offset: 0x0006593C
		private void method_2()
		{
			char c = this.method_8();
			char c2 = this.method_8();
			char c3 = this.method_8();
			char c4 = this.method_8();
			char c5 = this.method_8();
			char c6 = this.method_8();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.method_4();
				return;
			}
			if (c == '1' && c2 == 'A' && c3 == 'Y' && c4 == '&' && c5 == 'S')
			{
				if (c6 == 'Y')
				{
					this.int_14 = this.method_10();
					this.bool_0 = (this.method_7(1) == 1);
					this.method_12();
					this.interface10_0.Reset();
					this.int_13 = 1;
					return;
				}
			}
			Stream10.smethod_2();
			this.bool_2 = true;
		}

		// Token: 0x06001428 RID: 5160
		// RVA: 0x00068470 File Offset: 0x00066670
		private void method_20(int int_25)
		{
			if (0 > int_25 || int_25 > 9 || 0 > this.int_2 || this.int_2 > 9)
			{
				throw new Exception7("Invalid block size");
			}
			this.int_2 = int_25;
			if (int_25 == 0)
			{
				return;
			}
			int num = 100000 * int_25;
			this.byte_4 = new byte[num];
			this.int_6 = new int[num];
		}

		// Token: 0x06001417 RID: 5143
		// RVA: 0x00067804 File Offset: 0x00065A04
		private void method_3()
		{
			this.int_16 = (int)this.interface10_0.Value;
			if (this.int_14 != this.int_16)
			{
				Stream10.smethod_3();
			}
			this.uint_0 = ((this.uint_0 << 1 & 4294967295u) | this.uint_0 >> 31);
			this.uint_0 ^= (uint)this.int_16;
		}

		// Token: 0x06001418 RID: 5144
		// RVA: 0x00012483 File Offset: 0x00010683
		private void method_4()
		{
			this.int_15 = this.method_10();
			if (this.int_15 != (int)this.uint_0)
			{
				Stream10.smethod_3();
			}
			this.bool_2 = true;
		}

		// Token: 0x06001419 RID: 5145
		// RVA: 0x000124AB File Offset: 0x000106AB
		private void method_5(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.int_4 = 0;
			this.int_3 = 0;
		}

		// Token: 0x0600141A RID: 5146
		// RVA: 0x00067864 File Offset: 0x00065A64
		private void method_6()
		{
			int num = 0;
			try
			{
				num = this.stream_0.ReadByte();
			}
			catch (Exception)
			{
				Stream10.smethod_0();
			}
			if (num == -1)
			{
				Stream10.smethod_0();
			}
			this.int_3 = (this.int_3 << 8 | (num & 255));
			this.int_4 += 8;
		}

		// Token: 0x0600141B RID: 5147
		// RVA: 0x000678C8 File Offset: 0x00065AC8
		private int method_7(int int_25)
		{
			while (this.int_4 < int_25)
			{
				this.method_6();
			}
			int result = this.int_3 >> this.int_4 - int_25 & (1 << int_25) - 1;
			this.int_4 -= int_25;
			return result;
		}

		// Token: 0x0600141C RID: 5148
		// RVA: 0x000124C2 File Offset: 0x000106C2
		private char method_8()
		{
			return (char)this.method_7(8);
		}

		// Token: 0x0600141D RID: 5149
		// RVA: 0x000124CC File Offset: 0x000106CC
		private int method_9(int int_25)
		{
			return this.method_7(int_25);
		}

		// Token: 0x06001411 RID: 5137
		// RVA: 0x000675D8 File Offset: 0x000657D8
		public override int Read(byte[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("buffer");
			}
			for (int i = 0; i < count; i++)
			{
				int num = this.ReadByte();
				if (num == -1)
				{
					return i;
				}
				array[offset + i] = (byte)num;
			}
			return count;
		}

		// Token: 0x06001413 RID: 5139
		// RVA: 0x00067618 File Offset: 0x00065818
		public override int ReadByte()
		{
			if (this.bool_2)
			{
				return -1;
			}
			int result = this.int_12;
			switch (this.int_13)
			{
			case 3:
				this.method_16();
				break;
			case 4:
				this.method_17();
				break;
			case 6:
				this.method_18();
				break;
			case 7:
				this.method_19();
				break;
			}
			return result;
		}

		// Token: 0x0600140D RID: 5133
		// RVA: 0x00012436 File Offset: 0x00010636
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("BZip2InputStream Seek not supported");
		}

		// Token: 0x0600140E RID: 5134
		// RVA: 0x00012442 File Offset: 0x00010642
		public override void SetLength(long value)
		{
			throw new NotSupportedException("BZip2InputStream SetLength not supported");
		}

		// Token: 0x06001429 RID: 5161
		// RVA: 0x000124D5 File Offset: 0x000106D5
		private static void smethod_0()
		{
			throw new EndOfStreamException("BZip2 input stream end of compressed stream");
		}

		// Token: 0x0600142A RID: 5162
		// RVA: 0x000124E1 File Offset: 0x000106E1
		private static void smethod_1()
		{
			throw new Exception7("BZip2 input stream block overrun");
		}

		// Token: 0x0600142B RID: 5163
		// RVA: 0x000124ED File Offset: 0x000106ED
		private static void smethod_2()
		{
			throw new Exception7("BZip2 input stream bad block header");
		}

		// Token: 0x0600142C RID: 5164
		// RVA: 0x000124F9 File Offset: 0x000106F9
		private static void smethod_3()
		{
			throw new Exception7("BZip2 input stream crc error");
		}

		// Token: 0x0600142D RID: 5165
		// RVA: 0x000684D0 File Offset: 0x000666D0
		private static void smethod_4(int[] int_25, int[] int_26, int[] int_27, char[] char_0, int int_28, int int_29, int int_30)
		{
			int num = 0;
			for (int i = int_28; i <= int_29; i++)
			{
				for (int j = 0; j < int_30; j++)
				{
					if ((int)char_0[j] == i)
					{
						int_27[num] = j;
						num++;
					}
				}
			}
			for (int k = 0; k < 23; k++)
			{
				int_26[k] = 0;
			}
			for (int l = 0; l < int_30; l++)
			{
				int_26[(int)(char_0[l] + '\u0001')]++;
			}
			for (int m = 1; m < 23; m++)
			{
				int_26[m] += int_26[m - 1];
			}
			for (int n = 0; n < 23; n++)
			{
				int_25[n] = 0;
			}
			int num2 = 0;
			for (int num3 = int_28; num3 <= int_29; num3++)
			{
				num2 += int_26[num3 + 1] - int_26[num3];
				int_25[num3] = num2 - 1;
				num2 <<= 1;
			}
			for (int num4 = int_28 + 1; num4 <= int_29; num4++)
			{
				int_26[num4] = (int_25[num4 - 1] + 1 << 1) - int_26[num4];
			}
		}

		// Token: 0x0600140F RID: 5135
		// RVA: 0x0001244E File Offset: 0x0001064E
		public override void Write(byte[] array, int offset, int count)
		{
			throw new NotSupportedException("BZip2InputStream Write not supported");
		}

		// Token: 0x06001410 RID: 5136
		// RVA: 0x0001245A File Offset: 0x0001065A
		public override void WriteByte(byte value)
		{
			throw new NotSupportedException("BZip2InputStream WriteByte not supported");
		}
	}
}
