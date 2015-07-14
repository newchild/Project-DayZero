using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns9
{
	// Token: 0x020001C3 RID: 451
	internal sealed class Class125 : IDisposable, IGraphicsDeviceService, Interface9
	{
		// Token: 0x04000C15 RID: 3093
		private bool bool_0;

		// Token: 0x04000C19 RID: 3097
		private bool bool_1;

		// Token: 0x04000C1D RID: 3101
		private bool bool_2;

		// Token: 0x04000C1E RID: 3102
		private bool bool_3;

		// Token: 0x04000C1F RID: 3103
		private bool bool_4;

		// Token: 0x04000C20 RID: 3104
		private bool bool_5;

		// Token: 0x04000C25 RID: 3109
		private bool bool_6 = true;

		// Token: 0x04000C26 RID: 3110
		private bool bool_7;

		// Token: 0x04000C1C RID: 3100
		private Class114 class114_0;

		// Token: 0x04000C1A RID: 3098
		private DepthFormat depthFormat_0 = 51;

		// Token: 0x04000C13 RID: 3091
		public static readonly DeviceType[] deviceType_0;

		// Token: 0x04000C27 RID: 3111
		private EventHandler eventHandler_0;

		// Token: 0x04000C28 RID: 3112
		private EventHandler eventHandler_1;

		// Token: 0x04000C29 RID: 3113
		private EventHandler eventHandler_2;

		// Token: 0x04000C2A RID: 3114
		private EventHandler eventHandler_3;

		// Token: 0x04000C2B RID: 3115
		private EventHandler eventHandler_4;

		// Token: 0x04000C2C RID: 3116
		private EventHandler<EventArgs1> eventHandler_5;

		// Token: 0x04000C1B RID: 3099
		private GraphicsDevice graphicsDevice_0;

		// Token: 0x04000C0E RID: 3086
		public static readonly int int_0;

		// Token: 0x04000C0F RID: 3087
		public static readonly int int_1;

		// Token: 0x04000C17 RID: 3095
		private int int_2 = Class125.int_0;

		// Token: 0x04000C18 RID: 3096
		private int int_3 = Class125.int_1;

		// Token: 0x04000C23 RID: 3107
		private int int_4;

		// Token: 0x04000C24 RID: 3108
		private int int_5;

		// Token: 0x04000C14 RID: 3092
		private static MultiSampleType[] multiSampleType_0;

		// Token: 0x04000C21 RID: 3105
		private ShaderProfile shaderProfile_0;

		// Token: 0x04000C22 RID: 3106
		private ShaderProfile shaderProfile_1 = 10;

		// Token: 0x04000C11 RID: 3089
		public static readonly SurfaceFormat[] surfaceFormat_0;

		// Token: 0x04000C12 RID: 3090
		public static readonly SurfaceFormat[] surfaceFormat_1;

		// Token: 0x04000C16 RID: 3094
		private SurfaceFormat surfaceFormat_2 = 1;

		// Token: 0x04000C10 RID: 3088
		private static readonly TimeSpan timeSpan_0;

		// Token: 0x14000007 RID: 7
		public event EventHandler DeviceCreated
		{
			// Token: 0x06000FE3 RID: 4067
			// RVA: 0x000548EC File Offset: 0x00052AEC
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			// Token: 0x06000FE4 RID: 4068
			// RVA: 0x00054924 File Offset: 0x00052B24
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000008 RID: 8
		public event EventHandler DeviceDisposing
		{
			// Token: 0x06000FE5 RID: 4069
			// RVA: 0x0005495C File Offset: 0x00052B5C
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			// Token: 0x06000FE6 RID: 4070
			// RVA: 0x00054994 File Offset: 0x00052B94
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000009 RID: 9
		public event EventHandler DeviceReset
		{
			// Token: 0x06000FE7 RID: 4071
			// RVA: 0x000549CC File Offset: 0x00052BCC
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			// Token: 0x06000FE8 RID: 4072
			// RVA: 0x00054A04 File Offset: 0x00052C04
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000A RID: 10
		public event EventHandler DeviceResetting
		{
			// Token: 0x06000FE9 RID: 4073
			// RVA: 0x00054A3C File Offset: 0x00052C3C
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			// Token: 0x06000FEA RID: 4074
			// RVA: 0x00054A74 File Offset: 0x00052C74
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000289 RID: 649
		public GraphicsDevice GraphicsDevice
		{
			// Token: 0x06000FEB RID: 4075
			// RVA: 0x0000F9AB File Offset: 0x0000DBAB
			get
			{
				return this.graphicsDevice_0;
			}
		}

		// Token: 0x06000FCD RID: 4045
		// RVA: 0x0005465C File Offset: 0x0005285C
		static Class125()
		{
			Class125.int_0 = 600;
			Class125.int_1 = 800;
			Class125.timeSpan_0 = TimeSpan.FromMilliseconds(50.0);
			Class125.surfaceFormat_0 = new SurfaceFormat[]
			{
				2,
				11,
				9,
				3
			};
			Class125.surfaceFormat_1 = new SurfaceFormat[]
			{
				9,
				11,
				10,
				2,
				1,
				3
			};
			Class125.deviceType_0 = new DeviceType[]
			{
				1
			};
			MultiSampleType[] array = new MultiSampleType[17];
			array[0] = 1;
			array[1] = 16;
			array[2] = 15;
			array[3] = 14;
			array[4] = 13;
			array[5] = 12;
			array[6] = 11;
			array[7] = 10;
			array[8] = 9;
			array[9] = 8;
			array[10] = 7;
			array[11] = 6;
			array[12] = 5;
			array[13] = 4;
			array[14] = 3;
			array[15] = 2;
			Class125.multiSampleType_0 = array;
		}

		// Token: 0x06000FCE RID: 4046
		// RVA: 0x00054748 File Offset: 0x00052948
		public Class125(Class114 class114_1)
		{
			if (class114_1 == null)
			{
				throw new ArgumentNullException(Class127.smethod_4());
			}
			this.class114_0 = class114_1;
			if (class114_1.method_3().GetService(typeof(Interface9)) != null)
			{
				throw new ArgumentException(Class127.smethod_6());
			}
			class114_1.method_3().method_0(typeof(Interface9), this);
			class114_1.method_3().method_0(typeof(IGraphicsDeviceService), this);
			class114_1.method_4().method_1(new EventHandler(this.method_26));
			class114_1.method_4().method_4(new EventHandler(this.method_27));
		}

		// Token: 0x06000FF4 RID: 4084
		// RVA: 0x00055354 File Offset: 0x00053554
		protected virtual void Dispose(bool bool_8)
		{
			if (bool_8)
			{
				if (this.class114_0 != null)
				{
					if (this.class114_0.method_3().GetService(typeof(IGraphicsDeviceService)) == this)
					{
						this.class114_0.method_3().method_1(typeof(IGraphicsDeviceService));
					}
					this.class114_0.method_4().method_2(new EventHandler(this.method_26));
					this.class114_0.method_4().method_5(new EventHandler(this.method_27));
				}
				if (this.graphicsDevice_0 != null)
				{
					this.graphicsDevice_0.Dispose();
					this.graphicsDevice_0 = null;
				}
				if (this.eventHandler_4 != null)
				{
					this.eventHandler_4(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x06000FFB RID: 4091
		[DllImport("user32.dll")]
		private static extern int GetSystemMetrics(uint uint_0);

		// Token: 0x06000FFC RID: 4092
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void graphicsDevice_0_DeviceLost(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FFD RID: 4093
		// RVA: 0x0000FA04 File Offset: 0x0000DC04
		private void graphicsDevice_0_DeviceReset(object sender, EventArgs e)
		{
			this.vmethod_4(this, EventArgs.Empty);
		}

		// Token: 0x06000FFE RID: 4094
		// RVA: 0x0000FA12 File Offset: 0x0000DC12
		private void graphicsDevice_0_DeviceResetting(object sender, EventArgs e)
		{
			this.vmethod_5(this, EventArgs.Empty);
		}

		// Token: 0x06000FFF RID: 4095
		// RVA: 0x0000FA20 File Offset: 0x0000DC20
		private void graphicsDevice_0_Disposing(object sender, EventArgs e)
		{
			this.vmethod_3(this, EventArgs.Empty);
		}

		// Token: 0x06000FCF RID: 4047
		// RVA: 0x0000F883 File Offset: 0x0000DA83
		public bool method_0()
		{
			return this.bool_4;
		}

		// Token: 0x06000FD0 RID: 4048
		// RVA: 0x0000F88B File Offset: 0x0000DA8B
		public void method_1(bool bool_8)
		{
			this.bool_4 = bool_8;
			this.bool_3 = true;
		}

		// Token: 0x06000FD9 RID: 4057
		// RVA: 0x0000F92C File Offset: 0x0000DB2C
		public int method_10()
		{
			return this.int_3;
		}

		// Token: 0x06000FDA RID: 4058
		// RVA: 0x0000F934 File Offset: 0x0000DB34
		public void method_11(int int_6)
		{
			if (int_6 <= 0)
			{
				throw new ArgumentOutOfRangeException("value", Class127.smethod_0());
			}
			this.int_3 = int_6;
			this.bool_7 = false;
			this.bool_3 = true;
		}

		// Token: 0x06000FDB RID: 4059
		// RVA: 0x0000F95F File Offset: 0x0000DB5F
		public DepthFormat method_12()
		{
			return this.depthFormat_0;
		}

		// Token: 0x06000FDC RID: 4060
		// RVA: 0x00054820 File Offset: 0x00052A20
		public void method_13(DepthFormat depthFormat_1)
		{
			switch (depthFormat_1)
			{
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 54:
			case 56:
				this.depthFormat_0 = depthFormat_1;
				this.bool_3 = true;
				return;
			case 53:
			case 55:
				IL_2F:
				throw new ArgumentOutOfRangeException("value", Class127.smethod_31());
			}
			goto IL_2F;
		}

		// Token: 0x06000FDD RID: 4061
		// RVA: 0x0000F967 File Offset: 0x0000DB67
		public bool method_14()
		{
			return this.bool_6;
		}

		// Token: 0x06000FDE RID: 4062
		// RVA: 0x0000F96F File Offset: 0x0000DB6F
		public void method_15(bool bool_8)
		{
			this.bool_6 = bool_8;
			this.bool_3 = true;
		}

		// Token: 0x06000FEC RID: 4076
		// RVA: 0x00054AAC File Offset: 0x00052CAC
		public void method_16(EventHandler<EventArgs1> eventHandler_6)
		{
			EventHandler<EventArgs1> eventHandler = this.eventHandler_5;
			EventHandler<EventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs1> value = (EventHandler<EventArgs1>)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs1>>(ref this.eventHandler_5, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000FED RID: 4077
		// RVA: 0x00054AE4 File Offset: 0x00052CE4
		private void method_17(bool bool_8, List<Class123> list_0)
		{
			IntPtr intptr_ = this.class114_0.method_4().vmethod_1();
			foreach (GraphicsAdapter current in GraphicsAdapter.get_Adapters())
			{
				if (bool_8 || this.method_28(intptr_, current))
				{
					DeviceType[] array = Class125.deviceType_0;
					for (int i = 0; i < array.Length; i++)
					{
						DeviceType deviceType = array[i];
						try
						{
							GraphicsDeviceCapabilities capabilities = current.GetCapabilities(deviceType);
							if (capabilities.get_DeviceCapabilities().get_IsDirect3D9Driver() && capabilities.get_MaxPixelShaderProfile() >= this.method_2() && capabilities.get_MaxVertexShaderProfile() >= this.method_3())
							{
								CreateOptions createOptions = 0;
								if (capabilities.get_DeviceCapabilities().get_SupportsHardwareTransformAndLight())
								{
									createOptions |= 64;
								}
								else
								{
									createOptions |= 32;
								}
								Class123 class = new Class123();
								class.method_1(current);
								class.method_5(deviceType);
								class.method_3(createOptions);
								class.method_6().set_DeviceWindowHandle(IntPtr.Zero);
								class.method_6().set_EnableAutoDepthStencil(true);
								class.method_6().set_BackBufferCount(1);
								class.method_6().set_PresentOptions(0);
								class.method_6().set_SwapEffect(1);
								class.method_6().set_FullScreenRefreshRateInHz(0);
								class.method_6().set_MultiSampleQuality(0);
								class.method_6().set_MultiSampleType(0);
								class.method_6().set_IsFullScreen(this.method_0());
								class.method_6().set_PresentationInterval(this.method_14() ? 1 : -2147483648);
								for (int j = 0; j < Class125.surfaceFormat_0.Length; j++)
								{
									this.method_18(current, deviceType, current.get_CurrentDisplayMode(), class, list_0);
									if (this.bool_4)
									{
										foreach (DisplayMode current2 in current.get_SupportedDisplayModes().get_Item(Class125.surfaceFormat_0[j]))
										{
											if (current2.get_Width() >= 640 && current2.get_Height() >= 480)
											{
												this.method_18(current, deviceType, current2, class, list_0);
											}
										}
									}
								}
							}
						}
						catch (DeviceNotSupportedException)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000FEE RID: 4078
		// RVA: 0x00054D70 File Offset: 0x00052F70
		private void method_18(GraphicsAdapter graphicsAdapter_0, DeviceType deviceType_1, DisplayMode displayMode_0, Class123 class123_0, List<Class123> list_0)
		{
			for (int i = 0; i < Class125.surfaceFormat_1.Length; i++)
			{
				SurfaceFormat surfaceFormat = Class125.surfaceFormat_1[i];
				if (graphicsAdapter_0.CheckDeviceType(deviceType_1, displayMode_0.get_Format(), surfaceFormat, this.method_0()))
				{
					Class123 class = class123_0.Clone();
					if (this.method_0())
					{
						class.method_6().set_BackBufferWidth(displayMode_0.get_Width());
						class.method_6().set_BackBufferHeight(displayMode_0.get_Height());
						class.method_6().set_FullScreenRefreshRateInHz(displayMode_0.get_RefreshRate());
					}
					else if (this.bool_7)
					{
						class.method_6().set_BackBufferWidth(this.int_5);
						class.method_6().set_BackBufferHeight(this.int_4);
					}
					else
					{
						class.method_6().set_BackBufferWidth(this.method_10());
						class.method_6().set_BackBufferHeight(this.method_8());
					}
					class.method_6().set_BackBufferFormat(surfaceFormat);
					class.method_6().set_AutoDepthStencilFormat(this.method_12());
					if (this.method_4())
					{
						int j = 0;
						while (j < Class125.multiSampleType_0.Length)
						{
							int num = 0;
							MultiSampleType multiSampleType = Class125.multiSampleType_0[j];
							if (!graphicsAdapter_0.CheckDeviceMultiSampleType(deviceType_1, surfaceFormat, this.method_0(), multiSampleType, ref num))
							{
								j++;
							}
							else
							{
								Class123 class2 = class.Clone();
								class2.method_6().set_MultiSampleType(multiSampleType);
								if (!list_0.Contains(class2))
								{
									list_0.Add(class2);
									break;
								}
								break;
							}
						}
					}
					else if (!list_0.Contains(class))
					{
						list_0.Add(class);
					}
				}
			}
		}

		// Token: 0x06000FEF RID: 4079
		// RVA: 0x0000F9B3 File Offset: 0x0000DBB3
		public void method_19()
		{
			if (this.graphicsDevice_0 == null || this.bool_3)
			{
				this.method_20(false);
			}
		}

		// Token: 0x06000FD1 RID: 4049
		// RVA: 0x0000F89B File Offset: 0x0000DA9B
		public ShaderProfile method_2()
		{
			return this.shaderProfile_0;
		}

		// Token: 0x06000FF1 RID: 4081
		// RVA: 0x00054F50 File Offset: 0x00053150
		private void method_20(bool bool_8)
		{
			if (this.class114_0 == null)
			{
				throw new InvalidOperationException(Class127.smethod_5());
			}
			string string_ = this.class114_0.method_4().vmethod_4();
			int num = this.class114_0.method_4().vmethod_0().Width;
			int num2 = this.class114_0.method_4().vmethod_0().Height;
			if (this.class114_0.bool_6)
			{
				this.method_21();
				this.bool_2 = true;
				bool flag = false;
				try
				{
					Class123 class = this.vmethod_1(bool_8);
					this.class114_0.method_4().vmethod_5(class.method_6().get_IsFullScreen());
					flag = true;
					bool flag2 = true;
					if (!bool_8 && this.graphicsDevice_0 != null)
					{
						this.vmethod_6(this, new EventArgs1(class));
						if (this.vmethod_0(class))
						{
							try
							{
								Class123 class2 = class.Clone();
								this.method_29(class.method_6());
								this.method_31(class);
								this.graphicsDevice_0.Reset(class2.method_6());
								flag2 = false;
							}
							catch
							{
							}
						}
					}
					if (flag2)
					{
						this.method_22(class);
					}
					PresentationParameters presentationParameters = this.graphicsDevice_0.get_PresentationParameters();
					string_ = this.graphicsDevice_0.get_CreationParameters().get_Adapter().get_DeviceName();
					this.bool_5 = presentationParameters.get_IsFullScreen();
					if (presentationParameters.get_BackBufferWidth() != 0)
					{
						num = this.method_10();
					}
					if (presentationParameters.get_BackBufferHeight() != 0)
					{
						num2 = this.method_8();
					}
					this.bool_3 = false;
					return;
				}
				finally
				{
					if (flag)
					{
						this.class114_0.method_4().vmethod_6(string_, num, num2);
					}
					this.bool_2 = false;
				}
			}
			this.bool_5 = this.method_0();
			num = this.method_10();
			num2 = this.method_8();
			this.class114_0.method_4().vmethod_5(this.method_0());
			this.class114_0.method_4().vmethod_6(string_, num, num2);
		}

		// Token: 0x06000FF2 RID: 4082
		// RVA: 0x00055140 File Offset: 0x00053340
		private void method_21()
		{
			bool flag = false;
			bool flag2 = false;
			foreach (GraphicsAdapter current in GraphicsAdapter.get_Adapters())
			{
				if (current.IsDeviceTypeAvailable(1))
				{
					flag = true;
					GraphicsDeviceCapabilities capabilities = current.GetCapabilities(1);
					if (capabilities.get_MaxPixelShaderProfile() != 16 && capabilities.get_MaxPixelShaderProfile() >= 0 && capabilities.get_DeviceCapabilities().get_IsDirect3D9Driver())
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag)
			{
				if (Class125.GetSystemMetrics(4096u) != 0)
				{
					throw new Exception1("");
				}
				throw new Exception1("");
			}
			else
			{
				if (!flag2)
				{
					throw new Exception1("");
				}
				return;
			}
		}

		// Token: 0x06000FF3 RID: 4083
		// RVA: 0x00055200 File Offset: 0x00053400
		private void method_22(Class123 class123_0)
		{
			if (this.graphicsDevice_0 != null)
			{
				this.graphicsDevice_0.Dispose();
				this.graphicsDevice_0 = null;
			}
			this.vmethod_6(this, new EventArgs1(class123_0));
			this.method_29(class123_0.method_6());
			try
			{
				this.method_31(class123_0);
				this.graphicsDevice_0 = new GraphicsDevice(class123_0.method_0(), class123_0.method_4(), this.class114_0.method_4().vmethod_1(), class123_0.method_2(), class123_0.method_6());
				this.graphicsDevice_0.add_DeviceResetting(new EventHandler(this.graphicsDevice_0_DeviceResetting));
				this.graphicsDevice_0.add_DeviceReset(new EventHandler(this.graphicsDevice_0_DeviceReset));
				this.graphicsDevice_0.add_DeviceLost(new EventHandler(this.graphicsDevice_0_DeviceLost));
				this.graphicsDevice_0.add_Disposing(new EventHandler(this.graphicsDevice_0_Disposing));
			}
			catch (DeviceNotSupportedException exception_)
			{
				throw new Exception1("", exception_);
			}
			catch (DriverInternalErrorException exception_2)
			{
				throw new Exception1("", exception_2);
			}
			catch (ArgumentException exception_3)
			{
				throw new Exception1("", exception_3);
			}
			catch (Exception exception_4)
			{
				throw new Exception1("", exception_4);
			}
			this.vmethod_2(this, EventArgs.Empty);
		}

		// Token: 0x06000FF5 RID: 4085
		// RVA: 0x0000F9D2 File Offset: 0x0000DBD2
		private bool method_23()
		{
			return !(this.graphicsDevice_0 == null) && this.method_24();
		}

		// Token: 0x06000FF6 RID: 4086
		// RVA: 0x00055418 File Offset: 0x00053618
		private bool method_24()
		{
			if (this.bool_5 && !Class114.bool_0)
			{
				return false;
			}
			switch (this.graphicsDevice_0.get_GraphicsDeviceStatus())
			{
			case 1:
				Thread.Sleep((int)Class125.timeSpan_0.TotalMilliseconds);
				return false;
			case 2:
			{
				Thread.Sleep((int)Class125.timeSpan_0.TotalMilliseconds);
				bool result;
				try
				{
					this.method_20(false);
					break;
				}
				catch (DeviceLostException)
				{
					result = false;
				}
				catch
				{
					this.method_20(true);
					break;
				}
				return result;
			}
			}
			return true;
		}

		// Token: 0x06000FF8 RID: 4088
		// RVA: 0x000554B4 File Offset: 0x000536B4
		private Class123 method_25(bool bool_8)
		{
			List<Class123> list = new List<Class123>();
			this.method_17(bool_8, list);
			if (list.Count == 0 && this.method_4())
			{
				this.method_5(false);
				this.method_17(bool_8, list);
			}
			if (list.Count == 0)
			{
				throw new Exception1(Class127.smethod_11());
			}
			this.vmethod_7(list);
			if (list.Count == 0)
			{
				throw new Exception1(Class127.smethod_12());
			}
			return list[0];
		}

		// Token: 0x06000FF9 RID: 4089
		// RVA: 0x00055524 File Offset: 0x00053724
		private void method_26(object sender, EventArgs e)
		{
			if (!this.bool_2 && (this.class114_0.method_4().vmethod_0().Height != 0 || this.class114_0.method_4().vmethod_0().Width != 0))
			{
				this.int_5 = this.class114_0.method_4().vmethod_0().Width;
				this.int_4 = this.class114_0.method_4().vmethod_0().Height;
				this.bool_7 = true;
				this.method_20(false);
			}
		}

		// Token: 0x06000FFA RID: 4090
		// RVA: 0x0000F9F3 File Offset: 0x0000DBF3
		private void method_27(object sender, EventArgs e)
		{
			if (!this.bool_2)
			{
				this.method_20(false);
			}
		}

		// Token: 0x06001000 RID: 4096
		// RVA: 0x0000FA2E File Offset: 0x0000DC2E
		private bool method_28(IntPtr intptr_0, GraphicsAdapter graphicsAdapter_0)
		{
			return Class122.smethod_3(graphicsAdapter_0) == Class122.smethod_5(intptr_0);
		}

		// Token: 0x06001001 RID: 4097
		// RVA: 0x000555AC File Offset: 0x000537AC
		private void method_29(PresentationParameters presentationParameters_0)
		{
			bool flag = presentationParameters_0.get_BackBufferWidth() == 0;
			bool flag2 = presentationParameters_0.get_BackBufferHeight() == 0;
			if (!presentationParameters_0.get_IsFullScreen())
			{
				IntPtr intPtr = presentationParameters_0.get_DeviceWindowHandle();
				if (intPtr == IntPtr.Zero)
				{
					if (this.class114_0 == null)
					{
						throw new InvalidOperationException(Class127.smethod_5());
					}
					intPtr = this.class114_0.method_4().vmethod_1();
				}
				Class126.Struct19 struct;
				Class126.GetClientRect(intPtr, ref struct);
				if (flag && struct.int_2 == 0)
				{
					presentationParameters_0.set_BackBufferWidth(1);
				}
				if (flag2 && struct.int_3 == 0)
				{
					presentationParameters_0.set_BackBufferHeight(1);
				}
			}
		}

		// Token: 0x06000FD2 RID: 4050
		// RVA: 0x0000F8A3 File Offset: 0x0000DAA3
		public ShaderProfile method_3()
		{
			return this.shaderProfile_1;
		}

		// Token: 0x06001008 RID: 4104
		// RVA: 0x0005563C File Offset: 0x0005383C
		private void method_30(List<Class123> list_0)
		{
			int i = 0;
			while (i < list_0.Count)
			{
				DeviceType deviceType = list_0[i].method_4();
				GraphicsAdapter graphicsAdapter = list_0[i].method_0();
				PresentationParameters presentationParameters = list_0[i].method_6();
				if (!graphicsAdapter.CheckDeviceFormat(deviceType, graphicsAdapter.get_CurrentDisplayMode().get_Format(), 0, 524288, 3, presentationParameters.get_BackBufferFormat()))
				{
					list_0.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
			list_0.Sort(new Class124(this));
		}

		// Token: 0x06001009 RID: 4105
		// RVA: 0x000556BC File Offset: 0x000538BC
		private void method_31(Class123 class123_0)
		{
			GraphicsAdapter graphicsAdapter = class123_0.method_0();
			DeviceType deviceType = class123_0.method_4();
			bool enableAutoDepthStencil = class123_0.method_6().get_EnableAutoDepthStencil();
			DepthFormat autoDepthStencilFormat = class123_0.method_6().get_AutoDepthStencilFormat();
			SurfaceFormat backBufferFormat = class123_0.method_6().get_BackBufferFormat();
			int backBufferWidth = class123_0.method_6().get_BackBufferWidth();
			int backBufferHeight = class123_0.method_6().get_BackBufferHeight();
			PresentationParameters presentationParameters = class123_0.method_6();
			SurfaceFormat surfaceFormat = presentationParameters.get_BackBufferFormat();
			SurfaceFormat surfaceFormat2;
			if (!presentationParameters.get_IsFullScreen())
			{
				surfaceFormat2 = graphicsAdapter.get_CurrentDisplayMode().get_Format();
				if (-1 == presentationParameters.get_BackBufferFormat())
				{
					surfaceFormat = surfaceFormat2;
				}
			}
			else
			{
				SurfaceFormat backBufferFormat2 = presentationParameters.get_BackBufferFormat();
				if (backBufferFormat2 != 1)
				{
					if (backBufferFormat2 != 10)
					{
						surfaceFormat2 = presentationParameters.get_BackBufferFormat();
					}
					else
					{
						surfaceFormat2 = 11;
					}
				}
				else
				{
					surfaceFormat2 = 2;
				}
			}
			if (-1 == Array.IndexOf<SurfaceFormat>(Class125.surfaceFormat_1, surfaceFormat))
			{
				throw new ArgumentException(Class127.smethod_29());
			}
			if (!graphicsAdapter.CheckDeviceType(deviceType, surfaceFormat2, presentationParameters.get_BackBufferFormat(), presentationParameters.get_IsFullScreen()))
			{
				throw new ArgumentException(Class127.smethod_32());
			}
			if (presentationParameters.get_BackBufferCount() < 0 || presentationParameters.get_BackBufferCount() > 3)
			{
				throw new ArgumentException(Class127.smethod_25());
			}
			if (presentationParameters.get_BackBufferCount() > 1 && presentationParameters.get_SwapEffect() == 3)
			{
				throw new ArgumentException(Class127.smethod_26());
			}
			switch (presentationParameters.get_SwapEffect())
			{
			case 1:
			case 2:
			case 3:
			{
				int num;
				if (!graphicsAdapter.CheckDeviceMultiSampleType(deviceType, surfaceFormat, presentationParameters.get_IsFullScreen(), presentationParameters.get_MultiSampleType(), ref num))
				{
					throw new ArgumentException(Class127.smethod_35());
				}
				if (presentationParameters.get_MultiSampleQuality() >= num)
				{
					throw new ArgumentException(Class127.smethod_33());
				}
				if (presentationParameters.get_MultiSampleType() != null && presentationParameters.get_SwapEffect() != 1)
				{
					throw new ArgumentException(Class127.smethod_34());
				}
				if ((presentationParameters.get_PresentOptions() & 2) != null && !presentationParameters.get_EnableAutoDepthStencil())
				{
					throw new ArgumentException(Class127.smethod_24());
				}
				if (presentationParameters.get_EnableAutoDepthStencil())
				{
					if (!graphicsAdapter.CheckDeviceFormat(deviceType, surfaceFormat2, 0, 0, 1, presentationParameters.get_AutoDepthStencilFormat()))
					{
						throw new ArgumentException(Class127.smethod_23());
					}
					if (!graphicsAdapter.CheckDepthStencilMatch(deviceType, surfaceFormat2, surfaceFormat, presentationParameters.get_AutoDepthStencilFormat()))
					{
						throw new ArgumentException(Class127.smethod_22());
					}
				}
				if (!presentationParameters.get_IsFullScreen())
				{
					if (presentationParameters.get_FullScreenRefreshRateInHz() != 0)
					{
						throw new ArgumentException(Class127.smethod_40());
					}
					PresentInterval presentationInterval = presentationParameters.get_PresentationInterval();
					if (presentationInterval != -2147483648)
					{
						switch (presentationInterval)
						{
						case 0:
						case 1:
							break;
						default:
							throw new ArgumentException(Class127.smethod_38());
						}
					}
					return;
				}
				else
				{
					if (presentationParameters.get_FullScreenRefreshRateInHz() == 0)
					{
						throw new ArgumentException(Class127.smethod_39());
					}
					GraphicsDeviceCapabilities capabilities = graphicsAdapter.GetCapabilities(deviceType);
					PresentInterval presentationInterval2 = presentationParameters.get_PresentationInterval();
					if (presentationInterval2 != -2147483648)
					{
						switch (presentationInterval2)
						{
						case 0:
						case 1:
							goto IL_2D5;
						case 2:
						case 4:
						case 8:
							if ((capabilities.get_PresentInterval() & presentationParameters.get_PresentationInterval()) == null)
							{
								throw new ArgumentException(Class127.smethod_36());
							}
							goto IL_2D5;
						case 3:
						case 5:
						case 6:
						case 7:
							IL_2AE:
							throw new ArgumentException(Class127.smethod_37());
						}
						goto IL_2AE;
					}
					IL_2D5:
					if (presentationParameters.get_IsFullScreen())
					{
						if (presentationParameters.get_BackBufferWidth() == 0 || presentationParameters.get_BackBufferHeight() == 0)
						{
							throw new ArgumentException(Class127.smethod_27());
						}
						bool flag = true;
						bool flag2 = false;
						DisplayMode currentDisplayMode = graphicsAdapter.get_CurrentDisplayMode();
						if (currentDisplayMode.get_Format() != surfaceFormat2 && currentDisplayMode.get_Width() != presentationParameters.get_BackBufferHeight() && currentDisplayMode.get_Height() != presentationParameters.get_BackBufferHeight() && currentDisplayMode.get_RefreshRate() != presentationParameters.get_FullScreenRefreshRateInHz())
						{
							flag = false;
							foreach (DisplayMode current in graphicsAdapter.get_SupportedDisplayModes().get_Item(surfaceFormat2))
							{
								if (current.get_Width() == presentationParameters.get_BackBufferWidth() && current.get_Height() == presentationParameters.get_BackBufferHeight())
								{
									flag2 = true;
									if (current.get_RefreshRate() == presentationParameters.get_FullScreenRefreshRateInHz())
									{
										flag = true;
										break;
									}
								}
							}
						}
						if (!flag && flag2)
						{
							throw new ArgumentException(Class127.smethod_28());
						}
						if (!flag)
						{
							throw new ArgumentException(Class127.smethod_30());
						}
					}
					if (presentationParameters.get_EnableAutoDepthStencil() != enableAutoDepthStencil)
					{
						throw new ArgumentException(Class127.smethod_21());
					}
					if (presentationParameters.get_EnableAutoDepthStencil())
					{
						if (presentationParameters.get_AutoDepthStencilFormat() != autoDepthStencilFormat)
						{
							throw new ArgumentException(Class127.smethod_21());
						}
						if (presentationParameters.get_BackBufferFormat() != backBufferFormat)
						{
							throw new ArgumentException(Class127.smethod_21());
						}
						if (presentationParameters.get_BackBufferWidth() != backBufferWidth)
						{
							throw new ArgumentException(Class127.smethod_21());
						}
						if (presentationParameters.get_BackBufferHeight() != backBufferHeight)
						{
							throw new ArgumentException(Class127.smethod_21());
						}
					}
					return;
				}
				break;
			}
			default:
				throw new ArgumentException(Class127.smethod_41());
			}
		}

		// Token: 0x06000FD3 RID: 4051
		// RVA: 0x0000F8AB File Offset: 0x0000DAAB
		public bool method_4()
		{
			return this.bool_0;
		}

		// Token: 0x06000FD4 RID: 4052
		// RVA: 0x0000F8B3 File Offset: 0x0000DAB3
		public void method_5(bool bool_8)
		{
			this.bool_0 = bool_8;
			this.bool_3 = true;
		}

		// Token: 0x06000FD5 RID: 4053
		// RVA: 0x0000F8C3 File Offset: 0x0000DAC3
		public SurfaceFormat method_6()
		{
			return this.surfaceFormat_2;
		}

		// Token: 0x06000FD6 RID: 4054
		// RVA: 0x0000F8CB File Offset: 0x0000DACB
		public void method_7(SurfaceFormat surfaceFormat_3)
		{
			if (Array.IndexOf<SurfaceFormat>(Class125.surfaceFormat_1, surfaceFormat_3) == -1)
			{
				throw new ArgumentOutOfRangeException("value", Class127.smethod_29());
			}
			this.surfaceFormat_2 = surfaceFormat_3;
			this.bool_3 = true;
		}

		// Token: 0x06000FD7 RID: 4055
		// RVA: 0x0000F8F9 File Offset: 0x0000DAF9
		public int method_8()
		{
			return this.int_2;
		}

		// Token: 0x06000FD8 RID: 4056
		// RVA: 0x0000F901 File Offset: 0x0000DB01
		public void method_9(int int_6)
		{
			if (int_6 <= 0)
			{
				throw new ArgumentOutOfRangeException("value", Class127.smethod_0());
			}
			this.int_2 = int_6;
			this.bool_7 = false;
			this.bool_3 = true;
		}

		// Token: 0x06000FE0 RID: 4064
		// RVA: 0x0000F98E File Offset: 0x0000DB8E
		bool Interface9.imethod_0()
		{
			if (!this.method_23())
			{
				return false;
			}
			this.bool_1 = true;
			return true;
		}

		// Token: 0x06000FE1 RID: 4065
		// RVA: 0x0000F9A2 File Offset: 0x0000DBA2
		void Interface9.imethod_1()
		{
			this.method_20(true);
		}

		// Token: 0x06000FE2 RID: 4066
		// RVA: 0x0005487C File Offset: 0x00052A7C
		void Interface9.imethod_2()
		{
			if (this.bool_1 && this.graphicsDevice_0 != null)
			{
				try
				{
					this.graphicsDevice_0.Present();
				}
				catch (InvalidOperationException)
				{
				}
				catch (DeviceLostException)
				{
				}
				catch (DeviceNotResetException)
				{
				}
				catch (DriverInternalErrorException)
				{
				}
			}
		}

		// Token: 0x06000FDF RID: 4063
		// RVA: 0x0000F97F File Offset: 0x0000DB7F
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000FF0 RID: 4080
		// RVA: 0x00054EE4 File Offset: 0x000530E4
		protected virtual bool vmethod_0(Class123 class123_0)
		{
			return !(this.graphicsDevice_0.get_CreationParameters().get_Adapter() != class123_0.method_0()) && this.graphicsDevice_0.get_CreationParameters().get_DeviceType() == class123_0.method_4() && this.graphicsDevice_0.get_CreationParameters().get_CreationOptions() == class123_0.method_2();
		}

		// Token: 0x06000FF7 RID: 4087
		// RVA: 0x0000F9EA File Offset: 0x0000DBEA
		protected virtual Class123 vmethod_1(bool bool_8)
		{
			return this.method_25(bool_8);
		}

		// Token: 0x06001002 RID: 4098
		// RVA: 0x0000FA3E File Offset: 0x0000DC3E
		protected virtual void vmethod_2(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(sender, e);
			}
		}

		// Token: 0x06001003 RID: 4099
		// RVA: 0x0000FA55 File Offset: 0x0000DC55
		protected virtual void vmethod_3(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(sender, e);
			}
		}

		// Token: 0x06001004 RID: 4100
		// RVA: 0x0000FA6C File Offset: 0x0000DC6C
		protected virtual void vmethod_4(object sender, EventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(sender, e);
			}
		}

		// Token: 0x06001005 RID: 4101
		// RVA: 0x0000FA83 File Offset: 0x0000DC83
		protected virtual void vmethod_5(object sender, EventArgs e)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(sender, e);
			}
		}

		// Token: 0x06001006 RID: 4102
		// RVA: 0x0000FA9A File Offset: 0x0000DC9A
		protected virtual void vmethod_6(object sender, EventArgs1 e)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(sender, e);
			}
		}

		// Token: 0x06001007 RID: 4103
		// RVA: 0x0000FAB1 File Offset: 0x0000DCB1
		protected virtual void vmethod_7(List<Class123> list_0)
		{
			this.method_30(list_0);
		}
	}
}
