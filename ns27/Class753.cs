using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns26;
using ns29;
using ns79;
using ns80;
using ns81;
using ns82;
using ns84;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x02000593 RID: 1427
	internal sealed class Class753
	{
		// Token: 0x04002639 RID: 9785
		[CompilerGenerated]
		private static Action<Class533> action_0;

		// Token: 0x04002625 RID: 9765
		internal bool bool_0;

		// Token: 0x0400262F RID: 9775
		private bool bool_1;

		// Token: 0x04002631 RID: 9777
		private bool bool_2 = true;

		// Token: 0x04002638 RID: 9784
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400262B RID: 9771
		internal Class533 class533_0;

		// Token: 0x04002637 RID: 9783
		private Class533 class533_1;

		// Token: 0x0400262A RID: 9770
		private Class534 class534_0;

		// Token: 0x04002627 RID: 9767
		internal Class911 class911_0;

		// Token: 0x04002622 RID: 9762
		private static Color color_0 = new Color(0, 0, 0, 240);

		// Token: 0x0400262C RID: 9772
		internal Color color_1 = Class885.color_2;

		// Token: 0x04002623 RID: 9763
		private EventHandler eventHandler_0;

		// Token: 0x04002624 RID: 9764
		private EventHandler eventHandler_1;

		// Token: 0x04002632 RID: 9778
		private float float_0;

		// Token: 0x04002633 RID: 9779
		private float float_1;

		// Token: 0x04002626 RID: 9766
		internal int int_0;

		// Token: 0x04002630 RID: 9776
		private int int_1;

		// Token: 0x04002636 RID: 9782
		internal int int_2;

		// Token: 0x04002628 RID: 9768
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04002629 RID: 9769
		internal List<Class533> list_1 = new List<Class533>();

		// Token: 0x04002634 RID: 9780
		internal object object_0;

		// Token: 0x04002635 RID: 9781
		internal string string_0;

		// Token: 0x0400262D RID: 9773
		private Vector2 vector2_0;

		// Token: 0x0400262E RID: 9774
		private Vector2 vector2_1;

		// Token: 0x06002D91 RID: 11665
		// RVA: 0x000226FD File Offset: 0x000208FD
		internal Class753(Class911 class911_1, string string_1, Vector2 vector2_2) : this(class911_1, string_1, vector2_2, 118f, 0.98f, false, false)
		{
		}

		// Token: 0x06002D92 RID: 11666
		// RVA: 0x00022714 File Offset: 0x00020914
		internal Class753(Class911 class911_1, string string_1, Vector2 vector2_2, float float_2, float float_3) : this(class911_1, string_1, vector2_2, float_2, float_3, false, false)
		{
		}

		// Token: 0x06002D93 RID: 11667
		// RVA: 0x00128204 File Offset: 0x00126404
		internal Class753(Class911 class911_1, string string_1, Vector2 vector2_2, float float_2, float float_3, bool bool_4, bool bool_5)
		{
			this.class911_0 = class911_1;
			this.float_0 = float_2;
			this.bool_1 = bool_4;
			this.bool_0 = bool_5;
			this.vector2_0 = vector2_2;
			this.float_1 = float_3;
			this.method_13(0);
			this.class533_0 = new Class533(string_1, 13f, vector2_2, new Vector2(float_2 + 2f, 15f), float_3 + 0.001f, true, Color.get_White(), false);
			this.class533_0.method_53(new Color(0, 0, 0, 128));
			this.class533_0.vector4_0 = Vector4.get_One() * 5f;
			this.class533_0.enum72_0 = (this.bool_0 ? Enum72.const_2 : Enum72.const_1);
			this.class533_0.method_58(true);
			this.class533_0.method_35(new EventHandler(this.method_17));
			this.class533_0.method_37(new EventHandler(this.method_16));
			this.class533_0.bool_1 = true;
			this.class533_0.method_2(new EventHandler(this.method_14));
			this.list_0.Add(this.class533_0);
			this.class534_0 = new Class534(FontAwesome.chevron_down, 14f, new Vector2(vector2_2.X + float_2 - 8f, vector2_2.Y + 8f))
			{
				float_0 = float_3 + 0.002f
			};
			this.list_0.Add(this.class534_0);
			if (class911_1 != null)
			{
				class911_1.Add<Class531>(this.list_0);
			}
		}

		// Token: 0x06002D98 RID: 11672
		// RVA: 0x0012882C File Offset: 0x00126A2C
		private void Close()
		{
			if (this.method_2() && Class115.int_1 - this.int_1 >= 100)
			{
				this.method_3(false);
				Class802.smethod_35(Enum96.const_8, new Delegate46(this.method_5), Enum98.const_8);
				Class802.smethod_35(Enum96.const_6, new Delegate46(this.method_6), Enum98.const_8);
				int num = 0;
				foreach (Class531 current in this.list_1)
				{
					bool flag;
					if (flag = (current is Class534))
					{
						current.method_16(0, Enum70.const_0);
					}
					else
					{
						current.method_19(this.class533_0.vector2_1 + (flag ? new Vector2(6f, 9f) : Vector2.get_Zero()), 200 + num * 10, Enum70.const_2);
						current.method_16(100 + num++ * 10, Enum70.const_0);
					}
				}
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, null);
				}
				Class115.class47_0.method_1(new VoidDelegate(this.method_20), 100 + num * 10, false);
				return;
			}
		}

		// Token: 0x06002D8D RID: 11661
		// RVA: 0x00128194 File Offset: 0x00126394
		internal void method_0(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002D8E RID: 11662
		// RVA: 0x001281CC File Offset: 0x001263CC
		internal void method_1(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002D9B RID: 11675
		// RVA: 0x00022751 File Offset: 0x00020951
		internal Class531 method_10(string string_1, object object_1, Color color_2)
		{
			return this.method_11(string_1, object_1, 0, color_2, true);
		}

		// Token: 0x06002D9C RID: 11676
		// RVA: 0x00128960 File Offset: 0x00126B60
		internal Class531 method_11(string string_1, object object_1, int int_3, Color color_2, bool bool_4)
		{
			Class533 class = new Class533(string_1, this.class533_0.method_60() - 1f, this.vector2_1, new Vector2(this.float_0 + 2f, 17f), this.float_1 + 0.003f, true, Color.get_TransparentWhite(), true);
			class.enum72_0 = (this.bool_0 ? Enum72.const_2 : Enum72.const_1);
			Class534 class2 = new Class534(FontAwesome.chevron_right, 10f, this.vector2_1 + new Vector2(6f, 9f));
			class2.float_0 = this.float_1 + 0.004f;
			class2.color_0 = Color.get_TransparentBlack();
			class2.float_3 = 0f;
			class2.method_58(false);
			Class533 class3 = class2;
			class.method_53(color_2);
			class.vector2_10 = new Vector2(12f, 3f);
			class.method_8(true);
			class3.method_8(true);
			if (bool_4)
			{
				class.bool_1 = true;
				class.bool_2 = true;
				if (object_1 != null)
				{
					class.method_2(new EventHandler(this.method_14));
					class.method_35(new EventHandler(this.method_17));
					class.method_37(new EventHandler(this.method_16));
				}
				class.object_0 = object_1;
				class.int_0 = int_3;
				class.float_4 = -1000f;
			}
			this.list_1.Add(class);
			this.list_1.Add(class3);
			this.list_0.Add(class);
			this.list_0.Add(class3);
			if (this.class911_0 != null)
			{
				this.class911_0.Add(class);
				this.class911_0.Add(class3);
			}
			return class;
		}

		// Token: 0x06002D9D RID: 11677
		// RVA: 0x00128B04 File Offset: 0x00126D04
		internal void method_12()
		{
			while (this.list_1.Count > 0)
			{
				Class533 class = this.list_1[0];
				this.list_1.Remove(class);
				this.list_0.Remove(class);
				if (this.class911_0 != null)
				{
					this.class911_0.Remove(class);
				}
				class.Dispose();
			}
			this.method_13(0);
			this.int_2 = 0;
			this.object_0 = null;
			this.string_0 = null;
		}

		// Token: 0x06002D9E RID: 11678
		// RVA: 0x00128B80 File Offset: 0x00126D80
		private void method_13(int int_3)
		{
			if (this.bool_1)
			{
				this.vector2_1 = this.vector2_0 + new Vector2(this.float_0 * (float)int_3, 2f);
				return;
			}
			this.vector2_1 = this.vector2_0 + new Vector2(this.float_0 * (float)int_3, 17f);
		}

		// Token: 0x06002D9F RID: 11679
		// RVA: 0x0002275E File Offset: 0x0002095E
		private void method_14(object sender, EventArgs e)
		{
			this.method_15(sender, false);
		}

		// Token: 0x06002DA0 RID: 11680
		// RVA: 0x00128BE0 File Offset: 0x00126DE0
		private void method_15(object object_1, bool bool_4)
		{
			if (object_1 == null)
			{
				object_1 = this.class533_0;
			}
			Class533 class = (Class533)object_1;
			if (class == this.class533_0)
			{
				if (this.method_2())
				{
					this.Close();
					return;
				}
				this.method_7();
				return;
			}
			else
			{
				this.Close();
				if (class.Text != this.class533_0.Text)
				{
					this.class533_0.bool_18 = true;
				}
				if (this.class533_1 != null && class != this.class533_0)
				{
					this.class533_1.bool_16 = false;
					this.class533_1.bool_18 = true;
				}
				if (class != null)
				{
					class.bool_16 = true;
					this.class533_0.object_0 = class.object_0;
				}
				if (class.object_0 == null)
				{
					return;
				}
				this.object_0 = class.object_0;
				this.string_0 = class.Text;
				this.int_2 = class.int_0;
				if (class != this.class533_0)
				{
					this.class533_1 = class;
				}
				this.class533_0.Text = (string.IsNullOrEmpty(class.Text) ? " " : class.Text);
				if (!bool_4)
				{
					Class331.smethod_36(null, "click-short-confirm", 1f, false);
				}
				if (class.object_0 is Color)
				{
					Color color_ = (Color)class.object_0;
					if (color_.get_A() < 1)
					{
						this.class533_0.method_53(Color.get_Black());
					}
					else
					{
						this.class533_0.method_53(color_);
					}
				}
				if (class.object_0 != null && class != this.class533_0 && !bool_4 && this.eventHandler_0 != null)
				{
					this.eventHandler_0(class.object_0, null);
				}
				return;
			}
		}

		// Token: 0x06002DA1 RID: 11681
		// RVA: 0x00128D7C File Offset: 0x00126F7C
		private void method_16(object sender, EventArgs e)
		{
			Class533 class = sender as Class533;
			if (class != null)
			{
				if (class.object_0 is Color)
				{
					class.method_53(Class610.smethod_2(class.method_52(), 0.1f));
				}
				else if (class == this.class533_0)
				{
					class.method_53(new Color(0, 0, 0, 128));
				}
				else
				{
					class.method_53(Class753.color_0);
				}
				class.bool_18 = true;
			}
		}

		// Token: 0x06002DA2 RID: 11682
		// RVA: 0x00128DE8 File Offset: 0x00126FE8
		private void method_17(object sender, EventArgs e)
		{
			Class533 class = sender as Class533;
			if (class != null)
			{
				if (class.object_0 is Color)
				{
					class.method_53(Class610.smethod_0(class.method_52(), 0.1f));
				}
				else
				{
					class.method_53(this.color_1);
				}
				Class331.smethod_36(null, "click-short", 1f, false);
				class.bool_18 = true;
			}
		}

		// Token: 0x06002DA3 RID: 11683
		// RVA: 0x00128E50 File Offset: 0x00127050
		public bool method_18(object object_1, bool bool_4)
		{
			Class531 class = this.method_19(object_1);
			if (class != null)
			{
				this.method_15(class, bool_4);
				return true;
			}
			return false;
		}

		// Token: 0x06002DA4 RID: 11684
		// RVA: 0x00128E74 File Offset: 0x00127074
		public Class531 method_19(object object_1)
		{
			foreach (Class531 current in this.list_1)
			{
				if (current.object_0 != null && current.object_0.Equals(object_1))
				{
					return current;
				}
			}
			return null;
		}

		// Token: 0x06002D8F RID: 11663
		// RVA: 0x000226EC File Offset: 0x000208EC
		[CompilerGenerated]
		internal bool method_2()
		{
			return this.bool_3;
		}

		// Token: 0x06002DA5 RID: 11685
		// RVA: 0x00022768 File Offset: 0x00020968
		[CompilerGenerated]
		private void method_20()
		{
			if (!this.method_2())
			{
				List<Class533> arg_2B_0 = this.list_1;
				if (Class753.action_0 == null)
				{
					Class753.action_0 = new Action<Class533>(Class753.smethod_0);
				}
				arg_2B_0.ForEach(Class753.action_0);
			}
		}

		// Token: 0x06002D90 RID: 11664
		// RVA: 0x000226F4 File Offset: 0x000208F4
		[CompilerGenerated]
		private void method_3(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x06002D94 RID: 11668
		// RVA: 0x001283C8 File Offset: 0x001265C8
		public void method_4(bool bool_4)
		{
			if (this.bool_2 == bool_4)
			{
				return;
			}
			if (this.bool_2)
			{
				this.Close();
			}
			this.bool_2 = bool_4;
			if (!this.bool_2)
			{
				this.class533_0.vmethod_2(false);
			}
			this.class533_0.bool_1 = this.bool_2;
			this.class533_0.method_53(this.bool_2 ? Color.get_Black() : Color.get_DarkGray());
			this.class533_0.bool_18 = true;
		}

		// Token: 0x06002D95 RID: 11669
		// RVA: 0x00128444 File Offset: 0x00126644
		private bool method_5(object object_1, EventArgs eventArgs_0)
		{
			if (!Class800.bool_4)
			{
				return false;
			}
			foreach (Class531 current in this.list_1)
			{
				if (current.vmethod_1())
				{
					bool result = false;
					return result;
				}
			}
			if (this.class533_0.vmethod_1())
			{
				return false;
			}
			this.Close();
			return true;
		}

		// Token: 0x06002D96 RID: 11670
		// RVA: 0x001284C0 File Offset: 0x001266C0
		private bool method_6(object object_1, EventArgs eventArgs_0)
		{
			Class802.smethod_35(Enum96.const_6, new Delegate46(this.method_6), Enum98.const_8);
			if (!this.method_2())
			{
				return false;
			}
			if (this.class911_0 != null && this.class911_0.class531_1 != null && this.class911_0.class531_1 != this.class533_0)
			{
				this.class911_0.class531_1.method_0(true);
				return true;
			}
			return false;
		}

		// Token: 0x06002D97 RID: 11671
		// RVA: 0x00128528 File Offset: 0x00126728
		private void method_7()
		{
			if (!this.method_2() && this.bool_2)
			{
				this.method_3(true);
				this.int_1 = Class115.int_1;
				Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_5), Enum98.const_8, Enum97.const_2);
				Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_6), Enum98.const_8, Enum97.const_2);
				Class331.smethod_36(null, "select-expand", 1f, false);
				if (this.list_1.Count > 0)
				{
					if (this.bool_1)
					{
						this.list_1[0].vector4_0.X = 5f;
						this.list_1[0].vector4_0.Y = 5f;
						this.list_1[this.list_1.Count - 2].vector4_0.Z = 5f;
						this.list_1[this.list_1.Count - 2].vector4_0.W = 5f;
					}
					else
					{
						this.list_1[0].vector4_0.Z = 5f;
						this.list_1[0].vector4_0.W = 5f;
						this.list_1[this.list_1.Count - 2].vector4_0.X = 5f;
						this.list_1[this.list_1.Count - 2].vector4_0.Y = 5f;
					}
				}
				int num = 0;
				Vector2 vector;
				vector..ctor(0f, 0f);
				foreach (Class533 current in this.list_1)
				{
					bool flag;
					if (!(flag = (current is Class534)))
					{
						vector.Y += (float)(this.bool_1 ? -1 : 1) * current.vmethod_11().Y + (this.bool_1 ? 0.5f : -0.5f);
					}
					int num2 = Class115.int_1 + num * 10;
					current.method_8(false);
					current.class26_0.Clear();
					current.vector2_1 = this.class533_0.vector2_1 + (flag ? new Vector2(6f, 9f) : Vector2.get_Zero());
					current.method_19(current.vector2_1 + vector, ((num > 0) ? 200 : 0) + num * 10, Enum70.const_22);
					current.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num2, num2 + 200, Enum70.const_1));
					num++;
				}
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, null);
				}
				return;
			}
		}

		// Token: 0x06002D99 RID: 11673
		// RVA: 0x00022725 File Offset: 0x00020925
		internal Class531 method_8(Class557 class557_0)
		{
			return this.method_11(class557_0.string_0, class557_0.object_0, 0, Class753.color_0, true);
		}

		// Token: 0x06002D9A RID: 11674
		// RVA: 0x00022740 File Offset: 0x00020940
		internal Class531 method_9(string string_1, object object_1)
		{
			return this.method_11(string_1, object_1, 0, Class753.color_0, true);
		}

		// Token: 0x06002DA6 RID: 11686
		// RVA: 0x0001B778 File Offset: 0x00019978
		[CompilerGenerated]
		private static void smethod_0(Class533 class533_2)
		{
			class533_2.method_8(true);
		}
	}
}
