using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns24;
using ns26;
using ns29;
using ns76;
using ns79;
using ns80;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using System;

namespace ns21
{
	// Token: 0x02000511 RID: 1297
	internal sealed class Class76 : Class73
	{
		// Token: 0x060029D8 RID: 10712
		// RVA: 0x00020117 File Offset: 0x0001E317
		internal Class76(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x060029DF RID: 10719
		// RVA: 0x0002024C File Offset: 0x0001E44C
		protected override void Dispose(bool bool_5)
		{
			Class64.smethod_28();
			base.Dispose(bool_5);
		}

		// Token: 0x060029D9 RID: 10713
		// RVA: 0x00020120 File Offset: 0x0001E320
		public override void Draw()
		{
			base.Draw();
			Class62.class664_0.Draw();
		}

		// Token: 0x060029DC RID: 10716
		// RVA: 0x00020224 File Offset: 0x0001E424
		protected override void vmethod_10()
		{
			this.class512_0 = Class62.class512_0;
		}

		// Token: 0x060029DB RID: 10715
		// RVA: 0x0010BE00 File Offset: 0x0010A000
		protected override void vmethod_11()
		{
			Class62.class664_0.vector2_0 = new Vector2(515f, 120f);
			Class62.class664_0.class911_0.bool_8 = true;
			foreach (Class660 current in Class62.class664_0.list_0)
			{
				current.class531_0.vmethod_7(Class885.Load("menu-button-background", Enum112.flag_6));
				current.class531_0.vector2_5 = new Vector2(26f, 20f);
				current.class531_0.object_0 = current;
				current.class533_2.Text = string.Empty;
				current.class531_0.class746_1 = new Class746(current.class531_0.color_0, Color.get_YellowGreen(), 0, 100);
			}
			Class62.class664_0.class911_0.method_12("extra");
			Class62.class664_0.method_2(true);
			Class62.class664_0.class911_0.float_0 = 1f;
			this.class512_0.bool_2 = true;
			this.vmethod_6(this.class512_0);
			this.int_2 = Class115.int_1 + 300;
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.7f, true, Color.get_Black(), null);
			class.vector2_2 = new Vector2((float)Class115.smethod_43() * 1.6f, 83f);
			this.class911_2.Add(class);
			Class533 class530_ = new Class533("Multiplayer Results", 22f, new Vector2(0f, 0f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_2.Add(class530_);
			class530_ = new Class533("Beatmap: " + Class466.Current.string_6, 16f, new Vector2(1f, 20f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_2.Add(class530_);
			class530_ = new Class533("Match played at " + this.class512_0.dateTime_0.ToString("yy/MM/dd hh:mm:ss", Class115.numberFormatInfo_0), 16f, new Vector2(1f, 34f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_2.Add(class530_);
			this.class531_0 = new Class531(Class885.Load("ranking-back", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(520f, 430f), 0.94f, true, new Color(255, 255, 255, 178), null);
			this.class531_0.method_2(new EventHandler(base.method_6));
			this.class531_0.bool_1 = true;
			this.class531_0.class746_1 = new Class746(TransformationType.Fade, 0.7f, 1f, 0, 200, Enum70.const_0);
			if (!Class115.bool_16)
			{
				this.class911_2.Add(this.class531_0);
			}
		}

		// Token: 0x060029DD RID: 10717
		// RVA: 0x0002009F File Offset: 0x0001E29F
		protected override bool vmethod_12(object object_0, EventArgs eventArgs_0)
		{
			base.method_10(false);
			return false;
		}

		// Token: 0x060029DE RID: 10718
		// RVA: 0x00020231 File Offset: 0x0001E431
		protected override void vmethod_13()
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.MatchSetup, false);
		}

		// Token: 0x060029E0 RID: 10720
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_14()
		{
		}

		// Token: 0x060029DA RID: 10714
		// RVA: 0x0010BC38 File Offset: 0x00109E38
		protected override void vmethod_7()
		{
			int num = 0;
			float num2 = 0f;
			int num3 = 360;
			foreach (Mods mods in Enum.GetValues(typeof(Mods)))
			{
				if (Class876.smethod_6(this.class512_0.class623_0, mods) && (mods != Mods.DoubleTime || !Class876.smethod_6(this.class512_0.class623_0, Mods.Nightcore)) && (mods != Mods.SuddenDeath || !Class876.smethod_6(this.class512_0.class623_0, Mods.Perfect)))
				{
					Class746 class = new Class746(TransformationType.Scale, 2f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					Class746 class2 = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					class.enum70_0 = Enum70.const_1;
					class2.enum70_0 = Enum70.const_1;
					Class531 class3 = new Class531(Class885.Load("selection-mod-" + mods.ToString().ToLower(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)num3, 440f), 0.92f + num2, true, Color.get_TransparentWhite(), null);
					class3.class26_0.Add(class);
					class3.class26_0.Add(class2);
					this.class911_2.Add(class3);
					num += 500;
					num2 += 1E-05f;
					num3 -= 20;
				}
			}
		}
	}
}
