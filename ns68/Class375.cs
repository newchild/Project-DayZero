using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns10;
using ns24;
using ns26;
using ns27;
using ns29;
using ns59;
using ns60;
using ns66;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns90;
using ns94;
using osu.GameModes.Edit;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ns68
{
	// Token: 0x020004C4 RID: 1220
	internal sealed class Class375 : Class370
	{
		// Token: 0x020004C5 RID: 1221
		[CompilerGenerated]
		private sealed class Class633
		{
			// Token: 0x04002070 RID: 8304
			public int int_0;

			// Token: 0x06002727 RID: 10023
			// RVA: 0x0001E3D4 File Offset: 0x0001C5D4
			public void method_0(object sender, EventArgs e)
			{
				Class331.smethod_70(this.int_0, false, false);
			}
		}

		// Token: 0x0400205B RID: 8283
		private bool bool_2;

		// Token: 0x04002068 RID: 8296
		internal bool bool_3;

		// Token: 0x04002069 RID: 8297
		internal bool bool_4;

		// Token: 0x0400206A RID: 8298
		internal bool bool_5;

		// Token: 0x0400206B RID: 8299
		internal bool bool_6;

		// Token: 0x0400206E RID: 8302
		private bool bool_7;

		// Token: 0x0400206C RID: 8300
		private Class340 class340_0;

		// Token: 0x0400205D RID: 8285
		internal Class366 class366_0;

		// Token: 0x04002061 RID: 8289
		internal Class531[] class531_0;

		// Token: 0x0400205E RID: 8286
		internal Class533 class533_0;

		// Token: 0x0400205F RID: 8287
		internal Class533 class533_1;

		// Token: 0x04002060 RID: 8288
		internal Class533 class533_2;

		// Token: 0x04002063 RID: 8291
		private Class533 class533_3;

		// Token: 0x04002064 RID: 8292
		private Class533 class533_4;

		// Token: 0x04002065 RID: 8293
		private Class533 class533_5;

		// Token: 0x04002062 RID: 8290
		private Class762 class762_0;

		// Token: 0x0400206F RID: 8303
		private Class911 class911_1;

		// Token: 0x0400206D RID: 8301
		private Dictionary<Class340, List<Class530>> dictionary_0 = new Dictionary<Class340, List<Class530>>();

		// Token: 0x04002066 RID: 8294
		private double double_0;

		// Token: 0x04002067 RID: 8295
		private double double_1;

		// Token: 0x04002059 RID: 8281
		private int int_0;

		// Token: 0x0400205C RID: 8284
		private int int_1 = -1;

		// Token: 0x0400205A RID: 8282
		private List<int> list_0 = new List<int>();

		// Token: 0x06002700 RID: 9984
		// RVA: 0x0001E2CE File Offset: 0x0001C4CE
		internal Class375(Editor editor_1) : base(editor_1)
		{
			this.class911_1 = new Class911();
		}

		// Token: 0x06002709 RID: 9993
		// RVA: 0x000EFEB0 File Offset: 0x000EE0B0
		internal override void Dispose()
		{
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			foreach (KeyValuePair<Class340, List<Class530>> current in this.dictionary_0)
			{
				for (int i = 0; i < current.Value.Count; i++)
				{
					current.Value[i].Dispose();
				}
			}
			base.Dispose();
		}

		// Token: 0x0600270A RID: 9994
		// RVA: 0x000EFF40 File Offset: 0x000EE140
		internal override void Draw()
		{
			byte b = 0;
			byte b2 = 0;
			byte b3 = 0;
			byte b4 = 0;
			byte b5 = 0;
			byte b6 = 0;
			bool flag;
			if ((!(flag = (this.class340_0 != null)) && Class331.smethod_17()) || (flag && this.class340_0.double_0 > 0.0))
			{
				this.class533_0.Text = string.Format(Class570.bool_0 ? "{0:0.000}" : "{0:0.00}", 60000.0 / (flag ? this.class340_0.double_0 : Class331.smethod_8()));
				this.class533_2.Text = string.Format("{0:#,0}", flag ? this.class340_0.double_1 : Class331.smethod_12());
				this.class533_4.Text = string.Format("{0:N2}", Class466.Current.DifficultySliderMultiplier);
				this.class533_3.Text = string.Format("{0}", Class466.Current.DifficultySliderTickRate);
				this.class533_1.Text = string.Format("{0}:{1}", this.class366_0.int_2, this.class366_0.int_0);
				if ((double)Class331.int_7 >= Class331.smethod_12())
				{
					double num = Class331.smethod_0() % (Class331.smethod_8() * (double)Class331.smethod_18()) / Class331.smethod_8();
					if (num < 1.0)
					{
						b = (byte)(187.0 * (1.0 - num));
						b2 = (byte)(255.0 * (1.0 - num));
						b3 = (byte)(51.0 * (1.0 - num));
					}
					else
					{
						num %= 3.0;
						if (num < 1.0)
						{
							b6 = (byte)(255.0 * (1.0 - num));
						}
						else if (num < 2.0)
						{
							b4 = (byte)(255.0 * (2.0 - num));
						}
						else if (num < 3.0)
						{
							b5 = (byte)(255.0 * (3.0 - num));
						}
					}
				}
			}
			else
			{
				this.class533_1.Text = Class41.GetString(OsuString.EditorModeTiming_TimingSectionNotTimed);
				this.class533_0.Text = "-";
				this.class533_2.Text = "-";
			}
			this.class531_0[0].color_0 = new Color(b, b2, b3, 0);
			this.class531_0[1].color_0 = new Color(b4, b4, b4, 0);
			this.class531_0[2].color_0 = new Color(b5, b5, b5, 0);
			this.class531_0[3].color_0 = new Color(b6, b6, b6, 0);
			this.class911_1.Draw();
			base.Draw();
			this.class366_0.Draw();
		}

		// Token: 0x060026F3 RID: 9971
		// RVA: 0x000EDA30 File Offset: 0x000EBC30
		internal void method_0(bool bool_8, int? nullable_0)
		{
			if (Class331.smethod_16().Count != 0 && !this.bool_2)
			{
				if (!nullable_0.HasValue)
				{
					nullable_0 = new int?(this.editor_0.int_6);
				}
				this.editor_0.method_16(false);
				List<Class340> list = Class331.smethod_16();
				int num = 0;
				int num2;
				if (bool_8)
				{
					num = list.IndexOf(Class331.smethod_14()[num]);
					num2 = num + 1;
				}
				else
				{
					num2 = list.Count;
				}
				double num3 = list[num].double_1;
				double num4 = (num2 == list.Count) ? ((double)Class331.smethod_31()) : list[num2].double_1;
				foreach (Class304 current in this.editor_0.class297_0.list_3)
				{
					if ((double)current.StartTime >= num3 && (double)current.StartTime <= num4)
					{
						Class340 class340_;
						if (bool_8)
						{
							class340_ = list[num];
						}
						else
						{
							class340_ = Class331.smethod_25((double)current.StartTime, list);
						}
						current.vmethod_4((int)this.method_1((double)current.StartTime, class340_, nullable_0));
						if (current.IsType(HitObjectType.Spinner) || current.IsType(HitObjectType.Hold))
						{
							current.vmethod_19((int)this.method_1((double)current.EndTime, class340_, nullable_0));
						}
					}
				}
				this.class297_0.method_20(true);
				this.class297_0.method_12(false);
				return;
			}
		}

		// Token: 0x060026F4 RID: 9972
		// RVA: 0x000EDBC0 File Offset: 0x000EBDC0
		private double method_1(double double_2, Class340 class340_1, int? nullable_0)
		{
			double num = double_2 - class340_1.double_1;
			if (nullable_0.HasValue)
			{
				double a = num / (class340_1.double_0 / (double)nullable_0.Value);
				return class340_1.double_1 + Math.Round(a) * (class340_1.double_0 / (double)nullable_0.Value);
			}
			double num2 = num / (class340_1.double_0 / 16.0);
			double num3 = num / (class340_1.double_0 / 12.0);
			double num4 = Math.Abs(Math.Round(num2) - num2);
			double num5 = Math.Abs(Math.Round(num3) - num3);
			if (num4 < num5)
			{
				return class340_1.double_1 + Math.Round(num2) * (class340_1.double_0 / 16.0);
			}
			return class340_1.double_1 + Math.Round(num3) * (class340_1.double_0 / 12.0);
		}

		// Token: 0x06002703 RID: 9987
		// RVA: 0x000EF79C File Offset: 0x000ED99C
		private void method_10()
		{
			if (Class800.smethod_1() == null)
			{
				this.bool_2 = false;
				if (this.bool_5)
				{
					this.editor_0.bool_5 = true;
					this.class297_0.vmethod_8(false, true);
					this.class297_0.method_11(false, true);
				}
				if (this.bool_4)
				{
					this.editor_0.bool_5 = true;
					if (this.class762_0.method_2() || this.bool_6)
					{
						Class331.smethod_6(true);
						List<Class340> list = Class331.smethod_16();
						Class340 class = (this.class340_0 != null) ? this.class340_0 : Class331.smethod_14()[Class331.int_1];
						int num = list.IndexOf(class);
						double num2 = class.double_1;
						double num3 = (num < list.Count - 1) ? list[num + 1].double_1 : ((double)Class331.smethod_31());
						int num4 = (int)(num2 - this.double_1);
						foreach (Class304 current in this.class297_0.list_3)
						{
							if ((double)current.StartTime < num3 && (double)current.StartTime >= this.double_1)
							{
								current.vmethod_4(current.StartTime + num4);
							}
						}
					}
				}
				if (this.bool_3)
				{
					this.editor_0.bool_5 = true;
					bool flag = this.class762_0.method_2();
					List<Class340> list2 = Class331.smethod_16();
					Class340 class2 = (this.class340_0 != null) ? this.class340_0 : Class331.smethod_14()[Class331.int_1];
					int num5 = list2.IndexOf(class2);
					double num6 = class2.double_1;
					double num7 = (num5 < list2.Count - 1) ? list2[num5 + 1].double_1 : ((double)Class331.smethod_31());
					double num8 = class2.double_0 / this.double_0;
					foreach (Class304 current2 in this.class297_0.list_3)
					{
						if (flag && (double)current2.StartTime < num7 && (double)current2.StartTime >= num6)
						{
							current2.vmethod_4(this.method_7(((double)current2.StartTime - num6) * num8 + num6, 8, 0.0));
						}
					}
				}
				if (this.bool_3 || this.bool_4)
				{
					this.class297_0.method_20(true);
				}
				this.class340_0 = null;
				this.bool_3 = false;
				this.bool_4 = false;
				this.bool_5 = false;
				this.bool_6 = false;
			}
		}

		// Token: 0x0600270B RID: 9995
		// RVA: 0x0001E339 File Offset: 0x0001C539
		internal void method_11()
		{
			this.method_12(Enum58.const_0);
		}

		// Token: 0x0600270C RID: 9996
		// RVA: 0x0001E342 File Offset: 0x0001C542
		internal void method_12(Enum58 enum58_0)
		{
			this.method_13(enum58_0, true);
		}

		// Token: 0x0600270D RID: 9997
		// RVA: 0x000F024C File Offset: 0x000EE44C
		internal void method_13(Enum58 enum58_0, bool bool_8)
		{
			this.method_10();
			this.editor_0.method_16(true);
			Class115.smethod_6(true);
			this.double_0 = Class331.smethod_8();
			this.double_1 = Class331.smethod_12();
			TimingEntry timingEntry = new TimingEntry(this.editor_0, enum58_0, bool_8, this.editor_0.enum105_0 == Enum105.const_3);
			timingEntry.ShowDialog(Class115.form_0);
			Class115.smethod_6(false);
			Class331.smethod_6(true);
			this.class297_0.method_12(false);
			if (this.editor_0.enum105_0 != Enum105.const_3)
			{
				this.vmethod_3();
			}
		}

		// Token: 0x0600270E RID: 9998
		// RVA: 0x000F02DC File Offset: 0x000EE4DC
		private void method_14(object sender, EventArgs e)
		{
			if (!this.bool_2 && Class331.smethod_17())
			{
				this.bool_2 = true;
				this.class340_0 = Class331.smethod_14()[Class331.int_1];
				this.editor_0.method_16(false);
			}
			this.method_22();
			this.class911_1.method_19();
		}

		// Token: 0x0600270F RID: 9999
		// RVA: 0x000F0334 File Offset: 0x000EE534
		private void method_15(object sender, EventArgs e)
		{
			if (!this.bool_2 && Class331.smethod_17())
			{
				this.bool_2 = true;
				this.class340_0 = Class331.smethod_14()[Class331.int_1];
				this.editor_0.method_16(false);
			}
			this.method_21();
			this.class911_1.method_19();
		}

		// Token: 0x06002710 RID: 10000
		// RVA: 0x000F038C File Offset: 0x000EE58C
		private void method_16(object sender, EventArgs e)
		{
			if (!this.bool_2 && Class331.smethod_17())
			{
				this.bool_2 = true;
				this.class340_0 = Class331.smethod_14()[Class331.int_1];
				this.editor_0.method_16(false);
			}
			this.method_20();
			this.class911_1.method_19();
		}

		// Token: 0x06002711 RID: 10001
		// RVA: 0x000F03E4 File Offset: 0x000EE5E4
		private void method_17(object sender, EventArgs e)
		{
			if (!this.bool_2 && Class331.smethod_17())
			{
				this.bool_2 = true;
				this.class340_0 = Class331.smethod_14()[Class331.int_1];
				this.editor_0.method_16(false);
			}
			this.method_19();
			this.class911_1.method_19();
		}

		// Token: 0x06002712 RID: 10002
		// RVA: 0x0001E34C File Offset: 0x0001C54C
		internal void method_18()
		{
			if (Class331.smethod_14().Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			Class331.smethod_14().Clear();
			this.int_0 = 0;
		}

		// Token: 0x06002713 RID: 10003
		// RVA: 0x000F043C File Offset: 0x000EE63C
		private void method_19()
		{
			bool flag;
			if ((!(flag = (this.class340_0 != null)) && Class331.smethod_17()) || (flag && this.class340_0.double_0 > 0.0))
			{
				if (!this.bool_3)
				{
					this.double_0 = (flag ? this.class340_0.double_0 : Class331.smethod_8());
					this.bool_3 = true;
				}
				Class340 class = (this.class340_0 != null) ? this.class340_0 : Class331.smethod_14()[Class331.int_1];
				if (Class570.bool_2)
				{
					class.double_0 -= 1.0;
					return;
				}
				if (Class570.bool_0)
				{
					class.double_0 -= 0.01;
					return;
				}
				class.double_0 -= 0.1;
			}
		}

		// Token: 0x060026F5 RID: 9973
		// RVA: 0x000EDC98 File Offset: 0x000EBE98
		internal void method_2(int int_2)
		{
			this.editor_0.method_16(false);
			foreach (Class304 current in this.editor_0.class297_0.list_3)
			{
				current.vmethod_4(Math.Min(Class331.smethod_31(), Math.Max(0, current.StartTime + int_2)));
			}
			this.class297_0.method_20(true);
			this.class297_0.method_12(false);
		}

		// Token: 0x06002714 RID: 10004
		// RVA: 0x000F0520 File Offset: 0x000EE720
		private void method_20()
		{
			bool flag;
			if ((!(flag = (this.class340_0 != null)) && Class331.smethod_17()) || (flag && this.class340_0.double_0 > 0.0))
			{
				if (!this.bool_3)
				{
					this.double_0 = (flag ? this.class340_0.double_0 : Class331.smethod_8());
					this.bool_3 = true;
				}
				Class340 class = (this.class340_0 != null) ? this.class340_0 : Class331.smethod_14()[Class331.int_1];
				if (Class570.bool_2)
				{
					class.double_0 += 1.0;
					return;
				}
				if (Class570.bool_0)
				{
					class.double_0 += 0.01;
					return;
				}
				class.double_0 += 0.1;
			}
		}

		// Token: 0x06002715 RID: 10005
		// RVA: 0x000F0604 File Offset: 0x000EE804
		private void method_21()
		{
			bool flag;
			if ((!(flag = (this.class340_0 != null)) && Class331.smethod_17()) || (flag && this.class340_0.double_0 > 0.0))
			{
				if (!this.bool_4)
				{
					this.double_1 = (flag ? this.class340_0.double_1 : Class331.smethod_12());
					this.bool_4 = true;
				}
				if (flag)
				{
					if (Class570.bool_2)
					{
						this.class340_0.double_1 += 10.0;
						return;
					}
					if (Class570.bool_0)
					{
						this.class340_0.double_1 += 1.0;
						return;
					}
					this.class340_0.double_1 += 2.0;
					return;
				}
				else
				{
					if (Class570.bool_2)
					{
						Class331.smethod_13(Class331.smethod_12() + 10.0);
						return;
					}
					if (Class570.bool_0)
					{
						Class331.smethod_13(Class331.smethod_12() + 1.0);
						return;
					}
					Class331.smethod_13(Class331.smethod_12() + 2.0);
				}
			}
		}

		// Token: 0x06002716 RID: 10006
		// RVA: 0x000F0728 File Offset: 0x000EE928
		private void method_22()
		{
			bool flag;
			if ((!(flag = (this.class340_0 != null)) && Class331.smethod_17()) || (flag && this.class340_0.double_0 > 0.0))
			{
				if (!this.bool_4)
				{
					this.double_1 = (flag ? this.class340_0.double_1 : Class331.smethod_12());
					this.bool_4 = true;
				}
				if (flag)
				{
					if (Class570.bool_2)
					{
						this.class340_0.double_1 -= 10.0;
						return;
					}
					if (Class570.bool_0)
					{
						this.class340_0.double_1 -= 1.0;
						return;
					}
					this.class340_0.double_1 -= 2.0;
					return;
				}
				else
				{
					if (Class570.bool_2)
					{
						Class331.smethod_13(Class331.smethod_12() - 10.0);
						return;
					}
					if (Class570.bool_0)
					{
						Class331.smethod_13(Class331.smethod_12() - 1.0);
						return;
					}
					Class331.smethod_13(Class331.smethod_12() - 2.0);
				}
			}
		}

		// Token: 0x06002717 RID: 10007
		// RVA: 0x0001E378 File Offset: 0x0001C578
		private void method_23(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06002718 RID: 10008
		// RVA: 0x000F084C File Offset: 0x000EEA4C
		private void method_24(object sender, EventArgs e)
		{
			if (Class466.Current.DifficultySliderTickRate < 4.0)
			{
				if (!this.bool_2)
				{
					this.bool_2 = true;
				}
				Class466.Current.DifficultySliderTickRate = (double)((int)Class466.Current.DifficultySliderTickRate + 1);
				this.bool_5 = true;
			}
		}

		// Token: 0x06002719 RID: 10009
		// RVA: 0x000F089C File Offset: 0x000EEA9C
		private void method_25(object sender, EventArgs e)
		{
			if (Class466.Current.DifficultySliderTickRate > 1.0)
			{
				if (!this.bool_2)
				{
					this.bool_2 = true;
				}
				Class466.Current.DifficultySliderTickRate = (double)((int)Class466.Current.DifficultySliderTickRate - 1);
				this.bool_5 = true;
			}
		}

		// Token: 0x0600271A RID: 10010
		// RVA: 0x000F08EC File Offset: 0x000EEAEC
		private void method_26(object sender, EventArgs e)
		{
			if (!this.bool_2)
			{
				this.bool_2 = true;
			}
			if (Class570.bool_0)
			{
				Class466.Current.DifficultySliderMultiplier = Math.Min(3.5999999046325684, Class466.Current.DifficultySliderMultiplier + 0.01);
			}
			else
			{
				Class466.Current.DifficultySliderMultiplier = Math.Min(3.5999999046325684, Class466.Current.DifficultySliderMultiplier + 0.1);
			}
			this.bool_5 = true;
			this.class911_1.method_19();
		}

		// Token: 0x0600271B RID: 10011
		// RVA: 0x000F097C File Offset: 0x000EEB7C
		private void method_27(object sender, EventArgs e)
		{
			if (!this.bool_2)
			{
				this.bool_2 = true;
			}
			if (Class570.bool_0)
			{
				Class466.Current.DifficultySliderMultiplier = Math.Max(0.40000000596046448, Class466.Current.DifficultySliderMultiplier - 0.01);
			}
			else
			{
				Class466.Current.DifficultySliderMultiplier = Math.Max(0.40000000596046448, Class466.Current.DifficultySliderMultiplier - 0.1);
			}
			this.bool_5 = true;
			this.class911_1.method_19();
		}

		// Token: 0x0600271C RID: 10012
		// RVA: 0x0001E380 File Offset: 0x0001C580
		private void method_28(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x0600271E RID: 10014
		// RVA: 0x0001E388 File Offset: 0x0001C588
		internal void method_29(Enum37 enum37_0)
		{
			if (Class331.smethod_14().Count == 0)
			{
				return;
			}
			Class331.smethod_19(enum37_0);
			Class115.editorControl_0.method_11(enum37_0);
			this.editor_0.class375_0.method_33();
		}

		// Token: 0x060026F6 RID: 9974
		// RVA: 0x000EDD34 File Offset: 0x000EBF34
		internal void method_3(int int_2)
		{
			if (this.editor_0.class371_0.list_1.Count == 0)
			{
				return;
			}
			double num = Class331.smethod_22((double)this.editor_0.class371_0.list_1[0].StartTime, false) / (double)this.editor_0.int_6;
			foreach (Class304 current in this.editor_0.class371_0.list_1)
			{
				current.vmethod_4(this.method_5((double)current.StartTime) + (int)((double)int_2 * num));
			}
			this.class297_0.method_20(true);
		}

		// Token: 0x0600271F RID: 10015
		// RVA: 0x000F0A74 File Offset: 0x000EEC74
		internal void method_30()
		{
			this.editor_0.method_16(false);
			foreach (Class304 current in this.class297_0.list_3)
			{
				Class321 class = current as Class321;
				if (class != null)
				{
					class.SpatialLength = 0.0;
					class.vmethod_24(true);
				}
			}
		}

		// Token: 0x06002720 RID: 10016
		// RVA: 0x000F0AF4 File Offset: 0x000EECF4
		internal void method_31(bool bool_8)
		{
			if (Class331.int_1 >= 0 && Class331.smethod_8() > 0.0)
			{
				if (!bool_8 && (double)Class331.int_7 < Class331.smethod_14()[0].double_1)
				{
					return;
				}
				double double_ = bool_8 ? Class331.smethod_8() : Class331.smethod_7().double_0;
				Class340 class = new Class340((double)Class331.int_7, double_);
				class.method_1(bool_8);
				if (Class331.int_2 >= 0)
				{
					Class340 class2 = Class331.smethod_7();
					class.int_0 = class2.int_0;
					class.enum37_0 = class2.enum37_0;
					class.method_3(Class331.smethod_82());
				}
				this.editor_0.method_16(false);
				this.editor_0.bool_5 = true;
				Class331.smethod_14().Add(class);
			}
			this.int_0 = 0;
			Class331.smethod_6(true);
			if (!bool_8)
			{
				this.method_12(Enum58.const_3);
			}
		}

		// Token: 0x06002721 RID: 10017
		// RVA: 0x000F0BD0 File Offset: 0x000EEDD0
		internal void method_32()
		{
			if (Class331.smethod_8() <= 0.0 || Class331.int_2 < 0)
			{
				return;
			}
			if (Class331.smethod_16().Count == 1 && Class331.int_2 == Class331.int_1)
			{
				return;
			}
			this.editor_0.method_16(false);
			Class331.smethod_14().RemoveAt(Class331.int_2);
			this.int_0 = 0;
			Class331.smethod_5();
			Class331.smethod_6(true);
		}

		// Token: 0x06002722 RID: 10018
		// RVA: 0x000F0C40 File Offset: 0x000EEE40
		internal void method_33()
		{
			Class331.smethod_16().Sort();
			for (int i = Class331.int_1; i <= Class331.int_2; i++)
			{
				Class340 class = Class331.smethod_14()[i];
				class.enum37_0 = Class331.smethod_18();
			}
		}

		// Token: 0x06002723 RID: 10019
		// RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		[CompilerGenerated]
		private void method_34(object sender, EventArgs e)
		{
			this.method_13(Enum58.const_1, false);
		}

		// Token: 0x06002724 RID: 10020
		// RVA: 0x0001E3C2 File Offset: 0x0001C5C2
		[CompilerGenerated]
		private void method_35(object sender, EventArgs e)
		{
			this.method_13(Enum58.const_2, false);
		}

		// Token: 0x06002725 RID: 10021
		// RVA: 0x0001E3CC File Offset: 0x0001C5CC
		[CompilerGenerated]
		private void method_36(object sender, EventArgs e)
		{
			this.method_11();
		}

		// Token: 0x060026F7 RID: 9975
		// RVA: 0x000EDDF8 File Offset: 0x000EBFF8
		internal int method_4(double double_2)
		{
			int num = this.method_7(double_2, 16, double_2);
			int num2 = this.method_7(double_2, 12, double_2);
			if (Math.Abs((double)num - double_2) > Math.Abs((double)num2 - double_2))
			{
				return num2;
			}
			return num;
		}

		// Token: 0x060026F8 RID: 9976
		// RVA: 0x0001E28F File Offset: 0x0001C48F
		internal int method_5(double double_2)
		{
			return this.method_7(double_2, this.editor_0.int_6, double_2);
		}

		// Token: 0x060026F9 RID: 9977
		// RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		internal int method_6(double double_2, double double_3)
		{
			return this.method_7(double_2, this.editor_0.int_6, double_3);
		}

		// Token: 0x060026FA RID: 9978
		// RVA: 0x000EDE34 File Offset: 0x000EC034
		internal int method_7(double double_2, int int_2, double double_3)
		{
			if (Class331.smethod_14().Count == 0)
			{
				return (int)double_2;
			}
			double num = Class331.smethod_20(double_3);
			double num2 = Class331.smethod_22(double_3, false) / (double)int_2;
			int num3;
			if (double_2 - num < 0.0)
			{
				num3 = (int)((double_2 - num) / num2) - 1;
			}
			else
			{
				num3 = (int)((double_2 - num) / num2);
			}
			int num4 = (int)((double)num3 * num2 + num);
			int num5 = (int)((double)(num3 + 1) * num2 + num);
			if (double_3 != double_2)
			{
				if ((double)num4 == double_3)
				{
					return num5;
				}
				if ((double)num5 == double_3)
				{
					return num4;
				}
			}
			if (double_2 - (double)num4 >= (double)num5 - double_2)
			{
				return num5;
			}
			return num4;
		}

		// Token: 0x060026FC RID: 9980
		// RVA: 0x000EDEB8 File Offset: 0x000EC0B8
		internal void method_8()
		{
			if (this.bool_2)
			{
				return;
			}
			if (Class331.int_1 >= 0)
			{
				Class340 class = Class331.smethod_14()[Class331.int_1];
				class.double_0 = 0.0;
				class.double_1 = ((Class331.int_1 == 0) ? 0.0 : (Class331.smethod_14()[Class331.int_1 - 1].double_1 + 1000.0));
				class.method_1(true);
				this.int_0 = 0;
				Class331.smethod_70((int)class.double_1, false, false);
			}
			else
			{
				Class331.smethod_87();
			}
			this.list_0.Clear();
			Class331.smethod_6(true);
		}

		// Token: 0x060026FD RID: 9981
		// RVA: 0x000EDF64 File Offset: 0x000EC164
		private void method_9()
		{
			if (this.bool_2)
			{
				return;
			}
			if (Class331.enum100_0 != Enum100.const_1)
			{
				Class331.smethod_87();
			}
			this.class366_0.int_6 = 3;
			if (this.list_0.Count > 0 && Class331.int_7 == this.list_0[this.list_0.Count - 1])
			{
				return;
			}
			if (this.list_0.Count > 0 && this.list_0[this.list_0.Count - 1] > Class331.int_7)
			{
				this.list_0.Clear();
			}
			if (this.list_0.Count == 1 && Class331.int_7 - this.list_0[0] > 1000)
			{
				this.list_0.Clear();
			}
			if (this.list_0.Count == 0)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorModeTiming_Tap_TapInTimeToTheBeat), 5000);
			}
			else if (this.list_0.Count == 2)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorModeTiming_Tap_KeepGoing), 5000);
			}
			else if (this.list_0.Count >= 4)
			{
				if (this.list_0.Count < 8)
				{
					Class723.smethod_1(string.Format(Class41.GetString(OsuString.EditorModeTiming_Tap_TapMoreTimes), 7 - this.list_0.Count), 5000);
				}
				else if (this.list_0.Count == 8)
				{
					Class723.smethod_1(Class41.GetString(OsuString.EditorModeTiming_Tap_TapToIncreaseAccuracy), 5000);
				}
				else if (this.list_0.Count == 16)
				{
					Class723.smethod_1(string.Format(Class41.GetString(OsuString.EditorModeTiming_Tap_BPMSensitivity), 0), 5000);
				}
				else if (this.list_0.Count == 32)
				{
					Class723.smethod_1(string.Format(Class41.GetString(OsuString.EditorModeTiming_Tap_BPMSensitivity), 1), 5000);
				}
				else if (this.list_0.Count == 64)
				{
					Class723.smethod_1(string.Format(Class41.GetString(OsuString.EditorModeTiming_Tap_BPMSensitivity), 2), 5000);
				}
			}
			this.list_0.Add(Class331.int_7);
			int num = 0;
			if (this.list_0.Count >= 8)
			{
				IL_73A:
				while (this.list_0.Count >= 2)
				{
					double num2 = (double)((float)(this.list_0[this.list_0.Count - 1] - this.list_0[1]) / ((float)this.list_0.Count - 2f));
					for (int i = 0; i < this.list_0.Count - 1; i++)
					{
						int num3 = this.list_0[i + 1] - this.list_0[i];
						if ((double)Math.Abs(num3) > num2 * 1.4)
						{
							this.list_0.RemoveAt(i + 1);
							if (i < this.list_0.Count - 1)
							{
								num3 = this.list_0[i + 1] - this.list_0[i];
								this.list_0.RemoveAt(i + 1);
							}
							for (int j = i + 1; j < this.list_0.Count; j++)
							{
								List<int> list;
								int index;
								(list = this.list_0)[index = j] = list[index] - num3;
							}
							num++;
							goto IL_73A;
						}
					}
					double num4 = 0.0;
					for (int k = 1; k < this.list_0.Count - 1; k++)
					{
						num4 += Math.Abs((double)this.list_0[k + 1] - ((double)this.list_0[k] + num2)) * (1.0 + (double)k / 64.0);
					}
					num4 /= (double)((float)this.list_0.Count - 1f);
					double num5 = ((double)(this.list_0[this.list_0.Count - 1] - this.list_0[1]) + num4) / (double)((float)this.list_0.Count - 2f);
					double num6 = ((double)(this.list_0[this.list_0.Count - 1] - this.list_0[1]) - num4) / (double)((float)this.list_0.Count - 2f);
					double num7 = num6;
					double num8 = 0.0;
					double num9 = 10000.0;
					while (num7 < num5)
					{
						double num10 = Math.Round(60000.0 / num7, (this.list_0.Count >= 64) ? 2 : ((this.list_0.Count < 32) ? 0 : 1));
						if (Math.Abs(60000.0 / num10 - num2) < num9)
						{
							num9 = Math.Abs(60000.0 / num8 - num2);
							num8 = num10;
						}
						num7 += ((this.list_0.Count >= 64) ? 0.05 : ((this.list_0.Count < 32) ? 0.1 : 0.5));
					}
					double num11 = 60000.0 / num8;
					double double_ = -1.0;
					double num12 = 1000.0;
					int l = 0;
					while (l < this.list_0.Count - 1)
					{
						double num13 = (double)this.list_0[l] - num11 * (double)l;
						double num14 = 0.0;
						double num15 = 0.0;
						int num16 = 0;
						for (int m = 1; m < this.list_0.Count - 1; m++)
						{
							if (l != m)
							{
								num16++;
								num14 += num13 + num11 * (double)m - (double)this.list_0[m];
								num15 = Math.Max(num15, Math.Abs(num13 + num11 * (double)m - (double)this.list_0[m]));
							}
						}
						double num17 = Math.Abs(num14) / (double)num16;
						if (num17 <= 200.0)
						{
							if (num15 < num12)
							{
								num12 = num15;
								double_ = num13;
							}
							l++;
						}
						else
						{
							if (l == 0)
							{
								this.list_0.RemoveAt(l);
								for (int n = 0; n < this.list_0.Count; n++)
								{
									List<int> list2;
									int index2;
									(list2 = this.list_0)[index2 = n] = list2[index2] - (int)Math.Round(num2);
								}
								num++;
								goto IL_73A;
							}
							l--;
							int num18 = this.list_0[l + 1] - this.list_0[l];
							this.list_0.RemoveAt(l + 1);
							if (l < this.list_0.Count - 1)
							{
								num18 = this.list_0[l + 1] - this.list_0[l];
								this.list_0.RemoveAt(l + 1);
							}
							for (int num19 = l + 1; num19 < this.list_0.Count; num19++)
							{
								List<int> list3;
								int index3;
								(list3 = this.list_0)[index3 = num19] = list3[index3] - num18;
							}
							num++;
							goto IL_73A;
						}
					}
					double num20 = (double)this.list_0[this.list_0.Count - 1] - (double)(this.list_0.Count - 1) * num11;
					Class331.smethod_9(60000.0 / num8);
					if (Class331.smethod_12() == 0.0)
					{
						Class331.smethod_13(double_);
					}
					else
					{
						Class331.smethod_13(Class331.smethod_12() - (Class331.smethod_12() - num20) / 2.0);
					}
					this.editor_0.bool_5 = true;
					if (Class331.int_7 != this.list_0[this.list_0.Count - 1])
					{
						Class331.smethod_70(this.list_0[this.list_0.Count - 1], false, false);
					}
					num2 -= num4;
					goto IL_80F;
				}
				return;
			}
			IL_80F:
			this.int_0 = Class331.int_7;
			if (double.IsInfinity(Class331.smethod_8()))
			{
				this.method_8();
			}
		}

		// Token: 0x060026FE RID: 9982
		// RVA: 0x00016E41 File Offset: 0x00015041
		internal override bool vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x060026FF RID: 9983
		// RVA: 0x0001E2B9 File Offset: 0x0001C4B9
		internal override void vmethod_1(bool bool_8)
		{
			base.vmethod_1(bool_8);
			this.class911_1.bool_6 = bool_8;
		}

		// Token: 0x0600271D RID: 10013
		// RVA: 0x000F0A0C File Offset: 0x000EEC0C
		internal override bool vmethod_10(Keys keys_0, bool bool_8)
		{
			if (keys_0 == 77 && Class570.bool_0)
			{
				this.method_0(false, null);
				return true;
			}
			if (keys_0 == 76 && !Class570.bool_0)
			{
				this.method_3(0);
				return true;
			}
			if (keys_0 == 84 && bool_8)
			{
				this.method_9();
				return true;
			}
			if (keys_0 == 82)
			{
				this.method_8();
				return true;
			}
			return base.vmethod_10(keys_0, bool_8);
		}

		// Token: 0x06002707 RID: 9991
		// RVA: 0x000EFDF0 File Offset: 0x000EDFF0
		internal override void vmethod_11()
		{
			this.class911_1.float_0 = 1f;
			Class115.smethod_68(1f, false);
			this.editor_0.method_65();
			this.editor_0.int_10 = 6;
			if (!this.bool_7)
			{
				Editor expr_40 = this.editor_0;
				expr_40.method_67(expr_40.method_66() * 0.4f);
			}
			this.bool_7 = true;
			base.vmethod_11();
		}

		// Token: 0x06002708 RID: 9992
		// RVA: 0x000EFE5C File Offset: 0x000EE05C
		internal override void vmethod_12()
		{
			this.method_10();
			this.class911_1.float_0 = 0f;
			Editor expr_1C = this.editor_0;
			expr_1C.method_67(expr_1C.method_66() / 0.4f);
			this.bool_7 = false;
			this.class340_0 = null;
			Class802.smethod_15();
			base.vmethod_12();
		}

		// Token: 0x06002701 RID: 9985
		// RVA: 0x000EE7A0 File Offset: 0x000EC9A0
		internal override void vmethod_18()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < Class331.smethod_14().Count; i++)
			{
				Class340 class = Class331.smethod_14()[i];
				if (class.method_0())
				{
					stringBuilder.AppendFormat("{2}. Offset: {0:#,0}ms\tBPM: {1:#.00#}\n", class.double_1, class.method_5(), i + 1);
				}
				else
				{
					stringBuilder.AppendFormat("{2}. Offset: {0:#,0}ms\tBPM: Inherited ({1}x)\n", class.double_1, Math.Round(-100.0 / class.double_0, 1), i + 1);
				}
			}
			try
			{
				Clipboard.SetText(stringBuilder.ToString());
			}
			catch (Exception)
			{
				Class723.smethod_4(Class41.GetString(OsuString.General_Editor_ClipboardNotAvailable));
			}
		}

		// Token: 0x06002702 RID: 9986
		// RVA: 0x000EE874 File Offset: 0x000ECA74
		protected override void vmethod_2()
		{
			this.class366_0 = new Class366(this.editor_0);
			this.class911_1.Add(new Class531(Class885.Load("editor-timing-window-bg", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(120f, 85f), 0f, true, Color.get_White(), Enum105.const_3));
			this.class911_0.Add(new Class531(Class885.Load("editor-metronome-bg", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(200f, 0f), 0f, true, Color.get_White(), Enum105.const_3));
			int num = 120;
			int num2 = 30;
			this.class911_1.Add(new Class531(Class885.Load("editor-beat-selector-back", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(258f, 120f), 0.2f, true, Color.get_White(), Enum105.const_3));
			Class531 class = new Class531(Class885.Load("editor-beat-selector-buttonleft", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(270f, 130f), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.string_0 = string.Concat(new string[]
			{
				Class41.GetString(OsuString.Editor_Timing_DecreaseBPM),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldShiftForLargerChanges),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldCtrlForSmallerChanges)
			});
			class.method_2(new EventHandler(this.method_16));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-beat-selector-buttonright", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(382f, 130f), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.string_0 = string.Concat(new string[]
			{
				Class41.GetString(OsuString.Editor_Timing_IncreaseBPM),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldShiftForLargerChanges),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldCtrlForSmallerChanges)
			});
			class.method_2(new EventHandler(this.method_17));
			this.class911_1.Add(class);
			this.class533_0 = new Class533(string.Empty, 14f, new Vector2(324f, 130f), 0.9f, true, Color.get_White());
			this.class533_0.object_0 = Enum105.const_3;
			this.class533_0.origins_0 = Origins.Centre;
			this.class533_0.bool_1 = true;
			this.class533_0.class746_1 = new Class746(Color.get_White(), Color.get_YellowGreen(), 0, 200);
			this.class533_0.method_2(new EventHandler(this.method_34));
			this.class533_0.string_0 = Class41.GetString(OsuString.EditorModeTiming_ClickToFineTuneTooltip);
			this.class911_1.Add(this.class533_0);
			Class533 class2 = new Class533("BPM:", 14f, new Vector2(155f, 123f), 0.9f, true, Color.get_White());
			class2.enum72_0 = Enum72.const_3;
			class2.vector2_9 = new Vector2(100f, 20f);
			class2.object_0 = Enum105.const_3;
			this.class911_1.Add(class2);
			num = 150;
			this.class533_5 = new Class533(Class41.GetString(OsuString.EditorModeTiming_TimingMenuNote), 14f, new Vector2(145f, 150f), 0.9f, true, Color.get_White());
			this.class533_5.object_0 = Enum105.const_3;
			this.class911_1.Add(this.class533_5);
			num = 186;
			this.class911_1.Add(new Class531(Class885.Load("editor-beat-selector-back", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(258f, 186f), 0.2f, true, Color.get_White(), Enum105.const_3));
			class = new Class531(Class885.Load("editor-beat-selector-buttonleft", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(270f, 196f), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_14));
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.string_0 = string.Concat(new string[]
			{
				Class41.GetString(OsuString.General_DecreaseOffset),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldShiftForLargerChanges),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldCtrlForSmallerChanges)
			});
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-beat-selector-buttonright", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(382f, 196f), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.string_0 = string.Concat(new string[]
			{
				Class41.GetString(OsuString.General_IncreaseOffset),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldShiftForLargerChanges),
				"\n",
				Class41.GetString(OsuString.EditorModeTiming_HoldCtrlForSmallerChanges)
			});
			class.method_2(new EventHandler(this.method_15));
			this.class911_1.Add(class);
			this.class533_2 = new Class533(string.Empty, 14f, new Vector2(324f, 196f), 0.9f, true, Color.get_White());
			this.class533_2.object_0 = Enum105.const_3;
			this.class533_2.origins_0 = Origins.Centre;
			this.class533_2.bool_1 = true;
			this.class533_2.class746_1 = new Class746(Color.get_White(), Color.get_YellowGreen(), 0, 200);
			this.class533_2.method_2(new EventHandler(this.method_35));
			this.class533_2.string_0 = Class41.GetString(OsuString.EditorModeTiming_ClickToFineTuneTooltip);
			this.class911_1.Add(this.class533_2);
			class2 = new Class533(Class41.GetString(OsuString.General_Offset) + ":", 14f, new Vector2(155f, 189f), 0.9f, true, Color.get_White());
			class2.enum72_0 = Enum72.const_3;
			class2.vector2_9 = new Vector2(100f, 20f);
			class2.object_0 = Enum105.const_3;
			this.class911_1.Add(class2);
			class = new Class531(Class885.Load("editor-timing-manual", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(455f, 146f), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_1 = new Class746(TransformationType.Scale, 1f, 1.1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_36));
			class.string_0 = Class41.GetString(OsuString.EditorModeTiming_TimingSetupTooltip);
			this.class911_1.Add(class);
			num = 216;
			this.class762_0 = new Class762(Class41.GetString(OsuString.EditorModeTiming_MoveAlreadyPlacedNotes), new Vector2(145f, 216f), 0.9f, true);
			this.class762_0.method_4(Class41.GetString(OsuString.EditorModeTiming_MoveAlreadyPlacedTooltip));
			foreach (Class531 current in this.class762_0.list_0)
			{
				current.object_0 = Enum105.const_3;
			}
			this.class911_1.Add<Class531>(this.class762_0.list_0);
			num += 60;
			class2 = new Class533(Class41.GetString(OsuString.Editor_Timing_SliderVelocity) + ":", 14f, new Vector2(155f, (float)(num + 3)), 0.9f, true, Color.get_White());
			class2.enum72_0 = Enum72.const_3;
			class2.vector2_9 = new Vector2(100f, 20f);
			class2.object_0 = Enum105.const_3;
			this.class911_1.Add(class2);
			this.class911_1.Add(new Class531(Class885.Load("editor-beat-selector-back", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(258f, (float)num), 0.2f, true, Color.get_White(), Enum105.const_3));
			class = new Class531(Class885.Load("editor-beat-selector-buttonleft", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(270f, (float)(num + 10)), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_27));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-beat-selector-buttonright", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(382f, (float)(num + 10)), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_26));
			this.class911_1.Add(class);
			this.class533_4 = new Class533(string.Empty, 14f, new Vector2(324f, (float)(num + 10)), 0.9f, true, Color.get_White());
			this.class533_4.object_0 = Enum105.const_3;
			this.class533_4.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_4);
			num += num2;
			class2 = new Class533(Class41.GetString(OsuString.Editor_Timing_SliderTickRate) + ":", 14f, new Vector2(155f, (float)(num + 3)), 0.9f, true, Color.get_White());
			class2.enum72_0 = Enum72.const_3;
			class2.vector2_9 = new Vector2(100f, 20f);
			class2.object_0 = Enum105.const_3;
			this.class911_1.Add(class2);
			this.class911_1.Add(new Class531(Class885.Load("editor-beat-selector-back", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(258f, (float)num), 0.2f, true, Color.get_White(), Enum105.const_3));
			class = new Class531(Class885.Load("editor-beat-selector-buttonleft", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(270f, (float)(num + 10)), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_25));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-beat-selector-buttonright", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(382f, (float)(num + 10)), 0.9f, true, Color.get_White(), Enum105.const_3);
			class.bool_1 = true;
			class.class746_1 = new Class746(Color.get_White(), Color.get_Orange(), 0, 140);
			class.class746_0 = new Class746(TransformationType.Scale, 1.2f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_24));
			this.class911_1.Add(class);
			this.class533_3 = new Class533(string.Empty, 14f, new Vector2(324f, (float)(num + 10)), 0.9f, true, Color.get_White());
			this.class533_3.object_0 = Enum105.const_3;
			this.class533_3.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_3);
			this.class531_0 = new Class531[]
			{
				new Class531(Class885.Load("editor-metronome-beat-lighting", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(123f, 18f), 0.9f, true, Color.get_White(), null),
				new Class531(Class885.Load("editor-metronome-beat-lighting", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(89f, 18f), 0.9f, true, Color.get_White(), null),
				new Class531(Class885.Load("editor-metronome-beat-lighting", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(55f, 18f), 0.9f, true, Color.get_White(), null),
				new Class531(Class885.Load("editor-metronome-beat-lighting", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(21f, 18f), 0.9f, true, Color.get_White(), null)
			};
			Class531[] array = this.class531_0;
			for (int i = 0; i < array.Length; i++)
			{
				Class531 class3 = array[i];
				class3.object_0 = Enum105.const_3;
			}
			this.class911_0.Add<Class531>(this.class531_0);
			Class760 class4 = new Class760(Class41.GetString(OsuString.EditorModeTiming_TapHere), new Vector2(140f, 34f), new Vector2(136f, 25f), 1f, Color.get_SkyBlue(), new EventHandler(this.method_28), true, true, new float?(12f));
			class4.bool_0 = false;
			class4.method_7(Class41.GetString(OsuString.EditorModeTiming_TapHereTooltip));
			this.class911_0.Add<Class531>(class4.list_0);
			Class760 class5 = new Class760(Class41.GetString(OsuString.General_Reset), new Vector2(197f, 4f), new Vector2(58f, 58f), 1f, Color.get_Orange(), new EventHandler(this.method_23), true, true, new float?(12f));
			this.class911_0.Add<Class531>(class5.list_0);
			this.class533_1 = new Class533(string.Empty, 13f, new Vector2(200f, 20f), 1f, true, Color.get_White());
			this.class533_1.enum115_0 = Enum115.const_7;
			this.class533_1.origins_0 = Origins.TopRight;
			this.class533_1.object_0 = Enum105.const_3;
			this.class911_0.Add(this.class533_1);
		}

		// Token: 0x060026FB RID: 9979
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_21()
		{
		}

		// Token: 0x06002704 RID: 9988
		// RVA: 0x0001E2FF File Offset: 0x0001C4FF
		internal override void vmethod_3()
		{
			this.method_10();
			this.class366_0.method_0();
			if (Class331.int_1 != this.int_1)
			{
				this.int_1 = Class331.int_1;
				Class115.editorControl_0.method_11(Class331.smethod_18());
			}
		}

		// Token: 0x06002705 RID: 9989
		// RVA: 0x000EFA54 File Offset: 0x000EDC54
		internal override void vmethod_4()
		{
			foreach (Class340 current in Class331.smethod_14())
			{
				if (current.double_1 >= (double)this.editor_0.int_8 && current.double_1 <= (double)this.editor_0.int_9)
				{
					float num = this.editor_0.method_69(current.double_1) - 4f;
					byte b = (byte)Math.Min(255.0, 255.0 * ((double)Math.Max(0f, Math.Min(num - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num - (float)this.editor_0.int_4))) / 40.0));
					Color color;
					color..ctor(255, 255, 255, b);
					string text;
					if (current.method_0())
					{
						if (current.double_0 == 0.0)
						{
							text = "-";
						}
						else
						{
							text = string.Format("{0:0}bpm", 1000.0 / current.double_0 * 60.0);
						}
					}
					else
					{
						text = string.Format("{0}x", (current.double_0 < 0.0) ? Math.Round(-100.0 / current.double_0, 1) : 1.0);
					}
					Vector2 vector;
					vector..ctor(num, (float)(this.editor_0.int_5 + this.editor_0.int_3 - 37));
					float num2 = Class911.smethod_4((float)((int)current.double_1));
					Color color2 = current.method_0() ? color : new Color(180, 210, 254, b);
					Vector2 vector2;
					vector2..ctor(num + 6f, (float)(this.editor_0.int_5 + this.editor_0.int_3 - 27));
					float num3 = Class911.smethod_4((float)((int)current.double_1 - 2));
					List<Class530> list;
					if (!this.dictionary_0.TryGetValue(current, out list))
					{
						Class375.Class633 class = new Class375.Class633();
						list = new List<Class530>();
						list.Add(new Class531(Class885.Load("editor-timeline-timinginfo", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector, num2, true, color2, null)
						{
							bool_1 = true
						});
						List<Class530> arg_273_0 = list;
						Class533 class2 = new Class533(text, 14f, vector2, num3, true, Color.get_White());
						class2.method_59(true);
						class2.method_55(Color.get_Black());
						arg_273_0.Add(class2);
						class.int_0 = (int)current.double_1;
						list[0].method_2(new EventHandler(class.method_0));
						this.dictionary_0.Add(current, list);
					}
					else
					{
						list[0].vector2_1 = vector;
						list[0].float_0 = num2;
						list[0].float_3 = (float)b / 255f;
						list[0].color_0 = color2;
						list[1].vector2_1 = vector2;
						list[1].float_0 = num3;
						((Class533)list[1]).Text = text;
					}
					this.editor_0.class911_3.Add(list[0]);
					this.editor_0.class911_3.Add(list[1]);
				}
			}
		}

		// Token: 0x06002706 RID: 9990
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_5()
		{
		}
	}
}
