using Microsoft.StylusInput;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns29;
using ns64;
using ns81;
using ns90;
using System;

namespace ns82
{
	// Token: 0x02000602 RID: 1538
	internal sealed class Class571 : Class563
	{
		// Token: 0x04002B58 RID: 11096
		internal bool bool_0;

		// Token: 0x04002B59 RID: 11097
		internal bool bool_1;

		// Token: 0x04002B5A RID: 11098
		internal ButtonState buttonState_0;

		// Token: 0x04002B5B RID: 11099
		private RealTimeStylus realTimeStylus_0;

		// Token: 0x06002FC3 RID: 12227
		// RVA: 0x00023821 File Offset: 0x00021A21
		internal override void Dispose()
		{
			this.method_0(false);
			this.realTimeStylus_0.Dispose();
		}

		// Token: 0x06002FC2 RID: 12226
		// RVA: 0x00134624 File Offset: 0x00132824
		internal override bool Initialize()
		{
			try
			{
				if (!this.bool_0)
				{
					this.realTimeStylus_0 = new RealTimeStylus(Class115.class115_0.method_4().vmethod_1(), false);
					Class801 item = new Class801(this);
					this.realTimeStylus_0.AsyncPluginCollection.Add(item);
					this.realTimeStylus_0.Enabled = Class341.class606_62.Value;
					this.bool_0 = true;
					return true;
				}
			}
			catch (Exception)
			{
				Class723.smethod_4("Tablet initialisation failed.");
			}
			return false;
		}

		// Token: 0x06002FC1 RID: 12225
		// RVA: 0x000237FA File Offset: 0x000219FA
		internal void method_0(bool bool_2)
		{
			if (this.bool_0)
			{
				if (this.realTimeStylus_0.Enabled != bool_2)
				{
					this.realTimeStylus_0.Enabled = bool_2;
					return;
				}
			}
		}

		// Token: 0x06002FC4 RID: 12228
		// RVA: 0x001346B0 File Offset: 0x001328B0
		internal override void vmethod_1(bool bool_2)
		{
			if (Class62.bool_12 && Class341.class606_43)
			{
				this.bool_1 = false;
				return;
			}
			if (this.bool_1)
			{
				Class800.smethod_2(1);
				this.bool_1 = false;
				return;
			}
			if (this.buttonState_0 == 1)
			{
				Class800.smethod_2(this.buttonState_0);
			}
		}

		// Token: 0x06002FC5 RID: 12229
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002FC6 RID: 12230
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override int vmethod_3()
		{
			return 1;
		}
	}
}
