using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns60;
using ns70;
using ns79;
using ns82;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns23
{
	// Token: 0x02000420 RID: 1056
	internal sealed class Class307 : Class306
	{
		// Token: 0x04001A8C RID: 6796
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04001A8B RID: 6795
		internal float float_0;

		// Token: 0x04001A8D RID: 6797
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x04001A8E RID: 6798
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04001A8A RID: 6794
		internal Vector2 vector2_1;

		// Token: 0x06002204 RID: 8708
		// RVA: 0x0001B543 File Offset: 0x00019743
		internal Class307(Class297 class297_1, Vector2 vector2_2, int int_7, bool bool_6, HitObjectSoundType hitObjectSoundType_0, int int_8) : base(class297_1, vector2_2, int_7, bool_6, hitObjectSoundType_0, int_8)
		{
			this.class531_2.method_8(true);
		}

		// Token: 0x0600220B RID: 8715
		// RVA: 0x0001B59C File Offset: 0x0001979C
		[CompilerGenerated]
		private static void smethod_5(Class531 class531_4)
		{
			List<Class746> arg_23_0 = class531_4.class26_0;
			if (Class307.predicate_3 == null)
			{
				Class307.predicate_3 = new Predicate<Class746>(Class307.smethod_6);
			}
			arg_23_0.RemoveAll(Class307.predicate_3);
		}

		// Token: 0x0600220C RID: 8716
		// RVA: 0x0001B469 File Offset: 0x00019669
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_1)
		{
			return class746_1.byte_0 == 148;
		}

		// Token: 0x0600220D RID: 8717
		// RVA: 0x0001B423 File Offset: 0x00019623
		[CompilerGenerated]
		private static bool smethod_7(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Colour && class746_1.byte_0 == 147;
		}

		// Token: 0x0600220A RID: 8714
		// RVA: 0x000C942C File Offset: 0x000C762C
		internal override void vmethod_1()
		{
			Color color;
			color..ctor((byte)Math.Max(0f, (float)this.Colour.get_R() * 0.45f), (byte)Math.Max(0f, (float)this.Colour.get_G() * 0.45f), (byte)Math.Max(0f, (float)this.Colour.get_B() * 0.45f), 255);
			Color color2;
			color2..ctor(195, 195, 195, 255);
			Color white = Color.get_White();
			foreach (Class531 current in this.list_0)
			{
				int num = (int)this.class297_0.class296_0.method_36((double)this.StartTime, false);
				List<Class746> arg_DD_0 = current.class26_0;
				if (Class307.predicate_4 == null)
				{
					Class307.predicate_4 = new Predicate<Class746>(Class307.smethod_7);
				}
				arg_DD_0.RemoveAll(Class307.predicate_4);
				Class746 class = new Class746((current.int_0 == 0) ? color2 : color, (current.int_0 == 0) ? white : this.Colour, this.StartTime - num - 96, this.StartTime - num);
				if (class != null)
				{
					class.byte_0 = 147;
				}
				current.class26_0.Add(class);
			}
		}

		// Token: 0x06002208 RID: 8712
		// RVA: 0x000C93C8 File Offset: 0x000C75C8
		internal override Enum61 vmethod_2()
		{
			Vector2 vector = Class802.smethod_0() ? Class802.vector2_1 : Class115.smethod_58(Class802.vector2_0);
			this.vector2_1 = vector - this.Position;
			this.float_0 = 1f - Vector2.Distance(vector, this.Position) / this.class297_0.HitObjectRadius;
			return base.vmethod_2();
		}

		// Token: 0x06002207 RID: 8711
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_21()
		{
		}

		// Token: 0x06002205 RID: 8709
		// RVA: 0x0001B560 File Offset: 0x00019760
		internal override string vmethod_23()
		{
			return "target";
		}

		// Token: 0x06002206 RID: 8710
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_25()
		{
			return false;
		}

		// Token: 0x06002209 RID: 8713
		// RVA: 0x0001B567 File Offset: 0x00019767
		internal override void vmethod_8(bool bool_6)
		{
			if (!bool_6)
			{
				base.vmethod_8(bool_6);
				return;
			}
			List<Class531> arg_2E_0 = this.list_1;
			if (Class307.action_2 == null)
			{
				Class307.action_2 = new Action<Class531>(Class307.smethod_5);
			}
			arg_2E_0.ForEach(Class307.action_2);
		}
	}
}
