using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200059C RID: 1436
	internal sealed class Class760
	{
		// Token: 0x0200059D RID: 1437
		[CompilerGenerated]
		private sealed class Class761
		{
			// Token: 0x0400268C RID: 9868
			public string string_0;

			// Token: 0x06002E25 RID: 11813
			// RVA: 0x00022D8F File Offset: 0x00020F8F
			public void method_0(Class531 class531_0)
			{
				class531_0.string_0 = this.string_0;
			}
		}

		// Token: 0x04002689 RID: 9865
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x0400268A RID: 9866
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x0400268B RID: 9867
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04002686 RID: 9862
		public bool bool_0 = true;

		// Token: 0x04002688 RID: 9864
		private bool bool_1;

		// Token: 0x04002685 RID: 9861
		internal Class533 class533_0;

		// Token: 0x04002683 RID: 9859
		private Color color_0;

		// Token: 0x04002684 RID: 9860
		private Color color_1;

		// Token: 0x04002687 RID: 9863
		private EventHandler eventHandler_0;

		// Token: 0x04002682 RID: 9858
		internal List<Class531> list_0;

		// Token: 0x06002E18 RID: 11800
		// RVA: 0x0012B080 File Offset: 0x00129280
		internal Class760(string string_0, Vector2 vector2_0, Vector2 vector2_1, float float_0, Color color_2, EventHandler eventHandler_1, bool bool_2, bool bool_3, float? nullable_0)
		{
			this.method_6(color_2);
			if (eventHandler_1 != null)
			{
				this.method_0(eventHandler_1);
			}
			this.list_0 = new List<Class531>();
			int num = bool_3 ? -1 : 1;
			Class533 class = new Class533(string_0, nullable_0.HasValue ? nullable_0.Value : (14f * vector2_1.Y / 18f / (float)((string_0.IndexOf('\n') > 0) ? 2 : 1)), vector2_0, float_0 + 0.002f, true, Color.get_White());
			class.method_62("Aller");
			this.class533_0 = class;
			if (bool_3)
			{
				this.class533_0.enum115_0 = Enum115.const_7;
			}
			this.class533_0.origins_0 = Origins.Centre;
			float x = this.class533_0.vmethod_11().X;
			if (x > vector2_1.X)
			{
				vector2_1.X = x;
			}
			this.class533_0.vector2_0 += new Vector2(vector2_1.X * (float)num, vector2_1.Y) / 2f;
			this.class533_0.vector2_1 = this.class533_0.vector2_0;
			this.class533_0.vmethod_9();
			Class531 class2 = new Class531(bool_2 ? Class885.Load("button-left", Enum112.flag_5) : Class885.Load("button-left", Enum112.flag_1), bool_3 ? Enum115.const_7 : Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, float_0, true, this.color_1, this);
			class2.float_2 = vector2_1.Y / ((float)class2.int_1 * 0.625f);
			class2.bool_1 = true;
			class2.method_2(new EventHandler(this.method_1));
			class2.bool_2 = true;
			class2.method_35(new EventHandler(this.method_2));
			class2.method_37(new EventHandler(this.method_3));
			this.list_0.Add(class2);
			float num2 = (float)this.list_0[0].int_4 * 0.625f * this.list_0[0].float_2;
			class2 = new Class531(bool_2 ? Class885.Load("button-right", Enum112.flag_5) : Class885.Load("button-right", Enum112.flag_1), bool_3 ? Enum115.const_7 : Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0 + (float)num * new Vector2(vector2_1.X - num2, 0f), float_0, true, this.color_1, this);
			class2.float_2 = vector2_1.Y / ((float)class2.int_1 * 0.625f);
			class2.bool_1 = true;
			class2.method_2(new EventHandler(this.method_1));
			class2.bool_2 = true;
			class2.method_35(new EventHandler(this.method_2));
			class2.method_37(new EventHandler(this.method_3));
			this.list_0.Add(class2);
			class2 = new Class531(bool_2 ? Class885.Load("button-middle", Enum112.flag_5) : Class885.Load("button-middle", Enum112.flag_1), bool_3 ? Enum115.const_7 : Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0 + (float)num * new Vector2(num2, 0f), float_0 + 0.001f, true, this.color_1, this);
			class2.bool_1 = true;
			class2.method_2(new EventHandler(this.method_1));
			class2.bool_2 = true;
			class2.method_35(new EventHandler(this.method_2));
			class2.method_37(new EventHandler(this.method_3));
			if (class2.vmethod_6() != null)
			{
				class2.vector2_2 = new Vector2((vector2_1.X - num2 * 2f) / (float)class2.vmethod_6().method_0() * 1.6f, this.list_0[1].float_2);
			}
			this.list_0.Add(class2);
			this.list_0.Add(this.class533_0);
		}

		// Token: 0x06002E17 RID: 11799
		// RVA: 0x0012B048 File Offset: 0x00129248
		internal void method_0(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002E19 RID: 11801
		// RVA: 0x0012B444 File Offset: 0x00129644
		private void method_1(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
			if (this.bool_0)
			{
				Class331.smethod_59("click-short-confirm", 100, Enum112.flag_5);
			}
			List<Class531> arg_4E_0 = this.list_0;
			if (Class760.action_0 == null)
			{
				Class760.action_0 = new Action<Class531>(Class760.smethod_0);
			}
			arg_4E_0.ForEach(Class760.action_0);
		}

		// Token: 0x06002E1A RID: 11802
		// RVA: 0x0012B4A4 File Offset: 0x001296A4
		private void method_2(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.list_0[0].method_39(this.color_0, 50, true, Enum70.const_0);
			this.list_0[1].method_39(this.color_0, 50, true, Enum70.const_0);
			this.list_0[2].method_39(this.color_0, 50, true, Enum70.const_0);
			if (this.bool_0)
			{
				Class331.smethod_36(null, "click-short", 1f, false);
			}
		}

		// Token: 0x06002E1B RID: 11803
		// RVA: 0x00022CE4 File Offset: 0x00020EE4
		private void method_3(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_8), true);
		}

		// Token: 0x06002E1C RID: 11804
		// RVA: 0x00022CFD File Offset: 0x00020EFD
		public void method_4()
		{
			List<Class531> arg_23_0 = this.list_0;
			if (Class760.action_1 == null)
			{
				Class760.action_1 = new Action<Class531>(Class760.smethod_1);
			}
			arg_23_0.ForEach(Class760.action_1);
		}

		// Token: 0x06002E1D RID: 11805
		// RVA: 0x00022D27 File Offset: 0x00020F27
		public void method_5()
		{
			List<Class531> arg_23_0 = this.list_0;
			if (Class760.action_2 == null)
			{
				Class760.action_2 = new Action<Class531>(Class760.smethod_2);
			}
			arg_23_0.ForEach(Class760.action_2);
		}

		// Token: 0x06002E1E RID: 11806
		// RVA: 0x0012B538 File Offset: 0x00129738
		public void method_6(Color color_2)
		{
			this.color_0 = color_2;
			this.color_1 = new Color((byte)Math.Max(0, (int)(this.color_0.get_R() - 20)), (byte)Math.Max(0, (int)(this.color_0.get_G() - 20)), (byte)Math.Max(0, (int)(this.color_0.get_B() - 20)));
			if (this.list_0 != null && this.list_0.Count >= 3)
			{
				this.list_0[0].color_0 = this.color_1;
				this.list_0[1].color_0 = this.color_1;
				this.list_0[2].color_0 = this.color_1;
			}
		}

		// Token: 0x06002E1F RID: 11807
		// RVA: 0x0012B5F4 File Offset: 0x001297F4
		public void method_7(string string_0)
		{
			Class760.Class761 class = new Class760.Class761();
			class.string_0 = string_0;
			this.list_0.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002E21 RID: 11809
		// RVA: 0x0012B628 File Offset: 0x00129828
		[CompilerGenerated]
		private void method_8()
		{
			if (!this.list_0[0].vmethod_1() && !this.list_0[1].vmethod_1() && !this.list_0[2].vmethod_1())
			{
				this.list_0[0].method_39(this.color_1, 50, false, Enum70.const_0);
				this.list_0[1].method_39(this.color_1, 50, false, Enum70.const_0);
				this.list_0[2].method_39(this.color_1, 50, false, Enum70.const_0);
				this.bool_1 = false;
				return;
			}
		}

		// Token: 0x06002E20 RID: 11808
		// RVA: 0x00022D51 File Offset: 0x00020F51
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_0)
		{
			class531_0.method_40(Color.get_White(), 400);
		}

		// Token: 0x06002E22 RID: 11810
		// RVA: 0x00022D63 File Offset: 0x00020F63
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_0)
		{
			class531_0.bool_1 = false;
			class531_0.method_16(50, Enum70.const_0);
		}

		// Token: 0x06002E23 RID: 11811
		// RVA: 0x00022D75 File Offset: 0x00020F75
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_0)
		{
			if (!(class531_0 is Class533))
			{
				class531_0.bool_1 = true;
			}
			class531_0.method_14(50, Enum70.const_0);
		}
	}
}
