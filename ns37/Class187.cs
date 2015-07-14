using System;
using System.IO;

namespace ns37
{
	// Token: 0x0200024B RID: 587
	internal sealed class Class187 : Interface12
	{
		// Token: 0x04000F1A RID: 3866
		private Class186 class186_0;

		// Token: 0x06001472 RID: 5234
		// RVA: 0x000126A0 File Offset: 0x000108A0
		public Class187(string string_0)
		{
			this.class186_0 = new Class186(string_0);
		}

		// Token: 0x06001473 RID: 5235
		// RVA: 0x00068C28 File Offset: 0x00066E28
		public virtual bool IsMatch(string string_0)
		{
			bool result = false;
			if (string_0 != null)
			{
				string string_ = (string_0.Length > 0) ? Path.GetFullPath(string_0) : "";
				result = this.class186_0.IsMatch(string_);
			}
			return result;
		}
	}
}
