using ns45;
using ns48;
using System;
using System.Threading;

namespace ns43
{
	// Token: 0x020002CF RID: 719
	internal sealed class Class249 : IDisposable, IEquatable<Class249>
	{
		// Token: 0x04001187 RID: 4487
		private bool bool_0;

		// Token: 0x04001188 RID: 4488
		private Class272 class272_0;

		// Token: 0x04001189 RID: 4489
		private Class277 class277_0;

		// Token: 0x04001186 RID: 4486
		private EventHandler<EventArgs11> eventHandler_0;

		// Token: 0x060016C6 RID: 5830
		// RVA: 0x0001414C File Offset: 0x0001234C
		public void Dispose()
		{
			this.bool_0 = true;
		}

		// Token: 0x060016C8 RID: 5832
		// RVA: 0x0007285C File Offset: 0x00070A5C
		public override bool Equals(object obj)
		{
			Class249 class = obj as Class249;
			return class != null && this.Equals(class);
		}

		// Token: 0x060016C9 RID: 5833
		// RVA: 0x00014162 File Offset: 0x00012362
		public bool Equals(Class249 other)
		{
			return other != null && Class272.smethod_0(this.class272_0, other.class272_0);
		}

		// Token: 0x060016CA RID: 5834
		// RVA: 0x0001417A File Offset: 0x0001237A
		public override int GetHashCode()
		{
			return this.class272_0.GetHashCode();
		}

		// Token: 0x060016C4 RID: 5828
		// RVA: 0x00072824 File Offset: 0x00070A24
		internal void method_0(EventHandler<EventArgs11> eventHandler_1)
		{
			EventHandler<EventArgs11> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs11> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs11> value = (EventHandler<EventArgs11>)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs11>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060016C5 RID: 5829
		// RVA: 0x00014144 File Offset: 0x00012344
		public Class277 method_1()
		{
			return this.class277_0;
		}

		// Token: 0x060016C7 RID: 5831
		// RVA: 0x00014155 File Offset: 0x00012355
		public override string ToString()
		{
			return this.method_1().Name;
		}
	}
}
