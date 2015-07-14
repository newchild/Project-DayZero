using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using osu.Graphics.Sprites;
using System;

namespace ns79
{
	// Token: 0x0200045C RID: 1116
	internal class Class532 : Class531
	{
		// Token: 0x04001C3F RID: 7231
		internal Enum69 enum69_0;

		// Token: 0x06002437 RID: 9271
		// RVA: 0x0001C64E File Offset: 0x0001A84E
		internal Class532(Class731 class731_1, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9) : base(class731_1, enum115_1, origins_1, enum114_1, vector2_9)
		{
		}

		// Token: 0x06002438 RID: 9272
		// RVA: 0x0001C65D File Offset: 0x0001A85D
		internal Class532(Class731 class731_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2) : base(class731_1, vector2_9, float_7, bool_15, color_2)
		{
		}

		// Token: 0x06002439 RID: 9273
		// RVA: 0x000DBB9C File Offset: 0x000D9D9C
		internal Class532(Class731 class731_1, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2) : base(class731_1, enum115_1, origins_1, enum114_1, vector2_9, float_7, bool_15, color_2, null)
		{
		}

		// Token: 0x0600243A RID: 9274
		// RVA: 0x0001C66C File Offset: 0x0001A86C
		internal bool method_49()
		{
			return this.class731_0 != null && Class115.int_1 - this.class731_0.int_2 > 5000 && this.method_50();
		}

		// Token: 0x0600243B RID: 9275
		// RVA: 0x0001C696 File Offset: 0x0001A896
		internal bool method_50()
		{
			if (this.class731_0 == null)
			{
				return false;
			}
			this.class731_0.Dispose();
			this.class731_0 = null;
			this.enum69_0 = Enum69.const_0;
			return true;
		}
	}
}
