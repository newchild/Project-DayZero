using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns19;
using ns24;
using ns27;
using ns79;
using ns8;
using ns84;
using ns90;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns74
{
	// Token: 0x020003E1 RID: 993
	internal sealed class Class441
	{
		// Token: 0x04001920 RID: 6432
		private bool bool_0;

		// Token: 0x04001925 RID: 6437
		internal bool bool_1;

		// Token: 0x04001926 RID: 6438
		private bool bool_2;

		// Token: 0x0400191B RID: 6427
		private Class533 class533_0;

		// Token: 0x0400191C RID: 6428
		private Class533 class533_1;

		// Token: 0x0400191D RID: 6429
		private Class533 class533_2;

		// Token: 0x0400191E RID: 6430
		private Class533 class533_3;

		// Token: 0x0400191F RID: 6431
		private Class533 class533_4;

		// Token: 0x0400191A RID: 6426
		private Class754 class754_0;

		// Token: 0x04001918 RID: 6424
		internal static Color color_0 = new Color(150, 150, 150);

		// Token: 0x04001919 RID: 6425
		internal static Color color_1 = new Color(255, 255, 255);

		// Token: 0x04001924 RID: 6436
		internal int int_0;

		// Token: 0x04001923 RID: 6435
		internal List<Class531> list_0;

		// Token: 0x04001928 RID: 6440
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x04001921 RID: 6433
		private string string_0;

		// Token: 0x04001922 RID: 6434
		private string string_1;

		// Token: 0x04001917 RID: 6423
		private Vector2 vector2_0 = new Vector2(280f, 2f);

		// Token: 0x04001927 RID: 6439
		private Vector2 vector2_1;

		// Token: 0x1700036B RID: 875
		internal string Name
		{
			// Token: 0x06001FD6 RID: 8150
			// RVA: 0x0001A093 File Offset: 0x00018293
			get
			{
				return this.string_0;
			}
			// Token: 0x06001FD7 RID: 8151
			// RVA: 0x0001A09B File Offset: 0x0001829B
			set
			{
				this.string_0 = value;
				if (this.string_1 == null)
				{
					this.string_1 = this.Name;
				}
			}
		}

		// Token: 0x06001FD8 RID: 8152
		// RVA: 0x0001A0B8 File Offset: 0x000182B8
		internal Class441(string string_2)
		{
			this.Name = string_2;
		}

		// Token: 0x06001FD4 RID: 8148
		// RVA: 0x0001A07C File Offset: 0x0001827C
		private bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06001FD5 RID: 8149
		// RVA: 0x0001A084 File Offset: 0x00018284
		private void method_1(bool bool_3)
		{
			this.bool_0 = bool_3;
			this.method_12();
		}

		// Token: 0x06001FE1 RID: 8161
		// RVA: 0x0001A105 File Offset: 0x00018305
		private void method_10(object sender, EventArgs e)
		{
			this.method_1(!this.method_0());
		}

		// Token: 0x06001FE2 RID: 8162
		// RVA: 0x000B57BC File Offset: 0x000B39BC
		private void method_11(string string_2, string string_3)
		{
			List<string> list = Class476.smethod_1(string_2);
			Class476.Remove(string_2);
			Class476.smethod_4(string_3);
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Class476.smethod_5(string_3, list[i]);
				}
			}
		}

		// Token: 0x06001FE3 RID: 8163
		// RVA: 0x000B5800 File Offset: 0x000B3A00
		internal void method_12()
		{
			if (!this.method_0())
			{
				this.class754_0.method_20(false);
				this.class754_0.bool_3 = true;
				try
				{
					this.bool_2 = Class476.smethod_1(this.string_1).Contains(Class466.Current.string_3);
				}
				catch
				{
					return;
				}
				this.class754_0.class533_0.method_55(this.bool_2 ? Color.get_YellowGreen() : Color.get_White());
				string arg = this.Name;
				if (this.Name.Length > 40)
				{
					arg = this.Name.Substring(0, 40) + "...";
				}
				this.class754_0.Text = string.Format("{0} ({1})", arg, this.int_0);
				if (this.bool_1 != this.class754_0.class533_0.bool_16)
				{
					this.class754_0.class533_0.bool_16 = this.bool_1;
					this.class754_0.class533_0.bool_18 = true;
				}
				this.class533_1.color_0 = (this.class533_2.color_0 = (this.bool_2 ? Class441.color_0 : Class441.color_1));
				this.class533_3.color_0 = (this.class533_4.color_0 = (this.bool_2 ? Class441.color_1 : Class441.color_0));
				return;
			}
			this.class754_0.class533_0.method_55(Color.get_Yellow());
			this.class754_0.Text = this.Name;
			this.class754_0.bool_3 = false;
			this.class754_0.method_19(false);
		}

		// Token: 0x06001FE4 RID: 8164
		// RVA: 0x0001A116 File Offset: 0x00018316
		internal void method_13()
		{
			this.bool_1 = false;
			this.method_1(false);
		}

		// Token: 0x06001FE5 RID: 8165
		// RVA: 0x0001A126 File Offset: 0x00018326
		private void method_14(object sender, EventArgs e)
		{
			if (this.method_0())
			{
				this.method_1(false);
			}
			this.method_16(true, sender == this.class533_4);
		}

		// Token: 0x06001FE6 RID: 8166
		// RVA: 0x0001A147 File Offset: 0x00018347
		private void method_15(object sender, EventArgs e)
		{
			if (this.method_0())
			{
				this.method_1(false);
			}
			this.method_16(false, sender == this.class533_2);
		}

		// Token: 0x06001FE7 RID: 8167
		// RVA: 0x000B59B4 File Offset: 0x000B3BB4
		private void method_16(bool bool_3, bool bool_4)
		{
			bool flag = false;
			if (bool_4)
			{
				List<Class296> arg_2A_0 = Class466.list_3;
				if (Class441.predicate_0 == null)
				{
					Class441.predicate_0 = new Predicate<Class296>(Class441.smethod_0);
				}
				List<Class296> list = arg_2A_0.FindAll(Class441.predicate_0);
				using (List<Class296>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class296 current = enumerator.Current;
						if (bool_3)
						{
							if (Class476.smethod_7(this.Name, current.string_3))
							{
								this.int_0--;
								flag = true;
							}
						}
						else if (Class476.smethod_5(this.Name, current.string_3))
						{
							this.int_0++;
							flag = true;
						}
					}
					goto IL_F9;
				}
			}
			if (bool_3)
			{
				if (Class476.smethod_7(this.Name, Class466.Current.string_3))
				{
					this.int_0--;
					flag = true;
				}
			}
			else if (Class476.smethod_5(this.Name, Class466.Current.string_3))
			{
				this.int_0++;
				flag = true;
			}
			IL_F9:
			if (!flag)
			{
				return;
			}
			Class723.smethod_1(string.Format(bool_3 ? Class41.GetString(OsuString.CollectionSprites_Removed) : Class41.GetString(OsuString.CollectionSprites_Added), bool_4 ? Class466.Current.string_12 : Class466.Current.string_7, this.Name), 1500);
			this.method_12();
		}

		// Token: 0x06001FE8 RID: 8168
		// RVA: 0x000B5B1C File Offset: 0x000B3D1C
		[CompilerGenerated]
		private void method_17(object sender, EventArgs e)
		{
			if (this.class754_0.class533_0.bool_3)
			{
				if (this.class754_0.class533_0.float_3 == 1f)
				{
					this.class754_0.class533_0.color_0 = Color.get_White();
					return;
				}
			}
		}

		// Token: 0x06001FE9 RID: 8169
		// RVA: 0x000B5B6C File Offset: 0x000B3D6C
		[CompilerGenerated]
		private void method_18(object sender, EventArgs e)
		{
			if (this.class754_0.class533_0.bool_3)
			{
				if (this.class754_0.class533_0.float_3 == 1f)
				{
					this.class754_0.class533_0.color_0 = new Color(200, 200, 200);
					return;
				}
			}
		}

		// Token: 0x06001FD9 RID: 8153
		// RVA: 0x000B4EDC File Offset: 0x000B30DC
		internal bool method_2(Vector2 vector2_2)
		{
			this.vector2_1 = vector2_2;
			bool result;
			if (result = (this.list_0 == null))
			{
				this.method_3();
			}
			else
			{
				Vector2 vector = this.list_0[0].vector2_0;
				foreach (Class531 current in this.list_0)
				{
					Vector2 vector2_3 = this.vector2_1 + (current.vector2_0 - vector);
					current.method_19(vector2_3, 500, Enum70.const_1);
				}
			}
			this.method_12();
			return result;
		}

		// Token: 0x06001FDA RID: 8154
		// RVA: 0x0001A0DC File Offset: 0x000182DC
		private void method_3()
		{
			this.method_4();
			this.method_5();
			this.method_9();
		}

		// Token: 0x06001FDB RID: 8155
		// RVA: 0x000B4F88 File Offset: 0x000B3188
		private void method_4()
		{
			if (this.list_0 != null)
			{
				return;
			}
			this.list_0 = new List<Class531>();
			List<string> list = Class476.smethod_1(this.Name);
			if (list == null)
			{
				return;
			}
			int count = list.Count;
			int num = 0;
			for (int i = count - 1; i >= 0; i--)
			{
				if (Class466.smethod_25(list[i]) == null)
				{
					Class476.smethod_7(this.Name, list[i]);
					num++;
				}
			}
			this.int_0 = count - num;
		}

		// Token: 0x06001FDC RID: 8156
		// RVA: 0x000B5004 File Offset: 0x000B3204
		private void method_5()
		{
			if (this.class754_0 != null)
			{
				return;
			}
			this.class754_0 = new Class754(string.Empty, 12, this.vector2_1, 448f, 0.95f, false);
			this.class754_0.class533_0.color_0 = new Color(200, 200, 200);
			this.class754_0.bool_3 = true;
			this.class754_0.float_0 = 11f + 2f * this.vector2_0.Y;
			this.class754_0.color_0 = Color.get_Yellow();
			this.class754_0.class533_0.method_53(Color.get_Black());
			this.class754_0.class533_0.int_7 = 1;
			this.class754_0.class533_0.method_2(new EventHandler(this.method_8));
			this.class754_0.method_3(new Class754.Delegate37(this.method_6));
			this.class754_0.method_2(new Class754.Delegate37(this.method_7));
			this.class754_0.class533_0.method_35(new EventHandler(this.method_17));
			this.class754_0.class533_0.method_37(new EventHandler(this.method_18));
			this.list_0.AddRange(this.class754_0.list_0);
		}

		// Token: 0x06001FDD RID: 8157
		// RVA: 0x000B5160 File Offset: 0x000B3360
		private void method_6(Class754 class754_1, bool bool_3)
		{
			if (this.method_0())
			{
				if (this.Name.Length > 25)
				{
					this.Name = this.Name.Substring(0, 25);
					this.class754_0.Text = this.Name.Substring(0, 25);
				}
				if (this.class754_0.Text.Length > 25)
				{
					this.class754_0.Text = this.class754_0.Text.Substring(0, 25);
				}
			}
		}

		// Token: 0x06001FDE RID: 8158
		// RVA: 0x000B51E4 File Offset: 0x000B33E4
		private void method_7(Class754 class754_1, bool bool_3)
		{
			if (this.method_0())
			{
				if (this.class754_0.Text.Length == 0)
				{
					this.Name = ((this.string_1.Length > 25) ? this.string_1.Substring(0, 25) : this.string_1);
					this.method_11(this.string_1, this.Name);
					this.string_1 = this.Name;
					this.class754_0.Text = this.Name;
				}
				else
				{
					this.method_11(this.string_1, this.class754_0.Text);
					this.string_1 = this.class754_0.Text;
					this.Name = this.class754_0.Text;
				}
				this.method_1(false);
				this.method_12();
				Class92.smethod_2(this);
			}
		}

		// Token: 0x06001FDF RID: 8159
		// RVA: 0x0001A0F0 File Offset: 0x000182F0
		private void method_8(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.method_12();
			Class92.smethod_2(this);
		}

		// Token: 0x06001FE0 RID: 8160
		// RVA: 0x000B52B8 File Offset: 0x000B34B8
		private void method_9()
		{
			if (this.class533_0 == null)
			{
				this.class533_0 = new Class533(Class41.GetString(OsuString.General_Rename), 10f, this.vector2_1 + this.vector2_0, 0.96f, true, Color.get_White());
				this.class533_0.bool_1 = true;
				this.class533_0.method_2(new EventHandler(this.method_10));
				this.class533_0.enum72_0 = Enum72.const_2;
				this.class533_0.vector2_9 = new Vector2(35f, 11f);
				this.class533_0.color_0 = Class441.color_1;
				this.class533_0.method_53(Color.get_Orange());
				this.class533_0.int_7 = 2;
				this.class533_0.method_55(Color.get_Orange());
				this.list_0.Add(this.class533_0);
				this.vector2_0 += new Vector2(10f + this.class533_0.vector2_9.X, 0f);
			}
			if (this.class533_2 == null)
			{
				this.class533_2 = new Class533("+Set", 10f, this.vector2_1 + this.vector2_0, 0.96f, true, Color.get_White());
				this.class533_2.bool_1 = true;
				this.class533_2.method_2(new EventHandler(this.method_15));
				this.class533_2.string_0 = Class41.GetString(OsuString.CollectionSprites_AddSetToCollection);
				this.class533_2.enum72_0 = Enum72.const_2;
				this.class533_2.vector2_9 = new Vector2(30f, 11f);
				this.class533_2.method_53(Color.get_Green());
				this.class533_2.int_7 = 2;
				this.class533_2.method_55(Color.get_YellowGreen());
				this.list_0.Add(this.class533_2);
				this.vector2_0 += new Vector2(5f + this.class533_2.vector2_9.X, 0f);
			}
			if (this.class533_1 == null)
			{
				this.class533_1 = new Class533("+", 10f, this.vector2_1 + this.vector2_0, 0.96f, true, Color.get_White());
				this.class533_1.bool_1 = true;
				this.class533_1.method_2(new EventHandler(this.method_15));
				this.class533_1.string_0 = Class41.GetString(OsuString.CollectionSprites_AddToCollection);
				this.class533_1.enum72_0 = Enum72.const_2;
				this.class533_1.vector2_9 = new Vector2(20f, 11f);
				this.class533_1.method_53(Color.get_Green());
				this.class533_1.int_7 = 2;
				this.class533_1.method_55(Color.get_YellowGreen());
				this.list_0.Add(this.class533_1);
				this.vector2_0 += new Vector2(5f + this.class533_1.vector2_9.X, 0f);
			}
			if (this.class533_4 == null)
			{
				this.class533_4 = new Class533("-Set", 10f, this.vector2_1 + this.vector2_0, 0.96f, true, Color.get_White());
				this.class533_4.bool_1 = true;
				this.class533_4.method_2(new EventHandler(this.method_14));
				this.class533_4.string_0 = Class41.GetString(OsuString.CollectionSprites_RemoveSetFromCollection);
				this.class533_4.enum72_0 = Enum72.const_2;
				this.class533_4.vector2_9 = new Vector2(30f, 11f);
				this.class533_4.method_53(Color.get_OrangeRed());
				this.class533_4.int_7 = 2;
				this.class533_4.method_55(Color.get_DarkOrange());
				this.list_0.Add(this.class533_4);
				this.vector2_0 += new Vector2(5f + this.class533_4.vector2_9.X, 0f);
			}
			if (this.class533_3 == null)
			{
				this.class533_3 = new Class533("-", 10f, this.vector2_1 + this.vector2_0, 0.96f, true, Color.get_White());
				this.class533_3.bool_1 = true;
				this.class533_3.method_2(new EventHandler(this.method_14));
				this.class533_3.string_0 = Class41.GetString(OsuString.CollectionSprites_RemoveFromCollection);
				this.class533_3.enum72_0 = Enum72.const_2;
				this.class533_3.vector2_9 = new Vector2(20f, 11f);
				this.class533_3.method_53(Color.get_OrangeRed());
				this.class533_3.int_7 = 2;
				this.class533_3.method_55(Color.get_DarkOrange());
				this.list_0.Add(this.class533_3);
			}
		}

		// Token: 0x06001FEA RID: 8170
		// RVA: 0x0001A168 File Offset: 0x00018368
		[CompilerGenerated]
		private static bool smethod_0(Class296 class296_0)
		{
			return class296_0.method_3() == Class466.Current.method_3();
		}
	}
}
