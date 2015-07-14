using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200016E RID: 366
	internal struct Struct12 : bSerializable
	{
		// Token: 0x040005F2 RID: 1522
		public int int_0;

		// Token: 0x06000DF8 RID: 3576
		// RVA: 0x0000E98E File Offset: 0x0000CB8E
		public Struct12(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000DF9 RID: 3577
		// RVA: 0x0000E997 File Offset: 0x0000CB97
		public Struct12(Class32 class32_0)
		{
			this.int_0 = class32_0.ReadInt32();
		}

		// Token: 0x06000DFA RID: 3578
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DFB RID: 3579
		// RVA: 0x0000E9A5 File Offset: 0x0000CBA5
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.int_0);
		}
	}
}
