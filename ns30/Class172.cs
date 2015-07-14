using System;
using System.IO;

namespace ns30
{
	// Token: 0x02000225 RID: 549
	internal sealed class Class172
	{
		// Token: 0x06001368 RID: 4968
		// RVA: 0x00064074 File Offset: 0x00062274
		public static long smethod_0(Stream stream_0, Stream stream_1, long long_0)
		{
			if (long_0 == 0L)
			{
				stream_0.Position = 0L;
				long_0 = stream_0.Length;
			}
			long result = long_0;
			byte[] array = new byte[61440];
			int num = (int)long_0;
			if (num > array.Length)
			{
				num = array.Length;
			}
			while (long_0 != 0L)
			{
				int num2 = (int)long_0;
				if (long_0 > (long)num)
				{
					num2 = num;
				}
				stream_0.Read(array, 0, num2);
				stream_1.Write(array, 0, num2);
				long_0 -= (long)num2;
			}
			return result;
		}
	}
}
