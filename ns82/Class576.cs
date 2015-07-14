using osu.Input;
using System;
using System.Collections.Generic;

namespace ns82
{
	// Token: 0x02000477 RID: 1143
	internal sealed class Class576
	{
		// Token: 0x04001E94 RID: 7828
		internal int int_0;

		// Token: 0x04001E97 RID: 7831
		private int int_1 = -1;

		// Token: 0x04001E96 RID: 7830
		private List<Class577> list_0 = new List<Class577>();

		// Token: 0x04001E95 RID: 7829
		internal ManiaLayoutsFor maniaLayoutsFor_0;

		// Token: 0x17000382 RID: 898
		internal Class577 this[int int_2]
		{
			// Token: 0x060024E0 RID: 9440
			// RVA: 0x0001CCBE File Offset: 0x0001AEBE
			get
			{
				if (int_2 >= 0 && int_2 < this.list_0.Count)
				{
					return this.list_0[int_2];
				}
				return null;
			}
		}

		// Token: 0x060024E2 RID: 9442
		// RVA: 0x0001CCEE File Offset: 0x0001AEEE
		internal Class576(int int_2, ManiaLayoutsFor maniaLayoutsFor_1)
		{
			this.int_0 = int_2;
			this.maniaLayoutsFor_0 = maniaLayoutsFor_1;
		}

		// Token: 0x060024E3 RID: 9443
		// RVA: 0x000DDDD4 File Offset: 0x000DBFD4
		internal void Add(string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string string_ = array[i];
				this.list_0.Add(new Class577(this.int_0, this.maniaLayoutsFor_0, string_));
			}
		}

		// Token: 0x060024E5 RID: 9445
		// RVA: 0x0001CD2E File Offset: 0x0001AF2E
		internal void Insert(int int_2, Class577 class577_0)
		{
			this.list_0.Insert(int_2, class577_0 ?? this.method_3());
		}

		// Token: 0x060024DE RID: 9438
		// RVA: 0x0001CC96 File Offset: 0x0001AE96
		internal int method_0()
		{
			return this.int_1;
		}

		// Token: 0x060024DF RID: 9439
		// RVA: 0x0001CC9E File Offset: 0x0001AE9E
		internal void method_1(int int_2)
		{
			this.int_1 = ((int_2 < this.list_0.Count) ? Math.Max(int_2, -1) : -1);
		}

		// Token: 0x060024E1 RID: 9441
		// RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		internal Class577 method_2()
		{
			return this[this.method_0()];
		}

		// Token: 0x060024E4 RID: 9444
		// RVA: 0x0001CD16 File Offset: 0x0001AF16
		internal Class577 method_3()
		{
			return new Class577(this.int_0, this.maniaLayoutsFor_0, "");
		}

		// Token: 0x060024E6 RID: 9446
		// RVA: 0x000DDE24 File Offset: 0x000DC024
		public override string ToString()
		{
			string text = string.Empty;
			foreach (Class577 current in this.list_0)
			{
				text = text + current.ToString() + ';';
			}
			return text.TrimEnd(new char[]
			{
				';'
			});
		}
	}
}
