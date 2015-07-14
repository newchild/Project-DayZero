using System;

namespace MonoTorrent.Client.Encryption
{
	// Token: 0x020002BB RID: 699
	[Flags]
	public enum EncryptionTypes
	{
		// Token: 0x04001146 RID: 4422
		None = 0,
		// Token: 0x04001147 RID: 4423
		PlainText = 1,
		// Token: 0x04001148 RID: 4424
		RC4Header = 2,
		// Token: 0x04001149 RID: 4425
		RC4Full = 4,
		// Token: 0x0400114A RID: 4426
		All = 7
	}
}
