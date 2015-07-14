using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns30
{
	// Token: 0x0200021D RID: 541
	internal static class Class169
	{
		// Token: 0x0200021E RID: 542
		[CompilerGenerated]
		private sealed class Class170
		{
			// Token: 0x04000E8C RID: 3724
			public bool bool_0;

			// Token: 0x04000E8E RID: 3726
			public Class129 class129_0;

			// Token: 0x04000E8D RID: 3725
			public int int_0;

			// Token: 0x0600134B RID: 4939
			// RVA: 0x00063F08 File Offset: 0x00062108
			public void method_0(object object_0)
			{
				try
				{
					if (this.bool_0)
					{
						this.class129_0.bool_1 = true;
						Thread.Sleep(this.int_0);
						this.class129_0.bool_1 = false;
					}
					if (!this.class129_0.bool_0)
					{
						this.class129_0.Perform(false);
					}
				}
				catch (ThreadAbortException)
				{
				}
				catch (Exception exception_)
				{
					this.class129_0.vmethod_0(exception_);
				}
			}
		}

		// Token: 0x04000E8A RID: 3722
		private static int int_0;

		// Token: 0x04000E89 RID: 3721
		private static long long_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly object object_0 = new object();

		// Token: 0x06001348 RID: 4936
		// RVA: 0x00063E24 File Offset: 0x00062024
		public static bool smethod_0(Class129 class129_0)
		{
			Class169.Class170 class = new Class169.Class170();
			class.class129_0 = class129_0;
			if (class.class129_0 == null)
			{
				throw new ArgumentNullException();
			}
			class.bool_0 = false;
			lock (Class169.object_0)
			{
				long ticks = DateTime.Now.Ticks;
				if (ticks - Class169.long_0 < 1500000L)
				{
					class.bool_0 = true;
					Class169.int_0++;
				}
				else
				{
					Class169.int_0 = 0;
				}
				class.int_0 = Class169.int_0 * 150;
				Class169.long_0 = ticks;
			}
			ParameterizedThreadStart start = new ParameterizedThreadStart(class.method_0);
			Thread thread = new Thread(start);
			thread.Priority = ThreadPriority.Highest;
			thread.IsBackground = true;
			thread.Start();
			class.class129_0.thread_0 = thread;
			return true;
		}
	}
}
