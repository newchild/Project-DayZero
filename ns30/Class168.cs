using System;
using System.Collections;

namespace ns30
{
	// Token: 0x02000217 RID: 535
	internal sealed class Class168 : CollectionBase
	{
		// Token: 0x04000E75 RID: 3701
		private Class167 class167_0;

		// Token: 0x170002C2 RID: 706
		public Class147 this[int int_0]
		{
			// Token: 0x06001318 RID: 4888
			// RVA: 0x00011CC2 File Offset: 0x0000FEC2
			get
			{
				return (Class147)base.InnerList[int_0];
			}
		}

		// Token: 0x0600130F RID: 4879
		// RVA: 0x00011C1A File Offset: 0x0000FE1A
		public Class168(Class167 class167_1)
		{
			this.class167_0 = class167_1;
		}

		// Token: 0x06001310 RID: 4880
		// RVA: 0x00010CDD File Offset: 0x0000EEDD
		public void Add(Class147 class147_0)
		{
			base.List.Add(class147_0);
		}

		// Token: 0x06001311 RID: 4881
		// RVA: 0x000637A4 File Offset: 0x000619A4
		public Class148 method_0(string string_0, string string_1)
		{
			Class148 class = new Class148(string_0, string_1);
			this.Add(class);
			return class;
		}

		// Token: 0x06001312 RID: 4882
		// RVA: 0x000637C4 File Offset: 0x000619C4
		public Class149 method_1(string string_0, string string_1)
		{
			Class149 class = new Class149(string_0, string_1);
			this.Add(class);
			return class;
		}

		// Token: 0x06001317 RID: 4887
		// RVA: 0x00011CAD File Offset: 0x0000FEAD
		public void method_2()
		{
			if (this.method_3() != null)
			{
				this.method_3().method_13();
			}
		}

		// Token: 0x06001319 RID: 4889
		// RVA: 0x00011CD5 File Offset: 0x0000FED5
		public Class167 method_3()
		{
			return this.class167_0;
		}

		// Token: 0x06001313 RID: 4883
		// RVA: 0x000637E4 File Offset: 0x000619E4
		protected override void OnClear()
		{
			base.OnClear();
			foreach (Class147 class in base.InnerList)
			{
				class.class167_0 = null;
			}
		}

		// Token: 0x06001314 RID: 4884
		// RVA: 0x00011C29 File Offset: 0x0000FE29
		protected override void OnClearComplete()
		{
			base.OnClearComplete();
			if (this.method_3() != null)
			{
				this.method_3().method_14();
			}
			this.method_2();
		}

		// Token: 0x06001315 RID: 4885
		// RVA: 0x00011C4A File Offset: 0x0000FE4A
		protected override void OnInsertComplete(int index, object value)
		{
			base.OnInsertComplete(index, value);
			((Class147)value).class167_0 = this.method_3();
			if (this.method_3() != null)
			{
				this.method_3().method_14();
			}
			this.method_2();
		}

		// Token: 0x06001316 RID: 4886
		// RVA: 0x00011C7E File Offset: 0x0000FE7E
		protected override void OnRemoveComplete(int index, object value)
		{
			base.OnRemoveComplete(index, value);
			((Class147)value).class167_0 = null;
			if (this.method_3() != null)
			{
				this.method_3().method_14();
			}
			this.method_2();
		}
	}
}
