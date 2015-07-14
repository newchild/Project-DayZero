using System;

namespace ns46
{
	// Token: 0x020002AB RID: 683
	internal abstract class Class224
	{
		// Token: 0x0600160E RID: 5646
		// RVA: 0x000715D0 File Offset: 0x0006F7D0
		public static int smethod_0(byte[] byte_0, int int_0, string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Class224.Write(byte_0, int_0 + i, (byte)string_0[i]);
			}
			return string_0.Length;
		}

		// Token: 0x0600160B RID: 5643
		// RVA: 0x00013946 File Offset: 0x00011B46
		public static int Write(byte[] byte_0, int int_0, byte byte_1)
		{
			byte_0[int_0] = byte_1;
			return 1;
		}

		// Token: 0x0600160D RID: 5645
		// RVA: 0x0001395C File Offset: 0x00011B5C
		public static int Write(byte[] byte_0, int int_0, byte[] byte_1)
		{
			return Class224.Write(byte_0, int_0, byte_1, 0, byte_1.Length);
		}

		// Token: 0x0600160C RID: 5644
		// RVA: 0x0001394D File Offset: 0x00011B4D
		public static int Write(byte[] byte_0, int int_0, byte[] byte_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(byte_1, int_1, byte_0, int_0, int_2);
			return int_2;
		}
	}
}
