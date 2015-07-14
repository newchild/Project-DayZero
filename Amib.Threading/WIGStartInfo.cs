using System;

namespace Amib.Threading
{
	// Token: 0x02000333 RID: 819
	public class WIGStartInfo
	{
		// Token: 0x040012BA RID: 4794
		private CallToPostExecute _callToPostExecute;

		// Token: 0x040012B9 RID: 4793
		private bool _disposeOfStateObjects;

		// Token: 0x040012BE RID: 4798
		private bool _fillStateWithArgs;

		// Token: 0x040012BB RID: 4795
		private PostExecuteWorkItemCallback _postExecuteWorkItemCallback;

		// Token: 0x040012BF RID: 4799
		protected bool _readOnly;

		// Token: 0x040012BC RID: 4796
		private bool _startSuspended;

		// Token: 0x040012B7 RID: 4791
		private bool _useCallerCallContext;

		// Token: 0x040012B8 RID: 4792
		private bool _useCallerHttpContext;

		// Token: 0x040012BD RID: 4797
		private WorkItemPriority _workItemPriority;

		// Token: 0x1700033A RID: 826
		public virtual CallToPostExecute CallToPostExecute
		{
			// Token: 0x0600183C RID: 6204
			// RVA: 0x00014D5E File Offset: 0x00012F5E
			get
			{
				return this._callToPostExecute;
			}
		}

		// Token: 0x17000339 RID: 825
		public virtual bool DisposeOfStateObjects
		{
			// Token: 0x0600183B RID: 6203
			// RVA: 0x00014D56 File Offset: 0x00012F56
			get
			{
				return this._disposeOfStateObjects;
			}
		}

		// Token: 0x1700033E RID: 830
		public virtual bool FillStateWithArgs
		{
			// Token: 0x06001840 RID: 6208
			// RVA: 0x00014D7E File Offset: 0x00012F7E
			get
			{
				return this._fillStateWithArgs;
			}
		}

		// Token: 0x1700033B RID: 827
		public virtual PostExecuteWorkItemCallback PostExecuteWorkItemCallback
		{
			// Token: 0x0600183D RID: 6205
			// RVA: 0x00014D66 File Offset: 0x00012F66
			get
			{
				return this._postExecuteWorkItemCallback;
			}
		}

		// Token: 0x1700033C RID: 828
		public virtual bool StartSuspended
		{
			// Token: 0x0600183E RID: 6206
			// RVA: 0x00014D6E File Offset: 0x00012F6E
			get
			{
				return this._startSuspended;
			}
		}

		// Token: 0x17000337 RID: 823
		public virtual bool UseCallerCallContext
		{
			// Token: 0x06001839 RID: 6201
			// RVA: 0x00014D46 File Offset: 0x00012F46
			get
			{
				return this._useCallerCallContext;
			}
		}

		// Token: 0x17000338 RID: 824
		public virtual bool UseCallerHttpContext
		{
			// Token: 0x0600183A RID: 6202
			// RVA: 0x00014D4E File Offset: 0x00012F4E
			get
			{
				return this._useCallerHttpContext;
			}
		}

		// Token: 0x1700033D RID: 829
		public virtual WorkItemPriority WorkItemPriority
		{
			// Token: 0x0600183F RID: 6207
			// RVA: 0x00014D76 File Offset: 0x00012F76
			get
			{
				return this._workItemPriority;
			}
		}

		// Token: 0x06001836 RID: 6198
		// RVA: 0x00074E0C File Offset: 0x0007300C
		public WIGStartInfo()
		{
			this._fillStateWithArgs = false;
			this._workItemPriority = WorkItemPriority.Normal;
			this._startSuspended = false;
			this._postExecuteWorkItemCallback = SmartThreadPool.DefaultPostExecuteWorkItemCallback;
			this._callToPostExecute = CallToPostExecute.Always;
			this._disposeOfStateObjects = false;
			this._useCallerHttpContext = false;
			this._useCallerCallContext = false;
		}

		// Token: 0x06001837 RID: 6199
		// RVA: 0x00074E5C File Offset: 0x0007305C
		public WIGStartInfo(WIGStartInfo wigstartInfo_0)
		{
			this._useCallerCallContext = wigstartInfo_0.UseCallerCallContext;
			this._useCallerHttpContext = wigstartInfo_0.UseCallerHttpContext;
			this._disposeOfStateObjects = wigstartInfo_0.DisposeOfStateObjects;
			this._callToPostExecute = wigstartInfo_0.CallToPostExecute;
			this._postExecuteWorkItemCallback = wigstartInfo_0.PostExecuteWorkItemCallback;
			this._workItemPriority = wigstartInfo_0.WorkItemPriority;
			this._startSuspended = wigstartInfo_0.StartSuspended;
			this._fillStateWithArgs = wigstartInfo_0.FillStateWithArgs;
		}

		// Token: 0x06001838 RID: 6200
		// RVA: 0x00014D31 File Offset: 0x00012F31
		protected void ThrowIfReadOnly()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("This is a readonly instance and set is not supported");
			}
		}
	}
}
