using Microsoft.Xna.Framework;
using ns23;
using ns70;
using osu.GameplayElements.HitObjects;
using System;

namespace ns60
{
	// Token: 0x0200054C RID: 1356
	internal sealed class Class309 : Class306
	{
		// Token: 0x06002BC6 RID: 11206
		// RVA: 0x000216D5 File Offset: 0x0001F8D5
		internal Class309(Class297 class297_1, Vector2 vector2_1, int int_7, bool bool_6, HitObjectSoundType hitObjectSoundType_0, int int_8) : base(class297_1, vector2_1, int_7, bool_6, hitObjectSoundType_0, int_8)
		{
		}

		// Token: 0x06002BC7 RID: 11207
		// RVA: 0x0011C104 File Offset: 0x0011A304
		internal override Enum61 vmethod_2()
		{
			Enum61 enum = base.vmethod_2();
			if (enum > Enum61.flag_5)
			{
				return enum;
			}
			return Enum61.flag_2;
		}
	}
}
