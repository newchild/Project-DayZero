using Amib.Threading.Internal;
using System;
using System.Collections;
using System.Diagnostics;
using System.Security;
using System.Threading;

namespace Amib.Threading
{
	// Token: 0x02000327 RID: 807
	public sealed class SmartThreadPool : WorkItemsGroupBase, IDisposable
	{
		// Token: 0x02000328 RID: 808
		internal sealed class ThreadEntry
		{
			// Token: 0x04001295 RID: 4757
			private readonly SmartThreadPool _associatedSmartThreadPool;

			// Token: 0x04001293 RID: 4755
			private readonly DateTime _creationTime;

			// Token: 0x04001294 RID: 4756
			private DateTime _lastAliveTime;

			// Token: 0x17000333 RID: 819
			public SmartThreadPool AssociatedSmartThreadPool
			{
				// Token: 0x06001804 RID: 6148
				// RVA: 0x00014B9B File Offset: 0x00012D9B
				get
				{
					return this._associatedSmartThreadPool;
				}
			}

			// Token: 0x17000332 RID: 818
			public WorkItem CurrentWorkItem
			{
				// Token: 0x06001801 RID: 6145
				// RVA: 0x00014B65 File Offset: 0x00012D65
				get;
				// Token: 0x06001802 RID: 6146
				// RVA: 0x00014B6D File Offset: 0x00012D6D
				set;
			}

			// Token: 0x06001803 RID: 6147
			// RVA: 0x00014B76 File Offset: 0x00012D76
			public ThreadEntry(SmartThreadPool smartThreadPool_0)
			{
				this._associatedSmartThreadPool = smartThreadPool_0;
				this._creationTime = DateTime.UtcNow;
				this._lastAliveTime = DateTime.MinValue;
			}

			// Token: 0x06001805 RID: 6149
			// RVA: 0x00014BA3 File Offset: 0x00012DA3
			public void IAmAlive()
			{
				this._lastAliveTime = DateTime.UtcNow;
			}
		}

		// Token: 0x0400127F RID: 4735
		public static readonly int? DefaultMaxStackSize = null;

		// Token: 0x0400127E RID: 4734
		public static readonly string DefaultPerformanceCounterInstanceName;

		// Token: 0x0400127D RID: 4733
		public static readonly PostExecuteWorkItemCallback DefaultPostExecuteWorkItemCallback;

		// Token: 0x0400128D RID: 4749
		private CanceledWorkItemsGroup _canceledSmartThreadPool = new CanceledWorkItemsGroup();

		// Token: 0x04001285 RID: 4741
		private int _currentWorkItemsCount;

		// Token: 0x04001283 RID: 4739
		private int _inUseWorkerThreads;

		// Token: 0x0400128B RID: 4747
		private bool _isDisposed;

		// Token: 0x04001286 RID: 4742
		private ManualResetEvent _isIdleWaitHandle = EventWaitHandleFactory.CreateManualResetEvent(true);

		// Token: 0x04001288 RID: 4744
		private bool _isSuspended;

		// Token: 0x0400128F RID: 4751
		private ISTPInstancePerformanceCounters _localPCs = NullSTPInstancePerformanceCounters.Instance;

		// Token: 0x04001291 RID: 4753
		private ThreadInitializationHandler _onThreadInitialization;

		// Token: 0x04001292 RID: 4754
		private ThreadTerminationHandler _onThreadTermination;

		// Token: 0x04001289 RID: 4745
		private bool _shutdown;

		// Token: 0x04001287 RID: 4743
		private ManualResetEvent _shuttingDownEvent = EventWaitHandleFactory.CreateManualResetEvent(false);

		// Token: 0x04001284 RID: 4740
		private STPStartInfo _stpStartInfo;

		// Token: 0x0400128A RID: 4746
		private int _threadCounter;

		// Token: 0x04001290 RID: 4752
		[ThreadStatic]
		private static SmartThreadPool.ThreadEntry _threadEntry;

		// Token: 0x0400128E RID: 4750
		private ISTPInstancePerformanceCounters _windowsPCs = NullSTPInstancePerformanceCounters.Instance;

		// Token: 0x04001280 RID: 4736
		private readonly SynchronizedDictionary<Thread, SmartThreadPool.ThreadEntry> _workerThreads = new SynchronizedDictionary<Thread, SmartThreadPool.ThreadEntry>();

		// Token: 0x0400128C RID: 4748
		private readonly SynchronizedDictionary<IWorkItemsGroup, IWorkItemsGroup> _workItemsGroups = new SynchronizedDictionary<IWorkItemsGroup, IWorkItemsGroup>();

		// Token: 0x04001282 RID: 4738
		private int _workItemsProcessed;

		// Token: 0x04001281 RID: 4737
		private readonly WorkItemsQueue _workItemsQueue = new WorkItemsQueue();

		// Token: 0x1700032F RID: 815
		internal static SmartThreadPool.ThreadEntry CurrentThreadEntry
		{
			// Token: 0x060017E4 RID: 6116
			// RVA: 0x00014AC6 File Offset: 0x00012CC6
			get
			{
				return SmartThreadPool._threadEntry;
			}
			// Token: 0x060017E5 RID: 6117
			// RVA: 0x00014ACD File Offset: 0x00012CCD
			set
			{
				SmartThreadPool._threadEntry = value;
			}
		}

		// Token: 0x17000331 RID: 817
		public bool IsShuttingdown
		{
			// Token: 0x060017FA RID: 6138
			// RVA: 0x00014B1B File Offset: 0x00012D1B
			get
			{
				return this._shutdown;
			}
		}

		// Token: 0x17000330 RID: 816
		public static bool IsWorkItemCanceled
		{
			// Token: 0x060017F9 RID: 6137
			// RVA: 0x00014B0A File Offset: 0x00012D0A
			get
			{
				return SmartThreadPool.CurrentThreadEntry.CurrentWorkItem.IsCanceled;
			}
		}

		// Token: 0x1700032E RID: 814
		public override WIGStartInfo WIGStartInfo
		{
			// Token: 0x060017FD RID: 6141
			// RVA: 0x00014B43 File Offset: 0x00012D43
			get
			{
				return this._stpStartInfo.AsReadOnly();
			}
		}

		// Token: 0x060017E6 RID: 6118
		// RVA: 0x00073DBC File Offset: 0x00071FBC
		public SmartThreadPool(STPStartInfo stpstartInfo_0)
		{
			this._stpStartInfo = new STPStartInfo(stpstartInfo_0);
			this.Initialize();
		}

		// Token: 0x060017FE RID: 6142
		// RVA: 0x00074960 File Offset: 0x00072B60
		public override void Cancel(bool bool_0)
		{
			this._canceledSmartThreadPool.IsCanceled = true;
			this._canceledSmartThreadPool = new CanceledWorkItemsGroup();
			ICollection values = this._workItemsGroups.Values;
			foreach (WorkItemsGroup workItemsGroup in values)
			{
				workItemsGroup.Cancel(bool_0);
			}
			if (bool_0)
			{
				foreach (SmartThreadPool.ThreadEntry current in this._workerThreads.Values)
				{
					WorkItem currentWorkItem = current.CurrentWorkItem;
					if (currentWorkItem != null && current.AssociatedSmartThreadPool == this && !currentWorkItem.IsCanceled)
					{
						current.CurrentWorkItem.GetWorkItemResult().Cancel(true);
					}
				}
			}
		}

		// Token: 0x060017F8 RID: 6136
		// RVA: 0x00074874 File Offset: 0x00072A74
		internal void CancelAbortWorkItemsGroup(WorkItemsGroup workItemsGroup_0)
		{
			foreach (SmartThreadPool.ThreadEntry current in this._workerThreads.Values)
			{
				WorkItem currentWorkItem = current.CurrentWorkItem;
				if (currentWorkItem != null && currentWorkItem.WasQueuedBy(workItemsGroup_0) && !currentWorkItem.IsCanceled)
				{
					current.CurrentWorkItem.GetWorkItemResult().Cancel(true);
				}
			}
		}

		// Token: 0x060017ED RID: 6125
		// RVA: 0x00074088 File Offset: 0x00072288
		private void DecrementWorkItemsCount()
		{
			if (Interlocked.Decrement(ref this._currentWorkItemsCount) == 0)
			{
				base.IsIdle = true;
				this._isIdleWaitHandle.Set();
			}
			Interlocked.Increment(ref this._workItemsProcessed);
			if (!this._shutdown)
			{
				this._windowsPCs.SampleWorkItems((long)this._workItemsQueue.Count, (long)this._workItemsProcessed);
				this._localPCs.SampleWorkItems((long)this._workItemsQueue.Count, (long)this._workItemsProcessed);
			}
		}

		// Token: 0x060017EA RID: 6122
		// RVA: 0x00073FA4 File Offset: 0x000721A4
		private WorkItem Dequeue()
		{
			return this._workItemsQueue.DequeueWorkItem(this._stpStartInfo.IdleTimeout, this._shuttingDownEvent);
		}

		// Token: 0x060017FB RID: 6139
		// RVA: 0x000748F4 File Offset: 0x00072AF4
		public void Dispose()
		{
			if (!this._isDisposed)
			{
				if (!this._shutdown)
				{
					this.Shutdown();
				}
				if (this._shuttingDownEvent != null)
				{
					this._shuttingDownEvent.Close();
					this._shuttingDownEvent = null;
				}
				this._workerThreads.Clear();
				if (this._isIdleWaitHandle != null)
				{
					this._isIdleWaitHandle.Close();
					this._isIdleWaitHandle = null;
				}
				this._isDisposed = true;
			}
		}

		// Token: 0x060017EB RID: 6123
		// RVA: 0x00073FD0 File Offset: 0x000721D0
		internal override void Enqueue(WorkItem workItem_0)
		{
			this.IncrementWorkItemsCount();
			workItem_0.CanceledSmartThreadPool = this._canceledSmartThreadPool;
			this._workItemsQueue.EnqueueWorkItem(workItem_0);
			workItem_0.WorkItemIsQueued();
			if (this._currentWorkItemsCount > this._workerThreads.Count)
			{
				this.StartThreads(1);
			}
		}

		// Token: 0x060017F3 RID: 6131
		// RVA: 0x000745E8 File Offset: 0x000727E8
		private void ExecuteWorkItem(WorkItem workItem_0)
		{
			this._windowsPCs.SampleWorkItemsWaitTime(workItem_0.WaitingTime);
			this._localPCs.SampleWorkItemsWaitTime(workItem_0.WaitingTime);
			try
			{
				workItem_0.Execute();
			}
			finally
			{
				this._windowsPCs.SampleWorkItemsProcessTime(workItem_0.ProcessTime);
				this._localPCs.SampleWorkItemsProcessTime(workItem_0.ProcessTime);
			}
		}

		// Token: 0x060017F6 RID: 6134
		// RVA: 0x000747BC File Offset: 0x000729BC
		private void FireOnThreadInitialization()
		{
			if (this._onThreadInitialization != null)
			{
				Delegate[] invocationList = this._onThreadInitialization.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					ThreadInitializationHandler threadInitializationHandler = (ThreadInitializationHandler)invocationList[i];
					try
					{
						threadInitializationHandler();
					}
					catch (Exception ex)
					{
						ex.GetHashCode();
						throw;
					}
				}
			}
		}

		// Token: 0x060017F7 RID: 6135
		// RVA: 0x00074818 File Offset: 0x00072A18
		private void FireOnThreadTermination()
		{
			if (this._onThreadTermination != null)
			{
				Delegate[] invocationList = this._onThreadTermination.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					ThreadTerminationHandler threadTerminationHandler = (ThreadTerminationHandler)invocationList[i];
					try
					{
						threadTerminationHandler();
					}
					catch (Exception ex)
					{
						ex.GetHashCode();
						throw;
					}
				}
			}
		}

		// Token: 0x060017EC RID: 6124
		// RVA: 0x0007401C File Offset: 0x0007221C
		private void IncrementWorkItemsCount()
		{
			this._windowsPCs.SampleWorkItems((long)this._workItemsQueue.Count, (long)this._workItemsProcessed);
			this._localPCs.SampleWorkItems((long)this._workItemsQueue.Count, (long)this._workItemsProcessed);
			int num = Interlocked.Increment(ref this._currentWorkItemsCount);
			if (num == 1)
			{
				base.IsIdle = false;
				this._isIdleWaitHandle.Reset();
			}
		}

		// Token: 0x060017F0 RID: 6128
		// RVA: 0x00074108 File Offset: 0x00072308
		private void InformCompleted()
		{
			if (this._workerThreads.Contains(Thread.CurrentThread))
			{
				this._workerThreads.Remove(Thread.CurrentThread);
				this._windowsPCs.SampleThreads((long)this._workerThreads.Count, (long)this._inUseWorkerThreads);
				this._localPCs.SampleThreads((long)this._workerThreads.Count, (long)this._inUseWorkerThreads);
			}
		}

		// Token: 0x060017E7 RID: 6119
		// RVA: 0x00073E3C File Offset: 0x0007203C
		private void Initialize()
		{
			base.Name = this._stpStartInfo.ThreadPoolName;
			this.ValidateSTPStartInfo();
			this._isSuspended = this._stpStartInfo.StartSuspended;
			if (this._stpStartInfo.PerformanceCounterInstanceName != null)
			{
				try
				{
					this._windowsPCs = new STPInstancePerformanceCounters(this._stpStartInfo.PerformanceCounterInstanceName);
				}
				catch (Exception)
				{
					this._windowsPCs = NullSTPInstancePerformanceCounters.Instance;
				}
			}
			if (this._stpStartInfo.EnableLocalPerformanceCounters)
			{
				this._localPCs = new LocalSTPInstancePerformanceCounters();
			}
			if (!this._isSuspended)
			{
				this.StartOptimalNumberOfThreads();
			}
		}

		// Token: 0x060017FF RID: 6143
		// RVA: 0x00014B50 File Offset: 0x00012D50
		internal override void PreQueueWorkItem()
		{
			this.ValidateNotDisposed();
		}

		// Token: 0x060017F2 RID: 6130
		// RVA: 0x00074330 File Offset: 0x00072530
		private void ProcessQueuedItems()
		{
			SmartThreadPool.CurrentThreadEntry = this._workerThreads[Thread.CurrentThread];
			this.FireOnThreadInitialization();
			try
			{
				bool flag = false;
				while (!this._shutdown)
				{
					SmartThreadPool.CurrentThreadEntry.IAmAlive();
					if (this._workerThreads.Count > this._stpStartInfo.MaxWorkerThreads)
					{
						lock (this._workerThreads.SyncRoot)
						{
							if (this._workerThreads.Count > this._stpStartInfo.MaxWorkerThreads)
							{
								this.InformCompleted();
								break;
							}
						}
					}
					WorkItem workItem = this.Dequeue();
					SmartThreadPool.CurrentThreadEntry.IAmAlive();
					if (workItem == null && this._workerThreads.Count > this._stpStartInfo.MinWorkerThreads)
					{
						lock (this._workerThreads.SyncRoot)
						{
							if (this._workerThreads.Count > this._stpStartInfo.MinWorkerThreads)
							{
								this.InformCompleted();
								break;
							}
						}
					}
					if (workItem != null)
					{
						try
						{
							flag = false;
							SmartThreadPool.CurrentThreadEntry.CurrentWorkItem = workItem;
							if (workItem.StartingWorkItem())
							{
								int num = Interlocked.Increment(ref this._inUseWorkerThreads);
								this._windowsPCs.SampleThreads((long)this._workerThreads.Count, (long)num);
								this._localPCs.SampleThreads((long)this._workerThreads.Count, (long)num);
								flag = true;
								workItem.FireWorkItemStarted();
								this.ExecuteWorkItem(workItem);
							}
						}
						catch (Exception ex)
						{
							ex.GetHashCode();
						}
						finally
						{
							workItem.DisposeOfState();
							SmartThreadPool.CurrentThreadEntry.CurrentWorkItem = null;
							if (flag)
							{
								int num2 = Interlocked.Decrement(ref this._inUseWorkerThreads);
								this._windowsPCs.SampleThreads((long)this._workerThreads.Count, (long)num2);
								this._localPCs.SampleThreads((long)this._workerThreads.Count, (long)num2);
							}
							workItem.FireWorkItemCompleted();
							this.DecrementWorkItemsCount();
						}
					}
				}
			}
			catch (ThreadAbortException ex2)
			{
				ex2.GetHashCode();
				Thread.ResetAbort();
			}
			catch (Exception)
			{
			}
			finally
			{
				this.InformCompleted();
				this.FireOnThreadTermination();
			}
		}

		// Token: 0x060017EE RID: 6126
		// RVA: 0x00014AD5 File Offset: 0x00012CD5
		internal void RegisterWorkItemsGroup(IWorkItemsGroup iworkItemsGroup_0)
		{
			this._workItemsGroups[iworkItemsGroup_0] = iworkItemsGroup_0;
		}

		// Token: 0x060017F4 RID: 6132
		// RVA: 0x00014B00 File Offset: 0x00012D00
		public void Shutdown()
		{
			this.Shutdown(true, 0);
		}

		// Token: 0x060017F5 RID: 6133
		// RVA: 0x00074654 File Offset: 0x00072854
		public void Shutdown(bool bool_0, int int_0)
		{
			this.ValidateNotDisposed();
			ISTPInstancePerformanceCounters windowsPCs = this._windowsPCs;
			if (NullSTPInstancePerformanceCounters.Instance != this._windowsPCs)
			{
				this._windowsPCs = NullSTPInstancePerformanceCounters.Instance;
				windowsPCs.Dispose();
			}
			Thread[] array;
			lock (this._workerThreads.SyncRoot)
			{
				this._workItemsQueue.Dispose();
				this._shutdown = true;
				this._shuttingDownEvent.Set();
				array = new Thread[this._workerThreads.Count];
				this._workerThreads.Keys.CopyTo(array, 0);
			}
			int num = int_0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			bool flag = -1 == int_0;
			bool flag2 = false;
			Thread[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				Thread thread = array2[i];
				if (flag || num >= 0)
				{
					if (thread.Join(num))
					{
						if (!flag)
						{
							num = int_0 - (int)stopwatch.ElapsedMilliseconds;
						}
						i++;
						continue;
					}
					flag2 = true;
				}
				else
				{
					flag2 = true;
				}
				IL_E1:
				if (flag2 && bool_0)
				{
					Thread[] array3 = array;
					for (int j = 0; j < array3.Length; j++)
					{
						Thread thread2 = array3[j];
						if (thread2 != null && thread2.IsAlive)
						{
							try
							{
								thread2.Abort();
							}
							catch (SecurityException ex)
							{
								ex.GetHashCode();
							}
							catch (ThreadStateException ex2)
							{
								ex2.GetHashCode();
							}
						}
					}
				}
				return;
			}
			goto IL_E1;
		}

		// Token: 0x060017E8 RID: 6120
		// RVA: 0x00073EDC File Offset: 0x000720DC
		private void StartOptimalNumberOfThreads()
		{
			int num = Math.Max(this._workItemsQueue.Count, this._stpStartInfo.MinWorkerThreads);
			num = Math.Min(num, this._stpStartInfo.MaxWorkerThreads);
			num -= this._workerThreads.Count;
			if (num > 0)
			{
				this.StartThreads(num);
			}
		}

		// Token: 0x060017F1 RID: 6129
		// RVA: 0x00074174 File Offset: 0x00072374
		private void StartThreads(int int_0)
		{
			if (this._isSuspended)
			{
				return;
			}
			lock (this._workerThreads.SyncRoot)
			{
				if (!this._shutdown)
				{
					for (int i = 0; i < int_0; i++)
					{
						if (this._workerThreads.Count >= this._stpStartInfo.MaxWorkerThreads)
						{
							break;
						}
						Thread thread = this._stpStartInfo.MaxStackSize.HasValue ? new Thread(new ThreadStart(this.ProcessQueuedItems), this._stpStartInfo.MaxStackSize.Value) : new Thread(new ThreadStart(this.ProcessQueuedItems));
						thread.Name = string.Concat(new object[]
						{
							"STP ",
							base.Name,
							" Thread #",
							this._threadCounter
						});
						thread.IsBackground = this._stpStartInfo.AreThreadsBackground;
						if (this._stpStartInfo.ApartmentState != ApartmentState.Unknown)
						{
							thread.SetApartmentState(this._stpStartInfo.ApartmentState);
						}
						thread.Priority = this._stpStartInfo.ThreadPriority;
						thread.Start();
						this._threadCounter++;
						this._workerThreads[thread] = new SmartThreadPool.ThreadEntry(this);
						this._windowsPCs.SampleThreads((long)this._workerThreads.Count, (long)this._inUseWorkerThreads);
						this._localPCs.SampleThreads((long)this._workerThreads.Count, (long)this._inUseWorkerThreads);
					}
				}
			}
		}

		// Token: 0x060017EF RID: 6127
		// RVA: 0x00014AE4 File Offset: 0x00012CE4
		internal void UnregisterWorkItemsGroup(IWorkItemsGroup iworkItemsGroup_0)
		{
			if (this._workItemsGroups.Contains(iworkItemsGroup_0))
			{
				this._workItemsGroups.Remove(iworkItemsGroup_0);
			}
		}

		// Token: 0x060017FC RID: 6140
		// RVA: 0x00014B23 File Offset: 0x00012D23
		private void ValidateNotDisposed()
		{
			if (this._isDisposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString(), "The SmartThreadPool has been shutdown");
			}
		}

		// Token: 0x060017E9 RID: 6121
		// RVA: 0x00073F30 File Offset: 0x00072130
		private void ValidateSTPStartInfo()
		{
			if (this._stpStartInfo.MinWorkerThreads < 0)
			{
				throw new ArgumentOutOfRangeException("MinWorkerThreads", "MinWorkerThreads cannot be negative");
			}
			if (this._stpStartInfo.MaxWorkerThreads <= 0)
			{
				throw new ArgumentOutOfRangeException("MaxWorkerThreads", "MaxWorkerThreads must be greater than zero");
			}
			if (this._stpStartInfo.MinWorkerThreads > this._stpStartInfo.MaxWorkerThreads)
			{
				throw new ArgumentOutOfRangeException("MinWorkerThreads, maxWorkerThreads", "MaxWorkerThreads must be greater or equal to MinWorkerThreads");
			}
		}
	}
}
