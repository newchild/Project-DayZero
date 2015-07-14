using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns82
{
	// Token: 0x02000472 RID: 1138
	internal sealed class Class572
	{
		// Token: 0x02000473 RID: 1139
		internal sealed class Class573
		{
			// Token: 0x04001E8C RID: 7820
			internal Enum96 enum96_0;

			// Token: 0x04001E8D RID: 7821
			internal List<Delegate46> list_0 = new List<Delegate46>();

			// Token: 0x060024D6 RID: 9430
			// RVA: 0x0001CC39 File Offset: 0x0001AE39
			public Class573(Enum96 enum96_1)
			{
				this.enum96_0 = enum96_1;
			}
		}

		// Token: 0x02000474 RID: 1140
		[CompilerGenerated]
		private sealed class Class574
		{
			// Token: 0x04001E8E RID: 7822
			public Enum96 enum96_0;

			// Token: 0x060024D8 RID: 9432
			// RVA: 0x0001CC53 File Offset: 0x0001AE53
			public bool method_0(Class572.Class573 class573_0)
			{
				return class573_0.enum96_0 == this.enum96_0;
			}
		}

		// Token: 0x04001E8A RID: 7818
		internal bool bool_0;

		// Token: 0x04001E89 RID: 7817
		internal Enum98 enum98_0;

		// Token: 0x04001E8B RID: 7819
		internal List<Class572.Class573> list_0 = new List<Class572.Class573>();

		// Token: 0x060024D1 RID: 9425
		// RVA: 0x0001CC18 File Offset: 0x0001AE18
		internal Class572(Enum98 enum98_1, bool bool_1)
		{
			this.enum98_0 = enum98_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x060024D4 RID: 9428
		// RVA: 0x000DDB1C File Offset: 0x000DBD1C
		internal bool Invoke(Enum96 enum96_0)
		{
			if (!this.bool_0)
			{
				return false;
			}
			Class572.Class573 class = this.method_2(enum96_0);
			if (class == null)
			{
				return false;
			}
			for (int i = class.list_0.Count - 1; i >= 0; i--)
			{
				Delegate delegate = class.list_0[i];
				Delegate arg_3D_0 = delegate;
				object[] args = new object[2];
				if ((bool)arg_3D_0.DynamicInvoke(args))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060024D2 RID: 9426
		// RVA: 0x000DDAD0 File Offset: 0x000DBCD0
		internal void method_0(Enum96 enum96_0, Delegate46 delegate46_0)
		{
			Class572.Class573 class = this.method_2(enum96_0);
			if (class != null)
			{
				class.list_0.Add(delegate46_0);
			}
		}

		// Token: 0x060024D3 RID: 9427
		// RVA: 0x000DDAF4 File Offset: 0x000DBCF4
		internal void method_1(Enum96 enum96_0, Delegate46 delegate46_0)
		{
			Class572.Class573 class = this.method_2(enum96_0);
			if (class != null)
			{
				class.list_0.Remove(delegate46_0);
			}
		}

		// Token: 0x060024D5 RID: 9429
		// RVA: 0x000DDB80 File Offset: 0x000DBD80
		private Class572.Class573 method_2(Enum96 enum96_0)
		{
			Class572.Class574 class = new Class572.Class574();
			class.enum96_0 = enum96_0;
			Class572.Class573 class2 = this.list_0.Find(new Predicate<Class572.Class573>(class.method_0));
			if (class2 == null)
			{
				this.list_0.Add(class2 = new Class572.Class573(class.enum96_0));
			}
			return class2;
		}
	}
}
