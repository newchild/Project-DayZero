using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns16;
using ns24;
using ns27;
using ns29;
using ns79;
using ns8;
using ns82;
using ns84;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns28
{
	// Token: 0x020004D0 RID: 1232
	internal sealed class Class95 : Class89
	{
		// Token: 0x020004D1 RID: 1233
		[CompilerGenerated]
		private sealed class Class640
		{
			// Token: 0x040020F8 RID: 8440
			public Class95 class95_0;

			// Token: 0x040020F7 RID: 8439
			public string string_0;

			// Token: 0x060027C1 RID: 10177
			// RVA: 0x0001EA05 File Offset: 0x0001CC05
			public bool method_0(Class296 class296_0)
			{
				return class296_0.string_12.IndexOf(this.string_0, StringComparison.CurrentCultureIgnoreCase) >= 0;
			}
		}

		// Token: 0x040020F3 RID: 8435
		public bool bool_5;

		// Token: 0x040020ED RID: 8429
		private readonly Class110 class110_0;

		// Token: 0x040020F4 RID: 8436
		public Class296 class296_0;

		// Token: 0x040020EC RID: 8428
		private Class533 class533_0;

		// Token: 0x040020EB RID: 8427
		private Class753 class753_0;

		// Token: 0x040020EE RID: 8430
		private Class756 class756_0;

		// Token: 0x040020EF RID: 8431
		private Class911 class911_1;

		// Token: 0x040020F0 RID: 8432
		private Class911 class911_2;

		// Token: 0x040020F6 RID: 8438
		[CompilerGenerated]
		private static Comparison<Class296> comparison_0;

		// Token: 0x040020F5 RID: 8437
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x040020F1 RID: 8433
		private int int_1;

		// Token: 0x040020F2 RID: 8434
		private int int_2;

		// Token: 0x040020E9 RID: 8425
		internal List<Class296> list_1 = new List<Class296>();

		// Token: 0x040020EA RID: 8426
		private List<Class641> list_2 = new List<Class641>();

		// Token: 0x060027B1 RID: 10161
		// RVA: 0x000F6AD4 File Offset: 0x000F4CD4
		public Class95() : base(Class41.GetString(OsuString.JumpToDialog_Title), true)
		{
			this.class911_0.Add(new Class540(new Vector2(10f, 79f), new Vector2((float)(Class115.smethod_43() - 20), 1f), 1f, Color.get_White()));
			this.class911_0.Add(new Class540(new Vector2(10f, 440f), new Vector2((float)(Class115.smethod_43() - 20), 1f), 1f, Color.get_White()));
			Rectangle rectangle_;
			rectangle_..ctor(10, 80, (int)(640f * Class115.smethod_46()) - 20, 360);
			this.class110_0 = new Class110(rectangle_, Vector2.get_Zero(), true, 0f, Enum98.const_5);
			this.class911_1 = new Class911(true);
			this.class911_2 = new Class911(true);
			this.class911_1.method_4(Class115.bool_21, null);
			this.int_1 = Class115.smethod_43();
			this.class533_0 = new Class533(Class41.GetString(OsuString.SongSelection_Collections) + ":", 20f, new Vector2(10f, 30f), 2f, true, new Color(254, 220, 97));
			this.class753_0 = new Class753(this.class911_2, "All", new Vector2(10f, 55f), 140f, 3f);
			this.class756_0 = new Class756(20, new Vector2(10f, 50f), 20, Enum72.const_3);
			this.int_2 = -1;
			this.class911_0.Add<Class531>(this.class756_0.list_0);
			this.class911_0.Add(this.class533_0);
			this.class110_0.method_30(this.class911_1);
			Class754 arg_1FF_0 = this.class756_0;
			Class754.Delegate37 delegate37_ = delegate(Class754 class754_0, bool bool_6)
			{
				if (bool_6)
				{
					if (this.class756_0.method_29() && this.class756_0.string_0.Length == 1)
					{
						this.int_2 = Class115.int_1;
						return;
					}
					if (!this.class756_0.method_29())
					{
						this.int_2 = Class115.int_1 + 300;
					}
				}
			};
			arg_1FF_0.method_3(delegate37_);
			if (Class95.eventHandler_4 == null)
			{
				Class95.eventHandler_4 = new EventHandler(Class95.smethod_2);
			}
			base.method_2(Class95.eventHandler_4);
			this.class753_0.method_9("All", "All");
			this.class753_0.method_18("All", true);
			foreach (string current in Class476.smethod_0().Keys)
			{
				this.class753_0.method_9(current, current);
			}
			this.class753_0.method_0(new EventHandler(this.method_11));
			this.class296_0 = Class466.Current;
			this.method_9();
		}

		// Token: 0x060027B4 RID: 10164
		// RVA: 0x0001E991 File Offset: 0x0001CB91
		protected override void Dispose(bool bool_6)
		{
			base.Dispose(bool_6);
			this.class756_0.Dispose();
			this.class110_0.Dispose();
		}

		// Token: 0x060027B2 RID: 10162
		// RVA: 0x0001E96D File Offset: 0x0001CB6D
		internal override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
			this.class911_2.Draw();
			Class109.Draw();
		}

		// Token: 0x060027B3 RID: 10163
		// RVA: 0x000F6DAC File Offset: 0x000F4FAC
		public override void imethod_2()
		{
			this.method_13(false, false);
			base.imethod_2();
			this.class110_0.imethod_2();
			Class109.class911_0.float_0 = 1f;
			if (!this.class756_0.method_0() || !this.class756_0.textInputControl_0.method_3())
			{
				this.class756_0.method_19(true);
			}
			if (this.int_2 > 0 && this.int_2 < Class115.int_1)
			{
				this.int_2 = -1;
				this.method_9();
			}
		}

		// Token: 0x060027B6 RID: 10166
		// RVA: 0x000F6F48 File Offset: 0x000F5148
		private void method_10()
		{
			Class95.Class640 class = new Class95.Class640();
			class.class95_0 = this;
			this.list_1.Clear();
			class.string_0 = this.class756_0.Text;
			List<Class296> list;
			if (this.class753_0.object_0 != "All")
			{
				list = Class466.list_3.FindAll(new Predicate<Class296>(this.method_15));
			}
			else
			{
				list = new List<Class296>(Class466.list_3);
			}
			if (!string.IsNullOrEmpty(class.string_0))
			{
				list = list.FindAll(new Predicate<Class296>(class.method_0));
			}
			if (list.Count == 0)
			{
				return;
			}
			list.Sort();
			this.list_1.Add(list[0]);
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].method_3() != list[i - 1].method_3())
				{
					this.list_1.Add(list[i]);
				}
			}
			List<Class296> arg_109_0 = this.list_1;
			if (Class95.comparison_0 == null)
			{
				Class95.comparison_0 = new Comparison<Class296>(Class95.smethod_3);
			}
			arg_109_0.Sort(Class95.comparison_0);
		}

		// Token: 0x060027B7 RID: 10167
		// RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		private void method_11(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x060027B8 RID: 10168
		// RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		private void method_12(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				this.Close(false);
			}
		}

		// Token: 0x060027B9 RID: 10169
		// RVA: 0x000F7064 File Offset: 0x000F5264
		internal void method_13(bool bool_6, bool bool_7)
		{
			if (Class466.Current != this.class296_0 || bool_6 || bool_7)
			{
				if (!bool_6)
				{
					this.class296_0 = Class466.Current;
				}
				else
				{
					Class466.smethod_21(this.class296_0);
				}
				foreach (Class641 current in this.list_2)
				{
					if (this.class296_0.string_4 == current.class296_0.string_4)
					{
						current.class540_0.method_25(0.6f, 100, Enum70.const_0);
						current.class540_0.method_39(Color.get_CornflowerBlue(), 100, false, Enum70.const_0);
						if (!bool_6)
						{
							if (this.list_2.Count <= 12)
							{
								this.class110_0.method_14(new Vector2(0f, 0f));
							}
							else if ((float)(this.list_2.IndexOf(current) * 30) >= this.class110_0.vector2_2.Y - 360f)
							{
								this.class110_0.method_17(new Vector2(0f, this.class110_0.vector2_2.Y - 360f), 0f);
							}
							else
							{
								this.class110_0.method_17(new Vector2(0f, (float)(30 * this.list_2.IndexOf(current))), 0f);
							}
						}
					}
					else if (current.class540_0.float_3 != 0.001f)
					{
						current.class540_0.method_25(0.001f, 20, Enum70.const_0);
						current.class540_0.method_39(Color.get_White(), 20, false, Enum70.const_0);
					}
				}
			}
			if (bool_6 && !this.bool_5)
			{
				Class109.smethod_3(false, false);
				Class109.smethod_4(Class466.Current);
			}
		}

		// Token: 0x060027BA RID: 10170
		// RVA: 0x000F724C File Offset: 0x000F544C
		private void method_14(bool bool_6)
		{
			foreach (Class641 current in this.list_2)
			{
				if (this.class296_0.string_4 == current.class296_0.string_4)
				{
					if ((!bool_6 || this.list_2.IndexOf(current) < this.list_2.Count - 1) && (bool_6 || this.list_2.IndexOf(current) > 0))
					{
						int index = bool_6 ? (this.list_2.IndexOf(current) + 1) : (this.list_2.IndexOf(current) - 1);
						int num = bool_6 ? 10 : 1;
						this.class296_0 = this.list_1[index];
						this.method_13(true, false);
						if ((bool_6 && this.class110_0.vector2_3.Y + 300f <= (float)(this.list_2.IndexOf(current) * 30)) || (!bool_6 && this.class110_0.vector2_3.Y >= (float)(this.list_2.IndexOf(current) * 30)))
						{
							this.class110_0.method_17(new Vector2(0f, (float)(30 * (this.list_2.IndexOf(current) - num))), 0f);
						}
					}
					break;
				}
			}
		}

		// Token: 0x060027BE RID: 10174
		// RVA: 0x0001E9D0 File Offset: 0x0001CBD0
		[CompilerGenerated]
		private bool method_15(Class296 class296_1)
		{
			return Class476.smethod_0()[this.class753_0.string_0].Contains(class296_1.string_3);
		}

		// Token: 0x060027B5 RID: 10165
		// RVA: 0x000F6E30 File Offset: 0x000F5030
		private void method_9()
		{
			int num = 0;
			Class109.smethod_6();
			this.method_10();
			this.class911_1.Clear(true);
			this.list_2.Clear();
			foreach (Class296 current in this.list_1)
			{
				num++;
				if (num >= 250)
				{
					break;
				}
				Class641 class = new Class641(current, this, current.Title, current.Artist, num - 1);
				class.class540_0.method_2(new EventHandler(this.method_12));
				this.list_2.Add(class);
				this.class911_1.Add(class.class533_0);
				this.class911_1.Add(class.class540_0);
				Class109.smethod_5(current);
			}
			int num2 = (num >= 250) ? (num - 1) : num;
			this.class110_0.method_14(new Vector2(640f * Class115.smethod_46(), (float)(num2 * 30)));
			this.method_13(false, true);
		}

		// Token: 0x060027BD RID: 10173
		// RVA: 0x0001E9C9 File Offset: 0x0001CBC9
		[CompilerGenerated]
		private static void smethod_2(object sender, EventArgs e)
		{
			Class109.smethod_6();
		}

		// Token: 0x060027BF RID: 10175
		// RVA: 0x0001E9F2 File Offset: 0x0001CBF2
		[CompilerGenerated]
		private static int smethod_3(Class296 class296_1, Class296 class296_2)
		{
			return class296_2.dateTime_0.CompareTo(class296_1.dateTime_0);
		}

		// Token: 0x060027BB RID: 10171
		// RVA: 0x000F73C0 File Offset: 0x000F55C0
		internal override bool vmethod_5(Keys keys_0)
		{
			if (Class115.class109_0.method_2(null, keys_0))
			{
				return true;
			}
			switch (keys_0)
			{
			case 38:
				this.method_14(false);
				return true;
			case 40:
				this.method_14(true);
				return true;
			}
			return base.vmethod_5(keys_0);
		}
	}
}
