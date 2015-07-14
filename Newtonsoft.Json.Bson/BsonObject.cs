using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000020 RID: 32
	internal sealed class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x0400008B RID: 139
		private readonly List<BsonProperty> _children = new List<BsonProperty>();

		// Token: 0x17000018 RID: 24
		public override BsonType Type
		{
			// Token: 0x060000C1 RID: 193
			// RVA: 0x00006369 File Offset: 0x00004569
			get
			{
				return BsonType.Object;
			}
		}

		// Token: 0x060000C0 RID: 192
		// RVA: 0x0002A244 File Offset: 0x00028444
		public void Add(string name, BsonToken token)
		{
			this._children.Add(new BsonProperty
			{
				Name = new BsonString(name, false),
				Value = token
			});
			token.Parent = this;
		}

		// Token: 0x060000C2 RID: 194
		// RVA: 0x0000636C File Offset: 0x0000456C
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x060000C3 RID: 195
		// RVA: 0x0000637E File Offset: 0x0000457E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
