using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns29;
using ns69;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003C3 RID: 963
	internal sealed class Class414 : Class413
	{
		// Token: 0x040017D3 RID: 6099
		[CompilerGenerated]
		private static Action<Class414> action_0;

		// Token: 0x040017D4 RID: 6100
		[CompilerGenerated]
		private static Action<Class414> action_1;

		// Token: 0x040017D5 RID: 6101
		[CompilerGenerated]
		private static Action<Class414> action_2;

		// Token: 0x040017D6 RID: 6102
		[CompilerGenerated]
		private static Action<Class414> action_3;

		// Token: 0x040017CF RID: 6095
		private bool bool_0;

		// Token: 0x040017D0 RID: 6096
		private bool bool_1 = true;

		// Token: 0x040017D2 RID: 6098
		private Class421 class421_0;

		// Token: 0x040017CD RID: 6093
		private Color color_0;

		// Token: 0x040017CE RID: 6094
		private Color color_1;

		// Token: 0x040017D1 RID: 6097
		private List<Class414> list_0 = new List<Class414>();

		// Token: 0x040017D7 RID: 6103
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x06001E18 RID: 7704
		// RVA: 0x000A3E88 File Offset: 0x000A2088
		public Class414(Class911 class911_1, Class421 class421_1, bool bool_2) : base(class911_1, Class885.class547_0.string_5)
		{
			this.class421_0 = class421_1;
			this.class536_0.vector2_1 = new Vector2(class421_1.method_23() + class421_1.float_0 / 2f, class421_1.method_41((float)class421_1.class546_0.int_2));
			this.class536_0.vector2_5 = Vector2.get_Zero();
			this.class536_0.origins_0 = Origins.Centre;
			if (Class885.class547_0.double_0 >= 2.4 || class421_1.method_31() < 1f)
			{
				this.class536_0.float_2 = class421_1.method_33();
			}
			this.class536_0.bool_21 = true;
			this.color_0 = class421_1.class546_0.method_8("Hold", new Color(255, 199, 51));
			this.color_1 = class421_1.class546_0.method_8("Break", Color.get_Red());
			if (!bool_2)
			{
				return;
			}
			if (class421_1.method_3() != null)
			{
				foreach (Class421 current in class421_1.method_3())
				{
					this.list_0.Add(new Class414(class911_1, current, false));
				}
			}
		}

		// Token: 0x06001E20 RID: 7712
		// RVA: 0x00018C37 File Offset: 0x00016E37
		[CompilerGenerated]
		private void method_3(Class414 class414_0)
		{
			class414_0.vmethod_1(this.vmethod_0());
		}

		// Token: 0x06001E21 RID: 7713
		// RVA: 0x00018C45 File Offset: 0x00016E45
		[CompilerGenerated]
		private static void smethod_2(Class414 class414_0)
		{
			class414_0.vmethod_4();
		}

		// Token: 0x06001E22 RID: 7714
		// RVA: 0x00018C4D File Offset: 0x00016E4D
		[CompilerGenerated]
		private static void smethod_3(Class414 class414_0)
		{
			class414_0.vmethod_6();
		}

		// Token: 0x06001E23 RID: 7715
		// RVA: 0x00018C55 File Offset: 0x00016E55
		[CompilerGenerated]
		private static void smethod_4(Class414 class414_0)
		{
			class414_0.vmethod_5();
		}

		// Token: 0x06001E24 RID: 7716
		// RVA: 0x00018C5D File Offset: 0x00016E5D
		[CompilerGenerated]
		private static void smethod_5(Class414 class414_0)
		{
			class414_0.vmethod_7();
		}

		// Token: 0x06001E25 RID: 7717
		// RVA: 0x00018B51 File Offset: 0x00016D51
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_0)
		{
			return class746_0.byte_0 == 1;
		}

		// Token: 0x06001E16 RID: 7702
		// RVA: 0x00018B5C File Offset: 0x00016D5C
		internal override int vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x06001E17 RID: 7703
		// RVA: 0x00018B64 File Offset: 0x00016D64
		internal override void vmethod_1(int int_3)
		{
			base.vmethod_1(int_3);
			this.list_0.ForEach(new Action<Class414>(this.method_3));
		}

		// Token: 0x06001E19 RID: 7705
		// RVA: 0x00018B84 File Offset: 0x00016D84
		protected override string vmethod_3()
		{
			return this.int_0.ToString();
		}

		// Token: 0x06001E1A RID: 7706
		// RVA: 0x00018B91 File Offset: 0x00016D91
		internal override void vmethod_4()
		{
			this.class536_0.method_16(500, Enum70.const_0);
			List<Class414> arg_34_0 = this.list_0;
			if (Class414.action_0 == null)
			{
				Class414.action_0 = new Action<Class414>(Class414.smethod_2);
			}
			arg_34_0.ForEach(Class414.action_0);
		}

		// Token: 0x06001E1C RID: 7708
		// RVA: 0x00018BFC File Offset: 0x00016DFC
		internal override void vmethod_5()
		{
			this.class536_0.method_14(500, Enum70.const_0);
			List<Class414> arg_34_0 = this.list_0;
			if (Class414.action_2 == null)
			{
				Class414.action_2 = new Action<Class414>(Class414.smethod_4);
			}
			arg_34_0.ForEach(Class414.action_2);
		}

		// Token: 0x06001E1B RID: 7707
		// RVA: 0x00018BCC File Offset: 0x00016DCC
		internal override void vmethod_6()
		{
			base.vmethod_6();
			List<Class414> arg_29_0 = this.list_0;
			if (Class414.action_1 == null)
			{
				Class414.action_1 = new Action<Class414>(Class414.smethod_3);
			}
			arg_29_0.ForEach(Class414.action_1);
		}

		// Token: 0x06001E1D RID: 7709
		// RVA: 0x000A3FEC File Offset: 0x000A21EC
		internal override void vmethod_7()
		{
			base.vmethod_7();
			if (Class62.bool_8 && !this.bool_0)
			{
				this.bool_0 = true;
				this.class536_0.class26_0.Add(new Class746(Color.get_White(), this.color_0, Class115.int_1, Class115.int_1 + 300));
			}
			else if (!Class62.bool_8 && this.bool_0)
			{
				this.bool_0 = false;
				this.class536_0.class26_0.Add(new Class746(this.color_0, Color.get_White(), Class115.int_1, Class115.int_1 + 300));
			}
			List<Class414> arg_B7_0 = this.list_0;
			if (Class414.action_3 == null)
			{
				Class414.action_3 = new Action<Class414>(Class414.smethod_5);
			}
			arg_B7_0.ForEach(Class414.action_3);
		}

		// Token: 0x06001E1F RID: 7711
		// RVA: 0x000A4154 File Offset: 0x000A2354
		protected override void vmethod_8()
		{
			if (this.vmethod_0() == 0 && this.bool_1)
			{
				this.bool_1 = false;
				Class536 class = new Class536(this.class536_0.Text, Class885.class547_0.string_5, Class885.class547_0.int_1, Enum115.const_5, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.915f, true, this.color_1, true);
				class.vector2_1 = this.class536_0.vector2_1;
				class.vector2_5 = Vector2.get_Zero();
				class.class26_0.Add(new Class746(TransformationType.Fade, 0.8f, 0f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0));
				class.class26_0.Add(new Class746(TransformationType.Scale, 1f, 4f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0));
				this.class911_0.Add(class);
			}
		}

		// Token: 0x06001E1E RID: 7710
		// RVA: 0x000A40B8 File Offset: 0x000A22B8
		protected override void vmethod_9(bool bool_2)
		{
			this.bool_1 = true;
			List<Class746> arg_2F_0 = this.class536_0.class26_0;
			if (Class414.predicate_2 == null)
			{
				Class414.predicate_2 = new Predicate<Class746>(Class414.smethod_6);
			}
			arg_2F_0.RemoveAll(Class414.predicate_2);
			Class746 class = new Class746(TransformationType.VectorScale, new Vector2(1f, 1.4f), new Vector2(1f, 1f), Class115.int_1, Class115.int_1 + 300, Enum70.const_0);
			class.enum70_0 = Enum70.const_1;
			class.byte_0 = 1;
			this.class536_0.class26_0.Add(class);
		}
	}
}
