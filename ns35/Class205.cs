using System;

namespace ns35
{
	// Token: 0x02000265 RID: 613
	internal sealed class Class205 : ICloneable
	{
		// Token: 0x02000266 RID: 614
		[Flags]
		private enum Enum26 : byte
		{
			// Token: 0x04000FD7 RID: 4055
			flag_0 = 0,
			// Token: 0x04000FD8 RID: 4056
			flag_1 = 1,
			// Token: 0x04000FD9 RID: 4057
			flag_2 = 2,
			// Token: 0x04000FDA RID: 4058
			flag_3 = 4,
			// Token: 0x04000FDB RID: 4059
			flag_4 = 8,
			// Token: 0x04000FDC RID: 4060
			flag_5 = 16
		}

		// Token: 0x04000FD4 RID: 4052
		private bool bool_0;

		// Token: 0x04000FCF RID: 4047
		private byte[] byte_0;

		// Token: 0x04000FD5 RID: 4053
		private byte byte_1;

		// Token: 0x04000FCE RID: 4046
		private Enum25 enum25_0 = Enum25.const_1;

		// Token: 0x04000FC5 RID: 4037
		private Class205.Enum26 enum26_0;

		// Token: 0x04000FC6 RID: 4038
		private int int_0 = -1;

		// Token: 0x04000FD1 RID: 4049
		private int int_1;

		// Token: 0x04000FD2 RID: 4050
		private long long_0 = -1L;

		// Token: 0x04000FD3 RID: 4051
		private long long_1;

		// Token: 0x04000FC8 RID: 4040
		private string string_0;

		// Token: 0x04000FD0 RID: 4048
		private string string_1;

		// Token: 0x04000FCC RID: 4044
		private uint uint_0;

		// Token: 0x04000FCD RID: 4045
		private uint uint_1;

		// Token: 0x04000FC9 RID: 4041
		private ulong ulong_0;

		// Token: 0x04000FCA RID: 4042
		private ulong ulong_1;

		// Token: 0x04000FC7 RID: 4039
		private ushort ushort_0;

		// Token: 0x04000FCB RID: 4043
		private ushort ushort_1;

		// Token: 0x170002E3 RID: 739
		public string Name
		{
			// Token: 0x0600154D RID: 5453
			// RVA: 0x00013018 File Offset: 0x00011218
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x170002E2 RID: 738
		public int Version
		{
			// Token: 0x06001544 RID: 5444
			// RVA: 0x0006CFAC File Offset: 0x0006B1AC
			get
			{
				if (this.ushort_1 != 0)
				{
					return (int)this.ushort_1;
				}
				int result = 10;
				if (this.method_18())
				{
					result = 45;
				}
				else if (Enum25.const_1 == this.enum25_0)
				{
					result = 20;
				}
				else if (this.method_36())
				{
					result = 20;
				}
				else if (this.method_0())
				{
					result = 20;
				}
				else if (this.method_13(8))
				{
					result = 11;
				}
				return result;
			}
		}

		// Token: 0x06001533 RID: 5427
		// RVA: 0x00012EB5 File Offset: 0x000110B5
		public Class205(string string_2) : this(string_2, 0, 45, Enum25.const_1)
		{
		}

		// Token: 0x06001534 RID: 5428
		// RVA: 0x0006CED8 File Offset: 0x0006B0D8
		internal Class205(string string_2, int int_2, int int_3, Enum25 enum25_1)
		{
			if (string_2 == null)
			{
				throw new ArgumentNullException("ZipEntry name");
			}
			if (string_2.Length > 65535)
			{
				throw new ArgumentException("Name is too long", "name");
			}
			if (int_2 != 0 && int_2 < 10)
			{
				throw new ArgumentOutOfRangeException("versionRequiredToExtract");
			}
			this.method_22(DateTime.Now);
			this.string_0 = string_2;
			this.ushort_0 = (ushort)int_3;
			this.ushort_1 = (ushort)int_2;
			this.enum25_0 = enum25_1;
		}

		// Token: 0x0600155E RID: 5470
		// RVA: 0x0006D444 File Offset: 0x0006B644
		public object Clone()
		{
			Class205 class = (Class205)base.MemberwiseClone();
			if (this.byte_0 != null)
			{
				class.byte_0 = new byte[this.byte_0.Length];
				Array.Copy(this.byte_0, 0, class.byte_0, 0, this.byte_0.Length);
			}
			return class;
		}

		// Token: 0x06001535 RID: 5429
		// RVA: 0x00012EC2 File Offset: 0x000110C2
		public bool method_0()
		{
			return (this.int_1 & 1) != 0;
		}

		// Token: 0x06001536 RID: 5430
		// RVA: 0x00012ED2 File Offset: 0x000110D2
		public void method_1(bool bool_1)
		{
			if (bool_1)
			{
				this.int_1 |= 1;
				return;
			}
			this.int_1 &= -2;
		}

		// Token: 0x0600153F RID: 5439
		// RVA: 0x00012F5B File Offset: 0x0001115B
		public int method_10()
		{
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_5) == 0)
			{
				return -1;
			}
			return this.int_0;
		}

		// Token: 0x06001540 RID: 5440
		// RVA: 0x00012F71 File Offset: 0x00011171
		public void method_11(int int_2)
		{
			this.int_0 = int_2;
			this.enum26_0 |= Class205.Enum26.flag_5;
		}

		// Token: 0x06001541 RID: 5441
		// RVA: 0x00012F8A File Offset: 0x0001118A
		public bool method_12()
		{
			return this.method_14() == 0 || this.method_14() == 10;
		}

		// Token: 0x06001542 RID: 5442
		// RVA: 0x0006CF70 File Offset: 0x0006B170
		private bool method_13(int int_2)
		{
			bool result = false;
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_5) != 0 && (this.method_14() == 0 || this.method_14() == 10) && (this.method_10() & int_2) == int_2)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001543 RID: 5443
		// RVA: 0x00012FA0 File Offset: 0x000111A0
		public int method_14()
		{
			return this.ushort_0 >> 8 & 255;
		}

		// Token: 0x06001545 RID: 5445
		// RVA: 0x00012FB0 File Offset: 0x000111B0
		public void method_15()
		{
			this.bool_0 = true;
		}

		// Token: 0x06001546 RID: 5446
		// RVA: 0x00012FB9 File Offset: 0x000111B9
		public bool method_16()
		{
			return this.bool_0;
		}

		// Token: 0x06001547 RID: 5447
		// RVA: 0x0006D010 File Offset: 0x0006B210
		public bool method_17()
		{
			bool result;
			if (!(result = this.bool_0))
			{
				ulong num = this.ulong_1;
				if (this.ushort_1 == 0 && this.method_0())
				{
					num += 12uL;
				}
				result = ((this.ulong_0 >= 4294967295uL || num >= 4294967295uL) && (this.ushort_1 == 0 || this.ushort_1 >= 45));
			}
			return result;
		}

		// Token: 0x06001548 RID: 5448
		// RVA: 0x00012FC1 File Offset: 0x000111C1
		public bool method_18()
		{
			return this.method_17() || this.long_1 >= 4294967295L;
		}

		// Token: 0x06001549 RID: 5449
		// RVA: 0x00012FE1 File Offset: 0x000111E1
		public long method_19()
		{
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_4) == 0)
			{
				return 0L;
			}
			return (long)((ulong)this.uint_1);
		}

		// Token: 0x06001537 RID: 5431
		// RVA: 0x00012EF5 File Offset: 0x000110F5
		public void method_2(bool bool_1)
		{
			if (bool_1)
			{
				this.int_1 |= 2048;
				return;
			}
			this.int_1 &= -2049;
		}

		// Token: 0x0600154A RID: 5450
		// RVA: 0x00012FFF File Offset: 0x000111FF
		public void method_20(long long_2)
		{
			this.uint_1 = (uint)long_2;
			this.enum26_0 |= Class205.Enum26.flag_4;
		}

		// Token: 0x0600154B RID: 5451
		// RVA: 0x0006D084 File Offset: 0x0006B284
		public DateTime method_21()
		{
			uint second = Math.Min(59u, 2u * (this.uint_1 & 31u));
			uint minute = Math.Min(59u, this.uint_1 >> 5 & 63u);
			uint hour = Math.Min(23u, this.uint_1 >> 11 & 31u);
			uint month = Math.Max(1u, Math.Min(12u, this.uint_1 >> 21 & 15u));
			uint year = (this.uint_1 >> 25 & 127u) + 1980u;
			int day = Math.Max(1, Math.Min(DateTime.DaysInMonth((int)year, (int)month), (int)(this.uint_1 >> 16 & 31u)));
			return new DateTime((int)year, (int)month, day, (int)hour, (int)minute, (int)second);
		}

		// Token: 0x0600154C RID: 5452
		// RVA: 0x0006D128 File Offset: 0x0006B328
		public void method_22(DateTime dateTime_0)
		{
			uint num = (uint)dateTime_0.Year;
			uint num2 = (uint)dateTime_0.Month;
			uint num3 = (uint)dateTime_0.Day;
			uint num4 = (uint)dateTime_0.Hour;
			uint num5 = (uint)dateTime_0.Minute;
			uint num6 = (uint)dateTime_0.Second;
			if (num < 1980u)
			{
				num = 1980u;
				num2 = 1u;
				num3 = 1u;
				num4 = 0u;
				num5 = 0u;
				num6 = 0u;
			}
			else if (num > 2107u)
			{
				num = 2107u;
				num2 = 12u;
				num3 = 31u;
				num4 = 23u;
				num5 = 59u;
				num6 = 59u;
			}
			this.method_20((long)((ulong)((num - 1980u & 127u) << 25 | num2 << 21 | num3 << 16 | num4 << 11 | num5 << 5 | num6 >> 1)));
		}

		// Token: 0x0600154E RID: 5454
		// RVA: 0x00013020 File Offset: 0x00011220
		public long method_23()
		{
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_1) == 0)
			{
				return -1L;
			}
			return (long)this.ulong_0;
		}

		// Token: 0x0600154F RID: 5455
		// RVA: 0x0001303D File Offset: 0x0001123D
		public void method_24(long long_2)
		{
			this.ulong_0 = (ulong)long_2;
			this.enum26_0 |= Class205.Enum26.flag_1;
		}

		// Token: 0x06001550 RID: 5456
		// RVA: 0x00013055 File Offset: 0x00011255
		public long method_25()
		{
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_2) == 0)
			{
				return -1L;
			}
			return (long)this.ulong_1;
		}

		// Token: 0x06001551 RID: 5457
		// RVA: 0x00013072 File Offset: 0x00011272
		public void method_26(long long_2)
		{
			this.ulong_1 = (ulong)long_2;
			this.enum26_0 |= Class205.Enum26.flag_2;
		}

		// Token: 0x06001552 RID: 5458
		// RVA: 0x0001308A File Offset: 0x0001128A
		public long method_27()
		{
			if ((byte)(this.enum26_0 & Class205.Enum26.flag_3) == 0)
			{
				return -1L;
			}
			return (long)((ulong)this.uint_0 & 4294967295uL);
		}

		// Token: 0x06001553 RID: 5459
		// RVA: 0x000130B2 File Offset: 0x000112B2
		public void method_28(long long_2)
		{
			this.uint_0 = (uint)long_2;
			this.enum26_0 |= Class205.Enum26.flag_3;
		}

		// Token: 0x06001554 RID: 5460
		// RVA: 0x000130CB File Offset: 0x000112CB
		public Enum25 method_29()
		{
			return this.enum25_0;
		}

		// Token: 0x06001538 RID: 5432
		// RVA: 0x00012F1F File Offset: 0x0001111F
		internal void method_3(byte byte_2)
		{
			this.byte_1 = byte_2;
		}

		// Token: 0x06001555 RID: 5461
		// RVA: 0x000130D3 File Offset: 0x000112D3
		public void method_30(Enum25 enum25_1)
		{
			if (!Class205.smethod_0(enum25_1))
			{
				throw new NotSupportedException("Compression method not supported");
			}
			this.enum25_0 = enum25_1;
		}

		// Token: 0x06001556 RID: 5462
		// RVA: 0x000130EF File Offset: 0x000112EF
		public byte[] method_31()
		{
			return this.byte_0;
		}

		// Token: 0x06001557 RID: 5463
		// RVA: 0x0006D1D0 File Offset: 0x0006B3D0
		public void method_32(byte[] byte_2)
		{
			if (byte_2 == null)
			{
				this.byte_0 = null;
				return;
			}
			if (byte_2.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			this.byte_0 = new byte[byte_2.Length];
			Array.Copy(byte_2, 0, this.byte_0, 0, byte_2.Length);
		}

		// Token: 0x06001558 RID: 5464
		// RVA: 0x0006D21C File Offset: 0x0006B41C
		internal void method_33(bool bool_1)
		{
			Class207 class = new Class207(this.byte_0);
			if (class.Find(1))
			{
				if ((this.ushort_1 & 255) < 45)
				{
					throw new Exception8("Zip64 Extended information found but version is not valid");
				}
				this.bool_0 = true;
				if (class.method_1() < 4)
				{
					throw new Exception8("Extra data extended Zip64 information length is invalid");
				}
				if (bool_1 || this.ulong_0 == 4294967295uL)
				{
					this.ulong_0 = (ulong)class.method_10();
				}
				if (bool_1 || this.ulong_1 == 4294967295uL)
				{
					this.ulong_1 = (ulong)class.method_10();
				}
				if (!bool_1 && this.long_1 == 4294967295L)
				{
					this.long_1 = class.method_10();
				}
			}
			else if ((this.ushort_1 & 255) >= 45 && (this.ulong_0 == 4294967295uL || this.ulong_1 == 4294967295uL))
			{
				throw new Exception8("Zip64 Extended information required but is missing.");
			}
			if (class.Find(10))
			{
				if (class.method_1() < 8)
				{
					throw new Exception8("NTFS Extra data invalid");
				}
				class.method_11();
				while (class.method_3() >= 4)
				{
					int num = class.method_12();
					int num2 = class.method_12();
					if (num == 1)
					{
						if (num2 >= 24)
						{
							long fileTime = class.method_10();
							class.method_10();
							class.method_10();
							this.method_22(DateTime.FromFileTime(fileTime));
							return;
						}
						return;
					}
					else
					{
						class.Skip(num2);
					}
				}
				return;
			}
			else if (class.Find(21589))
			{
				int num3 = class.method_1();
				int num4 = class.ReadByte();
				if ((num4 & 1) != 0 && num3 >= 5)
				{
					int seconds = class.method_11();
					this.method_22((new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime());
				}
			}
		}

		// Token: 0x06001559 RID: 5465
		// RVA: 0x000130F7 File Offset: 0x000112F7
		public string method_34()
		{
			return this.string_1;
		}

		// Token: 0x0600155A RID: 5466
		// RVA: 0x000130FF File Offset: 0x000112FF
		public void method_35(string string_2)
		{
			if (string_2 != null && string_2.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", "cannot exceed 65535");
			}
			this.string_1 = string_2;
		}

		// Token: 0x0600155B RID: 5467
		// RVA: 0x0006D3F4 File Offset: 0x0006B5F4
		public bool method_36()
		{
			int length = this.string_0.Length;
			int arg_41_0;
			if (length > 0)
			{
				if (this.string_0[length - 1] == '/' || this.string_0[length - 1] == '\\')
				{
					arg_41_0 = 1;
					return arg_41_0 != 0;
				}
			}
			arg_41_0 = (this.method_13(16) ? 1 : 0);
			return arg_41_0 != 0;
		}

		// Token: 0x0600155C RID: 5468
		// RVA: 0x00013128 File Offset: 0x00011328
		public bool method_37()
		{
			return !this.method_36() && !this.method_13(8);
		}

		// Token: 0x0600155D RID: 5469
		// RVA: 0x0001313E File Offset: 0x0001133E
		public bool method_38()
		{
			return Class205.smethod_0(this.method_29());
		}

		// Token: 0x06001539 RID: 5433
		// RVA: 0x00012F28 File Offset: 0x00011128
		public int method_4()
		{
			return this.int_1;
		}

		// Token: 0x0600153A RID: 5434
		// RVA: 0x00012F30 File Offset: 0x00011130
		public void method_5(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x0600153B RID: 5435
		// RVA: 0x00012F39 File Offset: 0x00011139
		public long method_6()
		{
			return this.long_0;
		}

		// Token: 0x0600153C RID: 5436
		// RVA: 0x00012F41 File Offset: 0x00011141
		public void method_7(long long_2)
		{
			this.long_0 = long_2;
		}

		// Token: 0x0600153D RID: 5437
		// RVA: 0x00012F4A File Offset: 0x0001114A
		public long method_8()
		{
			return this.long_1;
		}

		// Token: 0x0600153E RID: 5438
		// RVA: 0x00012F52 File Offset: 0x00011152
		public void method_9(long long_2)
		{
			this.long_1 = long_2;
		}

		// Token: 0x06001560 RID: 5472
		// RVA: 0x0001314B File Offset: 0x0001134B
		public static bool smethod_0(Enum25 enum25_1)
		{
			return enum25_1 == Enum25.const_1 || enum25_1 == Enum25.const_0;
		}

		// Token: 0x0600155F RID: 5471
		// RVA: 0x00013018 File Offset: 0x00011218
		public override string ToString()
		{
			return this.string_0;
		}
	}
}
