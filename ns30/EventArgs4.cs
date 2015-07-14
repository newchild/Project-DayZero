using System;

namespace ns30
{
	// Token: 0x02000214 RID: 532
	internal sealed class EventArgs4 : EventArgs
	{
		// Token: 0x04000E68 RID: 3688
		private string string_0;

		// Token: 0x04000E69 RID: 3689
		private string[] string_1;

		// Token: 0x04000E6A RID: 3690
		private Uri uri_0;

		// Token: 0x060012F1 RID: 4849
		// RVA: 0x00011A83 File Offset: 0x0000FC83
		public EventArgs4(string string_2, Uri uri_1, string[] string_3)
		{
			this.string_0 = string_2;
			this.uri_0 = uri_1;
			this.string_1 = string_3;
		}
	}
}
