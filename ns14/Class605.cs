using System;
using System.Threading;

namespace ns14
{
	// Token: 0x0200049C RID: 1180
	internal sealed class Class605<T> : Interface18, Interface19 where T : IComparable
	{
		// Token: 0x04001F51 RID: 8017
		private EventHandler eventHandler_0;

		// Token: 0x04001F4F RID: 8015
		private T gparam_0;

		// Token: 0x04001F50 RID: 8016
		public T gparam_1;

		// Token: 0x04001F52 RID: 8018
		private string string_0;

		// Token: 0x17000385 RID: 901
		public string Description
		{
			// Token: 0x060025D1 RID: 9681
			// RVA: 0x0001D606 File Offset: 0x0001B806
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000386 RID: 902
		public T Value
		{
			// Token: 0x060025C8 RID: 9672
			// RVA: 0x0001D59A File Offset: 0x0001B79A
			get
			{
				return this.gparam_0;
			}
			// Token: 0x060025C9 RID: 9673
			// RVA: 0x0001D5A2 File Offset: 0x0001B7A2
			set
			{
				if (this.gparam_0.CompareTo(value) == 0)
				{
					return;
				}
				this.gparam_0 = value;
				this.method_0();
			}
		}

		// Token: 0x060025CA RID: 9674
		// RVA: 0x00005E0F File Offset: 0x0000400F
		public Class605()
		{
		}

		// Token: 0x060025CB RID: 9675
		// RVA: 0x0001D5CB File Offset: 0x0001B7CB
		public Class605(T gparam_2)
		{
			this.gparam_0 = gparam_2;
		}

		// Token: 0x060025CE RID: 9678
		// RVA: 0x0001D5E2 File Offset: 0x0001B7E2
		public object imethod_0()
		{
			return this.Value;
		}

		// Token: 0x060025CF RID: 9679
		// RVA: 0x000E3600 File Offset: 0x000E1800
		public void imethod_1(object object_0)
		{
			try
			{
				this.Value = (T)((object)object_0);
			}
			catch
			{
			}
		}

		// Token: 0x060025C6 RID: 9670
		// RVA: 0x000E3590 File Offset: 0x000E1790
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

		// Token: 0x060025C7 RID: 9671
		// RVA: 0x000E35C8 File Offset: 0x000E17C8
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

		// Token: 0x060025D0 RID: 9680
		// RVA: 0x0001D5EF File Offset: 0x0001B7EF
		internal void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x060025CC RID: 9676
		// RVA: 0x0001D59A File Offset: 0x0001B79A
		public static implicit operator T(Class605<T> class605_0)
		{
			return class605_0.gparam_0;
		}

		// Token: 0x060025CD RID: 9677
		// RVA: 0x0001D5DA File Offset: 0x0001B7DA
		public static implicit operator Class605<T>(T gparam_2)
		{
			return new Class605<T>(gparam_2);
		}

		// Token: 0x060025D3 RID: 9683
		// RVA: 0x0001D622 File Offset: 0x0001B822
		internal void Reset()
		{
			this.Value = this.gparam_1;
		}

		// Token: 0x060025D2 RID: 9682
		// RVA: 0x0001D60F File Offset: 0x0001B80F
		public override string ToString()
		{
			return this.gparam_0.ToString();
		}
	}
}
