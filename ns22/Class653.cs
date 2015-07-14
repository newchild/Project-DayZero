using osu.GameModes.Play.Components;
using System;

namespace ns22
{
	// Token: 0x020004EA RID: 1258
	internal sealed class Class653 : IComparable<Class653>
	{
		// Token: 0x04002193 RID: 8595
		internal CommentTargets commentTargets_0;

		// Token: 0x04002192 RID: 8594
		internal int int_0;

		// Token: 0x04002194 RID: 8596
		internal string string_0;

		// Token: 0x04002195 RID: 8597
		internal string string_1;

		// Token: 0x06002896 RID: 10390
		// RVA: 0x0001F457 File Offset: 0x0001D657
		internal Class653(int int_1, CommentTargets commentTargets_1, string string_2, string string_3)
		{
			this.int_0 = int_1;
			this.commentTargets_0 = commentTargets_1;
			this.string_0 = string_2;
			this.string_1 = string_3;
		}

		// Token: 0x06002898 RID: 10392
		// RVA: 0x0001F49C File Offset: 0x0001D69C
		public int CompareTo(Class653 obj)
		{
			return this.int_0.CompareTo(obj.int_0);
		}

		// Token: 0x06002897 RID: 10391
		// RVA: 0x0001F47C File Offset: 0x0001D67C
		internal int method_0()
		{
			return 4000 + Math.Min(5000, this.string_1.Length * 60);
		}
	}
}
