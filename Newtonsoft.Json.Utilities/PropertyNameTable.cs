using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200013B RID: 315
	internal sealed class PropertyNameTable
	{
		// Token: 0x0200013C RID: 316
		private sealed class Entry
		{
			// Token: 0x04000542 RID: 1346
			internal readonly int HashCode;

			// Token: 0x04000543 RID: 1347
			internal PropertyNameTable.Entry Next;

			// Token: 0x04000541 RID: 1345
			internal readonly string Value;

			// Token: 0x06000CB2 RID: 3250
			// RVA: 0x0000D8C4 File Offset: 0x0000BAC4
			internal Entry(string value, int hashCode, PropertyNameTable.Entry next)
			{
				this.Value = value;
				this.HashCode = hashCode;
				this.Next = next;
			}
		}

		// Token: 0x0400053D RID: 1341
		private static readonly int HashCodeRandomizer;

		// Token: 0x0400053E RID: 1342
		private int _count;

		// Token: 0x0400053F RID: 1343
		private PropertyNameTable.Entry[] _entries;

		// Token: 0x04000540 RID: 1344
		private int _mask = 31;

		// Token: 0x06000CAB RID: 3243
		// RVA: 0x0000D895 File Offset: 0x0000BA95
		static PropertyNameTable()
		{
			PropertyNameTable.HashCodeRandomizer = Environment.TickCount;
		}

		// Token: 0x06000CAC RID: 3244
		// RVA: 0x0000D8A1 File Offset: 0x0000BAA1
		public PropertyNameTable()
		{
			this._entries = new PropertyNameTable.Entry[this._mask + 1];
		}

		// Token: 0x06000CAE RID: 3246
		// RVA: 0x00048E58 File Offset: 0x00047058
		public string Add(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int length = key.Length;
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + PropertyNameTable.HashCodeRandomizer;
			for (int i = 0; i < key.Length; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (PropertyNameTable.Entry entry = this._entries[num & this._mask]; entry != null; entry = entry.Next)
			{
				if (entry.HashCode == num && entry.Value.Equals(key))
				{
					return entry.Value;
				}
			}
			return this.AddEntry(key, num);
		}

		// Token: 0x06000CAF RID: 3247
		// RVA: 0x00048F00 File Offset: 0x00047100
		private string AddEntry(string str, int hashCode)
		{
			int num = hashCode & this._mask;
			PropertyNameTable.Entry entry = new PropertyNameTable.Entry(str, hashCode, this._entries[num]);
			this._entries[num] = entry;
			if (this._count++ == this._mask)
			{
				this.Grow();
			}
			return entry.Value;
		}

		// Token: 0x06000CAD RID: 3245
		// RVA: 0x00048DC0 File Offset: 0x00046FC0
		public string Get(char[] key, int start, int length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + PropertyNameTable.HashCodeRandomizer;
			num += (num << 7 ^ (int)key[start]);
			int num2 = start + length;
			for (int i = start + 1; i < num2; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (PropertyNameTable.Entry entry = this._entries[num & this._mask]; entry != null; entry = entry.Next)
			{
				if (entry.HashCode == num && PropertyNameTable.TextEquals(entry.Value, key, start, length))
				{
					return entry.Value;
				}
			}
			return null;
		}

		// Token: 0x06000CB0 RID: 3248
		// RVA: 0x00048F54 File Offset: 0x00047154
		private void Grow()
		{
			PropertyNameTable.Entry[] entries = this._entries;
			int num = this._mask * 2 + 1;
			PropertyNameTable.Entry[] array = new PropertyNameTable.Entry[num + 1];
			for (int i = 0; i < entries.Length; i++)
			{
				PropertyNameTable.Entry next;
				for (PropertyNameTable.Entry entry = entries[i]; entry != null; entry = next)
				{
					int num2 = entry.HashCode & num;
					next = entry.Next;
					entry.Next = array[num2];
					array[num2] = entry;
				}
			}
			this._entries = array;
			this._mask = num;
		}

		// Token: 0x06000CB1 RID: 3249
		// RVA: 0x00048FCC File Offset: 0x000471CC
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			if (str1.Length != str2Length)
			{
				return false;
			}
			for (int i = 0; i < str1.Length; i++)
			{
				if (str1[i] != str2[str2Start + i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
