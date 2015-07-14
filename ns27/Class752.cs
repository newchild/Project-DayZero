using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x02000592 RID: 1426
	internal sealed class Class752 : Class750
	{
		// Token: 0x04002620 RID: 9760
		internal bool bool_1;

		// Token: 0x0400261E RID: 9758
		internal Class531 class531_1;

		// Token: 0x0400261F RID: 9759
		internal Class531 class531_2;

		// Token: 0x04002621 RID: 9761
		private EventHandler eventHandler_2;

		// Token: 0x06002D86 RID: 11654
		// RVA: 0x00127F70 File Offset: 0x00126170
		internal Class752(string string_0, object object_1, Vector2 vector2_0, float float_0, bool bool_2, bool bool_3, Class746 class746_0, bool bool_4)
		{
			EventHandler eventHandler = null;
			base..ctor(string_0, object_1, vector2_0, float_0, bool_2, bool_3, class746_0, 1f);
			this.bool_1 = bool_4;
			if (bool_4)
			{
				this.class531_1 = new Class531(Class885.Load("selection-tab-close", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, float_0 + 0.0002f, true, new Color(255, 255, 255, 1), null);
				this.class531_1.vector2_5 = new Vector2(-49f, 8f);
				this.class531_1.object_0 = this;
				this.list_0.Add(this.class531_1);
				this.class531_2 = new Class531(Class885.Load("selection-tab-close", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, float_0 + 0.0002f, true, new Color(255, 255, 255, 1), null);
				this.class531_2.vector2_5 = new Vector2(-49f, 8f);
				this.class531_2.bool_1 = true;
				this.class531_2.method_2(new EventHandler(this.method_5));
				this.class531_2.object_0 = this;
				this.class531_2.float_4 = -10f;
				this.class531_2.method_35(delegate(object sender, EventArgs e)
				{
					this.class531_2.float_3 = this.class531_0.float_3 * 1f;
					this.class531_2.color_0 = Color.get_White();
				});
				Class531 arg_15E_0 = this.class531_2;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_6);
				}
				arg_15E_0.method_37(eventHandler);
				this.list_0.Add(this.class531_2);
				this.class531_0.method_35(new EventHandler(this.method_3));
				this.class531_0.method_37(new EventHandler(this.method_2));
			}
		}

		// Token: 0x06002D87 RID: 11655
		// RVA: 0x0002262C File Offset: 0x0002082C
		private void method_2(object sender, EventArgs e)
		{
			this.class531_1.color_0 = new Color(255, 255, 255, 1);
			this.class531_1.float_3 = 0.01f;
		}

		// Token: 0x06002D88 RID: 11656
		// RVA: 0x0002265E File Offset: 0x0002085E
		private void method_3(object sender, EventArgs e)
		{
			this.class531_1.color_0 = Color.get_White();
			this.class531_1.float_3 = 0.4f;
		}

		// Token: 0x06002D89 RID: 11657
		// RVA: 0x00128120 File Offset: 0x00126320
		internal void method_4(EventHandler eventHandler_3)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_3);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002D8A RID: 11658
		// RVA: 0x00128158 File Offset: 0x00126358
		private void method_5(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-close", 1f, false);
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x06002D8C RID: 11660
		// RVA: 0x000226AE File Offset: 0x000208AE
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			this.class531_2.float_3 = this.class531_0.float_3 * 0.01f;
			this.class531_2.color_0 = new Color(255, 255, 255, 1);
		}
	}
}
