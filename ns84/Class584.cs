using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns85;
using System;
using System.Collections.Generic;

namespace ns84
{
	// Token: 0x02000487 RID: 1159
	internal sealed class Class584 : Class582, IDisposable, Interface16, Interface17
	{
		// Token: 0x04001EF6 RID: 7926
		private Color color_0;

		// Token: 0x04001EF7 RID: 7927
		private Color color_1;

		// Token: 0x04001EF8 RID: 7928
		private Color color_2;

		// Token: 0x04001EF9 RID: 7929
		private float float_0;

		// Token: 0x04001EFA RID: 7930
		private float float_1;

		// Token: 0x04001EF5 RID: 7925
		private List<Color> list_0;

		// Token: 0x06002566 RID: 9574
		// RVA: 0x0001D149 File Offset: 0x0001B349
		internal Class584()
		{
			this.float_1 = ((!Class115.bool_26 || Class115.int_0 >= 2) ? 1f : 0.95f) * 0.921875f;
		}

		// Token: 0x06002570 RID: 9584
		// RVA: 0x0001D1DC File Offset: 0x0001B3DC
		public override void Draw(List<Class880> list_1, Class880 class880_0, float float_2, Color color_3)
		{
			this.Draw(list_1, class880_0, float_2, color_3, this.color_2);
		}

		// Token: 0x06002571 RID: 9585
		// RVA: 0x000E1B84 File Offset: 0x000DFD84
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_2, int int_6)
		{
			Color color_;
			if (int_6 == -1)
			{
				color_ = this.color_1;
			}
			else if (int_6 == -2)
			{
				color_ = this.color_0;
			}
			else
			{
				color_ = this.list_0[int_6];
			}
			this.Draw(list_1, class880_0, float_2, color_, this.color_2);
		}

		// Token: 0x0600256F RID: 9583
		// RVA: 0x000E1A84 File Offset: 0x000DFC84
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_2, Color color_3, Color color_4)
		{
			Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaBlendEnable(true);
			Class115.class125_0.GraphicsDevice.get_RenderState().set_SeparateAlphaBlendEnabled(true);
			Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaSourceBlend(2);
			Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaDestinationBlend(6);
			base.Draw(list_1, float_2 * this.float_1, color_4, 0f, "StandardBorder", true);
			Class115.class125_0.GraphicsDevice.get_RenderState().set_SeparateAlphaBlendEnabled(false);
			Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaSourceBlend(5);
			Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaDestinationBlend(6);
			Class115.class582_0.Draw(list_1, float_2 * 52f / 64f, new Color(color_3.get_R(), color_3.get_G(), color_3.get_B(), 255), 0f, "Standard", true);
		}

		// Token: 0x06002572 RID: 9586
		// RVA: 0x0001D1EF File Offset: 0x0001B3EF
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_2, int int_6, Color color_3)
		{
			this.Draw(list_1, class880_0, float_2, this.list_0[int_6], color_3);
		}

		// Token: 0x06002568 RID: 9576
		// RVA: 0x0001D181 File Offset: 0x0001B381
		public Color imethod_0()
		{
			return this.color_0;
		}

		// Token: 0x06002569 RID: 9577
		// RVA: 0x0001D189 File Offset: 0x0001B389
		public void imethod_1(Color color_3)
		{
			this.color_0 = color_3;
		}

		// Token: 0x0600256A RID: 9578
		// RVA: 0x0001D192 File Offset: 0x0001B392
		public Color imethod_2()
		{
			return this.color_1;
		}

		// Token: 0x0600256E RID: 9582
		// RVA: 0x0001D1B5 File Offset: 0x0001B3B5
		public void imethod_3(List<Color> list_1, Color color_3, Color color_4, Color color_5, float float_2)
		{
			this.vmethod_0(list_1);
			this.imethod_1(color_3);
			this.vmethod_1(color_4);
			this.vmethod_2(color_5);
			this.vmethod_3(float_2);
		}

		// Token: 0x06002567 RID: 9575
		// RVA: 0x0001D178 File Offset: 0x0001B378
		public void vmethod_0(List<Color> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x0600256B RID: 9579
		// RVA: 0x0001D19A File Offset: 0x0001B39A
		public void vmethod_1(Color color_3)
		{
			this.color_1 = color_3;
		}

		// Token: 0x0600256C RID: 9580
		// RVA: 0x0001D1A3 File Offset: 0x0001B3A3
		public void vmethod_2(Color color_3)
		{
			this.color_2 = color_3;
		}

		// Token: 0x0600256D RID: 9581
		// RVA: 0x0001D1AC File Offset: 0x0001B3AC
		public void vmethod_3(float float_2)
		{
			this.float_0 = float_2;
		}
	}
}
