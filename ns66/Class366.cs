using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns26;
using ns29;
using ns80;
using ns81;
using ns85;
using osu.GameModes.Edit;
using System;
using System.Collections.Generic;

namespace ns66
{
	// Token: 0x02000372 RID: 882
	internal sealed class Class366
	{
		// Token: 0x0400152C RID: 5420
		internal bool bool_0 = true;

		// Token: 0x04001522 RID: 5410
		private readonly Class339 class339_0;

		// Token: 0x04001523 RID: 5411
		private readonly Class339 class339_1;

		// Token: 0x04001524 RID: 5412
		private Color color_0 = new Color(250, 250, 250, 140);

		// Token: 0x04001525 RID: 5413
		private Color color_1 = new Color(50, 50, 50, 140);

		// Token: 0x04001521 RID: 5409
		private Editor editor_0;

		// Token: 0x04001526 RID: 5414
		internal int int_0;

		// Token: 0x04001527 RID: 5415
		internal int int_1;

		// Token: 0x04001528 RID: 5416
		internal int int_2;

		// Token: 0x04001529 RID: 5417
		private int int_3;

		// Token: 0x0400152A RID: 5418
		private int int_4;

		// Token: 0x0400152B RID: 5419
		private int int_5;

		// Token: 0x0400152D RID: 5421
		internal int int_6;

		// Token: 0x06001AA5 RID: 6821
		// RVA: 0x00082E44 File Offset: 0x00081044
		internal Class366(Editor editor_1)
		{
			this.editor_0 = editor_1;
			this.class339_0 = new Class339(Class331.smethod_37("metronomehigh", false, true, Enum112.flag_1));
			this.class339_1 = new Class339(Class331.smethod_37("metronomelow", false, true, Enum112.flag_1));
		}

		// Token: 0x06001AA6 RID: 6822
		// RVA: 0x00082ECC File Offset: 0x000810CC
		internal void Draw()
		{
			List<Class880> list = new List<Class880>();
			Vector2 vector;
			vector..ctor(330f, 360f);
			float hitObjectRadius = this.editor_0.class297_0.HitObjectRadius;
			Class340 class = Class331.smethod_7();
			float num = (class != null) ? class.method_4() : 1f;
			float num2 = (float)(100.0 * Class466.Current.DifficultySliderMultiplier / (double)num);
			float num3 = (float)((int)(300f / num2));
			if (num3 == 0f)
			{
				num3 = 0.5f;
			}
			float num4 = num3 * num2;
			Vector2 vector2;
			vector2..ctor(num4 * 0.5f, 0f);
			list.Add(new Class880(Class115.smethod_56(vector - vector2), Class115.smethod_56(vector + vector2)));
			Class115.class582_0.Draw(list, hitObjectRadius * Class115.float_5, this.color_0, 0f, "Standard", true);
			list.Clear();
			Vector2 vector3;
			vector3..ctor((float)this.editor_0.class297_0.SliderScoringPointDistance / num, 0f);
			Vector2 vector4 = vector - vector2;
			while (vector4.X <= vector.X + vector2.X + 1f)
			{
				list.Add(new Class880(Class115.smethod_56(vector4), Class115.smethod_56(vector4)));
				vector4 += vector3;
			}
			vector4 = vector - vector2;
			Class115.class582_0.Draw(list, hitObjectRadius * 0.2f * this.editor_0.class297_0.float_0, Color.get_White(), 0f, "Standard", true);
			list.Clear();
			double num5 = Class331.smethod_21((double)Class331.int_7);
			double num6 = ((double)Class331.int_7 - num5) / Class331.smethod_22((double)Class331.int_7, false);
			num6 *= (double)num2;
			for (num6 %= (double)(num4 * 2f); num6 < 0.0; num6 += (double)num4)
			{
			}
			if (num6 >= (double)num4)
			{
				num6 = (double)(num4 * 2f) - num6;
			}
			vector4 += new Vector2((float)num6, 0f);
			list.Add(new Class880(Class115.smethod_56(vector4), Class115.smethod_56(vector4)));
			Class115.class582_0.Draw(list, hitObjectRadius * Class115.float_5, this.color_1, 0f, "Standard", true);
		}

		// Token: 0x06001AA7 RID: 6823
		// RVA: 0x00083124 File Offset: 0x00081324
		internal void method_0()
		{
			if (!Class331.smethod_17())
			{
				return;
			}
			double num = (double)Class331.int_7 - Class331.smethod_12();
			double num2 = num / Class331.smethod_8();
			int num3 = (int)Class331.smethod_18();
			this.int_1 = (int)num2;
			this.int_0 = this.int_1 % num3;
			this.int_2 = this.int_1 / num3;
			int num4 = (int)(2.0 * num2);
			int num5 = (int)(3.0 * num2);
			bool flag = (this.editor_0.int_6 % 3 == 0) ? (num5 > this.int_5) : (num4 > this.int_4);
			if (num < 0.0)
			{
				this.int_0 += 3;
				this.int_2--;
			}
			if (this.bool_0 && Class331.enum100_0 == Enum100.const_1)
			{
				if (this.int_3 != this.int_1 - 1 && this.int_3 <= this.int_1)
				{
					if (flag && Class570.bool_0)
					{
						this.class339_1.method_10(true, true);
						this.class339_1.method_0(0.8f);
					}
				}
				else if (this.int_6 == 0)
				{
					Enum37 enum = Class331.smethod_18();
					if (enum == Enum37.const_0)
					{
						switch (this.int_0)
						{
						case 0:
							this.class339_0.method_10(true, true);
							break;
						case 1:
						case 3:
							this.class339_1.method_10(true, true);
							this.class339_1.method_0(0.8f);
							break;
						case 2:
							this.class339_1.method_10(true, true);
							this.class339_1.method_0(0.6f);
							break;
						}
					}
					else
					{
						int num6 = this.int_0;
						if (num6 == 0)
						{
							this.class339_0.method_10(true, true);
						}
						else
						{
							this.class339_1.method_10(true, true);
							this.class339_1.method_0(0.8f);
						}
					}
				}
				else
				{
					this.int_6--;
				}
			}
			this.int_3 = this.int_1;
			this.int_4 = num4;
			this.int_5 = num5;
		}
	}
}
