using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using osu.Graphics.Sprites;
using System;

namespace ns79
{
	// Token: 0x02000580 RID: 1408
	internal sealed class Class539 : Class531
	{
		// Token: 0x040025AA RID: 9642
		internal int int_7;

		// Token: 0x06002D3C RID: 11580
		// RVA: 0x00125E40 File Offset: 0x00124040
		public Class539(Class731 class731_1, Vector2 vector2_9, float float_7, bool bool_15, Color color_2, int int_8) : base(class731_1, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_9, float_7, bool_15, color_2, null)
		{
			this.int_7 = int_8;
		}

		// Token: 0x06002D3D RID: 11581
		// RVA: 0x00125E68 File Offset: 0x00124068
		internal override bool vmethod_10(Vector2 vector2_9, int int_8)
		{
			float num = this.float_2 * (float)this.int_7 * Class115.float_4 / 2f;
			return Vector2.DistanceSquared(vector2_9, this.vector2_3) < num * num;
		}
	}
}
