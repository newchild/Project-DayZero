using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000065 RID: 101
	public interface IJsonLineInfo
	{
		// Token: 0x1700007B RID: 123
		int LineNumber
		{
			// Token: 0x060002C7 RID: 711
			get;
		}

		// Token: 0x1700007C RID: 124
		int LinePosition
		{
			// Token: 0x060002C8 RID: 712
			get;
		}

		// Token: 0x060002C6 RID: 710
		bool HasLineInfo();
	}
}
