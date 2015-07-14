using ns29;
using osu;
using osu.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Threading;

namespace ns14
{
	// Token: 0x020005BB RID: 1467
	internal static class Class784
	{
		// Token: 0x040026EE RID: 9966
		public static int int_0;

		// Token: 0x040026ED RID: 9965
		internal static IpcChannel ipcChannel_0;

		// Token: 0x040026EC RID: 9964
		internal static List<Enum75> list_0 = new List<Enum75>();

		// Token: 0x06002EBF RID: 11967
		// RVA: 0x00130200 File Offset: 0x0012E400
		internal static void smethod_0(string string_0)
		{
			bool flag;
			if (flag = Class784.smethod_1(string_0))
			{
				return;
			}
			if (!Class905.bool_0 && Class784.smethod_3())
			{
				int num = 20;
				while (num-- > 0 && !flag)
				{
					Thread.Sleep(200);
					flag = Class784.smethod_1(string_0);
				}
				if (!flag)
				{
					Class115.smethod_70(OsuModes.Exit, false);
				}
			}
		}

		// Token: 0x06002EC0 RID: 11968
		// RVA: 0x00130254 File Offset: 0x0012E454
		private static bool smethod_1(string string_0)
		{
			try
			{
				Class784.ipcChannel_0 = new IpcChannel(string_0);
				ChannelServices.RegisterChannel(Class784.ipcChannel_0, false);
				RemotingConfiguration.RegisterWellKnownServiceType(typeof(InterProcessOsu), "loader", WellKnownObjectMode.Singleton);
				return true;
			}
			catch
			{
				Class784.ipcChannel_0 = null;
			}
			return false;
		}

		// Token: 0x06002EC1 RID: 11969
		// RVA: 0x001302AC File Offset: 0x0012E4AC
		internal static void smethod_2()
		{
			if (Class784.ipcChannel_0 != null)
			{
				try
				{
					ChannelServices.UnregisterChannel(Class784.ipcChannel_0);
				}
				catch
				{
				}
				Class784.ipcChannel_0 = null;
			}
		}

		// Token: 0x06002EC2 RID: 11970
		// RVA: 0x001302E8 File Offset: 0x0012E4E8
		private static bool smethod_3()
		{
			try
			{
				using (Class785 class = Class785.smethod_0())
				{
					if (class == null)
					{
						bool result = false;
						return result;
					}
					InterProcessOsu interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://osu!/loader");
					if (interProcessOsu != null)
					{
						interProcessOsu.method_2();
						bool result = true;
						return result;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06002EC3 RID: 11971
		// RVA: 0x0013035C File Offset: 0x0012E55C
		internal static InterProcessOsu smethod_4()
		{
			InterProcessOsu result;
			try
			{
				using (Class785 class = Class785.smethod_0())
				{
					if (class == null)
					{
						result = null;
					}
					else
					{
						InterProcessOsu interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://osu!/loader");
						result = interProcessOsu;
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002EC4 RID: 11972
		// RVA: 0x001303C0 File Offset: 0x0012E5C0
		internal static void smethod_5(string string_0)
		{
			try
			{
				using (Class785 class = Class785.smethod_0())
				{
					if (class != null)
					{
						InterProcessOsu interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://osu!/loader");
						if (interProcessOsu != null)
						{
							interProcessOsu.method_0(string_0);
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
