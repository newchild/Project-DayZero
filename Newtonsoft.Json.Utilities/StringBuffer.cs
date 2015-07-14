using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000157 RID: 343
	internal sealed class StringBuffer
	{
		// Token: 0x040005C7 RID: 1479
		private static readonly char[] EmptyBuffer = new char[0];

		// Token: 0x040005C5 RID: 1477
		private char[] _buffer;

		// Token: 0x040005C6 RID: 1478
		private int _position;

		// Token: 0x1700027B RID: 635
		public int Position
		{
			// Token: 0x06000D68 RID: 3432
			// RVA: 0x0000E43F File Offset: 0x0000C63F
			get
			{
				return this._position;
			}
			// Token: 0x06000D69 RID: 3433
			// RVA: 0x0000E447 File Offset: 0x0000C647
			set
			{
				this._position = value;
			}
		}

		// Token: 0x06000D6A RID: 3434
		// RVA: 0x0000E450 File Offset: 0x0000C650
		public StringBuffer()
		{
			this._buffer = StringBuffer.EmptyBuffer;
		}

		// Token: 0x06000D6B RID: 3435
		// RVA: 0x0000E463 File Offset: 0x0000C663
		public StringBuffer(int initalSize)
		{
			this._buffer = new char[initalSize];
		}

		// Token: 0x06000D6C RID: 3436
		// RVA: 0x0004B69C File Offset: 0x0004989C
		public void Append(char value)
		{
			if (this._position == this._buffer.Length)
			{
				this.EnsureSize(1);
			}
			this._buffer[this._position++] = value;
		}

		// Token: 0x06000D6D RID: 3437
		// RVA: 0x0000E477 File Offset: 0x0000C677
		public void Append(char[] buffer, int startIndex, int count)
		{
			if (this._position + count >= this._buffer.Length)
			{
				this.EnsureSize(count);
			}
			Array.Copy(buffer, startIndex, this._buffer, this._position, count);
			this._position += count;
		}

		// Token: 0x06000D6E RID: 3438
		// RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		public void Clear()
		{
			this._buffer = StringBuffer.EmptyBuffer;
			this._position = 0;
		}

		// Token: 0x06000D6F RID: 3439
		// RVA: 0x0004B6DC File Offset: 0x000498DC
		private void EnsureSize(int appendLength)
		{
			char[] array = new char[(this._position + appendLength) * 2];
			Array.Copy(this._buffer, array, this._position);
			this._buffer = array;
		}

		// Token: 0x06000D72 RID: 3442
		// RVA: 0x0000E4E6 File Offset: 0x0000C6E6
		public char[] GetInternalBuffer()
		{
			return this._buffer;
		}

		// Token: 0x06000D70 RID: 3440
		// RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public override string ToString()
		{
			return this.ToString(0, this._position);
		}

		// Token: 0x06000D71 RID: 3441
		// RVA: 0x0000E4D7 File Offset: 0x0000C6D7
		public string ToString(int start, int length)
		{
			return new string(this._buffer, start, length);
		}
	}
}
