using System;

namespace osu_common.Updater
{
	// Token: 0x02000289 RID: 649
	public class UpdaterFileInfo
	{
		// Token: 0x040010AD RID: 4269
		public string filename;

		// Token: 0x040010AF RID: 4271
		public int filesize;

		// Token: 0x040010AE RID: 4270
		public string file_hash;

		// Token: 0x040010AC RID: 4268
		public int file_version;

		// Token: 0x040010B2 RID: 4274
		public int? patch_from;

		// Token: 0x040010B1 RID: 4273
		public int? patch_id;

		// Token: 0x040010B5 RID: 4277
		public string response;

		// Token: 0x040010B0 RID: 4272
		public DateTime timestamp;

		// Token: 0x040010B3 RID: 4275
		public string url_full;

		// Token: 0x040010B4 RID: 4276
		public string url_patch;

		// Token: 0x040010B6 RID: 4278
		public bool zip;
	}
}
