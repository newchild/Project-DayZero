using Microsoft.Xna.Framework;
using ns18;
using ns29;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020004F9 RID: 1273
	internal sealed class Class412 : Class410
	{
		// Token: 0x04002205 RID: 8709
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04002206 RID: 8710
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04002203 RID: 8707
		private bool bool_3;

		// Token: 0x04002204 RID: 8708
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x060028F3 RID: 10483
		// RVA: 0x001027B4 File Offset: 0x001009B4
		internal Class412(Class911 class911_1) : base(class911_1)
		{
			this.bool_0 = false;
			this.class531_1.vector2_1 = new Vector2(this.class538_0.vector2_1.X + (float)this.class538_0.int_6 * Class115.float_5, this.class531_1.vector2_1.Y);
			this.class531_1.class26_0.Add(new Class746(TransformationType.Scale, 0f, 1f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_1));
			this.class531_1.class26_0.Add(new Class746(TransformationType.Rotation, -4f, 0f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_1));
		}

		// Token: 0x060028FB RID: 10491
		// RVA: 0x00102880 File Offset: 0x00100A80
		private void method_10()
		{
			if (Class62.bool_15)
			{
				return;
			}
			if (base.method_2() == 200.0 == this.bool_3)
			{
				return;
			}
			this.bool_3 = (base.method_2() == 200.0);
			if (this.bool_3)
			{
				Class531 class = this.class538_0.Clone();
				class.bool_7 = true;
				class.float_0 += 0.01f;
				Class746 class2 = new Class746(TransformationType.Fade, 0.2f, 1f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
				class2.bool_0 = true;
				class2.int_2 = 1000;
				class.class26_0.Add(class2);
				class2 = new Class746(TransformationType.Fade, 1f, 0.12f, Class115.int_1 + 1000, Class115.int_1 + 2000, Enum70.const_0);
				class2.bool_0 = true;
				class2.int_2 = 1000;
				class.class26_0.Add(class2);
				this.list_1.Add(class);
				this.class531_1.bool_7 = true;
				this.list_1.Add(class);
				this.class911_0.Add<Class531>(this.list_1);
				return;
			}
			List<Class531> arg_148_0 = this.list_1;
			if (Class412.action_3 == null)
			{
				Class412.action_3 = new Action<Class531>(Class412.smethod_5);
			}
			arg_148_0.ForEach(Class412.action_3);
			this.list_1.Clear();
			this.class531_1.bool_7 = false;
		}

		// Token: 0x060028FD RID: 10493
		// RVA: 0x0001F82A File Offset: 0x0001DA2A
		internal override void Reset()
		{
			base.Reset();
			this.vmethod_10(0.0);
		}

		// Token: 0x060028FE RID: 10494
		// RVA: 0x00018A43 File Offset: 0x00016C43
		[CompilerGenerated]
		private static void smethod_4(Class531 class531_3)
		{
			class531_3.method_16(100, Enum70.const_0);
		}

		// Token: 0x060028FF RID: 10495
		// RVA: 0x0001F841 File Offset: 0x0001DA41
		[CompilerGenerated]
		private static void smethod_5(Class531 class531_3)
		{
			class531_3.method_16(50, Enum70.const_0);
			class531_3.bool_0 = false;
		}

		// Token: 0x060028F6 RID: 10486
		// RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		protected override void vmethod_0(bool bool_4)
		{
			if (!bool_4)
			{
				List<Class531> arg_26_0 = this.list_1;
				if (Class412.action_2 == null)
				{
					Class412.action_2 = new Action<Class531>(Class412.smethod_4);
				}
				arg_26_0.ForEach(Class412.action_2);
			}
			base.vmethod_0(bool_4);
		}

		// Token: 0x060028F9 RID: 10489
		// RVA: 0x00018A65 File Offset: 0x00016C65
		protected override Class731[] vmethod_1(string string_0)
		{
			return Class885.smethod_27(string_0, Enum112.flag_5, true);
		}

		// Token: 0x060028FC RID: 10492
		// RVA: 0x0001F811 File Offset: 0x0001DA11
		internal override void vmethod_11(double double_5)
		{
			base.vmethod_11(double_5 * 0.06);
			this.method_10();
		}

		// Token: 0x060028F7 RID: 10487
		// RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		internal override void vmethod_12(double double_5)
		{
			base.vmethod_12(double_5 * 0.06);
			this.method_10();
		}

		// Token: 0x060028F8 RID: 10488
		// RVA: 0x00018A6F File Offset: 0x00016C6F
		protected override Class731 vmethod_2(string string_0)
		{
			return Class885.Load(string_0, Enum112.flag_5);
		}

		// Token: 0x060028F5 RID: 10485
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_3()
		{
		}

		// Token: 0x060028F4 RID: 10484
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x060028FA RID: 10490
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_6()
		{
		}
	}
}
