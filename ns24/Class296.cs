using Amib.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns10;
using ns14;
using ns18;
using ns19;
using ns23;
using ns25;
using ns26;
using ns29;
using ns30;
using ns31;
using ns64;
using ns69;
using ns76;
using ns8;
using ns90;
using osu;
using osu.Audio;
using osu.GameModes.Select;
using osu.GameplayElements;
using osu.GameplayElements.Beatmaps;
using osu_common;
using osu_common.Bancho;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns24
{
	// Token: 0x02000536 RID: 1334
	internal sealed class Class296 : BeatmapBase, IComparable<Class296>, bSerializable
	{
		// Token: 0x02000537 RID: 1335
		internal sealed class Class708 : IComparer<Class296>
		{
			// Token: 0x06002B89 RID: 11145
			// RVA: 0x0002145D File Offset: 0x0001F65D
			public int Compare(Class296 x, Class296 y)
			{
				if (x.string_3 == null)
				{
					if (y.string_3 == null)
					{
						return 0;
					}
					return 1;
				}
				else
				{
					if (y.string_3 == null)
					{
						return -1;
					}
					return x.string_3.CompareTo(y.string_3);
				}
			}
		}

		// Token: 0x02000539 RID: 1337
		[CompilerGenerated]
		private sealed class Class709
		{
			// Token: 0x0200053A RID: 1338
			private sealed class Class710
			{
				// Token: 0x0400244A RID: 9290
				public Class296.Class709 class709_0;

				// Token: 0x0400244B RID: 9291
				public Dictionary<int, double> dictionary_0;

				// Token: 0x06002B8D RID: 11149
				// RVA: 0x0002148E File Offset: 0x0001F68E
				public void method_0()
				{
					this.class709_0.class296_0.method_17(this.class709_0.playModes_0, this.dictionary_0);
					this.class709_0.voidDelegate_0();
				}
			}

			// Token: 0x04002447 RID: 9287
			public Class296 class296_0;

			// Token: 0x04002448 RID: 9288
			public PlayModes playModes_0;

			// Token: 0x04002449 RID: 9289
			public VoidDelegate voidDelegate_0;

			// Token: 0x06002B8B RID: 11147
			// RVA: 0x0011B6EC File Offset: 0x001198EC
			public void method_0()
			{
				Class296.Class709.Class710 class = new Class296.Class709.Class710();
				class.class709_0 = this;
				lock (this.class296_0)
				{
					if (this.class296_0.bool_7)
					{
						return;
					}
					this.class296_0.bool_7 = true;
				}
				class.dictionary_0 = this.class296_0.method_22(this.playModes_0);
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			}
		}

		// Token: 0x0200053B RID: 1339
		[CompilerGenerated]
		private sealed class Class711
		{
			// Token: 0x0400244D RID: 9293
			public Class296 class296_0;

			// Token: 0x0400244C RID: 9292
			public PlayModes playModes_0;

			// Token: 0x06002B8F RID: 11151
			// RVA: 0x000214C1 File Offset: 0x0001F6C1
			public void method_0()
			{
				if (Class296.class296_0 == this.class296_0)
				{
					if (Class296.playModes_1 == this.playModes_0)
					{
						Class169.smethod_0(this.class296_0.class133_0);
						return;
					}
				}
				this.class296_0.class133_0 = null;
			}
		}

		// Token: 0x0200053C RID: 1340
		[CompilerGenerated]
		private sealed class Class712
		{
			// Token: 0x0400244E RID: 9294
			public Class512 class512_0;

			// Token: 0x06002B91 RID: 11153
			// RVA: 0x000214FD File Offset: 0x0001F6FD
			public bool method_0(Class512 class512_1)
			{
				return class512_1.string_2 == this.class512_0.string_2;
			}
		}

		// Token: 0x0200053D RID: 1341
		[CompilerGenerated]
		private sealed class Class713
		{
			// Token: 0x04002452 RID: 9298
			public bool bool_0;

			// Token: 0x0400244F RID: 9295
			public Class178 class178_0;

			// Token: 0x04002450 RID: 9296
			public Class296 class296_0;

			// Token: 0x04002451 RID: 9297
			public string string_0;

			// Token: 0x06002B93 RID: 11155
			// RVA: 0x0011B778 File Offset: 0x00119978
			public void method_0(Class296 class296_1)
			{
				if (this.bool_0)
				{
					class296_1.method_4(this.string_0);
					class296_1.string_9 = Path.GetFileName(class296_1.string_9);
					class296_1.string_1 = Path.GetFileName(class296_1.string_1);
					class296_1.class178_0 = this.class178_0;
					class296_1.bool_10 = true;
				}
				this.class178_0.method_18(class296_1.string_9, class296_1.int_2);
			}
		}

		// Token: 0x02000538 RID: 1336
		internal enum Enum64
		{
			// Token: 0x04002443 RID: 9283
			const_0,
			// Token: 0x04002444 RID: 9284
			const_1,
			// Token: 0x04002445 RID: 9285
			const_2,
			// Token: 0x04002446 RID: 9286
			const_3
		}

		// Token: 0x040023E3 RID: 9187
		internal bool bool_0;

		// Token: 0x040023E7 RID: 9191
		private bool bool_1 = true;

		// Token: 0x0400240D RID: 9229
		internal bool bool_10;

		// Token: 0x0400240E RID: 9230
		internal bool bool_11 = true;

		// Token: 0x0400240F RID: 9231
		internal bool bool_12;

		// Token: 0x04002410 RID: 9232
		internal bool bool_13;

		// Token: 0x04002423 RID: 9251
		internal bool bool_14 = true;

		// Token: 0x04002427 RID: 9255
		internal bool bool_15;

		// Token: 0x0400242A RID: 9258
		internal bool bool_16;

		// Token: 0x0400242C RID: 9260
		internal bool bool_17;

		// Token: 0x04002430 RID: 9264
		internal bool bool_18;

		// Token: 0x04002431 RID: 9265
		internal bool bool_19;

		// Token: 0x040023EC RID: 9196
		internal bool bool_2;

		// Token: 0x04002432 RID: 9266
		private bool bool_20;

		// Token: 0x04002438 RID: 9272
		public bool bool_21;

		// Token: 0x04002439 RID: 9273
		public bool bool_22;

		// Token: 0x0400243A RID: 9274
		public bool bool_23;

		// Token: 0x0400243B RID: 9275
		public bool bool_24;

		// Token: 0x0400243C RID: 9276
		public bool bool_25;

		// Token: 0x0400243D RID: 9277
		public bool bool_26;

		// Token: 0x040023ED RID: 9197
		internal bool bool_3;

		// Token: 0x040023EE RID: 9198
		internal bool bool_4;

		// Token: 0x040023FB RID: 9211
		internal bool bool_5;

		// Token: 0x040023FC RID: 9212
		internal bool bool_6;

		// Token: 0x04002409 RID: 9225
		private bool bool_7;

		// Token: 0x0400240B RID: 9227
		internal bool bool_8;

		// Token: 0x0400240C RID: 9228
		internal bool bool_9;

		// Token: 0x04002433 RID: 9267
		private Class133 class133_0;

		// Token: 0x040023E2 RID: 9186
		private Class178 class178_0;

		// Token: 0x04002434 RID: 9268
		private static Class296 class296_0;

		// Token: 0x04002414 RID: 9236
		internal Class512 class512_0;

		// Token: 0x040023E8 RID: 9192
		internal Color color_0;

		// Token: 0x04002441 RID: 9281
		[CompilerGenerated]
		private static Comparison<Class512> comparison_0;

		// Token: 0x040023FD RID: 9213
		internal DateTime dateTime_0;

		// Token: 0x040023FE RID: 9214
		internal DateTime dateTime_1;

		// Token: 0x04002436 RID: 9270
		private Delegate52 delegate52_0;

		// Token: 0x04002408 RID: 9224
		private Dictionary<int, double>[] dictionary_0 = new Dictionary<int, double>[Enum.GetNames(typeof(PlayModes)).Length];

		// Token: 0x04002405 RID: 9221
		private double double_0;

		// Token: 0x04002406 RID: 9222
		private double double_1;

		// Token: 0x04002407 RID: 9223
		private double double_2;

		// Token: 0x040023F5 RID: 9205
		internal Enum65 enum65_0;

		// Token: 0x04002415 RID: 9237
		internal float float_0;

		// Token: 0x04002422 RID: 9250
		internal float float_1;

		// Token: 0x04002425 RID: 9253
		internal float float_2 = 1f;

		// Token: 0x040023E1 RID: 9185
		private static readonly int[] int_0 = new int[]
		{
			20150404,
			20140610,
			20141123,
			20150110
		};

		// Token: 0x040023E6 RID: 9190
		internal int int_1;

		// Token: 0x04002404 RID: 9220
		internal int int_10;

		// Token: 0x04002411 RID: 9233
		internal int int_11;

		// Token: 0x04002413 RID: 9235
		internal int int_12;

		// Token: 0x04002417 RID: 9239
		internal int int_13;

		// Token: 0x0400241D RID: 9245
		internal int int_14;

		// Token: 0x0400241E RID: 9246
		internal int int_15 = 100;

		// Token: 0x04002426 RID: 9254
		internal int int_16;

		// Token: 0x04002429 RID: 9257
		internal int int_17;

		// Token: 0x0400242B RID: 9259
		internal int int_18;

		// Token: 0x040023EB RID: 9195
		internal int int_2;

		// Token: 0x040023EF RID: 9199
		internal int int_3 = -1;

		// Token: 0x040023F0 RID: 9200
		internal int int_4;

		// Token: 0x040023F1 RID: 9201
		internal int int_5;

		// Token: 0x040023F2 RID: 9202
		internal int int_6;

		// Token: 0x040023F3 RID: 9203
		internal int int_7;

		// Token: 0x040023F6 RID: 9206
		internal int int_8;

		// Token: 0x04002403 RID: 9219
		internal int int_9;

		// Token: 0x04002416 RID: 9238
		internal List<Class512> list_0 = new List<Class512>();

		// Token: 0x0400242D RID: 9261
		internal List<Class340> list_1 = new List<Class340>();

		// Token: 0x0400242F RID: 9263
		internal long long_0;

		// Token: 0x0400243E RID: 9278
		public int? nullable_0;

		// Token: 0x0400243F RID: 9279
		public object object_0 = true;

		// Token: 0x04002437 RID: 9271
		internal OverlayPosition overlayPosition_0;

		// Token: 0x0400241C RID: 9244
		private PlayModes playModes_0;

		// Token: 0x04002435 RID: 9269
		private static PlayModes playModes_1;

		// Token: 0x04002440 RID: 9280
		[CompilerGenerated]
		private static Predicate<Class340> predicate_0;

		// Token: 0x04002418 RID: 9240
		internal Rankings rankings_0 = Rankings.N;

		// Token: 0x04002419 RID: 9241
		internal Rankings rankings_1 = Rankings.N;

		// Token: 0x0400241A RID: 9242
		internal Rankings rankings_2 = Rankings.N;

		// Token: 0x0400241B RID: 9243
		internal Rankings rankings_3 = Rankings.N;

		// Token: 0x040023FF RID: 9215
		internal SampleSet sampleSet_0;

		// Token: 0x040023E4 RID: 9188
		internal string string_0;

		// Token: 0x040023E5 RID: 9189
		internal string string_1;

		// Token: 0x04002412 RID: 9234
		internal string string_10 = string.Empty;

		// Token: 0x0400241F RID: 9247
		internal string string_11 = string.Empty;

		// Token: 0x04002420 RID: 9248
		internal string string_12;

		// Token: 0x04002421 RID: 9249
		internal string string_13 = string.Empty;

		// Token: 0x04002428 RID: 9256
		internal string string_14 = string.Empty;

		// Token: 0x0400242E RID: 9262
		private string string_15;

		// Token: 0x040023E9 RID: 9193
		internal string string_2;

		// Token: 0x040023EA RID: 9194
		internal string string_3;

		// Token: 0x040023F4 RID: 9204
		internal string string_4;

		// Token: 0x040023FA RID: 9210
		internal string string_5 = string.Empty;

		// Token: 0x04002400 RID: 9216
		internal string string_6;

		// Token: 0x04002401 RID: 9217
		internal string string_7;

		// Token: 0x04002402 RID: 9218
		internal string string_8;

		// Token: 0x0400240A RID: 9226
		internal string string_9 = string.Empty;

		// Token: 0x04002424 RID: 9252
		internal SubmissionStatus submissionStatus_0;

		// Token: 0x040023F7 RID: 9207
		internal ushort ushort_0;

		// Token: 0x040023F8 RID: 9208
		internal ushort ushort_1;

		// Token: 0x040023F9 RID: 9209
		internal ushort ushort_2;

		// Token: 0x06002B38 RID: 11064
		// RVA: 0x001178C4 File Offset: 0x00115AC4
		public Class296()
		{
			for (int i = 0; i < this.dictionary_0.Length; i++)
			{
				this.dictionary_0[i] = new Dictionary<int, double>();
			}
		}

		// Token: 0x06002B39 RID: 11065
		// RVA: 0x001179C8 File Offset: 0x00115BC8
		internal Class296(string string_16)
		{
			this.string_9 = Path.GetFileName(string_16);
			this.method_4(Path.GetDirectoryName(string_16));
			this.method_11();
		}

		// Token: 0x06002B7F RID: 11135
		// RVA: 0x000213A9 File Offset: 0x0001F5A9
		internal void Cleanup()
		{
			if (this.class178_0 != null)
			{
				Class134.smethod_2(this.class178_0);
				this.class178_0 = null;
			}
		}

		// Token: 0x06002B3A RID: 11066
		// RVA: 0x00021167 File Offset: 0x0001F367
		internal Class296 Clone()
		{
			return new Class296(Path.Combine(this.method_3(), this.string_9));
		}

		// Token: 0x06002B63 RID: 11107
		// RVA: 0x0001ACFD File Offset: 0x00018EFD
		public int CompareTo(Class296 obj)
		{
			return this.string_9.CompareTo(obj.string_9);
		}

		// Token: 0x06002B2D RID: 11053
		// RVA: 0x00021080 File Offset: 0x0001F280
		internal bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x06002B2E RID: 11054
		// RVA: 0x00021088 File Offset: 0x0001F288
		internal void method_1(bool bool_27)
		{
			this.bool_1 = bool_27;
		}

		// Token: 0x06002B37 RID: 11063
		// RVA: 0x00021151 File Offset: 0x0001F351
		internal bool method_10()
		{
			return this.submissionStatus_0 > SubmissionStatus.Unknown && this.submissionStatus_0 < SubmissionStatus.EditableCutoff;
		}

		// Token: 0x06002B3B RID: 11067
		// RVA: 0x00117ACC File Offset: 0x00115CCC
		internal bool method_11()
		{
			this.list_1.Clear();
			bool flag;
			if (flag = (Class331.smethod_32() == this))
			{
				Class331.smethod_5();
				Class331.smethod_75(Enum38.const_0);
			}
			this.int_14 = -1;
			this.int_1 = 0;
			this.int_11 = 0;
			this.int_9 = 0;
			this.ushort_1 = 0;
			this.ushort_0 = 0;
			this.ushort_2 = 0;
			this.int_6 = 14;
			this.int_17 = 0;
			this.float_1 = 0.7f;
			this.enum65_0 = Enum65.const_1;
			this.overlayPosition_0 = OverlayPosition.NoChange;
			this.bool_5 = false;
			this.string_2 = null;
			this.method_6(PlayModes.Osu);
			this.sampleSet_0 = SampleSet.Normal;
			this.bool_9 = false;
			bool flag2 = false;
			if (this.bool_10)
			{
				if (this.method_44() == null)
				{
					return false;
				}
				if (this.int_3 <= 0)
				{
					this.int_3 = Convert.ToInt32(this.method_44().method_20(Enum9.const_9));
				}
				this.Title = this.method_44().method_20(Enum9.const_0);
				this.method_9(Path.Combine("Data\\e\\", this.int_3 + " - " + this.Title));
			}
			using (Stream stream = this.method_61())
			{
				if (stream == null)
				{
					this.bool_4 = false;
					this.int_3 = -1;
					this.int_2 = 0;
					return false;
				}
				this.bool_4 = true;
				using (StreamReader streamReader = new StreamReader(stream))
				{
					this.method_66();
					this.dateTime_1 = File.GetLastWriteTimeUtc(this.bool_10 ? this.method_3() : this.method_46());
					FileSection fileSection = FileSection.Unknown;
					int num = -1;
					int num2 = -1;
					int num3 = -1;
					string text = string.Empty;
					string text2 = string.Empty;
					int num4 = 0;
					char[] separator = new char[]
					{
						','
					};
					try
					{
						if (!streamReader.EndOfStream)
						{
							string text3 = streamReader.ReadLine();
							if (text3.IndexOf("osu file format") == 0)
							{
								this.int_6 = int.Parse(text3.Remove(0, text3.LastIndexOf('v') + 1));
								if (flag)
								{
									Class331.smethod_75((this.int_6 < 4) ? Enum38.const_1 : Enum38.const_0);
								}
								int arg_20B_1;
								if (this.int_6 < 5)
								{
									if (Class115.osuModes_1 == OsuModes.Edit)
									{
										arg_20B_1 = 24;
										goto IL_20B;
									}
								}
								arg_20B_1 = 0;
								IL_20B:
								this.int_17 = arg_20B_1;
							}
						}
						while (!streamReader.EndOfStream)
						{
							string text4 = streamReader.ReadLine().Trim();
							if (text4.Length != 0)
							{
								string text5 = string.Empty;
								string text6 = string.Empty;
								if (fileSection != FileSection.HitObjects)
								{
									int num5 = text4.IndexOf(':');
									if (num5 >= 0)
									{
										text5 = text4.Remove(num5).Trim();
										text6 = text4.Remove(0, num5 + 1).Trim();
									}
									else if (text4[0] == '[')
									{
										try
										{
											fileSection = (FileSection)Enum.Parse(typeof(FileSection), text4.Trim(new char[]
											{
												'[',
												']'
											}));
											continue;
										}
										catch
										{
											continue;
										}
									}
								}
								FileSection fileSection2 = fileSection;
								if (fileSection2 <= FileSection.TimingPoints)
								{
									switch (fileSection2)
									{
									case FileSection.General:
									{
										string key;
										switch (key = text5)
										{
										case "SampleSet":
											this.sampleSet_0 = (SampleSet)Enum.Parse(typeof(SampleSet), text6);
											if (flag)
											{
												Class331.sampleSet_0 = this.sampleSet_0;
											}
											break;
										case "CustomSamples":
											if (flag)
											{
												Class331.smethod_75((text6[0] == '1') ? Enum38.const_1 : Enum38.const_0);
											}
											break;
										case "OverlayPosition":
											this.overlayPosition_0 = (OverlayPosition)Enum.Parse(typeof(OverlayPosition), text6, true);
											break;
										case "Countdown":
											this.enum65_0 = (Enum65)int.Parse(text6);
											break;
										case "AudioFilename":
											if (text6.Length > 0)
											{
												this.string_1 = text6;
											}
											break;
										case "AudioHash":
											this.string_0 = text6;
											break;
										case "AudioLeadIn":
											this.int_1 = int.Parse(text6);
											break;
										case "PreviewTime":
											this.int_14 = int.Parse(text6);
											break;
										case "SampleVolume":
											this.int_15 = int.Parse(text6);
											break;
										case "StackLeniency":
											this.float_1 = Math.Max(0f, Math.Min(1f, float.Parse(text6, Class115.numberFormatInfo_0)));
											break;
										case "Mode":
											this.method_6((PlayModes)int.Parse(text6));
											break;
										case "LetterboxInBreaks":
											this.bool_11 = (text6[0] == '1');
											break;
										case "WidescreenStoryboard":
											this.bool_12 = (text6[0] == '1');
											break;
										case "SkinPreference":
											this.string_11 = text6;
											break;
										case "AlwaysShowPlayfield":
											this.bool_0 = (text6[0] == '1');
											break;
										case "EpilepsyWarning":
											this.bool_21 = (text6[0] == '1');
											break;
										case "CountdownOffset":
											this.int_8 = Math.Max(Math.Min(int.Parse(text6), 3), 0);
											break;
										case "SpecialStyle":
											this.bool_16 = (text6[0] == '1');
											break;
										case "TimelineZoom":
											this.float_2 = float.Parse(text6);
											break;
										case "SamplesMatchPlaybackRate":
											this.bool_17 = (text6[0] == '1');
											break;
										}
										break;
									}
									case FileSection.Colours:
										this.bool_5 = true;
										break;
									default:
									{
										string key2;
										if (fileSection2 != FileSection.Metadata)
										{
											if (fileSection2 == FileSection.TimingPoints)
											{
												Class340 class = Class297.smethod_2(text4, this.int_17, this.int_15, this.sampleSet_0);
												if (class != null)
												{
													this.list_1.Add(class);
												}
											}
										}
										else
											switch (key2 = text5)
											{
											case "Artist":
												this.Artist = text6;
												break;
											case "ArtistUnicode":
												this.ArtistUnicode = text6;
												break;
											case "Title":
												this.Title = text6;
												break;
											case "TitleUnicode":
												this.TitleUnicode = text6;
												break;
											case "Creator":
												this.string_5 = text6;
												break;
											case "Version":
												this.string_14 = text6;
												break;
											case "Tags":
												this.Tags = text6;
												break;
											case "Source":
												this.string_13 = text6;
												break;
											case "BeatmapID":
												if (this.int_2 == 0)
												{
													this.int_2 = Convert.ToInt32(text6);
												}
												break;
											case "BeatmapSetID":
												if (this.int_3 == -1)
												{
													this.int_3 = Convert.ToInt32(text6);
												}
												break;
											}
										break;
									}
									}
								}
								else if (fileSection2 != FileSection.Events)
								{
									if (fileSection2 != FileSection.HitObjects)
									{
										if (fileSection2 == FileSection.Difficulty)
										{
											string a;
											if ((a = text5) != null)
											{
												if (!(a == "HPDrainRate"))
												{
													if (!(a == "CircleSize"))
													{
														if (!(a == "OverallDifficulty"))
														{
															if (!(a == "SliderMultiplier"))
															{
																if (!(a == "SliderTickRate"))
																{
																	if (a == "ApproachRate")
																	{
																		if (this.int_6 >= 13)
																		{
																			this.DifficultyApproachRate = Math.Min(10f, Math.Max(0f, float.Parse(text6, Class115.numberFormatInfo_0)));
																		}
																		else
																		{
																			this.DifficultyApproachRate = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
																		}
																		flag2 = true;
																	}
																}
																else
																{
																	this.DifficultySliderTickRate = Math.Max(0.5, Math.Min(8.0, double.Parse(text6, Class115.numberFormatInfo_0)));
																}
															}
															else
															{
																this.DifficultySliderMultiplier = Math.Max(0.4, Math.Min(3.6, double.Parse(text6, Class115.numberFormatInfo_0)));
															}
														}
														else
														{
															if (this.int_6 >= 13)
															{
																this.DifficultyOverall = Math.Min(10f, Math.Max(0f, float.Parse(text6, Class115.numberFormatInfo_0)));
															}
															else
															{
																this.DifficultyOverall = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
															}
															if (!flag2)
															{
																this.DifficultyApproachRate = this.DifficultyOverall;
															}
														}
													}
													else if (this.int_6 >= 13)
													{
														if (this.method_5() == PlayModes.OsuMania)
														{
															this.DifficultyCircleSize = Math.Min(18f, Math.Max(1f, float.Parse(text6, Class115.numberFormatInfo_0)));
														}
														else
														{
															this.DifficultyCircleSize = Math.Min(10f, Math.Max(0f, float.Parse(text6, Class115.numberFormatInfo_0)));
														}
													}
													else
													{
														this.DifficultyCircleSize = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
													}
												}
												else if (this.int_6 >= 13)
												{
													this.DifficultyHpDrainRate = Math.Min(10f, Math.Max(0f, float.Parse(text6, Class115.numberFormatInfo_0)));
												}
												else
												{
													this.DifficultyHpDrainRate = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
												}
											}
										}
									}
									else
									{
										string[] array = text4.Split(separator, 7);
										if (num == -1)
										{
											num = int.Parse(array[2]);
										}
										int num8 = Convert.ToInt32(array[3]) & 139;
										int num9 = num8;
										switch (num9)
										{
										case 1:
											this.ushort_0 += 1;
											text = array[2];
											text2 = text;
											break;
										case 2:
											this.ushort_1 += 1;
											text = array[2];
											text2 = text;
											break;
										default:
											if (num9 != 8)
											{
												if (num9 == 128)
												{
													this.ushort_1 += 1;
													text = array[5].Split(new char[]
													{
														':'
													})[0];
													text2 = text;
												}
											}
											else
											{
												this.ushort_2 += 1;
												text = array[2];
												text2 = array[5];
											}
											break;
										}
										this.int_11++;
									}
								}
								else
								{
									char c = text4[0];
									switch (c)
									{
									case '0':
									{
										string[] array = text4.Split(new char[]
										{
											','
										});
										this.string_2 = array[2].Trim(new char[]
										{
											'"'
										});
										break;
									}
									case '1':
										break;
									case '2':
									{
										string[] array = text4.Split(new char[]
										{
											','
										});
										num4 += int.Parse(array[2]) - int.Parse(array[1]);
										break;
									}
									case '3':
									{
										string[] array = text4.Split(new char[]
										{
											','
										});
										this.color_0 = new Color(byte.Parse(array[2]), byte.Parse(array[3]), byte.Parse(array[4]));
										break;
									}
									default:
										if (c == 'S')
										{
											if (this.string_2 == null && text4[1] == 'P')
											{
												string[] array = text4.Split(new char[]
												{
													','
												});
												this.string_2 = array[3].Trim(new char[]
												{
													'"'
												});
											}
										}
										break;
									}
								}
							}
						}
					}
					catch (Exception)
					{
						Class723.smethod_1("Processing beatmap's headers failed.  This map is likely corrupt!", 3000);
					}
					if (this.int_3 <= 0 && this.submissionStatus_0 != SubmissionStatus.NotSubmitted && this.string_4 != null)
					{
						string[] array2 = this.string_4.Split(new char[]
						{
							Path.DirectorySeparatorChar
						})[0].Split(new char[]
						{
							' '
						});
						if (array2.Length > 0 && !int.TryParse(array2[0], out this.int_3))
						{
							this.int_3 = -1;
						}
					}
					this.method_53();
					if (text.Length > 0)
					{
						num2 = int.Parse(text);
					}
					if (text2.Length > 0)
					{
						num3 = int.Parse(text2);
					}
					this.int_9 = (num2 - num - num4) / 1000;
					this.int_10 = (num3 - num - num4) / 1000;
					this.method_1(this.method_68(this.string_1));
					this.int_16 = num3;
					this.method_67();
					this.bool_8 = true;
				}
			}
			return true;
		}

		// Token: 0x06002B3C RID: 11068
		// RVA: 0x00118938 File Offset: 0x00116B38
		internal double method_12()
		{
			return (double)((this.DifficultyHpDrainRate + this.DifficultyOverall + this.DifficultyCircleSize + Class778.smethod_2((float)this.int_11 / (float)this.int_9 * 8f, 0f, 16f)) / 38f * 5f);
		}

		// Token: 0x06002B3D RID: 11069
		// RVA: 0x0011898C File Offset: 0x00116B8C
		internal int method_13()
		{
			return (int)Math.Round((double)((this.DifficultyHpDrainRate + this.DifficultyOverall + this.DifficultyCircleSize + Class778.smethod_2((float)this.int_11 / (float)this.int_9 * 8f, 0f, 16f)) / 38f * 5f));
		}

		// Token: 0x06002B3E RID: 11070
		// RVA: 0x001189E8 File Offset: 0x00116BE8
		internal double method_14()
		{
			if (this.double_0 > 0.0)
			{
				return this.double_0;
			}
			int num = (int)(this.ushort_0 + 2 * this.ushort_1 + 3 * this.ushort_2);
			double num2 = (double)num / (double)this.int_9;
			if (num != 0 && this.list_1.Count != 0)
			{
				double num3;
				if ((double)((float)this.ushort_1 / (float)num) < 0.1)
				{
					num3 = (double)(this.DifficultyHpDrainRate + this.DifficultyOverall + this.DifficultyCircleSize);
				}
				else
				{
					num3 = ((double)(this.DifficultyHpDrainRate + this.DifficultyOverall + this.DifficultyCircleSize) + Math.Max(0.0, Math.Min(4.0, 1000.0 / this.list_1[0].double_0 * this.DifficultySliderMultiplier - 1.5) * 2.5)) * 0.75;
				}
				double val;
				if (num3 > 21.0)
				{
					val = (Math.Min(num3, 30.0) / 3.0 * 4.0 + Math.Min(20.0 - 0.032 * Math.Pow(num2 - 5.0, 4.0), 20.0)) / 10.0;
				}
				else if (num2 >= 2.5)
				{
					val = (Math.Min(num3, 18.0) / 18.0 * 10.0 + Math.Min(40.0 - 40.0 / Math.Pow(5.0, 3.5) * Math.Pow(Math.Min(num2, 5.0) - 5.0, 4.0), 40.0)) / 10.0;
				}
				else if (num2 < 1.0)
				{
					val = Math.Min(num3, 18.0) / 18.0 * 10.0 / 10.0 + 0.25;
				}
				else
				{
					val = (Math.Min(num3, 18.0) / 18.0 * 10.0 + Math.Min(25.0 * (num2 - 1.0), 40.0)) / 10.0;
				}
				this.double_0 = Math.Min(5.0, val);
				return this.double_0;
			}
			return 0.0;
		}

		// Token: 0x06002B3F RID: 11071
		// RVA: 0x00118CC4 File Offset: 0x00116EC4
		public Class461 method_15(PlayModes playModes_2)
		{
			switch (playModes_2)
			{
			case PlayModes.Taiko:
				return new Class465(this);
			case PlayModes.CatchTheBeat:
				return new Class462(this);
			case PlayModes.OsuMania:
				return new Class463(this, Class876.class623_0 & Mods.KeyMod);
			default:
				return new Class464(this);
			}
		}

		// Token: 0x06002B40 RID: 11072
		// RVA: 0x0002117F File Offset: 0x0001F37F
		public double method_16(PlayModes playModes_2, Mods mods_0)
		{
			mods_0 = Class461.smethod_1(mods_0, playModes_2, this);
			if (!this.dictionary_0[(int)playModes_2].ContainsKey((int)mods_0))
			{
				return -1.0;
			}
			return this.dictionary_0[(int)playModes_2][(int)mods_0];
		}

		// Token: 0x06002B41 RID: 11073
		// RVA: 0x00118D14 File Offset: 0x00116F14
		internal void method_17(PlayModes playModes_2, Dictionary<int, double> dictionary_1)
		{
			Dictionary<int, double> dictionary = this.dictionary_0[(int)playModes_2];
			foreach (KeyValuePair<int, double> current in dictionary_1)
			{
				dictionary[current.Key] = current.Value;
			}
		}

		// Token: 0x06002B42 RID: 11074
		// RVA: 0x000211B3 File Offset: 0x0001F3B3
		internal void method_18()
		{
			this.method_19(this.method_29());
		}

		// Token: 0x06002B43 RID: 11075
		// RVA: 0x000211C1 File Offset: 0x0001F3C1
		internal void method_19(PlayModes playModes_2)
		{
			this.method_17(playModes_2, this.method_22(playModes_2));
		}

		// Token: 0x06002B2F RID: 11055
		// RVA: 0x00021091 File Offset: 0x0001F291
		internal bool method_2()
		{
			return Class115.osuModes_1 == OsuModes.Edit || Class115.class61_0 is Class63;
		}

		// Token: 0x06002B44 RID: 11076
		// RVA: 0x000211D1 File Offset: 0x0001F3D1
		public void method_20(SmartThreadPool smartThreadPool_0, WorkItemPriority workItemPriority_0, VoidDelegate voidDelegate_0)
		{
			this.method_21(smartThreadPool_0, workItemPriority_0, this.method_29(), voidDelegate_0);
		}

		// Token: 0x06002B45 RID: 11077
		// RVA: 0x00118D7C File Offset: 0x00116F7C
		public void method_21(SmartThreadPool smartThreadPool_0, WorkItemPriority workItemPriority_0, PlayModes playModes_2, VoidDelegate voidDelegate_0)
		{
			Class296.Class709 class = new Class296.Class709();
			class.playModes_0 = playModes_2;
			class.voidDelegate_0 = voidDelegate_0;
			class.class296_0 = this;
			if (this.method_16(class.playModes_0, Class876.class623_0) >= 0.0)
			{
				return;
			}
			this.bool_7 = false;
			smartThreadPool_0.QueueWorkItem(new Action(class.method_0), workItemPriority_0);
		}

		// Token: 0x06002B46 RID: 11078
		// RVA: 0x00118DE4 File Offset: 0x00116FE4
		public Dictionary<int, double> method_22(PlayModes playModes_2)
		{
			Class461 class = this.method_15(playModes_2);
			Dictionary<int, double> dictionary = new Dictionary<int, double>();
			Mods[] array = class.vmethod_0();
			for (int i = 0; i < array.Length; i++)
			{
				Mods mods = array[i];
				dictionary[(int)mods] = class.method_2(mods, null);
			}
			class.Dispose();
			return dictionary;
		}

		// Token: 0x06002B47 RID: 11079
		// RVA: 0x00118E34 File Offset: 0x00117034
		internal double method_23()
		{
			if (this.double_1 > 0.0)
			{
				return this.double_1;
			}
			float num;
			if (this.int_9 == 0)
			{
				num = 10000f;
			}
			else
			{
				num = (float)this.int_9;
			}
			if (this.method_5() == PlayModes.OsuMania)
			{
				this.double_1 = ((double)(this.DifficultyHpDrainRate + this.DifficultyCircleSize) / 1.5 + (double)Math.Max((float)this.int_11 / num * 9f, 0f)) / 38.0 * 5.0 / 1.5;
			}
			else
			{
				this.double_1 = ((double)(this.DifficultyHpDrainRate + Class778.smethod_2(this.DifficultyApproachRate, 4f, 7f)) / 1.5 + (double)Math.Max((float)this.int_11 / num * 9f, 0f)) / 38.0 * 5.0 / 1.15;
			}
			this.double_1 = Math.Min(this.double_1, 12.0);
			return this.double_1;
		}

		// Token: 0x06002B48 RID: 11080
		// RVA: 0x00118F64 File Offset: 0x00117164
		internal double method_24()
		{
			if (this.double_2 > 0.0)
			{
				return this.double_2;
			}
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				double num = (this.int_9 == 0) ? ((this.list_1[this.list_1.Count - 1].double_1 + 1.0) / 1000.0) : ((double)this.int_9);
				float num2 = (float)this.ushort_0 + (float)this.ushort_1 * 1.2f;
				if (num2 == 0f)
				{
					this.double_2 = 0.0;
				}
				else
				{
					this.double_2 = Math.Min((double)(this.DifficultyHpDrainRate / 14f + this.DifficultyOverall / 12f) + (double)num2 / num / 2.3 * Math.Pow(1.04, (double)(this.DifficultyCircleSize - 3f)), 5.0);
				}
				return this.double_2;
			}
			return 0.0;
		}

		// Token: 0x06002B49 RID: 11081
		// RVA: 0x00119080 File Offset: 0x00117280
		internal void method_25()
		{
			this.double_2 = 0.0;
			this.double_1 = 0.0;
			this.double_0 = 0.0;
			Dictionary<int, double>[] array = this.dictionary_0;
			for (int i = 0; i < array.Length; i++)
			{
				Dictionary<int, double> dictionary = array[i];
				dictionary.Clear();
			}
			lock (this)
			{
				this.bool_7 = false;
			}
		}

		// Token: 0x06002B4A RID: 11082
		// RVA: 0x000211E2 File Offset: 0x0001F3E2
		internal double method_26()
		{
			return this.method_16(this.method_29(), Class876.class623_0);
		}

		// Token: 0x06002B4B RID: 11083
		// RVA: 0x000211FA File Offset: 0x0001F3FA
		internal double method_27()
		{
			if (this.method_5() == PlayModes.OsuMania)
			{
				return this.method_24();
			}
			return this.method_14();
		}

		// Token: 0x06002B4C RID: 11084
		// RVA: 0x00119104 File Offset: 0x00117304
		internal double method_28()
		{
			double num = this.method_26();
			if (num >= 0.0)
			{
				return num;
			}
			return this.method_27();
		}

		// Token: 0x06002B4D RID: 11085
		// RVA: 0x00021212 File Offset: 0x0001F412
		internal PlayModes method_29()
		{
			if (this.method_5() != PlayModes.Osu)
			{
				return this.method_5();
			}
			return Class62.Mode;
		}

		// Token: 0x06002B30 RID: 11056
		// RVA: 0x000210AA File Offset: 0x0001F2AA
		internal string method_3()
		{
			return Class466.smethod_17() + this.string_4;
		}

		// Token: 0x06002B4E RID: 11086
		// RVA: 0x0011912C File Offset: 0x0011732C
		internal string method_30()
		{
			double value = Class297.smethod_11((double)this.DifficultyCircleSize, 1.3);
			double value2 = Class297.smethod_11((double)this.DifficultyHpDrainRate, 1.4);
			double value3 = Class297.smethod_11((double)this.DifficultyApproachRate, 1.4);
			double value4 = Class297.smethod_11((double)this.DifficultyOverall, 1.4);
			double num = this.method_26();
			string text = string.Empty;
			string text2 = Class876.smethod_5(Mods.DoubleTime) ? "▴" : (Class876.smethod_5(Mods.HalfTime) ? "▾" : "");
			PlayModes playModes = this.method_29();
			if (playModes != PlayModes.Osu)
			{
				if (playModes != PlayModes.CatchTheBeat)
				{
					if (playModes == PlayModes.OsuMania)
					{
						text += "Keys:{0:0} ";
						goto IL_CE;
					}
					goto IL_CE;
				}
			}
			text = text + "CS:{0:0.##} AR:{1:0.##}" + text2 + " ";
			IL_CE:
			string text3 = text;
			text = string.Concat(new string[]
			{
				text3,
				"OD:{2:0.##}",
				text2,
				" HP:{3:0.##}",
				text2,
				" "
			});
			if (num >= 0.0)
			{
				text += "Stars:{4:0.##}";
			}
			string text4 = string.Format(text, new object[]
			{
				(playModes == PlayModes.OsuMania) ? ((double)Class421.smethod_2(this)) : Math.Round(value, 2),
				Math.Round(value3, 2),
				Math.Round(value4, 2),
				Math.Round(value2, 2),
				Math.Round(num, 2)
			});
			if (this.int_13 != 0 || this.int_12 != 0)
			{
				text4 = text4 + '\n' + string.Format(Class41.GetString(OsuString.SongSelection_CustomOffset), new object[]
				{
					(this.int_13 > 0) ? "+" : string.Empty,
					this.int_13,
					(this.int_12 > 0) ? "+" : string.Empty,
					this.int_12
				});
			}
			return text4;
		}

		// Token: 0x06002B4F RID: 11087
		// RVA: 0x00119364 File Offset: 0x00117564
		internal string method_31()
		{
			string result = string.Empty;
			switch (this.method_29())
			{
			case PlayModes.Taiko:
			{
				Class303 class = new Class303(false);
				class.method_8(this, Class876.class623_0);
				class.vmethod_8(false, false);
				result = string.Format(Class41.GetString(OsuString.SongSelection_DifficultyInfo_Tooltip_Taiko), Class297.smethod_9((double)class.HitWindow300 - 0.5), Class297.smethod_9((double)class.HitWindow100 - 0.5));
				class.Dispose();
				break;
			}
			case PlayModes.CatchTheBeat:
			{
				Class302 class2 = new Class302(false);
				class2.method_8(this, Class876.class623_0);
				class2.vmethod_8(false, false);
				result = string.Format(Class41.GetString(OsuString.SongSelection_DifficultyInfo_Tooltip_CatchTheBeat), Class297.smethod_9((double)class2.PreEmpt), class2.HitObjectRadius);
				class2.Dispose();
				break;
			}
			case PlayModes.OsuMania:
			{
				Class300 class3 = new Class300(false);
				class3.method_8(this, Class876.class623_0);
				class3.vmethod_8(false, false);
				result = string.Format(Class41.GetString(OsuString.SongSelection_DifficultyInfo_Tooltip_Mania), new object[]
				{
					Class297.smethod_9((double)class3.int_17 + 0.5),
					Class297.smethod_9((double)class3.HitWindow300 + 0.5),
					Class297.smethod_9((double)class3.int_18 + 0.5),
					Class297.smethod_9((double)class3.HitWindow100 + 0.5),
					Class297.smethod_9((double)class3.HitWindow50 + 0.5)
				});
				class3.Dispose();
				break;
			}
			default:
			{
				Class298 class4 = new Class298(false);
				class4.method_8(this, Class876.class623_0);
				class4.vmethod_8(false, false);
				result = string.Format(Class41.GetString(OsuString.SongSelection_DifficultyInfo_Tooltip_Osu), new object[]
				{
					Class297.smethod_9((double)class4.PreEmpt),
					Class297.smethod_9((double)class4.HitWindow300 - 0.5),
					Class297.smethod_9((double)class4.HitWindow100 - 0.5),
					Class297.smethod_9((double)class4.HitWindow50 - 0.5),
					class4.SpinnerRotationRatio,
					class4.HitObjectRadius
				});
				class4.Dispose();
				break;
			}
			}
			return result;
		}

		// Token: 0x06002B50 RID: 11088
		// RVA: 0x00119618 File Offset: 0x00117818
		internal double method_32()
		{
			if (this.list_1 == null || this.list_1.Count == 0)
			{
				return 0.0;
			}
			double num = 5000.0;
			for (int i = 0; i < this.list_1.Count; i++)
			{
				if (this.list_1[i].method_0() && this.list_1[i].double_0 < num)
				{
					num = this.list_1[i].double_0;
				}
			}
			if (num == 0.0)
			{
				return 0.0;
			}
			return 60000.0 / num;
		}

		// Token: 0x06002B51 RID: 11089
		// RVA: 0x001196C4 File Offset: 0x001178C4
		internal Vector3 method_33()
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				double num = 1.7976931348623157E+308;
				double num2 = -1.7976931348623157E+308;
				double num3 = (double)this.int_16;
				double num4 = 0.0;
				Dictionary<double, int> dictionary = new Dictionary<double, int>();
				for (int i = this.list_1.Count - 1; i >= 0; i--)
				{
					Class340 class = this.list_1[i];
					if (class.method_0())
					{
						num4 = class.double_0;
					}
					if (num4 != 0.0 && class.double_1 <= num3 && (class.method_0() || i <= 0))
					{
						if (num4 < num)
						{
							num = num4;
						}
						if (num4 > num2)
						{
							num2 = num4;
						}
						if (dictionary.ContainsKey(num4))
						{
							Dictionary<double, int> dictionary2;
							double key;
							(dictionary2 = dictionary)[key = num4] = dictionary2[key] + (int)(num3 - ((i == 0) ? 0.0 : class.double_1));
						}
						else
						{
							dictionary[num4] = (int)(num3 - ((i == 0) ? 0.0 : class.double_1));
						}
						num3 = class.double_1;
					}
				}
				int num5 = 0;
				double num6 = 0.0;
				foreach (KeyValuePair<double, int> current in dictionary)
				{
					if (current.Value > num5)
					{
						num5 = current.Value;
						num6 = current.Key;
					}
				}
				return new Vector3((float)Math.Round(60000.0 / num2), (float)Math.Round(60000.0 / num), (float)Math.Round(60000.0 / num6));
			}
			return Vector3.get_Zero();
		}

		// Token: 0x06002B53 RID: 11091
		// RVA: 0x00119900 File Offset: 0x00117B00
		internal double method_34(double double_3)
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				int num = 0;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					if (this.list_1[i].method_0() && this.list_1[i].double_1 <= double_3)
					{
						num = i;
					}
				}
				double num2 = this.list_1[num].double_0;
				double num3 = this.list_1[num].double_1;
				if (num == 0 && num2 > 0.0)
				{
					while (num3 > 0.0)
					{
						num3 -= num2;
					}
				}
				return num3;
			}
			return 0.0;
		}

		// Token: 0x06002B54 RID: 11092
		// RVA: 0x001199BC File Offset: 0x00117BBC
		internal double method_35(double double_3)
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				int index = 0;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					if (this.list_1[i].method_0() && this.list_1[i].double_1 <= double_3)
					{
						index = i;
					}
				}
				return this.list_1[index].double_1;
			}
			return 0.0;
		}

		// Token: 0x06002B55 RID: 11093
		// RVA: 0x00119A3C File Offset: 0x00117C3C
		internal double method_36(double double_3, bool bool_27)
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				int num = 0;
				int num2 = 0;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					if (this.list_1[i].double_1 <= double_3)
					{
						if (this.list_1[i].method_0())
						{
							num = i;
						}
						else
						{
							num2 = i;
						}
					}
				}
				double num3 = 1.0;
				if (bool_27 && num2 > num && this.list_1[num2].double_0 < 0.0)
				{
					num3 = (double)this.list_1[num2].method_4();
				}
				return this.list_1[num].double_0 * num3;
			}
			return 0.0;
		}

		// Token: 0x06002B56 RID: 11094
		// RVA: 0x00119B08 File Offset: 0x00117D08
		internal float method_37(double double_3)
		{
			Class340 class = this.method_39(double_3);
			if (class == null)
			{
				return 1f;
			}
			return class.method_4();
		}

		// Token: 0x06002B57 RID: 11095
		// RVA: 0x00119B2C File Offset: 0x00117D2C
		internal int method_38(double double_3, bool bool_27)
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				int result = 0;
				if (bool_27)
				{
					for (int i = 0; i < this.list_1.Count; i++)
					{
						Class340 class = this.list_1[i];
						if (class.double_1 <= double_3)
						{
							result = i;
						}
					}
				}
				else
				{
					for (int j = 0; j < this.list_1.Count; j++)
					{
						Class340 class2 = this.list_1[j];
						if (class2.double_1 <= double_3 && class2.method_0())
						{
							result = j;
						}
					}
				}
				return result;
			}
			return -1;
		}

		// Token: 0x06002B58 RID: 11096
		// RVA: 0x00119BC0 File Offset: 0x00117DC0
		internal Class340 method_39(double double_3)
		{
			if (this.list_1 != null && this.list_1.Count != 0)
			{
				Class340 class = null;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					Class340 class2 = this.list_1[i];
					if (class2.double_1 <= double_3)
					{
						class = class2;
					}
				}
				if (class == null)
				{
					class = this.list_1[0];
				}
				return class;
			}
			return null;
		}

		// Token: 0x06002B31 RID: 11057
		// RVA: 0x0011785C File Offset: 0x00115A5C
		internal void method_4(string string_16)
		{
			string_16 = Class34.smethod_15(string_16);
			int num = string_16.LastIndexOf(Path.DirectorySeparatorChar);
			if (num >= 0)
			{
				int num2 = string_16.IndexOf(Class466.smethod_17());
				if (num2 >= 0)
				{
					string_16 = string_16.Substring(num2 + Class466.smethod_17().Length);
				}
			}
			this.string_4 = string_16.Trim(new char[]
			{
				Path.DirectorySeparatorChar
			});
		}

		// Token: 0x06002B59 RID: 11097
		// RVA: 0x00021228 File Offset: 0x0001F428
		internal Class340 method_40(double double_3)
		{
			return Class296.smethod_1(double_3, this.list_1);
		}

		// Token: 0x06002B5B RID: 11099
		// RVA: 0x00119C78 File Offset: 0x00117E78
		internal Rankings method_41()
		{
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
				return this.rankings_1;
			case PlayModes.Taiko:
				return this.rankings_2;
			case PlayModes.CatchTheBeat:
				return this.rankings_0;
			case PlayModes.OsuMania:
				return this.rankings_3;
			default:
				return Rankings.N;
			}
		}

		// Token: 0x06002B5C RID: 11100
		// RVA: 0x00119CC0 File Offset: 0x00117EC0
		internal void method_42(Rankings rankings_4)
		{
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
				this.rankings_1 = rankings_4;
				return;
			case PlayModes.Taiko:
				this.rankings_2 = rankings_4;
				return;
			case PlayModes.CatchTheBeat:
				this.rankings_0 = rankings_4;
				return;
			case PlayModes.OsuMania:
				this.rankings_3 = rankings_4;
				return;
			default:
				return;
			}
		}

		// Token: 0x06002B5D RID: 11101
		// RVA: 0x00119D0C File Offset: 0x00117F0C
		internal string method_43()
		{
			string text = this.string_9.Replace(".osu", "");
			if (text.Length == 0)
			{
				return null;
			}
			if (text[text.Length - 1] == ']')
			{
				text = text.Remove(text.LastIndexOf('['));
			}
			return text.Trim() + ".osb";
		}

		// Token: 0x06002B5E RID: 11102
		// RVA: 0x00119D6C File Offset: 0x00117F6C
		internal Class178 method_44()
		{
			if (!this.bool_10)
			{
				return null;
			}
			if (!this.bool_20 && this.class178_0 != null)
			{
				return this.class178_0;
			}
			Class178 class = Class134.smethod_0(this.method_3());
			if (this.class178_0 == null && !this.bool_20)
			{
				if (class == null)
				{
					string text = this.method_3().Replace(".osz2", "") + ".osz2";
					if (!File.Exists(text))
					{
						return null;
					}
					class = Class134.smethod_0(text);
					if (class == null)
					{
						this.bool_20 = false;
						return null;
					}
					this.method_4(text);
					this.bool_10 = true;
				}
				this.bool_20 = true;
				this.class178_0 = class;
				return this.class178_0;
			}
			this.class178_0 = class;
			return class;
		}

		// Token: 0x06002B5F RID: 11103
		// RVA: 0x00021236 File Offset: 0x0001F436
		internal void method_45(Class178 class178_1)
		{
			if (class178_1 == null)
			{
				return;
			}
			this.class178_0 = class178_1;
			this.bool_10 = true;
		}

		// Token: 0x06002B60 RID: 11104
		// RVA: 0x00119E24 File Offset: 0x00118024
		internal string method_46()
		{
			if (!this.bool_10)
			{
				return Path.Combine(this.method_3(), this.string_9);
			}
			if (this.method_8() != null && this.method_2())
			{
				return Path.Combine(this.method_8(), this.string_9);
			}
			return this.string_9;
		}

		// Token: 0x06002B64 RID: 11108
		// RVA: 0x0002124A File Offset: 0x0001F44A
		internal bool method_47()
		{
			return this.class133_0 != null;
		}

		// Token: 0x06002B65 RID: 11109
		// RVA: 0x0011A490 File Offset: 0x00118690
		internal void method_48(bool bool_27, bool bool_28, RankingType rankingType_0)
		{
			Class296.Class711 class = new Class296.Class711();
			class.class296_0 = this;
			if (this.class133_0 != null && !bool_28)
			{
				return;
			}
			this.list_0.Clear();
			Class296.class296_0 = this;
			class.playModes_0 = ((this.method_5() != PlayModes.Osu) ? this.method_5() : Class62.Mode);
			Class296.playModes_1 = class.playModes_0;
			if (this.class133_0 != null)
			{
				this.class133_0.method_1(new Class133.Delegate17(this.method_49));
				this.class133_0.Abort();
			}
			string text = string.Empty;
			if (this.method_44() != null)
			{
				text = (BitConverter.ToString(this.method_44().method_4()) + BitConverter.ToString(this.method_44().method_0())).Replace("-", "");
			}
			int num = 400;
			switch (rankingType_0)
			{
			case RankingType.Friends:
				num = 1000;
				break;
			case RankingType.Country:
				num = 1000;
				break;
			}
			string text2 = string.Concat(new object[]
			{
				"http://osu.ppy.sh/web/osu-osz2-getscores.php?s=",
				bool_27 ? "0" : "1",
				"&vv=2&v=",
				(int)rankingType_0,
				"&c=",
				this.string_3,
				"&f=",
				Class34.smethod_8(Path.GetFileName(this.string_9)),
				"&m=",
				(int)class.playModes_0,
				"&i=",
				this.int_3,
				"&mods=",
				(int)Class876.class623_0,
				"&h=",
				text,
				"&a=",
				Class115.bool_35 ? "1" : "0",
				"&us=",
				Class341.class605_20,
				"&ha=",
				Class341.class605_17
			});
			this.class133_0 = new Class133(text2);
			this.class133_0.method_0(new Class133.Delegate17(this.method_49));
			Class115.class47_0.method_1(new VoidDelegate(class.method_0), bool_28 ? 0 : num, false);
		}

		// Token: 0x06002B66 RID: 11110
		// RVA: 0x0011A6EC File Offset: 0x001188EC
		private void method_49(string string_16, Exception exception_0)
		{
			if (exception_0 != null)
			{
				this.class133_0 = null;
				return;
			}
			this.bool_9 = false;
			try
			{
				string[] array = string_16.Split(new char[]
				{
					'\n'
				});
				this.list_0.Clear();
				if (array.Length > 0)
				{
					this.bool_18 = false;
					string[] array2 = array[0].Split(new char[]
					{
						'|'
					});
					bool.TryParse(array2[1], out this.bool_3);
					string a;
					if ((a = array2[0]) != null)
					{
						if (a == "-1")
						{
							this.submissionStatus_0 = SubmissionStatus.NotSubmitted;
							this.bool_9 = true;
							goto IL_E5;
						}
						if (a == "0")
						{
							this.submissionStatus_0 = SubmissionStatus.Pending;
							goto IL_E5;
						}
						if (a == "1")
						{
							this.submissionStatus_0 = SubmissionStatus.Unknown;
							this.bool_18 = true;
							goto IL_E5;
						}
						if (a == "3")
						{
							this.submissionStatus_0 = SubmissionStatus.Approved;
							goto IL_E5;
						}
					}
					this.submissionStatus_0 = SubmissionStatus.Ranked;
					IL_E5:
					if (array2.Length > 2)
					{
						int.TryParse(array2[2], out this.int_2);
						int.TryParse(array2[3], out this.int_3);
						int.TryParse(array2[4], out this.int_4);
					}
				}
				if (array.Length > 1 && array[1].Length > 0)
				{
					int num = int.Parse(array[1]);
					if (num != this.int_12 && this.int_13 != 0)
					{
						Class723.smethod_1(string.Concat(new object[]
						{
							"New online offset available.  Adjusting overall local offset from ",
							this.int_13,
							" to ",
							num,
							"."
						}), 2000);
						this.int_13 = 0;
					}
					this.int_12 = num;
					this.string_10 = array[2].Replace('|', '\n');
					this.float_0 = float.Parse(array[3], Class115.numberFormatInfo_0);
				}
				if (array.Length > 4)
				{
					if (array[4].Length > 0)
					{
						this.class512_0 = Class721.smethod_0((this.method_5() != PlayModes.Osu) ? this.method_5() : Class62.Mode, array[4], this);
						if (this.dateTime_0 == DateTime.MinValue)
						{
							this.dateTime_0 = this.class512_0.dateTime_0;
						}
					}
					else
					{
						this.class512_0 = null;
					}
					int i = 5;
					while (i < array.Length)
					{
						Class296.Class712 class = new Class296.Class712();
						string text = array[i];
						if (text.Length != 0)
						{
							class.class512_0 = Class721.smethod_0((this.method_5() != PlayModes.Osu) ? this.method_5() : Class62.Mode, array[i], this);
							Class512 class2 = this.list_0.Find(new Predicate<Class512>(class.method_0));
							if (class2 == null)
							{
								goto IL_2A4;
							}
							if (class2.int_1 <= 0)
							{
								this.list_0.Remove(class2);
								goto IL_2A4;
							}
							IL_2B6:
							i++;
							continue;
							IL_2A4:
							this.list_0.Add(class.class512_0);
							goto IL_2B6;
						}
						break;
					}
					List<Class512> arg_2E6_0 = this.list_0;
					if (Class296.comparison_0 == null)
					{
						Class296.comparison_0 = new Comparison<Class512>(Class296.smethod_3);
					}
					arg_2E6_0.Sort(Class296.comparison_0);
				}
			}
			catch
			{
				Class723.smethod_4("Scores could not be retrieved.");
			}
			Class115.class47_0.Add(new VoidDelegate(this.method_77), false);
		}

		// Token: 0x06002B32 RID: 11058
		// RVA: 0x000210BC File Offset: 0x0001F2BC
		internal PlayModes method_5()
		{
			return this.playModes_0;
		}

		// Token: 0x06002B67 RID: 11111
		// RVA: 0x0011AA28 File Offset: 0x00118C28
		internal void method_50(Delegate52 delegate52_1)
		{
			Delegate52 delegate = this.delegate52_0;
			Delegate52 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate52 value = (Delegate52)Delegate.Combine(delegate2, delegate52_1);
				delegate = Interlocked.CompareExchange<Delegate52>(ref this.delegate52_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002B68 RID: 11112
		// RVA: 0x0011AA60 File Offset: 0x00118C60
		internal void method_51(Delegate52 delegate52_1)
		{
			Delegate52 delegate = this.delegate52_0;
			Delegate52 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate52 value = (Delegate52)Delegate.Remove(delegate2, delegate52_1);
				delegate = Interlocked.CompareExchange<Delegate52>(ref this.delegate52_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002B69 RID: 11113
		// RVA: 0x0011AA98 File Offset: 0x00118C98
		internal void method_52()
		{
			Class133 class = this.class133_0;
			if (class != null)
			{
				class.Abort();
			}
			this.class133_0 = null;
			this.delegate52_0 = null;
		}

		// Token: 0x06002B6A RID: 11114
		// RVA: 0x0011AAC4 File Offset: 0x00118CC4
		internal void method_53()
		{
			string str = this.Artist;
			if (this.Artist.Length > 0)
			{
				this.string_12 = str + " - " + this.Title;
			}
			else if (this.Title.Length > 0)
			{
				this.string_12 = this.Title;
			}
			else
			{
				this.string_12 = Path.GetFileName(this.string_9);
			}
			string text = (this.string_14.Length > 0) ? (" [" + this.string_14 + "]") : "";
			if (this.Artist.Length > 0)
			{
				this.string_6 = str + " - " + this.Title + text;
				str = ((this.string_13.Length > 0) ? (this.string_13 + " (" + this.Artist + ")") : this.Artist);
				this.string_7 = str + " - " + this.Title + text;
			}
			else if (this.Title.Length > 0)
			{
				this.string_6 = this.Title + text;
				this.string_7 = this.string_6;
			}
			else
			{
				this.string_6 = Path.GetFileName(this.string_9);
				this.string_7 = this.string_6;
			}
			if (this.Title.Length > 0)
			{
				this.string_8 = this.Title + text;
				return;
			}
			this.string_8 = Path.GetFileName(this.string_9);
		}

		// Token: 0x06002B6B RID: 11115
		// RVA: 0x00021258 File Offset: 0x0001F458
		internal void method_54()
		{
			Class115.smethod_90(string.Format("http://osu.ppy.sh/b/{0}", this.int_2), null);
		}

		// Token: 0x06002B6C RID: 11116
		// RVA: 0x00021275 File Offset: 0x0001F475
		internal void method_55()
		{
			Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/t/{0}", this.int_5), null);
		}

		// Token: 0x06002B6D RID: 11117
		// RVA: 0x00021292 File Offset: 0x0001F492
		internal void method_56()
		{
			Class115.smethod_90(string.Format("http://osu.ppy.sh/forum/posting.php?mode=reply&t={0}", this.int_5), null);
		}

		// Token: 0x06002B6E RID: 11118
		// RVA: 0x0011AC48 File Offset: 0x00118E48
		internal void method_57()
		{
			try
			{
				string text = Path.Combine(this.method_3(), this.string_9);
				File.Delete(text);
				File.Move(text + "_", text);
				string text2 = this.string_3;
				List<string> list = Class476.smethod_2(text2);
				this.method_11();
				if (list != null && list.Count > 0)
				{
					foreach (string current in list)
					{
						Class476.smethod_7(current, text2);
						Class476.smethod_5(current, this.string_3);
					}
				}
				this.method_25();
				if (Class115.class61_0 is Class68)
				{
					Class68 class = (Class68)Class115.class61_0;
					class.method_18(this, WorkItemPriority.Normal);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06002B70 RID: 11120
		// RVA: 0x000212B7 File Offset: 0x0001F4B7
		internal void method_58()
		{
			this.rankings_0 = Rankings.N;
			this.rankings_2 = Rankings.N;
			this.rankings_1 = Rankings.N;
			this.rankings_3 = Rankings.N;
		}

		// Token: 0x06002B71 RID: 11121
		// RVA: 0x000212D9 File Offset: 0x0001F4D9
		internal bool method_59(string string_16)
		{
			return this.method_2() && this.method_8() != null && File.Exists(Path.Combine(this.method_8(), string_16));
		}

		// Token: 0x06002B33 RID: 11059
		// RVA: 0x000210C4 File Offset: 0x0001F2C4
		internal void method_6(PlayModes playModes_2)
		{
			if (Enum.IsDefined(typeof(PlayModes), playModes_2))
			{
				this.playModes_0 = playModes_2;
				return;
			}
			this.playModes_0 = PlayModes.Osu;
		}

		// Token: 0x06002B72 RID: 11122
		// RVA: 0x0011AD28 File Offset: 0x00118F28
		internal Stream method_60()
		{
			if (!this.method_0())
			{
				return null;
			}
			if (this.method_44() == null || this.method_59(this.string_1))
			{
				return this.method_62(this.string_1);
			}
			Stream stream = this.method_44().method_21(this.string_1);
			if (stream == null)
			{
				this.method_1(false);
				return null;
			}
			return stream;
		}

		// Token: 0x06002B73 RID: 11123
		// RVA: 0x000212FE File Offset: 0x0001F4FE
		internal Stream method_61()
		{
			return this.method_62(this.string_9);
		}

		// Token: 0x06002B74 RID: 11124
		// RVA: 0x0011AD84 File Offset: 0x00118F84
		internal Stream method_62(string string_16)
		{
			Stream result;
			try
			{
				if (this.method_44() == null)
				{
					string_16 = Path.Combine(this.method_3(), string_16);
					if (!File.Exists(string_16))
					{
						result = null;
					}
					else
					{
						result = File.OpenRead(string_16);
					}
				}
				else if (this.method_59(string_16))
				{
					result = File.OpenRead(Path.Combine(this.method_8(), string_16));
				}
				else
				{
					result = this.method_44().method_21(string_16);
				}
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002B75 RID: 11125
		// RVA: 0x0011AE00 File Offset: 0x00119000
		internal byte[] method_63(string string_16)
		{
			byte[] array = null;
			if (this.method_44() != null && !this.method_44().method_33(1, false))
			{
				return null;
			}
			try
			{
				using (Stream stream = this.method_62(string_16))
				{
					if (stream != null)
					{
						array = new byte[stream.Length];
						stream.Read(array, 0, array.Length);
						stream.Close();
					}
				}
			}
			finally
			{
				if (this.method_44() != null)
				{
					this.method_44().method_34();
				}
			}
			return array;
		}

		// Token: 0x06002B76 RID: 11126
		// RVA: 0x0011AE94 File Offset: 0x00119094
		internal Class178 method_64(string string_16, bool bool_27)
		{
			Predicate<Class296> predicate = null;
			Action<Class296> action = null;
			Class296.Class713 class = new Class296.Class713();
			class.string_0 = string_16;
			class.bool_0 = bool_27;
			class.class296_0 = this;
			if (this.int_3 <= 0)
			{
				throw new InvalidOperationException("Cannot convert a map to osz2 which does not have a Beatmapset ID.");
			}
			if (this.bool_10)
			{
				return null;
			}
			Class466.bool_4 = false;
			try
			{
				Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
				if (File.Exists(class.string_0))
				{
					File.Delete(class.string_0);
				}
				class.class178_0 = Class134.smethod_1(class.string_0, true, false);
				if (class.class178_0 == null)
				{
					Class178 result = null;
					return result;
				}
				if (!class.class178_0.method_33(50, false))
				{
					Class178 result = null;
					return result;
				}
				try
				{
					class.class178_0.method_25(this.method_3(), true);
					class.class178_0.method_24(Enum9.const_9, Convert.ToString(this.int_3));
					class.class178_0.method_24(Enum9.const_1, this.Artist);
					class.class178_0.method_24(Enum9.const_2, this.string_5);
					class.class178_0.method_24(Enum9.const_4, this.string_13);
					class.class178_0.method_24(Enum9.const_0, this.Title);
					class.class178_0.method_24(Enum9.const_12, this.TitleUnicode);
					class.class178_0.method_24(Enum9.const_13, this.ArtistUnicode);
					class.class178_0.method_24(Enum9.const_5, this.Tags);
				}
				catch
				{
					class.class178_0.Close();
					Class178 result = null;
					return result;
				}
				string path = this.method_3();
				List<Class296> arg_192_0 = Class466.list_3;
				if (predicate == null)
				{
					predicate = new Predicate<Class296>(this.method_78);
				}
				List<Class296> list = arg_192_0.FindAll(predicate);
				List<Class296> arg_1AB_0 = list;
				if (action == null)
				{
					action = new Action<Class296>(class.method_0);
				}
				arg_1AB_0.ForEach(action);
				class.class178_0.method_32(false);
				if (!this.method_3().EndsWith(Class115.class605_0) && class.bool_0)
				{
					Class331.smethod_91();
					Directory.Delete(path, true);
				}
			}
			finally
			{
				Class466.bool_4 = true;
				Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
			}
			return class.class178_0;
		}

		// Token: 0x06002B77 RID: 11127
		// RVA: 0x0002130C File Offset: 0x0001F50C
		internal void method_65(string string_16)
		{
			if (this.bool_10)
			{
				this.method_44().method_29(string_16);
				this.method_44().method_31();
				return;
			}
			Class624.smethod_1(Path.Combine(this.method_3(), string_16));
		}

		// Token: 0x06002B78 RID: 11128
		// RVA: 0x0011B0E0 File Offset: 0x001192E0
		internal void method_66()
		{
			string a = Class33.smethod_3(this.method_63(this.string_9));
			if (a == this.string_3)
			{
				return;
			}
			bool flag = Class466.Remove(this);
			List<string> list = Class476.smethod_2(this.string_3);
			if (list != null && list.Count > 0)
			{
				foreach (string current in list)
				{
					Class476.smethod_7(current, this.string_3);
					Class476.smethod_5(current, a);
				}
			}
			this.string_3 = a;
			if (flag)
			{
				Class466.Add(this);
			}
		}

		// Token: 0x06002B79 RID: 11129
		// RVA: 0x00021341 File Offset: 0x0001F541
		internal void method_67()
		{
			this.double_0 = 0.0;
		}

		// Token: 0x06002B7A RID: 11130
		// RVA: 0x00021352 File Offset: 0x0001F552
		internal bool method_68(string string_16)
		{
			if (string.IsNullOrEmpty(string_16))
			{
				return false;
			}
			if (this.method_44() == null)
			{
				return File.Exists(Path.Combine(this.method_3(), string_16));
			}
			return this.method_44().method_19(string_16) || this.method_59(string_16);
		}

		// Token: 0x06002B7B RID: 11131
		// RVA: 0x0002138F File Offset: 0x0001F58F
		internal void method_69()
		{
			if (this.method_44() == null)
			{
				throw new Exception("Can only update osz2 packages.");
			}
			Class67.smethod_0();
		}

		// Token: 0x06002B34 RID: 11060
		// RVA: 0x000210EC File Offset: 0x0001F2EC
		internal List<Class340> method_7()
		{
			if (this.list_1 == null)
			{
				return null;
			}
			List<Class340> arg_2D_0 = this.list_1;
			if (Class296.predicate_0 == null)
			{
				Class296.predicate_0 = new Predicate<Class340>(Class296.smethod_2);
			}
			return arg_2D_0.FindAll(Class296.predicate_0);
		}

		// Token: 0x06002B7C RID: 11132
		// RVA: 0x0011B190 File Offset: 0x00119390
		internal string method_70()
		{
			if (!this.bool_10)
			{
				return null;
			}
			string text = this.method_8();
			if (text == null)
			{
				text = Path.Combine("Data\\e\\", this.int_3 + " - " + this.Title);
			}
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			this.method_9(text);
			return this.method_8();
		}

		// Token: 0x06002B7D RID: 11133
		// RVA: 0x0011B1F4 File Offset: 0x001193F4
		internal string method_71(string string_16, bool bool_27)
		{
			byte[] array = this.method_63(string_16);
			if (array == null)
			{
				return null;
			}
			this.method_70();
			string text = Path.Combine(this.method_8(), string_16);
			if (File.Exists(text) && !bool_27)
			{
				return text;
			}
			string result;
			try
			{
				File.WriteAllBytes(text, array);
				return text;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002B7E RID: 11134
		// RVA: 0x0011B250 File Offset: 0x00119450
		internal bool method_72(Class296.Enum64 enum64_0, bool bool_27)
		{
			bool result = true;
			this.method_70();
			if (!this.method_44().method_33(100, false))
			{
				return false;
			}
			try
			{
				List<Struct20> list = this.method_44().method_30();
				foreach (Struct20 current in list)
				{
					string path = current.method_0();
					if ((!Class178.smethod_7(path) && !Class178.smethod_5(path)) || (Class809.bool_4 && !(this.string_5 != Class115.class861_0.Name)))
					{
						string text = Path.Combine(this.method_8(), path);
						string directoryName = Path.GetDirectoryName(text);
						if (!Directory.Exists(directoryName))
						{
							Directory.CreateDirectory(directoryName);
						}
						if (File.Exists(text))
						{
							DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
							FileInfo fileInfo = new FileInfo(text);
							long num = 0L;
							long num2 = 0L;
							try
							{
								num = lastWriteTimeUtc.ToFileTime();
								num2 = current.method_9().ToFileTime();
							}
							catch
							{
							}
							if (Math.Abs(num2 - num) < 200000000L && fileInfo.Length == (long)(current.Length - 4))
							{
								continue;
							}
							switch (enum64_0)
							{
							case Class296.Enum64.const_0:
								using (FileColissionDialog fileColissionDialog = new FileColissionDialog(text, (int)fileInfo.Length, fileInfo.LastWriteTime, Path.Combine(this.method_3(), path), current.Length, current.method_9().ToLocalTime()))
								{
									if (fileColissionDialog.ShowDialog(Class115.form_0) == DialogResult.Ignore)
									{
										continue;
									}
									switch (fileColissionDialog.method_0())
									{
									case FileColissionDialog.Enum41.const_2:
										enum64_0 = Class296.Enum64.const_1;
										break;
									case FileColissionDialog.Enum41.const_3:
										continue;
									case FileColissionDialog.Enum41.const_4:
										enum64_0 = Class296.Enum64.const_3;
										continue;
									}
									goto IL_1E7;
								}
								break;
							case Class296.Enum64.const_1:
								goto IL_1E7;
							case Class296.Enum64.const_2:
								break;
							case Class296.Enum64.const_3:
								continue;
							default:
								goto IL_1E7;
							}
							if (current.method_9() < lastWriteTimeUtc)
							{
								continue;
							}
						}
						else if (bool_27)
						{
							continue;
						}
						IL_1E7:
						using (Stream stream = this.method_44().method_21(path))
						{
							if (stream.Length == 0L)
							{
								File.WriteAllBytes(text, new byte[0]);
							}
							else
							{
								using (FileStream fileStream = File.Create(text, (int)stream.Length, FileOptions.WriteThrough))
								{
									byte[] array = new byte[stream.Length];
									stream.Read(array, 0, array.Length);
									fileStream.Write(array, 0, array.Length);
									fileStream.Flush();
								}
							}
						}
						try
						{
							File.SetCreationTimeUtc(text, current.method_7());
							File.SetLastWriteTimeUtc(text, current.method_9());
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
				result = false;
			}
			finally
			{
				this.method_44().method_34();
			}
			return result;
		}

		// Token: 0x06002B80 RID: 11136
		// RVA: 0x000213C5 File Offset: 0x0001F5C5
		internal string method_73()
		{
			if (Class341.class606_58 && !string.IsNullOrEmpty(this.TitleUnicode))
			{
				return this.TitleUnicode;
			}
			return this.Title;
		}

		// Token: 0x06002B81 RID: 11137
		// RVA: 0x000213ED File Offset: 0x0001F5ED
		internal string method_74()
		{
			if (Class341.class606_58 && !string.IsNullOrEmpty(this.ArtistUnicode))
			{
				return this.ArtistUnicode;
			}
			return this.Artist;
		}

		// Token: 0x06002B82 RID: 11138
		// RVA: 0x0011B5F0 File Offset: 0x001197F0
		internal string method_75()
		{
			if (Class341.class606_58 && !string.IsNullOrEmpty(this.ArtistUnicode) && !string.IsNullOrEmpty(this.TitleUnicode))
			{
				return this.ArtistUnicode + " - " + this.TitleUnicode;
			}
			return this.string_12;
		}

		// Token: 0x06002B83 RID: 11139
		// RVA: 0x0011B640 File Offset: 0x00119840
		internal string method_76()
		{
			if (Class341.class606_58 && !string.IsNullOrEmpty(this.ArtistUnicode) && !string.IsNullOrEmpty(this.TitleUnicode))
			{
				string str = (this.string_13.Length > 0) ? (this.string_13 + " (" + this.ArtistUnicode + ")") : this.ArtistUnicode;
				return str + " - " + this.TitleUnicode + ((this.string_14.Length > 0) ? (" [" + this.string_14 + "]") : "");
			}
			return this.string_7;
		}

		// Token: 0x06002B86 RID: 11142
		// RVA: 0x00021415 File Offset: 0x0001F615
		[CompilerGenerated]
		private void method_77()
		{
			if (this.delegate52_0 != null)
			{
				this.delegate52_0(this);
			}
			this.class133_0 = null;
		}

		// Token: 0x06002B87 RID: 11143
		// RVA: 0x00021432 File Offset: 0x0001F632
		[CompilerGenerated]
		private bool method_78(Class296 class296_1)
		{
			return class296_1.method_3() == this.method_3();
		}

		// Token: 0x06002B35 RID: 11061
		// RVA: 0x00021120 File Offset: 0x0001F320
		internal string method_8()
		{
			if (this.string_15 == null)
			{
				return null;
			}
			if (!Directory.Exists(this.string_15))
			{
				this.string_15 = null;
				return null;
			}
			return this.string_15;
		}

		// Token: 0x06002B36 RID: 11062
		// RVA: 0x00021148 File Offset: 0x0001F348
		internal void method_9(string string_16)
		{
			this.string_15 = string_16;
		}

		// Token: 0x06002B61 RID: 11105
		// RVA: 0x00119E74 File Offset: 0x00118074
		public void ReadFromStream(Class32 class32_0)
		{
			this.Artist = class32_0.ReadString();
			if (Class466.int_0 >= Class344.int_0)
			{
				this.ArtistUnicode = class32_0.ReadString();
			}
			this.Title = class32_0.ReadString();
			if (Class466.int_0 >= Class344.int_0)
			{
				this.TitleUnicode = class32_0.ReadString();
			}
			this.string_5 = class32_0.ReadString();
			this.string_14 = class32_0.ReadString();
			this.string_1 = class32_0.ReadString();
			this.string_3 = class32_0.ReadString();
			this.string_9 = class32_0.ReadString();
			this.submissionStatus_0 = (SubmissionStatus)class32_0.ReadByte();
			this.ushort_0 = class32_0.ReadUInt16();
			this.ushort_1 = class32_0.ReadUInt16();
			this.ushort_2 = class32_0.ReadUInt16();
			this.dateTime_1 = class32_0.method_1();
			if (Class466.int_0 >= 20140612)
			{
				this.DifficultyApproachRate = class32_0.ReadSingle();
				this.DifficultyCircleSize = class32_0.ReadSingle();
				this.DifficultyHpDrainRate = class32_0.ReadSingle();
				this.DifficultyOverall = class32_0.ReadSingle();
			}
			else
			{
				this.DifficultyApproachRate = (float)class32_0.ReadByte();
				this.DifficultyCircleSize = (float)class32_0.ReadByte();
				this.DifficultyHpDrainRate = (float)class32_0.ReadByte();
				this.DifficultyOverall = (float)class32_0.ReadByte();
			}
			this.DifficultySliderMultiplier = class32_0.ReadDouble();
			if (Class466.int_0 >= 20140609)
			{
				if (Class466.int_0 < 20140610)
				{
					for (int i = 0; i < 4; i++)
					{
						class32_0.method_3<Mods, double>();
					}
				}
				else
				{
					for (int j = 0; j < 4; j++)
					{
						if (Class466.int_0 < Class296.int_0[j])
						{
							class32_0.method_3<int, double>();
						}
						else
						{
							this.dictionary_0[j] = (Dictionary<int, double>)class32_0.method_3<int, double>();
						}
					}
				}
			}
			this.int_9 = class32_0.ReadInt32();
			this.int_16 = class32_0.ReadInt32();
			this.int_14 = class32_0.ReadInt32();
			this.list_1 = (List<Class340>)class32_0.method_2<Class340>();
			this.int_2 = class32_0.ReadInt32();
			this.int_3 = class32_0.ReadInt32();
			this.int_5 = class32_0.ReadInt32();
			this.rankings_1 = (Rankings)class32_0.ReadByte();
			this.rankings_0 = (Rankings)class32_0.ReadByte();
			this.rankings_2 = (Rankings)class32_0.ReadByte();
			this.rankings_3 = (Rankings)class32_0.ReadByte();
			this.int_13 = (int)class32_0.ReadInt16();
			this.float_1 = class32_0.ReadSingle();
			this.method_6((PlayModes)class32_0.ReadByte());
			this.string_13 = class32_0.ReadString();
			this.Tags = class32_0.ReadString();
			this.int_12 = (int)class32_0.ReadInt16();
			this.string_10 = class32_0.ReadString();
			this.bool_13 = class32_0.ReadBoolean();
			this.dateTime_0 = class32_0.method_1();
			this.bool_10 = class32_0.ReadBoolean();
			this.method_4(class32_0.ReadString());
			this.long_0 = class32_0.ReadInt64();
			this.bool_22 = class32_0.ReadBoolean();
			this.bool_23 = class32_0.ReadBoolean();
			this.bool_24 = class32_0.ReadBoolean();
			if (Class466.int_0 >= 20130624)
			{
				this.bool_25 = class32_0.ReadBoolean();
			}
			if (Class466.int_0 >= 20130913)
			{
				this.bool_26 = class32_0.ReadBoolean();
			}
			else
			{
				this.bool_26 = (this.bool_25 || this.bool_24 || this.bool_23);
			}
			if (Class466.int_0 < 20140608)
			{
				class32_0.ReadInt16();
			}
			this.int_7 = class32_0.ReadInt32();
			this.int_18 = (int)class32_0.ReadByte();
			this.int_11 = (int)(this.ushort_0 + this.ushort_2 + this.ushort_1);
			this.bool_4 = (this.string_3 != null);
			this.method_1(true);
			this.method_53();
		}

		// Token: 0x06002B52 RID: 11090
		// RVA: 0x001198A0 File Offset: 0x00117AA0
		internal static string smethod_0(Vector3 vector3_0)
		{
			if (vector3_0.X == vector3_0.Y)
			{
				return vector3_0.X.ToString("0");
			}
			return string.Format("{0:0}-{1:0} ({2:0})", vector3_0.X, vector3_0.Y, vector3_0.Z);
		}

		// Token: 0x06002B5A RID: 11098
		// RVA: 0x00119C28 File Offset: 0x00117E28
		internal static Class340 smethod_1(double double_3, List<Class340> list_2)
		{
			if (list_2 == null || list_2.Count == 0)
			{
				return null;
			}
			Class340 item = new Class340(double_3, 0.0);
			int num = list_2.BinarySearch(item);
			if (num < 0)
			{
				num = ~num;
			}
			if (num <= 1)
			{
				return list_2[0];
			}
			return list_2[num - 1];
		}

		// Token: 0x06002B84 RID: 11140
		// RVA: 0x000165A1 File Offset: 0x000147A1
		[CompilerGenerated]
		private static bool smethod_2(Class340 class340_0)
		{
			return class340_0.method_0();
		}

		// Token: 0x06002B85 RID: 11141
		// RVA: 0x000D5744 File Offset: 0x000D3944
		[CompilerGenerated]
		private static int smethod_3(Class512 class512_1, Class512 class512_2)
		{
			int num = class512_2.int_3.CompareTo(class512_1.int_3);
			if (num != 0)
			{
				return num;
			}
			return class512_1.dateTime_0.CompareTo(class512_2.dateTime_0);
		}

		// Token: 0x06002B6F RID: 11119
		// RVA: 0x000212AF File Offset: 0x0001F4AF
		public override string ToString()
		{
			return this.string_6;
		}

		// Token: 0x06002B62 RID: 11106
		// RVA: 0x0011A214 File Offset: 0x00118414
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.Artist);
			class31_0.Write(this.ArtistUnicode);
			class31_0.Write(this.Title);
			class31_0.Write(this.TitleUnicode);
			class31_0.Write(this.string_5);
			class31_0.Write(this.string_14);
			class31_0.Write(this.string_1);
			class31_0.Write(this.string_3);
			class31_0.Write(this.string_9);
			class31_0.Write((byte)this.submissionStatus_0);
			class31_0.Write(this.ushort_0);
			class31_0.Write(this.ushort_1);
			class31_0.Write(this.ushort_2);
			class31_0.Write(this.dateTime_1);
			class31_0.Write(this.DifficultyApproachRate);
			class31_0.Write(this.DifficultyCircleSize);
			class31_0.Write(this.DifficultyHpDrainRate);
			class31_0.Write(this.DifficultyOverall);
			class31_0.Write(this.DifficultySliderMultiplier);
			for (int i = 0; i < 4; i++)
			{
				class31_0.Write<int, double>(this.dictionary_0[i]);
			}
			class31_0.Write(this.int_9);
			class31_0.Write(this.int_16);
			class31_0.Write(this.int_14);
			class31_0.Write<Class340>(this.list_1);
			class31_0.Write(this.int_2);
			class31_0.Write(this.int_3);
			class31_0.Write(this.int_5);
			class31_0.Write((byte)this.rankings_1);
			class31_0.Write((byte)this.rankings_0);
			class31_0.Write((byte)this.rankings_2);
			class31_0.Write((byte)this.rankings_3);
			class31_0.Write((short)this.int_13);
			class31_0.Write(this.float_1);
			class31_0.Write((byte)this.method_5());
			class31_0.Write(this.string_13);
			class31_0.Write(this.Tags);
			class31_0.Write((short)this.int_12);
			class31_0.Write(this.string_10);
			class31_0.Write(this.bool_13);
			class31_0.Write(this.dateTime_0);
			class31_0.Write(this.bool_10);
			class31_0.Write(this.string_4);
			class31_0.Write(this.long_0);
			class31_0.Write(this.bool_22);
			class31_0.Write(this.bool_23);
			class31_0.Write(this.bool_24);
			class31_0.Write(this.bool_25);
			class31_0.Write(this.bool_26);
			class31_0.Write(this.int_7);
			class31_0.Write((byte)this.int_18);
		}
	}
}
