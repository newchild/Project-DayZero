using Microsoft.Xna.Framework;
using System;

namespace ns14
{
	// Token: 0x020004A0 RID: 1184
	internal sealed class Class609
	{
		// Token: 0x04001F5B RID: 8027
		private bool bool_0;

		// Token: 0x04001F5C RID: 8028
		private float float_0;

		// Token: 0x04001F5D RID: 8029
		private float float_1;

		// Token: 0x04001F5E RID: 8030
		private float float_2;

		// Token: 0x04001F5F RID: 8031
		private float float_3;

		// Token: 0x060025EC RID: 9708
		// RVA: 0x0001D750 File Offset: 0x0001B950
		internal Class609()
		{
			this.bool_0 = false;
		}

		// Token: 0x060025ED RID: 9709
		// RVA: 0x000E3788 File Offset: 0x000E1988
		internal Class609(Vector2[] vector2_0) : this()
		{
			for (int i = 0; i < vector2_0.Length; i++)
			{
				Vector2 vector2_ = vector2_0[i];
				this.Add(vector2_);
			}
		}

		// Token: 0x060025F0 RID: 9712
		// RVA: 0x000E3828 File Offset: 0x000E1A28
		internal void Add(Vector2 vector2_0)
		{
			if (this.bool_0)
			{
				this.float_0 = Math.Min(this.float_0, vector2_0.X);
				this.float_1 = Math.Max(this.float_1, vector2_0.X);
				this.float_2 = Math.Min(this.float_2, vector2_0.Y);
				this.float_3 = Math.Max(this.float_3, vector2_0.Y);
				return;
			}
			this.float_0 = vector2_0.X;
			this.float_1 = vector2_0.X;
			this.float_2 = vector2_0.Y;
			this.float_3 = vector2_0.Y;
			this.bool_0 = true;
		}

		// Token: 0x060025EE RID: 9710
		// RVA: 0x000E37C0 File Offset: 0x000E19C0
		internal float? method_0()
		{
			if (!this.bool_0)
			{
				return null;
			}
			return new float?(this.float_1 - this.float_0);
		}

		// Token: 0x060025EF RID: 9711
		// RVA: 0x000E37F4 File Offset: 0x000E19F4
		internal float? method_1()
		{
			if (!this.bool_0)
			{
				return null;
			}
			return new float?(this.float_3 - this.float_2);
		}
	}
}
