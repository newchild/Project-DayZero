using ns14;
using ns18;
using ns23;
using ns24;
using ns26;
using ns29;
using ns64;
using ns76;
using ns8;
using ns90;
using osu;
using osu.GameModes.Edit;
using osu_common;
using osu_common.Helpers;
using System;

namespace ns69
{
	// Token: 0x020003D6 RID: 982
	internal sealed class Class435
	{
		// Token: 0x040018EC RID: 6380
		private static bool bool_0;

		// Token: 0x040018F1 RID: 6385
		private static Class296 class296_0;

		// Token: 0x040018EE RID: 6382
		internal static double double_0;

		// Token: 0x040018EF RID: 6383
		internal static double double_1;

		// Token: 0x040018F0 RID: 6384
		private static double double_2;

		// Token: 0x040018ED RID: 6381
		internal static int int_0 = 12;

		// Token: 0x06001F8B RID: 8075
		// RVA: 0x000B2BD8 File Offset: 0x000B0DD8
		internal static bool smethod_0(int int_1, Enum45 enum45_0)
		{
			if ((enum45_0 & Enum45.flag_2) > Enum45.flag_0)
			{
				if (Class466.Current == null)
				{
					int_1 = Class341.class608_7.Value;
					if (Class435.double_2 <= 0.0)
					{
						Class435.double_2 = 100.0;
					}
				}
				else
				{
					int_1 = ((!Class341.class606_72 || Class466.Current.int_18 <= 0) ? Class341.class608_7.Value : Class466.Current.int_18);
					if (Class466.Current != Class435.class296_0)
					{
						Class435.class296_0 = Class466.Current;
						Class435.double_2 = (double)Class435.class296_0.method_33().Z;
					}
				}
				Class435.bool_0 = false;
			}
			else if ((enum45_0 & Enum45.flag_1) == Enum45.flag_0 && Class435.bool_0)
			{
				return false;
			}
			int_1 = Class778.smethod_1(int_1, 1, 40);
			if ((enum45_0 & Enum45.flag_1) > Enum45.flag_0)
			{
				Class435.bool_0 = true;
				Class341.class608_7.Value = int_1;
				if (Class466.Current != null && Class341.class606_72)
				{
					Class466.Current.int_18 = int_1;
				}
			}
			Class435.double_1 = Class435.double_2 * (Class876.smethod_5(Mods.DoubleTime) ? 1.5 : (Class876.smethod_5(Mods.HalfTime) ? 0.75 : 1.0));
			double num = Class435.double_0;
			if ((enum45_0 & Enum45.flag_3) == Enum45.flag_0)
			{
				Class435.int_0 = int_1;
				Class435.double_0 = (double)Class435.int_0 * (Class341.class606_73 ? 1.0 : (100.0 / Math.Max(Class435.double_1, 1.0)));
			}
			else
			{
				Class435.double_0 = (double)int_1;
				Class435.int_0 = Class778.smethod_1((int)Math.Round(Class435.double_0 * Class435.double_1 / 100.0), 1, 40);
			}
			return Class435.double_0 != num;
		}

		// Token: 0x06001F8C RID: 8076
		// RVA: 0x000B2DA0 File Offset: 0x000B0FA0
		internal static void smethod_1(int int_1)
		{
			int int_2 = Class435.int_0 + int_1;
			Class435.smethod_0(int_2, Enum45.flag_1);
			Class723.smethod_1(string.Format(Class41.GetString(OsuString.ConfigMania_OsuManiaSpeedSet), Class435.smethod_2()), 1750);
		}

		// Token: 0x06001F8D RID: 8077
		// RVA: 0x00019CC8 File Offset: 0x00017EC8
		internal static string smethod_2()
		{
			return string.Format("{0:0} ({1})", Class435.int_0, Class341.class606_73 ? Class41.GetString(OsuString.ConfigMania_BPMscale) : Class41.GetString(OsuString.ConfigMania_Fixed));
		}

		// Token: 0x06001F8E RID: 8078
		// RVA: 0x000B2DDC File Offset: 0x000B0FDC
		internal static double smethod_3(int int_1)
		{
			Class297 class = null;
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				class = Class62.class62_0.class297_0;
			}
			else if (Class115.osuModes_1 == OsuModes.Edit)
			{
				class = Editor.editor_0.class297_0;
			}
			if (class == null)
			{
				return Class331.smethod_22((double)int_1, Class466.Current.method_5() == PlayModes.OsuMania);
			}
			return class.class296_0.method_36((double)int_1, class.class296_0.method_5() == PlayModes.OsuMania);
		}

		// Token: 0x06001F8F RID: 8079
		// RVA: 0x00019D00 File Offset: 0x00017F00
		internal static double smethod_4(double double_3, double double_4)
		{
			return 21.0 * Class435.double_0 * double_4 / double_3;
		}

		// Token: 0x06001F90 RID: 8080
		// RVA: 0x00019D15 File Offset: 0x00017F15
		internal static double smethod_5(int int_1, int int_2)
		{
			return (double)int_2 * Class435.smethod_3(int_1) / 21.0 / Class435.double_0;
		}

		// Token: 0x06001F91 RID: 8081
		// RVA: 0x00019D30 File Offset: 0x00017F30
		internal static double smethod_6(double double_3, double double_4)
		{
			return double_4 * double_3 / 21.0 / Class435.double_0;
		}
	}
}
