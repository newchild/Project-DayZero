using ns8;
using osu_common.Bancho;
using System;
using System.Collections.Generic;

namespace ns3
{
	// Token: 0x0200017A RID: 378
	internal sealed class Class16 : bSerializable
	{
		// Token: 0x0400064E RID: 1614
		public List<Class8> list_0 = new List<Class8>();

		// Token: 0x06000E25 RID: 3621
		// RVA: 0x0004DFE0 File Offset: 0x0004C1E0
		public Class16(Class32 class32_0)
		{
			int num = class32_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				this.list_0.Add(new Class8(class32_0));
			}
		}

		// Token: 0x06000E26 RID: 3622
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E27 RID: 3623
		// RVA: 0x0004E024 File Offset: 0x0004C224
		public void WriteToStream(Class31 class31_0)
		{
			int count = this.list_0.Count;
			class31_0.Write(count);
			for (int i = 0; i < count; i++)
			{
				this.list_0[i].WriteToStream(class31_0);
			}
		}
	}
}
