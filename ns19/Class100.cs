using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns24;
using ns27;
using ns76;
using ns79;
using ns8;
using ns81;
using ns82;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;

namespace ns19
{
	// Token: 0x02000526 RID: 1318
	internal sealed class Class100 : Class89
	{
		// Token: 0x04002365 RID: 9061
		private bool bool_5;

		// Token: 0x04002362 RID: 9058
		private Class533 class533_0;

		// Token: 0x04002364 RID: 9060
		private Dictionary<Mods, Class692> dictionary_0 = new Dictionary<Mods, Class692>();

		// Token: 0x04002363 RID: 9059
		private readonly Enum62 enum62_0;

		// Token: 0x04002361 RID: 9057
		private float float_1;

		// Token: 0x06002AAE RID: 10926
		// RVA: 0x001140AC File Offset: 0x001122AC
		public Class100(Enum62 enum62_1) : base(Class41.GetString(OsuString.ModSelection_Title), true)
		{
			this.enum62_0 = enum62_1;
			this.class911_0.Add(this.class533_0 = new Class533("", 30f, new Vector2(0f, this.float_0 - 20f), Vector2.get_Zero(), 0.94f, true, Color.get_White(), true)
			{
				enum115_0 = Enum115.const_6
			});
			this.class533_0.origins_0 = Origins.Centre;
			this.float_0 += this.class533_0.vmethod_11().Y + 35f;
			this.float_1 = this.float_0;
			this.class911_0.Add(new Class533(Class41.GetString(OsuString.ModSelection_Reduction), 24f, new Vector2(20f, this.float_0 - 13f), Vector2.get_Zero(), 0.94f, true, Color.get_LimeGreen(), true));
			if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(0, 0), new Mods[]
				{
					Mods.Easy
				}));
			}
			if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(0, 1), new Mods[]
				{
					Mods.NoFail
				}));
			}
			if ((this.enum62_0 & Enum62.flag_1) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(0, 2), new Mods[]
				{
					Mods.HalfTime
				}));
			}
			this.float_0 += 60f;
			this.class911_0.Add(new Class533(Class41.GetString(OsuString.ModSelection_Increase), 24f, new Vector2(20f, this.float_0 - 13f), Vector2.get_Zero(), 0.94f, true, Color.get_OrangeRed(), true));
			if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(1, 0), new Mods[]
				{
					Mods.HardRock
				}));
			}
			if ((this.enum62_0 & Enum62.flag_2) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(1, 1), new Mods[]
				{
					Mods.SuddenDeath,
					Mods.Perfect
				}));
			}
			else if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(1, 1), new Mods[]
				{
					Mods.SuddenDeath
				}));
			}
			if ((this.enum62_0 & Enum62.flag_1) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(1, 2), new Mods[]
				{
					Mods.DoubleTime,
					Mods.Nightcore
				}));
			}
			if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				if (Class62.Mode == PlayModes.OsuMania)
				{
					this.method_9(new Class692(this.method_10(1, 3), new Mods[]
					{
						Mods.FadeIn,
						Mods.Hidden
					}));
				}
				else
				{
					this.method_9(new Class692(this.method_10(1, 3), new Mods[]
					{
						Mods.Hidden
					}));
				}
				this.method_9(new Class692(this.method_10(1, 4), new Mods[]
				{
					Mods.Flashlight
				}));
			}
			this.float_0 += 60f;
			this.class911_0.Add(new Class533(Class41.GetString(OsuString.ModSelection_Special), 24f, new Vector2(20f, this.float_0 - 13f), Vector2.get_Zero(), 0.94f, true, Color.get_White(), true));
			int num = 0;
			if ((this.enum62_0 & (Enum62.flag_1 | Enum62.flag_3)) > (Enum62)0)
			{
				if (Class62.Mode == PlayModes.OsuMania)
				{
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.Key4,
						Mods.Key5,
						Mods.Key6,
						Mods.Key7,
						Mods.Key8,
						Mods.Key9,
						Mods.Key1,
						Mods.Key2,
						Mods.Key3
					}));
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.KeyCoop
					}));
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.Random
					}));
				}
				else
				{
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.Relax
					}));
				}
				if (Class62.Mode == PlayModes.Osu)
				{
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.Relax2
					}));
					this.method_9(new Class692(this.method_10(2, num++), new Mods[]
					{
						Mods.SpunOut
					}));
				}
			}
			if ((this.enum62_0 & Enum62.flag_2) > (Enum62)0)
			{
				this.method_9(new Class692(this.method_10(2, num++), new Mods[]
				{
					Mods.Autoplay,
					Mods.Cinema
				}));
			}
			this.float_0 += 60f;
			base.method_3(Class41.GetString(OsuString.ModSelection_Reset), Color.get_OrangeRed(), new EventHandler(this.method_13), false, false, true);
			base.method_3(Class41.GetString(OsuString.General_Close), Color.get_Gray(), new EventHandler(this.method_14), true, false, true);
		}

		// Token: 0x06002ABB RID: 10939
		// RVA: 0x00020BFC File Offset: 0x0001EDFC
		internal override void Close(bool bool_6)
		{
			base.Close(bool_6);
		}

		// Token: 0x06002AB0 RID: 10928
		// RVA: 0x00020BBA File Offset: 0x0001EDBA
		internal Vector2 method_10(int int_1, int int_2)
		{
			return new Vector2((float)(240 + int_2 * 85), this.float_1 + (float)(int_1 * 60));
		}

		// Token: 0x06002AB1 RID: 10929
		// RVA: 0x001146D4 File Offset: 0x001128D4
		internal bool method_11(Mods mods_0, bool? nullable_0)
		{
			Class692 class = null;
			if (!this.dictionary_0.TryGetValue(mods_0, out class))
			{
				return false;
			}
			if (!nullable_0.HasValue)
			{
				if (class.mods_0 != mods_0)
				{
					if (class.list_1[0] != mods_0)
					{
						class.method_0(true, mods_0);
						return true;
					}
				}
				class.method_1(false);
			}
			else
			{
				class.method_0(nullable_0.Value, mods_0);
			}
			return true;
		}

		// Token: 0x06002AB2 RID: 10930
		// RVA: 0x0011473C File Offset: 0x0011293C
		private void method_12(object sender, EventArgs e)
		{
			if (!this.bool_1 || this.bool_5)
			{
				return;
			}
			Class692 class = sender as Class692;
			if (class == null)
			{
				return;
			}
			Mods mods_ = Class876.class623_0;
			foreach (Mods current in class.list_1)
			{
				Class876.class623_0 &= ~current;
			}
			Class876.class623_0 |= class.mods_0;
			Class876.smethod_4(class.mods_0);
			this.bool_5 = true;
			this.method_15();
			this.bool_5 = false;
			if (Class461.smethod_0(mods_) != Class461.smethod_0(Class876.class623_0))
			{
				Class876.smethod_2();
			}
		}

		// Token: 0x06002AB5 RID: 10933
		// RVA: 0x00114824 File Offset: 0x00112A24
		private void method_13(object sender, EventArgs e)
		{
			bool flag = Class461.smethod_0(Class876.class623_0) > Mods.None;
			Class876.Reset();
			this.method_15();
			if (flag)
			{
				Class876.smethod_2();
			}
		}

		// Token: 0x06002AB6 RID: 10934
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_14(object sender, EventArgs e)
		{
		}

		// Token: 0x06002AB7 RID: 10935
		// RVA: 0x00114858 File Offset: 0x00112A58
		private void method_15()
		{
			Class876.smethod_4(Mods.None);
			Mods mods = Mods.NoFail;
			while (mods < Mods.LastMod)
			{
				bool flag;
				if (flag = Class876.smethod_5(mods))
				{
					goto IL_3E;
				}
				Class692 class = null;
				if (!this.dictionary_0.TryGetValue(mods, out class) || class.mods_0 == Mods.None || flag || !Class876.smethod_5(class.mods_0))
				{
					goto IL_3E;
				}
				IL_4C:
				mods *= Mods.Easy;
				continue;
				IL_3E:
				this.method_11(mods, new bool?(flag));
				goto IL_4C;
			}
			this.method_16();
		}

		// Token: 0x06002AB8 RID: 10936
		// RVA: 0x001148C4 File Offset: 0x00112AC4
		private void method_16()
		{
			double num = (Class62.Mode == PlayModes.OsuMania) ? Class876.smethod_8(Class876.class623_0 & ~(Mods.Hidden | Mods.HardRock | Mods.DoubleTime | Mods.Flashlight | Mods.FadeIn)) : Class876.smethod_7();
			this.class533_0.Text = string.Format("Score Multiplier: {0:0.00}x", num);
			if (num > 1.0)
			{
				this.class533_0.method_39(Color.get_GreenYellow(), 400, false, Enum70.const_0);
				return;
			}
			if (num < 1.0)
			{
				this.class533_0.method_39(Color.get_OrangeRed(), 400, false, Enum70.const_0);
				return;
			}
			this.class533_0.method_39(Color.get_White(), 400, false, Enum70.const_0);
		}

		// Token: 0x06002AAF RID: 10927
		// RVA: 0x00114644 File Offset: 0x00112844
		private void method_9(Class692 class692_0)
		{
			class692_0.eventHandler_0 = (EventHandler)Delegate.Combine(class692_0.eventHandler_0, new EventHandler(this.method_12));
			foreach (Mods current in class692_0.list_1)
			{
				this.dictionary_0.Add(current, class692_0);
			}
			this.class911_0.Add<Class531>(class692_0.list_0);
		}

		// Token: 0x06002AB9 RID: 10937
		// RVA: 0x00114974 File Offset: 0x00112B74
		internal static Mods smethod_2(Keys keys_0)
		{
			switch (Class795.smethod_4(keys_0, BindingTarget.ModSelect))
			{
			case Bindings.Easy:
				return Mods.Easy;
			case Bindings.NoFail:
				return Mods.NoFail;
			case Bindings.HalfTime:
				return Mods.HalfTime;
			case Bindings.HardRock:
				return Mods.HardRock;
			case Bindings.SuddenDeath:
				if (Class570.bool_2)
				{
					return Mods.Perfect;
				}
				return Mods.SuddenDeath;
			case Bindings.DoubleTime:
				if (Class570.bool_2)
				{
					return Mods.Nightcore;
				}
				return Mods.DoubleTime;
			case Bindings.Hidden:
				if (!Class570.bool_2 && Class62.Mode == PlayModes.OsuMania)
				{
					return Mods.FadeIn;
				}
				return Mods.Hidden;
			case Bindings.Flashlight:
				return Mods.Flashlight;
			case Bindings.Relax:
				if (Class62.Mode == PlayModes.OsuMania)
				{
					return Mods.Key4;
				}
				return Mods.Relax;
			case Bindings.Autopilot:
				if (Class62.Mode == PlayModes.OsuMania)
				{
					return Mods.Random;
				}
				return Mods.Relax2;
			case Bindings.SpunOut:
				return Mods.SpunOut;
			case Bindings.Auto:
				if (Class570.bool_2)
				{
					return Mods.Cinema;
				}
				return Mods.Autoplay;
			default:
				return Mods.None;
			}
		}

		// Token: 0x06002AB3 RID: 10931
		// RVA: 0x00020BD8 File Offset: 0x0001EDD8
		internal override void vmethod_3()
		{
			base.vmethod_3();
		}

		// Token: 0x06002AB4 RID: 10932
		// RVA: 0x00020BE0 File Offset: 0x0001EDE0
		internal override void vmethod_4()
		{
			this.bool_5 = true;
			this.method_15();
			this.bool_5 = false;
			base.vmethod_4();
		}

		// Token: 0x06002ABA RID: 10938
		// RVA: 0x00114A50 File Offset: 0x00112C50
		internal override bool vmethod_5(Keys keys_0)
		{
			Mods mods = Class100.smethod_2(keys_0);
			if (mods != Mods.None)
			{
				this.method_11(mods, null);
				return true;
			}
			if (keys_0 == 112)
			{
				this.Close(false);
				return true;
			}
			if (Class62.Mode == PlayModes.OsuMania)
			{
				switch (keys_0)
				{
				case 48:
					this.method_11(Mods.Key4, new bool?(false));
					return true;
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
					this.method_11((Mods)(32768 << keys_0 - 52), new bool?(true));
					return true;
				}
			}
			return base.vmethod_5(keys_0);
		}
	}
}
