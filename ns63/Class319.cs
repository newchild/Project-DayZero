using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using ns70;
using ns79;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Runtime.CompilerServices;

namespace ns63
{
	// Token: 0x0200054A RID: 1354
	internal sealed class Class319 : Class316
	{
		// Token: 0x0200054B RID: 1355
		[CompilerGenerated]
		private sealed class Class719
		{
			// Token: 0x04002471 RID: 9329
			public Class746 class746_0;

			// Token: 0x06002BC5 RID: 11205
			// RVA: 0x000216C2 File Offset: 0x0001F8C2
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
			}
		}

		// Token: 0x04002470 RID: 9328
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x06002BC0 RID: 11200
		// RVA: 0x0011BF68 File Offset: 0x0011A168
		public Class319(Class297 class297_1, Vector2 vector2_2, int int_6, bool bool_8, HitObjectSoundType hitObjectSoundType_0, string string_1) : base(class297_1, vector2_2, int_6, bool_8, hitObjectSoundType_0, "drop")
		{
			Class319.Class719 class = new Class319.Class719();
			this.list_1.ForEach(delegate(Class531 class531_3)
			{
				class531_3.float_2 *= 0.8f;
			});
			Class496 class2 = this.class297_0.class494_0 as Class496;
			float num = (float)class2.class30_0.method_3() * 2f;
			class.class746_0 = new Class746(TransformationType.Rotation, num, 0f, this.StartTime - this.class297_0.PreEmpt, this.StartTime + 2000, Enum70.const_0);
			class.class746_0.float_1 = (float)class.class746_0.method_0() / 200f + num;
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002BC1 RID: 11201
		// RVA: 0x0011C040 File Offset: 0x0011A240
		internal override void vmethod_12()
		{
			Class340 class = this.class297_0.class296_0.method_39((double)(this.StartTime + 2));
			SampleSet sampleSet = (this.sampleSet_0 == SampleSet.None) ? class.sampleSet_0 : this.sampleSet_0;
			Class331.smethod_65(new Struct69(this.SoundType, sampleSet, class.enum38_0, class.int_0, (this.sampleSet_1 == SampleSet.None) ? sampleSet : this.sampleSet_1), this.vmethod_14());
		}

		// Token: 0x06002BC2 RID: 11202
		// RVA: 0x0011C0B4 File Offset: 0x0011A2B4
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			if (this.bool_6)
			{
				this.enum61_0 = Enum61.flag_23;
				this.vmethod_12();
			}
			else
			{
				this.enum61_0 = Enum61.flag_3;
			}
			this.vmethod_8(this.enum61_0 > Enum61.flag_5);
			return this.enum61_0;
		}
	}
}
