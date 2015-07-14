using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace ns9
{
	// Token: 0x020001BB RID: 443
	internal sealed class Class117 : Collection<Interface6>
	{
		// Token: 0x04000BF7 RID: 3063
		private EventHandler<EventArgs0> eventHandler_0;

		// Token: 0x04000BF8 RID: 3064
		private EventHandler<EventArgs0> eventHandler_1;

		// Token: 0x06000F89 RID: 3977
		// RVA: 0x0000F552 File Offset: 0x0000D752
		internal Class117()
		{
		}

		// Token: 0x06000F8A RID: 3978
		// RVA: 0x00053CA4 File Offset: 0x00051EA4
		protected override void ClearItems()
		{
			for (int i = 0; i < base.Count; i++)
			{
				this.method_3(new EventArgs0(base[i]));
			}
			base.ClearItems();
		}

		// Token: 0x06000F8B RID: 3979
		// RVA: 0x0000F55A File Offset: 0x0000D75A
		protected override void InsertItem(int index, Interface6 item)
		{
			if (base.IndexOf(item) != -1)
			{
				throw new ArgumentException(Class127.smethod_1());
			}
			base.InsertItem(index, item);
			if (item != null)
			{
				this.method_2(new EventArgs0(item));
			}
		}

		// Token: 0x06000F87 RID: 3975
		// RVA: 0x00053C34 File Offset: 0x00051E34
		public void method_0(EventHandler<EventArgs0> eventHandler_2)
		{
			EventHandler<EventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F88 RID: 3976
		// RVA: 0x00053C6C File Offset: 0x00051E6C
		public void method_1(EventHandler<EventArgs0> eventHandler_2)
		{
			EventHandler<EventArgs0> eventHandler = this.eventHandler_1;
			EventHandler<EventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs0> value = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F8C RID: 3980
		// RVA: 0x0000F588 File Offset: 0x0000D788
		private void method_2(EventArgs0 eventArgs0_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs0_0);
			}
		}

		// Token: 0x06000F8D RID: 3981
		// RVA: 0x0000F59F File Offset: 0x0000D79F
		private void method_3(EventArgs0 eventArgs0_0)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, eventArgs0_0);
			}
		}

		// Token: 0x06000F8E RID: 3982
		// RVA: 0x00053CDC File Offset: 0x00051EDC
		protected override void RemoveItem(int index)
		{
			Interface6 interface = base[index];
			base.RemoveItem(index);
			if (interface != null)
			{
				this.method_3(new EventArgs0(interface));
			}
		}

		// Token: 0x06000F8F RID: 3983
		// RVA: 0x0000F5B6 File Offset: 0x0000D7B6
		protected override void SetItem(int index, Interface6 item)
		{
			throw new NotSupportedException(Class127.smethod_2());
		}
	}
}
