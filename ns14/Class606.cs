using System;
using System.Threading;

namespace ns14
{
	// Token: 0x0200049D RID: 1181
	internal sealed class Class606 : Interface19
	{
		// Token: 0x04001F53 RID: 8019
		private bool bool_0;

		// Token: 0x04001F54 RID: 8020
		public bool bool_1;

		// Token: 0x04001F55 RID: 8021
		private EventHandler eventHandler_0;

		// Token: 0x17000387 RID: 903
		public bool Value
		{
			// Token: 0x060025D4 RID: 9684
			// RVA: 0x0001D630 File Offset: 0x0001B830
			get
			{
				return this.bool_0;
			}
			// Token: 0x060025D5 RID: 9685
			// RVA: 0x0001D638 File Offset: 0x0001B838
			set
			{
				if (value == this.bool_0)
				{
					return;
				}
				this.bool_0 = value;
				this.method_0();
			}
		}

		// Token: 0x060025D7 RID: 9687
		// RVA: 0x0001D668 File Offset: 0x0001B868
		public Class606(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x060025DC RID: 9692
		// RVA: 0x000E3630 File Offset: 0x000E1830
		public void imethod_2(EventHandler eventHandler_1)
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

		// Token: 0x060025DD RID: 9693
		// RVA: 0x000E3668 File Offset: 0x000E1868
		public void imethod_3(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060025D6 RID: 9686
		// RVA: 0x0001D651 File Offset: 0x0001B851
		internal void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x060025DB RID: 9691
		// RVA: 0x0001D6A1 File Offset: 0x0001B8A1
		public void method_1()
		{
			this.Value = !this.Value;
		}

		// Token: 0x060025D8 RID: 9688
		// RVA: 0x0001D677 File Offset: 0x0001B877
		public static implicit operator bool(Class606 class606_0)
		{
			return class606_0 != null && class606_0.Value;
		}

		// Token: 0x060025D9 RID: 9689
		// RVA: 0x0001D684 File Offset: 0x0001B884
		public static implicit operator Class606(bool bool_2)
		{
			return new Class606(bool_2);
		}

		// Token: 0x060025DA RID: 9690
		// RVA: 0x0001D68C File Offset: 0x0001B88C
		public override string ToString()
		{
			if (!this.bool_0)
			{
				return "0";
			}
			return "1";
		}
	}
}
