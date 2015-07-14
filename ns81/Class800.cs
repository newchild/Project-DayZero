using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns25;
using ns29;
using ns6;
using ns64;
using ns76;
using ns77;
using ns79;
using ns80;
using ns82;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns81
{
	// Token: 0x02000601 RID: 1537
	internal sealed class Class800
	{
		// Token: 0x04002B41 RID: 11073
		public static bool bool_0;

		// Token: 0x04002B42 RID: 11074
		public static bool bool_1;

		// Token: 0x04002B43 RID: 11075
		internal static bool bool_2;

		// Token: 0x04002B48 RID: 11080
		internal static bool bool_3;

		// Token: 0x04002B51 RID: 11089
		internal static bool bool_4;

		// Token: 0x04002B52 RID: 11090
		internal static bool bool_5;

		// Token: 0x04002B53 RID: 11091
		internal static bool bool_6;

		// Token: 0x04002B54 RID: 11092
		internal static bool bool_7;

		// Token: 0x04002B39 RID: 11065
		private static ButtonState buttonState_0;

		// Token: 0x04002B3A RID: 11066
		private static ButtonState buttonState_1;

		// Token: 0x04002B4E RID: 11086
		private static ButtonState buttonState_10;

		// Token: 0x04002B4F RID: 11087
		private static ButtonState buttonState_11;

		// Token: 0x04002B3B RID: 11067
		private static ButtonState buttonState_2;

		// Token: 0x04002B3C RID: 11068
		private static ButtonState buttonState_3;

		// Token: 0x04002B3D RID: 11069
		private static ButtonState buttonState_4;

		// Token: 0x04002B46 RID: 11078
		internal static ButtonState buttonState_5;

		// Token: 0x04002B47 RID: 11079
		internal static ButtonState buttonState_6;

		// Token: 0x04002B4B RID: 11083
		private static ButtonState buttonState_7;

		// Token: 0x04002B4C RID: 11084
		private static ButtonState buttonState_8;

		// Token: 0x04002B4D RID: 11085
		private static ButtonState buttonState_9;

		// Token: 0x04002B38 RID: 11064
		internal static float float_0;

		// Token: 0x04002B36 RID: 11062
		internal static int int_0;

		// Token: 0x04002B37 RID: 11063
		internal static int int_1;

		// Token: 0x04002B3E RID: 11070
		private static int int_2;

		// Token: 0x04002B40 RID: 11072
		internal static int int_3;

		// Token: 0x04002B35 RID: 11061
		internal static long long_0;

		// Token: 0x04002B44 RID: 11076
		public static MouseButtons mouseButtons_0;

		// Token: 0x04002B45 RID: 11077
		public static MouseButtons mouseButtons_1;

		// Token: 0x04002B49 RID: 11081
		internal static MouseButtons mouseButtons_2;

		// Token: 0x04002B4A RID: 11082
		internal static MouseButtons mouseButtons_3;

		// Token: 0x04002B55 RID: 11093
		[CompilerGenerated]
		private static Point point_0;

		// Token: 0x04002B57 RID: 11095
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04002B3F RID: 11071
		internal static Vector2 vector2_0;

		// Token: 0x04002B50 RID: 11088
		private static Vector2 vector2_1;

		// Token: 0x04002B56 RID: 11094
		[CompilerGenerated]
		private static Vector2 vector2_2;

		// Token: 0x06002F9C RID: 12188
		// RVA: 0x00133D7C File Offset: 0x00131F7C
		internal static void Initialize()
		{
			Class115.form_0.Deactivate += new EventHandler(Class800.smethod_39);
			Class115.form_0.MouseWheel += new MouseEventHandler(Class800.smethod_40);
			if (Class115.bool_27)
			{
				Class115.baseGLControl_0.MouseDown += new MouseEventHandler(Class800.smethod_42);
				Class115.baseGLControl_0.MouseUp += new MouseEventHandler(Class800.smethod_41);
				Class115.baseGLControl_0.MouseWheel += new MouseEventHandler(Class800.smethod_40);
				return;
			}
			Class115.form_0.MouseDown += new MouseEventHandler(Class800.smethod_42);
			Class115.form_0.MouseUp += new MouseEventHandler(Class800.smethod_41);
		}

		// Token: 0x06002F91 RID: 12177
		// RVA: 0x000235D9 File Offset: 0x000217D9
		internal static bool smethod_0()
		{
			return Class115.rectangle_1.Contains(Class800.smethod_15());
		}

		// Token: 0x06002F92 RID: 12178
		// RVA: 0x000235EA File Offset: 0x000217EA
		internal static ButtonState smethod_1()
		{
			return Class800.buttonState_7;
		}

		// Token: 0x06002F9B RID: 12187
		// RVA: 0x00023655 File Offset: 0x00021855
		internal static void smethod_10(ButtonState buttonState_12)
		{
			if (buttonState_12 == 1)
			{
				Class800.buttonState_11 = buttonState_12;
			}
			Class800.buttonState_1 = buttonState_12;
		}

		// Token: 0x06002F9D RID: 12189
		// RVA: 0x00133E2C File Offset: 0x0013202C
		internal static void smethod_11(Interface15 interface15_0)
		{
			Class800.smethod_12(interface15_0.Position);
			if (interface15_0.imethod_1().HasValue)
			{
				Class800.smethod_2(interface15_0.imethod_1().Value);
			}
			if (interface15_0.imethod_2().HasValue)
			{
				Class800.smethod_4(interface15_0.imethod_2().Value);
			}
			if (interface15_0.imethod_3().HasValue)
			{
				Class800.smethod_6(interface15_0.imethod_3().Value);
			}
			if (interface15_0.imethod_4().HasValue)
			{
				Class800.smethod_8(interface15_0.imethod_4().Value);
			}
			if (interface15_0.imethod_5().HasValue)
			{
				Class800.smethod_10(interface15_0.imethod_5().Value);
			}
		}

		// Token: 0x06002F9E RID: 12190
		// RVA: 0x00023667 File Offset: 0x00021867
		internal static void smethod_12(Vector2 vector2_3)
		{
			Class800.smethod_20(vector2_3);
			Class802.smethod_31(vector2_3);
		}

		// Token: 0x06002F9F RID: 12191
		// RVA: 0x00133EFC File Offset: 0x001320FC
		internal static void smethod_13(Point point_1, bool bool_8)
		{
			if (!bool_8 && !Class114.bool_0)
			{
				return;
			}
			int num = (!Class115.bool_12 || !Class115.bool_27) ? 0 : Class115.editorControl_0.Height;
			Cursor.Position = Class115.form_0.PointToScreen(new Point(point_1.X, point_1.Y + num));
		}

		// Token: 0x06002FA0 RID: 12192
		// RVA: 0x00133F54 File Offset: 0x00132154
		internal static Point smethod_14()
		{
			int num = (!Class115.bool_12 || !Class115.bool_27) ? 0 : Class115.editorControl_0.Height;
			Point point = Class115.form_0.PointToClient(Cursor.Position);
			return new Point(point.X, point.Y - num);
		}

		// Token: 0x06002FA1 RID: 12193
		// RVA: 0x00023675 File Offset: 0x00021875
		[CompilerGenerated]
		internal static Point smethod_15()
		{
			return Class800.point_0;
		}

		// Token: 0x06002FA2 RID: 12194
		// RVA: 0x0002367C File Offset: 0x0002187C
		[CompilerGenerated]
		private static void smethod_16(Point point_1)
		{
			Class800.point_0 = point_1;
		}

		// Token: 0x06002FA3 RID: 12195
		// RVA: 0x00023684 File Offset: 0x00021884
		[CompilerGenerated]
		internal static Vector2 smethod_17()
		{
			return Class800.vector2_2;
		}

		// Token: 0x06002FA4 RID: 12196
		// RVA: 0x0002368B File Offset: 0x0002188B
		[CompilerGenerated]
		private static void smethod_18(Vector2 vector2_3)
		{
			Class800.vector2_2 = vector2_3;
		}

		// Token: 0x06002FA5 RID: 12197
		// RVA: 0x00023693 File Offset: 0x00021893
		internal static Vector2 smethod_19()
		{
			return Class800.vector2_1;
		}

		// Token: 0x06002F93 RID: 12179
		// RVA: 0x000235F1 File Offset: 0x000217F1
		internal static void smethod_2(ButtonState buttonState_12)
		{
			if (buttonState_12 == 1)
			{
				Class800.buttonState_7 = buttonState_12;
			}
			Class800.buttonState_2 = buttonState_12;
		}

		// Token: 0x06002FA6 RID: 12198
		// RVA: 0x00133FA4 File Offset: 0x001321A4
		private static void smethod_20(Vector2 vector2_3)
		{
			Class800.vector2_1 = vector2_3;
			Class800.smethod_18((Class800.vector2_1 + new Vector2(0f, (float)((!Class115.bool_12 || !Class115.bool_27) ? 0 : Class115.editorControl_0.Height))) / Class115.float_4);
			Class800.smethod_16(new Point((int)Math.Round((double)vector2_3.X), (int)Math.Round((double)vector2_3.Y)));
		}

		// Token: 0x06002FA7 RID: 12199
		// RVA: 0x0002369A File Offset: 0x0002189A
		internal static void smethod_21()
		{
			Class800.smethod_12(Class802.vector2_0);
		}

		// Token: 0x06002FA8 RID: 12200
		// RVA: 0x000236A6 File Offset: 0x000218A6
		internal static bool smethod_22(Vector2 vector2_3, int int_4)
		{
			return Class800.smethod_23(new Point((int)Math.Round((double)vector2_3.X), (int)Math.Round((double)vector2_3.Y)), int_4);
		}

		// Token: 0x06002FA9 RID: 12201
		// RVA: 0x0013401C File Offset: 0x0013221C
		internal static bool smethod_23(Point point_1, int int_4)
		{
			return point_1.X >= int_4 && point_1.X < Class115.int_22 - int_4 && (point_1.Y >= int_4 & point_1.Y < Class115.int_23 + Class115.int_25 - int_4);
		}

		// Token: 0x06002FAA RID: 12202
		// RVA: 0x000236CF File Offset: 0x000218CF
		internal static void smethod_24()
		{
			Class800.smethod_25(Cursors.Arrow);
		}

		// Token: 0x06002FAB RID: 12203
		// RVA: 0x000236DB File Offset: 0x000218DB
		internal static void smethod_25(Cursor cursor_0)
		{
			if (Class115.form_0.Cursor != cursor_0)
			{
				Class115.form_0.Cursor = cursor_0;
			}
		}

		// Token: 0x06002FAC RID: 12204
		// RVA: 0x0013406C File Offset: 0x0013226C
		internal static void smethod_26()
		{
			if (Class115.bool_16)
			{
				Class800.bool_7 = (Class115.osuModes_1 == OsuModes.Play && Class802.smethod_0());
				Class800.bool_6 = true;
				Class800.bool_5 = true;
			}
			else
			{
				Class800.bool_7 = (Class802.bool_13 && Class115.osuModes_1 != OsuModes.Edit && (Class802.smethod_0() || !Class111.bool_1 || !Class111.bool_2));
				Class800.bool_7 &= (Class115.osuModes_1 != OsuModes.Play || Class62.class62_0 == null || !Class62.class62_0.vmethod_5());
				Class800.bool_7 &= (Class115.osuModes_1 != OsuModes.Menu || Class115.smethod_91() < 5000);
				Class800.bool_7 &= (Class115.osuModes_1 != OsuModes.Exit);
				Class800.bool_6 = ((Class111.bool_1 && Class111.bool_2) || Class115.osuModes_1 == OsuModes.Edit || (Class115.osuModes_1 == OsuModes.Play && Class802.smethod_0() && Class802.bool_12) || Class115.osuModes_0 == OsuModes.Exit || Class115.smethod_5());
				Class800.bool_5 = (Class800.bool_6 || (!Class800.smethod_0() && !Class800.smethod_23(Class800.smethod_14(), 0)));
			}
			if (Class800.bool_5 != Class115.bool_20)
			{
				Class115.bool_20 = Class800.bool_5;
				if (Class800.bool_5)
				{
					Cursor.Show();
				}
				else
				{
					Cursor.Hide();
				}
			}
			if (Class802.class531_0 == null)
			{
				return;
			}
			if ((Class800.bool_7 && Class802.class531_0.float_3 == 1f) || (!Class800.bool_7 && Class802.class531_0.float_3 == 0f))
			{
				return;
			}
			List<Class746> arg_1B2_0 = Class802.class531_0.class26_0;
			if (Class800.predicate_0 == null)
			{
				Class800.predicate_0 = new Predicate<Class746>(Class800.smethod_46);
			}
			if (arg_1B2_0.Find(Class800.predicate_0) != null)
			{
				return;
			}
			if (Class800.bool_7)
			{
				Class802.class531_0.method_14(100, Enum70.const_0);
				return;
			}
			Class802.class531_0.method_16(300, Enum70.const_0);
		}

		// Token: 0x06002FAD RID: 12205
		// RVA: 0x00134258 File Offset: 0x00132458
		internal static Interface15 smethod_27(List<Class563> list_0)
		{
			Interface15 interface = null;
			Interface15 interface2 = null;
			Interface15 interface3 = null;
			foreach (Class563 current in list_0)
			{
				if (interface == null && current.vmethod_2() && current is Interface15)
				{
					interface = (Interface15)current;
				}
				if (current is Class564)
				{
					interface2 = (Interface15)current;
				}
				if (current is Class567)
				{
					interface3 = (Interface15)current;
				}
				current.vmethod_1(interface == current);
			}
			if (interface != null)
			{
				if ((interface is Class564 || interface is Class567) && interface2 != null && interface3 != null)
				{
					Class62.smethod_0(interface2.Position - Class800.smethod_19(), interface3.Position - Class800.smethod_19());
				}
				Class800.smethod_11(interface);
			}
			return interface;
		}

		// Token: 0x06002FAE RID: 12206
		// RVA: 0x00134330 File Offset: 0x00132530
		internal static void smethod_28()
		{
			if (Class62.bool_12 && Class341.class606_43)
			{
				Class800.smethod_45();
				return;
			}
			if (Class114.bool_0 && Class115.osuModes_1 != OsuModes.Edit && Class115.osuModes_1 != OsuModes.Menu)
			{
				if (Class800.smethod_7() == 1 && Class800.buttonState_6 != Class800.smethod_7())
				{
					Class570.smethod_6(27);
				}
				Class800.buttonState_6 = Class800.smethod_7();
				if (Class800.smethod_9() == 1 && Class800.buttonState_5 != Class800.smethod_9())
				{
					Class570.smethod_6(Class795.smethod_3(Bindings.Skip));
				}
				Class800.buttonState_5 = Class800.smethod_9();
			}
		}

		// Token: 0x06002FAF RID: 12207
		// RVA: 0x000236FA File Offset: 0x000218FA
		internal static void smethod_29()
		{
			Class802.int_4 = Class115.int_1;
			Class802.smethod_33(Enum96.const_1);
		}

		// Token: 0x06002F94 RID: 12180
		// RVA: 0x00023603 File Offset: 0x00021803
		internal static ButtonState smethod_3()
		{
			return Class800.buttonState_8;
		}

		// Token: 0x06002FB0 RID: 12208
		// RVA: 0x0002370C File Offset: 0x0002190C
		internal static void smethod_30()
		{
			Class802.int_4 = Class115.int_1;
			Class802.smethod_33(Enum96.const_0);
		}

		// Token: 0x06002FB1 RID: 12209
		// RVA: 0x0002371E File Offset: 0x0002191E
		internal static void smethod_31()
		{
			Class802.smethod_33(Enum96.const_3);
			Class802.bool_2 = true;
		}

		// Token: 0x06002FB2 RID: 12210
		// RVA: 0x001343C0 File Offset: 0x001325C0
		internal static void smethod_32()
		{
			if (Class341.class606_23 && (Class115.osuModes_1 != OsuModes.Play || !Class876.smethod_5(Mods.Cinema)) && (Class62.class62_0 == null || !Class62.class62_0.vmethod_5()))
			{
				Class731 class = Class885.Load("cursor-ripple", Enum112.flag_6);
				if (class == null)
				{
					class = Class885.Load("menu-osu-shockwave", Enum112.flag_1);
				}
				Class531 class2 = new Class531(class, Enum115.const_4, Origins.Centre, Enum114.const_0, Class802.vector2_0, 0.2f, false, Color.get_White(), null);
				class2.bool_7 = true;
				class2.float_3 = 0.2f;
				class2.method_16(700, Enum70.const_0);
				class2.class26_0.Add(new Class746(TransformationType.Scale, 0.05f, 0.5f, Class115.int_1, Class115.int_1 + 700, Enum70.const_1));
				Class115.class911_2.Add(class2);
			}
			Class802.smethod_33(Enum96.const_7);
		}

		// Token: 0x06002FB3 RID: 12211
		// RVA: 0x0002372C File Offset: 0x0002192C
		internal static void smethod_33()
		{
			if (Class800.bool_4)
			{
				Class911.class531_0 = null;
				Class809.smethod_38();
			}
			Class911.smethod_7(false);
			Class802.smethod_33(Enum96.const_8);
		}

		// Token: 0x06002FB4 RID: 12212
		// RVA: 0x0002374C File Offset: 0x0002194C
		internal static void smethod_34()
		{
			Class911.smethod_7(true);
		}

		// Token: 0x06002FB5 RID: 12213
		// RVA: 0x00023754 File Offset: 0x00021954
		internal static void smethod_35()
		{
			Class802.smethod_33(Enum96.const_6);
			Class911.smethod_6();
		}

		// Token: 0x06002FB6 RID: 12214
		// RVA: 0x00023761 File Offset: 0x00021961
		internal static void smethod_36()
		{
			Class802.smethod_33(Enum96.const_5);
			Class802.int_0 = 0;
		}

		// Token: 0x06002FB7 RID: 12215
		// RVA: 0x0002376F File Offset: 0x0002196F
		internal static void smethod_37()
		{
			Class802.smethod_33(Enum96.const_2);
			Class802.bool_2 = false;
		}

		// Token: 0x06002FB8 RID: 12216
		// RVA: 0x0013449C File Offset: 0x0013269C
		public static pButtonState smethod_38(bool bool_8, bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			pButtonState pButtonState = pButtonState.None;
			if (bool_8)
			{
				pButtonState |= pButtonState.Left1;
			}
			if (bool_9)
			{
				pButtonState |= pButtonState.Left2;
			}
			if (bool_10)
			{
				pButtonState |= pButtonState.Right1;
			}
			if (bool_11)
			{
				pButtonState |= pButtonState.Right2;
			}
			if (bool_12)
			{
				pButtonState |= pButtonState.Smoke;
			}
			return pButtonState;
		}

		// Token: 0x06002FB9 RID: 12217
		// RVA: 0x0002377D File Offset: 0x0002197D
		private static void smethod_39(object sender, EventArgs e)
		{
			Class800.smethod_2(0);
			Class800.smethod_4(0);
			Class800.smethod_6(0);
			Class800.smethod_8(0);
			Class800.smethod_10(0);
		}

		// Token: 0x06002F95 RID: 12181
		// RVA: 0x0002360A File Offset: 0x0002180A
		internal static void smethod_4(ButtonState buttonState_12)
		{
			if (buttonState_12 == 1)
			{
				Class800.buttonState_8 = buttonState_12;
			}
			Class800.buttonState_4 = buttonState_12;
		}

		// Token: 0x06002FBA RID: 12218
		// RVA: 0x0002379D File Offset: 0x0002199D
		private static void smethod_40(object sender, MouseEventArgs e)
		{
			Class800.int_2 += e.Delta;
		}

		// Token: 0x06002FBB RID: 12219
		// RVA: 0x001344D4 File Offset: 0x001326D4
		private static void smethod_41(object sender, MouseEventArgs e)
		{
			MouseButtons button = e.Button;
			if (button <= MouseButtons.Right)
			{
				if (button == MouseButtons.Left)
				{
					Class800.smethod_2(0);
					return;
				}
				if (button != MouseButtons.Right)
				{
					return;
				}
				Class800.smethod_4(0);
				return;
			}
			else
			{
				if (button == MouseButtons.Middle)
				{
					Class800.smethod_6(0);
					return;
				}
				if (button == MouseButtons.XButton1)
				{
					Class800.smethod_8(0);
					return;
				}
				if (button != MouseButtons.XButton2)
				{
					return;
				}
				Class800.smethod_10(0);
				return;
			}
		}

		// Token: 0x06002FBC RID: 12220
		// RVA: 0x0013453C File Offset: 0x0013273C
		private static void smethod_42(object sender, MouseEventArgs e)
		{
			MouseButtons button = e.Button;
			if (button <= MouseButtons.Right)
			{
				if (button == MouseButtons.Left)
				{
					Class800.smethod_2(1);
					return;
				}
				if (button != MouseButtons.Right)
				{
					return;
				}
				Class800.smethod_4(1);
				return;
			}
			else
			{
				if (button == MouseButtons.Middle)
				{
					Class800.smethod_6(1);
					return;
				}
				if (button == MouseButtons.XButton1)
				{
					Class800.smethod_8(1);
					return;
				}
				if (button != MouseButtons.XButton2)
				{
					return;
				}
				Class800.smethod_10(1);
				return;
			}
		}

		// Token: 0x06002FBD RID: 12221
		// RVA: 0x001345A4 File Offset: 0x001327A4
		internal static bool smethod_43()
		{
			if (Class800.buttonState_7 == Class800.buttonState_2 && Class800.buttonState_8 == Class800.buttonState_4 && Class800.buttonState_9 == Class800.buttonState_3 && Class800.buttonState_10 == Class800.buttonState_0)
			{
				if (Class800.buttonState_11 == Class800.buttonState_1)
				{
					return false;
				}
			}
			Class800.buttonState_7 = Class800.buttonState_2;
			Class800.buttonState_8 = Class800.buttonState_4;
			Class800.buttonState_9 = Class800.buttonState_3;
			Class800.buttonState_10 = Class800.buttonState_0;
			Class800.buttonState_11 = Class800.buttonState_1;
			return true;
		}

		// Token: 0x06002FBE RID: 12222
		// RVA: 0x000237B0 File Offset: 0x000219B0
		internal static void smethod_44()
		{
			if (Class800.int_2 == 0)
			{
				return;
			}
			if (Class800.int_2 > 0)
			{
				Class800.smethod_29();
			}
			else
			{
				Class800.smethod_30();
			}
			Class800.int_2 = 0;
		}

		// Token: 0x06002FBF RID: 12223
		// RVA: 0x000237D4 File Offset: 0x000219D4
		internal static void smethod_45()
		{
			Class800.buttonState_7 = 0;
			Class800.buttonState_2 = 0;
			Class800.buttonState_8 = 0;
			Class800.buttonState_4 = 0;
			Class800.buttonState_9 = 0;
			Class800.buttonState_3 = 0;
		}

		// Token: 0x06002FC0 RID: 12224
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_46(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x06002F96 RID: 12182
		// RVA: 0x0002361C File Offset: 0x0002181C
		internal static ButtonState smethod_5()
		{
			return Class800.buttonState_9;
		}

		// Token: 0x06002F97 RID: 12183
		// RVA: 0x00023623 File Offset: 0x00021823
		internal static void smethod_6(ButtonState buttonState_12)
		{
			if (buttonState_12 == 1)
			{
				Class800.buttonState_9 = buttonState_12;
			}
			Class800.buttonState_3 = buttonState_12;
		}

		// Token: 0x06002F98 RID: 12184
		// RVA: 0x00023635 File Offset: 0x00021835
		internal static ButtonState smethod_7()
		{
			return Class800.buttonState_10;
		}

		// Token: 0x06002F99 RID: 12185
		// RVA: 0x0002363C File Offset: 0x0002183C
		internal static void smethod_8(ButtonState buttonState_12)
		{
			if (buttonState_12 == 1)
			{
				Class800.buttonState_10 = buttonState_12;
			}
			Class800.buttonState_0 = buttonState_12;
		}

		// Token: 0x06002F9A RID: 12186
		// RVA: 0x0002364E File Offset: 0x0002184E
		internal static ButtonState smethod_9()
		{
			return Class800.buttonState_11;
		}
	}
}
