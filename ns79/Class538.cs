using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns77;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Threading;

namespace ns79
{
	// Token: 0x0200057E RID: 1406
	internal sealed class Class538 : Class531
	{
		// Token: 0x0400259A RID: 9626
		public bool bool_15;

		// Token: 0x0400259C RID: 9628
		internal bool bool_16 = true;

		// Token: 0x040025A2 RID: 9634
		private bool bool_17 = true;

		// Token: 0x040025A3 RID: 9635
		private bool bool_18;

		// Token: 0x040025A4 RID: 9636
		private Class731[] class731_1;

		// Token: 0x040025A0 RID: 9632
		private double double_0 = 16.666666666666668;

		// Token: 0x040025A1 RID: 9633
		private double double_1;

		// Token: 0x040025A5 RID: 9637
		private int[] int_10;

		// Token: 0x0400259D RID: 9629
		internal int int_7;

		// Token: 0x0400259E RID: 9630
		private int int_8;

		// Token: 0x0400259F RID: 9631
		private int int_9;

		// Token: 0x0400259B RID: 9627
		public LoopTypes loopTypes_0;

		// Token: 0x040025A6 RID: 9638
		private VoidDelegate voidDelegate_1;

		// Token: 0x06002D2A RID: 11562
		// RVA: 0x001258C4 File Offset: 0x00123AC4
		internal Class538(Class731[] class731_2, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9, float float_7, bool bool_19, Color color_2) : this(class731_2, enum115_1, origins_1, enum114_1, vector2_9, float_7, bool_19, color_2, null)
		{
		}

		// Token: 0x06002D2B RID: 11563
		// RVA: 0x001258E8 File Offset: 0x00123AE8
		internal Class538(Class731[] class731_2, Enum115 enum115_1, Origins origins_1, Enum114 enum114_1, Vector2 vector2_9, float float_7, bool bool_19, Color color_2, object object_1) : base((class731_2 == null || class731_2.Length == 0) ? null : class731_2[0], enum115_1, origins_1, enum114_1, vector2_9, float_7, bool_19, color_2, object_1)
		{
			if (class731_2 != null)
			{
				this.method_55(class731_2);
			}
		}

		// Token: 0x06002D3B RID: 11579
		// RVA: 0x00125D8C File Offset: 0x00123F8C
		public override Class531 Clone()
		{
			Class538 class = new Class538(this.method_54(), this.enum115_0, this.origins_0, this.enum114_0, this.vector2_0, this.float_0, this.bool_0, this.color_0, this.object_0);
			class.method_53(this.method_52());
			class.loopTypes_0 = this.loopTypes_0;
			foreach (Class746 current in this.class26_0)
			{
				class.class26_0.Add(current.Clone());
			}
			return class;
		}

		// Token: 0x06002D29 RID: 11561
		// RVA: 0x0012588C File Offset: 0x00123A8C
		internal void method_49(VoidDelegate voidDelegate_2)
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

		// Token: 0x06002D2D RID: 11565
		// RVA: 0x001259D0 File Offset: 0x00123BD0
		internal void method_50(int int_11)
		{
			if (int_11 < 0)
			{
				int_11 = 0;
			}
			this.int_8 = ((this.loopTypes_0 == LoopTypes.LoopOnce) ? Math.Min(int_11, this.method_51()) : (int_11 % (this.method_51() + 1)));
			double num = (double)Class911.smethod_0(this);
			int num2 = this.vmethod_4() ? (int_11 - this.int_8 + (this.method_51() - this.int_8)) : int_11;
			this.double_1 = num - (double)num2 * this.double_0;
			this.bool_17 = false;
		}

		// Token: 0x06002D2E RID: 11566
		// RVA: 0x00022288 File Offset: 0x00020488
		public int method_51()
		{
			if (this.method_58())
			{
				return this.method_56().Length - 1;
			}
			return this.int_7 - 1;
		}

		// Token: 0x06002D2F RID: 11567
		// RVA: 0x000222A5 File Offset: 0x000204A5
		internal double method_52()
		{
			return this.double_0;
		}

		// Token: 0x06002D30 RID: 11568
		// RVA: 0x00125A50 File Offset: 0x00123C50
		internal void method_53(double double_2)
		{
			if (this.double_0 == double_2)
			{
				return;
			}
			if (!this.bool_17 && this.double_0 > 0.0)
			{
				double num = (double)Class911.smethod_0(this);
				if (this.double_1 < num)
				{
					double num2 = (num - this.double_1) / this.double_0;
					this.double_1 = ((this.loopTypes_0 != LoopTypes.LoopOnce || num2 <= (double)this.method_51()) ? (num - num2 * double_2) : (this.double_1 + (double)this.method_51() * this.double_0 - (double)this.method_51() * double_2));
				}
			}
			this.double_0 = double_2;
		}

		// Token: 0x06002D31 RID: 11569
		// RVA: 0x000222AD File Offset: 0x000204AD
		internal Class731[] method_54()
		{
			return this.class731_1;
		}

		// Token: 0x06002D32 RID: 11570
		// RVA: 0x00125AE8 File Offset: 0x00123CE8
		internal void method_55(Class731[] class731_2)
		{
			if (class731_2 == this.class731_1)
			{
				return;
			}
			this.class731_1 = class731_2;
			if (this.class731_1 != null)
			{
				this.int_7 = this.class731_1.Length;
				if (this.int_7 > 0)
				{
					base.vmethod_7(this.class731_1[0]);
				}
				else
				{
					base.vmethod_7(null);
				}
			}
			else
			{
				this.int_7 = 0;
			}
			this.int_9 = 0;
			this.method_59();
		}

		// Token: 0x06002D33 RID: 11571
		// RVA: 0x000222B5 File Offset: 0x000204B5
		internal int[] method_56()
		{
			return this.int_10;
		}

		// Token: 0x06002D34 RID: 11572
		// RVA: 0x000222BD File Offset: 0x000204BD
		internal void method_57(int[] int_11)
		{
			if (this.int_10 == int_11)
			{
				return;
			}
			this.int_10 = int_11;
			this.method_59();
		}

		// Token: 0x06002D35 RID: 11573
		// RVA: 0x000222D6 File Offset: 0x000204D6
		public bool method_58()
		{
			return this.method_56() != null;
		}

		// Token: 0x06002D37 RID: 11575
		// RVA: 0x000222FE File Offset: 0x000204FE
		internal void method_59()
		{
			this.bool_17 = true;
			this.bool_18 = false;
			this.int_8 = (this.vmethod_4() ? this.method_51() : 0);
		}

		// Token: 0x06002D39 RID: 11577
		// RVA: 0x00125B74 File Offset: 0x00123D74
		internal void method_60()
		{
			if (this.int_7 < 2)
			{
				return;
			}
			if (this.bool_16 && this.double_0 > 0.0)
			{
				double num = (double)Class911.smethod_0(this);
				if (!this.bool_17 && num < this.double_1)
				{
					this.method_59();
				}
				if (this.bool_17)
				{
					this.double_1 = ((this.class26_0.Count > 0) ? ((double)this.class26_0[0].int_0) : num);
					this.bool_17 = false;
				}
				double num2 = num - this.double_1;
				int num3 = (int)Math.Floor(num2 / this.double_0);
				if (num3 < 0)
				{
					num3 = 0;
				}
				bool flag = false;
				if (this.loopTypes_0 == LoopTypes.LoopOnce)
				{
					if (num3 > this.method_51())
					{
						num3 = this.method_51();
						if (!this.bool_18)
						{
							this.bool_18 = true;
							flag = true;
						}
					}
					else
					{
						this.bool_18 = false;
					}
				}
				else
				{
					num3 %= this.method_51() + 1;
					this.bool_18 = false;
				}
				this.int_8 = (this.vmethod_4() ? (this.method_51() - num3) : num3);
				if (flag && this.voidDelegate_1 != null)
				{
					this.voidDelegate_1();
				}
			}
			else
			{
				this.method_50(Class778.smethod_1(this.int_8, 0, this.method_51()));
			}
			if (this.int_9 != this.int_8)
			{
				this.class731_0 = (this.method_58() ? this.method_54()[Math.Min(this.method_54().Length - 1, this.method_56()[this.int_8])] : this.method_54()[this.int_8]);
				if (this.vmethod_6() != null)
				{
					if (!this.bool_15)
					{
						this.vmethod_8();
					}
					if (this.origins_0 != Origins.TopLeft)
					{
						this.vmethod_9();
					}
				}
				this.int_9 = this.int_8;
			}
		}

		// Token: 0x06002D3A RID: 11578
		// RVA: 0x00125D30 File Offset: 0x00123F30
		internal void method_61()
		{
			if (Class885.class547_0 == null || this.class731_1 == null)
			{
				return;
			}
			if (Class885.class547_0.int_4 > 0)
			{
				this.method_53((double)(1000f / (float)Class885.class547_0.int_4));
				return;
			}
			this.method_53((double)(1000f / (float)this.method_54().Length));
		}

		// Token: 0x06002D38 RID: 11576
		// RVA: 0x00125B54 File Offset: 0x00123D54
		public override Enum51 vmethod_3()
		{
			Enum51 enum = base.vmethod_3();
			if (enum != Enum51.const_0)
			{
				return enum;
			}
			this.method_60();
			return Enum51.const_0;
		}

		// Token: 0x06002D2C RID: 11564
		// RVA: 0x00125940 File Offset: 0x00123B40
		internal override void vmethod_5(bool bool_19)
		{
			if (base.vmethod_4() == bool_19)
			{
				return;
			}
			if (!this.bool_17 && this.double_0 > 0.0)
			{
				double num = (double)Class911.smethod_0(this);
				if (this.double_1 < num)
				{
					int num2 = this.method_51() + 1;
					double num3 = (num - this.double_1) / this.double_0;
					double num4 = Math.Floor(num3 / (double)num2) * (double)num2;
					double num5 = (double)this.method_51() - (num3 - num4);
					this.double_1 = num - (num4 + num5) * this.double_0;
				}
			}
			base.vmethod_5(bool_19);
		}

		// Token: 0x06002D36 RID: 11574
		// RVA: 0x000222E4 File Offset: 0x000204E4
		internal override Class731 vmethod_6()
		{
			if (this.method_54() != null && this.int_7 != 0)
			{
				return this.class731_0;
			}
			return null;
		}
	}
}
