using ns24;
using ns77;
using ns79;
using ns8;
using ns80;
using ns89;
using osu.GameModes.Edit;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu.GameplayElements.Events;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns55
{
	// Token: 0x0200036E RID: 878
	internal sealed class Class295 : AiModRuleset
	{
		// Token: 0x0400151E RID: 5406
		[CompilerGenerated]
		private static BeenCorrectedDelegate beenCorrectedDelegate_0;

		// Token: 0x0400151F RID: 5407
		[CompilerGenerated]
		private static Predicate<Class702> predicate_0;

		// Token: 0x17000363 RID: 867
		public override AiModType Type
		{
			// Token: 0x06001A96 RID: 6806
			// RVA: 0x0000B7FB File Offset: 0x000099FB
			get
			{
				return AiModType.Design;
			}
		}

		// Token: 0x06001A99 RID: 6809
		// RVA: 0x00082A74 File Offset: 0x00080C74
		private void method_0()
		{
			string[] files = Directory.GetFiles(Class466.Current.method_3(), "*", SearchOption.AllDirectories);
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>(files.Length);
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				string path = array[i];
				string extension;
				if ((extension = Path.GetExtension(path)) != null && (extension == ".png" || extension == ".jpg" || extension == ".jpeg"))
				{
					string text = Path.GetFileName(path).ToLower();
					dictionary[text] = true;
					int num = 1;
					string text2 = text;
					if (text2.IndexOf("@2x") >= 0)
					{
						num = 2;
						text2 = text2.Substring(0, text2.IndexOf('@'));
					}
					string a;
					if ((a = text2) != null && (a == "hitcircle" || a == "hitcircleoverlay" || a == "approachcircle" || a == "reversearrow"))
					{
						Class731 class = Class885.Load(text, Enum112.flag_3);
						if (class != null && (class.method_0() != 128 * num || class.method_1() != 128 * num))
						{
							this.method_1(text, 128 * num);
						}
					}
				}
			}
			Class872 class872_ = Editor.editor_0.class872_0;
			for (int j = 0; j < class872_.list_3.Length; j++)
			{
				for (int k = 0; k < class872_.list_3[j].Count; k++)
				{
					Class702 class2 = class872_.list_3[j][k];
					string text3 = Path.GetFileName(class2.string_0).ToLower();
					if (!dictionary.ContainsKey(text3))
					{
						if (Class466.Current.bool_15)
						{
							string string_ = text3.Substring(0, text3.LastIndexOf('.')).ToLower();
							Class731 class3 = Class885.Load(string_, Enum112.flag_6);
							if (class3 != null)
							{
								goto IL_222;
							}
						}
						else
						{
							int num2 = text3.LastIndexOf('.');
							if (num2 >= 0 && dictionary.ContainsKey(text3.Insert(num2, "0")) && dictionary.ContainsKey(text3.Insert(num2, "1")))
							{
								goto IL_222;
							}
						}
						dictionary[text3] = true;
						this.Reports.Add(new AiReport(Severity.Error, Class41.GetString(OsuString.AIDesign_FileMissing) + text3));
					}
					IL_222:;
				}
			}
		}

		// Token: 0x06001A9A RID: 6810
		// RVA: 0x000165DA File Offset: 0x000147DA
		private void method_1(string string_0, int int_0)
		{
			this.Reports.Add(new AiReport(Severity.Error, string.Format(Class41.GetString(OsuString.AIDesign_IncorrectDimensions), string_0, int_0)));
		}

		// Token: 0x06001A98 RID: 6808
		// RVA: 0x000828A0 File Offset: 0x00080AA0
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class872 class872_ = Editor.editor_0.class872_0;
			if (class872_.class702_0 == null)
			{
				List<AiReport> arg_48_0 = this.Reports;
				int arg_43_0 = -1;
				Severity arg_43_1 = Severity.Error;
				string arg_43_2 = Class41.GetString(OsuString.AIDesign_NoBackgroundImage);
				int arg_43_3 = -1;
				if (Class295.beenCorrectedDelegate_0 == null)
				{
					Class295.beenCorrectedDelegate_0 = new BeenCorrectedDelegate(Class295.smethod_0);
				}
				arg_48_0.Add(new AiReport(arg_43_0, arg_43_1, arg_43_2, arg_43_3, Class295.beenCorrectedDelegate_0));
			}
			else if (class872_.class702_0.class531_0 != null)
			{
				int int_ = class872_.class702_0.class531_0.int_6;
				int int_2 = class872_.class702_0.class531_0.int_5;
				if (int_ > 1366 || int_2 > 768)
				{
					this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIDesign_BackgroundTooLarge)));
				}
			}
			if (class872_.list_5.Count > 0)
			{
				foreach (Class541 current in class872_.list_5)
				{
					if (current.int_6 > 1280 && current.int_5 > 720)
					{
						this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIDesign_VideoDimensionsTooLargeWidescreen)));
					}
					else if (current.int_6 > 1024 && current.int_5 > 768)
					{
						this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIDesign_VideoDimensionsTooLarge)));
					}
				}
			}
			if (!Class466.Current.bool_21)
			{
				List<Class702> arg_186_0 = class872_.list_1;
				if (Class295.predicate_0 == null)
				{
					Class295.predicate_0 = new Predicate<Class702>(Class295.smethod_1);
				}
				if (arg_186_0.FindAll(Class295.predicate_0).Count > 5)
				{
					this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIDesign_EpilepsyWarning)));
				}
			}
			this.method_0();
		}

		// Token: 0x06001A9B RID: 6811
		// RVA: 0x00016603 File Offset: 0x00014803
		[CompilerGenerated]
		private static bool smethod_0()
		{
			return Editor.editor_0.class872_0.class702_0 != null;
		}

		// Token: 0x06001A9C RID: 6812
		// RVA: 0x0001661A File Offset: 0x0001481A
		[CompilerGenerated]
		private static bool smethod_1(Class702 class702_0)
		{
			return class702_0.int_0 - class702_0.int_2 < 100 && class702_0.eventTypes_0 != EventTypes.Sample;
		}
	}
}
