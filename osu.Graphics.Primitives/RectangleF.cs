using Microsoft.Xna.Framework;
using System;
using System.Globalization;

namespace osu.Graphics.Primitives
{
	// Token: 0x02000568 RID: 1384
	[Serializable]
	public struct RectangleF
	{
		// Token: 0x040024F5 RID: 9461
		public static readonly RectangleF Empty;

		// Token: 0x040024F9 RID: 9465
		public float Height;

		// Token: 0x040024F8 RID: 9464
		public float Width;

		// Token: 0x040024F6 RID: 9462
		public float X;

		// Token: 0x040024F7 RID: 9463
		public float Y;

		// Token: 0x170003A0 RID: 928
		public float Top
		{
			// Token: 0x06002CB3 RID: 11443
			// RVA: 0x00021DDC File Offset: 0x0001FFDC
			get
			{
				return this.Y;
			}
		}

		// Token: 0x06002CC1 RID: 11457
		// RVA: 0x00021E66 File Offset: 0x00020066
		static RectangleF()
		{
			RectangleF.Empty = default(RectangleF);
		}

		// Token: 0x06002CB0 RID: 11440
		// RVA: 0x00021DA6 File Offset: 0x0001FFA6
		public RectangleF(float float_0, float float_1, float float_2, float float_3)
		{
			this.X = float_0;
			this.Y = float_1;
			this.Width = float_2;
			this.Height = float_3;
		}

		// Token: 0x06002CB8 RID: 11448
		// RVA: 0x00021E38 File Offset: 0x00020038
		public bool Contains(Vector2 vector2_0)
		{
			return this.Contains(vector2_0.X, vector2_0.Y);
		}

		// Token: 0x06002CB9 RID: 11449
		// RVA: 0x00021E4E File Offset: 0x0002004E
		public bool Contains(Point point_0)
		{
			return this.Contains((float)point_0.X, (float)point_0.Y);
		}

		// Token: 0x06002CBA RID: 11450
		// RVA: 0x00121BB0 File Offset: 0x0011FDB0
		public bool Contains(RectangleF rectangleF_0)
		{
			return this.X <= rectangleF_0.X && rectangleF_0.X + rectangleF_0.Width <= this.X + this.Width && this.Y <= rectangleF_0.Y && rectangleF_0.Y + rectangleF_0.Height <= this.Y + this.Height;
		}

		// Token: 0x06002CB7 RID: 11447
		// RVA: 0x00021E02 File Offset: 0x00020002
		public bool Contains(float float_0, float float_1)
		{
			return this.X <= float_0 && float_0 < this.X + this.Width && this.Y <= float_1 && float_1 < this.Y + this.Height;
		}

		// Token: 0x06002CB6 RID: 11446
		// RVA: 0x00121B54 File Offset: 0x0011FD54
		public override bool Equals(object obj)
		{
			if (!(obj is RectangleF))
			{
				return false;
			}
			RectangleF rectangleF = (RectangleF)obj;
			return rectangleF.X == this.X && rectangleF.Y == this.Y && rectangleF.Width == this.Width && rectangleF.Height == this.Height;
		}

		// Token: 0x06002CBD RID: 11453
		// RVA: 0x00121D28 File Offset: 0x0011FF28
		public override int GetHashCode()
		{
			return (int)((uint)this.X ^ ((uint)this.Y << 13 | (uint)this.Y >> 19) ^ ((uint)this.Width << 26 | (uint)this.Width >> 6) ^ ((uint)this.Height << 7 | (uint)this.Height >> 25));
		}

		// Token: 0x06002CB2 RID: 11442
		// RVA: 0x00021DD4 File Offset: 0x0001FFD4
		public float method_0()
		{
			return this.X;
		}

		// Token: 0x06002CB4 RID: 11444
		// RVA: 0x00021DE4 File Offset: 0x0001FFE4
		public float method_1()
		{
			return this.X + this.Width;
		}

		// Token: 0x06002CB5 RID: 11445
		// RVA: 0x00021DF3 File Offset: 0x0001FFF3
		public float method_2()
		{
			return this.Y + this.Height;
		}

		// Token: 0x06002CBB RID: 11451
		// RVA: 0x00121C1C File Offset: 0x0011FE1C
		public bool method_3(Vector2 vector2_0, Vector2 vector2_1, float float_0)
		{
			if (float_0 == 0f)
			{
				return this.Contains(vector2_0);
			}
			Matrix matrix = Matrix.CreateRotationZ(-float_0);
			Vector2 vector = Vector2.Transform(vector2_0 - vector2_1, matrix) + vector2_1;
			return this.Contains(vector.X, vector.Y);
		}

		// Token: 0x06002CBC RID: 11452
		// RVA: 0x00121C6C File Offset: 0x0011FE6C
		public void method_4(Vector2 vector2_0, float float_0, ref Vector2 vector2_1, ref Vector2 vector2_2, ref Vector2 vector2_3, ref Vector2 vector2_4)
		{
			Matrix matrix = Matrix.CreateRotationZ(float_0);
			vector2_1 = Vector2.Transform(new Vector2(this.method_0(), this.Top) - vector2_0, matrix) + vector2_0;
			vector2_2 = Vector2.Transform(new Vector2(this.method_1(), this.Top) - vector2_0, matrix) + vector2_0;
			vector2_3 = Vector2.Transform(new Vector2(this.method_0(), this.method_2()) - vector2_0, matrix) + vector2_0;
			vector2_4 = Vector2.Transform(new Vector2(this.method_1(), this.method_2()) - vector2_0, matrix) + vector2_0;
		}

		// Token: 0x06002CBE RID: 11454
		// RVA: 0x00121D7C File Offset: 0x0011FF7C
		public void method_5(float float_0, float float_1)
		{
			this.X -= float_0;
			this.Y -= float_1;
			this.Width += 2f * float_0;
			this.Height += 2f * float_1;
		}

		// Token: 0x06002CB1 RID: 11441
		// RVA: 0x00021DC5 File Offset: 0x0001FFC5
		public static RectangleF smethod_0(float float_0, float float_1, float float_2, float float_3)
		{
			return new RectangleF(float_0, float_1, float_2 - float_0, float_3 - float_1);
		}

		// Token: 0x06002CBF RID: 11455
		// RVA: 0x00121DD0 File Offset: 0x0011FFD0
		public static RectangleF smethod_1(RectangleF rectangleF_0, float float_0, float float_1)
		{
			RectangleF result = rectangleF_0;
			result.method_5(float_0, float_1);
			return result;
		}

		// Token: 0x06002CC2 RID: 11458
		// RVA: 0x00121E7C File Offset: 0x0012007C
		public static bool smethod_2(double double_0, RectangleF rectangleF_0, RectangleF rectangleF_1, Vector2 vector2_0)
		{
			double num2;
			double num;
			double num4;
			double num3;
			double num6;
			double num5;
			double num8;
			double num7;
			if (double_0 == 0.0)
			{
				num = (num2 = (double)rectangleF_0.X) + (double)rectangleF_0.Width;
				num3 = (num4 = (double)rectangleF_0.Y) + (double)rectangleF_0.Height;
				num5 = (num6 = (double)rectangleF_1.X) + (double)rectangleF_1.Width;
				num7 = (num8 = (double)rectangleF_1.Y) + (double)rectangleF_1.Height;
				return num2 <= num5 && num6 <= num && num4 <= num7 && num8 <= num3;
			}
			double num9 = Math.Cos(double_0);
			double num10 = Math.Sin(double_0);
			bool flag = num9 > 0.0;
			bool flag2 = num10 > 0.0;
			double num11 = 0.5 * (double)rectangleF_0.Width;
			double num12 = 0.5 * (double)rectangleF_0.Height;
			double num13 = (double)(rectangleF_0.X + vector2_0.X);
			double num14 = (double)(rectangleF_0.Y + vector2_0.Y);
			double num15 = num9 * num11;
			double num16 = num10 * num11;
			double num17 = num9 * num12;
			double num18 = num10 * num12;
			num5 = (num6 = (double)rectangleF_1.X - num13) + (double)rectangleF_1.Width;
			num7 = (num8 = (double)rectangleF_1.Y - num14) + (double)rectangleF_1.Height;
			if (flag)
			{
				if (flag2)
				{
					num2 = -(num = num15 + num18);
					num4 = -(num3 = num17 + num16);
				}
				else
				{
					num2 = -(num = num15 - num18);
					num4 = -(num3 = num17 - num16);
				}
			}
			else if (flag2)
			{
				num = -(num2 = num15 - num18);
				num3 = -(num4 = num17 - num16);
			}
			else
			{
				num = -(num2 = num15 + num18);
				num3 = -(num4 = num17 + num16);
			}
			if (num2 > num5 || num6 > num || num4 > num7 || num8 > num3)
			{
				return false;
			}
			if (flag)
			{
				if (flag2)
				{
					return num9 * num5 + num10 * num7 >= -num11 && num9 * num6 + num10 * num8 <= num11 && num9 * num7 - num10 * num6 >= -num12 && num9 * num8 - num10 * num5 <= num12;
				}
				return num9 * num5 + num10 * num8 >= -num11 && num9 * num6 + num10 * num7 <= num11 && num9 * num7 - num10 * num5 >= -num12 && num9 * num8 - num10 * num6 <= num12;
			}
			else
			{
				if (flag2)
				{
					return num9 * num6 + num10 * num7 >= -num11 && num9 * num5 + num10 * num8 <= num11 && num9 * num8 - num10 * num6 >= -num12 && num9 * num7 - num10 * num5 <= num12;
				}
				return num9 * num6 + num10 * num8 >= -num11 && num9 * num5 + num10 * num7 <= num11 && num9 * num8 - num10 * num5 >= -num12 && num9 * num7 - num10 * num6 <= num12;
			}
		}

		// Token: 0x06002CC0 RID: 11456
		// RVA: 0x00121DEC File Offset: 0x0011FFEC
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{X=",
				this.X.ToString(CultureInfo.CurrentCulture),
				",Y=",
				this.Y.ToString(CultureInfo.CurrentCulture),
				",Width=",
				this.Width.ToString(CultureInfo.CurrentCulture),
				",Height=",
				this.Height.ToString(CultureInfo.CurrentCulture),
				"}"
			});
		}
	}
}
