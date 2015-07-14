using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns18;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns6;
using ns64;
using ns69;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns89;
using ns9;
using ns90;
using osu;
using osu.GameModes.Edit;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns82
{
	// Token: 0x02000604 RID: 1540
	internal static class Class802
	{
		// Token: 0x02000605 RID: 1541
		[CompilerGenerated]
		private sealed class Class803
		{
			// Token: 0x04002BAA RID: 11178
			public string string_0;

			// Token: 0x06003005 RID: 12293
			// RVA: 0x00023A28 File Offset: 0x00021C28
			public void method_0()
			{
				Class802.textInputControl_0.TextBox.Text = this.string_0;
				Class802.textInputControl_0.TextBox.Select(Math.Max(0, this.string_0.Length), 0);
			}
		}

		// Token: 0x02000606 RID: 1542
		[CompilerGenerated]
		private sealed class Class804
		{
			// Token: 0x04002BAB RID: 11179
			public Type type_0;

			// Token: 0x06003007 RID: 12295
			// RVA: 0x00023A60 File Offset: 0x00021C60
			public bool method_0(Class563 class563_0)
			{
				return class563_0.GetType() == this.type_0;
			}
		}

		// Token: 0x02000607 RID: 1543
		[CompilerGenerated]
		private sealed class Class805
		{
			// Token: 0x04002BAD RID: 11181
			public Delegate46 delegate46_0;

			// Token: 0x04002BAC RID: 11180
			public Enum96 enum96_0;

			// Token: 0x04002BAE RID: 11182
			public Enum98 enum98_0;

			// Token: 0x06003009 RID: 12297
			// RVA: 0x00023A70 File Offset: 0x00021C70
			public bool method_0(Class572 class572_0)
			{
				return class572_0.enum98_0 == this.enum98_0;
			}

			// Token: 0x0600300A RID: 12298
			// RVA: 0x00023A80 File Offset: 0x00021C80
			public void method_1()
			{
				Class802.list_5.Find(new Predicate<Class572>(this.method_2)).method_1(this.enum96_0, this.delegate46_0);
			}

			// Token: 0x0600300B RID: 12299
			// RVA: 0x00023A70 File Offset: 0x00021C70
			public bool method_2(Class572 class572_0)
			{
				return class572_0.enum98_0 == this.enum98_0;
			}
		}

		// Token: 0x02000608 RID: 1544
		[CompilerGenerated]
		private sealed class Class806
		{
			// Token: 0x04002BAF RID: 11183
			public Enum98 enum98_0;

			// Token: 0x0600300D RID: 12301
			// RVA: 0x00023AA9 File Offset: 0x00021CA9
			public bool method_0(Class572 class572_0)
			{
				return class572_0.enum98_0 == this.enum98_0;
			}
		}

		// Token: 0x04002B60 RID: 11104
		internal static bool bool_0;

		// Token: 0x04002B65 RID: 11109
		private static bool bool_1;

		// Token: 0x04002B73 RID: 11123
		private static bool bool_10;

		// Token: 0x04002B74 RID: 11124
		internal static bool bool_11;

		// Token: 0x04002B7B RID: 11131
		internal static bool bool_12 = true;

		// Token: 0x04002B7C RID: 11132
		internal static bool bool_13 = true;

		// Token: 0x04002B7F RID: 11135
		private static bool bool_14;

		// Token: 0x04002B81 RID: 11137
		internal static bool bool_15;

		// Token: 0x04002B83 RID: 11139
		internal static bool bool_16;

		// Token: 0x04002B85 RID: 11141
		internal static bool bool_17;

		// Token: 0x04002B87 RID: 11143
		internal static bool bool_18;

		// Token: 0x04002B88 RID: 11144
		internal static bool bool_19;

		// Token: 0x04002B66 RID: 11110
		internal static bool bool_2;

		// Token: 0x04002B89 RID: 11145
		internal static bool bool_20;

		// Token: 0x04002B8A RID: 11146
		internal static bool bool_21;

		// Token: 0x04002B8C RID: 11148
		internal static bool bool_22;

		// Token: 0x04002B8D RID: 11149
		internal static bool bool_23;

		// Token: 0x04002B92 RID: 11154
		private static bool bool_24;

		// Token: 0x04002B93 RID: 11155
		internal static bool bool_25;

		// Token: 0x04002B94 RID: 11156
		internal static bool bool_26 = false;

		// Token: 0x04002B95 RID: 11157
		private static bool bool_27 = false;

		// Token: 0x04002B9D RID: 11165
		public static bool bool_28;

		// Token: 0x04002BA0 RID: 11168
		public static bool bool_29;

		// Token: 0x04002B6B RID: 11115
		internal static bool bool_3;

		// Token: 0x04002BA2 RID: 11170
		private static bool bool_30;

		// Token: 0x04002B6C RID: 11116
		internal static bool bool_4;

		// Token: 0x04002B6D RID: 11117
		internal static bool bool_5;

		// Token: 0x04002B6E RID: 11118
		internal static bool bool_6;

		// Token: 0x04002B70 RID: 11120
		internal static bool bool_7;

		// Token: 0x04002B71 RID: 11121
		internal static bool bool_8;

		// Token: 0x04002B72 RID: 11122
		private static bool bool_9 = true;

		// Token: 0x04002B6A RID: 11114
		internal static ButtonState buttonState_0;

		// Token: 0x04002B6F RID: 11119
		internal static ButtonState buttonState_1;

		// Token: 0x04002B75 RID: 11125
		private static ButtonState buttonState_2;

		// Token: 0x04002B76 RID: 11126
		private static ButtonState buttonState_3;

		// Token: 0x04002B77 RID: 11127
		private static ButtonState buttonState_4;

		// Token: 0x04002B86 RID: 11142
		internal static ButtonState buttonState_5;

		// Token: 0x04002B8B RID: 11147
		internal static ButtonState buttonState_6;

		// Token: 0x04002BA1 RID: 11169
		internal static Class14 class14_0;

		// Token: 0x04002B82 RID: 11138
		internal static Class512 class512_0;

		// Token: 0x04002B8E RID: 11150
		internal static Class531 class531_0;

		// Token: 0x04002B98 RID: 11160
		internal static Class531 class531_1;

		// Token: 0x04002B90 RID: 11152
		internal static Class755 class755_0;

		// Token: 0x04002B9B RID: 11163
		private static Class797 class797_0 = new Class797();

		// Token: 0x04002B8F RID: 11151
		internal static Class799 class799_0;

		// Token: 0x04002B79 RID: 11129
		private static double double_0;

		// Token: 0x04002B7A RID: 11130
		private static double double_1;

		// Token: 0x04002B80 RID: 11136
		internal static Enum99 enum99_0;

		// Token: 0x04002B96 RID: 11158
		internal static Interface15 interface15_0 = null;

		// Token: 0x04002B63 RID: 11107
		internal static int int_0;

		// Token: 0x04002B7D RID: 11133
		internal static int int_1;

		// Token: 0x04002B84 RID: 11140
		internal static int int_2;

		// Token: 0x04002B99 RID: 11161
		private static int int_3 = 0;

		// Token: 0x04002B9E RID: 11166
		public static int int_4;

		// Token: 0x04002B67 RID: 11111
		internal static KeyboardState keyboardState_0;

		// Token: 0x04002B68 RID: 11112
		private static KeyboardState keyboardState_1;

		// Token: 0x04002B5E RID: 11102
		private static readonly List<Class563> list_0 = new List<Class563>();

		// Token: 0x04002B78 RID: 11128
		internal static List<Keys> list_1 = new List<Keys>();

		// Token: 0x04002B9A RID: 11162
		private static List<Class531> list_2 = new List<Class531>();

		// Token: 0x04002B9C RID: 11164
		internal static List<TextInputControl> list_3 = new List<TextInputControl>();

		// Token: 0x04002B9F RID: 11167
		private static List<Keys> list_4 = new List<Keys>();

		// Token: 0x04002BA5 RID: 11173
		private static List<Class572> list_5 = new List<Class572>();

		// Token: 0x04002B69 RID: 11113
		internal static pButtonState pButtonState_0;

		// Token: 0x04002B61 RID: 11105
		internal static Point point_0;

		// Token: 0x04002BA7 RID: 11175
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04002BA8 RID: 11176
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04002B5F RID: 11103
		private static readonly Queue<VoidDelegate> queue_0 = new Queue<VoidDelegate>();

		// Token: 0x04002BA6 RID: 11174
		private static Queue<VoidDelegate> queue_1 = new Queue<VoidDelegate>();

		// Token: 0x04002B5D RID: 11101
		internal static readonly Rectangle rectangle_0 = Cursor.Clip;

		// Token: 0x04002B64 RID: 11108
		internal static string string_0;

		// Token: 0x04002B91 RID: 11153
		internal static TextInputControl textInputControl_0;

		// Token: 0x04002B62 RID: 11106
		internal static Vector2 vector2_0;

		// Token: 0x04002B7E RID: 11134
		internal static Vector2 vector2_1;

		// Token: 0x04002B97 RID: 11159
		private static Vector2 vector2_2 = -Vector2.get_One();

		// Token: 0x04002BA3 RID: 11171
		internal static Vector2 vector2_3;

		// Token: 0x04002BA4 RID: 11172
		internal static Vector2 vector2_4;

		// Token: 0x04002BA9 RID: 11177
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06002FE2 RID: 12258
		// RVA: 0x00134878 File Offset: 0x00132A78
		internal static void Dispose()
		{
			foreach (Class563 current in Class802.list_0)
			{
				current.Dispose();
			}
			Class115.smethod_19(new VoidDelegate(Class802.smethod_8));
		}

		// Token: 0x06002FE1 RID: 12257
		// RVA: 0x001347B0 File Offset: 0x001329B0
		internal static void Initialize()
		{
			Class115.smethod_18(new VoidDelegate(Class802.smethod_8));
			Class802.smethod_32();
			Class800.Initialize();
			Class802.smethod_11();
			Class808.Initialize();
			Class802.smethod_23(new Class566());
			if (Class341.class606_24)
			{
				Class802.smethod_23(new Class568());
			}
			if (!Class341.class606_60)
			{
				Class802.smethod_23(new Class571());
			}
			if (Class341.class606_33)
			{
				Class802.smethod_23(new Class569());
			}
			Class802.smethod_23(new Class567());
			Class802.smethod_23(new Class564());
			Class115.class115_0.method_5(new EventHandler(Class802.smethod_9));
			Class115.class115_0.method_7(new EventHandler(Class802.smethod_9));
		}

		// Token: 0x06002FD9 RID: 12249
		// RVA: 0x00023873 File Offset: 0x00021A73
		internal static bool smethod_0()
		{
			return Class802.bool_14;
		}

		// Token: 0x06002FDA RID: 12250
		// RVA: 0x0002387A File Offset: 0x00021A7A
		internal static void smethod_1(bool bool_31)
		{
			Class802.bool_14 = bool_31;
			if (!Class802.bool_14)
			{
				Class802.class512_0 = null;
				Class802.class14_0 = null;
			}
		}

		// Token: 0x06002FE5 RID: 12261
		// RVA: 0x00134930 File Offset: 0x00132B30
		internal static void smethod_10()
		{
			if (Class115.bool_16 || Class905.smethod_16())
			{
				return;
			}
			bool flag = false;
			Class62 class62_ = Class62.class62_0;
			if (class62_ != null && class62_.class427_0 != null)
			{
				flag = class62_.class427_0.vmethod_51();
			}
			bool flag2 = Class62.bool_12 && flag && !Class802.smethod_0();
			Class567 class = Class802.interface15_0 as Class567;
			bool flag3 = class != null && !class.method_1() && Class800.smethod_23(Class800.smethod_15(), 1);
			if (Class802.bool_9 && Class114.bool_0 && (flag2 || Class115.class125_0.method_0() || flag3))
			{
				if (Cursor.Clip != Class115.rectangle_2)
				{
					Cursor.Clip = Class115.rectangle_2;
					if (flag2)
					{
						Class115.form_0.TopMost = true;
					}
					Class802.bool_27 = true;
				}
				Class802.bool_26 = true;
				return;
			}
			if ((Cursor.Clip != Class802.rectangle_0 && Class802.bool_27) || Class115.form_0.TopMost)
			{
				Cursor.Clip = Class802.rectangle_0;
				Class115.form_0.TopMost = false;
				Class802.bool_27 = false;
			}
			Class802.bool_26 = false;
		}

		// Token: 0x06002FE6 RID: 12262
		// RVA: 0x00134A4C File Offset: 0x00132C4C
		private static void smethod_11()
		{
			Class802.class755_0 = new Class755(12, new Vector2(10.5f, 465f), 640f, true, 0.98f);
			Class802.class755_0.class533_0.bool_16 = false;
			Class802.textInputControl_0 = Class802.class755_0.textInputControl_0;
			Class802.class799_0 = Class802.textInputControl_0.TextBox;
			Class802.class755_0.method_25(false);
			Class802.smethod_25(Class802.textInputControl_0);
		}

		// Token: 0x06002FE7 RID: 12263
		// RVA: 0x00134AC4 File Offset: 0x00132CC4
		internal static void smethod_12()
		{
			bool flag = Class802.bool_9;
			Class802.bool_9 = (!Class802.smethod_0() && (!Class62.bool_16 || Class62.bool_11 || (Class872.bool_1 && (Class62.class62_0 == null || Class62.class62_0.bool_25))));
			Class802.smethod_10();
			Class800.smethod_26();
			Class802.interface15_0 = Class800.smethod_27(Class802.list_0);
			Class800.smethod_28();
			if (Class802.int_0 > 0)
			{
				Class802.int_0 = (int)Math.Max(0.0, (double)Class802.int_0 - Class115.double_9);
			}
			int num = 0;
			Class802.vector2_3 = ((!Class802.bool_9 || !flag) ? Vector2.get_Zero() : (Class802.vector2_4 - Class802.vector2_0));
			Class802.vector2_4 = Class802.vector2_0;
			bool flag2 = false;
			do
			{
				Class331.smethod_53();
				Class802.bool_25 = Class115.bool_13;
				if (Class802.bool_9)
				{
					if (!Class115.bool_11)
					{
						Class62.smethod_5();
						Class802.smethod_18();
						if (Class802.vector2_0 != Class800.smethod_19())
						{
							if (Class800.smethod_0())
							{
								Class802.int_4 = Class115.int_1;
							}
							Class802.vector2_0 = Class800.smethod_19();
						}
						Class802.point_0 = Class800.smethod_15();
						Class802.vector2_1 = Class115.smethod_58(Class802.vector2_0);
					}
				}
				else
				{
					flag2 = Class802.smethod_13();
					if (!Class802.smethod_0() && Class62.bool_16)
					{
						Class62.smethod_5();
						Class802.smethod_18();
					}
				}
				if (!Class115.bool_12)
				{
					Class802.class531_0.vector2_1 = (Class802.bool_12 ? Class802.vector2_0 : Class800.smethod_19());
				}
				if (Class802.bool_13 && (Class114.bool_0 || Class802.smethod_0()))
				{
					Class800.smethod_44();
					try
					{
						Class802.keyboardState_0 = Keyboard.GetState();
						goto IL_7A8;
					}
					catch (InvalidOperationException)
					{
						goto IL_7A8;
					}
					goto IL_185;
					IL_1A1:
					if (Class341.class606_70)
					{
						Class808.smethod_3(Class802.list_4);
					}
					if (Class341.class606_33)
					{
						Class802.list_4.AddRange(Class569.list_0);
					}
					if (!Class802.smethod_0())
					{
						Class802.smethod_19();
					}
					Class802.smethod_14(Class802.list_4);
					Class802.double_0 += Class115.double_9;
					if (Class802.double_0 >= 100.0)
					{
						Class802.double_0 -= 100.0;
						if (Class802.buttonState_0 == 1 && Class800.bool_3 && Class115.enum113_0 != Enum113.const_0)
						{
							Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_34));
						}
					}
					Class802.bool_8 = (Class802.buttonState_0 == 1 && (Class802.bool_11 ? (Class802.bool_4 || Class802.bool_6) : (Class802.buttonState_1 != Class802.buttonState_0)));
					Class802.bool_23 = (Class802.buttonState_5 == 1 && (Class802.bool_11 ? (Class802.bool_19 || Class802.bool_21) : (Class802.buttonState_6 != Class802.buttonState_5)));
					Class802.bool_10 = (Class800.smethod_5() == 1 && Class802.buttonState_3 != Class800.smethod_5());
					bool arg_309_0;
					if (Class114.bool_0)
					{
						if (Class800.smethod_1() != 1 || Class802.buttonState_2 == 1)
						{
							if (Class800.smethod_3() == 1)
							{
								if (Class802.buttonState_4 != 1)
								{
									goto IL_2FE;
								}
							}
							arg_309_0 = Class802.bool_10;
							goto IL_309;
						}
						IL_2FE:
						arg_309_0 = true;
					}
					else
					{
						arg_309_0 = false;
					}
					IL_309:
					bool flag3 = arg_309_0;
					bool flag4 = (Class800.smethod_1() == null && Class802.buttonState_2 != null) || (Class800.smethod_3() == null && Class802.buttonState_4 != null) || (Class800.smethod_5() == null && Class802.buttonState_3 != 0);
					Class800.bool_4 = (flag3 || flag4);
					Class800.bool_0 = false;
					if (Class802.buttonState_1 != Class802.buttonState_0 || Class802.buttonState_6 != Class802.buttonState_5)
					{
						Class800.mouseButtons_1 = Class800.mouseButtons_0;
						Class800.mouseButtons_0 = Class800.mouseButtons_2;
						Class800.mouseButtons_2 = MouseButtons.None;
						if (Class802.buttonState_0 == 1)
						{
							Class800.mouseButtons_2 |= MouseButtons.Left;
							Class800.mouseButtons_3 = MouseButtons.Left;
						}
						if (Class802.buttonState_5 == 1)
						{
							Class800.mouseButtons_2 |= MouseButtons.Right;
							Class800.mouseButtons_3 = MouseButtons.Right;
						}
					}
					bool flag5 = false;
					if (flag3)
					{
						Class800.vector2_0 = Class800.smethod_19();
						Class800.int_3 = Class115.int_1;
						Class802.int_4 = Class115.int_1;
						if (Class115.enum113_0 != Enum113.const_0)
						{
							if (Class802.int_0 > 0)
							{
								Class800.bool_0 = true;
								Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_36));
								Class802.int_0 = 0;
							}
							else
							{
								Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_33));
								flag5 = true;
								Class802.double_0 = 0.0;
								Class802.int_0 = 250;
							}
						}
					}
					Class800.bool_1 = false;
					if (Class802.bool_8 || Class802.bool_23)
					{
						if (Class802.bool_28 && (!Class802.smethod_0() || Class802.bool_12))
						{
							Class802.bool_30 = true;
							List<Class746> arg_4B0_0 = Class802.class531_0.class26_0;
							if (Class802.predicate_0 == null)
							{
								Class802.predicate_0 = new Predicate<Class746>(Class802.smethod_37);
							}
							arg_4B0_0.RemoveAll(Class802.predicate_0);
							Class746 class = new Class746(TransformationType.Scale, 1f, 1.3f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0);
							class.enum70_0 = Enum70.const_1;
							Class802.class531_0.class26_0.Add(class);
						}
						Class800.bool_2 = true;
						Class800.int_3 = Class115.int_1;
						Class800.bool_1 = true;
						if (Class115.enum113_0 != Enum113.const_0)
						{
							Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_32));
							if (!Class802.smethod_0() && !flag5)
							{
								Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_33));
							}
						}
					}
					bool flag6 = Class802.buttonState_0 == null && Class802.buttonState_5 == null && Class800.bool_2;
					if (flag4 || flag6)
					{
						if (Class911.class531_0 != null)
						{
							if (Class911.class531_0.bool_2 && Vector2.Distance(Class800.vector2_0, Class800.smethod_19()) * Class115.float_6 < 10f)
							{
								Class911.class531_0.method_0(true);
							}
							Class911.class531_0 = null;
						}
						Class802.bool_29 = false;
						if (!Class802.smethod_0() || flag4)
						{
							Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_35));
						}
					}
					if (flag6)
					{
						Class802.bool_30 = false;
						if (Class802.bool_28)
						{
							List<Class746> arg_606_0 = Class802.class531_0.class26_0;
							if (Class802.predicate_1 == null)
							{
								Class802.predicate_1 = new Predicate<Class746>(Class802.smethod_38);
							}
							arg_606_0.RemoveAll(Class802.predicate_1);
							Class746 class2 = new Class746(TransformationType.Scale, Class802.class531_0.float_2, 1f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0);
							class2.enum70_0 = Enum70.const_1;
							Class802.class531_0.class26_0.Add(class2);
						}
						Class800.bool_2 = false;
					}
					if (Class800.smethod_1() == 1 && Class115.enum113_0 != Enum113.const_0)
					{
						Class800.bool_3 = true;
						if (Class800.smethod_19() != Class800.vector2_0)
						{
							Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_31));
							goto IL_6D1;
						}
						goto IL_6D1;
					}
					else
					{
						Class800.bool_3 = false;
						if (Class802.bool_2)
						{
							Class802.queue_0.Enqueue(new VoidDelegate(Class800.smethod_37));
							goto IL_6D1;
						}
						goto IL_6D1;
					}
					IL_185:
					Keys[] pressedKeys = Class802.keyboardState_0.GetPressedKeys();
					if (pressedKeys.Length > 0)
					{
						Class802.list_4.AddRange(pressedKeys);
						goto IL_1A1;
					}
					goto IL_1A1;
					IL_7A8:
					Class802.list_4.Clear();
					if (Class114.bool_0)
					{
						goto IL_185;
					}
					goto IL_1A1;
				}
				else
				{
					Class802.buttonState_0 = 0;
					Class802.buttonState_5 = 0;
					Class570.bool_0 = false;
					Class570.bool_1 = false;
					Class570.bool_2 = false;
				}
				IL_6D1:
				Class802.bool_24 = Class114.bool_0;
				while (Class802.queue_0.Count > 0)
				{
					Class802.queue_0.Dequeue()();
				}
				Class115.class115_0.method_37();
				Class802.buttonState_1 = Class802.buttonState_0;
				Class802.buttonState_6 = Class802.buttonState_5;
				Class802.bool_7 = (Class802.buttonState_0 == 1);
				Class802.bool_22 = (Class802.buttonState_5 == 1);
				Class802.buttonState_2 = Class800.smethod_1();
				Class802.buttonState_4 = Class800.smethod_3();
				Class802.buttonState_3 = Class800.smethod_5();
				Class802.keyboardState_1 = Class802.keyboardState_0;
				if (!Class800.smethod_43() && ((!Class802.smethod_0() && Class802.bool_9) || !flag2))
				{
					break;
				}
			}
			while (num++ < 30);
		}

		// Token: 0x06002FE8 RID: 12264
		// RVA: 0x001352A4 File Offset: 0x001334A4
		private static bool smethod_13()
		{
			bool result = false;
			lock (Class858.object_0)
			{
				if (Class802.class512_0 != null && Class802.class512_0.list_1 != null)
				{
					int count = Class802.class512_0.list_1.Count;
					Class802.bool_15 = false;
					Class802.bool_25 = false;
					int num = Class331.smethod_71() ? -1 : 1;
					Class62 class62_ = Class62.class62_0;
					if (Class115.osuModes_1 == OsuModes.Play && Class62.class512_0 != null && class62_ != null && class62_.enum110_0 != Enum110.const_0 && Class62.bool_40 && count > 0 && Class802.int_1 < count - 1 && (Class802.bool_17 || !Class115.bool_16 || !Class115.bool_18) && (Class802.bool_17 || !Class802.bool_16 || Class802.class512_0.list_1[count - 1].int_0 - Class331.int_7 > 1000))
					{
						Class802.bool_0 = false;
						if (!Class331.smethod_71())
						{
							if (Class802.int_1 < count - 1 && Class802.class512_0.list_1[Class802.int_1 + 1].int_0 <= Class331.int_7)
							{
								Class802.int_1++;
								Class802.bool_15 = true;
							}
							if ((result = (Class331.int_7 - Class802.class512_0.list_1[Class802.int_1].int_0 > 16 && Class802.bool_15)) && Class802.class512_0.vmethod_0())
							{
								while (Class802.int_1 < count - 1 && !Class802.class512_0.list_1[Class802.int_1].bool_0 && !Class802.class512_0.list_1[Class802.int_1].bool_1 && Class802.class512_0.list_1[Class802.int_1 + 1].int_0 <= Class331.int_7 && Class802.class512_0.list_1[Class802.int_1].bool_0 == Class802.bool_7 && Class802.class512_0.list_1[Class802.int_1].bool_1 == Class802.bool_22 && Class802.class512_0.list_1[Class802.int_1].pButtonState_0 == Class802.pButtonState_0 && !Class62.bool_9)
								{
									Class802.int_1 += num;
								}
							}
						}
						else
						{
							if (Class802.int_1 > 0 && Class802.class512_0.list_1[Class802.int_1].int_0 > Class331.int_7)
							{
								Class802.int_1--;
							}
							if ((result = (Math.Abs(Class802.class512_0.list_1[Class802.int_1].int_0 - Class331.int_7) > 16)) && Class802.class512_0.vmethod_0())
							{
								while (Class802.int_1 > 0 && !Class802.class512_0.list_1[Class802.int_1].bool_0 && !Class802.class512_0.list_1[Class802.int_1].bool_1 && Class802.class512_0.list_1[Class802.int_1 - 1].int_0 > Class331.int_7 && Class802.class512_0.list_1[Class802.int_1].bool_0 == Class802.bool_7 && Class802.class512_0.list_1[Class802.int_1].bool_1 == Class802.bool_22 && Class802.class512_0.list_1[Class802.int_1].pButtonState_0 == Class802.pButtonState_0 && !Class62.bool_9)
								{
									Class802.int_1 += num;
								}
							}
						}
						if (Class802.bool_11)
						{
							Class802.bool_4 = false;
							Class802.bool_6 = false;
							Class802.bool_19 = false;
							Class802.bool_21 = false;
							Class802.buttonState_0 = 0;
							Class802.buttonState_5 = 0;
						}
						Class802.class14_0 = Class802.class512_0.list_1[Class802.int_1];
						Vector2 vector;
						if (Class802.bool_15)
						{
							Class331.int_7 = Class802.class14_0.int_0;
							Class802.bool_25 = true;
							Class802.bool_4 = ((!Class802.bool_11 || !Class802.bool_3) && Class802.class14_0.bool_2);
							Class802.bool_3 = Class802.class14_0.bool_2;
							Class802.bool_6 = ((!Class802.bool_11 || !Class802.bool_5) && Class802.class14_0.bool_4);
							Class802.bool_5 = Class802.class14_0.bool_4;
							Class802.bool_19 = ((!Class802.bool_11 || !Class802.bool_18) && Class802.class14_0.bool_3);
							Class802.bool_18 = Class802.class14_0.bool_3;
							Class802.bool_21 = ((!Class802.bool_11 || !Class802.bool_20) && Class802.class14_0.bool_5);
							Class802.bool_20 = Class802.class14_0.bool_5;
							Class802.buttonState_0 = ((Class802.bool_4 || Class802.bool_6) ? 1 : 0);
							Class802.buttonState_5 = ((Class802.bool_19 || Class802.bool_21) ? 1 : 0);
							vector..ctor(Class802.class14_0.float_0, Class802.class14_0.float_1);
							if (Class62.bool_40 && Class802.class512_0.playModes_0 == PlayModes.OsuMania)
							{
								int num2 = (int)Class802.class14_0.float_0;
								int num3 = (int)Class802.class14_0.float_1;
								Class300 class = (Class300)Class62.class62_0.class297_0;
								for (int i = 0; i < Class802.smethod_6().list_0.Count; i++)
								{
									bool flag = (num2 & Class802.smethod_6().list_0[i].method_2()) > 0;
									if (Class802.smethod_6().method_36())
									{
										if (i == 0)
										{
											Class802.smethod_6().list_0[Class802.smethod_6().list_0.Count - 1].method_6(flag);
										}
										else
										{
											Class802.smethod_6().list_0[i - 1].method_6(flag);
										}
									}
									else
									{
										Class802.smethod_6().list_0[i].method_6(flag);
									}
								}
								if (num3 > 0 && !Class876.smethod_5(Mods.Autoplay))
								{
									Enum45 enum = Enum45.flag_0;
									if (Class802.class512_0.int_4 < 20141018)
									{
										enum |= Enum45.flag_3;
									}
									if (Class435.smethod_0(num3, enum))
									{
										class.method_38(Class802.class14_0.int_0);
									}
								}
								vector..ctor(-500f, -500f);
							}
							Class802.pButtonState_0 = Class802.class14_0.pButtonState_0;
						}
						else if (Class802.class512_0.playModes_0 == PlayModes.OsuMania)
						{
							for (int j = 0; j < Class802.smethod_6().list_0.Count; j++)
							{
								Class802.smethod_6().list_0[j].bool_2 = Class802.smethod_6().list_0[j].method_5();
							}
							vector..ctor(-500f, -500f);
						}
						else if (Class802.class14_0.int_0 == Class802.class512_0.list_1[Class802.int_1 + 1].int_0)
						{
							vector..ctor(Class802.class14_0.float_0, Class802.class14_0.float_1);
						}
						else if (Class802.class14_0.int_0 >= Class331.int_7)
						{
							int index = Math.Max(0, Class802.int_1 - 1);
							int index2 = Class802.int_1;
							vector = Vector2.Lerp(new Vector2(Class802.class512_0.list_1[index].float_0, Class802.class512_0.list_1[index].float_1), new Vector2(Class802.class512_0.list_1[index2].float_0, Class802.class512_0.list_1[index2].float_1), (Class802.class512_0.list_1[index2].int_0 == Class802.class512_0.list_1[index].int_0) ? 0f : Math.Max(0f, 1f - (float)(Class802.class512_0.list_1[index2].int_0 - Class331.int_7) / (float)(Class802.class512_0.list_1[index2].int_0 - Class802.class512_0.list_1[index].int_0)));
						}
						else
						{
							int index3 = Class802.int_1;
							int index4 = Math.Min(count - 1, Class802.int_1 + 1);
							vector = Vector2.Lerp(new Vector2(Class802.class512_0.list_1[index3].float_0, Class802.class512_0.list_1[index3].float_1), new Vector2(Class802.class512_0.list_1[index4].float_0, Class802.class512_0.list_1[index4].float_1), (Class802.class512_0.list_1[index4].int_0 == Class802.class512_0.list_1[index3].int_0) ? 0f : Math.Max(0f, 1f - (float)(Class802.class512_0.list_1[index4].int_0 - Class331.int_7) / (float)(Class802.class512_0.list_1[index4].int_0 - Class802.class512_0.list_1[index3].int_0)));
						}
						Class802.vector2_1 = vector;
						Class802.vector2_0 = Class115.smethod_61(vector);
						Class802.point_0 = new Point((int)Class802.vector2_0.X, (int)Class802.vector2_0.Y);
						Class62.bool_12 = false;
					}
					else if (Class802.bool_16)
					{
						Class62.bool_12 = false;
						if (Class802.bool_17)
						{
							Class802.bool_25 = true;
							if (Class62.bool_11 && !Class62.bool_6)
							{
								Class802.bool_0 = false;
							}
							if (Class62.class533_0 != null && Class62.bool_6)
							{
								Class62.class533_0.Text = Class41.GetString(OsuString.InputManager_HostFailed);
							}
						}
						else
						{
							Class802.bool_0 = true;
							float num4;
							if (count == 0)
							{
								num4 = 0f;
							}
							else
							{
								num4 = Class778.smethod_2((float)(Class802.class512_0.list_1[count - 1].int_0 - Class331.int_7) / 10f, 0f, 100f);
							}
							if (Class62.class533_0 != null)
							{
								string text = null;
								switch (Class858.enum0_1)
								{
								case Enum0.const_4:
									text += Class41.GetString(OsuString.InputManager_HostFailed);
									Class858.smethod_2();
									break;
								case Enum0.const_5:
									text += Class41.GetString(OsuString.InputManager_HostPaused);
									break;
								case Enum0.const_7:
									text += Class41.GetString(OsuString.InputManager_HostIsSelectingASong);
									Class858.smethod_2();
									break;
								}
								if (text == null)
								{
									text = string.Format(Class41.GetString(OsuString.InputManager_Buffering), num4);
								}
								Class62.class533_0.Text = text;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06002FE9 RID: 12265
		// RVA: 0x00135DD0 File Offset: 0x00133FD0
		private static void smethod_14(List<Keys> list_6)
		{
			if (list_6 == null)
			{
				list_6 = new List<Keys>();
			}
			List<Keys> list = new List<Keys>(list_6);
			Class570.bool_0 = (Class802.keyboardState_0.IsKeyDown(162) || Class802.keyboardState_0.IsKeyDown(163));
			Class570.bool_1 = (Class802.keyboardState_0.IsKeyDown(164) || Class802.keyboardState_0.IsKeyDown(165));
			Class570.bool_2 = (Class802.keyboardState_0.IsKeyDown(160) || Class802.keyboardState_0.IsKeyDown(161));
			if (list_6 == null || list_6.Count == 0 || !Class802.bool_24)
			{
				Class802.double_1 = -120.0;
			}
			bool flag = Class570.bool_0 || Class570.bool_1;
			foreach (Keys current in Class802.list_1)
			{
				if (!list_6.Contains(current))
				{
					Class802.int_4 = Class115.int_1;
					Class570.smethod_7(current);
				}
			}
			TextInputControl textInputControl = Class802.smethod_28();
			if (textInputControl != null && textInputControl.method_3())
			{
				bool flag2 = false;
				if (list_6.Count >= 2 && list_6.Contains(162) && list_6.Contains(165))
				{
					flag2 = false;
				}
				else if (list_6.Count > 1 && (list_6.Contains(164) || list_6.Contains(162) || list_6.Contains(165) || list_6.Contains(163)))
				{
					flag2 = true;
				}
				else if (list_6.Count == 1 && Class795.smethod_11(list_6[0], Bindings.BossKey))
				{
					flag2 = true;
				}
				else
				{
					for (int i = 0; i < list_6.Count; i++)
					{
						Keys keys = list_6[i];
						if (keys >= 300)
						{
							flag2 = true;
						}
						else
						{
							Keys keys2 = keys;
							if (keys2 <= 27)
							{
								if (keys2 == 9 || keys2 == 13 || keys2 == 27)
								{
									goto IL_29C;
								}
							}
							else
							{
								switch (keys2)
								{
								case 33:
								case 34:
								case 38:
								case 40:
									goto IL_29C;
								case 35:
								case 36:
									break;
								case 37:
								case 39:
									flag2 = textInputControl.bool_0;
									goto IL_29F;
								default:
									if (keys2 == 46)
									{
										goto IL_29C;
									}
									switch (keys2)
									{
									case 162:
									case 163:
									case 164:
									case 165:
										flag2 = true;
										goto IL_29F;
									}
									break;
								}
							}
							string text = keys.ToString();
							if (text[0] == 'F')
							{
								text = text.Substring(1);
								int num;
								if (int.TryParse(text, out num))
								{
									flag2 = true;
									flag = true;
									goto IL_29F;
								}
							}
							list_6.Remove(keys);
							i--;
							goto IL_29F;
							IL_29C:
							flag2 = true;
						}
						IL_29F:;
					}
				}
				if (!flag2)
				{
					Class802.double_1 = -120.0;
					Class802.list_1 = list;
					return;
				}
			}
			for (int j = 0; j < list_6.Count; j++)
			{
				Keys keys3 = list_6[j];
				bool flag3 = false;
				if (Class802.list_1 != null)
				{
					for (int k = 0; k < Class802.list_1.Count; k++)
					{
						if (keys3 == Class802.list_1[k])
						{
							flag3 = true;
							break;
						}
					}
				}
				if (Class115.enum113_0 != Enum113.const_0)
				{
					if (!flag3)
					{
						Class802.double_0 = -100.0;
						Class809.smethod_38();
						bool flag4;
						if (!(flag4 = Class115.smethod_8(null, keys3)) && textInputControl != null && textInputControl.class754_0 != null)
						{
							flag4 = textInputControl.class754_0.vmethod_1(null, keys3, true);
						}
						if (!flag4 && Class115.class89_0 != null)
						{
							flag4 = Class115.class89_0.vmethod_5(keys3);
							flag4 = true;
						}
						if (!flag4 && Class115.class81_0 != null)
						{
							flag4 = Class115.class81_0.method_12(null, keys3, true);
						}
						if (Class115.smethod_5())
						{
							flag4 = true;
						}
						if (!flag4)
						{
							flag4 = Class111.smethod_17(null, keys3, true);
						}
						if (!flag4 && Class115.class80_0.method_23())
						{
							flag4 = Class115.class80_0.method_20(null, keys3, true);
						}
						if ((!Class111.bool_2 || flag) && !flag4)
						{
							Class802.int_4 = Class115.int_1;
							Class570.smethod_6(keys3);
						}
					}
					else
					{
						int num2 = 0;
						while (num2 < Class802.list_1.Count && keys3 != Class802.list_1[num2])
						{
							num2++;
						}
					}
				}
			}
			int num3 = 0;
			for (int l = 0; l < Class802.list_1.Count; l++)
			{
				switch (Class802.list_1[l])
				{
				case 160:
				case 161:
				case 162:
				case 163:
				case 164:
				case 165:
					break;
				default:
					num3++;
					break;
				}
			}
			if (num3 > 0)
			{
				if (Class802.double_1 >= 100.0)
				{
					Class802.double_1 -= 100.0;
					if (Class802.list_1 != null)
					{
						foreach (Keys current2 in list_6)
						{
							foreach (Keys current3 in Class802.list_1)
							{
								if (current2 == current3)
								{
									break;
								}
							}
							if (current2 != 246 && current2 != 251)
							{
								bool flag5 = false;
								if (textInputControl != null && textInputControl.class754_0 != null)
								{
									flag5 = textInputControl.class754_0.vmethod_1(null, current2, false);
								}
								if (!flag5 && Class115.class81_0 != null)
								{
									flag5 = Class115.class81_0.method_12(null, current2, false);
								}
								if (!flag5)
								{
									flag5 = Class111.smethod_17(null, current2, false);
								}
								if (!flag5 && Class115.class80_0.method_23())
								{
									flag5 = Class115.class80_0.method_20(null, current2, false);
								}
								if (!flag5 && Class115.class89_0 != null)
								{
									flag5 = true;
								}
								if (!Class111.bool_2 && !flag5)
								{
									Class802.int_4 = Class115.int_1;
									Class570.smethod_8(current2, false);
								}
							}
						}
					}
				}
				Class802.double_1 += Class115.double_9;
			}
			else
			{
				Class802.double_1 = -120.0;
			}
			Class802.list_1 = list;
		}

		// Token: 0x06002FEA RID: 12266
		// RVA: 0x00023916 File Offset: 0x00021B16
		internal static void smethod_15()
		{
			if (!Class802.bool_2)
			{
				return;
			}
			Class800.bool_3 = false;
			Class800.vector2_0 = Class802.vector2_0;
			Class802.bool_2 = false;
			Class800.smethod_37();
		}

		// Token: 0x06002FEB RID: 12267
		// RVA: 0x0002393B File Offset: 0x00021B3B
		internal static void smethod_16()
		{
			Class802.buttonState_0 = 0;
			Class802.bool_4 = false;
			Class802.bool_3 = false;
			Class802.bool_6 = false;
			Class802.bool_5 = false;
			Class802.buttonState_5 = 0;
			Class802.bool_19 = false;
			Class802.bool_18 = false;
			Class802.bool_21 = false;
			Class802.bool_20 = false;
		}

		// Token: 0x06002FEC RID: 12268
		// RVA: 0x0013642C File Offset: 0x0013462C
		internal static int smethod_17()
		{
			int num = 0;
			for (int i = 0; i < Class802.smethod_6().list_0.Count; i++)
			{
				if (Class802.smethod_6().list_0[i].method_5())
				{
					if (Class62.class62_0.class297_0 is Class300 && Class802.smethod_6().method_36())
					{
						if (i == Class802.smethod_6().list_0.Count - 1)
						{
							num += Class802.smethod_6().list_0[0].method_2();
						}
						else
						{
							num += Class802.smethod_6().list_0[i + 1].method_2();
						}
					}
					else
					{
						num += Class802.smethod_6().list_0[i].method_2();
					}
				}
			}
			return num;
		}

		// Token: 0x06002FED RID: 12269
		// RVA: 0x001364F4 File Offset: 0x001346F4
		internal static void smethod_18()
		{
			Class802.buttonState_0 = Class800.smethod_1();
			Class802.bool_4 = (Class802.buttonState_0 == 1 && (!Class802.bool_11 || !Class802.bool_7));
			Class802.bool_3 = (Class802.buttonState_0 == 1);
			Class802.bool_6 = false;
			Class802.bool_5 = false;
			Class802.buttonState_5 = Class800.smethod_3();
			Class802.bool_19 = (Class802.buttonState_5 == 1 && (!Class802.bool_11 || !Class802.bool_22));
			Class802.bool_18 = (Class802.buttonState_5 == 1);
			Class802.bool_21 = false;
			Class802.bool_20 = false;
		}

		// Token: 0x06002FEE RID: 12270
		// RVA: 0x0013658C File Offset: 0x0013478C
		private static void smethod_19()
		{
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				return;
			}
			Keys keys;
			if ((keys = Class795.smethod_8(Enum77.const_0)) != null)
			{
				bool flag;
				Class802.bool_3 |= (flag = (Class802.keyboardState_0.IsKeyDown(keys) || Class569.smethod_2(keys)));
				Class802.bool_4 |= (flag && (!Class802.bool_11 || (!Class802.keyboardState_1.IsKeyDown(keys) && !Class569.smethod_3(keys))));
			}
			if ((keys = Class795.smethod_8(Enum77.const_1)) != null)
			{
				bool flag2;
				Class802.bool_5 |= (flag2 = (Class802.keyboardState_0.IsKeyDown(keys) || Class569.smethod_2(keys)));
				Class802.bool_6 |= (flag2 && (!Class802.bool_11 || (!Class802.keyboardState_1.IsKeyDown(keys) && !Class569.smethod_3(keys))));
			}
			if ((keys = Class795.smethod_8(Enum77.const_2)) != null)
			{
				bool flag3;
				Class802.bool_18 |= (flag3 = (Class802.keyboardState_0.IsKeyDown(keys) || Class569.smethod_2(keys)));
				Class802.bool_19 |= (flag3 && (!Class802.bool_11 || (!Class802.keyboardState_1.IsKeyDown(keys) && !Class569.smethod_3(keys))));
			}
			if (Class795.smethod_8(Enum77.const_3) != null)
			{
				keys = Class795.smethod_8(Enum77.const_3);
				bool flag4;
				Class802.bool_20 |= (flag4 = (Class802.keyboardState_0.IsKeyDown(keys) || Class569.smethod_2(keys)));
				Class802.bool_21 |= (flag4 && (!Class802.bool_11 || (!Class802.keyboardState_1.IsKeyDown(keys) && !Class569.smethod_3(keys))));
			}
			if ((Class802.bool_6 || Class802.bool_4) && !Class802.smethod_0() && (!Class62.bool_11 || !Class111.bool_2))
			{
				Class802.buttonState_0 = 1;
			}
			if ((Class802.bool_19 || Class802.bool_21) && !Class802.smethod_0() && (!Class62.bool_11 || !Class111.bool_2))
			{
				Class802.buttonState_5 = 1;
			}
		}

		// Token: 0x06002FDB RID: 12251
		// RVA: 0x00023895 File Offset: 0x00021A95
		public static bool smethod_2()
		{
			return Class802.bool_1;
		}

		// Token: 0x06002FEF RID: 12271
		// RVA: 0x00023979 File Offset: 0x00021B79
		internal static bool smethod_20()
		{
			return (Class802.smethod_0() && Class802.bool_12) || Class62.bool_16;
		}

		// Token: 0x06002FF0 RID: 12272
		// RVA: 0x00136798 File Offset: 0x00134998
		internal static void smethod_21()
		{
			if (Class802.class531_0 == null || Class802.class531_1 == null)
			{
				return;
			}
			if (Class802.vector2_2 == -Vector2.get_One() || (Class802.smethod_20() && (!Class800.smethod_22(Class802.vector2_2, -100) || !Class800.smethod_22(Class802.class531_0.vector2_1, -100))))
			{
				Class802.vector2_2 = Class802.class531_0.vector2_1;
			}
			Class802.class531_1.vector2_1 = Class802.class531_0.vector2_1;
			Class802.class531_1.float_3 = Class802.class531_0.float_3;
			float num = (float)Class115.double_9 / 300f;
			foreach (Class531 current in Class802.list_2)
			{
				current.float_3 = Math.Max(0f, current.float_3 - num);
			}
			int num2 = 0;
			while (num2 < Class802.list_2.Count && Class802.list_2[num2].float_3 <= 0f)
			{
				Class802.list_2[num2].bool_0 = false;
				num2++;
			}
			Class802.list_2.RemoveRange(0, num2);
			if (!Class802.class531_0.bool_3)
			{
				return;
			}
			Class731 class731_ = Class885.class731_0;
			if (class731_ == null || class731_.method_0() < 5)
			{
				return;
			}
			float num3 = (float)class731_.method_0() * 0.625f * Class115.float_4 * Class802.class531_0.float_2 / 2.5f;
			if (Class802.class531_1.vmethod_6() != null)
			{
				if (Vector2.Distance(Class802.vector2_2, Class802.class531_0.vector2_1) < num3)
				{
					return;
				}
				List<Vector2> list = Class802.smethod_20() ? new List<Vector2>() : Class802.interface15_0.imethod_6();
				list.Add(Class802.class531_0.vector2_1);
				for (int i = 0; i < list.Count; i++)
				{
					float num4 = Vector2.Distance(Class802.vector2_2, list[i]);
					float num5 = num4 / num3;
					for (int j = 0; j < (int)num5; j++)
					{
						Class531 class = new Class531(class731_, Enum115.const_15, Class885.smethod_2().bool_0 ? Origins.Centre : Origins.TopLeft, Enum114.const_0, Vector2.Lerp(Class802.vector2_2, list[i], (float)j / num5), ((Class802.class531_1 != null) ? Class802.class531_1.float_0 : Class802.class531_0.float_0) - 0.001f, true, Class802.class531_0.color_1, null);
						class.bool_7 = true;
						class.float_2 = Class802.class531_0.float_2;
						class.vector2_2 = Class802.class531_0.vector2_2;
						if (Class885.smethod_2().bool_9)
						{
							class.float_1 = Class802.class531_0.float_1;
						}
						Class115.class911_1.Add(class);
						Class802.list_2.Add(class);
					}
					if (num5 > 0f)
					{
						Class802.vector2_2 = Vector2.Lerp(Class802.vector2_2, list[i], (float)((int)num5) / num5);
					}
				}
				list.RemoveAt(list.Count - 1);
				Class802.int_3 = Class115.int_1;
				return;
			}
			else
			{
				if (!Class115.bool_13 && (double)(Class115.int_1 - Class802.int_3) < 16.666666666666668)
				{
					return;
				}
				Class531 class2 = new Class531(class731_, Enum115.const_15, Class885.smethod_2().bool_0 ? Origins.Centre : Origins.TopLeft, Enum114.const_0, Class802.class531_0.vector2_1, Class802.class531_0.float_0 - 0.001f, false, Class802.class531_0.color_1, null);
				class2.method_16(150, Enum70.const_0);
				Class802.int_3 = Class115.int_1;
				if (class2 != null)
				{
					class2.float_2 = Class802.class531_0.float_2;
					class2.vector2_2 = Class802.class531_0.vector2_2;
					if (Class885.smethod_2().bool_9)
					{
						class2.float_1 = Class802.class531_0.float_1;
					}
					Class115.class911_1.Add(class2);
				}
				return;
			}
		}

		// Token: 0x06002FF1 RID: 12273
		// RVA: 0x00136B98 File Offset: 0x00134D98
		public static Class563 smethod_22(Type type_0)
		{
			Class802.Class804 class = new Class802.Class804();
			class.type_0 = type_0;
			return Class802.list_0.Find(new Predicate<Class563>(class.method_0));
		}

		// Token: 0x06002FF2 RID: 12274
		// RVA: 0x00136BC8 File Offset: 0x00134DC8
		public static bool smethod_23(Class563 class563_0)
		{
			try
			{
				if (class563_0.Initialize())
				{
					int num = Class802.list_0.BinarySearch(class563_0, Class802.class797_0);
					if (num < 0)
					{
						num = ~num;
					}
					Class802.list_0.Insert(num, class563_0);
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06002FF3 RID: 12275
		// RVA: 0x00136C20 File Offset: 0x00134E20
		internal static void smethod_24()
		{
			Mods mods_ = (Class62.class512_0 != null) ? Class62.class512_0.class623_0 : Class876.class623_0;
			float num = (Class115.osuModes_1 != OsuModes.Play || !Class341.class606_68.Value) ? 1f : (1f - 0.7f * (float)(Class297.smethod_10((double)Class466.Current.DifficultyCircleSize, 1.3, mods_) - 4.0) / 5f);
			if (Class802.class531_0 != null)
			{
				Class802.class531_0.vector2_2 = num * Vector2.get_One() * (float)Class341.class607_0.Value;
			}
			if (Class802.class531_1 != null)
			{
				Class802.class531_1.vector2_2 = Class802.class531_0.vector2_2;
			}
		}

		// Token: 0x06002FF4 RID: 12276
		// RVA: 0x00023990 File Offset: 0x00021B90
		internal static void smethod_25(TextInputControl textInputControl_1)
		{
			if (!Class802.list_3.Remove(textInputControl_1))
			{
				Class115.form_0.Controls.Add(textInputControl_1);
			}
			Class802.list_3.Add(textInputControl_1);
			textInputControl_1.SendToBack();
			Class802.smethod_27(true);
		}

		// Token: 0x06002FF5 RID: 12277
		// RVA: 0x000239C7 File Offset: 0x00021BC7
		internal static void smethod_26(TextInputControl textInputControl_1)
		{
			if (textInputControl_1 == Class802.textInputControl_0)
			{
				return;
			}
			Class115.form_0.Controls.Remove(textInputControl_1);
			Class802.list_3.Remove(textInputControl_1);
			Class802.smethod_27(true);
		}

		// Token: 0x06002FF6 RID: 12278
		// RVA: 0x00136CE8 File Offset: 0x00134EE8
		internal static TextInputControl smethod_27(bool bool_31)
		{
			TextInputControl textInputControl = Class802.smethod_28();
			if (!Class115.smethod_5() && Class114.bool_0 && (!textInputControl.Focused || bool_31))
			{
				textInputControl.Focus();
			}
			return textInputControl;
		}

		// Token: 0x06002FF7 RID: 12279
		// RVA: 0x00136D1C File Offset: 0x00134F1C
		internal static TextInputControl smethod_28()
		{
			if (Class802.list_3.Count == 0)
			{
				return null;
			}
			for (int i = Class802.list_3.Count - 1; i >= 0; i--)
			{
				TextInputControl textInputControl = Class802.list_3[i];
				if (textInputControl.method_3())
				{
					return textInputControl;
				}
			}
			return Class802.list_3[0];
		}

		// Token: 0x06002FF8 RID: 12280
		// RVA: 0x00136D70 File Offset: 0x00134F70
		internal static bool smethod_29()
		{
			if (Class341.class607_3 != 1.0 && !Class341.class606_79 && Class115.smethod_94())
			{
				Class341.class606_79.Value = true;
				Class723.smethod_5(Class41.GetString(OsuString.Options_Input_RawInputRequired), Color.get_OrangeRed(), 10000, null);
				return true;
			}
			return false;
		}

		// Token: 0x06002FDC RID: 12252
		// RVA: 0x0002389C File Offset: 0x00021A9C
		public static void smethod_3(bool bool_31)
		{
			if (Class802.bool_1 == bool_31)
			{
				return;
			}
			Class802.bool_1 = bool_31;
			Class802.class755_0.method_25(bool_31);
		}

		// Token: 0x06002FF9 RID: 12281
		// RVA: 0x00136DD0 File Offset: 0x00134FD0
		internal static void smethod_30(Vector2 vector2_5)
		{
			Class800.smethod_13(new Point((int)Math.Round((double)vector2_5.X), (int)Math.Round((double)vector2_5.Y)), false);
			Class802.vector2_0 = vector2_5;
			Class802.vector2_4 = Class802.vector2_0;
			Class802.interface15_0 = null;
			Class800.smethod_21();
		}

		// Token: 0x06002FFA RID: 12282
		// RVA: 0x00136E20 File Offset: 0x00135020
		internal static void smethod_31(Vector2 vector2_5)
		{
			foreach (Class563 current in Class802.list_0)
			{
				if (current != Class802.interface15_0 && current is Interface15)
				{
					((Interface15)current).imethod_0(vector2_5);
				}
			}
		}

		// Token: 0x06002FFB RID: 12283
		// RVA: 0x00136E88 File Offset: 0x00135088
		internal static void smethod_32()
		{
			if (Class802.voidDelegate_0 == null)
			{
				Class802.voidDelegate_0 = new VoidDelegate(Class802.smethod_39);
			}
			Class115.smethod_12(Class802.voidDelegate_0);
			List<Enum98> list = new List<Enum98>((Enum98[])Enum.GetValues(typeof(Enum98)));
			list.Reverse();
			foreach (Enum98 current in list)
			{
				Class802.list_5.Add(new Class572(current, true));
			}
		}

		// Token: 0x06002FFC RID: 12284
		// RVA: 0x00136F24 File Offset: 0x00135124
		internal static void smethod_33(Enum96 enum96_0)
		{
			foreach (Class572 current in Class802.list_5)
			{
				if (current.Invoke(enum96_0))
				{
					break;
				}
			}
		}

		// Token: 0x06002FFD RID: 12285
		// RVA: 0x00136F7C File Offset: 0x0013517C
		internal static void smethod_34(Enum96 enum96_0, Delegate46 delegate46_0, Enum98 enum98_0, Enum97 enum97_0)
		{
			Class802.Class805 class = new Class802.Class805();
			class.enum96_0 = enum96_0;
			class.delegate46_0 = delegate46_0;
			class.enum98_0 = enum98_0;
			Class802.list_5.Find(new Predicate<Class572>(class.method_0)).method_0(class.enum96_0, class.delegate46_0);
			if (enum97_0 == Enum97.const_0)
			{
				Class802.queue_1.Enqueue(new VoidDelegate(class.method_1));
			}
		}

		// Token: 0x06002FFE RID: 12286
		// RVA: 0x00136FE4 File Offset: 0x001351E4
		internal static void smethod_35(Enum96 enum96_0, Delegate46 delegate46_0, Enum98 enum98_0)
		{
			Class802.Class806 class = new Class802.Class806();
			class.enum98_0 = enum98_0;
			Class802.list_5.Find(new Predicate<Class572>(class.method_0)).method_1(enum96_0, delegate46_0);
		}

		// Token: 0x06002FFF RID: 12287
		// RVA: 0x000239F5 File Offset: 0x00021BF5
		internal static void smethod_36(Enum96 enum96_0, Delegate46 delegate46_0, Enum98 enum98_0, Enum97 enum97_0)
		{
			Class802.smethod_35(enum96_0, delegate46_0, enum98_0);
			Class802.smethod_34(enum96_0, delegate46_0, enum98_0, enum97_0);
		}

		// Token: 0x06003000 RID: 12288
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_37(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06003001 RID: 12289
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_38(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06003002 RID: 12290
		// RVA: 0x00023A08 File Offset: 0x00021C08
		[CompilerGenerated]
		private static void smethod_39()
		{
			while (Class802.queue_1.Count != 0)
			{
				Class802.queue_1.Dequeue()();
			}
		}

		// Token: 0x06002FDD RID: 12253
		// RVA: 0x000238B8 File Offset: 0x00021AB8
		public static bool smethod_4()
		{
			return Class802.interface15_0 is Class566 || Class802.interface15_0 is Class568;
		}

		// Token: 0x06002FDE RID: 12254
		// RVA: 0x00134704 File Offset: 0x00132904
		public static List<Vector2> smethod_5()
		{
			if (Class802.interface15_0 is Class566)
			{
				return new List<Vector2>(((Class566)Class802.interface15_0).dictionary_0.Values);
			}
			if (Class800.bool_3)
			{
				return new List<Vector2>(new Vector2[]
				{
					Class800.vector2_0 / Class115.float_4
				});
			}
			return new List<Vector2>();
		}

		// Token: 0x06002FDF RID: 12255
		// RVA: 0x000238D5 File Offset: 0x00021AD5
		private static Class421 smethod_6()
		{
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				return Editor.editor_0.class297_0.class421_0;
			}
			return Class62.class62_0.class297_0.class421_0;
		}

		// Token: 0x06002FE0 RID: 12256
		// RVA: 0x0013476C File Offset: 0x0013296C
		public static void smethod_7(string string_1)
		{
			Class802.Class803 class = new Class802.Class803();
			class.string_0 = string_1;
			if (class.string_0 == null)
			{
				class.string_0 = string.Empty;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06002FE3 RID: 12259
		// RVA: 0x001348DC File Offset: 0x00132ADC
		internal static void smethod_8()
		{
			foreach (Class563 current in Class802.list_0)
			{
				current.vmethod_0();
			}
		}

		// Token: 0x06002FE4 RID: 12260
		// RVA: 0x000238FE File Offset: 0x00021AFE
		private static void smethod_9(object sender, EventArgs e)
		{
			Class802.smethod_10();
			if (Class114.bool_0)
			{
				Class800.vector2_0 = Class802.vector2_0;
			}
		}
	}
}
