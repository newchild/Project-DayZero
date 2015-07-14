using System;
using System.Collections;
using System.Collections.Generic;

namespace ns50
{
	// Token: 0x020002D0 RID: 720
	internal sealed class Class250 : IEnumerable, IEnumerable<Class268>
	{
		// Token: 0x0400118A RID: 4490
		private List<Class268> list_0;

		// Token: 0x060016CB RID: 5835
		// RVA: 0x00014187 File Offset: 0x00012387
		public IEnumerator<Class268> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060016CC RID: 5836
		// RVA: 0x00014199 File Offset: 0x00012399
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
