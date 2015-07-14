using ns79;
using System;

namespace ns77
{
	// Token: 0x0200044A RID: 1098
	internal abstract class Class520 : IDisposable
	{
		// Token: 0x04001BA2 RID: 7074
		internal Class911 class911_0;

		// Token: 0x06002371 RID: 9073
		// RVA: 0x0001C0D6 File Offset: 0x0001A2D6
		public Class520(bool bool_0)
		{
			this.class911_0 = new Class911(bool_0);
		}

		// Token: 0x06002376 RID: 9078
		// RVA: 0x0001C105 File Offset: 0x0001A305
		public void Dispose()
		{
			GC.SuppressFinalize(this);
			this.Dispose(false);
		}

		// Token: 0x06002372 RID: 9074
		// RVA: 0x0001C0EA File Offset: 0x0001A2EA
		internal virtual void Dispose(bool bool_0)
		{
			this.class911_0.Dispose();
		}

		// Token: 0x06002374 RID: 9076
		// RVA: 0x0001C0F7 File Offset: 0x0001A2F7
		internal virtual void Draw()
		{
			this.class911_0.Draw();
		}

		// Token: 0x06002373 RID: 9075
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Initialize()
		{
		}

		// Token: 0x06002375 RID: 9077
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_0()
		{
		}
	}
}
