using System;
using System.Threading;

namespace Amib.Threading.Internal
{
	// Token: 0x02000339 RID: 825
	public sealed class WorkItemsGroup : WorkItemsGroupBase
	{
		// Token: 0x040012DE RID: 4830
		private CanceledWorkItemsGroup _canceledWorkItemsGroup;

		// Token: 0x040012D8 RID: 4824
		private int _concurrency;

		// Token: 0x040012DD RID: 4829
		private readonly ManualResetEvent _isIdleWaitHandle;

		// Token: 0x040012D7 RID: 4823
		private bool _isSuspended;

		// Token: 0x040012D4 RID: 4820
		private readonly object _lock;

		// Token: 0x040012D6 RID: 4822
		private WorkItemsGroupIdleHandler _onIdle;

		// Token: 0x040012D5 RID: 4821
		private readonly SmartThreadPool _stp;

		// Token: 0x040012DB RID: 4827
		private int _workItemsExecutingInStp;

		// Token: 0x040012DC RID: 4828
		private readonly WIGStartInfo _workItemsGroupStartInfo;

		// Token: 0x040012DA RID: 4826
		private int _workItemsInStpQueue;

		// Token: 0x040012D9 RID: 4825
		private readonly PriorityQueue _workItemsQueue;

		// Token: 0x17000355 RID: 853
		public override WIGStartInfo WIGStartInfo
		{
			// Token: 0x06001871 RID: 6257
			// RVA: 0x00014F38 File Offset: 0x00013138
			get
			{
				return this._workItemsGroupStartInfo;
			}
		}

		// Token: 0x06001872 RID: 6258
		// RVA: 0x000752DC File Offset: 0x000734DC
		public override void Cancel(bool bool_0)
		{
			lock (this._lock)
			{
				this._canceledWorkItemsGroup.IsCanceled = true;
				this._workItemsQueue.Clear();
				this._workItemsInStpQueue = 0;
				this._canceledWorkItemsGroup = new CanceledWorkItemsGroup();
			}
			if (bool_0)
			{
				this._stp.CancelAbortWorkItemsGroup(this);
			}
		}

		// Token: 0x06001878 RID: 6264
		// RVA: 0x00014F59 File Offset: 0x00013159
		internal override void Enqueue(WorkItem workItem_0)
		{
			this.EnqueueToSTPNextWorkItem(workItem_0);
		}

		// Token: 0x06001879 RID: 6265
		// RVA: 0x00014F62 File Offset: 0x00013162
		private void EnqueueToSTPNextWorkItem(WorkItem workItem_0)
		{
			this.EnqueueToSTPNextWorkItem(workItem_0, false);
		}

		// Token: 0x0600187A RID: 6266
		// RVA: 0x00075414 File Offset: 0x00073614
		private void EnqueueToSTPNextWorkItem(WorkItem workItem_0, bool bool_0)
		{
			lock (this._lock)
			{
				if (bool_0)
				{
					this._workItemsInStpQueue--;
					if (this._workItemsInStpQueue < 0)
					{
						this._workItemsInStpQueue = 0;
					}
					this._workItemsExecutingInStp--;
					if (this._workItemsExecutingInStp < 0)
					{
						this._workItemsExecutingInStp = 0;
					}
				}
				if (workItem_0 != null)
				{
					workItem_0.CanceledWorkItemsGroup = this._canceledWorkItemsGroup;
					this.RegisterToWorkItemCompletion(workItem_0.GetWorkItemResult());
					this._workItemsQueue.Enqueue(workItem_0);
					if (1 == this._workItemsQueue.Count && this._workItemsInStpQueue == 0)
					{
						this._stp.RegisterWorkItemsGroup(this);
						base.IsIdle = false;
						this._isIdleWaitHandle.Reset();
					}
				}
				if (this._workItemsQueue.Count == 0)
				{
					if (this._workItemsInStpQueue == 0)
					{
						this._stp.UnregisterWorkItemsGroup(this);
						base.IsIdle = true;
						this._isIdleWaitHandle.Set();
						if (bool_0 && this._onIdle != null && this._onIdle.GetInvocationList().Length > 0)
						{
							this._stp.QueueWorkItem(new WorkItemCallback(this.FireOnIdle));
						}
					}
				}
				else if (!this._isSuspended && this._workItemsInStpQueue < this._concurrency)
				{
					WorkItem workItem_ = this._workItemsQueue.Dequeue() as WorkItem;
					try
					{
						this._stp.Enqueue(workItem_);
					}
					catch (ObjectDisposedException ex)
					{
						ex.GetHashCode();
					}
					this._workItemsInStpQueue++;
				}
			}
		}

		// Token: 0x06001874 RID: 6260
		// RVA: 0x00014F40 File Offset: 0x00013140
		private object FireOnIdle(object object_0)
		{
			this.FireOnIdleImpl(this._onIdle);
			return null;
		}

		// Token: 0x06001875 RID: 6261
		// RVA: 0x00075380 File Offset: 0x00073580
		private void FireOnIdleImpl(WorkItemsGroupIdleHandler workItemsGroupIdleHandler_0)
		{
			if (workItemsGroupIdleHandler_0 == null)
			{
				return;
			}
			Delegate[] invocationList = workItemsGroupIdleHandler_0.GetInvocationList();
			Delegate[] array = invocationList;
			for (int i = 0; i < array.Length; i++)
			{
				WorkItemsGroupIdleHandler workItemsGroupIdleHandler = (WorkItemsGroupIdleHandler)array[i];
				try
				{
					workItemsGroupIdleHandler(this);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001877 RID: 6263
		// RVA: 0x00014F4F File Offset: 0x0001314F
		private void OnWorkItemCompletedCallback(WorkItem workItem_0)
		{
			this.EnqueueToSTPNextWorkItem(null, true);
		}

		// Token: 0x06001876 RID: 6262
		// RVA: 0x000753D0 File Offset: 0x000735D0
		private void OnWorkItemStartedCallback(WorkItem workItem_0)
		{
			lock (this._lock)
			{
				this._workItemsExecutingInStp++;
			}
		}

		// Token: 0x06001873 RID: 6259
		// RVA: 0x00075348 File Offset: 0x00073548
		private void RegisterToWorkItemCompletion(IWorkItemResult iworkItemResult_0)
		{
			IInternalWorkItemResult internalWorkItemResult = (IInternalWorkItemResult)iworkItemResult_0;
			internalWorkItemResult.OnWorkItemStarted += new WorkItemStateCallback(this.OnWorkItemStartedCallback);
			internalWorkItemResult.OnWorkItemCompleted += new WorkItemStateCallback(this.OnWorkItemCompletedCallback);
		}
	}
}
