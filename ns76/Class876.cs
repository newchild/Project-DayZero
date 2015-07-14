using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns24;
using ns29;
using ns69;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns76
{
	// Token: 0x02000678 RID: 1656
	internal static class Class876
	{
		// Token: 0x0200067B RID: 1659
		[CompilerGenerated]
		private sealed class Class877
		{
			// Token: 0x0400302A RID: 12330
			public bool bool_0;

			// Token: 0x04003029 RID: 12329
			public string string_0;

			// Token: 0x060033C0 RID: 13248
			// RVA: 0x000261B3 File Offset: 0x000243B3
			public void method_0(string string_1, string string_2)
			{
				this.string_0 = this.string_0 + (this.bool_0 ? string_1 : (string_2 ?? string_1)) + ',';
			}
		}

		// Token: 0x02000679 RID: 1657
		// Token: 0x060033B8 RID: 13240
		internal delegate void Delegate53(object object_0, Mods mods_0);

		// Token: 0x0200067A RID: 1658
		// Token: 0x060033BC RID: 13244
		private delegate void Delegate54(string string_0, string string_1);

		// Token: 0x04003027 RID: 12327
		internal static Class623<Mods> class623_0 = Mods.None;

		// Token: 0x04003028 RID: 12328
		private static Class876.Delegate53 delegate53_0;

		// Token: 0x060033AC RID: 13228
		// RVA: 0x0002616B File Offset: 0x0002436B
		internal static void Reset()
		{
			Class876.class623_0 = Mods.None;
		}

		// Token: 0x060033A8 RID: 13224
		// RVA: 0x0016168C File Offset: 0x0015F88C
		internal static void smethod_0(Class876.Delegate53 delegate53_1)
		{
			Class876.Delegate53 delegate = Class876.delegate53_0;
			Class876.Delegate53 delegate2;
			do
			{
				delegate2 = delegate;
				Class876.Delegate53 value = (Class876.Delegate53)Delegate.Combine(delegate2, delegate53_1);
				delegate = Interlocked.CompareExchange<Class876.Delegate53>(ref Class876.delegate53_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060033A9 RID: 13225
		// RVA: 0x001616C0 File Offset: 0x0015F8C0
		internal static void smethod_1(Class876.Delegate53 delegate53_1)
		{
			Class876.Delegate53 delegate = Class876.delegate53_0;
			Class876.Delegate53 delegate2;
			do
			{
				delegate2 = delegate;
				Class876.Delegate53 value = (Class876.Delegate53)Delegate.Remove(delegate2, delegate53_1);
				delegate = Interlocked.CompareExchange<Class876.Delegate53>(ref Class876.delegate53_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060033B3 RID: 13235
		// RVA: 0x0002619B File Offset: 0x0002439B
		internal static string smethod_10(Mods mods_0, bool bool_0)
		{
			return Class876.smethod_9(mods_0, false, bool_0, false, false);
		}

		// Token: 0x060033B4 RID: 13236
		// RVA: 0x000261A7 File Offset: 0x000243A7
		internal static string smethod_11(Mods mods_0, bool bool_0, bool bool_1)
		{
			return Class876.smethod_9(mods_0, true, false, bool_0, bool_1);
		}

		// Token: 0x060033B5 RID: 13237
		// RVA: 0x00162450 File Offset: 0x00160650
		internal static List<Class531> smethod_12(Mods mods_0, Vector2 vector2_0, float float_0, string string_0)
		{
			List<Class531> list = new List<Class531>();
			int num = 0;
			float num2 = 0f;
			foreach (Mods mods in Enum.GetValues(typeof(Mods)))
			{
				if (Class876.smethod_6(mods_0, mods) && (mods != Mods.DoubleTime || !Class876.smethod_6(mods_0, Mods.Nightcore)) && (mods != Mods.SuddenDeath || !Class876.smethod_6(mods_0, Mods.Perfect)))
				{
					list.Add(new Class531(Class885.Load("selection-mod-" + mods.ToString().ToLower(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_0, 0.975f + num2, true, Color.get_TransparentWhite(), null)
					{
						object_0 = string_0,
						class26_0 = 
						{
							new Class746(TransformationType.Scale, 2f * float_0, 1f * float_0, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0)
							{
								enum70_0 = Enum70.const_1
							},
							new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0)
							{
								enum70_0 = Enum70.const_1
							}
						}
					});
					num += 200;
					num2 += 1E-05f;
					vector2_0.X += 20f * float_0;
				}
			}
			return list;
		}

		// Token: 0x060033AA RID: 13226
		// RVA: 0x0002614D File Offset: 0x0002434D
		internal static void smethod_2()
		{
			if (Class876.delegate53_0 != null)
			{
				Class876.delegate53_0(null, Class876.class623_0);
			}
		}

		// Token: 0x060033AB RID: 13227
		// RVA: 0x001616F4 File Offset: 0x0015F8F4
		public static bool smethod_3(Mods mods_0)
		{
			if (Class62.Mode == PlayModes.OsuMania)
			{
				if (Class876.smethod_6(Mods.HardRock | Mods.Random, mods_0))
				{
					return false;
				}
				if (Class876.smethod_6(Mods.KeyCoop, mods_0))
				{
					return false;
				}
				if (Class466.Current.method_5() == PlayModes.Osu)
				{
					int num = Class421.smethod_3(Class466.Current, mods_0);
					if (num < 4 || num > 8)
					{
						return false;
					}
				}
			}
			return !Class876.smethod_6(Mods.Autoplay, mods_0) && !Class876.smethod_6(Mods.Target, mods_0);
		}

		// Token: 0x060033AD RID: 13229
		// RVA: 0x00161768 File Offset: 0x0015F968
		internal static void smethod_4(Mods mods_0)
		{
			switch (Class62.Mode)
			{
			case PlayModes.Taiko:
				Class876.class623_0 &= ~(Mods.SpunOut | Mods.Relax2 | Mods.Target);
				break;
			case PlayModes.CatchTheBeat:
				Class876.class623_0 &= ~(Mods.SpunOut | Mods.Relax2 | Mods.Target);
				break;
			case PlayModes.OsuMania:
				Class876.class623_0 &= ~(Mods.Relax | Mods.SpunOut | Mods.Relax2 | Mods.Target);
				break;
			}
			bool flag;
			if (!(flag = (Class62.Mode == PlayModes.OsuMania)))
			{
				Class876.class623_0 &= ~(Mods.Key4 | Mods.Key5 | Mods.Key6 | Mods.Key7 | Mods.Key8 | Mods.FadeIn | Mods.Random | Mods.Key9 | Mods.KeyCoop | Mods.Key1 | Mods.Key3 | Mods.Key2);
			}
			for (Mods mods = (mods_0 != Mods.None) ? mods_0 : Mods.NoFail; mods < ((mods_0 == Mods.None) ? Mods.LastMod : (mods_0 << 1)); mods *= Mods.Easy)
			{
				Mods mods2 = Class876.class623_0 & mods;
				if (mods2 != Mods.None)
				{
					Mods mods3 = mods2;
					if (mods3 <= Mods.HalfTime)
					{
						if (mods3 <= Mods.HardRock)
						{
							switch (mods3)
							{
							case Mods.NoFail:
								Class876.class623_0 &= ~Mods.SuddenDeath;
								Class876.class623_0 &= ~Mods.Perfect;
								Class876.class623_0 &= ~Mods.Relax2;
								Class876.class623_0 &= ~Mods.Relax;
								break;
							case Mods.Easy:
								Class876.class623_0 &= ~Mods.HardRock;
								break;
							default:
								if (mods3 != Mods.Hidden)
								{
									if (mods3 == Mods.HardRock)
									{
										Class876.class623_0 &= ~Mods.Easy;
									}
								}
								else if (flag)
								{
									Class876.class623_0 &= ~Mods.Flashlight;
									Class876.class623_0 &= ~Mods.FadeIn;
								}
								break;
							}
						}
						else if (mods3 <= Mods.DoubleTime)
						{
							if (mods3 != Mods.SuddenDeath)
							{
								if (mods3 == Mods.DoubleTime)
								{
									Class876.class623_0 &= ~Mods.HalfTime;
								}
							}
							else
							{
								Class876.class623_0 &= ~Mods.NoFail;
								Class876.class623_0 &= ~Mods.Relax2;
								Class876.class623_0 &= ~Mods.Relax;
							}
						}
						else if (mods3 != Mods.Relax)
						{
							if (mods3 == Mods.HalfTime)
							{
								Class876.class623_0 &= ~Mods.DoubleTime;
								Class876.class623_0 &= ~Mods.Nightcore;
							}
						}
						else
						{
							Class876.class623_0 &= ~Mods.Relax2;
							Class876.class623_0 &= ~Mods.NoFail;
							Class876.class623_0 &= ~Mods.SuddenDeath;
							Class876.class623_0 &= ~Mods.Perfect;
						}
					}
					else if (mods3 <= Mods.SpunOut)
					{
						if (mods3 != Mods.Nightcore)
						{
							if (mods3 != Mods.Flashlight)
							{
								if (mods3 == Mods.SpunOut)
								{
									Class876.class623_0 &= ~Mods.Relax2;
								}
							}
							else if (flag)
							{
								Class876.class623_0 &= ~Mods.Hidden;
								Class876.class623_0 &= ~Mods.FadeIn;
							}
						}
						else
						{
							Class876.class623_0 |= Mods.DoubleTime;
						}
					}
					else if (mods3 <= Mods.Perfect)
					{
						if (mods3 != Mods.Relax2)
						{
							if (mods3 == Mods.Perfect)
							{
								Class876.class623_0 |= Mods.SuddenDeath;
							}
						}
						else
						{
							Class876.class623_0 &= ~Mods.SpunOut;
							Class876.class623_0 &= ~Mods.Relax;
							Class876.class623_0 &= ~Mods.NoFail;
							Class876.class623_0 &= ~Mods.SuddenDeath;
							Class876.class623_0 &= ~Mods.Perfect;
						}
					}
					else if (mods3 != Mods.FadeIn)
					{
						if (mods3 == Mods.Cinema)
						{
							Class876.class623_0 |= Mods.Autoplay;
						}
					}
					else
					{
						Class876.class623_0 &= ~Mods.Hidden;
						Class876.class623_0 &= ~Mods.Flashlight;
					}
				}
			}
			if ((Class876.class623_0 & Mods.Autoplay) > Mods.None)
			{
				Class876.class623_0 &= ~Mods.SpunOut;
				Class876.class623_0 &= ~Mods.Relax;
				Class876.class623_0 &= ~Mods.Relax2;
				Class876.class623_0 &= ~Mods.SuddenDeath;
				Class876.class623_0 &= ~Mods.Perfect;
			}
		}

		// Token: 0x060033AE RID: 13230
		// RVA: 0x00026178 File Offset: 0x00024378
		internal static bool smethod_5(Mods mods_0)
		{
			return Class876.smethod_6(Class876.class623_0, mods_0);
		}

		// Token: 0x060033AF RID: 13231
		// RVA: 0x00014837 File Offset: 0x00012A37
		internal static bool smethod_6(Mods mods_0, Mods mods_1)
		{
			return (mods_0 & mods_1) > Mods.None;
		}

		// Token: 0x060033B0 RID: 13232
		// RVA: 0x0002618A File Offset: 0x0002438A
		internal static double smethod_7()
		{
			return Class876.smethod_8(Class876.class623_0);
		}

		// Token: 0x060033B1 RID: 13233
		// RVA: 0x00161CF0 File Offset: 0x0015FEF0
		internal static double smethod_8(Mods mods_0)
		{
			double num = 1.0;
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
			case PlayModes.Taiko:
				if (Class876.smethod_6(mods_0, Mods.NoFail))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.Easy))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.HalfTime))
				{
					num *= 0.3;
				}
				if (Class876.smethod_6(mods_0, Mods.Hidden))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.HardRock))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.DoubleTime))
				{
					num *= 1.12;
				}
				if (Class876.smethod_6(mods_0, Mods.Flashlight))
				{
					num *= 1.12;
				}
				if (Class876.smethod_6(mods_0, Mods.SpunOut))
				{
					num *= 0.9;
				}
				if (Class876.smethod_6(mods_0, Mods.Relax) || Class876.smethod_6(mods_0, Mods.Relax2))
				{
					num *= 0.0;
				}
				break;
			case PlayModes.CatchTheBeat:
				if (Class876.smethod_6(mods_0, Mods.NoFail))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.Easy))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.HalfTime))
				{
					num *= 0.3;
				}
				if (Class876.smethod_6(mods_0, Mods.Hidden))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.HardRock))
				{
					num *= 1.12;
				}
				if (Class876.smethod_6(mods_0, Mods.DoubleTime))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.Flashlight))
				{
					num *= 1.12;
				}
				if (Class876.smethod_6(mods_0, Mods.SpunOut))
				{
					num *= 0.9;
				}
				if (Class876.smethod_6(mods_0, Mods.Relax) || Class876.smethod_6(mods_0, Mods.Relax2))
				{
					num *= 0.0;
				}
				break;
			case PlayModes.OsuMania:
				if (Class876.smethod_6(mods_0, Mods.NoFail))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.Easy))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.HalfTime))
				{
					num *= 0.5;
				}
				if (Class876.smethod_6(mods_0, Mods.Hidden) || Class876.smethod_6(mods_0, Mods.FadeIn))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.HardRock))
				{
					num *= 1.08;
				}
				if (Class876.smethod_6(mods_0, Mods.DoubleTime))
				{
					num *= 1.1;
				}
				if (Class876.smethod_6(mods_0, Mods.Flashlight))
				{
					num *= 1.06;
				}
				if (Class876.smethod_6(mods_0, Mods.SpunOut))
				{
					num *= 0.0;
				}
				if (Class876.smethod_6(mods_0, Mods.Relax))
				{
					num *= 0.0;
				}
				if (Class876.smethod_6(mods_0, Mods.Relax2))
				{
					num *= 0.0;
				}
				if (Class876.smethod_6(mods_0, Mods.Random))
				{
					num *= 1.0;
				}
				if (Class466.Current != null)
				{
					int num2 = Class421.smethod_1(Class466.Current);
					int num3 = Class421.smethod_2(Class466.Current);
					if (num3 > num2)
					{
						num *= 0.9;
					}
					else if (num3 < num2)
					{
						num *= 0.9 - 0.04 * (double)(num2 - num3);
					}
				}
				break;
			}
			return Math.Max(0.0, num);
		}

		// Token: 0x060033B2 RID: 13234
		// RVA: 0x0016205C File Offset: 0x0016025C
		private static string smethod_9(Mods mods_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			Class876.Class877 class = new Class876.Class877();
			class.bool_0 = bool_0;
			if (mods_0 == Mods.None)
			{
				if (!bool_1)
				{
					return string.Empty;
				}
				return "None";
			}
			else
			{
				class.string_0 = string.Empty;
				Class876.Delegate54 delegate = new Class876.Delegate54(class.method_0);
				PlayModes playModes = (Class466.Current != null) ? Class466.Current.method_5() : PlayModes.Osu;
				if (Class876.smethod_6(Mods.Cinema, mods_0))
				{
					delegate("Cinema", null);
				}
				else if (Class876.smethod_6(Mods.Autoplay, mods_0))
				{
					delegate("Auto", null);
				}
				if (playModes == PlayModes.Osu && Class876.smethod_6(Mods.Target, mods_0))
				{
					delegate("TP", "TargetPractice");
				}
				if (playModes == PlayModes.Osu && Class876.smethod_6(Mods.SpunOut, mods_0))
				{
					delegate("SO", "SpunOut");
				}
				if (Class876.smethod_6(Mods.Easy, mods_0))
				{
					delegate("EZ", "Easy");
				}
				if (Class876.smethod_6(Mods.NoFail, mods_0))
				{
					delegate("NF", "NoFail");
				}
				if (Class876.smethod_6(Mods.Hidden, mods_0))
				{
					delegate("HD", "Hidden");
				}
				else if ((playModes == PlayModes.Osu || playModes == PlayModes.OsuMania) && Class876.smethod_6(Mods.FadeIn, mods_0))
				{
					delegate("FI", "FadeIn");
				}
				if (Class876.smethod_6(Mods.Nightcore, mods_0))
				{
					delegate("NC", "Nightcore");
				}
				else if (Class876.smethod_6(Mods.DoubleTime, mods_0))
				{
					delegate("DT", "DoubleTime");
				}
				if (Class876.smethod_6(Mods.HalfTime, mods_0))
				{
					delegate("HT", "HalfTime");
				}
				if (Class876.smethod_6(Mods.HardRock, mods_0))
				{
					delegate("HR", "HardRock");
				}
				if (playModes != PlayModes.OsuMania && Class876.smethod_6(Mods.Relax, mods_0))
				{
					delegate("Relax", null);
				}
				if (playModes == PlayModes.Osu && Class876.smethod_6(Mods.Relax2, mods_0))
				{
					delegate("AP", "AutoPilot");
				}
				if (Class876.smethod_6(Mods.Perfect, mods_0))
				{
					delegate("PF", "Perfect");
				}
				else if (Class876.smethod_6(Mods.SuddenDeath, mods_0))
				{
					delegate("SD", "SuddenDeath");
				}
				if (Class876.smethod_6(Mods.Flashlight, mods_0))
				{
					delegate("FL", "Flashlight");
				}
				if (playModes == PlayModes.Osu)
				{
					if (Class876.smethod_6(Mods.Key1, mods_0))
					{
						delegate("1K", null);
					}
					else if (Class876.smethod_6(Mods.Key2, mods_0))
					{
						delegate("2K", null);
					}
					else if (Class876.smethod_6(Mods.Key3, mods_0))
					{
						delegate("3K", null);
					}
					else if (Class876.smethod_6(Mods.Key4, mods_0))
					{
						delegate("4K", null);
					}
					else if (Class876.smethod_6(Mods.Key5, mods_0))
					{
						delegate("5K", null);
					}
					else if (Class876.smethod_6(Mods.Key6, mods_0))
					{
						delegate("6K", null);
					}
					else if (Class876.smethod_6(Mods.Key7, mods_0))
					{
						delegate("7K", null);
					}
					else if (Class876.smethod_6(Mods.Key8, mods_0))
					{
						delegate("8K", null);
					}
					else if (Class876.smethod_6(Mods.Key9, mods_0))
					{
						delegate("9K", null);
					}
				}
				if (playModes == PlayModes.Osu || playModes == PlayModes.OsuMania)
				{
					if (Class876.smethod_6(Mods.KeyCoop, mods_0))
					{
						delegate("2P", "Co-op");
					}
					if (Class876.smethod_6(Mods.Random, mods_0))
					{
						delegate("RD", "Random");
					}
				}
				class.string_0 = class.string_0.Trim(new char[]
				{
					','
				});
				if (class.string_0.Length == 0)
				{
					return "";
				}
				if (bool_2)
				{
					class.string_0 = "(" + class.string_0 + ")";
				}
				if (bool_3)
				{
					Class876.Class877 expr_3CC = class;
					expr_3CC.string_0 += " ";
				}
				return class.string_0;
			}
		}
	}
}
