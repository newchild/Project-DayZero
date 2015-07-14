using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns29;
using ns3;
using ns76;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020004F3 RID: 1267
	internal class Class660 : IComparable<Class660>
	{
		// Token: 0x020004F4 RID: 1268
		[CompilerGenerated]
		private sealed class Class663
		{
			// Token: 0x040021EA RID: 8682
			public Class660 class660_0;

			// Token: 0x040021EB RID: 8683
			public Struct13 struct13_0;

			// Token: 0x060028DC RID: 10460
			// RVA: 0x0001F6E8 File Offset: 0x0001D8E8
			public void method_0()
			{
				this.class660_0.method_7(this.struct13_0);
			}
		}

		// Token: 0x040021DC RID: 8668
		internal bool bool_0;

		// Token: 0x040021E1 RID: 8673
		internal bool bool_1;

		// Token: 0x040021E2 RID: 8674
		private bool bool_2;

		// Token: 0x040021E3 RID: 8675
		internal bool bool_3 = true;

		// Token: 0x040021E4 RID: 8676
		internal bool bool_4 = true;

		// Token: 0x040021E0 RID: 8672
		internal Class512 class512_0;

		// Token: 0x040021D6 RID: 8662
		internal Class531 class531_0;

		// Token: 0x040021E6 RID: 8678
		private Class531 class531_1;

		// Token: 0x040021CF RID: 8655
		protected readonly Class533 class533_0;

		// Token: 0x040021D8 RID: 8664
		internal Class533 class533_1;

		// Token: 0x040021D9 RID: 8665
		internal Class533 class533_2;

		// Token: 0x040021E5 RID: 8677
		internal Class664 class664_0;

		// Token: 0x040021E8 RID: 8680
		internal float float_0 = 1f;

		// Token: 0x040021D0 RID: 8656
		private static int int_0;

		// Token: 0x040021D1 RID: 8657
		private int int_1;

		// Token: 0x040021D4 RID: 8660
		internal int int_2;

		// Token: 0x040021D5 RID: 8661
		internal int int_3;

		// Token: 0x040021D7 RID: 8663
		internal List<Class531> list_0;

		// Token: 0x040021DD RID: 8669
		internal MatchScoringTypes matchScoringTypes_0;

		// Token: 0x040021DB RID: 8667
		internal Mods mods_0;

		// Token: 0x040021DF RID: 8671
		private bool? nullable_0;

		// Token: 0x040021DA RID: 8666
		internal PlayModes playModes_0;

		// Token: 0x040021E9 RID: 8681
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x040021DE RID: 8670
		private SlotTeams slotTeams_0;

		// Token: 0x040021D2 RID: 8658
		internal string string_0;

		// Token: 0x040021E7 RID: 8679
		public Struct13 struct13_0;

		// Token: 0x040021D3 RID: 8659
		internal Vector2 vector2_0;

		// Token: 0x060028D1 RID: 10449
		// RVA: 0x0001F6B3 File Offset: 0x0001D8B3
		internal Class660(int int_4, Class512 class512_1, PlayModes playModes_1) : this(int_4, class512_1.string_2, playModes_1)
		{
			this.bool_1 = true;
			this.vmethod_0(class512_1);
		}

		// Token: 0x060028D2 RID: 10450
		// RVA: 0x0010103C File Offset: 0x000FF23C
		internal Class660(int int_4, string string_1, PlayModes playModes_1)
		{
			this.int_2 = int_4;
			this.playModes_0 = playModes_1;
			this.string_0 = (string_1 ?? "-");
			this.int_1 = Class660.int_0++;
			this.list_0 = new List<Class531>();
			float num = 0.92f;
			this.class531_0 = new Class531(Class885.Load("menu-button-background", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, this.vector2_0, num, true, new Color(0, 0, 0, 100), null);
			this.class531_0.float_3 = 0f;
			this.class531_0.float_2 = 0.6f;
			this.method_4();
			this.list_0.Add(this.class531_0);
			this.class533_0 = new Class533(string_1, 14f, this.vector2_0 + new Vector2(4f, 1f), Vector2.get_Zero(), (float)0.92000301668940665, true, new Color(255, 255, 255, 0), true);
			this.list_0.Add(this.class533_0);
			this.class533_1 = new Class533(string.Empty, 10f, this.vector2_0 + new Vector2(4f, 15f), new Vector2(150f, 33f), (float)0.92000301668940665, true, new Color(255, 255, 255, 0), true);
			this.class533_1.int_0 = 2;
			this.list_0.Add(this.class533_1);
			this.class533_2 = new Class533((int_4 > 0) ? int_4.ToString() : "--", 30f, this.vector2_0 + new Vector2(90f, 0f), Vector2.get_Zero(), num + 2E-06f, true, new Color(255, 255, 255, 120), false);
			this.class533_2.float_3 = 0f;
			this.class533_2.origins_0 = Origins.TopRight;
			this.list_0.Add(this.class533_2);
		}

		// Token: 0x060028D3 RID: 10451
		// RVA: 0x00101278 File Offset: 0x000FF478
		public int CompareTo(Class660 obj)
		{
			if (object.ReferenceEquals(obj, this))
			{
				return 0;
			}
			if (this.slotTeams_0 != obj.slotTeams_0)
			{
				return this.slotTeams_0.CompareTo(obj.slotTeams_0);
			}
			if (this.bool_3 != obj.bool_3)
			{
				if (!this.bool_3)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				int num = 0;
				if (this.class512_0 != null && obj.class512_0 != null)
				{
					switch (this.matchScoringTypes_0)
					{
					case MatchScoringTypes.Score:
						num = obj.int_3.CompareTo(this.int_3);
						break;
					case MatchScoringTypes.Accuracy:
						num = obj.class512_0.vmethod_1().CompareTo(this.class512_0.vmethod_1());
						break;
					case MatchScoringTypes.Combo:
						num = obj.class512_0.ushort_6.CompareTo(this.class512_0.ushort_6);
						break;
					}
				}
				else
				{
					num = obj.int_3.CompareTo(this.int_3);
				}
				if (num != 0)
				{
					return num;
				}
				num = this.string_0.CompareTo(obj.string_0);
				if (num != 0)
				{
					return num;
				}
				if (this.int_1 <= obj.int_1)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x060028CC RID: 10444
		// RVA: 0x0001F649 File Offset: 0x0001D849
		internal SlotTeams method_0()
		{
			return this.slotTeams_0;
		}

		// Token: 0x060028CD RID: 10445
		// RVA: 0x0001F651 File Offset: 0x0001D851
		internal void method_1(SlotTeams slotTeams_1)
		{
			this.slotTeams_0 = slotTeams_1;
			this.method_4();
		}

		// Token: 0x060028CE RID: 10446
		// RVA: 0x0010100C File Offset: 0x000FF20C
		internal bool method_2()
		{
			bool? flag = this.nullable_0;
			if (!flag.HasValue)
			{
				return this.slotTeams_0 == SlotTeams.Red;
			}
			return flag.GetValueOrDefault();
		}

		// Token: 0x060028CF RID: 10447
		// RVA: 0x0001F660 File Offset: 0x0001D860
		internal void method_3(bool bool_5)
		{
			this.nullable_0 = new bool?(bool_5);
			this.method_4();
		}

		// Token: 0x060028D0 RID: 10448
		// RVA: 0x0001F674 File Offset: 0x0001D874
		private void method_4()
		{
			if (this.method_2())
			{
				this.class531_0.vector2_5 = new Vector2(90f, 20f);
				return;
			}
			this.class531_0.vector2_5 = new Vector2(460f, 20f);
		}

		// Token: 0x060028D4 RID: 10452
		// RVA: 0x00101394 File Offset: 0x000FF594
		internal void method_5(Vector2 vector2_1, bool bool_5, bool bool_6)
		{
			int num = bool_6 ? 0 : 600;
			Vector2 vector = vector2_1 - this.list_0[0].vector2_1;
			foreach (Class531 current in this.list_0)
			{
				if (this.bool_0 != bool_5)
				{
					if (bool_5)
					{
						current.method_25(this.float_0, num, Enum70.const_0);
					}
					else
					{
						current.method_16(num, Enum70.const_0);
					}
				}
				if (bool_6)
				{
					List<Class746> arg_86_0 = current.class26_0;
					if (Class660.predicate_0 == null)
					{
						Class660.predicate_0 = new Predicate<Class746>(Class660.smethod_0);
					}
					arg_86_0.RemoveAll(Class660.predicate_0);
					current.vector2_1 += vector;
				}
				else
				{
					current.method_23(vector, num, Enum70.const_1);
				}
			}
			if (bool_5 && !this.bool_2)
			{
				bool flag = false;
				while (this.class533_0.vmethod_11().X > 90f)
				{
					this.class533_0.Text = this.class533_0.Text.Remove(this.class533_0.Text.Length - 1);
					flag = true;
				}
				if (flag)
				{
					Class533 expr_120 = this.class533_0;
					expr_120.Text += "...";
				}
				this.bool_2 = true;
			}
			this.bool_0 = bool_5;
		}

		// Token: 0x060028D7 RID: 10455
		// RVA: 0x001016B0 File Offset: 0x000FF8B0
		internal void method_6(Struct13 struct13_1)
		{
			Class660.Class663 class = new Class660.Class663();
			class.struct13_0 = struct13_1;
			class.class660_0 = this;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060028D8 RID: 10456
		// RVA: 0x001016E8 File Offset: 0x000FF8E8
		internal void method_7(Struct13 struct13_1)
		{
			Class512 class = Class721.Create(this.playModes_0, struct13_1, null);
			class.class623_0 = this.mods_0;
			this.struct13_0 = struct13_1;
			Class512 class2 = this.class512_0;
			this.vmethod_0(class);
			this.bool_3 = struct13_1.bool_0;
			if (class2 != null && class.vmethod_2() != class2.vmethod_2())
			{
				string text = "0";
				bool flag;
				if (flag = (this.playModes_0 == PlayModes.OsuMania))
				{
					if (class.ushort_1 > class2.ushort_1)
					{
						text = "300";
					}
					else if (class.ushort_0 > class2.ushort_0)
					{
						text = "100";
					}
					else if (class.ushort_2 > class2.ushort_2)
					{
						text = "50";
					}
					else if (class.ushort_3 > class2.ushort_3)
					{
						text = "300g";
					}
					else if (class.ushort_4 > class2.ushort_4)
					{
						text = "200";
					}
				}
				else
				{
					if (class.ushort_1 > class2.ushort_1)
					{
						text = "300";
					}
					else if (class.ushort_0 > class2.ushort_0)
					{
						text = "100";
					}
					else if (class.ushort_2 > class2.ushort_2)
					{
						text = "50";
					}
					if (class.ushort_3 > class2.ushort_3)
					{
						text += "g";
					}
					if (class.ushort_4 > class2.ushort_4)
					{
						text += "k";
					}
				}
				if (class.ushort_6 == 0 && class2.ushort_6 == 0)
				{
					return;
				}
				bool flag2;
				if (!(flag2 = (text == "0")) && this.class531_1 != null && this.class531_1.class26_0.Count > 0 && this.class531_1.class26_0[0].int_0 == Class115.int_1)
				{
					return;
				}
				if (this.class531_1 != null && this.class531_1.int_0 == 0)
				{
					this.class531_1.float_0 -= 0.0001f;
					this.class531_1.method_16(100, Enum70.const_0);
					this.class664_0.class911_0.Remove(this.class531_1);
					this.class664_0.class911_0.Add(this.class531_1);
				}
				Class731 class731_;
				if (flag)
				{
					class731_ = Class885.smethod_27("mania-hit" + text, Enum112.flag_6, true)[0];
				}
				else
				{
					class731_ = Class885.Load("hit" + text, Enum112.flag_6);
				}
				Class531 class3 = new Class531(class731_, Origins.Centre, this.class531_0.vector2_1 + (this.method_2() ? new Vector2(-10f, 14f) : new Vector2(110f, 14f)), (flag2 ? 0.95f : 0.949f) - (float)this.int_2 * 0.001f, false, Color.get_White());
				class3.int_0 = (flag2 ? 1 : 0);
				this.class531_1 = class3;
				if (text == "0")
				{
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + Class297.int_7, Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.6f, 0.4f, Class115.int_1, (int)((double)Class115.int_1 + (double)Class297.int_7 * 1.4), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + Class297.int_9 / 2, Class115.int_1 + Class297.int_9 + Class297.int_8, Enum70.const_0));
				}
				else
				{
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + Class297.int_7, Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.2f, 0.4f, Class115.int_1, (int)((double)Class115.int_1 + (double)Class297.int_7 * 0.8), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.4f, 0.3f, Class115.int_1 + Class297.int_7, (int)((double)Class115.int_1 + (double)Class297.int_7 * 1.2), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.3f, 0.35f, Class115.int_1 + Class297.int_7, (int)((double)Class115.int_1 + (double)Class297.int_7 * 1.4), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + Class297.int_9, Class115.int_1 + Class297.int_9 / 2 + Class297.int_8, Enum70.const_0));
				}
				this.class664_0.class911_0.Add(class3);
			}
		}

		// Token: 0x060028D9 RID: 10457
		// RVA: 0x00101BA4 File Offset: 0x000FFDA4
		internal void method_8()
		{
			foreach (Class531 current in this.list_0)
			{
				current.method_16(0, Enum70.const_0);
			}
			this.class531_0.method_16(0, Enum70.const_0);
			this.class533_1.method_16(0, Enum70.const_0);
			this.class533_0.method_16(0, Enum70.const_0);
			this.class533_2.method_16(0, Enum70.const_0);
		}

		// Token: 0x060028DA RID: 10458
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x060028D5 RID: 10453
		// RVA: 0x001014F4 File Offset: 0x000FF6F4
		internal virtual void vmethod_0(Class512 class512_1)
		{
			this.class512_0 = class512_1;
			this.int_3 = class512_1.int_3;
			switch (this.matchScoringTypes_0)
			{
			case MatchScoringTypes.Score:
				this.class533_1.Text = ((class512_1.int_3 > 0) ? class512_1.int_3.ToString("0,0", Class115.numberFormatInfo_0) : "-");
				break;
			case MatchScoringTypes.Accuracy:
				this.class533_1.Text = ((class512_1.int_3 > 0) ? string.Format("{0:n}%", class512_1.vmethod_1() * 100f) : "-");
				break;
			case MatchScoringTypes.Combo:
				this.class533_1.Text = ((class512_1.ushort_6 > 0) ? string.Format("{0}x", class512_1.ushort_6) : "-");
				break;
			}
			Class533 expr_D1 = this.class533_1;
			object text = expr_D1.Text;
			expr_D1.Text = string.Concat(new object[]
			{
				text,
				" (",
				this.bool_1 ? class512_1.int_0 : ((int)class512_1.ushort_6),
				"x)"
			});
			if (!this.bool_1)
			{
				Color color_ = this.class531_0.color_0;
				if (class512_1.bool_2)
				{
					if (class512_1.double_1 > 0.0)
					{
						color_..ctor((byte)(200.0 - class512_1.double_1), 20, (byte)class512_1.double_1, this.class531_0.color_0.get_A());
					}
				}
				else
				{
					color_..ctor(80, 80, 80, this.class531_0.color_0.get_A());
				}
				this.class531_0.method_39(color_, 50, false, Enum70.const_0);
			}
		}

		// Token: 0x060028D6 RID: 10454
		// RVA: 0x0001F6D1 File Offset: 0x0001D8D1
		internal virtual void vmethod_1(string string_1)
		{
			if (!this.bool_4)
			{
				return;
			}
			this.class533_2.Text = string_1;
		}
	}
}
