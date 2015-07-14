using System;

namespace ns33
{
	// Token: 0x020001E9 RID: 489
	internal sealed class Class140
	{
		// Token: 0x04000D65 RID: 3429
		internal byte byte_0;

		// Token: 0x04000D6B RID: 3435
		internal byte byte_1;

		// Token: 0x04000D66 RID: 3430
		internal int int_0;

		// Token: 0x04000D67 RID: 3431
		internal int[] int_1;

		// Token: 0x04000D71 RID: 3441
		internal int int_10;

		// Token: 0x04000D72 RID: 3442
		internal int[] int_11;

		// Token: 0x04000D73 RID: 3443
		internal int int_12;

		// Token: 0x04000D68 RID: 3432
		internal int int_2;

		// Token: 0x04000D69 RID: 3433
		internal int int_3;

		// Token: 0x04000D6A RID: 3434
		private static readonly int[] int_4 = new int[]
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

		// Token: 0x04000D6C RID: 3436
		internal int int_5;

		// Token: 0x04000D6D RID: 3437
		internal int int_6;

		// Token: 0x04000D6E RID: 3438
		internal int[] int_7;

		// Token: 0x04000D6F RID: 3439
		internal int int_8;

		// Token: 0x04000D70 RID: 3440
		internal int int_9;

		// Token: 0x06001140 RID: 4416
		// RVA: 0x00005E0F File Offset: 0x0000400F
		internal Class140()
		{
		}

		// Token: 0x06001141 RID: 4417
		// RVA: 0x0005CA40 File Offset: 0x0005AC40
		internal int method_0(int int_13, int int_14, int[] int_15, int int_16, int[] int_17, int int_18, Class139 class139_0, GClass1 gclass1_0)
		{
			int num = gclass1_0.int_2;
			int num2 = gclass1_0.int_0;
			int num3 = class139_0.int_1;
			int i = class139_0.int_2;
			int num4 = class139_0.int_15;
			int num5 = (num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4);
			int num6 = Class140.int_4[int_13];
			int num7 = Class140.int_4[int_14];
			int num10;
			int num11;
			while (true)
			{
				if (i >= 20)
				{
					int num8 = num3 & num6;
					int num9 = (int_16 + num8) * 3;
					num10 = int_15[num9];
					if (num10 == 0)
					{
						num3 >>= int_15[num9 + 1];
						i -= int_15[num9 + 1];
						class139_0.byte_0[num4++] = (byte)int_15[num9 + 2];
						num5--;
					}
					else
					{
						while (true)
						{
							num3 >>= int_15[num9 + 1];
							i -= int_15[num9 + 1];
							if ((num10 & 16) != 0)
							{
								break;
							}
							if ((num10 & 64) != 0)
							{
								goto IL_538;
							}
							num8 += int_15[num9 + 2];
							num8 += (num3 & Class140.int_4[num10]);
							num9 = (int_16 + num8) * 3;
							num10 = int_15[num9];
							if (num10 == 0)
							{
								goto IL_3F9;
							}
						}
						num10 &= 15;
						num11 = int_15[num9 + 2] + (num3 & Class140.int_4[num10]);
						num3 >>= num10;
						for (i -= num10; i < 15; i += 8)
						{
							num2--;
							num3 |= (int)(gclass1_0.byte_0[num++] & 255) << i;
						}
						num8 = (num3 & num7);
						num9 = (int_18 + num8) * 3;
						num10 = int_17[num9];
						while (true)
						{
							num3 >>= int_17[num9 + 1];
							i -= int_17[num9 + 1];
							if ((num10 & 16) != 0)
							{
								break;
							}
							if ((num10 & 64) != 0)
							{
								goto IL_451;
							}
							num8 += int_17[num9 + 2];
							num8 += (num3 & Class140.int_4[num10]);
							num9 = (int_18 + num8) * 3;
							num10 = int_17[num9];
						}
						num10 &= 15;
						while (i < num10)
						{
							num2--;
							num3 |= (int)(gclass1_0.byte_0[num++] & 255) << i;
							i += 8;
						}
						int num12 = int_17[num9 + 2] + (num3 & Class140.int_4[num10]);
						num3 >>= num10;
						i -= num10;
						num5 -= num11;
						int num13;
						if (num4 >= num12)
						{
							num13 = num4 - num12;
							if (num4 - num13 > 0 && 2 > num4 - num13)
							{
								class139_0.byte_0[num4++] = class139_0.byte_0[num13++];
								class139_0.byte_0[num4++] = class139_0.byte_0[num13++];
								num11 -= 2;
							}
							else
							{
								Array.Copy(class139_0.byte_0, num13, class139_0.byte_0, num4, 2);
								num4 += 2;
								num13 += 2;
								num11 -= 2;
							}
						}
						else
						{
							num13 = num4 - num12;
							do
							{
								num13 += class139_0.int_5;
							}
							while (num13 < 0);
							num10 = class139_0.int_5 - num13;
							if (num11 > num10)
							{
								num11 -= num10;
								if (num4 - num13 > 0 && num10 > num4 - num13)
								{
									do
									{
										class139_0.byte_0[num4++] = class139_0.byte_0[num13++];
									}
									while (--num10 != 0);
								}
								else
								{
									Array.Copy(class139_0.byte_0, num13, class139_0.byte_0, num4, num10);
									num4 += num10;
									num13 += num10;
								}
								num13 = 0;
							}
						}
						if (num4 - num13 > 0 && num11 > num4 - num13)
						{
							do
							{
								class139_0.byte_0[num4++] = class139_0.byte_0[num13++];
							}
							while (--num11 != 0);
							goto IL_42F;
						}
						Array.Copy(class139_0.byte_0, num13, class139_0.byte_0, num4, num11);
						num4 += num11;
						num13 += num11;
						goto IL_42F;
						IL_3F9:
						num3 >>= int_15[num9 + 1];
						i -= int_15[num9 + 1];
						class139_0.byte_0[num4++] = (byte)int_15[num9 + 2];
						num5--;
					}
					IL_42F:
					if (num5 < 258 || num2 < 10)
					{
						goto IL_4CB;
					}
				}
				else
				{
					num2--;
					num3 |= (int)(gclass1_0.byte_0[num++] & 255) << i;
					i += 8;
				}
			}
			IL_451:
			gclass1_0.string_0 = "invalid distance code";
			num11 = gclass1_0.int_0 - num2;
			num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
			num2 += num11;
			num -= num11;
			i -= num11 << 3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_0.int_0 = num2;
			gclass1_0.long_1 += (long)(num - gclass1_0.int_2);
			gclass1_0.int_2 = num;
			class139_0.int_15 = num4;
			return -3;
			IL_4CB:
			num11 = gclass1_0.int_0 - num2;
			num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
			num2 += num11;
			num -= num11;
			i -= num11 << 3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_0.int_0 = num2;
			gclass1_0.long_1 += (long)(num - gclass1_0.int_2);
			gclass1_0.int_2 = num;
			class139_0.int_15 = num4;
			return 0;
			IL_538:
			if ((num10 & 32) != 0)
			{
				num11 = gclass1_0.int_0 - num2;
				num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
				num2 += num11;
				num -= num11;
				i -= num11 << 3;
				class139_0.int_1 = num3;
				class139_0.int_2 = i;
				gclass1_0.int_0 = num2;
				gclass1_0.long_1 += (long)(num - gclass1_0.int_2);
				gclass1_0.int_2 = num;
				class139_0.int_15 = num4;
				return 1;
			}
			gclass1_0.string_0 = "invalid literal/length code";
			num11 = gclass1_0.int_0 - num2;
			num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
			num2 += num11;
			num -= num11;
			i -= num11 << 3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_0.int_0 = num2;
			gclass1_0.long_1 += (long)(num - gclass1_0.int_2);
			gclass1_0.int_2 = num;
			class139_0.int_15 = num4;
			return -3;
		}

		// Token: 0x06001142 RID: 4418
		// RVA: 0x00010829 File Offset: 0x0000EA29
		internal void method_1(int int_13, int int_14, int[] int_15, int int_16, int[] int_17, int int_18)
		{
			this.int_9 = 0;
			this.byte_1 = (byte)int_13;
			this.byte_0 = (byte)int_14;
			this.int_7 = int_15;
			this.int_8 = int_16;
			this.int_1 = int_17;
			this.int_2 = int_18;
			this.int_11 = null;
		}

		// Token: 0x06001143 RID: 4419
		// RVA: 0x0005D074 File Offset: 0x0005B274
		internal int method_2(Class139 class139_0, int int_13)
		{
			GClass1 gclass1_ = class139_0.gclass1_0;
			int num = gclass1_.int_2;
			int num2 = gclass1_.int_0;
			int num3 = class139_0.int_1;
			int i = class139_0.int_2;
			int num4 = class139_0.int_15;
			int num5 = (num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4);
			while (true)
			{
				int num6;
				switch (this.int_9)
				{
				case 0:
					if (num5 >= 258 && num2 >= 10)
					{
						class139_0.int_1 = num3;
						class139_0.int_2 = i;
						gclass1_.int_0 = num2;
						gclass1_.long_1 += (long)(num - gclass1_.int_2);
						gclass1_.int_2 = num;
						class139_0.int_15 = num4;
						int_13 = this.method_0((int)this.byte_1, (int)this.byte_0, this.int_7, this.int_8, this.int_1, this.int_2, class139_0, gclass1_);
						num = gclass1_.int_2;
						num2 = gclass1_.int_0;
						num3 = class139_0.int_1;
						i = class139_0.int_2;
						num4 = class139_0.int_15;
						num5 = ((num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
						if (int_13 != 0)
						{
							this.int_9 = ((int_13 == 1) ? 7 : 9);
							continue;
						}
					}
					this.int_10 = (int)this.byte_1;
					this.int_11 = this.int_7;
					this.int_12 = this.int_8;
					this.int_9 = 1;
					goto IL_43A;
				case 1:
					goto IL_43A;
				case 2:
					num6 = this.int_3;
					while (i < num6)
					{
						if (num2 == 0)
						{
							goto IL_78A;
						}
						int_13 = 0;
						num2--;
						num3 |= (int)(gclass1_.byte_0[num++] & 255) << i;
						i += 8;
					}
					this.int_5 += (num3 & Class140.int_4[num6]);
					num3 >>= num6;
					i -= num6;
					this.int_10 = (int)this.byte_0;
					this.int_11 = this.int_1;
					this.int_12 = this.int_2;
					this.int_9 = 3;
					goto IL_2D3;
				case 3:
					goto IL_2D3;
				case 4:
					num6 = this.int_3;
					while (i < num6)
					{
						if (num2 == 0)
						{
							goto IL_87E;
						}
						int_13 = 0;
						num2--;
						num3 |= (int)(gclass1_.byte_0[num++] & 255) << i;
						i += 8;
					}
					this.int_0 += (num3 & Class140.int_4[num6]);
					num3 >>= num6;
					i -= num6;
					this.int_9 = 5;
					goto IL_141;
				case 5:
					goto IL_141;
				case 6:
					if (num5 == 0)
					{
						if (num4 == class139_0.int_5 && class139_0.int_12 != 0)
						{
							num4 = 0;
							num5 = ((0 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
						}
						if (num5 == 0)
						{
							class139_0.int_15 = num4;
							int_13 = class139_0.Flush(int_13);
							num4 = class139_0.int_15;
							num5 = ((num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
							if (num4 == class139_0.int_5 && class139_0.int_12 != 0)
							{
								num4 = 0;
								num5 = ((0 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
							}
							if (num5 == 0)
							{
								goto IL_910;
							}
						}
					}
					int_13 = 0;
					class139_0.byte_0[num4++] = (byte)this.int_6;
					num5--;
					this.int_9 = 0;
					continue;
				case 7:
					goto IL_959;
				case 8:
					goto IL_A06;
				case 9:
					goto IL_A52;
				}
				break;
				IL_141:
				int j;
				for (j = num4 - this.int_0; j < 0; j += class139_0.int_5)
				{
				}
				while (this.int_5 != 0)
				{
					if (num5 == 0)
					{
						if (num4 == class139_0.int_5 && class139_0.int_12 != 0)
						{
							num4 = 0;
							num5 = ((0 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
						}
						if (num5 == 0)
						{
							class139_0.int_15 = num4;
							int_13 = class139_0.Flush(int_13);
							num4 = class139_0.int_15;
							num5 = ((num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
							if (num4 == class139_0.int_5 && class139_0.int_12 != 0)
							{
								num4 = 0;
								num5 = ((0 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4));
							}
							if (num5 == 0)
							{
								goto IL_8C7;
							}
						}
					}
					class139_0.byte_0[num4++] = class139_0.byte_0[j++];
					num5--;
					if (j == class139_0.int_5)
					{
						j = 0;
					}
					this.int_5--;
				}
				this.int_9 = 0;
				continue;
				IL_2D3:
				num6 = this.int_10;
				while (i < num6)
				{
					if (num2 == 0)
					{
						goto IL_835;
					}
					int_13 = 0;
					num2--;
					num3 |= (int)(gclass1_.byte_0[num++] & 255) << i;
					i += 8;
				}
				int num7 = (this.int_12 + (num3 & Class140.int_4[num6])) * 3;
				num3 >>= this.int_11[num7 + 1];
				i -= this.int_11[num7 + 1];
				int num8 = this.int_11[num7];
				if ((num8 & 16) != 0)
				{
					this.int_3 = (num8 & 15);
					this.int_0 = this.int_11[num7 + 2];
					this.int_9 = 4;
					continue;
				}
				if ((num8 & 64) == 0)
				{
					this.int_10 = num8;
					this.int_12 = num7 / 3 + this.int_11[num7 + 2];
					continue;
				}
				goto IL_7D3;
				IL_43A:
				num6 = this.int_10;
				while (i < num6)
				{
					if (num2 == 0)
					{
						goto IL_741;
					}
					int_13 = 0;
					num2--;
					num3 |= (int)(gclass1_.byte_0[num++] & 255) << i;
					i += 8;
				}
				num7 = (this.int_12 + (num3 & Class140.int_4[num6])) * 3;
				num3 = Class143.smethod_0(num3, this.int_11[num7 + 1]);
				i -= this.int_11[num7 + 1];
				num8 = this.int_11[num7];
				if (num8 == 0)
				{
					this.int_6 = this.int_11[num7 + 2];
					this.int_9 = 6;
				}
				else if ((num8 & 16) != 0)
				{
					this.int_3 = (num8 & 15);
					this.int_5 = this.int_11[num7 + 2];
					this.int_9 = 2;
				}
				else if ((num8 & 64) == 0)
				{
					this.int_10 = num8;
					this.int_12 = num7 / 3 + this.int_11[num7 + 2];
				}
				else
				{
					if ((num8 & 32) == 0)
					{
						goto IL_6DF;
					}
					this.int_9 = 7;
				}
			}
			int_13 = -2;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(-2);
			IL_6DF:
			this.int_9 = 9;
			gclass1_.string_0 = "invalid literal/length code";
			int_13 = -3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(-3);
			IL_741:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_78A:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_7D3:
			this.int_9 = 9;
			gclass1_.string_0 = "invalid distance code";
			int_13 = -3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(-3);
			IL_835:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_87E:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_8C7:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_910:
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(int_13);
			IL_959:
			if (i > 7)
			{
				i -= 8;
				num2++;
				num--;
			}
			class139_0.int_15 = num4;
			int_13 = class139_0.Flush(int_13);
			num4 = class139_0.int_15;
			int arg_9A6_0 = (num4 < class139_0.int_12) ? (class139_0.int_12 - num4 - 1) : (class139_0.int_5 - num4);
			if (class139_0.int_12 != class139_0.int_15)
			{
				class139_0.int_1 = num3;
				class139_0.int_2 = i;
				gclass1_.int_0 = num2;
				gclass1_.long_1 += (long)(num - gclass1_.int_2);
				gclass1_.int_2 = num;
				class139_0.int_15 = num4;
				return class139_0.Flush(int_13);
			}
			this.int_9 = 8;
			IL_A06:
			int_13 = 1;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(1);
			IL_A52:
			int_13 = -3;
			class139_0.int_1 = num3;
			class139_0.int_2 = i;
			gclass1_.int_0 = num2;
			gclass1_.long_1 += (long)(num - gclass1_.int_2);
			gclass1_.int_2 = num;
			class139_0.int_15 = num4;
			return class139_0.Flush(-3);
		}
	}
}
