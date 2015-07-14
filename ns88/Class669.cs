using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns23;
using ns26;
using ns29;
using ns3;
using ns5;
using ns59;
using ns60;
using ns63;
using ns70;
using ns76;
using ns79;
using ns80;
using ns82;
using ns89;
using ns90;
using osu;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns88
{
	// Token: 0x020004FF RID: 1279
	internal sealed class Class669 : Class668
	{
		// Token: 0x02000500 RID: 1280
		[CompilerGenerated]
		private sealed class Class672
		{
			// Token: 0x0400223A RID: 8762
			public Class669 class669_0;

			// Token: 0x04002239 RID: 8761
			public Class705 class705_0;

			// Token: 0x0400223B RID: 8763
			public int int_0;

			// Token: 0x0600294F RID: 10575
			// RVA: 0x0001FBF1 File Offset: 0x0001DDF1
			public bool method_0(Class705 class705_1)
			{
				return class705_1.int_2 <= this.int_0 && class705_1.int_0 >= this.int_0;
			}

			// Token: 0x06002950 RID: 10576
			// RVA: 0x00104CD4 File Offset: 0x00102ED4
			public bool method_1(Class304 class304_0)
			{
				return (class304_0.int_4 == this.class669_0.class64_0.int_35 || class304_0.int_4 == -2) && class304_0.EndTime <= this.class705_0.int_0 + this.class669_0.class64_0.class297_0.HitWindow50 && !class304_0.bool_0;
			}
		}

		// Token: 0x02000501 RID: 1281
		[CompilerGenerated]
		private sealed class Class673
		{
			// Token: 0x0400223C RID: 8764
			public Class14 class14_0;

			// Token: 0x0400223D RID: 8765
			public Class14 class14_1;

			// Token: 0x06002952 RID: 10578
			// RVA: 0x0001FC14 File Offset: 0x0001DE14
			public bool method_0(int int_0)
			{
				return this.class14_0.int_0 <= int_0 && this.class14_1.int_0 > int_0;
			}
		}

		// Token: 0x02000502 RID: 1282
		[CompilerGenerated]
		private sealed class Class674
		{
			// Token: 0x0400223E RID: 8766
			public Class669.Class673 class673_0;

			// Token: 0x0400223F RID: 8767
			public int int_0;

			// Token: 0x06002954 RID: 10580
			// RVA: 0x0001FC34 File Offset: 0x0001DE34
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime == this.int_0;
			}
		}

		// Token: 0x02000503 RID: 1283
		[CompilerGenerated]
		private sealed class Class675
		{
			// Token: 0x04002240 RID: 8768
			public Class746 class746_0;

			// Token: 0x04002241 RID: 8769
			public Class746 class746_1;

			// Token: 0x06002956 RID: 10582
			// RVA: 0x0001FC44 File Offset: 0x0001DE44
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
				class531_0.class26_0.Add(this.class746_1);
			}
		}

		// Token: 0x02000504 RID: 1284
		[CompilerGenerated]
		private sealed class Class676
		{
			// Token: 0x04002242 RID: 8770
			public Class297 class297_0;

			// Token: 0x04002243 RID: 8771
			public Class669 class669_0;

			// Token: 0x06002958 RID: 10584
			// RVA: 0x0001FC68 File Offset: 0x0001DE68
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime >= Class331.int_7 - this.class297_0.HitWindow50 && class304_0.int_4 == this.class669_0.int_1 && !class304_0.bool_0;
			}
		}

		// Token: 0x02000505 RID: 1285
		[CompilerGenerated]
		private sealed class Class677
		{
			// Token: 0x04002244 RID: 8772
			public Class669.Class676 class676_0;

			// Token: 0x04002245 RID: 8773
			public int int_0;

			// Token: 0x0600295A RID: 10586
			// RVA: 0x0001FCA1 File Offset: 0x0001DEA1
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime == this.int_0;
			}
		}

		// Token: 0x04002237 RID: 8759
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002238 RID: 8760
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x0400222E RID: 8750
		private readonly Class512 class512_0 = new Class512();

		// Token: 0x04002235 RID: 8757
		private Class512 class512_1;

		// Token: 0x04002231 RID: 8753
		private Class665 class665_0;

		// Token: 0x0400222F RID: 8751
		private int int_0;

		// Token: 0x04002232 RID: 8754
		private int int_1 = -3;

		// Token: 0x04002234 RID: 8756
		private int int_2;

		// Token: 0x04002230 RID: 8752
		private List<Class705> list_0;

		// Token: 0x04002233 RID: 8755
		private List<int> list_1;

		// Token: 0x04002236 RID: 8758
		[CompilerGenerated]
		private static Predicate<Class304> predicate_0;

		// Token: 0x06002934 RID: 10548
		// RVA: 0x0001FAD6 File Offset: 0x0001DCD6
		internal Class669(Class64 class64_1) : base(class64_1)
		{
			Class802.bool_12 = false;
			this.class512_0.bool_0 = false;
			this.class512_0.bool_2 = true;
		}

		// Token: 0x0600293A RID: 10554
		// RVA: 0x0001FB25 File Offset: 0x0001DD25
		public override void Dispose()
		{
			Class802.class531_0.color_0 = Color.get_White();
			Class802.bool_12 = true;
			Class802.smethod_1(false);
			this.method_7();
			this.class665_0.method_5(null);
			base.Dispose();
		}

		// Token: 0x06002943 RID: 10563
		// RVA: 0x00104454 File Offset: 0x00102654
		internal override void Initialize()
		{
			Class802.class512_0 = (this.class512_1 = Class721.Create(Class62.Mode, "osu!", this.class64_0.class297_0.class296_0));
			this.class64_0.class427_0.vmethod_29();
			Class62.class512_0.bool_0 = false;
			base.Initialize();
		}

		// Token: 0x06002937 RID: 10551
		// RVA: 0x0001FB10 File Offset: 0x0001DD10
		private bool method_0()
		{
			return this.method_2(Class331.int_7);
		}

		// Token: 0x06002939 RID: 10553
		// RVA: 0x00103ABC File Offset: 0x00101CBC
		private int method_1()
		{
			if (Class872.bool_1)
			{
				return -1;
			}
			List<Class304> arg_36_0 = this.class64_0.class297_0.list_4;
			if (Class669.predicate_0 == null)
			{
				Class669.predicate_0 = new Predicate<Class304>(Class669.smethod_0);
			}
			Class304 class = arg_36_0.Find(Class669.predicate_0);
			if (class == null)
			{
				return -1;
			}
			return class.int_4;
		}

		// Token: 0x0600293C RID: 10556
		// RVA: 0x00103B10 File Offset: 0x00101D10
		private bool method_2(int int_3)
		{
			Class669.Class672 class = new Class669.Class672();
			class.int_0 = int_3;
			class.class669_0 = this;
			if (!Class872.bool_1 && !this.class64_0.bool_25 && !Class62.bool_6)
			{
				if (this.class64_0.enum110_0 == Enum110.const_2)
				{
					if (Class331.int_7 > this.class64_0.class297_0.list_3[this.class64_0.class297_0.int_14 - 1].EndTime)
					{
						return true;
					}
					class.class705_0 = this.list_0.Find(new Predicate<Class705>(class.method_0));
					return class.class705_0 != null && this.class64_0.class297_0.list_4.FindIndex(new Predicate<Class304>(class.method_1)) >= 0;
				}
			}
			return true;
		}

		// Token: 0x06002940 RID: 10560
		// RVA: 0x00103D0C File Offset: 0x00101F0C
		private void method_3(Class660 class660_0)
		{
			int ushort_ = (int)this.class512_0.ushort_1;
			int ushort_2 = (int)this.class512_0.ushort_0;
			int ushort_3 = (int)this.class512_0.ushort_2;
			int ushort_4 = (int)this.class512_0.ushort_5;
			this.class512_0.list_0 = Class62.class512_0.list_0;
			this.class512_0.Reset();
			foreach (int current in this.list_1)
			{
				Class512 class = this.class64_0.list_4[current].class512_0;
				if (class != null)
				{
					this.class512_0.int_3 += class.int_3;
					Class512 expr_AB = this.class512_0;
					expr_AB.ushort_2 += class.ushort_2;
					Class512 expr_C5 = this.class512_0;
					expr_C5.ushort_0 += class.ushort_0;
					Class512 expr_DF = this.class512_0;
					expr_DF.ushort_1 += class.ushort_1;
					Class512 expr_F9 = this.class512_0;
					expr_F9.ushort_5 += class.ushort_5;
					Class512 expr_113 = this.class512_0;
					expr_113.ushort_3 += class.ushort_3;
					Class512 expr_12D = this.class512_0;
					expr_12D.ushort_4 += class.ushort_4;
					this.class512_0.double_1 = Math.Max(this.class512_0.double_1, class.double_1);
					this.class512_0.int_0 = Math.Max(this.class512_0.int_0, class.int_0);
				}
			}
			if (class660_0 != this.class64_0.class660_0)
			{
				HitObjectType int_ = (HitObjectType)class660_0.struct13_0.int_3;
				if (int_.IsType(HitObjectType.Normal))
				{
					if ((int)this.class512_0.ushort_2 > ushort_3)
					{
						this.method_4(Enum61.flag_14);
					}
					else if ((int)this.class512_0.ushort_0 > ushort_2)
					{
						this.method_4(Enum61.flag_15);
					}
					else if ((int)this.class512_0.ushort_5 > ushort_4)
					{
						this.method_4(Enum61.flag_3);
					}
				}
				else if (int_.IsType(HitObjectType.Slider))
				{
					if ((int)this.class512_0.ushort_2 > ushort_3)
					{
						this.method_5(Enum61.flag_14);
					}
					else if ((int)this.class512_0.ushort_0 > ushort_2)
					{
						this.method_5(Enum61.flag_15);
					}
					else if ((int)this.class512_0.ushort_1 > ushort_)
					{
						this.method_5(Enum61.flag_16);
					}
					else if ((int)this.class512_0.ushort_5 > ushort_4)
					{
						this.method_5(Enum61.flag_3);
					}
				}
			}
			this.class64_0.class427_0.class666_0.vmethod_0(this.class512_0.int_3);
		}

		// Token: 0x06002941 RID: 10561
		// RVA: 0x00103FEC File Offset: 0x001021EC
		private void method_4(Enum61 enum61_0)
		{
			List<Class14> list = this.class512_1.list_1;
			for (int i = Class802.int_1 + 1; i < list.Count - 2; i++)
			{
				Class14 class = list[i - 1];
				Class14 class2 = list[i];
				Class14 class3 = list[i + 1];
				if (class2.bool_0)
				{
					if (class.bool_0 || class3.bool_0 || this.method_2(class2.int_0))
					{
						i++;
						continue;
					}
					if (enum61_0 == Enum61.flag_3)
					{
						class2.method_0(pButtonState.None);
						return;
					}
					if (enum61_0 != Enum61.flag_14)
					{
						if (enum61_0 == Enum61.flag_15)
						{
							int num = (int)((float)this.class64_0.class297_0.HitWindow300 * 1.1f);
							if (class2.int_0 - class.int_0 > num)
							{
								class2.int_0 -= num;
								return;
							}
						}
					}
					else
					{
						int num2 = (int)((float)this.class64_0.class297_0.HitWindow100 * 1.1f);
						if (class2.int_0 - class.int_0 > num2)
						{
							class2.int_0 -= num2;
							return;
						}
					}
				}
			}
		}

		// Token: 0x06002942 RID: 10562
		// RVA: 0x0010411C File Offset: 0x0010231C
		private void method_5(Enum61 enum61_0)
		{
			List<Class14> list = Class802.class512_0.list_1;
			int i = Class802.int_1 + 1;
			int count = list.Count;
			if (i > count - 1)
			{
				return;
			}
			int num = Math.Max(this.int_2, i);
			while (num < count - 2 && list[num + 1].bool_0)
			{
				num++;
			}
			this.int_2 = num;
			while (i < count - 2)
			{
				Predicate<int> predicate = null;
				Class669.Class673 class = new Class669.Class673();
				Class14 class2 = list[i - 1];
				class.class14_0 = list[i];
				class.class14_1 = list[i + 1];
				if (class.class14_0.bool_0 && class.class14_1.bool_0 && !class2.bool_0 && !this.method_2(class.class14_0.int_0))
				{
					Class669.Class674 class3 = new Class669.Class674();
					class3.class673_0 = class;
					num = i;
					class3.int_0 = list[num].int_0;
					Class321 class4 = this.class64_0.class297_0.list_3.Find(new Predicate<Class304>(class3.method_0)) as Class321;
					if (class4 == null)
					{
						i++;
						continue;
					}
					if (enum61_0 <= Enum61.flag_14)
					{
						if (enum61_0 == Enum61.flag_3)
						{
							while (class.class14_0.bool_0)
							{
								class.class14_0.method_0(pButtonState.None);
								if (i == count - 1)
								{
									return;
								}
								class.class14_0 = list[++i];
							}
							return;
						}
						if (enum61_0 != Enum61.flag_14)
						{
							goto IL_1E0;
						}
					}
					else if (enum61_0 != Enum61.flag_15 && enum61_0 != Enum61.flag_16)
					{
						goto IL_1E0;
					}
					int num2;
					if (enum61_0 == Enum61.flag_14)
					{
						num2 = (((float)((class4.list_7.Count + 1) / 2) == (float)(class4.list_7.Count + 1) / 2f) ? ((class4.list_7.Count + 1) / 2) : ((class4.list_7.Count + 1) / 2 + 1));
					}
					else
					{
						if (enum61_0 != Enum61.flag_15)
						{
							return;
						}
						num2 = 1;
					}
					num2 -= class4.int_8;
					if (num2 <= 0)
					{
						i++;
						continue;
					}
					bool flag = true;
					int num3 = class.class14_0.int_0 + Math.Min(class4.list_7[0], this.class64_0.class297_0.HitWindow50);
					while (class.class14_0.int_0 <= class4.EndTime && num2 > 0)
					{
						if (flag)
						{
							if (class.class14_0.int_0 < num3)
							{
								class.class14_0.method_0(pButtonState.None);
							}
							else
							{
								flag = false;
								num2--;
							}
						}
						if (!flag)
						{
							List<int> arg_2B2_0 = class4.list_7;
							if (predicate == null)
							{
								predicate = new Predicate<int>(class.method_0);
							}
							if (arg_2B2_0.FindIndex(predicate) >= 0)
							{
								if (num2 <= 0)
								{
									return;
								}
								num2--;
								class.class14_0.method_0(pButtonState.None);
								class.class14_1.method_0(pButtonState.None);
							}
						}
						if (i == count - 1)
						{
							return;
						}
						class.class14_0 = list[++i];
						class.class14_1 = list[i + 1];
					}
					return;
				}
				IL_1E0:
				i++;
			}
		}

		// Token: 0x06002945 RID: 10565
		// RVA: 0x001046D0 File Offset: 0x001028D0
		private void method_6()
		{
			List<Class531> arg_28_0 = this.class64_0.list_0;
			if (Class669.action_0 == null)
			{
				Class669.action_0 = new Action<Class531>(Class669.smethod_1);
			}
			arg_28_0.ForEach(Class669.action_0);
			foreach (Class705 current in this.list_0)
			{
				for (int i = 0; i < 1300; i += 200)
				{
					Class669.Class675 class = new Class669.Class675();
					class.class746_0 = new Class746(TransformationType.Fade, 0f, 1f, current.int_2 - 1000 + i, current.int_2 - 1000 + i, Enum70.const_0);
					class.class746_1 = new Class746(TransformationType.Fade, 1f, 0f, current.int_2 - 900 + i, current.int_2 - 900 + i, Enum70.const_0);
					this.class64_0.list_0.ForEach(new Action<Class531>(class.method_0));
				}
			}
		}

		// Token: 0x06002946 RID: 10566
		// RVA: 0x0001FB86 File Offset: 0x0001DD86
		private void method_7()
		{
			List<Class531> arg_28_0 = this.class64_0.list_0;
			if (Class669.action_1 == null)
			{
				Class669.action_1 = new Action<Class531>(Class669.smethod_2);
			}
			arg_28_0.ForEach(Class669.action_1);
		}

		// Token: 0x0600294B RID: 10571
		// RVA: 0x0001FBC6 File Offset: 0x0001DDC6
		[CompilerGenerated]
		private static bool smethod_0(Class304 class304_0)
		{
			return class304_0.EndTime >= Class331.int_7;
		}

		// Token: 0x0600294C RID: 10572
		// RVA: 0x0001BBF8 File Offset: 0x00019DF8
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_0)
		{
			class531_0.class26_0.Clear();
		}

		// Token: 0x0600294D RID: 10573
		// RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_0)
		{
			class531_0.class26_0.Clear();
			class531_0.method_17(1000);
		}

		// Token: 0x06002938 RID: 10552
		// RVA: 0x0001FB1D File Offset: 0x0001DD1D
		internal override Class512 vmethod_0()
		{
			return this.class512_0;
		}

		// Token: 0x06002935 RID: 10549
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_1()
		{
			return false;
		}

		// Token: 0x0600293D RID: 10557
		// RVA: 0x00103BF0 File Offset: 0x00101DF0
		internal override void vmethod_10(int int_3)
		{
			base.vmethod_10(int_3);
			if (Class62.bool_6)
			{
				return;
			}
			if (Class64.bool_55)
			{
				Class115.smethod_70(OsuModes.RankingTeam, false);
				this.class64_0.method_84();
				Class723.smethod_2(null, null);
				return;
			}
			this.class64_0.class427_0.class410_0.vmethod_10(0.0);
			this.class64_0.vmethod_22();
		}

		// Token: 0x06002949 RID: 10569
		// RVA: 0x0001FBB5 File Offset: 0x0001DDB5
		internal override void vmethod_12()
		{
			Class115.smethod_70(OsuModes.RankingTagCoop, false);
			Class723.smethod_2(null, null);
		}

		// Token: 0x0600294A RID: 10570
		// RVA: 0x00104C4C File Offset: 0x00102E4C
		internal override void vmethod_13()
		{
			if (this.class64_0 != null && this.class64_0.class533_2 != null && this.class64_0.list_4 != null)
			{
				this.class64_0.class533_2.Text = ((this.int_1 < 0) ? "" : this.class64_0.list_4[this.int_1].string_0);
				this.class64_0.class533_2.method_40(Color.get_White(), 300);
				return;
			}
		}

		// Token: 0x06002936 RID: 10550
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002944 RID: 10564
		// RVA: 0x001044B0 File Offset: 0x001026B0
		internal override void vmethod_3()
		{
			bMatch class10_ = Class64.class10_0;
			this.list_1 = new List<int>();
			int num = 0;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if ((class10_.slotStatus[i] & SlotStatus.flag_5) > (SlotStatus)0 && class10_.slotTeam[i] == class10_.slotTeam[this.class64_0.int_35])
				{
					this.list_1.Add(i);
					num++;
				}
			}
			Class297 class297_ = this.class64_0.class297_0;
			int num2 = -1;
			this.list_0 = new List<Class705>();
			Class705 class = null;
			bool flag = true;
			bool flag2;
			if (flag2 = (Class72.color_0 != Color.get_TransparentWhite()))
			{
				Class885.interface17_0.imethod_1(Class72.color_0);
			}
			int j = 0;
			while (j < class297_.int_14)
			{
				Class304 class2 = class297_.list_3[j];
				bool flag3 = class2.NewCombo || flag;
				bool flag4 = class2.IsType(HitObjectType.Spinner) || class2 is Class317;
				if (flag3)
				{
					if (!flag4)
					{
						num2 = (num2 + 1) % num;
						flag = false;
					}
					if (!flag4)
					{
						if (this.list_1[num2] != this.class64_0.int_35)
						{
							class = null;
							goto IL_17C;
						}
					}
					int int_ = (j > 0) ? Math.Max(class2.StartTime - class297_.HitWindow50, class297_.list_3[j - 1].EndTime + 1) : (class2.StartTime - class297_.HitWindow50);
					int endTime = class2.EndTime;
					class = new Class705(int_, endTime);
					this.list_0.Add(class);
				}
				IL_17C:
				if (flag4)
				{
					goto IL_1B2;
				}
				if (this.list_1[num2] == this.class64_0.int_35)
				{
					goto IL_1B2;
				}
				class2.bool_5 = false;
				class2.vmethod_0(Color.get_Gray());
				IL_1DB:
				class2.int_4 = (flag4 ? -2 : this.list_1[num2]);
				j++;
				continue;
				IL_1B2:
				if (class != null)
				{
					class.vmethod_1(class2.EndTime + class297_.HitWindow50);
				}
				if (flag2)
				{
					class2.vmethod_0(Class72.color_0);
					goto IL_1DB;
				}
				goto IL_1DB;
			}
			this.method_6();
		}

		// Token: 0x06002947 RID: 10567
		// RVA: 0x001047F4 File Offset: 0x001029F4
		internal override void vmethod_4()
		{
			Predicate<Class304> predicate = null;
			Class669.Class676 class = new Class669.Class676();
			class.class669_0 = this;
			class.class297_0 = this.class64_0.class297_0;
			if (Class802.smethod_0() && !this.class64_0.bool_25 && Class331.int_7 < this.int_0 + class.class297_0.HitWindow50)
			{
				return;
			}
			int num = this.method_1();
			bool flag = num == this.class64_0.int_35 || this.method_0();
			if (this.int_1 != num || Class802.smethod_0() == flag)
			{
				this.int_1 = num;
				this.vmethod_13();
				Class802.class531_0.method_39(flag ? Color.get_White() : Color.get_Gray(), 50, false, Enum70.const_0);
				if (num == -2)
				{
					this.class665_0.method_6();
				}
				else
				{
					this.class665_0.method_5((num == -1) ? null : this.class64_0.list_4[num]);
				}
				if (Class802.smethod_0() == flag)
				{
					Class802.smethod_1(!flag);
					this.class64_0.method_8();
					if (Class802.smethod_0())
					{
						Class669.Class677 class2 = new Class669.Class677();
						class2.class676_0 = class;
						Class802.class512_0 = this.class512_1;
						this.int_0 = Class331.int_7;
						List<Class304> arg_15A_0 = this.class64_0.class297_0.list_4;
						if (predicate == null)
						{
							predicate = new Predicate<Class304>(class.method_0);
						}
						Class304 class3 = arg_15A_0.Find(predicate);
						class2.int_0 = ((class3 != null) ? (class3.StartTime - class.class297_0.HitWindow50) : Class331.int_7);
						while (Class802.int_1 < Class802.class512_0.list_1.Count - 1 && Class802.class512_0.list_1[Class802.int_1].int_0 < class2.int_0)
						{
							Class802.int_1++;
						}
						if (Class802.class512_0.list_1[Class802.int_1].bool_0)
						{
							while (Class802.class512_0.list_1[Class802.int_1].int_0 > class2.int_0 && Class802.class512_0.list_1[Class802.int_1 - 1].bool_0)
							{
								Class802.int_1--;
							}
						}
						else
						{
							while (Class802.class512_0.list_1[Class802.int_1].int_0 > class2.int_0 && !Class802.class512_0.list_1[Class802.int_1].bool_0)
							{
								Class802.int_1--;
							}
						}
						class2.int_0 = Class802.class512_0.list_1[Class802.int_1].int_0;
						class3 = this.class64_0.class297_0.list_4.Find(new Predicate<Class304>(class2.method_0));
						if (class3 != null && class3.int_4 != this.int_1)
						{
							Class802.int_1++;
						}
						Class14 class4 = Class802.class512_0.list_1[Class802.int_1];
						Class14 item = new Class14(class4.int_0 - 1, class4.float_0, class4.float_1, pButtonState.None);
						Class802.class512_0.list_1.Insert(Class802.int_1, item);
						Class802.class512_0.list_1.Insert(Class802.int_1, item);
					}
					else
					{
						Class802.smethod_18();
					}
				}
			}
			base.vmethod_4();
		}

		// Token: 0x0600293E RID: 10558
		// RVA: 0x00103C58 File Offset: 0x00101E58
		internal override Class664 vmethod_5()
		{
			this.class665_0 = new Class665(Class64.class10_0.method_1(), null, new Vector2(0f, (float)((Class62.Mode == PlayModes.Taiko) ? 40 : 150)), true, Class64.bool_55 ? Class64.class10_0.slotTeam[this.class64_0.int_35] : SlotTeams.Blue);
			return this.class665_0;
		}

		// Token: 0x0600293F RID: 10559
		// RVA: 0x00103CC0 File Offset: 0x00101EC0
		internal override void vmethod_6(Struct13 struct13_0)
		{
			Class660 class = this.class64_0.list_4[(int)struct13_0.byte_0];
			class.method_7(struct13_0);
			if (class.method_0() != this.class64_0.class660_0.method_0())
			{
				return;
			}
			this.method_3(class);
		}

		// Token: 0x06002948 RID: 10568
		// RVA: 0x00104B4C File Offset: 0x00102D4C
		internal override void vmethod_7()
		{
			Class62.class664_0.int_2 = Class64.class10_0.method_1();
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (Class64.class10_0.slotStatus[i] != SlotStatus.flag_5)
				{
					this.class64_0.list_4.Add(null);
				}
				else
				{
					Class662 class = new Class662(i, Class64.class10_0.class861_0[i], Class64.class10_0.matchScoringType, Class62.Mode, Class64.class10_0.slotTeam[i]);
					this.class64_0.list_4.Add(class);
					Class62.class664_0.Add(class);
				}
			}
			this.class64_0.class660_0 = this.class64_0.list_4[this.class64_0.int_35];
			if (this.class64_0.class660_0 != null)
			{
				Class62.class664_0.vmethod_0(this.class64_0.class660_0);
			}
			this.class665_0.method_5(null);
			Class62.class664_0.method_2(false);
		}

		// Token: 0x0600293B RID: 10555
		// RVA: 0x0001FB5A File Offset: 0x0001DD5A
		internal override void vmethod_8()
		{
			this.class64_0.method_84();
			if (Class64.bool_55)
			{
				Class115.smethod_70(OsuModes.RankingTeam, false);
				Class723.smethod_2(null, null);
				return;
			}
			Class115.smethod_70(OsuModes.MatchSetup, false);
		}
	}
}
