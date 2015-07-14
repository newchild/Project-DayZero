using System;
using System.Collections.Generic;
using System.IO;

namespace ns15
{
	// Token: 0x020001B2 RID: 434
	internal sealed class Class53
	{
		// Token: 0x04000BCC RID: 3020
		public static Dictionary<string, string> dictionary_0;

		// Token: 0x06000F27 RID: 3879
		// RVA: 0x00052FBC File Offset: 0x000511BC
		public static void smethod_0()
		{
			if (Class53.dictionary_0 != null)
			{
				return;
			}
			Class53.dictionary_0 = new Dictionary<string, string>();
			if (!File.Exists("osu!.cfg"))
			{
				return;
			}
			StreamReader streamReader = File.OpenText("osu!.cfg");
			while (!streamReader.EndOfStream)
			{
				string[] array = streamReader.ReadLine().Split(new char[]
				{
					'='
				});
				if (array.Length >= 2)
				{
					Class53.dictionary_0[array[0].Trim()] = array[1].Trim();
				}
			}
			streamReader.Close();
		}

		// Token: 0x06000F28 RID: 3880
		// RVA: 0x0005303C File Offset: 0x0005123C
		public static void smethod_1()
		{
			Class53.smethod_0();
			StreamWriter streamWriter = new StreamWriter("osu!.cfg", false);
			foreach (KeyValuePair<string, string> current in Class53.dictionary_0)
			{
				streamWriter.WriteLine("{0} = {1}", current.Key, current.Value);
			}
			streamWriter.Close();
		}

		// Token: 0x06000F29 RID: 3881
		// RVA: 0x000530B8 File Offset: 0x000512B8
		internal static void smethod_2()
		{
			List<string> list = new List<string>();
			foreach (string current in Class53.dictionary_0.Keys)
			{
				if (current.StartsWith("h_"))
				{
					list.Add(current);
				}
			}
			foreach (string current2 in list)
			{
				Class53.dictionary_0.Remove(current2);
			}
			Class53.smethod_1();
		}
	}
}
