using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

namespace ns8
{
	// Token: 0x02000199 RID: 409
	internal static class Class34
	{
		// Token: 0x0200019B RID: 411
		internal static class Class35
		{
			// Token: 0x06000ECD RID: 3789
			[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern bool MoveFileEx(string string_0, string string_1, Class34.Enum6 enum6_0);
		}

		// Token: 0x0200019A RID: 410
		[Flags]
		internal enum Enum6
		{
			// Token: 0x04000720 RID: 1824
			flag_0 = 0,
			// Token: 0x04000721 RID: 1825
			flag_1 = 1,
			// Token: 0x04000722 RID: 1826
			flag_2 = 2,
			// Token: 0x04000723 RID: 1827
			flag_3 = 4,
			// Token: 0x04000724 RID: 1828
			flag_4 = 8,
			// Token: 0x04000725 RID: 1829
			flag_5 = 16,
			// Token: 0x04000726 RID: 1830
			flag_6 = 32
		}

		// Token: 0x06000EBE RID: 3774
		// RVA: 0x0000E57E File Offset: 0x0000C77E
		public static char IntToHex(int int_0)
		{
			if (int_0 <= 9)
			{
				return (char)(int_0 + 48);
			}
			return (char)(int_0 - 10 + 97);
		}

		// Token: 0x06000EB1 RID: 3761
		// RVA: 0x0004FD4C File Offset: 0x0004DF4C
		public static string smethod_0(string string_0)
		{
			string text = string.Empty;
			for (int i = 0; i < string_0.Length; i++)
			{
				if (i > 0 && char.IsUpper(string_0[i]))
				{
					text += " ";
				}
				text += string_0[i];
			}
			return text;
		}

		// Token: 0x06000EB2 RID: 3762
		// RVA: 0x0004FDA4 File Offset: 0x0004DFA4
		public static string smethod_1(string string_0)
		{
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			for (int i = 0; i < invalidFileNameChars.Length; i++)
			{
				char c = invalidFileNameChars[i];
				string_0 = string_0.Replace(c.ToString(), string.Empty);
			}
			return string_0;
		}

		// Token: 0x06000EBB RID: 3771
		// RVA: 0x000501CC File Offset: 0x0004E3CC
		public static byte[] smethod_10(string string_0, Encoding encoding_0, bool bool_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			byte[] bytes = encoding_0.GetBytes(string_0);
			return Class34.smethod_11(bytes, 0, bytes.Length, false, bool_0);
		}

		// Token: 0x06000EBC RID: 3772
		// RVA: 0x000501F4 File Offset: 0x0004E3F4
		private static byte[] smethod_11(byte[] byte_0, int int_0, int int_1, bool bool_0, bool bool_1)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < int_1; i++)
			{
				char c = (char)byte_0[int_0 + i];
				if (bool_1 && c == ' ')
				{
					num++;
				}
				else if (!Class34.smethod_12(c))
				{
					num2++;
				}
			}
			if (!bool_0 && num == 0 && num2 == 0)
			{
				return byte_0;
			}
			byte[] array = new byte[int_1 + num2 * 2];
			int num3 = 0;
			for (int j = 0; j < int_1; j++)
			{
				byte b = byte_0[int_0 + j];
				char c2 = (char)b;
				if (Class34.smethod_12(c2))
				{
					array[num3++] = b;
				}
				else if (bool_1 && c2 == ' ')
				{
					array[num3++] = 43;
				}
				else
				{
					array[num3++] = 37;
					array[num3++] = (byte)Class34.IntToHex(b >> 4 & 15);
					array[num3++] = (byte)Class34.IntToHex((int)(b & 15));
				}
			}
			return array;
		}

		// Token: 0x06000EBD RID: 3773
		// RVA: 0x000502D4 File Offset: 0x0004E4D4
		public static bool smethod_12(char char_0)
		{
			if ((char_0 >= 'a' && char_0 <= 'z') || (char_0 >= 'A' && char_0 <= 'Z') || (char_0 >= '0' && char_0 <= '9'))
			{
				return true;
			}
			if (char_0 != '!')
			{
				switch (char_0)
				{
				case '\'':
				case '(':
				case ')':
				case '*':
				case '-':
				case '.':
					return true;
				case '+':
				case ',':
					break;
				default:
					if (char_0 == '_')
					{
						return true;
					}
					break;
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000EBF RID: 3775
		// RVA: 0x0005033C File Offset: 0x0004E53C
		public static void smethod_13(string string_0)
		{
			string[] files = Directory.GetFiles(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = files[i];
				FileInfo fileInfo = new FileInfo(fileName);
				if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
				{
					fileInfo.Attributes &= ~FileAttributes.ReadOnly;
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = 0; j < directories.Length; j++)
			{
				string string_ = directories[j];
				Class34.smethod_13(string_);
			}
		}

		// Token: 0x06000EC0 RID: 3776
		// RVA: 0x000503B0 File Offset: 0x0004E5B0
		public static bool smethod_14(string string_0, string string_1, bool bool_0, bool bool_1)
		{
			string_0 = Class34.smethod_15(string_0);
			string_1 = Class34.smethod_15(string_1);
			if (string_0 == string_1)
			{
				return true;
			}
			bool result;
			try
			{
				if (bool_0)
				{
					Class34.smethod_18(string_1);
				}
				File.Move(string_0, string_1);
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000EC1 RID: 3777
		// RVA: 0x00050404 File Offset: 0x0004E604
		public static string smethod_15(string string_0)
		{
			return string_0.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar).TrimEnd(new char[]
			{
				Path.DirectorySeparatorChar
			});
		}

		// Token: 0x06000EC2 RID: 3778
		// RVA: 0x0000EFDC File Offset: 0x0000D1DC
		public static string smethod_16(string string_0)
		{
			return string_0.Replace(Path.DirectorySeparatorChar, '/');
		}

		// Token: 0x06000EC3 RID: 3779
		// RVA: 0x00050440 File Offset: 0x0004E640
		public static bool smethod_17(string string_0)
		{
			string_0 = Class34.smethod_15(string_0);
			try
			{
				File.Delete(string_0);
				return true;
			}
			catch
			{
			}
			string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			try
			{
				File.Move(string_0, text);
			}
			catch
			{
				text = string_0;
			}
			return Class34.Class35.MoveFileEx(text, null, Class34.Enum6.flag_3);
		}

		// Token: 0x06000EC4 RID: 3780
		// RVA: 0x000504B4 File Offset: 0x0004E6B4
		public static bool smethod_18(string string_0)
		{
			string_0 = Class34.smethod_15(string_0);
			if (!File.Exists(string_0))
			{
				return false;
			}
			try
			{
				File.Delete(string_0);
				bool result = true;
				return result;
			}
			catch
			{
			}
			try
			{
				if (!Directory.Exists("_cleanup"))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory("_cleanup");
					directoryInfo.Attributes |= FileAttributes.Hidden;
				}
				File.Move(string_0, "_cleanup/" + Guid.NewGuid());
				bool result = true;
				return result;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000EC5 RID: 3781
		// RVA: 0x00050548 File Offset: 0x0004E748
		public static string smethod_19(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			string_0 = Class34.smethod_16(string_0);
			int num = string_0.LastIndexOf('/');
			string text = (num >= 0) ? string_0.Substring(0, num + 1) : string.Empty;
			string text2 = (num >= 0) ? string_0.Remove(0, num + 1) : string_0;
			for (int i = 0; i < text2.Length; i++)
			{
				char c = text2[i];
				if (c <= '~')
				{
					text += c;
				}
			}
			return text;
		}

		// Token: 0x06000EB3 RID: 3763
		// RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		public static string smethod_2(string string_0)
		{
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			for (int i = 0; i < invalidFileNameChars.Length; i++)
			{
				char c = invalidFileNameChars[i];
				string_0 = string_0.Replace(c.ToString(), string.Empty);
			}
			string_0 = string_0.Replace(".", string.Empty);
			return string_0;
		}

		// Token: 0x06000EC6 RID: 3782
		// RVA: 0x000505C4 File Offset: 0x0004E7C4
		public static void smethod_20(string string_0, string string_1)
		{
			string_0 = Class34.smethod_15(string_0);
			string_1 = Class34.smethod_15(string_1);
			if (string_0 == "Songs" + Path.DirectorySeparatorChar)
			{
				return;
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < directories.Length; i++)
			{
				string text = directories[i];
				string text2 = text;
				text2 = Path.Combine(string_1, text2.Remove(0, 1 + text2.LastIndexOf(Path.DirectorySeparatorChar)));
				try
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(text2);
					if ((new DirectoryInfo(text).Attributes & FileAttributes.Hidden) > (FileAttributes)0)
					{
						directoryInfo.Attributes |= FileAttributes.Hidden;
					}
				}
				catch
				{
				}
				Class34.smethod_20(text, text2);
			}
			bool bool_;
			if (!(bool_ = Directory.Exists(string_1)))
			{
				DirectoryInfo directoryInfo2 = Directory.CreateDirectory(string_1);
				try
				{
					if ((new DirectoryInfo(string_0).Attributes & FileAttributes.Hidden) > (FileAttributes)0)
					{
						directoryInfo2.Attributes |= FileAttributes.Hidden;
					}
				}
				catch
				{
				}
			}
			string[] files = Directory.GetFiles(string_0);
			for (int j = 0; j < files.Length; j++)
			{
				string text3 = files[j];
				string text4 = Path.Combine(string_1, Path.GetFileName(text3));
				if (!Class34.smethod_14(text3, text4, bool_, false))
				{
					try
					{
						File.Copy(text3, text4);
						goto IL_11A;
					}
					catch
					{
						goto IL_11A;
					}
					goto IL_112;
					IL_11A:
					File.Delete(text3);
				}
				IL_112:;
			}
			Directory.Delete(string_0, true);
		}

		// Token: 0x06000EC7 RID: 3783
		// RVA: 0x00050724 File Offset: 0x0004E924
		public static int smethod_21(string string_0)
		{
			int num = string_0.Length;
			string[] files = Directory.GetFiles(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string text = files[i];
				if (text.Length > num)
				{
					num = text.Length;
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = 0; j < directories.Length; j++)
			{
				string string_ = directories[j];
				int num2 = Class34.smethod_21(string_);
				if (num2 > num)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x06000EC8 RID: 3784
		// RVA: 0x00050798 File Offset: 0x0004E998
		public static string smethod_22(string string_0)
		{
			return Class34.smethod_16(string_0.Trim(new char[]
			{
				'"'
			}));
		}

		// Token: 0x06000EC9 RID: 3785
		// RVA: 0x000507C0 File Offset: 0x0004E9C0
		public static byte[] smethod_23(string string_0)
		{
			int length = string_0.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x06000ECA RID: 3786
		// RVA: 0x00050800 File Offset: 0x0004EA00
		public unsafe static bool smethod_24(byte[] byte_0, byte[] byte_1)
		{
			if (byte_0 != null && byte_1 != null)
			{
				if (byte_0.Length == byte_1.Length)
				{
					byte* ptr;
					if (byte_0 != null && byte_0.Length != 0)
					{
						fixed (byte* ptr = &byte_0[0])
						{
						}
					}
					else
					{
						ptr = null;
					}
					byte* ptr2;
					if (byte_1 != null && byte_1.Length != 0)
					{
						fixed (byte* ptr2 = &byte_1[0])
						{
						}
					}
					else
					{
						ptr2 = null;
					}
					byte* ptr3 = ptr;
					byte* ptr4 = ptr2;
					int num = byte_0.Length;
					int i = 0;
					bool result;
					while (i < num / 8)
					{
						if (*(long*)ptr3 != *(long*)ptr4)
						{
							result = false;
							return result;
						}
						i++;
						ptr3 += 8;
						ptr4 += 8;
					}
					if ((num & 4) != 0)
					{
						if (*(int*)ptr3 != *(int*)ptr4)
						{
							result = false;
							return result;
						}
						ptr3 += 4;
						ptr4 += 4;
					}
					if ((num & 2) != 0)
					{
						if (*(short*)ptr3 != *(short*)ptr4)
						{
							result = false;
							return result;
						}
						ptr3 += 2;
						ptr4 += 2;
					}
					if ((num & 1) != 0 && *ptr3 != *ptr4)
					{
						result = false;
						return result;
					}
					result = true;
					return result;
				}
			}
			return false;
		}

		// Token: 0x06000ECB RID: 3787
		// RVA: 0x000508E0 File Offset: 0x0004EAE0
		public static bool smethod_25(string string_0)
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
			NTAccount nTAccount = securityIdentifier.Translate(typeof(NTAccount)) as NTAccount;
			string string_ = nTAccount.ToString();
			bool result;
			try
			{
				Class34.smethod_6(string_0, string_, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
				Class34.smethod_6(string_0, string_, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
				Class34.smethod_13(string_0);
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000ECC RID: 3788
		// RVA: 0x00050954 File Offset: 0x0004EB54
		internal static string smethod_26(string string_0, string string_1)
		{
			string_0 = Class34.smethod_16(string_0).TrimEnd(new char[]
			{
				'/'
			});
			string_1 = Class34.smethod_16(string_1).TrimEnd(new char[]
			{
				'/'
			});
			if (string_0.Length < string_1.Length + 1 || string_0[string_1.Length] != '/' || !string_0.StartsWith(string_1))
			{
				throw new ArgumentException(string_0 + " isn't contained in " + string_1);
			}
			return string_0.Substring(string_1.Length + 1);
		}

		// Token: 0x06000EB4 RID: 3764
		// RVA: 0x0004FE2C File Offset: 0x0004E02C
		public static bool smethod_3(string string_0, string string_1)
		{
			try
			{
				using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(string_0))
				{
					bool result;
					if (registryKey != null && !(registryKey.OpenSubKey("shell\\open\\command").GetValue(string.Empty).ToString() != string.Format("\"{0}\" \"%1\"", string_1)))
					{
						result = true;
						return result;
					}
					result = false;
					return result;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000EB5 RID: 3765
		// RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public static bool smethod_4(string string_0, string string_1, string string_2, string string_3, bool bool_0)
		{
			bool result;
			try
			{
				if (!string.IsNullOrEmpty(string_0))
				{
					if (string_0[0] != '.')
					{
						string_0 = "." + string_0;
					}
					using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(string_0, true))
					{
						if (registryKey == null)
						{
							using (RegistryKey registryKey2 = Registry.ClassesRoot.CreateSubKey(string_0))
							{
								registryKey2.SetValue(string.Empty, string_1);
								goto IL_60;
							}
						}
						registryKey.SetValue(string.Empty, string_1);
						IL_60:;
					}
				}
				using (RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey(string_1))
				{
					if (registryKey3 != null && !(registryKey3.OpenSubKey("shell\\open\\command").GetValue(string.Empty).ToString() != string.Format("\"{0}\" \"%1\"", string_3)))
					{
						if (registryKey3.OpenSubKey("DefaultIcon").GetValue(string.Empty) != null)
						{
							goto IL_1B1;
						}
						using (RegistryKey registryKey4 = Registry.ClassesRoot.CreateSubKey(string_1))
						{
							using (RegistryKey registryKey5 = registryKey4.CreateSubKey("DefaultIcon"))
							{
								registryKey5.SetValue(string.Empty, string.Format("\"{0}\",1", string_3));
							}
							goto IL_1B1;
						}
					}
					using (RegistryKey registryKey6 = Registry.ClassesRoot.CreateSubKey(string_1))
					{
						registryKey6.SetValue(string.Empty, string_2);
						if (bool_0)
						{
							registryKey6.SetValue("URL Protocol", string.Empty);
						}
						using (RegistryKey registryKey7 = registryKey6.CreateSubKey("shell\\open\\command"))
						{
							registryKey7.SetValue(string.Empty, string.Format("\"{0}\" \"%1\"", string_3));
						}
						using (RegistryKey registryKey8 = registryKey6.CreateSubKey("DefaultIcon"))
						{
							registryKey8.SetValue(string.Empty, string.Format("\"{0}\",1", string_3));
						}
					}
					IL_1B1:;
				}
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000EB6 RID: 3766
		// RVA: 0x0005015C File Offset: 0x0004E35C
		public static void smethod_5(string string_0)
		{
			try
			{
				if (Registry.ClassesRoot.OpenSubKey(string_0) != null)
				{
					Registry.ClassesRoot.DeleteSubKeyTree(string_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000EB7 RID: 3767
		// RVA: 0x00050198 File Offset: 0x0004E398
		public static void smethod_6(string string_0, string string_1, FileSystemRights fileSystemRights_0, InheritanceFlags inheritanceFlags_0, PropagationFlags propagationFlags_0, AccessControlType accessControlType_0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl();
			accessControl.AddAccessRule(new FileSystemAccessRule(string_1, fileSystemRights_0, inheritanceFlags_0, propagationFlags_0, accessControlType_0));
			directoryInfo.SetAccessControl(accessControl);
		}

		// Token: 0x06000EB8 RID: 3768
		// RVA: 0x0000EF9D File Offset: 0x0000D19D
		public static string smethod_7(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			return Class34.smethod_9(string_0, Encoding.UTF8, false);
		}

		// Token: 0x06000EB9 RID: 3769
		// RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		public static string smethod_8(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			return Class34.smethod_9(string_0, Encoding.UTF8, true);
		}

		// Token: 0x06000EBA RID: 3770
		// RVA: 0x0000EFC3 File Offset: 0x0000D1C3
		public static string smethod_9(string string_0, Encoding encoding_0, bool bool_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			return Encoding.ASCII.GetString(Class34.smethod_10(string_0, encoding_0, bool_0));
		}
	}
}
