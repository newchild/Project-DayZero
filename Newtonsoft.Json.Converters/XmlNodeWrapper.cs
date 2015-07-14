using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C0 RID: 192
	internal class XmlNodeWrapper : IXmlNode
	{
		// Token: 0x04000333 RID: 819
		private IList<IXmlNode> _childNodes;

		// Token: 0x04000332 RID: 818
		private readonly XmlNode _node;

		// Token: 0x1700010F RID: 271
		public IList<IXmlNode> Attributes
		{
			// Token: 0x06000697 RID: 1687
			// RVA: 0x00009BF5 File Offset: 0x00007DF5
			get
			{
				if (this._node.Attributes == null)
				{
					return null;
				}
				return Enumerable.ToList<IXmlNode>(Enumerable.Select<XmlAttribute, IXmlNode>(Enumerable.Cast<XmlAttribute>(this._node.Attributes), new Func<XmlAttribute, IXmlNode>(XmlNodeWrapper.WrapNode)));
			}
		}

		// Token: 0x1700010E RID: 270
		public IList<IXmlNode> ChildNodes
		{
			// Token: 0x06000695 RID: 1685
			// RVA: 0x00009BB9 File Offset: 0x00007DB9
			get
			{
				if (this._childNodes == null)
				{
					this._childNodes = Enumerable.ToList<IXmlNode>(Enumerable.Select<XmlNode, IXmlNode>(Enumerable.Cast<XmlNode>(this._node.ChildNodes), new Func<XmlNode, IXmlNode>(XmlNodeWrapper.WrapNode)));
				}
				return this._childNodes;
			}
		}

		// Token: 0x1700010D RID: 269
		public virtual string LocalName
		{
			// Token: 0x06000694 RID: 1684
			// RVA: 0x00009BAC File Offset: 0x00007DAC
			get
			{
				return this._node.LocalName;
			}
		}

		// Token: 0x17000112 RID: 274
		public string NamespaceUri
		{
			// Token: 0x0600069C RID: 1692
			// RVA: 0x00009C47 File Offset: 0x00007E47
			get
			{
				return this._node.NamespaceURI;
			}
		}

		// Token: 0x1700010C RID: 268
		public XmlNodeType NodeType
		{
			// Token: 0x06000693 RID: 1683
			// RVA: 0x00009B9F File Offset: 0x00007D9F
			get
			{
				return this._node.NodeType;
			}
		}

		// Token: 0x17000110 RID: 272
		public IXmlNode ParentNode
		{
			// Token: 0x06000698 RID: 1688
			// RVA: 0x000376D8 File Offset: 0x000358D8
			get
			{
				XmlNode xmlNode = (this._node is XmlAttribute) ? ((XmlAttribute)this._node).OwnerElement : this._node.ParentNode;
				if (xmlNode == null)
				{
					return null;
				}
				return XmlNodeWrapper.WrapNode(xmlNode);
			}
		}

		// Token: 0x17000111 RID: 273
		public string Value
		{
			// Token: 0x06000699 RID: 1689
			// RVA: 0x00009C2C File Offset: 0x00007E2C
			get
			{
				return this._node.Value;
			}
			// Token: 0x0600069A RID: 1690
			// RVA: 0x00009C39 File Offset: 0x00007E39
			set
			{
				this._node.Value = value;
			}
		}

		// Token: 0x1700010B RID: 267
		public object WrappedNode
		{
			// Token: 0x06000692 RID: 1682
			// RVA: 0x00009B97 File Offset: 0x00007D97
			get
			{
				return this._node;
			}
		}

		// Token: 0x06000691 RID: 1681
		// RVA: 0x00009B88 File Offset: 0x00007D88
		public XmlNodeWrapper(XmlNode node)
		{
			this._node = node;
		}

		// Token: 0x0600069B RID: 1691
		// RVA: 0x0003771C File Offset: 0x0003591C
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			XmlNodeWrapper xmlNodeWrapper = (XmlNodeWrapper)newChild;
			this._node.AppendChild(xmlNodeWrapper._node);
			this._childNodes = null;
			return newChild;
		}

		// Token: 0x06000696 RID: 1686
		// RVA: 0x0003768C File Offset: 0x0003588C
		internal static IXmlNode WrapNode(XmlNode node)
		{
			XmlNodeType nodeType = node.NodeType;
			if (nodeType == XmlNodeType.Element)
			{
				return new XmlElementWrapper((XmlElement)node);
			}
			if (nodeType == XmlNodeType.DocumentType)
			{
				return new XmlDocumentTypeWrapper((XmlDocumentType)node);
			}
			if (nodeType != XmlNodeType.XmlDeclaration)
			{
				return new XmlNodeWrapper(node);
			}
			return new XmlDeclarationWrapper((XmlDeclaration)node);
		}
	}
}
