using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns24;
using ns26;
using ns27;
using ns29;
using ns30;
using ns40;
using ns5;
using ns6;
using ns64;
using ns74;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns9;
using ns90;
using osu;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000642 RID: 1602
	internal sealed class Class112 : Class54
	{
		// Token: 0x02000643 RID: 1603
		[CompilerGenerated]
		private sealed class Class846
		{
			// Token: 0x04002D3A RID: 11578
			public int int_0;

			// Token: 0x06003187 RID: 12679
			// RVA: 0x000249CF File Offset: 0x00022BCF
			public void method_0(Class530 class530_0)
			{
				class530_0.method_19(new Vector2(class530_0.vector2_0.X, class530_0.vector2_0.Y), this.int_0, Enum70.const_1);
			}
		}

		// Token: 0x02000644 RID: 1604
		[CompilerGenerated]
		private sealed class Class847
		{
			// Token: 0x02000645 RID: 1605
			private sealed class Class848
			{
				// Token: 0x04002D3F RID: 11583
				public byte[] byte_0;

				// Token: 0x04002D3E RID: 11582
				public Class112.Class847 class847_0;

				// Token: 0x06003192 RID: 12690
				// RVA: 0x001450BC File Offset: 0x001432BC
				public void method_0()
				{
					this.class847_0.class531_0.vmethod_7(Class731.smethod_6(this.byte_0));
					Class885.smethod_35(this.class847_0.class531_0.vmethod_6());
					this.class847_0.class531_0.float_3 = 0f;
					if (Class112.class335_0 == null)
					{
						this.class847_0.class531_0.method_25(0.6f, 500, Enum70.const_1);
						this.class847_0.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.7f, 1.1f, Class115.int_1, Class115.int_1 + 300, Enum70.const_1));
						this.class847_0.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 1.2f, Class115.int_1 + 300, Class115.int_1 + 5300, Enum70.const_0));
					}
				}
			}

			// Token: 0x02000646 RID: 1606
			private sealed class Class849
			{
				// Token: 0x04002D41 RID: 11585
				public byte[] byte_0;

				// Token: 0x04002D40 RID: 11584
				public Class112.Class847 class847_0;

				// Token: 0x04002D42 RID: 11586
				private static Predicate<Class746> predicate_0;

				// Token: 0x06003194 RID: 12692
				// RVA: 0x001451A8 File Offset: 0x001433A8
				public void method_0()
				{
					if (Class112.class690_0 != this.class847_0.class690_0)
					{
						return;
					}
					Class112.bool_1 = (Class331.enum100_0 == Enum100.const_1);
					if (Class112.bool_1 && Class115.osuModes_1 != OsuModes.OnlineSelection && Class115.osuModes_1 != OsuModes.Play)
					{
						Class331.bool_1 = false;
						Class331.smethod_88();
					}
					if (Class112.class335_0 != null)
					{
						Class112.class335_0.vmethod_7();
					}
					Class112.class335_0 = Class331.smethod_58(this.byte_0, false);
					Class112.class335_0.vmethod_6(true);
					this.class847_0.class531_0.method_14(500, Enum70.const_0);
					List<Class746> arg_B4_0 = this.class847_0.class531_0.class26_0;
					if (Class112.Class847.Class849.predicate_0 == null)
					{
						Class112.Class847.Class849.predicate_0 = new Predicate<Class746>(Class112.Class847.Class849.smethod_0);
					}
					arg_B4_0.RemoveAll(Class112.Class847.Class849.predicate_0);
					this.class847_0.class531_0.class26_0.Add(new Class746(TransformationType.Scale, this.class847_0.class531_0.float_2, 1.25f, Class115.int_1, Class115.int_1 + 300, Enum70.const_1));
					this.class847_0.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1.25f, 1.2f, Class115.int_1 + 300, Class115.int_1 + 700, Enum70.const_2));
				}

				// Token: 0x06003195 RID: 12693
				// RVA: 0x00018A5A File Offset: 0x00016C5A
				private static bool smethod_0(Class746 class746_0)
				{
					return class746_0.transformationType_0 == TransformationType.Scale;
				}
			}

			// Token: 0x04002D3C RID: 11580
			public Class112 class112_0;

			// Token: 0x04002D3B RID: 11579
			public Class531 class531_0;

			// Token: 0x04002D3D RID: 11581
			public Class690 class690_0;

			// Token: 0x06003189 RID: 12681
			// RVA: 0x00144FEC File Offset: 0x001431EC
			public void method_0(byte[] byte_0, Exception exception_0)
			{
				Class112.Class847.Class848 class = new Class112.Class847.Class848();
				class.class847_0 = this;
				class.byte_0 = byte_0;
				if (exception_0 == null && class.byte_0.Length != 0)
				{
					Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
					return;
				}
			}

			// Token: 0x0600318A RID: 12682
			// RVA: 0x00145034 File Offset: 0x00143234
			public void method_1(byte[] byte_0, Exception exception_0)
			{
				Class112.Class847.Class849 class = new Class112.Class847.Class849();
				class.class847_0 = this;
				class.byte_0 = byte_0;
				if (exception_0 == null && class.byte_0.Length != 0)
				{
					Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
					return;
				}
			}

			// Token: 0x0600318B RID: 12683
			// RVA: 0x0014507C File Offset: 0x0014327C
			public void method_2(object sender, EventArgs e)
			{
				if (Class72.class10_0 == null && Class62.class62_0 == null)
				{
					Class296 class296_ = Class466.smethod_33(this.class690_0.int_0);
					Class466.smethod_21(class296_);
					Class115.smethod_70(OsuModes.SelectPlay, true);
					Class112.smethod_0();
					return;
				}
			}

			// Token: 0x0600318C RID: 12684
			// RVA: 0x000249FA File Offset: 0x00022BFA
			public void method_3(object sender, EventArgs e)
			{
				this.class690_0.method_3(false);
				Class112.smethod_0();
			}

			// Token: 0x0600318D RID: 12685
			// RVA: 0x00024A0D File Offset: 0x00022C0D
			public void method_4(object sender, EventArgs e)
			{
				this.class690_0.method_3(true);
				Class112.smethod_0();
			}

			// Token: 0x0600318E RID: 12686
			// RVA: 0x00024A20 File Offset: 0x00022C20
			public void method_5(object sender, EventArgs e)
			{
				Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/p/{0}", this.class690_0.int_2), null);
			}

			// Token: 0x0600318F RID: 12687
			// RVA: 0x00024A42 File Offset: 0x00022C42
			public void method_6(object sender, EventArgs e)
			{
				Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/t/{0}", this.class690_0.int_1), null);
			}

			// Token: 0x06003190 RID: 12688
			// RVA: 0x00024A64 File Offset: 0x00022C64
			public void method_7(object sender, EventArgs e)
			{
				Class115.smethod_90(string.Format("http://osu.ppy.sh/s/{0}", this.class690_0.int_0), null);
			}
		}

		// Token: 0x02000647 RID: 1607
		[CompilerGenerated]
		private sealed class Class850
		{
			// Token: 0x04002D44 RID: 11588
			public Class746 class746_0;

			// Token: 0x04002D43 RID: 11587
			public Class112.Class847 class847_0;

			// Token: 0x06003197 RID: 12695
			// RVA: 0x001452EC File Offset: 0x001434EC
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(new Class746(TransformationType.MovementX, class531_0.vector2_0.X, class531_0.vector2_0.X - (this.class847_0.class112_0.class531_0.vector2_1.X - this.class746_0.vector2_1.X), this.class746_0.int_0, this.class746_0.int_1, this.class746_0.enum70_0));
			}
		}

		// Token: 0x02000648 RID: 1608
		[CompilerGenerated]
		private sealed class Class851
		{
			// Token: 0x04002D45 RID: 11589
			public Class690 class690_0;

			// Token: 0x06003199 RID: 12697
			// RVA: 0x00024A86 File Offset: 0x00022C86
			public bool method_0(Class854 class854_0)
			{
				return class854_0.class690_0.int_0 == this.class690_0.int_0;
			}

			// Token: 0x0600319A RID: 12698
			// RVA: 0x00024AA0 File Offset: 0x00022CA0
			public void method_1()
			{
				if (Class112.class690_0 == this.class690_0)
				{
					Class112.smethod_0();
				}
			}
		}

		// Token: 0x02000649 RID: 1609
		[CompilerGenerated]
		private sealed class Class852
		{
			// Token: 0x04002D48 RID: 11592
			public EventHandler eventHandler_0;

			// Token: 0x04002D49 RID: 11593
			public EventHandler eventHandler_1;

			// Token: 0x04002D47 RID: 11591
			public int int_0;

			// Token: 0x04002D46 RID: 11590
			public LinkId linkId_0;

			// Token: 0x0600319C RID: 12700
			// RVA: 0x00145374 File Offset: 0x00143574
			public void method_0(object sender, EventArgs e)
			{
				Class690 class = sender as Class690;
				if (class != null)
				{
					Class112.smethod_8(class);
					class.method_7(this.eventHandler_0);
					return;
				}
				if (this.eventHandler_1 == null)
				{
					Class112.smethod_7(this.linkId_0, this.int_0);
					return;
				}
				this.eventHandler_1(null, null);
			}
		}

		// Token: 0x0200064A RID: 1610
		[CompilerGenerated]
		private sealed class Class853
		{
			// Token: 0x04002D4A RID: 11594
			public EventHandler eventHandler_0;

			// Token: 0x04002D4B RID: 11595
			public EventHandler eventHandler_1;

			// Token: 0x0600319E RID: 12702
			// RVA: 0x001453C8 File Offset: 0x001435C8
			public void method_0(object sender, EventArgs e)
			{
				Class690 class = sender as Class690;
				if (class == null)
				{
					if (this.eventHandler_1 != null)
					{
						this.eventHandler_1(null, null);
					}
					return;
				}
				Class112.smethod_8(class);
				class.method_7(this.eventHandler_0);
			}
		}

		// Token: 0x04002D32 RID: 11570
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04002D33 RID: 11571
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04002D34 RID: 11572
		[CompilerGenerated]
		private static Action<Class530> action_2;

		// Token: 0x04002D37 RID: 11575
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04002D39 RID: 11577
		[CompilerGenerated]
		private static Action<Class531> action_4;

		// Token: 0x04002D27 RID: 11559
		internal static bool bool_1;

		// Token: 0x04002D28 RID: 11560
		internal static bool bool_2;

		// Token: 0x04002D2B RID: 11563
		private bool bool_3;

		// Token: 0x04002D2E RID: 11566
		private bool bool_4;

		// Token: 0x04002D2F RID: 11567
		private bool bool_5;

		// Token: 0x04002D30 RID: 11568
		internal bool bool_6;

		// Token: 0x04002D29 RID: 11561
		private readonly Class110 class110_0 = new Class110(new Rectangle(120, 70, 120, 250), Vector2.get_Zero(), true, 0f, Enum98.const_2);

		// Token: 0x04002D31 RID: 11569
		private static Class335 class335_0;

		// Token: 0x04002D2C RID: 11564
		private Class531 class531_0;

		// Token: 0x04002D25 RID: 11557
		internal static Class690 class690_0;

		// Token: 0x04002D2A RID: 11562
		private readonly Class911 class911_0 = new Class911(true);

		// Token: 0x04002D36 RID: 11574
		[CompilerGenerated]
		private static EventHandler eventHandler_2;

		// Token: 0x04002D2D RID: 11565
		private int int_1;

		// Token: 0x04002D24 RID: 11556
		internal static List<Class854> list_0 = new List<Class854>();

		// Token: 0x04002D26 RID: 11558
		private static List<Class531> list_1;

		// Token: 0x04002D35 RID: 11573
		[CompilerGenerated]
		private static Predicate<Class854> predicate_0;

		// Token: 0x04002D38 RID: 11576
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04002D23 RID: 11555
		private static readonly Queue<Class690> queue_0 = new Queue<Class690>();

		// Token: 0x0600316C RID: 12652
		// RVA: 0x00024840 File Offset: 0x00022A40
		public Class112(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x06003171 RID: 12657
		// RVA: 0x00144234 File Offset: 0x00142434
		internal void Draw()
		{
			if (Class115.bool_16)
			{
				return;
			}
			if (!Class62.bool_12 && (!this.bool_4 || !(this.class531_0.vector2_1 == this.class531_0.vector2_0)))
			{
				float num = (float)((Class115.osuModes_1 == OsuModes.OnlineSelection) ? Class115.smethod_44() : 250);
				this.class531_0.vector2_2.Y = num + 20f;
				this.class911_0.bool_14 = (Class112.class690_0 != null && (!Class111.bool_2 || !Class111.bool_1));
				this.class911_0.Draw();
				this.class110_0.method_16(new RectangleF((float)((int)Math.Ceiling((double)(this.class531_0.method_28().X + 1f))), 70f, 120f, (float)((int)num)));
				this.class110_0.class911_0.bool_14 = (this.bool_6 && !this.class911_0.bool_14);
				this.class110_0.class911_0.float_0 = (float)((Class112.class690_0 == null) ? 1 : 0);
				this.class110_0.Draw();
				return;
			}
		}

		// Token: 0x06003172 RID: 12658
		// RVA: 0x00144368 File Offset: 0x00142568
		public override void imethod_2()
		{
			this.class110_0.imethod_2();
			if (Class112.class335_0 != null)
			{
				if (Class112.class335_0.vmethod_8())
				{
					Class112.class335_0.vmethod_1(Class331.smethod_77() / 100f);
				}
				else
				{
					Class112.smethod_1();
				}
			}
			if (Class112.list_0.Count <= 0 && Class112.class690_0 == null)
			{
				if (Class115.osuModes_1 == OsuModes.OnlineSelection)
				{
					this.bool_5 = false;
				}
			}
			else
			{
				this.bool_5 = true;
			}
			this.bool_3 = (Class115.osuModes_1 == OsuModes.OnlineSelection || Class112.class690_0 != null);
			this.bool_4 = (Class112.list_0.Count == 0 && !this.bool_3);
			if (!this.bool_4 && (this.bool_3 || (!Class62.bool_12 && (this.class531_0.rectangleF_0.Contains(Class800.smethod_15()) || Class800.smethod_19().X > (float)Class115.int_22))))
			{
				this.method_1();
			}
			else
			{
				this.method_3();
			}
			if (Class112.bool_2)
			{
				int num = 0;
				List<Class854> arg_11E_0 = Class112.list_0;
				if (Class112.predicate_0 == null)
				{
					Class112.predicate_0 = new Predicate<Class854>(Class112.smethod_12);
				}
				int num2 = arg_11E_0.FindAll(Class112.predicate_0).Count;
				Class112.bool_2 = false;
				int i = 0;
				while (i < Class112.list_0.Count)
				{
					Class854 class = Class112.list_0[i];
					if (class.enum104_0 == Enum104.const_0 && num2 < 2)
					{
						class.method_8();
						num2++;
						goto IL_27B;
					}
					if (class.enum104_0 != Enum104.const_3)
					{
						goto IL_27B;
					}
					if (class.list_0 != null)
					{
						foreach (Class531 current in class.list_0)
						{
							if (!this.bool_6 && (!Class62.bool_12 || Class341.class606_50.Value))
							{
								this.class110_0.class911_0.Remove(current);
								Class115.class911_2.Add(current);
								current.enum115_0 = Enum115.const_7;
								current.vector2_1 = new Vector2(2f, current.vector2_1.Y + 50f + 20f);
								current.method_16(2500, Enum70.const_0);
								current.method_19(new Vector2(120f, current.vector2_1.Y), 800, Enum70.const_1);
							}
							else
							{
								current.method_16(300, Enum70.const_0);
							}
							current.bool_0 = false;
						}
					}
					Class112.list_0.RemoveAt(i--);
					Class112.bool_2 = true;
					IL_2B1:
					i++;
					continue;
					IL_27B:
					if (class.method_4(new Vector2(0f, (float)num)))
					{
						this.class110_0.class911_0.Add<Class531>(class.list_0);
						this.method_2(true);
					}
					num += 20;
					goto IL_2B1;
				}
				this.class110_0.method_14(new Vector2(120f, (float)num));
			}
			if (Class112.queue_0.Count > 0)
			{
				if (Class112.class690_0 != null)
				{
					Class112.smethod_0();
				}
				this.method_4(Class112.queue_0.Dequeue());
			}
			base.imethod_2();
		}

		// Token: 0x0600316D RID: 12653
		// RVA: 0x00143FC8 File Offset: 0x001421C8
		public override void Initialize()
		{
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(2f, 50f), 0.68f, true, new Color(0, 0, 0, 180), null);
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2(120f, 270f);
			this.class911_0.Add(this.class531_0);
			Class533 class530_ = new Class533("osu!direct", 14f, new Vector2(2f, 50f), 1f, true, Color.get_YellowGreen())
			{
				enum115_0 = Enum115.const_7,
				bool_16 = true
			};
			this.class911_0.Add(class530_);
			Class533 class = new Class533("panel", 12f, new Vector2(-38f, 58f), 1f, true, Color.get_White());
			class.enum115_0 = Enum115.const_7;
			class.bool_16 = true;
			this.class911_0.Add(class);
			this.class911_0.bool_1 = false;
			base.Initialize();
		}

		// Token: 0x0600316E RID: 12654
		// RVA: 0x0002487C File Offset: 0x00022A7C
		internal void method_1()
		{
			this.method_2(false);
		}

		// Token: 0x0600316F RID: 12655
		// RVA: 0x001440E4 File Offset: 0x001422E4
		internal void method_2(bool bool_7)
		{
			this.int_1 = Class115.int_1;
			if (bool_7)
			{
				this.int_1 += 2000;
			}
			if (this.bool_6)
			{
				return;
			}
			Class331.smethod_59("select-expand", 100, Enum112.flag_5);
			List<Class530> arg_5F_0 = this.class911_0.list_2;
			if (Class112.action_0 == null)
			{
				Class112.action_0 = new Action<Class530>(Class112.smethod_9);
			}
			arg_5F_0.ForEach(Class112.action_0);
			this.bool_6 = true;
		}

		// Token: 0x06003170 RID: 12656
		// RVA: 0x0014415C File Offset: 0x0014235C
		internal void method_3()
		{
			Class112.Class846 class = new Class112.Class846();
			if (!this.bool_6)
			{
				return;
			}
			if (this.bool_5)
			{
				class.int_0 = 400;
			}
			else
			{
				class.int_0 = 0;
				List<Class530> arg_53_0 = this.class911_0.list_2;
				if (Class112.action_1 == null)
				{
					Class112.action_1 = new Action<Class530>(Class112.smethod_10);
				}
				arg_53_0.ForEach(Class112.action_1);
			}
			if (this.int_1 + 800 > Class115.int_1)
			{
				return;
			}
			this.class911_0.list_2.ForEach(new Action<Class530>(class.method_0));
			if (!this.bool_5)
			{
				List<Class530> arg_B8_0 = this.class911_0.list_2;
				if (Class112.action_2 == null)
				{
					Class112.action_2 = new Action<Class530>(Class112.smethod_11);
				}
				arg_B8_0.ForEach(Class112.action_2);
			}
			this.bool_6 = false;
			this.bool_5 = true;
		}

		// Token: 0x06003173 RID: 12659
		// RVA: 0x00144690 File Offset: 0x00142890
		private void method_4(Class690 class690_1)
		{
			Class131.Delegate9 delegate = null;
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			Class112.Class847 class = new Class112.Class847();
			class.class690_0 = class690_1;
			class.class112_0 = this;
			if ((Class115.bool_17 || (Class341.class606_3 && (Class72.class10_0 != null || Class858.class861_0 != null))) && !class.class690_0.bool_1 && !class.class690_0.method_1())
			{
				class.class690_0.method_3(false);
				return;
			}
			if (Class115.bool_16)
			{
				return;
			}
			this.class531_0.method_40(Color.get_Gray(), 500);
			Class112.class690_0 = class.class690_0;
			Class112.list_1 = new List<Class531>();
			Class533 class2 = new Class533(class.class690_0.string_0, 12f, new Vector2(this.class531_0.vector2_1.X, 74f), 1f, true, Color.get_Orchid());
			class2.enum115_0 = Enum115.const_7;
			class2.bool_16 = true;
			Class112.list_1.Add(class2);
			class2 = new Class533(class.class690_0.string_2, 12f, new Vector2(this.class531_0.vector2_1.X, 86f), 1f, true, Color.get_White());
			class2.enum115_0 = Enum115.const_7;
			class2.bool_16 = true;
			Class112.list_1.Add(class2);
			class2 = new Class533("by " + class.class690_0.string_1, 12f, new Vector2(this.class531_0.vector2_1.X, 98f), 1f, true, Color.get_White());
			class2.enum115_0 = Enum115.const_7;
			Class112.list_1.Add(class2);
			class.class531_0 = new Class531(null, Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(this.class531_0.vector2_1.X - 60f, 160f), 1f, true, Color.get_TransparentWhite(), null);
			class.class531_0.bool_6 = true;
			class.class531_0.float_2 = 1.2f;
			Class112.list_1.Add(class.class531_0);
			float num = 162f;
			Class131 class3 = new Class131("http://b.ppy.sh/thumb/" + class.class690_0.int_0 + "l.jpg");
			class3.method_0(new Class131.Delegate9(class.method_0));
			Class169.smethod_0(class3);
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				Class131 class4 = new Class131("http://b.ppy.sh/preview/" + class.class690_0.int_0 + ".mp3");
				Class131 arg_2B3_0 = class4;
				if (delegate == null)
				{
					delegate = new Class131.Delegate9(class.method_1);
				}
				arg_2B3_0.method_0(delegate);
				Class169.smethod_0(class4);
			}
			bool flag = Class466.smethod_33(class.class690_0.int_0) != null;
			float num2;
			if (flag && !class.class690_0.method_1() && class.class690_0.bool_2)
			{
				num2 = 16.25f;
			}
			else if (!flag && (class.class690_0.method_1() || !class.class690_0.bool_2))
			{
				num2 = 25f;
			}
			else
			{
				num2 = 20f;
			}
			Class760 class5;
			if (flag)
			{
				string arg_390_0 = "Go to map";
				Vector2 arg_390_1 = new Vector2(this.class531_0.vector2_1.X, 50f + num);
				Vector2 arg_390_2 = new Vector2(120f, num2);
				float arg_390_3 = 0.92f;
				Color arg_390_4 = Color.get_SkyBlue();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_2);
				}
				class5 = new Class760(arg_390_0, arg_390_1, arg_390_2, arg_390_3, arg_390_4, eventHandler, false, true, null);
				Class112.list_1.AddRange(class5.list_0);
				num += num2 + 2f;
			}
			class5 = new Class760(class.class690_0.method_1() ? "Cancel DL" : "Download", new Vector2(this.class531_0.vector2_1.X, 50f + num), new Vector2(120f, num2), 0.92f, Color.get_Bisque(), new EventHandler(class.method_3), false, true, null);
			Class112.list_1.AddRange(class5.list_0);
			num += num2 + 2f;
			if (!class.class690_0.method_1() && class.class690_0.bool_2)
			{
				string arg_4B2_0 = "DL NoVideo";
				Vector2 arg_4B2_1 = new Vector2(this.class531_0.vector2_1.X, 50f + num);
				Vector2 arg_4B2_2 = new Vector2(120f, num2);
				float arg_4B2_3 = 0.92f;
				Color arg_4B2_4 = Color.get_BlueViolet();
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(class.method_4);
				}
				class5 = new Class760(arg_4B2_0, arg_4B2_1, arg_4B2_2, arg_4B2_3, arg_4B2_4, eventHandler2, false, true, null);
				Class112.list_1.AddRange(class5.list_0);
				num += num2 + 2f;
			}
			string arg_535_0 = "Cancel";
			Vector2 arg_535_1 = new Vector2(this.class531_0.vector2_1.X, 50f + num);
			Vector2 arg_535_2 = new Vector2(120f, num2);
			float arg_535_3 = 0.92f;
			Color arg_535_4 = Color.get_Gray();
			if (Class112.eventHandler_2 == null)
			{
				Class112.eventHandler_2 = new EventHandler(Class112.smethod_13);
			}
			class5 = new Class760(arg_535_0, arg_535_1, arg_535_2, arg_535_3, arg_535_4, Class112.eventHandler_2, false, true, null);
			Class112.list_1.AddRange(class5.list_0);
			num += num2 + 2f;
			if (class.class690_0.int_2 > 0)
			{
				string arg_5BF_0 = "View Post";
				Vector2 arg_5BF_1 = new Vector2(this.class531_0.vector2_1.X, 50f + num);
				Vector2 arg_5BF_2 = new Vector2(120f, num2);
				float arg_5BF_3 = 0.92f;
				Color arg_5BF_4 = Color.get_YellowGreen();
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(class.method_5);
				}
				class5 = new Class760(arg_5BF_0, arg_5BF_1, arg_5BF_2, arg_5BF_3, arg_5BF_4, eventHandler3, false, true, null);
				Class112.list_1.AddRange(class5.list_0);
			}
			else
			{
				string arg_631_0 = "View Thread";
				Vector2 arg_631_1 = new Vector2(this.class531_0.vector2_1.X, 50f + num);
				Vector2 arg_631_2 = new Vector2(120f, num2);
				float arg_631_3 = 0.92f;
				Color arg_631_4 = Color.get_YellowGreen();
				if (eventHandler4 == null)
				{
					eventHandler4 = new EventHandler(class.method_6);
				}
				class5 = new Class760(arg_631_0, arg_631_1, arg_631_2, arg_631_3, arg_631_4, eventHandler4, false, true, null);
				Class112.list_1.AddRange(class5.list_0);
			}
			num += num2 + 2f;
			class5 = new Class760("View Listing", new Vector2(this.class531_0.vector2_1.X, 50f + num), new Vector2(120f, num2), 0.92f, Color.get_OrangeRed(), new EventHandler(class.method_7), false, true, null);
			Class112.list_1.AddRange(class5.list_0);
			List<Class531> arg_6DE_0 = Class112.list_1;
			if (Class112.action_3 == null)
			{
				Class112.action_3 = new Action<Class531>(Class112.smethod_14);
			}
			arg_6DE_0.ForEach(Class112.action_3);
			this.class911_0.Add<Class531>(Class112.list_1);
			if (this.class531_0.class26_0.Count > 0)
			{
				Action<Class531> action = null;
				Class112.Class850 class6 = new Class112.Class850();
				class6.class847_0 = class;
				Class112.Class850 arg_748_0 = class6;
				List<Class746> arg_743_0 = this.class531_0.class26_0;
				if (Class112.predicate_1 == null)
				{
					Class112.predicate_1 = new Predicate<Class746>(Class112.smethod_15);
				}
				arg_748_0.class746_0 = arg_743_0.Find(Class112.predicate_1);
				if (class6.class746_0 != null)
				{
					List<Class531> arg_770_0 = Class112.list_1;
					if (action == null)
					{
						action = new Action<Class531>(class6.method_0);
					}
					arg_770_0.ForEach(action);
				}
			}
		}

		// Token: 0x06003174 RID: 12660
		// RVA: 0x00024885 File Offset: 0x00022A85
		private static void smethod_0()
		{
			Class112.smethod_1();
			List<Class531> arg_27_0 = Class112.list_1;
			if (Class112.action_4 == null)
			{
				Class112.action_4 = new Action<Class531>(Class112.smethod_16);
			}
			arg_27_0.ForEach(Class112.action_4);
			Class112.class690_0 = null;
			Class112.bool_1 = false;
		}

		// Token: 0x06003175 RID: 12661
		// RVA: 0x000248BF File Offset: 0x00022ABF
		private static void smethod_1()
		{
			if (Class112.class335_0 != null)
			{
				Class112.class335_0.vmethod_7();
				Class112.class335_0 = null;
				if (Class112.bool_1 && Class115.osuModes_1 != OsuModes.OnlineSelection && Class115.osuModes_1 != OsuModes.Play)
				{
					Class331.bool_1 = true;
					Class331.smethod_88();
				}
			}
		}

		// Token: 0x0600317E RID: 12670
		// RVA: 0x0001F2E9 File Offset: 0x0001D4E9
		[CompilerGenerated]
		private static void smethod_10(Class530 class530_0)
		{
			class530_0.method_12();
		}

		// Token: 0x0600317F RID: 12671
		// RVA: 0x00024982 File Offset: 0x00022B82
		[CompilerGenerated]
		private static void smethod_11(Class530 class530_0)
		{
			class530_0.method_13();
		}

		// Token: 0x06003180 RID: 12672
		// RVA: 0x0002498A File Offset: 0x00022B8A
		[CompilerGenerated]
		private static bool smethod_12(Class854 class854_0)
		{
			return class854_0.enum104_0 > Enum104.const_0;
		}

		// Token: 0x06003181 RID: 12673
		// RVA: 0x00024995 File Offset: 0x00022B95
		[CompilerGenerated]
		private static void smethod_13(object sender, EventArgs e)
		{
			Class112.smethod_0();
		}

		// Token: 0x06003182 RID: 12674
		// RVA: 0x0002499C File Offset: 0x00022B9C
		[CompilerGenerated]
		private static void smethod_14(Class531 class531_1)
		{
			class531_1.method_15(100);
		}

		// Token: 0x06003183 RID: 12675
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_15(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x06003184 RID: 12676
		// RVA: 0x000249A7 File Offset: 0x00022BA7
		[CompilerGenerated]
		private static void smethod_16(Class531 class531_1)
		{
			class531_1.method_16(100, Enum70.const_0);
			class531_1.bool_0 = false;
		}

		// Token: 0x06003176 RID: 12662
		// RVA: 0x00144E14 File Offset: 0x00143014
		public static bool smethod_2(Class690 class690_1, bool bool_7, Delegate47 delegate47_0)
		{
			Class112.Class851 class = new Class112.Class851();
			class.class690_0 = class690_1;
			if (Class112.list_0.Find(new Predicate<Class854>(class.method_0)) != null)
			{
				Class723.smethod_1("This beatmap is already being downloaded!", 2000);
				return false;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_1), false);
			Class854 class854_ = new Class854(class.class690_0, bool_7);
			Class112.smethod_3(class854_);
			delegate47_0(class854_);
			return true;
		}

		// Token: 0x06003177 RID: 12663
		// RVA: 0x000248FC File Offset: 0x00022AFC
		public static bool smethod_3(Class854 class854_0)
		{
			if (Class112.list_0.Contains(class854_0))
			{
				return false;
			}
			Class112.list_0.Add(class854_0);
			Class112.bool_2 = true;
			return true;
		}

		// Token: 0x06003178 RID: 12664
		// RVA: 0x0002491F File Offset: 0x00022B1F
		public static void smethod_4(LinkId linkId_0, int int_2, EventHandler eventHandler_3)
		{
			Class112.smethod_5(linkId_0, int_2, eventHandler_3, null);
		}

		// Token: 0x06003179 RID: 12665
		// RVA: 0x00144E8C File Offset: 0x0014308C
		public static void smethod_5(LinkId linkId_0, int int_2, EventHandler eventHandler_3, EventHandler eventHandler_4)
		{
			EventHandler eventHandler = null;
			Class112.Class852 class = new Class112.Class852();
			class.linkId_0 = linkId_0;
			class.int_0 = int_2;
			class.eventHandler_0 = eventHandler_3;
			class.eventHandler_1 = eventHandler_4;
			if ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
			{
				LinkId arg_55_0 = class.linkId_0;
				string arg_55_1 = class.int_0.ToString();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				Class690.smethod_1(arg_55_0, arg_55_1, eventHandler);
				return;
			}
			Class112.smethod_7(class.linkId_0, class.int_0);
		}

		// Token: 0x0600317A RID: 12666
		// RVA: 0x00144F08 File Offset: 0x00143108
		public static void smethod_6(string string_0, EventHandler eventHandler_3, EventHandler eventHandler_4)
		{
			EventHandler eventHandler = null;
			Class112.Class853 class = new Class112.Class853();
			class.eventHandler_0 = eventHandler_3;
			class.eventHandler_1 = eventHandler_4;
			if ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
			{
				LinkId arg_38_0 = LinkId.Checksum;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				Class690.smethod_1(arg_38_0, string_0, eventHandler);
				return;
			}
			if (class.eventHandler_1 != null)
			{
				class.eventHandler_1(null, null);
			}
		}

		// Token: 0x0600317B RID: 12667
		// RVA: 0x00144F68 File Offset: 0x00143168
		private static void smethod_7(LinkId linkId_0, int int_2)
		{
			switch (linkId_0)
			{
			case LinkId.Set:
				Class115.smethod_90(string.Format("http://osu.ppy.sh/s/{0}", int_2), null);
				return;
			case LinkId.Beatmap:
				Class115.smethod_90(string.Format("http://osu.ppy.sh/b/{0}", int_2), null);
				return;
			case LinkId.Topic:
				Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/t/{0}", int_2), null);
				return;
			case LinkId.Post:
				Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/p/{0}", int_2), null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600317C RID: 12668
		// RVA: 0x0002492A File Offset: 0x00022B2A
		internal static void smethod_8(Class690 class690_1)
		{
			if (!Class112.queue_0.Contains(class690_1) && Class112.class690_0 != class690_1)
			{
				Class112.queue_0.Enqueue(class690_1);
			}
		}

		// Token: 0x0600317D RID: 12669
		// RVA: 0x0002494C File Offset: 0x00022B4C
		[CompilerGenerated]
		private static void smethod_9(Class530 class530_0)
		{
			class530_0.method_19(new Vector2(class530_0.vector2_0.X + 120f - 2f, class530_0.vector2_0.Y), 400, Enum70.const_1);
		}
	}
}
