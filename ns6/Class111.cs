using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns16;
using ns18;
using ns19;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns40;
using ns5;
using ns64;
using ns69;
using ns7;
using ns76;
using ns77;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using ns93;
using osu;
using osu.GameModes.Edit;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ns6
{
	// Token: 0x02000623 RID: 1571
	internal sealed class Class111 : Class54
	{
		// Token: 0x02000624 RID: 1572
		[CompilerGenerated]
		private sealed class Class821
		{
			// Token: 0x04002CC2 RID: 11458
			public Class21 class21_0;

			// Token: 0x06003111 RID: 12561
			// RVA: 0x00024421 File Offset: 0x00022621
			public bool method_0(Class21 class21_1)
			{
				return class21_1.string_0 == this.class21_0.string_0;
			}
		}

		// Token: 0x02000625 RID: 1573
		[CompilerGenerated]
		private sealed class Class822
		{
			// Token: 0x04002CC3 RID: 11459
			public string string_0;

			// Token: 0x06003113 RID: 12563
			// RVA: 0x00024439 File Offset: 0x00022639
			public bool method_0(Class21 class21_0)
			{
				return class21_0.string_0 == this.string_0;
			}
		}

		// Token: 0x02000626 RID: 1574
		[CompilerGenerated]
		private sealed class Class823
		{
			// Token: 0x04002CC4 RID: 11460
			public string string_0;

			// Token: 0x06003115 RID: 12565
			// RVA: 0x0002444C File Offset: 0x0002264C
			public bool method_0(Class861 class861_0)
			{
				return class861_0.string_4.StartsWith(this.string_0, StringComparison.InvariantCultureIgnoreCase) && class861_0.bool_10;
			}
		}

		// Token: 0x02000627 RID: 1575
		[CompilerGenerated]
		private sealed class Class824
		{
			// Token: 0x02000628 RID: 1576
			private sealed class Class825
			{
				// Token: 0x04002CCD RID: 11469
				public Class21 class21_0;

				// Token: 0x04002CC9 RID: 11465
				public Class111.Class824 class824_0;

				// Token: 0x04002CCC RID: 11468
				public Class861 class861_0;

				// Token: 0x04002CCA RID: 11466
				public string string_0;

				// Token: 0x04002CCB RID: 11467
				public string string_1;

				// Token: 0x0600311A RID: 12570
				// RVA: 0x0002446A File Offset: 0x0002266A
				public bool method_0(Class21 class21_1)
				{
					return class21_1.string_0 == (this.class824_0.bool_0 ? this.string_0 : this.string_1);
				}

				// Token: 0x0600311B RID: 12571
				// RVA: 0x00024492 File Offset: 0x00022692
				public bool method_1(Class21 class21_1)
				{
					return class21_1.string_0 == this.string_0;
				}

				// Token: 0x0600311C RID: 12572
				// RVA: 0x000244A5 File Offset: 0x000226A5
				public void method_2()
				{
					if (this.class861_0 != null)
					{
						Class111.smethod_49(this.class861_0);
						if (!Class111.bool_2)
						{
							Class111.smethod_21(false);
						}
					}
				}

				// Token: 0x0600311D RID: 12573
				// RVA: 0x000244C7 File Offset: 0x000226C7
				public void method_3()
				{
					if (this.class21_0 != null)
					{
						Class111.class594_0.method_2(this.class21_0);
						if (!Class111.bool_2)
						{
							Class111.smethod_21(false);
						}
					}
				}
			}

			// Token: 0x02000629 RID: 1577
			private sealed class Class826
			{
				// Token: 0x04002CCE RID: 11470
				public Class39 class39_0;

				// Token: 0x0600311F RID: 12575
				// RVA: 0x000244EF File Offset: 0x000226EF
				public bool method_0(Class21 class21_0)
				{
					return class21_0.string_0 == this.class39_0.string_0.Substring(11);
				}
			}

			// Token: 0x04002CC6 RID: 11462
			public bool bool_0;

			// Token: 0x04002CC7 RID: 11463
			public bool bool_1;

			// Token: 0x04002CC5 RID: 11461
			public Class11 class11_0;

			// Token: 0x04002CC8 RID: 11464
			private static Predicate<Class39> predicate_0;

			// Token: 0x06003117 RID: 12567
			// RVA: 0x00141AE0 File Offset: 0x0013FCE0
			public void method_0()
			{
				Predicate<Class21> predicate = null;
				VoidDelegate voidDelegate = null;
				VoidDelegate voidDelegate2 = null;
				Class111.Class824.Class825 class = new Class111.Class824.Class825();
				class.class824_0 = this;
				class.string_0 = this.class11_0.string_1;
				class.string_1 = (this.bool_0 ? Class115.class861_0.Name : this.class11_0.object_0.ToString());
				string text = this.class11_0.string_0;
				string text2 = class.string_1;
				if (text.Length == 0)
				{
					return;
				}
				if (Class341.class606_9)
				{
					text = Class836.smethod_0(text);
				}
				if (Class341.class606_11)
				{
					int num = 0;
					for (int i = 0; i < text.Length; i++)
					{
						if (text[i] > '~')
						{
							text = text.Replace(text[i], ' ');
							num++;
						}
					}
					if (num > text.Length / 2)
					{
						return;
					}
				}
				bool flag = false;
				if (class.string_0 == "#spectator" && !Class341.class606_55 && Class858.class861_0 == null)
				{
					return;
				}
				class.class861_0 = null;
				if (!this.bool_0)
				{
					class.class861_0 = Class809.smethod_28(this.class11_0.int_0, true);
					if (!this.class11_0.method_0() && Class111.list_9.Contains(class.string_1.ToLower().Replace(' ', '_')))
					{
						return;
					}
					if (this.class11_0.method_0() && Class111.list_11.Contains(class.string_1.ToLower().Replace(' ', '_')))
					{
						return;
					}
				}
				class.class21_0 = null;
				if (this.class11_0.method_0())
				{
					Class111.Class824.Class825 arg_1B5_0 = class;
					List<Class21> arg_1B0_0 = Class111.list_1;
					if (predicate == null)
					{
						predicate = new Predicate<Class21>(class.method_0);
					}
					arg_1B5_0.class21_0 = arg_1B0_0.Find(predicate);
					if (class.class21_0 == null)
					{
						class.class21_0 = Class111.smethod_8(class.string_1, true, false);
						class.class21_0.method_0(true);
					}
				}
				else
				{
					class.class21_0 = Class111.list_1.Find(new Predicate<Class21>(class.method_1));
				}
				if (class.class21_0 == null)
				{
					return;
				}
				Class111.class594_0.method_6(class.class21_0);
				if (this.class11_0.method_0() && class.string_1 == "BanchoBot")
				{
					Class111.smethod_40(class.class21_0);
				}
				if (text.StartsWith('\u0001' + "ACTION ") && text.Length >= 8)
				{
					text = text.Substring(8).Trim(new char[]
					{
						'\u0001'
					});
					text2 = "*" + text2;
					flag = true;
				}
				else
				{
					if (text.IndexOf('\u0001') >= 0 || text.IndexOf('/') == 0)
					{
						return;
					}
					text2 += ":";
				}
				Class40 class2;
				try
				{
					class2 = Class36.smethod_2(text, 0, Class111.int_15);
					List<Class39> arg_2F2_0 = class2.list_0;
					if (Class111.Class824.predicate_0 == null)
					{
						Class111.Class824.predicate_0 = new Predicate<Class39>(Class111.Class824.smethod_0);
					}
					arg_2F2_0.RemoveAll(Class111.Class824.predicate_0);
				}
				catch
				{
					class2 = new Class40(string.Empty);
				}
				text = class2.string_0;
				List<Class841> list_ = class.class21_0.list_0;
				text2 = DateTime.Now.ToString("HH:mm") + ' ' + text2;
				if (this.class11_0.method_0() && !this.bool_0)
				{
					if (!Class111.bool_2)
					{
						string arg_391_0 = string.Format(Class41.GetString(OsuString.ChatEngine_PrivateMessageReceived), class.string_1);
						Color arg_391_1 = Color.get_DarkOrchid();
						int arg_391_2 = 6000;
						if (voidDelegate == null)
						{
							voidDelegate = new VoidDelegate(class.method_2);
						}
						Class723.smethod_5(arg_391_0, arg_391_1, arg_391_2, voidDelegate);
					}
					if (!Class114.bool_0 || Class115.bool_11)
					{
						Class115.smethod_84();
					}
					Class111.string_1 = this.class11_0.object_0.ToString();
				}
				Color color_;
				if (!(class.string_1 == Class115.class861_0.Name) && !(class.string_1 == Class115.class861_0.string_4))
				{
					if (this.bool_1 && class.string_0 != "#highlight" && !this.class11_0.method_0() && !this.bool_0 && !Class111.list_10.Contains(class.string_1.ToLower().Replace(' ', '_')) && Class111.smethod_26(text))
					{
						color_ = Color.get_YellowGreen();
						if (Class341.class606_10)
						{
							if (!Class111.bool_2)
							{
								string arg_4B2_0 = string.Format(Class41.GetString(OsuString.ChatEngine_Mention), this.class11_0.object_0);
								Color arg_4B2_1 = Color.get_DarkOrchid();
								int arg_4B2_2 = 6000;
								if (voidDelegate2 == null)
								{
									voidDelegate2 = new VoidDelegate(class.method_3);
								}
								Class723.smethod_5(arg_4B2_0, arg_4B2_1, arg_4B2_2, voidDelegate2);
							}
							if (!Class114.bool_0 || Class115.bool_11)
							{
								Class115.smethod_84();
							}
						}
						Class21 class3 = Class111.smethod_8("#highlight", true, false);
						class3.method_0(true);
						Class111.class594_0.method_6(class3);
						Class111.smethod_24(new Class11(this.class11_0.object_0, "#highlight", class.string_0 + " " + text)
						{
							int_0 = this.class11_0.int_0
						}, false, true);
					}
					else if (class.string_1 == "BanchoBot")
					{
						color_..ctor(250, 129, 198);
					}
					else if (flag)
					{
						color_ = Color.get_White();
					}
					else if (this.class11_0.method_0())
					{
						color_..ctor(89, 116, 255);
					}
					else if (class.class861_0 == null)
					{
						color_..ctor(255, 240, 154);
					}
					else if ((class.class861_0.enum30_0 & Enum30.flag_5) > Enum30.flag_0)
					{
						color_..ctor(116, 208, 255);
					}
					else if ((class.class861_0.enum30_0 & Enum30.flag_2) > Enum30.flag_0)
					{
						color_ = Color.get_OrangeRed();
					}
					else if ((class.class861_0.enum30_0 & Enum30.flag_4) > Enum30.flag_0)
					{
						color_..ctor(183, 232, 255);
					}
					else if ((class.class861_0.enum30_0 & Enum30.flag_3) > Enum30.flag_0)
					{
						color_..ctor(255, 223, 46);
					}
					else
					{
						color_..ctor(255, 240, 154);
					}
				}
				else
				{
					color_ = Color.get_White();
				}
				Class841 item = new Class841(class.class861_0, text2, text, color_)
				{
					class40_0 = class2
				};
				list_.Add(item);
				if (Class341.class606_41 && class.string_1 != "BanchoBot" && this.class11_0.method_0() && !this.bool_0)
				{
					Class111.smethod_53(class.string_1, this.class11_0.string_0, false);
				}
			}

			// Token: 0x06003118 RID: 12568
			// RVA: 0x001421E0 File Offset: 0x001403E0
			private static bool smethod_0(Class39 class39_0)
			{
				Class111.Class824.Class826 class = new Class111.Class824.Class826();
				class.class39_0 = class39_0;
				return class.class39_0.string_0.StartsWith("osu://chan/") && Class111.list_1.Find(new Predicate<Class21>(class.method_0)) == null;
			}
		}

		// Token: 0x0200062A RID: 1578
		[CompilerGenerated]
		private sealed class Class827
		{
			// Token: 0x04002CCF RID: 11471
			public List<Class861> list_0;

			// Token: 0x06003121 RID: 12577
			// RVA: 0x0002450E File Offset: 0x0002270E
			public void method_0()
			{
				Class111.smethod_36(this.list_0, false);
			}
		}

		// Token: 0x0200062B RID: 1579
		[CompilerGenerated]
		private sealed class Class828
		{
			// Token: 0x04002CD0 RID: 11472
			public string string_0;
		}

		// Token: 0x0200062C RID: 1580
		[CompilerGenerated]
		private sealed class Class829
		{
			// Token: 0x04002CD3 RID: 11475
			public bool bool_0;

			// Token: 0x04002CD2 RID: 11474
			public Class40 class40_0;

			// Token: 0x04002CD1 RID: 11473
			public Class111.Class828 class828_0;

			// Token: 0x06003124 RID: 12580
			// RVA: 0x0014222C File Offset: 0x0014042C
			public void method_0(Class39 class39_0)
			{
				if (class39_0.string_0.IndexOf('\ud83d') == 0 && class39_0.string_0.Length == 2)
				{
					if (!this.bool_0)
					{
						this.bool_0 = true;
						this.class828_0.string_0 = this.class40_0.string_0;
						Class111.class533_0.Text = ">" + this.class828_0.string_0;
					}
					Vector2 vector;
					vector..ctor(Class111.class533_0.method_66(0, class39_0.int_0 + 1).X - 2f, 0f);
					string str = ((int)class39_0.string_0[1]).ToString();
					Class531 class = new Class531(Class885.Load("emoji-" + str, Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, Class111.class533_0.vector2_1 + vector, 0.975f, true, Color.get_White(), null);
					Class111.list_8.Add(class);
					Class111.list_13.Add(class);
					Class111.class911_0.Add(class);
				}
			}
		}

		// Token: 0x0200062D RID: 1581
		[CompilerGenerated]
		private sealed class Class830
		{
			// Token: 0x04002CD4 RID: 11476
			public Class861 class861_0;

			// Token: 0x06003126 RID: 12582
			// RVA: 0x0002451C File Offset: 0x0002271C
			public void method_0()
			{
				if (this.class861_0 != null)
				{
					Class111.smethod_49(this.class861_0);
					if (!Class111.bool_2)
					{
						Class111.smethod_21(false);
					}
				}
			}
		}

		// Token: 0x0200062E RID: 1582
		[CompilerGenerated]
		private sealed class Class831
		{
			// Token: 0x04002CD5 RID: 11477
			public string string_0;

			// Token: 0x06003128 RID: 12584
			// RVA: 0x0002453E File Offset: 0x0002273E
			public void method_0(object sender, EventArgs e)
			{
				Class115.smethod_90(this.string_0, null);
			}

			// Token: 0x06003129 RID: 12585
			// RVA: 0x0002453E File Offset: 0x0002273E
			public void method_1(object sender, EventArgs e)
			{
				Class115.smethod_90(this.string_0, null);
			}
		}

		// Token: 0x0200062F RID: 1583
		[CompilerGenerated]
		private sealed class Class832
		{
			// Token: 0x04002CD6 RID: 11478
			public string string_0;

			// Token: 0x0600312B RID: 12587
			// RVA: 0x0002454C File Offset: 0x0002274C
			public bool method_0(Class21 class21_0)
			{
				return class21_0.string_0 == this.string_0;
			}
		}

		// Token: 0x02000630 RID: 1584
		[CompilerGenerated]
		private sealed class Class833
		{
			// Token: 0x04002CD7 RID: 11479
			public string string_0;

			// Token: 0x0600312D RID: 12589
			// RVA: 0x0002455F File Offset: 0x0002275F
			public void method_0()
			{
				Class115.smethod_90(this.string_0, null);
			}
		}

		// Token: 0x02000631 RID: 1585
		[CompilerGenerated]
		private sealed class Class834
		{
			// Token: 0x04002CD8 RID: 11480
			public string string_0;

			// Token: 0x0600312F RID: 12591
			// RVA: 0x0002456D File Offset: 0x0002276D
			public bool method_0(Class750 class750_0)
			{
				return class750_0.class533_0.Text == this.string_0;
			}
		}

		// Token: 0x02000632 RID: 1586
		[CompilerGenerated]
		private sealed class Class835
		{
			// Token: 0x04002CD9 RID: 11481
			public int int_0;

			// Token: 0x06003131 RID: 12593
			// RVA: 0x00024585 File Offset: 0x00022785
			public bool method_0(Class841 class841_0)
			{
				return class841_0.class861_0 != null && class841_0.class861_0.int_1 == this.int_0;
			}
		}

		// Token: 0x04002CB3 RID: 11443
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002CB4 RID: 11444
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x04002CBA RID: 11450
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04002CBB RID: 11451
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04002CBC RID: 11452
		[CompilerGenerated]
		private static Action<Class531> action_4;

		// Token: 0x04002CBD RID: 11453
		[CompilerGenerated]
		private static Action<Class531> action_5;

		// Token: 0x04002C6F RID: 11375
		internal static bool bool_1;

		// Token: 0x04002C70 RID: 11376
		internal static bool bool_2;

		// Token: 0x04002C87 RID: 11399
		private bool bool_3;

		// Token: 0x04002C91 RID: 11409
		private static bool bool_4;

		// Token: 0x04002C9F RID: 11423
		internal static bool bool_5;

		// Token: 0x04002CA0 RID: 11424
		internal static bool bool_6 = false;

		// Token: 0x04002CA1 RID: 11425
		private static bool[] bool_7 = new bool[]
		{
			true,
			true,
			true,
			true
		};

		// Token: 0x04002CA4 RID: 11428
		private bool bool_8;

		// Token: 0x04002C73 RID: 11379
		private static Class110 class110_0;

		// Token: 0x04002C7D RID: 11389
		internal static Class110 class110_1;

		// Token: 0x04002C60 RID: 11360
		internal static Class21 class21_0;

		// Token: 0x04002C62 RID: 11362
		private static Class531 class531_0;

		// Token: 0x04002C63 RID: 11363
		private static Class531 class531_1;

		// Token: 0x04002CAE RID: 11438
		private static Class531 class531_10;

		// Token: 0x04002CAF RID: 11439
		private static Class531 class531_11;

		// Token: 0x04002CB0 RID: 11440
		private static Class531 class531_12;

		// Token: 0x04002C64 RID: 11364
		private static Class531 class531_2;

		// Token: 0x04002C7E RID: 11390
		private static Class531 class531_3;

		// Token: 0x04002C7F RID: 11391
		private static Class531 class531_4;

		// Token: 0x04002C80 RID: 11392
		internal static Class531 class531_5;

		// Token: 0x04002C82 RID: 11394
		private readonly Class531 class531_6;

		// Token: 0x04002C86 RID: 11398
		private static Class531 class531_7;

		// Token: 0x04002CAB RID: 11435
		private static Class531 class531_8;

		// Token: 0x04002CAD RID: 11437
		private static Class531 class531_9;

		// Token: 0x04002C7A RID: 11386
		internal static Class533 class533_0;

		// Token: 0x04002C7C RID: 11388
		internal static Class533 class533_1;

		// Token: 0x04002C81 RID: 11393
		private readonly Class533 class533_2;

		// Token: 0x04002C83 RID: 11395
		private readonly Class592 class592_0;

		// Token: 0x04002C66 RID: 11366
		internal static Class594 class594_0;

		// Token: 0x04002C9A RID: 11418
		private Class753 class753_0;

		// Token: 0x04002CAA RID: 11434
		private Class754 class754_0;

		// Token: 0x04002C90 RID: 11408
		private readonly Class762 class762_0;

		// Token: 0x04002C99 RID: 11417
		private static Class796 class796_0;

		// Token: 0x04002C76 RID: 11382
		private static Class841 class841_0;

		// Token: 0x04002C92 RID: 11410
		private static Class87 class87_0;

		// Token: 0x04002C7B RID: 11387
		internal static Class911 class911_0;

		// Token: 0x04002C93 RID: 11411
		private static Class911 class911_1;

		// Token: 0x04002C8B RID: 11403
		private Comparison<Class861> comparison_0;

		// Token: 0x04002CB5 RID: 11445
		[CompilerGenerated]
		private static Comparison<Class861> comparison_1;

		// Token: 0x04002CB6 RID: 11446
		[CompilerGenerated]
		private static Comparison<Class861> comparison_2;

		// Token: 0x04002CB7 RID: 11447
		[CompilerGenerated]
		private static Comparison<Class861> comparison_3;

		// Token: 0x04002CB8 RID: 11448
		[CompilerGenerated]
		private static Comparison<Class861> comparison_4;

		// Token: 0x04002CB2 RID: 11442
		[CompilerGenerated]
		private static Class754.Delegate37 delegate37_0;

		// Token: 0x04002C67 RID: 11367
		private static Enum102 enum102_0;

		// Token: 0x04002CA7 RID: 11431
		private Enum31 enum31_0;

		// Token: 0x04002CC0 RID: 11456
		[CompilerGenerated]
		private static EventHandler eventHandler_2;

		// Token: 0x04002CC1 RID: 11457
		[CompilerGenerated]
		private static EventHandler eventHandler_3;

		// Token: 0x04002C5F RID: 11359
		internal static readonly int int_1 = 80;

		// Token: 0x04002C8C RID: 11404
		private int int_10;

		// Token: 0x04002C8D RID: 11405
		private int int_11;

		// Token: 0x04002C8F RID: 11407
		private static int int_12;

		// Token: 0x04002C98 RID: 11416
		internal static readonly int int_13 = Class115.bool_16 ? 96 : 160;

		// Token: 0x04002C9D RID: 11421
		private static int[] int_14 = new int[]
		{
			56397,
			56398,
			56444,
			56832,
			56835,
			56838,
			56840,
			56842,
			56845,
			56846,
			56847,
			56849,
			56854,
			56855,
			56859,
			56864,
			56865,
			56869,
			56876,
			56877,
			56878,
			56879
		};

		// Token: 0x04002C9E RID: 11422
		private static int int_15 = 2;

		// Token: 0x04002CA3 RID: 11427
		private int int_16;

		// Token: 0x04002CA6 RID: 11430
		private static int int_17;

		// Token: 0x04002CAC RID: 11436
		private static int int_18;

		// Token: 0x04002CB1 RID: 11441
		private static int int_19 = 1000;

		// Token: 0x04002C68 RID: 11368
		private static int int_2;

		// Token: 0x04002C6B RID: 11371
		private static int int_3;

		// Token: 0x04002C6C RID: 11372
		private static int int_4;

		// Token: 0x04002C6E RID: 11374
		private static int int_5;

		// Token: 0x04002C71 RID: 11377
		private static int int_6;

		// Token: 0x04002C74 RID: 11380
		private static int int_7;

		// Token: 0x04002C89 RID: 11401
		private int int_8;

		// Token: 0x04002C8A RID: 11402
		private int int_9;

		// Token: 0x04002C61 RID: 11361
		internal static List<Class841> list_0;

		// Token: 0x04002C65 RID: 11365
		internal static List<Class21> list_1 = new List<Class21>();

		// Token: 0x04002C96 RID: 11414
		private static readonly List<string> list_10 = new List<string>();

		// Token: 0x04002C97 RID: 11415
		private static readonly List<string> list_11 = new List<string>();

		// Token: 0x04002C9B RID: 11419
		private static List<Class531> list_12 = new List<Class531>();

		// Token: 0x04002C9C RID: 11420
		private static List<Class531> list_13 = new List<Class531>();

		// Token: 0x04002CA5 RID: 11429
		private List<Class861> list_14 = new List<Class861>();

		// Token: 0x04002CA9 RID: 11433
		internal static readonly List<string> list_15 = new List<string>();

		// Token: 0x04002C69 RID: 11369
		private static List<string> list_2 = new List<string>();

		// Token: 0x04002C6A RID: 11370
		private static List<string> list_3 = new List<string>();

		// Token: 0x04002C6D RID: 11373
		internal static List<int> list_4 = new List<int>();

		// Token: 0x04002C78 RID: 11384
		internal static List<string> list_5 = new List<string>();

		// Token: 0x04002C79 RID: 11385
		internal static List<string> list_6 = new List<string>();

		// Token: 0x04002C8E RID: 11406
		private static readonly List<string> list_7 = new List<string>();

		// Token: 0x04002C94 RID: 11412
		private static List<Class531> list_8 = new List<Class531>();

		// Token: 0x04002C95 RID: 11413
		private static readonly List<string> list_9 = new List<string>();

		// Token: 0x04002CBE RID: 11454
		[CompilerGenerated]
		private static Predicate<Class861> predicate_0;

		// Token: 0x04002CA2 RID: 11426
		private static Queue<VoidDelegate> queue_0 = new Queue<VoidDelegate>();

		// Token: 0x04002C72 RID: 11378
		internal static string string_0;

		// Token: 0x04002C75 RID: 11381
		private static string string_1;

		// Token: 0x04002C77 RID: 11383
		private static string string_2;

		// Token: 0x04002C88 RID: 11400
		private string string_3;

		// Token: 0x04002CA8 RID: 11432
		internal static string[] string_4;

		// Token: 0x04002C84 RID: 11396
		private readonly Vector2 vector2_0 = new Vector2(0f, 447f);

		// Token: 0x04002C85 RID: 11397
		private readonly Vector2 vector2_1 = new Vector2(0f, 467f);

		// Token: 0x04002CB9 RID: 11449
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04002CBF RID: 11455
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x060030A3 RID: 12451
		// RVA: 0x0013AD68 File Offset: 0x00138F68
		internal Class111(Class114 class114_1) : base(class114_1)
		{
			Class111.class87_0 = new Class87(class114_1);
			Class111.class911_0 = Class115.class911_2;
			Class111.class911_0.Add(Class802.class755_0.class533_1);
			Class111.class110_1 = new Class110(new Rectangle(10, 60, Class115.smethod_43() - 15, 259), new Vector2(630f, 600f), true, 0f, Enum98.const_4);
			Class111.class110_1.method_7(new VoidDelegate(this.method_4));
			Class111.class110_1.class911_0.bool_1 = false;
			Class111.class110_1.class911_0.bool_14 = true;
			Class111.class110_1.method_19();
			Class111.class911_1 = new Class911(true)
			{
				bool_14 = true
			};
			this.class592_0 = new Class592(Class115.class911_2, 7, new Vector2(50f, 60f), 0.98f, false, Color.get_Crimson(), 0, false);
			this.class592_0.Add(Class41.GetString(OsuString.ChatEngine_SortName), 0, false);
			this.class592_0.Add(Class41.GetString(OsuString.ChatEngine_SortRank), 1, false);
			this.class592_0.Add(Class41.GetString(OsuString.ChatEngine_SortLocation), 2, false);
			this.class592_0.Add(Class41.GetString(OsuString.ChatEngine_SortTimeZone), 4, false);
			this.class592_0.Add(Class41.GetString(OsuString.ChatEngine_SortWorldMap), 3, false);
			this.class592_0.method_0(new EventHandler(this.method_9));
			Class533 class = new Class533(Class41.GetString(OsuString.ChatEngine_Filter), 12f, new Vector2(220f, 5f), 0.97f, true, Color.get_White());
			class.origins_0 = Origins.TopRight;
			class.object_0 = "user";
			class.float_3 = 0f;
			Class111.class911_0.Add(class);
			this.class753_0 = new Class753(Class111.class911_1, string.Empty, new Vector2(220f, 5f), 98f, 0.995f);
			this.class753_0.method_11(Class41.GetString(OsuString.User_Filter_All), Enum103.const_0, 0, Color.get_Black(), true);
			this.class753_0.method_11(Class41.GetString(OsuString.User_Filter_Friends), Enum103.const_1, 1, Color.get_Black(), true);
			this.class753_0.method_11(Class41.GetString(OsuString.User_Filter_Near), Enum103.const_3, 3, Color.get_Black(), true);
			this.class753_0.method_11(Class41.GetString(OsuString.User_Filter_Country), Enum103.const_2, 2, Color.get_Black(), true);
			this.class753_0.method_18(Class341.class605_21.Value, true);
			this.class753_0.method_0(new EventHandler(this.method_2));
			this.class762_0 = new Class762(Class41.GetString(OsuString.ChatEngine_LockPanels), 0.8f, new Vector2(330f, 5f), 0.98f, false, 0f);
			this.class762_0.method_8(new Delegate38(this.method_7));
			Class111.class911_0.Add<Class531>(this.class762_0.list_0);
			foreach (Class531 current in this.class762_0.list_0)
			{
				current.float_3 = 0f;
				current.string_0 = Class41.GetString(OsuString.ChatEngine_LockPanels_Tooltip);
				current.object_0 = "user";
			}
			class = new Class533(Class41.GetString(OsuString.SongSelection_Search), 12f, new Vector2(220f, 25f), 0.97f, true, Color.get_White());
			class.origins_0 = Origins.TopRight;
			class.object_0 = "user";
			class.float_3 = 0f;
			Class111.class911_0.Add(class);
			this.class754_0 = new Class754(string.Empty, 12, new Vector2(220f, 25f), 100f, 0.98f, false);
			this.class754_0.int_0 = 14;
			Class754 arg_476_0 = this.class754_0;
			if (Class111.delegate37_0 == null)
			{
				Class111.delegate37_0 = new Class754.Delegate37(Class111.smethod_73);
			}
			arg_476_0.method_3(Class111.delegate37_0);
			List<Class531> arg_4A3_0 = this.class754_0.list_0;
			if (Class111.action_0 == null)
			{
				Class111.action_0 = new Action<Class531>(Class111.smethod_74);
			}
			arg_4A3_0.ForEach(Class111.action_0);
			Class111.class911_0.Add<Class531>(this.class754_0.list_0);
			Class111.class531_11 = new Class531(Class885.Load("mode-osu-small", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(340f, 32f))
			{
				bool_0 = true
			};
			Class111.class531_11.float_3 = 0f;
			Class111.class531_11.bool_1 = true;
			Class111.class531_11.method_35(new EventHandler(this.method_1));
			Class111.class531_11.method_2(new EventHandler(this.method_3));
			Class111.class531_11.object_0 = "user";
			Class111.class531_11.int_0 = 0;
			Class111.class531_10 = new Class531(Class885.Load("mode-taiko-small", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(370f, 32f))
			{
				bool_0 = true
			};
			Class111.class531_10.float_3 = 0f;
			Class111.class531_10.bool_1 = true;
			Class111.class531_10.method_35(new EventHandler(this.method_1));
			Class111.class531_10.method_2(new EventHandler(this.method_3));
			Class111.class531_10.object_0 = "user";
			Class111.class531_10.int_0 = 1;
			Class111.class531_9 = new Class531(Class885.Load("mode-fruits-small", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(400f, 32f))
			{
				bool_0 = true
			};
			Class111.class531_9.float_3 = 0f;
			Class111.class531_9.method_35(new EventHandler(this.method_1));
			Class111.class531_9.bool_1 = true;
			Class111.class531_9.method_2(new EventHandler(this.method_3));
			Class111.class531_9.object_0 = "user";
			Class111.class531_9.int_0 = 2;
			Class111.class531_12 = new Class531(Class885.Load("mode-mania-small", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(430f, 32f))
			{
				bool_0 = true
			};
			Class111.class531_12.float_3 = 0f;
			Class111.class531_12.method_35(new EventHandler(this.method_1));
			Class111.class531_12.bool_1 = true;
			Class111.class531_12.method_2(new EventHandler(this.method_3));
			Class111.class531_12.object_0 = "user";
			Class111.class531_12.int_0 = 3;
			Class111.class911_0.Add(Class111.class531_11);
			Class111.class911_0.Add(Class111.class531_10);
			Class111.class911_0.Add(Class111.class531_9);
			Class111.class911_0.Add(Class111.class531_12);
			if (this.class592_0.method_2((int)Class341.class605_22.Value) == null)
			{
				this.class592_0.method_2(1);
			}
			foreach (Class531 current2 in this.class592_0.list_0)
			{
				current2.float_3 = 0f;
				current2.object_0 = "user";
			}
			if (Class341.class606_9)
			{
				Class836.Initialize();
			}
			Class111.class594_0 = new Class594(Class111.class911_0, 8, new Vector2(46f, (float)(482 - Class111.int_13 + 12)), 0.97f, false, new Color(51, 71, 157));
			Class111.class594_0.method_0(new EventHandler(this.method_8));
			Class111.class594_0.method_11(new EventHandler(this.method_5));
			Class111.class594_0.method_10(new EventHandler(this.method_6));
			Class111.class21_0 = Class111.smethod_8("#osu", true, false);
			Class111.class594_0.method_2(Class111.class21_0);
			Class111.int_7 = (Class115.bool_16 ? 6 : 11);
			Class111.class533_0 = new Class533(string.Empty, 12f, new Vector2(3f, 465f), 0.97f, true, Color.get_White());
			Class111.list_8.Add(Class111.class533_0);
			Class111.class911_0.Add(Class111.class533_0);
			Class111.class533_0.float_3 = 0f;
			Class111.class533_0.Text = "aa";
			float x = Class111.class533_0.vmethod_11().X;
			Class111.class533_0.Text = "a\\0a";
			float x2 = Class111.class533_0.vmethod_11().X;
			Class111.int_15 = (int)Math.Ceiling(10.0 / (double)Math.Max(1f, x2 - x));
			Class111.class533_0.Text = string.Empty;
			Class111.class531_7 = new Class531(Class115.class731_0, new Vector2(0f, 320f), 0.961f, true, new Color(200, 200, 200, 50));
			Class111.list_8.Add(Class111.class531_7);
			Class111.class531_7.vector2_2 = new Vector2((float)Class115.int_22, 22f);
			Class111.class911_0.Add(Class111.class531_7);
			Class111.class531_7.float_3 = 0f;
			Class111.smethod_3();
			Class111.class531_5 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(11f, 466f), 0.974f, true, Color.get_White(), null);
			Class111.list_8.Add(Class111.class531_5);
			Class111.class531_5.vector2_2 = new Vector2(2f, 18f);
			Class111.class531_5.float_3 = 0f;
			Class111.class911_0.Add(Class111.class531_5);
			this.class531_6 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 320f), 0.974f, true, new Color(255, 255, 255, 100), null);
			Class111.list_8.Add(this.class531_6);
			this.class531_6.vector2_2 = new Vector2(0f, 32f);
			Class111.class911_0.Add(this.class531_6);
			Class111.class531_4 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, (float)(480 - Class111.int_13)), 0.96f, true, new Color(0, 0, 0, 210), null);
			Class111.list_8.Add(Class111.class531_4);
			Class111.class531_4.float_3 = 0f;
			Class111.class531_4.bool_1 = true;
			Class111.class531_4.vector2_2 = new Vector2((float)Class115.smethod_43(), (float)Class111.int_13) * 1.6f;
			Class111.class911_0.Add(Class111.class531_4);
			Class111.class110_0 = new Class110(Class111.smethod_1(), Vector2.get_Zero(), true, 0f, Enum98.const_4);
			Class111.class110_0.class911_0.bool_14 = true;
			Class111.class110_0.float_4 = 0.36f;
			Class111.class110_0.vector2_4.Y = 1f;
			Class111.class531_8 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.95f, true, new Color(0, 0, 0, 210), "user");
			Class111.class531_8.float_3 = 0f;
			Class111.class911_0.Add(Class111.class531_8);
			Class111.class531_8.int_0 = 12;
			Class111.class531_8.bool_1 = true;
			Class111.class531_8.vector2_2 = new Vector2((float)Class115.smethod_43(), 320f) * 1.6f;
			Class746 class746_ = new Class746(Color.get_White(), Color.get_Pink(), 0, 100);
			Class111.class531_0 = new Class531(Class885.Load("overlay-show", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(30f, 474f), 0.98f, true, Color.get_White(), null);
			Class111.class531_0.class746_1 = class746_;
			Class111.class531_0.int_0 = 14;
			Class111.class531_0.string_0 = Class41.GetString(OsuString.ChatEngine_ToggleChat_Tooltip);
			Class111.class531_0.bool_1 = true;
			Class111.class531_0.method_35(new EventHandler(this.method_1));
			Class111.class531_0.method_2(new EventHandler(Class111.smethod_16));
			Class111.class911_0.Add(Class111.class531_0);
			Class111.class531_3 = new Class531(Class885.Load("overlay-online", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(90f, 474f), 0.98f, true, Color.get_White(), null);
			Class111.class531_3.class746_1 = class746_;
			Class111.class531_3.int_0 = 12;
			Class111.class531_3.string_0 = Class41.GetString(OsuString.ChatEngine_ToggleOnlineUsers_Tooltip);
			Class111.class531_3.bool_1 = true;
			Class111.class531_3.method_35(new EventHandler(this.method_1));
			Class111.class531_3.method_2(new EventHandler(this.method_10));
			Class111.class911_0.Add(Class111.class531_3);
			class746_ = new Class746(Class341.class606_63 ? Color.get_White() : Color.get_Gray(), Class341.class606_63 ? Color.get_White() : Color.get_Pink(), 0, 100);
			Class111.class531_2 = new Class531(Class885.Load(Class341.class606_63 ? "overlay-ticker2" : "overlay-ticker", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(210f, 474f), 0.98f, true, Class341.class606_63 ? Color.get_White() : Color.get_Gray(), null);
			Class111.list_8.Add(Class111.class531_2);
			Class111.class531_2.float_3 = 0f;
			Class111.class531_2.class746_1 = class746_;
			Class111.class531_2.string_0 = Class41.GetString(OsuString.ChatEngine_Ticker_Tooltip);
			Class111.class531_2.int_0 = 12;
			Class111.class531_2.bool_1 = true;
			Class111.class531_2.method_35(new EventHandler(this.method_1));
			Class111.class531_2.method_2(new EventHandler(Class111.smethod_14));
			Class111.class911_0.Add(Class111.class531_2);
			class746_ = new Class746(Class341.class606_2 ? Color.get_White() : Color.get_Gray(), Class341.class606_2 ? Color.get_White() : Color.get_Pink(), 0, 100);
			Class111.class531_1 = new Class531(Class885.Load(Class341.class606_2 ? "overlay-hidemode2" : "overlay-hidemode", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(150f, 474f), 0.98f, true, Class341.class606_2 ? Color.get_White() : Color.get_Gray(), null);
			Class111.list_8.Add(Class111.class531_1);
			Class111.class531_1.float_3 = 0f;
			Class111.class531_1.class746_1 = class746_;
			Class111.class531_1.int_0 = 12;
			Class111.class531_1.string_0 = Class41.GetString(OsuString.ChatEngine_AutoHide_Tooltip);
			Class111.class531_1.bool_1 = true;
			Class111.class531_1.method_35(new EventHandler(this.method_1));
			Class111.class531_1.method_2(new EventHandler(Class111.smethod_13));
			Class111.class911_0.Add(Class111.class531_1);
			foreach (Class531 current3 in Class111.list_8)
			{
				current3.vector2_1 = current3.vector2_0 + new Vector2(0f, 80f);
			}
			this.class533_2 = new Class533("osu!Bancho", 30f, new Vector2(0f, 0f), 0.955f, true, new Color(255, 255, 255, 255));
			this.class533_2.object_0 = "user";
			this.class533_2.float_3 = 0f;
			this.class533_2.int_0 = 12;
			Class111.class911_0.Add(this.class533_2);
			this.class533_2 = new Class533(Class41.GetString(OsuString.BanchoClient_Connecting), 16f, new Vector2(4f, 26f), 0.955f, true, new Color(255, 255, 255, 255));
			this.class533_2.object_0 = "user";
			this.class533_2.float_3 = 0f;
			this.class533_2.int_0 = 12;
			Class111.class911_0.Add(this.class533_2);
			Class111.class533_1 = new Class533(string.Empty, 12f, this.vector2_1, 0.975f, true, Color.get_White());
			Class111.class533_1.vector2_9 = new Vector2((float)Class115.smethod_43(), 13.5f);
			Class111.class533_1.object_0 = "ticker";
			Class111.class533_1.enum72_0 = Enum72.const_1;
			Class111.class533_1.method_53(Color.get_Black());
			Class111.class533_1.float_3 = 0f;
			Class111.class911_0.Add(Class111.class533_1);
			Class111.class796_0 = new Class796(Class111.class911_0, new Vector2(2f, 466f), Class802.class799_0);
			Class111.class796_0.bool_0 = false;
			Class111.smethod_70();
			Class115.smethod_18(new VoidDelegate(Class111.smethod_70));
			Class111.bool_6 = true;
		}

		// Token: 0x060030FB RID: 12539
		// RVA: 0x0002434B File Offset: 0x0002254B
		protected override void Dispose(bool bool_9)
		{
			Class111.class110_0.Dispose();
			Class111.class110_1.Dispose();
			base.Dispose(bool_9);
		}

		// Token: 0x060030B7 RID: 12471
		// RVA: 0x0013C720 File Offset: 0x0013A920
		public void Draw()
		{
			if (Class115.bool_16 && !Class115.bool_17)
			{
				return;
			}
			Class111.class110_0.Draw();
			if (Class111.bool_1)
			{
				Class111.class110_1.method_16(new RectangleF(10f, 60f, (float)(Class115.smethod_43() - 15), (float)(259 - Class111.class594_0.method_15())));
			}
			Enum102 value = Class341.class605_22.Value;
			if (value == Enum102.const_3)
			{
				Class111.class87_0.class911_0.float_0 = this.class533_2.float_3;
				Class111.class110_1.class911_0.float_0 = 0f;
				Class111.class87_0.Draw();
			}
			else
			{
				Class111.class110_1.class911_0.float_0 = this.class533_2.float_3;
				Class111.class110_1.Draw();
			}
			Class111.class911_1.Draw();
			Class111.class911_1.float_0 = this.class533_2.float_3;
		}

		// Token: 0x060030CA RID: 12490
		// RVA: 0x0013D7A4 File Offset: 0x0013B9A4
		public override void imethod_2()
		{
			this.method_15();
			Class111.smethod_35();
			Enum102 value = Class341.class605_22.Value;
			if (value != Enum102.const_3)
			{
				Class111.class110_1.imethod_2();
			}
			else
			{
				Class111.class87_0.imethod_2();
			}
			this.method_17();
			Class111.smethod_30();
			Class111.class110_0.imethod_2();
			Class111.class110_0.method_16(Class111.smethod_1());
			Class111.class110_0.method_32(Class111.class531_4.float_3);
			this.method_14();
			if (Class111.bool_2 && Class115.int_1 - Class111.int_6 > 400)
			{
				this.method_11();
				Class111.class594_0.method_16();
			}
			this.method_12();
			this.method_18();
			base.imethod_2();
		}

		// Token: 0x060030A4 RID: 12452
		// RVA: 0x000BCA44 File Offset: 0x000BAC44
		private void method_1(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x060030B6 RID: 12470
		// RVA: 0x0013C6A8 File Offset: 0x0013A8A8
		private void method_10(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			if (Class111.bool_2 || (!Class111.bool_2 && !Class111.bool_1))
			{
				Class111.smethod_19();
			}
			if (!Class111.bool_2 && Class111.smethod_22())
			{
				Class47 arg_64_0 = Class115.class47_0;
				if (Class111.voidDelegate_0 == null)
				{
					Class111.voidDelegate_0 = new VoidDelegate(Class111.smethod_80);
				}
				arg_64_0.Add(Class111.voidDelegate_0, false);
			}
		}

		// Token: 0x060030CC RID: 12492
		// RVA: 0x0013D934 File Offset: 0x0013BB34
		private void method_11()
		{
			if (Class111.bool_1 && Class111.bool_2)
			{
				this.method_16((Class341.class605_21 == Enum103.const_1) ? Enum31.const_2 : Enum31.const_1);
				this.int_16 = Class115.int_1;
				bool flag = Class111.class110_1.int_1 > 0 && Class115.int_1 - Class111.class110_1.int_1 <= 10000;
				int num = (int)Math.Round((double)((float)Class115.smethod_43() / 205f));
				Class111.class110_1.class911_0.float_3 = ((num != 3) ? ((float)Class115.smethod_43() / (25f + (float)num * 205f)) : 1f);
				bool flag2 = !Class114.bool_0 || Class115.smethod_91() > 60000;
				if (Class115.int_1 - Class111.int_18 > Class111.int_19 * (flag2 ? 4 : 1) || Class111.int_18 == 0)
				{
					Class111.Class827 class = new Class111.Class827();
					Class111.int_18 = Class115.int_1;
					Class111.int_19 = Math.Max(500, Math.Min((int)((float)Class111.int_19 * 1.2f), 10000));
					this.bool_8 = false;
					if (!flag && !Class111.bool_4)
					{
						lock (Class809.list_1)
						{
							Class809.list_1.Sort(this.comparison_0);
						}
					}
					int num2 = 0;
					this.int_8 = 0;
					string text = this.class754_0.class533_0.Text.ToLower();
					bool flag3 = text.Length > 0;
					class.list_0 = new List<Class861>();
					bool flag4 = Class341.class605_21 == Enum103.const_1 || flag3;
					Class111.class531_11.method_8(flag4);
					Class111.class531_10.method_8(flag4);
					Class111.class531_9.method_8(flag4);
					Class111.class531_12.method_8(flag4);
					int num3 = 0;
					lock (Class809.list_1)
					{
						foreach (Class861 current in Class809.list_1)
						{
							if (current.int_1 >= 1 && current.bool_10)
							{
								if (current.bool_9)
								{
									num3++;
								}
								if ((flag3 && (!current.bool_9 || !current.Name.ToLower().Contains(text))) || (!flag3 && Class341.class605_21 == Enum103.const_1 && !current.bool_3) || (!flag3 && Class341.class605_21 == Enum103.const_3 && ((double)Math.Abs(current.float_2 - Class115.class861_0.float_2) >= 0.01 || (double)Math.Abs(current.float_1 - Class115.class861_0.float_1) >= 0.01)) || (!flag3 && Class341.class605_21 == Enum103.const_2 && current.int_5 != Class115.class861_0.int_5) || (!flag4 && !Class111.bool_7[(int)current.playModes_0]))
								{
									if (current.class531_2 != null && !current.class531_2.method_7())
									{
										List<Class531> arg_331_0 = current.list_0;
										if (Class111.action_4 == null)
										{
											Class111.action_4 = new Action<Class531>(Class111.smethod_83);
										}
										arg_331_0.ForEach(Class111.action_4);
									}
								}
								else
								{
									if (!flag && !Class111.bool_4)
									{
										if (current.method_10(new Vector2((float)(this.int_8 % num * 205), (float)(this.int_8 / num * 52)), true, num2))
										{
											current.class531_2.bool_1 = true;
											current.class531_2.bool_2 = true;
											current.class531_2.method_2(new EventHandler(Class111.smethod_42));
											current.class531_2.object_0 = current;
											current.class911_0 = Class111.class110_1.class911_0;
											Class111.class110_1.class911_0.Add<Class531>(current.list_0);
											foreach (Class531 current2 in current.list_0)
											{
												current2.class26_0.Add(new Class746(TransformationType.Fade, 0f, current2.float_3, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
											}
										}
										List<Class531> arg_466_0 = current.list_0;
										if (Class111.action_3 == null)
										{
											Class111.action_3 = new Action<Class531>(Class111.smethod_82);
										}
										arg_466_0.ForEach(Class111.action_3);
									}
									this.int_8++;
									if (current.class531_2 != null && current.class531_2.bool_3)
									{
										class.list_0.Add(current);
									}
								}
								num2++;
							}
						}
					}
					if (class.list_0.Count == 0)
					{
						Class111.smethod_50();
					}
					else
					{
						Class115.class47_0.method_1(new VoidDelegate(class.method_0), 500, false);
					}
					this.class533_2.Text = string.Format(Class41.GetString(OsuString.ChatEngine_UsersConnected), num2.ToString("#,0", Class115.numberFormatInfo_0));
					Class111.class110_1.method_14(new Vector2((float)num, (float)(this.int_8 / num * 52 + 52)));
					if (num2 - num3 > 500)
					{
						Class856.smethod_8();
						return;
					}
				}
			}
			else if (this.int_16 > 0 && this.int_16 + 40000 < Class115.int_1)
			{
				this.int_16 = 0;
				this.method_16(Enum31.const_0);
				if (this.list_14.Count > 0)
				{
					this.list_14.Clear();
				}
			}
		}

		// Token: 0x060030CD RID: 12493
		// RVA: 0x0013DF40 File Offset: 0x0013C140
		private void method_12()
		{
			if (!Class809.smethod_4())
			{
				Class111.class533_0.color_0 = Color.get_Red();
				Class111.class531_5.method_16(0, Enum70.const_0);
				int num = (int)Math.Ceiling(Class809.dateTime_0.Subtract(DateTime.Now).TotalMinutes);
				this.string_3 = (Class111.class533_0.Text = string.Format(Class41.GetString(OsuString.ChatEngine_SilenceNotification), num));
				return;
			}
			Class111.Class828 class = new Class111.Class828();
			Class111.class533_0.color_0 = Color.get_White();
			class.string_0 = Class802.class799_0.Text;
			if (class.string_0 != this.string_3)
			{
				Class111.Class829 class2 = new Class111.Class829();
				class2.class828_0 = class;
				this.string_3 = class.string_0;
				this.int_9 = 0;
				class2.class40_0 = Class36.smethod_2(class.string_0, 0, Class111.int_15);
				class2.bool_0 = false;
				List<Class531> arg_10D_0 = Class111.list_13;
				if (Class111.action_5 == null)
				{
					Class111.action_5 = new Action<Class531>(Class111.smethod_84);
				}
				arg_10D_0.ForEach(Class111.action_5);
				Class111.list_13.Clear();
				class2.class40_0.list_0.ForEach(new Action<Class39>(class2.method_0));
				if (!class2.bool_0)
				{
					Class111.class533_0.Text = ">" + class.string_0;
				}
				float x;
				for (x = Class111.class533_0.method_66(this.int_9, Class111.class533_0.Text.Length - this.int_9).X; x > (float)(Class115.smethod_43() - 60); x = Class111.class533_0.method_66(this.int_9, Class111.class533_0.Text.Length - this.int_9).X)
				{
					this.int_9 += 4;
				}
				if (this.int_9 > 0)
				{
					class.string_0 = class.string_0.Remove(0, this.int_9);
					Class111.class533_0.Text = class.string_0;
				}
				if (x > (float)(Class115.smethod_43() - 240))
				{
					Class111.class531_1.method_16(200, Enum70.const_0);
					Class111.class531_2.method_16(200, Enum70.const_0);
					Class111.class531_3.method_16(200, Enum70.const_0);
				}
				else
				{
					Class111.class531_1.method_14(200, Enum70.const_0);
					Class111.class531_2.method_14(200, Enum70.const_0);
					Class111.class531_3.method_14(200, Enum70.const_0);
				}
			}
			this.int_11 = this.int_10;
			this.int_10 = Math.Max(0, Class802.class799_0.SelectionStart + ((this.int_9 == 0) ? 1 : (-this.int_9)));
			int num2 = Math.Min(Class802.class799_0.SelectionLength, Class111.class533_0.Text.Length - this.int_10);
			if (num2 > 0)
			{
				this.class531_6.vector2_1 = Class111.class533_0.vector2_1;
				try
				{
					Class531 expr_2F6_cp_0 = this.class531_6;
					expr_2F6_cp_0.vector2_1.X = expr_2F6_cp_0.vector2_1.X + (Class111.class533_0.method_66(0, this.int_10).X - 2f);
					this.class531_6.vector2_2 = new Vector2(Class111.class533_0.method_66(this.int_10, num2).X - 4f, 32f) * 1.6f;
				}
				catch (Exception)
				{
				}
				Class111.class531_5.method_16(50, Enum70.const_0);
				this.class531_6.method_14(50, Enum70.const_0);
				this.int_11 = -1;
				this.int_10 = -1;
			}
			else
			{
				this.class531_6.method_16(50, Enum70.const_0);
				if (Class111.class531_5.class26_0.Count == 0)
				{
					Class111.class531_5.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0.4f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0)
					{
						enum70_0 = Enum70.const_1,
						bool_0 = true
					});
				}
				if (this.int_11 != this.int_10)
				{
					Class111.class531_5.vector2_1.X = (float)((this.int_10 == Class111.class533_0.Text.Length) ? 2 : 1) + Class111.class533_0.vector2_1.X + Class111.class533_0.method_66(0, Math.Min(Class111.class533_0.Text.Length, this.int_10)).X - 3.5f;
					Class111.class531_5.vector2_0.X = Class111.class531_5.vector2_1.X;
				}
			}
			Class111.class796_0.vector2_0.X = Class111.class531_5.vector2_1.X;
			Class111.class796_0.method_0();
		}

		// Token: 0x060030D2 RID: 12498
		// RVA: 0x0013E5D4 File Offset: 0x0013C7D4
		private void method_13()
		{
			if (Class111.list_0 == null)
			{
				return;
			}
			if (Class341.class606_63 && Class111.list_0.Count > 0 && Class111.class841_0 != Class111.list_0[Class111.list_0.Count - 1])
			{
				Class111.class841_0 = Class111.list_0[Class111.list_0.Count - 1];
				Class111.class533_1.vector2_1 = ((Class115.osuModes_1 == OsuModes.Edit) ? this.vector2_0 : this.vector2_1);
				if (Class111.class841_0 != null && Class111.class841_0.string_0.Length > 0)
				{
					Class111.class533_1.Text = Class111.class841_0.string_1 + " " + Class111.class841_0.string_0;
					if (!Class111.bool_2)
					{
						Class111.class533_1.color_0 = Class111.class841_0.color_0;
						Class111.class533_1.method_17(8000);
					}
				}
			}
		}

		// Token: 0x060030D3 RID: 12499
		// RVA: 0x000242A7 File Offset: 0x000224A7
		private void method_14()
		{
			if (Class111.bool_2)
			{
				Class111.smethod_34(false);
			}
			this.method_13();
		}

		// Token: 0x060030D4 RID: 12500
		// RVA: 0x0013E6D0 File Offset: 0x0013C8D0
		private void method_15()
		{
			if ((Class111.bool_2 || !Class62.bool_12 || Class341.class606_50) && Class111.queue_0.Count > 0)
			{
				lock (Class111.queue_0)
				{
					Class111.queue_0.Dequeue()();
				}
			}
		}

		// Token: 0x060030D7 RID: 12503
		// RVA: 0x000242BC File Offset: 0x000224BC
		private void method_16(Enum31 enum31_1)
		{
			if (!Class809.bool_4)
			{
				this.enum31_0 = Enum31.const_0;
				return;
			}
			if (this.enum31_0 == enum31_1)
			{
				return;
			}
			Class809.smethod_33(Enum3.const_79, (int)enum31_1);
			this.enum31_0 = enum31_1;
		}

		// Token: 0x060030D8 RID: 12504
		// RVA: 0x0013E890 File Offset: 0x0013CA90
		private void method_17()
		{
			if (!Class341.class606_47)
			{
				return;
			}
			if (Class111.int_3 > 0 && Class115.int_1 - Class111.int_3 > 1000 && Class111.list_2.Count > 0)
			{
				Class111.Class830 class = new Class111.Class830();
				Class111.int_3 = 0;
				string text = Class111.list_2[0];
				for (int i = 1; i < Class111.list_2.Count; i++)
				{
					text = text + ", " + Class111.list_2[i];
				}
				class.class861_0 = ((Class111.list_2.Count == 1) ? Class809.smethod_29(Class111.list_2[0]) : null);
				Class723.smethod_5(string.Format(Class41.GetString(OsuString.ChatEngine_FriendsOnline), text), Color.get_YellowGreen(), 8000, new VoidDelegate(class.method_0));
				Class111.list_2.Clear();
			}
			if (Class111.int_4 > 0 && Class115.int_1 - Class111.int_4 > 1000 && Class111.list_3.Count > 0)
			{
				Class111.int_4 = 0;
				string text2 = Class111.list_3[0];
				for (int j = 1; j < Class111.list_3.Count; j++)
				{
					text2 = text2 + ", " + Class111.list_3[j];
				}
				Class723.smethod_5(string.Format(Class41.GetString(OsuString.ChatEngine_FriendsOffline), text2), Color.get_OrangeRed(), 8000, null);
				Class111.list_3.Clear();
			}
		}

		// Token: 0x060030D9 RID: 12505
		// RVA: 0x0013EA10 File Offset: 0x0013CC10
		private void method_18()
		{
			bool flag = Class876.smethod_5(Mods.Cinema);
			bool flag2;
			if (Class809.bool_4 && (!Class115.bool_16 || Class115.bool_17))
			{
				if (Class115.osuModes_1 == OsuModes.Play && (!Class802.smethod_0() || flag))
				{
					flag2 = (!Class111.bool_2 && (!Class331.smethod_79() || Class62.bool_29) && (Class62.bool_12 || Class62.smethod_2() || Class62.bool_42 || flag));
					if (Class341.class606_2)
					{
						if (Class62.bool_12 && Class111.bool_2)
						{
							if (!this.bool_3)
							{
								this.bool_3 = true;
								Class111.smethod_21(false);
							}
						}
						else if (!Class62.bool_12 && !Class111.bool_2 && this.bool_3)
						{
							this.bool_3 = false;
							Class111.smethod_21(false);
						}
					}
				}
				else
				{
					flag2 = (Class115.class89_0 != null || (!Class111.bool_2 && (Class115.osuModes_1 != OsuModes.Menu || Class79.bool_4) && Class115.osuModes_1 != OsuModes.Rank && Class115.osuModes_1 != OsuModes.RankingVs && Class115.osuModes_1 != OsuModes.RankingTagCoop && Class115.osuModes_1 != OsuModes.RankingTeam && Class115.osuModes_1 != OsuModes.Play && Class115.osuModes_1 != OsuModes.OnlineSelection && Class115.osuModes_1 != OsuModes.BeatmapImport));
				}
			}
			else
			{
				if (Class111.bool_2)
				{
					Class111.smethod_21(false);
				}
				flag2 = true;
			}
			if (flag2 != Class111.class531_0.bool_3)
			{
				return;
			}
			if (flag2)
			{
				Class111.class531_0.method_16(50, Enum70.const_0);
				Class111.class531_3.method_16(50, Enum70.const_0);
				Class115.class533_1.method_21((float)(Class115.smethod_44() - 2), 300, Enum70.const_1);
				return;
			}
			Class111.class531_0.method_14(50, Enum70.const_0);
			Class111.class531_3.method_14(50, Enum70.const_0);
			Class115.class533_1.method_21((float)(Class115.smethod_44() - 14), 300, Enum70.const_1);
		}

		// Token: 0x060030A6 RID: 12454
		// RVA: 0x000241AC File Offset: 0x000223AC
		private void method_2(object sender, EventArgs e)
		{
			Class341.class605_21.Value = (Enum103)this.class753_0.int_2;
			Class111.int_18 = 0;
			Class111.smethod_50();
		}

		// Token: 0x060030A7 RID: 12455
		// RVA: 0x0013BFA8 File Offset: 0x0013A1A8
		private void method_3(object sender, EventArgs e)
		{
			Class531 class = sender as Class531;
			PlayModes int_ = (PlayModes)class.int_0;
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class111.smethod_5(int_, !Class111.bool_7[class.int_0]);
		}

		// Token: 0x060030AA RID: 12458
		// RVA: 0x000241CE File Offset: 0x000223CE
		private void method_4()
		{
			Class111.smethod_50();
		}

		// Token: 0x060030AB RID: 12459
		// RVA: 0x000241D5 File Offset: 0x000223D5
		private void method_5(object sender, EventArgs e)
		{
			Class115.smethod_37(new Class102());
		}

		// Token: 0x060030AC RID: 12460
		// RVA: 0x0013C0F8 File Offset: 0x0013A2F8
		private void method_6(object sender, EventArgs e)
		{
			Class21 class = sender as Class21;
			if (class != null)
			{
				Class111.smethod_11(class, true, false);
			}
			if (Class111.class594_0.list_1.Count == 1)
			{
				Class111.smethod_7(Class111.list_0);
			}
		}

		// Token: 0x060030AD RID: 12461
		// RVA: 0x000241E1 File Offset: 0x000223E1
		private void method_7(object object_0, bool bool_9)
		{
			Class111.bool_4 = bool_9;
		}

		// Token: 0x060030B4 RID: 12468
		// RVA: 0x0013C4A4 File Offset: 0x0013A6A4
		private void method_8(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			if (Class111.class21_0 != null)
			{
				string text = Class802.class799_0.Text;
				if (!text.StartsWith("!") && !text.StartsWith("/"))
				{
					Class111.class21_0.string_2 = Class802.class799_0.Text;
				}
			}
			Class111.class21_0 = (sender as Class21);
			if (Class111.class21_0 == null)
			{
				return;
			}
			Class802.smethod_7(Class111.class21_0.string_2);
			Class111.class21_0.Join(false);
			Class111.smethod_6(Class111.list_0);
			Class111.smethod_33(Class111.class21_0.list_0, false);
			Class111.list_0 = Class111.class21_0.list_0;
			Class111.smethod_38();
			if ((Class111.bool_5 || Class115.int_1 > 20000 || Class341.class605_10.Value.Length == 0) && Class111.class21_0.string_0[0] == '#')
			{
				Class341.class605_10.Value = Class111.class21_0.string_0;
			}
			Class111.int_2 = 0;
		}

		// Token: 0x060030B5 RID: 12469
		// RVA: 0x0013C5A4 File Offset: 0x0013A7A4
		private void method_9(object sender, EventArgs e)
		{
			Class111.enum102_0 = (Enum102)sender;
			Class341.class605_22.Value = Class111.enum102_0;
			Class111.int_18 = 0;
			Class111.class110_1.method_17(Vector2.get_Zero(), 0f);
			Class111.class110_1.int_1 = -1;
			Class111.smethod_50();
			switch (Class111.enum102_0)
			{
			case Enum102.const_1:
				if (Class111.comparison_4 == null)
				{
					Class111.comparison_4 = new Comparison<Class861>(Class111.smethod_79);
				}
				this.comparison_0 = Class111.comparison_4;
				return;
			case Enum102.const_2:
				if (Class111.comparison_2 == null)
				{
					Class111.comparison_2 = new Comparison<Class861>(Class111.smethod_77);
				}
				this.comparison_0 = Class111.comparison_2;
				return;
			case Enum102.const_4:
				if (Class111.comparison_3 == null)
				{
					Class111.comparison_3 = new Comparison<Class861>(Class111.smethod_78);
				}
				this.comparison_0 = Class111.comparison_3;
				return;
			}
			if (Class111.comparison_1 == null)
			{
				Class111.comparison_1 = new Comparison<Class861>(Class111.smethod_76);
			}
			this.comparison_0 = Class111.comparison_1;
		}

		// Token: 0x060030A0 RID: 12448
		// RVA: 0x00024140 File Offset: 0x00022340
		private static float smethod_0()
		{
			return Class111.class531_4.vector2_1.Y + 14f;
		}

		// Token: 0x060030A1 RID: 12449
		// RVA: 0x00024157 File Offset: 0x00022357
		private static RectangleF smethod_1()
		{
			return new RectangleF(2f, Class111.smethod_0(), (float)(Class115.smethod_43() - 2), (float)(Class111.int_13 - 29));
		}

		// Token: 0x060030B2 RID: 12466
		// RVA: 0x0013C390 File Offset: 0x0013A590
		public static void smethod_10(string string_5)
		{
			Class111.Class822 class = new Class111.Class822();
			class.string_0 = string_5;
			Class21 class2 = Class111.list_1.Find(new Predicate<Class21>(class.method_0));
			if (class2 == null)
			{
				return;
			}
			Class111.smethod_11(class2, false, true);
		}

		// Token: 0x060030B3 RID: 12467
		// RVA: 0x0013C3D0 File Offset: 0x0013A5D0
		public static void smethod_11(Class21 class21_1, bool bool_9, bool bool_10)
		{
			if (class21_1.string_0 == "#spectator" && !bool_10)
			{
				class21_1.method_1();
				Class111.list_15.Remove(class21_1.string_0);
				Class111.class594_0.Remove(class21_1);
				return;
			}
			class21_1.method_1();
			Class111.list_15.Remove(class21_1.string_0);
			if (class21_1.bool_2 || (class21_1.bool_3 && !class21_1.bool_0))
			{
				Class111.list_1.Remove(class21_1);
			}
			if (bool_9)
			{
				Class341.class605_9.Value = Class341.class605_9.Value.Replace(class21_1.string_0, string.Empty).Replace("  ", string.Empty);
			}
			Class111.class594_0.Remove(class21_1);
			if (Class111.class21_0 == class21_1)
			{
				Class111.class594_0.method_14(1);
			}
		}

		// Token: 0x060030B8 RID: 12472
		// RVA: 0x0002423B File Offset: 0x0002243B
		internal static bool smethod_12()
		{
			return Class111.bool_2 && Class111.class531_4.rectangleF_0.Contains(Class800.smethod_15());
		}

		// Token: 0x060030B9 RID: 12473
		// RVA: 0x0013C810 File Offset: 0x0013AA10
		internal static void smethod_13(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class341.class606_2.Value = !Class341.class606_2;
		}

		// Token: 0x060030BA RID: 12474
		// RVA: 0x0013C850 File Offset: 0x0013AA50
		internal static void smethod_14(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class341.class606_63.Value = !Class341.class606_63;
		}

		// Token: 0x060030BB RID: 12475
		// RVA: 0x0013C890 File Offset: 0x0013AA90
		internal static void smethod_15()
		{
			if (Class111.class531_2 != null)
			{
				Class111.class531_2.class746_1 = new Class746(Class341.class606_63 ? Color.get_White() : Color.get_Gray(), Class341.class606_63 ? Color.get_White() : Color.get_Pink(), 0, 100);
				Class111.class531_2.method_39(Class341.class606_63 ? Color.get_White() : Color.get_Gray(), 100, false, Enum70.const_0);
				Class111.class531_2.vmethod_7(Class885.Load(Class341.class606_63 ? "overlay-ticker2" : "overlay-ticker", Enum112.flag_1));
			}
			if (Class111.class531_1 != null)
			{
				Class111.class531_1.class746_1 = new Class746(Class341.class606_2 ? Color.get_White() : Color.get_Gray(), Class341.class606_2 ? Color.get_White() : Color.get_Pink(), 0, 100);
				Class111.class531_1.method_39(Class341.class606_2 ? Color.get_White() : Color.get_Gray(), 100, false, Enum70.const_0);
				Class111.class531_1.vmethod_7(Class885.Load(Class341.class606_2 ? "overlay-hidemode2" : "overlay-hidemode", Enum112.flag_1));
			}
		}

		// Token: 0x060030BC RID: 12476
		// RVA: 0x0013C9D4 File Offset: 0x0013ABD4
		private static void smethod_16(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			if (Class111.smethod_22() || Class111.bool_2)
			{
				if (!Class111.bool_2 && Class111.bool_1)
				{
					Class111.smethod_19();
				}
				Class111.smethod_21(false);
			}
		}

		// Token: 0x060030BD RID: 12477
		// RVA: 0x0013CA24 File Offset: 0x0013AC24
		internal static bool smethod_17(object object_0, Keys keys_0, bool bool_9)
		{
			if (Class111.bool_2 && (Class802.class799_0.bool_0 || (Class802.class799_0.int_0 > 0 && Class115.int_1 - Class802.class799_0.int_0 < Class111.int_1)))
			{
				return true;
			}
			if (bool_9)
			{
				if (keys_0 == Class795.smethod_3(Bindings.ToggleChat))
				{
					if (Class111.bool_2 || Class111.smethod_22())
					{
						Class111.smethod_21(false);
					}
					return true;
				}
				if (keys_0 == Class795.smethod_3(Bindings.ToggleExtendedChat))
				{
					if (Class111.smethod_22())
					{
						if (Class111.bool_2)
						{
							Class111.smethod_19();
						}
						else
						{
							if (!Class111.bool_1)
							{
								Class111.smethod_19();
							}
							if (Class111.smethod_22())
							{
								Class111.smethod_21(false);
							}
						}
					}
					return true;
				}
			}
			if (Class111.bool_2)
			{
				if (Class570.bool_1 && !Class570.bool_2 && !Class570.bool_0 && keys_0 >= 48 && keys_0 <= 57)
				{
					int num = (keys_0 == 48) ? 9 : (keys_0 - 49);
					if (num < Class111.class594_0.list_1.Count)
					{
						Class111.class594_0.method_2(Class111.class594_0.list_1[num].object_0);
						return true;
					}
				}
				if (bool_9)
				{
					if (Class570.bool_0)
					{
						if (keys_0 != 9)
						{
							switch (keys_0)
							{
							case 78:
								Class111.class594_0.method_14(1);
								break;
							case 79:
								break;
							case 80:
								Class111.class594_0.method_14(-1);
								break;
							default:
								if (keys_0 == 87)
								{
									Class111.class594_0.vmethod_3(Class111.class594_0.class750_1 as Class752);
								}
								break;
							}
						}
						else if (Class570.bool_2)
						{
							Class111.class594_0.method_14(-1);
						}
						else
						{
							Class111.class594_0.method_14(1);
						}
					}
					if (Class570.bool_1)
					{
						switch (keys_0)
						{
						case 37:
							Class111.class594_0.method_14(-1);
							break;
						case 39:
							Class111.class594_0.method_14(1);
							break;
						}
						return true;
					}
					if (keys_0 == 9)
					{
						Class111.smethod_18();
						return true;
					}
					if (keys_0 != 13)
					{
						if (keys_0 == 27)
						{
							if (Class111.bool_2)
							{
								if (Class70.enum59_0 != Enum59.const_0 && Class70.enum59_0 != Enum59.const_5)
								{
									if (Class111.bool_1)
									{
										Class111.smethod_19();
									}
									else
									{
										Enum59 enum59_ = Class70.enum59_0;
										if (enum59_ != Enum59.const_1)
										{
											if (enum59_ == Enum59.const_4)
											{
												Class72.smethod_0();
											}
										}
										else
										{
											Class115.smethod_70(OsuModes.Menu, false);
										}
									}
								}
								else
								{
									Class111.smethod_21(false);
								}
							}
							return true;
						}
					}
					else
					{
						if (Class802.class799_0.Text.Length != 0 && Class809.smethod_4())
						{
							if (Class111.class594_0.list_1.Count != 1)
							{
								Class111.smethod_44(Class802.class799_0.Text, true);
							}
							Class802.smethod_7(string.Empty);
							return true;
						}
						return true;
					}
				}
				switch (keys_0)
				{
				case 33:
					if (bool_9 || Class111.class110_0.method_24() > Class111.class110_0.float_2)
					{
						Class111.class110_0.method_25((float)(-12 * Class111.int_7), 0f);
					}
					return true;
				case 34:
					if (bool_9 || Class111.class110_0.method_24() < Class111.class110_0.vector2_2.Y - Class111.class110_0.method_3())
					{
						Class111.class110_0.method_25((float)(12 * Class111.int_7), 0f);
					}
					return true;
				default:
					switch (keys_0)
					{
					case 38:
						Class111.smethod_57();
						return true;
					case 40:
						Class111.smethod_58();
						return true;
					}
					break;
				}
			}
			return false;
		}

		// Token: 0x060030BE RID: 12478
		// RVA: 0x0013CD5C File Offset: 0x0013AF5C
		private static void smethod_18()
		{
			Predicate<Class861> predicate = null;
			Class111.Class823 class = new Class111.Class823();
			string text = Class802.class799_0.Text;
			if (text.Length == 0)
			{
				return;
			}
			int i;
			for (i = Class802.class799_0.SelectionStart; i < text.Length; i++)
			{
				if (text[i] == ' ')
				{
					break;
				}
			}
			int num = text.LastIndexOf(' ', Math.Max(0, i - 1));
			int num2 = text.IndexOf(' ', Math.Max(0, i - 1));
			if (num2 == -1)
			{
				num2 = text.Length;
			}
			else
			{
				num2--;
			}
			if (num == -1)
			{
				num = 0;
			}
			else
			{
				num++;
			}
			if (num2 < num)
			{
				num2 = num;
			}
			class.string_0 = text.Substring(num, num2 - num).Replace(' ', '_').Trim();
			if (class.string_0.Length == 0)
			{
				return;
			}
			List<Class861> list = null;
			lock (Class809.list_1)
			{
				List<Class861> arg_E4_0 = Class809.list_1;
				if (predicate == null)
				{
					predicate = new Predicate<Class861>(class.method_0);
				}
				list = arg_E4_0.FindAll(predicate);
			}
			if (list.Count == 1)
			{
				string text2 = list[0].string_4 + ((num == 0) ? ": " : " ");
				Class802.class799_0.Text = Class802.class799_0.Text.Remove(num, num2 - num).Insert(num, text2);
				Class802.class799_0.SelectionStart = i + (text2.Length - class.string_0.Length);
				Class802.class799_0.SelectionLength = 0;
				return;
			}
			if (list.Count > 1)
			{
				string text3 = string.Empty;
				int num3 = 0;
				bool flag = true;
				IL_236:
				while (flag && num3 <= list[0].string_4.Length - 1)
				{
					char c = list[0].string_4[num3];
					int j = 1;
					while (j < list.Count)
					{
						if (list[j].string_4.Length - 1 >= num3)
						{
							if (char.ToLower(list[j].string_4[num3]) == char.ToLower(c))
							{
								j++;
								continue;
							}
						}
						flag = false;
						IL_21C:
						if (flag)
						{
							text3 += c;
						}
						num3++;
						goto IL_236;
					}
					goto IL_21C;
				}
				text3 = text3.Replace(' ', '_');
				Class802.class799_0.Text = Class802.class799_0.Text.Remove(num, num2 - num).Insert(num, text3);
				Class802.class799_0.SelectionStart = i + (text3.Length - class.string_0.Length);
				Class802.class799_0.SelectionLength = 0;
				string text4 = string.Empty;
				for (int k = 0; k < list.Count; k++)
				{
					if (k == 20)
					{
						text4 += "...";
						IL_2EB:
						Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_TabComplete) + text4, string.Empty, Color.get_YellowGreen()));
						return;
					}
					text4 = text4 + list[k].string_4 + " ";
				}
				goto IL_2EB;
			}
		}

		// Token: 0x060030BF RID: 12479
		// RVA: 0x0013D090 File Offset: 0x0013B290
		internal static void smethod_19()
		{
			Class111.bool_1 = !Class111.bool_1;
			if (Class111.bool_1)
			{
				Class115.class80_0.method_24(false);
			}
			Class111.smethod_20();
			bool flag = !Class111.bool_2 || (Class111.bool_2 && Class111.bool_1);
			Class111.class531_3.class746_1 = new Class746(flag ? Color.get_White() : Color.get_Gray(), flag ? Color.get_White() : Color.get_Pink(), 0, 100);
			Class111.class531_3.method_39(flag ? Color.get_White() : Color.get_Gray(), 100, false, Enum70.const_0);
		}

		// Token: 0x060030A2 RID: 12450
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal static bool smethod_2()
		{
			return false;
		}

		// Token: 0x060030C0 RID: 12480
		// RVA: 0x0013D12C File Offset: 0x0013B32C
		private static void smethod_20()
		{
			if (Class111.bool_1 && Class111.bool_2)
			{
				Class111.class110_1.method_18();
				Class111.smethod_50();
			}
			else
			{
				Class111.class110_1.method_19();
			}
			using (List<Class530>.Enumerator enumerator = Class111.class911_0.method_11("user").GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					if (Class111.bool_1 && Class111.bool_2)
					{
						class.method_14(300, Enum70.const_0);
					}
					else
					{
						class.method_16(300, Enum70.const_0);
					}
				}
			}
			using (List<Class530>.Enumerator enumerator2 = Class115.class911_3.method_11("user").GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class531 class2 = (Class531)enumerator2.Current;
					if (Class111.bool_1 && Class111.bool_2)
					{
						class2.method_14(300, Enum70.const_0);
					}
					else
					{
						class2.method_16(300, Enum70.const_0);
					}
				}
			}
		}

		// Token: 0x060030C1 RID: 12481
		// RVA: 0x0013D24C File Offset: 0x0013B44C
		internal static void smethod_21(bool bool_9)
		{
			if (!Class111.bool_2 && !Class809.bool_4)
			{
				return;
			}
			bool flag = Class115.class61_0 is Class70 || Class115.class61_0 is Class72;
			if (!bool_9 && (Class111.bool_2 || Class115.class89_0 != null) && flag)
			{
				if (Class111.bool_1)
				{
					Class111.smethod_19();
				}
				return;
			}
			Class111.bool_2 = !Class111.bool_2;
			Class111.int_6 = Class115.int_1;
			Class111.class531_0.vmethod_7(Class885.Load(Class111.bool_2 ? "overlay-hide" : "overlay-show", Enum112.flag_1));
			bool flag2 = !Class111.bool_2 || (Class111.bool_2 && Class111.bool_1);
			Class111.class531_3.class746_1 = new Class746(flag2 ? Color.get_White() : Color.get_Gray(), flag2 ? Color.get_White() : Color.get_Pink(), 0, 100);
			Class111.class531_3.method_39(flag2 ? Color.get_White() : Color.get_Gray(), 100, false, Enum70.const_0);
			Class331.smethod_59("select-expand", 100, Enum112.flag_5);
			if (Class111.bool_2)
			{
				Class115.class80_0.method_8(false);
				Class111.smethod_33(Class111.list_0, true);
				Class111.smethod_38();
				lock (Class911.object_0)
				{
					foreach (Class531 current in Class111.list_8)
					{
						current.method_14(300, Enum70.const_0);
						current.method_21(current.vector2_0.Y, 400, Enum70.const_16);
					}
				}
				Class111.class533_1.method_16(20, Enum70.const_0);
				List<Class531> arg_1BC_0 = Class111.list_12;
				if (Class111.action_2 == null)
				{
					Class111.action_2 = new Action<Class531>(Class111.smethod_81);
				}
				arg_1BC_0.ForEach(Class111.action_2);
			}
			else
			{
				lock (Class111.class911_0.list_2)
				{
					foreach (Class531 current2 in Class111.list_8)
					{
						current2.method_16(300, Enum70.const_0);
						current2.method_21(current2.vector2_0.Y + 80f, 400, Enum70.const_15);
					}
				}
			}
			Class111.smethod_20();
			Class802.smethod_3(Class111.bool_2);
		}

		// Token: 0x060030C2 RID: 12482
		// RVA: 0x0002425A File Offset: 0x0002245A
		private static bool smethod_22()
		{
			if (!Class115.smethod_33() && Class115.osuModes_1 != OsuModes.Play)
			{
				Class115.smethod_80(false);
				return false;
			}
			return Class115.smethod_33();
		}

		// Token: 0x060030C3 RID: 12483
		// RVA: 0x0013D4D8 File Offset: 0x0013B6D8
		internal static void smethod_23(string string_5)
		{
			Class21 class = Class111.smethod_8("#console", true, false);
			class.method_0(true);
			Class111.class594_0.method_2(class);
			Class111.smethod_24(new Class11("BanchoBot", class.string_0, string_5), false, true);
		}

		// Token: 0x060030C4 RID: 12484
		// RVA: 0x0013D520 File Offset: 0x0013B720
		internal static void smethod_24(Class11 class11_0, bool bool_9, bool bool_10)
		{
			VoidDelegate voidDelegate = null;
			Class111.Class824 class = new Class111.Class824();
			class.class11_0 = class11_0;
			class.bool_0 = bool_9;
			class.bool_1 = bool_10;
			lock (Class111.queue_0)
			{
				Queue<VoidDelegate> arg_3F_0 = Class111.queue_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				arg_3F_0.Enqueue(voidDelegate);
			}
		}

		// Token: 0x060030C5 RID: 12485
		// RVA: 0x0013D58C File Offset: 0x0013B78C
		internal static void smethod_25(string string_5)
		{
			Class21 class = Class111.smethod_8("#userlog", true, false);
			class.method_0(true);
			Class111.smethod_24(new Class11("BanchoBot", "#userlog", string_5), false, false);
		}

		// Token: 0x060030C6 RID: 12486
		// RVA: 0x0013D5C4 File Offset: 0x0013B7C4
		private static bool smethod_26(string string_5)
		{
			if (Class111.smethod_27(Class341.class605_20, string_5))
			{
				return true;
			}
			if (Class341.class605_20.Value.IndexOf(' ') > 0 && Class111.smethod_27(Class341.class605_20.Value.Replace(" ", "_"), string_5))
			{
				return true;
			}
			for (int i = 0; i < Class111.list_7.Count; i++)
			{
				if (Class111.smethod_27(Class111.list_7[i], string_5))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060030C7 RID: 12487
		// RVA: 0x0013D648 File Offset: 0x0013B848
		private static bool smethod_27(string string_5, string string_6)
		{
			if (!string.IsNullOrEmpty(string_5) && !string.IsNullOrEmpty(string_6))
			{
				int num = 0;
				int length = string_6.Length;
				while (true)
				{
					int num2 = string_6.IndexOf(string_5, num, length - num, StringComparison.InvariantCultureIgnoreCase);
					if (num2 < 0)
					{
						break;
					}
					bool flag = true;
					if (!Class111.smethod_28(string_5[0]) || !Class111.smethod_28(string_5[string_5.Length - 1]))
					{
						if (flag && num2 > 0)
						{
							flag &= (!char.IsLetter(string_6[num2 - 1]) || Class111.smethod_28(string_6[num2 - 1]));
						}
						if (flag && num2 + string_5.Length < length)
						{
							flag &= (!char.IsLetter(string_6[num2 + string_5.Length]) || Class111.smethod_28(string_6[num2 + string_5.Length]));
						}
					}
					if (flag)
					{
						return true;
					}
					num = num2 + string_5.Length;
					if (num >= length - 1)
					{
						return false;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060030C8 RID: 12488
		// RVA: 0x0013D734 File Offset: 0x0013B934
		private static bool smethod_28(char char_0)
		{
			return (char_0 < 'Ѐ' || char_0 > 'ӿ') && (char_0 < 'Ԁ' || char_0 > 'ԯ') && (char_0 < 'ⷠ' || char_0 > 'ⷿ') && (char_0 < 'Ꙁ' || char_0 > 'ꚟ') && (char_0 < 'ᴫ' || char_0 > 'ᵸ') && char_0 > 'Ā';
		}

		// Token: 0x060030C9 RID: 12489
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal static void smethod_29(string string_5, string string_6)
		{
		}

		// Token: 0x060030A5 RID: 12453
		// RVA: 0x00024179 File Offset: 0x00022379
		internal static void smethod_3()
		{
			Class111.string_0 = (Class341.class606_83.Value ? "Tahoma" : "Aller Light");
			Class111.class533_0.method_62(Class111.string_0);
			Class111.smethod_38();
		}

		// Token: 0x060030CB RID: 12491
		// RVA: 0x0013D85C File Offset: 0x0013BA5C
		private static void smethod_30()
		{
			if (Class111.list_0.Count == 0)
			{
				Class111.class110_0.float_2 = -Class111.class110_0.method_3();
				return;
			}
			Class841 class = Class111.list_0[Class111.list_0.Count - 1];
			if (class.method_2())
			{
				Class578 class2 = class.method_0();
				float num = Math.Min(0f, class2.Position.Y + class2.method_0() - Class111.class110_0.method_3());
				if (Class111.class110_0.float_3 < 0f || Class111.class110_0.vector2_3.Y >= num)
				{
					Class111.class110_0.float_2 = Math.Min(0f, class2.Position.Y + class2.method_0() - Class111.class110_0.method_3());
				}
			}
		}

		// Token: 0x060030CE RID: 12494
		// RVA: 0x0013E410 File Offset: 0x0013C610
		private static void smethod_31(List<Class841> list_16, bool bool_9)
		{
			int num = list_16.Count - 1;
			while (num >= 0 && !list_16[num].method_2())
			{
				num--;
			}
			num++;
			if (num < list_16.Count)
			{
				float num2 = Class111.class110_0.vector2_2.Y - Class111.class110_0.method_3();
				for (int i = num; i < list_16.Count; i++)
				{
					Class111.smethod_37(i, true);
				}
				float num3 = Class111.class110_0.vector2_2.Y - Class111.class110_0.method_3();
				float num4 = list_16[list_16.Count - 1].method_0().method_0();
				if (num2 - Class111.class110_0.method_24() < num4 && Class111.class110_0.vector2_3.Y < num3)
				{
					Class111.class110_0.method_26(bool_9 ? -0.01f : 0f);
				}
			}
		}

		// Token: 0x060030CF RID: 12495
		// RVA: 0x0013E4F4 File Offset: 0x0013C6F4
		private static void smethod_32(List<Class841> list_16)
		{
			int num = list_16.Count - 1;
			while (num >= 0 && (!list_16[num].method_2() || list_16[num].method_0().Position.Y > Class111.class110_0.vector2_3.Y))
			{
				Class841 class = list_16[num];
				if (!class.method_2())
				{
					Class111.smethod_37(num, false);
					if (class.method_0().Position.Y <= Class111.class110_0.vector2_3.Y)
					{
						return;
					}
				}
				num--;
			}
		}

		// Token: 0x060030D0 RID: 12496
		// RVA: 0x0013E584 File Offset: 0x0013C784
		private static void smethod_33(List<Class841> list_16, bool bool_9)
		{
			if (list_16.Count <= 500)
			{
				return;
			}
			if (list_16 == Class111.list_0 && !bool_9)
			{
				do
				{
					Class111.smethod_39(0);
				}
				while (list_16.Count > 500);
				return;
			}
			list_16.RemoveRange(0, list_16.Count - 500);
		}

		// Token: 0x060030D1 RID: 12497
		// RVA: 0x0002427D File Offset: 0x0002247D
		private static void smethod_34(bool bool_9)
		{
			if (Class111.list_0 == null)
			{
				return;
			}
			Class111.smethod_31(Class111.list_0, bool_9);
			Class111.smethod_32(Class111.list_0);
			Class111.smethod_33(Class111.list_0, false);
		}

		// Token: 0x060030D5 RID: 12501
		// RVA: 0x0013E738 File Offset: 0x0013C938
		private static void smethod_35()
		{
			if (Class809.int_15 > 100 && !Class62.bool_12)
			{
				lock (Class809.list_1)
				{
					List<Class861> arg_3E_0 = Class809.list_1;
					if (Class111.predicate_0 == null)
					{
						Class111.predicate_0 = new Predicate<Class861>(Class111.smethod_85);
					}
					arg_3E_0.RemoveAll(Class111.predicate_0);
				}
				Class809.int_15 = 0;
			}
		}

		// Token: 0x060030D6 RID: 12502
		// RVA: 0x0013E7A8 File Offset: 0x0013C9A8
		internal static void smethod_36(List<Class861> list_16, bool bool_9)
		{
			if (list_16.Count == 0)
			{
				return;
			}
			if (!bool_9)
			{
				if (Class115.int_1 - Class111.int_17 < 1000)
				{
					return;
				}
				Class111.int_17 = Class115.int_1;
			}
			List<int> list = new List<int>(list_16.Count);
			foreach (Class861 current in list_16)
			{
				if ((current.class531_2 != null && current.class531_2.bool_3) || bool_9)
				{
					list.Add(current.int_1);
					current.method_18(true, false);
					if (list.Count == 32)
					{
						Class809.smethod_34(Enum3.const_85, new Struct14(list));
						list = new List<int>();
					}
				}
			}
			if (list.Count > 0)
			{
				Class809.smethod_34(Enum3.const_85, new Struct14(list));
			}
		}

		// Token: 0x060030DA RID: 12506
		// RVA: 0x0013EBE4 File Offset: 0x0013CDE4
		private static void smethod_37(int int_20, bool bool_9)
		{
			Class841 class = Class111.list_0[int_20];
			Class578 class2 = class.method_0();
			bool_9 |= (int_20 == Class111.list_0.Count - 1);
			class2.Position = new Vector2(0f, bool_9 ? Class111.class110_0.vector2_2.Y : (Class111.list_0[int_20 + 1].method_0().Position.Y - class2.method_0()));
			if (class2.Position.Y < 0f)
			{
				for (int i = int_20 + 1; i < Class111.list_0.Count; i++)
				{
					Class841 class3 = Class111.list_0[i];
					if (class3.method_2())
					{
						class3.method_0().Position += new Vector2(0f, -class2.Position.Y);
					}
				}
				Class110 expr_E3_cp_0 = Class111.class110_0;
				expr_E3_cp_0.vector2_3.Y = expr_E3_cp_0.vector2_3.Y + -class2.Position.Y;
				Class111.class110_0.method_14(Class111.class110_0.vector2_2 + new Vector2(0f, -class2.Position.Y));
				class2.Position = new Vector2(class2.Position.X, 0f);
			}
			Class111.class110_0.class911_0.Add<Class531>(class2.list_0);
			if (bool_9)
			{
				Class111.class110_0.method_14(Class111.class110_0.vector2_2 + new Vector2(0f, class2.method_0()));
			}
		}

		// Token: 0x060030DB RID: 12507
		// RVA: 0x0013ED78 File Offset: 0x0013CF78
		private static void smethod_38()
		{
			if (Class111.class110_0 == null)
			{
				return;
			}
			Class111.class110_0.method_29(true);
			if (Class111.list_0 == null)
			{
				return;
			}
			Class111.class110_0.vector2_2.Y = (float)Math.Max(0, (Class111.list_0.Count - 1) * 12);
			if (Class111.list_0.Count > 0)
			{
				Class111.smethod_6(Class111.list_0);
				Class111.smethod_37(Class111.list_0.Count - 1, false);
			}
			Class111.smethod_30();
			Class111.class110_0.vector2_3.Y = Math.Max(Class111.class110_0.float_2, Class111.class110_0.vector2_2.Y - Class111.class110_0.method_3());
			Class111.class110_0.method_27();
		}

		// Token: 0x060030DC RID: 12508
		// RVA: 0x0013EE38 File Offset: 0x0013D038
		private static void smethod_39(int int_20)
		{
			Class841 class = Class111.list_0[int_20];
			Vector2 zero = Vector2.get_Zero();
			if (class.method_2())
			{
				Class578 class2 = class.method_0();
				zero.Y = class2.method_0();
				class2.Dispose();
				Class111.class110_0.class911_0.method_13<Class531>(class2.list_0);
			}
			else
			{
				zero.Y = 12f;
			}
			Class111.list_0.RemoveAt(int_20);
			float num = (int_20 >= Class111.list_0.Count) ? Class111.class110_0.vector2_2.Y : Class111.list_0[int_20].method_0().Position.Y;
			if (num < Class111.class110_0.vector2_3.Y + Class111.class110_0.method_3())
			{
				Class111.class110_0.vector2_3 -= zero;
			}
			Class111.class110_0.method_14(Class111.class110_0.vector2_2 - zero);
			for (int i = int_20; i < Class111.list_0.Count; i++)
			{
				if (Class111.list_0[i].method_2())
				{
					Class111.list_0[i].method_0().Position -= zero;
				}
			}
		}

		// Token: 0x060030A8 RID: 12456
		// RVA: 0x0013BFF4 File Offset: 0x0013A1F4
		internal static void smethod_4(PlayModes playModes_0)
		{
			foreach (PlayModes playModes in Enum.GetValues(typeof(PlayModes)))
			{
				Class111.smethod_5(playModes, playModes_0 == playModes);
			}
		}

		// Token: 0x060030DD RID: 12509
		// RVA: 0x000242E6 File Offset: 0x000224E6
		internal static void smethod_40(Class21 class21_1)
		{
			if (class21_1 == null)
			{
				return;
			}
			if (!Class111.list_15.Contains(class21_1.string_0))
			{
				Class111.smethod_8(class21_1.string_0, false, true);
			}
			Class111.class594_0.method_2(class21_1);
		}

		// Token: 0x060030DE RID: 12510
		// RVA: 0x0013EF7C File Offset: 0x0013D17C
		internal static void smethod_41(string string_5)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			Class111.Class831 class = new Class111.Class831();
			class.string_0 = string_5;
			try
			{
				string text = class.string_0.Replace("index.php", string.Empty);
				string text2 = null;
				string str = Regex.Escape("http://osu.ppy.sh").Replace("http", "http[s]?");
				Regex regex = new Regex(str + "/\\?p=beatmap&(.)=([0-9]*)");
				Match match = regex.Match(text);
				if (match.Success)
				{
					text2 = match.Groups[1].Value;
				}
				if (text2 == null)
				{
					Regex regex2 = new Regex(str + "/(.)/([0-9]*)");
					match = regex2.Match(text);
					if (match.Success)
					{
						text2 = match.Groups[1].Value;
					}
				}
				if (text2 == null)
				{
					Regex regex3 = new Regex(str + "/forum/viewtopic.php.*[\\?|&]t=([^0].[0-9]*).*");
					match = regex3.Match(text);
					if (match.Success)
					{
						text2 = "t";
					}
				}
				if (text2 == null)
				{
					Regex regex4 = new Regex(str + "/forum/viewtopic.php\\?.*p=([^0].[0-9]*).*");
					match = regex4.Match(text);
					if (match.Success)
					{
						text2 = "p";
					}
				}
				if (text.StartsWith("osu://"))
				{
					string[] array = text.Replace("osu://", string.Empty).Split(new char[]
					{
						'/'
					});
					string a;
					if ((a = array[0]) != null)
					{
						if (a == "dl")
						{
							Class112.smethod_4(LinkId.Set, int.Parse(array[1]), null);
							return;
						}
						if (!(a == "edit"))
						{
							if (a == "chan")
							{
								Class111.smethod_40(Class111.smethod_8(array[1], false, true));
								return;
							}
						}
						else
						{
							if (Class115.osuModes_1 != OsuModes.Edit)
							{
								Class723.smethod_1(Class41.GetString(OsuString.ChatEngine_MustBeEditMode), 2000);
								return;
							}
							if (Class115.bool_11 && Class115.form_0.Visible)
							{
								Class47 arg_1F4_0 = Class115.class47_0;
								if (Class111.voidDelegate_1 == null)
								{
									Class111.voidDelegate_1 = new VoidDelegate(Class111.smethod_86);
								}
								arg_1F4_0.Add(Class111.voidDelegate_1, false);
							}
							Editor.smethod_0(array[1].Replace("%20", " "));
							return;
						}
					}
				}
				if (text2 == null)
				{
					Regex regex5 = new Regex("osump\\://([0-9]*)/(.*)");
					match = regex5.Match(text);
					if (match.Success)
					{
						if (!Class809.smethod_21(true))
						{
							return;
						}
						if (Class72.class10_0 != null)
						{
							Class723.smethod_4(Class41.GetString(OsuString.ChatEngine_AlreadyInMatch));
							return;
						}
						int num;
						if (!int.TryParse(match.Groups[1].Value, out num))
						{
							return;
						}
						string value = match.Groups[2].Value;
						Class70.smethod_4(num, value);
						return;
					}
				}
				if (Class115.class61_0 is Class68)
				{
					Class68 class2 = (Class68)Class115.class61_0;
					Class296 class3 = null;
					if (text2 == "s")
					{
						class3 = Class466.smethod_33(int.Parse(match.Groups[2].Value));
					}
					else if (text2 == "b")
					{
						class3 = Class466.smethod_32(int.Parse(match.Groups[2].Value));
					}
					if (class3 != null)
					{
						class2.Select(class3);
						return;
					}
				}
				string a2;
				if (text2 != null && (Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0 && (a2 = text2) != null)
				{
					if (a2 == "s")
					{
						LinkId arg_488_0 = LinkId.Set;
						int arg_488_1 = int.Parse(match.Groups[2].Value);
						EventHandler arg_488_2 = null;
						if (Class111.eventHandler_2 == null)
						{
							Class111.eventHandler_2 = new EventHandler(Class111.smethod_87);
						}
						Class112.smethod_5(arg_488_0, arg_488_1, arg_488_2, Class111.eventHandler_2);
						return;
					}
					if (a2 == "b")
					{
						LinkId arg_448_0 = LinkId.Beatmap;
						int arg_448_1 = int.Parse(match.Groups[2].Value);
						EventHandler arg_448_2 = null;
						if (Class111.eventHandler_3 == null)
						{
							Class111.eventHandler_3 = new EventHandler(Class111.smethod_88);
						}
						Class112.smethod_5(arg_448_0, arg_448_1, arg_448_2, Class111.eventHandler_3);
						return;
					}
					if (a2 == "t")
					{
						LinkId arg_408_0 = LinkId.Topic;
						int arg_408_1 = int.Parse(match.Groups[1].Value);
						EventHandler arg_408_2 = null;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler(class.method_0);
						}
						Class112.smethod_5(arg_408_0, arg_408_1, arg_408_2, eventHandler);
						return;
					}
					if (a2 == "p")
					{
						LinkId arg_3D0_0 = LinkId.Post;
						int arg_3D0_1 = int.Parse(match.Groups[1].Value);
						EventHandler arg_3D0_2 = null;
						if (eventHandler2 == null)
						{
							eventHandler2 = new EventHandler(class.method_1);
						}
						Class112.smethod_5(arg_3D0_0, arg_3D0_1, arg_3D0_2, eventHandler2);
						return;
					}
				}
			}
			catch
			{
			}
			if (!class.string_0.StartsWith("http://") && !class.string_0.StartsWith("https://"))
			{
				class.string_0 = "http://" + class.string_0;
			}
			Class115.smethod_90(class.string_0, null);
		}

		// Token: 0x060030DF RID: 12511
		// RVA: 0x0013F484 File Offset: 0x0013D684
		internal static void smethod_42(object sender, EventArgs e)
		{
			if (!Class111.bool_2)
			{
				return;
			}
			Class531 class = sender as Class531;
			if (class == null || class.object_0 == null)
			{
				return;
			}
			Class861 class2 = class.object_0 as Class861;
			if (class2 == null)
			{
				return;
			}
			if (class2 == Class115.class861_0)
			{
				Class115.smethod_34(null, null);
				return;
			}
			Class527.smethod_0(class2, !(sender is Class533));
		}

		// Token: 0x060030E0 RID: 12512
		// RVA: 0x0013F4E0 File Offset: 0x0013D6E0
		internal static void smethod_43(Class861 class861_0, bool bool_9)
		{
			if (class861_0.bool_3 == bool_9)
			{
				return;
			}
			class861_0.bool_3 = bool_9;
			if (class861_0.bool_3)
			{
				Class723.smethod_1("You are now friends with " + class861_0.Name + ".", 2000);
				Class111.list_4.Add(class861_0.int_1);
				Class809.smethod_34(Enum3.const_73, new Struct12(class861_0.int_1));
				return;
			}
			Class723.smethod_1("You are no longer friends with " + class861_0.Name + ".", 2000);
			Class111.list_4.Remove(class861_0.int_1);
			Class809.smethod_34(Enum3.const_74, new Struct12(class861_0.int_1));
		}

		// Token: 0x060030E1 RID: 12513
		// RVA: 0x00024318 File Offset: 0x00022518
		internal static void smethod_44(string string_5, bool bool_9)
		{
			Class111.smethod_45(string_5, Class111.class21_0.string_0, bool_9);
		}

		// Token: 0x060030E2 RID: 12514
		// RVA: 0x0013F594 File Offset: 0x0013D794
		internal static void smethod_45(string string_5, string string_6, bool bool_9)
		{
			Class111.Class832 class = new Class111.Class832();
			class.string_0 = string_6;
			if (!Class809.bool_6)
			{
				return;
			}
			if (Class111.smethod_51(string_5))
			{
				return;
			}
			if (string_5.Length == 0)
			{
				return;
			}
			if (string_5.IndexOf('\n') >= 0)
			{
				string_5 = string_5.Remove(string_5.IndexOf('\n'));
			}
			if (bool_9)
			{
				if (Class111.list_6.Count > 0)
				{
					Class111.list_6.RemoveRange(0, Class111.int_5);
				}
				Class111.int_5 = 0;
				Class111.list_6.Insert(Class111.int_5, string_5);
			}
			if (!Class809.bool_4)
			{
				Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_NotConnected), string.Empty, Color.get_Red()));
			}
			bool flag = string_5[0] == '/';
			bool flag2 = class.string_0[0] != '#';
			if (string_5.StartsWith("/bb "))
			{
				Class111.smethod_44("/chat BanchoBot", false);
				Class111.smethod_44(string_5.Replace("/bb ", string.Empty), false);
				return;
			}
			Class21 class2 = Class111.list_1.Find(new Predicate<Class21>(class.method_0));
			if (flag)
			{
				int num = string_5.IndexOf(' ');
				string text = (num > 0) ? string_5.Substring(1, num - 1) : string_5.Substring(1);
				string text2 = (num > 0) ? string_5.Substring(num + 1).Trim() : null;
				string key;
				switch (key = text)
				{
				case "ignore":
				{
					if (text2 == null)
					{
						return;
					}
					string[] array = text2.Split(new char[]
					{
						'@'
					});
					if (array.Length < 2)
					{
						array = new string[]
						{
							array[0],
							"cp"
						};
					}
					Class861 class861_ = Class809.smethod_29(array[0]);
					Class111.smethod_48(class861_, array[1]);
					return;
				}
				case "unignore":
				{
					if (text2 == null)
					{
						return;
					}
					Class861 class861_2 = Class809.smethod_29(text2);
					Class111.smethod_47(class861_2);
					return;
				}
				case "np":
					Class111.smethod_56(true, false);
					return;
				case "away":
				{
					Class11 bSerializable_ = new Class11(null, null, text2);
					Class809.smethod_34(Enum3.const_82, bSerializable_);
					return;
				}
				case "watch":
				{
					if (text2 == null)
					{
						return;
					}
					if (Class115.osuModes_1 == OsuModes.Edit || (Class115.osuModes_1 == OsuModes.Play && Class115.bool_25))
					{
						Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_ExitEditorForSpectator), string.Empty, Color.get_Red()));
						return;
					}
					Class861 class3 = Class809.smethod_29(text2);
					if (class3 != null)
					{
						Class858.smethod_5(class3);
						return;
					}
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
					return;
				}
				case "savelog":
					Class111.smethod_52(class.string_0);
					return;
				case "addfriend":
				{
					if (text2 == null)
					{
						return;
					}
					text2 = text2.Replace('_', ' ');
					Class861 class4 = Class809.smethod_29(text2);
					if (class4 == Class115.class861_0)
					{
						Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_FriendAddSelf), string.Empty, Color.get_Red()));
						return;
					}
					if (class4 != null)
					{
						Class111.smethod_43(class4, true);
						return;
					}
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
					return;
				}
				case "delfriend":
				{
					Class861 class5 = Class809.smethod_29(text2);
					if (class5 == Class115.class861_0)
					{
						Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_FriendRemoveSelf), string.Empty, Color.get_Red()));
						return;
					}
					if (class5 != null)
					{
						Class111.smethod_43(class5, false);
						return;
					}
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
					return;
				}
				case "invite":
				{
					Class861 class6 = Class809.smethod_29(text2);
					if (class6 != null && class6.bool_4)
					{
						if (Class72.class10_0 != null)
						{
							Class809.smethod_35(new Class23(Enum3.const_87, new Struct12(class6.int_1), false));
							Class111.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.ChatEngine_UserInvited), class6.Name), string.Empty, Color.get_YellowGreen()));
						}
						return;
					}
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
					return;
				}
				case "chat":
				case "query":
				case "msg":
				{
					if (text2 == null)
					{
						if (Class111.string_1 == null)
						{
							return;
						}
						text2 = Class111.string_1;
					}
					Class861 class7 = Class809.smethod_29(text2);
					if (class7 != null)
					{
						Class111.smethod_49(class7);
						return;
					}
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
					return;
				}
				case "close":
					if (class.string_0[0] == '#')
					{
						return;
					}
					Class111.smethod_10(class.string_0);
					return;
				case "nopm":
					Class341.class606_0.method_1();
					Class809.smethod_33(Enum3.const_99, Class341.class606_0 ? 1 : 0);
					if (Class341.class606_0)
					{
						Class723.smethod_1(Class41.GetString(OsuString.Options_Online_BlockNonFriendPM_Toggle_On), 5000);
						return;
					}
					Class723.smethod_1(Class41.GetString(OsuString.Options_Online_BlockNonFriendPM_Toggle_Off), 5000);
					return;
				case "help":
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_Help1), string.Empty, Color.get_YellowGreen()));
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_Help2), string.Empty, Color.get_LightGray()));
					Class111.list_0.Add(new Class841("/addfriend /delfriend <user>", Class41.GetString(OsuString.ChatEngine_Help3), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/away <message>", Class41.GetString(OsuString.ChatEngine_Help4), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/bb", Class41.GetString(OsuString.ChatEngine_Help5), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/chat <user>", Class41.GetString(OsuString.ChatEngine_Help6), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/clear", Class41.GetString(OsuString.ChatEngine_Help7), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/help", Class41.GetString(OsuString.ChatEngine_Help8), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/ignore <user>[@chp]", Class41.GetString(OsuString.ChatEngine_Help9), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841(string.Empty, "By adding an @ followed by the letters, c, h, and/or p, you may ignore them in chat, highlights, or PMs respectively.", Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/unignore <user>", Class41.GetString(OsuString.ChatEngine_Help10), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/keys", Class41.GetString(OsuString.ChatEngine_Help11), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/me <action>", Class41.GetString(OsuString.ChatEngine_Help12), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/np", Class41.GetString(OsuString.ChatEngine_HelpNowPlaying), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/reply or /r", Class41.GetString(OsuString.ChatEngine_HelpReply), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/savelog", Class41.GetString(OsuString.ChatEngine_HelpSavelog), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/watch <user>", Class41.GetString(OsuString.ChatEngine_HelpSpectate), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/nopm", Class41.GetString(OsuString.ChatEngine_HelpDisablePrivateMessage), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("/invite", Class41.GetString(OsuString.ChatEngine_HelpInvite), Color.get_OrangeRed()));
					return;
				case "clear":
					Class111.smethod_7(Class111.list_0);
					return;
				case "keys":
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_HelpKeys), string.Empty, Color.get_YellowGreen()));
					Class111.list_0.Add(new Class841("PageUp/PageDown", Class41.GetString(OsuString.ChatEngine_HelpPageUpDown), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("Tab", Class41.GetString(OsuString.ChatEngine_HelpAutocomplete), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("F8", Class41.GetString(OsuString.ChatEngine_HelpToggleChat), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("F9", Class41.GetString(OsuString.ChatEngine_HelpToggleOnlineUsers), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("Ctrl-C/V", Class41.GetString(OsuString.ChatEngine_HelpCopyPaste), Color.get_OrangeRed()));
					Class111.list_0.Add(new Class841("Alt+0-9", Class41.GetString(OsuString.ChatEngine_HelpJumpTab), Color.get_OrangeRed()));
					return;
				case "r":
				case "reply":
				{
					string text3 = string_5.Remove(0, string_5.IndexOf(' ') + 1);
					if (Class111.string_1 == null)
					{
						Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_LastPrivateMessageNotExist), string.Empty, Color.get_Red()));
						return;
					}
					if (Class809.smethod_29(Class111.string_1) != null)
					{
						Class11 class8 = new Class11(null, Class111.string_1, text3);
						Class809.smethod_34(Enum3.const_25, class8);
						Class111.smethod_24(class8, true, true);
						return;
					}
					Class111.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.ChatEngine_LastPrivateMessageWentOffline), Class111.string_1), string.Empty, Color.get_Red()));
					return;
				}
				case "me":
					if (string_5.Trim().Length < 5)
					{
						return;
					}
					string_5 = string.Concat(new object[]
					{
						'\u0001',
						"ACTION ",
						string_5.Substring(4),
						'\u0001'
					});
					goto IL_B5D;
				case "j":
				case "join":
				{
					if (text2 == null)
					{
						Class115.smethod_37(new Class102());
						return;
					}
					if (!text2.StartsWith("#"))
					{
						text2 = "#" + text2;
					}
					Class21 class9 = Class111.smethod_8(text2, false, true);
					if (class9 != null)
					{
						Class111.class594_0.method_2(class9);
					}
					return;
				}
				case "p":
				case "part":
					if (class2 != null && !class2.bool_1)
					{
						return;
					}
					if (text2 == null)
					{
						text2 = class.string_0;
					}
					if (!text2.StartsWith("#"))
					{
						text2 = "#" + text2;
					}
					Class111.smethod_10(text2);
					break;

					return;
				}
				return;
			}
			IL_B5D:
			if (flag2 && class.string_0 != Class115.class861_0.Name)
			{
				Class861 class10 = Class809.smethod_29(class.string_0);
				if (class10 != null)
				{
					Class809.smethod_34(Enum3.const_25, new Class11(null, class.string_0, string_5));
					if (Class341.class606_41 && class.string_0 != "BanchoBot")
					{
						Class111.smethod_53(class.string_0, string_5, true);
					}
				}
				else
				{
					Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
				}
			}
			else if (class.string_0 != "#announce")
			{
				Class809.smethod_34(Enum3.const_1, new Class11(null, class.string_0, string_5));
			}
			Class111.smethod_24(new Class11(Class341.class605_20, class.string_0, string_5), true, true);
		}

		// Token: 0x060030E3 RID: 12515
		// RVA: 0x001401D8 File Offset: 0x0013E3D8
		internal static bool smethod_46(Class861 class861_0)
		{
			return class861_0 != null && (Class111.list_9.Contains(class861_0.Name) || Class111.list_10.Contains(class861_0.Name) || Class111.list_11.Contains(class861_0.Name));
		}

		// Token: 0x060030E4 RID: 12516
		// RVA: 0x00140228 File Offset: 0x0013E428
		internal static void smethod_47(Class861 class861_0)
		{
			if (class861_0 == null)
			{
				Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
				return;
			}
			string item = class861_0.Name.Replace(' ', '_').ToLower();
			if (false | Class111.list_9.Remove(item) | Class111.list_10.Remove(item) | Class111.list_11.Remove(item))
			{
				Class111.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.ChatEngine_Unignore), class861_0.Name), string.Empty, Color.get_Yellow()));
				return;
			}
			Class111.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.ChatEngine_UnignoreFailed), class861_0.Name), string.Empty, Color.get_Yellow()));
		}

		// Token: 0x060030E5 RID: 12517
		// RVA: 0x001402F8 File Offset: 0x0013E4F8
		internal static void smethod_48(Class861 class861_0, string string_5)
		{
			if (class861_0 == null)
			{
				Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_UserNotOnline), string.Empty, Color.get_Red()));
				return;
			}
			bool flag = false;
			string text = string.Empty;
			if (string_5.Contains("c") && !Class111.list_9.Contains(class861_0.Name))
			{
				flag = true;
				Class111.list_9.Add(class861_0.Name.Replace(' ', '_').ToLower());
				text += ", chat";
			}
			if (string_5.Contains("h") && !Class111.list_10.Contains(class861_0.Name))
			{
				flag = true;
				Class111.list_10.Add(class861_0.Name.Replace(' ', '_').ToLower());
				text += ", highlights";
			}
			if (string_5.Contains("p") && !Class111.list_11.Contains(class861_0.Name))
			{
				flag = true;
				Class111.list_11.Add(class861_0.Name.Replace(' ', '_').ToLower());
				text += ", PMs";
			}
			if (flag)
			{
				Class111.list_0.Add(new Class841(string.Format("You will no longer hear {0}.", class861_0.Name), " {" + text.Substring(2) + "}", Color.get_Yellow()));
				return;
			}
			Class111.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.ChatEngine_IgnoreFailed), class861_0.Name), string.Empty, Color.get_Yellow()));
		}

		// Token: 0x060030E6 RID: 12518
		// RVA: 0x00140484 File Offset: 0x0013E684
		internal static void smethod_49(Class861 class861_0)
		{
			if (class861_0.int_1 == 2)
			{
				Class115.smethod_90("http://osu.ppy.sh/p/doyoureallywanttoaskpeppy", null);
				return;
			}
			Class21 class = Class111.smethod_8(class861_0.Name, true, false);
			if (class != null)
			{
				class.method_0(true);
				Class111.class594_0.method_2(class);
				Class111.list_0.Add(new Class841(Class41.GetString(OsuString.ChatEngine_CloseTab), string.Empty, Color.get_Wheat()));
			}
		}

		// Token: 0x060030A9 RID: 12457
		// RVA: 0x0013C05C File Offset: 0x0013A25C
		internal static void smethod_5(PlayModes playModes_0, bool bool_9)
		{
			Class531 class;
			switch (playModes_0)
			{
			case PlayModes.Taiko:
				class = Class111.class531_10;
				break;
			case PlayModes.CatchTheBeat:
				class = Class111.class531_9;
				break;
			case PlayModes.OsuMania:
				class = Class111.class531_12;
				break;
			default:
				class = Class111.class531_11;
				break;
			}
			Class111.bool_7[(int)playModes_0] = bool_9;
			if (bool_9)
			{
				class.method_39(new Color(255, 255, 255, 255), 100, false, Enum70.const_0);
			}
			else
			{
				class.method_39(new Color(128, 128, 128, 255), 100, false, Enum70.const_0);
			}
			Class111.int_18 = 0;
		}

		// Token: 0x060030E7 RID: 12519
		// RVA: 0x0002432B File Offset: 0x0002252B
		internal static void smethod_50()
		{
			Class111.int_19 = 0;
			Class111.class110_1.int_1 = -1;
		}

		// Token: 0x060030E8 RID: 12520
		// RVA: 0x001404F0 File Offset: 0x0013E6F0
		private static bool smethod_51(string string_5)
		{
			if (Class115.osuModes_1 == OsuModes.Play && !Class802.smethod_0())
			{
				int length = string_5.Length;
				int num = 0;
				if (Class111.string_4 == null)
				{
					Class111.string_4 = new string[9];
					switch (Class62.Mode)
					{
					case PlayModes.Osu:
						Class111.string_4[0] = Class795.smethod_3(Bindings.OsuLeft).ToString();
						Class111.string_4[1] = Class795.smethod_3(Bindings.OsuRight).ToString();
						break;
					case PlayModes.Taiko:
						Class111.string_4[2] = Class795.smethod_3(Bindings.TaikoInnerLeft).ToString();
						Class111.string_4[3] = Class795.smethod_3(Bindings.TaikoInnerRight).ToString();
						Class111.string_4[4] = Class795.smethod_3(Bindings.TaikoOuterLeft).ToString();
						Class111.string_4[5] = Class795.smethod_3(Bindings.TaikoOuterRight).ToString();
						break;
					case PlayModes.CatchTheBeat:
						Class111.string_4[6] = Class795.smethod_3(Bindings.FruitsDash).ToString();
						Class111.string_4[7] = Class795.smethod_3(Bindings.FruitsLeft).ToString();
						Class111.string_4[8] = Class795.smethod_3(Bindings.FruitsRight).ToString();
						break;
					}
				}
				int i = 0;
				IL_16B:
				while (i < length)
				{
					for (int j = 0; j < 9; j++)
					{
						if (char.ToUpper(string_5[i]).ToString() == Class111.string_4[j])
						{
							num++;
							IL_167:
							i++;
							goto IL_16B;
						}
					}
					goto IL_167;
				}
				return num > length / 2;
			}
			return false;
		}

		// Token: 0x060030E9 RID: 12521
		// RVA: 0x00140674 File Offset: 0x0013E874
		private static void smethod_52(string string_5)
		{
			Class111.Class833 class = new Class111.Class833();
			if (!Directory.Exists("Chat"))
			{
				Directory.CreateDirectory("Chat");
			}
			class.string_0 = string.Format("Chat\\{0}-{1:yyyyMMdd-hhmmss}.txt", Regex.Replace(string_5, string.Format("[{0}]", Regex.Escape(new string(Path.GetInvalidFileNameChars()))), "_"), DateTime.Now);
			using (StreamWriter streamWriter = File.CreateText(class.string_0))
			{
				string text = string.Empty;
				foreach (Class841 current in Class111.list_0)
				{
					if (current.class40_0 != null)
					{
						string text2 = string.Format("{0} {1}", current.string_1, current.class40_0.string_1);
						if (!(text2 == text))
						{
							text = text2;
							streamWriter.WriteLine(text);
						}
					}
				}
			}
			Class723.smethod_5(string.Format(Class41.GetString(OsuString.ChatEngine_ExportChat), class.string_0), Color.get_YellowGreen(), 3000, new VoidDelegate(class.method_0));
		}

		// Token: 0x060030EA RID: 12522
		// RVA: 0x001407B4 File Offset: 0x0013E9B4
		internal static void smethod_53(string string_5, string string_6, bool bool_9)
		{
			if (!Directory.Exists("Chat"))
			{
				Directory.CreateDirectory("Chat");
			}
			string path = string.Format("Chat\\{0}.txt", Regex.Replace(string_5, string.Format("[{0}]", Regex.Escape(new string(Path.GetInvalidFileNameChars()))), "_"));
			string contents;
			if (string_6.Contains(" *"))
			{
				contents = string.Format("{0:yyyy-MM-dd HH:mm} {1}" + '\r' + '\n', DateTime.Now, string_6);
			}
			else
			{
				contents = string.Format("{0:yyyy-MM-dd HH:mm} {1}: {2}" + '\r' + '\n', DateTime.Now, bool_9 ? Class115.class861_0.Name : string_5, string_6);
			}
			File.AppendAllText(path, contents);
		}

		// Token: 0x060030EB RID: 12523
		// RVA: 0x00140880 File Offset: 0x0013EA80
		internal static string[] smethod_54()
		{
			string[] array = new string[3];
			if (Class466.Current != null)
			{
				array[0] = Class466.Current.string_12 + ((Class115.osuModes_1 == OsuModes.Play || Class115.osuModes_1 == OsuModes.Edit) ? (" [" + Class466.Current.string_14 + "]") : string.Empty);
			}
			array[1] = string.Empty;
			array[2] = "listening to";
			switch (Class115.osuModes_1)
			{
			case OsuModes.Edit:
				array[2] = "editing";
				break;
			case OsuModes.Play:
				switch (Class62.Mode)
				{
				case PlayModes.Taiko:
				{
					string[] array2;
					(array2 = array)[1] = array2[1] + " <Taiko>";
					break;
				}
				case PlayModes.CatchTheBeat:
				{
					string[] array3;
					(array3 = array)[1] = array3[1] + " <CatchTheBeat>";
					break;
				}
				case PlayModes.OsuMania:
				{
					string[] array4;
					(array4 = array)[1] = array4[1] + " <osu!mania>";
					break;
				}
				}
				if (Class62.class512_0 != null)
				{
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Easy))
					{
						string[] array5;
						(array5 = array)[1] = array5[1] + " -Easy";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.NoFail))
					{
						string[] array6;
						(array6 = array)[1] = array6[1] + " -NoFail";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden))
					{
						string[] array7;
						(array7 = array)[1] = array7[1] + " +Hidden";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Perfect))
					{
						string[] array8;
						(array8 = array)[1] = array8[1] + " +Perfect";
					}
					else if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.SuddenDeath))
					{
						string[] array9;
						(array9 = array)[1] = array9[1] + " +SuddenDeath";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HardRock))
					{
						string[] array10;
						(array10 = array)[1] = array10[1] + " +HardRock";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Nightcore))
					{
						string[] array11;
						(array11 = array)[1] = array11[1] + " +Nightcore";
					}
					else if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.DoubleTime))
					{
						string[] array12;
						(array12 = array)[1] = array12[1] + " +DoubleTime";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
					{
						string[] array13;
						(array13 = array)[1] = array13[1] + " -HalfTime";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
					{
						string[] array14;
						(array14 = array)[1] = array14[1] + " +Flashlight";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.SpunOut))
					{
						string[] array15;
						(array15 = array)[1] = array15[1] + " -SpunOut";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Cinema))
					{
						string[] array16;
						(array16 = array)[1] = array16[1] + " |Cinema|";
					}
					else if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Autoplay))
					{
						string[] array17;
						(array17 = array)[1] = array17[1] + " |Autoplay|";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Target))
					{
						string[] array18;
						(array18 = array)[1] = array18[1] + " ~Target~";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax))
					{
						string[] array19;
						(array19 = array)[1] = array19[1] + " ~Relax~";
					}
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax2))
					{
						string[] array20;
						(array20 = array)[1] = array20[1] + " ~Autopilot~";
					}
					if (Class62.class512_0.playModes_0 == PlayModes.OsuMania)
					{
						string[] array21;
						string[] expr_3DD = array21 = array;
						int arg_430_1 = 1;
						object obj = array21[1];
						expr_3DD[arg_430_1] = string.Concat(new object[]
						{
							obj,
							" |",
							Class421.smethod_3(Class466.Current, Class62.class512_0.class623_0),
							"K|"
						});
					}
				}
				array[2] = (Class802.smethod_0() ? "watching" : "playing");
				break;
			}
			return array;
		}

		// Token: 0x060030EC RID: 12524
		// RVA: 0x00140CD8 File Offset: 0x0013EED8
		internal static string smethod_55(string[] string_5)
		{
			if (Class466.Current == null)
			{
				return null;
			}
			if (string_5 == null)
			{
				string_5 = Class111.smethod_54();
			}
			string text = string_5[0];
			string text2 = string_5[1];
			string str = string_5[2];
			string str2;
			if (Class466.Current.int_2 > 0)
			{
				str2 = string.Format("[{0}/b/{1} {2}]{3}", new object[]
				{
					"http://osu.ppy.sh",
					Class466.Current.int_2,
					text,
					text2
				});
			}
			else if (Class466.Current.int_3 > 0)
			{
				str2 = string.Format("[{0}/s/{1} {2}]{3}", new object[]
				{
					"http://osu.ppy.sh",
					Class466.Current.int_3,
					text,
					text2
				});
			}
			else
			{
				str2 = text + text2;
			}
			return "/me is " + str + " " + str2;
		}

		// Token: 0x060030ED RID: 12525
		// RVA: 0x00140DB4 File Offset: 0x0013EFB4
		internal static void smethod_56(bool bool_9, bool bool_10)
		{
			if (Class466.Current == null)
			{
				return;
			}
			string[] array = Class111.smethod_54();
			Class786.smethod_1(true, array[2], Class466.Current.Title, Class466.Current.Artist, (Class115.osuModes_1 == OsuModes.Play) ? Class466.Current.string_14 : string.Empty);
			if (bool_9 && (Class111.string_2 != array[0] || Class115.int_1 - Class111.int_12 > 60000))
			{
				Class111.string_2 = array[0];
				Class111.smethod_44(Class111.smethod_55(array), false);
				Class111.int_12 = Class115.int_1;
			}
		}

		// Token: 0x060030EE RID: 12526
		// RVA: 0x00140E48 File Offset: 0x0013F048
		internal static void smethod_57()
		{
			if (Class111.list_6.Count == 0)
			{
				return;
			}
			if (Class802.class799_0.Text.Length > 0)
			{
				if (Class111.int_5 == 0 && Class802.class799_0.Text != Class111.list_6[Class111.int_5])
				{
					Class111.list_6.Insert(Class111.int_5, Class802.class799_0.Text);
					Class111.int_5++;
				}
				else
				{
					Class111.list_6[Class111.int_5] = Class802.class799_0.Text;
				}
			}
			else
			{
				Class111.int_5 = Math.Max(-1, Class111.int_5 - 1);
			}
			Class111.int_5 = Math.Max(0, Math.Min(Class111.list_6.Count - 1, Class111.int_5 + 1));
			if (Class111.int_5 >= Class111.list_6.Count)
			{
				return;
			}
			if (Class111.list_6[Class111.int_5] != Class802.class799_0.Text)
			{
				Class802.smethod_7(Class111.list_6[Class111.int_5]);
			}
		}

		// Token: 0x060030EF RID: 12527
		// RVA: 0x00140F58 File Offset: 0x0013F158
		internal static void smethod_58()
		{
			if (Class802.class799_0.Text.Length > 0)
			{
				if (Class111.int_5 == 0 && (Class111.list_6.Count == 0 || Class802.class799_0.Text != Class111.list_6[Class111.int_5]))
				{
					Class111.list_6.Insert(Class111.int_5, Class802.class799_0.Text);
				}
				else
				{
					Class111.list_6[Class111.int_5] = Class802.class799_0.Text;
				}
			}
			if (Class111.int_5 == 0)
			{
				Class802.smethod_7(string.Empty);
				return;
			}
			Class111.int_5 = Math.Max(0, Class111.int_5 - 1);
			if (Class111.int_5 >= Class111.list_6.Count)
			{
				return;
			}
			if (Class111.list_6[Class111.int_5] != Class802.class799_0.Text)
			{
				Class802.smethod_7(Class111.list_6[Class111.int_5]);
			}
		}

		// Token: 0x060030F0 RID: 12528
		// RVA: 0x00141048 File Offset: 0x0013F248
		public static void smethod_59(int int_20)
		{
			lock (Class809.list_1)
			{
				Class861 class = Class809.smethod_28(int_20, false);
				if (class == null)
				{
					Class809.smethod_39(class = new Class861(int_20, null));
				}
				if (Class111.list_4.Contains(class.int_1))
				{
					class.method_18(true, false);
				}
			}
		}

		// Token: 0x060030AE RID: 12462
		// RVA: 0x0013C134 File Offset: 0x0013A334
		internal static void smethod_6(List<Class841> list_16)
		{
			if (list_16 == null)
			{
				return;
			}
			foreach (Class841 current in list_16)
			{
				if (current.method_2())
				{
					current.method_0().Dispose();
					current.method_1(null);
				}
			}
		}

		// Token: 0x060030F1 RID: 12529
		// RVA: 0x001410B0 File Offset: 0x0013F2B0
		public static void smethod_60(Class17 class17_0)
		{
			Class856.smethod_4(class17_0);
			lock (Class809.list_1)
			{
				Class861 class = Class809.smethod_28(class17_0.int_1, true);
				if (class != null)
				{
					class.method_5(class17_0);
				}
				else
				{
					Class809.smethod_39(new Class861(class17_0));
				}
			}
		}

		// Token: 0x060030F2 RID: 12530
		// RVA: 0x0014110C File Offset: 0x0013F30C
		public static void smethod_61(Class861 class861_0)
		{
			if (Class111.list_4.Contains(class861_0.int_1))
			{
				class861_0.bool_3 = true;
				Class111.int_3 = Class115.int_1;
				if (Class111.list_3.Contains(class861_0.Name))
				{
					Class111.list_3.Remove(class861_0.Name);
					return;
				}
				if (!Class111.list_2.Contains(class861_0.Name))
				{
					Class111.list_2.Add(class861_0.Name);
				}
			}
		}

		// Token: 0x060030F3 RID: 12531
		// RVA: 0x00141184 File Offset: 0x0013F384
		public static void smethod_62(Class19 class19_0)
		{
			Class861 class = Class809.smethod_28(class19_0.int_2, true);
			if (class != null)
			{
				class.method_6(class19_0);
			}
		}

		// Token: 0x060030F4 RID: 12532
		// RVA: 0x001411A8 File Offset: 0x0013F3A8
		public static void smethod_63(int int_20, Enum1 enum1_0)
		{
			Class861 class = Class809.smethod_28(int_20, false);
			if (class != null)
			{
				switch (enum1_0)
				{
				case Enum1.const_0:
					if (class.bool_3)
					{
						Class111.int_4 = Class115.int_1;
						if (Class111.list_2.Contains(class.Name))
						{
							Class111.list_2.Remove(class.Name);
						}
						if (!Class111.list_3.Contains(class.Name))
						{
							Class111.list_3.Add(class.Name);
						}
					}
					if (class.list_0 != null)
					{
						foreach (Class531 current in class.list_0)
						{
							if (class.bool_7)
							{
								current.method_16(500, Enum70.const_0);
							}
							else
							{
								current.float_3 = 0f;
							}
							current.bool_0 = false;
						}
					}
					Class809.smethod_40(class);
					break;
				case Enum1.const_1:
					class.bool_4 = true;
					break;
				case Enum1.const_2:
					class.bool_4 = false;
					break;
				}
				if ((enum1_0 == Enum1.const_0 || enum1_0 == Enum1.const_2) && Class858.class861_0 == class)
				{
					lock (Class858.object_0)
					{
						Class858.smethod_4(true);
					}
				}
			}
		}

		// Token: 0x060030F5 RID: 12533
		// RVA: 0x001412F4 File Offset: 0x0013F4F4
		public static void smethod_64()
		{
			Class111.class110_1.method_29(true);
			lock (Class809.list_1)
			{
				Class809.list_1.Clear();
			}
			Class809.int_15 = 0;
			Class809.dictionary_1.Clear();
			Class111.int_18 = 0;
		}

		// Token: 0x060030F6 RID: 12534
		// RVA: 0x00141354 File Offset: 0x0013F554
		public static void smethod_65()
		{
			Class21[] array = new Class21[Class111.list_1.Count];
			Class111.list_1.CopyTo(array, 0);
			for (int i = array.Length - 1; i >= 0; i--)
			{
				Class21 class = array[i];
				if (class.string_0 == "#multiplayer" || class.string_0 == "#spectator")
				{
					Class111.class594_0.Remove(class);
					Class111.list_1.Remove(class);
				}
			}
		}

		// Token: 0x060030F7 RID: 12535
		// RVA: 0x0002433E File Offset: 0x0002253E
		public static void smethod_66(List<int> list_16)
		{
			Class111.list_4.AddRange(list_16);
		}

		// Token: 0x060030F8 RID: 12536
		// RVA: 0x001413CC File Offset: 0x0013F5CC
		public static void smethod_67()
		{
			Class111.list_7.Clear();
			string[] array = Class341.class605_13.Value.Split(new char[]
			{
				' '
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text.Length > 0 && !Class111.list_7.Contains(text))
				{
					Class111.list_7.Add(text);
				}
			}
		}

		// Token: 0x060030F9 RID: 12537
		// RVA: 0x00141434 File Offset: 0x0013F634
		public static void smethod_68()
		{
			Class111.list_9.Clear();
			Class111.list_10.Clear();
			Class111.list_11.Clear();
			string[] array = Class341.class605_14.Value.Split(new char[]
			{
				' '
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text.Length != 0)
				{
					string[] array2 = text.Split(new char[]
					{
						'@'
					});
					if (array2.Length < 2)
					{
						array2 = new string[]
						{
							array2[0],
							"cp"
						};
					}
					if (array2[1].Contains("c") && !Class111.list_9.Contains(array2[0]))
					{
						Class111.list_9.Add(array2[0].ToLower());
					}
					if (array2[1].Contains("h") && !Class111.list_10.Contains(array2[0]))
					{
						Class111.list_10.Add(array2[0].ToLower());
					}
					if (array2[1].Contains("p") && !Class111.list_11.Contains(array2[0]))
					{
						Class111.list_11.Add(array2[0].ToLower());
					}
				}
			}
		}

		// Token: 0x060030FA RID: 12538
		// RVA: 0x0014156C File Offset: 0x0013F76C
		public static void smethod_69()
		{
			Class111.smethod_67();
			Class111.list_15.Clear();
			string[] array = Class341.class605_9.Value.Split(new char[]
			{
				' '
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text.Length > 0 && !Class111.list_15.Contains(text))
				{
					Class111.list_15.Add(text);
				}
			}
			if (!Class111.list_15.Contains("#osu"))
			{
				Class111.list_15.Insert(0, "#osu");
			}
			Class111.smethod_68();
		}

		// Token: 0x060030AF RID: 12463
		// RVA: 0x000241E9 File Offset: 0x000223E9
		internal static void smethod_7(List<Class841> list_16)
		{
			Class111.smethod_6(list_16);
			list_16.Clear();
			if (list_16 == Class111.list_0)
			{
				Class111.smethod_38();
			}
		}

		// Token: 0x060030FC RID: 12540
		// RVA: 0x00141600 File Offset: 0x0013F800
		internal static void smethod_70()
		{
			Class111.class531_7.vector2_2 = new Vector2((float)Class115.smethod_43() * 1.6f, 22f);
			Class111.class594_0.method_1((int)((float)Class115.int_22 / (74f * Class115.float_4)));
			Class111.class531_8.vector2_2 = new Vector2((float)Class115.smethod_43(), 320f) * 1.6f;
			Class111.class533_1.vector2_9 = new Vector2((float)Class115.smethod_43(), 13.5f);
			Class111.class533_1.vector2_9 = new Vector2((float)Class115.smethod_43(), 13.5f);
			Class111.class531_4.vector2_2 = new Vector2((float)Class115.smethod_43(), 160f) * 1.6f;
			Class111.smethod_38();
		}

		// Token: 0x060030FD RID: 12541
		// RVA: 0x001416CC File Offset: 0x0013F8CC
		internal static void smethod_71()
		{
			List<Class750> list = new List<Class750>();
			using (List<string>.Enumerator enumerator = Class111.list_15.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class111.Class834 class = new Class111.Class834();
					class.string_0 = enumerator.Current;
					List<Class750> arg_42_0 = Class111.class594_0.list_1;
					Predicate<Class750> match = new Predicate<Class750>(class.method_0);
					Class750 class2 = arg_42_0.Find(match);
					if (class2 != null)
					{
						list.Add(class2);
					}
				}
			}
			foreach (Class750 current in Class111.class594_0.list_1)
			{
				if (!list.Contains(current))
				{
					list.Add(current);
				}
			}
			Class111.class594_0.list_1 = list;
			Class111.class594_0.vmethod_1();
		}

		// Token: 0x060030FE RID: 12542
		// RVA: 0x001417C0 File Offset: 0x0013F9C0
		internal static void smethod_72(int int_20)
		{
			Predicate<Class841> predicate = null;
			Class111.Class835 class = new Class111.Class835();
			class.int_0 = int_20;
			foreach (Class21 current in Class111.list_1)
			{
				if (current.list_0 == Class111.list_0)
				{
					for (int i = 0; i < Class111.list_0.Count; i++)
					{
						Class841 class2 = Class111.list_0[i];
						if (class2.class861_0 != null && class2.class861_0.int_1 == class.int_0)
						{
							Class111.smethod_39(i);
							i--;
						}
					}
				}
				else
				{
					List<Class841> arg_96_0 = current.list_0;
					if (predicate == null)
					{
						predicate = new Predicate<Class841>(class.method_0);
					}
					arg_96_0.RemoveAll(predicate);
				}
			}
		}

		// Token: 0x060030FF RID: 12543
		// RVA: 0x000241CE File Offset: 0x000223CE
		[CompilerGenerated]
		private static void smethod_73(Class754 class754_1, bool bool_9)
		{
			Class111.smethod_50();
		}

		// Token: 0x06003100 RID: 12544
		// RVA: 0x00024368 File Offset: 0x00022568
		[CompilerGenerated]
		private static void smethod_74(Class531 class531_13)
		{
			class531_13.object_0 = "user";
			class531_13.float_3 = 0f;
		}

		// Token: 0x06003101 RID: 12545
		// RVA: 0x00024380 File Offset: 0x00022580
		[CompilerGenerated]
		private static void smethod_75(Class531 class531_13)
		{
			Class111.list_8.Add(class531_13);
			class531_13.vector2_1.Y = class531_13.vector2_0.Y;
			if (!Class111.bool_2)
			{
				class531_13.float_3 = 0f;
			}
		}

		// Token: 0x06003102 RID: 12546
		// RVA: 0x000243B5 File Offset: 0x000225B5
		[CompilerGenerated]
		private static int smethod_76(Class861 class861_0, Class861 class861_1)
		{
			return class861_0.Name.CompareTo(class861_1.Name);
		}

		// Token: 0x06003103 RID: 12547
		// RVA: 0x00141898 File Offset: 0x0013FA98
		[CompilerGenerated]
		private static int smethod_77(Class861 class861_0, Class861 class861_1)
		{
			int num = 0;
			if (class861_0.string_5 != null && class861_1.string_5 != null)
			{
				num = class861_0.string_5.CompareTo(class861_1.string_5);
			}
			if (num == 0)
			{
				return class861_0.Name.CompareTo(class861_1.Name);
			}
			return num;
		}

		// Token: 0x06003104 RID: 12548
		// RVA: 0x001418E0 File Offset: 0x0013FAE0
		[CompilerGenerated]
		private static int smethod_78(Class861 class861_0, Class861 class861_1)
		{
			int num = class861_0.int_4.CompareTo(class861_1.int_4);
			if (num == 0)
			{
				return class861_0.Name.CompareTo(class861_1.Name);
			}
			return num;
		}

		// Token: 0x06003105 RID: 12549
		// RVA: 0x00141918 File Offset: 0x0013FB18
		[CompilerGenerated]
		private static int smethod_79(Class861 class861_0, Class861 class861_1)
		{
			if (!class861_0.bool_4 && !class861_1.bool_4)
			{
				return class861_0.Name.CompareTo(class861_1.Name);
			}
			if (!class861_0.bool_4)
			{
				return 1;
			}
			if (!class861_1.bool_4)
			{
				return -1;
			}
			int num = class861_0.int_3.CompareTo(class861_1.int_3);
			if (class861_0.int_3 == 0 && class861_1.int_3 == 0)
			{
				class861_0.Name.CompareTo(class861_1.Name);
			}
			if (class861_0.int_3 == 0 && class861_1.int_3 == 0)
			{
				return class861_0.Name.CompareTo(class861_1.Name);
			}
			if (class861_0.int_3 == 0)
			{
				return 1;
			}
			if (class861_1.int_3 == 0)
			{
				return -1;
			}
			if (num == 0)
			{
				return class861_0.Name.CompareTo(class861_1.Name);
			}
			return num;
		}

		// Token: 0x060030B0 RID: 12464
		// RVA: 0x00024204 File Offset: 0x00022404
		internal static Class21 smethod_8(string string_5, bool bool_9, bool bool_10)
		{
			return Class111.smethod_9(new Class21(string_5, string_5 != "#osu" && string_5 != "#multiplayer" && string_5 != "#spectator"), bool_9, bool_10);
		}

		// Token: 0x06003106 RID: 12550
		// RVA: 0x000243C8 File Offset: 0x000225C8
		[CompilerGenerated]
		private static void smethod_80()
		{
			Class111.smethod_21(false);
		}

		// Token: 0x06003107 RID: 12551
		// RVA: 0x0001B778 File Offset: 0x00019978
		[CompilerGenerated]
		private static void smethod_81(Class531 class531_13)
		{
			class531_13.method_8(true);
		}

		// Token: 0x06003108 RID: 12552
		// RVA: 0x000243D0 File Offset: 0x000225D0
		[CompilerGenerated]
		private static void smethod_82(Class531 class531_13)
		{
			class531_13.method_8(false);
		}

		// Token: 0x06003109 RID: 12553
		// RVA: 0x0001B778 File Offset: 0x00019978
		[CompilerGenerated]
		private static void smethod_83(Class531 class531_13)
		{
			class531_13.method_8(true);
		}

		// Token: 0x0600310A RID: 12554
		// RVA: 0x000243D9 File Offset: 0x000225D9
		[CompilerGenerated]
		private static void smethod_84(Class531 class531_13)
		{
			Class111.list_8.Remove(class531_13);
			Class111.class911_0.Remove(class531_13);
			class531_13.Dispose();
		}

		// Token: 0x0600310B RID: 12555
		// RVA: 0x000243F8 File Offset: 0x000225F8
		[CompilerGenerated]
		private static bool smethod_85(Class861 class861_0)
		{
			return !class861_0.bool_10;
		}

		// Token: 0x0600310C RID: 12556
		// RVA: 0x00024403 File Offset: 0x00022603
		[CompilerGenerated]
		private static void smethod_86()
		{
			Class115.form_0.WindowState = FormWindowState.Normal;
		}

		// Token: 0x0600310D RID: 12557
		// RVA: 0x00024410 File Offset: 0x00022610
		[CompilerGenerated]
		private static void smethod_87(object sender, EventArgs e)
		{
			Class723.smethod_4(Class41.GetString(OsuString.ChatEngine_CouldntFindThisBeatmap));
		}

		// Token: 0x0600310E RID: 12558
		// RVA: 0x00024410 File Offset: 0x00022610
		[CompilerGenerated]
		private static void smethod_88(object sender, EventArgs e)
		{
			Class723.smethod_4(Class41.GetString(OsuString.ChatEngine_CouldntFindThisBeatmap));
		}

		// Token: 0x060030B1 RID: 12465
		// RVA: 0x0013C19C File Offset: 0x0013A39C
		internal static Class21 smethod_9(Class21 class21_1, bool bool_9, bool bool_10)
		{
			Class111.Class821 class = new Class111.Class821();
			class.class21_0 = class21_1;
			if (class.class21_0.string_0 == "#spectator" && !Class341.class606_55 && Class858.class861_0 == null)
			{
				return null;
			}
			bool_10 |= (Class111.list_15.Contains(class.class21_0.string_0) && !bool_9);
			Class21 class2 = Class111.list_1.Find(new Predicate<Class21>(class.method_0));
			if (class2 == null)
			{
				class2 = class.class21_0;
				class2.bool_0 = bool_9;
				Class111.list_1.Add(class2);
			}
			else if (!string.IsNullOrEmpty(class.class21_0.string_1) || class.class21_0.vmethod_0() > 0)
			{
				class2.string_1 = class.class21_0.string_1;
				class2.vmethod_1(class.class21_0.vmethod_0());
			}
			if (class2.string_0[0] != '#')
			{
				class2.bool_2 = true;
			}
			class2.bool_1 = (class2.string_0 != "#multiplayer");
			if (!(class2.string_0 == "#multiplayer") && !(class2.string_0 == "#spectator"))
			{
				if (bool_10)
				{
					if (!class2.Join(false))
					{
						return null;
					}
					Class111.class594_0.Add(class2.string_0, class2, false);
				}
				else if (bool_9)
				{
					Class111.class594_0.Add(class2.string_0, class2, false);
				}
			}
			else
			{
				class2.bool_2 = true;
				Class111.class594_0.Add(class2.string_0, class2, true);
				Class111.class594_0.method_2(class2);
			}
			List<Class531> arg_1B1_0 = Class111.class594_0.list_0;
			if (Class111.action_1 == null)
			{
				Class111.action_1 = new Action<Class531>(Class111.smethod_75);
			}
			arg_1B1_0.ForEach(Class111.action_1);
			if (!Class111.bool_5 && Class341.class605_10 == class2.string_0)
			{
				Class111.class594_0.method_2(class2);
				Class111.bool_5 = true;
			}
			return class2;
		}
	}
}
