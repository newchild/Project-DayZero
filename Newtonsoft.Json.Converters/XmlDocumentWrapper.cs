using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C2 RID: 194
	internal sealed class XmlDocumentWrapper : XmlNodeWrapper, IXmlNode, IXmlDocument
	{
		// Token: 0x04000334 RID: 820
		private readonly XmlDocument _document;

		// Token: 0x17000114 RID: 276
		public IXmlElement DocumentElement
		{
			// Token: 0x060006B7 RID: 1719
			// RVA: 0x00009D29 File Offset: 0x00007F29
			get
			{
				if (this._document.DocumentElement == null)
				{
					return null;
				}
				return new XmlElementWrapper(this._document.DocumentElement);
			}
		}

		// Token: 0x060006AA RID: 1706
		// RVA: 0x00009C54 File Offset: 0x00007E54
		public XmlDocumentWrapper(XmlDocument document) : base(document)
		{
			this._document = document;
		}

		// Token: 0x060006B5 RID: 1717
		// RVA: 0x0003774C File Offset: 0x0003594C
		public IXmlNode CreateAttribute(string name, string value)
		{
			return new XmlNodeWrapper(this._document.CreateAttribute(name))
			{
				Value = value
			};
		}

		// Token: 0x060006B6 RID: 1718
		// RVA: 0x00037774 File Offset: 0x00035974
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return new XmlNodeWrapper(this._document.CreateAttribute(qualifiedName, namespaceUri))
			{
				Value = value
			};
		}

		// Token: 0x060006AD RID: 1709
		// RVA: 0x00009C8A File Offset: 0x00007E8A
		public IXmlNode CreateCDataSection(string data)
		{
			return new XmlNodeWrapper(this._document.CreateCDataSection(data));
		}

		// Token: 0x060006AB RID: 1707
		// RVA: 0x00009C64 File Offset: 0x00007E64
		public IXmlNode CreateComment(string data)
		{
			return new XmlNodeWrapper(this._document.CreateComment(data));
		}

		// Token: 0x060006B3 RID: 1715
		// RVA: 0x00009D02 File Offset: 0x00007F02
		public IXmlElement CreateElement(string elementName)
		{
			return new XmlElementWrapper(this._document.CreateElement(elementName));
		}

		// Token: 0x060006B4 RID: 1716
		// RVA: 0x00009D15 File Offset: 0x00007F15
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new XmlElementWrapper(this._document.CreateElement(qualifiedName, namespaceUri));
		}

		// Token: 0x060006B2 RID: 1714
		// RVA: 0x00009CEE File Offset: 0x00007EEE
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return new XmlNodeWrapper(this._document.CreateProcessingInstruction(target, data));
		}

		// Token: 0x060006AF RID: 1711
		// RVA: 0x00009CB0 File Offset: 0x00007EB0
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return new XmlNodeWrapper(this._document.CreateSignificantWhitespace(text));
		}

		// Token: 0x060006AC RID: 1708
		// RVA: 0x00009C77 File Offset: 0x00007E77
		public IXmlNode CreateTextNode(string text)
		{
			return new XmlNodeWrapper(this._document.CreateTextNode(text));
		}

		// Token: 0x060006AE RID: 1710
		// RVA: 0x00009C9D File Offset: 0x00007E9D
		public IXmlNode CreateWhitespace(string text)
		{
			return new XmlNodeWrapper(this._document.CreateWhitespace(text));
		}

		// Token: 0x060006B0 RID: 1712
		// RVA: 0x00009CC3 File Offset: 0x00007EC3
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return new XmlDeclarationWrapper(this._document.CreateXmlDeclaration(version, encoding, standalone));
		}

		// Token: 0x060006B1 RID: 1713
		// RVA: 0x00009CD8 File Offset: 0x00007ED8
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return new XmlDocumentTypeWrapper(this._document.CreateDocumentType(name, publicId, systemId, null));
		}
	}
}
