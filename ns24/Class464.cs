using ns23;
using ns29;
using ns59;
using ns60;
using osu.GameplayElements.HitObjects;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x020003FC RID: 1020
	internal sealed class Class464 : Class461
	{
		// Token: 0x020003FD RID: 1021
		internal enum Enum46
		{
			// Token: 0x040019D4 RID: 6612
			const_0,
			// Token: 0x040019D5 RID: 6613
			const_1
		}

		// Token: 0x040019D1 RID: 6609
		[CompilerGenerated]
		private static Comparison<Class510> comparison_0;

		// Token: 0x040019D2 RID: 6610
		[CompilerGenerated]
		private static Comparison<double> comparison_1;

		// Token: 0x040019D0 RID: 6608
		private List<Class510> list_1;

		// Token: 0x060020BF RID: 8383
		// RVA: 0x0001AAB2 File Offset: 0x00018CB2
		public Class464(Class296 class296_1) : base(class296_1)
		{
		}

		// Token: 0x060020C4 RID: 8388
		// RVA: 0x000BDE48 File Offset: 0x000BC048
		protected bool method_3()
		{
			List<Class510>.Enumerator enumerator = this.list_1.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return false;
			}
			Class510 class510_ = enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class510 current = enumerator.Current;
				current.method_0(class510_, this.double_0);
				class510_ = current;
			}
			return true;
		}

		// Token: 0x060020C5 RID: 8389
		// RVA: 0x000BDE98 File Offset: 0x000BC098
		protected double method_4(Class464.Enum46 enum46_0)
		{
			double num = 400.0 * this.double_0;
			List<double> list = new List<double>();
			double num2 = num;
			double num3 = 0.0;
			Class510 class = null;
			foreach (Class510 current in this.list_1)
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
						double num4 = Math.Pow(Class510.double_0[(int)enum46_0], (num2 - (double)class.class304_0.StartTime) / 1000.0);
						num3 = class.double_2[(int)enum46_0] * num4;
					}
					num2 += num;
				}
				if (current.double_2[(int)enum46_0] > num3)
				{
					num3 = current.double_2[(int)enum46_0];
				}
				class = current;
			}
			double num5 = 0.0;
			double num6 = 1.0;
			List<double> arg_10E_0 = list;
			if (Class464.comparison_1 == null)
			{
				Class464.comparison_1 = new Comparison<double>(Class464.smethod_4);
			}
			arg_10E_0.Sort(Class464.comparison_1);
			foreach (double num7 in list)
			{
				num5 += num6 * num7;
				num6 *= 0.9;
			}
			return num5;
		}

		// Token: 0x060020C0 RID: 8384
		// RVA: 0x0001AABB File Offset: 0x00018CBB
		public static Mods smethod_2()
		{
			return Mods.Easy | Mods.HardRock | Mods.DoubleTime | Mods.HalfTime;
		}

		// Token: 0x060020C6 RID: 8390
		// RVA: 0x0001AB8D File Offset: 0x00018D8D
		[CompilerGenerated]
		private static int smethod_3(Class510 class510_0, Class510 class510_1)
		{
			return class510_0.class304_0.StartTime - class510_1.class304_0.StartTime;
		}

		// Token: 0x060020C7 RID: 8391
		// RVA: 0x0001AB00 File Offset: 0x00018D00
		[CompilerGenerated]
		private static int smethod_4(double double_1, double double_2)
		{
			return double_2.CompareTo(double_1);
		}

		// Token: 0x060020C1 RID: 8385
		// RVA: 0x0001AB85 File Offset: 0x00018D85
		internal override Class297 vmethod_1()
		{
			return new Class298(false);
		}

		// Token: 0x060020C2 RID: 8386
		// RVA: 0x000BDB50 File Offset: 0x000BBD50
		protected override void vmethod_3()
		{
			foreach (Class304 current in this.list_0)
			{
				if (current.IsType(HitObjectType.Slider))
				{
					((Class321)current).vmethod_24(false);
				}
			}
		}

		// Token: 0x060020C3 RID: 8387
		// RVA: 0x000BDBB4 File Offset: 0x000BBDB4
		protected override double vmethod_4(Dictionary<string, string> dictionary_0)
		{
			this.list_1 = new List<Class510>(this.list_0.Count);
			float float_ = 32f * (1f - 0.7f * (float)this.class297_0.AdjustDifficulty((double)this.class296_0.DifficultyCircleSize));
			foreach (Class304 current in this.list_0)
			{
				this.list_1.Add(new Class510(current, float_));
			}
			List<Class510> arg_A7_0 = this.list_1;
			if (Class464.comparison_0 == null)
			{
				Class464.comparison_0 = new Comparison<Class510>(Class464.smethod_3);
			}
			arg_A7_0.Sort(Class464.comparison_0);
			if (!this.method_3())
			{
				return 0.0;
			}
			double d = this.method_4(Class464.Enum46.const_0);
			double d2 = this.method_4(Class464.Enum46.const_1);
			double num = Math.Sqrt(d) * 0.0675;
			double num2 = Math.Sqrt(d2) * 0.0675;
			if (dictionary_0 != null)
			{
				dictionary_0.Add("Aim", num2.ToString("0.00", Class115.numberFormatInfo_0));
				dictionary_0.Add("Speed", num.ToString("0.00", Class115.numberFormatInfo_0));
				double num3 = (double)this.class297_0.HitWindow300 / this.double_0;
				double num4 = (double)this.class297_0.PreEmpt / this.double_0;
				dictionary_0.Add("OD", (-(num3 - 80.0) / 6.0).ToString("0.00", Class115.numberFormatInfo_0));
				dictionary_0.Add("AR", ((num4 > 1200.0) ? (-(num4 - 1800.0) / 120.0) : (-(num4 - 1200.0) / 150.0 + 5.0)).ToString("0.00", Class115.numberFormatInfo_0));
				int num5 = 0;
				foreach (Class510 current2 in this.list_1)
				{
					num5 += current2.int_0;
				}
				dictionary_0.Add("Max combo", num5.ToString(Class115.numberFormatInfo_0));
			}
			return num + num2 + Math.Abs(num - num2) * 0.5;
		}
	}
}
