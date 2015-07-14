using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns23;
using ns59;
using ns70;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;

namespace ns62
{
	// Token: 0x02000436 RID: 1078
	internal sealed class Class326 : Class325
	{
		// Token: 0x04001B1A RID: 6938
		private bool[] bool_6;

		// Token: 0x04001B1C RID: 6940
		private Enum48 enum48_0;

		// Token: 0x04001B1B RID: 6939
		private int int_6;

		// Token: 0x04001B19 RID: 6937
		internal List<Class312> list_2;

		// Token: 0x17000375 RID: 885
		public override int ComboNumber
		{
			// Token: 0x060022B1 RID: 8881
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
			// Token: 0x060022B2 RID: 8882
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000374 RID: 884
		public override Vector2 EndPosition
		{
			// Token: 0x060022B3 RID: 8883
			// RVA: 0x000060D8 File Offset: 0x000042D8
			get
			{
				throw new NotImplementedException();
			}
			// Token: 0x060022B4 RID: 8884
			// RVA: 0x000060D8 File Offset: 0x000042D8
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060022AD RID: 8877
		// RVA: 0x000D05AC File Offset: 0x000CE7AC
		internal Class326(Class297 class297_1, int int_7, int int_8, HitObjectSoundType hitObjectSoundType_0, Enum48 enum48_1, bool[] bool_7) : base(class297_1, int_7, int_8, hitObjectSoundType_0)
		{
			this.bool_6 = bool_7;
			for (int i = 0; i < bool_7.Length; i++)
			{
				if (bool_7[i])
				{
					this.int_6++;
				}
			}
			this.enum48_0 = enum48_1;
			if (this.int_6 == this.class297_0.class421_0.list_0.Count)
			{
				this.enum48_0 &= (Enum48)(-3);
			}
			this.list_2 = new List<Class312>();
		}

		// Token: 0x060022AF RID: 8879
		// RVA: 0x000D0798 File Offset: 0x000CE998
		private void Add(int int_7, int int_8, int int_9)
		{
			if (int_8 == int_9)
			{
				Class312 class = new Class312(this.class297_0, int_7, int_8, this.SoundType);
				class.sampleSet_0 = this.sampleSet_0;
				class.sampleSet_1 = this.sampleSet_1;
				class.enum38_0 = this.enum38_0;
				class.int_3 = this.int_3;
				class.int_9 = 1;
				this.list_2.Add(class);
				return;
			}
			Class313 class2 = new Class313(this.class297_0, int_7, int_8, int_9, HitObjectSoundType.Normal);
			class2.hitObjectSoundType_1 = HitObjectSoundType.Normal;
			class2.hitObjectSoundType_0 = this.SoundType;
			class2.sampleSet_0 = this.sampleSet_0;
			class2.sampleSet_1 = this.sampleSet_1;
			class2.sampleSet_2 = this.sampleSet_0;
			class2.sampleSet_3 = this.sampleSet_1;
			class2.enum38_0 = this.enum38_0;
			class2.int_3 = this.int_3;
			class2.int_9 = 1;
			this.list_2.Add(class2);
		}

		// Token: 0x060022B8 RID: 8888
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Class304 Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022AE RID: 8878
		// RVA: 0x000D0630 File Offset: 0x000CE830
		internal void method_8()
		{
			if ((this.enum48_0 & Enum48.const_14) > Enum48.const_0)
			{
				this.Add(0, this.StartTime, this.EndTime);
				return;
			}
			if (this.EndTime - this.StartTime < 100)
			{
				if (this.class297_0.class421_0.list_0.Count != 8)
				{
					this.Add(this.method_9(0), this.StartTime, this.StartTime);
					return;
				}
				if (this.SoundType.IsType(HitObjectSoundType.Finish) && this.EndTime - this.StartTime < 1000)
				{
					this.Add(0, this.StartTime, this.StartTime);
					return;
				}
				this.Add(this.method_9(this.class297_0.class421_0.method_37()), this.StartTime, this.StartTime);
				return;
			}
			else
			{
				if (this.class297_0.class421_0.list_0.Count != 8)
				{
					this.Add(this.method_9(0), this.StartTime, this.EndTime);
					return;
				}
				if (this.SoundType.IsType(HitObjectSoundType.Finish) && this.EndTime - this.StartTime < 1000)
				{
					this.Add(0, this.StartTime, this.EndTime);
					return;
				}
				this.Add(this.method_9(this.class297_0.class421_0.method_37()), this.StartTime, this.EndTime);
				return;
			}
		}

		// Token: 0x060022B0 RID: 8880
		// RVA: 0x000D0880 File Offset: 0x000CEA80
		private int method_9(int int_7)
		{
			Class495 class = this.class297_0.class494_0 as Class495;
			int num = class.class30_0.method_2(int_7, this.class297_0.class421_0.list_0.Count);
			if ((this.enum48_0 & Enum48.const_2) > Enum48.const_0)
			{
				while (this.bool_6[num])
				{
					num = class.class30_0.method_2(int_7, this.class297_0.class421_0.list_0.Count);
				}
			}
			return num;
		}

		// Token: 0x060022B9 RID: 8889
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void Select()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022B6 RID: 8886
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_0(Color color_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022BD RID: 8893
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022BE RID: 8894
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_19(int int_7)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022B7 RID: 8887
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override Enum61 vmethod_2()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022BA RID: 8890
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_3()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022BB RID: 8891
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_4(int int_7)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022BC RID: 8892
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_5(Vector2 vector2_1, bool bool_7)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022B5 RID: 8885
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override bool vmethod_9()
		{
			throw new NotImplementedException();
		}
	}
}
