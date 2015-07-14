using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns26;
using ns29;
using ns64;
using ns80;
using ns82;
using ns90;
using osu;
using osu.Input;
using osu_common;
using System;
using System.Collections.Generic;
using WiimoteLib;

namespace ns81
{
	// Token: 0x02000615 RID: 1557
	internal static class Class808
	{
		// Token: 0x04002BED RID: 11245
		private static ButtonState buttonState_0;

		// Token: 0x04002BEE RID: 11246
		private static ButtonState buttonState_1;

		// Token: 0x04002BE8 RID: 11240
		private static int int_0;

		// Token: 0x04002BEB RID: 11243
		private static TaikoDrumState taikoDrumState_0;

		// Token: 0x04002BEC RID: 11244
		private static TaikoDrumState taikoDrumState_1;

		// Token: 0x04002BEA RID: 11242
		private static WiimoteState wiimoteState_0;

		// Token: 0x04002BE9 RID: 11241
		internal static Wiimote wiimote_0;

		// Token: 0x06003039 RID: 12345
		// RVA: 0x00137868 File Offset: 0x00135A68
		internal static bool GetState()
		{
			if (Class808.wiimote_0 == null)
			{
				return false;
			}
			Class808.wiimoteState_0 = Class808.wiimote_0.get_WiimoteState();
			if (Class808.int_0 > 0 && Class808.int_0 <= Class115.int_1)
			{
				Class808.int_0 = -1;
				Class808.wiimote_0.SetRumble(false);
			}
			return Class808.wiimoteState_0 != null;
		}

		// Token: 0x06003037 RID: 12343
		// RVA: 0x001377D4 File Offset: 0x001359D4
		internal static bool Initialize()
		{
			if (!Class341.class606_70)
			{
				return false;
			}
			bool result;
			try
			{
				Class808.wiimote_0 = new Wiimote();
				Class808.wiimote_0.Connect();
				goto IL_50;
			}
			catch
			{
				Class723.smethod_5("Could not find Wiimote.  Please check connection then reenable in options.", Color.get_Red(), 8000, null);
				Class341.class606_70.Value = false;
				Class808.smethod_1();
				result = false;
			}
			return result;
			IL_50:
			Class723.smethod_5("Found Wiimote!", Color.get_YellowGreen(), 6000, null);
			Class808.wiimote_0.SetLEDs(true, true, true, true);
			return true;
		}

		// Token: 0x06003036 RID: 12342
		// RVA: 0x00023CC2 File Offset: 0x00021EC2
		internal static bool smethod_0()
		{
			return Class808.wiimote_0 != null;
		}

		// Token: 0x06003038 RID: 12344
		// RVA: 0x00023CCF File Offset: 0x00021ECF
		internal static void smethod_1()
		{
			if (Class808.wiimote_0 != null)
			{
				Class808.wiimote_0.SetLEDs(false, false, false, false);
				Class808.wiimote_0.Disconnect();
				Class808.wiimote_0 = null;
			}
		}

		// Token: 0x0600303A RID: 12346
		// RVA: 0x00023CF6 File Offset: 0x00021EF6
		internal static void smethod_2(int int_1)
		{
			if (!Class808.smethod_0())
			{
				return;
			}
			Class808.wiimote_0.SetRumble(true);
			Class808.int_0 = Class115.int_1 + int_1;
		}

		// Token: 0x0600303B RID: 12347
		// RVA: 0x001378C0 File Offset: 0x00135AC0
		internal static void smethod_3(List<Keys> list_0)
		{
			if (!Class808.GetState())
			{
				return;
			}
			Class808.buttonState_1 = Class808.buttonState_0;
			Class808.buttonState_0 = Class808.wiimoteState_0.ButtonState;
			Class808.taikoDrumState_1 = Class808.taikoDrumState_0;
			Class808.taikoDrumState_0 = Class808.wiimoteState_0.TaikoDrumState;
			if (Class331.bool_0)
			{
				Class808.wiimote_0.SetLEDs(Class331.int_0 % 4 == 0, Class331.int_0 % 4 == 1, Class331.int_0 % 4 == 2, Class331.int_0 % 4 == 3);
			}
			bool flag = (!Class808.taikoDrumState_1.InnerLeft && Class808.taikoDrumState_0.InnerLeft) || (!Class808.buttonState_1.Down && Class808.buttonState_0.Down);
			bool flag2 = (!Class808.taikoDrumState_1.InnerRight && Class808.taikoDrumState_0.InnerRight) || (!Class808.buttonState_1.One && Class808.buttonState_0.One);
			bool flag3 = (!Class808.taikoDrumState_1.OuterLeft && Class808.taikoDrumState_0.OuterLeft) || (!Class808.buttonState_1.Up && Class808.buttonState_0.Up);
			bool flag4 = (!Class808.taikoDrumState_1.OuterRight && Class808.taikoDrumState_0.OuterRight) || (!Class808.buttonState_1.Two && Class808.buttonState_0.Two);
			if (!Class802.smethod_0())
			{
				Class802.bool_4 |= flag;
				Class802.bool_6 |= flag2;
				Class802.bool_19 |= flag3;
				Class802.bool_21 |= flag4;
				Class802.bool_3 |= (Class808.taikoDrumState_0.InnerLeft || Class808.buttonState_0.Down);
				Class802.bool_5 |= (Class808.taikoDrumState_0.InnerRight || Class808.buttonState_0.One);
				Class802.bool_18 |= (Class808.taikoDrumState_0.OuterLeft || Class808.buttonState_0.Up);
				Class802.bool_20 |= (Class808.taikoDrumState_0.OuterRight || Class808.buttonState_0.Two);
			}
			OsuModes osuModes_ = Class115.osuModes_1;
			switch (osuModes_)
			{
			case OsuModes.Menu:
				if ((flag || flag2) && Class115.enum113_0 == Enum113.const_2)
				{
					Class62.Mode = PlayModes.Taiko;
					Class115.smethod_70(OsuModes.SelectPlay, false);
					Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				}
				if (Class808.buttonState_0.A && Class115.enum113_0 == Enum113.const_2)
				{
					Class62.Mode = PlayModes.Taiko;
					Class115.smethod_70(OsuModes.SelectPlay, false);
					Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				}
				if (Class808.buttonState_0.B)
				{
					list_0.Add(27);
				}
				break;
			case OsuModes.Edit:
				break;
			case OsuModes.Play:
				if (Class808.wiimoteState_0.BalanceBoardState.CenterOfGravity.X < 0f || Class808.buttonState_0.Left)
				{
					list_0.Add(Class795.smethod_3(Bindings.FruitsLeft));
				}
				if (Class808.wiimoteState_0.BalanceBoardState.CenterOfGravity.X > 0f || Class808.buttonState_0.Right)
				{
					list_0.Add(Class795.smethod_3(Bindings.FruitsRight));
				}
				if (Class808.buttonState_0.A || Class808.buttonState_0.B)
				{
					list_0.Add(Class795.smethod_3(Bindings.FruitsDash));
				}
				break;
			default:
				if (osuModes_ == OsuModes.SelectPlay)
				{
					if (!Class808.taikoDrumState_0.InnerLeft && !Class808.taikoDrumState_0.InnerRight && !Class808.buttonState_0.Two)
					{
						if (!Class808.taikoDrumState_1.OuterLeft && !Class808.buttonState_0.Up && !Class808.buttonState_0.Right)
						{
							if (Class808.taikoDrumState_1.OuterRight || Class808.buttonState_0.Down || Class808.buttonState_0.Left)
							{
								list_0.Add(40);
							}
						}
						else
						{
							list_0.Add(38);
						}
					}
					else
					{
						list_0.Add(13);
					}
					if (Class808.buttonState_0.B || Class808.buttonState_0.One)
					{
						list_0.Add(27);
					}
				}
				break;
			}
			if (Class808.buttonState_0.Plus || (Class62.bool_11 && Class808.buttonState_0.Up) || Class808.buttonState_0.Right)
			{
				list_0.Add(38);
			}
			if (Class808.buttonState_0.Minus || (Class62.bool_11 && Class808.buttonState_0.Down) || Class808.buttonState_0.Left)
			{
				list_0.Add(40);
			}
			if (Class808.buttonState_0.Home)
			{
				list_0.Add(27);
			}
			if (Class808.buttonState_0.A)
			{
				if (Class62.bool_6 && !Class62.bool_11)
				{
					list_0.Add(27);
					return;
				}
				if (Class115.osuModes_1 == OsuModes.Play && !Class62.bool_11)
				{
					list_0.Add(Class795.smethod_3(Bindings.Skip));
					return;
				}
				list_0.Add(13);
			}
		}
	}
}
