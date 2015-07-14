using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns23;
using ns29;
using ns59;
using ns70;
using ns76;
using ns79;
using ns80;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Runtime.CompilerServices;

namespace ns63
{
	// Token: 0x02000542 RID: 1346
	internal class Class316 : Class305
	{
		// Token: 0x02000543 RID: 1347
		[CompilerGenerated]
		private sealed class Class714
		{
			// Token: 0x04002466 RID: 9318
			public Class746 class746_0;

			// Token: 0x04002467 RID: 9319
			public float float_0;

			// Token: 0x06002BAB RID: 11179
			// RVA: 0x0002157B File Offset: 0x0001F77B
			public void ctor>b__0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
				class531_0.float_1 = this.float_0;
			}
		}

		// Token: 0x02000544 RID: 1348
		[CompilerGenerated]
		private sealed class Class715
		{
			// Token: 0x04002468 RID: 9320
			public Class316.Class714 class714_0;

			// Token: 0x04002469 RID: 9321
			public Class746 class746_0;

			// Token: 0x06002BAD RID: 11181
			// RVA: 0x0002159A File Offset: 0x0001F79A
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
			}
		}

		// Token: 0x02000545 RID: 1349
		[CompilerGenerated]
		private sealed class Class716
		{
			// Token: 0x0400246A RID: 9322
			public Vector2 vector2_0;

			// Token: 0x06002BAF RID: 11183
			// RVA: 0x000215AD File Offset: 0x0001F7AD
			public void method_0(Class531 class531_0)
			{
				class531_0.vector2_1 = this.vector2_0;
			}
		}

		// Token: 0x04002460 RID: 9312
		public bool bool_6;

		// Token: 0x04002465 RID: 9317
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04002462 RID: 9314
		public Class304 class304_0;

		// Token: 0x0400245E RID: 9310
		private Class531 class531_0;

		// Token: 0x0400245F RID: 9311
		private Class531 class531_1;

		// Token: 0x04002464 RID: 9316
		private Class531 class531_2;

		// Token: 0x04002463 RID: 9315
		internal float float_0;

		// Token: 0x04002461 RID: 9313
		public Vector2 vector2_1;

		// Token: 0x17000395 RID: 917
		public override int ComboNumber
		{
			// Token: 0x06002B98 RID: 11160
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return 0;
			}
			// Token: 0x06002B99 RID: 11161
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		public override Vector2 EndPosition
		{
			// Token: 0x06002B9C RID: 11164
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x06002B9D RID: 11165
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000393 RID: 915
		public override bool NewCombo
		{
			// Token: 0x06002B9A RID: 11162
			// RVA: 0x00021539 File Offset: 0x0001F739
			get;
			// Token: 0x06002B9B RID: 11163
			// RVA: 0x00021541 File Offset: 0x0001F741
			set;
		}

		// Token: 0x06002B97 RID: 11159
		// RVA: 0x0011B7E8 File Offset: 0x001199E8
		public Class316(Class297 class297_1, Vector2 vector2_2, int int_6, bool bool_8, HitObjectSoundType hitObjectSoundType_0, string string_1) : base(class297_1)
		{
			this.Position = new Vector2(Class778.smethod_2(vector2_2.X, 0f, (float)Class115.int_18), 340f);
			this.vector2_0 = this.Position;
			this.StartTime = int_6;
			this.EndTime = int_6;
			this.SoundType = hitObjectSoundType_0;
			this.NewCombo = bool_8;
			if (class297_1.class911_0 != null)
			{
				Class316.Class714 class = new Class316.Class714();
				this.class531_0 = new Class531(Class885.Load("fruit-" + string_1, Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)this.StartTime), false, Color.get_White(), null);
				this.list_1.Add(this.class531_0);
				this.list_0.Add(this.class531_0);
				this.class531_0.int_0 = 1;
				this.class531_1 = new Class531(Class885.Load("fruit-" + string_1 + "-overlay", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.StartTime - 1)), false, Color.get_White(), null);
				this.list_1.Add(this.class531_1);
				this.list_0.Add(this.class531_1);
				this.class531_2 = new Class531(Class885.Load("fruit-" + string_1, Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.StartTime + 1)), false, Color.get_TransparentBlack(), null);
				this.class531_2.bool_7 = true;
				this.list_1.Add(this.class531_2);
				this.list_0.Add(this.class531_2);
				class.class746_0 = new Class746(new Vector2(this.Position.X, -100f), new Vector2(this.Position.X, 340f), this.StartTime - this.class297_0.PreEmpt, this.StartTime, Enum70.const_0);
				Class746 expr_1F4_cp_0 = class.class746_0;
				expr_1F4_cp_0.vector2_1.Y = expr_1F4_cp_0.vector2_1.Y + (class.class746_0.vector2_1.Y - class.class746_0.vector2_0.Y) * 0.2f;
				class.class746_0.int_1 += (int)((float)class.class746_0.method_0() * 0.2f);
				class.float_0 = Class562.smethod_6(-0.2f, 0.2f);
				this.list_1.ForEach(delegate(Class531 class531_0)
				{
					class531_0.class26_0.Add(class.class746_0);
					class531_0.float_1 = class.float_0;
				});
				if (Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden))
				{
					Class316.Class715 class2 = new Class316.Class715();
					class2.class714_0 = class;
					class2.class746_0 = new Class746(TransformationType.Fade, 1f, 0f, int_6 - (int)((double)this.class297_0.PreEmpt * 0.6), int_6 - (int)((double)this.class297_0.PreEmpt * 0.44), Enum70.const_0);
					this.list_1.ForEach(new Action<Class531>(class2.method_0));
				}
			}
		}

		// Token: 0x06002BA2 RID: 11170
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Class304 Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002B95 RID: 11157
		// RVA: 0x0002152B File Offset: 0x0001F72B
		public bool method_8()
		{
			return this.class304_0 != null;
		}

		// Token: 0x06002BA9 RID: 11177
		// RVA: 0x0011BB94 File Offset: 0x00119D94
		internal void method_9(Class304 class304_1)
		{
			if (this.method_8())
			{
				return;
			}
			this.float_0 = 0f;
			this.class304_0 = class304_1;
			if (this.class297_0.class911_0 == null)
			{
				return;
			}
			this.class531_2.color_0 = Class885.smethod_3().method_2();
			Class746 class = new Class746(TransformationType.Scale, this.class531_0.float_2 * 1.2f, this.class531_0.float_2 * 1.3f, this.class531_0.class26_0[0].int_0, this.class531_0.class26_0[0].int_0 + 500, Enum70.const_0);
			class.bool_0 = true;
			this.class531_2.class26_0.Add(class);
			if (!Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden))
			{
				class = new Class746(TransformationType.Fade, 1f, 0.5f, this.class531_0.class26_0[0].int_0, this.class531_0.class26_0[0].int_0 + 500, Enum70.const_0);
				class.bool_0 = true;
				this.class531_2.class26_0.Add(class);
			}
		}

		// Token: 0x06002BA3 RID: 11171
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void Select()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002B9F RID: 11167
		// RVA: 0x00021557 File Offset: 0x0001F757
		internal override void vmethod_0(Color color_0)
		{
			base.vmethod_0(color_0);
			if (this.class531_0 != null)
			{
				this.class531_0.color_0 = color_0;
			}
			this.Colour = color_0;
		}

		// Token: 0x06002BA7 RID: 11175
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002BA8 RID: 11176
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002BA0 RID: 11168
		// RVA: 0x0011BAF4 File Offset: 0x00119CF4
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			if (this.bool_6)
			{
				this.enum61_0 = Enum61.flag_16;
				this.vmethod_12();
			}
			else
			{
				this.enum61_0 = (this.vmethod_23() ? Enum61.flag_3 : Enum61.flag_2);
			}
			this.vmethod_8(this.enum61_0 > Enum61.flag_5);
			return this.enum61_0;
		}

		// Token: 0x06002B96 RID: 11158
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_23()
		{
			return true;
		}

		// Token: 0x06002BA4 RID: 11172
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_3()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002BA5 RID: 11173
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_4(int int_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002BA6 RID: 11174
		// RVA: 0x0011BB54 File Offset: 0x00119D54
		internal override void vmethod_5(Vector2 vector2_2, bool bool_8)
		{
			Class316.Class716 class = new Class316.Class716();
			class.vector2_0 = vector2_2;
			base.vmethod_5(class.vector2_0, bool_8);
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002BA1 RID: 11169
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_8(bool bool_8)
		{
		}

		// Token: 0x06002B9E RID: 11166
		// RVA: 0x0002154A File Offset: 0x0001F74A
		internal override bool vmethod_9()
		{
			return this.class531_0.bool_3;
		}
	}
}
