using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns26;
using ns59;
using ns70;
using ns79;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns62
{
	// Token: 0x02000439 RID: 1081
	internal sealed class Class315 : Class305
	{
		// Token: 0x0200043A RID: 1082
		[CompilerGenerated]
		private sealed class Class508
		{
			// Token: 0x04001B3F RID: 6975
			public int int_0;

			// Token: 0x04001B40 RID: 6976
			public int int_1;

			// Token: 0x06002303 RID: 8963
			// RVA: 0x0001BCDA File Offset: 0x00019EDA
			public void method_0(Class312 class312_0)
			{
				class312_0.int_3 = this.int_1;
				class312_0.int_9 = this.int_0;
			}
		}

		// Token: 0x0200043B RID: 1083
		[CompilerGenerated]
		private sealed class Class509
		{
			// Token: 0x04001B41 RID: 6977
			public Vector2 vector2_0;

			// Token: 0x06002305 RID: 8965
			// RVA: 0x0001BCF4 File Offset: 0x00019EF4
			public void method_0(Class531 class531_0)
			{
				class531_0.vector2_1 = this.vector2_0;
			}
		}

		// Token: 0x04001B3A RID: 6970
		private bool[] bool_6;

		// Token: 0x04001B3E RID: 6974
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04001B3D RID: 6973
		private Class495 class495_0;

		// Token: 0x04001B39 RID: 6969
		private Enum48 enum48_0;

		// Token: 0x04001B3B RID: 6971
		private int int_6;

		// Token: 0x04001B3C RID: 6972
		private int int_7;

		// Token: 0x04001B38 RID: 6968
		internal List<Class312> list_2;

		// Token: 0x17000378 RID: 888
		public override int ComboNumber
		{
			// Token: 0x060022F2 RID: 8946
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return 0;
			}
			// Token: 0x060022F3 RID: 8947
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		public override Vector2 EndPosition
		{
			// Token: 0x060022F6 RID: 8950
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x060022F7 RID: 8951
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000376 RID: 886
		public override bool NewCombo
		{
			// Token: 0x060022F4 RID: 8948
			// RVA: 0x0001BCB8 File Offset: 0x00019EB8
			get;
			// Token: 0x060022F5 RID: 8949
			// RVA: 0x0001BCC0 File Offset: 0x00019EC0
			set;
		}

		// Token: 0x060022E9 RID: 8937
		// RVA: 0x000D27E0 File Offset: 0x000D09E0
		public Class315(Class297 class297_1, Vector2 vector2_1, int int_8, HitObjectSoundType hitObjectSoundType_0, Enum48 enum48_1, bool[] bool_8) : base(class297_1)
		{
			this.list_2 = new List<Class312>();
			this.enum48_0 = enum48_1;
			this.bool_6 = bool_8;
			this.Position = vector2_1;
			this.vector2_0 = vector2_1;
			this.StartTime = int_8;
			this.SoundType = hitObjectSoundType_0;
			for (int i = 0; i < bool_8.Length; i++)
			{
				if (bool_8[i])
				{
					this.int_6++;
					this.int_7 = i;
				}
			}
		}

		// Token: 0x060022EF RID: 8943
		// RVA: 0x000D32C8 File Offset: 0x000D14C8
		private void Add(int int_8)
		{
			Class312 class = new Class312(this.class297_0, int_8, this.StartTime, this.SoundType);
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.enum38_0 = this.enum38_0;
			this.list_2.Add(class);
		}

		// Token: 0x060022FB RID: 8955
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Class304 Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022EC RID: 8940
		// RVA: 0x000D2EA4 File Offset: 0x000D10A4
		private void method_10(float float_0, float float_1, float float_2)
		{
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0)
			{
				this.method_9(float_1, (float_2 + float_1) / 2f, float_2, float_2 / 2f);
				return;
			}
			switch (this.class297_0.class421_0.list_0.Count)
			{
			case 2:
				float_2 = 1f;
				float_1 = 1f;
				float_0 = 1f;
				break;
			case 3:
				float_2 = 1f;
				float_1 = 1f;
				float_0 = Math.Max(0.97f, float_0);
				break;
			case 4:
				float_2 = Math.Max(0.8f, float_2 * 2f);
				float_1 = 1f;
				float_0 = 1f;
				break;
			case 5:
				float_1 = 1f;
				float_0 = Math.Max(0.97f, float_0);
				break;
			case 6:
				float_2 = Math.Max(0.5f, float_2 * 2f);
				float_1 = Math.Max(0.85f, float_1 * 2f);
				float_0 = 1f;
				break;
			}
			double num = this.class495_0.class30_0.method_3();
			bool flag = false;
			if (num > (double)float_0)
			{
				flag = true;
			}
			num = this.class495_0.class30_0.method_3();
			if (num >= (double)float_1)
			{
				this.method_12(3);
				flag = false;
			}
			else if (num >= (double)float_2)
			{
				this.method_12(2);
			}
			else
			{
				this.method_12(1);
			}
			if (flag && this.class297_0.class421_0.list_0.Count % 2 != 0)
			{
				this.Add(this.class297_0.class421_0.list_0.Count / 2);
			}
		}

		// Token: 0x060022ED RID: 8941
		// RVA: 0x000D3034 File Offset: 0x000D1234
		private void method_11(int int_8)
		{
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0)
			{
				int num = this.class297_0.class421_0.list_0.Count - this.class297_0.class421_0.method_37();
				for (int i = 0; i < this.class297_0.class421_0.list_0.Count; i++)
				{
					num -= (this.bool_6[i] ? 1 : 0);
				}
				if (int_8 > num)
				{
					int_8 = num;
				}
			}
			int num2 = this.class297_0.class421_0.method_43(this.Position, true);
			bool[] array = new bool[this.class297_0.class421_0.list_0.Count];
			while (int_8 > 0)
			{
				while (true)
				{
					if (!array[num2])
					{
						if (!this.bool_6[num2])
						{
							break;
						}
						if ((this.enum48_0 & Enum48.const_2) <= Enum48.const_0)
						{
							break;
						}
					}
					if ((this.enum48_0 & Enum48.const_8) > Enum48.const_0)
					{
						num2++;
						if (num2 == this.class297_0.class421_0.list_0.Count)
						{
							num2 = this.class297_0.class421_0.method_37();
						}
					}
					else
					{
						num2 = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), this.class297_0.class421_0.list_0.Count);
					}
				}
				IL_13C:
				this.Add(num2);
				array[num2] = true;
				int_8--;
				continue;
				goto IL_13C;
			}
		}

		// Token: 0x060022EE RID: 8942
		// RVA: 0x000D3194 File Offset: 0x000D1394
		private void method_12(int int_8)
		{
			bool[] array = new bool[this.class297_0.class421_0.list_0.Count];
			int int_9 = (this.class297_0.class421_0.list_0.Count % 2 == 0) ? (this.class297_0.class421_0.list_0.Count / 2) : ((this.class297_0.class421_0.list_0.Count - 1) / 2);
			int num = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), int_9);
			for (int i = 0; i < int_8; i++)
			{
				while (array[num])
				{
					num = this.class495_0.class30_0.method_2(this.class297_0.class421_0.method_37(), int_9);
				}
				array[num] = true;
				array[this.class297_0.class421_0.list_0.Count - num - 1 + this.class297_0.class421_0.method_37()] = true;
				this.Add(num);
				this.Add(this.class297_0.class421_0.list_0.Count - num - 1 + this.class297_0.class421_0.method_37());
			}
		}

		// Token: 0x060022F0 RID: 8944
		// RVA: 0x000D3320 File Offset: 0x000D1520
		private void method_13()
		{
			Class315.Class508 class = new Class315.Class508();
			class.int_0 = this.list_2.Count;
			if (class.int_0 == 0)
			{
				return;
			}
			class.int_1 = this.int_3;
			if ((this.enum48_0 & Enum48.const_14) == Enum48.const_0)
			{
				if (this.int_3 != 0)
				{
					class.int_1 = Math.Min(this.int_3, this.int_3 * 4 / 3 / class.int_0);
				}
				else
				{
					Class340 class2 = this.class297_0.class296_0.method_39((double)this.StartTime);
					if (class2 != null)
					{
						class.int_1 = Math.Min(class2.int_0, class2.int_0 * 4 / 3 / class.int_0);
					}
				}
			}
			this.list_2.ForEach(new Action<Class312>(class.method_0));
		}

		// Token: 0x060022EA RID: 8938
		// RVA: 0x000D2858 File Offset: 0x000D0A58
		internal void method_8()
		{
			this.class495_0 = (this.class297_0.class494_0 as Class495);
			if ((this.enum48_0 & Enum48.const_3) == Enum48.const_0)
			{
				if (this.SoundType.IsType(HitObjectSoundType.Finish) && this.class297_0.class421_0.list_0.Count != 8)
				{
					this.enum48_0 |= Enum48.const_9;
				}
				else if (this.SoundType.IsType(HitObjectSoundType.Clap))
				{
					this.enum48_0 |= Enum48.const_8;
				}
			}
			if ((this.enum48_0 & Enum48.const_14) <= Enum48.const_0)
			{
				if (this.class297_0.class421_0.list_0.Count != 1)
				{
					if ((this.enum48_0 & Enum48.const_10) > Enum48.const_0 && this.int_6 > 0)
					{
						for (int i = this.class297_0.class421_0.method_37(); i < this.bool_6.Length; i++)
						{
							if (this.bool_6[i])
							{
								this.Add(this.class297_0.class421_0.list_0.Count - i - 1 + this.class297_0.class421_0.method_37());
							}
						}
						this.method_13();
						return;
					}
					if ((this.enum48_0 & Enum48.const_11) > Enum48.const_0 && this.int_6 == 1 && (this.class297_0.class421_0.list_0.Count != 8 || this.int_7 != 0) && (this.class297_0.class421_0.list_0.Count % 2 == 0 || this.int_7 != this.class297_0.class421_0.list_0.Count / 2))
					{
						this.int_7 = this.class297_0.class421_0.list_0.Count - this.int_7 - 1 + this.class297_0.class421_0.method_37();
						this.Add(this.int_7);
						this.method_13();
						return;
					}
					if ((this.enum48_0 & Enum48.const_1) > Enum48.const_0 && this.int_6 > 0)
					{
						for (int j = this.class297_0.class421_0.method_37(); j < this.bool_6.Length; j++)
						{
							if (this.bool_6[j])
							{
								this.Add(j);
							}
						}
						this.method_13();
						return;
					}
					if ((this.enum48_0 & (Enum48)6144) > Enum48.const_0 && this.int_6 == 1)
					{
						if ((this.enum48_0 & Enum48.const_12) > Enum48.const_0)
						{
							this.int_7++;
							if (this.int_7 == this.class297_0.class421_0.list_0.Count)
							{
								this.int_7 = this.class297_0.class421_0.method_37();
							}
						}
						else
						{
							this.int_7--;
							if (this.int_7 == this.class297_0.class421_0.method_37() - 1)
							{
								this.int_7 = this.class297_0.class421_0.list_0.Count - 1;
							}
						}
						this.Add(this.int_7);
						this.method_13();
						return;
					}
					if ((this.enum48_0 & Enum48.const_3) > Enum48.const_0)
					{
						this.method_11(1);
						this.method_13();
						return;
					}
					if ((this.enum48_0 & Enum48.const_9) > Enum48.const_0)
					{
						if (this.class297_0.class296_0.method_23() > 6.5)
						{
							this.method_10(0.88f, 0.88f, 0.62f);
						}
						else if (this.class297_0.class296_0.method_23() > 4.0)
						{
							this.method_10(0.88f, 1f, 0.83f);
						}
						else
						{
							this.method_10(0.88f, 1f, 1f);
						}
					}
					else if (this.class297_0.class296_0.method_23() > 6.5)
					{
						if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
						{
							this.method_9(1f, 1f, 0.58f, 0.22f);
						}
						else
						{
							this.method_9(1f, 1f, 0.38f, 0f);
						}
					}
					else if (this.class297_0.class296_0.method_23() > 4.0)
					{
						if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
						{
							this.method_9(1f, 1f, 0.92f, 0.65f);
						}
						else
						{
							this.method_9(1f, 1f, 0.85f, 0.48f);
						}
					}
					else if (this.class297_0.class296_0.method_23() > 2.0)
					{
						if ((this.enum48_0 & Enum48.const_4) > Enum48.const_0)
						{
							this.method_9(1f, 1f, 1f, 0.82f);
						}
						else
						{
							this.method_9(1f, 1f, 1f, 0.55f);
						}
					}
					else
					{
						this.method_9(1f, 1f, 1f, 1f);
					}
					if (this.class297_0.class421_0.method_37() > 0 && this.SoundType.IsType(HitObjectSoundType.Finish | HitObjectSoundType.Clap))
					{
						this.Add(0);
					}
					this.method_13();
					return;
				}
			}
			this.Add(this.class297_0.class421_0.method_43(this.Position, false));
			this.method_13();
		}

		// Token: 0x060022EB RID: 8939
		// RVA: 0x000D2DA0 File Offset: 0x000D0FA0
		private void method_9(float float_0, float float_1, float float_2, float float_3)
		{
			switch (this.class297_0.class421_0.list_0.Count)
			{
			case 2:
				float_0 = 1f;
				float_1 = 1f;
				float_2 = 1f;
				float_3 = 1f;
				break;
			case 3:
				float_0 = 1f;
				float_1 = 1f;
				float_2 = 1f;
				float_3 = Math.Max(float_3, 0.9f);
				break;
			case 4:
				float_0 = 1f;
				float_1 = 1f;
				float_2 = Math.Max(float_2, 0.96f);
				float_3 = Math.Max(float_3, 0.77f);
				break;
			case 5:
				float_0 = 1f;
				float_1 = Math.Max(float_1, 0.97f);
				float_2 = Math.Max(float_2, 0.85f);
				break;
			}
			if (this.SoundType.IsType(HitObjectSoundType.Clap))
			{
				float_3 = 0f;
			}
			int int_ = this.class495_0.method_0(float_3, float_2, float_1, float_0, 1f);
			this.method_11(int_);
		}

		// Token: 0x060022FC RID: 8956
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void Select()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022F8 RID: 8952
		// RVA: 0x0001BCC9 File Offset: 0x00019EC9
		internal override void vmethod_0(Color color_0)
		{
			this.Colour = color_0;
		}

		// Token: 0x06002300 RID: 8960
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002301 RID: 8961
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_8)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022F9 RID: 8953
		// RVA: 0x0001BCD2 File Offset: 0x00019ED2
		internal override Enum61 vmethod_2()
		{
			return this.enum61_0;
		}

		// Token: 0x060022FD RID: 8957
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_3()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022FE RID: 8958
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_4(int int_8)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022FF RID: 8959
		// RVA: 0x000D33E8 File Offset: 0x000D15E8
		internal override void vmethod_5(Vector2 vector2_1, bool bool_8)
		{
			Class315.Class509 class = new Class315.Class509();
			class.vector2_0 = vector2_1;
			base.vmethod_5(class.vector2_0, bool_8);
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x060022FA RID: 8954
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_8(bool bool_8)
		{
		}

		// Token: 0x060022F1 RID: 8945
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_9()
		{
			return true;
		}
	}
}
