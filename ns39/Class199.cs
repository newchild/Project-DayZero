using ns34;
using ns38;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ns39
{
	// Token: 0x02000259 RID: 601
	internal sealed class Class199
	{
		// Token: 0x04000F8A RID: 3978
		private byte[] byte_0;

		// Token: 0x04000F8C RID: 3980
		private byte[] byte_1;

		// Token: 0x04000F8E RID: 3982
		private ICryptoTransform icryptoTransform_0;

		// Token: 0x04000F89 RID: 3977
		private int int_0;

		// Token: 0x04000F8B RID: 3979
		private int int_1;

		// Token: 0x04000F8D RID: 3981
		private int int_2;

		// Token: 0x04000F8F RID: 3983
		private Stream stream_0;

		// Token: 0x060014E6 RID: 5350
		// RVA: 0x00012B24 File Offset: 0x00010D24
		public Class199(Stream stream_1, int int_3)
		{
			this.stream_0 = stream_1;
			if (int_3 < 1024)
			{
				int_3 = 1024;
			}
			this.byte_0 = new byte[int_3];
			this.byte_1 = this.byte_0;
		}

		// Token: 0x060014E7 RID: 5351
		// RVA: 0x00012B5A File Offset: 0x00010D5A
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060014E8 RID: 5352
		// RVA: 0x00012B62 File Offset: 0x00010D62
		public void method_1(Class196 class196_0)
		{
			if (this.int_2 > 0)
			{
				class196_0.method_5(this.byte_1, this.int_1 - this.int_2, this.int_2);
				this.int_2 = 0;
			}
		}

		// Token: 0x060014E9 RID: 5353
		// RVA: 0x0006C058 File Offset: 0x0006A258
		public void method_2()
		{
			this.int_0 = 0;
			int i = this.byte_0.Length;
			while (i > 0)
			{
				int num = this.stream_0.Read(this.byte_0, this.int_0, i);
				if (num > 0)
				{
					this.int_0 += num;
					i -= num;
				}
				else
				{
					if (this.int_0 == 0)
					{
						throw new Exception6("Unexpected EOF");
					}
					IL_5A:
					if (this.icryptoTransform_0 != null)
					{
						this.int_1 = this.icryptoTransform_0.TransformBlock(this.byte_0, 0, this.int_0, this.byte_1, 0);
					}
					else
					{
						this.int_1 = this.int_0;
					}
					this.int_2 = this.int_1;
					return;
				}
			}
			goto IL_5A;
		}
	}
}
