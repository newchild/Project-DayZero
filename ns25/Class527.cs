using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns27;
using ns29;
using ns3;
using ns5;
using ns6;
using ns64;
using ns7;
using ns77;
using ns78;
using ns79;
using ns8;
using ns82;
using ns90;
using osu;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x020006A9 RID: 1705
	internal sealed class Class527 : Class520
	{
		// Token: 0x020006AA RID: 1706
		[CompilerGenerated]
		private sealed class Class904
		{
			// Token: 0x04003173 RID: 12659
			public Class861 class861_0;

			// Token: 0x06003541 RID: 13633
			// RVA: 0x00026FF5 File Offset: 0x000251F5
			public bool method_0(Class527 class527_0)
			{
				return class527_0.class861_0 == this.class861_0;
			}
		}

		// Token: 0x04003170 RID: 12656
		private bool bool_0;

		// Token: 0x0400316E RID: 12654
		internal Class861 class861_0;

		// Token: 0x0400316F RID: 12655
		internal Class861 class861_1;

		// Token: 0x04003171 RID: 12657
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04003172 RID: 12658
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x0400316D RID: 12653
		internal static List<Class527> list_0 = new List<Class527>();

		// Token: 0x06003530 RID: 13616
		// RVA: 0x00026EC9 File Offset: 0x000250C9
		public Class527(Class861 class861_2) : base(false)
		{
			this.class861_0 = class861_2;
			this.class861_1 = (class861_2.Clone() as Class861);
		}

		// Token: 0x06003532 RID: 13618
		// RVA: 0x00026EEA File Offset: 0x000250EA
		internal override void Dispose(bool bool_1)
		{
			if (this.class861_1 != null)
			{
				this.class861_1.Dispose();
			}
			base.Dispose(bool_1);
		}

		// Token: 0x06003533 RID: 13619
		// RVA: 0x0016C524 File Offset: 0x0016A724
		private void method_0()
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			EventHandler eventHandler5 = null;
			EventHandler eventHandler6 = null;
			EventHandler eventHandler7 = null;
			Class89 class = new Class89(null, false);
			class.class911_0.bool_14 = true;
			class.vector2_0 = new Vector2(50f, 60f);
			Class111.smethod_36(new List<Class861>
			{
				this.class861_0
			}, true);
			bool flag = this.class861_0.Name == Class115.class861_0.Name;
			class.method_2(new EventHandler(this.method_1));
			if (this.class861_0.bool_4 && !flag && Class115.osuModes_1 != OsuModes.Edit && (Class115.osuModes_1 != OsuModes.Play || !Class115.bool_25))
			{
				Class89 arg_E7_0 = class;
				string arg_E7_1 = (this.class861_0 == Class858.class861_0) ? Class41.GetString(OsuString.UserProfile_StopSpectating) : Class41.GetString(OsuString.UserProfile_StartSpectating);
				Color arg_E7_2 = Color.get_YellowGreen();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_2);
				}
				arg_E7_0.method_3(arg_E7_1, arg_E7_2, eventHandler, true, false, true);
			}
			class.method_3(Class41.GetString(OsuString.UserProfile_ViewProfile), new Color(58, 110, 165), new EventHandler(this.method_3), true, false, true);
			if (flag)
			{
				if (Class115.osuModes_1 == OsuModes.Menu && Class809.smethod_4())
				{
					Class89 arg_15A_0 = class;
					string arg_15A_1 = Class41.GetString(OsuString.UserProfile_SignOut);
					Color arg_15A_2 = Color.get_Orange();
					if (Class527.eventHandler_0 == null)
					{
						Class527.eventHandler_0 = new EventHandler(Class527.smethod_1);
					}
					arg_15A_0.method_3(arg_15A_1, arg_15A_2, Class527.eventHandler_0, true, false, true);
				}
				Class89 arg_18F_0 = class;
				string arg_18F_1 = Class41.GetString(OsuString.UserProfile_ChangeAvatar);
				Color arg_18F_2 = Color.get_Orange();
				if (Class527.eventHandler_1 == null)
				{
					Class527.eventHandler_1 = new EventHandler(Class527.smethod_2);
				}
				arg_18F_0.method_3(arg_18F_1, arg_18F_2, Class527.eventHandler_1, true, false, true);
			}
			else
			{
				Class89 arg_1C0_0 = class;
				string arg_1C0_1 = Class41.GetString(OsuString.UserProfile_StartChat);
				Color arg_1C0_2 = Color.get_MediumPurple();
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(this.method_4);
				}
				arg_1C0_0.method_3(arg_1C0_1, arg_1C0_2, eventHandler2, true, false, true);
				if (this.class861_0.bool_4 && Class72.class10_0 != null)
				{
					Class89 arg_200_0 = class;
					string arg_200_1 = Class41.GetString(OsuString.UserProfile_Invitetogame);
					Color arg_200_2 = Color.get_Yellow();
					if (eventHandler3 == null)
					{
						eventHandler3 = new EventHandler(this.method_5);
					}
					arg_200_0.method_3(arg_200_1, arg_200_2, eventHandler3, true, false, true);
				}
				Class89 arg_245_0 = class;
				string arg_245_1 = this.class861_0.bool_3 ? Class41.GetString(OsuString.UserProfile_CancelFriendship) : Class41.GetString(OsuString.UserProfile_AddFriend);
				Color arg_245_2 = Color.get_Pink();
				if (eventHandler4 == null)
				{
					eventHandler4 = new EventHandler(this.method_6);
				}
				arg_245_0.method_3(arg_245_1, arg_245_2, eventHandler4, true, false, true);
				if (this.bool_0 && this.class861_0.int_1 > 0)
				{
					Class89 arg_28D_0 = class;
					string arg_28D_1 = Class41.GetString(OsuString.UserProfile_ReportUser);
					Color arg_28D_2 = Color.get_Red();
					if (eventHandler5 == null)
					{
						eventHandler5 = new EventHandler(this.method_7);
					}
					arg_28D_0.method_3(arg_28D_1, arg_28D_2, eventHandler5, true, false, true);
					if (Class111.smethod_46(this.class861_0))
					{
						Class89 arg_2C6_0 = class;
						string arg_2C6_1 = Class41.GetString(OsuString.UserProfile_UnignoreUser);
						Color arg_2C6_2 = Color.get_Gray();
						if (eventHandler6 == null)
						{
							eventHandler6 = new EventHandler(this.method_8);
						}
						arg_2C6_0.method_3(arg_2C6_1, arg_2C6_2, eventHandler6, true, false, true);
					}
					else
					{
						Class89 arg_2F4_0 = class;
						string arg_2F4_1 = Class41.GetString(OsuString.UserProfile_IgnoreUser);
						Color arg_2F4_2 = Color.get_Gray();
						if (eventHandler7 == null)
						{
							eventHandler7 = new EventHandler(this.method_9);
						}
						arg_2F4_0.method_3(arg_2F4_1, arg_2F4_2, eventHandler7, true, false, true);
					}
				}
			}
			class.method_3(Class41.GetString(OsuString.General_Close), Color.get_DarkGray(), null, true, false, true);
			if (this.class861_1.method_10(new Vector2(5f, 5f), true, 0))
			{
				class.class911_0.Add<Class531>(this.class861_1.list_0);
			}
			Class115.smethod_37(class);
		}

		// Token: 0x06003534 RID: 13620
		// RVA: 0x00026F06 File Offset: 0x00025106
		[CompilerGenerated]
		private void method_1(object sender, EventArgs e)
		{
			Class527.list_0.Remove(this);
		}

		// Token: 0x06003535 RID: 13621
		// RVA: 0x0016C880 File Offset: 0x0016AA80
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			if (Class70.enum59_0 != Enum59.const_0)
			{
				Class723.smethod_4(Class41.GetString(OsuString.UserProfile_CantSpectate));
				return;
			}
			if (Class115.osuModes_1 == OsuModes.Play && !Class802.smethod_0())
			{
				Class723.smethod_4(Class41.GetString(OsuString.UserProfile_CantSpectate));
				return;
			}
			if (!(this.class861_0.Name == Class341.class605_20))
			{
				if (this.class861_0 != Class858.class861_0)
				{
					Class858.smethod_5(this.class861_0);
					return;
				}
			}
			Class858.smethod_4(true);
		}

		// Token: 0x06003536 RID: 13622
		// RVA: 0x00026F14 File Offset: 0x00025114
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			Class115.smethod_90((this.class861_0.int_1 == 0) ? "http://osu.ppy.sh/wiki/BanchoBot" : string.Format(Class625.string_1, this.class861_0.int_1), null);
		}

		// Token: 0x06003539 RID: 13625
		// RVA: 0x00026F75 File Offset: 0x00025175
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			Class111.smethod_49(this.class861_0);
		}

		// Token: 0x0600353A RID: 13626
		// RVA: 0x0016C904 File Offset: 0x0016AB04
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			Class809.smethod_35(new Class23(Enum3.const_87, new Struct12(this.class861_0.int_1), false));
			Class723.smethod_1(string.Format(Class41.GetString(OsuString.ChatEngine_UserInvited), this.class861_0.Name), 5000);
		}

		// Token: 0x0600353B RID: 13627
		// RVA: 0x00026F82 File Offset: 0x00025182
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			Class111.smethod_43(this.class861_0, !this.class861_0.bool_3);
		}

		// Token: 0x0600353C RID: 13628
		// RVA: 0x00026F9D File Offset: 0x0002519D
		[CompilerGenerated]
		private void method_7(object sender, EventArgs e)
		{
			Class809.smethod_34(Enum3.const_1, new Class11(null, Class111.class21_0.string_0, "!report " + this.class861_0.Name));
		}

		// Token: 0x0600353D RID: 13629
		// RVA: 0x00026FCA File Offset: 0x000251CA
		[CompilerGenerated]
		private void method_8(object sender, EventArgs e)
		{
			Class111.smethod_47(this.class861_0);
		}

		// Token: 0x0600353E RID: 13630
		// RVA: 0x00026FD7 File Offset: 0x000251D7
		[CompilerGenerated]
		private void method_9(object sender, EventArgs e)
		{
			Class111.smethod_48(this.class861_0, "cp");
		}

		// Token: 0x06003531 RID: 13617
		// RVA: 0x0016C4C8 File Offset: 0x0016A6C8
		internal static void smethod_0(Class861 class861_2, bool bool_1)
		{
			Class527.Class904 class = new Class527.Class904();
			class.class861_0 = class861_2;
			Class527 class2 = Class527.list_0.Find(new Predicate<Class527>(class.method_0));
			if (class2 != null)
			{
				return;
			}
			class2 = new Class527(class.class861_0);
			class2.bool_0 = !bool_1;
			Class527.list_0.Add(class2);
			class2.method_0();
		}

		// Token: 0x06003537 RID: 13623
		// RVA: 0x00026F4A File Offset: 0x0002514A
		[CompilerGenerated]
		private static void smethod_1(object sender, EventArgs e)
		{
			Class115.class80_0.method_4();
			if (!Class115.class80_0.method_7())
			{
				Class115.smethod_80(false);
			}
		}

		// Token: 0x06003538 RID: 13624
		// RVA: 0x00026F68 File Offset: 0x00025168
		[CompilerGenerated]
		private static void smethod_2(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/ucp.php?i=profile&mode=avatar", null);
		}
	}
}
