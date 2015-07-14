using ns48;
using System;

namespace ns43
{
	// Token: 0x020002DC RID: 732
	internal sealed class Class261 : Class259
	{
		// Token: 0x020002DD RID: 733
		private struct Struct44 : IComparable<Class261.Struct44>
		{
			// Token: 0x0400119B RID: 4507
			public Class270 class270_0;

			// Token: 0x0400119A RID: 4506
			public Class278 class278_0;

			// Token: 0x060016E2 RID: 5858
			// RVA: 0x0001428C File Offset: 0x0001248C
			public int CompareTo(Class261.Struct44 obj)
			{
				return obj.class278_0.method_1() - this.class278_0.method_1();
			}
		}
	}
}
