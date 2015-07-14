using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000019 RID: 25
	public sealed class BsonObjectId
	{
		// Token: 0x17000002 RID: 2
		public byte[] Value
		{
			// Token: 0x06000057 RID: 87
			// RVA: 0x00005F67 File Offset: 0x00004167
			get;
			// Token: 0x06000058 RID: 88
			// RVA: 0x00005F6F File Offset: 0x0000416F
			private set;
		}

		// Token: 0x06000059 RID: 89
		// RVA: 0x00005F78 File Offset: 0x00004178
		public BsonObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value.Length != 12)
			{
				throw new ArgumentException("An ObjectId must be 12 bytes", "value");
			}
			this.Value = value;
		}
	}
}
