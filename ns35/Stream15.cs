using System;
using System.IO;

namespace ns35
{
	// Token: 0x02000272 RID: 626
	internal sealed class Stream15 : Stream
	{
		// Token: 0x04001009 RID: 4105
		private bool bool_0;

		// Token: 0x0400100A RID: 4106
		private Stream stream_0;

		// Token: 0x170002E8 RID: 744
		public override bool CanRead
		{
			// Token: 0x0600159E RID: 5534
			// RVA: 0x00013410 File Offset: 0x00011610
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x170002E9 RID: 745
		public override bool CanSeek
		{
			// Token: 0x0600159F RID: 5535
			// RVA: 0x0001341D File Offset: 0x0001161D
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x170002EA RID: 746
		public override bool CanTimeout
		{
			// Token: 0x060015A0 RID: 5536
			// RVA: 0x0001342A File Offset: 0x0001162A
			get
			{
				return this.stream_0.CanTimeout;
			}
		}

		// Token: 0x170002EB RID: 747
		public override bool CanWrite
		{
			// Token: 0x060015A4 RID: 5540
			// RVA: 0x0001345F File Offset: 0x0001165F
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x170002EC RID: 748
		public override long Length
		{
			// Token: 0x060015A1 RID: 5537
			// RVA: 0x00013437 File Offset: 0x00011637
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x170002ED RID: 749
		public override long Position
		{
			// Token: 0x060015A2 RID: 5538
			// RVA: 0x00013444 File Offset: 0x00011644
			get
			{
				return this.stream_0.Position;
			}
			// Token: 0x060015A3 RID: 5539
			// RVA: 0x00013451 File Offset: 0x00011651
			set
			{
				this.stream_0.Position = value;
			}
		}

		// Token: 0x0600159D RID: 5533
		// RVA: 0x00013401 File Offset: 0x00011601
		public Stream15(Stream stream_1)
		{
			this.stream_0 = stream_1;
		}

		// Token: 0x060015AA RID: 5546
		// RVA: 0x0006E858 File Offset: 0x0006CA58
		public override void Close()
		{
			Stream stream = this.stream_0;
			this.stream_0 = null;
			if (this.bool_0 && stream != null)
			{
				this.bool_0 = false;
				stream.Close();
			}
		}

		// Token: 0x060015A5 RID: 5541
		// RVA: 0x0001346C File Offset: 0x0001166C
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x060015AB RID: 5547
		// RVA: 0x0006E88C File Offset: 0x0006CA8C
		public long method_0(int int_0, long long_0, int int_1, int int_2)
		{
			long num = long_0 - (long)int_1;
			if (num < 0L)
			{
				return -1L;
			}
			long num2 = Math.Max(num - (long)int_2, 0L);
			while (num >= num2)
			{
				long expr_33 = num;
				num = expr_33 - 1L;
				this.Seek(expr_33, SeekOrigin.Begin);
				if (this.method_4() == int_0)
				{
					return this.Position;
				}
			}
			return -1L;
		}

		// Token: 0x060015AC RID: 5548
		// RVA: 0x0006E900 File Offset: 0x0006CB00
		public void method_1(long long_0, long long_1, long long_2)
		{
			long position = this.stream_0.Position;
			this.method_7(101075792);
			this.method_9(44L);
			this.method_5(45);
			this.method_5(45);
			this.method_7(0);
			this.method_7(0);
			this.method_9(long_0);
			this.method_9(long_0);
			this.method_9(long_1);
			this.method_9(long_2);
			this.method_7(117853008);
			this.method_7(0);
			this.method_9(position);
			this.method_7(1);
		}

		// Token: 0x060015AD RID: 5549
		// RVA: 0x0006E990 File Offset: 0x0006CB90
		public void method_2(long long_0, long long_1, long long_2, byte[] byte_0)
		{
			if (long_0 >= 65535L || long_2 >= 4294967295L || long_1 >= 4294967295L)
			{
				this.method_1(long_0, long_1, long_2);
			}
			this.method_7(101010256);
			this.method_5(0);
			this.method_5(0);
			if (long_0 >= 65535L)
			{
				this.method_6(65535);
				this.method_6(65535);
			}
			else
			{
				this.method_5((int)((short)long_0));
				this.method_5((int)((short)long_0));
			}
			if (long_1 >= 4294967295L)
			{
				this.method_8(4294967295u);
			}
			else
			{
				this.method_7((int)long_1);
			}
			if (long_2 >= 4294967295L)
			{
				this.method_8(4294967295u);
			}
			else
			{
				this.method_7((int)long_2);
			}
			int num = (byte_0 != null) ? byte_0.Length : 0;
			if (num > 65535)
			{
				throw new Exception8(string.Format("Comment length({0}) is too long can only be 64K", num));
			}
			this.method_5(num);
			if (num > 0)
			{
				this.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x060015AE RID: 5550
		// RVA: 0x0006EA94 File Offset: 0x0006CC94
		public int method_3()
		{
			int num = this.stream_0.ReadByte();
			if (num < 0)
			{
				throw new EndOfStreamException();
			}
			int num2 = this.stream_0.ReadByte();
			if (num2 < 0)
			{
				throw new EndOfStreamException();
			}
			return num | num2 << 8;
		}

		// Token: 0x060015AF RID: 5551
		// RVA: 0x000134B6 File Offset: 0x000116B6
		public int method_4()
		{
			return this.method_3() | this.method_3() << 16;
		}

		// Token: 0x060015B0 RID: 5552
		// RVA: 0x000134C8 File Offset: 0x000116C8
		public void method_5(int int_0)
		{
			this.stream_0.WriteByte((byte)(int_0 & 255));
			this.stream_0.WriteByte((byte)(int_0 >> 8 & 255));
		}

		// Token: 0x060015B1 RID: 5553
		// RVA: 0x000134F2 File Offset: 0x000116F2
		public void method_6(ushort ushort_0)
		{
			this.stream_0.WriteByte((byte)(ushort_0 & 255));
			this.stream_0.WriteByte((byte)(ushort_0 >> 8));
		}

		// Token: 0x060015B2 RID: 5554
		// RVA: 0x00013516 File Offset: 0x00011716
		public void method_7(int int_0)
		{
			this.method_5(int_0);
			this.method_5(int_0 >> 16);
		}

		// Token: 0x060015B3 RID: 5555
		// RVA: 0x00013529 File Offset: 0x00011729
		public void method_8(uint uint_0)
		{
			this.method_6((ushort)(uint_0 & 65535u));
			this.method_6((ushort)(uint_0 >> 16));
		}

		// Token: 0x060015B4 RID: 5556
		// RVA: 0x00013544 File Offset: 0x00011744
		public void method_9(long long_0)
		{
			this.method_7((int)long_0);
			this.method_7((int)(long_0 >> 32));
		}

		// Token: 0x060015A8 RID: 5544
		// RVA: 0x00013496 File Offset: 0x00011696
		public override int Read(byte[] array, int offset, int count)
		{
			return this.stream_0.Read(array, offset, count);
		}

		// Token: 0x060015A6 RID: 5542
		// RVA: 0x00013479 File Offset: 0x00011679
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.stream_0.Seek(offset, origin);
		}

		// Token: 0x060015A7 RID: 5543
		// RVA: 0x00013488 File Offset: 0x00011688
		public override void SetLength(long value)
		{
			this.stream_0.SetLength(value);
		}

		// Token: 0x060015A9 RID: 5545
		// RVA: 0x000134A6 File Offset: 0x000116A6
		public override void Write(byte[] array, int offset, int count)
		{
			this.stream_0.Write(array, offset, count);
		}
	}
}
