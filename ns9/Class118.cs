using System;
using System.Threading;

namespace ns9
{
	// Token: 0x020001BD RID: 445
	internal abstract class Class118
	{
		// Token: 0x04000BFA RID: 3066
		private EventHandler eventHandler_0;

		// Token: 0x04000BFB RID: 3067
		private EventHandler eventHandler_1;

		// Token: 0x04000BFC RID: 3068
		private EventHandler eventHandler_2;

		// Token: 0x04000BFD RID: 3069
		private EventHandler eventHandler_3;

		// Token: 0x04000BFE RID: 3070
		private EventHandler eventHandler_4;

		// Token: 0x04000BFF RID: 3071
		private EventHandler eventHandler_5;

		// Token: 0x06000F92 RID: 3986
		// RVA: 0x00053D08 File Offset: 0x00051F08
		internal void method_0(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F93 RID: 3987
		// RVA: 0x00053D40 File Offset: 0x00051F40
		internal void method_1(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F9E RID: 3998
		// RVA: 0x0000F645 File Offset: 0x0000D845
		protected void method_10()
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F9F RID: 3999
		// RVA: 0x0000F660 File Offset: 0x0000D860
		protected void method_11()
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F94 RID: 3988
		// RVA: 0x00053D78 File Offset: 0x00051F78
		internal void method_2(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F95 RID: 3989
		// RVA: 0x00053DB0 File Offset: 0x00051FB0
		internal void method_3(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F96 RID: 3990
		// RVA: 0x00053DE8 File Offset: 0x00051FE8
		internal void method_4(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F97 RID: 3991
		// RVA: 0x00053E20 File Offset: 0x00052020
		internal void method_5(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F9A RID: 3994
		// RVA: 0x0000F5D9 File Offset: 0x0000D7D9
		protected void method_6()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F9B RID: 3995
		// RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		protected void method_7()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F9C RID: 3996
		// RVA: 0x0000F60F File Offset: 0x0000D80F
		protected void method_8()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F9D RID: 3997
		// RVA: 0x0000F62A File Offset: 0x0000D82A
		protected void method_9()
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FA0 RID: 4000
		internal abstract void Run();

		// Token: 0x06000F99 RID: 3993
		internal abstract void vmethod_0();

		// Token: 0x06000FA1 RID: 4001
		internal abstract Class121 vmethod_1();
	}
}
