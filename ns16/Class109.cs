using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns24;
using ns26;
using ns28;
using ns29;
using ns64;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns9;
using ns90;
using osu;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns16
{
	// Token: 0x020004D3 RID: 1235
	internal sealed class Class109 : Class54
	{
		// Token: 0x020004D4 RID: 1236
		[CompilerGenerated]
		private sealed class Class642
		{
			// Token: 0x04002108 RID: 8456
			public Class109 class109_0;

			// Token: 0x04002107 RID: 8455
			public Class95 class95_0;

			// Token: 0x060027DF RID: 10207
			// RVA: 0x0001EB26 File Offset: 0x0001CD26
			public void method_0(object sender, EventArgs e)
			{
				if (this.class95_0.class296_0 != null)
				{
					this.class109_0.bool_1 = false;
				}
			}
		}

		// Token: 0x04002105 RID: 8453
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04002106 RID: 8454
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04002103 RID: 8451
		private bool bool_1;

		// Token: 0x04002104 RID: 8452
		private static bool bool_2 = true;

		// Token: 0x04002101 RID: 8449
		private readonly Class531 class531_0;

		// Token: 0x04002102 RID: 8450
		private readonly Class531 class531_1;

		// Token: 0x04002100 RID: 8448
		internal static readonly Class911 class911_0 = new Class911(true);

		// Token: 0x040020FF RID: 8447
		private static List<Class296> list_0 = new List<Class296>();

		// Token: 0x040020FD RID: 8445
		private static readonly Stack<string> stack_0 = new Stack<string>();

		// Token: 0x040020FE RID: 8446
		private static readonly Stack<string> stack_1 = new Stack<string>();

		// Token: 0x060027C6 RID: 10182
		// RVA: 0x000F75CC File Offset: 0x000F57CC
		internal Class109(Class114 class114_1) : base(class114_1)
		{
			Class109.class911_0.method_15();
			Class109.class911_0.bool_14 = true;
			Class746 class = new Class746(TransformationType.Scale, 1f, 1.2f, 0, 100, Enum70.const_0);
			class.enum70_0 = Enum70.const_1;
			Class746 class2 = new Class746(TransformationType.Scale, 1.1f, 1.2f, 0, 100, Enum70.const_0);
			class2.enum70_0 = Enum70.const_1;
			Class534 class3 = new Class534(FontAwesome.step_backward, 14f, new Vector2(136f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Previous track";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_10));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.play, 14f, new Vector2(116f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Play";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_9));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.pause, 14f, new Vector2(96f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Pause";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_8));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.stop, 14f, new Vector2(76f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Stop the music!";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_6));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.step_forward, 14f, new Vector2(56f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Next track";
			class3.class746_0 = class2;
			class3.class746_1 = class;
			class3.method_35(new EventHandler(this.method_1));
			class3.method_2(new EventHandler(this.method_5));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.info, 14f, new Vector2(36f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "View song info";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_4));
			Class109.class911_0.Add(class3);
			class3 = new Class534(FontAwesome.bars, 14f, new Vector2(16f, 11f))
			{
				enum115_0 = Enum115.const_7,
				object_0 = "b"
			};
			class3.bool_1 = true;
			class3.string_0 = "Jump To window";
			class3.class746_0 = class2;
			class3.method_35(new EventHandler(this.method_1));
			class3.class746_1 = class;
			class3.method_2(new EventHandler(this.method_7));
			Class109.class911_0.Add(class3);
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(143f, 20f), 0.96f, true, new Color(20, 20, 20, 128), "b");
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2(134f, 3f);
			this.class531_0.class746_1 = new Class746(new Color(20, 20, 20, 128), new Color(60, 60, 60, 128), 0, 100);
			this.class531_0.bool_1 = true;
			this.class531_0.string_0 = "Click to seek to a specific point in the song.";
			this.class531_0.method_2(new EventHandler(this.method_3));
			this.class531_0.bool_7 = true;
			Class109.class911_0.Add(this.class531_0);
			this.class531_1 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(143f, 20f), 0.97f, true, new Color(255, 255, 255, 128), "b");
			this.class531_1.float_2 = 1.6f;
			this.class531_1.vector2_2 = new Vector2(0f, 3f);
			this.class531_1.bool_7 = true;
			Class109.class911_0.Add(this.class531_1);
			Class570.smethod_0(new Class570.Delegate44(this.method_2));
		}

		// Token: 0x060027CA RID: 10186
		// RVA: 0x0001EA5C File Offset: 0x0001CC5C
		internal static void Draw()
		{
			if (Class115.bool_16)
			{
				return;
			}
			Class109.class911_0.Draw();
		}

		// Token: 0x060027CB RID: 10187
		// RVA: 0x000F7B94 File Offset: 0x000F5D94
		public override void imethod_2()
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			if (!this.bool_1 && Class109.smethod_0())
			{
				Class109.smethod_2();
			}
			if (Class331.smethod_31() > 0)
			{
				this.class531_1.vector2_2 = new Vector2(Math.Max(0f, (float)Class331.int_7 / (float)Class331.smethod_31()) * 134f, 3f);
			}
			base.imethod_2();
		}

		// Token: 0x060027C7 RID: 10183
		// RVA: 0x000BCA44 File Offset: 0x000BAC44
		private void method_1(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x060027D4 RID: 10196
		// RVA: 0x000F7FB4 File Offset: 0x000F61B4
		private void method_10(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class723.smethod_1("<< Prev", 1000);
			if (Class109.stack_1.Count > 0 && Class466.Current != null)
			{
				Class109.stack_0.Push(Class466.Current.string_3);
				Class466.smethod_21(Class466.smethod_25(Class109.stack_1.Pop()));
			}
			Class109.smethod_3(false, false);
			this.bool_1 = false;
		}

		// Token: 0x060027CC RID: 10188
		// RVA: 0x000F7C00 File Offset: 0x000F5E00
		internal bool method_2(object object_0, Keys keys_0)
		{
			if (Class109.smethod_0() && !Class570.bool_2 && !Class570.bool_0 && !Class570.bool_1)
			{
				if (Class115.osuModes_1 == OsuModes.Menu)
				{
					if (keys_0 <= 67)
					{
						switch (keys_0)
						{
						case 37:
							goto IL_9C;
						case 38:
							goto IL_B9;
						case 39:
							break;
						default:
							if (keys_0 != 67)
							{
								goto IL_B9;
							}
							this.method_8(null, null);
							return true;
						}
					}
					else
					{
						if (keys_0 == 74)
						{
							this.method_7(null, null);
							return true;
						}
						if (keys_0 == 82)
						{
							Class109.smethod_3(true, false);
							return true;
						}
						switch (keys_0)
						{
						case 86:
							break;
						case 87:
						case 89:
							goto IL_B9;
						case 88:
							this.method_9(null, null);
							return true;
						case 90:
							goto IL_9C;
						default:
							goto IL_B9;
						}
					}
					this.method_5(null, null);
					return true;
					IL_9C:
					this.method_10(null, null);
					return true;
				}
				IL_B9:
				switch (keys_0)
				{
				case 112:
					this.method_10(null, null);
					return true;
				case 113:
					this.method_9(null, null);
					return true;
				case 114:
					this.method_8(null, null);
					return true;
				case 115:
					if (!Class570.bool_1)
					{
						this.method_6(null, null);
						return true;
					}
					break;
				case 116:
					this.method_5(null, null);
					return true;
				case 117:
					this.method_7(null, null);
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060027CD RID: 10189
		// RVA: 0x000F7D34 File Offset: 0x000F5F34
		private void method_3(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class109.class911_0.method_19();
			Class331.smethod_70((int)(Math.Min(1f, (Class802.vector2_0.X - this.class531_0.vector2_3.X) / Class115.float_4 / 134f) * (float)Class331.smethod_31()), false, false);
		}

		// Token: 0x060027CE RID: 10190
		// RVA: 0x0001EA71 File Offset: 0x0001CC71
		private void method_4(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class109.smethod_7(true);
			Class723.smethod_1("Song Info will be " + (Class341.class606_49 ? "permanently displayed." : "temporarily displayed."), 1000);
		}

		// Token: 0x060027CF RID: 10191
		// RVA: 0x000F7D94 File Offset: 0x000F5F94
		private void method_5(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class723.smethod_1(">> Next", 1000);
			if (Class109.stack_0.Count > 0)
			{
				Class109.stack_1.Push(Class466.Current.string_3);
				Class466.smethod_21(Class466.smethod_25(Class109.stack_0.Pop()));
				Class109.smethod_3(false, false);
			}
			else
			{
				Class109.smethod_3(true, false);
			}
			this.bool_1 = false;
		}

		// Token: 0x060027D0 RID: 10192
		// RVA: 0x000F7E20 File Offset: 0x000F6020
		private void method_6(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class723.smethod_1("Stop Playing", 1000);
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class331.smethod_90();
			this.bool_1 = true;
		}

		// Token: 0x060027D1 RID: 10193
		// RVA: 0x000F7E6C File Offset: 0x000F606C
		private void method_7(object sender, EventArgs e)
		{
			Class109.Class642 class = new Class109.Class642();
			class.class109_0 = this;
			if (!Class109.smethod_0())
			{
				return;
			}
			if (Class115.class89_0 is Class95)
			{
				Class115.class89_0.Close(false);
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			if (Class115.class80_0.method_23())
			{
				Class115.class80_0.method_24(false);
			}
			class.class95_0 = new Class95();
			class.class95_0.method_2(new EventHandler(class.method_0));
			Class115.smethod_37(class.class95_0);
		}

		// Token: 0x060027D2 RID: 10194
		// RVA: 0x000F7F04 File Offset: 0x000F6104
		private void method_8(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class723.smethod_1(Class331.smethod_79() ? "Unpause" : "Pause", 1000);
			this.bool_1 = Class331.smethod_88();
		}

		// Token: 0x060027D3 RID: 10195
		// RVA: 0x000F7F5C File Offset: 0x000F615C
		private void method_9(object sender, EventArgs e)
		{
			if (!Class109.smethod_0())
			{
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class723.smethod_1("Play", 1000);
			if (Class331.smethod_79())
			{
				Class331.smethod_88();
			}
			else
			{
				Class331.smethod_87();
			}
			this.bool_1 = false;
		}

		// Token: 0x060027C8 RID: 10184
		// RVA: 0x0001EA49 File Offset: 0x0001CC49
		internal static bool smethod_0()
		{
			return Class109.class911_0.float_0 > 0f;
		}

		// Token: 0x060027C9 RID: 10185
		// RVA: 0x000F7B5C File Offset: 0x000F5D5C
		internal static void smethod_1(bool bool_3)
		{
			int num = bool_3 ? 1 : 0;
			if ((float)num == Class109.class911_0.float_0)
			{
				return;
			}
			Class109.class911_0.float_0 = (float)num;
			Class109.smethod_7(false);
		}

		// Token: 0x060027D5 RID: 10197
		// RVA: 0x000F803C File Offset: 0x000F623C
		internal static void smethod_2()
		{
			if (Class331.enum100_0 == Enum100.const_0 && (Class331.class335_0 == null || Class331.class335_0.Position > Class331.class335_0.double_0 * 0.95) && Class331.bool_1 && Class466.list_3.Count > 0 && Class115.enum113_0 == Enum113.const_2)
			{
				Class109.smethod_3(true, false);
			}
		}

		// Token: 0x060027D6 RID: 10198
		// RVA: 0x000F809C File Offset: 0x000F629C
		internal static void smethod_3(bool bool_3, bool bool_4)
		{
			if (Class466.list_3.Count <= 0)
			{
				return;
			}
			if (Class466.Current == null || bool_3)
			{
				List<Class296> list = (Class109.list_0.Count == 0) ? Class466.list_3 : Class109.list_0;
				int int_ = (Class109.list_0.Count == 0) ? (list.Count - 1) : list.Count;
				Class296 class = list[Class562.smethod_1(0, int_)];
				int num = 0;
				while (num++ < 100 && ((Class466.Current != null && class.string_12 == Class466.Current.string_12) || !class.method_0() || class.method_60() == null))
				{
					class = list[Class562.smethod_1(0, int_)];
				}
				if (Class466.Current != null)
				{
					Class109.stack_1.Push(Class466.Current.string_3);
				}
				Class466.smethod_21(class);
			}
			try
			{
				Class331.smethod_86(Class466.Current, true, bool_4 || (!Class341.class606_84 && (Class331.class335_0 == null || Class331.smethod_32() == null || string.IsNullOrEmpty(Class331.smethod_32().string_4))), true);
			}
			catch (Exception11)
			{
			}
			Class109.smethod_7(false);
		}

		// Token: 0x060027D7 RID: 10199
		// RVA: 0x0001EAAD File Offset: 0x0001CCAD
		internal static void smethod_4(Class296 class296_0)
		{
			Class109.stack_1.Push(class296_0.string_3);
		}

		// Token: 0x060027D8 RID: 10200
		// RVA: 0x0001EABF File Offset: 0x0001CCBF
		internal static void smethod_5(Class296 class296_0)
		{
			Class109.list_0.Add(class296_0);
		}

		// Token: 0x060027D9 RID: 10201
		// RVA: 0x0001EACC File Offset: 0x0001CCCC
		internal static void smethod_6()
		{
			Class109.list_0.Clear();
		}

		// Token: 0x060027DA RID: 10202
		// RVA: 0x000F81D0 File Offset: 0x000F63D0
		private static void smethod_7(bool bool_3)
		{
			if (Class466.Current == null)
			{
				return;
			}
			if (!Class109.bool_2)
			{
				List<Class530> arg_3B_0 = Class109.class911_0.method_11("b");
				if (Class109.action_0 == null)
				{
					Class109.action_0 = new Action<Class530>(Class109.smethod_8);
				}
				arg_3B_0.ForEach(Class109.action_0);
				List<Class530> arg_6C_0 = Class109.class911_0.method_11("np");
				if (Class109.action_1 == null)
				{
					Class109.action_1 = new Action<Class530>(Class109.smethod_9);
				}
				arg_6C_0.ForEach(Class109.action_1);
				return;
			}
			if (bool_3)
			{
				Class341.class606_49.Value = !Class341.class606_49;
			}
			Class109.class911_0.method_12("np");
			string text = Class466.Current.method_75();
			if (text == null)
			{
				return;
			}
			if (text.Length > 54)
			{
				text = text.Substring(0, 54) + "...";
			}
			Class533 class = new Class533(text, 14f, Vector2.get_Zero(), Vector2.get_Zero(), 0.999f, Class341.class606_49, Color.get_White(), false);
			class.enum115_0 = Enum115.const_7;
			class.object_0 = "np";
			float x = class.vmethod_11().X;
			Class746 class2 = new Class746(new Vector2(-80f + x, 0f), new Vector2(10f + x, 0f), Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
			class2.enum70_0 = Enum70.const_1;
			Class746 class3 = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
			class2.enum70_0 = Enum70.const_1;
			Class746 class4 = class2.method_1();
			class4.int_0 = Class115.int_1 + 6000;
			class4.int_1 = Class115.int_1 + 8000;
			Class746 class5 = class3.method_1();
			class5.int_0 = Class115.int_1 + 6000;
			class5.int_1 = Class115.int_1 + 8000;
			class.class26_0.Add(class2);
			class.class26_0.Add(class3);
			if (!Class341.class606_49)
			{
				class.class26_0.Add(class4);
				class.class26_0.Add(class5);
			}
			class.vector2_5 = new Vector2(0f, -2f);
			Class109.class911_0.Add(class);
			Class531 class6 = new Class531(Class885.Load("menu-np", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(620f, 0f), 0.998f, Class341.class606_49, Color.get_White(), "np");
			class6.vector2_5 = new Vector2(100f, 0f);
			class6.class26_0.Add(class2);
			class6.class26_0.Add(class3);
			if (!Class341.class606_49)
			{
				class6.class26_0.Add(class4);
				class6.class26_0.Add(class5);
			}
			Class109.class911_0.Add(class6);
			Vector2 vector;
			vector..ctor(0f, 20f);
			using (List<Class530>.Enumerator enumerator = Class109.class911_0.method_11("b").GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class7 = (Class531)enumerator.Current;
					class7.class26_0.Clear();
					class2 = new Class746(class7.vector2_1, class7.vector2_0 + vector, Class115.int_1, Class115.int_1 + 400, Enum70.const_0);
					class3 = class2.method_1();
					class3.vector2_1 = class7.vector2_0;
					class3.int_0 = Class115.int_1 + 7600;
					class3.int_1 = Class115.int_1 + 8000;
					class7.class26_0.Add(class2);
					if (!Class341.class606_49)
					{
						class7.class26_0.Add(class3);
					}
				}
			}
		}

		// Token: 0x060027DB RID: 10203
		// RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		[CompilerGenerated]
		private static void smethod_8(Class530 class530_0)
		{
			class530_0.method_19(class530_0.vector2_0, 100, Enum70.const_1);
		}

		// Token: 0x060027DC RID: 10204
		// RVA: 0x0001EAEA File Offset: 0x0001CCEA
		[CompilerGenerated]
		private static void smethod_9(Class530 class530_0)
		{
			class530_0.method_16(60, Enum70.const_0);
		}
	}
}
