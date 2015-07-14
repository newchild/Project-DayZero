using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ns37
{
	// Token: 0x0200024A RID: 586
	internal sealed class Class186 : Interface12
	{
		// Token: 0x04000F18 RID: 3864
		private ArrayList arrayList_0;

		// Token: 0x04000F19 RID: 3865
		private ArrayList arrayList_1;

		// Token: 0x04000F17 RID: 3863
		private string string_0;

		// Token: 0x0600146C RID: 5228
		// RVA: 0x00012656 File Offset: 0x00010856
		public Class186(string string_1)
		{
			this.string_0 = string_1;
			this.arrayList_0 = new ArrayList();
			this.arrayList_1 = new ArrayList();
			this.method_2();
		}

		// Token: 0x06001470 RID: 5232
		// RVA: 0x00012689 File Offset: 0x00010889
		public bool IsMatch(string string_1)
		{
			return this.method_0(string_1) && !this.method_1(string_1);
		}

		// Token: 0x0600146E RID: 5230
		// RVA: 0x00068A6C File Offset: 0x00066C6C
		public bool method_0(string string_1)
		{
			bool result = false;
			if (this.arrayList_0.Count == 0)
			{
				result = true;
			}
			else
			{
				foreach (Regex regex in this.arrayList_0)
				{
					if (regex.IsMatch(string_1))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600146F RID: 5231
		// RVA: 0x00068AE0 File Offset: 0x00066CE0
		public bool method_1(string string_1)
		{
			bool result = false;
			foreach (Regex regex in this.arrayList_1)
			{
				if (regex.IsMatch(string_1))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001471 RID: 5233
		// RVA: 0x00068B44 File Offset: 0x00066D44
		private void method_2()
		{
			if (this.string_0 == null)
			{
				return;
			}
			string[] array = this.string_0.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].Length > 0)
				{
					bool flag = array[i][0] != '-';
					string pattern;
					if (array[i][0] == '+')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else if (array[i][0] == '-')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else
					{
						pattern = array[i];
					}
					if (flag)
					{
						this.arrayList_0.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
					}
					else
					{
						this.arrayList_1.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
					}
				}
			}
		}

		// Token: 0x0600146D RID: 5229
		// RVA: 0x00012681 File Offset: 0x00010881
		public override string ToString()
		{
			return this.string_0;
		}
	}
}
