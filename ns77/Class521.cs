using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns77
{
	// Token: 0x0200044B RID: 1099
	internal sealed class Class521 : Class520
	{
		// Token: 0x0200044C RID: 1100
		[CompilerGenerated]
		private sealed class Class528
		{
			// Token: 0x04001BA8 RID: 7080
			public Class533 class533_0;

			// Token: 0x0600237B RID: 9083
			// RVA: 0x0001C11C File Offset: 0x0001A31C
			public void method_0(Class530 class530_0)
			{
				class530_0.vector2_1.Y = class530_0.vector2_1.Y + (Class521.vector2_0.Y + this.class533_0.vmethod_11().Y / 0.625f / Class115.float_4);
			}

			// Token: 0x0600237C RID: 9084
			// RVA: 0x0001C157 File Offset: 0x0001A357
			public void method_1()
			{
				this.class533_0.method_53(Class521.color_0);
			}
		}

		// Token: 0x04001BA7 RID: 7079
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04001BA6 RID: 7078
		private Class529 class529_0;

		// Token: 0x04001BA4 RID: 7076
		private static Color color_0 = new Color(0, 0, 0, 180);

		// Token: 0x04001BA5 RID: 7077
		private static Color color_1 = new Color(50, 176, 255, 180);

		// Token: 0x04001BA3 RID: 7075
		private static Vector2 vector2_0 = new Vector2(0f, 0f);

		// Token: 0x06002377 RID: 9079
		// RVA: 0x0001C114 File Offset: 0x0001A314
		[CompilerGenerated]
		internal bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002378 RID: 9080
		// RVA: 0x000D6398 File Offset: 0x000D4598
		internal override void vmethod_0()
		{
			base.vmethod_0();
			if (this.class911_0 != null)
			{
				this.class911_0.float_0 = (float)(this.method_0() ? 1 : 0);
			}
			foreach (string current in this.class529_0.method_0())
			{
				Class521.Class528 class = new Class521.Class528();
				if (current != null && current.Length != 0)
				{
					Class521.Class528 arg_BD_0 = class;
					Class533 class2 = new Class533(current, 9f, Class521.vector2_0, 1f, false, Color.get_White());
					class2.enum115_0 = Enum115.const_11;
					class2.vector2_9 = new Vector2(700f, 0f);
					class2.origins_0 = Origins.BottomLeft;
					class2.bool_17 = false;
					class2.method_53(Class521.color_1);
					class2.bool_15 = false;
					class2.method_58(true);
					arg_BD_0.class533_0 = class2;
					this.class911_0.list_2.ForEach(new Action<Class530>(class.method_0));
					if (this.class911_0.list_2.Count > 0 && this.class911_0.list_2[0].vector2_1.Y > 480f)
					{
						this.class911_0.Remove(this.class911_0.list_2[0]);
					}
					this.class911_0.Add(class.class533_0);
					class.class533_0.method_16(15000, Enum70.const_18);
					Class115.class47_0.method_1(new VoidDelegate(class.method_1), 320, false);
				}
			}
		}
	}
}
