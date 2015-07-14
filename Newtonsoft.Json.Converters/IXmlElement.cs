using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C3 RID: 195
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x17000115 RID: 277
		bool IsEmpty
		{
			// Token: 0x060006BA RID: 1722
			get;
		}

		// Token: 0x060006B9 RID: 1721
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x060006B8 RID: 1720
		void SetAttributeNode(IXmlNode attribute);
	}
}
