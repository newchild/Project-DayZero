using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns24;
using ns26;
using ns29;
using ns59;
using ns60;
using ns69;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns89;
using ns90;
using ns94;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.Events;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns68
{
	// Token: 0x0200038F RID: 911
	internal sealed class Class374 : Class371
	{
		// Token: 0x02000390 RID: 912
		[CompilerGenerated]
		private sealed class Class384
		{
			// Token: 0x04001675 RID: 5749
			public Class374 class374_0;

			// Token: 0x04001673 RID: 5747
			public int int_0;

			// Token: 0x04001674 RID: 5748
			public int int_1;

			// Token: 0x06001C4A RID: 7242
			// RVA: 0x00017512 File Offset: 0x00015712
			public void method_0(Class304 class304_0)
			{
				if (class304_0.EndTime >= this.int_0 && class304_0.StartTime <= this.int_1)
				{
					this.class374_0.Select(class304_0);
					return;
				}
			}
		}

		// Token: 0x02000391 RID: 913
		[CompilerGenerated]
		private sealed class Class385
		{
			// Token: 0x04001676 RID: 5750
			public Class374 class374_0;

			// Token: 0x04001677 RID: 5751
			public Keys keys_0;

			// Token: 0x06001C4C RID: 7244
			// RVA: 0x0001753D File Offset: 0x0001573D
			public bool method_0(Class409 class409_0)
			{
				return class409_0.Key == this.keys_0 || class409_0.method_0() == this.keys_0;
			}
		}

		// Token: 0x0400166B RID: 5739
		private bool bool_21;

		// Token: 0x0400166E RID: 5742
		private bool bool_22;

		// Token: 0x04001662 RID: 5730
		private Class304 class304_3;

		// Token: 0x04001667 RID: 5735
		private Class306[] class306_0;

		// Token: 0x04001661 RID: 5729
		private Class308 class308_0;

		// Token: 0x04001659 RID: 5721
		private Class531 class531_3;

		// Token: 0x0400165B RID: 5723
		private Class531 class531_4;

		// Token: 0x0400165A RID: 5722
		internal Class533 class533_7;

		// Token: 0x04001668 RID: 5736
		protected Class704 class704_0;

		// Token: 0x0400165C RID: 5724
		private Class911 class911_1;

		// Token: 0x04001672 RID: 5746
		[CompilerGenerated]
		private static Comparison<Class304> comparison_1;

		// Token: 0x04001654 RID: 5716
		private float float_0 = 160f;

		// Token: 0x0400165E RID: 5726
		private float float_1 = -1f;

		// Token: 0x04001663 RID: 5731
		private float float_2;

		// Token: 0x04001670 RID: 5744
		private float float_3;

		// Token: 0x0400165D RID: 5725
		private int int_10 = -1;

		// Token: 0x0400165F RID: 5727
		private int int_11;

		// Token: 0x04001660 RID: 5728
		private int int_12;

		// Token: 0x04001664 RID: 5732
		private int int_13;

		// Token: 0x04001669 RID: 5737
		private int int_14 = -1;

		// Token: 0x0400166A RID: 5738
		private int int_15 = -1;

		// Token: 0x0400166C RID: 5740
		private int int_16;

		// Token: 0x0400166D RID: 5741
		private int int_17;

		// Token: 0x0400166F RID: 5743
		private int int_18 = -1;

		// Token: 0x04001651 RID: 5713
		private int int_4;

		// Token: 0x04001652 RID: 5714
		private int int_5 = 80;

		// Token: 0x04001653 RID: 5715
		private int int_6 = 160;

		// Token: 0x04001655 RID: 5717
		private int int_7 = 64;

		// Token: 0x04001656 RID: 5718
		private int int_8 = 458;

		// Token: 0x04001657 RID: 5719
		private int int_9 = 7;

		// Token: 0x04001665 RID: 5733
		private List<Class704> list_3;

		// Token: 0x04001666 RID: 5734
		private List<Class704> list_4;

		// Token: 0x04001671 RID: 5745
		[CompilerGenerated]
		private static Predicate<Class530> predicate_8;

		// Token: 0x04001658 RID: 5720
		private Vector2 vector2_7;

		// Token: 0x06001C0B RID: 7179
		// RVA: 0x00093E18 File Offset: 0x00092018
		public Class374(Editor editor_1) : base(editor_1)
		{
		}

		// Token: 0x06001C0F RID: 7183
		// RVA: 0x000172F6 File Offset: 0x000154F6
		internal override void Dispose()
		{
			this.class531_3.Dispose();
			this.class911_1.Dispose();
			base.Dispose();
		}

		// Token: 0x06001C17 RID: 7191
		// RVA: 0x00094EB4 File Offset: 0x000930B4
		internal override void Draw()
		{
			this.class911_0.Draw();
			this.class911_1.Draw();
			if (this.bool_5 && this.editor_0.enum108_0 == Enum108.const_2)
			{
				Color color_;
				color_..ctor(255, 255, 255, 180);
				Vector2 vector2_;
				vector2_..ctor(this.vector2_1.X, this.vector2_0.Y);
				Vector2 vector2_2;
				vector2_2..ctor(this.vector2_0.X, this.vector2_1.Y);
				Class115.class882_0.method_0();
				Class115.class882_0.method_1(this.vector2_0, color_);
				Class115.class882_0.method_1(vector2_, color_);
				Class115.class882_0.method_1(vector2_, color_);
				Class115.class882_0.method_1(this.vector2_1, color_);
				Class115.class882_0.method_1(this.vector2_1, color_);
				Class115.class882_0.method_1(vector2_2, color_);
				Class115.class882_0.method_1(vector2_2, color_);
				Class115.class882_0.method_1(this.vector2_0, color_);
				Class115.class882_0.method_2();
				Class115.class582_0.method_2(this.vector2_0, this.vector2_1, this.color_4);
			}
			if (Class331.smethod_17())
			{
				this.class533_7.Text = string.Format("{0}:{1}", this.int_17, this.int_16);
				return;
			}
			this.class533_7.Text = "-";
		}

		// Token: 0x06001C0C RID: 7180
		// RVA: 0x00093E8C File Offset: 0x0009208C
		internal override void Initialize()
		{
			this.int_9 = (int)Math.Round((double)Class466.Current.DifficultyCircleSize);
			this.class297_0.class421_0 = new Class421(Class885.smethod_21(this.int_9, Mods.None), true, 0f, 480f, float.NaN, 1f, 0, 0);
			this.float_0 = (float)this.int_6 + this.method_72() * (float)this.int_9;
			this.class911_1 = new Class911(true);
			this.list_0 = new List<Class304>();
			this.list_4 = new List<Class704>();
			this.list_3 = new List<Class704>();
			this.class306_0 = new Class306[this.int_9];
			base.Initialize();
		}

		// Token: 0x06001C07 RID: 7175
		// RVA: 0x00093DE4 File Offset: 0x00091FE4
		private float method_72()
		{
			float num = (float)(Class115.smethod_43() - this.int_6) - 70f;
			return Math.Min(30f, num / (float)this.int_9);
		}

		// Token: 0x06001C08 RID: 7176
		// RVA: 0x000172E8 File Offset: 0x000154E8
		private float method_73()
		{
			return this.method_72() / 30f;
		}

		// Token: 0x06001C10 RID: 7184
		// RVA: 0x00094494 File Offset: 0x00092694
		private void method_74(ref int int_19, ref int int_20)
		{
			int_19 = -1;
			int_20 = -1;
			foreach (Class304 current in this.list_1)
			{
				int num = this.class297_0.class421_0.method_43(current.Position, false);
				if (int_19 == -1)
				{
					int_19 = num;
					int_20 = num;
				}
				else if (num <= int_19)
				{
					int_19 = num;
				}
				else if (num >= int_20)
				{
					int_20 = num;
				}
			}
		}

		// Token: 0x06001C11 RID: 7185
		// RVA: 0x00017314 File Offset: 0x00015514
		private void method_75()
		{
			this.int_11 = Class331.int_7 - this.editor_0.int_7 / 12;
			this.int_12 = Class331.int_7 + this.editor_0.int_7 / 3;
		}

		// Token: 0x06001C12 RID: 7186
		// RVA: 0x00094520 File Offset: 0x00092720
		private void method_76()
		{
			this.vector2_1 = Class802.vector2_0;
			this.vector2_1.X = Math.Min(this.vector2_1.X, ((float)this.int_6 + (float)this.int_9 * this.method_72() + this.method_72()) * Class115.float_4);
			RectangleF rectangleF = new RectangleF(Math.Min(this.vector2_0.X, this.vector2_1.X), Math.Min(this.vector2_0.Y, this.vector2_1.Y), Math.Abs(this.vector2_0.X - this.vector2_1.X), Math.Abs(this.vector2_0.Y - this.vector2_1.Y));
			Vector2 vector = this.vector2_0 / Class115.float_4;
			Vector2 vector2 = this.vector2_1 / Class115.float_4;
			vector.Y -= (float)Class115.int_25 / Class115.float_4;
			vector2.Y -= (float)Class115.int_25 / Class115.float_4;
			this.vmethod_17();
			if (vector.X > (float)this.int_5 && vector.X < (float)(this.int_5 + 60) && vector2.X > (float)this.int_5 && vector2.X < (float)(this.int_5 + 60))
			{
				Action<Class304> action = null;
				Class374.Class384 class = new Class374.Class384();
				class.class374_0 = this;
				int val = (int)(((float)this.int_8 - vector.Y) / (float)(this.int_8 - this.int_7) * (float)Class331.smethod_31());
				int num = (int)(((float)this.int_8 - vector2.Y) / (float)(this.int_8 - this.int_7) * (float)Class331.smethod_31());
				class.int_0 = Math.Min(val, num);
				class.int_1 = Math.Max(val, num);
				if (this.editor_0.enum108_0 == Enum108.const_2)
				{
					List<Class304> arg_219_0 = this.class297_0.list_3;
					if (action == null)
					{
						action = new Action<Class304>(class.method_0);
					}
					arg_219_0.ForEach(action);
				}
				Class331.smethod_70(num, false, false);
				return;
			}
			if (this.editor_0.enum108_0 == Enum108.const_2)
			{
				for (int i = 0; i < this.class911_1.list_2.Count; i++)
				{
					Class531 class2 = (Class531)this.class911_1.list_2[i];
					if (rectangleF.Contains(class2.rectangleF_0) && class2.object_0 != null)
					{
						if (this.bool_22)
						{
							this.Select((Class704)class2.object_0);
						}
						else
						{
							this.Select((Class304)class2.object_0);
						}
					}
				}
			}
		}

		// Token: 0x06001C13 RID: 7187
		// RVA: 0x000947E4 File Offset: 0x000929E4
		private void method_77()
		{
			if (this.bool_5)
			{
				this.method_76();
				return;
			}
			if (!Class371.dictionary_0[Enum106.flag_5] && this.bool_8)
			{
				int num = (int)((this.vector2_7.X - this.float_2) / this.method_72());
				int num2 = this.method_88(this.vector2_7.Y) - this.int_13;
				this.int_4 += num2;
				int num3 = (int)(this.editor_0.double_0 * Math.Round((double)this.int_4 / this.editor_0.double_0));
				if (Math.Abs(num3) > 0)
				{
					this.int_4 -= num3;
				}
				bool flag = true;
				if (this.bool_22)
				{
					if (Class570.bool_2)
					{
						num3 = num2;
					}
					if (!flag)
					{
						goto IL_2B2;
					}
					using (List<Class704>.Enumerator enumerator = this.list_3.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class704 current = enumerator.Current;
							current.int_2 += num3;
						}
						goto IL_2B2;
					}
				}
				int num4;
				int num5;
				this.method_74(ref num4, ref num5);
				if (this.int_14 != -1 && this.int_15 != -1)
				{
					num = this.int_14 - this.int_15;
				}
				else if (this.vector2_7.X < (float)this.int_6)
				{
					num = num4 * -1;
				}
				else if (this.vector2_7.X > this.float_0)
				{
					num = this.class297_0.class421_0.list_0.Count - num5 - 1;
				}
				else
				{
					num = 0;
				}
				bool flag2 = num4 + num >= 0 && this.vector2_7.X < this.float_0;
				bool flag3 = num5 + num <= this.class297_0.class421_0.list_0.Count - 1 && this.vector2_7.X > (float)this.int_6;
				foreach (Class304 current2 in this.list_1)
				{
					if (flag)
					{
						current2.StartTime += num2;
						current2.EndTime += num2;
					}
					if ((flag2 && num < 0) || (flag3 && num > 0))
					{
						int num6 = this.class297_0.class421_0.method_43(current2.Position, false);
						num6 += num;
						num6 = Math.Min(this.int_9, Math.Max(0, num6));
						current2.Position.X = (current2.vector2_0.X = (float)this.class297_0.class421_0.list_0[num6].method_14());
					}
				}
				IL_2B2:
				if (num != 0)
				{
					this.float_2 = this.vector2_7.X;
				}
				if (num2 != 0)
				{
					this.int_13 = this.method_88(this.vector2_7.Y);
				}
				return;
			}
		}

		// Token: 0x06001C15 RID: 7189
		// RVA: 0x00094C90 File Offset: 0x00092E90
		internal void method_78()
		{
			if (this.editor_0.bool_10 && Class331.enum100_0 == Enum100.const_1 && !this.bool_22)
			{
				bool flag = false;
				for (int i = 0; i < this.class297_0.class421_0.list_0.Count; i++)
				{
					if (this.class297_0.class421_0.list_0[i].method_5() && !this.class297_0.class421_0.list_0[i].bool_2)
					{
						Class306 class = new Class306(this.class297_0, new Vector2((float)this.class297_0.class421_0.list_0[i].method_14(), 192f), this.editor_0.class375_0.method_5((double)Class331.int_7), false, false, false, false, 0);
						this.method_84(class);
						this.class306_0[i] = class;
						flag = true;
					}
					else if (!this.class297_0.class421_0.list_0[i].method_5() && this.class297_0.class421_0.list_0[i].bool_2)
					{
						int num = this.editor_0.class375_0.method_5((double)Class331.int_7);
						Class306 class2 = this.class306_0[i];
						if (class2 != null && num - class2.StartTime > 300)
						{
							this.class297_0.Remove(class2, false);
							this.method_84(new Class308(this.class297_0, class2.Position, class2.StartTime, false, false, false, false, 0)
							{
								EndTime = num
							});
							this.class306_0[i] = null;
							flag = true;
						}
					}
				}
				if (flag)
				{
					this.class297_0.method_20(true);
				}
			}
		}

		// Token: 0x06001C16 RID: 7190
		// RVA: 0x00094E58 File Offset: 0x00093058
		private int method_79()
		{
			if (!this.bool_21)
			{
				return -1;
			}
			float num = (float)this.int_6;
			for (int i = 0; i < this.class297_0.class421_0.list_0.Count; i++)
			{
				num += this.method_72();
				if (this.vector2_7.X <= num)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C1A RID: 7194
		// RVA: 0x00095034 File Offset: 0x00093234
		private Class531 method_80()
		{
			for (int i = 0; i < this.class911_1.list_2.Count; i++)
			{
				Class531 class = this.class911_1.list_2[i] as Class531;
				if (class.rectangleF_0.Contains(Class802.vector2_0.X, Class802.vector2_0.Y) && class.object_0 != null)
				{
					return class;
				}
			}
			return null;
		}

		// Token: 0x06001C1B RID: 7195
		// RVA: 0x000950A0 File Offset: 0x000932A0
		private Class304 method_81()
		{
			Class531 class = this.method_80();
			if (class == null)
			{
				return null;
			}
			return class.object_0 as Class304;
		}

		// Token: 0x06001C1C RID: 7196
		// RVA: 0x000950C4 File Offset: 0x000932C4
		private Class704 method_82()
		{
			Class531 class = this.method_80();
			if (class != null)
			{
				if (class.int_0 == -10010)
				{
					return class.object_0 as Class704;
				}
			}
			return null;
		}

		// Token: 0x06001C1E RID: 7198
		// RVA: 0x000956BC File Offset: 0x000938BC
		private bool method_83()
		{
			return this.vector2_7.X > (float)this.int_6 && this.vector2_7.X < this.float_0 && this.vector2_7.Y > (float)this.int_7 && this.vector2_7.Y < (float)this.int_8;
		}

		// Token: 0x06001C21 RID: 7201
		// RVA: 0x00017349 File Offset: 0x00015549
		private void method_84(Class304 class304_4)
		{
			this.class297_0.vmethod_9(class304_4);
		}

		// Token: 0x06001C27 RID: 7207
		// RVA: 0x00095F78 File Offset: 0x00094178
		private void method_85(bool bool_23)
		{
			if (this.list_3.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			if (bool_23)
			{
				this.list_3.ForEach(new Action<Class704>(this.method_96));
				return;
			}
			this.list_3.ForEach(new Action<Class704>(this.method_97));
		}

		// Token: 0x06001C28 RID: 7208
		// RVA: 0x00095FD4 File Offset: 0x000941D4
		private void method_86(int int_19, int int_20)
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			foreach (Class304 current in this.list_1)
			{
				if (int_19 != 0)
				{
					int num = this.class297_0.class421_0.method_43(current.Position, false);
					num += int_19;
					num = Math.Min(this.int_9 - 1, Math.Max(0, num));
					current.Position.X = (current.vector2_0.X = (float)this.class297_0.class421_0.list_0[num].method_14());
				}
				if (int_20 != 0)
				{
					double num2 = Class331.smethod_22((double)current.StartTime, false) / (double)this.editor_0.int_6;
					current.StartTime += (int)num2 * int_20;
					current.EndTime += (int)num2 * int_20;
				}
			}
		}

		// Token: 0x06001C2B RID: 7211
		// RVA: 0x00017387 File Offset: 0x00015587
		private float method_87(int int_19)
		{
			return (float)this.int_8 - (float)((int_19 - this.int_11) * (this.int_8 - this.int_7)) * 1f / (float)(this.int_12 - this.int_11);
		}

		// Token: 0x06001C2C RID: 7212
		// RVA: 0x000173BD File Offset: 0x000155BD
		private int method_88(float float_4)
		{
			return (int)((float)(this.int_12 - this.int_11) * ((float)this.int_8 - float_4) * 1f / (float)(this.int_8 - this.int_7) + (float)this.int_11);
		}

		// Token: 0x06001C2E RID: 7214
		// RVA: 0x000964E4 File Offset: 0x000946E4
		private void method_89(Class704 class704_1, int int_19)
		{
			if (int_19 != this.int_18)
			{
				this.float_3 = (float)this.int_6;
			}
			else
			{
				this.float_3 += (float)this.int_9 * this.method_72() / 8f;
			}
			this.int_18 = int_19;
			Color color_ = class704_1.bool_3 ? Color.get_LightSkyBlue() : Color.get_Orange();
			Class531 class = new Class531(Class885.Load("mania-note1", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2(this.float_3, this.method_87(int_19)), 0.92f, true, color_, class704_1);
			class.int_0 = -10010;
			class.vector2_2 = new Vector2((float)this.int_9 / 8f * this.method_73(), 1f) * 0.1875f;
			this.class911_1.Add(class);
		}

		// Token: 0x06001C2F RID: 7215
		// RVA: 0x000965BC File Offset: 0x000947BC
		private void method_90(Class304 class304_4, int int_19, float float_4, bool bool_23)
		{
			int num = class304_4.class297_0.class421_0.method_43(class304_4.Position, false);
			Color color_ = class304_4.method_2() ? Color.get_LightSkyBlue() : class304_4.class297_0.class421_0.list_0[num].method_16();
			if (class304_4.StartTime == class304_4.EndTime)
			{
				Class531 class = new Class531(Class885.Load("mania-note1", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)num + float_4, this.method_87(class304_4.StartTime)), 0.92f, true, color_, class304_4);
				class.int_0 = class304_4.StartTime;
				class.vector2_2.X = this.method_73();
				class.float_2 = 0.1875f;
				this.class911_1.Add(class);
			}
			else
			{
				Class531 class;
				if (class304_4.StartTime >= this.int_11 && class304_4.StartTime < this.int_12)
				{
					class = new Class531(Class885.Load("mania-note1", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)num + float_4, this.method_87(class304_4.StartTime)), 0.92f, true, color_, class304_4);
					class.int_0 = class304_4.StartTime;
					class.vector2_2.X = this.method_73();
					class.float_2 = 0.1875f;
					this.class911_1.Add(class);
				}
				if (class304_4.EndTime >= this.int_11 && class304_4.EndTime < this.int_12)
				{
					class = new Class531(Class885.Load("mania-note1", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)num + float_4, this.method_87(class304_4.EndTime)), 0.92f, true, color_, class304_4);
					class.int_0 = class304_4.EndTime;
					class.vector2_2.X = this.method_73();
					class.float_2 = 0.1875f;
					this.class911_1.Add(class);
				}
				float num2 = Math.Min((float)this.int_8, this.method_87(class304_4.StartTime));
				float num3 = Math.Max((float)this.int_7, this.method_87(class304_4.EndTime));
				class = new Class531(Class885.smethod_27("mania-note1L", Enum112.flag_1, true)[0], Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)num + float_4, num2), 0.918f, true, color_, class304_4);
				class.int_0 = class304_4.StartTime;
				class.vector2_2 = new Vector2(0.1875f * this.method_73(), (num2 - num3) / 82f * 1.6f);
				this.class911_1.Add(class);
			}
			if (bool_23 && class304_4.StartTime > this.int_11 && class304_4.StartTime < this.int_12)
			{
				string text = string.Empty;
				if (!string.IsNullOrEmpty(class304_4.string_0))
				{
					text = this.method_91(class304_4.string_0);
				}
				else if (class304_4.SoundType != HitObjectSoundType.None)
				{
					if (class304_4.Whistle)
					{
						text += "W|";
					}
					if (class304_4.Finish)
					{
						text += "F|";
					}
					if (class304_4.Clap)
					{
						text += "C";
					}
					if (text.EndsWith("|"))
					{
						text = text.Substring(0, text.Length - 1);
					}
				}
				if (text != string.Empty)
				{
					Class533 class530_ = new Class533(text, 10f, new Vector2((float)this.int_6 + this.method_72() * (float)num + float_4, this.method_87(class304_4.StartTime) - 10f), 0.93f, true, Color.get_White());
					this.class911_1.Add(class530_);
				}
			}
		}

		// Token: 0x06001C30 RID: 7216
		// RVA: 0x000173F5 File Offset: 0x000155F5
		private string method_91(string string_0)
		{
			return string_0.Substring(0, string_0.LastIndexOf("."));
		}

		// Token: 0x06001C31 RID: 7217
		// RVA: 0x0009697C File Offset: 0x00094B7C
		internal void method_92()
		{
			double num = Class331.smethod_22((double)Class331.int_7, false) / (double)this.editor_0.int_6;
			int num2;
			double num3;
			if (Class331.smethod_17())
			{
				num2 = (int)(((double)this.int_11 - Class331.smethod_12()) / Class331.smethod_8());
				num3 = (double)num2 * Class331.smethod_8() + Class331.smethod_12();
			}
			else
			{
				num3 = (double)this.int_11 / num + num;
				num2 = 0;
			}
			int num4 = (int)((Class331.int_2 < 0) ? Enum37.const_0 : Class331.smethod_14()[Class331.int_2].enum37_0);
			if (num > 1E-05)
			{
				int num5 = 0;
				for (double num6 = num3; num6 < (double)this.int_12; num6 += num)
				{
					int num7 = num5 % this.editor_0.int_6;
					Color color_ = this.editor_0.color_14;
					if (this.editor_0.int_6 == 1)
					{
						color_ = this.editor_0.color_14;
					}
					else if (this.editor_0.int_6 == 2)
					{
						color_ = ((num7 == 0) ? this.editor_0.color_14 : this.editor_0.color_12);
					}
					else if (this.editor_0.int_6 == 4)
					{
						if (num7 == 0)
						{
							color_ = this.editor_0.color_14;
						}
						else
						{
							if (num7 != 1)
							{
								if (num7 != 3)
								{
									color_ = this.editor_0.color_12;
									goto IL_221;
								}
							}
							color_ = this.editor_0.color_10;
						}
					}
					else
					{
						if (this.editor_0.int_6 != 8)
						{
							if (this.editor_0.int_6 != 16)
							{
								if (this.editor_0.int_6 != 3 && this.editor_0.int_6 != 6 && this.editor_0.int_6 != 12)
								{
									goto IL_221;
								}
								if (num7 % 3 == 0)
								{
									color_ = this.editor_0.color_12;
									goto IL_221;
								}
								if (num7 == 0)
								{
									color_ = this.editor_0.color_14;
									goto IL_221;
								}
								color_ = this.editor_0.color_13;
								goto IL_221;
							}
						}
						if (num7 == 0)
						{
							color_ = this.editor_0.color_14;
						}
						else if ((num7 - 1) % 2 == 0)
						{
							color_ = this.editor_0.color_11;
						}
						else if (num7 % 4 == 0)
						{
							color_ = this.editor_0.color_12;
						}
						else
						{
							color_ = this.editor_0.color_10;
						}
					}
					IL_221:
					if (num6 >= (double)this.int_11)
					{
						float num8 = this.method_87((int)num6);
						Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6, num8), 0.916f, true, color_, null);
						class.vector2_2 = new Vector2((float)this.int_9 * this.method_72(), 1f) * 1.6f;
						this.class911_1.Add(class);
						if (this.class297_1 != null)
						{
							class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)this.int_9 + this.method_72(), num8), 0.916f, true, color_, null);
							class.vector2_2 = new Vector2((float)((int)Math.Round((double)this.class297_1.class296_0.DifficultyCircleSize)) * this.method_72(), 1f) * 1.6f;
							class.int_0 = -10086;
							this.class911_1.Add(class);
						}
						if (num2 % num4 == 0 && num5 % this.editor_0.int_6 == 0)
						{
							class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6, num8 - 2f), 0.916f, true, color_, null);
							class.vector2_2 = new Vector2((float)this.int_9 * this.method_72(), 1f) * 1.6f;
							this.class911_1.Add(class);
							if (this.class297_1 != null)
							{
								class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)this.int_9 + this.method_72(), num8 - 2f), 0.916f, true, color_, null);
								class.vector2_2 = new Vector2((float)((int)Math.Round((double)this.class297_1.class296_0.DifficultyCircleSize)) * this.method_72(), 1f) * 1.6f;
								class.int_0 = -10086;
								this.class911_1.Add(class);
							}
						}
					}
					if (num5 % this.editor_0.int_6 == 0)
					{
						num2++;
					}
					num5++;
				}
			}
		}

		// Token: 0x06001C34 RID: 7220
		// RVA: 0x00096E04 File Offset: 0x00095004
		internal void method_93()
		{
			SampleSet sampleSet = SampleSet.None;
			SampleSet sampleSet2 = SampleSet.None;
			bool flag;
			bool flag2;
			bool flag3;
			if (!this.bool_22 && this.list_1.Count != 0)
			{
				sampleSet = this.list_1[0].sampleSet_0;
				sampleSet2 = this.list_1[0].sampleSet_1;
				bool arg_49_0 = true;
				flag = true;
				flag2 = true;
				flag3 = arg_49_0;
				bool flag4 = true;
				bool flag5 = true;
				using (List<Class304>.Enumerator enumerator = this.list_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class304 current = enumerator.Current;
						if (flag4 && sampleSet != current.sampleSet_0)
						{
							sampleSet = SampleSet.None;
							flag4 = false;
						}
						if (flag5 && sampleSet2 != current.sampleSet_1)
						{
							sampleSet2 = SampleSet.None;
							flag5 = false;
						}
						flag2 &= current.Whistle;
						flag3 &= current.Finish;
						flag &= current.Clap;
					}
					goto IL_CF;
				}
			}
			bool arg_CE_0 = false;
			flag = false;
			flag3 = false;
			flag2 = arg_CE_0;
			IL_CF:
			base.method_10(Enum106.flag_1, flag2);
			base.method_10(Enum106.flag_2, flag3);
			base.method_10(Enum106.flag_6, flag);
			if (sampleSet != (SampleSet)this.class753_0.object_0)
			{
				this.class753_0.method_18(sampleSet, true);
			}
			if (sampleSet2 != (SampleSet)this.class753_1.object_0)
			{
				this.class753_1.method_18(sampleSet2, true);
			}
		}

		// Token: 0x06001C38 RID: 7224
		// RVA: 0x00017412 File Offset: 0x00015612
		internal void method_94(Class704 class704_1)
		{
			if (!class704_1.bool_3)
			{
				return;
			}
			class704_1.bool_3 = false;
			this.list_3.Remove(class704_1);
			this.bool_14 = true;
		}

		// Token: 0x06001C44 RID: 7236
		// RVA: 0x0001749A File Offset: 0x0001569A
		[CompilerGenerated]
		private void method_95(Class530 class530_0)
		{
			if (class530_0.object_0 != null)
			{
				if (class530_0.object_0 == "vertical")
				{
					if (this.bool_22)
					{
						class530_0.method_12();
						return;
					}
					class530_0.method_13();
					return;
				}
			}
		}

		// Token: 0x06001C45 RID: 7237
		// RVA: 0x000174C9 File Offset: 0x000156C9
		[CompilerGenerated]
		private void method_96(Class704 class704_1)
		{
			class704_1.int_2 += (int)this.editor_0.double_0;
		}

		// Token: 0x06001C46 RID: 7238
		// RVA: 0x000174E4 File Offset: 0x000156E4
		[CompilerGenerated]
		private void method_97(Class704 class704_1)
		{
			class704_1.int_2 -= (int)this.editor_0.double_0;
		}

		// Token: 0x06001C48 RID: 7240
		// RVA: 0x000174FF File Offset: 0x000156FF
		[CompilerGenerated]
		private void method_98(Class704 class704_1)
		{
			this.editor_0.class872_0.Remove(class704_1);
		}

		// Token: 0x06001C3B RID: 7227
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Reset()
		{
		}

		// Token: 0x06001C35 RID: 7221
		// RVA: 0x00017409 File Offset: 0x00015609
		internal override void Select(HitObjectBase[] hitObjectBase_0)
		{
			base.Select(hitObjectBase_0);
		}

		// Token: 0x06001C36 RID: 7222
		// RVA: 0x00096F58 File Offset: 0x00095158
		internal override void Select(Class304 class304_4)
		{
			if (this.list_1.Contains(class304_4))
			{
				return;
			}
			this.list_1.Add(class304_4);
			class304_4.method_3(true);
			this.class533_5.Text = class304_4.string_0 + "\n";
			this.class533_5.string_0 = class304_4.string_0;
			if (class304_4.int_3 != 0)
			{
				Class533 expr_5C = this.class533_5;
				expr_5C.Text = expr_5C.Text + class304_4.int_3.ToString() + "%";
			}
			this.bool_14 = true;
		}

		// Token: 0x06001C37 RID: 7223
		// RVA: 0x00096FE8 File Offset: 0x000951E8
		internal void Select(Class704 class704_1)
		{
			if (this.list_3.Contains(class704_1))
			{
				return;
			}
			this.list_3.Add(class704_1);
			class704_1.bool_3 = true;
			this.class533_5.Text = this.method_91(class704_1.string_0) + "\n";
			this.class533_5.string_0 = this.method_91(class704_1.string_0);
			if (class704_1.int_3 != 0)
			{
				Class533 expr_68 = this.class533_5;
				expr_68.Text = expr_68.Text + class704_1.int_3.ToString() + "%";
			}
			this.bool_14 = true;
		}

		// Token: 0x06001C43 RID: 7235
		// RVA: 0x0001748B File Offset: 0x0001568B
		[CompilerGenerated]
		private static bool smethod_23(Class530 class530_0)
		{
			return class530_0.int_0 == -10086;
		}

		// Token: 0x06001C47 RID: 7239
		// RVA: 0x0001724A File Offset: 0x0001544A
		[CompilerGenerated]
		private static int smethod_24(Class304 class304_4, Class304 class304_5)
		{
			return class304_4.StartTime.CompareTo(class304_5.StartTime);
		}

		// Token: 0x06001C04 RID: 7172
		// RVA: 0x000172CB File Offset: 0x000154CB
		internal override bool vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x06001C05 RID: 7173
		// RVA: 0x000172D3 File Offset: 0x000154D3
		internal override void vmethod_1(bool bool_23)
		{
			base.vmethod_1(bool_23);
			this.class911_1.bool_6 = bool_23;
		}

		// Token: 0x06001C26 RID: 7206
		// RVA: 0x00095DA8 File Offset: 0x00093FA8
		internal override bool vmethod_10(Keys keys_0, bool bool_23)
		{
			Predicate<Class409> predicate = null;
			Action<Class530> action = null;
			Class374.Class385 class = new Class374.Class385();
			class.keys_0 = keys_0;
			class.class374_0 = this;
			Bindings bindings = Class795.smethod_4(class.keys_0, BindingTarget.Editor);
			if (bool_23)
			{
				switch (bindings)
				{
				case Bindings.SelectTool:
					base.method_48(Class371.Enum42.const_0);
					return true;
				case Bindings.NormalTool:
					base.method_48(Class371.Enum42.const_1);
					return true;
				case Bindings.SliderTool:
					base.method_48(Class371.Enum42.const_4);
					return true;
				}
			}
			if (this.editor_0.bool_10 && Class331.enum100_0 == Enum100.const_1)
			{
				List<Class409> arg_94_0 = this.class297_0.class421_0.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class409>(class.method_0);
				}
				if (arg_94_0.Find(predicate) != null)
				{
					return true;
				}
			}
			if (Class570.bool_0 && bool_23)
			{
				if (this.bool_22)
				{
					if (this.list_3.Count > 0)
					{
						switch (class.keys_0)
						{
						case 38:
							this.method_85(true);
							return true;
						case 40:
							this.method_85(false);
							return true;
						}
					}
				}
				else if (this.list_1.Count > 0)
				{
					switch (class.keys_0)
					{
					case 37:
						this.method_86(-1, 0);
						return true;
					case 38:
						this.method_86(0, 1);
						return true;
					case 39:
						this.method_86(1, 0);
						return true;
					case 40:
						this.method_86(0, -1);
						return true;
					}
				}
			}
			else
			{
				Keys keys_ = class.keys_0;
				if (keys_ == 9)
				{
					this.bool_22 = !this.bool_22;
					if (this.bool_22)
					{
						this.class304_1 = null;
					}
					else
					{
						this.class704_0 = null;
					}
					List<Class530> arg_1AC_0 = this.class911_0.list_2;
					if (action == null)
					{
						action = new Action<Class530>(this.method_95);
					}
					arg_1AC_0.ForEach(action);
					return true;
				}
			}
			return base.vmethod_10(class.keys_0, bool_23);
		}

		// Token: 0x06001C29 RID: 7209
		// RVA: 0x00017357 File Offset: 0x00015557
		internal override void vmethod_11()
		{
			if (this.int_9 != (int)Math.Round((double)Class466.Current.DifficultyCircleSize))
			{
				this.Initialize();
				return;
			}
			base.vmethod_11();
		}

		// Token: 0x06001C2A RID: 7210
		// RVA: 0x0001737F File Offset: 0x0001557F
		internal override void vmethod_12()
		{
			base.vmethod_12();
		}

		// Token: 0x06001C32 RID: 7218
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_13()
		{
		}

		// Token: 0x06001C09 RID: 7177
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_14()
		{
			return false;
		}

		// Token: 0x06001C42 RID: 7234
		// RVA: 0x00017463 File Offset: 0x00015663
		internal override bool vmethod_15()
		{
			if (!this.bool_22)
			{
				return base.vmethod_15();
			}
			if (this.list_3.Count > 0)
			{
				this.vmethod_17();
				return false;
			}
			return true;
		}

		// Token: 0x06001C39 RID: 7225
		// RVA: 0x00097084 File Offset: 0x00095284
		internal override void vmethod_16()
		{
			this.vmethod_17();
			if (this.bool_22)
			{
				using (List<Class704>.Enumerator enumerator = this.editor_0.class872_0.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class704 current = enumerator.Current;
						this.Select(current);
					}
					return;
				}
			}
			foreach (Class304 current2 in this.class297_0.list_3)
			{
				this.Select(current2);
			}
		}

		// Token: 0x06001C3A RID: 7226
		// RVA: 0x00097138 File Offset: 0x00095338
		internal override void vmethod_17()
		{
			if (this.bool_22)
			{
				if (this.list_3.Count == 0)
				{
					return;
				}
				for (int i = 0; i < this.list_3.Count; i++)
				{
					this.list_3[i].bool_3 = false;
				}
				this.list_3.Clear();
				this.bool_14 = true;
			}
			else
			{
				if (this.list_1.Count == 0)
				{
					return;
				}
				for (int j = 0; j < this.list_1.Count; j++)
				{
					this.list_1[j].method_3(false);
				}
				this.list_1.Clear();
				this.bool_14 = true;
			}
			if (this.class304_3 != null)
			{
				this.class304_3.method_3(false);
			}
			this.class304_3 = null;
			this.class533_5.Text = string.Empty;
			this.class533_5.string_0 = string.Empty;
		}

		// Token: 0x06001C40 RID: 7232
		// RVA: 0x00097744 File Offset: 0x00095944
		internal override void vmethod_18()
		{
			string text = string.Empty;
			int startTime = Class331.int_7;
			if (this.bool_22)
			{
				this.list_4.Clear();
				this.list_3.Sort();
				if (this.list_3.Count > 0)
				{
					foreach (Class704 current in this.list_3)
					{
						this.list_4.Add((Class704)current.Clone());
						text = text + current.ToString() + "\n";
					}
					text.Remove(text.Length - 1);
				}
			}
			else
			{
				this.list_0.Clear();
				this.list_1.Sort();
				if (this.list_1.Count > 0)
				{
					if (Class371.dictionary_0[Enum106.flag_5])
					{
						if (this.list_1.Count == 1)
						{
							this.class304_2 = this.list_1[0];
						}
						if (this.class304_3 != null)
						{
							this.class304_2 = this.class304_3;
						}
					}
					text = " (";
					foreach (Class304 current2 in this.list_1)
					{
						this.list_0.Add(current2.Clone());
						text += string.Format("{0}|{1},", current2.StartTime, this.class297_0.class421_0.method_43(current2.Position, false));
					}
					text = text.Trim(new char[]
					{
						','
					}) + ")";
					startTime = this.list_1[0].StartTime;
				}
			}
			if (!this.bool_22 || (this.bool_22 && this.list_4.Count == 0))
			{
				string str = string.Format("{0:00}:{1:00}:{2:000}", startTime / 60000, startTime % 60000 / 1000, startTime % 1000);
				text = str + text + " - ";
			}
			try
			{
				Clipboard.SetText(text);
			}
			catch (Exception)
			{
				Class723.smethod_4(Class41.GetString(OsuString.General_Editor_ClipboardNotAvailable));
			}
		}

		// Token: 0x06001C3F RID: 7231
		// RVA: 0x0009746C File Offset: 0x0009566C
		internal override void vmethod_19()
		{
			if (this.bool_22)
			{
				if (this.list_4.Count == 0)
				{
					return;
				}
				this.editor_0.method_16(false);
				this.vmethod_17();
				int num = (Class331.smethod_17() ? this.editor_0.class375_0.method_5((double)Class331.int_7) : Class331.int_7) - this.list_4[0].int_2;
				using (List<Class704>.Enumerator enumerator = this.list_4.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class704 current = enumerator.Current;
						Class704 class = (Class704)current.Clone();
						class.int_2 += num;
						class.int_0 += num;
						int num2 = this.editor_0.class375_0.method_4((double)class.int_2);
						int num3 = this.editor_0.class375_0.method_4((double)class.int_0);
						if (Math.Abs(num2 - class.int_2) == 1)
						{
							class.int_2 = num2;
						}
						if (Math.Abs(num3 - class.int_0) == 1)
						{
							class.int_0 = num3;
						}
						this.Select(class);
						this.editor_0.class872_0.Add(class);
					}
					return;
				}
			}
			if (this.list_0.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.vmethod_17();
			List<Class304> arg_188_0 = this.list_0;
			if (Class374.comparison_1 == null)
			{
				Class374.comparison_1 = new Comparison<Class304>(Class374.smethod_24);
			}
			arg_188_0.Sort(Class374.comparison_1);
			int num4 = (Class331.smethod_17() ? this.editor_0.class375_0.method_5((double)Class331.int_7) : Class331.int_7) - this.list_0[0].StartTime;
			foreach (Class304 current2 in this.list_0)
			{
				Class304 class2 = current2.Clone();
				class2.StartTime += num4;
				class2.EndTime += num4;
				int num5 = this.editor_0.class375_0.method_4((double)class2.StartTime);
				int num6 = this.editor_0.class375_0.method_4((double)class2.EndTime);
				if (Math.Abs(num5 - class2.StartTime) == 1)
				{
					class2.StartTime = num5;
				}
				if (Math.Abs(num6 - class2.EndTime) == 1)
				{
					class2.EndTime = num6;
				}
				class2.method_3(false);
				this.method_84(class2);
			}
			this.class297_0.method_20(true);
		}

		// Token: 0x06001C0D RID: 7181
		// RVA: 0x00093F44 File Offset: 0x00092144
		protected override void vmethod_2()
		{
			this.class911_0.Clear(true);
			base.vmethod_2();
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)(this.int_6 - 1), (float)this.int_7), 0.9f, true, Color.get_Black(), null);
			class.vector2_2 = new Vector2((float)this.int_9 * this.method_72() + 1f, 398f) * 1.6f;
			this.class911_0.Add(class);
			class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_5, (float)this.int_7), 0.9f, true, Color.get_Black(), null);
			class.vector2_2 = new Vector2(60f, 398f) * 1.6f;
			class.float_3 = 0.95f;
			this.class911_0.Add(class);
			this.class531_4 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)(this.int_5 - 2), (float)this.int_8), 0.901f, true, Color.get_White(), null);
			this.class531_4.vector2_2 = new Vector2(62f, 0f) * 1.6f;
			this.class531_4.float_3 = 0.5f;
			this.class911_0.Add(this.class531_4);
			for (int i = 0; i <= this.int_9; i++)
			{
				class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6 + this.method_72() * (float)i, (float)this.int_7), 0.91f, true, Color.get_White(), null);
				class.vector2_2 = new Vector2(1f, 398f) * 1.6f;
				if (i > 0 && i < this.int_9)
				{
					class.object_0 = "vertical";
				}
				this.class911_0.Add(class);
			}
			class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_5, (float)this.int_7), 0.91f, true, Color.get_White(), null);
			class.vector2_2 = new Vector2(1f, 398f) * 1.6f;
			this.class911_0.Add(class);
			class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)(this.int_5 + 60), (float)this.int_7), 0.91f, true, Color.get_White(), null);
			class.vector2_2 = new Vector2(1f, 398f) * 1.6f;
			this.class911_0.Add(class);
			class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)this.int_6, (float)(this.int_8 - (this.int_8 - this.int_7) / 5)), 0.96f, true, Color.get_GreenYellow(), null);
			class.vector2_2 = new Vector2((float)this.int_9 * this.method_72(), 4f) * 1.6f;
			this.class911_0.Add(class);
			this.class531_3 = new Class531(Class885.Load("mania-note1", Enum112.flag_1), Enum115.const_5, Origins.BottomCentre, Enum114.const_0, new Vector2(0f, 0f), 0.95f, true, Color.get_White(), null);
			this.class531_3.method_8(true);
			this.class531_3.vector2_2.X = this.method_73();
			this.class531_3.float_2 = 0.1875f;
			this.class911_0.Add(this.class531_3);
			this.class533_7 = new Class533(string.Empty, 13f, new Vector2(200f, 20f), 1f, true, Color.get_White());
			this.class533_7.enum115_0 = Enum115.const_7;
			this.class533_7.origins_0 = Origins.TopRight;
			this.class911_0.Add(this.class533_7);
			if (this.class297_1 != null)
			{
				this.vmethod_36();
			}
		}

		// Token: 0x06001C20 RID: 7200
		// RVA: 0x000957E0 File Offset: 0x000939E0
		internal override bool vmethod_20()
		{
			if (!this.vmethod_0())
			{
				return false;
			}
			if (this.bool_22)
			{
				if (this.class704_0 == null)
				{
					return false;
				}
				Class704 class = this.class704_0;
				if (Class570.bool_0)
				{
					this.editor_0.method_16(false);
					this.method_84(new Class306(this.class297_0, new Vector2((float)this.class297_0.class421_0.list_0[0].method_14(), 192f), this.editor_0.class375_0.method_5((double)class.int_2), false, false, false, false, 0)
					{
						string_0 = class.string_0,
						int_3 = class.int_3,
						int_2 = class.int_4
					});
					this.class297_0.method_20(true);
					this.editor_0.class872_0.Remove(class);
				}
				else
				{
					Class331.smethod_60(class.string_0, 1f, Enum112.flag_6);
				}
				return true;
			}
			else
			{
				if (this.class304_1 == null)
				{
					return false;
				}
				Class304 class304_ = this.class304_1;
				if (this.bool_21)
				{
					if (Class570.bool_0 && !string.IsNullOrEmpty(class304_.string_0))
					{
						this.editor_0.method_16(false);
						Class704 class2 = new Class704(class304_.int_2, class304_.string_0, class304_.StartTime, StoryLayer.Background, class304_.int_3);
						if (class2.int_3 == 0)
						{
							class2.int_3 = 70;
						}
						this.editor_0.class872_0.Add(class2);
						this.class297_0.Remove(class304_, true);
					}
					else
					{
						class304_.vmethod_12();
					}
				}
				else
				{
					this.editor_0.method_16(false);
					Class304 class3 = class304_.Clone();
					class3.method_3(false);
					this.method_84(class3);
				}
				return true;
			}
		}

		// Token: 0x06001C22 RID: 7202
		// RVA: 0x0009598C File Offset: 0x00093B8C
		internal override bool vmethod_24()
		{
			if (!Class570.bool_0)
			{
				return false;
			}
			Class371.Enum42 enum42_ = this.enum42_0;
			if (enum42_ == Class371.Enum42.const_4)
			{
				base.method_48(Class371.Enum42.const_1);
				return true;
			}
			return base.vmethod_24();
		}

		// Token: 0x06001C23 RID: 7203
		// RVA: 0x000959BC File Offset: 0x00093BBC
		internal override bool vmethod_25()
		{
			if (!Class570.bool_0)
			{
				return false;
			}
			Class371.Enum42 enum42_ = this.enum42_0;
			if (enum42_ != Class371.Enum42.const_1)
			{
				return enum42_ == Class371.Enum42.const_4 || base.vmethod_25();
			}
			base.method_48(Class371.Enum42.const_4);
			return true;
		}

		// Token: 0x06001C06 RID: 7174
		// RVA: 0x00093DB8 File Offset: 0x00091FB8
		protected override bool vmethod_26(Class371.Enum42 enum42_1)
		{
			switch (enum42_1)
			{
			case Class371.Enum42.const_0:
			case Class371.Enum42.const_1:
			case Class371.Enum42.const_4:
				return true;
			case Class371.Enum42.const_2:
			case Class371.Enum42.const_3:
				return false;
			}
			return false;
		}

		// Token: 0x06001C0A RID: 7178
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_27()
		{
			return false;
		}

		// Token: 0x06001C14 RID: 7188
		// RVA: 0x00094AF0 File Offset: 0x00092CF0
		internal override void vmethod_3()
		{
			this.class297_0.class421_0.method_19();
			this.vector2_7 = new Vector2(Class802.vector2_0.X, Class802.vector2_0.Y - (float)Class115.int_25) / Class115.float_4;
			this.method_75();
			this.bool_21 = this.method_83();
			if (this.bool_21)
			{
				if (this.bool_22)
				{
					this.class704_0 = this.method_82();
				}
				else
				{
					this.class304_1 = this.method_81();
					this.int_14 = this.method_79();
				}
			}
			else
			{
				this.int_14 = -1;
				this.class304_1 = null;
				this.class704_0 = null;
			}
			base.method_20();
			if (this.enum42_0 != Class371.Enum42.const_0 && this.bool_21)
			{
				this.class531_3.method_8(false);
				this.class531_3.vector2_1 = this.vector2_7;
			}
			else
			{
				this.class531_3.method_8(true);
			}
			if (this.class308_0 != null)
			{
				int num = this.method_88(this.vector2_7.Y);
				if (num > this.class308_0.StartTime)
				{
					this.class308_0.EndTime = num;
				}
				else
				{
					this.class308_0.StartTime = num;
				}
			}
			if (this.editor_0.bool_7)
			{
				this.method_77();
			}
			if (Class331.smethod_17())
			{
				int num2 = (int)(Class331.smethod_0() / Class331.smethod_8());
				int num3 = (int)Class331.smethod_18();
				this.int_16 = num2 % num3;
				this.int_17 = num2 / num3;
			}
			this.method_78();
			this.class297_0.method_26();
			if (this.bool_14)
			{
				this.method_93();
				this.bool_14 = false;
			}
			this.int_15 = this.int_14;
		}

		// Token: 0x06001C19 RID: 7193
		// RVA: 0x000156CE File Offset: 0x000138CE
		protected override float vmethod_30(Vector2 vector2_8, Vector2 vector2_9)
		{
			return 0f;
		}

		// Token: 0x06001C18 RID: 7192
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_31()
		{
		}

		// Token: 0x06001C3E RID: 7230
		// RVA: 0x00017438 File Offset: 0x00015638
		internal override void vmethod_32()
		{
			if (!this.bool_22)
			{
				base.vmethod_32();
				return;
			}
			if (this.list_3.Count == 0)
			{
				return;
			}
			this.vmethod_18();
			this.vmethod_35();
		}

		// Token: 0x06001C3C RID: 7228
		// RVA: 0x0009721C File Offset: 0x0009541C
		internal override void vmethod_33()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			foreach (Class304 current in this.list_1)
			{
				int num = this.class297_0.class421_0.method_43(current.Position, false);
				num = this.int_9 - num - 1;
				current.Position.X = (current.vector2_0.X = (float)this.class297_0.class421_0.list_0[num].method_14());
			}
		}

		// Token: 0x06001C3D RID: 7229
		// RVA: 0x000972DC File Offset: 0x000954DC
		internal override void vmethod_34()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			int num = 2147483647;
			int num2 = -2147483648;
			foreach (Class304 current in this.list_1)
			{
				if (current.StartTime < num)
				{
					num = current.StartTime;
				}
				if (current.EndTime > num2)
				{
					num2 = current.EndTime;
				}
			}
			foreach (Class304 current2 in this.list_1)
			{
				int num3 = num2 - (current2.StartTime - num);
				int num4 = num2 - (current2.EndTime - num);
				if (current2.IsType(HitObjectType.Hold))
				{
					current2.StartTime = num4;
					current2.EndTime = num3;
				}
				else
				{
					current2.StartTime = num3;
					current2.EndTime = num4;
				}
				int num5 = this.editor_0.class375_0.method_4((double)current2.StartTime);
				int num6 = this.editor_0.class375_0.method_4((double)current2.EndTime);
				if (Math.Abs(num5 - current2.StartTime) == 1)
				{
					current2.StartTime = num5;
				}
				if (Math.Abs(num6 - current2.EndTime) == 1)
				{
					current2.EndTime = num6;
				}
			}
		}

		// Token: 0x06001C41 RID: 7233
		// RVA: 0x000979BC File Offset: 0x00095BBC
		internal override void vmethod_35()
		{
			Action<Class704> action = null;
			base.vmethod_35();
			if (this.bool_22)
			{
				if (this.list_3.Count == 0)
				{
					return;
				}
				this.editor_0.method_16(false);
				List<Class704> arg_41_0 = this.list_3;
				if (action == null)
				{
					action = new Action<Class704>(this.method_98);
				}
				arg_41_0.ForEach(action);
				this.vmethod_17();
			}
		}

		// Token: 0x06001C0E RID: 7182
		// RVA: 0x00094338 File Offset: 0x00092538
		internal override void vmethod_36()
		{
			List<Class530> arg_28_0 = this.class911_0.list_2;
			if (Class374.predicate_8 == null)
			{
				Class374.predicate_8 = new Predicate<Class530>(Class374.smethod_23);
			}
			arg_28_0.RemoveAll(Class374.predicate_8);
			if (this.class297_1 != null)
			{
				int num = (int)Math.Round((double)this.class297_1.class296_0.DifficultyCircleSize);
				float num2 = (float)this.int_6 + this.method_72() * (float)this.int_9 + this.method_72();
				Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(num2, (float)this.int_7), 0.9f, true, new Color(50, 50, 50), null);
				class.vector2_2 = new Vector2((float)num * this.method_72() + 1f, 398f) * 1.6f;
				class.int_0 = -10086;
				this.class911_0.Add(class);
				for (int i = 0; i <= num; i++)
				{
					class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(num2 + this.method_72() * (float)i, (float)this.int_7), 0.91f, true, Color.get_White(), null);
					class.vector2_2 = new Vector2(1f, 398f) * 1.6f;
					class.int_0 = -10086;
					this.class911_0.Add(class);
				}
			}
		}

		// Token: 0x06001C33 RID: 7219
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x06001C2D RID: 7213
		// RVA: 0x000960EC File Offset: 0x000942EC
		internal override void vmethod_5()
		{
			this.method_75();
			this.int_10 = Class331.int_7;
			this.float_1 = this.editor_0.method_66();
			this.class911_1.Clear(true);
			this.method_92();
			if (this.bool_22)
			{
				List<Class704> list_ = this.editor_0.class872_0.list_2;
				this.int_18 = -1;
				for (int i = 0; i < list_.Count; i++)
				{
					Class704 class = list_[i];
					if (class.int_2 >= this.int_11 && class.int_2 <= this.int_12)
					{
						this.method_89(class, class.int_2);
					}
				}
			}
			else
			{
				int num = 100;
				int[] array = new int[100];
				int num2 = Class331.smethod_31();
				int num3 = (int)Math.Ceiling((double)num2 * 1.0 / (double)100f);
				for (int j = 0; j < this.class297_0.list_3.Count; j++)
				{
					Class304 class2 = this.class297_0.list_3[j];
					int num4 = class2.StartTime / num3;
					int num5 = class2.EndTime / num3;
					if (num4 < num)
					{
						array[num4]++;
						if (num4 != num5)
						{
							while (++num4 <= num5 && num4 < num)
							{
								array[num4]++;
							}
						}
						if (class2.EndTime >= this.int_11 && class2.StartTime <= this.int_12)
						{
							this.method_90(class2, this.int_9, 0f, this.editor_0.bool_11);
						}
					}
				}
				double num6 = (double)(60000f / Class466.Current.method_33().Z / 2f);
				int num7 = (int)((double)num3 / num6 * (double)this.int_9 * 0.60000002384185791);
				for (int k = 0; k < num; k++)
				{
					if (array[k] != 0)
					{
						Color color_;
						color_..ctor(247, 236, 0);
						if (array[k] > num7)
						{
							color_..ctor(250, 170, 212);
						}
						Class531 class3 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2((float)this.int_5, (float)this.int_8 - (float)(this.int_8 - this.int_7) * 1f / (float)num * (float)k), 0.93f, true, color_, null);
						class3.vector2_2 = new Vector2(60f / (float)num7 * (float)Math.Min(num7, array[k]), (float)(this.int_8 - this.int_7) * 1f / (float)num - 1f) * 1.6f;
						this.class911_1.Add(class3);
					}
				}
			}
			if (this.class297_1 != null)
			{
				for (int l = 0; l < this.class297_1.list_3.Count; l++)
				{
					Class304 class4 = this.class297_1.list_3[l];
					if (class4.EndTime >= this.int_11)
					{
						if (class4.StartTime > this.int_12)
						{
							break;
						}
						this.method_90(class4, (int)Math.Round((double)this.class297_1.class296_0.DifficultyCircleSize), (float)this.int_9 * this.method_72() + this.method_72(), this.editor_0.bool_11);
					}
				}
			}
			float num8 = (float)this.int_8 - (float)this.int_11 * 1f / (float)Class331.smethod_31() * (float)(this.int_8 - this.int_7);
			float num9 = (float)this.int_8 - (float)this.int_12 * 1f / (float)Class331.smethod_31() * (float)(this.int_8 - this.int_7);
			this.class531_4.vector2_1.Y = num8;
			this.class531_4.vector2_2.Y = num8 - num9;
		}

		// Token: 0x06001C1D RID: 7197
		// RVA: 0x000950F8 File Offset: 0x000932F8
		internal override bool vmethod_6()
		{
			if (!this.vmethod_0())
			{
				return false;
			}
			bool flag = Class802.buttonState_5 == 1;
			if (this.class297_1 != null && !this.bool_21)
			{
				this.vmethod_17();
				if (this.class304_1 != null)
				{
					if (this.class304_3 != null)
					{
						this.class304_3.method_3(false);
					}
					this.class304_3 = this.class304_1;
					this.class304_3.method_3(true);
					return false;
				}
			}
			if (!flag)
			{
				if (Class371.dictionary_0[Enum106.flag_5] && Class570.bool_0 && Class570.bool_2 && this.class304_1 != null)
				{
					base.method_47(this.class304_1);
					return true;
				}
				if (Class570.bool_1)
				{
					bool flag2 = false;
					if (this.bool_22)
					{
						if (this.list_3.Count > 0)
						{
							flag2 = true;
						}
						else if (this.class704_0 != null)
						{
							this.Select(this.class704_0);
							flag2 = true;
						}
					}
					else
					{
						if (this.list_1.Count > 0)
						{
							flag2 = true;
						}
						if (this.class304_1 != null)
						{
							this.Select(this.class304_1);
							flag2 = true;
						}
					}
					if (flag2)
					{
						this.editor_0.method_88();
					}
					return false;
				}
				if (this.bool_22)
				{
					if (this.class704_0 != null)
					{
						if (!this.class704_0.bool_3)
						{
							if (!Class570.bool_0)
							{
								this.vmethod_17();
							}
							this.Select(this.class704_0);
						}
						else if (this.class704_0.bool_3 && Class570.bool_0 && this.list_3.Count > 1)
						{
							this.method_94(this.class704_0);
							this.class704_0.bool_3 = false;
							this.list_3.Remove(this.class704_0);
						}
					}
					else
					{
						this.vmethod_17();
					}
				}
				else
				{
					int index = (int)((this.vector2_7.X - (float)this.int_6) / this.method_72());
					switch (this.enum42_0)
					{
					case Class371.Enum42.const_0:
					{
						Class531 class = this.method_80();
						if (class != null)
						{
							Class304 class2 = (Class304)class.object_0;
							int int_ = class.int_0;
							if (Class570.bool_2)
							{
								if (Class371.dictionary_0[Enum106.flag_5])
								{
									if (Class570.bool_0)
									{
										base.method_47(class2);
									}
									return false;
								}
								if (class2.IsType(HitObjectType.Normal) && int_ == class2.StartTime)
								{
									this.vmethod_17();
									this.editor_0.method_16(false);
									this.class297_0.Remove(class2, false);
									Class308 class3 = new Class308(this.class297_0, class2.Position, class2.StartTime, false, class2.Whistle, class2.Finish, class2.Clap, 0);
									class3.EndTime = class2.StartTime;
									class3.sampleSet_0 = class2.sampleSet_0;
									class3.sampleSet_1 = class2.sampleSet_1;
									class3.enum38_0 = class2.enum38_0;
									class3.string_0 = class2.string_0;
									class3.int_2 = class2.int_2;
									class3.int_3 = class2.int_3;
									class3.bool_6 = true;
									this.method_84(class3);
									this.class308_0 = class3;
								}
							}
							if (!class2.IsType(HitObjectType.Normal) && int_ == class2.EndTime)
							{
								this.editor_0.method_16(false);
								this.vmethod_17();
								Class308 class4 = (Class308)class2;
								class4.bool_6 = true;
								this.class308_0 = class4;
								return false;
							}
						}
						if (this.class304_1 != null)
						{
							if (!this.class304_1.method_2())
							{
								if (!Class570.bool_0)
								{
									this.vmethod_17();
								}
								this.Select(this.class304_1);
							}
							else if (this.class304_1.method_2() && Class570.bool_0 && this.list_1.Count > 1)
							{
								base.method_56(this.class304_1);
							}
						}
						else
						{
							this.vmethod_17();
						}
						return false;
					}
					case Class371.Enum42.const_1:
						if (this.bool_21)
						{
							this.vmethod_17();
							this.editor_0.method_16(false);
							int num = this.method_88(this.vector2_7.Y);
							num = this.editor_0.class375_0.method_5((double)num);
							Class306 class304_ = new Class306(this.class297_0, new Vector2((float)this.class297_0.class421_0.list_0[index].method_14(), 192f), num, false, false, false, false, 0);
							this.method_84(class304_);
							this.class297_0.method_20(true);
						}
						return false;
					case Class371.Enum42.const_4:
						if (this.bool_21)
						{
							this.vmethod_17();
							this.editor_0.method_16(false);
							int num2 = this.method_88(this.vector2_7.Y);
							num2 = this.editor_0.class375_0.method_5((double)num2);
							Class308 class5 = new Class308(this.class297_0, new Vector2((float)this.class297_0.class421_0.list_0[index].method_14(), 192f), num2, false, false, false, false, 0);
							class5.bool_6 = true;
							this.method_84(class5);
							this.class297_0.method_20(true);
							this.class308_0 = class5;
						}
						return false;
					}
				}
			}
			else if (this.bool_22)
			{
				if (this.class704_0 != null)
				{
					this.editor_0.method_16(false);
					if (this.class704_0.bool_3)
					{
						this.vmethod_35();
					}
					else
					{
						this.list_3.Remove(this.class704_0);
						this.editor_0.class872_0.Remove(this.class704_0);
					}
					this.class704_0 = null;
				}
			}
			else if (this.class304_1 != null)
			{
				this.editor_0.method_16(false);
				if (this.class304_1.method_2())
				{
					this.vmethod_35();
				}
				else
				{
					this.class297_0.Remove(this.class304_1, false);
				}
				this.class304_1 = null;
				return true;
			}
			return true;
		}

		// Token: 0x06001C1F RID: 7199
		// RVA: 0x0009571C File Offset: 0x0009391C
		internal override bool vmethod_7()
		{
			if (this.class308_0 != null)
			{
				this.class308_0.bool_6 = false;
				this.class308_0.EndTime = this.editor_0.class375_0.method_5((double)this.class308_0.EndTime);
				this.class308_0.StartTime = this.editor_0.class375_0.method_5((double)this.class308_0.StartTime);
				if (this.class308_0.EndTime == this.class308_0.StartTime)
				{
					this.class297_0.Remove(this.class308_0, false);
					Class306 class304_ = (Class306)this.class308_0.method_8();
					this.class297_0.vmethod_9(class304_);
				}
				this.class308_0 = null;
			}
			return false;
		}

		// Token: 0x06001C25 RID: 7205
		// RVA: 0x00095C38 File Offset: 0x00093E38
		internal override bool vmethod_8()
		{
			int num = this.int_6 - 100;
			float num2 = this.float_0 + this.method_72();
			if (this.bool_21 || (this.vector2_7.X >= (float)(this.int_6 - 20) && this.vector2_7.X <= num2 + 20f))
			{
				this.editor_0.enum108_0 = Enum108.const_2;
			}
			if (this.vector2_7.X >= (float)num && this.vector2_7.X <= num2 && this.vector2_7.Y > (float)this.int_7)
			{
				this.vector2_0 = Class802.vector2_0;
				this.vector2_1 = this.vector2_0;
				if (this.bool_22)
				{
					if (this.class704_0 != null)
					{
						this.int_13 = this.method_88(this.vector2_7.Y);
						this.float_2 = this.vector2_7.X;
						this.editor_0.method_16(false);
						this.bool_8 = true;
						return false;
					}
				}
				else if (this.class304_1 != null)
				{
					this.int_13 = this.method_88(this.vector2_7.Y);
					this.float_2 = this.vector2_7.X;
					if (this.class308_0 == null || !this.class308_0.bool_6)
					{
						this.editor_0.method_16(false);
					}
					this.bool_8 = true;
					return false;
				}
				this.bool_5 = (this.enum42_0 == Class371.Enum42.const_0);
			}
			return false;
		}

		// Token: 0x06001C24 RID: 7204
		// RVA: 0x000959F4 File Offset: 0x00093BF4
		internal override void vmethod_9()
		{
			this.bool_5 = false;
			if (!Class371.dictionary_0[Enum106.flag_5] && this.bool_8)
			{
				if (this.bool_22)
				{
					if (this.list_3.Count > 0)
					{
						int num = this.list_3[0].int_2 - this.editor_0.class375_0.method_5((double)this.list_3[0].int_2);
						foreach (Class704 current in this.list_3)
						{
							current.int_2 = this.editor_0.class375_0.method_4((double)(current.int_2 - num));
						}
						this.editor_0.class872_0.list_2.Sort();
					}
				}
				else
				{
					this.list_1.Sort();
					if (this.list_1.Count > 0)
					{
						int num2 = this.list_1[0].StartTime - this.editor_0.class375_0.method_5((double)this.list_1[0].StartTime);
						if (this.list_1.Count == 1)
						{
							Class304 class = this.list_1[0];
							class.StartTime = this.editor_0.class375_0.method_5((double)class.StartTime);
							class.EndTime = this.editor_0.class375_0.method_5((double)class.EndTime);
						}
						else
						{
							foreach (Class304 current2 in this.list_1)
							{
								current2.StartTime = this.editor_0.class375_0.method_4((double)(current2.StartTime - num2));
								current2.EndTime = this.editor_0.class375_0.method_4((double)(current2.EndTime - num2));
							}
						}
						this.class297_0.method_20(true);
					}
				}
			}
			this.bool_8 = false;
			this.editor_0.enum108_0 = Enum108.const_0;
		}
	}
}
