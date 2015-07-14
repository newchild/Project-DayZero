using System;
using System.Security.Cryptography;
using System.Security.Permissions;

namespace ns15
{
	// Token: 0x020001AD RID: 429
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	internal sealed class Class50 : Class49
	{
		// Token: 0x04000BC4 RID: 3012
		private RijndaelManaged rijndaelManaged_0;

		// Token: 0x17000282 RID: 642
		public override int FeedbackSize
		{
			// Token: 0x06000F06 RID: 3846
			// RVA: 0x0000F1F9 File Offset: 0x0000D3F9
			get
			{
				return this.rijndaelManaged_0.FeedbackSize;
			}
			// Token: 0x06000F07 RID: 3847
			// RVA: 0x0000F206 File Offset: 0x0000D406
			set
			{
				this.rijndaelManaged_0.FeedbackSize = value;
			}
		}

		// Token: 0x17000283 RID: 643
		public override byte[] IV
		{
			// Token: 0x06000F08 RID: 3848
			// RVA: 0x0000F214 File Offset: 0x0000D414
			get
			{
				return this.rijndaelManaged_0.IV;
			}
			// Token: 0x06000F09 RID: 3849
			// RVA: 0x0000F221 File Offset: 0x0000D421
			set
			{
				this.rijndaelManaged_0.IV = value;
			}
		}

		// Token: 0x17000284 RID: 644
		public override byte[] Key
		{
			// Token: 0x06000F0A RID: 3850
			// RVA: 0x0000F22F File Offset: 0x0000D42F
			get
			{
				return this.rijndaelManaged_0.Key;
			}
			// Token: 0x06000F0B RID: 3851
			// RVA: 0x0000F23C File Offset: 0x0000D43C
			set
			{
				this.rijndaelManaged_0.Key = value;
			}
		}

		// Token: 0x17000285 RID: 645
		public override int KeySize
		{
			// Token: 0x06000F0C RID: 3852
			// RVA: 0x0000F24A File Offset: 0x0000D44A
			get
			{
				return this.rijndaelManaged_0.KeySize;
			}
			// Token: 0x06000F0D RID: 3853
			// RVA: 0x0000F257 File Offset: 0x0000D457
			set
			{
				this.rijndaelManaged_0.KeySize = value;
			}
		}

		// Token: 0x17000286 RID: 646
		public override CipherMode Mode
		{
			// Token: 0x06000F0E RID: 3854
			// RVA: 0x0000F265 File Offset: 0x0000D465
			get
			{
				return this.rijndaelManaged_0.Mode;
			}
			// Token: 0x06000F0F RID: 3855
			// RVA: 0x0000F272 File Offset: 0x0000D472
			set
			{
				if (value == CipherMode.CFB || value == CipherMode.OFB)
				{
					throw new CryptographicException("Invalid cipher mode");
				}
				this.rijndaelManaged_0.Mode = value;
			}
		}

		// Token: 0x17000287 RID: 647
		public override PaddingMode Padding
		{
			// Token: 0x06000F10 RID: 3856
			// RVA: 0x0000F293 File Offset: 0x0000D493
			get
			{
				return this.rijndaelManaged_0.Padding;
			}
			// Token: 0x06000F11 RID: 3857
			// RVA: 0x0000F2A0 File Offset: 0x0000D4A0
			set
			{
				this.rijndaelManaged_0.Padding = value;
			}
		}

		// Token: 0x06000EFE RID: 3838
		// RVA: 0x0000F179 File Offset: 0x0000D379
		public Class50()
		{
			this.rijndaelManaged_0 = new RijndaelManaged();
			this.rijndaelManaged_0.BlockSize = this.BlockSize;
			this.rijndaelManaged_0.KeySize = this.KeySize;
		}

		// Token: 0x06000EFF RID: 3839
		// RVA: 0x0000F1AE File Offset: 0x0000D3AE
		public override ICryptoTransform CreateDecryptor()
		{
			return this.rijndaelManaged_0.CreateDecryptor();
		}

		// Token: 0x06000F00 RID: 3840
		// RVA: 0x00051B8C File Offset: 0x0004FD8C
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!base.ValidKeySize(rgbKey.Length * 8))
			{
				throw new ArgumentException("Invalid key size", "key");
			}
			if (rgbIV != null && rgbIV.Length * 8 != this.BlockSizeValue)
			{
				throw new ArgumentException("Invalid IV size", "iv");
			}
			return this.rijndaelManaged_0.CreateDecryptor(rgbKey, rgbIV);
		}

		// Token: 0x06000F01 RID: 3841
		// RVA: 0x0000F1BB File Offset: 0x0000D3BB
		public override ICryptoTransform CreateEncryptor()
		{
			return this.rijndaelManaged_0.CreateEncryptor();
		}

		// Token: 0x06000F02 RID: 3842
		// RVA: 0x00051BF4 File Offset: 0x0004FDF4
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!base.ValidKeySize(rgbKey.Length * 8))
			{
				throw new ArgumentException("Invalid key size", "key");
			}
			if (rgbIV != null && rgbIV.Length * 8 != this.BlockSizeValue)
			{
				throw new ArgumentException("Invalid IV size", "iv");
			}
			return this.rijndaelManaged_0.CreateEncryptor(rgbKey, rgbIV);
		}

		// Token: 0x06000F03 RID: 3843
		// RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				((IDisposable)this.rijndaelManaged_0).Dispose();
			}
		}

		// Token: 0x06000F04 RID: 3844
		// RVA: 0x0000F1DF File Offset: 0x0000D3DF
		public override void GenerateIV()
		{
			this.rijndaelManaged_0.GenerateIV();
		}

		// Token: 0x06000F05 RID: 3845
		// RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public override void GenerateKey()
		{
			this.rijndaelManaged_0.GenerateKey();
		}
	}
}
