using System;
using System.Runtime.CompilerServices;

namespace Amib.Threading.Internal
{
	// Token: 0x02000325 RID: 805
	public abstract class WorkItemsGroupBase : IWorkItemsGroup
	{
		// Token: 0x0400127A RID: 4730
		private string _name = "WorkItemsGroupBase";

		// Token: 0x1700032D RID: 813
		protected bool IsIdle
		{
			// Token: 0x060017DE RID: 6110
			// RVA: 0x00014AA5 File Offset: 0x00012CA5
			[CompilerGenerated]
			set
			{
				this.<IsIdle>k__BackingField = value;
			}
		}

		// Token: 0x1700032B RID: 811
		public string Name
		{
			// Token: 0x060017D7 RID: 6103
			// RVA: 0x00014A8B File Offset: 0x00012C8B
			get
			{
				return this._name;
			}
			// Token: 0x060017D8 RID: 6104
			// RVA: 0x00014A93 File Offset: 0x00012C93
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700032C RID: 812
		public abstract WIGStartInfo WIGStartInfo
		{
			// Token: 0x060017D9 RID: 6105
			get;
		}

		// Token: 0x060017D6 RID: 6102
		// RVA: 0x00014A71 File Offset: 0x00012C71
		public WorkItemsGroupBase()
		{
			this.IsIdle = true;
		}

		// Token: 0x060017DD RID: 6109
		// RVA: 0x00014A9C File Offset: 0x00012C9C
		public virtual void Cancel()
		{
			this.Cancel(false);
		}

		// Token: 0x060017DA RID: 6106
		public abstract void Cancel(bool bool_0);

		// Token: 0x060017DB RID: 6107
		internal abstract void Enqueue(WorkItem workItem_0);

		// Token: 0x060017DC RID: 6108
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void PreQueueWorkItem()
		{
		}

		// Token: 0x060017DF RID: 6111
		// RVA: 0x00073D4C File Offset: 0x00071F4C
		public IWorkItemResult QueueWorkItem(WorkItemCallback workItemCallback_0)
		{
			WorkItem workItem = WorkItemFactory.CreateWorkItem(this, this.WIGStartInfo, workItemCallback_0);
			this.Enqueue(workItem);
			return workItem.GetWorkItemResult();
		}

		// Token: 0x060017E0 RID: 6112
		// RVA: 0x00014AAE File Offset: 0x00012CAE
		public IWorkItemResult QueueWorkItem(Action action_0)
		{
			return this.QueueWorkItem(action_0, WorkItemPriority.Normal);
		}

		// Token: 0x060017E1 RID: 6113
		// RVA: 0x00073D74 File Offset: 0x00071F74
		public IWorkItemResult QueueWorkItem(Action action_0, WorkItemPriority workItemPriority_0)
		{
			this.PreQueueWorkItem();
			WorkItem workItem = WorkItemFactory.CreateWorkItem(this, this.WIGStartInfo, delegate(object object_0)
			{
				action_0();
				return null;
			}, workItemPriority_0);
			this.Enqueue(workItem);
			return workItem.GetWorkItemResult();
		}
	}
}
