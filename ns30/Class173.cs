using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;

namespace ns30
{
	// Token: 0x02000226 RID: 550
	internal sealed class Class173 : StringCollection
	{
		// Token: 0x0600136A RID: 4970
		// RVA: 0x00011FC9 File Offset: 0x000101C9
		public bool Contains(string string_0, bool bool_0)
		{
			if (!bool_0)
			{
				return base.Contains(string_0);
			}
			return this.method_1(string_0);
		}

		// Token: 0x06001369 RID: 4969
		// RVA: 0x000640F0 File Offset: 0x000622F0
		public bool method_0(string string_0, bool bool_0)
		{
			string[] array = Class174.smethod_0(string_0);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (bool_0 && base.Count > 0)
				{
					int index = base.Count - 1;
					this[index] += text;
					bool_0 = false;
				}
				else
				{
					base.Add(text);
				}
			}
			if (string_0.Length == 1)
			{
				if (string_0[0] != '\n')
				{
					return true;
				}
			}
			return string_0.Length > 1 && string_0[string_0.Length - 2] != '\r' && string_0[string_0.Length - 1] != '\n';
		}

		// Token: 0x0600136B RID: 4971
		// RVA: 0x000641A0 File Offset: 0x000623A0
		private bool method_1(string string_0)
		{
			StringEnumerator enumerator = base.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (string.Compare(enumerator.Current, string_0, true, CultureInfo.InvariantCulture) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600136C RID: 4972
		// RVA: 0x00011FDD File Offset: 0x000101DD
		public bool method_2(Stream stream_0, string string_0)
		{
			return this.method_3(stream_0, 0L, false, string_0);
		}

		// Token: 0x0600136D RID: 4973
		// RVA: 0x000641D8 File Offset: 0x000623D8
		public bool method_3(Stream stream_0, long long_0, bool bool_0, string string_0)
		{
			if (long_0 == 0L)
			{
				long_0 = stream_0.Length;
			}
			if (long_0 > 0L)
			{
				byte[] array = new byte[long_0];
				stream_0.Read(array, 0, (int)long_0);
				return this.method_0(Class175.GetString(array, string_0), bool_0);
			}
			return false;
		}

		// Token: 0x0600136E RID: 4974
		// RVA: 0x0006422C File Offset: 0x0006242C
		public string[] ToArray()
		{
			string[] array = new string[base.Count];
			base.CopyTo(array, 0);
			return array;
		}

		// Token: 0x0600136F RID: 4975
		// RVA: 0x00064250 File Offset: 0x00062450
		public override string ToString()
		{
			string[] array = new string[base.Count];
			base.CopyTo(array, 0);
			return string.Join("\r\n", array) + "\r\n";
		}
	}
}
