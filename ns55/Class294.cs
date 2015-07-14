using ns24;
using ns26;
using ns8;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns55
{
	// Token: 0x0200036A RID: 874
	internal sealed class Class294 : AiModRuleset
	{
		// Token: 0x0200036B RID: 875
		[CompilerGenerated]
		private sealed class Class364
		{
			// Token: 0x0400151D RID: 5405
			public Class296 class296_0;

			// Token: 0x06001A8E RID: 6798
			// RVA: 0x000165A9 File Offset: 0x000147A9
			public bool method_0(Class296 class296_1)
			{
				return class296_1.method_3() == this.class296_0.method_3();
			}
		}

		// Token: 0x0400151B RID: 5403
		[CompilerGenerated]
		private static Predicate<Class340> predicate_0;

		// Token: 0x0400151C RID: 5404
		[CompilerGenerated]
		private static Predicate<Class340> predicate_1;

		// Token: 0x17000362 RID: 866
		public override AiModType Type
		{
			// Token: 0x06001A86 RID: 6790
			// RVA: 0x0001659E File Offset: 0x0001479E
			get
			{
				return AiModType.Mapset;
			}
		}

		// Token: 0x06001A87 RID: 6791
		// RVA: 0x00016545 File Offset: 0x00014745
		internal Class294()
		{
		}

		// Token: 0x06001A89 RID: 6793
		// RVA: 0x000823B8 File Offset: 0x000805B8
		private void method_0(Class296 class296_0, Class296 class296_1)
		{
			if (class296_0.string_1 != class296_1.string_1)
			{
				return;
			}
			Dictionary<int, double> dictionary = new Dictionary<int, double>();
			List<Class340> arg_3D_0 = class296_0.list_1;
			if (Class294.predicate_0 == null)
			{
				Class294.predicate_0 = new Predicate<Class340>(Class294.smethod_0);
			}
			List<Class340> list = arg_3D_0.FindAll(Class294.predicate_0);
			List<Class340> arg_66_0 = class296_1.list_1;
			if (Class294.predicate_1 == null)
			{
				Class294.predicate_1 = new Predicate<Class340>(Class294.smethod_1);
			}
			List<Class340> list2 = arg_66_0.FindAll(Class294.predicate_1);
			for (int i = 0; i < list.Count; i++)
			{
				dictionary[(int)list[i].double_1] = list[i].double_0;
			}
			int num = 0;
			for (int j = 0; j < list2.Count; j++)
			{
				int key = (int)list2[j].double_1;
				if (dictionary.ContainsKey(key) && dictionary[key] == list2[j].double_0)
				{
					dictionary.Remove(key);
					num++;
				}
			}
			if (num != list2.Count || num != list.Count)
			{
				this.Reports.Add(new AiReport(Severity.Warning, "Uninherited timing points conflict with " + class296_1.string_14 + " diff."));
			}
		}

		// Token: 0x06001A8A RID: 6794
		// RVA: 0x000824F4 File Offset: 0x000806F4
		private void method_1()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Class466.Current.method_3());
			FileInfo[] files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			long num = 0L;
			bool flag = false;
			Regex regex = new Regex("\\.(avi|wmv|flv|mpg)");
			FileInfo[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = array[i];
				num += fileInfo.Length;
				if (regex.IsMatch(fileInfo.Name))
				{
					flag = true;
				}
			}
			num /= 1024L;
			if (!flag && num > 10240L)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_LargeFilesize)));
				return;
			}
			if (flag && num > 24576L)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_LargeFilesizeVideo)));
			}
		}

		// Token: 0x06001A88 RID: 6792
		// RVA: 0x00081F94 File Offset: 0x00080194
		protected override void RunAllRules(HitObjectManagerBase hitObjectManager)
		{
			Class294.Class364 class = new Class294.Class364();
			class.class296_0 = Class466.Current;
			List<Class296> list = Class466.list_3.FindAll(new Predicate<Class296>(class.method_0));
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			double num4 = 5.0;
			for (int i = 0; i < list.Count; i++)
			{
				Class296 class2 = list[i];
				if (class2.method_5() == PlayModes.Taiko)
				{
					num++;
				}
				if (class2.method_5() == PlayModes.OsuMania)
				{
					num2++;
				}
				if (class2.method_5() == PlayModes.Osu)
				{
					num3++;
					if (class2.method_14() < num4)
					{
						num4 = class2.method_14();
					}
				}
				if (!(class2.string_3 == class.class296_0.string_3))
				{
					class2.method_11();
					if (class2.Artist != class.class296_0.Artist)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingArtist), class2.string_14)));
					}
					if (class2.Title != class.class296_0.Title)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingTitle), class2.string_14)));
					}
					if (class2.ArtistUnicode != class.class296_0.ArtistUnicode)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingUnicodeArtist), class2.string_14)));
					}
					if (class2.TitleUnicode != class.class296_0.TitleUnicode)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingUnicodeTitle), class2.string_14)));
					}
					if (class2.string_13 != class.class296_0.string_13)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingSource), class2.string_14)));
					}
					if (class2.Tags != class.class296_0.Tags)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingTags), class2.string_14)));
					}
					if (class2.string_1 != class.class296_0.string_1)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingAudioFile), class2.string_14)));
					}
					if (class2.int_1 != class.class296_0.int_1)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingLeadin), class2.string_14)));
					}
					if (class2.int_14 != class.class296_0.int_14)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingPreviewTime), class2.string_14)));
					}
					if (class2.enum65_0 != class.class296_0.enum65_0)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingCountdown), class2.string_14)));
					}
					if (class2.bool_11 != class.class296_0.bool_11)
					{
						this.Reports.Add(new AiReport(Severity.Warning, string.Format(Class41.GetString(OsuString.AIMapset_ConflictingLetterbox), class2.string_14)));
					}
					this.method_0(class.class296_0, class2);
				}
			}
			if (num3 == 1)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_MissingStandardDiff)));
			}
			if (num4 > 3.25)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_MissingEasierDiff)));
			}
			if (num == 1)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_MissingTaikoDiff)));
			}
			if (num2 == 1)
			{
				this.Reports.Add(new AiReport(Severity.Warning, Class41.GetString(OsuString.AIMapset_MissingManiaDiff)));
			}
			this.method_1();
		}

		// Token: 0x06001A8B RID: 6795
		// RVA: 0x000165A1 File Offset: 0x000147A1
		[CompilerGenerated]
		private static bool smethod_0(Class340 class340_0)
		{
			return class340_0.method_0();
		}

		// Token: 0x06001A8C RID: 6796
		// RVA: 0x000165A1 File Offset: 0x000147A1
		[CompilerGenerated]
		private static bool smethod_1(Class340 class340_0)
		{
			return class340_0.method_0();
		}
	}
}
