using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ns27
{
	// Token: 0x02000492 RID: 1170
	internal sealed class Class598 : IDisposable
	{
		// Token: 0x04001F35 RID: 7989
		private bool bool_0;

		// Token: 0x04001F36 RID: 7990
		private bool bool_1;

		// Token: 0x04001F3C RID: 7996
		internal Class531 class531_0;

		// Token: 0x04001F3D RID: 7997
		private Class597 class597_0;

		// Token: 0x04001F3E RID: 7998
		private Class911 class911_0;

		// Token: 0x04001F38 RID: 7992
		internal Color color_0 = new Color(0, 0, 0, 160);

		// Token: 0x04001F39 RID: 7993
		internal Color color_1 = new Color(165, 90, 234, 230);

		// Token: 0x04001F3A RID: 7994
		internal Color color_2 = new Color(0, 85, 85, 85);

		// Token: 0x04001F3F RID: 7999
		private EventHandler eventHandler_0;

		// Token: 0x04001F3B RID: 7995
		internal int int_0;

		// Token: 0x04001F37 RID: 7991
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04001F33 RID: 7987
		private Vector2 vector2_0;

		// Token: 0x04001F34 RID: 7988
		private Vector2 vector2_1;

		// Token: 0x060025A5 RID: 9637
		// RVA: 0x000E2DBC File Offset: 0x000E0FBC
		internal Class598(Class597 class597_1, Class911 class911_1, Vector2 vector2_2, Vector2 vector2_3, bool bool_2)
		{
			this.vector2_0 = vector2_2;
			this.vector2_1 = vector2_3;
			this.class597_0 = class597_1;
			this.class911_0 = class911_1;
			this.bool_0 = bool_2;
			this.bool_1 = false;
			Color color_ = bool_2 ? this.color_2 : this.color_0;
			this.class531_0 = new Class531(Class885.Load("opaque-white", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(vector2_3.X, vector2_3.Y), 0.99f, true, Color.get_TransparentBlack(), null);
			this.class531_0.vector2_2 = new Vector2(vector2_2.X / 16f, vector2_2.Y / 16f);
			this.class531_0.list_1 = new List<Class746>();
			this.class531_0.list_1.Add(new Class746(color_, this.color_1, 0, 10));
			this.class531_0.list_2 = new List<Class746>();
			this.class531_0.list_2.Add(new Class746(this.color_1, color_, 0, 100));
			this.class531_0.method_2(new EventHandler(this.method_3));
			this.class911_0.Add(this.class531_0);
		}

		// Token: 0x060025AA RID: 9642
		// RVA: 0x0001D48F File Offset: 0x0001B68F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060025AB RID: 9643
		// RVA: 0x000E311C File Offset: 0x000E131C
		private void Dispose(bool bool_2)
		{
			if (bool_2)
			{
				foreach (Class531 current in this.list_0)
				{
					this.class911_0.Remove(current);
					current.Dispose();
				}
				this.class911_0.Remove(this.class531_0);
				this.class531_0.Dispose();
			}
		}

		// Token: 0x060025AC RID: 9644
		// RVA: 0x000E319C File Offset: 0x000E139C
		~Class598()
		{
			this.Dispose(false);
		}

		// Token: 0x060025A6 RID: 9638
		// RVA: 0x000E2F44 File Offset: 0x000E1144
		internal void method_0(int int_1)
		{
			if (this.bool_1)
			{
				return;
			}
			Color color = this.bool_0 ? this.color_2 : this.color_0;
			foreach (Class531 current in this.list_0)
			{
				current.class26_0.Clear();
				current.method_14(200, Enum70.const_0);
			}
			this.class531_0.class26_0.Clear();
			this.class531_0.method_39(color, 0, false, Enum70.const_0);
			this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, (float)color.get_A() / 255f, Class115.int_1 + int_1, Class115.int_1 + int_1 + 200, Enum70.const_0));
			this.class531_0.bool_3 = true;
			this.class531_0.bool_1 = true;
			this.bool_1 = true;
		}

		// Token: 0x060025A7 RID: 9639
		// RVA: 0x000E3048 File Offset: 0x000E1248
		internal void method_1()
		{
			if (!this.bool_1)
			{
				return;
			}
			foreach (Class531 current in this.list_0)
			{
				current.class26_0.Clear();
				current.method_16(100, Enum70.const_0);
			}
			this.class531_0.bool_1 = false;
			this.class531_0.class26_0.Clear();
			this.class531_0.method_16(100, Enum70.const_0);
			this.bool_1 = false;
		}

		// Token: 0x060025A8 RID: 9640
		// RVA: 0x000E30E4 File Offset: 0x000E12E4
		internal void method_2(EventHandler eventHandler_1)
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

		// Token: 0x060025A9 RID: 9641
		// RVA: 0x0001D474 File Offset: 0x0001B674
		private void method_3(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}
	}
}
