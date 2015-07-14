using Microsoft.Xna.Framework;
using ns14;
using ns18;
using ns24;
using ns25;
using ns29;
using ns3;
using ns30;
using ns40;
using ns64;
using ns78;
using ns8;
using ns90;
using osu_common;
using osu_common.Bancho;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using SevenZip.Compression.LZMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace ns76
{
	// Token: 0x02000441 RID: 1089
	internal class Class512 : ICloneable, IComparable<Class512>, bSerializable
	{
		// Token: 0x04001B5B RID: 7003
		internal bool bool_0 = true;

		// Token: 0x04001B67 RID: 7015
		internal bool bool_1;

		// Token: 0x04001B6B RID: 7019
		internal bool bool_2;

		// Token: 0x04001B6C RID: 7020
		internal bool bool_3;

		// Token: 0x04001B6E RID: 7022
		internal bool bool_4;

		// Token: 0x04001B72 RID: 7026
		internal byte[] byte_0;

		// Token: 0x04001B82 RID: 7042
		internal Class296 class296_0;

		// Token: 0x04001B63 RID: 7011
		internal Class623<Mods> class623_0 = Mods.None;

		// Token: 0x04001B7B RID: 7035
		internal Class861 class861_0;

		// Token: 0x04001B62 RID: 7010
		internal DateTime dateTime_0;

		// Token: 0x04001B83 RID: 7043
		private Delegate59 delegate59_0;

		// Token: 0x04001B84 RID: 7044
		private Delegate59 delegate59_1;

		// Token: 0x04001B7A RID: 7034
		internal double double_0;

		// Token: 0x04001B7D RID: 7037
		internal double double_1;

		// Token: 0x04001B78 RID: 7032
		internal Enum66 enum66_0;

		// Token: 0x04001B68 RID: 7016
		internal int int_0;

		// Token: 0x04001B6A RID: 7018
		internal int int_1;

		// Token: 0x04001B6D RID: 7021
		internal int int_2;

		// Token: 0x04001B79 RID: 7033
		internal int int_3;

		// Token: 0x04001B7C RID: 7036
		internal int int_4 = 20150414;

		// Token: 0x04001B81 RID: 7041
		internal int int_5;

		// Token: 0x04001B66 RID: 7014
		internal List<Vector2> list_0;

		// Token: 0x04001B73 RID: 7027
		internal List<Class14> list_1;

		// Token: 0x04001B74 RID: 7028
		internal List<int> list_2;

		// Token: 0x04001B75 RID: 7029
		internal List<int> list_3;

		// Token: 0x04001B76 RID: 7030
		internal List<bool> list_4 = new List<bool>();

		// Token: 0x04001B77 RID: 7031
		internal List<Struct13> list_5 = new List<Struct13>();

		// Token: 0x04001B69 RID: 7017
		internal long long_0;

		// Token: 0x04001B80 RID: 7040
		internal MemoryStream memoryStream_0;

		// Token: 0x04001B64 RID: 7012
		internal PlayModes playModes_0;

		// Token: 0x04001B5A RID: 7002
		private static string string_0 = "h89f2-890h2h89b34g-h80g134n90133";

		// Token: 0x04001B65 RID: 7013
		internal string string_1 = string.Empty;

		// Token: 0x04001B6F RID: 7023
		internal string string_2;

		// Token: 0x04001B70 RID: 7024
		internal string string_3;

		// Token: 0x04001B71 RID: 7025
		internal string string_4;

		// Token: 0x04001B7F RID: 7039
		internal string string_5;

		// Token: 0x04001B5C RID: 7004
		internal ushort ushort_0;

		// Token: 0x04001B5D RID: 7005
		internal ushort ushort_1;

		// Token: 0x04001B5E RID: 7006
		internal ushort ushort_2;

		// Token: 0x04001B5F RID: 7007
		internal ushort ushort_3;

		// Token: 0x04001B60 RID: 7008
		internal ushort ushort_4;

		// Token: 0x04001B61 RID: 7009
		internal ushort ushort_5;

		// Token: 0x04001B7E RID: 7038
		internal ushort ushort_6;

		// Token: 0x0600231D RID: 8989
		// RVA: 0x000D3DC4 File Offset: 0x000D1FC4
		internal Class512()
		{
			this.list_1 = new List<Class14>();
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x0600231E RID: 8990
		// RVA: 0x000D3E2C File Offset: 0x000D202C
		internal Class512(Class296 class296_1, string string_6)
		{
			if (class296_1 != null)
			{
				this.string_1 = class296_1.string_3;
			}
			this.class296_0 = class296_1;
			this.string_2 = string_6;
			this.dateTime_0 = DateTime.Now;
			this.bool_2 = false;
			this.bool_4 = false;
			this.list_1 = new List<Class14>();
		}

		// Token: 0x0600231F RID: 8991
		// RVA: 0x000D3EC0 File Offset: 0x000D20C0
		internal Class512(string string_6, Class296 class296_1)
		{
			this.class861_0 = new Class861();
			this.bool_1 = true;
			if (class296_1 != null)
			{
				this.class296_0 = class296_1;
				this.string_1 = class296_1.string_3;
			}
			this.bool_4 = false;
			this.list_1 = new List<Class14>();
			string[] array = string_6.Split(new char[]
			{
				'|'
			});
			this.bool_2 = true;
			this.long_0 = Convert.ToInt64(array[0]);
			this.string_2 = array[1];
			this.class861_0.Name = this.string_2;
			this.int_3 = Convert.ToInt32(array[2]);
			this.int_0 = (int)Convert.ToUInt16(array[3]);
			this.ushort_2 = Convert.ToUInt16(array[4]);
			this.ushort_0 = Convert.ToUInt16(array[5]);
			this.ushort_1 = Convert.ToUInt16(array[6]);
			this.ushort_5 = Convert.ToUInt16(array[7]);
			this.ushort_4 = Convert.ToUInt16(array[8]);
			this.ushort_3 = Convert.ToUInt16(array[9]);
			this.bool_4 = (array[10] == "1");
			this.class623_0 = (Mods)Convert.ToInt32(array[11]);
			Class861 arg_18B_0 = this.class861_0;
			string[] arg_185_0 = array;
			int arg_185_1 = 12;
			int num = 13;
			arg_18B_0.int_1 = Convert.ToInt32(arg_185_0[arg_185_1]);
			if (array[13].Length > 0)
			{
				this.int_1 = Convert.ToInt32(array[num]);
			}
			num++;
			try
			{
				this.dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)int.Parse(array[num]));
				if (this.dateTime_0 < new DateTime(1990, 5, 31))
				{
					this.dateTime_0 = DateTime.Now;
				}
			}
			catch
			{
				this.dateTime_0 = DateTime.Now;
			}
		}

		// Token: 0x06002320 RID: 8992
		// RVA: 0x000D40E8 File Offset: 0x000D22E8
		internal Class512(Struct13 struct13_0, string string_6)
		{
			this.bool_2 = struct13_0.bool_0;
			this.string_2 = string_6;
			this.ushort_1 = struct13_0.ushort_1;
			this.ushort_0 = struct13_0.ushort_0;
			this.ushort_2 = struct13_0.ushort_2;
			this.ushort_3 = struct13_0.ushort_3;
			this.ushort_4 = struct13_0.ushort_4;
			this.ushort_5 = struct13_0.ushort_5;
			this.int_3 = struct13_0.int_2;
			this.int_0 = (int)struct13_0.ushort_7;
			this.bool_4 = struct13_0.bool_1;
			this.double_1 = (double)struct13_0.int_0;
			this.ushort_6 = struct13_0.ushort_6;
			this.class623_0 = Class876.class623_0;
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x06002346 RID: 9030
		// RVA: 0x0000F044 File Offset: 0x0000D244
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06002341 RID: 9025
		// RVA: 0x000D5744 File Offset: 0x000D3944
		public int CompareTo(Class512 obj)
		{
			int num = obj.int_3.CompareTo(this.int_3);
			if (num != 0)
			{
				return num;
			}
			return this.dateTime_0.CompareTo(obj.dateTime_0);
		}

		// Token: 0x06002322 RID: 8994
		// RVA: 0x000D41F4 File Offset: 0x000D23F4
		private string method_0()
		{
			string text = string.Empty;
			for (int i = 0; i < (int)Class62.enum43_0; i++)
			{
				text += ' ';
			}
			Class62.enum43_0 = Enum43.flag_0;
			string str = this.string_2;
			return string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}:{10}:{11}:{12}:{13}:{14}:{15}:{16:yyMMddHHmmss}:{17}", new object[]
			{
				this.string_1,
				str + (((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? " " : ""),
				this.method_2(),
				this.ushort_1,
				this.ushort_0,
				this.ushort_2,
				this.ushort_3,
				this.ushort_4,
				this.ushort_5,
				this.int_3,
				this.int_0,
				this.bool_4,
				this.vmethod_4(),
				(int)this.class623_0,
				this.bool_2,
				(int)this.playModes_0,
				this.dateTime_0.ToUniversalTime(),
				20150414 + text
			});
		}

		// Token: 0x06002323 RID: 8995
		// RVA: 0x000D4368 File Offset: 0x000D2568
		internal string method_1()
		{
			return Class33.smethod_2(string.Concat(new object[]
			{
				this.int_0,
				"osu",
				this.string_2,
				this.string_1,
				this.int_3,
				this.vmethod_4()
			}));
		}

		// Token: 0x0600232F RID: 9007
		// RVA: 0x000D4A18 File Offset: 0x000D2C18
		internal string method_10()
		{
			if (!string.IsNullOrEmpty(this.string_4))
			{
				return this.string_4;
			}
			StringBuilder stringBuilder = new StringBuilder();
			float num = 0f;
			if (this.list_0 == null)
			{
				return null;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Vector2 vector = this.list_0[i];
				if (vector.X - num > 2000f || i == this.list_0.Count - 1 || i == 0)
				{
					num = vector.X;
					stringBuilder.AppendFormat("{0}|{1},", Math.Round((double)vector.X, 2).ToString(Class115.numberFormatInfo_0), Math.Round((double)vector.Y, 2).ToString(Class115.numberFormatInfo_0));
				}
			}
			this.list_0.Clear();
			this.list_0 = null;
			this.string_4 = stringBuilder.ToString();
			return this.string_4;
		}

		// Token: 0x06002330 RID: 9008
		// RVA: 0x000D4B0C File Offset: 0x000D2D0C
		internal void method_11()
		{
			if (this.enum66_0 > Enum66.const_0)
			{
				return;
			}
			this.enum66_0 = Enum66.const_1;
			if (!Class115.smethod_33())
			{
				return;
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += new DoWorkEventHandler(this.method_18);
			backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x06002331 RID: 9009
		// RVA: 0x000D4B50 File Offset: 0x000D2D50
		internal void method_12()
		{
			Class131 class = new Class131(string.Format("http://osu.ppy.sh/web/osu-getreplay.php?c={0}&m={1}&u={2}&h={3}", new object[]
			{
				this.long_0,
				(int)this.playModes_0,
				Class341.class605_20,
				Class341.class605_17
			}));
			class.method_0(new Class131.Delegate9(this.method_13));
			Class169.smethod_0(class);
		}

		// Token: 0x06002332 RID: 9010
		// RVA: 0x0001BE75 File Offset: 0x0001A075
		private void method_13(byte[] byte_1, Exception exception_0)
		{
			this.byte_0 = byte_1;
			this.method_19();
			if (this.delegate59_0 != null)
			{
				this.delegate59_0(this);
			}
		}

		// Token: 0x06002333 RID: 9011
		// RVA: 0x000D4BBC File Offset: 0x000D2DBC
		internal void method_14(Delegate59 delegate59_2)
		{
			Delegate59 delegate = this.delegate59_0;
			Delegate59 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate59 value = (Delegate59)Delegate.Combine(delegate2, delegate59_2);
				delegate = Interlocked.CompareExchange<Delegate59>(ref this.delegate59_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002334 RID: 9012
		// RVA: 0x000D4BF4 File Offset: 0x000D2DF4
		internal void method_15(Delegate59 delegate59_2)
		{
			Delegate59 delegate = this.delegate59_0;
			Delegate59 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate59 value = (Delegate59)Delegate.Remove(delegate2, delegate59_2);
				delegate = Interlocked.CompareExchange<Delegate59>(ref this.delegate59_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002335 RID: 9013
		// RVA: 0x000D4C2C File Offset: 0x000D2E2C
		internal void method_16(Delegate59 delegate59_2)
		{
			Delegate59 delegate = this.delegate59_1;
			Delegate59 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate59 value = (Delegate59)Delegate.Combine(delegate2, delegate59_2);
				delegate = Interlocked.CompareExchange<Delegate59>(ref this.delegate59_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002336 RID: 9014
		// RVA: 0x000D4C64 File Offset: 0x000D2E64
		internal void method_17(Delegate59 delegate59_2)
		{
			Delegate59 delegate = this.delegate59_1;
			Delegate59 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate59 value = (Delegate59)Delegate.Remove(delegate2, delegate59_2);
				delegate = Interlocked.CompareExchange<Delegate59>(ref this.delegate59_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002337 RID: 9015
		// RVA: 0x000D4C9C File Offset: 0x000D2E9C
		private void method_18(object sender, DoWorkEventArgs e)
		{
			Class115.class861_0.class533_0.Text = Class41.GetString(OsuString.Score_SubmittingScore);
			try
			{
				byte[] byte_ = new byte[0];
				if (this.bool_2)
				{
					if (Class466.Current.class512_0 != null && this.int_3 > Class466.Current.class512_0.int_3)
					{
						Class466.Current.list_0.Clear();
					}
					this.byte_0 = SevenZipHelper.Compress(new ASCIIEncoding().GetBytes(this.method_4()));
					byte_ = this.byte_0;
				}
				Class132 class = new Class132("http://osu.ppy.sh/web/osu-submit-modular.php", byte_, "replay", "score");
				string text = null;
				if (this.bool_2)
				{
					Process[] array = Class115.process_0;
					Class115.process_0 = null;
					if (array == null || array.Length == 0)
					{
						array = Process.GetProcesses();
					}
					StringBuilder stringBuilder = new StringBuilder();
					Process[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						Process process = array2[i];
						string text2 = string.Empty;
						try
						{
							text2 = process.MainModule.FileName;
							FileInfo fileInfo = new FileInfo(text2);
							if (fileInfo != null)
							{
								text2 = Class33.smethod_2(fileInfo.Length.ToString()) + " " + text2;
							}
						}
						catch
						{
						}
						stringBuilder.AppendLine(string.Concat(new string[]
						{
							text2,
							" | ",
							process.ProcessName,
							" (",
							process.MainWindowTitle,
							")"
						}));
					}
					class.class167_0.Items.method_0("pl", Class33.smethod_0(stringBuilder.ToString(), Class512.string_0, ref text));
				}
				else
				{
					class.class167_0.Items.method_0("x", this.bool_3 ? "1" : "0");
					class.class167_0.Items.method_0("ft", this.int_2.ToString());
				}
				char[] expr_1FC_cp_0 = Class115.char_0;
				int expr_1FC_cp_1 = 5;
				expr_1FC_cp_0[expr_1FC_cp_1] += '\u0001';
				class.class167_0.Items.method_0("score", Class33.smethod_0(this.method_0(), Class512.string_0, ref text));
				class.class167_0.Items.method_0("fs", Class33.smethod_0(this.method_26(), Class512.string_0, ref text));
				class.class167_0.Items.method_0("c1", Class115.smethod_23());
				class.class167_0.Items.method_0("pass", Class341.class605_17);
				class.class167_0.Items.method_0("s", Class33.smethod_0(Class115.string_0, Class512.string_0, ref text));
				try
				{
					if (this.bool_2 && this.memoryStream_0 != null)
					{
						class.class167_0.Items.method_1("i", "i").method_4(this.memoryStream_0.ToArray());
					}
					else
					{
						class.class167_0.Items.method_0("i", string.Empty);
					}
				}
				catch
				{
				}
				Class115.int_33++;
				this.memoryStream_0 = null;
				class.class167_0.Items.method_0("iv", text);
				int num = this.bool_2 ? 10 : 2;
				int num2 = 7500;
				bool flag = false;
				while (num-- > 0)
				{
					try
					{
						this.string_5 = class.method_7(false);
						if (this.string_5.Contains("error:"))
						{
							string key;
							switch (key = this.string_5.Replace("error: ", string.Empty))
							{
							case "nouser":
								Class723.smethod_4(Class41.GetString(OsuString.Score_ErrorNoUser));
								break;
							case "pass":
								Class723.smethod_4(Class41.GetString(OsuString.Score_ErrorPassword));
								break;
							case "inactive":
							case "ban":
								Class723.smethod_4("ERROR: Your account is no longer active.  Please send an email to accounts@ppy.sh if you think this is a mistake.");
								break;
							case "beatmap":
								if (this.class296_0 != null && this.class296_0.submissionStatus_0 > SubmissionStatus.Pending)
								{
									Class723.smethod_4(Class41.GetString(OsuString.Score_ErrorBeatmap));
									this.class296_0.submissionStatus_0 = SubmissionStatus.Unknown;
								}
								break;
							case "disabled":
								Class723.smethod_4(Class41.GetString(OsuString.Score_ErrorDisabled));
								break;
							case "oldver":
								Class723.smethod_4(Class41.GetString(OsuString.Score_ErrorVersion));
								Class115.smethod_0(true, false);
								break;
							}
							flag = true;
						}
						break;
					}
					catch
					{
					}
					if (num2 >= 60000)
					{
						Class723.smethod_4(string.Format(Class41.GetString(OsuString.Score_SubmissionFailed), num2 / 60000));
					}
					Thread.Sleep(num2);
					num2 *= 2;
				}
				if (flag)
				{
					this.enum66_0 = Enum66.const_2;
					return;
				}
			}
			catch (Exception)
			{
			}
			if (this.delegate59_1 != null)
			{
				this.delegate59_1(this);
			}
			this.enum66_0 = Enum66.const_2;
			if (!this.bool_2)
			{
				Class115.class861_0.method_15();
			}
		}

		// Token: 0x06002338 RID: 9016
		// RVA: 0x000D5278 File Offset: 0x000D3478
		internal void method_19()
		{
			if (this.byte_0 != null && this.byte_0.Length != 0)
			{
				if (this.list_1 == null)
				{
					this.list_1 = new List<Class14>();
				}
				else
				{
					this.list_1.Clear();
				}
				try
				{
					this.method_20(new ASCIIEncoding().GetString(SevenZipHelper.Decompress(this.byte_0)));
				}
				catch (Exception)
				{
					this.list_1.Clear();
				}
				return;
			}
		}

		// Token: 0x06002324 RID: 8996
		// RVA: 0x000D43CC File Offset: 0x000D25CC
		private string method_2()
		{
			string text = string.Format("chickenmcnuggets{0}o15{1}{2}smustard{3}{4}uu{5}{6}{7}{8}{9}{10}{11}" + 'Q' + "{12}{13}{15}{14:yyMMddHHmmss}{16}", new object[]
			{
				(int)(this.ushort_0 + this.ushort_1),
				this.ushort_2,
				this.ushort_3,
				this.ushort_4,
				this.ushort_5,
				this.string_1,
				this.int_0,
				this.bool_4,
				this.string_2,
				this.int_3,
				this.vmethod_4(),
				(int)this.class623_0,
				this.bool_2,
				(int)this.playModes_0,
				this.dateTime_0.ToUniversalTime(),
				20150414,
				Class115.string_0
			});
			string text2 = Class33.smethod_2(text);
			if (text2.Length != 32)
			{
				throw new Exception("checksum failure");
			}
			return text2;
		}

		// Token: 0x06002339 RID: 9017
		// RVA: 0x000D52F4 File Offset: 0x000D34F4
		internal void method_20(string string_6)
		{
			if (string_6.Length > 0)
			{
				string[] array = string_6.Split(new char[]
				{
					','
				});
				Class14 class;
				if (this.list_1.Count > 0)
				{
					class = this.list_1[this.list_1.Count - 1];
				}
				else
				{
					class = new Class14(0, 0f, 0f, pButtonState.None);
				}
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i];
					if (text.Length != 0)
					{
						string[] array3 = text.Split(new char[]
						{
							'|'
						});
						if (array3.Length >= 4)
						{
							if (array3[0] == "-12345")
							{
								this.int_5 = int.Parse(array3[3]);
							}
							else
							{
								pButtonState pButtonState_ = (pButtonState)Enum.Parse(typeof(pButtonState), array3[3]);
								Class14 class2 = new Class14(int.Parse(array3[0]) + class.int_0, float.Parse(array3[1], Class115.numberFormatInfo_0), float.Parse(array3[2], Class115.numberFormatInfo_0), pButtonState_);
								this.list_1.Add(class2);
								class = class2;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600233A RID: 9018
		// RVA: 0x000D5424 File Offset: 0x000D3624
		internal void method_21(string string_6)
		{
			this.list_0 = new List<Vector2>();
			if (string_6.Length > 0)
			{
				string[] array = string_6.Split(new char[]
				{
					','
				});
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text = array2[i];
					if (text.Length != 0)
					{
						string[] array3 = text.Split(new char[]
						{
							'|'
						});
						this.list_0.Add(new Vector2((float)decimal.Parse(array3[0], Class115.numberFormatInfo_0), (float)decimal.Parse(array3[1], Class115.numberFormatInfo_0)));
					}
				}
			}
		}

		// Token: 0x0600233B RID: 9019
		// RVA: 0x0001BE98 File Offset: 0x0001A098
		internal void method_22()
		{
			this.method_10();
			if (this.list_0 != null)
			{
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x0600233F RID: 9023
		// RVA: 0x000D5560 File Offset: 0x000D3760
		public void method_23(Class32 class32_0)
		{
			this.bool_2 = true;
			this.int_4 = class32_0.ReadInt32();
			this.string_1 = class32_0.ReadString();
			this.string_2 = class32_0.ReadString();
			this.string_3 = class32_0.ReadString();
			this.ushort_1 = class32_0.ReadUInt16();
			this.ushort_0 = class32_0.ReadUInt16();
			this.ushort_2 = class32_0.ReadUInt16();
			this.ushort_3 = class32_0.ReadUInt16();
			this.ushort_4 = class32_0.ReadUInt16();
			this.ushort_5 = class32_0.ReadUInt16();
			this.int_3 = class32_0.ReadInt32();
			this.int_0 = (int)class32_0.ReadUInt16();
			this.bool_4 = class32_0.ReadBoolean();
			this.class623_0 = (Mods)class32_0.ReadInt32();
			this.string_4 = class32_0.ReadString();
			this.dateTime_0 = class32_0.method_1();
		}

		// Token: 0x06002343 RID: 9027
		// RVA: 0x0001BEBB File Offset: 0x0001A0BB
		internal void method_24()
		{
			this.list_1 = null;
			this.byte_0 = null;
			this.string_4 = null;
		}

		// Token: 0x06002344 RID: 9028
		// RVA: 0x000D57D0 File Offset: 0x000D39D0
		internal void method_25()
		{
			if (!this.method_9())
			{
				return;
			}
			Class512 class = Class908.smethod_5(this.method_8(), false);
			if (class != null)
			{
				this.byte_0 = class.byte_0;
				this.string_4 = class.string_4;
			}
		}

		// Token: 0x06002345 RID: 9029
		// RVA: 0x000D5810 File Offset: 0x000D3A10
		public string method_26()
		{
			Class296 current = Class466.Current;
			return string.Format("{0}:{1}:{2}:{3}:{4}", new object[]
			{
				current.nullable_0,
				current.bool_22,
				current.bool_23,
				current.bool_24,
				current.object_0
			});
		}

		// Token: 0x06002347 RID: 9031
		// RVA: 0x0001BED2 File Offset: 0x0001A0D2
		internal void method_27()
		{
			File.Delete(this.method_8());
			File.Delete(this.method_7());
		}

		// Token: 0x06002325 RID: 8997
		// RVA: 0x000D4514 File Offset: 0x000D2714
		internal string method_3()
		{
			string text = string.Format("{0}p{1}o{2}o{3}t{4}a{5}r{6}e{7}y{8}o{9}u{10}{11}{12}", new object[]
			{
				(int)(this.ushort_0 + this.ushort_1),
				this.ushort_2,
				this.ushort_3,
				this.ushort_4,
				this.ushort_5,
				this.string_1,
				this.int_0,
				this.bool_4,
				this.string_2,
				this.int_3,
				this.vmethod_4(),
				(int)this.class623_0,
				this.bool_2
			});
			return Class33.smethod_2(text);
		}

		// Token: 0x06002328 RID: 9000
		// RVA: 0x000D45F8 File Offset: 0x000D27F8
		internal string method_4()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.list_1 != null)
			{
				Class14 class = new Class14(0, 0f, 0f, pButtonState.None);
				foreach (Class14 current in this.list_1)
				{
					stringBuilder.AppendFormat("{0}|{1}|{2}|{3},", new object[]
					{
						current.int_0 - class.int_0,
						current.float_0.ToString(Class115.numberFormatInfo_0),
						current.float_1.ToString(Class115.numberFormatInfo_0),
						(int)current.pButtonState_0
					});
					class = current;
				}
			}
			stringBuilder.AppendFormat("{0}|{1}|{2}|{3},", new object[]
			{
				-12345,
				0,
				0,
				this.int_5
			});
			return stringBuilder.ToString();
		}

		// Token: 0x0600232A RID: 9002
		// RVA: 0x0001BE16 File Offset: 0x0001A016
		internal void method_5()
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<Vector2>();
			}
			if (this.list_2 == null)
			{
				this.list_2 = new List<int>();
			}
			if (this.list_3 == null)
			{
				this.list_3 = new List<int>();
			}
		}

		// Token: 0x0600232B RID: 9003
		// RVA: 0x000D4834 File Offset: 0x000D2A34
		internal List<double> method_6(List<int> list_6)
		{
			if (list_6 != null && list_6.Count != 0)
			{
				List<double> list = new List<double>(4);
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 2147483647;
				for (int i = 0; i < list_6.Count; i++)
				{
					if (list_6[i] > num6)
					{
						num6 = list_6[i];
					}
					if (list_6[i] < num7)
					{
						num7 = list_6[i];
					}
					num3 += (double)list_6[i];
					if (list_6[i] >= 0)
					{
						num += (double)list_6[i];
						num4++;
					}
					else
					{
						num2 += (double)list_6[i];
						num5++;
					}
				}
				double num8 = num3 / (double)list_6.Count;
				double num9 = 0.0;
				for (int j = 0; j < list_6.Count; j++)
				{
					num9 += Math.Pow((double)list_6[j] - num8, 2.0);
				}
				num9 /= (double)list_6.Count;
				list.Add((num5 == 0) ? 0.0 : (num2 / (double)num5));
				list.Add((num4 == 0) ? 0.0 : (num / (double)num4));
				list.Add(num8);
				list.Add(num9);
				list.Add(Math.Sqrt(num9));
				list.Add((double)num6);
				list.Add((double)num7);
				return list;
			}
			return null;
		}

		// Token: 0x0600232C RID: 9004
		// RVA: 0x0001BE51 File Offset: 0x0001A051
		internal string method_7()
		{
			return this.method_8().Replace(".osr", ".osg");
		}

		// Token: 0x0600232D RID: 9005
		// RVA: 0x000D49C4 File Offset: 0x000D2BC4
		internal string method_8()
		{
			long num;
			try
			{
				num = this.dateTime_0.ToFileTimeUtc();
			}
			catch
			{
				num = DateTime.Now.ToFileTimeUtc();
			}
			return string.Format("Data\\r\\{0}-{1}.osr", this.string_1, num);
		}

		// Token: 0x0600232E RID: 9006
		// RVA: 0x0001BE68 File Offset: 0x0001A068
		internal bool method_9()
		{
			return File.Exists(this.method_8());
		}

		// Token: 0x0600233E RID: 9022
		// RVA: 0x000D54D0 File Offset: 0x000D36D0
		public void ReadFromStream(Class32 class32_0)
		{
			if (class32_0.BaseStream.Position == 1L)
			{
				this.method_23(class32_0);
			}
			this.byte_0 = class32_0.ReadByteArray();
			if (this.int_4 >= 20140721)
			{
				this.long_0 = class32_0.ReadInt64();
			}
			else if (this.int_4 >= Class344.int_0)
			{
				this.long_0 = (long)class32_0.ReadInt32();
			}
			this.vmethod_5(class32_0);
			if (this.string_3 != this.method_3())
			{
				throw new Exception("fucked score");
			}
		}

		// Token: 0x06002342 RID: 9026
		// RVA: 0x000D577C File Offset: 0x000D397C
		internal void Reset()
		{
			this.ushort_6 = 0;
			this.int_0 = 0;
			this.ushort_5 = 0;
			this.ushort_2 = 0;
			this.ushort_0 = 0;
			this.ushort_1 = 0;
			this.ushort_3 = 0;
			this.ushort_5 = 0;
			this.ushort_4 = 0;
			this.int_3 = 0;
		}

		// Token: 0x0600231C RID: 8988
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_0()
		{
			return true;
		}

		// Token: 0x06002321 RID: 8993
		// RVA: 0x0001BDA3 File Offset: 0x00019FA3
		internal virtual float vmethod_1()
		{
			if (this.vmethod_2() <= 0)
			{
				return 0f;
			}
			return (float)(this.ushort_2 * 50 + this.ushort_0 * 100 + this.ushort_1 * 300) / (float)(this.vmethod_2() * 300);
		}

		// Token: 0x06002326 RID: 8998
		// RVA: 0x0001BDE3 File Offset: 0x00019FE3
		internal virtual int vmethod_2()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1 + this.ushort_5);
		}

		// Token: 0x06002327 RID: 8999
		// RVA: 0x0001BE00 File Offset: 0x0001A000
		internal virtual int vmethod_3()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1);
		}

		// Token: 0x06002329 RID: 9001
		// RVA: 0x000D471C File Offset: 0x000D291C
		internal virtual Rankings vmethod_4()
		{
			float num = (float)this.ushort_1 / (float)this.vmethod_2();
			float num2 = (float)this.ushort_2 / (float)this.vmethod_2();
			if (!this.bool_2)
			{
				return Rankings.F;
			}
			if (num == 1f)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.X;
				}
				return Rankings.XH;
			}
			else if ((double)num > 0.9 && (double)num2 <= 0.01 && this.ushort_5 == 0)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.S;
				}
				return Rankings.SH;
			}
			else
			{
				if (((double)num > 0.8 && this.ushort_5 == 0) || (double)num > 0.9)
				{
					return Rankings.A;
				}
				if (((double)num > 0.7 && this.ushort_5 == 0) || (double)num > 0.8)
				{
					return Rankings.B;
				}
				if ((double)num > 0.6)
				{
					return Rankings.C;
				}
				return Rankings.D;
			}
		}

		// Token: 0x0600233C RID: 9020
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_5(Class32 class32_0)
		{
		}

		// Token: 0x0600233D RID: 9021
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_6(Class31 class31_0)
		{
		}

		// Token: 0x06002340 RID: 9024
		// RVA: 0x000D563C File Offset: 0x000D383C
		public void WriteToStream(Class31 class31_0)
		{
			this.bool_2 = true;
			class31_0.Write((byte)this.playModes_0);
			class31_0.Write(20150414);
			class31_0.Write(this.string_1);
			class31_0.Write(this.string_2);
			class31_0.Write(this.method_3());
			class31_0.Write(this.ushort_1);
			class31_0.Write(this.ushort_0);
			class31_0.Write(this.ushort_2);
			class31_0.Write(this.ushort_3);
			class31_0.Write(this.ushort_4);
			class31_0.Write(this.ushort_5);
			class31_0.Write(this.int_3);
			class31_0.Write((ushort)this.int_0);
			class31_0.Write(this.bool_4);
			class31_0.Write((int)this.class623_0);
			class31_0.Write(this.method_10());
			class31_0.Write(this.dateTime_0);
			class31_0.method_2(this.byte_0);
			class31_0.Write(this.long_0);
			this.vmethod_6(class31_0);
		}
	}
}
