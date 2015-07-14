using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns8
{
	// Token: 0x02000193 RID: 403
	internal sealed class Stream1 : Stream
	{
		// Token: 0x040006FE RID: 1790
		[CompilerGenerated]
		private static bool bool_0;

		// Token: 0x04000700 RID: 1792
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040006FD RID: 1789
		private Class29 class29_0 = new Class29();

		// Token: 0x040006FF RID: 1791
		[CompilerGenerated]
		private Stream stream_0;

		// Token: 0x1700027D RID: 637
		public override bool CanRead
		{
			// Token: 0x06000E89 RID: 3721
			// RVA: 0x0000EE30 File Offset: 0x0000D030
			get
			{
				return this.method_0().CanRead;
			}
		}

		// Token: 0x1700027E RID: 638
		public override bool CanSeek
		{
			// Token: 0x06000E8A RID: 3722
			// RVA: 0x0000EE3D File Offset: 0x0000D03D
			get
			{
				return this.method_0().CanSeek;
			}
		}

		// Token: 0x1700027F RID: 639
		public override bool CanWrite
		{
			// Token: 0x06000E8B RID: 3723
			// RVA: 0x0000EE4A File Offset: 0x0000D04A
			get
			{
				return this.method_0().CanWrite;
			}
		}

		// Token: 0x17000280 RID: 640
		public override long Length
		{
			// Token: 0x06000E8C RID: 3724
			// RVA: 0x0000EE57 File Offset: 0x0000D057
			get
			{
				return this.method_0().Length;
			}
		}

		// Token: 0x17000281 RID: 641
		public override long Position
		{
			// Token: 0x06000E8D RID: 3725
			// RVA: 0x0000EE64 File Offset: 0x0000D064
			get
			{
				return this.method_0().Position;
			}
			// Token: 0x06000E8E RID: 3726
			// RVA: 0x0000EE71 File Offset: 0x0000D071
			set
			{
				this.method_0().Position = value;
			}
		}

		// Token: 0x06000E82 RID: 3714
		// RVA: 0x0004EEF4 File Offset: 0x0004D0F4
		public unsafe Stream1(Stream stream_1, Enum4 enum4_0, byte[] byte_0)
		{
			uint[] array = new uint[4];
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				fixed (byte* ptr = &byte_0[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			uint[] array2;
			uint* ptr2;
			if ((array2 = array) != null && array2.Length != 0)
			{
				fixed (uint* ptr2 = &array2[0])
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
			this.method_1(stream_1);
			this.class29_0.method_0(array, enum4_0);
		}

		// Token: 0x06000E8F RID: 3727
		// RVA: 0x0000EE7F File Offset: 0x0000D07F
		public override void Close()
		{
			if (!this.method_2())
			{
				Stream1.smethod_0(false);
				this.method_3(true);
			}
		}

		// Token: 0x06000E83 RID: 3715
		// RVA: 0x0004EF94 File Offset: 0x0004D194
		~Stream1()
		{
			this.Close();
		}

		// Token: 0x06000E84 RID: 3716
		// RVA: 0x0000EE06 File Offset: 0x0000D006
		public override void Flush()
		{
			this.method_0().Flush();
		}

		// Token: 0x06000E7E RID: 3710
		// RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		[CompilerGenerated]
		public Stream method_0()
		{
			return this.stream_0;
		}

		// Token: 0x06000E7F RID: 3711
		// RVA: 0x0000EDEC File Offset: 0x0000CFEC
		[CompilerGenerated]
		private void method_1(Stream stream_1)
		{
			this.stream_0 = stream_1;
		}

		// Token: 0x06000E80 RID: 3712
		// RVA: 0x0000EDF5 File Offset: 0x0000CFF5
		[CompilerGenerated]
		public bool method_2()
		{
			return this.bool_1;
		}

		// Token: 0x06000E81 RID: 3713
		// RVA: 0x0000EDFD File Offset: 0x0000CFFD
		[CompilerGenerated]
		private void method_3(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x06000E87 RID: 3719
		// RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		public override int Read(byte[] array, int offset, int count)
		{
			int result = this.method_0().Read(array, offset, count);
			this.class29_0.method_8(array, offset, count);
			return result;
		}

		// Token: 0x06000E85 RID: 3717
		// RVA: 0x0000EE13 File Offset: 0x0000D013
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.method_0().Seek(offset, origin);
		}

		// Token: 0x06000E86 RID: 3718
		// RVA: 0x0000EE22 File Offset: 0x0000D022
		public override void SetLength(long value)
		{
			this.method_0().SetLength(value);
		}

		// Token: 0x06000E7D RID: 3709
		// RVA: 0x0000EDDC File Offset: 0x0000CFDC
		[CompilerGenerated]
		private static void smethod_0(bool bool_2)
		{
			Stream1.bool_0 = bool_2;
		}

		// Token: 0x06000E88 RID: 3720
		// RVA: 0x0004EFEC File Offset: 0x0004D1EC
		public override void Write(byte[] array, int offset, int count)
		{
			byte[] array2 = new byte[array.Length];
			array.CopyTo(array2, 0);
			this.class29_0.method_9(array2, offset, count);
			this.method_0().Write(array2, offset, count);
		}
	}
}
