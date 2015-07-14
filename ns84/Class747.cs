using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns29;
using ns64;
using ns77;
using ns80;
using osu_ui;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ns84
{
	// Token: 0x02000587 RID: 1415
	internal static class Class747
	{
		// Token: 0x02000588 RID: 1416
		private enum Enum71
		{
			// Token: 0x040025FC RID: 9724
			const_0,
			// Token: 0x040025FD RID: 9725
			const_1,
			// Token: 0x040025FE RID: 9726
			const_2,
			// Token: 0x040025FF RID: 9727
			const_3,
			// Token: 0x04002600 RID: 9728
			const_4
		}

		// Token: 0x040025F4 RID: 9716
		private static readonly Brush brush_0 = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

		// Token: 0x040025F5 RID: 9717
		private static readonly Brush brush_1 = new SolidBrush(Color.FromArgb(160, 20, 20, 20));

		// Token: 0x040025F8 RID: 9720
		private static Dictionary<string, Font> dictionary_0 = new Dictionary<string, Font>();

		// Token: 0x040025F9 RID: 9721
		private static float float_0 = 0f;

		// Token: 0x040025FA RID: 9722
		internal static float float_1 = 1f;

		// Token: 0x040025F6 RID: 9718
		private static object object_0 = new object();

		// Token: 0x040025F7 RID: 9719
		private static PrivateFontCollection privateFontCollection_0 = new PrivateFontCollection();

		// Token: 0x06002D5F RID: 11615
		// RVA: 0x000224DA File Offset: 0x000206DA
		internal static void Initialize()
		{
			Class747.smethod_12("FontAwesome", false);
			Class747.smethod_12("Aller", false);
			Class747.smethod_12("Aller_Lt", false);
			Class747.smethod_12("Aller_Bd", false);
		}

		// Token: 0x06002D53 RID: 11603
		// RVA: 0x000224B1 File Offset: 0x000206B1
		private static bool smethod_0(char char_0)
		{
			return (char_0 >= '぀' && char_0 <= 'ゟ') || (char_0 >= '゠' && char_0 <= 'ヿ');
		}

		// Token: 0x06002D54 RID: 11604
		// RVA: 0x0012625C File Offset: 0x0012445C
		private static bool smethod_1(char char_0)
		{
			return (char_0 >= '가' && char_0 <= '힯') || (char_0 >= 'ᄀ' && char_0 <= 'ᇿ') || (char_0 >= '㄰' && char_0 <= '㆏') || (char_0 >= '㈀' && char_0 <= '㋿') || (char_0 >= 'ꥠ' && char_0 <= '꥿') || (char_0 >= 'ힰ' && char_0 <= '퟿');
		}

		// Token: 0x06002D5D RID: 11613
		// RVA: 0x00127160 File Offset: 0x00125360
		internal static void smethod_10()
		{
			foreach (Font current in Class747.dictionary_0.Values)
			{
				current.Dispose();
			}
			Class747.dictionary_0.Clear();
		}

		// Token: 0x06002D5E RID: 11614
		// RVA: 0x001271C4 File Offset: 0x001253C4
		private static Font smethod_11(string string_0, float float_2, FontStyle fontStyle_0)
		{
			if (string_0.StartsWith("skin-"))
			{
				string_0 = string_0.Replace("skin-", string.Empty);
				Font font = Class885.smethod_16(float_2, FontStyle.Regular);
				if (font != null)
				{
					return font;
				}
			}
			string key = string_0 + float_2 + (int)fontStyle_0;
			Font font2;
			if (Class747.dictionary_0.TryGetValue(key, out font2))
			{
				return font2;
			}
			FontFamily fontFamily = Class747.smethod_12(string_0, true);
			if (fontFamily != null)
			{
				font2 = new Font(fontFamily, float_2, fontStyle_0);
			}
			else
			{
				font2 = new Font(string_0, float_2, fontStyle_0);
			}
			return Class747.dictionary_0[key] = font2;
		}

		// Token: 0x06002D60 RID: 11616
		// RVA: 0x00127254 File Offset: 0x00125454
		private static FontFamily smethod_12(string string_0, bool bool_0)
		{
			if (string_0.StartsWith("res:"))
			{
				string_0 = string_0.Replace("res:", string.Empty);
				bool_0 = false;
			}
			FontFamily[] families = Class747.privateFontCollection_0.Families;
			for (int i = 0; i < families.Length; i++)
			{
				FontFamily fontFamily = families[i];
				if (fontFamily.Name == string_0)
				{
					return fontFamily;
				}
			}
			if (bool_0)
			{
				return null;
			}
			FontFamily result = null;
			try
			{
				byte[] array = (byte[])ResourcesStore.get_ResourceManager().GetObject(string_0);
				if (array != null && array.Length > 0)
				{
					GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
					IntPtr memory = gCHandle.AddrOfPinnedObject();
					Class747.privateFontCollection_0.AddMemoryFont(memory, array.Length);
					gCHandle.Free();
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06002D55 RID: 11605
		// RVA: 0x001262D0 File Offset: 0x001244D0
		private static bool smethod_2(char char_0)
		{
			return (char_0 >= '一' && char_0 <= '鿿') || (char_0 >= '㐀' && char_0 <= '䷿') || ((int)char_0 >= 131072 && (int)char_0 <= 173791) || (char_0 >= '豈' && char_0 <= '﫿') || ((int)char_0 >= 194560 && (int)char_0 <= 195103);
		}

		// Token: 0x06002D56 RID: 11606
		// RVA: 0x00126334 File Offset: 0x00124534
		private static bool smethod_3(char char_0)
		{
			return (char_0 >= 'Ѐ' && char_0 <= 'ӿ') || (char_0 >= 'Ԁ' && char_0 <= 'ԯ') || (char_0 >= 'ⷠ' && char_0 <= 'ⷿ') || (char_0 >= 'Ꙁ' && char_0 <= 'ꚟ');
		}

		// Token: 0x06002D57 RID: 11607
		// RVA: 0x00126388 File Offset: 0x00124588
		private static Class747.Enum71 smethod_4(string string_0)
		{
			bool flag = false;
			int i = 0;
			while (i < string_0.Length)
			{
				char char_ = string_0[i];
				Class747.Enum71 result;
				if (!Class747.smethod_0(char_))
				{
					if (!Class747.smethod_1(char_))
					{
						if (!Class747.smethod_3(char_))
						{
							flag |= Class747.smethod_2(char_);
							i++;
							continue;
						}
						result = Class747.Enum71.const_3;
					}
					else
					{
						result = Class747.Enum71.const_2;
					}
				}
				else
				{
					result = Class747.Enum71.const_1;
				}
				return result;
			}
			if (!flag)
			{
				return Class747.Enum71.const_0;
			}
			return Class747.Enum71.const_4;
		}

		// Token: 0x06002D58 RID: 11608
		// RVA: 0x001263EC File Offset: 0x001245EC
		internal static Class731 smethod_5(string string_0, float float_2, Vector2 vector2_0, Color color_0, Enum73 enum73_0, bool bool_0, bool bool_1, Enum72 enum72_0, bool bool_2, ref Vector2 vector2_1, ref RectangleF[] rectangleF_0, Color color_1, Color color_2, int int_0, bool bool_3, bool bool_4, string string_1, Vector4 vector4_0, Vector2 vector2_2, Class731 class731_0, int int_1, int int_2)
		{
			Class731 result;
			lock (Class747.object_0)
			{
				rectangleF_0 = null;
				try
				{
					using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
					{
						using (StringFormat stringFormat = new StringFormat())
						{
							if (Class747.float_0 == 0f)
							{
								Class747.float_0 = 96f / graphics.DpiX;
							}
							float_2 *= Class747.float_0;
							if (string_0 == null)
							{
								vector2_1 = Vector2.get_Zero();
								result = null;
							}
							else
							{
								graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
								if (string_1.StartsWith("Aller"))
								{
									string text = Class747.smethod_9(string_0);
									if (text != null)
									{
										string_1 = text;
									}
								}
								if (int_1 == 0 && int_2 <= 0)
								{
									if (int_2 == -1)
									{
										int_2 = string_0.Length;
									}
								}
								else
								{
									string_0 = string_0.Substring(int_1, int_2);
								}
								if (float_2 < 20f && string_1.EndsWith(" Light"))
								{
									string_1 = string_1.Replace(" Light", string.Empty);
								}
								FontStyle fontStyle = FontStyle.Regular;
								if (bool_0)
								{
									if (string_1.EndsWith(" Light"))
									{
										string_1 = string_1.Replace(" Light", string.Empty);
									}
									fontStyle |= FontStyle.Bold;
								}
								if (bool_1)
								{
									fontStyle |= FontStyle.Underline;
								}
								switch (enum72_0)
								{
								case Enum72.const_0:
								case Enum72.const_1:
									stringFormat.Alignment = StringAlignment.Near;
									break;
								case Enum72.const_2:
									stringFormat.Alignment = StringAlignment.Center;
									break;
								case Enum72.const_3:
									stringFormat.Alignment = StringAlignment.Far;
									break;
								}
								if (!Class905.smethod_16() && string_1.StartsWith("Aller"))
								{
									for (char c = '0'; c <= '9'; c += '\u0001')
									{
										string_0 = string_0.Replace(c, c + '');
									}
								}
								Font font = Class747.smethod_11(string_1, float_2 * Class747.float_1, fontStyle);
								if (Class747.float_1 != 1f)
								{
									vector2_0 *= Class747.float_1;
								}
								SizeF sizeF;
								try
								{
									if (string_0.Length == 0)
									{
										string_0 = " ";
									}
									sizeF = ((vector2_0 != Vector2.get_Zero()) ? graphics.MeasureString(string_0, font, new SizeF(vector2_0.X, vector2_0.Y), stringFormat) : graphics.MeasureString(string_0, font));
								}
								catch (InvalidOperationException)
								{
									vector2_1 = Vector2.get_Zero();
									result = null;
									return result;
								}
								int num = (int)(sizeF.Width + 1f);
								int num2 = (int)(sizeF.Height + 1f);
								if (vector2_0.Y != 0f)
								{
									num2 = (int)vector2_0.Y;
								}
								if (vector2_0.X != 0f && (enum72_0 != Enum72.const_0 || color_1.get_A() > 0))
								{
									num = (int)vector2_0.X;
								}
								if (vector2_2 != Vector2.get_Zero() && vector2_0 == Vector2.get_Zero())
								{
									num += (int)(vector2_2.X * 2f);
									num2 += (int)(vector2_2.Y * 2f);
								}
								vector2_1 = new Vector2((float)num, (float)num2);
								float num3 = Math.Max(0.5f, Math.Min(1f, float_2 * Class747.float_1 / 14f));
								if (bool_4)
								{
									rectangleF_0 = new RectangleF[string_0.Length];
									int num4 = string_0.Length / 32 + 1;
									for (int i = 0; i < num4; i++)
									{
										int num5 = i * 32;
										int num6 = Math.Min(string_0.Length - num5, 32);
										CharacterRange[] array = new CharacterRange[num6];
										for (int j = 0; j < num6; j++)
										{
											array[j] = new CharacterRange(j + num5, 1);
										}
										stringFormat.SetMeasurableCharacterRanges(array);
										Region[] array2 = graphics.MeasureCharacterRanges(string_0, font, new RectangleF(vector2_2.X, vector2_2.Y, (vector2_0.X == 0f) ? float.PositiveInfinity : vector2_0.X, (vector2_0.Y == 0f) ? float.PositiveInfinity : vector2_0.Y), stringFormat);
										for (int k = 0; k < num6; k++)
										{
											Region region = array2[k];
											rectangleF_0[k + num5] = region.GetBounds(graphics);
										}
									}
								}
								int num8;
								if (bool_3)
								{
									int num7 = 0;
									num8 = 0;
									int l = 0;
									while (l < string_0.Length)
									{
										if (string_0[l++] != ' ')
										{
											break;
										}
										num7++;
									}
									int m = string_0.Length - 1;
									while (m >= l)
									{
										if (string_0[m--] != ' ')
										{
											break;
										}
										num8++;
									}
									if (num7 == string_0.Length)
									{
										num8 += num7;
									}
								}
								else
								{
									using (Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb))
									{
										using (Graphics graphics2 = Graphics.FromImage(bitmap))
										{
											graphics2.TextRenderingHint = graphics.TextRenderingHint;
											graphics2.SmoothingMode = SmoothingMode.HighQuality;
											graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
											if (color_1.get_A() > 0)
											{
												if (vector4_0 != Vector4.get_Zero())
												{
													Class747.smethod_6(graphics2, new Rectangle(0, 0, num, num2), new SolidBrush(Class778.smethod_6(color_1)), vector4_0);
													if (int_0 > 0)
													{
														Class747.smethod_7(graphics2, new Rectangle(0, 0, num - (int)Math.Ceiling((double)((float)int_0 / 2f)), num2 - (int)Math.Ceiling((double)((float)int_0 / 2f))), new Pen(Class778.smethod_6(color_2), (float)int_0), vector4_0);
													}
												}
												else
												{
													graphics2.Clear(Class778.smethod_6(color_1));
													if (int_0 > 0)
													{
														graphics2.DrawRectangle(new Pen(Class778.smethod_6(color_2), (float)int_0), new Rectangle(int_0 / 2, int_0 / 2, num - int_0, num2 - int_0));
													}
												}
											}
											else
											{
												graphics2.Clear(Color.FromArgb(1, (int)color_0.get_R(), (int)color_0.get_G(), (int)color_0.get_B()));
											}
											using (Brush brush = new SolidBrush(Class778.smethod_6(color_0)))
											{
												if (vector2_0 != Vector2.get_Zero())
												{
													vector2_0.X -= vector2_2.X * 2f;
													vector2_0.Y -= vector2_2.Y * 2f;
													switch (enum73_0)
													{
													case Enum73.const_1:
														graphics2.DrawString(string_0, font, Class747.brush_0, new RectangleF(vector2_2.X - num3, num3 + vector2_2.Y, vector2_0.X, vector2_0.Y), stringFormat);
														graphics2.DrawString(string_0, font, Class747.brush_0, new RectangleF(vector2_2.X + num3, num3 + vector2_2.Y, vector2_0.X, vector2_0.Y), stringFormat);
														break;
													case Enum73.const_2:
													{
														Brush brush2 = Class747.brush_1;
														if (color_1.get_A() == 0 && int_0 == 1 && color_2.get_A() > 0)
														{
															brush2 = new SolidBrush(Class778.smethod_6(color_2));
														}
														graphics2.DrawString(string_0, font, brush2, new RectangleF(vector2_2.X + num3, vector2_2.Y + num3, vector2_0.X, vector2_0.Y), stringFormat);
														graphics2.DrawString(string_0, font, brush2, new RectangleF(vector2_2.X + num3, vector2_2.Y - num3, vector2_0.X, vector2_0.Y), stringFormat);
														graphics2.DrawString(string_0, font, brush2, new RectangleF(vector2_2.X - num3, vector2_2.Y + num3, vector2_0.X, vector2_0.Y), stringFormat);
														graphics2.DrawString(string_0, font, brush2, new RectangleF(vector2_2.X - num3, vector2_2.Y - num3, vector2_0.X, vector2_0.Y), stringFormat);
														break;
													}
													}
													graphics2.DrawString(string_0, font, brush, new RectangleF(vector2_2.X, vector2_2.Y, vector2_0.X, vector2_0.Y), stringFormat);
												}
												else
												{
													switch (enum73_0)
													{
													case Enum73.const_1:
														graphics2.DrawString(string_0, font, Class747.brush_0, vector2_2.X - num3, vector2_2.Y + num3);
														graphics2.DrawString(string_0, font, Class747.brush_0, vector2_2.X + num3, vector2_2.Y + num3);
														break;
													case Enum73.const_2:
													{
														Brush brush3 = Class747.brush_1;
														if (color_1.get_A() == 0 && int_0 == 1 && color_2.get_A() > 0)
														{
															brush3 = new SolidBrush(Class778.smethod_6(color_2));
														}
														graphics2.DrawString(string_0, font, brush3, vector2_2.X + num3, vector2_2.Y + num3);
														graphics2.DrawString(string_0, font, brush3, vector2_2.X - num3, vector2_2.Y + num3);
														graphics2.DrawString(string_0, font, brush3, vector2_2.X + num3, vector2_2.Y - num3);
														graphics2.DrawString(string_0, font, brush3, vector2_2.X - num3, vector2_2.Y - num3);
														break;
													}
													}
													graphics2.DrawString(string_0, font, brush, vector2_2.X, vector2_2.Y);
												}
											}
											BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, num, num2), ImageLockMode.ReadOnly, bitmap.PixelFormat);
											if (class731_0 != null && !class731_0.bool_2 && class731_0.method_0() == num)
											{
												if (class731_0.method_1() == num2)
												{
													class731_0.method_7(bitmapData.Scan0, num, num2, string_0);
													goto IL_936;
												}
											}
											class731_0 = Class731.smethod_7(bitmapData.Scan0, num, num2, true, string_0);
											IL_936:
											bitmap.UnlockBits(bitmapData);
											result = class731_0;
											return result;
										}
									}
								}
								vector2_1 = new Vector2((float)num + (float)num8 * 5.145f * float_2 / 12f, (float)num2);
								result = null;
							}
						}
					}
				}
				catch (Exception)
				{
					vector2_1 = Vector2.get_Zero();
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06002D59 RID: 11609
		// RVA: 0x00126E74 File Offset: 0x00125074
		private static void smethod_6(Graphics graphics_0, Rectangle rectangle_0, Brush brush_2, Vector4 vector4_0)
		{
			using (GraphicsPath graphicsPath = Class747.smethod_8(rectangle_0, vector4_0))
			{
				graphics_0.FillPath(brush_2, graphicsPath);
			}
		}

		// Token: 0x06002D5A RID: 11610
		// RVA: 0x00126EB0 File Offset: 0x001250B0
		private static void smethod_7(Graphics graphics_0, Rectangle rectangle_0, Pen pen_0, Vector4 vector4_0)
		{
			using (GraphicsPath graphicsPath = Class747.smethod_8(rectangle_0, vector4_0))
			{
				graphics_0.DrawPath(pen_0, graphicsPath);
			}
		}

		// Token: 0x06002D5B RID: 11611
		// RVA: 0x00126EEC File Offset: 0x001250EC
		private static GraphicsPath smethod_8(Rectangle rectangle_0, Vector4 vector4_0)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = (int)(vector4_0.W * 2f);
			graphicsPath.AddLine(rectangle_0.Left + num, rectangle_0.Top, rectangle_0.Right - num, rectangle_0.Top);
			if (num > 0)
			{
				graphicsPath.AddArc(Rectangle.FromLTRB(rectangle_0.Right - num, rectangle_0.Top, rectangle_0.Right, rectangle_0.Top + num), -90f, 90f);
			}
			num = (int)(vector4_0.X * 2f);
			graphicsPath.AddLine(rectangle_0.Right, rectangle_0.Top + num, rectangle_0.Right, rectangle_0.Bottom - num);
			if (num > 0)
			{
				graphicsPath.AddArc(Rectangle.FromLTRB(rectangle_0.Right - num, rectangle_0.Bottom - num, rectangle_0.Right, rectangle_0.Bottom), 0f, 90f);
			}
			num = (int)(vector4_0.Y * 2f);
			graphicsPath.AddLine(rectangle_0.Right - num, rectangle_0.Bottom, rectangle_0.Left + num, rectangle_0.Bottom);
			if (num > 0)
			{
				graphicsPath.AddArc(Rectangle.FromLTRB(rectangle_0.Left, rectangle_0.Bottom - num, rectangle_0.Left + num, rectangle_0.Bottom), 90f, 90f);
			}
			num = (int)(vector4_0.Z * 2f);
			graphicsPath.AddLine(rectangle_0.Left, rectangle_0.Bottom - num, rectangle_0.Left, rectangle_0.Top + num);
			if (num > 0)
			{
				graphicsPath.AddArc(Rectangle.FromLTRB(rectangle_0.Left, rectangle_0.Top, rectangle_0.Left + num, rectangle_0.Top + num), 180f, 90f);
			}
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06002D5C RID: 11612
		// RVA: 0x001270C0 File Offset: 0x001252C0
		private static string smethod_9(string string_0)
		{
			switch (Class747.smethod_4(string_0))
			{
			case Class747.Enum71.const_1:
				return "Meiryo";
			case Class747.Enum71.const_2:
				return "Malgun Gothic";
			case Class747.Enum71.const_3:
				return "Tahoma";
			case Class747.Enum71.const_4:
			{
				string a;
				if ((a = Class341.class605_3) != null)
				{
					if (a == "zh-CHS")
					{
						return "Microsoft Yahei";
					}
					if (a == "zh-CHT")
					{
						return "Microsoft JhengHei";
					}
					if (a == "ja")
					{
						return "Meiryo";
					}
					if (a == "ko")
					{
						return "Malgun Gothic";
					}
				}
				return "Segoe UI";
			}
			default:
				return null;
			}
		}
	}
}
