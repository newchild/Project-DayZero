using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000330 RID: 816
	internal sealed class STPInstancePerformanceCounters : IDisposable, ISTPInstancePerformanceCounters
	{
		// Token: 0x040012AF RID: 4783
		private bool _isDisposed;

		// Token: 0x040012B0 RID: 4784
		private STPInstancePerformanceCounter[] _pcs;

		// Token: 0x040012B1 RID: 4785
		private static readonly STPInstancePerformanceCounter _stpInstanceNullPerformanceCounter;

		// Token: 0x0600181E RID: 6174
		// RVA: 0x00014C7D File Offset: 0x00012E7D
		static STPInstancePerformanceCounters()
		{
			STPInstancePerformanceCounters._stpInstanceNullPerformanceCounter = new STPInstanceNullPerformanceCounter();
		}

		// Token: 0x0600181F RID: 6175
		// RVA: 0x00074CB4 File Offset: 0x00072EB4
		public STPInstancePerformanceCounters(string string_0)
		{
			this._isDisposed = false;
			this._pcs = new STPInstancePerformanceCounter[14];
			STPPerformanceCounters.Instance.GetHashCode();
			for (int i = 0; i < this._pcs.Length; i++)
			{
				if (string_0 != null)
				{
					this._pcs[i] = new STPInstancePerformanceCounter(string_0, (STPPerformanceCounterType)i);
				}
				else
				{
					this._pcs[i] = STPInstancePerformanceCounters._stpInstanceNullPerformanceCounter;
				}
			}
		}

		// Token: 0x06001820 RID: 6176
		// RVA: 0x00074D1C File Offset: 0x00072F1C
		public void Close()
		{
			if (this._pcs != null)
			{
				for (int i = 0; i < this._pcs.Length; i++)
				{
					if (this._pcs[i] != null)
					{
						this._pcs[i].Dispose();
					}
				}
				this._pcs = null;
			}
		}

		// Token: 0x06001821 RID: 6177
		// RVA: 0x00014C89 File Offset: 0x00012E89
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06001822 RID: 6178
		// RVA: 0x00014C92 File Offset: 0x00012E92
		public virtual void Dispose(bool bool_0)
		{
			if (!this._isDisposed && bool_0)
			{
				this.Close();
			}
			this._isDisposed = true;
		}

		// Token: 0x06001823 RID: 6179
		// RVA: 0x00014CAC File Offset: 0x00012EAC
		private STPInstancePerformanceCounter GetCounter(STPPerformanceCounterType stpperformanceCounterType_0)
		{
			return this._pcs[(int)stpperformanceCounterType_0];
		}

		// Token: 0x06001824 RID: 6180
		// RVA: 0x00074D64 File Offset: 0x00072F64
		public void SampleThreads(long long_0, long long_1)
		{
			this.GetCounter(STPPerformanceCounterType.ActiveThreads).Set(long_0);
			this.GetCounter(STPPerformanceCounterType.InUseThreads).Set(long_1);
			this.GetCounter(STPPerformanceCounterType.OverheadThreads).Set(long_0 - long_1);
			this.GetCounter(STPPerformanceCounterType.OverheadThreadsPercentBase).Set(long_0 - long_1);
			this.GetCounter(STPPerformanceCounterType.OverheadThreadsPercent).Set(long_1);
		}

		// Token: 0x06001825 RID: 6181
		// RVA: 0x00074DB8 File Offset: 0x00072FB8
		public void SampleWorkItems(long long_0, long long_1)
		{
			this.GetCounter(STPPerformanceCounterType.WorkItems).Set(long_0 + long_1);
			this.GetCounter(STPPerformanceCounterType.WorkItemsInQueue).Set(long_0);
			this.GetCounter(STPPerformanceCounterType.WorkItemsProcessed).Set(long_1);
			this.GetCounter(STPPerformanceCounterType.WorkItemsQueuedPerSecond).Set(long_0);
			this.GetCounter(STPPerformanceCounterType.WorkItemsProcessedPerSecond).Set(long_1);
		}

		// Token: 0x06001827 RID: 6183
		// RVA: 0x00014CDA File Offset: 0x00012EDA
		public void SampleWorkItemsProcessTime(TimeSpan timeSpan_0)
		{
			this.GetCounter(STPPerformanceCounterType.AvgWorkItemProcessTime).IncrementBy((long)timeSpan_0.TotalMilliseconds);
			this.GetCounter(STPPerformanceCounterType.AvgWorkItemProcessTimeBase).Increment();
		}

		// Token: 0x06001826 RID: 6182
		// RVA: 0x00014CB6 File Offset: 0x00012EB6
		public void SampleWorkItemsWaitTime(TimeSpan timeSpan_0)
		{
			this.GetCounter(STPPerformanceCounterType.AvgWorkItemWaitTime).IncrementBy((long)timeSpan_0.TotalMilliseconds);
			this.GetCounter(STPPerformanceCounterType.AvgWorkItemWaitTimeBase).Increment();
		}
	}
}
