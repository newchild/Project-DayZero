using System;

namespace ns62
{
	// Token: 0x02000422 RID: 1058
	internal sealed class Class492
	{
		// Token: 0x04001A99 RID: 6809
		internal Class312 class312_0;

		// Token: 0x04001A97 RID: 6807
		internal static readonly double double_0 = 0.125;

		// Token: 0x04001A98 RID: 6808
		internal static readonly double double_1 = 0.3;

		// Token: 0x04001A9A RID: 6810
		private double[] double_2;

		// Token: 0x04001A9B RID: 6811
		private double[] double_3;

		// Token: 0x04001A9C RID: 6812
		internal double double_4 = 1.0;

		// Token: 0x06002216 RID: 8726
		// RVA: 0x000C982C File Offset: 0x000C7A2C
		internal Class492(Class312 class312_1)
		{
			this.class312_0 = class312_1;
			this.double_3 = new double[class312_1.class297_0.class421_0.list_0.Count];
			this.double_2 = new double[class312_1.class297_0.class421_0.list_0.Count];
			for (int i = 0; i < class312_1.class297_0.class421_0.list_0.Count; i++)
			{
				this.double_3[i] = 0.0;
				this.double_2[i] = 0.0;
			}
		}

		// Token: 0x06002214 RID: 8724
		// RVA: 0x0001B616 File Offset: 0x00019816
		internal double method_0()
		{
			return this.double_3[this.class312_0.class409_0];
		}

		// Token: 0x06002215 RID: 8725
		// RVA: 0x0001B62F File Offset: 0x0001982F
		internal void method_1(double double_5)
		{
			this.double_3[this.class312_0.class409_0] = double_5;
		}

		// Token: 0x06002217 RID: 8727
		// RVA: 0x000C98D8 File Offset: 0x000C7AD8
		internal void method_2(Class492 class492_0, double double_5)
		{
			double num = 1.0;
			double num2 = (double)(this.class312_0.StartTime - class492_0.class312_0.StartTime) / double_5;
			double num3 = Math.Pow(Class492.double_0, num2 / 1000.0);
			double num4 = Math.Pow(Class492.double_1, num2 / 1000.0);
			double num5 = 1.0;
			double num6 = 0.0;
			for (int i = 0; i < this.class312_0.class297_0.class421_0.list_0.Count; i++)
			{
				this.double_2[i] = class492_0.double_2[i];
				if ((double)this.class312_0.StartTime < this.double_2[i] && (double)this.class312_0.EndTime > this.double_2[i])
				{
					num6 = 1.0;
				}
				if ((double)this.class312_0.EndTime == this.double_2[i])
				{
					num6 = 0.0;
				}
				if (this.double_2[i] > (double)this.class312_0.EndTime)
				{
					num5 = 1.25;
				}
			}
			this.double_2[this.class312_0.class409_0] = (double)this.class312_0.EndTime;
			for (int j = 0; j < this.class312_0.class297_0.class421_0.list_0.Count; j++)
			{
				this.double_3[j] = class492_0.double_3[j] * num3;
			}
			this.method_1(this.method_0() + 2.0 * num5);
			this.double_4 = class492_0.double_4 * num4 + (num + num6) * num5;
		}
	}
}
