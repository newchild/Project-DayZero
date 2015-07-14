using System;
using System.Runtime.Serialization;

namespace MonoTorrent.BEncoding
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public sealed class BEncodingException : Exception
	{
		// Token: 0x0600167C RID: 5756
		// RVA: 0x00006F9B File Offset: 0x0000519B
		public BEncodingException(string string_0) : base(string_0)
		{
		}

		// Token: 0x0600167D RID: 5757
		// RVA: 0x00006FAE File Offset: 0x000051AE
		protected BEncodingException(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
		{
		}
	}
}
