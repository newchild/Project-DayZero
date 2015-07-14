using Amib.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns16;
using ns17;
using ns18;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns30;
using ns40;
using ns6;
using ns64;
using ns69;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using osu;
using osu.GameModes.Select;
using osu.GameplayElements.Beatmaps;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ns19
{
	// Token: 0x020003EB RID: 1003
	internal sealed class Class68 : Class61
	{
		// Token: 0x020003ED RID: 1005
		[CompilerGenerated]
		private sealed class Class449
		{
			// Token: 0x040019A4 RID: 6564
			public Class531 class531_0;

			// Token: 0x040019A5 RID: 6565
			public Class533 class533_0;

			// Token: 0x040019A6 RID: 6566
			public Class68 class68_0;

			// Token: 0x040019A3 RID: 6563
			public PlayModes playModes_0;

			// Token: 0x06002072 RID: 8306
			// RVA: 0x000BCE5C File Offset: 0x000BB05C
			public void method_0(object sender, EventArgs e)
			{
				Class331.smethod_36(null, "click-short", 1f, false);
				if (this.class531_0.vmethod_6().enum112_0 == Enum112.flag_1)
				{
					this.class531_0.method_26(1.1f, 1000, Enum70.const_25);
				}
				this.class533_0.method_19(this.class533_0.vector2_0 + new Vector2(10f, 0f), 300, Enum70.const_1);
			}

			// Token: 0x06002073 RID: 8307
			// RVA: 0x000BCEE0 File Offset: 0x000BB0E0
			public void method_1(object sender, EventArgs e)
			{
				if (this.class531_0.vmethod_6().enum112_0 == Enum112.flag_1)
				{
					this.class531_0.method_26(1f, 1000, Enum70.const_25);
				}
				this.class533_0.method_19(this.class533_0.vector2_0, 300, Enum70.const_1);
			}

			// Token: 0x06002074 RID: 8308
			// RVA: 0x000BCF38 File Offset: 0x000BB138
			public void method_2(object sender, EventArgs e)
			{
				Class331.smethod_36(null, "click-short-confirm", 1f, false);
				this.class68_0.method_8(this.playModes_0);
			}
		}

		// Token: 0x020003EE RID: 1006
		[CompilerGenerated]
		private sealed class Class450
		{
			// Token: 0x040019A8 RID: 6568
			public Class296 class296_0;

			// Token: 0x040019A7 RID: 6567
			public Class68 class68_0;

			// Token: 0x06002076 RID: 8310
			// RVA: 0x0001A667 File Offset: 0x00018867
			public void method_0()
			{
				if (this.class296_0 == Class466.Current)
				{
					this.class68_0.method_52();
				}
				this.class68_0.class86_0.method_70(this.class296_0);
			}
		}

		// Token: 0x020003EF RID: 1007
		[CompilerGenerated]
		private sealed class Class451
		{
			// Token: 0x040019AA RID: 6570
			public Class68 class68_0;

			// Token: 0x040019A9 RID: 6569
			public string string_0;

			// Token: 0x06002078 RID: 8312
			// RVA: 0x0001A697 File Offset: 0x00018897
			public void method_0(object sender, EventArgs e)
			{
				Class476.Remove(this.string_0);
				this.class68_0.method_50(this.class68_0.treeGroupMode_0, false, null, false);
			}
		}

		// Token: 0x020003F0 RID: 1008
		[CompilerGenerated]
		private sealed class Class452
		{
			// Token: 0x040019AC RID: 6572
			public Class68 class68_0;

			// Token: 0x040019AB RID: 6571
			public Mods mods_0;

			// Token: 0x0600207A RID: 8314
			// RVA: 0x0001A6BD File Offset: 0x000188BD
			public void method_0(object sender, EventArgs e)
			{
				if (Class876.class623_0 != this.mods_0 && Class341.class605_5 == RankingType.SelectedMod)
				{
					this.class68_0.method_54(true);
				}
			}
		}

		// Token: 0x020003F1 RID: 1009
		[CompilerGenerated]
		private sealed class Class453
		{
			// Token: 0x040019AD RID: 6573
			public int int_0;

			// Token: 0x040019AE RID: 6574
			public string string_0;

			// Token: 0x0600207C RID: 8316
			// RVA: 0x0001A6EA File Offset: 0x000188EA
			public bool method_0(Class296 class296_0)
			{
				return class296_0.int_2 == this.int_0 || class296_0.int_3 == this.int_0 || class296_0.int_5 == this.int_0 || Class68.smethod_3(class296_0, this.string_0);
			}

			// Token: 0x0600207D RID: 8317
			// RVA: 0x0001A728 File Offset: 0x00018928
			public bool method_1(Class296 class296_0)
			{
				return Class68.smethod_3(class296_0, this.string_0);
			}
		}

		// Token: 0x020003F2 RID: 1010
		[CompilerGenerated]
		private sealed class Class454
		{
			// Token: 0x040019AF RID: 6575
			public Class68.Class453 class453_0;

			// Token: 0x040019B1 RID: 6577
			public double double_0;

			// Token: 0x040019B0 RID: 6576
			public string string_0;

			// Token: 0x0600207F RID: 8319
			// RVA: 0x0001A736 File Offset: 0x00018936
			public bool method_0(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round(class296_0.method_26(), 2), this.string_0, this.double_0);
			}

			// Token: 0x06002080 RID: 8320
			// RVA: 0x0001A755 File Offset: 0x00018955
			public bool method_1(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round((double)class296_0.DifficultyCircleSize, 1), this.string_0, this.double_0) && class296_0.method_5() != PlayModes.OsuMania && class296_0.method_5() != PlayModes.Taiko;
			}

			// Token: 0x06002089 RID: 8329
			// RVA: 0x0001A8C9 File Offset: 0x00018AC9
			public bool method_10(Class296 class296_0)
			{
				return Class68.smethod_2<DateTime>(class296_0.dateTime_0, this.string_0, DateTime.MinValue);
			}

			// Token: 0x0600208A RID: 8330
			// RVA: 0x0001A8E1 File Offset: 0x00018AE1
			public bool method_11(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)class296_0.method_5(), this.string_0, this.double_0);
			}

			// Token: 0x0600208B RID: 8331
			// RVA: 0x0001A8FB File Offset: 0x00018AFB
			public bool method_12(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)class296_0.submissionStatus_0, this.string_0, this.double_0) || Class68.smethod_2<double>((double)class296_0.submissionStatus_0, this.string_0, this.double_0 + 1.0);
			}

			// Token: 0x0600208C RID: 8332
			// RVA: 0x0001A93B File Offset: 0x00018B3B
			public bool method_13(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)class296_0.submissionStatus_0, this.string_0, this.double_0) && Class68.smethod_2<double>((double)class296_0.submissionStatus_0, this.string_0, this.double_0 + 1.0);
			}

			// Token: 0x0600208D RID: 8333
			// RVA: 0x0001A97B File Offset: 0x00018B7B
			public bool method_14(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)class296_0.submissionStatus_0, this.string_0, this.double_0);
			}

			// Token: 0x06002081 RID: 8321
			// RVA: 0x0001A78E File Offset: 0x0001898E
			public bool method_2(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round((double)class296_0.DifficultyHpDrainRate, 1), this.string_0, this.double_0);
			}

			// Token: 0x06002082 RID: 8322
			// RVA: 0x0001A7AE File Offset: 0x000189AE
			public bool method_3(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round((double)class296_0.DifficultyOverall, 1), this.string_0, this.double_0);
			}

			// Token: 0x06002083 RID: 8323
			// RVA: 0x0001A7CE File Offset: 0x000189CE
			public bool method_4(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round((double)class296_0.DifficultyApproachRate, 1), this.string_0, this.double_0) && class296_0.method_5() != PlayModes.OsuMania && class296_0.method_5() != PlayModes.Taiko;
			}

			// Token: 0x06002084 RID: 8324
			// RVA: 0x0001A807 File Offset: 0x00018A07
			public bool method_5(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)Class421.smethod_2(class296_0), this.string_0, this.double_0) && class296_0.method_5() == PlayModes.OsuMania;
			}

			// Token: 0x06002085 RID: 8325
			// RVA: 0x0001A82E File Offset: 0x00018A2E
			public bool method_6(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)class296_0.int_18, this.string_0, this.double_0) && (class296_0.method_5() == PlayModes.OsuMania || class296_0.method_5() == PlayModes.Osu);
			}

			// Token: 0x06002086 RID: 8326
			// RVA: 0x0001A860 File Offset: 0x00018A60
			public bool method_7(Class296 class296_0)
			{
				return Class68.smethod_2<double>(Math.Round((double)class296_0.method_33().Z), this.string_0, this.double_0);
			}

			// Token: 0x06002087 RID: 8327
			// RVA: 0x0001A884 File Offset: 0x00018A84
			public bool method_8(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)(class296_0.int_16 / 1000), this.string_0, this.double_0);
			}

			// Token: 0x06002088 RID: 8328
			// RVA: 0x0001A8A4 File Offset: 0x00018AA4
			public bool method_9(Class296 class296_0)
			{
				return Class68.smethod_2<double>((double)Math.Max(class296_0.int_10, class296_0.int_9), this.string_0, this.double_0);
			}
		}

		// Token: 0x020003F3 RID: 1011
		[CompilerGenerated]
		private sealed class Class455
		{
			// Token: 0x040019B3 RID: 6579
			public Class68.Class453 class453_0;

			// Token: 0x040019B2 RID: 6578
			public Class68.Class454 class454_0;

			// Token: 0x040019B4 RID: 6580
			public DateTime dateTime_0;

			// Token: 0x0600208F RID: 8335
			// RVA: 0x0001A995 File Offset: 0x00018B95
			public bool method_0(Class296 class296_0)
			{
				return Class68.smethod_2<DateTime>(class296_0.dateTime_0, this.class454_0.string_0, this.dateTime_0);
			}
		}

		// Token: 0x020003F4 RID: 1012
		[CompilerGenerated]
		private sealed class Class456
		{
			// Token: 0x040019B7 RID: 6583
			public bool bool_0;

			// Token: 0x040019B9 RID: 6585
			public bool bool_1;

			// Token: 0x040019B5 RID: 6581
			public Class68 class68_0;

			// Token: 0x040019B8 RID: 6584
			public string string_0;

			// Token: 0x040019B6 RID: 6582
			public TreeGroupMode treeGroupMode_0;

			// Token: 0x06002091 RID: 8337
			// RVA: 0x0001A9B3 File Offset: 0x00018BB3
			public void method_0()
			{
				Class115.class47_0.Add(new VoidDelegate(this.method_2), false);
			}

			// Token: 0x06002092 RID: 8338
			// RVA: 0x000BCF70 File Offset: 0x000BB170
			public void method_1()
			{
				if (Class115.class61_0 == this.class68_0 && !this.class68_0.bool_3)
				{
					this.class68_0.class86_0.bool_3 = true;
					this.class68_0.class86_0.bool_6 = true;
					this.class68_0.class86_0.Select(Class466.Current, this.bool_0, this.string_0, this.bool_1);
					this.class68_0.method_46(true);
					this.class68_0.class86_0.method_49(0.0);
					return;
				}
			}

			// Token: 0x06002093 RID: 8339
			// RVA: 0x0001A9CC File Offset: 0x00018BCC
			public void method_2()
			{
				if (Class115.class61_0 == this.class68_0)
				{
					this.class68_0.method_50(this.treeGroupMode_0, this.bool_0, this.string_0, this.bool_1);
				}
			}
		}

		// Token: 0x020003F5 RID: 1013
		[CompilerGenerated]
		private sealed class Class457
		{
			// Token: 0x040019BA RID: 6586
			public Class533 class533_0;

			// Token: 0x040019BB RID: 6587
			public Class537 class537_0;

			// Token: 0x06002095 RID: 8341
			// RVA: 0x000BD008 File Offset: 0x000BB208
			public void method_0(object sender, EventArgs e)
			{
				this.class533_0.method_14(100, Enum70.const_0);
				if (this.class537_0 != null)
				{
					this.class537_0.method_39(Color.get_DarkGray(), 100, false, Enum70.const_0);
				}
				Class331.smethod_36(null, "click-short", 1f, false);
			}

			// Token: 0x06002096 RID: 8342
			// RVA: 0x0001A9FE File Offset: 0x00018BFE
			public void method_1(object sender, EventArgs e)
			{
				this.class533_0.method_16(100, Enum70.const_0);
				if (this.class537_0 != null)
				{
					this.class537_0.method_39(Color.get_White(), 100, false, Enum70.const_0);
				}
			}
		}

		// Token: 0x020003F6 RID: 1014
		[CompilerGenerated]
		private sealed class Class458
		{
			// Token: 0x040019BC RID: 6588
			public Class68 class68_0;

			// Token: 0x040019BE RID: 6590
			public EventArgs eventArgs_0;

			// Token: 0x040019BD RID: 6589
			public object object_0;

			// Token: 0x06002098 RID: 8344
			// RVA: 0x0001AA2B File Offset: 0x00018C2B
			public void method_0(object sender, EventArgs e)
			{
				this.class68_0.method_61(this.object_0, this.eventArgs_0);
			}
		}

		// Token: 0x020003F7 RID: 1015
		[CompilerGenerated]
		private sealed class Class459
		{
			// Token: 0x040019BF RID: 6591
			public Class296 class296_0;

			// Token: 0x040019C0 RID: 6592
			public Class68 class68_0;

			// Token: 0x040019C1 RID: 6593
			public EventArgs eventArgs_0;

			// Token: 0x0600209A RID: 8346
			// RVA: 0x000BD05C File Offset: 0x000BB25C
			public void method_0(string string_0, Exception exception_0)
			{
				VoidDelegate voidDelegate = null;
				if (exception_0 == null)
				{
					Class47 arg_1C_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_1);
					}
					arg_1C_0.Add(voidDelegate, false);
				}
				else
				{
					try
					{
						File.Delete(this.class68_0.string_2);
					}
					catch
					{
					}
				}
				this.class68_0.method_62(this.eventArgs_0 == null);
			}

			// Token: 0x0600209B RID: 8347
			// RVA: 0x0001AA44 File Offset: 0x00018C44
			public void method_1()
			{
				this.class296_0.method_57();
			}
		}

		// Token: 0x020003F8 RID: 1016
		[CompilerGenerated]
		private sealed class Class460
		{
			// Token: 0x040019C3 RID: 6595
			public bool bool_0;

			// Token: 0x040019C2 RID: 6594
			public Class68 class68_0;

			// Token: 0x0600209D RID: 8349
			// RVA: 0x000BD0C8 File Offset: 0x000BB2C8
			public void method_0()
			{
				if (this.bool_0)
				{
					this.class68_0.method_54(true);
				}
				else
				{
					if (this.class68_0.class531_15 != null)
					{
						this.class68_0.class531_15.bool_1 = true;
						this.class68_0.class531_15.method_14(100, Enum70.const_0);
						if (this.class68_0.class531_15.object_0 != null)
						{
							((Class531)this.class68_0.class531_15.object_0).class26_0[0] = ((Class531)this.class68_0.class531_15.object_0).class26_0[0].method_1();
						}
					}
					Class723.smethod_4(Class41.GetString(OsuString.SongSelection_UpdateNotAvailable));
				}
				Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
			}
		}

		// Token: 0x020003EC RID: 1004
		// Token: 0x0600206E RID: 8302
		private delegate bool Delegate32(Class296 class296_0);

		// Token: 0x04001995 RID: 6549
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04001996 RID: 6550
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04001997 RID: 6551
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x0400199C RID: 6556
		[CompilerGenerated]
		private static Action<Class530> action_3;

		// Token: 0x0400199D RID: 6557
		[CompilerGenerated]
		private static Action<Class530> action_4;

		// Token: 0x0400199E RID: 6558
		[CompilerGenerated]
		private static Action<Class530> action_5;

		// Token: 0x040019A1 RID: 6561
		[CompilerGenerated]
		private static Action<Class530> action_6;

		// Token: 0x040019A2 RID: 6562
		[CompilerGenerated]
		private static Action<Class531> action_7;

		// Token: 0x0400197E RID: 6526
		private bool bool_10;

		// Token: 0x04001986 RID: 6534
		public static bool bool_11 = true;

		// Token: 0x0400198B RID: 6539
		private bool bool_12;

		// Token: 0x04001946 RID: 6470
		private bool bool_2;

		// Token: 0x04001947 RID: 6471
		private bool bool_3;

		// Token: 0x04001955 RID: 6485
		private readonly bool bool_4;

		// Token: 0x04001956 RID: 6486
		private readonly bool bool_5;

		// Token: 0x04001974 RID: 6516
		private bool bool_6;

		// Token: 0x04001978 RID: 6520
		private bool bool_7;

		// Token: 0x04001979 RID: 6521
		private bool bool_8;

		// Token: 0x0400197C RID: 6524
		private bool bool_9;

		// Token: 0x0400196A RID: 6506
		private readonly Class110 class110_0;

		// Token: 0x04001988 RID: 6536
		private Class26<Class512> class26_0;

		// Token: 0x04001945 RID: 6469
		private Class296 class296_0;

		// Token: 0x04001952 RID: 6482
		private readonly Class296 class296_1;

		// Token: 0x04001948 RID: 6472
		private readonly Class531 class531_0;

		// Token: 0x04001949 RID: 6473
		private readonly Class531 class531_1;

		// Token: 0x0400195F RID: 6495
		private readonly Class531 class531_10;

		// Token: 0x04001960 RID: 6496
		private readonly Class531 class531_11;

		// Token: 0x0400196C RID: 6508
		private readonly Class531 class531_12;

		// Token: 0x04001971 RID: 6513
		private readonly Class531 class531_13;

		// Token: 0x04001975 RID: 6517
		internal Class531 class531_14;

		// Token: 0x04001976 RID: 6518
		private Class531 class531_15;

		// Token: 0x04001983 RID: 6531
		private Class531 class531_16;

		// Token: 0x04001984 RID: 6532
		private Class531 class531_17;

		// Token: 0x0400198A RID: 6538
		private Class531 class531_18;

		// Token: 0x0400194A RID: 6474
		private readonly Class531 class531_2;

		// Token: 0x04001957 RID: 6487
		private readonly Class531 class531_3;

		// Token: 0x04001959 RID: 6489
		private Class531 class531_4;

		// Token: 0x0400195A RID: 6490
		private Class531 class531_5;

		// Token: 0x0400195B RID: 6491
		private readonly Class531 class531_6;

		// Token: 0x0400195C RID: 6492
		private readonly Class531 class531_7;

		// Token: 0x0400195D RID: 6493
		private readonly Class531 class531_8;

		// Token: 0x0400195E RID: 6494
		private readonly Class531 class531_9;

		// Token: 0x0400194B RID: 6475
		private readonly Class533 class533_0;

		// Token: 0x0400194C RID: 6476
		private readonly Class533 class533_1;

		// Token: 0x0400194D RID: 6477
		private readonly Class533 class533_2;

		// Token: 0x0400194E RID: 6478
		private readonly Class533 class533_3;

		// Token: 0x0400194F RID: 6479
		private readonly Class533 class533_4;

		// Token: 0x04001953 RID: 6483
		private readonly Class533 class533_5;

		// Token: 0x04001954 RID: 6484
		private readonly Class533 class533_6;

		// Token: 0x04001961 RID: 6497
		private readonly Class533 class533_7;

		// Token: 0x04001965 RID: 6501
		private readonly Class533 class533_8;

		// Token: 0x04001970 RID: 6512
		private readonly Class592 class592_0;

		// Token: 0x04001985 RID: 6533
		private Class597 class597_0;

		// Token: 0x04001987 RID: 6535
		internal static Class605<PlayModes> class605_0;

		// Token: 0x04001973 RID: 6515
		private Class695 class695_0;

		// Token: 0x0400196B RID: 6507
		private Class731 class731_0;

		// Token: 0x0400196D RID: 6509
		private readonly Class731 class731_1;

		// Token: 0x0400196E RID: 6510
		private readonly Class731 class731_2;

		// Token: 0x0400196F RID: 6511
		private readonly Class731 class731_3;

		// Token: 0x04001950 RID: 6480
		private readonly Class753 class753_0;

		// Token: 0x04001951 RID: 6481
		private readonly Class753 class753_1;

		// Token: 0x04001989 RID: 6537
		private Class753 class753_2;

		// Token: 0x04001962 RID: 6498
		private Class755 class755_0;

		// Token: 0x0400198C RID: 6540
		private Class86 class86_0;

		// Token: 0x04001966 RID: 6502
		private readonly Class911 class911_1;

		// Token: 0x04001967 RID: 6503
		private readonly Class911 class911_2;

		// Token: 0x04001968 RID: 6504
		private readonly Class911 class911_3;

		// Token: 0x04001969 RID: 6505
		private readonly Class911 class911_4;

		// Token: 0x04001943 RID: 6467
		private Enum113 enum113_0;

		// Token: 0x0400199A RID: 6554
		[CompilerGenerated]
		private static EventHandler eventHandler_10;

		// Token: 0x04001991 RID: 6545
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x04001992 RID: 6546
		[CompilerGenerated]
		private static EventHandler eventHandler_5;

		// Token: 0x04001993 RID: 6547
		[CompilerGenerated]
		private static EventHandler eventHandler_6;

		// Token: 0x04001994 RID: 6548
		[CompilerGenerated]
		private static EventHandler eventHandler_7;

		// Token: 0x04001998 RID: 6552
		[CompilerGenerated]
		private static EventHandler eventHandler_8;

		// Token: 0x04001999 RID: 6553
		[CompilerGenerated]
		private static EventHandler eventHandler_9;

		// Token: 0x04001972 RID: 6514
		private int int_2;

		// Token: 0x04001977 RID: 6519
		private int int_3;

		// Token: 0x0400197B RID: 6523
		private int int_4;

		// Token: 0x04001981 RID: 6529
		private int int_5;

		// Token: 0x0400198F RID: 6543
		private static KeyValuePair<double, string>[] keyValuePair_0 = new KeyValuePair<double, string>[]
		{
			new KeyValuePair<double, string>(0.0, "osu!"),
			new KeyValuePair<double, string>(1.0, "taiko"),
			new KeyValuePair<double, string>(2.0, "catchthebeat"),
			new KeyValuePair<double, string>(2.0, "ctb"),
			new KeyValuePair<double, string>(3.0, "osu!mania"),
			new KeyValuePair<double, string>(3.0, "osumania"),
			new KeyValuePair<double, string>(3.0, "mania"),
			new KeyValuePair<double, string>(3.0, "o!m")
		};

		// Token: 0x04001990 RID: 6544
		private static KeyValuePair<double, string>[] keyValuePair_1 = new KeyValuePair<double, string>[]
		{
			new KeyValuePair<double, string>(0.0, "unknown"),
			new KeyValuePair<double, string>(1.0, "notsubmitted"),
			new KeyValuePair<double, string>(2.0, "pending"),
			new KeyValuePair<double, string>(4.0, "ranked"),
			new KeyValuePair<double, string>(5.0, "approved")
		};

		// Token: 0x04001958 RID: 6488
		private readonly List<Class531> list_0;

		// Token: 0x04001982 RID: 6530
		private List<Class531> list_1;

		// Token: 0x0400199B RID: 6555
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x0400199F RID: 6559
		[CompilerGenerated]
		private static Predicate<Class512> predicate_1;

		// Token: 0x040019A0 RID: 6560
		[CompilerGenerated]
		private static Predicate<Class512> predicate_2;

		// Token: 0x0400198D RID: 6541
		private static Regex regex_0 = new Regex("^(\\w*)([<>=]=?|!=)(.*)$");

		// Token: 0x0400198E RID: 6542
		private static Regex regex_1 = new Regex("(?x)\r\n            ^\r\n            [+-]?\r\n            (?:\r\n                # start with digit\r\n                (?>\\d+) \\.?\r\n                |\r\n                # start with point\r\n                \\. \\d\r\n            )\r\n            \\d*\r\n            (?: e [+-]? \\d+ )?  # possible exponent\r\n            $\r\n        ");

		// Token: 0x04001980 RID: 6528
		private SmartThreadPool smartThreadPool_0;

		// Token: 0x04001963 RID: 6499
		private static string string_0;

		// Token: 0x04001964 RID: 6500
		private static string string_1;

		// Token: 0x0400197A RID: 6522
		private string string_2;

		// Token: 0x0400197D RID: 6525
		private string string_3;

		// Token: 0x04001944 RID: 6468
		private Thread thread_0;

		// Token: 0x0400197F RID: 6527
		private TreeGroupMode treeGroupMode_0;

		// Token: 0x0600200D RID: 8205
		// RVA: 0x000B64B4 File Offset: 0x000B46B4
		internal Class68(Class114 class114_1)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			this.enum113_0 = Enum113.const_2;
			this.list_0 = new List<Class531>();
			this.int_2 = -1;
			this.int_4 = -1;
			this.list_1 = new List<Class531>();
			this.bool_12 = true;
			base..ctor(class114_1);
			Class695.smethod_1();
			this.smartThreadPool_0 = new SmartThreadPool(new STPStartInfo
			{
				MaxWorkerThreads = 1,
				AreThreadsBackground = true,
				IdleTimeout = 1000,
				ThreadPriority = ThreadPriority.BelowNormal
			});
			this.class296_1 = Class466.Current;
			this.bool_5 = (Class115.osuModes_1 == OsuModes.SelectPlay);
			this.bool_4 = (Class115.osuModes_1 == OsuModes.SelectMulti);
			if (!this.bool_4 && this.bool_5)
			{
				Class62.Mode = Class68.class605_0;
			}
			Class908.smethod_1();
			Class476.smethod_3();
			if (Class466.Current != null)
			{
				Class466.Current.list_0.Clear();
			}
			Class62.class512_0 = null;
			lock (Class858.object_0)
			{
				Class802.smethod_1(false);
				Class802.bool_16 = false;
			}
			this.method_23();
			if ((Class466.Current == null || string.IsNullOrEmpty(Class466.Current.string_4) || !Class466.Current.bool_4) && (Class115.osuModes_1 == OsuModes.SelectPlay || Class115.osuModes_1 == OsuModes.SelectMulti || Class115.osuModes_1 == OsuModes.SelectEdit))
			{
				Class109.smethod_3(true, true);
			}
			Class570.smethod_4(new Class570.Delegate45(this.method_39));
			Class570.smethod_2(new Class570.Delegate44(this.method_38));
			Class569.smethod_0(new Class569.Delegate43(this.method_19));
			Class809.smethod_8(new VoidDelegate(this.method_21));
			Class876.smethod_0(new Class876.Delegate53(this.method_9));
			this.class86_0 = new Class86(class114_1);
			this.class86_0.method_16(new Class86.Delegate56(this.method_10));
			this.class86_0.method_18(new Class86.Delegate56(this.method_11));
			this.class86_0.method_20(new Class86.Delegate56(this.method_12));
			this.class86_0.method_22(new Class86.Delegate56(this.method_13));
			this.class86_0.method_24(new Class86.Delegate56(this.method_14));
			this.class86_0.method_26(new Class86.Delegate56(this.method_15));
			this.class86_0.method_28(new VoidDelegate(this.method_44));
			this.class86_0.method_30(new VoidDelegate(this.method_45));
			Class466.smethod_19(new Class466.Delegate33(this.method_32));
			if (Class62.class911_1 != null)
			{
				this.class911_3 = Class62.class911_1;
			}
			else
			{
				this.class911_3 = new Class911(true);
			}
			this.class110_0 = new Class110(new Rectangle(-5, 92, 290, 267), Vector2.get_Zero(), true, 0f, Enum98.const_2)
			{
				bool_2 = true,
				bool_8 = true
			};
			this.class911_2 = new Class911(true);
			this.class911_4 = new Class911(true);
			this.class911_1 = new Class911(true);
			this.class533_0 = new Class533(" ", 18f, new Vector2(21f, -3f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class533_0.vmethod_11();
			this.class911_1.Add(this.class533_0);
			this.class533_1 = new Class533(string.Empty, 12f, new Vector2(23f, 12f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_1.Add(this.class533_1);
			this.class533_2 = new Class533(string.Empty, 12f, new Vector2(1f, 24f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_1.Add(this.class533_2);
			this.class533_3 = new Class533(string.Empty, 12f, new Vector2(1f, 36f), Vector2.get_Zero(), 0.79f, true, Color.get_White(), false);
			this.class911_1.Add(this.class533_3);
			this.class533_4 = new Class533(string.Empty, 8f, new Vector2(1f, 48f), Vector2.get_Zero(), 1f, true, Color.get_White(), false);
			this.class911_1.Add(this.class533_4);
			this.class533_6 = new Class533(string.Empty, 20f, new Vector2(5f, -1f), 1f, true, new Color(255, 255, 255, 128))
			{
				enum115_0 = Enum115.const_7,
				origins_0 = Origins.TopRight,
				object_0 = 0.0
			};
			this.class911_1.Add(this.class533_6);
			this.class731_2 = Class885.Load("selection-ranked", Enum112.flag_1);
			this.class731_3 = Class885.Load("selection-question", Enum112.flag_1);
			this.class731_1 = Class885.Load("selection-approved", Enum112.flag_1);
			this.class531_12 = new Class531(this.class731_2, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(12f, 12f), 0.78f, true, Color.get_TransparentWhite(), null);
			this.class911_1.Add(this.class531_12);
			this.class531_13 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 1f, true, Color.get_TransparentWhite(), null);
			this.class531_13.bool_13 = false;
			this.class531_13.bool_7 = true;
			this.class531_13.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23);
			this.class911_1.Add(this.class531_13);
			this.class531_9 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(3f, 73f), 0.88f, true, new Color(0, 0, 0, 128), null);
			this.class531_9.float_2 = 1.6f;
			this.class531_9.vector2_2 = new Vector2(3f, 330f);
			this.class531_10 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(3f, 73f), 0.89f, true, new Color(255, 255, 255, 255), null);
			this.class531_10.float_2 = 1.6f;
			this.class531_10.vector2_2 = new Vector2(3f, 20f);
			this.class911_1.Add(this.class531_9);
			this.class911_1.Add(this.class531_10);
			if (!this.bool_5 && !this.bool_4)
			{
				Class876.class623_0 = Mods.None;
				Class531 class530_ = new Class531(Class885.Load("selection-drop", Enum112.flag_1), new Vector2(5f, 110f), 0.5f, true, Color.get_White());
				this.class911_1.Add(class530_);
			}
			else
			{
				bool flag;
				Enum115 enum115_ = (flag = (Class885.smethod_25() || Class885.Load("selection-mods", Enum112.flag_6).enum112_0 == Enum112.flag_1)) ? Enum115.const_11 : Enum115.const_5;
				Origins origins_ = flag ? Origins.BottomLeft : Origins.TopLeft;
				float num = (float)(flag ? 0 : 426);
				float num2 = (float)(Class115.bool_21 ? 140 : 120);
				if (Class68.bool_11)
				{
					this.class531_17 = new Class531(Class885.Load("selection-mode", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.95f, true, Color.get_White(), null);
					this.class911_1.Add(this.class531_17);
					this.class531_17 = new Class531(Class885.Load("selection-mode-over", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.96f, true, Color.get_White(), null);
					this.class531_17.float_3 = 0.01f;
					this.class531_17.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 100, Enum70.const_0);
					this.class531_17.bool_1 = true;
					Class531 arg_831_0 = this.class531_17;
					if (Class68.eventHandler_4 == null)
					{
						Class68.eventHandler_4 = new EventHandler(Class68.smethod_5);
					}
					arg_831_0.method_35(Class68.eventHandler_4);
					Class530 arg_850_0 = this.class531_17;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(this.method_64);
					}
					arg_850_0.method_2(eventHandler);
					this.class911_1.Add(this.class531_17);
					this.class597_0 = new Class597(this.class911_1);
					float num3 = 80f;
					Vector2 vector;
					vector..ctor(num2, 344f);
					for (int i = 0; i < 4; i++)
					{
						Class68.Class449 class = new Class68.Class449();
						class.class68_0 = this;
						class.playModes_0 = (PlayModes)i;
						Class731 class2;
						switch (class.playModes_0)
						{
						case PlayModes.Taiko:
							class2 = Class885.Load("mode-taiko-med", Enum112.flag_6);
							break;
						case PlayModes.CatchTheBeat:
							class2 = Class885.Load("mode-fruits-med", Enum112.flag_6);
							break;
						case PlayModes.OsuMania:
							class2 = Class885.Load("mode-mania-med", Enum112.flag_6);
							break;
						default:
							class2 = Class885.Load("mode-osu-med", Enum112.flag_6);
							break;
						}
						class.class531_0 = new Class531(class2, Enum115.const_5, Origins.Centre, Enum114.const_0, vector + new Vector2(num3 / 2f, num3 / 2f), 0.991f, true, Color.get_TransparentWhite(), null);
						this.class911_2.Add(class.class531_0);
						Class68.Class449 arg_9AA_0 = class;
						Class533 class3 = new Class533(Class213.smethod_0(class.playModes_0), 24f, vector + new Vector2(num3 + 10f, num3 / 2f), 0.992f, true, Color.get_TransparentWhite());
						class3.origins_0 = Origins.CentreLeft;
						class3.bool_16 = true;
						class3.method_58(true);
						arg_9AA_0.class533_0 = class3;
						this.class911_2.Add(class.class533_0);
						Class598 class4 = new Class598(this.class597_0, this.class911_2, new Vector2(num3 * 3.5f * 1.6f, num3 * 1.6f), vector, false);
						class4.list_0.Add(class.class531_0);
						class4.list_0.Add(class.class533_0);
						class4.class531_0.method_35(new EventHandler(class.method_0));
						class4.class531_0.method_37(new EventHandler(class.method_1));
						class4.method_2(new EventHandler(class.method_2));
						this.class597_0.list_0.Add(class4);
						vector.Y -= num3;
					}
					num2 += 57.6f;
				}
				if (!this.bool_4)
				{
					this.class531_0 = new Class531(Class885.Load("selection-mods", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.95f, true, Color.get_White(), null);
					this.class911_1.Add(this.class531_0);
					this.class531_0 = new Class531(Class885.Load("selection-mods-over", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.96f, true, Color.get_White(), null);
					this.class531_0.float_3 = 0.01f;
					this.class531_0.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 100, Enum70.const_0);
					Class531 arg_B62_0 = this.class531_0;
					if (Class68.eventHandler_5 == null)
					{
						Class68.eventHandler_5 = new EventHandler(Class68.smethod_6);
					}
					arg_B62_0.method_35(Class68.eventHandler_5);
					this.class531_0.bool_1 = true;
					this.class531_0.method_2(new EventHandler(this.method_34));
					this.class911_1.Add(this.class531_0);
					num2 += 48f;
				}
				if (this.bool_4 || this.bool_5)
				{
					this.class531_2 = new Class531(Class885.Load("selection-random", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.95f, true, Color.get_White(), null);
					this.class911_1.Add(this.class531_2);
					this.class531_2 = new Class531(Class885.Load("selection-random-over", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.96f, true, Color.get_White(), null);
					this.class531_2.float_3 = 0.01f;
					this.class531_2.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 100, Enum70.const_0);
					this.class531_2.method_35(delegate(object sender, EventArgs e)
					{
						Class331.smethod_36(null, "click-short", 1f, false);
					});
					this.class531_2.bool_1 = true;
					this.class531_2.method_2(new EventHandler(this.method_35));
					this.class911_1.Add(this.class531_2);
					num2 += 48f;
				}
				this.class531_1 = new Class531(Class885.Load("selection-options", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.95f, true, Color.get_White(), null);
				this.class911_1.Add(this.class531_1);
				this.class531_1 = new Class531(Class885.Load("selection-options-over", Enum112.flag_6), enum115_, origins_, Enum114.const_0, new Vector2(num2, num), 0.96f, true, Color.get_White(), null);
				this.class531_1.float_3 = 0.01f;
				this.class531_1.method_35(delegate(object sender, EventArgs e)
				{
					Class331.smethod_36(null, "click-short", 1f, false);
				});
				this.class531_1.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 100, Enum70.const_0);
				this.class531_1.bool_1 = true;
				this.class531_1.method_2(new EventHandler(this.method_33));
				this.class911_1.Add(this.class531_1);
				num2 += 48f;
				num2 += 48f;
				Class115.class861_0.method_10(new Vector2(num2, 429f), false, 0);
				this.class911_1.Add<Class531>(Class115.class861_0.list_0);
			}
			if (this.bool_5)
			{
				Color color_ = ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? Color.get_Black() : new Color(30, 30, 30);
				this.class753_2 = new Class753(this.class911_1, string.Empty, new Vector2(5f, 73.5f), 190f, 1f);
				this.class753_2.class533_0.method_55(new Color(31, 184, 255, 180));
				this.class753_2.class533_0.method_61(14f);
				this.class753_2.method_9(Class41.GetString(OsuString.SongSelection_Rank_Local), RankingType.Local);
				this.class753_2.method_10(Class41.GetString(OsuString.SongSelection_Rank_Country), RankingType.Country, color_);
				this.class753_2.method_9(Class41.GetString(OsuString.SongSelection_Rank_Top), RankingType.Top);
				this.class753_2.method_11(Class41.GetString(OsuString.SongSelection_Rank_Mod), RankingType.SelectedMod, 0, color_, true);
				this.class753_2.method_10(Class41.GetString(OsuString.SongSelection_Rank_Friends), RankingType.Friends, color_);
				this.class753_2.method_18(Class341.class605_5.Value, true);
				this.class753_2.method_0(delegate(object sender, EventArgs e)
				{
					Class341.class605_5.Value = (RankingType)this.class753_2.object_0;
					switch (Class341.class605_5.Value)
					{
					case RankingType.Top:
						if (!Class809.bool_4)
						{
							Class723.smethod_1(Class41.GetString(OsuString.SongSelection_NoNetworkConnection), 5000);
							this.class753_2.method_18(RankingType.Local, true);
							return;
						}
						break;
					case RankingType.SelectedMod:
					case RankingType.Friends:
					case RankingType.Country:
						if ((Class809.class623_0 & Enum30.flag_3) == Enum30.flag_0)
						{
							Class723.smethod_1(Class41.GetString(OsuString.SongSelection_NeedSupporter), 5000);
							Class753 arg_A8_0 = this.class753_2;
							Class341.class605_5.Value = RankingType.Top;
							arg_A8_0.method_18(RankingType.Top, false);
							return;
						}
						break;
					}
					this.method_54(true);
				});
			}
			this.class531_3 = new Class531(Class885.Load("rank-forum", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(214f, 81f), 0.95f, true, Color.get_TransparentWhite(), null);
			this.class531_3.method_2(new EventHandler(Class68.smethod_0));
			this.class531_3.bool_1 = true;
			this.class531_3.string_0 = Class41.GetString(OsuString.SongSelection_WebAccess);
			this.class531_3.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 50, Enum70.const_0);
			this.class911_1.Add(this.class531_3);
			this.class531_6 = new Class531(Class885.Load("menu-osu", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(40f, 450f), 0.9f, true, Color.get_White(), null);
			this.class531_6.float_2 = 0.4f;
			this.class911_1.Add(this.class531_6);
			this.class531_7 = new Class531(Class885.Load("menu-osu", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(40f, 450f), 0.91f, true, Color.get_White(), null);
			this.class531_7.float_2 = 0.4f;
			this.class911_1.Add(this.class531_7);
			this.class531_8 = new Class539(Class885.Load("menu-osu", Enum112.flag_1), new Vector2(40f, 450f), 1f, true, Color.get_White(), 250)
			{
				enum115_0 = Enum115.const_7,
				origins_0 = Origins.Centre
			};
			this.class531_8.float_3 = 0.01f;
			this.class531_8.method_2(new EventHandler(this.method_36));
			this.class531_8.bool_1 = true;
			this.class531_8.float_2 = 0.55f;
			this.class531_8.float_4 = -100f;
			this.class531_8.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 100, Enum70.const_0);
			this.class911_1.Add(this.class531_8);
			if (!this.bool_4)
			{
				Class591 class5 = new Class591(new EventHandler(this.method_37), true, false);
				this.class911_1.Add<Class531>(class5.list_0);
			}
			this.class592_0 = new Class592(this.class911_1, 6, new Vector2((float)(Class115.smethod_43() - 55), 49f), 0.87f, true, Color.get_Crimson(), 0, true);
			this.class592_0.float_1 = 0.8f;
			Class533 class6 = new Class533(Class41.GetString(OsuString.SongSelection_Sort), 22f, new Vector2((float)(Class115.smethod_43() - 130), 40f), 0.86f, true, new Color(174, 210, 139));
			class6.origins_0 = Origins.BottomRight;
			this.class911_1.Add(class6);
			float x = class6.vmethod_11().X;
			this.class753_1 = new Class753(this.class911_1, "Choice2", new Vector2((float)(Class115.smethod_43() - 130), 18f));
			this.class753_1.color_1 = new Color(174, 210, 139);
			this.class753_1.class533_0.method_55(Class610.smethod_2(this.class753_1.color_1, 0.2f));
			this.class753_1.class533_0.int_7 = 1;
			class6 = new Class533(Class41.GetString(OsuString.SongSelection_Group), 22f, new Vector2((float)(Class115.smethod_43() - 140 - 118) - x, 40f), 0.86f, true, new Color(146, 195, 230));
			class6.origins_0 = Origins.BottomRight;
			this.class911_1.Add(class6);
			this.class753_0 = new Class753(this.class911_1, "Choice1", new Vector2((float)(Class115.smethod_43() - 140 - 118) - x, 18f));
			this.class753_0.color_1 = new Color(146, 195, 230);
			this.class753_0.class533_0.method_55(Class610.smethod_2(this.class753_0.color_1, 0.2f));
			this.class753_0.class533_0.int_7 = 1;
			Class753 arg_13CC_0 = this.class753_0;
			if (eventHandler2 == null)
			{
				eventHandler2 = new EventHandler(this.method_65);
			}
			arg_13CC_0.method_0(eventHandler2);
			Class753 arg_13EB_0 = this.class753_1;
			if (eventHandler3 == null)
			{
				eventHandler3 = new EventHandler(this.method_66);
			}
			arg_13EB_0.method_0(eventHandler3);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByArtist), TreeSortMode.Artist);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByBPM), TreeSortMode.BPM);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByCreator), TreeSortMode.Creator);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByDateAdded), TreeSortMode.Date);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByDifficulty), TreeSortMode.Difficulty);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByLength), TreeSortMode.Length);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByRankAchieved), TreeSortMode.Rank);
			this.class753_1.method_9(Class41.GetString(OsuString.SongSelection_ByTitle), TreeSortMode.Title);
			List<Class531> arg_14F8_0 = this.class753_1.list_0;
			if (Class68.action_0 == null)
			{
				Class68.action_0 = new Action<Class531>(Class68.smethod_7);
			}
			arg_14F8_0.ForEach(Class68.action_0);
			this.class753_1.method_18(this.class86_0.class605_1.Value, true);
			this.class592_0.Add(Class41.GetString(OsuString.SongSelection_NoGrouping), TreeGroupMode.Search, false);
			if (!this.bool_5 && !this.bool_4)
			{
				this.class592_0.Add(Class41.GetString(OsuString.SongSelection_MyMaps), TreeGroupMode.My_Maps, false);
				this.class592_0.Add(Class41.GetString(OsuString.SongSelection_ByCreator), TreeGroupMode.Creator, false);
			}
			else
			{
				this.class592_0.Add(Class41.GetString(OsuString.SongSelection_ByDifficulty), TreeGroupMode.Difficulty, false);
				this.class592_0.Add(Class41.GetString(OsuString.SongSelection_ByArtist), TreeGroupMode.Artist, false);
			}
			this.class592_0.Add(Class41.GetString(OsuString.SongSelection_RecentlyPlayed), TreeGroupMode.Last_Played, false);
			if (Class115.smethod_43() > 720)
			{
				this.class592_0.Add(Class41.GetString(OsuString.SongSelection_Collections), TreeGroupMode.Collection, false);
			}
			this.class592_0.method_0(new EventHandler(this.method_22));
			this.class533_8 = new Class533(Class41.GetString(OsuString.SongSelection_Search), 13f, new Vector2(220f, 54f), Vector2.get_Zero(), 0.81f, true, Color.get_White(), false);
			this.class533_8.enum115_0 = Enum115.const_7;
			this.class533_8.bool_16 = true;
			this.class533_8.method_57(Color.get_GreenYellow());
			this.class911_1.Add(this.class533_8);
			this.class755_0 = new Class755(13, new Vector2(this.class533_8.method_28().X + this.class533_8.vmethod_11().X, 54f), 174f, true, 0.98f);
			this.class755_0.method_23(false);
			this.class755_0.method_25(!Class111.bool_2);
			this.class755_0.method_27(Class41.GetString(OsuString.SongSelection_TypeToBegin));
			this.class755_0.class533_0.bool_16 = true;
			this.class755_0.method_3(new Class754.Delegate37(this.method_20));
			this.class911_1.Add<Class531>(this.class755_0.list_0);
			this.class533_7 = new Class533(string.Empty, 11f, new Vector2(220f, 66f), Vector2.get_Zero(), 0.81f, true, Color.get_White(), false);
			this.class533_7.bool_16 = true;
			this.class533_7.enum115_0 = Enum115.const_7;
			this.class911_1.Add(this.class533_7);
			this.class531_11 = new Class531(Class885.Load("menu-button-background", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(14f, 46f), 0.69f, true, new Color(0, 0, 0, 102), null);
			this.class911_1.Add(this.class531_11);
			this.class531_16 = new Class531(Class885.Load("songselect-top", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.7f, true, Color.get_White(), null);
			this.class911_1.Add(this.class531_16);
			if (Class115.int_22 > 1366)
			{
				this.class531_16 = new Class531(Class885.Load("songselect-top", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(1365f / Class115.float_4, 0f), 0.7f, true, Color.get_White(), null);
				this.class531_16.int_2 = 1365;
				this.class531_16.int_4 = 1;
				this.class531_16.vector2_2 = new Vector2((float)(Class115.int_22 - 1365), 1f);
				this.class911_1.Add(this.class531_16);
			}
			Class531 class7 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, -10f), 0f, true, Color.get_Black(), null);
			class7.vector2_2 = new Vector2((float)(Class115.smethod_43() + 1) * 1.6f, 97f);
			class7.bool_1 = true;
			this.class911_1.Add(class7);
			class7 = new Class531(Class885.Load("songselect-bottom", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_0, new Vector2(0f, 480f), 0.7f, true, Color.get_White(), null);
			class7.vector2_2 = new Vector2((float)Class115.int_22 / Class115.float_4 / ((float)class7.int_4 * 0.625f), 1f);
			class7.bool_1 = true;
			this.class911_1.Add(class7);
			this.class531_18 = Class599.smethod_0(Color.get_White());
			this.class531_18.enum115_0 = Enum115.const_5;
			this.class531_18.vector2_1 = new Vector2(118f, 200f);
			this.class531_18.method_16(0, Enum70.const_0);
			this.class911_1.Add(this.class531_18);
			bool bool_;
			if (bool_ = (Class466.class296_0 != null))
			{
				Class466.smethod_21(Class466.class296_0);
				Class466.class296_0 = null;
			}
			this.method_50(this.class86_0.class605_0.Value, Class68.string_1 != null, Class68.string_1, bool_);
			Class68.string_1 = null;
			if (!string.IsNullOrEmpty(Class68.string_0))
			{
				this.class755_0.Text = Class68.string_0;
				this.method_46(true);
				Class68.string_0 = null;
			}
			this.class533_5 = new Class533(string.Empty, 30f, new Vector2(60f, 397f), 0.3f, true, new Color(255, 255, 255, 128));
			this.class533_5.method_59(true);
			this.class911_1.Add(this.class533_5);
			this.method_6();
		}

		// Token: 0x0600200E RID: 8206
		// RVA: 0x000B7FA0 File Offset: 0x000B61A0
		protected override void Dispose(bool bool_13)
		{
			try
			{
				this.smartThreadPool_0.Shutdown(false, 0);
				this.smartThreadPool_0.Dispose();
			}
			catch
			{
			}
			Class68.bool_11 = true;
			Class68.class605_0.Value = Class62.Mode;
			Class570.smethod_5(new Class570.Delegate45(this.method_39));
			Class570.smethod_3(new Class570.Delegate44(this.method_38));
			Class569.smethod_1(new Class569.Delegate43(this.method_19));
			Class466.smethod_20(new Class466.Delegate33(this.method_32));
			this.class86_0.method_17(new Class86.Delegate56(this.method_10));
			this.class86_0.method_19(new Class86.Delegate56(this.method_11));
			this.class86_0.method_21(new Class86.Delegate56(this.method_12));
			this.class86_0.method_23(new Class86.Delegate56(this.method_13));
			this.class86_0.method_25(new Class86.Delegate56(this.method_14));
			this.class86_0.method_27(new Class86.Delegate56(this.method_15));
			this.class86_0.method_29(new VoidDelegate(this.method_44));
			this.class86_0.method_31(new VoidDelegate(this.method_45));
			Class696 class = this.class86_0.method_4();
			Class68.string_1 = ((class == null || !class.method_16()) ? null : class.Name);
			this.class86_0.Dispose();
			if (this.class597_0 != null)
			{
				this.class597_0.Dispose();
			}
			if (this.thread_0 != null)
			{
				this.thread_0.Abort();
			}
			Class809.smethod_9(new VoidDelegate(this.method_21));
			Class876.smethod_1(new Class876.Delegate53(this.method_9));
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class911_2 != null)
			{
				this.class911_2.Dispose();
			}
			if (this.class911_4 != null)
			{
				this.class911_4.Dispose();
			}
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				this.class911_3.Dispose();
			}
			else
			{
				List<Class530> arg_21C_0 = this.class911_3.list_2;
				if (Class68.action_1 == null)
				{
					Class68.action_1 = new Action<Class530>(Class68.smethod_8);
				}
				arg_21C_0.ForEach(Class68.action_1);
				Class62.class911_1 = this.class911_3;
			}
			if (this.class110_0 != null)
			{
				this.class110_0.Dispose();
			}
			this.method_41();
			this.bool_8 = true;
			base.Dispose(bool_13);
		}

		// Token: 0x06002050 RID: 8272
		// RVA: 0x000BC67C File Offset: 0x000BA87C
		public override void Draw()
		{
			if (this.bool_8)
			{
				return;
			}
			if (this.class86_0.bool_3 && !this.bool_3 && this.class86_0.method_9() && this.class86_0.method_6().method_11() && !this.class86_0.bool_2 && Class331.int_7 != Class331.int_9 && Class331.smethod_17() && Class331.smethod_8() > 150.0 && Math.Abs((double)(Class331.int_7 + 300) - Class331.smethod_12()) % Class331.smethod_8() < Math.Min(100.0, Class331.smethod_8() / 10.0))
			{
				if (this.class731_0 == null)
				{
					this.class731_0 = Class885.Load("star2", Enum112.flag_6);
				}
				for (int i = 0; i < 5; i++)
				{
					Class531 class = new Class531(this.class731_0, Enum115.const_7, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.111f, false, Color.get_White(), null);
					class.bool_7 = true;
					class.float_2 = 0.8f;
					Class746 class2 = new Class746(TransformationType.Scale, 1f, 2f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Rotation, Class562.smethod_6(-2f, 2f), Class562.smethod_6(-2f, 2f), Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					Vector2 vector;
					vector..ctor(-100f, this.class86_0.method_6().vector2_0.Y + this.class86_0.method_14() + (float)Class562.smethod_1(-20, 20));
					Vector2 vector2_ = vector + new Vector2((float)Class562.smethod_1(140, 900), 0f);
					class2 = new Class746(vector, vector2_, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					this.class911_3.Add(class);
				}
			}
			int num = Class115.int_1 % 1000;
			int num2 = 1000;
			if (Class466.Current != null && !this.class86_0.bool_2 && Class331.smethod_17() && Class331.smethod_0() > 0.0)
			{
				num = (int)(Class331.smethod_0() % Class331.smethod_8());
				num2 = (int)Class331.smethod_8();
			}
			this.class531_6.float_2 = Class778.smethod_11((float)num, 0.45f, 0.4f, (float)num2);
			this.class531_7.float_3 = Class778.smethod_11((float)num, 0.7f, 0f, (float)num2);
			this.class531_7.float_2 = Class778.smethod_11((float)num, 0.45f, 0.49f, (float)num2);
			base.Draw();
			this.class911_3.Draw();
			this.class86_0.Draw();
			this.class911_4.Draw();
			this.class110_0.Draw();
			this.class911_2.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06002036 RID: 8246
		// RVA: 0x000B9918 File Offset: 0x000B7B18
		public override void imethod_2()
		{
			if (this.bool_3)
			{
				if (this.class531_16.class26_0.Count == 0)
				{
					this.method_42();
				}
			}
			else
			{
				Class798.Check(14000);
				this.class110_0.imethod_2();
				this.class755_0.method_25(!Class111.bool_2 && Class115.class89_0 == null);
				if (this.class531_4 != null && Class115.bool_13)
				{
					this.class531_4.float_3 = (float)((80.0 - Class331.double_0 * 30.0) / 255.0) * ((this.class531_14 == null) ? 1f : (1f - this.class531_14.float_3 / 2f));
				}
				if (this.int_3 > 0 && !this.bool_7)
				{
					this.int_3 -= 16;
					if (this.int_3 < 0)
					{
						this.method_4(true);
					}
				}
			}
			bool flag = this.bool_7;
			this.bool_7 = (Class115.class89_0 != null);
			if (this.bool_7 != flag)
			{
				if (this.bool_7)
				{
					this.method_4(false);
				}
				else
				{
					this.int_3 = 100;
				}
			}
			if (this.class531_13.float_3 > 0f && Class115.enum113_0 == Enum113.const_2)
			{
				Class733.float_1 = 0.004f;
				Class733.float_2 = 0f;
				Class733.bool_1 = true;
				Class733.bool_2 = false;
				Class733.bool_0 = true;
				Class733.float_0 = this.class531_13.float_3 / 1.18f;
			}
			this.class533_5.Text = Class876.smethod_10(Class876.class623_0, false);
			if (this.bool_8)
			{
				return;
			}
			this.method_46(false);
			this.method_2();
			this.class86_0.bool_4 = (Class911.class531_0 == null);
			this.class86_0.imethod_2();
			if (!this.bool_3 && this.class86_0.bool_3)
			{
				this.class86_0.float_3 = 0f;
			}
			this.method_43();
			this.method_17();
			this.method_40();
			this.class531_10.method_19(new Vector2(this.class531_10.vector2_1.X, 73f + 310f * this.class86_0.method_12()), 30, Enum70.const_1);
			base.imethod_2();
		}

		// Token: 0x06002051 RID: 8273
		// RVA: 0x000BC9F4 File Offset: 0x000BABF4
		public override void Initialize()
		{
			base.Initialize();
			Class858.smethod_3(Enum0.const_7, null);
			Class876.smethod_4(Mods.None);
			bool flag = this.class86_0.bool_3;
			this.method_4(true);
			this.class86_0.bool_3 = flag;
			Class809.smethod_36(true);
		}

		// Token: 0x06002008 RID: 8200
		// RVA: 0x0001A2CC File Offset: 0x000184CC
		private void method_1(Class296 class296_2, bool bool_13)
		{
			if (!bool_13)
			{
				this.enum113_0 = Enum113.const_0;
				return;
			}
			if (this.thread_0 != null && this.class296_0 == Class466.Current && this.enum113_0 != Enum113.const_2)
			{
				return;
			}
			Class331.smethod_86(Class466.Current, bool_13, true, true);
		}

		// Token: 0x06002014 RID: 8212
		// RVA: 0x000B8704 File Offset: 0x000B6904
		private void method_10(object object_0, Class695 class695_1)
		{
			this.bool_6 = false;
			Class296 current = Class466.Current;
			if (Class466.Current != null)
			{
				Class466.Current.method_52();
			}
			if (class695_1 != null)
			{
				Class466.smethod_21(class695_1.class296_0);
			}
			if (Class466.Current == null)
			{
				return;
			}
			bool flag;
			if ((flag = (current != Class466.Current)) || this.bool_12 || this.class86_0.bool_2)
			{
				this.method_52();
			}
			bool bool_ = !flag;
			if (!this.class86_0.bool_2 && (flag || this.bool_12))
			{
				if (current != null && Class466.Current.method_3() == current.method_3() && !this.bool_12)
				{
					bool_ = true;
					Class331.smethod_59("select-difficulty", 100, Enum112.flag_5);
				}
				else
				{
					Class331.smethod_59("select-expand", 100, Enum112.flag_5);
				}
				this.method_53();
				if (!Class466.Current.bool_8 && Class466.Current.bool_4 && !Class466.Current.method_11())
				{
					Class77.smethod_8(false);
					return;
				}
				try
				{
					this.method_1(Class466.Current, bool_);
				}
				catch
				{
					Class723.smethod_4(Class41.GetString(OsuString.SongSelection_AudioError));
					this.bool_6 = true;
				}
				this.bool_12 = false;
				this.class533_0.class26_0.Clear();
				this.class533_0.float_3 = 0f;
				this.class533_1.class26_0.Clear();
				this.class533_1.float_3 = 0f;
				this.class533_2.class26_0.Clear();
				this.class533_2.float_3 = 0f;
				this.class533_3.class26_0.Clear();
				this.class533_3.float_3 = 0f;
				this.class533_4.class26_0.Clear();
				this.class533_4.float_3 = 0f;
				this.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0));
				this.class533_1.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 100, Class115.int_1 + 500, Enum70.const_0));
				this.class533_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 200, Class115.int_1 + 600, Enum70.const_0));
				this.class533_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 200, Class115.int_1 + 700, Enum70.const_0));
				this.class533_4.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 300, Class115.int_1 + 800, Enum70.const_0));
				this.method_56(false);
				this.class531_13.class26_0.Clear();
				this.class531_13.class26_0.Add(new Class746(TransformationType.Fade, 0.1f, 0f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
				this.method_43();
			}
			Class115.class83_0.method_7(Enum50.flag_0, null);
		}

		// Token: 0x06002015 RID: 8213
		// RVA: 0x0001A3D2 File Offset: 0x000185D2
		private void method_11(object object_0, Class695 class695_1)
		{
			Class331.smethod_59("select-expand", 100, Enum112.flag_5);
		}

		// Token: 0x06002016 RID: 8214
		// RVA: 0x0001A3E2 File Offset: 0x000185E2
		private void method_12(object object_0, Class695 class695_1)
		{
			if (class695_1 is Class696)
			{
				if (this.class86_0.class605_0.Value == TreeGroupMode.Collection)
				{
					this.method_25(class695_1);
					return;
				}
			}
			else
			{
				this.method_24();
			}
		}

		// Token: 0x06002017 RID: 8215
		// RVA: 0x000B8A4C File Offset: 0x000B6C4C
		private void method_13(object object_0, Class695 class695_1)
		{
			if (Class570.bool_0 && Class570.bool_2 && !this.bool_4 && this.bool_5)
			{
				Class876.class623_0 |= Mods.Cinema;
			}
			if (Class570.bool_0 && !this.bool_4 && this.bool_5)
			{
				Class876.class623_0 |= Mods.Autoplay;
			}
			this.method_42();
		}

		// Token: 0x06002018 RID: 8216
		// RVA: 0x000B8AC8 File Offset: 0x000B6CC8
		private void method_14(object object_0, Class695 class695_1)
		{
			if (class695_1.class296_0 != null && class695_1.class296_0.method_26() < 0.0)
			{
				Class296 class = this.class86_0.method_5();
				bool flag = class != null && class.string_4 == class695_1.class296_0.string_4;
				this.method_18(class695_1.class296_0, flag ? WorkItemPriority.Normal : WorkItemPriority.BelowNormal);
			}
		}

		// Token: 0x06002019 RID: 8217
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_15(object object_0, Class695 class695_1)
		{
		}

		// Token: 0x0600201A RID: 8218
		// RVA: 0x000B8B30 File Offset: 0x000B6D30
		private void method_16(TreeGroupMode treeGroupMode_1)
		{
			TreeSortMode treeSortMode = this.class86_0.class605_1.Value;
			switch (treeGroupMode_1)
			{
			case TreeGroupMode.Artist:
				treeSortMode = TreeSortMode.Artist;
				break;
			case TreeGroupMode.BPM:
				break;
			case TreeGroupMode.Creator:
				treeSortMode = TreeSortMode.Creator;
				break;
			case TreeGroupMode.Date:
				treeSortMode = TreeSortMode.Date;
				break;
			case TreeGroupMode.Difficulty:
				treeSortMode = TreeSortMode.Difficulty;
				break;
			case TreeGroupMode.Length:
				treeSortMode = TreeSortMode.Length;
				break;
			default:
				if (treeGroupMode_1 == TreeGroupMode.Title)
				{
					treeSortMode = TreeSortMode.Title;
				}
				break;
			}
			if (treeSortMode != this.class86_0.class605_1.Value)
			{
				this.class86_0.class605_1.Value = treeSortMode;
				this.class753_1.method_18(treeSortMode, true);
			}
		}

		// Token: 0x0600201B RID: 8219
		// RVA: 0x000B8BC4 File Offset: 0x000B6DC4
		private void method_17()
		{
			while (this.int_5 < Class466.list_3.Count)
			{
				Class296 class = Class466.list_3[this.int_5];
				this.int_5++;
				if (class.method_26() < 0.0)
				{
					this.method_18(class, WorkItemPriority.Lowest);
					return;
				}
			}
		}

		// Token: 0x0600201C RID: 8220
		// RVA: 0x000B8C20 File Offset: 0x000B6E20
		internal void method_18(Class296 class296_2, WorkItemPriority workItemPriority_0)
		{
			Class68.Class450 class = new Class68.Class450();
			class.class296_0 = class296_2;
			class.class68_0 = this;
			class.class296_0.method_20(this.smartThreadPool_0, workItemPriority_0, new VoidDelegate(class.method_0));
		}

		// Token: 0x0600201D RID: 8221
		// RVA: 0x000B8C60 File Offset: 0x000B6E60
		private void method_19(object object_0, List<Keys> list_2)
		{
			switch (list_2[0])
			{
			case 340:
				this.method_39(null, 27, true);
				return;
			case 341:
				this.method_39(null, 13, true);
				return;
			default:
				return;
			}
		}

		// Token: 0x06002009 RID: 8201
		// RVA: 0x000B63D4 File Offset: 0x000B45D4
		private void method_2()
		{
			if (this.bool_6)
			{
				return;
			}
			if (Class115.bool_13)
			{
				Enum113 enum = this.enum113_0;
				if (enum == Enum113.const_0)
				{
					Class331.smethod_89(Class331.int_11 - 8, false);
					if (Class331.int_11 <= 10)
					{
						try
						{
							Class331.smethod_86(Class466.Current, false, true, true);
							this.enum113_0 = Enum113.const_2;
						}
						catch (Exception)
						{
							Class723.smethod_4(Class41.GetString(OsuString.SongSelection_AudioError));
							this.bool_6 = true;
						}
					}
				}
			}
			try
			{
				if (Class331.enum100_0 == Enum100.const_0 && Class331.bool_1 && Class466.list_3.Count > 0 && Class115.enum113_0 == Enum113.const_2)
				{
					if (Class466.Current == null)
					{
						Class466.smethod_21(Class466.list_3[0]);
					}
					Class331.smethod_86(Class466.Current, true, true, true);
				}
			}
			catch
			{
				this.bool_6 = true;
			}
		}

		// Token: 0x0600201E RID: 8222
		// RVA: 0x0001A40E File Offset: 0x0001860E
		private void method_20(Class754 class754_0, bool bool_13)
		{
			this.bool_10 |= bool_13;
		}

		// Token: 0x0600201F RID: 8223
		// RVA: 0x0001A41E File Offset: 0x0001861E
		private void method_21()
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_67), false);
		}

		// Token: 0x06002020 RID: 8224
		// RVA: 0x000B8CA4 File Offset: 0x000B6EA4
		private void method_22(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			TreeGroupMode treeGroupMode = (TreeGroupMode)sender;
			if (treeGroupMode == this.treeGroupMode_0)
			{
				return;
			}
			this.method_16(treeGroupMode);
			this.method_50(treeGroupMode, false, null, false);
		}

		// Token: 0x06002022 RID: 8226
		// RVA: 0x000B8DB0 File Offset: 0x000B6FB0
		private void method_23()
		{
			if (Class466.list_3.Count == 0 || (this.bool_5 && Class466.list_3.Count - Class466.int_2 == 0))
			{
				this.bool_8 = true;
				if ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
				{
					Class115.smethod_70(OsuModes.OnlineSelection, false);
					return;
				}
				Class723.smethod_8(Class41.GetString(OsuString.SongSelection_NoBeatmaps), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
				{
					Class115.smethod_70(OsuModes.OnlineSelection, false);
					return;
				}
				Class115.smethod_90("http://osu.ppy.sh/?p=beatmaplist", null);
				Class115.smethod_70(OsuModes.Menu, false);
			}
		}

		// Token: 0x06002023 RID: 8227
		// RVA: 0x000B8E40 File Offset: 0x000B7040
		private void method_24()
		{
			if (Class466.Current == null)
			{
				return;
			}
			Color yellowGreen = Color.get_YellowGreen();
			Color color_;
			color_..ctor(208, 125, 216);
			Class89 class = new Class89(string.Format(Class41.GetString(OsuString.SongSelection_ThisBeatmap), Class466.Current.string_12), true);
			class.method_3(Class41.GetString(OsuString.SongSelection_Collection), yellowGreen, new EventHandler(this.method_68), true, false, true);
			class.method_3(Class41.GetString(OsuString.SongSelection_Delete), Color.get_OrangeRed(), new EventHandler(this.method_29), true, false, true);
			if (this.bool_5)
			{
				class.method_3(Class41.GetString(OsuString.SongSelection_RemoveFromUnplayed), color_, new EventHandler(this.method_28), true, false, true);
				class.method_3(Class41.GetString(OsuString.SongSelection_ClearLocalScores), color_, new EventHandler(this.method_27), true, false, true);
				class.method_3(Class41.GetString(OsuString.SongSelection_Edit), Color.get_OrangeRed(), new EventHandler(this.method_26), true, false, true);
			}
			class.method_3(Class41.GetString(OsuString.General_Cancel), Color.get_Gray(), null, true, false, true);
			Class115.smethod_37(class);
		}

		// Token: 0x06002024 RID: 8228
		// RVA: 0x000B8F5C File Offset: 0x000B715C
		private void method_25(Class695 class695_1)
		{
			Class68.Class451 class = new Class68.Class451();
			class.class68_0 = this;
			class.string_0 = class695_1.Name;
			if (!Class476.smethod_0().ContainsKey(class.string_0))
			{
				return;
			}
			Class89 class2 = new Class89(string.Format(Class41.GetString(OsuString.SongSelection_ThisCollection), class.string_0), true);
			class2.method_3(Class41.GetString(OsuString.SongSelection_Delete), Color.get_OrangeRed(), new EventHandler(class.method_0), true, false, true);
			class2.method_3(Class41.GetString(OsuString.General_Cancel), Color.get_Gray(), null, true, false, true);
			Class115.smethod_37(class2);
		}

		// Token: 0x06002025 RID: 8229
		// RVA: 0x0001A437 File Offset: 0x00018637
		private void method_26(object sender, EventArgs e)
		{
			Class115.smethod_70(OsuModes.Edit, false);
		}

		// Token: 0x06002026 RID: 8230
		// RVA: 0x000B8FF0 File Offset: 0x000B71F0
		private void method_27(object sender, EventArgs e)
		{
			Class908.Remove(Class466.Current.string_3);
			Class723.smethod_5(string.Format(Class41.GetString(OsuString.SongSelection_ClearedScores), Class466.Current.string_12), Color.get_LimeGreen(), 3000, null);
			this.method_56(false);
		}

		// Token: 0x06002027 RID: 8231
		// RVA: 0x000B903C File Offset: 0x000B723C
		private void method_28(object sender, EventArgs e)
		{
			Class466.Current.bool_13 = false;
			Class723.smethod_5(string.Format(Class41.GetString(OsuString.SongSelection_RemovedFromUnplayedSongs), Class466.Current.string_12), Color.get_SkyBlue(), 3000, null);
			this.method_50(this.class86_0.class605_0.Value, false, null, false);
		}

		// Token: 0x06002028 RID: 8232
		// RVA: 0x000B9098 File Offset: 0x000B7298
		private void method_29(object sender, EventArgs e)
		{
			Class89 class = new Class89(string.Format(Class41.GetString(OsuString.SongSelection_DeleteFromDisk), Class466.Current.string_6), true);
			List<Class296> arg_42_0 = Class466.list_3;
			if (Class68.predicate_0 == null)
			{
				Class68.predicate_0 = new Predicate<Class296>(Class68.smethod_13);
			}
			if (arg_42_0.FindAll(Class68.predicate_0).Count > 1 && !Class466.Current.bool_10)
			{
				class.method_3(Class41.GetString(OsuString.SongSelection_DeleteAllDifficulties), Color.get_OrangeRed(), new EventHandler(this.method_31), true, false, true);
				class.method_3(Class41.GetString(OsuString.SongSelection_DeleteOnlyThisDifficulty), Color.get_OrangeRed(), new EventHandler(this.method_30), true, false, true);
			}
			else
			{
				class.method_3(Class41.GetString(OsuString.SongSelection_DeleteThisBeatmap), Color.get_OrangeRed(), new EventHandler(this.method_31), true, false, true);
			}
			class.method_3(Class41.GetString(OsuString.SongSelection_NoCancel), Color.get_Gray(), null, true, false, true);
			Class115.smethod_37(class);
		}

		// Token: 0x0600200A RID: 8202
		// RVA: 0x0001A306 File Offset: 0x00018506
		private bool method_3()
		{
			return this.bool_2;
		}

		// Token: 0x06002029 RID: 8233
		// RVA: 0x0001A440 File Offset: 0x00018640
		private void method_30(object sender, EventArgs e)
		{
			Class466.smethod_34(Class466.Current, false);
		}

		// Token: 0x0600202A RID: 8234
		// RVA: 0x0001A44D File Offset: 0x0001864D
		private void method_31(object sender, EventArgs e)
		{
			Class466.smethod_34(Class466.Current, true);
			Class723.smethod_5(string.Format(Class41.GetString(OsuString.SongSelection_DeletedFromDisk), Class466.Current.string_6), Color.get_Red(), 3000, null);
		}

		// Token: 0x0600202B RID: 8235
		// RVA: 0x000B9190 File Offset: 0x000B7390
		private void method_32(object object_0, List<Class296> list_2)
		{
			this.method_23();
			if (this.bool_8)
			{
				return;
			}
			if (this.class86_0.list_0.Count == 0)
			{
				this.bool_12 = true;
				Class109.smethod_3(true, true);
				this.method_50(TreeGroupMode.None, false, null, true);
			}
			else
			{
				this.method_46(true);
			}
			this.method_7();
		}

		// Token: 0x0600202C RID: 8236
		// RVA: 0x000B91E8 File Offset: 0x000B73E8
		private void method_33(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			this.method_24();
		}

		// Token: 0x0600202D RID: 8237
		// RVA: 0x000B9214 File Offset: 0x000B7414
		private void method_34(object sender, EventArgs e)
		{
			Class68.Class452 class = new Class68.Class452();
			class.class68_0 = this;
			if (!this.bool_5)
			{
				return;
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			this.class86_0.method_85();
			class.mods_0 = Class876.class623_0;
			Class100 class2 = new Class100(Enum62.flag_5);
			class2.method_2(new EventHandler(class.method_0));
			Class115.smethod_37(class2);
		}

		// Token: 0x0600202E RID: 8238
		// RVA: 0x000B928C File Offset: 0x000B748C
		private void method_35(object sender, EventArgs e)
		{
			if (Class570.bool_2)
			{
				this.class86_0.method_85();
				this.class86_0.method_86();
			}
			else if (this.class86_0.bool_2)
			{
				this.class86_0.method_85();
			}
			else
			{
				this.class86_0.method_83();
			}
			Class331.smethod_36(null, "click-short-confirm", 1f, true);
		}

		// Token: 0x0600202F RID: 8239
		// RVA: 0x000B92F8 File Offset: 0x000B74F8
		private void method_36(object sender, EventArgs e)
		{
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return;
			}
			Class746 class = new Class746(TransformationType.Scale, 0.6f, 2f, Class115.int_1, Class115.int_1 + 800, Enum70.const_0);
			class.enum70_0 = Enum70.const_1;
			this.class531_8.float_3 = 1f;
			this.class531_8.class26_0.Clear();
			this.class531_8.class26_0.Add(class);
			this.class531_8.bool_1 = false;
			this.class531_6.vector2_1 = new Vector2(900f, 900f);
			this.class531_7.vector2_1 = new Vector2(900f, 900f);
			this.method_42();
		}

		// Token: 0x06002030 RID: 8240
		// RVA: 0x000B93B0 File Offset: 0x000B75B0
		private void method_37(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			this.method_4(false);
			if (this.bool_4)
			{
				if (this.class296_1 != null)
				{
					Class466.smethod_21(this.class296_1);
					try
					{
						Class331.smethod_84(Class466.Current, false, true, true, false);
					}
					catch
					{
					}
				}
				Class115.smethod_70(OsuModes.MatchSetup, false);
				return;
			}
			Class115.smethod_70(OsuModes.Menu, false);
		}

		// Token: 0x06002031 RID: 8241
		// RVA: 0x000B9424 File Offset: 0x000B7624
		private bool method_38(object object_0, Keys keys_0)
		{
			if (keys_0 == 113)
			{
				this.class86_0.method_85();
				return true;
			}
			return false;
		}

		// Token: 0x06002032 RID: 8242
		// RVA: 0x000B9448 File Offset: 0x000B7648
		private bool method_39(object object_0, Keys keys_0, bool bool_13)
		{
			if (!this.method_3())
			{
				return false;
			}
			if (bool_13)
			{
				if (Class466.Current != null && Class466.Current.method_29() == PlayModes.OsuMania)
				{
					if (Class570.bool_0 && (keys_0 == 187 || keys_0 == Class795.smethod_3(Bindings.IncreaseSpeed)))
					{
						Class435.smethod_1(1);
						return true;
					}
					if (Class570.bool_0 && (keys_0 == 189 || keys_0 == Class795.smethod_3(Bindings.DecreaseSpeed)))
					{
						Class435.smethod_1(-1);
						return true;
					}
				}
				if (keys_0 <= 52)
				{
					if (keys_0 == 27)
					{
						if (this.class86_0.bool_2)
						{
							this.class86_0.method_85();
						}
						else if (this.bool_9)
						{
							this.method_47();
						}
						else
						{
							this.method_37(null, null);
						}
						return true;
					}
					switch (keys_0)
					{
					case 46:
						if (Class570.bool_2)
						{
							this.method_29(null, null);
							return true;
						}
						break;
					case 49:
					case 50:
					case 51:
					case 52:
						if (Class570.bool_0 && Class68.bool_11)
						{
							PlayModes playModes_ = keys_0 - 49;
							this.method_8(playModes_);
							return true;
						}
						break;
					}
				}
				else if (keys_0 != 65)
				{
					switch (keys_0)
					{
					case 112:
						this.method_34(null, null);
						return true;
					case 113:
						if (bool_13)
						{
							this.method_35(null, null);
						}
						return true;
					case 114:
						if (!this.class86_0.bool_2)
						{
							this.method_24();
						}
						return true;
					case 116:
						Class77.smethod_8(true);
						return true;
					}
				}
				else
				{
					if (!this.bool_5)
					{
						return false;
					}
					if (Class570.bool_0 && !this.bool_4)
					{
						Class876.class623_0 ^= Mods.Autoplay;
						Class876.smethod_4(Mods.None);
						return true;
					}
				}
			}
			this.method_46(false);
			return false;
		}

		// Token: 0x0600200B RID: 8203
		// RVA: 0x0001A30E File Offset: 0x0001850E
		private void method_4(bool bool_13)
		{
			this.bool_2 = bool_13;
			this.class86_0.bool_3 = bool_13;
		}

		// Token: 0x06002033 RID: 8243
		// RVA: 0x000B95FC File Offset: 0x000B77FC
		private void method_40()
		{
			this.class911_4.Clear(false);
			if (this.class695_0 == null)
			{
				return;
			}
			this.class695_0.vector2_0 = Class800.smethod_19() / Class115.float_4 - new Vector2(150f, 0f);
			this.class695_0.method_15(Vector2.get_Zero());
			this.class695_0.method_13(this.class911_4);
		}

		// Token: 0x06002034 RID: 8244
		// RVA: 0x000B9670 File Offset: 0x000B7870
		private void method_41()
		{
			if (string.IsNullOrEmpty(Class68.string_0) && this.class86_0.int_5 > 1 && this.int_4 < 0)
			{
				Class68.string_0 = (string.IsNullOrEmpty(this.class755_0.Text) ? null : this.class755_0.Text);
			}
			this.class755_0.Dispose();
		}

		// Token: 0x06002035 RID: 8245
		// RVA: 0x000B96D0 File Offset: 0x000B78D0
		private void method_42()
		{
			if (Class466.Current != null && !this.class86_0.bool_2)
			{
				if (Class115.enum113_0 == Enum113.const_2)
				{
					if (!this.bool_3)
					{
						this.class531_18.method_16(80, Enum70.const_0);
						this.method_41();
						this.method_4(false);
						Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
					}
					OsuModes osuModes_ = Class115.osuModes_1;
					if (osuModes_ == OsuModes.SelectEdit)
					{
						Class115.smethod_70(OsuModes.Edit, false);
						return;
					}
					if (osuModes_ == OsuModes.SelectMulti)
					{
						Class115.smethod_70(OsuModes.MatchSetup, false);
						return;
					}
					if (this.bool_3)
					{
						Class115.smethod_71(OsuModes.Play, false);
						return;
					}
					this.bool_3 = true;
					this.class86_0.float_3 = 500f;
					if (this.class531_14 != null)
					{
						Class531 class = this.class531_14.Clone();
						class.float_0 += 0.01f;
						class.bool_7 = true;
						class.method_26(class.float_2 + 0.04f, 1000, Enum70.const_1);
						class.method_17(1000);
						this.class911_3.Add(class);
					}
					List<Class530> arg_11D_0 = this.class911_1.list_2;
					if (Class68.action_3 == null)
					{
						Class68.action_3 = new Action<Class530>(Class68.smethod_14);
					}
					arg_11D_0.ForEach(Class68.action_3);
					List<Class530> arg_14A_0 = this.class911_2.list_2;
					if (Class68.action_4 == null)
					{
						Class68.action_4 = new Action<Class530>(Class68.smethod_15);
					}
					arg_14A_0.ForEach(Class68.action_4);
					List<Class530> arg_17C_0 = this.class110_0.class911_0.list_2;
					if (Class68.action_5 == null)
					{
						Class68.action_5 = new Action<Class530>(Class68.smethod_16);
					}
					arg_17C_0.ForEach(Class68.action_5);
					this.class531_9.method_16(100, Enum70.const_0);
					this.class531_10.method_16(100, Enum70.const_0);
					this.class531_4.method_39(Color.get_SkyBlue(), 1000, false, Enum70.const_0);
					this.class531_4.method_16(1000, Enum70.const_0);
					this.class531_4.class26_0.Add(new Class746(TransformationType.Scale, 1f, 2f, Class115.int_1, Class115.int_1 + 4000, Enum70.const_1));
					this.class531_4.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 1f, Class115.int_1, Class115.int_1 + 4000, Enum70.const_2));
					return;
				}
			}
		}

		// Token: 0x06002037 RID: 8247
		// RVA: 0x000B9B6C File Offset: 0x000B7D6C
		private void method_43()
		{
			this.class533_6.object_0 = Class435.double_0;
			if (Class466.Current != null && Class466.Current.method_29() == PlayModes.OsuMania)
			{
				this.class533_6.Text = Class435.smethod_2();
				return;
			}
			this.class533_6.Text = string.Empty;
		}

		// Token: 0x06002038 RID: 8248
		// RVA: 0x0001A483 File Offset: 0x00018683
		private void method_44()
		{
			this.class531_8.bool_1 = false;
			Class466.smethod_21(null);
			this.method_56(false);
			Class115.class83_0.method_7(Enum50.flag_0, null);
		}

		// Token: 0x06002039 RID: 8249
		// RVA: 0x0001A4AA File Offset: 0x000186AA
		private void method_45()
		{
			this.class531_8.bool_1 = true;
			this.bool_12 = true;
		}

		// Token: 0x0600203A RID: 8250
		// RVA: 0x000B9BC4 File Offset: 0x000B7DC4
		private void method_46(bool bool_13)
		{
			if (!bool_13 && (Class111.bool_2 || Class115.enum113_0 == Enum113.const_0 || !this.method_3()))
			{
				this.bool_10 = false;
				return;
			}
			bool flag = bool_13;
			if (this.bool_10)
			{
				this.bool_10 = false;
				if (this.class755_0.Text.Length == 0)
				{
					return;
				}
				flag = true;
			}
			bool flag2 = !this.class86_0.bool_2 && ((this.int_4 >= 0 && this.int_4 <= Class115.int_1) || bool_13);
			if (this.class755_0.Text.Length <= 0 || (!flag && (!(this.string_3 != this.class755_0.Text) || !flag2)))
			{
				if (this.class755_0.Text.Length == 0)
				{
					this.method_47();
				}
				return;
			}
			this.int_4 = Class115.int_1 + 300;
			this.method_48();
			if (!flag2)
			{
				this.class533_7.Text = Class41.GetString(OsuString.SongSelection_Searching);
				return;
			}
			this.class86_0.method_64();
			int num = 0;
			int num2 = -1;
			this.int_4 = -1;
			this.string_3 = this.class755_0.Text;
			string text = this.class755_0.Text.ToLower();
			foreach (Class695 current in this.class86_0.list_0)
			{
				current.bool_3 = (!(current is Class696) && !current.class296_0.bool_4 && Class115.osuModes_1 == OsuModes.SelectPlay);
			}
			string[] array = text.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string string_ = array2[i];
				Class68.Delegate32 delegate = Class68.smethod_1(string_);
				foreach (Class695 current2 in this.class86_0.list_0)
				{
					if (!current2.bool_3 && !(current2 is Class696) && !delegate(current2.class296_0))
					{
						current2.bool_3 = true;
					}
				}
			}
			this.class86_0.method_54();
			this.class86_0.method_49(0.0);
			bool flag3 = true;
			for (int j = 0; j < this.class86_0.list_0.Count; j++)
			{
				Class695 class = this.class86_0.list_0[j];
				if (!class.bool_3 && !(class is Class696))
				{
					num++;
					if (flag3)
					{
						if (num2 == -1)
						{
							num2 = j;
						}
						else if (class.method_3())
						{
							flag3 = false;
						}
					}
				}
			}
			Class695 class2 = this.class86_0.method_6();
			if (flag3 && num2 > 0 && (class2 == null || class2.bool_3 || class2.int_1 != this.class86_0.list_0[num2].int_1))
			{
				this.class86_0.method_72(num2, true);
			}
			this.method_51(num);
		}

		// Token: 0x0600203B RID: 8251
		// RVA: 0x000B9EF8 File Offset: 0x000B80F8
		private void method_47()
		{
			if (!this.bool_9)
			{
				return;
			}
			this.class86_0.method_64();
			this.string_3 = string.Empty;
			Class802.class799_0.Clear();
			foreach (Class695 current in this.class86_0.list_0)
			{
				current.bool_3 = false;
			}
			this.bool_9 = false;
			this.int_4 = -1;
			this.class86_0.method_54();
			this.class86_0.method_49(0.0);
			this.class755_0.method_28();
			this.class531_11.class26_0.Add(new Class746(TransformationType.Fade, this.class531_11.float_3, 0.4f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0));
			this.class531_11.class26_0.Add(new Class746(new Vector2(this.class531_11.vector2_1.X, 54f), new Vector2(this.class531_11.vector2_1.X, 46f), Class115.int_1, Class115.int_1 + 200, Enum70.const_1));
			this.class533_7.method_16(200, Enum70.const_0);
		}

		// Token: 0x0600203C RID: 8252
		// RVA: 0x000BA054 File Offset: 0x000B8254
		private void method_48()
		{
			if (this.bool_9)
			{
				return;
			}
			this.class531_11.class26_0.Add(new Class746(TransformationType.Fade, this.class531_11.float_3, 0.95f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0));
			this.class531_11.class26_0.Add(new Class746(new Vector2(this.class531_11.vector2_1.X, 46f), new Vector2(this.class531_11.vector2_1.X, 54f), Class115.int_1, Class115.int_1 + 200, Enum70.const_1));
			this.class533_7.method_14(300, Enum70.const_0);
			this.bool_9 = true;
		}

		// Token: 0x06002041 RID: 8257
		// RVA: 0x0001A4BF File Offset: 0x000186BF
		private void method_49()
		{
			this.class592_0.method_3(this.treeGroupMode_0, true, true);
			this.class753_0.method_18(this.treeGroupMode_0, true);
		}

		// Token: 0x0600200C RID: 8204
		// RVA: 0x0001A323 File Offset: 0x00018523
		private bool method_5()
		{
			return (Class809.bool_4 || (!string.IsNullOrEmpty(Class341.class605_20) && Class809.int_9 == 0)) && Class341.class605_5 != RankingType.Local;
		}

		// Token: 0x06002042 RID: 8258
		// RVA: 0x000BA7DC File Offset: 0x000B89DC
		private void method_50(TreeGroupMode treeGroupMode_1, bool bool_13, string string_4, bool bool_14)
		{
			VoidDelegate voidDelegate = null;
			Class68.Class456 class = new Class68.Class456();
			class.treeGroupMode_0 = treeGroupMode_1;
			class.bool_0 = bool_13;
			class.string_0 = string_4;
			class.bool_1 = bool_14;
			class.class68_0 = this;
			if (!Class466.bool_1 && class.treeGroupMode_0 == TreeGroupMode.Online_Favourites)
			{
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				Class466.smethod_7(voidDelegate);
				Class466.smethod_9();
			}
			if (class.treeGroupMode_0 == TreeGroupMode.None)
			{
				class.treeGroupMode_0 = TreeGroupMode.Search;
			}
			this.treeGroupMode_0 = class.treeGroupMode_0;
			this.method_49();
			this.class86_0.bool_3 = false;
			this.class86_0.method_71(250);
			this.class86_0.float_3 = 500f;
			this.class86_0.method_91(class.treeGroupMode_0, !this.bool_5 && !this.bool_4, new VoidDelegate(class.method_1));
		}

		// Token: 0x06002043 RID: 8259
		// RVA: 0x000BA8C0 File Offset: 0x000B8AC0
		private void method_51(int int_6)
		{
			if (this.bool_9)
			{
				if (int_6 > 1)
				{
					this.class533_7.Text = string.Format(Class41.GetString(OsuString.SongSelection_MatchesFound), int_6);
					return;
				}
				if (int_6 > 0)
				{
					this.class533_7.Text = string.Format(Class41.GetString(OsuString.SongSelection_MatchFound), int_6);
					return;
				}
				this.class533_7.Text = Class41.GetString(OsuString.SongSelection_Reset);
			}
		}

		// Token: 0x06002044 RID: 8260
		// RVA: 0x000BA934 File Offset: 0x000B8B34
		internal void method_52()
		{
			if (this.class86_0.bool_2)
			{
				return;
			}
			Class296 current = Class466.Current;
			Vector3 vector = current.method_33();
			double num = Class297.smethod_9((double)current.int_16);
			this.class533_0.Text = current.method_76();
			if (Class876.smethod_5(Mods.DoubleTime))
			{
				this.class533_2.method_57(new Color(246, 154, 161));
				vector *= 1.5f;
			}
			else if (Class876.smethod_5(Mods.HalfTime))
			{
				this.class533_2.method_57(Color.get_LightBlue());
				vector *= 0.75f;
			}
			else
			{
				this.class533_2.method_57(Color.get_White());
			}
			int num2 = (int)num / 60000;
			int num3 = (int)(num % 60000.0) / 1000;
			this.class533_2.bool_16 = true;
			this.class533_2.Text = string.Format(Class41.GetString(OsuString.SongSelection_BeatmapInfo), new object[]
			{
				num2,
				num3,
				Class296.smethod_0(vector),
				current.int_11
			});
			this.class533_3.Text = string.Format(Class41.GetString(OsuString.SongSelection_BeatmapInfo2), current.ushort_0, current.ushort_1, current.ushort_2);
			if (Class466.Current.string_5.Length > 0)
			{
				this.class533_1.Text = string.Format(Class41.GetString(OsuString.SongSelection_BeatmapInfoCreator), current.string_5);
			}
			else
			{
				this.class533_1.Text = string.Empty;
			}
			if (Class876.smethod_5(Mods.HardRock))
			{
				this.class533_4.method_57(new Color(246, 154, 161));
			}
			else if (Class876.smethod_5(Mods.Easy))
			{
				this.class533_4.method_57(Color.get_LightBlue());
			}
			else
			{
				this.class533_4.method_57(Color.get_White());
			}
			this.class533_4.Text = current.method_30();
			this.class533_4.string_0 = current.method_31();
			this.class533_4.bool_1 = (this.class533_4.string_0 != string.Empty);
			if (current.method_29() == PlayModes.OsuMania)
			{
				Class435.smethod_0(0, Enum45.flag_2);
				this.method_43();
			}
		}

		// Token: 0x06002045 RID: 8261
		// RVA: 0x000BAB94 File Offset: 0x000B8D94
		private void method_53()
		{
			Class731 class = this.class531_12.vmethod_6();
			bool flag = true;
			switch (Class466.Current.submissionStatus_0)
			{
			case SubmissionStatus.NotSubmitted:
			{
				this.class531_12.method_16(500, Enum70.const_0);
				class = this.class731_3;
				Class746 class2 = new Class746(TransformationType.Scale, 1f, 0.8f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0);
				class2.enum70_0 = Enum70.const_1;
				this.class531_12.class26_0.Add(class2);
				flag = false;
				goto IL_1A8;
			}
			case SubmissionStatus.Ranked:
			{
				Class746 class3 = new Class746(TransformationType.Scale, 0.92f, 1.4f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0);
				class3.enum70_0 = Enum70.const_2;
				Class746 class4 = new Class746(TransformationType.Scale, 1.4f, 1f, Class115.int_1 + 200, Class115.int_1 + 400, Enum70.const_0);
				class4.enum70_0 = Enum70.const_2;
				this.class531_12.class26_0.Add(class3);
				this.class531_12.class26_0.Add(class4);
				class = this.class731_2;
				goto IL_1A8;
			}
			case SubmissionStatus.Approved:
			{
				class = this.class731_1;
				Class746 class5 = new Class746(TransformationType.Rotation, -0.4f, 0f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0);
				class5.enum70_0 = Enum70.const_1;
				Class746 class6 = new Class746(TransformationType.Scale, 1.4f, 1f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0);
				class6.enum70_0 = Enum70.const_1;
				this.class531_12.class26_0.Add(class5);
				this.class531_12.class26_0.Add(class6);
				goto IL_1A8;
			}
			}
			class = this.class731_3;
			IL_1A8:
			if (flag)
			{
				if (class != this.class531_12.vmethod_6())
				{
					this.class531_12.vmethod_7(class);
					this.class531_12.method_15(400);
					return;
				}
				this.class531_12.method_14(400, Enum70.const_0);
			}
		}

		// Token: 0x06002046 RID: 8262
		// RVA: 0x000BAD8C File Offset: 0x000B8F8C
		private void method_54(bool bool_13)
		{
			bool flag = this.bool_5 || this.bool_4;
			if (!this.method_5() && flag)
			{
				if (flag)
				{
					this.method_56(false);
				}
				return;
			}
			Class296 current = Class466.Current;
			if (current != null)
			{
				if (this.class531_18 != null)
				{
					this.class531_18.method_14(200, Enum70.const_0);
				}
				if (flag)
				{
					this.method_59();
				}
				current.method_48(flag, bool_13, flag ? Class341.class605_5.Value : RankingType.Top);
				current.method_50(new Delegate52(this.method_55));
			}
		}

		// Token: 0x06002047 RID: 8263
		// RVA: 0x0001A4F2 File Offset: 0x000186F2
		private void method_55(object object_0)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_70), false);
			Class466.Current.method_51(new Delegate52(this.method_55));
		}

		// Token: 0x06002048 RID: 8264
		// RVA: 0x000BAE18 File Offset: 0x000B9018
		internal void method_56(bool bool_13)
		{
			if (this.bool_3)
			{
				return;
			}
			if (this.class531_15 != null)
			{
				this.class531_15.bool_0 = false;
				this.class531_15.method_16(200, Enum70.const_0);
				if (this.class531_15.object_0 != null)
				{
					Class531 class = (Class531)this.class531_15.object_0;
					class.bool_0 = false;
					class.method_16(200, Enum70.const_0);
				}
			}
			if (Class466.Current != null && Class466.Current.int_2 != 0)
			{
				this.class531_3.bool_1 = true;
				this.class531_3.class26_0.Clear();
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, this.class531_3.float_3, 1f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0));
			}
			else
			{
				this.class531_3.bool_1 = false;
				this.class531_3.method_16(300, Enum70.const_0);
			}
			this.class531_18.method_16(50, Enum70.const_0);
			if (Class466.Current == null)
			{
				this.method_59();
				return;
			}
			if (this.bool_5 || this.bool_4)
			{
				this.method_59();
				this.class26_0 = new Class26<Class512>();
				if (!this.method_5())
				{
					Class341.class605_5.Value = RankingType.Local;
				}
				else if (Class341.class605_5.Value > RankingType.Top && Class809.bool_4 && (Class809.class623_0 & Enum30.flag_3) == Enum30.flag_0)
				{
					Class341.class605_5.Value = RankingType.Top;
				}
				RankingType value = Class341.class605_5.Value;
				if (value != RankingType.Local)
				{
					if (!Class466.Current.method_47())
					{
						this.method_54(false);
						return;
					}
					this.class26_0.AddRange(Class466.Current.list_0);
					Class466.Current.method_51(new Delegate52(this.method_55));
					if (Class341.class605_5 == RankingType.Friends && Class466.Current.class512_0 != null)
					{
						List<Class512> arg_223_0 = this.class26_0;
						if (Class68.predicate_1 == null)
						{
							Class68.predicate_1 = new Predicate<Class512>(Class68.smethod_17);
						}
						if (arg_223_0.Find(Class68.predicate_1) == null)
						{
							this.class26_0.method_0((Class512)Class466.Current.class512_0.Clone());
						}
						for (int i = 0; i < this.class26_0.Count; i++)
						{
							this.class26_0[i].int_1 = i + 1;
						}
					}
				}
				else
				{
					List<Class512> list = Class908.smethod_0(Class466.Current.string_3, Class62.Mode);
					if (list != null && list.Count > 0 && !this.class26_0.Contains(list[0]))
					{
						int num = 1;
						foreach (Class512 current in list)
						{
							current.int_1 = num++;
							this.class26_0.Add(current);
						}
					}
				}
				Class466.Current.list_0 = this.class26_0;
				int num2 = 1;
				int num3 = 4;
				if (this.class26_0 != null && this.class26_0.Count > 0)
				{
					for (int j = 0; j < this.class26_0.Count; j++)
					{
						Class512 class2 = this.class26_0[j];
						this.method_57(class2, (float)num3, num2++, class2.int_1, (j < this.class26_0.Count - 1) ? (class2.int_3 - this.class26_0[j + 1].int_3) : 0, null);
						num3 += 33;
					}
					if (this.method_5())
					{
						Class533 class3 = new Class533(Class41.GetString(OsuString.SongSelection_OnlineRecord), 14f, new Vector2(120f, 362f), Vector2.get_Zero(), 0.05f, true, Color.get_TransparentWhite(), false);
						class3.method_58(true);
						class3.origins_0 = Origins.TopCentre;
						class3.method_57(Color.get_White());
						class3.bool_16 = true;
						this.list_1.Add(class3);
						class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 600, Enum70.const_0));
						this.method_57(Class466.Current.class512_0, 382f, 9, (Class466.Current.class512_0 != null) ? Class466.Current.class512_0.int_1 : 0, 0, this.list_1);
						if (Class466.Current.class512_0 != null && Class466.Current.method_41() != Class466.Current.class512_0.vmethod_4())
						{
							Class466.Current.method_42(Class466.Current.class512_0.vmethod_4());
							this.class86_0.method_43();
						}
					}
					this.class110_0.method_14(new Vector2(50f, (float)(this.class26_0.Count * 33)));
				}
				else
				{
					this.method_58();
					this.class110_0.method_14(Vector2.get_Zero());
				}
				this.class110_0.method_23(0f, -0.99f);
				if (Class115.class861_0 != null)
				{
					List<Class512> arg_543_0 = this.class26_0;
					if (Class68.predicate_2 == null)
					{
						Class68.predicate_2 = new Predicate<Class512>(Class68.smethod_18);
					}
					int num4 = arg_543_0.FindIndex(Class68.predicate_2);
					if (num4 >= 8 && this.class26_0.Count > 8)
					{
						this.class110_0.method_23(Math.Max(0f, this.class110_0.vector2_2.Y - this.class110_0.method_3()) * ((float)(num4 - 7) / (float)(this.class26_0.Count - 8)), -0.99f);
					}
				}
				this.class911_2.Add<Class531>(this.list_1);
				this.method_53();
				return;
			}
			if (Class466.Current.submissionStatus_0 < SubmissionStatus.Ranked && !Class466.Current.bool_18 && !bool_13)
			{
				this.method_54(false);
				return;
			}
			this.method_58();
		}

		// Token: 0x06002049 RID: 8265
		// RVA: 0x000BB3F4 File Offset: 0x000B95F4
		private void method_57(Class512 class512_0, float float_0, int int_6, int int_7, int int_8, List<Class531> list_2)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			Class68.Class457 class = new Class68.Class457();
			Vector2 vector;
			vector..ctor(200f, 0f);
			float num = (float)((list_2 != null) ? 3 : 0);
			int num2 = (int_6 - 1) * 50 + Class115.int_1;
			Class746 item = new Class746(TransformationType.Fade, 0f, 1f, num2, num2 + 200, Enum70.const_0);
			string text;
			if (list_2 != null)
			{
				if (class512_0 == null)
				{
					text = Class41.GetString(OsuString.SongSelection_NoPersonalRecordSet);
				}
				else if (Class466.Current.int_4 > 0 && Class466.Current.int_4 > int_7)
				{
					text = string.Format("#{0:#,0} of {1:#,0}", int_7, Class466.Current.int_4);
				}
				else
				{
					text = string.Format("#{0:#,0} {1}", int_7, class512_0.string_2);
				}
			}
			else
			{
				text = class512_0.string_2;
			}
			Color transparentWhite = Color.get_TransparentWhite();
			class.class533_0 = new Class533((int_7 > 0) ? int_7.ToString() : string.Empty, 18f, new Vector2(18f + num, float_0 + 15f), Vector2.get_Zero(), 0.6f, true, transparentWhite, true);
			class.class533_0.origins_0 = Origins.Centre;
			class.class533_0.method_59(true);
			class.class533_0.bool_16 = true;
			if (list_2 != null)
			{
				list_2.Add(class.class533_0);
			}
			else
			{
				this.class110_0.class911_0.Add(class.class533_0);
			}
			class.class537_0 = null;
			if (class512_0 != null && class512_0.class861_0 != null && class512_0.class861_0.int_1 > 0)
			{
				class.class537_0 = new Class537(null, null, (class512_0.class861_0.int_1 == Class115.class861_0.int_1) ? 0 : 500, new Vector2(18f + num, float_0 + 15.4f), 0.45f);
				class512_0.class861_0.method_3(class.class537_0, 46f);
				if (list_2 != null)
				{
					list_2.Add(class.class537_0);
				}
				else
				{
					this.class110_0.class911_0.Add(class.class537_0);
				}
			}
			if (class512_0 != null && class512_0.class861_0 != null && Class111.list_4.Contains(class512_0.class861_0.int_1) && Class341.class605_5.Value != RankingType.Friends)
			{
				transparentWhite..ctor(255, 235, 115, 0);
			}
			int num3 = 400;
			Class531 class2 = new Class533(text, 16f, new Vector2(58f + num, (class512_0 != null) ? float_0 : (float_0 + 6f)), Vector2.get_Zero(), 0.4f, true, transparentWhite, true);
			Class746 class3 = new Class746(class2.vector2_0 - vector, class2.vector2_0, num2, num2 + num3, Enum70.const_0);
			class3.enum70_0 = Enum70.const_30;
			class2.class26_0.Add(class3);
			class2.class26_0.Add(item);
			if (list_2 != null)
			{
				list_2.Add(class2);
			}
			else
			{
				this.class110_0.class911_0.Add(class2);
			}
			if (class512_0 != null)
			{
				string text2 = string.Format(Class41.GetString(OsuString.SongSelection_ScoreList), class512_0.int_3, class512_0.int_0);
				class2 = new Class533(text2, 12f, new Vector2(58f + num, 15f + float_0), Vector2.get_Zero(), 0.4f, true, Color.get_TransparentWhite(), true);
				class3 = new Class746(class2.vector2_0 - vector, class2.vector2_0, num2, num2 + num3, Enum70.const_0);
				class3.enum70_0 = Enum70.const_30;
				class2.class26_0.Add(class3);
				class2.class26_0.Add(item);
				if (list_2 != null)
				{
					list_2.Add(class2);
				}
				else
				{
					this.class110_0.class911_0.Add(class2);
				}
				Class533 class4 = new Class533(string.Concat(new object[]
				{
					Class876.smethod_11(class512_0.class623_0, false, false),
					'\n',
					string.Format("{0:0.00}%", class512_0.vmethod_1() * 100f),
					'\n',
					(int_8 > 0) ? ("+" + int_8.ToString("#,0")) : "-"
				}), 10f, new Vector2(236f + num, 0f + float_0), new Vector2(100f, 0f), 0.4f, true, Color.get_TransparentWhite(), true);
				class4.method_59(true);
				class4.bool_15 = false;
				class4.enum72_0 = Enum72.const_3;
				class4.origins_0 = Origins.TopRight;
				class3 = new Class746(class4.vector2_0 - vector, class4.vector2_0, num2, num2 + num3, Enum70.const_0);
				class3.enum70_0 = Enum70.const_30;
				class4.class26_0.Add(class3);
				class4.class26_0.Add(item);
				if (list_2 != null)
				{
					list_2.Add(class4);
				}
				else
				{
					this.class110_0.class911_0.Add(class4);
				}
			}
			DateTime dateTime = DateTime.Now;
			if (class512_0 != null)
			{
				try
				{
					class2 = new Class531(Class885.Load(string.Format("ranking-{0}-small", class512_0.vmethod_4()), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(46f + num, 14.6f + float_0), 0.4f, true, Color.get_TransparentWhite(), null);
					class3 = new Class746(class2.vector2_0 - vector, class2.vector2_0, num2, num2 + num3, Enum70.const_0);
					class3.enum70_0 = Enum70.const_30;
					class2.class26_0.Add(class3);
					class2.class26_0.Add(item);
					if (list_2 != null)
					{
						list_2.Add(class2);
					}
					else
					{
						this.class110_0.class911_0.Add(class2);
					}
				}
				catch (Exception)
				{
				}
				dateTime = class512_0.dateTime_0.ToLocalTime();
				double totalHours = (DateTime.Now - dateTime).TotalHours;
				if (totalHours < 96.0)
				{
					Class534 class5 = new Class534(FontAwesome.arrow_circle_o_up, 18f, new Vector2(248f + num, 15f + float_0))
					{
						float_0 = 0.4f,
						bool_0 = true,
						color_0 = Color.get_TransparentWhite(),
						float_3 = 0f
					};
					class3 = new Class746(class5.vector2_0 - vector, class5.vector2_0, num2, num2 + num3, Enum70.const_0);
					class3.enum70_0 = Enum70.const_30;
					class5.class26_0.Add(class3);
					class5.class26_0.Add(item);
					if (list_2 != null)
					{
						list_2.Add(class5);
					}
					else
					{
						this.class110_0.class911_0.Add(class5);
					}
					string text3 = (int)totalHours + "h";
					if (totalHours > 47.0)
					{
						text3 = (int)(totalHours / 24.0) + "d";
					}
					else if (totalHours >= 1.0)
					{
						text3 = (int)totalHours + "h";
					}
					else if (totalHours > 0.016666666666666666)
					{
						text3 = (int)(totalHours * 60.0) + "m";
					}
					else
					{
						text3 = (int)(totalHours * 3600.0) + "s";
					}
					Class533 class6 = new Class533(text3, 10f, new Vector2(258f + num, 15f + float_0), new Vector2(100f, 0f), 0.4f, true, Color.get_TransparentWhite(), true);
					class6.method_59(true);
					class6.bool_15 = false;
					class6.origins_0 = Origins.CentreLeft;
					class3 = new Class746(class6.vector2_0 - vector, class6.vector2_0, num2, num2 + num3, Enum70.const_0);
					class3.enum70_0 = Enum70.const_30;
					class6.class26_0.Add(class3);
					class6.class26_0.Add(item);
					if (list_2 != null)
					{
						list_2.Add(class6);
					}
					else
					{
						this.class110_0.class911_0.Add(class6);
					}
				}
			}
			item = new Class746(TransformationType.Fade, 0f, 0.3f, num2, num2 + 200, Enum70.const_0);
			class2 = new Class531(Class885.Load("menu-button-background", Enum112.flag_6), Enum115.const_5, Origins.CentreLeft, Enum114.const_0, new Vector2(num, 15f + float_0), 0.12f + (float)int_6 / 1000f, true, new Color(0, 0, 0, 120), class512_0);
			if (class512_0 != null)
			{
				if (class512_0.playModes_0 == PlayModes.OsuMania)
				{
					class2.string_0 = string.Format(Class41.GetString(OsuString.SongSelection_TooltipScoreMania), new object[]
					{
						dateTime,
						class512_0.ushort_3,
						class512_0.ushort_1,
						class512_0.ushort_4,
						(int)(class512_0.ushort_0 + class512_0.ushort_2 + class512_0.ushort_5),
						class512_0.vmethod_1() * 100f,
						Class876.smethod_10(class512_0.class623_0, true)
					});
				}
				else
				{
					class2.string_0 = string.Format(Class41.GetString(OsuString.SongSelection_TooltipScore), new object[]
					{
						dateTime,
						class512_0.ushort_1,
						class512_0.ushort_0,
						class512_0.ushort_2,
						class512_0.ushort_5,
						class512_0.vmethod_1() * 100f,
						Class876.smethod_10(class512_0.class623_0, true)
					});
				}
				class2.method_2(new EventHandler(this.method_63));
				class2.bool_2 = true;
				class2.bool_1 = true;
				class2.class746_1 = new Class746(TransformationType.Fade, 0.3f, 0.6f, 0, 200, Enum70.const_0);
				Class531 arg_A22_0 = class2;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				arg_A22_0.method_35(eventHandler);
				Class531 arg_A3A_0 = class2;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(class.method_1);
				}
				arg_A3A_0.method_37(eventHandler2);
			}
			class3 = new Class746(class2.vector2_0 - vector, class2.vector2_0, num2, num2 + num3, Enum70.const_0);
			class3.enum70_0 = Enum70.const_30;
			class2.float_3 = 0f;
			class2.class26_0.Add(class3);
			class2.class26_0.Add(item);
			class2.float_2 = 0.55f;
			int num4 = 150;
			int num5 = 900;
			int i;
			for (i = 0; i < num4 + num5; i += (int)Math.Max(100.0, Class331.smethod_8() * 2.0))
			{
			}
			i -= num4 + num5;
			int num6 = num2 + (int)(Class331.smethod_8() * (1.0 - Class331.double_0)) - num4;
			Class746 class7 = new Class746(new Color(0, 0, 0, 255), new Color(100, 100, 100, 255), num6, num6 + num4);
			class7.enum70_0 = Enum70.const_2;
			class7.int_2 = num5 + i;
			class7.bool_0 = true;
			class2.class26_0.Add(class7);
			Class746 class8 = new Class746(new Color(100, 100, 100, 255), new Color(0, 0, 0, 255), num6 + num4, num6 + num4 + num5);
			class8.enum70_0 = Enum70.const_1;
			class8.int_2 = num4 + i;
			class8.bool_0 = true;
			class2.class26_0.Add(class8);
			if (list_2 != null)
			{
				list_2.Add(class2);
			}
			else
			{
				this.class110_0.class911_0.Add(class2);
			}
			List<Class530> arg_C04_0 = this.class110_0.class911_0.list_2;
			if (Class68.action_6 == null)
			{
				Class68.action_6 = new Action<Class530>(Class68.smethod_19);
			}
			arg_C04_0.ForEach(Class68.action_6);
		}

		// Token: 0x0600204A RID: 8266
		// RVA: 0x000BC01C File Offset: 0x000BA21C
		private void method_58()
		{
			if (Class466.Current == null)
			{
				return;
			}
			this.class531_15 = new Class531(Class885.Load("selection-norecords", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(118f, 170f), 0.12f, true, Color.get_TransparentWhite(), null);
			this.class531_15.method_14(400, Enum70.const_0);
			this.class531_15.method_19(this.class531_15.vector2_1 + new Vector2(0f, 30f), 400, Enum70.const_1);
			this.class911_2.Add(this.class531_15);
			if (this.method_5() || !this.bool_5)
			{
				if (Class466.Current.bool_18)
				{
					this.class531_15.vmethod_7(Class885.Load("selection-update", Enum112.flag_1));
					this.class531_15.method_2(new EventHandler(this.method_60));
					this.class531_15.class746_1 = new Class746(Color.get_White(), Color.get_LimeGreen(), 0, 200);
					this.class531_15.bool_1 = true;
					Class531 class = new Class531(Class885.Load("selection-update", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(118f, 200f), 0.13f, true, Color.get_TransparentWhite(), null);
					class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0));
					Class746 class2 = new Class746(TransformationType.Scale, 1f, 2f, Class115.int_1 + 400, Class115.int_1 + 1400, Enum70.const_0);
					this.class531_15.object_0 = class;
					class2.bool_0 = true;
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 400, Class115.int_1 + 1400, Enum70.const_0);
					this.class531_15.object_0 = class;
					class2.bool_0 = true;
					class2.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					this.class911_1.Add(class);
					return;
				}
				switch (Class466.Current.submissionStatus_0)
				{
				case SubmissionStatus.Unknown:
					this.class531_15.vmethod_7(Class885.Load("selection-unknown", Enum112.flag_1));
					return;
				case SubmissionStatus.NotSubmitted:
					this.class531_15.vmethod_7(Class885.Load("selection-notsubmitted", Enum112.flag_1));
					return;
				case SubmissionStatus.Pending:
					this.class531_15.vmethod_7(Class885.Load("selection-notranked", Enum112.flag_1));
					return;
				case SubmissionStatus.EditableCutoff:
					break;
				case SubmissionStatus.Ranked:
				case SubmissionStatus.Approved:
					if (!this.bool_5)
					{
						this.class531_15.vmethod_7(Class885.Load("selection-latestranked", Enum112.flag_1));
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600204B RID: 8267
		// RVA: 0x000BC2C4 File Offset: 0x000BA4C4
		private void method_59()
		{
			this.class26_0 = null;
			List<Class531> arg_2A_0 = this.list_1;
			if (Class68.action_7 == null)
			{
				Class68.action_7 = new Action<Class531>(Class68.smethod_20);
			}
			arg_2A_0.ForEach(Class68.action_7);
			this.list_1.Clear();
			this.class110_0.method_29(true);
		}

		// Token: 0x0600200F RID: 8207
		// RVA: 0x000B8210 File Offset: 0x000B6410
		private void method_6()
		{
			if (this.class531_5 != null)
			{
				this.class911_1.Remove(this.class531_5);
				this.class531_5 = null;
			}
			if (this.class531_4 != null)
			{
				this.class531_4.bool_0 = false;
				this.class531_4.method_16(300, Enum70.const_0);
				this.class531_4 = null;
			}
			if (this.bool_5 || this.bool_4)
			{
				switch (Class62.Mode)
				{
				case PlayModes.Taiko:
					this.class531_4 = new Class531(Class885.Load("mode-taiko", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.12f, true, new Color(255, 255, 255, 70), null);
					break;
				case PlayModes.CatchTheBeat:
					this.class531_4 = new Class531(Class885.Load("mode-fruits", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.12f, true, new Color(255, 255, 255, 70), null);
					break;
				case PlayModes.OsuMania:
					this.class531_4 = new Class531(Class885.Load("mode-mania", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.12f, true, new Color(255, 255, 255, 70), null);
					break;
				default:
					this.class531_4 = new Class531(Class885.Load("mode-osu", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.12f, true, new Color(255, 255, 255, 70), null);
					break;
				}
				this.class531_4.bool_7 = true;
				this.class911_3.Add(this.class531_4);
				if (Class68.bool_11)
				{
					Class731 class;
					switch (Class62.Mode)
					{
					case PlayModes.Taiko:
						class = Class885.Load("mode-taiko-small", Enum112.flag_6);
						break;
					case PlayModes.CatchTheBeat:
						class = Class885.Load("mode-fruits-small", Enum112.flag_6);
						break;
					case PlayModes.OsuMania:
						class = Class885.Load("mode-mania-small", Enum112.flag_6);
						break;
					default:
						class = Class885.Load("mode-osu-small", Enum112.flag_6);
						break;
					}
					float num = (float)(Class115.bool_21 ? 140 : 120);
					this.class531_5 = new Class531(class, Enum115.const_11, Origins.Centre, Enum114.const_0, new Vector2(num + 28.8f, 35f), 0.97f, true, Color.get_White(), null);
					this.class531_5.bool_7 = true;
					this.class911_1.Add(this.class531_5);
					this.class531_5.float_2 = 0f;
					this.class531_5.method_26(1f, 1000, Enum70.const_25);
				}
			}
			this.method_7();
			this.class86_0.method_43();
			this.class753_0.method_12();
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_NoGrouping), TreeGroupMode.Search);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByArtist), TreeGroupMode.Artist);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByBPM), TreeGroupMode.BPM);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByCreator), TreeGroupMode.Creator);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByDateAdded), TreeGroupMode.Date);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByDifficulty), TreeGroupMode.Difficulty);
			if (Class62.Mode == PlayModes.OsuMania)
			{
				this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByKeyCount), TreeGroupMode.Mania_Keys);
			}
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByLength), TreeGroupMode.Length);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByMode), TreeGroupMode.Mode);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByRankAchieved), TreeGroupMode.Rank);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_ByTitle), TreeGroupMode.Title);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_Collections), TreeGroupMode.Collection);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_Favourites), TreeGroupMode.Online_Favourites);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_MyMaps), TreeGroupMode.My_Maps);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_RankedStatus), TreeGroupMode.RankedStatus);
			this.class753_0.method_9(Class41.GetString(OsuString.SongSelection_RecentlyPlayed), TreeGroupMode.Last_Played);
			List<Class531> arg_4B4_0 = this.class753_0.list_0;
			if (Class68.action_2 == null)
			{
				Class68.action_2 = new Action<Class531>(Class68.smethod_9);
			}
			arg_4B4_0.ForEach(Class68.action_2);
			if (Class62.Mode != PlayModes.OsuMania && this.treeGroupMode_0 == TreeGroupMode.Mania_Keys)
			{
				this.method_50(TreeGroupMode.Search, false, null, false);
			}
			else
			{
				this.method_49();
			}
			Class876.smethod_4(Mods.None);
		}

		// Token: 0x0600204C RID: 8268
		// RVA: 0x000BC318 File Offset: 0x000BA518
		private void method_60(object sender, EventArgs e)
		{
			EventHandler eventHandler = null;
			Class68.Class458 class = new Class68.Class458();
			class.object_0 = sender;
			class.eventArgs_0 = e;
			class.class68_0 = this;
			Class115.smethod_6(true);
			if (Class466.Current.string_5 == Class341.class605_20)
			{
				Class89 class2 = new Class89(Class41.GetString(OsuString.SongSelection_WarningDestroyChanges), false);
				Class89 arg_73_0 = class2;
				string arg_73_1 = Class41.GetString(OsuString.SongSelection_DiscardLocalChanges);
				Color arg_73_2 = Color.get_OrangeRed();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				arg_73_0.method_3(arg_73_1, arg_73_2, eventHandler, true, false, true);
				class2.method_3(Class41.GetString(OsuString.SongSelection_KeepLocalChanges), Color.get_Gray(), null, true, false, true);
				Class115.smethod_37(class2);
			}
			else
			{
				this.method_61(class.object_0, class.eventArgs_0);
			}
			Class115.smethod_6(false);
		}

		// Token: 0x0600204D RID: 8269
		// RVA: 0x000BC3D8 File Offset: 0x000BA5D8
		private void method_61(object sender, EventArgs e)
		{
			FileNetRequest.Delegate10 delegate = null;
			Class68.Class459 class = new Class68.Class459();
			class.eventArgs_0 = e;
			class.class68_0 = this;
			Class531 class2 = (Class531)sender;
			class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0.2f, Class115.int_1, Class115.int_1 + 400, Enum70.const_0));
			if (class2.object_0 != null)
			{
				((Class531)class2.object_0).class26_0[0] = ((Class531)class2.object_0).class26_0[0].method_1();
				((Class531)class2.object_0).class26_0[1] = ((Class531)class2.object_0).class26_0[1].method_1();
			}
			class2.bool_1 = false;
			class.class296_0 = Class466.Current;
			try
			{
				if (!class.class296_0.bool_10)
				{
					this.string_2 = class.class296_0.string_9 + "_";
					FileNetRequest fileNetRequest = new FileNetRequest(string.Format("{0}/{1}_", class.class296_0.method_3(), class.class296_0.string_9), "http://osu.ppy.sh/web/maps/" + Path.GetFileName(class.class296_0.string_9.Replace("#", "%23")));
					FileNetRequest arg_151_0 = fileNetRequest;
					if (delegate == null)
					{
						delegate = new FileNetRequest.Delegate10(class.method_0);
					}
					arg_151_0.method_2(delegate);
					Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
					Class169.smethod_0(fileNetRequest);
				}
				else
				{
					new Class131("http://osu.ppy.sh/web/maps/" + Path.GetFileName(class.class296_0.string_9.Replace("#", "%23")));
					Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
					class.class296_0.method_69();
					class.class296_0.method_72(Class296.Enum64.const_0, true);
					Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600204E RID: 8270
		// RVA: 0x000BC5D0 File Offset: 0x000BA7D0
		private void method_62(bool bool_13)
		{
			Class68.Class460 class = new Class68.Class460();
			class.bool_0 = bool_13;
			class.class68_0 = this;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x0600204F RID: 8271
		// RVA: 0x000BC608 File Offset: 0x000BA808
		private void method_63(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				return;
			}
			bool flag = Class800.mouseButtons_3 == MouseButtons.Right;
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class512 class = (Class512)((Class531)sender).object_0;
			if (class != null && !class.bool_1 && flag)
			{
				Class115.smethod_37(new Class93(class));
				return;
			}
			Class802.class512_0 = class;
			Class802.smethod_1(true);
			Class115.smethod_70(OsuModes.Rank, false);
		}

		// Token: 0x06002053 RID: 8275
		// RVA: 0x000BCA6C File Offset: 0x000BAC6C
		[CompilerGenerated]
		private void method_64(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "select-expand", 1f, false);
			this.class597_0.method_0();
		}

		// Token: 0x06002058 RID: 8280
		// RVA: 0x0001A521 File Offset: 0x00018721
		[CompilerGenerated]
		private void method_65(object sender, EventArgs e)
		{
			this.method_22(sender, null);
		}

		// Token: 0x06002059 RID: 8281
		// RVA: 0x000BCB64 File Offset: 0x000BAD64
		[CompilerGenerated]
		private void method_66(object sender, EventArgs e)
		{
			TreeSortMode treeSortMode = (TreeSortMode)sender;
			if (treeSortMode != this.class86_0.class605_1.Value)
			{
				this.class86_0.class605_1.Value = treeSortMode;
				this.class86_0.method_89();
			}
		}

		// Token: 0x0600205D RID: 8285
		// RVA: 0x0001A538 File Offset: 0x00018738
		[CompilerGenerated]
		private void method_67()
		{
			this.method_54(false);
		}

		// Token: 0x06002061 RID: 8289
		// RVA: 0x000BCBD4 File Offset: 0x000BADD4
		[CompilerGenerated]
		private void method_68(object sender, EventArgs e)
		{
			Class696 class = this.class86_0.method_4();
			Class68.string_1 = ((class == null || !class.method_16()) ? null : class.Name);
			Class92 class89_ = new Class92(new EventHandler(this.method_69));
			Class115.smethod_37(class89_);
		}

		// Token: 0x06002062 RID: 8290
		// RVA: 0x0001A565 File Offset: 0x00018765
		[CompilerGenerated]
		private void method_69(object sender, EventArgs e)
		{
			if (this.class86_0.class605_0.Value == TreeGroupMode.Collection)
			{
				this.method_50(TreeGroupMode.Collection, Class68.string_1 != null, Class68.string_1, false);
			}
		}

		// Token: 0x06002010 RID: 8208
		// RVA: 0x0001A356 File Offset: 0x00018556
		private void method_7()
		{
			this.smartThreadPool_0.Cancel();
			this.int_5 = 0;
			this.method_52();
			this.class86_0.method_69();
			this.class86_0.method_55();
		}

		// Token: 0x06002067 RID: 8295
		// RVA: 0x0001A5B7 File Offset: 0x000187B7
		[CompilerGenerated]
		private void method_70()
		{
			if (Class466.Current != null)
			{
				if (Class466.Current.int_12 != 0)
				{
					this.method_52();
				}
				this.method_56(true);
			}
		}

		// Token: 0x06002011 RID: 8209
		// RVA: 0x0001A386 File Offset: 0x00018586
		private void method_8(PlayModes playModes_0)
		{
			if (Class62.Mode == playModes_0)
			{
				return;
			}
			Class62.Mode = playModes_0;
			Class809.smethod_36(true);
			if (Class466.Current.method_5() == PlayModes.Osu)
			{
				this.method_54(true);
			}
			this.method_6();
		}

		// Token: 0x06002012 RID: 8210
		// RVA: 0x0001A3B6 File Offset: 0x000185B6
		private void method_9(object object_0, Mods mods_0)
		{
			this.method_7();
		}

		// Token: 0x06002013 RID: 8211
		// RVA: 0x0001A3BE File Offset: 0x000185BE
		internal void Select(Class296 class296_2)
		{
			if (class296_2 != null)
			{
				this.class86_0.Select(class296_2, true, null, false);
			}
		}

		// Token: 0x06002021 RID: 8225
		// RVA: 0x000B8CD8 File Offset: 0x000B6ED8
		private static void smethod_0(object sender, EventArgs e)
		{
			Class89 class = new Class89(Class41.GetString(OsuString.SongSelection_OpenOptions), true);
			Class89 arg_41_0 = class;
			string arg_41_1 = Class41.GetString(OsuString.SongSelection_ListingScores);
			Color arg_41_2 = Color.get_OrangeRed();
			if (Class68.eventHandler_8 == null)
			{
				Class68.eventHandler_8 = new EventHandler(Class68.smethod_10);
			}
			arg_41_0.method_3(arg_41_1, arg_41_2, Class68.eventHandler_8, true, false, true);
			Class89 arg_76_0 = class;
			string arg_76_1 = Class41.GetString(OsuString.SongSelection_Topic);
			Color arg_76_2 = Color.get_YellowGreen();
			if (Class68.eventHandler_9 == null)
			{
				Class68.eventHandler_9 = new EventHandler(Class68.smethod_11);
			}
			arg_76_0.method_3(arg_76_1, arg_76_2, Class68.eventHandler_9, true, false, true);
			Class89 arg_AB_0 = class;
			string arg_AB_1 = Class41.GetString(OsuString.SongSelection_Reply);
			Color arg_AB_2 = Color.get_YellowGreen();
			if (Class68.eventHandler_10 == null)
			{
				Class68.eventHandler_10 = new EventHandler(Class68.smethod_12);
			}
			arg_AB_0.method_3(arg_AB_1, arg_AB_2, Class68.eventHandler_10, true, false, true);
			class.method_3(Class41.GetString(OsuString.General_Cancel), Color.get_Gray(), null, true, false, true);
			Class115.smethod_37(class);
		}

		// Token: 0x0600203D RID: 8253
		// RVA: 0x000BA114 File Offset: 0x000B8314
		private static Class68.Delegate32 smethod_1(string string_4)
		{
			Class68.Delegate32 delegate = null;
			Class68.Class453 class = new Class68.Class453();
			class.string_0 = string_4;
			Match match = Class68.regex_0.Match(class.string_0);
			if (match.Success)
			{
				Class68.Delegate32 delegate2 = null;
				Class68.Delegate32 delegate3 = null;
				Class68.Delegate32 delegate4 = null;
				Class68.Delegate32 delegate5 = null;
				Class68.Delegate32 delegate6 = null;
				Class68.Delegate32 delegate7 = null;
				Class68.Delegate32 delegate8 = null;
				Class68.Delegate32 delegate9 = null;
				Class68.Delegate32 delegate10 = null;
				Class68.Delegate32 delegate11 = null;
				Class68.Delegate32 delegate12 = null;
				Class68.Delegate32 delegate13 = null;
				Class68.Delegate32 delegate14 = null;
				Class68.Delegate32 delegate15 = null;
				Class68.Delegate32 delegate16 = null;
				Class68.Class454 class2 = new Class68.Class454();
				class2.class453_0 = class;
				string text = match.Groups[1].Value.ToLower();
				class2.string_0 = match.Groups[2].Value;
				string text2 = match.Groups[3].Value.ToLower();
				if (class2.string_0 == "=")
				{
					class2.string_0 = "==";
				}
				Match match2 = Class68.regex_1.Match(text2);
				if (match2.Success)
				{
					class2.double_0 = double.Parse(match2.Groups[0].Value, Class115.numberFormatInfo_0);
					Class68.Class455 class3 = new Class68.Class455();
					class3.class454_0 = class2;
					class3.class453_0 = class;
					string key;
					switch (key = text)
					{
					case "star":
					case "stars":
						if (delegate2 == null)
						{
							delegate2 = new Class68.Delegate32(class2.method_0);
						}
						return delegate2;
					case "cs":
						if (delegate3 == null)
						{
							delegate3 = new Class68.Delegate32(class2.method_1);
						}
						return delegate3;
					case "hp":
						if (delegate4 == null)
						{
							delegate4 = new Class68.Delegate32(class2.method_2);
						}
						return delegate4;
					case "od":
						if (delegate5 == null)
						{
							delegate5 = new Class68.Delegate32(class2.method_3);
						}
						return delegate5;
					case "ar":
						if (delegate6 == null)
						{
							delegate6 = new Class68.Delegate32(class2.method_4);
						}
						return delegate6;
					case "key":
					case "keys":
						if (delegate7 == null)
						{
							delegate7 = new Class68.Delegate32(class2.method_5);
						}
						return delegate7;
					case "speed":
						if (delegate8 == null)
						{
							delegate8 = new Class68.Delegate32(class2.method_6);
						}
						return delegate8;
					case "bpm":
						if (delegate9 == null)
						{
							delegate9 = new Class68.Delegate32(class2.method_7);
						}
						return delegate9;
					case "length":
						if (delegate10 == null)
						{
							delegate10 = new Class68.Delegate32(class2.method_8);
						}
						return delegate10;
					case "drain":
						if (delegate11 == null)
						{
							delegate11 = new Class68.Delegate32(class2.method_9);
						}
						return delegate11;
					case "played":
						try
						{
							class3.dateTime_0 = DateTime.Now.AddDays(-class2.double_0);
						}
						catch (ArgumentOutOfRangeException)
						{
							class3.dateTime_0 = ((class2.double_0 > 0.0) ? DateTime.MinValue : DateTime.MaxValue);
						}
						return new Class68.Delegate32(class3.method_0);
					}
				}
				string a;
				if ((a = text) != null)
				{
					if (!(a == "unplayed"))
					{
						if (a == "mode")
						{
							class2.double_0 = Class68.smethod_4(text2, Class68.keyValuePair_0);
							if (delegate13 == null)
							{
								delegate13 = new Class68.Delegate32(class2.method_11);
							}
							return delegate13;
						}
						if (a == "status")
						{
							class2.double_0 = Class68.smethod_4(text2, Class68.keyValuePair_1);
							string a2;
							if (class2.double_0 == 4.0 && (a2 = class2.string_0) != null)
							{
								if (!(a2 == ">") && !(a2 == "<="))
								{
									if (a2 == "==")
									{
										if (delegate14 == null)
										{
											delegate14 = new Class68.Delegate32(class2.method_12);
										}
										return delegate14;
									}
									if (a2 == "!=")
									{
										if (delegate15 == null)
										{
											delegate15 = new Class68.Delegate32(class2.method_13);
										}
										return delegate15;
									}
								}
								else
								{
									class2.double_0 = 5.0;
								}
							}
							if (delegate16 == null)
							{
								delegate16 = new Class68.Delegate32(class2.method_14);
							}
							return delegate16;
						}
					}
					else if (string.IsNullOrEmpty(text2))
					{
						if (delegate12 == null)
						{
							delegate12 = new Class68.Delegate32(class2.method_10);
						}
						return delegate12;
					}
				}
			}
			if (int.TryParse(class.string_0, out class.int_0))
			{
				if (delegate == null)
				{
					delegate = new Class68.Delegate32(class.method_0);
				}
				return delegate;
			}
			return new Class68.Delegate32(class.method_1);
		}

		// Token: 0x0600205E RID: 8286
		// RVA: 0x0001A541 File Offset: 0x00018741
		[CompilerGenerated]
		private static void smethod_10(object sender, EventArgs e)
		{
			Class466.Current.method_54();
		}

		// Token: 0x0600205F RID: 8287
		// RVA: 0x0001A54D File Offset: 0x0001874D
		[CompilerGenerated]
		private static void smethod_11(object sender, EventArgs e)
		{
			Class466.Current.method_55();
		}

		// Token: 0x06002060 RID: 8288
		// RVA: 0x0001A559 File Offset: 0x00018759
		[CompilerGenerated]
		private static void smethod_12(object sender, EventArgs e)
		{
			Class466.Current.method_56();
		}

		// Token: 0x06002063 RID: 8291
		// RVA: 0x00019C70 File Offset: 0x00017E70
		[CompilerGenerated]
		private static bool smethod_13(Class296 class296_2)
		{
			return class296_2.string_4 == Class466.Current.string_4;
		}

		// Token: 0x06002064 RID: 8292
		// RVA: 0x000BCC20 File Offset: 0x000BAE20
		[CompilerGenerated]
		private static void smethod_14(Class530 class530_0)
		{
			if (class530_0.vector2_1.Y > (float)(Class115.int_19 / 2))
			{
				class530_0.method_23(new Vector2(0f, 110f), 800, Enum70.const_1);
				return;
			}
			class530_0.method_23(new Vector2(0f, -110f), 800, Enum70.const_1);
		}

		// Token: 0x06002065 RID: 8293
		// RVA: 0x0001A594 File Offset: 0x00018794
		[CompilerGenerated]
		private static void smethod_15(Class530 class530_0)
		{
			class530_0.method_16(500, Enum70.const_0);
		}

		// Token: 0x06002066 RID: 8294
		// RVA: 0x0001A5A2 File Offset: 0x000187A2
		[CompilerGenerated]
		private static void smethod_16(Class530 class530_0)
		{
			class530_0.method_16(500, Enum70.const_0);
			class530_0.bool_1 = false;
		}

		// Token: 0x06002068 RID: 8296
		// RVA: 0x0001A5D9 File Offset: 0x000187D9
		[CompilerGenerated]
		private static bool smethod_17(Class512 class512_0)
		{
			return class512_0.string_2 == Class466.Current.class512_0.string_2;
		}

		// Token: 0x06002069 RID: 8297
		// RVA: 0x0001A5F5 File Offset: 0x000187F5
		[CompilerGenerated]
		private static bool smethod_18(Class512 class512_0)
		{
			return class512_0.string_2 == Class115.class861_0.Name;
		}

		// Token: 0x0600206A RID: 8298
		// RVA: 0x0001A60C File Offset: 0x0001880C
		[CompilerGenerated]
		private static void smethod_19(Class530 class530_0)
		{
			class530_0.method_5(new RectangleF?(new RectangleF(0f, 92f, 640f, 267f)));
		}

		// Token: 0x0600203E RID: 8254
		// RVA: 0x000BA614 File Offset: 0x000B8814
		private static bool smethod_2<T>(T gparam_0, string string_4, T gparam_1) where T : IComparable<T>
		{
			int num = gparam_0.CompareTo(gparam_1);
			switch (string_4)
			{
			case "<":
				return num < 0;
			case ">":
				return num > 0;
			case "==":
				return num == 0;
			case ">=":
				return num >= 0;
			case "<=":
				return num <= 0;
			case "!=":
				return num != 0;
			}
			return false;
		}

		// Token: 0x0600206B RID: 8299
		// RVA: 0x0001A632 File Offset: 0x00018832
		[CompilerGenerated]
		private static void smethod_20(Class531 class531_19)
		{
			class531_19.bool_1 = false;
			class531_19.class746_1 = null;
			class531_19.float_0 -= 0.01f;
			class531_19.method_16(500, Enum70.const_0);
			class531_19.bool_0 = false;
		}

		// Token: 0x0600203F RID: 8255
		// RVA: 0x000BA6F0 File Offset: 0x000B88F0
		private static bool smethod_3(Class296 class296_2, string string_4)
		{
			return class296_2.string_6.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0 || class296_2.string_5.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0 || class296_2.Tags.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0 || class296_2.string_13.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0 || (class296_2.ArtistUnicode != null && class296_2.ArtistUnicode.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0) || (class296_2.TitleUnicode != null && class296_2.TitleUnicode.IndexOf(string_4, StringComparison.CurrentCultureIgnoreCase) >= 0);
		}

		// Token: 0x06002040 RID: 8256
		// RVA: 0x000BA77C File Offset: 0x000B897C
		private static double smethod_4(string string_4, KeyValuePair<double, string>[] keyValuePair_2)
		{
			if (string_4.Length == 0)
			{
				return double.NaN;
			}
			for (int i = 0; i < keyValuePair_2.Length; i++)
			{
				KeyValuePair<double, string> keyValuePair = keyValuePair_2[i];
				if (keyValuePair.Value.StartsWith(string_4))
				{
					return keyValuePair.Key;
				}
			}
			return double.NaN;
		}

		// Token: 0x06002052 RID: 8274
		// RVA: 0x000BCA44 File Offset: 0x000BAC44
		[CompilerGenerated]
		private static void smethod_5(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x06002054 RID: 8276
		// RVA: 0x000BCA44 File Offset: 0x000BAC44
		[CompilerGenerated]
		private static void smethod_6(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x0600205A RID: 8282
		// RVA: 0x0001A52B File Offset: 0x0001872B
		[CompilerGenerated]
		private static void smethod_7(Class531 class531_19)
		{
			class531_19.float_4 = -999f;
		}

		// Token: 0x0600205B RID: 8283
		// RVA: 0x000BCBA8 File Offset: 0x000BADA8
		[CompilerGenerated]
		private static void smethod_8(Class530 class530_0)
		{
			Class531 class = class530_0 as Class531;
			if (class != null && class.vmethod_6() != null)
			{
				class.vmethod_6().bool_4 = false;
			}
		}

		// Token: 0x0600205C RID: 8284
		// RVA: 0x0001A52B File Offset: 0x0001872B
		[CompilerGenerated]
		private static void smethod_9(Class531 class531_19)
		{
			class531_19.float_4 = -999f;
		}
	}
}
