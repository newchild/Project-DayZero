using System;
using System.IO;
using System.Text;

namespace ns33
{
	// Token: 0x020001E7 RID: 487
	internal sealed class Stream4 : Stream
	{
		// Token: 0x04000D48 RID: 3400
		private bool bool_0;

		// Token: 0x04000D4A RID: 3402
		private bool bool_1;

		// Token: 0x04000D4C RID: 3404
		internal static DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x04000D4D RID: 3405
		internal static Encoding encoding_0 = Encoding.GetEncoding("iso-8859-1");

		// Token: 0x04000D47 RID: 3399
		private int int_0;

		// Token: 0x04000D4B RID: 3403
		private int int_1;

		// Token: 0x04000D4E RID: 3406
		public DateTime? nullable_0;

		// Token: 0x04000D45 RID: 3397
		internal Stream5 stream5_0;

		// Token: 0x04000D46 RID: 3398
		private string string_0;

		// Token: 0x04000D49 RID: 3401
		private string string_1;

		// Token: 0x17000296 RID: 662
		public override bool CanRead
		{
			// Token: 0x0600112F RID: 4399
			// RVA: 0x00010746 File Offset: 0x0000E946
			get
			{
				if (this.bool_0)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				return this.stream5_0.stream_0.CanRead;
			}
		}

		// Token: 0x17000297 RID: 663
		public override bool CanSeek
		{
			// Token: 0x06001130 RID: 4400
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000298 RID: 664
		public override bool CanWrite
		{
			// Token: 0x06001131 RID: 4401
			// RVA: 0x0001076B File Offset: 0x0000E96B
			get
			{
				if (this.bool_0)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				return this.stream5_0.stream_0.CanWrite;
			}
		}

		// Token: 0x17000299 RID: 665
		public override long Length
		{
			// Token: 0x06001136 RID: 4406
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700029A RID: 666
		public override long Position
		{
			// Token: 0x06001137 RID: 4407
			// RVA: 0x0005B6E4 File Offset: 0x000598E4
			get
			{
				if (this.stream5_0.enum16_0 == Stream5.Enum16.const_0)
				{
					return this.stream5_0.gclass1_0.long_2 + (long)this.int_1;
				}
				if (this.stream5_0.enum16_0 == Stream5.Enum16.const_1)
				{
					return this.stream5_0.gclass1_0.long_1 + (long)this.stream5_0.int_1;
				}
				return 0L;
			}
			// Token: 0x06001138 RID: 4408
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001126 RID: 4390
		// RVA: 0x000106FD File Offset: 0x0000E8FD
		public Stream4(Stream stream_0, Enum12 enum12_0, Enum11 enum11_0) : this(stream_0, enum12_0, enum11_0, false)
		{
		}

		// Token: 0x06001127 RID: 4391
		// RVA: 0x00010709 File Offset: 0x0000E909
		public Stream4(Stream stream_0, Enum12 enum12_0, Enum11 enum11_0, bool bool_2)
		{
			this.stream5_0 = new Stream5(stream_0, enum12_0, enum11_0, Enum17.const_1, bool_2);
		}

		// Token: 0x06001128 RID: 4392
		// RVA: 0x0005B388 File Offset: 0x00059588
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.bool_0)
				{
					if (disposing && this.stream5_0 != null)
					{
						this.stream5_0.Close();
						this.int_0 = this.stream5_0.method_5();
					}
					this.bool_0 = true;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600112A RID: 4394
		// RVA: 0x00010726 File Offset: 0x0000E926
		public override void Flush()
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			this.stream5_0.Flush();
		}

		// Token: 0x06001129 RID: 4393
		// RVA: 0x0005B3E8 File Offset: 0x000595E8
		private int method_0()
		{
			byte[] array = (this.method_1() == null) ? null : Stream4.encoding_0.GetBytes(this.method_1());
			byte[] array2 = (this.method_3() == null) ? null : Stream4.encoding_0.GetBytes(this.method_3());
			int num = (this.method_1() == null) ? 0 : (array.Length + 1);
			int num2 = (this.method_3() == null) ? 0 : (array2.Length + 1);
			int num3 = 10 + num + num2;
			byte[] array3 = new byte[num3];
			array3[0] = 31;
			array3[1] = 139;
			byte[] arg_8A_0 = array3;
			int arg_8A_1 = 2;
			int num4 = 3;
			arg_8A_0[arg_8A_1] = 8;
			byte b = 0;
			if (this.method_1() != null)
			{
				b ^= 16;
			}
			if (this.method_3() != null)
			{
				b ^= 8;
			}
			array3[num4++] = b;
			if (!this.nullable_0.HasValue)
			{
				this.nullable_0 = new DateTime?(DateTime.Now);
			}
			int value = (int)(this.nullable_0.Value - Stream4.dateTime_0).TotalSeconds;
			Array.Copy(BitConverter.GetBytes(value), 0, array3, num4, 4);
			num4 += 4;
			array3[num4++] = 0;
			array3[num4++] = 255;
			if (num2 != 0)
			{
				Array.Copy(array2, 0, array3, num4, num2 - 1);
				num4 += num2 - 1;
				array3[num4++] = 0;
			}
			if (num != 0)
			{
				Array.Copy(array, 0, array3, num4, num - 1);
				num4 += num - 1;
				array3[num4++] = 0;
			}
			this.stream5_0.stream_0.Write(array3, 0, array3.Length);
			return array3.Length;
		}

		// Token: 0x06001132 RID: 4402
		// RVA: 0x00010790 File Offset: 0x0000E990
		public string method_1()
		{
			return this.string_0;
		}

		// Token: 0x06001133 RID: 4403
		// RVA: 0x00010798 File Offset: 0x0000E998
		public void method_2(string string_2)
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			this.string_0 = string_2;
		}

		// Token: 0x06001134 RID: 4404
		// RVA: 0x000107B4 File Offset: 0x0000E9B4
		public string method_3()
		{
			return this.string_1;
		}

		// Token: 0x06001135 RID: 4405
		// RVA: 0x0005B644 File Offset: 0x00059844
		public void method_4(string string_2)
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			this.string_1 = string_2;
			if (this.string_1 != null)
			{
				if (this.string_1.IndexOf("/") != -1)
				{
					this.string_1 = this.string_1.Replace("/", "\\");
				}
				if (this.string_1.EndsWith("\\"))
				{
					throw new Exception("Illegal filename");
				}
				if (this.string_1.IndexOf("\\") != -1)
				{
					this.string_1 = Path.GetFileName(this.string_1);
				}
			}
		}

		// Token: 0x0600112B RID: 4395
		// RVA: 0x0005B584 File Offset: 0x00059784
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			int result = this.stream5_0.Read(array, offset, count);
			if (!this.bool_1)
			{
				this.bool_1 = true;
				this.method_4(this.stream5_0.string_1);
				this.method_2(this.stream5_0.string_0);
			}
			return result;
		}

		// Token: 0x0600112C RID: 4396
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600112D RID: 4397
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600112E RID: 4398
		// RVA: 0x0005B5E8 File Offset: 0x000597E8
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			if (this.stream5_0.enum16_0 == Stream5.Enum16.const_2)
			{
				if (!this.stream5_0.method_4())
				{
					throw new InvalidOperationException();
				}
				this.int_1 = this.method_0();
			}
			this.stream5_0.Write(array, offset, count);
		}
	}
}
