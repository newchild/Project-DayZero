using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns26;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x02000524 RID: 1316
	internal sealed class Class692
	{
		// Token: 0x02000525 RID: 1317
		[CompilerGenerated]
		private sealed class Class693
		{
			// Token: 0x04002360 RID: 9056
			public Mods mods_0;

			// Token: 0x06002AAD RID: 10925
			// RVA: 0x00020BAA File Offset: 0x0001EDAA
			public bool method_0(Class531 class531_0)
			{
				return class531_0.int_0 == (int)this.mods_0;
			}
		}

		// Token: 0x0400235F RID: 9055
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x0400235A RID: 9050
		private Class531 class531_0;

		// Token: 0x0400235D RID: 9053
		internal EventHandler eventHandler_0;

		// Token: 0x0400235E RID: 9054
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x04002359 RID: 9049
		internal List<Class531> list_0;

		// Token: 0x0400235C RID: 9052
		internal List<Mods> list_1;

		// Token: 0x0400235B RID: 9051
		public Mods mods_0;

		// Token: 0x06002AA5 RID: 10917
		// RVA: 0x00113CD0 File Offset: 0x00111ED0
		public Class692(Vector2 vector2_0, Mods[] mods_1)
		{
			EventHandler eventHandler = null;
			this.list_0 = new List<Class531>();
			base..ctor();
			this.list_1 = new List<Mods>(mods_1);
			int i = 0;
			while (i < mods_1.Length)
			{
				Mods mods = mods_1[i];
				string string_ = "selection-mod-" + mods.ToString().ToLower();
				Class531 class = new Class531(Class885.Load(string_, Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_0, 0.94f, true, Color.get_TransparentWhite(), null);
				class.int_0 = (int)mods;
				class.method_35(delegate(object sender, EventArgs e)
				{
					Class331.smethod_36(null, "click-short", 1f, false);
				});
				Class530 arg_AA_0 = class;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_2);
				}
				arg_AA_0.method_2(eventHandler);
				class.bool_1 = true;
				if (Class62.Mode != PlayModes.Osu)
				{
					try
					{
						class.string_0 = Class41.GetString((OsuString)Enum.Parse(typeof(OsuString), "ModSelection_Mod_" + mods.ToString() + "_" + Class62.Mode.ToString()));
						goto IL_15D;
					}
					catch
					{
						goto IL_15D;
					}
					goto Block_5;
				}
				goto IL_15D;
				IL_146:
				this.list_0.Add(class);
				i++;
				continue;
				Block_5:
				try
				{
					IL_10D:
					class.string_0 = Class41.GetString((OsuString)Enum.Parse(typeof(OsuString), "ModSelection_Mod_" + mods.ToString()));
				}
				catch
				{
				}
				goto IL_146;
				IL_15D:
				if (class.string_0 == null)
				{
					goto IL_10D;
				}
				goto IL_146;
			}
			this.class531_0 = new Class531(Class885.Load("lighting", Enum112.flag_1), Origins.Centre, vector2_0, 0.99f, true, Color.get_SkyBlue());
			this.class531_0.float_3 = 0f;
			this.class531_0.bool_7 = true;
			this.list_0.Add(this.class531_0);
		}

		// Token: 0x06002AA6 RID: 10918
		// RVA: 0x00113EB0 File Offset: 0x001120B0
		internal void method_0(bool bool_0, Mods mods_1)
		{
			Predicate<Class531> predicate = null;
			Class692.Class693 class = new Class692.Class693();
			class.mods_0 = mods_1;
			List<Class531> arg_32_0 = this.list_0;
			if (Class692.action_0 == null)
			{
				Class692.action_0 = new Action<Class531>(Class692.smethod_0);
			}
			arg_32_0.ForEach(Class692.action_0);
			if (!bool_0)
			{
				this.mods_0 = Mods.None;
				this.list_0[0].method_14(100, Enum70.const_0);
			}
			else
			{
				List<Class531> arg_6E_0 = this.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class531>(class.method_0);
				}
				Class531 class2 = arg_6E_0.Find(predicate);
				if (class2 == null || class.mods_0 == Mods.None)
				{
					class2 = this.list_0[0];
				}
				this.mods_0 = (Mods)class2.int_0;
				class2.method_14(100, Enum70.const_0);
				class2.method_26(1.2f, 400, Enum70.const_25);
				class2.method_27(0.1f, 400, Enum70.const_25);
			}
			this.class531_0.method_25((this.mods_0 == Mods.None) ? 0f : 0.2f, 100, Enum70.const_0);
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x06002AA7 RID: 10919
		// RVA: 0x00113FBC File Offset: 0x001121BC
		internal void method_1(bool bool_0)
		{
			Predicate<Mods> predicate = null;
			if (this.mods_0 == Mods.None)
			{
				Class331.smethod_36(null, "check-on", 1f, false);
				this.method_0(true, this.list_1[bool_0 ? (this.list_1.Count - 1) : 0]);
				return;
			}
			if (this.list_1[bool_0 ? 0 : (this.list_1.Count - 1)] == this.mods_0)
			{
				Class331.smethod_36(null, "check-off", 1f, false);
				this.method_0(false, Mods.None);
				return;
			}
			Class331.smethod_36(null, "check-on", 1f, false);
			bool arg_DB_1 = true;
			List<Mods> arg_D6_0 = this.list_1;
			List<Mods> arg_C9_0 = this.list_1;
			if (predicate == null)
			{
				predicate = new Predicate<Mods>(this.method_3);
			}
			this.method_0(arg_DB_1, arg_D6_0[arg_C9_0.FindIndex(predicate) + (bool_0 ? -1 : 1)]);
		}

		// Token: 0x06002AA9 RID: 10921
		// RVA: 0x00020B5F File Offset: 0x0001ED5F
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			this.method_1(Class800.smethod_3() == 1);
		}

		// Token: 0x06002AAB RID: 10923
		// RVA: 0x00020B9F File Offset: 0x0001ED9F
		[CompilerGenerated]
		private bool method_3(Mods mods_1)
		{
			return mods_1 == this.mods_0;
		}

		// Token: 0x06002AAA RID: 10922
		// RVA: 0x00020B6F File Offset: 0x0001ED6F
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_1)
		{
			class531_1.method_16(100, Enum70.const_0);
			class531_1.method_26(1f, 400, Enum70.const_25);
			class531_1.method_27(0f, 400, Enum70.const_25);
		}
	}
}
