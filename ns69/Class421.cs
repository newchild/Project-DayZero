using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns22;
using ns23;
using ns24;
using ns26;
using ns29;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns82;
using ns89;
using osu;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns69
{
	// Token: 0x020003CB RID: 971
	internal sealed class Class421 : IDisposable, IEnumerable, IEnumerable<Class421>
	{
		// Token: 0x020003CD RID: 973
		[CompilerGenerated]
		private sealed class Class423
		{
			// Token: 0x040018AF RID: 6319
			public Class421 class421_0;

			// Token: 0x040018B0 RID: 6320
			public float float_0;

			// Token: 0x06001F01 RID: 7937
			// RVA: 0x000196EE File Offset: 0x000178EE
			public void method_0(Class530 class530_0)
			{
				class530_0.vector2_1.Y = class530_0.vector2_1.Y - (this.class421_0.float_2 - this.float_0);
			}

			// Token: 0x06001F02 RID: 7938
			// RVA: 0x000196EE File Offset: 0x000178EE
			public void method_1(Class530 class530_0)
			{
				class530_0.vector2_1.Y = class530_0.vector2_1.Y - (this.class421_0.float_2 - this.float_0);
			}

			// Token: 0x06001F03 RID: 7939
			// RVA: 0x000196EE File Offset: 0x000178EE
			public void method_2(Class530 class530_0)
			{
				class530_0.vector2_1.Y = class530_0.vector2_1.Y - (this.class421_0.float_2 - this.float_0);
			}
		}

		// Token: 0x020003CE RID: 974
		[CompilerGenerated]
		private sealed class Class424
		{
			// Token: 0x040018B1 RID: 6321
			public Class421 class421_0;

			// Token: 0x040018B2 RID: 6322
			public float float_0;

			// Token: 0x06001F05 RID: 7941
			// RVA: 0x00019714 File Offset: 0x00017914
			public void method_0(Class530 class530_0)
			{
				class530_0.vector2_1.X = class530_0.vector2_1.X - (this.class421_0.float_3 - this.float_0);
			}

			// Token: 0x06001F06 RID: 7942
			// RVA: 0x00019714 File Offset: 0x00017914
			public void method_1(Class530 class530_0)
			{
				class530_0.vector2_1.X = class530_0.vector2_1.X - (this.class421_0.float_3 - this.float_0);
			}

			// Token: 0x06001F07 RID: 7943
			// RVA: 0x00019714 File Offset: 0x00017914
			public void method_2(Class530 class530_0)
			{
				class530_0.vector2_1.X = class530_0.vector2_1.X - (this.class421_0.float_3 - this.float_0);
			}
		}

		// Token: 0x020003CF RID: 975
		[CompilerGenerated]
		private sealed class Class425
		{
			// Token: 0x040018B3 RID: 6323
			public float float_0;

			// Token: 0x06001F09 RID: 7945
			// RVA: 0x0001973A File Offset: 0x0001793A
			public void method_0(float float_1)
			{
				this.float_0 += float_1;
			}
		}

		// Token: 0x020003D0 RID: 976
		[CompilerGenerated]
		private sealed class Class426
		{
			// Token: 0x040018B4 RID: 6324
			public float float_0;

			// Token: 0x06001F0B RID: 7947
			// RVA: 0x0001974A File Offset: 0x0001794A
			public void method_0(float float_1)
			{
				this.float_0 = Math.Min(this.float_0, float_1);
			}
		}

		// Token: 0x040018AA RID: 6314
		[CompilerGenerated]
		private static Action<Class409> action_0;

		// Token: 0x040018A1 RID: 6305
		private bool bool_0;

		// Token: 0x040018A7 RID: 6311
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040018A8 RID: 6312
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04001894 RID: 6292
		internal Class411 class411_0;

		// Token: 0x040018A6 RID: 6310
		[CompilerGenerated]
		private Class421 class421_0;

		// Token: 0x04001895 RID: 6293
		private Class531 class531_0;

		// Token: 0x04001896 RID: 6294
		private Class531 class531_1;

		// Token: 0x04001898 RID: 6296
		private Class531 class531_2;

		// Token: 0x04001899 RID: 6297
		private Class531 class531_3;

		// Token: 0x0400189B RID: 6299
		private Class531 class531_4;

		// Token: 0x0400189C RID: 6300
		private Class531 class531_5;

		// Token: 0x04001897 RID: 6295
		private Class538 class538_0;

		// Token: 0x0400189A RID: 6298
		private Class538 class538_1;

		// Token: 0x0400188F RID: 6287
		internal Class546 class546_0;

		// Token: 0x04001890 RID: 6288
		internal Class911 class911_0;

		// Token: 0x04001891 RID: 6289
		internal Class911 class911_1;

		// Token: 0x04001892 RID: 6290
		internal Class911 class911_2;

		// Token: 0x04001893 RID: 6291
		internal Class911 class911_3;

		// Token: 0x0400189D RID: 6301
		private Dictionary<string, Class731[]> dictionary_0;

		// Token: 0x0400189F RID: 6303
		internal float float_0;

		// Token: 0x040018A0 RID: 6304
		private float float_1;

		// Token: 0x040018A2 RID: 6306
		private float float_2;

		// Token: 0x040018A3 RID: 6307
		private float float_3;

		// Token: 0x040018A9 RID: 6313
		[CompilerGenerated]
		private float float_4;

		// Token: 0x0400188E RID: 6286
		private int int_0;

		// Token: 0x040018A5 RID: 6309
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400189E RID: 6302
		internal List<Class409> list_0;

		// Token: 0x040018A4 RID: 6308
		private static Mods?[] nullable_0;

		// Token: 0x17000368 RID: 872
		internal float Top
		{
			// Token: 0x06001ED9 RID: 7897
			// RVA: 0x0001949B File Offset: 0x0001769B
			get
			{
				return this.float_2;
			}
		}

		// Token: 0x06001EF0 RID: 7920
		// RVA: 0x0001967F File Offset: 0x0001787F
		static Class421()
		{
			Class421.smethod_4();
		}

		// Token: 0x06001ECA RID: 7882
		// RVA: 0x000AD6D8 File Offset: 0x000AB8D8
		internal Class421(Class297 class297_0)
		{
			Class546 class = new Class546();
			class.method_7(Class421.smethod_3(class297_0.class296_0, class297_0.class623_0));
			this..ctor(class, true, 0f, 480f, float.NaN, 1f, 0, 0);
		}

		// Token: 0x06001EC9 RID: 7881
		// RVA: 0x000ACC64 File Offset: 0x000AAE64
		internal Class421(Class546 class546_1, bool bool_3, float float_5, float float_6, float float_7, float float_8, int int_2, int int_3)
		{
			this.dictionary_0 = new Dictionary<string, Class731[]>(6);
			this.list_0 = new List<Class409>();
			base..ctor();
			this.method_11(bool_3);
			this.method_21(float_6);
			this.class546_0 = class546_1;
			this.int_0 = int_2;
			this.method_1(int_3);
			if (!bool_3)
			{
				this.class911_0 = new Class911(true);
				this.class911_1 = new Class911(true);
				this.class911_2 = new Class911(true);
				this.class911_3 = new Class911(true);
				this.class531_1 = new Class531(this.class546_0.Load("StageHint", "mania-stage-hint", this.method_7()), Enum115.const_5, Origins.CentreLeft, Enum114.const_1, new Vector2(0f, this.method_30()), 0.62f, true, Color.get_White(), null);
				this.class531_1.float_3 = 0.9f;
				this.class531_1.vector2_2 = new Vector2(0f, 0.9f);
				this.class531_1.float_2 = 1.6026f;
				this.class531_1.method_43(this.method_26());
				this.class911_0.Add(this.class531_1);
				Class531 class = new Class531(this.class546_0.Load("StageLeft", "mania-stage-left", this.method_7()), Enum115.const_5, Origins.TopRight, Enum114.const_1, new Vector2(0.05f, this.Top), 0.8f, true, Color.get_White(), null);
				class.vector2_2 = new Vector2(this.method_31(), this.method_20() / (float)class.int_5 * 1.6f);
				this.class911_1.Add(class);
				this.class531_0 = new Class531(this.class546_0.Load("StageRight", "mania-stage-right", this.method_7()), Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0.05f, this.Top), 0.8f, true, Color.get_White(), null);
				this.class531_0.vector2_2 = new Vector2(this.method_31(), this.method_20() / (float)this.class531_0.int_5 * 1.6f);
				this.class911_1.Add(this.class531_0);
				Class731[] array = this.class546_0.method_9("StageBottom", "mania-stage-bottom", this.method_7());
				if (array != null && array.Length > 0)
				{
					this.class538_0 = new Class538(array, Enum115.const_5, this.method_45(Origins.BottomCentre), Enum114.const_1, new Vector2(0f, this.method_27()), 0.94f, true, Color.get_White());
					this.class538_0.method_53(16.666666666666668);
					this.class538_0.float_2 = 1.6f;
					this.class911_2.Add(this.class538_0);
				}
				if (this.class546_0.bool_0)
				{
					this.class531_2 = new Class531(Class115.class731_0, Enum115.const_5, this.method_45(Origins.TopLeft), Enum114.const_1, new Vector2(0f, this.method_30()), 0.62f, true, this.class546_0.method_8("JudgementLine", Color.get_White()), null);
					this.class531_2.float_3 = 0.9f;
					this.class531_2.vector2_2 = new Vector2(0f, 0.7f);
					this.class531_2.float_2 = 1.6026f;
					this.class911_0.Add(this.class531_2);
				}
				class = new Class531(Class885.Load("mania-stage-light", Enum112.flag_1), Enum115.const_5, Origins.BottomRight, Enum114.const_1, new Vector2(0f, this.Top), 0.5f, true, Color.get_TransparentWhite(), null);
				class.float_1 = -1.57079637f;
				class.vector2_2 = new Vector2(this.method_20() / (float)class.int_6, 0.27f) * 1.6f;
				this.class911_1.Add(class);
				this.class531_3 = new Class531(Class885.Load("mania-stage-light", Enum112.flag_1), Enum115.const_5, Origins.BottomLeft, Enum114.const_1, new Vector2(0f, this.Top), 0.5f, true, Color.get_TransparentWhite(), null);
				this.class531_3.float_1 = 1.57079637f;
				this.class531_3.vector2_2 = new Vector2(this.method_20() / (float)this.class531_3.int_6, 0.27f) * 1.6f;
				this.class911_1.Add(this.class531_3);
				this.class538_1 = new Class538(null, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(0f, this.method_41((float)this.class546_0.int_3)), 0.998f, true, Color.get_White());
				this.class538_1.method_53(50.0);
				this.class911_2.Add(this.class538_1);
				string[] array2 = new string[]
				{
					"0",
					"50",
					"100",
					"200",
					"300",
					"300g"
				};
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i];
					this.dictionary_0.Add(text, this.class546_0.method_9("Hit" + text, "mania-hit" + text, this.method_7()));
				}
				if (this.method_9())
				{
					bool flag = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden);
					Class731 class2 = Class885.Load("mania-stage-hidden", Enum112.flag_1);
					if (class2 == null)
					{
						Class115.smethod_70(OsuModes.Menu, false);
					}
					if (this.method_26())
					{
						this.class531_4 = new Class531(Class115.class731_0, Enum115.const_5, flag ? Origins.TopLeft : Origins.BottomLeft, Enum114.const_1, new Vector2(0f, flag ? this.method_30() : 480f), 0.81f, true, Color.get_Black(), null);
						this.class531_5 = new Class531(class2, Enum115.const_5, flag ? Origins.TopLeft : Origins.BottomLeft, Enum114.const_1, new Vector2(0f, flag ? (this.method_30() + 100f) : 200f), 0.81f, true, Color.get_TransparentWhite(), null);
					}
					else
					{
						this.class531_4 = new Class531(Class115.class731_0, Enum115.const_5, flag ? Origins.BottomLeft : Origins.TopLeft, Enum114.const_1, new Vector2(0f, flag ? this.method_30() : 0f), 0.81f, true, Color.get_Black(), null);
						this.class531_5 = new Class531(class2, Enum115.const_5, flag ? Origins.BottomLeft : Origins.TopLeft, Enum114.const_1, new Vector2(0f, flag ? (this.method_30() - 100f) : 100f), 0.81f, true, Color.get_TransparentWhite(), null);
					}
					this.class911_2.Add(this.class531_4);
					this.class911_2.Add(this.class531_5);
				}
			}
			this.method_24(float.IsNaN(float_7) ? this.class546_0.float_1 : float_7);
			this.method_22(float_5);
			if (!bool_3 && int_3 == 0)
			{
				float float_9 = Math.Min(this.method_23(), (float)Class115.smethod_43() - this.class546_0.float_2);
				float num = Math.Min(this.class546_0.float_2, (float)Class115.smethod_43() - this.method_23());
				this.method_24(float_9);
				float num2 = 0f;
				for (int j = 0; j < this.class546_0.method_6(); j++)
				{
					num2 += this.class546_0.list_2[j] + ((j > 0) ? this.class546_0.list_1[j - 1] : 0f);
				}
				float arg_785_0 = num2;
				float arg_785_1;
				if (this.class546_0.method_4())
				{
					if (this.method_40() != -1)
					{
						arg_785_1 = this.class546_0.float_3;
						goto IL_785;
					}
				}
				arg_785_1 = 0f;
				IL_785:
				num2 = arg_785_0 + arg_785_1;
				float num3 = this.method_23() + num2 + num;
				float num4 = Math.Max(0f, num3 - (float)Class115.smethod_43());
				float_8 = (num2 - num4) / num2;
			}
			this.float_1 = float_8;
			for (int k = int_3; k < int_3 + this.method_39(); k++)
			{
				this.list_0.Add(new Class409(this, k, float_8));
			}
			if (!bool_3)
			{
				this.class911_3.method_18(new RectangleF(this.method_23(), this.Top, this.float_0, this.method_20()));
				this.class911_3.bool_4 = true;
			}
			if (!bool_3)
			{
				this.class531_1.vector2_2.X = this.float_0 / (float)this.class531_1.int_6;
				Class531 expr_856_cp_0 = this.class531_0;
				expr_856_cp_0.vector2_1.X = expr_856_cp_0.vector2_1.X + this.float_0;
				if (this.class538_0 != null)
				{
					Class538 expr_87B_cp_0 = this.class538_0;
					expr_87B_cp_0.vector2_1.X = expr_87B_cp_0.vector2_1.X + this.float_0 / 2f;
				}
				if (this.class531_2 != null)
				{
					this.class531_2.vector2_2.X = this.float_0;
				}
				Class531 expr_8BC_cp_0 = this.class531_3;
				expr_8BC_cp_0.vector2_1.X = expr_8BC_cp_0.vector2_1.X + this.float_0;
				Class538 expr_8D9_cp_0 = this.class538_1;
				expr_8D9_cp_0.vector2_1.X = expr_8D9_cp_0.vector2_1.X + this.float_0 / 2f;
				if (Class885.class547_0.double_0 >= 2.4 || this.method_31() < 1f)
				{
					this.class538_1.vector2_2 = Vector2.get_One() * this.method_33();
				}
				if (this.method_9())
				{
					bool flag2 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden);
					this.class531_4.vector2_2 = new Vector2(this.float_0 * 1.6f, 160f);
					this.class531_4.float_3 = 0f;
					this.class531_5.vector2_2 = new Vector2(this.float_0 * 1.6f, 0.72f);
					if ((!flag2 && !this.method_26()) || (flag2 && this.method_26()))
					{
						this.class531_5.method_43(true);
					}
					this.class531_5.float_3 = 0f;
				}
				if (this.method_40() == -1)
				{
					this.class411_0 = new Class411(this);
				}
			}
			if (this.method_40() != -1)
			{
				float_7 = this.method_23() + this.float_0 + this.class546_0.float_3 * float_8;
				this.method_4(new Class421(this.class546_0, bool_3, float_5, float_6, float_7, float_8, int_2 + 1, int_3 + this.method_39()));
				this.list_0.AddRange(this.method_3().list_0);
				this.class411_0 = this.method_3().class411_0;
			}
			this.method_13();
		}

		// Token: 0x06001ED3 RID: 7891
		// RVA: 0x00019473 File Offset: 0x00017673
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001ED4 RID: 7892
		// RVA: 0x000ADD34 File Offset: 0x000ABF34
		protected virtual void Dispose(bool bool_3)
		{
			if (bool_3)
			{
				if (!this.method_10())
				{
					this.class911_0.Dispose();
					this.class911_1.Dispose();
					this.class911_2.Dispose();
				}
				if (this.method_3() != null)
				{
					this.method_3().Dispose();
				}
				this.method_12(true);
			}
		}

		// Token: 0x06001ED1 RID: 7889
		// RVA: 0x000ADCD4 File Offset: 0x000ABED4
		internal void Draw()
		{
			foreach (Class421 current in this)
			{
				current.class911_3.Draw();
				current.method_44();
				current.class911_2.Draw();
			}
		}

		// Token: 0x06001ED5 RID: 7893
		// RVA: 0x000ADD88 File Offset: 0x000ABF88
		public IEnumerator<Class421> GetEnumerator()
		{
			Class421.Class422 class = new Class421.Class422(0);
			class.class421_1 = this;
			return class;
		}

		// Token: 0x06001EBC RID: 7868
		// RVA: 0x00019390 File Offset: 0x00017590
		[CompilerGenerated]
		internal int method_0()
		{
			return this.int_1;
		}

		// Token: 0x06001EBD RID: 7869
		// RVA: 0x00019398 File Offset: 0x00017598
		[CompilerGenerated]
		private void method_1(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x06001EC6 RID: 7878
		// RVA: 0x00019427 File Offset: 0x00017627
		[CompilerGenerated]
		internal bool method_10()
		{
			return this.bool_1;
		}

		// Token: 0x06001EC7 RID: 7879
		// RVA: 0x0001942F File Offset: 0x0001762F
		[CompilerGenerated]
		private void method_11(bool bool_3)
		{
			this.bool_1 = bool_3;
		}

		// Token: 0x06001EC8 RID: 7880
		// RVA: 0x00019438 File Offset: 0x00017638
		[CompilerGenerated]
		private void method_12(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x06001ECB RID: 7883
		// RVA: 0x000AD728 File Offset: 0x000AB928
		private void method_13()
		{
			int num = Math.Min(this.int_0, 1);
			int num2 = this.method_39();
			bool flag = this.method_35() && this.method_8() != Enum54.const_0;
			Class577 class = this.method_5().method_2();
			if (class != null)
			{
				foreach (Class409 current in this.list_0)
				{
					current.Key = class[current, Enum53.const_1];
				}
				if (flag)
				{
					this.list_0[this.method_38()].method_1(class[num, Enum53.const_2]);
				}
				return;
			}
			int num3 = 0;
			if (flag)
			{
				num2--;
				num3 = ((this.method_38() == 0) ? 1 : 0);
				this.list_0[this.method_38()].Key = Class795.keys_1[num];
				this.list_0[this.method_38()].method_1(Class795.keys_2[num]);
			}
			int num4 = Math.Max(0, Class795.int_0[num] - num2 / 2);
			bool flag2 = num2 % 2 == 0 && num2 < 10;
			for (int i = 0; i < num2; i++)
			{
				if (flag2 && (num4 == Class795.int_0[0] || num4 == Class795.int_0[1]))
				{
					num4++;
				}
				this.list_0[i + num3].Key = Class795.keys_0[num4++];
			}
		}

		// Token: 0x06001ECC RID: 7884
		// RVA: 0x000AD8B0 File Offset: 0x000ABAB0
		internal void method_14()
		{
			foreach (Class421 current in this)
			{
				current.method_13();
			}
		}

		// Token: 0x06001ECD RID: 7885
		// RVA: 0x000AD8F8 File Offset: 0x000ABAF8
		internal void method_15(Class577 class577_0)
		{
			if (class577_0 == null)
			{
				return;
			}
			foreach (Class421 current in this)
			{
				foreach (Class409 current2 in current.list_0)
				{
					class577_0[current2, Enum53.const_1] = current2.Key;
				}
				if (current.method_35() && current.method_8() != Enum54.const_0)
				{
					class577_0[Math.Min(current.int_0, 1), Enum53.const_2] = current.list_0[current.method_38()].method_0();
				}
			}
		}

		// Token: 0x06001ECE RID: 7886
		// RVA: 0x000AD9CC File Offset: 0x000ABBCC
		private Class731[] method_16(Enum61 enum61_0)
		{
			if (enum61_0 <= Enum61.flag_34)
			{
				if (enum61_0 != Enum61.flag_4)
				{
					if (enum61_0 == Enum61.flag_33)
					{
						return this.dictionary_0["50"];
					}
					if (enum61_0 == Enum61.flag_34)
					{
						return this.dictionary_0["100"];
					}
				}
			}
			else
			{
				if (enum61_0 == Enum61.flag_35)
				{
					return this.dictionary_0["200"];
				}
				if (enum61_0 == Enum61.flag_36)
				{
					return this.dictionary_0["300"];
				}
				if (enum61_0 == Enum61.flag_37)
				{
					return this.dictionary_0["300g"];
				}
			}
			return this.dictionary_0["0"];
		}

		// Token: 0x06001ECF RID: 7887
		// RVA: 0x000ADA7C File Offset: 0x000ABC7C
		internal void method_17(Enum61 enum61_0)
		{
			if (enum61_0 != Enum61.flag_0)
			{
				this.class538_1.method_55(this.method_16(enum61_0));
				this.class538_1.method_59();
				this.class538_1.class26_0.Clear();
				this.class538_1.float_1 = 0f;
				float num = 1f;
				this.class538_1.class26_0.Add(new Class746(TransformationType.Fade, this.class538_1.float_3, 1f, Class331.int_7, Class331.int_7 + 20, Enum70.const_1));
				if (enum61_0 == Enum61.flag_4)
				{
					this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, num * 1.2f, num, Class331.int_7, Class331.int_7 + 100, Enum70.const_1));
					this.class538_1.class26_0.Add(new Class746(TransformationType.Rotation, 0f, Class562.smethod_6(-0.1f, 0.1f), Class331.int_7, Class331.int_7 + 100, Enum70.const_1));
				}
				else
				{
					this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, num * 0.8f, num, Class331.int_7, Class331.int_7 + 40, Enum70.const_0));
					this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, num, num * 0.7f, Class331.int_7, Class331.int_7 + 80, Enum70.const_0));
					this.class538_1.class26_0.Add(new Class746(TransformationType.Scale, num * 0.7f, num * 0.4f, Class331.int_7 + 180, Class331.int_7 + 220, Enum70.const_2));
				}
				this.class538_1.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 180, Class331.int_7 + 220, Enum70.const_2));
			}
		}

		// Token: 0x06001ED0 RID: 7888
		// RVA: 0x000ADC48 File Offset: 0x000ABE48
		internal void method_18()
		{
			foreach (Class421 current in this)
			{
				current.class911_1.Draw();
			}
			foreach (Class421 current2 in this)
			{
				current2.class911_0.Draw();
			}
		}

		// Token: 0x06001ED2 RID: 7890
		// RVA: 0x00019441 File Offset: 0x00017641
		internal void method_19()
		{
			if (Class802.smethod_0())
			{
				return;
			}
			List<Class409> arg_2B_0 = this.list_0;
			if (Class421.action_0 == null)
			{
				Class421.action_0 = new Action<Class409>(Class421.smethod_6);
			}
			arg_2B_0.ForEach(Class421.action_0);
		}

		// Token: 0x06001EBE RID: 7870
		// RVA: 0x000193A1 File Offset: 0x000175A1
		private int method_2()
		{
			return this.class546_0.method_6() - this.method_0();
		}

		// Token: 0x06001ED7 RID: 7895
		// RVA: 0x0001948A File Offset: 0x0001768A
		[CompilerGenerated]
		internal float method_20()
		{
			return this.float_4;
		}

		// Token: 0x06001ED8 RID: 7896
		// RVA: 0x00019492 File Offset: 0x00017692
		[CompilerGenerated]
		private void method_21(float float_5)
		{
			this.float_4 = float_5;
		}

		// Token: 0x06001EDA RID: 7898
		// RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		internal void method_22(float float_5)
		{
			Action<Class530> action = null;
			Action<Class530> action2 = null;
			Action<Class530> action3 = null;
			Class421.Class423 class = new Class421.Class423();
			class.float_0 = float_5;
			class.class421_0 = this;
			if (!this.method_10())
			{
				List<Class530> arg_41_0 = this.class911_0.list_2;
				if (action == null)
				{
					action = new Action<Class530>(class.method_0);
				}
				arg_41_0.ForEach(action);
				List<Class530> arg_62_0 = this.class911_2.list_2;
				if (action2 == null)
				{
					action2 = new Action<Class530>(class.method_1);
				}
				arg_62_0.ForEach(action2);
				List<Class530> arg_83_0 = this.class911_1.list_2;
				if (action3 == null)
				{
					action3 = new Action<Class530>(class.method_2);
				}
				arg_83_0.ForEach(action3);
				this.class911_3.method_18(new RectangleF(this.method_23(), this.Top, this.float_0, this.method_20()));
			}
			this.float_2 = class.float_0;
		}

		// Token: 0x06001EDB RID: 7899
		// RVA: 0x000194A3 File Offset: 0x000176A3
		internal float method_23()
		{
			return this.float_3;
		}

		// Token: 0x06001EDC RID: 7900
		// RVA: 0x000ADE70 File Offset: 0x000AC070
		internal void method_24(float float_5)
		{
			Action<Class530> action = null;
			Action<Class530> action2 = null;
			Action<Class530> action3 = null;
			Class421.Class424 class = new Class421.Class424();
			class.float_0 = float_5;
			class.class421_0 = this;
			if (!this.method_10())
			{
				List<Class530> arg_41_0 = this.class911_0.list_2;
				if (action == null)
				{
					action = new Action<Class530>(class.method_0);
				}
				arg_41_0.ForEach(action);
				List<Class530> arg_62_0 = this.class911_2.list_2;
				if (action2 == null)
				{
					action2 = new Action<Class530>(class.method_1);
				}
				arg_62_0.ForEach(action2);
				List<Class530> arg_83_0 = this.class911_1.list_2;
				if (action3 == null)
				{
					action3 = new Action<Class530>(class.method_2);
				}
				arg_83_0.ForEach(action3);
				this.class911_3.method_18(new RectangleF(this.method_23(), this.Top, this.float_0, this.method_20()));
			}
			this.float_3 = class.float_0;
		}

		// Token: 0x06001EDD RID: 7901
		// RVA: 0x000194AB File Offset: 0x000176AB
		internal float method_25()
		{
			return this.Top + this.method_20();
		}

		// Token: 0x06001EDE RID: 7902
		// RVA: 0x000194BA File Offset: 0x000176BA
		internal bool method_26()
		{
			return this.class546_0.bool_1;
		}

		// Token: 0x06001EDF RID: 7903
		// RVA: 0x000194C7 File Offset: 0x000176C7
		internal float method_27()
		{
			if (!this.method_26())
			{
				return this.method_25();
			}
			return this.Top;
		}

		// Token: 0x06001EE0 RID: 7904
		// RVA: 0x000194DE File Offset: 0x000176DE
		internal float method_28()
		{
			if (!this.method_10())
			{
				return this.class911_0.float_0;
			}
			return 0f;
		}

		// Token: 0x06001EE1 RID: 7905
		// RVA: 0x000ADF3C File Offset: 0x000AC13C
		internal void method_29(float float_5)
		{
			if (!this.method_10())
			{
				Class911 arg_39_0 = this.class911_1;
				Class911 arg_33_0 = this.class911_2;
				Class911 arg_2B_0 = this.class911_0;
				this.class911_3.float_0 = float_5;
				arg_2B_0.float_0 = float_5;
				arg_33_0.float_0 = float_5;
				arg_39_0.float_0 = float_5;
			}
			if (this.method_3() != null)
			{
				this.method_3().method_29(this.method_28());
			}
		}

		// Token: 0x06001EBF RID: 7871
		// RVA: 0x000193B5 File Offset: 0x000175B5
		[CompilerGenerated]
		internal Class421 method_3()
		{
			return this.class421_0;
		}

		// Token: 0x06001EE2 RID: 7906
		// RVA: 0x000194F9 File Offset: 0x000176F9
		internal float method_30()
		{
			return this.method_41((float)this.class546_0.int_0);
		}

		// Token: 0x06001EE3 RID: 7907
		// RVA: 0x0001950D File Offset: 0x0001770D
		internal float method_31()
		{
			return this.method_20() / (float)Class115.int_19;
		}

		// Token: 0x06001EE4 RID: 7908
		// RVA: 0x000ADFA0 File Offset: 0x000AC1A0
		internal float method_32()
		{
			Class421.Class425 class = new Class421.Class425();
			if (this.class546_0.method_6() == 0)
			{
				return 0f;
			}
			class.float_0 = 0f;
			this.class546_0.list_2.ForEach(new Action<float>(class.method_0));
			return class.float_0 * this.float_1 / (float)(30 * this.class546_0.method_6());
		}

		// Token: 0x06001EE5 RID: 7909
		// RVA: 0x0001951C File Offset: 0x0001771C
		internal float method_33()
		{
			return Math.Min(this.method_32(), this.method_31());
		}

		// Token: 0x06001EE6 RID: 7910
		// RVA: 0x000AE00C File Offset: 0x000AC20C
		internal float method_34()
		{
			Class421.Class426 class = new Class421.Class426();
			class.float_0 = 3.40282347E+38f;
			this.class546_0.list_2.ForEach(new Action<float>(class.method_0));
			return class.float_0 * this.float_1;
		}

		// Token: 0x06001EE7 RID: 7911
		// RVA: 0x0001952F File Offset: 0x0001772F
		internal bool method_35()
		{
			return this.method_39() > 4 && this.method_39() % 2 == 0;
		}

		// Token: 0x06001EE8 RID: 7912
		// RVA: 0x00019547 File Offset: 0x00017747
		internal bool method_36()
		{
			return this.method_35() && this.class546_0 != null && this.method_8() == Enum54.const_2;
		}

		// Token: 0x06001EE9 RID: 7913
		// RVA: 0x00019564 File Offset: 0x00017764
		internal int method_37()
		{
			if (this.list_0.Count != 8)
			{
				return this.method_0();
			}
			return this.method_0() + 1;
		}

		// Token: 0x06001EEA RID: 7914
		// RVA: 0x00019583 File Offset: 0x00017783
		internal int method_38()
		{
			if (this.method_39() % 2 != 0)
			{
				return 2 + (this.method_39() - 5) / 2;
			}
			if (this.method_8() == Enum54.const_0 || !this.method_35())
			{
				return -1;
			}
			if (this.method_8() != Enum54.const_1)
			{
				return this.method_39() - 1;
			}
			return 0;
		}

		// Token: 0x06001EEB RID: 7915
		// RVA: 0x000195C1 File Offset: 0x000177C1
		internal int method_39()
		{
			if (this.class546_0.method_4() && this.int_0 <= 0)
			{
				return (this.method_2() + 1) / 2;
			}
			return this.method_2();
		}

		// Token: 0x06001EC0 RID: 7872
		// RVA: 0x000193BD File Offset: 0x000175BD
		[CompilerGenerated]
		private void method_4(Class421 class421_1)
		{
			this.class421_0 = class421_1;
		}

		// Token: 0x06001EEC RID: 7916
		// RVA: 0x000195EA File Offset: 0x000177EA
		internal int method_40()
		{
			if (this.class546_0.method_4() && this.int_0 <= 0 && this.method_2() > this.method_39())
			{
				return this.method_2() - this.method_39();
			}
			return -1;
		}

		// Token: 0x06001EED RID: 7917
		// RVA: 0x0001961F File Offset: 0x0001781F
		internal float method_41(float float_5)
		{
			float_5 = (this.method_26() ? ((float)Class115.int_19 - float_5) : float_5);
			return this.Top + float_5 * this.method_31();
		}

		// Token: 0x06001EEE RID: 7918
		// RVA: 0x00019645 File Offset: 0x00017845
		internal RectangleF method_42(float float_5, float float_6)
		{
			float_5 = this.method_41(float_5);
			float_6 = this.method_41(float_6);
			return RectangleF.smethod_0(this.method_23(), Math.Min(float_5, float_6), this.method_23() + this.float_0, Math.Max(float_5, float_6));
		}

		// Token: 0x06001EEF RID: 7919
		// RVA: 0x000AE054 File Offset: 0x000AC254
		internal int method_43(Vector2 vector2_0, bool bool_3)
		{
			if (bool_3 && this.list_0.Count == 8)
			{
				float num = 73.14286f;
				return Math.Min((int)Math.Floor((double)(Math.Max(0f, vector2_0.X) / num)), 6) + 1;
			}
			float num2 = 512f / (float)this.list_0.Count;
			return Math.Min((int)Math.Floor((double)(vector2_0.X / num2)), this.list_0.Count - 1);
		}

		// Token: 0x06001EF7 RID: 7927
		// RVA: 0x000AE2B4 File Offset: 0x000AC4B4
		private void method_44()
		{
			if (this.method_9())
			{
				if (this.class531_4 == null || this.class531_5 == null)
				{
					Class62.class62_0.method_4();
					return;
				}
				if (!Class62.bool_11 && Class115.bool_13)
				{
					if (Class872.bool_1)
					{
						if (this.class531_4.float_3 > 0f)
						{
							this.class531_4.float_3 -= 0.016667f;
						}
						else if (this.class531_4.float_3 < 0f)
						{
							this.class531_4.float_3 = 0f;
						}
						if (this.class531_5.float_3 > 0f)
						{
							this.class531_5.float_3 -= 0.016667f;
							return;
						}
						if (this.class531_5.float_3 < 0f)
						{
							this.class531_5.float_3 = 0f;
							return;
						}
					}
					else
					{
						if (this.class531_4.float_3 < 1f)
						{
							this.class531_4.float_3 += 0.026667f;
						}
						else if (this.class531_4.float_3 > 1f)
						{
							this.class531_4.float_3 = 1f;
						}
						if (this.class531_5.float_3 < 1f)
						{
							this.class531_5.float_3 += 0.026667f;
						}
						else if (this.class531_5.float_3 > 1f)
						{
							this.class531_5.float_3 = 1f;
						}
						float num = (float)Math.Min(400, 160 + Class62.class62_0.class427_0.class413_0.vmethod_0() / 2);
						if (this.class531_4.vector2_2.Y > num)
						{
							Class531 expr_1BC_cp_0 = this.class531_4;
							expr_1BC_cp_0.vector2_2.Y = expr_1BC_cp_0.vector2_2.Y - 2f;
						}
						else
						{
							this.class531_4.vector2_2.Y = num;
						}
						if (this.method_26())
						{
							if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden))
							{
								this.class531_5.vector2_1.Y = this.method_30() + this.class531_4.vector2_2.Y / 1.6f;
								return;
							}
							this.class531_5.vector2_1.Y = (float)Class115.int_19 - this.class531_4.vector2_2.Y / 1.6f;
							return;
						}
						else
						{
							if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden))
							{
								this.class531_5.vector2_1.Y = this.method_30() - this.class531_4.vector2_2.Y / 1.6f;
								return;
							}
							this.class531_5.vector2_1.Y = this.class531_4.vector2_2.Y / 1.6f;
						}
					}
				}
			}
		}

		// Token: 0x06001EF8 RID: 7928
		// RVA: 0x000AE594 File Offset: 0x000AC794
		internal Origins method_45(Origins origins_0)
		{
			if (!this.method_26())
			{
				return origins_0;
			}
			switch (origins_0)
			{
			case Origins.TopLeft:
				return Origins.BottomLeft;
			case Origins.TopRight:
				return Origins.BottomRight;
			case Origins.BottomCentre:
				return Origins.TopCentre;
			case Origins.TopCentre:
				return Origins.BottomCentre;
			case Origins.BottomLeft:
				return Origins.TopLeft;
			case Origins.BottomRight:
				return Origins.TopRight;
			}
			return origins_0;
		}

		// Token: 0x06001EC1 RID: 7873
		// RVA: 0x000193C6 File Offset: 0x000175C6
		internal Class576 method_5()
		{
			return Class575.smethod_1(this.class546_0.method_6(), this.class546_0.method_4() ? ManiaLayoutsFor.Split : ManiaLayoutsFor.Normal);
		}

		// Token: 0x06001EC2 RID: 7874
		// RVA: 0x000193E9 File Offset: 0x000175E9
		internal bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x06001EC3 RID: 7875
		// RVA: 0x000193F1 File Offset: 0x000175F1
		internal Enum112 method_7()
		{
			if (Class466.Current.method_5() != PlayModes.OsuMania)
			{
				return Enum112.flag_5;
			}
			return Enum112.flag_6;
		}

		// Token: 0x06001EC4 RID: 7876
		// RVA: 0x000ACC14 File Offset: 0x000AAE14
		internal Enum54 method_8()
		{
			if (!this.method_35())
			{
				return Enum54.const_0;
			}
			if (this.int_0 % 2 == 0)
			{
				return this.class546_0.enum54_0;
			}
			if (this.class546_0.enum54_0 == Enum54.const_1)
			{
				return Enum54.const_2;
			}
			if (this.class546_0.enum54_0 == Enum54.const_2)
			{
				return Enum54.const_1;
			}
			return Enum54.const_0;
		}

		// Token: 0x06001EC5 RID: 7877
		// RVA: 0x00019403 File Offset: 0x00017603
		private bool method_9()
		{
			return Class62.class512_0 != null && Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden | Mods.FadeIn);
		}

		// Token: 0x06001EF1 RID: 7921
		// RVA: 0x000AE0D0 File Offset: 0x000AC2D0
		private static int smethod_0(Class296 class296_0)
		{
			float num = (float)(class296_0.ushort_1 + class296_0.ushort_2) / (float)class296_0.int_11;
			if ((double)num < 0.2)
			{
				return 7;
			}
			if ((double)num >= 0.3 && Math.Round((double)class296_0.DifficultyCircleSize) < 5.0)
			{
				if ((double)num <= 0.6)
				{
					return Math.Max(4, Math.Min((int)Math.Round((double)class296_0.DifficultyOverall) + 1, 7));
				}
				if (Math.Round((double)class296_0.DifficultyOverall) <= 4.0)
				{
					return 4;
				}
				return 5;
			}
			else
			{
				if (Math.Round((double)class296_0.DifficultyOverall) <= 5.0)
				{
					return 6;
				}
				return 7;
			}
		}

		// Token: 0x06001EF2 RID: 7922
		// RVA: 0x00019686 File Offset: 0x00017886
		internal static int smethod_1(Class296 class296_0)
		{
			if (class296_0.method_5() == PlayModes.OsuMania)
			{
				return (int)Math.Round((double)class296_0.DifficultyCircleSize);
			}
			return Class421.smethod_0(class296_0);
		}

		// Token: 0x06001EF3 RID: 7923
		// RVA: 0x000196A5 File Offset: 0x000178A5
		internal static int smethod_2(Class296 class296_0)
		{
			if (class296_0 == null)
			{
				return 4;
			}
			return Class421.smethod_3(class296_0, Class802.smethod_0() ? Class802.class512_0.class623_0 : Class876.class623_0);
		}

		// Token: 0x06001EF4 RID: 7924
		// RVA: 0x000AE188 File Offset: 0x000AC388
		internal static int smethod_3(Class296 class296_0, Mods mods_0)
		{
			if (class296_0 == null)
			{
				return 4;
			}
			if (class296_0.method_5() == PlayModes.OsuMania)
			{
				return (int)Math.Round((double)class296_0.DifficultyCircleSize);
			}
			Mods mods = mods_0 & Mods.KeyMod & ~Mods.KeyCoop;
			int num;
			if (mods > Mods.None && (mods & mods - 1) == Mods.None)
			{
				num = Convert.ToInt32(mods.ToString().Substring(3));
			}
			else
			{
				num = Class421.smethod_0(class296_0);
			}
			if ((mods_0 & Mods.KeyCoop) > Mods.None)
			{
				return num * 2;
			}
			return num;
		}

		// Token: 0x06001EF5 RID: 7925
		// RVA: 0x000AE1FC File Offset: 0x000AC3FC
		private static void smethod_4()
		{
			Class421.nullable_0 = new Mods?[19];
			int i = 1;
			while (i <= 18)
			{
				Mods mods = Mods.None;
				int num = i;
				if (i <= 9)
				{
					goto IL_28;
				}
				if (i % 2 == 0)
				{
					num /= 2;
					mods = Mods.KeyCoop;
					goto IL_28;
				}
				IL_63:
				i++;
				continue;
				IL_28:
				Class421.nullable_0[i] = new Mods?(mods | (Mods)Enum.Parse(typeof(Mods), "Key" + num));
				goto IL_63;
			}
		}

		// Token: 0x06001EF6 RID: 7926
		// RVA: 0x000AE278 File Offset: 0x000AC478
		internal static Mods smethod_5(Class296 class296_0, Mods mods_0)
		{
			Mods mods = mods_0 & ~(Mods.Key4 | Mods.Key5 | Mods.Key6 | Mods.Key7 | Mods.Key8 | Mods.Key9 | Mods.KeyCoop | Mods.Key1 | Mods.Key3 | Mods.Key2);
			int num = Class421.smethod_3(class296_0, mods_0);
			if (Class421.smethod_1(class296_0) == num)
			{
				return mods;
			}
			return mods | Class421.nullable_0[num].Value;
		}

		// Token: 0x06001EF9 RID: 7929
		// RVA: 0x000196CF File Offset: 0x000178CF
		[CompilerGenerated]
		private static void smethod_6(Class409 class409_0)
		{
			class409_0.method_7();
		}

		// Token: 0x06001ED6 RID: 7894
		// RVA: 0x00019482 File Offset: 0x00017682
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
