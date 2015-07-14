using Microsoft.Xna.Framework;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020004E8 RID: 1256
	internal sealed class Class415 : Class413
	{
		// Token: 0x04002191 RID: 8593
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x06002887 RID: 10375
		// RVA: 0x000FE924 File Offset: 0x000FCB24
		internal Class415(Class911 class911_1) : base(class911_1, "")
		{
			if (Class885.smethod_25())
			{
				this.class536_0.vector2_1 = new Vector2(56f, 211f);
				this.class536_0.vector2_0 = new Vector2(56f, 211f);
				this.class536_0.vector2_5 = Vector2.get_Zero();
				this.class536_1.vector2_1 = new Vector2(56f, 211f);
				this.class536_1.vector2_5 = Vector2.get_Zero();
				this.class536_0.bool_21 = true;
			}
			else
			{
				this.class536_0.vector2_1 = new Vector2(53f, 211f);
				this.class536_0.vector2_0 = new Vector2(53f, 211f);
				this.class536_0.vector2_5 = Vector2.get_Zero();
				this.class536_1.vector2_1 = new Vector2(53f, 211f);
				this.class536_1.vector2_5 = Vector2.get_Zero();
			}
			this.class536_0.float_2 = 0.8f;
			this.class536_1.float_2 = 0.8f;
			this.class536_0.origins_0 = Origins.BottomCentre;
		}

		// Token: 0x0600288C RID: 10380
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_0)
		{
			return class746_0.byte_0 == 1;
		}

		// Token: 0x06002888 RID: 10376
		// RVA: 0x00018B84 File Offset: 0x00016D84
		protected override string vmethod_3()
		{
			return this.int_0.ToString();
		}

		// Token: 0x0600288A RID: 10378
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x06002889 RID: 10377
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_5()
		{
		}

		// Token: 0x0600288B RID: 10379
		// RVA: 0x000FEA5C File Offset: 0x000FCC5C
		protected override void vmethod_9(bool bool_0)
		{
			List<Class746> arg_28_0 = this.class536_0.class26_0;
			if (Class415.predicate_2 == null)
			{
				Class415.predicate_2 = new Predicate<Class746>(Class415.smethod_2);
			}
			arg_28_0.RemoveAll(Class415.predicate_2);
			Class746 class = new Class746(TransformationType.VectorScale, new Vector2(1f, 1.4f), new Vector2(1f, 1f), Class115.int_1, Class115.int_1 + 300, Enum70.const_0);
			class.enum70_0 = Enum70.const_1;
			class.byte_0 = 1;
			this.class536_0.class26_0.Add(class);
		}
	}
}
