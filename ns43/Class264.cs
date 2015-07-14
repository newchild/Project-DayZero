using System;
using System.Collections;
using System.Collections.Generic;

namespace ns43
{
	// Token: 0x020002DE RID: 734
	internal sealed class Class264<T> : IEnumerable<T>, IEnumerable, ICollection<T>, IList<T>
	{
		// Token: 0x0400119C RID: 4508
		private List<T> list_0;

		// Token: 0x17000309 RID: 777
		public int Count
		{
			// Token: 0x060016EE RID: 5870
			// RVA: 0x00014331 File Offset: 0x00012531
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x1700030A RID: 778
		public bool IsReadOnly
		{
			// Token: 0x060016EF RID: 5871
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x17000308 RID: 776
		public T this[int index]
		{
			// Token: 0x060016E8 RID: 5864
			// RVA: 0x000142E4 File Offset: 0x000124E4
			get
			{
				return this.list_0[index];
			}
			// Token: 0x060016E9 RID: 5865
			// RVA: 0x000142F2 File Offset: 0x000124F2
			set
			{
				this.list_0[index] = value;
			}
		}

		// Token: 0x060016E3 RID: 5859
		// RVA: 0x000142A6 File Offset: 0x000124A6
		public Class264()
		{
			this.list_0 = new List<T>();
		}

		// Token: 0x060016E4 RID: 5860
		// RVA: 0x000142B9 File Offset: 0x000124B9
		public Class264(IEnumerable<T> ienumerable_0)
		{
			this.list_0 = new List<T>(ienumerable_0);
		}

		// Token: 0x060016EA RID: 5866
		// RVA: 0x000729C8 File Offset: 0x00070BC8
		public void Add(T item)
		{
			int num = this.list_0.BinarySearch(item);
			if (num < 0)
			{
				this.list_0.Insert(~num, item);
				return;
			}
			this.list_0.Insert(num, item);
		}

		// Token: 0x060016EB RID: 5867
		// RVA: 0x00014301 File Offset: 0x00012501
		public void Clear()
		{
			this.list_0.Clear();
		}

		// Token: 0x060016EC RID: 5868
		// RVA: 0x0001430E File Offset: 0x0001250E
		public bool Contains(T item)
		{
			return this.list_0.BinarySearch(item) >= 0;
		}

		// Token: 0x060016ED RID: 5869
		// RVA: 0x00014322 File Offset: 0x00012522
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x060016F1 RID: 5873
		// RVA: 0x0001433E File Offset: 0x0001253E
		public IEnumerator<T> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060016E5 RID: 5861
		// RVA: 0x000729A4 File Offset: 0x00070BA4
		public int IndexOf(T item)
		{
			int num = this.list_0.BinarySearch(item);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x060016E6 RID: 5862
		// RVA: 0x000142CD File Offset: 0x000124CD
		public void Insert(int index, T item)
		{
			this.Add(item);
		}

		// Token: 0x060016F0 RID: 5872
		// RVA: 0x00072A04 File Offset: 0x00070C04
		public bool Remove(T item)
		{
			int num = this.list_0.BinarySearch(item);
			if (num < 0)
			{
				return false;
			}
			this.list_0.RemoveAt(num);
			return true;
		}

		// Token: 0x060016E7 RID: 5863
		// RVA: 0x000142D6 File Offset: 0x000124D6
		public void RemoveAt(int index)
		{
			this.list_0.RemoveAt(index);
		}

		// Token: 0x060016F2 RID: 5874
		// RVA: 0x00014350 File Offset: 0x00012550
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
