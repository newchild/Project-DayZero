using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C8 RID: 200
	internal sealed class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlNode, IXmlDocumentType
	{
		// Token: 0x04000337 RID: 823
		private readonly XmlDocumentType _documentType;

		// Token: 0x17000124 RID: 292
		public string InternalSubset
		{
			// Token: 0x060006D2 RID: 1746
			// RVA: 0x00009DFF File Offset: 0x00007FFF
			get
			{
				return this._documentType.InternalSubset;
			}
		}

		// Token: 0x17000125 RID: 293
		public override string LocalName
		{
			// Token: 0x060006D3 RID: 1747
			// RVA: 0x00009E0C File Offset: 0x0000800C
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x17000121 RID: 289
		public string Name
		{
			// Token: 0x060006CF RID: 1743
			// RVA: 0x00009DD8 File Offset: 0x00007FD8
			get
			{
				return this._documentType.Name;
			}
		}

		// Token: 0x17000123 RID: 291
		public string Public
		{
			// Token: 0x060006D1 RID: 1745
			// RVA: 0x00009DF2 File Offset: 0x00007FF2
			get
			{
				return this._documentType.PublicId;
			}
		}

		// Token: 0x17000122 RID: 290
		public string System
		{
			// Token: 0x060006D0 RID: 1744
			// RVA: 0x00009DE5 File Offset: 0x00007FE5
			get
			{
				return this._documentType.SystemId;
			}
		}

		// Token: 0x060006CE RID: 1742
		// RVA: 0x00009DC8 File Offset: 0x00007FC8
		public XmlDocumentTypeWrapper(XmlDocumentType documentType) : base(documentType)
		{
			this._documentType = documentType;
		}
	}
}
