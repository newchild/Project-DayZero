using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns80;
using osu.GameModes.Play.Components;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020004F2 RID: 1266
	internal sealed class Class659 : Class658
	{
		// Token: 0x040021CD RID: 8653
		private Class531 class531_2;

		// Token: 0x040021CE RID: 8654
		private Class82 class82_0 = new Class82();

		// Token: 0x060028C9 RID: 10441
		// RVA: 0x00100EB4 File Offset: 0x000FF0B4
		internal Class659(Class911 class911_1, Vector2 vector2_1) : base(class911_1, ProgressBarTypes.Pie, 34f)
		{
			this.vector2_0 = vector2_1;
			this.class531_2 = new Class531(Class885.Load("circularmetre", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, vector2_1, 0.95f, true, Color.get_White(), null);
			class911_1.Add(this.class531_2);
			this.class82_0.vector2_0 = new Vector2((float)Class115.int_22 / Class115.float_4 - vector2_1.X, vector2_1.Y);
			this.class82_0.float_1 = 10f;
		}

		// Token: 0x060028CA RID: 10442
		// RVA: 0x00100F50 File Offset: 0x000FF150
		internal override void Draw()
		{
			this.class82_0.color_0 = ((this.class82_0.float_3 < 0f) ? new Color(199, 255, 47, (byte)((double)(this.class911_0.float_0 * (float)this.class531_2.color_1.get_A()) * 0.6)) : new Color(255, 255, 255, (byte)((double)(this.class911_0.float_0 * (float)this.class531_2.color_1.get_A()) * 0.6)));
			this.class82_0.imethod_2();
			this.class82_0.Draw();
		}

		// Token: 0x060028CB RID: 10443
		// RVA: 0x0001F63B File Offset: 0x0001D83B
		internal override void vmethod_0(float float_1)
		{
			this.class82_0.float_3 = float_1;
		}
	}
}
