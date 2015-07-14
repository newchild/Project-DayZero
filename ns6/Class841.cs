using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns78;
using ns8;
using System;

namespace ns6
{
	// Token: 0x0200063B RID: 1595
	internal sealed class Class841
	{
		// Token: 0x04002D10 RID: 11536
		internal Class40 class40_0;

		// Token: 0x04002D11 RID: 11537
		private Class578 class578_0;

		// Token: 0x04002D0F RID: 11535
		internal Class861 class861_0;

		// Token: 0x04002D0B RID: 11531
		internal Color color_0;

		// Token: 0x04002D0E RID: 11534
		internal DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04002D0C RID: 11532
		internal string string_0;

		// Token: 0x04002D0D RID: 11533
		internal string string_1;

		// Token: 0x06003152 RID: 12626
		// RVA: 0x00024771 File Offset: 0x00022971
		internal Class841(string string_2, string string_3, Color color_1)
		{
			this.string_1 = string_2;
			this.string_0 = string_3;
			this.color_0 = color_1;
		}

		// Token: 0x06003151 RID: 12625
		// RVA: 0x00024741 File Offset: 0x00022941
		internal Class841(Class861 class861_1, string string_2, string string_3, Color color_1)
		{
			this.class861_0 = class861_1;
			this.string_1 = string_2;
			this.string_0 = string_3;
			this.color_0 = color_1;
		}

		// Token: 0x0600314E RID: 12622
		// RVA: 0x000246F1 File Offset: 0x000228F1
		internal Class578 method_0()
		{
			if (this.class578_0 == null)
			{
				this.class578_0 = new Class578(Vector2.get_Zero(), 0.97f, 12f, (float)(Class115.smethod_43() - 10), this, Class111.string_0);
			}
			return this.class578_0;
		}

		// Token: 0x0600314F RID: 12623
		// RVA: 0x0002472A File Offset: 0x0002292A
		internal void method_1(Class578 class578_1)
		{
			this.class578_0 = class578_1;
		}

		// Token: 0x06003150 RID: 12624
		// RVA: 0x00024733 File Offset: 0x00022933
		internal bool method_2()
		{
			return this.class578_0 != null;
		}
	}
}
