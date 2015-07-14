using Microsoft.Xna.Framework.Graphics;
using ns85;
using System;
using System.Collections.Generic;

namespace ns84
{
	// Token: 0x02000480 RID: 1152
	internal interface Interface17 : IDisposable, Interface16
	{
		// Token: 0x06002506 RID: 9478
		void Draw(List<Class880> list_0, Class880 class880_0, float float_0, int int_0);

		// Token: 0x06002507 RID: 9479
		void Draw(List<Class880> list_0, Class880 class880_0, float float_0, int int_0, Color color_0);

		// Token: 0x06002502 RID: 9474
		Color imethod_0();

		// Token: 0x06002503 RID: 9475
		void imethod_1(Color color_0);

		// Token: 0x06002504 RID: 9476
		Color imethod_2();

		// Token: 0x06002505 RID: 9477
		void imethod_3(List<Color> list_0, Color color_0, Color color_1, Color color_2, float float_0);
	}
}
