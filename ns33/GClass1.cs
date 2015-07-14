using System;
using System.Runtime.InteropServices;

namespace ns33
{
	// Token: 0x020001F1 RID: 497
	[ComVisible(true), Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	public sealed class GClass1
	{
		// Token: 0x04000DBC RID: 3516
		public byte[] byte_0;

		// Token: 0x04000DC1 RID: 3521
		public byte[] byte_1;

		// Token: 0x04000DBB RID: 3515
		internal Class137 class137_0;

		// Token: 0x04000DBD RID: 3517
		internal Class141 class141_0;

		// Token: 0x04000DBA RID: 3514
		public Enum11 enum11_0;

		// Token: 0x04000DC2 RID: 3522
		public Enum13 enum13_0;

		// Token: 0x04000DB8 RID: 3512
		public int int_0;

		// Token: 0x04000DB9 RID: 3513
		public int int_1;

		// Token: 0x04000DBF RID: 3519
		public int int_2;

		// Token: 0x04000DC0 RID: 3520
		public int int_3;

		// Token: 0x04000DC5 RID: 3525
		public int int_4;

		// Token: 0x04000DB7 RID: 3511
		internal long long_0;

		// Token: 0x04000DC3 RID: 3523
		public long long_1;

		// Token: 0x04000DC4 RID: 3524
		public long long_2;

		// Token: 0x04000DBE RID: 3518
		public string string_0;

		// Token: 0x06001173 RID: 4467
		// RVA: 0x00010A0B File Offset: 0x0000EC0B
		public GClass1()
		{
			this.enum11_0 = Enum11.const_2;
			this.int_4 = 15;
			this.enum13_0 = Enum13.const_0;
		}

		// Token: 0x06001174 RID: 4468
		// RVA: 0x0005FB24 File Offset: 0x0005DD24
		private int method_0(bool bool_0)
		{
			if (this.class141_0 != null)
			{
				throw new GException0("You may not call InitializeDeflate() after calling InitializeInflate().");
			}
			this.class137_0 = new Class137();
			this.class137_0.method_32(bool_0);
			return this.class137_0.Initialize(this, this.enum11_0, this.int_4, this.enum13_0);
		}

		// Token: 0x06001175 RID: 4469
		// RVA: 0x00010A29 File Offset: 0x0000EC29
		public int method_1(Enum15 enum15_0)
		{
			if (this.class137_0 == null)
			{
				throw new GException0("No Deflate State!");
			}
			return this.class137_0.method_12(enum15_0);
		}

		// Token: 0x06001176 RID: 4470
		// RVA: 0x0005FB7C File Offset: 0x0005DD7C
		public int method_2()
		{
			if (this.class137_0 == null)
			{
				throw new GException0("No Deflate State!");
			}
			int result = this.class137_0.method_16();
			this.class137_0 = null;
			return result;
		}

		// Token: 0x06001177 RID: 4471
		// RVA: 0x0005FBB0 File Offset: 0x0005DDB0
		public int method_3()
		{
			if (this.class141_0 == null)
			{
				throw new GException0("No Inflate State!");
			}
			int result = this.class141_0.method_0();
			this.class141_0 = null;
			return result;
		}

		// Token: 0x06001178 RID: 4472
		// RVA: 0x0005FBE4 File Offset: 0x0005DDE4
		internal void method_4()
		{
			int int_ = this.class137_0.int_25;
			if (int_ > this.int_1)
			{
				int_ = this.int_1;
			}
			if (int_ != 0)
			{
				if (this.class137_0.byte_0.Length <= this.class137_0.int_23 || this.byte_1.Length <= this.int_3 || this.class137_0.byte_0.Length < this.class137_0.int_23 + int_ || this.byte_1.Length < this.int_3 + int_)
				{
					throw new GException0(string.Format("Invalid State. (pending.Length={0}, pendingCount={1})", this.class137_0.byte_0.Length, this.class137_0.int_25));
				}
				Array.Copy(this.class137_0.byte_0, this.class137_0.int_23, this.byte_1, this.int_3, int_);
				this.int_3 += int_;
				this.class137_0.int_23 += int_;
				this.long_2 += (long)int_;
				this.int_1 -= int_;
				this.class137_0.int_25 -= int_;
				if (this.class137_0.int_25 == 0)
				{
					this.class137_0.int_23 = 0;
				}
			}
		}

		// Token: 0x06001179 RID: 4473
		// RVA: 0x00010A4A File Offset: 0x0000EC4A
		public int method_5(Enum15 enum15_0)
		{
			if (this.class141_0 == null)
			{
				throw new GException0("No Inflate State!");
			}
			return this.class141_0.method_1(enum15_0);
		}

		// Token: 0x0600117A RID: 4474
		// RVA: 0x00010A6B File Offset: 0x0000EC6B
		public int method_6(Enum11 enum11_1, bool bool_0)
		{
			this.enum11_0 = enum11_1;
			return this.method_0(bool_0);
		}

		// Token: 0x0600117B RID: 4475
		// RVA: 0x00010A7B File Offset: 0x0000EC7B
		public int method_7(bool bool_0)
		{
			return this.method_8(this.int_4, bool_0);
		}

		// Token: 0x0600117C RID: 4476
		// RVA: 0x00010A8A File Offset: 0x0000EC8A
		public int method_8(int int_5, bool bool_0)
		{
			this.int_4 = int_5;
			if (this.class137_0 != null)
			{
				throw new GException0("You may not call InitializeInflate() after calling InitializeDeflate().");
			}
			this.class141_0 = new Class141(bool_0);
			return this.class141_0.Initialize(this, int_5);
		}

		// Token: 0x0600117D RID: 4477
		// RVA: 0x0005FD40 File Offset: 0x0005DF40
		internal int method_9(byte[] byte_2, int int_5, int int_6)
		{
			int num = this.int_0;
			if (num > int_6)
			{
				num = int_6;
			}
			if (num == 0)
			{
				return 0;
			}
			this.int_0 -= num;
			if (this.class137_0.method_31())
			{
				this.long_0 = Class136.smethod_0(this.long_0, this.byte_0, this.int_2, num);
			}
			Array.Copy(this.byte_0, this.int_2, byte_2, int_5, num);
			this.int_2 += num;
			this.long_1 += (long)num;
			return num;
		}
	}
}
