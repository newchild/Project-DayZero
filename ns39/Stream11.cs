using ns34;
using ns38;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ns39
{
	// Token: 0x02000258 RID: 600
	internal class Stream11 : Stream
	{
		// Token: 0x04000F87 RID: 3975
		private bool bool_0;

		// Token: 0x04000F88 RID: 3976
		private bool bool_1 = true;

		// Token: 0x04000F84 RID: 3972
		private byte[] byte_0;

		// Token: 0x04000F85 RID: 3973
		protected Class189 class189_0;

		// Token: 0x04000F83 RID: 3971
		private ICryptoTransform icryptoTransform_0;

		// Token: 0x04000F86 RID: 3974
		protected Stream stream_0;

		// Token: 0x04000F82 RID: 3970
		private string string_0;

		// Token: 0x170002D8 RID: 728
		public override bool CanRead
		{
			// Token: 0x060014D6 RID: 5334
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002D9 RID: 729
		public override bool CanSeek
		{
			// Token: 0x060014D7 RID: 5335
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002DA RID: 730
		public override bool CanWrite
		{
			// Token: 0x060014D8 RID: 5336
			// RVA: 0x00012A75 File Offset: 0x00010C75
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x170002DB RID: 731
		public override long Length
		{
			// Token: 0x060014D9 RID: 5337
			// RVA: 0x00012A82 File Offset: 0x00010C82
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x170002DC RID: 732
		public override long Position
		{
			// Token: 0x060014DA RID: 5338
			// RVA: 0x00012A8F File Offset: 0x00010C8F
			get
			{
				return this.stream_0.Position;
			}
			// Token: 0x060014DB RID: 5339
			// RVA: 0x00012A9C File Offset: 0x00010C9C
			set
			{
				throw new NotSupportedException("Position property not supported");
			}
		}

		// Token: 0x060014CE RID: 5326
		// RVA: 0x00012A22 File Offset: 0x00010C22
		public Stream11(Stream stream_1, Class189 class189_1) : this(stream_1, class189_1, 512)
		{
		}

		// Token: 0x060014CF RID: 5327
		// RVA: 0x0006BE2C File Offset: 0x0006A02C
		public Stream11(Stream stream_1, Class189 class189_1, int int_0)
		{
			if (stream_1 == null)
			{
				throw new ArgumentNullException("baseOutputStream");
			}
			if (!stream_1.CanWrite)
			{
				throw new ArgumentException("Must support writing", "baseOutputStream");
			}
			if (class189_1 == null)
			{
				throw new ArgumentNullException("deflater");
			}
			if (int_0 <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.stream_0 = stream_1;
			this.byte_0 = new byte[int_0];
			this.class189_0 = class189_1;
		}

		// Token: 0x060014E0 RID: 5344
		// RVA: 0x00012AD8 File Offset: 0x00010CD8
		public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			throw new NotSupportedException("DeflaterOutputStream BeginRead not currently supported");
		}

		// Token: 0x060014E1 RID: 5345
		// RVA: 0x00012AE4 File Offset: 0x00010CE4
		public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			throw new NotSupportedException("BeginWrite is not supported");
		}

		// Token: 0x060014E3 RID: 5347
		// RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		public override void Close()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				try
				{
					this.vmethod_0();
					if (this.icryptoTransform_0 != null)
					{
						this.icryptoTransform_0.Dispose();
						this.icryptoTransform_0 = null;
					}
				}
				finally
				{
					if (this.bool_1)
					{
						this.stream_0.Close();
					}
				}
			}
		}

		// Token: 0x060014E2 RID: 5346
		// RVA: 0x00012AF0 File Offset: 0x00010CF0
		public override void Flush()
		{
			this.class189_0.Flush();
			this.method_4();
			this.stream_0.Flush();
		}

		// Token: 0x060014D1 RID: 5329
		// RVA: 0x00012A31 File Offset: 0x00010C31
		public bool method_0()
		{
			return this.stream_0.CanSeek;
		}

		// Token: 0x060014D2 RID: 5330
		// RVA: 0x00012A3E File Offset: 0x00010C3E
		public string method_1()
		{
			return this.string_0;
		}

		// Token: 0x060014D3 RID: 5331
		// RVA: 0x00012A46 File Offset: 0x00010C46
		public void method_2(string string_1)
		{
			if (string_1 != null && string_1.Length == 0)
			{
				this.string_0 = null;
				return;
			}
			this.string_0 = string_1;
		}

		// Token: 0x060014D4 RID: 5332
		// RVA: 0x00012A62 File Offset: 0x00010C62
		protected void method_3(byte[] byte_1, int int_0, int int_1)
		{
			this.icryptoTransform_0.TransformBlock(byte_1, 0, int_1, byte_1, 0);
		}

		// Token: 0x060014D5 RID: 5333
		// RVA: 0x0006BF50 File Offset: 0x0006A150
		protected void method_4()
		{
			while (!this.class189_0.method_3())
			{
				int num = this.class189_0.method_7(this.byte_0, 0, this.byte_0.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.icryptoTransform_0 != null)
				{
					this.method_3(this.byte_0, 0, num);
				}
				this.stream_0.Write(this.byte_0, 0, num);
			}
			if (!this.class189_0.method_3())
			{
				throw new Exception6("DeflaterOutputStream can't deflate all input?");
			}
		}

		// Token: 0x060014DF RID: 5343
		// RVA: 0x00012ACC File Offset: 0x00010CCC
		public override int Read(byte[] array, int offset, int count)
		{
			throw new NotSupportedException("DeflaterOutputStream Read not supported");
		}

		// Token: 0x060014DE RID: 5342
		// RVA: 0x00012AC0 File Offset: 0x00010CC0
		public override int ReadByte()
		{
			throw new NotSupportedException("DeflaterOutputStream ReadByte not supported");
		}

		// Token: 0x060014DC RID: 5340
		// RVA: 0x00012AA8 File Offset: 0x00010CA8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("DeflaterOutputStream Seek not supported");
		}

		// Token: 0x060014DD RID: 5341
		// RVA: 0x00012AB4 File Offset: 0x00010CB4
		public override void SetLength(long value)
		{
			throw new NotSupportedException("DeflaterOutputStream SetLength not supported");
		}

		// Token: 0x060014D0 RID: 5328
		// RVA: 0x0006BEA4 File Offset: 0x0006A0A4
		public virtual void vmethod_0()
		{
			this.class189_0.method_1();
			while (!this.class189_0.method_2())
			{
				int num = this.class189_0.method_7(this.byte_0, 0, this.byte_0.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.icryptoTransform_0 != null)
				{
					this.method_3(this.byte_0, 0, num);
				}
				this.stream_0.Write(this.byte_0, 0, num);
			}
			if (!this.class189_0.method_2())
			{
				throw new Exception6("Can't deflate all input?");
			}
			this.stream_0.Flush();
			if (this.icryptoTransform_0 != null)
			{
				this.icryptoTransform_0.Dispose();
				this.icryptoTransform_0 = null;
			}
		}

		// Token: 0x060014E5 RID: 5349
		// RVA: 0x00012B0E File Offset: 0x00010D0E
		public override void Write(byte[] array, int offset, int count)
		{
			this.class189_0.method_4(array, offset, count);
			this.method_4();
		}

		// Token: 0x060014E4 RID: 5348
		// RVA: 0x0006C034 File Offset: 0x0006A234
		public override void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}
	}
}
