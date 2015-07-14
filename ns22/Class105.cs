using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns29;
using ns59;
using ns79;
using ns80;
using ns9;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020003BD RID: 957
	internal class Class105 : Class103
	{
		// Token: 0x040017A5 RID: 6053
		protected Class531 class531_0;

		// Token: 0x040017A7 RID: 6055
		private Class531 class531_1;

		// Token: 0x040017A6 RID: 6054
		private float float_0;

		// Token: 0x06001DD1 RID: 7633
		// RVA: 0x00018848 File Offset: 0x00016A48
		internal Class105(Class114 class114_1, Class297 class297_1) : base(class114_1, class297_1)
		{
		}

		// Token: 0x06001DD2 RID: 7634
		// RVA: 0x000A25F0 File Offset: 0x000A07F0
		internal override void Initialize()
		{
			float arg_0B_0 = this.vmethod_3().X;
			float arg_18_0 = this.vmethod_4() / 2f;
			float num = this.vmethod_4();
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-num / 2f, this.method_2() * 2f), 0.79f, true, Color.get_Black(), null);
			class.float_3 = 0.6f;
			class.vector2_2 = new Vector2(num, this.method_2() * 4f) * 1.6f;
			this.class911_0.Add(class);
			num = (float)this.class297_0.HitWindow300 / this.method_3() * this.vmethod_4();
			Class531 class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-num / 2f, this.method_2() / 2f), 0.82f, true, this.color_0, null);
			class2.vector2_2 = new Vector2(num, this.method_2()) * 1.6f;
			this.class911_0.Add(class2);
			num = (float)this.class297_0.HitWindow100 / this.method_3() * this.vmethod_4();
			class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-num / 2f, this.method_2() / 2f), 0.81f, true, this.color_1, null);
			class2.vector2_2 = new Vector2(num, this.method_2()) * 1.6f;
			this.class911_0.Add(class2);
			num = (float)this.class297_0.HitWindow50 / this.method_3() * this.vmethod_4();
			class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-num / 2f, this.method_2() / 2f), 0.8f, true, this.color_2, null);
			class2.vector2_2 = new Vector2(num, this.method_2()) * 1.6f;
			this.class911_0.Add(class2);
			this.class531_1 = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-0.75f, this.method_2() * 2f), 0.83f, true, Color.get_White(), null);
			this.class531_1.vector2_2 = new Vector2(1.5f, this.method_2() * 4f) * 1.6f;
			this.class911_0.Add(this.class531_1);
			this.class531_0 = new Class531(Class885.Load("editor-rate-arrow", Enum112.flag_1), Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(0f, -3f), 0.84f, true, Color.get_White(), null);
			this.class531_0.float_2 = 0.6f * this.vmethod_0();
			this.class911_0.Add(this.class531_0);
		}

		// Token: 0x06001DCD RID: 7629
		// RVA: 0x00018852 File Offset: 0x00016A52
		protected float method_2()
		{
			return 3f * this.vmethod_0();
		}

		// Token: 0x06001DD0 RID: 7632
		// RVA: 0x00018897 File Offset: 0x00016A97
		internal float method_3()
		{
			return (float)this.class297_0.HitWindow50;
		}

		// Token: 0x06001DD3 RID: 7635
		// RVA: 0x000A2900 File Offset: 0x000A0B00
		internal override void vmethod_2(Class304 class304_0, int? nullable_0)
		{
			float num = (float)(nullable_0 ?? (Class331.int_7 - class304_0.StartTime));
			this.int_1 = Class331.int_7 + 4000;
			base.method_1();
			if (num < 0f)
			{
				num = Math.Max(num, -this.method_3());
			}
			else
			{
				num = Math.Min(num, this.method_3());
			}
			float num2 = num / this.method_3() * (this.vmethod_4() / 2f);
			this.float_0 = this.float_0 * 0.8f + num2 * 0.2f;
			this.class531_0.method_19(new Vector2(this.vmethod_3().X + this.float_0, this.class531_0.vector2_0.Y), 800, Enum70.const_1);
			num = Math.Abs(num);
			Class531 class = this.class531_1.Clone();
			class.enum114_0 = Enum114.const_2;
			class.bool_0 = false;
			class.float_0 = 0.85f;
			class.color_0 = ((num <= (float)this.class297_0.HitWindow300) ? this.color_0 : ((num <= (float)this.class297_0.HitWindow100) ? this.color_1 : this.color_2));
			class.vector2_1.X = this.vmethod_3().X + num2;
			class.vector2_2.X = 3f;
			class.float_3 = 0.4f;
			class.bool_7 = true;
			class.method_16(10000, Enum70.const_0);
			this.class911_0.Add(class);
		}

		// Token: 0x06001DCE RID: 7630
		// RVA: 0x00018860 File Offset: 0x00016A60
		internal virtual Vector2 vmethod_3()
		{
			return new Vector2((float)(Class115.smethod_43() / 2), (float)Class115.smethod_44() - this.method_2() * 2f);
		}

		// Token: 0x06001DCF RID: 7631
		// RVA: 0x00018882 File Offset: 0x00016A82
		internal virtual float vmethod_4()
		{
			return (float)this.class297_0.HitWindow50 * this.vmethod_0();
		}
	}
}
