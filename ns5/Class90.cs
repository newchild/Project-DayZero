using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns27;
using ns79;
using System;
using System.Collections.Generic;

namespace ns5
{
	// Token: 0x0200039C RID: 924
	internal sealed class Class90 : Class89
	{
		// Token: 0x040016B2 RID: 5810
		private Class754 class754_0;

		// Token: 0x040016B1 RID: 5809
		private readonly List<Class531> list_1 = new List<Class531>();

		// Token: 0x040016B3 RID: 5811
		internal string string_0;

		// Token: 0x040016B4 RID: 5812
		internal string string_1;

		// Token: 0x06001C8B RID: 7307
		// RVA: 0x000177A7 File Offset: 0x000159A7
		internal Class90(string string_2) : base("Enter a new password...", true)
		{
			this.string_0 = ((string_2 == null) ? "" : string_2);
		}

		// Token: 0x06001C8E RID: 7310
		// RVA: 0x000177DA File Offset: 0x000159DA
		internal override void Close(bool bool_5)
		{
			this.string_1 = this.class754_0.Text;
			base.Close(bool_5);
		}

		// Token: 0x06001C8F RID: 7311
		// RVA: 0x000177F4 File Offset: 0x000159F4
		protected override void Dispose(bool bool_5)
		{
			base.Dispose(bool_5);
		}

		// Token: 0x06001C8D RID: 7309
		// RVA: 0x000177D1 File Offset: 0x000159D1
		private void method_9(object sender, EventArgs e)
		{
			this.Close(false);
		}

		// Token: 0x06001C8C RID: 7308
		// RVA: 0x00099118 File Offset: 0x00097318
		internal override void vmethod_3()
		{
			Class533 class = new Class533("Password:", 16f, new Vector2(30f, 120f), 0.92f, true, Color.get_White());
			this.class911_0.Add(class);
			this.list_1.Add(class);
			this.class754_0 = new Class754(this.string_0, 16, new Vector2(150f, 120f), 450f, 0.92f, false);
			this.class754_0.int_0 = 50;
			this.float_0 = 180f;
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			base.method_3("OK", Color.get_LimeGreen(), new EventHandler(this.method_9), false, false, true);
			base.method_3("Cancel", Color.get_LightGray(), new EventHandler(this.method_9), false, false, true);
			base.vmethod_3();
			this.class531_0.color_0 = new Color(15, 59, 87, 200);
			this.class754_0.Select();
		}

		// Token: 0x06001C90 RID: 7312
		// RVA: 0x000177FD File Offset: 0x000159FD
		internal override bool vmethod_5(Keys keys_0)
		{
			return base.vmethod_5(keys_0);
		}
	}
}
