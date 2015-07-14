using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns69;
using ns77;
using ns79;
using ns80;
using System;

namespace ns22
{
	// Token: 0x020003C1 RID: 961
	internal sealed class Class411 : Class410
	{
		// Token: 0x06001DFA RID: 7674
		// RVA: 0x000A3814 File Offset: 0x000A1A14
		internal Class411(Class421 class421_0) : base(class421_0.class911_1)
		{
			this.class531_1.method_8(true);
			this.class531_0.float_1 = -1.5708f;
			this.class538_0.float_1 = -1.5708f;
			this.class531_0.float_2 = 0.7f;
			this.class538_0.float_2 = 0.7f;
			this.class531_0.vector2_2 = new Vector2(1f, class421_0.method_31());
			this.class538_0.vector2_2 = new Vector2(1f, class421_0.method_31());
			this.class531_0.vector2_1 = new Vector2(class421_0.method_23() + class421_0.float_0 + 1f, class421_0.Top + class421_0.method_20());
			if (this.bool_2)
			{
				this.class538_0.vector2_1 = new Vector2(class421_0.method_23() + class421_0.float_0 + 6.6f, class421_0.Top + 474.8f * class421_0.method_31());
			}
			else
			{
				this.class538_0.vector2_1 = new Vector2(class421_0.method_23() + class421_0.float_0 + 8f, class421_0.Top + 478f * class421_0.method_31());
			}
			this.bool_0 = false;
			this.class911_0.Add<Class531>(this.list_0);
		}

		// Token: 0x06001DFD RID: 7677
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void Draw()
		{
		}

		// Token: 0x06001E04 RID: 7684
		// RVA: 0x00018A78 File Offset: 0x00016C78
		internal override void Reset()
		{
			base.Reset();
			this.vmethod_10(200.0);
		}

		// Token: 0x06001DFB RID: 7675
		// RVA: 0x00018A65 File Offset: 0x00016C65
		protected override Class731[] vmethod_1(string string_0)
		{
			return Class885.smethod_27(string_0, Enum112.flag_5, true);
		}

		// Token: 0x06001DFC RID: 7676
		// RVA: 0x00018A6F File Offset: 0x00016C6F
		protected override Class731 vmethod_2(string string_0)
		{
			return Class885.Load(string_0, Enum112.flag_5);
		}

		// Token: 0x06001E03 RID: 7683
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_3()
		{
		}

		// Token: 0x06001E02 RID: 7682
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x06001DFE RID: 7678
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_6()
		{
		}

		// Token: 0x06001E01 RID: 7681
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_7(Color color_0)
		{
		}

		// Token: 0x06001E00 RID: 7680
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_8()
		{
		}

		// Token: 0x06001DFF RID: 7679
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_9()
		{
		}
	}
}
