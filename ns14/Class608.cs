using ns29;
using System;

namespace ns14
{
	// Token: 0x0200049F RID: 1183
	internal sealed class Class608 : Class607
	{
		// Token: 0x17000389 RID: 905
		public new int Value
		{
			// Token: 0x060025E6 RID: 9702
			// RVA: 0x0001D71C File Offset: 0x0001B91C
			get
			{
				return (int)base.Value;
			}
			// Token: 0x060025E7 RID: 9703
			// RVA: 0x0001D725 File Offset: 0x0001B925
			set
			{
				base.Value = (double)value;
			}
		}

		// Token: 0x060025E8 RID: 9704
		// RVA: 0x0001D72F File Offset: 0x0001B92F
		public Class608(int int_0) : base((double)int_0)
		{
		}

		// Token: 0x060025E9 RID: 9705
		// RVA: 0x0001D739 File Offset: 0x0001B939
		public static implicit operator int(Class608 class608_0)
		{
			return class608_0.Value;
		}

		// Token: 0x060025EB RID: 9707
		// RVA: 0x0001D741 File Offset: 0x0001B941
		internal void Reset()
		{
			this.Value = (int)this.double_1;
		}

		// Token: 0x060025EA RID: 9706
		// RVA: 0x000E3768 File Offset: 0x000E1968
		public override string ToString()
		{
			return this.Value.ToString(Class115.numberFormatInfo_0);
		}
	}
}
