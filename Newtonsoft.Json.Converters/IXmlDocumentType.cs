using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C7 RID: 199
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x17000120 RID: 288
		string InternalSubset
		{
			// Token: 0x060006CD RID: 1741
			get;
		}

		// Token: 0x1700011D RID: 285
		string Name
		{
			// Token: 0x060006CA RID: 1738
			get;
		}

		// Token: 0x1700011F RID: 287
		string Public
		{
			// Token: 0x060006CC RID: 1740
			get;
		}

		// Token: 0x1700011E RID: 286
		string System
		{
			// Token: 0x060006CB RID: 1739
			get;
		}
	}
}
