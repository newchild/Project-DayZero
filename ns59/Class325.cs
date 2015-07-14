using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns29;
using osu.GameplayElements.HitObjects;
using System;

namespace ns59
{
	// Token: 0x02000435 RID: 1077
	internal abstract class Class325 : Class304
	{
		// Token: 0x060022AB RID: 8875
		// RVA: 0x000D04E4 File Offset: 0x000CE6E4
		protected Class325(Class297 class297_1, int int_6, int int_7, HitObjectSoundType hitObjectSoundType_0) : base(class297_1)
		{
			this.Position = new Vector2((float)(Class115.int_18 / 2), (float)(Class115.int_17 / 2));
			this.vector2_0 = this.Position;
			this.StartTime = int_6;
			this.EndTime = int_7;
			this.Type = HitObjectType.Spinner;
			if (this.class297_0.class296_0.int_6 <= 8)
			{
				this.Type |= HitObjectType.NewCombo;
			}
			this.SoundType = hitObjectSoundType_0;
			this.Colour = Color.get_Gray();
		}

		// Token: 0x060022AC RID: 8876
		// RVA: 0x000D0568 File Offset: 0x000CE768
		internal override void vmethod_12()
		{
			Class340 class = this.class297_0.class296_0.method_39((double)this.EndTime);
			if (class != null)
			{
				base.method_6(class, this.SoundType, this.sampleSet_0, this.sampleSet_1);
			}
		}
	}
}
