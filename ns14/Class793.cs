using Microsoft.Win32;
using ns29;
using System;

namespace ns14
{
	// Token: 0x020005CB RID: 1483
	internal sealed class Class793
	{
		// Token: 0x06002EFB RID: 12027
		// RVA: 0x00130E98 File Offset: 0x0012F098
		internal static void smethod_0()
		{
			Guid a = Class793.smethod_2();
			if (a == Guid.Empty)
			{
				return;
			}
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true))
			{
				try
				{
					registryKey.DeleteSubKeyTree(a.ToString("B"));
				}
				catch
				{
				}
			}
		}

		// Token: 0x06002EFC RID: 12028
		// RVA: 0x00130F0C File Offset: 0x0012F10C
		internal static bool smethod_1()
		{
			Guid a = Class793.smethod_2();
			if (a == Guid.Empty)
			{
				return false;
			}
			try
			{
				string text = a.ToString("B");
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", false))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
					{
						if (registryKey2 != null && (string)registryKey2.GetValue("DisplayIcon") == Class905.smethod_0())
						{
							bool result = true;
							return result;
						}
					}
				}
				try
				{
					using (RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey("Installer\\Products", true))
					{
						using (RegistryKey registryKey4 = registryKey3.OpenSubKey("6242953CE135011419D1FBCE2EEC82C4"))
						{
							if (registryKey4 != null)
							{
								registryKey3.DeleteSubKeyTree("6242953CE135011419D1FBCE2EEC82C4");
							}
						}
					}
				}
				catch
				{
				}
				using (RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true))
				{
					if (registryKey5 == null)
					{
						bool result = false;
						return result;
					}
					try
					{
						using (RegistryKey registryKey6 = registryKey5.OpenSubKey("{C3592426-531E-4110-911D-BFECE2CE284C}"))
						{
							if (registryKey6 != null)
							{
								registryKey5.DeleteSubKeyTree("{C3592426-531E-4110-911D-BFECE2CE284C}");
							}
						}
					}
					catch
					{
					}
					using (RegistryKey registryKey7 = registryKey5.OpenSubKey(text, true) ?? registryKey5.CreateSubKey(text))
					{
						if (registryKey7 == null)
						{
							bool result = false;
							return result;
						}
						registryKey7.SetValue("DisplayName", "osu!");
						registryKey7.SetValue("ApplicationVersion", "latest");
						registryKey7.SetValue("Publisher", "ppy Pty Ltd");
						registryKey7.SetValue("DisplayIcon", Class905.smethod_0());
						registryKey7.SetValue("DisplayVersion", "latest");
						registryKey7.SetValue("EstimatedSize", 125952, RegistryValueKind.DWord);
						registryKey7.SetValue("NoModify", 1, RegistryValueKind.DWord);
						registryKey7.SetValue("NoRepair", 1, RegistryValueKind.DWord);
						registryKey7.SetValue("URLInfoAbout", "http://osu.ppy.sh");
						registryKey7.SetValue("Contact", "osu@ppy.sh");
						registryKey7.SetValue("InstallDate", DateTime.Now.ToString("yyyyMMdd"));
						registryKey7.SetValue("UninstallString", Class905.smethod_0() + " -uninstall");
					}
				}
			}
			catch (Exception)
			{
				bool result = false;
				return result;
			}
			return true;
		}

		// Token: 0x06002EFD RID: 12029
		// RVA: 0x00131260 File Offset: 0x0012F460
		internal static Guid smethod_2()
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\osu!", false))
				{
					if (registryKey != null)
					{
						string value = registryKey.GetValue("UninstallID") as string;
						if (!string.IsNullOrEmpty(value))
						{
							Guid result = new Guid((string)registryKey.GetValue("UninstallID"));
							return result;
						}
					}
				}
				using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\osu!"))
				{
					Guid guid = Guid.NewGuid();
					registryKey2.SetValue("UninstallID", guid.ToString());
					Guid result = guid;
					return result;
				}
			}
			catch
			{
			}
			return Guid.Empty;
		}
	}
}
