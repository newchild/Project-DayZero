using ns29;
using System;
using System.Threading;

namespace ns14
{
	// Token: 0x0200049E RID: 1182
	internal class Class607 : Interface19
	{
		// Token: 0x04001F56 RID: 8022
		private double double_0;

		// Token: 0x04001F57 RID: 8023
		public double double_1;

		// Token: 0x04001F58 RID: 8024
		internal double double_2 = -1.7976931348623157E+308;

		// Token: 0x04001F59 RID: 8025
		internal double double_3 = 1.7976931348623157E+308;

		// Token: 0x04001F5A RID: 8026
		private EventHandler eventHandler_0;

		// Token: 0x17000388 RID: 904
		public virtual double Value
		{
			// Token: 0x060025DE RID: 9694
			// RVA: 0x0001D6B2 File Offset: 0x0001B8B2
			get
			{
				return this.double_0;
			}
			// Token: 0x060025DF RID: 9695
			// RVA: 0x000E36A0 File Offset: 0x000E18A0
			set
			{
				double num = value;
				if (num > this.double_3)
				{
					num = this.double_3;
				}
				else if (num < this.double_2)
				{
					num = this.double_2;
				}
				if (num == this.double_0)
				{
					return;
				}
				this.double_0 = num;
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, null);
				}
			}
		}

		// Token: 0x060025E0 RID: 9696
		// RVA: 0x0001D6BA File Offset: 0x0001B8BA
		public Class607(double double_4)
		{
			this.double_0 = double_4;
		}

		// Token: 0x060025E4 RID: 9700
		// RVA: 0x000E36F8 File Offset: 0x000E18F8
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

		// Token: 0x060025E5 RID: 9701
		// RVA: 0x000E3730 File Offset: 0x000E1930
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

		// Token: 0x060025E1 RID: 9697
		// RVA: 0x0001D6E7 File Offset: 0x0001B8E7
		public static implicit operator double(Class607 class607_0)
		{
			if (class607_0 != null)
			{
				return class607_0.Value;
			}
			return 0.0;
		}

		// Token: 0x060025E2 RID: 9698
		// RVA: 0x0001D6FC File Offset: 0x0001B8FC
		public override string ToString()
		{
			return this.double_0.ToString("0.##", Class115.numberFormatInfo_0);
		}

		// Token: 0x060025E3 RID: 9699
		// RVA: 0x0001D713 File Offset: 0x0001B913
		public void vmethod_0()
		{
			this.eventHandler_0 = null;
		}
	}
}
