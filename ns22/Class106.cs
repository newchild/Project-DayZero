using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns29;
using ns59;
using ns79;
using ns80;
using ns9;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003BE RID: 958
	internal sealed class Class106 : Class105
	{
		// Token: 0x040017A8 RID: 6056
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x06001DD4 RID: 7636
		// RVA: 0x000188A5 File Offset: 0x00016AA5
		public Class106(Class114 class114_1, Class297 class297_1) : base(class114_1, class297_1)
		{
		}

		// Token: 0x06001DD5 RID: 7637
		// RVA: 0x000A2A8C File Offset: 0x000A0C8C
		internal override void Initialize()
		{
			base.Initialize();
			float arg_11_0 = this.vmethod_3().X;
			float arg_1E_0 = this.vmethod_4() / 2f;
			float num = this.vmethod_4();
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.BottomCentre, Enum114.const_1, this.vmethod_3() + new Vector2(-num / 2f, -base.method_2() * 2f), 0.79f, true, Color.get_Black(), null);
			class.float_3 = 0.4f;
			class.vector2_2 = new Vector2(num, base.method_2() * 24f) * 1.6f;
			this.class911_0.Add(class);
			Class307 class2 = new Class307(this.class297_0, new Vector2(256f, 365f), 0, false, HitObjectSoundType.None, 0);
			class2.vmethod_0(Color.get_Red());
			List<Class531> arg_EB_0 = class2.list_1;
			if (Class106.action_0 == null)
			{
				Class106.action_0 = new Action<Class531>(Class106.smethod_0);
			}
			arg_EB_0.ForEach(Class106.action_0);
			this.class911_0.Add<Class531>(class2.list_1);
		}

		// Token: 0x06001DD7 RID: 7639
		// RVA: 0x000188AF File Offset: 0x00016AAF
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_2)
		{
			class531_2.bool_0 = true;
			class531_2.class26_0.Clear();
			class531_2.float_3 = 1f;
		}

		// Token: 0x06001DD6 RID: 7638
		// RVA: 0x000A2B9C File Offset: 0x000A0D9C
		internal override void vmethod_2(Class304 class304_0, int? nullable_0)
		{
			Class307 class = class304_0 as Class307;
			Class531 class2 = new Class531(Class885.Load("particle" + class304_0.int_5, Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_2, new Vector2(256f, 365f) + class.vector2_1, 1f, false, Color.get_Black(), null);
			class2.method_17(60000);
			this.class911_0.Add(class2);
			base.vmethod_2(class304_0, nullable_0);
		}
	}
}
