using System;

namespace ns38
{
	// Token: 0x0200024D RID: 589
	internal sealed class Class189
	{
		// Token: 0x04000F1C RID: 3868
		private bool bool_0;

		// Token: 0x04000F20 RID: 3872
		private Class191 class191_0;

		// Token: 0x04000F1F RID: 3871
		private Class195 class195_0;

		// Token: 0x04000F1B RID: 3867
		private int int_0;

		// Token: 0x04000F1D RID: 3869
		private int int_1;

		// Token: 0x04000F1E RID: 3870
		private long long_0;

		// Token: 0x06001478 RID: 5240
		// RVA: 0x00068E88 File Offset: 0x00067088
		public Class189(int int_2, bool bool_1)
		{
			if (int_2 == -1)
			{
				int_2 = 6;
			}
			else if (int_2 < 0 || int_2 > 9)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			this.class195_0 = new Class195();
			this.class191_0 = new Class191(this.class195_0);
			this.bool_0 = bool_1;
			this.method_6(Enum22.const_1);
			this.method_5(int_2);
			this.Reset();
		}

		// Token: 0x0600147B RID: 5243
		// RVA: 0x00012703 File Offset: 0x00010903
		public void Flush()
		{
			this.int_1 |= 4;
		}

		// Token: 0x0600147A RID: 5242
		// RVA: 0x000126FB File Offset: 0x000108FB
		public long method_0()
		{
			return this.long_0;
		}

		// Token: 0x0600147C RID: 5244
		// RVA: 0x00012713 File Offset: 0x00010913
		public void method_1()
		{
			this.int_1 |= 12;
		}

		// Token: 0x0600147D RID: 5245
		// RVA: 0x00012724 File Offset: 0x00010924
		public bool method_2()
		{
			return this.int_1 == 30 && this.class195_0.method_6();
		}

		// Token: 0x0600147E RID: 5246
		// RVA: 0x0001273D File Offset: 0x0001093D
		public bool method_3()
		{
			return this.class191_0.method_2();
		}

		// Token: 0x0600147F RID: 5247
		// RVA: 0x0001274A File Offset: 0x0001094A
		public void method_4(byte[] byte_0, int int_2, int int_3)
		{
			if ((this.int_1 & 8) != 0)
			{
				throw new InvalidOperationException("Finish() already called");
			}
			this.class191_0.method_1(byte_0, int_2, int_3);
		}

		// Token: 0x06001480 RID: 5248
		// RVA: 0x0001276F File Offset: 0x0001096F
		public void method_5(int int_2)
		{
			if (int_2 == -1)
			{
				int_2 = 6;
			}
			else if (int_2 < 0 || int_2 > 9)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			if (this.int_0 != int_2)
			{
				this.int_0 = int_2;
				this.class191_0.method_6(int_2);
			}
		}

		// Token: 0x06001481 RID: 5249
		// RVA: 0x000127AC File Offset: 0x000109AC
		public void method_6(Enum22 enum22_0)
		{
			this.class191_0.method_5(enum22_0);
		}

		// Token: 0x06001482 RID: 5250
		// RVA: 0x00068EF0 File Offset: 0x000670F0
		public int method_7(byte[] byte_0, int int_2, int int_3)
		{
			int num = int_3;
			if (this.int_1 == 127)
			{
				throw new InvalidOperationException("Deflater closed");
			}
			if (this.int_1 < 16)
			{
				int num2 = 30720;
				int num3 = this.int_0 - 1 >> 1;
				if (num3 < 0 || num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if ((this.int_1 & 1) != 0)
				{
					num2 |= 32;
				}
				num2 += 31 - num2 % 31;
				this.class195_0.method_5(num2);
				if ((this.int_1 & 1) != 0)
				{
					int num4 = this.class191_0.method_4();
					this.class191_0.method_3();
					this.class195_0.method_5(num4 >> 16);
					this.class195_0.method_5(num4 & 65535);
				}
				this.int_1 = (16 | (this.int_1 & 12));
			}
			while (true)
			{
				int num5 = this.class195_0.Flush(byte_0, int_2, int_3);
				int_2 += num5;
				this.long_0 += (long)num5;
				int_3 -= num5;
				if (int_3 == 0 || this.int_1 == 30)
				{
					goto IL_1E2;
				}
				if (!this.class191_0.method_0((this.int_1 & 4) != 0, (this.int_1 & 8) != 0))
				{
					if (this.int_1 == 16)
					{
						break;
					}
					if (this.int_1 == 20)
					{
						if (this.int_0 != 0)
						{
							for (int i = 8 + (-this.class195_0.method_2() & 7); i > 0; i -= 10)
							{
								this.class195_0.method_4(2, 10);
							}
						}
						this.int_1 = 16;
					}
					else if (this.int_1 == 28)
					{
						this.class195_0.method_3();
						if (!this.bool_0)
						{
							int num6 = this.class191_0.method_4();
							this.class195_0.method_5(num6 >> 16);
							this.class195_0.method_5(num6 & 65535);
						}
						this.int_1 = 30;
					}
				}
			}
			return num - int_3;
			IL_1E2:
			return num - int_3;
		}

		// Token: 0x06001479 RID: 5241
		// RVA: 0x000126C1 File Offset: 0x000108C1
		public void Reset()
		{
			this.int_1 = (this.bool_0 ? 16 : 0);
			this.long_0 = 0L;
			this.class195_0.Reset();
			this.class191_0.Reset();
		}
	}
}
