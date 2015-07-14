using System;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200005D RID: 93
	public sealed class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x17000062 RID: 98
		public TraceLevel LevelFilter
		{
			// Token: 0x06000281 RID: 641
			// RVA: 0x00007636 File Offset: 0x00005836
			get;
			// Token: 0x06000282 RID: 642
			// RVA: 0x0000763E File Offset: 0x0000583E
			set;
		}

		// Token: 0x06000283 RID: 643
		// RVA: 0x0002EDF8 File Offset: 0x0002CFF8
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			switch (level)
			{
			case TraceLevel.Error:
				return TraceEventType.Error;
			case TraceLevel.Warning:
				return TraceEventType.Warning;
			case TraceLevel.Info:
				return TraceEventType.Information;
			case TraceLevel.Verbose:
				return TraceEventType.Verbose;
			default:
				throw new ArgumentOutOfRangeException("level");
			}
		}

		// Token: 0x06000284 RID: 644
		// RVA: 0x0002EE34 File Offset: 0x0002D034
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			if (level == TraceLevel.Off)
			{
				return;
			}
			TraceEventCache eventCache = new TraceEventCache();
			TraceEventType traceEventType = this.GetTraceEventType(level);
			foreach (TraceListener traceListener in System.Diagnostics.Trace.Listeners)
			{
				if (!traceListener.IsThreadSafe)
				{
					lock (traceListener)
					{
						traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
						goto IL_65;
					}
					goto IL_56;
				}
				goto IL_56;
				IL_65:
				if (System.Diagnostics.Trace.AutoFlush)
				{
					traceListener.Flush();
					continue;
				}
				continue;
				IL_56:
				traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
				goto IL_65;
			}
		}
	}
}
