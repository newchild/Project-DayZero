using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns79;
using osu.Graphics.Primitives;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ns14
{
	// Token: 0x020005B2 RID: 1458
	internal sealed class Class778
	{
		// Token: 0x06002E8C RID: 11916
		// RVA: 0x0002311D File Offset: 0x0002131D
		internal static float smethod_0(float float_0, float float_1, float float_2)
		{
			return float_0 + (float_1 - float_0) * float_2;
		}

		// Token: 0x06002E8D RID: 11917
		// RVA: 0x00023126 File Offset: 0x00021326
		internal static int smethod_1(int int_0, int int_1, int int_2)
		{
			if (int_0 > int_2)
			{
				return int_2;
			}
			if (int_0 < int_1)
			{
				return int_1;
			}
			return int_0;
		}

		// Token: 0x06002E96 RID: 11926
		// RVA: 0x000231C7 File Offset: 0x000213C7
		internal static Vector2 smethod_10(Vector2 vector2_0, float float_0, double double_0)
		{
			return new Vector2((float)(Math.Cos(double_0) * (double)float_0), (float)(Math.Sin(double_0) * (double)float_0)) + vector2_0;
		}

		// Token: 0x06002E97 RID: 11927
		// RVA: 0x000231E8 File Offset: 0x000213E8
		internal static float smethod_11(float float_0, float float_1, float float_2, float float_3)
		{
			return (float)Class778.smethod_17(Enum70.const_4, (double)float_0, (double)float_1, (double)(float_2 - float_1), (double)float_3);
		}

		// Token: 0x06002E98 RID: 11928
		// RVA: 0x000231FB File Offset: 0x000213FB
		internal static float smethod_12(float float_0, float float_1, float float_2, float float_3)
		{
			return (float)Class778.smethod_17(Enum70.const_3, (double)float_0, (double)float_1, (double)(float_2 - float_1), (double)float_3);
		}

		// Token: 0x06002E99 RID: 11929
		// RVA: 0x0012EF98 File Offset: 0x0012D198
		public static Color smethod_13(Color color_0, Color color_1, int int_0, int int_1, int int_2, Enum70 enum70_0)
		{
			if (color_0 == color_1)
			{
				return color_0;
			}
			int num = int_0 - int_1;
			int num2 = int_2 - int_1;
			if (num2 != 0 && num != 0)
			{
				return new Color((byte)Math.Max(0.0, Math.Min(255.0, Class778.smethod_17(enum70_0, (double)num, (double)color_0.get_R(), (double)(color_1.get_R() - color_0.get_R()), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, Class778.smethod_17(enum70_0, (double)num, (double)color_0.get_G(), (double)(color_1.get_G() - color_0.get_G()), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, Class778.smethod_17(enum70_0, (double)num, (double)color_0.get_B(), (double)(color_1.get_B() - color_0.get_B()), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, Class778.smethod_17(enum70_0, (double)num, (double)color_0.get_A(), (double)(color_1.get_A() - color_0.get_A()), (double)num2))));
			}
			return color_0;
		}

		// Token: 0x06002E9A RID: 11930
		// RVA: 0x0012F0CC File Offset: 0x0012D2CC
		public static float smethod_14(float float_0, float float_1, int int_0, int int_1, int int_2, Enum70 enum70_0)
		{
			if (float_0 == float_1)
			{
				return float_0;
			}
			int num = int_0 - int_1;
			int num2 = int_2 - int_1;
			if (num == 0)
			{
				return float_0;
			}
			if (num2 == 0)
			{
				return float_1;
			}
			return (float)Class778.smethod_17(enum70_0, (double)num, (double)float_0, (double)(float_1 - float_0), (double)num2);
		}

		// Token: 0x06002E9B RID: 11931
		// RVA: 0x0012F104 File Offset: 0x0012D304
		internal static Vector2 smethod_15(Vector2 vector2_0, Vector2 vector2_1, double double_0, double double_1, float float_0, Enum70 enum70_0)
		{
			float num = (float)(double_0 - double_1);
			float num2 = (float)((double)float_0 - double_1);
			if (num2 != 0f)
			{
				if (num != 0f)
				{
					return new Vector2((float)Class778.smethod_17(enum70_0, (double)num, (double)vector2_0.X, (double)(vector2_1.X - vector2_0.X), (double)num2), (float)Class778.smethod_17(enum70_0, (double)num, (double)vector2_0.Y, (double)(vector2_1.Y - vector2_0.Y), (double)num2));
				}
			}
			return vector2_0;
		}

		// Token: 0x06002E9C RID: 11932
		// RVA: 0x0012F180 File Offset: 0x0012D380
		internal static osu.Graphics.Primitives.RectangleF smethod_16(osu.Graphics.Primitives.RectangleF rectangleF_0, osu.Graphics.Primitives.RectangleF rectangleF_1, double double_0, double double_1, float float_0, Enum70 enum70_0)
		{
			float num = (float)(double_0 - double_1);
			float num2 = (float)((double)float_0 - double_1);
			if (num2 != 0f)
			{
				if (num != 0f)
				{
					return new osu.Graphics.Primitives.RectangleF((float)Class778.smethod_17(enum70_0, (double)num, (double)rectangleF_0.X, (double)(rectangleF_1.X - rectangleF_0.X), (double)num2), (float)Class778.smethod_17(enum70_0, (double)num, (double)rectangleF_0.Y, (double)(rectangleF_1.Y - rectangleF_0.Y), (double)num2), (float)Class778.smethod_17(enum70_0, (double)num, (double)rectangleF_0.Width, (double)(rectangleF_1.Width - rectangleF_0.Width), (double)num2), (float)Class778.smethod_17(enum70_0, (double)num, (double)rectangleF_0.Height, (double)(rectangleF_1.Height - rectangleF_0.Height), (double)num2));
				}
			}
			return rectangleF_0;
		}

		// Token: 0x06002E9D RID: 11933
		// RVA: 0x0012F248 File Offset: 0x0012D448
		internal static double smethod_17(Enum70 enum70_0, double double_0, double double_1, double double_2, double double_3)
		{
			if (double_2 != 0.0 && double_0 != 0.0)
			{
				if (double_3 != 0.0)
				{
					if (double_0 == double_3)
					{
						return double_1 + double_2;
					}
					switch (enum70_0)
					{
					case Enum70.const_1:
					case Enum70.const_4:
						return -double_2 * (double_0 /= double_3) * (double_0 - 2.0) + double_1;
					case Enum70.const_2:
					case Enum70.const_3:
						return double_2 * (double_0 /= double_3) * double_0 + double_1;
					case Enum70.const_5:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * double_0 * double_0 + double_1;
						}
						return -double_2 / 2.0 * ((double_0 -= 1.0) * (double_0 - 2.0) - 1.0) + double_1;
					case Enum70.const_6:
						return double_2 * (double_0 /= double_3) * double_0 * double_0 + double_1;
					case Enum70.const_7:
						return double_2 * ((double_0 = double_0 / double_3 - 1.0) * double_0 * double_0 + 1.0) + double_1;
					case Enum70.const_8:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * double_0 * double_0 * double_0 + double_1;
						}
						return double_2 / 2.0 * ((double_0 -= 2.0) * double_0 * double_0 + 2.0) + double_1;
					case Enum70.const_9:
						return double_2 * (double_0 /= double_3) * double_0 * double_0 * double_0 + double_1;
					case Enum70.const_10:
						return -double_2 * ((double_0 = double_0 / double_3 - 1.0) * double_0 * double_0 * double_0 - 1.0) + double_1;
					case Enum70.const_11:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * double_0 * double_0 * double_0 * double_0 + double_1;
						}
						return -double_2 / 2.0 * ((double_0 -= 2.0) * double_0 * double_0 * double_0 - 2.0) + double_1;
					case Enum70.const_12:
						return double_2 * (double_0 /= double_3) * double_0 * double_0 * double_0 * double_0 + double_1;
					case Enum70.const_13:
						return double_2 * ((double_0 = double_0 / double_3 - 1.0) * double_0 * double_0 * double_0 * double_0 + 1.0) + double_1;
					case Enum70.const_14:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * double_0 * double_0 * double_0 * double_0 * double_0 + double_1;
						}
						return double_2 / 2.0 * ((double_0 -= 2.0) * double_0 * double_0 * double_0 * double_0 + 2.0) + double_1;
					case Enum70.const_15:
						return -double_2 * Math.Cos(double_0 / double_3 * 1.5707950592041016) + double_2 + double_1;
					case Enum70.const_16:
						return double_2 * Math.Sin(double_0 / double_3 * 1.5707950592041016) + double_1;
					case Enum70.const_17:
						return -double_2 / 2.0 * (Math.Cos(3.1415901184082031 * double_0 / double_3) - 1.0) + double_1;
					case Enum70.const_18:
						return double_2 * Math.Pow(2.0, 10.0 * (double_0 / double_3 - 1.0)) + double_1;
					case Enum70.const_19:
						if (double_0 != double_3)
						{
							return double_2 * (-Math.Pow(2.0, -10.0 * double_0 / double_3) + 1.0) + double_1;
						}
						return double_1 + double_2;
					case Enum70.const_20:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * Math.Pow(2.0, 10.0 * (double_0 - 1.0)) + double_1;
						}
						return double_2 / 2.0 * (-Math.Pow(2.0, -10.0 * (double_0 -= 1.0)) + 2.0) + double_1;
					case Enum70.const_21:
						return -double_2 * (Math.Sqrt(1.0 - (double_0 /= double_3) * double_0) - 1.0) + double_1;
					case Enum70.const_22:
						return double_2 * Math.Sqrt(1.0 - (double_0 = double_0 / double_3 - 1.0) * double_0) + double_1;
					case Enum70.const_23:
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return -double_2 / 2.0 * (Math.Sqrt(1.0 - double_0 * double_0) - 1.0) + double_1;
						}
						return double_2 / 2.0 * (Math.Sqrt(1.0 - (double_0 -= 2.0) * double_0) + 1.0) + double_1;
					case Enum70.const_24:
					{
						if ((double_0 /= double_3) == 1.0)
						{
							return double_1 + double_2;
						}
						double num = double_3 * 0.3;
						double num2 = double_2;
						double num3;
						if (num2 < Math.Abs(double_2))
						{
							num2 = double_2;
							num3 = num / 4.0;
						}
						else
						{
							num3 = num / 6.2831802368164062 * Math.Asin(double_2 / num2);
						}
						return -(num2 * Math.Pow(2.0, 10.0 * (double_0 -= 1.0)) * Math.Sin((double_0 * double_3 - num3) * 6.2831802368164062 / num)) + double_1;
					}
					case Enum70.const_25:
					{
						if ((double_0 /= double_3) == 1.0)
						{
							return double_1 + double_2;
						}
						double num4 = double_3 * 0.3;
						double num5 = double_2;
						double num6;
						if (num5 < Math.Abs(double_2))
						{
							num5 = double_2;
							num6 = num4 / 4.0;
						}
						else
						{
							num6 = num4 / 6.2831802368164062 * Math.Asin(double_2 / num5);
						}
						return num5 * Math.Pow(2.0, -10.0 * double_0) * Math.Sin((double_0 * double_3 - num6) * 6.2831802368164062 / num4) + double_2 + double_1;
					}
					case Enum70.const_26:
					{
						if ((double_0 /= double_3) == 1.0)
						{
							return double_1 + double_2;
						}
						double num7 = double_3 * 0.3;
						double num8 = double_2;
						double num9;
						if (num8 < Math.Abs(double_2))
						{
							num8 = double_2;
							num9 = num7 / 4.0;
						}
						else
						{
							num9 = num7 / 6.2831802368164062 * Math.Asin(double_2 / num8);
						}
						return num8 * Math.Pow(2.0, -10.0 * double_0) * Math.Sin((0.5 * double_0 * double_3 - num9) * 6.2831802368164062 / num7) + double_2 + double_1;
					}
					case Enum70.const_27:
					{
						if ((double_0 /= double_3) == 1.0)
						{
							return double_1 + double_2;
						}
						double num10 = double_3 * 0.3;
						double num11 = double_2;
						double num12;
						if (num11 < Math.Abs(double_2))
						{
							num11 = double_2;
							num12 = num10 / 4.0;
						}
						else
						{
							num12 = num10 / 6.2831802368164062 * Math.Asin(double_2 / num11);
						}
						return num11 * Math.Pow(2.0, -10.0 * double_0) * Math.Sin((0.25 * double_0 * double_3 - num12) * 6.2831802368164062 / num10) + double_2 + double_1;
					}
					case Enum70.const_28:
					{
						if ((double_0 /= double_3 / 2.0) == 2.0)
						{
							return double_1 + double_2;
						}
						double num13 = double_3 * 0.44999999999999996;
						double num14 = double_2;
						double num15;
						if (num14 < Math.Abs(double_2))
						{
							num14 = double_2;
							num15 = num13 / 4.0;
						}
						else
						{
							num15 = num13 / 6.2831802368164062 * Math.Asin(double_2 / num14);
						}
						if (double_0 < 1.0)
						{
							return -0.5 * (num14 * Math.Pow(2.0, 10.0 * (double_0 -= 1.0)) * Math.Sin((double_0 * double_3 - num15) * 6.2831802368164062 / num13)) + double_1;
						}
						return num14 * Math.Pow(2.0, -10.0 * (double_0 -= 1.0)) * Math.Sin((double_0 * double_3 - num15) * 6.2831802368164062 / num13) * 0.5 + double_2 + double_1;
					}
					case Enum70.const_29:
					{
						double num16 = 1.70158;
						return double_2 * (double_0 /= double_3) * double_0 * (2.70158 * double_0 - num16) + double_1;
					}
					case Enum70.const_30:
					{
						double num17 = 1.70158;
						return double_2 * ((double_0 = double_0 / double_3 - 1.0) * double_0 * (2.70158 * double_0 + num17) + 1.0) + double_1;
					}
					case Enum70.const_31:
					{
						double num18 = 1.70158;
						if ((double_0 /= double_3 / 2.0) < 1.0)
						{
							return double_2 / 2.0 * (double_0 * double_0 * (((num18 *= 1.525) + 1.0) * double_0 - num18)) + double_1;
						}
						return double_2 / 2.0 * ((double_0 -= 2.0) * double_0 * (((num18 *= 1.525) + 1.0) * double_0 + num18) + 2.0) + double_1;
					}
					case Enum70.const_32:
						return double_2 - Class778.smethod_17(Enum70.const_33, double_3 - double_0, 0.0, double_2, double_3) + double_1;
					case Enum70.const_33:
						if ((double_0 /= double_3) < 0.36363636363636365)
						{
							return double_2 * (7.5625 * double_0 * double_0) + double_1;
						}
						if (double_0 < 0.72727272727272729)
						{
							return double_2 * (7.5625 * (double_0 -= 0.54545454545454541) * double_0 + 0.75) + double_1;
						}
						if (double_0 < 0.90909090909090906)
						{
							return double_2 * (7.5625 * (double_0 -= 0.81818181818181823) * double_0 + 0.9375) + double_1;
						}
						return double_2 * (7.5625 * (double_0 -= 0.95454545454545459) * double_0 + 0.984375) + double_1;
					case Enum70.const_34:
						if (double_0 < double_3 / 2.0)
						{
							return Class778.smethod_17(Enum70.const_32, double_0 * 2.0, 0.0, double_2, double_3) * 0.5 + double_1;
						}
						return Class778.smethod_17(Enum70.const_33, double_0 * 2.0 - double_3, 0.0, double_2, double_3) * 0.5 + double_2 * 0.5 + double_1;
					default:
						return double_2 * (double_0 / double_3) + double_1;
					}
				}
			}
			return double_1;
		}

		// Token: 0x06002E8E RID: 11918
		// RVA: 0x00023135 File Offset: 0x00021335
		internal static float smethod_2(float float_0, float float_1, float float_2)
		{
			if (float.IsNaN(float_1) || float.IsNaN(float_2))
			{
				return float.NaN;
			}
			if (float_0 > float_2)
			{
				return float_2;
			}
			if (float_0 < float_1)
			{
				return float_1;
			}
			return float_0;
		}

		// Token: 0x06002E8F RID: 11919
		// RVA: 0x0012EBE8 File Offset: 0x0012CDE8
		internal static List<Vector2> smethod_3(List<Vector2> list_0)
		{
			int count = list_0.Count;
			Vector2[] array = new Vector2[count];
			List<Vector2> list = new List<Vector2>();
			int num = 50 * count;
			for (int i = 0; i <= num; i++)
			{
				for (int j = 0; j < count; j++)
				{
					array[j] = list_0[j];
				}
				for (int k = 0; k < count; k++)
				{
					for (int l = 0; l < count - k - 1; l++)
					{
						Vector2.Lerp(ref array[l], ref array[l + 1], (float)i / (float)num, ref array[l]);
					}
				}
				list.Add(array[0]);
			}
			return list;
		}

		// Token: 0x06002E90 RID: 11920
		// RVA: 0x0012ECA8 File Offset: 0x0012CEA8
		internal static List<Vector2> smethod_4(List<Vector2> list_0)
		{
			int count = list_0.Count;
			Vector2[] array = new Vector2[count];
			List<Vector2> list = new List<Vector2>();
			int num = 50 * count;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < count; j++)
				{
					array[j] = list_0[j];
				}
				for (int k = 0; k < count; k++)
				{
					for (int l = 0; l < count - k - 1; l++)
					{
						Vector2.Lerp(ref array[l], ref array[l + 1], (float)i / (float)num, ref array[l]);
					}
				}
				list.Add(array[0]);
			}
			return list;
		}

		// Token: 0x06002E91 RID: 11921
		// RVA: 0x0002315A File Offset: 0x0002135A
		internal static Color smethod_5(Color color_0)
		{
			return new Color(color_0.R, color_0.G, color_0.B, color_0.A);
		}

		// Token: 0x06002E92 RID: 11922
		// RVA: 0x0002317D File Offset: 0x0002137D
		internal static Color smethod_6(Color color_0)
		{
			return Color.FromArgb((int)color_0.get_A(), (int)color_0.get_R(), (int)color_0.get_G(), (int)color_0.get_B());
		}

		// Token: 0x06002E93 RID: 11923
		// RVA: 0x0012ED68 File Offset: 0x0012CF68
		internal static float[] smethod_7(Matrix matrix_0)
		{
			return new float[]
			{
				matrix_0.M11,
				matrix_0.M12,
				matrix_0.M13,
				matrix_0.M14,
				matrix_0.M21,
				matrix_0.M22,
				matrix_0.M23,
				matrix_0.M24,
				matrix_0.M31,
				matrix_0.M32,
				matrix_0.M33,
				matrix_0.M34,
				matrix_0.M41,
				matrix_0.M42,
				matrix_0.M43,
				matrix_0.M44
			};
		}

		// Token: 0x06002E94 RID: 11924
		// RVA: 0x0012EE28 File Offset: 0x0012D028
		internal static void smethod_8(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, ref Vector2 vector2_3, ref float float_0, ref double double_0, ref double double_1)
		{
			float num = 2f * (vector2_0.X * (vector2_1.Y - vector2_2.Y) + vector2_1.X * (vector2_2.Y - vector2_0.Y) + vector2_2.X * (vector2_0.Y - vector2_1.Y));
			float num2 = vector2_0.LengthSquared();
			float num3 = vector2_1.LengthSquared();
			float num4 = vector2_2.LengthSquared();
			vector2_3 = new Vector2((num2 * (vector2_1.Y - vector2_2.Y) + num3 * (vector2_2.Y - vector2_0.Y) + num4 * (vector2_0.Y - vector2_1.Y)) / num, (num2 * (vector2_2.X - vector2_1.X) + num3 * (vector2_0.X - vector2_2.X) + num4 * (vector2_1.X - vector2_0.X)) / num);
			float_0 = Vector2.Distance(vector2_3, vector2_0);
			double_0 = Class778.smethod_9(vector2_0, vector2_3);
			double num5 = Class778.smethod_9(vector2_1, vector2_3);
			double_1 = Class778.smethod_9(vector2_2, vector2_3);
			while (num5 < double_0)
			{
				num5 += 6.2831802368164062;
			}
			while (double_1 < double_0)
			{
				double_1 += 6.2831802368164062;
			}
			if (num5 > double_1)
			{
				double_1 -= 6.2831802368164062;
			}
		}

		// Token: 0x06002E95 RID: 11925
		// RVA: 0x000231A0 File Offset: 0x000213A0
		internal static double smethod_9(Vector2 vector2_0, Vector2 vector2_1)
		{
			return Math.Atan2((double)(vector2_0.Y - vector2_1.Y), (double)(vector2_0.X - vector2_1.X));
		}
	}
}
