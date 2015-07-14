using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns77;
using ns84;
using osu.Graphics.Sprites;
using System;

namespace ns79
{
	// Token: 0x02000583 RID: 1411
	internal sealed class Class541 : Class531
	{
		// Token: 0x040025AD RID: 9645
		internal Class915 class915_0;

		// Token: 0x040025AB RID: 9643
		internal int int_7;

		// Token: 0x040025AC RID: 9644
		private int int_8;

		// Token: 0x06002D41 RID: 11585
		// RVA: 0x00125ED8 File Offset: 0x001240D8
		internal Class541(string string_1, int int_9) : base(null, Enum115.const_3, Origins.Centre, Enum114.const_1, Vector2.get_Zero(), 0.1f, true, Color.get_White(), null)
		{
			this.class915_0 = new Class915(string_1);
			this.class915_0.int_7 = int_9;
			this.int_7 = int_9 + this.class915_0.int_1;
			this.int_6 = this.class915_0.method_5();
			this.int_5 = this.class915_0.method_6();
			this.vector2_5 = new Vector2((float)(this.class915_0.method_5() / 2), (float)(this.class915_0.method_6() / 2));
			this.int_4 = this.int_6;
			this.int_1 = this.int_5;
			this.method_50(int_9);
		}

		// Token: 0x06002D46 RID: 11590
		// RVA: 0x0002236F File Offset: 0x0002056F
		internal override void Dispose(bool bool_15)
		{
			if (this.class915_0 != null)
			{
				this.class915_0.Dispose();
			}
			this.class915_0 = null;
			base.Dispose(bool_15);
		}

		// Token: 0x06002D42 RID: 11586
		// RVA: 0x00022338 File Offset: 0x00020538
		internal int method_49()
		{
			return this.int_8;
		}

		// Token: 0x06002D43 RID: 11587
		// RVA: 0x00022340 File Offset: 0x00020540
		internal void method_50(int int_9)
		{
			this.int_8 = int_9;
			this.class915_0.int_7 = int_9;
		}

		// Token: 0x06002D45 RID: 11589
		// RVA: 0x00022362 File Offset: 0x00020562
		internal void method_51()
		{
			this.class915_0.method_7();
		}

		// Token: 0x06002D47 RID: 11591
		// RVA: 0x00125F94 File Offset: 0x00124194
		internal void method_52(bool bool_15)
		{
			int num = Class331.int_8 - this.method_49();
			if (num < 0)
			{
				num = 0;
			}
			this.class915_0.Seek(num, bool_15);
		}

		// Token: 0x06002D44 RID: 11588
		// RVA: 0x00022355 File Offset: 0x00020555
		internal override Class731 vmethod_6()
		{
			return this.class915_0.method_4();
		}
	}
}
