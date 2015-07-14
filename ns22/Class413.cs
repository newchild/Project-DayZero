using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns26;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns22
{
	// Token: 0x020003C2 RID: 962
	internal class Class413
	{
		// Token: 0x040017C4 RID: 6084
		internal Class536 class536_0;

		// Token: 0x040017C5 RID: 6085
		internal Class536 class536_1;

		// Token: 0x040017C3 RID: 6083
		protected readonly Class911 class911_0;

		// Token: 0x040017C6 RID: 6086
		internal int int_0;

		// Token: 0x040017C7 RID: 6087
		internal int int_1;

		// Token: 0x040017CA RID: 6090
		[CompilerGenerated]
		private int int_2;

		// Token: 0x040017CB RID: 6091
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x040017CC RID: 6092
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x040017C8 RID: 6088
		private string string_0;

		// Token: 0x040017C9 RID: 6089
		private VoidDelegate voidDelegate_0;

		// Token: 0x06001E07 RID: 7687
		// RVA: 0x00018AA0 File Offset: 0x00016CA0
		public Class413(Class911 class911_1, string string_1)
		{
			this.class911_0 = class911_1;
			this.string_0 = ((string_1 != "") ? string_1 : Class885.class547_0.string_5);
			this.vmethod_2();
		}

		// Token: 0x06001E0F RID: 7695
		// RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		private void method_0()
		{
			this.class536_0.Text = this.class536_1.Text;
			List<Class746> arg_3E_0 = this.class536_0.class26_0;
			if (Class413.predicate_0 == null)
			{
				Class413.predicate_0 = new Predicate<Class746>(Class413.smethod_0);
			}
			arg_3E_0.RemoveAll(Class413.predicate_0);
			Class746 class = new Class746(TransformationType.Scale, 1.28f, 1.4f, Class115.int_1, Class115.int_1 + 50, Enum70.const_0);
			class.enum70_0 = Enum70.const_2;
			this.class536_0.class26_0.Add(class);
			class = new Class746(TransformationType.Scale, 1.4f, 1.28f, Class115.int_1 + 50, Class115.int_1 + 100, Enum70.const_0);
			class.enum70_0 = Enum70.const_1;
			this.class536_0.class26_0.Add(class);
		}

		// Token: 0x06001E12 RID: 7698
		// RVA: 0x00018B2C File Offset: 0x00016D2C
		internal void method_1(int int_3)
		{
			if (int_3 > 0 && Math.Abs(this.vmethod_0() - int_3) > 10)
			{
				this.int_0 = int_3;
			}
			this.vmethod_1(int_3);
		}

		// Token: 0x06001E13 RID: 7699
		// RVA: 0x000A3E50 File Offset: 0x000A2050
		internal void method_2(VoidDelegate voidDelegate_1)
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

		// Token: 0x06001E0D RID: 7693
		// RVA: 0x00018B1C File Offset: 0x00016D1C
		internal void Reset()
		{
			this.vmethod_1(0);
			this.int_0 = 0;
		}

		// Token: 0x06001E14 RID: 7700
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06001E15 RID: 7701
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_1(Class746 class746_0)
		{
			return class746_0.byte_0 == 1;
		}

		// Token: 0x06001E05 RID: 7685
		// RVA: 0x00018A8F File Offset: 0x00016C8F
		[CompilerGenerated]
		internal virtual int vmethod_0()
		{
			return this.int_2;
		}

		// Token: 0x06001E06 RID: 7686
		// RVA: 0x00018A97 File Offset: 0x00016C97
		[CompilerGenerated]
		internal virtual void vmethod_1(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x06001E08 RID: 7688
		// RVA: 0x000A3970 File Offset: 0x000A1B70
		protected virtual void vmethod_2()
		{
			this.class536_0 = new Class536(this.vmethod_3(), this.string_0, Class885.class547_0.int_2, Enum115.const_5, Origins.Custom, Enum114.const_0, new Vector2(2f, 472f), 0.92f, true, Color.get_TransparentWhite(), true);
			this.class536_0.vector2_5 = new Vector2(0f, this.class536_0.vmethod_11().Y * 0.625f + 9f);
			this.class536_0.float_2 = 1.28f;
			this.class536_1 = new Class536("0x", this.string_0, Class885.class547_0.int_2, Enum115.const_5, Origins.Custom, Enum114.const_0, new Vector2(2f, 472f), 0.91f, true, Color.get_TransparentWhite(), true);
			this.class536_1.vector2_5 = new Vector2(3f, this.class536_1.vmethod_11().Y * 0.625f + 9f);
			this.class536_1.bool_7 = true;
			this.class536_1.float_2 = 1.28f;
			if ((!Class62.bool_15 && !Class62.bool_16) || Class62.Mode == PlayModes.Taiko)
			{
				this.class911_0.Add(this.class536_0);
				this.class911_0.Add(this.class536_1);
			}
		}

		// Token: 0x06001E09 RID: 7689
		// RVA: 0x00018AD5 File Offset: 0x00016CD5
		protected virtual string vmethod_3()
		{
			return this.int_0 + "x";
		}

		// Token: 0x06001E0A RID: 7690
		// RVA: 0x000A3AC0 File Offset: 0x000A1CC0
		internal virtual void vmethod_4()
		{
			this.class536_0.method_16(1000, Enum70.const_0);
			this.class536_0.method_19(this.class536_0.vector2_0 - new Vector2(80f, 0f), 1000, Enum70.const_2);
		}

		// Token: 0x06001E0B RID: 7691
		// RVA: 0x00018AEC File Offset: 0x00016CEC
		internal virtual void vmethod_5()
		{
			this.class536_0.method_14(1000, Enum70.const_0);
			this.class536_0.method_19(this.class536_0.vector2_0, 1000, Enum70.const_1);
		}

		// Token: 0x06001E0C RID: 7692
		// RVA: 0x000A3B10 File Offset: 0x000A1D10
		internal virtual void vmethod_6()
		{
			if (this.int_0 != 0 && this.class536_0.float_3 == 0f)
			{
				this.class536_0.method_14(120, Enum70.const_0);
				return;
			}
			if (this.int_0 == 0 && this.vmethod_0() == 0 && this.class536_0.float_3 == 1f)
			{
				this.class536_0.method_16(120, Enum70.const_0);
			}
		}

		// Token: 0x06001E0E RID: 7694
		// RVA: 0x000A3B78 File Offset: 0x000A1D78
		internal virtual void vmethod_7()
		{
			if (this.vmethod_0() < this.int_0)
			{
				if (!Class331.smethod_71() && this.vmethod_0() != 0)
				{
					this.int_0 = this.vmethod_0();
				}
				else if (Class115.bool_13)
				{
					this.int_0--;
				}
				this.vmethod_8();
			}
			else if (this.vmethod_0() > this.int_0)
			{
				this.int_0++;
				bool bool_ = this.class536_0.Text != this.class536_1.Text;
				this.class536_0.Text = this.class536_1.Text;
				this.vmethod_9(bool_);
				if (this.voidDelegate_0 != null)
				{
					this.voidDelegate_0();
				}
			}
			this.class536_1.Text = this.vmethod_3();
			if (this.class536_1.class26_0.Count > 0)
			{
				if (this.class536_1.class26_0[0].int_1 < Class115.int_1 + 140 && this.class536_0.Text != this.class536_1.Text)
				{
					this.method_0();
					return;
				}
			}
			else if (this.class536_0.Text != this.class536_1.Text)
			{
				this.class536_0.Text = this.class536_1.Text;
			}
		}

		// Token: 0x06001E10 RID: 7696
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_8()
		{
		}

		// Token: 0x06001E11 RID: 7697
		// RVA: 0x000A3D98 File Offset: 0x000A1F98
		protected virtual void vmethod_9(bool bool_0)
		{
			if (bool_0)
			{
				this.method_0();
			}
			List<Class746> arg_31_0 = this.class536_1.class26_0;
			if (Class413.predicate_1 == null)
			{
				Class413.predicate_1 = new Predicate<Class746>(Class413.smethod_1);
			}
			arg_31_0.RemoveAll(Class413.predicate_1);
			this.class536_1.class26_0.Add(new Class746(TransformationType.Scale, 2f, 1.28f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0)
			{
				byte_0 = 1
			});
			this.class536_1.class26_0.Add(new Class746(TransformationType.Fade, 0.6f, 0f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0)
			{
				byte_0 = 1
			});
		}
	}
}
