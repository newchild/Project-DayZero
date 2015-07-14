using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace ns14
{
	// Token: 0x020005BC RID: 1468
	internal sealed class Class785 : IpcClientChannel, IDisposable
	{
		// Token: 0x040026EF RID: 9967
		private bool bool_0;

		// Token: 0x06002EC7 RID: 11975
		// RVA: 0x00130464 File Offset: 0x0012E664
		public Class785()
		{
			try
			{
				ChannelServices.RegisterChannel(this, false);
			}
			catch
			{
			}
		}

		// Token: 0x06002EC8 RID: 11976
		// RVA: 0x00130494 File Offset: 0x0012E694
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			try
			{
				ChannelServices.UnregisterChannel(this);
			}
			catch
			{
			}
		}

		// Token: 0x06002EC6 RID: 11974
		// RVA: 0x0013042C File Offset: 0x0012E62C
		public static Class785 smethod_0()
		{
			Class785 class = null;
			try
			{
				class = new Class785();
			}
			catch
			{
				if (class != null)
				{
					class.Dispose();
					class = null;
				}
			}
			return class;
		}
	}
}
