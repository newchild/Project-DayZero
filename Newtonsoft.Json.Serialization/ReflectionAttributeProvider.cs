using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000064 RID: 100
	public sealed class ReflectionAttributeProvider : IAttributeProvider
	{
		// Token: 0x0400019E RID: 414
		private readonly object _attributeProvider;

		// Token: 0x060002C3 RID: 707
		// RVA: 0x00007980 File Offset: 0x00005B80
		public ReflectionAttributeProvider(object attributeProvider)
		{
			ValidationUtils.ArgumentNotNull(attributeProvider, "attributeProvider");
			this._attributeProvider = attributeProvider;
		}

		// Token: 0x060002C4 RID: 708
		// RVA: 0x0000799A File Offset: 0x00005B9A
		public IList<Attribute> GetAttributes(bool inherit)
		{
			return ReflectionUtils.GetAttributes(this._attributeProvider, null, inherit);
		}

		// Token: 0x060002C5 RID: 709
		// RVA: 0x000079A9 File Offset: 0x00005BA9
		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			return ReflectionUtils.GetAttributes(this._attributeProvider, attributeType, inherit);
		}
	}
}
