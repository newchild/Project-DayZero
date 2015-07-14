using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x020003DB RID: 987
	internal sealed class Class437
	{
		// Token: 0x040018FF RID: 6399
		internal bool bool_0;

		// Token: 0x040018FD RID: 6397
		internal Class531 class531_0;

		// Token: 0x040018FE RID: 6398
		internal Class531 class531_1;

		// Token: 0x04001900 RID: 6400
		internal int int_0 = Class115.int_1 + 300;

		// Token: 0x04001901 RID: 6401
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x06001FAF RID: 8111
		// RVA: 0x000B44E4 File Offset: 0x000B26E4
		public Class437(string string_0, Vector2 vector2_0, string string_1, bool bool_1, int int_1, Origins origins_0)
		{
			int num = Class885.smethod_25() ? -16 : -25;
			Class531 class = new Class531(Class885.smethod_29(string_0, Enum112.flag_6, true), Enum115.const_5, origins_0, Enum114.const_0, vector2_0, bool_1 ? 0.91f : 0.9f, true, Color.get_TransparentWhite(), null);
			class.float_3 = 0f;
			Class746 class2 = new Class746(TransformationType.Scale, 1f, 0.5f, this.int_0 + int_1, this.int_0 + int_1 + 300, Enum70.const_0);
			class2.enum70_0 = Enum70.const_2;
			class.class26_0.Add(class2);
			class2 = new Class746(TransformationType.Fade, 0f, 1f, this.int_0 + int_1, this.int_0 + int_1 + 300, Enum70.const_0);
			class2.enum70_0 = Enum70.const_2;
			class.class26_0.Add(class2);
			this.class531_0 = class;
			this.bool_0 = bool_1;
			if (string_1 == null)
			{
				return;
			}
			this.vmethod_0(string_1, new Vector2(vector2_0.X + 40f, vector2_0.Y + (float)num));
		}

		// Token: 0x06001FB3 RID: 8115
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_0(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06001FB0 RID: 8112
		// RVA: 0x000B45FC File Offset: 0x000B27FC
		internal virtual void vmethod_0(string string_0, Vector2 vector2_0)
		{
			Vector2 vector;
			vector..ctor(40f, 0f);
			Class531 class = new Class536(string_0, Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, 0.8f, true, Color.get_TransparentWhite(), true);
			class.float_2 = 1.12f;
			Class746 class2 = new Class746(class.vector2_1 - vector, class.vector2_1, this.int_0 + 200, this.int_0 + 200 + 300, Enum70.const_0);
			class2.enum70_0 = Enum70.const_1;
			class.class26_0.Add(class2);
			class2 = new Class746(TransformationType.Fade, 0f, 1f, this.int_0 + 200, this.int_0 + 200 + 300, Enum70.const_0);
			class2.enum70_0 = Enum70.const_1;
			class.class26_0.Add(class2);
			this.class531_1 = class;
		}

		// Token: 0x06001FB1 RID: 8113
		// RVA: 0x00019E74 File Offset: 0x00018074
		internal virtual void vmethod_1(float float_0)
		{
			if (this.class531_0 == null)
			{
				return;
			}
			this.class531_0.float_1 = float_0;
		}

		// Token: 0x06001FB2 RID: 8114
		// RVA: 0x000B46E4 File Offset: 0x000B28E4
		internal virtual void vmethod_2(float float_0, float float_1)
		{
			if (this.class531_0 == null)
			{
				return;
			}
			List<Class746> arg_31_0 = this.class531_0.class26_0;
			if (Class437.predicate_0 == null)
			{
				Class437.predicate_0 = new Predicate<Class746>(Class437.smethod_0);
			}
			Class746 class = arg_31_0.Find(Class437.predicate_0);
			if (class == null)
			{
				return;
			}
			class.float_0 = float_0;
			class.float_1 = float_1;
		}
	}
}
