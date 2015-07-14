using MonoTorrent.Client.Encryption;
using System;
using System.Net;

namespace MonoTorrent.Client
{
	// Token: 0x020002E2 RID: 738
	[Serializable]
	public sealed class EngineSettings : ICloneable
	{
		// Token: 0x040011A7 RID: 4519
		private EncryptionTypes allowedEncryption;

		// Token: 0x040011A4 RID: 4516
		private const EncryptionTypes DefaultAllowedEncryption = EncryptionTypes.All;

		// Token: 0x0400119E RID: 4510
		private const bool DefaultEnableHaveSupression = false;

		// Token: 0x040011A5 RID: 4517
		private const int DefaultListenPort = 52138;

		// Token: 0x040011A0 RID: 4512
		private const int DefaultMaxConnections = 150;

		// Token: 0x040011A1 RID: 4513
		private const int DefaultMaxDownloadSpeed = 0;

		// Token: 0x040011A3 RID: 4515
		private const int DefaultMaxHalfOpenConnections = 5;

		// Token: 0x040011A2 RID: 4514
		private const int DefaultMaxUploadSpeed = 0;

		// Token: 0x0400119F RID: 4511
		private const string DefaultSavePath = "";

		// Token: 0x040011A9 RID: 4521
		private int globalMaxConnections;

		// Token: 0x040011AB RID: 4523
		private int globalMaxDownloadSpeed;

		// Token: 0x040011AA RID: 4522
		private int globalMaxHalfOpenConnections;

		// Token: 0x040011AC RID: 4524
		private int globalMaxUploadSpeed;

		// Token: 0x040011A6 RID: 4518
		private bool haveSupressionEnabled;

		// Token: 0x040011A8 RID: 4520
		private int listenPort;

		// Token: 0x040011AD RID: 4525
		private int maxOpenStreams;

		// Token: 0x040011AE RID: 4526
		private int maxReadRate;

		// Token: 0x040011AF RID: 4527
		private int maxWriteRate;

		// Token: 0x040011B0 RID: 4528
		private bool preferEncryption;

		// Token: 0x040011B1 RID: 4529
		private IPEndPoint reportedEndpoint;

		// Token: 0x040011B2 RID: 4530
		private string savePath;

		// Token: 0x060016F6 RID: 5878
		// RVA: 0x00014360 File Offset: 0x00012560
		public EngineSettings Clone()
		{
			return (EngineSettings)base.MemberwiseClone();
		}

		// Token: 0x060016F7 RID: 5879
		// RVA: 0x00072A6C File Offset: 0x00070C6C
		public override bool Equals(object obj)
		{
			EngineSettings engineSettings = obj as EngineSettings;
			return engineSettings != null && (this.globalMaxConnections == engineSettings.globalMaxConnections && this.globalMaxDownloadSpeed == engineSettings.globalMaxDownloadSpeed && this.globalMaxHalfOpenConnections == engineSettings.globalMaxHalfOpenConnections && this.globalMaxUploadSpeed == engineSettings.globalMaxUploadSpeed && this.listenPort == engineSettings.listenPort && this.allowedEncryption == engineSettings.allowedEncryption) && this.savePath == engineSettings.savePath;
		}

		// Token: 0x060016F8 RID: 5880
		// RVA: 0x00072AEC File Offset: 0x00070CEC
		public override int GetHashCode()
		{
			return this.globalMaxConnections + this.globalMaxDownloadSpeed + this.globalMaxHalfOpenConnections + this.globalMaxUploadSpeed + this.listenPort.GetHashCode() + this.allowedEncryption.GetHashCode() + this.savePath.GetHashCode();
		}

		// Token: 0x060016F5 RID: 5877
		// RVA: 0x00014358 File Offset: 0x00012558
		object ICloneable.Clone()
		{
			return this.Clone();
		}
	}
}
