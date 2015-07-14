using System;
using System.Diagnostics;

namespace ns9
{
	// Token: 0x020001BA RID: 442
	internal sealed class Class116
	{
		// Token: 0x04000BF5 RID: 3061
		private bool bool_0;

		// Token: 0x04000BF6 RID: 3062
		private bool bool_1 = true;

		// Token: 0x04000BF2 RID: 3058
		private long long_0;

		// Token: 0x04000BF3 RID: 3059
		private TimeSpan timeSpan_0;

		// Token: 0x04000BF4 RID: 3060
		private TimeSpan timeSpan_1;

		// Token: 0x06000F84 RID: 3972
		// RVA: 0x0000F50C File Offset: 0x0000D70C
		public Class116()
		{
			this.Reset();
		}

		// Token: 0x06000F85 RID: 3973
		// RVA: 0x0000F521 File Offset: 0x0000D721
		internal void Reset()
		{
			this.timeSpan_0 = TimeSpan.Zero;
			this.timeSpan_1 = TimeSpan.Zero;
			this.long_0 = Class116.smethod_0();
			this.bool_0 = false;
		}

		// Token: 0x06000F86 RID: 3974
		// RVA: 0x0000F54B File Offset: 0x0000D74B
		internal static long smethod_0()
		{
			return Stopwatch.GetTimestamp();
		}
	}
}
