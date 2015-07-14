using System;
using System.Collections.Generic;

namespace ns8
{
	// Token: 0x020001A0 RID: 416
	internal sealed class Class40 : ICloneable
	{
		// Token: 0x04000735 RID: 1845
		public List<Class39> list_0 = new List<Class39>();

		// Token: 0x04000736 RID: 1846
		public string string_0;

		// Token: 0x04000737 RID: 1847
		public string string_1;

		// Token: 0x06000ED7 RID: 3799
		// RVA: 0x00050EF4 File Offset: 0x0004F0F4
		public Class40(string string_2)
		{
			this.string_0 = string_2;
			this.string_1 = string_2;
		}

		// Token: 0x06000ED8 RID: 3800
		// RVA: 0x0000F044 File Offset: 0x0000D244
		public object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
