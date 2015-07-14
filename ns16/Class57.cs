using ns26;
using ns29;
using ns9;
using System;
using Un4seen.Bass;

namespace ns16
{
	// Token: 0x02000393 RID: 915
	internal class Class57 : Class55
	{
		// Token: 0x0400167A RID: 5754
		internal Class335 class335_0;

		// Token: 0x04001679 RID: 5753
		internal float float_0 = 1f;

		// Token: 0x0400167B RID: 5755
		internal float[] float_1 = new float[1024];

		// Token: 0x0400167C RID: 5756
		internal float float_2;

		// Token: 0x06001C50 RID: 7248
		// RVA: 0x00017597 File Offset: 0x00015797
		public Class57() : base(Class115.class114_0)
		{
			this.Initialize();
		}

		// Token: 0x06001C51 RID: 7249
		// RVA: 0x000175C5 File Offset: 0x000157C5
		public override void Draw()
		{
			base.Draw();
		}

		// Token: 0x06001C52 RID: 7250
		// RVA: 0x00097A18 File Offset: 0x00095C18
		public override void imethod_2()
		{
			if (this.class335_0 == null && (Class331.class335_0 == null || Class331.smethod_79() || Class331.bool_4))
			{
				float num = (float)Math.Pow(0.949999988079071, Class115.double_0);
				for (int i = 0; i < 1024; i++)
				{
					this.float_1[i] *= num;
				}
			}
			else
			{
				try
				{
					Bass.BASS_ChannelGetData((this.class335_0 != null) ? this.class335_0.method_0() : Class331.class335_0.method_0(), this.float_1, -2147483645);
				}
				catch
				{
				}
				if (this.float_0 != 1f)
				{
					for (int j = 0; j < 1024; j++)
					{
						this.float_1[j] *= this.float_0;
					}
				}
			}
			this.float_2 = 0f;
			for (int k = 0; k < 1024; k++)
			{
				this.float_2 += this.float_1[k];
			}
			base.imethod_2();
		}
	}
}
