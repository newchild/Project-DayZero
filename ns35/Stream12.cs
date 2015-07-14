using ns36;
using ns38;
using ns39;
using System;
using System.Collections;
using System.IO;

namespace ns35
{
	// Token: 0x02000274 RID: 628
	internal sealed class Stream12 : Stream11
	{
		// Token: 0x0400100E RID: 4110
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04001016 RID: 4118
		private bool bool_2;

		// Token: 0x04001015 RID: 4117
		private byte[] byte_1 = new byte[0];

		// Token: 0x0400100F RID: 4111
		private Class182 class182_0 = new Class182();

		// Token: 0x04001010 RID: 4112
		private Class205 class205_0;

		// Token: 0x04001019 RID: 4121
		private Enum24 enum24_0 = Enum24.const_2;

		// Token: 0x04001012 RID: 4114
		private Enum25 enum25_0 = Enum25.const_1;

		// Token: 0x04001011 RID: 4113
		private int int_0 = -1;

		// Token: 0x04001013 RID: 4115
		private long long_0;

		// Token: 0x04001014 RID: 4116
		private long long_1;

		// Token: 0x04001017 RID: 4119
		private long long_2 = -1L;

		// Token: 0x04001018 RID: 4120
		private long long_3 = -1L;

		// Token: 0x060015BD RID: 5565
		// RVA: 0x0006ECBC File Offset: 0x0006CEBC
		public Stream12(Stream stream_1) : base(stream_1, new Class189(-1, true))
		{
		}

		// Token: 0x060015C3 RID: 5571
		// RVA: 0x0006F5D4 File Offset: 0x0006D7D4
		private void method_10(long long_4)
		{
			this.long_1 += 12L;
			byte[] array = new byte[12];
			Random random = new Random();
			random.NextBytes(array);
			array[11] = (byte)(long_4 >> 24);
			base.method_3(array, 0, array.Length);
			this.stream_0.Write(array, 0, array.Length);
		}

		// Token: 0x060015C5 RID: 5573
		// RVA: 0x0006F6F0 File Offset: 0x0006D8F0
		private void method_11(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[4096];
			while (int_2 > 0)
			{
				int num = (int_2 < 4096) ? int_2 : 4096;
				Array.Copy(byte_2, int_1, array, 0, num);
				base.method_3(array, 0, num);
				this.stream_0.Write(array, 0, num);
				int_2 -= num;
				int_1 += num;
			}
		}

		// Token: 0x060015BE RID: 5566
		// RVA: 0x000135C6 File Offset: 0x000117C6
		private void method_5(int int_1)
		{
			this.stream_0.WriteByte((byte)(int_1 & 255));
			this.stream_0.WriteByte((byte)(int_1 >> 8 & 255));
		}

		// Token: 0x060015BF RID: 5567
		// RVA: 0x000135F0 File Offset: 0x000117F0
		private void method_6(int int_1)
		{
			this.method_5(int_1);
			this.method_5(int_1 >> 16);
		}

		// Token: 0x060015C0 RID: 5568
		// RVA: 0x00013603 File Offset: 0x00011803
		private void method_7(long long_4)
		{
			this.method_6((int)long_4);
			this.method_6((int)(long_4 >> 32));
		}

		// Token: 0x060015C1 RID: 5569
		// RVA: 0x0006ED2C File Offset: 0x0006CF2C
		public void method_8(Class205 class205_1)
		{
			if (class205_1 == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (this.arrayList_0 == null)
			{
				throw new InvalidOperationException("ZipOutputStream was finished");
			}
			if (this.class205_0 != null)
			{
				this.method_9();
			}
			if (this.arrayList_0.Count == 2147483647)
			{
				throw new Exception8("Too many entries for Zip file");
			}
			Enum25 enum = class205_1.method_29();
			int int_ = this.int_0;
			class205_1.method_5(class205_1.method_4() & 2048);
			this.bool_2 = false;
			bool flag = true;
			if (enum == Enum25.const_0)
			{
				class205_1.method_5(class205_1.method_4() & -9);
				if (class205_1.method_25() >= 0L)
				{
					if (class205_1.method_23() < 0L)
					{
						class205_1.method_24(class205_1.method_25());
					}
					else if (class205_1.method_23() != class205_1.method_25())
					{
						throw new Exception8("Method STORED, but compressed size != size");
					}
				}
				else if (class205_1.method_23() >= 0L)
				{
					class205_1.method_26(class205_1.method_23());
				}
				if (class205_1.method_23() < 0L || class205_1.method_27() < 0L)
				{
					if (base.method_0())
					{
						flag = false;
					}
					else
					{
						enum = Enum25.const_1;
						int_ = 0;
					}
				}
			}
			if (enum == Enum25.const_1)
			{
				if (class205_1.method_23() == 0L)
				{
					class205_1.method_26(class205_1.method_23());
					class205_1.method_28(0L);
					enum = Enum25.const_0;
				}
				else if (class205_1.method_25() < 0L || class205_1.method_23() < 0L || class205_1.method_27() < 0L)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (!base.method_0())
				{
					class205_1.method_5(class205_1.method_4() | 8);
				}
				else
				{
					this.bool_2 = true;
				}
			}
			if (base.method_1() != null)
			{
				class205_1.method_1(true);
				if (class205_1.method_27() < 0L)
				{
					class205_1.method_5(class205_1.method_4() | 8);
				}
			}
			class205_1.method_9(this.long_1);
			class205_1.method_30(enum);
			this.enum25_0 = enum;
			this.long_3 = -1L;
			if (this.enum24_0 == Enum24.const_1 || (class205_1.method_23() < 0L && this.enum24_0 == Enum24.const_2))
			{
				class205_1.method_15();
			}
			this.method_6(67324752);
			this.method_5(class205_1.Version);
			this.method_5(class205_1.method_4());
			this.method_5((int)((byte)enum));
			this.method_6((int)class205_1.method_19());
			if (flag)
			{
				this.method_6((int)class205_1.method_27());
				if (class205_1.method_17())
				{
					this.method_6(-1);
					this.method_6(-1);
				}
				else
				{
					this.method_6(class205_1.method_0() ? ((int)class205_1.method_25() + 12) : ((int)class205_1.method_25()));
					this.method_6((int)class205_1.method_23());
				}
			}
			else
			{
				if (this.bool_2)
				{
					this.long_2 = this.stream_0.Position;
				}
				this.method_6(0);
				if (this.bool_2)
				{
					this.long_3 = this.stream_0.Position;
				}
				if (class205_1.method_17() && this.bool_2)
				{
					this.method_6(-1);
					this.method_6(-1);
				}
				else
				{
					this.method_6(0);
					this.method_6(0);
				}
			}
			byte[] array = Class204.smethod_7(class205_1.method_4(), class205_1.Name);
			if (array.Length > 65535)
			{
				throw new Exception8("Entry name too long.");
			}
			Class207 class = new Class207(class205_1.method_31());
			if (class205_1.method_17() && (flag || this.bool_2))
			{
				class.method_4();
				if (flag)
				{
					class.method_8(class205_1.method_23());
					class.method_8(class205_1.method_25());
				}
				else
				{
					class.method_8(-1L);
					class.method_8(-1L);
				}
				class.method_5(1);
				if (!class.Find(1))
				{
					throw new Exception8("Internal error cant find extra data");
				}
				if (this.bool_2)
				{
					this.long_3 = (long)class.method_2();
				}
			}
			else
			{
				class.method_9(1);
			}
			byte[] array2 = class.method_0();
			this.method_5(array.Length);
			this.method_5(array2.Length);
			if (array.Length > 0)
			{
				this.stream_0.Write(array, 0, array.Length);
			}
			if (class205_1.method_17() && this.bool_2)
			{
				this.long_3 += this.stream_0.Position;
			}
			if (array2.Length > 0)
			{
				this.stream_0.Write(array2, 0, array2.Length);
			}
			this.long_1 += (long)(30 + array.Length + array2.Length);
			this.class205_0 = class205_1;
			this.class182_0.Reset();
			if (enum == Enum25.const_1)
			{
				this.class189_0.Reset();
				this.class189_0.method_5(int_);
			}
			this.long_0 = 0L;
			if (class205_1.method_0())
			{
				if (class205_1.method_27() < 0L)
				{
					this.method_10(class205_1.method_19() << 16);
					return;
				}
				this.method_10(class205_1.method_27());
			}
		}

		// Token: 0x060015C2 RID: 5570
		// RVA: 0x0006F22C File Offset: 0x0006D42C
		public void method_9()
		{
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("No open entry");
			}
			if (this.enum25_0 == Enum25.const_1)
			{
				base.vmethod_0();
			}
			long num = (this.enum25_0 == Enum25.const_1) ? this.class189_0.method_0() : this.long_0;
			if (this.class205_0.method_23() < 0L)
			{
				this.class205_0.method_24(this.long_0);
			}
			else if (this.class205_0.method_23() != this.long_0)
			{
				throw new Exception8(string.Concat(new object[]
				{
					"size was ",
					this.long_0,
					", but I expected ",
					this.class205_0.method_23()
				}));
			}
			if (this.class205_0.method_25() < 0L)
			{
				this.class205_0.method_26(num);
			}
			else if (this.class205_0.method_25() != num)
			{
				throw new Exception8(string.Concat(new object[]
				{
					"compressed size was ",
					num,
					", but I expected ",
					this.class205_0.method_25()
				}));
			}
			if (this.class205_0.method_27() < 0L)
			{
				this.class205_0.method_28(this.class182_0.Value);
			}
			else if (this.class205_0.method_27() != this.class182_0.Value)
			{
				throw new Exception8(string.Concat(new object[]
				{
					"crc was ",
					this.class182_0.Value,
					", but I expected ",
					this.class205_0.method_27()
				}));
			}
			this.long_1 += num;
			if (this.class205_0.method_0())
			{
				Class205 expr_1E6 = this.class205_0;
				expr_1E6.method_26(expr_1E6.method_25() + 12L);
			}
			if (this.bool_2)
			{
				this.bool_2 = false;
				long position = this.stream_0.Position;
				this.stream_0.Seek(this.long_2, SeekOrigin.Begin);
				this.method_6((int)this.class205_0.method_27());
				if (this.class205_0.method_17())
				{
					if (this.long_3 == -1L)
					{
						throw new Exception8("Entry requires zip64 but this has been turned off");
					}
					this.stream_0.Seek(this.long_3, SeekOrigin.Begin);
					this.method_7(this.class205_0.method_23());
					this.method_7(this.class205_0.method_25());
				}
				else
				{
					this.method_6((int)this.class205_0.method_25());
					this.method_6((int)this.class205_0.method_23());
				}
				this.stream_0.Seek(position, SeekOrigin.Begin);
			}
			if ((this.class205_0.method_4() & 8) != 0)
			{
				this.method_6(134695760);
				this.method_6((int)this.class205_0.method_27());
				if (this.class205_0.method_17())
				{
					this.method_7(this.class205_0.method_25());
					this.method_7(this.class205_0.method_23());
					this.long_1 += 24L;
				}
				else
				{
					this.method_6((int)this.class205_0.method_25());
					this.method_6((int)this.class205_0.method_23());
					this.long_1 += 16L;
				}
			}
			this.arrayList_0.Add(this.class205_0);
			this.class205_0 = null;
		}

		// Token: 0x060015C6 RID: 5574
		// RVA: 0x0006F74C File Offset: 0x0006D94C
		public override void vmethod_0()
		{
			if (this.arrayList_0 == null)
			{
				return;
			}
			if (this.class205_0 != null)
			{
				this.method_9();
			}
			long num = (long)this.arrayList_0.Count;
			long num2 = 0L;
			foreach (Class205 class in this.arrayList_0)
			{
				this.method_6(33639248);
				this.method_5(45);
				this.method_5(class.Version);
				this.method_5(class.method_4());
				this.method_5((int)((short)class.method_29()));
				this.method_6((int)class.method_19());
				this.method_6((int)class.method_27());
				if (!class.method_16() && class.method_25() < 4294967295L)
				{
					this.method_6((int)class.method_25());
				}
				else
				{
					this.method_6(-1);
				}
				if (!class.method_16() && class.method_23() < 4294967295L)
				{
					this.method_6((int)class.method_23());
				}
				else
				{
					this.method_6(-1);
				}
				byte[] array = Class204.smethod_7(class.method_4(), class.Name);
				if (array.Length > 65535)
				{
					throw new Exception8("Name too long.");
				}
				Class207 class2 = new Class207(class.method_31());
				if (class.method_18())
				{
					class2.method_4();
					if (class.method_16() || class.method_23() >= 4294967295L)
					{
						class2.method_8(class.method_23());
					}
					if (class.method_16() || class.method_25() >= 4294967295L)
					{
						class2.method_8(class.method_25());
					}
					if (class.method_8() >= 4294967295L)
					{
						class2.method_8(class.method_8());
					}
					class2.method_5(1);
				}
				else
				{
					class2.method_9(1);
				}
				byte[] array2 = class2.method_0();
				byte[] array3 = (class.method_34() != null) ? Class204.smethod_7(class.method_4(), class.method_34()) : new byte[0];
				if (array3.Length > 65535)
				{
					throw new Exception8("Comment too long.");
				}
				this.method_5(array.Length);
				this.method_5(array2.Length);
				this.method_5(array3.Length);
				this.method_5(0);
				this.method_5(0);
				if (class.method_10() != -1)
				{
					this.method_6(class.method_10());
				}
				else if (class.method_36())
				{
					this.method_6(16);
				}
				else
				{
					this.method_6(0);
				}
				if (class.method_8() >= 4294967295L)
				{
					this.method_6(-1);
				}
				else
				{
					this.method_6((int)class.method_8());
				}
				if (array.Length > 0)
				{
					this.stream_0.Write(array, 0, array.Length);
				}
				if (array2.Length > 0)
				{
					this.stream_0.Write(array2, 0, array2.Length);
				}
				if (array3.Length > 0)
				{
					this.stream_0.Write(array3, 0, array3.Length);
				}
				num2 += (long)(46 + array.Length + array2.Length + array3.Length);
			}
			using (Stream15 stream = new Stream15(this.stream_0))
			{
				stream.method_2(num, num2, this.long_1, this.byte_1);
			}
			this.arrayList_0 = null;
		}

		// Token: 0x060015C4 RID: 5572
		// RVA: 0x0006F630 File Offset: 0x0006D830
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("No open entry.");
			}
			if (array == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Invalid offset/count combination");
			}
			this.class182_0.vmethod_0(array, offset, count);
			this.long_0 += (long)count;
			Enum25 enum = this.enum25_0;
			if (enum != Enum25.const_0)
			{
				if (enum != Enum25.const_1)
				{
					return;
				}
				base.Write(array, offset, count);
				return;
			}
			else
			{
				if (base.method_1() != null)
				{
					this.method_11(array, offset, count);
					return;
				}
				this.stream_0.Write(array, offset, count);
				return;
			}
		}
	}
}
