using MonoTorrent.BEncoding;
using System;

namespace ns47
{
	// Token: 0x020002B1 RID: 689
	internal abstract class Class230
	{
		// Token: 0x0600163D RID: 5693
		// RVA: 0x000719E4 File Offset: 0x0006FBE4
		public byte[] Encode()
		{
			byte[] array = new byte[this.vmethod_0()];
			if (this.Encode(array, 0) != array.Length)
			{
				throw new BEncodingException("Error encoding the data");
			}
			return array;
		}

		// Token: 0x0600163E RID: 5694
		public abstract int Encode(byte[] byte_0, int int_0);

		// Token: 0x0600163F RID: 5695
		public abstract int vmethod_0();
	}
}
