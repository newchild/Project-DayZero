using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using osu.GameplayElements.HitObjects;
using System;

namespace ns60
{
	// Token: 0x0200043E RID: 1086
	internal sealed class Class308 : Class306
	{
		// Token: 0x04001B4B RID: 6987
		internal bool bool_6;

		// Token: 0x06002310 RID: 8976
		// RVA: 0x000D3924 File Offset: 0x000D1B24
		internal Class308(Class297 class297_1, Vector2 vector2_1, int int_7, bool bool_7, bool bool_8, bool bool_9, bool bool_10, int int_8) : base(class297_1, vector2_1, int_7, bool_7, bool_8, bool_9, bool_10, int_8)
		{
			this.Type = HitObjectType.Hold;
			this.bool_6 = false;
		}

		// Token: 0x06002313 RID: 8979
		// RVA: 0x000D3984 File Offset: 0x000D1B84
		internal override Class304 Clone()
		{
			Class308 class = new Class308(this.class297_0, this.Position, this.StartTime, false, this.SoundType.IsType(HitObjectSoundType.Whistle), this.SoundType.IsType(HitObjectSoundType.Finish), this.SoundType.IsType(HitObjectSoundType.Clap), this.int_0);
			class.vector2_0 = this.vector2_0;
			class.EndTime = this.EndTime;
			class.vmethod_0(this.Colour);
			class.ComboNumber = this.ComboNumber;
			class.method_3(base.method_2());
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.enum38_0 = this.enum38_0;
			class.int_3 = this.int_3;
			class.int_2 = this.int_2;
			class.string_0 = this.string_0;
			return class;
		}

		// Token: 0x06002314 RID: 8980
		// RVA: 0x000D3A5C File Offset: 0x000D1C5C
		internal Class304 method_8()
		{
			Class306 class = new Class306(this.class297_0, this.Position, this.StartTime, false, this.SoundType.IsType(HitObjectSoundType.Whistle), this.SoundType.IsType(HitObjectSoundType.Finish), this.SoundType.IsType(HitObjectSoundType.Clap), this.int_0);
			class.vmethod_0(this.Colour);
			class.ComboNumber = this.ComboNumber;
			class.method_3(base.method_2());
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.enum38_0 = this.enum38_0;
			class.int_3 = this.int_3;
			class.int_2 = this.int_2;
			class.string_0 = this.string_0;
			return class;
		}

		// Token: 0x06002315 RID: 8981
		// RVA: 0x0001BD3E File Offset: 0x00019F3E
		internal override void vmethod_12()
		{
			if (Math.Abs(Class331.int_7 - this.EndTime) < Math.Abs(Class331.int_7 - this.StartTime))
			{
				return;
			}
			base.vmethod_12();
		}

		// Token: 0x06002312 RID: 8978
		// RVA: 0x0001BD35 File Offset: 0x00019F35
		internal override void vmethod_19(int int_7)
		{
			this.EndTime = int_7;
		}

		// Token: 0x06002311 RID: 8977
		// RVA: 0x000D3958 File Offset: 0x000D1B58
		internal override void vmethod_4(int int_7)
		{
			int num = int_7 - this.StartTime;
			this.StartTime = int_7;
			this.EndTime += num;
		}
	}
}
