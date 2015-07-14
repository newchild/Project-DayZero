using ns79;
using ns82;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ns27
{
	// Token: 0x02000491 RID: 1169
	internal sealed class Class597 : IDisposable
	{
		// Token: 0x04001F30 RID: 7984
		private bool bool_0;

		// Token: 0x04001F31 RID: 7985
		private bool bool_1;

		// Token: 0x04001F2F RID: 7983
		private Class911 class911_0;

		// Token: 0x04001F32 RID: 7986
		private EventHandler eventHandler_0;

		// Token: 0x04001F2E RID: 7982
		internal List<Class598> list_0;

		// Token: 0x0600259B RID: 9627
		// RVA: 0x0001D3D3 File Offset: 0x0001B5D3
		internal Class597(Class911 class911_1) : this(class911_1, new List<Class598>())
		{
		}

		// Token: 0x0600259C RID: 9628
		// RVA: 0x0001D3E1 File Offset: 0x0001B5E1
		internal Class597(Class911 class911_1, List<Class598> list_1)
		{
			this.list_0 = list_1;
			this.class911_0 = class911_1;
			this.bool_0 = false;
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_5), Enum98.const_2, Enum97.const_0);
		}

		// Token: 0x060025A1 RID: 9633
		// RVA: 0x000E2D24 File Offset: 0x000E0F24
		internal void ClearItems()
		{
			foreach (Class598 current in this.list_0)
			{
				current.Dispose();
			}
			this.list_0.Clear();
		}

		// Token: 0x060025A4 RID: 9636
		// RVA: 0x0001D46C File Offset: 0x0001B66C
		public void Dispose()
		{
			this.ClearItems();
		}

		// Token: 0x0600259D RID: 9629
		// RVA: 0x0001D412 File Offset: 0x0001B612
		internal void method_0()
		{
			if (this.method_3())
			{
				this.method_2();
				return;
			}
			this.method_1();
		}

		// Token: 0x0600259E RID: 9630
		// RVA: 0x000E2C5C File Offset: 0x000E0E5C
		internal void method_1()
		{
			this.bool_0 = true;
			this.bool_1 = true;
			int num = 0;
			foreach (Class598 current in this.list_0)
			{
				current.method_0(num);
				num += 20;
			}
		}

		// Token: 0x0600259F RID: 9631
		// RVA: 0x000E2CC8 File Offset: 0x000E0EC8
		internal void method_2()
		{
			this.bool_0 = false;
			foreach (Class598 current in this.list_0)
			{
				current.method_1();
			}
		}

		// Token: 0x060025A0 RID: 9632
		// RVA: 0x0001D429 File Offset: 0x0001B629
		internal bool method_3()
		{
			return this.bool_0;
		}

		// Token: 0x060025A2 RID: 9634
		// RVA: 0x000E2D84 File Offset: 0x000E0F84
		internal void method_4(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060025A3 RID: 9635
		// RVA: 0x0001D431 File Offset: 0x0001B631
		private bool method_5(object object_0, EventArgs eventArgs_0)
		{
			if (this.method_3() && !this.bool_1)
			{
				this.method_2();
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
				}
				return true;
			}
			this.bool_1 = false;
			return false;
		}
	}
}
