using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000025 RID: 37
	internal sealed class BsonRegex : BsonToken
	{
		// Token: 0x17000020 RID: 32
		public BsonString Options
		{
			// Token: 0x060000D7 RID: 215
			// RVA: 0x0000646A File Offset: 0x0000466A
			get;
			// Token: 0x060000D8 RID: 216
			// RVA: 0x00006472 File Offset: 0x00004672
			set;
		}

		// Token: 0x1700001F RID: 31
		public BsonString Pattern
		{
			// Token: 0x060000D5 RID: 213
			// RVA: 0x00006459 File Offset: 0x00004659
			get;
			// Token: 0x060000D6 RID: 214
			// RVA: 0x00006461 File Offset: 0x00004661
			set;
		}

		// Token: 0x17000021 RID: 33
		public override BsonType Type
		{
			// Token: 0x060000DA RID: 218
			// RVA: 0x0000649D File Offset: 0x0000469D
			get
			{
				return BsonType.Regex;
			}
		}

		// Token: 0x060000D9 RID: 217
		// RVA: 0x0000647B File Offset: 0x0000467B
		public BsonRegex(string pattern, string options)
		{
			this.Pattern = new BsonString(pattern, false);
			this.Options = new BsonString(options, false);
		}
	}
}
