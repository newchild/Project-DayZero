using ns29;
using ns79;
using ns83;
using ns90;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns86
{
	// Token: 0x0200048A RID: 1162
	internal static class Class589
	{
		// Token: 0x0200048B RID: 1163
		[CompilerGenerated]
		private sealed class Class590
		{
			// Token: 0x04001F07 RID: 7943
			public Class580 class580_0;

			// Token: 0x06002576 RID: 9590
			// RVA: 0x0001D21F File Offset: 0x0001B41F
			public void method_0()
			{
				Class115.class911_3.Add<Class531>(this.class580_0.list_0);
				Class723.smethod_1(this.class580_0.string_0, this.class580_0.int_0);
			}
		}

		// Token: 0x04001F06 RID: 7942
		private static int int_0;

		// Token: 0x04001F04 RID: 7940
		private static List<bool> list_0 = new List<bool>();

		// Token: 0x04001F05 RID: 7941
		private static readonly Queue<Class580> queue_0 = new Queue<Class580>();

		// Token: 0x06002573 RID: 9587
		// RVA: 0x000E1BCC File Offset: 0x000DFDCC
		internal static void smethod_0()
		{
			Class589.Class590 class = new Class589.Class590();
			if (Class115.int_1 >= Class589.int_0 && Class589.queue_0.Count != 0)
			{
				class.class580_0 = Class589.queue_0.Dequeue();
				class.class580_0.method_0();
				Class589.list_0[class.class580_0.int_1] = true;
				Class589.int_0 = Class115.int_1 + class.class580_0.int_0 + 300;
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
				return;
			}
		}
	}
}
