using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns24;
using ns26;
using ns29;
using ns59;
using ns76;
using ns79;
using ns8;
using ns81;
using ns82;
using ns90;
using osu;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;

namespace ns18
{
	// Token: 0x02000508 RID: 1288
	internal sealed class Class63 : Class62
	{
		// Token: 0x04002251 RID: 8785
		private static bool bool_48;

		// Token: 0x04002253 RID: 8787
		private Class512 class512_1;

		// Token: 0x0400224B RID: 8779
		private Class533 class533_2;

		// Token: 0x0400224C RID: 8780
		private Class533 class533_3;

		// Token: 0x0400224D RID: 8781
		private Class533 class533_4;

		// Token: 0x04002249 RID: 8777
		private double double_0;

		// Token: 0x0400224A RID: 8778
		private double double_1;

		// Token: 0x04002247 RID: 8775
		private int int_35 = -1;

		// Token: 0x04002248 RID: 8776
		private int int_36;

		// Token: 0x0400224E RID: 8782
		internal int int_37;

		// Token: 0x0400224F RID: 8783
		internal int int_38;

		// Token: 0x04002250 RID: 8784
		internal int int_39;

		// Token: 0x04002252 RID: 8786
		internal static List<int> list_4;

		// Token: 0x06002963 RID: 10595
		// RVA: 0x0001FCF3 File Offset: 0x0001DEF3
		protected override void Dispose(bool bool_49)
		{
			if (Class115.osuModes_1 != OsuModes.Edit && Class115.osuModes_1 != OsuModes.Play)
			{
				Class115.bool_25 = false;
			}
			Class63.bool_48 = (Class62.bool_27 && Class802.smethod_0());
			Class802.smethod_1(false);
			base.Dispose(bool_49);
		}

		// Token: 0x06002961 RID: 10593
		// RVA: 0x00104E2C File Offset: 0x0010302C
		public override void imethod_2()
		{
			if (this.class523_0.bool_0 && this.class297_0.int_14 != 0)
			{
				if (Class63.bool_48 && !this.method_80())
				{
					this.method_81(true);
					Class63.bool_48 = false;
				}
				float num = Class115.smethod_47() * (float)(Class115.class83_0.method_2() + this.class872_0.class911_1.int_3 + this.class872_0.class911_0.int_3 + this.class872_0.class911_2.int_3);
				if (Class115.bool_13)
				{
					this.class533_2.color_0 = ((num > 5f) ? Color.get_Red() : Color.get_White());
					this.class533_2.bool_16 = (num > 5f);
					this.class533_2.Text = string.Format("Current: {0:00}:{1:00}:{2:00} | SB Load: {3:0.00}x", new object[]
					{
						Class331.int_7 / 1000 / 60,
						Class331.int_7 % 60000 / 1000,
						Class331.int_7 % 1000 / 10,
						num
					});
				}
				if (this.int_35 == -1 || (this.class297_0.int_13 >= 0 && Class331.int_7 - this.class297_0.list_3[this.class297_0.int_13].EndTime > 200 && Class331.int_7 / 200 > this.int_35))
				{
					this.int_35 = Class331.int_7 / 200;
					if (Class62.Mode == PlayModes.OsuMania)
					{
						this.class533_3.Text = string.Format("300g x {0}\n300 x {1}\n200 x {2}\n100 x {3}\n50 x {4}\nMiss x {5}\nMistimed Hits: {6:#,0}% (ave {7}ms {8})", new object[]
						{
							Class62.class512_0.ushort_3,
							Class62.class512_0.ushort_1,
							Class62.class512_0.ushort_4,
							Class62.class512_0.ushort_0,
							Class62.class512_0.ushort_2,
							Class62.class512_0.ushort_5,
							(this.int_39 > 0) ? ((float)this.int_36 / (float)this.int_39 * 100f) : 0f,
							(this.double_1 > 0.0) ? ((int)Math.Round(Math.Abs(this.double_0 / this.double_1))) : 0,
							(this.double_0 < 0.0) ? Class41.GetString(OsuString.PlayerTest_Early) : Class41.GetString(OsuString.PlayerTest_Late)
						});
					}
					else
					{
						this.class533_3.Text = string.Format("300 x {0}\n100 x {1}\n50 x {2}\nMiss x {3}\n\nMistimed Hits: {4:#,0}% (ave {5}ms {6})", new object[]
						{
							Class62.class512_0.ushort_1,
							Class62.class512_0.ushort_0,
							Class62.class512_0.ushort_2,
							Class62.class512_0.ushort_5,
							(this.int_39 > 0) ? ((float)this.int_36 / (float)this.int_39 * 100f) : 0f,
							(this.double_1 > 0.0) ? ((int)Math.Round(Math.Abs(this.double_0 / this.double_1))) : 0,
							(this.double_0 < 0.0) ? Class41.GetString(OsuString.PlayerTest_Early) : Class41.GetString(OsuString.PlayerTest_Late)
						});
					}
				}
				base.imethod_2();
				return;
			}
			base.method_45();
		}

		// Token: 0x06002967 RID: 10599
		// RVA: 0x0001FD33 File Offset: 0x0001DF33
		public override void Initialize()
		{
			base.Initialize();
		}

		// Token: 0x06002964 RID: 10596
		// RVA: 0x0001FD2C File Offset: 0x0001DF2C
		private bool method_80()
		{
			return Class802.smethod_0();
		}

		// Token: 0x06002965 RID: 10597
		// RVA: 0x001051F8 File Offset: 0x001033F8
		private void method_81(bool bool_49)
		{
			if (bool_49 == Class802.smethod_0())
			{
				return;
			}
			if (Class115.bool_25 && Class331.int_7 < this.class297_0.list_3[this.class297_0.int_14 - 1].EndTime && Class62.bool_40)
			{
				Class802.smethod_1(bool_49);
				if (Class802.smethod_0())
				{
					Class802.class512_0 = this.class512_1;
					while (Class802.class512_0.list_1[Class802.int_1].int_0 < Class331.int_7)
					{
						Class802.int_1++;
					}
					Class802.int_1 -= 2;
					if (Class802.int_1 < 0)
					{
						Class802.int_1 = 0;
					}
					foreach (Class304 current in this.class297_0.list_3)
					{
						if (current.EndTime >= Class331.int_7)
						{
							break;
						}
						current.bool_0 = true;
					}
				}
				Class723.smethod_1("Autoplay mod " + (Class802.smethod_0() ? "enabled" : "disabled"), 2000);
				return;
			}
		}

		// Token: 0x0600296A RID: 10602
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_11()
		{
		}

		// Token: 0x06002962 RID: 10594
		// RVA: 0x0001FCE9 File Offset: 0x0001DEE9
		protected override bool vmethod_14()
		{
			Class115.smethod_70(OsuModes.Edit, false);
			return true;
		}

		// Token: 0x06002966 RID: 10598
		// RVA: 0x00105334 File Offset: 0x00103534
		protected override bool vmethod_15(object object_0, Keys keys_0)
		{
			if (this.method_80() && Class795.smethod_12(keys_0, Class62.Mode))
			{
				this.method_81(false);
			}
			if (base.vmethod_15(object_0, keys_0))
			{
				return true;
			}
			if (keys_0 <= 66)
			{
				if (keys_0 == 9)
				{
					this.method_81(!this.method_80());
					return true;
				}
				if (keys_0 == 66)
				{
					if (Class570.bool_0)
					{
						if (Class63.list_4 == null && this.class297_0.list_1 != null)
						{
							Class63.list_4 = this.class297_0.list_1;
						}
						else if (Class63.list_4 == null)
						{
							Class63.list_4 = new List<int>();
						}
						Class63.list_4.Add(Class331.int_7);
						Class723.smethod_1("Added new bookmark!", 1000);
						return true;
					}
					return false;
				}
			}
			else if (keys_0 != 80)
			{
				switch (keys_0)
				{
				case 112:
					Class115.smethod_71(OsuModes.Edit, false);
					return true;
				case 113:
					Class115.int_28 = Class331.int_7;
					Class115.smethod_71(OsuModes.Edit, false);
					return true;
				case 114:
				{
					if (!Class802.smethod_0())
					{
						Class723.smethod_1("Press [Tab] to active autoplay before changing speed.", 1500);
						return true;
					}
					int num = Class331.smethod_67();
					if (num == 150)
					{
						num = 100;
					}
					else
					{
						num = 150;
					}
					Class331.smethod_68(num);
					Class723.smethod_1(string.Format("Speed set to {0:0.0}x", (double)num / 100.0), 1000);
					return true;
				}
				}
			}
			else
			{
				if (Class570.bool_0)
				{
					Class331.smethod_88();
					Class62.bool_11 = !Class62.bool_11;
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06002969 RID: 10601
		// RVA: 0x00105730 File Offset: 0x00103930
		internal override void vmethod_31(Class304 class304_2)
		{
			if (Class62.Mode == PlayModes.OsuMania && class304_2.EndTime > class304_2.StartTime)
			{
				return;
			}
			int num = Math.Abs(Class331.int_7 - class304_2.StartTime);
			if (num > 20)
			{
				this.int_36++;
			}
			this.double_0 = 0.95 * this.double_0 + 0.05 * (double)(Class331.int_7 - class304_2.StartTime);
			this.double_1 = 1.0 - (1.0 - this.double_1) * 0.95;
			if (this.double_1 > 0.99)
			{
				this.double_1 = 1.0;
			}
			this.int_39++;
			base.vmethod_31(class304_2);
		}

		// Token: 0x06002968 RID: 10600
		// RVA: 0x001054AC File Offset: 0x001036AC
		protected override bool vmethod_7(bool bool_49)
		{
			this.class512_1 = Class802.class512_0;
			this.class533_2 = new Class533("\n", 10f, new Vector2(1f, 44f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_2.bool_15 = false;
			this.class533_2.bool_17 = false;
			this.class533_2.nullable_2 = new bool?(true);
			this.class911_2.Add(this.class533_2);
			int num = (int)(this.class533_2.vmethod_11().Y * 1f / Class115.float_4);
			this.class533_3 = new Class533(string.Empty, 10f, new Vector2(1f, (float)(50 + num)), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_3.bool_15 = false;
			this.class533_3.bool_17 = false;
			this.class533_3.nullable_2 = new bool?(true);
			this.class911_2.Add(this.class533_3);
			this.class533_4 = new Class533(string.Empty, 10f, new Vector2(1f, this.class533_3.vector2_1.Y + (float)(num * 9) + 6f), Vector2.get_Zero(), 1f, true, new Color(231, 255, 208), true);
			this.class533_4.bool_15 = false;
			this.class533_4.bool_17 = false;
			this.class533_4.nullable_2 = new bool?(true);
			this.class911_2.Add(this.class533_4);
			int num2 = this.int_38;
			if (Class62.Mode == PlayModes.OsuMania)
			{
				num2 = 1000000;
			}
			this.class533_4.Text = string.Format("Star Rating: {3:0.00}\nTotal Play Length: {0}s\nMaximum Score: {1:0,0}\nMaximum Combo: {2:0,0}\n\nTab: autoplay\nCtrl-B: bookmark\nCtrl-P: Toggle pause\nF1: quick exit\nF2: exit at current pos\nF3: change autoplay speed", new object[]
			{
				Class466.Current.int_9,
				num2,
				this.int_37,
				Class466.Current.method_26()
			});
			Class340 class = Class331.smethod_7();
			if (class != null)
			{
				Class62.bool_38 = class.method_2();
			}
			if (Class62.bool_38)
			{
				this.class427_0.vmethod_46(Class62.bool_38);
			}
			if (this.class872_0 != null)
			{
				this.class872_0.class911_1.bool_2 = true;
				this.class872_0.class911_0.bool_2 = true;
				this.class872_0.class911_2.bool_2 = true;
			}
			return base.vmethod_7(bool_49);
		}

		// Token: 0x0600296B RID: 10603
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_9()
		{
		}
	}
}
