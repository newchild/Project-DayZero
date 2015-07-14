using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns29;
using ns64;
using ns79;
using ns80;
using osu;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns60
{
	// Token: 0x0200067C RID: 1660
	internal sealed class Class311 : Class306
	{
		// Token: 0x0400302B RID: 12331
		private readonly Class746 class746_1;

		// Token: 0x0400302C RID: 12332
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x0400302D RID: 12333
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x060033C1 RID: 13249
		// RVA: 0x001625F8 File Offset: 0x001607F8
		internal Class311(Class297 class297_1, Vector2 vector2_1, int int_7, int int_8, bool bool_6, float float_0, Class321 class321_0) : base(class297_1, vector2_1, int_7, false, false, false, false, 0)
		{
			this.list_1.Remove(this.class531_0);
			this.list_1.Remove(this.class531_2);
			this.class746_1 = new Class746(TransformationType.Fade, 0f, 0f, int_8 - this.class297_0.int_10, Math.Min(int_8, int_8 - this.class297_0.int_10 + Class297.int_2), Enum70.const_0);
			if (bool_6)
			{
				this.class531_2 = new Class531(Class885.Load("reversearrow", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(int_7 - 3)), false, Color.get_White(), null);
				this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, int_8, int_8 + 150, Enum70.const_0));
				this.list_1.Add(this.class531_2);
				this.list_0.Add(this.class531_2);
			}
			this.class531_1.class26_0.Clear();
			this.class531_1.class26_0.Add(this.class746_1);
			this.class538_0.class26_0.Clear();
			this.class538_0.class26_0.Add(this.class746_1);
			this.vmethod_7();
			if (bool_6)
			{
				if (Class885.smethod_25())
				{
					this.class531_2.float_1 = float_0;
					for (int i = int_8; i < int_7; i += 300)
					{
						int num = Math.Min(300, int_7 - i);
						this.class531_2.class26_0.Add(new Class746(TransformationType.Scale, 1.3f, 1f, i, i + num, Enum70.const_1));
					}
					return;
				}
				for (int j = int_8; j < int_7; j += 300)
				{
					int num2 = Math.Min(300, int_7 - j);
					this.class531_2.class26_0.Add(new Class746(TransformationType.Scale, 1.3f, 1f, j, j + num2, Enum70.const_0));
					this.class531_2.class26_0.Add(new Class746(TransformationType.Rotation, float_0 + 0.09817469f, float_0 - 0.09817469f, j, j + num2, Enum70.const_0));
				}
			}
		}

		// Token: 0x060033C5 RID: 13253
		// RVA: 0x0001B469 File Offset: 0x00019669
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_2)
		{
			return class746_2.byte_0 == 148;
		}

		// Token: 0x060033C6 RID: 13254
		// RVA: 0x0001B469 File Offset: 0x00019669
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_2)
		{
			return class746_2.byte_0 == 148;
		}

		// Token: 0x060033C2 RID: 13250
		// RVA: 0x00162818 File Offset: 0x00160A18
		internal override void vmethod_0(Color color_0)
		{
			if (this.class531_2.vmethod_6() != null && this.class531_2.vmethod_6().enum112_0 == Enum112.flag_1 && (int)(color_0.get_R() + color_0.get_G() + color_0.get_B()) > 600)
			{
				this.class531_2.color_0 = Color.get_Black();
				this.list_0.Remove(this.class531_2);
			}
			base.vmethod_0(color_0);
		}

		// Token: 0x060033C3 RID: 13251
		// RVA: 0x0016288C File Offset: 0x00160A8C
		internal override void vmethod_7()
		{
			base.vmethod_7();
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class531 class = this.list_1[i];
				if (class.enum114_0 != Enum114.const_0)
				{
					List<Class746> arg_42_0 = class.class26_0;
					if (Class311.predicate_3 == null)
					{
						Class311.predicate_3 = new Predicate<Class746>(Class311.smethod_5);
					}
					arg_42_0.RemoveAll(Class311.predicate_3);
					class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.StartTime, this.StartTime, Enum70.const_0)
					{
						byte_0 = 148
					});
				}
			}
		}

		// Token: 0x060033C4 RID: 13252
		// RVA: 0x0016292C File Offset: 0x00160B2C
		internal override void vmethod_8(bool bool_6)
		{
			if (bool_6 && (Class115.osuModes_1 != OsuModes.Edit || Class341.class606_20))
			{
				foreach (Class531 current in this.list_1)
				{
					if (current != this.class531_3)
					{
						List<Class746> arg_66_0 = current.class26_0;
						if (Class311.predicate_4 == null)
						{
							Class311.predicate_4 = new Predicate<Class746>(Class311.smethod_6);
						}
						arg_66_0.RemoveAll(Class311.predicate_4);
						current.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.StartTime, this.StartTime + Class297.int_3, Enum70.const_0)
						{
							byte_0 = 148
						});
						current.class26_0.Add(new Class746(TransformationType.Scale, 1f, 1.4f, this.StartTime, this.StartTime + Class297.int_3, Enum70.const_1)
						{
							byte_0 = 148
						});
					}
				}
				return;
			}
		}
	}
}
