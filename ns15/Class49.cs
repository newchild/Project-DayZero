using System;
using System.Security.Cryptography;
using System.Security.Permissions;

namespace ns15
{
	// Token: 0x020001AC RID: 428
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	internal abstract class Class49 : SymmetricAlgorithm
	{
		// Token: 0x04000BC2 RID: 3010
		private static KeySizes[] keySizes_0 = new KeySizes[]
		{
			new KeySizes(128, 128, 0)
		};

		// Token: 0x04000BC3 RID: 3011
		private static KeySizes[] keySizes_1 = new KeySizes[]
		{
			new KeySizes(128, 256, 64)
		};

		// Token: 0x06000EFC RID: 3836
		// RVA: 0x00051AEC File Offset: 0x0004FCEC
		protected Class49()
		{
			this.LegalBlockSizesValue = Class49.keySizes_0;
			this.LegalKeySizesValue = Class49.keySizes_1;
			this.BlockSizeValue = 128;
			this.FeedbackSizeValue = 8;
			this.KeySizeValue = 256;
			this.ModeValue = CipherMode.CBC;
		}
	}
}
