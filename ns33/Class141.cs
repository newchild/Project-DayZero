using System;

namespace ns33
{
	// Token: 0x020001EA RID: 490
	internal sealed class Class141
	{
		// Token: 0x04000D75 RID: 3445
		private bool bool_0;

		// Token: 0x04000D77 RID: 3447
		private static byte[] byte_0;

		// Token: 0x04000D76 RID: 3446
		internal Class139 class139_0;

		// Token: 0x04000D74 RID: 3444
		internal GClass1 gclass1_0;

		// Token: 0x04000D78 RID: 3448
		internal int int_0;

		// Token: 0x04000D79 RID: 3449
		internal int int_1;

		// Token: 0x04000D7A RID: 3450
		internal int int_2;

		// Token: 0x04000D7D RID: 3453
		internal int int_3;

		// Token: 0x04000D7B RID: 3451
		internal long long_0;

		// Token: 0x04000D7C RID: 3452
		internal long[] long_1;

		// Token: 0x06001145 RID: 4421
		// RVA: 0x0005DB20 File Offset: 0x0005BD20
		static Class141()
		{
			Class141.byte_0 = new byte[]
			{
				0,
				0,
				255,
				255
			};
		}

		// Token: 0x06001146 RID: 4422
		// RVA: 0x00010881 File Offset: 0x0000EA81
		public Class141(bool bool_1)
		{
			this.long_1 = new long[1];
			this.bool_0 = true;
			this.bool_0 = bool_1;
		}

		// Token: 0x06001149 RID: 4425
		// RVA: 0x0005E2D0 File Offset: 0x0005C4D0
		internal int Initialize(GClass1 gclass1_1, int int_4)
		{
			this.gclass1_0 = gclass1_1;
			this.gclass1_0.string_0 = null;
			this.class139_0 = null;
			if (int_4 >= 8 && int_4 <= 15)
			{
				this.int_3 = int_4;
				this.class139_0 = new Class139(gclass1_1, this.method_2() ? this : null, 1 << int_4);
				this.Reset();
				return 0;
			}
			this.method_0();
			throw new GException0("Bad window size.");
		}

		// Token: 0x06001147 RID: 4423
		// RVA: 0x000108A3 File Offset: 0x0000EAA3
		internal int method_0()
		{
			if (this.class139_0 != null)
			{
				this.class139_0.method_0();
			}
			this.class139_0 = null;
			return 0;
		}

		// Token: 0x06001148 RID: 4424
		// RVA: 0x0005DB4C File Offset: 0x0005BD4C
		internal int method_1(Enum15 enum15_0)
		{
			if (this.gclass1_0.byte_0 == null)
			{
				throw new GException0("InputBuffer is null. ");
			}
			int num = (enum15_0 == Enum15.const_4) ? -5 : 0;
			int num2 = -5;
			while (true)
			{
				switch (this.int_2)
				{
				case 0:
					if (this.gclass1_0.int_0 == 0)
					{
						return num2;
					}
					num2 = num;
					this.gclass1_0.int_0--;
					this.gclass1_0.long_1 += 1L;
					if (((this.int_1 = (int)this.gclass1_0.byte_0[this.gclass1_0.int_2++]) & 15) != 8)
					{
						this.int_2 = 13;
						this.gclass1_0.string_0 = string.Format("unknown compression method (0x{0:X2})", this.int_1);
						this.int_0 = 5;
						continue;
					}
					if ((this.int_1 >> 4) + 8 > this.int_3)
					{
						this.int_2 = 13;
						this.gclass1_0.string_0 = string.Format("invalid window size ({0})", (this.int_1 >> 4) + 8);
						this.int_0 = 5;
						continue;
					}
					this.int_2 = 1;
					goto IL_2F3;
				case 1:
					goto IL_2F3;
				case 2:
					goto IL_4FA;
				case 3:
					goto IL_57A;
				case 4:
					goto IL_605;
				case 5:
					goto IL_68F;
				case 6:
					goto IL_724;
				case 7:
					num2 = this.class139_0.method_1(num2);
					if (num2 == -3)
					{
						this.int_2 = 13;
						this.int_0 = 0;
						continue;
					}
					if (num2 == 0)
					{
						num2 = num;
					}
					if (num2 != 1)
					{
						return num2;
					}
					num2 = num;
					this.class139_0.Reset(this.long_1);
					if (!this.method_2())
					{
						this.int_2 = 12;
						continue;
					}
					this.int_2 = 8;
					goto IL_204;
				case 8:
					goto IL_204;
				case 9:
					goto IL_172;
				case 10:
					goto IL_E1;
				case 11:
					goto IL_2C;
				case 12:
					return 1;
				case 13:
					goto IL_75A;
				}
				goto Block_18;
				IL_2C:
				if (this.gclass1_0.int_0 == 0)
				{
					return num2;
				}
				num2 = num;
				this.gclass1_0.int_0--;
				this.gclass1_0.long_1 += 1L;
				this.long_0 += (long)((ulong)this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255uL);
				if ((int)this.long_1[0] != (int)this.long_0)
				{
					this.int_2 = 13;
					this.gclass1_0.string_0 = "incorrect data check";
					this.int_0 = 5;
					continue;
				}
				goto IL_750;
				IL_E1:
				if (this.gclass1_0.int_0 != 0)
				{
					num2 = num;
					this.gclass1_0.int_0--;
					this.gclass1_0.long_1 += 1L;
					this.long_0 += ((long)((long)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 8) & 65280L);
					this.int_2 = 11;
					goto IL_2C;
				}
				return num2;
				IL_172:
				if (this.gclass1_0.int_0 != 0)
				{
					num2 = num;
					this.gclass1_0.int_0--;
					this.gclass1_0.long_1 += 1L;
					this.long_0 += ((long)((long)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 16) & 16711680L);
					this.int_2 = 10;
					goto IL_E1;
				}
				return num2;
				IL_204:
				if (this.gclass1_0.int_0 != 0)
				{
					num2 = num;
					this.gclass1_0.int_0--;
					this.gclass1_0.long_1 += 1L;
					this.long_0 = (long)((int)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 24 & -16777216);
					this.int_2 = 9;
					goto IL_172;
				}
				return num2;
				IL_2F3:
				if (this.gclass1_0.int_0 == 0)
				{
					return num2;
				}
				num2 = num;
				this.gclass1_0.int_0--;
				this.gclass1_0.long_1 += 1L;
				int num3 = (int)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255);
				if (((this.int_1 << 8) + num3) % 31 != 0)
				{
					this.int_2 = 13;
					this.gclass1_0.string_0 = "incorrect header check";
					this.int_0 = 5;
				}
				else
				{
					if ((num3 & 32) != 0)
					{
						goto IL_4F3;
					}
					this.int_2 = 7;
				}
			}
			return num2;
			Block_18:
			throw new GException0("Stream error.");
			IL_4F3:
			this.int_2 = 2;
			IL_4FA:
			if (this.gclass1_0.int_0 == 0)
			{
				return num2;
			}
			num2 = num;
			this.gclass1_0.int_0--;
			this.gclass1_0.long_1 += 1L;
			this.long_0 = (long)((int)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 24 & -16777216);
			this.int_2 = 3;
			IL_57A:
			if (this.gclass1_0.int_0 == 0)
			{
				return num2;
			}
			num2 = num;
			this.gclass1_0.int_0--;
			this.gclass1_0.long_1 += 1L;
			this.long_0 += ((long)((long)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 16) & 16711680L);
			this.int_2 = 4;
			IL_605:
			if (this.gclass1_0.int_0 == 0)
			{
				return num2;
			}
			num2 = num;
			this.gclass1_0.int_0--;
			this.gclass1_0.long_1 += 1L;
			this.long_0 += ((long)((long)(this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255) << 8) & 65280L);
			this.int_2 = 5;
			IL_68F:
			if (this.gclass1_0.int_0 == 0)
			{
				return num2;
			}
			this.gclass1_0.int_0--;
			this.gclass1_0.long_1 += 1L;
			this.long_0 += (long)((ulong)this.gclass1_0.byte_0[this.gclass1_0.int_2++] & 255uL);
			this.gclass1_0.long_0 = this.long_0;
			this.int_2 = 6;
			return 2;
			IL_724:
			this.int_2 = 13;
			this.gclass1_0.string_0 = "need dictionary";
			this.int_0 = 0;
			return -2;
			IL_750:
			this.int_2 = 12;
			return 1;
			IL_75A:
			throw new GException0(string.Format("Bad state ({0})", this.gclass1_0.string_0));
		}

		// Token: 0x0600114B RID: 4427
		// RVA: 0x000108C0 File Offset: 0x0000EAC0
		internal bool method_2()
		{
			return this.bool_0;
		}

		// Token: 0x0600114A RID: 4426
		// RVA: 0x0005E344 File Offset: 0x0005C544
		internal int Reset()
		{
			GClass1 arg_23_0 = this.gclass1_0;
			this.gclass1_0.long_2 = 0L;
			arg_23_0.long_1 = 0L;
			this.gclass1_0.string_0 = null;
			this.int_2 = (this.method_2() ? 0 : 7);
			this.class139_0.Reset(null);
			return 0;
		}
	}
}
