using MonoTorrent.Common;
using ns48;
using ns53;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ns43
{
	// Token: 0x020002C3 RID: 707
	internal sealed class Class238
	{
		// Token: 0x020002C4 RID: 708
		private sealed class Class239
		{
			// Token: 0x04001158 RID: 4440
			private bool bool_0;

			// Token: 0x0400115E RID: 4446
			private bool bool_1;

			// Token: 0x04001159 RID: 4441
			private Delegate27 delegate27_0;

			// Token: 0x0400115C RID: 4444
			private Delegate28 delegate28_0;

			// Token: 0x0400115D RID: 4445
			private Delegate29 delegate29_0;

			// Token: 0x0400115B RID: 4443
			private Exception exception_0;

			// Token: 0x04001157 RID: 4439
			private ManualResetEvent manualResetEvent_0;

			// Token: 0x0400115A RID: 4442
			private object object_0;

			// Token: 0x17000301 RID: 769
			public ManualResetEvent WaitHandle
			{
				// Token: 0x060016A7 RID: 5799
				// RVA: 0x00013FD7 File Offset: 0x000121D7
				get
				{
					return this.manualResetEvent_0;
				}
			}

			// Token: 0x060016A8 RID: 5800
			// RVA: 0x00013FDF File Offset: 0x000121DF
			public Class239()
			{
				this.manualResetEvent_0 = new ManualResetEvent(false);
			}

			// Token: 0x060016A9 RID: 5801
			// RVA: 0x000723BC File Offset: 0x000705BC
			public void Execute()
			{
				try
				{
					if (this.delegate27_0 != null)
					{
						this.object_0 = this.delegate27_0();
					}
					else if (this.delegate28_0 != null)
					{
						this.delegate28_0();
					}
					else if (this.delegate29_0 != null)
					{
						this.bool_1 = this.delegate29_0();
					}
				}
				catch (Exception ex)
				{
					this.exception_0 = ex;
					if (!this.method_0())
					{
						throw;
					}
				}
				finally
				{
					this.manualResetEvent_0.Set();
				}
			}

			// Token: 0x060016A3 RID: 5795
			// RVA: 0x00013FB5 File Offset: 0x000121B5
			public bool method_0()
			{
				return this.bool_0;
			}

			// Token: 0x060016A4 RID: 5796
			// RVA: 0x00013FBD File Offset: 0x000121BD
			public void method_1(bool bool_2)
			{
				this.bool_0 = bool_2;
			}

			// Token: 0x060016A5 RID: 5797
			// RVA: 0x00013FC6 File Offset: 0x000121C6
			public Exception method_2()
			{
				return this.exception_0;
			}

			// Token: 0x060016A6 RID: 5798
			// RVA: 0x00013FCE File Offset: 0x000121CE
			public void method_3(Delegate28 delegate28_1)
			{
				this.delegate28_0 = delegate28_1;
			}

			// Token: 0x060016AA RID: 5802
			// RVA: 0x00013FF3 File Offset: 0x000121F3
			public void method_4()
			{
				this.bool_0 = false;
				this.delegate27_0 = null;
				this.object_0 = null;
				this.exception_0 = null;
				this.delegate28_0 = null;
				this.delegate29_0 = null;
				this.bool_1 = false;
			}
		}

		// Token: 0x04001153 RID: 4435
		private AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);

		// Token: 0x04001152 RID: 4434
		private Class274 class274_0 = new Class274();

		// Token: 0x04001154 RID: 4436
		private Queue<Class238.Class239> queue_0 = new Queue<Class238.Class239>();

		// Token: 0x04001155 RID: 4437
		private Queue<Class238.Class239> queue_1 = new Queue<Class238.Class239>();

		// Token: 0x04001156 RID: 4438
		internal Thread thread_0;

		// Token: 0x0600169B RID: 5787
		// RVA: 0x00072158 File Offset: 0x00070358
		public Class238(string string_0)
		{
			WaitCallback callBack = delegate(object object_0)
			{
				this.thread_0 = Thread.CurrentThread;
				this.method_0();
			};
			ThreadPool.QueueUserWorkItem(callBack);
		}

		// Token: 0x0600169C RID: 5788
		// RVA: 0x000721B0 File Offset: 0x000703B0
		private void method_0()
		{
			while (true)
			{
				Class238.Class239 class = null;
				lock (this.queue_1)
				{
					if (this.queue_1.Count > 0)
					{
						class = this.queue_1.Dequeue();
					}
					goto IL_5C;
				}
				IL_32:
				this.autoResetEvent_0.WaitOne();
				continue;
				IL_5C:
				if (class == null)
				{
					goto IL_32;
				}
				bool flag = !class.method_0();
				class.Execute();
				if (flag)
				{
					this.method_4(class);
				}
			}
		}

		// Token: 0x0600169D RID: 5789
		// RVA: 0x00072230 File Offset: 0x00070430
		private void method_1(Class238.Class239 class239_0, Enum36 enum36_0)
		{
			lock (this.queue_1)
			{
				this.queue_1.Enqueue(class239_0);
				this.autoResetEvent_0.Set();
			}
		}

		// Token: 0x0600169E RID: 5790
		// RVA: 0x0007227C File Offset: 0x0007047C
		public void method_2(Delegate28 delegate28_0)
		{
			Class238.Class239 class = this.method_5();
			class.method_3(delegate28_0);
			try
			{
				this.method_3(class);
			}
			finally
			{
				this.method_4(class);
			}
		}

		// Token: 0x0600169F RID: 5791
		// RVA: 0x000722B8 File Offset: 0x000704B8
		private void method_3(Class238.Class239 class239_0)
		{
			class239_0.WaitHandle.Reset();
			class239_0.method_1(true);
			if (Thread.CurrentThread == this.thread_0)
			{
				class239_0.Execute();
			}
			else
			{
				this.method_1(class239_0, Enum36.const_5);
			}
			class239_0.WaitHandle.WaitOne();
			if (class239_0.method_2() != null)
			{
				throw new TorrentException("Exception in mainloop", class239_0.method_2());
			}
		}

		// Token: 0x060016A0 RID: 5792
		// RVA: 0x0007231C File Offset: 0x0007051C
		private void method_4(Class238.Class239 class239_0)
		{
			class239_0.method_4();
			lock (this.queue_0)
			{
				this.queue_0.Enqueue(class239_0);
			}
		}

		// Token: 0x060016A1 RID: 5793
		// RVA: 0x00072364 File Offset: 0x00070564
		private Class238.Class239 method_5()
		{
			lock (this.queue_0)
			{
				if (this.queue_0.Count > 0)
				{
					return this.queue_0.Dequeue();
				}
			}
			return new Class238.Class239();
		}
	}
}
