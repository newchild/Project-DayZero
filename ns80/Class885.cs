using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns23;
using ns24;
using ns26;
using ns29;
using ns64;
using ns77;
using ns79;
using ns8;
using ns82;
using ns84;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns80
{
	// Token: 0x0200068E RID: 1678
	internal static class Class885
	{
		// Token: 0x0200068F RID: 1679
		[CompilerGenerated]
		private sealed class Class886
		{
			// Token: 0x040030DE RID: 12510
			public string string_0;

			// Token: 0x06003474 RID: 13428
			// RVA: 0x0002684F File Offset: 0x00024A4F
			public bool method_0(string string_1)
			{
				return string_1.Equals(this.string_0, StringComparison.CurrentCultureIgnoreCase);
			}
		}

		// Token: 0x02000690 RID: 1680
		[CompilerGenerated]
		private sealed class Class887
		{
			// Token: 0x040030DF RID: 12511
			public List<Color> list_0;

			// Token: 0x06003476 RID: 13430
			// RVA: 0x00168738 File Offset: 0x00166938
			public void method_0()
			{
				if (Class885.class547_0 != null && Class885.class297_0 != null)
				{
					Class885.smethod_5();
					if (Class885.interface17_0 != null)
					{
						Class885.interface17_0.imethod_3(this.list_0, Class885.interface17_0.imethod_0(), Class885.interface17_0.imethod_2(), Class885.smethod_23("SliderBorder", true), Class885.class297_0.HitObjectRadius * Class115.float_1);
					}
					return;
				}
			}
		}

		// Token: 0x02000691 RID: 1681
		[CompilerGenerated]
		private sealed class Class888
		{
			// Token: 0x040030E0 RID: 12512
			public Class546 class546_0;

			// Token: 0x06003478 RID: 13432
			// RVA: 0x0002685E File Offset: 0x00024A5E
			public bool method_0(Class546 class546_1)
			{
				return class546_1.method_6() == this.class546_0.method_6();
			}
		}

		// Token: 0x02000692 RID: 1682
		[CompilerGenerated]
		private sealed class Class889
		{
			// Token: 0x040030E1 RID: 12513
			public int int_0;

			// Token: 0x0600347A RID: 13434
			// RVA: 0x00026873 File Offset: 0x00024A73
			public bool method_0(Class546 class546_0)
			{
				return class546_0.method_6() == this.int_0;
			}
		}

		// Token: 0x040030DD RID: 12509
		[CompilerGenerated]
		private static Action<Class731> action_0;

		// Token: 0x040030CF RID: 12495
		private static bool bool_0;

		// Token: 0x040030D2 RID: 12498
		internal static bool bool_1 = false;

		// Token: 0x040030D5 RID: 12501
		public static bool bool_2;

		// Token: 0x040030D7 RID: 12503
		private static bool bool_3;

		// Token: 0x040030D3 RID: 12499
		private static Class297 class297_0;

		// Token: 0x040030CB RID: 12491
		internal static Class547 class547_0;

		// Token: 0x040030CC RID: 12492
		internal static Class547 class547_1;

		// Token: 0x040030D4 RID: 12500
		internal static Class731 class731_0;

		// Token: 0x040030D6 RID: 12502
		private static Class911 class911_0 = new Class911
		{
			bool_7 = false
		};

		// Token: 0x040030CD RID: 12493
		internal static Color[] color_0 = new Color[]
		{
			new Color(255, 192, 0),
			new Color(0, 202, 0),
			new Color(18, 124, 255),
			new Color(242, 24, 57),
			new Color(0, 0, 0, 0),
			new Color(0, 0, 0, 0),
			new Color(0, 0, 0, 0),
			new Color(0, 0, 0, 0)
		};

		// Token: 0x040030D8 RID: 12504
		public static Color color_1 = new Color(236, 117, 140);

		// Token: 0x040030D9 RID: 12505
		public static Color color_2 = new Color(187, 17, 119);

		// Token: 0x040030DA RID: 12506
		public static Color color_3 = new Color(34, 153, 187);

		// Token: 0x040030C2 RID: 12482
		private static readonly Dictionary<string, int> dictionary_0 = new Dictionary<string, int>();

		// Token: 0x040030C3 RID: 12483
		private static Dictionary<string, Class731[]> dictionary_1 = new Dictionary<string, Class731[]>();

		// Token: 0x040030C4 RID: 12484
		private static Dictionary<Enum112, Dictionary<string, Class731>> dictionary_2 = new Dictionary<Enum112, Dictionary<string, Class731>>();

		// Token: 0x040030C5 RID: 12485
		private static Dictionary<string, Class731> dictionary_3 = new Dictionary<string, Class731>();

		// Token: 0x040030C6 RID: 12486
		private static Dictionary<string, Class731> dictionary_4 = new Dictionary<string, Class731>();

		// Token: 0x040030C7 RID: 12487
		private static Dictionary<string, Class731> dictionary_5 = new Dictionary<string, Class731>();

		// Token: 0x040030C9 RID: 12489
		internal static Dictionary<string, Color> dictionary_6 = new Dictionary<string, Color>();

		// Token: 0x040030CA RID: 12490
		internal static Dictionary<string, Color> dictionary_7 = new Dictionary<string, Color>();

		// Token: 0x040030D1 RID: 12497
		internal static Interface17 interface17_0;

		// Token: 0x040030CE RID: 12494
		internal static List<string> list_0;

		// Token: 0x040030D0 RID: 12496
		private static List<Class731> list_1 = new List<Class731>();

		// Token: 0x040030DB RID: 12507
		[CompilerGenerated]
		private static Predicate<Class546> predicate_0;

		// Token: 0x040030C8 RID: 12488
		private static VoidDelegate voidDelegate_0;

		// Token: 0x040030DC RID: 12508
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x0600346B RID: 13419
		// RVA: 0x000267D6 File Offset: 0x000249D6
		internal static void Cleanup()
		{
			Class742.smethod_0();
		}

		// Token: 0x0600344F RID: 13391
		// RVA: 0x00026775 File Offset: 0x00024975
		internal static void Initialize()
		{
			Class885.smethod_9(null, false);
			Class885.smethod_19();
		}

		// Token: 0x06003461 RID: 13409
		// RVA: 0x00167E30 File Offset: 0x00166030
		internal static Class731 Load(string string_0, Enum112 enum112_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			if (Class885.bool_2 && enum112_0 != Enum112.flag_3)
			{
				enum112_0 &= ~Enum112.flag_3;
			}
			if (enum112_0 == Enum112.flag_6)
			{
				switch (Class115.osuModes_1)
				{
				case OsuModes.Edit:
				case OsuModes.Play:
					break;
				default:
					enum112_0 &= ~Enum112.flag_3;
					break;
				}
			}
			Class731 class = null;
			Dictionary<string, Class731> dictionary = null;
			if (!Class885.dictionary_2.TryGetValue(enum112_0, out dictionary))
			{
				dictionary = (Class885.dictionary_2[enum112_0] = new Dictionary<string, Class731>());
			}
			if (dictionary.TryGetValue(string_0, out class))
			{
				return class;
			}
			Class731 result;
			try
			{
				Class296 current;
				if ((enum112_0 & Enum112.flag_3) > Enum112.flag_0 && (current = Class466.Current) != null)
				{
					if (Class885.dictionary_3.TryGetValue(string_0, out class))
					{
						if (class != null)
						{
							result = class;
							return result;
						}
					}
					else
					{
						using (Stream stream = current.method_62((string_0.IndexOf('.') < 0) ? (string_0 + ".png") : string_0))
						{
							if (stream != null)
							{
								class = Class731.smethod_3(stream, string_0);
								if (class != null)
								{
									class.enum112_0 = Enum112.flag_3;
								}
								Class885.smethod_26(class);
								Class885.dictionary_3[string_0] = class;
								result = class;
								return result;
							}
						}
						Class885.dictionary_3[string_0] = null;
					}
				}
				if ((enum112_0 & Enum112.flag_2) > Enum112.flag_0 && !Class885.smethod_24())
				{
					if (Class885.dictionary_5.TryGetValue(string_0, out class))
					{
						if (class != null)
						{
							result = class;
							return result;
						}
					}
					else
					{
						string text = Path.Combine(Path.Combine("Skins", Class885.class547_0.string_2), (string_0.IndexOf('.') < 0) ? (string_0 + ".png") : string_0);
						string text2 = text.Insert(text.LastIndexOf('.'), "@2x");
						if (Class115.smethod_93() && File.Exists(text2))
						{
							class = Class731.smethod_2(text2);
							class.int_3 = 2;
							Class885.dictionary_5[string_0] = class;
							if (class != null)
							{
								class.enum112_0 = Enum112.flag_2;
							}
							Class885.smethod_26(class);
							result = class;
							return result;
						}
						if (File.Exists(text))
						{
							class = Class731.smethod_2(text);
							Class885.dictionary_5[string_0] = class;
							if (class != null)
							{
								class.enum112_0 = Enum112.flag_2;
							}
							Class885.smethod_26(class);
							result = class;
							return result;
						}
						Class885.dictionary_5[string_0] = null;
					}
				}
				if ((enum112_0 & Enum112.flag_1) != Enum112.flag_0)
				{
					try
					{
						if (Class885.dictionary_4.TryGetValue(string_0, out class))
						{
							result = class;
							return result;
						}
						string_0 = Class34.smethod_15(string_0);
						class = ((string_0.IndexOf(Path.DirectorySeparatorChar) > 0) ? Class731.smethod_2(string_0) : Class731.smethod_1(string_0));
						Class885.smethod_26(class);
						Class885.dictionary_4[string_0] = class;
						if (class != null)
						{
							class.enum112_0 = Enum112.flag_1;
						}
						result = class;
						return result;
					}
					catch
					{
						result = null;
						return result;
					}
				}
				result = null;
			}
			finally
			{
				dictionary[string_0] = class;
			}
			return result;
		}

		// Token: 0x06003446 RID: 13382
		// RVA: 0x00166E7C File Offset: 0x0016507C
		internal static void smethod_0(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = Class885.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class885.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003447 RID: 13383
		// RVA: 0x00166EB0 File Offset: 0x001650B0
		internal static void smethod_1(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = Class885.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class885.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003451 RID: 13393
		// RVA: 0x00026784 File Offset: 0x00024984
		internal static void smethod_10(Class297 class297_1)
		{
			Class885.class297_0 = class297_1;
			Class885.smethod_11();
		}

		// Token: 0x06003452 RID: 13394
		// RVA: 0x001672C0 File Offset: 0x001654C0
		internal static void smethod_11()
		{
			Class885.Class887 class = new Class885.Class887();
			if (Class885.class547_0 != null && Class885.class297_0 != null)
			{
				class.list_0 = new List<Color>();
				if ((float)Class885.smethod_23("SliderTrackOverride", true).get_A() > 0f)
				{
					class.list_0.Add(Class885.smethod_23("SliderTrackOverride", true));
				}
				else if (Class466.Current != null && Class466.Current.method_5() != PlayModes.Taiko)
				{
					class.list_0.AddRange(Class885.class297_0.list_2);
				}
				else
				{
					class.list_0.Add(new Color(252, 184, 6));
				}
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
				return;
			}
		}

		// Token: 0x06003453 RID: 13395
		// RVA: 0x00167384 File Offset: 0x00165584
		internal static void smethod_12(bool bool_4)
		{
			if (!bool_4 && Class802.class531_0 != null && Class802.class531_0.vmethod_6() != null && !Class802.class531_0.vmethod_6().method_4())
			{
				return;
			}
			if (Class885.class547_0 == null)
			{
				return;
			}
			Class731 class = Class885.Load("cursor", Class341.class606_65 ? Enum112.flag_5 : Enum112.flag_6);
			Class885.class731_0 = Class885.Load("cursortrail", Class341.class606_65 ? Enum112.flag_5 : Enum112.flag_6);
			if (class != null && Class885.class731_0 != null)
			{
				Class802.bool_28 = Class885.class547_0.bool_1;
				Class531 class2 = Class802.class531_0;
				Class531 class3 = Class802.class531_1;
				if (class2 == null)
				{
					class2 = (Class802.class531_0 = new Class531(null, Enum115.const_15, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.999f, true, Color.get_White(), null)
					{
						float_3 = 0f
					});
					Class115.class911_1.Add(class2);
					class3 = (Class802.class531_1 = new Class531(null, Enum115.const_15, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 1f, true, Color.get_White(), null)
					{
						float_3 = 0f
					});
					Class115.class911_1.Add(class3);
				}
				bool flag = false;
				for (int i = 0; i < class2.class26_0.Count; i++)
				{
					if (class2.class26_0[i].transformationType_0 == TransformationType.Rotation)
					{
						flag = true;
						IL_148:
						if (!Class885.class547_0.bool_2)
						{
							class2.class26_0.Clear();
							class2.float_1 = 0f;
						}
						else if (!flag)
						{
							class2.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 6.28318548f, 0, 10000, Enum70.const_0)
							{
								bool_0 = true
							});
						}
						class2.origins_0 = (class3.origins_0 = (Class885.class547_0.bool_0 ? Origins.Centre : Origins.TopLeft));
						class2.float_2 = 1f;
						class2.vmethod_7(class);
						class3.vmethod_7(Class885.Load("cursormiddle", class.enum112_0));
						Class802.smethod_24();
						return;
					}
				}
				goto IL_148;
			}
		}

		// Token: 0x06003454 RID: 13396
		// RVA: 0x00167580 File Offset: 0x00165780
		internal static void smethod_13(bool bool_4)
		{
			Class885.bool_1 = bool_4;
			if (Class885.dictionary_3.Count == 0)
			{
				return;
			}
			Class731[] array = new Class731[Class885.dictionary_3.Count];
			Class885.dictionary_3.Values.CopyTo(array, 0);
			Class731[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Class731 class = array2[i];
				if (class != null && !class.bool_4)
				{
					class.Dispose();
				}
			}
			Class885.dictionary_3.Clear();
			Class885.dictionary_1.Clear();
			Class885.dictionary_0.Clear();
			Class885.bool_1 = false;
			Class885.dictionary_2.Clear();
		}

		// Token: 0x06003455 RID: 13397
		// RVA: 0x00167614 File Offset: 0x00165814
		internal static void smethod_14(bool bool_4)
		{
			List<Class731> list = new List<Class731>();
			foreach (Class731 current in Class885.dictionary_4.Values)
			{
				if (current != null)
				{
					if (!current.bool_4 && !bool_4)
					{
						list.Add(current);
					}
					else
					{
						current.Dispose();
					}
				}
			}
			Class885.dictionary_4.Clear();
			if (list.Count > 0)
			{
				foreach (Class731 current2 in list)
				{
					Class885.dictionary_4.Add(current2.string_0, current2);
				}
			}
			Class885.dictionary_1.Clear();
			Class885.dictionary_2.Clear();
		}

		// Token: 0x06003456 RID: 13398
		// RVA: 0x001676F8 File Offset: 0x001658F8
		internal static void smethod_15(bool bool_4)
		{
			List<Class731> list = new List<Class731>();
			foreach (Class731 current in Class885.dictionary_5.Values)
			{
				if (current != null)
				{
					if (!current.bool_4 && !bool_4)
					{
						list.Add(current);
					}
					else
					{
						current.Dispose();
					}
				}
			}
			Class885.dictionary_5.Clear();
			if (list.Count > 0)
			{
				foreach (Class731 current2 in list)
				{
					Class885.dictionary_5.Add(current2.string_0, current2);
				}
			}
			Class885.dictionary_1.Clear();
			Class885.dictionary_2.Clear();
		}

		// Token: 0x06003457 RID: 13399
		// RVA: 0x001677DC File Offset: 0x001659DC
		internal static Font smethod_16(float float_0, FontStyle fontStyle_0)
		{
			string text = Path.Combine(Path.Combine("Skins", Class885.class547_0.string_2), "taiko.ttf");
			if (!Class885.smethod_24() && File.Exists(text))
			{
				Font result;
				using (PrivateFontCollection privateFontCollection = new PrivateFontCollection())
				{
					privateFontCollection.AddFontFile(text);
					FontFamily family = privateFontCollection.Families[0];
					result = new Font(family, 19f, fontStyle_0);
				}
				return result;
			}
			return null;
		}

		// Token: 0x06003458 RID: 13400
		// RVA: 0x0016785C File Offset: 0x00165A5C
		internal static Class547 smethod_17(string string_0)
		{
			Class547 class = new Class547();
			class.string_2 = string_0;
			string path = Path.Combine(Path.Combine("Skins", string_0), "skin.ini");
			bool flag = File.Exists(path);
			bool flag2;
			if ((flag2 = (string_0 == "Default")) || string_0 == "User" || !flag)
			{
				class.double_0 = 2.5;
			}
			Class547 result;
			try
			{
				if (flag2)
				{
					class.string_1 = " osu!";
					class.string_0 = "peppy";
				}
				else if (flag)
				{
					using (StreamReader streamReader = File.OpenText(path))
					{
						string text = "General";
						while (!streamReader.EndOfStream)
						{
							string text2 = streamReader.ReadLine().Trim();
							if (text2.StartsWith("["))
							{
								text = text2.Trim(new char[]
								{
									'[',
									']'
								});
								if (text == "Mania")
								{
									class.list_2.Add(new Class546());
								}
							}
							else
							{
								class.vmethod_1(text, text2);
							}
						}
					}
				}
				class.vmethod_0();
				return class;
			}
			catch (Exception)
			{
				Class723.smethod_1(Class41.GetString(OsuString.SkinManager_ErrorLoadingConfig), 5000);
				if (flag2)
				{
					return class;
				}
				result = Class885.smethod_17("Default");
			}
			return result;
		}

		// Token: 0x06003459 RID: 13401
		// RVA: 0x001679C4 File Offset: 0x00165BC4
		[Obsolete("Support for loading mania skins from nK.ini only exists for migration to new system.")]
		private static void smethod_18()
		{
			if (Class885.smethod_24())
			{
				return;
			}
			try
			{
				string path = Path.Combine("Skins", Class885.class547_0.string_2);
				string[] files = Directory.GetFiles(path, "*K.ini");
				bool flag = false;
				for (int i = 0; i < files.Length; i++)
				{
					Class885.Class888 class = new Class885.Class888();
					class.class546_0 = new Class546();
					string text = files[i].Substring(files[i].LastIndexOf(Path.DirectorySeparatorChar) + 1);
					class.class546_0.method_7(Convert.ToInt32(text.Substring(0, text.IndexOf("K", StringComparison.CurrentCultureIgnoreCase))));
					if (Class885.class547_0.list_2.Find(new Predicate<Class546>(class.method_0)) == null)
					{
						using (FileStream fileStream = new FileStream(files[i], FileMode.Open))
						{
							using (StreamReader streamReader = new StreamReader(fileStream))
							{
								while (streamReader.Peek() != -1)
								{
									string string_ = streamReader.ReadLine();
									class.class546_0.vmethod_1("Mania", string_);
								}
							}
						}
						class.class546_0.method_1();
						Class885.class547_0.list_2.Add(class.class546_0);
						flag = true;
					}
				}
				if (flag)
				{
					Class885.class547_0.double_0 = 2.4;
					Class885.smethod_20();
				}
			}
			catch
			{
				Class723.smethod_1(Class41.GetString(OsuString.SkinManager_ErrorLoadingConfig), 5000);
			}
		}

		// Token: 0x0600345A RID: 13402
		// RVA: 0x00167B80 File Offset: 0x00165D80
		[Obsolete("Support for migrating keys from mania skins into layouts is only temporary.")]
		private static void smethod_19()
		{
			if (Class466.int_0 < 20150304)
			{
				foreach (Class546 current in Class885.class547_0.list_2)
				{
					current.method_3();
				}
			}
		}

		// Token: 0x06003448 RID: 13384
		// RVA: 0x0002672D File Offset: 0x0002492D
		internal static Class547 smethod_2()
		{
			if (!Class341.class606_65)
			{
				return Class885.class547_0;
			}
			return Class885.class547_1;
		}

		// Token: 0x0600345B RID: 13403
		// RVA: 0x00167BE4 File Offset: 0x00165DE4
		internal static void smethod_20()
		{
			if (Class885.smethod_24())
			{
				Class885.smethod_36();
			}
			using (FileStream fileStream = new FileStream(Path.Combine(Path.Combine("Skins", Class885.class547_0.string_2), "skin.ini"), FileMode.Create))
			{
				using (StreamWriter streamWriter = new StreamWriter(fileStream))
				{
					Class885.class547_0.vmethod_3(streamWriter);
				}
			}
		}

		// Token: 0x0600345C RID: 13404
		// RVA: 0x00167C68 File Offset: 0x00165E68
		internal static Class546 smethod_21(int int_0, Mods mods_0)
		{
			Class885.Class889 class = new Class885.Class889();
			class.int_0 = int_0;
			Class546 class2 = Class885.class547_0.list_2.Find(new Predicate<Class546>(class.method_0));
			if (class2 == null)
			{
				Class546 class3 = new Class546();
				class3.method_7(class.int_0);
				class2 = class3;
				Class885.class547_0.list_2.Add(class2);
			}
			if (class.int_0 <= 1)
			{
				class2.method_5(false);
				class2.nullable_0 = null;
			}
			else
			{
				class2.method_5(class.int_0 >= 10 || (mods_0 & Mods.KeyCoop) > Mods.None);
			}
			return class2;
		}

		// Token: 0x0600345D RID: 13405
		// RVA: 0x00167D04 File Offset: 0x00165F04
		internal static void smethod_22()
		{
			Class885.dictionary_7.Clear();
			foreach (KeyValuePair<string, Color> current in Class885.class547_0.dictionary_1)
			{
				Class885.dictionary_7[current.Key] = current.Value;
			}
		}

		// Token: 0x0600345E RID: 13406
		// RVA: 0x00167D78 File Offset: 0x00165F78
		internal static Color smethod_23(string string_0, bool bool_4)
		{
			Color result;
			if (bool_4 && Class885.dictionary_6.TryGetValue(string_0, out result))
			{
				if (result.get_A() > 0)
				{
					return result;
				}
				return Color.get_TransparentWhite();
			}
			else
			{
				if (Class885.dictionary_7.TryGetValue(string_0, out result) && result.get_A() > 0)
				{
					return result;
				}
				return Color.get_TransparentWhite();
			}
		}

		// Token: 0x0600345F RID: 13407
		// RVA: 0x00026791 File Offset: 0x00024991
		internal static bool smethod_24()
		{
			return Class885.class547_0 != null && Class885.class547_0.string_2 == "Default";
		}

		// Token: 0x06003460 RID: 13408
		// RVA: 0x00167DCC File Offset: 0x00165FCC
		internal static bool smethod_25()
		{
			return Class115.bool_32 && (Class885.smethod_24() || (Class885.class547_0 != null && Class885.class547_0.string_2 == "User") || Class885.class547_0 == null || (Class885.class547_0 != null && Class885.class547_0.double_0 > 1.0));
		}

		// Token: 0x06003462 RID: 13410
		// RVA: 0x00168100 File Offset: 0x00166300
		private static void smethod_26(Class731 class731_1)
		{
			Class531 class530_ = new Class531(class731_1, Enum115.const_15, Origins.TopCentre, Enum114.const_0, new Vector2(-9999f, -9999f))
			{
				bool_0 = true
			};
			Class885.class911_0.Add(class530_);
			if (!Class885.bool_3)
			{
				Class47 arg_58_0 = Class115.class47_0;
				if (Class885.voidDelegate_1 == null)
				{
					Class885.voidDelegate_1 = new VoidDelegate(Class885.smethod_39);
				}
				arg_58_0.Add(Class885.voidDelegate_1, true);
				Class885.bool_3 = true;
			}
		}

		// Token: 0x06003463 RID: 13411
		// RVA: 0x00168170 File Offset: 0x00166370
		internal static Class731[] smethod_27(string string_0, Enum112 enum112_0, bool bool_4)
		{
			Class731[] array;
			if (Class885.dictionary_1.TryGetValue(string_0, out array) && array[0].enum112_0 == enum112_0)
			{
				return array;
			}
			string arg = bool_4 ? "-" : string.Empty;
			Class731 class = Class885.Load(string_0 + arg + 0, enum112_0);
			Class731 class2 = Class885.Load(string_0, enum112_0);
			if (class != null && class == Class885.smethod_28(class, class2))
			{
				List<Class731> list = new List<Class731>();
				int num = 1;
				while (class != null)
				{
					list.Add(class);
					class = Class885.Load(string_0 + arg + num, class.enum112_0);
					num++;
				}
				array = list.ToArray();
				Class885.dictionary_1[string_0] = array;
				return array;
			}
			if (class2 != null)
			{
				array = new Class731[]
				{
					class2
				};
				Class885.dictionary_1[string_0] = array;
				return array;
			}
			return null;
		}

		// Token: 0x06003464 RID: 13412
		// RVA: 0x00168244 File Offset: 0x00166444
		private static Class731 smethod_28(Class731 class731_1, Class731 class731_2)
		{
			if (class731_1 != null && (class731_2 == null || class731_1.enum112_0 == Enum112.flag_3 || (class731_1.enum112_0 == Enum112.flag_2 && class731_2.enum112_0 != Enum112.flag_3) || (class731_1.enum112_0 == Enum112.flag_1 && class731_2.enum112_0 != Enum112.flag_3 && class731_2.enum112_0 != Enum112.flag_2)))
			{
				return class731_1;
			}
			return class731_2;
		}

		// Token: 0x06003465 RID: 13413
		// RVA: 0x000267B0 File Offset: 0x000249B0
		internal static Class731 smethod_29(string string_0, Enum112 enum112_0, bool bool_4)
		{
			return Class885.smethod_28(Class885.Load(string_0, enum112_0), Class885.smethod_27(string_0, enum112_0, bool_4)[0]);
		}

		// Token: 0x06003449 RID: 13385
		// RVA: 0x00026746 File Offset: 0x00024946
		internal static Class545 smethod_3()
		{
			return Class885.class547_0.class545_0;
		}

		// Token: 0x06003466 RID: 13414
		// RVA: 0x000267C8 File Offset: 0x000249C8
		internal static void smethod_30()
		{
			if (Class885.list_0 == null)
			{
				Class885.smethod_6();
			}
		}

		// Token: 0x06003467 RID: 13415
		// RVA: 0x00168290 File Offset: 0x00166490
		internal static void smethod_31()
		{
			if (!Class115.bool_26)
			{
				return;
			}
			Class885.smethod_32(Class885.dictionary_4);
			Class885.smethod_32(Class885.dictionary_3);
			Class885.smethod_32(Class885.dictionary_5);
			List<Class731> arg_48_0 = Class885.list_1;
			if (Class885.action_0 == null)
			{
				Class885.action_0 = new Action<Class731>(Class885.smethod_40);
			}
			arg_48_0.ForEach(Class885.action_0);
			Class885.list_1.Clear();
			Class885.bool_0 = true;
		}

		// Token: 0x06003468 RID: 13416
		// RVA: 0x001682FC File Offset: 0x001664FC
		private static void smethod_32(Dictionary<string, Class731> dictionary_8)
		{
			foreach (KeyValuePair<string, Class731> current in dictionary_8)
			{
				if (current.Value != null && current.Value.method_2() != null)
				{
					current.Value.method_2().Dispose();
					current.Value.method_3(null);
				}
			}
		}

		// Token: 0x06003469 RID: 13417
		// RVA: 0x00168380 File Offset: 0x00166580
		internal static void smethod_33(bool bool_4)
		{
			if ((!Class885.bool_0 || !Class115.bool_26) && !bool_4)
			{
				return;
			}
			Class885.bool_0 = false;
			Class885.dictionary_1.Clear();
			Class885.dictionary_2.Clear();
			Class885.smethod_34(Class885.dictionary_4, bool_4);
			Class885.smethod_34(Class885.dictionary_3, bool_4);
			Class885.smethod_34(Class885.dictionary_5, bool_4);
			Class742.smethod_1();
		}

		// Token: 0x0600346A RID: 13418
		// RVA: 0x001683E0 File Offset: 0x001665E0
		internal static void smethod_34(Dictionary<string, Class731> dictionary_8, bool bool_4)
		{
			if (!Class115.bool_26 && !bool_4)
			{
				return;
			}
			Dictionary<string, Class731> dictionary = new Dictionary<string, Class731>(dictionary_8);
			dictionary_8.Clear();
			foreach (KeyValuePair<string, Class731> current in dictionary)
			{
				if (current.Value == null)
				{
					dictionary_8[current.Key] = null;
				}
				else
				{
					Class731 class = Class885.Load(current.Key, current.Value.enum112_0);
					if (class != null)
					{
						GC.SuppressFinalize(class);
						current.Value.method_3(class.method_2());
						current.Value.class748_0 = class.class748_0;
						current.Value.int_3 = class.int_3;
						current.Value.int_1 = class.int_1;
						current.Value.int_0 = class.int_0;
						current.Value.bool_2 = false;
					}
					else
					{
						current.Value.method_3(null);
						current.Value.class748_0 = null;
					}
					dictionary_8[current.Key] = current.Value;
					Class885.dictionary_2[current.Value.enum112_0][current.Key] = current.Value;
				}
			}
		}

		// Token: 0x0600346C RID: 13420
		// RVA: 0x000267DD File Offset: 0x000249DD
		public static void smethod_35(Class731 class731_1)
		{
			Class885.list_1.Add(class731_1);
		}

		// Token: 0x0600346D RID: 13421
		// RVA: 0x00168550 File Offset: 0x00166750
		internal static void smethod_36()
		{
			if (!Class885.smethod_24())
			{
				return;
			}
			if (!Directory.Exists(Path.Combine("Skins", "User")))
			{
				Directory.CreateDirectory(Path.Combine("Skins", "User"));
			}
			Class341.class605_19.Value = "User";
			Class885.smethod_9(Class341.class605_19, true);
		}

		// Token: 0x0600346E RID: 13422
		// RVA: 0x000267EA File Offset: 0x000249EA
		internal static Color smethod_37()
		{
			return Class885.color_0[Class562.smethod_1(0, 4)];
		}

		// Token: 0x0600346F RID: 13423
		// RVA: 0x00026802 File Offset: 0x00024A02
		[CompilerGenerated]
		private static bool smethod_38(Class546 class546_0)
		{
			return class546_0.dictionary_1.Count > 0;
		}

		// Token: 0x06003470 RID: 13424
		// RVA: 0x00026812 File Offset: 0x00024A12
		[CompilerGenerated]
		private static void smethod_39()
		{
			Class885.class911_0.Draw();
			Class885.class911_0.Clear(true);
			Class885.bool_3 = false;
		}

		// Token: 0x0600344A RID: 13386
		// RVA: 0x00026752 File Offset: 0x00024952
		internal static Enum68 smethod_4()
		{
			if (!Class341.class606_26)
			{
				return Class885.class547_0.enum68_0;
			}
			return Class885.class547_1.enum68_0;
		}

		// Token: 0x06003471 RID: 13425
		// RVA: 0x00026830 File Offset: 0x00024A30
		[CompilerGenerated]
		private static void smethod_40(Class731 class731_1)
		{
			if (!class731_1.method_4() && class731_1.method_2() == null)
			{
				return;
			}
			class731_1.Dispose();
		}

		// Token: 0x0600344B RID: 13387
		// RVA: 0x00166EE4 File Offset: 0x001650E4
		private static void smethod_5()
		{
			if (Class115.bool_27)
			{
				if (Class885.interface17_0 is Class588)
				{
					return;
				}
				if (Class885.interface17_0 != null)
				{
					Class885.interface17_0.Dispose();
				}
				Class588 class = new Class588();
				class.Initialize();
				Class885.interface17_0 = class;
				return;
			}
			else
			{
				switch (Class885.smethod_4())
				{
				case Enum68.const_0:
				{
					if (Class885.interface17_0 is Class584)
					{
						return;
					}
					if (Class885.interface17_0 != null)
					{
						Class885.interface17_0.Dispose();
					}
					Class584 class2 = new Class584();
					class2.method_0(Class115.class125_0.GraphicsDevice, Class115.contentManager_0);
					Class885.interface17_0 = class2;
					return;
				}
				}
				if (Class885.interface17_0 is Class586)
				{
					return;
				}
				if (Class885.interface17_0 != null)
				{
					Class885.interface17_0.Dispose();
				}
				Class586 class3 = new Class586();
				class3.Initialize(Class115.class125_0.GraphicsDevice, Class115.contentManager_0);
				Class885.interface17_0 = class3;
				return;
			}
		}

		// Token: 0x0600344C RID: 13388
		// RVA: 0x00166FC0 File Offset: 0x001651C0
		internal static void smethod_6()
		{
			Class885.list_0 = new List<string>();
			string[] directories = Directory.GetDirectories("Skins");
			string[] array = directories;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				Class885.list_0.Add(text.Replace("Skins" + Path.DirectorySeparatorChar, string.Empty));
			}
			Class885.list_0.Sort();
			Class885.list_0.Insert(0, "Default");
		}

		// Token: 0x0600344D RID: 13389
		// RVA: 0x0016703C File Offset: 0x0016523C
		internal static void smethod_7(string string_0)
		{
			if (Class885.dictionary_0.ContainsKey(string_0))
			{
				Dictionary<string, int> dictionary;
				(dictionary = Class885.dictionary_0)[string_0] = dictionary[string_0] + 1;
				return;
			}
			Class885.dictionary_0[string_0] = 1;
		}

		// Token: 0x0600344E RID: 13390
		// RVA: 0x0016707C File Offset: 0x0016527C
		internal static void smethod_8(string string_0)
		{
			if (Class885.bool_1)
			{
				return;
			}
			int num = 0;
			if (Class885.dictionary_0.TryGetValue(string_0, out num))
			{
				if (num > 1)
				{
					Dictionary<string, int> dictionary;
					(dictionary = Class885.dictionary_0)[string_0] = dictionary[string_0] - 1;
				}
				else
				{
					Class885.dictionary_0.Remove(string_0);
					if (!Class885.dictionary_3.ContainsKey(string_0))
					{
						return;
					}
					Class731 class = Class885.dictionary_3[string_0];
					if (class != null)
					{
						class.Dispose();
						Class885.dictionary_3.Remove(string_0);
						Class885.dictionary_2.Clear();
					}
					return;
				}
			}
		}

		// Token: 0x06003450 RID: 13392
		// RVA: 0x00167108 File Offset: 0x00165308
		internal static bool smethod_9(string string_0, bool bool_4)
		{
			Class885.Class886 class = new Class885.Class886();
			class.string_0 = string_0;
			Class885.smethod_30();
			bool result = true;
			if (class.string_0 == null || Class885.list_0.Find(new Predicate<string>(class.method_0)) == null)
			{
				result = (class.string_0 == null);
				class.string_0 = Class341.class605_19;
			}
			bool flag = false;
			if ((Class115.osuModes_1 == OsuModes.Edit || Class115.bool_25) && Class341.class606_18)
			{
				class.string_0 = "Default";
				flag = true;
			}
			bool flag2 = false;
			if (bool_4 || Class885.class547_0 == null || !class.string_0.Equals(Class885.class547_0.string_2, StringComparison.CurrentCultureIgnoreCase))
			{
				Class885.smethod_15(true);
				Class547 class2 = Class885.smethod_17(class.string_0);
				if (class2 != null)
				{
					flag2 = true;
					Class885.class547_0 = class2;
					if (class.string_0 == Class341.class605_19)
					{
						Class885.class547_1 = Class885.class547_0;
					}
					Class885.smethod_18();
					List<Class546> arg_116_0 = Class885.class547_0.list_2;
					if (Class885.predicate_0 == null)
					{
						Class885.predicate_0 = new Predicate<Class546>(Class885.smethod_38);
					}
					if (arg_116_0.Exists(Class885.predicate_0))
					{
						Class885.smethod_20();
					}
					Class331.smethod_47();
					if (Class115.osuModes_1 != OsuModes.Play)
					{
						if (Class115.osuModes_1 != OsuModes.SkinSelect)
						{
							Class331.smethod_43();
							goto IL_145;
						}
					}
					Class331.smethod_42();
				}
			}
			IL_145:
			Class885.dictionary_6.Clear();
			Class885.smethod_22();
			if (Class341.class606_65 && Class885.class547_0 != Class885.class547_1 && !flag)
			{
				Class547 class3 = Class885.class547_0;
				Class885.class547_0 = Class885.class547_1;
				Class885.smethod_12(true);
				Class885.class547_0 = class3;
			}
			else
			{
				Class885.smethod_12(true);
			}
			if (flag2 && Class885.voidDelegate_0 != null)
			{
				Class885.voidDelegate_0();
			}
			return result;
		}
	}
}
