using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns26;
using ns29;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x0200068B RID: 1675
	internal sealed class Class883 : IDisposable
	{
		// Token: 0x0200068C RID: 1676
		internal sealed class Class542 : Class531
		{
			// Token: 0x040030BF RID: 12479
			private float float_7;

			// Token: 0x06003442 RID: 13378
			// RVA: 0x00026717 File Offset: 0x00024917
			internal Class542(Class731 class731_1, Vector2 vector2_9, float float_8, Color color_2, float float_9) : base(class731_1, vector2_9, float_8, true, color_2)
			{
				this.float_7 = float_9;
			}

			// Token: 0x06003443 RID: 13379
			// RVA: 0x00166D24 File Offset: 0x00164F24
			internal override bool vmethod_10(Vector2 vector2_9, int int_7)
			{
				float height = this.rectangleF_0.Height;
				RectangleF rectangleF_ = this.rectangleF_0;
				rectangleF_.Y -= height * 7f;
				rectangleF_.Height += height * 14f;
				rectangleF_.Width = this.float_7 * Class115.float_4;
				return rectangleF_.Contains(vector2_9);
			}
		}

		// Token: 0x0200068D RID: 1677
		[CompilerGenerated]
		private sealed class Class884
		{
			// Token: 0x040030C0 RID: 12480
			public Class883 class883_0;

			// Token: 0x040030C1 RID: 12481
			public int int_0;

			// Token: 0x06003445 RID: 13381
			// RVA: 0x00166D8C File Offset: 0x00164F8C
			public void ctor>b__0()
			{
				float num = this.class883_0.class531_0.rectangleF_0.X - this.class883_0.class531_1.rectangleF_0.X;
				float num2 = (float)this.class883_0.class531_0.int_4 / 1.6f / 2f;
				this.class883_0.class531_1.vector2_2.X = Math.Max(0f, num / Class115.float_5);
				this.class883_0.class531_2.vector2_2.X = Math.Max(0f, (float)this.int_0 * 1.6f - (num + (float)this.class883_0.class531_0.int_4) / Class115.float_5);
				this.class883_0.class531_2.vector2_1.X = this.class883_0.class531_0.vector2_1.X + num2;
			}
		}

		// Token: 0x040030AD RID: 12461
		private bool bool_0;

		// Token: 0x040030B5 RID: 12469
		private bool bool_1 = true;

		// Token: 0x040030B6 RID: 12470
		internal bool bool_2;

		// Token: 0x040030BC RID: 12476
		private bool bool_3;

		// Token: 0x040030BD RID: 12477
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040030BE RID: 12478
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040030B4 RID: 12468
		internal Class531 class531_0;

		// Token: 0x040030B9 RID: 12473
		internal Class531 class531_1;

		// Token: 0x040030BA RID: 12474
		internal Class531 class531_2;

		// Token: 0x040030B1 RID: 12465
		internal Color color_0;

		// Token: 0x040030AC RID: 12460
		private readonly double double_0;

		// Token: 0x040030AF RID: 12463
		internal double double_1;

		// Token: 0x040030B2 RID: 12466
		internal double double_2;

		// Token: 0x040030B3 RID: 12467
		internal double double_3;

		// Token: 0x040030B7 RID: 12471
		internal double double_4 = 1.0;

		// Token: 0x040030BB RID: 12475
		private EventHandler eventHandler_0;

		// Token: 0x040030B0 RID: 12464
		internal int int_0;

		// Token: 0x040030B8 RID: 12472
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x040030AE RID: 12462
		private Vector2 vector2_0;

		// Token: 0x170003AD RID: 941
		public bool ReadOnly
		{
			// Token: 0x06003440 RID: 13376
			// RVA: 0x00026706 File Offset: 0x00024906
			get;
			// Token: 0x06003441 RID: 13377
			// RVA: 0x0002670E File Offset: 0x0002490E
			set;
		}

		// Token: 0x0600342C RID: 13356
		// RVA: 0x00166704 File Offset: 0x00164904
		internal Class883(Class911 class911_0, double double_5, double double_6, double double_7, Vector2 vector2_1, int int_1)
		{
			Class883 class883_0 = this;
			this.double_3 = double_5;
			this.double_2 = double_6;
			this.double_1 = (this.double_0 = Math.Max(double_5, Math.Min(double_6, double_7)));
			this.int_0 = int_1;
			this.color_0 = Class885.color_1;
			this.class531_1 = new Class883.Class542(Class115.class731_0, vector2_1, 0.992f, this.color_0, (float)int_1);
			this.class531_1.bool_1 = true;
			this.class531_1.nullable_2 = new bool?(true);
			this.class531_1.vector2_2 = new Vector2((float)int_1 * 1.6f, 1.5f);
			this.class531_2 = new Class531(Class115.class731_0, vector2_1, 0.991f, true, this.color_0);
			this.class531_2.nullable_2 = new bool?(true);
			this.class531_2.bool_1 = true;
			this.class531_2.float_3 = 0.5f;
			this.class531_2.vector2_2 = new Vector2((float)int_1 * 1.6f, 1.5f);
			this.class531_0 = new Class531(Class885.Load("circle-empty", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, this.method_18(), 0.99f, true, this.color_0, null);
			this.class531_0.bool_1 = true;
			Class531 arg_19C_0 = this.class531_0;
			VoidDelegate voidDelegate_ = delegate
			{
				float num = class883_0.class531_0.rectangleF_0.X - class883_0.class531_1.rectangleF_0.X;
				float num2 = (float)class883_0.class531_0.int_4 / 1.6f / 2f;
				class883_0.class531_1.vector2_2.X = Math.Max(0f, num / Class115.float_5);
				class883_0.class531_2.vector2_2.X = Math.Max(0f, (float)int_1 * 1.6f - (num + (float)class883_0.class531_0.int_4) / Class115.float_5);
				class883_0.class531_2.vector2_1.X = class883_0.class531_0.vector2_1.X + num2;
			};
			arg_19C_0.method_30(voidDelegate_);
			this.list_0.Add(this.class531_0);
			this.list_0.Add(this.class531_1);
			this.list_0.Add(this.class531_2);
			this.class531_1.method_35(new EventHandler(this.method_10));
			this.class531_1.method_37(new EventHandler(this.method_9));
			if (class911_0 != null)
			{
				class911_0.Add(this.class531_0);
				class911_0.Add(this.class531_1);
				class911_0.Add(this.class531_2);
			}
			this.method_21();
		}

		// Token: 0x0600343B RID: 13371
		// RVA: 0x000266D6 File Offset: 0x000248D6
		public void Dispose()
		{
			this.method_22();
		}

		// Token: 0x06003426 RID: 13350
		// RVA: 0x000265D7 File Offset: 0x000247D7
		internal Vector2 method_0()
		{
			return this.class531_1.vector2_1;
		}

		// Token: 0x06003427 RID: 13351
		// RVA: 0x000265E4 File Offset: 0x000247E4
		internal bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06003431 RID: 13361
		// RVA: 0x0002662C File Offset: 0x0002482C
		private void method_10(object sender, EventArgs e)
		{
			if (!this.ReadOnly && this.method_2())
			{
				this.method_8(true);
				this.method_6(true);
				return;
			}
		}

		// Token: 0x06003432 RID: 13362
		// RVA: 0x0002664D File Offset: 0x0002484D
		private bool method_11(object object_0, EventArgs eventArgs_0)
		{
			this.vector2_0 = Class800.smethod_19();
			return false;
		}

		// Token: 0x06003433 RID: 13363
		// RVA: 0x00166A00 File Offset: 0x00164C00
		private bool method_12(object object_0, EventArgs eventArgs_0)
		{
			if (!this.bool_0)
			{
				Vector2 vector = (Class800.smethod_19() - this.vector2_0) * Class115.float_6;
				if (Math.Abs(vector.Y) >= 5f)
				{
					this.vector2_0.Y = float.NegativeInfinity;
					return false;
				}
				if ((double)Math.Abs(vector.X) <= 2.5 || Math.Abs(vector.Y) >= 5f)
				{
					return false;
				}
				this.bool_0 = true;
			}
			this.method_15();
			return true;
		}

		// Token: 0x06003434 RID: 13364
		// RVA: 0x00166A94 File Offset: 0x00164C94
		private bool method_13(object object_0, EventArgs eventArgs_0)
		{
			Vector2 vector = (Class800.smethod_19() - this.vector2_0) * Class115.float_6;
			if (this.bool_0 || Math.Abs(vector.Y) < 5f)
			{
				this.bool_0 = false;
				this.method_15();
			}
			if (!this.class531_1.vmethod_1())
			{
				this.method_6(false);
			}
			return false;
		}

		// Token: 0x06003435 RID: 13365
		// RVA: 0x00166AFC File Offset: 0x00164CFC
		private double method_14()
		{
			RectangleF rectangleF = this.method_16();
			return (double)(Class800.smethod_19().X - rectangleF.X) / (double)rectangleF.Width * (this.double_2 - this.double_3);
		}

		// Token: 0x06003436 RID: 13366
		// RVA: 0x0002665B File Offset: 0x0002485B
		private void method_15()
		{
			if (this.method_2())
			{
				this.SetValue(Math.Min(this.double_2, Math.Max(this.double_3, this.double_3 + this.method_14())), false);
			}
		}

		// Token: 0x06003437 RID: 13367
		// RVA: 0x00166B3C File Offset: 0x00164D3C
		private RectangleF method_16()
		{
			return new RectangleF(this.class531_1.rectangleF_0.X, this.class531_1.rectangleF_0.Y - this.class531_0.rectangleF_0.Height / 2f, (float)this.int_0 * Class115.float_4, this.class531_0.rectangleF_0.Height);
		}

		// Token: 0x06003438 RID: 13368
		// RVA: 0x0002668F File Offset: 0x0002488F
		private float method_17()
		{
			return (float)((this.double_1 - this.double_3) / (this.double_2 - this.double_3));
		}

		// Token: 0x06003439 RID: 13369
		// RVA: 0x000266AD File Offset: 0x000248AD
		private Vector2 method_18()
		{
			return this.method_0() + new Vector2((float)this.int_0, 0f) * this.method_17();
		}

		// Token: 0x0600343A RID: 13370
		// RVA: 0x00166BA4 File Offset: 0x00164DA4
		private bool method_19(object object_0, Keys keys_0, bool bool_6)
		{
			if (!this.bool_2)
			{
				return false;
			}
			switch (keys_0)
			{
			case 37:
				this.SetValue(Math.Min(this.double_2, Math.Max(this.double_3, this.double_1 - this.double_4)), false);
				return true;
			case 39:
				this.SetValue(Math.Min(this.double_2, Math.Max(this.double_3, this.double_1 + this.double_4)), false);
				return true;
			}
			return false;
		}

		// Token: 0x06003428 RID: 13352
		// RVA: 0x000265EC File Offset: 0x000247EC
		internal bool method_2()
		{
			return this.bool_1 && this.class531_0.bool_3;
		}

		// Token: 0x0600343C RID: 13372
		// RVA: 0x000266DE File Offset: 0x000248DE
		internal void method_20(double double_5, double double_6, double double_7)
		{
			this.double_3 = double_5;
			this.double_2 = double_6;
			this.SetValue(double_7, false);
		}

		// Token: 0x0600343E RID: 13374
		// RVA: 0x00166CBC File Offset: 0x00164EBC
		private void method_21()
		{
			int int_ = this.class531_0.bool_3 ? 100 : 0;
			this.class531_0.vector2_0 = this.method_18() + (this.class531_1.vector2_0 - this.class531_1.vector2_1);
			this.class531_0.method_19(this.method_18(), int_, Enum70.const_1);
		}

		// Token: 0x0600343F RID: 13375
		// RVA: 0x000266F6 File Offset: 0x000248F6
		internal void method_22()
		{
			this.bool_0 = false;
			this.method_6(false);
		}

		// Token: 0x06003429 RID: 13353
		// RVA: 0x00166610 File Offset: 0x00164810
		internal void method_3(bool bool_6)
		{
			if (this.bool_1 == bool_6)
			{
				return;
			}
			this.bool_1 = bool_6;
			if (this.bool_1)
			{
				this.class531_0.method_14(100, Enum70.const_0);
				this.class531_1.method_14(100, Enum70.const_0);
				this.class531_2.method_14(100, Enum70.const_0);
				return;
			}
			this.class531_0.method_16(100, Enum70.const_0);
			this.class531_1.method_16(100, Enum70.const_0);
			this.class531_2.method_16(100, Enum70.const_0);
			this.method_22();
		}

		// Token: 0x0600342A RID: 13354
		// RVA: 0x00166694 File Offset: 0x00164894
		internal void method_4(string string_0)
		{
			Class531 arg_23_0 = this.class531_1;
			Class531 arg_1D_0 = this.class531_2;
			this.class531_0.string_0 = string_0;
			arg_1D_0.string_0 = string_0;
			arg_23_0.string_0 = string_0;
		}

		// Token: 0x0600342B RID: 13355
		// RVA: 0x001666CC File Offset: 0x001648CC
		internal void method_5(EventHandler eventHandler_1)
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

		// Token: 0x0600342D RID: 13357
		// RVA: 0x00166940 File Offset: 0x00164B40
		private void method_6(bool bool_6)
		{
			if (bool_6 == this.bool_3)
			{
				return;
			}
			this.bool_3 = bool_6;
			if (this.bool_3)
			{
				Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_11), Enum98.const_8, Enum97.const_2);
				Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_13), Enum98.const_8, Enum97.const_2);
				Class802.smethod_34(Enum96.const_3, new Delegate46(this.method_12), Enum98.const_8, Enum97.const_2);
				Class570.smethod_4(new Class570.Delegate45(this.method_19));
				return;
			}
			Class802.smethod_35(Enum96.const_8, new Delegate46(this.method_11), Enum98.const_8);
			Class802.smethod_35(Enum96.const_6, new Delegate46(this.method_13), Enum98.const_8);
			Class802.smethod_35(Enum96.const_3, new Delegate46(this.method_12), Enum98.const_8);
			Class570.smethod_5(new Class570.Delegate45(this.method_19));
		}

		// Token: 0x0600342E RID: 13358
		// RVA: 0x00026603 File Offset: 0x00024803
		[CompilerGenerated]
		internal bool method_7()
		{
			return this.bool_4;
		}

		// Token: 0x0600342F RID: 13359
		// RVA: 0x0002660B File Offset: 0x0002480B
		[CompilerGenerated]
		private void method_8(bool bool_6)
		{
			this.bool_4 = bool_6;
		}

		// Token: 0x06003430 RID: 13360
		// RVA: 0x00026614 File Offset: 0x00024814
		private void method_9(object sender, EventArgs e)
		{
			this.method_8(false);
			if (!this.bool_0)
			{
				this.method_6(false);
			}
		}

		// Token: 0x0600343D RID: 13373
		// RVA: 0x00166C30 File Offset: 0x00164E30
		internal void SetValue(double double_5, bool bool_6)
		{
			double_5 = Math.Min(this.double_2, Math.Max(this.double_3, double_5));
			if (this.double_1 != double_5 || !this.method_1())
			{
				this.double_1 = double_5;
				if (!bool_6)
				{
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, null);
					}
					if (this.method_1())
					{
						Class331.smethod_36(null, "sliderbar", 1f + this.method_17() * 0.2f, false);
					}
				}
				this.method_21();
			}
		}
	}
}
