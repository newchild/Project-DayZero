using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns22;
using ns23;
using ns24;
using ns29;
using ns3;
using ns42;
using ns59;
using ns62;
using ns64;
using ns70;
using ns76;
using ns77;
using ns79;
using ns8;
using ns82;
using ns89;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using osu_gameplay;
using osudata;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns69
{
	// Token: 0x020003D2 RID: 978
	internal sealed class Class428 : Class427
	{
		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		private sealed class Class433
		{
			// Token: 0x040018D5 RID: 6357
			public Class312 class312_0;

			// Token: 0x040018D7 RID: 6359
			public Class428 class428_0;

			// Token: 0x040018D6 RID: 6358
			public int int_0;

			// Token: 0x06001F6F RID: 8047
			// RVA: 0x000B1E0C File Offset: 0x000B000C
			public void method_0(Class14 class14_0)
			{
				if (class14_0.int_0 <= this.class312_0.StartTime)
				{
					return;
				}
				if (class14_0.int_0 >= this.class312_0.EndTime)
				{
					return;
				}
				class14_0.float_0 = (float)this.class428_0.method_6((int)class14_0.float_0, this.int_0);
			}
		}

		// Token: 0x020003D4 RID: 980
		[CompilerGenerated]
		private sealed class Class434
		{
			// Token: 0x040018D8 RID: 6360
			public int int_0;

			// Token: 0x06001F71 RID: 8049
			// RVA: 0x00019B3A File Offset: 0x00017D3A
			public bool method_0(Class14 class14_0)
			{
				return class14_0.int_0 <= this.int_0;
			}
		}

		// Token: 0x040018D3 RID: 6355
		private int int_4 = 10;

		// Token: 0x040018D4 RID: 6356
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x06001F4C RID: 8012
		// RVA: 0x00019968 File Offset: 0x00017B68
		public Class428(Class62 class62_1) : base(class62_1)
		{
		}

		// Token: 0x06001F4E RID: 8014
		// RVA: 0x00019981 File Offset: 0x00017B81
		public override void Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06001F5C RID: 8028
		// RVA: 0x000199EF File Offset: 0x00017BEF
		internal override void Draw()
		{
			if (!this.bool_0)
			{
				return;
			}
			this.class297_0.class421_0.Draw();
			this.class666_0.Draw();
			this.vmethod_31();
			if (this.class103_0 != null)
			{
				this.class103_0.Draw();
			}
		}

		// Token: 0x06001F6A RID: 8042
		// RVA: 0x00019B10 File Offset: 0x00017D10
		private int method_6(int int_5, int int_6)
		{
			if (int_6 > 0)
			{
				if ((int_5 & int_6) > 0)
				{
					int_5 &= ~int_6;
				}
				else
				{
					int_5 |= int_6;
				}
			}
			else if ((int_5 & -int_6) > 0)
			{
				int_5 &= ~(-int_6);
			}
			return int_5;
		}

		// Token: 0x06001F6B RID: 8043
		// RVA: 0x000B1980 File Offset: 0x000AFB80
		private void method_7(List<Class14> list_0, int int_5, int int_6)
		{
			Class428.Class434 class = new Class428.Class434();
			class.int_0 = int_5;
			int num = list_0.FindLastIndex(new Predicate<Class14>(class.method_0));
			if (num < 0)
			{
				list_0.Add(new Class14(class.int_0, (float)this.method_6(0, int_6), (float)this.int_4, pButtonState.None));
				return;
			}
			if (class.int_0 == 0)
			{
				list_0.Insert(num + 1, new Class14(0, (float)this.method_6((int)list_0[num].float_0, int_6), (float)this.int_4, pButtonState.None));
				return;
			}
			if (list_0[num].int_0 == class.int_0)
			{
				list_0[num].float_0 = (float)this.method_6((int)list_0[num].float_0, int_6);
				return;
			}
			list_0.Insert(num + 1, new Class14(class.int_0, (float)this.method_6((int)list_0[num].float_0, int_6), (float)this.int_4, pButtonState.None));
		}

		// Token: 0x06001F6C RID: 8044
		// RVA: 0x000B1A70 File Offset: 0x000AFC70
		internal double method_8()
		{
			double num = 0.05;
			double num2 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 195.0, 160.0, 60.0);
			this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 170.0, 80.0);
			double num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 180.0, 80.0);
			double num4 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 8.0, 4.0, 0.0);
			int num5;
			while (true)
			{
				IL_2CD:
				this.int_1 = 0;
				num5 = 0;
				this.class410_0.Reset();
				this.class413_0.vmethod_1(0);
				Class62.class512_0.int_3 = 0;
				double num6 = this.class410_0.method_2();
				int num7 = this.class297_0.list_3[0].StartTime - this.class297_0.PreEmpt;
				bool flag = false;
				int count = this.class62_0.class872_0.list_0.Count;
				int num8 = 0;
				int i = 0;
				while (i < this.class297_0.int_14)
				{
					Class304 class = this.class297_0.list_3[i];
					int num9 = num7;
					int num10 = 0;
					if (count > 0 && num8 < count)
					{
						Class702 class2 = this.class62_0.class872_0.list_0[num8];
						if (class2.int_2 >= num9 && class2.int_0 <= class.StartTime)
						{
							num10 = class2.Length;
							num8++;
						}
					}
					this.class410_0.vmethod_11(num * (double)(class.StartTime - num7 - num10));
					num7 = class.EndTime;
					if (this.class410_0.method_2() < num6)
					{
						num6 = this.class410_0.method_2();
					}
					if (this.class410_0.method_2() > num2)
					{
						this.vmethod_41(Enum61.flag_37, class);
						this.int_1++;
						if (class.EndTime > class.StartTime)
						{
							num5 += (class.EndTime - class.StartTime) / Class420.int_2;
						}
						class.double_0 = this.class410_0.method_2();
						i++;
					}
					else
					{
						flag = true;
						num *= 0.96;
						IL_211:
						if (!flag && this.class410_0.method_2() < num3)
						{
							flag = true;
							num *= 0.94;
							this.double_0 *= 1.01;
							this.double_1 *= 1.01;
						}
						double num11 = (this.class410_0.method_4() - 200.0) / (double)this.class297_0.int_14;
						if (!flag && num11 < num4)
						{
							flag = true;
							num *= 0.96;
							this.double_0 *= 1.02;
							this.double_1 *= 1.01;
						}
						if (flag)
						{
							goto IL_2CD;
						}
						goto IL_34F;
					}
				}
				goto IL_211;
			}
			IL_34F:
			if (Class115.bool_25)
			{
				Class63 class3 = this.class62_0 as Class63;
				if (class3 != null)
				{
					class3.int_38 = Class62.class512_0.int_3;
					class3.int_37 = this.class413_0.vmethod_0() + num5;
				}
			}
			return num;
		}

		// Token: 0x06001F6D RID: 8045
		// RVA: 0x00019948 File Offset: 0x00017B48
		[CompilerGenerated]
		private static void smethod_2()
		{
			Class62.enum43_0 |= Enum43.flag_5;
			Class62.bool_18 = false;
		}

		// Token: 0x06001F58 RID: 8024
		// RVA: 0x000199C3 File Offset: 0x00017BC3
		internal override Vector2 vmethod_0()
		{
			return new Vector2(0f, 135f);
		}

		// Token: 0x06001F59 RID: 8025
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_1()
		{
			return false;
		}

		// Token: 0x06001F67 RID: 8039
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_11()
		{
			return false;
		}

		// Token: 0x06001F4F RID: 8015
		// RVA: 0x00019989 File Offset: 0x00017B89
		internal override bool vmethod_12()
		{
			if (Class62.bool_12)
			{
				return !Class802.smethod_4();
			}
			return base.vmethod_12();
		}

		// Token: 0x06001F66 RID: 8038
		// RVA: 0x00019AAE File Offset: 0x00017CAE
		internal override bool vmethod_14()
		{
			return this.class413_0.vmethod_0() > 99 && this.class413_0.vmethod_0() % 100 == 0;
		}

		// Token: 0x06001F4D RID: 8013
		// RVA: 0x00019979 File Offset: 0x00017B79
		internal override void vmethod_19()
		{
			base.vmethod_19();
		}

		// Token: 0x06001F64 RID: 8036
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_20()
		{
		}

		// Token: 0x06001F5D RID: 8029
		// RVA: 0x00019A2E File Offset: 0x00017C2E
		internal override void vmethod_21(float float_0)
		{
			this.class297_0.class421_0.method_29(float_0);
			base.vmethod_21(float_0);
		}

		// Token: 0x06001F52 RID: 8018
		// RVA: 0x000B12EC File Offset: 0x000AF4EC
		internal override void vmethod_22()
		{
			this.class297_0.class421_0.class411_0.double_1 = this.method_8();
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
			{
				this.class297_0.class421_0.class411_0.double_1 *= 0.75;
			}
			base.vmethod_22();
		}

		// Token: 0x06001F53 RID: 8019
		// RVA: 0x000B135C File Offset: 0x000AF55C
		internal override void vmethod_23()
		{
			Class300 class = (Class300)this.class297_0;
			double num = Class876.smethod_8(Class62.class512_0.class623_0 & ~(Mods.Hidden | Mods.HardRock | Mods.DoubleTime | Mods.Flashlight | Mods.FadeIn));
			this.double_2 = (double)Class420.int_0 / (double)class.int_24 * num;
			if (!Class876.smethod_6(Class62.class512_0.class623_0, Mods.SuddenDeath) && Class876.smethod_6(Class62.class512_0.class623_0, Mods.Easy))
			{
				this.int_0 = 2;
			}
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				this.class911_3 = new Class911(true);
				this.class531_0 = new Class531(null, Enum115.const_2, Origins.CentreLeft, Enum114.const_0, new Vector2(0f, 220f), 1f, true, Color.get_White(), null);
				this.class531_0.float_2 = 1.4f;
				this.class911_3.Add(this.class531_0);
				this.vmethod_24();
			}
		}

		// Token: 0x06001F54 RID: 8020
		// RVA: 0x000B1454 File Offset: 0x000AF654
		protected override void vmethod_24()
		{
			if (this.class531_0 == null)
			{
				return;
			}
			this.bool_1 = true;
			byte[] array = ResourcesStore.get_ResourceManager().GetObject("flashlightv2_mania") as byte[];
			if (array == null)
			{
				this.bool_1 = false;
				array = (ResourcesStore.get_ResourceManager().GetObject("flashlight2") as byte[]);
			}
			byte[] array2 = Class33.smethod_4(array);
			byte[] arg_79_0;
			if (!this.bool_1)
			{
				RuntimeHelpers.InitializeArray(arg_79_0 = new byte[16], fieldof(Class918.struct71_2).FieldHandle);
			}
			else
			{
				RuntimeHelpers.InitializeArray(arg_79_0 = new byte[16], fieldof(Class918.struct71_3).FieldHandle);
			}
			byte[] array3 = arg_79_0;
			bool flag = false;
			for (int i = 0; i < 16; i++)
			{
				if (array2[i] != array3[i])
				{
					flag = true;
					IL_9D:
					if (flag)
					{
						Class47 arg_C3_0 = Class115.class47_0;
						if (Class428.voidDelegate_1 == null)
						{
							Class428.voidDelegate_1 = new VoidDelegate(Class428.smethod_2);
						}
						arg_C3_0.Add(Class428.voidDelegate_1, true);
					}
					this.class531_0.vmethod_7(Class731.smethod_6(array));
					return;
				}
			}
			goto IL_9D;
		}

		// Token: 0x06001F50 RID: 8016
		// RVA: 0x000B128C File Offset: 0x000AF48C
		internal override void vmethod_26()
		{
			base.vmethod_26();
			this.class410_0 = this.class297_0.class421_0.class411_0;
			if (!Class341.smethod_6(Enum40.const_0))
			{
				Class723.smethod_1(string.Format(Class41.GetString(OsuString.Tips_ManiaSpeedChange), Class795.smethod_5(Bindings.IncreaseSpeed), Class795.smethod_5(Bindings.DecreaseSpeed)), 2500);
				Class341.smethod_7(Enum40.const_0, true);
			}
		}

		// Token: 0x06001F62 RID: 8034
		// RVA: 0x00019A87 File Offset: 0x00017C87
		internal override Class297 vmethod_27()
		{
			return new Class300(true);
		}

		// Token: 0x06001F65 RID: 8037
		// RVA: 0x00019A8F File Offset: 0x00017C8F
		internal override void vmethod_28()
		{
			this.class413_0 = new Class414(this.class911_1, this.class297_0.class421_0, true);
		}

		// Token: 0x06001F69 RID: 8041
		// RVA: 0x000B17A0 File Offset: 0x000AF9A0
		internal override void vmethod_29()
		{
			this.int_4 = (int)(2000f / Class466.Current.method_33().Z);
			Class802.class512_0.list_1 = new List<Class14>();
			List<Class14> list_ = Class802.class512_0.list_1;
			list_.Add(new Class14(0, 0f, (float)this.int_4, pButtonState.None));
			for (int i = 0; i < this.class297_0.int_14; i++)
			{
				Action<Class14> action = null;
				Class428.Class433 class = new Class428.Class433();
				class.class428_0 = this;
				class.class312_0 = (Class312)this.class297_0.list_3[i];
				class.int_0 = 0;
				if (this.class297_0.class421_0.method_36())
				{
					class.int_0 = this.class297_0.class421_0.list_0[(class.class312_0.class409_0 == this.class297_0.class421_0.list_0.Count - 1) ? 0 : (class.class312_0.class409_0 + 1)].method_2();
				}
				else
				{
					class.int_0 = class.class312_0.class409_0.method_2();
				}
				this.method_7(list_, class.class312_0.StartTime, class.int_0);
				if (class.class312_0.enum47_0 == Enum47.const_1)
				{
					List<Class14> arg_158_0 = list_;
					if (action == null)
					{
						action = new Action<Class14>(class.method_0);
					}
					arg_158_0.ForEach(action);
					this.method_7(list_, class.class312_0.EndTime - 1, -class.int_0);
				}
				else
				{
					this.method_7(list_, class.class312_0.StartTime + 1, -class.int_0);
				}
			}
			Class62.class512_0.list_1 = Class802.class512_0.list_1;
			Class62.class512_0.string_2 = "osu!topus!";
		}

		// Token: 0x06001F5E RID: 8030
		// RVA: 0x00019A48 File Offset: 0x00017C48
		internal override bool vmethod_3()
		{
			return this.class297_0.class421_0.class411_0.method_2() >= 160.0;
		}

		// Token: 0x06001F5B RID: 8027
		// RVA: 0x000199D4 File Offset: 0x00017BD4
		internal override void vmethod_30()
		{
			if (!this.bool_0)
			{
				return;
			}
			this.class297_0.class421_0.method_18();
		}

		// Token: 0x06001F55 RID: 8021
		// RVA: 0x000B153C File Offset: 0x000AF73C
		internal override void vmethod_31()
		{
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				if (this.class531_0.vmethod_6() == null || (Class115.bool_27 && !this.class531_0.vmethod_6().class748_0.method_0()) || (Class115.bool_26 && this.class531_0.vmethod_6().method_2() == null))
				{
					if (this.class512_0.bool_0)
					{
						this.class512_0.bool_0 = false;
						Class723.smethod_1("Couldn't draw Flashlight texture - disabling ranking.", 2000);
						Class341.smethod_14();
						Class115.smethod_70(OsuModes.Update, false);
					}
					return;
				}
				if (this.class911_3.list_2.Count == 0)
				{
					this.class62_0.method_4();
				}
				this.class911_3.Draw();
			}
		}

		// Token: 0x06001F57 RID: 8023
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_32()
		{
		}

		// Token: 0x06001F51 RID: 8017
		// RVA: 0x000198D9 File Offset: 0x00017AD9
		internal override void vmethod_33()
		{
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x06001F56 RID: 8022
		// RVA: 0x000199A1 File Offset: 0x00017BA1
		internal override void vmethod_36()
		{
			if (this.bool_0 && !Class62.bool_11)
			{
				this.class297_0.class421_0.method_19();
				return;
			}
		}

		// Token: 0x06001F5A RID: 8026
		// RVA: 0x000B1614 File Offset: 0x000AF814
		internal override void vmethod_38()
		{
			base.vmethod_38();
			Class300 class = (Class300)this.class297_0;
			this.class62_0.method_9(false);
			this.class512_0.int_3 = (int)Math.Round(this.class512_0.double_0);
			if (this.class512_0.int_3 == 999999)
			{
				this.class512_0.int_3 = 1000000;
			}
			if (this.class512_0.ushort_5 + this.class512_0.ushort_2 + this.class512_0.ushort_0 == 0 && (double)((float)this.class512_0.ushort_4 / (float)this.class512_0.vmethod_2()) < 0.1)
			{
				this.class512_0.bool_4 = true;
			}
			else
			{
				this.class512_0.bool_4 = false;
			}
			this.class512_0.class623_0 = Class421.smethod_5(Class466.Current, this.class512_0.class623_0);
			if (class.int_27 > class.int_22 * 2 / 3)
			{
				Class62.enum43_0 |= Enum43.flag_11;
			}
			this.int_3++;
			this.class62_0.method_8();
		}

		// Token: 0x06001F61 RID: 8033
		// RVA: 0x000B1748 File Offset: 0x000AF948
		internal override bool vmethod_40()
		{
			Class421 class421_ = this.class297_0.class421_0;
			for (int i = 0; i < class421_.list_0.Count; i++)
			{
				if (class421_.list_0[i].method_5() != class421_.list_0[i].bool_2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001F68 RID: 8040
		// RVA: 0x00019AD2 File Offset: 0x00017CD2
		internal override void vmethod_41(Enum61 enum61_0, Class304 class304_0)
		{
			if ((class304_0.bool_0 && enum61_0 != Enum61.flag_5) || enum61_0 == Enum61.flag_0)
			{
				this.class62_0.method_62(enum61_0 != Enum61.flag_4 && enum61_0 != Enum61.flag_0);
			}
			base.vmethod_41(enum61_0, class304_0);
		}

		// Token: 0x06001F5F RID: 8031
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_7()
		{
			return true;
		}

		// Token: 0x06001F63 RID: 8035
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06001F60 RID: 8032
		// RVA: 0x00019A6D File Offset: 0x00017C6D
		internal override bool vmethod_9()
		{
			return this.class512_0.vmethod_2() == this.class297_0.int_14;
		}
	}
}
