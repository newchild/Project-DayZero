using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns18;
using ns19;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns30;
using ns40;
using ns6;
using ns69;
using ns7;
using ns76;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns5
{
	// Token: 0x020004E3 RID: 1251
	internal sealed class Class72 : Class61
	{
		// Token: 0x020004E4 RID: 1252
		[CompilerGenerated]
		private sealed class Class649
		{
			// Token: 0x0400218B RID: 8587
			public Class72 class72_0;

			// Token: 0x0400218A RID: 8586
			public Class90 class90_0;

			// Token: 0x0600287E RID: 10366
			// RVA: 0x0001F366 File Offset: 0x0001D566
			public void method_0(object sender, EventArgs e)
			{
				if (this.class90_0.string_1 != this.class72_0.string_0)
				{
					Class72.class10_0.gamePassword = this.class90_0.string_1;
					Class809.smethod_34(Enum3.const_90, Class72.class10_0);
				}
			}
		}

		// Token: 0x020004E5 RID: 1253
		[CompilerGenerated]
		private sealed class Class650
		{
			// Token: 0x0400218D RID: 8589
			public Class72 class72_0;

			// Token: 0x0400218C RID: 8588
			public int int_0;

			// Token: 0x06002880 RID: 10368
			// RVA: 0x0001F3A6 File Offset: 0x0001D5A6
			public void method_0(object sender, EventArgs e)
			{
				Class809.smethod_34(Enum3.const_70, new Struct12(this.int_0));
			}

			// Token: 0x06002881 RID: 10369
			// RVA: 0x0001F3BF File Offset: 0x0001D5BF
			public void method_1(object sender, EventArgs e)
			{
				this.class72_0.method_20(this.int_0);
			}

			// Token: 0x06002882 RID: 10370
			// RVA: 0x000FE8F4 File Offset: 0x000FCAF4
			public void method_2(object sender, EventArgs e)
			{
				Class861 class = Class809.smethod_28(Class72.class10_0.slotId[this.int_0], true);
				if (class != null)
				{
					Class527.smethod_0(class, true);
				}
			}
		}

		// Token: 0x020004E6 RID: 1254
		[CompilerGenerated]
		private sealed class Class651
		{
			// Token: 0x0400218E RID: 8590
			public Class72 class72_0;

			// Token: 0x0400218F RID: 8591
			public string string_0;

			// Token: 0x06002884 RID: 10372
			// RVA: 0x0001F3D2 File Offset: 0x0001D5D2
			public bool method_0(Class531 class531_0)
			{
				return (string)class531_0.object_0 == this.string_0;
			}
		}

		// Token: 0x020004E7 RID: 1255
		[CompilerGenerated]
		private sealed class Class652
		{
			// Token: 0x04002190 RID: 8592
			public Struct13 struct13_0;

			// Token: 0x06002886 RID: 10374
			// RVA: 0x0001F3EA File Offset: 0x0001D5EA
			public void method_0()
			{
				if (Class72.class72_0 == null)
				{
					return;
				}
				Class721.Create(Class72.class10_0.playMode, this.struct13_0, string.Empty);
			}
		}

		// Token: 0x04002187 RID: 8583
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04002188 RID: 8584
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x0400217F RID: 8575
		private bool bool_10;

		// Token: 0x04002180 RID: 8576
		internal static bool bool_11;

		// Token: 0x04002182 RID: 8578
		private static bool bool_12;

		// Token: 0x04002160 RID: 8544
		private static bool bool_2;

		// Token: 0x04002161 RID: 8545
		private static bool bool_3;

		// Token: 0x04002162 RID: 8546
		public static bool bool_4;

		// Token: 0x04002164 RID: 8548
		private static bool bool_5;

		// Token: 0x04002165 RID: 8549
		private static bool bool_6;

		// Token: 0x0400216C RID: 8556
		private bool bool_7;

		// Token: 0x0400217A RID: 8570
		private bool bool_8;

		// Token: 0x0400217B RID: 8571
		private bool bool_9;

		// Token: 0x04002163 RID: 8547
		public static Class10 class10_0;

		// Token: 0x0400217D RID: 8573
		private Class110 class110_0 = new Class110(new Rectangle(2, 85, (int)(285f * Class115.smethod_46()), 200), Vector2.get_Zero(), true, 0f, Enum98.const_2);

		// Token: 0x04002167 RID: 8551
		private readonly Class531[] class531_0 = new Class531[bMatch.smethod_0()];

		// Token: 0x04002168 RID: 8552
		private readonly Class531[] class531_1 = new Class531[bMatch.smethod_0()];

		// Token: 0x04002169 RID: 8553
		private readonly Class531[] class531_2 = new Class531[bMatch.smethod_0()];

		// Token: 0x0400216A RID: 8554
		private readonly Class533[] class533_0 = new Class533[bMatch.smethod_0()];

		// Token: 0x0400216B RID: 8555
		private readonly Class533[] class533_1 = new Class533[bMatch.smethod_0()];

		// Token: 0x04002176 RID: 8566
		private Class533 class533_2;

		// Token: 0x04002177 RID: 8567
		private Class533 class533_3;

		// Token: 0x04002186 RID: 8582
		private Class533 class533_4;

		// Token: 0x0400217E RID: 8574
		private Class695 class695_0;

		// Token: 0x04002184 RID: 8580
		private static Class72 class72_0;

		// Token: 0x04002173 RID: 8563
		private Class753 class753_0;

		// Token: 0x04002174 RID: 8564
		private Class753 class753_1;

		// Token: 0x04002175 RID: 8565
		private Class753 class753_2;

		// Token: 0x04002172 RID: 8562
		private Class754 class754_0;

		// Token: 0x0400216D RID: 8557
		private Class760 class760_0;

		// Token: 0x0400216E RID: 8558
		private Class760 class760_1;

		// Token: 0x0400216F RID: 8559
		private Class760 class760_2;

		// Token: 0x04002170 RID: 8560
		private Class760 class760_3;

		// Token: 0x04002171 RID: 8561
		private Class760 class760_4;

		// Token: 0x04002185 RID: 8581
		private Class762 class762_0;

		// Token: 0x0400217C RID: 8572
		private Class911 class911_1 = new Class911(true);

		// Token: 0x04002181 RID: 8577
		internal static Color color_0 = Color.get_TransparentWhite();

		// Token: 0x04002183 RID: 8579
		private Dictionary<string, Mods> dictionary_0 = new Dictionary<string, Mods>();

		// Token: 0x04002166 RID: 8550
		private readonly List<Class531> list_0 = new List<Class531>();

		// Token: 0x04002178 RID: 8568
		private Mods mods_0;

		// Token: 0x04002179 RID: 8569
		private string string_0;

		// Token: 0x04002189 RID: 8585
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06002849 RID: 10313
		// RVA: 0x000FBB74 File Offset: 0x000F9D74
		public Class72(Class114 class114_1) : base(class114_1)
		{
			Class72.class72_0 = this;
		}

		// Token: 0x06002865 RID: 10341
		// RVA: 0x000FD428 File Offset: 0x000FB628
		protected override void Dispose(bool bool_13)
		{
			Class72.class72_0 = null;
			Class570.smethod_1(new Class570.Delegate44(this.method_8));
			if (Class115.osuModes_1 != OsuModes.MatchSetup && Class115.osuModes_1 != OsuModes.SelectMulti && Class115.osuModes_1 != OsuModes.BeatmapImport && Class70.enum59_0 != Enum59.const_1 && Class70.enum59_0 != Enum59.const_5)
			{
				this.method_25(null, null);
			}
			if ((Class70.enum59_0 == Enum59.const_5 || Class70.enum59_0 == Enum59.const_4) && !Class70.bool_3 && Class111.bool_2)
			{
				Class111.smethod_21(true);
			}
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class754_0 != null)
			{
				this.class754_0.Dispose();
			}
			this.class110_0.Dispose();
			base.Dispose(bool_13);
		}

		// Token: 0x06002866 RID: 10342
		// RVA: 0x000FD4DC File Offset: 0x000FB6DC
		public override void Draw()
		{
			if (this.class695_0 != null)
			{
				this.class695_0.vector2_0 = this.class695_0.class531_0.vector2_1;
				this.class695_0.method_15(Vector2.get_Zero());
			}
			this.class911_1.Draw();
			this.class110_0.Draw();
			base.Draw();
		}

		// Token: 0x06002867 RID: 10343
		// RVA: 0x000FD53C File Offset: 0x000FB73C
		public override void imethod_2()
		{
			if (!Class809.bool_6 && Class115.enum113_0 == Enum113.const_2)
			{
				Class115.smethod_70(OsuModes.Menu, false);
				Class723.smethod_4(Class41.GetString(OsuString.MatchSetup_NeedsBancho));
			}
			if (Class72.class10_0 == null)
			{
				if (Class115.enum113_0 == Enum113.const_2)
				{
					Class115.smethod_70(OsuModes.Menu, false);
				}
				return;
			}
			if (Class115.enum113_0 == Enum113.const_0)
			{
				return;
			}
			if (this.bool_9)
			{
				Class77.smethod_8(false);
				this.bool_9 = false;
				return;
			}
			this.class110_0.imethod_2();
			if (!this.bool_8 && Class331.enum100_0 == Enum100.const_0 && Class115.enum113_0 == Enum113.const_2 && Class466.Current != null)
			{
				try
				{
					Class331.smethod_86(Class466.Current, true, false, true);
				}
				catch
				{
					this.bool_8 = true;
				}
			}
			if (Class72.bool_6)
			{
				this.class110_0.method_14(new Vector2(280f, (float)(bMatch.smethod_0() * 25)));
				this.class533_4.Text = Class41.GetString(OsuString.MatchSetup_CurrentPlayers) + string.Format(" ({0}/{1})", Class72.class10_0.method_1(), Class72.class10_0.method_3());
				int num = Class72.class10_0.method_8(Class115.class861_0.int_1);
				if (num < 0)
				{
					Class72.smethod_3();
					return;
				}
				this.class754_0.class533_0.Text = Class72.class10_0.gameName;
				this.bool_10 = Class72.class10_0.method_6();
				if (Class62.Mode != Class72.class10_0.playMode)
				{
					Class62.Mode = Class72.class10_0.playMode;
					Class72.bool_5 = true;
				}
				this.class753_0.method_18(Class72.class10_0.matchScoringType, true);
				this.class753_1.method_18(Class72.class10_0.matchTeamType, true);
				this.method_5(Class72.class10_0.matchTeamType, EventArgs.Empty);
				if (!Class72.bool_4 && (Class72.class10_0.specialModes & MultiSpecialModes.FreeMod) <= MultiSpecialModes.None)
				{
					this.class760_3.method_4();
				}
				else
				{
					this.class760_3.method_5();
				}
				if (Class72.bool_4)
				{
					this.class762_0.method_11();
					this.class762_0.method_6((Class72.class10_0.specialModes & MultiSpecialModes.FreeMod) > MultiSpecialModes.None);
				}
				else
				{
					this.class762_0.method_9();
				}
				if (Class72.class10_0.method_5() == Class72.class10_0.method_1() != this.bool_7)
				{
					this.bool_7 = (Class72.class10_0.method_5() == Class72.class10_0.method_1());
					if (this.bool_7)
					{
						Class331.smethod_59("match-confirm", 100, Enum112.flag_5);
					}
				}
				if (Class72.class10_0.slotStatus[num] == SlotStatus.flag_3 && Class72.bool_4 && Class72.class10_0.method_5() > 1 && Class72.class10_0.method_7())
				{
					if (this.bool_7)
					{
						this.class760_4.class533_0.Text = Class41.GetString(OsuString.MatchSetup_StartGame);
					}
					else
					{
						this.class760_4.class533_0.Text = Class41.GetString(OsuString.MatchSetup_ForceStartGame) + string.Format(" ({0}/{1})", Class72.class10_0.method_5(), Class72.class10_0.method_1());
					}
				}
				else if (Class72.class10_0.slotStatus[num] == SlotStatus.flag_2)
				{
					if (this.class760_4.class533_0.Text != Class41.GetString(OsuString.MatchSetup_Ready))
					{
						this.class760_4.class533_0.Text = Class41.GetString(OsuString.MatchSetup_Ready);
						Class331.smethod_59("match-notready", 100, Enum112.flag_5);
					}
				}
				else if (this.class760_4.class533_0.Text != Class41.GetString(OsuString.MatchSetup_NotReady))
				{
					this.class760_4.class533_0.Text = Class41.GetString(OsuString.MatchSetup_NotReady);
					Class331.smethod_59("match-ready", 100, Enum112.flag_5);
				}
				int i = 0;
				while (i < bMatch.smethod_0())
				{
					Class861 class = Class72.class10_0.class861_0[i];
					bool flag = false;
					if ((Class72.class10_0.slotStatus[i] & SlotStatus.flag_7) <= (SlotStatus)0)
					{
						this.class533_1[i].Text = string.Empty;
						this.class531_0[i].string_0 = Class41.GetString(OsuString.MatchSetup_MoveToThisSlot);
						goto IL_52B;
					}
					if (class != null)
					{
						flag = (class.int_1 == Class115.class861_0.int_1);
						this.class533_0[i].Text = class.Name;
						if (Class72.class10_0.slotStatus[i] != SlotStatus.flag_5 && class.int_3 > 0)
						{
							this.class533_1[i].Text = string.Format("Rank:#{0}", class.int_3);
						}
						this.class531_1[i].string_0 = string.Empty;
						this.class531_1[i].vmethod_7(Class885.Load(Class72.bool_4 ? "lobby-boot" : "lobby-unlock", Enum112.flag_1));
						if (flag)
						{
							this.class531_1[i].string_0 = Class41.GetString(OsuString.MatchSetup_YouAreTheHost);
						}
						else
						{
							this.class531_1[i].string_0 = Class41.GetString(OsuString.MatchSetup_KickAndLock);
						}
						this.class531_0[i].string_0 = string.Format(Class41.GetString(OsuString.MatchSetup_Player_Tooltip), (int)class.float_0, class.double_0, class.string_5);
						goto IL_52B;
					}
					IL_828:
					i++;
					continue;
					IL_52B:
					this.class531_2[i].bool_1 = false;
					SlotStatus slotStatus = Class72.class10_0.slotStatus[i];
					if (slotStatus <= SlotStatus.flag_3)
					{
						switch (slotStatus)
						{
						case SlotStatus.flag_0:
							this.class533_0[i].Text = Class41.GetString(OsuString.MatchSetup_SlotOpen);
							this.class531_1[i].vmethod_7(Class885.Load("lobby-unlock", Enum112.flag_1));
							this.class531_1[i].string_0 = Class41.GetString(OsuString.MatchSetup_LockThisSlot);
							this.class531_2[i].color_0 = Color.get_White();
							this.class531_0[i].color_0 = Color.get_White();
							break;
						case SlotStatus.flag_1:
							this.class533_0[i].Text = Class41.GetString(OsuString.MatchSetup_Locked);
							this.class531_1[i].vmethod_7(Class885.Load("lobby-lock", Enum112.flag_1));
							this.class531_1[i].string_0 = Class41.GetString(OsuString.MatchSetup_UnlockThisSlot);
							this.class531_2[i].color_0 = Color.get_Black();
							this.class531_0[i].color_0 = Color.get_Black();
							break;
						case SlotStatus.flag_0 | SlotStatus.flag_1:
							break;
						case SlotStatus.flag_2:
							this.class531_2[i].color_0 = Color.get_White();
							this.class531_0[i].color_0 = new Color(214, 255, 151);
							break;
						default:
							if (slotStatus == SlotStatus.flag_3)
							{
								this.class531_2[i].color_0 = Color.get_YellowGreen();
								this.class531_0[i].color_0 = Color.get_YellowGreen();
							}
							break;
						}
					}
					else if (slotStatus != SlotStatus.flag_4)
					{
						if (slotStatus == SlotStatus.flag_5)
						{
							this.class531_2[i].color_0 = Color.get_LightBlue();
							this.class531_0[i].color_0 = Color.get_LightBlue();
							Class533 expr_6EE = this.class533_0[i];
							expr_6EE.Text = expr_6EE.Text + " " + Class41.GetString(OsuString.MatchSetup_Playing);
						}
					}
					else
					{
						this.class531_2[i].color_0 = Color.get_OrangeRed();
						this.class531_0[i].color_0 = Color.get_OrangeRed();
						Class533 expr_73B = this.class533_0[i];
						expr_73B.Text = expr_73B.Text + " " + Class41.GetString(OsuString.MatchSetup_NoMap);
					}
					if (this.bool_10)
					{
						switch (Class72.class10_0.slotStatus[i])
						{
						case SlotStatus.flag_0:
						case SlotStatus.flag_1:
							break;
						default:
							this.class531_2[i].color_0 = ((Class72.class10_0.slotTeam[i] == SlotTeams.Blue) ? Color.get_Blue() : Color.get_Red());
							this.class531_2[i].bool_1 = flag;
							break;
						}
					}
					if (Class72.class10_0.hostId == Class72.class10_0.slotId[i])
					{
						if (class != null)
						{
							Class72.bool_3 |= (Class72.bool_4 != (class.int_1 == Class115.class861_0.int_1));
							Class72.bool_4 = (class.int_1 == Class115.class861_0.int_1);
						}
						this.class531_1[i].vmethod_7(Class885.Load("lobby-crown", Enum112.flag_1));
						goto IL_828;
					}
					goto IL_828;
				}
				Class72.bool_6 = false;
				if (Class72.bool_5)
				{
					this.method_26();
				}
				if (Class72.bool_3)
				{
					this.method_10(false);
				}
				this.method_30();
			}
			base.imethod_2();
		}

		// Token: 0x0600284A RID: 10314
		// RVA: 0x000FBC30 File Offset: 0x000F9E30
		public override void Initialize()
		{
			this.class110_0.float_4 = 0.5f;
			Class695.smethod_1();
			if (Class72.class10_0 == null)
			{
				Class115.smethod_71(OsuModes.Lobby, false);
				return;
			}
			Class72.bool_12 = false;
			lock (Class858.object_0)
			{
				Class802.smethod_1(false);
				Class802.bool_16 = false;
			}
			Class570.smethod_0(new Class570.Delegate44(this.method_8));
			if (Class70.enum59_0 == Enum59.const_5)
			{
				Class70.enum59_0 = Enum59.const_4;
			}
			Class533 class = new Class533(Class41.GetString(OsuString.MatchSetup_TeamMode), 12f, new Vector2((float)(Class115.smethod_43() - 115), 220f), 0.955f, true, Color.get_White());
			class.bool_16 = true;
			class.origins_0 = Origins.TopRight;
			this.class911_1.Add(class);
			this.class753_1 = new Class753(this.class911_1, string.Empty, new Vector2((float)(Class115.smethod_43() - 110), 220f), 90f, 0.98f);
			int num = 0;
			string[] names = Enum.GetNames(typeof(MatchTeamTypes));
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				this.class753_1.method_9(Class34.smethod_0(text), (MatchTeamTypes)(num++));
			}
			this.class753_1.method_0(new EventHandler(this.method_5));
			class = new Class533(Class41.GetString(OsuString.MatchSetup_WinCondition), 12f, new Vector2((float)(Class115.smethod_43() - 115), 240f), 0.955f, true, Color.get_White());
			class.bool_16 = true;
			class.origins_0 = Origins.TopRight;
			this.class911_1.Add(class);
			this.class753_0 = new Class753(this.class911_1, string.Empty, new Vector2((float)(Class115.smethod_43() - 110), 240f), 90f, 0.98f);
			num = 0;
			string[] names2 = Enum.GetNames(typeof(MatchScoringTypes));
			for (int j = 0; j < names2.Length; j++)
			{
				string text2 = names2[j];
				this.class753_0.method_9(Class34.smethod_0(text2), (MatchScoringTypes)(num++));
			}
			this.class753_0.method_0(new EventHandler(this.method_4));
			this.class533_2 = new Class533(Class41.GetString(OsuString.MatchSetup_ComboColour), 12f, new Vector2((float)(Class115.smethod_43() - 115), 260f), 0.955f, true, Color.get_TransparentWhite());
			this.class533_2.origins_0 = Origins.TopRight;
			this.class533_2.bool_16 = true;
			this.class911_1.Add(this.class533_2);
			this.class753_2 = new Class753(this.class911_1, string.Empty, new Vector2((float)(Class115.smethod_43() - 110), 260f), 60f, 0.98f, true, false);
			this.class753_2.class533_0.string_0 = Class41.GetString(OsuString.MatchSetup_ComboColour_Tooltip);
			this.class753_2.method_9(Class41.GetString(OsuString.General_Default), Color.get_TransparentWhite());
			this.class753_2.method_10(" ", Color.get_OrangeRed(), Class610.smethod_2(Color.get_OrangeRed(), 0.1f));
			this.class753_2.method_10(" ", Color.get_BlueViolet(), Class610.smethod_2(Color.get_BlueViolet(), 0.1f));
			this.class753_2.method_10(" ", Color.get_YellowGreen(), Class610.smethod_2(Color.get_YellowGreen(), 0.1f));
			this.class753_2.method_10(" ", Color.get_Yellow(), Class610.smethod_2(Color.get_Yellow(), 0.1f));
			this.class753_2.method_10(" ", Color.get_LightPink(), Class610.smethod_2(Color.get_PeachPuff(), 0.1f));
			this.class753_2.method_18(Class72.color_0, true);
			this.class753_2.method_0(new EventHandler(this.method_2));
			List<Class531> arg_423_0 = this.class753_2.list_0;
			if (Class72.action_0 == null)
			{
				Class72.action_0 = new Action<Class531>(Class72.smethod_7);
			}
			arg_423_0.ForEach(Class72.action_0);
			Class533 class2 = new Class533(Class41.GetString(OsuString.MatchSetup_Header), 30f, new Vector2(0f, 0f), 0.955f, true, Color.get_White());
			class2.method_58(true);
			this.class911_1.Add(class2);
			this.class533_3 = new Class533(Class72.bool_4 ? Class41.GetString(OsuString.MatchSetup_YouAreTheHost) : Class41.GetString(OsuString.MatchSetup_YouAreAPlayer), 16f, new Vector2(4f, 26f), 0.955f, true, Color.get_White());
			this.class911_1.Add(this.class533_3);
			Class531 class3 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.68f, true, Color.get_TransparentBlack(), null);
			class3.float_3 = 1f;
			class3.vector2_2.X = (float)Class115.smethod_43();
			class3.vector2_2.Y = 52f;
			class3.float_2 = 1.6f;
			this.class911_1.Add(class3);
			this.class760_4 = new Class760(Class41.GetString(OsuString.MatchSetup_Ready), new Vector2((float)(Class115.smethod_43() / 2) + 10f * Class115.smethod_46(), 285f), new Vector2(300f * Class115.smethod_46(), 30f), 0.92f, new Color(99, 139, 228), new EventHandler(this.method_17), true, false, null);
			this.class911_1.Add<Class531>(this.class760_4.list_0);
			this.class760_2 = new Class760(Class41.GetString(OsuString.MatchSetup_LeaveMatch), new Vector2((float)(Class115.smethod_43() / 2) - 310f * Class115.smethod_46(), 285f), new Vector2(300f * Class115.smethod_46(), 30f), 0.92f, new Color(235, 160, 62), new EventHandler(this.method_25), true, false, null);
			this.class911_1.Add<Class531>(this.class760_2.list_0);
			Class533 class4 = new Class533(Class41.GetString(OsuString.MatchSetup_GameName), 18f, new Vector2((float)(Class115.smethod_43() - 335), 62f), 0.9f, true, Color.get_White());
			class4.bool_16 = true;
			this.class911_1.Add(class4);
			this.class760_0 = new Class760(Class41.GetString(OsuString.MatchSetup_ChangePassword), new Vector2((float)(Class115.smethod_43() - 226), 62f), new Vector2(80f, 18f), 0.9f, Color.get_YellowGreen(), new EventHandler(this.method_15), true, false, null);
			this.class911_1.Add<Class531>(this.class760_0.list_0);
			Class533 class5 = new Class533(Class41.GetString(OsuString.MatchSetup_Beatmap), 18f, new Vector2((float)(Class115.smethod_43() - 335), 112f), 0.9f, true, Color.get_White());
			class5.bool_16 = true;
			this.class911_1.Add(class5);
			this.class760_1 = new Class760(Class41.GetString(OsuString.MatchSetup_ChangeBeatmap), new Vector2((float)(Class115.smethod_43() - 256), 112f), new Vector2(80f, 18f), 0.9f, Color.get_YellowGreen(), new EventHandler(this.method_11), true, false, null);
			this.class911_1.Add<Class531>(this.class760_1.list_0);
			Class533 class6 = new Class533(Class41.GetString(OsuString.MatchSetup_Mods), 18f, new Vector2((float)(Class115.smethod_43() - 335), 196f), 0.9f, true, Color.get_White());
			class6.bool_16 = true;
			this.class911_1.Add(class6);
			this.class760_3 = new Class760(Class41.GetString(OsuString.MatchSetup_ChangeBeatmap), new Vector2((float)(Class115.smethod_43() - 288), 196f), new Vector2(80f, 18f), 0.9f, Color.get_YellowGreen(), new EventHandler(this.method_13), true, false, null);
			this.class911_1.Add<Class531>(this.class760_3.list_0);
			this.class762_0 = new Class762(Class41.GetString(OsuString.MatchSetup_FreeMods), new Vector2((float)(Class115.smethod_43() - 200), 196f), 1f, false);
			this.class762_0.method_8(new Delegate38(this.method_34));
			if (Class213.int_0 >= 17)
			{
				this.class911_1.Add<Class531>(this.class762_0.list_0);
			}
			this.class533_4 = new Class533(Class41.GetString(OsuString.MatchSetup_CurrentPlayers), 18f, new Vector2(21f * Class115.smethod_46(), 60f), 0.9f, true, Color.get_White());
			this.class533_4.bool_16 = true;
			this.class911_1.Add(this.class533_4);
			for (int k = 0; k < bMatch.smethod_0(); k++)
			{
				this.class533_0[k] = new Class533(string.Empty, 18f, new Vector2(42f * Class115.smethod_46(), (float)(k * 25)), 1f, true, Color.get_White());
				this.class110_0.class911_0.Add(this.class533_0[k]);
				this.class533_1[k] = new Class533(string.Empty, 12f, new Vector2(194f * Class115.smethod_46(), (float)(3 + k * 25)), new Vector2(77f, 0f), 1f, true, Color.get_White(), false);
				this.class533_1[k].enum72_0 = Enum72.const_3;
				this.class110_0.class911_0.Add(this.class533_1[k]);
				Class531 class7 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(33f * Class115.smethod_46(), (float)(k * 25)), 0.974f, true, Color.get_White(), null);
				class7.bool_1 = true;
				class7.method_2(new EventHandler(this.method_18));
				class7.bool_2 = true;
				class7.vector2_2 = new Vector2(5f, 20f);
				class7.int_0 = k;
				class7.float_2 = 1.6f;
				class7.string_0 = Class41.GetString(OsuString.MatchSetup_ChangeTeam);
				this.class110_0.class911_0.Add(class7);
				this.class531_2[k] = class7;
				Class531 class8 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(41f * Class115.smethod_46(), (float)(k * 25)), 0.974f, true, new Color(255, 255, 255, 50), null);
				class8.bool_1 = true;
				class8.vector2_2 = new Vector2(230f * Class115.smethod_46(), 20f);
				class8.float_2 = 1.6f;
				class8.string_0 = Class41.GetString(OsuString.MatchSetup_MoveToThisSlot);
				class8.class746_1 = new Class746(TransformationType.Fade, 0.2f, 0.4f, 0, 60, Enum70.const_0);
				class8.method_2(new EventHandler(this.method_19));
				class8.bool_2 = true;
				class8.int_0 = k;
				this.class531_0[k] = class8;
				this.class110_0.class911_0.Add(class8);
				Class531 class9 = new Class531(Class885.Load("lobby-unlock", Enum112.flag_1), Origins.Centre, new Vector2(21f * Class115.smethod_46(), (float)(10 + k * 25)), 1f, true, Color.get_LightGray());
				this.class531_1[k] = class9;
				class9.method_2(new EventHandler(this.method_16));
				class9.class746_1 = new Class746(TransformationType.Rotation, 0f, 0.1f, 0, 100, Enum70.const_0);
				class9.class746_0 = new Class746(TransformationType.Scale, 2f, 1f, 0, 200, Enum70.const_0);
				class9.string_0 = Class41.GetString(OsuString.MatchSetup_LockThisSlot);
				class9.bool_2 = true;
				class9.int_0 = k;
				this.class110_0.class911_0.Add(class9);
			}
			this.class754_0 = new Class754(Class72.class10_0.gameName, 16, new Vector2((float)(Class115.smethod_43() - 330), 85f), 320f, 1f, false);
			this.class754_0.bool_0 = true;
			this.class754_0.method_2(new Class754.Delegate37(this.method_9));
			this.class754_0.bool_3 = true;
			this.class754_0.int_0 = 50;
			this.class911_1.Add<Class531>(this.class754_0.list_0);
			Class746 class10 = new Class746(TransformationType.Scale, 1f, 1.2f, 0, 100, Enum70.const_0);
			class10.enum70_0 = Enum70.const_1;
			Class746 class11 = new Class746(TransformationType.Scale, 1.1f, 1.2f, 0, 100, Enum70.const_0);
			class11.enum70_0 = Enum70.const_1;
			Class531 class12 = new Class531(Class885.Load("editor-button-pause", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(80f, 12f), 0.96f, true, Color.get_White(), "b");
			class12.bool_1 = true;
			class12.string_0 = Class41.GetString(OsuString.MatchSetup_Pause);
			class12.class746_0 = class11;
			class12.class746_1 = class10;
			class12.method_2(new EventHandler(this.method_6));
			this.class911_1.Add(class12);
			Class72.bool_6 = true;
			Class72.bool_5 = true;
			Class72.bool_3 = true;
			this.method_10(true);
			this.method_1();
			this.method_3();
			if (!Class111.bool_2)
			{
				Class111.smethod_21(false);
			}
			base.Initialize();
		}

		// Token: 0x0600284B RID: 10315
		// RVA: 0x000FCA40 File Offset: 0x000FAC40
		private void method_1()
		{
			Mods mods = Mods.None;
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				if (Class72.class10_0.class861_0[i] != null && Class72.class10_0.class861_0[i].int_1 == Class115.class861_0.int_1)
				{
					mods = (Class72.class10_0.slotMods[i] & Mods.FreeModAllowed);
					IL_54:
					Class876.class623_0 = (Class72.class10_0.activeMods | mods);
					this.method_27();
					return;
				}
			}
			goto IL_54;
		}

		// Token: 0x06002855 RID: 10325
		// RVA: 0x000FCD24 File Offset: 0x000FAF24
		private void method_10(bool bool_13)
		{
			if (Class72.bool_4)
			{
				if (!this.class531_1[0].bool_1 || bool_13)
				{
					this.class754_0.bool_3 = false;
					if (this.class695_0 != null)
					{
						this.class695_0.class531_0.bool_1 = true;
					}
					this.class760_1.method_5();
					this.class760_0.method_5();
					Class531[] array = this.class531_1;
					for (int i = 0; i < array.Length; i++)
					{
						Class531 class = array[i];
						class.bool_1 = true;
						class.method_39(Color.get_White(), 100, false, Enum70.const_0);
					}
					this.class533_3.Text = Class41.GetString(OsuString.MatchSetup_YouAreTheHost);
					Class72.bool_6 = true;
				}
				this.class753_0.method_4(Class72.class10_0.matchTeamType != MatchTeamTypes.TagCoop);
				this.class753_1.method_4(true);
				this.class762_0.method_1(true);
				this.method_24(false);
			}
			else
			{
				this.class762_0.method_1(false);
				if (this.class531_1[0].bool_1 || bool_13)
				{
					this.class754_0.bool_3 = true;
					if (this.class695_0 != null)
					{
						this.class695_0.class531_0.bool_1 = false;
					}
					this.class760_1.method_4();
					this.class760_0.method_4();
					Class531[] array2 = this.class531_1;
					for (int j = 0; j < array2.Length; j++)
					{
						Class531 class2 = array2[j];
						class2.bool_1 = false;
						class2.method_39(Color.get_LightGray(), 100, false, Enum70.const_0);
					}
					this.class533_3.Text = Class41.GetString(OsuString.MatchSetup_YouAreAPlayer);
					Class72.bool_6 = true;
				}
				this.class753_0.method_4(false);
				this.class753_1.method_4(false);
			}
			Class72.bool_3 = false;
		}

		// Token: 0x06002856 RID: 10326
		// RVA: 0x000FCEE4 File Offset: 0x000FB0E4
		private void method_11(object sender, EventArgs e)
		{
			if (Class802.buttonState_5 == 1 && Class466.Current != null)
			{
				Class92 class89_ = new Class92(null);
				Class115.smethod_37(class89_);
				return;
			}
			if (!Class72.bool_4)
			{
				return;
			}
			if (this.class695_0 != null)
			{
				this.class695_0.class531_0.method_23(new Vector2(400f, 0f), 600, Enum70.const_1);
			}
			this.method_24(true);
			Class62.Mode = Class72.class10_0.playMode;
			Class68.bool_11 = (Class72.class10_0.matchTeamType != MatchTeamTypes.TagCoop && Class72.class10_0.matchTeamType != MatchTeamTypes.TagTeamVs);
			Class115.smethod_70(OsuModes.SelectMulti, false);
		}

		// Token: 0x06002857 RID: 10327
		// RVA: 0x000FCF88 File Offset: 0x000FB188
		private bool method_12()
		{
			int num = Class72.class10_0.method_8(Class115.class861_0.int_1);
			if (num < 0)
			{
				return false;
			}
			if (Class72.class10_0.slotStatus[num] == SlotStatus.flag_3)
			{
				Class723.smethod_5(Class41.GetString(OsuString.MatchSetup_CantChangeMod), Color.get_Red(), 1500, null);
				return false;
			}
			return true;
		}

		// Token: 0x06002858 RID: 10328
		// RVA: 0x000FCFDC File Offset: 0x000FB1DC
		private void method_13(object sender, EventArgs e)
		{
			if (!this.method_12())
			{
				return;
			}
			this.mods_0 = Class876.class623_0;
			Enum62 enum = Enum62.flag_0;
			if (Class72.bool_4)
			{
				enum |= Enum62.flag_1;
			}
			if ((Class72.class10_0.specialModes & MultiSpecialModes.FreeMod) > MultiSpecialModes.None)
			{
				enum |= Enum62.flag_3;
			}
			Class100 class = new Class100(enum);
			class.method_2(new EventHandler(this.method_14));
			Class115.smethod_37(class);
		}

		// Token: 0x06002859 RID: 10329
		// RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		private void method_14(object sender, EventArgs e)
		{
			if (Class876.class623_0 != this.mods_0)
			{
				Class809.smethod_34(Enum3.const_51, new Struct12((int)Class876.class623_0));
			}
		}

		// Token: 0x0600285A RID: 10330
		// RVA: 0x000FD044 File Offset: 0x000FB244
		private void method_15(object sender, EventArgs e)
		{
			Class72.Class649 class = new Class72.Class649();
			class.class72_0 = this;
			this.string_0 = Class72.class10_0.gamePassword;
			class.class90_0 = new Class90(this.string_0);
			class.class90_0.method_2(new EventHandler(class.method_0));
			Class115.smethod_37(class.class90_0);
		}

		// Token: 0x0600285B RID: 10331
		// RVA: 0x000FD0A4 File Offset: 0x000FB2A4
		private void method_16(object sender, EventArgs e)
		{
			int int_ = ((Class531)sender).int_0;
			this.method_20(int_);
		}

		// Token: 0x0600285C RID: 10332
		// RVA: 0x000FD0C4 File Offset: 0x000FB2C4
		private void method_17(object sender, EventArgs e)
		{
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return;
			}
			if (Class466.Current.method_5() == PlayModes.Taiko || Class466.Current.method_5() == PlayModes.OsuMania)
			{
				if (Class72.class10_0.matchTeamType != MatchTeamTypes.TagCoop)
				{
					if (Class72.class10_0.matchTeamType != MatchTeamTypes.TagTeamVs)
					{
						goto IL_42;
					}
				}
				Class723.smethod_1(Class41.GetString(OsuString.MatchSetup_NoTaikoCoop), 3000);
				return;
			}
			IL_42:
			int num = Class72.class10_0.method_8(Class115.class861_0.int_1);
			if (num < 0)
			{
				return;
			}
			if (Class72.class10_0.slotStatus[num] == SlotStatus.flag_2)
			{
				Class809.smethod_34(Enum3.const_39, null);
				return;
			}
			if (Class72.bool_4 && Class72.class10_0.method_5() > 1 && Class72.class10_0.method_7())
			{
				Class809.smethod_34(Enum3.const_44, null);
				this.class760_2.method_4();
				return;
			}
			if (Class72.class10_0.slotStatus[num] == SlotStatus.flag_3)
			{
				Class809.smethod_34(Enum3.const_55, null);
			}
		}

		// Token: 0x0600285D RID: 10333
		// RVA: 0x0001F1D7 File Offset: 0x0001D3D7
		private void method_18(object sender, EventArgs e)
		{
			this.method_22();
		}

		// Token: 0x0600285E RID: 10334
		// RVA: 0x000FD1A8 File Offset: 0x000FB3A8
		private void method_19(object sender, EventArgs e)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			Class72.Class650 class = new Class72.Class650();
			class.class72_0 = this;
			class.int_0 = ((Class531)sender).int_0;
			if (Class72.class10_0.slotStatus[class.int_0] == SlotStatus.flag_1)
			{
				return;
			}
			if (Class72.class10_0.slotStatus[class.int_0] == SlotStatus.flag_0)
			{
				this.method_21(class.int_0);
				return;
			}
			if (Class72.bool_4 && Class72.class10_0.slotId[class.int_0] != Class115.class861_0.int_1)
			{
				Class89 class2 = new Class89(string.Format(Class41.GetString(OsuString.MatchSetup_UserActionsHeader), this.class533_0[class.int_0].Text), true);
				Class89 arg_DA_0 = class2;
				string arg_DA_1 = Class41.GetString(OsuString.MatchSetup_TransferHostPrivileges);
				Color arg_DA_2 = Color.get_YellowGreen();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				arg_DA_0.method_3(arg_DA_1, arg_DA_2, eventHandler, true, false, true);
				Class89 arg_104_0 = class2;
				string arg_104_1 = Class41.GetString(OsuString.MatchSetup_Kick);
				Color arg_104_2 = Color.get_Red();
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(class.method_1);
				}
				arg_104_0.method_3(arg_104_1, arg_104_2, eventHandler2, true, false, true);
				Class89 arg_13A_0 = class2;
				string arg_13A_1 = Class41.GetString(OsuString.MatchSetup_UserOptions);
				Color arg_13A_2 = new Color(58, 110, 165);
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(class.method_2);
				}
				arg_13A_0.method_3(arg_13A_1, arg_13A_2, eventHandler3, true, false, true);
				class2.method_3(Class41.GetString(OsuString.General_Cancel), Color.get_Gray(), null, true, false, true);
				Class115.smethod_37(class2);
				return;
			}
			Class861 class3 = Class809.smethod_28(Class72.class10_0.slotId[class.int_0], true);
			if (class3 != null)
			{
				Class527.smethod_0(class3, true);
			}
		}

		// Token: 0x0600284C RID: 10316
		// RVA: 0x0001F119 File Offset: 0x0001D319
		private void method_2(object sender, EventArgs e)
		{
			Class72.color_0 = (Color)sender;
		}

		// Token: 0x0600285F RID: 10335
		// RVA: 0x0001F1DF File Offset: 0x0001D3DF
		private void method_20(int int_2)
		{
			Class809.smethod_34(Enum3.const_40, new Struct12(int_2));
		}

		// Token: 0x06002860 RID: 10336
		// RVA: 0x0001F1F3 File Offset: 0x0001D3F3
		private void method_21(int int_2)
		{
			if (int_2 == Class72.class10_0.method_8(Class115.class861_0.int_1))
			{
				return;
			}
			Class809.smethod_34(Enum3.const_38, new Struct12(int_2));
		}

		// Token: 0x06002861 RID: 10337
		// RVA: 0x0001F21F File Offset: 0x0001D41F
		private void method_22()
		{
			Class809.smethod_34(Enum3.const_77, null);
		}

		// Token: 0x06002862 RID: 10338
		// RVA: 0x0001F229 File Offset: 0x0001D429
		private void method_23()
		{
			if (Class72.bool_4)
			{
				Class62.int_12 = Class115.int_1;
				Class72.class10_0.Seed = Class62.int_12;
			}
		}

		// Token: 0x06002863 RID: 10339
		// RVA: 0x000FD334 File Offset: 0x000FB534
		private void method_24(bool bool_13)
		{
			if (bool_13)
			{
				Class72.class10_0.beatmapName = string.Empty;
				Class72.class10_0.beatmapChecksum = string.Empty;
				Class72.class10_0.beatmapId = -1;
			}
			else if (Class466.Current != null && Class72.class10_0.beatmapChecksum != Class466.Current.string_3)
			{
				Class72.bool_5 = true;
				Class72.class10_0.beatmapName = Class466.Current.string_6;
				Class72.class10_0.beatmapChecksum = Class466.Current.string_3;
				Class72.class10_0.beatmapId = Class466.Current.int_2;
				Class72.class10_0.playMode = Class62.Mode;
				this.method_23();
			}
			if ((Class72.class10_0.activeMods & Mods.Random) > Mods.None && Class72.class10_0.beatmapChecksum == Class466.Current.string_3)
			{
				this.method_23();
			}
			Class809.smethod_34(Enum3.const_41, Class72.class10_0);
		}

		// Token: 0x06002864 RID: 10340
		// RVA: 0x0001F24B File Offset: 0x0001D44B
		private void method_25(object sender, EventArgs e)
		{
			Class72.smethod_3();
		}

		// Token: 0x06002868 RID: 10344
		// RVA: 0x000FDDC0 File Offset: 0x000FBFC0
		private void method_26()
		{
			if (this.class695_0 != null)
			{
				this.class695_0.method_14(this.class911_1);
				this.class695_0.Dispose();
				this.class695_0 = null;
			}
			if (string.IsNullOrEmpty(Class72.class10_0.beatmapChecksum))
			{
				this.class760_4.method_4();
				this.class695_0 = new Class695(new Class296
				{
					bool_4 = true,
					Title = Class41.GetString(OsuString.MatchSetup_HostIsChangingTheMap),
					string_5 = Class41.GetString(OsuString.MatchSetup_PleaseWait)
				}, null, new PlayModes?(Class72.class10_0.playMode));
				this.class695_0.bool_4 = true;
				this.class695_0.Initialize(true);
				this.class695_0.method_20(Enum63.const_1);
				this.class695_0.class531_0.method_39(Color.get_DarkGray(), 0, false, Enum70.const_0);
				this.class695_0.class531_0.class746_1 = null;
				this.class695_0.class531_0.string_0 = null;
			}
			else
			{
				Class296 class = Class466.smethod_25(Class72.class10_0.beatmapChecksum);
				if (class != null)
				{
					class.method_11();
					if (!class.bool_4)
					{
						Class466.Remove(class);
						class = null;
					}
				}
				Class72.bool_2 = (class != null && class.string_3 == Class72.class10_0.beatmapChecksum);
				if (!Class72.bool_2)
				{
					this.class760_4.method_4();
					Class466.smethod_21(Class466.smethod_32(Class72.class10_0.beatmapId));
					Class331.smethod_90();
					this.class695_0 = new Class695(new Class296
					{
						Title = Class72.class10_0.beatmapName,
						bool_4 = true,
						string_5 = ((Class466.Current != null) ? Class41.GetString(OsuString.MatchSetup_UpdateToLatest) : ((Class72.class10_0.beatmapId > 0) ? Class41.GetString(OsuString.MatchSetup_DownloadThisMap) : Class41.GetString(OsuString.MatchSetup_YouDontHaveThisMap)))
					}, null, new PlayModes?(Class72.class10_0.playMode));
					this.class695_0.bool_4 = true;
					this.class695_0.Initialize(true);
					this.class695_0.method_20(Enum63.const_1);
					this.class695_0.class531_0.method_39(Color.get_OrangeRed(), 0, false, Enum70.const_0);
					if (Class72.class10_0.beatmapId > 0)
					{
						this.class695_0.class531_0.bool_1 = true;
						this.class695_0.class531_0.method_2(new EventHandler(this.method_32));
						this.class695_0.class531_0.class746_1 = new Class746(this.class695_0.color_12, Color.get_YellowGreen(), 0, 100);
					}
					else
					{
						this.class695_0.class531_0.bool_1 = false;
					}
					Class809.smethod_34(Enum3.const_54, null);
					this.class695_0.class533_1.bool_16 = true;
				}
				else
				{
					if (Class72.class10_0.slotStatus[Class72.class10_0.method_8(Class115.class861_0.int_1)] == SlotStatus.flag_4)
					{
						Class809.smethod_34(Enum3.const_59, null);
					}
					this.class760_4.method_5();
					Class466.smethod_21(class);
					this.class695_0 = new Class695(class, null, new PlayModes?(Class72.class10_0.playMode));
					this.class695_0.bool_4 = true;
					this.class695_0.Initialize(true);
					this.class695_0.method_20(Enum63.const_2);
					this.class695_0.class531_0.method_2(new EventHandler(this.method_11));
					this.class695_0.class531_0.class746_1 = new Class746(this.class695_0.color_12, Color.get_Orange(), 0, 100);
					this.class695_0.class531_0.string_0 = string.Empty;
					this.bool_8 = false;
					this.method_27();
					try
					{
						Class331.smethod_86(Class466.Current, true, false, true);
					}
					catch
					{
						Class723.smethod_4(Class41.GetString(OsuString.SongSelection_AudioError));
						this.bool_8 = true;
					}
				}
			}
			if (this.class695_0 != null)
			{
				this.class695_0.method_7(0.6f);
				this.class695_0.class531_0.vector2_1 = new Vector2((float)(Class115.smethod_43() - 40), 165f);
				this.class695_0.class531_0.method_19(new Vector2((float)(Class115.smethod_43() - 340), 165f), 500, Enum70.const_1);
				this.class695_0.method_13(this.class911_1);
			}
			Class72.bool_5 = false;
		}

		// Token: 0x06002869 RID: 10345
		// RVA: 0x0001F252 File Offset: 0x0001D452
		private void method_27()
		{
			if (Class466.Current != null && this.class695_0 != null)
			{
				this.method_28();
				if (this.class695_0.class531_0.string_0 != null)
				{
					this.method_29();
				}
				return;
			}
		}

		// Token: 0x0600286A RID: 10346
		// RVA: 0x000FE21C File Offset: 0x000FC41C
		private void method_28()
		{
			Class296 current = Class466.Current;
			if (current.method_26() < 0.0)
			{
				current.method_18();
			}
			this.class695_0.method_6(false);
		}

		// Token: 0x0600286B RID: 10347
		// RVA: 0x000FE254 File Offset: 0x000FC454
		private void method_29()
		{
			Class296 current = Class466.Current;
			Vector3 vector = current.method_33();
			double num = Class297.smethod_9((double)current.int_16);
			if (Class876.smethod_5(Mods.DoubleTime))
			{
				vector *= 1.5f;
			}
			else if (Class876.smethod_5(Mods.HalfTime))
			{
				vector *= 0.75f;
			}
			int num2 = (int)num / 60000;
			int num3 = (int)(num % 60000.0) / 1000;
			this.class695_0.class531_0.string_0 = string.Format(Class41.GetString(OsuString.MatchSetup_BeatmapInfo) + "\n" + current.method_30(), new object[]
			{
				Class296.smethod_0(vector),
				num2,
				num3,
				(current.dateTime_0 != DateTime.MinValue) ? current.dateTime_0.ToShortDateString() : Class41.GetString(OsuString.MatchSetup_NeverPlayed)
			});
		}

		// Token: 0x0600284D RID: 10317
		// RVA: 0x000FCAC0 File Offset: 0x000FACC0
		private void method_3()
		{
			Class115.class861_0.method_10(new Vector2((float)(Class115.smethod_43() / 2 - 100), 1f), false, 0);
			this.class911_1.Add<Class531>(Class115.class861_0.list_0);
			if (Class72.bool_11)
			{
				Class115.class861_0.method_15();
				Class72.bool_11 = false;
			}
		}

		// Token: 0x0600286C RID: 10348
		// RVA: 0x000FE34C File Offset: 0x000FC54C
		private void method_30()
		{
			if ((Class72.class10_0.specialModes & MultiSpecialModes.FreeMod) > MultiSpecialModes.None)
			{
				Class876.class623_0 = ((Class876.class623_0 & Mods.FreeModAllowed) | Class72.class10_0.activeMods);
			}
			else
			{
				Class876.class623_0 = Class72.class10_0.activeMods;
			}
			this.method_31(Class72.class10_0.activeMods, new Vector2((float)(Class115.smethod_43() - 310), 235f), 1f, "main");
			for (int i = 0; i < bMatch.smethod_0(); i++)
			{
				this.method_31(Class72.class10_0.slotMods[i] & Mods.FreeModAllowed, new Vector2(170f * Class115.smethod_46(), (float)(10 + i * 25)), 0.5f, "slot" + i);
			}
			this.method_27();
		}

		// Token: 0x0600286D RID: 10349
		// RVA: 0x000FE430 File Offset: 0x000FC630
		private void method_31(Mods mods_1, Vector2 vector2_0, float float_0, string string_1)
		{
			Class72.Class651 class = new Class72.Class651();
			class.string_0 = string_1;
			class.class72_0 = this;
			Mods mods;
			if (this.dictionary_0.TryGetValue(class.string_0, out mods) && mods == mods_1)
			{
				return;
			}
			this.dictionary_0[class.string_0] = mods_1;
			this.list_0.FindAll(new Predicate<Class531>(class.method_0)).ForEach(new Action<Class531>(this.method_35));
			List<Class531> list = Class876.smethod_12(mods_1, vector2_0, float_0, class.string_0);
			this.list_0.AddRange(list);
			if (class.string_0 == "main")
			{
				this.class911_1.Add<Class531>(list);
				return;
			}
			this.class110_0.class911_0.Add<Class531>(list);
		}

		// Token: 0x0600286E RID: 10350
		// RVA: 0x000FE4F4 File Offset: 0x000FC6F4
		private void method_32(object sender, EventArgs e)
		{
			EventHandler eventHandler = null;
			if (Class466.Current == null)
			{
				LinkId arg_BD_0 = LinkId.Beatmap;
				int arg_BD_1 = Class72.class10_0.beatmapId;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_36);
				}
				Class112.smethod_4(arg_BD_0, arg_BD_1, eventHandler);
				return;
			}
			if (Class466.Current.bool_10)
			{
				Class466.Current.method_69();
				return;
			}
			Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
			FileNetRequest fileNetRequest = new FileNetRequest(Class466.Current.method_46() + "_", "http://osu.ppy.sh/web/maps/" + Path.GetFileName(Class466.Current.string_9));
			fileNetRequest.method_2(new FileNetRequest.Delegate10(this.method_33));
			Class169.smethod_0(fileNetRequest);
			((Class531)sender).bool_1 = false;
			Class723.smethod_5(Class41.GetString(OsuString.MatchSetup_DownloadingUpdate), Color.get_YellowGreen(), 2000, null);
		}

		// Token: 0x0600286F RID: 10351
		// RVA: 0x0001F282 File Offset: 0x0001D482
		private void method_33(string string_1, Exception exception_0)
		{
			Class47 arg_23_0 = Class115.class47_0;
			if (Class72.voidDelegate_0 == null)
			{
				Class72.voidDelegate_0 = new VoidDelegate(Class72.smethod_9);
			}
			arg_23_0.Add(Class72.voidDelegate_0, false);
		}

		// Token: 0x06002877 RID: 10359
		// RVA: 0x000FE894 File Offset: 0x000FCA94
		[CompilerGenerated]
		private void method_34(object object_0, bool bool_13)
		{
			if (!this.method_12())
			{
				return;
			}
			if (bool_13)
			{
				Class72.class10_0.specialModes |= MultiSpecialModes.FreeMod;
			}
			else
			{
				Class72.class10_0.slotMods = new Mods[bMatch.smethod_0()];
				Class72.class10_0.specialModes &= ~MultiSpecialModes.FreeMod;
			}
			Class809.smethod_34(Enum3.const_41, Class72.class10_0);
		}

		// Token: 0x06002879 RID: 10361
		// RVA: 0x0001F2F1 File Offset: 0x0001D4F1
		[CompilerGenerated]
		private void method_35(Class531 class531_3)
		{
			class531_3.method_16(400, Enum70.const_0);
			class531_3.method_23(new Vector2(0f, 20f), 400, Enum70.const_2);
			class531_3.bool_0 = false;
			this.list_0.Remove(class531_3);
		}

		// Token: 0x0600287A RID: 10362
		// RVA: 0x0001F32E File Offset: 0x0001D52E
		[CompilerGenerated]
		private void method_36(object sender, EventArgs e)
		{
			this.bool_9 = true;
		}

		// Token: 0x0600284E RID: 10318
		// RVA: 0x0001F126 File Offset: 0x0001D326
		private void method_4(object sender, EventArgs e)
		{
			Class72.class10_0.matchScoringType = (MatchScoringTypes)sender;
			Class809.smethod_34(Enum3.const_41, Class72.class10_0);
		}

		// Token: 0x0600284F RID: 10319
		// RVA: 0x000FCB1C File Offset: 0x000FAD1C
		private void method_5(object sender, EventArgs e)
		{
			Class72.class10_0.matchTeamType = (MatchTeamTypes)sender;
			if (Class72.class10_0.matchTeamType != MatchTeamTypes.TagCoop)
			{
				if (Class72.class10_0.matchTeamType != MatchTeamTypes.TagTeamVs)
				{
					this.class533_2.method_12();
					List<Class531> arg_5F_0 = this.class753_2.list_0;
					if (Class72.action_1 == null)
					{
						Class72.action_1 = new Action<Class531>(Class72.smethod_8);
					}
					arg_5F_0.ForEach(Class72.action_1);
					goto IL_AA;
				}
			}
			Class72.class10_0.playMode = PlayModes.Osu;
			this.class533_2.method_14(50, Enum70.const_0);
			this.class753_2.class533_0.method_14(50, Enum70.const_0);
			if (Class72.class10_0.matchTeamType == MatchTeamTypes.TagCoop)
			{
				Class72.class10_0.matchScoringType = MatchScoringTypes.Score;
			}
			IL_AA:
			if (e == null)
			{
				Class809.smethod_34(Enum3.const_41, Class72.class10_0);
			}
		}

		// Token: 0x06002850 RID: 10320
		// RVA: 0x0001F144 File Offset: 0x0001D344
		private void method_6(object sender, EventArgs e)
		{
			Class723.smethod_1(Class331.smethod_79() ? "Unpause" : Class41.GetString(OsuString.MatchSetup_Pause), 1000);
			this.bool_8 = !Class331.smethod_79();
			Class331.smethod_88();
		}

		// Token: 0x06002852 RID: 10322
		// RVA: 0x000FCBE4 File Offset: 0x000FADE4
		private SlotStatus method_7()
		{
			int num = Class72.class10_0.method_8(Class115.class861_0.int_1);
			if (num < 0)
			{
				return SlotStatus.flag_0;
			}
			return Class72.class10_0.slotStatus[num];
		}

		// Token: 0x06002853 RID: 10323
		// RVA: 0x000FCC18 File Offset: 0x000FAE18
		private bool method_8(object object_0, Keys keys_0)
		{
			if (Class466.Current != null && Class466.Current.method_29() == PlayModes.OsuMania)
			{
				if (Class570.bool_0 && (keys_0 == 187 || keys_0 == Class795.smethod_3(Bindings.IncreaseSpeed)))
				{
					Class435.smethod_1(1);
					return true;
				}
				if (Class570.bool_0 && (keys_0 == 189 || keys_0 == Class795.smethod_3(Bindings.DecreaseSpeed)))
				{
					Class435.smethod_1(-1);
					return true;
				}
			}
			if (keys_0 == 116)
			{
				if (Class72.bool_4)
				{
					this.method_11(null, null);
					return true;
				}
				if (Class115.enum113_0 == Enum113.const_2 && this.method_7() == SlotStatus.flag_4)
				{
					Class77.smethod_8(true);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002854 RID: 10324
		// RVA: 0x000FCCB0 File Offset: 0x000FAEB0
		private void method_9(Class754 class754_1, bool bool_13)
		{
			if (Class72.class10_0 == null)
			{
				return;
			}
			if (this.class754_0.class533_0.Text.Length > 0)
			{
				Class72.class10_0.gameName = this.class754_0.class533_0.Text;
			}
			this.class754_0.bool_0 = Class72.class10_0.gameName.Contains("(room #");
			Class809.smethod_34(Enum3.const_41, Class72.class10_0);
		}

		// Token: 0x06002851 RID: 10321
		// RVA: 0x0001F17C File Offset: 0x0001D37C
		internal static void smethod_0()
		{
			if (Class72.bool_12)
			{
				Class115.smethod_70(OsuModes.Lobby, false);
				return;
			}
			Class723.smethod_1(Class41.GetString(OsuString.MatchSetup_HitEscapeToLeave), 1500);
			Class72.bool_12 = true;
		}

		// Token: 0x06002870 RID: 10352
		// RVA: 0x000FE5C4 File Offset: 0x000FC7C4
		public static void smethod_1(Class10 class10_1)
		{
			if (class10_1.inProgress && Class64.class10_0 != null)
			{
				for (int i = 0; i < bMatch.smethod_0(); i++)
				{
					if (Class72.class10_0.slotId[i] >= 0 && class10_1.slotId[i] < 0)
					{
						Class64.smethod_30(i);
					}
				}
			}
			else
			{
				for (int j = 0; j < bMatch.smethod_0(); j++)
				{
					if (class10_1.slotId[j] != Class72.class10_0.slotId[j])
					{
						if (class10_1.slotId[j] == -1)
						{
							int num = Class72.class10_0.slotId[j];
							bool flag = true;
							int k = 0;
							while (k < bMatch.smethod_0())
							{
								if (class10_1.slotId[k] == num)
								{
									flag = false;
									IL_A4:
									if (flag)
									{
										Class723.smethod_5(Class72.class10_0.class861_0[j].Name + " left the game.", Color.get_OrangeRed(), 3000, null);
										Class331.smethod_59("match-leave", 100, Enum112.flag_5);
										goto IL_173;
									}
									goto IL_173;
								}
								else
								{
									k++;
								}
							}
							goto IL_A4;
						}
						int num2 = class10_1.slotId[j];
						bool flag2 = true;
						int l = 0;
						while (l < bMatch.smethod_0())
						{
							if (Class72.class10_0.slotId[l] == num2)
							{
								flag2 = false;
								IL_121:
								if (flag2 && class10_1.class861_0[j].int_1 != Class115.class861_0.int_1)
								{
									Class723.smethod_5(class10_1.class861_0[j].Name + " joined the game.", Color.get_YellowGreen(), 3000, null);
									Class331.smethod_59("match-join", 100, Enum112.flag_5);
									goto IL_173;
								}
								goto IL_173;
							}
							else
							{
								l++;
							}
						}
						goto IL_121;
					}
					IL_173:;
				}
			}
			if (class10_1.beatmapChecksum != Class72.class10_0.beatmapChecksum)
			{
				Class72.bool_5 = true;
			}
			if (!Class72.bool_4)
			{
				Class62.int_12 = class10_1.Seed;
			}
			class10_1.gamePassword = Class72.class10_0.gamePassword;
			Class72.class10_0 = class10_1;
			Class72.bool_6 = true;
		}

		// Token: 0x06002871 RID: 10353
		// RVA: 0x0001F24B File Offset: 0x0001D44B
		public static void smethod_2()
		{
			Class72.smethod_3();
		}

		// Token: 0x06002872 RID: 10354
		// RVA: 0x0001F2AC File Offset: 0x0001D4AC
		internal static void smethod_3()
		{
			if (Class70.enum59_0 == Enum59.const_1)
			{
				return;
			}
			Class70.enum59_0 = Enum59.const_1;
			Class809.smethod_34(Enum3.const_33, null);
			Class876.class623_0 = Mods.None;
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Lobby, false);
		}

		// Token: 0x06002873 RID: 10355
		// RVA: 0x000FE7A0 File Offset: 0x000FC9A0
		public static void smethod_4(Class10 class10_1)
		{
			Class72.class10_0 = class10_1;
			if (!Class72.bool_2)
			{
				Class72.smethod_3();
				return;
			}
			if (Class72.class72_0 != null)
			{
				Class72.class72_0.method_1();
			}
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class331.smethod_59("match-start", 100, Enum112.flag_5);
			Class64.class10_0 = class10_1;
			Class70.enum59_0 = Enum59.const_5;
			Class115.smethod_70(OsuModes.Play, false);
		}

		// Token: 0x06002874 RID: 10356
		// RVA: 0x000FE804 File Offset: 0x000FCA04
		public static void smethod_5()
		{
			Class72.bool_4 = true;
			Class72.bool_6 = true;
			Class72.bool_3 = true;
			if (Class72.class10_0 != null)
			{
				Class72.class10_0.gamePassword = null;
			}
			Class723.smethod_5(Class41.GetString(OsuString.MatchSetup_BecameHost), Color.get_YellowGreen(), 6000, null);
			Class331.smethod_59("match-confirm", 100, Enum112.flag_5);
		}

		// Token: 0x06002875 RID: 10357
		// RVA: 0x000FE860 File Offset: 0x000FCA60
		public static void smethod_6(Struct13 struct13_0)
		{
			Class72.Class652 class = new Class72.Class652();
			class.struct13_0 = struct13_0;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06002876 RID: 10358
		// RVA: 0x0001F2E9 File Offset: 0x0001D4E9
		[CompilerGenerated]
		private static void smethod_7(Class531 class531_3)
		{
			class531_3.method_12();
		}

		// Token: 0x06002878 RID: 10360
		// RVA: 0x0001EBEB File Offset: 0x0001CDEB
		[CompilerGenerated]
		private static void smethod_8(Class531 class531_3)
		{
			class531_3.method_16(50, Enum70.const_0);
		}

		// Token: 0x0600287B RID: 10363
		// RVA: 0x0001F337 File Offset: 0x0001D537
		[CompilerGenerated]
		private static void smethod_9()
		{
			Class466.Current.method_57();
			Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
			Class72.bool_6 = true;
			Class72.bool_5 = true;
		}
	}
}
