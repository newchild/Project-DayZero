using ns8;
using System;
using System.IO;

namespace ns4
{
	// Token: 0x02000188 RID: 392
	internal sealed class Class25
	{
		// Token: 0x040006EA RID: 1770
		public byte[] byte_0;

		// Token: 0x040006ED RID: 1773
		private Class32 class32_0;

		// Token: 0x040006EB RID: 1771
		public int int_0;

		// Token: 0x040006EC RID: 1772
		public int int_1;

		// Token: 0x040006EE RID: 1774
		public MemoryStream memoryStream_0;

		// Token: 0x1700027C RID: 636
		public Class32 Reader
		{
			// Token: 0x06000E4D RID: 3661
			// RVA: 0x0000EC5F File Offset: 0x0000CE5F
			get
			{
				if (this.class32_0 == null)
				{
					this.class32_0 = new Class32(this.memoryStream_0);
				}
				return this.class32_0;
			}
		}

		// Token: 0x06000E4E RID: 3662
		// RVA: 0x0000EC80 File Offset: 0x0000CE80
		public Class25(byte[] byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.memoryStream_0 = new MemoryStream(byte_1, int_2, int_3, true);
		}
	}
}
