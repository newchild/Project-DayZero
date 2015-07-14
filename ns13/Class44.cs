using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ns13
{
	// Token: 0x020001A5 RID: 421
	internal static class Class44
	{
		// Token: 0x020001A6 RID: 422
		private sealed class Class45
		{
			// Token: 0x04000BB5 RID: 2997
			public List<Thread> list_0;
		}

		// Token: 0x020001A7 RID: 423
		internal sealed class Class46 : IDisposable
		{
			// Token: 0x04000BB6 RID: 2998
			private object object_0;

			// Token: 0x06000EEE RID: 3822
			// RVA: 0x0000F10A File Offset: 0x0000D30A
			public void Dispose()
			{
				if (this.object_0 != null)
				{
					Class44.smethod_0(this.object_0);
					this.object_0 = null;
				}
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static bool bool_0;

		// Token: 0x04000BB2 RID: 2994
		private static Dictionary<object, Class44.Class45> dictionary_0;

		// Token: 0x04000BB1 RID: 2993
		private static object object_0;

		// Token: 0x04000BB3 RID: 2995
		private static StreamWriter streamWriter_0;

		// Token: 0x06000EEC RID: 3820
		// RVA: 0x0005161C File Offset: 0x0004F81C
		static Class44()
		{
			Class44.object_0 = new object();
			Class44.dictionary_0 = new Dictionary<object, Class44.Class45>();
			try
			{
				FileStream stream = new FileStream("lockLog.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
				Class44.streamWriter_0 = new StreamWriter(stream);
				Class44.streamWriter_0.BaseStream.Position = Class44.streamWriter_0.BaseStream.Length;
				Class44.bool_0 = true;
			}
			catch
			{
				Class44.bool_0 = false;
			}
		}

		// Token: 0x06000EED RID: 3821
		// RVA: 0x00051698 File Offset: 0x0004F898
		private static void smethod_0(object object_1)
		{
			lock (Class44.object_0)
			{
				Class44.Class45 class;
				if (!Class44.dictionary_0.TryGetValue(object_1, out class))
				{
					return;
				}
				if (class.list_0.Count == 0)
				{
					Class44.dictionary_0.Remove(object_1);
				}
			}
			Monitor.Exit(object_1);
		}
	}
}
