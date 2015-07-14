using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200017E RID: 382
	internal struct Struct16 : bSerializable
	{
		// Token: 0x0400065C RID: 1628
		public readonly string string_0;

		// Token: 0x06000E32 RID: 3634
		// RVA: 0x0000EB1F File Offset: 0x0000CD1F
		public Struct16(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000E33 RID: 3635
		// RVA: 0x0000EB28 File Offset: 0x0000CD28
		public Struct16(Class32 class32_0)
		{
			this.string_0 = class32_0.ReadString();
		}

		// Token: 0x06000E34 RID: 3636
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E35 RID: 3637
		// RVA: 0x0000EB36 File Offset: 0x0000CD36
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.string_0);
		}
	}
}
