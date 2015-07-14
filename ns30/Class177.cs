using System;
using System.IO;

namespace ns30
{
	// Token: 0x02000230 RID: 560
	internal sealed class Class177
	{
		// Token: 0x04000EAF RID: 3759
		private static int int_0 = 50;

		// Token: 0x060013AC RID: 5036
		// RVA: 0x00064F04 File Offset: 0x00063104
		public static string smethod_0(string string_0)
		{
			string fileName = Path.GetFileName(string_0);
			if (fileName == null)
			{
				return string.Empty;
			}
			return fileName;
		}

		// Token: 0x060013AD RID: 5037
		// RVA: 0x00012162 File Offset: 0x00010362
		public static int smethod_1(byte[] byte_0, byte[] byte_1, int int_1)
		{
			return Class177.smethod_2(byte_0, byte_1, int_1, byte_1.Length);
		}

		// Token: 0x060013AE RID: 5038
		// RVA: 0x00064F24 File Offset: 0x00063124
		public static int smethod_2(byte[] byte_0, byte[] byte_1, int int_1, int int_2)
		{
			int num = 0;
			int num2 = byte_0.Length;
			for (int i = int_1; i < int_2; i++)
			{
				if (byte_1[i] == byte_0[num])
				{
					num++;
					if (num == num2)
					{
						return i - num2 + 1;
					}
				}
				else
				{
					num = 0;
				}
			}
			return -1;
		}
	}
}
