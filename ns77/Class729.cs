using Microsoft.Xna.Framework;
using ns26;
using ns29;
using ns79;
using System;
using System.Collections.Generic;

namespace ns77
{
	// Token: 0x02000566 RID: 1382
	internal sealed class Class729
	{
		// Token: 0x040024F0 RID: 9456
		private List<Class730> list_0 = new List<Class730>();

		// Token: 0x06002CAB RID: 11435
		// RVA: 0x00021D6E File Offset: 0x0001FF6E
		internal Class729()
		{
		}

		// Token: 0x06002CAC RID: 11436
		// RVA: 0x00021D81 File Offset: 0x0001FF81
		internal Class730 Add(Class730 class730_0)
		{
			this.list_0.Add(class730_0);
			return class730_0;
		}

		// Token: 0x06002CAD RID: 11437
		// RVA: 0x0012195C File Offset: 0x0011FB5C
		internal Class730 Add(Class531 class531_0, Vector2? nullable_0, bool bool_0)
		{
			Class730 class = new Class730(class531_0, nullable_0.HasValue ? nullable_0.Value : Vector2.get_Zero());
			this.Add(class);
			return class;
		}

		// Token: 0x06002CAE RID: 11438
		// RVA: 0x00121990 File Offset: 0x0011FB90
		internal void method_0()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				Class730 class = this.list_0[i];
				Class531 class531_ = class.class531_0;
				bool flag = (class531_.class26_0.Count == 0 || class531_.class26_0[class531_.class26_0.Count - 1].int_1 < Class911.smethod_0(class531_)) && (!class531_.bool_3 || class531_.vector2_1.Y > 550f);
				bool flag2 = class531_.class26_0.Count > 0 && class531_.class26_0[0].int_0 > Class911.smethod_0(class531_);
				bool flag3 = class531_.enum114_0 == Enum114.const_1 && Class331.smethod_79();
				if (!flag && !flag2 && !flag3)
				{
					Class730 expr_D3_cp_0 = class;
					expr_D3_cp_0.vector2_0.Y = expr_D3_cp_0.vector2_0.Y + 8f * (float)Class115.double_0 * (1f + class.float_0 / 100f);
					class531_.vector2_1 += class.vector2_0 * (float)(Class115.double_9 / 1000.0);
					if (class.bool_0 && class531_.enum115_0 == Enum115.const_5 && ((class531_.vector2_1.X < 0f && class.vector2_0.X < 0f) || (class531_.vector2_1.X > (float)Class115.smethod_43() && class.vector2_0.X > 0f)))
					{
						class.vector2_0.X = -class.vector2_0.X;
					}
				}
				else if (flag)
				{
					this.list_0.RemoveAt(i);
				}
			}
		}
	}
}
