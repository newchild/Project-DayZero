using ns29;
using System;

namespace ns26
{
	// Token: 0x02000344 RID: 836
	internal sealed class Class337 : Class335
	{
		// Token: 0x0400134E RID: 4942
		private bool bool_4;

		// Token: 0x04001350 RID: 4944
		private bool bool_5;

		// Token: 0x0400134F RID: 4943
		private double double_1;

		// Token: 0x04001352 RID: 4946
		private double double_2 = 100.0;

		// Token: 0x04001351 RID: 4945
		private long long_0;

		// Token: 0x1700035C RID: 860
		internal override double Position
		{
			// Token: 0x06001942 RID: 6466
			// RVA: 0x000156C6 File Offset: 0x000138C6
			get
			{
				return this.double_1;
			}
		}

		// Token: 0x0600193E RID: 6462
		// RVA: 0x00015691 File Offset: 0x00013891
		internal override void Seek(double double_3)
		{
			this.double_1 = double_3;
		}

		// Token: 0x06001943 RID: 6467
		// RVA: 0x000156CE File Offset: 0x000138CE
		internal override float vmethod_0()
		{
			return 0f;
		}

		// Token: 0x06001944 RID: 6468
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_1(float float_0)
		{
		}

		// Token: 0x06001946 RID: 6470
		// RVA: 0x000156D5 File Offset: 0x000138D5
		public override double vmethod_10()
		{
			return this.double_2;
		}

		// Token: 0x06001947 RID: 6471
		// RVA: 0x000156DD File Offset: 0x000138DD
		public override void vmethod_11(double double_3)
		{
			if (double_3 == this.double_2)
			{
				return;
			}
			this.double_2 = double_3;
		}

		// Token: 0x06001948 RID: 6472
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_14()
		{
			return true;
		}

		// Token: 0x0600193D RID: 6461
		// RVA: 0x00015688 File Offset: 0x00013888
		internal override void vmethod_5(bool bool_6)
		{
			this.bool_5 = bool_6;
		}

		// Token: 0x0600193F RID: 6463
		// RVA: 0x0001569A File Offset: 0x0001389A
		internal override void vmethod_6(bool bool_6)
		{
			if (bool_6)
			{
				this.double_1 = 0.0;
			}
			this.bool_4 = true;
		}

		// Token: 0x06001940 RID: 6464
		// RVA: 0x000156B5 File Offset: 0x000138B5
		internal override void vmethod_7()
		{
			this.bool_4 = false;
		}

		// Token: 0x06001941 RID: 6465
		// RVA: 0x000156BE File Offset: 0x000138BE
		public override bool vmethod_8()
		{
			return this.bool_4;
		}

		// Token: 0x06001945 RID: 6469
		// RVA: 0x00078D6C File Offset: 0x00076F6C
		public override void vmethod_9()
		{
			if (Class115.long_0 == this.long_0)
			{
				return;
			}
			if (this.bool_4)
			{
				this.double_1 += (double)(this.bool_5 ? -1 : 1) * Class115.double_9 * this.double_2 / 100.0;
				this.long_0 = Class115.long_0;
			}
		}
	}
}
