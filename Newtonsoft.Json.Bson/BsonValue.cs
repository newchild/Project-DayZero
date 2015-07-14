using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000022 RID: 34
	internal class BsonValue : BsonToken
	{
		// Token: 0x0400008E RID: 142
		private readonly BsonType _type;

		// Token: 0x0400008D RID: 141
		private readonly object _value;

		// Token: 0x1700001B RID: 27
		public override BsonType Type
		{
			// Token: 0x060000CC RID: 204
			// RVA: 0x000063FC File Offset: 0x000045FC
			get
			{
				return this._type;
			}
		}

		// Token: 0x1700001A RID: 26
		public object Value
		{
			// Token: 0x060000CB RID: 203
			// RVA: 0x000063F4 File Offset: 0x000045F4
			get
			{
				return this._value;
			}
		}

		// Token: 0x060000CA RID: 202
		// RVA: 0x000063DE File Offset: 0x000045DE
		public BsonValue(object value, BsonType type)
		{
			this._value = value;
			this._type = type;
		}
	}
}
