using Microsoft.Xna.Framework;
using ns23;
using ns26;
using ns60;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using System;
using System.Collections.Generic;

namespace ns62
{
	// Token: 0x02000434 RID: 1076
	internal sealed class Class322 : Class321
	{
		// Token: 0x04001B16 RID: 6934
		private bool[] bool_14;

		// Token: 0x04001B18 RID: 6936
		private Class495 class495_0;

		// Token: 0x04001B14 RID: 6932
		private Enum48 enum48_0;

		// Token: 0x04001B15 RID: 6933
		private int int_12;

		// Token: 0x04001B17 RID: 6935
		private int int_13;

		// Token: 0x04001B13 RID: 6931
		internal List<Class312> list_11;

		// Token: 0x0600229E RID: 8862
		// RVA: 0x000CF2F8 File Offset: 0x000CD4F8
		internal Class322(Class297 class297_1, Vector2 vector2_4, int int_14, HitObjectSoundType hitObjectSoundType_0, int int_15, double double_3, List<Vector2> list_12, List<HitObjectSoundType> list_13, Enum48 enum48_1, bool[] bool_15) : base(class297_1, vector2_4, int_14, false, hitObjectSoundType_0, CurveTypes.Bezier, int_15, double_3, list_12, list_13, 0)
		{
			this.class495_0 = (this.class297_0.class494_0 as Class495);
			this.list_11 = new List<Class312>();
			this.EndTime = base.method_8();
			this.enum48_0 = enum48_1;
			this.int_12 = base.Length / int_15;
			this.class297_0.class421_0.method_43(vector2_4, false);
			this.bool_14 = bool_15;
			for (int i = 0; i < bool_15.Length; i++)
			{
				if (bool_15[i])
				{
					this.int_13++;
				}
			}
		}

		// Token: 0x060022A4 RID: 8868
		// RVA: 0x000CFA08 File Offset: 0x000CDC08
		private void Add(int int_14, int int_15, int int_16, int int_17, int int_18)
		{
			if (int_18 == 0)
			{
				int_18 = int_17;
			}
			int int_19 = this.int_3;
			if ((this.enum48_0 & Enum48.const_14) == Enum48.const_0)
			{
				if (this.int_3 != 0)
				{
					int_19 = Math.Min(this.int_3, this.int_3 * 4 / 3 / int_18);
				}
				else
				{
					Class340 class = this.class297_0.class296_0.method_39((double)this.StartTime);
					if (class != null)
					{
						int_19 = Math.Min(class.int_0, class.int_0 * 4 / 3 / int_18);
					}
				}
			}
			if (int_15 == int_16)
			{
				Class312 class2 = new Class312(this.class297_0, int_14, int_15, this.method_34(int_15));
				class2.sampleSet_0 = this.method_35(int_15);
				class2.sampleSet_1 = this.method_36(int_15);
				class2.enum38_0 = this.enum38_0;
				class2.int_3 = int_19;
				class2.int_9 = int_17;
				this.list_11.Add(class2);
				return;
			}
			Class313 class3 = new Class313(this.class297_0, int_14, int_15, int_16, this.SoundType);
			class3.hitObjectSoundType_1 = this.method_34(int_15);
			class3.hitObjectSoundType_0 = this.method_34(int_16);
			class3.sampleSet_0 = this.method_35(int_15);
			class3.sampleSet_1 = this.method_36(int_15);
			class3.sampleSet_2 = this.method_35(int_16);
			class3.sampleSet_3 = this.method_36(int_16);
			class3.sampleSet_4 = this.sampleSet_0;
			class3.sampleSet_5 = this.sampleSet_1;
			class3.enum38_0 = this.enum38_0;
			class3.int_3 = int_19;
			class3.int_9 = int_17;
			this.list_11.Add(class3);
		}

		// Token: 0x0600229F RID: 8863
		// RVA: 0x000CF3A0 File Offset: 0x000CD5A0
		internal void method_32()
		{
			int int_ = this.class297_0.class421_0.method_43(this.Position, false);
			int segmentCount = this.SegmentCount;
			if ((this.enum48_0 & Enum48.const_14) <= Enum48.const_0)
			{
				if (this.class297_0.class421_0.list_0.Count != 1)
				{
					if (segmentCount > 1)
					{
						if (this.int_12 <= 90)
						{
							this.method_38(1, this.StartTime, this.EndTime - this.StartTime);
							return;
						}
						if (this.int_12 <= 120)
						{
							this.enum48_0 |= Enum48.const_2;
							this.method_40(this.StartTime, this.int_12, segmentCount);
							return;
						}
						if (this.int_12 <= 160)
						{
							this.method_39(this.StartTime, this.int_12, segmentCount);
							return;
						}
						if (this.int_12 <= 200 && this.class297_0.class296_0.method_23() > 3.0)
						{
							this.method_41(this.StartTime, this.int_12, segmentCount);
							return;
						}
						int num = this.EndTime - this.StartTime;
						if (num >= 4000)
						{
							this.method_33(this.StartTime, num, 1f, 1f, 0.77f);
							return;
						}
						if (this.int_12 > 400 && num < 4000 && segmentCount < this.class297_0.class421_0.list_0.Count - 1 - this.class297_0.class421_0.method_37())
						{
							this.method_37(segmentCount, this.StartTime, this.int_12);
							return;
						}
						this.method_42(this.StartTime, this.int_12, segmentCount);
						return;
					}
					else
					{
						if (this.int_12 <= 110)
						{
							if (this.int_13 < this.class297_0.class421_0.list_0.Count)
							{
								this.enum48_0 |= Enum48.const_2;
							}
							else
							{
								this.enum48_0 &= (Enum48)(-3);
							}
							this.method_40(this.StartTime, this.int_12, (this.int_12 < 80) ? 0 : 1);
							return;
						}
						if (this.class297_0.class296_0.method_23() > 6.5)
						{
							if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
							{
								this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 0.7f, 0.22f);
								return;
							}
							this.method_33(this.StartTime, this.EndTime - this.StartTime, 0.97f, 0.64f, 0.15f);
							return;
						}
						else if (this.class297_0.class296_0.method_23() > 4.0)
						{
							if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
							{
								this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 0.92f, 0.57f);
								return;
							}
							this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 0.82f, 0.44f);
							return;
						}
						else if (this.class297_0.class296_0.method_23() > 2.5)
						{
							if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
							{
								this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 1f, 0.7f);
								return;
							}
							this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 0.92f, 0.63f);
							return;
						}
						else
						{
							if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
							{
								this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 1f, 0.83f);
								return;
							}
							this.method_33(this.StartTime, this.EndTime - this.StartTime, 1f, 1f, 0.73f);
							return;
						}
					}
				}
			}
			this.Add(int_, this.StartTime, this.EndTime, 1, 0);
		}

		// Token: 0x060022A0 RID: 8864
		// RVA: 0x000CF78C File Offset: 0x000CD98C
		private void method_33(int int_14, int int_15, float float_1, float float_2, float float_3)
		{
			switch (this.class297_0.class421_0.list_0.Count)
			{
			case 2:
				float_1 = 1f;
				float_2 = 1f;
				float_3 = 1f;
				break;
			case 3:
				float_1 = 1f;
				float_2 = 1f;
				float_3 = Math.Max(float_3, 0.9f);
				break;
			case 4:
				float_1 = 1f;
				float_2 = Math.Max(float_2, 0.96f);
				float_3 = Math.Max(float_3, 0.7f);
				break;
			case 5:
				float_1 = Math.Max(float_1, 0.97f);
				float_2 = Math.Max(float_2, 0.9f);
				float_3 = Math.Max(float_3, 0.66f);
				break;
			}
			if ((this.enum48_0 & Enum48.const_4) == Enum48.const_0 && (this.SoundType.IsType(HitObjectSoundType.Finish | HitObjectSoundType.Clap) || this.method_34(int_14).IsType(HitObjectSoundType.Finish | HitObjectSoundType.Clap)))
			{
				float_3 = 0f;
			}
			this.method_38(this.class495_0.method_0(float_3, float_2, float_1, 1f, 1f), int_14, int_15);
		}

		// Token: 0x060022A1 RID: 8865
		// RVA: 0x000CF8A4 File Offset: 0x000CDAA4
		private HitObjectSoundType method_34(int int_14)
		{
			if (this.bool_10)
			{
				return this.SoundType;
			}
			int num = (this.int_12 == 0) ? 0 : ((int_14 - this.StartTime) / this.int_12);
			if (num < this.list_8.Count)
			{
				return this.list_8[num];
			}
			return this.list_8[this.list_8.Count - 1];
		}

		// Token: 0x060022A2 RID: 8866
		// RVA: 0x000CF910 File Offset: 0x000CDB10
		private SampleSet method_35(int int_14)
		{
			if (this.bool_10 || (this.enum48_0 & Enum48.const_14) > Enum48.const_0)
			{
				return this.sampleSet_0;
			}
			int num = (this.int_12 == 0) ? 0 : ((int_14 - this.StartTime) / this.int_12);
			if (num >= this.list_9.Count)
			{
				return this.list_9[this.list_9.Count - 1];
			}
			return this.list_9[num];
		}

		// Token: 0x060022A3 RID: 8867
		// RVA: 0x000CF98C File Offset: 0x000CDB8C
		private SampleSet method_36(int int_14)
		{
			if (this.bool_10 || (this.enum48_0 & Enum48.const_14) > Enum48.const_0)
			{
				return this.sampleSet_1;
			}
			int num = (this.int_12 == 0) ? 0 : ((int_14 - this.StartTime) / this.int_12);
			if (num >= this.list_10.Count)
			{
				return this.list_10[this.list_10.Count - 1];
			}
			return this.list_10[num];
		}

		// Token: 0x060022A5 RID: 8869
		// RVA: 0x000CFB88 File Offset: 0x000CDD88
		private void method_37(int int_14, int int_15, int int_16)
		{
			int num = int_15;
			int int_17 = int_15 + int_16 * int_14;
			int i = Math.Min(int_14, this.class297_0.class421_0.list_0.Count);
			bool[] array = new bool[this.class297_0.class421_0.list_0.Count];
			int num2 = this.class297_0.class421_0.method_43(this.Position, true);
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0 && this.int_13 < this.class297_0.class421_0.list_0.Count)
			{
				while (this.bool_14[num2])
				{
					num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
			}
			while (i > 0)
			{
				while (array[num2])
				{
					num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
				this.Add(num2, num, int_17, int_14, 0);
				array[num2] = true;
				num += int_16;
				i--;
			}
		}

		// Token: 0x060022A6 RID: 8870
		// RVA: 0x000CFCBC File Offset: 0x000CDEBC
		private void method_38(int int_14, int int_15, int int_16)
		{
			int num = this.class297_0.class421_0.list_0.Count - this.class297_0.class421_0.method_37() - this.int_13;
			if (num >= int_14)
			{
				bool[] array = new bool[this.class297_0.class421_0.list_0.Count];
				int num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				for (int i = 0; i < int_14; i++)
				{
					while (array[num2] || this.bool_14[num2])
					{
						num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
					}
					this.Add(num2, int_15, int_15 + int_16, int_14, 0);
					array[num2] = true;
				}
				return;
			}
			int num3 = int_14;
			bool[] array2 = new bool[this.class297_0.class421_0.list_0.Count];
			int num4 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
			for (int j = 0; j < num; j++)
			{
				while (array2[num4] || this.bool_14[num4])
				{
					num4 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
				this.Add(num4, int_15, int_15 + int_16, int_14, 0);
				array2[num4] = true;
				num3--;
			}
			for (int k = 0; k < num3; k++)
			{
				while (array2[num4])
				{
					num4 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
				this.Add(num4, int_15, int_15 + int_16, int_14, 0);
				array2[num4] = true;
			}
		}

		// Token: 0x060022A7 RID: 8871
		// RVA: 0x000CFEEC File Offset: 0x000CE0EC
		private void method_39(int int_14, int int_15, int int_16)
		{
			int num = this.class297_0.class421_0.method_43(this.Position, true);
			bool flag = this.class495_0.class30_0.method_3() > 0.5;
			while (int_16 >= 0)
			{
				int_16--;
				this.Add(num, int_14, int_14, 1, 0);
				int_14 += int_15;
				if (flag)
				{
					if (num >= this.class297_0.class421_0.list_0.Count - 1)
					{
						flag = false;
						num--;
					}
					else
					{
						num++;
					}
				}
				else if (num <= this.class297_0.class421_0.method_37())
				{
					flag = true;
					num++;
				}
				else
				{
					num--;
				}
			}
		}

		// Token: 0x060022A8 RID: 8872
		// RVA: 0x000CFF98 File Offset: 0x000CE198
		private void method_40(int int_14, int int_15, int int_16)
		{
			int num = this.class297_0.class421_0.method_43(this.Position, true);
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0 && this.int_13 < this.class297_0.class421_0.list_0.Count)
			{
				while (this.bool_14[num])
				{
					num = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
			}
			int num2 = num;
			while (int_16 >= 0)
			{
				this.Add(num, int_14, int_14, 1, 0);
				while (num == num2)
				{
					num = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
				num2 = num;
				int_14 += int_15;
				int_16--;
			}
		}

		// Token: 0x060022A9 RID: 8873
		// RVA: 0x000D0084 File Offset: 0x000CE284
		private void method_41(int int_14, int int_15, int int_16)
		{
			bool flag = this.class297_0.class421_0.list_0.Count >= 4 && this.class297_0.class421_0.list_0.Count <= 8;
			int num = this.class495_0.class30_0.method_2(1, this.class297_0.class421_0.list_0.Count - (flag ? 1 : 0));
			int num2 = this.class297_0.class421_0.method_43(this.Position, true);
			while (int_16 >= 0)
			{
				this.Add(num2, int_14, int_14, 2, 0);
				num2 += num;
				if (num2 >= this.class297_0.class421_0.list_0.Count - this.class297_0.class421_0.method_37())
				{
					num2 = num2 - this.class297_0.class421_0.list_0.Count - this.class297_0.class421_0.method_37() + (flag ? 1 : 0);
				}
				num2 += this.class297_0.class421_0.method_37();
				if (this.class297_0.class421_0.list_0.Count > 2)
				{
					this.Add(num2, int_14, int_14, 2, 0);
				}
				num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				int_14 += int_15;
				int_16--;
			}
		}

		// Token: 0x060022AA RID: 8874
		// RVA: 0x000D01FC File Offset: 0x000CE3FC
		private void method_42(int int_14, int int_15, int int_16)
		{
			int num = this.class297_0.class421_0.method_43(this.Position, true);
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0 && this.int_13 < this.class297_0.class421_0.list_0.Count)
			{
				while (this.bool_14[num])
				{
					num = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
				}
			}
			this.Add(num, int_14, this.EndTime, 1, 0);
			bool[] array = new bool[this.class297_0.class421_0.list_0.Count];
			int num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
			int num3;
			if (this.class297_0.class296_0.method_23() > 6.5)
			{
				num3 = this.class495_0.method_0(0.37f, 1f, 1f, 1f, 1f);
			}
			else if (this.class297_0.class296_0.method_23() > 4.0)
			{
				num3 = this.class495_0.method_0((this.class297_0.class421_0.list_0.Count < 6) ? 0.88f : 0.55f, 1f, 1f, 1f, 1f);
			}
			else if (this.class297_0.class296_0.method_23() > 2.5)
			{
				num3 = this.class495_0.method_0((this.class297_0.class421_0.list_0.Count < 6) ? 1f : 0.76f, 1f, 1f, 1f, 1f);
			}
			else
			{
				num3 = 0;
			}
			num3 = Math.Min(num3, this.class297_0.class421_0.list_0.Count - 1);
			bool flag = this.method_34(int_14) <= HitObjectSoundType.Normal;
			while (int_16 >= 0)
			{
				if (!flag || int_14 != this.StartTime)
				{
					for (int i = 0; i < num3; i++)
					{
						while (array[num2] || num2 == num)
						{
							num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
						}
						int int_17 = num3 + 1;
						int int_18 = num3 + ((int_16 == this.SegmentCount || int_16 == 0) ? 1 : 0);
						this.Add(num2, int_14, int_14, int_17, int_18);
						array[num2] = true;
					}
				}
				int_14 += int_15;
				array = new bool[this.class297_0.class421_0.list_0.Count];
				int_16--;
			}
		}
	}
}
