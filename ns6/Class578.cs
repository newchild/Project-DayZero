using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns8;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns6
{
	// Token: 0x0200047A RID: 1146
	internal sealed class Class578
	{
		// Token: 0x0200047B RID: 1147
		[CompilerGenerated]
		private sealed class Class579
		{
			// Token: 0x04001EA5 RID: 7845
			public Class39 class39_0;

			// Token: 0x04001EA6 RID: 7846
			public List<Class531> list_0;

			// Token: 0x060024F6 RID: 9462
			// RVA: 0x000DE7C0 File Offset: 0x000DC9C0
			public void method_0(object sender, EventArgs e)
			{
				foreach (Class531 current in this.list_0)
				{
					current.method_39(Color.get_LightBlue(), 100, false, Enum70.const_0);
				}
			}

			// Token: 0x060024F7 RID: 9463
			// RVA: 0x000DE820 File Offset: 0x000DCA20
			public void method_1(object sender, EventArgs e)
			{
				foreach (Class531 current in this.list_0)
				{
					current.method_39(new Color(39, 70, 120, 255), 100, false, Enum70.const_0);
				}
			}

			// Token: 0x060024F8 RID: 9464
			// RVA: 0x0001CDA6 File Offset: 0x0001AFA6
			public void method_2(object sender, EventArgs e)
			{
				Class111.smethod_41(this.class39_0.string_0);
			}
		}

		// Token: 0x04001E9F RID: 7839
		private Class533 class533_0;

		// Token: 0x04001EA0 RID: 7840
		private Class533 class533_1;

		// Token: 0x04001EA2 RID: 7842
		private Color color_0;

		// Token: 0x04001EA3 RID: 7843
		private Color color_1;

		// Token: 0x04001EA4 RID: 7844
		private float float_0;

		// Token: 0x04001EA1 RID: 7841
		internal readonly List<Class531> list_0;

		// Token: 0x17000384 RID: 900
		internal Vector2 Position
		{
			// Token: 0x060024EE RID: 9454
			// RVA: 0x0001CD66 File Offset: 0x0001AF66
			get
			{
				return this.class533_1.vector2_0;
			}
			// Token: 0x060024EF RID: 9455
			// RVA: 0x000DE07C File Offset: 0x000DC27C
			set
			{
				foreach (Class531 current in this.list_0)
				{
					if (current != this.class533_1)
					{
						current.vector2_0 += value - this.class533_1.vector2_0;
						current.vector2_1 = current.vector2_0;
					}
				}
				this.class533_1.vector2_0 = value;
				this.class533_1.vector2_1 = value;
			}
		}

		// Token: 0x060024F0 RID: 9456
		// RVA: 0x000DE118 File Offset: 0x000DC318
		public Class578(Vector2 vector2_0, float float_1, float float_2, float float_3, Class841 class841_0, string string_0)
		{
			EventHandler eventHandler = null;
			this.list_0 = new List<Class531>();
			this.color_0 = new Color(104, 137, 255);
			base..ctor();
			this.float_0 = float_2;
			this.class533_1 = new Class533(string.Empty, float_2, vector2_0, new Vector2(float_3, 0f), float_1, true, Color.get_White(), true);
			this.class533_0 = new Class533(string.Empty, float_2, vector2_0, new Vector2(float_3, 0f), float_1, true, Color.get_White(), true);
			this.class533_1.method_62(string_0);
			this.class533_0.method_62(string_0);
			bool flag = class841_0.string_1.Length > 8 && class841_0.string_1[7] == '*' && class841_0.string_0.Length == 0;
			this.color_1 = class841_0.color_0;
			this.class533_0.Text = class841_0.string_0;
			this.class533_1.Text = class841_0.string_1;
			this.class533_1.color_0 = this.color_1;
			this.class533_1.bool_1 = (!flag && class841_0.class861_0 != null);
			this.class533_1.object_0 = class841_0.class861_0;
			this.class533_1.method_35(delegate(object sender, EventArgs e)
			{
				((Class531)sender).method_39(this.color_0, 100, false, Enum70.const_0);
			});
			Class531 arg_179_0 = this.class533_1;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_2);
			}
			arg_179_0.method_37(eventHandler);
			this.class533_1.method_2(new EventHandler(Class111.smethod_42));
			this.class533_1.bool_2 = true;
			float num = Math.Max(50f, this.class533_1.vmethod_11().X);
			Class533 expr_1C7_cp_0 = this.class533_0;
			expr_1C7_cp_0.vector2_1.X = expr_1C7_cp_0.vector2_1.X + num;
			Class533 expr_1DF_cp_0 = this.class533_0;
			expr_1DF_cp_0.vector2_0.X = expr_1DF_cp_0.vector2_0.X + num;
			Class533 expr_1F7_cp_0 = this.class533_0;
			expr_1F7_cp_0.vector2_9.X = expr_1F7_cp_0.vector2_9.X - num;
			Class533 class = flag ? this.class533_1 : this.class533_0;
			if (class841_0.color_0.get_A() != 0)
			{
				this.list_0.Add(this.class533_1);
			}
			this.list_0.Add(this.class533_0);
			try
			{
				if (class.Text.Length > 0 && class841_0.class40_0 != null && class841_0.class40_0.list_0.Count > 0)
				{
					RectangleF[] array = class.method_65();
					List<int> list = class.method_64(array);
					foreach (Class39 current in class841_0.class40_0.list_0)
					{
						if (current.string_0.IndexOf('\ud83d') == 0 && current.string_0.Length == 2)
						{
							float num2 = (float)((int)(num + class.method_66(0, current.int_0).X - (float)((current.int_0 == 0) ? 4 : 1)));
							string str = ((int)current.string_0[1]).ToString();
							Class531 item = new Class531(Class885.Load("emoji-" + str, Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, this.class533_1.vector2_1 + new Vector2(num2, 0f), 0.975f, true, Color.get_White(), null);
							this.list_0.Add(item);
						}
						else
						{
							int num3 = list.BinarySearch(current.int_0);
							if (num3 < 0)
							{
								num3 = ~num3 - 1;
							}
							List<Class531> list2 = new List<Class531>();
							int i = current.int_0;
							while (i < current.int_0 + current.int_1)
							{
								int val = (num3 >= list.Count - 1) ? class.Text.Length : list[num3 + 1];
								i = Math.Min(val, current.int_0 + current.int_1);
								int num4 = Math.Max(list[num3], current.int_0);
								int num5 = i - 1;
								while (num5 > num4 && array[num5].Width == 0f && array[num5].Height == 0f && array[num5].X == 0f)
								{
									if (array[num5].Y != 0f)
									{
										break;
									}
									num5--;
								}
								num = array[num4].X - 1f;
								RectangleF rectangleF = array[num5];
								float num6 = rectangleF.X + rectangleF.Width - num + 1f;
								list2.Add(this.method_1(current, list2, new Vector2(num, float_2 * (float)num3 + 1f), new Vector2(num6, float_2)));
								num3++;
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060024F2 RID: 9458
		// RVA: 0x000DE76C File Offset: 0x000DC96C
		internal void Dispose()
		{
			foreach (Class531 current in this.list_0)
			{
				current.Dispose();
			}
		}

		// Token: 0x060024ED RID: 9453
		// RVA: 0x000DE03C File Offset: 0x000DC23C
		internal float method_0()
		{
			float num = Math.Max(this.class533_0.vmethod_11().Y, this.class533_1.vmethod_11().Y);
			return num - num % this.float_0;
		}

		// Token: 0x060024F1 RID: 9457
		// RVA: 0x000DE654 File Offset: 0x000DC854
		private Class531 method_1(Class39 class39_0, List<Class531> list_1, Vector2 vector2_0, Vector2 vector2_1)
		{
			Class578.Class579 class = new Class578.Class579();
			class.class39_0 = class39_0;
			class.list_0 = list_1;
			Class531 class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, this.class533_0.vector2_1 + vector2_0);
			class2.vector2_0 = this.class533_0.vector2_0 + vector2_0;
			class2.float_0 = this.class533_0.float_0 - 0.001f;
			class2.bool_0 = true;
			class2.object_0 = "link";
			class2.color_0 = new Color(39, 70, 120, 255);
			class2.float_2 = 1.6f;
			class2.vector2_2 = vector2_1;
			class2.bool_1 = true;
			class2.method_35(new EventHandler(class.method_0));
			class2.method_37(new EventHandler(class.method_1));
			class2.method_2(new EventHandler(class.method_2));
			class2.string_0 = "link: " + class.class39_0.string_0;
			class2.bool_2 = true;
			this.list_0.Add(class2);
			return class2;
		}

		// Token: 0x060024F4 RID: 9460
		// RVA: 0x0001CD8B File Offset: 0x0001AF8B
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			((Class531)sender).method_39(this.color_1, 700, false, Enum70.const_0);
		}
	}
}
