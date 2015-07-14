using System;
using System.Threading;

namespace ns9
{
	// Token: 0x020001B5 RID: 437
	internal class Class54 : IDisposable, Interface6, Interface7
	{
		// Token: 0x04000BCD RID: 3021
		private bool bool_0 = true;

		// Token: 0x04000BCE RID: 3022
		private Class114 class114_0;

		// Token: 0x04000BD0 RID: 3024
		private EventHandler eventHandler_0;

		// Token: 0x04000BD1 RID: 3025
		private EventHandler eventHandler_1;

		// Token: 0x04000BCF RID: 3023
		private int int_0;

		// Token: 0x06000F32 RID: 3890
		// RVA: 0x0000F2AE File Offset: 0x0000D4AE
		public Class54(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x06000F33 RID: 3891
		// RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000F34 RID: 3892
		// RVA: 0x000531DC File Offset: 0x000513DC
		protected virtual void Dispose(bool bool_1)
		{
			if (bool_1)
			{
				lock (this)
				{
					if (this.method_0() != null)
					{
						this.method_0().method_0().Remove(this);
					}
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, EventArgs.Empty);
					}
				}
			}
		}

		// Token: 0x06000F35 RID: 3893
		// RVA: 0x00053240 File Offset: 0x00051440
		~Class54()
		{
			this.Dispose(false);
		}

		// Token: 0x06000F30 RID: 3888
		// RVA: 0x0005316C File Offset: 0x0005136C
		public void imethod_0(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F31 RID: 3889
		// RVA: 0x000531A4 File Offset: 0x000513A4
		public void imethod_1(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F37 RID: 3895
		// RVA: 0x0000653E File Offset: 0x0000473E
		public virtual void imethod_2()
		{
		}

		// Token: 0x06000F38 RID: 3896
		// RVA: 0x0000F2D3 File Offset: 0x0000D4D3
		public bool imethod_3()
		{
			return this.bool_0;
		}

		// Token: 0x06000F3A RID: 3898
		// RVA: 0x0000F2E3 File Offset: 0x0000D4E3
		public int imethod_4()
		{
			return this.int_0;
		}

		// Token: 0x06000F36 RID: 3894
		// RVA: 0x0000653E File Offset: 0x0000473E
		public virtual void Initialize()
		{
		}

		// Token: 0x06000F39 RID: 3897
		// RVA: 0x0000F2DB File Offset: 0x0000D4DB
		protected Class114 method_0()
		{
			return this.class114_0;
		}
	}
}
