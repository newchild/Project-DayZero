using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns23;
using ns26;
using ns70;
using ns79;
using ns80;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;

namespace ns63
{
	// Token: 0x02000546 RID: 1350
	internal sealed class Class317 : Class316
	{
		// Token: 0x02000547 RID: 1351
		[CompilerGenerated]
		private sealed class Class717
		{
			// Token: 0x0400246C RID: 9324
			public Class746 class746_0;

			// Token: 0x0400246D RID: 9325
			public Class746 class746_1;

			// Token: 0x06002BB8 RID: 11192
			// RVA: 0x00021616 File Offset: 0x0001F816
			public void ctor>b__a(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_1);
			}

			// Token: 0x06002BB7 RID: 11191
			// RVA: 0x00021603 File Offset: 0x0001F803
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
			}
		}

		// Token: 0x0400246B RID: 9323
		private int int_6;

		// Token: 0x06002BB1 RID: 11185
		// RVA: 0x0011BCC8 File Offset: 0x00119EC8
		public Class317(Class297 class297_1, Vector2 vector2_2, int int_7, bool bool_8, HitObjectSoundType hitObjectSoundType_0, string string_1, int int_8) : base(class297_1, vector2_2, int_7, bool_8, hitObjectSoundType_0, string_1)
		{
			Class317.Class717 class = new Class317.Class717();
			Class496 class2 = this.class297_0.class494_0 as Class496;
			float float_ = (float)class2.class30_0.method_3() * 1.6f + 0.6f;
			class.class746_0 = new Class746(TransformationType.Scale, float_, 0.6f, this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0);
			this.list_1.ForEach(new Action<Class531>(class.method_0));
			class.class746_1 = new Class746(TransformationType.Rotation, Class562.smethod_6(-1f, 1f), Class562.smethod_6(-1f, 1f), this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0);
			this.list_1.ForEach(delegate(Class531 class531_0)
			{
				class531_0.class26_0.Add(class.class746_1);
			});
			if (this.class297_0.list_2.Count > 0)
			{
				base.vmethod_0(this.class297_0.list_2[class2.class30_0.method_2(0, this.class297_0.list_2.Count)]);
			}
			this.Type &= ~HitObjectType.NewCombo;
			this.int_6 = int_8;
		}

		// Token: 0x06002BB5 RID: 11189
		// RVA: 0x000215FB File Offset: 0x0001F7FB
		public void method_10()
		{
			base.vmethod_12();
		}

		// Token: 0x06002BB3 RID: 11187
		// RVA: 0x0011BE44 File Offset: 0x0011A044
		internal override void vmethod_0(Color color_0)
		{
			Color color_ = color_0;
			switch (Class562.smethod_1(0, 3))
			{
			case 1:
				color_..ctor(255, 192, 0);
				break;
			case 2:
				color_..ctor(214, 221, 28);
				break;
			default:
				color_..ctor(255, 240, 0);
				break;
			}
			base.vmethod_0(color_);
		}

		// Token: 0x06002BB2 RID: 11186
		// RVA: 0x0011BE0C File Offset: 0x0011A00C
		internal override void vmethod_12()
		{
			Class339 class = Class331.smethod_59("metronomelow", Class331.smethod_81(), Enum112.flag_5);
			class.method_3(0.77f + (float)this.int_6 * 0.006f);
		}

		// Token: 0x06002BB4 RID: 11188
		// RVA: 0x000215BB File Offset: 0x0001F7BB
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			if (this.bool_6)
			{
				this.enum61_0 = Enum61.flag_26;
				this.vmethod_12();
			}
			else
			{
				this.enum61_0 = Enum61.flag_5;
			}
			this.vmethod_8(this.enum61_0 > Enum61.flag_5);
			return this.enum61_0;
		}

		// Token: 0x06002BB0 RID: 11184
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_23()
		{
			return false;
		}
	}
}
