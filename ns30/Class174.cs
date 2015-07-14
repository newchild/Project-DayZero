using System;

namespace ns30
{
	// Token: 0x0200022A RID: 554
	internal sealed class Class174
	{
		// Token: 0x0600137E RID: 4990
		// RVA: 0x00012021 File Offset: 0x00010221
		public static string[] smethod_0(string string_0)
		{
			return Class174.smethod_1(string_0.Replace("\r\n", "\r"), '\r');
		}

		// Token: 0x0600137F RID: 4991
		// RVA: 0x00064460 File Offset: 0x00062660
		public static string[] smethod_1(string string_0, char char_0)
		{
			string[] array = string_0.Split(new char[]
			{
				char_0
			});
			if (array.Length > 0 && array[array.Length - 1].Length == 0)
			{
				string[] array2 = new string[array.Length - 1];
				Array.Copy(array, array2, array.Length - 1);
				return array2;
			}
			return array;
		}

		// Token: 0x06001380 RID: 4992
		// RVA: 0x0001203A File Offset: 0x0001023A
		public static bool smethod_2(string string_0)
		{
			return string_0 == null || string_0.Length == 0;
		}

		// Token: 0x06001381 RID: 4993
		// RVA: 0x000644B0 File Offset: 0x000626B0
		public static long smethod_3(string string_0, long long_0)
		{
			try
			{
				return Convert.ToInt64(string_0);
			}
			catch (Exception)
			{
			}
			return long_0;
		}

		// Token: 0x06001382 RID: 4994
		// RVA: 0x000644DC File Offset: 0x000626DC
		public static int smethod_4(string string_0, int int_0)
		{
			try
			{
				return Convert.ToInt32(string_0);
			}
			catch (Exception)
			{
			}
			return int_0;
		}

		// Token: 0x06001383 RID: 4995
		// RVA: 0x00064508 File Offset: 0x00062708
		public static int smethod_5(string string_0, int int_0, int int_1)
		{
			try
			{
				return Convert.ToInt32(string_0, int_0);
			}
			catch (Exception)
			{
			}
			return int_1;
		}
	}
}
