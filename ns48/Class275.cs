using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns48
{
	// Token: 0x020002F2 RID: 754
	internal static class Class275
	{
		// Token: 0x020002F3 RID: 755
		[CompilerGenerated]
		private sealed class Class276<T> where T : EventArgs
		{
			// Token: 0x040011E4 RID: 4580
			public EventHandler<T> eventHandler_0;

			// Token: 0x040011E6 RID: 4582
			public T gparam_0;

			// Token: 0x040011E5 RID: 4581
			public object object_0;

			// Token: 0x06001733 RID: 5939
			// RVA: 0x00014606 File Offset: 0x00012806
			public void method_0(object object_1)
			{
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this.object_0, this.gparam_0);
				}
			}
		}

		// Token: 0x040011E3 RID: 4579
		private static Random random_0 = new Random();

		// Token: 0x0600172E RID: 5934
		// RVA: 0x00072E98 File Offset: 0x00071098
		public static void smethod_0<T>(EventHandler<T> eventHandler_0, object object_0, T gparam_0) where T : EventArgs
		{
			Class275.Class276<T> class = new Class275.Class276<T>();
			class.eventHandler_0 = eventHandler_0;
			class.object_0 = object_0;
			class.gparam_0 = gparam_0;
			if (class.eventHandler_0 == null)
			{
				return;
			}
			ThreadPool.QueueUserWorkItem(new WaitCallback(class.method_0));
		}

		// Token: 0x0600172F RID: 5935
		// RVA: 0x000145C6 File Offset: 0x000127C6
		public static bool smethod_1(byte[] byte_0, byte[] byte_1)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("array1");
			}
			if (byte_1 == null)
			{
				throw new ArgumentNullException("array2");
			}
			return byte_0.Length == byte_1.Length && Class275.smethod_2(byte_0, 0, byte_1, 0, byte_0.Length);
		}

		// Token: 0x06001730 RID: 5936
		// RVA: 0x00072EDC File Offset: 0x000710DC
		public static bool smethod_2(byte[] byte_0, int int_0, byte[] byte_1, int int_1, int int_2)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("array1");
			}
			if (byte_1 == null)
			{
				throw new ArgumentNullException("array2");
			}
			if (byte_0.Length - int_0 >= int_2 && byte_1.Length - int_1 >= int_2)
			{
				for (int i = 0; i < int_2; i++)
				{
					if (byte_0[int_0 + i] != byte_1[int_1 + i])
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}
}
