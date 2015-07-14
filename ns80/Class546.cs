using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns29;
using ns69;
using ns77;
using ns82;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns80
{
	// Token: 0x02000459 RID: 1113
	internal sealed class Class546 : Class544
	{
		// Token: 0x04001BF2 RID: 7154
		internal bool bool_0 = true;

		// Token: 0x04001BF3 RID: 7155
		internal bool bool_1;

		// Token: 0x04001BF4 RID: 7156
		internal bool bool_2 = true;

		// Token: 0x04001BF5 RID: 7157
		internal bool bool_3;

		// Token: 0x04001BF6 RID: 7158
		private bool bool_4;

		// Token: 0x04001C0A RID: 7178
		[CompilerGenerated]
		private static Class548.Delegate36<float> delegate36_0;

		// Token: 0x04001C0B RID: 7179
		[CompilerGenerated]
		private static Class548.Delegate36<float> delegate36_1;

		// Token: 0x04001BE9 RID: 7145
		internal Dictionary<string, Keys> dictionary_1 = new Dictionary<string, Keys>();

		// Token: 0x04001C02 RID: 7170
		private Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

		// Token: 0x04001C04 RID: 7172
		private Dictionary<string, Color> dictionary_3 = new Dictionary<string, Color>();

		// Token: 0x04001C06 RID: 7174
		private Dictionary<string, bool> dictionary_4 = new Dictionary<string, bool>();

		// Token: 0x04001C08 RID: 7176
		private Dictionary<string, Enum55> dictionary_5 = new Dictionary<string, Enum55>();

		// Token: 0x04001BF0 RID: 7152
		internal Enum54 enum54_0;

		// Token: 0x04001BF1 RID: 7153
		internal float float_0 = 1.2f;

		// Token: 0x04001BF8 RID: 7160
		internal float float_1 = 136f;

		// Token: 0x04001BF9 RID: 7161
		internal float float_2 = 19f;

		// Token: 0x04001BFE RID: 7166
		internal float float_3 = 40f;

		// Token: 0x04001BFF RID: 7167
		internal float float_4;

		// Token: 0x04001BFA RID: 7162
		internal int int_0 = 402;

		// Token: 0x04001BFB RID: 7163
		internal int int_1 = 413;

		// Token: 0x04001BFC RID: 7164
		internal int int_2 = 111;

		// Token: 0x04001BFD RID: 7165
		internal int int_3 = 325;

		// Token: 0x04001C00 RID: 7168
		private int int_4;

		// Token: 0x04001C01 RID: 7169
		internal int int_5 = 60;

		// Token: 0x04001BEB RID: 7147
		internal List<float> list_0 = new List<float>();

		// Token: 0x04001BEC RID: 7148
		internal List<float> list_1 = new List<float>();

		// Token: 0x04001BED RID: 7149
		internal List<float> list_2 = new List<float>();

		// Token: 0x04001BEE RID: 7150
		internal List<float> list_3 = new List<float>();

		// Token: 0x04001BEF RID: 7151
		internal List<float> list_4 = new List<float>();

		// Token: 0x04001BF7 RID: 7159
		internal bool? nullable_0 = null;

		// Token: 0x04001C0C RID: 7180
		[CompilerGenerated]
		private static Predicate<string> predicate_0;

		// Token: 0x04001C0D RID: 7181
		[CompilerGenerated]
		private static Predicate<string> predicate_1;

		// Token: 0x04001C0E RID: 7182
		[CompilerGenerated]
		private static Predicate<string> predicate_2;

		// Token: 0x04001C0F RID: 7183
		[CompilerGenerated]
		private static Predicate<string> predicate_3;

		// Token: 0x04001BEA RID: 7146
		private static readonly Regex regex_0 = new Regex("^Key\\d+$");

		// Token: 0x04001C03 RID: 7171
		private static readonly Regex regex_1 = new Regex("(?x)\r\n            KeyImage\\d+D? |\r\n            NoteImage\\d+[HLT]? |\r\n            Stage(?:Left|Right|Bottom|Hint|Light) |\r\n            Hit(?:0|50|100|200|300|300g) |\r\n            Lighting[NL] |\r\n            WarningArrow\r\n        ");

		// Token: 0x04001C05 RID: 7173
		private static readonly Regex regex_2 = new Regex("(?x)\r\n            ^Colour(?:\r\n                \\d+ |\r\n                ColumnLine |\r\n                JudgementLine |\r\n                Barline |\r\n                Break |\r\n                Hold |\r\n                KeyWarning |\r\n                Light\\d+\r\n            )$\r\n        ");

		// Token: 0x04001C07 RID: 7175
		private static readonly Regex regex_3 = new Regex("(?x)\r\n            ^(?:\r\n                NoteFlipWhenUpsideDown\\d*[HLT]? |\r\n                KeyFlipWhenUpsideDown\\d*\r\n            )$\r\n        ");

		// Token: 0x04001C09 RID: 7177
		private static readonly Regex regex_4 = new Regex("^NoteBodyStyle\\d*$");

		// Token: 0x060023F0 RID: 9200
		// RVA: 0x000D85DC File Offset: 0x000D67DC
		internal Class546()
		{
			base.method_0("Mania");
		}

		// Token: 0x060023F4 RID: 9204
		// RVA: 0x000D8C40 File Offset: 0x000D6E40
		internal Class731 Load(string string_0, string string_1, Enum112 enum112_0)
		{
			string string_2;
			Class731 result;
			if (this.dictionary_2.TryGetValue(string_0, out string_2) && (result = Class885.Load(string_2, enum112_0)) != null)
			{
				return result;
			}
			return Class885.Load(string_1, enum112_0);
		}

		// Token: 0x060023E9 RID: 9193
		// RVA: 0x000D80C0 File Offset: 0x000D62C0
		internal void method_1()
		{
			Class548 class = this.dictionary_0["Mania"];
			float num = 0f;
			if (class.method_3<float>("ColumnLineWidth", ref num))
			{
				if (num > 0f && num < 2f)
				{
					num = 2f;
				}
				int num2 = 0;
				while (num2 <= this.method_6() && num2 < this.list_0.Count)
				{
					this.list_0[num2] = (float)Convert.ToDouble(num, Class115.numberFormatInfo_0);
					num2++;
				}
			}
			string text = null;
			if (class.method_3<string>("ColumnLine", ref text))
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				int num3 = 0;
				while (num3 < array.Length && num3 < this.list_0.Count)
				{
					this.list_0[num3] = ((array[num3] == "0") ? 0f : this.list_0[num3]);
					num3++;
				}
			}
			class.method_3<float>("BarlineWidth", ref this.float_0);
			int num4 = 0;
			if (class.method_3<int>("SpecialStyle", ref num4))
			{
				int num5 = 0;
				class.method_3<int>("SpecialPositionLeft", ref num5);
				if (num4 == 1 && num5 == 1)
				{
					this.enum54_0 = Enum54.const_1;
				}
				else if (num4 == 1)
				{
					this.enum54_0 = Enum54.const_2;
				}
				else
				{
					this.enum54_0 = Enum54.const_0;
				}
			}
			class.method_3<string>("FontCombo", ref Class885.class547_0.string_5);
			class.method_4("FontCombo");
			class.method_4("ColumnLineWidth");
			class.method_4("ColumnLine");
			class.method_4("BarlineWidth");
			class.method_4("SpecialStyle");
			class.method_4("SpecialPositionLeft");
			this.vmethod_0();
		}

		// Token: 0x060023F6 RID: 9206
		// RVA: 0x000D8CA8 File Offset: 0x000D6EA8
		internal bool method_10(string string_0, int int_6, string string_1, bool bool_5)
		{
			if (!this.bool_1)
			{
				return false;
			}
			string key = string.Format("{0}FlipWhenUpsideDown{1}", string_0, string_1);
			string_0 = string.Format("{0}FlipWhenUpsideDown{1}{2}", string_0, int_6, string_1);
			bool result;
			if (this.dictionary_4.TryGetValue(string_0, out result))
			{
				return result;
			}
			if (this.dictionary_4.TryGetValue(key, out result))
			{
				return result;
			}
			return bool_5;
		}

		// Token: 0x060023F7 RID: 9207
		// RVA: 0x0001C469 File Offset: 0x0001A669
		internal bool method_11(int int_6, string string_0, bool bool_5)
		{
			return Class885.class547_0.double_0 >= 2.5 && this.method_10("Note", int_6, string_0, bool_5);
		}

		// Token: 0x060023F8 RID: 9208
		// RVA: 0x000D8D08 File Offset: 0x000D6F08
		internal Enum55 method_12(int int_6)
		{
			if (Class885.class547_0.double_0 < 2.5)
			{
				return Enum55.const_0;
			}
			Enum55 result;
			if (this.dictionary_5.TryGetValue("NoteBodyStyle" + int_6, out result))
			{
				return result;
			}
			if (this.dictionary_5.TryGetValue("NoteBodyStyle", out result))
			{
				return result;
			}
			return Enum55.const_2;
		}

		// Token: 0x060023F9 RID: 9209
		// RVA: 0x0001C490 File Offset: 0x0001A690
		internal float method_13(int int_6)
		{
			return this.method_15(int_6, this.list_3);
		}

		// Token: 0x060023FA RID: 9210
		// RVA: 0x0001C49F File Offset: 0x0001A69F
		internal float method_14(int int_6)
		{
			return this.method_15(int_6, this.list_4);
		}

		// Token: 0x060023FB RID: 9211
		// RVA: 0x000D8D64 File Offset: 0x000D6F64
		private float method_15(int int_6, List<float> list_5)
		{
			if (Class885.class547_0.double_0 < 2.5)
			{
				return 1f;
			}
			float num = (list_5[int_6] > 0f) ? list_5[int_6] : this.list_2[int_6];
			return num / 30f;
		}

		// Token: 0x060023FC RID: 9212
		// RVA: 0x0001C4AE File Offset: 0x0001A6AE
		[CompilerGenerated]
		private bool method_16(string string_0)
		{
			return Class546.regex_0.IsMatch(string_0) && !this.dictionary_1.ContainsKey(string_0);
		}

		// Token: 0x060023EA RID: 9194
		// RVA: 0x000D8280 File Offset: 0x000D6480
		private void method_2()
		{
			Class548 class = this.dictionary_0["Mania"];
			Dictionary<string, string> dictionary = class.method_5(new Predicate<string>(this.method_16));
			foreach (KeyValuePair<string, string> current in dictionary)
			{
				if (current.Value.StartsWith("Button"))
				{
					string text = current.Value.Substring(6);
					int num = 0;
					string a;
					if ((a = text) == null)
					{
						goto IL_C0;
					}
					if (!(a == "Left"))
					{
						if (!(a == "Right"))
						{
							if (!(a == "Up"))
							{
								if (!(a == "Down"))
								{
									goto IL_C0;
								}
								num = 43;
							}
							else
							{
								num = 42;
							}
						}
						else
						{
							num = 41;
						}
					}
					else
					{
						num = 40;
					}
					IL_CB:
					Keys value = 300 + num;
					this.dictionary_1.Add(current.Key, value);
					goto IL_12B;
					IL_C0:
					if (int.TryParse(text, out num))
					{
						goto IL_CB;
					}
					break;
				}
				else
				{
					try
					{
						Keys value = (Keys)Enum.Parse(typeof(Keys), current.Value);
						if (!this.dictionary_1.ContainsValue(value))
						{
							this.dictionary_1.Add(current.Key, value);
						}
					}
					catch
					{
					}
				}
				IL_12B:
				class.method_4(current.Key);
			}
		}

		// Token: 0x060023EB RID: 9195
		// RVA: 0x000D8410 File Offset: 0x000D6610
		internal void method_3()
		{
			if (this.method_6() <= 0 || this.method_6() > 18)
			{
				return;
			}
			Class421 class = new Class421(this, true, 0f, 480f, float.NaN, 1f, 0, 0);
			Class576 class2 = class.method_5();
			if (class2.method_0() >= 0)
			{
				return;
			}
			bool flag = false;
			Class577 class3 = class2.method_3();
			class.method_15(class3);
			Keys value;
			for (int i = 0; i < this.method_6(); i++)
			{
				if (this.dictionary_1.TryGetValue("Key" + i, out value))
				{
					class3[i, Enum53.const_1] = value;
					flag = true;
				}
			}
			if (this.dictionary_1.TryGetValue("Key100", out value))
			{
				class3[0, Enum53.const_2] = value;
				flag = true;
			}
			if (flag)
			{
				class2.Insert(0, class3);
				class2.method_1(0);
			}
		}

		// Token: 0x060023EC RID: 9196
		// RVA: 0x000D84F0 File Offset: 0x000D66F0
		internal bool method_4()
		{
			bool? flag = this.nullable_0;
			if (!flag.HasValue)
			{
				return this.bool_4;
			}
			return flag.GetValueOrDefault();
		}

		// Token: 0x060023ED RID: 9197
		// RVA: 0x0001C458 File Offset: 0x0001A658
		internal void method_5(bool bool_5)
		{
			this.bool_4 = bool_5;
		}

		// Token: 0x060023EE RID: 9198
		// RVA: 0x0001C461 File Offset: 0x0001A661
		internal int method_6()
		{
			return this.int_4;
		}

		// Token: 0x060023EF RID: 9199
		// RVA: 0x000D851C File Offset: 0x000D671C
		internal void method_7(int int_6)
		{
			this.int_4 = int_6;
			this.list_0.Clear();
			this.list_1.Clear();
			this.list_2.Clear();
			this.list_4.Clear();
			this.list_3.Clear();
			for (int i = 0; i <= this.int_4; i++)
			{
				this.list_0.Add(2f);
				if (i < this.int_4)
				{
					this.list_2.Add(30f);
					this.list_3.Add(0f);
					this.list_4.Add(0f);
				}
				if (i < this.int_4 - 1)
				{
					this.list_1.Add(0f);
				}
			}
		}

		// Token: 0x060023F3 RID: 9203
		// RVA: 0x000D8C10 File Offset: 0x000D6E10
		internal Color method_8(string string_0, Color color_0)
		{
			string_0 = "Colour" + string_0;
			Color result;
			if (this.dictionary_3.TryGetValue(string_0, out result))
			{
				return result;
			}
			return color_0;
		}

		// Token: 0x060023F5 RID: 9205
		// RVA: 0x000D8C74 File Offset: 0x000D6E74
		internal Class731[] method_9(string string_0, string string_1, Enum112 enum112_0)
		{
			string string_2;
			Class731[] result;
			if (this.dictionary_2.TryGetValue(string_0, out string_2) && (result = Class885.smethod_27(string_2, enum112_0, true)) != null)
			{
				return result;
			}
			return Class885.smethod_27(string_1, enum112_0, true);
		}

		// Token: 0x060023FD RID: 9213
		// RVA: 0x0001C4CE File Offset: 0x0001A6CE
		[CompilerGenerated]
		private static float smethod_0(float float_5)
		{
			if (float_5 > 0f && float_5 < 2f)
			{
				return 2f;
			}
			return float_5;
		}

		// Token: 0x060023FE RID: 9214
		// RVA: 0x0001C4E7 File Offset: 0x0001A6E7
		[CompilerGenerated]
		private static float smethod_1(float float_5)
		{
			return Class778.smethod_2(float_5, 5f, 100f);
		}

		// Token: 0x060023FF RID: 9215
		// RVA: 0x0001C4F9 File Offset: 0x0001A6F9
		[CompilerGenerated]
		private static bool smethod_2(string string_0)
		{
			return Class546.regex_1.IsMatch(string_0);
		}

		// Token: 0x06002400 RID: 9216
		// RVA: 0x0001C506 File Offset: 0x0001A706
		[CompilerGenerated]
		private static bool smethod_3(string string_0)
		{
			return Class546.regex_2.IsMatch(string_0);
		}

		// Token: 0x06002401 RID: 9217
		// RVA: 0x0001C513 File Offset: 0x0001A713
		[CompilerGenerated]
		private static bool smethod_4(string string_0)
		{
			return Class546.regex_3.IsMatch(string_0);
		}

		// Token: 0x06002402 RID: 9218
		// RVA: 0x0001C520 File Offset: 0x0001A720
		[CompilerGenerated]
		private static bool smethod_5(string string_0)
		{
			return Class546.regex_4.IsMatch(string_0);
		}

		// Token: 0x060023F1 RID: 9201
		// RVA: 0x000D86E0 File Offset: 0x000D68E0
		internal override void vmethod_0()
		{
			Class548 class = this.dictionary_0["Mania"];
			string value = null;
			if (class.method_3<string>("Keys", ref value))
			{
				this.method_7(Convert.ToInt32(value));
			}
			Class548 arg_57_0 = class;
			string arg_57_1 = "ColumnLineWidth";
			List<float> arg_57_2 = this.list_0;
			if (Class546.delegate36_0 == null)
			{
				Class546.delegate36_0 = new Class548.Delegate36<float>(Class546.smethod_0);
			}
			arg_57_0.method_7<float>(arg_57_1, arg_57_2, Class546.delegate36_0);
			class.method_3<float>("BarlineHeight", ref this.float_0);
			class.method_3<Enum54>("SpecialStyle", ref this.enum54_0);
			Class548 arg_A9_0 = class;
			string arg_A9_1 = "ColumnWidth";
			List<float> arg_A9_2 = this.list_2;
			if (Class546.delegate36_1 == null)
			{
				Class546.delegate36_1 = new Class548.Delegate36<float>(Class546.smethod_1);
			}
			arg_A9_0.method_7<float>(arg_A9_1, arg_A9_2, Class546.delegate36_1);
			class.method_7<float>("ColumnSpacing", this.list_1, null);
			class.method_7<float>("LightingNWidth", this.list_3, null);
			class.method_7<float>("LightingLWidth", this.list_4, null);
			Class548 arg_103_0 = class;
			if (Class546.predicate_0 == null)
			{
				Class546.predicate_0 = new Predicate<string>(Class546.smethod_2);
			}
			this.dictionary_2 = arg_103_0.method_6<string>(Class546.predicate_0);
			Class548 arg_12C_0 = class;
			if (Class546.predicate_1 == null)
			{
				Class546.predicate_1 = new Predicate<string>(Class546.smethod_3);
			}
			this.dictionary_3 = arg_12C_0.method_6<Color>(Class546.predicate_1);
			Class548 arg_155_0 = class;
			if (Class546.predicate_2 == null)
			{
				Class546.predicate_2 = new Predicate<string>(Class546.smethod_4);
			}
			this.dictionary_4 = arg_155_0.method_6<bool>(Class546.predicate_2);
			Class548 arg_17E_0 = class;
			if (Class546.predicate_3 == null)
			{
				Class546.predicate_3 = new Predicate<string>(Class546.smethod_5);
			}
			this.dictionary_5 = arg_17E_0.method_6<Enum55>(Class546.predicate_3);
			class.method_3<float>("WidthForNoteHeightScale", ref this.float_4);
			class.method_3<float>("StageSeparation", ref this.float_3);
			this.float_3 = Math.Max(this.float_3, 5f);
			class.method_3<bool>("SeparateScore", ref this.bool_2);
			class.method_3<bool?>("SplitStages", ref this.nullable_0);
			class.method_3<bool>("KeysUnderNotes", ref this.bool_3);
			class.method_3<float>("ColumnStart", ref this.float_1);
			class.method_3<float>("ColumnRight", ref this.float_2);
			class.method_3<bool>("JudgementLine", ref this.bool_0);
			class.method_3<int>("HitPosition", ref this.int_0);
			this.int_0 = Math.Max(240, Math.Min(this.int_0, 480));
			class.method_3<int>("LightPosition", ref this.int_1);
			class.method_3<int>("ComboPosition", ref this.int_2);
			class.method_3<int>("ScorePosition", ref this.int_3);
			class.method_3<bool>("UpsideDown", ref this.bool_1);
			class.method_3<int>("LightFramePerSecond", ref this.int_5);
			if (this.int_5 <= 0)
			{
				this.int_5 = 24;
			}
			this.method_2();
		}

		// Token: 0x060023F2 RID: 9202
		// RVA: 0x000D89C0 File Offset: 0x000D6BC0
		internal virtual void vmethod_3(StreamWriter streamWriter_0)
		{
			Class548 class = this.dictionary_0["Mania"];
			class.WriteValue<string>("Keys", this.method_6().ToString(), null, true);
			class.method_11<float>("ColumnWidth", this.list_2, 30f, false);
			class.method_11<float>("ColumnLineWidth", this.list_0, 2f, false);
			class.method_11<float>("ColumnSpacing", this.list_1, 0f, false);
			class.method_11<float>("LightingNWidth", this.list_3, 0f, false);
			class.method_11<float>("LightingLWidth", this.list_4, 0f, false);
			class.WriteValue("SpecialStyle", "SpecialStyle", false);
			class.WriteValue("ColumnStart", "ColumnStart", false);
			class.WriteValue("ColumnRight", "ColumnRight", false);
			class.WriteValue("JudgementLine", "JudgementLine", false);
			class.WriteValue("BarlineHeight", "BarlineHeight", false);
			class.WriteValue("HitPosition", "HitPosition", false);
			class.WriteValue("LightPosition", "LightPosition", false);
			class.WriteValue("ComboPosition", "ComboPosition", false);
			class.WriteValue("ScorePosition", "ScorePosition", false);
			class.WriteValue("UpsideDown", "UpsideDown", false);
			class.WriteValue("LightFramePerSecond", "LightFramePerSecond", false);
			class.WriteValue("SeparateScore", "SeparateScore", false);
			class.WriteValue("KeysUnderNotes", "KeysUnderNotes", false);
			class.WriteValue("SplitStages", "splitStagesFromSkin", false);
			class.WriteValue("StageSeparation", "StageSeparation", false);
			class.WriteValue("WidthForNoteHeightScale", "WidthForNoteHeightScale", false);
			class.method_13<string>(this.dictionary_2, null);
			class.method_13<bool>(this.dictionary_4, true);
			class.method_13<Enum55>(this.dictionary_5, Enum55.const_2);
			foreach (KeyValuePair<string, Color> current in this.dictionary_3)
			{
				class.WriteValue<Color?>(current.Key, new Color?(current.Value), null, false);
			}
			base.vmethod_2(streamWriter_0);
		}
	}
}
