using Microsoft.Win32;
using System;

namespace ns14
{
	// Token: 0x020005C4 RID: 1476
	internal static class Class788
	{
		// Token: 0x0400271F RID: 10015
		private static bool bool_0;

		// Token: 0x04002720 RID: 10016
		private static bool bool_1;

		// Token: 0x04002722 RID: 10018
		private static bool bool_2;

		// Token: 0x04002723 RID: 10019
		private static bool? nullable_0 = null;

		// Token: 0x04002721 RID: 10017
		private static RegistryKey registryKey_0;

		// Token: 0x06002EDE RID: 11998
		// RVA: 0x00130AA4 File Offset: 0x0012ECA4
		public static void smethod_0()
		{
			if (!Class788.bool_0 && (!Class788.nullable_0.HasValue || Class788.nullable_0.Value))
			{
				Class788.nullable_0 = new bool?(false);
				if (Class788.registryKey_0 == null)
				{
					try
					{
						Class788.registryKey_0 = Registry.CurrentUser.OpenSubKey("ControlPanel\\Desktop", true);
						if (Class788.registryKey_0 != null)
						{
							Class788.bool_2 = (Class788.registryKey_0.GetValue("ScreenSaveActive").ToString() == "1");
						}
						else
						{
							Class788.bool_0 = true;
						}
					}
					catch
					{
						Class788.bool_0 = true;
					}
				}
				if (Class788.bool_2 && Class788.bool_1)
				{
					if (Class788.registryKey_0 != null)
					{
						Class788.registryKey_0.SetValue("ScreenSaveActive", "0");
					}
					Class788.bool_1 = false;
				}
				return;
			}
		}

		// Token: 0x06002EDF RID: 11999
		// RVA: 0x00130B7C File Offset: 0x0012ED7C
		public static void smethod_1()
		{
			if (!Class788.bool_0 && (!Class788.nullable_0.HasValue || !Class788.nullable_0.Value))
			{
				Class788.nullable_0 = new bool?(true);
				if (Class788.bool_2 && !Class788.bool_1)
				{
					if (Class788.registryKey_0 != null)
					{
						Class788.registryKey_0.SetValue("ScreenSaveActive", "1");
					}
					Class788.bool_1 = true;
				}
				return;
			}
		}
	}
}
