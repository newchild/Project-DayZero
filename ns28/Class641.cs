using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns29;
using ns79;
using System;

namespace ns28
{
	// Token: 0x020004D2 RID: 1234
	internal sealed class Class641
	{
		// Token: 0x040020FB RID: 8443
		internal Class296 class296_0;

		// Token: 0x040020F9 RID: 8441
		internal Class533 class533_0;

		// Token: 0x040020FA RID: 8442
		internal Class540 class540_0;

		// Token: 0x040020FC RID: 8444
		private Class95 class95_0;

		// Token: 0x060027C2 RID: 10178
		// RVA: 0x000F746C File Offset: 0x000F566C
		internal Class641(Class296 class296_1, Class95 class95_1, string string_0, string string_1, int int_0)
		{
			this.class95_0 = class95_1;
			this.class296_0 = class296_1;
			this.class533_0 = new Class533(class296_1.method_75(), 20f, new Vector2(0f, (float)(int_0 * 30 + 5)), 2f, true, Color.get_White());
			this.class540_0 = new Class540(new Vector2(0f, (float)(int_0 * 30)), new Vector2(640f * Class115.smethod_46() - 30f, 30f), 1f, new Color(50, 50, 50))
			{
				float_3 = 0.01f,
				bool_7 = true,
				bool_1 = true,
				bool_2 = true
			};
			this.class540_0.method_35(new EventHandler(this.method_0));
			this.class540_0.method_37(new EventHandler(this.method_1));
			this.class540_0.method_2(new EventHandler(this.method_2));
		}

		// Token: 0x060027C3 RID: 10179
		// RVA: 0x0001EA1F File Offset: 0x0001CC1F
		private void method_0(object sender, EventArgs e)
		{
			this.class540_0.method_25(0.6f, 100, Enum70.const_0);
		}

		// Token: 0x060027C4 RID: 10180
		// RVA: 0x0001EA34 File Offset: 0x0001CC34
		private void method_1(object sender, EventArgs e)
		{
			this.class540_0.method_25(0.001f, 20, Enum70.const_0);
		}

		// Token: 0x060027C5 RID: 10181
		// RVA: 0x000F7570 File Offset: 0x000F5770
		private void method_2(object sender, EventArgs e)
		{
			if (this.class95_0.class296_0.method_3() == this.class296_0.method_3())
			{
				this.class95_0.bool_5 = true;
			}
			this.class95_0.class296_0 = this.class296_0;
			this.class95_0.method_13(true, false);
		}
	}
}
