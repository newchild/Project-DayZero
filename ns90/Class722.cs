using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns29;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns90
{
	// Token: 0x0200055E RID: 1374
	internal sealed class Class722
	{
		// Token: 0x040024DA RID: 9434
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x040024D6 RID: 9430
		private bool bool_0;

		// Token: 0x040024D1 RID: 9425
		private Class531 class531_0;

		// Token: 0x040024D2 RID: 9426
		private Class531 class531_1;

		// Token: 0x040024D3 RID: 9427
		private Class531 class531_2;

		// Token: 0x040024D4 RID: 9428
		private Class533 class533_0;

		// Token: 0x040024CE RID: 9422
		internal readonly Color color_0;

		// Token: 0x040024D0 RID: 9424
		private float float_0;

		// Token: 0x040024CD RID: 9421
		internal readonly int int_0;

		// Token: 0x040024D7 RID: 9431
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040024CF RID: 9423
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x040024D8 RID: 9432
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x040024D9 RID: 9433
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x040024CC RID: 9420
		internal readonly string string_0;

		// Token: 0x040024D5 RID: 9429
		internal VoidDelegate voidDelegate_0;

		// Token: 0x06002C8A RID: 11402
		// RVA: 0x00021C08 File Offset: 0x0001FE08
		internal Class722(string string_1, int int_2, Color color_1, VoidDelegate voidDelegate_1)
		{
			this.string_0 = string_1;
			this.int_0 = int_2;
			this.color_0 = color_1;
			this.voidDelegate_0 = voidDelegate_1;
		}

		// Token: 0x06002C88 RID: 11400
		// RVA: 0x00021BF7 File Offset: 0x0001FDF7
		[CompilerGenerated]
		internal int method_0()
		{
			return this.int_1;
		}

		// Token: 0x06002C89 RID: 11401
		// RVA: 0x00021BFF File Offset: 0x0001FDFF
		[CompilerGenerated]
		private void method_1(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x06002C8B RID: 11403
		// RVA: 0x00021C38 File Offset: 0x0001FE38
		private void method_2(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.method_1(Class115.int_1);
			this.list_0.ForEach(new Action<Class531>(this.method_6));
		}

		// Token: 0x06002C8C RID: 11404
		// RVA: 0x00021C65 File Offset: 0x0001FE65
		private void method_3(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.method_1(Class115.int_1);
			this.list_0.ForEach(new Action<Class531>(this.method_7));
		}

		// Token: 0x06002C8D RID: 11405
		// RVA: 0x00120CD0 File Offset: 0x0011EED0
		private void method_4(object sender, EventArgs e)
		{
			this.bool_0 = true;
			List<Class531> arg_2A_0 = this.list_0;
			if (Class722.action_0 == null)
			{
				Class722.action_0 = new Action<Class531>(Class722.smethod_2);
			}
			arg_2A_0.ForEach(Class722.action_0);
			if (Class802.buttonState_0 == 1 && this.voidDelegate_0 != null && !Class62.bool_12)
			{
				this.voidDelegate_0();
			}
		}

		// Token: 0x06002C8E RID: 11406
		// RVA: 0x00120D30 File Offset: 0x0011EF30
		internal float method_5()
		{
			VoidDelegate voidDelegate = null;
			Class731 class = Class885.Load("notification", Enum112.flag_1);
			float num = (float)class.method_0() * 0.625f;
			float num2 = num * 0.9f;
			float num3 = (num - num2) / 2f;
			float num4 = (float)Class115.smethod_44();
			this.class533_0 = new Class533(this.string_0, 9f - (float)(Class115.int_23 - 1024) / 256f, new Vector2(3f + num3 + num2, num4 + num3), new Vector2(num2, 0f), 1f, false, Color.get_White(), false);
			this.class533_0.enum115_0 = Enum115.const_7;
			this.class533_0.origins_0 = Origins.TopLeft;
			this.class533_0.bool_16 = true;
			Vector2 vector = this.class533_0.vmethod_11();
			this.class531_1 = new Class531(class, Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(0f, num4), 0.98f, false, this.color_0, null);
			this.class531_1.nullable_2 = new bool?(false);
			this.class531_1.int_1 = 13;
			this.class531_1.method_2(new EventHandler(this.method_4));
			this.class531_1.bool_1 = true;
			this.class531_1.method_35(new EventHandler(this.method_3));
			this.class531_1.method_37(new EventHandler(this.method_2));
			num4 += 8.125f;
			float num5 = vector.Y - (26.875f - num3 * 2f);
			if (num5 > 0f)
			{
				this.class531_0 = new Class531(class, Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(0f, num4), 0.98f, false, this.color_0, null);
				this.class531_0.nullable_2 = new bool?(false);
				this.class531_0.int_3 = 13;
				this.class531_0.int_1 = 13;
				this.class531_0.method_2(new EventHandler(this.method_4));
				this.class531_0.bool_1 = true;
				this.class531_0.method_35(new EventHandler(this.method_3));
				this.class531_0.method_37(new EventHandler(this.method_2));
				this.class531_0.vector2_2.Y = num5 / 8.125f;
				this.list_0.Add(this.class531_0);
				num4 += 8.125f * this.class531_0.vector2_2.Y;
			}
			this.class531_2 = new Class531(class, Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(0f, num4), 0.98f, false, this.color_0, null);
			this.class531_2.nullable_2 = new bool?(false);
			this.class531_2.int_3 = 26;
			this.class531_2.int_1 = 30;
			this.class531_2.bool_1 = true;
			this.class531_2.method_35(new EventHandler(this.method_3));
			this.class531_2.method_37(new EventHandler(this.method_2));
			this.class531_2.method_2(new EventHandler(this.method_4));
			num4 += 18.75f;
			this.list_0.Add(this.class531_1);
			this.list_0.Add(this.class533_0);
			this.list_0.Add(this.class531_2);
			this.float_0 = num4 - (float)Class115.smethod_44();
			this.method_1(Class115.int_1);
			foreach (Class531 current in this.list_0)
			{
				Class531 expr_384_cp_0 = current;
				expr_384_cp_0.vector2_1.Y = expr_384_cp_0.vector2_1.Y - (this.float_0 + 28f);
				Class531 expr_3A3_cp_0 = current;
				expr_3A3_cp_0.vector2_1.X = expr_3A3_cp_0.vector2_1.X - 100f;
				current.method_23(new Vector2(100f, 0f), 800, Enum70.const_26);
				current.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0));
				current.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 200 + this.int_0 - 500, Class115.int_1 + 200 + this.int_0, Enum70.const_2));
				current.object_0 = "notice";
				Class47 arg_470_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_8);
				}
				arg_470_0.method_1(voidDelegate, 200, false);
			}
			return this.float_0;
		}

		// Token: 0x06002C8F RID: 11407
		// RVA: 0x001211F0 File Offset: 0x0011F3F0
		[CompilerGenerated]
		private void method_6(Class531 class531_3)
		{
			if (class531_3 != this.class533_0)
			{
				class531_3.method_39(this.color_0, 60, false, Enum70.const_0);
			}
			List<Class746> arg_3D_0 = class531_3.class26_0;
			if (Class722.predicate_0 == null)
			{
				Class722.predicate_0 = new Predicate<Class746>(Class722.smethod_0);
			}
			arg_3D_0.RemoveAll(Class722.predicate_0);
			class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 200 + this.int_0 - 500, Class115.int_1 + 200 + this.int_0, Enum70.const_2));
		}

		// Token: 0x06002C91 RID: 11409
		// RVA: 0x00121288 File Offset: 0x0011F488
		[CompilerGenerated]
		private void method_7(Class531 class531_3)
		{
			if (class531_3 != this.class533_0)
			{
				class531_3.method_39(Color.get_White(), 60, false, Enum70.const_0);
			}
			List<Class746> arg_3C_0 = class531_3.class26_0;
			if (Class722.predicate_1 == null)
			{
				Class722.predicate_1 = new Predicate<Class746>(Class722.smethod_1);
			}
			arg_3C_0.RemoveAll(Class722.predicate_1);
			class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 200 + this.int_0 - 500 + 60000, Class115.int_1 + 200 + this.int_0 + 60000, Enum70.const_2));
		}

		// Token: 0x06002C94 RID: 11412
		// RVA: 0x00021C92 File Offset: 0x0001FE92
		[CompilerGenerated]
		private void method_8()
		{
			this.class533_0.nullable_2 = new bool?(true);
		}

		// Token: 0x06002C90 RID: 11408
		// RVA: 0x0001BAAB File Offset: 0x00019CAB
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade && class746_0.float_1 == 0f;
		}

		// Token: 0x06002C92 RID: 11410
		// RVA: 0x0001BAAB File Offset: 0x00019CAB
		[CompilerGenerated]
		private static bool smethod_1(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade && class746_0.float_1 == 0f;
		}

		// Token: 0x06002C93 RID: 11411
		// RVA: 0x00018A43 File Offset: 0x00016C43
		[CompilerGenerated]
		private static void smethod_2(Class531 class531_3)
		{
			class531_3.method_16(100, Enum70.const_0);
		}
	}
}
