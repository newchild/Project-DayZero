using System;
using System.Collections.Generic;
using System.IO;

namespace ns33
{
	// Token: 0x020001EF RID: 495
	internal sealed class Stream5 : Stream
	{
		// Token: 0x020001F0 RID: 496
		internal enum Enum16
		{
			// Token: 0x04000DB4 RID: 3508
			const_0,
			// Token: 0x04000DB5 RID: 3509
			const_1,
			// Token: 0x04000DB6 RID: 3510
			const_2
		}

		// Token: 0x04000DAA RID: 3498
		protected internal bool bool_0;

		// Token: 0x04000DB1 RID: 3505
		private bool bool_1;

		// Token: 0x04000DA1 RID: 3489
		protected internal byte[] byte_0 = new byte[1];

		// Token: 0x04000DAE RID: 3502
		protected internal byte[] byte_1;

		// Token: 0x04000DA9 RID: 3497
		protected internal DateTime dateTime_0;

		// Token: 0x04000DAB RID: 3499
		protected internal Enum11 enum11_0;

		// Token: 0x04000DA3 RID: 3491
		protected internal Enum12 enum12_0;

		// Token: 0x04000DB2 RID: 3506
		protected internal Enum13 enum13_0;

		// Token: 0x04000DA5 RID: 3493
		protected internal Enum15 enum15_0;

		// Token: 0x04000DAD RID: 3501
		protected internal Stream5.Enum16 enum16_0 = Stream5.Enum16.const_2;

		// Token: 0x04000DA4 RID: 3492
		protected internal Enum17 enum17_0;

		// Token: 0x04000DB0 RID: 3504
		private GClass0 gclass0_0;

		// Token: 0x04000DAF RID: 3503
		protected internal GClass1 gclass1_0;

		// Token: 0x04000DA2 RID: 3490
		protected internal int int_0 = 8192;

		// Token: 0x04000DA8 RID: 3496
		protected internal int int_1;

		// Token: 0x04000DAC RID: 3500
		protected internal Stream stream_0;

		// Token: 0x04000DA6 RID: 3494
		protected internal string string_0;

		// Token: 0x04000DA7 RID: 3495
		protected internal string string_1;

		// Token: 0x1700029B RID: 667
		public override bool CanRead
		{
			// Token: 0x0600116A RID: 4458
			// RVA: 0x0001099F File Offset: 0x0000EB9F
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x1700029C RID: 668
		public override bool CanSeek
		{
			// Token: 0x0600116B RID: 4459
			// RVA: 0x000109AC File Offset: 0x0000EBAC
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x1700029D RID: 669
		public override bool CanWrite
		{
			// Token: 0x0600116C RID: 4460
			// RVA: 0x000109B9 File Offset: 0x0000EBB9
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x1700029E RID: 670
		public override long Length
		{
			// Token: 0x0600116E RID: 4462
			// RVA: 0x000109DD File Offset: 0x0000EBDD
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x1700029F RID: 671
		public override long Position
		{
			// Token: 0x0600116F RID: 4463
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
			// Token: 0x06001170 RID: 4464
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600115E RID: 4446
		// RVA: 0x0005F110 File Offset: 0x0005D310
		public Stream5(Stream stream_1, Enum12 enum12_1, Enum11 enum11_1, Enum17 enum17_1, bool bool_2)
		{
			this.stream_0 = stream_1;
			this.bool_0 = bool_2;
			this.enum12_0 = enum12_1;
			this.enum17_0 = enum17_1;
			this.enum11_0 = enum11_1;
			if (enum17_1 == Enum17.const_1)
			{
				this.gclass0_0 = new GClass0();
			}
		}

		// Token: 0x06001160 RID: 4448
		// RVA: 0x0005F2A4 File Offset: 0x0005D4A4
		public override void Close()
		{
			if (this.stream_0 != null)
			{
				try
				{
					this.method_2();
				}
				finally
				{
					this.method_1();
					if (!this.bool_0)
					{
						this.stream_0.Close();
					}
					this.stream_0 = null;
				}
			}
		}

		// Token: 0x06001163 RID: 4451
		// RVA: 0x00010979 File Offset: 0x0000EB79
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x0600115F RID: 4447
		// RVA: 0x0005F17C File Offset: 0x0005D37C
		private int method_0()
		{
			int num = 0;
			byte[] array = new byte[10];
			int num2 = this.stream_0.Read(array, 0, array.Length);
			if (num2 == 0)
			{
				return 0;
			}
			if (num2 != 10)
			{
				throw new GException0("Not a valid GZIP stream.");
			}
			if (array[0] == 31 && array[1] == 139)
			{
				if (array[2] == 8)
				{
					int num3 = BitConverter.ToInt32(array, 4);
					this.dateTime_0 = Stream4.dateTime_0.AddSeconds((double)num3);
					num += num2;
					if ((array[3] & 4) == 4)
					{
						num2 = this.stream_0.Read(array, 0, 2);
						num += num2;
						short num4 = (short)((int)array[0] + (int)array[1] * 256);
						byte[] array2 = new byte[(int)num4];
						num2 = this.stream_0.Read(array2, 0, array2.Length);
						if (num2 != (int)num4)
						{
							throw new GException0("Unexpected end-of-file reading GZIP header.");
						}
						num += num2;
					}
					if ((array[3] & 8) == 8)
					{
						this.string_1 = this.method_3();
					}
					if ((array[3] & 16) == 16)
					{
						this.string_0 = this.method_3();
					}
					if ((array[3] & 2) == 2)
					{
						this.Read(this.byte_0, 0, 1);
					}
					return num;
				}
			}
			throw new GException0("Bad GZIP header.");
		}

		// Token: 0x06001161 RID: 4449
		// RVA: 0x00010946 File Offset: 0x0000EB46
		private void method_1()
		{
			if (this.method_7() != null)
			{
				if (this.method_4())
				{
					this.gclass1_0.method_2();
				}
				else
				{
					this.gclass1_0.method_3();
				}
				this.gclass1_0 = null;
			}
		}

		// Token: 0x06001162 RID: 4450
		// RVA: 0x0005F2F4 File Offset: 0x0005D4F4
		private void method_2()
		{
			if (this.gclass1_0 != null)
			{
				if (this.enum16_0 == Stream5.Enum16.const_0)
				{
					bool flag;
					do
					{
						this.gclass1_0.byte_1 = this.method_6();
						this.gclass1_0.int_3 = 0;
						this.gclass1_0.int_1 = this.byte_1.Length;
						int num = this.method_4() ? this.gclass1_0.method_1(Enum15.const_4) : this.gclass1_0.method_5(Enum15.const_4);
						if (num != 1 && num != 0)
						{
							goto IL_11E;
						}
						if (this.byte_1.Length - this.gclass1_0.int_1 > 0)
						{
							this.stream_0.Write(this.byte_1, 0, this.byte_1.Length - this.gclass1_0.int_1);
						}
						flag = (this.gclass1_0.int_0 == 0 && this.gclass1_0.int_1 != 0);
						if (this.enum17_0 == Enum17.const_1 && !this.method_4())
						{
							flag = (this.gclass1_0.int_0 == 8 && this.gclass1_0.int_1 != 0);
						}
					}
					while (!flag);
					this.Flush();
					if (this.enum17_0 != Enum17.const_1)
					{
						return;
					}
					if (!this.method_4())
					{
						throw new GException0("Writing with decompression is not supported.");
					}
					int value = this.gclass0_0.method_1();
					this.stream_0.Write(BitConverter.GetBytes(value), 0, 4);
					int value2 = (int)(this.gclass0_0.method_2() & 4294967295L);
					this.stream_0.Write(BitConverter.GetBytes(value2), 0, 4);
					return;
					IL_11E:
					throw new GException0((this.method_4() ? "de" : "in") + "flating: " + this.gclass1_0.string_0);
				}
				if (this.enum16_0 == Stream5.Enum16.const_1 && this.enum17_0 == Enum17.const_1)
				{
					if (this.method_4())
					{
						throw new GException0("Reading with compression is not supported.");
					}
					if (this.gclass1_0.long_2 != 0L)
					{
						byte[] array = new byte[8];
						if (this.gclass1_0.int_0 != 8)
						{
							throw new GException0(string.Format("Protocol error. AvailableBytesIn={0}, expected 8", this.gclass1_0.int_0));
						}
						Array.Copy(this.gclass1_0.byte_0, this.gclass1_0.int_2, array, 0, array.Length);
						int num2 = BitConverter.ToInt32(array, 0);
						int num3 = this.gclass0_0.method_1();
						int num4 = BitConverter.ToInt32(array, 4);
						int num5 = (int)(this.gclass1_0.long_2 & 4294967295L);
						if (num3 != num2)
						{
							throw new GException0(string.Format("Bad CRC32 in GZIP stream. (actual({0:X8})!=expected({1:X8}))", num3, num2));
						}
						if (num5 != num4)
						{
							throw new GException0(string.Format("Bad size in GZIP stream. (actual({0})!=expected({1}))", num5, num4));
						}
					}
				}
			}
		}

		// Token: 0x06001165 RID: 4453
		// RVA: 0x0005F8A0 File Offset: 0x0005DAA0
		private string method_3()
		{
			List<byte> list = new List<byte>();
			bool flag = false;
			while (this.stream_0.Read(this.byte_0, 0, 1) == 1)
			{
				if (this.byte_0[0] == 0)
				{
					flag = true;
				}
				else
				{
					list.Add(this.byte_0[0]);
				}
				if (flag)
				{
					byte[] array = list.ToArray();
					return Stream4.encoding_0.GetString(array, 0, array.Length);
				}
			}
			throw new GException0("Unexpected EOF reading GZIP header.");
		}

		// Token: 0x06001169 RID: 4457
		// RVA: 0x00010994 File Offset: 0x0000EB94
		protected internal bool method_4()
		{
			return this.enum12_0 == Enum12.const_0;
		}

		// Token: 0x0600116D RID: 4461
		// RVA: 0x000109C6 File Offset: 0x0000EBC6
		internal int method_5()
		{
			if (this.gclass0_0 == null)
			{
				return 0;
			}
			return this.gclass0_0.method_1();
		}

		// Token: 0x06001171 RID: 4465
		// RVA: 0x000109EA File Offset: 0x0000EBEA
		private byte[] method_6()
		{
			if (this.byte_1 == null)
			{
				this.byte_1 = new byte[this.int_0];
			}
			return this.byte_1;
		}

		// Token: 0x06001172 RID: 4466
		// RVA: 0x0005FAB4 File Offset: 0x0005DCB4
		private GClass1 method_7()
		{
			if (this.gclass1_0 == null)
			{
				bool flag = this.enum17_0 == Enum17.const_2;
				this.gclass1_0 = new GClass1();
				if (this.enum12_0 == Enum12.const_1)
				{
					this.gclass1_0.method_7(flag);
				}
				else
				{
					this.gclass1_0.enum13_0 = this.enum13_0;
					this.gclass1_0.method_6(this.enum11_0, flag);
				}
			}
			return this.gclass1_0;
		}

		// Token: 0x06001164 RID: 4452
		// RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.enum16_0 == Stream5.Enum16.const_2)
			{
				if (!this.stream_0.CanRead)
				{
					throw new GException0("The stream is not readable.");
				}
				this.enum16_0 = Stream5.Enum16.const_1;
				this.method_7().int_0 = 0;
				if (this.enum17_0 == Enum17.const_1)
				{
					this.int_1 = this.method_0();
					if (this.int_1 == 0)
					{
						return 0;
					}
				}
			}
			if (this.enum16_0 != Stream5.Enum16.const_1)
			{
				throw new GException0("Cannot Read after Writing.");
			}
			if (count == 0)
			{
				return 0;
			}
			if (this.bool_1 && this.method_4())
			{
				return 0;
			}
			if (array == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (offset < array.GetLowerBound(0))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offset + count > array.GetLength(0))
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.gclass1_0.byte_1 = array;
			this.gclass1_0.int_3 = offset;
			this.gclass1_0.int_1 = count;
			this.gclass1_0.byte_0 = this.method_6();
			int num;
			while (true)
			{
				if (this.gclass1_0.int_0 == 0 && !this.bool_1)
				{
					this.gclass1_0.int_2 = 0;
					this.gclass1_0.int_0 = this.stream_0.Read(this.byte_1, 0, this.byte_1.Length);
					if (this.gclass1_0.int_0 == 0)
					{
						this.bool_1 = true;
					}
				}
				num = (this.method_4() ? this.gclass1_0.method_1(this.enum15_0) : this.gclass1_0.method_5(this.enum15_0));
				if (this.bool_1 && num == -5)
				{
					break;
				}
				if (num != 0 && num != 1)
				{
					goto Block_17;
				}
				if (((this.bool_1 || num == 1) && this.gclass1_0.int_1 == count) || this.gclass1_0.int_1 <= 0 || this.bool_1)
				{
					goto IL_234;
				}
				if (num != 0)
				{
					goto Block_21;
				}
			}
			return 0;
			Block_17:
			throw new GException0(string.Format("{0}flating:  rc={1}  msg={2}", this.method_4() ? "de" : "in", num, this.gclass1_0.string_0));
			Block_21:
			IL_234:
			if (this.gclass1_0.int_1 > 0)
			{
				if (num != 0)
				{
				}
				if (this.bool_1 && this.method_4())
				{
					num = this.gclass1_0.method_1(Enum15.const_4);
					if (num != 0 && num != 1)
					{
						throw new GException0(string.Format("Deflating:  rc={0}  msg={1}", num, this.gclass1_0.string_0));
					}
				}
			}
			num = count - this.gclass1_0.int_1;
			if (this.gclass0_0 != null)
			{
				this.gclass0_0.method_0(array, offset, num);
			}
			return num;
		}

		// Token: 0x06001166 RID: 4454
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001167 RID: 4455
		// RVA: 0x00010986 File Offset: 0x0000EB86
		public override void SetLength(long value)
		{
			this.stream_0.SetLength(value);
		}

		// Token: 0x06001168 RID: 4456
		// RVA: 0x0005F910 File Offset: 0x0005DB10
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.gclass0_0 != null)
			{
				this.gclass0_0.method_0(array, offset, count);
			}
			if (this.enum16_0 == Stream5.Enum16.const_2)
			{
				this.enum16_0 = Stream5.Enum16.const_0;
			}
			else if (this.enum16_0 != Stream5.Enum16.const_0)
			{
				throw new GException0("Cannot Write after Reading.");
			}
			if (count != 0)
			{
				this.method_7().byte_0 = array;
				this.gclass1_0.int_2 = offset;
				this.gclass1_0.int_0 = count;
				while (true)
				{
					this.gclass1_0.byte_1 = this.method_6();
					this.gclass1_0.int_3 = 0;
					this.gclass1_0.int_1 = this.byte_1.Length;
					int num = this.method_4() ? this.gclass1_0.method_1(this.enum15_0) : this.gclass1_0.method_5(this.enum15_0);
					if (num != 0 && num != 1)
					{
						break;
					}
					this.stream_0.Write(this.byte_1, 0, this.byte_1.Length - this.gclass1_0.int_1);
					bool flag = this.gclass1_0.int_0 == 0 && this.gclass1_0.int_1 != 0;
					if (this.enum17_0 == Enum17.const_1 && !this.method_4())
					{
						flag = (this.gclass1_0.int_0 == 8 && this.gclass1_0.int_1 != 0);
					}
					if (flag)
					{
						goto Block_11;
					}
				}
				throw new GException0((this.method_4() ? "de" : "in") + "flating: " + this.gclass1_0.string_0);
				Block_11:;
			}
		}
	}
}
