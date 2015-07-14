using ns37;
using System;
using System.IO;
using System.Text;

namespace ns35
{
	// Token: 0x02000273 RID: 627
	internal sealed class Class212 : Interface11
	{
		// Token: 0x0400100C RID: 4108
		private static readonly char[] char_0;

		// Token: 0x0400100D RID: 4109
		private static readonly char[] char_1;

		// Token: 0x0400100B RID: 4107
		private string string_0;

		// Token: 0x060015B7 RID: 5559
		// RVA: 0x0006EAD4 File Offset: 0x0006CCD4
		static Class212()
		{
			char[] invalidPathChars = Path.GetInvalidPathChars();
			int num = invalidPathChars.Length + 2;
			Class212.char_1 = new char[num];
			Array.Copy(invalidPathChars, 0, Class212.char_1, 0, invalidPathChars.Length);
			Class212.char_1[num - 1] = '*';
			Class212.char_1[num - 2] = '?';
			num = invalidPathChars.Length + 4;
			Class212.char_0 = new char[num];
			Array.Copy(invalidPathChars, 0, Class212.char_0, 0, invalidPathChars.Length);
			Class212.char_0[num - 1] = ':';
			Class212.char_0[num - 2] = '\\';
			Class212.char_0[num - 3] = '*';
			Class212.char_0[num - 4] = '?';
		}

		// Token: 0x060015B5 RID: 5557
		// RVA: 0x00005E0F File Offset: 0x0000400F
		public Class212()
		{
		}

		// Token: 0x060015B6 RID: 5558
		// RVA: 0x00013559 File Offset: 0x00011759
		public Class212(string string_1)
		{
			this.method_0(string_1);
		}

		// Token: 0x060015B9 RID: 5561
		// RVA: 0x0006EB6C File Offset: 0x0006CD6C
		public string imethod_0(string string_1)
		{
			if (string_1 != null)
			{
				string text = string_1.ToLower();
				if (this.string_0 != null && text.IndexOf(this.string_0) == 0)
				{
					string_1 = string_1.Substring(this.string_0.Length);
				}
				if (Path.IsPathRooted(string_1))
				{
					string_1 = string_1.Substring(Path.GetPathRoot(string_1).Length);
				}
				string_1 = string_1.Replace("\\", "/");
				while (string_1.Length > 0)
				{
					if (string_1[0] != '/')
					{
						break;
					}
					string_1 = string_1.Remove(0, 1);
				}
				string_1 = Class212.smethod_0(string_1, '_');
			}
			else
			{
				string_1 = string.Empty;
			}
			return string_1;
		}

		// Token: 0x060015B8 RID: 5560
		// RVA: 0x00013568 File Offset: 0x00011768
		public string imethod_1(string string_1)
		{
			string_1 = this.imethod_0(string_1);
			if (string_1.Length > 0)
			{
				if (!string_1.EndsWith("/"))
				{
					string_1 += "/";
				}
				return string_1;
			}
			throw new Exception8("Cannot have an empty directory name");
		}

		// Token: 0x060015BA RID: 5562
		// RVA: 0x000135A4 File Offset: 0x000117A4
		public void method_0(string string_1)
		{
			this.string_0 = string_1;
			if (this.string_0 != null)
			{
				this.string_0 = this.string_0.ToLower();
			}
		}

		// Token: 0x060015BB RID: 5563
		// RVA: 0x0006EC14 File Offset: 0x0006CE14
		private static string smethod_0(string string_1, char char_2)
		{
			int i = string_1.IndexOfAny(Class212.char_0);
			if (i > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(string_1);
				while (i >= 0)
				{
					stringBuilder[i] = char_2;
					if (i >= string_1.Length)
					{
						i = -1;
					}
					else
					{
						i = string_1.IndexOfAny(Class212.char_0, i + 1);
					}
				}
				string_1 = stringBuilder.ToString();
			}
			return string_1;
		}

		// Token: 0x060015BC RID: 5564
		// RVA: 0x0006EC6C File Offset: 0x0006CE6C
		public static bool smethod_1(string string_1, bool bool_0)
		{
			bool result;
			if (result = (string_1 != null))
			{
				if (bool_0)
				{
					result = (string_1.IndexOfAny(Class212.char_1) < 0);
				}
				else
				{
					result = (string_1.IndexOfAny(Class212.char_0) < 0 && string_1.IndexOf('/') != 0);
				}
			}
			return result;
		}
	}
}
