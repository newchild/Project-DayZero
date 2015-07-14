using System;
using System.Runtime.CompilerServices;

namespace Amib.Threading
{
	// Token: 0x02000337 RID: 823
	public sealed class WorkItemInfo
	{
		// Token: 0x17000351 RID: 849
		public CallToPostExecute CallToPostExecute
		{
			// Token: 0x06001868 RID: 6248
			// RVA: 0x00014EE0 File Offset: 0x000130E0
			get;
			// Token: 0x06001869 RID: 6249
			// RVA: 0x00014EE8 File Offset: 0x000130E8
			set;
		}

		// Token: 0x17000350 RID: 848
		public bool DisposeOfStateObjects
		{
			// Token: 0x06001866 RID: 6246
			// RVA: 0x00014ECF File Offset: 0x000130CF
			get;
			// Token: 0x06001867 RID: 6247
			// RVA: 0x00014ED7 File Offset: 0x000130D7
			set;
		}

		// Token: 0x17000352 RID: 850
		public PostExecuteWorkItemCallback PostExecuteWorkItemCallback
		{
			// Token: 0x0600186A RID: 6250
			// RVA: 0x00014EF1 File Offset: 0x000130F1
			get;
			// Token: 0x0600186B RID: 6251
			// RVA: 0x00014EF9 File Offset: 0x000130F9
			set;
		}

		// Token: 0x17000354 RID: 852
		public long Timeout
		{
			// Token: 0x0600186E RID: 6254
			// RVA: 0x00014F13 File Offset: 0x00013113
			[CompilerGenerated]
			get
			{
				return this.<Timeout>k__BackingField;
			}
		}

		// Token: 0x1700034E RID: 846
		public bool UseCallerCallContext
		{
			// Token: 0x06001862 RID: 6242
			// RVA: 0x00014EAD File Offset: 0x000130AD
			get;
			// Token: 0x06001863 RID: 6243
			// RVA: 0x00014EB5 File Offset: 0x000130B5
			set;
		}

		// Token: 0x1700034F RID: 847
		public bool UseCallerHttpContext
		{
			// Token: 0x06001864 RID: 6244
			// RVA: 0x00014EBE File Offset: 0x000130BE
			get;
			// Token: 0x06001865 RID: 6245
			// RVA: 0x00014EC6 File Offset: 0x000130C6
			set;
		}

		// Token: 0x17000353 RID: 851
		public WorkItemPriority WorkItemPriority
		{
			// Token: 0x0600186C RID: 6252
			// RVA: 0x00014F02 File Offset: 0x00013102
			get;
			// Token: 0x0600186D RID: 6253
			// RVA: 0x00014F0A File Offset: 0x0001310A
			set;
		}

		// Token: 0x06001861 RID: 6241
		// RVA: 0x00014E77 File Offset: 0x00013077
		public WorkItemInfo()
		{
			this.UseCallerCallContext = false;
			this.UseCallerHttpContext = false;
			this.DisposeOfStateObjects = false;
			this.CallToPostExecute = CallToPostExecute.Always;
			this.PostExecuteWorkItemCallback = SmartThreadPool.DefaultPostExecuteWorkItemCallback;
			this.WorkItemPriority = WorkItemPriority.Normal;
		}
	}
}
