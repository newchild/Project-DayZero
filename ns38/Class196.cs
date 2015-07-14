using ns34;
using ns36;
using ns39;
using System;

namespace ns38
{
	// Token: 0x02000255 RID: 597
	internal sealed class Class196
	{
		// Token: 0x04000F67 RID: 3943
		private bool bool_0;

		// Token: 0x04000F6A RID: 3946
		private bool bool_1;

		// Token: 0x04000F70 RID: 3952
		private Class181 class181_0;

		// Token: 0x04000F6D RID: 3949
		private Class197 class197_0;

		// Token: 0x04000F6E RID: 3950
		private Class198 class198_0;

		// Token: 0x04000F6F RID: 3951
		private Class198 class198_1;

		// Token: 0x04000F6C RID: 3948
		private Class200 class200_0;

		// Token: 0x04000F6B RID: 3947
		private Class201 class201_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly int[] int_0 = new int[]
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

		// Token: 0x04000F5E RID: 3934
		private static readonly int[] int_1 = new int[]
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

		// Token: 0x04000F5F RID: 3935
		private static readonly int[] int_2 = new int[]
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

		// Token: 0x04000F60 RID: 3936
		private static readonly int[] int_3 = new int[]
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

		// Token: 0x04000F61 RID: 3937
		private int int_4;

		// Token: 0x04000F62 RID: 3938
		private int int_5;

		// Token: 0x04000F63 RID: 3939
		private int int_6;

		// Token: 0x04000F64 RID: 3940
		private int int_7;

		// Token: 0x04000F65 RID: 3941
		private int int_8;

		// Token: 0x04000F66 RID: 3942
		private int int_9;

		// Token: 0x04000F68 RID: 3944
		private long long_0;

		// Token: 0x04000F69 RID: 3945
		private long long_1;

		// Token: 0x060014B8 RID: 5304
		// RVA: 0x0001296F File Offset: 0x00010B6F
		public Class196() : this(false)
		{
		}

		// Token: 0x060014B9 RID: 5305
		// RVA: 0x00012978 File Offset: 0x00010B78
		public Class196(bool bool_2)
		{
			this.bool_1 = bool_2;
			this.class181_0 = new Class181();
			this.class201_0 = new Class201();
			this.class200_0 = new Class200();
			this.int_4 = (bool_2 ? 2 : 0);
		}

		// Token: 0x060014BA RID: 5306
		// RVA: 0x0006AFEC File Offset: 0x000691EC
		private bool method_0()
		{
			int num = this.class201_0.method_0(16);
			if (num < 0)
			{
				return false;
			}
			this.class201_0.method_1(16);
			num = ((num << 8 | num >> 8) & 65535);
			if (num % 31 != 0)
			{
				throw new Exception6("Header checksum illegal");
			}
			if ((num & 3840) != 2048)
			{
				throw new Exception6("Compression Method unknown");
			}
			if ((num & 32) == 0)
			{
				this.int_4 = 2;
			}
			else
			{
				this.int_4 = 1;
				this.int_6 = 32;
			}
			return true;
		}

		// Token: 0x060014BB RID: 5307
		// RVA: 0x0006B074 File Offset: 0x00069274
		private bool method_1()
		{
			while (this.int_6 > 0)
			{
				int num = this.class201_0.method_0(8);
				if (num < 0)
				{
					return false;
				}
				this.class201_0.method_1(8);
				this.int_5 = (this.int_5 << 8 | num);
				this.int_6 -= 8;
			}
			return false;
		}

		// Token: 0x060014BC RID: 5308
		// RVA: 0x0006B0CC File Offset: 0x000692CC
		private bool method_2()
		{
			int i = this.class200_0.method_2();
			while (i >= 258)
			{
				int num;
				switch (this.int_4)
				{
				case 7:
					while (((num = this.class198_0.method_1(this.class201_0)) & -256) == 0)
					{
						this.class200_0.Write(num);
						if (--i < 258)
						{
							return true;
						}
					}
					if (num >= 257)
					{
						try
						{
							this.int_7 = Class196.int_0[num - 257];
							this.int_6 = Class196.int_1[num - 257];
						}
						catch (Exception)
						{
							throw new Exception6("Illegal rep length code");
						}
						goto IL_AC;
					}
					if (num < 0)
					{
						return false;
					}
					this.class198_1 = null;
					this.class198_0 = null;
					this.int_4 = 2;
					return true;
				case 8:
					goto IL_AC;
				case 9:
					goto IL_FC;
				case 10:
					break;
				default:
					throw new Exception6("Inflater unknown mode");
				}
				IL_13D:
				if (this.int_6 > 0)
				{
					this.int_4 = 10;
					int num2 = this.class201_0.method_0(this.int_6);
					if (num2 < 0)
					{
						return false;
					}
					this.class201_0.method_1(this.int_6);
					this.int_8 += num2;
				}
				this.class200_0.Repeat(this.int_7, this.int_8);
				i -= this.int_7;
				this.int_4 = 7;
				continue;
				IL_FC:
				num = this.class198_1.method_1(this.class201_0);
				if (num >= 0)
				{
					try
					{
						this.int_8 = Class196.int_2[num];
						this.int_6 = Class196.int_3[num];
					}
					catch (Exception)
					{
						throw new Exception6("Illegal rep dist code");
					}
					goto IL_13D;
				}
				return false;
				IL_AC:
				if (this.int_6 > 0)
				{
					this.int_4 = 8;
					int num3 = this.class201_0.method_0(this.int_6);
					if (num3 < 0)
					{
						return false;
					}
					this.class201_0.method_1(this.int_6);
					this.int_7 += num3;
				}
				this.int_4 = 9;
				goto IL_FC;
			}
			return true;
		}

		// Token: 0x060014BD RID: 5309
		// RVA: 0x0006B2E0 File Offset: 0x000694E0
		private bool method_3()
		{
			while (this.int_6 > 0)
			{
				int num = this.class201_0.method_0(8);
				if (num < 0)
				{
					return false;
				}
				this.class201_0.method_1(8);
				this.int_5 = (this.int_5 << 8 | num);
				this.int_6 -= 8;
			}
			if ((int)this.class181_0.Value != this.int_5)
			{
				throw new Exception6(string.Concat(new object[]
				{
					"Adler chksum doesn't match: ",
					(int)this.class181_0.Value,
					" vs. ",
					this.int_5
				}));
			}
			this.int_4 = 12;
			return false;
		}

		// Token: 0x060014BE RID: 5310
		// RVA: 0x0006B39C File Offset: 0x0006959C
		private bool method_4()
		{
			switch (this.int_4)
			{
			case 0:
				return this.method_0();
			case 1:
				return this.method_1();
			case 2:
				if (this.bool_0)
				{
					if (this.bool_1)
					{
						this.int_4 = 12;
						return false;
					}
					this.class201_0.method_4();
					this.int_6 = 32;
					this.int_4 = 11;
					return true;
				}
				else
				{
					int num = this.class201_0.method_0(3);
					if (num < 0)
					{
						return false;
					}
					this.class201_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class201_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class198_0 = Class198.class198_0;
						this.class198_1 = Class198.class198_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class197_0 = new Class197();
						this.int_4 = 6;
						break;
					default:
						throw new Exception6("Unknown block type " + num);
					}
					return true;
				}
				break;
			case 3:
				if ((this.int_9 = this.class201_0.method_0(16)) < 0)
				{
					return false;
				}
				this.class201_0.method_1(16);
				this.int_4 = 4;
				break;
			case 4:
				break;
			case 5:
				goto IL_1A4;
			case 6:
				if (!this.class197_0.method_0(this.class201_0))
				{
					return false;
				}
				this.class198_0 = this.class197_0.method_1();
				this.class198_1 = this.class197_0.method_2();
				this.int_4 = 7;
				goto IL_228;
			case 7:
			case 8:
			case 9:
			case 10:
				goto IL_228;
			case 11:
				return this.method_3();
			case 12:
				return false;
			default:
				throw new Exception6("Inflater.Decode unknown mode");
			}
			int num2 = this.class201_0.method_0(16);
			if (num2 < 0)
			{
				return false;
			}
			this.class201_0.method_1(16);
			if (num2 != (this.int_9 ^ 65535))
			{
				throw new Exception6("broken uncompressed block");
			}
			this.int_4 = 5;
			IL_1A4:
			int num3 = this.class200_0.method_1(this.class201_0, this.int_9);
			this.int_9 -= num3;
			if (this.int_9 == 0)
			{
				this.int_4 = 2;
				return true;
			}
			return !this.class201_0.method_5();
			IL_228:
			return this.method_2();
		}

		// Token: 0x060014BF RID: 5311
		// RVA: 0x000129B5 File Offset: 0x00010BB5
		public void method_5(byte[] byte_0, int int_10, int int_11)
		{
			this.class201_0.method_7(byte_0, int_10, int_11);
			this.long_1 += (long)int_11;
		}

		// Token: 0x060014C0 RID: 5312
		// RVA: 0x0006B5E0 File Offset: 0x000697E0
		public int method_6(byte[] byte_0, int int_10, int int_11)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (int_11 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "count cannot be negative");
			}
			if (int_10 < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "offset cannot be negative");
			}
			if (int_10 + int_11 > byte_0.Length)
			{
				throw new ArgumentException("count exceeds buffer bounds");
			}
			if (int_11 == 0)
			{
				if (!this.method_9())
				{
					this.method_4();
				}
				return 0;
			}
			int num = 0;
			while (true)
			{
				if (this.int_4 != 11)
				{
					int num2 = this.class200_0.method_4(byte_0, int_10, int_11);
					if (num2 > 0)
					{
						this.class181_0.vmethod_0(byte_0, int_10, num2);
						int_10 += num2;
						num += num2;
						this.long_0 += (long)num2;
						int_11 -= num2;
						if (int_11 == 0)
						{
							return num;
						}
					}
				}
				if (!this.method_4())
				{
					if (this.class200_0.method_3() <= 0)
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

		// Token: 0x060014C1 RID: 5313
		// RVA: 0x000129D4 File Offset: 0x00010BD4
		public bool method_7()
		{
			return this.class201_0.method_5();
		}

		// Token: 0x060014C2 RID: 5314
		// RVA: 0x000129E1 File Offset: 0x00010BE1
		public bool method_8()
		{
			return this.int_4 == 1 && this.int_6 == 0;
		}

		// Token: 0x060014C3 RID: 5315
		// RVA: 0x000129F7 File Offset: 0x00010BF7
		public bool method_9()
		{
			return this.int_4 == 12 && this.class200_0.method_3() == 0;
		}
	}
}
