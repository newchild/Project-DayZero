using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns24;
using ns26;
using ns29;
using ns40;
using ns5;
using ns6;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns84;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x0200050F RID: 1295
	internal class Class74 : Class73
	{
		// Token: 0x04002299 RID: 8857
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002298 RID: 8856
		private List<Class531> list_2;

		// Token: 0x060029BC RID: 10684
		// RVA: 0x00020117 File Offset: 0x0001E317
		internal Class74(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x060029BE RID: 10686
		// RVA: 0x00020132 File Offset: 0x0001E332
		protected override void Dispose(bool bool_5)
		{
			if (Class115.osuModes_0 != OsuModes.RankingVs)
			{
				Class64.smethod_28();
				base.Dispose(bool_5);
			}
		}

		// Token: 0x060029BD RID: 10685
		// RVA: 0x00020120 File Offset: 0x0001E320
		public override void Draw()
		{
			base.Draw();
			Class62.class664_0.Draw();
		}

		// Token: 0x060029C0 RID: 10688
		// RVA: 0x00020149 File Offset: 0x0001E349
		protected void method_15(string string_1, Class512 class512_1)
		{
			this.vmethod_6(class512_1);
		}

		// Token: 0x060029C1 RID: 10689
		// RVA: 0x00109B78 File Offset: 0x00107D78
		private void method_16(object sender, EventArgs e)
		{
			Class660 class = (Class660)((Class531)sender).object_0;
			Class62.class664_0.method_2(true);
			class.method_5(class.class531_0.vector2_1 - new Vector2(30f, 0f), true, false);
			this.method_15(class.string_0, class.class512_0);
		}

		// Token: 0x060029C8 RID: 10696
		// RVA: 0x000191A5 File Offset: 0x000173A5
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_8)
		{
			class531_8.method_16(200, Enum70.const_0);
			class531_8.bool_0 = false;
		}

		// Token: 0x060029C4 RID: 10692
		// RVA: 0x00020152 File Offset: 0x0001E352
		protected override void vmethod_10()
		{
			base.method_3(false);
		}

		// Token: 0x060029C3 RID: 10691
		// RVA: 0x00109DC8 File Offset: 0x00107FC8
		protected override void vmethod_11()
		{
			Class62.class664_0.vector2_0 = new Vector2((float)(Class115.smethod_43() - 125), 120f);
			foreach (Class660 current in Class62.class664_0.list_0)
			{
				current.class531_0.vmethod_7(Class885.Load("menu-button-background", Enum112.flag_6));
				current.class531_0.vector2_5 = new Vector2(26f, 20f);
				current.class531_0.method_2(new EventHandler(this.method_16));
				current.class531_0.bool_1 = true;
				current.class531_0.object_0 = current;
				current.class531_0.class746_1 = new Class746(current.class531_0.color_0, Color.get_YellowGreen(), 0, 100);
				if (current.string_0 == Class115.class861_0.Name)
				{
					Class111.smethod_25(string.Format(Class41.GetString(OsuString.Userlog_Multiplayer), new object[]
					{
						current.int_2,
						Class62.class664_0.list_0.Count,
						Class466.Current.string_7,
						Class213.smethod_0(Class62.Mode)
					}));
				}
			}
			Class62.class664_0.class911_0.float_0 = 1f;
			Class533 class = new Class533("Click a player tab to view their score! Hit F2 to export your replay.", 14f, new Vector2((float)Class115.smethod_43(), 60f), Vector2.get_Zero(), 1f, true, Color.get_White(), false)
			{
				enum72_0 = Enum72.const_3,
				origins_0 = Origins.TopRight,
				bool_11 = true
			};
			class.bool_16 = true;
			this.class911_2.Add(class);
			this.int_2 = Class115.int_1 + 300;
			if (Class62.class664_0.class660_0 != null)
			{
				Class62.class664_0.class660_0.class531_0.method_0(true);
			}
			Class533 class2 = new Class533(Class466.Current.string_6, 22f, new Vector2(0f, 0f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class2.bool_11 = true;
			this.class911_2.Add(class2);
			class2 = new Class533("Beatmap by " + Class466.Current.string_5, 16f, new Vector2(1f, 20f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class2.bool_11 = true;
			this.class911_2.Add(class2);
			class2 = new Class533("Match played at " + this.class512_0.dateTime_0.ToString("yy/MM/dd hh:mm:ss", Class115.numberFormatInfo_0), 16f, new Vector2(1f, 34f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class2.bool_11 = true;
			this.class911_2.Add(class2);
			if (!Class72.class10_0.method_6() && Class62.class664_0.list_0.Count > 1 && Class62.class664_0.list_0[0].int_3 != Class62.class664_0.list_0[1].int_3)
			{
				Class731 class3 = ((Class661)Class62.class664_0.list_0[0]).class537_0.vmethod_6();
				Class531 class4 = new Class531(Class885.Load("ranking-winner", Enum112.flag_6), new Vector2(395f, 10f), 0.4f, true, Color.get_White());
				this.class911_2.Add(class4);
				if (class3 != null)
				{
					Class531 class5 = new Class531(class3, Origins.Centre, new Vector2(457.5f, 89f), 0.41f, true, Color.get_White());
					class5.float_2 = 185f / (float)Math.Max(class5.int_6, class5.int_5);
					this.class911_2.Add(class5);
					class5.method_23(new Vector2(0f, 200f), 2000, Enum70.const_1);
					class5.method_15(1500);
				}
				class4.method_23(new Vector2(0f, 200f), 2000, Enum70.const_1);
				class4.method_15(1500);
			}
		}

		// Token: 0x060029C5 RID: 10693
		// RVA: 0x0002009F File Offset: 0x0001E29F
		protected override bool vmethod_12(object object_0, EventArgs eventArgs_0)
		{
			base.method_10(false);
			return false;
		}

		// Token: 0x060029C6 RID: 10694
		// RVA: 0x0002015B File Offset: 0x0001E35B
		protected override void vmethod_13()
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class72.bool_11 = true;
			Class115.smethod_70(OsuModes.MatchSetup, false);
		}

		// Token: 0x060029C7 RID: 10695
		// RVA: 0x0002017C File Offset: 0x0001E37C
		protected override void vmethod_14()
		{
			if (this.class512_0.bool_0)
			{
				base.vmethod_14();
			}
		}

		// Token: 0x060029BF RID: 10687
		// RVA: 0x00109AF4 File Offset: 0x00107CF4
		protected override void vmethod_7()
		{
			if (this.list_2 != null)
			{
				List<Class531> arg_2B_0 = this.list_2;
				if (Class74.action_0 == null)
				{
					Class74.action_0 = new Action<Class531>(Class74.smethod_2);
				}
				arg_2B_0.ForEach(Class74.action_0);
			}
			this.list_2 = Class876.smethod_12(this.class512_0.class623_0, new Vector2(305f, 440f), 1f, "mods");
			this.class911_2.Add<Class531>(this.list_2);
		}

		// Token: 0x060029C2 RID: 10690
		// RVA: 0x00109BDC File Offset: 0x00107DDC
		protected override void vmethod_8(int int_3)
		{
			if (this.class512_0.vmethod_4() < Rankings.F)
			{
				Class531 class = new Class531(Class885.Load("ranking-" + this.class512_0.vmethod_4(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(180f, 250f), 0.3f, true, Color.get_TransparentWhite(), null);
				Class746 class2 = new Class746(TransformationType.Scale, 1.4f, 1f, this.int_2 + int_3, this.int_2 + int_3 + 1000, Enum70.const_0);
				class2.enum70_0 = Enum70.const_2;
				class.class26_0.Add(class2);
				class2 = new Class746(TransformationType.Fade, 0f, 0.4f, this.int_2 + int_3, this.int_2 + int_3 + 1000, Enum70.const_0);
				class2.enum70_0 = Enum70.const_2;
				class.class26_0.Add(class2);
				this.class911_2.Add(class);
				this.list_0.Add(class);
				if (this.class512_0.vmethod_4() < Rankings.B)
				{
					class = new Class531(Class885.Load("ranking-" + this.class512_0.vmethod_4(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(180f, 270f), 0.9f, true, Color.get_TransparentWhite(), null);
					class2 = new Class746(TransformationType.Scale, 1f, 2f, this.int_2 + int_3 + 1000, this.int_2 + int_3 + 1400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					this.list_0.Add(class);
					class2 = new Class746(TransformationType.Fade, 0.4f, 0f, this.int_2 + int_3 + 1000, this.int_2 + int_3 + 1400, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					this.class911_2.Add(class);
					this.list_0.Add(class);
				}
			}
		}
	}
}
