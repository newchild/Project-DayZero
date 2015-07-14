using ns45;
using ns49;
using System;
using System.Runtime.CompilerServices;

namespace ns43
{
	// Token: 0x020002B8 RID: 696
	internal sealed class Class235 : IDisposable
	{
		// Token: 0x04001134 RID: 4404
		public static readonly bool bool_0 = false;

		// Token: 0x04001135 RID: 4405
		public static readonly bool bool_1 = true;

		// Token: 0x04001136 RID: 4406
		public static readonly bool bool_2 = true;

		// Token: 0x04001137 RID: 4407
		public static readonly bool bool_3 = true;

		// Token: 0x04001138 RID: 4408
		public static readonly bool bool_4 = true;

		// Token: 0x04001139 RID: 4409
		public static readonly bool bool_5 = true;

		// Token: 0x0400113A RID: 4410
		public static readonly bool bool_6 = true;

		// Token: 0x0400113B RID: 4411
		public static readonly bool bool_7 = true;

		// Token: 0x0400113F RID: 4415
		private bool bool_8;

		// Token: 0x04001142 RID: 4418
		private Class223 class223_0;

		// Token: 0x04001132 RID: 4402
		internal static Class238 class238_0 = new Class238("Client Engine Loop");

		// Token: 0x0400113C RID: 4412
		internal static readonly Class240 class240_0 = new Class240();

		// Token: 0x0400113E RID: 4414
		private Class243 class243_0;

		// Token: 0x04001140 RID: 4416
		private Class244 class244_0;

		// Token: 0x04001141 RID: 4417
		private Class245 class245_0;

		// Token: 0x0400113D RID: 4413
		private Interface14 interface14_0;

		// Token: 0x04001133 RID: 4403
		private static Random random_0 = new Random();

		// Token: 0x06001681 RID: 5761
		// RVA: 0x00013ECB File Offset: 0x000120CB
		public void Dispose()
		{
			if (this.bool_8)
			{
				return;
			}
			this.bool_8 = true;
			Class235.class238_0.method_2(new Delegate28(this.method_0));
		}

		// Token: 0x06001682 RID: 5762
		// RVA: 0x00013EF3 File Offset: 0x000120F3
		[CompilerGenerated]
		private void method_0()
		{
			this.interface14_0.Dispose();
			this.class243_0.Dispose();
			this.class244_0.Dispose();
			this.class223_0.vmethod_2();
			this.class245_0.Dispose();
		}
	}
}
