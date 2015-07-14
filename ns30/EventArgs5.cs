using System;

namespace ns30
{
	// Token: 0x02000218 RID: 536
	internal sealed class EventArgs5 : EventArgs
	{
		// Token: 0x04000E76 RID: 3702
		private Class154 class154_0;

		// Token: 0x04000E77 RID: 3703
		private string string_0;

		// Token: 0x04000E78 RID: 3704
		private string[] string_1;

		// Token: 0x04000E79 RID: 3705
		private Uri uri_0;

		// Token: 0x0600131A RID: 4890
		// RVA: 0x00011CDD File Offset: 0x0000FEDD
		public EventArgs5(string string_2, Uri uri_1, string[] string_3, Class154 class154_1)
		{
			this.string_0 = string_2;
			this.uri_0 = uri_1;
			this.string_1 = string_3;
			this.class154_0 = class154_1;
		}
	}
}
