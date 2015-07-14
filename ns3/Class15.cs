using ns8;
using osu_common.Bancho;
using System;
using System.Collections.Generic;

namespace ns3
{
	// Token: 0x02000179 RID: 377
	internal sealed class Class15 : bSerializable
	{
		// Token: 0x0400064C RID: 1612
		public List<string> list_0;

		// Token: 0x0400064D RID: 1613
		public List<int> list_1;

		// Token: 0x06000E22 RID: 3618
		// RVA: 0x0000EACC File Offset: 0x0000CCCC
		public Class15(int int_0, int int_1)
		{
			this.list_0 = new List<string>(int_0);
			this.list_1 = new List<int>(int_1);
		}

		// Token: 0x06000E23 RID: 3619
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E24 RID: 3620
		// RVA: 0x0004DF24 File Offset: 0x0004C124
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.list_0.Count);
			foreach (string current in this.list_0)
			{
				class31_0.Write(current);
			}
			class31_0.Write(this.list_1.Count);
			foreach (int current2 in this.list_1)
			{
				class31_0.Write(current2);
			}
		}
	}
}
