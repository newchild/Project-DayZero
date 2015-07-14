using System;

namespace ns43
{
	// Token: 0x020002B7 RID: 695
	internal struct Struct43
	{
		// Token: 0x0400112F RID: 4399
		private bool bool_0;

		// Token: 0x04001130 RID: 4400
		private bool bool_1;

		// Token: 0x04001131 RID: 4401
		private bool bool_2;

		// Token: 0x0400112D RID: 4397
		private Class254 class254_0;

		// Token: 0x0400112B RID: 4395
		private Class258 class258_0;

		// Token: 0x0400112C RID: 4396
		private int int_0;

		// Token: 0x0400112E RID: 4398
		private int int_1;

		// Token: 0x0600167F RID: 5759
		// RVA: 0x00072070 File Offset: 0x00070270
		public override bool Equals(object obj)
		{
			if (!(obj is Struct43))
			{
				return false;
			}
			Struct43 struct = (Struct43)obj;
			return this.method_0() == struct.method_0() && this.int_0 == struct.int_0 && this.int_1 == struct.int_1;
		}

		// Token: 0x06001680 RID: 5760
		// RVA: 0x00013EB5 File Offset: 0x000120B5
		public override int GetHashCode()
		{
			return this.method_0() ^ this.int_1 ^ this.int_0;
		}

		// Token: 0x0600167E RID: 5758
		// RVA: 0x00013EA8 File Offset: 0x000120A8
		public int method_0()
		{
			return this.class258_0.Index;
		}
	}
}
