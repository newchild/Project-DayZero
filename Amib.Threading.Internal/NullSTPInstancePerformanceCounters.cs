using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000331 RID: 817
	internal sealed class NullSTPInstancePerformanceCounters : IDisposable, ISTPInstancePerformanceCounters
	{
		// Token: 0x040012B2 RID: 4786
		private static readonly NullSTPInstancePerformanceCounters _instance = new NullSTPInstancePerformanceCounters();

		// Token: 0x17000336 RID: 822
		public static NullSTPInstancePerformanceCounters Instance
		{
			// Token: 0x06001828 RID: 6184
			// RVA: 0x00014CFE File Offset: 0x00012EFE
			get
			{
				return NullSTPInstancePerformanceCounters._instance;
			}
		}

		// Token: 0x06001829 RID: 6185
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void Dispose()
		{
		}

		// Token: 0x0600182A RID: 6186
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleThreads(long long_0, long long_1)
		{
		}

		// Token: 0x0600182B RID: 6187
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleWorkItems(long long_0, long long_1)
		{
		}

		// Token: 0x0600182D RID: 6189
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleWorkItemsProcessTime(TimeSpan timeSpan_0)
		{
		}

		// Token: 0x0600182C RID: 6188
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void SampleWorkItemsWaitTime(TimeSpan timeSpan_0)
		{
		}
	}
}
