using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns79;
using ns80;
using ns84;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200058F RID: 1423
	internal class Class750
	{
		// Token: 0x04002618 RID: 9752
		internal bool bool_0;

		// Token: 0x04002614 RID: 9748
		internal Class531 class531_0;

		// Token: 0x04002615 RID: 9749
		internal Class533 class533_0;

		// Token: 0x04002619 RID: 9753
		private EventHandler eventHandler_0;

		// Token: 0x0400261A RID: 9754
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x04002617 RID: 9751
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04002616 RID: 9750
		internal object object_0;

		// Token: 0x06002D74 RID: 11636
		// RVA: 0x001279DC File Offset: 0x00125BDC
		internal Class750(string string_0, object object_1, Vector2 vector2_0, float float_0, bool bool_1, bool bool_2, Class746 class746_0, float float_1)
		{
			this.class531_0 = new Class531(bool_2 ? Class885.Load("selection-tab", Enum112.flag_6) : Class885.Load("selection-tab", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, float_0, true, class746_0.color_0, null);
			if (bool_1)
			{
				this.class531_0.method_43(true);
			}
			this.class531_0.class746_1 = class746_0;
			this.class531_0.method_35(delegate(object sender, EventArgs e)
			{
				Class331.smethod_36(null, "click-short", 1f, false);
			});
			this.class531_0.vector2_5 = new Vector2(70f, 12f);
			this.class531_0.object_0 = this;
			this.object_0 = (object_1 ?? this);
			int num = (int)(13f / float_1);
			if (!string.IsNullOrEmpty(string_0))
			{
				string_0 = ((string_0.Length > num) ? (string_0.Remove(num) + "..") : string_0);
				this.class531_0.bool_1 = true;
				this.class531_0.method_2(new EventHandler(this.method_1));
			}
			else
			{
				this.class531_0.color_0 = new Color(160, 8, 42);
			}
			this.class533_0 = new Class533(string_0, 12f * float_1, vector2_0, new Vector2(82f, 12f) * float_1, float_0 + 0.0001f, true, Color.get_White(), false);
			this.class533_0.bool_16 = true;
			this.class533_0.method_58(true);
			this.class533_0.origins_0 = Origins.Centre;
			this.class533_0.enum72_0 = Enum72.const_2;
			this.list_0.Add(this.class531_0);
			this.list_0.Add(this.class533_0);
		}

		// Token: 0x06002D75 RID: 11637
		// RVA: 0x00127BA4 File Offset: 0x00125DA4
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

		// Token: 0x06002D76 RID: 11638
		// RVA: 0x00022595 File Offset: 0x00020795
		protected void method_1(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x06002D73 RID: 11635
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_0()
		{
			return true;
		}
	}
}
