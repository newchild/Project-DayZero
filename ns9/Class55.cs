using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading;

namespace ns9
{
	// Token: 0x020001B7 RID: 439
	internal class Class55 : Class54, Interface8
	{
		// Token: 0x04000BD4 RID: 3028
		private bool bool_1;

		// Token: 0x04000BD5 RID: 3029
		private EventHandler eventHandler_2;

		// Token: 0x04000BD6 RID: 3030
		private EventHandler eventHandler_3;

		// Token: 0x04000BD2 RID: 3026
		private IGraphicsDeviceService igraphicsDeviceService_0;

		// Token: 0x04000BD3 RID: 3027
		private int int_1;

		// Token: 0x06000F40 RID: 3904
		// RVA: 0x0000F2EB File Offset: 0x0000D4EB
		public Class55(Class114 class114_1) : base(class114_1)
		{
			this.bool_1 = true;
		}

		// Token: 0x06000F4C RID: 3916
		// RVA: 0x00053318 File Offset: 0x00051518
		protected override void Dispose(bool bool_2)
		{
			if (bool_2 && this.igraphicsDeviceService_0 != null)
			{
				this.igraphicsDeviceService_0.remove_DeviceCreated(new EventHandler(this.igraphicsDeviceService_0_DeviceCreated));
				this.igraphicsDeviceService_0.remove_DeviceResetting(new EventHandler(this.igraphicsDeviceService_0_DeviceResetting));
				this.igraphicsDeviceService_0.remove_DeviceReset(new EventHandler(this.igraphicsDeviceService_0_DeviceReset));
				this.igraphicsDeviceService_0.remove_DeviceDisposing(new EventHandler(this.igraphicsDeviceService_0_DeviceDisposing));
			}
			base.Dispose(bool_2);
		}

		// Token: 0x06000F44 RID: 3908
		// RVA: 0x0000653E File Offset: 0x0000473E
		public virtual void Draw()
		{
		}

		// Token: 0x06000F48 RID: 3912
		// RVA: 0x0000F329 File Offset: 0x0000D529
		private void igraphicsDeviceService_0_DeviceCreated(object sender, EventArgs e)
		{
			this.vmethod_2(true);
		}

		// Token: 0x06000F49 RID: 3913
		// RVA: 0x0000F332 File Offset: 0x0000D532
		private void igraphicsDeviceService_0_DeviceDisposing(object sender, EventArgs e)
		{
			this.vmethod_4(true);
		}

		// Token: 0x06000F4A RID: 3914
		// RVA: 0x0000F33B File Offset: 0x0000D53B
		private void igraphicsDeviceService_0_DeviceReset(object sender, EventArgs e)
		{
			this.vmethod_2(false);
		}

		// Token: 0x06000F4B RID: 3915
		// RVA: 0x0000F344 File Offset: 0x0000D544
		private void igraphicsDeviceService_0_DeviceResetting(object sender, EventArgs e)
		{
			this.vmethod_4(false);
		}

		// Token: 0x06000F41 RID: 3905
		// RVA: 0x00053270 File Offset: 0x00051470
		public void imethod_5(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F42 RID: 3906
		// RVA: 0x000532A8 File Offset: 0x000514A8
		public void imethod_6(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F45 RID: 3909
		// RVA: 0x0000F2FB File Offset: 0x0000D4FB
		public int imethod_7()
		{
			return this.int_1;
		}

		// Token: 0x06000F46 RID: 3910
		// RVA: 0x0000F303 File Offset: 0x0000D503
		public virtual bool imethod_8()
		{
			return this.bool_1;
		}

		// Token: 0x06000F4D RID: 3917
		// RVA: 0x00053394 File Offset: 0x00051594
		public override void Initialize()
		{
			base.Initialize();
			this.igraphicsDeviceService_0 = (base.method_0().method_3().GetService(typeof(IGraphicsDeviceService)) as IGraphicsDeviceService);
			if (this.igraphicsDeviceService_0 == null)
			{
				throw new InvalidOperationException(Class127.smethod_9());
			}
			this.igraphicsDeviceService_0.add_DeviceCreated(new EventHandler(this.igraphicsDeviceService_0_DeviceCreated));
			this.igraphicsDeviceService_0.add_DeviceResetting(new EventHandler(this.igraphicsDeviceService_0_DeviceResetting));
			this.igraphicsDeviceService_0.add_DeviceReset(new EventHandler(this.igraphicsDeviceService_0_DeviceReset));
			this.igraphicsDeviceService_0.add_DeviceDisposing(new EventHandler(this.igraphicsDeviceService_0_DeviceDisposing));
			if (this.igraphicsDeviceService_0.get_GraphicsDevice() != null)
			{
				this.vmethod_2(true);
			}
		}

		// Token: 0x06000F43 RID: 3907
		// RVA: 0x000532E0 File Offset: 0x000514E0
		public void vmethod_0(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F47 RID: 3911
		// RVA: 0x0000F30B File Offset: 0x0000D50B
		public virtual void vmethod_1(bool bool_2)
		{
			if (this.bool_1 != bool_2)
			{
				this.bool_1 = bool_2;
				this.vmethod_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F4E RID: 3918
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_2(bool bool_2)
		{
		}

		// Token: 0x06000F4F RID: 3919
		// RVA: 0x0000F34D File Offset: 0x0000D54D
		protected virtual void vmethod_3(object sender, EventArgs e)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000F50 RID: 3920
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_4(bool bool_2)
		{
		}
	}
}
