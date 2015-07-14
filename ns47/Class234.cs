using ns46;
using ns48;
using System;
using System.Text;

namespace ns47
{
	// Token: 0x020002B5 RID: 693
	internal sealed class Class234 : Class230, IComparable<Class234>
	{
		// Token: 0x0400112A RID: 4394
		private byte[] byte_0;

		// Token: 0x06001672 RID: 5746
		// RVA: 0x00013E5E File Offset: 0x0001205E
		public Class234(string string_0) : this(Encoding.UTF8.GetBytes(string_0))
		{
		}

		// Token: 0x06001673 RID: 5747
		// RVA: 0x00013E71 File Offset: 0x00012071
		public Class234(byte[] byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x06001677 RID: 5751
		// RVA: 0x00013E88 File Offset: 0x00012088
		public int CompareTo(object object_0)
		{
			return this.CompareTo(object_0 as Class234);
		}

		// Token: 0x06001678 RID: 5752
		// RVA: 0x00071F64 File Offset: 0x00070164
		public int CompareTo(Class234 obj)
		{
			if (obj == null)
			{
				return 1;
			}
			int num = (this.byte_0.Length > obj.byte_0.Length) ? obj.byte_0.Length : this.byte_0.Length;
			for (int i = 0; i < num; i++)
			{
				int result;
				if ((result = this.byte_0[i].CompareTo(obj.byte_0[i])) != 0)
				{
					return result;
				}
			}
			if (this.byte_0.Length == obj.byte_0.Length)
			{
				return 0;
			}
			if (this.byte_0.Length <= obj.byte_0.Length)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06001675 RID: 5749
		// RVA: 0x00071ED8 File Offset: 0x000700D8
		public override int Encode(byte[] byte_1, int int_0)
		{
			int num = int_0 + Class224.smethod_0(byte_1, int_0, this.byte_0.Length.ToString());
			num += Class224.smethod_0(byte_1, num, ":");
			num += Class224.Write(byte_1, num, this.byte_0);
			return num - int_0;
		}

		// Token: 0x06001679 RID: 5753
		// RVA: 0x00071FF4 File Offset: 0x000701F4
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			Class234 class;
			if (obj is string)
			{
				class = new Class234((string)obj);
			}
			else
			{
				if (!(obj is Class234))
				{
					return false;
				}
				class = (Class234)obj;
			}
			return Class275.smethod_1(this.byte_0, class.byte_0);
		}

		// Token: 0x0600167A RID: 5754
		// RVA: 0x00072040 File Offset: 0x00070240
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.byte_0.Length; i++)
			{
				num += (int)this.byte_0[i];
			}
			return num;
		}

		// Token: 0x06001674 RID: 5748
		// RVA: 0x00013E80 File Offset: 0x00012080
		public static implicit operator Class234(string string_0)
		{
			return new Class234(string_0);
		}

		// Token: 0x0600167B RID: 5755
		// RVA: 0x00013E96 File Offset: 0x00012096
		public override string ToString()
		{
			return Encoding.UTF8.GetString(this.byte_0);
		}

		// Token: 0x06001676 RID: 5750
		// RVA: 0x00071F24 File Offset: 0x00070124
		public override int vmethod_0()
		{
			int num = 1;
			for (int num2 = this.byte_0.Length; num2 != 0; num2 /= 10)
			{
				num++;
			}
			if (this.byte_0.Length == 0)
			{
				num++;
			}
			return num + this.byte_0.Length;
		}
	}
}
