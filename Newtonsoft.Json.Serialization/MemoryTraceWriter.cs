using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000063 RID: 99
	public sealed class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x0400019C RID: 412
		private readonly Queue<string> _traceMessages;

		// Token: 0x1700007A RID: 122
		public TraceLevel LevelFilter
		{
			// Token: 0x060002BD RID: 701
			// RVA: 0x0000794D File Offset: 0x00005B4D
			get;
			// Token: 0x060002BE RID: 702
			// RVA: 0x00007955 File Offset: 0x00005B55
			set;
		}

		// Token: 0x060002BF RID: 703
		// RVA: 0x0000795E File Offset: 0x00005B5E
		public MemoryTraceWriter()
		{
			this.LevelFilter = TraceLevel.Verbose;
			this._traceMessages = new Queue<string>();
		}

		// Token: 0x060002C1 RID: 705
		// RVA: 0x00007978 File Offset: 0x00005B78
		public IEnumerable<string> GetTraceMessages()
		{
			return this._traceMessages;
		}

		// Token: 0x060002C2 RID: 706
		// RVA: 0x0002F350 File Offset: 0x0002D550
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string current in this._traceMessages)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append(current);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002C0 RID: 704
		// RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			string item = string.Concat(new string[]
			{
				DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture),
				" ",
				level.ToString("g"),
				" ",
				message
			});
			if (this._traceMessages.Count >= 1000)
			{
				this._traceMessages.Dequeue();
			}
			this._traceMessages.Enqueue(item);
		}
	}
}
