using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000142 RID: 322
	internal struct StringReference
	{
		// Token: 0x0400054C RID: 1356
		private readonly char[] _chars;

		// Token: 0x0400054E RID: 1358
		private readonly int _length;

		// Token: 0x0400054D RID: 1357
		private readonly int _startIndex;

		// Token: 0x17000259 RID: 601
		public char[] Chars
		{
			// Token: 0x06000CCA RID: 3274
			// RVA: 0x0000D987 File Offset: 0x0000BB87
			get
			{
				return this._chars;
			}
		}

		// Token: 0x1700025B RID: 603
		public int Length
		{
			// Token: 0x06000CCC RID: 3276
			// RVA: 0x0000D997 File Offset: 0x0000BB97
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700025A RID: 602
		public int StartIndex
		{
			// Token: 0x06000CCB RID: 3275
			// RVA: 0x0000D98F File Offset: 0x0000BB8F
			get
			{
				return this._startIndex;
			}
		}

		// Token: 0x06000CCD RID: 3277
		// RVA: 0x0000D99F File Offset: 0x0000BB9F
		public StringReference(char[] chars, int startIndex, int length)
		{
			this._chars = chars;
			this._startIndex = startIndex;
			this._length = length;
		}

		// Token: 0x06000CCE RID: 3278
		// RVA: 0x0000D9B6 File Offset: 0x0000BBB6
		public override string ToString()
		{
			return new string(this._chars, this._startIndex, this._length);
		}
	}
}
