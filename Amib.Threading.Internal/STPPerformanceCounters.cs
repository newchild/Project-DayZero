using System;
using System.Diagnostics;

namespace Amib.Threading.Internal
{
	// Token: 0x0200032D RID: 813
	internal sealed class STPPerformanceCounters
	{
		// Token: 0x040012AC RID: 4780
		private static readonly STPPerformanceCounters _instance;

		// Token: 0x040012AB RID: 4779
		internal STPPerformanceCounter[] _stpPerformanceCounters;

		// Token: 0x17000335 RID: 821
		public static STPPerformanceCounters Instance
		{
			// Token: 0x06001811 RID: 6161
			// RVA: 0x00014BEA File Offset: 0x00012DEA
			get
			{
				return STPPerformanceCounters._instance;
			}
		}

		// Token: 0x0600180E RID: 6158
		// RVA: 0x00014BDE File Offset: 0x00012DDE
		static STPPerformanceCounters()
		{
			STPPerformanceCounters._instance = new STPPerformanceCounters();
		}

		// Token: 0x0600180F RID: 6159
		// RVA: 0x00074A84 File Offset: 0x00072C84
		private STPPerformanceCounters()
		{
			STPPerformanceCounter[] stpPerformanceCounters = new STPPerformanceCounter[]
			{
				new STPPerformanceCounter("Active threads", "The current number of available in the thread pool.", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("In use threads", "The current number of threads that execute a work item.", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("Overhead threads", "The current number of threads that are active, but are not in use.", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("% overhead threads", "The current number of threads that are active, but are not in use in percents.", PerformanceCounterType.RawFraction),
				new STPPerformanceCounter("% overhead threads base", "The current number of threads that are active, but are not in use in percents.", PerformanceCounterType.RawBase),
				new STPPerformanceCounter("Work Items", "The number of work items in the Smart Thread Pool. Both queued and processed.", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("Work Items in queue", "The current number of work items in the queue", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("Work Items processed", "The number of work items already processed", PerformanceCounterType.NumberOfItems32),
				new STPPerformanceCounter("Work Items queued/sec", "The number of work items queued per second", PerformanceCounterType.RateOfCountsPerSecond32),
				new STPPerformanceCounter("Work Items processed/sec", "The number of work items processed per second", PerformanceCounterType.RateOfCountsPerSecond32),
				new STPPerformanceCounter("Avg. Work Item wait time/sec", "The average time a work item supends in the queue waiting for its turn to execute.", PerformanceCounterType.AverageCount64),
				new STPPerformanceCounter("Avg. Work Item wait time base", "The average time a work item supends in the queue waiting for its turn to execute.", PerformanceCounterType.AverageBase),
				new STPPerformanceCounter("Avg. Work Item process time/sec", "The average time it takes to process a work item.", PerformanceCounterType.AverageCount64),
				new STPPerformanceCounter("Avg. Work Item process time base", "The average time it takes to process a work item.", PerformanceCounterType.AverageBase),
				new STPPerformanceCounter("Work Items Groups", "The current number of work item groups associated with the Smart Thread Pool.", PerformanceCounterType.NumberOfItems32)
			};
			this._stpPerformanceCounters = stpPerformanceCounters;
			this.SetupCategory();
		}

		// Token: 0x06001810 RID: 6160
		// RVA: 0x00074C10 File Offset: 0x00072E10
		private void SetupCategory()
		{
			if (!PerformanceCounterCategory.Exists("SmartThreadPool"))
			{
				CounterCreationDataCollection counterCreationDataCollection = new CounterCreationDataCollection();
				for (int i = 0; i < this._stpPerformanceCounters.Length; i++)
				{
					this._stpPerformanceCounters[i].AddCounterToCollection(counterCreationDataCollection);
				}
				PerformanceCounterCategory.Create("SmartThreadPool", "SmartThreadPool performance counters", PerformanceCounterCategoryType.MultiInstance, counterCreationDataCollection);
			}
		}
	}
}
