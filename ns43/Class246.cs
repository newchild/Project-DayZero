using System;
using System.Collections.Generic;

namespace ns43
{
	// Token: 0x020002CC RID: 716
	internal sealed class Class246 : IDisposable
	{
		// Token: 0x04001179 RID: 4473
		private bool bool_0;

		// Token: 0x04001177 RID: 4471
		private Class254 class254_0;

		// Token: 0x04001178 RID: 4472
		private List<Class256> list_0;

		// Token: 0x060016BB RID: 5819
		// RVA: 0x000140E7 File Offset: 0x000122E7
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			this.class254_0.method_0().method_0(new EventHandler<EventArgs11>(this.method_0));
		}

		// Token: 0x060016BA RID: 5818
		// RVA: 0x000140D4 File Offset: 0x000122D4
		internal void method_0(object sender, EventArgs11 e)
		{
			this.list_0.Add(e.method_0());
		}
	}
}
