using ns79;
using ns89;
using osu.GameplayElements.Events;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns75
{
	// Token: 0x0200040E RID: 1038
	internal sealed class Class479 : Class477
	{
		// Token: 0x0200040F RID: 1039
		[CompilerGenerated]
		private sealed class Class483
		{
			// Token: 0x04001A1C RID: 6684
			public Class479 class479_0;

			// Token: 0x04001A1F RID: 6687
			public Class531 class531_0;

			// Token: 0x04001A1D RID: 6685
			public Class702 class702_0;

			// Token: 0x04001A1E RID: 6686
			public Class744 class744_0;

			// Token: 0x06002138 RID: 8504
			// RVA: 0x0001AE8C File Offset: 0x0001908C
			public void method_0()
			{
				this.class479_0.method_2(this.class702_0, this.class744_0, this.class531_0, true);
			}
		}

		// Token: 0x06002135 RID: 8501
		// RVA: 0x0001AE6A File Offset: 0x0001906A
		public Class479(string string_0)
		{
			if (string_0.Length > 0)
			{
				throw new ArgumentException("Invalid trigger description: " + string_0);
			}
		}

		// Token: 0x06002134 RID: 8500
		// RVA: 0x00006369 File Offset: 0x00004569
		internal override TriggerGroup vmethod_0()
		{
			return TriggerGroup.Failing;
		}

		// Token: 0x06002136 RID: 8502
		// RVA: 0x000C08D4 File Offset: 0x000BEAD4
		internal override void vmethod_1(Class702 class702_0, Class744 class744_0, Class531 class531_0)
		{
			Class479.Class483 class = new Class479.Class483();
			class.class702_0 = class702_0;
			class.class744_0 = class744_0;
			class.class531_0 = class531_0;
			class.class479_0 = this;
			Class872.smethod_11(new VoidDelegate(class.method_0));
		}
	}
}
