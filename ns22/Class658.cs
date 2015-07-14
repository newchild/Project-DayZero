using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns29;
using ns79;
using osu.GameModes.Play.Components;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020004F1 RID: 1265
	internal class Class658 : IDisposable
	{
		// Token: 0x040021C9 RID: 8649
		private readonly Class531 class531_0;

		// Token: 0x040021CA RID: 8650
		private readonly Class531 class531_1;

		// Token: 0x040021CC RID: 8652
		protected readonly Class911 class911_0;

		// Token: 0x040021C8 RID: 8648
		private readonly float float_0;

		// Token: 0x040021CB RID: 8651
		internal Vector2 vector2_0;

		// Token: 0x060028C5 RID: 10437
		// RVA: 0x00100D14 File Offset: 0x000FEF14
		internal Class658(Class911 class911_1, ProgressBarTypes progressBarTypes_0, float float_1)
		{
			this.class911_0 = class911_1;
			Enum115 enum115_;
			switch (progressBarTypes_0)
			{
			case ProgressBarTypes.Pie:
				return;
			case ProgressBarTypes.BottomRight:
				this.vector2_0 = new Vector2(118f, 460f);
				this.float_0 = 118f;
				enum115_ = Enum115.const_7;
				goto IL_9D;
			case ProgressBarTypes.Bottom:
				this.vector2_0 = new Vector2(0f, 477f);
				this.float_0 = (float)Class115.int_22 / Class115.float_4;
				enum115_ = Enum115.const_5;
				goto IL_9D;
			}
			this.vector2_0 = new Vector2(178f, float_1 - 2f);
			this.float_0 = 170f;
			enum115_ = Enum115.const_7;
			IL_9D:
			this.class531_0 = new Class531(Class115.class731_0, enum115_, Origins.TopLeft, Enum114.const_0, this.vector2_0, 0.938f, true, new Color(255, 255, 255, 20), null);
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2(this.float_0, 3f);
			this.class531_0.bool_7 = true;
			class911_1.Add(this.class531_0);
			this.class531_1 = new Class531(Class115.class731_0, enum115_, Origins.TopLeft, Enum114.const_0, this.vector2_0, 0.94f, true, new Color(255, 255, 128, 128), null);
			this.class531_1.float_2 = 1.6f;
			this.class531_1.vector2_2 = new Vector2(0f, 3f);
			this.class531_1.bool_7 = true;
			class911_1.Add(this.class531_1);
		}

		// Token: 0x060028C7 RID: 10439
		// RVA: 0x0000653E File Offset: 0x0000473E
		public virtual void Dispose()
		{
		}

		// Token: 0x060028C8 RID: 10440
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Draw()
		{
		}

		// Token: 0x060028C6 RID: 10438
		// RVA: 0x0001F60D File Offset: 0x0001D80D
		internal virtual void vmethod_0(float float_1)
		{
			this.class531_1.vector2_2 = new Vector2(Class778.smethod_2(float_1, 0f, 1f) * this.float_0, 3f);
		}
	}
}
