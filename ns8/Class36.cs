using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns8
{
	// Token: 0x0200019C RID: 412
	internal static class Class36
	{
		// Token: 0x0200019D RID: 413
		[CompilerGenerated]
		private sealed class Class37
		{
			// Token: 0x0400072E RID: 1838
			public Match match_0;
		}

		// Token: 0x0200019E RID: 414
		[CompilerGenerated]
		private sealed class Class38
		{
			// Token: 0x0400072F RID: 1839
			public Class36.Class37 class37_0;

			// Token: 0x04000730 RID: 1840
			public int int_0;

			// Token: 0x04000731 RID: 1841
			public string string_0;

			// Token: 0x06000ED4 RID: 3796
			// RVA: 0x00050E78 File Offset: 0x0004F078
			public bool method_0(Class39 class39_0)
			{
				return (class39_0.int_0 <= this.int_0 && class39_0.int_0 + class39_0.int_1 >= this.int_0 + this.class37_0.match_0.Length) || (this.int_0 <= class39_0.int_0 && this.int_0 + this.class37_0.match_0.Length >= class39_0.int_0 + class39_0.int_1);
			}

			// Token: 0x06000ED5 RID: 3797
			// RVA: 0x0000EFEB File Offset: 0x0000D1EB
			public void method_1(Class39 class39_0)
			{
				class39_0.int_0 -= ((class39_0.int_0 > this.int_0) ? (this.class37_0.match_0.Length - this.string_0.Length) : 0);
			}
		}

		// Token: 0x04000727 RID: 1831
		private static Regex regex_0 = new Regex("\\[\\[([^\\]]+)\\]\\]");

		// Token: 0x04000728 RID: 1832
		private static Regex regex_1 = new Regex("\\(([^\\)]*)\\)\\[([a-z]+://[^ ]+)\\]");

		// Token: 0x04000729 RID: 1833
		private static Regex regex_2 = new Regex("\\[([a-z]+://[^ ]+) ([^\\[\\]]*(((?<open>\\[)[^\\[\\]]*)+((?<close-open>\\])[^\\[\\]]*)+)*(?(open)(?!)))\\]");

		// Token: 0x0400072A RID: 1834
		private static Regex regex_3 = new Regex("(?<paren>\\([^)]*)?(?<link>https?:\\/\\/(?<domain>(?:[a-z0-9]\\.|[a-z0-9][a-z0-9-]*[a-z0-9]\\.)*[a-z][a-z0-9-]*[a-z0-9](?::\\d+)?)(?<path>(?:(?:\\/+(?:[a-z0-9$_\\.\\+!\\*\\',;:\\(\\)@&~=-]|%[0-9a-f]{2})*)*(?:\\?(?:[a-z0-9$_\\+!\\*\\',;:\\(\\)@&=\\/~-]|%[0-9a-f]{2})*)?)?(?:#(?:[a-z0-9$_\\+!\\*\\',;:\\(\\)@&=\\/~-]|%[0-9a-f]{2})*)?)?)", RegexOptions.IgnoreCase);

		// Token: 0x0400072B RID: 1835
		private static Regex regex_4 = new Regex("\\d\\d:\\d\\d:\\d\\d\\d? [^-]*");

		// Token: 0x0400072C RID: 1836
		private static Regex regex_5 = new Regex("#[a-zA-Z]+[a-zA-Z0-9]+");

		// Token: 0x0400072D RID: 1837
		private static Regex regex_6 = new Regex("(\\uD83D[\\uDC00-\\uDE4F])");

		// Token: 0x06000ECE RID: 3790
		// RVA: 0x000509E0 File Offset: 0x0004EBE0
		private static void smethod_0(Regex regex_7, Class40 class40_0, int int_0)
		{
			foreach (Match match in regex_7.Matches(class40_0.string_0, int_0))
			{
				int num = match.Index;
				string value = match.Groups["paren"].Value;
				string text = match.Groups["link"].Value;
				int num2 = text.Length;
				if (!string.IsNullOrEmpty(value))
				{
					num += value.Length;
					if (text.EndsWith(")"))
					{
						num2--;
						text = text.Remove(text.Length - 1);
					}
				}
				class40_0.list_0.Add(new Class39(text, num, num2));
			}
		}

		// Token: 0x06000ECF RID: 3791
		// RVA: 0x00050ACC File Offset: 0x0004ECCC
		private static void smethod_1(Regex regex_7, string string_0, string string_1, Class40 class40_0, int int_0)
		{
			int num = 0;
			IEnumerator enumerator = regex_7.Matches(class40_0.string_0, int_0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Class36.Class37 class = new Class36.Class37();
					class.match_0 = (Match)enumerator.Current;
					Action<Class39> action = null;
					Class36.Class38 class2 = new Class36.Class38();
					class2.class37_0 = class;
					class2.int_0 = class.match_0.Index - num;
					class2.string_0 = string.Format(string_0, class.match_0.Groups[0], (class.match_0.Groups.Count > 1) ? class.match_0.Groups[1].Value : "", (class.match_0.Groups.Count > 2) ? class.match_0.Groups[2].Value : "").Trim();
					string text = string.Format(string_1, class.match_0.Groups[0], (class.match_0.Groups.Count > 1) ? class.match_0.Groups[1].Value : "", (class.match_0.Groups.Count > 2) ? class.match_0.Groups[2].Value : "").Trim();
					if (class2.string_0.Length != 0 && text.Length != 0 && class40_0.list_0.Find(new Predicate<Class39>(class2.method_0)) == null)
					{
						class40_0.string_0 = class40_0.string_0.Remove(class2.int_0, class.match_0.Length).Insert(class2.int_0, class2.string_0);
						List<Class39> arg_1E6_0 = class40_0.list_0;
						if (action == null)
						{
							action = new Action<Class39>(class2.method_1);
						}
						arg_1E6_0.ForEach(action);
						class40_0.list_0.Add(new Class39(text, class2.int_0, class2.string_0.Length));
						num += class.match_0.Length - class2.string_0.Length;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06000ED0 RID: 3792
		// RVA: 0x00050D40 File Offset: 0x0004EF40
		public static Class40 smethod_2(string string_0, int int_0, int int_1)
		{
			Class40 class = new Class40(string_0);
			Class36.smethod_1(Class36.regex_2, "{2}", "{1}", class, int_0);
			Class36.smethod_1(Class36.regex_1, "{1}", "{2}", class, int_0);
			Class36.smethod_1(Class36.regex_0, "wiki:{1}", "http://osu.ppy.sh/wiki/{1}", class, int_0);
			Class36.smethod_0(Class36.regex_3, class, int_0);
			Class36.smethod_1(Class36.regex_4, "{0}", "osu://edit/{0}", class, int_0);
			Class36.smethod_1(Class36.regex_5, "{0}", "osu://chan/{0}", class, int_0);
			string text = "";
			while (int_1-- > 0)
			{
				text += "\0";
			}
			Class36.smethod_1(Class36.regex_6, text, "{0}", class, int_0);
			return class;
		}
	}
}
