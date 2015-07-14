using ns8;
using System;
using System.Collections.Generic;

namespace ns79
{
	// Token: 0x0200057D RID: 1405
	internal class Class743
	{
		// Token: 0x04002599 RID: 9625
		internal Class26<Class746> class26_0 = new Class26<Class746>();

		// Token: 0x04002597 RID: 9623
		internal int int_0 = 1;

		// Token: 0x04002598 RID: 9624
		internal int int_1;

		// Token: 0x06002D26 RID: 11558
		// RVA: 0x00022260 File Offset: 0x00020460
		internal Class743(int int_2, int int_3)
		{
			this.int_0 = int_3;
			this.int_1 = int_2;
		}

		// Token: 0x06002D27 RID: 11559
		// RVA: 0x001256DC File Offset: 0x001238DC
		internal Class743 Clone()
		{
			Class743 class = new Class743(this.int_1, this.int_0);
			foreach (Class746 current in this.class26_0)
			{
				class.class26_0.Add(current.Clone());
			}
			return class;
		}

		// Token: 0x06002D28 RID: 11560
		// RVA: 0x00125750 File Offset: 0x00123950
		internal virtual List<Class746> vmethod_0()
		{
			if (this.class26_0.Count == 0)
			{
				return null;
			}
			List<Class746> list = new List<Class746>();
			int num = -1;
			int num2 = -1;
			for (int i = 0; i < this.class26_0.Count; i++)
			{
				if (this.class26_0[i].int_0 < num2 || num2 == -1)
				{
					num2 = this.class26_0[i].int_0;
				}
				if (this.class26_0[i].int_1 > num || num == -1)
				{
					num = this.class26_0[i].int_1;
				}
			}
			int num3 = num - num2;
			for (int j = 0; j < this.class26_0.Count; j++)
			{
				Class746 class = this.class26_0[j].Clone();
				class.bool_1 = true;
				if (this.int_0 > 1)
				{
					class.bool_0 = true;
					class.int_2 = num3 - (class.int_1 - class.int_0);
					class.int_3 = this.int_0;
				}
				class.int_0 += this.int_1;
				class.int_1 += this.int_1;
				list.Add(class);
			}
			return list;
		}
	}
}
