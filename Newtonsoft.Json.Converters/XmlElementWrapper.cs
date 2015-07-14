using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C4 RID: 196
	internal sealed class XmlElementWrapper : XmlNodeWrapper, IXmlNode, IXmlElement
	{
		// Token: 0x04000335 RID: 821
		private readonly XmlElement _element;

		// Token: 0x17000116 RID: 278
		public bool IsEmpty
		{
			// Token: 0x060006BE RID: 1726
			// RVA: 0x00009D68 File Offset: 0x00007F68
			get
			{
				return this._element.IsEmpty;
			}
		}

		// Token: 0x060006BB RID: 1723
		// RVA: 0x00009D4A File Offset: 0x00007F4A
		public XmlElementWrapper(XmlElement element) : base(element)
		{
			this._element = element;
		}

		// Token: 0x060006BD RID: 1725
		// RVA: 0x00009D5A File Offset: 0x00007F5A
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this._element.GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x060006BC RID: 1724
		// RVA: 0x0003779C File Offset: 0x0003599C
		public void SetAttributeNode(IXmlNode attribute)
		{
			XmlNodeWrapper xmlNodeWrapper = (XmlNodeWrapper)attribute;
			this._element.SetAttributeNode((XmlAttribute)xmlNodeWrapper.WrappedNode);
		}
	}
}
