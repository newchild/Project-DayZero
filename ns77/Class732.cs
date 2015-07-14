using System;
using System.IO;

namespace ns77
{
	// Token: 0x0200056A RID: 1386
	internal sealed class Class732 : BinaryReader
	{
		// Token: 0x06002CDC RID: 11484
		// RVA: 0x00021F80 File Offset: 0x00020180
		public Class732(Stream stream_0) : base(stream_0)
		{
		}

		// Token: 0x06002CDD RID: 11485
		// RVA: 0x0012291C File Offset: 0x00120B1C
		public int method_0()
		{
			int num = 0;
			int num2 = 0;
			while (num2 != 35)
			{
				byte b = this.ReadByte();
				num |= (int)(b & 127) << num2;
				num2 += 7;
				if ((b & 128) == 0)
				{
					return num;
				}
			}
			return -1;
		}
	}
}
