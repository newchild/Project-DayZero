using System;
using System.IO;
using System.Text;

namespace ns30
{
	// Token: 0x020001F7 RID: 503
	internal sealed class Stream6 : Stream
	{
		// Token: 0x04000DD8 RID: 3544
		private bool bool_0;

		// Token: 0x04000DD9 RID: 3545
		private bool bool_1;

		// Token: 0x04000DD4 RID: 3540
		private long long_0;

		// Token: 0x04000DD6 RID: 3542
		private long long_1;

		// Token: 0x04000DDA RID: 3546
		private long long_2;

		// Token: 0x04000DD7 RID: 3543
		private Stream stream_0;

		// Token: 0x04000DD5 RID: 3541
		private string string_0;

		// Token: 0x170002A0 RID: 672
		public override bool CanRead
		{
			// Token: 0x06001190 RID: 4496
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002A1 RID: 673
		public override bool CanSeek
		{
			// Token: 0x06001191 RID: 4497
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x170002A2 RID: 674
		public override bool CanWrite
		{
			// Token: 0x06001192 RID: 4498
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x170002A5 RID: 677
		public bool IsCompleted
		{
			// Token: 0x06001193 RID: 4499
			// RVA: 0x00010B1C File Offset: 0x0000ED1C
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x170002A3 RID: 675
		public override long Length
		{
			// Token: 0x06001194 RID: 4500
			// RVA: 0x00010B24 File Offset: 0x0000ED24
			get
			{
				return this.long_2;
			}
		}

		// Token: 0x170002A4 RID: 676
		public override long Position
		{
			// Token: 0x06001195 RID: 4501
			// RVA: 0x00010B2C File Offset: 0x0000ED2C
			get
			{
				return this.Seek(0L, SeekOrigin.Current);
			}
			// Token: 0x06001196 RID: 4502
			// RVA: 0x00010B3E File Offset: 0x0000ED3E
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x06001187 RID: 4487
		// RVA: 0x0005FED0 File Offset: 0x0005E0D0
		public Stream6(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.string_0 = string.Empty;
			this.bool_1 = false;
			this.long_0 = 0L;
			this.long_1 = 0L;
			this.bool_0 = false;
			this.long_2 = 0L;
		}

		// Token: 0x06001188 RID: 4488
		// RVA: 0x00010B0F File Offset: 0x0000ED0F
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x06001189 RID: 4489
		// RVA: 0x0005FF30 File Offset: 0x0005E130
		private string method_0(byte[] byte_0, int int_0, int int_1)
		{
			int num = 0;
			for (int i = int_0; i < int_0 + int_1; i++)
			{
				byte b = byte_0[i];
				if ((b < 48 || b > 57) && (b < 97 || b > 102) && (b < 65 || b > 70))
				{
					break;
				}
				num++;
			}
			return Encoding.ASCII.GetString(byte_0, int_0, num);
		}

		// Token: 0x0600118B RID: 4491
		// RVA: 0x0005FF80 File Offset: 0x0005E180
		private bool method_1(byte[] byte_0, ref int int_0, int int_1)
		{
			bool result = false;
			if (this.long_0 > 0L)
			{
				int num = int_1 - int_0;
				if (num > (int)(this.long_0 - this.long_1))
				{
					num = (int)(this.long_0 - this.long_1);
				}
				this.stream_0.Write(byte_0, int_0, num);
				int_0 += num;
				this.long_1 += (long)num;
			}
			if (this.long_1 == this.long_0)
			{
				while (int_0 < int_1)
				{
					if (byte_0[int_0] == 10)
					{
						int_0++;
						result = true;
						if (this.long_0 == 0L)
						{
							this.bool_0 = true;
						}
						return result;
					}
					int_0++;
				}
			}
			return result;
		}

		// Token: 0x0600118C RID: 4492
		// RVA: 0x00060034 File Offset: 0x0005E234
		private bool method_2(byte[] byte_0, ref int int_0, int int_1)
		{
			int num = int_0;
			while (int_0 < int_1)
			{
				if (byte_0[int_0] == 10)
				{
					this.string_0 += this.method_0(byte_0, num, int_0 - num - 1);
					if (!Class174.smethod_2(this.string_0))
					{
						this.string_0 = "0x" + this.string_0;
					}
					this.long_0 = (long)Class174.smethod_5(this.string_0, 16, 0);
					this.string_0 = string.Empty;
					this.long_1 = 0L;
					int_0++;
					return true;
				}
				int_0++;
			}
			this.string_0 += this.method_0(byte_0, num, int_0 - num);
			return false;
		}

		// Token: 0x0600118A RID: 4490
		// RVA: 0x00006D86 File Offset: 0x00004F86
		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600118D RID: 4493
		// RVA: 0x000600F4 File Offset: 0x0005E2F4
		public override long Seek(long offset, SeekOrigin origin)
		{
			long num = 0L;
			switch (origin)
			{
			case SeekOrigin.Begin:
				num = offset;
				break;
			case SeekOrigin.Current:
				num = this.long_2 + offset;
				break;
			case SeekOrigin.End:
				num = this.long_2 - offset;
				break;
			}
			if (num != this.long_2)
			{
				throw new Exception5("Invalid Stream operation");
			}
			return num;
		}

		// Token: 0x0600118E RID: 4494
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600118F RID: 4495
		// RVA: 0x00060150 File Offset: 0x0005E350
		public override void Write(byte[] array, int offset, int count)
		{
			this.long_2 += (long)count;
			do
			{
				if (!this.bool_1)
				{
					this.bool_1 = this.method_2(array, ref offset, count);
				}
				if (this.bool_1)
				{
					this.bool_1 = !this.method_1(array, ref offset, count);
				}
			}
			while (offset < count & !this.IsCompleted);
		}
	}
}
