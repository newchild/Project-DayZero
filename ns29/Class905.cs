using Microsoft.Xna.Framework.Graphics;
using ns11;
using ns14;
using ns25;
using ns41;
using ns64;
using ns8;
using ns9;
using osu;
using osu.Helpers;
using osu.Properties;
using osu_common.Helpers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace ns29
{
	// Token: 0x020006AB RID: 1707
	internal static class Class905
	{
		// Token: 0x020006AC RID: 1708
		[CompilerGenerated]
		private sealed class Class906
		{
			// Token: 0x0400317C RID: 12668
			public Bitmap bitmap_0;

			// Token: 0x06003559 RID: 13657
			// RVA: 0x0016D3A8 File Offset: 0x0016B5A8
			public void method_0()
			{
				try
				{
					Application.Run(new SplashScreen(this.bitmap_0));
				}
				catch
				{
				}
			}
		}

		// Token: 0x020006AD RID: 1709
		[CompilerGenerated]
		private sealed class Class907
		{
			// Token: 0x0400317D RID: 12669
			public UnhandledExceptionEventArgs unhandledExceptionEventArgs_0;

			// Token: 0x0600355B RID: 13659
			// RVA: 0x0016D3DC File Offset: 0x0016B5DC
			public void method_0()
			{
				Class115.smethod_6(true);
				Class115.class114_0.bool_7 = true;
				ErrorDialog errorDialog = new ErrorDialog(this.unhandledExceptionEventArgs_0.ExceptionObject as Exception, true);
				errorDialog.ShowDialog();
				Class809.smethod_27();
				Environment.Exit(-1);
			}
		}

		// Token: 0x04003174 RID: 12660
		internal static bool bool_0;

		// Token: 0x04003177 RID: 12663
		public static bool bool_1;

		// Token: 0x04003178 RID: 12664
		internal static bool bool_2;

		// Token: 0x0400317A RID: 12666
		private static bool bool_3;

		// Token: 0x04003175 RID: 12661
		internal static Guid guid_0 = new Guid("{20F7B388-7444-42CC-9388-C23275781FF8}");

		// Token: 0x0400317B RID: 12667
		private static bool? nullable_0;

		// Token: 0x04003176 RID: 12662
		private static string string_0;

		// Token: 0x04003179 RID: 12665
		internal static string[] string_1;

		// Token: 0x06003546 RID: 13638
		// RVA: 0x0016CCD8 File Offset: 0x0016AED8
		private static void Cleanup()
		{
			if (!Directory.Exists("_cleanup"))
			{
				return;
			}
			string[] files = Directory.GetFiles("_cleanup");
			for (int i = 0; i < files.Length; i++)
			{
				string path = files[i];
				try
				{
					File.Delete(path);
				}
				catch
				{
				}
			}
			try
			{
				Directory.Delete("_cleanup");
			}
			catch
			{
			}
		}

		// Token: 0x06003555 RID: 13653
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string string_2);

		// Token: 0x06003554 RID: 13652
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_2);

		// Token: 0x06003545 RID: 13637
		// RVA: 0x0016C958 File Offset: 0x0016AB58
		[STAThread]
		private static void Main()
		{
			Class905.string_1 = Environment.GetCommandLineArgs();
			Environment.CurrentDirectory = Path.GetDirectoryName(Class905.smethod_0());
			Application.SetCompatibleTextRenderingDefault(false);
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Class905.smethod_7);
			bool flag = File.Exists(".require_update") || File.Exists("help.txt");
			string[] array = new string[]
			{
				"avcodec-51.dll",
				"avformat-52.dll",
				"avutil-49.dll",
				"bass.dll",
				"bass_fx.dll",
				"d3dx9_31.dll",
				"pthreadGC2.dll",
				"x3daudio1_1.dll",
				"Microsoft.Xna.Framework.dll",
				"Microsoft.Ink.dll",
				"osu.dll",
				"osu!gameplay.dll",
				"osu!ui.dll"
			};
			string a;
			if (Class905.string_1.Length > 1 && (a = Class905.string_1[1]) != null)
			{
				if (!(a == "-fix-framework"))
				{
					if (!(a == "-repair"))
					{
						if (a == "-allowuserwrites")
						{
							string text = string.Empty;
							for (int i = 2; i < Class905.string_1.Length; i++)
							{
								text = text + Class905.string_1[i] + " ";
							}
							Class905.smethod_15(text.Trim());
							return;
						}
						if (a == "-uninstall")
						{
							new Maintenance(Enum74.const_3).ShowDialog();
							return;
						}
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					string[] array2 = array;
					for (int j = 0; j < array2.Length; j++)
					{
						string text2 = array2[j];
						Class34.smethod_18(text2);
					}
					Class34.smethod_18("Microsoft.Xna.Framework.dll");
					flag = true;
				}
			}
			if (Class905.smethod_2() == "osu!test.exe")
			{
				Class34.smethod_18("osu!.exe");
				File.Move("osu!test.exe", "osu!.exe");
				MessageBox.Show("osu! test build no longer runs as a separate executable.\nplease update your shortcuts to point to osu!.exe!", "osu! is changing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Process.Start("osu!.exe");
				return;
			}
			if (!flag)
			{
				string[] array3 = array;
				for (int k = 0; k < array3.Length; k++)
				{
					string path = array3[k];
					if (!File.Exists(path))
					{
						if (new Maintenance(Enum74.const_2).ShowDialog() != DialogResult.Cancel)
						{
							IL_25E:
							string[] files = Directory.GetFiles(".", "*.dll");
							for (int l = 0; l < files.Length; l++)
							{
								string path2 = files[l];
								if ((File.GetAttributes(path2) & FileAttributes.Hidden) == (FileAttributes)0)
								{
									File.SetAttributes(path2, FileAttributes.Hidden);
								}
							}
							string[] files2 = Directory.GetFiles(".", "osu!test*");
							for (int m = 0; m < files2.Length; m++)
							{
								string path3 = files2[m];
								if (Path.GetExtension(path3) != ".exe")
								{
									Class34.smethod_18(path3);
								}
							}
							if (Directory.Exists("Data") && (File.GetAttributes("Data") & FileAttributes.Hidden) == (FileAttributes)0)
							{
								File.SetAttributes("Data", FileAttributes.Hidden);
							}
							Class905.Cleanup();
							Class34.smethod_18("osume.exe");
							if ((!flag && Class905.string_1.Length >= 2 && !(Class905.string_1[1] == "-go")) || !Directory.Exists("_pending"))
							{
								Class905.smethod_3(Class905.string_1);
								return;
							}
							if (!Class214.smethod_6(true))
							{
								Class214.Reset(true);
							}
							Process.Start("osu!.exe", "-go");
							Class905.smethod_12();
						}
						return;
					}
				}
				goto IL_25E;
			}
			Class34.smethod_18(".require_update");
			Class34.smethod_18("help.txt");
			if (new Maintenance(Enum74.const_2).ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			Process.Start("osu!.exe");
		}

		// Token: 0x06003542 RID: 13634
		// RVA: 0x00027005 File Offset: 0x00025205
		internal static string smethod_0()
		{
			string arg_14_0;
			if ((arg_14_0 = Class905.string_0) == null)
			{
				arg_14_0 = (Class905.string_0 = Application.ExecutablePath);
			}
			return arg_14_0;
		}

		// Token: 0x06003543 RID: 13635
		// RVA: 0x0002701B File Offset: 0x0002521B
		internal static string smethod_1()
		{
			return Path.GetFileNameWithoutExtension(Class905.smethod_0());
		}

		// Token: 0x0600354E RID: 13646
		// RVA: 0x00027033 File Offset: 0x00025233
		internal static void smethod_10()
		{
			if (Class115.enum32_0 != Enum32.const_4)
			{
				File.WriteAllBytes(".require_update", new byte[0]);
			}
			Class905.smethod_9(true);
		}

		// Token: 0x0600354F RID: 13647
		// RVA: 0x00027053 File Offset: 0x00025253
		internal static void smethod_11(bool bool_4)
		{
			Process.Start("osu!.exe", bool_4 ? "-fix-framework" : "-repair");
			Class905.smethod_12();
		}

		// Token: 0x06003550 RID: 13648
		// RVA: 0x00027074 File Offset: 0x00025274
		internal static void smethod_12()
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06003551 RID: 13649
		// RVA: 0x0016D22C File Offset: 0x0016B42C
		internal static bool smethod_13(string string_2, bool bool_4)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
			processStartInfo.FileName = Class905.smethod_0();
			if (!string.IsNullOrEmpty(string_2))
			{
				processStartInfo.Arguments = string_2;
			}
			processStartInfo.Verb = "runas";
			try
			{
				Process process = Process.Start(processStartInfo);
				if (bool_4)
				{
					bool result;
					if (process != null && !process.WaitForExit(60000))
					{
						Class792.smethod_0("osu! took a bit too long while trying to perform an elevated operation (" + (string_2 ?? "unknown") + ").\\nPlease report this.");
						result = false;
						return result;
					}
					result = true;
					return result;
				}
			}
			catch
			{
				bool result = false;
				return result;
			}
			Class905.smethod_12();
			return true;
		}

		// Token: 0x06003552 RID: 13650
		// RVA: 0x00027080 File Offset: 0x00025280
		internal static bool smethod_14()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06003553 RID: 13651
		// RVA: 0x0016D2D8 File Offset: 0x0016B4D8
		internal static void smethod_15(string string_2)
		{
			if (string.IsNullOrEmpty(string_2))
			{
				string_2 = Environment.CurrentDirectory;
			}
			if (!Class905.smethod_14())
			{
				Class905.smethod_13("-allowuserwrites " + string_2, true);
				return;
			}
			if (!Directory.Exists(string_2))
			{
				Directory.CreateDirectory(string_2);
			}
			Class34.smethod_25(string_2);
		}

		// Token: 0x06003556 RID: 13654
		// RVA: 0x0016D324 File Offset: 0x0016B524
		internal static bool smethod_16()
		{
			if (Class905.nullable_0.HasValue)
			{
				return Class905.nullable_0.Value;
			}
			IntPtr moduleHandle = Class905.GetModuleHandle("ntdll.dll");
			if (moduleHandle == IntPtr.Zero)
			{
				Class905.nullable_0 = new bool?(false);
			}
			else
			{
				IntPtr procAddress = Class905.GetProcAddress(moduleHandle, "wine_get_version");
				if (procAddress == IntPtr.Zero)
				{
					Class905.nullable_0 = new bool?(false);
				}
				else
				{
					Class905.nullable_0 = new bool?(true);
				}
			}
			return Class905.nullable_0.Value;
		}

		// Token: 0x06003544 RID: 13636
		// RVA: 0x00027027 File Offset: 0x00025227
		internal static string smethod_2()
		{
			return Path.GetFileName(Class905.smethod_0());
		}

		// Token: 0x06003547 RID: 13639
		// RVA: 0x0016CD48 File Offset: 0x0016AF48
		private static void smethod_3(string[] string_2)
		{
			string text = string_2[0].Trim(new char[]
			{
				'"'
			});
			if (text.IndexOf(Path.DirectorySeparatorChar) >= 0)
			{
				Class905.string_0 = text;
			}
			if (string_2.Length > 1 && Class905.smethod_4(ref string_2))
			{
				return;
			}
			bool flag = File.Exists("tournament.cfg");
			string text2 = (string_2.Length > 1) ? string.Join(" ", string_2, 1, string_2.Length - 1) : null;
			bool flag2 = text2 != null || Class905.bool_0 || flag;
			try
			{
				try
				{
					if (!flag2)
					{
						InterProcessOsu interProcessOsu = Class784.smethod_4();
						if (interProcessOsu != null && interProcessOsu.method_1())
						{
							return;
						}
					}
				}
				catch
				{
				}
				using (Class48 class = new Class48(Class905.guid_0, flag2 ? -1 : 5000))
				{
					try
					{
						if (!class.method_0() && text2 != null)
						{
							Class784.smethod_5(text2);
							return;
						}
						Class905.smethod_5(text2, class.method_0(), flag && !Class115.bool_16);
					}
					catch (BadImageFormatException)
					{
						Class905.smethod_11(true);
					}
					catch
					{
					}
				}
			}
			catch (Exception0)
			{
			}
			Class905.smethod_9(false);
		}

		// Token: 0x06003548 RID: 13640
		// RVA: 0x0016CE94 File Offset: 0x0016B094
		private static bool smethod_4(ref string[] string_2)
		{
			string a;
			if ((a = string_2[1]) != null)
			{
				if (a == "-setpermissions")
				{
					Environment.CurrentDirectory = Path.GetDirectoryName(Class905.smethod_0());
					Class115.smethod_31(false);
					return true;
				}
				if (a == "-setassociations")
				{
					Environment.CurrentDirectory = Path.GetDirectoryName(Class905.smethod_0());
					Class115.smethod_31(true);
					return true;
				}
				if (a == "-benchmark")
				{
					Class115.bool_30 = true;
					return false;
				}
				if (a == "-spectateclient")
				{
					Class115.bool_16 = true;
					Class115.int_2 = int.Parse(string_2[2]);
					Class115.string_2 = "osu!-spectator-" + string_2[2];
					string_2 = new string[0];
					return false;
				}
				if (a == "-multi")
				{
					Class905.bool_0 = true;
					string_2 = new string[0];
					return false;
				}
			}
			return false;
		}

		// Token: 0x06003549 RID: 13641
		// RVA: 0x0016CF68 File Offset: 0x0016B168
		private static void smethod_5(string string_2, bool bool_4, bool bool_5)
		{
			if (string_2 != null && string_2.StartsWith("-"))
			{
				string_2 = null;
			}
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Class905.smethod_8);
			Class115.smethod_0(false, false);
			Class115 class = null;
			try
			{
				if (bool_5)
				{
					Class115.bool_16 = true;
					Class115.bool_17 = true;
					Class115.osuModes_0 = OsuModes.Tourney;
				}
				if (!Class905.smethod_16() && !Class115.bool_16)
				{
					Class905.smethod_6();
				}
				Class905.bool_1 = true;
				Process.GetCurrentProcess().PriorityBoostEnabled = true;
				class = new Class115(string_2);
				Class115.bool_15 = bool_4;
				class.Run();
			}
			catch (Exception1)
			{
				if (Class115.long_0 < 10L)
				{
					if (class != null)
					{
						class.method_2(true);
					}
					if (DialogResult.Yes == Class792.smethod_1("Your graphics card does not seem to support Shader Model 1.1+.\nIf you have successfully run osu! in the past, this may indicate that your graphics card is low on memory, in which case you should close some other programs or restart your computer.\nWould you like to swap to OpenGl mode and continue anyway?", "video card error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1))
					{
						Class341.class605_18.Value = "opengl";
						Class341.smethod_3();
						Class905.bool_2 = true;
					}
				}
				else
				{
					Class905.bool_2 = true;
				}
			}
			catch (OutOfVideoMemoryException)
			{
				if (class != null)
				{
					class.method_2(true);
				}
				new ErrorDialog("Your graphics card has run out of memory.  If you are using a custom skin, please try reverting to the default to save on texture memory. Disabling in-game video may also help!", true).ShowDialog();
				Class905.bool_2 = true;
			}
			catch (BadImageFormatException)
			{
				Class905.smethod_11(true);
			}
			catch (MissingManifestResourceException)
			{
				Class905.smethod_11(true);
			}
			catch (UnauthorizedAccessException)
			{
				Class905.bool_2 = true;
			}
			catch (TypeInitializationException)
			{
				Class905.smethod_11(true);
			}
			catch (Exception exception_)
			{
				if (class != null)
				{
					class.method_2(true);
				}
				new ErrorDialog(exception_, true).ShowDialog();
			}
			Class809.smethod_27();
		}

		// Token: 0x0600354A RID: 13642
		// RVA: 0x0016D110 File Offset: 0x0016B310
		private static void smethod_6()
		{
			try
			{
				Class905.Class906 class = new Class905.Class906();
				class.bitmap_0 = Resources.splash;
				new Thread(new ThreadStart(class.method_0))
				{
					IsBackground = true
				}.Start();
			}
			catch
			{
			}
		}

		// Token: 0x0600354B RID: 13643
		// RVA: 0x00006D2A File Offset: 0x00004F2A
		private static Assembly smethod_7(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			return null;
		}

		// Token: 0x0600354C RID: 13644
		// RVA: 0x0016D164 File Offset: 0x0016B364
		private static void smethod_8(object sender, UnhandledExceptionEventArgs e)
		{
			Class905.Class907 class = new Class905.Class907();
			class.unhandledExceptionEventArgs_0 = e;
			if (class.unhandledExceptionEventArgs_0.ExceptionObject is BadImageFormatException || class.unhandledExceptionEventArgs_0.ExceptionObject is TypeInitializationException)
			{
				Class905.smethod_11(true);
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			while (true)
			{
				Thread.Sleep(60000);
			}
		}

		// Token: 0x0600354D RID: 13645
		// RVA: 0x0016D1CC File Offset: 0x0016B3CC
		private static void smethod_9(bool bool_4)
		{
			if (Class905.bool_3)
			{
				return;
			}
			Class905.bool_3 = true;
			if (Class115.enum32_0 == Enum32.const_4 && Class115.osuModes_1 != OsuModes.Exit)
			{
				try
				{
					Process.Start("osu!.exe");
					return;
				}
				catch
				{
					return;
				}
			}
			if (Class905.bool_2 || bool_4)
			{
				Process.Start("osu!.exe");
			}
		}
	}
}
