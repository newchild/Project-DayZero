using System;
using System.Diagnostics;
using System.Threading;

namespace Amib.Threading.Internal
{
	// Token: 0x02000310 RID: 784
	public sealed class WorkItem : IHasWorkItemPriority
	{
		// Token: 0x02000311 RID: 785
		private sealed class WorkItemResult : IWorkItemResult<object>, IWorkItemResult, IInternalWorkItemResult
		{
			// Token: 0x0400125B RID: 4699
			private readonly WorkItem _workItem;

			// Token: 0x14000010 RID: 16
			public event WorkItemStateCallback OnWorkItemCompleted
			{
				// Token: 0x0600179E RID: 6046
				// RVA: 0x000149FE File Offset: 0x00012BFE
				add
				{
					this._workItem.OnWorkItemCompleted += value;
				}
			}

			// Token: 0x1400000F RID: 15
			public event WorkItemStateCallback OnWorkItemStarted
			{
				// Token: 0x0600179D RID: 6045
				// RVA: 0x000149F0 File Offset: 0x00012BF0
				add
				{
					this._workItem.OnWorkItemStarted += value;
				}
			}

			// Token: 0x0600179B RID: 6043
			// RVA: 0x000149D3 File Offset: 0x00012BD3
			public WorkItemResult(WorkItem workItem_0)
			{
				this._workItem = workItem_0;
			}

			// Token: 0x0600179C RID: 6044
			// RVA: 0x000149E2 File Offset: 0x00012BE2
			public bool Cancel(bool bool_0)
			{
				return this._workItem.Cancel(bool_0);
			}
		}

		// Token: 0x02000312 RID: 786
		private enum WorkItemState
		{
			// Token: 0x0400125D RID: 4701
			InQueue,
			// Token: 0x0400125E RID: 4702
			InProgress,
			// Token: 0x0400125F RID: 4703
			Completed,
			// Token: 0x04001260 RID: 4704
			Canceled
		}

		// Token: 0x04001248 RID: 4680
		private readonly WorkItemCallback _callback;

		// Token: 0x0400124A RID: 4682
		private readonly CallerThreadContext _callerContext;

		// Token: 0x04001255 RID: 4693
		private CanceledWorkItemsGroup _canceledSmartThreadPool = CanceledWorkItemsGroup.NotCanceledWorkItemsGroup;

		// Token: 0x04001254 RID: 4692
		private CanceledWorkItemsGroup _canceledWorkItemsGroup = CanceledWorkItemsGroup.NotCanceledWorkItemsGroup;

		// Token: 0x0400124C RID: 4684
		private Exception _exception;

		// Token: 0x04001257 RID: 4695
		private Thread _executingThread;

		// Token: 0x04001258 RID: 4696
		private long _expirationTime;

		// Token: 0x0400125A RID: 4698
		private Stopwatch _processingStopwatch;

		// Token: 0x0400124B RID: 4683
		private object _result;

		// Token: 0x04001249 RID: 4681
		private object _state;

		// Token: 0x04001259 RID: 4697
		private Stopwatch _waitingOnQueueStopwatch;

		// Token: 0x0400124E RID: 4686
		private ManualResetEvent _workItemCompleted;

		// Token: 0x0400124F RID: 4687
		private int _workItemCompletedRefCount;

		// Token: 0x04001251 RID: 4689
		private readonly WorkItemInfo _workItemInfo;

		// Token: 0x04001250 RID: 4688
		private readonly WorkItem.WorkItemResult _workItemResult;

		// Token: 0x04001256 RID: 4694
		private readonly IWorkItemsGroup _workItemsGroup;

		// Token: 0x0400124D RID: 4685
		private WorkItem.WorkItemState _workItemState;

		// Token: 0x1400000E RID: 14
		internal event WorkItemStateCallback OnWorkItemCompleted
		{
			// Token: 0x06001799 RID: 6041
			// RVA: 0x000149CA File Offset: 0x00012BCA
			add
			{
				this._workItemCompletedEvent += value;
			}
		}

		// Token: 0x1400000D RID: 13
		internal event WorkItemStateCallback OnWorkItemStarted
		{
			// Token: 0x06001798 RID: 6040
			// RVA: 0x000149C1 File Offset: 0x00012BC1
			add
			{
				this._workItemStartedEvent += value;
			}
		}

		// Token: 0x1400000C RID: 12
		private event WorkItemStateCallback _workItemCompletedEvent
		{
			// Token: 0x0600177F RID: 6015
			// RVA: 0x000732CC File Offset: 0x000714CC
			add
			{
				WorkItemStateCallback workItemStateCallback = this._workItemCompletedEvent;
				WorkItemStateCallback workItemStateCallback2;
				do
				{
					workItemStateCallback2 = workItemStateCallback;
					WorkItemStateCallback value2 = (WorkItemStateCallback)Delegate.Combine(workItemStateCallback2, value);
					workItemStateCallback = Interlocked.CompareExchange<WorkItemStateCallback>(ref this._workItemCompletedEvent, value2, workItemStateCallback2);
				}
				while (workItemStateCallback != workItemStateCallback2);
			}
		}

		// Token: 0x1400000B RID: 11
		private event WorkItemStateCallback _workItemStartedEvent
		{
			// Token: 0x0600177E RID: 6014
			// RVA: 0x00073294 File Offset: 0x00071494
			add
			{
				WorkItemStateCallback workItemStateCallback = this._workItemStartedEvent;
				WorkItemStateCallback workItemStateCallback2;
				do
				{
					workItemStateCallback2 = workItemStateCallback;
					WorkItemStateCallback value2 = (WorkItemStateCallback)Delegate.Combine(workItemStateCallback2, value);
					workItemStateCallback = Interlocked.CompareExchange<WorkItemStateCallback>(ref this._workItemStartedEvent, value2, workItemStateCallback2);
				}
				while (workItemStateCallback != workItemStateCallback2);
			}
		}

		// Token: 0x17000324 RID: 804
		internal CanceledWorkItemsGroup CanceledSmartThreadPool
		{
			// Token: 0x06001787 RID: 6023
			// RVA: 0x00014977 File Offset: 0x00012B77
			get
			{
				return this._canceledSmartThreadPool;
			}
			// Token: 0x06001788 RID: 6024
			// RVA: 0x0001497F File Offset: 0x00012B7F
			set
			{
				this._canceledSmartThreadPool = value;
			}
		}

		// Token: 0x17000323 RID: 803
		internal CanceledWorkItemsGroup CanceledWorkItemsGroup
		{
			// Token: 0x06001785 RID: 6021
			// RVA: 0x00014966 File Offset: 0x00012B66
			get
			{
				return this._canceledWorkItemsGroup;
			}
			// Token: 0x06001786 RID: 6022
			// RVA: 0x0001496E File Offset: 0x00012B6E
			set
			{
				this._canceledWorkItemsGroup = value;
			}
		}

		// Token: 0x17000325 RID: 805
		public bool IsCanceled
		{
			// Token: 0x06001796 RID: 6038
			// RVA: 0x00073884 File Offset: 0x00071A84
			get
			{
				bool result;
				lock (this)
				{
					result = (this.GetWorkItemState() == WorkItem.WorkItemState.Canceled);
				}
				return result;
			}
		}

		// Token: 0x17000322 RID: 802
		public TimeSpan ProcessTime
		{
			// Token: 0x06001781 RID: 6017
			// RVA: 0x0001494E File Offset: 0x00012B4E
			get
			{
				return this._processingStopwatch.Elapsed;
			}
		}

		// Token: 0x17000321 RID: 801
		public TimeSpan WaitingTime
		{
			// Token: 0x06001780 RID: 6016
			// RVA: 0x00014941 File Offset: 0x00012B41
			get
			{
				return this._waitingOnQueueStopwatch.Elapsed;
			}
		}

		// Token: 0x17000320 RID: 800
		public WorkItemPriority WorkItemPriority
		{
			// Token: 0x06001797 RID: 6039
			// RVA: 0x000149B4 File Offset: 0x00012BB4
			get
			{
				return this._workItemInfo.WorkItemPriority;
			}
		}

		// Token: 0x06001782 RID: 6018
		// RVA: 0x00073304 File Offset: 0x00071504
		public WorkItem(IWorkItemsGroup iworkItemsGroup_0, WorkItemInfo workItemInfo_0, WorkItemCallback workItemCallback_0, object object_0)
		{
			this._workItemsGroup = iworkItemsGroup_0;
			this._workItemInfo = workItemInfo_0;
			if (this._workItemInfo.UseCallerCallContext || this._workItemInfo.UseCallerHttpContext)
			{
				this._callerContext = CallerThreadContext.Capture(this._workItemInfo.UseCallerCallContext, this._workItemInfo.UseCallerHttpContext);
			}
			this._callback = workItemCallback_0;
			this._state = object_0;
			this._workItemResult = new WorkItem.WorkItemResult(this);
			this.Initialize();
		}

		// Token: 0x06001795 RID: 6037
		// RVA: 0x000737D0 File Offset: 0x000719D0
		private bool Cancel(bool bool_0)
		{
			bool result = false;
			bool flag = false;
			lock (this)
			{
				switch (this.GetWorkItemState())
				{
				case WorkItem.WorkItemState.InQueue:
					flag = true;
					result = true;
					break;
				case WorkItem.WorkItemState.InProgress:
					if (bool_0)
					{
						Thread thread = Interlocked.CompareExchange<Thread>(ref this._executingThread, null, this._executingThread);
						if (thread != null)
						{
							thread.Abort();
							result = true;
							flag = true;
						}
					}
					else
					{
						result = true;
						flag = true;
					}
					break;
				case WorkItem.WorkItemState.Canceled:
					if (bool_0)
					{
						Thread thread2 = Interlocked.CompareExchange<Thread>(ref this._executingThread, null, this._executingThread);
						if (thread2 != null)
						{
							thread2.Abort();
						}
					}
					result = true;
					break;
				}
				if (flag)
				{
					this.SignalComplete(true);
				}
			}
			return result;
		}

		// Token: 0x0600179A RID: 6042
		// RVA: 0x000738C0 File Offset: 0x00071AC0
		public void DisposeOfState()
		{
			if (this._workItemInfo.DisposeOfStateObjects)
			{
				IDisposable disposable = this._state as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
					this._state = null;
				}
			}
		}

		// Token: 0x0600178A RID: 6026
		// RVA: 0x000734A4 File Offset: 0x000716A4
		public void Execute()
		{
			CallToPostExecute callToPostExecute = CallToPostExecute.Never;
			switch (this.GetWorkItemState())
			{
			case WorkItem.WorkItemState.InProgress:
				callToPostExecute |= CallToPostExecute.WhenWorkItemNotCanceled;
				this.ExecuteWorkItem();
				goto IL_35;
			case WorkItem.WorkItemState.Canceled:
				callToPostExecute |= CallToPostExecute.WhenWorkItemCanceled;
				goto IL_35;
			}
			throw new NotSupportedException();
			IL_35:
			if ((callToPostExecute & this._workItemInfo.CallToPostExecute) != CallToPostExecute.Never)
			{
				this.PostExecute();
			}
			this._processingStopwatch.Stop();
		}

		// Token: 0x0600178D RID: 6029
		// RVA: 0x00073578 File Offset: 0x00071778
		private void ExecuteWorkItem()
		{
			CallerThreadContext callerThreadContext_ = null;
			if (this._callerContext != null)
			{
				callerThreadContext_ = CallerThreadContext.Capture(this._callerContext.CapturedCallContext, this._callerContext.CapturedHttpContext);
				CallerThreadContext.Apply(this._callerContext);
			}
			Exception exception_ = null;
			object object_ = null;
			try
			{
				try
				{
					object_ = this._callback(this._state);
				}
				catch (Exception ex)
				{
					exception_ = ex;
				}
				if (Interlocked.CompareExchange<Thread>(ref this._executingThread, null, this._executingThread) == null)
				{
					Thread.Sleep(60000);
				}
			}
			catch (ThreadAbortException ex2)
			{
				ex2.GetHashCode();
				if (!SmartThreadPool.CurrentThreadEntry.AssociatedSmartThreadPool.IsShuttingdown)
				{
					Thread.ResetAbort();
				}
			}
			if (this._callerContext != null)
			{
				CallerThreadContext.Apply(callerThreadContext_);
			}
			if (!SmartThreadPool.IsWorkItemCanceled)
			{
				this.SetResult(object_, exception_);
			}
		}

		// Token: 0x0600178B RID: 6027
		// RVA: 0x00073508 File Offset: 0x00071708
		internal void FireWorkItemCompleted()
		{
			try
			{
				if (this._workItemCompletedEvent != null)
				{
					this._workItemCompletedEvent(this);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600178C RID: 6028
		// RVA: 0x00073540 File Offset: 0x00071740
		internal void FireWorkItemStarted()
		{
			try
			{
				if (this._workItemStartedEvent != null)
				{
					this._workItemStartedEvent(this);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001790 RID: 6032
		// RVA: 0x0001499F File Offset: 0x00012B9F
		internal IWorkItemResult GetWorkItemResult()
		{
			return this._workItemResult;
		}

		// Token: 0x06001791 RID: 6033
		// RVA: 0x0007369C File Offset: 0x0007189C
		private WorkItem.WorkItemState GetWorkItemState()
		{
			WorkItem.WorkItemState result;
			lock (this)
			{
				if (WorkItem.WorkItemState.Completed == this._workItemState)
				{
					result = this._workItemState;
				}
				else
				{
					long ticks = DateTime.UtcNow.Ticks;
					if (WorkItem.WorkItemState.Canceled != this._workItemState && ticks > this._expirationTime)
					{
						this._workItemState = WorkItem.WorkItemState.Canceled;
					}
					if (WorkItem.WorkItemState.InProgress == this._workItemState)
					{
						result = this._workItemState;
					}
					else if (!this.CanceledSmartThreadPool.IsCanceled && !this.CanceledWorkItemsGroup.IsCanceled)
					{
						result = this._workItemState;
					}
					else
					{
						result = WorkItem.WorkItemState.Canceled;
					}
				}
			}
			return result;
		}

		// Token: 0x06001783 RID: 6019
		// RVA: 0x00073398 File Offset: 0x00071598
		internal void Initialize()
		{
			this._workItemState = WorkItem.WorkItemState.InQueue;
			this._workItemCompleted = null;
			this._workItemCompletedRefCount = 0;
			this._waitingOnQueueStopwatch = new Stopwatch();
			this._processingStopwatch = new Stopwatch();
			this._expirationTime = ((this._workItemInfo.Timeout > 0L) ? (DateTime.UtcNow.Ticks + this._workItemInfo.Timeout * 10000L) : 9223372036854775807L);
		}

		// Token: 0x0600177D RID: 6013
		// RVA: 0x00073250 File Offset: 0x00071450
		private static bool IsValidStatesTransition(WorkItem.WorkItemState workItemState_0, WorkItem.WorkItemState workItemState_1)
		{
			bool result = false;
			switch (workItemState_0)
			{
			case WorkItem.WorkItemState.InQueue:
				result = (WorkItem.WorkItemState.InProgress == workItemState_1 || WorkItem.WorkItemState.Canceled == workItemState_1);
				break;
			case WorkItem.WorkItemState.InProgress:
				result = (WorkItem.WorkItemState.Completed == workItemState_1 || WorkItem.WorkItemState.Canceled == workItemState_1);
				break;
			}
			return result;
		}

		// Token: 0x0600178E RID: 6030
		// RVA: 0x00073654 File Offset: 0x00071854
		private void PostExecute()
		{
			if (this._workItemInfo.PostExecuteWorkItemCallback != null)
			{
				try
				{
					this._workItemInfo.PostExecuteWorkItemCallback(this._workItemResult);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600178F RID: 6031
		// RVA: 0x00014988 File Offset: 0x00012B88
		internal void SetResult(object object_0, Exception exception_0)
		{
			this._result = object_0;
			this._exception = exception_0;
			this.SignalComplete(false);
		}

		// Token: 0x06001792 RID: 6034
		// RVA: 0x0007373C File Offset: 0x0007193C
		private void SetWorkItemState(WorkItem.WorkItemState workItemState_0)
		{
			lock (this)
			{
				if (WorkItem.IsValidStatesTransition(this._workItemState, workItemState_0))
				{
					this._workItemState = workItemState_0;
				}
			}
		}

		// Token: 0x06001793 RID: 6035
		// RVA: 0x00073780 File Offset: 0x00071980
		private void SignalComplete(bool bool_0)
		{
			this.SetWorkItemState(bool_0 ? WorkItem.WorkItemState.Canceled : WorkItem.WorkItemState.Completed);
			lock (this)
			{
				if (this._workItemCompleted != null)
				{
					this._workItemCompleted.Set();
				}
			}
		}

		// Token: 0x06001789 RID: 6025
		// RVA: 0x0007341C File Offset: 0x0007161C
		public bool StartingWorkItem()
		{
			this._waitingOnQueueStopwatch.Stop();
			this._processingStopwatch.Start();
			lock (this)
			{
				if (this.IsCanceled)
				{
					bool result = false;
					if (this._workItemInfo.PostExecuteWorkItemCallback != null && (this._workItemInfo.CallToPostExecute & CallToPostExecute.WhenWorkItemCanceled) == CallToPostExecute.WhenWorkItemCanceled)
					{
						result = true;
					}
					return result;
				}
				this._executingThread = Thread.CurrentThread;
				this.SetWorkItemState(WorkItem.WorkItemState.InProgress);
			}
			return true;
		}

		// Token: 0x06001784 RID: 6020
		// RVA: 0x0001495B File Offset: 0x00012B5B
		internal bool WasQueuedBy(IWorkItemsGroup iworkItemsGroup_0)
		{
			return iworkItemsGroup_0 == this._workItemsGroup;
		}

		// Token: 0x06001794 RID: 6036
		// RVA: 0x000149A7 File Offset: 0x00012BA7
		internal void WorkItemIsQueued()
		{
			this._waitingOnQueueStopwatch.Start();
		}
	}
}
