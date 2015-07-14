using ns14;
using ns26;
using ns59;
using ns79;
using ns89;
using osu.Audio;
using osu.GameplayElements.Events;
using osu.GameplayElements.HitObjects;
using System;
using System.Runtime.CompilerServices;

namespace ns75
{
	// Token: 0x0200040C RID: 1036
	internal sealed class Class478 : Class477
	{
		// Token: 0x0200040D RID: 1037
		[CompilerGenerated]
		private sealed class Class482
		{
			// Token: 0x04001A18 RID: 6680
			public Class478 class478_0;

			// Token: 0x04001A1B RID: 6683
			public Class531 class531_0;

			// Token: 0x04001A19 RID: 6681
			public Class702 class702_0;

			// Token: 0x04001A1A RID: 6682
			public Class744 class744_0;

			// Token: 0x06002133 RID: 8499
			// RVA: 0x000C07FC File Offset: 0x000BE9FC
			public void method_0(Struct69 struct69_0)
			{
				if (this.class478_0.sampleSet_0 != SampleSet.All && struct69_0.sampleSet_0 != this.class478_0.sampleSet_0)
				{
					return;
				}
				if (this.class478_0.sampleSet_1 != SampleSet.All && struct69_0.sampleSet_1 != this.class478_0.sampleSet_1 && (struct69_0.sampleSet_1 != SampleSet.None || struct69_0.sampleSet_0 != this.class478_0.sampleSet_1))
				{
					return;
				}
				if (this.class478_0.hitObjectSoundType_0 != HitObjectSoundType.None && !struct69_0.hitObjectSoundType_0.IsType(this.class478_0.hitObjectSoundType_0))
				{
					return;
				}
				if (this.class478_0.bool_2 && struct69_0.enum38_0 != this.class478_0.enum38_0)
				{
					return;
				}
				this.class478_0.method_2(this.class702_0, this.class744_0, this.class531_0, false);
			}
		}

		// Token: 0x04001A15 RID: 6677
		internal bool bool_0;

		// Token: 0x04001A16 RID: 6678
		internal bool bool_1;

		// Token: 0x04001A17 RID: 6679
		internal bool bool_2;

		// Token: 0x04001A14 RID: 6676
		internal Enum38 enum38_0;

		// Token: 0x04001A11 RID: 6673
		internal HitObjectSoundType hitObjectSoundType_0;

		// Token: 0x04001A12 RID: 6674
		internal SampleSet sampleSet_0 = SampleSet.All;

		// Token: 0x04001A13 RID: 6675
		internal SampleSet sampleSet_1 = SampleSet.All;

		// Token: 0x0600212F RID: 8495
		// RVA: 0x000C0588 File Offset: 0x000BE788
		internal Class478(string string_0)
		{
			string text = string_0;
			SampleSet sampleSet;
			if (Class558.smethod_0<SampleSet>(text, ref sampleSet) && sampleSet != SampleSet.None)
			{
				this.sampleSet_0 = sampleSet;
				this.bool_0 = true;
				text = text.Substring(this.sampleSet_0.ToString().Length, text.Length - this.sampleSet_0.ToString().Length);
				if (Class558.smethod_0<SampleSet>(text, ref sampleSet) && sampleSet != SampleSet.None)
				{
					this.sampleSet_1 = sampleSet;
					this.bool_1 = true;
					text = text.Substring(this.sampleSet_1.ToString().Length, text.Length - this.sampleSet_1.ToString().Length);
				}
			}
			HitObjectSoundType hitObjectSoundType;
			if (Class558.smethod_0<HitObjectSoundType>(text, ref hitObjectSoundType) && hitObjectSoundType != HitObjectSoundType.None && hitObjectSoundType != HitObjectSoundType.Normal)
			{
				this.hitObjectSoundType_0 = hitObjectSoundType;
				text = text.Substring(this.hitObjectSoundType_0.ToString().Length, text.Length - this.hitObjectSoundType_0.ToString().Length);
			}
			int num;
			if (int.TryParse(text, out num))
			{
				this.enum38_0 = (Enum38)num;
				this.bool_2 = true;
			}
			if (this.hitObjectSoundType_0 != HitObjectSoundType.None && this.bool_0 && !this.bool_1)
			{
				this.sampleSet_1 = this.sampleSet_0;
				this.sampleSet_0 = SampleSet.All;
				this.bool_0 = false;
				this.bool_1 = true;
			}
			if (!this.ToString().Equals(this.vmethod_0().ToString() + string_0))
			{
				throw new Exception("Invalid hitsound trigger description after " + this.ToString());
			}
		}

		// Token: 0x06002131 RID: 8497
		// RVA: 0x000C0774 File Offset: 0x000BE974
		public override string ToString()
		{
			string text = this.vmethod_0().ToString();
			if (this.bool_0)
			{
				text += this.sampleSet_0;
			}
			if (this.bool_1)
			{
				text += this.sampleSet_1;
			}
			if (this.hitObjectSoundType_0 != HitObjectSoundType.None)
			{
				text += this.hitObjectSoundType_0;
			}
			if (this.bool_2)
			{
				text += (int)this.enum38_0;
			}
			return text;
		}

		// Token: 0x0600212E RID: 8494
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override TriggerGroup vmethod_0()
		{
			return TriggerGroup.HitSound;
		}

		// Token: 0x06002130 RID: 8496
		// RVA: 0x000C0734 File Offset: 0x000BE934
		internal override void vmethod_1(Class702 class702_0, Class744 class744_0, Class531 class531_0)
		{
			Class478.Class482 class = new Class478.Class482();
			class.class702_0 = class702_0;
			class.class744_0 = class744_0;
			class.class531_0 = class531_0;
			class.class478_0 = this;
			Class872.smethod_8(new Delegate51(class.method_0));
		}
	}
}
