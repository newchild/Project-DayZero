using Microsoft.Xna.Framework.Graphics;
using ns30;
using ns64;
using ns90;
using osu_common.Libraries.NetLib;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns6
{
	// Token: 0x02000635 RID: 1589
	internal static class Class836
	{
		// Token: 0x04002CE5 RID: 11493
		private static bool bool_0;

		// Token: 0x04002CE6 RID: 11494
		private static bool bool_1;

		// Token: 0x04002CE9 RID: 11497
		[CompilerGenerated]
		private static FileNetRequest.Delegate10 delegate10_0;

		// Token: 0x04002CE8 RID: 11496
		private static int int_0;

		// Token: 0x04002CE7 RID: 11495
		private static string[] string_0;

		// Token: 0x06003133 RID: 12595
		// RVA: 0x001423C8 File Offset: 0x001405C8
		internal static void Initialize()
		{
			if (Class836.bool_1)
			{
				return;
			}
			Class836.bool_1 = true;
			if (File.Exists("Data/filter.txt") && (DateTime.Now - File.GetLastWriteTime("Data/filter.txt")).TotalDays <= 7.0)
			{
				Class836.smethod_1();
				return;
			}
			FileNetRequest fileNetRequest = new FileNetRequest("Data/filter.txt", "http://osu.ppy.sh/release/filter.txt");
			FileNetRequest arg_75_0 = fileNetRequest;
			if (Class836.delegate10_0 == null)
			{
				Class836.delegate10_0 = new FileNetRequest.Delegate10(Class836.smethod_2);
			}
			arg_75_0.method_2(Class836.delegate10_0);
			Class169.smethod_0(fileNetRequest);
		}

		// Token: 0x06003132 RID: 12594
		// RVA: 0x0014233C File Offset: 0x0014053C
		internal static string smethod_0(string string_1)
		{
			if (!Class836.bool_0)
			{
				Class836.Initialize();
			}
			if (Class836.bool_1)
			{
				return "Chat filter is updating...";
			}
			for (int i = 0; i < Class836.int_0; i++)
			{
				int num = string_1.IndexOf(Class836.string_0[i], StringComparison.OrdinalIgnoreCase);
				while (num >= 0 && Class836.string_0[i].Length > 0)
				{
					string_1 = string_1.Replace(string_1.Substring(num, Class836.string_0[i].Length), "*beep*");
					num = string_1.IndexOf(Class836.string_0[i], StringComparison.OrdinalIgnoreCase);
				}
			}
			return string_1;
		}

		// Token: 0x06003134 RID: 12596
		// RVA: 0x00142458 File Offset: 0x00140658
		private static void smethod_1()
		{
			if (!File.Exists("Data/filter.txt"))
			{
				Class341.class606_9.Value = false;
				Class723.smethod_5("Failed to download chat filter data.  Disabling filter.", Color.get_Red(), 5000, null);
			}
			Class836.string_0 = File.ReadAllLines("Data/filter.txt");
			Class836.int_0 = Class836.string_0.Length;
			Class836.bool_0 = true;
			Class836.bool_1 = false;
		}

		// Token: 0x06003135 RID: 12597
		// RVA: 0x000245A4 File Offset: 0x000227A4
		[CompilerGenerated]
		private static void smethod_2(string string_1, Exception exception_0)
		{
			Class836.smethod_1();
		}
	}
}
