using System;
using System.Diagnostics;

namespace Amib.Threading.Internal
{
	// Token: 0x0200032E RID: 814
	internal class STPInstancePerformanceCounter : IDisposable
	{
		// Token: 0x040012AD RID: 4781
		private bool _isDisposed;

		// Token: 0x040012AE RID: 4782
		private PerformanceCounter _pcs;

		// Token: 0x06001812 RID: 6162
		// RVA: 0x00014BF1 File Offset: 0x00012DF1
		protected STPInstancePerformanceCounter()
		{
			this._isDisposed = false;
		}

		// Token: 0x06001813 RID: 6163
		// RVA: 0x00074C64 File Offset: 0x00072E64
		public STPInstancePerformanceCounter(string string_0, STPPerformanceCounterType stpperformanceCounterType_0) : this()
		{
			STPPerformanceCounters instance = STPPerformanceCounters.Instance;
			this._pcs = new PerformanceCounter("SmartThreadPool", instance._stpPerformanceCounters[(int)stpperformanceCounterType_0].Name, string_0, false);
			this._pcs.RawValue = this._pcs.RawValue;
		}

		// Token: 0x06001814 RID: 6164
		// RVA: 0x00014C00 File Offset: 0x00012E00
		public void Close()
		{
			if (this._pcs != null)
			{
				this._pcs.RemoveInstance();
				this._pcs.Close();
				this._pcs = null;
			}
		}

		// Token: 0x06001815 RID: 6165
		// RVA: 0x00014C27 File Offset: 0x00012E27
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06001816 RID: 6166
		// RVA: 0x00014C30 File Offset: 0x00012E30
		public virtual void Dispose(bool bool_0)
		{
			if (!this._isDisposed && bool_0)
			{
				this.Close();
			}
			this._isDisposed = true;
		}

		// Token: 0x06001817 RID: 6167
		// RVA: 0x00014C4A File Offset: 0x00012E4A
		public virtual void Increment()
		{
			this._pcs.Increment();
		}

		// Token: 0x06001818 RID: 6168
		// RVA: 0x00014C58 File Offset: 0x00012E58
		public virtual void IncrementBy(long long_0)
		{
			this._pcs.IncrementBy(long_0);
		}

		// Token: 0x06001819 RID: 6169
		// RVA: 0x00014C67 File Offset: 0x00012E67
		public virtual void Set(long long_0)
		{
			this._pcs.RawValue = long_0;
		}
	}
}
