using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ns22;
using ns24;
using ns25;
using ns29;
using ns76;
using ns82;
using osu;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns18
{
	// Token: 0x0200051B RID: 1307
	internal sealed class Class65 : Class62
	{
		// Token: 0x040022E1 RID: 8929
		private Class84 class84_0;

		// Token: 0x06002A2E RID: 10798
		// RVA: 0x000205A1 File Offset: 0x0001E7A1
		protected override void Dispose(bool bool_48)
		{
			if (this.class84_0 != null)
			{
				this.class84_0.Dispose();
			}
			base.Dispose(bool_48);
		}

		// Token: 0x06002A35 RID: 10805
		// RVA: 0x00110328 File Offset: 0x0010E528
		public override void Draw()
		{
			if (this.class297_0 != null && Class876.smethod_5(Mods.Cinema))
			{
				this.class297_0.class911_0.float_0 = 0.01f;
				this.class911_2.float_0 = 0f;
				this.class911_10.float_0 = 0f;
				this.class911_8.float_0 = 0f;
				this.class911_7.float_0 = 0f;
				this.class911_3.float_0 = 0f;
				this.class911_4.float_0 = 0f;
			}
			base.Draw();
		}

		// Token: 0x06002A34 RID: 10804
		// RVA: 0x001102C4 File Offset: 0x0010E4C4
		public override void imethod_2()
		{
			if (!this.class523_0.bool_0)
			{
				base.imethod_2();
				return;
			}
			if (Class802.bool_16)
			{
				if (Class802.bool_0 && !Class62.bool_11)
				{
					this.vmethod_16();
				}
				else if (!Class802.bool_0 && Class62.bool_11)
				{
					this.vmethod_16();
				}
			}
			this.class84_0.imethod_2();
			base.imethod_2();
		}

		// Token: 0x06002A32 RID: 10802
		// RVA: 0x0001FD33 File Offset: 0x0001DF33
		public override void Initialize()
		{
			base.Initialize();
		}

		// Token: 0x06002A2F RID: 10799
		// RVA: 0x001100F0 File Offset: 0x0010E2F0
		protected override void vmethod_10()
		{
			this.class84_0 = new Class84(this);
			this.class84_0.Initialize();
			Class115.bool_25 = false;
			Class802.enum99_0 = Enum99.const_0;
			Class802.int_1 = 0;
			Class802.smethod_16();
			if (!Class802.bool_16)
			{
				Class858.Reset();
			}
			if (Class802.int_2 > 0)
			{
				Class62.class512_0 = Class802.class512_0;
				Class62.class512_0.list_0 = new List<Vector2>();
				Class62.class512_0.list_2 = new List<int>(Class466.Current.int_11);
				base.method_33(this.class297_0.class296_0);
			}
			if (Class802.class512_0.list_1.Count >= 2 && Class802.class512_0.list_1[1].int_0 < Class802.class512_0.list_1[0].int_0)
			{
				Class802.class512_0.list_1[1].int_0 = Class802.class512_0.list_1[0].int_0;
				Class802.class512_0.list_1[0].int_0 = 0;
			}
		}

		// Token: 0x06002A30 RID: 10800
		// RVA: 0x00110200 File Offset: 0x0010E400
		protected override bool vmethod_15(object object_0, Keys keys_0)
		{
			if (keys_0 != 70)
			{
				return base.vmethod_15(object_0, keys_0);
			}
			if (this.class84_0.class531_0 == null)
			{
				return false;
			}
			this.class84_0.class531_0.method_0(true);
			return true;
		}

		// Token: 0x06002A3A RID: 10810
		// RVA: 0x00020645 File Offset: 0x0001E845
		internal override void vmethod_26(bool bool_48)
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				Class115.smethod_70(OsuModes.SelectPlay, false);
				return;
			}
			base.vmethod_26(bool_48);
		}

		// Token: 0x06002A36 RID: 10806
		// RVA: 0x000205E4 File Offset: 0x0001E7E4
		protected override void vmethod_27()
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				this.class297_0.Draw();
				return;
			}
			base.vmethod_27();
		}

		// Token: 0x06002A33 RID: 10803
		// RVA: 0x000205BD File Offset: 0x0001E7BD
		protected override void vmethod_28()
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				return;
			}
			if (Class802.smethod_0())
			{
				this.class84_0.Draw();
			}
			base.vmethod_28();
		}

		// Token: 0x06002A38 RID: 10808
		// RVA: 0x0002061A File Offset: 0x0001E81A
		protected override void vmethod_29()
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				return;
			}
			base.vmethod_29();
		}

		// Token: 0x06002A39 RID: 10809
		// RVA: 0x0002062F File Offset: 0x0001E82F
		protected override bool vmethod_32()
		{
			return !Class876.smethod_5(Mods.Cinema) && base.vmethod_32();
		}

		// Token: 0x06002A37 RID: 10807
		// RVA: 0x00020604 File Offset: 0x0001E804
		public override bool vmethod_5()
		{
			return Class876.smethod_5(Mods.Cinema) || base.vmethod_5();
		}

		// Token: 0x06002A31 RID: 10801
		// RVA: 0x00110240 File Offset: 0x0010E440
		protected override bool vmethod_7(bool bool_48)
		{
			if (Class802.class512_0.class623_0 > Mods.None)
			{
				this.class84_0.method_19(44);
			}
			if (Class876.smethod_5(Mods.Cinema))
			{
				if (this.class427_0.class103_0 != null)
				{
					this.class427_0.class103_0.Dispose();
					this.class427_0.class103_0 = null;
				}
				if (this.inputOverlay_0 != null)
				{
					this.inputOverlay_0.Dispose();
					this.inputOverlay_0 = null;
				}
			}
			return base.vmethod_7(bool_48);
		}
	}
}
