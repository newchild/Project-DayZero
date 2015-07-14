using System;
using System.Threading;

namespace ns8
{
	// Token: 0x020001AA RID: 426
	internal sealed class Class48 : IDisposable
	{
		// Token: 0x04000BBF RID: 3007
		private bool bool_0;

		// Token: 0x04000BC1 RID: 3009
		private bool bool_1;

		// Token: 0x04000BC0 RID: 3008
		private Guid guid_0;

		// Token: 0x04000BBE RID: 3006
		private Mutex mutex_0;

		// Token: 0x06000EF6 RID: 3830
		// RVA: 0x00051A04 File Offset: 0x0004FC04
		public Class48(Guid guid_1, int int_0)
		{
			this.guid_0 = guid_1;
			while (true)
			{
				this.mutex_0 = new Mutex(true, guid_1.ToString(), ref this.bool_0);
				if (int_0 < 0)
				{
					break;
				}
				try
				{
					if (!this.mutex_0.WaitOne(int_0, false))
					{
						throw new Exception0();
					}
					return;
				}
				catch (AbandonedMutexException)
				{
				}
			}
		}

		// Token: 0x06000EFA RID: 3834
		// RVA: 0x0000F16A File Offset: 0x0000D36A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000EF8 RID: 3832
		// RVA: 0x00051A70 File Offset: 0x0004FC70
		protected virtual void Dispose(bool bool_2)
		{
			if (!this.bool_1)
			{
				if (this.mutex_0 != null)
				{
					try
					{
						this.mutex_0.Close();
					}
					catch
					{
					}
					this.mutex_0 = null;
				}
				this.bool_1 = true;
			}
		}

		// Token: 0x06000EF9 RID: 3833
		// RVA: 0x00051ABC File Offset: 0x0004FCBC
		~Class48()
		{
			this.Dispose(false);
		}

		// Token: 0x06000EF7 RID: 3831
		// RVA: 0x0000F162 File Offset: 0x0000D362
		public bool method_0()
		{
			return this.bool_0;
		}
	}
}
