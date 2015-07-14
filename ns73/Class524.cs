using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns26;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;

namespace ns73
{
	// Token: 0x0200050C RID: 1292
	internal sealed class Class524 : Class520
	{
		// Token: 0x04002276 RID: 8822
		private Class538 class538_0;

		// Token: 0x04002277 RID: 8823
		private Dictionary<Enum60, Class679> dictionary_0 = new Dictionary<Enum60, Class679>();

		// Token: 0x04002278 RID: 8824
		internal Enum60 enum60_0;

		// Token: 0x04002279 RID: 8825
		internal Enum60 enum60_1;

		// Token: 0x1700038E RID: 910
		internal Vector2 Position
		{
			// Token: 0x06002998 RID: 10648
			// RVA: 0x0001FF4F File Offset: 0x0001E14F
			set
			{
				this.class538_0.vector2_1 = value;
			}
		}

		// Token: 0x0600299B RID: 10651
		// RVA: 0x0001FF82 File Offset: 0x0001E182
		public Class524() : base(false)
		{
		}

		// Token: 0x06002996 RID: 10646
		// RVA: 0x00107644 File Offset: 0x00105844
		internal override void Initialize()
		{
			this.class911_0.bool_8 = false;
			this.class538_0 = new Class538(null, Enum115.const_5, Origins.BottomLeft, Enum114.const_1, Vector2.get_Zero(), 1f, true, Color.get_White());
			this.class538_0.method_49(new VoidDelegate(this.method_0));
			this.class538_0.float_2 = 0.6f;
			this.class911_0.Add(this.class538_0);
			this.dictionary_0.Add(Enum60.const_4, new Class679(Class885.smethod_27("pippidonclear", Enum112.flag_6, false), new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				5,
				6,
				5,
				4,
				3,
				2,
				1,
				0
			}, 100.0));
			this.dictionary_0.Add(Enum60.const_2, new Class679(Class885.smethod_27("pippidonfail", Enum112.flag_6, false), null, 0.0));
			this.dictionary_0.Add(Enum60.const_3, new Class679(Class885.smethod_27("pippidonkiai", Enum112.flag_6, false), null, 0.0));
			this.dictionary_0.Add(Enum60.const_1, new Class679(Class885.smethod_27("pippidonidle", Enum112.flag_6, false), null, 0.0));
			this.method_1(Enum60.const_1, false);
			base.Initialize();
		}

		// Token: 0x06002997 RID: 10647
		// RVA: 0x0001FF34 File Offset: 0x0001E134
		private void method_0()
		{
			this.class538_0.loopTypes_0 = LoopTypes.LoopForever;
			this.method_1(this.enum60_0, false);
		}

		// Token: 0x06002999 RID: 10649
		// RVA: 0x00107770 File Offset: 0x00105970
		internal void method_1(Enum60 enum60_2, bool bool_0)
		{
			if (!bool_0)
			{
				this.enum60_0 = enum60_2;
			}
			this.enum60_1 = enum60_2;
			if (this.class538_0.loopTypes_0 == LoopTypes.LoopOnce)
			{
				return;
			}
			Class679 class = this.dictionary_0[enum60_2];
			this.class538_0.method_55(class.class731_0);
			this.class538_0.method_53((class.double_0 != 0.0) ? class.double_0 : Class331.smethod_8());
			this.class538_0.method_57(class.int_0);
			this.class538_0.loopTypes_0 = (bool_0 ? LoopTypes.LoopOnce : LoopTypes.LoopForever);
		}

		// Token: 0x0600299A RID: 10650
		// RVA: 0x0001FF5D File Offset: 0x0001E15D
		internal override void vmethod_0()
		{
			if (this.class538_0.loopTypes_0 == LoopTypes.LoopForever)
			{
				this.class538_0.method_53(Class331.smethod_8());
			}
			base.vmethod_0();
		}
	}
}
