using System;
using System.Collections;
using System.Collections.Generic;

namespace ns50
{
	// Token: 0x020002E6 RID: 742
	internal sealed class Class268 : IEnumerable, IEnumerable<Class266>
	{
		// Token: 0x040011C3 RID: 4547
		private List<Class266> list_0;

		// Token: 0x060016FD RID: 5885
		// RVA: 0x000143AB File Offset: 0x000125AB
		public IEnumerator<Class266> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060016FE RID: 5886
		// RVA: 0x000143BD File Offset: 0x000125BD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
