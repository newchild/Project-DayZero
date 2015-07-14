using ns75;
using System;
using System.Collections.Generic;

namespace ns79
{
	// Token: 0x0200058D RID: 1421
	internal sealed class Class744 : Class743
	{
		// Token: 0x04002610 RID: 9744
		internal readonly Class477 class477_0;

		// Token: 0x04002611 RID: 9745
		internal int int_2;

		// Token: 0x04002612 RID: 9746
		internal int int_3;

		// Token: 0x04002613 RID: 9747
		private List<Class746> list_0;

		// Token: 0x06002D6F RID: 11631
		// RVA: 0x0002253C File Offset: 0x0002073C
		public Class744(Class477 class477_1, int int_4, int int_5) : base(int_4, 1)
		{
			this.class477_0 = class477_1;
			this.int_2 = int_5;
			this.int_3 = int_4;
		}

		// Token: 0x06002D71 RID: 11633
		// RVA: 0x0002255B File Offset: 0x0002075B
		public List<Class746> method_0()
		{
			return this.list_0;
		}

		// Token: 0x06002D70 RID: 11632
		// RVA: 0x001279C0 File Offset: 0x00125BC0
		internal override List<Class746> vmethod_0()
		{
			List<Class746> result = base.vmethod_0();
			this.list_0 = result;
			return result;
		}
	}
}
