using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns26;
using ns27;
using ns29;
using ns79;
using ns8;
using ns80;
using ns82;
using ns84;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020004D8 RID: 1240
	internal sealed class Class98 : Class89
	{
		// Token: 0x020004D9 RID: 1241
		[CompilerGenerated]
		private sealed class Class643
		{
			// Token: 0x0400211B RID: 8475
			public Class533 class533_0;

			// Token: 0x0400211C RID: 8476
			public Class98 class98_0;

			// Token: 0x06002800 RID: 10240
			// RVA: 0x0001ECF9 File Offset: 0x0001CEF9
			public void method_0(object sender, EventArgs e)
			{
				this.class533_0.method_53(Color.get_Red());
				this.class533_0.bool_18 = true;
			}

			// Token: 0x06002801 RID: 10241
			// RVA: 0x0001ED17 File Offset: 0x0001CF17
			public void method_1(object sender, EventArgs e)
			{
				this.class533_0.method_53(Color.get_Black());
				this.class533_0.bool_18 = true;
			}
		}

		// Token: 0x020004DA RID: 1242
		[CompilerGenerated]
		private sealed class Class644
		{
			// Token: 0x0400211E RID: 8478
			public Class533 class533_0;

			// Token: 0x0400211D RID: 8477
			public Class98.Class643 class643_0;

			// Token: 0x06002803 RID: 10243
			// RVA: 0x0001ED35 File Offset: 0x0001CF35
			public void method_0(object sender, EventArgs e)
			{
				this.class533_0.method_53(Color.get_Gray());
				this.class533_0.method_57(Color.get_Black());
				this.class533_0.bool_18 = true;
			}

			// Token: 0x06002804 RID: 10244
			// RVA: 0x0001ED63 File Offset: 0x0001CF63
			public void method_1(object sender, EventArgs e)
			{
				this.class533_0.method_53(Color.get_Black());
				this.class533_0.method_57(Color.get_White());
				this.class533_0.bool_18 = true;
			}
		}

		// Token: 0x020004DB RID: 1243
		[CompilerGenerated]
		private sealed class Class645
		{
			// Token: 0x04002122 RID: 8482
			public Bindings bindings_0;

			// Token: 0x04002120 RID: 8480
			public Class98.Class643 class643_0;

			// Token: 0x0400211F RID: 8479
			public Class98.Class644 class644_0;

			// Token: 0x04002121 RID: 8481
			public string string_0;

			// Token: 0x06002806 RID: 10246
			// RVA: 0x0001ED91 File Offset: 0x0001CF91
			public void method_0(object sender, EventArgs e)
			{
				this.class643_0.class98_0.method_10(this.bindings_0, this.string_0);
			}
		}

		// Token: 0x04002117 RID: 8471
		private Bindings bindings_0;

		// Token: 0x04002115 RID: 8469
		private Class110 class110_0;

		// Token: 0x04002118 RID: 8472
		private Class533 class533_0;

		// Token: 0x04002119 RID: 8473
		private Class533 class533_1;

		// Token: 0x0400211A RID: 8474
		private Class533 class533_2;

		// Token: 0x04002116 RID: 8470
		private Class911 class911_1 = new Class911(true);

		// Token: 0x060027F4 RID: 10228
		// RVA: 0x000F8D9C File Offset: 0x000F6F9C
		public Class98() : base(Class41.GetString(OsuString.Options_Input_KeyBindings), false)
		{
			this.class110_0 = new Class110(new Rectangle(110, 30, 420, 420), Vector2.get_Zero(), false, 0f, Enum98.const_5);
		}

		// Token: 0x060027FC RID: 10236
		// RVA: 0x0001ECB7 File Offset: 0x0001CEB7
		protected override void Dispose(bool bool_5)
		{
			base.Dispose(bool_5);
			this.class911_1.Dispose();
			this.class110_0.Dispose();
		}

		// Token: 0x060027FA RID: 10234
		// RVA: 0x0001EC7D File Offset: 0x0001CE7D
		internal override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
			if (this.bindings_0 != Bindings.None)
			{
				this.class911_1.Draw();
			}
		}

		// Token: 0x060027FB RID: 10235
		// RVA: 0x0001ECA4 File Offset: 0x0001CEA4
		public override void imethod_2()
		{
			base.imethod_2();
			this.class110_0.imethod_2();
		}

		// Token: 0x060027F7 RID: 10231
		// RVA: 0x0001EBF6 File Offset: 0x0001CDF6
		private void method_10(Bindings bindings_1, string string_0)
		{
			this.class533_2.Text = string_0;
			this.class533_0.method_14(200, Enum70.const_0);
			this.class533_1.method_14(200, Enum70.const_0);
			this.bindings_0 = bindings_1;
		}

		// Token: 0x060027F8 RID: 10232
		// RVA: 0x0001EC2D File Offset: 0x0001CE2D
		private bool method_11(Keys keys_0)
		{
			if (this.bindings_0 == Bindings.None)
			{
				return false;
			}
			Class795.Set(this.bindings_0, keys_0);
			this.bindings_0 = Bindings.None;
			this.method_9();
			return true;
		}

		// Token: 0x060027FD RID: 10237
		// RVA: 0x00017D4E File Offset: 0x00015F4E
		[CompilerGenerated]
		private void method_12(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			this.Close(false);
		}

		// Token: 0x060027FE RID: 10238
		// RVA: 0x0001ECD6 File Offset: 0x0001CED6
		[CompilerGenerated]
		private void method_13(object sender, EventArgs e)
		{
			Class795.Initialize(true);
			this.method_9();
			this.class110_0.method_23(0f, -0.99f);
		}

		// Token: 0x060027F6 RID: 10230
		// RVA: 0x000F9030 File Offset: 0x000F7230
		internal void method_9()
		{
			Class98.Class643 class = new Class98.Class643();
			class.class98_0 = this;
			this.class110_0.method_29(false);
			int num = 0;
			for (int i = 1; i < Class795.string_0.Length; i++)
			{
				EventHandler eventHandler = null;
				EventHandler eventHandler2 = null;
				Class98.Class644 class2 = new Class98.Class644();
				class2.class643_0 = class;
				string text = Class795.string_0[i];
				if (!text.StartsWith("__"))
				{
					bool flag;
					if (flag = (text[0] == '_'))
					{
						text = text.Substring(1);
					}
					class2.class533_0 = new Class533(text, (float)(flag ? 16 : 14), new Vector2(0f, (float)num), new Vector2(402f, 17f), flag ? 0.97f : 0.98f, true, Color.get_White(), false);
					this.class110_0.class911_0.Add(class2.class533_0);
					class2.class533_0.method_53(Color.get_Black());
					if (flag)
					{
						class2.class533_0.method_57(Color.get_YellowGreen());
						class2.class533_0.enum72_0 = Enum72.const_2;
					}
					else
					{
						Class98.Class645 class3 = new Class98.Class645();
						class3.class644_0 = class2;
						class3.class643_0 = class;
						class2.class533_0.int_7 = 2;
						class2.class533_0.method_55(Color.get_LightGray());
						class2.class533_0.bool_1 = true;
						Class531 arg_15F_0 = class2.class533_0;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler(class2.method_0);
						}
						arg_15F_0.method_35(eventHandler);
						Class531 arg_180_0 = class2.class533_0;
						if (eventHandler2 == null)
						{
							eventHandler2 = new EventHandler(class2.method_1);
						}
						arg_180_0.method_37(eventHandler2);
						class3.string_0 = text;
						class3.bindings_0 = (Bindings)i;
						class2.class533_0.method_2(new EventHandler(class3.method_0));
						class2.class533_0.bool_2 = true;
						class2.class533_0.enum72_0 = Enum72.const_1;
						Class533 class4 = new Class533(Class795.smethod_5((Bindings)i), 12f, new Vector2(300f, (float)(num + 1)), new Vector2(100f, 15f), 1f, true, Color.get_Gold(), false);
						class4.method_53(new Color(0, 0, 0, 160));
						class4.int_7 = 2;
						class4.method_55(Color.get_LightGray());
						class4.enum72_0 = Enum72.const_2;
						this.class110_0.class911_0.Add(class4);
					}
					num += 17;
				}
			}
			class.class533_0 = new Class533(Class41.GetString(OsuString.Options_ResetAllBindings), 14f, new Vector2(0f, (float)num), new Vector2(402f, 17f), 0.98f, true, Color.get_White(), false);
			class.class533_0.method_55(Color.get_LightGray());
			class.class533_0.method_53(Color.get_Black());
			class.class533_0.method_57(Color.get_White());
			class.class533_0.bool_1 = true;
			class.class533_0.method_35(new EventHandler(class.method_0));
			class.class533_0.method_37(new EventHandler(class.method_1));
			class.class533_0.method_2(new EventHandler(this.method_13));
			class.class533_0.enum72_0 = Enum72.const_2;
			num += 17;
			this.class110_0.class911_0.Add(class.class533_0);
			this.class110_0.method_14(new Vector2(510f, (float)num));
		}

		// Token: 0x060027F5 RID: 10229
		// RVA: 0x000F8DF0 File Offset: 0x000F6FF0
		internal override void vmethod_3()
		{
			this.class911_0.bool_14 = true;
			this.class110_0.method_6(true);
			Class591 class = new Class591(new EventHandler(this.method_12), false, true);
			this.class911_0.Add<Class531>(class.list_0);
			this.class533_2 = new Class533(string.Empty, 40f, new Vector2((float)(Class115.smethod_43() / 2), 120f), 1f, true, Color.get_Orange());
			this.class533_2.method_58(true);
			this.class533_2.bool_16 = true;
			this.class533_2.vector2_9 = new Vector2(1024f, 0f);
			this.class533_2.enum72_0 = Enum72.const_2;
			this.class533_2.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_2);
			this.class533_0 = new Class533(Class41.GetString(OsuString.OptionsBindKey_ChangeBinding), 40f, new Vector2((float)(Class115.smethod_43() / 2), 240f), 1f, true, Color.get_White());
			this.class533_0.method_58(true);
			this.class533_0.vector2_9 = new Vector2(1024f, 0f);
			this.class533_0.enum72_0 = Enum72.const_2;
			this.class533_0.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_0);
			this.class533_1 = new Class533(Class41.GetString(OsuString.OptionsBindKey_ConflictsWarning), 30f, new Vector2((float)(Class115.smethod_43() / 2), 360f), 1f, true, Color.get_LightYellow());
			this.class533_1.method_58(true);
			this.class533_1.vector2_9 = new Vector2(1024f, 0f);
			this.class533_1.enum72_0 = Enum72.const_2;
			this.class533_1.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_1);
			Class531 class2 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.91f, true, new Color(0, 0, 0, 220), null);
			class2.vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25));
			this.class911_1.Add(class2);
			this.method_9();
			base.vmethod_3();
		}

		// Token: 0x060027F9 RID: 10233
		// RVA: 0x0001EC53 File Offset: 0x0001CE53
		internal override bool vmethod_5(Keys keys_0)
		{
			if (this.bindings_0 != Bindings.None && keys_0 == 27)
			{
				this.bindings_0 = Bindings.None;
				return true;
			}
			return base.vmethod_5(keys_0) || this.method_11(keys_0);
		}
	}
}
