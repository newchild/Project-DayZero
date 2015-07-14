using Microsoft.Xna.Framework;
using ns24;
using ns59;
using osu.GameplayElements.HitObjects;
using System;

namespace ns60
{
	// Token: 0x0200043D RID: 1085
	internal sealed class Class510
	{
		// Token: 0x04001B45 RID: 6981
		internal Class304 class304_0;

		// Token: 0x04001B42 RID: 6978
		internal static readonly double[] double_0 = new double[]
		{
			0.3,
			0.15
		};

		// Token: 0x04001B43 RID: 6979
		private static readonly double[] double_1 = new double[]
		{
			1400.0,
			26.25
		};

		// Token: 0x04001B46 RID: 6982
		internal double[] double_2 = new double[]
		{
			1.0,
			1.0
		};

		// Token: 0x04001B49 RID: 6985
		private float float_0;

		// Token: 0x04001B4A RID: 6986
		private float float_1;

		// Token: 0x04001B44 RID: 6980
		internal int int_0;

		// Token: 0x04001B47 RID: 6983
		private Vector2 vector2_0;

		// Token: 0x04001B48 RID: 6984
		private Vector2 vector2_1;

		// Token: 0x0600230A RID: 8970
		// RVA: 0x000D3428 File Offset: 0x000D1628
		internal Class510(Class304 class304_1, float float_2)
		{
			this.class304_0 = class304_1;
			if (class304_1.IsType(HitObjectType.Slider))
			{
				Class321 class = (Class321)class304_1;
				this.int_0 = 1 + class.list_7.Count;
			}
			else
			{
				this.int_0 = 1;
			}
			float num = 52f / float_2;
			if (float_2 < 30f)
			{
				float num2 = Math.Min(30f - float_2, 5f) / 50f;
				num *= 1f + num2;
			}
			this.vector2_0 = class304_1.Position * num;
			if (class304_1.IsType(HitObjectType.Slider))
			{
				float num3 = float_2 * 3f;
				int num4 = Math.Min(class304_1.Length / class304_1.SegmentCount, 60000);
				int num5 = class304_1.StartTime + num4;
				Vector2 vector = class304_1.Position;
				for (int i = class304_1.StartTime + 10; i < num5; i += 10)
				{
					Vector2 vector2 = class304_1.PositionAtTime(i) - vector;
					float num6 = vector2.Length();
					if (num6 > num3)
					{
						vector2.Normalize();
						num6 -= num3;
						vector += vector2 * num6;
						this.float_0 += num6;
					}
				}
				this.float_0 *= num;
				if (class304_1.SegmentCount % 2 == 1)
				{
					this.vector2_1 = vector * num;
				}
				if (class304_1.SegmentCount > 1)
				{
					num5 += num4;
					for (int j = num5 - num4 + 10; j < num5; j += 10)
					{
						Vector2 vector3 = class304_1.PositionAtTime(j) - vector;
						float num7 = vector3.Length();
						if (num7 > num3)
						{
							vector3.Normalize();
							num7 -= num3;
							vector += vector3 * num7;
							this.float_1 += num7;
						}
					}
					this.float_1 *= num;
					if (class304_1.SegmentCount % 2 == 0)
					{
						this.vector2_1 = vector * num;
						return;
					}
				}
			}
			else
			{
				this.vector2_1 = this.vector2_0;
			}
		}

		// Token: 0x0600230B RID: 8971
		// RVA: 0x0001BD21 File Offset: 0x00019F21
		internal void method_0(Class510 class510_0, double double_3)
		{
			this.method_1(class510_0, Class464.Enum46.const_0, double_3);
			this.method_1(class510_0, Class464.Enum46.const_1, double_3);
		}

		// Token: 0x0600230D RID: 8973
		// RVA: 0x000D3760 File Offset: 0x000D1960
		private void method_1(Class510 class510_0, Class464.Enum46 enum46_0, double double_3)
		{
			double num = 0.0;
			double num2 = (double)(this.class304_0.StartTime - class510_0.class304_0.StartTime) / double_3;
			double num3 = Math.Pow(Class510.double_0[(int)enum46_0], num2 / 1000.0);
			if (!this.class304_0.IsType(HitObjectType.Spinner))
			{
				if (this.class304_0.IsType(HitObjectType.Slider))
				{
					switch (enum46_0)
					{
					case Class464.Enum46.const_0:
						num = Class510.smethod_0((double)(class510_0.float_0 + class510_0.float_1 * (float)(class510_0.class304_0.SegmentCount - 1)) + this.method_2(class510_0), enum46_0) * Class510.double_1[(int)enum46_0];
						break;
					case Class464.Enum46.const_1:
						num = (Class510.smethod_0((double)class510_0.float_0, enum46_0) + Class510.smethod_0((double)class510_0.float_1, enum46_0) * (double)(class510_0.class304_0.SegmentCount - 1) + Class510.smethod_0(this.method_2(class510_0), enum46_0)) * Class510.double_1[(int)enum46_0];
						break;
					}
				}
				else if (this.class304_0.IsType(HitObjectType.Normal))
				{
					num = Class510.smethod_0(this.method_2(class510_0), enum46_0) * Class510.double_1[(int)enum46_0];
				}
			}
			num /= Math.Max(num2, 50.0);
			this.double_2[(int)enum46_0] = class510_0.double_2[(int)enum46_0] * num3 + num;
		}

		// Token: 0x0600230E RID: 8974
		// RVA: 0x000D38A4 File Offset: 0x000D1AA4
		internal double method_2(Class510 class510_0)
		{
			return (double)(this.vector2_0 - class510_0.vector2_1).Length();
		}

		// Token: 0x0600230C RID: 8972
		// RVA: 0x000D3658 File Offset: 0x000D1858
		private static double smethod_0(double double_3, Class464.Enum46 enum46_0)
		{
			switch (enum46_0)
			{
			case Class464.Enum46.const_0:
			{
				double result;
				if (double_3 > 125.0)
				{
					result = 2.5;
				}
				else if (double_3 > 110.0)
				{
					result = 1.6 + 0.9 * (double_3 - 110.0) / 15.0;
				}
				else if (double_3 > 90.0)
				{
					result = 1.2 + 0.4 * (double_3 - 90.0) / 20.0;
				}
				else if (double_3 > 45.0)
				{
					result = 0.95 + 0.25 * (double_3 - 45.0) / 45.0;
				}
				else
				{
					result = 0.95;
				}
				return result;
			}
			case Class464.Enum46.const_1:
				return Math.Pow(double_3, 0.99);
			default:
				return 0.0;
			}
		}
	}
}
