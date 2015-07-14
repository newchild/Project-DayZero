using Microsoft.Xna.Framework.Graphics;
using ns85;
using ns91;
using System;
using System.Collections.Generic;

namespace ns84
{
	// Token: 0x02000482 RID: 1154
	internal sealed class Class583 : Class582, IDisposable, Interface16, Interface17
	{
		// Token: 0x04001EC8 RID: 7880
		private Color color_0;

		// Token: 0x04001EC9 RID: 7881
		private Color color_1;

		// Token: 0x04001ECA RID: 7882
		private Color color_2;

		// Token: 0x04001ECB RID: 7883
		private float float_0;

		// Token: 0x04001EC7 RID: 7879
		private List<Color> list_0;

		// Token: 0x0600251E RID: 9502
		// RVA: 0x0001CE8B File Offset: 0x0001B08B
		public override void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3)
		{
			this.Draw(list_1, class880_0, float_1, color_3, this.color_2);
		}

		// Token: 0x0600251F RID: 9503
		// RVA: 0x000DFCBC File Offset: 0x000DDEBC
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_6)
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
			this.Draw(list_1, class880_0, float_1, color_, this.color_2);
		}

		// Token: 0x0600251D RID: 9501
		// RVA: 0x000DFC34 File Offset: 0x000DDE34
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, Color color_3, Color color_4)
		{
			BaseGLControl.smethod_5(1u, 771u);
			base.Draw(list_1, float_1 * 58f / 64f, color_4, 0f, "StandardBorder", true);
			BaseGLControl.smethod_5(770u, 771u);
			base.Draw(list_1, float_1 * 51f / 64f, new Color(color_3.get_R(), color_3.get_G(), color_3.get_B(), 255), 0f, "StandardNoRect", true);
		}

		// Token: 0x06002520 RID: 9504
		// RVA: 0x0001CE9E File Offset: 0x0001B09E
		public void Draw(List<Class880> list_1, Class880 class880_0, float float_1, int int_6, Color color_3)
		{
			this.Draw(list_1, class880_0, float_1, this.list_0[int_6], color_3);
		}

		// Token: 0x06002516 RID: 9494
		// RVA: 0x0001CE30 File Offset: 0x0001B030
		public Color imethod_0()
		{
			return this.color_0;
		}

		// Token: 0x06002517 RID: 9495
		// RVA: 0x0001CE38 File Offset: 0x0001B038
		public void imethod_1(Color color_3)
		{
			this.color_0 = color_3;
		}

		// Token: 0x06002518 RID: 9496
		// RVA: 0x0001CE41 File Offset: 0x0001B041
		public Color imethod_2()
		{
			return this.color_1;
		}

		// Token: 0x0600251C RID: 9500
		// RVA: 0x0001CE64 File Offset: 0x0001B064
		public void imethod_3(List<Color> list_1, Color color_3, Color color_4, Color color_5, float float_1)
		{
			this.vmethod_0(list_1);
			this.imethod_1(color_3);
			this.vmethod_1(color_4);
			this.vmethod_2(color_5);
			this.vmethod_3(float_1);
		}

		// Token: 0x06002515 RID: 9493
		// RVA: 0x0001CE27 File Offset: 0x0001B027
		public void vmethod_0(List<Color> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x06002519 RID: 9497
		// RVA: 0x0001CE49 File Offset: 0x0001B049
		public void vmethod_1(Color color_3)
		{
			this.color_1 = color_3;
		}

		// Token: 0x0600251A RID: 9498
		// RVA: 0x0001CE52 File Offset: 0x0001B052
		public void vmethod_2(Color color_3)
		{
			this.color_2 = color_3;
		}

		// Token: 0x0600251B RID: 9499
		// RVA: 0x0001CE5B File Offset: 0x0001B05B
		public void vmethod_3(float float_1)
		{
			this.float_0 = float_1;
		}
	}
}
