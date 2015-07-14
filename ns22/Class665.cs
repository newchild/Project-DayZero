using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020004F8 RID: 1272
	internal sealed class Class665 : Class664
	{
		// Token: 0x040021FF RID: 8703
		private Class531 class531_0;

		// Token: 0x04002200 RID: 8704
		private static Color color_0 = new Color(163, 222, 69, 160);

		// Token: 0x04002201 RID: 8705
		private static Color color_1 = new Color(89, 122, 36, 160);

		// Token: 0x04002202 RID: 8706
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x060028EC RID: 10476
		// RVA: 0x001024D0 File Offset: 0x001006D0
		internal Class665(int int_3, Class660 class660_1, Vector2 vector2_3, bool bool_6, SlotTeams slotTeams_0) : base(int_3, class660_1, vector2_3, bool_6)
		{
			bool flag = slotTeams_0 == SlotTeams.Red;
			this.class531_0 = new Class531(Class885.Load("play-warningarrow", Enum112.flag_1), flag ? Enum115.const_7 : Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(vector2_3.X + 150f, -100f), 1f, true, Class115.bool_32 ? Color.get_YellowGreen() : Color.get_White(), "extra");
			Class746 class = new Class746(TransformationType.MovementX, vector2_3.X + 170f, vector2_3.X + 150f, Class115.int_1, Class115.int_1 + 300, Enum70.const_2);
			class.bool_0 = true;
			class.int_2 = 300;
			Class746 class2 = new Class746(TransformationType.MovementX, vector2_3.X + 150f, vector2_3.X + 170f, Class115.int_1 + 300, Class115.int_1 + 600, Enum70.const_1);
			class2.bool_0 = true;
			class2.int_2 = 300;
			this.class531_0.class26_0.Add(class);
			this.class531_0.class26_0.Add(class2);
			if (!flag)
			{
				this.class531_0.method_45(true);
			}
			this.class531_0.float_2 = 0.5f;
			this.class911_0.Add(this.class531_0);
		}

		// Token: 0x060028EF RID: 10479
		// RVA: 0x0010262C File Offset: 0x0010082C
		internal void method_5(Class660 class660_1)
		{
			foreach (Class660 current in this.list_0)
			{
				current.class531_0.method_39((class660_1 == current) ? Class665.color_0 : Class665.color_1, 70, false, Enum70.const_0);
			}
			if (class660_1 != null)
			{
				List<Class746> arg_7E_0 = this.class531_0.class26_0;
				if (Class665.predicate_0 == null)
				{
					Class665.predicate_0 = new Predicate<Class746>(Class665.smethod_0);
				}
				arg_7E_0.RemoveAll(Class665.predicate_0);
				this.class531_0.class26_0.Add(new Class746(TransformationType.MovementY, this.class531_0.vector2_1.Y, class660_1.class531_0.vector2_1.Y + this.vector2_1.Y / 2f - 6f, Class115.int_1, Class115.int_1 + 100, Enum70.const_1));
				this.class531_0.method_14(50, Enum70.const_0);
				return;
			}
			this.class531_0.method_16(500, Enum70.const_0);
		}

		// Token: 0x060028F0 RID: 10480
		// RVA: 0x00102750 File Offset: 0x00100950
		public void method_6()
		{
			foreach (Class660 current in this.list_0)
			{
				current.class531_0.method_39(Class665.color_0, 70, false, Enum70.const_0);
			}
		}

		// Token: 0x060028F1 RID: 10481
		// RVA: 0x00019196 File Offset: 0x00017396
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY;
		}

		// Token: 0x060028EE RID: 10478
		// RVA: 0x0001F789 File Offset: 0x0001D989
		internal override void vmethod_0(Class660 class660_1)
		{
			this.class660_0 = class660_1;
		}

		// Token: 0x060028ED RID: 10477
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_1(bool bool_6)
		{
			return false;
		}
	}
}
