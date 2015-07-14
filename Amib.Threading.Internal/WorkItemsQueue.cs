using System;
using System.Threading;

namespace Amib.Threading.Internal
{
	// Token: 0x0200033A RID: 826
	public sealed class WorkItemsQueue : IDisposable
	{
		// Token: 0x0200033B RID: 827
		public sealed class WaiterEntry : IDisposable
		{
			// Token: 0x040012E9 RID: 4841
			private bool _isDisposed;

			// Token: 0x040012E7 RID: 4839
			private bool _isSignaled;

			// Token: 0x040012E6 RID: 4838
			private bool _isTimedout;

			// Token: 0x040012EA RID: 4842
			internal WorkItemsQueue.WaiterEntry _nextWaiterEntry;

			// Token: 0x040012EB RID: 4843
			internal WorkItemsQueue.WaiterEntry _prevWaiterEntry;

			// Token: 0x040012E5 RID: 4837
			private AutoResetEvent _waitHandle = EventWaitHandleFactory.CreateAutoResetEvent();

			// Token: 0x040012E8 RID: 4840
			private WorkItem _workItem;

			// Token: 0x17000358 RID: 856
			public WaitHandle WaitHandle
			{
				// Token: 0x06001889 RID: 6281
				// RVA: 0x0001501F File Offset: 0x0001321F
				get
				{
					return this._waitHandle;
				}
			}

			// Token: 0x17000359 RID: 857
			public WorkItem WorkItem
			{
				// Token: 0x0600188A RID: 6282
				// RVA: 0x00015027 File Offset: 0x00013227
				get
				{
					return this._workItem;
				}
			}

			// Token: 0x06001888 RID: 6280
			// RVA: 0x00015006 File Offset: 0x00013206
			public WaiterEntry()
			{
				this.Reset();
			}

			// Token: 0x0600188E RID: 6286
			// RVA: 0x00015052 File Offset: 0x00013252
			public void Close()
			{
				if (this._waitHandle != null)
				{
					this._waitHandle.Close();
					this._waitHandle = null;
				}
			}

			// Token: 0x0600188F RID: 6287
			// RVA: 0x0007599C File Offset: 0x00073B9C
			public void Dispose()
			{
				lock (this)
				{
					if (!this._isDisposed)
					{
						this.Close();
					}
					this._isDisposed = true;
				}
			}

			// Token: 0x0600188D RID: 6285
			// RVA: 0x0001502F File Offset: 0x0001322F
			public void Reset()
			{
				this._workItem = null;
				this._isTimedout = false;
				this._isSignaled = false;
				this._waitHandle.Reset();
			}

			// Token: 0x0600188B RID: 6283
			// RVA: 0x00075900 File Offset: 0x00073B00
			public bool Signal(WorkItem workItem_0)
			{
				lock (this)
				{
					if (!this._isTimedout)
					{
						this._workItem = workItem_0;
						this._isSignaled = true;
						this._waitHandle.Set();
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600188C RID: 6284
			// RVA: 0x00075958 File Offset: 0x00073B58
			public bool Timeout()
			{
				lock (this)
				{
					if (!this._isSignaled)
					{
						this._isTimedout = true;
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x040012DF RID: 4831
		private readonly WorkItemsQueue.WaiterEntry _headWaiterEntry = new WorkItemsQueue.WaiterEntry();

		// Token: 0x040012E4 RID: 4836
		private bool _isDisposed;

		// Token: 0x040012E2 RID: 4834
		private bool _isWorkItemsQueueActive = true;

		// Token: 0x040012E3 RID: 4835
		[ThreadStatic]
		private static WorkItemsQueue.WaiterEntry _waiterEntry;

		// Token: 0x040012E0 RID: 4832
		private int _waitersCount;

		// Token: 0x040012E1 RID: 4833
		private readonly PriorityQueue _workItems = new PriorityQueue();

		// Token: 0x17000357 RID: 855
		public int Count
		{
			// Token: 0x0600187D RID: 6269
			// RVA: 0x00014F7B File Offset: 0x0001317B
			get
			{
				return this._workItems.Count;
			}
		}

		// Token: 0x17000356 RID: 854
		private static WorkItemsQueue.WaiterEntry CurrentWaiterEntry
		{
			// Token: 0x0600187B RID: 6267
			// RVA: 0x00014F6C File Offset: 0x0001316C
			get
			{
				return WorkItemsQueue._waiterEntry;
			}
			// Token: 0x0600187C RID: 6268
			// RVA: 0x00014F73 File Offset: 0x00013173
			set
			{
				WorkItemsQueue._waiterEntry = value;
			}
		}

		// Token: 0x06001880 RID: 6272
		// RVA: 0x0007573C File Offset: 0x0007393C
		private void Cleanup()
		{
			lock (this)
			{
				if (this._isWorkItemsQueueActive)
				{
					this._isWorkItemsQueueActive = false;
					foreach (WorkItem workItem in this._workItems)
					{
						workItem.DisposeOfState();
					}
					this._workItems.Clear();
					while (this._waitersCount > 0)
					{
						WorkItemsQueue.WaiterEntry waiterEntry = this.PopWaiter();
						waiterEntry.Timeout();
					}
				}
			}
		}

		// Token: 0x0600187F RID: 6271
		// RVA: 0x00075640 File Offset: 0x00073840
		public WorkItem DequeueWorkItem(int int_0, WaitHandle waitHandle_0)
		{
			WorkItem workItem = null;
			WorkItemsQueue.WaiterEntry threadWaiterEntry;
			lock (this)
			{
				this.ValidateNotDisposed();
				if (this._workItems.Count > 0)
				{
					workItem = (this._workItems.Dequeue() as WorkItem);
					return workItem;
				}
				threadWaiterEntry = WorkItemsQueue.GetThreadWaiterEntry();
				this.PushWaiter(threadWaiterEntry);
			}
			WaitHandle[] waitHandle_ = new WaitHandle[]
			{
				threadWaiterEntry.WaitHandle,
				waitHandle_0
			};
			int num = STPEventWaitHandle.WaitAny(waitHandle_, int_0, true);
			lock (this)
			{
				bool flag;
				if (!(flag = (0 == num)))
				{
					bool flag2;
					if (flag2 = threadWaiterEntry.Timeout())
					{
						this.RemoveWaiter(threadWaiterEntry, false);
					}
					flag = !flag2;
				}
				if (flag)
				{
					workItem = threadWaiterEntry.WorkItem;
					if (workItem == null)
					{
						workItem = (this._workItems.Dequeue() as WorkItem);
					}
				}
			}
			return workItem;
		}

		// Token: 0x06001885 RID: 6277
		// RVA: 0x00014FAA File Offset: 0x000131AA
		public void Dispose()
		{
			if (!this._isDisposed)
			{
				this.Cleanup();
			}
			this._isDisposed = true;
		}

		// Token: 0x0600187E RID: 6270
		// RVA: 0x000755BC File Offset: 0x000737BC
		public bool EnqueueWorkItem(WorkItem workItem_0)
		{
			if (workItem_0 == null)
			{
				throw new ArgumentNullException("workItem", "workItem cannot be null");
			}
			bool flag = true;
			lock (this)
			{
				this.ValidateNotDisposed();
				if (!this._isWorkItemsQueueActive)
				{
					return false;
				}
				while (this._waitersCount > 0)
				{
					WorkItemsQueue.WaiterEntry waiterEntry = this.PopWaiter();
					if (waiterEntry.Signal(workItem_0))
					{
						flag = false;
						IL_4C:
						if (flag)
						{
							this._workItems.Enqueue(workItem_0);
						}
						return true;
					}
				}
				goto IL_4C;
			}
			return true;
		}

		// Token: 0x06001881 RID: 6273
		// RVA: 0x00014F88 File Offset: 0x00013188
		private static WorkItemsQueue.WaiterEntry GetThreadWaiterEntry()
		{
			if (WorkItemsQueue.CurrentWaiterEntry == null)
			{
				WorkItemsQueue.CurrentWaiterEntry = new WorkItemsQueue.WaiterEntry();
			}
			WorkItemsQueue.CurrentWaiterEntry.Reset();
			return WorkItemsQueue.CurrentWaiterEntry;
		}

		// Token: 0x06001883 RID: 6275
		// RVA: 0x00075868 File Offset: 0x00073A68
		private WorkItemsQueue.WaiterEntry PopWaiter()
		{
			WorkItemsQueue.WaiterEntry nextWaiterEntry = this._headWaiterEntry._nextWaiterEntry;
			WorkItemsQueue.WaiterEntry nextWaiterEntry2 = nextWaiterEntry._nextWaiterEntry;
			this.RemoveWaiter(nextWaiterEntry, true);
			this._headWaiterEntry._nextWaiterEntry = nextWaiterEntry2;
			if (nextWaiterEntry2 != null)
			{
				nextWaiterEntry2._prevWaiterEntry = this._headWaiterEntry;
			}
			return nextWaiterEntry;
		}

		// Token: 0x06001882 RID: 6274
		// RVA: 0x000757EC File Offset: 0x000739EC
		public void PushWaiter(WorkItemsQueue.WaiterEntry waiterEntry_0)
		{
			this.RemoveWaiter(waiterEntry_0, false);
			if (this._headWaiterEntry._nextWaiterEntry == null)
			{
				this._headWaiterEntry._nextWaiterEntry = waiterEntry_0;
				waiterEntry_0._prevWaiterEntry = this._headWaiterEntry;
			}
			else
			{
				WorkItemsQueue.WaiterEntry nextWaiterEntry = this._headWaiterEntry._nextWaiterEntry;
				this._headWaiterEntry._nextWaiterEntry = waiterEntry_0;
				waiterEntry_0._nextWaiterEntry = nextWaiterEntry;
				waiterEntry_0._prevWaiterEntry = this._headWaiterEntry;
				nextWaiterEntry._prevWaiterEntry = waiterEntry_0;
			}
			this._waitersCount++;
		}

		// Token: 0x06001884 RID: 6276
		// RVA: 0x000758AC File Offset: 0x00073AAC
		private void RemoveWaiter(WorkItemsQueue.WaiterEntry waiterEntry_0, bool bool_0)
		{
			WorkItemsQueue.WaiterEntry prevWaiterEntry = waiterEntry_0._prevWaiterEntry;
			WorkItemsQueue.WaiterEntry nextWaiterEntry = waiterEntry_0._nextWaiterEntry;
			bool flag = bool_0;
			waiterEntry_0._prevWaiterEntry = null;
			waiterEntry_0._nextWaiterEntry = null;
			if (prevWaiterEntry != null)
			{
				prevWaiterEntry._nextWaiterEntry = nextWaiterEntry;
				flag = true;
			}
			if (nextWaiterEntry != null)
			{
				nextWaiterEntry._prevWaiterEntry = prevWaiterEntry;
				flag = true;
			}
			if (flag)
			{
				this._waitersCount--;
			}
		}

		// Token: 0x06001886 RID: 6278
		// RVA: 0x00014FC1 File Offset: 0x000131C1
		private void ValidateNotDisposed()
		{
			if (this._isDisposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString(), "The SmartThreadPool has been shutdown");
			}
		}
	}
}
