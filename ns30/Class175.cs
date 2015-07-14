using System;
using System.Text;

namespace ns30
{
	// Token: 0x0200022E RID: 558
	internal sealed class Class175
	{
		// Token: 0x060013A1 RID: 5025
		// RVA: 0x00064CD0 File Offset: 0x00062ED0
		public static string GetString(byte[] byte_0, string string_0)
		{
			if (!Class174.smethod_2(string_0))
			{
				string string;
				try
				{
					string = Encoding.GetEncoding(string_0).GetString(byte_0);
				}
				catch
				{
					goto IL_1C;
				}
				return string;
			}
			IL_1C:
			return Encoding.ASCII.GetString(byte_0);
		}

		// Token: 0x060013A0 RID: 5024
		// RVA: 0x00064C7C File Offset: 0x00062E7C
		public static byte[] smethod_0(string string_0, string string_1)
		{
			if (!Class174.smethod_2(string_1))
			{
				byte[] bytes;
				try
				{
					bytes = Encoding.GetEncoding(string_1).GetBytes(string_0);
				}
				catch (NotSupportedException)
				{
					goto IL_1F;
				}
				catch (ArgumentException)
				{
					goto IL_1F;
				}
				return bytes;
			}
			IL_1F:
			return Encoding.ASCII.GetBytes(string_0);
		}
	}
}
