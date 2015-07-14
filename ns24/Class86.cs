using Amib.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns18;
using ns26;
using ns29;
using ns40;
using ns6;
using ns64;
using ns69;
using ns79;
using ns8;
using ns81;
using ns82;
using ns9;
using osu.GameplayElements.Beatmaps;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns24
{
	// Token: 0x02000694 RID: 1684
	internal sealed class Class86 : Class55
	{
		// Token: 0x02000698 RID: 1688
		[CompilerGenerated]
		private sealed class Class890
		{
			// Token: 0x04003134 RID: 12596
			public List<Class296> list_0;

			// Token: 0x06003510 RID: 13584
			// RVA: 0x00026D32 File Offset: 0x00024F32
			public bool method_0(Class695 class695_0)
			{
				return class695_0.class296_0 != null && this.list_0.Contains(class695_0.class296_0);
			}
		}

		// Token: 0x02000699 RID: 1689
		[CompilerGenerated]
		private sealed class Class891
		{
			// Token: 0x04003135 RID: 12597
			public Class296 class296_0;

			// Token: 0x06003512 RID: 13586
			// RVA: 0x00026D4F File Offset: 0x00024F4F
			public bool method_0(Class695 class695_0)
			{
				return class695_0.class296_0 == this.class296_0;
			}
		}

		// Token: 0x0200069A RID: 1690
		[CompilerGenerated]
		private sealed class Class892
		{
			// Token: 0x04003136 RID: 12598
			public Class296 class296_0;

			// Token: 0x04003137 RID: 12599
			public string string_0;

			// Token: 0x06003514 RID: 13588
			// RVA: 0x00026D5F File Offset: 0x00024F5F
			public bool method_0(Class695 class695_0)
			{
				return class695_0.class296_0 == this.class296_0 && (this.string_0 == null || (class695_0.class695_1 != null && class695_0.class695_1.Name == this.string_0));
			}
		}

		// Token: 0x0200069B RID: 1691
		[CompilerGenerated]
		private sealed class Class893
		{
			// Token: 0x0200069C RID: 1692
			private sealed class Class894
			{
				// Token: 0x0400313A RID: 12602
				public Class86.Class893 class893_0;

				// Token: 0x0400313B RID: 12603
				public List<Class695> list_0;

				// Token: 0x06003518 RID: 13592
				// RVA: 0x0016BFFC File Offset: 0x0016A1FC
				public void method_0()
				{
					this.class893_0.class86_0.method_85();
					Class695 class695_ = this.class893_0.class86_0.method_6();
					this.class893_0.class86_0.list_0 = this.list_0;
					this.class893_0.class86_0.method_7(class695_);
					this.class893_0.class86_0.method_97();
					this.class893_0.class86_0.method_49(0.0);
					this.class893_0.class86_0.int_2++;
				}
			}

			// Token: 0x04003139 RID: 12601
			public Class86 class86_0;

			// Token: 0x04003138 RID: 12600
			public int int_0;

			// Token: 0x06003516 RID: 13590
			// RVA: 0x0016BF78 File Offset: 0x0016A178
			public void method_0()
			{
				Class86.Class893.Class894 class = new Class86.Class893.Class894();
				class.class893_0 = this;
				while (this.int_0 - this.class86_0.int_2 > 1)
				{
					Thread.Sleep(1);
				}
				class.list_0 = new List<Class695>();
				class.list_0.AddRange(this.class86_0.list_0);
				this.class86_0.method_90(class.list_0);
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			}
		}

		// Token: 0x0200069D RID: 1693
		[CompilerGenerated]
		private sealed class Class895
		{
			// Token: 0x0200069E RID: 1694
			private sealed class Class896
			{
				// Token: 0x04003141 RID: 12609
				public Class86.Class895 class895_0;

				// Token: 0x04003142 RID: 12610
				public List<Class695> list_0;

				// Token: 0x0600351C RID: 13596
				// RVA: 0x0016C12C File Offset: 0x0016A32C
				public void method_0()
				{
					this.class895_0.class86_0.method_85();
					this.class895_0.class86_0.method_47();
					this.class895_0.class86_0.method_33(this.class895_0.class86_0.list_0);
					this.class895_0.class86_0.list_0 = this.list_0;
					this.class895_0.class86_0.class605_0.Value = this.class895_0.treeGroupMode_0;
					this.class895_0.class86_0.dictionary_0.Clear();
					this.class895_0.class86_0.method_97();
					if (this.class895_0.voidDelegate_0 != null)
					{
						this.class895_0.voidDelegate_0();
					}
					this.class895_0.class86_0.int_2++;
				}
			}

			// Token: 0x0400313F RID: 12607
			public bool bool_0;

			// Token: 0x0400313D RID: 12605
			public Class86 class86_0;

			// Token: 0x0400313C RID: 12604
			public int int_0;

			// Token: 0x0400313E RID: 12606
			public TreeGroupMode treeGroupMode_0;

			// Token: 0x04003140 RID: 12608
			public VoidDelegate voidDelegate_0;

			// Token: 0x0600351A RID: 13594
			// RVA: 0x0016C098 File Offset: 0x0016A298
			public void method_0()
			{
				Class86.Class895.Class896 class = new Class86.Class895.Class896();
				class.class895_0 = this;
				while (this.int_0 - this.class86_0.int_2 > 1)
				{
					Thread.Sleep(1);
				}
				class.list_0 = new List<Class695>(Class466.list_3.Count);
				this.class86_0.method_92(class.list_0, this.treeGroupMode_0, this.bool_0);
				this.class86_0.method_90(class.list_0);
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			}
		}

		// Token: 0x0200069F RID: 1695
		[CompilerGenerated]
		private sealed class Class897
		{
			// Token: 0x04003143 RID: 12611
			public Rankings rankings_0;

			// Token: 0x0600351E RID: 13598
			// RVA: 0x00026D9B File Offset: 0x00024F9B
			public bool method_0(Class296 class296_0)
			{
				return class296_0.method_41() == this.rankings_0;
			}
		}

		// Token: 0x020006A0 RID: 1696
		[CompilerGenerated]
		private sealed class Class898
		{
			// Token: 0x04003144 RID: 12612
			public double double_0;

			// Token: 0x04003145 RID: 12613
			public double double_1;

			// Token: 0x06003520 RID: 13600
			// RVA: 0x00026DAB File Offset: 0x00024FAB
			public bool method_0(Class296 class296_0)
			{
				return class296_0.method_26() > this.double_0 && class296_0.method_26() <= this.double_1;
			}
		}

		// Token: 0x020006A1 RID: 1697
		[CompilerGenerated]
		private sealed class Class899
		{
			// Token: 0x04003146 RID: 12614
			public int int_0;

			// Token: 0x06003522 RID: 13602
			// RVA: 0x00026DCE File Offset: 0x00024FCE
			public bool method_0(Class296 class296_0)
			{
				return class296_0.int_16 < this.int_0 * 60000 && class296_0.int_16 >= (this.int_0 - 1) * 60000;
			}
		}

		// Token: 0x020006A2 RID: 1698
		[CompilerGenerated]
		private sealed class Class900
		{
			// Token: 0x04003147 RID: 12615
			public int int_0;

			// Token: 0x06003524 RID: 13604
			// RVA: 0x00026DFF File Offset: 0x00024FFF
			public bool method_0(Class296 class296_0)
			{
				return class296_0.method_32() < (double)(this.int_0 * 60) && class296_0.method_32() >= (double)((this.int_0 - 1) * 60);
			}
		}

		// Token: 0x020006A3 RID: 1699
		[CompilerGenerated]
		private sealed class Class901
		{
			// Token: 0x04003148 RID: 12616
			public int int_0;

			// Token: 0x06003526 RID: 13606
			// RVA: 0x00026E2C File Offset: 0x0002502C
			public bool method_0(Class296 class296_0)
			{
				return Class421.smethod_2(class296_0) == this.int_0;
			}
		}

		// Token: 0x02000695 RID: 1685
		// Token: 0x06003504 RID: 13572
		internal delegate void Delegate56(object object_0, Class695 class695_0);

		// Token: 0x02000696 RID: 1686
		// Token: 0x06003508 RID: 13576
		private delegate string Delegate57(Class296 class296_0);

		// Token: 0x02000697 RID: 1687
		// Token: 0x0600350C RID: 13580
		private delegate DateTime Delegate58(Class296 class296_0);

		// Token: 0x040030F6 RID: 12534
		internal bool bool_2;

		// Token: 0x040030FB RID: 12539
		internal bool bool_3 = true;

		// Token: 0x040030FC RID: 12540
		internal bool bool_4;

		// Token: 0x040030FD RID: 12541
		private bool bool_5;

		// Token: 0x040030FE RID: 12542
		internal bool bool_6;

		// Token: 0x04003102 RID: 12546
		private bool bool_7;

		// Token: 0x04003107 RID: 12551
		private bool bool_8;

		// Token: 0x04003108 RID: 12552
		private bool bool_9;

		// Token: 0x040030EB RID: 12523
		internal Class605<TreeGroupMode> class605_0;

		// Token: 0x040030EC RID: 12524
		internal Class605<TreeSortMode> class605_1;

		// Token: 0x040030ED RID: 12525
		private readonly Class911 class911_0;

		// Token: 0x0400310D RID: 12557
		private Class86.Delegate56 delegate56_0;

		// Token: 0x0400310E RID: 12558
		private Class86.Delegate56 delegate56_1;

		// Token: 0x0400310F RID: 12559
		private Class86.Delegate56 delegate56_2;

		// Token: 0x04003110 RID: 12560
		private Class86.Delegate56 delegate56_3;

		// Token: 0x04003111 RID: 12561
		private Class86.Delegate56 delegate56_4;

		// Token: 0x04003112 RID: 12562
		private Class86.Delegate56 delegate56_5;

		// Token: 0x0400311C RID: 12572
		[CompilerGenerated]
		private static Class86.Delegate57 delegate57_0;

		// Token: 0x04003121 RID: 12577
		[CompilerGenerated]
		private static Class86.Delegate57 delegate57_1;

		// Token: 0x04003122 RID: 12578
		[CompilerGenerated]
		private static Class86.Delegate57 delegate57_2;

		// Token: 0x04003129 RID: 12585
		[CompilerGenerated]
		private static Class86.Delegate58 delegate58_0;

		// Token: 0x0400312A RID: 12586
		[CompilerGenerated]
		private static Class86.Delegate58 delegate58_1;

		// Token: 0x0400310C RID: 12556
		private Dictionary<Class695, Class695> dictionary_0 = new Dictionary<Class695, Class695>();

		// Token: 0x0400310B RID: 12555
		private double double_0;

		// Token: 0x04003116 RID: 12566
		private double double_1;

		// Token: 0x04003117 RID: 12567
		private double double_2 = 0.99599999189376831;

		// Token: 0x04003118 RID: 12568
		private double double_3;

		// Token: 0x040030EE RID: 12526
		private float float_0 = 0.6f;

		// Token: 0x040030F5 RID: 12533
		private float float_1 = -1f;

		// Token: 0x040030F8 RID: 12536
		private float float_2 = 0.0001f;

		// Token: 0x04003104 RID: 12548
		internal float float_3;

		// Token: 0x04003119 RID: 12569
		[CompilerGenerated]
		private float float_4;

		// Token: 0x040030EA RID: 12522
		private IComparer<Class695> icomparer_0;

		// Token: 0x04003103 RID: 12547
		private int int_10 = -1;

		// Token: 0x04003105 RID: 12549
		private int int_11;

		// Token: 0x04003106 RID: 12550
		private int int_12;

		// Token: 0x04003109 RID: 12553
		private int int_13 = -1;

		// Token: 0x0400310A RID: 12554
		private int int_14;

		// Token: 0x040030EF RID: 12527
		private volatile int int_2;

		// Token: 0x040030F0 RID: 12528
		private volatile int int_3;

		// Token: 0x040030F2 RID: 12530
		internal int int_4;

		// Token: 0x040030F3 RID: 12531
		internal int int_5;

		// Token: 0x040030F7 RID: 12535
		private int int_6;

		// Token: 0x040030FF RID: 12543
		private int int_7 = -1;

		// Token: 0x04003100 RID: 12544
		private int int_8 = -1;

		// Token: 0x04003101 RID: 12545
		private int int_9 = -1;

		// Token: 0x040030FA RID: 12538
		private LinkedList<Class296> linkedList_0 = new LinkedList<Class296>();

		// Token: 0x040030F1 RID: 12529
		internal List<Class695> list_0 = new List<Class695>();

		// Token: 0x040030F4 RID: 12532
		private List<float> list_1 = new List<float>();

		// Token: 0x040030F9 RID: 12537
		private List<int> list_2 = new List<int>();

		// Token: 0x0400311A RID: 12570
		[CompilerGenerated]
		private static Predicate<Class695> predicate_0;

		// Token: 0x0400311B RID: 12571
		[CompilerGenerated]
		private static Predicate<Class296> predicate_1;

		// Token: 0x04003127 RID: 12583
		[CompilerGenerated]
		private static Predicate<Class296> predicate_10;

		// Token: 0x04003128 RID: 12584
		[CompilerGenerated]
		private static Predicate<Class296> predicate_11;

		// Token: 0x0400312B RID: 12587
		[CompilerGenerated]
		private static Predicate<Class296> predicate_12;

		// Token: 0x0400312C RID: 12588
		[CompilerGenerated]
		private static Predicate<Class296> predicate_13;

		// Token: 0x0400312D RID: 12589
		[CompilerGenerated]
		private static Predicate<Class296> predicate_14;

		// Token: 0x0400312E RID: 12590
		[CompilerGenerated]
		private static Predicate<Class296> predicate_15;

		// Token: 0x0400312F RID: 12591
		[CompilerGenerated]
		private static Predicate<Class296> predicate_16;

		// Token: 0x04003130 RID: 12592
		[CompilerGenerated]
		private static Predicate<Class296> predicate_17;

		// Token: 0x04003131 RID: 12593
		[CompilerGenerated]
		private static Predicate<Class296> predicate_18;

		// Token: 0x04003132 RID: 12594
		[CompilerGenerated]
		private static Predicate<Class296> predicate_19;

		// Token: 0x0400311D RID: 12573
		[CompilerGenerated]
		private static Predicate<Class296> predicate_2;

		// Token: 0x04003133 RID: 12595
		[CompilerGenerated]
		private static Predicate<Class296> predicate_20;

		// Token: 0x0400311E RID: 12574
		[CompilerGenerated]
		private static Predicate<Class296> predicate_3;

		// Token: 0x0400311F RID: 12575
		[CompilerGenerated]
		private static Predicate<Class296> predicate_4;

		// Token: 0x04003120 RID: 12576
		[CompilerGenerated]
		private static Predicate<Class296> predicate_5;

		// Token: 0x04003123 RID: 12579
		[CompilerGenerated]
		private static Predicate<Class296> predicate_6;

		// Token: 0x04003124 RID: 12580
		[CompilerGenerated]
		private static Predicate<Class296> predicate_7;

		// Token: 0x04003125 RID: 12581
		[CompilerGenerated]
		private static Predicate<Class296> predicate_8;

		// Token: 0x04003126 RID: 12582
		[CompilerGenerated]
		private static Predicate<Class296> predicate_9;

		// Token: 0x04003115 RID: 12565
		private SmartThreadPool smartThreadPool_0;

		// Token: 0x04003113 RID: 12563
		private VoidDelegate voidDelegate_0;

		// Token: 0x04003114 RID: 12564
		private VoidDelegate voidDelegate_1;

		// Token: 0x0600349B RID: 13467
		// RVA: 0x00168B90 File Offset: 0x00166D90
		internal Class86(Class114 class114_1) : base(class114_1)
		{
			this.smartThreadPool_0 = new SmartThreadPool(new STPStartInfo
			{
				MaxWorkerThreads = 1,
				AreThreadsBackground = true,
				IdleTimeout = 1000,
				ThreadPriority = ThreadPriority.Normal
			});
			Class115.smethod_50(new Delegate1(this.method_34));
			Class466.smethod_0(new EventHandler(this.method_44));
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_39), Enum98.const_2, Enum97.const_0);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_40), Enum98.const_2, Enum97.const_0);
			Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_38), Enum98.const_2, Enum97.const_0);
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_37), Enum98.const_2, Enum97.const_0);
			Class570.smethod_4(new Class570.Delegate45(this.method_41));
			Class569.smethod_0(new Class569.Delegate43(this.method_42));
			Class466.smethod_19(new Class466.Delegate33(this.method_32));
			this.class911_0 = new Class911(true);
			this.class605_0 = Class341.class605_23;
			this.class605_1 = Class341.class605_24;
			Comparison<Class296> comparison_ = delegate(Class296 class296_0, Class296 class296_1)
			{
				if (class296_0 == class296_1)
				{
					return 0;
				}
				if (!class296_0.bool_4)
				{
					return 1;
				}
				if (!class296_1.bool_4)
				{
					return -1;
				}
				int num = 0;
				switch (this.class605_1.Value)
				{
				case TreeSortMode.Artist:
					num = class296_0.Artist.CompareTo(class296_1.Artist);
					if (num != 0)
					{
						return num;
					}
					break;
				case TreeSortMode.BPM:
					num = class296_0.method_32().CompareTo(class296_1.method_32());
					goto IL_171;
				case TreeSortMode.Creator:
					num = class296_0.string_5.CompareTo(class296_1.string_5);
					goto IL_171;
				case TreeSortMode.Date:
					if (!(class296_0.method_3() != class296_1.method_3()) && (!class296_0.bool_10 || !class296_1.bool_10) && Math.Abs((class296_0.dateTime_1 - class296_1.dateTime_1).TotalSeconds) <= 10.0)
					{
						num = 0;
						goto IL_171;
					}
					num = class296_0.dateTime_1.CompareTo(class296_1.dateTime_1);
					goto IL_171;
				case TreeSortMode.Difficulty:
					num = class296_0.method_26().CompareTo(class296_1.method_26());
					goto IL_171;
				case TreeSortMode.Length:
					num = (class296_0.int_16 / 1000).CompareTo(class296_1.int_16 / 1000);
					goto IL_171;
				case TreeSortMode.Rank:
					num = class296_1.method_41().CompareTo(class296_0.method_41());
					goto IL_171;
				case TreeSortMode.Title:
					break;
				default:
					goto IL_171;
				}
				num = class296_0.Title.CompareTo(class296_1.Title);
				IL_171:
				if (num != 0)
				{
					return num;
				}
				num = class296_0.string_4.CompareTo(class296_1.string_4);
				if (num != 0)
				{
					return num;
				}
				num = class296_0.method_29().CompareTo(class296_1.method_29());
				if (num != 0)
				{
					return num;
				}
				num = class296_0.method_28().CompareTo(class296_1.method_28());
				if (num != 0)
				{
					return num;
				}
				num = class296_0.string_9.CompareTo(class296_1.string_9);
				if (num != 0)
				{
					return num;
				}
				return 0;
			};
			this.icomparer_0 = new Class700(comparison_);
		}

		// Token: 0x0600349D RID: 13469
		// RVA: 0x00168D88 File Offset: 0x00166F88
		protected override void Dispose(bool bool_10)
		{
			this.smartThreadPool_0.Shutdown(false, 0);
			this.smartThreadPool_0.Dispose();
			Class115.smethod_51(new Delegate1(this.method_34));
			Class466.smethod_1(new EventHandler(this.method_44));
			Class570.smethod_5(new Class570.Delegate45(this.method_41));
			Class569.smethod_1(new Class569.Delegate43(this.method_42));
			Class466.smethod_20(new Class466.Delegate33(this.method_32));
			if (this.class911_0 != null)
			{
				this.class911_0.Dispose();
			}
			this.method_33(this.list_0);
			base.Dispose(bool_10);
		}

		// Token: 0x060034B0 RID: 13488
		// RVA: 0x000269F1 File Offset: 0x00024BF1
		public override void Draw()
		{
			base.Draw();
			this.class911_0.Draw();
		}

		// Token: 0x060034B3 RID: 13491
		// RVA: 0x00026A05 File Offset: 0x00024C05
		public override void imethod_2()
		{
			this.method_84();
			if (this.bool_3)
			{
				this.method_51();
			}
			this.method_52();
			if (this.int_9 >= 0)
			{
				this.method_87(this.int_9);
			}
			this.method_66();
			base.imethod_2();
		}

		// Token: 0x0600347B RID: 13435
		// RVA: 0x001687A0 File Offset: 0x001669A0
		internal int method_1(int int_15, int int_16, bool bool_10)
		{
			do
			{
				int_15 += int_16;
			}
			while (int_15 >= 0 && int_15 < this.list_0.Count && ((this.list_0[int_15].bool_3 && !bool_10) || this.list_0[int_15] is Class696));
			return int_15;
		}

		// Token: 0x06003484 RID: 13444
		// RVA: 0x00026943 File Offset: 0x00024B43
		private bool method_10()
		{
			return this.int_10 >= 0;
		}

		// Token: 0x06003485 RID: 13445
		// RVA: 0x00026951 File Offset: 0x00024B51
		internal int method_11()
		{
			if (this.int_10 < 0)
			{
				return this.int_9;
			}
			return this.int_10;
		}

		// Token: 0x06003486 RID: 13446
		// RVA: 0x00026969 File Offset: 0x00024B69
		[CompilerGenerated]
		internal float method_12()
		{
			return this.float_4;
		}

		// Token: 0x06003487 RID: 13447
		// RVA: 0x00026971 File Offset: 0x00024B71
		[CompilerGenerated]
		private void method_13(float float_5)
		{
			this.float_4 = float_5;
		}

		// Token: 0x06003488 RID: 13448
		// RVA: 0x0002697A File Offset: 0x00024B7A
		internal float method_14()
		{
			return -(this.float_1 * this.method_12());
		}

		// Token: 0x0600348A RID: 13450
		// RVA: 0x0002699E File Offset: 0x00024B9E
		private bool method_15()
		{
			return this.int_7 >= 0;
		}

		// Token: 0x0600348B RID: 13451
		// RVA: 0x00168810 File Offset: 0x00166A10
		internal void method_16(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_0;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600348C RID: 13452
		// RVA: 0x00168848 File Offset: 0x00166A48
		internal void method_17(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_0;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600348D RID: 13453
		// RVA: 0x00168880 File Offset: 0x00166A80
		internal void method_18(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_1;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600348E RID: 13454
		// RVA: 0x001688B8 File Offset: 0x00166AB8
		internal void method_19(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_1;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600347C RID: 13436
		// RVA: 0x00026883 File Offset: 0x00024A83
		private float method_2(int int_15, float float_5)
		{
			if (this.float_1 > 0f && int_15 >= 0)
			{
				return Math.Max(0f, this.list_1[int_15] + float_5) / this.float_1;
			}
			return -1f;
		}

		// Token: 0x0600348F RID: 13455
		// RVA: 0x001688F0 File Offset: 0x00166AF0
		internal void method_20(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_2;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_2, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003490 RID: 13456
		// RVA: 0x00168928 File Offset: 0x00166B28
		internal void method_21(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_2;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_2, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003491 RID: 13457
		// RVA: 0x00168960 File Offset: 0x00166B60
		internal void method_22(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_3;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_3, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003492 RID: 13458
		// RVA: 0x00168998 File Offset: 0x00166B98
		internal void method_23(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_3;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_3, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003493 RID: 13459
		// RVA: 0x001689D0 File Offset: 0x00166BD0
		internal void method_24(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_4;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_4, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003494 RID: 13460
		// RVA: 0x00168A08 File Offset: 0x00166C08
		internal void method_25(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_4;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_4, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003495 RID: 13461
		// RVA: 0x00168A40 File Offset: 0x00166C40
		internal void method_26(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_5;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Combine(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_5, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003496 RID: 13462
		// RVA: 0x00168A78 File Offset: 0x00166C78
		internal void method_27(Class86.Delegate56 delegate56_6)
		{
			Class86.Delegate56 delegate = this.delegate56_5;
			Class86.Delegate56 delegate2;
			do
			{
				delegate2 = delegate;
				Class86.Delegate56 value = (Class86.Delegate56)Delegate.Remove(delegate2, delegate56_6);
				delegate = Interlocked.CompareExchange<Class86.Delegate56>(ref this.delegate56_5, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003497 RID: 13463
		// RVA: 0x00168AB0 File Offset: 0x00166CB0
		internal void method_28(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = this.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003498 RID: 13464
		// RVA: 0x00168AE8 File Offset: 0x00166CE8
		internal void method_29(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = this.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x0600347D RID: 13437
		// RVA: 0x000268BB File Offset: 0x00024ABB
		private Class695 method_3(int int_15)
		{
			if (int_15 < 0)
			{
				return null;
			}
			return this.list_0[int_15];
		}

		// Token: 0x06003499 RID: 13465
		// RVA: 0x00168B20 File Offset: 0x00166D20
		internal void method_30(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = this.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x0600349A RID: 13466
		// RVA: 0x00168B58 File Offset: 0x00166D58
		internal void method_31(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = this.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x0600349C RID: 13468
		// RVA: 0x00168D4C File Offset: 0x00166F4C
		private void method_32(object object_0, List<Class296> list_3)
		{
			Class86.Class890 class = new Class86.Class890();
			class.list_0 = list_3;
			List<Class695> ienumerable_ = this.list_0.FindAll(new Predicate<Class695>(class.method_0));
			this.Remove(ienumerable_);
		}

		// Token: 0x0600349E RID: 13470
		// RVA: 0x00168E28 File Offset: 0x00167028
		private void method_33(List<Class695> list_3)
		{
			foreach (Class695 current in list_3)
			{
				current.Dispose();
			}
		}

		// Token: 0x0600349F RID: 13471
		// RVA: 0x000269AC File Offset: 0x00024BAC
		private void method_34(bool bool_10)
		{
			this.method_33(this.list_0);
		}

		// Token: 0x060034A0 RID: 13472
		// RVA: 0x000269BA File Offset: 0x00024BBA
		internal Class695 method_35(Class296 class296_0, Class695 class695_0, PlayModes? nullable_0)
		{
			return new Class695(class296_0, class695_0, nullable_0);
		}

		// Token: 0x060034A1 RID: 13473
		// RVA: 0x000269C4 File Offset: 0x00024BC4
		internal Class696 method_36(string string_0)
		{
			return new Class696(string_0);
		}

		// Token: 0x060034A2 RID: 13474
		// RVA: 0x00168E78 File Offset: 0x00167078
		private bool method_37(object object_0, EventArgs eventArgs_0)
		{
			if (this.bool_3 && (!Class111.bool_1 || !Class111.bool_2))
			{
				this.method_53();
				this.int_13 = this.int_7;
				this.bool_7 = false;
				if (!this.method_15() && Class802.buttonState_5 == 1)
				{
					this.bool_9 = true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060034A3 RID: 13475
		// RVA: 0x00168ED0 File Offset: 0x001670D0
		private bool method_38(object object_0, EventArgs eventArgs_0)
		{
			bool flag = this.bool_5;
			if (Class802.buttonState_0 != 1)
			{
				if (this.bool_8)
				{
					this.double_0 *= (double)((float)Math.Pow(0.95, Math.Max(0.0, this.double_1 - 66.0)));
					this.double_1 = 0.0;
				}
				this.bool_5 = false;
				this.bool_8 = false;
			}
			if (!this.bool_3)
			{
				return false;
			}
			if (this.int_13 < 0 || this.int_13 >= this.list_0.Count)
			{
				return false;
			}
			if (!flag && this.list_0.Count != 0 && this.list_0[this.int_13].Contains(Class800.smethod_15()))
			{
				this.bool_7 = false;
				Class695 class = this.list_0[this.int_13];
				if (!(class is Class696))
				{
					if (this.int_13 == this.int_9)
					{
						if (!Class802.bool_22 && this.delegate56_3 != null)
						{
							this.delegate56_3(this, class);
							goto IL_145;
						}
						goto IL_145;
					}
				}
				if (class.method_19() <= Enum63.const_1)
				{
					this.method_72(this.int_13, true);
				}
				else
				{
					this.Select(this.int_13, true);
				}
				IL_145:
				if (Class802.bool_22 && this.delegate56_2 != null)
				{
					this.delegate56_2(this, class);
				}
				this.int_13 = -1;
				return false;
			}
			return false;
		}

		// Token: 0x060034A4 RID: 13476
		// RVA: 0x0016904C File Offset: 0x0016724C
		private bool method_39(object object_0, EventArgs eventArgs_0)
		{
			this.bool_7 = false;
			this.double_0 -= 0.4 * (1.0 + Math.Min(Math.Abs(this.double_0) / 2.0, 5.0));
			this.double_2 = 0.994;
			return true;
		}

		// Token: 0x0600347E RID: 13438
		// RVA: 0x001687F0 File Offset: 0x001669F0
		internal Class696 method_4()
		{
			return this.method_3(this.int_8) as Class696;
		}

		// Token: 0x060034A5 RID: 13477
		// RVA: 0x001690B4 File Offset: 0x001672B4
		private bool method_40(object object_0, EventArgs eventArgs_0)
		{
			this.bool_7 = false;
			this.double_0 += 0.4 * (1.0 + Math.Min(Math.Abs(this.double_0) / 2.0, 5.0));
			this.double_2 = 0.994;
			return true;
		}

		// Token: 0x060034A6 RID: 13478
		// RVA: 0x0016911C File Offset: 0x0016731C
		private bool method_41(object object_0, Keys keys_0, bool bool_10)
		{
			if (!this.bool_3)
			{
				return false;
			}
			switch (keys_0)
			{
			case 33:
				this.method_80(-10, true, false);
				return true;
			case 34:
				this.method_80(10, true, false);
				return true;
			case 35:
			case 36:
				break;
			case 37:
			case 39:
				if (bool_10)
				{
					if (Class570.bool_2)
					{
						this.method_79((keys_0 == 37) ? -1 : 1);
					}
					else if (this.method_10())
					{
						this.method_72(this.int_10, true);
					}
					else
					{
						this.method_80((keys_0 == 37) ? -1 : 1, false, true);
					}
				}
				return true;
			case 38:
				goto IL_C6;
			case 40:
				goto IL_116;
			default:
				switch (keys_0)
				{
				case 342:
					goto IL_C6;
				case 343:
					goto IL_116;
				}
				break;
			}
			if (!bool_10 || keys_0 != 13)
			{
				return false;
			}
			if (Class115.class80_0.method_7())
			{
				return true;
			}
			if (Class570.bool_2 && !Class570.bool_0)
			{
				this.method_78();
			}
			else if (this.method_10())
			{
				this.method_72(this.int_10, true);
			}
			else if (this.delegate56_3 != null)
			{
				this.delegate56_3(this, this.method_6());
			}
			return true;
			IL_C6:
			this.method_80(-1, true, false);
			return true;
			IL_116:
			this.method_80(1, true, false);
			return true;
		}

		// Token: 0x060034A7 RID: 13479
		// RVA: 0x0016924C File Offset: 0x0016744C
		private void method_42(object object_0, List<Keys> list_3)
		{
			Keys keys = list_3[0];
			Keys keys2 = keys;
			if (keys2 != 341)
			{
				return;
			}
			this.method_41(null, 13, true);
		}

		// Token: 0x060034A8 RID: 13480
		// RVA: 0x00169278 File Offset: 0x00167478
		internal void method_43()
		{
			foreach (Class695 current in this.list_0)
			{
				if (current.class296_0 != null && current.class531_1 != null)
				{
					if (current.class296_0.method_41() <= Rankings.D && current.class296_0.bool_13)
					{
						current.class296_0.bool_13 = false;
					}
					current.method_9();
				}
			}
		}

		// Token: 0x060034A9 RID: 13481
		// RVA: 0x00169304 File Offset: 0x00167504
		internal void method_44(object sender, EventArgs e)
		{
			VoidDelegate voidDelegate = null;
			if (this.list_0 == null)
			{
				return;
			}
			this.method_43();
			if (Class466.list_0 == null)
			{
				Class115.class47_0.Add(new VoidDelegate(Class466.smethod_28), false);
				Class47 arg_46_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_98);
				}
				arg_46_0.Add(voidDelegate, false);
			}
		}

		// Token: 0x060034AA RID: 13482
		// RVA: 0x000269CC File Offset: 0x00024BCC
		internal void method_45()
		{
			this.int_7 = -1;
			this.method_46();
		}

		// Token: 0x060034AB RID: 13483
		// RVA: 0x0016935C File Offset: 0x0016755C
		internal void method_46()
		{
			if (this.int_10 >= 0)
			{
				Class695 class = this.list_0[this.int_10];
				class.method_23(class.method_4(), 50);
			}
			this.int_10 = -1;
		}

		// Token: 0x060034AC RID: 13484
		// RVA: 0x000269DB File Offset: 0x00024BDB
		internal void method_47()
		{
			this.method_45();
			this.int_9 = -1;
			this.int_8 = -1;
		}

		// Token: 0x060034AD RID: 13485
		// RVA: 0x0016939C File Offset: 0x0016759C
		private void method_48(float float_5, double double_4)
		{
			if (double_4 == 0.0)
			{
				this.double_0 = 0.0;
				this.method_13(float_5);
				return;
			}
			float num = (float_5 - this.method_12()) * this.float_1;
			this.double_2 = double_4;
			this.double_0 = (double)(-(double)num * (float)Math.Log(this.double_2));
		}

		// Token: 0x060034AE RID: 13486
		// RVA: 0x001693FC File Offset: 0x001675FC
		internal void method_49(double double_4)
		{
			int int_ = (!this.bool_7 || this.int_10 < 0) ? this.int_9 : this.int_10;
			Class695 class = this.method_3(int_);
			if (class != null && class.class695_1 != null && !class.class695_1.method_16())
			{
				int_ = this.int_8;
			}
			this.method_50(int_, -220f, double_4);
		}

		// Token: 0x0600347F RID: 13439
		// RVA: 0x000268CF File Offset: 0x00024ACF
		internal Class296 method_5()
		{
			if (!this.method_8())
			{
				return null;
			}
			return this.method_6().class296_0;
		}

		// Token: 0x060034AF RID: 13487
		// RVA: 0x00169460 File Offset: 0x00167660
		internal void method_50(int int_15, float float_5, double double_4)
		{
			float num = this.method_2(int_15, float_5);
			if (num >= 0f)
			{
				this.method_48(num, double_4);
			}
		}

		// Token: 0x060034B1 RID: 13489
		// RVA: 0x00169488 File Offset: 0x00167688
		public void method_51()
		{
			if (Class802.buttonState_0 == 1)
			{
				if (this.bool_8 && Class115.double_9 > 0.0)
				{
					this.double_1 += Class115.double_9;
					double num = (double)((float)(this.int_14 - Class800.smethod_15().Y) * Class115.float_6) / this.double_1;
					this.double_3 = num * this.double_1;
					float num2 = (float)Math.Pow((Math.Sign(num) == -Math.Sign(this.double_0) || Math.Abs(num) > Math.Abs(this.double_0)) ? 0.9 : 0.95, this.double_1);
					if (num != 0.0)
					{
						this.double_1 = 0.0;
						this.double_0 = this.double_0 * (double)num2 + (double)(1f - num2) * num;
						this.double_2 = ((this.double_0 == 0.0) ? 0.5 : Math.Max(0.5, 0.99599999189376831 - 0.002 / Math.Abs(this.double_0)));
					}
					if (this.method_15() && Class800.smethod_19().X / Class115.float_4 < Class86.smethod_0() - 200f && this.delegate56_5 != null)
					{
						this.delegate56_5(this, this.method_3(this.int_7));
					}
				}
				if (Class802.buttonState_1 == null && (this.bool_4 || this.method_15()))
				{
					this.double_3 = 0.0;
					this.bool_8 = true;
					this.double_1 = 0.0;
				}
			}
			else
			{
				this.bool_8 = false;
			}
			this.int_14 = Class800.smethod_15().Y;
			if (Class802.buttonState_5 != 1)
			{
				this.bool_9 = false;
			}
			if ((Class800.smethod_17().X < 200f && !this.bool_8) || (Class111.bool_1 && Class111.bool_2) || this.bool_7)
			{
				this.method_49(0.992);
				return;
			}
			if ((Class802.buttonState_0 == 1 || Class802.buttonState_5 == 1) && !this.bool_5 && Vector2.DistanceSquared(Class800.vector2_0, Class800.smethod_19()) > 6400f)
			{
				this.bool_5 = true;
			}
			if (Class802.buttonState_0 != 1 && this.bool_9)
			{
				float float_ = Class778.smethod_2((Class802.vector2_0.Y - 70f * Class115.float_4) / ((float)Class115.int_23 - 150f * Class115.float_4), 0f, 1f);
				this.method_48(float_, 0.992);
			}
		}

		// Token: 0x060034B2 RID: 13490
		// RVA: 0x00169748 File Offset: 0x00167948
		private void method_52()
		{
			if (!this.bool_8)
			{
				double num = this.double_0;
				this.double_0 *= Math.Pow(this.double_2, Class115.double_9);
				this.double_3 = ((num != this.double_0) ? ((this.double_0 - num) / Math.Log(this.double_2)) : num);
				if (Math.Abs(this.double_0) < 0.01)
				{
					this.double_0 = 0.0;
					this.double_2 = 0.99599999189376831;
				}
			}
			if (this.float_1 > 0f)
			{
				this.method_13(Class778.smethod_2((float)this.double_3 / this.float_1 + this.method_12(), 0f, 1f));
			}
		}

		// Token: 0x060034B4 RID: 13492
		// RVA: 0x00169814 File Offset: 0x00167A14
		private void method_53()
		{
			if (!this.bool_8 && !this.bool_9)
			{
				bool flag = false;
				for (int i = this.int_11; i < this.int_12; i++)
				{
					Class695 class = this.list_0[i];
					if (class.method_11() && class.method_12())
					{
						if (this.int_7 != i && class.method_21())
						{
							this.int_7 = i;
							if (Class114.bool_0)
							{
								Class331.smethod_36(null, "menuclick", 1f, false);
							}
							class.method_22(Class610.smethod_1(class.color_12, 0.3f), 1000);
						}
						flag = true;
					}
				}
				if (!flag)
				{
					this.int_7 = -1;
				}
				return;
			}
		}

		// Token: 0x060034B5 RID: 13493
		// RVA: 0x001698CC File Offset: 0x00167ACC
		internal void method_54()
		{
			int num = 0;
			Class695 class = null;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class695 class2 = this.list_0[i];
				Class696 class3 = class2 as Class696;
				if (class3 != null)
				{
					class = null;
					class3.bool_3 = (class3.method_29() == 0);
					class3.method_30(false);
				}
				else if (class2.bool_3)
				{
					class2.class695_0 = null;
					class2.int_1 = -1;
					class2.method_20(Enum63.const_0);
				}
				else
				{
					if (class == null || class.class296_0.string_4 != class2.class296_0.string_4)
					{
						class = class2;
					}
					class2.class695_0 = class;
					if (class2.method_3())
					{
						num++;
						class2.bool_4 = true;
					}
					else
					{
						class2.class695_0.bool_4 = false;
						class2.bool_4 = false;
					}
					class2.int_1 = num;
					if (!class2.class296_0.bool_13)
					{
						class2.class695_0.method_1(true);
					}
				}
			}
			this.method_55();
			this.method_57();
			this.method_56();
		}

		// Token: 0x060034B6 RID: 13494
		// RVA: 0x001699D4 File Offset: 0x00167BD4
		internal void method_55()
		{
			this.int_4 = 0;
			this.int_5 = 0;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class695 class = this.list_0[i];
				if (!(class is Class696) && !class.bool_3)
				{
					this.method_67(class);
					if (!class.Hidden)
					{
						this.int_4++;
						if (class.method_3())
						{
							this.int_5++;
						}
					}
				}
			}
		}

		// Token: 0x060034B7 RID: 13495
		// RVA: 0x00169A58 File Offset: 0x00167C58
		private void method_56()
		{
			if (this.method_10())
			{
				Class695 class = this.list_0[this.int_10];
				class.method_23(Class610.smethod_0(class.method_4(), 0.4f), 50);
			}
		}

		// Token: 0x060034B8 RID: 13496
		// RVA: 0x00169A98 File Offset: 0x00167C98
		private void method_57()
		{
			int num = 0;
			this.list_1.Clear();
			this.list_1.Capacity = this.list_0.Count;
			Class695 class = null;
			float num2 = 0f;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class695 class2 = this.list_0[i];
				if (class2.method_11())
				{
					if (class2 is Class696)
					{
						if (class != null && !(class is Class696))
						{
							num2 += 10f;
						}
					}
					else if (class2.class296_0 != null && class != null && (class.method_16() || (!class.method_16() && class2.method_16())))
					{
						num2 += 10f;
					}
					class = class2;
					num++;
				}
				this.list_1.Add(200f + num2 + (float)((num - 1) * 48));
			}
			if (num <= 0)
			{
				this.float_1 = -1f;
				return;
			}
			float num3 = this.method_12() * this.float_1;
			this.float_1 = num2 + (float)((num - 1) * 48);
			this.method_13((this.float_1 <= 0f) ? 0f : Class778.smethod_2(num3 / this.float_1, 0f, 1f));
		}

		// Token: 0x060034B9 RID: 13497
		// RVA: 0x00026A42 File Offset: 0x00024C42
		private double method_58()
		{
			return -this.double_0 / Math.Log(this.double_2);
		}

		// Token: 0x060034BB RID: 13499
		// RVA: 0x00169BD0 File Offset: 0x00167DD0
		private float method_59(int int_15)
		{
			float num = 0f;
			Class695 class = this.list_0[int_15];
			if (class is Class696)
			{
				num -= 50f;
			}
			if (class.class296_0 != null && class.method_16())
			{
				num -= 50f;
			}
			if (this.method_15() && int_15 == this.int_7)
			{
				num -= 45f;
			}
			return num;
		}

		// Token: 0x06003480 RID: 13440
		// RVA: 0x000268E6 File Offset: 0x00024AE6
		internal Class695 method_6()
		{
			if (!this.method_8())
			{
				return null;
			}
			return this.method_3(this.int_9);
		}

		// Token: 0x060034BC RID: 13500
		// RVA: 0x00026A7B File Offset: 0x00024C7B
		private float method_60(int int_15)
		{
			return this.method_59(int_15) + Class86.smethod_1(this.list_0[int_15].vector2_0.Y + this.method_14() + (float)this.method_58());
		}

		// Token: 0x060034BD RID: 13501
		// RVA: 0x00169C34 File Offset: 0x00167E34
		private float method_61(int int_15)
		{
			if (this.method_15())
			{
				if (this.int_7 < int_15)
				{
					return this.list_1[int_15] + 10f;
				}
				if (this.int_7 > int_15)
				{
					return this.list_1[int_15] - 10f;
				}
			}
			return this.list_1[int_15];
		}

		// Token: 0x060034BE RID: 13502
		// RVA: 0x00026AAF File Offset: 0x00024CAF
		private Vector2 method_62(int int_15)
		{
			return new Vector2(this.method_60(int_15), this.method_61(int_15));
		}

		// Token: 0x060034C1 RID: 13505
		// RVA: 0x00169C90 File Offset: 0x00167E90
		private void method_63(Vector2 vector2_0)
		{
			this.method_65();
			int num = -1;
			Vector2 vector2_ = Class695.smethod_0();
			for (int i = this.int_11; i < this.int_12; i++)
			{
				Class695 class = this.list_0[i];
				if (class.method_11())
				{
					num = i;
					vector2_ = class.vector2_0;
					IL_135:
					while (this.int_11 > 0)
					{
						class = this.list_0[this.int_11 - 1];
						float num2 = this.method_61(this.int_11 - 1);
						if (Class86.smethod_2(num2 + vector2_0.Y))
						{
							break;
						}
						this.method_68(class, true);
						this.int_11--;
						if (class.method_11())
						{
							if (num >= 0)
							{
								float num3 = this.method_59(this.int_11);
								vector2_.Y += this.list_1[this.int_11] - this.list_1[num];
								vector2_.X = Math.Min(vector2_.X - this.method_59(num) + num3, num3 + vector2_0.X + 200f);
								num = this.int_11;
							}
							else
							{
								vector2_ = this.method_62(this.int_11) + vector2_0;
							}
						}
						class.vector2_0 = vector2_;
					}
					num = -1;
					vector2_ = Class695.smethod_0();
					for (int j = this.int_12 - 1; j >= this.int_11; j--)
					{
						class = this.list_0[j];
						if (class.method_11())
						{
							num = j;
							vector2_ = class.vector2_0;
							IL_27C:
							while (this.int_12 < this.list_0.Count)
							{
								class = this.list_0[this.int_12];
								float num4 = this.method_61(this.int_12);
								if (Class86.smethod_3(num4 + vector2_0.Y))
								{
									return;
								}
								this.method_68(class, true);
								this.int_12++;
								if (class.method_11())
								{
									if (num >= 0)
									{
										float num5 = this.method_59(this.int_12 - 1);
										vector2_.Y += this.list_1[this.int_12 - 1] - this.list_1[num];
										vector2_.X = Math.Min(vector2_.X - this.method_59(num) + num5, num5 + vector2_0.X + 200f);
										num = this.int_12 - 1;
									}
									else
									{
										vector2_ = this.method_62(this.int_12 - 1) + vector2_0;
									}
								}
								class.vector2_0 = vector2_;
							}
							return;
						}
					}
					goto IL_27C;
				}
			}
			goto IL_135;
		}

		// Token: 0x060034C2 RID: 13506
		// RVA: 0x00026AD8 File Offset: 0x00024CD8
		internal void method_64()
		{
			this.int_11 = 0;
			this.int_12 = this.list_0.Count;
		}

		// Token: 0x060034C3 RID: 13507
		// RVA: 0x00026AF2 File Offset: 0x00024CF2
		internal void method_65()
		{
			this.int_12 = Math.Min(this.int_12, this.list_0.Count);
		}

		// Token: 0x060034C4 RID: 13508
		// RVA: 0x00169F30 File Offset: 0x00168130
		private void method_66()
		{
			Vector2 vector;
			vector..ctor(Class86.smethod_0() + this.float_3, 0f);
			Vector2 vector2;
			vector2..ctor(0f, this.method_14());
			this.method_63(vector + vector2 - new Vector2(0f, (float)this.method_58()));
			this.method_53();
			this.class911_0.Clear(false);
			for (int i = this.int_11; i < this.int_12; i++)
			{
				Class695 class = this.list_0[i];
				if (class.method_11())
				{
					Vector2 vector3 = this.method_62(i) + vector;
					Vector2 vector2_;
					if (this.bool_6)
					{
						vector2_ = vector3;
					}
					else
					{
						vector2_ = class.vector2_0;
						float num = vector3.X - vector2_.X;
						num *= (float)Math.Pow(0.95, Class115.double_0);
						float num2 = vector3.Y - vector2_.Y;
						num2 *= (float)Math.Pow(0.875, Class115.double_0);
						vector2_.X = vector3.X - num;
						vector2_.Y = vector3.Y - num2;
					}
					class.vector2_0 = vector2_;
					bool flag = Class86.smethod_2(vector2_.Y + this.method_14());
					bool flag2 = Class86.smethod_3(vector2_.Y + this.method_14());
					if (!flag && !flag2)
					{
						if (!class.bool_6)
						{
							class.Initialize(true);
						}
						else
						{
							this.method_68(class, false);
						}
						class.method_15(vector2);
						class.method_13(this.class911_0);
					}
					else if (Class86.smethod_3(vector3.Y + this.method_14()) && flag2)
					{
						for (int j = this.int_12 - 1; j >= i; j--)
						{
							this.list_0[j].vector2_0 = this.method_62(j) + vector;
						}
						this.int_12 = Math.Min(i, this.int_12);
					}
					else if (Class86.smethod_2(vector3.Y + this.method_14()) && flag)
					{
						for (int k = this.int_11; k <= i; k++)
						{
							this.list_0[k].vector2_0 = this.method_62(k) + vector;
						}
						this.int_11 = Math.Max(i + 1, this.int_11);
					}
				}
			}
			this.bool_6 = false;
		}

		// Token: 0x060034C5 RID: 13509
		// RVA: 0x0016A1A4 File Offset: 0x001683A4
		private void method_67(Class695 class695_0)
		{
			if ((class695_0.class695_1 != null && !class695_0.class695_1.method_16()) || class695_0.bool_3)
			{
				class695_0.method_20(Enum63.const_0);
				return;
			}
			Class695 class = this.method_6();
			bool flag = class != null && class.class296_0 != null && class695_0.class296_0 != null && class695_0.class296_0.string_4 == class.class296_0.string_4;
			if (class695_0 == class)
			{
				class695_0.method_20(Enum63.const_4);
			}
			else if (flag)
			{
				class695_0.method_20(Enum63.const_3);
			}
			else if (class695_0.bool_4)
			{
				class695_0.method_20(Enum63.const_2);
			}
			else if (class695_0.method_3())
			{
				class695_0.method_20(Enum63.const_1);
			}
			else
			{
				class695_0.method_20(Enum63.const_0);
			}
			if (class695_0.method_16() && this.delegate56_4 != null)
			{
				this.delegate56_4(this, class695_0);
			}
		}

		// Token: 0x060034C6 RID: 13510
		// RVA: 0x00026B10 File Offset: 0x00024D10
		private void method_68(Class695 class695_0, bool bool_10)
		{
			if (this.dictionary_0.ContainsKey(class695_0))
			{
				class695_0.method_6(bool_10);
				this.dictionary_0.Remove(class695_0);
			}
		}

		// Token: 0x060034C7 RID: 13511
		// RVA: 0x0016A270 File Offset: 0x00168470
		public void method_69()
		{
			this.dictionary_0.Clear();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class695 class = this.list_0[i];
				if (!(class is Class696))
				{
					this.dictionary_0.Add(class, class);
				}
			}
		}

		// Token: 0x06003481 RID: 13441
		// RVA: 0x000268FE File Offset: 0x00024AFE
		private void method_7(Class695 class695_0)
		{
			this.int_9 = this.list_0.IndexOf(class695_0);
		}

		// Token: 0x060034C8 RID: 13512
		// RVA: 0x0016A2C0 File Offset: 0x001684C0
		public void method_70(Class296 class296_0)
		{
			Class86.Class891 class = new Class86.Class891();
			class.class296_0 = class296_0;
			List<Class695> list = this.list_0.FindAll(new Predicate<Class695>(class.method_0));
			foreach (Class695 current in list)
			{
				current.method_6(false);
			}
		}

		// Token: 0x060034C9 RID: 13513
		// RVA: 0x0016A334 File Offset: 0x00168534
		internal void method_71(int int_15)
		{
			foreach (Class695 current in this.list_0)
			{
				current.method_18(int_15);
			}
		}

		// Token: 0x060034CA RID: 13514
		// RVA: 0x0016A388 File Offset: 0x00168588
		internal void method_72(int int_15, bool bool_10)
		{
			if (int_15 != -1 && !(this.list_0[int_15] is Class696) && !this.list_0[int_15].bool_3)
			{
				double num = Class115.class861_0.method_0();
				while (int_15 > 0 && !this.list_0[int_15].method_3())
				{
					int_15--;
				}
				double num2 = double.PositiveInfinity;
				for (int i = int_15; i < this.list_0.Count; i = this.method_1(i, 1, false))
				{
					if (this.list_0[i].int_1 != this.list_0[int_15].int_1)
					{
						break;
					}
					Class695 class = this.list_0[i];
					if (class.class296_0 != null && class.class296_0.method_29() == Class62.Mode)
					{
						double num3 = Math.Abs(class.class296_0.method_28() - num);
						if (num3 < num2)
						{
							num2 = num3;
							int_15 = i;
						}
					}
				}
			}
			this.Select(int_15, bool_10);
		}

		// Token: 0x060034CE RID: 13518
		// RVA: 0x00026B34 File Offset: 0x00024D34
		private void method_73(Class695 class695_0)
		{
			this.method_75(this.list_0.IndexOf(class695_0));
		}

		// Token: 0x060034CF RID: 13519
		// RVA: 0x0016A688 File Offset: 0x00168888
		private int method_74(int int_15, bool bool_10)
		{
			int num = this.method_1(int_15, 1, bool_10);
			if (num < this.list_0.Count && this.method_3(num).class296_0.string_4 == this.method_3(int_15).class296_0.string_4)
			{
				return num;
			}
			int num2 = this.method_1(int_15, -1, bool_10);
			if (num2 >= 0)
			{
				return num2;
			}
			if (num < this.list_0.Count)
			{
				return num;
			}
			if (bool_10)
			{
				return -1;
			}
			return this.method_74(int_15, true);
		}

		// Token: 0x060034D0 RID: 13520
		// RVA: 0x0016A708 File Offset: 0x00168908
		private void method_75(int int_15)
		{
			if (int_15 >= 0 && this.list_0.Count != 0)
			{
				if (this.method_3(int_15).method_11())
				{
					this.int_4--;
				}
				if (this.int_9 == int_15)
				{
					this.int_9 = this.method_74(int_15, false);
				}
				Class695 class = this.list_0[int_15];
				if (class.class695_1 != null)
				{
					Class696 class2 = class.class695_1 as Class696;
					class2.list_2.Remove(class);
				}
				this.list_0.RemoveAt(int_15);
				if (this.int_9 > int_15)
				{
					this.int_9--;
				}
				return;
			}
		}

		// Token: 0x060034D1 RID: 13521
		// RVA: 0x0016A7B4 File Offset: 0x001689B4
		private void method_76()
		{
			if (this.method_8())
			{
				this.method_45();
				if (this.method_5() != null && this.method_5().string_4 != Class466.Current.string_4)
				{
					this.method_72(this.int_9, true);
				}
				else
				{
					this.Select(this.int_9, true);
				}
			}
			else
			{
				this.method_47();
			}
			this.method_54();
		}

		// Token: 0x060034D2 RID: 13522
		// RVA: 0x0016A820 File Offset: 0x00168A20
		private void method_77()
		{
			Vector2 vector2_ = this.method_4().vector2_0;
			int num = this.int_8 + 1;
			while (num < this.list_0.Count && !(this.list_0[num] is Class696))
			{
				Class695 class = this.list_0[num];
				if (!class.bool_6 && !Class86.smethod_3(vector2_.Y + this.method_14()) && !Class86.smethod_2(vector2_.Y + this.method_14()))
				{
					class.Initialize(false);
				}
				class.vector2_0 = vector2_;
				if (class.method_3() && class.method_11())
				{
					vector2_.Y += 48f;
				}
				num++;
			}
		}

		// Token: 0x060034D3 RID: 13523
		// RVA: 0x0016A8E4 File Offset: 0x00168AE4
		private void method_78()
		{
			int num = (this.method_4() == null) ? this.int_9 : this.int_8;
			if (num != -1)
			{
				if (this.list_0[num].class695_1 != null || this.list_0[num] is Class696)
				{
					while (!(this.list_0[num] is Class696))
					{
						num--;
					}
					this.method_46();
					this.Select(num, true);
					return;
				}
			}
		}

		// Token: 0x060034D4 RID: 13524
		// RVA: 0x0016A95C File Offset: 0x00168B5C
		private void method_79(int int_15)
		{
			int num = (this.method_4() == null) ? this.int_9 : this.int_8;
			if (num != -1)
			{
				if (this.list_0[num].class695_1 != null || this.list_0[num] is Class696)
				{
					while (!(this.list_0[num] is Class696))
					{
						num--;
					}
					this.method_46();
					int num2 = num;
					int num3 = Math.Sign(int_15);
					int num4 = 0;
					do
					{
						num2 = (this.list_0.Count + num2 + num3) % this.list_0.Count;
						Class695 class = this.list_0[num2];
						if (!class.bool_3 && class is Class696)
						{
							num4++;
						}
						if (num == num2)
						{
							break;
						}
					}
					while (num4 < Math.Abs(int_15));
					this.Select(num2, true);
					return;
				}
			}
		}

		// Token: 0x06003482 RID: 13442
		// RVA: 0x00026912 File Offset: 0x00024B12
		internal bool method_8()
		{
			return this.int_9 >= 0;
		}

		// Token: 0x060034D5 RID: 13525
		// RVA: 0x0016AA38 File Offset: 0x00168C38
		private void method_80(int int_15, bool bool_10, bool bool_11)
		{
			if (int_15 == 0 || this.list_0.Count == 0)
			{
				return;
			}
			int num = this.method_11();
			if (num >= 0 && !this.method_3(num).method_11() && this.method_4() != null && this.method_4().method_16())
			{
				num = this.int_8;
			}
			if (num == -1)
			{
				return;
			}
			int num2 = num;
			int num3 = this.method_8() ? this.method_6().int_1 : -1;
			int num4 = Math.Sign(int_15);
			int num5 = 0;
			do
			{
				num2 = (this.list_0.Count + num2 + num4) % this.list_0.Count;
				Class695 class = this.list_0[num2];
				if (!class.bool_3 && (bool_10 || (!(class is Class696) && class.int_1 != num3)) && (!bool_10 || !class.Hidden))
				{
					num5++;
				}
				if (num == num2)
				{
					break;
				}
			}
			while (num5 < Math.Abs(int_15));
			if (bool_11)
			{
				this.method_72(num2, true);
				return;
			}
			this.method_81(num2);
		}

		// Token: 0x060034D6 RID: 13526
		// RVA: 0x0016AB40 File Offset: 0x00168D40
		internal void method_81(int int_15)
		{
			this.method_46();
			Class695 class = this.list_0[int_15];
			this.bool_7 = true;
			if (this.method_8() && class.int_1 == this.method_6().int_1)
			{
				this.Select(int_15, true);
				return;
			}
			this.int_10 = int_15;
			Class331.smethod_36(null, "menuclick", 1f, false);
			this.method_56();
		}

		// Token: 0x060034D7 RID: 13527
		// RVA: 0x00026B48 File Offset: 0x00024D48
		internal int method_82(int int_15)
		{
			List<Class695> arg_24_0 = this.list_0;
			if (Class86.predicate_0 == null)
			{
				Class86.predicate_0 = new Predicate<Class695>(Class86.smethod_4);
			}
			return arg_24_0.FindIndex(int_15, Class86.predicate_0);
		}

		// Token: 0x060034D8 RID: 13528
		// RVA: 0x0016ABB4 File Offset: 0x00168DB4
		internal bool method_83()
		{
			if (this.list_0.Count < 2 || this.int_4 < 2 || Class115.smethod_92())
			{
				return false;
			}
			this.list_2.Clear();
			for (int i = this.method_82(0); i >= 0; i = this.method_82(i + 1))
			{
				this.list_2.Add(i);
			}
			if (this.list_2.Count <= 0)
			{
				return false;
			}
			if (Class466.Current != null)
			{
				this.linkedList_0.AddLast(Class466.Current);
			}
			if (this.linkedList_0.Count > 20)
			{
				this.linkedList_0.RemoveFirst();
			}
			this.float_2 = 0.0001f;
			this.bool_2 = true;
			if (this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
			this.method_81(this.list_2[Class562.smethod_0(this.list_2.Count)]);
			return true;
		}

		// Token: 0x060034D9 RID: 13529
		// RVA: 0x0016ACA4 File Offset: 0x00168EA4
		private void method_84()
		{
			if (this.bool_2 && Class115.bool_13 && (float)this.int_6++ > this.float_2)
			{
				if (this.int_4 <= 1)
				{
					this.method_85();
					return;
				}
				int num = this.method_11();
				num = this.method_82(num + 1);
				if (num < 0)
				{
					num = this.method_82(0);
				}
				if (num < 0)
				{
					this.method_85();
					return;
				}
				Class331.smethod_36(new int?((int)(Math.Min(50f, this.float_2 + 20f) / 50f * 100f)), "menuclick", 1f, false);
				this.int_6 = 0;
				this.float_2 *= 1.4f;
				if (this.float_2 > (float)Class562.smethod_1(20, 50))
				{
					this.method_85();
					this.float_2 = 0.0001f;
					return;
				}
				this.method_81(num);
			}
		}

		// Token: 0x060034DA RID: 13530
		// RVA: 0x0016AD98 File Offset: 0x00168F98
		internal void method_85()
		{
			if (!this.bool_2)
			{
				return;
			}
			this.bool_2 = false;
			if (this.voidDelegate_1 != null)
			{
				this.voidDelegate_1();
			}
			Class695 class = this.method_3(this.method_11());
			if (class != null && class.method_19() <= Enum63.const_1)
			{
				this.method_72(this.method_11(), true);
				return;
			}
			this.Select(this.method_11(), true);
		}

		// Token: 0x060034DB RID: 13531
		// RVA: 0x00026B73 File Offset: 0x00024D73
		internal void method_86()
		{
			if (this.linkedList_0.Count != 0 && !this.bool_2)
			{
				this.Select(this.linkedList_0.Last.Value, true, null, false);
				this.linkedList_0.RemoveLast();
				return;
			}
		}

		// Token: 0x060034DC RID: 13532
		// RVA: 0x0016ADFC File Offset: 0x00168FFC
		internal void method_87(int int_15)
		{
			int int_16 = this.list_0[int_15].int_1;
			if (int_16 < 0)
			{
				return;
			}
			int num = int_15;
			while (--num >= 0)
			{
				if (this.list_0[num].int_1 != int_16)
				{
					break;
				}
			}
			num++;
			int num2 = int_15;
			while (++num2 < this.list_0.Count)
			{
				if (this.list_0[num2].int_1 != int_16)
				{
					break;
				}
			}
			Class695 class695_ = this.method_6();
			if (this.method_88(this.list_0, num, num2))
			{
				this.method_7(class695_);
				this.method_97();
			}
		}

		// Token: 0x060034DD RID: 13533
		// RVA: 0x0016AE98 File Offset: 0x00169098
		internal bool method_88(List<Class695> list_3, int int_15, int int_16)
		{
			for (int i = int_15 + 1; i < int_16; i++)
			{
				if (this.icomparer_0.Compare(list_3[i - 1], list_3[i]) > 0)
				{
					list_3.Sort(int_15, int_16 - int_15, this.icomparer_0);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060034DE RID: 13534
		// RVA: 0x0016AEE4 File Offset: 0x001690E4
		internal void method_89()
		{
			Class86.Class893 class = new Class86.Class893();
			class.class86_0 = this;
			this.int_3++;
			class.int_0 = this.int_3;
			this.smartThreadPool_0.QueueWorkItem(new Action(class.method_0));
		}

		// Token: 0x06003483 RID: 13443
		// RVA: 0x00026920 File Offset: 0x00024B20
		internal bool method_9()
		{
			return this.method_8() && this.method_3(this.int_9).class296_0 != null;
		}

		// Token: 0x060034DF RID: 13535
		// RVA: 0x0016AF38 File Offset: 0x00169138
		internal void method_90(List<Class695> list_3)
		{
			for (int i = 0; i < list_3.Count; i++)
			{
				int num = i;
				while (num < list_3.Count && !(list_3[num] is Class696))
				{
					num++;
				}
				int num2 = num - i;
				if (num2 != 0)
				{
					this.method_88(list_3, i, num);
					i += num2;
				}
			}
		}

		// Token: 0x060034E0 RID: 13536
		// RVA: 0x0016AF8C File Offset: 0x0016918C
		internal void method_91(TreeGroupMode treeGroupMode_0, bool bool_10, VoidDelegate voidDelegate_2)
		{
			Class86.Class895 class = new Class86.Class895();
			class.treeGroupMode_0 = treeGroupMode_0;
			class.bool_0 = bool_10;
			class.voidDelegate_0 = voidDelegate_2;
			class.class86_0 = this;
			this.int_3++;
			class.int_0 = this.int_3;
			this.smartThreadPool_0.QueueWorkItem(new Action(class.method_0));
		}

		// Token: 0x060034E1 RID: 13537
		// RVA: 0x0016AFF4 File Offset: 0x001691F4
		private void method_92(List<Class695> list_3, TreeGroupMode treeGroupMode_0, bool bool_10)
		{
			switch (treeGroupMode_0)
			{
			case TreeGroupMode.Artist:
				if (Class86.delegate57_0 == null)
				{
					Class86.delegate57_0 = new Class86.Delegate57(Class86.smethod_6);
				}
				this.method_93(list_3, bool_10, Class86.delegate57_0);
				return;
			case TreeGroupMode.BPM:
			{
				Predicate<Class296> predicate = null;
				Class86.Class900 class = new Class86.Class900();
				class.int_0 = 1;
				while (class.int_0 < 6)
				{
					string text = "Under " + class.int_0 * 60 + " BPM";
					string arg_D7_2 = text;
					List<Class296> arg_D1_0 = Class466.list_3;
					if (predicate == null)
					{
						predicate = new Predicate<Class296>(class.method_0);
					}
					this.method_96(list_3, arg_D7_2, arg_D1_0.FindAll(predicate), bool_10);
					class.int_0++;
				}
				string arg_124_2 = "Over 300 BPM";
				List<Class296> arg_11E_0 = Class466.list_3;
				if (Class86.predicate_11 == null)
				{
					Class86.predicate_11 = new Predicate<Class296>(Class86.smethod_18);
				}
				this.method_96(list_3, arg_124_2, arg_11E_0.FindAll(Class86.predicate_11), bool_10);
				return;
			}
			case TreeGroupMode.Creator:
				if (Class86.delegate57_2 == null)
				{
					Class86.delegate57_2 = new Class86.Delegate57(Class86.smethod_12);
				}
				this.method_93(list_3, bool_10, Class86.delegate57_2);
				return;
			case TreeGroupMode.Date:
				if (Class86.delegate58_0 == null)
				{
					Class86.delegate58_0 = new Class86.Delegate58(Class86.smethod_19);
				}
				this.method_94(list_3, bool_10, Class86.delegate58_0);
				return;
			case TreeGroupMode.Difficulty:
			{
				string arg_1A5_2 = "Not yet calculated";
				List<Class296> arg_19F_0 = Class466.list_3;
				if (Class86.predicate_7 == null)
				{
					Class86.predicate_7 = new Predicate<Class296>(Class86.smethod_14);
				}
				this.method_96(list_3, arg_1A5_2, arg_19F_0.FindAll(Class86.predicate_7), bool_10);
				for (double num = 1.0; num <= 10.0; num += 1.0)
				{
					Class86.Class898 class2 = new Class86.Class898();
					class2.double_0 = ((num == 1.0) ? -0.1 : (num - 0.5));
					class2.double_1 = Math.Min(10.0, num + 0.5);
					string string_ = num + " Star" + ((num != 1.0) ? "s" : "");
					this.method_96(list_3, string_, Class466.list_3.FindAll(new Predicate<Class296>(class2.method_0)), bool_10);
				}
				string arg_29E_2 = "Above 10 stars";
				List<Class296> arg_298_0 = Class466.list_3;
				if (Class86.predicate_8 == null)
				{
					Class86.predicate_8 = new Predicate<Class296>(Class86.smethod_15);
				}
				this.method_96(list_3, arg_29E_2, arg_298_0.FindAll(Class86.predicate_8), bool_10);
				return;
			}
			case TreeGroupMode.Length:
			{
				Predicate<Class296> predicate2 = null;
				Class86.Class899 class3 = new Class86.Class899();
				class3.int_0 = 1;
				while (class3.int_0 < 6)
				{
					string text2 = string.Concat(new object[]
					{
						"Under ",
						class3.int_0,
						" minute",
						(class3.int_0 > 1) ? "s" : ""
					});
					string arg_32C_2 = text2;
					List<Class296> arg_326_0 = Class466.list_3;
					if (predicate2 == null)
					{
						predicate2 = new Predicate<Class296>(class3.method_0);
					}
					this.method_96(list_3, arg_32C_2, arg_326_0.FindAll(predicate2), bool_10);
					class3.int_0++;
				}
				string arg_37C_2 = "Under 10 minutes";
				List<Class296> arg_376_0 = Class466.list_3;
				if (Class86.predicate_9 == null)
				{
					Class86.predicate_9 = new Predicate<Class296>(Class86.smethod_16);
				}
				this.method_96(list_3, arg_37C_2, arg_376_0.FindAll(Class86.predicate_9), bool_10);
				string arg_3B0_2 = "Over 10 minutes";
				List<Class296> arg_3AA_0 = Class466.list_3;
				if (Class86.predicate_10 == null)
				{
					Class86.predicate_10 = new Predicate<Class296>(Class86.smethod_17);
				}
				this.method_96(list_3, arg_3B0_2, arg_3AA_0.FindAll(Class86.predicate_10), bool_10);
				return;
			}
			case TreeGroupMode.Rank:
			{
				string arg_3E5_2 = "Silver SS";
				List<Class296> arg_3DF_0 = Class466.list_3;
				if (Class86.predicate_2 == null)
				{
					Class86.predicate_2 = new Predicate<Class296>(Class86.smethod_7);
				}
				this.method_96(list_3, arg_3E5_2, arg_3DF_0.FindAll(Class86.predicate_2), bool_10);
				string arg_419_2 = "Silver S";
				List<Class296> arg_413_0 = Class466.list_3;
				if (Class86.predicate_3 == null)
				{
					Class86.predicate_3 = new Predicate<Class296>(Class86.smethod_8);
				}
				this.method_96(list_3, arg_419_2, arg_413_0.FindAll(Class86.predicate_3), bool_10);
				string arg_44D_2 = "SS";
				List<Class296> arg_447_0 = Class466.list_3;
				if (Class86.predicate_4 == null)
				{
					Class86.predicate_4 = new Predicate<Class296>(Class86.smethod_9);
				}
				this.method_96(list_3, arg_44D_2, arg_447_0.FindAll(Class86.predicate_4), bool_10);
				for (int i = 3; i < 8; i++)
				{
					Class86.Class897 class4 = new Class86.Class897();
					class4.rankings_0 = (Rankings)i;
					this.method_96(list_3, class4.rankings_0.ToString(), Class466.list_3.FindAll(new Predicate<Class296>(class4.method_0)), bool_10);
				}
				string arg_4C8_2 = "No Rank Achieved";
				List<Class296> arg_4C2_0 = Class466.list_3;
				if (Class86.predicate_5 == null)
				{
					Class86.predicate_5 = new Predicate<Class296>(Class86.smethod_10);
				}
				this.method_96(list_3, arg_4C8_2, arg_4C2_0.FindAll(Class86.predicate_5), bool_10);
				return;
			}
			case TreeGroupMode.My_Maps:
			{
				List<Class296> arg_4F2_0 = Class466.list_3;
				if (Class86.predicate_6 == null)
				{
					Class86.predicate_6 = new Predicate<Class296>(Class86.smethod_13);
				}
				this.method_95(list_3, arg_4F2_0.FindAll(Class86.predicate_6), bool_10);
				return;
			}
			case (TreeGroupMode)9:
			case (TreeGroupMode)10:
			case (TreeGroupMode)11:
				break;
			case TreeGroupMode.Search:
				this.method_95(list_3, Class466.list_3, bool_10);
				return;
			case TreeGroupMode.Title:
				if (Class86.delegate57_1 == null)
				{
					Class86.delegate57_1 = new Class86.Delegate57(Class86.smethod_11);
				}
				this.method_93(list_3, bool_10, Class86.delegate57_1);
				return;
			case TreeGroupMode.Last_Played:
				if (Class86.delegate58_1 == null)
				{
					Class86.delegate58_1 = new Class86.Delegate58(Class86.smethod_20);
				}
				this.method_94(list_3, bool_10, Class86.delegate58_1);
				return;
			case TreeGroupMode.Online_Favourites:
			{
				List<Class296> arg_57C_0 = Class466.list_3;
				if (Class86.predicate_1 == null)
				{
					Class86.predicate_1 = new Predicate<Class296>(Class86.smethod_5);
				}
				this.method_95(list_3, arg_57C_0.FindAll(Class86.predicate_1), bool_10);
				return;
			}
			case TreeGroupMode.Mania_Keys:
			{
				List<Class296> arg_5AA_0 = Class466.list_3;
				if (Class86.predicate_16 == null)
				{
					Class86.predicate_16 = new Predicate<Class296>(Class86.smethod_25);
				}
				List<Class296> list = arg_5AA_0.FindAll(Class86.predicate_16);
				Class86.Class901 class5 = new Class86.Class901();
				class5.int_0 = 1;
				while (class5.int_0 <= 18)
				{
					this.method_96(list_3, string.Format("{0} Keys", class5.int_0), list.FindAll(new Predicate<Class296>(class5.method_0)), bool_10);
					class5.int_0++;
				}
				return;
			}
			case TreeGroupMode.Mode:
			{
				string arg_63D_2 = Class213.smethod_0(PlayModes.Osu);
				List<Class296> arg_637_0 = Class466.list_3;
				if (Class86.predicate_17 == null)
				{
					Class86.predicate_17 = new Predicate<Class296>(Class86.smethod_26);
				}
				this.method_96(list_3, arg_63D_2, arg_637_0.FindAll(Class86.predicate_17), bool_10);
				string arg_672_2 = Class213.smethod_0(PlayModes.Taiko);
				List<Class296> arg_66C_0 = Class466.list_3;
				if (Class86.predicate_18 == null)
				{
					Class86.predicate_18 = new Predicate<Class296>(Class86.smethod_27);
				}
				this.method_96(list_3, arg_672_2, arg_66C_0.FindAll(Class86.predicate_18), bool_10);
				string arg_6A7_2 = Class213.smethod_0(PlayModes.CatchTheBeat);
				List<Class296> arg_6A1_0 = Class466.list_3;
				if (Class86.predicate_19 == null)
				{
					Class86.predicate_19 = new Predicate<Class296>(Class86.smethod_28);
				}
				this.method_96(list_3, arg_6A7_2, arg_6A1_0.FindAll(Class86.predicate_19), bool_10);
				string arg_6DC_2 = Class213.smethod_0(PlayModes.OsuMania);
				List<Class296> arg_6D6_0 = Class466.list_3;
				if (Class86.predicate_20 == null)
				{
					Class86.predicate_20 = new Predicate<Class296>(Class86.smethod_29);
				}
				this.method_96(list_3, arg_6DC_2, arg_6D6_0.FindAll(Class86.predicate_20), bool_10);
				return;
			}
			case TreeGroupMode.Collection:
			{
				List<Class296> list = new List<Class296>();
				foreach (KeyValuePair<string, List<string>> current in Class476.smethod_0())
				{
					list.Clear();
					foreach (string current2 in current.Value)
					{
						Class296 class6 = Class466.smethod_25(current2);
						if (class6 != null)
						{
							list.Add(class6);
						}
					}
					if (list.Count > 0)
					{
						this.method_96(list_3, current.Key, list, bool_10);
					}
				}
				break;
			}
			case TreeGroupMode.RankedStatus:
			{
				string arg_7B0_2 = "Ranked";
				List<Class296> arg_7AA_0 = Class466.list_3;
				if (Class86.predicate_12 == null)
				{
					Class86.predicate_12 = new Predicate<Class296>(Class86.smethod_21);
				}
				this.method_96(list_3, arg_7B0_2, arg_7AA_0.FindAll(Class86.predicate_12), bool_10);
				string arg_7E4_2 = "Pending";
				List<Class296> arg_7DE_0 = Class466.list_3;
				if (Class86.predicate_13 == null)
				{
					Class86.predicate_13 = new Predicate<Class296>(Class86.smethod_22);
				}
				this.method_96(list_3, arg_7E4_2, arg_7DE_0.FindAll(Class86.predicate_13), bool_10);
				string arg_818_2 = "Not Submitted";
				List<Class296> arg_812_0 = Class466.list_3;
				if (Class86.predicate_14 == null)
				{
					Class86.predicate_14 = new Predicate<Class296>(Class86.smethod_23);
				}
				this.method_96(list_3, arg_818_2, arg_812_0.FindAll(Class86.predicate_14), bool_10);
				string arg_84C_2 = "Unknown";
				List<Class296> arg_846_0 = Class466.list_3;
				if (Class86.predicate_15 == null)
				{
					Class86.predicate_15 = new Predicate<Class296>(Class86.smethod_24);
				}
				this.method_96(list_3, arg_84C_2, arg_846_0.FindAll(Class86.predicate_15), bool_10);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060034E2 RID: 13538
		// RVA: 0x0016B870 File Offset: 0x00169A70
		private void method_93(List<Class695> list_3, bool bool_10, Class86.Delegate57 delegate57_3)
		{
			List<Class296> list = new List<Class296>();
			List<List<Class296>> list2 = new List<List<Class296>>();
			for (char c = 'A'; c <= 'Z'; c += '\u0001')
			{
				list2.Add(new List<Class296>());
			}
			List<Class296> list3 = new List<Class296>();
			foreach (Class296 current in Class466.list_3)
			{
				string text = delegate57_3(current);
				if (text.Length > 0)
				{
					char c2 = text[0];
					if (char.IsNumber(c2))
					{
						list.Add(current);
						continue;
					}
					char c3 = char.ToUpper(c2);
					if (c3 >= 'A' && c3 <= 'Z')
					{
						list2[(int)(c3 - 'A')].Add(current);
						continue;
					}
				}
				list3.Add(current);
			}
			this.method_96(list_3, "0-9", list, bool_10);
			for (char c4 = 'A'; c4 <= 'Z'; c4 += '\u0001')
			{
				this.method_96(list_3, c4.ToString(), list2[(int)(c4 - 'A')], bool_10);
			}
			this.method_96(list_3, "Other", list3, bool_10);
		}

		// Token: 0x060034E3 RID: 13539
		// RVA: 0x0016B998 File Offset: 0x00169B98
		private void method_94(List<Class695> list_3, bool bool_10, Class86.Delegate58 delegate58_2)
		{
			DateTime now = DateTime.Now;
			List<Class296> list = new List<Class296>();
			List<Class296> list2 = new List<Class296>();
			List<Class296> list3 = new List<Class296>();
			List<List<Class296>> list4 = new List<List<Class296>>();
			int i;
			for (i = 1; i <= 5; i++)
			{
				list4.Add(new List<Class296>());
			}
			List<Class296> list5 = new List<Class296>();
			List<Class296> list6 = new List<Class296>();
			using (List<Class296>.Enumerator enumerator = Class466.list_3.GetEnumerator())
			{
				IL_175:
				while (enumerator.MoveNext())
				{
					Class296 current = enumerator.Current;
					DateTime dateTime = delegate58_2(current);
					if (dateTime == DateTime.MinValue)
					{
						list6.Add(current);
					}
					else
					{
						if (!(now - dateTime >= new TimeSpan(30 * (i - 1), 0, 0, 0)))
						{
							int j = i - 1;
							while (j >= 2)
							{
								if (!(now - dateTime >= new TimeSpan(30 * (j - 1), 0, 0, 0)))
								{
									j--;
								}
								else
								{
									list4[j - 1].Add(current);
									IL_FB:
									if (j >= 2)
									{
										goto IL_175;
									}
									if (now - dateTime >= new TimeSpan(7, 0, 0, 0))
									{
										list4[0].Add(current);
										goto IL_175;
									}
									if (now - dateTime >= new TimeSpan(2, 0, 0, 0))
									{
										list3.Add(current);
										goto IL_175;
									}
									if (now - dateTime >= new TimeSpan(24, 0, 0))
									{
										list2.Add(current);
										goto IL_175;
									}
									list.Add(current);
									goto IL_175;
								}
							}
							goto IL_FB;
						}
						list5.Add(current);
					}
				}
			}
			this.method_96(list_3, "Today", list, bool_10);
			this.method_96(list_3, "Yesterday", list2, bool_10);
			this.method_96(list_3, "Last Week", list3, bool_10);
			for (i = 1; i <= 5; i++)
			{
				string string_ = string.Concat(new object[]
				{
					i,
					" Month",
					(i > 1) ? "s" : "",
					" Ago"
				});
				this.method_96(list_3, string_, list4[i - 1], bool_10);
			}
			this.method_96(list_3, "Over " + (i - 1) + " Months Ago", list5, bool_10);
			this.method_96(list_3, "Never", list6, bool_10);
		}

		// Token: 0x060034E4 RID: 13540
		// RVA: 0x0016BC18 File Offset: 0x00169E18
		private void method_95(List<Class695> list_3, List<Class296> list_4, bool bool_10)
		{
			foreach (Class296 current in list_4)
			{
				if (current.bool_4 || bool_10)
				{
					list_3.Add(this.method_35(current, null, null));
				}
			}
		}

		// Token: 0x060034E5 RID: 13541
		// RVA: 0x0016BC84 File Offset: 0x00169E84
		private void method_96(List<Class695> list_3, string string_0, List<Class296> list_4, bool bool_10)
		{
			Class696 class = this.method_36(string_0);
			foreach (Class296 current in list_4)
			{
				if (current.bool_4 || bool_10)
				{
					class.list_2.Add(this.method_35(current, class, null));
				}
			}
			if (class.list_2.Count > 0)
			{
				list_3.Add(class);
				list_3.AddRange(class.list_2);
			}
		}

		// Token: 0x060034E6 RID: 13542
		// RVA: 0x0016BD20 File Offset: 0x00169F20
		internal void method_97()
		{
			this.float_0 = 0.6f;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class695 class = this.list_0[i];
				class.method_7(this.float_0);
				this.float_0 += 3E-05f;
			}
			this.method_54();
			this.method_64();
		}

		// Token: 0x060034E8 RID: 13544
		// RVA: 0x00026BAF File Offset: 0x00024DAF
		[CompilerGenerated]
		private void method_98()
		{
			this.method_54();
		}

		// Token: 0x060034CD RID: 13517
		// RVA: 0x0016A638 File Offset: 0x00168838
		internal void Remove(IEnumerable<Class695> ienumerable_0)
		{
			foreach (Class695 current in ienumerable_0)
			{
				this.method_73(current);
			}
			this.method_76();
		}

		// Token: 0x060034CC RID: 13516
		// RVA: 0x0016A4FC File Offset: 0x001686FC
		internal void Select(int int_15, bool bool_10)
		{
			this.int_7 = int_15;
			bool flag = false;
			if (int_15 >= 0)
			{
				Class695 class = this.list_0[int_15];
				if (!(class is Class696))
				{
					this.method_46();
					this.int_9 = int_15;
					if (class.class695_1 != null && !class.class695_1.method_16() && bool_10)
					{
						int_15 = this.list_0.IndexOf(class.class695_1);
					}
					if (this.delegate56_0 != null)
					{
						this.delegate56_0(this, this.method_6());
					}
				}
				class = this.list_0[int_15];
				if (class is Class696)
				{
					if (this.int_8 != int_15 && this.method_4() != null)
					{
						this.method_4().method_17(false);
					}
					this.int_8 = int_15;
					this.method_4().method_17(!this.method_4().method_16());
					flag = this.method_4().method_16();
					if (this.delegate56_1 != null)
					{
						this.delegate56_1(this, this.method_4());
					}
				}
			}
			else
			{
				this.int_9 = int_15;
				if (this.delegate56_0 != null)
				{
					this.delegate56_0(this, null);
				}
			}
			this.method_54();
			if (flag)
			{
				this.method_77();
			}
			this.method_49(0.99);
		}

		// Token: 0x060034CB RID: 13515
		// RVA: 0x0016A490 File Offset: 0x00168690
		internal void Select(Class296 class296_0, bool bool_10, string string_0, bool bool_11)
		{
			Class86.Class892 class = new Class86.Class892();
			class.class296_0 = class296_0;
			class.string_0 = string_0;
			int num = this.list_0.FindIndex(new Predicate<Class695>(class.method_0));
			if (class.string_0 != null && num == -1)
			{
				this.Select(class.class296_0, bool_10, null, bool_11);
				return;
			}
			if (bool_11)
			{
				this.method_72(num, bool_10);
				return;
			}
			this.Select(num, bool_10);
		}

		// Token: 0x06003489 RID: 13449
		// RVA: 0x0002698A File Offset: 0x00024B8A
		internal static float smethod_0()
		{
			return (float)Class115.int_22 / Class115.float_4 - 340f;
		}

		// Token: 0x060034BA RID: 13498
		// RVA: 0x00026A57 File Offset: 0x00024C57
		private static float smethod_1(float float_5)
		{
			return Math.Min(200f, Math.Abs(float_5 / 480f - 0.5f) * 75f);
		}

		// Token: 0x060034EF RID: 13551
		// RVA: 0x00026C07 File Offset: 0x00024E07
		[CompilerGenerated]
		private static bool smethod_10(Class296 class296_0)
		{
			return class296_0.method_41() >= Rankings.F;
		}

		// Token: 0x060034F0 RID: 13552
		// RVA: 0x00026C15 File Offset: 0x00024E15
		[CompilerGenerated]
		private static string smethod_11(Class296 class296_0)
		{
			return class296_0.Title;
		}

		// Token: 0x060034F1 RID: 13553
		// RVA: 0x00026C1D File Offset: 0x00024E1D
		[CompilerGenerated]
		private static string smethod_12(Class296 class296_0)
		{
			return class296_0.string_5;
		}

		// Token: 0x060034F2 RID: 13554
		// RVA: 0x00026C25 File Offset: 0x00024E25
		[CompilerGenerated]
		private static bool smethod_13(Class296 class296_0)
		{
			return class296_0.string_5.ToLower() == Class341.class605_20.Value.ToLower();
		}

		// Token: 0x060034F3 RID: 13555
		// RVA: 0x00026C46 File Offset: 0x00024E46
		[CompilerGenerated]
		private static bool smethod_14(Class296 class296_0)
		{
			return class296_0.method_26() <= -0.1;
		}

		// Token: 0x060034F4 RID: 13556
		// RVA: 0x00026C5C File Offset: 0x00024E5C
		[CompilerGenerated]
		private static bool smethod_15(Class296 class296_0)
		{
			return class296_0.method_26() > 10.0;
		}

		// Token: 0x060034F5 RID: 13557
		// RVA: 0x00026C6F File Offset: 0x00024E6F
		[CompilerGenerated]
		private static bool smethod_16(Class296 class296_0)
		{
			return class296_0.int_16 < 600000 && class296_0.int_16 >= 300000;
		}

		// Token: 0x060034F6 RID: 13558
		// RVA: 0x00026C90 File Offset: 0x00024E90
		[CompilerGenerated]
		private static bool smethod_17(Class296 class296_0)
		{
			return class296_0.int_16 >= 600000;
		}

		// Token: 0x060034F7 RID: 13559
		// RVA: 0x00026CA2 File Offset: 0x00024EA2
		[CompilerGenerated]
		private static bool smethod_18(Class296 class296_0)
		{
			return class296_0.method_32() > 300.0;
		}

		// Token: 0x060034F8 RID: 13560
		// RVA: 0x00026CB5 File Offset: 0x00024EB5
		[CompilerGenerated]
		private static DateTime smethod_19(Class296 class296_0)
		{
			return class296_0.dateTime_1;
		}

		// Token: 0x060034BF RID: 13503
		// RVA: 0x00026AC4 File Offset: 0x00024CC4
		private static bool smethod_2(float float_5)
		{
			return float_5 < -20f;
		}

		// Token: 0x060034F9 RID: 13561
		// RVA: 0x00026CBD File Offset: 0x00024EBD
		[CompilerGenerated]
		private static DateTime smethod_20(Class296 class296_0)
		{
			return class296_0.dateTime_0;
		}

		// Token: 0x060034FA RID: 13562
		// RVA: 0x00026CC5 File Offset: 0x00024EC5
		[CompilerGenerated]
		private static bool smethod_21(Class296 class296_0)
		{
			return class296_0.submissionStatus_0 == SubmissionStatus.Ranked || class296_0.submissionStatus_0 == SubmissionStatus.Approved;
		}

		// Token: 0x060034FB RID: 13563
		// RVA: 0x00026CDB File Offset: 0x00024EDB
		[CompilerGenerated]
		private static bool smethod_22(Class296 class296_0)
		{
			return class296_0.submissionStatus_0 == SubmissionStatus.Pending;
		}

		// Token: 0x060034FC RID: 13564
		// RVA: 0x00026CE6 File Offset: 0x00024EE6
		[CompilerGenerated]
		private static bool smethod_23(Class296 class296_0)
		{
			return class296_0.submissionStatus_0 == SubmissionStatus.NotSubmitted;
		}

		// Token: 0x060034FD RID: 13565
		// RVA: 0x00026CF1 File Offset: 0x00024EF1
		[CompilerGenerated]
		private static bool smethod_24(Class296 class296_0)
		{
			return class296_0.submissionStatus_0 == SubmissionStatus.Unknown;
		}

		// Token: 0x060034FE RID: 13566
		// RVA: 0x00026CFC File Offset: 0x00024EFC
		[CompilerGenerated]
		private static bool smethod_25(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.Osu || class296_0.method_5() == PlayModes.OsuMania;
		}

		// Token: 0x060034FF RID: 13567
		// RVA: 0x000162AB File Offset: 0x000144AB
		[CompilerGenerated]
		private static bool smethod_26(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.Osu;
		}

		// Token: 0x06003500 RID: 13568
		// RVA: 0x00026D11 File Offset: 0x00024F11
		[CompilerGenerated]
		private static bool smethod_27(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.Taiko;
		}

		// Token: 0x06003501 RID: 13569
		// RVA: 0x00026D1C File Offset: 0x00024F1C
		[CompilerGenerated]
		private static bool smethod_28(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.CatchTheBeat;
		}

		// Token: 0x06003502 RID: 13570
		// RVA: 0x00026D27 File Offset: 0x00024F27
		[CompilerGenerated]
		private static bool smethod_29(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.OsuMania;
		}

		// Token: 0x060034C0 RID: 13504
		// RVA: 0x00026ACE File Offset: 0x00024CCE
		private static bool smethod_3(float float_5)
		{
			return float_5 > 640f;
		}

		// Token: 0x060034E9 RID: 13545
		// RVA: 0x00026BB7 File Offset: 0x00024DB7
		[CompilerGenerated]
		private static bool smethod_4(Class695 class695_0)
		{
			return class695_0.class296_0 != null && !class695_0.Hidden && class695_0.class296_0.bool_4;
		}

		// Token: 0x060034EA RID: 13546
		// RVA: 0x00026BD6 File Offset: 0x00024DD6
		[CompilerGenerated]
		private static bool smethod_5(Class296 class296_0)
		{
			return class296_0.bool_19;
		}

		// Token: 0x060034EB RID: 13547
		// RVA: 0x00026BDE File Offset: 0x00024DDE
		[CompilerGenerated]
		private static string smethod_6(Class296 class296_0)
		{
			return class296_0.Artist;
		}

		// Token: 0x060034EC RID: 13548
		// RVA: 0x00026BE6 File Offset: 0x00024DE6
		[CompilerGenerated]
		private static bool smethod_7(Class296 class296_0)
		{
			return class296_0.method_41() == Rankings.XH;
		}

		// Token: 0x060034ED RID: 13549
		// RVA: 0x00026BF1 File Offset: 0x00024DF1
		[CompilerGenerated]
		private static bool smethod_8(Class296 class296_0)
		{
			return class296_0.method_41() == Rankings.SH;
		}

		// Token: 0x060034EE RID: 13550
		// RVA: 0x00026BFC File Offset: 0x00024DFC
		[CompilerGenerated]
		private static bool smethod_9(Class296 class296_0)
		{
			return class296_0.method_41() == Rankings.X;
		}
	}
}
