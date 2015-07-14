using ns14;
using ns29;
using ns70;
using ns82;
using System;
using Un4seen.Bass;

namespace ns26
{
	// Token: 0x02000347 RID: 839
	internal sealed class Class339 : IDisposable
	{
		// Token: 0x04001367 RID: 4967
		private bool bool_0;

		// Token: 0x04001368 RID: 4968
		internal bool bool_1;

		// Token: 0x04001360 RID: 4960
		private float float_0 = 1f;

		// Token: 0x04001361 RID: 4961
		private float float_1;

		// Token: 0x04001362 RID: 4962
		private float float_2;

		// Token: 0x04001363 RID: 4963
		private float float_3 = 1f;

		// Token: 0x04001366 RID: 4966
		private float float_4;

		// Token: 0x04001364 RID: 4964
		private int int_0;

		// Token: 0x04001365 RID: 4965
		private int int_1;

		// Token: 0x06001958 RID: 6488
		// RVA: 0x0001584D File Offset: 0x00013A4D
		internal Class339(int int_2)
		{
			this.method_8(int_2);
		}

		// Token: 0x0600195C RID: 6492
		// RVA: 0x00015889 File Offset: 0x00013A89
		public void Dispose()
		{
			if (!this.bool_1)
			{
				this.Dispose(true);
				GC.SuppressFinalize(this);
				this.bool_1 = true;
			}
		}

		// Token: 0x0600195D RID: 6493
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void Dispose(bool bool_2)
		{
		}

		// Token: 0x0600195B RID: 6491
		// RVA: 0x0007905C File Offset: 0x0007725C
		~Class339()
		{
			this.Dispose(false);
		}

		// Token: 0x0600194E RID: 6478
		// RVA: 0x00015761 File Offset: 0x00013961
		public void method_0(float float_5)
		{
			if (float_5 == this.float_0)
			{
				return;
			}
			this.float_0 = float_5;
			this.method_4();
		}

		// Token: 0x0600194F RID: 6479
		// RVA: 0x0001577A File Offset: 0x0001397A
		public void method_1(float float_5)
		{
			if (float_5 == this.float_1)
			{
				return;
			}
			this.float_1 = Class778.smethod_2(float_5, -1f, 1f);
			this.method_4();
		}

		// Token: 0x06001959 RID: 6489
		// RVA: 0x00079024 File Offset: 0x00077224
		internal void method_10(bool bool_2, bool bool_3)
		{
			this.bool_0 = true;
			if (!this.method_7())
			{
				return;
			}
			if (bool_3)
			{
				this.method_9();
			}
			int num = this.method_6();
			Bass.BASS_ChannelPlay(num, bool_2);
		}

		// Token: 0x0600195A RID: 6490
		// RVA: 0x00015872 File Offset: 0x00013A72
		internal void method_11(bool bool_2)
		{
			if (!this.method_5())
			{
				return;
			}
			Bass.BASS_ChannelStop(this.int_0);
		}

		// Token: 0x0600195E RID: 6494
		// RVA: 0x000158A7 File Offset: 0x00013AA7
		public bool method_12()
		{
			return this.method_5() && Bass.BASS_ChannelIsActive(this.int_0) != 0;
		}

		// Token: 0x0600195F RID: 6495
		// RVA: 0x000158C4 File Offset: 0x00013AC4
		internal bool method_13()
		{
			return (!this.method_7() || Bass.BASS_ChannelIsActive(this.int_0) == null) && this.bool_0;
		}

		// Token: 0x06001960 RID: 6496
		// RVA: 0x000158E3 File Offset: 0x00013AE3
		internal void method_14()
		{
			if (this.method_12() && this.method_5())
			{
				Bass.BASS_ChannelPause(this.int_0);
				return;
			}
		}

		// Token: 0x06001950 RID: 6480
		// RVA: 0x000157A2 File Offset: 0x000139A2
		public void method_2(float float_5)
		{
			if (float_5 == this.float_2)
			{
				return;
			}
			this.float_2 = float_5;
			this.method_4();
		}

		// Token: 0x06001951 RID: 6481
		// RVA: 0x000157BB File Offset: 0x000139BB
		public void method_3(float float_5)
		{
			if (float_5 == this.float_3)
			{
				return;
			}
			this.float_3 = float_5;
			this.method_4();
		}

		// Token: 0x06001952 RID: 6482
		// RVA: 0x00078F54 File Offset: 0x00077154
		internal void method_4()
		{
			if (!this.method_5())
			{
				return;
			}
			if (this.float_2 > 0f)
			{
				if (Class427.class427_0 != null)
				{
					this.float_1 = Class427.class427_0.vmethod_6().X / 512f - 0.5f;
				}
				else
				{
					this.float_1 = Class802.vector2_0.X / Class115.float_4 / (float)Class115.smethod_43() - 0.5f;
				}
				this.float_1 *= this.float_2;
			}
			Bass.BASS_ChannelSetAttribute(this.int_0, 2, this.float_0 * Class331.smethod_78() / 100f);
			Bass.BASS_ChannelSetAttribute(this.int_0, 3, this.float_1);
			Bass.BASS_ChannelSetAttribute(this.int_0, 1, this.float_4 * this.float_3);
		}

		// Token: 0x06001953 RID: 6483
		// RVA: 0x000157D4 File Offset: 0x000139D4
		private bool method_5()
		{
			return this.int_0 != 0;
		}

		// Token: 0x06001954 RID: 6484
		// RVA: 0x000157E2 File Offset: 0x000139E2
		public int method_6()
		{
			if (!this.method_5())
			{
				this.int_0 = Bass.BASS_SampleGetChannel(this.int_1, false);
				Bass.BASS_ChannelGetAttribute(this.int_0, 1, ref this.float_4);
				this.method_4();
			}
			return this.int_0;
		}

		// Token: 0x06001955 RID: 6485
		// RVA: 0x0001581D File Offset: 0x00013A1D
		private bool method_7()
		{
			return this.int_1 != 0;
		}

		// Token: 0x06001956 RID: 6486
		// RVA: 0x0001582B File Offset: 0x00013A2B
		public void method_8(int int_2)
		{
			if (int_2 == this.int_1)
			{
				return;
			}
			this.int_1 = int_2;
			this.method_9();
		}

		// Token: 0x06001957 RID: 6487
		// RVA: 0x00015844 File Offset: 0x00013A44
		private void method_9()
		{
			this.int_0 = 0;
		}
	}
}
