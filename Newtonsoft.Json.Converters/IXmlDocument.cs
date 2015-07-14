using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C1 RID: 193
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x17000113 RID: 275
		IXmlElement DocumentElement
		{
			// Token: 0x060006A9 RID: 1705
			get;
		}

		// Token: 0x060006A7 RID: 1703
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x060006A8 RID: 1704
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x0600069F RID: 1695
		IXmlNode CreateCDataSection(string data);

		// Token: 0x0600069D RID: 1693
		IXmlNode CreateComment(string text);

		// Token: 0x060006A5 RID: 1701
		IXmlElement CreateElement(string elementName);

		// Token: 0x060006A6 RID: 1702
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x060006A4 RID: 1700
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x060006A1 RID: 1697
		IXmlNode CreateSignificantWhitespace(string text);

		// Token: 0x0600069E RID: 1694
		IXmlNode CreateTextNode(string text);

		// Token: 0x060006A0 RID: 1696
		IXmlNode CreateWhitespace(string text);

		// Token: 0x060006A2 RID: 1698
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x060006A3 RID: 1699
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
	}
}
