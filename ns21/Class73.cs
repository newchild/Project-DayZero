using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns18;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns64;
using ns76;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns9;
using ns90;
using osu;
using osu.GameModes.Select;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x0200050E RID: 1294
	internal class Class73 : Class61
	{
		// Token: 0x04002283 RID: 8835
		protected bool bool_2;

		// Token: 0x04002284 RID: 8836
		protected bool bool_3;

		// Token: 0x04002286 RID: 8838
		protected bool bool_4;

		// Token: 0x04002293 RID: 8851
		private Class110 class110_0;

		// Token: 0x0400227F RID: 8831
		private Class339 class339_0;

		// Token: 0x0400228A RID: 8842
		protected internal Class512 class512_0;

		// Token: 0x04002280 RID: 8832
		protected Class531 class531_0;

		// Token: 0x04002281 RID: 8833
		protected Class531 class531_1;

		// Token: 0x04002282 RID: 8834
		protected Class531 class531_2;

		// Token: 0x04002289 RID: 8841
		protected Class531 class531_3;

		// Token: 0x0400228E RID: 8846
		protected Class531[] class531_4 = new Class531[10];

		// Token: 0x04002291 RID: 8849
		private Class531 class531_5;

		// Token: 0x04002292 RID: 8850
		private Class531 class531_6;

		// Token: 0x04002295 RID: 8853
		private Class531 class531_7;

		// Token: 0x04002288 RID: 8840
		protected Class536 class536_0;

		// Token: 0x04002287 RID: 8839
		protected Class543 class543_0;

		// Token: 0x04002294 RID: 8852
		private Class760 class760_0;

		// Token: 0x0400228B RID: 8843
		protected Class911 class911_1;

		// Token: 0x0400228C RID: 8844
		protected Class911 class911_2;

		// Token: 0x0400228D RID: 8845
		protected Class911 class911_3;

		// Token: 0x04002285 RID: 8837
		private Class99 class99_0;

		// Token: 0x0400228F RID: 8847
		protected int int_2;

		// Token: 0x0400227D RID: 8829
		protected readonly List<Class531> list_0 = new List<Class531>();

		// Token: 0x0400227E RID: 8830
		protected List<Class437> list_1 = new List<Class437>();

		// Token: 0x04002296 RID: 8854
		[CompilerGenerated]
		private static Predicate<bool> predicate_0;

		// Token: 0x04002297 RID: 8855
		[CompilerGenerated]
		private static Predicate<bool> predicate_1;

		// Token: 0x04002290 RID: 8848
		protected string string_0;

		// Token: 0x0600299D RID: 10653
		// RVA: 0x0001FFB3 File Offset: 0x0001E1B3
		internal Class73(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x060029A0 RID: 10656
		// RVA: 0x001078E4 File Offset: 0x00105AE4
		protected override void Dispose(bool bool_5)
		{
			if (this.class339_0 != null)
			{
				this.class339_0.method_11(true);
			}
			Class331.smethod_96();
			if (this.class110_0 != null)
			{
				this.class110_0.Dispose();
			}
			Class570.smethod_1(new Class570.Delegate44(this.method_1));
			if (Class466.Current != null)
			{
				Class466.Current.list_0.Clear();
			}
			if (this.class99_0 != null)
			{
				this.class99_0.Close(false);
				this.class99_0.Dispose();
			}
			if (this.class512_0 != null)
			{
				if (this.class512_0.list_0 != null)
				{
					this.class512_0.method_22();
				}
				if (this.bool_3)
				{
					this.class512_0.method_15(new Delegate59(this.method_9));
				}
				if (!Class802.smethod_0())
				{
					this.class512_0.method_24();
				}
			}
			OsuModes osuModes_ = Class115.osuModes_0;
			if (osuModes_ != OsuModes.Rank)
			{
				switch (osuModes_)
				{
				case OsuModes.RankingVs:
				case OsuModes.RankingTagCoop:
				case OsuModes.RankingTeam:
					goto IL_F0;
				case OsuModes.OnlineSelection:
				case OsuModes.OptionsOffsetWizard:
					IL_EA:
					Class62.class512_0 = null;
					goto IL_F0;
				}
				goto IL_EA;
			}
			IL_F0:
			Class115.class911_0.Remove(this.class531_3);
			if (this.class911_2 != null)
			{
				this.class911_2.Dispose();
			}
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			base.Dispose(bool_5);
		}

		// Token: 0x060029A2 RID: 10658
		// RVA: 0x0001FFDF File Offset: 0x0001E1DF
		public override void Draw()
		{
			if (this.class110_0 == null)
			{
				return;
			}
			base.Draw();
			this.class911_1.Draw();
			this.class110_0.Draw();
			this.class911_3.Draw();
		}

		// Token: 0x060029A1 RID: 10657
		// RVA: 0x00107A34 File Offset: 0x00105C34
		public override void imethod_2()
		{
			if (this.class110_0 == null)
			{
				return;
			}
			this.class110_0.imethod_2();
			if (this.class760_0 != null)
			{
				if (this.class110_0.vector2_3.Y > 20f)
				{
					this.class760_0.method_4();
				}
				else
				{
					this.class760_0.method_5();
				}
			}
			int num = Class115.int_1 - this.int_2;
			int num2 = num / 500;
			if (this.class536_0 != null)
			{
				string text = string.Empty;
				for (int i = 0; i < Math.Max(8, this.string_0.Length); i++)
				{
					if (i >= num2)
					{
						text += Class562.smethod_1(0, 9).ToString()[0];
					}
					else
					{
						text += this.string_0[i];
					}
				}
				this.class536_0.Text = text;
			}
			if (num > 4400 && !this.bool_4)
			{
				this.vmethod_14();
			}
			base.imethod_2();
		}

		// Token: 0x060029A7 RID: 10663
		// RVA: 0x00108C14 File Offset: 0x00106E14
		public override void Initialize()
		{
			if (Class62.class512_0 == null && Class802.class512_0 == null)
			{
				Class115.smethod_71(OsuModes.Menu, true);
				return;
			}
			this.class911_1 = new Class911(true);
			this.class911_3 = new Class911(true);
			this.vmethod_10();
			if (this.class512_0 == null)
			{
				Class115.smethod_71(OsuModes.Menu, true);
				return;
			}
			if (Class466.Current == null || (!string.IsNullOrEmpty(this.class512_0.string_1) && Class466.Current.string_3 != this.class512_0.string_1))
			{
				Class296 class = Class466.smethod_25(this.class512_0.string_1);
				if (class != null)
				{
					Class466.smethod_21(class);
				}
			}
			if (Class466.Current == null)
			{
				Class115.smethod_71(OsuModes.Menu, true);
				return;
			}
			this.class110_0 = new Class110(new Rectangle(0, 0, Class115.smethod_43(), Class115.smethod_44()), new Vector2((float)Class115.smethod_43(), (float)Class115.smethod_44() * ((this.class99_0 != null) ? 1.875f : 1f) - 60f), true, 60f, Enum98.const_2);
			this.class911_2 = this.class110_0.class911_0;
			Class591 class2 = new Class591(new EventHandler(this.method_11), true, false);
			this.class911_3.Add<Class531>(class2.list_0);
			bool bool_ = Class802.bool_16;
			lock (Class858.object_0)
			{
				Class802.smethod_1(false);
				Class802.bool_16 = false;
				Class802.int_2 = 0;
			}
			this.int_2 = Class115.int_1 + 300;
			Class570.smethod_0(new Class570.Delegate44(this.method_1));
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.vmethod_12), Enum98.const_2, Enum97.const_0);
			this.class531_5 = new Class531(Class885.Load("ranking-background-overlay", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(180f, (float)(Class885.smethod_25() ? 200 : 170)), 0.05f, true, Color.get_White(), null);
			this.class531_5.bool_7 = true;
			this.class531_5.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 6.28318548f, Class115.int_1, Class115.int_1 + 20000, Enum70.const_0));
			this.class531_5.class26_0[0].bool_0 = true;
			this.class911_1.Add(this.class531_5);
			Class531 class3 = new Class531(Class885.Load("ranking-title", Enum112.flag_6), Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(20f, 0f), 0.991f, true, Color.get_White(), null);
			class3.bool_11 = Class885.smethod_25();
			this.class911_2.Add(class3);
			this.vmethod_9();
			this.string_0 = string.Format("{0:00000000}", this.class512_0.int_3);
			Class531 class4 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.99f, true, Color.get_Black(), null);
			class4.float_3 = 0.8f;
			class4.vector2_2 = new Vector2((float)Class115.smethod_43() * 1.6f, 96f);
			class4.bool_11 = true;
			this.class911_2.Add(class4);
			this.vmethod_11();
			this.vmethod_6(this.class512_0);
			base.Initialize();
			if (!this.bool_4)
			{
				this.vmethod_14();
			}
			if (this.bool_4 && !bool_)
			{
				this.method_10(false);
				return;
			}
			List<bool> arg_36B_0 = this.class512_0.list_4;
			if (Class73.predicate_0 == null)
			{
				Class73.predicate_0 = new Predicate<bool>(Class73.smethod_0);
			}
			int arg_3A7_0 = arg_36B_0.FindAll(Class73.predicate_0).Count;
			List<bool> arg_39D_0 = this.class512_0.list_4;
			if (Class73.predicate_1 == null)
			{
				Class73.predicate_1 = new Predicate<bool>(Class73.smethod_1);
			}
			if (arg_3A7_0 > arg_39D_0.FindAll(Class73.predicate_1).Count)
			{
				this.class339_0 = Class331.smethod_59("applause", 100, Enum112.flag_6);
			}
		}

		// Token: 0x0600299E RID: 10654
		// RVA: 0x00107808 File Offset: 0x00105A08
		protected bool method_1(object object_0, Keys keys_0)
		{
			if (keys_0 == 27)
			{
				this.vmethod_13();
				return true;
			}
			if (keys_0 == 113)
			{
				if (this.class512_0.bool_1)
				{
					this.method_8(new Delegate59(this.method_2));
					return true;
				}
				if (this.class512_0 != null)
				{
					Class908.smethod_6((this.class512_0.list_1 != null || Class62.class512_0 == null) ? this.class512_0 : Class62.class512_0, null);
					return true;
				}
			}
			if (keys_0 != 32)
			{
				if (keys_0 != 13)
				{
					return false;
				}
			}
			this.method_10(false);
			return true;
		}

		// Token: 0x060029B3 RID: 10675
		// RVA: 0x0010994C File Offset: 0x00107B4C
		protected bool method_10(bool bool_5)
		{
			if (Class115.int_1 - this.int_2 < 5000 && !this.bool_2)
			{
				this.bool_2 = true;
				this.int_2 = Class115.int_1 - 7000;
				lock (this.class911_2.list_2)
				{
					foreach (Class530 current in this.class911_2.list_2)
					{
						foreach (Class746 current2 in current.class26_0)
						{
							if (!current2.bool_0)
							{
								current2.int_0 = this.int_2 - 200;
								current2.int_1 = this.int_2 - 100;
							}
						}
					}
				}
				this.class911_3.Remove(this.class531_3);
				return false;
			}
			if (bool_5)
			{
				this.vmethod_13();
			}
			return true;
		}

		// Token: 0x060029B6 RID: 10678
		// RVA: 0x000200C4 File Offset: 0x0001E2C4
		[CompilerGenerated]
		private void method_11(object sender, EventArgs e)
		{
			this.vmethod_13();
		}

		// Token: 0x060029B9 RID: 10681
		// RVA: 0x000200CC File Offset: 0x0001E2CC
		[CompilerGenerated]
		private bool method_12(Class512 class512_1)
		{
			return class512_1.long_0 == this.class512_0.long_0;
		}

		// Token: 0x060029BA RID: 10682
		// RVA: 0x000200E1 File Offset: 0x0001E2E1
		[CompilerGenerated]
		private bool method_13(Class512 class512_1)
		{
			return class512_1.int_3 >= this.class512_0.int_3;
		}

		// Token: 0x060029BB RID: 10683
		// RVA: 0x000200F9 File Offset: 0x0001E2F9
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			this.class110_0.method_23((float)Class115.smethod_44() * 0.875f, -0.99f);
		}

		// Token: 0x0600299F RID: 10655
		// RVA: 0x00107894 File Offset: 0x00105A94
		private void method_2(object object_0)
		{
			this.class512_0.method_15(new Delegate59(this.method_2));
			Class908.smethod_6(this.class512_0, null);
			this.bool_3 = false;
			this.class911_2.float_5 = 0f;
			Class723.smethod_3();
		}

		// Token: 0x060029AA RID: 10666
		// RVA: 0x001091FC File Offset: 0x001073FC
		protected void method_3(bool bool_5)
		{
			Predicate<Class512> predicate = null;
			this.class512_0 = Class62.class512_0;
			if (this.class512_0.bool_2 && !this.bool_4 && !Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax) && !Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax2))
			{
				if (Class466.Current.class512_0 != null)
				{
					if (this.class512_0.int_3 > Class466.Current.class512_0.int_3)
					{
						Class466.Current.method_42(this.class512_0.vmethod_4());
					}
				}
				else if (Class466.Current.method_41() == Rankings.N)
				{
					Class466.Current.method_42(this.class512_0.vmethod_4());
				}
				else
				{
					List<Class512> list = Class908.smethod_0(Class466.Current.string_3, this.class512_0.playModes_0);
					if (list == null || list.Count == 0)
					{
						if (this.class512_0.vmethod_4() < Class466.Current.method_41())
						{
							Class466.Current.method_42(this.class512_0.vmethod_4());
						}
					}
					else
					{
						List<Class512> arg_13D_0 = list;
						if (predicate == null)
						{
							predicate = new Predicate<Class512>(this.method_13);
						}
						if (arg_13D_0.FindAll(predicate).Count == 0)
						{
							Class466.Current.method_42(this.class512_0.vmethod_4());
						}
					}
				}
				if (bool_5)
				{
					this.class99_0 = new Class99(this);
				}
			}
		}

		// Token: 0x060029AC RID: 10668
		// RVA: 0x00020013 File Offset: 0x0001E213
		protected void method_4(object sender, EventArgs e)
		{
			if (!this.bool_3 && this.method_10(false))
			{
				this.method_7();
			}
		}

		// Token: 0x060029AD RID: 10669
		// RVA: 0x0002002C File Offset: 0x0001E22C
		protected void method_5(object sender, EventArgs e)
		{
			this.method_10(false);
			if (!this.bool_3)
			{
				Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				Class115.smethod_70(OsuModes.Play, false);
			}
		}

		// Token: 0x060029AE RID: 10670
		// RVA: 0x00020056 File Offset: 0x0001E256
		protected void method_6(object sender, EventArgs e)
		{
			this.method_10(true);
		}

		// Token: 0x060029AF RID: 10671
		// RVA: 0x0010979C File Offset: 0x0010799C
		protected void method_7()
		{
			if (this.class512_0.bool_1)
			{
				this.method_8(new Delegate59(this.method_9));
				return;
			}
			if (this.class512_0.list_1 == null || this.class512_0.list_1.Count == 0)
			{
				if (this.class512_0.byte_0 == null)
				{
					this.class512_0.method_25();
				}
				this.class512_0.method_19();
			}
			if (this.class512_0.list_1 != null && this.class512_0.list_1.Count > 0)
			{
				Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				Class858.smethod_4(false);
				Class802.smethod_1(true);
				Class802.class512_0 = this.class512_0;
				Class62.int_12 = this.class512_0.int_5;
				Class115.smethod_70(OsuModes.Play, false);
				return;
			}
			Class723.smethod_5("This score has no replay data saved!", Color.get_Red(), 5000, null);
		}

		// Token: 0x060029B0 RID: 10672
		// RVA: 0x00020060 File Offset: 0x0001E260
		private void method_8(Delegate59 delegate59_0)
		{
			Class723.smethod_1("Downloading replay data...", 10000);
			this.class911_2.float_5 = 0.5f;
			this.bool_3 = true;
			this.class512_0.method_12();
			this.class512_0.method_14(delegate59_0);
		}

		// Token: 0x060029B1 RID: 10673
		// RVA: 0x00109880 File Offset: 0x00107A80
		protected void method_9(object object_0)
		{
			this.class512_0.method_15(new Delegate59(this.method_9));
			this.bool_3 = false;
			if (this.class512_0.list_1 != null && this.class512_0.list_1.Count > 0)
			{
				Class723.smethod_3();
				Class858.smethod_4(false);
				Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				Class802.smethod_1(true);
				Class802.class512_0 = this.class512_0;
				Class62.int_12 = this.class512_0.int_5;
				Class115.smethod_70(OsuModes.Play, false);
				return;
			}
			Class723.smethod_1("Replay data is not available for this play!", 2000);
			this.class911_2.float_5 = 0f;
			this.class531_1.method_16(100, Enum70.const_0);
			this.class531_1.bool_1 = false;
		}

		// Token: 0x060029B7 RID: 10679
		// RVA: 0x00007F8B File Offset: 0x0000618B
		[CompilerGenerated]
		private static bool smethod_0(bool bool_5)
		{
			return bool_5;
		}

		// Token: 0x060029B8 RID: 10680
		// RVA: 0x0001929C File Offset: 0x0001749C
		[CompilerGenerated]
		private static bool smethod_1(bool bool_5)
		{
			return !bool_5;
		}

		// Token: 0x060029A9 RID: 10665
		// RVA: 0x00109098 File Offset: 0x00107298
		protected virtual void vmethod_10()
		{
			Predicate<Class512> predicate = null;
			this.bool_4 = Class802.smethod_0();
			if (this.bool_4 && (Class62.class512_0 == null || !Class876.smethod_6(Class62.class512_0.class623_0, Mods.Autoplay)))
			{
				if (Class802.bool_16 && Class62.class512_0 != null)
				{
					this.class512_0 = Class62.class512_0;
					if (this.class512_0.string_2.Length == 0)
					{
						this.class512_0.string_2 = Class858.class861_0.Name;
						return;
					}
				}
				else
				{
					this.class512_0 = Class802.class512_0;
					if (Class62.class512_0 != null && Class62.class512_0.list_2 != null)
					{
						this.class512_0.list_2 = new List<int>();
						this.class512_0.list_2.AddRange(Class62.class512_0.list_2);
					}
					if (this.class512_0.bool_1)
					{
						List<Class512> list = Class908.smethod_0(this.class512_0.string_1, this.class512_0.playModes_0);
						if (list != null)
						{
							List<Class512> arg_107_0 = list;
							if (predicate == null)
							{
								predicate = new Predicate<Class512>(this.method_12);
							}
							Class512 class = arg_107_0.Find(predicate);
							if (class != null && class.method_9())
							{
								this.class512_0 = class;
							}
						}
					}
					this.class512_0.method_25();
					if (this.class512_0.string_4 != null)
					{
						this.class512_0.method_21(this.class512_0.string_4);
						return;
					}
				}
			}
			else
			{
				this.method_3(true);
			}
		}

		// Token: 0x060029AB RID: 10667
		// RVA: 0x00109378 File Offset: 0x00107578
		protected virtual void vmethod_11()
		{
			EventHandler eventHandler = null;
			Class533 class = new Class533(Class466.Current.string_6, 22f, new Vector2(0f, 0f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class.bool_11 = true;
			this.class911_2.Add(class);
			class = new Class533("Beatmap by " + Class466.Current.string_5, 16f, new Vector2(1f, 20f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class.bool_11 = true;
			this.class911_2.Add(class);
			class = new Class533(string.Format("Played by {0} on {1}.", this.class512_0.string_2, this.class512_0.dateTime_0.ToLocalTime()), 16f, new Vector2(1f, 34f), Vector2.get_Zero(), 0.991f, true, Color.get_White(), false);
			class.bool_11 = true;
			this.class911_2.Add(class);
			float num = 360f;
			if (!this.bool_4)
			{
				if (Class885.smethod_25())
				{
					this.class531_2 = new Class531(Class885.Load("pause-retry", Enum112.flag_6), Enum115.const_7, Origins.CentreRight, Enum114.const_0, new Vector2(0f, num), 0.94f, true, new Color(255, 255, 255, 178), null);
				}
				else
				{
					this.class531_2 = new Class531(Class885.Load("ranking-retry", Enum112.flag_6), Enum115.const_7, Origins.CentreRight, Enum114.const_0, new Vector2(0f, num), 0.94f, true, new Color(255, 255, 255, 178), null);
				}
				this.class531_2.method_2(new EventHandler(this.method_5));
				this.class531_2.bool_1 = true;
				this.class531_2.class746_1 = new Class746(TransformationType.Fade, 0.7f, 1f, 0, 200, Enum70.const_0);
				this.class911_2.Add(this.class531_2);
				num += 60f;
			}
			if (((this.class512_0.list_1 != null && this.class512_0.list_1.Count > 0) || (this.class512_0.byte_0 != null || this.class512_0.method_9()) || (Class341.class605_5 == RankingType.Top && (this.class512_0.int_1 <= 40 || (this.class512_0.int_1 <= 50 && this.class512_0.dateTime_0 > new DateTime(2013, 7, 1))) && this.class512_0.bool_1)) && !Class115.bool_16)
			{
				if (Class885.smethod_25())
				{
					this.class531_1 = new Class531(Class885.Load("pause-replay", Enum112.flag_6), Enum115.const_7, Origins.CentreRight, Enum114.const_0, new Vector2(0f, num), 0.94f, true, new Color(255, 255, 255, 178), null);
				}
				else
				{
					this.class531_1 = new Class531(Class885.Load("ranking-replay", Enum112.flag_6), Enum115.const_7, Origins.CentreRight, Enum114.const_0, new Vector2(0f, num), 0.94f, true, new Color(255, 255, 255, 178), null);
				}
				this.class531_1.method_2(new EventHandler(this.method_4));
				this.class531_1.bool_1 = true;
				this.class531_1.class746_1 = new Class746(TransformationType.Fade, 0.7f, 1f, 0, 200, Enum70.const_0);
				this.class911_2.Add(this.class531_1);
				num += 60f;
			}
			if (this.class99_0 != null)
			{
				string arg_3F5_0 = "▼ Online Ranking ▼";
				Vector2 arg_3F5_1 = new Vector2((float)(Class115.smethod_43() / 2 - 100), (float)(Class115.smethod_44() - 26));
				Vector2 arg_3F5_2 = new Vector2(200f, 30f);
				float arg_3F5_3 = 0.95f;
				Color arg_3F5_4 = Color.get_BlueViolet();
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_14);
				}
				this.class760_0 = new Class760(arg_3F5_0, arg_3F5_1, arg_3F5_2, arg_3F5_3, arg_3F5_4, eventHandler, true, false, null);
				this.class911_2.Add<Class531>(this.class760_0.list_0);
			}
		}

		// Token: 0x060029B2 RID: 10674
		// RVA: 0x0002009F File Offset: 0x0001E29F
		protected virtual bool vmethod_12(object object_0, EventArgs eventArgs_0)
		{
			this.method_10(false);
			return false;
		}

		// Token: 0x060029B4 RID: 10676
		// RVA: 0x000200AA File Offset: 0x0001E2AA
		protected virtual void vmethod_13()
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.SelectPlay, false);
		}

		// Token: 0x060029B5 RID: 10677
		// RVA: 0x00109A84 File Offset: 0x00107C84
		protected virtual void vmethod_14()
		{
			if (this.class99_0 != null && !this.class99_0.bool_1)
			{
				this.class99_0.vmethod_3();
				this.class99_0.vmethod_4();
				this.class99_0.class911_0.vector2_2 = new Vector2(0f, (float)Class115.smethod_44());
				this.class110_0.method_30(this.class99_0.class911_0);
				return;
			}
		}

		// Token: 0x060029A3 RID: 10659
		// RVA: 0x00107B34 File Offset: 0x00105D34
		protected virtual int vmethod_5()
		{
			int num = 300 - (this.bool_2 ? 7000 : 0);
			foreach (Class437 current in this.list_1)
			{
				if (current.class531_0 != null)
				{
					foreach (Class746 current2 in current.class531_0.class26_0)
					{
						current2.int_0 += num;
						current2.int_1 += num;
					}
					this.class911_2.Add(current.class531_0);
					this.list_0.Add(current.class531_0);
				}
				if (current.class531_1 != null)
				{
					foreach (Class746 current3 in current.class531_1.class26_0)
					{
						current3.int_0 += num;
						current3.int_1 += num;
					}
					this.class911_2.Add(current.class531_1);
					this.list_0.Add(current.class531_1);
				}
				if (!current.bool_0)
				{
					num += 300;
				}
			}
			return num;
		}

		// Token: 0x060029A4 RID: 10660
		// RVA: 0x00107CE4 File Offset: 0x00105EE4
		protected virtual void vmethod_6(Class512 class512_1)
		{
			if (class512_1 == null)
			{
				return;
			}
			foreach (Class531 current in this.list_0)
			{
				current.method_16(100, Enum70.const_0);
				current.bool_0 = false;
			}
			this.list_0.Clear();
			this.list_1.Clear();
			this.class512_0 = class512_1;
			this.string_0 = string.Format("{0:00000000}", class512_1.int_3);
			this.class536_0 = new Class536("", Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(220f, 94f), 0.8f, true, Color.get_White(), true);
			this.class536_0.float_2 = (Class885.smethod_25() ? 1.3f : 1.05f);
			if (Class885.smethod_25())
			{
				this.class536_0.int_9 = -2;
			}
			this.class536_0.bool_21 = true;
			this.class911_2.Add(this.class536_0);
			this.list_0.Add(this.class536_0);
			Class437 class;
			switch (class512_1.playModes_0)
			{
			case PlayModes.Osu:
				this.list_1.Add(new Class437("hit300", new Vector2(40f, 160f), string.Format("{0}x", class512_1.ushort_1), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("hit100", new Vector2(40f, 220f), string.Format("{0}x", class512_1.ushort_0), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("hit50", new Vector2(40f, 280f), string.Format("{0}x", class512_1.ushort_2), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("hit300g", new Vector2(240f, 160f), string.Format("{0}x", class512_1.ushort_3), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("hit100k", new Vector2(240f, 220f), string.Format("{0}x", class512_1.ushort_4), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("hit0", new Vector2(240f, 280f), string.Format("{0}x", class512_1.ushort_5), false, 0, Origins.Centre));
				break;
			case PlayModes.Taiko:
				this.list_1.Add(new Class437("taiko-hit300", new Vector2(40f, 160f), string.Format("{0}x", (int)(class512_1.ushort_1 - class512_1.ushort_3)), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("taiko-hit100", new Vector2(40f, 220f), string.Format("{0}x", (int)(class512_1.ushort_0 - class512_1.ushort_4)), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("taiko-hit0", new Vector2(40f, 280f), string.Format("{0}x", class512_1.ushort_5), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("taiko-hit300g", new Vector2(240f, 160f), string.Format("{0}x", class512_1.ushort_3), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("taiko-hit100k", new Vector2(240f, 220f), string.Format("{0}x", class512_1.ushort_4), false, 0, Origins.Centre));
				break;
			case PlayModes.CatchTheBeat:
				this.list_1.Add(new Class437("fruit-orange-overlay", new Vector2(40f, 160f), null, true, 0, Origins.Centre));
				class = new Class437("fruit-orange", new Vector2(40f, 160f), string.Format("{0}x", class512_1.ushort_1), false, 0, Origins.Centre);
				class.class531_0.color_0 = Color.get_Orange();
				this.list_1.Add(class);
				class = new Class437("fruit-drop", new Vector2(40f, 220f), string.Format("{0}x", class512_1.ushort_0), false, 0, Origins.Centre);
				class.vmethod_2(1f, 0.6f);
				class.class531_0.color_0 = Color.get_YellowGreen();
				this.list_1.Add(class);
				class = new Class437("fruit-drop", new Vector2(40f, 280f), string.Format("{0}x", class512_1.ushort_2), false, 0, Origins.Centre);
				class.vmethod_2(1f, 0.4f);
				class.vmethod_1(4f);
				class.class531_0.color_0 = Color.get_LightBlue();
				this.list_1.Add(class);
				class = new Class437("fruit-orange-overlay", new Vector2(240f, 160f), null, true, 0, Origins.Centre);
				class.vmethod_2(1f, 0.4f);
				class.vmethod_1(0.8f);
				this.list_1.Add(class);
				class = new Class437("hit0", new Vector2(240f, 160f) - new Vector2(20f, 20f), null, true, 0, Origins.Centre);
				class.vmethod_2(0.7f, 0.2f);
				this.list_1.Add(class);
				class = new Class437("fruit-orange", new Vector2(240f, 160f), string.Format("{0}x", class512_1.ushort_5), false, 0, Origins.Centre);
				class.vmethod_2(1f, 0.4f);
				class.vmethod_1(0.8f);
				class.class531_0.color_0 = Color.get_LightGray();
				this.list_1.Add(class);
				break;
			case PlayModes.OsuMania:
				this.list_1.Add(new Class437("mania-hit300", new Vector2(40f, 160f), string.Format("{0}x", class512_1.ushort_1), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("mania-hit200", new Vector2(40f, 220f), string.Format("{0}x", class512_1.ushort_4), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("mania-hit50", new Vector2(40f, 280f), string.Format("{0}x", class512_1.ushort_2), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("mania-hit300g", new Vector2(240f, 160f), string.Format("{0}x", class512_1.ushort_3), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("mania-hit100", new Vector2(240f, 220f), string.Format("{0}x", class512_1.ushort_0), false, 0, Origins.Centre));
				this.list_1.Add(new Class437("mania-hit0", new Vector2(240f, 280f), string.Format("{0}x", class512_1.ushort_5), false, 0, Origins.Centre));
				break;
			}
			int num = Class885.smethod_25() ? 20 : 8;
			class = new Class437("ranking-maxcombo", new Vector2(5f, (float)(320 - num)), null, false, 0, Origins.TopLeft);
			class.vmethod_2(1f, 1f);
			class.class531_0.float_0 = 0.81f;
			class.vmethod_0(string.Format("{0}x", class512_1.int_0), new Vector2(15f, 330f));
			class.class531_1.float_0 = 0.8f;
			this.list_1.Add(class);
			class = new Class437("ranking-accuracy", new Vector2(182f, (float)(320 - num)), null, false, 0, Origins.TopLeft);
			class.vmethod_2(1f, 1f);
			class.class531_0.float_0 = 0.81f;
			class.vmethod_0(string.Format("{0:0.00}%", class512_1.vmethod_1() * 100f), new Vector2(194f, 330f));
			class.class531_1.float_0 = 0.8f;
			this.list_1.Add(class);
			string text = "";
			if (class512_1.list_2 != null && class512_1.list_2.Count != 0)
			{
				List<double> list = class512_1.method_6(class512_1.list_2);
				if (list != null)
				{
					text = string.Format("Accuracy:\nError: {0:0.00}ms ~ +{1:0.00}ms\nUnstable Rate: {2:0.00}\n", list[0], list[1], list[4] * 10.0);
				}
			}
			if (class512_1.list_3 != null && class512_1.list_3.Count != 0)
			{
				List<double> list2 = class512_1.method_6(class512_1.list_3);
				if (list2 != null)
				{
					text += string.Format("Spin:\nSpeed: {0:000}(Max:{1:000}rpm)\nUnstable Rate: {2:0.00}\n", list2[2], list2[5], list2[4] * 2.0);
				}
			}
			if (text != "")
			{
				this.class531_7.bool_1 = true;
				this.class531_7.string_0 = text;
			}
			if (class512_1.bool_4)
			{
				class = new Class437("ranking-perfect", new Vector2((float)(Class885.smethod_25() ? 260 : 200), 430f), null, false, 300, Origins.Centre);
				class.vmethod_2(1.1f, 1f);
				class.class531_0.float_0 = 0.99f;
				this.list_1.Add(class);
			}
			int num2 = this.vmethod_5();
			this.vmethod_8(num2);
			if (this.class543_0 != null)
			{
				this.class911_2.Remove(this.class543_0);
				this.class543_0.Dispose();
			}
			this.class543_0 = new Class543(this.int_2, 4000, class512_1, new RectangleF(165f, (float)(Class885.smethod_25() ? 385 : 370), 186f, 86f));
			this.class911_2.Add(this.class543_0);
			this.vmethod_7();
			this.class531_3 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 1f, false, Color.get_TransparentWhite(), null);
			this.class531_3.bool_13 = false;
			this.class531_3.bool_7 = true;
			this.class531_3.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23);
			Class746 item = new Class746(TransformationType.Fade, 0.5f, 0f, this.int_2 + num2 + 1000, this.int_2 + num2 + 2400, Enum70.const_0);
			this.class531_3.class26_0.Add(item);
			this.class911_3.Add(this.class531_3);
			this.list_0.Add(this.class531_3);
		}

		// Token: 0x060029A5 RID: 10661
		// RVA: 0x0010885C File Offset: 0x00106A5C
		protected virtual void vmethod_7()
		{
			int num = 0;
			float num2 = 0f;
			int num3 = 600;
			foreach (Mods mods in Enum.GetValues(typeof(Mods)))
			{
				if (Class876.smethod_6(this.class512_0.class623_0, mods) && (mods != Mods.DoubleTime || !Class876.smethod_6(this.class512_0.class623_0, Mods.Nightcore)) && (mods != Mods.SuddenDeath || !Class876.smethod_6(this.class512_0.class623_0, Mods.Perfect)))
				{
					Class746 class = new Class746(TransformationType.Scale, 2f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					Class746 class2 = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					class.enum70_0 = Enum70.const_1;
					class2.enum70_0 = Enum70.const_1;
					Class531 class3 = new Class531(Class885.Load("selection-mod-" + mods.ToString().ToLower(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)num3, 260f), 0.92f + num2, true, Color.get_TransparentWhite(), null);
					class3.class26_0.Add(class);
					class3.class26_0.Add(class2);
					this.class911_2.Add(class3);
					num += 500;
					num2 += 1E-05f;
					num3 -= 20;
				}
			}
		}

		// Token: 0x060029A6 RID: 10662
		// RVA: 0x00108A24 File Offset: 0x00106C24
		protected virtual void vmethod_8(int int_3)
		{
			this.class531_6 = new Class531(Class885.Load("ranking-" + this.class512_0.vmethod_4(), Enum112.flag_6), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(120f, (float)(Class885.smethod_25() ? 200 : 170)), 0.9f, true, Color.get_TransparentWhite(), null);
			Class746 class = new Class746(TransformationType.Scale, 2f, 1f, this.int_2 + int_3, this.int_2 + int_3 + 1000, Enum70.const_0);
			class.enum70_0 = Enum70.const_2;
			this.class531_6.class26_0.Add(class);
			class = new Class746(TransformationType.Fade, 0f, 1f, this.int_2 + int_3, this.int_2 + int_3 + 1000, Enum70.const_0);
			class.enum70_0 = Enum70.const_2;
			this.class531_6.class26_0.Add(class);
			this.class911_2.Add(this.class531_6);
			if (this.class512_0.vmethod_4() < Rankings.C)
			{
				Class531 class2 = new Class531(Class885.Load("ranking-" + this.class512_0.vmethod_4(), Enum112.flag_6), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(120f, (float)(Class885.smethod_25() ? 200 : 170)), 0.91f, true, Color.get_TransparentWhite(), null);
				class2.bool_7 = true;
				class = new Class746(TransformationType.Scale, 1f, 1.05f, this.int_2 + int_3 + 1000, this.int_2 + int_3 + 3400, Enum70.const_0);
				class.enum70_0 = Enum70.const_1;
				class2.class26_0.Add(class);
				class = new Class746(TransformationType.Fade, 1f, 0f, this.int_2 + int_3 + 1000, this.int_2 + int_3 + 3400, Enum70.const_0);
				class.enum70_0 = Enum70.const_1;
				class2.class26_0.Add(class);
				this.class911_2.Add(class2);
			}
		}

		// Token: 0x060029A8 RID: 10664
		// RVA: 0x00108FF0 File Offset: 0x001071F0
		protected virtual void vmethod_9()
		{
			this.class531_7 = new Class531(Class885.Load("ranking-graph", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(160f, (float)(Class885.smethod_25() ? 380 : 360)), 0.8f, true, Color.get_White(), null);
			this.class911_2.Add(this.class531_7);
			Class531 class530_ = new Class531(Class885.Load("ranking-panel", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, (float)(Class885.smethod_25() ? 64 : 46)), 0.2f, true, Color.get_White(), null);
			this.class911_2.Add(class530_);
		}
	}
}
