using System;
using System.Diagnostics;

namespace Amib.Threading.Internal
{
	// Token: 0x0200032C RID: 812
	internal sealed class STPPerformanceCounter
	{
		// Token: 0x040012A9 RID: 4777
		protected string _counterHelp;

		// Token: 0x040012AA RID: 4778
		protected string _counterName;

		// Token: 0x040012A8 RID: 4776
		private readonly PerformanceCounterType _pcType;

		// Token: 0x17000334 RID: 820
		public string Name
		{
			// Token: 0x0600180D RID: 6157
			// RVA: 0x00014BD6 File Offset: 0x00012DD6
			get
			{
				return this._counterName;
			}
		}

		// Token: 0x0600180B RID: 6155
		// RVA: 0x00014BB9 File Offset: 0x00012DB9
		public STPPerformanceCounter(string string_0, string string_1, PerformanceCounterType performanceCounterType_0)
		{
			this._counterName = string_0;
			this._counterHelp = string_1;
			this._pcType = performanceCounterType_0;
		}

		// Token: 0x0600180C RID: 6156
		// RVA: 0x00074A54 File Offset: 0x00072C54
		public void AddCounterToCollection(CounterCreationDataCollection counterCreationDataCollection_0)
		{
			CounterCreationData value = new CounterCreationData(this._counterName, this._counterHelp, this._pcType);
			counterCreationDataCollection_0.Add(value);
		}
	}
}
