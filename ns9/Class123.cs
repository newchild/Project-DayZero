using Microsoft.Xna.Framework.Graphics;
using System;

namespace ns9
{
	// Token: 0x020001C0 RID: 448
	internal sealed class Class123
	{
		// Token: 0x04000C0A RID: 3082
		private CreateOptions createOptions_0 = 64;

		// Token: 0x04000C0B RID: 3083
		private DeviceType deviceType_0 = 1;

		// Token: 0x04000C09 RID: 3081
		private GraphicsAdapter graphicsAdapter_0 = GraphicsAdapter.get_DefaultAdapter();

		// Token: 0x04000C0C RID: 3084
		private PresentationParameters presentationParameters_0 = new PresentationParameters();

		// Token: 0x06000FBC RID: 4028
		// RVA: 0x00054044 File Offset: 0x00052244
		public Class123 Clone()
		{
			return new Class123
			{
				presentationParameters_0 = this.presentationParameters_0.Clone(),
				createOptions_0 = this.createOptions_0,
				graphicsAdapter_0 = this.graphicsAdapter_0,
				deviceType_0 = this.deviceType_0
			};
		}

		// Token: 0x06000FBD RID: 4029
		// RVA: 0x00054090 File Offset: 0x00052290
		public override bool Equals(object obj)
		{
			Class123 class = obj as Class123;
			return class != null && class.graphicsAdapter_0.Equals(this.graphicsAdapter_0) && class.createOptions_0.Equals(this.createOptions_0) && class.deviceType_0.Equals(this.deviceType_0) && class.method_6().get_AutoDepthStencilFormat() == this.method_6().get_AutoDepthStencilFormat() && class.method_6().get_BackBufferCount() == this.method_6().get_BackBufferCount() && class.method_6().get_BackBufferFormat() == this.method_6().get_BackBufferFormat() && class.method_6().get_BackBufferHeight() == this.method_6().get_BackBufferHeight() && class.method_6().get_BackBufferWidth() == this.method_6().get_BackBufferWidth() && !(class.method_6().get_DeviceWindowHandle() != this.method_6().get_DeviceWindowHandle()) && class.method_6().get_EnableAutoDepthStencil() == this.method_6().get_EnableAutoDepthStencil() && class.method_6().get_FullScreenRefreshRateInHz() == this.method_6().get_FullScreenRefreshRateInHz() && class.method_6().get_IsFullScreen() == this.method_6().get_IsFullScreen() && class.method_6().get_MultiSampleQuality() == this.method_6().get_MultiSampleQuality() && class.method_6().get_MultiSampleType() == this.method_6().get_MultiSampleType() && class.method_6().get_PresentationInterval() == this.method_6().get_PresentationInterval() && class.method_6().get_PresentOptions() == this.method_6().get_PresentOptions() && class.method_6().get_SwapEffect() == this.method_6().get_SwapEffect();
		}

		// Token: 0x06000FBE RID: 4030
		// RVA: 0x0000F7B8 File Offset: 0x0000D9B8
		public override int GetHashCode()
		{
			return this.deviceType_0.GetHashCode() ^ this.createOptions_0.GetHashCode() ^ this.graphicsAdapter_0.GetHashCode() ^ this.presentationParameters_0.GetHashCode();
		}

		// Token: 0x06000FBF RID: 4031
		// RVA: 0x0000F7F3 File Offset: 0x0000D9F3
		public GraphicsAdapter method_0()
		{
			return this.graphicsAdapter_0;
		}

		// Token: 0x06000FC0 RID: 4032
		// RVA: 0x0000F7FB File Offset: 0x0000D9FB
		public void method_1(GraphicsAdapter graphicsAdapter_1)
		{
			if (this.graphicsAdapter_0 == null)
			{
				throw new ArgumentNullException(Class127.smethod_14());
			}
			this.graphicsAdapter_0 = graphicsAdapter_1;
		}

		// Token: 0x06000FC1 RID: 4033
		// RVA: 0x0000F81D File Offset: 0x0000DA1D
		public CreateOptions method_2()
		{
			return this.createOptions_0;
		}

		// Token: 0x06000FC2 RID: 4034
		// RVA: 0x0000F825 File Offset: 0x0000DA25
		public void method_3(CreateOptions createOptions_1)
		{
			this.createOptions_0 = createOptions_1;
		}

		// Token: 0x06000FC3 RID: 4035
		// RVA: 0x0000F82E File Offset: 0x0000DA2E
		public DeviceType method_4()
		{
			return this.deviceType_0;
		}

		// Token: 0x06000FC4 RID: 4036
		// RVA: 0x0000F836 File Offset: 0x0000DA36
		public void method_5(DeviceType deviceType_1)
		{
			this.deviceType_0 = deviceType_1;
		}

		// Token: 0x06000FC5 RID: 4037
		// RVA: 0x0000F83F File Offset: 0x0000DA3F
		public PresentationParameters method_6()
		{
			return this.presentationParameters_0;
		}
	}
}
