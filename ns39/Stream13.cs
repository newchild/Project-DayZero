using ns34;
using ns35;
using ns38;
using System;
using System.IO;

namespace ns39
{
	// Token: 0x0200025A RID: 602
	internal class Stream13 : Stream
	{
		// Token: 0x04000F93 RID: 3987
		private bool bool_0;

		// Token: 0x04000F94 RID: 3988
		private bool bool_1 = true;

		// Token: 0x04000F90 RID: 3984
		protected Class196 class196_0;

		// Token: 0x04000F91 RID: 3985
		protected Class199 class199_0;

		// Token: 0x04000F92 RID: 3986
		protected Stream stream_0;

		// Token: 0x170002DD RID: 733
		public override bool CanRead
		{
			// Token: 0x060014EE RID: 5358
			// RVA: 0x00012BD3 File Offset: 0x00010DD3
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x170002DE RID: 734
		public override bool CanSeek
		{
			// Token: 0x060014EF RID: 5359
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002DF RID: 735
		public override bool CanWrite
		{
			// Token: 0x060014F0 RID: 5360
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002E0 RID: 736
		public override long Length
		{
			// Token: 0x060014F1 RID: 5361
			// RVA: 0x00012BE0 File Offset: 0x00010DE0
			get
			{
				return (long)this.class199_0.method_0();
			}
		}

		// Token: 0x170002E1 RID: 737
		public override long Position
		{
			// Token: 0x060014F2 RID: 5362
			// RVA: 0x00012BEE File Offset: 0x00010DEE
			get
			{
				return this.stream_0.Position;
			}
			// Token: 0x060014F3 RID: 5363
			// RVA: 0x00012BFB File Offset: 0x00010DFB
			set
			{
				throw new NotSupportedException("InflaterInputStream Position not supported");
			}
		}

		// Token: 0x060014EA RID: 5354
		// RVA: 0x00012B93 File Offset: 0x00010D93
		public Stream13(Stream stream_1) : this(stream_1, new Class196(), 4096)
		{
		}

		// Token: 0x060014EB RID: 5355
		// RVA: 0x00012BA6 File Offset: 0x00010DA6
		public Stream13(Stream stream_1, Class196 class196_1) : this(stream_1, class196_1, 4096)
		{
		}

		// Token: 0x060014EC RID: 5356
		// RVA: 0x0006C108 File Offset: 0x0006A308
		public Stream13(Stream stream_1, Class196 class196_1, int int_0)
		{
			if (stream_1 == null)
			{
				throw new ArgumentNullException("baseInputStream");
			}
			if (class196_1 == null)
			{
				throw new ArgumentNullException("inflater");
			}
			if (int_0 <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.stream_0 = stream_1;
			this.class196_0 = class196_1;
			this.class199_0 = new Class199(stream_1, int_0);
		}

		// Token: 0x060014F9 RID: 5369
		// RVA: 0x00012C44 File Offset: 0x00010E44
		public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
		}

		// Token: 0x060014FA RID: 5370
		// RVA: 0x00012C50 File Offset: 0x00010E50
		public override void Close()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				if (this.bool_1)
				{
					this.stream_0.Close();
				}
			}
		}

		// Token: 0x060014F4 RID: 5364
		// RVA: 0x00012C07 File Offset: 0x00010E07
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x060014ED RID: 5357
		// RVA: 0x00012BB5 File Offset: 0x00010DB5
		protected void method_0()
		{
			this.class199_0.method_2();
			this.class199_0.method_1(this.class196_0);
		}

		// Token: 0x060014FB RID: 5371
		// RVA: 0x0006C168 File Offset: 0x0006A368
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.class196_0.method_8())
			{
				throw new Exception6("Need a dictionary");
			}
			int num = count;
			while (true)
			{
				int num2 = this.class196_0.method_6(array, offset, num);
				offset += num2;
				num -= num2;
				if (num == 0 || this.class196_0.method_9())
				{
					goto IL_69;
				}
				if (this.class196_0.method_7())
				{
					this.method_0();
				}
				else if (num2 == 0)
				{
					break;
				}
			}
			throw new Exception8("Dont know what to do");
			IL_69:
			return count - num;
		}

		// Token: 0x060014F5 RID: 5365
		// RVA: 0x00012C14 File Offset: 0x00010E14
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("Seek not supported");
		}

		// Token: 0x060014F6 RID: 5366
		// RVA: 0x00012C20 File Offset: 0x00010E20
		public override void SetLength(long value)
		{
			throw new NotSupportedException("InflaterInputStream SetLength not supported");
		}

		// Token: 0x060014F7 RID: 5367
		// RVA: 0x00012C2C File Offset: 0x00010E2C
		public override void Write(byte[] array, int offset, int count)
		{
			throw new NotSupportedException("InflaterInputStream Write not supported");
		}

		// Token: 0x060014F8 RID: 5368
		// RVA: 0x00012C38 File Offset: 0x00010E38
		public override void WriteByte(byte value)
		{
			throw new NotSupportedException("InflaterInputStream WriteByte not supported");
		}
	}
}
