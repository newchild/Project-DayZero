using System;
using System.Threading;

namespace Amib.Threading
{
	// Token: 0x02000334 RID: 820
	public sealed class STPStartInfo : WIGStartInfo
	{
		// Token: 0x040012C9 RID: 4809
		private ApartmentState _apartmentState = ApartmentState.Unknown;

		// Token: 0x040012C5 RID: 4805
		private bool _areThreadsBackground = true;

		// Token: 0x040012C6 RID: 4806
		private bool _enableLocalPerformanceCounters;

		// Token: 0x040012C0 RID: 4800
		private int _idleTimeout = 60000;

		// Token: 0x040012C8 RID: 4808
		private int? _maxStackSize = SmartThreadPool.DefaultMaxStackSize;

		// Token: 0x040012C2 RID: 4802
		private int _maxWorkerThreads = 25;

		// Token: 0x040012C1 RID: 4801
		private int _minWorkerThreads;

		// Token: 0x040012C4 RID: 4804
		private string _performanceCounterInstanceName = SmartThreadPool.DefaultPerformanceCounterInstanceName;

		// Token: 0x040012C7 RID: 4807
		private string _threadPoolName = "SmartThreadPool";

		// Token: 0x040012C3 RID: 4803
		private ThreadPriority _threadPriority = ThreadPriority.Normal;

		// Token: 0x17000347 RID: 839
		public ApartmentState ApartmentState
		{
			// Token: 0x06001850 RID: 6224
			// RVA: 0x00014E02 File Offset: 0x00013002
			get
			{
				return this._apartmentState;
			}
		}

		// Token: 0x17000346 RID: 838
		public virtual bool AreThreadsBackground
		{
			// Token: 0x0600184D RID: 6221
			// RVA: 0x00014DEB File Offset: 0x00012FEB
			get
			{
				return this._areThreadsBackground;
			}
			// Token: 0x0600184E RID: 6222
			// RVA: 0x00014DF3 File Offset: 0x00012FF3
			set
			{
				base.ThrowIfReadOnly();
				this._areThreadsBackground = value;
			}
		}

		// Token: 0x17000345 RID: 837
		public virtual bool EnableLocalPerformanceCounters
		{
			// Token: 0x0600184C RID: 6220
			// RVA: 0x00014DE3 File Offset: 0x00012FE3
			get
			{
				return this._enableLocalPerformanceCounters;
			}
		}

		// Token: 0x1700033F RID: 831
		public virtual int IdleTimeout
		{
			// Token: 0x06001843 RID: 6211
			// RVA: 0x00014D86 File Offset: 0x00012F86
			get
			{
				return this._idleTimeout;
			}
			// Token: 0x06001844 RID: 6212
			// RVA: 0x00014D8E File Offset: 0x00012F8E
			set
			{
				base.ThrowIfReadOnly();
				this._idleTimeout = value;
			}
		}

		// Token: 0x17000348 RID: 840
		public int? MaxStackSize
		{
			// Token: 0x06001851 RID: 6225
			// RVA: 0x00014E0A File Offset: 0x0001300A
			get
			{
				return this._maxStackSize;
			}
		}

		// Token: 0x17000341 RID: 833
		public virtual int MaxWorkerThreads
		{
			// Token: 0x06001846 RID: 6214
			// RVA: 0x00014DA5 File Offset: 0x00012FA5
			get
			{
				return this._maxWorkerThreads;
			}
			// Token: 0x06001847 RID: 6215
			// RVA: 0x00014DAD File Offset: 0x00012FAD
			set
			{
				base.ThrowIfReadOnly();
				this._maxWorkerThreads = value;
			}
		}

		// Token: 0x17000340 RID: 832
		public virtual int MinWorkerThreads
		{
			// Token: 0x06001845 RID: 6213
			// RVA: 0x00014D9D File Offset: 0x00012F9D
			get
			{
				return this._minWorkerThreads;
			}
		}

		// Token: 0x17000344 RID: 836
		public virtual string PerformanceCounterInstanceName
		{
			// Token: 0x0600184B RID: 6219
			// RVA: 0x00014DDB File Offset: 0x00012FDB
			get
			{
				return this._performanceCounterInstanceName;
			}
		}

		// Token: 0x17000343 RID: 835
		public virtual string ThreadPoolName
		{
			// Token: 0x0600184A RID: 6218
			// RVA: 0x00014DD3 File Offset: 0x00012FD3
			get
			{
				return this._threadPoolName;
			}
		}

		// Token: 0x17000342 RID: 834
		public virtual ThreadPriority ThreadPriority
		{
			// Token: 0x06001848 RID: 6216
			// RVA: 0x00014DBC File Offset: 0x00012FBC
			get
			{
				return this._threadPriority;
			}
			// Token: 0x06001849 RID: 6217
			// RVA: 0x00014DC4 File Offset: 0x00012FC4
			set
			{
				base.ThrowIfReadOnly();
				this._threadPriority = value;
			}
		}

		// Token: 0x06001841 RID: 6209
		// RVA: 0x00074ED0 File Offset: 0x000730D0
		public STPStartInfo()
		{
			this._performanceCounterInstanceName = SmartThreadPool.DefaultPerformanceCounterInstanceName;
			this._threadPriority = ThreadPriority.Normal;
			this._maxWorkerThreads = 25;
			this._idleTimeout = 60000;
			this._minWorkerThreads = 0;
		}

		// Token: 0x06001842 RID: 6210
		// RVA: 0x00074F58 File Offset: 0x00073158
		public STPStartInfo(STPStartInfo stpstartInfo_0) : base(stpstartInfo_0)
		{
			this._idleTimeout = stpstartInfo_0.IdleTimeout;
			this._minWorkerThreads = stpstartInfo_0.MinWorkerThreads;
			this._maxWorkerThreads = stpstartInfo_0.MaxWorkerThreads;
			this._threadPriority = stpstartInfo_0.ThreadPriority;
			this._performanceCounterInstanceName = stpstartInfo_0.PerformanceCounterInstanceName;
			this._enableLocalPerformanceCounters = stpstartInfo_0._enableLocalPerformanceCounters;
			this._threadPoolName = stpstartInfo_0._threadPoolName;
			this._areThreadsBackground = stpstartInfo_0.AreThreadsBackground;
			this._apartmentState = stpstartInfo_0._apartmentState;
		}

		// Token: 0x0600184F RID: 6223
		// RVA: 0x00075024 File Offset: 0x00073224
		public STPStartInfo AsReadOnly()
		{
			return new STPStartInfo(this)
			{
				_readOnly = true
			};
		}
	}
}
