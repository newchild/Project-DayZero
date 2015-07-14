using System;
using System.Collections.Generic;
using System.IO;

namespace ns24
{
	// Token: 0x02000409 RID: 1033
	internal sealed class Class475
	{
		// Token: 0x04001A0B RID: 6667
		internal Class475 class475_0;

		// Token: 0x04001A08 RID: 6664
		internal int int_0;

		// Token: 0x04001A06 RID: 6662
		internal List<Class296> list_0;

		// Token: 0x04001A07 RID: 6663
		internal List<Class475> list_1;

		// Token: 0x04001A09 RID: 6665
		internal string string_0;

		// Token: 0x04001A0A RID: 6666
		internal string string_1;

		// Token: 0x0600211A RID: 8474
		// RVA: 0x000C0070 File Offset: 0x000BE270
		internal Class475(string string_2, Class475 class475_1)
		{
			string[] array = string_2.Split(new char[]
			{
				Path.DirectorySeparatorChar
			});
			this.string_0 = array[array.Length - 1];
			this.string_1 = string_2;
			this.list_1 = new List<Class475>();
			this.list_0 = new List<Class296>();
			this.class475_0 = class475_1;
			Class475 class = this;
			while (class.class475_0 != null)
			{
				this.int_0++;
				class = class.class475_0;
			}
		}
	}
}
