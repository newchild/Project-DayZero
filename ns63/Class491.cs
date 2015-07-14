using ns14;
using ns59;
using System;

namespace ns63
{
	// Token: 0x02000421 RID: 1057
	internal sealed class Class491
	{
		// Token: 0x04001A91 RID: 6801
		internal Class304 class304_0;

		// Token: 0x04001A8F RID: 6799
		internal static readonly double double_0 = 0.2;

		// Token: 0x04001A92 RID: 6802
		internal double double_1 = 1.0;

		// Token: 0x04001A96 RID: 6806
		private readonly double double_2 = 12.5;

		// Token: 0x04001A90 RID: 6800
		private float float_0;

		// Token: 0x04001A93 RID: 6803
		internal float float_1;

		// Token: 0x04001A94 RID: 6804
		internal float float_2;

		// Token: 0x04001A95 RID: 6805
		private float float_3;

		// Token: 0x0600220F RID: 8719
		// RVA: 0x000C95A0 File Offset: 0x000C77A0
		internal Class491(Class304 class304_1, float float_4)
		{
			this.class304_0 = class304_1;
			float num = 41f / float_4;
			this.float_0 = 16f;
			this.float_3 = class304_1.Position.X * num;
		}

		// Token: 0x0600220E RID: 8718
		// RVA: 0x0001B5C7 File Offset: 0x000197C7
		private float method_0()
		{
			return this.float_3 + this.float_1;
		}

		// Token: 0x06002210 RID: 8720
		// RVA: 0x000C9600 File Offset: 0x000C7800
		internal void method_1(Class491 class491_0, double double_3)
		{
			double num = (double)(this.class304_0.StartTime - class491_0.class304_0.StartTime) / double_3;
			double num2 = Math.Pow(Class491.double_0, num / 1000.0);
			this.float_1 = Class778.smethod_2(class491_0.method_0(), this.float_3 - (41f - this.float_0), this.float_3 + (41f - this.float_0)) - this.float_3;
			this.float_2 = this.method_2(class491_0);
			double num3 = Class491.smethod_0(this.float_2);
			if (this.float_3 < class491_0.float_3)
			{
				this.float_2 = -this.float_2;
			}
			Class316 class = class491_0.class304_0 as Class316;
			double num4 = 0.0;
			double num5 = Math.Sqrt(Math.Max(num, 25.0));
			if ((double)Math.Abs(this.float_2) > 0.1)
			{
				if ((double)Math.Abs(class491_0.float_2) > 0.1 && Math.Sign(this.float_2) != Math.Sign(class491_0.float_2))
				{
					double num6 = this.double_2 / num5;
					double num7 = (double)(Math.Min(this.float_0, Math.Abs(this.float_2)) / this.float_0);
					num3 += num6 * num7;
					if (class != null && class.float_0 <= 10f)
					{
						num4 += 0.3 * num7;
					}
				}
				num3 += 7.5 * (double)Math.Min(Math.Abs(this.float_2), 82f) / 246.0 / num5;
			}
			if (class != null && class.float_0 <= 10f)
			{
				if (!class.method_8())
				{
					num4 += 1.0;
				}
				else
				{
					this.float_1 = 0f;
				}
				num3 *= 1.0 + num4 * (double)((10f - class.float_0) / 10f);
			}
			num3 *= 850.0 / Math.Max(num, 25.0);
			this.double_1 = class491_0.double_1 * num2 + num3;
		}

		// Token: 0x06002212 RID: 8722
		// RVA: 0x0001B5F2 File Offset: 0x000197F2
		internal float method_2(Class491 class491_0)
		{
			return Math.Abs(this.method_0() - class491_0.method_0());
		}

		// Token: 0x06002211 RID: 8721
		// RVA: 0x0001B5D6 File Offset: 0x000197D6
		private static double smethod_0(float float_4)
		{
			return Math.Pow((double)float_4, 1.3) / 500.0;
		}
	}
}
