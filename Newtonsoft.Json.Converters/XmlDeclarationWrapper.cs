using System;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C6 RID: 198
	internal sealed class XmlDeclarationWrapper : XmlNodeWrapper, IXmlNode, IXmlDeclaration
	{
		// Token: 0x04000336 RID: 822
		private readonly XmlDeclaration _declaration;

		// Token: 0x1700011B RID: 283
		public string Encoding
		{
			// Token: 0x060006C6 RID: 1734
			// RVA: 0x00009D92 File Offset: 0x00007F92
			get
			{
				return this._declaration.Encoding;
			}
			// Token: 0x060006C7 RID: 1735
			// RVA: 0x00009D9F File Offset: 0x00007F9F
			set
			{
				this._declaration.Encoding = value;
			}
		}

		// Token: 0x1700011C RID: 284
		public string Standalone
		{
			// Token: 0x060006C8 RID: 1736
			// RVA: 0x00009DAD File Offset: 0x00007FAD
			get
			{
				return this._declaration.Standalone;
			}
			// Token: 0x060006C9 RID: 1737
			// RVA: 0x00009DBA File Offset: 0x00007FBA
			set
			{
				this._declaration.Standalone = value;
			}
		}

		// Token: 0x1700011A RID: 282
		public string Version
		{
			// Token: 0x060006C5 RID: 1733
			// RVA: 0x00009D85 File Offset: 0x00007F85
			get
			{
				return this._declaration.Version;
			}
		}

		// Token: 0x060006C4 RID: 1732
		// RVA: 0x00009D75 File Offset: 0x00007F75
		public XmlDeclarationWrapper(XmlDeclaration declaration) : base(declaration)
		{
			this._declaration = declaration;
		}
	}
}
