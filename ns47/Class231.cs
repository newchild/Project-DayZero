using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ns47
{
	// Token: 0x020002B2 RID: 690
	internal sealed class Class231 : Class230, IEnumerable, IEnumerable<KeyValuePair<Class234, Class230>>, IDictionary<Class234, Class230>, ICollection<KeyValuePair<Class234, Class230>>
	{
		// Token: 0x04001127 RID: 4391
		private SortedDictionary<Class234, Class230> sortedDictionary_0;

		// Token: 0x170002F6 RID: 758
		public int Count
		{
			// Token: 0x0600164C RID: 5708
			// RVA: 0x00013CB1 File Offset: 0x00011EB1
			get
			{
				return this.sortedDictionary_0.Count;
			}
		}

		// Token: 0x170002F7 RID: 759
		public bool IsReadOnly
		{
			// Token: 0x0600164D RID: 5709
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170002F5 RID: 757
		public Class230 this[Class234 key]
		{
			// Token: 0x06001651 RID: 5713
			// RVA: 0x00013CEF File Offset: 0x00011EEF
			get
			{
				return this.sortedDictionary_0[key];
			}
			// Token: 0x06001652 RID: 5714
			// RVA: 0x00013CFD File Offset: 0x00011EFD
			set
			{
				this.sortedDictionary_0[key] = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		public ICollection<Class234> Keys
		{
			// Token: 0x06001653 RID: 5715
			// RVA: 0x00013D0C File Offset: 0x00011F0C
			get
			{
				return this.sortedDictionary_0.Keys;
			}
		}

		// Token: 0x170002F9 RID: 761
		public ICollection<Class230> Values
		{
			// Token: 0x06001654 RID: 5716
			// RVA: 0x00013D19 File Offset: 0x00011F19
			get
			{
				return this.sortedDictionary_0.Values;
			}
		}

		// Token: 0x06001647 RID: 5703
		// RVA: 0x00013C36 File Offset: 0x00011E36
		public void Add(KeyValuePair<Class234, Class230> item)
		{
			this.sortedDictionary_0.Add(item.Key, item.Value);
		}

		// Token: 0x06001646 RID: 5702
		// RVA: 0x00013C27 File Offset: 0x00011E27
		public void Add(Class234 key, Class230 value)
		{
			this.sortedDictionary_0.Add(key, value);
		}

		// Token: 0x06001648 RID: 5704
		// RVA: 0x00013C51 File Offset: 0x00011E51
		public void Clear()
		{
			this.sortedDictionary_0.Clear();
		}

		// Token: 0x06001649 RID: 5705
		// RVA: 0x00013C5E File Offset: 0x00011E5E
		public bool Contains(KeyValuePair<Class234, Class230> item)
		{
			return this.sortedDictionary_0.ContainsKey(item.Key) && this.sortedDictionary_0[item.Key].Equals(item.Value);
		}

		// Token: 0x0600164A RID: 5706
		// RVA: 0x00013C94 File Offset: 0x00011E94
		public bool ContainsKey(Class234 key)
		{
			return this.sortedDictionary_0.ContainsKey(key);
		}

		// Token: 0x0600164B RID: 5707
		// RVA: 0x00013CA2 File Offset: 0x00011EA2
		public void CopyTo(KeyValuePair<Class234, Class230>[] array, int arrayIndex)
		{
			this.sortedDictionary_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x06001641 RID: 5697
		// RVA: 0x00071A18 File Offset: 0x0006FC18
		public override int Encode(byte[] byte_0, int int_0)
		{
			int num = 0;
			byte_0[int_0] = 100;
			num = 1;
			foreach (KeyValuePair<Class234, Class230> current in this)
			{
				num += current.Key.Encode(byte_0, int_0 + num);
				num += current.Value.Encode(byte_0, int_0 + num);
			}
			byte_0[int_0 + num] = 101;
			num++;
			return num;
		}

		// Token: 0x06001643 RID: 5699
		// RVA: 0x00071B0C File Offset: 0x0006FD0C
		public override bool Equals(object obj)
		{
			Class231 class = obj as Class231;
			if (class == null)
			{
				return false;
			}
			if (this.sortedDictionary_0.Count != class.sortedDictionary_0.Count)
			{
				return false;
			}
			foreach (KeyValuePair<Class234, Class230> current in this.sortedDictionary_0)
			{
				Class230 obj2;
				if (!class.TryGetValue(current.Key, ref obj2))
				{
					bool result = false;
					return result;
				}
				if (!current.Value.Equals(obj2))
				{
					bool result = false;
					return result;
				}
			}
			return true;
		}

		// Token: 0x06001655 RID: 5717
		// RVA: 0x00013D26 File Offset: 0x00011F26
		public IEnumerator<KeyValuePair<Class234, Class230>> GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x06001644 RID: 5700
		// RVA: 0x00071BAC File Offset: 0x0006FDAC
		public override int GetHashCode()
		{
			int num = 0;
			foreach (KeyValuePair<Class234, Class230> current in this.sortedDictionary_0)
			{
				num ^= current.Key.GetHashCode();
				num ^= current.Value.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600164E RID: 5710
		// RVA: 0x00013CBE File Offset: 0x00011EBE
		public bool Remove(Class234 key)
		{
			return this.sortedDictionary_0.Remove(key);
		}

		// Token: 0x0600164F RID: 5711
		// RVA: 0x00013CCC File Offset: 0x00011ECC
		public bool Remove(KeyValuePair<Class234, Class230> item)
		{
			return this.sortedDictionary_0.Remove(item.Key);
		}

		// Token: 0x06001656 RID: 5718
		// RVA: 0x00013D26 File Offset: 0x00011F26
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x06001645 RID: 5701
		// RVA: 0x00013C15 File Offset: 0x00011E15
		public override string ToString()
		{
			return Encoding.UTF8.GetString(base.Encode());
		}

		// Token: 0x06001650 RID: 5712
		// RVA: 0x00013CE0 File Offset: 0x00011EE0
		public bool TryGetValue(Class234 key, ref Class230 value)
		{
			return this.sortedDictionary_0.TryGetValue(key, out value);
		}

		// Token: 0x06001642 RID: 5698
		// RVA: 0x00071A98 File Offset: 0x0006FC98
		public override int vmethod_0()
		{
			int num = 0;
			num = 1;
			foreach (KeyValuePair<Class234, Class230> current in this.sortedDictionary_0)
			{
				num += current.Key.vmethod_0();
				num += current.Value.vmethod_0();
			}
			num++;
			return num;
		}
	}
}
