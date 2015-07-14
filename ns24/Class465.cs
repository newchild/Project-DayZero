using ns23;
using ns29;
using ns59;
using ns61;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x020003FE RID: 1022
	internal sealed class Class465 : Class461
	{
		// Token: 0x040019D7 RID: 6615
		[CompilerGenerated]
		private static Comparison<Class511> comparison_0;

		// Token: 0x040019D8 RID: 6616
		[CompilerGenerated]
		private static Comparison<double> comparison_1;

		// Token: 0x040019D6 RID: 6614
		private List<Class511> list_1;

		// Token: 0x060020C8 RID: 8392
		// RVA: 0x0001AAB2 File Offset: 0x00018CB2
		public Class465(Class296 class296_1) : base(class296_1)
		{
		}

		// Token: 0x060020CC RID: 8396
		// RVA: 0x000BE12C File Offset: 0x000BC32C
		protected bool method_3()
		{
			List<Class511>.Enumerator enumerator = this.list_1.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return false;
			}
			Class511 class511_ = enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class511 current = enumerator.Current;
				current.method_1(class511_, this.double_0);
				class511_ = current;
			}
			return true;
		}

		// Token: 0x060020CD RID: 8397
		// RVA: 0x000BE17C File Offset: 0x000BC37C
		protected double method_4()
		{
			double num = 400.0 * this.double_0;
			List<double> list = new List<double>();
			double num2 = num;
			double num3 = 0.0;
			Class511 class = null;
			foreach (Class511 current in this.list_1)
			{
				while ((double)current.class304_0.StartTime > num2)
				{
					list.Add(num3);
					if (class == null)
					{
						num3 = 0.0;
					}
					else
					{
						double num4 = Math.Pow(Class511.double_0, (num2 - (double)class.class304_0.StartTime) / 1000.0);
						num3 = class.double_1 * num4;
					}
					num2 += num;
				}
				if (current.double_1 > num3)
				{
					num3 = current.double_1;
				}
				class = current;
			}
			double num5 = 0.0;
			double num6 = 1.0;
			List<double> arg_103_0 = list;
			if (Class465.comparison_1 == null)
			{
				Class465.comparison_1 = new Comparison<double>(Class465.smethod_4);
			}
			arg_103_0.Sort(Class465.comparison_1);
			foreach (double num7 in list)
			{
				num5 += num6 * num7;
				num6 *= 0.9;
			}
			return num5;
		}

		// Token: 0x060020C9 RID: 8393
		// RVA: 0x0001AABB File Offset: 0x00018CBB
		public static Mods smethod_2()
		{
			return Mods.Easy | Mods.HardRock | Mods.DoubleTime | Mods.HalfTime;
		}

		// Token: 0x060020CE RID: 8398
		// RVA: 0x0001ABAE File Offset: 0x00018DAE
		[CompilerGenerated]
		private static int smethod_3(Class511 class511_0, Class511 class511_1)
		{
			return class511_0.class304_0.StartTime - class511_1.class304_0.StartTime;
		}

		// Token: 0x060020CF RID: 8399
		// RVA: 0x0001AB00 File Offset: 0x00018D00
		[CompilerGenerated]
		private static int smethod_4(double double_1, double double_2)
		{
			return double_2.CompareTo(double_1);
		}

		// Token: 0x060020CA RID: 8394
		// RVA: 0x0001ABA6 File Offset: 0x00018DA6
		internal override Class297 vmethod_1()
		{
			return new Class303(false);
		}

		// Token: 0x060020CB RID: 8395
		// RVA: 0x000BE01C File Offset: 0x000BC21C
		protected override double vmethod_4(Dictionary<string, string> dictionary_0)
		{
			this.list_1 = new List<Class511>(this.list_0.Count);
			foreach (Class304 current in this.list_0)
			{
				this.list_1.Add(new Class511(current));
			}
			List<Class511> arg_7A_0 = this.list_1;
			if (Class465.comparison_0 == null)
			{
				Class465.comparison_0 = new Comparison<Class511>(Class465.smethod_3);
			}
			arg_7A_0.Sort(Class465.comparison_0);
			if (!this.method_3())
			{
				return 0.0;
			}
			double result = this.method_4() * 0.04125;
			if (dictionary_0 != null)
			{
				dictionary_0.Add("Strain", result.ToString("0.00", Class115.numberFormatInfo_0));
				dictionary_0.Add("Hit window 300", ((double)this.class297_0.HitWindow300 / this.double_0).ToString("0.00", Class115.numberFormatInfo_0));
			}
			return result;
		}
	}
}
