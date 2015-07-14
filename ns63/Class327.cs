using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns59;
using ns70;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;

namespace ns63
{
	// Token: 0x02000557 RID: 1367
	internal sealed class Class327 : Class325
	{
		// Token: 0x04002499 RID: 9369
		internal List<Class317> list_2 = new List<Class317>();

		// Token: 0x1700039D RID: 925
		public override int ComboNumber
		{
			// Token: 0x06002C3E RID: 11326
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
			// Token: 0x06002C3F RID: 11327
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700039C RID: 924
		public override Vector2 EndPosition
		{
			// Token: 0x06002C40 RID: 11328
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
			// Token: 0x06002C41 RID: 11329
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002C3D RID: 11325
		// RVA: 0x0011EA14 File Offset: 0x0011CC14
		internal Class327(Class297 class297_1, int int_6, int int_7, HitObjectSoundType hitObjectSoundType_0) : base(class297_1, int_6, int_7, hitObjectSoundType_0)
		{
			Class496 class = this.class297_0.class494_0 as Class496;
			bool flag = true;
			float num;
			for (num = (float)(int_7 - int_6); num > 100f; num /= 2f)
			{
			}
			if (num <= 0f)
			{
				return;
			}
			int num2 = 0;
			for (float num3 = (float)int_6; num3 <= (float)int_7; num3 += num)
			{
				Class317 item = new Class317(this.class297_0, new Vector2((float)class.class30_0.method_2(0, 512), 0f), (int)num3, flag && this.NewCombo, this.SoundType, class.method_2(), num2);
				this.list_2.Add(item);
				flag = false;
				num2++;
			}
		}

		// Token: 0x06002C45 RID: 11333
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Class304 Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C46 RID: 11334
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void Select()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C43 RID: 11331
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_0(Color color_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C4A RID: 11338
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C4B RID: 11339
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C44 RID: 11332
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_2()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C47 RID: 11335
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_3()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C48 RID: 11336
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_4(int int_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C49 RID: 11337
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_5(Vector2 vector2_1, bool bool_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C42 RID: 11330
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override bool vmethod_9()
		{
			throw new NotImplementedException();
		}
	}
}
