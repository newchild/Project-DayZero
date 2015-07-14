using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020004FC RID: 1276
	internal sealed class Class667 : Class666
	{
		// Token: 0x06002907 RID: 10503
		// RVA: 0x0001F8DA File Offset: 0x0001DADA
		internal Class667(Class911 class911_1) : base(class911_1)
		{
			Class536 expr_12_cp_0 = this.class536_1;
			expr_12_cp_0.vector2_1.Y = expr_12_cp_0.vector2_1.Y + this.vector2_1.Y * 0.8f;
		}

		// Token: 0x06002908 RID: 10504
		// RVA: 0x00102DBC File Offset: 0x00100FBC
		internal override void vmethod_0(int int_2)
		{
			if (!Class62.bool_15)
			{
				int num = int_2 - this.int_1;
				if (num > 0)
				{
					Vector2 vector;
					vector..ctor(10f, this.class536_0.vector2_1.Y + this.vector2_1.Y);
					Class536 class = new Class536(num.ToString(), Class885.class547_0.string_4, Class885.class547_0.int_1, this.class536_1.enum115_0, Origins.TopRight, Enum114.const_0, vector, 0.95f, false, Color.get_Red(), true);
					class.float_2 = this.float_0 * 0.8f;
					this.class911_0.Add(class);
					class.method_15(60);
					class.class26_0.Add(new Class746(vector + new Vector2((float)(Class562.smethod_7(0.5) ? 10 : -10), 0f), vector, Class115.int_1, Class115.int_1 + 100, Enum70.const_1));
					class.class26_0.Add(new Class746(vector, vector + new Vector2(0f, -30f), Class115.int_1 + 300, Class115.int_1 + 420, Enum70.const_2));
					class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 300, Class115.int_1 + 420, Enum70.const_2));
				}
			}
			base.vmethod_0(int_2);
		}
	}
}
