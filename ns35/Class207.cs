using System;
using System.IO;

namespace ns35
{
	// Token: 0x0200026A RID: 618
	internal sealed class Class207 : IDisposable
	{
		// Token: 0x04000FEF RID: 4079
		private byte[] byte_0;

		// Token: 0x04000FEB RID: 4075
		private int int_0;

		// Token: 0x04000FEC RID: 4076
		private int int_1;

		// Token: 0x04000FED RID: 4077
		private int int_2;

		// Token: 0x04000FEE RID: 4078
		private MemoryStream memoryStream_0;

		// Token: 0x170002E4 RID: 740
		public int Length
		{
			// Token: 0x0600156A RID: 5482
			// RVA: 0x000131F1 File Offset: 0x000113F1
			get
			{
				return this.byte_0.Length;
			}
		}

		// Token: 0x06001568 RID: 5480
		// RVA: 0x000131A8 File Offset: 0x000113A8
		public Class207(byte[] byte_1)
		{
			if (byte_1 == null)
			{
				this.byte_0 = new byte[0];
				return;
			}
			this.byte_0 = byte_1;
		}

		// Token: 0x0600156F RID: 5487
		// RVA: 0x0006D788 File Offset: 0x0006B988
		public void AddEntry(int int_3, byte[] byte_1)
		{
			if (int_3 > 65535 || int_3 < 0)
			{
				throw new ArgumentOutOfRangeException("headerID");
			}
			int num = (byte_1 == null) ? 0 : byte_1.Length;
			if (num > 65535)
			{
				throw new ArgumentOutOfRangeException("fieldData", "exceeds maximum length");
			}
			int num2 = this.byte_0.Length + num + 4;
			if (this.Find(int_3))
			{
				num2 -= this.method_1() + 4;
			}
			if (num2 > 65535)
			{
				throw new Exception8("Data exceeds maximum length");
			}
			this.method_9(int_3);
			byte[] array = new byte[num2];
			this.byte_0.CopyTo(array, 0);
			int index = this.byte_0.Length;
			this.byte_0 = array;
			this.method_15(ref index, int_3);
			this.method_15(ref index, num);
			if (byte_1 != null)
			{
				byte_1.CopyTo(array, index);
			}
		}

		// Token: 0x0600157E RID: 5502
		// RVA: 0x00013302 File Offset: 0x00011502
		public void Dispose()
		{
			if (this.memoryStream_0 != null)
			{
				this.memoryStream_0.Close();
			}
		}

		// Token: 0x0600156E RID: 5486
		// RVA: 0x0006D6E4 File Offset: 0x0006B8E4
		public bool Find(int int_3)
		{
			this.int_1 = this.byte_0.Length;
			this.int_2 = 0;
			this.int_0 = 0;
			int num = this.int_1;
			int num2 = int_3 - 1;
			while (num2 != int_3 && this.int_0 < this.byte_0.Length - 3)
			{
				num2 = this.method_14();
				num = this.method_14();
				if (num2 != int_3)
				{
					this.int_0 += num;
				}
			}
			bool result;
			if (result = (num2 == int_3 && this.int_0 + num <= this.byte_0.Length))
			{
				this.int_1 = this.int_0;
				this.int_2 = num;
			}
			return result;
		}

		// Token: 0x06001569 RID: 5481
		// RVA: 0x000131C7 File Offset: 0x000113C7
		public byte[] method_0()
		{
			if (this.Length > 65535)
			{
				throw new Exception8("Data exceeds maximum length");
			}
			return (byte[])this.byte_0.Clone();
		}

		// Token: 0x0600156B RID: 5483
		// RVA: 0x000131FB File Offset: 0x000113FB
		public int method_1()
		{
			return this.int_2;
		}

		// Token: 0x06001576 RID: 5494
		// RVA: 0x000132A4 File Offset: 0x000114A4
		public long method_10()
		{
			this.method_13(8);
			return ((long)this.method_11() & 4294967295L) | (long)this.method_11() << 32;
		}

		// Token: 0x06001577 RID: 5495
		// RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		public int method_11()
		{
			this.method_13(4);
			int result = (int)this.byte_0[this.int_0] + ((int)this.byte_0[this.int_0 + 1] << 8) + ((int)this.byte_0[this.int_0 + 2] << 16) + ((int)this.byte_0[this.int_0 + 3] << 24);
			this.int_0 += 4;
			return result;
		}

		// Token: 0x06001578 RID: 5496
		// RVA: 0x0006D95C File Offset: 0x0006BB5C
		public int method_12()
		{
			this.method_13(2);
			int result = (int)this.byte_0[this.int_0] + ((int)this.byte_0[this.int_0 + 1] << 8);
			this.int_0 += 2;
			return result;
		}

		// Token: 0x0600157B RID: 5499
		// RVA: 0x0006D9F4 File Offset: 0x0006BBF4
		private void method_13(int int_3)
		{
			if (this.int_1 > this.byte_0.Length || this.int_1 < 4)
			{
				throw new Exception8("Find must be called before calling a Read method");
			}
			if (this.int_0 > this.int_1 + this.int_2 - int_3)
			{
				throw new Exception8("End of extra data");
			}
		}

		// Token: 0x0600157C RID: 5500
		// RVA: 0x0006DA48 File Offset: 0x0006BC48
		private int method_14()
		{
			if (this.int_0 > this.byte_0.Length - 2)
			{
				throw new Exception8("End of extra data");
			}
			int result = (int)this.byte_0[this.int_0] + ((int)this.byte_0[this.int_0 + 1] << 8);
			this.int_0 += 2;
			return result;
		}

		// Token: 0x0600157D RID: 5501
		// RVA: 0x000132E0 File Offset: 0x000114E0
		private void method_15(ref int int_3, int int_4)
		{
			this.byte_0[int_3] = (byte)int_4;
			this.byte_0[int_3 + 1] = (byte)(int_4 >> 8);
			int_3 += 2;
		}

		// Token: 0x0600156C RID: 5484
		// RVA: 0x00013203 File Offset: 0x00011403
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x0600156D RID: 5485
		// RVA: 0x0001320B File Offset: 0x0001140B
		public int method_3()
		{
			if (this.int_1 > this.byte_0.Length || this.int_1 < 4)
			{
				throw new Exception8("Find must be called before calling a Read method");
			}
			return this.int_1 + this.int_2 - this.int_0;
		}

		// Token: 0x06001570 RID: 5488
		// RVA: 0x00013245 File Offset: 0x00011445
		public void method_4()
		{
			this.memoryStream_0 = new MemoryStream();
		}

		// Token: 0x06001571 RID: 5489
		// RVA: 0x0006D854 File Offset: 0x0006BA54
		public void method_5(int int_3)
		{
			byte[] byte_ = this.memoryStream_0.ToArray();
			this.memoryStream_0 = null;
			this.AddEntry(int_3, byte_);
		}

		// Token: 0x06001572 RID: 5490
		// RVA: 0x00013252 File Offset: 0x00011452
		public void method_6(int int_3)
		{
			this.memoryStream_0.WriteByte((byte)int_3);
			this.memoryStream_0.WriteByte((byte)(int_3 >> 8));
		}

		// Token: 0x06001573 RID: 5491
		// RVA: 0x00013270 File Offset: 0x00011470
		public void method_7(int int_3)
		{
			this.method_6((int)((short)int_3));
			this.method_6((int)((short)(int_3 >> 16)));
		}

		// Token: 0x06001574 RID: 5492
		// RVA: 0x00013285 File Offset: 0x00011485
		public void method_8(long long_0)
		{
			this.method_7((int)(long_0 & 4294967295L));
			this.method_7((int)(long_0 >> 32));
		}

		// Token: 0x06001575 RID: 5493
		// RVA: 0x0006D87C File Offset: 0x0006BA7C
		public bool method_9(int int_3)
		{
			bool result = false;
			if (this.Find(int_3))
			{
				result = true;
				int num = this.int_1 - 4;
				byte[] destinationArray = new byte[this.byte_0.Length - (this.method_1() + 4)];
				Array.Copy(this.byte_0, 0, destinationArray, 0, num);
				int num2 = num + this.method_1() + 4;
				Array.Copy(this.byte_0, num2, destinationArray, num, this.byte_0.Length - num2);
				this.byte_0 = destinationArray;
			}
			return result;
		}

		// Token: 0x06001579 RID: 5497
		// RVA: 0x0006D9A0 File Offset: 0x0006BBA0
		public int ReadByte()
		{
			int result = -1;
			if (this.int_0 < this.byte_0.Length && this.int_1 + this.int_2 > this.int_0)
			{
				result = (int)this.byte_0[this.int_0];
				this.int_0++;
			}
			return result;
		}

		// Token: 0x0600157A RID: 5498
		// RVA: 0x000132C9 File Offset: 0x000114C9
		public void Skip(int int_3)
		{
			this.method_13(int_3);
			this.int_0 += int_3;
		}
	}
}
