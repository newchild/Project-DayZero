using System;

namespace MonoTorrent.Client
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public sealed class TorrentSettings : ICloneable
	{
		// Token: 0x040011C1 RID: 4545
		private long connectionRetentionFactor;

		// Token: 0x040011B3 RID: 4531
		private const int DefaultDownloadSpeed = 0;

		// Token: 0x040011B7 RID: 4535
		private const bool DefaultInitialSeedingEnabled = false;

		// Token: 0x040011B4 RID: 4532
		private const int DefaultMaxConnections = 60;

		// Token: 0x040011B5 RID: 4533
		private const int DefaultUploadSlots = 4;

		// Token: 0x040011B6 RID: 4534
		private const int DefaultUploadSpeed = 0;

		// Token: 0x040011B8 RID: 4536
		private bool enablePeerExchange;

		// Token: 0x040011B9 RID: 4537
		private bool initialSeedingEnabled;

		// Token: 0x040011BC RID: 4540
		private int maxConnections;

		// Token: 0x040011BA RID: 4538
		private int maxDownloadSpeed;

		// Token: 0x040011BB RID: 4539
		private int maxUploadSpeed;

		// Token: 0x040011BE RID: 4542
		private int minimumTimeBetweenReviews;

		// Token: 0x040011BF RID: 4543
		private int percentOfMaxRateToSkipReview;

		// Token: 0x040011C0 RID: 4544
		private TimeSpan timeToWaitUntilIdle;

		// Token: 0x040011BD RID: 4541
		private int uploadSlots;

		// Token: 0x040011C2 RID: 4546
		private bool useDht;

		// Token: 0x060016FA RID: 5882
		// RVA: 0x00014375 File Offset: 0x00012575
		public TorrentSettings Clone()
		{
			return (TorrentSettings)base.MemberwiseClone();
		}

		// Token: 0x060016FB RID: 5883
		// RVA: 0x00072B40 File Offset: 0x00070D40
		public override bool Equals(object obj)
		{
			TorrentSettings torrentSettings = obj as TorrentSettings;
			return torrentSettings != null && (this.initialSeedingEnabled == torrentSettings.initialSeedingEnabled && this.maxConnections == torrentSettings.maxConnections && this.maxDownloadSpeed == torrentSettings.maxDownloadSpeed && this.maxUploadSpeed == torrentSettings.maxUploadSpeed) && this.uploadSlots == torrentSettings.uploadSlots;
		}

		// Token: 0x060016FC RID: 5884
		// RVA: 0x00014382 File Offset: 0x00012582
		public override int GetHashCode()
		{
			return this.initialSeedingEnabled.GetHashCode() ^ this.maxConnections ^ this.maxDownloadSpeed ^ this.maxUploadSpeed ^ this.uploadSlots;
		}

		// Token: 0x060016F9 RID: 5881
		// RVA: 0x0001436D File Offset: 0x0001256D
		object ICloneable.Clone()
		{
			return this.Clone();
		}
	}
}
