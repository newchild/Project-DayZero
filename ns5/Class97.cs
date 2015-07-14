using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns24;
using ns25;
using ns27;
using ns29;
using ns64;
using ns7;
using ns79;
using ns90;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns5
{
	// Token: 0x020004D7 RID: 1239
	internal sealed class Class97 : Class89
	{
		// Token: 0x04002112 RID: 8466
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04002113 RID: 8467
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04002114 RID: 8468
		[CompilerGenerated]
		private static Action<Class531> action_4;

		// Token: 0x04002111 RID: 8465
		private Class753 class753_0;

		// Token: 0x0400210D RID: 8461
		private Class754 class754_0;

		// Token: 0x0400210E RID: 8462
		private Class754 class754_1;

		// Token: 0x0400210F RID: 8463
		private Class762 class762_0;

		// Token: 0x04002110 RID: 8464
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x060027E9 RID: 10217
		// RVA: 0x0001EB8E File Offset: 0x0001CD8E
		internal Class97() : base("Create New Game...", true)
		{
		}

		// Token: 0x060027EF RID: 10223
		// RVA: 0x0001EBA7 File Offset: 0x0001CDA7
		protected override void Dispose(bool bool_5)
		{
			this.class754_0.Dispose();
			base.Dispose(bool_5);
		}

		// Token: 0x060027EC RID: 10220
		// RVA: 0x000F8C04 File Offset: 0x000F6E04
		private void method_10(object object_0, bool bool_5)
		{
			if (bool_5)
			{
				List<Class531> arg_26_0 = this.list_1;
				if (Class97.action_3 == null)
				{
					Class97.action_3 = new Action<Class531>(Class97.smethod_3);
				}
				arg_26_0.ForEach(Class97.action_3);
				return;
			}
			List<Class531> arg_4F_0 = this.list_1;
			if (Class97.action_4 == null)
			{
				Class97.action_4 = new Action<Class531>(Class97.smethod_4);
			}
			arg_4F_0.ForEach(Class97.action_4);
		}

		// Token: 0x060027ED RID: 10221
		// RVA: 0x000F8C68 File Offset: 0x000F6E68
		private void method_11(Class754 class754_2, bool bool_5)
		{
			if (this.class754_0.class533_0.Text.Length == 0)
			{
				this.class754_0.class533_0.Text = this.class754_0.string_0;
			}
			if (bool_5)
			{
				this.class754_0.bool_0 = false;
			}
		}

		// Token: 0x060027EE RID: 10222
		// RVA: 0x000F8CB8 File Offset: 0x000F6EB8
		private void method_12(object sender, EventArgs e)
		{
			if (Class70.enum59_0 == Enum59.const_3)
			{
				return;
			}
			if (this.class762_0.method_2() && this.class754_1.class533_0.Text.Length == 0)
			{
				Class723.smethod_4("Enter a password before attempting to start the game...");
				return;
			}
			Class723.smethod_1("Creating game...", 1600);
			Class70.enum59_0 = Enum59.const_3;
			Class10 class = new Class10(MatchTypes.Standard, MatchScoringTypes.Score, MatchTeamTypes.HeadToHead, PlayModes.Osu, this.class754_0.class533_0.Text, this.class762_0.method_2() ? this.class754_1.class533_0.Text : null, (int)this.class753_0.object_0, Class466.Current.string_6, Class466.Current.string_3, Class466.Current.int_2, Mods.None, Class115.class861_0.int_1, MultiSpecialModes.None, Class62.int_12);
			Class72.class10_0 = class;
			Class809.smethod_34(Enum3.const_31, class);
		}

		// Token: 0x060027EB RID: 10219
		// RVA: 0x0001EB61 File Offset: 0x0001CD61
		private void method_9(object sender, EventArgs e)
		{
			if (Class70.enum59_0 == Enum59.const_2)
			{
				return;
			}
			this.Close(false);
		}

		// Token: 0x060027F1 RID: 10225
		// RVA: 0x0001EBD6 File Offset: 0x0001CDD6
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_1)
		{
			class531_1.method_16(0, Enum70.const_0);
		}

		// Token: 0x060027F2 RID: 10226
		// RVA: 0x0001EBE0 File Offset: 0x0001CDE0
		[CompilerGenerated]
		private static void smethod_3(Class531 class531_1)
		{
			class531_1.method_14(50, Enum70.const_0);
		}

		// Token: 0x060027F3 RID: 10227
		// RVA: 0x0001EBEB File Offset: 0x0001CDEB
		[CompilerGenerated]
		private static void smethod_4(Class531 class531_1)
		{
			class531_1.method_16(50, Enum70.const_0);
		}

		// Token: 0x060027EA RID: 10218
		// RVA: 0x000F8848 File Offset: 0x000F6A48
		internal override void vmethod_3()
		{
			Class533 class = new Class533("Game Name:", 16f, new Vector2(30f, 100f), 0.92f, true, Color.get_White());
			this.class911_0.Add(class);
			this.class754_0 = new Class754(Class341.class605_20 + "'s game", 16, new Vector2(150f, 100f), 450f, 0.92f, false);
			this.class754_0.int_0 = 50;
			this.class754_0.method_2(new Class754.Delegate37(this.method_11));
			this.class754_0.bool_0 = true;
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			this.class762_0 = new Class762("Require password to join", new Vector2(30f, 130f), 0.92f, false);
			this.class762_0.method_8(new Delegate38(this.method_10));
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			class = new Class533("Password:", 16f, new Vector2(30f, 160f), 0.92f, true, Color.get_White());
			this.class911_0.Add(class);
			this.list_1.Add(class);
			this.class754_1 = new Class754("", 16, new Vector2(150f, 160f), 450f, 0.92f, false);
			this.class754_1.int_0 = 50;
			this.class911_0.Add<Class531>(this.class754_1.list_0);
			this.list_1.AddRange(this.class754_1.list_0);
			class = new Class533("Max Players:", 16f, new Vector2(30f, 190f), 0.92f, true, Color.get_White());
			this.class911_0.Add(class);
			this.float_0 = 250f;
			base.method_3("Start Game", Color.get_LimeGreen(), new EventHandler(this.method_12), false, false, true);
			base.method_3("Cancel", Color.get_LightGray(), new EventHandler(this.method_9), false, false, true);
			this.class753_0 = new Class753(null, "", new Vector2(150f, 190f), 200f, 0.96f);
			this.class753_0.method_9("2 players", 2);
			this.class753_0.method_9("3 players", 3);
			this.class753_0.method_9("4 players", 4);
			this.class753_0.method_9("5 players", 5);
			this.class753_0.method_9("6 players", 6);
			this.class753_0.method_9("7 players", 7);
			this.class753_0.method_9("8 players", 8);
			if (bMatch.smethod_0() > 8)
			{
				this.class753_0.method_9(bMatch.smethod_0() + " players", bMatch.smethod_0());
			}
			this.class753_0.method_18(8, true);
			this.class753_0.class911_0 = this.class911_0;
			this.class911_0.Add<Class531>(this.class753_0.list_0);
			base.vmethod_3();
			this.class531_0.color_0 = new Color(0, 0, 0, 200);
			List<Class531> arg_3A7_0 = this.list_1;
			if (Class97.action_2 == null)
			{
				Class97.action_2 = new Action<Class531>(Class97.smethod_2);
			}
			arg_3A7_0.ForEach(Class97.action_2);
		}

		// Token: 0x060027F0 RID: 10224
		// RVA: 0x0001EBBB File Offset: 0x0001CDBB
		internal override bool vmethod_5(Keys keys_0)
		{
			if (!base.vmethod_5(keys_0))
			{
				return false;
			}
			if (keys_0 == 13)
			{
				this.method_12(null, null);
			}
			return true;
		}
	}
}
