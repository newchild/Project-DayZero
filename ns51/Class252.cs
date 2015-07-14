using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace ns51
{
	// Token: 0x020002D2 RID: 722
	internal sealed class Class252 : IDisposable
	{
		// Token: 0x0400118D RID: 4493
		private bool bool_0;

		// Token: 0x0400118B RID: 4491
		private static MethodInfo methodInfo_0 = typeof(WebHeaderCollection).GetMethod("AddWithoutValidate", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400118C RID: 4492
		private Stream stream_0;

		// Token: 0x060016CE RID: 5838
		// RVA: 0x000141A1 File Offset: 0x000123A1
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			if (this.stream_0 != null)
			{
				this.stream_0.Dispose();
			}
			this.stream_0 = null;
		}
	}
}
