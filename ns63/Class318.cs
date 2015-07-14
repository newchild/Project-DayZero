using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns70;
using ns79;
using ns80;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;

namespace ns63
{
	// Token: 0x02000548 RID: 1352
	internal sealed class Class318 : Class316
	{
		// Token: 0x02000549 RID: 1353
		[CompilerGenerated]
		private sealed class Class718
		{
			// Token: 0x0400246F RID: 9327
			public Class746 class746_0;

			// Token: 0x06002BBF RID: 11199
			// RVA: 0x0002169B File Offset: 0x0001F89B
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
			}
		}

		// Token: 0x0400246E RID: 9326
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x06002BBA RID: 11194
		// RVA: 0x0011BEB0 File Offset: 0x0011A0B0
		public Class318(Class297 class297_1, Vector2 vector2_2, int int_6, bool bool_8, HitObjectSoundType hitObjectSoundType_0, string string_1) : base(class297_1, vector2_2, int_6, bool_8, hitObjectSoundType_0, "drop")
		{
			Class318.Class718 class = new Class318.Class718();
			this.list_1.ForEach(delegate(Class531 class531_3)
			{
				class531_3.float_2 *= 0.4f;
			});
			class.class746_0 = new Class746(TransformationType.Rotation, 0f, 0f, this.StartTime - this.class297_0.PreEmpt, this.StartTime + 2000, Enum70.const_0);
			class.class746_0.float_1 = (float)class.class746_0.method_0() / 200f;
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002BBB RID: 11195
		// RVA: 0x00021629 File Offset: 0x0001F829
		internal override void vmethod_12()
		{
			Class331.smethod_61(Class331.smethod_37("slidertick", false, false, Class331.bool_3 ? Enum112.flag_5 : Enum112.flag_6), 100, 0f, false, 1f);
		}

		// Token: 0x06002BBC RID: 11196
		// RVA: 0x00021655 File Offset: 0x0001F855
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			this.enum61_0 = (this.bool_6 ? Enum61.flag_10 : Enum61.flag_11);
			this.vmethod_8(this.enum61_0 > Enum61.flag_5);
			return this.enum61_0;
		}

		// Token: 0x06002BB9 RID: 11193
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_23()
		{
			return false;
		}
	}
}
