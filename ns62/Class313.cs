using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns69;
using ns70;
using ns79;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using System;

namespace ns62
{
	// Token: 0x0200042C RID: 1068
	internal class Class313 : Class312
	{
		// Token: 0x04001AD5 RID: 6869
		internal bool bool_10;

		// Token: 0x04001AD9 RID: 6873
		internal bool bool_11;

		// Token: 0x04001ADA RID: 6874
		internal bool bool_12;

		// Token: 0x04001ADC RID: 6876
		private bool bool_13;

		// Token: 0x04001AD6 RID: 6870
		internal Class538 class538_1;

		// Token: 0x04001AD7 RID: 6871
		internal Class538 class538_2;

		// Token: 0x04001ACF RID: 6863
		internal HitObjectSoundType hitObjectSoundType_0;

		// Token: 0x04001AD0 RID: 6864
		internal HitObjectSoundType hitObjectSoundType_1;

		// Token: 0x04001AD8 RID: 6872
		internal int int_10 = -1;

		// Token: 0x04001ADB RID: 6875
		internal int int_11;

		// Token: 0x04001AD1 RID: 6865
		internal SampleSet sampleSet_2;

		// Token: 0x04001AD2 RID: 6866
		internal SampleSet sampleSet_3;

		// Token: 0x04001AD3 RID: 6867
		internal SampleSet sampleSet_4;

		// Token: 0x04001AD4 RID: 6868
		internal SampleSet sampleSet_5;

		// Token: 0x0600224B RID: 8779
		// RVA: 0x000CA684 File Offset: 0x000C8884
		public Class313(Class297 class297_1, int int_12, int int_13, int int_14, HitObjectSoundType hitObjectSoundType_2) : base(class297_1, int_12, int_13, hitObjectSoundType_2)
		{
			int_12 = this.class409_0;
			this.SoundType = hitObjectSoundType_2;
			this.hitObjectSoundType_1 = hitObjectSoundType_2;
			this.hitObjectSoundType_0 = hitObjectSoundType_2;
			this.enum47_0 = Enum47.const_1;
			this.EndTime = int_14;
			this.bool_10 = true;
			if (!class297_1.class421_0.method_10())
			{
				this.class538_0.method_55(base.method_8(string.Format("NoteImage{0}H", int_12), this.class409_0.method_19() + "H"));
				this.class538_0.method_43(class297_1.class421_0.class546_0.method_11(int_12, "H", this.class538_0.method_42()));
				base.method_9(this.class538_0);
				this.class538_2 = new Class538(base.method_8(string.Format("NoteImage{0}T", int_12), this.class409_0.method_19() + "T") ?? this.class538_0.method_54(), Enum115.const_5, this.class538_0.origins_0, Enum114.const_1, this.Position, 0.7975f, false, Color.get_White());
				this.class538_2.float_3 = this.class538_0.float_3;
				this.class538_2.method_43(!class297_1.class421_0.class546_0.method_11(int_12, "T", true));
				base.method_9(this.class538_2);
				this.list_1.Add(this.class538_2);
				this.class538_1 = new Class538(base.method_8(string.Format("NoteImage{0}L", int_12), this.class409_0.method_19() + "L"), Enum115.const_5, this.class538_0.origins_0, Enum114.const_1, this.Position, 0.795f, false, Color.get_White());
				this.class538_1.float_3 = this.class538_0.float_3;
				this.class538_1.method_53(30.0);
				this.class538_1.bool_16 = false;
				this.class538_1.method_43(class297_1.class421_0.class546_0.method_11(int_12, "L", true));
				base.method_9(this.class538_1);
				this.list_1.Add(this.class538_1);
			}
		}

		// Token: 0x0600224F RID: 8783
		// RVA: 0x000CA934 File Offset: 0x000C8B34
		internal void method_10(bool bool_14)
		{
			Class340 class = this.class297_0.class296_0.method_40((double)((bool_14 ? this.StartTime : this.EndTime) + 2));
			if (class == null)
			{
				return;
			}
			if (bool_14)
			{
				base.method_6(class, this.hitObjectSoundType_1, this.sampleSet_0, this.sampleSet_1);
				return;
			}
			base.method_6(class, this.hitObjectSoundType_0, this.sampleSet_2, this.sampleSet_3);
		}

		// Token: 0x06002250 RID: 8784
		// RVA: 0x000CA9A0 File Offset: 0x000C8BA0
		internal Enum61 method_11()
		{
			Enum61 result = Enum61.flag_5;
			if (this.int_10 != -1 && Class331.int_7 <= this.EndTime && Class331.int_7 >= this.StartTime && Class331.int_7 - this.int_10 >= Class420.int_2)
			{
				this.int_10 += Class420.int_2;
				result = Enum61.flag_40;
			}
			return result;
		}

		// Token: 0x06002251 RID: 8785
		// RVA: 0x0001B825 File Offset: 0x00019A25
		internal Enum61 method_12()
		{
			this.class538_1.bool_16 = true;
			this.int_10 = Class331.int_7;
			this.vmethod_23();
			if (!this.bool_7)
			{
				((Class300)this.class297_0).method_44(this);
			}
			return Enum61.flag_5;
		}

		// Token: 0x06002252 RID: 8786
		// RVA: 0x0001B85E File Offset: 0x00019A5E
		internal void method_13()
		{
			if (Class331.int_7 > this.StartTime + this.class297_0.HitWindow50 && this.int_7 == 0)
			{
				this.vmethod_25();
			}
		}

		// Token: 0x0600224E RID: 8782
		// RVA: 0x0001B814 File Offset: 0x00019A14
		internal override void vmethod_12()
		{
			if (this.bool_10)
			{
				this.method_10(false);
			}
		}

		// Token: 0x0600224D RID: 8781
		// RVA: 0x0001B80D File Offset: 0x00019A0D
		internal override void vmethod_18()
		{
			Class331.smethod_94();
		}

		// Token: 0x06002254 RID: 8788
		// RVA: 0x000CA9FC File Offset: 0x000C8BFC
		internal override Enum61 vmethod_2()
		{
			this.class538_1.bool_16 = false;
			this.int_10 = -1;
			if (this.bool_0)
			{
				return this.enum61_0;
			}
			if (Class331.int_7 < this.StartTime + this.class297_0.HitWindow50 && this.int_7 == 0)
			{
				return Enum61.flag_5;
			}
			this.method_13();
			if (Class331.int_7 < this.EndTime - this.class297_0.HitWindow50)
			{
				if (this.bool_6)
				{
					return Enum61.flag_5;
				}
				this.vmethod_18();
				this.vmethod_25();
				this.bool_13 = true;
				return Enum61.flag_0;
			}
			else
			{
				if (Class331.int_7 < this.EndTime + this.class297_0.HitWindow50 && this.bool_6)
				{
					return Enum61.flag_5;
				}
				this.vmethod_18();
				this.bool_0 = true;
				this.enum61_0 = Enum61.flag_4;
				int num;
				if (this.int_7 < this.StartTime - this.class297_0.HitWindow50)
				{
					num = this.EndTime - 1;
				}
				else if (this.int_7 < this.StartTime)
				{
					num = this.StartTime + (this.StartTime - this.int_7);
				}
				else
				{
					num = this.int_7;
				}
				int num2;
				if (this.bool_6)
				{
					num2 = Class331.int_7;
				}
				else if (this.int_8 > this.EndTime)
				{
					num2 = this.EndTime - (this.int_8 - this.EndTime);
				}
				else
				{
					num2 = this.int_8;
				}
				Math.Abs(num2 - num);
				int num3 = Math.Abs(num - this.StartTime);
				int num4 = Math.Abs(num2 - this.EndTime);
				int num5 = num3 + num4;
				Class300 class = this.class297_0 as Class300;
				if (num2 < this.EndTime - class.HitWindow50)
				{
					this.enum61_0 = Enum61.flag_4;
				}
				else if ((double)num3 <= (double)class.int_17 * 1.2 && (double)num5 <= (double)class.int_17 * 2.4)
				{
					this.enum61_0 = Enum61.flag_37;
				}
				else if ((double)num3 <= (double)class.HitWindow300 * 1.1 && (double)num5 <= (double)class.HitWindow300 * 2.2)
				{
					this.enum61_0 = Enum61.flag_36;
				}
				else if (num3 <= class.int_18 && num5 <= class.int_18 * 2)
				{
					this.enum61_0 = Enum61.flag_35;
				}
				else if (num3 <= class.HitWindow100 && num5 <= class.HitWindow100 * 2)
				{
					this.enum61_0 = Enum61.flag_34;
				}
				else
				{
					this.enum61_0 = Enum61.flag_33;
				}
				if (this.enum61_0 >= Enum61.flag_36 && this.bool_13)
				{
					this.enum61_0 = Enum61.flag_35;
				}
				if (this.enum61_0 > Enum61.flag_5)
				{
					this.vmethod_12();
				}
				if (!this.bool_7 && Class331.int_7 >= this.EndTime - this.class297_0.HitWindow50)
				{
					this.vmethod_24();
				}
				else
				{
					this.vmethod_25();
				}
				return this.enum61_0;
			}
		}

		// Token: 0x0600224C RID: 8780
		// RVA: 0x000CA8E0 File Offset: 0x000C8AE0
		internal override void vmethod_23()
		{
			SampleSet sampleSet = SampleSet.None;
			SampleSet sampleSet2 = SampleSet.None;
			if (this.class297_0.class296_0.int_6 >= 14)
			{
				sampleSet = this.sampleSet_4;
				sampleSet2 = this.sampleSet_5;
			}
			Class331.smethod_63(this.SoundType, sampleSet, sampleSet2, false, null);
			this.method_10(true);
		}

		// Token: 0x06002253 RID: 8787
		// RVA: 0x0001B887 File Offset: 0x00019A87
		internal override void vmethod_25()
		{
			if (!this.bool_7)
			{
				((Class300)this.class297_0).method_45(this);
				base.vmethod_25();
			}
		}
	}
}
