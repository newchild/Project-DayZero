using System;

namespace ns36
{
	// Token: 0x0200023A RID: 570
	internal sealed class Class181 : Interface10
	{
		// Token: 0x04000F00 RID: 3840
		private uint uint_0;

		// Token: 0x170002D4 RID: 724
		public long Value
		{
			// Token: 0x06001431 RID: 5169
			// RVA: 0x00012505 File Offset: 0x00010705
			get
			{
				return (long)((ulong)this.uint_0);
			}
		}

		// Token: 0x06001432 RID: 5170
		// RVA: 0x0001250E File Offset: 0x0001070E
		public Class181()
		{
			this.Reset();
		}

		// Token: 0x06001434 RID: 5172
		// RVA: 0x000685E0 File Offset: 0x000667E0
		public void imethod_0(int int_0)
		{
			uint num = this.uint_0 & 65535u;
			uint num2 = this.uint_0 >> 16;
			num = (num + (uint)(int_0 & 255)) % 65521u;
			num2 = (num + num2) % 65521u;
			this.uint_0 = (num2 << 16) + num;
		}

		// Token: 0x06001433 RID: 5171
		// RVA: 0x0001251C File Offset: 0x0001071C
		public void Reset()
		{
			this.uint_0 = 1u;
		}

		// Token: 0x06001435 RID: 5173
		// RVA: 0x0006862C File Offset: 0x0006682C
		public void vmethod_0(byte[] byte_0, int int_0, int int_1)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "cannot be negative");
			}
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "cannot be negative");
			}
			if (int_0 >= byte_0.Length)
			{
				throw new ArgumentOutOfRangeException("offset", "not a valid index into buffer");
			}
			if (int_0 + int_1 > byte_0.Length)
			{
				throw new ArgumentOutOfRangeException("count", "exceeds buffer size");
			}
			uint num = this.uint_0 & 65535u;
			uint num2 = this.uint_0 >> 16;
			while (int_1 > 0)
			{
				int num3 = 3800;
				if (3800 > int_1)
				{
					num3 = int_1;
				}
				int_1 -= num3;
				while (--num3 >= 0)
				{
					num += (uint)(byte_0[int_0++] & 255);
					num2 += num;
				}
				num %= 65521u;
				num2 %= 65521u;
			}
			this.uint_0 = (num2 << 16 | num);
		}
	}
}
