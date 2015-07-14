using ns43;
using ns52;
using System;

namespace ns49
{
	// Token: 0x020002C9 RID: 713
	internal sealed class Class243 : IDisposable
	{
		// Token: 0x04001174 RID: 4468
		private bool bool_0;

		// Token: 0x04001173 RID: 4467
		private static Class238 class238_0 = new Class238("Disk IO");

		// Token: 0x04001175 RID: 4469
		private Class265 class265_0;

		// Token: 0x060016B6 RID: 5814
		// RVA: 0x00014088 File Offset: 0x00012288
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Class243.class238_0.method_2(new Delegate28(this.class265_0.Dispose));
		}
	}
}
