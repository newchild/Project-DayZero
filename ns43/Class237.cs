using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns43
{
	// Token: 0x020002BF RID: 703
	internal sealed class Class237 : IDisposable
	{
		// Token: 0x04001151 RID: 4433
		[CompilerGenerated]
		private static Action<Stream16> action_0;

		// Token: 0x04001150 RID: 4432
		private List<Stream16> list_0;

		// Token: 0x0600168D RID: 5773
		// RVA: 0x00013F65 File Offset: 0x00012165
		public void Dispose()
		{
			List<Stream16> arg_23_0 = this.list_0;
			if (Class237.action_0 == null)
			{
				Class237.action_0 = new Action<Stream16>(Class237.smethod_0);
			}
			arg_23_0.ForEach(Class237.action_0);
			this.list_0.Clear();
		}

		// Token: 0x0600168E RID: 5774
		// RVA: 0x00013F9A File Offset: 0x0001219A
		[CompilerGenerated]
		private static void smethod_0(Stream16 stream16_0)
		{
			stream16_0.Dispose();
		}
	}
}
