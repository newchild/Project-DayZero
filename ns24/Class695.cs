using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns29;
using ns64;
using ns69;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x0200052A RID: 1322
	internal class Class695
	{
		// Token: 0x0200052B RID: 1323
		[CompilerGenerated]
		private sealed class Class697
		{
			// Token: 0x040023B6 RID: 9142
			public Class695 class695_0;

			// Token: 0x040023B5 RID: 9141
			public float float_0;

			// Token: 0x06002AFB RID: 11003
			// RVA: 0x00116C20 File Offset: 0x00114E20
			public void method_0(Class530 class530_0)
			{
				if (!(class530_0.object_0 is Vector2))
				{
					return;
				}
				if (class530_0 != this.class695_0.class531_2 && class530_0 != this.class695_0.class531_1)
				{
					if (class530_0 != this.class695_0.class537_0)
					{
						Vector2 vector = (Vector2)class530_0.object_0;
						vector.X += this.float_0;
						class530_0.object_0 = vector;
						return;
					}
				}
			}
		}

		// Token: 0x0200052C RID: 1324
		[CompilerGenerated]
		private sealed class Class698
		{
			// Token: 0x040023B8 RID: 9144
			public bool bool_0;

			// Token: 0x040023B7 RID: 9143
			public Class695 class695_0;

			// Token: 0x06002AFD RID: 11005
			// RVA: 0x00020F5E File Offset: 0x0001F15E
			public void method_0(Class530 class530_0)
			{
				class530_0.method_16(this.bool_0 ? 0 : 200, Enum70.const_0);
			}
		}

		// Token: 0x040023B4 RID: 9140
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002394 RID: 9108
		private bool bool_0;

		// Token: 0x04002395 RID: 9109
		private bool bool_1;

		// Token: 0x04002396 RID: 9110
		private bool bool_2;

		// Token: 0x04002399 RID: 9113
		public bool bool_3;

		// Token: 0x0400239A RID: 9114
		public bool bool_4;

		// Token: 0x040023AF RID: 9135
		internal static bool bool_5;

		// Token: 0x040023B0 RID: 9136
		internal bool bool_6;

		// Token: 0x04002392 RID: 9106
		internal Class296 class296_0;

		// Token: 0x0400239F RID: 9119
		internal Class531 class531_0;

		// Token: 0x040023A3 RID: 9123
		internal Class531 class531_1;

		// Token: 0x040023A9 RID: 9129
		internal Class531 class531_2;

		// Token: 0x040023A0 RID: 9120
		internal Class533 class533_0;

		// Token: 0x040023A1 RID: 9121
		internal Class533 class533_1;

		// Token: 0x040023A2 RID: 9122
		private Class533 class533_2;

		// Token: 0x040023AA RID: 9130
		private Class537 class537_0;

		// Token: 0x04002397 RID: 9111
		internal Class695 class695_0;

		// Token: 0x04002398 RID: 9112
		internal Class695 class695_1;

		// Token: 0x040023A7 RID: 9127
		protected static Class731 class731_0;

		// Token: 0x040023A8 RID: 9128
		protected static Class731 class731_1;

		// Token: 0x040023A4 RID: 9124
		private static Class746 class746_0 = new Class746(TransformationType.Scale, 1f, 1.1f, 0, 300, Enum70.const_1);

		// Token: 0x04002386 RID: 9094
		internal static Color color_0 = new Color(163, 240, 44, 255);

		// Token: 0x04002387 RID: 9095
		internal static Color color_1 = new Color(35, 50, 143, 255);

		// Token: 0x04002390 RID: 9104
		public static Color color_10;

		// Token: 0x04002391 RID: 9105
		public static Color color_11;

		// Token: 0x040023B2 RID: 9138
		internal Color color_12;

		// Token: 0x040023B3 RID: 9139
		[CompilerGenerated]
		private Color color_13;

		// Token: 0x04002388 RID: 9096
		internal static Color color_2 = new Color(35, 90, 193, 255);

		// Token: 0x04002389 RID: 9097
		internal static Color color_3 = new Color(233, 104, 0, 240);

		// Token: 0x0400238A RID: 9098
		internal static Color color_4 = new Color(235, 73, 153, 240);

		// Token: 0x0400238B RID: 9099
		internal static Color color_5 = new Color(0, 150, 236, 240);

		// Token: 0x0400238C RID: 9100
		internal static Color color_6 = Class610.smethod_1(Class695.color_5, 0.3f);

		// Token: 0x0400238D RID: 9101
		internal static Color color_7 = new Color(255, 255, 255, 220);

		// Token: 0x0400238E RID: 9102
		internal static Color color_8 = new Color(Color.get_MediumSlateBlue().get_R(), Color.get_MediumSlateBlue().get_G(), Color.get_MediumSlateBlue().get_B(), 240);

		// Token: 0x0400238F RID: 9103
		public static Color color_9;

		// Token: 0x0400239D RID: 9117
		private double double_0 = -1.0;

		// Token: 0x040023B1 RID: 9137
		protected Enum63 enum63_0;

		// Token: 0x040023AC RID: 9132
		internal float float_0;

		// Token: 0x040023AE RID: 9134
		private float float_1;

		// Token: 0x04002385 RID: 9093
		internal static readonly int int_0 = 10;

		// Token: 0x04002393 RID: 9107
		internal int int_1 = -1;

		// Token: 0x0400239B RID: 9115
		private int int_2;

		// Token: 0x0400239C RID: 9116
		private int int_3;

		// Token: 0x040023AB RID: 9131
		public int int_4;

		// Token: 0x0400239E RID: 9118
		protected List<Class530> list_0;

		// Token: 0x040023A5 RID: 9125
		internal List<Class531> list_1 = new List<Class531>();

		// Token: 0x040023A6 RID: 9126
		private PlayModes? nullable_0;

		// Token: 0x040023AD RID: 9133
		internal Vector2 vector2_0 = Class695.smethod_0();

		// Token: 0x17000390 RID: 912
		internal bool Hidden
		{
			// Token: 0x06002AE4 RID: 10980
			// RVA: 0x00020E11 File Offset: 0x0001F011
			get
			{
				return this.enum63_0 <= Enum63.const_0;
			}
		}

		// Token: 0x1700038F RID: 911
		internal virtual string Name
		{
			// Token: 0x06002ADA RID: 10970
			// RVA: 0x00020D98 File Offset: 0x0001EF98
			get
			{
				return this.class296_0.method_73();
			}
		}

		// Token: 0x06002AD8 RID: 10968
		// RVA: 0x00115760 File Offset: 0x00113960
		internal Class695(Class296 class296_1, Class695 class695_2, PlayModes? nullable_1)
		{
			this.class695_1 = class695_2;
			if (nullable_1.HasValue)
			{
				this.nullable_0 = nullable_1;
			}
			this.method_5(Class695.color_3);
			this.class296_0 = class296_1;
			if (class296_1 != null)
			{
				if (!class296_1.bool_4)
				{
					this.method_5(Class695.color_8);
				}
				this.bool_0 = !class296_1.bool_13;
			}
			this.color_12 = this.method_4();
		}

		// Token: 0x06002ADB RID: 10971
		// RVA: 0x00020DA5 File Offset: 0x0001EFA5
		internal bool Contains(Point point_0)
		{
			return this.class531_0 != null && this.class531_0.rectangleF_0.Contains(point_0);
		}

		// Token: 0x06002AD9 RID: 10969
		// RVA: 0x001157FC File Offset: 0x001139FC
		internal void Dispose()
		{
			if (this.list_0 != null)
			{
				using (List<Class530>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						Class533 class2 = class as Class533;
						if (class2 != null && class2.class731_0 != null)
						{
							class2.class731_0.Dispose();
							class2.class731_0 = null;
						}
					}
				}
			}
		}

		// Token: 0x06002AEC RID: 10988
		// RVA: 0x00020E7D File Offset: 0x0001F07D
		internal void Initialize(bool bool_7)
		{
			this.vmethod_0();
			this.bool_6 = true;
			this.vmethod_1(Enum63.const_0, bool_7);
		}

		// Token: 0x06002AD2 RID: 10962
		// RVA: 0x00020D33 File Offset: 0x0001EF33
		internal bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002AD3 RID: 10963
		// RVA: 0x00020D3B File Offset: 0x0001EF3B
		internal void method_1(bool bool_7)
		{
			if (this.bool_0 == bool_7)
			{
				return;
			}
			this.bool_0 = bool_7;
			this.method_25(300);
		}

		// Token: 0x06002AE1 RID: 10977
		// RVA: 0x0011626C File Offset: 0x0011446C
		private void method_10()
		{
			Class695.Class697 class = new Class695.Class697();
			class.class695_0 = this;
			float num = (float)(Class695.bool_5 ? 15 : 5);
			float num2 = this.float_1;
			this.float_1 = (float)((this.enum63_0 < Enum63.const_2 || (!this.bool_1 && !this.bool_2)) ? 3 : 20) + num;
			if (num2 != this.float_1 && this.list_0 != null)
			{
				class.float_0 = this.float_1 - num2;
				this.list_0.ForEach(new Action<Class530>(class.method_0));
				return;
			}
		}

		// Token: 0x06002AE2 RID: 10978
		// RVA: 0x00020DC2 File Offset: 0x0001EFC2
		internal bool method_11()
		{
			return (this.class695_1 == null || (this.class695_1.method_16() && !this.class695_1.bool_3)) && this.enum63_0 > Enum63.const_0 && !this.bool_3;
		}

		// Token: 0x06002AE3 RID: 10979
		// RVA: 0x00020DFA File Offset: 0x0001EFFA
		internal bool method_12()
		{
			return this.class531_0 != null && this.class531_0.vmethod_1();
		}

		// Token: 0x06002AE6 RID: 10982
		// RVA: 0x00020E1F File Offset: 0x0001F01F
		internal void method_13(Class911 class911_0)
		{
			class911_0.method_17(this.list_0);
		}

		// Token: 0x06002AE7 RID: 10983
		// RVA: 0x00020E2D File Offset: 0x0001F02D
		internal void method_14(Class911 class911_0)
		{
			class911_0.method_13<Class530>(this.list_0);
		}

		// Token: 0x06002AE8 RID: 10984
		// RVA: 0x00116364 File Offset: 0x00114564
		internal void method_15(Vector2 vector2_1)
		{
			using (List<Class530>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					class.vector2_1 = this.vector2_0 + vector2_1;
					if (class.object_0 is Vector2)
					{
						class.vector2_1 += (Vector2)class.object_0;
					}
				}
			}
		}

		// Token: 0x06002AE9 RID: 10985
		// RVA: 0x00020E3B File Offset: 0x0001F03B
		public bool method_16()
		{
			return this.enum63_0 >= Enum63.const_3;
		}

		// Token: 0x06002AEA RID: 10986
		// RVA: 0x00020E49 File Offset: 0x0001F049
		public void method_17(bool bool_7)
		{
			if (this.method_16() == bool_7)
			{
				return;
			}
			if (this.enum63_0 < Enum63.const_3)
			{
				this.method_20(Enum63.const_3);
				return;
			}
			if (this.bool_4)
			{
				this.method_20(Enum63.const_2);
				return;
			}
			this.method_20(Enum63.const_1);
		}

		// Token: 0x06002AEB RID: 10987
		// RVA: 0x001163F4 File Offset: 0x001145F4
		internal void method_18(int int_5)
		{
			if (!this.bool_6)
			{
				return;
			}
			using (List<Class530>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					class.method_16(int_5, Enum70.const_0);
				}
			}
		}

		// Token: 0x06002AEF RID: 10991
		// RVA: 0x00020ED2 File Offset: 0x0001F0D2
		internal Enum63 method_19()
		{
			return this.enum63_0;
		}

		// Token: 0x06002AD4 RID: 10964
		// RVA: 0x00020D59 File Offset: 0x0001EF59
		private bool method_2()
		{
			return !Class695.bool_5 && this.class296_0.int_3 > 0 && Class341.class606_78.Value;
		}

		// Token: 0x06002AF0 RID: 10992
		// RVA: 0x00116A04 File Offset: 0x00114C04
		internal void method_20(Enum63 enum63_1)
		{
			if (this.enum63_0 == enum63_1)
			{
				return;
			}
			Enum63 enum63_2 = this.enum63_0;
			this.enum63_0 = enum63_1;
			if (this.bool_6)
			{
				this.vmethod_1(enum63_2, false);
			}
			this.vmethod_2(enum63_2);
		}

		// Token: 0x06002AF1 RID: 10993
		// RVA: 0x00020EDA File Offset: 0x0001F0DA
		internal bool method_21()
		{
			return this.class531_0 != null && this.class531_0.float_3 == 1f;
		}

		// Token: 0x06002AF2 RID: 10994
		// RVA: 0x00020EF8 File Offset: 0x0001F0F8
		internal void method_22(Color color_14, int int_5)
		{
			if (this.class531_0 != null)
			{
				this.class531_0.method_40(color_14, int_5);
			}
		}

		// Token: 0x06002AF3 RID: 10995
		// RVA: 0x00020F0F File Offset: 0x0001F10F
		internal void method_23(Color color_14, int int_5)
		{
			this.color_12 = color_14;
			this.method_24(int_5);
		}

		// Token: 0x06002AF4 RID: 10996
		// RVA: 0x00020F1F File Offset: 0x0001F11F
		private void method_24(int int_5)
		{
			if (this.class531_0 != null)
			{
				this.class531_0.method_39(this.color_12, int_5, false, Enum70.const_0);
			}
		}

		// Token: 0x06002AF5 RID: 10997
		// RVA: 0x00116A40 File Offset: 0x00114C40
		private void method_25(int int_5)
		{
			switch (this.enum63_0)
			{
			case Enum63.const_3:
				this.method_5(Class695.color_5);
				break;
			case Enum63.const_4:
				this.method_5(Class695.color_7);
				break;
			default:
				this.method_5(this.method_0() ? Class695.color_3 : Class695.color_4);
				break;
			}
			this.method_23(this.method_4(), int_5);
		}

		// Token: 0x06002AF6 RID: 10998
		// RVA: 0x00020F3E File Offset: 0x0001F13E
		[CompilerGenerated]
		private void method_26()
		{
			this.class537_0.method_15(400);
		}

		// Token: 0x06002AF8 RID: 11000
		// RVA: 0x00116AA8 File Offset: 0x00114CA8
		[CompilerGenerated]
		private void method_27(Class531 class531_3)
		{
			Color color;
			if (this.enum63_0 <= Enum63.const_2)
			{
				color = Class695.color_10;
			}
			else
			{
				if (class531_3 != this.class533_1)
				{
					if (class531_3 != this.class533_0)
					{
						color = Class695.color_10;
						goto IL_33;
					}
				}
				color = Class695.color_11;
			}
			IL_33:
			class531_3.color_0 = color;
		}

		// Token: 0x06002AD5 RID: 10965
		// RVA: 0x00020D7C File Offset: 0x0001EF7C
		internal bool method_3()
		{
			return this == this.class695_0;
		}

		// Token: 0x06002AD6 RID: 10966
		// RVA: 0x00020D87 File Offset: 0x0001EF87
		[CompilerGenerated]
		public Color method_4()
		{
			return this.color_13;
		}

		// Token: 0x06002AD7 RID: 10967
		// RVA: 0x00020D8F File Offset: 0x0001EF8F
		[CompilerGenerated]
		protected void method_5(Color color_14)
		{
			this.color_13 = color_14;
		}

		// Token: 0x06002ADC RID: 10972
		// RVA: 0x0011587C File Offset: 0x00113A7C
		internal void method_6(bool bool_7)
		{
			if (!this.bool_6 || this.enum63_0 < Enum63.const_2)
			{
				return;
			}
			double num = Math.Min(this.class296_0.method_26(), 10.0);
			if (this.double_0 == num)
			{
				return;
			}
			this.method_8();
			if (num < 0.0)
			{
				num = 0.0;
				int num2 = this.int_2 + Class695.int_0;
				for (int i = this.int_2; i < num2; i++)
				{
					Class530 class = this.list_0[i];
					class.method_16(bool_7 ? 0 : (Class695.bool_5 ? 1000 : 600), Enum70.const_0);
				}
			}
			else
			{
				int num3 = this.int_2 + Class695.int_0;
				for (int j = this.int_2; j < num3; j++)
				{
					Class530 class2 = this.list_0[j];
					class2.method_14(bool_7 ? 0 : (Class695.bool_5 ? 1000 : 600), Enum70.const_0);
				}
			}
			int num4 = this.int_2 + Class695.int_0 * 2;
			for (int k = this.int_2 + Class695.int_0; k < num4; k++)
			{
				int num5 = k - (this.int_2 + Class695.int_0);
				double num6 = num - (double)num5;
				Class531 class3 = this.list_0[k] as Class531;
				class3.class26_0.Clear();
				if (Class695.bool_5)
				{
					int int_ = (int)((double)class3.int_6 * num6);
					class3.method_47(int_, bool_7 ? 0 : 500, Enum70.const_7);
				}
				else
				{
					float num7 = (num6 <= 0.0) ? 0f : (0.6f * (float)Math.Max(0.5, Math.Min(1.0, num6) + (double)((float)num5 * 0.04f)));
					int num8 = (int)Math.Floor((double)num5 - Math.Min(num, this.double_0));
					if (bool_7)
					{
						class3.method_26(num7, 0, Enum70.const_0);
					}
					else
					{
						int num9 = (this.double_0 <= num) ? num8 : ((int)Math.Floor(this.double_0 - num) - num8 - 1);
						int num10 = Class115.int_1 + num9 * 80 + 50;
						class3.class26_0.Add(new Class746(TransformationType.Scale, class3.float_2, num7, num10, num10 + 500, Enum70.const_30));
					}
				}
			}
			this.double_0 = num;
		}

		// Token: 0x06002ADD RID: 10973
		// RVA: 0x00115AEC File Offset: 0x00113CEC
		internal void method_7(float float_2)
		{
			this.float_0 = float_2;
			if (this.list_0 == null)
			{
				return;
			}
			using (List<Class530>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					class.float_0 = float_2;
					float_2 += 1E-06f;
				}
			}
		}

		// Token: 0x06002ADF RID: 10975
		// RVA: 0x00116158 File Offset: 0x00114358
		internal void method_8()
		{
			if (this.class296_0 == null)
			{
				return;
			}
			this.class533_2.Text = this.class296_0.string_14;
			if ((Class62.Mode == PlayModes.OsuMania && this.class296_0.method_5() == PlayModes.Osu) || this.class296_0.method_5() == PlayModes.OsuMania)
			{
				Class533 expr_48 = this.class533_2;
				expr_48.Text += string.Format(" ({0}K{1})", Class421.smethod_2(this.class296_0), (Math.Round((double)this.class296_0.DifficultyOverall) <= 4.0) ? "↓" : string.Empty);
			}
		}

		// Token: 0x06002AE0 RID: 10976
		// RVA: 0x00116200 File Offset: 0x00114400
		internal void method_9()
		{
			this.class531_1.vmethod_7((this.class296_0.method_41() > Rankings.D) ? null : Class885.Load("ranking-" + this.class296_0.method_41() + "-small", Enum112.flag_6));
			this.bool_2 = (this.class531_1.vmethod_6() != null);
			this.method_10();
		}

		// Token: 0x06002AD1 RID: 10961
		// RVA: 0x00020D19 File Offset: 0x0001EF19
		internal static Vector2 smethod_0()
		{
			return new Vector2(Class86.smethod_0() + 500f, (float)(Class115.smethod_44() / 2));
		}

		// Token: 0x06002AE5 RID: 10981
		// RVA: 0x001162FC File Offset: 0x001144FC
		public static void smethod_1()
		{
			Class695.color_9 = Class885.dictionary_7["SongSelectActiveText"];
			Class695.color_10 = Class885.dictionary_7["SongSelectInactiveText"];
			Class695.color_11 = Class610.smethod_7(Class695.color_10, 50);
			Class695.class731_0 = Class885.Load("menu-button-background", Enum112.flag_6);
			Class695.class731_1 = Class885.Load("star", Enum112.flag_6);
		}

		// Token: 0x06002AF7 RID: 10999
		// RVA: 0x00020F51 File Offset: 0x0001F151
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_3)
		{
			class531_3.color_0 = Class695.color_9;
		}

		// Token: 0x06002ADE RID: 10974
		// RVA: 0x00115B60 File Offset: 0x00113D60
		protected virtual void vmethod_0()
		{
			VoidDelegate voidDelegate = null;
			this.list_0 = new List<Class530>();
			if (this.class296_0 != null)
			{
				PlayModes? playModes = this.nullable_0;
				if (this.class296_0 != null && this.class296_0.method_5() != PlayModes.Osu)
				{
					playModes = new PlayModes?(this.class296_0.method_5());
				}
				Class695.bool_5 = (Class885.class547_0.double_0 < 2.2 && Class885.Load("menu-button-background", Enum112.flag_6).enum112_0 != Enum112.flag_1);
				this.class296_0.method_75();
				if (this.class296_0.string_5.Length <= 0)
				{
				}
				this.class531_0 = new Class531(Class695.class731_0, Enum115.const_5, Origins.CentreLeft, Enum114.const_0, this.vector2_0, this.float_0, true, this.color_12, this);
				this.class531_0.bool_1 = true;
				this.list_0.Add(this.class531_0);
				bool flag = this.method_2();
				float num = (float)(Class695.bool_5 ? 15 : 5);
				float num2 = (float)(flag ? 75 : 5);
				float num3 = (float)(Class695.bool_5 ? -3 : 0);
				this.class533_0 = new Class533(this.Name, 16f, Vector2.get_Zero(), Vector2.get_Zero(), this.float_0 + 1E-06f, true, Class695.color_10, false);
				this.class533_0.origins_0 = Origins.CentreLeft;
				this.class533_0.object_0 = new Vector2(num2, num3 - 16f);
				this.list_1.Add(this.class533_0);
				this.list_0.Add(this.class533_0);
				this.class533_1 = new Class533(this.class296_0.method_74() + " // " + this.class296_0.string_5, 12f, Vector2.get_Zero(), Vector2.get_Zero(), this.float_0 + 1E-06f, true, Class695.color_10, false);
				this.class533_1.origins_0 = Origins.CentreLeft;
				this.class533_1.object_0 = new Vector2(num2 + 1f, num3 - 4f);
				this.list_1.Add(this.class533_1);
				this.list_0.Add(this.class533_1);
				if (flag)
				{
					bool flag2 = Class115.int_23 >= 768;
					this.class537_0 = new Class537(string.Concat(new object[]
					{
						"http://b.ppy.sh/thumb/",
						this.class296_0.int_3,
						flag2 ? "l" : "",
						".jpg"
					}), string.Concat(new object[]
					{
						"Data\\bt\\",
						this.class296_0.int_3,
						flag2 ? "l" : "",
						".jpg"
					}), 500, Vector2.get_Zero(), this.float_0 + 1E-06f);
					Class537 arg_30D_0 = this.class537_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_26);
					}
					arg_30D_0.method_55(voidDelegate);
					this.class537_0.color_0 = new Color(50, 50, 50, 255);
					this.class537_0.bool_7 = true;
					this.class537_0.vector2_2 = new Vector2(1.425f, 1.425f) * (flag2 ? 0.5f : 1f);
					this.class537_0.origins_0 = Origins.CentreLeft;
					this.class537_0.object_0 = new Vector2(5.2f, 0.25f);
					this.list_0.Add(this.class537_0);
				}
				this.int_4 = this.list_0.Count;
				this.class533_2 = new Class533(string.Empty, 12f, Vector2.get_Zero(), Vector2.get_Zero(), this.float_0 + 1E-06f, true, Class695.color_10, false);
				this.class533_2.origins_0 = Origins.CentreLeft;
				this.class533_2.bool_16 = true;
				this.class533_2.object_0 = new Vector2(num2 + 1f, num3 + 7f);
				this.list_1.Add(this.class533_2);
				this.list_0.Add(this.class533_2);
				this.method_8();
				if (playModes.HasValue)
				{
					this.bool_1 = true;
					Class731 class = null;
					PlayModes valueOrDefault = playModes.GetValueOrDefault();
					if (playModes.HasValue)
					{
						switch (valueOrDefault)
						{
						case PlayModes.Osu:
							class = Class885.Load("mode-osu-small", Enum112.flag_1);
							break;
						case PlayModes.Taiko:
							class = Class885.Load("mode-taiko-small", Enum112.flag_1);
							break;
						case PlayModes.CatchTheBeat:
							class = Class885.Load("mode-fruits-small", Enum112.flag_1);
							break;
						case PlayModes.OsuMania:
							class = Class885.Load("mode-mania-small", Enum112.flag_1);
							break;
						}
					}
					this.class531_2 = new Class531(class, Enum115.const_5, Origins.CentreLeft, Enum114.const_0, Vector2.get_Zero(), this.float_0 + 1E-06f, true, Color.get_White(), null);
					this.class531_2.vector2_2 = new Vector2(0.8f, 0.8f);
					this.class531_2.object_0 = new Vector2(num + num2 + 1f, num3 - 13f);
					this.list_1.Add(this.class531_2);
					this.list_0.Add(this.class531_2);
				}
				this.class531_1 = new Class531(null, Origins.CentreLeft, Vector2.get_Zero(), this.float_0 + 1E-06f, true, Color.get_White());
				this.class531_1.object_0 = new Vector2(num + num2 - 1f, num3 + (float)(this.bool_1 ? 14 : 0));
				this.list_0.Add(this.class531_1);
				this.method_9();
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				this.list_0[i].float_3 = 0f;
			}
		}

		// Token: 0x06002AED RID: 10989
		// RVA: 0x00116458 File Offset: 0x00114658
		internal virtual void vmethod_1(Enum63 enum63_1, bool bool_7)
		{
			Action<Class530> action = null;
			Action<Class531> action2 = null;
			Class695.Class698 class = new Class695.Class698();
			class.bool_0 = bool_7;
			class.class695_0 = this;
			if (this.enum63_0 <= Enum63.const_0)
			{
				if (this.list_0[0].float_3 != 0f)
				{
					List<Class530> arg_59_0 = this.list_0;
					if (action == null)
					{
						action = new Action<Class530>(class.method_0);
					}
					arg_59_0.ForEach(action);
				}
			}
			else if (enum63_1 <= Enum63.const_0)
			{
				int num = (this.enum63_0 >= Enum63.const_2) ? this.list_0.Count : this.int_4;
				for (int i = 0; i < num; i++)
				{
					this.list_0[i].method_15(class.bool_0 ? 0 : 200);
				}
			}
			this.method_10();
			if ((this.enum63_0 >= Enum63.const_2 && enum63_1 < Enum63.const_2) || (this.enum63_0 < Enum63.const_2 && enum63_1 >= Enum63.const_2))
			{
				float num2 = (float)(Class695.bool_5 ? -3 : 0);
				float num3 = (float)(this.method_2() ? 75 : 5);
				if (this.enum63_0 >= Enum63.const_2)
				{
					this.int_2 = this.list_0.Count;
					this.int_3 = this.list_1.Count;
					Color color;
					color..ctor(255, 255, 255, 30);
					for (int j = 0; j < Class695.int_0; j++)
					{
						Class531 class2 = new Class531(Class695.class731_1, Enum115.const_5, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), this.class533_0.float_0, true, color, this.class296_0)
						{
							vector2_2 = new Vector2(0.6f, 0.6f),
							object_0 = new Vector2(this.float_1 + num3 + ((float)j + 0.5f) * ((float)Class695.class731_1.method_0() * 0.625f) * 0.6f, num2 + 18f),
							bool_7 = true,
							float_3 = 0f
						};
						if (!Class695.bool_5)
						{
							class2.float_2 = 0.35f;
						}
						this.list_0.Add(class2);
					}
					for (int k = 0; k < Class695.int_0; k++)
					{
						Class531 class3 = new Class531(Class695.class731_1, Enum115.const_5, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), this.class533_0.float_0 + 1E-06f, true, Color.get_White(), this.class296_0)
						{
							vector2_2 = new Vector2(0.6f, 0.6f),
							object_0 = new Vector2(this.float_1 + num3 + ((float)k + 0.5f) * ((float)Class695.class731_1.method_0() * 0.625f) * 0.6f, num2 + 18f)
						};
						if (Class695.bool_5)
						{
							class3.int_4 = -(class3.int_6 * k);
						}
						else
						{
							class3.float_2 = 0f;
						}
						this.list_0.Add(class3);
						this.list_1.Add(class3);
					}
					for (int l = 0; l < this.list_0.Count; l++)
					{
						Class531 class4 = this.list_0[l] as Class531;
						if (l >= this.int_4 && (l < this.int_2 || l >= this.int_2 + Class695.int_0))
						{
							class4.method_14(class.bool_0 ? 0 : 300, Enum70.const_0);
						}
					}
					this.method_6(class.bool_0);
				}
				else
				{
					for (int m = 0; m < this.list_0.Count; m++)
					{
						Class531 class5 = this.list_0[m] as Class531;
						if (m >= this.int_4)
						{
							class5.method_16(class.bool_0 ? 0 : 300, Enum70.const_0);
						}
					}
					int num4 = this.int_2 + Class695.int_0 * 2;
					for (int n = this.int_2; n < num4; n++)
					{
						this.list_0[n].bool_0 = false;
					}
					this.list_0.RemoveRange(this.int_2, Class695.int_0 * 2);
					this.list_1.RemoveRange(this.int_3, Class695.int_0);
					this.double_0 = -1.0;
				}
			}
			if ((this.enum63_0 >= Enum63.const_3 && enum63_1 < Enum63.const_3) || (this.enum63_0 < Enum63.const_3 && enum63_1 >= Enum63.const_3))
			{
				if (this.enum63_0 >= Enum63.const_3)
				{
					if (this.class537_0 != null)
					{
						this.class537_0.bool_7 = false;
						this.class537_0.method_15(class.bool_0 ? 0 : 1000);
						this.class537_0.int_7 = 100;
						this.class537_0.method_39(new Color(255, 255, 255, 255), class.bool_0 ? 0 : 300, false, Enum70.const_0);
					}
				}
				else if (this.class537_0 != null)
				{
					this.class537_0.bool_7 = true;
					this.class537_0.int_7 = 500;
					this.class537_0.method_39(new Color(50, 50, 50, 255), class.bool_0 ? 0 : 300, false, Enum70.const_0);
				}
				this.method_10();
			}
			this.method_25(class.bool_0 ? 0 : 300);
			if (this.enum63_0 == Enum63.const_4)
			{
				List<Class531> arg_577_0 = this.list_1;
				if (Class695.action_0 == null)
				{
					Class695.action_0 = new Action<Class531>(Class695.smethod_2);
				}
				arg_577_0.ForEach(Class695.action_0);
				return;
			}
			List<Class531> arg_597_0 = this.list_1;
			if (action2 == null)
			{
				action2 = new Action<Class531>(this.method_27);
			}
			arg_597_0.ForEach(action2);
		}

		// Token: 0x06002AEE RID: 10990
		// RVA: 0x00020E94 File Offset: 0x0001F094
		internal virtual void vmethod_2(Enum63 enum63_1)
		{
			if (!this.bool_6 && this.method_16())
			{
				this.Initialize(false);
			}
			if (enum63_1 <= Enum63.const_0 && !this.method_3() && this.class695_0 != null)
			{
				this.vector2_0 = this.class695_0.vector2_0;
			}
		}
	}
}
