using System;

namespace ns43
{
	// Token: 0x020002D4 RID: 724
	internal sealed class Class254
	{
		// Token: 0x04001190 RID: 4496
		private Class249 class249_0;

		// Token: 0x0400118F RID: 4495
		private Class256 class256_0;

		// Token: 0x060016D2 RID: 5842
		// RVA: 0x0007287C File Offset: 0x00070A7C
		public override bool Equals(object obj)
		{
			Class254 class = obj as Class254;
			return class != null && this.class256_0.Equals(class.class256_0);
		}

		// Token: 0x060016D3 RID: 5843
		// RVA: 0x000141FF File Offset: 0x000123FF
		public override int GetHashCode()
		{
			return this.class256_0.method_0().GetHashCode();
		}

		// Token: 0x060016D1 RID: 5841
		// RVA: 0x000141F7 File Offset: 0x000123F7
		public Class249 method_0()
		{
			return this.class249_0;
		}

		// Token: 0x060016D4 RID: 5844
		// RVA: 0x00014211 File Offset: 0x00012411
		public override string ToString()
		{
			return this.class256_0.method_0().ToString();
		}
	}
}
