using ns23;
using ns29;
using ns59;
using ns63;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x020003FA RID: 1018
	internal sealed class Class462 : Class461
	{
		// Token: 0x040019CA RID: 6602
		[CompilerGenerated]
		private static Comparison<Class491> comparison_0;

		// Token: 0x040019CB RID: 6603
		[CompilerGenerated]
		private static Comparison<double> comparison_1;

		// Token: 0x040019C9 RID: 6601
		private List<Class491> list_1;

		// Token: 0x060020AB RID: 8363
		// RVA: 0x0001AAB2 File Offset: 0x00018CB2
		public Class462(Class296 class296_1) : base(class296_1)
		{
		}

		// Token: 0x060020B0 RID: 8368
		// RVA: 0x000BD5C0 File Offset: 0x000BB7C0
		protected bool method_3()
		{
			List<Class491>.Enumerator enumerator = this.list_1.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return false;
			}
			Class491 class491_ = enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class491 current = enumerator.Current;
				current.method_1(class491_, this.double_0);
				class491_ = current;
			}
			return true;
		}

		// Token: 0x060020B1 RID: 8369
		// RVA: 0x000BD610 File Offset: 0x000BB810
		protected double method_4()
		{
			double num = 750.0 * this.double_0;
			List<double> list = new List<double>();
			double num2 = num;
			double num3 = 0.0;
			Class491 class = null;
			foreach (Class491 current in this.list_1)
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
						double num4 = Math.Pow(Class491.double_0, (num2 - (double)class.class304_0.StartTime) / 1000.0);
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
			if (Class462.comparison_1 == null)
			{
				Class462.comparison_1 = new Comparison<double>(Class462.smethod_4);
			}
			arg_103_0.Sort(Class462.comparison_1);
			foreach (double num7 in list)
			{
				num5 += num6 * num7;
				num6 *= 0.94;
			}
			return num5;
		}

		// Token: 0x060020AC RID: 8364
		// RVA: 0x0001AABB File Offset: 0x00018CBB
		public static Mods smethod_2()
		{
			return Mods.Easy | Mods.HardRock | Mods.DoubleTime | Mods.HalfTime;
		}

		// Token: 0x060020B2 RID: 8370
		// RVA: 0x0001AAE7 File Offset: 0x00018CE7
		[CompilerGenerated]
		private static int smethod_3(Class491 class491_0, Class491 class491_1)
		{
			return class491_0.class304_0.StartTime - class491_1.class304_0.StartTime;
		}

		// Token: 0x060020B3 RID: 8371
		// RVA: 0x0001AB00 File Offset: 0x00018D00
		[CompilerGenerated]
		private static int smethod_4(double double_1, double double_2)
		{
			return double_2.CompareTo(double_1);
		}

		// Token: 0x060020AD RID: 8365
		// RVA: 0x0001AAC2 File Offset: 0x00018CC2
		internal override Class297 vmethod_1()
		{
			return new Class302(false);
		}

		// Token: 0x060020AE RID: 8366
		// RVA: 0x0001AACA File Offset: 0x00018CCA
		protected override bool vmethod_2(Mods mods_1)
		{
			return ((this.class297_0.class623_0 ^ mods_1) & Mods.HardRock) > Mods.None;
		}

		// Token: 0x060020AF RID: 8367
		// RVA: 0x000BD3E4 File Offset: 0x000BB5E4
		protected override double vmethod_4(Dictionary<string, string> dictionary_0)
		{
			this.list_1 = new List<Class491>(this.list_0.Count);
			float num = 305f / Class115.float_1 * this.class297_0.float_0 * 0.7f;
			float num2 = num / 2f;
			Class302 class = this.class297_0 as Class302;
			class.method_34(num);
			num2 *= 0.8f;
			foreach (Class304 current in this.list_0)
			{
				if (!(current is Class318) && !(current is Class317))
				{
					this.list_1.Add(new Class491(current, num2));
				}
			}
			List<Class491> arg_CD_0 = this.list_1;
			if (Class462.comparison_0 == null)
			{
				Class462.comparison_0 = new Comparison<Class491>(Class462.smethod_3);
			}
			arg_CD_0.Sort(Class462.comparison_0);
			if (!this.method_3())
			{
				return 0.0;
			}
			double result = Math.Sqrt(this.method_4()) * 0.145;
			if (dictionary_0 != null)
			{
				dictionary_0.Add("Aim", result.ToString("0.00", Class115.numberFormatInfo_0));
				double num3 = (double)this.class297_0.PreEmpt / this.double_0;
				dictionary_0.Add("AR", ((num3 > 1200.0) ? (-(num3 - 1800.0) / 120.0) : (-(num3 - 1200.0) / 150.0 + 5.0)).ToString("0.00", Class115.numberFormatInfo_0));
				dictionary_0.Add("Max combo", this.list_1.Count.ToString(Class115.numberFormatInfo_0));
			}
			return result;
		}
	}
}
