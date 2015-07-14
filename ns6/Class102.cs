using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns27;
using ns79;
using ns8;
using ns80;
using ns82;
using ns84;
using ns90;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns6
{
	// Token: 0x0200063C RID: 1596
	internal sealed class Class102 : Class89
	{
		// Token: 0x0200063D RID: 1597
		[CompilerGenerated]
		private sealed class Class842
		{
			// Token: 0x04002D1D RID: 11549
			public Class102 class102_0;

			// Token: 0x04002D1A RID: 11546
			public Class533 class533_0;

			// Token: 0x04002D1B RID: 11547
			public Class533 class533_1;

			// Token: 0x04002D1C RID: 11548
			public Class533 class533_2;

			// Token: 0x06003160 RID: 12640
			// RVA: 0x00024814 File Offset: 0x00022A14
			public void method_0(object sender, EventArgs e)
			{
				this.class102_0.method_13(this.class533_0, this.class533_1);
			}

			// Token: 0x06003161 RID: 12641
			// RVA: 0x00143E84 File Offset: 0x00142084
			public void method_1(object sender, EventArgs e)
			{
				if (this.class533_0.bool_3)
				{
					if (this.class533_0.float_3 == 1f)
					{
						this.class533_0.method_53(Class610.smethod_2(this.class533_0.method_54(), 4f));
						this.class533_1.bool_16 = true;
						this.class533_1.bool_18 = true;
						this.class533_2.bool_18 = true;
						return;
					}
				}
			}

			// Token: 0x06003162 RID: 12642
			// RVA: 0x00143EF8 File Offset: 0x001420F8
			public void method_2(object sender, EventArgs e)
			{
				if (this.class533_0.bool_3)
				{
					if (this.class533_0.float_3 == 1f)
					{
						this.class533_0.method_53(Color.get_Black());
						this.class533_1.bool_16 = false;
						this.class533_1.bool_18 = true;
						this.class533_2.bool_18 = true;
						return;
					}
				}
			}
		}

		// Token: 0x0200063E RID: 1598
		[CompilerGenerated]
		private sealed class Class843
		{
			// Token: 0x04002D1E RID: 11550
			public float float_0;
		}

		// Token: 0x0200063F RID: 1599
		[CompilerGenerated]
		private sealed class Class844
		{
			// Token: 0x04002D20 RID: 11552
			public bool bool_0;

			// Token: 0x04002D21 RID: 11553
			public Class102 class102_0;

			// Token: 0x04002D1F RID: 11551
			public Class102.Class843 class843_0;

			// Token: 0x06003165 RID: 12645
			// RVA: 0x00143F5C File Offset: 0x0014215C
			public void method_0(Class531 class531_0)
			{
				this.class102_0.method_12(class531_0);
				if (this.bool_0)
				{
					class531_0.method_14(300, Enum70.const_0);
					class531_0.method_21(class531_0.bool_1 ? this.class843_0.float_0 : (this.class843_0.float_0 + 8f), 300, Enum70.const_1);
					return;
				}
				class531_0.method_16(300, Enum70.const_0);
			}
		}

		// Token: 0x02000640 RID: 1600
		[CompilerGenerated]
		private sealed class Class845
		{
			// Token: 0x04002D22 RID: 11554
			public string string_0;

			// Token: 0x06003167 RID: 12647
			// RVA: 0x0002482D File Offset: 0x00022A2D
			public bool method_0(Class21 class21_0)
			{
				return class21_0.string_0 == this.string_0;
			}
		}

		// Token: 0x04002D16 RID: 11542
		private readonly Class110 class110_0;

		// Token: 0x04002D13 RID: 11539
		private Class754 class754_0;

		// Token: 0x04002D14 RID: 11540
		private Color color_0 = new Color(154, 205, 50);

		// Token: 0x04002D15 RID: 11541
		private Color color_1 = new Color(255, 165, 0);

		// Token: 0x04002D19 RID: 11545
		[CompilerGenerated]
		private static Comparison<Class21> comparison_0;

		// Token: 0x04002D17 RID: 11543
		private Dictionary<Class21, List<Class531>> dictionary_0 = new Dictionary<Class21, List<Class531>>();

		// Token: 0x04002D12 RID: 11538
		private static int int_1 = 65;

		// Token: 0x04002D18 RID: 11544
		private List<Class21> list_1;

		// Token: 0x06003153 RID: 12627
		// RVA: 0x00143690 File Offset: 0x00141890
		internal Class102() : base(Class41.GetString(OsuString.ChannelListDialog_SelectAnyChannelYouWishToJoin), true)
		{
			this.class110_0 = new Class110(new Rectangle(0, 60, 550, 321), Vector2.get_Zero(), false, 0f, Enum98.const_5);
			this.float_0 = 400f;
			base.method_3(Class41.GetString(OsuString.General_Close), Class885.color_1, null, true, false, true);
		}

		// Token: 0x0600315C RID: 12636
		// RVA: 0x000247E4 File Offset: 0x000229E4
		protected override void Dispose(bool bool_5)
		{
			this.class110_0.Dispose();
			base.Dispose(bool_5);
		}

		// Token: 0x06003159 RID: 12633
		// RVA: 0x000247D1 File Offset: 0x000229D1
		internal override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
		}

		// Token: 0x06003154 RID: 12628
		// RVA: 0x00024799 File Offset: 0x00022999
		public override void imethod_2()
		{
			this.class110_0.imethod_2();
			base.imethod_2();
		}

		// Token: 0x06003157 RID: 12631
		// RVA: 0x00143818 File Offset: 0x00141A18
		private void method_10()
		{
			Vector2 vector;
			vector..ctor((float)(Class102.int_1 + 30), 0f);
			this.list_1 = new List<Class21>(Class111.list_1);
			List<Class21> arg_48_0 = this.list_1;
			if (Class102.comparison_0 == null)
			{
				Class102.comparison_0 = new Comparison<Class21>(Class102.smethod_2);
			}
			arg_48_0.Sort(Class102.comparison_0);
			foreach (Class21 current in this.list_1)
			{
				Class102.Class842 class = new Class102.Class842();
				class.class102_0 = this;
				if (current.string_0.StartsWith("#"))
				{
					string string_ = string.Format(Class41.GetString(OsuString.ChannelListDialog_TopicAndUserCount), string.IsNullOrEmpty(current.string_1) ? Class41.GetString(OsuString.ChannelListDialog_NoDescriptionAvailable) : current.string_1, current.vmethod_0());
					class.class533_0 = new Class533(string.Empty, 12f, vector, 0.95f, true, current.bool_0 ? Class885.color_1 : Class885.color_3);
					class.class533_0.bool_1 = true;
					class.class533_0.object_0 = current.string_0;
					class.class533_0.vector4_0 = Vector4.get_One() * 4f;
					class.class533_0.bool_2 = true;
					class.class533_0.vector2_9 = new Vector2(445f, 30f);
					class.class533_0.method_53(Color.get_Black());
					class.class533_0.int_7 = 2;
					class.class533_0.method_55(Color.get_White());
					class.class533_0.enum72_0 = Enum72.const_1;
					Vector2 vector2_ = vector;
					vector2_.Y += 8f;
					vector2_.X += 10f;
					class.class533_1 = new Class533(current.string_0, 12f, vector2_, 0.99f, true, current.bool_0 ? Class885.color_1 : Class885.color_3);
					class.class533_1.bool_1 = false;
					class.class533_2 = new Class533(string_, 12f, new Vector2(vector.X + 100f, vector.Y + 8f), 0.99f, true, Color.get_White());
					class.class533_2.vector2_9 = new Vector2(345f, 30f);
					class.class533_2.enum72_0 = Enum72.const_1;
					class.class533_2.bool_1 = false;
					class.class533_0.method_2(new EventHandler(class.method_0));
					class.class533_0.method_35(new EventHandler(class.method_1));
					class.class533_0.method_37(new EventHandler(class.method_2));
					vector.Y += 33f;
					this.class110_0.class911_0.Add(class.class533_0);
					this.class110_0.class911_0.Add(class.class533_1);
					this.class110_0.class911_0.Add(class.class533_2);
					this.dictionary_0[current] = new List<Class531>
					{
						class.class533_0,
						class.class533_1,
						class.class533_2
					};
				}
			}
			this.class110_0.method_14(new Vector2(160f, vector.Y));
		}

		// Token: 0x06003158 RID: 12632
		// RVA: 0x00143BC8 File Offset: 0x00141DC8
		private void method_11(Class754 class754_1, bool bool_5)
		{
			bool flag = this.class754_0.class533_0.Text.Length == 0;
			if (bool_5)
			{
				Class102.Class843 class = new Class102.Class843();
				class.float_0 = 0f;
				foreach (Class21 current in this.list_1)
				{
					Class102.Class844 class2 = new Class102.Class844();
					class2.class843_0 = class;
					class2.class102_0 = this;
					class2.bool_0 = (flag || current.string_0.Contains(this.class754_0.Text));
					if (current.string_0.Contains("#"))
					{
						this.dictionary_0[current].ForEach(new Action<Class531>(class2.method_0));
						if (class2.bool_0)
						{
							class.float_0 += 33f;
						}
					}
				}
				this.class110_0.method_14(new Vector2(160f, class.float_0));
			}
		}

		// Token: 0x0600315A RID: 12634
		// RVA: 0x00143CE8 File Offset: 0x00141EE8
		private void method_12(Class531 class531_1)
		{
			Class533 class = class531_1 as Class533;
			class.bool_16 = false;
		}

		// Token: 0x0600315B RID: 12635
		// RVA: 0x00143D04 File Offset: 0x00141F04
		private void method_13(Class533 class533_0, Class533 class533_1)
		{
			Class102.Class845 class = new Class102.Class845();
			class.string_0 = class533_0.object_0.ToString();
			Class21 class2 = Class111.list_1.Find(new Predicate<Class21>(class.method_0));
			if (class2 == null)
			{
				Class723.smethod_1(Class41.GetString(OsuString.ChannelListDialog_CantRejoinThisChannel), 1500);
				return;
			}
			if (Class802.buttonState_6 == 1)
			{
				if (!class2.bool_0 || !class2.bool_1)
				{
					return;
				}
				Class111.smethod_11(class2, false, false);
				Class723.smethod_1(string.Format(Class41.GetString(OsuString.ChannelListDialog_Left), class2.string_0), 1500);
				class533_0.method_39(Class885.color_3, 300, false, Enum70.const_0);
				class533_1.method_39(Class885.color_3, 300, false, Enum70.const_0);
			}
			else
			{
				if (!class2.bool_0)
				{
					try
					{
						Class21 class3 = Class111.smethod_8(class.string_0, false, true);
						if (class3 == null)
						{
							Class723.smethod_1(string.Format(Class41.GetString(OsuString.ChannelListDialog_JoiningTooFast), class.string_0), 1500);
							return;
						}
						Class111.class594_0.method_2(class3);
						Class723.smethod_1(string.Format(Class41.GetString(OsuString.ChannelListDialog_Joined), class3.string_0), 1500);
						class533_0.method_39(Class885.color_1, 300, false, Enum70.const_0);
						class533_1.method_39(Class885.color_1, 300, false, Enum70.const_0);
						goto IL_15A;
					}
					catch
					{
						goto IL_15A;
					}
				}
				Class723.smethod_1(Class41.GetString(OsuString.ChannelListDialog_AlreadyJoined), 1500);
			}
			IL_15A:
			this.imethod_2();
		}

		// Token: 0x06003156 RID: 12630
		// RVA: 0x000247AC File Offset: 0x000229AC
		private void method_9(Class754 class754_1, bool bool_5)
		{
			if (this.class754_0.Text.Length > 0 && bool_5)
			{
				this.class754_0.method_19(true);
				return;
			}
		}

		// Token: 0x0600315D RID: 12637
		// RVA: 0x000247F8 File Offset: 0x000229F8
		[CompilerGenerated]
		private static int smethod_2(Class21 class21_0, Class21 class21_1)
		{
			return class21_0.string_0.CompareTo(class21_1.string_0);
		}

		// Token: 0x06003155 RID: 12629
		// RVA: 0x00143734 File Offset: 0x00141934
		internal override void vmethod_3()
		{
			Class533 class530_ = new Class533(Class41.GetString(OsuString.Lobby_Search), 15f, new Vector2((float)(Class102.int_1 + 30), 35f), 0.95f, true, Color.get_White());
			this.class911_0.Add(class530_);
			this.class754_0 = new Class754(string.Empty, 15, new Vector2((float)(Class102.int_1 + 80), 35f), 100f, 0.94f, false);
			this.class754_0.bool_4 = false;
			this.class754_0.method_3(new Class754.Delegate37(this.method_11));
			this.class754_0.method_2(new Class754.Delegate37(this.method_9));
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			this.method_10();
			this.class754_0.method_19(true);
			base.vmethod_3();
		}
	}
}
