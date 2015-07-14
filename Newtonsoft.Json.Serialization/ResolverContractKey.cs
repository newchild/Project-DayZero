using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FE RID: 254
	internal struct ResolverContractKey : IEquatable<ResolverContractKey>
	{
		// Token: 0x04000439 RID: 1081
		private readonly Type _contractType;

		// Token: 0x04000438 RID: 1080
		private readonly Type _resolverType;

		// Token: 0x06000A63 RID: 2659
		// RVA: 0x0000C2D9 File Offset: 0x0000A4D9
		public ResolverContractKey(Type resolverType, Type contractType)
		{
			this._resolverType = resolverType;
			this._contractType = contractType;
		}

		// Token: 0x06000A65 RID: 2661
		// RVA: 0x0000C302 File Offset: 0x0000A502
		public override bool Equals(object obj)
		{
			return obj is ResolverContractKey && this.Equals((ResolverContractKey)obj);
		}

		// Token: 0x06000A66 RID: 2662
		// RVA: 0x0000C31A File Offset: 0x0000A51A
		public bool Equals(ResolverContractKey other)
		{
			return this._resolverType == other._resolverType && this._contractType == other._contractType;
		}

		// Token: 0x06000A64 RID: 2660
		// RVA: 0x0000C2E9 File Offset: 0x0000A4E9
		public override int GetHashCode()
		{
			return this._resolverType.GetHashCode() ^ this._contractType.GetHashCode();
		}
	}
}
