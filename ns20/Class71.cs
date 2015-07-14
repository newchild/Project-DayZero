using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns18;
using ns23;
using ns24;
using ns26;
using ns27;
using ns29;
using ns35;
using ns59;
using ns60;
using ns64;
using ns79;
using ns8;
using ns80;
using ns81;
using ns84;
using ns9;
using ns90;
using osu;
using osu.Audio;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020004E2 RID: 1250
	internal sealed class Class71 : Class61
	{
		// Token: 0x0400215A RID: 8538
		private Class297 class297_0;

		// Token: 0x0400215C RID: 8540
		private Class533 class533_0;

		// Token: 0x0400215B RID: 8539
		private readonly Class911 class911_1;

		// Token: 0x0400215F RID: 8543
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x0400215D RID: 8541
		private int int_2;

		// Token: 0x0400215E RID: 8542
		private List<Class547> list_0 = new List<Class547>();

		// Token: 0x0600283B RID: 10299
		// RVA: 0x000FAEB4 File Offset: 0x000F90B4
		internal Class71(Class114 class114_1) : base(class114_1)
		{
			Class570.smethod_0(new Class570.Delegate44(this.method_7));
			this.class911_1 = new Class911(true);
			Class62.Mode = PlayModes.Osu;
			Class62.class512_0 = null;
			string[] files = Directory.GetFiles("Skins");
			int i = 0;
			while (i < files.Length)
			{
				string text = files[i];
				if (Path.GetExtension(text) == ".osk")
				{
					goto IL_7C;
				}
				if (Path.GetExtension(text) == ".zip")
				{
					goto Block_3;
				}
				IL_C1:
				i++;
				continue;
				Block_3:
				try
				{
					IL_7C:
					Class203 class = new Class203();
					string text2 = "Skins/" + Path.GetFileNameWithoutExtension(text);
					Directory.CreateDirectory(text2);
					class.method_6(text, text2, ".*");
				}
				catch
				{
					Class723.smethod_4(string.Format(Class41.GetString(OsuString.OptionsSkin_ImportFailed), text));
				}
				goto IL_C1;
			}
			Class885.smethod_6();
			foreach (string current in Class885.list_0)
			{
				Class547 class2 = Class885.smethod_17(current);
				if (class2.string_2 == "Default")
				{
					this.list_0.Insert(0, class2);
				}
				else
				{
					this.list_0.Add(class2);
				}
			}
			this.int_2 = this.list_0.IndexOf(Class885.class547_0) / 12;
			this.method_1(false);
		}

		// Token: 0x06002844 RID: 10308
		// RVA: 0x0001F0D4 File Offset: 0x0001D2D4
		protected override void Dispose(bool bool_2)
		{
			Class570.smethod_1(new Class570.Delegate44(this.method_7));
			this.class297_0.Dispose();
			this.class911_1.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06002846 RID: 10310
		// RVA: 0x000FBB1C File Offset: 0x000F9D1C
		public override void Draw()
		{
			if (this.class297_0.class872_0 != null)
			{
				this.class297_0.class872_0.method_4();
				this.class297_0.class872_0.method_5();
				this.class297_0.Draw();
			}
			this.class911_1.Draw();
			base.Draw();
		}

		// Token: 0x06002845 RID: 10309
		// RVA: 0x000FB9C0 File Offset: 0x000F9BC0
		public override void imethod_2()
		{
			if (Class331.enum100_0 == Enum100.const_0)
			{
				this.method_5(null, null);
			}
			Class331.smethod_48(Class331.sampleSet_0, false);
			if (Class466.Current == null)
			{
				return;
			}
			this.class297_0.method_26();
			foreach (Class304 current in this.class297_0.list_4)
			{
				if (!current.bool_0 && current.EndTime - Class331.int_7 < 16 && Class562.smethod_7(0.43))
				{
					this.class297_0.vmethod_10(current);
				}
				current.vmethod_6();
				Class321 class = current as Class321;
				if (class != null)
				{
					if (!class.vmethod_25() && class.StartTime - Class331.int_7 < 16 && Class562.smethod_7(0.44))
					{
						class.vmethod_26();
					}
					if (class.bool_5)
					{
						Class62.bool_8 = true;
						Class800.bool_2 = true;
						current.vmethod_17(Class115.smethod_61(class.PositionAtTime(Class331.int_7)));
					}
				}
				else if (current is Class328 && current.bool_5)
				{
					((Class328)current).double_4 = 0.10000000149011612;
					current.vmethod_17(Vector2.get_Zero());
				}
			}
			base.imethod_2();
		}

		// Token: 0x06002847 RID: 10311
		// RVA: 0x0001F104 File Offset: 0x0001D304
		public override void Initialize()
		{
			base.Initialize();
		}

		// Token: 0x0600283C RID: 10300
		// RVA: 0x000FB034 File Offset: 0x000F9234
		private void method_1(bool bool_2)
		{
			this.class911_1.Clear(true);
			if (bool_2)
			{
				Class885.smethod_9(null, true);
				Class331.sampleSet_0 = SampleSet.None;
			}
			if (bool_2 || this.class297_0 == null)
			{
				if (this.class297_0 != null)
				{
					this.class297_0.Dispose();
				}
				this.class297_0 = new Class298(true);
				if (Class466.Current != null)
				{
					this.class297_0.method_8(Class466.Current, Mods.None);
					this.class297_0.method_0();
				}
			}
			int num = Class115.smethod_43() - 200;
			Class591 class = new Class591(new EventHandler(Class71.smethod_0), true, false);
			this.class911_1.Add<Class531>(class.list_0);
			string arg_F4_0 = Class41.GetString(OsuString.OptionsSkin_GetMore);
			Vector2 arg_F4_1 = new Vector2((float)num, 400f);
			Vector2 arg_F4_2 = new Vector2(200f, 30f);
			float arg_F4_3 = 1f;
			Color arg_F4_4 = Color.get_White();
			if (Class71.eventHandler_4 == null)
			{
				Class71.eventHandler_4 = new EventHandler(Class71.smethod_1);
			}
			Class760 class2 = new Class760(arg_F4_0, arg_F4_1, arg_F4_2, arg_F4_3, arg_F4_4, Class71.eventHandler_4, true, false, null);
			class2.class533_0.color_0 = Color.get_Black();
			this.class911_1.Add<Class531>(class2.list_0);
			class2 = new Class760(Class41.GetString(OsuString.OptionsSkin_Random), new Vector2((float)num, 440f), new Vector2(200f, 30f), 1f, Color.get_White(), new EventHandler(this.method_5), true, false, null);
			class2.class533_0.color_0 = Color.get_Black();
			this.class911_1.Add<Class531>(class2.list_0);
			class2 = new Class760(Class41.GetString(OsuString.OptionsSkin_ExportAsOsk), new Vector2((float)num, 360f), new Vector2(200f, 30f), 1f, Color.get_White(), new EventHandler(this.method_6), true, false, null);
			class2.class533_0.color_0 = Color.get_Black();
			this.class911_1.Add<Class531>(class2.list_0);
			this.class911_1.Add(new Class533(Class41.GetString(OsuString.OptionsSkin_Available), 20f, new Vector2((float)(num + 20), 10f), Vector2.get_Zero(), 1f, true, Color.get_White(), true));
			int num2 = 30;
			for (int i = this.int_2 * 12; i < (this.int_2 + 1) * 12; i++)
			{
				int num3 = 0;
				if (i < this.list_0.Count)
				{
					Class547 class3 = this.list_0[i];
					if (class3.string_2 == Class885.class547_0.string_2)
					{
						Class533 class4 = new Class533(Class885.class547_0.string_1, 15f, new Vector2((float)(num + 4), (float)num2), new Vector2(200f, 0f), 0.9f, true, Color.get_White(), false);
						class4.object_0 = class3.string_2;
						class4.enum72_0 = Enum72.const_1;
						class4.method_53(Color.get_Black());
						class4.int_7 = 2;
						class4.method_55(Color.get_LimeGreen());
						class4.method_2(new EventHandler(this.method_4));
						this.class911_1.Add(class4);
						num3 = (int)class4.vmethod_11().Y - 15;
					}
					else
					{
						Class533 class4 = new Class533(class3.string_1, 15f, new Vector2((float)(num + 40), (float)num2), new Vector2(200f, 0f), 0.9f, true, Color.get_White(), false);
						class4.object_0 = class3.string_2;
						class4.bool_1 = true;
						class4.enum72_0 = Enum72.const_1;
						class4.method_53(Color.get_Black());
						class4.int_7 = 2;
						class4.method_55(Color.get_OrangeRed());
						class4.class746_1 = new Class746(class4.vector2_0, class4.vector2_0 - new Vector2(36f, 0f), 0, 200, Enum70.const_0);
						class4.class746_1.enum70_0 = Enum70.const_1;
						class4.method_2(new EventHandler(this.method_4));
						this.class911_1.Add(class4);
						num3 = (int)class4.vmethod_11().Y - 15;
					}
				}
				num2 += 20 + num3;
			}
			if (this.int_2 > 0)
			{
				Class533 class4 = new Class533(Class41.GetString(OsuString.OptionsSkin_Previous), 15f, new Vector2((float)(num + 40), (float)num2), new Vector2(200f, 0f), 0.9f, true, Color.get_White(), false);
				class4.bool_1 = true;
				class4.enum72_0 = Enum72.const_1;
				class4.method_53(Color.get_Black());
				class4.int_7 = 2;
				class4.method_55(Color.get_Orange());
				class4.class746_1 = new Class746(class4.vector2_0, class4.vector2_0 - new Vector2(36f, 0f), 0, 200, Enum70.const_0);
				class4.class746_1.enum70_0 = Enum70.const_1;
				class4.method_2(new EventHandler(this.method_3));
				this.class911_1.Add(class4);
			}
			num2 += 20;
			if (this.list_0.Count > (this.int_2 + 1) * 12)
			{
				Class533 class4 = new Class533(Class41.GetString(OsuString.OptionsSkin_Next), 15f, new Vector2((float)(num + 40), (float)num2), new Vector2(200f, 0f), 0.9f, true, Color.get_White(), false);
				class4.bool_1 = true;
				class4.enum72_0 = Enum72.const_1;
				class4.method_53(Color.get_Black());
				class4.int_7 = 2;
				class4.method_55(Color.get_Orange());
				class4.class746_1 = new Class746(class4.vector2_0, class4.vector2_0 - new Vector2(36f, 0f), 0, 200, Enum70.const_0);
				class4.class746_1.enum70_0 = Enum70.const_1;
				class4.method_2(new EventHandler(this.method_2));
				this.class911_1.Add(class4);
			}
			Class538 class5 = new Class538(Class885.smethod_27("scorebar-colour", Enum112.flag_6, true), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(3f, 10f), 0.95f, true, Color.get_White(), null);
			class5.int_4 = 460;
			this.class911_1.Add(class5);
			Class531 class530_ = new Class531(Class885.Load("scorebar-ki", Enum112.flag_6), Origins.Centre, new Vector2(287f, 16f), 0.97f, true, Color.get_White());
			this.class911_1.Add(class530_);
			class530_ = new Class531(Class885.Load("scorebar-kidanger", Enum112.flag_6), Origins.Centre, new Vector2(160f, 16f), 0.98f, true, Color.get_White());
			this.class911_1.Add(class530_);
			class530_ = new Class531(Class885.Load("scorebar-kidanger2", Enum112.flag_6), Origins.Centre, new Vector2(100f, 16f), 0.99f, true, Color.get_White());
			this.class911_1.Add(class530_);
			class530_ = new Class531(Class885.Load("scorebar-bg", Enum112.flag_6), Vector2.get_Zero(), 0.9f, true, Color.get_White());
			this.class911_1.Add(class530_);
			Class531 class6 = new Class531(Class115.class731_0, new Vector2((float)num, 0f), 0.2f, true, new Color(0, 0, 0, 160));
			class6.vector2_2 = new Vector2(320f, 768f);
			this.class911_1.Add(class6);
			this.class533_0 = new Class533(Class885.class547_0.string_1 + ((!string.IsNullOrEmpty(Class885.class547_0.string_0)) ? (" " + string.Format(Class41.GetString(OsuString.SongSelection_BeatmapBy), Class885.class547_0.string_0)) : string.Empty), 24f, new Vector2(0f, 30f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_0.bool_16 = true;
			this.class533_0.method_15(1500);
			this.class911_1.Add(this.class533_0);
		}

		// Token: 0x0600283D RID: 10301
		// RVA: 0x0001F083 File Offset: 0x0001D283
		private void method_2(object sender, EventArgs e)
		{
			this.int_2++;
			this.method_1(false);
		}

		// Token: 0x0600283E RID: 10302
		// RVA: 0x0001F09A File Offset: 0x0001D29A
		private void method_3(object sender, EventArgs e)
		{
			this.int_2--;
			this.method_1(false);
		}

		// Token: 0x0600283F RID: 10303
		// RVA: 0x0001F0B1 File Offset: 0x0001D2B1
		private void method_4(object sender, EventArgs e)
		{
			Class341.class605_19.Value = (string)((Class531)sender).object_0;
			this.method_1(true);
		}

		// Token: 0x06002840 RID: 10304
		// RVA: 0x000FB868 File Offset: 0x000F9A68
		private void method_5(object sender, EventArgs e)
		{
			if (Class466.list_3.Count == 0)
			{
				return;
			}
			Class296 class = Class466.list_3[Class562.smethod_1(0, Class466.list_3.Count - 1)];
			int num = 0;
			if (Class466.Current != null)
			{
				while (class.string_12 == Class466.Current.string_12 || !class.method_0())
				{
					class = Class466.list_3[Class562.smethod_1(0, Class466.list_3.Count - 1)];
					if (num++ > 5)
					{
						break;
					}
				}
			}
			Class466.smethod_21(class);
			Class331.smethod_84(Class466.Current, false, false, true, false);
			this.method_1(true);
			Class331.smethod_70(Class466.Current.int_14, false, false);
			Class331.smethod_87();
			Class331.int_7 = 0;
		}

		// Token: 0x06002841 RID: 10305
		// RVA: 0x000FB92C File Offset: 0x000F9B2C
		private void method_6(object sender, EventArgs e)
		{
			if (Class885.smethod_24())
			{
				Class723.smethod_4(Class41.GetString(OsuString.OptionsSkin_CannotExportDefault));
				return;
			}
			if (Class885.class547_0 == null)
			{
				return;
			}
			Class115.smethod_82(Class885.class547_0.string_1 + ".osk", "Skins/" + Class885.class547_0.string_2);
		}

		// Token: 0x06002843 RID: 10307
		// RVA: 0x000FB988 File Offset: 0x000F9B88
		private bool method_7(object object_0, Keys keys_0)
		{
			if (keys_0 != 27)
			{
				switch (keys_0)
				{
				case 81:
					break;
				case 82:
					this.method_1(true);
					return true;
				default:
					return false;
				}
			}
			Class71.smethod_0(null, null);
			return true;
		}

		// Token: 0x06002842 RID: 10306
		// RVA: 0x00019F21 File Offset: 0x00018121
		private static void smethod_0(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Menu, false);
		}

		// Token: 0x06002848 RID: 10312
		// RVA: 0x0001F10C File Offset: 0x0001D30C
		[CompilerGenerated]
		private static void smethod_1(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/109", null);
		}
	}
}
