using System;
using System.Collections;

namespace ns30
{
	// Token: 0x020001FD RID: 509
	internal sealed class Class155 : IEnumerable, IList, ICollection
	{
		// Token: 0x020001FE RID: 510
		private sealed class Class156 : IEnumerator
		{
			// Token: 0x04000DF3 RID: 3571
			private Class155 class155_0;

			// Token: 0x04000DF2 RID: 3570
			private IEnumerator ienumerator_0;

			// Token: 0x170002B2 RID: 690
			object IEnumerator.Current
			{
				// Token: 0x060011F9 RID: 4601
				// RVA: 0x00060964 File Offset: 0x0005EB64
				get
				{
					byte[] byte_ = (byte[])this.ienumerator_0.Current;
					return this.class155_0.GetString(byte_);
				}
			}

			// Token: 0x060011F6 RID: 4598
			// RVA: 0x00010F19 File Offset: 0x0000F119
			public Class156(Class155 class155_1)
			{
				this.class155_0 = class155_1;
				this.ienumerator_0 = class155_1.arrayList_0.GetEnumerator();
			}

			// Token: 0x060011F7 RID: 4599
			// RVA: 0x00010F39 File Offset: 0x0000F139
			bool IEnumerator.MoveNext()
			{
				return this.ienumerator_0.MoveNext();
			}

			// Token: 0x060011F8 RID: 4600
			// RVA: 0x00010F46 File Offset: 0x0000F146
			void IEnumerator.Reset()
			{
				this.ienumerator_0.Reset();
			}
		}

		// Token: 0x04000DF1 RID: 3569
		private ArrayList arrayList_0;

		// Token: 0x04000DF0 RID: 3568
		private string string_0;

		// Token: 0x170002AC RID: 684
		public int Count
		{
			// Token: 0x060011ED RID: 4589
			// RVA: 0x00010EC6 File Offset: 0x0000F0C6
			get
			{
				return this.arrayList_0.Count;
			}
		}

		// Token: 0x170002AE RID: 686
		public bool IsSynchronized
		{
			// Token: 0x060011EE RID: 4590
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002AB RID: 683
		public string this[int int_0]
		{
			// Token: 0x060011EF RID: 4591
			// RVA: 0x00010ED3 File Offset: 0x0000F0D3
			get
			{
				return this.GetString((byte[])this.arrayList_0[int_0]);
			}
			// Token: 0x060011F0 RID: 4592
			// RVA: 0x00010EEC File Offset: 0x0000F0EC
			set
			{
				this.arrayList_0[int_0] = this.method_1(value);
			}
		}

		// Token: 0x170002AD RID: 685
		public object SyncRoot
		{
			// Token: 0x060011F1 RID: 4593
			// RVA: 0x00007F8B File Offset: 0x0000618B
			get
			{
				return this;
			}
		}

		// Token: 0x170002AF RID: 687
		bool IList.IsFixedSize
		{
			// Token: 0x060011F2 RID: 4594
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002B0 RID: 688
		bool IList.IsReadOnly
		{
			// Token: 0x060011F3 RID: 4595
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002B1 RID: 689
		object IList.this[int index]
		{
			// Token: 0x060011F4 RID: 4596
			// RVA: 0x00010F01 File Offset: 0x0000F101
			get
			{
				return this[index];
			}
			// Token: 0x060011F5 RID: 4597
			// RVA: 0x00010F0A File Offset: 0x0000F10A
			set
			{
				this[index] = (string)value;
			}
		}

		// Token: 0x060011D4 RID: 4564
		// RVA: 0x00010D4C File Offset: 0x0000EF4C
		public int Add(string string_1)
		{
			return this.Add(this.method_1(string_1));
		}

		// Token: 0x060011D5 RID: 4565
		// RVA: 0x00010D5B File Offset: 0x0000EF5B
		public int Add(byte[] byte_0)
		{
			return this.arrayList_0.Add(byte_0);
		}

		// Token: 0x060011D7 RID: 4567
		// RVA: 0x00010D69 File Offset: 0x0000EF69
		public void Clear()
		{
			this.arrayList_0.Clear();
		}

		// Token: 0x060011D8 RID: 4568
		// RVA: 0x00010D76 File Offset: 0x0000EF76
		public bool Contains(byte[] byte_0)
		{
			return this.IndexOf(byte_0) > -1;
		}

		// Token: 0x060011D9 RID: 4569
		// RVA: 0x00010D82 File Offset: 0x0000EF82
		public bool Contains(string string_1)
		{
			return this.Contains(this.method_1(string_1));
		}

		// Token: 0x060011DA RID: 4570
		// RVA: 0x000608A8 File Offset: 0x0005EAA8
		public void CopyTo(string[] string_1, int int_0)
		{
			for (int i = 0; i < this.Count; i++)
			{
				string_1[i] = this[i];
			}
		}

		// Token: 0x060011DC RID: 4572
		// RVA: 0x00010D9F File Offset: 0x0000EF9F
		private string GetString(byte[] byte_0)
		{
			return Class175.GetString(byte_0, this.method_2());
		}

		// Token: 0x060011DD RID: 4573
		// RVA: 0x00010DAD File Offset: 0x0000EFAD
		public int IndexOf(string string_1)
		{
			return this.IndexOf(this.method_1(string_1));
		}

		// Token: 0x060011DE RID: 4574
		// RVA: 0x000608D0 File Offset: 0x0005EAD0
		public int IndexOf(byte[] byte_0)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (this.method_0((byte[])this.arrayList_0[i], byte_0))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060011DF RID: 4575
		// RVA: 0x00010DBC File Offset: 0x0000EFBC
		public void Insert(int int_0, string string_1)
		{
			this.Insert(int_0, this.method_1(string_1));
		}

		// Token: 0x060011E0 RID: 4576
		// RVA: 0x00010DCC File Offset: 0x0000EFCC
		public void Insert(int int_0, byte[] byte_0)
		{
			this.arrayList_0.Insert(int_0, byte_0);
		}

		// Token: 0x060011D6 RID: 4566
		// RVA: 0x00060868 File Offset: 0x0005EA68
		private bool method_0(byte[] byte_0, byte[] byte_1)
		{
			if (byte_0 != null || byte_1 != null)
			{
				if (byte_0 == null || byte_1 == null)
				{
					return false;
				}
				if (byte_0.Length != byte_1.Length)
				{
					return false;
				}
				for (int i = 0; i < byte_0.Length; i++)
				{
					if (byte_0[i] != byte_1[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060011DB RID: 4571
		// RVA: 0x00010D91 File Offset: 0x0000EF91
		private byte[] method_1(string string_1)
		{
			return Class175.smethod_0(string_1, this.method_2());
		}

		// Token: 0x060011EC RID: 4588
		// RVA: 0x00010EBE File Offset: 0x0000F0BE
		public string method_2()
		{
			return this.string_0;
		}

		// Token: 0x060011E1 RID: 4577
		// RVA: 0x0006090C File Offset: 0x0005EB0C
		public void Remove(byte[] byte_0)
		{
			int num = this.IndexOf(byte_0);
			if (num > -1)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060011E2 RID: 4578
		// RVA: 0x00010DDB File Offset: 0x0000EFDB
		public void Remove(string string_1)
		{
			this.Remove(this.method_1(string_1));
		}

		// Token: 0x060011E3 RID: 4579
		// RVA: 0x00010DEA File Offset: 0x0000EFEA
		public void RemoveAt(int index)
		{
			this.arrayList_0.RemoveAt(index);
		}

		// Token: 0x060011E4 RID: 4580
		// RVA: 0x00010DF8 File Offset: 0x0000EFF8
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyTo((string[])array, index);
		}

		// Token: 0x060011E5 RID: 4581
		// RVA: 0x00010E07 File Offset: 0x0000F007
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Class155.Class156(this);
		}

		// Token: 0x060011E6 RID: 4582
		// RVA: 0x00010E0F File Offset: 0x0000F00F
		int IList.Add(object value)
		{
			if (value is string)
			{
				return this.Add((string)value);
			}
			return this.Add((byte[])value);
		}

		// Token: 0x060011E7 RID: 4583
		// RVA: 0x00010E32 File Offset: 0x0000F032
		bool IList.Contains(object value)
		{
			if (value is string)
			{
				return this.Contains((string)value);
			}
			return this.Contains((byte[])value);
		}

		// Token: 0x060011E8 RID: 4584
		// RVA: 0x00010E55 File Offset: 0x0000F055
		int IList.IndexOf(object value)
		{
			if (value is string)
			{
				return this.IndexOf((string)value);
			}
			return this.IndexOf((byte[])value);
		}

		// Token: 0x060011E9 RID: 4585
		// RVA: 0x00010E78 File Offset: 0x0000F078
		void IList.Insert(int index, object value)
		{
			if (value is string)
			{
				this.Insert(index, (string)value);
			}
			this.Insert(index, (byte[])value);
		}

		// Token: 0x060011EA RID: 4586
		// RVA: 0x00010E9C File Offset: 0x0000F09C
		void IList.Remove(object value)
		{
			if (value is string)
			{
				this.Remove((string)value);
			}
			this.Remove((byte[])value);
		}

		// Token: 0x060011EB RID: 4587
		// RVA: 0x0006092C File Offset: 0x0005EB2C
		public override string ToString()
		{
			string[] array = new string[this.Count];
			this.CopyTo(array, 0);
			return string.Join("\r\n", array) + "\r\n";
		}
	}
}
