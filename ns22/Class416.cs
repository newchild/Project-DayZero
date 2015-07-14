using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;

namespace ns22
{
	// Token: 0x020004E9 RID: 1257
	internal sealed class Class416 : Class413
	{
		// Token: 0x0600288D RID: 10381
		// RVA: 0x0001F40F File Offset: 0x0001D60F
		internal Class416(Class911 class911_1) : base(class911_1, "")
		{
		}

		// Token: 0x06002893 RID: 10387
		// RVA: 0x0001F41D File Offset: 0x0001D61D
		internal void method_3(float float_0)
		{
			base.vmethod_7();
			this.class536_0.vector2_1.X = float_0;
			this.class536_1.vector2_1.X = float_0;
		}

		// Token: 0x0600288E RID: 10382
		// RVA: 0x000FEAF0 File Offset: 0x000FCCF0
		protected override void vmethod_2()
		{
			this.class536_0 = new Class536(this.vmethod_3(), Class885.class547_0.string_5, Class885.class547_0.int_2, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(2f, 240f), 0.9f, true, Color.get_TransparentWhite(), true);
			this.class536_1 = new Class536("", Class885.class547_0.string_5, Class885.class547_0.int_2, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(2f, 240f), 0.91f, true, Color.get_TransparentWhite(), true);
			this.class536_1.bool_7 = true;
			if (!Class62.bool_15 && !Class62.bool_16)
			{
				this.class911_0.Add(this.class536_0);
				this.class911_0.Add(this.class536_1);
			}
		}

		// Token: 0x0600288F RID: 10383
		// RVA: 0x00018B84 File Offset: 0x00016D84
		protected override string vmethod_3()
		{
			return this.int_0.ToString();
		}

		// Token: 0x06002891 RID: 10385
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x06002890 RID: 10384
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_5()
		{
		}

		// Token: 0x06002892 RID: 10386
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_6()
		{
		}

		// Token: 0x06002894 RID: 10388
		// RVA: 0x0001F447 File Offset: 0x0001D647
		protected override void vmethod_8()
		{
			this.class536_0.method_16(100, Enum70.const_0);
		}

		// Token: 0x06002895 RID: 10389
		// RVA: 0x000FEBC0 File Offset: 0x000FCDC0
		protected override void vmethod_9(bool bool_0)
		{
			this.class536_0.class26_0.Clear();
			this.class536_1.class26_0.Clear();
			this.class536_0.float_3 = 1f;
			Class746 item = new Class746(TransformationType.Scale, 2f, 1f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0)
			{
				enum70_0 = Enum70.const_1,
				byte_0 = 1
			};
			this.class536_0.class26_0.Add(item);
			item = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 1000, Class115.int_1 + 1300, Enum70.const_0)
			{
				byte_0 = 1
			};
			this.class536_0.class26_0.Add(item);
			item = new Class746(TransformationType.Scale, 2f, 2.4f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0)
			{
				enum70_0 = Enum70.const_1,
				byte_0 = 1
			};
			Class746 item2 = new Class746(TransformationType.Fade, 0.7f, 0f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0)
			{
				byte_0 = 1
			};
			this.class536_1.class26_0.Add(item);
			this.class536_1.class26_0.Add(item2);
		}
	}
}
