using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns24;
using ns26;
using ns29;
using ns59;
using ns60;
using ns63;
using ns64;
using ns69;
using ns70;
using ns75;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns82;
using ns85;
using ns89;
using ns90;
using osu;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements;
using osu.GameplayElements.Beatmaps;
using osu.GameplayElements.Events;
using osu.GameplayElements.HitObjects;
using osu.GameplayElements.HitObjects.Osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns23
{
	// Token: 0x02000414 RID: 1044
	internal abstract class Class297 : HitObjectManagerBase, IDisposable
	{
		// Token: 0x02000416 RID: 1046
		[CompilerGenerated]
		private sealed class Class486
		{
			// Token: 0x04001A55 RID: 6741
			public bool bool_0;

			// Token: 0x060021A6 RID: 8614
			// RVA: 0x0001B16A File Offset: 0x0001936A
			public bool method_0(Class702 class702_0)
			{
				return (class702_0.bool_1 && class702_0.bool_2) == this.bool_0;
			}

			// Token: 0x060021A7 RID: 8615
			// RVA: 0x0001B185 File Offset: 0x00019385
			public bool method_1(Class702 class702_0)
			{
				return class702_0.bool_2 == this.bool_0;
			}

			// Token: 0x060021A8 RID: 8616
			// RVA: 0x0001B185 File Offset: 0x00019385
			public bool method_2(Class704 class704_0)
			{
				return class704_0.bool_2 == this.bool_0;
			}
		}

		// Token: 0x02000417 RID: 1047
		[CompilerGenerated]
		private sealed class Class487
		{
			// Token: 0x04001A58 RID: 6744
			public bool bool_0;

			// Token: 0x04001A56 RID: 6742
			public int int_0;

			// Token: 0x04001A57 RID: 6743
			public int int_1;

			// Token: 0x060021AA RID: 8618
			// RVA: 0x0001B195 File Offset: 0x00019395
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime >= this.int_0 && class304_0.EndTime <= this.int_1 && class304_0.IsType(HitObjectType.Slider) && (!this.bool_0 || class304_0.vmethod_9());
			}
		}

		// Token: 0x02000418 RID: 1048
		[CompilerGenerated]
		private sealed class Class488
		{
			// Token: 0x04001A59 RID: 6745
			public Class304 class304_0;

			// Token: 0x060021AC RID: 8620
			// RVA: 0x0001B1CE File Offset: 0x000193CE
			public bool method_0(Class304 class304_1)
			{
				return class304_1.StartTime == this.class304_0.StartTime;
			}
		}

		// Token: 0x02000419 RID: 1049
		[CompilerGenerated]
		private sealed class Class489
		{
			// Token: 0x04001A5C RID: 6748
			public Class304 class304_0;

			// Token: 0x04001A5A RID: 6746
			public int int_0;

			// Token: 0x04001A5B RID: 6747
			public int int_1;

			// Token: 0x060021AE RID: 8622
			// RVA: 0x0001B1E3 File Offset: 0x000193E3
			public bool method_0(Class304 class304_1)
			{
				return class304_1 == this.class304_0;
			}

			// Token: 0x060021AF RID: 8623
			// RVA: 0x0001B1EE File Offset: 0x000193EE
			public bool method_1(Class705 class705_0)
			{
				return class705_0.int_2 > this.int_1 && class705_0.int_0 < this.int_0;
			}
		}

		// Token: 0x02000415 RID: 1045
		// Token: 0x060021A2 RID: 8610
		internal delegate void Delegate34(Enum61 enum61_0, string string_0, Class304 class304_0);

		// Token: 0x04001A4E RID: 6734
		[CompilerGenerated]
		private static Action<Enum38> action_0;

		// Token: 0x04001A50 RID: 6736
		[CompilerGenerated]
		private static Action<Class702> action_1;

		// Token: 0x04001A52 RID: 6738
		[CompilerGenerated]
		private static Action<Class530> action_2;

		// Token: 0x04001A53 RID: 6739
		[CompilerGenerated]
		private static Action<Class530> action_3;

		// Token: 0x04001A54 RID: 6740
		[CompilerGenerated]
		private static Action<Class304> action_4;

		// Token: 0x04001A36 RID: 6710
		internal bool bool_0;

		// Token: 0x04001A3A RID: 6714
		internal bool bool_1;

		// Token: 0x04001A34 RID: 6708
		internal Class296 class296_0;

		// Token: 0x04001A45 RID: 6725
		internal Class304 class304_0;

		// Token: 0x04001A4B RID: 6731
		private Class304 class304_1;

		// Token: 0x04001A48 RID: 6728
		internal Class421 class421_0;

		// Token: 0x04001A41 RID: 6721
		protected internal Class494 class494_0;

		// Token: 0x04001A35 RID: 6709
		internal Class623<Mods> class623_0;

		// Token: 0x04001A40 RID: 6720
		internal Class872 class872_0;

		// Token: 0x04001A46 RID: 6726
		internal Class911 class911_0;

		// Token: 0x04001A4A RID: 6730
		private Class297.Delegate34 delegate34_0;

		// Token: 0x04001A47 RID: 6727
		private Dictionary<string, string> dictionary_0;

		// Token: 0x04001A37 RID: 6711
		internal float float_0;

		// Token: 0x04001A38 RID: 6712
		internal float float_1;

		// Token: 0x04001A2A RID: 6698
		internal static readonly int int_0 = 95;

		// Token: 0x04001A2B RID: 6699
		internal static readonly int int_1 = 78;

		// Token: 0x04001A3C RID: 6716
		public int int_10;

		// Token: 0x04001A3D RID: 6717
		internal int int_11;

		// Token: 0x04001A3E RID: 6718
		internal int int_12;

		// Token: 0x04001A3F RID: 6719
		internal int int_13;

		// Token: 0x04001A43 RID: 6723
		internal int int_14;

		// Token: 0x04001A4D RID: 6733
		private int int_15;

		// Token: 0x04001A2C RID: 6700
		internal static readonly int int_2 = 400;

		// Token: 0x04001A2D RID: 6701
		internal static readonly int int_3 = 240;

		// Token: 0x04001A2E RID: 6702
		internal static readonly int int_4 = 32;

		// Token: 0x04001A2F RID: 6703
		internal static readonly int int_5 = 128;

		// Token: 0x04001A30 RID: 6704
		internal static readonly int int_6 = 800;

		// Token: 0x04001A31 RID: 6705
		internal static readonly int int_7 = 120;

		// Token: 0x04001A32 RID: 6706
		internal static readonly int int_8 = 600;

		// Token: 0x04001A33 RID: 6707
		internal static readonly int int_9 = 500;

		// Token: 0x04001A29 RID: 6697
		internal static List<Class297> list_0 = new List<Class297>();

		// Token: 0x04001A39 RID: 6713
		internal List<int> list_1;

		// Token: 0x04001A3B RID: 6715
		internal List<Color> list_2 = new List<Color>();

		// Token: 0x04001A42 RID: 6722
		internal List<Class304> list_3 = new List<Class304>();

		// Token: 0x04001A44 RID: 6724
		internal List<Class304> list_4 = new List<Class304>();

		// Token: 0x04001A49 RID: 6729
		private List<Class538> list_5 = new List<Class538>();

		// Token: 0x04001A4C RID: 6732
		private List<Class531> list_6 = new List<Class531>();

		// Token: 0x04001A28 RID: 6696
		internal static Matrix matrix_0;

		// Token: 0x04001A4F RID: 6735
		[CompilerGenerated]
		private static Predicate<Class702> predicate_0;

		// Token: 0x04001A51 RID: 6737
		[CompilerGenerated]
		private static Predicate<Class304> predicate_1;

		// Token: 0x06002164 RID: 8548
		// RVA: 0x000C4C8C File Offset: 0x000C2E8C
		internal Class297(bool bool_2)
		{
			if (bool_2)
			{
				this.class911_0 = new Class911(this.vmethod_2())
				{
					bool_6 = false
				};
				this.class911_0.method_15();
				lock (Class297.list_0)
				{
					Class297.list_0.Add(this);
				}
				Class115.smethod_50(new Delegate1(this.method_10));
			}
			if (this.class911_0 != null && Class115.osuModes_1 != OsuModes.Edit)
			{
				this.class911_0.bool_4 = true;
			}
		}

		// Token: 0x06002177 RID: 8567
		// RVA: 0x000C55FC File Offset: 0x000C37FC
		internal virtual void Add(Class304 class304_2, bool bool_2)
		{
			Predicate<Class304> predicate = null;
			Class297.Class488 class = new Class297.Class488();
			class.class304_0 = class304_2;
			if (bool_2)
			{
				List<Class304> arg_29_0 = this.list_4;
				if (predicate == null)
				{
					predicate = new Predicate<Class304>(class.method_0);
				}
				Class304 class2 = arg_29_0.Find(predicate);
				if (class2 != null)
				{
					this.Remove(class2, false);
				}
			}
			int i = this.list_3.BinarySearch(class.class304_0);
			if (i < 0)
			{
				i = ~i;
			}
			if (class.class304_0.NewCombo && i > 0)
			{
				this.list_3[i - 1].LastInCombo = true;
			}
			while (i < this.list_3.Count)
			{
				if (this.list_3[i].StartTime != class.class304_0.StartTime)
				{
					break;
				}
				i++;
			}
			this.list_3.Insert(i, class.class304_0);
			this.class304_1 = class.class304_0;
			if (this.class911_0 != null)
			{
				this.class911_0.Add<Class531>(class.class304_0.list_1);
			}
			this.int_14++;
		}

		// Token: 0x0600215E RID: 8542
		// RVA: 0x0001AFFF File Offset: 0x000191FF
		public override double AdjustDifficulty(double difficulty)
		{
			return (Class297.smethod_10(difficulty, 1.3, this.class623_0) - 5.0) / 5.0;
		}

		// Token: 0x06002171 RID: 8561
		// RVA: 0x000C5250 File Offset: 0x000C3450
		internal void Clear()
		{
			this.int_14 = 0;
			this.list_5.Clear();
			this.class911_0.Clear(true);
			if (this.list_3 != null)
			{
				foreach (Class304 current in this.list_3)
				{
					current.Dispose();
				}
				this.list_3.Clear();
			}
		}

		// Token: 0x06002169 RID: 8553
		// RVA: 0x000C4DBC File Offset: 0x000C2FBC
		internal List<Class304> Clone()
		{
			List<Class304> list = new List<Class304>();
			foreach (Class304 current in this.list_3)
			{
				list.Add(current.Clone());
			}
			return list;
		}

		// Token: 0x06002172 RID: 8562
		// RVA: 0x000C52D4 File Offset: 0x000C34D4
		public virtual void Dispose()
		{
			if (this.class911_0 != null)
			{
				this.class911_0.Dispose();
				Class115.smethod_51(new Delegate1(this.method_10));
				lock (Class297.list_0)
				{
					Class297.list_0.Remove(this);
				}
			}
			foreach (Class304 current in this.list_3)
			{
				current.vmethod_18();
				current.Dispose();
			}
			if (this.class872_0 != null)
			{
				this.class872_0.Dispose();
			}
			this.list_3.Clear();
			this.list_3 = null;
			this.int_14 = 0;
			if (this.dictionary_0 != null)
			{
				this.dictionary_0.Clear();
			}
		}

		// Token: 0x0600218C RID: 8588
		// RVA: 0x0001B0D9 File Offset: 0x000192D9
		internal void Draw()
		{
			this.class911_0.Draw();
		}

		// Token: 0x06002155 RID: 8533
		// RVA: 0x0001AF5C File Offset: 0x0001915C
		public override BeatmapBase GetBeatmap()
		{
			return this.class296_0;
		}

		// Token: 0x06002156 RID: 8534
		// RVA: 0x000C4AF4 File Offset: 0x000C2CF4
		public override List<HitObjectBase> GetHitObjects()
		{
			List<HitObjectBase> list = new List<HitObjectBase>();
			foreach (Class304 current in this.list_3)
			{
				list.Add(current.Clone());
			}
			return list;
		}

		// Token: 0x06002144 RID: 8516
		// RVA: 0x000C09BC File Offset: 0x000BEBBC
		internal bool Load(bool bool_2)
		{
			Class331.smethod_92();
			Class331.smethod_46();
			Class885.dictionary_6.Clear();
			if (bool_2)
			{
				this.class296_0.method_11();
			}
			if (this.class872_0 != null)
			{
				this.class872_0.Dispose();
			}
			this.class872_0 = new Class872(this);
			if (Class115.osuModes_1 != OsuModes.Edit)
			{
				this.class911_0.method_1(true);
				this.class872_0.class911_0.method_1(true);
				this.class872_0.class911_2.method_1(true);
			}
			this.vmethod_8(false, true);
			if (!this.bool_1)
			{
				if (this.list_1 == null)
				{
					this.list_1 = new List<int>();
				}
				else
				{
					this.list_1.Clear();
				}
			}
			this.bool_1 = false;
			this.Clear();
			bool flag;
			if (flag = this.class296_0.bool_4)
			{
				try
				{
					this.method_1(FileSection.All, true);
				}
				catch (Exception ex)
				{
					string str = Class41.GetString(OsuString.HitObjectManager_LoadSave_BeatmapFailLoad);
					if (ex is Exception10)
					{
						str += string.Format(Class41.GetString(OsuString.HitObjectManager_LoadSave_StoryboardErrorOnLine), ((Exception10)ex).int_0);
					}
					if (Class115.osuModes_1 == OsuModes.Edit && DialogResult.Yes != Class723.smethod_8(str + Class41.GetString(OsuString.HitObjectManager_LoadSave_EditAsNewMap), MessageBoxButtons.YesNo, MessageBoxIcon.Hand))
					{
						Class723.smethod_8("osu! will do its best to load what it can of the map...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						this.Clear();
						flag = false;
					}
				}
			}
			this.method_20(false);
			List<Enum38> list = new List<Enum38>();
			foreach (Class340 current in this.class296_0.list_1)
			{
				if (current.enum38_0 > Enum38.const_2 && !list.Contains(current.enum38_0))
				{
					list.Add(current.enum38_0);
				}
			}
			foreach (Class304 current2 in this.list_3)
			{
				if (current2.enum38_0 > Enum38.const_2 && !list.Contains(current2.enum38_0))
				{
					list.Add(current2.enum38_0);
				}
			}
			List<Enum38> arg_22C_0 = list;
			if (Class297.action_0 == null)
			{
				Class297.action_0 = new Action<Enum38>(Class297.smethod_15);
			}
			arg_22C_0.ForEach(Class297.action_0);
			Class331.smethod_42();
			Class331.sampleSet_0 = SampleSet.None;
			if (this.class296_0.int_6 < 4 || !flag)
			{
				Class331.smethod_48(this.class296_0.sampleSet_0, false);
			}
			this.vmethod_18();
			this.class872_0.method_21();
			if (Class115.osuModes_1 != OsuModes.Edit)
			{
				this.class911_0.method_1(false);
				this.class872_0.class911_1.method_1(false);
				this.class872_0.class911_0.method_1(false);
				this.class872_0.class911_2.method_1(false);
			}
			if (Class115.osuModes_1 == OsuModes.Edit || Class62.Mode == PlayModes.Osu)
			{
				Class885.smethod_10(this);
			}
			return flag;
		}

		// Token: 0x0600215F RID: 8543
		// RVA: 0x000C4C10 File Offset: 0x000C2E10
		public override double MapDifficultyRange(double difficulty, double min, double mid, double max)
		{
			difficulty = Class297.smethod_10(difficulty, 1.4, this.class623_0);
			if (difficulty > 5.0)
			{
				return mid + (max - mid) * (difficulty - 5.0) / 5.0;
			}
			if (difficulty < 5.0)
			{
				return mid - (mid - min) * (5.0 - difficulty) / 5.0;
			}
			return mid;
		}

		// Token: 0x06002143 RID: 8515
		// RVA: 0x000C0994 File Offset: 0x000BEB94
		internal bool method_0()
		{
			bool result = this.Load(true);
			this.method_27(false);
			this.class872_0.method_20();
			return result;
		}

		// Token: 0x06002145 RID: 8517
		// RVA: 0x000C0CC0 File Offset: 0x000BEEC0
		internal void method_1(FileSection fileSection_0, bool bool_2)
		{
			FileSection fileSection = FileSection.Unknown;
			if (bool_2)
			{
				this.class296_0.method_66();
			}
			List<string> list = new List<string>();
			list.Add(this.class296_0.string_9);
			string text = this.class296_0.method_43();
			if (this.class296_0.method_68(text))
			{
				list.Add(text);
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = Class115.osuModes_1 == OsuModes.Play && Class876.smethod_6(this.class623_0, Mods.HardRock);
			this.dictionary_0 = new Dictionary<string, string>();
			for (int i = 0; i < list.Count; i++)
			{
				using (TextReader textReader = new StreamReader(this.class296_0.method_62(list[i])))
				{
					int num = 0;
					string text2 = null;
					bool flag4 = true;
					while (true)
					{
						if (flag4)
						{
							text2 = textReader.ReadLine();
							if (text2 == null)
							{
								goto IL_1A6F;
							}
							num++;
						}
						flag4 = true;
						if (text2.Length != 0 && !text2.StartsWith(" ") && !text2.StartsWith("_") && !text2.StartsWith("//"))
						{
							try
							{
								if (fileSection == FileSection.Events)
								{
									this.method_2(ref text2);
								}
							}
							catch (Exception exception_)
							{
								throw new Exception10(num, exception_);
							}
							if (text2[0] == '[')
							{
								try
								{
									fileSection = (FileSection)Enum.Parse(typeof(FileSection), text2.Trim(new char[]
									{
										'[',
										']'
									}));
									continue;
								}
								catch (Exception)
								{
									continue;
								}
							}
							if ((fileSection_0 & fileSection) > FileSection.Unknown)
							{
								string[] array = text2.Trim().Split(new char[]
								{
									','
								});
								string[] array2 = text2.Trim().Split(new char[]
								{
									':'
								});
								string text3 = string.Empty;
								string text4 = string.Empty;
								if (array2.Length > 1)
								{
									text3 = array2[0].Trim();
									text4 = array2[1].Trim();
								}
								FileSection fileSection2 = fileSection;
								if (fileSection2 <= FileSection.Events)
								{
									string text5;
									switch (fileSection2)
									{
									case FileSection.General:
										break;
									case FileSection.Colours:
										if (!flag)
										{
											flag = true;
											for (int j = 1; j <= 8; j++)
											{
												Class885.dictionary_6["Combo" + j.ToString()] = Color.get_TransparentWhite();
											}
										}
										if ((!this.class296_0.bool_23 && !Class341.class606_32) || Class115.osuModes_1 == OsuModes.Edit)
										{
											string[] array3 = text4.Split(new char[]
											{
												','
											});
											Class885.dictionary_6[text3] = new Color((byte)Convert.ToInt32(array3[0]), (byte)Convert.ToInt32(array3[1]), (byte)Convert.ToInt32(array3[2]));
											continue;
										}
										continue;
									case (FileSection)3:
										continue;
									case FileSection.Editor:
										if ((Class115.osuModes_1 != OsuModes.Edit && !Class115.bool_25) || (text5 = text3) == null)
										{
											continue;
										}
										if (text5 == "Bookmarks")
										{
											string[] array4 = text4.Split(new char[]
											{
												','
											});
											string[] array5 = array4;
											for (int k = 0; k < array5.Length; k++)
											{
												string text6 = array5[k];
												if (text6.Length > 0)
												{
													int item = int.Parse(text6);
													if (!this.list_1.Contains(item))
													{
														this.list_1.Add(item);
													}
												}
											}
											continue;
										}
										if (text5 == "DistanceSpacing")
										{
											Class341.class607_2.Value = Convert.ToDouble(text4, Class115.numberFormatInfo_0);
											continue;
										}
										if (text5 == "BeatDivisor")
										{
											Class341.class608_2.Value = Convert.ToInt32(text4, Class115.numberFormatInfo_0);
											continue;
										}
										if (text5 == "GridSize")
										{
											Class341.class608_3.Value = Convert.ToInt32(text4, Class115.numberFormatInfo_0);
											continue;
										}
										if (text5 == "TimelineZoom")
										{
											this.class296_0.float_2 = (float)Convert.ToDecimal(text4, Class115.numberFormatInfo_0);
											continue;
										}
										continue;
									default:
										if (fileSection2 != FileSection.Events)
										{
											continue;
										}
										try
										{
											Class702 class = null;
											EventTypes eventTypes;
											try
											{
												eventTypes = (EventTypes)Enum.Parse(typeof(EventTypes), array[0]);
											}
											catch
											{
												MessageBox.Show(string.Format(Class41.GetString(OsuString.HitObjectManager_LoadSave_StoryboardErrorOnLine_2), list[i], num, text2) + Class41.GetString(OsuString.HitObjectManager_LoadSave_StoryboardErrorContent_1));
												continue;
											}
											switch (eventTypes)
											{
											case EventTypes.Background:
											case EventTypes.Video:
												class = this.class872_0.Add(array[2].Trim(new char[]
												{
													'"'
												}), int.Parse(array[1], Class115.numberFormatInfo_0) + this.class296_0.int_17);
												if (class != null)
												{
													if (class.class531_0 != null && array.Length > 4)
													{
														Vector2 vector;
														vector..ctor((float)int.Parse(array[3]), (float)int.Parse(array[4]));
														if (vector != Vector2.get_One())
														{
															class.class531_0.vector2_1 = vector;
														}
													}
													class.int_1 = num;
													class.bool_2 = (i == 0);
												}
												break;
											case EventTypes.Break:
												if (i > 0)
												{
													continue;
												}
												class = new Class705(int.Parse(array[1], Class115.numberFormatInfo_0) + this.class296_0.int_17, int.Parse(array[2], Class115.numberFormatInfo_0) + this.class296_0.int_17);
												class.int_1 = num;
												class.bool_2 = true;
												if (class.Length > 650)
												{
													this.class872_0.Add(class);
												}
												break;
											case EventTypes.Sprite:
												try
												{
													class = new Class706(Class34.smethod_22(array[3]), new Vector2((float)int.Parse(array[4]), (float)int.Parse(array[5])), (Origins)Enum.Parse(typeof(Origins), array[2]), (StoryLayer)Enum.Parse(typeof(StoryLayer), array[1]), this.class296_0.bool_15);
													class.int_1 = num;
													class.bool_2 = (i == 0);
												}
												catch (Exception)
												{
													continue;
												}
												this.class872_0.Add(class);
												break;
											case EventTypes.Sample:
												try
												{
													string text7 = Class34.smethod_22(array[3]);
													int num2 = Class331.smethod_38(text7, false, true, false);
													class = new Class704(num2, text7, int.Parse(array[1], Class115.numberFormatInfo_0) + this.class296_0.int_17, (StoryLayer)Enum.Parse(typeof(StoryLayer), array[2]), (array.Length > 4) ? Math.Min(100, Math.Max(0, int.Parse(array[4], Class115.numberFormatInfo_0))) : 100);
													class.int_1 = num;
													class.bool_2 = (i == 0);
												}
												catch
												{
												}
												this.class872_0.Add(class);
												break;
											case EventTypes.Animation:
												try
												{
													class = new Class703(Class34.smethod_22(array[3]), new Vector2((float)int.Parse(array[4]), (float)int.Parse(array[5])), (Origins)Enum.Parse(typeof(Origins), array[2]), (StoryLayer)Enum.Parse(typeof(StoryLayer), array[1]), int.Parse(array[6]), double.Parse(array[7], Class115.numberFormatInfo_0), this.class296_0.bool_15, (LoopTypes)((array.Length > 8) ? Enum.Parse(typeof(LoopTypes), array[8]) : LoopTypes.LoopForever));
													class.int_1 = num;
													class.bool_2 = (i == 0);
												}
												catch
												{
													continue;
												}
												this.class872_0.Add(class);
												break;
											}
											text2 = textReader.ReadLine();
											if (text2 == null)
											{
												continue;
											}
											this.method_2(ref text2);
											num++;
											Class743 class2 = null;
											bool flag5 = false;
											while (text2.Trim().Length > 0)
											{
												if (text2[0] != ' ' && text2[0] != '_')
												{
													break;
												}
												try
												{
													if (!Class872.smethod_0())
													{
														EventTypes eventTypes2 = eventTypes;
														if (eventTypes2 != EventTypes.Video)
														{
															switch (eventTypes2)
															{
															case EventTypes.Sprite:
															case EventTypes.Animation:
																goto IL_60B;
															}
															continue;
														}
													}
													IL_60B:
													array = text2.Trim(new char[]
													{
														' ',
														'_'
													}).Split(new char[]
													{
														','
													});
													int l = 1;
													int num3 = array.Length;
													if (text2[1] != ' ' && text2[1] != '_')
													{
														class2 = null;
													}
													Enum70 enum70_ = Enum70.const_0;
													int num4 = 0;
													int num5 = 0;
													int num6 = 0;
													if ((text5 = array[0]) == null || (!(text5 == "L") && !(text5 == "T")))
													{
														enum70_ = (Enum70)int.Parse(array[l++]);
														num4 = int.Parse(array[l++]) + this.class296_0.int_17;
														if (array[l].Length == 0)
														{
															num5 = num4;
															l++;
														}
														else
														{
															num5 = int.Parse(array[l++]) + this.class296_0.int_17;
														}
														num6 = num5 - num4;
													}
													if (num5 > this.class872_0.int_0)
													{
														this.class872_0.int_0 = num5;
													}
													if (num4 < this.class872_0.int_1)
													{
														this.class872_0.int_1 = num4;
													}
													bool flag6 = true;
													int num7 = -1;
													while (l < num3)
													{
														if (num7 == l)
														{
															break;
														}
														num7 = l;
														Class746 class3 = null;
														switch (text5 = array[0])
														{
														case "M":
														{
															l -= (flag6 ? 0 : 2);
															bool flag7 = l == num3 - 2;
															Vector2 vector2;
															vector2..ctor(float.Parse(array[l++], Class115.numberFormatInfo_0), float.Parse(array[l++], Class115.numberFormatInfo_0));
															Vector2 vector2_ = flag7 ? vector2 : new Vector2(float.Parse(array[l++], Class115.numberFormatInfo_0), float.Parse(array[l++], Class115.numberFormatInfo_0));
															class3 = new Class746(vector2, vector2_, num4, num5, Enum70.const_0);
															break;
														}
														case "MX":
														{
															l -= (flag6 ? 0 : 1);
															bool flag8 = l == num3 - 1;
															float num9 = float.Parse(array[l++], Class115.numberFormatInfo_0);
															float float_ = flag8 ? num9 : float.Parse(array[l++], Class115.numberFormatInfo_0);
															class3 = new Class746(TransformationType.MovementX, num9, float_, num4, num5, Enum70.const_0);
															break;
														}
														case "MY":
														{
															l -= (flag6 ? 0 : 1);
															bool flag9 = l == num3 - 1;
															float num10 = float.Parse(array[l++], Class115.numberFormatInfo_0);
															float float_2 = flag9 ? num10 : float.Parse(array[l++], Class115.numberFormatInfo_0);
															class3 = new Class746(TransformationType.MovementY, num10, float_2, num4, num5, Enum70.const_0);
															break;
														}
														case "F":
														{
															l -= (flag6 ? 0 : 1);
															bool flag10 = l == num3 - 1;
															float num11 = float.Parse(array[l++], Class115.numberFormatInfo_0);
															float float_3 = flag10 ? num11 : float.Parse(array[l++], Class115.numberFormatInfo_0);
															class3 = new Class746(TransformationType.Fade, num11, float_3, num4, num5, Enum70.const_0);
															break;
														}
														case "R":
														{
															l -= (flag6 ? 0 : 1);
															bool flag11 = l == num3 - 1;
															float num12 = float.Parse(array[l++], Class115.numberFormatInfo_0);
															float float_4 = flag11 ? num12 : float.Parse(array[l++], Class115.numberFormatInfo_0);
															class3 = new Class746(TransformationType.Rotation, num12, float_4, num4, num5, Enum70.const_0);
															break;
														}
														case "S":
														{
															l -= (flag6 ? 0 : 1);
															bool flag12 = l == num3 - 1;
															float num13 = float.Parse(array[l++], Class115.numberFormatInfo_0);
															float float_5 = flag12 ? num13 : float.Parse(array[l++], Class115.numberFormatInfo_0);
															class3 = new Class746(TransformationType.Scale, num13, float_5, num4, num5, Enum70.const_0);
															break;
														}
														case "V":
														{
															l -= (flag6 ? 0 : 1);
															bool flag13 = l == num3 - 2;
															Vector2 vector3;
															vector3..ctor(float.Parse(array[l++], Class115.numberFormatInfo_0), float.Parse(array[l++], Class115.numberFormatInfo_0));
															Vector2 vector2_2 = flag13 ? vector3 : new Vector2(float.Parse(array[l++], Class115.numberFormatInfo_0), float.Parse(array[l++], Class115.numberFormatInfo_0));
															class3 = new Class746(TransformationType.VectorScale, vector3, vector2_2, num4, num5, Enum70.const_0);
															break;
														}
														case "C":
														{
															l -= (flag6 ? 0 : 3);
															bool flag14 = l == num3 - 3;
															Color color;
															color..ctor(byte.Parse(array[l++]), byte.Parse(array[l++]), byte.Parse(array[l++]));
															Color color_ = flag14 ? color : new Color(byte.Parse(array[l++]), byte.Parse(array[l++]), byte.Parse(array[l++]));
															class3 = new Class746(color, color_, num4, num5);
															break;
														}
														case "P":
															l -= (flag6 ? 0 : 3);
															class3 = new Class746();
															class3.int_0 = num4;
															class3.int_1 = num5;
															if ((text5 = array[l++]) != null)
															{
																if (!(text5 == "H"))
																{
																	if (!(text5 == "V"))
																	{
																		if (text5 == "A")
																		{
																			if (class.class531_0 != null && class3.method_0() == 0)
																			{
																				class.class531_0.bool_7 = true;
																			}
																			class3.transformationType_0 = TransformationType.ParameterAdditive;
																		}
																	}
																	else
																	{
																		if (class.class531_0 != null && class3.method_0() == 0)
																		{
																			class.class531_0.method_43(true);
																		}
																		class3.transformationType_0 = TransformationType.ParameterFlipVertical;
																	}
																}
																else
																{
																	if (class.class531_0 != null && class3.method_0() == 0)
																	{
																		class.class531_0.method_45(true);
																	}
																	class3.transformationType_0 = TransformationType.ParameterFlipHorizontal;
																}
															}
															break;
														case "L":
															class2 = new Class743(int.Parse(array[l++]) + this.class296_0.int_17, int.Parse(array[l++]));
															if (class != null)
															{
																if (class.class531_0.list_0 == null)
																{
																	class.class531_0.list_0 = new List<Class743>();
																}
																class.class531_0.list_0.Add(class2);
															}
															break;
														case "T":
														{
															Class477 class4 = Class477.Create(array[l++]);
															if (array.Length > 2)
															{
																num4 = int.Parse(array[l++]) + this.class296_0.int_17;
																num5 = int.Parse(array[l++]) + this.class296_0.int_17;
															}
															if (array.Length > 4)
															{
																TriggerGroup triggerGroup = (TriggerGroup)(-(TriggerGroup)int.Parse(array[l++]));
																if (triggerGroup != TriggerGroup.None)
																{
																	class4.method_3(triggerGroup);
																}
															}
															class2 = new Class744(class4, num4, num5);
															if (class != null)
															{
																class.method_0(class2 as Class744);
															}
															break;
														}
														}
														if (class3 != null)
														{
															class3.enum70_0 = enum70_;
															if (class2 != null)
															{
																class2.class26_0.method_0(class3);
																if (!flag5 || class2.int_1 < class.int_2)
																{
																	class.int_2 = class2.int_1;
																	flag5 = true;
																}
															}
															else if (class != null)
															{
																class.class531_0.class26_0.method_0(class3);
																if (!flag5 || num4 < class.int_2)
																{
																	class.int_2 = num4;
																	flag5 = true;
																}
															}
														}
														num4 += num6;
														num5 += num6;
														flag6 = false;
													}
												}
												catch (Exception ex)
												{
													MessageBox.Show(string.Format(Class41.GetString(OsuString.HitObjectManager_LoadSave_StoryboardErrorOnLine_2) + "\n\n" + ex.Message, list[i], num, text2));
												}
												finally
												{
													text2 = textReader.ReadLine();
													this.method_2(ref text2);
													num++;
												}
											}
											if (class != null && class.class531_0 != null && this.class872_0.class911_0.bool_4 && class.eventTypes_0 != EventTypes.Background && class.eventTypes_0 != EventTypes.Video)
											{
												class.class531_0.method_10();
												if (class.storyLayer_0 == StoryLayer.Background)
												{
													this.class872_0.class911_0.Add(class.class531_0);
												}
												else
												{
													this.class872_0.class911_2.Add(class.class531_0);
												}
											}
											flag4 = false;
											continue;
										}
										catch (Exception exception_2)
										{
											throw new Exception10(num, exception_2);
										}
										break;
									}
									if ((text5 = text3) != null)
									{
										if (!(text5 == "EditorBookmarks"))
										{
											if (!(text5 == "EditorDistanceSpacing"))
											{
												if (!(text5 == "StoryFireInFront"))
												{
													if (text5 == "UseSkinSprites")
													{
														this.class296_0.bool_15 = (text4[0] == '1');
													}
												}
												else
												{
													this.class296_0.bool_14 = (text4[0] == '1');
												}
											}
											else
											{
												Class341.class607_2.Value = Convert.ToDouble(text4, Class115.numberFormatInfo_0);
											}
										}
										else
										{
											string[] array6 = text4.Split(new char[]
											{
												','
											});
											string[] array5 = array6;
											for (int k = 0; k < array5.Length; k++)
											{
												string text8 = array5[k];
												if (text8.Length > 0)
												{
													int item2 = int.Parse(text8);
													if (!this.list_1.Contains(item2))
													{
														this.list_1.Add(item2);
													}
												}
											}
										}
									}
								}
								else if (fileSection2 != FileSection.HitObjects)
								{
									if (fileSection2 == FileSection.Variables)
									{
										string[] array7 = text2.Split(new char[]
										{
											'='
										});
										if (array7.Length == 2)
										{
											this.dictionary_0.Add(array7[0], array7[1]);
										}
									}
								}
								else if (i <= 0)
								{
									if (!flag2)
									{
										this.vmethod_0(false);
										flag2 = true;
									}
									HitObjectType type = (HitObjectType)(int.Parse(array[3], Class115.numberFormatInfo_0) & -113);
									HitObjectSoundType hitObjectSoundType = (HitObjectSoundType)int.Parse(array[4], Class115.numberFormatInfo_0);
									int num14 = (int)Math.Max(0m, Math.Min(512m, decimal.Parse(array[0], Class115.numberFormatInfo_0)));
									int num15 = (int)Math.Max(0m, Math.Min(512m, decimal.Parse(array[1], Class115.numberFormatInfo_0)));
									Vector2 vector2_3;
									vector2_3..ctor((float)num14, (float)(flag3 ? (384 - num15) : num15));
									int num16 = (int)decimal.Parse(array[2], Class115.numberFormatInfo_0) + this.class296_0.int_17;
									int num17 = Convert.ToInt32(array[3], Class115.numberFormatInfo_0) >> 4 & 7;
									bool flag15 = type.IsType(HitObjectType.NewCombo);
									SampleSet sampleSet_ = SampleSet.None;
									SampleSet sampleSet_2 = SampleSet.None;
									Enum38 enum38_ = Enum38.const_0;
									string string_ = string.Empty;
									int num18 = 0;
									if (type.IsType(HitObjectType.Normal))
									{
										if (array.Length > 5 && array[5].Length > 0)
										{
											string[] array8 = array[5].Split(new char[]
											{
												':'
											});
											sampleSet_ = (SampleSet)Convert.ToInt32(array8[0]);
											sampleSet_2 = (SampleSet)Convert.ToInt32(array8[1]);
											enum38_ = (Enum38)((array8.Length > 2) ? Convert.ToInt32(array8[2]) : 0);
											num18 = ((array8.Length > 3) ? int.Parse(array8[3]) : 0);
											string_ = ((array8.Length > 4) ? array8[4] : string.Empty);
										}
										Class305 class305_ = this.class494_0.vmethod_0(vector2_3, num16, this.method_6() | flag15, hitObjectSoundType, flag15 ? num17 : 0, sampleSet_, sampleSet_2, enum38_, num18, string_);
										this.vmethod_19(class305_);
									}
									else if (type.IsType(HitObjectType.Slider))
									{
										CurveTypes curveTypes_ = CurveTypes.Catmull;
										double double_ = 0.0;
										List<Vector2> list2 = new List<Vector2>();
										List<HitObjectSoundType> list3 = null;
										string[] array9 = array[5].Split(new char[]
										{
											'|'
										});
										for (int m = 0; m < array9.Length; m++)
										{
											if (array9[m].Length == 1)
											{
												string text5;
												if ((text5 = array9[m]) != null)
												{
													if (!(text5 == "C"))
													{
														if (!(text5 == "B"))
														{
															if (!(text5 == "L"))
															{
																if (text5 == "P")
																{
																	curveTypes_ = CurveTypes.PerfectCurve;
																}
															}
															else
															{
																curveTypes_ = CurveTypes.Linear;
															}
														}
														else
														{
															curveTypes_ = CurveTypes.Bezier;
														}
													}
													else
													{
														curveTypes_ = CurveTypes.Catmull;
													}
												}
											}
											else
											{
												string[] array10 = array9[m].Split(new char[]
												{
													':'
												});
												Vector2 item3;
												item3..ctor((float)((int)Convert.ToDouble(array10[0], Class115.numberFormatInfo_0)), (float)((int)(flag3 ? (384.0 - Convert.ToDouble(array10[1], Class115.numberFormatInfo_0)) : Convert.ToDouble(array10[1], Class115.numberFormatInfo_0))));
												list2.Add(item3);
											}
										}
										int num19 = Convert.ToInt32(array[6], Class115.numberFormatInfo_0);
										if (num19 > 9000)
										{
											break;
										}
										if (array.Length > 7)
										{
											double_ = Convert.ToDouble(array[7], Class115.numberFormatInfo_0);
										}
										if (array.Length > 8 && array[8].Length > 0)
										{
											string[] array11 = array[8].Split(new char[]
											{
												'|'
											});
											if (array11.Length > 0)
											{
												list3 = new List<HitObjectSoundType>();
												int num20 = Math.Min(array11.Length, num19 + 1);
												int n;
												for (n = 0; n < num20; n++)
												{
													int item4;
													int.TryParse(array11[n], out item4);
													list3.Add((HitObjectSoundType)item4);
												}
												while (n < num19 + 1)
												{
													list3.Add(hitObjectSoundType);
													n++;
												}
											}
										}
										List<SampleSet> list4 = new List<SampleSet>();
										List<SampleSet> list5 = new List<SampleSet>();
										if (array.Length > 9 && array[9].Length > 0)
										{
											string[] array12 = array[9].Split(new char[]
											{
												'|'
											});
											if (array12.Length > 0)
											{
												string[] array5 = array12;
												for (int k = 0; k < array5.Length; k++)
												{
													string text9 = array5[k];
													string[] array13 = text9.Split(new char[]
													{
														':'
													});
													list4.Add((SampleSet)Convert.ToInt32(array13[0]));
													list5.Add((SampleSet)Convert.ToInt32(array13[1]));
												}
											}
										}
										if (list3 != null)
										{
											if (list4.Count > num19 + 1)
											{
												list4.RemoveRange(num19 + 1, list4.Count - num19 - 1);
											}
											else
											{
												for (int num21 = list4.Count; num21 <= num19; num21++)
												{
													list4.Add(SampleSet.None);
												}
											}
											if (list5.Count > num19 + 1)
											{
												list5.RemoveRange(num19 + 1, list5.Count - num19 - 1);
											}
											else
											{
												for (int num22 = list5.Count; num22 <= num19; num22++)
												{
													list5.Add(SampleSet.None);
												}
											}
										}
										if (array.Length > 10)
										{
											string[] array14 = array[10].Split(new char[]
											{
												':'
											});
											sampleSet_ = (SampleSet)Convert.ToInt32(array14[0]);
											sampleSet_2 = (SampleSet)Convert.ToInt32(array14[1]);
											enum38_ = (Enum38)((array14.Length > 2) ? Convert.ToInt32(array14[2]) : 0);
											num18 = ((array14.Length > 3) ? int.Parse(array14[3]) : 0);
											string_ = ((array14.Length > 4) ? array14[4] : string.Empty);
										}
										Class320 class320_ = this.class494_0.vmethod_1(vector2_3, num16, this.method_6() || flag15, hitObjectSoundType, curveTypes_, num19, double_, list2, list3, flag15 ? num17 : 0, sampleSet_, sampleSet_2, list4, list5, enum38_, num18, string_);
										this.vmethod_21(class320_);
									}
									else if (type.IsType(HitObjectType.Spinner))
									{
										if (array.Length > 6)
										{
											string[] array15 = array[6].Split(new char[]
											{
												':'
											});
											sampleSet_ = (SampleSet)Convert.ToInt32(array15[0]);
											sampleSet_2 = (SampleSet)Convert.ToInt32(array15[1]);
											enum38_ = (Enum38)((array15.Length > 2) ? Convert.ToInt32(array15[2]) : 0);
											num18 = ((array15.Length > 3) ? int.Parse(array15[3]) : 0);
											string_ = ((array15.Length > 4) ? array15[4] : string.Empty);
										}
										Class325 class5 = this.class494_0.vmethod_2(num16, Math.Min(Class331.smethod_31() - 50, Convert.ToInt32(array[5], Class115.numberFormatInfo_0)) + this.class296_0.int_17, hitObjectSoundType, sampleSet_, sampleSet_2, enum38_, num18, string_);
										class5.NewCombo = type.IsType(HitObjectType.NewCombo);
										this.vmethod_20(class5);
									}
									else if (type.IsType(HitObjectType.Hold))
									{
										int num23 = num16;
										if (array.Length > 5 && array[5].Length > 0)
										{
											string[] array16 = array[5].Split(new char[]
											{
												':'
											});
											num23 = Convert.ToInt32(array16[0]);
											if (array16.Length > 1)
											{
												sampleSet_ = (SampleSet)Convert.ToInt32(array16[1]);
												sampleSet_2 = (SampleSet)Convert.ToInt32(array16[2]);
											}
											if (array16.Length > 3)
											{
												enum38_ = (Enum38)Convert.ToInt32(array16[3]);
											}
											num18 = ((array16.Length > 4) ? int.Parse(array16[4]) : 0);
											string_ = ((array16.Length > 5) ? array16[5] : string.Empty);
										}
										Class305 class6 = this.class494_0.vmethod_3(vector2_3, num16, num23, this.method_6() || flag15, hitObjectSoundType, flag15 ? num17 : 0, sampleSet_, sampleSet_2, enum38_, num18, string_);
										if (class6 != null)
										{
											this.vmethod_19(class6);
										}
									}
								}
							}
						}
					}
					throw new ArgumentOutOfRangeException(Class41.GetString(OsuString.HitObjectManager_LoadSave_ErrorTooManyRepeats));
					IL_1A6F:;
				}
				if (!flag2)
				{
					this.vmethod_0(false);
				}
			}
		}

		// Token: 0x06002165 RID: 8549
		// RVA: 0x000C4D5C File Offset: 0x000C2F5C
		private void method_10(bool bool_2)
		{
			foreach (Class304 current in this.list_3)
			{
				Class321 class = current as Class321;
				if (class != null)
				{
					class.method_10();
				}
			}
		}

		// Token: 0x0600216B RID: 8555
		// RVA: 0x000C5024 File Offset: 0x000C3224
		internal void method_11(bool bool_2, bool bool_3)
		{
			Class297.Class487 class = new Class297.Class487();
			class.bool_0 = bool_2;
			class.int_0 = (int)Class331.smethod_12();
			class.int_1 = (int)((Class331.smethod_14().Count - 1 > Class331.int_1) ? Class331.smethod_14()[Class331.int_1 + 1].double_1 : ((double)Class331.smethod_31()));
			if (this.list_3 == null)
			{
				return;
			}
			List<Class304> list = this.list_3.FindAll(new Predicate<Class304>(class.method_0));
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				Class321 class2 = (Class321)list[i];
				if (bool_3)
				{
					class2.SpatialLength = 0.0;
				}
				class2.vmethod_24(true);
			}
		}

		// Token: 0x0600216C RID: 8556
		// RVA: 0x000C50E4 File Offset: 0x000C32E4
		internal void method_12(bool bool_2)
		{
			if (this.list_3 == null)
			{
				return;
			}
			List<Class304> arg_2C_0 = this.list_3;
			if (Class297.predicate_1 == null)
			{
				Class297.predicate_1 = new Predicate<Class304>(Class297.smethod_18);
			}
			List<Class304> list = arg_2C_0.FindAll(Class297.predicate_1);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				Class321 class = (Class321)list[i];
				if (bool_2)
				{
					class.SpatialLength = 0.0;
				}
				class.vmethod_24(true);
			}
		}

		// Token: 0x0600216E RID: 8558
		// RVA: 0x000C51E0 File Offset: 0x000C33E0
		internal void method_13(Class297.Delegate34 delegate34_1)
		{
			Class297.Delegate34 delegate = this.delegate34_0;
			Class297.Delegate34 delegate2;
			do
			{
				delegate2 = delegate;
				Class297.Delegate34 value = (Class297.Delegate34)Delegate.Combine(delegate2, delegate34_1);
				delegate = Interlocked.CompareExchange<Class297.Delegate34>(ref this.delegate34_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600216F RID: 8559
		// RVA: 0x000C5218 File Offset: 0x000C3418
		internal void method_14(Class297.Delegate34 delegate34_1)
		{
			Class297.Delegate34 delegate = this.delegate34_0;
			Class297.Delegate34 delegate2;
			do
			{
				delegate2 = delegate;
				Class297.Delegate34 value = (Class297.Delegate34)Delegate.Remove(delegate2, delegate34_1);
				delegate = Interlocked.CompareExchange<Class297.Delegate34>(ref this.delegate34_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002170 RID: 8560
		// RVA: 0x0001B097 File Offset: 0x00019297
		protected void method_15(Enum61 enum61_0, string string_0, Class304 class304_2)
		{
			if (this.delegate34_0 != null)
			{
				this.delegate34_0(enum61_0, string_0, class304_2);
			}
		}

		// Token: 0x06002173 RID: 8563
		// RVA: 0x000C53C0 File Offset: 0x000C35C0
		internal Class304 method_16(int int_16, int int_17, float float_2, bool bool_2, Predicate<Class304> predicate_2)
		{
			if (this.list_4.Count == 0)
			{
				return null;
			}
			Vector2 vector;
			vector..ctor((float)int_16, (float)int_17);
			Class304 class = null;
			int num = 0;
			foreach (Class304 current in this.list_4)
			{
				if ((predicate_2 != null || current.vmethod_9()) && (predicate_2 == null || predicate_2(current)))
				{
					int num2 = Math.Min(Math.Abs(current.StartTime - Class331.int_7), Math.Abs(current.EndTime - Class331.int_7));
					if ((Vector2.DistanceSquared(vector, bool_2 ? current.vector2_0 : current.Position) < float_2 * float_2 || Vector2.DistanceSquared(vector, bool_2 ? current.method_1() : current.vmethod_10()) < float_2 * float_2) && (class == null || num2 < num))
					{
						class = current;
						num = num2;
					}
					if (current.IsType(HitObjectType.Slider) && class == null)
					{
						Class321 class2 = current as Class321;
						if (class2.list_4 != null)
						{
							foreach (Class880 current2 in class2.list_4)
							{
								Vector2 vector2 = current2.vector2_0;
								if (bool_2)
								{
									vector2 -= class2.Position - class2.vector2_0;
								}
								if (Vector2.Distance(vector, vector2) < float_2)
								{
									class = current;
									num = num2;
									break;
								}
							}
						}
					}
				}
			}
			return class;
		}

		// Token: 0x06002174 RID: 8564
		// RVA: 0x0001B0AF File Offset: 0x000192AF
		internal Class304 method_17(float float_2, float float_3, bool bool_2)
		{
			return this.method_18(float_2, float_3, bool_2, this.HitObjectRadius);
		}

		// Token: 0x06002175 RID: 8565
		// RVA: 0x000C5578 File Offset: 0x000C3778
		internal Class304 method_18(float float_2, float float_3, bool bool_2, float float_4)
		{
			bool flag = !Class802.smethod_0() && bool_2;
			Vector2 vector2_;
			vector2_..ctor(float_2, float_3);
			foreach (Class304 current in this.list_4)
			{
				if ((!flag || current.bool_5) && current.vmethod_20(vector2_, bool_2, float_4))
				{
					return current;
				}
			}
			return null;
		}

		// Token: 0x06002179 RID: 8569
		// RVA: 0x000C624C File Offset: 0x000C444C
		private IEnumerable<Class531> method_19(Class731 class731_0, int int_16)
		{
			List<Class531> list = new List<Class531>(int_16);
			int num = Math.Min(this.list_6.Count, 1000);
			int num2 = 0;
			int num3 = 0;
			while (num3 < num && num2 < int_16)
			{
				this.int_15 = (this.int_15 + 1) % num;
				Class531 class = this.list_6[this.int_15];
				if (class.class26_0[1].int_1 < Class331.int_7)
				{
					class.vmethod_7(class731_0);
					class.bool_3 = true;
					list.Add(class);
					num2++;
				}
				num3++;
			}
			while (num2++ < int_16 && this.list_6.Count < 1000)
			{
				Class531 class2 = new Class531(class731_0, Enum115.const_0, Origins.Centre, Enum114.const_2, Vector2.get_Zero(), 0f, false, Color.get_White(), null)
				{
					bool_7 = true
				};
				class2.class26_0.Add(new Class746(Vector2.get_Zero(), Vector2.get_Zero(), 0, 0, Enum70.const_0));
				class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, 0, 0, Enum70.const_0));
				this.list_6.Add(class2);
				list.Add(class2);
			}
			return list;
		}

		// Token: 0x06002146 RID: 8518
		// RVA: 0x000C285C File Offset: 0x000C0A5C
		private void method_2(ref string string_0)
		{
			if (this.dictionary_0 != null && string_0.IndexOf('$') >= 0)
			{
				foreach (KeyValuePair<string, string> current in this.dictionary_0)
				{
					string_0 = string_0.Replace(current.Key, current.Value);
				}
				return;
			}
		}

		// Token: 0x06002180 RID: 8576
		// RVA: 0x000C6608 File Offset: 0x000C4808
		internal void method_20(bool bool_2)
		{
			this.int_14 = this.list_3.Count;
			if (bool_2)
			{
				Class304[] collection = Class619.smethod_0<Class304>(this.list_3);
				this.list_3.Clear();
				this.list_3.AddRange(collection);
			}
			int num = 0;
			int num2 = 0;
			bool flag = false;
			int num3 = -1;
			int count = this.list_2.Count;
			int count2 = this.class872_0.list_0.Count;
			for (int i = 0; i < this.int_14; i++)
			{
				Class304 class = this.list_3[i];
				while (num3 + 1 < count2 && this.class872_0.list_0[num3 + 1].int_0 < class.StartTime)
				{
					num3++;
					class.NewCombo = true;
				}
				int num4 = (this.class296_0.bool_23 || Class341.class606_32) ? 0 : class.int_0;
				if (class.IsType(HitObjectType.Spinner))
				{
					if (this.class296_0.int_6 <= 8)
					{
						flag = true;
					}
					else if (class.NewCombo)
					{
						num += num4;
						flag = true;
					}
				}
				else if (!flag && (class.Type & HitObjectType.NewCombo) <= (HitObjectType)0 && (i != 0 || class is Class316))
				{
					num2 = (class.ComboNumber = num2 + 1);
				}
				else
				{
					num2 = 1;
					class.ComboNumber = 1;
					num += num4 + 1;
					flag = false;
				}
				if (count > 0 && this.vmethod_5())
				{
					class.vmethod_0(this.list_2[num % count]);
					class.int_1 = num % count;
				}
			}
			if (this.int_14 > 0)
			{
				this.list_3[this.int_14 - 1].LastInCombo = true;
			}
		}

		// Token: 0x06002181 RID: 8577
		// RVA: 0x000C67B8 File Offset: 0x000C49B8
		internal int method_21(Class705 class705_0)
		{
			int num = (class705_0.int_0 - class705_0.int_2) / 2 + class705_0.int_2;
			int num2 = this.list_3.BinarySearch(new Class330(this, num));
			if (num2 < 0)
			{
				num2 = ~num2;
			}
			return num2;
		}

		// Token: 0x06002182 RID: 8578
		// RVA: 0x000C67F8 File Offset: 0x000C49F8
		internal bool method_22(Class304 class304_2, bool bool_2)
		{
			Class297.Class489 class = new Class297.Class489();
			class.class304_0 = class304_2;
			int num = this.list_3.FindIndex(new Predicate<Class304>(class.method_0));
			if (num <= 0)
			{
				return bool_2;
			}
			class.int_0 = this.list_3[num].StartTime;
			class.int_1 = this.list_3[num - 1].EndTime;
			Class705 class2 = this.class872_0.list_0.Find(new Predicate<Class705>(class.method_1));
			return class2 != null;
		}

		// Token: 0x06002183 RID: 8579
		// RVA: 0x0001B0C0 File Offset: 0x000192C0
		internal int method_23(Class705 class705_0)
		{
			return this.method_21(class705_0) - 1;
		}

		// Token: 0x06002184 RID: 8580
		// RVA: 0x000C6884 File Offset: 0x000C4A84
		internal void method_24(int int_16)
		{
			if (!(this.list_3[int_16] is Class325))
			{
				if (int_16 == 0)
				{
					return;
				}
				int_16--;
				if (!(this.list_3[int_16] is Class325))
				{
					return;
				}
			}
			for (int i = int_16; i > 0; i--)
			{
				if (!(this.list_3[i] is Class325))
				{
					i++;
					IL_81:
					while (i < this.int_14)
					{
						if (!(this.list_3[i] is Class325))
						{
							this.list_3[i].NewCombo = true;
							return;
						}
						if (this.list_3[i].NewCombo)
						{
							return;
						}
						i++;
					}
					return;
				}
			}
			goto IL_81;
		}

		// Token: 0x06002185 RID: 8581
		// RVA: 0x000C6930 File Offset: 0x000C4B30
		internal void method_25()
		{
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < this.list_3.Count; i++)
			{
				Class304 class = this.list_3[i];
				if (!class.IsType(HitObjectType.Spinner))
				{
					if (flag && !flag2)
					{
						class.NewCombo = true;
					}
					flag = false;
					flag2 = false;
				}
				else
				{
					flag2 |= class.NewCombo;
				}
			}
		}

		// Token: 0x06002186 RID: 8582
		// RVA: 0x0001B0CB File Offset: 0x000192CB
		internal void method_26()
		{
			this.vmethod_15();
			this.vmethod_16();
		}

		// Token: 0x0600218D RID: 8589
		// RVA: 0x000C6EFC File Offset: 0x000C50FC
		internal void method_27(bool bool_2)
		{
			this.class872_0.method_16(true, bool_2);
			if (!this.class872_0.class911_0.bool_4)
			{
				List<Class530> arg_4C_0 = this.class872_0.class911_0.list_2;
				if (Class297.action_2 == null)
				{
					Class297.action_2 = new Action<Class530>(Class297.smethod_19);
				}
				arg_4C_0.ForEach(Class297.action_2);
				List<Class530> arg_7E_0 = this.class872_0.class911_2.list_2;
				if (Class297.action_3 == null)
				{
					Class297.action_3 = new Action<Class530>(Class297.smethod_20);
				}
				arg_7E_0.ForEach(Class297.action_3);
			}
		}

		// Token: 0x0600218F RID: 8591
		// RVA: 0x000C702C File Offset: 0x000C522C
		internal void method_28(int int_16, int int_17)
		{
			if (int_17 == -1)
			{
				int_17 = this.int_14 - 1;
			}
			Vector2 vector;
			vector..ctor(this.StackOffset, this.StackOffset);
			float num = (float)this.PreEmpt * this.class296_0.float_1;
			for (int i = int_16; i <= int_17; i++)
			{
				this.list_3[i].StackCount = 0;
			}
			int num2 = int_17;
			for (int j = int_17; j >= int_16; j--)
			{
				int num3 = j;
				for (int k = num3 + 1; k < this.int_14; k++)
				{
					Class304 class = this.list_3[num3];
					if (class is Class325)
					{
						break;
					}
					Class304 class2 = this.list_3[k];
					if (!(class2 is Class325))
					{
						if ((float)(class2.StartTime - class.EndTime) > num)
						{
							break;
						}
						if (Vector2.Distance(class.vector2_0, class2.vector2_0) < 3f || (class is Class320 && Vector2.Distance(class.method_0(), class2.vector2_0) < 3f))
						{
							num3 = k;
							class2.StackCount = 0;
						}
					}
				}
				if (num3 > num2)
				{
					num2 = num3;
					if (num2 == this.int_14 - 1)
					{
						break;
					}
				}
			}
			int num4 = int_16;
			for (int l = num2; l > int_16; l--)
			{
				int num5 = l;
				Class304 class3 = this.list_3[l];
				if (class3.StackCount == 0 && !(class3 is Class325))
				{
					if (class3 is Class305)
					{
						while (--num5 >= 0)
						{
							Class304 class4 = this.list_3[num5];
							if (!(class4 is Class325))
							{
								if ((float)(class3.StartTime - class4.EndTime) > num)
								{
									break;
								}
								if (num5 < num4)
								{
									class4.StackCount = 0;
									num4 = num5;
								}
								if (class4 is Class320 && Vector2.Distance(class4.method_0(), class3.vector2_0) < 3f)
								{
									int num6 = class3.StackCount - class4.StackCount + 1;
									for (int m = num5 + 1; m <= l; m++)
									{
										if (Vector2.Distance(class4.method_0(), this.list_3[m].vector2_0) < 3f)
										{
											this.list_3[m].StackCount -= num6;
										}
									}
									break;
								}
								if (Vector2.Distance(class4.vector2_0, class3.vector2_0) < 3f)
								{
									class4.StackCount = class3.StackCount + 1;
									class3 = class4;
								}
							}
						}
					}
					else if (class3 is Class320)
					{
						while (--num5 >= int_16)
						{
							Class304 class5 = this.list_3[num5];
							if (!(class5 is Class325))
							{
								if ((float)(class3.StartTime - class5.StartTime) > num)
								{
									break;
								}
								if (Vector2.Distance(class5.method_0(), class3.vector2_0) < 3f)
								{
									class5.StackCount = class3.StackCount + 1;
									class3 = class5;
								}
							}
						}
					}
				}
			}
			for (int n = int_16; n <= int_17; n++)
			{
				Class304 class6 = this.list_3[n];
				class6.vmethod_5(class6.vector2_0 - (float)class6.StackCount * vector, true);
			}
		}

		// Token: 0x06002190 RID: 8592
		// RVA: 0x000C7378 File Offset: 0x000C5578
		private void method_29()
		{
			Vector2 vector;
			vector..ctor(this.StackOffset, this.StackOffset);
			for (int i = 0; i < this.int_14; i++)
			{
				Class304 class = this.list_3[i];
				if (class is Class321)
				{
					((Class321)class).vmethod_24(true);
				}
				int endTime = class.EndTime;
				if (class.StackCount == 0 || class.IsType(HitObjectType.Slider))
				{
					int num = 0;
					int num2 = i + 1;
					while (num2 < this.int_14 && (float)this.list_3[num2].StartTime - (float)this.PreEmpt * this.class296_0.float_1 <= (float)endTime)
					{
						if (Vector2.Distance(this.list_3[num2].Position, class.Position) < 3f)
						{
							class.StackCount++;
							endTime = this.list_3[num2].EndTime;
						}
						else if (Vector2.Distance(this.list_3[num2].Position, class.vmethod_10()) < 3f)
						{
							num++;
							this.list_3[num2].StackCount -= num;
							endTime = this.list_3[num2].EndTime;
						}
						num2++;
					}
				}
				if (class.StackCount != 0)
				{
					class.vmethod_5(class.Position - (float)class.StackCount * vector, true);
				}
			}
		}

		// Token: 0x06002147 RID: 8519
		// RVA: 0x000C28D8 File Offset: 0x000C0AD8
		internal bool method_3(bool bool_2, bool bool_3, bool bool_4)
		{
			this.method_30();
			this.class872_0.method_10();
			Class296 class = this.class296_0;
			class.int_6 = 14;
			StringBuilder stringBuilder;
			using (StringWriter stringWriter = new StringWriter())
			{
				stringWriter.WriteLine("osu file format v" + class.int_6);
				stringWriter.WriteLine();
				stringWriter.WriteLine("[General]");
				stringWriter.WriteLine("AudioFilename: " + Path.GetFileName(class.string_1));
				stringWriter.WriteLine("AudioLeadIn: " + class.int_1);
				stringWriter.WriteLine("PreviewTime: " + Class331.smethod_76());
				stringWriter.WriteLine("Countdown: " + (int)class.enum65_0);
				stringWriter.WriteLine("SampleSet: " + ((Class331.sampleSet_0 > SampleSet.Soft) ? SampleSet.None : Class331.sampleSet_0));
				stringWriter.WriteLine("StackLeniency: " + class.float_1.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("Mode: " + (int)class.method_5());
				stringWriter.WriteLine("LetterboxInBreaks: " + (class.bool_11 ? "1" : "0"));
				if (!class.bool_14)
				{
					stringWriter.WriteLine("StoryFireInFront: 0");
				}
				if (class.bool_15)
				{
					stringWriter.WriteLine("UseSkinSprites: 1");
				}
				if (class.bool_0)
				{
					stringWriter.WriteLine("AlwaysShowPlayfield: 1");
				}
				if (class.overlayPosition_0 != OverlayPosition.NoChange)
				{
					stringWriter.WriteLine("OverlayPosition: " + class.overlayPosition_0);
				}
				if (!string.IsNullOrEmpty(class.string_11))
				{
					stringWriter.WriteLine("SkinPreference:" + class.string_11);
				}
				if (class.bool_21)
				{
					stringWriter.WriteLine("EpilepsyWarning: 1");
				}
				if (class.int_8 > 0)
				{
					stringWriter.WriteLine("CountdownOffset: " + class.int_8.ToString());
				}
				if (class.method_5() == PlayModes.OsuMania)
				{
					stringWriter.WriteLine("SpecialStyle: " + (class.bool_16 ? "1" : "0"));
				}
				stringWriter.WriteLine("WidescreenStoryboard: " + (class.bool_12 ? "1" : "0"));
				if (class.bool_17)
				{
					stringWriter.WriteLine("SamplesMatchPlaybackRate: 1");
				}
				stringWriter.WriteLine();
				stringWriter.WriteLine("[Editor]");
				if (this.list_1.Count > 0)
				{
					string text = string.Empty;
					foreach (int current in this.list_1)
					{
						text = text + current + ",";
					}
					text = text.Trim(new char[]
					{
						','
					});
					stringWriter.WriteLine("Bookmarks: " + text);
				}
				stringWriter.WriteLine("DistanceSpacing: " + Class341.class607_2);
				stringWriter.WriteLine("BeatDivisor: " + Class341.class608_2);
				stringWriter.WriteLine("GridSize: " + Class341.class608_3);
				stringWriter.WriteLine("TimelineZoom: " + class.float_2.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine();
				stringWriter.WriteLine("[Metadata]");
				stringWriter.WriteLine("Title:" + class.Title);
				stringWriter.WriteLine("TitleUnicode:" + class.TitleUnicode);
				stringWriter.WriteLine("Artist:" + class.Artist);
				stringWriter.WriteLine("ArtistUnicode:" + class.ArtistUnicode);
				stringWriter.WriteLine("Creator:" + class.string_5);
				stringWriter.WriteLine("Version:" + class.string_14);
				stringWriter.WriteLine("Source:" + class.string_13);
				stringWriter.WriteLine("Tags:" + class.Tags);
				stringWriter.WriteLine("BeatmapID:" + class.int_2);
				stringWriter.WriteLine("BeatmapSetID:" + class.int_3);
				stringWriter.WriteLine();
				stringWriter.WriteLine("[Difficulty]");
				stringWriter.WriteLine("HPDrainRate:" + class.DifficultyHpDrainRate.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("CircleSize:" + class.DifficultyCircleSize.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("OverallDifficulty:" + class.DifficultyOverall.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("ApproachRate:" + class.DifficultyApproachRate.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("SliderMultiplier:" + class.DifficultySliderMultiplier.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine("SliderTickRate:" + class.DifficultySliderTickRate.ToString(Class115.numberFormatInfo_0));
				stringWriter.WriteLine();
				this.method_4(stringWriter, true);
				stringWriter.WriteLine();
				if (this.class296_0.list_1.Count > 0)
				{
					stringWriter.WriteLine("[TimingPoints]");
					stringWriter.WriteLine(Class297.smethod_0(this.class296_0.list_1));
				}
				if (class.bool_5)
				{
					stringWriter.WriteLine();
					stringWriter.WriteLine("[Colours]");
					foreach (KeyValuePair<string, Color> current2 in Class885.dictionary_6)
					{
						if (current2.Value.get_A() != 0)
						{
							stringWriter.WriteLine("{0} : {1},{2},{3}", new object[]
							{
								current2.Key,
								current2.Value.get_R(),
								current2.Value.get_G(),
								current2.Value.get_B()
							});
						}
					}
				}
				stringWriter.WriteLine();
				stringWriter.WriteLine("[HitObjects]");
				this.method_25();
				this.method_20(true);
				foreach (Class304 current3 in this.list_3)
				{
					if (current3.StartTime <= Class331.smethod_31() && current3.StartTime >= 0)
					{
						string text2 = string.Empty;
						if (current3.IsType(HitObjectType.Slider))
						{
							text2 = ",";
							Class321 class2 = (Class321)current3;
							if (class2.SpatialLength == 0.0)
							{
								continue;
							}
							text2 = text2 + class2.curveTypes_1.ToString().Substring(0, 1) + "|";
							for (int i = 1; i < class2.list_3.Count; i++)
							{
								Vector2 vector = class2.list_3[i];
								object obj = text2;
								text2 = string.Concat(new object[]
								{
									obj,
									(int)vector.X,
									":",
									(int)vector.Y,
									"|"
								});
							}
							text2 = text2.Trim(new char[]
							{
								'|'
							});
							text2 = text2 + "," + class2.SegmentCount;
							text2 = text2 + "," + class2.SpatialLength.ToString(Class115.numberFormatInfo_0);
							if (!class2.bool_10)
							{
								text2 += ",";
								for (int j = 0; j < class2.list_8.Count; j++)
								{
									text2 = text2 + (int)class2.list_8[j] + "|";
								}
								text2 = text2.Trim(new char[]
								{
									'|'
								});
								text2 += ",";
								for (int k = 0; k < class2.list_9.Count; k++)
								{
									object obj2 = text2;
									text2 = string.Concat(new object[]
									{
										obj2,
										(int)class2.list_9[k],
										":",
										(int)class2.list_10[k],
										"|"
									});
								}
								text2 = text2.Trim(new char[]
								{
									'|'
								});
								text2 += string.Format(",{0}:{1}:{2}:{3}:{4}", new object[]
								{
									(int)current3.sampleSet_0,
									(int)current3.sampleSet_1,
									(int)current3.enum38_0,
									current3.int_3,
									current3.string_0
								});
							}
						}
						else if (current3.IsType(HitObjectType.Spinner))
						{
							text2 = string.Format(",{0},{1}:{2}:{3}:{4}:{5}", new object[]
							{
								current3.EndTime,
								(int)current3.sampleSet_0,
								(int)current3.sampleSet_1,
								(int)current3.enum38_0,
								current3.int_3,
								current3.string_0
							});
						}
						else if (current3.IsType(HitObjectType.Normal))
						{
							text2 = string.Format(",{0}:{1}:{2}:{3}:{4}", new object[]
							{
								(int)current3.sampleSet_0,
								(int)current3.sampleSet_1,
								(int)current3.enum38_0,
								current3.int_3,
								current3.string_0
							});
						}
						else if (current3.IsType(HitObjectType.Hold))
						{
							text2 = string.Format(",{0}:{1}:{2}:{3}:{4}:{5}", new object[]
							{
								current3.EndTime,
								(int)current3.sampleSet_0,
								(int)current3.sampleSet_1,
								(int)current3.enum38_0,
								current3.int_3,
								current3.string_0
							});
						}
						stringWriter.WriteLine(string.Concat(new object[]
						{
							(int)current3.Position.X,
							",",
							(int)current3.Position.Y,
							",",
							current3.StartTime,
							",",
							((int)(current3.Type | (HitObjectType)((current3.int_0 & 7) << 4))).ToString(),
							",",
							(int)current3.SoundType,
							text2
						}));
					}
				}
				stringBuilder = stringWriter.GetStringBuilder();
			}
			string text3 = Class33.smethod_1(class.method_46());
			string value = Class33.smethod_2(stringBuilder.ToString());
			bool flag = !text3.Equals(value);
			if (bool_4)
			{
				return flag;
			}
			if (bool_2)
			{
				if (text3.Equals(value))
				{
					return true;
				}
				if (Class115.bool_25)
				{
					if (DialogResult.OK != MessageBox.Show(Class41.GetString(OsuString.HitObjectManager_LoadSave_TestModeDirtyDialog), "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
					{
						return false;
					}
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show(Class41.GetString(OsuString.HitObjectManager_LoadSave_SaveChangesDialog), "osu!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					DialogResult dialogResult2 = dialogResult;
					switch (dialogResult2)
					{
					case DialogResult.OK:
						break;
					case DialogResult.Cancel:
						return false;
					default:
						if (dialogResult2 == DialogResult.No)
						{
							return true;
						}
						break;
					}
				}
			}
			string text4 = ((class.Artist.Length > 0) ? (class.Artist + " - " + class.Title) : Path.GetFileNameWithoutExtension(class.string_1)) + ((class.string_5.Length > 0) ? (" (" + class.string_5 + ")") : string.Empty) + ((class.string_14.Length > 0) ? (" [" + class.string_14 + "]") : string.Empty) + ".osu";
			text4 = Class34.smethod_1(text4);
			if (bool_3 || text4 != class.string_9)
			{
				if (File.Exists(class.method_3() + "\\" + text4))
				{
					DialogResult dialogResult3 = MessageBox.Show(Class41.GetString(OsuString.HitObjectManager_LoadSave_FileAlreadyExistsDialog), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					DialogResult dialogResult4 = dialogResult3;
					if (dialogResult4 == DialogResult.No)
					{
						return false;
					}
				}
				if (!bool_3)
				{
					Class34.smethod_18(class.method_46());
				}
				class.string_9 = text4;
			}
			if (class.bool_10)
			{
				class.method_70();
			}
			try
			{
				File.WriteAllText(class.method_46(), stringBuilder.ToString());
			}
			catch (Exception)
			{
				Class723.smethod_4("Unable to write to file " + class.method_46());
				bool result = false;
				return result;
			}
			List<Class702> arg_D74_0 = this.class872_0.list_1;
			if (Class297.predicate_0 == null)
			{
				Class297.predicate_0 = new Predicate<Class702>(Class297.smethod_16);
			}
			if (arg_D74_0.Find(Class297.predicate_0) != null)
			{
				using (StringWriter stringWriter2 = new StringWriter())
				{
					if (this.dictionary_0 != null && this.dictionary_0.Count > 0)
					{
						stringWriter2.WriteLine("[Variables]");
						foreach (KeyValuePair<string, string> current4 in this.dictionary_0)
						{
							stringWriter2.WriteLine("{0}={1}", current4.Key, current4.Value);
						}
						stringWriter2.WriteLine();
					}
					this.method_4(stringWriter2, false);
					stringBuilder = stringWriter2.GetStringBuilder();
				}
				string text5 = stringBuilder.ToString();
				foreach (KeyValuePair<string, string> current5 in this.dictionary_0)
				{
					text5 = text5.Replace("," + current5.Value, "," + current5.Key);
				}
				bool result;
				try
				{
					File.WriteAllText(Path.Combine(class.bool_10 ? class.method_8() : class.method_3(), class.method_43()), text5);
					goto IL_EC6;
				}
				catch
				{
					Class723.smethod_4("Unable to write to file " + class.method_43());
					result = false;
				}
				return result;
				IL_EC6:
				if (this.class296_0.submissionStatus_0 > SubmissionStatus.NotSubmitted)
				{
					this.class296_0.bool_18 = flag;
				}
			}
			else
			{
				File.Delete(Path.Combine(class.bool_10 ? class.method_8() : class.method_3(), class.method_43()));
			}
			Class115.smethod_79(Path.GetFileName(class.string_9));
			class.method_25();
			class.method_11();
			Class331.smethod_6(false);
			return true;
		}

		// Token: 0x06002191 RID: 8593
		// RVA: 0x0001B0E7 File Offset: 0x000192E7
		internal void method_30()
		{
			List<Class304> arg_23_0 = this.list_3;
			if (Class297.action_4 == null)
			{
				Class297.action_4 = new Action<Class304>(Class297.smethod_21);
			}
			arg_23_0.ForEach(Class297.action_4);
		}

		// Token: 0x06002192 RID: 8594
		// RVA: 0x000C7500 File Offset: 0x000C5700
		internal void method_31(int int_16, int int_17)
		{
			if (int_17 == -1)
			{
				int_17 = this.int_14 - 1;
			}
			Class731[] class731_ = Class885.smethod_27("followpoint", Enum112.flag_6, true);
			int num = 0;
			for (int i = int_16 + 1; i <= int_17; i++)
			{
				Class304 class = this.list_3[i];
				if (!class.NewCombo && !this.list_3[i - 1].IsType(HitObjectType.Spinner) && !this.list_3[i].IsType(HitObjectType.Spinner))
				{
					Vector2 endPosition = this.list_3[i - 1].EndPosition;
					int endTime = this.list_3[i - 1].EndTime;
					Vector2 position = class.Position;
					int startTime = class.StartTime;
					int num2 = (int)Vector2.Distance(endPosition, position);
					Vector2 vector = position - endPosition;
					int num3 = startTime - endTime;
					float num4 = (float)Math.Atan2((double)(position.Y - endPosition.Y), (double)(position.X - endPosition.X));
					for (int j = (int)((double)Class297.int_4 * 1.5); j < num2 - Class297.int_4; j += Class297.int_4)
					{
						float num5 = (float)j / (float)num2;
						Vector2 vector2 = endPosition + (num5 - 0.1f) * vector;
						Vector2 vector3 = endPosition + num5 * vector;
						int num6 = (int)((float)endTime + num5 * (float)num3) - Class297.int_6;
						int num7 = (int)((float)endTime + num5 * (float)num3);
						Class538 class2;
						if (num < this.list_5.Count)
						{
							class2 = this.list_5[num];
							class2.vector2_1 = vector3;
							foreach (Class746 current in class2.class26_0)
							{
								if (current.transformationType_0 == TransformationType.Fade && current.float_1 == 0f)
								{
									current.int_0 = num7;
									current.int_1 = num7 + Class297.int_2;
								}
								else
								{
									current.int_0 = num6;
									current.int_1 = num6 + Class297.int_2;
								}
								if (current.transformationType_0 == TransformationType.Movement)
								{
									current.vector2_0 = vector2;
									current.vector2_1 = vector3;
								}
							}
							class2.method_59();
						}
						else
						{
							class2 = new Class538(class731_, Enum115.const_0, Origins.Centre, Enum114.const_1, vector3, 0f, false, Color.get_White(), null);
							class2.method_61();
							class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num6, num6 + Class297.int_2, Enum70.const_0));
							if (Class885.smethod_24() && Class115.bool_32)
							{
								class2.class26_0.Add(new Class746(TransformationType.Scale, 1.5f, 1f, num6, num6 + Class297.int_2, Enum70.const_1));
								class2.class26_0.Add(new Class746(TransformationType.Movement, vector2, vector3, num6, num6 + Class297.int_2, Enum70.const_1));
							}
							class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num7, num7 + Class297.int_2, Enum70.const_0));
							if (Class115.osuModes_1 == OsuModes.Edit)
							{
								this.list_5.Add(class2);
							}
						}
						class2.float_1 = num4;
						this.class911_0.Add(class2);
						num++;
					}
				}
			}
		}

		// Token: 0x06002196 RID: 8598
		// RVA: 0x000C785C File Offset: 0x000C5A5C
		public bool method_32()
		{
			switch (this.class296_0.overlayPosition_0)
			{
			case OverlayPosition.Below:
				return false;
			case OverlayPosition.Above:
				return true;
			default:
				return Class885.class547_0.bool_4;
			}
		}

		// Token: 0x0600219C RID: 8604
		// RVA: 0x0001B144 File Offset: 0x00019344
		[CompilerGenerated]
		private void method_33(Class304 class304_2)
		{
			class304_2.list_1.ForEach(new Action<Class531>(this.class911_0.Add));
		}

		// Token: 0x06002148 RID: 8520
		// RVA: 0x000C38F0 File Offset: 0x000C1AF0
		private void method_4(StringWriter stringWriter_0, bool bool_2)
		{
			Predicate<Class702> predicate = null;
			Class297.Class486 class = new Class297.Class486();
			class.bool_0 = bool_2;
			stringWriter_0.WriteLine("[Events]");
			stringWriter_0.WriteLine("//Background and Video events");
			foreach (Class702 current in this.class872_0.list_1.FindAll(new Predicate<Class702>(class.method_0)))
			{
				switch (current.eventTypes_0)
				{
				case EventTypes.Background:
					stringWriter_0.WriteLine("{0},{1},\"{2}\",{3},{4}", new object[]
					{
						(int)current.eventTypes_0,
						current.int_2,
						Class34.smethod_16(current.string_0),
						(current.class531_0 != null) ? current.class531_0.vector2_1.X : 0f,
						(current.class531_0 != null) ? current.class531_0.vector2_1.Y : 0f
					});
					break;
				case EventTypes.Video:
					stringWriter_0.WriteLine("{0},{1},\"{2}\"", current.eventTypes_0, current.int_2, current.string_0);
					break;
				}
			}
			if (class.bool_0)
			{
				stringWriter_0.WriteLine("//Break Periods");
				foreach (Class705 current2 in this.class872_0.list_0)
				{
					stringWriter_0.WriteLine("{0},{1},{2}", (int)current2.eventTypes_0, current2.int_2, current2.int_0);
				}
			}
			for (int i = 0; i < this.class872_0.list_3.Length; i++)
			{
				stringWriter_0.WriteLine("//Storyboard Layer {0} ({1})", i, (StoryLayer)i);
				List<Class702> arg_203_0 = this.class872_0.list_3[i];
				if (predicate == null)
				{
					predicate = new Predicate<Class702>(class.method_1);
				}
				foreach (Class702 current3 in arg_203_0.FindAll(predicate))
				{
					switch (current3.eventTypes_0)
					{
					case EventTypes.Sprite:
					case EventTypes.Animation:
					{
						current3.class531_0.class26_0.Sort();
						Class703 class2 = current3 as Class703;
						if (current3.eventTypes_0 == EventTypes.Sprite)
						{
							stringWriter_0.WriteLine("{0},{1},{2},\"{3}\",{4},{5}", new object[]
							{
								current3.eventTypes_0,
								current3.storyLayer_0,
								current3.class531_0.origins_0,
								current3.string_0,
								(int)current3.class531_0.vector2_0.X,
								(int)current3.class531_0.vector2_0.Y
							});
						}
						else
						{
							stringWriter_0.WriteLine("{0},{1},{2},\"{3}\",{4},{5},{6},{7},{8}", new object[]
							{
								current3.eventTypes_0,
								current3.storyLayer_0,
								current3.class531_0.origins_0,
								current3.string_0,
								(int)current3.class531_0.vector2_0.X,
								(int)current3.class531_0.vector2_0.Y,
								class2.class538_0.int_7,
								class2.double_0,
								class2.class538_0.loopTypes_0
							});
						}
						if (current3.class531_0.list_0 != null)
						{
							foreach (Class743 current4 in current3.class531_0.list_0)
							{
								stringWriter_0.WriteLine(" L,{0},{1}", current4.int_1, current4.int_0);
								current4.class26_0.Sort();
								foreach (Class746 current5 in current4.class26_0)
								{
									if (current5.method_0() == 0)
									{
										stringWriter_0.Write("  {0},{1},{2},,", Class297.smethod_3(current5.transformationType_0), (int)current5.enum70_0, current5.int_0);
									}
									else
									{
										stringWriter_0.Write("  {0},{1},{2},{3},", new object[]
										{
											Class297.smethod_3(current5.transformationType_0),
											(int)current5.enum70_0,
											current5.int_0,
											current5.int_1
										});
									}
									this.method_5(stringWriter_0, current5);
									stringWriter_0.WriteLine();
								}
							}
						}
						foreach (Class746 current6 in current3.class531_0.class26_0)
						{
							if (!current6.bool_1)
							{
								if (current6.method_0() == 0)
								{
									stringWriter_0.Write(" {0},{1},{2},,", Class297.smethod_3(current6.transformationType_0), (int)current6.enum70_0, current6.int_0);
								}
								else
								{
									stringWriter_0.Write(" {0},{1},{2},{3},", new object[]
									{
										Class297.smethod_3(current6.transformationType_0),
										(int)current6.enum70_0,
										current6.int_0,
										current6.int_1
									});
								}
								this.method_5(stringWriter_0, current6);
								stringWriter_0.WriteLine();
							}
						}
						if (current3.dictionary_0.Count > 0)
						{
							foreach (KeyValuePair<TriggerGroup, List<Class744>> current7 in current3.dictionary_0)
							{
								foreach (Class744 current8 in current7.Value)
								{
									if (current8.int_2 == 0)
									{
										stringWriter_0.Write(" T,{0}", current8.class477_0);
									}
									else
									{
										stringWriter_0.Write(" T,{0},{1},{2}", current8.class477_0, current8.int_3, current8.int_2);
									}
									if (current8.class477_0.method_0())
									{
										stringWriter_0.WriteLine(",{0}", (int)(-(int)current8.class477_0.method_1()));
									}
									else
									{
										stringWriter_0.WriteLine();
									}
									current8.class26_0.Sort();
									foreach (Class746 current9 in current8.class26_0)
									{
										if (current9.method_0() == 0)
										{
											stringWriter_0.Write("  {0},{1},{2},,", Class297.smethod_3(current9.transformationType_0), (int)current9.enum70_0, current9.int_0);
										}
										else
										{
											stringWriter_0.Write("  {0},{1},{2},{3},", new object[]
											{
												Class297.smethod_3(current9.transformationType_0),
												(int)current9.enum70_0,
												current9.int_0,
												current9.int_1
											});
										}
										this.method_5(stringWriter_0, current9);
										stringWriter_0.WriteLine();
									}
								}
							}
						}
						break;
					}
					}
				}
			}
			stringWriter_0.WriteLine("//Storyboard Sound Samples");
			foreach (Class704 current10 in this.class872_0.list_2.FindAll(new Predicate<Class704>(class.method_2)))
			{
				stringWriter_0.WriteLine("{0},{1},{2},\"{3}\",{4}", new object[]
				{
					current10.eventTypes_0,
					current10.int_2,
					(int)current10.storyLayer_0,
					Class34.smethod_16(current10.string_0),
					current10.int_3
				});
			}
			List<Class702> arg_8DA_0 = this.class872_0.list_1;
			if (Class297.action_1 == null)
			{
				Class297.action_1 = new Action<Class702>(Class297.smethod_17);
			}
			arg_8DA_0.ForEach(Class297.action_1);
		}

		// Token: 0x0600214D RID: 8525
		// RVA: 0x000C45F0 File Offset: 0x000C27F0
		private void method_5(StringWriter stringWriter_0, Class746 class746_0)
		{
			TransformationType transformationType_ = class746_0.transformationType_0;
			if (transformationType_ <= TransformationType.ParameterFlipHorizontal)
			{
				if (transformationType_ <= TransformationType.Rotation)
				{
					switch (transformationType_)
					{
					case TransformationType.Movement:
						if (class746_0.vector2_0 == class746_0.vector2_1)
						{
							stringWriter_0.Write("{0},{1}", (int)class746_0.vector2_0.X, (int)class746_0.vector2_0.Y);
							return;
						}
						stringWriter_0.Write("{0},{1},{2},{3}", new object[]
						{
							(int)class746_0.vector2_0.X,
							(int)class746_0.vector2_0.Y,
							(int)class746_0.vector2_1.X,
							(int)class746_0.vector2_1.Y
						});
						return;
					case TransformationType.Fade:
					case TransformationType.Scale:
						goto IL_2D1;
					case TransformationType.Movement | TransformationType.Fade:
						break;
					default:
						if (transformationType_ != TransformationType.Rotation)
						{
							return;
						}
						goto IL_2D1;
					}
				}
				else if (transformationType_ != TransformationType.Colour)
				{
					if (transformationType_ != TransformationType.ParameterFlipHorizontal)
					{
						return;
					}
					stringWriter_0.Write("H");
					return;
				}
				else
				{
					if (class746_0.color_0 == class746_0.color_1)
					{
						stringWriter_0.Write("{0},{1},{2}", class746_0.color_0.get_R(), class746_0.color_0.get_G(), class746_0.color_0.get_B());
						return;
					}
					stringWriter_0.Write("{0},{1},{2},{3},{4},{5}", new object[]
					{
						class746_0.color_0.get_R(),
						class746_0.color_0.get_G(),
						class746_0.color_0.get_B(),
						class746_0.color_1.get_R(),
						class746_0.color_1.get_G(),
						class746_0.color_1.get_B()
					});
					return;
				}
			}
			else if (transformationType_ <= TransformationType.MovementX)
			{
				if (transformationType_ == TransformationType.ParameterFlipVertical)
				{
					stringWriter_0.Write("V");
					return;
				}
				if (transformationType_ != TransformationType.MovementX)
				{
					return;
				}
				goto IL_2D1;
			}
			else
			{
				if (transformationType_ == TransformationType.MovementY)
				{
					goto IL_2D1;
				}
				if (transformationType_ != TransformationType.VectorScale)
				{
					if (transformationType_ != TransformationType.ParameterAdditive)
					{
						return;
					}
					stringWriter_0.Write("A");
				}
				else
				{
					if (class746_0.vector2_0 == class746_0.vector2_1)
					{
						stringWriter_0.Write("{0},{1}", class746_0.vector2_0.X.ToString(Class115.numberFormatInfo_0), class746_0.vector2_0.Y.ToString(Class115.numberFormatInfo_0));
						return;
					}
					stringWriter_0.Write("{0},{1},{2},{3}", new object[]
					{
						class746_0.vector2_0.X.ToString(Class115.numberFormatInfo_0),
						class746_0.vector2_0.Y.ToString(Class115.numberFormatInfo_0),
						class746_0.vector2_1.X.ToString(Class115.numberFormatInfo_0),
						class746_0.vector2_1.Y.ToString(Class115.numberFormatInfo_0)
					});
					return;
				}
			}
			return;
			IL_2D1:
			if (class746_0.float_0 == class746_0.float_1)
			{
				stringWriter_0.Write("{0}", class746_0.float_0.ToString(Class115.numberFormatInfo_0));
				return;
			}
			stringWriter_0.Write("{0},{1}", class746_0.float_0.ToString(Class115.numberFormatInfo_0), class746_0.float_1.ToString(Class115.numberFormatInfo_0));
		}

		// Token: 0x0600214E RID: 8526
		// RVA: 0x0001AEF5 File Offset: 0x000190F5
		public bool method_6()
		{
			return this.class304_1 == null || this.class304_1 is Class325 || this.class304_1 is Class317;
		}

		// Token: 0x0600214F RID: 8527
		// RVA: 0x0001AF1C File Offset: 0x0001911C
		internal void method_7(List<Class304> list_7)
		{
			if (list_7 == null)
			{
				return;
			}
			this.class911_0.Clear(true);
			this.list_3 = list_7;
		}

		// Token: 0x06002153 RID: 8531
		// RVA: 0x0001AF35 File Offset: 0x00019135
		internal void method_8(Class296 class296_1, Mods mods_0)
		{
			this.class296_0 = class296_1;
			this.class623_0 = mods_0;
			this.class494_0 = this.vmethod_7();
			this.vmethod_1();
		}

		// Token: 0x06002160 RID: 8544
		// RVA: 0x0001B02F File Offset: 0x0001922F
		internal int method_9()
		{
			if (Class115.osuModes_1 == OsuModes.Edit && !Class341.class606_20)
			{
				return 1600;
			}
			return 0;
		}

		// Token: 0x0600217E RID: 8574
		// RVA: 0x000C6574 File Offset: 0x000C4774
		internal void Remove(Class304[] class304_2)
		{
			for (int i = 0; i < class304_2.Length; i++)
			{
				Class304 class304_3 = class304_2[i];
				this.Remove(class304_3, false);
			}
			this.method_20(false);
		}

		// Token: 0x0600217F RID: 8575
		// RVA: 0x000C65A8 File Offset: 0x000C47A8
		internal bool Remove(Class304 class304_2, bool bool_2)
		{
			if (class304_2 == null)
			{
				return false;
			}
			this.class911_0.method_13<Class531>(class304_2.list_1);
			bool result;
			if (result = this.list_3.Remove(class304_2))
			{
				this.int_14--;
			}
			this.list_4.Remove(class304_2);
			if (bool_2)
			{
				this.method_20(false);
			}
			class304_2.Dispose();
			return result;
		}

		// Token: 0x06002157 RID: 8535
		// RVA: 0x000C4B54 File Offset: 0x000C2D54
		public override double SliderVelocityAt(int time)
		{
			double num = this.class296_0.method_36((double)time, true);
			if (num > 0.0)
			{
				return this.SliderScoringPointDistance * this.class296_0.DifficultySliderTickRate * (1000.0 / num);
			}
			return this.SliderScoringPointDistance * this.class296_0.DifficultySliderTickRate;
		}

		// Token: 0x06002149 RID: 8521
		// RVA: 0x000C42D0 File Offset: 0x000C24D0
		internal static string smethod_0(List<Class340> list_7)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (Class340 current in list_7)
			{
				if (current.double_0 != 0.0)
				{
					stringBuilder.AppendFormat(Class115.numberFormatInfo_0, "{0},{1},{2},{3},{4},{5},{6},{7}\r\n", new object[]
					{
						current.double_1,
						current.double_0,
						(int)current.enum37_0,
						(int)current.sampleSet_0,
						(int)current.enum38_0,
						current.int_0,
						current.method_0() ? "1" : "0",
						(int)current.enum39_0
					});
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600214A RID: 8522
		// RVA: 0x000C43D0 File Offset: 0x000C25D0
		internal static List<Class340> smethod_1(Class296 class296_1, string string_0, ref bool bool_2, bool bool_3)
		{
			List<Class340> list = bool_3 ? null : new List<Class340>();
			if (!string_0.Contains("NaN") && !string_0.Contains("Infinity"))
			{
				string[] array = string_0.Split(new char[]
				{
					'\n'
				});
				bool_2 = true;
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i];
					if (text.Trim().Length != 0)
					{
						Class340 class = Class297.smethod_2(text, class296_1.int_17, class296_1.int_15, class296_1.sampleSet_0);
						if (class == null)
						{
							bool_2 = false;
							return null;
						}
						if (!bool_3)
						{
							list.Add(class);
						}
					}
				}
				return list;
			}
			bool_2 = false;
			return null;
		}

		// Token: 0x0600215C RID: 8540
		// RVA: 0x000C4BB0 File Offset: 0x000C2DB0
		public static double smethod_10(double double_0, double double_1, Mods mods_0)
		{
			if (Class115.osuModes_1 != OsuModes.Edit && Class876.smethod_6(mods_0, Mods.Easy))
			{
				double_0 = Math.Max(0.0, double_0 / 2.0);
			}
			if (Class115.osuModes_1 != OsuModes.Edit && Class876.smethod_6(mods_0, Mods.HardRock))
			{
				double_0 = Math.Min(10.0, double_0 * double_1);
			}
			return double_0;
		}

		// Token: 0x0600215D RID: 8541
		// RVA: 0x0001AFEC File Offset: 0x000191EC
		public static double smethod_11(double double_0, double double_1)
		{
			return Class297.smethod_10(double_0, double_1, Class876.class623_0);
		}

		// Token: 0x0600216D RID: 8557
		// RVA: 0x000C515C File Offset: 0x000C335C
		internal static void smethod_12()
		{
			float num = (float)Class115.class125_0.method_10();
			float num2 = (float)Class115.class125_0.method_8();
			float num3 = 1f / (num / 2f);
			float num4 = 1f / (num2 / 2f);
			Class297.matrix_0 = Matrix.CreateScale(num3, num4, 1f) * Matrix.CreateScale(1f, -1f, 1f) * Matrix.CreateTranslation(-1f, 1f, 1f);
		}

		// Token: 0x0600218A RID: 8586
		// RVA: 0x000C6D30 File Offset: 0x000C4F30
		internal static void smethod_13()
		{
			lock (Class297.list_0)
			{
				foreach (Class297 current in Class297.list_0)
				{
					if (Class115.osuModes_1 == OsuModes.Edit)
					{
						for (int i = 0; i < current.int_14; i++)
						{
							if (current.list_3[i].bool_4)
							{
								current.list_3[i].Draw();
							}
						}
					}
					else if (Class62.bool_40 || Class115.osuModes_1 != OsuModes.Play)
					{
						foreach (Class304 current2 in current.list_4)
						{
							if (current2.bool_4)
							{
								current2.Draw();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600218B RID: 8587
		// RVA: 0x000C6E40 File Offset: 0x000C5040
		internal static void smethod_14()
		{
			lock (Class297.list_0)
			{
				foreach (Class297 current in Class297.list_0)
				{
					foreach (Class304 current2 in current.list_4)
					{
						Class321 class = current2 as Class321;
						if (class != null)
						{
							class.method_10();
						}
					}
				}
			}
		}

		// Token: 0x06002198 RID: 8600
		// RVA: 0x0001B11B File Offset: 0x0001931B
		[CompilerGenerated]
		private static void smethod_15(Enum38 enum38_0)
		{
			Class331.smethod_41(enum38_0);
		}

		// Token: 0x06002199 RID: 8601
		// RVA: 0x0001B123 File Offset: 0x00019323
		[CompilerGenerated]
		private static bool smethod_16(Class702 class702_0)
		{
			return !class702_0.bool_2;
		}

		// Token: 0x0600219A RID: 8602
		// RVA: 0x0001B12E File Offset: 0x0001932E
		[CompilerGenerated]
		private static void smethod_17(Class702 class702_0)
		{
			class702_0.int_1 = 0;
		}

		// Token: 0x0600219B RID: 8603
		// RVA: 0x0001B137 File Offset: 0x00019337
		[CompilerGenerated]
		private static bool smethod_18(Class304 class304_2)
		{
			return (class304_2.Type & HitObjectType.Slider) > (HitObjectType)0;
		}

		// Token: 0x0600219D RID: 8605
		// RVA: 0x0001B162 File Offset: 0x00019362
		[CompilerGenerated]
		private static void smethod_19(Class530 class530_0)
		{
			class530_0.method_10();
		}

		// Token: 0x0600214B RID: 8523
		// RVA: 0x000C4480 File Offset: 0x000C2680
		internal static Class340 smethod_2(string string_0, int int_16, int int_17, SampleSet sampleSet_0)
		{
			Class340 result;
			try
			{
				string[] array = string_0.Split(new char[]
				{
					','
				});
				if (array.Length > 2)
				{
					int enum39_ = (array.Length > 7) ? Convert.ToInt32(array[7], Class115.numberFormatInfo_0) : 0;
					result = new Class340(double.Parse(array[0].Trim(), Class115.numberFormatInfo_0) + (double)int_16, double.Parse(array[1].Trim(), Class115.numberFormatInfo_0), (Enum37)((array[2][0] == '0') ? 4 : int.Parse(array[2])), (SampleSet)int.Parse(array[3]), (Enum38)((array.Length > 4) ? int.Parse(array[4]) : 0), (array.Length > 5) ? int.Parse(array[5]) : int_17, array.Length <= 6 || array[6][0] == '1', (Enum39)enum39_);
				}
				else if (array.Length == 2)
				{
					result = new Class340(double.Parse(array[0].Trim(), Class115.numberFormatInfo_0) + (double)int_16, double.Parse(array[1].Trim(), Class115.numberFormatInfo_0), Enum37.const_0, sampleSet_0, Class331.smethod_74(), 100, true, Enum39.flag_0);
				}
				else
				{
					result = null;
				}
			}
			catch (FormatException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600219E RID: 8606
		// RVA: 0x0001B162 File Offset: 0x00019362
		[CompilerGenerated]
		private static void smethod_20(Class530 class530_0)
		{
			class530_0.method_10();
		}

		// Token: 0x0600219F RID: 8607
		// RVA: 0x00017213 File Offset: 0x00015413
		[CompilerGenerated]
		private static void smethod_21(Class304 class304_2)
		{
			class304_2.method_4();
		}

		// Token: 0x0600214C RID: 8524
		// RVA: 0x000C45B0 File Offset: 0x000C27B0
		private static string smethod_3(TransformationType transformationType_0)
		{
			if (transformationType_0 == TransformationType.MovementX)
			{
				return "MX";
			}
			if (transformationType_0 != TransformationType.MovementY)
			{
				return transformationType_0.ToString().Substring(0, 1);
			}
			return "MY";
		}

		// Token: 0x06002151 RID: 8529
		// RVA: 0x000C4A14 File Offset: 0x000C2C14
		public static void smethod_4(bool bool_2)
		{
			lock (Class297.list_0)
			{
				foreach (Class297 current in Class297.list_0)
				{
					current.vmethod_8(bool_2, true);
				}
			}
		}

		// Token: 0x06002152 RID: 8530
		// RVA: 0x000C4A8C File Offset: 0x000C2C8C
		public static void smethod_5(Struct69 struct69_0)
		{
			lock (Class297.list_0)
			{
				if (Class297.list_0.Count > 0 && Class297.list_0[0].class872_0 != null)
				{
					Class297.list_0[0].class872_0.method_18(struct69_0);
				}
			}
		}

		// Token: 0x06002158 RID: 8536
		// RVA: 0x0001AF64 File Offset: 0x00019164
		public static double smethod_6(double double_0, Mods mods_0)
		{
			if (Class876.smethod_6(mods_0, Mods.DoubleTime))
			{
				return double_0 * 1.5;
			}
			if (Class876.smethod_6(mods_0, Mods.HalfTime))
			{
				return double_0 * 0.75;
			}
			return double_0;
		}

		// Token: 0x06002159 RID: 8537
		// RVA: 0x0001AF96 File Offset: 0x00019196
		public static double smethod_7(double double_0)
		{
			return Class297.smethod_6(double_0, Class876.class623_0);
		}

		// Token: 0x0600215A RID: 8538
		// RVA: 0x0001AFA8 File Offset: 0x000191A8
		public static double smethod_8(double double_0, Mods mods_0)
		{
			if (Class876.smethod_6(mods_0, Mods.DoubleTime))
			{
				return double_0 / 1.5;
			}
			if (Class876.smethod_6(mods_0, Mods.HalfTime))
			{
				return double_0 / 0.75;
			}
			return double_0;
		}

		// Token: 0x0600215B RID: 8539
		// RVA: 0x0001AFDA File Offset: 0x000191DA
		public static double smethod_9(double double_0)
		{
			return Class297.smethod_8(double_0, Class876.class623_0);
		}

		// Token: 0x06002150 RID: 8528
		// RVA: 0x000C4924 File Offset: 0x000C2B24
		internal virtual void vmethod_0(bool bool_2)
		{
			this.list_2.Clear();
			for (int i = 1; i <= 8; i++)
			{
				Color item = Class885.smethod_23("Combo" + i, !this.class296_0.bool_23 && !Class341.class606_32);
				if (item.get_A() != 0)
				{
					this.list_2.Add(item);
				}
			}
			if (bool_2)
			{
				List<Color> list = new List<Color>();
				foreach (Color current in this.list_2)
				{
					list.Add(new Color(80 + current.get_R() / 2, 80 + current.get_G() / 2, 80 + current.get_B() / 2));
				}
				this.list_2 = list;
			}
		}

		// Token: 0x06002154 RID: 8532
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_1()
		{
		}

		// Token: 0x06002178 RID: 8568
		// RVA: 0x000C5700 File Offset: 0x000C3900
		internal virtual Enum61 vmethod_10(Class304 class304_2)
		{
			this.class304_0 = class304_2;
			Enum61 enum = class304_2.vmethod_2();
			int num = this.list_3.BinarySearch(class304_2);
			this.int_13 = ((num < 0) ? (~num) : num);
			if (enum == Enum61.flag_5)
			{
				return enum;
			}
			bool flag = false;
			string text = string.Empty;
			if (Class62.class512_0 != null && Class876.smethod_6(this.class623_0, Mods.Perfect))
			{
				Enum61 enum2 = enum & Enum61.flag_39;
				Enum61 enum3 = enum2;
				switch (enum3)
				{
				case Enum61.flag_14:
				case Enum61.flag_17:
					break;
				default:
					switch (enum3)
					{
					case Enum61.flag_15:
					case Enum61.flag_18:
					case Enum61.flag_20:
						break;
					default:
						goto IL_98;
					}
					break;
				}
				enum = Enum61.flag_3;
			}
			IL_98:
			Color arg_9D_0 = Color.get_White();
			int num2 = 0;
			string str;
			if (enum < Enum61.flag_5)
			{
				str = "hit0";
			}
			else
			{
				Enum61 enum4 = enum & Enum61.flag_39;
				if (enum4 != Enum61.flag_14)
				{
					switch (enum4)
					{
					case Enum61.flag_15:
						str = "hit100";
						num2 = 100;
						new Color(129, 255, 95);
						goto IL_1D5;
					case Enum61.flag_18:
						break;
					case Enum61.flag_20:
						str = "hit100k";
						num2 = 100;
						new Color(129, 255, 95);
						goto IL_1D5;
					default:
						switch (enum4)
						{
						case Enum61.flag_16:
							str = "hit300";
							num2 = 300;
							new Color(69, 255, 255);
							goto IL_1D5;
						case Enum61.flag_21:
							str = "hit300k";
							num2 = 300;
							new Color(69, 255, 255);
							goto IL_1D5;
						case Enum61.flag_22:
							str = "hit300g";
							num2 = 300;
							new Color(69, 255, 255);
							goto IL_1D5;
						}
						break;
					}
					str = string.Empty;
				}
				else
				{
					str = "hit50";
					num2 = 50;
					new Color(255, 216, 95);
				}
			}
			IL_1D5:
			if ((enum & Enum61.flag_28) > Enum61.flag_5 && enum > Enum61.flag_3)
			{
				text = "k";
			}
			Enum61 enum5 = enum;
			if (enum5 != Enum61.flag_3 && enum5 != Enum61.flag_14)
			{
				if (enum5 == Enum61.flag_15)
				{
					this.int_12++;
				}
			}
			else
			{
				this.int_11++;
			}
			if (this.vmethod_6() && num >= 0 && (num == this.int_14 - 1 || (num < this.int_14 - 1 && this.list_3[num + 1].NewCombo)))
			{
				flag = true;
				bool flag2 = false;
				if (!(class304_2 is Class328))
				{
					for (int i = num; i > -1; i--)
					{
						if (!this.list_3[i].bool_0)
						{
							flag2 = true;
							break;
						}
						if (this.list_3[i].NewCombo)
						{
							break;
						}
					}
				}
				if (enum > Enum61.flag_5)
				{
					if (this.int_12 == 0 && this.int_11 == 0 && !flag2)
					{
						text = "g";
						enum |= Enum61.flag_8;
					}
					else if (this.int_11 == 0 && !flag2)
					{
						text = "k";
						enum |= Enum61.flag_7;
					}
					else
					{
						enum |= Enum61.flag_6;
					}
				}
				this.int_12 = 0;
				this.int_11 = 0;
			}
			Class731 class = null;
			if ((!Class62.bool_15 && !Class62.bool_16) || enum >= Enum61.flag_5)
			{
				Class731[] array = this.vmethod_12(str + text);
				if (array != null)
				{
					class = Class885.Load("particle" + num2, array[0].enum112_0);
				}
				bool flag3 = false;
				float num3;
				if (Class62.Mode == PlayModes.Taiko)
				{
					num3 = 0.96f;
				}
				else if (class304_2 is Class328)
				{
					num3 = Class911.smethod_2((float)(class304_2.StartTime + 20));
				}
				else if (class == null && (class304_2 is Class306 || class304_2 is Class321))
				{
					num3 = Class911.smethod_3((float)(class304_2.EndTime - 4));
				}
				else
				{
					flag3 = true;
					num3 = Class911.smethod_2((float)class304_2.EndTime);
				}
				Class538 class2 = new Class538(array, Enum115.const_0, Origins.Centre, Enum114.const_2, class304_2.EndPosition, num3, false, Color.get_White())
				{
					loopTypes_0 = LoopTypes.LoopOnce
				};
				bool flag4 = class2.int_7 == 1;
				if (class != null && flag3 && enum > Enum61.flag_5)
				{
					Class538 class3 = (Class538)class2.Clone();
					class3.float_0 = 1f;
					class3.bool_7 = true;
					class3.float_2 = 0.9f;
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.6f, 1.1f, Class331.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 0.8), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 0.9f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 1.2), Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Scale, 0.9f, 1.05f, Class331.int_7, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_0));
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.5f, Class331.int_7 - 16, Class331.int_7 + 40, Enum70.const_1));
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0.5f, 0f, Class331.int_7 + 40, Class331.int_7 + 340, Enum70.const_0));
					this.class911_0.Add(class3);
				}
				if (enum > Enum61.flag_5 && Class341.class606_29 && this.vmethod_22())
				{
					Class531 class4 = new Class531(Class885.Load("lighting", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_2, class304_2.EndPosition, 0f, false, class304_2.Colour, null);
					if (!Class885.smethod_25())
					{
						int num4 = (!Class62.bool_38 || Class341.class606_46) ? 600 : 300;
						float num5 = (!Class62.bool_38 || Class341.class606_46) ? 1.85f : 2f;
						class4.class26_0.Add(new Class746(TransformationType.Scale, 0.8f, num5, Class331.int_7, Class331.int_7 + num4, Enum70.const_1));
						class4.class26_0.Add(new Class746(TransformationType.Scale, num5, 2.2f, Class331.int_7 + num4, Class331.int_7 + 1400, Enum70.const_0));
						class4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7, Class331.int_7 + 1400, Enum70.const_0));
						class4.bool_7 = true;
						this.class911_0.Add(class4);
					}
					else
					{
						class4.class26_0.Add(new Class746(TransformationType.Scale, 0.8f, 1.2f, Class331.int_7, Class331.int_7 + 600, Enum70.const_1));
						class4.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Class331.int_7 + 200, Enum70.const_0));
						class4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 400, Class331.int_7 + 1400, Enum70.const_0));
						class4.bool_7 = true;
						this.class911_0.Add(class4);
					}
				}
				if (class != null && enum >= Enum61.flag_5)
				{
					IEnumerable<Class531> enumerable = this.method_19(class, 150);
					foreach (Class531 current in enumerable)
					{
						current.vector2_1 = class304_2.EndPosition;
						int num6 = Class562.smethod_1(500, 1200);
						double num7 = Class562.smethod_3(6.2831853071795862);
						current.class26_0[0].vector2_0 = class304_2.EndPosition;
						current.class26_0[0].vector2_1 = class304_2.EndPosition + new Vector2((float)Math.Cos(num7), (float)Math.Sin(num7)) * (float)Class562.smethod_1(0, 35);
						current.class26_0[0].int_0 = Class331.int_7 - 100;
						current.class26_0[0].int_1 = Class331.int_7 + num6;
						current.class26_0[1].float_0 = Class802.class531_0.float_3;
						current.class26_0[1].int_0 = Class331.int_7;
						current.class26_0[1].int_1 = Class331.int_7 + num6;
						this.class911_0.Add(current);
					}
				}
				bool flag5 = class304_2.IsType(HitObjectType.Spinner);
				if (enum == Enum61.flag_3)
				{
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Class331.int_7 + Class297.int_7, Enum70.const_0));
					if (flag4)
					{
						if (Class62.class512_0 != null && Class115.class861_0.bStatus_0 != bStatus.Multiplaying && Class876.smethod_6(this.class623_0, Mods.SuddenDeath))
						{
							class2.class26_0.Add(new Class746(TransformationType.Scale, 2f, 6f, Class331.int_7, Class331.int_7 + 600, Enum70.const_0));
						}
						else
						{
							class2.class26_0.Add(new Class746(TransformationType.Scale, 2f, 1f, Class331.int_7, Class331.int_7 + Class297.int_7, Enum70.const_0));
						}
						float num8 = Class562.smethod_6(-0.15f, 0.15f);
						if (Class885.smethod_25() && Class62.Mode == PlayModes.Osu)
						{
							class2.class26_0.Add(new Class746(TransformationType.Movement, class304_2.EndPosition + new Vector2(0f, -5f), class304_2.EndPosition + new Vector2(0f, 40f), Class331.int_7, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_2));
						}
						class2.class26_0.Add(new Class746(TransformationType.Rotation, 0f, num8, Class331.int_7, Class331.int_7 + Class297.int_7, Enum70.const_0));
						class2.class26_0.Add(new Class746(TransformationType.Rotation, num8, num8 * 2f, Class331.int_7 + Class297.int_7, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_2));
					}
					class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + Class297.int_9, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_0));
				}
				else if (enum > Enum61.flag_5)
				{
					if (flag5 && !Class885.smethod_25())
					{
						Class531 class5 = new Class531(Class885.Load("spinner-osu", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_2, new Vector2(320f, 180f), (Class62.Mode == PlayModes.Osu) ? 0f : num3, false, Color.get_White(), null);
						this.vmethod_13(class5);
						this.class911_0.Add(class5);
					}
					this.vmethod_14(class2, flag4, class != null);
				}
				this.vmethod_11(class2);
				this.class911_0.Add(class2);
			}
			if (flag && text.Length == 0)
			{
				text = "b";
			}
			if (this.delegate34_0 != null)
			{
				this.delegate34_0(enum, text, class304_2);
			}
			if (this.class872_0 != null)
			{
				this.class872_0.method_17(class304_2);
			}
			return enum;
		}

		// Token: 0x0600217A RID: 8570
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_11(Class531 class531_0)
		{
		}

		// Token: 0x0600217B RID: 8571
		// RVA: 0x00018999 File Offset: 0x00016B99
		protected virtual Class731[] vmethod_12(string string_0)
		{
			return Class885.smethod_27(string_0, Enum112.flag_6, true);
		}

		// Token: 0x0600217C RID: 8572
		// RVA: 0x000C6384 File Offset: 0x000C4584
		protected virtual void vmethod_13(Class531 class531_0)
		{
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Class331.int_7 + Class297.int_7, Enum70.const_0));
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + Class297.int_9, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_0));
			this.class911_0.Add(class531_0);
		}

		// Token: 0x0600217D RID: 8573
		// RVA: 0x000C6404 File Offset: 0x000C4604
		protected virtual void vmethod_14(Class531 class531_0, bool bool_2, bool bool_3)
		{
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Class331.int_7 + (bool_3 ? 80 : Class297.int_7), Enum70.const_0));
			if (bool_2)
			{
				if (!bool_3)
				{
					class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.6f, 1.1f, Class331.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 0.8), Enum70.const_0));
					class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 0.9f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 1.2), Enum70.const_0));
					class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.9f, 1f, Class331.int_7 + Class297.int_7, (int)((double)Class331.int_7 + (double)Class297.int_7 * 1.4), Enum70.const_0));
				}
				else
				{
					class531_0.class26_0.Add(new Class746(TransformationType.Scale, 0.9f, 1.05f, Class331.int_7, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_0));
				}
			}
			class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + Class297.int_9, Class331.int_7 + Class297.int_9 + Class297.int_8, Enum70.const_0));
		}

		// Token: 0x06002187 RID: 8583
		// RVA: 0x000C698C File Offset: 0x000C4B8C
		internal virtual void vmethod_15()
		{
			Action<Class304> action = null;
			Editor editor_ = Editor.editor_0;
			this.int_14 = this.list_3.Count;
			int val = Class331.int_7 - ((editor_ == null || Class341.class606_20) ? this.PreEmpt : this.method_9());
			int num = Class331.int_7 + this.PreEmpt;
			if (editor_ != null)
			{
				val = Math.Min(val, editor_.int_8);
				num = Math.Max(num, editor_.int_9);
			}
			int num2 = this.list_3.BinarySearch(new Class330(this, val));
			if (num2 < 0)
			{
				num2 = ~num2;
			}
			int num3 = num2;
			while (num3 < this.int_14 - 1 && this.list_3[num3].StartTime <= num)
			{
				num3++;
			}
			if (num2 == this.int_14)
			{
				this.list_4.Clear();
				if (editor_ != null)
				{
					this.class911_0.list_2.Clear();
					return;
				}
			}
			else
			{
				this.list_4 = this.list_3.GetRange(num2, 1 + num3 - num2);
				if (editor_ != null)
				{
					this.class911_0.list_2.Clear();
					List<Class304> arg_121_0 = this.list_4;
					if (action == null)
					{
						action = new Action<Class304>(this.method_33);
					}
					arg_121_0.ForEach(action);
					if (this.class296_0.method_5() == PlayModes.Osu)
					{
						if (Class341.class606_22)
						{
							this.method_28(num2, num3);
						}
						if (Class341.class606_21)
						{
							this.method_31(num2, num3);
						}
					}
					if (Editor.editor_0.class371_0.list_1.Count > 0)
					{
						foreach (Class304 current in Editor.editor_0.class371_0.list_1)
						{
							if (!this.list_4.Contains(current))
							{
								if (current.IsType(HitObjectType.Slider))
								{
									Class321 class = current as Class321;
									Class306 class2 = class.class306_0;
									this.class911_0.Add(class2.class531_3);
									if (class.method_9().Count > 1)
									{
										class2 = class.method_9()[1];
										this.class911_0.Add(class2.class531_3);
									}
								}
								else
								{
									Class306 class2 = current as Class306;
									if (class2 != null)
									{
										this.class911_0.Add(class2.class531_3);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002188 RID: 8584
		// RVA: 0x000C6BF0 File Offset: 0x000C4DF0
		internal virtual void vmethod_16()
		{
			foreach (Class304 current in this.list_4)
			{
				current.vmethod_6();
				this.vmethod_17(current);
			}
		}

		// Token: 0x06002189 RID: 8585
		// RVA: 0x000C6C4C File Offset: 0x000C4E4C
		protected virtual void vmethod_17(Class304 class304_2)
		{
			if (Class802.bool_25 || !Class802.smethod_0())
			{
				if (class304_2.IsType(HitObjectType.Slider))
				{
					Class321 class = (Class321)class304_2;
					if (Class115.osuModes_1 == OsuModes.Play)
					{
						if (class.StartTime + this.HitWindow50 < Class331.int_7 && !class.vmethod_25() && Class115.osuModes_1 == OsuModes.Play)
						{
							this.vmethod_10(class.class306_0);
						}
						if (class.vmethod_15() <= Class331.int_7 && !class.bool_0)
						{
							this.vmethod_10(class);
							return;
						}
					}
				}
				else if (class304_2.IsType(HitObjectType.Spinner))
				{
					if (class304_2.vmethod_15() < Class331.int_7 && !class304_2.bool_0 && Class115.osuModes_1 == OsuModes.Play)
					{
						this.vmethod_10(class304_2);
						return;
					}
				}
				else if (class304_2.EndTime + this.HitWindow50 < Class331.int_7 && !class304_2.bool_0 && Class115.osuModes_1 == OsuModes.Play)
				{
					this.vmethod_10(class304_2);
				}
			}
		}

		// Token: 0x0600218E RID: 8590
		// RVA: 0x000C6F8C File Offset: 0x000C518C
		protected virtual void vmethod_18()
		{
			if (Class115.osuModes_1 == OsuModes.Edit)
			{
				return;
			}
			this.int_14 = this.list_3.Count;
			if (this.class296_0.int_6 > 5)
			{
				foreach (Class304 current in this.list_3)
				{
					Class321 class = current as Class321;
					if (class != null)
					{
						class.vmethod_24(true);
					}
				}
				this.method_28(0, -1);
			}
			else
			{
				this.method_29();
			}
			this.method_31(0, -1);
		}

		// Token: 0x06002193 RID: 8595
		// RVA: 0x0001B111 File Offset: 0x00019311
		protected virtual void vmethod_19(Class305 class305_0)
		{
			this.Add(class305_0, false);
		}

		// Token: 0x06002161 RID: 8545
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected virtual bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002194 RID: 8596
		// RVA: 0x0001B111 File Offset: 0x00019311
		protected virtual void vmethod_20(Class325 class325_0)
		{
			this.Add(class325_0, false);
		}

		// Token: 0x06002195 RID: 8597
		// RVA: 0x0001B111 File Offset: 0x00019311
		protected virtual void vmethod_21(Class320 class320_0)
		{
			this.Add(class320_0, false);
		}

		// Token: 0x06002197 RID: 8599
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_22()
		{
			return true;
		}

		// Token: 0x06002162 RID: 8546
		// RVA: 0x0001B04C File Offset: 0x0001924C
		internal virtual Class304 vmethod_3()
		{
			if (this.int_14 <= 0)
			{
				return null;
			}
			return this.list_3[0];
		}

		// Token: 0x06002163 RID: 8547
		// RVA: 0x0001B065 File Offset: 0x00019265
		internal virtual Class304 vmethod_4()
		{
			if (this.int_14 <= 0)
			{
				return null;
			}
			return this.list_3[this.int_14 - 1];
		}

		// Token: 0x06002166 RID: 8550
		// RVA: 0x0001B085 File Offset: 0x00019285
		protected virtual bool vmethod_5()
		{
			return Class466.Current.method_5() != PlayModes.Taiko;
		}

		// Token: 0x06002167 RID: 8551
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_6()
		{
			return true;
		}

		// Token: 0x06002168 RID: 8552
		internal abstract Class494 vmethod_7();

		// Token: 0x0600216A RID: 8554
		// RVA: 0x000C4E1C File Offset: 0x000C301C
		internal virtual void vmethod_8(bool bool_2, bool bool_3)
		{
			if (this.class296_0 != null)
			{
				this.SliderScoringPointDistance = 100.0 * this.class296_0.DifficultySliderMultiplier / this.class296_0.DifficultySliderTickRate;
				this.SpinnerRotationRatio = this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 3.0, 5.0, 7.5);
				this.HitWindow50 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 200.0, 150.0, 100.0);
				this.HitWindow100 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 140.0, 100.0, 60.0);
				this.HitWindow300 = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyOverall, 80.0, 50.0, 20.0);
				this.PreEmpt = (int)this.MapDifficultyRange((double)this.class296_0.DifficultyApproachRate, 1800.0, 1200.0, 450.0);
				this.float_1 = (float)((double)(Class115.float_3 / 8f) * (1.0 - 0.699999988079071 * this.AdjustDifficulty((double)this.class296_0.DifficultyCircleSize)));
				this.HitObjectRadius = this.float_1 / 2f / Class115.float_1 * 1.00041f;
				this.int_10 = (int)((float)this.PreEmpt * 2f / 3f);
				if (bool_3)
				{
					Class331.smethod_6(true);
				}
				this.float_0 = this.float_1 / (float)Class297.int_5;
				if (this.class911_0 != null)
				{
					this.class911_0.float_4 = this.float_0;
				}
				this.StackOffset = this.HitObjectRadius / 10f;
				if (bool_2)
				{
					this.method_12(false);
				}
			}
		}

		// Token: 0x06002176 RID: 8566
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_9(Class304 class304_2)
		{
		}
	}
}
