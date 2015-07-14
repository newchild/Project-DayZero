using System;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200005C RID: 92
	public interface ITraceWriter
	{
		// Token: 0x17000061 RID: 97
		TraceLevel LevelFilter
		{
			// Token: 0x0600027F RID: 639
			get;
		}

		// Token: 0x06000280 RID: 640
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
