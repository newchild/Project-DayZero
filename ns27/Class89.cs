using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns29;
using ns6;
using ns64;
using ns77;
using ns79;
using ns82;
using ns84;
using ns9;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200039B RID: 923
	internal class Class89 : Class54
	{
		// Token: 0x040016AF RID: 5807
		[CompilerGenerated]
		private static Action<Class746> action_0;

		// Token: 0x040016B0 RID: 5808
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x040016A4 RID: 5796
		internal bool bool_1;

		// Token: 0x040016A5 RID: 5797
		internal bool bool_2;

		// Token: 0x040016A8 RID: 5800
		private bool bool_3;

		// Token: 0x040016AC RID: 5804
		private bool bool_4;

		// Token: 0x040016A7 RID: 5799
		private byte byte_0 = 235;

		// Token: 0x040016AD RID: 5805
		internal Class531 class531_0;

		// Token: 0x040016A6 RID: 5798
		internal Class911 class911_0 = new Class911(true)
		{
			bool_1 = false
		};

		// Token: 0x040016A9 RID: 5801
		private EventHandler eventHandler_2;

		// Token: 0x040016AA RID: 5802
		private EventHandler eventHandler_3;

		// Token: 0x040016A3 RID: 5795
		internal float float_0;

		// Token: 0x040016AB RID: 5803
		private List<Class531> list_0 = new List<Class531>();

		// Token: 0x040016AE RID: 5806
		internal Vector2 vector2_0;

		// Token: 0x06001C74 RID: 7284
		// RVA: 0x00098A6C File Offset: 0x00096C6C
		internal Class89(string string_0, bool bool_5) : base(Class115.class115_0)
		{
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.1f, true, new Color(0, 0, 0, this.byte_0), null);
			this.class531_0.vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25));
			this.class531_0.bool_1 = true;
			this.class911_0.Add(this.class531_0);
			this.bool_2 = bool_5;
			if (!string.IsNullOrEmpty(string_0))
			{
				Class533 class = new Class533(string_0, 24f, new Vector2(2f, 2f), new Vector2((float)(Class115.smethod_43() - 2), 0f), 0.92f, true, Color.get_White(), true);
				this.class911_0.Add(class);
				this.float_0 = class.vmethod_11().Y + class.vector2_1.Y + 50f;
			}
			this.vmethod_0();
		}

		// Token: 0x06001C7F RID: 7295
		// RVA: 0x00098F6C File Offset: 0x0009716C
		internal virtual void Close(bool bool_5)
		{
			if (!this.bool_1)
			{
				return;
			}
			using (List<Class530>.Enumerator enumerator = this.class911_0.list_2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					class.method_16(120, Enum70.const_0);
					class.bool_1 = false;
					class.bool_0 = false;
				}
			}
			if (bool_5 && this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, null);
			}
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
			if (this.bool_3 && this.vmethod_2())
			{
				Class111.smethod_21(true);
			}
			this.bool_1 = false;
			this.Dispose();
		}

		// Token: 0x06001C76 RID: 7286
		// RVA: 0x00017703 File Offset: 0x00015903
		public new void Dispose()
		{
			this.class911_0.Dispose();
			base.Dispose();
		}

		// Token: 0x06001C83 RID: 7299
		// RVA: 0x0001774C File Offset: 0x0001594C
		protected override void Dispose(bool bool_5)
		{
			if (this.bool_1)
			{
				this.Close(false);
			}
			this.eventHandler_2 = null;
			base.Dispose(bool_5);
		}

		// Token: 0x06001C78 RID: 7288
		// RVA: 0x00017724 File Offset: 0x00015924
		internal virtual void Draw()
		{
			if (!this.bool_1)
			{
				return;
			}
			this.class911_0.Draw();
		}

		// Token: 0x06001C81 RID: 7297
		// RVA: 0x00099034 File Offset: 0x00097234
		public override void imethod_2()
		{
			if (Class341.class606_4 && this.bool_1)
			{
				Class733.bool_1 = true;
				Class733.float_1 = 0.004f;
				Class733.bool_0 = false;
				Class733.bool_2 = true;
				Class733.bool_2 = false;
				Class733.float_0 = this.class911_0.list_2[0].float_3;
			}
			base.imethod_2();
		}

		// Token: 0x06001C80 RID: 7296
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void Initialize()
		{
		}

		// Token: 0x06001C79 RID: 7289
		// RVA: 0x0001773B File Offset: 0x0001593B
		internal int method_1()
		{
			if (!this.bool_1)
			{
				return 0;
			}
			return Class115.int_1;
		}

		// Token: 0x06001C7C RID: 7292
		// RVA: 0x00098CE0 File Offset: 0x00096EE0
		internal void method_2(EventHandler eventHandler_4)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_4);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001C7D RID: 7293
		// RVA: 0x00098D18 File Offset: 0x00096F18
		internal void method_3(string string_0, Color color_0, EventHandler eventHandler_4, bool bool_5, bool bool_6, bool bool_7)
		{
			Class760 class = new Class760(this.list_0.Count + 1 + ". " + string_0, new Vector2((float)(Class115.smethod_43() / 2 - 230 + (bool_7 ? 0 : 240)), this.float_0) + this.vector2_0, new Vector2((float)(bool_6 ? 220 : 460), 40f), 0.92f, color_0, eventHandler_4, this.bool_2, false, null);
			((Class533)class.list_0[3]).method_58(true);
			for (int i = 0; i < 4; i++)
			{
				Class531 class2 = class.list_0[i];
				if (i < 3 && bool_5)
				{
					class2.method_2(new EventHandler(this.method_4));
					class2.object_0 = class;
				}
				if (this.bool_1)
				{
					class2.method_15(140);
				}
				else
				{
					int num = this.list_0.Count * 60;
					class2.float_3 = 0f;
					class2.class26_0.Add(new Class746(class2.vector2_0 + new Vector2((float)(this.bool_4 ? -40 : 40), 0f), class2.vector2_0, num, num + 800, Enum70.const_33));
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num, num + 800, Enum70.const_1));
					class2.vector2_1 += new Vector2((float)(this.bool_4 ? -40 : 40), 0f);
				}
				this.class911_0.Add(class2);
			}
			this.list_0.Add(class.list_0[0]);
			this.bool_4 = !this.bool_4;
			this.float_0 += 50f;
		}

		// Token: 0x06001C7E RID: 7294
		// RVA: 0x00098F0C File Offset: 0x0009710C
		private void method_4(object sender, EventArgs e)
		{
			this.Close(false);
			Class531 class = sender as Class531;
			Class760 class2 = (class != null) ? (class.object_0 as Class760) : (sender as Class760);
			if (class2 != null)
			{
				List<Class531> arg_4B_0 = class2.list_0;
				if (Class89.action_1 == null)
				{
					Class89.action_1 = new Action<Class531>(Class89.smethod_1);
				}
				arg_4B_0.ForEach(Class89.action_1);
			}
		}

		// Token: 0x06001C85 RID: 7301
		// RVA: 0x0001776B File Offset: 0x0001596B
		[CompilerGenerated]
		private bool method_5(object object_0, EventArgs eventArgs_0)
		{
			return this.bool_1;
		}

		// Token: 0x06001C86 RID: 7302
		// RVA: 0x0001776B File Offset: 0x0001596B
		[CompilerGenerated]
		private bool method_6(object object_0, EventArgs eventArgs_0)
		{
			return this.bool_1;
		}

		// Token: 0x06001C87 RID: 7303
		// RVA: 0x0001776B File Offset: 0x0001596B
		[CompilerGenerated]
		private bool method_7(object object_0, EventArgs eventArgs_0)
		{
			return this.bool_1;
		}

		// Token: 0x06001C88 RID: 7304
		// RVA: 0x0001776B File Offset: 0x0001596B
		[CompilerGenerated]
		private bool method_8(object object_0, EventArgs eventArgs_0)
		{
			return this.bool_1;
		}

		// Token: 0x06001C89 RID: 7305
		// RVA: 0x00017773 File Offset: 0x00015973
		[CompilerGenerated]
		private static void smethod_0(Class746 class746_0)
		{
			class746_0.int_0 += Class115.int_1;
			class746_0.int_1 += Class115.int_1;
		}

		// Token: 0x06001C8A RID: 7306
		// RVA: 0x00017799 File Offset: 0x00015999
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_1)
		{
			class531_1.method_16(600, Enum70.const_0);
		}

		// Token: 0x06001C75 RID: 7285
		// RVA: 0x00098B98 File Offset: 0x00096D98
		protected virtual void vmethod_0()
		{
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_5), Enum98.const_5, Enum97.const_0);
			Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_6), Enum98.const_5, Enum97.const_0);
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_7), Enum98.const_5, Enum97.const_0);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_8), Enum98.const_5, Enum97.const_0);
		}

		// Token: 0x06001C77 RID: 7287
		// RVA: 0x00017716 File Offset: 0x00015916
		internal virtual void vmethod_1(Class531 class531_1)
		{
			this.class911_0.Add(class531_1);
		}

		// Token: 0x06001C7A RID: 7290
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_2()
		{
			return true;
		}

		// Token: 0x06001C7B RID: 7291
		// RVA: 0x00098BF8 File Offset: 0x00096DF8
		internal virtual void vmethod_3()
		{
			if (this.bool_1)
			{
				return;
			}
			if (Class111.bool_2 && this.vmethod_2())
			{
				Class111.smethod_21(true);
				this.bool_3 = true;
			}
			for (int i = this.class911_0.list_2.Count - 1; i > -1; i--)
			{
				Class530 class = this.class911_0.list_2[i];
				if (class.class26_0.Count > 0 && class.class26_0[0].int_1 < Class115.int_1)
				{
					List<Class746> arg_98_0 = class.class26_0;
					if (Class89.action_0 == null)
					{
						Class89.action_0 = new Action<Class746>(Class89.smethod_0);
					}
					arg_98_0.ForEach(Class89.action_0);
				}
				if (class.class26_0.Count == 0 && class.color_0 != Color.get_TransparentWhite())
				{
					class.method_15(300);
				}
			}
			this.bool_1 = true;
		}

		// Token: 0x06001C82 RID: 7298
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_4()
		{
		}

		// Token: 0x06001C84 RID: 7300
		// RVA: 0x0009909C File Offset: 0x0009729C
		internal virtual bool vmethod_5(Keys keys_0)
		{
			if (keys_0 == 13)
			{
				this.Close(false);
				return true;
			}
			if (keys_0 == 27)
			{
				this.Close(true);
				return true;
			}
			int num;
			if (int.TryParse(keys_0.ToString().Replace("D", ""), out num) && num < this.list_0.Count + 1 && num > 0)
			{
				this.list_0[num - 1].method_0(true);
				return true;
			}
			return false;
		}
	}
}
