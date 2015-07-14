using ns59;
using ns79;
using ns89;
using osu.GameplayElements.Events;
using System;
using System.Runtime.CompilerServices;

namespace ns75
{
	// Token: 0x02000412 RID: 1042
	internal sealed class Class481 : Class477
	{
		// Token: 0x02000413 RID: 1043
		[CompilerGenerated]
		private sealed class Class485
		{
			// Token: 0x04001A24 RID: 6692
			public Class481 class481_0;

			// Token: 0x04001A27 RID: 6695
			public Class531 class531_0;

			// Token: 0x04001A25 RID: 6693
			public Class702 class702_0;

			// Token: 0x04001A26 RID: 6694
			public Class744 class744_0;

			// Token: 0x06002142 RID: 8514
			// RVA: 0x0001AECC File Offset: 0x000190CC
			public void method_0(Class304 class304_0)
			{
				if (class304_0.int_5 > 0)
				{
					this.class481_0.method_2(this.class702_0, this.class744_0, this.class531_0, false);
				}
			}
		}

		// Token: 0x0600213F RID: 8511
		// RVA: 0x0001AE6A File Offset: 0x0001906A
		public Class481(string string_0)
		{
			if (string_0.Length > 0)
			{
				throw new ArgumentException("Invalid trigger description: " + string_0);
			}
		}

		// Token: 0x0600213E RID: 8510
		// RVA: 0x000063AE File Offset: 0x000045AE
		internal override TriggerGroup vmethod_0()
		{
			return TriggerGroup.HitObjectHit;
		}

		// Token: 0x06002140 RID: 8512
		// RVA: 0x000C0954 File Offset: 0x000BEB54
		internal override void vmethod_1(Class702 class702_0, Class744 class744_0, Class531 class531_0)
		{
			Class481.Class485 class = new Class481.Class485();
			class.class702_0 = class702_0;
			class.class744_0 = class744_0;
			class.class531_0 = class531_0;
			class.class481_0 = this;
			Class872.smethod_7(new Delegate55(class.method_0));
		}
	}
}
