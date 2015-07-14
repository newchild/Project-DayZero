using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns59;
using ns69;
using ns76;
using ns8;
using ns82;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns62
{
	// Token: 0x02000427 RID: 1063
	internal sealed class Class495 : Class494
	{
		// Token: 0x02000428 RID: 1064
		[CompilerGenerated]
		private sealed class Class499
		{
			// Token: 0x04001ABB RID: 6843
			public string string_0;

			// Token: 0x06002244 RID: 8772
			// RVA: 0x0001B7CE File Offset: 0x000199CE
			public void method_0(Class312 class312_0)
			{
				class312_0.method_5(this.string_0);
			}
		}

		// Token: 0x02000429 RID: 1065
		[CompilerGenerated]
		private sealed class Class500
		{
			// Token: 0x04001ABC RID: 6844
			public Class322 class322_0;

			// Token: 0x04001ABD RID: 6845
			public string string_0;

			// Token: 0x06002246 RID: 8774
			// RVA: 0x0001B7DC File Offset: 0x000199DC
			public void method_0(Class312 class312_0)
			{
				class312_0.method_5(this.string_0);
			}

			// Token: 0x06002247 RID: 8775
			// RVA: 0x0001B7EA File Offset: 0x000199EA
			public bool method_1(Class312 class312_0)
			{
				return class312_0.EndTime == this.class322_0.EndTime;
			}

			// Token: 0x06002248 RID: 8776
			// RVA: 0x0001B7DC File Offset: 0x000199DC
			public void method_2(Class312 class312_0)
			{
				class312_0.method_5(this.string_0);
			}
		}

		// Token: 0x0200042A RID: 1066
		[CompilerGenerated]
		private sealed class Class501
		{
			// Token: 0x04001ABE RID: 6846
			public string string_0;

			// Token: 0x0600224A RID: 8778
			// RVA: 0x0001B7FF File Offset: 0x000199FF
			public void method_0(Class312 class312_0)
			{
				class312_0.method_5(this.string_0);
			}
		}

		// Token: 0x04001AB7 RID: 6839
		private bool[] bool_0;

		// Token: 0x04001AB1 RID: 6833
		internal Class30 class30_0 = new Class30(1337);

		// Token: 0x04001AB2 RID: 6834
		internal Class30 class30_1 = new Class30(1337);

		// Token: 0x04001AB3 RID: 6835
		internal Class30 class30_2 = new Class30(10086);

		// Token: 0x04001AB9 RID: 6841
		private double double_0 = 2147483647.0;

		// Token: 0x04001ABA RID: 6842
		private Enum48 enum48_0 = Enum48.const_12;

		// Token: 0x04001AB5 RID: 6837
		private int int_0;

		// Token: 0x04001AB6 RID: 6838
		private int int_1;

		// Token: 0x04001AB8 RID: 6840
		private List<int> list_0;

		// Token: 0x04001AB4 RID: 6836
		private Vector2 vector2_0;

		// Token: 0x0600223B RID: 8763
		// RVA: 0x000C9E00 File Offset: 0x000C8000
		public Class495(Class297 class297_1) : base(class297_1)
		{
			if (!this.class297_0.bool_0)
			{
				Enum45 enum = (!Class802.smethod_0() || Class876.smethod_5(Mods.Autoplay)) ? Enum45.flag_1 : Enum45.flag_0;
				Class435.smethod_0(0, enum | Enum45.flag_2);
			}
			int num = (int)Math.Round((double)(this.class297_0.class296_0.DifficultyHpDrainRate + this.class297_0.class296_0.DifficultyCircleSize)) * 20 + (int)((double)this.class297_0.class296_0.DifficultyOverall * 41.2) + (int)Math.Round((double)this.class297_0.class296_0.DifficultyApproachRate);
			this.class30_0.method_0(num);
			this.class30_1.method_0(num);
			this.list_0 = new List<int>(7);
			this.method_2(Vector2.get_Zero(), 0);
			this.bool_0 = new bool[Class421.smethod_3(this.class297_0.class296_0, this.class297_0.class623_0)];
		}

		// Token: 0x0600223C RID: 8764
		// RVA: 0x000C9F4C File Offset: 0x000C814C
		internal int method_0(float float_0, float float_1, float float_2, float float_3, float float_4)
		{
			double num = this.class30_0.method_3();
			if (num >= (double)float_4)
			{
				return 6;
			}
			if (num >= (double)float_3)
			{
				return 5;
			}
			if (num >= (double)float_2)
			{
				return 4;
			}
			if (num >= (double)float_1)
			{
				return 3;
			}
			if (num >= (double)float_0)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0600223D RID: 8765
		// RVA: 0x000C9F8C File Offset: 0x000C818C
		private void method_1(int int_2)
		{
			if (this.list_0.Count == 7)
			{
				this.list_0.RemoveAt(0);
			}
			this.list_0.Add(int_2);
			if (this.list_0.Count >= 2)
			{
				this.double_0 = (double)(this.list_0[this.list_0.Count - 1] - this.list_0[0]) / (double)this.list_0.Count;
			}
		}

		// Token: 0x0600223E RID: 8766
		// RVA: 0x0001B7B0 File Offset: 0x000199B0
		private void method_2(Vector2 vector2_1, int int_2)
		{
			this.int_1 = int_2 - this.int_0;
			this.int_0 = int_2;
			this.vector2_0 = vector2_1;
		}

		// Token: 0x0600223F RID: 8767
		// RVA: 0x000CA008 File Offset: 0x000C8208
		internal override Class305 vmethod_0(Vector2 vector2_1, int int_2, bool bool_1, HitObjectSoundType hitObjectSoundType_0, int int_3, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_4, string string_0)
		{
			Action<Class312> action = null;
			Class495.Class499 class = new Class495.Class499();
			class.string_0 = string_0;
			Class315 class2 = null;
			if (this.class297_0.class296_0.method_5() == PlayModes.OsuMania)
			{
				class2 = new Class315(this.class297_0, vector2_1, int_2, hitObjectSoundType_0, Enum48.const_14, this.bool_0);
				class2.sampleSet_0 = sampleSet_0;
				class2.sampleSet_1 = sampleSet_1;
				class2.enum38_0 = enum38_0;
				class2.int_3 = int_4;
				class2.method_8();
				List<Class312> arg_84_0 = class2.list_2;
				if (action == null)
				{
					action = new Action<Class312>(class.method_0);
				}
				arg_84_0.ForEach(action);
				this.method_2(vector2_1, int_2);
			}
			else
			{
				this.method_1(int_2);
				int num = int_2 - this.int_0;
				double num2 = this.class297_0.class296_0.method_36((double)int_2, false);
				Enum48 enum;
				if (num <= 80)
				{
					enum = (Enum48)6;
				}
				else if (num <= 95)
				{
					enum = ((Enum48)6 | this.enum48_0);
				}
				else if (num <= 105)
				{
					enum = (Enum48)10;
				}
				else if (num <= 125)
				{
					enum = Enum48.const_2;
				}
				else
				{
					float num3 = (vector2_1 - this.vector2_0).Length();
					Class340 class3 = this.class297_0.class296_0.method_39((double)int_2);
					if (num <= 135 && num3 < 20f)
					{
						enum = (Enum48)1028;
					}
					else if (num <= 150 && num3 < 20f)
					{
						enum = (Enum48)9;
					}
					else if (num3 < 20f && this.double_0 >= num2 / 2.5)
					{
						enum = (Enum48)520;
					}
					else if (this.double_0 >= num2 / 2.5 && (class3 == null || !class3.method_2()))
					{
						enum = Enum48.const_4;
					}
					else
					{
						enum = Enum48.const_0;
					}
				}
				class2 = new Class315(this.class297_0, vector2_1, int_2, hitObjectSoundType_0, enum, this.bool_0);
				class2.sampleSet_0 = sampleSet_0;
				class2.sampleSet_1 = sampleSet_1;
				class2.enum38_0 = enum38_0;
				class2.int_3 = int_4;
				class2.method_8();
				this.bool_0 = new bool[this.class297_0.class421_0.list_0.Count];
				foreach (Class312 current in class2.list_2)
				{
					this.bool_0[current.int_6] = true;
					if ((enum & Enum48.const_12) > Enum48.const_0 && current.int_6 == this.class297_0.class421_0.list_0.Count - 1)
					{
						this.enum48_0 = Enum48.const_13;
					}
					else if ((enum & Enum48.const_13) > Enum48.const_0 && current.int_6 == this.class297_0.class421_0.method_37())
					{
						this.enum48_0 = Enum48.const_12;
					}
					current.method_5(class.string_0);
				}
				this.method_2(vector2_1, int_2);
			}
			return class2;
		}

		// Token: 0x06002240 RID: 8768
		// RVA: 0x000CA2E0 File Offset: 0x000C84E0
		internal override Class320 vmethod_1(Vector2 vector2_1, int int_2, bool bool_1, HitObjectSoundType hitObjectSoundType_0, CurveTypes curveTypes_0, int int_3, double double_1, List<Vector2> list_1, List<HitObjectSoundType> list_2, int int_4, SampleSet sampleSet_0, SampleSet sampleSet_1, List<SampleSet> list_3, List<SampleSet> list_4, Enum38 enum38_0, int int_5, string string_0)
		{
			Action<Class312> action = null;
			Predicate<Class312> predicate = null;
			Action<Class312> action2 = null;
			Class495.Class500 class = new Class495.Class500();
			class.string_0 = string_0;
			if (this.class297_0.class296_0.method_5() == PlayModes.OsuMania)
			{
				class.class322_0 = new Class322(this.class297_0, vector2_1, int_2, hitObjectSoundType_0, int_3, double_1, list_1, list_2, Enum48.const_14, this.bool_0);
				class.class322_0.sampleSet_0 = sampleSet_0;
				class.class322_0.sampleSet_1 = sampleSet_1;
				class.class322_0.enum38_0 = enum38_0;
				class.class322_0.int_3 = int_5;
				class.class322_0.method_32();
				List<Class312> arg_BD_0 = class.class322_0.list_11;
				if (action == null)
				{
					action = new Action<Class312>(class.method_0);
				}
				arg_BD_0.ForEach(action);
				this.method_2(vector2_1, class.class322_0.EndTime);
			}
			else
			{
				Class340 class2 = this.class297_0.class296_0.method_39((double)int_2);
				Enum48 enum48_ = Enum48.const_0;
				if (class2 != null && !class2.method_2())
				{
					enum48_ = Enum48.const_4;
				}
				class.class322_0 = new Class322(this.class297_0, vector2_1, int_2, hitObjectSoundType_0, int_3, double_1, list_1, list_2, enum48_, this.bool_0);
				class.class322_0.sampleSet_0 = sampleSet_0;
				class.class322_0.sampleSet_1 = sampleSet_1;
				class.class322_0.list_9 = list_3;
				class.class322_0.list_10 = list_4;
				class.class322_0.enum38_0 = enum38_0;
				class.class322_0.int_3 = int_5;
				class.class322_0.method_32();
				this.bool_0 = new bool[this.class297_0.class421_0.list_0.Count];
				if (class.class322_0.list_11.Count > 1)
				{
					List<Class312> arg_1D6_0 = class.class322_0.list_11;
					if (predicate == null)
					{
						predicate = new Predicate<Class312>(class.method_1);
					}
					using (List<Class312>.Enumerator enumerator = arg_1D6_0.FindAll(predicate).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class312 current = enumerator.Current;
							this.bool_0[current.int_6] = true;
						}
						goto IL_233;
					}
				}
				this.bool_0[class.class322_0.list_11[0].int_6] = true;
				IL_233:
				List<Class312> arg_254_0 = class.class322_0.list_11;
				if (action2 == null)
				{
					action2 = new Action<Class312>(class.method_2);
				}
				arg_254_0.ForEach(action2);
				int num = (class.class322_0.EndTime - int_2) / int_3;
				while (int_3-- >= 0)
				{
					this.method_2(vector2_1, int_2);
					this.method_1(int_2);
					int_2 += num;
				}
			}
			return class.class322_0;
		}

		// Token: 0x06002241 RID: 8769
		// RVA: 0x000CA590 File Offset: 0x000C8790
		internal override Class325 vmethod_2(int int_2, int int_3, HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_4, string string_0)
		{
			Class495.Class501 class = new Class495.Class501();
			class.string_0 = string_0;
			Class326 class2 = new Class326(this.class297_0, int_2, int_3, hitObjectSoundType_0, Enum48.const_2, this.bool_0);
			class2.sampleSet_0 = sampleSet_0;
			class2.sampleSet_1 = sampleSet_1;
			class2.enum38_0 = enum38_0;
			class2.int_3 = int_4;
			class2.method_8();
			class2.list_2.ForEach(new Action<Class312>(class.method_0));
			this.method_2(new Vector2(256f, 192f), int_3);
			this.method_1(int_3);
			return class2;
		}

		// Token: 0x06002242 RID: 8770
		// RVA: 0x000CA61C File Offset: 0x000C881C
		internal override Class305 vmethod_3(Vector2 vector2_1, int int_2, int int_3, bool bool_1, HitObjectSoundType hitObjectSoundType_0, int int_4, SampleSet sampleSet_0, SampleSet sampleSet_1, Enum38 enum38_0, int int_5, string string_0)
		{
			Class314 class = new Class314(this.class297_0, this.class297_0.class421_0.method_43(vector2_1, false), int_2, int_3, hitObjectSoundType_0);
			class.sampleSet_0 = sampleSet_0;
			class.sampleSet_1 = sampleSet_1;
			class.enum38_0 = enum38_0;
			class.int_3 = int_5;
			class.method_5(string_0);
			this.method_2(vector2_1, int_3);
			this.method_1(int_3);
			return class;
		}
	}
}
