using System;
using System.Threading;

namespace ns30
{
	// Token: 0x020001D0 RID: 464
	internal abstract class Class129
	{
		// Token: 0x020001D1 RID: 465
		// Token: 0x0600108D RID: 4237
		internal delegate void Delegate5();

		// Token: 0x020001D2 RID: 466
		// Token: 0x06001091 RID: 4241
		internal delegate void Delegate6(object object_0, long long_0, long long_1);

		// Token: 0x04000C86 RID: 3206
		internal bool bool_0;

		// Token: 0x04000C87 RID: 3207
		internal bool bool_1;

		// Token: 0x04000C84 RID: 3204
		public string string_0;

		// Token: 0x04000C85 RID: 3205
		internal Thread thread_0;

		// Token: 0x06001088 RID: 4232
		// RVA: 0x000101DC File Offset: 0x0000E3DC
		public Class129(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600108A RID: 4234
		// RVA: 0x000101EB File Offset: 0x0000E3EB
		public virtual void Abort()
		{
			if (this.bool_1)
			{
				this.bool_0 = true;
				return;
			}
			if (this.thread_0 != null && this.thread_0.IsAlive)
			{
				this.thread_0.Abort();
			}
		}

		// Token: 0x06001089 RID: 4233
		public abstract void Perform(bool bool_2);

		// Token: 0x0600108B RID: 4235
		public abstract void vmethod_0(Exception exception_0);
	}
}
