using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns6;
using ns79;
using System;
using System.Threading;

namespace ns27
{
	// Token: 0x02000591 RID: 1425
	internal sealed class Class594 : Class593
	{
		// Token: 0x0400261D RID: 9757
		private Class751 class751_0;

		// Token: 0x0400261B RID: 9755
		private EventHandler eventHandler_1;

		// Token: 0x0400261C RID: 9756
		private EventHandler eventHandler_2;

		// Token: 0x06002D7A RID: 11642
		// RVA: 0x00127C74 File Offset: 0x00125E74
		internal Class594(Class911 class911_1, int int_5, Vector2 vector2_1, float float_3, bool bool_3, Color color_2) : base(class911_1, int_5, vector2_1, float_3, bool_3, color_2)
		{
			Vector2 vector2_2;
			vector2_2..ctor(vector2_1.X + (float)(this.list_1.Count % this.int_0 * 74) + (float)(this.list_1.Count / this.int_0 * 10), vector2_1.Y + 6f - (float)(14 * (1 + this.list_1.Count / this.int_0)));
			this.class751_0 = new Class751(vector2_2, 1f, false, false);
			this.class751_0.method_0(new EventHandler(this.method_13));
			this.list_0.AddRange(this.class751_0.list_0);
			class911_1.Add<Class531>(this.class751_0.list_0);
			this.list_1.Insert(0, this.class751_0);
		}

		// Token: 0x06002D7B RID: 11643
		// RVA: 0x000225AC File Offset: 0x000207AC
		internal override Class750 Add(string string_0, object object_0, bool bool_3)
		{
			return base.Add(string_0, object_0, bool_3 ? 0 : (this.list_1.Count - 1));
		}

		// Token: 0x06002D7D RID: 11645
		// RVA: 0x00127DAC File Offset: 0x00125FAC
		internal void method_10(EventHandler eventHandler_3)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_3);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06002D7E RID: 11646
		// RVA: 0x00127DE4 File Offset: 0x00125FE4
		internal void method_11(EventHandler eventHandler_3)
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

		// Token: 0x06002D7F RID: 11647
		// RVA: 0x00127E1C File Offset: 0x0012601C
		private void method_12(object sender, EventArgs e)
		{
			Class752 class752_ = sender as Class752;
			this.vmethod_3(class752_);
		}

		// Token: 0x06002D81 RID: 11649
		// RVA: 0x000225F8 File Offset: 0x000207F8
		private void method_13(object sender, EventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, null);
			}
		}

		// Token: 0x06002D82 RID: 11650
		// RVA: 0x00127E38 File Offset: 0x00126038
		internal void method_14(int int_5)
		{
			if (this.list_1.Count - 1 == 0)
			{
				base.method_5(this.list_1[0], false);
				return;
			}
			int index = (this.list_1.IndexOf(this.class750_1) + int_5 + this.list_1.Count - 1) % (this.list_1.Count - 1);
			base.method_5(this.list_1[index], false);
		}

		// Token: 0x06002D84 RID: 11652
		// RVA: 0x0002260F File Offset: 0x0002080F
		public int method_15()
		{
			return (this.list_1.Count - 1) / this.int_0 * this.int_2;
		}

		// Token: 0x06002D85 RID: 11653
		// RVA: 0x00127F18 File Offset: 0x00126118
		internal void method_16()
		{
			int num = (this.class750_2 != null || (this.class911_0.class531_1 != null && this.class911_0.class531_1.object_0 is Class750)) ? 13 : 6;
			if (num != this.int_2)
			{
				this.int_2 = num;
				this.vmethod_1();
			}
		}

		// Token: 0x06002D7C RID: 11644
		// RVA: 0x00127D58 File Offset: 0x00125F58
		protected override Class750 vmethod_0(string string_0, object object_0, Vector2 vector2_1, float float_3)
		{
			Class21 class = object_0 as Class21;
			bool bool_ = class != null && class.bool_1;
			Class752 class2 = new Class752(string_0, object_0, vector2_1, float_3, this.bool_0, this.bool_1, this.class746_0, bool_);
			class2.method_4(new EventHandler(this.method_12));
			return class2;
		}

		// Token: 0x06002D83 RID: 11651
		// RVA: 0x00127EAC File Offset: 0x001260AC
		internal override void vmethod_1()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			if (this.class751_0 != null && this.list_1[this.list_1.Count - 1] != this.class751_0)
			{
				this.list_1.Remove(this.class751_0);
				this.list_1.Add(this.class751_0);
			}
			base.vmethod_1();
		}

		// Token: 0x06002D80 RID: 11648
		// RVA: 0x000225C9 File Offset: 0x000207C9
		internal virtual void vmethod_3(Class752 class752_0)
		{
			if (class752_0 != null && class752_0.bool_1)
			{
				this.Remove(class752_0);
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(class752_0.object_0, null);
				}
				return;
			}
		}
	}
}
