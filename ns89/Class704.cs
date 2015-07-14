using ns26;
using osu.GameplayElements.Events;
using System;

namespace ns89
{
	// Token: 0x02000535 RID: 1333
	internal sealed class Class704 : Class702, IComparable<Class704>
	{
		// Token: 0x040023E0 RID: 9184
		internal bool bool_3;

		// Token: 0x040023DE RID: 9182
		internal Class338 class338_0;

		// Token: 0x040023DD RID: 9181
		internal int int_3;

		// Token: 0x040023DF RID: 9183
		internal int int_4;

		// Token: 0x06002B26 RID: 11046
		// RVA: 0x00117728 File Offset: 0x00115928
		internal Class704(int int_5, string string_1, int int_6, StoryLayer storyLayer_1, int int_7)
		{
			this.int_3 = int_7;
			this.eventTypes_0 = EventTypes.Sample;
			this.string_0 = string_1;
			this.int_4 = int_5;
			this.int_2 = int_6;
			this.storyLayer_0 = storyLayer_1;
			this.class338_0 = new Class338(this.int_2, this.int_4, this.int_3, true);
		}

		// Token: 0x06002B2A RID: 11050
		// RVA: 0x00117788 File Offset: 0x00115988
		internal override Class702 Clone()
		{
			return new Class704(this.int_4, this.string_0, this.int_2, this.storyLayer_0, this.int_3)
			{
				bool_2 = this.bool_2
			};
		}

		// Token: 0x06002B2C RID: 11052
		// RVA: 0x0002106D File Offset: 0x0001F26D
		public int CompareTo(Class704 obj)
		{
			return this.int_2.CompareTo(obj.int_2);
		}

		// Token: 0x06002B27 RID: 11047
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool Load()
		{
			return false;
		}

		// Token: 0x06002B2B RID: 11051
		// RVA: 0x001177C8 File Offset: 0x001159C8
		public override string ToString()
		{
			int num = this.int_2 / 1000 / 60;
			int num2 = (this.int_2 - num * 1000 * 60) / 1000;
			int num3 = this.int_2 - num * 1000 * 60 - num2 * 1000;
			return string.Format("{0}:{1}:{2}  {3}@{4}%", new object[]
			{
				num,
				num2,
				num3,
				this.string_0,
				this.int_3
			});
		}

		// Token: 0x06002B28 RID: 11048
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_0(int int_5)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002B29 RID: 11049
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_1(int int_5)
		{
			throw new NotImplementedException();
		}
	}
}
