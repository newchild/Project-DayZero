using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns16;
using ns18;
using ns24;
using ns25;
using ns29;
using ns40;
using ns64;
using ns77;
using ns79;
using ns80;
using ns82;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns23
{
	// Token: 0x02000444 RID: 1092
	internal sealed class Class83 : Class55
	{
		// Token: 0x02000446 RID: 1094
		[CompilerGenerated]
		private sealed class Class517
		{
			// Token: 0x04001B95 RID: 7061
			public Class83 class83_0;

			// Token: 0x04001B97 RID: 7063
			public Class83.Delegate35 delegate35_0;

			// Token: 0x04001B96 RID: 7062
			public Enum50 enum50_0;
		}

		// Token: 0x02000447 RID: 1095
		[CompilerGenerated]
		private sealed class Class518
		{
			// Token: 0x02000448 RID: 1096
			private sealed class Class519
			{
				// Token: 0x04001B9B RID: 7067
				public Class83.Class517 class517_0;

				// Token: 0x04001B9A RID: 7066
				public Class83.Class518 class518_0;

				// Token: 0x04001B9C RID: 7068
				public Class731 class731_0;

				// Token: 0x06002370 RID: 9072
				// RVA: 0x000D6340 File Offset: 0x000D4540
				public void method_0()
				{
					if (this.class518_0.int_0 != this.class517_0.class83_0.int_2)
					{
						return;
					}
					this.class517_0.class83_0.method_8(this.class517_0.enum50_0, this.class517_0.delegate35_0, this.class731_0);
				}
			}

			// Token: 0x04001B98 RID: 7064
			public Class83.Class517 class517_0;

			// Token: 0x04001B99 RID: 7065
			public int int_0;

			// Token: 0x0600236E RID: 9070
			// RVA: 0x000D61F8 File Offset: 0x000D43F8
			public void method_0()
			{
				VoidDelegate voidDelegate = null;
				Class83.Class518.Class519 class = new Class83.Class518.Class519();
				class.class518_0 = this;
				class.class517_0 = this.class517_0;
				if (this.int_0 != this.class517_0.class83_0.int_2)
				{
					return;
				}
				class.class731_0 = null;
				if (Class466.Current != null && !string.IsNullOrEmpty(Class466.Current.string_2))
				{
					OsuModes osuModes_ = Class115.osuModes_1;
					switch (osuModes_)
					{
					case OsuModes.Edit:
					case OsuModes.Play:
					case OsuModes.SelectEdit:
					case OsuModes.SelectPlay:
					case OsuModes.Rank:
						break;
					case OsuModes.Exit:
					case OsuModes.SkinSelect:
						goto IL_CD;
					default:
						switch (osuModes_)
						{
						case OsuModes.SelectMulti:
						case OsuModes.RankingVs:
						case OsuModes.RankingTagCoop:
						case OsuModes.RankingTeam:
							break;
						case OsuModes.OnlineSelection:
						case OsuModes.OptionsOffsetWizard:
							goto IL_CD;
						default:
							goto IL_CD;
						}
						break;
					}
					class.class731_0 = Class885.Load(Class466.Current.string_2, Enum112.flag_3);
					if (class.class731_0 != null)
					{
						class.class731_0.bool_4 = true;
					}
				}
				IL_CD:
				if (class.class731_0 == null && (Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0 && !Class885.smethod_24())
				{
					class.class731_0 = Class885.Load("menu-background.jpg", Enum112.flag_2);
				}
				if (class.class731_0 == null)
				{
					class.class731_0 = Class885.Load("menu-background", Enum112.flag_1);
				}
				if (class.class731_0 != null)
				{
					Class47 arg_134_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(class.method_0);
					}
					arg_134_0.Add(voidDelegate, false);
				}
			}
		}

		// Token: 0x02000445 RID: 1093
		// Token: 0x06002369 RID: 9065
		internal delegate void Delegate35(Class531 class531_0);

		// Token: 0x04001B89 RID: 7049
		internal bool bool_2 = true;

		// Token: 0x04001B91 RID: 7057
		private bool bool_3;

		// Token: 0x04001B8D RID: 7053
		internal Class531 class531_0;

		// Token: 0x04001B8A RID: 7050
		internal Class60 class60_0 = new Class60();

		// Token: 0x04001B8B RID: 7051
		internal Class60 class60_1 = new Class60
		{
			bool_4 = false,
			bool_5 = false,
			bool_6 = false,
			bool_3 = false
		};

		// Token: 0x04001B8C RID: 7052
		internal Class731 class731_0;

		// Token: 0x04001B86 RID: 7046
		private Class911 class911_0 = new Class911
		{
			bool_7 = true
		};

		// Token: 0x04001B87 RID: 7047
		private Class911 class911_1 = new Class911(true)
		{
			bool_7 = true
		};

		// Token: 0x04001B88 RID: 7048
		private Class911 class911_2 = new Class911(true);

		// Token: 0x04001B90 RID: 7056
		private Class83.Delegate35 delegate35_0;

		// Token: 0x04001B94 RID: 7060
		private Enum30 enum30_0;

		// Token: 0x04001B8F RID: 7055
		private Enum50 enum50_0 = Enum50.flag_0;

		// Token: 0x04001B8E RID: 7054
		internal float float_0 = 1f;

		// Token: 0x04001B92 RID: 7058
		private int int_2;

		// Token: 0x04001B93 RID: 7059
		private VoidDelegate voidDelegate_0;

		// Token: 0x06002357 RID: 9047
		// RVA: 0x000D5B80 File Offset: 0x000D3D80
		public Class83() : base(Class115.class114_0)
		{
			this.Initialize();
			Class115.smethod_12(new VoidDelegate(this.method_4));
			Class115.smethod_18(new VoidDelegate(this.method_3));
			Class809.smethod_10(new VoidDelegate(this.method_1));
		}

		// Token: 0x0600235C RID: 9052
		// RVA: 0x0001C035 File Offset: 0x0001A235
		protected override void Dispose(bool bool_4)
		{
			this.class911_0.Dispose();
			this.class911_1.Dispose();
			this.class911_2.Dispose();
			this.class60_0.Dispose();
			this.class60_1.Dispose();
			base.Dispose(bool_4);
		}

		// Token: 0x0600235E RID: 9054
		// RVA: 0x0001C07D File Offset: 0x0001A27D
		public override void Draw()
		{
			this.class911_0.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06002360 RID: 9056
		// RVA: 0x000D5C54 File Offset: 0x000D3E54
		public override void imethod_2()
		{
			float num = 1f - this.float_0 - this.class911_1.float_1;
			if (Math.Abs(num) > 0.001f)
			{
				this.class911_1.float_1 += num * (float)Math.Min(1.0, Class115.double_0) * (Class62.bool_12 ? 0.1f : 0.04f);
			}
			else
			{
				this.class911_1.float_1 = 1f - this.float_0;
			}
			if (Class115.int_1 < Class79.int_6)
			{
				return;
			}
			if (this.bool_2 && Class341.class606_57)
			{
				float num2 = Class802.vector2_0.X - (float)(Class115.int_22 / 2);
				float num3 = Class802.vector2_0.Y - (float)(Class115.int_23 / 2);
				this.class911_1.vector2_0 = new Vector2(num2, num3) / Class115.float_4 / 180f;
				if (this.class531_0 != null)
				{
					this.class531_0.vector2_2 = new Vector2(1.01f, 1.01f);
				}
			}
			else
			{
				this.class911_1.vector2_0 = Vector2.get_Zero();
				if (this.class531_0 != null)
				{
					this.class531_0.vector2_2 = Vector2.get_One();
				}
			}
			this.class911_0.float_1 = this.class911_1.float_1;
			this.class911_0.vector2_0 = this.class911_1.vector2_0;
			base.imethod_2();
		}

		// Token: 0x0600235D RID: 9053
		// RVA: 0x0001C075 File Offset: 0x0001A275
		public override void Initialize()
		{
			base.Initialize();
		}

		// Token: 0x06002358 RID: 9048
		// RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		private void method_1()
		{
			if (this.class731_0 != null && this.class731_0.enum112_0 != Enum112.flag_3)
			{
				this.method_7(Enum50.flag_0, null);
			}
		}

		// Token: 0x06002365 RID: 9061
		// RVA: 0x000D60EC File Offset: 0x000D42EC
		private Class531 method_10(Enum50 enum50_1)
		{
			if (this.class731_0 == null || this.class731_0.bool_2)
			{
				this.class731_0 = Class885.Load("menu-background", Enum112.flag_1);
			}
			Enum115 enum115_ = ((enum50_1 & Enum50.flag_1) != (Enum50)0) ? Enum115.const_3 : Enum115.const_9;
			return new Class531(this.class731_0, enum115_, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), Class911.smethod_4((float)Class115.int_1), true, Color.get_White(), null);
		}

		// Token: 0x06002366 RID: 9062
		// RVA: 0x000D6154 File Offset: 0x000D4354
		private void method_11(Class531 class531_1, Enum50 enum50_1, Class83.Delegate35 delegate35_1)
		{
			if (class531_1 != null && this.class731_0 != null)
			{
				if ((enum50_1 & Enum50.flag_1) != (Enum50)0)
				{
					class531_1.method_46((enum50_1 & Enum50.flag_0) != (Enum50)0, false);
				}
				else
				{
					class531_1.float_2 = (float)Class115.int_24 / (float)this.class731_0.method_1();
					if ((float)class531_1.int_6 * class531_1.float_2 * Class115.float_5 < (float)Class115.int_22)
					{
						class531_1.float_2 = (float)Class115.int_22 / ((float)class531_1.int_6 * Class115.float_5);
					}
				}
				if (delegate35_1 != null)
				{
					delegate35_1(this.class531_0);
				}
				this.enum50_0 = enum50_1;
				this.delegate35_0 = delegate35_1;
				return;
			}
		}

		// Token: 0x06002367 RID: 9063
		// RVA: 0x0001C0BE File Offset: 0x0001A2BE
		[CompilerGenerated]
		private void method_12()
		{
			this.class60_0.method_3(Class885.class547_0.list_0, true);
		}

		// Token: 0x06002359 RID: 9049
		// RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		internal int method_2()
		{
			if (this.class531_0 == null)
			{
				return 0;
			}
			return this.class531_0.method_29();
		}

		// Token: 0x0600235A RID: 9050
		// RVA: 0x0001BFE7 File Offset: 0x0001A1E7
		private void method_3()
		{
			this.method_11(this.class531_0, this.enum50_0, this.delegate35_0);
		}

		// Token: 0x0600235B RID: 9051
		// RVA: 0x0001C001 File Offset: 0x0001A201
		private void method_4()
		{
			this.method_7(Enum50.flag_0, null);
			this.float_0 = 0.6f;
			this.bool_2 = true;
			if (this.class531_0 != null)
			{
				this.class531_0.vector2_1 = Vector2.get_Zero();
			}
		}

		// Token: 0x0600235F RID: 9055
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void method_5()
		{
		}

		// Token: 0x06002361 RID: 9057
		// RVA: 0x000D5DCC File Offset: 0x000D3FCC
		internal void method_6(bool bool_4)
		{
			this.bool_3 = false;
			if (this.class531_0 == null)
			{
				return;
			}
			this.class531_0.bool_0 = false;
			this.class531_0.method_16(250, Enum70.const_0);
			this.class531_0 = null;
			if (bool_4 && this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
		}

		// Token: 0x06002362 RID: 9058
		// RVA: 0x0001C097 File Offset: 0x0001A297
		internal void method_7(Enum50 enum50_1, Class83.Delegate35 delegate35_1)
		{
			this.class731_0 = null;
			this.bool_3 = true;
			this.int_2++;
			this.method_8(enum50_1, delegate35_1, null);
		}

		// Token: 0x06002363 RID: 9059
		// RVA: 0x000D5E24 File Offset: 0x000D4024
		private void method_8(Enum50 enum50_1, Class83.Delegate35 delegate35_1, Class731 class731_1)
		{
			VoidDelegate voidDelegate = null;
			Class83.Class517 class = new Class83.Class517();
			class.enum50_0 = enum50_1;
			class.delegate35_0 = delegate35_1;
			class.class83_0 = this;
			if (Class115.int_1 < Class79.int_6 || !this.bool_3)
			{
				return;
			}
			if (this.class531_0 != null)
			{
				this.class531_0.method_25(1f, 100, Enum70.const_0);
			}
			if (class731_1 == null || class731_1.method_4())
			{
				Class83.Class518 class2 = new Class83.Class518();
				class2.class517_0 = class;
				class2.int_0 = this.int_2;
				Class115.smethod_87(new VoidDelegate(class2.method_0));
				return;
			}
			this.class731_0 = class731_1;
			this.enum30_0 = Class809.class623_0;
			if (this.class531_0 != null && this.class731_0 == this.class531_0.vmethod_6() && this.delegate35_0 == null && class.delegate35_0 == null && this.enum50_0 == class.enum50_0)
			{
				return;
			}
			bool flag = this.class531_0 == null;
			this.method_6(false);
			this.class531_0 = this.method_10(class.enum50_0);
			this.class531_0.method_15(50);
			this.method_11(this.class531_0, class.enum50_0, class.delegate35_0);
			Class911 class3 = ((class.enum50_0 & Enum50.flag_0) != (Enum50)0) ? this.class911_1 : this.class911_0;
			class3.Add(this.class531_0);
			if (this.class60_0 != null)
			{
				if (Class885.class547_0.list_0.Count != 0)
				{
					Class47 arg_15C_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_12);
					}
					arg_15C_0.Add(voidDelegate, false);
				}
				else
				{
					switch (this.class731_0.enum112_0)
					{
					case Enum112.flag_2:
					{
						Stream stream_ = new FileStream(this.class731_0.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
						this.class60_0.method_4(stream_, new VoidDelegate(this.method_9));
						goto IL_1FF;
					}
					case Enum112.flag_3:
						this.class60_0.method_4(Class466.Current.method_62(Class466.Current.string_2), new VoidDelegate(this.method_9));
						goto IL_1FF;
					}
					this.class60_0.method_4(null, new VoidDelegate(this.method_9));
				}
			}
			IL_1FF:
			if (this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
			this.class60_0.float_3 = (float)(flag ? 150 : 50);
		}

		// Token: 0x06002364 RID: 9060
		// RVA: 0x000D6088 File Offset: 0x000D4288
		private void method_9()
		{
			this.class60_0.bool_2 = (Class115.osuModes_1 != OsuModes.SelectPlay);
			if (this.class731_0 != null && this.class731_0.enum112_0 != Enum112.flag_3 && this.class60_1.method_1().Count == 0)
			{
				this.class60_1.method_3(this.class60_0.method_1(), false);
			}
		}
	}
}
