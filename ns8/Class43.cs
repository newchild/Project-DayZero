using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns8
{
	// Token: 0x020001A4 RID: 420
	internal sealed class Class43 : IDisposable
	{
		// Token: 0x04000BAF RID: 2991
		private bool bool_0;

		// Token: 0x04000BB0 RID: 2992
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000BAC RID: 2988
		private readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

		// Token: 0x04000BAD RID: 2989
		private readonly Dictionary<string, object> dictionary_1 = new Dictionary<string, object>();

		// Token: 0x04000BAE RID: 2990
		private string string_0;

		// Token: 0x06000EE3 RID: 3811
		// RVA: 0x0000F08A File Offset: 0x0000D28A
		public Class43(string string_1, bool bool_2)
		{
			this.method_1(string_1, bool_2);
		}

		// Token: 0x06000EE5 RID: 3813
		// RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		public void Dispose()
		{
			if (this.bool_0)
			{
				this.method_3();
			}
		}

		// Token: 0x06000EE4 RID: 3812
		// RVA: 0x00051330 File Offset: 0x0004F530
		~Class43()
		{
			this.Dispose();
		}

		// Token: 0x06000EE6 RID: 3814
		// RVA: 0x0005135C File Offset: 0x0004F55C
		public T GetValue<T>(string string_1, T gparam_0)
		{
			object obj;
			if (this.dictionary_1.TryGetValue(string_1, out obj))
			{
				return (T)((object)obj);
			}
			string text;
			if (!this.dictionary_0.TryGetValue(string_1, out text))
			{
				this.SetValue<T>(string_1, gparam_0);
				return gparam_0;
			}
			string name = typeof(T).Name;
			string a;
			if ((a = name) != null)
			{
				if (!(a == "Boolean"))
				{
					if (!(a == "Int32"))
					{
						if (!(a == "Int64"))
						{
							if (a == "String")
							{
								obj = text;
							}
						}
						else
						{
							obj = long.Parse(text);
						}
					}
					else
					{
						obj = int.Parse(text);
					}
				}
				else
				{
					obj = (text[0] == '1');
				}
			}
			this.dictionary_1[string_1] = obj;
			this.dictionary_0[string_1] = text;
			return (T)((object)obj);
		}

		// Token: 0x06000EE2 RID: 3810
		// RVA: 0x0000F082 File Offset: 0x0000D282
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x06000EE8 RID: 3816
		// RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		public void method_1(string string_1, bool bool_2)
		{
			this.dictionary_0.Clear();
			this.dictionary_1.Clear();
			if (this.method_2(string_1) || bool_2)
			{
				this.string_0 = string_1;
			}
		}

		// Token: 0x06000EE9 RID: 3817
		// RVA: 0x000514E0 File Offset: 0x0004F6E0
		private bool method_2(string string_1)
		{
			if (!File.Exists(string_1))
			{
				return false;
			}
			try
			{
				using (StreamReader streamReader = File.OpenText(string_1))
				{
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						if (text.Length >= 2 && !text.StartsWith("#"))
						{
							int num = text.IndexOf('=');
							string key = text.Remove(num).Trim();
							string value = text.Substring(num + 1).Trim();
							this.dictionary_0[key] = value;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000EEA RID: 3818
		// RVA: 0x0000F0EB File Offset: 0x0000D2EB
		public void method_3()
		{
			if (this.string_0 == null)
			{
				return;
			}
			this.method_4(this.string_0);
			this.bool_0 = false;
		}

		// Token: 0x06000EEB RID: 3819
		// RVA: 0x00051588 File Offset: 0x0004F788
		private bool method_4(string string_1)
		{
			bool result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (KeyValuePair<string, string> current in this.dictionary_0)
				{
					stringBuilder.AppendLine(current.Key + " = " + current.Value);
				}
				File.WriteAllText(string_1, stringBuilder.ToString());
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000EE7 RID: 3815
		// RVA: 0x00051434 File Offset: 0x0004F634
		public void SetValue<T>(string string_1, T gparam_0)
		{
			string name;
			if ((name = typeof(T).Name) != null && name == "Boolean")
			{
				this.dictionary_0[string_1] = ((gparam_0.ToString() == "True") ? "1" : "0");
			}
			else
			{
				this.dictionary_0[string_1] = ((gparam_0 == null) ? null : gparam_0.ToString());
			}
			this.dictionary_1[string_1] = gparam_0;
			this.bool_0 = true;
			if (this.method_0())
			{
				this.method_3();
			}
		}
	}
}
