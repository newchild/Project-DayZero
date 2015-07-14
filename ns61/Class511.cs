using ns59;
using osu.GameplayElements.HitObjects;
using System;

namespace ns61
{
	// Token: 0x0200043F RID: 1087
	internal sealed class Class511
	{
		// Token: 0x02000440 RID: 1088
		private enum Enum49
		{
			// Token: 0x04001B57 RID: 6999
			const_0,
			// Token: 0x04001B58 RID: 7000
			const_1,
			// Token: 0x04001B59 RID: 7001
			const_2
		}

		// Token: 0x04001B4D RID: 6989
		internal Class304 class304_0;

		// Token: 0x04001B4C RID: 6988
		internal static readonly double double_0 = 0.3;

		// Token: 0x04001B4E RID: 6990
		internal double double_1 = 1.0;

		// Token: 0x04001B51 RID: 6993
		private double double_2;

		// Token: 0x04001B52 RID: 6994
		private readonly double double_3 = 0.75;

		// Token: 0x04001B53 RID: 6995
		private readonly double double_4 = 1.0;

		// Token: 0x04001B54 RID: 6996
		private readonly double double_5 = 0.2;

		// Token: 0x04001B55 RID: 6997
		private readonly double double_6 = 2.0;

		// Token: 0x04001B50 RID: 6992
		private Class511.Enum49 enum49_0;

		// Token: 0x04001B4F RID: 6991
		private int int_0 = 1;

		// Token: 0x06002317 RID: 8983
		// RVA: 0x000D3B1C File Offset: 0x000D1D1C
		internal Class511(Class304 class304_1)
		{
			this.class304_0 = class304_1;
		}

		// Token: 0x06002316 RID: 8982
		// RVA: 0x0001BD6B File Offset: 0x00019F6B
		internal bool method_0()
		{
			return this.class304_0.SoundType.IsType(HitObjectSoundType.Clap) || this.class304_0.SoundType.IsType(HitObjectSoundType.Whistle);
		}

		// Token: 0x06002318 RID: 8984
		// RVA: 0x000D3B88 File Offset: 0x000D1D88
		internal void method_1(Class511 class511_0, double double_7)
		{
			this.double_2 = (double)(this.class304_0.StartTime - class511_0.class304_0.StartTime) / double_7;
			double num = Math.Pow(Class511.double_0, this.double_2 / 1000.0);
			double num2 = 1.0;
			if (class511_0.class304_0.IsType(HitObjectType.Normal) && this.class304_0.IsType(HitObjectType.Normal) && this.class304_0.StartTime - class511_0.class304_0.StartTime < 1000)
			{
				num2 += this.method_2(class511_0);
				num2 += this.method_3(class511_0);
			}
			double num3 = 1.0;
			if (this.double_2 < 50.0)
			{
				num3 = 0.4 + 0.6 * this.double_2 / 50.0;
			}
			this.double_1 = class511_0.double_1 * num + num2 * num3;
		}

		// Token: 0x06002319 RID: 8985
		// RVA: 0x000D3C7C File Offset: 0x000D1E7C
		internal double method_2(Class511 class511_0)
		{
			if (class511_0.method_0() != this.method_0())
			{
				this.enum49_0 = ((class511_0.int_0 % 2 == 0) ? Class511.Enum49.const_1 : Class511.Enum49.const_2);
				switch (class511_0.enum49_0)
				{
				case Class511.Enum49.const_1:
					if (this.enum49_0 == Class511.Enum49.const_2)
					{
						return this.double_3;
					}
					break;
				case Class511.Enum49.const_2:
					if (this.enum49_0 == Class511.Enum49.const_1)
					{
						return this.double_3;
					}
					break;
				}
			}
			else
			{
				this.enum49_0 = class511_0.enum49_0;
				this.int_0 = class511_0.int_0 + 1;
			}
			return 0.0;
		}

		// Token: 0x0600231A RID: 8986
		// RVA: 0x000D3D08 File Offset: 0x000D1F08
		internal double method_3(Class511 class511_0)
		{
			if (this.double_2 != 0.0)
			{
				if (class511_0.double_2 != 0.0)
				{
					double num = Math.Max(class511_0.double_2 / this.double_2, this.double_2 / class511_0.double_2);
					if (num >= 8.0)
					{
						return 0.0;
					}
					double num2 = Math.Log(num, this.double_6) % 1.0;
					if (num2 > this.double_5 && num2 < 1.0 - this.double_5)
					{
						return this.double_4;
					}
					return 0.0;
				}
			}
			return 0.0;
		}
	}
}
