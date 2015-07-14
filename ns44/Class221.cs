using ns43;
using ns45;
using System;
using System.Runtime.CompilerServices;

namespace ns44
{
	// Token: 0x020002A9 RID: 681
	internal sealed class Class221 : IDisposable, Interface14
	{
		// Token: 0x04001104 RID: 4356
		private bool bool_0;

		// Token: 0x04001103 RID: 4355
		internal static Class238 class238_0 = new Class238("DhtLoop");

		// Token: 0x06001605 RID: 5637
		// RVA: 0x000138E1 File Offset: 0x00011AE1
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			Class221.class238_0.method_2(new Delegate28(this.method_0));
		}

		// Token: 0x06001606 RID: 5638
		// RVA: 0x00013902 File Offset: 0x00011B02
		[CompilerGenerated]
		private void method_0()
		{
			this.bool_0 = true;
		}
	}
}
