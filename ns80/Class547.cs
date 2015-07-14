using Microsoft.Xna.Framework.Graphics;
using ns29;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns80
{
	// Token: 0x02000577 RID: 1399
	internal sealed class Class547 : Class544
	{
		// Token: 0x04002559 RID: 9561
		internal bool bool_0 = true;

		// Token: 0x0400255A RID: 9562
		internal bool bool_1 = true;

		// Token: 0x04002570 RID: 9584
		internal bool bool_10;

		// Token: 0x04002571 RID: 9585
		internal bool bool_11;

		// Token: 0x04002572 RID: 9586
		private bool bool_12;

		// Token: 0x0400255B RID: 9563
		internal bool bool_2 = true;

		// Token: 0x0400255E RID: 9566
		internal bool bool_3;

		// Token: 0x04002567 RID: 9575
		internal bool bool_4 = true;

		// Token: 0x04002568 RID: 9576
		internal bool bool_5 = true;

		// Token: 0x04002569 RID: 9577
		internal bool bool_6 = true;

		// Token: 0x0400256A RID: 9578
		internal bool bool_7 = !Class885.smethod_25();

		// Token: 0x0400256B RID: 9579
		internal bool bool_8;

		// Token: 0x0400256D RID: 9581
		internal bool bool_9;

		// Token: 0x04002575 RID: 9589
		internal Class545 class545_0 = new Class545();

		// Token: 0x04002577 RID: 9591
		[CompilerGenerated]
		private static Converter<int, string> converter_0;

		// Token: 0x04002556 RID: 9558
		internal Dictionary<string, Color> dictionary_1 = new Dictionary<string, Color>();

		// Token: 0x04002557 RID: 9559
		private Dictionary<string, Color> dictionary_2 = new Dictionary<string, Color>
		{
			{
				"Combo1",
				Class885.color_0[0]
			},
			{
				"Combo2",
				Class885.color_0[1]
			},
			{
				"Combo3",
				Class885.color_0[2]
			},
			{
				"Combo4",
				Class885.color_0[3]
			},
			{
				"Combo5",
				Class885.color_0[4]
			},
			{
				"MenuGlow",
				new Color(0, 78, 155)
			},
			{
				"SliderBall",
				new Color(2, 170, 255)
			},
			{
				"SliderBorder",
				new Color(255, 255, 255)
			},
			{
				"SpinnerApproachCircle",
				new Color(77, 139, 217)
			},
			{
				"SongSelectActiveText",
				Color.get_Black()
			},
			{
				"SongSelectInactiveText",
				Color.get_White()
			},
			{
				"StarBreakAdditive",
				Color.get_LightPink()
			}
		};

		// Token: 0x04002573 RID: 9587
		internal double double_0 = 1.0;

		// Token: 0x0400256F RID: 9583
		internal Enum68 enum68_0 = Enum68.const_1;

		// Token: 0x0400255F RID: 9567
		internal int int_0 = 10;

		// Token: 0x04002563 RID: 9571
		internal int int_1;

		// Token: 0x04002565 RID: 9573
		internal int int_2;

		// Token: 0x04002566 RID: 9574
		internal int int_3 = -2;

		// Token: 0x0400256C RID: 9580
		internal int int_4 = -1;

		// Token: 0x04002558 RID: 9560
		internal List<Color> list_0 = new List<Color>();

		// Token: 0x0400256E RID: 9582
		internal List<int> list_1 = new List<int>();

		// Token: 0x04002574 RID: 9588
		internal List<Class546> list_2 = new List<Class546>();

		// Token: 0x04002576 RID: 9590
		private static readonly Regex regex_0 = new Regex("Triangle\\d+");

		// Token: 0x0400255C RID: 9564
		internal string string_0 = string.Empty;

		// Token: 0x0400255D RID: 9565
		internal string string_1 = "Unknown";

		// Token: 0x04002560 RID: 9568
		internal string string_2;

		// Token: 0x04002561 RID: 9569
		internal string string_3 = "default";

		// Token: 0x04002562 RID: 9570
		internal string string_4 = "score";

		// Token: 0x04002564 RID: 9572
		internal string string_5 = "score";

		// Token: 0x06002D07 RID: 11527
		// RVA: 0x001240D0 File Offset: 0x001222D0
		internal Class547()
		{
			base.method_0("General");
			base.method_0("Colours");
			base.method_0("Fonts");
			this.dictionary_0["Colours"].bool_0 = false;
		}

		// Token: 0x06002D0B RID: 11531
		// RVA: 0x00022159 File Offset: 0x00020359
		[CompilerGenerated]
		private static string smethod_0(int int_5)
		{
			return int_5.ToString(Class115.numberFormatInfo_0);
		}

		// Token: 0x06002D09 RID: 11529
		// RVA: 0x00124384 File Offset: 0x00122584
		internal override void vmethod_0()
		{
			Class548 class = this.dictionary_0["General"];
			class.method_3<string>("Name", ref this.string_1);
			class.method_3<string>("Author", ref this.string_0);
			class.method_3<bool>("SliderBallFlip", ref this.bool_3);
			class.method_3<bool>("SliderBallDontRotate", ref this.bool_3);
			class.method_3<bool>("CursorRotate", ref this.bool_2);
			class.method_3<bool>("CursorExpand", ref this.bool_1);
			class.method_3<bool>("CursorCentre", ref this.bool_0);
			class.method_3<int>("SliderBallFrames", ref this.int_0);
			class.method_3<bool>("HitCircleOverlayAboveNumber", ref this.bool_4);
			class.method_3<bool>("HitCircleOverlayAboveNumer", ref this.bool_4);
			class.method_3<bool>("SpinnerFrequencyModulate", ref this.bool_5);
			class.method_3<bool>("LayeredHitSounds", ref this.bool_6);
			class.method_3<bool>("SpinnerFadePlayfield", ref this.bool_7);
			class.method_3<bool>("SpinnerNoBlink", ref this.bool_8);
			class.method_3<bool>("AllowSliderBallTint", ref this.bool_10);
			class.method_3<int>("AnimationFramerate", ref this.int_4);
			class.method_3<bool>("CursorTrailRotate", ref this.bool_9);
			class.method_7<int>("CustomComboBurstSounds", this.list_1, null);
			class.method_3<bool>("ComboBurstRandom", ref this.bool_11);
			class.method_3<Enum68>("SliderStyle", ref this.enum68_0);
			string text = null;
			if (class.method_3<string>("Version", ref text))
			{
				this.bool_12 = (text == "latest");
				this.double_0 = (this.bool_12 ? 2.5 : Convert.ToDouble(text, Class115.numberFormatInfo_0));
			}
			class = this.dictionary_0["Colours"];
			this.dictionary_1 = class.method_8<Color>();
			bool flag = this.dictionary_1.ContainsKey("Combo1");
			foreach (KeyValuePair<string, Color> current in this.dictionary_2)
			{
				if (!this.dictionary_1.ContainsKey(current.Key) && (!flag || !current.Key.StartsWith("Combo")))
				{
					this.dictionary_1[current.Key] = current.Value;
				}
			}
			foreach (KeyValuePair<string, Color> current2 in this.dictionary_1)
			{
				if (Class547.regex_0.IsMatch(current2.Key))
				{
					this.list_0.Add(current2.Value);
				}
			}
			class = this.dictionary_0["Fonts"];
			class.method_3<string>("HitCirclePrefix", ref this.string_3);
			class.method_3<int>("HitCircleOverlap", ref this.int_3);
			class.method_3<string>("ScorePrefix", ref this.string_4);
			class.method_3<string>("ComboPrefix", ref this.string_5);
			class.method_3<int>("ScoreOverlap", ref this.int_1);
			class.method_3<int>("ComboOverlap", ref this.int_2);
			this.class545_0.vmethod_0();
			for (int i = 0; i < this.list_2.Count; i++)
			{
				this.list_2[i].vmethod_0();
			}
		}

		// Token: 0x06002D08 RID: 11528
		// RVA: 0x00124320 File Offset: 0x00122520
		internal override void vmethod_1(string string_6, string string_7)
		{
			if (string_6 != null)
			{
				if (string_6 == "Mania")
				{
					this.list_2[this.list_2.Count - 1].vmethod_1(string_6, string_7);
					return;
				}
				if (string_6 == "CatchTheBeat")
				{
					this.class545_0.vmethod_1(string_6, string_7);
					return;
				}
			}
			base.vmethod_1(string_6, string_7);
		}

		// Token: 0x06002D0A RID: 11530
		// RVA: 0x0012471C File Offset: 0x0012291C
		internal virtual void vmethod_3(StreamWriter streamWriter_0)
		{
			Class548 class = this.dictionary_0["General"];
			class.WriteValue("Name", "SkinName", false);
			class.WriteValue("Author", "SkinAuthor", false);
			class.WriteValue("SliderBallFlip", "SliderBallFlip", false);
			class.WriteValue("CursorRotate", "CursorRotate", false);
			class.WriteValue("CursorExpand", "CursorExpand", false);
			class.WriteValue("CursorCentre", "CursorCentre", false);
			class.WriteValue("SliderBallFrames", "SliderBallFrames", false);
			class.WriteValue("HitCircleOverlayAboveNumber", "OverlayAboveNumber", false);
			class.WriteValue("SpinnerFrequencyModulate", "SpinnerFrequencyModulate", false);
			class.WriteValue("LayeredHitSounds", "LayeredHitSounds", false);
			class.WriteValue("SpinnerFadePlayfield", "SpinnerFadePlayfield", false);
			class.WriteValue("SpinnerNoBlink", "SpinnerNoBlink", false);
			class.WriteValue("AllowSliderBallTint", "AllowSliderBallTint", false);
			class.WriteValue("AnimationFramerate", "AnimationFramerate", false);
			class.WriteValue("CursorTrailRotate", "CursorTrailRotate", false);
			Class548 arg_153_0 = class;
			string arg_153_1 = "CustomComboBurstSounds";
			string arg_148_0 = ",";
			List<int> arg_13E_0 = this.list_1;
			if (Class547.converter_0 == null)
			{
				Class547.converter_0 = new Converter<int, string>(Class547.smethod_0);
			}
			arg_153_0.WriteValue<string>(arg_153_1, string.Join(arg_148_0, arg_13E_0.ConvertAll<string>(Class547.converter_0).ToArray()), "", false);
			class.WriteValue("ComboBurstRandom", "ComboBurstRandom", false);
			class.WriteValue<int>("SliderStyle", (int)this.enum68_0, 2, false);
			if (this.bool_12)
			{
				class.WriteValue<string>("Version", "latest", "latest", false);
			}
			else
			{
				class.WriteValue("Version", "Version", false);
			}
			class = this.dictionary_0["Colours"];
			foreach (KeyValuePair<string, Color> current in this.dictionary_1)
			{
				Color gparam_;
				if (this.dictionary_2.TryGetValue(current.Key, out gparam_))
				{
					this.dictionary_0["Colours"].WriteValue<Color>(current.Key, this.dictionary_1[current.Key], gparam_, false);
				}
				else
				{
					this.dictionary_0["Colours"].WriteValue<Color?>(current.Key, new Color?(this.dictionary_1[current.Key]), null, false);
				}
			}
			class = this.dictionary_0["Fonts"];
			class.WriteValue("HitCirclePrefix", "FontHitCircle", false);
			class.WriteValue("HitCircleOverlap", "FontHitCircleOverlap", false);
			class.WriteValue("ScorePrefix", "FontScore", false);
			class.WriteValue("ComboPrefix", "FontCombo", false);
			class.WriteValue("ScoreOverlap", "FontScoreOverlap", false);
			class.WriteValue("ComboOverlap", "FontComboOverlap", false);
			base.vmethod_2(streamWriter_0);
			this.class545_0.vmethod_2(streamWriter_0);
			for (int i = 0; i < this.list_2.Count; i++)
			{
				this.list_2[i].vmethod_3(streamWriter_0);
			}
		}
	}
}
