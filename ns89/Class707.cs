using ns79;
using osu.GameplayElements.Events;
using System;
using System.IO;

namespace ns89
{
	// Token: 0x0200065D RID: 1629
	internal sealed class Class707 : Class702
	{
		// Token: 0x04002DE1 RID: 11745
		internal Class541 class541_0;

		// Token: 0x06003219 RID: 12825
		// RVA: 0x00024EA3 File Offset: 0x000230A3
		internal Class707(Class541 class541_1, string string_1, int int_3)
		{
			this.class541_0 = class541_1;
			this.bool_1 = true;
			this.eventTypes_0 = EventTypes.Video;
			this.string_0 = Path.GetFileName(string_1);
			this.class531_0 = class541_1;
			this.int_2 = int_3;
			this.bool_0 = true;
		}

		// Token: 0x0600321D RID: 12829
		// RVA: 0x00024EFE File Offset: 0x000230FE
		internal override Class702 Clone()
		{
			return new Class707(this.class541_0, this.string_0, this.int_2);
		}

		// Token: 0x0600321A RID: 12826
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool Load()
		{
			return false;
		}

		// Token: 0x0600321B RID: 12827
		// RVA: 0x00024EE1 File Offset: 0x000230E1
		internal override void vmethod_0(int int_3)
		{
			if (this.class541_0 != null)
			{
				this.class541_0.method_50(int_3);
			}
			this.int_2 = int_3;
		}

		// Token: 0x0600321C RID: 12828
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_1(int int_3)
		{
			throw new NotImplementedException();
		}
	}
}
