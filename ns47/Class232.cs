using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ns47
{
	// Token: 0x020002B3 RID: 691
	internal sealed class Class232 : Class230, IEnumerable, IEnumerable<Class230>, IList<Class230>, ICollection<Class230>
	{
		// Token: 0x04001128 RID: 4392
		private List<Class230> list_0;

		// Token: 0x170002FB RID: 763
		public int Count
		{
			// Token: 0x06001660 RID: 5728
			// RVA: 0x00013D70 File Offset: 0x00011F70
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x170002FC RID: 764
		public bool IsReadOnly
		{
			// Token: 0x06001663 RID: 5731
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002FA RID: 762
		public Class230 this[int index]
		{
			// Token: 0x06001666 RID: 5734
			// RVA: 0x00013DB6 File Offset: 0x00011FB6
			get
			{
				return this.list_0[index];
			}
			// Token: 0x06001667 RID: 5735
			// RVA: 0x00013DC4 File Offset: 0x00011FC4
			set
			{
				this.list_0[index] = value;
			}
		}

		// Token: 0x0600165C RID: 5724
		// RVA: 0x00013D38 File Offset: 0x00011F38
		public void Add(Class230 item)
		{
			this.list_0.Add(item);
		}

		// Token: 0x0600165D RID: 5725
		// RVA: 0x00013D46 File Offset: 0x00011F46
		public void Clear()
		{
			this.list_0.Clear();
		}

		// Token: 0x0600165E RID: 5726
		// RVA: 0x00013D53 File Offset: 0x00011F53
		public bool Contains(Class230 item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x0600165F RID: 5727
		// RVA: 0x00013D61 File Offset: 0x00011F61
		public void CopyTo(Class230[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x06001657 RID: 5719
		// RVA: 0x00071C1C File Offset: 0x0006FE1C
		public override int Encode(byte[] byte_0, int int_0)
		{
			byte_0[int_0] = 108;
			int num = 1;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				num += this.list_0[i].Encode(byte_0, int_0 + num);
			}
			byte_0[int_0 + num] = 101;
			return num + 1;
		}

		// Token: 0x06001659 RID: 5721
		// RVA: 0x00071CAC File Offset: 0x0006FEAC
		public override bool Equals(object obj)
		{
			Class232 class = obj as Class232;
			if (class == null)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (!this.list_0[i].Equals(class.list_0[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001668 RID: 5736
		// RVA: 0x00013DD3 File Offset: 0x00011FD3
		public IEnumerator<Class230> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x0600165A RID: 5722
		// RVA: 0x00071D00 File Offset: 0x0006FF00
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				num ^= this.list_0[i].GetHashCode();
			}
			return num;
		}

		// Token: 0x06001661 RID: 5729
		// RVA: 0x00013D7D File Offset: 0x00011F7D
		public int IndexOf(Class230 item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x06001662 RID: 5730
		// RVA: 0x00013D8B File Offset: 0x00011F8B
		public void Insert(int index, Class230 item)
		{
			this.list_0.Insert(index, item);
		}

		// Token: 0x06001664 RID: 5732
		// RVA: 0x00013D9A File Offset: 0x00011F9A
		public bool Remove(Class230 item)
		{
			return this.list_0.Remove(item);
		}

		// Token: 0x06001665 RID: 5733
		// RVA: 0x00013DA8 File Offset: 0x00011FA8
		public void RemoveAt(int index)
		{
			this.list_0.RemoveAt(index);
		}

		// Token: 0x06001669 RID: 5737
		// RVA: 0x00013DE5 File Offset: 0x00011FE5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600165B RID: 5723
		// RVA: 0x00013C15 File Offset: 0x00011E15
		public override string ToString()
		{
			return Encoding.UTF8.GetString(base.Encode());
		}

		// Token: 0x06001658 RID: 5720
		// RVA: 0x00071C6C File Offset: 0x0006FE6C
		public override int vmethod_0()
		{
			int num = 1;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				num += this.list_0[i].vmethod_0();
			}
			return num + 1;
		}
	}
}
