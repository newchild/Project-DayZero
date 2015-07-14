using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns29;
using ns79;
using ns8;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns77
{
	// Token: 0x0200044E RID: 1102
	internal class Class530 : IDisposable, IComparable<Class530>
	{
		// Token: 0x04001BAE RID: 7086
		internal bool bool_0;

		// Token: 0x04001BB3 RID: 7091
		internal bool bool_1;

		// Token: 0x04001BB4 RID: 7092
		internal bool bool_2;

		// Token: 0x04001BBB RID: 7099
		internal bool bool_3;

		// Token: 0x04001BBF RID: 7103
		protected bool bool_4;

		// Token: 0x04001BC0 RID: 7104
		internal bool bool_5;

		// Token: 0x04001BC1 RID: 7105
		internal bool bool_6;

		// Token: 0x04001BAC RID: 7084
		internal Class26<Class746> class26_0 = new Class26<Class746>();

		// Token: 0x04001BB5 RID: 7093
		internal Class746 class746_0;

		// Token: 0x04001BAF RID: 7087
		internal Color color_0;

		// Token: 0x04001BAA RID: 7082
		internal Enum114 enum114_0;

		// Token: 0x04001BB6 RID: 7094
		private EventHandler eventHandler_0;

		// Token: 0x04001BAB RID: 7083
		internal float float_0;

		// Token: 0x04001BB7 RID: 7095
		internal float float_1;

		// Token: 0x04001BB8 RID: 7096
		internal float float_2;

		// Token: 0x04001BB9 RID: 7097
		internal float float_3;

		// Token: 0x04001BB2 RID: 7090
		internal int int_0;

		// Token: 0x04001BAD RID: 7085
		internal List<Class743> list_0;

		// Token: 0x04001BBD RID: 7101
		private Rectangle? nullable_0 = null;

		// Token: 0x04001BBE RID: 7102
		private RectangleF? nullable_1 = null;

		// Token: 0x04001BB1 RID: 7089
		internal object object_0;

		// Token: 0x04001BC2 RID: 7106
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04001BC3 RID: 7107
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04001BCC RID: 7116
		[CompilerGenerated]
		private static Predicate<Class746> predicate_10;

		// Token: 0x04001BCD RID: 7117
		[CompilerGenerated]
		private static Predicate<Class746> predicate_11;

		// Token: 0x04001BCE RID: 7118
		[CompilerGenerated]
		private static Predicate<Class746> predicate_12;

		// Token: 0x04001BCF RID: 7119
		[CompilerGenerated]
		private static Predicate<Class746> predicate_13;

		// Token: 0x04001BC4 RID: 7108
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x04001BC5 RID: 7109
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x04001BC6 RID: 7110
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04001BC7 RID: 7111
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x04001BC8 RID: 7112
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x04001BC9 RID: 7113
		[CompilerGenerated]
		private static Predicate<Class746> predicate_7;

		// Token: 0x04001BCA RID: 7114
		[CompilerGenerated]
		private static Predicate<Class746> predicate_8;

		// Token: 0x04001BCB RID: 7115
		[CompilerGenerated]
		private static Predicate<Class746> predicate_9;

		// Token: 0x04001BB0 RID: 7088
		internal Vector2 vector2_0;

		// Token: 0x04001BBA RID: 7098
		internal Vector2 vector2_1;

		// Token: 0x04001BBC RID: 7100
		internal Vector2 vector2_2 = Vector2.get_One();

		// Token: 0x06002395 RID: 9109
		// RVA: 0x000D6930 File Offset: 0x000D4B30
		public Class530(bool bool_7)
		{
			this.bool_0 = bool_7;
			if (bool_7)
			{
				this.float_3 = 1f;
			}
		}

		// Token: 0x06002391 RID: 9105
		// RVA: 0x0001C1F7 File Offset: 0x0001A3F7
		public int CompareTo(Class530 obj)
		{
			return this.class26_0[0].int_0.CompareTo(obj.class26_0[0].int_0);
		}

		// Token: 0x06002393 RID: 9107
		// RVA: 0x0001C220 File Offset: 0x0001A420
		public virtual void Dispose()
		{
			GC.SuppressFinalize(this);
			this.Dispose(false);
		}

		// Token: 0x06002394 RID: 9108
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Dispose(bool bool_7)
		{
		}

		// Token: 0x0600238D RID: 9101
		// RVA: 0x0001C1DD File Offset: 0x0001A3DD
		public virtual bool Draw()
		{
			return !this.bool_5;
		}

		// Token: 0x06002392 RID: 9106
		// RVA: 0x000D6900 File Offset: 0x000D4B00
		~Class530()
		{
			this.Dispose(true);
		}

		// Token: 0x06002381 RID: 9089
		// RVA: 0x000D6628 File Offset: 0x000D4828
		internal bool method_0(bool bool_7)
		{
			if (this.bool_2 && !bool_7)
			{
				return false;
			}
			bool result;
			if (result = (this.eventHandler_0 != null))
			{
				this.eventHandler_0(this, null);
			}
			if (this.class746_0 != null)
			{
				int num = this.class746_0.int_1 - this.class746_0.int_0;
				this.class746_0.int_0 = Class115.int_1;
				this.class746_0.int_1 = Class115.int_1 + num;
				if (!this.class26_0.Contains(this.class746_0))
				{
					this.class26_0.Add(this.class746_0);
				}
			}
			return result;
		}

		// Token: 0x06002382 RID: 9090
		// RVA: 0x0001C169 File Offset: 0x0001A369
		internal void method_1()
		{
			this.eventHandler_0 = null;
		}

		// Token: 0x0600238F RID: 9103
		// RVA: 0x000D680C File Offset: 0x000D4A0C
		internal void method_10()
		{
			if (this.list_0 != null && this.list_0.Count != 0)
			{
				List<Class746> arg_38_0 = this.class26_0;
				if (Class530.predicate_0 == null)
				{
					Class530.predicate_0 = new Predicate<Class746>(Class530.smethod_0);
				}
				arg_38_0.RemoveAll(Class530.predicate_0);
				foreach (Class743 current in this.list_0)
				{
					this.method_11(current);
				}
				return;
			}
		}

		// Token: 0x06002390 RID: 9104
		// RVA: 0x000D68A0 File Offset: 0x000D4AA0
		internal void method_11(Class743 class743_0)
		{
			List<Class746> list = class743_0.vmethod_0();
			if (list == null)
			{
				return;
			}
			foreach (Class746 current in list)
			{
				this.class26_0.method_0(current);
			}
		}

		// Token: 0x06002396 RID: 9110
		// RVA: 0x0001C22F File Offset: 0x0001A42F
		internal void method_12()
		{
			this.method_16(0, Enum70.const_0);
		}

		// Token: 0x06002397 RID: 9111
		// RVA: 0x0001C239 File Offset: 0x0001A439
		internal void method_13()
		{
			this.method_14(0, Enum70.const_0);
		}

		// Token: 0x06002398 RID: 9112
		// RVA: 0x000D6988 File Offset: 0x000D4B88
		internal void method_14(int int_1, Enum70 enum70_0)
		{
			int count = this.class26_0.Count;
			if (count == 0 && this.float_3 == 1f)
			{
				return;
			}
			if (count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.Fade && class.float_1 == 1f && class.int_1 - class.int_0 == int_1)
				{
					return;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_84_0 = this.class26_0;
				if (Class530.predicate_1 == null)
				{
					Class530.predicate_1 = new Predicate<Class746>(Class530.smethod_1);
				}
				arg_84_0.RemoveAll(Class530.predicate_1);
			}
			if (1f - this.float_3 < 1.401298E-45f)
			{
				return;
			}
			if (int_1 == 0)
			{
				this.float_3 = 1f;
				return;
			}
			Class746 item = new Class746(TransformationType.Fade, this.float_3, 1f, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, enum70_0);
			this.class26_0.Add(item);
		}

		// Token: 0x06002399 RID: 9113
		// RVA: 0x000D6A9C File Offset: 0x000D4C9C
		internal Class746 method_15(int int_1)
		{
			this.float_3 = 0f;
			lock (Class911.object_0)
			{
				List<Class746> arg_3A_0 = this.class26_0;
				if (Class530.predicate_2 == null)
				{
					Class530.predicate_2 = new Predicate<Class746>(Class530.smethod_2);
				}
				arg_3A_0.RemoveAll(Class530.predicate_2);
			}
			Class746 class = new Class746(TransformationType.Fade, 0f, 1f, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			this.class26_0.Add(class);
			return class;
		}

		// Token: 0x0600239A RID: 9114
		// RVA: 0x000D6B40 File Offset: 0x000D4D40
		internal void method_16(int int_1, Enum70 enum70_0)
		{
			int count = this.class26_0.Count;
			if (count == 0 && this.float_3 == 0f)
			{
				return;
			}
			if (count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.Fade && class.float_1 == 0f && class.int_1 - class.int_0 == int_1)
				{
					return;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_84_0 = this.class26_0;
				if (Class530.predicate_3 == null)
				{
					Class530.predicate_3 = new Predicate<Class746>(Class530.smethod_3);
				}
				arg_84_0.RemoveAll(Class530.predicate_3);
			}
			if (this.float_3 < 1.401298E-45f)
			{
				return;
			}
			if (int_1 == 0)
			{
				this.float_3 = 0f;
				return;
			}
			Class746 item = new Class746(TransformationType.Fade, this.float_3, 0f, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, enum70_0);
			this.class26_0.Add(item);
		}

		// Token: 0x0600239B RID: 9115
		// RVA: 0x000D6C4C File Offset: 0x000D4E4C
		internal Class746 method_17(int int_1)
		{
			this.float_3 = 1f;
			lock (Class911.object_0)
			{
				List<Class746> arg_3A_0 = this.class26_0;
				if (Class530.predicate_4 == null)
				{
					Class530.predicate_4 = new Predicate<Class746>(Class530.smethod_4);
				}
				arg_3A_0.RemoveAll(Class530.predicate_4);
			}
			Class746 class = new Class746(TransformationType.Fade, 1f, 0f, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			this.class26_0.Add(class);
			return class;
		}

		// Token: 0x0600239C RID: 9116
		// RVA: 0x0001C243 File Offset: 0x0001A443
		internal void method_18(Vector2 vector2_3, int int_1)
		{
			this.method_19(vector2_3, int_1, Enum70.const_0);
		}

		// Token: 0x0600239D RID: 9117
		// RVA: 0x000D6CF0 File Offset: 0x000D4EF0
		internal Class746 method_19(Vector2 vector2_3, int int_1, Enum70 enum70_0)
		{
			lock (Class911.object_0)
			{
				List<Class746> arg_2F_0 = this.class26_0;
				if (Class530.predicate_5 == null)
				{
					Class530.predicate_5 = new Predicate<Class746>(Class530.smethod_5);
				}
				arg_2F_0.RemoveAll(Class530.predicate_5);
			}
			if (vector2_3 == this.vector2_1)
			{
				return null;
			}
			if (int_1 == 0)
			{
				this.vector2_1 = vector2_3;
				return null;
			}
			Class746 class = new Class746(this.vector2_1, vector2_3, Class115.smethod_21(this.enum114_0) - (int)Math.Max(1.0, Class115.double_9), Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class.enum70_0 = enum70_0;
			this.class26_0.Add(class);
			return class;
		}

		// Token: 0x06002383 RID: 9091
		// RVA: 0x000D66C8 File Offset: 0x000D48C8
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

		// Token: 0x0600239E RID: 9118
		// RVA: 0x000D6DB8 File Offset: 0x000D4FB8
		internal void method_20(float float_4, int int_1, Enum70 enum70_0)
		{
			lock (Class911.object_0)
			{
				List<Class746> arg_2F_0 = this.class26_0;
				if (Class530.predicate_6 == null)
				{
					Class530.predicate_6 = new Predicate<Class746>(Class530.smethod_6);
				}
				arg_2F_0.RemoveAll(Class530.predicate_6);
			}
			if (float_4 == this.vector2_1.X)
			{
				return;
			}
			if (int_1 == 0)
			{
				this.vector2_1.X = float_4;
				return;
			}
			Class746 class = new Class746(TransformationType.MovementX, this.vector2_1.X, float_4, Class115.smethod_21(this.enum114_0) - (int)Math.Max(1.0, Class115.double_9), Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class.enum70_0 = enum70_0;
			this.class26_0.Add(class);
		}

		// Token: 0x0600239F RID: 9119
		// RVA: 0x000D6E8C File Offset: 0x000D508C
		internal void method_21(float float_4, int int_1, Enum70 enum70_0)
		{
			lock (Class911.object_0)
			{
				List<Class746> arg_2F_0 = this.class26_0;
				if (Class530.predicate_7 == null)
				{
					Class530.predicate_7 = new Predicate<Class746>(Class530.smethod_7);
				}
				arg_2F_0.RemoveAll(Class530.predicate_7);
			}
			if (float_4 == this.vector2_1.Y)
			{
				return;
			}
			if (int_1 == 0)
			{
				this.vector2_1.Y = float_4;
				return;
			}
			Class746 class = new Class746(TransformationType.MovementY, this.vector2_1.Y, float_4, Class115.smethod_21(this.enum114_0) - (int)Math.Max(1.0, Class115.double_9), Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class.enum70_0 = enum70_0;
			this.class26_0.Add(class);
		}

		// Token: 0x060023A0 RID: 9120
		// RVA: 0x000D6F60 File Offset: 0x000D5160
		internal Class746 method_22(Vector2 vector2_3, int int_1)
		{
			List<Class746> arg_23_0 = this.class26_0;
			if (Class530.predicate_8 == null)
			{
				Class530.predicate_8 = new Predicate<Class746>(Class530.smethod_8);
			}
			Class746 class = arg_23_0.Find(Class530.predicate_8);
			if (class != null)
			{
				this.vector2_1 = class.vector2_1;
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_67_0 = this.class26_0;
				if (Class530.predicate_9 == null)
				{
					Class530.predicate_9 = new Predicate<Class746>(Class530.smethod_9);
				}
				arg_67_0.RemoveAll(Class530.predicate_9);
			}
			Class746 class2 = new Class746(this.vector2_1, this.vector2_1 + vector2_3, Class115.smethod_21(this.enum114_0), Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class2.byte_0 = 125;
			this.class26_0.Add(class2);
			return class2;
		}

		// Token: 0x060023A1 RID: 9121
		// RVA: 0x000D703C File Offset: 0x000D523C
		internal void method_23(Vector2 vector2_3, int int_1, Enum70 enum70_0)
		{
			lock (Class911.object_0)
			{
				List<Class746> arg_2F_0 = this.class26_0;
				if (Class530.predicate_10 == null)
				{
					Class530.predicate_10 = new Predicate<Class746>(Class530.smethod_10);
				}
				arg_2F_0.RemoveAll(Class530.predicate_10);
			}
			Class746 class = new Class746(this.vector2_1, this.vector2_1 + vector2_3, Class115.smethod_21(this.enum114_0), Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class.enum70_0 = enum70_0;
			this.class26_0.Add(class);
		}

		// Token: 0x060023A2 RID: 9122
		// RVA: 0x000D70DC File Offset: 0x000D52DC
		internal void method_24(int int_1)
		{
			if (int_1 == 0)
			{
				return;
			}
			foreach (Class746 current in this.class26_0)
			{
				current.int_0 += int_1;
				current.int_1 += int_1;
			}
		}

		// Token: 0x060023A3 RID: 9123
		// RVA: 0x000D714C File Offset: 0x000D534C
		public void method_25(float float_4, int int_1, Enum70 enum70_0)
		{
			if (this.class26_0.Count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.Fade && class.float_1 == float_4 && class.int_1 - class.int_0 == int_1)
				{
					return;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_6D_0 = this.class26_0;
				if (Class530.predicate_11 == null)
				{
					Class530.predicate_11 = new Predicate<Class746>(Class530.smethod_11);
				}
				arg_6D_0.RemoveAll(Class530.predicate_11);
			}
			if (this.float_3 == float_4)
			{
				return;
			}
			Class746 class2 = new Class746(TransformationType.Fade, this.float_3, (this.color_0.get_A() != 0) ? ((float)this.color_0.get_A() / 255f * float_4) : float_4, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class2.enum70_0 = enum70_0;
			this.class26_0.Add(class2);
		}

		// Token: 0x060023A4 RID: 9124
		// RVA: 0x000D7254 File Offset: 0x000D5454
		public Class746 method_26(float float_4, int int_1, Enum70 enum70_0)
		{
			if (this.class26_0.Count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.Scale && class.float_1 == float_4 && class.int_1 - class.int_0 == int_1)
				{
					return null;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_6E_0 = this.class26_0;
				if (Class530.predicate_12 == null)
				{
					Class530.predicate_12 = new Predicate<Class746>(Class530.smethod_12);
				}
				arg_6E_0.RemoveAll(Class530.predicate_12);
			}
			if (this.float_2 == float_4)
			{
				return null;
			}
			Class746 class2 = new Class746(TransformationType.Scale, this.float_2, float_4, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class2.enum70_0 = enum70_0;
			this.class26_0.Add(class2);
			return class2;
		}

		// Token: 0x060023A5 RID: 9125
		// RVA: 0x000D733C File Offset: 0x000D553C
		public void method_27(float float_4, int int_1, Enum70 enum70_0)
		{
			if (this.class26_0.Count == 1)
			{
				Class746 class = this.class26_0[0];
				if (class.transformationType_0 == TransformationType.Rotation && class.float_1 == float_4 && class.int_1 - class.int_0 == int_1)
				{
					return;
				}
			}
			lock (Class911.object_0)
			{
				List<Class746> arg_6D_0 = this.class26_0;
				if (Class530.predicate_13 == null)
				{
					Class530.predicate_13 = new Predicate<Class746>(Class530.smethod_13);
				}
				arg_6D_0.RemoveAll(Class530.predicate_13);
			}
			if (this.float_1 == float_4)
			{
				return;
			}
			Class746 class2 = new Class746(TransformationType.Rotation, this.float_1, float_4, Class115.smethod_21(this.enum114_0) - (int)Class115.double_9, Class115.smethod_21(this.enum114_0) + int_1, Enum70.const_0);
			class2.enum70_0 = enum70_0;
			this.class26_0.Add(class2);
		}

		// Token: 0x06002384 RID: 9092
		// RVA: 0x000D6700 File Offset: 0x000D4900
		internal Rectangle method_3()
		{
			if (!this.method_6())
			{
				return Class911.rectangle_0;
			}
			Rectangle? rectangle = this.nullable_0;
			if (!rectangle.HasValue)
			{
				return Class911.class911_0.rectangle_1;
			}
			return rectangle.GetValueOrDefault();
		}

		// Token: 0x06002385 RID: 9093
		// RVA: 0x000D6740 File Offset: 0x000D4940
		internal RectangleF? method_4()
		{
			return new RectangleF?(this.nullable_1 ?? Class911.class911_0.rectangleF_2);
		}

		// Token: 0x06002386 RID: 9094
		// RVA: 0x000D6778 File Offset: 0x000D4978
		internal void method_5(RectangleF? nullable_2)
		{
			this.nullable_1 = nullable_2;
			if (!nullable_2.HasValue)
			{
				this.nullable_0 = null;
				return;
			}
			this.nullable_0 = new Rectangle?(new Rectangle((int)(nullable_2.Value.X * Class115.float_4), (int)(nullable_2.Value.Y * Class115.float_4), (int)Math.Ceiling((double)(nullable_2.Value.Width * Class115.float_4)), (int)Math.Ceiling((double)(nullable_2.Value.Height * Class115.float_4))));
		}

		// Token: 0x06002387 RID: 9095
		// RVA: 0x0001C172 File Offset: 0x0001A372
		protected bool method_6()
		{
			return Class911.class911_0.bool_7 || this.nullable_1.HasValue;
		}

		// Token: 0x0600238A RID: 9098
		// RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		internal bool method_7()
		{
			return this.bool_5;
		}

		// Token: 0x0600238B RID: 9099
		// RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		internal void method_8(bool bool_7)
		{
			this.bool_5 = bool_7;
			if (this.bool_5)
			{
				this.vmethod_2(false);
			}
		}

		// Token: 0x0600238C RID: 9100
		// RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		protected int method_9()
		{
			if (this.enum114_0 != Enum114.const_0)
			{
				return Class331.int_7;
			}
			return Class115.int_1;
		}

		// Token: 0x060023A6 RID: 9126
		// RVA: 0x0001C24F File Offset: 0x0001A44F
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_1)
		{
			return class746_1.bool_1;
		}

		// Token: 0x060023A7 RID: 9127
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_1(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060023B0 RID: 9136
		// RVA: 0x0001C257 File Offset: 0x0001A457
		[CompilerGenerated]
		private static bool smethod_10(Class746 class746_1)
		{
			return (class746_1.transformationType_0 & TransformationType.Movement) > TransformationType.None;
		}

		// Token: 0x060023B1 RID: 9137
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_11(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060023B2 RID: 9138
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_12(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x060023B3 RID: 9139
		// RVA: 0x0001C292 File Offset: 0x0001A492
		[CompilerGenerated]
		private static bool smethod_13(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Rotation;
		}

		// Token: 0x060023A8 RID: 9128
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060023A9 RID: 9129
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_3(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060023AA RID: 9130
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_4(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060023AB RID: 9131
		// RVA: 0x0001C257 File Offset: 0x0001A457
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_1)
		{
			return (class746_1.transformationType_0 & TransformationType.Movement) > TransformationType.None;
		}

		// Token: 0x060023AC RID: 9132
		// RVA: 0x0001C264 File Offset: 0x0001A464
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_1)
		{
			return (class746_1.transformationType_0 & TransformationType.MovementX) > TransformationType.None;
		}

		// Token: 0x060023AD RID: 9133
		// RVA: 0x0001C275 File Offset: 0x0001A475
		[CompilerGenerated]
		private static bool smethod_7(Class746 class746_1)
		{
			return (class746_1.transformationType_0 & TransformationType.MovementY) > TransformationType.None;
		}

		// Token: 0x060023AE RID: 9134
		// RVA: 0x0001C286 File Offset: 0x0001A486
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_1)
		{
			return class746_1.byte_0 == 125;
		}

		// Token: 0x060023AF RID: 9135
		// RVA: 0x0001C257 File Offset: 0x0001A457
		[CompilerGenerated]
		private static bool smethod_9(Class746 class746_1)
		{
			return (class746_1.transformationType_0 & TransformationType.Movement) > TransformationType.None;
		}

		// Token: 0x06002380 RID: 9088
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x06002388 RID: 9096
		// RVA: 0x0001C18D File Offset: 0x0001A38D
		internal virtual bool vmethod_1()
		{
			return this.bool_4;
		}

		// Token: 0x06002389 RID: 9097
		// RVA: 0x0001C195 File Offset: 0x0001A395
		internal virtual void vmethod_2(bool bool_7)
		{
			if (bool_7 == this.bool_4)
			{
				return;
			}
			this.bool_4 = bool_7;
		}

		// Token: 0x0600238E RID: 9102
		// RVA: 0x0001C1EA File Offset: 0x0001A3EA
		public virtual Enum51 vmethod_3()
		{
			if (this.bool_5)
			{
				return Enum51.const_1;
			}
			return Enum51.const_0;
		}
	}
}
