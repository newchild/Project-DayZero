using System;

namespace Amib.Threading
{
	// Token: 0x02000313 RID: 787
	public interface IWorkItemResult<TResult>
	{
		// Token: 0x0600179F RID: 6047
		bool Cancel(bool bool_0);
	}
	// Token: 0x02000314 RID: 788
	public interface IWorkItemResult : IWorkItemResult<object>
	{
	}
}
