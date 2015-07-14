using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace ns30
{
	// Token: 0x02000207 RID: 519
	internal sealed class Class158 : IEnumerable, ICollection
	{
		// Token: 0x04000E0B RID: 3595
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x170002B7 RID: 695
		public int Count
		{
			// Token: 0x06001236 RID: 4662
			// RVA: 0x000110F2 File Offset: 0x0000F2F2
			get
			{
				return this.arrayList_0.Count;
			}
		}

		// Token: 0x170002B9 RID: 697
		public bool IsSynchronized
		{
			// Token: 0x06001237 RID: 4663
			// RVA: 0x000110FF File Offset: 0x0000F2FF
			get
			{
				return this.arrayList_0.IsSynchronized;
			}
		}

		// Token: 0x170002B5 RID: 693
		public Class157 this[string string_0]
		{
			// Token: 0x06001238 RID: 4664
			// RVA: 0x000613F0 File Offset: 0x0005F5F0
			get
			{
				int num = this.IndexOf(string_0);
				if (num >= 0)
				{
					return (Class157)this.arrayList_0[num];
				}
				return null;
			}
		}

		// Token: 0x170002B6 RID: 694
		public Class157 this[int int_0]
		{
			// Token: 0x06001239 RID: 4665
			// RVA: 0x0001110C File Offset: 0x0000F30C
			get
			{
				return (Class157)this.arrayList_0[int_0];
			}
		}

		// Token: 0x170002B8 RID: 696
		public object SyncRoot
		{
			// Token: 0x0600123A RID: 4666
			// RVA: 0x0001111F File Offset: 0x0000F31F
			get
			{
				return this.arrayList_0.SyncRoot;
			}
		}

		// Token: 0x06001226 RID: 4646
		// RVA: 0x00011074 File Offset: 0x0000F274
		public void Add(Class157 class157_0)
		{
			this.arrayList_0.Add(class157_0);
		}

		// Token: 0x06001227 RID: 4647
		// RVA: 0x00011083 File Offset: 0x0000F283
		public void Add(string string_0, string string_1)
		{
			this.Add(new Class157(string_0, string_1));
		}

		// Token: 0x06001229 RID: 4649
		// RVA: 0x00011092 File Offset: 0x0000F292
		public void Clear()
		{
			this.arrayList_0.Clear();
		}

		// Token: 0x0600122A RID: 4650
		// RVA: 0x0001109F File Offset: 0x0000F29F
		public void CopyTo(Array array, int index)
		{
			this.arrayList_0.CopyTo(array, index);
		}

		// Token: 0x0600122C RID: 4652
		// RVA: 0x000110AE File Offset: 0x0000F2AE
		public IEnumerator GetEnumerator()
		{
			return this.arrayList_0.GetEnumerator();
		}

		// Token: 0x06001231 RID: 4657
		// RVA: 0x00061210 File Offset: 0x0005F410
		private int IndexOf(string string_0)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (string.Compare(string_0, ((Class157)this.arrayList_0[i]).Name, true, CultureInfo.InvariantCulture) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001233 RID: 4659
		// RVA: 0x000110D4 File Offset: 0x0000F2D4
		public void Remove(Class157 class157_0)
		{
			this.arrayList_0.Remove(class157_0);
		}

		// Token: 0x06001228 RID: 4648
		// RVA: 0x00060F78 File Offset: 0x0005F178
		public static void smethod_0(StringCollection stringCollection_0, string string_0, string string_1)
		{
			if (!Class174.smethod_2(string_1))
			{
				string_1 = string_1.Replace("\r\n", "\r\n\t");
				if (string_1[string_1.Length - 1] == '\t')
				{
					string_1 = string_1.Substring(0, string_1.Length - 1);
				}
				stringCollection_0.AddRange(Class174.smethod_0(string.Format("{0}: {1}", string_0, string_1)));
			}
		}

		// Token: 0x0600122B RID: 4651
		// RVA: 0x00060FDC File Offset: 0x0005F1DC
		private static string smethod_1(string string_0, string string_1)
		{
			string text = Class158.smethod_6(string_0, string_1).Trim();
			if (text.Length != 0)
			{
				if (text[0] == '"' || text[0] == '\'')
				{
					if (text[text.Length - 1] != '"' && text[text.Length - 1] != '\'')
					{
						return text;
					}
					return text.Substring(1, text.Length - 2);
				}
			}
			return text;
		}

		// Token: 0x0600122D RID: 4653
		// RVA: 0x00061050 File Offset: 0x0005F250
		public static int smethod_2(int int_0, IList ilist_0, Class158 class158_0)
		{
			if (ilist_0 == null)
			{
				return int_0;
			}
			for (int i = int_0; i < ilist_0.Count; i++)
			{
				string text = (string)ilist_0[i];
				if (Class174.smethod_2(text))
				{
					return i;
				}
				if (text[0] != '\t' && text[0] != ' ')
				{
					int num = text.IndexOf(":");
					if (num >= 0)
					{
						class158_0.Add(text.Substring(0, num), i.ToString(CultureInfo.InvariantCulture));
					}
				}
			}
			return ilist_0.Count;
		}

		// Token: 0x0600122E RID: 4654
		// RVA: 0x000610D0 File Offset: 0x0005F2D0
		public static string smethod_3(IList ilist_0, Class157 class157_0)
		{
			string text = string.Empty;
			if (class157_0 != null && class157_0.Value != null)
			{
				int num = Convert.ToInt32(class157_0.Value, CultureInfo.InvariantCulture);
				text = ((string)ilist_0[num]).Substring(class157_0.Name.Length + ":".Length).TrimStart(new char[0]);
				for (int i = num + 1; i < ilist_0.Count; i++)
				{
					string text2 = (string)ilist_0[i];
					if (text2.Length == 0)
					{
						return text;
					}
					if (!text2[0].Equals('\t') && !text2[0].Equals(' '))
					{
						return text;
					}
					text += text2.Trim();
				}
			}
			return text;
		}

		// Token: 0x0600122F RID: 4655
		// RVA: 0x000110BB File Offset: 0x0000F2BB
		public static string smethod_4(IList ilist_0, Class158 class158_0, string string_0)
		{
			return Class158.smethod_3(ilist_0, class158_0[string_0.ToLower(CultureInfo.InvariantCulture)]);
		}

		// Token: 0x06001230 RID: 4656
		// RVA: 0x0006119C File Offset: 0x0005F39C
		public static string smethod_5(string string_0, string string_1)
		{
			string text = Class158.smethod_1(string_0, string_1).Trim();
			if (!Class174.smethod_2(text))
			{
				if (text[0] == '\'' || text[0] == '"')
				{
					if (text[text.Length - 1] != '\'' && text[text.Length - 1] != '"')
					{
						return text;
					}
					return text.Substring(1, text.Length - 1);
				}
			}
			return text;
		}

		// Token: 0x06001232 RID: 4658
		// RVA: 0x00061258 File Offset: 0x0005F458
		private static string smethod_6(string string_0, string string_1)
		{
			string text = string.Empty;
			int num;
			if (string_1.Length == 0 && string_0.Length != 0)
			{
				num = 0;
			}
			else
			{
				num = string_0.ToLower(CultureInfo.InvariantCulture).IndexOf(string_1);
			}
			if (num >= 0)
			{
				text = string_0.Substring(num + string_1.Length);
				bool flag = false;
				string text2 = string.Empty;
				for (int i = 0; i < text.Length; i++)
				{
					if (text2.Length == 0 && (text[i].Equals('\'') || text[i].Equals('"')))
					{
						text2 = text[i].ToString(CultureInfo.InvariantCulture);
						flag = !flag;
					}
					else if (text2.Length != 0 && text[i].Equals(text2[0]))
					{
						flag = !flag;
					}
					if (!flag && (text[i].Equals(';') || text[i].Equals(',')))
					{
						return text.Substring(0, i);
					}
				}
			}
			return text;
		}

		// Token: 0x06001234 RID: 4660
		// RVA: 0x0006137C File Offset: 0x0005F57C
		public static void smethod_7(StringCollection stringCollection_0, Class158 class158_0, Class157 class157_0)
		{
			if (class157_0 != null)
			{
				class158_0.Remove(class157_0);
				int i = int.Parse(class157_0.Value);
				stringCollection_0.RemoveAt(i);
				while (i < stringCollection_0.Count)
				{
					if (Class174.smethod_2(stringCollection_0[i]))
					{
						break;
					}
					if (stringCollection_0[i][0] != '\t' && stringCollection_0[i][0] != ' ')
					{
						return;
					}
					stringCollection_0.RemoveAt(i);
				}
			}
		}

		// Token: 0x06001235 RID: 4661
		// RVA: 0x000110E2 File Offset: 0x0000F2E2
		public static void smethod_8(StringCollection stringCollection_0, Class158 class158_0, string string_0)
		{
			Class158.smethod_7(stringCollection_0, class158_0, class158_0[string_0]);
		}
	}
}
