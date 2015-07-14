using System;
using System.IO;

namespace ns30
{
	// Token: 0x0200022B RID: 555
	internal sealed class Class149 : Class147
	{
		// Token: 0x04000EA2 RID: 3746
		private byte[] byte_1;

		// Token: 0x04000E9F RID: 3743
		private string string_0;

		// Token: 0x04000EA0 RID: 3744
		private string string_1;

		// Token: 0x04000EA1 RID: 3745
		private string string_2;

		// Token: 0x06001384 RID: 4996
		// RVA: 0x0001204A File Offset: 0x0001024A
		public Class149(string string_3, string string_4)
		{
			this.string_1 = string_4;
			this.string_2 = string_3;
			this.string_0 = "application/octet-stream";
		}

		// Token: 0x06001385 RID: 4997
		// RVA: 0x0001206B File Offset: 0x0001026B
		public void method_4(byte[] byte_2)
		{
			this.byte_1 = byte_2;
		}

		// Token: 0x06001387 RID: 4999
		// RVA: 0x00012074 File Offset: 0x00010274
		public string method_5()
		{
			return this.string_0;
		}

		// Token: 0x06001388 RID: 5000
		// RVA: 0x0001207C File Offset: 0x0001027C
		public string method_6()
		{
			return this.string_1;
		}

		// Token: 0x06001389 RID: 5001
		// RVA: 0x00012084 File Offset: 0x00010284
		public string method_7()
		{
			return this.string_2;
		}

		// Token: 0x06001386 RID: 4998
		// RVA: 0x00064538 File Offset: 0x00062738
		public override Stream vmethod_0()
		{
			if (base.method_1() != null && base.method_1().method_11())
			{
				Stream7 stream = new Stream7();
				Stream result;
				try
				{
					stream.method_0(new Stream8("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", new object[]
					{
						base.method_2(this.method_6()),
						base.method_2(Class177.smethod_0(this.method_7())),
						this.method_5()
					}));
					EventArgs2 eventArgs = new EventArgs2(this);
					base.method_1().vmethod_3(eventArgs);
					if (eventArgs.method_0() == null)
					{
						if (this.byte_1 == null)
						{
							stream.method_0(new FileStream(this.method_7(), FileMode.Open, FileAccess.Read, FileShare.Read));
						}
						else
						{
							stream.method_0(new MemoryStream(this.byte_1));
						}
					}
					else
					{
						stream.method_0(eventArgs.method_0());
					}
					result = stream;
				}
				catch (Exception ex)
				{
					stream.Close();
					throw ex;
				}
				return result;
			}
			return Stream.Null;
		}
	}
}
