using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020004FB RID: 1275
	internal class Class666
	{
		// Token: 0x0400220E RID: 8718
		protected readonly Class536 class536_0;

		// Token: 0x0400220F RID: 8719
		protected readonly Class536 class536_1;

		// Token: 0x0400220D RID: 8717
		protected readonly Class911 class911_0;

		// Token: 0x04002211 RID: 8721
		private double double_0;

		// Token: 0x04002213 RID: 8723
		internal double double_1;

		// Token: 0x04002216 RID: 8726
		protected float float_0;

		// Token: 0x04002210 RID: 8720
		private int int_0;

		// Token: 0x04002212 RID: 8722
		internal int int_1;

		// Token: 0x04002214 RID: 8724
		internal Vector2 vector2_0;

		// Token: 0x04002215 RID: 8725
		protected Vector2 vector2_1;

		// Token: 0x06002901 RID: 10497
		// RVA: 0x0001F875 File Offset: 0x0001DA75
		internal Class666(Class911 class911_1) : this(class911_1, new Vector2(6f, 0f), true, 0.96f, true, true)
		{
		}

		// Token: 0x06002902 RID: 10498
		// RVA: 0x001029F4 File Offset: 0x00100BF4
		internal Class666(Class911 class911_1, Vector2 vector2_2, bool bool_0, float float_1, bool bool_1, bool bool_2)
		{
			this.class911_0 = class911_1;
			this.float_0 = float_1;
			if (Class115.bool_16)
			{
				float_1 *= 1.4f;
			}
			float num = vector2_2.Y;
			this.vector2_1 = Vector2.get_Zero();
			if (bool_1)
			{
				this.class536_0 = new Class536("00000000", Class885.class547_0.string_4, Class885.class547_0.int_1, bool_0 ? Enum115.const_7 : Enum115.const_5, bool_0 ? Origins.TopRight : Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.95f, true, Color.get_White(), true);
				this.class536_0.bool_21 = true;
				this.vector2_1 = this.class536_0.vmethod_11() * 0.625f * float_1;
				this.class536_0.vector2_1 = new Vector2(vector2_2.X, num);
				this.class536_0.float_2 = float_1;
				num += this.vector2_1.Y;
			}
			if (Class885.smethod_25())
			{
				num += 3f;
			}
			if (bool_2)
			{
				this.class536_1 = new Class536("00.00%", Class885.class547_0.string_4, Class885.class547_0.int_1, bool_0 ? Enum115.const_7 : Enum115.const_5, bool_0 ? Origins.TopRight : Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.95f, true, Color.get_White(), true);
				this.class536_1.float_2 = float_1 * (bool_1 ? 0.6f : 1f);
				this.class536_1.bool_21 = true;
				this.class536_1.vector2_1 = new Vector2(vector2_2.X, num);
				this.vector2_0 = this.class536_1.vector2_1 + new Vector2(this.class536_1.vmethod_11().X * 0.625f * this.class536_1.float_2 + 24f, this.class536_1.vmethod_11().Y * 0.625f * this.class536_1.float_2 / 2f);
			}
			if (!Class62.bool_15 && !Class62.bool_16)
			{
				class911_1.Add(this.class536_0);
				class911_1.Add(this.class536_1);
			}
		}

		// Token: 0x06002903 RID: 10499
		// RVA: 0x00102C28 File Offset: 0x00100E28
		internal void Draw()
		{
			if (Class115.bool_13)
			{
				if (this.class536_1 != null)
				{
					if (this.double_0 - this.double_1 <= -0.005)
					{
						this.double_0 = Math.Round(this.double_0 + Math.Max(0.01, (this.double_1 - this.double_0) / 2.0), 2);
						this.class536_1.Text = string.Format("{0:00.00}%", this.double_0);
					}
					else if (this.double_0 - this.double_1 >= 0.005)
					{
						this.double_0 = Math.Round(this.double_0 - Math.Max(0.01, (this.double_0 - this.double_1) / 2.0), 2);
						this.class536_1.Text = string.Format("{0:00.00}%", this.double_0);
					}
				}
				if (this.class536_0 != null && this.int_0 != this.int_1)
				{
					if (this.int_0 < this.int_1)
					{
						this.int_0 += Math.Max(1, (this.int_1 - this.int_0) / 4);
					}
					else
					{
						this.int_0 -= Math.Max(1, (this.int_0 - this.int_1) / 4);
					}
					this.class536_0.Text = string.Format("{0:00000000}", this.int_0);
				}
			}
		}

		// Token: 0x06002900 RID: 10496
		// RVA: 0x0001F853 File Offset: 0x0001DA53
		internal float method_0()
		{
			if (this.class536_0 != null)
			{
				return (float)this.class536_0.int_1 / 1.6f;
			}
			return 0f;
		}

		// Token: 0x06002905 RID: 10501
		// RVA: 0x0001F89E File Offset: 0x0001DA9E
		internal void method_1(float float_1)
		{
			this.double_1 = Math.Round((double)float_1, 2);
		}

		// Token: 0x06002906 RID: 10502
		// RVA: 0x0001F8AE File Offset: 0x0001DAAE
		internal void method_2()
		{
			if (this.class536_0 != null)
			{
				this.class536_0.method_16(0, Enum70.const_0);
			}
			if (this.class536_1 != null)
			{
				this.class536_1.method_16(0, Enum70.const_0);
			}
		}

		// Token: 0x06002904 RID: 10500
		// RVA: 0x0001F895 File Offset: 0x0001DA95
		internal virtual void vmethod_0(int int_2)
		{
			this.int_1 = int_2;
		}
	}
}
