using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns23;
using ns26;
using ns29;
using ns59;
using ns64;
using ns70;
using ns79;
using ns9;
using System;

namespace ns22
{
	// Token: 0x020003BB RID: 955
	internal class Class103 : Class54
	{
		// Token: 0x0400179D RID: 6045
		protected Class297 class297_0;

		// Token: 0x0400179E RID: 6046
		protected Class911 class911_0;

		// Token: 0x040017A0 RID: 6048
		protected Color color_0 = new Color(50, 188, 231);

		// Token: 0x040017A1 RID: 6049
		protected Color color_1 = new Color(87, 227, 19);

		// Token: 0x040017A2 RID: 6050
		protected Color color_2 = new Color(218, 174, 70);

		// Token: 0x0400179F RID: 6047
		protected int int_1;

		// Token: 0x06001DC0 RID: 7616
		// RVA: 0x000A212C File Offset: 0x000A032C
		internal Class103(Class114 class114_1, Class297 class297_1) : base(class114_1)
		{
			this.class297_0 = class297_1;
			this.class911_0 = new Class911(true);
			this.class911_0.float_0 = 0f;
			this.Initialize();
		}

		// Token: 0x06001DC1 RID: 7617
		// RVA: 0x000187FD File Offset: 0x000169FD
		internal new void Dispose()
		{
			this.class911_0.Dispose();
		}

		// Token: 0x06001DC5 RID: 7621
		// RVA: 0x0001880A File Offset: 0x00016A0A
		internal void Draw()
		{
			this.class911_0.Draw();
		}

		// Token: 0x06001DC7 RID: 7623
		// RVA: 0x000A21AC File Offset: 0x000A03AC
		public override void imethod_2()
		{
			if ((Class62.bool_9 || Class331.int_7 > this.int_1 || (Class62.class62_0.enum110_0 != Enum110.const_2 && Class62.class62_0.enum110_0 != Enum110.const_3)) && this.class911_0.float_0 > 0f)
			{
				this.class911_0.float_1 = (float)Math.Max(0.0, (double)(1f - 4f * this.class911_0.float_0) - 0.039999999105930328 * Class115.double_0);
				this.class911_0.float_0 = (float)Math.Max(0.0, (double)this.class911_0.float_0 - 0.039999999105930328 * Class115.double_0);
			}
		}

		// Token: 0x06001DC2 RID: 7618
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal new virtual void Initialize()
		{
		}

		// Token: 0x06001DC6 RID: 7622
		// RVA: 0x00018818 File Offset: 0x00016A18
		protected void method_1()
		{
			this.class911_0.float_1 = 0f;
			this.class911_0.float_0 = 1f;
		}

		// Token: 0x06001DBF RID: 7615
		// RVA: 0x000187F0 File Offset: 0x000169F0
		protected virtual float vmethod_0()
		{
			return (float)Class341.class607_4.Value;
		}

		// Token: 0x06001DC3 RID: 7619
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_1(Enum61 enum61_0)
		{
		}

		// Token: 0x06001DC4 RID: 7620
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_2(Class304 class304_0, int? nullable_0)
		{
		}
	}
}
