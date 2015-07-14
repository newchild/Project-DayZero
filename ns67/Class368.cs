using Microsoft.Xna.Framework;
using ns23;
using ns24;
using ns26;
using ns29;
using ns59;
using ns60;
using ns8;
using ns89;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.Events;
using osu.GameplayElements.HitObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ns67
{
	// Token: 0x02000374 RID: 884
	internal sealed class Class368
	{
		// Token: 0x02000375 RID: 885
		[CompilerGenerated]
		private sealed class Class369
		{
			// Token: 0x04001546 RID: 5446
			public int int_0;

			// Token: 0x06001AB8 RID: 6840
			// RVA: 0x00016679 File Offset: 0x00014879
			public bool method_0(Class367 class367_0)
			{
				return class367_0.int_0 == this.int_0 && class367_0.double_0 == 0.0 && !class367_0.bool_0;
			}
		}

		// Token: 0x04001537 RID: 5431
		internal bool bool_0;

		// Token: 0x04001538 RID: 5432
		internal bool bool_1;

		// Token: 0x04001539 RID: 5433
		internal bool bool_2;

		// Token: 0x0400153A RID: 5434
		internal bool bool_3;

		// Token: 0x0400153B RID: 5435
		internal bool bool_4;

		// Token: 0x04001535 RID: 5429
		private Class301 class301_0;

		// Token: 0x04001541 RID: 5441
		private Class305[] class305_0;

		// Token: 0x04001536 RID: 5430
		private Class872 class872_0;

		// Token: 0x0400153C RID: 5436
		private Dictionary<string, string> dictionary_0;

		// Token: 0x0400153D RID: 5437
		private Dictionary<string, double> dictionary_1;

		// Token: 0x0400153E RID: 5438
		private Dictionary<string, bool> dictionary_2;

		// Token: 0x0400153F RID: 5439
		private Dictionary<string, bool> dictionary_3;

		// Token: 0x04001534 RID: 5428
		private Editor editor_0;

		// Token: 0x04001545 RID: 5445
		private int int_0 = 1;

		// Token: 0x04001540 RID: 5440
		private List<Class367> list_0;

		// Token: 0x04001542 RID: 5442
		private List<string> list_1;

		// Token: 0x04001543 RID: 5443
		private string string_0 = "";

		// Token: 0x04001544 RID: 5444
		private string string_1 = "";

		// Token: 0x06001AAC RID: 6828
		// RVA: 0x000833E4 File Offset: 0x000815E4
		internal Class368(Editor editor_1)
		{
			this.editor_0 = editor_1;
			this.class301_0 = (editor_1.class297_0 as Class301);
			this.class872_0 = editor_1.class872_0;
			this.dictionary_0 = new Dictionary<string, string>();
			this.dictionary_1 = new Dictionary<string, double>();
			this.dictionary_2 = new Dictionary<string, bool>();
			this.dictionary_3 = new Dictionary<string, bool>();
			this.list_0 = new List<Class367>();
			this.list_1 = new List<string>();
			this.class305_0 = new Class305[10];
		}

		// Token: 0x06001AAD RID: 6829
		// RVA: 0x00083488 File Offset: 0x00081688
		public void Clear()
		{
			this.dictionary_0.Clear();
			this.dictionary_1.Clear();
			this.dictionary_2.Clear();
			this.dictionary_3.Clear();
			this.list_0.Clear();
			this.list_1.Clear();
		}

		// Token: 0x06001AAE RID: 6830
		// RVA: 0x000834D8 File Offset: 0x000816D8
		internal bool method_0(string string_2, string string_3)
		{
			string_2 = Class34.smethod_15(string_2);
			this.string_0 = Path.GetDirectoryName(string_2);
			Class466.Current.DifficultyCircleSize = 1f;
			try
			{
				using (FileStream fileStream = new FileStream(string_2, FileMode.Open))
				{
					using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(string_3)))
					{
						while (!streamReader.EndOfStream)
						{
							string text = streamReader.ReadLine();
							if (text.IndexOf('#') >= 0)
							{
								text = text.Substring(1);
								if (text.IndexOf(':') > 0)
								{
									string[] array = text.Split(new char[]
									{
										':'
									});
									if (array.Length == 2)
									{
										array[0] = array[0].Trim();
										array[1] = array[1].Trim();
										if (array[0].Length == 5)
										{
											if (!this.method_6(array))
											{
												this.list_1.Add(text);
												continue;
											}
											continue;
										}
									}
								}
								int num = text.IndexOf(' ');
								if (num > 0)
								{
									string[] array2 = new string[]
									{
										text.Substring(0, num).Trim().ToUpper(),
										text.Substring(num).Trim()
									};
									string key3;
									bool result;
									Class367 class;
									int num3;
									if (array2[0].StartsWith("BPM") && array2[0].Length == 5)
									{
										string key = array2[0].Substring(3, 2);
										this.dictionary_1.Add(key, double.Parse(array2[1], Class115.numberFormatInfo_0));
									}
									else if (array2[0].StartsWith("WAV") && array2[0].Length == 5)
									{
										string key2 = array2[0].Substring(3, 2);
										this.dictionary_0.Add(key2, this.method_2(array2[1]));
									}
									else
										switch (key3 = array2[0])
										{
										case "PLAYER":
											if (int.Parse(array2[1]) != 1)
											{
												MessageBox.Show("Can not convert 2 player style bms file.");
												result = false;
												return result;
											}
											break;
										case "TITLE":
											if (this.bool_3)
											{
												Class466.Current.Title = array2[1];
												Class466.Current.TitleUnicode = array2[1];
											}
											break;
										case "ARTIST":
											if (this.bool_3)
											{
												Class466.Current.Artist = array2[1];
												Class466.Current.ArtistUnicode = array2[1];
											}
											break;
										case "BPM":
											class = new Class367();
											class.double_2 = double.Parse(array2[1], Class115.numberFormatInfo_0);
											this.list_0.Add(class);
											break;
										case "STAGEFILE":
											if (this.bool_2)
											{
												Class466.Current.string_2 = array2[1];
												this.method_3(array2[1]);
											}
											break;
										case "PLAYLEVEL":
											if (this.bool_3)
											{
												Class466.Current.string_14 = "Lv." + array2[1];
											}
											break;
										case "RANK":
											if (this.bool_3)
											{
												num3 = int.Parse(array2[1], Class115.numberFormatInfo_0);
												Class466.Current.DifficultyHpDrainRate = (float)((byte)Math.Max(4, Math.Min(9, 9 - num3 * 2)));
												Class466.Current.DifficultyOverall = Class466.Current.DifficultyHpDrainRate;
											}
											break;
										case "LNTYPE":
											this.int_0 = int.Parse(array2[1], Class115.numberFormatInfo_0);
											break;
										case "LNOBJ":
											this.string_1 = array2[1];
											break;
										}
								}
							}
						}
					}
				}
				this.list_0.Sort();
				this.method_1();
				byte b = (byte)Math.Round((double)Class466.Current.DifficultyCircleSize);
				if ((b == 6 || b == 8) && !Class466.Current.bool_16)
				{
					Class466.Current.DifficultyCircleSize = (float)(b - 1);
				}
				this.bool_4 = !Class466.Current.bool_16;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					string[] array3 = this.list_1[i].Split(new char[]
					{
						':'
					});
					if (array3.Length == 2)
					{
						array3[0] = array3[0].Trim();
						array3[1] = array3[1].Trim();
						if (array3[0].Length == 5)
						{
							this.method_8(array3);
						}
					}
				}
				for (int j = 0; j < this.class305_0.Length; j++)
				{
					if (this.class305_0[j] != null)
					{
						IL_610:
						throw new Exception("Something wrong with the bms");
					}
				}
				List<Class340> list = new List<Class340>(this.list_0.Count);
				for (int k = 0; k < this.list_0.Count; k++)
				{
					Class367 class2 = this.list_0[k];
					Class340 item = new Class340((double)((int)class2.double_1), class2.bool_0 ? (60000.0 / class2.double_2) : -100.0, (Enum37)(class2.double_3 * 4.0), SampleSet.None, Enum38.const_0, 70, class2.bool_0, Enum39.flag_0);
					list.Add(item);
				}
				Class331.smethod_15(list);
				if (!this.bool_0)
				{
					foreach (KeyValuePair<string, bool> current in this.dictionary_2)
					{
						this.method_3(current.Key);
					}
				}
				if (!this.bool_1)
				{
					using (Dictionary<string, bool>.Enumerator enumerator2 = this.dictionary_3.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							KeyValuePair<string, bool> current2 = enumerator2.Current;
							this.method_3(current2.Key);
						}
						goto IL_61B;
					}
					goto IL_610;
				}
				IL_61B:;
			}
			catch (Exception)
			{
				MessageBox.Show("Convert failed");
				bool result = false;
				return result;
			}
			return true;
		}

		// Token: 0x06001AAF RID: 6831
		// RVA: 0x00083B94 File Offset: 0x00081D94
		private void method_1()
		{
			Class367 class = this.list_0[0].Clone();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class367 class2 = this.list_0[i];
				class2.double_1 = ((double)class2.int_0 + class2.double_0 - ((double)class.int_0 + class.double_0)) * (240000.0 / class.double_2) * class.double_3 + class.double_1;
				class.double_1 = class2.double_1;
				class.int_0 = class2.int_0;
				class.double_0 = class2.double_0;
				if (class2.double_2 != -1.0)
				{
					class.double_2 = class2.double_2;
				}
				else
				{
					class2.double_2 = class.double_2;
				}
				if (class2.double_3 != class.double_3)
				{
					class.double_3 = class2.double_3;
				}
			}
		}

		// Token: 0x06001AB0 RID: 6832
		// RVA: 0x00083C88 File Offset: 0x00081E88
		private string method_2(string string_2)
		{
			if (Regex.IsMatch(string_2, "\\.(mp3|wav|ogg)$"))
			{
				return string_2;
			}
			string text = ".ogg";
			for (int i = 0; i < 3; i++)
			{
				if (i == 1)
				{
					text = ".wav";
				}
				else if (i == 2)
				{
					text = ".mp3";
				}
				if (File.Exists(this.string_0 + string_2 + text))
				{
					return string_2 + text;
				}
			}
			return "";
		}

		// Token: 0x06001AB1 RID: 6833
		// RVA: 0x00083CF0 File Offset: 0x00081EF0
		private void method_3(string string_2)
		{
			string text = Path.Combine(this.string_0, string_2);
			string text2 = Path.Combine(Class466.Current.method_3(), string_2);
			if (File.Exists(text2))
			{
				return;
			}
			if (File.Exists(text))
			{
				File.Copy(text, text2, true);
			}
		}

		// Token: 0x06001AB2 RID: 6834
		// RVA: 0x00083D34 File Offset: 0x00081F34
		private int[] method_4(string string_2)
		{
			return new int[]
			{
				int.Parse(string_2.Substring(0, 3)),
				int.Parse(string_2.Substring(3, 2))
			};
		}

		// Token: 0x06001AB3 RID: 6835
		// RVA: 0x00083D6C File Offset: 0x00081F6C
		private List<string> method_5(string string_2)
		{
			int i = 0;
			List<string> list = new List<string>(string_2.Length / 2);
			while (i < string_2.Length - 1)
			{
				list.Add(string_2.Substring(i, 2));
				i += 2;
			}
			return list;
		}

		// Token: 0x06001AB4 RID: 6836
		// RVA: 0x00083DAC File Offset: 0x00081FAC
		private bool method_6(string[] string_2)
		{
			int[] array = this.method_4(string_2[0]);
			List<string> list = this.method_5(string_2[1]);
			int num = array[1];
			switch (num)
			{
			case 2:
			{
				Class368.Class369 class = new Class368.Class369();
				class.int_0 = array[0];
				Class367 class2 = this.list_0.Find(new Predicate<Class367>(class.method_0));
				if (class2 == null)
				{
					Class367 class3 = new Class367();
					class3.double_3 = double.Parse(string_2[1], Class115.numberFormatInfo_0);
					class3.int_0 = class.int_0;
					class3.double_0 = 0.0;
					class3.bool_0 = false;
					this.list_0.Add(class3);
				}
				else
				{
					class2.double_3 = double.Parse(string_2[1], Class115.numberFormatInfo_0);
				}
				Class367 class4 = new Class367();
				class4.int_0 = class.int_0 + 1;
				class4.double_0 = 0.0;
				class4.bool_0 = false;
				this.list_0.Add(class4);
				return true;
			}
			case 3:
				for (int i = 0; i < list.Count; i++)
				{
					if (!(list[i] == "00"))
					{
						Class367 class5 = new Class367();
						class5.int_0 = array[0];
						class5.double_0 = 1.0 * (double)i / (double)list.Count;
						class5.double_2 = (double)Convert.ToInt32(list[i], 16);
						this.list_0.Add(class5);
					}
				}
				return true;
			case 4:
			case 5:
			case 6:
			case 7:
			case 9:
			case 10:
			case 17:
				break;
			case 8:
				for (int j = 0; j < list.Count; j++)
				{
					double double_;
					if (!(list[j] == "00") && this.dictionary_1.TryGetValue(list[j], out double_))
					{
						Class367 class6 = new Class367();
						class6.int_0 = array[0];
						class6.double_0 = 1.0 * (double)j / (double)list.Count;
						class6.double_2 = double_;
						this.list_0.Add(class6);
					}
				}
				return true;
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 18:
			case 19:
			{
				int num2 = (array[1] == 16) ? 0 : ((array[1] < 16) ? (array[1] - 10) : (array[1] - 12));
				if ((double)num2 >= Math.Round((double)Class466.Current.DifficultyCircleSize))
				{
					Class466.Current.DifficultyCircleSize = (float)((byte)(num2 + 1));
				}
				if (num2 == 0)
				{
					Class466.Current.bool_16 = true;
				}
				return false;
			}
			default:
				switch (num)
				{
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 58:
				case 59:
				{
					int num3 = (array[1] == 56) ? 0 : ((array[1] < 56) ? (array[1] - 50) : (array[1] - 52));
					if ((double)num3 >= Math.Round((double)Class466.Current.DifficultyCircleSize))
					{
						Class466.Current.DifficultyCircleSize = (float)((byte)(num3 + 1));
					}
					if (num3 == 0)
					{
						Class466.Current.bool_16 = true;
					}
					return false;
				}
				}
				break;
			}
			return false;
		}

		// Token: 0x06001AB5 RID: 6837
		// RVA: 0x000840D0 File Offset: 0x000822D0
		private double method_7(int int_1, double double_0)
		{
			Class367 class = new Class367();
			class.int_0 = int_1;
			class.double_0 = double_0;
			int num = this.list_0.BinarySearch(class);
			if (num < 0)
			{
				num = ~num;
			}
			if (num > this.list_0.Count)
			{
				num = this.list_0.Count;
			}
			Class367 class2 = this.list_0[(num == 0) ? 0 : (num - 1)];
			return ((double)class.int_0 + class.double_0 - ((double)class2.int_0 + class2.double_0)) * (240000.0 / class2.double_2) * class2.double_3 + class2.double_1;
		}

		// Token: 0x06001AB6 RID: 6838
		// RVA: 0x00084170 File Offset: 0x00082370
		private void method_8(string[] string_2)
		{
			int[] array = this.method_4(string_2[0]);
			List<string> list = this.method_5(string_2[1]);
			int num = array[1];
			if (num != 1)
			{
				switch (num)
				{
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 18:
				case 19:
					for (int i = 0; i < list.Count; i++)
					{
						if (!(list[i] == "00"))
						{
							int num2 = (array[1] == 16) ? 0 : ((array[1] < 16) ? (array[1] - 10) : (array[1] - 12));
							if (this.bool_4)
							{
								num2--;
							}
							if (this.int_0 == 2 && list[i] == this.string_1 && this.class305_0[num2] != null)
							{
								this.class305_0[num2].EndTime = (int)this.method_7(array[0], 1.0 * (double)i / (double)list.Count);
								this.class305_0[num2].Type = HitObjectType.Hold;
								this.class305_0[num2] = null;
							}
							else
							{
								Class306 class = new Class306(this.class301_0, new Vector2((float)this.class301_0.class421_0.list_0[num2].method_14(), 192f), (int)this.method_7(array[0], 1.0 * (double)i / (double)list.Count), false);
								string key = "";
								if (this.dictionary_0.TryGetValue(list[i], out key) && !this.bool_0)
								{
									this.dictionary_2[key] = true;
									class.string_0 = key;
								}
								else
								{
									class.int_3 = 1;
								}
								this.class301_0.Add(class, true);
								if (this.int_0 == 2)
								{
									this.class305_0[num2] = class;
								}
							}
						}
					}
					return;
				case 17:
					break;
				default:
					switch (num)
					{
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 58:
					case 59:
						if (this.int_0 != 1)
						{
							return;
						}
						for (int j = 0; j < list.Count; j++)
						{
							if (!(list[j] == "00"))
							{
								int num3 = (array[1] == 56) ? 0 : ((array[1] < 56) ? (array[1] - 50) : (array[1] - 52));
								if (this.bool_4)
								{
									num3--;
								}
								if (this.class305_0[num3] != null)
								{
									this.class305_0[num3].EndTime = (int)this.method_7(array[0], 1.0 * (double)j / (double)list.Count);
									this.class305_0[num3] = null;
								}
								else
								{
									Class308 class2 = new Class308(this.class301_0, new Vector2((float)this.class301_0.class421_0.list_0[num3].method_14(), 192f), (int)this.method_7(array[0], 1.0 * (double)j / (double)list.Count), false, false, false, false, 0);
									string key2 = "";
									if (this.dictionary_0.TryGetValue(list[j], out key2) && !this.bool_0)
									{
										this.dictionary_2[key2] = true;
										class2.string_0 = key2;
									}
									else
									{
										class2.int_3 = 1;
									}
									this.class301_0.Add(class2, true);
									this.class305_0[num3] = class2;
								}
							}
						}
						break;
					case 57:
						break;
					default:
						return;
					}
					break;
				}
				return;
			}
			if (this.bool_1)
			{
				return;
			}
			for (int k = 0; k < list.Count; k++)
			{
				string key3;
				if (!(list[k] == "00") && this.dictionary_0.TryGetValue(list[k], out key3))
				{
					Class704 class3 = new Class704(-1, key3, (int)this.method_7(array[0], 1.0 * (double)k / (double)list.Count), StoryLayer.Background, 70);
					class3.bool_2 = true;
					this.class872_0.Add(class3);
					this.dictionary_3[key3] = true;
				}
			}
		}
	}
}
