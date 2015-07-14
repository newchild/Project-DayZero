using ns30;
using ns41;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns8
{
	// Token: 0x020001A1 RID: 417
	internal static class Class41
	{
		// Token: 0x020001A2 RID: 418
		[CompilerGenerated]
		private sealed class Class42
		{
			// Token: 0x0400073B RID: 1851
			public string string_0;

			// Token: 0x0400073C RID: 1852
			public string string_1;

			// Token: 0x0400073D RID: 1853
			public string string_2;

			// Token: 0x0400073F RID: 1855
			public string string_3;

			// Token: 0x0400073E RID: 1854
			public VoidDelegate voidDelegate_0;

			// Token: 0x06000EE0 RID: 3808
			// RVA: 0x000512BC File Offset: 0x0004F4BC
			public void method_0(string string_4, Exception exception_0)
			{
				ThreadStart threadStart = null;
				if (exception_0 != null)
				{
					if (!File.Exists(this.string_0))
					{
						if (threadStart == null)
						{
							threadStart = new ThreadStart(this.method_1);
						}
						new Thread(threadStart)
						{
							IsBackground = true
						}.Start();
						return;
					}
				}
				else
				{
					Class34.smethod_14(this.string_1, this.string_0, true, true);
				}
				Class41.smethod_0(this.string_2, false, this.voidDelegate_0, this.string_3);
			}

			// Token: 0x06000EE1 RID: 3809
			// RVA: 0x0000F062 File Offset: 0x0000D262
			public void method_1()
			{
				Thread.Sleep(1000);
				Class41.smethod_0(null, false, this.voidDelegate_0, this.string_3);
			}
		}

		// Token: 0x04000739 RID: 1849
		public static bool bool_0;

		// Token: 0x04000738 RID: 1848
		private static Dictionary<OsuString, string> dictionary_0 = new Dictionary<OsuString, string>();

		// Token: 0x0400073A RID: 1850
		public static string string_0 = string.Empty;

		// Token: 0x06000ED9 RID: 3801
		// RVA: 0x00050F24 File Offset: 0x0004F124
		public static string GetString(OsuString osuString_0)
		{
			if (!Class41.bool_0)
			{
				Class41.smethod_1("");
			}
			string result;
			try
			{
				result = Class41.dictionary_0[osuString_0];
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000EDA RID: 3802
		// RVA: 0x00050F6C File Offset: 0x0004F16C
		public static bool smethod_0(string string_1, bool bool_1, VoidDelegate voidDelegate_0, string string_2)
		{
			Class41.Class42 class = new Class41.Class42();
			class.string_2 = string_1;
			class.voidDelegate_0 = voidDelegate_0;
			class.string_3 = string_2;
			Thread currentThread = Thread.CurrentThread;
			if (string.IsNullOrEmpty(class.string_2) || class.string_2 == "unknown")
			{
				string name = currentThread.CurrentUICulture.Name;
				string text = name.Substring(0, 2);
				string a;
				if ((a = text) != null && (a == "ms" || a == "vi" || a == "zh"))
				{
					class.string_2 = name;
				}
				else
				{
					class.string_2 = text;
				}
			}
			Class41.bool_0 = false;
			Class41.string_0 = class.string_2;
			if ((class.string_2 == "en" || !bool_1) && Class41.smethod_1(class.string_3))
			{
				try
				{
					currentThread.CurrentUICulture = new CultureInfo(class.string_2);
				}
				catch
				{
				}
				if (class.voidDelegate_0 != null)
				{
					class.voidDelegate_0();
				}
				return true;
			}
			class.string_0 = "Localisation/" + class.string_2 + ".txt";
			class.string_1 = class.string_0 + ".new";
			FileNetRequest fileNetRequest = new FileNetRequest(class.string_1, string.Concat(new object[]
			{
				Class214.string_1,
				"Localisation/",
				class.string_2,
				".txt?",
				DateTime.Today.ToFileTimeUtc()
			}));
			fileNetRequest.method_2(new FileNetRequest.Delegate10(class.method_0));
			Class169.smethod_0(fileNetRequest);
			return false;
		}

		// Token: 0x06000EDB RID: 3803
		// RVA: 0x00051134 File Offset: 0x0004F334
		private static bool smethod_1(string string_1)
		{
			bool result;
			lock (Class41.dictionary_0)
			{
				if (!Class41.bool_0)
				{
					try
					{
						Class41.dictionary_0.Clear();
						if (!string.IsNullOrEmpty(string_1))
						{
							Class41.smethod_2(string_1);
						}
						else
						{
							Class41.smethod_3("en");
						}
						if (Class41.string_0 == "en")
						{
							result = true;
							return result;
						}
						result = Class41.smethod_3(Class41.string_0);
						return result;
					}
					finally
					{
						Class41.bool_0 = true;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000EDC RID: 3804
		// RVA: 0x000511CC File Offset: 0x0004F3CC
		private static bool smethod_2(string string_1)
		{
			using (StringReader stringReader = new StringReader(string_1))
			{
				while (stringReader.Peek() != -1)
				{
					string text = stringReader.ReadLine();
					int num = text.IndexOf('=');
					if (num > 0)
					{
						try
						{
							Class41.dictionary_0[(OsuString)Enum.Parse(typeof(OsuString), text.Remove(num), false)] = text.Substring(num + 1).Replace("\\n", "\n");
						}
						catch
						{
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000EDD RID: 3805
		// RVA: 0x0005126C File Offset: 0x0004F46C
		private static bool smethod_3(string string_1)
		{
			string path = "Localisation/" + string_1 + ".txt";
			if (!File.Exists(path))
			{
				return false;
			}
			bool result;
			try
			{
				Class41.smethod_2(File.ReadAllText(path));
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
