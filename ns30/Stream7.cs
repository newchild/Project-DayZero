using System;
using System.Collections;
using System.IO;

namespace ns30
{
	// Token: 0x0200021C RID: 540
	internal sealed class Stream7 : Stream
	{
		// Token: 0x04000E88 RID: 3720
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000E87 RID: 3719
		private long long_0;

		// Token: 0x170002C4 RID: 708
		public override bool CanRead
		{
			// Token: 0x06001341 RID: 4929
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x170002C5 RID: 709
		public override bool CanSeek
		{
			// Token: 0x06001342 RID: 4930
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return true;
			}
		}

		// Token: 0x170002C6 RID: 710
		public override bool CanWrite
		{
			// Token: 0x06001343 RID: 4931
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002C7 RID: 711
		public override long Length
		{
			// Token: 0x06001344 RID: 4932
			// RVA: 0x00063DBC File Offset: 0x00061FBC
			get
			{
				long num = 0L;
				foreach (Stream stream in this.arrayList_0)
				{
					num += stream.Length;
				}
				return num;
			}
		}

		// Token: 0x170002C8 RID: 712
		public override long Position
		{
			// Token: 0x06001345 RID: 4933
			// RVA: 0x00011E67 File Offset: 0x00010067
			get
			{
				return this.long_0;
			}
			// Token: 0x06001346 RID: 4934
			// RVA: 0x00010B3E File Offset: 0x0000ED3E
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x0600133B RID: 4923
		// RVA: 0x00063C10 File Offset: 0x00061E10
		public override void Close()
		{
			foreach (Stream stream in this.arrayList_0)
			{
				stream.Close();
			}
			base.Close();
		}

		// Token: 0x0600133C RID: 4924
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void Flush()
		{
		}

		// Token: 0x0600133A RID: 4922
		// RVA: 0x00011E58 File Offset: 0x00010058
		public void method_0(Stream stream_0)
		{
			this.arrayList_0.Add(stream_0);
		}

		// Token: 0x0600133D RID: 4925
		// RVA: 0x00063C70 File Offset: 0x00061E70
		public override int Read(byte[] array, int offset, int count)
		{
			long num = 0L;
			int num2 = 0;
			int num3 = offset;
			foreach (Stream stream in this.arrayList_0)
			{
				if (this.long_0 < num + stream.Length)
				{
					stream.Position = this.long_0 - num;
					int num4 = stream.Read(array, num3, count);
					num2 += num4;
					num3 += num4;
					this.long_0 += (long)num4;
					if (num4 >= count)
					{
						return num2;
					}
					count -= num4;
				}
				num += stream.Length;
			}
			return num2;
		}

		// Token: 0x0600133E RID: 4926
		// RVA: 0x00063D38 File Offset: 0x00061F38
		public override long Seek(long offset, SeekOrigin origin)
		{
			long length = this.Length;
			switch (origin)
			{
			case SeekOrigin.Begin:
				this.long_0 = offset;
				break;
			case SeekOrigin.Current:
				this.long_0 += offset;
				break;
			case SeekOrigin.End:
				this.long_0 = length - offset;
				break;
			}
			if (this.long_0 > length)
			{
				this.long_0 = length;
			}
			else if (this.long_0 < 0L)
			{
				this.long_0 = 0L;
			}
			return this.long_0;
		}

		// Token: 0x0600133F RID: 4927
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001340 RID: 4928
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void Write(byte[] array, int offset, int count)
		{
		}
	}
}
