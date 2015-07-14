using ns23;
using ns59;
using ns69;
using ns76;
using osu.GameplayElements;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns24
{
	// Token: 0x020003F9 RID: 1017
	internal abstract class Class461
	{
		// Token: 0x040019C4 RID: 6596
		internal Class296 class296_0;

		// Token: 0x040019C6 RID: 6598
		internal Class297 class297_0;

		// Token: 0x040019C7 RID: 6599
		internal double double_0 = 1.0;

		// Token: 0x040019C8 RID: 6600
		internal List<Class304> list_0;

		// Token: 0x040019C5 RID: 6597
		protected static readonly Mods[] mods_0 = new Mods[]
		{
			Mods.None,
			Mods.DoubleTime,
			Mods.HalfTime,
			Mods.Easy,
			Mods.Easy | Mods.DoubleTime,
			Mods.Easy | Mods.HalfTime,
			Mods.HardRock,
			Mods.HardRock | Mods.DoubleTime,
			Mods.HardRock | Mods.HalfTime
		};

		// Token: 0x0600209E RID: 8350
		// RVA: 0x0001AA51 File Offset: 0x00018C51
		public Class461(Class296 class296_1)
		{
			this.class296_0 = class296_1.Clone();
		}

		// Token: 0x0600209F RID: 8351
		// RVA: 0x0001AA74 File Offset: 0x00018C74
		public virtual void Dispose()
		{
			if (this.class297_0 != null)
			{
				this.class297_0.Dispose();
				this.class297_0 = null;
			}
		}

		// Token: 0x060020A7 RID: 8359
		// RVA: 0x000BD1D8 File Offset: 0x000BB3D8
		private void method_0()
		{
			int num;
			if (Class876.smethod_6(this.class297_0.class623_0, Mods.DoubleTime))
			{
				num = 150;
			}
			else if (Class876.smethod_6(this.class297_0.class623_0, Mods.HalfTime))
			{
				num = 75;
			}
			else
			{
				num = 100;
			}
			this.double_0 = (double)num / 100.0;
		}

		// Token: 0x060020A8 RID: 8360
		// RVA: 0x000BD23C File Offset: 0x000BB43C
		private void method_1(Mods mods_1)
		{
			this.list_0 = null;
			if (this.class297_0 != null)
			{
				this.class297_0.Dispose();
			}
			this.class297_0 = this.vmethod_1();
			this.class297_0.bool_0 = true;
			if (!this.class296_0.bool_8)
			{
				int int_ = this.class296_0.int_2;
				this.class296_0.method_11();
				this.class296_0.int_2 = int_;
			}
			this.class297_0.method_8(this.class296_0, mods_1);
			this.method_0();
			this.class297_0.vmethod_8(false, false);
			if (!this.class296_0.bool_8)
			{
				return;
			}
			this.class297_0.method_1(FileSection.HitObjects, false);
			this.list_0 = new List<Class304>(this.class297_0.list_3);
			this.vmethod_3();
		}

		// Token: 0x060020A9 RID: 8361
		// RVA: 0x000BD30C File Offset: 0x000BB50C
		public double method_2(Mods mods_1, Dictionary<string, string> dictionary_0)
		{
			try
			{
				double result;
				if (this.list_0 != null && !this.vmethod_2(mods_1))
				{
					this.class297_0.class623_0 = mods_1;
					this.method_0();
					this.class297_0.vmethod_8(false, false);
				}
				else
				{
					this.method_1(mods_1);
					if (this.list_0 == null)
					{
						result = 0.0;
						return result;
					}
				}
				double num = this.vmethod_4(dictionary_0);
				result = num;
				return result;
			}
			catch
			{
			}
			return 0.0;
		}

		// Token: 0x060020A1 RID: 8353
		// RVA: 0x0001AA97 File Offset: 0x00018C97
		public static Mods smethod_0(Mods mods_1)
		{
			return mods_1 & (Class464.smethod_2() | Class465.smethod_2() | Class462.smethod_2() | Class463.smethod_2());
		}

		// Token: 0x060020A2 RID: 8354
		// RVA: 0x000BD190 File Offset: 0x000BB390
		public static Mods smethod_1(Mods mods_1, PlayModes playModes_0, Class296 class296_1)
		{
			switch (playModes_0)
			{
			case PlayModes.Taiko:
				return mods_1 & Class465.smethod_2();
			case PlayModes.CatchTheBeat:
				return mods_1 & Class462.smethod_2();
			case PlayModes.OsuMania:
				return Class421.smethod_5(class296_1, mods_1) & Class463.smethod_2();
			default:
				return mods_1 & Class464.smethod_2();
			}
		}

		// Token: 0x060020A0 RID: 8352
		// RVA: 0x0001AA90 File Offset: 0x00018C90
		public virtual Mods[] vmethod_0()
		{
			return Class461.mods_0;
		}

		// Token: 0x060020A3 RID: 8355
		internal abstract Class297 vmethod_1();

		// Token: 0x060020A4 RID: 8356
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected virtual bool vmethod_2(Mods mods_1)
		{
			return false;
		}

		// Token: 0x060020A5 RID: 8357
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_3()
		{
		}

		// Token: 0x060020A6 RID: 8358
		protected abstract double vmethod_4(Dictionary<string, string> dictionary_0);
	}
}
