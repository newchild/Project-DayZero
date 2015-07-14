using osu.GameplayElements.Events;
using System;

namespace ns89
{
	// Token: 0x0200065B RID: 1627
	internal sealed class Class705 : Class702, IComparable<Class705>
	{
		// Token: 0x04002DD9 RID: 11737
		public bool bool_3;

		// Token: 0x04002DDA RID: 11738
		public bool bool_4;

		// Token: 0x0600320C RID: 12812
		// RVA: 0x00024E58 File Offset: 0x00023058
		internal Class705(int int_3, int int_4)
		{
			this.eventTypes_0 = EventTypes.Break;
			this.int_2 = int_3;
			this.int_0 = int_4;
			this.bool_0 = true;
		}

		// Token: 0x06003210 RID: 12816
		// RVA: 0x0014915C File Offset: 0x0014735C
		internal override Class702 Clone()
		{
			return new Class705(this.int_2, this.int_0)
			{
				bool_3 = this.bool_3,
				bool_4 = this.bool_4
			};
		}

		// Token: 0x06003211 RID: 12817
		// RVA: 0x0002106D File Offset: 0x0001F26D
		public int CompareTo(Class705 obj)
		{
			return this.int_2.CompareTo(obj.int_2);
		}

		// Token: 0x0600320F RID: 12815
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool Load()
		{
			return false;
		}

		// Token: 0x0600320D RID: 12813
		// RVA: 0x00024E7C File Offset: 0x0002307C
		internal override void vmethod_0(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x0600320E RID: 12814
		// RVA: 0x00024E85 File Offset: 0x00023085
		internal override void vmethod_1(int int_3)
		{
			this.int_0 = int_3;
		}
	}
}
