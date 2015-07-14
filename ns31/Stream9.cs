using ns8;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns31
{
	// Token: 0x02000233 RID: 563
	internal sealed class Stream9 : Stream
	{
		// Token: 0x02000234 RID: 564
		// Token: 0x060013FD RID: 5117
		internal delegate void Delegate18(Stream9 stream9_0);

		// Token: 0x04000ED6 RID: 3798
		private bool bool_0;

		// Token: 0x04000ED8 RID: 3800
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000ED2 RID: 3794
		private byte[] byte_0 = new byte[64];

		// Token: 0x04000ED3 RID: 3795
		private Class29 class29_0 = new Class29();

		// Token: 0x04000ED7 RID: 3799
		private Stream9.Delegate18 delegate18_0;

		// Token: 0x04000ED0 RID: 3792
		private readonly int int_0;

		// Token: 0x04000ED4 RID: 3796
		private int int_1;

		// Token: 0x04000ED5 RID: 3797
		private long long_0;

		// Token: 0x04000ED1 RID: 3793
		private Stream stream_0;

		// Token: 0x170002C9 RID: 713
		public override bool CanRead
		{
			// Token: 0x060013EC RID: 5100
			// RVA: 0x00012325 File Offset: 0x00010525
			get
			{
				return !this.method_0();
			}
		}

		// Token: 0x170002CA RID: 714
		public override bool CanSeek
		{
			// Token: 0x060013ED RID: 5101
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002CB RID: 715
		public override bool CanWrite
		{
			// Token: 0x060013EE RID: 5102
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002CC RID: 716
		public override long Length
		{
			// Token: 0x060013EF RID: 5103
			// RVA: 0x00012330 File Offset: 0x00010530
			get
			{
				return (long)this.int_0;
			}
		}

		// Token: 0x170002CD RID: 717
		public override long Position
		{
			// Token: 0x060013F2 RID: 5106
			// RVA: 0x0001234A File Offset: 0x0001054A
			get
			{
				return this.long_0 - (long)this.int_1;
			}
			// Token: 0x060013F3 RID: 5107
			// RVA: 0x0001235A File Offset: 0x0001055A
			set
			{
				this.stream_0.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x060013E9 RID: 5097
		// RVA: 0x00012307 File Offset: 0x00010507
		public Stream9(string string_0, int int_2, int int_3, byte[] byte_1, byte[] byte_2) : this(File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read), int_2, int_3, byte_1, byte_2)
		{
			this.bool_0 = true;
		}

		// Token: 0x060013EA RID: 5098
		// RVA: 0x000670AC File Offset: 0x000652AC
		public unsafe Stream9(Stream stream_1, int int_2, int int_3, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = new byte[4];
			stream_1.Seek((long)int_2, SeekOrigin.Begin);
			stream_1.Read(array, 0, 4);
			this.stream_0 = stream_1;
			this.stream_0.Position = (long)(this.int_1 = int_2 + 4);
			uint[] array2 = new uint[4];
			byte* ptr;
			if (byte_2 != null && byte_2.Length != 0)
			{
				fixed (byte* ptr = &byte_2[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			uint[] array3;
			uint* ptr2;
			if ((array3 = array2) != null && array3.Length != 0)
			{
				fixed (uint* ptr2 = &array3[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			uint* ptr3 = (uint*)ptr;
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
			ptr2[2] = ptr3[2];
			ptr2[3] = ptr3[3];
			ptr2 = null;
			ptr = null;
			this.class29_0.method_0(array2, Enum4.const_1);
			byte[] array4 = new byte[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			this.class29_0.method_8(array4, 0, 4);
			this.int_0 = ((int)array4[0] | (int)array4[1] << 8 | (int)array4[2] << 16 | (int)array4[3] << 24);
			this.long_0 = (long)this.int_1;
		}

		// Token: 0x060013F5 RID: 5109
		// RVA: 0x0001236A File Offset: 0x0001056A
		public override void Close()
		{
			if (this.delegate18_0 != null)
			{
				this.delegate18_0(this);
			}
			base.Close();
		}

		// Token: 0x060013F9 RID: 5113
		// RVA: 0x00012386 File Offset: 0x00010586
		protected override void Dispose(bool disposing)
		{
			this.method_1(true);
			if (disposing && this.bool_0)
			{
				this.stream_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060013EB RID: 5099
		// RVA: 0x00056E70 File Offset: 0x00055070
		~Stream9()
		{
			this.Dispose(false);
		}

		// Token: 0x060013F6 RID: 5110
		// RVA: 0x000071FE File Offset: 0x000053FE
		public override void Flush()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060013F0 RID: 5104
		// RVA: 0x00012339 File Offset: 0x00010539
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x060013F1 RID: 5105
		// RVA: 0x00012341 File Offset: 0x00010541
		[CompilerGenerated]
		protected void method_1(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x060013F4 RID: 5108
		// RVA: 0x000671F8 File Offset: 0x000653F8
		public void method_2(Stream9.Delegate18 delegate18_1)
		{
			Stream9.Delegate18 delegate = this.delegate18_0;
			Stream9.Delegate18 delegate2;
			do
			{
				delegate2 = delegate;
				Stream9.Delegate18 value = (Stream9.Delegate18)Delegate.Combine(delegate2, delegate18_1);
				delegate = Interlocked.CompareExchange<Stream9.Delegate18>(ref this.delegate18_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060013FA RID: 5114
		// RVA: 0x00067308 File Offset: 0x00065508
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.Position + (long)count > (long)this.int_0)
			{
				count = this.int_0 - (int)this.Position;
			}
			if (count == 0)
			{
				return 0;
			}
			long num = this.long_0 - (long)this.int_1;
			long num2 = num & -64L;
			int num3 = (int)num % 64;
			int num4 = count;
			int num5 = count - (64 - num3);
			int num6 = 0;
			int num7 = 0;
			if (num5 > 0)
			{
				num7 = ((int)num + count & -64);
				num6 = ((int)num + count) % 64;
				num5 = num7 - (64 - num3 + (int)num);
				if (num5 > 0)
				{
					this.stream_0.Position = this.long_0;
					this.stream_0.Read(array, offset, count);
					this.class29_0.method_8(array, 64 - num3 + offset, num5);
				}
			}
			int count2 = Math.Min(64, this.int_0 - (int)num2);
			this.stream_0.Position = num2 + (long)this.int_1;
			this.stream_0.Read(this.byte_0, 0, count2);
			this.class29_0.method_8(this.byte_0, 0, count2);
			Array.Copy(this.byte_0, num3, array, offset, Math.Min(64 - num3, count));
			if (num6 > 0)
			{
				int count3 = Math.Min(64, this.int_0 - num7);
				this.stream_0.Position = (long)(num7 + this.int_1);
				this.stream_0.Read(this.byte_0, 0, count3);
				this.class29_0.method_8(this.byte_0, 0, count3);
				Array.Copy(this.byte_0, 0, array, count - num6 + offset, num6);
			}
			this.stream_0.Position = this.long_0;
			this.Seek((long)num4, SeekOrigin.Current);
			return num4;
		}

		// Token: 0x060013F7 RID: 5111
		// RVA: 0x00067230 File Offset: 0x00065430
		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
			case SeekOrigin.Begin:
				if (offset >= 0L)
				{
					this.long_0 = Math.Min(offset, (long)this.int_0) + (long)this.int_1;
				}
				break;
			case SeekOrigin.Current:
				if (this.Position + offset >= 0L)
				{
					this.long_0 = Math.Min(this.long_0 + offset - (long)this.int_1, (long)this.int_0) + (long)this.int_1;
				}
				break;
			case SeekOrigin.End:
				if ((long)this.int_0 + offset >= 0L)
				{
					this.long_0 = (long)this.int_0 + offset + (long)this.int_1;
				}
				break;
			}
			this.stream_0.Seek(this.long_0, SeekOrigin.Begin);
			return this.Position;
		}

		// Token: 0x060013F8 RID: 5112
		// RVA: 0x000071FE File Offset: 0x000053FE
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060013FB RID: 5115
		// RVA: 0x000071FE File Offset: 0x000053FE
		public override void Write(byte[] array, int offset, int count)
		{
			throw new NotSupportedException();
		}
	}
}
