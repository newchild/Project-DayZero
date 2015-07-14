using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns27;
using ns79;
using ns90;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;

namespace ns5
{
	// Token: 0x020004D6 RID: 1238
	internal sealed class Class96 : Class89
	{
		// Token: 0x0400210A RID: 8458
		private readonly bMatch bMatch_0;

		// Token: 0x0400210C RID: 8460
		private Class754 class754_0;

		// Token: 0x0400210B RID: 8459
		private readonly List<Class531> list_1 = new List<Class531>();

		// Token: 0x060027E3 RID: 10211
		// RVA: 0x0001EB41 File Offset: 0x0001CD41
		internal Class96(bMatch bMatch_1) : base("Joining this game requires a password...", true)
		{
			this.bMatch_0 = bMatch_1;
		}

		// Token: 0x060027E7 RID: 10215
		// RVA: 0x000177F4 File Offset: 0x000159F4
		protected override void Dispose(bool bool_5)
		{
			base.Dispose(bool_5);
		}

		// Token: 0x060027E6 RID: 10214
		// RVA: 0x000F87EC File Offset: 0x000F69EC
		private void method_10(object sender, EventArgs e)
		{
			if (Class70.enum59_0 == Enum59.const_2)
			{
				return;
			}
			if (this.class754_0.class533_0.Text.Length == 0)
			{
				Class723.smethod_4("Enter a password before attempting to start the game...");
				return;
			}
			Class70.smethod_5(this.bMatch_0, this.class754_0.class533_0.Text);
			this.Close(false);
		}

		// Token: 0x060027E5 RID: 10213
		// RVA: 0x0001EB61 File Offset: 0x0001CD61
		private void method_9(object sender, EventArgs e)
		{
			if (Class70.enum59_0 == Enum59.const_2)
			{
				return;
			}
			this.Close(false);
		}

		// Token: 0x060027E4 RID: 10212
		// RVA: 0x000F86D8 File Offset: 0x000F68D8
		internal override void vmethod_3()
		{
			Class533 class = new Class533("Password:", 16f, new Vector2(30f, 120f), 0.92f, true, Color.get_White());
			this.class911_0.Add(class);
			this.list_1.Add(class);
			this.class754_0 = new Class754("", 16, new Vector2(150f, 120f), 450f, 0.92f, false);
			this.class754_0.int_0 = 50;
			this.float_0 = 180f;
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			base.method_3("Join Game", Color.get_LimeGreen(), new EventHandler(this.method_10), false, false, true);
			base.method_3("Cancel", Color.get_LightGray(), new EventHandler(this.method_9), false, false, true);
			base.vmethod_3();
			this.class531_0.color_0 = new Color(15, 59, 87, 200);
			this.class754_0.Select();
		}

		// Token: 0x060027E8 RID: 10216
		// RVA: 0x0001EB73 File Offset: 0x0001CD73
		internal override bool vmethod_5(Keys keys_0)
		{
			if (!base.vmethod_5(keys_0))
			{
				return false;
			}
			if (keys_0 == 13)
			{
				this.method_10(null, null);
			}
			return true;
		}
	}
}
