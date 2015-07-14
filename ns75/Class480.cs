using ns79;
using ns89;
using osu.GameplayElements.Events;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns75
{
	// Token: 0x02000410 RID: 1040
	internal sealed class Class480 : Class477
	{
		// Token: 0x02000411 RID: 1041
		[CompilerGenerated]
		private sealed class Class484
		{
			// Token: 0x04001A20 RID: 6688
			public Class480 class480_0;

			// Token: 0x04001A23 RID: 6691
			public Class531 class531_0;

			// Token: 0x04001A21 RID: 6689
			public Class702 class702_0;

			// Token: 0x04001A22 RID: 6690
			public Class744 class744_0;

			// Token: 0x0600213D RID: 8509
			// RVA: 0x0001AEAC File Offset: 0x000190AC
			public void method_0()
			{
				this.class480_0.method_2(this.class702_0, this.class744_0, this.class531_0, true);
			}
		}

		// Token: 0x0600213A RID: 8506
		// RVA: 0x0001AE6A File Offset: 0x0001906A
		public Class480(string string_0)
		{
			if (string_0.Length > 0)
			{
				throw new ArgumentException("Invalid trigger description: " + string_0);
			}
		}

		// Token: 0x06002139 RID: 8505
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override TriggerGroup vmethod_0()
		{
			return TriggerGroup.Passing;
		}

		// Token: 0x0600213B RID: 8507
		// RVA: 0x000C0914 File Offset: 0x000BEB14
		internal override void vmethod_1(Class702 class702_0, Class744 class744_0, Class531 class531_0)
		{
			Class480.Class484 class = new Class480.Class484();
			class.class702_0 = class702_0;
			class.class744_0 = class744_0;
			class.class531_0 = class531_0;
			class.class480_0 = this;
			Class872.smethod_9(new VoidDelegate(class.method_0));
		}
	}
}
