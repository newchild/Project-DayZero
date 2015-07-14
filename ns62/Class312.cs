using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns59;
using ns69;
using ns70;
using ns77;
using ns79;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns62
{
	// Token: 0x02000424 RID: 1060
	internal class Class312 : Class305
	{
		// Token: 0x02000425 RID: 1061
		[CompilerGenerated]
		private sealed class Class493
		{
			// Token: 0x04001AAF RID: 6831
			public Vector2 vector2_0;

			// Token: 0x06002235 RID: 8757
			// RVA: 0x0001B793 File Offset: 0x00019993
			public void method_0(Class531 class531_0)
			{
				class531_0.vector2_1 = this.vector2_0;
			}
		}

		// Token: 0x04001AAD RID: 6829
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x04001AAE RID: 6830
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04001AA6 RID: 6822
		internal bool bool_6;

		// Token: 0x04001AAA RID: 6826
		internal bool bool_7;

		// Token: 0x04001AAB RID: 6827
		internal bool bool_8;

		// Token: 0x04001AAC RID: 6828
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04001AA1 RID: 6817
		internal Class409 class409_0;

		// Token: 0x04001AA9 RID: 6825
		internal Class538 class538_0;

		// Token: 0x04001AA3 RID: 6819
		internal Enum47 enum47_0;

		// Token: 0x04001AA8 RID: 6824
		internal float float_0;

		// Token: 0x04001AA2 RID: 6818
		internal int int_6;

		// Token: 0x04001AA4 RID: 6820
		internal int int_7;

		// Token: 0x04001AA5 RID: 6821
		internal int int_8;

		// Token: 0x04001AA7 RID: 6823
		internal int int_9 = 1;

		// Token: 0x17000371 RID: 881
		public override int ComboNumber
		{
			// Token: 0x06002220 RID: 8736
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return 0;
			}
			// Token: 0x06002221 RID: 8737
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		public override Vector2 EndPosition
		{
			// Token: 0x06002224 RID: 8740
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x06002225 RID: 8741
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700036F RID: 879
		public override bool NewCombo
		{
			// Token: 0x06002222 RID: 8738
			// RVA: 0x0001B6C7 File Offset: 0x000198C7
			get;
			// Token: 0x06002223 RID: 8739
			// RVA: 0x0001B6CF File Offset: 0x000198CF
			set;
		}

		// Token: 0x06002219 RID: 8729
		// RVA: 0x000C9A9C File Offset: 0x000C7C9C
		public Class312(Class297 class297_1, int int_10, int int_11, HitObjectSoundType hitObjectSoundType_0) : base(class297_1)
		{
			this.int_6 = int_10;
			int_10 = ((Class300)class297_1).method_35(int_10);
			this.class409_0 = class297_1.class421_0.list_0[int_10];
			this.Position = new Vector2(this.class409_0.method_10() - this.class409_0.method_8().method_23() + this.class409_0.method_12() / 2f, -100f);
			this.vector2_0 = this.Position;
			this.StartTime = int_11;
			this.EndTime = int_11;
			this.SoundType = hitObjectSoundType_0;
			if (!class297_1.class421_0.method_10())
			{
				this.class538_0 = new Class538(this.method_8("NoteImage" + int_10.ToString(), this.class409_0.method_19()), Enum115.const_5, class297_1.class421_0.method_45(Origins.BottomCentre), Enum114.const_1, this.Position, 0.8f, false, Color.get_White());
				this.class538_0.float_3 = 1f;
				this.class538_0.method_43(class297_1.class421_0.class546_0.method_11(int_10, "", true));
				this.method_9(this.class538_0);
				this.list_1.Add(this.class538_0);
			}
		}

		// Token: 0x06002229 RID: 8745
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Class304 Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600221A RID: 8730
		// RVA: 0x0001B667 File Offset: 0x00019867
		protected Class731[] method_8(string string_1, string string_2)
		{
			return this.class297_0.class421_0.class546_0.method_9(string_1, string_2, this.class297_0.class421_0.method_7());
		}

		// Token: 0x0600221B RID: 8731
		// RVA: 0x000C9BF0 File Offset: 0x000C7DF0
		protected void method_9(Class531 class531_0)
		{
			float num = this.class409_0.method_12() / (float)class531_0.int_4 * 1.6f;
			float num2 = (this.class409_0.method_8().class546_0.float_4 > 0f) ? this.class409_0.method_8().class546_0.float_4 : this.class409_0.method_8().method_34();
			float num3 = num2 / (float)class531_0.int_4 * 1.6f * (class531_0.method_42() ? -1f : 1f);
			class531_0.vector2_2 = new Vector2(num, num3);
		}

		// Token: 0x0600222A RID: 8746
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void Select()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002232 RID: 8754
		// RVA: 0x0001B778 File Offset: 0x00019978
		[CompilerGenerated]
		private static void smethod_5(Class531 class531_0)
		{
			class531_0.method_8(true);
		}

		// Token: 0x06002233 RID: 8755
		// RVA: 0x0001B781 File Offset: 0x00019981
		[CompilerGenerated]
		private static void smethod_6(Class531 class531_0)
		{
			class531_0.method_39(Color.get_Gray(), 60, false, Enum70.const_0);
		}

		// Token: 0x06002227 RID: 8743
		// RVA: 0x0001B6EB File Offset: 0x000198EB
		internal override void vmethod_0(Color color_0)
		{
			this.list_1[0].color_0 = color_0;
			this.Colour = color_0;
		}

		// Token: 0x0600221D RID: 8733
		// RVA: 0x000C9C90 File Offset: 0x000C7E90
		internal override void vmethod_12()
		{
			Class340 class = this.class297_0.class296_0.method_40((double)(this.StartTime + 2));
			if (class != null)
			{
				base.method_6(class, this.SoundType, this.sampleSet_0, this.sampleSet_1);
			}
		}

		// Token: 0x0600221C RID: 8732
		// RVA: 0x0001B690 File Offset: 0x00019890
		protected override float vmethod_14()
		{
			return (((float)this.class409_0 + 1f) / (float)this.class297_0.class421_0.list_0.Count - 0.5f) * 0.8f;
		}

		// Token: 0x0600222E RID: 8750
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600222F RID: 8751
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_10)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600221E RID: 8734
		// RVA: 0x000C9CD4 File Offset: 0x000C7ED4
		internal override Enum61 vmethod_2()
		{
			if (this.bool_0)
			{
				return this.enum61_0;
			}
			this.bool_0 = true;
			this.enum61_0 = Enum61.flag_4;
			if (this.bool_6)
			{
				int num = Math.Abs(this.int_7 - this.StartTime);
				Class300 class = this.class297_0 as Class300;
				if (num <= class.int_17)
				{
					this.enum61_0 = Enum61.flag_37;
				}
				else if (num <= class.HitWindow300)
				{
					this.enum61_0 = Enum61.flag_36;
				}
				else if (num <= class.int_18)
				{
					this.enum61_0 = Enum61.flag_35;
				}
				else if (num <= class.HitWindow100)
				{
					this.enum61_0 = Enum61.flag_34;
				}
				else if (num <= class.HitWindow50)
				{
					this.enum61_0 = Enum61.flag_33;
				}
				this.vmethod_12();
			}
			if (this.enum61_0 > Enum61.flag_33)
			{
				this.vmethod_24();
			}
			else
			{
				this.vmethod_25();
			}
			return this.enum61_0;
		}

		// Token: 0x0600221F RID: 8735
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_23()
		{
		}

		// Token: 0x06002230 RID: 8752
		// RVA: 0x0001B706 File Offset: 0x00019906
		internal virtual void vmethod_24()
		{
			if (!this.bool_8)
			{
				this.bool_8 = true;
				List<Class531> arg_32_0 = this.list_1;
				if (Class312.action_2 == null)
				{
					Class312.action_2 = new Action<Class531>(Class312.smethod_5);
				}
				arg_32_0.ForEach(Class312.action_2);
			}
		}

		// Token: 0x06002231 RID: 8753
		// RVA: 0x0001B73F File Offset: 0x0001993F
		internal virtual void vmethod_25()
		{
			if (!this.bool_7)
			{
				this.bool_7 = true;
				List<Class531> arg_32_0 = this.list_1;
				if (Class312.action_3 == null)
				{
					Class312.action_3 = new Action<Class531>(Class312.smethod_6);
				}
				arg_32_0.ForEach(Class312.action_3);
			}
		}

		// Token: 0x0600222B RID: 8747
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_3()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600222C RID: 8748
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_4(int int_10)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600222D RID: 8749
		// RVA: 0x000C9DC0 File Offset: 0x000C7FC0
		internal override void vmethod_5(Vector2 vector2_1, bool bool_10)
		{
			Class312.Class493 class = new Class312.Class493();
			class.vector2_0 = vector2_1;
			base.vmethod_5(class.vector2_0, bool_10);
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x06002228 RID: 8744
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_8(bool bool_10)
		{
		}

		// Token: 0x06002226 RID: 8742
		// RVA: 0x0001B6D8 File Offset: 0x000198D8
		internal override bool vmethod_9()
		{
			return this.list_1[0].bool_3;
		}
	}
}
