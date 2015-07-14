using ns23;
using ns29;
using ns59;
using ns62;
using ns76;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x020003FB RID: 1019
	internal sealed class Class463 : Class461
	{
		// Token: 0x040019CE RID: 6606
		[CompilerGenerated]
		private static Comparison<Class492> comparison_0;

		// Token: 0x040019CF RID: 6607
		[CompilerGenerated]
		private static Comparison<double> comparison_1;

		// Token: 0x040019CD RID: 6605
		private List<Class492> list_1;

		// Token: 0x040019CC RID: 6604
		private Mods mods_1;

		// Token: 0x060020B4 RID: 8372
		// RVA: 0x0001AB0A File Offset: 0x00018D0A
		public Class463(Class296 class296_1, Mods mods_2) : base(class296_1)
		{
			if (class296_1.method_5() == PlayModes.OsuMania)
			{
				mods_2 = Mods.None;
			}
			this.mods_1 = mods_2;
		}

		// Token: 0x060020BA RID: 8378
		// RVA: 0x000BD948 File Offset: 0x000BBB48
		protected bool method_3()
		{
			List<Class492>.Enumerator enumerator = this.list_1.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return false;
			}
			Class492 class492_ = enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class492 current = enumerator.Current;
				current.method_2(class492_, this.double_0);
				class492_ = current;
			}
			return true;
		}

		// Token: 0x060020BB RID: 8379
		// RVA: 0x000BD998 File Offset: 0x000BBB98
		protected double method_4()
		{
			double num = 400.0 * this.double_0;
			List<double> list = new List<double>();
			double num2 = num;
			double num3 = 0.0;
			Class492 class = null;
			foreach (Class492 current in this.list_1)
			{
				while ((double)current.class312_0.StartTime > num2)
				{
					list.Add(num3);
					if (class == null)
					{
						num3 = 0.0;
					}
					else
					{
						double num4 = Math.Pow(Class492.double_0, (num2 - (double)class.class312_0.StartTime) / 1000.0);
						double num5 = Math.Pow(Class492.double_1, (num2 - (double)class.class312_0.StartTime) / 1000.0);
						num3 = class.method_0() * num4 + class.double_4 * num5;
					}
					num2 += num;
				}
				double num6 = current.method_0() + current.double_4;
				if (num6 > num3)
				{
					num3 = num6;
				}
				class = current;
			}
			double num7 = 0.0;
			double num8 = 1.0;
			List<double> arg_141_0 = list;
			if (Class463.comparison_1 == null)
			{
				Class463.comparison_1 = new Comparison<double>(Class463.smethod_4);
			}
			arg_141_0.Sort(Class463.comparison_1);
			foreach (double num9 in list)
			{
				num7 += num8 * num9;
				num8 *= 0.9;
			}
			return num7;
		}

		// Token: 0x060020BC RID: 8380
		// RVA: 0x0001AB59 File Offset: 0x00018D59
		[CompilerGenerated]
		private void method_5(Class312 class312_0)
		{
			this.list_1.Add(new Class492(class312_0));
		}

		// Token: 0x060020B5 RID: 8373
		// RVA: 0x0001AB26 File Offset: 0x00018D26
		public static Mods smethod_2()
		{
			return Mods.Easy | Mods.HardRock | Mods.DoubleTime | Mods.HalfTime | Mods.Key4 | Mods.Key5 | Mods.Key6 | Mods.Key7 | Mods.Key8 | Mods.Key9 | Mods.KeyCoop | Mods.Key1 | Mods.Key3 | Mods.Key2;
		}

		// Token: 0x060020BD RID: 8381
		// RVA: 0x0001AB6C File Offset: 0x00018D6C
		[CompilerGenerated]
		private static int smethod_3(Class492 class492_0, Class492 class492_1)
		{
			return class492_0.class312_0.StartTime - class492_1.class312_0.StartTime;
		}

		// Token: 0x060020BE RID: 8382
		// RVA: 0x0001AB00 File Offset: 0x00018D00
		[CompilerGenerated]
		private static int smethod_4(double double_1, double double_2)
		{
			return double_2.CompareTo(double_1);
		}

		// Token: 0x060020B6 RID: 8374
		// RVA: 0x000BD78C File Offset: 0x000BB98C
		public override Mods[] vmethod_0()
		{
			Mods[] array = new Mods[Class461.mods_0.Length];
			for (int i = 0; i < Class461.mods_0.Length; i++)
			{
				array[i] = (this.mods_1 | Class461.mods_0[i]);
			}
			return array;
		}

		// Token: 0x060020B7 RID: 8375
		// RVA: 0x0001AB2D File Offset: 0x00018D2D
		internal override Class297 vmethod_1()
		{
			return new Class300(false);
		}

		// Token: 0x060020B8 RID: 8376
		// RVA: 0x0001AB35 File Offset: 0x00018D35
		protected override bool vmethod_2(Mods mods_2)
		{
			return (this.class297_0.class623_0 & Mods.KeyMod) != (mods_2 & Mods.KeyMod);
		}

		// Token: 0x060020B9 RID: 8377
		// RVA: 0x000BD7CC File Offset: 0x000BB9CC
		protected override double vmethod_4(Dictionary<string, string> dictionary_0)
		{
			Action<Class312> action = null;
			this.list_1 = new List<Class492>(this.list_0.Count);
			foreach (Class304 current in this.list_0)
			{
				if (current is Class315)
				{
					List<Class312> arg_53_0 = ((Class315)current).list_2;
					if (action == null)
					{
						action = new Action<Class312>(this.method_5);
					}
					arg_53_0.ForEach(action);
				}
				else if (current is Class312)
				{
					this.list_1.Add(new Class492((Class312)current));
				}
			}
			List<Class492> arg_B4_0 = this.list_1;
			if (Class463.comparison_0 == null)
			{
				Class463.comparison_0 = new Comparison<Class492>(Class463.smethod_3);
			}
			arg_B4_0.Sort(Class463.comparison_0);
			if (!this.method_3())
			{
				return 0.0;
			}
			double result = this.method_4() * 0.018;
			if (dictionary_0 != null)
			{
				dictionary_0.Add("Strain", result.ToString("0.00", Class115.numberFormatInfo_0));
				dictionary_0.Add("Hit window 300", Math.Ceiling((double)this.class297_0.HitWindow300 / this.double_0).ToString("0", Class115.numberFormatInfo_0));
				dictionary_0.Add("Score multiplier", Class876.smethod_8(Class876.class623_0).ToString("0.00", Class115.numberFormatInfo_0));
			}
			return result;
		}
	}
}
