using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns76;
using ns77;
using ns79;
using ns85;
using osu.Graphics.Primitives;
using System;
using System.Collections.Generic;

namespace ns21
{
	// Token: 0x0200066D RID: 1645
	internal sealed class Class543 : Class530
	{
		// Token: 0x04002FD0 RID: 12240
		internal bool bool_7;

		// Token: 0x04002FCC RID: 12236
		private Class512 class512_0;

		// Token: 0x04002FCF RID: 12239
		private double double_0;

		// Token: 0x04002FCD RID: 12237
		private int int_1;

		// Token: 0x04002FCE RID: 12238
		private int int_2;

		// Token: 0x04002FCA RID: 12234
		private List<Class881> list_1 = new List<Class881>();

		// Token: 0x04002FCB RID: 12235
		private List<Class880> list_2 = new List<Class880>();

		// Token: 0x04002FD1 RID: 12241
		internal RectangleF rectangleF_0;

		// Token: 0x06003363 RID: 13155
		// RVA: 0x0015F5AC File Offset: 0x0015D7AC
		internal Class543(int int_3, int int_4, Class512 class512_1, RectangleF rectangleF_1) : base(true)
		{
			this.float_0 = 0.85f;
			this.class512_0 = class512_1;
			this.int_1 = int_3;
			this.int_2 = int_4;
			this.rectangleF_0 = rectangleF_1;
			if (class512_1.list_0 != null && class512_1.list_0.Count > 0)
			{
				float x = class512_1.list_0[0].X;
				float x2 = class512_1.list_0[class512_1.list_0.Count - 1].X;
				float num = rectangleF_1.Width / (x2 - x);
				List<Vector2> list = new List<Vector2>();
				list.AddRange(class512_1.list_0);
				while (list.Count > 100)
				{
					int num2 = list.Count - 1;
					while (num2 >= 0 && num2 < list.Count)
					{
						list.RemoveAt(num2);
						num2 -= 2;
					}
				}
				Vector2[] array = list.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].X = Class115.float_4 * ((array[i].X - x) * num + rectangleF_1.X);
					bool flag = (double)array[i].Y > 0.5;
					array[i].Y = Class115.float_4 * ((1f - array[i].Y) * rectangleF_1.Height + rectangleF_1.Y);
					if (i > 0)
					{
						Class881 class = new Class881(array[i - 1], array[i], flag ? Color.get_YellowGreen() : Color.get_Red());
						this.list_1.Add(class);
						this.double_0 += (double)class.method_0();
					}
				}
			}
		}

		// Token: 0x06003365 RID: 13157
		// RVA: 0x0015F7A0 File Offset: 0x0015D9A0
		public override bool Draw()
		{
			if (!base.Draw())
			{
				return false;
			}
			int num = Class115.int_1 - this.int_1;
			if (this.list_1.Count > 0 && (num <= this.int_2 || !this.bool_7))
			{
				this.list_2.Clear();
				double num2 = this.double_0 * (double)Math.Min((float)this.int_2, (float)num / (float)this.int_2);
				Vector2 vector = (Class911.class911_0.vector2_1 - Class911.class911_0.vector2_0) * Class115.float_4;
				foreach (Class881 current in this.list_1)
				{
					if ((double)current.method_0() >= num2)
					{
						this.list_2.Add(new Class881(current.vector2_0 + vector, current.vector2_0 + Vector2.Normalize(current.vector2_1 - current.vector2_0) * (float)num2 + vector, current.color_0));
						break;
					}
					Class881 class = current.Clone() as Class881;
					class.vector2_0 += vector;
					class.vector2_1 += vector;
					this.list_2.Add(class);
					num2 -= (double)current.method_0();
				}
			}
			if (this.list_2.Count > 0)
			{
				Class115.class582_0.Draw(this.list_2, (float)(Class115.bool_16 ? 1 : 2), Color.get_Green(), 0f, "StandardNoGradient", true);
			}
			return true;
		}

		// Token: 0x06003364 RID: 13156
		// RVA: 0x00025F1E File Offset: 0x0002411E
		public override Enum51 vmethod_3()
		{
			return base.vmethod_3();
		}
	}
}
