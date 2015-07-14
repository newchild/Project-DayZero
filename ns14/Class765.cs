using ns18;
using ns24;
using ns26;
using ns29;
using ns30;
using ns64;
using System;
using System.IO;
using System.Threading;

namespace ns14
{
	// Token: 0x020005A2 RID: 1442
	internal static class Class765
	{
		// Token: 0x0400269F RID: 9887
		private static int int_0;

		// Token: 0x06002E3F RID: 11839
		// RVA: 0x0012BB30 File Offset: 0x00129D30
		internal static void smethod_0(Class764 class764_0)
		{
			if (Class765.int_0 > 0 && Class115.int_1 - Class765.int_0 < 10000)
			{
				return;
			}
			Class765.int_0 = Class115.int_1;
			try
			{
				Class162 class = new Class162();
				Class167 class2 = new Class167();
				class.method_26(class2);
				class2.Items.method_0("u", Class341.class605_20);
				if (Class115.class861_0 != null)
				{
					class2.Items.method_0("i", Class115.class861_0.int_1.ToString());
				}
				Class168 arg_92_0 = class2.Items;
				string arg_92_1 = "osumode";
				int osuModes_ = (int)Class115.osuModes_1;
				arg_92_0.method_0(arg_92_1, osuModes_.ToString());
				class2.Items.method_0("gamemode", ((int)Class62.Mode).ToString());
				class2.Items.method_0("gametime", Class115.int_1.ToString());
				class2.Items.method_0("audiotime", Class331.int_7.ToString());
				class2.Items.method_0("culture", Thread.CurrentThread.CurrentCulture.Name);
				class2.Items.method_0("b", (Class466.Current != null) ? Class466.Current.int_2.ToString() : "");
				class2.Items.method_0("bc", (Class466.Current != null) ? Class466.Current.string_3 : "");
				class2.Items.method_0("exception", class764_0.string_3);
				class2.Items.method_0("feedback", class764_0.string_0);
				class2.Items.method_0("stacktrace", class764_0.string_2);
				class2.Items.method_0("iltrace", class764_0.string_1);
				class2.Items.method_0("version", Class344.smethod_0());
				class2.Items.method_0("exehash", Class115.smethod_1(Path.GetFileName(Class905.smethod_0()), true));
				class2.Items.method_0("config", File.ReadAllText(Class341.smethod_1()));
				if (class764_0.byte_0 != null)
				{
					class2.Items.method_1("ss", "ss").method_4(class764_0.byte_0);
				}
				class.method_11(6000);
				class.method_48("http://osu.ppy.sh/web/osu-error.php");
				class.Close();
			}
			catch
			{
			}
		}
	}
}
