using ns8;
using osu_common.Bancho;
using System;
using System.Collections.Generic;

namespace ns3
{
	// Token: 0x0200017B RID: 379
	internal struct Struct14 : bSerializable
	{
		// Token: 0x0400064F RID: 1615
		public readonly List<int> list_0;

		// Token: 0x06000E28 RID: 3624
		// RVA: 0x0000EAEC File Offset: 0x0000CCEC
		public Struct14(List<int> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x06000E29 RID: 3625
		// RVA: 0x0004E064 File Offset: 0x0004C264
		public Struct14(Class32 class32_0)
		{
			this.list_0 = new List<int>();
			int num = (int)class32_0.ReadInt16();
			for (int i = 0; i < num; i++)
			{
				this.list_0.Add(class32_0.ReadInt32());
			}
		}

		// Token: 0x06000E2A RID: 3626
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E2B RID: 3627
		// RVA: 0x0004E0A0 File Offset: 0x0004C2A0
		public void WriteToStream(Class31 class31_0)
		{
			int count = this.list_0.Count;
			class31_0.Write((short)count);
			for (int i = 0; i < count; i++)
			{
				class31_0.Write(this.list_0[i]);
			}
		}
	}
}
