using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns26;
using ns59;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns82;
using ns89;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns23
{
	// Token: 0x0200041B RID: 1051
	internal sealed class Class299 : Class298
	{
		// Token: 0x0200041C RID: 1052
		[CompilerGenerated]
		private sealed class Class490
		{
			// Token: 0x04001A67 RID: 6759
			public double double_0;

			// Token: 0x060021BD RID: 8637
			// RVA: 0x0001B258 File Offset: 0x00019458
			public bool method_0(Class705 class705_0)
			{
				return (double)class705_0.int_2 <= this.double_0 && (double)class705_0.int_0 >= this.double_0;
			}
		}

		// Token: 0x04001A5D RID: 6749
		private bool bool_2;

		// Token: 0x04001A66 RID: 6758
		private Class729 class729_0 = new Class729();

		// Token: 0x04001A64 RID: 6756
		private double[] double_0 = new double[]
		{
			-1.5707963267948966,
			0.0,
			1.0471975511965976,
			1.5707963267948966,
			3.1415926535897931
		};

		// Token: 0x04001A5E RID: 6750
		private int int_16 = -1;

		// Token: 0x04001A5F RID: 6751
		private int int_17;

		// Token: 0x04001A60 RID: 6752
		private int int_18;

		// Token: 0x04001A65 RID: 6757
		private int int_19;

		// Token: 0x04001A61 RID: 6753
		private List<int> list_7 = new List<int>();

		// Token: 0x04001A62 RID: 6754
		private List<Class304> list_8 = new List<Class304>();

		// Token: 0x04001A63 RID: 6755
		private Random random_0;

		// Token: 0x060021BB RID: 8635
		// RVA: 0x000C80F0 File Offset: 0x000C62F0
		public Class299() : base(true)
		{
		}

		// Token: 0x060021B5 RID: 8629
		// RVA: 0x000C795C File Offset: 0x000C5B5C
		internal override void Add(Class304 class304_2, bool bool_3)
		{
			if (!this.bool_2)
			{
				if (this.int_16 < 0)
				{
					this.int_16 = class304_2.StartTime;
				}
				this.int_17 = class304_2.EndTime;
				if (class304_2.NewCombo)
				{
					this.list_7.Add(class304_2.StartTime);
				}
				this.list_8.Add(class304_2);
				return;
			}
			base.Add(class304_2, bool_3);
		}

		// Token: 0x060021B9 RID: 8633
		// RVA: 0x000C800C File Offset: 0x000C620C
		private bool method_34(Vector2 vector2_0, int int_20)
		{
			int num = 5;
			float num2 = 2.5f * (1f - (float)int_20 / 10f);
			int num3 = 0;
			while (num3++ < num && this.int_14 - num3 - 1 >= 0)
			{
				if (Vector2.Distance(vector2_0, this.list_3[this.int_14 - num3 - 1].Position) < this.HitObjectRadius * num2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060021B4 RID: 8628
		// RVA: 0x000C7904 File Offset: 0x000C5B04
		protected override void vmethod_1()
		{
			if (Class802.smethod_0() && Class876.smethod_6(Class802.class512_0.class623_0, Mods.Target))
			{
				this.random_0 = new Random(Class802.class512_0.int_5);
				return;
			}
			this.random_0 = new Random(Class62.int_12);
		}

		// Token: 0x060021B7 RID: 8631
		// RVA: 0x000C79C0 File Offset: 0x000C5BC0
		internal override Enum61 vmethod_10(Class304 class304_2)
		{
			Enum61 enum = base.vmethod_10(class304_2);
			if (enum > Enum61.flag_5)
			{
				float num = (float)(this.random_0.NextDouble() * 3.1415926535897931 * 2.0);
				for (int i = 0; i < 5; i++)
				{
					double num2 = this.double_0[i] + (double)num;
					double num3 = 300.0 + this.random_0.NextDouble() * 100.0;
					Enum61 enum2 = enum & Enum61.flag_38;
					if (enum2 != Enum61.flag_14)
					{
						if (enum2 == Enum61.flag_15)
						{
							num3 *= 0.4;
						}
					}
					else
					{
						num3 *= 0.01;
					}
					num3 *= Math.Pow((double)((Class307)class304_2).float_0, 4.0);
					Vector2 value;
					value..ctor((float)(num3 * Math.Cos(num2)), (float)(num3 * Math.Sin(num2)));
					Class531 class = new Class531(Class885.Load("target-pt-" + (i + 1), Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_2, class304_2.EndPosition, 0.99f, false, class304_2.Colour, null);
					class.float_1 = num;
					class.method_26(class.float_2 * 0.8f, 600, Enum70.const_0);
					class.method_17(600);
					this.class911_0.Add(class);
					this.class729_0.Add(class, new Vector2?(value), false).float_0 = 100f;
					class = new Class531(Class885.Load("targetoverlay-pt-" + (i + 1), Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_2, class304_2.EndPosition, 1f, false, Color.get_White(), null);
					class.float_1 = num;
					class.method_26(class.float_2 * 0.8f, 600, Enum70.const_0);
					class.method_17(600);
					this.class911_0.Add(class);
					this.class729_0.Add(class, new Vector2?(value), false).float_0 = 100f;
				}
			}
			return enum;
		}

		// Token: 0x060021BA RID: 8634
		// RVA: 0x000C8078 File Offset: 0x000C6278
		internal override void vmethod_15()
		{
			this.class729_0.method_0();
			foreach (Class304 current in this.list_4)
			{
				current.Position = current.list_1[0].vector2_1;
			}
			base.vmethod_15();
		}

		// Token: 0x060021B8 RID: 8632
		// RVA: 0x000C7BD4 File Offset: 0x000C5DD4
		protected override void vmethod_18()
		{
			Predicate<Class705> predicate = null;
			Class299.Class490 class = new Class299.Class490();
			this.bool_2 = true;
			this.class296_0.float_1 = 0f;
			class.double_0 = (double)this.int_16;
			int num = 0;
			Vector2 vector;
			vector..ctor(256f, 197f);
			double num2 = 0.0;
			double num3 = this.random_0.NextDouble() * 3.1415926535897931 * 2.0;
			while (class.double_0 < (double)this.int_17)
			{
				double num4 = (class.double_0 - (double)this.int_16) / (double)(this.int_17 - this.int_16);
				bool flag = num % 8 == 0;
				if (this.int_18 < this.list_7.Count && class.double_0 >= (double)this.list_7[this.int_18])
				{
					this.int_18++;
				}
				if (flag)
				{
					num2 = (double)this.HitObjectRadius + (double)((int)(num4 * 40.0)) / 40.0 * 333.0;
				}
				Class340 class2 = this.class296_0.method_39(class.double_0);
				double num5 = class2.method_2() ? 1.2 : 1.0;
				if (flag)
				{
					num5 *= 1.5;
				}
				num3 += (this.random_0.NextDouble() - 0.5) * 2.0;
				Vector2 vector2;
				vector2.X = vector.X + (float)(num2 * num5 * Math.Cos(num3));
				vector2.Y = vector.Y + (float)(num2 * num5 * Math.Sin(num3));
				int num6 = 0;
				while (true)
				{
					if (vector2.X >= 0f && vector2.Y >= 0f && vector2.X <= 512f && vector2.Y <= 384f)
					{
						if (num2 <= (double)this.HitObjectRadius)
						{
							break;
						}
						if (!this.method_34(vector2, num6))
						{
							break;
						}
					}
					num3 = this.random_0.NextDouble() * 3.1415926535897931 * 2.0;
					vector2.X = vector.X + (float)(num2 * num5 * Math.Cos(num3));
					vector2.Y = vector.Y + (float)(num2 * num5 * Math.Sin(num3));
					if (++num6 > 10)
					{
						num5 *= 0.9;
					}
				}
				IL_278:
				vector = vector2;
				Class307 class3 = new Class307(this, vector + new Vector2(0f, -10f), (int)class.double_0, flag, HitObjectSoundType.Normal, 0);
				List<Class705> arg_2C4_0 = this.class872_0.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class705>(class.method_0);
				}
				if (arg_2C4_0.Find(predicate) == null)
				{
					int num7 = this.list_8.BinarySearch(class3);
					if (num7 < 0)
					{
						num7 = ~num7 - 1;
					}
					if (num7 >= 0 && num7 > this.int_19 && num7 < this.list_8.Count)
					{
						this.int_19 = num7;
						Class304 class4 = this.list_8[num7];
						class3.sampleSet_0 = class4.sampleSet_0;
						class3.sampleSet_1 = class4.sampleSet_1;
						class3.SoundType = class4.SoundType;
						class3.enum38_0 = class4.enum38_0;
					}
					foreach (Class531 current in class3.list_1)
					{
						current.class26_0.Add(new Class746(TransformationType.Scale, current.float_2 * 0.5f, current.float_2, (int)class.double_0 - this.PreEmpt, (int)class.double_0, Enum70.const_0));
					}
					this.vmethod_19(class3);
				}
				num++;
				class.double_0 += this.class296_0.method_36(class.double_0, false);
				continue;
				goto IL_278;
			}
			base.method_20(false);
			base.vmethod_18();
		}

		// Token: 0x060021B6 RID: 8630
		// RVA: 0x0001B243 File Offset: 0x00019443
		internal override void vmethod_8(bool bool_3, bool bool_4)
		{
			base.vmethod_8(bool_3, bool_4);
			this.PreEmpt = 1500;
		}
	}
}
