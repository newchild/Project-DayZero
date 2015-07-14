using ns24;
using ns3;
using osu_common;
using System;

namespace ns76
{
	// Token: 0x0200055A RID: 1370
	internal sealed class Class515 : Class512
	{
		// Token: 0x06002C79 RID: 11385
		// RVA: 0x00021B40 File Offset: 0x0001FD40
		internal Class515(Struct13 struct13_0, string string_6) : base(struct13_0, string_6)
		{
			this.playModes_0 = PlayModes.Taiko;
		}

		// Token: 0x06002C7A RID: 11386
		// RVA: 0x00021B51 File Offset: 0x0001FD51
		internal Class515(Class296 class296_1, string string_6) : base(class296_1, string_6)
		{
			this.playModes_0 = PlayModes.Taiko;
		}

		// Token: 0x06002C7B RID: 11387
		// RVA: 0x00021B62 File Offset: 0x0001FD62
		internal Class515(string string_6, Class296 class296_1) : base(string_6, class296_1)
		{
			this.playModes_0 = PlayModes.Taiko;
		}

		// Token: 0x06002C78 RID: 11384
		// RVA: 0x00021B07 File Offset: 0x0001FD07
		internal override float vmethod_1()
		{
			if (this.vmethod_2() <= 0)
			{
				return 0f;
			}
			return (float)(this.ushort_0 * 150 + this.ushort_1 * 300) / (float)(this.vmethod_2() * 300);
		}
	}
}
