using ns8;
using osu_common.Bancho;
using osu_common.Bancho.Objects;
using System;

namespace ns3
{
	// Token: 0x02000177 RID: 375
	internal sealed class Class14 : bSerializable
	{
		// Token: 0x04000635 RID: 1589
		public bool bool_0;

		// Token: 0x04000636 RID: 1590
		public bool bool_1;

		// Token: 0x04000637 RID: 1591
		public bool bool_2;

		// Token: 0x04000638 RID: 1592
		public bool bool_3;

		// Token: 0x04000639 RID: 1593
		public bool bool_4;

		// Token: 0x0400063A RID: 1594
		public bool bool_5;

		// Token: 0x04000633 RID: 1587
		public float float_0;

		// Token: 0x04000634 RID: 1588
		public float float_1;

		// Token: 0x0400063C RID: 1596
		public int int_0;

		// Token: 0x0400063B RID: 1595
		public pButtonState pButtonState_0;

		// Token: 0x06000E1C RID: 3612
		// RVA: 0x0004DD20 File Offset: 0x0004BF20
		public Class14(Class32 class32_0)
		{
			this.pButtonState_0 = (pButtonState)class32_0.ReadByte();
			this.method_0(this.pButtonState_0);
			byte b = class32_0.ReadByte();
			if (b > 0)
			{
				this.method_0(pButtonState.Right1);
			}
			this.float_0 = class32_0.ReadSingle();
			this.float_1 = class32_0.ReadSingle();
			this.int_0 = class32_0.ReadInt32();
		}

		// Token: 0x06000E1A RID: 3610
		// RVA: 0x0000EA65 File Offset: 0x0000CC65
		public Class14(int int_1, float float_2, float float_3, pButtonState pButtonState_1)
		{
			this.float_0 = float_2;
			this.float_1 = float_3;
			this.pButtonState_0 = pButtonState_1;
			this.method_0(pButtonState_1);
			this.int_0 = int_1;
		}

		// Token: 0x06000E1B RID: 3611
		// RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		public void method_0(pButtonState pButtonState_1)
		{
			this.pButtonState_0 = pButtonState_1;
			this.bool_0 = ((pButtonState_1 & (pButtonState.Left1 | pButtonState.Left2)) > pButtonState.None);
			this.bool_2 = ((pButtonState_1 & pButtonState.Left1) > pButtonState.None);
			this.bool_4 = ((pButtonState_1 & pButtonState.Left2) > pButtonState.None);
			this.bool_1 = ((pButtonState_1 & (pButtonState.Right1 | pButtonState.Right2)) > pButtonState.None);
			this.bool_3 = ((pButtonState_1 & pButtonState.Right1) > pButtonState.None);
			this.bool_5 = ((pButtonState_1 & pButtonState.Right2) > pButtonState.None);
		}

		// Token: 0x06000E1D RID: 3613
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E1E RID: 3614
		// RVA: 0x0000EA92 File Offset: 0x0000CC92
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write((byte)this.pButtonState_0);
			class31_0.Write(0);
			class31_0.Write(this.float_0);
			class31_0.Write(this.float_1);
			class31_0.Write(this.int_0);
		}
	}
}
