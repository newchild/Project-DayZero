using System;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200012D RID: 301
	internal sealed class Base64Encoder
	{
		// Token: 0x0400052B RID: 1323
		private const int Base64LineSize = 76;

		// Token: 0x0400052C RID: 1324
		private const int LineSizeInBytes = 57;

		// Token: 0x0400052D RID: 1325
		private readonly char[] _charsLine = new char[76];

		// Token: 0x0400052F RID: 1327
		private byte[] _leftOverBytes;

		// Token: 0x04000530 RID: 1328
		private int _leftOverBytesCount;

		// Token: 0x0400052E RID: 1326
		private readonly TextWriter _writer;

		// Token: 0x06000C67 RID: 3175
		// RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		public Base64Encoder(TextWriter writer)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = writer;
		}

		// Token: 0x06000C68 RID: 3176
		// RVA: 0x000481E4 File Offset: 0x000463E4
		public void Encode(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > buffer.Length - index)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this._leftOverBytesCount > 0)
			{
				int leftOverBytesCount = this._leftOverBytesCount;
				while (leftOverBytesCount < 3 && count > 0)
				{
					this._leftOverBytes[leftOverBytesCount++] = buffer[index++];
					count--;
				}
				if (count == 0 && leftOverBytesCount < 3)
				{
					this._leftOverBytesCount = leftOverBytesCount;
					return;
				}
				int count2 = Convert.ToBase64CharArray(this._leftOverBytes, 0, 3, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count2);
			}
			this._leftOverBytesCount = count % 3;
			if (this._leftOverBytesCount > 0)
			{
				count -= this._leftOverBytesCount;
				if (this._leftOverBytes == null)
				{
					this._leftOverBytes = new byte[3];
				}
				for (int i = 0; i < this._leftOverBytesCount; i++)
				{
					this._leftOverBytes[i] = buffer[index + count + i];
				}
			}
			int num = index + count;
			int num2 = 57;
			while (index < num)
			{
				if (index + num2 > num)
				{
					num2 = num - index;
				}
				int count3 = Convert.ToBase64CharArray(buffer, index, num2, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count3);
				index += num2;
			}
		}

		// Token: 0x06000C69 RID: 3177
		// RVA: 0x00048328 File Offset: 0x00046528
		public void Flush()
		{
			if (this._leftOverBytesCount > 0)
			{
				int count = Convert.ToBase64CharArray(this._leftOverBytes, 0, this._leftOverBytesCount, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count);
				this._leftOverBytesCount = 0;
			}
		}

		// Token: 0x06000C6A RID: 3178
		// RVA: 0x0000D6DF File Offset: 0x0000B8DF
		private void WriteChars(char[] chars, int index, int count)
		{
			this._writer.Write(chars, index, count);
		}
	}
}
