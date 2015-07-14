using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns29;
using ns79;
using ns81;
using ns82;
using ns9;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns27
{
	// Token: 0x02000599 RID: 1433
	internal sealed class Class110 : Class54
	{
		// Token: 0x0200059A RID: 1434
		[CompilerGenerated]
		private sealed class Class758
		{
			// Token: 0x04002680 RID: 9856
			public RectangleF rectangleF_0;

			// Token: 0x06002E14 RID: 11796
			// RVA: 0x00022CC8 File Offset: 0x00020EC8
			public void method_0(Class911 class911_0)
			{
				class911_0.method_18(this.rectangleF_0);
			}
		}

		// Token: 0x0200059B RID: 1435
		[CompilerGenerated]
		private sealed class Class759
		{
			// Token: 0x04002681 RID: 9857
			public float float_0;

			// Token: 0x06002E16 RID: 11798
			// RVA: 0x00022CD6 File Offset: 0x00020ED6
			public void method_0(Class911 class911_0)
			{
				class911_0.float_0 = this.float_0;
			}
		}

		// Token: 0x0400267E RID: 9854
		[CompilerGenerated]
		private static Action<Class911> action_0;

		// Token: 0x0400267F RID: 9855
		[CompilerGenerated]
		private static Action<Class911> action_1;

		// Token: 0x0400265F RID: 9823
		internal bool bool_1 = true;

		// Token: 0x0400267A RID: 9850
		private bool bool_10;

		// Token: 0x04002660 RID: 9824
		internal bool bool_2;

		// Token: 0x04002663 RID: 9827
		internal bool bool_3 = true;

		// Token: 0x04002664 RID: 9828
		internal bool bool_4 = true;

		// Token: 0x04002665 RID: 9829
		internal bool bool_5;

		// Token: 0x04002666 RID: 9830
		private bool bool_6;

		// Token: 0x04002673 RID: 9843
		private bool bool_7;

		// Token: 0x04002675 RID: 9845
		internal bool bool_8;

		// Token: 0x04002676 RID: 9846
		private bool bool_9;

		// Token: 0x04002662 RID: 9826
		private readonly Class531 class531_0;

		// Token: 0x04002670 RID: 9840
		internal Class911 class911_0;

		// Token: 0x04002671 RID: 9841
		internal Class911 class911_1;

		// Token: 0x0400267B RID: 9851
		private double double_0;

		// Token: 0x0400267D RID: 9853
		internal double double_1 = 2.0;

		// Token: 0x0400265E RID: 9822
		private Enum97 enum97_0 = Enum97.const_2;

		// Token: 0x0400265D RID: 9821
		private Enum98 enum98_0;

		// Token: 0x04002661 RID: 9825
		internal float float_0;

		// Token: 0x0400266A RID: 9834
		private float float_1;

		// Token: 0x0400266C RID: 9836
		internal float float_2;

		// Token: 0x0400266F RID: 9839
		internal float float_3;

		// Token: 0x04002677 RID: 9847
		public float float_4 = 1f;

		// Token: 0x0400267C RID: 9852
		private float float_5 = -0.98f;

		// Token: 0x0400266D RID: 9837
		internal int int_1;

		// Token: 0x04002672 RID: 9842
		internal List<Class911> list_0 = new List<Class911>();

		// Token: 0x04002669 RID: 9833
		internal RectangleF rectangleF_0;

		// Token: 0x04002667 RID: 9831
		private Vector2 vector2_0;

		// Token: 0x04002668 RID: 9832
		private Vector2 vector2_1;

		// Token: 0x0400266B RID: 9835
		internal Vector2 vector2_2;

		// Token: 0x0400266E RID: 9838
		internal Vector2 vector2_3;

		// Token: 0x04002678 RID: 9848
		internal Vector2 vector2_4 = Vector2.get_Zero();

		// Token: 0x04002679 RID: 9849
		private Vector2 vector2_5;

		// Token: 0x04002674 RID: 9844
		private VoidDelegate voidDelegate_0;

		// Token: 0x06002DF1 RID: 11761
		// RVA: 0x00022B3D File Offset: 0x00020D3D
		internal Class110(Rectangle rectangle_0, Vector2 vector2_6, bool bool_11, float float_6, Enum98 enum98_1) : this(new RectangleF((float)rectangle_0.X, (float)rectangle_0.Y, (float)rectangle_0.Width, (float)rectangle_0.Height), vector2_6, bool_11, float_6, enum98_1)
		{
		}

		// Token: 0x06002DF2 RID: 11762
		// RVA: 0x00129F10 File Offset: 0x00128110
		internal Class110(RectangleF rectangleF_1, Vector2 vector2_6, bool bool_11, float float_6, Enum98 enum98_1) : base(Class115.class115_0)
		{
			this.enum98_0 = enum98_1;
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_10), enum98_1, this.enum97_0);
			Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_11), enum98_1, this.enum97_0);
			Class802.smethod_34(Enum96.const_3, new Delegate46(this.method_21), enum98_1, this.enum97_0);
			Class802.smethod_34(Enum96.const_2, new Delegate46(this.method_20), enum98_1, this.enum97_0);
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_13), enum98_1, this.enum97_0);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_12), enum98_1, this.enum97_0);
			this.class911_0 = new Class911(bool_11);
			this.class911_1 = new Class911(bool_11);
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 1.1f, true, Color.get_White(), null);
			this.class531_0.bool_1 = true;
			this.class531_0.class746_1 = new Class746(Color.get_White(), Color.get_YellowGreen(), 0, 0);
			this.class531_0.bool_11 = true;
			this.class531_0.float_2 = 1.6f;
			this.class911_0.Add(this.class531_0);
			this.method_2(float_6);
			this.method_14(vector2_6);
			this.method_16(rectangleF_1);
		}

		// Token: 0x06002E01 RID: 11777
		// RVA: 0x0012A7F4 File Offset: 0x001289F4
		protected override void Dispose(bool bool_11)
		{
			Class802.smethod_35(Enum96.const_8, new Delegate46(this.method_10), this.enum98_0);
			Class802.smethod_35(Enum96.const_6, new Delegate46(this.method_11), this.enum98_0);
			Class802.smethod_35(Enum96.const_3, new Delegate46(this.method_21), this.enum98_0);
			Class802.smethod_35(Enum96.const_2, new Delegate46(this.method_20), this.enum98_0);
			Class802.smethod_35(Enum96.const_1, new Delegate46(this.method_13), this.enum98_0);
			Class802.smethod_35(Enum96.const_0, new Delegate46(this.method_12), this.enum98_0);
			this.class911_0.Dispose();
			this.class911_1.Dispose();
			List<Class911> arg_C9_0 = this.list_0;
			if (Class110.action_0 == null)
			{
				Class110.action_0 = new Action<Class911>(Class110.smethod_0);
			}
			arg_C9_0.ForEach(Class110.action_0);
			base.Dispose(bool_11);
		}

		// Token: 0x06002E00 RID: 11776
		// RVA: 0x0012A79C File Offset: 0x0012899C
		public void Draw()
		{
			if (!this.method_4())
			{
				return;
			}
			this.class911_1.Draw();
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				this.list_0[i].Draw();
			}
			this.class911_0.Draw();
		}

		// Token: 0x06002E04 RID: 11780
		// RVA: 0x0012A8D8 File Offset: 0x00128AD8
		public override void imethod_2()
		{
			if (this.method_4())
			{
				if (this.bool_9 && (this.method_9() || this.vmethod_0()))
				{
					this.class531_0.method_14(50, Enum70.const_0);
				}
				else
				{
					this.class531_0.method_16(50, Enum70.const_0);
				}
				this.class911_0.bool_6 = true;
				this.class911_1.bool_6 = true;
			}
			else
			{
				this.class911_0.bool_6 = false;
				this.class911_1.bool_6 = false;
			}
			if (Math.Abs(this.float_3) <= 0.01f && this.method_22() == this.vector2_3)
			{
				return;
			}
			this.int_1 = Class115.int_1;
			float num = this.method_28();
			this.method_17(new Vector2(this.vector2_3.X, this.vector2_3.Y + num * (float)Class115.double_9), 0f);
			if (Math.Abs(num) <= 0.01f && !this.vmethod_0() && this.method_22() == this.vector2_3 && this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
		}

		// Token: 0x06002E02 RID: 11778
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void Initialize()
		{
		}

		// Token: 0x06002DE8 RID: 11752
		// RVA: 0x00022AB0 File Offset: 0x00020CB0
		internal float method_1()
		{
			return this.float_1;
		}

		// Token: 0x06002DF4 RID: 11764
		// RVA: 0x00022BA2 File Offset: 0x00020DA2
		private bool method_10(object object_0, EventArgs eventArgs_0)
		{
			this.bool_7 = (this.method_9() && (!this.bool_8 || (this.class911_0.class531_1 == Class911.class531_0 && Class911.class531_0 != null)));
			return false;
		}

		// Token: 0x06002DF5 RID: 11765
		// RVA: 0x00022BE1 File Offset: 0x00020DE1
		private bool method_11(object object_0, EventArgs eventArgs_0)
		{
			this.bool_7 = false;
			return false;
		}

		// Token: 0x06002DF6 RID: 11766
		// RVA: 0x0012A0CC File Offset: 0x001282CC
		private bool method_12(object object_0, EventArgs eventArgs_0)
		{
			if (this.method_4() && this.method_9() && Class911.class531_0 == null)
			{
				if (this.float_3 < 0f)
				{
					this.float_3 = 0f;
				}
				this.method_25(100f * this.float_4, 0f);
				return true;
			}
			return false;
		}

		// Token: 0x06002DF7 RID: 11767
		// RVA: 0x0012A124 File Offset: 0x00128324
		private bool method_13(object object_0, EventArgs eventArgs_0)
		{
			if (this.method_4() && this.method_9() && Class911.class531_0 == null)
			{
				if (this.float_3 > 0f)
				{
					this.float_3 = 0f;
				}
				this.method_25(-100f * this.float_4, 0f);
				return true;
			}
			return false;
		}

		// Token: 0x06002DF8 RID: 11768
		// RVA: 0x00022BEB File Offset: 0x00020DEB
		internal void method_14(Vector2 vector2_6)
		{
			this.vector2_2 = vector2_6;
			this.method_17(this.vector2_3, 0f);
		}

		// Token: 0x06002DF9 RID: 11769
		// RVA: 0x0012A17C File Offset: 0x0012837C
		private void method_15()
		{
			this.bool_9 = (this.bool_1 && this.vector2_2.Y > this.method_3());
			this.class531_0.bool_1 = this.bool_9;
			if (this.bool_9)
			{
				this.class531_0.vector2_2 = new Vector2(6f, Math.Max(14f, this.method_3() / this.vector2_2.Y * this.method_3() - 4f));
				this.class531_0.vector2_1 = new Vector2(this.bool_2 ? (2f + this.float_0) : (this.rectangleF_0.Width - 8f - this.float_0), this.method_1() + 2f + this.vector2_3.Y / (this.vector2_2.Y - this.method_3()) * (this.method_3() - this.class531_0.vector2_2.Y - 4f));
			}
		}

		// Token: 0x06002DFA RID: 11770
		// RVA: 0x0012A290 File Offset: 0x00128490
		internal void method_16(RectangleF rectangleF_1)
		{
			Class110.Class758 class = new Class110.Class758();
			class.rectangleF_0 = rectangleF_1;
			this.rectangleF_0 = class.rectangleF_0;
			Class110.Class758 expr_1F_cp_0 = class;
			expr_1F_cp_0.rectangleF_0.Width = expr_1F_cp_0.rectangleF_0.Width + this.vector2_4.X;
			Class110.Class758 expr_3C_cp_0 = class;
			expr_3C_cp_0.rectangleF_0.Height = expr_3C_cp_0.rectangleF_0.Height + this.vector2_4.Y;
			this.class911_0.method_18(class.rectangleF_0);
			this.class911_1.method_18(class.rectangleF_0);
			this.list_0.ForEach(new Action<Class911>(class.method_0));
			this.method_14(this.vector2_2);
		}

		// Token: 0x06002DFB RID: 11771
		// RVA: 0x0012A338 File Offset: 0x00128538
		internal void method_17(Vector2 vector2_6, float float_6)
		{
			this.vector2_3 = new Vector2((float)((!this.bool_2 || !this.bool_1 || !this.bool_3) ? 0 : -8), Class778.smethod_2(vector2_6.Y, this.float_2, Math.Max(this.float_2, this.vector2_2.Y - this.method_3())) * float_6 + vector2_6.Y * (1f - float_6));
			if (float.IsNaN(this.vector2_3.X))
			{
				this.vector2_3.X = 0f;
			}
			if (float.IsNaN(this.vector2_3.Y))
			{
				this.vector2_3.Y = this.float_2;
			}
			this.class911_0.vector2_0 = this.vector2_3;
			this.class911_1.vector2_0 = this.vector2_3;
			this.list_0.ForEach(new Action<Class911>(this.method_34));
			this.method_15();
		}

		// Token: 0x06002DFC RID: 11772
		// RVA: 0x00022C05 File Offset: 0x00020E05
		public void method_18()
		{
			this.method_32(1f);
		}

		// Token: 0x06002DFD RID: 11773
		// RVA: 0x00022C12 File Offset: 0x00020E12
		internal void method_19()
		{
			this.method_32(0f);
		}

		// Token: 0x06002DE9 RID: 11753
		// RVA: 0x00022AB8 File Offset: 0x00020CB8
		internal void method_2(float float_6)
		{
			this.float_1 = float_6;
			this.method_15();
		}

		// Token: 0x06002DFE RID: 11774
		// RVA: 0x0012A434 File Offset: 0x00128634
		private bool method_20(object object_0, EventArgs eventArgs_0)
		{
			this.bool_10 = false;
			this.bool_7 = false;
			if (this.bool_5)
			{
				if (this.bool_6)
				{
					this.vector2_5 = Vector2.get_Zero();
				}
				this.float_3 *= (float)Math.Pow(0.95, Math.Max(0.0, this.double_0 - 66.0));
				this.double_0 = 0.0;
				this.bool_5 = false;
				if (this.voidDelegate_0 != null)
				{
					this.voidDelegate_0();
				}
			}
			return false;
		}

		// Token: 0x06002DFF RID: 11775
		// RVA: 0x0012A4D0 File Offset: 0x001286D0
		private bool method_21(object object_0, EventArgs eventArgs_0)
		{
			if (!this.method_4() || this.bool_10)
			{
				return false;
			}
			if (Class802.bool_29)
			{
				return false;
			}
			if (!this.bool_5)
			{
				if (!this.bool_7 || (!this.class531_0.vmethod_1() && (!this.bool_4 || !this.method_9())))
				{
					this.bool_10 = true;
					return false;
				}
				this.bool_5 = true;
				this.double_0 = 0.0;
				this.bool_6 = !this.class531_0.vmethod_1();
				this.vector2_0 = Class800.smethod_19() * Class115.float_6;
				this.vector2_1 = this.vector2_3 + new Vector2(0f, this.vector2_3.Y - this.method_22().Y);
			}
			if (this.bool_5)
			{
				this.bool_7 = false;
				this.float_5 = ((this.float_3 == 0f) ? 0.5f : (-(float)Math.Max(0.5, 0.99599999189376831 - 0.002 / (double)Math.Abs(this.float_3))));
				Vector2 vector = Class800.smethod_19() * Class115.float_6;
				if (this.vector2_5 != Vector2.get_Zero() && Class115.double_9 > 0.0)
				{
					this.double_0 += Class115.double_9;
					float num = (float)((double)(this.vector2_5.Y - vector.Y) / this.double_0);
					float num2 = (float)Math.Pow((Math.Sign(num) == -Math.Sign(this.float_3) || Math.Abs(num) > Math.Abs(this.float_3)) ? 0.9 : 0.95, this.double_0);
					if (num != 0f)
					{
						this.double_0 = 0.0;
						this.float_3 = this.float_3 * num2 + (1f - num2) * num;
					}
				}
				this.vector2_5 = vector;
				if (this.bool_6)
				{
					this.method_17(this.vector2_1 + (this.vector2_0 - Class800.smethod_19() * Class115.float_6), 0.5f);
				}
				else
				{
					this.method_17(this.vector2_1 + (Class800.smethod_19() * Class115.float_6 - this.vector2_0) * (this.vector2_2.Y - this.method_3()) / (this.method_3() - this.class531_0.vector2_2.Y - 4f), 1f);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002E03 RID: 11779
		// RVA: 0x00022C1F File Offset: 0x00020E1F
		private Vector2 method_22()
		{
			return new Vector2(0f, Class778.smethod_2(this.vector2_3.Y, this.float_2, Math.Max(this.float_2, this.vector2_2.Y - this.method_3())));
		}

		// Token: 0x06002E05 RID: 11781
		// RVA: 0x0012A9F8 File Offset: 0x00128BF8
		internal void method_23(float float_6, float float_7)
		{
			this.float_5 = float_7;
			if (this.float_5 == 0f)
			{
				this.float_5 = -0.98f;
			}
			float num = float_6 - this.vector2_3.Y;
			if (this.float_5 < 0f)
			{
				this.float_3 = (float)Math.Sign(num) * 0.01f - num * (float)Math.Log((double)(-(double)this.float_5));
				return;
			}
			this.float_3 = (float)Math.Sign(num) * (float)Math.Sqrt((double)Math.Abs(num * this.float_5 * 2f));
		}

		// Token: 0x06002E06 RID: 11782
		// RVA: 0x0012AA8C File Offset: 0x00128C8C
		internal float method_24()
		{
			if (this.float_5 == 0f)
			{
				return 0f;
			}
			float num;
			if (this.float_5 < 0f)
			{
				num = this.vector2_3.Y + ((float)Math.Sign(this.float_3) * 0.01f - this.float_3) / (float)Math.Log((double)(-(double)this.float_5));
			}
			else
			{
				num = this.vector2_3.Y + this.float_3 / this.float_5 * (this.float_3 / 2f) * (float)Math.Sign(this.float_3);
			}
			if (float.IsNaN(num))
			{
				throw new Exception(string.Concat(new object[]
				{
					"NaN in TargetHeight. ",
					this.vector2_3.Y,
					" ",
					this.float_3,
					" ",
					this.float_5
				}));
			}
			return num;
		}

		// Token: 0x06002E07 RID: 11783
		// RVA: 0x0012AB88 File Offset: 0x00128D88
		internal void method_25(float float_6, float float_7)
		{
			float num = this.method_24();
			this.method_23(num + float_6, float_7);
		}

		// Token: 0x06002E08 RID: 11784
		// RVA: 0x0012ABA8 File Offset: 0x00128DA8
		internal void method_26(float float_6)
		{
			float float_7 = Math.Max(this.float_2, this.vector2_2.Y - this.method_3());
			this.method_23(float_7, float_6);
		}

		// Token: 0x06002E09 RID: 11785
		// RVA: 0x00022C5E File Offset: 0x00020E5E
		internal void method_27()
		{
			this.float_3 = 0f;
			this.float_5 = -0.98f;
		}

		// Token: 0x06002E0A RID: 11786
		// RVA: 0x0012ABDC File Offset: 0x00128DDC
		private float method_28()
		{
			if (this.bool_5)
			{
				return 0f;
			}
			float num = this.float_3;
			float num2 = this.method_22().Y - this.vector2_3.Y;
			if (num2 != 0f && !this.bool_5)
			{
				double num3 = 1.0 - 0.2 * this.double_1;
				if (Math.Sign(this.float_3) != Math.Sign(num2))
				{
					this.float_3 *= (float)Math.Pow(num3, Class115.double_0);
				}
				num = ((this.float_3 == num || Class115.double_0 <= 0.0) ? this.float_3 : ((this.float_3 - num) / (float)(Class115.double_0 * Math.Log(num3))));
			}
			else if (this.float_5 < 0f)
			{
				float num4 = (Math.Abs(this.float_3) <= 0.01f) ? 0f : ((float)Math.Log((double)(0.01f / Math.Abs(this.float_3)), (double)(-(double)this.float_5)));
				float num5 = (float)Math.Min((double)num4, Class115.double_9);
				this.float_3 *= (float)Math.Pow((double)(-(double)this.float_5), (double)num5);
				float arg_175_0;
				if (num5 > 0f)
				{
					if (this.float_3 != num)
					{
						arg_175_0 = (this.float_3 - num) / (float)((double)num5 * Math.Log((double)(-(double)this.float_5)));
						goto IL_175;
					}
				}
				arg_175_0 = this.float_3;
				IL_175:
				num = arg_175_0;
				num *= num5 / (float)Class115.double_9;
			}
			else if (this.float_5 > 0f)
			{
				float num6 = Math.Abs(this.float_3) / this.float_5;
				if (this.float_3 > 0f)
				{
					this.float_3 = Math.Max(0f, this.float_3 - this.float_5 * (float)Class115.double_9);
				}
				else if (this.float_3 < 0f)
				{
					this.float_3 = Math.Min(0f, this.float_3 + this.float_5 * (float)Class115.double_9);
				}
				num = (num + this.float_3) * Math.Min(num6 / (float)Class115.double_9, 1f) / 2f;
			}
			if (Math.Abs(num) <= 0.01f && Math.Abs(this.float_3) <= 0.01f && (double)Math.Abs(num2) < 0.5)
			{
				this.method_17(this.method_22(), 0f);
				num = 0f;
				this.float_3 = 0f;
				this.float_5 = -0.98f;
			}
			else if (Class115.double_9 > 0.0)
			{
				float num7 = num2 - num2 * (float)Math.Pow(1.0 - 0.005 * this.double_1, Class115.double_9);
				num += num7 / (float)Class115.double_9;
			}
			return num;
		}

		// Token: 0x06002E0B RID: 11787
		// RVA: 0x0012AEC4 File Offset: 0x001290C4
		public void method_29(bool bool_11)
		{
			this.class911_0.Clear(true);
			this.class911_1.Clear(true);
			this.class911_0.Add(this.class531_0);
			if (bool_11)
			{
				this.method_14(Vector2.get_Zero());
			}
			List<Class911> arg_5A_0 = this.list_0;
			if (Class110.action_1 == null)
			{
				Class110.action_1 = new Action<Class911>(Class110.smethod_1);
			}
			arg_5A_0.ForEach(Class110.action_1);
		}

		// Token: 0x06002DEA RID: 11754
		// RVA: 0x00022AC7 File Offset: 0x00020CC7
		internal float method_3()
		{
			return this.rectangleF_0.Height - this.float_1;
		}

		// Token: 0x06002E0C RID: 11788
		// RVA: 0x00022C76 File Offset: 0x00020E76
		internal void method_30(Class911 class911_2)
		{
			class911_2.method_18(this.rectangleF_0);
			class911_2.bool_14 = this.method_5();
			this.list_0.Add(class911_2);
		}

		// Token: 0x06002E0D RID: 11789
		// RVA: 0x00022C9C File Offset: 0x00020E9C
		public float method_31()
		{
			return this.class911_0.float_0;
		}

		// Token: 0x06002E0E RID: 11790
		// RVA: 0x0012AF30 File Offset: 0x00129130
		public void method_32(float float_6)
		{
			Class110.Class759 class = new Class110.Class759();
			class.float_0 = float_6;
			this.class911_0.float_0 = class.float_0;
			this.class911_1.float_0 = class.float_0;
			this.list_0.ForEach(new Action<Class911>(class.method_0));
		}

		// Token: 0x06002E0F RID: 11791
		// RVA: 0x0012AF84 File Offset: 0x00129184
		internal void method_33()
		{
			Class802.smethod_36(Enum96.const_8, new Delegate46(this.method_10), this.enum98_0, this.enum97_0);
			Class802.smethod_36(Enum96.const_6, new Delegate46(this.method_11), this.enum98_0, this.enum97_0);
			Class802.smethod_36(Enum96.const_3, new Delegate46(this.method_21), this.enum98_0, this.enum97_0);
			Class802.smethod_36(Enum96.const_2, new Delegate46(this.method_20), this.enum98_0, this.enum97_0);
			Class802.smethod_36(Enum96.const_1, new Delegate46(this.method_13), this.enum98_0, this.enum97_0);
			Class802.smethod_36(Enum96.const_0, new Delegate46(this.method_12), this.enum98_0, this.enum97_0);
		}

		// Token: 0x06002E10 RID: 11792
		// RVA: 0x00022CA9 File Offset: 0x00020EA9
		[CompilerGenerated]
		private void method_34(Class911 class911_2)
		{
			class911_2.vector2_1 = this.vector2_3;
		}

		// Token: 0x06002DEB RID: 11755
		// RVA: 0x00022ADB File Offset: 0x00020CDB
		internal bool method_4()
		{
			return this.method_31() >= 0.01f;
		}

		// Token: 0x06002DEC RID: 11756
		// RVA: 0x00022AED File Offset: 0x00020CED
		internal bool method_5()
		{
			return this.class911_0.bool_14;
		}

		// Token: 0x06002DED RID: 11757
		// RVA: 0x00022AFA File Offset: 0x00020CFA
		internal void method_6(bool bool_11)
		{
			this.class911_0.bool_14 = bool_11;
			this.class911_1.bool_14 = bool_11;
		}

		// Token: 0x06002DEF RID: 11759
		// RVA: 0x00129ED8 File Offset: 0x001280D8
		internal void method_7(VoidDelegate voidDelegate_1)
		{
			VoidDelegate voidDelegate = this.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_1);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06002DF0 RID: 11760
		// RVA: 0x00022B30 File Offset: 0x00020D30
		internal bool method_8()
		{
			return this.class531_0.vmethod_1();
		}

		// Token: 0x06002DF3 RID: 11763
		// RVA: 0x00022B70 File Offset: 0x00020D70
		internal bool method_9()
		{
			return this.method_4() && this.class911_0.rectangleF_3.Contains((float)Class800.smethod_15().X, (float)Class800.smethod_15().Y);
		}

		// Token: 0x06002E11 RID: 11793
		// RVA: 0x00022CB7 File Offset: 0x00020EB7
		[CompilerGenerated]
		private static void smethod_0(Class911 class911_2)
		{
			class911_2.Dispose();
		}

		// Token: 0x06002E12 RID: 11794
		// RVA: 0x00022CBF File Offset: 0x00020EBF
		[CompilerGenerated]
		private static void smethod_1(Class911 class911_2)
		{
			class911_2.Clear(true);
		}

		// Token: 0x06002DEE RID: 11758
		// RVA: 0x00022B14 File Offset: 0x00020D14
		internal virtual bool vmethod_0()
		{
			return Math.Abs(this.float_3) > 0.01f || this.bool_5;
		}
	}
}
