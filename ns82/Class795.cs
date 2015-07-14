using Microsoft.Xna.Framework.Input;
using ns18;
using ns6;
using ns64;
using osu.Input;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns82
{
	// Token: 0x020005D2 RID: 1490
	internal static class Class795
	{
		// Token: 0x04002784 RID: 10116
		private static Dictionary<Bindings, Keys> dictionary_0 = new Dictionary<Bindings, Keys>();

		// Token: 0x04002785 RID: 10117
		private static Dictionary<BindingTarget, Dictionary<Keys, Bindings>> dictionary_1 = new Dictionary<BindingTarget, Dictionary<Keys, Bindings>>();

		// Token: 0x04002787 RID: 10119
		public static readonly int[] int_0 = new int[]
		{
			4,
			13
		};

		// Token: 0x04002788 RID: 10120
		public static readonly Keys[] keys_0 = new Keys[]
		{
			65,
			83,
			68,
			70,
			32,
			74,
			75,
			76,
			186,
			81,
			87,
			69,
			82,
			165,
			85,
			73,
			79,
			80
		};

		// Token: 0x04002789 RID: 10121
		public static readonly Keys[] keys_1 = new Keys[]
		{
			160,
			161
		};

		// Token: 0x0400278A RID: 10122
		public static readonly Keys[] keys_2 = new Keys[]
		{
			162,
			163
		};

		// Token: 0x04002786 RID: 10118
		public static string[] string_0 = new string[]
		{
			"None",
			"_osu! Standard Mode",
			"Left Click",
			"Right Click",
			"Smoke",
			"_Taiko Mode",
			"Drum Centre (Left)",
			"Drum Centre (Right)",
			"Drum Rim (Left)",
			"Drum Rim (Right)",
			"_Catch the Beat Mode",
			"Move Left",
			"Move Right",
			"Dash! (2x movement speed)",
			"_osu! Mania Mode",
			"Increase Speed",
			"Decrease Speed",
			"_In-Game",
			"Game Pause",
			"Skip Cutscene",
			"Toggle Scoreboard",
			"Increase Local Song Offset",
			"Decrease Local Song Offset",
			"Quick Retry (hold briefly)",
			"_Universal",
			"Toggle Framerate Limit",
			"Toggle Chat",
			"Toggle Extended Chat",
			"Save Screenshot",
			"Increase Volume",
			"Decrease Volume",
			"Disable mouse buttons",
			"Boss key",
			"_Editor",
			"Select Tool",
			"Normal Tool",
			"Slider Tool",
			"Spinner Tool",
			"New Combo Toggle",
			"Whistle Toggle",
			"Finish Toggle",
			"Clap Toggle",
			"Grid Snap Toggle",
			"Distance Snap Toggle",
			"Note Lock Toggle",
			"Nudge Left",
			"Nudge Right",
			"Help Toggle",
			"Jump To First Note",
			"Play From Beginning",
			"Audio Pause",
			"Jump To End",
			"Grid Size Change",
			"Add Timing Section",
			"Add Inheriting Section",
			"Remove Section",
			"_Mod Select",
			"Easy",
			"No Fail",
			"Half Time",
			"Hard Rock",
			"Sudden Death",
			"Double Time",
			"Hidden",
			"Flashlight",
			"Relax",
			"Autopilot",
			"Spun Out",
			"Auto"
		};

		// Token: 0x06002F12 RID: 12050
		// RVA: 0x00131864 File Offset: 0x0012FA64
		public static void Initialize(bool bool_0)
		{
			Class795.dictionary_0 = new Dictionary<Bindings, Keys>();
			Class795.dictionary_1 = new Dictionary<BindingTarget, Dictionary<Keys, Bindings>>();
			foreach (BindingTarget key in Enum.GetValues(typeof(BindingTarget)))
			{
				Class795.dictionary_1[key] = new Dictionary<Keys, Bindings>();
			}
			Class795.smethod_2(Bindings.OsuLeft, 90);
			Class795.smethod_2(Bindings.OsuRight, 88);
			Class795.smethod_2(Bindings.OsuSmoke, 67);
			Class795.smethod_2(Bindings.FruitsDash, 160);
			Class795.smethod_2(Bindings.FruitsLeft, 37);
			Class795.smethod_2(Bindings.FruitsRight, 39);
			Class795.smethod_2(Bindings.TaikoInnerLeft, 88);
			Class795.smethod_2(Bindings.TaikoInnerRight, 67);
			Class795.smethod_2(Bindings.TaikoOuterLeft, 90);
			Class795.smethod_2(Bindings.TaikoOuterRight, 86);
			Class795.smethod_2(Bindings.Pause, 27);
			Class795.smethod_2(Bindings.Skip, 32);
			Class795.smethod_2(Bindings.ToggleScoreboard, 9);
			Class795.smethod_2(Bindings.ToggleChat, 119);
			Class795.smethod_2(Bindings.ToggleExtendedChat, 120);
			Class795.smethod_2(Bindings.Screenshot, 123);
			Class795.smethod_2(Bindings.IncreaseAudioOffset, 187);
			Class795.smethod_2(Bindings.DecreaseAudioOffset, 189);
			Class795.smethod_2(Bindings.QuickRetry, 192);
			Class795.smethod_2(Bindings.IncreaseSpeed, 115);
			Class795.smethod_2(Bindings.DecreaseSpeed, 114);
			Class795.smethod_2(Bindings.ToggleFrameLimiter, 118);
			Class795.smethod_2(Bindings.VolumeIncrease, 38);
			Class795.smethod_2(Bindings.VolumeDecrease, 40);
			Class795.smethod_2(Bindings.DisableMouseButtons, 121);
			Class795.smethod_2(Bindings.BossKey, 45);
			Class795.smethod_2(Bindings.SelectTool, 49);
			Class795.smethod_2(Bindings.NormalTool, 50);
			Class795.smethod_2(Bindings.SliderTool, 51);
			Class795.smethod_2(Bindings.SpinnerTool, 52);
			Class795.smethod_2(Bindings.NewComboToggle, 81);
			Class795.smethod_2(Bindings.WhistleToggle, 87);
			Class795.smethod_2(Bindings.FinishToggle, 69);
			Class795.smethod_2(Bindings.ClapToggle, 82);
			Class795.smethod_2(Bindings.GridSnapToggle, 84);
			Class795.smethod_2(Bindings.DistSnapToggle, 89);
			Class795.smethod_2(Bindings.NoteLockToggle, 76);
			Class795.smethod_2(Bindings.NudgeLeft, 74);
			Class795.smethod_2(Bindings.NudgeRight, 75);
			Class795.smethod_2(Bindings.HelpToggle, 72);
			Class795.smethod_2(Bindings.JumpToBegin, 90);
			Class795.smethod_2(Bindings.PlayFromBegin, 88);
			Class795.smethod_2(Bindings.AudioPause, 67);
			Class795.smethod_2(Bindings.JumpToEnd, 86);
			Class795.smethod_2(Bindings.GridChange, 71);
			Class795.smethod_2(Bindings.TimingSection, 0);
			Class795.smethod_2(Bindings.InheritingSection, 0);
			Class795.smethod_2(Bindings.RemoveSection, 0);
			Class795.smethod_2(Bindings.Easy, 81);
			Class795.smethod_2(Bindings.NoFail, 87);
			Class795.smethod_2(Bindings.HalfTime, 69);
			Class795.smethod_2(Bindings.HardRock, 65);
			Class795.smethod_2(Bindings.SuddenDeath, 83);
			Class795.smethod_2(Bindings.DoubleTime, 68);
			Class795.smethod_2(Bindings.Hidden, 70);
			Class795.smethod_2(Bindings.Flashlight, 71);
			Class795.smethod_2(Bindings.Relax, 90);
			Class795.smethod_2(Bindings.Autopilot, 88);
			Class795.smethod_2(Bindings.SpunOut, 67);
			Class795.smethod_2(Bindings.Auto, 86);
			if (!bool_0)
			{
				string[] names = Enum.GetNames(typeof(Bindings));
				for (int i = 1; i < names.Length; i++)
				{
					string text = names[i];
					if (text[0] != '_')
					{
						try
						{
							object obj;
							if (Class341.dictionary_0.TryGetValue("key" + text, out obj))
							{
								Class795.Set((Bindings)i, (Keys)Enum.Parse(typeof(Keys), obj.ToString(), true));
							}
						}
						catch
						{
						}
					}
				}
				Class795.smethod_7();
				Class575.Initialize();
			}
		}

		// Token: 0x06002F08 RID: 12040
		// RVA: 0x000233A3 File Offset: 0x000215A3
		public static void Set(Bindings bindings_0, Keys keys_3)
		{
			Class795.smethod_2(bindings_0, keys_3);
			Class795.smethod_7();
		}

		// Token: 0x06002F09 RID: 12041
		// RVA: 0x00131434 File Offset: 0x0012F634
		private static BindingTarget smethod_0(Bindings bindings_0)
		{
			int num = (int)bindings_0;
			while (num-- > 1)
			{
				string text = ((Bindings)num).ToString();
				if (text[0] == '_')
				{
					for (int i = 2; i > 0; i--)
					{
						if (text.Substring(1) == ((BindingTarget)i).ToString())
						{
							return (BindingTarget)i;
						}
					}
				}
			}
			return BindingTarget.Universal;
		}

		// Token: 0x06002F0A RID: 12042
		// RVA: 0x000233B1 File Offset: 0x000215B1
		private static Dictionary<Keys, Bindings> smethod_1(BindingTarget bindingTarget_0)
		{
			return Class795.dictionary_1[bindingTarget_0];
		}

		// Token: 0x06002F14 RID: 12052
		// RVA: 0x000233CB File Offset: 0x000215CB
		public static Bindings smethod_10(Keys keys_3)
		{
			return Class795.smethod_4(keys_3, BindingTarget.Universal);
		}

		// Token: 0x06002F15 RID: 12053
		// RVA: 0x000233D4 File Offset: 0x000215D4
		public static bool smethod_11(Keys keys_3, Bindings bindings_0)
		{
			return Class795.smethod_3(bindings_0) == keys_3;
		}

		// Token: 0x06002F16 RID: 12054
		// RVA: 0x00131C14 File Offset: 0x0012FE14
		internal static bool smethod_12(Keys keys_3, PlayModes playModes_0)
		{
			switch (playModes_0)
			{
			case PlayModes.Osu:
				if (keys_3 == Class795.smethod_3(Bindings.OsuLeft))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.OsuRight))
				{
					return true;
				}
				break;
			case PlayModes.Taiko:
				if (keys_3 == Class795.smethod_3(Bindings.TaikoInnerLeft))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.TaikoInnerRight))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.TaikoOuterLeft))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.TaikoOuterRight))
				{
					return true;
				}
				break;
			case PlayModes.CatchTheBeat:
				if (keys_3 == Class795.smethod_3(Bindings.FruitsLeft))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.FruitsRight))
				{
					return true;
				}
				if (keys_3 == Class795.smethod_3(Bindings.FruitsDash))
				{
					return true;
				}
				break;
			}
			return false;
		}

		// Token: 0x06002F0B RID: 12043
		// RVA: 0x0013148C File Offset: 0x0012F68C
		private static void smethod_2(Bindings bindings_0, Keys keys_3)
		{
			BindingTarget bindingTarget_ = Class795.smethod_0(bindings_0);
			Dictionary<Keys, Bindings> dictionary = Class795.smethod_1(bindingTarget_);
			Keys keys;
			if (Class795.dictionary_0.TryGetValue(bindings_0, out keys) && keys_3 == keys)
			{
				return;
			}
			if (Class795.dictionary_0.TryGetValue(bindings_0, out keys) && keys != null)
			{
				bool flag = false;
				foreach (KeyValuePair<Bindings, Keys> current in Class795.dictionary_0)
				{
					if (current.Key != bindings_0 && current.Value == keys)
					{
						dictionary[keys] = current.Key;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					dictionary.Remove(keys);
				}
			}
			Class795.dictionary_0[bindings_0] = keys_3;
			dictionary[keys_3] = bindings_0;
			Class111.string_4 = null;
		}

		// Token: 0x06002F0C RID: 12044
		// RVA: 0x000233BE File Offset: 0x000215BE
		public static Keys smethod_3(Bindings bindings_0)
		{
			return Class795.dictionary_0[bindings_0];
		}

		// Token: 0x06002F0D RID: 12045
		// RVA: 0x00131560 File Offset: 0x0012F760
		public static Bindings smethod_4(Keys keys_3, BindingTarget bindingTarget_0)
		{
			if (keys_3 == null)
			{
				return Bindings.None;
			}
			Bindings result;
			if (!Class795.dictionary_1[bindingTarget_0].TryGetValue(keys_3, out result))
			{
				return Bindings.None;
			}
			return result;
		}

		// Token: 0x06002F0E RID: 12046
		// RVA: 0x0013158C File Offset: 0x0012F78C
		public static string smethod_5(Bindings bindings_0)
		{
			Keys keys_ = Class795.dictionary_0[bindings_0];
			return Class795.smethod_6(keys_);
		}

		// Token: 0x06002F0F RID: 12047
		// RVA: 0x001315AC File Offset: 0x0012F7AC
		public static string smethod_6(Keys keys_3)
		{
			string text = keys_3.ToString().Replace("Oem", "");
			if (text.Length == 2 && text[0] == 'D')
			{
				text = text.Substring(1);
			}
			if (keys_3 <= 254)
			{
				if (keys_3 <= 165)
				{
					if (keys_3 != 32)
					{
						switch (keys_3)
						{
						case 160:
							text = "LSft";
							break;
						case 161:
							text = "RSft";
							break;
						case 162:
							text = "LCon";
							break;
						case 163:
							text = "RCon";
							break;
						case 164:
							text = "LAlt";
							break;
						case 165:
							text = "RAlt";
							break;
						}
					}
					else
					{
						text = "Spc";
					}
				}
				else
				{
					switch (keys_3)
					{
					case 186:
						text = ";";
						break;
					case 187:
					case 189:
						break;
					case 188:
						text = ",";
						break;
					case 190:
						text = ".";
						break;
					case 191:
						text = "/";
						break;
					default:
						switch (keys_3)
						{
						case 219:
							text = "[";
							break;
						case 220:
							text = "\\";
							break;
						case 221:
							text = "]";
							break;
						case 222:
							text = "'";
							break;
						}
						break;
					}
				}
				return text;
			}
			switch (keys_3)
			{
			case 340:
				return "Left";
			case 341:
				return "Right";
			case 342:
				return "Up";
			case 343:
				return "Down";
			default:
				return "Btn" + (keys_3 - 300).ToString();
			}
		}

		// Token: 0x06002F10 RID: 12048
		// RVA: 0x00131750 File Offset: 0x0012F950
		public static void smethod_7()
		{
			List<Keys> list = new List<Keys>();
			list.Add(Class795.smethod_3(Bindings.TaikoInnerLeft));
			if (list.Contains(Class795.smethod_3(Bindings.TaikoInnerRight)))
			{
				Class795.smethod_2(Bindings.TaikoInnerRight, 0);
			}
			else
			{
				list.Add(Class795.smethod_3(Bindings.TaikoInnerRight));
			}
			if (list.Contains(Class795.smethod_3(Bindings.TaikoOuterLeft)))
			{
				Class795.smethod_2(Bindings.TaikoOuterLeft, 0);
			}
			else
			{
				list.Add(Class795.smethod_3(Bindings.TaikoOuterLeft));
			}
			if (list.Contains(Class795.smethod_3(Bindings.TaikoOuterRight)))
			{
				Class795.smethod_2(Bindings.TaikoOuterRight, 0);
				return;
			}
			list.Add(Class795.smethod_3(Bindings.TaikoOuterRight));
		}

		// Token: 0x06002F11 RID: 12049
		// RVA: 0x001317DC File Offset: 0x0012F9DC
		public static Keys smethod_8(Enum77 enum77_0)
		{
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
				if (enum77_0 != Enum77.const_0)
				{
					if (enum77_0 != Enum77.const_1)
					{
						return Class795.dictionary_0[Bindings.OsuRight];
					}
				}
				return Class795.dictionary_0[Bindings.OsuLeft];
			case PlayModes.Taiko:
				if (enum77_0 == Enum77.const_0)
				{
					return Class795.dictionary_0[Bindings.TaikoInnerLeft];
				}
				if (enum77_0 == Enum77.const_1)
				{
					return Class795.dictionary_0[Bindings.TaikoInnerRight];
				}
				if (enum77_0 == Enum77.const_2)
				{
					return Class795.dictionary_0[Bindings.TaikoOuterLeft];
				}
				if (enum77_0 == Enum77.const_3)
				{
					return Class795.dictionary_0[Bindings.TaikoOuterRight];
				}
				break;
			}
			return 0;
		}

		// Token: 0x06002F13 RID: 12051
		// RVA: 0x00131B90 File Offset: 0x0012FD90
		public static void smethod_9()
		{
			foreach (KeyValuePair<Bindings, Keys> current in Class795.dictionary_0)
			{
				Class341.dictionary_0["key" + current.Key] = current.Value.ToString();
			}
			Class575.smethod_0();
		}
	}
}
