using System;
using System.Runtime.Serialization;

namespace MonoTorrent.Common
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public sealed class TorrentException : Exception
	{
		// Token: 0x06001686 RID: 5766
		// RVA: 0x00006FA4 File Offset: 0x000051A4
		public TorrentException(string string_0, Exception exception_0) : base(string_0, exception_0)
		{
		}

		// Token: 0x06001687 RID: 5767
		// RVA: 0x00006FAE File Offset: 0x000051AE
		public TorrentException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
