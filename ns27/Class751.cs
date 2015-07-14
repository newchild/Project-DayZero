using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns79;
using ns80;
using System;

namespace ns27
{
	// Token: 0x02000590 RID: 1424
	internal sealed class Class751 : Class750
	{
		// Token: 0x06002D79 RID: 11641
		// RVA: 0x00127BDC File Offset: 0x00125DDC
		internal Class751(Vector2 vector2_0, float float_0, bool bool_1, bool bool_2) : base(null, null, vector2_0, float_0, bool_1, bool_2, new Class746(Color.get_LightGray(), Color.get_White(), 0, 200), 1f)
		{
			this.class531_0.vmethod_7(Class885.Load("selection-tab-add", Enum112.flag_1));
			this.class531_0.color_0 = Color.get_LightGray();
			this.class531_0.vector2_5 = new Vector2(70f, 12f);
			this.class531_0.bool_1 = true;
			this.class531_0.method_2(new EventHandler(base.method_1));
		}

		// Token: 0x06002D78 RID: 11640
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_0()
		{
			return false;
		}
	}
}
