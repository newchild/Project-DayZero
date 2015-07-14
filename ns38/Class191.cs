using ns36;
using System;

namespace ns38
{
	// Token: 0x02000250 RID: 592
	internal sealed class Class191 : Class190
	{
		// Token: 0x04000F30 RID: 3888
		private bool bool_0;

		// Token: 0x04000F34 RID: 3892
		private byte[] byte_0;

		// Token: 0x04000F3B RID: 3899
		private byte[] byte_1;

		// Token: 0x04000F41 RID: 3905
		private Class181 class181_0;

		// Token: 0x04000F40 RID: 3904
		private Class192 class192_0;

		// Token: 0x04000F3F RID: 3903
		private Class195 class195_0;

		// Token: 0x04000F35 RID: 3893
		private Enum22 enum22_0;

		// Token: 0x04000F32 RID: 3890
		private int int_10;

		// Token: 0x04000F33 RID: 3891
		private int int_11;

		// Token: 0x04000F36 RID: 3894
		private int int_12;

		// Token: 0x04000F37 RID: 3895
		private int int_13;

		// Token: 0x04000F38 RID: 3896
		private int int_14;

		// Token: 0x04000F39 RID: 3897
		private int int_15;

		// Token: 0x04000F3A RID: 3898
		private int int_16;

		// Token: 0x04000F3C RID: 3900
		private int int_17;

		// Token: 0x04000F3D RID: 3901
		private int int_18;

		// Token: 0x04000F3E RID: 3902
		private int int_19;

		// Token: 0x04000F2B RID: 3883
		private int int_6;

		// Token: 0x04000F2E RID: 3886
		private int int_7;

		// Token: 0x04000F2F RID: 3887
		private int int_8;

		// Token: 0x04000F31 RID: 3889
		private int int_9;

		// Token: 0x04000F2C RID: 3884
		private short[] short_0;

		// Token: 0x04000F2D RID: 3885
		private short[] short_1;

		// Token: 0x06001485 RID: 5253
		// RVA: 0x00069178 File Offset: 0x00067378
		public Class191(Class195 class195_1)
		{
			this.class195_0 = class195_1;
			this.class192_0 = new Class192(class195_1);
			this.class181_0 = new Class181();
			this.byte_0 = new byte[65536];
			this.short_0 = new short[32768];
			this.short_1 = new short[32768];
			this.int_10 = 1;
			this.int_9 = 1;
		}

		// Token: 0x06001486 RID: 5254
		// RVA: 0x000691E8 File Offset: 0x000673E8
		public bool method_0(bool bool_1, bool bool_2)
		{
			while (true)
			{
				this.method_7();
				bool bool_3 = bool_1 && this.int_18 == this.int_19;
				bool flag;
				switch (this.int_16)
				{
				case 0:
					flag = this.method_12(bool_3, bool_2);
					goto IL_45;
				case 1:
					flag = this.method_13(bool_3, bool_2);
					goto IL_45;
				case 2:
					flag = this.method_14(bool_3, bool_2);
					goto IL_45;
				}
				break;
				IL_45:
				if (!this.class195_0.method_6())
				{
					return flag;
				}
				if (!flag)
				{
					return flag;
				}
			}
			throw new InvalidOperationException("unknown compressionFunction");
		}

		// Token: 0x06001487 RID: 5255
		// RVA: 0x00069268 File Offset: 0x00067468
		public void method_1(byte[] byte_2, int int_20, int int_21)
		{
			if (byte_2 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (int_20 < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (int_21 < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this.int_18 < this.int_19)
			{
				throw new InvalidOperationException("Old input was not completely processed");
			}
			int num = int_20 + int_21;
			if (int_20 > num || num > byte_2.Length)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.byte_1 = byte_2;
			this.int_18 = int_20;
			this.int_19 = num;
		}

		// Token: 0x06001491 RID: 5265
		// RVA: 0x00069664 File Offset: 0x00067864
		private void method_10()
		{
			Array.Copy(this.byte_0, 32768, this.byte_0, 0, 32768);
			this.int_7 -= 32768;
			this.int_10 -= 32768;
			this.int_9 -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = (int)this.short_0[i] & 65535;
				this.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = (int)this.short_1[j] & 65535;
				this.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}

		// Token: 0x06001492 RID: 5266
		// RVA: 0x00069738 File Offset: 0x00067938
		private bool method_11(int int_20)
		{
			int num = this.int_12;
			int num2 = this.int_14;
			short[] array = this.short_1;
			int num3 = this.int_10;
			int num4 = this.int_10 + this.int_8;
			int num5 = Math.Max(this.int_8, 2);
			int num6 = Math.Max(this.int_10 - 32506, 0);
			int num7 = this.int_10 + 258 - 1;
			byte b = this.byte_0[num4 - 1];
			byte b2 = this.byte_0[num4];
			if (num5 >= this.int_15)
			{
				num >>= 2;
			}
			if (num2 > this.int_11)
			{
				num2 = this.int_11;
			}
			do
			{
				if (this.byte_0[int_20 + num5] == b2 && this.byte_0[int_20 + num5 - 1] == b && this.byte_0[int_20] == this.byte_0[num3] && this.byte_0[int_20 + 1] == this.byte_0[num3 + 1])
				{
					int num8 = int_20 + 2;
					num3 += 2;
					while (this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && num3 < num7)
					{
					}
					if (num3 > num4)
					{
						this.int_7 = int_20;
						num4 = num3;
						num5 = num3 - this.int_10;
						if (num5 >= num2)
						{
							break;
						}
						b = this.byte_0[num4 - 1];
						b2 = this.byte_0[num4];
					}
					num3 = this.int_10;
				}
				if ((int_20 = ((int)array[int_20 & 32767] & 65535)) <= num6)
				{
					break;
				}
			}
			while (--num != 0);
			this.int_8 = Math.Min(num5, this.int_11);
			return this.int_8 >= 3;
		}

		// Token: 0x06001493 RID: 5267
		// RVA: 0x000699BC File Offset: 0x00067BBC
		private bool method_12(bool bool_1, bool bool_2)
		{
			if (!bool_1 && this.int_11 == 0)
			{
				return false;
			}
			this.int_10 += this.int_11;
			this.int_11 = 0;
			int num = this.int_10 - this.int_9;
			if (num < Class190.int_0 && (this.int_9 >= 32768 || num < 32506) && !bool_1)
			{
				return true;
			}
			bool flag = bool_2;
			if (num > Class190.int_0)
			{
				num = Class190.int_0;
				flag = false;
			}
			this.class192_0.method_2(this.byte_0, this.int_9, num, flag);
			this.int_9 += num;
			return !flag;
		}

		// Token: 0x06001494 RID: 5268
		// RVA: 0x00069A60 File Offset: 0x00067C60
		private bool method_13(bool bool_1, bool bool_2)
		{
			if (this.int_11 < 262 && !bool_1)
			{
				return false;
			}
			while (this.int_11 >= 262 || bool_1)
			{
				if (this.int_11 == 0)
				{
					this.class192_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, bool_2);
					this.int_9 = this.int_10;
					return false;
				}
				if (this.int_10 > 65274)
				{
					this.method_10();
				}
				int num;
				if (this.int_11 >= 3 && (num = this.method_9()) != 0 && this.enum22_0 != Enum22.const_2 && this.int_10 - num <= 32506 && this.method_11(num))
				{
					bool flag = this.class192_0.method_6(this.int_10 - this.int_7, this.int_8);
					this.int_11 -= this.int_8;
					if (this.int_8 <= this.int_13 && this.int_11 >= 3)
					{
						while (--this.int_8 > 0)
						{
							this.int_10++;
							this.method_9();
						}
						this.int_10++;
					}
					else
					{
						this.int_10 += this.int_8;
						if (this.int_11 >= 2)
						{
							this.method_8();
						}
					}
					this.int_8 = 2;
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					this.class192_0.method_5((int)(this.byte_0[this.int_10] & 255));
					this.int_10++;
					this.int_11--;
				}
				if (this.class192_0.method_4())
				{
					bool flag2 = bool_2 && this.int_11 == 0;
					this.class192_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, flag2);
					this.int_9 = this.int_10;
					return !flag2;
				}
			}
			return true;
		}

		// Token: 0x06001495 RID: 5269
		// RVA: 0x00069C78 File Offset: 0x00067E78
		private bool method_14(bool bool_1, bool bool_2)
		{
			if (this.int_11 < 262 && !bool_1)
			{
				return false;
			}
			while (this.int_11 >= 262 || bool_1)
			{
				if (this.int_11 == 0)
				{
					if (this.bool_0)
					{
						this.class192_0.method_5((int)(this.byte_0[this.int_10 - 1] & 255));
					}
					this.bool_0 = false;
					this.class192_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, bool_2);
					this.int_9 = this.int_10;
					return false;
				}
				if (this.int_10 >= 65274)
				{
					this.method_10();
				}
				int num = this.int_7;
				int num2 = this.int_8;
				if (this.int_11 >= 3)
				{
					int num3 = this.method_9();
					if (this.enum22_0 != Enum22.const_2 && num3 != 0 && this.int_10 - num3 <= 32506 && this.method_11(num3) && this.int_8 <= 5 && (this.enum22_0 == Enum22.const_1 || (this.int_8 == 3 && this.int_10 - this.int_7 > 4096)))
					{
						this.int_8 = 2;
					}
				}
				if (num2 >= 3 && this.int_8 <= num2)
				{
					this.class192_0.method_6(this.int_10 - 1 - num, num2);
					num2 -= 2;
					do
					{
						this.int_10++;
						this.int_11--;
						if (this.int_11 >= 3)
						{
							this.method_9();
						}
					}
					while (--num2 > 0);
					this.int_10++;
					this.int_11--;
					this.bool_0 = false;
					this.int_8 = 2;
				}
				else
				{
					if (this.bool_0)
					{
						this.class192_0.method_5((int)(this.byte_0[this.int_10 - 1] & 255));
					}
					this.bool_0 = true;
					this.int_10++;
					this.int_11--;
				}
				if (this.class192_0.method_4())
				{
					int num4 = this.int_10 - this.int_9;
					if (this.bool_0)
					{
						num4--;
					}
					bool flag = bool_2 && this.int_11 == 0 && !this.bool_0;
					this.class192_0.method_3(this.byte_0, this.int_9, num4, flag);
					this.int_9 += num4;
					return !flag;
				}
			}
			return true;
		}

		// Token: 0x06001488 RID: 5256
		// RVA: 0x000127BA File Offset: 0x000109BA
		public bool method_2()
		{
			return this.int_19 == this.int_18;
		}

		// Token: 0x0600148A RID: 5258
		// RVA: 0x000127CA File Offset: 0x000109CA
		public void method_3()
		{
			this.class181_0.Reset();
		}

		// Token: 0x0600148B RID: 5259
		// RVA: 0x000127D7 File Offset: 0x000109D7
		public int method_4()
		{
			return (int)this.class181_0.Value;
		}

		// Token: 0x0600148C RID: 5260
		// RVA: 0x000127E5 File Offset: 0x000109E5
		public void method_5(Enum22 enum22_1)
		{
			this.enum22_0 = enum22_1;
		}

		// Token: 0x0600148D RID: 5261
		// RVA: 0x00069368 File Offset: 0x00067568
		public void method_6(int int_20)
		{
			if (int_20 >= 0 && int_20 <= 9)
			{
				this.int_15 = Class190.int_1[int_20];
				this.int_13 = Class190.int_2[int_20];
				this.int_14 = Class190.int_3[int_20];
				this.int_12 = Class190.int_4[int_20];
				if (Class190.int_5[int_20] != this.int_16)
				{
					switch (this.int_16)
					{
					case 0:
						if (this.int_10 > this.int_9)
						{
							this.class192_0.method_2(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
							this.int_9 = this.int_10;
						}
						this.method_8();
						break;
					case 1:
						if (this.int_10 > this.int_9)
						{
							this.class192_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
							this.int_9 = this.int_10;
						}
						break;
					case 2:
						if (this.bool_0)
						{
							this.class192_0.method_5((int)(this.byte_0[this.int_10 - 1] & 255));
						}
						if (this.int_10 > this.int_9)
						{
							this.class192_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
							this.int_9 = this.int_10;
						}
						this.bool_0 = false;
						this.int_8 = 2;
						break;
					}
					this.int_16 = Class190.int_5[int_20];
				}
				return;
			}
			throw new ArgumentOutOfRangeException("level");
		}

		// Token: 0x0600148E RID: 5262
		// RVA: 0x00069508 File Offset: 0x00067708
		public void method_7()
		{
			if (this.int_10 >= 65274)
			{
				this.method_10();
			}
			while (this.int_11 < 262 && this.int_18 < this.int_19)
			{
				int num = 65536 - this.int_11 - this.int_10;
				if (num > this.int_19 - this.int_18)
				{
					num = this.int_19 - this.int_18;
				}
				Array.Copy(this.byte_1, this.int_18, this.byte_0, this.int_10 + this.int_11, num);
				this.class181_0.vmethod_0(this.byte_1, this.int_18, num);
				this.int_18 += num;
				this.int_17 += num;
				this.int_11 += num;
			}
			if (this.int_11 >= 3)
			{
				this.method_8();
			}
		}

		// Token: 0x0600148F RID: 5263
		// RVA: 0x000127EE File Offset: 0x000109EE
		private void method_8()
		{
			this.int_6 = ((int)this.byte_0[this.int_10] << 5 ^ (int)this.byte_0[this.int_10 + 1]);
		}

		// Token: 0x06001490 RID: 5264
		// RVA: 0x000695FC File Offset: 0x000677FC
		private int method_9()
		{
			int num = (this.int_6 << 5 ^ (int)this.byte_0[this.int_10 + 2]) & 32767;
			short num2 = this.short_1[this.int_10 & 32767] = this.short_0[num];
			this.short_0[num] = (short)this.int_10;
			this.int_6 = num;
			return (int)num2 & 65535;
		}

		// Token: 0x06001489 RID: 5257
		// RVA: 0x000692E8 File Offset: 0x000674E8
		public void Reset()
		{
			this.class192_0.Reset();
			this.class181_0.Reset();
			this.int_10 = 1;
			this.int_9 = 1;
			this.int_11 = 0;
			this.int_17 = 0;
			this.bool_0 = false;
			this.int_8 = 2;
			for (int i = 0; i < 32768; i++)
			{
				this.short_0[i] = 0;
			}
			for (int j = 0; j < 32768; j++)
			{
				this.short_1[j] = 0;
			}
		}
	}
}
