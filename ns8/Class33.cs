using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns8
{
	// Token: 0x02000198 RID: 408
	internal static class Class33
	{
		// Token: 0x0400071C RID: 1820
		private static MD5 md5_0 = MD5.Create();

		// Token: 0x0400071E RID: 1822
		private static NumberFormatInfo numberFormatInfo_0 = new CultureInfo("en-US", false).NumberFormat;

		// Token: 0x0400071D RID: 1821
		private static UTF8Encoding utf8Encoding_0 = new UTF8Encoding();

		// Token: 0x06000EAB RID: 3755
		// RVA: 0x0004FA80 File Offset: 0x0004DC80
		public static string smethod_0(string string_0, string string_1, ref string string_2)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			string result = null;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.BlockSize = 256;
				rijndaelManaged.Mode = CipherMode.CBC;
				if (string_2 != null)
				{
					rijndaelManaged.IV = Convert.FromBase64String(string_2);
				}
				else
				{
					rijndaelManaged.GenerateIV();
					string_2 = Convert.ToBase64String(rijndaelManaged.IV);
				}
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes, rijndaelManaged.IV), CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(string_0);
							streamWriter.Close();
						}
						cryptoStream.Close();
					}
					byte[] inArray = memoryStream.ToArray();
					result = Convert.ToBase64String(inArray);
					memoryStream.Close();
				}
				finally
				{
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x06000EAC RID: 3756
		// RVA: 0x0004FB98 File Offset: 0x0004DD98
		public static string smethod_1(string string_0)
		{
			string result;
			lock (Class33.md5_0)
			{
				if (File.Exists(string_0))
				{
					try
					{
						using (Stream stream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
						{
							byte[] array = Class33.md5_0.ComputeHash(stream);
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < array.Length; i++)
							{
								stringBuilder.Append(array[i].ToString("x2"));
							}
							result = stringBuilder.ToString();
							return result;
						}
					}
					catch (Exception)
					{
						result = string.Empty;
						return result;
					}
				}
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000EAD RID: 3757
		// RVA: 0x0000EF60 File Offset: 0x0000D160
		public static string smethod_2(string string_0)
		{
			return Class33.smethod_3(Class33.utf8Encoding_0.GetBytes(string_0));
		}

		// Token: 0x06000EAE RID: 3758
		// RVA: 0x0004FC58 File Offset: 0x0004DE58
		public static string smethod_3(byte[] byte_0)
		{
			lock (Class33.md5_0)
			{
				try
				{
					byte_0 = Class33.md5_0.ComputeHash(byte_0);
				}
				catch (Exception)
				{
					return "fail";
				}
			}
			char[] array = new char[byte_0.Length * 2];
			for (int i = 0; i < byte_0.Length; i++)
			{
				byte_0[i].ToString("x2", Class33.numberFormatInfo_0).CopyTo(0, array, i * 2, 2);
			}
			return new string(array);
		}

		// Token: 0x06000EAF RID: 3759
		// RVA: 0x0004FCF0 File Offset: 0x0004DEF0
		public static byte[] smethod_4(byte[] byte_0)
		{
			lock (Class33.md5_0)
			{
				try
				{
					byte_0 = Class33.md5_0.ComputeHash(byte_0);
				}
				catch (Exception)
				{
					return new byte[0];
				}
			}
			return byte_0;
		}
	}
}
