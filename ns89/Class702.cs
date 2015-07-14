using ns75;
using ns79;
using osu.GameplayElements.Events;
using System;
using System.Collections.Generic;

namespace ns89
{
	// Token: 0x02000533 RID: 1331
	internal abstract class Class702 : IComparable<Class702>
	{
		// Token: 0x040023CD RID: 9165
		internal bool bool_0;

		// Token: 0x040023D0 RID: 9168
		public bool bool_1;

		// Token: 0x040023D2 RID: 9170
		internal bool bool_2;

		// Token: 0x040023CE RID: 9166
		internal Class531 class531_0;

		// Token: 0x040023C9 RID: 9161
		internal Dictionary<TriggerGroup, List<Class744>> dictionary_0 = new Dictionary<TriggerGroup, List<Class744>>();

		// Token: 0x040023D1 RID: 9169
		internal EventTypes eventTypes_0;

		// Token: 0x040023C8 RID: 9160
		internal int int_0;

		// Token: 0x040023CB RID: 9163
		internal int int_1;

		// Token: 0x040023CF RID: 9167
		internal int int_2;

		// Token: 0x040023CC RID: 9164
		internal StoryLayer storyLayer_0;

		// Token: 0x040023CA RID: 9162
		internal string string_0;

		// Token: 0x17000392 RID: 914
		internal virtual int Length
		{
			// Token: 0x06002B14 RID: 11028
			// RVA: 0x0002104B File Offset: 0x0001F24B
			get
			{
				return this.int_0 - this.int_2;
			}
		}

		// Token: 0x06002B18 RID: 11032
		internal abstract Class702 Clone();

		// Token: 0x06002B1D RID: 11037
		// RVA: 0x001173B8 File Offset: 0x001155B8
		public int CompareTo(Class702 obj)
		{
			int num = this.int_2.CompareTo(obj.int_2);
			if (num != 0)
			{
				return num;
			}
			return this.eventTypes_0.CompareTo(obj.eventTypes_0);
		}

		// Token: 0x06002B17 RID: 11031
		internal abstract bool Load();

		// Token: 0x06002B19 RID: 11033
		// RVA: 0x00117200 File Offset: 0x00115400
		internal void method_0(Class744 class744_0)
		{
			Class477 class477_ = class744_0.class477_0;
			List<Class744> list;
			if (!this.dictionary_0.TryGetValue(class477_.method_1(), out list))
			{
				list = new List<Class744>();
				this.dictionary_0.Add(class477_.method_1(), list);
			}
			list.Add(class744_0);
			this.class531_0.bool_0 = true;
			this.class531_0.float_3 = 0f;
			class477_.vmethod_1(this, class744_0, this.class531_0);
		}

		// Token: 0x06002B1A RID: 11034
		// RVA: 0x00117274 File Offset: 0x00115474
		internal void method_1(TriggerGroup triggerGroup_0)
		{
			List<Class744> list;
			if (this.dictionary_0.TryGetValue(triggerGroup_0, out list))
			{
				foreach (Class744 current in list)
				{
					this.method_2(current);
				}
			}
		}

		// Token: 0x06002B1B RID: 11035
		// RVA: 0x001172D4 File Offset: 0x001154D4
		internal void method_2(Class744 class744_0)
		{
			List<Class746> list = class744_0.method_0();
			if (list != null)
			{
				foreach (Class746 current in list)
				{
					this.class531_0.class26_0.Remove(current);
				}
			}
		}

		// Token: 0x06002B1C RID: 11036
		// RVA: 0x00117338 File Offset: 0x00115538
		internal void method_3()
		{
			if (this.dictionary_0.Count <= 0)
			{
				return;
			}
			Dictionary<TriggerGroup, List<Class744>> dictionary = this.dictionary_0;
			this.dictionary_0 = new Dictionary<TriggerGroup, List<Class744>>();
			foreach (List<Class744> current in dictionary.Values)
			{
				current.ForEach(new Action<Class744>(this.method_0));
			}
		}

		// Token: 0x06002B15 RID: 11029
		internal abstract void vmethod_0(int int_3);

		// Token: 0x06002B16 RID: 11030
		internal abstract void vmethod_1(int int_3);
	}
}
