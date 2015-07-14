using System;
using System.Text;
using System.Threading;

namespace ns35
{
	// Token: 0x02000264 RID: 612
	internal sealed class Class204
	{
		// Token: 0x04000FC4 RID: 4036
		private static int int_0 = Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage;

		// Token: 0x0600152A RID: 5418
		// RVA: 0x00012DC1 File Offset: 0x00010FC1
		public static int smethod_0()
		{
			return Class204.int_0;
		}

		// Token: 0x0600152B RID: 5419
		// RVA: 0x00012DC8 File Offset: 0x00010FC8
		public static void smethod_1(int int_1)
		{
			Class204.int_0 = int_1;
		}

		// Token: 0x0600152C RID: 5420
		// RVA: 0x00012DD0 File Offset: 0x00010FD0
		public static string smethod_2(byte[] byte_0, int int_1)
		{
			if (byte_0 == null)
			{
				return string.Empty;
			}
			return Encoding.GetEncoding(Class204.smethod_0()).GetString(byte_0, 0, int_1);
		}

		// Token: 0x0600152D RID: 5421
		// RVA: 0x00012DED File Offset: 0x00010FED
		public static string smethod_3(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				return string.Empty;
			}
			return Class204.smethod_2(byte_0, byte_0.Length);
		}

		// Token: 0x0600152E RID: 5422
		// RVA: 0x00012E01 File Offset: 0x00011001
		public static string smethod_4(int int_1, byte[] byte_0, int int_2)
		{
			if (byte_0 == null)
			{
				return string.Empty;
			}
			if ((int_1 & 2048) != 0)
			{
				return Encoding.UTF8.GetString(byte_0, 0, int_2);
			}
			return Class204.smethod_2(byte_0, int_2);
		}

		// Token: 0x0600152F RID: 5423
		// RVA: 0x00012E2A File Offset: 0x0001102A
		public static string smethod_5(int int_1, byte[] byte_0)
		{
			if (byte_0 == null)
			{
				return string.Empty;
			}
			if ((int_1 & 2048) != 0)
			{
				return Encoding.UTF8.GetString(byte_0, 0, byte_0.Length);
			}
			return Class204.smethod_2(byte_0, byte_0.Length);
		}

		// Token: 0x06001530 RID: 5424
		// RVA: 0x00012E57 File Offset: 0x00011057
		public static byte[] smethod_6(string string_0)
		{
			if (string_0 == null)
			{
				return new byte[0];
			}
			return Encoding.GetEncoding(Class204.smethod_0()).GetBytes(string_0);
		}

		// Token: 0x06001531 RID: 5425
		// RVA: 0x00012E73 File Offset: 0x00011073
		public static byte[] smethod_7(int int_1, string string_0)
		{
			if (string_0 == null)
			{
				return new byte[0];
			}
			if ((int_1 & 2048) != 0)
			{
				return Encoding.UTF8.GetBytes(string_0);
			}
			return Class204.smethod_6(string_0);
		}
	}
}
