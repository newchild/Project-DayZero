using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns9
{
	// Token: 0x020001B9 RID: 441
	internal class Class114 : IDisposable
	{
		// Token: 0x04000BD8 RID: 3032
		public static bool bool_0 = true;

		// Token: 0x04000BDF RID: 3039
		private bool bool_1;

		// Token: 0x04000BE0 RID: 3040
		private bool bool_2;

		// Token: 0x04000BE5 RID: 3045
		private bool bool_3;

		// Token: 0x04000BE6 RID: 3046
		private bool bool_4 = true;

		// Token: 0x04000BE7 RID: 3047
		private bool bool_5;

		// Token: 0x04000BEB RID: 3051
		public bool bool_6;

		// Token: 0x04000BEC RID: 3052
		public bool bool_7;

		// Token: 0x04000BF1 RID: 3057
		private bool bool_8 = true;

		// Token: 0x04000BD9 RID: 3033
		private readonly Class116 class116_0;

		// Token: 0x04000BDB RID: 3035
		private readonly Class117 class117_0;

		// Token: 0x04000BE3 RID: 3043
		private Class118 class118_0;

		// Token: 0x04000BDC RID: 3036
		private readonly Class120 class120_0 = new Class120();

		// Token: 0x04000BED RID: 3053
		private EventHandler eventHandler_0;

		// Token: 0x04000BEE RID: 3054
		private EventHandler eventHandler_1;

		// Token: 0x04000BEF RID: 3055
		private EventHandler eventHandler_2;

		// Token: 0x04000BF0 RID: 3056
		private EventHandler eventHandler_3;

		// Token: 0x04000BE2 RID: 3042
		private IGraphicsDeviceService igraphicsDeviceService_0;

		// Token: 0x04000BE1 RID: 3041
		private Interface9 interface9_0;

		// Token: 0x04000BDA RID: 3034
		private readonly List<Interface8> list_0 = new List<Interface8>();

		// Token: 0x04000BDD RID: 3037
		private readonly List<Interface7> list_1 = new List<Interface7>();

		// Token: 0x04000BDE RID: 3038
		private TimeSpan timeSpan_0;

		// Token: 0x04000BE4 RID: 3044
		private TimeSpan timeSpan_1;

		// Token: 0x04000BE8 RID: 3048
		private TimeSpan timeSpan_2;

		// Token: 0x04000BE9 RID: 3049
		private TimeSpan timeSpan_3;

		// Token: 0x04000BEA RID: 3050
		private TimeSpan timeSpan_4;

		// Token: 0x06000F54 RID: 3924
		// RVA: 0x00053458 File Offset: 0x00051658
		public Class114()
		{
			this.method_11();
			this.class117_0 = new Class117();
			this.class117_0.method_0(new EventHandler<EventArgs0>(this.method_13));
			this.class117_0.method_1(new EventHandler<EventArgs0>(this.method_14));
			this.class116_0 = new Class116();
			this.timeSpan_4 = TimeSpan.Zero;
			this.timeSpan_0 = TimeSpan.Zero;
			this.timeSpan_2 = TimeSpan.Zero;
			this.timeSpan_3 = TimeSpan.FromTicks(166667L);
			this.timeSpan_1 = TimeSpan.FromMilliseconds(20.0);
		}

		// Token: 0x06000F5A RID: 3930
		// RVA: 0x0000F3EE File Offset: 0x0000D5EE
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000F65 RID: 3941
		// RVA: 0x00053610 File Offset: 0x00051810
		protected virtual void Dispose(bool bool_9)
		{
			if (bool_9)
			{
				lock (this)
				{
					Interface6[] array = new Interface6[this.class117_0.Count];
					this.class117_0.CopyTo(array, 0);
					for (int i = 0; i < array.Length; i++)
					{
						IDisposable disposable = array[i] as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					IDisposable disposable2 = this.interface9_0 as IDisposable;
					if (disposable2 != null)
					{
						disposable2.Dispose();
					}
					this.method_23();
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, EventArgs.Empty);
					}
				}
			}
		}

		// Token: 0x06000F66 RID: 3942
		// RVA: 0x000536B8 File Offset: 0x000518B8
		protected virtual void Draw()
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Interface8 interface = this.list_0[i];
				if (interface.imethod_8())
				{
					interface.Draw();
				}
			}
		}

		// Token: 0x06000F6D RID: 3949
		// RVA: 0x000537F0 File Offset: 0x000519F0
		~Class114()
		{
			this.Dispose(false);
		}

		// Token: 0x06000F80 RID: 3968
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000F61 RID: 3937
		// RVA: 0x0000F417 File Offset: 0x0000D617
		private void igraphicsDeviceService_0_DeviceCreated(object sender, EventArgs e)
		{
			this.vmethod_4(true);
		}

		// Token: 0x06000F62 RID: 3938
		// RVA: 0x0000F420 File Offset: 0x0000D620
		private void igraphicsDeviceService_0_DeviceDisposing(object sender, EventArgs e)
		{
			this.vmethod_8(true);
		}

		// Token: 0x06000F63 RID: 3939
		// RVA: 0x0000F429 File Offset: 0x0000D629
		private void igraphicsDeviceService_0_DeviceReset(object sender, EventArgs e)
		{
			this.vmethod_4(false);
		}

		// Token: 0x06000F64 RID: 3940
		// RVA: 0x0000F432 File Offset: 0x0000D632
		private void igraphicsDeviceService_0_DeviceResetting(object sender, EventArgs e)
		{
			this.vmethod_8(false);
		}

		// Token: 0x06000F77 RID: 3959
		// RVA: 0x000539CC File Offset: 0x00051BCC
		protected virtual void Initialize()
		{
			for (int i = 0; i < this.class117_0.Count; i++)
			{
				this.class117_0[i].Initialize();
			}
			if (this.bool_6)
			{
				this.method_15();
				if (this.igraphicsDeviceService_0 != null && this.igraphicsDeviceService_0.get_GraphicsDevice() != null)
				{
					this.vmethod_4(true);
				}
			}
		}

		// Token: 0x06000F55 RID: 3925
		// RVA: 0x0000F3A2 File Offset: 0x0000D5A2
		public Class117 method_0()
		{
			return this.class117_0;
		}

		// Token: 0x06000F56 RID: 3926
		// RVA: 0x0000F3AA File Offset: 0x0000D5AA
		public bool method_1()
		{
			return this.bool_5;
		}

		// Token: 0x06000F68 RID: 3944
		// RVA: 0x0000F43B File Offset: 0x0000D63B
		private void method_10()
		{
			if (this.bool_2 || !this.bool_1)
			{
				return;
			}
			this.vmethod_9();
			if (this.bool_7)
			{
				return;
			}
			this.vmethod_0();
			this.Draw();
			this.vmethod_2();
		}

		// Token: 0x06000F6B RID: 3947
		// RVA: 0x00053740 File Offset: 0x00051940
		private void method_11()
		{
			if (this.class118_0 == null)
			{
				this.class118_0 = new Class119(this);
				this.class118_0.method_0(new EventHandler(this.method_16));
				this.class118_0.method_1(new EventHandler(this.method_17));
				this.class118_0.method_5(new EventHandler(this.method_21));
				this.class118_0.method_4(new EventHandler(this.method_20));
				this.class118_0.method_3(new EventHandler(this.method_19));
				this.class118_0.method_2(new EventHandler(this.method_18));
			}
		}

		// Token: 0x06000F6C RID: 3948
		// RVA: 0x0000F485 File Offset: 0x0000D685
		public void method_12()
		{
			this.bool_2 = true;
			this.class118_0.vmethod_0();
		}

		// Token: 0x06000F6E RID: 3950
		// RVA: 0x00053820 File Offset: 0x00051A20
		private void method_13(object sender, EventArgs0 e)
		{
			if (this.bool_3)
			{
				e.method_0().Initialize();
			}
			Interface7 interface = e.method_0() as Interface7;
			if (interface != null)
			{
				int num = this.list_1.BinarySearch(interface, Class128.class128_0);
				if (num < 0)
				{
					this.list_1.Insert(~num, interface);
					interface.imethod_0(new EventHandler(this.method_24));
				}
			}
			Interface8 interface2 = e.method_0() as Interface8;
			if (interface2 != null)
			{
				int num2 = this.list_0.BinarySearch(interface2, Class113.class113_0);
				if (num2 < 0)
				{
					this.list_0.Insert(~num2, interface2);
					interface2.imethod_5(new EventHandler(this.method_9));
				}
			}
		}

		// Token: 0x06000F6F RID: 3951
		// RVA: 0x000538CC File Offset: 0x00051ACC
		private void method_14(object sender, EventArgs0 e)
		{
			Interface7 interface = e.method_0() as Interface7;
			if (interface != null)
			{
				this.list_1.Remove(interface);
				interface.imethod_1(new EventHandler(this.method_24));
			}
			Interface8 interface2 = e.method_0() as Interface8;
			if (interface2 != null)
			{
				this.list_0.Remove(interface2);
				interface2.imethod_6(new EventHandler(this.method_9));
			}
		}

		// Token: 0x06000F70 RID: 3952
		// RVA: 0x00053938 File Offset: 0x00051B38
		private void method_15()
		{
			this.igraphicsDeviceService_0 = (this.method_3().GetService(typeof(IGraphicsDeviceService)) as IGraphicsDeviceService);
			if (this.igraphicsDeviceService_0 != null)
			{
				this.igraphicsDeviceService_0.add_DeviceCreated(new EventHandler(this.igraphicsDeviceService_0_DeviceCreated));
				this.igraphicsDeviceService_0.add_DeviceResetting(new EventHandler(this.igraphicsDeviceService_0_DeviceResetting));
				this.igraphicsDeviceService_0.add_DeviceReset(new EventHandler(this.igraphicsDeviceService_0_DeviceReset));
				this.igraphicsDeviceService_0.add_DeviceDisposing(new EventHandler(this.igraphicsDeviceService_0_DeviceDisposing));
			}
		}

		// Token: 0x06000F71 RID: 3953
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_16(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F72 RID: 3954
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_17(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F73 RID: 3955
		// RVA: 0x0000F499 File Offset: 0x0000D699
		private void method_18(object sender, EventArgs e)
		{
			this.vmethod_7(this, EventArgs.Empty);
		}

		// Token: 0x06000F74 RID: 3956
		// RVA: 0x0000F4A7 File Offset: 0x0000D6A7
		private void method_19(object sender, EventArgs e)
		{
			this.method_22();
		}

		// Token: 0x06000F57 RID: 3927
		// RVA: 0x0000F3B2 File Offset: 0x0000D5B2
		public void method_2(bool bool_9)
		{
			this.bool_5 = bool_9;
			if (this.method_4() != null)
			{
				this.method_4().vmethod_3(bool_9);
			}
		}

		// Token: 0x06000F75 RID: 3957
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_20(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F76 RID: 3958
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_21(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F7D RID: 3965
		// RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		public void method_22()
		{
			if (!this.bool_2)
			{
				this.method_10();
			}
		}

		// Token: 0x06000F7E RID: 3966
		// RVA: 0x00053ACC File Offset: 0x00051CCC
		private void method_23()
		{
			if (this.igraphicsDeviceService_0 != null)
			{
				this.igraphicsDeviceService_0.remove_DeviceCreated(new EventHandler(this.igraphicsDeviceService_0_DeviceCreated));
				this.igraphicsDeviceService_0.remove_DeviceResetting(new EventHandler(this.igraphicsDeviceService_0_DeviceResetting));
				this.igraphicsDeviceService_0.remove_DeviceReset(new EventHandler(this.igraphicsDeviceService_0_DeviceReset));
				this.igraphicsDeviceService_0.remove_DeviceDisposing(new EventHandler(this.igraphicsDeviceService_0_DeviceDisposing));
			}
		}

		// Token: 0x06000F82 RID: 3970
		// RVA: 0x00053BEC File Offset: 0x00051DEC
		private void method_24(object sender, EventArgs e)
		{
			Interface7 item = sender as Interface7;
			this.list_1.Remove(item);
			int num = this.list_1.BinarySearch(item, Class128.class128_0);
			if (num < 0)
			{
				this.list_1.Insert(~num, item);
			}
		}

		// Token: 0x06000F58 RID: 3928
		// RVA: 0x0000F3CF File Offset: 0x0000D5CF
		public Class120 method_3()
		{
			return this.class120_0;
		}

		// Token: 0x06000F59 RID: 3929
		// RVA: 0x0000F3D7 File Offset: 0x0000D5D7
		public Class121 method_4()
		{
			if (this.class118_0 != null)
			{
				return this.class118_0.vmethod_1();
			}
			return null;
		}

		// Token: 0x06000F5B RID: 3931
		// RVA: 0x00053530 File Offset: 0x00051730
		public void method_5(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F5C RID: 3932
		// RVA: 0x00053568 File Offset: 0x00051768
		public void method_6(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F5D RID: 3933
		// RVA: 0x000535A0 File Offset: 0x000517A0
		public void method_7(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F5E RID: 3934
		// RVA: 0x000535D8 File Offset: 0x000517D8
		public void method_8(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000F67 RID: 3943
		// RVA: 0x000536F8 File Offset: 0x000518F8
		private void method_9(object sender, EventArgs e)
		{
			Interface8 item = sender as Interface8;
			this.list_0.Remove(item);
			int num = this.list_0.BinarySearch(item, Class113.class113_0);
			if (num < 0)
			{
				this.list_0.Insert(~num, item);
			}
		}

		// Token: 0x06000F7C RID: 3964
		// RVA: 0x00053A30 File Offset: 0x00051C30
		public void Run()
		{
			if (this.bool_6)
			{
				this.interface9_0 = (this.method_3().GetService(typeof(Interface9)) as Interface9);
				if (this.interface9_0 != null)
				{
					this.interface9_0.imethod_1();
				}
			}
			this.Initialize();
			this.bool_3 = true;
			try
			{
				this.vmethod_1();
				this.vmethod_9();
				this.bool_1 = true;
				if (this.class118_0 != null)
				{
					this.class118_0.Run();
				}
				this.vmethod_3();
			}
			finally
			{
				this.bool_3 = false;
			}
		}

		// Token: 0x06000F5F RID: 3935
		// RVA: 0x0000F3FD File Offset: 0x0000D5FD
		protected virtual bool vmethod_0()
		{
			return this.interface9_0 == null || this.interface9_0.imethod_0();
		}

		// Token: 0x06000F60 RID: 3936
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_1()
		{
		}

		// Token: 0x06000F69 RID: 3945
		// RVA: 0x0000F470 File Offset: 0x0000D670
		protected virtual void vmethod_2()
		{
			if (this.interface9_0 != null)
			{
				this.interface9_0.imethod_2();
			}
		}

		// Token: 0x06000F6A RID: 3946
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_3()
		{
		}

		// Token: 0x06000F78 RID: 3960
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_4(bool bool_9)
		{
		}

		// Token: 0x06000F79 RID: 3961
		// RVA: 0x0000F4AF File Offset: 0x0000D6AF
		protected virtual void vmethod_5(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x06000F7A RID: 3962
		// RVA: 0x0000F4C6 File Offset: 0x0000D6C6
		protected virtual void vmethod_6(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, e);
			}
		}

		// Token: 0x06000F7B RID: 3963
		// RVA: 0x0000F4DD File Offset: 0x0000D6DD
		protected virtual void vmethod_7(object sender, EventArgs e)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(null, e);
			}
		}

		// Token: 0x06000F7F RID: 3967
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_8(bool bool_9)
		{
		}

		// Token: 0x06000F81 RID: 3969
		// RVA: 0x00053B40 File Offset: 0x00051D40
		protected virtual void vmethod_9()
		{
			Class114.bool_0 = Class114.GetForegroundWindow().Equals(this.method_4().vmethod_1());
			if (!this.bool_8 && Class114.bool_0)
			{
				this.vmethod_5(this, EventArgs.Empty);
			}
			else if (this.bool_8 && !Class114.bool_0)
			{
				this.vmethod_6(this, EventArgs.Empty);
			}
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Interface7 interface = this.list_1[i];
				if (interface.imethod_3())
				{
					interface.imethod_2();
				}
			}
			this.bool_8 = Class114.bool_0;
		}
	}
}
