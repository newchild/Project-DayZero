using ns26;
using ns59;
using ns60;
using osu.GameplayElements.HitObjects;
using osu_common;
using System;
using System.Runtime.CompilerServices;

namespace ns23
{
	// Token: 0x02000531 RID: 1329
	internal sealed class Class301 : Class297
	{
		// Token: 0x02000532 RID: 1330
		[CompilerGenerated]
		private sealed class Class701
		{
			// Token: 0x040023C7 RID: 9159
			public Class304 class304_0;

			// Token: 0x06002B13 RID: 11027
			// RVA: 0x001171AC File Offset: 0x001153AC
			public bool method_0(Class304 class304_1)
			{
				return class304_1.StartTime <= this.class304_0.StartTime && class304_1.EndTime >= this.class304_0.EndTime && class304_1.Position.X == this.class304_0.Position.X;
			}
		}

		// Token: 0x040023C6 RID: 9158
		private bool bool_2;

		// Token: 0x06002B0C RID: 11020
		// RVA: 0x0001B20E File Offset: 0x0001940E
		internal Class301(bool bool_3) : base(bool_3)
		{
		}

		// Token: 0x06002B0F RID: 11023
		// RVA: 0x00021028 File Offset: 0x0001F228
		internal override void vmethod_16()
		{
			this.bool_2 = false;
			base.vmethod_16();
			if (!this.bool_2 && Class331.smethod_30())
			{
				Class331.smethod_94();
			}
		}

		// Token: 0x06002B10 RID: 11024
		// RVA: 0x0011707C File Offset: 0x0011527C
		protected override void vmethod_17(Class304 class304_2)
		{
			Class321 class = class304_2 as Class321;
			if (class != null && Class331.int_7 >= class.StartTime && Class331.int_7 <= class.EndTime)
			{
				class.method_24();
				this.bool_2 = true;
			}
			if (Class331.enum100_0 == Enum100.const_1 && Class331.float_2 < 300f)
			{
				if ((class304_2.StartTime <= Class331.int_7 && class304_2.StartTime >= Class331.int_9 && !class304_2.IsType(HitObjectType.Spinner)) || (class304_2.EndTime <= Class331.int_7 && class304_2.EndTime >= Class331.int_9))
				{
					if (!class304_2.bool_3)
					{
						class304_2.vmethod_12();
						class304_2.bool_3 = true;
					}
				}
				else if (class304_2.bool_3 && (float)Math.Abs(class304_2.StartTime - Class331.int_7) > Class331.float_2 * 4f)
				{
					class304_2.bool_3 = false;
				}
			}
			base.vmethod_17(class304_2);
		}

		// Token: 0x06002B0E RID: 11022
		// RVA: 0x00116FC4 File Offset: 0x001151C4
		protected override void vmethod_21(Class320 class320_0)
		{
			if (this.class296_0.method_5() == PlayModes.OsuMania)
			{
				this.Add(new Class308(this, class320_0.Position, class320_0.StartTime, false, class320_0.Whistle, class320_0.Finish, class320_0.Clap, 0)
				{
					EndTime = ((Class321)class320_0).method_8(),
					int_2 = class320_0.int_2,
					string_0 = class320_0.string_0,
					sampleSet_0 = class320_0.sampleSet_0,
					sampleSet_1 = class320_0.sampleSet_1,
					int_3 = class320_0.int_3,
					enum38_0 = class320_0.enum38_0
				}, false);
				class320_0.Dispose();
				return;
			}
			this.Add(class320_0, false);
		}

		// Token: 0x06002B0D RID: 11021
		// RVA: 0x0001B217 File Offset: 0x00019417
		internal override Class494 vmethod_7()
		{
			return new Class497(this);
		}

		// Token: 0x06002B11 RID: 11025
		// RVA: 0x00117160 File Offset: 0x00115360
		internal override void vmethod_9(Class304 class304_2)
		{
			Class301.Class701 class = new Class301.Class701();
			class.class304_0 = class304_2;
			Class304 class2 = this.list_3.Find(new Predicate<Class304>(class.method_0));
			if (class2 != null)
			{
				base.Remove(class2, false);
			}
			this.Add(class.class304_0, false);
		}
	}
}
