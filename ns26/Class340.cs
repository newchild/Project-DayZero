using ns14;
using ns24;
using ns8;
using osu.Audio;
using osu_common.Bancho;
using System;

namespace ns26
{
	// Token: 0x0200034A RID: 842
	internal sealed class Class340 : ICloneable, IComparable<Class340>, bSerializable
	{
		// Token: 0x04001377 RID: 4983
		private bool bool_0 = true;

		// Token: 0x04001371 RID: 4977
		internal double double_0;

		// Token: 0x04001373 RID: 4979
		internal double double_1;

		// Token: 0x04001375 RID: 4981
		internal Enum37 enum37_0;

		// Token: 0x04001372 RID: 4978
		internal Enum38 enum38_0;

		// Token: 0x04001378 RID: 4984
		internal Enum39 enum39_0;

		// Token: 0x04001376 RID: 4982
		internal int int_0;

		// Token: 0x04001374 RID: 4980
		internal SampleSet sampleSet_0;

		// Token: 0x06001967 RID: 6503
		// RVA: 0x0001599C File Offset: 0x00013B9C
		public Class340()
		{
		}

		// Token: 0x06001966 RID: 6502
		// RVA: 0x0007908C File Offset: 0x0007728C
		internal Class340(double double_2, double double_3) : this(double_2, double_3, Enum37.const_0, (Class331.sampleSet_0 != SampleSet.None) ? Class331.sampleSet_0 : Class466.Current.sampleSet_0, Class331.smethod_74(), (Class466.Current != null) ? Class466.Current.int_15 : 100, true, Enum39.flag_0)
		{
		}

		// Token: 0x06001968 RID: 6504
		// RVA: 0x000790D8 File Offset: 0x000772D8
		internal Class340(double double_2, double double_3, Enum37 enum37_1, SampleSet sampleSet_1, Enum38 enum38_1, int int_1, bool bool_1, Enum39 enum39_1)
		{
			this.double_1 = double_2;
			this.double_0 = double_3;
			this.enum37_0 = enum37_1;
			this.sampleSet_0 = ((sampleSet_1 == SampleSet.None) ? SampleSet.Soft : sampleSet_1);
			this.enum38_0 = enum38_1;
			this.int_0 = int_1;
			this.method_1(bool_1);
			this.enum39_0 = enum39_1;
		}

		// Token: 0x0600196B RID: 6507
		// RVA: 0x000159D8 File Offset: 0x00013BD8
		public object Clone()
		{
			return new Class340(this.double_1, this.double_0, this.enum37_0, this.sampleSet_0, this.enum38_0, this.int_0, this.method_0(), this.enum39_0);
		}

		// Token: 0x0600196C RID: 6508
		// RVA: 0x000791EC File Offset: 0x000773EC
		public int CompareTo(Class340 obj)
		{
			if (this.double_1 == obj.double_1)
			{
				return obj.method_0().CompareTo(this.method_0());
			}
			return this.double_1.CompareTo(obj.double_1);
		}

		// Token: 0x0600196A RID: 6506
		// RVA: 0x00079138 File Offset: 0x00077338
		public override bool Equals(object obj)
		{
			Class340 class = (Class340)obj;
			return Math.Abs(class.double_1 - this.double_1) <= 4.94065645841247E-324 && class.method_0() == this.method_0() && Math.Abs(class.double_0 - this.double_0) <= 4.94065645841247E-324 && class.method_2() == this.method_2() && class.sampleSet_0 == this.sampleSet_0 && class.enum37_0 == this.enum37_0 && class.int_0 == this.int_0 && class.enum38_0 == this.enum38_0;
		}

		// Token: 0x06001961 RID: 6497
		// RVA: 0x00015902 File Offset: 0x00013B02
		internal bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06001962 RID: 6498
		// RVA: 0x0001590A File Offset: 0x00013B0A
		internal void method_1(bool bool_1)
		{
			if (!bool_1 && this.double_0 >= 0.0)
			{
				this.double_0 = -100.0;
			}
			this.bool_0 = bool_1;
		}

		// Token: 0x06001963 RID: 6499
		// RVA: 0x00015936 File Offset: 0x00013B36
		internal bool method_2()
		{
			return (this.enum39_0 & Enum39.flag_1) > Enum39.flag_0;
		}

		// Token: 0x06001964 RID: 6500
		// RVA: 0x00015943 File Offset: 0x00013B43
		internal void method_3(bool bool_1)
		{
			if (bool_1)
			{
				this.enum39_0 |= Enum39.flag_1;
				return;
			}
			this.enum39_0 &= ~Enum39.flag_1;
		}

		// Token: 0x06001965 RID: 6501
		// RVA: 0x00015966 File Offset: 0x00013B66
		internal float method_4()
		{
			if (this.double_0 >= 0.0)
			{
				return 1f;
			}
			return Class778.smethod_2((float)(-(float)this.double_0), 10f, 1000f) / 100f;
		}

		// Token: 0x06001969 RID: 6505
		// RVA: 0x000159AB File Offset: 0x00013BAB
		internal double method_5()
		{
			if (this.double_0 != 0.0)
			{
				return 60000.0 / this.double_0;
			}
			return 0.0;
		}

		// Token: 0x0600196E RID: 6510
		// RVA: 0x00015A0F File Offset: 0x00013C0F
		public void ReadFromStream(Class32 class32_0)
		{
			this.double_0 = class32_0.ReadDouble();
			this.double_1 = class32_0.ReadDouble();
			this.method_1(class32_0.ReadBoolean());
		}

		// Token: 0x0600196D RID: 6509
		// RVA: 0x00079230 File Offset: 0x00077430
		public override string ToString()
		{
			return string.Format("{5}{0:00}:{1:00}:{2:00} {3}/4 {4} {6}{7}{8}", new object[]
			{
				(int)this.double_1 / 60000,
				(int)this.double_1 % 60000 / 1000,
				(int)this.double_1 % 1000 / 10,
				(int)this.enum37_0,
				(this.double_0 < 0.0) ? (Math.Round(-100.0 / this.double_0, 2) + "x sm") : ((60000.0 / this.double_0).ToString("N") + "bpm"),
				(!this.method_0()) ? "^ " : string.Empty,
				(this.sampleSet_0 == SampleSet.Soft) ? "S" : "N",
				(this.enum38_0 == Enum38.const_1) ? ":C1" : ((this.enum38_0 == Enum38.const_2) ? ":C2" : string.Empty),
				this.method_2() ? " Ki" : string.Empty
			});
		}

		// Token: 0x0600196F RID: 6511
		// RVA: 0x00015A35 File Offset: 0x00013C35
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.double_0);
			class31_0.Write(this.double_1);
			class31_0.Write(this.method_0());
		}
	}
}
