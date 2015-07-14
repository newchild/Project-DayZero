using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000338 RID: 824
	internal sealed class WorkItemResultTWrapper<TResult> : IWorkItemResult<TResult>
	{
		// Token: 0x040012D3 RID: 4819
		private readonly IWorkItemResult _workItemResult;

		// Token: 0x0600186F RID: 6255
		// RVA: 0x00014F1B File Offset: 0x0001311B
		public WorkItemResultTWrapper(IWorkItemResult iworkItemResult_0)
		{
			this._workItemResult = iworkItemResult_0;
		}

		// Token: 0x06001870 RID: 6256
		// RVA: 0x00014F2A File Offset: 0x0001312A
		public bool Cancel(bool bool_0)
		{
			return this._workItemResult.Cancel(bool_0);
		}
	}
}
