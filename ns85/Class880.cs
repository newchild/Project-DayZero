using Microsoft.Xna.Framework;
using System;

namespace ns85
{
	// Token: 0x02000688 RID: 1672
	internal class Class880 : ICloneable
	{
		// Token: 0x040030A0 RID: 12448
		internal bool bool_0;

		// Token: 0x040030A1 RID: 12449
		internal bool bool_1;

		// Token: 0x0400309E RID: 12446
		internal Vector2 vector2_0;

		// Token: 0x0400309F RID: 12447
		internal Vector2 vector2_1;

		// Token: 0x06003417 RID: 13335
		// RVA: 0x0002652C File Offset: 0x0002472C
		internal Class880(Vector2 vector2_2, Vector2 vector2_3)
		{
			this.vector2_0 = vector2_2;
			this.vector2_1 = vector2_3;
		}

		// Token: 0x0600341C RID: 13340
		// RVA: 0x0000F044 File Offset: 0x0000D244
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06003418 RID: 13336
		// RVA: 0x00166214 File Offset: 0x00164414
		internal float method_0()
		{
			return (this.vector2_1 - this.vector2_0).Length();
		}

		// Token: 0x06003419 RID: 13337
		// RVA: 0x00026542 File Offset: 0x00024742
		internal float method_1()
		{
			return (float)Math.Atan2((double)(this.vector2_1.Y - this.vector2_0.Y), (double)(this.vector2_1.X - this.vector2_0.X));
		}

		// Token: 0x0600341A RID: 13338
		// RVA: 0x0016623C File Offset: 0x0016443C
		internal Matrix method_2()
		{
			Matrix matrix = Matrix.CreateRotationZ(this.method_1());
			Matrix matrix2 = Matrix.CreateTranslation(this.vector2_0.X, this.vector2_0.Y, 0f);
			return matrix * matrix2;
		}

		// Token: 0x0600341B RID: 13339
		// RVA: 0x0002657A File Offset: 0x0002477A
		internal Matrix method_3()
		{
			return Matrix.CreateRotationZ(this.method_1()) * Matrix.CreateTranslation(this.vector2_1.X, this.vector2_1.Y, 0f);
		}
	}
}
