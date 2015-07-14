using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns10;
using ns14;
using ns23;
using ns26;
using ns27;
using ns29;
using ns59;
using ns6;
using ns60;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns85;
using ns89;
using ns90;
using ns94;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.Events;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns68
{
	// Token: 0x02000384 RID: 900
	internal class Class371 : Class370
	{
		// Token: 0x02000386 RID: 902
		[CompilerGenerated]
		private sealed class Class377
		{
			// Token: 0x04001645 RID: 5701
			public int int_0;

			// Token: 0x04001646 RID: 5702
			public int int_1;

			// Token: 0x06001BF1 RID: 7153
			// RVA: 0x00093B54 File Offset: 0x00091D54
			public bool method_0(Class705 class705_0)
			{
				return (class705_0.int_2 >= this.int_0 && class705_0.int_2 <= this.int_1) || (class705_0.int_0 >= this.int_0 && class705_0.int_0 <= this.int_1);
			}
		}

		// Token: 0x02000387 RID: 903
		[CompilerGenerated]
		private sealed class Class378
		{
			// Token: 0x04001647 RID: 5703
			public Class304 class304_0;
		}

		// Token: 0x02000388 RID: 904
		[CompilerGenerated]
		private sealed class Class379
		{
			// Token: 0x04001649 RID: 5705
			public Class304 class304_0;

			// Token: 0x0400164A RID: 5706
			public Class371 class371_0;

			// Token: 0x04001648 RID: 5704
			public Class371.Class378 class378_0;

			// Token: 0x06001BF4 RID: 7156
			// RVA: 0x00093BA0 File Offset: 0x00091DA0
			public bool method_0(Class304 class304_1)
			{
				if (this.class371_0.list_1.Contains(class304_1))
				{
					return false;
				}
				if (class304_1 == this.class378_0.class304_0 && Class371.dictionary_0[Enum106.flag_4])
				{
					return false;
				}
				Class321 class = class304_1 as Class321;
				return class304_1.vmethod_9() || (class != null && class.class306_0 != null && class.class306_0.vmethod_9()) || (class304_1.EndTime > this.class304_0.StartTime - this.class371_0.class297_0.PreEmpt && class304_1.StartTime < this.class304_0.EndTime + this.class371_0.class297_0.PreEmpt);
			}
		}

		// Token: 0x02000389 RID: 905
		[CompilerGenerated]
		private sealed class Class380
		{
			// Token: 0x0400164B RID: 5707
			public int int_0;

			// Token: 0x06001BF6 RID: 7158
			// RVA: 0x0001725D File Offset: 0x0001545D
			public void method_0(Class304 class304_0)
			{
				class304_0.vmethod_4(class304_0.StartTime + this.int_0);
			}
		}

		// Token: 0x0200038A RID: 906
		[CompilerGenerated]
		private sealed class Class381
		{
			// Token: 0x0400164C RID: 5708
			public int int_0;

			// Token: 0x06001BF8 RID: 7160
			// RVA: 0x00017272 File Offset: 0x00015472
			public bool method_0(Class304 class304_0)
			{
				return class304_0.EndTime < this.int_0 - 1;
			}

			// Token: 0x06001BF9 RID: 7161
			// RVA: 0x00017284 File Offset: 0x00015484
			public bool method_1(Class304 class304_0)
			{
				return class304_0.StartTime > this.int_0 + 1;
			}
		}

		// Token: 0x0200038B RID: 907
		[CompilerGenerated]
		private sealed class Class382
		{
			// Token: 0x0400164D RID: 5709
			public Class304 class304_0;

			// Token: 0x0400164E RID: 5710
			public Class304 class304_1;

			// Token: 0x06001BFB RID: 7163
			// RVA: 0x00017296 File Offset: 0x00015496
			public bool method_0(Class304 class304_2)
			{
				return class304_2 == this.class304_0;
			}

			// Token: 0x06001BFC RID: 7164
			// RVA: 0x000172A1 File Offset: 0x000154A1
			public bool method_1(Class304 class304_2)
			{
				return class304_2 == this.class304_1;
			}
		}

		// Token: 0x02000385 RID: 901
		internal enum Enum42
		{
			// Token: 0x04001640 RID: 5696
			const_0,
			// Token: 0x04001641 RID: 5697
			const_1,
			// Token: 0x04001642 RID: 5698
			const_2,
			// Token: 0x04001643 RID: 5699
			const_3,
			// Token: 0x04001644 RID: 5700
			const_4
		}

		// Token: 0x04001630 RID: 5680
		[CompilerGenerated]
		private static Action<Class304> action_0;

		// Token: 0x04001632 RID: 5682
		[CompilerGenerated]
		private static Action<Class304> action_1;

		// Token: 0x0400163B RID: 5691
		[CompilerGenerated]
		private static Action<Class304> action_10;

		// Token: 0x0400163C RID: 5692
		[CompilerGenerated]
		private static Action<Class304> action_11;

		// Token: 0x04001633 RID: 5683
		[CompilerGenerated]
		private static Action<Class304> action_2;

		// Token: 0x04001634 RID: 5684
		[CompilerGenerated]
		private static Action<Class304> action_3;

		// Token: 0x04001635 RID: 5685
		[CompilerGenerated]
		private static Action<Class304> action_4;

		// Token: 0x04001636 RID: 5686
		[CompilerGenerated]
		private static Action<Class304> action_5;

		// Token: 0x04001637 RID: 5687
		[CompilerGenerated]
		private static Action<Class304> action_6;

		// Token: 0x04001638 RID: 5688
		[CompilerGenerated]
		private static Action<Class304> action_7;

		// Token: 0x04001639 RID: 5689
		[CompilerGenerated]
		private static Action<Class304> action_8;

		// Token: 0x0400163A RID: 5690
		[CompilerGenerated]
		private static Action<Class304> action_9;

		// Token: 0x04001604 RID: 5636
		internal bool bool_10;

		// Token: 0x04001605 RID: 5637
		internal bool bool_11;

		// Token: 0x04001606 RID: 5638
		internal bool bool_12;

		// Token: 0x04001607 RID: 5639
		internal bool bool_13;

		// Token: 0x0400160B RID: 5643
		protected bool bool_14;

		// Token: 0x0400160D RID: 5645
		private bool bool_15 = true;

		// Token: 0x04001610 RID: 5648
		private bool bool_16;

		// Token: 0x04001619 RID: 5657
		private bool bool_17;

		// Token: 0x0400161A RID: 5658
		private bool bool_18;

		// Token: 0x04001625 RID: 5669
		private bool bool_19;

		// Token: 0x040015EC RID: 5612
		protected bool bool_2;

		// Token: 0x04001627 RID: 5671
		private bool bool_20;

		// Token: 0x040015ED RID: 5613
		protected bool bool_3;

		// Token: 0x040015F5 RID: 5621
		private bool bool_4;

		// Token: 0x040015F8 RID: 5624
		internal bool bool_5;

		// Token: 0x040015FB RID: 5627
		private bool bool_6;

		// Token: 0x040015FE RID: 5630
		private bool bool_7;

		// Token: 0x04001600 RID: 5632
		protected bool bool_8;

		// Token: 0x04001602 RID: 5634
		private bool bool_9;

		// Token: 0x04001626 RID: 5670
		internal Class297 class297_1;

		// Token: 0x040015F3 RID: 5619
		internal Class304 class304_0;

		// Token: 0x040015FD RID: 5629
		protected Class304 class304_1;

		// Token: 0x04001624 RID: 5668
		protected Class304 class304_2;

		// Token: 0x040015FF RID: 5631
		private Class321 class321_0;

		// Token: 0x04001609 RID: 5641
		internal Class321 class321_1;

		// Token: 0x0400160E RID: 5646
		internal Class321 class321_2;

		// Token: 0x04001613 RID: 5651
		private Class328 class328_0;

		// Token: 0x040015F0 RID: 5616
		private Class531[] class531_0;

		// Token: 0x04001611 RID: 5649
		private Class531[] class531_1;

		// Token: 0x0400161C RID: 5660
		private Class531 class531_2;

		// Token: 0x040015EF RID: 5615
		private Class533 class533_0;

		// Token: 0x0400160C RID: 5644
		private Class533 class533_1;

		// Token: 0x04001616 RID: 5654
		private Class533 class533_2;

		// Token: 0x0400161E RID: 5662
		private Class533 class533_3;

		// Token: 0x0400161F RID: 5663
		private Class533 class533_4;

		// Token: 0x04001622 RID: 5666
		protected Class533 class533_5;

		// Token: 0x04001629 RID: 5673
		private Class533 class533_6;

		// Token: 0x0400161D RID: 5661
		private Class597 class597_0;

		// Token: 0x040015FC RID: 5628
		private Class702 class702_0;

		// Token: 0x04001603 RID: 5635
		private Class705 class705_0;

		// Token: 0x04001620 RID: 5664
		protected Class753 class753_0;

		// Token: 0x04001621 RID: 5665
		protected Class753 class753_1;

		// Token: 0x04001618 RID: 5656
		private Class880 class880_0;

		// Token: 0x040015EE RID: 5614
		internal Class883 class883_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly Color color_0 = new Color(255, 255, 255, 150);

		// Token: 0x040015E6 RID: 5606
		private static readonly Color color_1 = new Color(0, 0, 0, 100);

		// Token: 0x040015E7 RID: 5607
		private static readonly Color color_2 = new Color(255, 255, 255, 255);

		// Token: 0x040015E8 RID: 5608
		private static readonly Color color_3 = new Color(255, 40, 40, 255);

		// Token: 0x040015EA RID: 5610
		protected readonly Color color_4 = new Color(255, 255, 255, 20);

		// Token: 0x040015EB RID: 5611
		private readonly Color color_5 = new Color(255, 255, 255, 50);

		// Token: 0x0400163D RID: 5693
		[CompilerGenerated]
		private static Comparison<Class304> comparison_0;

		// Token: 0x04001623 RID: 5667
		protected CoordinateForm coordinateForm_0;

		// Token: 0x040015E9 RID: 5609
		private CurveTypes curveTypes_0 = CurveTypes.PerfectCurve;

		// Token: 0x04001612 RID: 5650
		internal static Dictionary<Enum106, bool> dictionary_0;

		// Token: 0x040015F4 RID: 5620
		private double double_0;

		// Token: 0x040015F2 RID: 5618
		protected Class371.Enum42 enum42_0;

		// Token: 0x040015FA RID: 5626
		private int int_0;

		// Token: 0x0400160A RID: 5642
		internal int int_1;

		// Token: 0x04001614 RID: 5652
		private int int_2;

		// Token: 0x04001615 RID: 5653
		private int int_3;

		// Token: 0x040015F1 RID: 5617
		protected List<Class304> list_0;

		// Token: 0x04001608 RID: 5640
		internal List<Class304> list_1;

		// Token: 0x04001628 RID: 5672
		private List<Class304> list_2 = new List<Class304>();

		// Token: 0x0400162A RID: 5674
		[CompilerGenerated]
		private static Predicate<Class304> predicate_0;

		// Token: 0x0400162B RID: 5675
		[CompilerGenerated]
		private static Predicate<Class311> predicate_1;

		// Token: 0x0400162C RID: 5676
		[CompilerGenerated]
		private static Predicate<Class311> predicate_2;

		// Token: 0x0400162D RID: 5677
		[CompilerGenerated]
		private static Predicate<Class311> predicate_3;

		// Token: 0x0400162E RID: 5678
		[CompilerGenerated]
		private static Predicate<Class530> predicate_4;

		// Token: 0x0400162F RID: 5679
		[CompilerGenerated]
		private static Predicate<Class304> predicate_5;

		// Token: 0x04001631 RID: 5681
		[CompilerGenerated]
		private static Predicate<Class304> predicate_6;

		// Token: 0x0400163E RID: 5694
		[CompilerGenerated]
		private static Predicate<Class311> predicate_7;

		// Token: 0x040015F6 RID: 5622
		protected Vector2 vector2_0;

		// Token: 0x040015F7 RID: 5623
		protected Vector2 vector2_1;

		// Token: 0x040015F9 RID: 5625
		private Vector2 vector2_2;

		// Token: 0x04001601 RID: 5633
		private Vector2 vector2_3;

		// Token: 0x0400160F RID: 5647
		private Vector2 vector2_4;

		// Token: 0x04001617 RID: 5655
		private Vector2 vector2_5;

		// Token: 0x0400161B RID: 5659
		private Vector2 vector2_6;

		// Token: 0x06001B69 RID: 7017
		// RVA: 0x0008AA50 File Offset: 0x00088C50
		public Class371(Editor editor_1) : base(editor_1)
		{
			this.list_1 = new List<Class304>();
			this.list_0 = new List<Class304>();
			this.bool_19 = (editor_1.playModes_0 == PlayModes.Taiko);
			Class570.smethod_2(new Class570.Delegate44(this.method_28));
		}

		// Token: 0x06001B97 RID: 7063
		// RVA: 0x0008FD90 File Offset: 0x0008DF90
		internal override void Dispose()
		{
			Class341.class607_2.Value = this.double_0;
			if (Class371.dictionary_0 != null)
			{
				Class341.class606_16.Value = Class371.dictionary_0[Enum106.flag_4];
			}
			if (this.class597_0 != null)
			{
				this.class597_0.Dispose();
			}
			Class570.smethod_3(new Class570.Delegate44(this.method_28));
			base.Dispose();
		}

		// Token: 0x06001B99 RID: 7065
		// RVA: 0x0008FE58 File Offset: 0x0008E058
		internal override void Draw()
		{
			base.Draw();
			if (this.class880_0 != null)
			{
				Class115.class882_0.method_0();
				Color white = Color.get_White();
				int num = Math.Abs(Class115.int_1 % 600 - 300);
				byte b = (byte)(255f * ((float)num / 300f));
				Class115.class882_0.method_1(this.class880_0.vector2_0, new Color(white.get_R(), white.get_G(), white.get_B(), b));
				Class115.class882_0.method_1(this.class880_0.vector2_1, new Color(white.get_R(), white.get_G(), white.get_B(), 0));
				Class115.class882_0.method_2();
				this.class880_0 = null;
			}
			if (this.class321_0 != null && (this.enum42_0 == Class371.Enum42.const_0 || this.class321_2 != null))
			{
				for (int i = 0; i < this.class321_0.list_3.Count; i++)
				{
					bool flag = i > 0 && this.class321_0.list_3[i] == this.class321_0.list_3[i - 1];
					Vector2 vector = Class115.smethod_61(this.class321_0.list_3[i]);
					Class115.class582_0.method_2(vector - Vector2.get_One() * 4f, vector + Vector2.get_One() * 4f, Class371.color_1);
					Class115.class582_0.method_2(vector - Vector2.get_One() * 3f, vector + Vector2.get_One() * 3f, flag ? Class371.color_3 : ((i == this.int_1) ? Class371.color_2 : Class371.color_0));
				}
				Class115.class882_0.method_0();
				for (int j = 1; j < this.class321_0.list_3.Count; j++)
				{
					Class115.class882_0.method_1(Class115.smethod_61(this.class321_0.list_3[j - 1]), (j - 1 == this.int_1) ? Class371.color_2 : Class371.color_0);
					Class115.class882_0.method_1(Class115.smethod_61(this.class321_0.list_3[j]), (j == this.int_1) ? Class371.color_2 : Class371.color_0);
				}
				Class115.class882_0.method_2();
			}
		}

		// Token: 0x06001B6C RID: 7020
		// RVA: 0x0008AAEC File Offset: 0x00088CEC
		private HitObjectSoundType method_0()
		{
			HitObjectSoundType hitObjectSoundType = HitObjectSoundType.None;
			if (Class371.dictionary_0[Enum106.flag_1])
			{
				hitObjectSoundType |= HitObjectSoundType.Whistle;
			}
			if (Class371.dictionary_0[Enum106.flag_2])
			{
				hitObjectSoundType |= HitObjectSoundType.Finish;
			}
			if (Class371.dictionary_0[Enum106.flag_6])
			{
				hitObjectSoundType |= HitObjectSoundType.Clap;
			}
			return hitObjectSoundType;
		}

		// Token: 0x06001B72 RID: 7026
		// RVA: 0x0008ACD8 File Offset: 0x00088ED8
		private Class705 method_1(ref bool bool_21)
		{
			bool_21 = false;
			Class705 class = this.class702_0 as Class705;
			if (class == null)
			{
				return null;
			}
			int num = this.editor_0.method_71((int)Class800.smethod_19().X - 8);
			if (num <= class.int_2)
			{
				return class;
			}
			num = this.editor_0.method_71((int)Class800.smethod_19().X + 8);
			if (num >= class.int_0)
			{
				bool_21 = true;
				return class;
			}
			return null;
		}

		// Token: 0x06001B7E RID: 7038
		// RVA: 0x00016F5C File Offset: 0x0001515C
		protected void method_10(Enum106 enum106_0, bool bool_21)
		{
			this.method_15(enum106_0, bool_21, false);
		}

		// Token: 0x06001B7F RID: 7039
		// RVA: 0x0008BE14 File Offset: 0x0008A014
		private void method_11()
		{
			if (this.bool_16)
			{
				this.class533_2.method_57(Color.get_White());
				this.class533_2.color_0 = new Color(255, 255, 255, 180);
				int int_ = this.editor_0.int_6;
				if (int_ > 8)
				{
					if (int_ != 12)
					{
						if (int_ != 16)
						{
							goto IL_F9;
						}
					}
					this.class533_2.Text = string.Format(Class41.GetString(OsuString.EditorModeCompose_16WarningMessage), this.editor_0.int_6);
					this.class533_2.method_57(Color.get_Red());
					this.class533_2.color_0 = Color.get_White();
					this.class533_2.method_14(500, Enum70.const_0);
					goto IL_164;
				}
				if (int_ == 3)
				{
					this.class533_2.Text = Class41.GetString(OsuString.EditorModeCompose_3WarningMessage);
					this.class533_2.method_17(6000);
					goto IL_164;
				}
				switch (int_)
				{
				case 6:
					this.class533_2.Text = Class41.GetString(OsuString.EditorModeCompose_6WarningMessage);
					this.class533_2.method_17(6000);
					goto IL_164;
				case 8:
					this.class533_2.Text = Class41.GetString(OsuString.EditorModeCompose_8WarningMessage);
					this.class533_2.method_17(20000);
					goto IL_164;
				}
				IL_F9:
				this.class533_2.method_16(100, Enum70.const_0);
				IL_164:
				this.bool_16 = false;
			}
		}

		// Token: 0x06001B80 RID: 7040
		// RVA: 0x0008BF8C File Offset: 0x0008A18C
		private void method_12(object sender, EventArgs e)
		{
			if (this.list_1.Count != 1)
			{
				return;
			}
			Class598 class = sender as Class598;
			if (class == null)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.list_1[0].NewCombo = true;
			this.list_1[0].int_0 = class.int_0;
			this.class297_0.method_20(false);
			this.method_65();
		}

		// Token: 0x06001B81 RID: 7041
		// RVA: 0x0008BFFC File Offset: 0x0008A1FC
		private void method_13(object sender, EventArgs e)
		{
			SampleSet sampleSet = (SampleSet)this.class753_0.object_0;
			if (this.class321_1 != null)
			{
				this.editor_0.method_16(false);
				bool flag = this.class321_1.class306_0.method_2();
				List<Class311> arg_61_0 = this.class321_1.list_2;
				if (Class371.predicate_1 == null)
				{
					Class371.predicate_1 = new Predicate<Class311>(Class371.smethod_3);
				}
				List<Class311> list = arg_61_0.FindAll(Class371.predicate_1);
				this.class321_1.method_26();
				if (!flag && list.Count <= 0)
				{
					if (!this.class321_1.method_11())
					{
						this.class321_1.list_9[0] = sampleSet;
						for (int i = 0; i < this.class321_1.list_2.Count; i++)
						{
							this.class321_1.list_9[i + 1] = sampleSet;
						}
					}
					this.class321_1.sampleSet_0 = sampleSet;
				}
				else
				{
					if (flag)
					{
						this.class321_1.list_9[0] = sampleSet;
					}
					for (int j = 0; j < this.class321_1.list_2.Count; j++)
					{
						if (this.class321_1.list_2[j].method_2())
						{
							this.class321_1.list_9[j + 1] = sampleSet;
						}
					}
				}
			}
			else
			{
				if (this.list_1.Count > 0)
				{
					this.editor_0.method_16(false);
				}
				foreach (Class304 current in this.list_1)
				{
					Class321 class = current as Class321;
					if (class != null)
					{
						class.method_26();
						class.list_9[0] = sampleSet;
						for (int k = 0; k < class.list_2.Count; k++)
						{
							class.list_9[k + 1] = sampleSet;
						}
					}
					current.sampleSet_0 = sampleSet;
				}
			}
			this.method_66();
			this.editor_0.bool_5 = true;
		}

		// Token: 0x06001B82 RID: 7042
		// RVA: 0x0008C210 File Offset: 0x0008A410
		private void method_14(object sender, EventArgs e)
		{
			SampleSet sampleSet = (SampleSet)this.class753_1.object_0;
			if (this.class321_1 != null)
			{
				this.editor_0.method_16(false);
				bool flag = this.class321_1.class306_0.method_2();
				List<Class311> arg_61_0 = this.class321_1.list_2;
				if (Class371.predicate_2 == null)
				{
					Class371.predicate_2 = new Predicate<Class311>(Class371.smethod_4);
				}
				List<Class311> list = arg_61_0.FindAll(Class371.predicate_2);
				this.class321_1.method_26();
				if (!flag && list.Count <= 0)
				{
					if (!this.class321_1.method_11())
					{
						this.class321_1.list_10[0] = sampleSet;
						for (int i = 0; i < this.class321_1.list_2.Count; i++)
						{
							this.class321_1.list_10[i + 1] = sampleSet;
						}
					}
					this.class321_1.sampleSet_1 = sampleSet;
				}
				else
				{
					if (flag)
					{
						this.class321_1.list_10[0] = sampleSet;
					}
					for (int j = 0; j < this.class321_1.list_2.Count; j++)
					{
						if (this.class321_1.list_2[j].method_2())
						{
							this.class321_1.list_10[j + 1] = sampleSet;
						}
					}
				}
			}
			else
			{
				if (this.list_1.Count > 0)
				{
					this.editor_0.method_16(false);
				}
				foreach (Class304 current in this.list_1)
				{
					Class321 class = current as Class321;
					if (class != null)
					{
						class.method_26();
						class.list_10[0] = sampleSet;
						for (int k = 0; k < class.list_2.Count; k++)
						{
							class.list_10[k + 1] = sampleSet;
						}
					}
					current.sampleSet_1 = sampleSet;
				}
			}
			this.editor_0.bool_5 = true;
		}

		// Token: 0x06001B83 RID: 7043
		// RVA: 0x0008C420 File Offset: 0x0008A620
		private void method_15(Enum106 enum106_0, bool bool_21, bool bool_22)
		{
			if (Class371.dictionary_0[enum106_0] == bool_21)
			{
				return;
			}
			Class371.dictionary_0[enum106_0] = bool_21;
			if (this.class911_0.method_11(enum106_0)[0].bool_3)
			{
				this.method_18(enum106_0);
			}
			if (enum106_0 != Enum106.flag_3)
			{
				if (enum106_0 != Enum106.flag_4)
				{
					if (bool_22)
					{
						if (this.list_1.Count == 0)
						{
							return;
						}
						this.editor_0.method_16(false);
						if (this.class321_1 != null)
						{
							bool flag = this.class321_1.class306_0.method_2();
							List<Class311> arg_B8_0 = this.class321_1.list_2;
							if (Class371.predicate_3 == null)
							{
								Class371.predicate_3 = new Predicate<Class311>(Class371.smethod_5);
							}
							List<Class311> list = arg_B8_0.FindAll(Class371.predicate_3);
							if (!flag && list.Count <= 0)
							{
								if (this.class321_1.method_11())
								{
									this.class321_1.method_26();
								}
								else if (!this.class321_1.bool_10)
								{
									this.method_16(this.class321_1, bool_21, enum106_0);
								}
								switch (enum106_0)
								{
								case Enum106.flag_1:
									this.class321_1.Whistle = Class371.dictionary_0[enum106_0];
									break;
								case Enum106.flag_0 | Enum106.flag_1:
									break;
								case Enum106.flag_2:
									this.class321_1.Finish = Class371.dictionary_0[enum106_0];
									break;
								default:
									if (enum106_0 == Enum106.flag_6)
									{
										this.class321_1.Clap = Class371.dictionary_0[enum106_0];
									}
									break;
								}
							}
							else
							{
								this.class321_1.method_26();
								if (flag)
								{
									this.method_17(this.class321_1, bool_21, enum106_0, 0);
								}
								for (int i = 0; i < this.class321_1.list_2.Count; i++)
								{
									if (this.class321_1.list_2[i].method_2())
									{
										this.method_17(this.class321_1, bool_21, enum106_0, i + 1);
									}
								}
							}
							if (enum106_0 == Enum106.flag_0)
							{
								bool flag2 = this.class321_1.NewCombo = Class371.dictionary_0[enum106_0];
								this.class297_0.method_24(this.class297_0.list_3.IndexOf(this.class321_1));
								if (!flag2)
								{
									this.class321_1.int_0 = 0;
								}
							}
						}
						else
						{
							foreach (Class304 current in this.list_1)
							{
								if (enum106_0 == Enum106.flag_0)
								{
									bool flag3 = current.NewCombo = Class371.dictionary_0[enum106_0];
									this.class297_0.method_24(this.class297_0.list_3.IndexOf(current));
									if (!flag3)
									{
										current.int_0 = 0;
									}
								}
								else
								{
									Class321 class = current as Class321;
									if (class != null && !class.bool_10)
									{
										this.method_16(class, bool_21, enum106_0);
									}
									switch (enum106_0)
									{
									case Enum106.flag_1:
										current.Whistle = Class371.dictionary_0[enum106_0];
										break;
									case Enum106.flag_0 | Enum106.flag_1:
										break;
									case Enum106.flag_2:
										current.Finish = Class371.dictionary_0[enum106_0];
										break;
									default:
										if (enum106_0 == Enum106.flag_6)
										{
											current.Clap = Class371.dictionary_0[enum106_0];
										}
										break;
									}
								}
							}
						}
						if (enum106_0 == Enum106.flag_0)
						{
							this.class297_0.method_20(true);
							this.method_65();
						}
					}
					this.editor_0.bool_5 = true;
					return;
				}
			}
			else
			{
				Class115.editorControl_0.method_6(bool_21);
			}
		}

		// Token: 0x06001B84 RID: 7044
		// RVA: 0x0008C798 File Offset: 0x0008A998
		private void method_16(Class321 class321_3, bool bool_21, Enum106 enum106_0)
		{
			this.method_17(class321_3, bool_21, enum106_0, 0);
			for (int i = 0; i < class321_3.list_2.Count; i++)
			{
				this.method_17(class321_3, bool_21, enum106_0, i + 1);
			}
		}

		// Token: 0x06001B85 RID: 7045
		// RVA: 0x0008C7D4 File Offset: 0x0008A9D4
		private void method_17(Class321 class321_3, bool bool_21, Enum106 enum106_0, int int_4)
		{
			HitObjectSoundType hitObjectSoundType;
			switch (enum106_0)
			{
			case Enum106.flag_1:
				hitObjectSoundType = HitObjectSoundType.Whistle;
				break;
			case Enum106.flag_0 | Enum106.flag_1:
				return;
			case Enum106.flag_2:
				hitObjectSoundType = HitObjectSoundType.Finish;
				break;
			default:
				if (enum106_0 != Enum106.flag_6)
				{
					return;
				}
				hitObjectSoundType = HitObjectSoundType.Clap;
				break;
			}
			class321_3.list_8[int_4] = (bool_21 ? (class321_3.list_8[int_4] | hitObjectSoundType) : (class321_3.list_8[int_4] ^ hitObjectSoundType));
		}

		// Token: 0x06001B86 RID: 7046
		// RVA: 0x0008C838 File Offset: 0x0008AA38
		private void method_18(Enum106 enum106_0)
		{
			Class530 class = this.class911_0.method_11(enum106_0)[0];
			class.class26_0.Clear();
			if (Class371.dictionary_0[enum106_0])
			{
				class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0.9f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
				return;
			}
			class.class26_0.Add(new Class746(TransformationType.Fade, class.float_3, 0.4f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
		}

		// Token: 0x06001B87 RID: 7047
		// RVA: 0x0008C8CC File Offset: 0x0008AACC
		private void method_19()
		{
			if (Class570.bool_1)
			{
				if (!this.bool_4)
				{
					this.method_9(Enum106.flag_4);
					this.class533_1.Text = Class41.GetString(OsuString.EditorModeCompose_DistanceSpacing) + ":";
					this.class883_0.method_20(0.1, 2.0, this.double_0);
					this.method_6(this.double_0);
					this.bool_4 = true;
				}
			}
			else if (this.bool_4)
			{
				this.method_9(Enum106.flag_4);
				this.class533_1.Text = Class41.GetString(OsuString.EditorModeCompose_BeatSnapDivisor) + ":";
				this.class883_0.method_20(1.0, 16.0, (double)this.editor_0.int_6);
				this.method_4(this.editor_0.int_6);
				this.bool_4 = false;
			}
			if (Class570.bool_2)
			{
				if (!this.bool_6)
				{
					this.method_9(Enum106.flag_3);
					this.bool_6 = true;
					return;
				}
			}
			else if (this.bool_6)
			{
				this.method_9(Enum106.flag_3);
				this.bool_6 = false;
			}
		}

		// Token: 0x06001B76 RID: 7030
		// RVA: 0x0008BB68 File Offset: 0x00089D68
		private void method_2(object sender, EventArgs e)
		{
			if (this.list_1.Count == 0)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorModeCompose_SelectNotesMessage), 1000);
				return;
			}
			if (this.coordinateForm_0 == null)
			{
				this.coordinateForm_0 = new CoordinateForm();
				this.coordinateForm_0.Show(Class115.form_0);
				this.coordinateForm_0 = null;
			}
		}

		// Token: 0x06001B88 RID: 7048
		// RVA: 0x0008C9F0 File Offset: 0x0008ABF0
		protected void method_20()
		{
			if (!this.class883_0.method_2())
			{
				return;
			}
			if (this.vmethod_27() && Class570.bool_1)
			{
				double num = Math.Round(this.class883_0.double_1, Class570.bool_2 ? 2 : 1);
				if (this.class883_0.method_1() && num != this.double_0)
				{
					this.method_6((double)((float)num));
				}
			}
			else
			{
				int num2 = this.method_5((int)Math.Round(this.class883_0.double_1));
				if (this.class883_0.method_1() && num2 != this.editor_0.int_6)
				{
					this.method_4(num2);
					return;
				}
			}
		}

		// Token: 0x06001B89 RID: 7049
		// RVA: 0x0008CA94 File Offset: 0x0008AC94
		internal void method_21(bool bool_21)
		{
			if (this.bool_11)
			{
				return;
			}
			if (this.editor_0.bool_7 && !this.bool_12)
			{
				switch (this.editor_0.enum108_0)
				{
				case Enum108.const_1:
				case Enum108.const_2:
					if (!this.bool_5 || bool_21)
					{
						this.bool_11 = true;
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06001B8A RID: 7050
		// RVA: 0x0008CAF0 File Offset: 0x0008ACF0
		private void method_22()
		{
			this.vector2_2 = Vector2.get_Zero();
			this.int_0 = this.editor_0.method_71(Class802.point_0.X);
			this.int_2 = (this.int_3 = this.int_0);
		}

		// Token: 0x06001B8B RID: 7051
		// RVA: 0x0008CB38 File Offset: 0x0008AD38
		private void method_23(Vector2 vector2_7)
		{
			Vector2 vector = Class802.vector2_0;
			int num = (int)this.vector2_3.X;
			int num2 = (int)this.vector2_3.Y;
			int num3 = (int)vector2_7.X;
			int num4 = (int)vector2_7.Y;
			Class304 class = null;
			if (this.editor_0.bool_16)
			{
				int num5 = this.editor_0.method_71(Class802.point_0.X);
				Class702 class2 = null;
				foreach (Class705 current in this.editor_0.class872_0.list_0)
				{
					if (num5 > current.int_2 && num5 < current.int_0)
					{
						class2 = current;
						break;
					}
				}
				this.class702_0 = class2;
				if (this.class321_2 != null)
				{
					goto IL_34E;
				}
				double num6 = 1000.0;
				List<Class530> arg_103_0 = this.editor_0.class911_3.list_2;
				if (Class371.predicate_4 == null)
				{
					Class371.predicate_4 = new Predicate<Class530>(Class371.smethod_6);
				}
				List<Class530> list = arg_103_0.FindAll(Class371.predicate_4);
				using (List<Class530>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Class531 class3 = (Class531)enumerator2.Current;
						Class304 class4 = (Class304)class3.object_0;
						double num7 = (double)Vector2.Distance(vector, class3.vector2_1 * Class115.float_4 + new Vector2(0f, (float)Class115.int_25));
						bool flag = num5 > class4.StartTime && num5 < class4.EndTime;
						bool flag2 = this.list_1.Contains(class4);
						if ((num7 < (double)((float)class3.int_4 * class3.float_2 * Class115.float_4 / 5f) && (num7 < num6 || flag2)) || flag)
						{
							num6 = num7;
							class = class4;
							if (flag2)
							{
								break;
							}
						}
					}
					goto IL_34E;
				}
			}
			foreach (Class304 current2 in this.list_1)
			{
				if (Vector2.Distance(Class115.smethod_58(vector), current2.Position) < this.class297_0.HitObjectRadius)
				{
					class = current2;
				}
				if (current2.IsType(HitObjectType.Slider) && current2.vmethod_9())
				{
					Class321 class5 = current2 as Class321;
					if (class5.list_4 != null)
					{
						foreach (Class880 current3 in class5.list_4)
						{
							if (Vector2.Distance(Class115.smethod_58(vector), current3.vector2_0) < this.class297_0.HitObjectRadius)
							{
								class = current2;
								break;
							}
						}
					}
				}
				if (class != null)
				{
					break;
				}
			}
			if (class == null)
			{
				if (this.enum42_0 == Class371.Enum42.const_0)
				{
					class = this.class297_0.method_16(num, num2, this.class297_0.HitObjectRadius * 0.8f, false, null);
				}
				else if (Class371.dictionary_0[Enum106.flag_4])
				{
					class = this.class297_0.method_18((float)num, (float)num2, false, this.class297_0.HitObjectRadius * 0.5f);
				}
				else
				{
					class = this.class297_0.method_18((float)num3, (float)num4, false, this.class297_0.HitObjectRadius * 0.8f);
				}
			}
			IL_34E:
			this.class304_1 = class;
		}

		// Token: 0x06001B91 RID: 7057
		// RVA: 0x0008ECB0 File Offset: 0x0008CEB0
		internal void method_24()
		{
			this.class321_2 = null;
			this.list_1.Clear();
			List<Class304> arg_3B_0 = this.class297_0.list_3;
			if (Class371.predicate_6 == null)
			{
				Class371.predicate_6 = new Predicate<Class304>(Class371.smethod_9);
			}
			this.list_1 = arg_3B_0.FindAll(Class371.predicate_6);
			this.bool_14 = true;
			this.class321_1 = null;
			this.int_1 = -1;
			this.class321_0 = null;
		}

		// Token: 0x06001B92 RID: 7058
		// RVA: 0x00016F70 File Offset: 0x00015170
		private void method_25()
		{
			this.class304_1 = null;
			this.class321_0 = null;
		}

		// Token: 0x06001B9B RID: 7067
		// RVA: 0x000902F4 File Offset: 0x0008E4F4
		internal void method_26(bool bool_21)
		{
			this.editor_0.method_16(false);
			Class306 class = new Class306(this.class297_0, this.vector2_5, this.editor_0.method_85(), false, bool_21 ? HitObjectSoundType.Clap : HitObjectSoundType.Normal, 0);
			this.class297_0.Add(class, true);
			this.class297_0.method_20(true);
		}

		// Token: 0x06001B9C RID: 7068
		// RVA: 0x0009034C File Offset: 0x0008E54C
		internal void method_27()
		{
			this.editor_0.bool_10 = !this.editor_0.bool_10;
			if (this.editor_0.bool_10)
			{
				this.method_48(Class371.Enum42.const_1);
			}
			Class723.smethod_1(this.editor_0.bool_10 ? Class41.GetString(OsuString.EditorModeCompose_LiveMappingEnabled) : Class41.GetString(OsuString.EditorModeCompose_LiveMappingDisabled), 3000);
		}

		// Token: 0x06001B9E RID: 7070
		// RVA: 0x00090894 File Offset: 0x0008EA94
		private bool method_28(object object_0, Keys keys_0)
		{
			if (this.bool_2)
			{
				switch (keys_0)
				{
				case 37:
				case 38:
				case 39:
				case 40:
					if (!Class570.smethod_9(38) && !Class570.smethod_9(40) && !Class570.smethod_9(37) && !Class570.smethod_9(39))
					{
						this.bool_2 = false;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001B9F RID: 7071
		// RVA: 0x000908F4 File Offset: 0x0008EAF4
		private void method_29()
		{
			List<Class304> list_ = this.class297_0.list_3;
			for (int i = 1; i < list_.Count; i++)
			{
				if (list_[i].method_2() && list_[i - 1].CompareTo(list_[i]) == 0)
				{
					Class304 value = list_[i];
					list_[i] = list_[i - 1];
					list_[i - 1] = value;
				}
			}
			this.class297_0.method_20(false);
		}

		// Token: 0x06001B77 RID: 7031
		// RVA: 0x0008BBC4 File Offset: 0x00089DC4
		internal void method_3(int int_4, bool bool_21)
		{
			Class371.Class377 class = new Class371.Class377();
			class.int_0 = 0;
			class.int_1 = 0;
			foreach (Class304 current in this.class297_0.list_3)
			{
				if (current.EndTime < int_4)
				{
					class.int_0 = Math.Max(class.int_0, current.EndTime + 200);
				}
				else if (current.StartTime > int_4)
				{
					class.int_1 = current.StartTime - this.class297_0.PreEmpt;
					break;
				}
			}
			Class705 class2 = this.editor_0.class872_0.list_0.Find(new Predicate<Class705>(class.method_0));
			if (class2 != null)
			{
				return;
			}
			if (class.int_0 != 0 && class.int_1 != 0 && class.int_0 < class.int_1)
			{
				if (bool_21)
				{
					this.editor_0.method_16(false);
				}
				this.editor_0.class872_0.Add(new Class705(class.int_0, class.int_1));
				this.editor_0.bool_5 = true;
				return;
			}
			if (bool_21)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorModeCompose_NotEnoughRoomMessage), 3000);
			}
		}

		// Token: 0x06001BA0 RID: 7072
		// RVA: 0x00090974 File Offset: 0x0008EB74
		private void method_30()
		{
			List<Class304> list_ = this.class297_0.list_3;
			for (int i = 0; i < list_.Count - 1; i++)
			{
				if (list_[i].method_2() && list_[i].CompareTo(list_[i + 1]) == 0)
				{
					Class304 value = list_[i + 1];
					list_[i + 1] = list_[i];
					list_[i] = value;
				}
			}
			this.class297_0.method_20(false);
		}

		// Token: 0x06001BA2 RID: 7074
		// RVA: 0x00017020 File Offset: 0x00015220
		internal void method_31()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.editor_0.class375_0.method_3(-1);
		}

		// Token: 0x06001BA3 RID: 7075
		// RVA: 0x0001704D File Offset: 0x0001524D
		internal void method_32()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.editor_0.class375_0.method_3(1);
		}

		// Token: 0x06001BA4 RID: 7076
		// RVA: 0x000909F4 File Offset: 0x0008EBF4
		internal void method_33()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.list_1.Sort();
			this.editor_0.method_16(false);
			List<Class304> arg_48_0 = this.list_1;
			if (Class371.action_1 == null)
			{
				Class371.action_1 = new Action<Class304>(Class371.smethod_10);
			}
			arg_48_0.ForEach(Class371.action_1);
			this.method_21(false);
			this.bool_13 = this.bool_11;
			int endTime = this.list_1[0].EndTime;
			int startTime = this.list_1[0].StartTime;
			bool[] array = new bool[this.list_1.Count];
			for (int i = 0; i < this.list_1.Count; i++)
			{
				array[i] = this.list_1[i].NewCombo;
				if (this.list_1[i].EndTime > endTime)
				{
					endTime = this.list_1[i].EndTime;
				}
				if (this.list_1[i].StartTime < startTime)
				{
					startTime = this.list_1[i].StartTime;
				}
			}
			bool flag = this.editor_0.playModes_0 == PlayModes.OsuMania;
			int num = 1;
			foreach (Class304 current in this.list_1)
			{
				current.NewCombo = array[this.list_1.Count - num];
				num++;
				int num2 = startTime + (endTime - current.EndTime);
				if (!flag)
				{
					current.vmethod_4(num2);
					if (current.IsType(HitObjectType.Slider))
					{
						((Class321)current).Reverse();
					}
				}
				else
				{
					int num3 = this.editor_0.class375_0.method_4((double)num2);
					if (Math.Abs(num3 - num2) == 1)
					{
						num2 = num3;
					}
					current.vmethod_4(num2);
					if (current.IsType(HitObjectType.Hold))
					{
						int num4 = this.editor_0.class375_0.method_4((double)current.EndTime);
						if (Math.Abs(num4 - current.EndTime) == 1)
						{
							current.vmethod_19(num4);
						}
					}
				}
			}
			this.bool_14 = true;
			this.class297_0.method_20(true);
		}

		// Token: 0x06001BA5 RID: 7077
		// RVA: 0x00090C40 File Offset: 0x0008EE40
		internal void method_34()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.method_21(false);
			this.bool_13 = this.bool_11;
			List<Class304> list = new List<Class304>();
			int num = this.list_1[0].EndTime;
			int startTime = this.list_1[0].StartTime;
			for (int i = 0; i < this.list_1.Count; i++)
			{
				if (this.list_1[i].EndTime > num)
				{
					num = this.list_1[i].EndTime;
				}
				if (this.list_1[i].StartTime < startTime)
				{
					startTime = this.list_1[i].StartTime;
				}
			}
			num = this.editor_0.class375_0.method_5((double)num + Class331.smethod_8());
			foreach (Class304 current in this.list_1)
			{
				Class304 class = current.Clone();
				if (current is Class321)
				{
					((Class321)class).method_13(num + (current.StartTime - startTime), false);
				}
				else
				{
					class.vmethod_4(num + (current.StartTime - startTime));
				}
				list.Add(class);
				this.class297_0.Add(class, true);
			}
			this.vmethod_17();
			this.list_1 = list;
			this.method_57();
			this.class297_0.method_20(false);
		}

		// Token: 0x06001BA8 RID: 7080
		// RVA: 0x00091120 File Offset: 0x0008F320
		internal void method_35()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			List<Class304> arg_3D_0 = this.list_1;
			if (Class371.action_4 == null)
			{
				Class371.action_4 = new Action<Class304>(Class371.smethod_13);
			}
			arg_3D_0.ForEach(Class371.action_4);
			this.method_21(false);
			this.bool_13 = this.bool_11;
			Vector2 vector;
			vector..ctor((float)(Class115.int_18 / 2), (float)(Class115.int_17 / 2));
			foreach (Class304 current in this.list_1)
			{
				Vector2 vector2;
				vector2..ctor(current.Position.Y - vector.Y + vector.X, -(current.Position.X - vector.X) + vector.Y);
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = new Vector2(class.list_3[i].Y - vector.Y + vector.X, -(class.list_3[i].X - vector.X) + vector.Y);
					}
					class.class306_0.vmethod_5(vector2, false);
					class.Position = (class.vector2_0 = vector2);
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(vector2, false);
				}
			}
		}

		// Token: 0x06001BA9 RID: 7081
		// RVA: 0x000912E0 File Offset: 0x0008F4E0
		internal void method_36()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			List<Class304> arg_3D_0 = this.list_1;
			if (Class371.action_5 == null)
			{
				Class371.action_5 = new Action<Class304>(Class371.smethod_14);
			}
			arg_3D_0.ForEach(Class371.action_5);
			this.method_21(false);
			this.bool_13 = this.bool_11;
			Vector2 vector;
			vector..ctor((float)(Class115.int_18 / 2), (float)(Class115.int_17 / 2));
			foreach (Class304 current in this.list_1)
			{
				Vector2 vector2;
				vector2..ctor(-(current.Position.Y - vector.Y) + vector.X, current.Position.X - vector.X + vector.Y);
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = new Vector2(-(class.list_3[i].Y - vector.Y) + vector.X, class.list_3[i].X - vector.X + vector.Y);
					}
					class.class306_0.vmethod_5(vector2, false);
					class.Position = (class.vector2_0 = vector2);
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(vector2, false);
				}
			}
		}

		// Token: 0x06001BAA RID: 7082
		// RVA: 0x000914A0 File Offset: 0x0008F6A0
		internal void method_37(int int_4, bool bool_21)
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			List<Class304> arg_31_0 = this.list_1;
			if (Class371.action_6 == null)
			{
				Class371.action_6 = new Action<Class304>(Class371.smethod_15);
			}
			arg_31_0.ForEach(Class371.action_6);
			Vector2 vector2_ = this.method_42(bool_21);
			foreach (Class304 current in this.list_1)
			{
				Vector2 vector = Class371.smethod_0(current.Position, vector2_, int_4);
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = Class371.smethod_0(class.list_3[i], vector2_, int_4);
					}
					class.class306_0.vmethod_5(vector, false);
					class.Position = (class.vector2_0 = vector);
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(vector, false);
				}
			}
		}

		// Token: 0x06001BAC RID: 7084
		// RVA: 0x000916BC File Offset: 0x0008F8BC
		internal void method_38(Vector2 vector2_7, bool bool_21)
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			List<Class304> arg_31_0 = this.list_1;
			if (Class371.action_7 == null)
			{
				Class371.action_7 = new Action<Class304>(Class371.smethod_16);
			}
			arg_31_0.ForEach(Class371.action_7);
			Vector2 vector2_8 = this.method_42(bool_21);
			foreach (Class304 current in this.list_1)
			{
				Vector2 vector = Class371.smethod_1(current.Position, vector2_8, vector2_7);
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = Class371.smethod_1(class.list_3[i], vector2_8, vector2_7);
					}
					class.class306_0.vmethod_5(vector, false);
					class.Position = (class.vector2_0 = vector);
					class.SpatialLength = 0.0;
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(vector, false);
				}
			}
		}

		// Token: 0x06001BAD RID: 7085
		// RVA: 0x000917E8 File Offset: 0x0008F9E8
		internal int method_39(double double_1)
		{
			int num = this.editor_0.method_85();
			double num2 = Class331.smethod_22((double)num, false) / (double)this.editor_0.int_6;
			double num3 = this.class297_0.SliderVelocityAt(Class331.int_7) * double_1 * num2 / 1000.0;
			return (int)Math.Floor(3.1415901184082031 / Math.Asin(num3 / 180.0 / 2.0));
		}

		// Token: 0x06001B78 RID: 7032
		// RVA: 0x0008BD10 File Offset: 0x00089F10
		internal void method_4(int int_4)
		{
			this.bool_16 = true;
			int_4 = this.method_5(int_4);
			this.editor_0.int_6 = int_4;
			Class341.class608_2.Value = int_4;
			Class115.editorControl_0.method_10(int_4);
			if (!this.vmethod_27() || !Class570.bool_1)
			{
				this.class883_0.SetValue((double)int_4, false);
				this.class533_0.Text = "1/" + int_4;
			}
		}

		// Token: 0x06001BAE RID: 7086
		// RVA: 0x00091860 File Offset: 0x0008FA60
		internal bool method_40(int int_4, int int_5, double double_1, double double_2)
		{
			if (int_4 < 3)
			{
				return false;
			}
			int num = this.editor_0.method_85();
			double num2 = Class331.smethod_22((double)num, false) / (double)this.editor_0.int_6;
			double num3 = this.class297_0.SliderVelocityAt(Class331.int_7) * double_2 * num2 / 1000.0;
			double num4 = num3 / (2.0 * Math.Sin((double)(3.14159f / (float)int_4)));
			if (num4 > 180.0)
			{
				Class723.smethod_8(Class41.GetString(OsuString.EditorModeCompose_DistanceSnapTooLarge), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			this.editor_0.bool_3 = true;
			this.vmethod_35();
			this.editor_0.bool_3 = false;
			bool flag = true;
			for (int i = 1; i <= int_4 * int_5; i++)
			{
				Vector2 vector;
				vector..ctor((float)(num4 * Math.Cos((double)(6.28319f / (float)int_4 * (float)i) + double_1) + 256.0), (float)(num4 * Math.Sin((double)(6.28319f / (float)int_4 * (float)i) + double_1) + 192.0));
				Class306 class = new Class306(this.class297_0, vector, num, this.method_46(), Class371.dictionary_0[Enum106.flag_1], Class371.dictionary_0[Enum106.flag_2], Class371.dictionary_0[Enum106.flag_6], 0);
				if (flag && Class371.dictionary_0[Enum106.flag_0])
				{
					class.NewCombo = true;
				}
				flag = false;
				this.class297_0.Add(class, true);
				this.Select(class);
				num = this.editor_0.class375_0.method_5((double)num + num2);
			}
			this.class297_0.method_20(true);
			return true;
		}

		// Token: 0x06001BAF RID: 7087
		// RVA: 0x00091A00 File Offset: 0x0008FC00
		internal void method_41(int int_4, int int_5, bool bool_21)
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			List<Class304> arg_31_0 = this.list_1;
			if (Class371.action_8 == null)
			{
				Class371.action_8 = new Action<Class304>(Class371.smethod_17);
			}
			arg_31_0.ForEach(Class371.action_8);
			foreach (Class304 current in this.list_1)
			{
				current.vmethod_5(bool_21 ? new Vector2(current.Position.X + (float)int_4, current.Position.Y + (float)int_5) : new Vector2((float)int_4, (float)int_5), false);
			}
		}

		// Token: 0x06001BB1 RID: 7089
		// RVA: 0x00091B18 File Offset: 0x0008FD18
		private Vector2 method_42(bool bool_21)
		{
			if (bool_21)
			{
				return new Vector2((float)(Class115.int_18 / 2), (float)(Class115.int_17 / 2));
			}
			Vector2 vector = Vector2.get_Zero();
			foreach (Class304 current in this.list_1)
			{
				vector += current.vector2_0;
			}
			vector.X /= (float)this.list_1.Count;
			vector.Y /= (float)this.list_1.Count;
			return vector;
		}

		// Token: 0x06001BB2 RID: 7090
		// RVA: 0x00091BC8 File Offset: 0x0008FDC8
		internal float method_43(bool bool_21)
		{
			if (this.list_1.Count == 0)
			{
				return -1f;
			}
			Vector2 vector = this.method_42(bool_21);
			float num = vector.X;
			float num2 = vector.Y;
			float num3 = vector.X;
			float num4 = vector.Y;
			foreach (Class304 current in this.list_1)
			{
				num = Math.Min(current.Position.X, num);
				num2 = Math.Min(current.Position.Y, num2);
				num3 = Math.Max(current.Position.X, num3);
				num4 = Math.Max(current.Position.Y, num4);
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					num = Math.Min(class.EndPosition.X, num);
					num2 = Math.Min(class.EndPosition.Y, num2);
					num3 = Math.Max(class.EndPosition.X, num3);
					num4 = Math.Max(class.EndPosition.Y, num4);
				}
			}
			num -= vector.X;
			num2 -= vector.Y;
			num3 -= vector.X;
			num4 -= vector.Y;
			float num5 = -vector.X / num;
			float num6 = -vector.Y / num2;
			float num7 = (num3 == 0f) ? num5 : (((float)Class115.int_18 - vector.X) / num3);
			float num8 = (num4 == 0f) ? num6 : (((float)Class115.int_17 - vector.Y) / num4);
			if (num == 0f)
			{
				num5 = num7;
			}
			if (num2 == 0f)
			{
				num6 = num8;
			}
			if (num == 0f && num3 == 0f && num2 == 0f && num4 == 0f)
			{
				return -1f;
			}
			if (num == 0f && num3 == 0f)
			{
				return Math.Min(num6, num8);
			}
			if (num2 == 0f && num4 == 0f)
			{
				return Math.Min(num5, num7);
			}
			return Math.Min(Math.Min(num5, num7), Math.Min(num6, num8));
		}

		// Token: 0x06001BB3 RID: 7091
		// RVA: 0x0001707A File Offset: 0x0001527A
		internal void method_44()
		{
			this.method_45(this.list_1);
		}

		// Token: 0x06001BB4 RID: 7092
		// RVA: 0x00091E14 File Offset: 0x00090014
		private void method_45(List<Class304> list_3)
		{
			int num = 0;
			this.editor_0.method_16(false);
			foreach (Class304 current in list_3)
			{
				Class321 class = current as Class321;
				if (class != null)
				{
					class.method_27();
				}
				current.enum38_0 = Enum38.const_0;
				current.sampleSet_0 = SampleSet.None;
				current.sampleSet_1 = SampleSet.None;
				current.int_3 = 0;
				current.string_0 = string.Empty;
				current.int_2 = -1;
				current.SoundType = HitObjectSoundType.None;
			}
			if (num > 0)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorModeCompose_SelectedSampleReset), 2000);
			}
		}

		// Token: 0x06001BB5 RID: 7093
		// RVA: 0x00017088 File Offset: 0x00015288
		private bool method_46()
		{
			return this.class297_0.list_3.FindLast(new Predicate<Class304>(this.method_71)) is Class325;
		}

		// Token: 0x06001BB8 RID: 7096
		// RVA: 0x00092878 File Offset: 0x00090A78
		protected void method_47(Class304 class304_3)
		{
			if (this.class304_2 != null)
			{
				class304_3.SoundType = this.class304_2.SoundType;
				class304_3.enum38_0 = this.class304_2.enum38_0;
				class304_3.sampleSet_0 = this.class304_2.sampleSet_0;
				class304_3.sampleSet_1 = this.class304_2.sampleSet_1;
				class304_3.string_0 = this.class304_2.string_0;
				class304_3.int_2 = this.class304_2.int_2;
				class304_3.int_3 = this.class304_2.int_3;
				Class723.smethod_5(Class41.GetString(OsuString.EditorModeCompose_SampleApplied), Color.get_YellowGreen(), 700, null);
				return;
			}
			Class723.smethod_1(Class41.GetString(OsuString.EditorModeCompose_SelectNoteBeforeSampleCopy), 1500);
		}

		// Token: 0x06001BBA RID: 7098
		// RVA: 0x0009298C File Offset: 0x00090B8C
		internal void method_48(Class371.Enum42 enum42_1)
		{
			if (!this.vmethod_26(enum42_1))
			{
				return;
			}
			this.method_55(true);
			this.method_53();
			if (this.enum42_0 == Class371.Enum42.const_0 && enum42_1 != this.enum42_0)
			{
				this.vmethod_17();
			}
			this.enum42_0 = enum42_1;
			for (int i = 0; i < this.class531_0.Length; i++)
			{
				if (i != (int)this.enum42_0)
				{
					this.class531_0[i].class26_0.Add(new Class746(TransformationType.Fade, this.class531_0[i].float_3, 0.4f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
				}
				else
				{
					this.class531_0[i].class26_0.Add(new Class746(TransformationType.Fade, 1f, 0.9f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
				}
			}
		}

		// Token: 0x06001BBB RID: 7099
		// RVA: 0x000170D7 File Offset: 0x000152D7
		private void method_49()
		{
			this.method_10(Enum106.flag_1, false);
			this.method_10(Enum106.flag_2, false);
			this.method_10(Enum106.flag_6, false);
			this.method_10(Enum106.flag_0, false);
		}

		// Token: 0x06001B79 RID: 7033
		// RVA: 0x00016EF8 File Offset: 0x000150F8
		internal int method_5(int int_4)
		{
			if (int_4 > 16)
			{
				int_4 = 1;
			}
			if (int_4 == 5)
			{
				int_4 = 4;
			}
			if (int_4 == 7)
			{
				int_4 = 6;
			}
			if (int_4 >= 9 && int_4 <= 11)
			{
				int_4 = 12;
			}
			if (int_4 > 12 && int_4 < 16)
			{
				int_4 = 16;
			}
			return int_4;
		}

		// Token: 0x06001BBC RID: 7100
		// RVA: 0x00092A58 File Offset: 0x00090C58
		private void method_50(Enum106 enum106_0)
		{
			foreach (Enum106 enum in Enum.GetValues(typeof(Enum106)))
			{
				if ((enum & enum106_0) > (Enum106)0)
				{
					this.method_18(enum);
				}
				else
				{
					this.class911_0.method_11(enum)[0].method_16(300, Enum70.const_0);
				}
			}
		}

		// Token: 0x06001BBD RID: 7101
		// RVA: 0x00092AE8 File Offset: 0x00090CE8
		private void method_51(object sender, EventArgs e)
		{
			if (this.vmethod_14())
			{
				return;
			}
			for (int i = 0; i < this.class531_0.Length; i++)
			{
				if (this.class531_0[i].Equals(sender))
				{
					Class371.Enum42 enum42_ = (Class371.Enum42)i;
					this.method_48(enum42_);
					return;
				}
			}
		}

		// Token: 0x06001BBE RID: 7102
		// RVA: 0x000170FA File Offset: 0x000152FA
		internal void method_52()
		{
			if (this.class304_0 != null)
			{
				this.class297_0.Remove(this.class304_0, true);
			}
		}

		// Token: 0x06001BBF RID: 7103
		// RVA: 0x00017117 File Offset: 0x00015317
		private void method_53()
		{
			this.method_54(this.editor_0.method_85());
		}

		// Token: 0x06001BC0 RID: 7104
		// RVA: 0x00092B2C File Offset: 0x00090D2C
		private void method_54(int int_4)
		{
			if (this.class328_0 != null && this.bool_15)
			{
				if (int_4 != this.class328_0.EndTime)
				{
					this.editor_0.method_16(false);
					this.class328_0.vmethod_19(Math.Max(this.class328_0.StartTime, int_4));
				}
				if (this.class328_0.EndTime <= this.class328_0.StartTime)
				{
					this.class297_0.Remove(this.class328_0, true);
				}
				this.class328_0 = null;
				return;
			}
		}

		// Token: 0x06001BC1 RID: 7105
		// RVA: 0x00092BB4 File Offset: 0x00090DB4
		private void method_55(bool bool_21)
		{
			if (this.class321_2 != null && this.bool_15)
			{
				if (this.class321_2.list_3.Count != 1)
				{
					if (this.class321_2.SpatialLength != 0.0)
					{
						this.editor_0.method_16(false);
						this.class321_2.method_15(Class331.int_7);
						if (bool_21)
						{
							this.class321_2.method_16(true, false);
							goto IL_7C;
						}
						goto IL_7C;
					}
				}
				this.class297_0.Remove(this.class321_2, true);
				IL_7C:
				this.class321_2 = null;
				return;
			}
		}

		// Token: 0x06001BC5 RID: 7109
		// RVA: 0x0001712A File Offset: 0x0001532A
		internal void method_56(Class304 class304_3)
		{
			if (this.list_1.Contains(class304_3))
			{
				class304_3.method_3(false);
				this.list_1.Remove(class304_3);
				this.bool_14 = true;
			}
		}

		// Token: 0x06001BC8 RID: 7112
		// RVA: 0x00017155 File Offset: 0x00015355
		internal void method_57()
		{
			List<Class304> arg_23_0 = this.list_1;
			if (Class371.action_11 == null)
			{
				Class371.action_11 = new Action<Class304>(Class371.smethod_20);
			}
			arg_23_0.ForEach(Class371.action_11);
		}

		// Token: 0x06001BCB RID: 7115
		// RVA: 0x0001717F File Offset: 0x0001537F
		internal void method_58()
		{
			this.method_45(this.class297_0.list_3);
		}

		// Token: 0x06001BCC RID: 7116
		// RVA: 0x00017192 File Offset: 0x00015392
		private void method_59(object sender, EventArgs e)
		{
			this.class531_2.class26_0.Clear();
			this.class531_2.method_14(200, Enum70.const_0);
		}

		// Token: 0x06001B7A RID: 7034
		// RVA: 0x0008BD88 File Offset: 0x00089F88
		internal void method_6(double double_1)
		{
			double_1 = Math.Round(double_1, 2);
			this.double_0 = double_1;
			Class341.class607_2.Value = double_1;
			if (Class570.bool_1)
			{
				this.class883_0.SetValue(double_1, false);
				this.class533_0.Text = string.Format("{0:0.0#}x", this.double_0);
			}
		}

		// Token: 0x06001BCD RID: 7117
		// RVA: 0x00093144 File Offset: 0x00091344
		private void method_60(object sender, EventArgs e)
		{
			if (this.class597_0.method_3())
			{
				this.class531_2.class26_0.Clear();
				this.class531_2.method_14(200, Enum70.const_0);
				return;
			}
			this.class531_2.class26_0.Clear();
			this.class531_2.method_25(0.003921569f, 50, Enum70.const_0);
		}

		// Token: 0x06001BCE RID: 7118
		// RVA: 0x000171B5 File Offset: 0x000153B5
		private void method_61(object sender, EventArgs e)
		{
			if (this.class597_0.method_3())
			{
				this.class597_0.method_2();
				return;
			}
			this.class597_0.method_1();
		}

		// Token: 0x06001BCF RID: 7119
		// RVA: 0x000931A4 File Offset: 0x000913A4
		private void method_62()
		{
			this.class531_2.bool_1 = false;
			this.class531_2.class26_0.Clear();
			this.class531_2.method_16(50, Enum70.const_0);
			this.class531_2.method_36(new EventHandler(this.method_59));
			this.class531_2.method_38(new EventHandler(this.method_60));
			this.class531_1[0].vmethod_7(Class885.Load("editor-draw-newcombo", Enum112.flag_1));
		}

		// Token: 0x06001BD0 RID: 7120
		// RVA: 0x000171DB File Offset: 0x000153DB
		private void method_63(object sender, EventArgs e)
		{
			this.method_60(this, EventArgs.Empty);
		}

		// Token: 0x06001BD1 RID: 7121
		// RVA: 0x00093224 File Offset: 0x00091424
		private void method_64(Color color_6, int int_4, int int_5, bool bool_21, EventHandler eventHandler_0)
		{
			Class598 class = new Class598(this.class597_0, this.class911_0, new Vector2(32f, 32f), new Vector2((float)(Class115.smethod_43() - 70), (float)(80 + 20 * int_5)), bool_21);
			Class531 class2 = new Class531(Class885.Load("hitcircle", Enum112.flag_1), Enum115.const_2, Origins.TopLeft, Enum114.const_0, new Vector2((float)(Class115.smethod_43() - 70), (float)(80 + 20 * int_5)), 2f, true, new Color(color_6.get_R(), color_6.get_G(), color_6.get_B(), 0), null);
			Class531 class3 = new Class531(Class885.Load("hitcircleoverlay", Enum112.flag_1), Enum115.const_2, Origins.TopLeft, Enum114.const_0, new Vector2((float)(Class115.smethod_43() - 70), (float)(80 + 20 * int_5)), 3f, true, Color.get_TransparentWhite(), null);
			class2.float_2 = 0.15625f;
			class3.float_2 = 0.15625f;
			this.class911_0.Add(class2);
			this.class911_0.Add(class3);
			class.list_0.Add(class2);
			class.list_0.Add(class3);
			class.int_0 = int_4;
			class.method_2(new EventHandler(this.method_12));
			this.class597_0.list_0.Add(class);
		}

		// Token: 0x06001BD2 RID: 7122
		// RVA: 0x0009335C File Offset: 0x0009155C
		private void method_65()
		{
			if (this.list_1.Count != 1)
			{
				this.method_62();
				return;
			}
			Class304 class = this.list_1[0];
			if (!class.NewCombo)
			{
				this.method_62();
				return;
			}
			this.class531_1[0].vmethod_7(Class885.Load("editor-draw-newcombo-expandable", Enum112.flag_1));
			this.class531_2.bool_1 = true;
			this.class531_2.method_35(new EventHandler(this.method_59));
			this.class531_2.method_37(new EventHandler(this.method_60));
			this.class531_2.method_25(0.003921569f, 0, Enum70.const_0);
			this.class597_0.ClearItems();
			int count = this.class297_0.list_2.Count;
			int num = class.int_1 - class.int_0;
			if (num < 0)
			{
				num -= num / this.class297_0.list_2.Count * this.class297_0.list_2.Count;
				num += this.class297_0.list_2.Count;
			}
			int num2 = this.editor_0.class297_0.method_22(class, true) ? count : (count - 1);
			for (int i = 0; i < num2; i++)
			{
				Color color_ = this.class297_0.list_2[(num + i) % count];
				this.method_64(color_, i, i, i == class.int_0, new EventHandler(this.method_12));
			}
		}

		// Token: 0x06001BD3 RID: 7123
		// RVA: 0x000934CC File Offset: 0x000916CC
		internal void method_66()
		{
			if (this.list_1.Count == 0)
			{
				if (this.bool_14)
				{
					this.class753_0.method_18(SampleSet.None, true);
					this.class753_1.method_18(SampleSet.None, true);
					return;
				}
			}
			else
			{
				if (this.class321_1 != null)
				{
					SampleSet sampleSet = SampleSet.None;
					SampleSet sampleSet2 = SampleSet.None;
					if (this.class321_1.bool_10)
					{
						sampleSet = this.class321_1.sampleSet_0;
						sampleSet2 = this.class321_1.sampleSet_1;
					}
					else
					{
						int num;
						bool flag;
						if (this.class321_1.class306_0.method_2())
						{
							sampleSet = this.class321_1.list_9[0];
							sampleSet2 = this.class321_1.list_10[0];
							num = 0;
							flag = true;
						}
						else
						{
							List<Class311> arg_DE_0 = this.class321_1.list_2;
							if (Class371.predicate_7 == null)
							{
								Class371.predicate_7 = new Predicate<Class311>(Class371.smethod_22);
							}
							num = arg_DE_0.FindIndex(Class371.predicate_7);
							if (num >= 0)
							{
								sampleSet = this.class321_1.list_9[num + 1];
								sampleSet2 = this.class321_1.list_10[num + 1];
								flag = true;
							}
							else
							{
								flag = false;
							}
						}
						if (flag)
						{
							bool flag2 = true;
							bool flag3 = true;
							while (flag2 || flag3)
							{
								Class311 class = this.class321_1.list_2[num];
								if (class.method_2())
								{
									if (flag2)
									{
										flag2 = (this.class321_1.list_9[num + 1] == sampleSet);
									}
									if (flag3)
									{
										flag3 = (this.class321_1.list_10[num + 1] == sampleSet2);
									}
								}
								num++;
								if (num >= this.class321_1.list_2.Count)
								{
									IL_19D:
									if (!flag2)
									{
										sampleSet = SampleSet.None;
									}
									if (!flag3)
									{
										sampleSet2 = SampleSet.None;
										goto IL_1C3;
									}
									goto IL_1C3;
								}
							}
							goto IL_19D;
						}
						sampleSet = this.class321_1.sampleSet_0;
						sampleSet2 = this.class321_1.sampleSet_1;
					}
					IL_1C3:
					this.class753_0.method_18(sampleSet, true);
					this.class753_1.method_18(sampleSet2, true);
					return;
				}
				SampleSet sampleSet3 = this.list_1[0].sampleSet_0;
				SampleSet sampleSet4 = this.list_1[0].sampleSet_1;
				bool flag4 = true;
				bool flag5 = true;
				foreach (Class304 current in this.list_1)
				{
					if (flag4)
					{
						flag4 = (current.sampleSet_0 == sampleSet3);
					}
					if (flag5)
					{
						flag5 = (current.sampleSet_1 == sampleSet4);
					}
					if (!flag4 && !flag5)
					{
						break;
					}
				}
				if (!flag4)
				{
					sampleSet3 = SampleSet.None;
				}
				if (!flag5)
				{
					sampleSet4 = SampleSet.None;
				}
				this.class753_0.method_18(sampleSet3, true);
				this.class753_1.method_18(sampleSet4, true);
			}
		}

		// Token: 0x06001BD4 RID: 7124
		// RVA: 0x00093794 File Offset: 0x00091994
		internal void method_67()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			if (this.editor_0.enum108_0 != Enum108.const_1 && this.enum42_0 != Class371.Enum42.const_0 && this.editor_0.bool_15)
			{
				this.vmethod_17();
				return;
			}
			bool arg_3F_0 = true;
			bool flag = true;
			bool flag2 = true;
			bool flag3 = true;
			bool flag4 = arg_3F_0;
			if (this.class321_1 != null)
			{
				flag = this.class321_1.NewCombo;
				if (this.class321_1.bool_10)
				{
					flag3 &= this.class321_1.Whistle;
					flag4 &= this.class321_1.Finish;
					flag2 &= this.class321_1.Clap;
				}
				else
				{
					int num = 0;
					for (int i = 0; i < this.class321_1.method_9().Count; i++)
					{
						Class306 class = this.class321_1.method_9()[i];
						if (class.method_2())
						{
							flag3 &= this.class321_1.list_8[i].IsType(HitObjectSoundType.Whistle);
							flag4 &= this.class321_1.list_8[i].IsType(HitObjectSoundType.Finish);
							flag2 &= this.class321_1.list_8[i].IsType(HitObjectSoundType.Clap);
							num++;
						}
					}
					if (num == 0)
					{
						flag3 &= this.class321_1.Whistle;
						flag4 &= this.class321_1.Finish;
						flag2 &= this.class321_1.Clap;
					}
				}
			}
			else
			{
				foreach (Class304 current in this.list_1)
				{
					flag &= current.NewCombo;
					flag3 &= current.Whistle;
					flag4 &= current.Finish;
					flag2 &= current.Clap;
				}
			}
			this.method_10(Enum106.flag_1, flag3);
			this.method_10(Enum106.flag_2, flag4);
			this.method_10(Enum106.flag_6, flag2);
			this.method_10(Enum106.flag_0, flag);
		}

		// Token: 0x06001BD5 RID: 7125
		// RVA: 0x0009398C File Offset: 0x00091B8C
		internal void method_68(string string_0, int int_4)
		{
			foreach (Class304 current in this.list_1)
			{
				current.int_3 = int_4;
				current.method_5(string_0);
			}
		}

		// Token: 0x06001BD6 RID: 7126
		// RVA: 0x000939E8 File Offset: 0x00091BE8
		internal void method_69(int int_4, int int_5)
		{
			foreach (Class304 current in this.list_1)
			{
				current.int_3 = int_5;
				current.enum38_0 = (Enum38)int_4;
			}
		}

		// Token: 0x06001B7B RID: 7035
		// RVA: 0x00016F2D File Offset: 0x0001512D
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_14())
			{
				return;
			}
			this.method_3(Class331.int_7, true);
		}

		// Token: 0x06001BD7 RID: 7127
		// RVA: 0x00093A44 File Offset: 0x00091C44
		internal void method_70()
		{
			if (this.editor_0.playModes_0 != PlayModes.OsuMania)
			{
				return;
			}
			int num = 0;
			List<Class304> list_ = this.class297_0.list_3;
			for (int i = 0; i < list_.Count; i++)
			{
				if (list_[i].StartTime != list_[num].StartTime)
				{
					int num2 = i - num;
					if (num2 < 1)
					{
						num2 = 1;
					}
					int num3 = Class331.smethod_24((double)list_[num].StartTime).int_0;
					for (int j = num; j < i; j++)
					{
						list_[j].int_3 = num3 * 4 / 3 / num2;
					}
					num = i;
				}
			}
		}

		// Token: 0x06001BE9 RID: 7145
		// RVA: 0x0001721B File Offset: 0x0001541B
		[CompilerGenerated]
		private bool method_71(Class304 class304_3)
		{
			return class304_3.EndTime < Class331.int_7 && class304_3 != this.class304_0;
		}

		// Token: 0x06001B7C RID: 7036
		// RVA: 0x0008BDE4 File Offset: 0x00089FE4
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_14())
			{
				return;
			}
			Enum106 enum106_ = (Enum106)((Class531)sender).object_0;
			this.method_9(enum106_);
		}

		// Token: 0x06001B7D RID: 7037
		// RVA: 0x00016F44 File Offset: 0x00015144
		internal void method_9(Enum106 enum106_0)
		{
			this.method_15(enum106_0, !Class371.dictionary_0[enum106_0], true);
		}

		// Token: 0x06001BC3 RID: 7107
		// RVA: 0x00092CB4 File Offset: 0x00090EB4
		internal virtual void Select(HitObjectBase[] hitObjectBase_0)
		{
			if (this.class705_0 != null)
			{
				return;
			}
			this.vmethod_17();
			this.list_1 = new List<Class304>();
			for (int i = 0; i < hitObjectBase_0.Length; i++)
			{
				HitObjectBase hitObjectBase = hitObjectBase_0[i];
				this.list_1.Add(hitObjectBase as Class304);
			}
			List<Class304> arg_62_0 = this.list_1;
			if (Class371.action_9 == null)
			{
				Class371.action_9 = new Action<Class304>(Class371.smethod_18);
			}
			arg_62_0.ForEach(Class371.action_9);
			this.bool_14 = true;
		}

		// Token: 0x06001BC4 RID: 7108
		// RVA: 0x00092D30 File Offset: 0x00090F30
		internal virtual void Select(Class304 class304_3)
		{
			if (this.class705_0 != null)
			{
				return;
			}
			if (this.enum42_0 != Class371.Enum42.const_0)
			{
				this.method_48(Class371.Enum42.const_0);
			}
			if (!this.list_1.Contains(class304_3))
			{
				class304_3.method_3(true);
				this.list_1.Add(class304_3);
				this.bool_14 = true;
			}
		}

		// Token: 0x06001BAB RID: 7083
		// RVA: 0x000915BC File Offset: 0x0008F7BC
		private static Vector2 smethod_0(Vector2 vector2_7, Vector2 vector2_8, int int_4)
		{
			int_4 = -int_4;
			vector2_7.X -= vector2_8.X;
			vector2_7.Y -= vector2_8.Y;
			Vector2 result;
			result.X = (float)((double)vector2_7.X * Math.Cos((double)((float)int_4 / 180f) * 3.1415926535897931) + (double)vector2_7.Y * Math.Sin((double)((float)int_4 / 180f) * 3.1415926535897931));
			result.Y = (float)((double)vector2_7.X * -(float)Math.Sin((double)((float)int_4 / 180f) * 3.1415926535897931) + (double)vector2_7.Y * Math.Cos((double)((float)int_4 / 180f) * 3.1415926535897931));
			result.X += vector2_8.X;
			result.Y += vector2_8.Y;
			return result;
		}

		// Token: 0x06001BB0 RID: 7088
		// RVA: 0x00091ABC File Offset: 0x0008FCBC
		private static Vector2 smethod_1(Vector2 vector2_7, Vector2 vector2_8, Vector2 vector2_9)
		{
			return new Vector2(vector2_9.X * vector2_7.X + (1f - vector2_9.X) * vector2_8.X, vector2_9.Y * vector2_7.Y + (1f - vector2_9.Y) * vector2_8.Y);
		}

		// Token: 0x06001BE1 RID: 7137
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_10(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE2 RID: 7138
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_11(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE3 RID: 7139
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_12(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE4 RID: 7140
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_13(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE5 RID: 7141
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_14(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE6 RID: 7142
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_15(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE7 RID: 7143
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_16(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE8 RID: 7144
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_17(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BEA RID: 7146
		// RVA: 0x00017238 File Offset: 0x00015438
		[CompilerGenerated]
		private static void smethod_18(Class304 class304_3)
		{
			class304_3.method_3(true);
		}

		// Token: 0x06001BEB RID: 7147
		// RVA: 0x00017241 File Offset: 0x00015441
		[CompilerGenerated]
		private static void smethod_19(Class304 class304_3)
		{
			class304_3.method_3(false);
		}

		// Token: 0x06001BD9 RID: 7129
		// RVA: 0x000171E9 File Offset: 0x000153E9
		[CompilerGenerated]
		private static bool smethod_2(Class304 class304_3)
		{
			return !class304_3.IsType(HitObjectType.Spinner);
		}

		// Token: 0x06001BEC RID: 7148
		// RVA: 0x00017238 File Offset: 0x00015438
		[CompilerGenerated]
		private static void smethod_20(Class304 class304_3)
		{
			class304_3.method_3(true);
		}

		// Token: 0x06001BED RID: 7149
		// RVA: 0x0001724A File Offset: 0x0001544A
		[CompilerGenerated]
		private static int smethod_21(Class304 class304_3, Class304 class304_4)
		{
			return class304_3.StartTime.CompareTo(class304_4.StartTime);
		}

		// Token: 0x06001BEE RID: 7150
		// RVA: 0x000171F5 File Offset: 0x000153F5
		[CompilerGenerated]
		private static bool smethod_22(Class311 class311_0)
		{
			return class311_0.method_2();
		}

		// Token: 0x06001BDA RID: 7130
		// RVA: 0x000171F5 File Offset: 0x000153F5
		[CompilerGenerated]
		private static bool smethod_3(Class311 class311_0)
		{
			return class311_0.method_2();
		}

		// Token: 0x06001BDB RID: 7131
		// RVA: 0x000171F5 File Offset: 0x000153F5
		[CompilerGenerated]
		private static bool smethod_4(Class311 class311_0)
		{
			return class311_0.method_2();
		}

		// Token: 0x06001BDC RID: 7132
		// RVA: 0x000171F5 File Offset: 0x000153F5
		[CompilerGenerated]
		private static bool smethod_5(Class311 class311_0)
		{
			return class311_0.method_2();
		}

		// Token: 0x06001BDD RID: 7133
		// RVA: 0x000171FD File Offset: 0x000153FD
		[CompilerGenerated]
		private static bool smethod_6(Class530 class530_0)
		{
			return class530_0.object_0 != null;
		}

		// Token: 0x06001BDE RID: 7134
		// RVA: 0x0001720B File Offset: 0x0001540B
		[CompilerGenerated]
		private static bool smethod_7(Class304 class304_3)
		{
			return class304_3.vmethod_9();
		}

		// Token: 0x06001BDF RID: 7135
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_8(Class304 class304_3)
		{
			class304_3.method_4();
		}

		// Token: 0x06001BE0 RID: 7136
		// RVA: 0x000171F5 File Offset: 0x000153F5
		[CompilerGenerated]
		private static bool smethod_9(Class304 class304_3)
		{
			return class304_3.method_2();
		}

		// Token: 0x06001B66 RID: 7014
		// RVA: 0x00016E41 File Offset: 0x00015041
		internal override bool vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x06001B67 RID: 7015
		// RVA: 0x00016E49 File Offset: 0x00015049
		internal override void vmethod_1(bool bool_21)
		{
			base.vmethod_1(bool_21);
			this.class297_0.class911_0.bool_6 = bool_21;
			if (this.class297_1 != null)
			{
				this.class297_1.class911_0.bool_6 = bool_21;
			}
			this.method_48(Class371.Enum42.const_0);
		}

		// Token: 0x06001B9D RID: 7069
		// RVA: 0x000903B4 File Offset: 0x0008E5B4
		internal override bool vmethod_10(Keys keys_0, bool bool_21)
		{
			if (Class111.bool_2)
			{
				return false;
			}
			if (bool_21)
			{
				Bindings bindings = Class795.smethod_4(keys_0, BindingTarget.Universal);
				if (this.editor_0.playModes_0 != PlayModes.OsuMania && this.editor_0.bool_10 && this.editor_0.bool_15 && Class331.enum100_0 != Enum100.const_0)
				{
					switch (bindings)
					{
					case Bindings.TaikoInnerLeft:
						this.method_26(false);
						return true;
					case Bindings.TaikoInnerRight:
						this.method_26(false);
						return true;
					case Bindings.TaikoOuterLeft:
						this.method_26(true);
						return true;
					case Bindings.TaikoOuterRight:
						this.method_26(true);
						return true;
					}
				}
				if (Class570.bool_2)
				{
					if (keys_0 <= 69)
					{
						switch (keys_0)
						{
						case 49:
							this.method_4(1);
							return true;
						case 50:
							this.method_4(2);
							return true;
						case 51:
							this.method_4(3);
							return true;
						case 52:
							this.method_4(4);
							return true;
						case 53:
						case 55:
							break;
						case 54:
							this.method_4(6);
							return true;
						case 56:
							this.method_4(8);
							return true;
						default:
							if (keys_0 == 69)
							{
								this.class753_0.method_18(SampleSet.Soft, false);
								return true;
							}
							break;
						}
					}
					else
					{
						switch (keys_0)
						{
						case 81:
							this.class753_0.method_18(SampleSet.None, false);
							return true;
						case 82:
							if (Class570.bool_0)
							{
								this.editor_0.method_90();
							}
							else
							{
								this.class753_0.method_18(SampleSet.Drum, false);
							}
							return true;
						default:
							if (keys_0 == 87)
							{
								this.class753_0.method_18(SampleSet.Normal, false);
								return true;
							}
							break;
						}
					}
				}
				else if (Class570.bool_0)
				{
					if (keys_0 <= 77)
					{
						if (keys_0 == 9)
						{
							this.method_27();
							return true;
						}
						switch (keys_0)
						{
						case 65:
							this.vmethod_16();
							return true;
						case 68:
							this.method_34();
							return true;
						case 69:
							this.class753_1.method_18(SampleSet.Soft, false);
							return true;
						case 71:
							this.method_33();
							return true;
						case 72:
							this.vmethod_33();
							return true;
						case 74:
							this.vmethod_34();
							return true;
						case 77:
							this.method_4(this.editor_0.int_6 * 2 % 15);
							return true;
						}
					}
					else
					{
						switch (keys_0)
						{
						case 81:
							this.class753_1.method_18(SampleSet.None, false);
							return true;
						case 82:
							this.class753_1.method_18(SampleSet.Drum, false);
							return true;
						case 83:
						case 84:
						case 85:
							break;
						case 86:
							this.vmethod_19();
							return true;
						case 87:
							this.class753_1.method_18(SampleSet.Normal, false);
							return true;
						case 88:
							this.vmethod_32();
							return true;
						default:
							switch (keys_0)
							{
							case 188:
								this.method_35();
								return true;
							case 190:
								this.method_36();
								return true;
							}
							break;
						}
					}
				}
				else
				{
					switch (Class795.smethod_4(keys_0, BindingTarget.Editor))
					{
					case Bindings.SelectTool:
						this.method_48(Class371.Enum42.const_0);
						return true;
					case Bindings.NormalTool:
						this.method_48(Class371.Enum42.const_1);
						return true;
					case Bindings.SliderTool:
						this.method_48(Class371.Enum42.const_2);
						return true;
					case Bindings.SpinnerTool:
						this.method_48(Class371.Enum42.const_3);
						return true;
					case Bindings.NewComboToggle:
						this.method_9(Enum106.flag_0);
						return true;
					case Bindings.WhistleToggle:
						this.method_9(Enum106.flag_1);
						return true;
					case Bindings.FinishToggle:
						this.method_9(Enum106.flag_2);
						return true;
					case Bindings.ClapToggle:
						this.method_9(Enum106.flag_6);
						return true;
					case Bindings.GridSnapToggle:
						this.method_9(Enum106.flag_3);
						return true;
					case Bindings.DistSnapToggle:
						this.method_9(Enum106.flag_4);
						return true;
					case Bindings.NoteLockToggle:
						this.method_9(Enum106.flag_5);
						return true;
					case Bindings.NudgeLeft:
						this.method_31();
						return true;
					case Bindings.NudgeRight:
						this.method_32();
						return true;
					default:
						if (keys_0 == 46)
						{
							this.vmethod_35();
							return true;
						}
						switch (keys_0)
						{
						case 107:
							this.method_30();
							return true;
						case 109:
							this.method_29();
							return true;
						}
						break;
					}
				}
			}
			if (this.list_1 != null && this.list_1.Count != 0 && Class570.bool_0 && !this.bool_19)
			{
				float num = 1f;
				float x = this.list_1[0].vector2_0.X;
				float y = this.list_1[0].vector2_0.Y;
				if (this.bool_3)
				{
					num = (float)(this.editor_0.int_2 / 2) + 0.1f;
				}
				switch (keys_0)
				{
				case 37:
					this.vmethod_28(x - num, y, true);
					return true;
				case 38:
					this.vmethod_28(x, y - num, true);
					return true;
				case 39:
					this.vmethod_28(x + num, y, true);
					return true;
				case 40:
					this.vmethod_28(x, y + num, true);
					return true;
				}
			}
			return base.vmethod_10(keys_0, bool_21);
		}

		// Token: 0x06001B95 RID: 7061
		// RVA: 0x00016F80 File Offset: 0x00015180
		internal override void vmethod_11()
		{
			Class115.smethod_68(1f, false);
			this.editor_0.int_10 = 12;
			this.class883_0.method_3(true);
			this.class883_0.method_3(true);
			base.vmethod_11();
		}

		// Token: 0x06001B96 RID: 7062
		// RVA: 0x00016FB8 File Offset: 0x000151B8
		internal override void vmethod_12()
		{
			this.method_55(true);
			this.method_53();
			this.vmethod_17();
			Class802.smethod_15();
			this.class883_0.method_3(false);
			base.vmethod_12();
		}

		// Token: 0x06001B94 RID: 7060
		// RVA: 0x0008F6D0 File Offset: 0x0008D8D0
		internal override void vmethod_13()
		{
			List<Class880> list = new List<Class880>();
			foreach (Class304 current in this.list_2)
			{
				float num = this.editor_0.method_69((double)current.StartTime);
				float num2 = this.editor_0.method_69((double)current.EndTime);
				byte b = 170;
				if (num > (float)(this.editor_0.int_4 + this.editor_0.int_11 / 2))
				{
					b = (byte)Math.Min(170.0, 170.0 * (double)Math.Min(num - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num - (float)this.editor_0.int_4)) / 40.0);
				}
				else if (num2 < (float)(this.editor_0.int_4 + this.editor_0.int_11 / 2))
				{
					b = (byte)Math.Min(170.0, 170.0 * (double)Math.Min(num2 - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num2 - (float)this.editor_0.int_4)) / 40.0);
				}
				float num3 = (float)Class297.int_5 / 8f * Class115.float_4 - 1f;
				num = Math.Max(num * Class115.float_4, (float)this.editor_0.rectangle_2.get_Left() + num3);
				num2 = Math.Min(num2 * Class115.float_4, (float)this.editor_0.rectangle_2.get_Right() - num3);
				if (num <= num2)
				{
					list.Clear();
					list.Add(new Class880(new Vector2(num, (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)this.editor_0.rectangle_2.Height / 2f), new Vector2(num2, (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)this.editor_0.rectangle_2.Height / 2f)));
					Class115.class582_0.Draw(list, num3, new Color(current.Colour.get_R(), current.Colour.get_G(), current.Colour.get_B(), current.method_2() ? 255 : b), 0f, "Standard", true);
				}
			}
			foreach (Class705 current2 in this.editor_0.class872_0.list_0)
			{
				int num4 = 0;
				int num5 = 0;
				try
				{
					int num6 = this.class297_0.method_21(current2);
					num4 = this.class297_0.list_3[num6 - 1].EndTime;
					if (num6 < this.class297_0.int_14)
					{
						num5 = this.class297_0.list_3[num6].StartTime;
					}
					else
					{
						num5 = current2.int_0 + this.class297_0.PreEmpt;
					}
					goto IL_63D;
				}
				catch (ArgumentOutOfRangeException)
				{
					num4 = current2.int_2;
					num5 = current2.int_0 + this.class297_0.PreEmpt;
					goto IL_63D;
				}
				goto IL_34D;
				IL_35C:
				if ((this.editor_0.int_8 <= num5 && this.editor_0.int_9 >= num5) || (this.editor_0.int_8 >= num4 && this.editor_0.int_9 <= num5))
				{
					goto IL_39E;
				}
				continue;
				IL_34D:
				if (this.editor_0.int_9 < num4)
				{
					goto IL_35C;
				}
				IL_39E:
				list.Clear();
				Color color;
				Color color2;
				if (current2.int_0 - current2.int_2 < 50)
				{
					color..ctor(255, 0, 0, 150);
					color2..ctor(255, 0, 0, 150);
				}
				else
				{
					color = (current2.bool_3 ? new Color(40, 100, 100, 100) : new Color(100, 100, 100, 100));
					color2 = (current2.bool_4 ? new Color(40, 100, 100, 100) : new Color(100, 100, 100, 100));
				}
				list.Add(new Class880(new Vector2(this.editor_0.method_70((double)current2.int_2), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2)), new Vector2(this.editor_0.method_70((double)current2.int_0), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2))));
				list.Add(new Class881(new Vector2(this.editor_0.method_70((double)current2.int_0), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2)), new Vector2(this.editor_0.method_70((double)num5), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2)), color2));
				list.Add(new Class881(new Vector2(this.editor_0.method_70((double)num4), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2)), new Vector2(this.editor_0.method_70((double)current2.int_2), (float)this.editor_0.rectangle_2.get_Top() + 3f * Class115.float_4 + (float)(this.editor_0.rectangle_2.Height / 2)), color));
				Class115.class582_0.Draw(list, (float)(Class297.int_5 / 8) * Class115.float_4 - 1f, new Color(100, 100, 100, 150), 0f, "NoBlur", false);
				continue;
				IL_63D:
				if (this.editor_0.int_8 <= num4)
				{
					goto IL_34D;
				}
				goto IL_35C;
			}
		}

		// Token: 0x06001B6A RID: 7018
		// RVA: 0x00016E83 File Offset: 0x00015083
		internal override bool vmethod_14()
		{
			return this.class321_2 != null || this.int_1 >= 0 || (Class570.bool_0 && this.class321_1 != null);
		}

		// Token: 0x06001BC2 RID: 7106
		// RVA: 0x00092C48 File Offset: 0x00090E48
		internal override bool vmethod_15()
		{
			if (this.class321_2 != null)
			{
				this.class297_0.Remove(this.class321_2, true);
				this.class321_2 = null;
				return false;
			}
			if (this.class328_0 != null)
			{
				this.class297_0.Remove(this.class328_0, true);
				this.class328_0 = null;
				return false;
			}
			if (this.list_1.Count > 0)
			{
				this.vmethod_17();
				return false;
			}
			return true;
		}

		// Token: 0x06001BC6 RID: 7110
		// RVA: 0x00092D80 File Offset: 0x00090F80
		internal override void vmethod_16()
		{
			if (this.class705_0 != null)
			{
				return;
			}
			this.method_48(Class371.Enum42.const_0);
			this.method_21(true);
			this.vmethod_17();
			this.list_1.AddRange(this.class297_0.list_3);
			this.bool_14 = true;
			this.method_57();
		}

		// Token: 0x06001BC7 RID: 7111
		// RVA: 0x00092DD0 File Offset: 0x00090FD0
		internal override void vmethod_17()
		{
			this.method_49();
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.method_21(false);
			List<Class304> arg_3E_0 = this.list_1;
			if (Class371.action_10 == null)
			{
				Class371.action_10 = new Action<Class304>(Class371.smethod_19);
			}
			arg_3E_0.ForEach(Class371.action_10);
			if (this.class321_1 != null)
			{
				this.class321_1.method_28();
			}
			this.bool_14 = true;
			this.list_1.Clear();
		}

		// Token: 0x06001BC9 RID: 7113
		// RVA: 0x00092E48 File Offset: 0x00091048
		internal override void vmethod_18()
		{
			this.list_0.Clear();
			this.list_1.Sort();
			string text = string.Empty;
			int num = Class331.int_7;
			if (this.list_1.Count > 0)
			{
				text = " (";
				foreach (Class304 current in this.list_1)
				{
					text = text + current.ComboNumber + ",";
				}
				text = text.Trim(new char[]
				{
					','
				}) + ")";
				num = this.list_1[0].StartTime;
			}
			string str = string.Format("{0:00}:{1:00}:{2:000}", num / 60000, num % 60000 / 1000, num % 1000);
			try
			{
				Clipboard.SetText(str + text + " - ");
			}
			catch (Exception)
			{
				Class723.smethod_4(Class41.GetString(OsuString.General_Editor_ClipboardNotAvailable));
			}
			foreach (Class304 current2 in this.list_1)
			{
				Class304 item = current2.Clone();
				this.list_0.Add(item);
			}
			if (this.list_1.Count == 1 && Class371.dictionary_0[Enum106.flag_5])
			{
				this.class304_2 = this.list_1[0];
			}
		}

		// Token: 0x06001BCA RID: 7114
		// RVA: 0x00093004 File Offset: 0x00091204
		internal override void vmethod_19()
		{
			if (this.list_0 != null && this.list_0.Count != 0)
			{
				this.editor_0.method_16(false);
				this.vmethod_17();
				this.method_21(false);
				this.bool_10 = this.bool_11;
				List<Class304> arg_63_0 = this.list_0;
				if (Class371.comparison_0 == null)
				{
					Class371.comparison_0 = new Comparison<Class304>(Class371.smethod_21);
				}
				arg_63_0.Sort(Class371.comparison_0);
				int num = (Class331.smethod_17() ? this.editor_0.class375_0.method_5((double)Class331.int_7) : Class331.int_7) - this.list_0[0].StartTime;
				foreach (Class304 current in this.list_0)
				{
					Class304 class = current.Clone();
					if (current is Class321)
					{
						((Class321)class).method_13(class.StartTime + num, false);
					}
					else
					{
						class.vmethod_4(class.StartTime + num);
					}
					this.class297_0.Add(class, true);
					this.Select(class);
				}
				this.class297_0.method_20(true);
				return;
			}
		}

		// Token: 0x06001B75 RID: 7029
		// RVA: 0x0008B0A8 File Offset: 0x000892A8
		protected override void vmethod_2()
		{
			this.class883_0 = new Class883(this.class911_0, 1.0, 16.0, 1.0, new Vector2((float)(Class115.smethod_43() - 190), 25f), 140);
			this.class533_1 = new Class533(Class41.GetString(OsuString.EditorModeCompose_BeatSnapDivisor) + ":", 14f, new Vector2((float)(Class115.smethod_43() - 200), 0f), 1f, true, Color.get_White());
			this.class533_1.object_0 = Enum105.const_1;
			this.class911_0.Add(this.class533_1);
			this.class533_0 = new Class533(string.Empty, 14f, new Vector2((float)(Class115.smethod_43() - 40), 15f), 1f, true, Color.get_White());
			this.class533_0.object_0 = Enum105.const_1;
			this.class911_0.Add(this.class533_0);
			Class760 class = new Class760(Class41.GetString(OsuString.EditorModeCompose_InsertBreakTime), new Vector2((float)(Class115.smethod_43() - 190), 40f), new Vector2(130f, 22.5f), 1f, new Color(112, 152, 252), new EventHandler(this.method_7), true, false, null);
			class.method_0(new EventHandler(this.method_7));
			class.method_7(Class41.GetString(OsuString.EditorModeCompose_InsertBreakTooltip));
			this.class911_0.Add<Class531>(class.list_0);
			float num = Class611.smethod_0(Class115.form_0, false) / 96f;
			this.class533_2 = new Class533(string.Empty, 10f * num, new Vector2(70f, 120f), new Vector2((float)Class115.int_22 - 140f * Class115.float_4, Class115.float_0), 1f, true, Color.get_TransparentWhite(), true);
			this.class533_2.color_0 = new Color(255, 255, 255, 180);
			this.class533_2.nullable_2 = new bool?(true);
			this.class533_2.bool_17 = false;
			this.class533_2.enum72_0 = Enum72.const_2;
			this.class533_2.bool_15 = false;
			this.class911_0.Add(this.class533_2);
			this.class531_0 = new Class531[]
			{
				new Class531(Class885.Load("editor-draw-select", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 140f), 0.98f, true, Color.get_TransparentWhite(), null),
				new Class531(Class885.Load("editor-draw-normal", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 200f), 0.98f, true, Color.get_TransparentWhite(), null),
				new Class531(Class885.Load("editor-draw-slider", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 260f), 0.98f, true, Color.get_TransparentWhite(), null),
				new Class531(Class885.Load("editor-draw-spinner", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 320f), 0.98f, true, Color.get_TransparentWhite(), null),
				new Class531(Class885.Load("editor-draw-hold", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 260f), 0.98f, true, Color.get_TransparentWhite(), null)
			};
			this.class531_0[0].string_0 = Class41.GetString(OsuString.EditorModeCompose_ComposeToolSelectTooltip);
			this.class531_0[1].string_0 = Class41.GetString(OsuString.EditorModeCompose_ComposeToolCircleTooltip);
			this.class531_0[2].string_0 = Class41.GetString(OsuString.EditorModeCompose_ComposeToolSliderTooltip);
			this.class531_0[3].string_0 = Class41.GetString(OsuString.EditorModeCompose_ComposeToolSpinnerTooltip);
			this.class531_0[4].string_0 = Class41.GetString(OsuString.EditorModeCompose_ComposeToolHoldTooltip);
			if (this.editor_0.playModes_0 != PlayModes.OsuMania)
			{
				this.class531_0[4].method_8(true);
			}
			else
			{
				this.class531_0[2].method_8(true);
				this.class531_0[3].method_8(true);
			}
			Class531[] array = this.class531_0;
			for (int i = 0; i < array.Length; i++)
			{
				Class531 class2 = array[i];
				class2.bool_1 = true;
				class2.method_2(new EventHandler(this.method_51));
				this.class911_0.Add(class2);
			}
			if (Class371.dictionary_0 == null)
			{
				Class371.dictionary_0 = new Dictionary<Enum106, bool>();
				Class371.dictionary_0.Add(Enum106.flag_2, false);
				Class371.dictionary_0.Add(Enum106.flag_6, false);
				Class371.dictionary_0.Add(Enum106.flag_1, false);
				Class371.dictionary_0.Add(Enum106.flag_0, false);
				Class371.dictionary_0.Add(Enum106.flag_3, true);
				Class371.dictionary_0.Add(Enum106.flag_4, Class341.class606_16);
				Class371.dictionary_0.Add(Enum106.flag_5, false);
			}
			Class115.editorControl_0.method_5(Class331.smethod_17());
			this.class597_0 = new Class597(this.class911_0);
			this.class531_2 = new Class531(Class885.Load("editor-draw-newcombo-expand", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 80f), 2f, true, Color.get_TransparentWhite(), null);
			this.class531_2.bool_1 = true;
			this.class531_2.method_2(new EventHandler(this.method_61));
			this.class597_0.method_4(new EventHandler(this.method_63));
			this.class911_0.Add(this.class531_2);
			this.class531_1 = new Class531[]
			{
				new Class531(Class885.Load("editor-draw-newcombo", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 80f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_0),
				new Class531(Class885.Load("editor-sound-whistle", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 140f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_1),
				new Class531(Class885.Load("editor-sound-finish", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 180f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_2),
				new Class531(Class885.Load("editor-sound-clap", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 220f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_6),
				new Class531(Class885.Load("editor-draw-beatsnap", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 260f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_3),
				new Class531(Class885.Load("editor-draw-distsnap", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 320f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_4),
				new Class531(Class885.Load("editor-draw-lock", Enum112.flag_1), Enum115.const_7, Origins.TopLeft, Enum114.const_0, new Vector2(50f, 380f), 1f, true, Color.get_TransparentWhite(), Enum106.flag_5)
			};
			Class531[] array2 = this.class531_1;
			for (int j = 0; j < array2.Length; j++)
			{
				Class531 class3 = array2[j];
				class3.bool_1 = true;
				class3.method_2(new EventHandler(this.method_8));
				this.class911_0.Add(class3);
			}
			this.class531_1[0].string_0 = Class41.GetString(OsuString.EditorModeCompose_NewComboTooltip);
			this.class531_1[1].string_0 = Class41.GetString(OsuString.EditorModeCompose_WhistleTooltip);
			this.class531_1[2].string_0 = Class41.GetString(OsuString.EditorModeCompose_FinishTooltip);
			this.class531_1[3].string_0 = Class41.GetString(OsuString.EditorModeCompose_ClapTooltip);
			this.class531_1[4].string_0 = Class41.GetString(OsuString.EditorModeCompose_GridSnapTooltip);
			this.class531_1[5].string_0 = Class41.GetString(OsuString.EditorModeCompose_DistanceSnapTooltip);
			this.class531_1[6].string_0 = Class41.GetString(OsuString.EditorModeCompose_NoteLockTooltip);
			this.class533_5 = new Class533(string.Empty, 10f, new Vector2((float)(Class115.smethod_43() - 50), 36f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_5.bool_15 = false;
			this.class533_5.method_58(true);
			this.class533_5.bool_1 = true;
			this.class533_5.method_2(new EventHandler(this.method_2));
			this.class911_0.Add(this.class533_5);
			this.class533_3 = new Class533("Sampleset", 10f, new Vector2(2f, 84f), Vector2.get_Zero(), 0.97f, true, Color.get_White(), false);
			this.class911_0.Add(this.class533_3);
			this.class533_4 = new Class533("Additions", 10f, new Vector2(2f, 109f), Vector2.get_Zero(), 0.97f, true, Color.get_White(), false);
			this.class911_0.Add(this.class533_4);
			this.class753_0 = new Class753(this.class911_0, string.Empty, new Vector2(0f, 94f), 52f, 0.98f, false, false);
			this.class753_0.method_9("Auto", SampleSet.None);
			this.class753_0.method_9("Normal", SampleSet.Normal);
			this.class753_0.method_9("Soft", SampleSet.Soft);
			this.class753_0.method_9("Drum", SampleSet.Drum);
			this.class753_0.method_18(SampleSet.None, true);
			this.class753_0.method_0(new EventHandler(this.method_13));
			this.class753_1 = new Class753(this.class911_0, string.Empty, new Vector2(0f, 119f), 52f, 0.98f, false, false);
			this.class753_1.method_9("Auto", SampleSet.None);
			this.class753_1.method_9("Normal", SampleSet.Normal);
			this.class753_1.method_9("Soft", SampleSet.Soft);
			this.class753_1.method_9("Drum", SampleSet.Drum);
			this.class753_1.method_18(SampleSet.None, true);
			this.class753_1.method_0(new EventHandler(this.method_14));
			Class533 class4 = new Class533("Break", 16f, Vector2.get_Zero(), 1f, true, Color.get_White());
			class4.method_8(true);
			this.class533_6 = class4;
			this.class911_0.Add(this.class533_6);
			base.vmethod_2();
		}

		// Token: 0x06001B98 RID: 7064
		// RVA: 0x0008FDF4 File Offset: 0x0008DFF4
		internal override bool vmethod_20()
		{
			if (!this.vmethod_0())
			{
				return false;
			}
			if (this.list_1.Count > 0 && ((this.editor_0.bool_15 && this.enum42_0 == Class371.Enum42.const_0) || this.editor_0.bool_16))
			{
				Class331.smethod_70(this.list_1[0].StartTime, false, false);
				return true;
			}
			return false;
		}

		// Token: 0x06001B6D RID: 7021
		// RVA: 0x0008AB30 File Offset: 0x00088D30
		protected override void vmethod_21()
		{
			if (this.class297_0.list_3.Count > 0)
			{
				this.method_48(Class371.Enum42.const_0);
			}
			else
			{
				this.method_48(Class371.Enum42.const_1);
			}
			this.method_50(Enum106.flag_0 | Enum106.flag_1 | Enum106.flag_2 | Enum106.flag_3 | Enum106.flag_4 | Enum106.flag_5 | Enum106.flag_6);
			this.method_4(Class341.class608_2);
			this.method_6(Class341.class607_2);
		}

		// Token: 0x06001B6E RID: 7022
		// RVA: 0x00016EAD File Offset: 0x000150AD
		internal override bool vmethod_22()
		{
			if (Class570.bool_0)
			{
				this.method_4(Math.Max(1, this.editor_0.int_6 / 2));
				return true;
			}
			return false;
		}

		// Token: 0x06001B6F RID: 7023
		// RVA: 0x00016ED2 File Offset: 0x000150D2
		internal override bool vmethod_23()
		{
			if (Class570.bool_0)
			{
				this.method_4(Math.Min(16, this.editor_0.int_6 * 2));
				return true;
			}
			return false;
		}

		// Token: 0x06001B70 RID: 7024
		// RVA: 0x0008AB8C File Offset: 0x00088D8C
		internal override bool vmethod_24()
		{
			if (Class570.bool_0)
			{
				Class371.Enum42 enum = (Class371.Enum42)Math.Max(0.1f, (float)(this.enum42_0 - Class371.Enum42.const_1));
				if (enum != this.enum42_0)
				{
					this.method_48(enum);
				}
				return true;
			}
			if (!this.class883_0.method_7() && !Class115.smethod_67(this.vector2_3) && (this.enum42_0 != Class371.Enum42.const_0 || this.editor_0.enum108_0 != Enum108.const_2 || this.bool_5))
			{
				return false;
			}
			this.method_6((double)Class778.smethod_2((float)this.double_0 + (Class570.bool_2 ? 0.01f : 0.1f), 0f, 2f));
			return true;
		}

		// Token: 0x06001B71 RID: 7025
		// RVA: 0x0008AC34 File Offset: 0x00088E34
		internal override bool vmethod_25()
		{
			if (Class570.bool_0)
			{
				Class371.Enum42 enum = (Class371.Enum42)Math.Min(3, (int)(this.enum42_0 + 1));
				if (enum != this.enum42_0)
				{
					this.method_48(enum);
				}
				return true;
			}
			if (!this.class883_0.method_7() && !Class115.smethod_67(this.vector2_3) && (this.enum42_0 != Class371.Enum42.const_0 || this.editor_0.enum108_0 != Enum108.const_2 || this.bool_5))
			{
				return false;
			}
			this.method_6((double)Class778.smethod_2((float)this.double_0 - (Class570.bool_2 ? 0.01f : 0.1f), 0f, 2f));
			return true;
		}

		// Token: 0x06001B68 RID: 7016
		// RVA: 0x0008AA28 File Offset: 0x00088C28
		protected virtual bool vmethod_26(Class371.Enum42 enum42_1)
		{
			switch (enum42_1)
			{
			case Class371.Enum42.const_0:
			case Class371.Enum42.const_1:
			case Class371.Enum42.const_2:
			case Class371.Enum42.const_3:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x06001B6B RID: 7019
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_27()
		{
			return true;
		}

		// Token: 0x06001B8D RID: 7053
		// RVA: 0x0008E64C File Offset: 0x0008C84C
		protected virtual void vmethod_28(float float_0, float float_1, bool bool_21)
		{
			if (Class371.dictionary_0[Enum106.flag_5])
			{
				return;
			}
			if (bool_21 && !this.bool_2)
			{
				this.editor_0.method_16(true);
				this.bool_2 = true;
			}
			List<Class304> arg_50_0 = this.list_1;
			if (Class371.action_0 == null)
			{
				Class371.action_0 = new Action<Class304>(Class371.smethod_8);
			}
			arg_50_0.ForEach(Class371.action_0);
			bool flag = true;
			Class304 class = this.list_1[0];
			if (this.bool_3)
			{
				float_0 = (float)((int)Math.Round((double)(float_0 / (float)this.editor_0.int_2)) * this.editor_0.int_2);
				float_1 = (float)((int)Math.Round((double)(float_1 / (float)this.editor_0.int_2)) * this.editor_0.int_2);
			}
			float num = Math.Min(512f, Math.Max(0f, float_0)) - class.Position.X;
			float num2 = Math.Min(384f, Math.Max(0f, float_1)) - class.Position.Y;
			foreach (Class304 current in this.list_1)
			{
				if (!Class115.smethod_67(new Vector2(current.Position.X + num, current.Position.Y + num2)) || !Class115.smethod_67(new Vector2(current.vmethod_10().X + num, current.vmethod_10().Y + num2)))
				{
					flag = false;
					break;
				}
			}
			if (flag && (num != 0f || num2 != 0f))
			{
				this.bool_8 = true;
				foreach (Class304 current2 in this.list_1)
				{
					current2.vmethod_5(new Vector2((float)((int)(current2.Position.X + num)), (float)((int)(current2.Position.Y + num2))), false);
				}
			}
		}

		// Token: 0x06001B8E RID: 7054
		// RVA: 0x0008E86C File Offset: 0x0008CA6C
		protected virtual string vmethod_29(int int_4, Vector2 vector2_7, bool bool_21)
		{
			Predicate<Class304> predicate = null;
			Predicate<Class304> predicate2 = null;
			Class371.Class381 class = new Class371.Class381();
			class.int_0 = int_4;
			int startTime;
			int endTime;
			Vector2 vector2_8;
			Vector2 vector2_9;
			string arg;
			if (bool_21)
			{
				List<Class304> arg_38_0 = this.class297_0.list_3;
				if (predicate == null)
				{
					predicate = new Predicate<Class304>(class.method_0);
				}
				Class304 class2 = arg_38_0.FindLast(predicate);
				if (class2 == null || class2 is Class325)
				{
					return string.Empty;
				}
				startTime = class.int_0;
				endTime = class2.EndTime;
				vector2_8 = vector2_7;
				vector2_9 = class2.EndPosition;
				arg = "Prev";
			}
			else
			{
				List<Class304> arg_91_0 = this.class297_0.list_3;
				if (predicate2 == null)
				{
					predicate2 = new Predicate<Class304>(class.method_1);
				}
				Class304 class2 = arg_91_0.Find(predicate2);
				if (class2 == null || class2 is Class325)
				{
					return string.Empty;
				}
				startTime = class2.StartTime;
				endTime = class.int_0;
				vector2_8 = class2.Position;
				vector2_9 = vector2_7;
				arg = "Next";
			}
			int num = startTime - endTime;
			if (num > 3000)
			{
				return string.Empty;
			}
			double num2 = 1000.0 * (double)this.vmethod_30(vector2_8, vector2_9) / (this.class297_0.SliderVelocityAt(startTime) * (double)num);
			return string.Format("\n{1}: {0:f2}x", num2, arg);
		}

		// Token: 0x06001B8C RID: 7052
		// RVA: 0x0008CED0 File Offset: 0x0008B0D0
		internal override void vmethod_3()
		{
			if (this.bool_10)
			{
				this.editor_0.bool_7 = false;
			}
			this.editor_0.method_29(false);
			this.method_19();
			this.method_11();
			Vector2 vector2_ = Class802.vector2_0;
			this.vector2_3 = Class115.smethod_58(vector2_);
			int num = (int)this.vector2_3.X;
			int num2 = (int)this.vector2_3.Y;
			float num3 = (float)num;
			float num4 = (float)num2;
			if (this.bool_11)
			{
				switch (this.editor_0.enum108_0)
				{
				case Enum108.const_1:
				case Enum108.const_2:
					Class802.smethod_15();
					break;
				}
				this.method_22();
				this.method_23(vector2_);
				this.bool_5 = (this.class304_1 == null || (!this.class304_1.method_2() && this.int_1 < 0));
				if (this.bool_13 && this.bool_5)
				{
					this.bool_10 = true;
					this.bool_13 = false;
				}
				this.bool_11 = false;
			}
			Class304 class = null;
			if (this.list_1.Count > 0)
			{
				num3 -= (float)((int)this.vector2_2.X);
				num4 -= (float)((int)this.vector2_2.Y);
				if (this.bool_14)
				{
					this.list_1.Sort();
				}
				class = this.list_1[0];
				if (this.class321_1 != null && !this.class321_1.method_2())
				{
					this.class321_1 = null;
				}
			}
			else
			{
				this.class321_1 = null;
			}
			float num5 = this.class297_0.HitObjectRadius * 0.6f;
			this.bool_3 = Class371.dictionary_0[Enum106.flag_3];
			if ((this.editor_0.bool_7 || this.class304_0 != null) && this.class321_2 == null && this.int_1 <= 0 && !this.editor_0.bool_16)
			{
				Class371.Class378 class2 = new Class371.Class378();
				int num6 = Class331.int_7;
				if (this.list_1.Count > 0)
				{
					num6 = class.StartTime;
				}
				int num7 = this.class297_0.list_3.BinarySearch(new Class330(this.class297_0, num6 - 1));
				if (num7 < 0)
				{
					num7 = ~num7 - 1;
				}
				class2.class304_0 = ((num7 < 0 || this.class297_0.list_3[num7] is Class328) ? null : this.class297_0.list_3[num7]);
				if (class2.class304_0 != null)
				{
					Vector2 vector = class2.class304_0.method_0();
					int endTime = class2.class304_0.EndTime;
					Vector2 vector2 = Vector2.Normalize(new Vector2(num3, num4) - vector);
					if (Class371.dictionary_0[Enum106.flag_4])
					{
						Vector2 vector3 = vector + vector2 * (float)(this.class297_0.SliderVelocityAt(num6) * this.double_0 * (double)(num6 - endTime) / 1000.0);
						if (Class115.smethod_67(vector3))
						{
							num3 = vector3.X;
							num4 = vector3.Y;
							if (this.class531_1[5].color_0 == Color.get_Red())
							{
								this.class531_1[5].method_39(Color.get_White(), 100, false, Enum70.const_0);
							}
							if (this.editor_0.bool_7 && this.list_1.Count > 0)
							{
								this.class304_1 = class;
							}
						}
						else if (!this.bool_5 && this.editor_0.enum108_0 == Enum108.const_2)
						{
							this.class531_1[5].method_39(Color.get_Red(), 100, false, Enum70.const_0);
						}
						if (!Class371.dictionary_0[Enum106.flag_3] && ((Class570.bool_2 && !Class570.bool_0) || (!Class570.bool_2 && Class570.bool_0)) && Class115.smethod_67(this.vector2_3))
						{
							double num8 = Math.Atan2((double)(vector3.X - vector.X), (double)(vector3.Y - vector.Y)) * 180.0 / 3.1415926535897931;
							Math.Abs(num8);
							int num9 = (int)(Math.Round(num8 / 45.0) * 45.0);
							double num10 = Math.Abs(num8 - (double)num9);
							if (num10 < 10.0)
							{
								num9 = -num9 + 90;
								float num11 = Vector2.Distance(new Vector2(num3, num4), vector);
								Vector2 vector4;
								vector4..ctor((float)Math.Cos((double)num9 * 3.1415926535897931 / 180.0), (float)Math.Sin((double)num9 * 3.1415926535897931 / 180.0));
								num3 = vector.X + vector4.X * num11;
								num4 = vector.Y + vector4.Y * num11;
								this.class880_0 = new Class880(Class115.smethod_61(vector), Class115.smethod_61(vector + vector4 * num11 * 2f));
								this.bool_3 = false;
							}
						}
						if (Vector2.Distance(this.vector2_3, vector) < num5)
						{
							num3 = vector.X;
							num4 = vector.Y;
							this.bool_3 = false;
						}
					}
					else
					{
						num5 = this.class297_0.HitObjectRadius * 0.15f;
						if (this.list_1.Count > 0)
						{
							if (!this.bool_17)
							{
								float num12 = Vector2.Distance(class.vector2_0, vector);
								if ((!this.bool_18 || Vector2.Distance(this.vector2_3, vector) < num5) && num12 < num5)
								{
									num3 = vector.X;
									num4 = vector.Y;
									this.vector2_6 = new Vector2((float)num, (float)num2);
									this.bool_17 = true;
									this.bool_3 = false;
								}
							}
							else
							{
								float num13 = Vector2.Distance(this.vector2_3, this.vector2_6);
								float num14 = 8f;
								if (num13 > num14)
								{
									this.bool_17 = false;
								}
								else
								{
									num3 = vector.X;
									num4 = vector.Y;
									this.bool_3 = false;
								}
							}
						}
						else
						{
							this.bool_18 = false;
							this.bool_17 = false;
						}
					}
				}
				else
				{
					this.bool_18 = false;
					this.bool_17 = false;
				}
				if (!this.editor_0.bool_7 || this.bool_5 || this.list_1.Count <= 0 || this.bool_17)
				{
					goto IL_936;
				}
				float num15 = this.class297_0.HitObjectRadius * 0.15f;
				using (List<Class304>.Enumerator enumerator = this.list_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class371.Class379 class3 = new Class371.Class379();
						class3.class378_0 = class2;
						class3.class371_0 = this;
						class3.class304_0 = enumerator.Current;
						Predicate<Class304> predicate = new Predicate<Class304>(class3.method_0);
						Predicate<Class304> predicate2 = predicate;
						Vector2 vector5 = class3.class304_0.vector2_0 - class.vector2_0;
						int num16 = (int)(num3 + vector5.X);
						int num17 = (int)(num4 + vector5.Y);
						Class304 class4 = this.class297_0.method_16(num16, num17, num15, true, predicate2);
						if (class4 != null)
						{
							if (Vector2.Distance(class3.class304_0.vector2_0, class4.vector2_0) >= num15)
							{
								if (Vector2.Distance(class3.class304_0.vector2_0, class4.method_1()) >= num15)
								{
									continue;
								}
								num3 = class4.method_1().X - vector5.X;
								num4 = class4.method_1().Y - vector5.Y;
								this.bool_3 = false;
							}
							else
							{
								num3 = class4.vector2_0.X - vector5.X;
								num4 = class4.vector2_0.Y - vector5.Y;
								this.bool_3 = false;
							}
						}
						else
						{
							if (!(class3.class304_0.Position != class3.class304_0.vmethod_10()))
							{
								continue;
							}
							Vector2 vector6 = class3.class304_0.vmethod_10() - class3.class304_0.Position;
							num16 += (int)vector6.X;
							num17 += (int)vector6.Y;
							class4 = this.class297_0.method_16(num16, num17, num15, true, predicate2);
							if (class4 == null)
							{
								continue;
							}
							if (Vector2.Distance(class3.class304_0.method_1(), class4.vector2_0) >= num15)
							{
								if (Vector2.Distance(class3.class304_0.method_1(), class4.method_1()) >= num15)
								{
									continue;
								}
								num3 = class4.method_1().X - vector5.X - vector6.X;
								num4 = class4.method_1().Y - vector5.Y - vector6.Y;
								this.bool_3 = false;
							}
							else
							{
								num3 = class4.vector2_0.X - vector5.X - vector6.X;
								num4 = class4.vector2_0.Y - vector5.Y - vector6.Y;
								this.bool_3 = false;
							}
						}
						IL_8F6:
						goto IL_936;
					}
					goto IL_8F6;
				}
			}
			if (this.class531_1[5].color_0 == Color.get_Red())
			{
				this.class531_1[5].method_39(Color.get_White(), 100, false, Enum70.const_0);
			}
			IL_936:
			if (this.bool_3)
			{
				num3 = (float)((int)Math.Round((double)(num3 / (float)this.editor_0.int_2)) * this.editor_0.int_2);
				num4 = (float)((int)Math.Round((double)(num4 / (float)this.editor_0.int_2)) * this.editor_0.int_2);
			}
			this.method_20();
			if (this.editor_0.bool_7)
			{
				switch (this.editor_0.enum108_0)
				{
				case Enum108.const_1:
					this.int_3 = this.editor_0.method_71(Class802.point_0.X);
					if (Class331.enum100_0 != Enum100.const_1)
					{
						int num18 = 0;
						if (this.int_3 < this.editor_0.int_8)
						{
							num18 = (this.int_3 - this.editor_0.int_8) / 2;
						}
						else if (this.int_3 > this.editor_0.int_9)
						{
							num18 = (this.int_3 - this.editor_0.int_9) / 2;
						}
						if (num18 != 0)
						{
							Class331.smethod_70(Class331.int_7 + num18, false, false);
						}
					}
					if (this.bool_7)
					{
						if (this.class304_1 != null)
						{
							if (this.class304_1.IsType(HitObjectType.Slider))
							{
								Class321 class5 = (Class321)this.class304_1;
								int endTime2 = class5.EndTime;
								class5.method_15(this.int_3);
								if (class5.EndTime != endTime2)
								{
									this.bool_8 = true;
									this.class304_1 = class5;
									this.class297_0.method_20(true);
								}
							}
							else if (this.class304_1.IsType(HitObjectType.Spinner))
							{
								int num19 = this.editor_0.class375_0.method_5((double)this.int_3);
								if (num19 > this.class304_1.StartTime)
								{
									this.bool_8 = true;
									this.class304_1.vmethod_19(num19);
								}
							}
							this.class304_1.vmethod_6();
						}
						else if (this.class705_0 != null)
						{
							this.vmethod_17();
							Class705 class6 = this.class705_0;
							if (this.bool_9)
							{
								int num20 = this.editor_0.class375_0.method_5((double)this.int_3);
								if (num20 != class6.int_0)
								{
									class6.vmethod_1(num20);
									this.bool_8 = true;
									this.editor_0.method_30(false, true);
								}
							}
							else
							{
								int num21 = this.editor_0.class375_0.method_5((double)this.int_3);
								if (num21 != class6.int_2)
								{
									class6.vmethod_0(num21);
									this.bool_8 = true;
									this.editor_0.method_30(false, true);
								}
							}
						}
					}
					else
					{
						if (this.bool_5)
						{
							int num22 = Math.Min(Math.Max(this.editor_0.int_8, this.int_3), this.editor_0.int_9);
							using (List<Class304>.Enumerator enumerator = this.class297_0.list_3.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									Class304 current = enumerator.Current;
									if ((current.StartTime >= this.int_2 && current.StartTime <= num22) || (current.StartTime <= this.int_2 && current.StartTime >= num22) || (current.EndTime >= this.int_2 && current.EndTime <= num22) || (current.EndTime <= this.int_2 && current.EndTime >= num22))
									{
										this.Select(current);
									}
									else
									{
										this.method_56(current);
									}
								}
								break;
							}
						}
						if (this.list_1.Count > 0 && this.class304_1 != null)
						{
							Action<Class304> action = null;
							Class371.Class380 class7 = new Class371.Class380();
							int num23 = this.editor_0.method_71(Class802.point_0.X);
							if (!Class570.bool_2)
							{
								num23 = this.editor_0.class375_0.method_5((double)(num23 - this.int_0));
							}
							else
							{
								num23 -= this.int_0;
							}
							class7.int_0 = num23 - this.class304_1.StartTime;
							bool flag = true;
							int i = 0;
							while (i < this.list_1.Count)
							{
								Class304 class8 = this.list_1[i];
								if (class8.StartTime + class7.int_0 >= 0 && class8.StartTime + class7.int_0 < Class331.smethod_31())
								{
									i++;
								}
								else
								{
									flag = false;
									IL_D90:
									if (flag && !Class371.dictionary_0[Enum106.flag_5] && class7.int_0 != 0)
									{
										this.bool_8 = true;
										List<Class304> arg_DD6_0 = this.list_1;
										if (action == null)
										{
											action = new Action<Class304>(class7.method_0);
										}
										arg_DD6_0.ForEach(action);
										this.class297_0.method_20(true);
										goto IL_15B6;
									}
									goto IL_15B6;
								}
							}
							goto IL_D90;
						}
					}
					break;
				case Enum108.const_2:
					if (this.bool_5)
					{
						this.vector2_1 = vector2_;
						Rectangle rectangle;
						rectangle..ctor((int)Math.Min(this.vector2_0.X, this.vector2_1.X), (int)Math.Min(this.vector2_0.Y, this.vector2_1.Y), (int)Math.Abs(this.vector2_1.X - this.vector2_0.X), (int)Math.Abs(this.vector2_1.Y - this.vector2_0.Y));
						List<Class304> arg_E9F_0 = this.class297_0.list_3;
						if (Class371.predicate_5 == null)
						{
							Class371.predicate_5 = new Predicate<Class304>(Class371.smethod_7);
						}
						foreach (Class304 current2 in arg_E9F_0.FindAll(Class371.predicate_5))
						{
							if (rectangle.Contains((int)Class115.smethod_59((float)((int)current2.Position.X)), (int)Class115.smethod_60((float)((int)current2.Position.Y))))
							{
								this.Select(current2);
							}
							else
							{
								this.method_56(current2);
							}
						}
						if (this.list_1.Count == 0)
						{
							this.method_49();
						}
					}
					else if (this.class321_0 != null && this.class321_0 != this.class321_2 && this.int_1 >= 0)
					{
						Vector2 vector7;
						vector7..ctor(num3, num4);
						Vector2 vector8 = this.class321_0.list_3[this.int_1];
						if (vector7 != vector8)
						{
							this.bool_8 = true;
							this.class321_0.method_29(vector7, this.int_1);
						}
					}
					else if (this.list_1.Count > 0 && this.class304_1 != null)
					{
						this.vmethod_28(num3, num4, false);
					}
					break;
				}
			}
			else
			{
				this.int_1 = -1;
				if (this.class321_0 != null)
				{
					if (this.enum42_0 == Class371.Enum42.const_0)
					{
						for (int j = 0; j < this.class321_0.list_3.Count; j++)
						{
							if (Vector2.Distance(this.vector2_3, this.class321_0.list_3[j]) < 4f)
							{
								this.int_1 = j;
								break;
							}
						}
					}
					if (this.int_1 >= 0)
					{
						this.editor_0.bool_15 = true;
					}
					else if (this.editor_0.bool_15 && this.editor_0.enum107_0 == Enum107.const_1)
					{
						this.class321_0 = null;
					}
				}
				this.method_23(new Vector2(num3, num4));
				num3 = (float)((int)num3);
				num4 = (float)((int)num4);
				switch (this.enum42_0)
				{
				case Class371.Enum42.const_1:
				case Class371.Enum42.const_2:
				case Class371.Enum42.const_4:
					if (this.enum42_0 == Class371.Enum42.const_2 && this.class321_2 != null)
					{
						this.class321_2.method_14(Class331.int_7);
						this.vector2_4 = new Vector2(num3, num4);
						this.class321_2.method_17(this.vector2_4);
					}
					else
					{
						if (this.class304_1 != null)
						{
							if (Vector2.Distance(this.vector2_3, this.class304_1.vector2_0) < num5)
							{
								num3 = this.class304_1.vector2_0.X;
								num4 = this.class304_1.vector2_0.Y;
							}
							else if (Vector2.Distance(this.vector2_3, this.class304_1.method_1()) < num5)
							{
								num3 = this.class304_1.method_1().X;
								num4 = this.class304_1.method_1().Y;
							}
						}
						Vector2 vector9;
						vector9..ctor(num3, num4);
						if (Class115.smethod_67(vector9))
						{
							this.class304_0 = new Class306(this.class297_0, vector9, Class331.int_7, Class371.dictionary_0[Enum106.flag_0] || this.method_46());
							this.class304_0.bool_0 = true;
							this.class304_0.bool_3 = true;
							if (this.editor_0.playModes_0 == PlayModes.Taiko)
							{
								Color color;
								color..ctor(235, 69, 44);
								Color color2;
								color2..ctor(67, 142, 172);
								Color color3;
								color3..ctor(252, 184, 6);
								if (this.enum42_0 == Class371.Enum42.const_1)
								{
									if (!Class371.dictionary_0[Enum106.flag_1] && !Class371.dictionary_0[Enum106.flag_6])
									{
										this.class304_0.list_1[0].class26_0[1].color_0 = color;
										this.class304_0.list_1[0].class26_0[1].color_1 = color;
										this.class304_0.list_1[0].color_0 = color;
										this.class304_0.list_1[1].color_0 = color;
									}
									else
									{
										this.class304_0.list_1[0].class26_0[1].color_0 = color2;
										this.class304_0.list_1[0].class26_0[1].color_1 = color2;
										this.class304_0.list_1[0].color_0 = color2;
										this.class304_0.list_1[1].color_0 = color2;
									}
								}
								else if (this.enum42_0 == Class371.Enum42.const_2)
								{
									this.class304_0.list_1[0].class26_0[1].color_0 = color3;
									this.class304_0.list_1[0].class26_0[1].color_1 = color3;
									this.class304_0.list_1[0].color_0 = color3;
									this.class304_0.list_1[1].color_0 = color3;
								}
							}
							this.class297_0.Add(this.class304_0, false);
							this.class297_0.method_20(false);
						}
					}
					break;
				case Class371.Enum42.const_3:
					if (this.class328_0 != null)
					{
						int num24 = (int)((double)this.editor_0.method_85() + Class331.smethod_8());
						if (this.class328_0.EndTime != num24 && num24 > this.class328_0.StartTime)
						{
							this.class328_0.vmethod_19(Math.Max(this.class328_0.StartTime + 1, num24));
						}
					}
					else
					{
						this.class304_0 = new Class328(this.class297_0, Class331.int_7, Class331.int_7, this.method_0());
						foreach (Class531 current3 in this.class304_0.list_1)
						{
							current3.float_2 = 0.4f;
							if (current3.origins_0 == Origins.TopLeft)
							{
								current3.class26_0.Clear();
							}
						}
						this.class304_0.bool_0 = true;
						this.class304_0.bool_3 = true;
						this.class297_0.Add(this.class304_0, false);
					}
					break;
				}
				this.bool_7 = false;
				if (this.editor_0.bool_16)
				{
					if (this.class304_1 != null)
					{
						if (this.list_1.Count <= 1 && (this.class304_1.IsType(HitObjectType.Slider) || this.class304_1.IsType(HitObjectType.Spinner)))
						{
							this.bool_7 = (Math.Abs((float)Class802.point_0.X - this.editor_0.method_70((double)this.class304_1.EndTime)) < 6f);
						}
					}
					else
					{
						bool flag2;
						this.bool_7 = (this.method_1(ref flag2) != null);
					}
				}
				if (this.bool_7)
				{
					Class800.smethod_25(Cursors.SizeWE);
				}
				else if (this.enum42_0 != Class371.Enum42.const_0 && Class115.smethod_67(this.vector2_3))
				{
					Class800.smethod_25(Cursors.Cross);
					if (this.list_1.Count > 0)
					{
						this.vmethod_17();
					}
				}
				else
				{
					Class800.smethod_24();
				}
			}
			IL_15B6:
			if (this.list_1.Count == 1 && this.list_1[0].IsType(HitObjectType.Slider))
			{
				this.class321_1 = (Class321)this.list_1[0];
				this.class321_0 = this.class321_1;
			}
			else if (this.class321_2 != null)
			{
				this.class321_1 = this.class321_2;
				this.class321_0 = this.class321_2;
			}
			else if (this.class304_1 != null && this.class304_1.IsType(HitObjectType.Slider))
			{
				this.class321_0 = (Class321)this.class304_1;
			}
			else
			{
				this.class321_1 = null;
				this.class321_0 = this.class321_1;
			}
			if (this.bool_14)
			{
				this.list_1.Sort();
				this.method_65();
				this.method_66();
				this.method_67();
			}
			if (this.editor_0.bool_15)
			{
				this.editor_0.enum107_0 = Enum107.const_2;
			}
			else if (this.editor_0.bool_16)
			{
				this.editor_0.enum107_0 = Enum107.const_1;
			}
			else if (this.editor_0.bool_17)
			{
				this.editor_0.enum107_0 = Enum107.const_3;
			}
			else
			{
				this.editor_0.enum107_0 = Enum107.const_0;
			}
			this.class297_0.method_26();
			this.vector2_5 = new Vector2(num3, num4);
			if (Class115.bool_13)
			{
				this.vmethod_31();
			}
			this.bool_14 = false;
		}

		// Token: 0x06001B8F RID: 7055
		// RVA: 0x00016F67 File Offset: 0x00015167
		protected virtual float vmethod_30(Vector2 vector2_7, Vector2 vector2_8)
		{
			return Vector2.Distance(vector2_7, vector2_8);
		}

		// Token: 0x06001B90 RID: 7056
		// RVA: 0x0008E990 File Offset: 0x0008CB90
		protected virtual void vmethod_31()
		{
			string text = string.Empty;
			if (this.class321_0 != null && this.int_1 >= 0)
			{
				if (this.int_1 < this.class321_0.list_3.Count)
				{
					Vector2 vector = this.class321_0.list_3[this.int_1];
					this.class533_5.color_0 = Color.get_LightSalmon();
					this.class533_5.Text = string.Format("x:{0:0} y:{1:0}", vector.X, vector.Y);
				}
				text += this.vmethod_29(this.class321_0.StartTime, this.class321_0.Position, true);
				text += this.vmethod_29(this.class321_0.EndTime, this.class321_0.EndPosition, false);
				Class533 expr_D7 = this.class533_5;
				expr_D7.Text += text;
				return;
			}
			if (this.list_1.Count > 0)
			{
				Class371.Class382 class = new Class371.Class382();
				this.class533_5.color_0 = Color.get_Yellow();
				class.class304_0 = this.list_1[0];
				class.class304_1 = this.list_1[this.list_1.Count - 1];
				int num = this.class297_0.list_3.FindIndex(new Predicate<Class304>(class.method_0));
				int num2 = this.class297_0.list_3.FindIndex(new Predicate<Class304>(class.method_1));
				if (!(class.class304_0 is Class325))
				{
					if (num > 0)
					{
						text += this.vmethod_29(class.class304_0.StartTime, class.class304_0.Position, true);
					}
					if (num2 < this.class297_0.int_14 - 1 && num2 >= 0)
					{
						text += this.vmethod_29(class.class304_1.EndTime, class.class304_1.EndPosition, false);
					}
				}
				this.class533_5.Text = string.Format("x:{0:0} y:{1:0}", class.class304_0.Position.X, class.class304_0.Position.Y) + text;
				return;
			}
			if (this.enum42_0 == Class371.Enum42.const_1 || (this.enum42_0 == Class371.Enum42.const_2 && this.class321_2 == null))
			{
				Vector2 vector2_ = this.vector2_5;
				text += this.vmethod_29(Class331.int_7, vector2_, true);
				text += this.vmethod_29(Class331.int_7, vector2_, false);
				this.class533_5.Text = string.Format("x:{0:0} y:{1:0}", vector2_.X, vector2_.Y) + text;
				return;
			}
			if (this.enum42_0 == Class371.Enum42.const_2 && this.class321_2 != null)
			{
				return;
			}
			this.class533_5.color_0 = Color.get_White();
			this.class533_5.Text = string.Format("x:{0:0} y:{1:0}", this.vector2_5.X, this.vector2_5.Y);
		}

		// Token: 0x06001BA1 RID: 7073
		// RVA: 0x00016FE4 File Offset: 0x000151E4
		internal virtual void vmethod_32()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			if (this.editor_0.bool_7)
			{
				this.method_21(false);
				this.bool_10 = this.bool_11;
			}
			this.vmethod_18();
			this.vmethod_35();
		}

		// Token: 0x06001BA6 RID: 7078
		// RVA: 0x00090DC8 File Offset: 0x0008EFC8
		internal virtual void vmethod_33()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			List<Class304> arg_3D_0 = this.list_1;
			if (Class371.action_2 == null)
			{
				Class371.action_2 = new Action<Class304>(Class371.smethod_11);
			}
			arg_3D_0.ForEach(Class371.action_2);
			this.method_21(false);
			this.bool_13 = this.bool_11;
			foreach (Class304 current in this.list_1)
			{
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = new Vector2((float)Class115.int_18 - class.list_3[i].X, class.list_3[i].Y);
					}
					class.class306_0.vmethod_5(new Vector2((float)Class115.int_18 - current.Position.X, current.Position.Y), false);
					class.Position = (class.vector2_0 = new Vector2((float)Class115.int_18 - current.Position.X, current.Position.Y));
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(new Vector2((float)Class115.int_18 - current.Position.X, current.Position.Y), false);
				}
			}
		}

		// Token: 0x06001BA7 RID: 7079
		// RVA: 0x00090F74 File Offset: 0x0008F174
		internal virtual void vmethod_34()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			List<Class304> arg_3D_0 = this.list_1;
			if (Class371.action_3 == null)
			{
				Class371.action_3 = new Action<Class304>(Class371.smethod_12);
			}
			arg_3D_0.ForEach(Class371.action_3);
			this.method_21(false);
			this.bool_13 = this.bool_11;
			foreach (Class304 current in this.list_1)
			{
				if (current.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)current;
					for (int i = 0; i < class.list_3.Count; i++)
					{
						class.list_3[i] = new Vector2(class.list_3[i].X, (float)Class115.int_17 - class.list_3[i].Y);
					}
					class.class306_0.vmethod_5(new Vector2(current.Position.X, (float)Class115.int_17 - current.Position.Y), false);
					class.Position = (class.vector2_0 = new Vector2(current.Position.X, (float)Class115.int_17 - current.Position.Y));
					class.vmethod_24(true);
				}
				else
				{
					current.vmethod_5(new Vector2(current.Position.X, (float)Class115.int_17 - current.Position.Y), false);
				}
			}
		}

		// Token: 0x06001BB9 RID: 7097
		// RVA: 0x00092938 File Offset: 0x00090B38
		internal virtual void vmethod_35()
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.class297_0.Remove(this.list_1.ToArray());
			this.list_1.Clear();
			this.class297_0.method_20(true);
		}

		// Token: 0x06001BD8 RID: 7128
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_36()
		{
		}

		// Token: 0x06001B93 RID: 7059
		// RVA: 0x0008ED20 File Offset: 0x0008CF20
		internal override void vmethod_4()
		{
			this.list_2.Clear();
			this.class533_6.vmethod_11();
			foreach (Class705 current in this.editor_0.class872_0.list_0)
			{
				if (current.int_2 >= this.editor_0.int_8 && current.int_2 <= this.editor_0.int_9)
				{
					float num = this.editor_0.method_69((double)current.int_2);
					Class533 class = (Class533)this.class533_6.Clone();
					class.vector2_1 = new Vector2(num + 5f, 35f);
					class.float_3 = 1f;
					this.editor_0.class911_3.Add(class);
				}
			}
			int num2 = -60000;
			int num3 = 0;
			foreach (Class304 current2 in this.class297_0.list_4)
			{
				if (current2 != this.class304_0)
				{
					Class321 class2 = current2 as Class321;
					bool flag = current2.StartTime >= this.editor_0.int_8 && current2.StartTime <= this.editor_0.int_9;
					bool flag2 = current2.EndTime != current2.StartTime && current2.EndTime >= this.editor_0.int_8 && current2.EndTime <= this.editor_0.int_9;
					if ((current2.Length > 0 && (flag || flag2)) || (current2.StartTime < this.editor_0.int_8 && current2.EndTime > this.editor_0.int_9))
					{
						this.list_2.Add(current2);
					}
					if (current2.StartTime == num2)
					{
						num3++;
					}
					else
					{
						num3 = 0;
					}
					num2 = current2.StartTime;
					int num4 = 45 - 2 * num3;
					int num5 = 3 * num3;
					int num6 = 0;
					num4 += 0;
					if (flag)
					{
						float num7 = this.editor_0.method_69((double)current2.StartTime);
						byte b = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num7 - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num7 - (float)this.editor_0.int_4)) / 40.0);
						Color color;
						color..ctor(255, 255, 255, b);
						Color color2;
						color2..ctor(current2.Colour.get_R(), current2.Colour.get_G(), current2.Colour.get_B(), b);
						Color color3;
						color3..ctor(255, 0, 0, b);
						Class531 class3 = new Class531(Class885.Load("hitcircle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num7, (float)num4), Class911.smethod_4((float)(current2.StartTime + num5)), true, color2, current2);
						class3.float_2 = 0.4f;
						Class531 class4 = new Class531(Class885.Load("hitcircleoverlay", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num7, (float)num4), Class911.smethod_4((float)(current2.StartTime - 1 + num5)), true, color, null);
						class4.float_2 = 0.4f;
						Class531 class5 = new Class536(current2.ComboNumber.ToString(), Class885.class547_0.string_3, Class885.class547_0.int_3, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num7, (float)(45 - 3 * num3 + num6)), Class911.smethod_4((float)(current2.StartTime - 2 + num5)), true, color, false);
						class5.float_2 = 0.32f;
						if (current2.method_2())
						{
							Class531 class6 = new Class531(Class885.Load("hitcircleselect", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num7, (float)num4), Class911.smethod_4((float)(current2.StartTime - 3 + num5)), true, (class2 == null || !class2.class306_0.method_2()) ? color : color3, null);
							class6.float_2 = 0.4f;
							this.editor_0.class911_3.Add(class6);
						}
						this.editor_0.class911_3.Add(class3);
						this.editor_0.class911_3.Add(class4);
						this.editor_0.class911_3.Add(class5);
					}
					if (flag2)
					{
						float num8 = this.editor_0.method_69((double)current2.EndTime);
						byte b2 = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num8 - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num8 - (float)this.editor_0.int_4)) / 40.0);
						Color color4;
						color4..ctor(255, 255, 255, b2);
						Color color5;
						color5..ctor(current2.Colour.get_R(), current2.Colour.get_G(), current2.Colour.get_B(), b2);
						Color color6;
						color6..ctor(255, 0, 0, b2);
						Class531 class7 = new Class531(Class885.Load("hitcircle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num8, (float)num4), Class911.smethod_4((float)(current2.EndTime + num5)), true, color5, current2);
						class7.float_2 = 0.4f;
						Class531 class8 = new Class531(Class885.Load("hitcircleoverlay", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num8, (float)num4), Class911.smethod_4((float)(current2.EndTime - 1 + num5)), true, color4, null);
						class8.float_2 = 0.4f;
						if (current2.method_2())
						{
							Class531 class9 = new Class531(Class885.Load("hitcircleselect", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num8, (float)num4), Class911.smethod_4((float)(current2.EndTime - 3 + num5)), true, (class2 == null || class2.list_2.Count <= 0 || !class2.list_2[class2.list_2.Count - 1].method_2()) ? color4 : color6, null);
							class9.float_2 = 0.4f;
							this.editor_0.class911_3.Add(class9);
						}
						this.editor_0.class911_3.Add(class7);
						this.editor_0.class911_3.Add(class8);
					}
					if (class2 != null && (flag || flag2 || (current2.StartTime < this.editor_0.int_8 && current2.EndTime >= this.editor_0.int_9)))
					{
						for (int i = 0; i < class2.list_6.Count; i++)
						{
							int num9 = class2.list_6[i];
							if (num9 >= this.editor_0.int_8 && num9 <= this.editor_0.int_9)
							{
								float num10 = this.editor_0.method_69((double)num9);
								byte b3 = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num10 - (float)this.editor_0.int_4, (float)this.editor_0.int_11 - (num10 - (float)this.editor_0.int_4)) / 40.0);
								Color color7;
								color7..ctor(255, 255, 255, b3);
								Color color8;
								color8..ctor(current2.Colour.get_R(), current2.Colour.get_G(), current2.Colour.get_B(), b3);
								Color color9;
								color9..ctor(0, 0, 0, b3);
								Color color10;
								color10..ctor(255, 0, 0, b3);
								Class531 class10 = new Class531(Class885.Load("hitcircle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num10, (float)num4), Class911.smethod_4((float)(num9 + num5)), true, color8, current2);
								class10.float_2 = 0.4f;
								Class531 class11 = new Class531(Class885.Load("hitcircleoverlay", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num10, (float)num4), Class911.smethod_4((float)(num9 - 1 + num5)), true, color7, null);
								class11.float_2 = 0.4f;
								Color color11;
								if (class10.vmethod_6().enum112_0 == Enum112.flag_1 && (int)(current2.Colour.get_R() + current2.Colour.get_G() + current2.Colour.get_B()) > 600)
								{
									color11 = color9;
								}
								else
								{
									color11 = color7;
								}
								Class531 class12 = new Class531(Class885.Load("reversearrow", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num10, (float)num4), Class911.smethod_4((float)(num9 - 2 + num5)), true, color11, null);
								class12.float_2 = 0.4f;
								this.editor_0.class911_3.Add(class12);
								if (i < class2.list_2.Count && class2.list_2[i].method_2())
								{
									Class531 class13 = new Class531(Class885.Load("hitcircleselect", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(num10, (float)num4), Class911.smethod_4((float)(num9 - 3 + num5)), true, color10, null);
									class13.float_2 = 0.4f;
									this.editor_0.class911_3.Add(class13);
								}
								this.editor_0.class911_3.Add(class10);
								this.editor_0.class911_3.Add(class11);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001B9A RID: 7066
		// RVA: 0x000900E0 File Offset: 0x0008E2E0
		internal override void vmethod_5()
		{
			if (this.bool_5)
			{
				if (this.editor_0.enum108_0 == Enum108.const_2)
				{
					if (this.vector2_0 != this.vector2_1)
					{
						Color color;
						color..ctor(255, 255, 255, 180);
						Vector2 vector;
						vector..ctor(this.vector2_1.X, this.vector2_0.Y);
						Vector2 vector2;
						vector2..ctor(this.vector2_0.X, this.vector2_1.Y);
						Class115.class882_0.method_0();
						Class115.class882_0.method_1(this.vector2_0, color);
						Class115.class882_0.method_1(vector, color);
						Class115.class882_0.method_1(vector, color);
						Class115.class882_0.method_1(this.vector2_1, color);
						Class115.class882_0.method_1(this.vector2_1, color);
						Class115.class882_0.method_1(vector2, color);
						Class115.class882_0.method_1(vector2, color);
						Class115.class882_0.method_1(this.vector2_0, color);
						Class115.class882_0.method_2();
						Class115.class582_0.method_2(this.vector2_0, this.vector2_1, this.color_4);
					}
				}
				else if (this.editor_0.enum108_0 == Enum108.const_1 && this.int_2 != this.int_3)
				{
					float num = Math.Max((float)this.editor_0.rectangle_2.get_Left(), this.editor_0.method_70((double)Math.Min(this.int_2, this.int_3)));
					float num2 = Math.Min((float)this.editor_0.rectangle_2.get_Right(), this.editor_0.method_70((double)Math.Max(this.int_2, this.int_3)));
					if (num != num2)
					{
						Class115.class582_0.method_2(new Vector2(num, (float)this.editor_0.rectangle_2.get_Top()), new Vector2(num2, (float)this.editor_0.rectangle_2.get_Bottom()), this.color_5);
					}
				}
			}
			base.vmethod_5();
		}

		// Token: 0x06001BB6 RID: 7094
		// RVA: 0x00091EC8 File Offset: 0x000900C8
		internal override bool vmethod_6()
		{
			if (!this.vmethod_0())
			{
				return false;
			}
			if (this.vmethod_14())
			{
				this.class883_0.ReadOnly = true;
			}
			bool flag = Class802.buttonState_0 == 1;
			bool flag2 = Class802.buttonState_5 == 1;
			this.bool_12 = true;
			if (flag)
			{
				Class304 class = null;
				if (Class371.dictionary_0[Enum106.flag_5] && Class570.bool_0 && Class570.bool_2 && this.class304_1 != null)
				{
					this.method_47(this.class304_1);
					return false;
				}
				this.bool_15 = (!this.bool_7 || this.class304_1 != this.class328_0);
				if (this.editor_0.bool_16 && this.class321_2 == null)
				{
					this.method_48(Class371.Enum42.const_0);
				}
				this.bool_15 = true;
				if (this.enum42_0 != Class371.Enum42.const_0)
				{
					this.method_52();
					int num = this.editor_0.method_85();
					switch (this.enum42_0)
					{
					case Class371.Enum42.const_1:
						if (Class115.smethod_67(this.vector2_5) && Class115.smethod_67(this.vector2_3))
						{
							this.editor_0.method_16(false);
							Class306 class2 = new Class306(this.class297_0, this.vector2_5, num, Class371.dictionary_0[Enum106.flag_0] || this.method_46(), Class371.dictionary_0[Enum106.flag_1], Class371.dictionary_0[Enum106.flag_2], Class371.dictionary_0[Enum106.flag_6], 0);
							class = class2;
						}
						break;
					case Class371.Enum42.const_2:
						this.bool_10 = true;
						if (this.class321_2 == null)
						{
							if (Class115.smethod_67(this.vector2_5) && Class115.smethod_67(this.vector2_3))
							{
								this.editor_0.method_16(false);
								this.class321_2 = new Class321(this.class297_0, this.vector2_5, num, Class371.dictionary_0[Enum106.flag_0] || this.method_46(), this.method_0(), this.curveTypes_0, 0, 0.0, null, null, 0)
								{
									bool_6 = true
								};
								class = this.class321_2;
							}
						}
						else
						{
							this.editor_0.method_16(false);
							this.class321_2.method_16(false, false);
						}
						break;
					case Class371.Enum42.const_3:
						if (this.class328_0 == null && !this.editor_0.bool_16)
						{
							this.editor_0.method_16(false);
							this.class328_0 = new Class328(this.class297_0, num, (int)((double)num + Class331.smethod_8()), this.method_0());
							this.class328_0.NewCombo = true;
							class = this.class328_0;
						}
						break;
					}
					if (class != null)
					{
						this.class297_0.Add(class, true);
						if (class == this.class328_0)
						{
							if (class != this.class297_0.list_3[this.class297_0.int_14 - 1])
							{
								int index = this.class297_0.list_3.IndexOf(class) + 1;
								this.class297_0.list_3[index].NewCombo = true;
							}
						}
						else if (Class371.dictionary_0[Enum106.flag_0])
						{
							this.method_9(Enum106.flag_0);
						}
						class.sampleSet_0 = (SampleSet)this.class753_0.object_0;
						class.sampleSet_1 = (SampleSet)this.class753_1.object_0;
						this.class297_0.method_20(true);
						return false;
					}
				}
				else
				{
					if (Class570.bool_0)
					{
						if (this.class321_1 != null)
						{
							Class321 class3 = this.class321_1;
							if (this.class304_1 == null || (this.class304_1 == this.class321_1 && this.list_1.Count == 1 && !this.editor_0.bool_16))
							{
								if (this.int_1 < 0)
								{
									float num2 = 0f;
									int int_ = 0;
									Vector2 vector = Class115.smethod_58(Class802.vector2_0);
									for (int i = 1; i < class3.list_3.Count; i++)
									{
										Vector2 vector2 = class3.list_3[i];
										Vector2 vector3 = class3.list_3[i - 1];
										if (!(vector3 == vector2))
										{
											float num3 = Class778.smethod_2(((vector.X - vector3.X) * (vector2.X - vector3.X) + (vector.Y - vector3.Y) * (vector2.Y - vector3.Y)) / Vector2.DistanceSquared(vector3, vector2), 0f, 1f);
											Vector2 vector4;
											vector4..ctor(vector3.X + num3 * (vector2.X - vector3.X), vector3.Y + num3 * (vector2.Y - vector3.Y));
											float num4 = Vector2.DistanceSquared(vector4, vector);
											if (num2 == 0f || num4 <= num2)
											{
												int_ = i;
												num2 = num4;
											}
										}
									}
									this.editor_0.method_16(false);
									class3.method_30(int_, vector);
									return false;
								}
								Vector2 vector5 = class3.list_3[this.int_1];
								if (this.int_1 != 0 && this.int_1 != class3.list_3.Count - 1 && vector5 != class3.list_3[this.int_1 - 1] && vector5 != class3.list_3[this.int_1 + 1])
								{
									this.editor_0.method_16(false);
									class3.method_30(this.int_1, class3.list_3[this.int_1]);
									return false;
								}
							}
						}
						if (this.class304_1 != null)
						{
							if (this.class304_1.method_2() && this.list_1.Count > 1)
							{
								this.method_56(this.class304_1);
								this.bool_10 = true;
							}
							else
							{
								this.Select(this.class304_1);
							}
							return false;
						}
					}
					if (this.int_1 >= 0)
					{
						if (this.class321_1 == null && this.class321_0 != null)
						{
							this.class321_1 = this.class321_0;
							this.Select(this.class321_1);
						}
						return false;
					}
					if (this.class304_1 == null)
					{
						if (!this.bool_7)
						{
							this.vmethod_17();
						}
						return false;
					}
					if (this.bool_7 && this.class304_1 == this.class328_0)
					{
						this.vmethod_17();
						this.Select(this.class328_0);
						this.method_54(this.class328_0.EndTime);
						return false;
					}
					if (!this.bool_7 && this.class304_1 == this.class321_1)
					{
						bool flag3 = false;
						for (int j = 0; j < this.class321_1.method_9().Count; j++)
						{
							Class306 class4 = this.class321_1.method_9()[j];
							bool flag4 = (flag3 || !this.editor_0.bool_16) ? (Vector2.DistanceSquared(this.vector2_3, class4.Position) < this.class297_0.HitObjectRadius * this.class297_0.HitObjectRadius) : (Math.Abs(this.editor_0.method_70((double)class4.StartTime) - (float)Class802.point_0.X) < this.class297_0.HitObjectRadius * 0.5f);
							if (class4.method_2() != flag4)
							{
								class4.method_3(flag4);
								if (flag4)
								{
									class4.class531_3.color_0 = Color.get_Red();
								}
								else if (j < 2)
								{
									class4.Select();
									class4.class531_3.color_0 = Color.get_White();
								}
								this.bool_14 = true;
							}
							if (flag4)
							{
								flag3 = true;
							}
						}
						this.class321_1.method_12(!flag3);
					}
					if (this.class304_1.method_2())
					{
						return false;
					}
					this.vmethod_17();
					this.Select(this.class304_1);
				}
			}
			else if (flag2)
			{
				if (this.editor_0.bool_16 && this.class702_0 != null && this.class702_0.eventTypes_0 == EventTypes.Break)
				{
					if (this.editor_0.method_31(this.class702_0))
					{
						this.editor_0.method_16(false);
						this.editor_0.class872_0.Remove(this.class702_0);
					}
					return false;
				}
				if (this.class321_2 != null)
				{
					Class321 class5 = this.class321_2;
					if (!class5.bool_8 && class5.list_3.Count > 1)
					{
						this.method_55(false);
					}
					else
					{
						this.method_55(true);
					}
				}
				else if (this.class328_0 != null)
				{
					this.method_53();
				}
				else if (this.int_1 >= 0 && this.class321_0 != null && this.class321_0.list_3.Count > 2)
				{
					this.editor_0.method_16(false);
					this.class321_0.method_4();
					this.class321_0.list_3.RemoveAt(this.int_1);
					if (this.int_1 == 0)
					{
						this.class321_0.Position = (this.class321_0.vector2_0 = this.class321_0.list_3[0]);
						this.class321_0.vmethod_5(this.class321_0.list_3[0], false);
					}
					this.class321_0.SpatialLength = 0.0;
					this.class321_0.vmethod_24(true);
				}
				else if (this.class304_1 != null)
				{
					if (this.class304_1.method_2())
					{
						this.vmethod_35();
						this.method_25();
					}
					else if (Class331.enum100_0 != Enum100.const_0 && this.enum42_0 != Class371.Enum42.const_0)
					{
						this.method_9(Enum106.flag_0);
					}
					else
					{
						this.editor_0.method_16(false);
						this.class297_0.Remove(this.class304_1, true);
						this.method_25();
					}
				}
				else if (this.enum42_0 == Class371.Enum42.const_1 || this.enum42_0 == Class371.Enum42.const_2)
				{
					this.method_9(Enum106.flag_0);
				}
			}
			this.editor_0.method_29(true);
			return base.vmethod_6();
		}

		// Token: 0x06001BB7 RID: 7095
		// RVA: 0x000170AE File Offset: 0x000152AE
		internal override bool vmethod_7()
		{
			if (Class802.bool_7)
			{
				this.bool_10 = false;
				this.bool_13 = false;
			}
			this.class883_0.ReadOnly = false;
			return base.vmethod_7();
		}

		// Token: 0x06001B73 RID: 7027
		// RVA: 0x0008AD48 File Offset: 0x00088F48
		internal override bool vmethod_8()
		{
			if (this.bool_10)
			{
				return true;
			}
			this.bool_12 = true;
			this.bool_8 = false;
			this.bool_20 = false;
			this.class705_0 = null;
			this.vector2_0 = (this.vector2_1 = Class802.vector2_0);
			if (this.editor_0.bool_16 && this.int_1 < 0)
			{
				this.editor_0.enum108_0 = Enum108.const_1;
				int num = this.editor_0.method_71(Class802.point_0.X);
				this.class705_0 = this.method_1(ref this.bool_9);
				if (this.class304_1 != null)
				{
					this.editor_0.method_16(true);
					this.bool_20 = true;
					this.int_0 = num - this.class304_1.StartTime;
				}
				else if (this.class705_0 != null)
				{
					this.editor_0.method_16(true);
					this.bool_20 = true;
					this.int_0 = num - (this.bool_9 ? this.class705_0.int_0 : this.class705_0.int_2);
				}
				else
				{
					this.int_2 = (this.int_3 = num);
					this.bool_5 = true;
					this.vmethod_17();
				}
				this.bool_12 = false;
				return true;
			}
			if (this.int_1 < 0 && this.class304_1 == null && (!this.editor_0.bool_15 || this.editor_0.bool_17))
			{
				this.bool_12 = false;
				return false;
			}
			this.editor_0.enum108_0 = Enum108.const_2;
			this.bool_5 = true;
			if (this.class321_2 != null)
			{
				this.bool_5 = false;
			}
			else if (this.int_1 >= 0)
			{
				this.bool_5 = false;
				this.editor_0.method_16(true);
				this.bool_20 = true;
			}
			else if (this.class328_0 == null)
			{
				this.bool_5 = (this.class304_1 == null || this.class304_1.IsType(HitObjectType.Spinner));
				if (Class371.dictionary_0[Enum106.flag_5])
				{
					return true;
				}
				if (this.class304_1 != null && !this.class304_1.IsType(HitObjectType.Spinner) && this.class304_1.method_2())
				{
					List<Class304> arg_226_0 = this.list_1;
					if (Class371.predicate_0 == null)
					{
						Class371.predicate_0 = new Predicate<Class304>(Class371.smethod_2);
					}
					if (arg_226_0.Find(Class371.predicate_0) != null)
					{
						this.vector2_2 = Class115.smethod_58(Class802.vector2_0) - this.list_1[0].Position;
						this.editor_0.method_16(true);
						this.bool_20 = true;
					}
				}
			}
			this.bool_12 = false;
			return true;
		}

		// Token: 0x06001B74 RID: 7028
		// RVA: 0x0008AFC4 File Offset: 0x000891C4
		internal override void vmethod_9()
		{
			this.bool_12 = true;
			this.bool_5 = false;
			this.vector2_2 = Vector2.get_Zero();
			this.int_0 = this.editor_0.method_71(Class802.point_0.X);
			this.int_1 = -1;
			if (this.bool_8)
			{
				this.editor_0.method_29(true);
				if (this.editor_0.enum108_0 == Enum108.const_2)
				{
					this.class297_0.method_20(true);
					if (this.class321_1 != null && this.class321_1.list_2.Count > 0)
					{
						this.class321_1.list_2[0].Select();
					}
				}
			}
			else if (this.bool_20)
			{
				this.editor_0.method_17(true);
			}
			this.class705_0 = null;
			if (!this.bool_11)
			{
				this.bool_10 = false;
			}
			this.bool_12 = false;
			base.vmethod_9();
		}
	}
}
