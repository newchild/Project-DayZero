using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ns48
{
	// Token: 0x020002E9 RID: 745
	internal sealed class Class270 : IEnumerable, ICloneable, IEnumerable<bool>
	{
		// Token: 0x040011C6 RID: 4550
		private int[] int_0;

		// Token: 0x040011C7 RID: 4551
		private int int_1;

		// Token: 0x040011C8 RID: 4552
		private int int_2;

		// Token: 0x1700030F RID: 783
		public bool this[int int_3]
		{
			// Token: 0x06001706 RID: 5894
			// RVA: 0x0001441C File Offset: 0x0001261C
			get
			{
				return this.Get(int_3);
			}
			// Token: 0x06001707 RID: 5895
			// RVA: 0x00014425 File Offset: 0x00012625
			internal set
			{
				this.Set(int_3, value);
			}
		}

		// Token: 0x17000310 RID: 784
		public int Length
		{
			// Token: 0x06001704 RID: 5892
			// RVA: 0x000143E4 File Offset: 0x000125E4
			get
			{
				return this.int_1;
			}
		}

		// Token: 0x06001705 RID: 5893
		// RVA: 0x000143EC File Offset: 0x000125EC
		public Class270(int int_3)
		{
			if (int_3 < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			this.int_1 = int_3;
			this.int_0 = new int[(int_3 + 31) / 32];
		}

		// Token: 0x06001709 RID: 5897
		// RVA: 0x00072BA4 File Offset: 0x00070DA4
		public Class270 Clone()
		{
			Class270 class = new Class270(this.int_1);
			Buffer.BlockCopy(this.int_0, 0, class.int_0, 0, this.int_0.Length * 4);
			class.int_2 = this.int_2;
			return class;
		}

		// Token: 0x0600170A RID: 5898
		// RVA: 0x00072BE8 File Offset: 0x00070DE8
		public override bool Equals(object obj)
		{
			Class270 class = obj as Class270;
			if (class != null && this.int_0.Length == class.int_0.Length)
			{
				if (this.method_0() == class.method_0())
				{
					for (int i = 0; i < this.int_0.Length; i++)
					{
						if (this.int_0[i] != class.int_0[i])
						{
							return false;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600170B RID: 5899
		// RVA: 0x00014438 File Offset: 0x00012638
		private bool Get(int int_3)
		{
			if (int_3 < 0 || int_3 >= this.int_1)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return (this.int_0[int_3 >> 5] & 1 << 31 - (int_3 & 31)) != 0;
		}

		// Token: 0x0600170C RID: 5900
		// RVA: 0x00072C50 File Offset: 0x00070E50
		public IEnumerator<bool> GetEnumerator()
		{
			Class270.Class271 class = new Class270.Class271(0);
			class.class270_0 = this;
			return class;
		}

		// Token: 0x0600170E RID: 5902
		// RVA: 0x00072C6C File Offset: 0x00070E6C
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.int_0.Length; i++)
			{
				num += this.int_0[i];
			}
			return num;
		}

		// Token: 0x06001711 RID: 5905
		// RVA: 0x00014477 File Offset: 0x00012677
		public int method_0()
		{
			return this.int_2;
		}

		// Token: 0x0600170F RID: 5903
		// RVA: 0x00072C9C File Offset: 0x00070E9C
		public Class270 Set(int int_3, bool bool_0)
		{
			if (int_3 >= 0 && int_3 < this.int_1)
			{
				if (bool_0)
				{
					if ((this.int_0[int_3 >> 5] & 1 << 31 - (int_3 & 31)) == 0)
					{
						this.int_2++;
					}
					this.int_0[int_3 >> 5] |= 1 << 31 - int_3;
				}
				else
				{
					if ((this.int_0[int_3 >> 5] & 1 << 31 - (int_3 & 31)) != 0)
					{
						this.int_2--;
					}
					this.int_0[int_3 >> 5] &= ~(1 << 31 - (int_3 & 31));
				}
				return this;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		// Token: 0x0600170D RID: 5901
		// RVA: 0x0001446F File Offset: 0x0001266F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001708 RID: 5896
		// RVA: 0x00014430 File Offset: 0x00012630
		object ICloneable.Clone()
		{
			return this.Clone();
		}

		// Token: 0x06001710 RID: 5904
		// RVA: 0x00072D6C File Offset: 0x00070F6C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.int_0.Length * 16);
			for (int i = 0; i < this.Length; i++)
			{
				stringBuilder.Append(this.Get(i) ? 'T' : 'F');
				stringBuilder.Append(' ');
			}
			return stringBuilder.ToString(0, stringBuilder.Length - 1);
		}
	}
}
