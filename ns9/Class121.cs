using Microsoft.Xna.Framework;
using System;
using System.Threading;

namespace ns9
{
	// Token: 0x020001BF RID: 447
	internal abstract class Class121
	{
		// Token: 0x04000C04 RID: 3076
		private EventHandler eventHandler_0;

		// Token: 0x04000C05 RID: 3077
		private EventHandler eventHandler_1;

		// Token: 0x04000C06 RID: 3078
		private EventHandler eventHandler_2;

		// Token: 0x04000C07 RID: 3079
		private EventHandler eventHandler_3;

		// Token: 0x04000C08 RID: 3080
		private EventHandler eventHandler_4;

		// Token: 0x04000C01 RID: 3073
		internal static readonly int int_0 = 600;

		// Token: 0x04000C02 RID: 3074
		internal static readonly int int_1 = 800;

		// Token: 0x04000C03 RID: 3075
		private string string_0 = string.Empty;

		// Token: 0x17000288 RID: 648
		public string Title
		{
			// Token: 0x06000FAC RID: 4012
			// RVA: 0x0000F6EA File Offset: 0x0000D8EA
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException(Class127.smethod_20());
				}
				if (this.string_0 != value)
				{
					this.string_0 = value;
					this.vmethod_7(this.string_0);
				}
			}
		}

		// Token: 0x06000FA6 RID: 4006
		// RVA: 0x0000F6D7 File Offset: 0x0000D8D7
		internal Class121()
		{
		}

		// Token: 0x06000FAD RID: 4013
		// RVA: 0x00053EF4 File Offset: 0x000520F4
		internal void method_0(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FAE RID: 4014
		// RVA: 0x00053F2C File Offset: 0x0005212C
		public void method_1(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FAF RID: 4015
		// RVA: 0x00053F64 File Offset: 0x00052164
		public void method_2(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FB0 RID: 4016
		// RVA: 0x00053F9C File Offset: 0x0005219C
		internal void method_3(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FB1 RID: 4017
		// RVA: 0x00053FD4 File Offset: 0x000521D4
		public void method_4(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FB2 RID: 4018
		// RVA: 0x0005400C File Offset: 0x0005220C
		public void method_5(EventHandler eventHandler_5)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_5);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FB5 RID: 4021
		// RVA: 0x0000F71B File Offset: 0x0000D91B
		protected void method_6()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FB6 RID: 4022
		// RVA: 0x0000F736 File Offset: 0x0000D936
		protected void method_7()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FB7 RID: 4023
		// RVA: 0x0000F751 File Offset: 0x0000D951
		protected void method_8()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FB9 RID: 4025
		// RVA: 0x0000F787 File Offset: 0x0000D987
		protected void method_9()
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FB8 RID: 4024
		// RVA: 0x0000F76C File Offset: 0x0000D96C
		protected void OnPaint()
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000FA7 RID: 4007
		public abstract Rectangle vmethod_0();

		// Token: 0x06000FA8 RID: 4008
		public abstract IntPtr vmethod_1();

		// Token: 0x06000FA9 RID: 4009
		public abstract bool vmethod_2();

		// Token: 0x06000FAA RID: 4010
		internal abstract void vmethod_3(bool bool_0);

		// Token: 0x06000FAB RID: 4011
		public abstract string vmethod_4();

		// Token: 0x06000FB3 RID: 4019
		public abstract void vmethod_5(bool bool_0);

		// Token: 0x06000FB4 RID: 4020
		public abstract void vmethod_6(string string_1, int int_2, int int_3);

		// Token: 0x06000FBA RID: 4026
		protected abstract void vmethod_7(string string_1);
	}
}
