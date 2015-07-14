using System;
using System.IO;

namespace ns30
{
	// Token: 0x02000203 RID: 515
	internal sealed class Class148 : Class147
	{
		// Token: 0x04000E05 RID: 3589
		private string string_0;

		// Token: 0x04000E06 RID: 3590
		private string string_1;

		// Token: 0x06001218 RID: 4632
		// RVA: 0x00010FFD File Offset: 0x0000F1FD
		public Class148(string string_2, string string_3)
		{
			this.string_0 = string_2;
			this.string_1 = string_3;
		}

		// Token: 0x0600121A RID: 4634
		// RVA: 0x00060EFC File Offset: 0x0005F0FC
		private string method_4()
		{
			if (base.method_1() != null)
			{
				if (base.method_1().method_11())
				{
					return string.Format("Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}", base.method_2(this.method_5()), base.method_2(this.method_6()));
				}
				if (base.method_1().method_10())
				{
					return string.Format("{0}={1}", base.method_2(this.method_5()), base.method_2(this.method_6()));
				}
			}
			return string.Empty;
		}

		// Token: 0x0600121B RID: 4635
		// RVA: 0x00011020 File Offset: 0x0000F220
		public string method_5()
		{
			return this.string_0;
		}

		// Token: 0x0600121C RID: 4636
		// RVA: 0x00011028 File Offset: 0x0000F228
		public string method_6()
		{
			return this.string_1;
		}

		// Token: 0x06001219 RID: 4633
		// RVA: 0x00011013 File Offset: 0x0000F213
		public override Stream vmethod_0()
		{
			return new Stream8(this.method_4());
		}
	}
}
