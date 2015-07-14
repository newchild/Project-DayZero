using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C5 RID: 197
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x17000118 RID: 280
		string Encoding
		{
			// Token: 0x060006C0 RID: 1728
			get;
			// Token: 0x060006C1 RID: 1729
			set;
		}

		// Token: 0x17000119 RID: 281
		string Standalone
		{
			// Token: 0x060006C2 RID: 1730
			get;
			// Token: 0x060006C3 RID: 1731
			set;
		}

		// Token: 0x17000117 RID: 279
		string Version
		{
			// Token: 0x060006BF RID: 1727
			get;
		}
	}
}
