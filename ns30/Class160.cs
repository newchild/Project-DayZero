using System;
using System.Collections;
using System.Globalization;

namespace ns30
{
	// Token: 0x02000209 RID: 521
	internal sealed class Class160 : IEnumerable, ICollection
	{
		// Token: 0x04000E0D RID: 3597
		private ArrayList arrayList_0;

		// Token: 0x170002BD RID: 701
		public int Count
		{
			// Token: 0x0600123F RID: 4671
			// RVA: 0x00011163 File Offset: 0x0000F363
			get
			{
				return this.arrayList_0.Count;
			}
		}

		// Token: 0x170002BF RID: 703
		public bool IsSynchronized
		{
			// Token: 0x06001240 RID: 4672
			// RVA: 0x00011170 File Offset: 0x0000F370
			get
			{
				return this.arrayList_0.IsSynchronized;
			}
		}

		// Token: 0x170002BB RID: 699
		public Class159 this[int int_0]
		{
			// Token: 0x06001241 RID: 4673
			// RVA: 0x0001117D File Offset: 0x0000F37D
			get
			{
				return (Class159)this.arrayList_0[int_0];
			}
		}

		// Token: 0x170002BC RID: 700
		public Class159 this[string string_0]
		{
			// Token: 0x06001242 RID: 4674
			// RVA: 0x0006141C File Offset: 0x0005F61C
			get
			{
				foreach (Class159 class in this)
				{
					if (string.Compare(class.Name, string_0, true, CultureInfo.InvariantCulture) == 0)
					{
						return class;
					}
				}
				return null;
			}
		}

		// Token: 0x170002BE RID: 702
		public object SyncRoot
		{
			// Token: 0x06001243 RID: 4675
			// RVA: 0x00011190 File Offset: 0x0000F390
			get
			{
				return this.arrayList_0.SyncRoot;
			}
		}

		// Token: 0x0600123D RID: 4669
		// RVA: 0x00011147 File Offset: 0x0000F347
		public void CopyTo(Array array, int index)
		{
			this.arrayList_0.CopyTo(array, index);
		}

		// Token: 0x0600123E RID: 4670
		// RVA: 0x00011156 File Offset: 0x0000F356
		public IEnumerator GetEnumerator()
		{
			return this.arrayList_0.GetEnumerator();
		}
	}
}
