using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns77;
using ns80;
using osu.Graphics.OpenGl;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;

namespace ns79
{
	// Token: 0x0200057C RID: 1404
	internal sealed class Class536 : Class533
	{
		// Token: 0x04002591 RID: 9617
		internal bool bool_21;

		// Token: 0x04002595 RID: 9621
		private int int_10 = -1;

		// Token: 0x04002596 RID: 9622
		private int int_11 = -1;

		// Token: 0x04002594 RID: 9620
		internal int int_9;

		// Token: 0x0400258F RID: 9615
		internal List<Vector2> list_3 = new List<Vector2>();

		// Token: 0x04002590 RID: 9616
		internal List<Class731> list_4 = new List<Class731>();

		// Token: 0x04002592 RID: 9618
		internal string string_3 = "default";

		// Token: 0x04002593 RID: 9619
		internal string string_4;

		// Token: 0x06002D20 RID: 11552
		// RVA: 0x00124FD8 File Offset: 0x001231D8
		internal Class536(string string_5, string string_6, int int_12, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_11, float float_8, bool bool_22, Color color_5, bool bool_23) : base(null, enum115_1, origins_1, enum114_1, vector2_11, float_8, bool_22, color_5)
		{
			this.Text = string_5;
			this.class731_0 = null;
			this.string_3 = string_6;
			this.string_4 = string_6 + '-';
			this.int_9 = int_12;
			if (bool_23)
			{
				for (int i = 0; i < 10; i++)
				{
					Class885.Load(this.string_4 + i, Enum112.flag_6);
				}
				Class885.Load(this.string_4 + "dot", Enum112.flag_6);
				Class885.Load(this.string_4 + "comma", Enum112.flag_6);
				Class885.Load(this.string_4 + "percent", Enum112.flag_6);
			}
		}

		// Token: 0x06002D24 RID: 11556
		// RVA: 0x001254B8 File Offset: 0x001236B8
		public override bool Draw()
		{
			if (!base.Draw())
			{
				return false;
			}
			for (int i = 0; i < this.list_3.Count; i++)
			{
				if (this.list_4[i].method_2() == null)
				{
					this.vmethod_12(null);
				}
				if (i == 0 && this.list_4[i].int_3 != 1)
				{
					this.vector2_7 *= 1f / (float)this.list_4[i].int_3;
				}
				this.vector2_3 = new Vector2(this.list_3[i].X * this.float_6 + this.rectangleF_0.X, this.rectangleF_0.Y);
				Rectangle scissorRectangle = base.method_6() ? base.method_3() : Class911.rectangle_0;
				if (Class115.bool_26)
				{
					Class115.spriteBatch_0.get_GraphicsDevice().set_ScissorRectangle(scissorRectangle);
					Class115.spriteBatch_0.Draw(this.list_4[i].method_2(), this.vector2_3, null, this.color_1, this.float_1, Vector2.get_Zero(), this.vector2_7, 0, Math.Min(1f, this.float_0 + (float)i * 1E-05f));
				}
				if (Class115.bool_27)
				{
					Gl.glScissor(scissorRectangle.get_Left(), Class115.int_23 - scissorRectangle.get_Bottom(), scissorRectangle.Width, scissorRectangle.Height);
					this.list_4[i].class748_0.Draw(this.vector2_3, Vector2.get_Zero(), this.color_1, this.vector2_7, this.float_1, null);
				}
			}
			return true;
		}

		// Token: 0x06002D21 RID: 11553
		// RVA: 0x00022248 File Offset: 0x00020448
		internal override Vector2 vmethod_11()
		{
			if (this.bool_18)
			{
				this.vmethod_12(null);
			}
			return this.vector2_4;
		}

		// Token: 0x06002D23 RID: 11555
		// RVA: 0x001250F4 File Offset: 0x001232F4
		protected override Class731 vmethod_12(Class731 class731_1)
		{
			this.bool_18 = false;
			this.list_4.Clear();
			this.list_3.Clear();
			int num = 0;
			int num2 = 0;
			string text = this.Text;
			int num3 = (text == null) ? 0 : text.Length;
			int i = 0;
			while (i < num3)
			{
				class731_1 = null;
				num -= ((this.bool_21 || i == 0) ? 0 : this.int_9);
				int num4 = num;
				char c = text[i];
				if (c <= '%')
				{
					if (c != ' ')
					{
						if (c != '%')
						{
							goto IL_F3;
						}
						class731_1 = Class885.Load(this.string_4 + "percent", Enum112.flag_6);
						goto IL_12D;
					}
					else
					{
						class731_1 = null;
					}
				}
				else
				{
					switch (c)
					{
					case ',':
						class731_1 = Class885.Load(this.string_4 + "comma", Enum112.flag_6);
						goto IL_12D;
					case '-':
						goto IL_F3;
					case '.':
						class731_1 = Class885.Load(this.string_4 + "dot", Enum112.flag_6);
						goto IL_12D;
					default:
						if (c != '\\')
						{
							goto IL_F3;
						}
						class731_1 = Class885.Load(this.string_4 + "fps", Enum112.flag_6);
						goto IL_12D;
					}
				}
				IL_262:
				i++;
				continue;
				IL_12D:
				if (class731_1 != null)
				{
					char c2 = text[i];
					if (c2 <= '%')
					{
						if (c2 == ' ')
						{
							if (this.int_11 < 0)
							{
								Class731 class = Class885.Load(this.string_4 + "5", Enum112.flag_6);
								this.int_10 = ((class != null) ? class.method_0() : 40);
								class = Class885.Load(this.string_4 + "dot", Enum112.flag_6);
								this.int_11 = ((class != null) ? class.method_0() : 40);
							}
							num += this.int_11;
							goto IL_262;
						}
						if (c2 != '%')
						{
							goto IL_1F4;
						}
						goto IL_207;
					}
					else
					{
						switch (c2)
						{
						case ',':
						case '.':
							goto IL_207;
						case '-':
							goto IL_1F4;
						default:
							if (c2 != '\\')
							{
								goto IL_1F4;
							}
							num += class731_1.method_0();
							break;
						}
					}
					IL_210:
					if (this.bool_21)
					{
						this.list_3.Add(new Vector2((float)(num - num4), 0f));
					}
					else
					{
						this.list_3.Add(new Vector2((float)num4, 0f));
					}
					this.list_4.Add(class731_1);
					if (num2 == 0)
					{
						num2 = class731_1.method_1();
						goto IL_262;
					}
					goto IL_262;
					IL_1F4:
					if (!this.bool_21)
					{
						num += class731_1.method_0();
						goto IL_210;
					}
					goto IL_210;
					IL_207:
					num += class731_1.method_0();
					goto IL_210;
				}
				goto IL_262;
				IL_F3:
				class731_1 = Class885.Load(this.string_4 + text[i], Enum112.flag_6);
				goto IL_12D;
			}
			if (this.bool_21 && num3 > 1)
			{
				if (this.int_11 < 0)
				{
					Class731 class2 = Class885.Load(this.string_4 + "5", Enum112.flag_6);
					this.int_10 = ((class2 != null) ? class2.method_0() : 40);
					class2 = Class885.Load(this.string_4 + "dot", Enum112.flag_6);
					this.int_11 = ((class2 != null) ? class2.method_0() : 40);
				}
				num = 0;
				for (int j = 0; j < this.list_3.Count; j++)
				{
					float x = this.list_3[j].X;
					if (x == 0f)
					{
						this.list_3[j] = new Vector2((float)(num + Math.Max(0, (this.int_10 - this.list_4[j].method_0()) / 2)), 0f);
						num += this.int_10 - this.int_9;
					}
					else
					{
						this.list_3[j] = new Vector2((float)num, 0f);
						num += (int)x - this.int_9;
					}
				}
			}
			int num5 = num;
			this.vector2_4 = new Vector2((float)num5, (float)num2);
			this.vmethod_8();
			this.vmethod_9();
			return null;
		}

		// Token: 0x06002D22 RID: 11554
		// RVA: 0x001250C8 File Offset: 0x001232C8
		public override Enum51 vmethod_3()
		{
			Enum51 enum = base.vmethod_3();
			if (enum != Enum51.const_0)
			{
				return enum;
			}
			if (this.bool_18)
			{
				this.vmethod_12(null);
			}
			return enum;
		}

		// Token: 0x06002D25 RID: 11557
		// RVA: 0x0012567C File Offset: 0x0012387C
		internal override void vmethod_8()
		{
			this.int_4 = (this.int_6 = (int)Math.Round((double)this.vector2_4.X));
			this.int_1 = (this.int_5 = (int)Math.Round((double)this.vector2_4.Y));
			this.int_3 = 0;
			this.int_2 = 0;
		}
	}
}
