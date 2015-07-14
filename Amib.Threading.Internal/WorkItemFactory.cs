using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000336 RID: 822
	public sealed class WorkItemFactory
	{
		// Token: 0x0600185C RID: 6236
		// RVA: 0x00014E45 File Offset: 0x00013045
		public static WorkItem CreateWorkItem(IWorkItemsGroup iworkItemsGroup_0, WIGStartInfo wigstartInfo_0, WorkItemCallback workItemCallback_0)
		{
			return WorkItemFactory.CreateWorkItem(iworkItemsGroup_0, wigstartInfo_0, workItemCallback_0, null);
		}

		// Token: 0x0600185D RID: 6237
		// RVA: 0x00014E50 File Offset: 0x00013050
		public static WorkItem CreateWorkItem(IWorkItemsGroup iworkItemsGroup_0, WIGStartInfo wigstartInfo_0, WorkItemCallback workItemCallback_0, WorkItemPriority workItemPriority_0)
		{
			return WorkItemFactory.CreateWorkItem(iworkItemsGroup_0, wigstartInfo_0, workItemCallback_0, null, workItemPriority_0);
		}

		// Token: 0x0600185E RID: 6238
		// RVA: 0x00075208 File Offset: 0x00073408
		public static WorkItem CreateWorkItem(IWorkItemsGroup iworkItemsGroup_0, WIGStartInfo wigstartInfo_0, WorkItemCallback workItemCallback_0, object object_0)
		{
			WorkItemFactory.ValidateCallback(workItemCallback_0);
			return new WorkItem(iworkItemsGroup_0, new WorkItemInfo
			{
				UseCallerCallContext = wigstartInfo_0.UseCallerCallContext,
				UseCallerHttpContext = wigstartInfo_0.UseCallerHttpContext,
				PostExecuteWorkItemCallback = wigstartInfo_0.PostExecuteWorkItemCallback,
				CallToPostExecute = wigstartInfo_0.CallToPostExecute,
				DisposeOfStateObjects = wigstartInfo_0.DisposeOfStateObjects,
				WorkItemPriority = wigstartInfo_0.WorkItemPriority
			}, workItemCallback_0, object_0);
		}

		// Token: 0x0600185F RID: 6239
		// RVA: 0x00075274 File Offset: 0x00073474
		public static WorkItem CreateWorkItem(IWorkItemsGroup iworkItemsGroup_0, WIGStartInfo wigstartInfo_0, WorkItemCallback workItemCallback_0, object object_0, WorkItemPriority workItemPriority_0)
		{
			WorkItemFactory.ValidateCallback(workItemCallback_0);
			return new WorkItem(iworkItemsGroup_0, new WorkItemInfo
			{
				UseCallerCallContext = wigstartInfo_0.UseCallerCallContext,
				UseCallerHttpContext = wigstartInfo_0.UseCallerHttpContext,
				PostExecuteWorkItemCallback = wigstartInfo_0.PostExecuteWorkItemCallback,
				CallToPostExecute = wigstartInfo_0.CallToPostExecute,
				DisposeOfStateObjects = wigstartInfo_0.DisposeOfStateObjects,
				WorkItemPriority = workItemPriority_0
			}, workItemCallback_0, object_0);
		}

		// Token: 0x06001860 RID: 6240
		// RVA: 0x00014E5C File Offset: 0x0001305C
		private static void ValidateCallback(Delegate delegate_0)
		{
			if (delegate_0 != null && delegate_0.GetInvocationList().Length > 1)
			{
				throw new NotSupportedException("SmartThreadPool doesn't support delegates chains");
			}
		}
	}
}
