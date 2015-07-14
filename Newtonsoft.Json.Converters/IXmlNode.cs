using System;
using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BF RID: 191
	internal interface IXmlNode
	{
		// Token: 0x17000106 RID: 262
		IList<IXmlNode> Attributes
		{
			// Token: 0x0600068A RID: 1674
			get;
		}

		// Token: 0x17000105 RID: 261
		IList<IXmlNode> ChildNodes
		{
			// Token: 0x06000689 RID: 1673
			get;
		}

		// Token: 0x17000104 RID: 260
		string LocalName
		{
			// Token: 0x06000688 RID: 1672
			get;
		}

		// Token: 0x17000109 RID: 265
		string NamespaceUri
		{
			// Token: 0x0600068F RID: 1679
			get;
		}

		// Token: 0x17000103 RID: 259
		XmlNodeType NodeType
		{
			// Token: 0x06000687 RID: 1671
			get;
		}

		// Token: 0x17000107 RID: 263
		IXmlNode ParentNode
		{
			// Token: 0x0600068B RID: 1675
			get;
		}

		// Token: 0x17000108 RID: 264
		string Value
		{
			// Token: 0x0600068C RID: 1676
			get;
			// Token: 0x0600068D RID: 1677
			set;
		}

		// Token: 0x1700010A RID: 266
		object WrappedNode
		{
			// Token: 0x06000690 RID: 1680
			get;
		}

		// Token: 0x0600068E RID: 1678
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
