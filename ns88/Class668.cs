using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns29;
using ns3;
using ns76;
using ns79;
using ns90;
using osu;
using osu_common;
using osu_common.Bancho.Objects;
using System;

namespace ns88
{
	// Token: 0x020004FE RID: 1278
	internal abstract class Class668 : IDisposable
	{
		// Token: 0x0400222D RID: 8749
		internal static bool bool_0 = true;

		// Token: 0x0400222C RID: 8748
		protected readonly Class64 class64_0;

		// Token: 0x06002920 RID: 10528
		// RVA: 0x0001FA79 File Offset: 0x0001DC79
		internal Class668(Class64 class64_1)
		{
			this.class64_0 = class64_1;
		}

		// Token: 0x06002924 RID: 10532
		// RVA: 0x0001FA88 File Offset: 0x0001DC88
		public virtual void Dispose()
		{
			if (Class62.class664_0 != null)
			{
				Class668.bool_0 = Class62.class664_0.bool_0;
			}
		}

		// Token: 0x06002925 RID: 10533
		// RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		internal virtual void Initialize()
		{
			this.vmethod_3();
		}

		// Token: 0x06002921 RID: 10529
		// RVA: 0x00018FD5 File Offset: 0x000171D5
		internal virtual Class512 vmethod_0()
		{
			return Class62.class512_0;
		}

		// Token: 0x06002922 RID: 10530
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_1()
		{
			return true;
		}

		// Token: 0x0600292D RID: 10541
		// RVA: 0x00103884 File Offset: 0x00101A84
		internal virtual void vmethod_10(int int_0)
		{
			if (this.class64_0.list_4 != null && this.class64_0.list_4[int_0] != null)
			{
				this.class64_0.list_4[int_0].class533_2.Text = "Failed";
				this.class64_0.list_4[int_0].bool_3 = false;
				return;
			}
		}

		// Token: 0x0600292E RID: 10542
		// RVA: 0x001038EC File Offset: 0x00101AEC
		internal virtual void vmethod_11(int int_0)
		{
			if (this.class64_0.list_4 != null && this.class64_0.list_4[int_0] != null)
			{
				this.class64_0.list_4[int_0].class531_2.method_8(false);
				this.class64_0.list_4[int_0].class531_2.method_15(100);
				return;
			}
		}

		// Token: 0x0600292F RID: 10543
		// RVA: 0x0001FABD File Offset: 0x0001DCBD
		internal virtual void vmethod_12()
		{
			Class115.smethod_70(OsuModes.RankingVs, false);
			Class723.smethod_2(null, null);
		}

		// Token: 0x06002930 RID: 10544
		// RVA: 0x00103954 File Offset: 0x00101B54
		internal virtual void vmethod_13()
		{
			if (Class64.bool_55)
			{
				return;
			}
			if (!this.class64_0.bool_52)
			{
				string arg;
				switch (this.class64_0.class660_0.int_2)
				{
				case 1:
					arg = "st";
					break;
				case 2:
					arg = "nd";
					break;
				case 3:
					arg = "rd";
					break;
				default:
					arg = "th";
					break;
				}
				this.class64_0.class533_2.Text = this.class64_0.class660_0.int_2 + arg;
				return;
			}
			this.class64_0.class533_2.Text = "Failed";
		}

		// Token: 0x06002931 RID: 10545
		// RVA: 0x001039FC File Offset: 0x00101BFC
		internal virtual void vmethod_14(int int_0)
		{
			if (this.class64_0.list_4 != null && this.class64_0.list_4[int_0] != null)
			{
				this.class64_0.list_4[int_0].class533_2.Text = "Quit";
				this.class64_0.list_4[int_0].bool_3 = false;
				return;
			}
		}

		// Token: 0x06002932 RID: 10546
		// RVA: 0x00103A64 File Offset: 0x00101C64
		internal virtual void vmethod_15()
		{
			if (this.class64_0.class427_0.class410_0.method_2() < 190.0)
			{
				return;
			}
			this.class64_0.bool_52 = false;
			this.class64_0.class427_0.method_3(true);
			this.class64_0.method_82();
		}

		// Token: 0x06002923 RID: 10531
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_2()
		{
			return true;
		}

		// Token: 0x06002926 RID: 10534
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_3()
		{
		}

		// Token: 0x06002927 RID: 10535
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_4()
		{
		}

		// Token: 0x06002928 RID: 10536
		// RVA: 0x001036E4 File Offset: 0x001018E4
		internal virtual Class664 vmethod_5()
		{
			PlayModes mode = Class62.Mode;
			if (mode == PlayModes.Taiko)
			{
				return new Class664(6, null, new Vector2(0f, 265f), Class668.bool_0);
			}
			return new Class664(Class64.class10_0.method_1(), null, new Vector2(0f, 150f), Class668.bool_0);
		}

		// Token: 0x06002929 RID: 10537
		// RVA: 0x0010373C File Offset: 0x0010193C
		internal virtual void vmethod_6(Struct13 struct13_0)
		{
			Class660 class = this.class64_0.list_4[(int)struct13_0.byte_0];
			if (class == null)
			{
				return;
			}
			class.method_6(struct13_0);
			Class64.bool_50 = true;
		}

		// Token: 0x0600292A RID: 10538
		// RVA: 0x00103774 File Offset: 0x00101974
		internal virtual void vmethod_7()
		{
			Class62.class664_0.int_2 = Class64.class10_0.method_1();
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (Class64.class10_0.slotStatus[i] != SlotStatus.flag_5)
				{
					this.class64_0.list_4.Add(null);
				}
				else
				{
					Class661 class = new Class661(i, Class64.class10_0.class861_0[i], Class64.class10_0.matchScoringType, Class62.Mode, Class64.class10_0.slotTeam[i], Class64.class10_0.slotMods[i]);
					class.class531_0.color_0 = new Color(0, 0, 0, 180);
					this.class64_0.list_4.Add(class);
					Class62.class664_0.Add(class);
				}
			}
			this.class64_0.class660_0 = this.class64_0.list_4[this.class64_0.int_35];
			Class62.class664_0.vmethod_0(this.class64_0.class660_0);
			Class62.class664_0.vmethod_1(false);
		}

		// Token: 0x0600292B RID: 10539
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_8()
		{
		}

		// Token: 0x0600292C RID: 10540
		// RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		internal virtual void vmethod_9()
		{
			this.class64_0.class533_2.method_16(100, Enum70.const_0);
		}
	}
}
