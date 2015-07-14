using Microsoft.Xna.Framework;
using ns27;
using ns79;
using ns80;
using System;

namespace ns20
{
	// Token: 0x020003AA RID: 938
	internal sealed class Class398 : Class390
	{
		// Token: 0x040016F8 RID: 5880
		private Class531 class531_0;

		// Token: 0x06001CF3 RID: 7411
		// RVA: 0x0009B40C File Offset: 0x0009960C
		public Class398()
		{
			base.method_1(new Vector2(244f, 30f));
			this.class531_0 = Class599.smethod_0(Class885.smethod_37());
			this.class531_0.enum115_0 = Enum115.const_5;
			this.class531_0.vector2_2 = new Vector2(0.5f, 0.5f);
			this.class531_0.vector2_1 = new Vector2(base.method_0().X / 2f, base.method_0().Y / 2f);
			this.class911_0.Add(this.class531_0);
		}

		// Token: 0x06001CF4 RID: 7412
		// RVA: 0x00017DEB File Offset: 0x00015FEB
		public override void Dispose()
		{
			base.Dispose();
			this.class531_0.Dispose();
		}
	}
}
