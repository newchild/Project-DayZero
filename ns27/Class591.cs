using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns77;
using ns79;
using ns8;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x0200048C RID: 1164
	internal sealed class Class591
	{
		// Token: 0x04001F11 RID: 7953
		private bool bool_0;

		// Token: 0x04001F0E RID: 7950
		private Class531 class531_0;

		// Token: 0x04001F0F RID: 7951
		private Class531 class531_1;

		// Token: 0x04001F0C RID: 7948
		private Class533 class533_0;

		// Token: 0x04001F0D RID: 7949
		private Class534 class534_0;

		// Token: 0x04001F0A RID: 7946
		private Color color_0;

		// Token: 0x04001F0B RID: 7947
		private Color color_1;

		// Token: 0x04001F10 RID: 7952
		private EventHandler eventHandler_0;

		// Token: 0x04001F09 RID: 7945
		private float float_0;

		// Token: 0x04001F08 RID: 7944
		internal List<Class531> list_0;

		// Token: 0x06002577 RID: 9591
		// RVA: 0x000E1C5C File Offset: 0x000DFE5C
		public Class591(EventHandler eventHandler_1, bool bool_1, bool bool_2)
		{
			VoidDelegate voidDelegate = null;
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			this.list_0 = new List<Class531>();
			this.color_0 = new Color(238, 51, 153);
			this.color_1 = new Color(187, 17, 119);
			base..ctor();
			this.eventHandler_0 = eventHandler_1;
			Class731[] array = null;
			if (bool_1)
			{
				array = Class885.smethod_27("menu-back", Enum112.flag_5, true);
			}
			if (array != null && array.Length > 0)
			{
				Class538 class = new Class538(array, Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2(0f, 480f), 0.9f, true, Color.get_White());
				class.method_61();
				class.bool_11 = true;
				this.list_0.Add(class);
				Class538 class2 = new Class538(array, Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2(0f, 480f), 0.91f, true, Color.get_White());
				if (bool_2)
				{
					class2.method_25(0f, 0, Enum70.const_0);
				}
				class2.float_3 = 0.01f;
				class2.method_61();
				class2.method_2(new EventHandler(this.method_2));
				class2.bool_1 = true;
				class2.bool_11 = true;
				class2.bool_7 = true;
				class2.class746_1 = new Class746(TransformationType.Fade, 0.003921569f, 0.4f, 0, 250, Enum70.const_0);
				this.list_0.Add(class2);
				return;
			}
			this.list_0.Add(this.class533_0 = new Class533(Class41.GetString(OsuString.General_Back).ToLower(), 15f, new Vector2(0f, 21f), 0.91f, true, Color.get_White())
			{
				enum115_0 = Enum115.const_11,
				origins_0 = Origins.Centre,
				bool_11 = true
			});
			float x = this.class533_0.vmethod_11().X;
			if (x > 38f)
			{
				this.float_0 = x - 38f;
			}
			this.list_0.Add(this.class531_0 = new Class531(Class885.Load("back-button-layer", Enum112.flag_1), Enum115.const_11, Origins.BottomRight, Enum114.const_0, new Vector2(0f, 0f), 0.91f, true, this.color_0, null)
			{
				bool_11 = true
			});
			this.list_0.Add(this.class534_0 = new Class534(FontAwesome.chevron_circle_left, 18f, new Vector2(0f, 21f))
			{
				float_0 = 0.92f,
				enum115_0 = Enum115.const_11
			});
			Class531 arg_285_0 = this.class534_0;
			if (voidDelegate == null)
			{
				voidDelegate = new VoidDelegate(this.method_3);
			}
			arg_285_0.method_30(voidDelegate);
			this.list_0.Add(this.class531_1 = new Class531(Class885.Load("back-button-layer", Enum112.flag_1), Enum115.const_11, Origins.BottomRight, Enum114.const_0, new Vector2(0f, 0f), 0.9f, true, this.color_0, null)
			{
				bool_1 = true,
				bool_11 = true
			});
			Class530 arg_2FF_0 = this.class531_1;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_4);
			}
			arg_2FF_0.method_2(eventHandler);
			Class531 arg_31E_0 = this.class531_1;
			if (eventHandler2 == null)
			{
				eventHandler2 = new EventHandler(this.method_5);
			}
			arg_31E_0.method_35(eventHandler2);
			Class531 arg_33D_0 = this.class531_1;
			if (eventHandler3 == null)
			{
				eventHandler3 = new EventHandler(this.method_6);
			}
			arg_33D_0.method_37(eventHandler3);
			this.method_1(Enum70.const_25, 0);
		}

		// Token: 0x06002578 RID: 9592
		// RVA: 0x000E1FB4 File Offset: 0x000E01B4
		private void method_0(Enum70 enum70_0, int int_0)
		{
			this.bool_0 = true;
			this.class531_0.method_19(new Vector2(40f, this.class531_0.vector2_1.Y), int_0, enum70_0);
			this.class534_0.method_19(new Vector2(16.666666f, this.class534_0.vector2_1.Y), int_0, enum70_0);
			this.class531_1.method_19(new Vector2(86f + this.float_0, this.class531_1.vector2_1.Y), int_0, enum70_0);
			this.class533_0.method_19(new Vector2((86f + this.float_0 - 40f) / 2.4f + 40f, this.class533_0.vector2_1.Y), int_0, enum70_0);
			this.class531_0.method_39(this.color_1, int_0, false, enum70_0);
		}

		// Token: 0x06002579 RID: 9593
		// RVA: 0x000E20A0 File Offset: 0x000E02A0
		private void method_1(Enum70 enum70_0, int int_0)
		{
			this.bool_0 = false;
			this.class531_0.method_19(new Vector2(22f, this.class531_0.vector2_1.Y), int_0, enum70_0);
			this.class534_0.method_19(new Vector2(9.166666f, this.class534_0.vector2_1.Y), int_0, enum70_0);
			this.class531_1.method_19(new Vector2(60f + this.float_0, this.class531_1.vector2_1.Y), int_0, enum70_0);
			this.class533_0.method_19(new Vector2((60f + this.float_0 - 22f) / 2.4f + 22f, this.class533_0.vector2_1.Y), int_0, enum70_0);
			this.class531_0.method_39(this.color_0, int_0, false, enum70_0);
		}

		// Token: 0x0600257A RID: 9594
		// RVA: 0x0001D251 File Offset: 0x0001B451
		private void method_2(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x0600257B RID: 9595
		// RVA: 0x000E218C File Offset: 0x000E038C
		[CompilerGenerated]
		private void method_3()
		{
			if (Class331.bool_0)
			{
				this.class534_0.float_2 = (this.bool_0 ? 1.5f : 0.9f);
				Class746 class = this.class534_0.method_26(1f, (int)Class331.smethod_8() * 3, Enum70.const_25);
				if (class != null)
				{
					class.int_0 -= (int)Class331.smethod_8() / 4;
					class.int_1 -= (int)Class331.smethod_8() / 4;
				}
			}
		}

		// Token: 0x0600257C RID: 9596
		// RVA: 0x0001D268 File Offset: 0x0001B468
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_2(this, null);
			this.method_1(Enum70.const_31, 400);
		}

		// Token: 0x0600257D RID: 9597
		// RVA: 0x0001D27F File Offset: 0x0001B47F
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.method_0(Enum70.const_25, 600);
		}

		// Token: 0x0600257E RID: 9598
		// RVA: 0x0001D28E File Offset: 0x0001B48E
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			this.method_1(Enum70.const_25, 600);
		}
	}
}
