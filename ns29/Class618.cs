using Microsoft.Win32;
using osu;
using System;
using System.Collections.Generic;

namespace ns29
{
	// Token: 0x020004AD RID: 1197
	internal static class Class618
	{
		// Token: 0x04001F8F RID: 8079
		private static List<FrameworkVersion> list_0;

		// Token: 0x06002633 RID: 9779
		// RVA: 0x000E58FC File Offset: 0x000E3AFC
		public static List<FrameworkVersion> smethod_0()
		{
			if (Class618.list_0 == null)
			{
				Class618.list_0 = new List<FrameworkVersion>();
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\"))
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						string text = subKeyNames[i];
						if (text.StartsWith("v"))
						{
							RegistryKey registryKey2 = registryKey.OpenSubKey(text);
							string text2 = (string)registryKey2.GetValue("Version", "");
							string a = registryKey2.GetValue("SP", "").ToString();
							string a2 = registryKey2.GetValue("Install", "").ToString();
							if (a2 != "")
							{
								if (a != "" && a2 == "1")
								{
									if (text.StartsWith("v3.0"))
									{
										Class618.list_0.Add(FrameworkVersion.dotnet30);
									}
									else if (text.StartsWith("v3.5"))
									{
										Class618.list_0.Add(FrameworkVersion.dotnet35);
									}
								}
							}
							else
							{
								string[] subKeyNames2 = registryKey2.GetSubKeyNames();
								for (int j = 0; j < subKeyNames2.Length; j++)
								{
									string name = subKeyNames2[j];
									RegistryKey registryKey3 = registryKey2.OpenSubKey(name);
									text2 = (string)registryKey3.GetValue("Version", "");
									a2 = registryKey3.GetValue("Install", "").ToString();
									if (a2 == "1")
									{
										if (!text2.StartsWith("4.5") && !text2.StartsWith("4.6"))
										{
											if (text2.StartsWith("4"))
											{
												Class618.list_0.Add(FrameworkVersion.dotnet4);
											}
										}
										else
										{
											Class618.list_0.Add(FrameworkVersion.dotnet45);
										}
									}
								}
							}
						}
					}
				}
			}
			return Class618.list_0;
		}
	}
}
