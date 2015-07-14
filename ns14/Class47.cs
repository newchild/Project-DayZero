using ns8;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ns14
{
	// Token: 0x020001A8 RID: 424
	internal sealed class Class47
	{
		// Token: 0x04000BB8 RID: 3000
		private readonly Class26<Struct17> class26_0 = new Class26<Struct17>();

		// Token: 0x04000BB9 RID: 3001
		protected int int_0;

		// Token: 0x04000BB7 RID: 2999
		private readonly Queue<VoidDelegate> queue_0 = new Queue<VoidDelegate>();

		// Token: 0x04000BBA RID: 3002
		private Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x06000EEF RID: 3823
		// RVA: 0x000516FC File Offset: 0x0004F8FC
		public Class47()
		{
			this.int_0 = Thread.CurrentThread.ManagedThreadId;
			this.stopwatch_0.Start();
		}

		// Token: 0x06000EF2 RID: 3826
		// RVA: 0x00051958 File Offset: 0x0004FB58
		public virtual void Add(VoidDelegate voidDelegate_0, bool bool_0)
		{
			if (!bool_0 && Thread.CurrentThread.ManagedThreadId == this.int_0)
			{
				voidDelegate_0();
				return;
			}
			lock (this.queue_0)
			{
				this.queue_0.Enqueue(voidDelegate_0);
			}
		}

		// Token: 0x06000EF0 RID: 3824
		// RVA: 0x0005174C File Offset: 0x0004F94C
		public bool method_0()
		{
			lock (this.class26_0)
			{
				long elapsedMilliseconds = this.stopwatch_0.ElapsedMilliseconds;
				for (int i = 0; i < this.class26_0.Count; i++)
				{
					Struct17 struct = this.class26_0[i];
					if (struct.long_0 < elapsedMilliseconds)
					{
						lock (this.queue_0)
						{
							this.queue_0.Enqueue(struct.voidDelegate_0);
						}
						this.class26_0.RemoveAt(i--);
						if (struct.int_0 > 0)
						{
							this.class26_0.method_0(new Struct17(struct.voidDelegate_0, this.stopwatch_0.ElapsedMilliseconds + (long)struct.int_0, struct.int_0));
						}
					}
				}
			}
			VoidDelegate[] array;
			lock (this.queue_0)
			{
				int count = this.queue_0.Count;
				if (count == 0)
				{
					return false;
				}
				array = new VoidDelegate[count];
				this.queue_0.CopyTo(array, 0);
				this.queue_0.Clear();
			}
			VoidDelegate[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				VoidDelegate object_ = array2[j];
				try
				{
					VoidDelegate voidDelegate = new VoidDelegate(object_.Invoke);
					voidDelegate();
				}
				catch (Exception arg)
				{
					Console.WriteLine("super duper error on delegate " + arg);
				}
			}
			return true;
		}

		// Token: 0x06000EF1 RID: 3825
		// RVA: 0x000518F8 File Offset: 0x0004FAF8
		public void method_1(VoidDelegate voidDelegate_0, int int_1, bool bool_0)
		{
			Struct17 gparam_ = new Struct17(voidDelegate_0, this.stopwatch_0.ElapsedMilliseconds + (long)int_1, bool_0 ? int_1 : 0);
			lock (this.class26_0)
			{
				this.class26_0.method_0(gparam_);
			}
		}

		// Token: 0x06000EF3 RID: 3827
		// RVA: 0x000519B4 File Offset: 0x0004FBB4
		public bool method_2(VoidDelegate voidDelegate_0)
		{
			if (this.queue_0.Contains(voidDelegate_0))
			{
				return false;
			}
			lock (this.queue_0)
			{
				this.queue_0.Enqueue(voidDelegate_0);
			}
			return true;
		}
	}
}
