using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns23;
using ns24;
using ns26;
using ns29;
using ns5;
using ns59;
using ns64;
using ns70;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns85;
using ns91;
using osu;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.Beatmaps;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu.Graphics.OpenGl;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns60
{
	// Token: 0x0200042E RID: 1070
	internal class Class321 : Class320
	{
		// Token: 0x0200042F RID: 1071
		[CompilerGenerated]
		private sealed class Class502
		{
			// Token: 0x04001B0C RID: 6924
			public double double_0;

			// Token: 0x06002296 RID: 8854
			// RVA: 0x0001BAFC File Offset: 0x00019CFC
			public bool method_0(double double_1)
			{
				return double_1 > this.double_0;
			}
		}

		// Token: 0x02000430 RID: 1072
		[CompilerGenerated]
		private sealed class Class503
		{
			// Token: 0x04001B0D RID: 6925
			public Vector2 vector2_0;

			// Token: 0x06002298 RID: 8856
			// RVA: 0x0001BB07 File Offset: 0x00019D07
			public void method_0(Class311 class311_0)
			{
				class311_0.vmethod_5(class311_0.Position + this.vector2_0, false);
			}
		}

		// Token: 0x02000431 RID: 1073
		[CompilerGenerated]
		private sealed class Class504
		{
			// Token: 0x04001B0F RID: 6927
			public Class321 class321_0;

			// Token: 0x04001B0E RID: 6926
			public float float_0;
		}

		// Token: 0x02000432 RID: 1074
		[CompilerGenerated]
		private sealed class Class505
		{
			// Token: 0x04001B10 RID: 6928
			public Class321.Class504 class504_0;

			// Token: 0x04001B11 RID: 6929
			public int int_0;

			// Token: 0x0600229B RID: 8859
			// RVA: 0x0001BB21 File Offset: 0x00019D21
			public bool method_0(double double_0)
			{
				return double_0 < this.class504_0.class321_0.list_5[this.int_0] - (double)this.class504_0.float_0;
			}
		}

		// Token: 0x02000433 RID: 1075
		[CompilerGenerated]
		private sealed class Class506
		{
			// Token: 0x04001B12 RID: 6930
			public int int_0;

			// Token: 0x0600229D RID: 8861
			// RVA: 0x0001BB4E File Offset: 0x00019D4E
			public bool method_0(Class746 class746_0)
			{
				return class746_0.int_0 <= this.int_0 && class746_0.int_1 >= this.int_0;
			}
		}

		// Token: 0x04001B06 RID: 6918
		[CompilerGenerated]
		private static Action<Class306> action_2;

		// Token: 0x04001B07 RID: 6919
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04001B09 RID: 6921
		[CompilerGenerated]
		private static Action<Class311> action_4;

		// Token: 0x04001B0B RID: 6923
		[CompilerGenerated]
		private static Action<Class311> action_5;

		// Token: 0x04001AF4 RID: 6900
		internal bool bool_10 = true;

		// Token: 0x04001AF5 RID: 6901
		private bool bool_11;

		// Token: 0x04001AF9 RID: 6905
		internal bool bool_12;

		// Token: 0x04001AFC RID: 6908
		internal bool[] bool_13;

		// Token: 0x04001AEE RID: 6894
		internal bool bool_6;

		// Token: 0x04001AEF RID: 6895
		private bool bool_7;

		// Token: 0x04001AF1 RID: 6897
		internal bool bool_8;

		// Token: 0x04001AF2 RID: 6898
		private bool bool_9;

		// Token: 0x04001AEB RID: 6891
		internal Class306 class306_0;

		// Token: 0x04001ADE RID: 6878
		internal readonly Class531 class531_0;

		// Token: 0x04001ADF RID: 6879
		internal readonly Class531 class531_1;

		// Token: 0x04001AE5 RID: 6885
		internal Class531 class531_2;

		// Token: 0x04001ADD RID: 6877
		internal readonly Class538 class538_0;

		// Token: 0x04001AE1 RID: 6881
		internal readonly Class538 class538_1;

		// Token: 0x04001AE2 RID: 6882
		protected Class911 class911_0;

		// Token: 0x04001AE3 RID: 6883
		internal CurveTypes curveTypes_0;

		// Token: 0x04001AEC RID: 6892
		internal CurveTypes curveTypes_1;

		// Token: 0x04001AE8 RID: 6888
		internal double double_1;

		// Token: 0x04001B02 RID: 6914
		internal double double_2;

		// Token: 0x04001AED RID: 6893
		private float float_0;

		// Token: 0x04001AFA RID: 6906
		private int int_10;

		// Token: 0x04001AFB RID: 6907
		internal int int_11;

		// Token: 0x04001AE4 RID: 6884
		private int int_6;

		// Token: 0x04001AF3 RID: 6899
		private int int_7;

		// Token: 0x04001AF7 RID: 6903
		internal int int_8;

		// Token: 0x04001AF8 RID: 6904
		private int int_9;

		// Token: 0x04001B01 RID: 6913
		public List<SampleSet> list_10 = new List<SampleSet>();

		// Token: 0x04001AE0 RID: 6880
		internal readonly List<Class311> list_2;

		// Token: 0x04001AE6 RID: 6886
		internal List<Vector2> list_3;

		// Token: 0x04001AE7 RID: 6887
		internal List<Class880> list_4;

		// Token: 0x04001AEA RID: 6890
		internal List<double> list_5;

		// Token: 0x04001AFD RID: 6909
		internal List<int> list_6 = new List<int>();

		// Token: 0x04001AFE RID: 6910
		internal List<int> list_7 = new List<int>();

		// Token: 0x04001AFF RID: 6911
		public List<HitObjectSoundType> list_8 = new List<HitObjectSoundType>();

		// Token: 0x04001B00 RID: 6912
		public List<SampleSet> list_9 = new List<SampleSet>();

		// Token: 0x04001AF6 RID: 6902
		private MouseButtons mouseButtons_0;

		// Token: 0x04001B05 RID: 6917
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x04001B08 RID: 6920
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04001B0A RID: 6922
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x04001AE9 RID: 6889
		private RenderTarget2D renderTarget2D_0;

		// Token: 0x04001AF0 RID: 6896
		private Vector2 vector2_1;

		// Token: 0x04001B03 RID: 6915
		[CompilerGenerated]
		private Vector2 vector2_2;

		// Token: 0x04001B04 RID: 6916
		[CompilerGenerated]
		private Vector2 vector2_3;

		// Token: 0x17000373 RID: 883
		public override int ComboNumber
		{
			// Token: 0x06002262 RID: 8802
			// RVA: 0x0001B8F0 File Offset: 0x00019AF0
			get
			{
				return this.class306_0.ComboNumber;
			}
			// Token: 0x06002263 RID: 8803
			// RVA: 0x0001B8FD File Offset: 0x00019AFD
			set
			{
				this.class306_0.ComboNumber = value;
			}
		}

		// Token: 0x17000372 RID: 882
		public override Vector2 EndPosition
		{
			// Token: 0x06002260 RID: 8800
			// RVA: 0x0001B8DF File Offset: 0x00019ADF
			get;
			// Token: 0x06002261 RID: 8801
			// RVA: 0x0001B8E7 File Offset: 0x00019AE7
			set;
		}

		// Token: 0x06002259 RID: 8793
		// RVA: 0x000CAD04 File Offset: 0x000C8F04
		internal Class321(Class297 class297_1, Vector2 vector2_4, int int_12, bool bool_14, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_2, int int_13, double double_3, List<Vector2> list_11, List<HitObjectSoundType> list_12, int int_14) : base(class297_1)
		{
			this.curveTypes_0 = curveTypes_2;
			this.curveTypes_1 = curveTypes_2;
			this.int_0 = int_14;
			this.class911_0 = this.class297_0.class911_0;
			this.StartTime = int_12;
			this.EndTime = int_12;
			this.Position = vector2_4;
			this.vector2_0 = vector2_4;
			this.EndPosition = vector2_4;
			this.SoundType = hitObjectSoundType_0;
			if (list_11 == null)
			{
				this.list_3 = new List<Vector2>();
				this.list_3.Add(this.Position);
			}
			else
			{
				this.list_3 = list_11;
				if (this.list_3.Count > 0)
				{
					if (this.list_3[0] != this.Position)
					{
						this.list_3.Insert(0, this.Position);
					}
				}
				else
				{
					this.list_3.Add(this.Position);
				}
			}
			this.SegmentCount = Math.Max(1, int_13);
			this.bool_10 = (list_12 == null || list_12.Count == 0);
			if (!this.bool_10)
			{
				this.list_8 = list_12;
				this.list_9 = new List<SampleSet>(int_13 + 1);
				this.list_10 = new List<SampleSet>(int_13 + 1);
			}
			this.SpatialLength = double_3;
			this.bool_4 = true;
			this.list_2 = new List<Class311>();
			this.Type = HitObjectType.Slider;
			if (bool_14)
			{
				this.Type |= HitObjectType.NewCombo;
			}
			if (this.class911_0 != null)
			{
				this.vmethod_23();
				this.class538_1 = new Class538(Class885.smethod_27("sliderfollowcircle", Enum112.flag_6, true), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, 0.99f, false, Color.get_TransparentWhite(), this);
				this.class538_1.method_61();
				Class731[] array = Class885.smethod_27("sliderb", Enum112.flag_6, false);
				bool flag = array[0].enum112_0 == Enum112.flag_1;
				this.class538_0 = new Class538(array, Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, 0.99f, false, flag ? Class885.smethod_23("SliderBall", true) : Color.get_White(), this);
				this.class538_0.bool_10 = true;
				if (flag)
				{
					this.class531_0 = new Class531(Class885.Load("sliderb-spec", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, 1f, false, Color.get_White(), null)
					{
						bool_7 = true
					};
					this.class531_1 = new Class531(Class885.Load("sliderb-nd", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, 0.98f, false, new Color(5, 5, 5), null);
				}
				this.class531_2 = new Class531(null, Enum115.const_4, Origins.TopLeft, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.EndTime + 10)), false, Color.get_White(), null);
				this.class531_2.bool_6 = true;
			}
		}

		// Token: 0x0600225E RID: 8798
		// RVA: 0x000CB18C File Offset: 0x000C938C
		internal override Class304 Clone()
		{
			List<HitObjectSoundType> list = null;
			if (this.list_8 != null)
			{
				list = new List<HitObjectSoundType>();
				list.AddRange(this.list_8);
			}
			List<Vector2> list2 = new List<Vector2>();
			list2.AddRange(this.list_3);
			Class321 class = new Class321(this.class297_0, this.Position, this.StartTime, this.Type.IsType(HitObjectType.NewCombo), this.SoundType, this.curveTypes_0, this.SegmentCount, this.SpatialLength, list2, list, this.int_0);
			class.vector2_0 = this.vector2_0;
			class.ComboNumber = this.ComboNumber;
			class.list_6 = new List<int>(this.list_6);
			class.EndTime = this.EndTime;
			class.EndPosition = this.EndPosition;
			class.vmethod_0(this.Colour);
			class.method_3(base.method_2());
			class.method_12(this.method_11());
			class.int_1 = this.int_1;
			class.curveTypes_1 = this.curveTypes_1;
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.int_3 = this.int_3;
			class.int_2 = this.int_2;
			class.string_0 = this.string_0;
			if (this.list_9 != null)
			{
				class.list_9 = new List<SampleSet>(this.list_9);
			}
			if (this.list_10 != null)
			{
				class.list_10 = new List<SampleSet>(this.list_10);
			}
			return class;
		}

		// Token: 0x0600225F RID: 8799
		// RVA: 0x0001B8C8 File Offset: 0x00019AC8
		protected override void Dispose(bool bool_14)
		{
			if (this.class531_2 != null)
			{
				this.method_10();
			}
			base.Dispose(bool_14);
		}

		// Token: 0x06002267 RID: 8807
		// RVA: 0x000CCA14 File Offset: 0x000CAC14
		internal override void Draw()
		{
			if (this.vmethod_9() && this.list_4 != null)
			{
				float num = (!Class341.class606_61 || (Class115.osuModes_1 == OsuModes.Edit && !Class341.class606_19) || this.bool_6 || base.method_2()) ? 1f : Math.Min(1f, (float)(Class331.int_7 - (this.StartTime - this.class297_0.PreEmpt)) / ((float)this.class297_0.PreEmpt / 3f));
				if ((this.float_0 != num && Class115.bool_13) || this.class531_2 == null || this.class531_2.vmethod_6() == null || this.class531_2.vmethod_6().method_4())
				{
					Class321.Class502 class = new Class321.Class502();
					this.method_10();
					this.float_0 = num;
					List<Class880> list = new List<Class880>();
					int num2 = 0;
					bool flag = false;
					class.double_0 = (double)num * this.SpatialLength;
					int num3 = (num >= 1f) ? this.list_4.Count : (this.list_5.FindIndex(new Predicate<double>(class.method_0)) + 1);
					if (num3 == 0)
					{
						num3 = this.list_4.Count;
					}
					float num4 = (num >= 1f || num3 - 2 < 0) ? 0f : ((float)class.double_0 - ((num3 == 1) ? 0f : ((float)this.list_5[num3 - 2])));
					Vector2 vector = Class115.smethod_61(this.Position);
					Vector2 vector2 = Class115.smethod_61(this.vmethod_10());
					int i = this.int_6;
					while (i < num3)
					{
						if (!flag)
						{
							num2 = i;
						}
						bool flag2 = i == num3 - 1;
						if (!this.list_4[i].bool_1)
						{
							goto IL_1C4;
						}
						if (Class885.smethod_4() == Enum68.const_0)
						{
							goto IL_1C4;
						}
						int arg_1C5_0 = 32;
						IL_1C5:
						int num5 = arg_1C5_0;
						if (Vector2.Distance(this.list_4[num2].vector2_0, this.list_4[i].vector2_1) > (float)num5 || flag2 || this.list_4[i].bool_0)
						{
							goto IL_21D;
						}
						if (i == num3 - 2)
						{
							goto IL_21D;
						}
						flag = true;
						IL_319:
						i++;
						continue;
						IL_21D:
						if (flag2 && num4 > 0f)
						{
							Class880 class2 = new Class880(this.list_4[num2].vector2_0, this.list_4[i].vector2_1);
							class2.vector2_1 = class2.vector2_0 + Vector2.Normalize(class2.vector2_1 - class2.vector2_0) * num4;
							Class115.smethod_64(ref class2);
							if (num < 1f)
							{
								vector2 = class2.vector2_1;
							}
							list.Add(class2);
						}
						else if (num2 == i)
						{
							Class880 class3 = Class115.smethod_65(this.list_4[i]);
							vector2 = class3.vector2_1;
							list.Add(class3);
						}
						else
						{
							Class880 class4 = Class115.smethod_65(new Class880(this.list_4[num2].vector2_0, this.list_4[i].vector2_1));
							vector2 = class4.vector2_1;
							list.Add(class4);
						}
						flag = false;
						goto IL_319;
						IL_1C4:
						arg_1C5_0 = 6;
						goto IL_1C5;
					}
					this.int_6 = num3;
					if (num3 == 0)
					{
						return;
					}
					Vector2 vector3 = (float)(Class297.int_5 / 2) * Vector2.get_One();
					Vector2 vector4 = vector3;
					int num6 = 0;
					int num7 = 0;
					float num8 = this.class297_0.HitObjectRadius * Class115.float_1 * ((!Class115.bool_26 || Class115.int_0 >= 2) ? 1f : 0.95f);
					int count = list.Count;
					int num9;
					int num10;
					if (count > 0)
					{
						Vector2 vector2_ = list[0].vector2_0;
						Vector2 vector2_2 = list[0].vector2_0;
						for (int j = 0; j < count; j++)
						{
							Class880 class5 = list[j];
							if (class5.vector2_1.X < vector2_.X)
							{
								vector2_.X = class5.vector2_1.X;
							}
							else if (class5.vector2_1.X > vector2_2.X)
							{
								vector2_2.X = class5.vector2_1.X;
							}
							if (class5.vector2_1.Y < vector2_.Y)
							{
								vector2_.Y = class5.vector2_1.Y;
							}
							else if (class5.vector2_1.Y > vector2_2.Y)
							{
								vector2_2.Y = class5.vector2_1.Y;
							}
						}
						num9 = (int)((double)(vector2_2.X - vector2_.X) + (double)num8 * 2.3);
						num10 = (int)((double)(vector2_2.Y - vector2_.Y) + (double)num8 * 2.3);
						num6 = (int)((double)vector2_.X - (double)num8 * 1.15);
						num7 = (int)((double)vector2_.Y - (double)num8 * 1.15);
					}
					else
					{
						num9 = (int)((double)num8 * 2.2);
						num10 = (int)((double)num8 * 2.2);
					}
					int num11 = num9;
					int num12 = num10;
					int num13 = num6;
					int num14 = num7;
					if (Class115.osuModes_1 == OsuModes.Edit)
					{
						int num15 = num14 + num12 - (Class115.int_23 + Class115.int_25);
						if (num15 > 0)
						{
							for (int k = 0; k < count; k++)
							{
								Class880 class6 = list[k];
								Class880 expr_555_cp_0 = class6;
								expr_555_cp_0.vector2_0.Y = expr_555_cp_0.vector2_0.Y - (float)num15;
								Class880 expr_56B_cp_0 = class6;
								expr_56B_cp_0.vector2_1.Y = expr_56B_cp_0.vector2_1.Y - (float)num15;
							}
							num14 -= num15;
							vector.Y -= (float)num15;
							vector2.Y -= (float)num15;
						}
						num15 = num13 + num11 - Class115.int_22;
						if (num15 > 0)
						{
							for (int l = 0; l < count; l++)
							{
								Class880 class7 = list[l];
								Class880 expr_5D7_cp_0 = class7;
								expr_5D7_cp_0.vector2_0.X = expr_5D7_cp_0.vector2_0.X - (float)num15;
								Class880 expr_5ED_cp_0 = class7;
								expr_5ED_cp_0.vector2_1.X = expr_5ED_cp_0.vector2_1.X - (float)num15;
							}
							num13 -= num15;
							vector.X -= (float)num15;
							vector2.X -= (float)num15;
						}
						num15 = -num14;
						if (num15 > 0)
						{
							for (int m = 0; m < count; m++)
							{
								Class880 class8 = list[m];
								Class880 expr_651_cp_0 = class8;
								expr_651_cp_0.vector2_0.Y = expr_651_cp_0.vector2_0.Y + (float)num15;
								Class880 expr_667_cp_0 = class8;
								expr_667_cp_0.vector2_1.Y = expr_667_cp_0.vector2_1.Y + (float)num15;
							}
							num14 += num15;
							vector.Y += (float)num15;
							vector2.Y += (float)num15;
						}
						num15 = -num13;
						if (num15 > 0)
						{
							for (int n = 0; n < count; n++)
							{
								Class880 class9 = list[n];
								Class880 expr_6CB_cp_0 = class9;
								expr_6CB_cp_0.vector2_0.X = expr_6CB_cp_0.vector2_0.X + (float)num15;
								Class880 expr_6E1_cp_0 = class9;
								expr_6E1_cp_0.vector2_1.X = expr_6E1_cp_0.vector2_1.X + (float)num15;
							}
							num13 += num15;
							vector.X += (float)num15;
							vector2.X += (float)num15;
						}
					}
					bool flag3 = Class885.smethod_23("SliderTrackOverride", true).get_A() > 0;
					Color color;
					if (Class466.Current.method_5() != PlayModes.Taiko)
					{
						color = this.class297_0.list_2[this.int_1];
					}
					else
					{
						color..ctor(252, 184, 6);
					}
					int int_;
					if (this.Colour != Color.get_Gray() && Class72.class10_0 != null && Class72.class10_0.matchTeamType == MatchTeamTypes.TagCoop && Class72.color_0 != Color.get_TransparentWhite())
					{
						color = Class72.color_0;
						int_ = -2;
					}
					else if (flag3)
					{
						int_ = 0;
					}
					else if (this.Colour == Color.get_Gray() && color != Color.get_Gray())
					{
						color = Color.get_Gray();
						int_ = -1;
					}
					else
					{
						int_ = this.int_1;
					}
					Class731 class10 = Class885.Load("hitcircle", Enum112.flag_6);
					Class731 class11 = Class885.Load("hitcircleoverlay", Enum112.flag_6);
					float num16 = this.class297_0.float_0 * 1f / (float)class10.int_3;
					float num17 = this.class297_0.float_0 * 1f / (float)class11.int_3;
					if (class10.int_3 != 1)
					{
						vector3 *= 2f;
					}
					if (class11.int_3 != 1)
					{
						vector4 *= 2f;
					}
					if (Class115.bool_26)
					{
						bool flag4 = false;
						if (this.renderTarget2D_0 == null || this.renderTarget2D_0.get_IsDisposed() || this.class531_2 == null || this.class531_2.vmethod_6() == null)
						{
							this.renderTarget2D_0 = new RenderTarget2D(Class115.class125_0.GraphicsDevice, Class115.int_22, Class115.int_23 + Class115.int_25, 1, 1);
							flag4 = true;
						}
						Class115.class125_0.GraphicsDevice.SetRenderTarget(0, this.renderTarget2D_0);
						if (flag4 || Class885.smethod_4() == Enum68.const_0 || !Class115.smethod_40())
						{
							Class115.class125_0.GraphicsDevice.Clear(Color.get_TransparentBlack());
						}
						if (base.method_2())
						{
							Class885.interface17_0.Draw(list, null, this.class297_0.HitObjectRadius * Class115.float_1, int_, this.bool_11 ? new Color(229, 44, 44) : new Color(49, 151, 255));
						}
						else
						{
							Class885.interface17_0.Draw(list, null, this.class297_0.HitObjectRadius * Class115.float_1, int_);
						}
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaBlendEnable(true);
						Class115.class125_0.GraphicsDevice.get_RenderState().set_SeparateAlphaBlendEnabled(false);
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaSourceBlend(5);
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaDestinationBlend(6);
						Class115.spriteBatch_0.Begin(1, 0, 0);
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_SeparateAlphaBlendEnabled(true);
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaSourceBlend(2);
						Class115.spriteBatch_0.get_GraphicsDevice().get_RenderState().set_AlphaDestinationBlend(6);
						Class115.spriteBatch_0.Draw(class10.method_2(), vector2, null, color, 0f, vector3, num16, 0, 0.3f);
						Class115.spriteBatch_0.Draw(class11.method_2(), vector2, null, Color.get_White(), 0f, vector4, num17, 0, 0.4f);
						Class115.spriteBatch_0.Draw(class10.method_2(), vector, null, color, 0f, vector3, num16, 0, 0.5f);
						Class115.spriteBatch_0.Draw(class11.method_2(), vector, null, Color.get_White(), 0f, vector4, num17, 0, 0.6f);
						Class115.spriteBatch_0.End();
						Class115.class125_0.GraphicsDevice.ResolveRenderTarget(0);
						this.class531_2.vmethod_7(new Class731(this.renderTarget2D_0.GetTexture()));
						this.class531_2.vector2_1 = new Vector2((float)num6, (float)num7);
						Class115.class125_0.GraphicsDevice.SetRenderTarget(0, null);
						this.class531_2.int_2 = num13;
						this.class531_2.int_3 = num14;
						this.class531_2.int_4 = Math.Min(Class115.int_22, num11);
						this.class531_2.int_1 = Math.Min(Class115.int_23 + Class115.int_25, num12);
						return;
					}
					int num18 = Math.Min(Class115.int_22, num9);
					int num19 = Math.Min(Class115.int_23, num10);
					if (BaseGLControl.uint_0 == 3553u)
					{
						num18 = Class748.smethod_0(num18);
						num19 = Class748.smethod_0(num19);
					}
					BaseGLControl.rectangle_0 = new Rectangle(num13, num14 + num19, num13 + num18, -num19);
					BaseGLControl.smethod_1(false);
					Gl.glClear(16384u);
					Gl.glClear(256u);
					if (base.method_2())
					{
						Class885.interface17_0.Draw(list, null, this.class297_0.HitObjectRadius * Class115.float_1, int_, this.bool_11 ? new Color(229, 44, 44) : new Color(49, 151, 255));
					}
					else
					{
						Class885.interface17_0.Draw(list, null, this.class297_0.HitObjectRadius * Class115.float_1, int_);
					}
					Vector2 vector5;
					vector5..ctor(num16, num16);
					Vector2 vector6;
					vector6..ctor(num17, num17);
					Gl.glColorMask(255, 255, 255, 0);
					BaseGLControl.smethod_5(770u, 771u);
					class10.class748_0.Draw(vector2, vector3, color, vector5, 0f, new Rectangle?(new Rectangle(0, 0, class10.int_0, class10.int_1)));
					class11.class748_0.Draw(vector2, vector4, Color.get_White(), vector6, 0f, new Rectangle?(new Rectangle(0, 0, class11.int_0, class11.int_1)));
					class10.class748_0.Draw(vector, vector3, color, vector5, 0f, new Rectangle?(new Rectangle(0, 0, class10.int_0, class10.int_1)));
					class11.class748_0.Draw(vector, vector4, Color.get_White(), vector6, 0f, new Rectangle?(new Rectangle(0, 0, class11.int_0, class11.int_1)));
					Gl.glColorMask(0, 0, 0, 255);
					BaseGLControl.smethod_5(1u, 771u);
					class10.class748_0.Draw(vector2, vector3, color, vector5, 0f, new Rectangle?(new Rectangle(0, 0, class10.int_0, class10.int_1)));
					class11.class748_0.Draw(vector2, vector4, Color.get_White(), vector6, 0f, new Rectangle?(new Rectangle(0, 0, class11.int_0, class11.int_1)));
					class10.class748_0.Draw(vector, vector3, color, vector5, 0f, new Rectangle?(new Rectangle(0, 0, class10.int_0, class10.int_1)));
					class11.class748_0.Draw(vector, vector4, Color.get_White(), vector6, 0f, new Rectangle?(new Rectangle(0, 0, class11.int_0, class11.int_1)));
					Gl.glColorMask(255, 255, 255, 255);
					int[] array = new int[1];
					Gl.glGenTextures(1, array);
					int num20 = array[0];
					BaseGLControl.smethod_3(num20);
					Gl.glTexParameteri(BaseGLControl.uint_0, 10241u, 9729);
					Gl.glTexParameteri(BaseGLControl.uint_0, 10240u, 9729);
					Gl.glCopyTexImage2D(BaseGLControl.uint_0, 0, 6408u, 0, 0, num18, num19, 0);
					Class748 class12 = new Class748(num18, num19);
					class12.method_2(num20);
					this.class531_2.vmethod_7(new Class731(null, class12, num18, num19));
					this.class531_2.vector2_1 = new Vector2((float)num6, (float)num7);
					BaseGLControl.smethod_1(true);
					return;
				}
			}
			else
			{
				this.method_10();
			}
		}

		// Token: 0x06002268 RID: 8808
		// RVA: 0x000CD954 File Offset: 0x000CBB54
		internal void method_10()
		{
			if (this.class531_2 != null && this.class531_2.vmethod_6() != null)
			{
				this.class531_2.vmethod_6().Dispose();
				this.class531_2.vmethod_7(null);
			}
			this.int_6 = 0;
			this.float_0 = 0f;
		}

		// Token: 0x06002269 RID: 8809
		// RVA: 0x0001B93E File Offset: 0x00019B3E
		internal bool method_11()
		{
			return this.bool_11;
		}

		// Token: 0x0600226A RID: 8810
		// RVA: 0x0001B946 File Offset: 0x00019B46
		internal void method_12(bool bool_14)
		{
			if (bool_14 == this.bool_11)
			{
				return;
			}
			this.bool_11 = bool_14;
			if (this.class531_2 != null)
			{
				this.class531_2.Dispose();
			}
		}

		// Token: 0x0600226F RID: 8815
		// RVA: 0x0001B976 File Offset: 0x00019B76
		internal void method_13(int int_12, bool bool_14)
		{
			this.class306_0.vmethod_4(int_12);
			this.StartTime = int_12;
			if (bool_14)
			{
				this.vmethod_24(true);
				return;
			}
			this.EndTime = int_12;
		}

		// Token: 0x06002271 RID: 8817
		// RVA: 0x000CDDE4 File Offset: 0x000CBFE4
		internal void method_14(int int_12)
		{
			int segmentLength = base.SegmentLength;
			if (segmentLength != 0 && int_12 > this.StartTime && this.list_3.Count >= 2)
			{
				int num = 1;
				int i = this.StartTime + segmentLength;
				while (i < int_12)
				{
					i += segmentLength;
					num++;
				}
				if (this.SegmentCount != num)
				{
					this.SegmentCount = num;
					this.vmethod_24(true);
				}
				this.method_27();
				return;
			}
		}

		// Token: 0x06002272 RID: 8818
		// RVA: 0x000CDE4C File Offset: 0x000CC04C
		internal void method_15(int int_12)
		{
			int segmentLength = base.SegmentLength;
			if (segmentLength != 0 && int_12 > this.StartTime)
			{
				int num = 1;
				int i = this.StartTime + (int)((double)segmentLength * 1.5);
				while (i < int_12)
				{
					i += segmentLength;
					num++;
				}
				if (this.SegmentCount != num)
				{
					this.SegmentCount = num;
					this.vmethod_24(true);
				}
				this.method_28();
				return;
			}
		}

		// Token: 0x06002273 RID: 8819
		// RVA: 0x000CDEB0 File Offset: 0x000CC0B0
		internal void method_16(bool bool_14, bool bool_15)
		{
			this.curveTypes_0 = CurveTypes.PerfectCurve;
			if (this.list_3.Count > 1)
			{
				if (!this.bool_8 && !bool_14 && bool_15)
				{
					this.list_3.RemoveAt(this.list_3.Count - 1);
				}
				else if (this.bool_8 && this.list_4 != null)
				{
					this.bool_8 = false;
					this.bool_9 = true;
				}
				else if (!bool_15 && !this.bool_8 && this.list_3[this.list_3.Count - 1] != this.list_3[this.list_3.Count - 2])
				{
					this.list_3.Add(this.list_3[this.list_3.Count - 1]);
					this.bool_8 = false;
					this.bool_9 = true;
				}
			}
			if (bool_14)
			{
				this.curveTypes_0 = this.curveTypes_1;
			}
			this.bool_6 = !bool_14;
			this.vmethod_24(true);
		}

		// Token: 0x06002274 RID: 8820
		// RVA: 0x000CDFB4 File Offset: 0x000CC1B4
		internal void method_17(Vector2 vector2_4)
		{
			if (!this.bool_6)
			{
				return;
			}
			this.curveTypes_0 = CurveTypes.PerfectCurve;
			if (this.bool_8 && this.list_3[this.list_3.Count - 1] == this.vector2_1)
			{
				this.list_3.RemoveAt(this.list_3.Count - 1);
			}
			this.vector2_1 = vector2_4;
			this.bool_8 = false;
			this.bool_7 = true;
		}

		// Token: 0x06002275 RID: 8821
		// RVA: 0x0001B99D File Offset: 0x00019B9D
		internal int method_18(float float_1)
		{
			return (int)((double)this.StartTime + (double)float_1 / this.double_2 * 1000.0);
		}

		// Token: 0x06002277 RID: 8823
		// RVA: 0x000CE0B4 File Offset: 0x000CC2B4
		internal Vector2 method_19(float float_1)
		{
			if (this.list_4 == null)
			{
				this.vmethod_24(true);
			}
			float num = 0f;
			int num2 = 0;
			foreach (Class880 current in this.list_4)
			{
				if (num >= float_1)
				{
					break;
				}
				num += Vector2.Distance(current.vector2_0, current.vector2_1);
				num2++;
			}
			if (this.list_4.Count == 0)
			{
				return this.Position;
			}
			if (num2 == 0)
			{
				return this.list_4[num2].vector2_0;
			}
			Vector2 vector = (this.list_4[num2 - 1].vector2_1 - this.list_4[num2 - 1].vector2_0) * (1f - Math.Abs(float_1 - num) / Vector2.Distance(this.list_4[num2 - 1].vector2_0, this.list_4[num2 - 1].vector2_1));
			return this.list_4[num2 - 1].vector2_0 + vector;
		}

		// Token: 0x06002278 RID: 8824
		// RVA: 0x000CE1E4 File Offset: 0x000CC3E4
		internal bool method_20()
		{
			Class321.Class504 class = new Class321.Class504();
			class.class321_0 = this;
			if (this.list_4 != null && this.list_5 != null)
			{
				float num = this.class297_0.HitObjectRadius * 1f;
				class.float_0 = this.class297_0.HitObjectRadius * 4f;
				Predicate<double> predicate = null;
				Class321.Class505 class2 = new Class321.Class505();
				class2.class504_0 = class;
				class2.int_0 = 0;
				while (class2.int_0 < this.list_4.Count)
				{
					Vector2 vector = this.list_4[class2.int_0].vector2_1;
					List<double> arg_A2_0 = this.list_5;
					if (predicate == null)
					{
						predicate = new Predicate<double>(class2.method_0);
					}
					int num2 = arg_A2_0.FindLastIndex(predicate);
					int num3 = Math.Max(0, num2);
					int num4 = class2.int_0;
					while (num4 >= num3 && Vector2.Distance(vector, this.list_4[num4].vector2_0) < num)
					{
						num4--;
					}
					if (num4 + 1 == num2)
					{
						return true;
					}
					class2.int_0++;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06002280 RID: 8832
		// RVA: 0x000CE494 File Offset: 0x000CC694
		internal void method_21(bool bool_14, int int_12)
		{
			if (Class331.int_7 <= this.EndTime)
			{
				this.method_23();
			}
			if (bool_14)
			{
				Class340 class = this.class297_0.class296_0.method_39((double)(this.list_7[int_12] + 2));
				SampleSet sampleSet = (this.sampleSet_0 == SampleSet.None) ? class.sampleSet_0 : this.sampleSet_0;
				Class331.smethod_65(new Struct69(this.SoundType, sampleSet, class.enum38_0, class.int_0, (this.sampleSet_1 == SampleSet.None) ? sampleSet : this.sampleSet_1), this.vmethod_14());
				return;
			}
			Struct69 struct69_ = this.method_22(int_12);
			Class297.smethod_5(struct69_);
			Class331.smethod_62(struct69_, this.vmethod_14(), true);
		}

		// Token: 0x06002281 RID: 8833
		// RVA: 0x000CE540 File Offset: 0x000CC740
		internal Struct69 method_22(int int_12)
		{
			Class340 class;
			HitObjectSoundType hitObjectSoundType_;
			SampleSet sampleSet;
			SampleSet sampleSet2;
			if (int_12 == 0)
			{
				class = this.class297_0.class296_0.method_39((double)(this.StartTime + 5));
				if (this.bool_10)
				{
					hitObjectSoundType_ = this.SoundType;
					sampleSet = this.sampleSet_0;
					sampleSet2 = this.sampleSet_1;
				}
				else
				{
					if (this.list_8.Count == 0)
					{
						hitObjectSoundType_ = this.SoundType;
					}
					else
					{
						hitObjectSoundType_ = this.list_8[0];
					}
					if (this.list_9.Count != 0 && (this.class297_0.class296_0.int_6 >= 14 || this.list_9[0] != SampleSet.None))
					{
						sampleSet = this.list_9[0];
					}
					else
					{
						sampleSet = this.sampleSet_0;
					}
					if (this.list_10.Count == 0)
					{
						sampleSet2 = this.sampleSet_1;
					}
					else
					{
						sampleSet2 = this.list_10[0];
					}
				}
			}
			else
			{
				if (int_12 < this.SegmentCount)
				{
					if (int_12 != -1)
					{
						class = this.class297_0.class296_0.method_39((double)(this.list_6[int_12 - 1] + 5));
						goto IL_124;
					}
				}
				class = this.class297_0.class296_0.method_39((double)(this.EndTime + 5));
				IL_124:
				if (this.bool_10)
				{
					hitObjectSoundType_ = this.SoundType;
					sampleSet = this.sampleSet_0;
					sampleSet2 = this.sampleSet_1;
				}
				else
				{
					if (int_12 >= this.list_8.Count)
					{
						hitObjectSoundType_ = this.SoundType;
					}
					else
					{
						hitObjectSoundType_ = this.list_8[int_12];
					}
					if (int_12 >= this.list_9.Count)
					{
						sampleSet = this.sampleSet_0;
					}
					else
					{
						sampleSet = this.list_9[int_12];
					}
					if (int_12 >= this.list_10.Count)
					{
						sampleSet2 = this.sampleSet_1;
					}
					else
					{
						sampleSet2 = this.list_10[int_12];
					}
				}
			}
			if (sampleSet == SampleSet.None)
			{
				sampleSet = class.sampleSet_0;
			}
			if (sampleSet2 == SampleSet.None)
			{
				sampleSet2 = sampleSet;
			}
			return Struct69.smethod_0(hitObjectSoundType_, sampleSet, class.enum38_0, class.int_0, sampleSet2);
		}

		// Token: 0x06002282 RID: 8834
		// RVA: 0x000CE720 File Offset: 0x000CC920
		internal void method_23()
		{
			SampleSet sampleSet_ = SampleSet.None;
			SampleSet sampleSet_2 = SampleSet.None;
			if (this.class297_0.class296_0.int_6 >= 14)
			{
				sampleSet_ = this.sampleSet_0;
				sampleSet_2 = this.sampleSet_1;
			}
			Class331.smethod_63(this.SoundType, sampleSet_, sampleSet_2, Class885.class547_0.bool_6, new float?(this.vmethod_14() * 0.4f));
		}

		// Token: 0x06002284 RID: 8836
		// RVA: 0x000CE77C File Offset: 0x000CC97C
		internal void method_24()
		{
			this.int_9 = Class331.int_7;
			List<Class746> arg_33_0 = this.class538_1.class26_0;
			if (Class321.predicate_4 == null)
			{
				Class321.predicate_4 = new Predicate<Class746>(Class321.smethod_8);
			}
			arg_33_0.RemoveAll(Class321.predicate_4);
			int num;
			if (Class115.osuModes_1 == OsuModes.Edit)
			{
				num = this.StartTime;
			}
			else
			{
				num = Math.Max(Class331.int_7, this.StartTime);
			}
			this.class538_1.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num, Math.Min(this.EndTime, num + 60), Enum70.const_0));
			this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, 0.5f, 1f, num, Math.Min(this.EndTime, num + 180), Enum70.const_1));
			this.class538_1.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime, this.EndTime + 200, Enum70.const_2));
			this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, 1f, 0.8f, this.EndTime, this.EndTime + 200, Enum70.const_1));
			int count = this.list_7.Count;
			int num2 = 200;
			int num3 = (count > 1) ? Math.Min(num2, this.list_7[1] - this.list_7[0]) : num2;
			float float_ = 1.1f - (float)num3 / (float)num2 * 0.1f;
			if (count > 0)
			{
				foreach (int current in this.list_7.GetRange(0, count - 1))
				{
					this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, float_, current, Math.Min(this.EndTime, current + num3), Enum70.const_0));
				}
			}
			List<Class311> arg_203_0 = this.list_2;
			if (Class321.action_4 == null)
			{
				Class321.action_4 = new Action<Class311>(Class321.smethod_9);
			}
			arg_203_0.ForEach(Class321.action_4);
			this.bool_12 = true;
		}

		// Token: 0x06002285 RID: 8837
		// RVA: 0x000CE9A8 File Offset: 0x000CCBA8
		internal void method_25()
		{
			if (!this.bool_12)
			{
				return;
			}
			List<Class746> arg_31_0 = this.class538_1.class26_0;
			if (Class321.predicate_5 == null)
			{
				Class321.predicate_5 = new Predicate<Class746>(Class321.smethod_10);
			}
			arg_31_0.RemoveAll(Class321.predicate_5);
			int num = this.EndTime;
			foreach (int current in this.list_7)
			{
				if (current > Class331.int_7)
				{
					num = current;
					break;
				}
			}
			this.class538_1.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num - 100, num, Enum70.const_0));
			this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, 1f, 2f, num - 100, num, Enum70.const_0));
			if (!this.bool_0)
			{
				List<Class311> arg_F1_0 = this.list_2;
				if (Class321.action_5 == null)
				{
					Class321.action_5 = new Action<Class311>(Class321.smethod_11);
				}
				arg_F1_0.ForEach(Class321.action_5);
			}
			this.bool_12 = false;
		}

		// Token: 0x06002287 RID: 8839
		// RVA: 0x000CEEE8 File Offset: 0x000CD0E8
		internal void method_26()
		{
			if (!this.bool_10)
			{
				return;
			}
			for (int i = 0; i < this.SegmentCount + 1; i++)
			{
				this.list_8.Add(this.SoundType);
				this.list_9.Add(this.sampleSet_0);
				this.list_10.Add(this.sampleSet_1);
			}
			this.bool_10 = false;
		}

		// Token: 0x06002288 RID: 8840
		// RVA: 0x0001BA2C File Offset: 0x00019C2C
		internal void method_27()
		{
			this.bool_10 = true;
			this.sampleSet_0 = SampleSet.None;
			this.sampleSet_1 = SampleSet.None;
			this.list_8.Clear();
			this.list_9.Clear();
			this.list_10.Clear();
		}

		// Token: 0x06002289 RID: 8841
		// RVA: 0x000CEF4C File Offset: 0x000CD14C
		internal void method_28()
		{
			if (this.bool_10)
			{
				return;
			}
			int num = this.method_9().Count - this.list_9.Count;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					this.list_8.Add(this.SoundType);
					this.list_9.Add(this.sampleSet_0);
					this.list_10.Add(this.sampleSet_1);
				}
			}
			else if (num < 0)
			{
				num *= -1;
				for (int j = 0; j < num; j++)
				{
					this.list_8.RemoveAt(this.list_8.Count - 1);
					this.list_9.RemoveAt(this.list_9.Count - 1);
					this.list_10.RemoveAt(this.list_10.Count - 1);
				}
			}
			if (this.sampleSet_0 == SampleSet.None && this.sampleSet_1 == SampleSet.None)
			{
				int k = 0;
				while (k < this.list_9.Count)
				{
					if (this.list_8[k] == this.SoundType && this.list_9[k] == this.sampleSet_0)
					{
						if (this.list_10[k] == this.sampleSet_1)
						{
							k++;
							continue;
						}
					}
					return;
				}
				this.method_27();
				return;
			}
		}

		// Token: 0x0600228A RID: 8842
		// RVA: 0x000CF088 File Offset: 0x000CD288
		internal void method_29(Vector2 vector2_4, int int_12)
		{
			Vector2 vector = this.list_3[int_12];
			if (int_12 < this.list_3.Count - 1 && this.list_3[int_12 + 1] == this.list_3[int_12])
			{
				this.list_3[int_12 + 1] = vector2_4;
			}
			this.list_3[int_12] = vector2_4;
			if (int_12 == 0)
			{
				this.vector2_0 = vector2_4;
				this.Position = vector2_4;
				this.class306_0.vmethod_5(vector2_4, false);
			}
			this.SpatialLength = 0.0;
			this.vmethod_24(true);
			if (this.SpatialLength == 0.0)
			{
				this.list_3[int_12] = vector;
				if (int_12 == 0)
				{
					this.Position = (this.vector2_0 = vector);
					this.class306_0.vmethod_5(vector, false);
				}
				this.SpatialLength = 0.0;
				this.vmethod_24(true);
			}
			if (int_12 >= 0 && this.list_2.Count > 0)
			{
				this.list_2[0].vmethod_3();
			}
		}

		// Token: 0x0600228B RID: 8843
		// RVA: 0x0001BA64 File Offset: 0x00019C64
		internal void method_30(int int_12, Vector2 vector2_4)
		{
			this.list_3.Insert(int_12, vector2_4);
			this.curveTypes_0 = CurveTypes.PerfectCurve;
			this.SpatialLength = 0.0;
			this.vmethod_24(true);
		}

		// Token: 0x0600228D RID: 8845
		// RVA: 0x0001BA90 File Offset: 0x00019C90
		[CompilerGenerated]
		private bool method_31(Class531 class531_3)
		{
			return class531_3.int_0 == this.list_7[this.int_10];
		}

		// Token: 0x0600225B RID: 8795
		// RVA: 0x000CAFE4 File Offset: 0x000C91E4
		internal int method_8()
		{
			return (int)Math.Floor(this.SpatialLength * this.class297_0.class296_0.method_36((double)this.StartTime, true) * (double)this.SegmentCount * 0.01 / this.class297_0.class296_0.DifficultySliderMultiplier + (double)this.StartTime);
		}

		// Token: 0x0600225D RID: 8797
		// RVA: 0x000CB154 File Offset: 0x000C9354
		internal List<Class306> method_9()
		{
			List<Class306> list = new List<Class306>();
			list.Add(this.class306_0);
			this.list_2.ForEach(new Action<Class311>(list.Add));
			return list;
		}

		// Token: 0x06002276 RID: 8822
		// RVA: 0x000CE02C File Offset: 0x000CC22C
		public override Vector2 PositionAtTime(int time)
		{
			if (this.list_4 == null)
			{
				this.vmethod_24(true);
			}
			if (time >= this.StartTime && time <= this.EndTime)
			{
				float num = (float)(time - this.StartTime) / ((float)base.Length / (float)this.SegmentCount);
				if (num % 2f > 1f)
				{
					num = 1f - num % 1f;
				}
				else
				{
					num %= 1f;
				}
				float float_ = (float)(this.SpatialLength * (double)num);
				return this.method_19(float_);
			}
			return base.PositionAtTime(time);
		}

		// Token: 0x0600228C RID: 8844
		// RVA: 0x000CF1A0 File Offset: 0x000CD3A0
		internal void Reverse()
		{
			if (this.curveTypes_0 == CurveTypes.PerfectCurve && this.list_3.Count == 3)
			{
				Vector2 vector2_;
				float num;
				double num2;
				double num3;
				Class778.smethod_8(this.list_3[0], this.list_3[1], this.list_3[2], ref vector2_, ref num, ref num2, ref num3);
				bool flag = num2 > num3;
				for (num3 = Class778.smethod_9(this.vmethod_10(), vector2_); num3 < num2; num3 += 6.2831853071795862)
				{
				}
				if (flag)
				{
					num3 -= 6.2831853071795862;
				}
				Vector2 value = Class778.smethod_10(vector2_, num, num3);
				this.vmethod_5(value, false);
				this.list_3[0] = value;
				this.list_3[1] = Class778.smethod_10(vector2_, num, (num3 + num2) * 0.5);
				this.list_3[2] = Class778.smethod_10(vector2_, num, num2);
			}
			else
			{
				List<Vector2> list = new List<Vector2>(this.list_3);
				list.Reverse();
				if (this.double_1 + 1.0 <= this.SpatialLength || this.double_1 - 1.0 >= this.SpatialLength)
				{
					list[0] = this.vmethod_10();
				}
				this.vmethod_5(list[0], false);
				this.list_3 = list;
			}
			this.vmethod_24(true);
		}

		// Token: 0x0600226C RID: 8812
		// RVA: 0x000CDA74 File Offset: 0x000CBC74
		internal override void Select()
		{
			if (this.class531_2 != null)
			{
				this.class531_2.Dispose();
			}
			if (!this.class306_0.method_2())
			{
				this.class306_0.class531_3.color_0 = Color.get_White();
				this.class306_0.Select();
			}
			if (this.list_2.Count > 0 && !this.list_2[0].method_2())
			{
				this.list_2[0].class531_3.color_0 = Color.get_White();
				this.list_2[0].Select();
			}
		}

		// Token: 0x06002293 RID: 8851
		// RVA: 0x0001BADD File Offset: 0x00019CDD
		[CompilerGenerated]
		private static bool smethod_10(Class746 class746_0)
		{
			return class746_0.transformationType_0 != TransformationType.Movement;
		}

		// Token: 0x06002294 RID: 8852
		// RVA: 0x0001BAF4 File Offset: 0x00019CF4
		[CompilerGenerated]
		private static void smethod_11(Class311 class311_0)
		{
			class311_0.vmethod_7();
		}

		// Token: 0x0600228E RID: 8846
		// RVA: 0x0001BAAB File Offset: 0x00019CAB
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade && class746_0.float_1 == 0f;
		}

		// Token: 0x0600228F RID: 8847
		// RVA: 0x0001BAC5 File Offset: 0x00019CC5
		[CompilerGenerated]
		private static void smethod_6(Class306 class306_1)
		{
			class306_1.method_3(false);
			class306_1.vmethod_3();
		}

		// Token: 0x06002290 RID: 8848
		// RVA: 0x0001BAD4 File Offset: 0x00019CD4
		[CompilerGenerated]
		private static void smethod_7(Class531 class531_3)
		{
			class531_3.enum114_0 = Enum114.const_2;
		}

		// Token: 0x06002291 RID: 8849
		// RVA: 0x0001BADD File Offset: 0x00019CDD
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_0)
		{
			return class746_0.transformationType_0 != TransformationType.Movement;
		}

		// Token: 0x06002292 RID: 8850
		// RVA: 0x0001BAEB File Offset: 0x00019CEB
		[CompilerGenerated]
		private static void smethod_9(Class311 class311_0)
		{
			class311_0.vmethod_8(true);
		}

		// Token: 0x0600226B RID: 8811
		// RVA: 0x000CD9A4 File Offset: 0x000CBBA4
		internal override void vmethod_0(Color color_0)
		{
			if (this.class911_0 != null && color_0 != this.Colour)
			{
				this.class306_0.vmethod_0(color_0);
				foreach (Class311 current in this.list_2)
				{
					current.vmethod_0(color_0);
				}
				this.method_10();
				this.Colour = color_0;
				if ((this.class538_0.vmethod_6().enum112_0 == Enum112.flag_1 || Class885.class547_0.bool_10) && Class341.class606_8)
				{
					this.class538_0.color_0 = color_0;
				}
				base.vmethod_0(color_0);
				this.vmethod_1();
			}
		}

		// Token: 0x06002279 RID: 8825
		// RVA: 0x0001B9BB File Offset: 0x00019BBB
		[CompilerGenerated]
		internal override Vector2 vmethod_10()
		{
			return this.vector2_3;
		}

		// Token: 0x0600227A RID: 8826
		// RVA: 0x0001B9C3 File Offset: 0x00019BC3
		[CompilerGenerated]
		internal override void vmethod_11(Vector2 vector2_4)
		{
			this.vector2_3 = vector2_4;
		}

		// Token: 0x0600227E RID: 8830
		// RVA: 0x0001B9D9 File Offset: 0x00019BD9
		internal override void vmethod_12()
		{
			this.method_21(false, (Class331.int_7 > this.StartTime + base.Length / 2) ? (this.list_8.Count - 1) : 0);
		}

		// Token: 0x06002257 RID: 8791
		// RVA: 0x000CACE4 File Offset: 0x000C8EE4
		internal override List<Class531> vmethod_13()
		{
			return new List<Class531>
			{
				this.class531_2
			};
		}

		// Token: 0x0600227F RID: 8831
		// RVA: 0x0001BA08 File Offset: 0x00019C08
		protected override float vmethod_14()
		{
			return (this.class538_0.vector2_1.X / 512f - 0.5f) * 0.8f;
		}

		// Token: 0x06002286 RID: 8838
		// RVA: 0x000CEAC4 File Offset: 0x000CCCC4
		internal override Enum61 vmethod_17(Vector2 vector2_4)
		{
			if (!this.bool_0 && Class331.int_7 >= this.StartTime)
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = Class800.bool_2 && (Class800.mouseButtons_0 != (MouseButtons.Left | MouseButtons.Right) || Class800.mouseButtons_1 != Class800.mouseButtons_2);
				if (Class800.bool_2)
				{
					if (this.mouseButtons_0 != MouseButtons.None && (Class800.mouseButtons_2 == (MouseButtons.Left | MouseButtons.Right) || !flag3))
					{
						if ((Class800.mouseButtons_2 & this.mouseButtons_0) > MouseButtons.None)
						{
							flag2 = true;
						}
					}
					else
					{
						this.mouseButtons_0 = (Class802.bool_8 ? MouseButtons.Left : (Class802.bool_23 ? MouseButtons.Right : Class800.mouseButtons_2));
						flag2 = true;
					}
				}
				else
				{
					this.mouseButtons_0 = MouseButtons.None;
				}
				if (flag2 | (flag3 | Class62.bool_15))
				{
					Class321.Class506 class = new Class321.Class506();
					float num = this.bool_12 ? (this.class297_0.HitObjectRadius * 2.4f) : this.class297_0.HitObjectRadius;
					class.int_0 = Class331.int_7 - ((!(Class802.interface15_0 is Class568) || Class802.smethod_20()) ? 0 : Class341.class608_16);
					Class746 class2 = this.class538_0.class26_0.Find(new Predicate<Class746>(class.method_0));
					if (class2 == null && class.int_0 > this.class538_0.class26_0[this.class538_0.class26_0.Count - 1].int_1)
					{
						class2 = this.class538_0.class26_0[this.class538_0.class26_0.Count - 1];
					}
					if (Class802.interface15_0 is Class568 && !Class802.smethod_20() && class2 == null && class.int_0 < this.StartTime && Class331.int_7 >= this.StartTime)
					{
						class2 = this.class538_0.class26_0[0];
					}
					if (class2 != null)
					{
						Vector2 vector;
						if (class2.int_1 == class2.int_0)
						{
							vector = class2.vector2_1;
						}
						else
						{
							vector = class2.vector2_0 + (class2.vector2_1 - class2.vector2_0) * (1f - (float)(class2.int_1 - class.int_0) / (float)(class2.int_1 - class2.int_0));
						}
						flag = (Vector2.DistanceSquared(Class115.smethod_58(vector2_4), vector) < num * num);
					}
				}
				if (flag && !this.bool_12)
				{
					this.method_24();
				}
				Enum61 result = Enum61.flag_5;
				int num2 = 0;
				while (num2 < this.list_7.Count && this.list_7[num2] <= Class331.int_7)
				{
					num2++;
				}
				if (num2 < this.int_8 + this.int_11 && Class331.smethod_71())
				{
					bool flag4 = true;
					this.int_8 = 0;
					this.int_11 = 0;
					for (int i = 0; i < num2; i++)
					{
						if (this.bool_13[i])
						{
							this.int_8++;
							flag4 = true;
						}
						else
						{
							this.int_11++;
							flag4 = false;
						}
					}
					if (flag4)
					{
						this.method_24();
					}
					else
					{
						this.method_25();
					}
				}
				else if (this.int_8 + this.int_11 < num2)
				{
					int num3 = this.int_8 + this.int_11;
					if (flag && this.int_9 <= this.list_7[num3])
					{
						this.int_8++;
						this.bool_13[num3] = true;
						if (this.list_7.Count == num2)
						{
							result = Enum61.flag_13;
						}
						else if (num2 % (this.list_7.Count / this.SegmentCount) == 0)
						{
							result = Enum61.flag_12;
						}
						else
						{
							result = Enum61.flag_9;
						}
					}
					else
					{
						this.int_11++;
						this.bool_13[num3] = false;
						if (this.int_8 + this.int_11 == this.list_7.Count)
						{
							result = Enum61.flag_1;
						}
						else
						{
							result = Enum61.flag_2;
						}
					}
				}
				if (!flag && this.bool_12 && this.int_8 + this.int_11 < this.list_7.Count)
				{
					this.method_25();
				}
				return result;
			}
			return Enum61.flag_5;
		}

		// Token: 0x06002283 RID: 8835
		// RVA: 0x0001B80D File Offset: 0x00019A0D
		internal override void vmethod_18()
		{
			Class331.smethod_94();
		}

		// Token: 0x06002256 RID: 8790
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_12)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600227D RID: 8829
		// RVA: 0x000CE358 File Offset: 0x000CC558
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			this.vmethod_18();
			if (this.class306_0.enum61_0 > Enum61.flag_5)
			{
				this.int_8++;
			}
			if (this.bool_12)
			{
				Class311 class = new Class311(this.class297_0, (this.EndPosition == this.Position) ? this.vmethod_10() : this.Position, this.EndTime, this.EndTime, false, 0f, this);
				class.vmethod_0(this.class306_0.class531_1.color_0);
				List<Class531> arg_AD_0 = class.list_1;
				if (Class321.action_3 == null)
				{
					Class321.action_3 = new Action<Class531>(Class321.smethod_7);
				}
				arg_AD_0.ForEach(Class321.action_3);
				class.vmethod_8(true);
				this.class911_0.Add<Class531>(class.list_1);
			}
			double num = (double)this.int_8 / (double)(this.list_7.Count + 1);
			if (num > 0.0)
			{
				this.vmethod_12();
			}
			if (num == 1.0)
			{
				return Enum61.flag_16;
			}
			if (num >= 0.5)
			{
				return Enum61.flag_15;
			}
			if (num > 0.0)
			{
				return Enum61.flag_14;
			}
			return Enum61.flag_3;
		}

		// Token: 0x0600225A RID: 8794
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_21()
		{
		}

		// Token: 0x0600225C RID: 8796
		// RVA: 0x000CB044 File Offset: 0x000C9244
		protected virtual void vmethod_23()
		{
			this.class306_0 = new Class309(this.class297_0, new Vector2((float)((int)this.Position.X), (float)((int)this.Position.Y)), this.StartTime, this.NewCombo, this.bool_10 ? this.SoundType : this.list_8[0], this.int_0);
			Class746 item = new Class746(TransformationType.Fade, 0f, 0f, this.StartTime - 10, this.StartTime - 10, Enum70.const_0);
			this.class306_0.class531_1.class26_0.RemoveAt(0);
			this.class306_0.class531_1.class26_0.Insert(0, item);
			if (!this.class297_0.method_32() || (this.class297_0.class296_0.overlayPosition_0 == OverlayPosition.NoChange && Class885.smethod_24()))
			{
				this.class306_0.class538_0.class26_0.RemoveAt(0);
				this.class306_0.class538_0.class26_0.Insert(0, item);
			}
		}

		// Token: 0x06002266 RID: 8806
		// RVA: 0x000CB53C File Offset: 0x000C973C
		internal virtual void vmethod_24(bool bool_14)
		{
			bool_14 |= (this.SpatialLength == 0.0 || this.list_4 == null || this.bool_7);
			if (!bool_14)
			{
				return;
			}
			this.method_10();
			this.double_2 = this.class297_0.SliderVelocityAt(this.StartTime);
			List<Class880> list = new List<Class880>();
			if (this.bool_7)
			{
				if (this.list_3.Contains(this.vector2_1))
				{
					this.bool_7 = false;
				}
				else
				{
					this.list_3.Add(this.vector2_1);
				}
			}
			int num = 8;
			switch (this.curveTypes_0)
			{
			case CurveTypes.Catmull:
				for (int i = 0; i < this.list_3.Count - 1; i++)
				{
					Vector2 vector = (i - 1 >= 0) ? this.list_3[i - 1] : this.list_3[i];
					Vector2 vector2 = this.list_3[i];
					Vector2 vector3 = (i + 1 < this.list_3.Count) ? this.list_3[i + 1] : (vector2 + (vector2 - vector));
					Vector2 vector4 = (i + 2 < this.list_3.Count) ? this.list_3[i + 2] : (vector3 + (vector3 - vector2));
					for (int j = 0; j < 50; j++)
					{
						list.Add(new Class880(Vector2.CatmullRom(vector, vector2, vector3, vector4, (float)j / 50f), Vector2.CatmullRom(vector, vector2, vector3, vector4, (float)(j + 1) / 50f)));
					}
					list[list.Count - 1].bool_0 = true;
				}
				this.curveTypes_1 = CurveTypes.Catmull;
				goto IL_8D0;
			case CurveTypes.Bezier:
				break;
			case CurveTypes.Linear:
				goto IL_7DF;
			case CurveTypes.PerfectCurve:
				if (this.list_3.Count < 3)
				{
					goto IL_7DF;
				}
				if (this.list_3.Count <= 3)
				{
					Vector2 vector5 = this.list_3[0];
					Vector2 vector6 = this.list_3[1];
					Vector2 vector7 = this.list_3[2];
					if ((vector6.X - vector5.X) * (vector7.Y - vector5.Y) - (vector7.X - vector5.X) * (vector6.Y - vector5.Y) != 0f)
					{
						Vector2 vector2_;
						float num2;
						double num3;
						double num4;
						Class778.smethod_8(vector5, vector6, vector7, ref vector2_, ref num2, ref num3, ref num4);
						if (Class115.osuModes_1 == OsuModes.Edit)
						{
							Class609 class = new Class609(new Vector2[]
							{
								Class778.smethod_10(vector2_, num2, num3),
								Class778.smethod_10(vector2_, num2, num4)
							});
							double num5 = Math.Min(num3, num4);
							double num6 = Math.Max(num3, num4);
							int num7 = (int)(num5 * 2.0 / 3.1415926535897931 + 1.0);
							while ((double)((float)num7 * 0.5f) * 3.1415926535897931 < num6)
							{
								class.Add(Class778.smethod_10(vector2_, num2, (double)((float)num7 * 0.5f) * 3.1415926535897931));
								num7++;
							}
							if ((this.bool_7 && (class.method_0().Value > 512f || class.method_1().Value > 384f)) || class.method_0().Value > 640f || class.method_1().Value > 640f)
							{
								break;
							}
						}
						this.double_1 = Math.Abs((num4 - num3) * (double)num2);
						int num8 = (int)(this.double_1 * 0.125);
						Vector2 vector8 = vector5;
						for (int k = 1; k < num8; k++)
						{
							double num9 = (double)k / (double)num8;
							double double_ = num4 * num9 + num3 * (1.0 - num9);
							Vector2 vector9 = Class778.smethod_10(vector2_, num2, double_);
							list.Add(new Class880(vector8, vector9));
							vector8 = vector9;
						}
						list.Add(new Class880(vector8, vector7));
						this.curveTypes_1 = CurveTypes.PerfectCurve;
						goto IL_8D0;
					}
					goto IL_7DF;
				}
				break;
			default:
				goto IL_8D0;
			}
			int num10 = 0;
			for (int l = 0; l < this.list_3.Count; l++)
			{
				if (this.class297_0.class296_0.int_6 > 8)
				{
					bool flag;
					if ((flag = (l < this.list_3.Count - 2 && this.list_3[l] == this.list_3[l + 1])) || l == this.list_3.Count - 1)
					{
						List<Vector2> range = this.list_3.GetRange(num10, l - num10 + 1);
						if (range.Count == 2)
						{
							Class880 class2 = new Class880(range[0], range[1]);
							int num11 = Math.Max((int)class2.method_0() / num, 1);
							for (int m = 0; m < num11; m++)
							{
								list.Add(new Class880(class2.vector2_0 + (class2.vector2_1 - class2.vector2_0) * ((float)m / (float)num11), class2.vector2_0 + (class2.vector2_1 - class2.vector2_0) * ((float)(m + 1) / (float)num11))
								{
									bool_1 = true
								});
							}
						}
						else if (this.class297_0.class296_0.int_6 < 10)
						{
							List<Vector2> list2 = Class778.smethod_4(range);
							for (int n = 1; n < list2.Count; n++)
							{
								list.Add(new Class880(list2[n - 1], list2[n]));
							}
						}
						else
						{
							List<Vector2> list3 = Class778.smethod_3(range);
							for (int num12 = 1; num12 < list3.Count; num12++)
							{
								list.Add(new Class880(list3[num12 - 1], list3[num12]));
							}
						}
						list[list.Count - 1].bool_0 = true;
						if (flag)
						{
							l++;
						}
						num10 = l;
					}
				}
				else if (this.class297_0.class296_0.int_6 > 6)
				{
					bool flag2;
					if ((flag2 = (l < this.list_3.Count - 2 && this.list_3[l] == this.list_3[l + 1])) || l == this.list_3.Count - 1)
					{
						List<Vector2> range2 = this.list_3.GetRange(num10, l - num10 + 1);
						List<Vector2> list4 = Class778.smethod_3(range2);
						for (int num13 = 1; num13 < list4.Count; num13++)
						{
							list.Add(new Class880(list4[num13 - 1], list4[num13]));
						}
						list[list.Count - 1].bool_0 = true;
						if (flag2)
						{
							l++;
						}
						num10 = l;
					}
				}
				else if ((l > 0 && this.list_3[l] == this.list_3[l - 1]) || l == this.list_3.Count - 1)
				{
					List<Vector2> range3 = this.list_3.GetRange(num10, l - num10 + 1);
					List<Vector2> list5 = Class778.smethod_3(range3);
					for (int num14 = 1; num14 < list5.Count; num14++)
					{
						list.Add(new Class880(list5[num14 - 1], list5[num14]));
					}
					list[list.Count - 1].bool_0 = true;
					num10 = l;
				}
			}
			this.curveTypes_1 = CurveTypes.Bezier;
			goto IL_8D0;
			IL_7DF:
			for (int num15 = 1; num15 < this.list_3.Count; num15++)
			{
				Class880 class3 = new Class880(this.list_3[num15 - 1], this.list_3[num15]);
				int num16 = Math.Max((int)class3.method_0() / 10, 1);
				for (int num17 = 0; num17 < num16; num17++)
				{
					list.Add(new Class880(class3.vector2_0 + (class3.vector2_1 - class3.vector2_0) * ((float)num17 / (float)num16), class3.vector2_0 + (class3.vector2_1 - class3.vector2_0) * ((float)(num17 + 1) / (float)num16))
					{
						bool_1 = true
					});
				}
				list[list.Count - 1].bool_0 = true;
			}
			this.curveTypes_1 = CurveTypes.Linear;
			IL_8D0:
			double num18 = 0.0;
			int count = list.Count;
			for (int num19 = 0; num19 < count; num19++)
			{
				num18 += (double)list[num19].method_0();
			}
			this.double_1 = num18;
			int num20 = 0;
			double num21 = (this.class297_0.class296_0.int_6 < 8) ? this.class297_0.SliderScoringPointDistance : (this.class297_0.SliderScoringPointDistance / (double)this.class297_0.class296_0.method_37((double)this.StartTime));
			if (num18 > 0.0)
			{
				if (this.bool_7 || this.SpatialLength == 0.0)
				{
					if (Editor.editor_0 != null && Editor.smethod_1())
					{
						double num22 = num21 * this.class297_0.class296_0.DifficultySliderTickRate / (double)Editor.editor_0.int_6;
						num20 = (int)Math.Max(0.0, (num18 + 1.0) / num22);
						this.SpatialLength = (double)num20 * num22;
					}
					else
					{
						num20 = (int)(num18 / num21);
						this.SpatialLength = num18;
					}
				}
				if (num21 > this.SpatialLength)
				{
					num21 = this.SpatialLength;
				}
				if (this.bool_9)
				{
					this.int_7 = num20;
					this.bool_9 = false;
				}
				double num23 = num18 - this.SpatialLength;
				while (list.Count > 0)
				{
					Class880 class4 = list[list.Count - 1];
					float num24 = Vector2.Distance(class4.vector2_0, class4.vector2_1);
					if ((double)num24 <= num23 + 0.0001)
					{
						list.Remove(class4);
						num23 -= (double)num24;
					}
					else
					{
						if (class4.vector2_1 != class4.vector2_0)
						{
							class4.vector2_1 = class4.vector2_0 + Vector2.Normalize(class4.vector2_1 - class4.vector2_0) * (class4.method_0() - (float)num23);
							break;
						}
						break;
					}
				}
			}
			if (this.bool_7)
			{
				if (num20 == this.int_7 && num20 != 0)
				{
					this.list_3.RemoveAt(this.list_3.Count - 1);
					this.bool_8 = false;
				}
				else
				{
					this.bool_8 = true;
				}
				this.bool_7 = false;
			}
			count = list.Count;
			if (count > 0)
			{
				this.list_4 = list;
				if (this.list_5 == null)
				{
					this.list_5 = new List<double>(count);
				}
				else
				{
					this.list_5.Clear();
				}
				num18 = 0.0;
				foreach (Class880 current in list)
				{
					num18 += (double)current.method_0();
					this.list_5.Add(num18);
				}
			}
			if (this.class911_0 != null)
			{
				if (this.list_1.Count > 0)
				{
					this.class911_0.method_13<Class531>(this.list_1);
				}
				this.class538_1.class26_0.Clear();
				this.class538_0.class26_0.Clear();
				if (this.class531_0 != null)
				{
					this.class531_0.class26_0.Clear();
				}
				if (this.class531_1 != null)
				{
					this.class531_1.class26_0.Clear();
				}
				this.list_7.Clear();
				this.list_2.Clear();
			}
			if (count < 1)
			{
				return;
			}
			if (this.class911_0 != null)
			{
				this.list_1.Clear();
				this.list_0.Clear();
				for (int num25 = 0; num25 < this.class306_0.list_1.Count; num25++)
				{
					Class531 class5 = this.class306_0.list_1[num25];
					class5.object_0 = this;
					this.list_1.Add(class5);
				}
				this.list_0.AddRange(this.class306_0.list_0);
				this.list_1.Add(this.class538_1);
				if (this.class531_0 != null)
				{
					this.list_1.Add(this.class531_0);
				}
				if (this.class531_1 != null)
				{
					this.list_1.Add(this.class531_1);
				}
				this.list_1.Add(this.class538_0);
				if (list.Count > 2)
				{
					float num26 = (float)Math.Atan2((double)(list[0].vector2_0.Y - list[0].vector2_1.Y), (double)(list[0].vector2_0.X - list[0].vector2_1.X));
					this.class538_0.method_43((double)num26 >= -1.5707963267948966 && (double)num26 <= 1.5707963267948966);
				}
			}
			bool flag3 = false;
			bool flag4 = true;
			double num27 = 0.0;
			double num28 = (double)this.StartTime;
			Vector2 vector10 = default(Vector2);
			Vector2 vector11 = default(Vector2);
			double num29 = 0.0;
			this.vmethod_11(list[count - 1].vector2_1);
			for (int num30 = 0; num30 < this.SegmentCount; num30++)
			{
				int num31 = (int)num28;
				bool flag5 = false;
				List<Class531> list6 = new List<Class531>();
				for (int num32 = 0; num32 < count; num32++)
				{
					Class880 class6 = list[num32];
					if (flag3)
					{
						vector11 = class6.vector2_1;
						vector10 = class6.vector2_0;
					}
					else
					{
						vector11 = class6.vector2_0;
						vector10 = class6.vector2_1;
					}
					float num33 = Vector2.Distance(class6.vector2_0, class6.vector2_1);
					double num34 = (double)(1000f * num33) / this.double_2;
					if (this.class911_0 != null)
					{
						Class746 item = new Class746(vector11, vector10, (int)num28, (int)(num28 + num34), Enum70.const_0);
						this.class538_1.class26_0.Add(item);
						this.class538_0.class26_0.Add(item);
						if (this.class531_0 != null)
						{
							this.class531_0.class26_0.Add(item);
						}
						if (this.class531_1 != null)
						{
							this.class531_1.class26_0.Add(item);
						}
					}
					num28 += num34;
					num29 += (double)num33;
					if (num29 >= num21 || (num32 == count - 1 && !flag5))
					{
						num27 += Math.Min(num21, num29);
						int num35 = this.method_18((float)num27);
						if (num32 == count - 1)
						{
							num27 -= num21 - num29;
							num29 = num21 - num29;
							flag5 = true;
						}
						else
						{
							num29 -= Math.Min(num21, num29);
						}
						if (this.class911_0 != null && num32 != count - 1)
						{
							float num36 = 1f - (float)(num29 / (double)Vector2.Distance(vector11, vector10));
							Vector2 vector12 = vector11 + (vector10 - vector11) * num36;
							Class531 class7 = new Class531(Class885.Load("sliderscorepoint", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, vector12, Class911.smethod_4((float)(this.StartTime - 5)), false, Color.get_White(), this);
							if (class7.vmethod_6().enum112_0 == Enum112.flag_1)
							{
								class7.bool_7 = true;
							}
							if (flag4)
							{
								int num37 = (num35 - this.StartTime) / 2 + this.StartTime - this.class297_0.int_10;
								int num38 = num37 + 150;
								class7.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num37, num38, Enum70.const_0));
								class7.class26_0.Add(new Class746(TransformationType.Scale, 0.5f, 1.2f, num37, num38, Enum70.const_0));
								class7.class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 1f, num38, num38 + 150, Enum70.const_1));
							}
							else
							{
								int num39 = num31 + (num35 - num31) / 2;
								class7.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num39 - 200, num39, Enum70.const_0));
								class7.class26_0.Add(new Class746(TransformationType.Scale, 0.5f, 1.2f, num39 - 200, num39 - 50, Enum70.const_0));
								class7.class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 1f, num39 - 50, num39 + 150, Enum70.const_1));
							}
							float num40 = this.class297_0.HitObjectRadius * this.class297_0.HitObjectRadius;
							if (Class115.osuModes_1 != OsuModes.Play || (Vector2.DistanceSquared(vector12, this.vmethod_10()) >= num40 && Vector2.DistanceSquared(vector12, this.Position) >= num40))
							{
								this.list_1.Add(class7);
								list6.Add(class7);
							}
							class7.int_0 = num35;
						}
						this.list_7.Add(num35);
					}
				}
				if (this.class911_0 != null)
				{
					foreach (Class531 current2 in list6)
					{
						current2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, (int)num28, (int)num28, Enum70.const_0));
					}
				}
				float num41 = (float)Math.Atan2((double)(vector11.Y - vector10.Y), (double)(vector11.X - vector10.X));
				flag3 = !flag3;
				list.Reverse();
				if (this.class911_0 != null)
				{
					Class311 class8 = new Class311(this.class297_0, vector10, (int)num28, flag4 ? (this.StartTime - this.class297_0.int_10) : (num31 - (int)(num28 - (double)num31)), num30 < this.SegmentCount - 1, num41, this);
					class8.vmethod_0(this.class306_0.class531_1.color_0);
					this.list_2.Add(class8);
					if (flag4)
					{
						this.list_0.AddRange(class8.list_0);
					}
					this.list_1.AddRange(class8.list_1);
				}
				flag4 = false;
			}
			if (flag3)
			{
				list.Reverse();
			}
			if (base.method_2() && this.list_2.Count > 0)
			{
				this.list_2[0].Select();
			}
			this.EndPosition = vector10;
			this.EndTime = (int)num28;
			if (this.class911_0 != null)
			{
				this.class531_2.float_0 = Class911.smethod_4((float)(this.EndTime + 10));
				this.class531_2.class26_0.Clear();
				this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.97f, this.StartTime - this.class297_0.PreEmpt, this.StartTime - this.class297_0.PreEmpt + Class297.int_2, Enum70.const_0));
				this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0.97f, 0f, this.EndTime, this.EndTime + Class297.int_3, Enum70.const_0));
				this.list_1.Add(this.class531_2);
				this.list_0.Add(this.class531_2);
			}
			if (this.list_7.Count > 0)
			{
				this.list_7[this.list_7.Count - 1] = Math.Max(this.StartTime + base.Length / 2, this.list_7[this.list_7.Count - 1] - 36);
			}
			this.bool_13 = new bool[this.list_7.Count];
			this.list_6.Clear();
			for (int num42 = 0; num42 < this.list_7.Count - 1; num42++)
			{
				if (this.list_7.Count / this.SegmentCount > 0 && (num42 + 1) % (this.list_7.Count / this.SegmentCount) == 0)
				{
					this.list_6.Add(this.list_7[num42]);
				}
			}
			if (this.bool_12)
			{
				this.method_25();
			}
			if (this.class911_0 != null)
			{
				this.class911_0.Add<Class531>(this.list_1);
			}
			this.vmethod_1();
		}

		// Token: 0x0600227B RID: 8827
		// RVA: 0x0001B9CC File Offset: 0x00019BCC
		internal virtual bool vmethod_25()
		{
			return this.class306_0.bool_0;
		}

		// Token: 0x0600227C RID: 8828
		// RVA: 0x000CE308 File Offset: 0x000CC508
		internal virtual Enum61 vmethod_26()
		{
			if (Class802.bool_8 || Class802.bool_23)
			{
				this.mouseButtons_0 = (Class802.bool_8 ? MouseButtons.Left : (Class802.bool_23 ? MouseButtons.Right : Class800.mouseButtons_2));
			}
			return this.class306_0.vmethod_2();
		}

		// Token: 0x0600226D RID: 8813
		// RVA: 0x000CDB10 File Offset: 0x000CBD10
		internal override void vmethod_3()
		{
			this.bool_11 = false;
			if (this.class531_2 != null)
			{
				this.class531_2.Dispose();
			}
			List<Class306> arg_3D_0 = this.method_9();
			if (Class321.action_2 == null)
			{
				Class321.action_2 = new Action<Class306>(Class321.smethod_6);
			}
			arg_3D_0.ForEach(Class321.action_2);
		}

		// Token: 0x0600226E RID: 8814
		// RVA: 0x0001B96C File Offset: 0x00019B6C
		internal override void vmethod_4(int int_12)
		{
			this.method_13(int_12, true);
		}

		// Token: 0x06002270 RID: 8816
		// RVA: 0x000CDB60 File Offset: 0x000CBD60
		internal override void vmethod_5(Vector2 vector2_4, bool bool_14)
		{
			Class321.Class503 class = new Class321.Class503();
			class.vector2_0 = vector2_4 - this.Position;
			base.vmethod_5(vector2_4, bool_14);
			for (int i = 0; i < this.list_3.Count; i++)
			{
				List<Vector2> list;
				int index;
				(list = this.list_3)[index = i] = list[index] + class.vector2_0;
			}
			if (this.list_4 != null)
			{
				for (int j = 0; j < this.list_4.Count; j++)
				{
					this.list_4[j].vector2_0 += class.vector2_0;
					this.list_4[j].vector2_1 += class.vector2_0;
				}
			}
			foreach (Class531 current in this.list_1)
			{
				if (current.enum115_0 == Enum115.const_0)
				{
					current.vector2_0 += class.vector2_0;
					current.vector2_1 += class.vector2_0;
				}
				else
				{
					current.vector2_0 += class.vector2_0 * Class115.float_4 * Class115.smethod_48();
					current.vector2_1 += class.vector2_0 * Class115.float_4 * Class115.smethod_48();
				}
			}
			if (this.class538_0 != null)
			{
				foreach (Class746 current2 in this.class538_0.class26_0)
				{
					if (current2.transformationType_0 == TransformationType.Movement)
					{
						current2.vector2_0 += class.vector2_0;
						current2.vector2_1 += class.vector2_0;
					}
				}
			}
			this.class306_0.vmethod_5(vector2_4, false);
			this.list_2.ForEach(new Action<Class311>(class.method_0));
			this.vmethod_11(this.vmethod_10() + class.vector2_0);
			this.EndPosition += class.vector2_0;
		}

		// Token: 0x06002265 RID: 8805
		// RVA: 0x000CB2F8 File Offset: 0x000C94F8
		internal override void vmethod_6()
		{
			Predicate<Class531> predicate = null;
			base.vmethod_6();
			if (Class115.osuModes_1 == OsuModes.Edit || this.bool_7)
			{
				this.vmethod_24(false);
			}
			if (this.list_7.Count > 0)
			{
				int num = this.list_7.Count / this.SegmentCount;
				this.class538_0.vmethod_5((this.int_10 + num + 1) / num % 2 == 0);
				this.class538_0.method_45((this.int_10 + num + 1) / num % 2 == 0 && Class885.class547_0.bool_3);
				this.class538_0.method_53(Math.Max(150.0 / this.double_2 * 16.666666666666668, 16.666666666666668));
			}
			int num2 = -1;
			int num3 = 0;
			while (num3 < this.list_7.Count - 1 && this.list_7[num3] <= Class331.int_7)
			{
				num2 = num3;
				num3++;
			}
			if (Class331.int_7 >= this.StartTime && Class331.int_7 <= this.EndTime && Class331.enum100_0 == Enum100.const_1)
			{
				if (!this.bool_12)
				{
					this.vmethod_18();
					this.int_10 = num2;
					return;
				}
				this.method_23();
				if (num2 > this.int_10)
				{
					this.int_10 = num2;
					if ((this.int_10 + 1) % (this.list_7.Count / this.SegmentCount) > 0)
					{
						this.method_21(true, this.int_10);
					}
					else
					{
						this.method_21(false, (this.int_10 + 1) / (this.list_7.Count / this.SegmentCount));
					}
					List<Class531> arg_1A2_0 = this.list_1;
					if (predicate == null)
					{
						predicate = new Predicate<Class531>(this.method_31);
					}
					Class531 class = arg_1A2_0.Find(predicate);
					if (class != null && class.class26_0.Count > 1)
					{
						List<Class746> arg_1DC_0 = class.class26_0;
						if (Class321.predicate_3 == null)
						{
							Class321.predicate_3 = new Predicate<Class746>(Class321.smethod_5);
						}
						Class746 class2 = arg_1DC_0.Find(Class321.predicate_3);
						if (class2 != null)
						{
							class2.int_0 = this.list_7[this.int_10];
							class2.int_1 = this.list_7[this.int_10];
						}
					}
					this.int_10 = num2;
					return;
				}
			}
			else
			{
				this.int_10 = -1;
			}
		}

		// Token: 0x06002258 RID: 8792
		// RVA: 0x0001B8A8 File Offset: 0x00019AA8
		internal override void vmethod_7()
		{
			base.vmethod_7();
			this.vmethod_18();
			this.class306_0.vmethod_7();
			this.int_10 = 0;
		}

		// Token: 0x06002264 RID: 8804
		// RVA: 0x0001B90B File Offset: 0x00019B0B
		internal override bool vmethod_9()
		{
			return Class331.int_7 >= this.StartTime - this.class297_0.PreEmpt && Class331.int_7 <= this.EndTime + Class297.int_3;
		}
	}
}
