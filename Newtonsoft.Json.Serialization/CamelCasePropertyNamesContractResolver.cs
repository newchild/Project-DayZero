using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FD RID: 253
	public sealed class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x06000A61 RID: 2657
		// RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public CamelCasePropertyNamesContractResolver() : base(true)
		{
		}

		// Token: 0x06000A62 RID: 2658
		// RVA: 0x0000C2D1 File Offset: 0x0000A4D1
		protected internal override string ResolvePropertyName(string propertyName)
		{
			return StringUtils.ToCamelCase(propertyName);
		}
	}
}
