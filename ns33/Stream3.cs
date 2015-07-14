using System;
using System.IO;

namespace ns33
{
	// Token: 0x020001E1 RID: 481
	internal sealed class Stream3 : Stream, IDisposable
	{
		// Token: 0x04000CF8 RID: 3320
		private bool bool_0;

		// Token: 0x04000CF6 RID: 3318
		private GClass0 gclass0_0;

		// Token: 0x04000CF9 RID: 3321
		private long long_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly long long_1 = -99L;

		// Token: 0x04000CF7 RID: 3319
		private Stream stream_0;

		// Token: 0x17000291 RID: 657
		public override bool CanRead
		{
			// Token: 0x060010F1 RID: 4337
			// RVA: 0x0001052D File Offset: 0x0000E72D
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x17000292 RID: 658
		public override bool CanSeek
		{
			// Token: 0x060010F2 RID: 4338
			// RVA: 0x0001053A File Offset: 0x0000E73A
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x17000293 RID: 659
		public override bool CanWrite
		{
			// Token: 0x060010F3 RID: 4339
			// RVA: 0x00010547 File Offset: 0x0000E747
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x17000294 RID: 660
		public override long Length
		{
			// Token: 0x060010F4 RID: 4340
			// RVA: 0x00010554 File Offset: 0x0000E754
			get
			{
				if (this.long_0 == Stream3.long_1)
				{
					return this.stream_0.Length;
				}
				return this.long_0;
			}
		}

		// Token: 0x17000295 RID: 661
		public override long Position
		{
			// Token: 0x060010F5 RID: 4341
			// RVA: 0x00010575 File Offset: 0x0000E775
			get
			{
				return this.gclass0_0.method_2();
			}
			// Token: 0x060010F6 RID: 4342
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060010EA RID: 4330
		// RVA: 0x000104DB File Offset: 0x0000E6DB
		public override void Close()
		{
			base.Close();
			if (!this.bool_0)
			{
				this.stream_0.Close();
			}
		}

		// Token: 0x060010EB RID: 4331
		// RVA: 0x000104F6 File Offset: 0x0000E6F6
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x060010EC RID: 4332
		// RVA: 0x00059394 File Offset: 0x00057594
		public override int Read(byte[] array, int offset, int count)
		{
			int count2 = count;
			if (this.long_0 != Stream3.long_1)
			{
				if (this.gclass0_0.method_2() >= this.long_0)
				{
					return 0;
				}
				long num = this.long_0 - this.gclass0_0.method_2();
				if (num < (long)count)
				{
					count2 = (int)num;
				}
			}
			int num2 = this.stream_0.Read(array, offset, count2);
			if (num2 > 0)
			{
				this.gclass0_0.method_0(array, offset, num2);
			}
			return num2;
		}

		// Token: 0x060010ED RID: 4333
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060010EE RID: 4334
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060010EF RID: 4335
		// RVA: 0x00010503 File Offset: 0x0000E703
		void IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x060010F0 RID: 4336
		// RVA: 0x0001050B File Offset: 0x0000E70B
		public override void Write(byte[] array, int offset, int count)
		{
			if (count > 0)
			{
				this.gclass0_0.method_0(array, offset, count);
			}
			this.stream_0.Write(array, offset, count);
		}
	}
}
