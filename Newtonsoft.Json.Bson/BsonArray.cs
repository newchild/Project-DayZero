using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000021 RID: 33
	internal sealed class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x0400008C RID: 140
		private readonly List<BsonToken> _children = new List<BsonToken>();

		// Token: 0x17000019 RID: 25
		public override BsonType Type
		{
			// Token: 0x060000C6 RID: 198
			// RVA: 0x000063AE File Offset: 0x000045AE
			get
			{
				return BsonType.Array;
			}
		}

		// Token: 0x060000C5 RID: 197
		// RVA: 0x00006399 File Offset: 0x00004599
		public void Add(BsonToken token)
		{
			this._children.Add(token);
			token.Parent = this;
		}

		// Token: 0x060000C7 RID: 199
		// RVA: 0x000063B1 File Offset: 0x000045B1
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x060000C8 RID: 200
		// RVA: 0x000063C3 File Offset: 0x000045C3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
