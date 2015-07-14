using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns81;
using ns82;
using System;

namespace ns27
{
	// Token: 0x02000490 RID: 1168
	internal class Class593 : Class592
	{
		// Token: 0x04001F29 RID: 7977
		protected Class750 class750_2;

		// Token: 0x04001F2A RID: 7978
		private Class750 class750_3;

		// Token: 0x04001F2B RID: 7979
		private float float_2;

		// Token: 0x04001F2C RID: 7980
		private int int_3;

		// Token: 0x04001F2D RID: 7981
		private int int_4;

		// Token: 0x06002595 RID: 9621
		// RVA: 0x000E2A5C File Offset: 0x000E0C5C
		internal Class593(Class911 class911_1, int int_5, Vector2 vector2_1, float float_3, bool bool_3, Color color_2) : base(class911_1, int_5, vector2_1, float_3, bool_3, color_2, 0, false)
		{
			Class802.smethod_34(Enum96.const_3, new Delegate46(this.method_8), Enum98.const_2, Enum97.const_1);
			Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_9), Enum98.const_2, Enum97.const_1);
		}

		// Token: 0x06002598 RID: 9624
		// RVA: 0x000E2AC0 File Offset: 0x000E0CC0
		private bool method_8(object object_0, EventArgs eventArgs_0)
		{
			Class750 class = null;
			foreach (Class750 current in this.list_1)
			{
				if (current != this.class750_2 && current.class531_0.vmethod_1())
				{
					class = current;
					break;
				}
			}
			if (class == null || (this.float_2 != 0f && Math.Abs(Class800.smethod_19().X - this.float_2) <= 20f && Class115.int_1 - this.int_3 <= 500) || Class115.int_1 - this.int_3 <= 100)
			{
				return this.class750_2 != null;
			}
			if (this.class750_3 == class && this.int_4 == ((Class800.smethod_19().X > this.float_2) ? 1 : -1) && Class115.int_1 - this.int_3 < 500)
			{
				return true;
			}
			this.class750_3 = class;
			this.int_3 = Class115.int_1;
			this.list_1.IndexOf(this.class750_2);
			int index = this.list_1.IndexOf(class);
			if (this.class750_2 != null)
			{
				this.list_1.Remove(this.class750_2);
				this.int_4 = ((Class800.smethod_19().X > this.float_2) ? 1 : -1);
				this.float_2 = Class800.smethod_19().X;
				this.list_1.Insert(index, this.class750_2);
			}
			this.vmethod_1();
			return true;
		}

		// Token: 0x0600259A RID: 9626
		// RVA: 0x0001D3B7 File Offset: 0x0001B5B7
		private bool method_9(object object_0, EventArgs eventArgs_0)
		{
			this.class750_2 = null;
			this.class750_3 = null;
			this.float_2 = 0f;
			return false;
		}

		// Token: 0x06002599 RID: 9625
		// RVA: 0x0001D3A5 File Offset: 0x0001B5A5
		public override void Remove(Class750 class750_4)
		{
			base.Remove(class750_4);
			this.method_9(this, null);
		}

		// Token: 0x06002596 RID: 9622
		// RVA: 0x000E2AA4 File Offset: 0x000E0CA4
		protected override Class750 vmethod_0(string string_0, object object_0, Vector2 vector2_1, float float_3)
		{
			return base.vmethod_0(string_0, object_0, vector2_1, float_3);
		}

		// Token: 0x06002597 RID: 9623
		// RVA: 0x0001D37F File Offset: 0x0001B57F
		protected override void vmethod_2(object sender, EventArgs e)
		{
			base.vmethod_2(sender, e);
			this.class750_2 = (sender as Class750);
			this.float_2 = Class800.smethod_19().X;
		}
	}
}
