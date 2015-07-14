using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns79;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200048D RID: 1165
	internal class Class592
	{
		// Token: 0x0200048E RID: 1166
		[CompilerGenerated]
		private sealed class Class595
		{
			// Token: 0x04001F27 RID: 7975
			public object object_0;

			// Token: 0x06002592 RID: 9618
			// RVA: 0x0001D35C File Offset: 0x0001B55C
			public bool method_0(Class750 class750_0)
			{
				return class750_0.object_0 == this.object_0;
			}
		}

		// Token: 0x0200048F RID: 1167
		[CompilerGenerated]
		private sealed class Class596
		{
			// Token: 0x04001F28 RID: 7976
			public object object_0;

			// Token: 0x06002594 RID: 9620
			// RVA: 0x0001D36C File Offset: 0x0001B56C
			public bool method_0(Class750 class750_0)
			{
				return this.object_0.Equals(class750_0.object_0);
			}
		}

		// Token: 0x04001F25 RID: 7973
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04001F26 RID: 7974
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x04001F17 RID: 7959
		internal bool bool_0;

		// Token: 0x04001F1B RID: 7963
		internal bool bool_1;

		// Token: 0x04001F20 RID: 7968
		internal bool bool_2;

		// Token: 0x04001F13 RID: 7955
		protected readonly Class746 class746_0;

		// Token: 0x04001F14 RID: 7956
		private readonly Class746 class746_1;

		// Token: 0x04001F16 RID: 7958
		protected Class750 class750_0;

		// Token: 0x04001F18 RID: 7960
		internal Class750 class750_1;

		// Token: 0x04001F1C RID: 7964
		internal Class911 class911_0;

		// Token: 0x04001F1E RID: 7966
		internal Color color_0;

		// Token: 0x04001F1F RID: 7967
		internal Color color_1;

		// Token: 0x04001F22 RID: 7970
		private EventHandler eventHandler_0;

		// Token: 0x04001F12 RID: 7954
		private readonly float float_0;

		// Token: 0x04001F24 RID: 7972
		internal float float_1 = 1f;

		// Token: 0x04001F19 RID: 7961
		internal int int_0;

		// Token: 0x04001F1A RID: 7962
		protected int int_1;

		// Token: 0x04001F23 RID: 7971
		protected int int_2 = 13;

		// Token: 0x04001F1D RID: 7965
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x04001F21 RID: 7969
		internal List<Class750> list_1 = new List<Class750>();

		// Token: 0x04001F15 RID: 7957
		internal Vector2 vector2_0;

		// Token: 0x0600257F RID: 9599
		// RVA: 0x000E2208 File Offset: 0x000E0408
		internal Class592(Class911 class911_1, int int_3, Vector2 vector2_1, float float_2, bool bool_3, Color color_2, int int_4, bool bool_4)
		{
			this.int_1 = int_4;
			this.class911_0 = class911_1;
			this.float_0 = float_2;
			this.bool_1 = bool_3;
			this.int_0 = int_3;
			this.vector2_0 = vector2_1;
			this.bool_2 = bool_4;
			this.color_0 = color_2;
			this.color_1 = new Color((byte)Math.Min(255f, (float)this.color_0.get_R() * 1.8f), (byte)Math.Min(255f, (float)this.color_0.get_G() * 1.8f), (byte)Math.Min(255f, (float)this.color_0.get_B() * 1.8f));
			this.class746_0 = new Class746(this.color_0, new Color((byte)Math.Min(255, (int)(this.color_0.get_R() + 20)), (byte)Math.Min(255, (int)(this.color_0.get_G() + 50)), (byte)Math.Min(255, (int)(this.color_0.get_B() + 50))), 0, 80);
			this.class746_1 = new Class746(this.color_1, new Color((byte)Math.Min(255, (int)(this.color_1.get_R() + 20)), (byte)Math.Min(255, (int)(this.color_1.get_G() + 50)), (byte)Math.Min(255, (int)(this.color_1.get_B() + 50))), 0, 80);
		}

		// Token: 0x06002581 RID: 9601
		// RVA: 0x0001D29D File Offset: 0x0001B49D
		internal virtual Class750 Add(string string_0, object object_0, bool bool_3)
		{
			return this.Add(string_0, object_0, bool_3 ? 0 : this.list_1.Count);
		}

		// Token: 0x06002582 RID: 9602
		// RVA: 0x000E23E4 File Offset: 0x000E05E4
		internal virtual Class750 Add(string string_0, object object_0, int int_3)
		{
			Class592.Class595 class = new Class592.Class595();
			class.object_0 = object_0;
			if (this.list_1.Find(new Predicate<Class750>(class.method_0)) != null)
			{
				return null;
			}
			Vector2 vector2_;
			vector2_..ctor(this.vector2_0.X + (float)(this.list_1.Count % this.int_0 * this.int_1) + (float)(this.list_1.Count / this.int_0 * 10 * (this.bool_2 ? -1 : 1)), this.vector2_0.Y + 6f - (float)(14 * (1 + this.list_1.Count / this.int_0)));
			float float_ = this.float_0 - (float)this.list_1.Count * 0.0002f - (float)(this.list_1.Count / this.int_0) * 0.0001f;
			Class750 class2 = this.vmethod_0(string_0, class.object_0, vector2_, float_);
			class2.method_0(new EventHandler(this.vmethod_2));
			if (this.class750_0 == null)
			{
				this.class750_0 = class2;
			}
			this.list_0.AddRange(class2.list_0);
			this.class911_0.Add<Class531>(class2.list_0);
			if (int_3 < 0)
			{
				int_3 = 0;
			}
			this.list_1.Insert((int_3 > this.list_1.Count) ? this.list_1.Count : int_3, class2);
			this.vmethod_1();
			return class2;
		}

		// Token: 0x06002580 RID: 9600
		// RVA: 0x000E23AC File Offset: 0x000E05AC
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

		// Token: 0x06002584 RID: 9604
		// RVA: 0x0001D2DC File Offset: 0x0001B4DC
		internal void method_1(int int_3)
		{
			this.int_0 = int_3;
			this.vmethod_1();
		}

		// Token: 0x06002586 RID: 9606
		// RVA: 0x0001D2EB File Offset: 0x0001B4EB
		internal Class750 method_2(object object_0)
		{
			if (object_0 != null && !(object_0 is Class751))
			{
				return this.method_3(object_0, false, false);
			}
			return null;
		}

		// Token: 0x06002587 RID: 9607
		// RVA: 0x000E26A8 File Offset: 0x000E08A8
		internal Class750 method_3(object object_0, bool bool_3, bool bool_4)
		{
			Class750 class = this.method_4(object_0);
			if (class == null && !bool_4)
			{
				return null;
			}
			this.method_5(class, bool_3);
			return class;
		}

		// Token: 0x06002588 RID: 9608
		// RVA: 0x000E26D0 File Offset: 0x000E08D0
		internal Class750 method_4(object object_0)
		{
			Class592.Class596 class = new Class592.Class596();
			class.object_0 = object_0;
			return this.list_1.Find(new Predicate<Class750>(class.method_0));
		}

		// Token: 0x0600258A RID: 9610
		// RVA: 0x000E2738 File Offset: 0x000E0938
		internal void method_5(Class750 class750_2, bool bool_3)
		{
			if (this.class750_1 == class750_2)
			{
				return;
			}
			if (class750_2 != null && !class750_2.vmethod_0())
			{
				return;
			}
			Class750 class = this.class750_1;
			this.class750_1 = class750_2;
			foreach (Class750 current in this.list_1)
			{
				if (current == this.class750_1)
				{
					current.class531_0.method_39(Color.get_White(), 100, false, Enum70.const_0);
					current.class531_0.class746_1 = null;
					current.bool_0 = false;
					current.class533_0.method_39(Color.get_Black(), 20, false, Enum70.const_0);
					current.class533_0.method_58(false);
					current.class533_0.bool_18 = true;
					List<Class531> arg_C2_0 = current.list_0;
					if (Class592.action_0 == null)
					{
						Class592.action_0 = new Action<Class531>(Class592.smethod_0);
					}
					arg_C2_0.ForEach(Class592.action_0);
					this.class911_0.method_13<Class531>(current.list_0);
					this.class911_0.Add<Class531>(current.list_0);
				}
				else if (current == class)
				{
					current.class531_0.class746_1 = this.class746_0;
					current.class531_0.method_39(this.color_0, 20, false, Enum70.const_0);
					current.class533_0.method_39(Color.get_White(), 20, false, Enum70.const_0);
					current.class533_0.method_58(true);
					current.class533_0.bool_18 = true;
					List<Class531> arg_16C_0 = current.list_0;
					if (Class592.action_1 == null)
					{
						Class592.action_1 = new Action<Class531>(Class592.smethod_1);
					}
					arg_16C_0.ForEach(Class592.action_1);
					this.class911_0.method_13<Class531>(current.list_0);
					this.class911_0.Add<Class531>(current.list_0);
				}
			}
			if (!bool_3 && this.eventHandler_0 != null)
			{
				this.eventHandler_0((this.class750_1 != null) ? this.class750_1.object_0 : null, null);
			}
		}

		// Token: 0x0600258D RID: 9613
		// RVA: 0x000E2A08 File Offset: 0x000E0C08
		public void method_6(object object_0)
		{
			Class750 class = this.method_4(object_0);
			if (class != null)
			{
				if (class != this.class750_1)
				{
					class.bool_0 = true;
					class.class531_0.method_39(this.color_1, 100, false, Enum70.const_0);
					class.class531_0.class746_1 = this.class746_1;
					return;
				}
			}
		}

		// Token: 0x06002590 RID: 9616
		// RVA: 0x0001D33A File Offset: 0x0001B53A
		[CompilerGenerated]
		private void method_7(Class531 class531_0)
		{
			this.list_0.Remove(class531_0);
			class531_0.bool_0 = false;
			class531_0.method_16(200, Enum70.const_0);
		}

		// Token: 0x0600258B RID: 9611
		// RVA: 0x0001D303 File Offset: 0x0001B503
		public void Remove(object object_0)
		{
			this.Remove(this.method_4(object_0));
		}

		// Token: 0x0600258C RID: 9612
		// RVA: 0x000E2940 File Offset: 0x000E0B40
		public virtual void Remove(Class750 class750_2)
		{
			if (class750_2 == null)
			{
				return;
			}
			int num = this.list_1.IndexOf(class750_2);
			if (num >= 0 && num < this.list_1.Count)
			{
				this.list_1.Remove(class750_2);
				class750_2.list_0.ForEach(new Action<Class531>(this.method_7));
				if (this.class750_1 == class750_2 && this.list_1.Count > 0)
				{
					if (num < this.list_1.Count && this.list_1[num].vmethod_0())
					{
						this.method_5(this.list_1[num], false);
					}
					else if (num > 0)
					{
						this.method_5(this.list_1[num - 1], false);
					}
				}
				this.vmethod_1();
				return;
			}
		}

		// Token: 0x0600258E RID: 9614
		// RVA: 0x0001D312 File Offset: 0x0001B512
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_0)
		{
			class531_0.float_0 += 0.001f;
		}

		// Token: 0x0600258F RID: 9615
		// RVA: 0x0001D326 File Offset: 0x0001B526
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_0)
		{
			class531_0.float_0 -= 0.001f;
		}

		// Token: 0x06002583 RID: 9603
		// RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		protected virtual Class750 vmethod_0(string string_0, object object_0, Vector2 vector2_1, float float_2)
		{
			return new Class750(string_0, object_0, vector2_1, float_2, this.bool_0, this.bool_1, this.class746_0, this.float_1);
		}

		// Token: 0x06002585 RID: 9605
		// RVA: 0x000E2554 File Offset: 0x000E0754
		internal virtual void vmethod_1()
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class750 class = this.list_1[i];
				Vector2 vector2_;
				vector2_..ctor(this.vector2_0.X + (float)(i % this.int_0 * 74 * (this.bool_2 ? -1 : 1)) + (float)(i / this.int_0 % 2 * this.int_1), this.vector2_0.Y + 6f - 14f - (float)(this.int_2 * (i / this.int_0)));
				float num = this.float_0 - (float)i * 0.0002f - (float)(i / this.int_0) * 0.0001f;
				class.list_0[0].float_4 = (float)((int)(-100f + num * 100f));
				for (int j = 0; j < class.list_0.Count; j++)
				{
					Class531 class2 = class.list_0[j];
					class2.vector2_0 = vector2_;
					class2.method_19(vector2_, 300, Enum70.const_27);
					class2.float_0 = num + 0.0001f * (float)j + ((this.class750_1 == class) ? 0.001f : 0f);
				}
			}
			this.class911_0.method_10();
		}

		// Token: 0x06002589 RID: 9609
		// RVA: 0x000E2704 File Offset: 0x000E0904
		protected virtual void vmethod_2(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			this.method_5((Class750)sender, false);
		}
	}
}
