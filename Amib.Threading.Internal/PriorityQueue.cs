using System;
using System.Collections;
using System.Collections.Generic;

namespace Amib.Threading.Internal
{
	// Token: 0x02000323 RID: 803
	public sealed class PriorityQueue : IEnumerable
	{
		// Token: 0x02000324 RID: 804
		private sealed class PriorityQueueEnumerator : IEnumerator
		{
			// Token: 0x04001279 RID: 4729
			private IEnumerator _enumerator;

			// Token: 0x04001276 RID: 4726
			private readonly PriorityQueue _priorityQueue;

			// Token: 0x04001278 RID: 4728
			private int _queueIndex;

			// Token: 0x04001277 RID: 4727
			private int _version;

			// Token: 0x1700032A RID: 810
			public object Current
			{
				// Token: 0x060017D4 RID: 6100
				// RVA: 0x00014A64 File Offset: 0x00012C64
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x060017D2 RID: 6098
			// RVA: 0x00073BE0 File Offset: 0x00071DE0
			public PriorityQueueEnumerator(PriorityQueue priorityQueue_0)
			{
				this._priorityQueue = priorityQueue_0;
				this._version = this._priorityQueue._version;
				this._queueIndex = this._priorityQueue.GetNextNonEmptyQueue(-1);
				if (this._queueIndex >= 0)
				{
					this._enumerator = this._priorityQueue._queues[this._queueIndex].GetEnumerator();
					return;
				}
				this._enumerator = null;
			}

			// Token: 0x060017D5 RID: 6101
			// RVA: 0x00073CB4 File Offset: 0x00071EB4
			public bool MoveNext()
			{
				if (this._enumerator == null)
				{
					return false;
				}
				if (this._version != this._priorityQueue._version)
				{
					throw new InvalidOperationException("The collection has been modified");
				}
				if (this._enumerator.MoveNext())
				{
					return true;
				}
				this._queueIndex = this._priorityQueue.GetNextNonEmptyQueue(this._queueIndex);
				if (-1 == this._queueIndex)
				{
					return false;
				}
				this._enumerator = this._priorityQueue._queues[this._queueIndex].GetEnumerator();
				this._enumerator.MoveNext();
				return true;
			}

			// Token: 0x060017D3 RID: 6099
			// RVA: 0x00073C50 File Offset: 0x00071E50
			public void Reset()
			{
				this._version = this._priorityQueue._version;
				this._queueIndex = this._priorityQueue.GetNextNonEmptyQueue(-1);
				if (this._queueIndex >= 0)
				{
					this._enumerator = this._priorityQueue._queues[this._queueIndex].GetEnumerator();
					return;
				}
				this._enumerator = null;
			}
		}

		// Token: 0x04001273 RID: 4723
		private readonly LinkedList<IHasWorkItemPriority>[] _queues = new LinkedList<IHasWorkItemPriority>[5];

		// Token: 0x04001275 RID: 4725
		private int _version;

		// Token: 0x04001274 RID: 4724
		private int _workItemsCount;

		// Token: 0x17000329 RID: 809
		public int Count
		{
			// Token: 0x060017CF RID: 6095
			// RVA: 0x00014A54 File Offset: 0x00012C54
			get
			{
				return this._workItemsCount;
			}
		}

		// Token: 0x060017CB RID: 6091
		// RVA: 0x00073A80 File Offset: 0x00071C80
		public PriorityQueue()
		{
			for (int i = 0; i < this._queues.Length; i++)
			{
				this._queues[i] = new LinkedList<IHasWorkItemPriority>();
			}
		}

		// Token: 0x060017D0 RID: 6096
		// RVA: 0x00073B94 File Offset: 0x00071D94
		public void Clear()
		{
			if (this._workItemsCount > 0)
			{
				LinkedList<IHasWorkItemPriority>[] queues = this._queues;
				for (int i = 0; i < queues.Length; i++)
				{
					LinkedList<IHasWorkItemPriority> linkedList = queues[i];
					linkedList.Clear();
				}
				this._workItemsCount = 0;
				this._version++;
			}
		}

		// Token: 0x060017CD RID: 6093
		// RVA: 0x00073B04 File Offset: 0x00071D04
		public IHasWorkItemPriority Dequeue()
		{
			IHasWorkItemPriority result = null;
			if (this._workItemsCount > 0)
			{
				int nextNonEmptyQueue = this.GetNextNonEmptyQueue(-1);
				result = this._queues[nextNonEmptyQueue].First.Value;
				this._queues[nextNonEmptyQueue].RemoveFirst();
				this._workItemsCount--;
				this._version++;
			}
			return result;
		}

		// Token: 0x060017CC RID: 6092
		// RVA: 0x00073AC0 File Offset: 0x00071CC0
		public void Enqueue(IHasWorkItemPriority ihasWorkItemPriority_0)
		{
			int num = (WorkItemPriority)5 - ihasWorkItemPriority_0.WorkItemPriority - WorkItemPriority.BelowNormal;
			this._queues[num].AddLast(ihasWorkItemPriority_0);
			this._workItemsCount++;
			this._version++;
		}

		// Token: 0x060017D1 RID: 6097
		// RVA: 0x00014A5C File Offset: 0x00012C5C
		public IEnumerator GetEnumerator()
		{
			return new PriorityQueue.PriorityQueueEnumerator(this);
		}

		// Token: 0x060017CE RID: 6094
		// RVA: 0x00073B64 File Offset: 0x00071D64
		private int GetNextNonEmptyQueue(int int_0)
		{
			for (int i = int_0 + 1; i < 5; i++)
			{
				if (this._queues[i].Count > 0)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
