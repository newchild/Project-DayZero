using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns23;
using ns26;
using ns59;
using ns60;
using ns70;
using ns79;
using ns82;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns61
{
	// Token: 0x0200054D RID: 1357
	internal sealed class Class310 : Class306
	{
		// Token: 0x0400247C RID: 9340
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x0400247D RID: 9341
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x04002477 RID: 9335
		private bool bool_10;

		// Token: 0x04002478 RID: 9336
		private bool bool_11;

		// Token: 0x0400247A RID: 9338
		[CompilerGenerated]
		private bool bool_12;

		// Token: 0x0400247B RID: 9339
		[CompilerGenerated]
		private bool bool_13;

		// Token: 0x04002472 RID: 9330
		private bool bool_6;

		// Token: 0x04002474 RID: 9332
		private bool bool_7;

		// Token: 0x04002475 RID: 9333
		private bool bool_8;

		// Token: 0x04002476 RID: 9334
		private bool bool_9;

		// Token: 0x04002479 RID: 9337
		private Enum61 enum61_1;

		// Token: 0x04002473 RID: 9331
		private int int_7;

		// Token: 0x17000396 RID: 918
		public override int ComboNumber
		{
			// Token: 0x06002BCE RID: 11214
			// RVA: 0x00021700 File Offset: 0x0001F900
			get
			{
				return -1;
			}
			// Token: 0x06002BCF RID: 11215
			// RVA: 0x00021703 File Offset: 0x0001F903
			set
			{
				base.ComboNumber = -1;
			}
		}

		// Token: 0x06002BCB RID: 11211
		// RVA: 0x0011C124 File Offset: 0x0011A324
		public Class310(Class297 class297_1, Vector2 vector2_1, int int_8, bool bool_14, HitObjectSoundType hitObjectSoundType_0, bool bool_15) : base(class297_1, vector2_1, int_8, bool_14, hitObjectSoundType_0, 0)
		{
			this.method_8(false);
			this.method_10((this.SoundType & ~HitObjectSoundType.Finish & ~HitObjectSoundType.Normal) == HitObjectSoundType.None);
			float num = this.vmethod_26();
			foreach (Class531 current in this.list_1)
			{
				current.float_2 *= num;
			}
			if (this.method_9())
			{
				base.vmethod_0(new Color(235, 69, 44));
			}
			else
			{
				base.vmethod_0(new Color(67, 142, 172));
			}
			if (this.class538_0 != null)
			{
				this.class538_0.bool_16 = false;
			}
			this.list_1.ForEach(delegate(Class531 class531_4)
			{
				class531_4.enum115_0 = Enum115.const_1;
			});
			this.bool_2 = bool_15;
		}

		// Token: 0x06002BCA RID: 11210
		// RVA: 0x000216F7 File Offset: 0x0001F8F7
		[CompilerGenerated]
		private void method_10(bool bool_14)
		{
			this.bool_13 = bool_14;
		}

		// Token: 0x06002BD4 RID: 11220
		// RVA: 0x0001488D File Offset: 0x00012A8D
		private bool method_11()
		{
			return this.SoundType.IsType(HitObjectSoundType.Finish);
		}

		// Token: 0x06002BC8 RID: 11208
		// RVA: 0x000216E6 File Offset: 0x0001F8E6
		[CompilerGenerated]
		private void method_8(bool bool_14)
		{
			this.bool_12 = bool_14;
		}

		// Token: 0x06002BC9 RID: 11209
		// RVA: 0x000216EF File Offset: 0x0001F8EF
		[CompilerGenerated]
		internal bool method_9()
		{
			return this.bool_13;
		}

		// Token: 0x06002BDB RID: 11227
		// RVA: 0x0001BBF8 File Offset: 0x00019DF8
		[CompilerGenerated]
		private static void smethod_5(Class531 class531_4)
		{
			class531_4.class26_0.Clear();
		}

		// Token: 0x06002BD0 RID: 11216
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_1()
		{
		}

		// Token: 0x06002BD2 RID: 11218
		// RVA: 0x0011C22C File Offset: 0x0011A42C
		internal override void vmethod_12()
		{
			Class340 class = this.class297_0.class296_0.method_39((double)(this.StartTime + 5));
			int int_ = (this.int_3 != 0) ? this.int_3 : class.int_0;
			Class297.smethod_5(new Struct69(this.SoundType, class.sampleSet_0, class.enum38_0, int_, SampleSet.None));
			if (this.SoundType.IsType(HitObjectSoundType.Finish))
			{
				Class331.smethod_62(new Struct69(this.method_9() ? HitObjectSoundType.Finish : HitObjectSoundType.Whistle, class.sampleSet_0, class.enum38_0, int_, SampleSet.None), this.vmethod_14(), true);
			}
		}

		// Token: 0x06002BD1 RID: 11217
		// RVA: 0x000156CE File Offset: 0x000138CE
		protected override float vmethod_14()
		{
			return 0f;
		}

		// Token: 0x06002BD6 RID: 11222
		// RVA: 0x0011C47C File Offset: 0x0011A67C
		internal override Enum61 vmethod_2()
		{
			int num = Math.Abs(Class331.int_7 - this.StartTime);
			if (num < this.class297_0.HitWindow300 && !this.bool_11)
			{
				this.enum61_0 = Enum61.flag_16;
			}
			else if (num < this.class297_0.HitWindow100 && !this.bool_11)
			{
				this.enum61_0 = Enum61.flag_15;
			}
			else
			{
				this.enum61_0 = Enum61.flag_3;
			}
			if (!this.bool_6)
			{
				if (this.method_11() && this.enum61_0 != Enum61.flag_3)
				{
					if (this.bool_9)
					{
						this.bool_0 = true;
						this.method_8(true);
						this.enum61_0 |= Enum61.flag_28;
					}
					else
					{
						this.bool_6 = true;
						this.enum61_1 = this.enum61_0;
						this.int_7 = Class331.int_7;
						this.enum61_0 |= Enum61.flag_31;
					}
				}
				else
				{
					this.bool_0 = true;
				}
				if (this.enum61_0 > Enum61.flag_5)
				{
					this.vmethod_12();
				}
				this.vmethod_8(this.enum61_0 > Enum61.flag_5);
				return this.enum61_0;
			}
			if (this.bool_10 && this.method_11())
			{
				this.bool_0 = true;
				this.bool_5 = false;
				if (Class331.int_7 - this.int_7 < 30 && this.bool_8 != this.bool_7)
				{
					this.method_8(true);
					return this.enum61_1 | Enum61.flag_32;
				}
			}
			return Enum61.flag_5;
		}

		// Token: 0x06002BD3 RID: 11219
		// RVA: 0x0011C2C4 File Offset: 0x0011A4C4
		internal override bool vmethod_20(Vector2 vector2_1, bool bool_14, float float_0)
		{
			this.bool_8 = this.bool_7;
			this.bool_7 = false;
			this.bool_9 = false;
			this.bool_11 = false;
			bool flag = false;
			if (Class802.bool_4 || Class802.bool_6 || Class62.bool_15)
			{
				if (!this.method_9() && !Class62.bool_15)
				{
					this.bool_11 = true;
				}
				else
				{
					flag = true;
					this.bool_7 = Class802.bool_4;
					this.bool_9 = (Class802.bool_4 && Class802.bool_6);
				}
			}
			if (Class802.bool_19 || Class802.bool_21)
			{
				if (this.method_9() && !Class62.bool_15)
				{
					this.bool_11 = true;
				}
				else
				{
					flag = true;
					this.bool_7 = Class802.bool_19;
					this.bool_9 = (Class802.bool_19 && Class802.bool_21);
				}
			}
			if (this.bool_11 && !this.bool_6)
			{
				return Math.Abs(this.StartTime - Class331.int_7) <= this.class297_0.HitWindow50 && !this.bool_0;
			}
			this.bool_10 = (this.bool_6 && this.method_11());
			bool flag2 = Class802.bool_4 || Class802.bool_6;
			if (this.bool_10)
			{
				if (flag2)
				{
					if (!Class802.bool_3 || !Class802.bool_5)
					{
						this.bool_10 = false;
					}
				}
				else if (!Class802.bool_18 || !Class802.bool_20)
				{
					this.bool_10 = false;
				}
				this.bool_10 &= (Class331.int_7 - this.int_7 < 30);
			}
			return ((Math.Abs(this.StartTime - Class331.int_7) <= this.class297_0.HitWindow50 && !this.bool_6) || this.bool_10) && flag && !this.bool_0;
		}

		// Token: 0x06002BD8 RID: 11224
		// RVA: 0x00021756 File Offset: 0x0001F956
		protected override int vmethod_22()
		{
			return (int)(600.0 / this.class297_0.SliderVelocityAt(this.StartTime) / 0.60000002384185791 * 1000.0);
		}

		// Token: 0x06002BD5 RID: 11221
		// RVA: 0x0002170C File Offset: 0x0001F90C
		internal override string vmethod_23()
		{
			if (!this.method_11())
			{
				return "taikohitcircle";
			}
			return "taikobigcircle";
		}

		// Token: 0x06002BCD RID: 11213
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_24()
		{
			return false;
		}

		// Token: 0x06002BCC RID: 11212
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_25()
		{
			return false;
		}

		// Token: 0x06002BD9 RID: 11225
		// RVA: 0x00021788 File Offset: 0x0001F988
		protected override float vmethod_26()
		{
			if (!this.method_11())
			{
				return 0.65f;
			}
			return 1f;
		}

		// Token: 0x06002BD7 RID: 11223
		// RVA: 0x00021721 File Offset: 0x0001F921
		internal override void vmethod_8(bool bool_14)
		{
			if (bool_14)
			{
				List<Class531> arg_26_0 = this.list_1;
				if (Class310.action_3 == null)
				{
					Class310.action_3 = new Action<Class531>(Class310.smethod_5);
				}
				arg_26_0.ForEach(Class310.action_3);
				return;
			}
			base.vmethod_8(false);
		}
	}
}
