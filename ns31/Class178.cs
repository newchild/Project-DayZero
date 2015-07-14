using ns15;
using ns8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ns31
{
	// Token: 0x02000231 RID: 561
	internal sealed class Class178 : IDisposable
	{
		// Token: 0x02000232 RID: 562
		internal sealed class Class179 : IComparer<string>
		{
			// Token: 0x060013E7 RID: 5095
			// RVA: 0x000122DF File Offset: 0x000104DF
			public int Compare(string x, string y)
			{
				if (object.ReferenceEquals(x, y))
				{
					return 0;
				}
				if (Class178.smethod_7(x))
				{
					return 1;
				}
				if (Class178.smethod_7(y))
				{
					return -1;
				}
				return x.CompareTo(y);
			}
		}

		// Token: 0x04000ECF RID: 3791
		[CompilerGenerated]
		private static Action<Stream9> action_0;

		// Token: 0x04000EC0 RID: 3776
		internal bool bool_0;

		// Token: 0x04000EC1 RID: 3777
		private bool bool_1;

		// Token: 0x04000EC2 RID: 3778
		private bool bool_2;

		// Token: 0x04000EC3 RID: 3779
		private bool bool_3;

		// Token: 0x04000EC4 RID: 3780
		private bool bool_4;

		// Token: 0x04000ECC RID: 3788
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04000ECD RID: 3789
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04000EB1 RID: 3761
		private static byte[] byte_0;

		// Token: 0x04000EB2 RID: 3762
		private byte[] byte_1;

		// Token: 0x04000EB3 RID: 3763
		private static readonly byte[] byte_2;

		// Token: 0x04000EB8 RID: 3768
		private byte[] byte_3;

		// Token: 0x04000EC9 RID: 3785
		[CompilerGenerated]
		private byte[] byte_4;

		// Token: 0x04000ECA RID: 3786
		[CompilerGenerated]
		private byte[] byte_5;

		// Token: 0x04000ECB RID: 3787
		[CompilerGenerated]
		private byte[] byte_6;

		// Token: 0x04000ECE RID: 3790
		[CompilerGenerated]
		private static Comparison<Struct20> comparison_0;

		// Token: 0x04000EB5 RID: 3765
		private Dictionary<string, Struct20> dictionary_0;

		// Token: 0x04000EB6 RID: 3766
		private Dictionary<string, byte[]> dictionary_1;

		// Token: 0x04000EBA RID: 3770
		private Dictionary<string, DateTime> dictionary_2;

		// Token: 0x04000EBB RID: 3771
		private Dictionary<string, DateTime> dictionary_3;

		// Token: 0x04000EBC RID: 3772
		private Dictionary<string, bool> dictionary_4;

		// Token: 0x04000EBE RID: 3774
		private Dictionary<Enum9, string> dictionary_5;

		// Token: 0x04000EC5 RID: 3781
		private int int_0;

		// Token: 0x04000EC6 RID: 3782
		private int int_1;

		// Token: 0x04000EBD RID: 3773
		private List<Stream9> list_0;

		// Token: 0x04000EB7 RID: 3767
		private long long_0;

		// Token: 0x04000EC7 RID: 3783
		private long long_1;

		// Token: 0x04000EB0 RID: 3760
		private static readonly MD5CryptoServiceProvider md5CryptoServiceProvider_0;

		// Token: 0x04000EC8 RID: 3784
		private object object_0;

		// Token: 0x04000EB9 RID: 3769
		private SortedDictionary<string, int> sortedDictionary_0;

		// Token: 0x04000EBF RID: 3775
		private Stream stream_0;

		// Token: 0x04000EB4 RID: 3764
		private string string_0;

		// Token: 0x060013B9 RID: 5049
		// RVA: 0x00064F60 File Offset: 0x00063160
		static Class178()
		{
			Class178.md5CryptoServiceProvider_0 = new MD5CryptoServiceProvider();
			Class178.byte_0 = new byte[]
			{
				216,
				98,
				163,
				48,
				2,
				109,
				118,
				89,
				244,
				247,
				37,
				194,
				235,
				70,
				174,
				52,
				13,
				106,
				97,
				84,
				242,
				62,
				186,
				48,
				25,
				66,
				72,
				85,
				242,
				22,
				15,
				92
			};
			Class178.byte_2 = new byte[64];
			new Class30(1990).method_4(Class178.byte_2);
		}

		// Token: 0x060013BB RID: 5051
		// RVA: 0x000121C4 File Offset: 0x000103C4
		public Class178(string string_1) : this(string_1, null, false, false)
		{
		}

		// Token: 0x060013BC RID: 5052
		// RVA: 0x00064FE0 File Offset: 0x000631E0
		public Class178(Stream stream_1, bool bool_7)
		{
			this.bool_1 = true;
			this.object_0 = new object();
			base..ctor();
			this.stream_0 = stream_1;
			try
			{
				this.method_9(bool_7);
			}
			catch (Exception)
			{
				this.Close();
				throw;
			}
		}

		// Token: 0x060013BD RID: 5053
		// RVA: 0x00065030 File Offset: 0x00063230
		public Class178(string string_1, byte[] byte_7, bool bool_7, bool bool_8)
		{
			this.bool_1 = true;
			this.object_0 = new object();
			base..ctor();
			this.bool_4 = !File.Exists(string_1);
			if (this.bool_4 && !bool_7)
			{
				throw new IOException("File does not exist (" + string_1 + ").");
			}
			if (byte_7 != null)
			{
				this.byte_1 = byte_7;
			}
			try
			{
				this.string_0 = string_1;
				if (!this.bool_4)
				{
					this.stream_0 = File.Open(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				this.method_9(false);
			}
			catch (Exception)
			{
				this.Close();
				throw;
			}
		}

		// Token: 0x060013DF RID: 5087
		// RVA: 0x00066EDC File Offset: 0x000650DC
		public void Close()
		{
			if (this.bool_0)
			{
				return;
			}
			if (this.list_0 != null)
			{
				List<Stream9> arg_34_0 = this.list_0;
				if (Class178.action_0 == null)
				{
					Class178.action_0 = new Action<Stream9>(Class178.smethod_10);
				}
				arg_34_0.ForEach(Class178.action_0);
			}
			if (this.byte_3 != null)
			{
				Array.Clear(this.byte_3, 0, this.byte_3.Length);
			}
			if (this.dictionary_0 != null)
			{
				this.dictionary_0.Clear();
			}
			if (this.dictionary_1 != null)
			{
				this.dictionary_1.Clear();
			}
			if (this.dictionary_2 != null)
			{
				this.dictionary_2.Clear();
			}
			if (this.dictionary_3 != null)
			{
				this.dictionary_3.Clear();
			}
			if (this.dictionary_4 != null)
			{
				this.dictionary_4.Clear();
			}
			if (this.dictionary_5 != null)
			{
				this.dictionary_5.Clear();
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0.Dispose();
			}
			this.bool_0 = true;
		}

		// Token: 0x060013E2 RID: 5090
		// RVA: 0x000122A2 File Offset: 0x000104A2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060013E3 RID: 5091
		// RVA: 0x000122B1 File Offset: 0x000104B1
		private void Dispose(bool bool_7)
		{
			this.Close();
		}

		// Token: 0x060013BA RID: 5050
		// RVA: 0x00064FB0 File Offset: 0x000631B0
		~Class178()
		{
			this.Dispose(false);
		}

		// Token: 0x060013B0 RID: 5040
		// RVA: 0x00012178 File Offset: 0x00010378
		[CompilerGenerated]
		public byte[] method_0()
		{
			return this.byte_4;
		}

		// Token: 0x060013B1 RID: 5041
		// RVA: 0x00012180 File Offset: 0x00010380
		[CompilerGenerated]
		private void method_1(byte[] byte_7)
		{
			this.byte_4 = byte_7;
		}

		// Token: 0x060013BF RID: 5055
		// RVA: 0x000653C8 File Offset: 0x000635C8
		private void method_10(BinaryReader binaryReader_0)
		{
			this.method_14(true);
			using (Stream1 stream = new Stream1(binaryReader_0.BaseStream, Enum4.const_0, this.byte_1))
			{
				byte[] buffer = new byte[64];
				stream.Read(buffer, 0, 64);
				if (!Class34.smethod_24(buffer, Class178.byte_2))
				{
					throw new Exception("Invalid key");
				}
			}
			this.int_1 = (int)binaryReader_0.BaseStream.Position;
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < 16; i += 2)
			{
				num -= ((int)this.method_2()[i] | (int)this.method_2()[i + 1] << 17);
			}
			byte[] array = binaryReader_0.ReadBytes(num);
			this.int_0 = (int)binaryReader_0.BaseStream.Position;
			for (int j = 0; j < this.byte_3.Length; j++)
			{
				byte[] expr_BD_cp_0 = this.byte_3;
				int expr_BD_cp_1 = j;
				expr_BD_cp_0[expr_BD_cp_1] ^= this.method_4()[j % 16];
			}
			using (Class49 class = new Class50())
			{
				class.IV = this.byte_3;
				class.Key = this.byte_1;
				using (MemoryStream memoryStream = new MemoryStream(array))
				{
					using (Stream stream2 = new Stream1(memoryStream, Enum4.const_1, this.byte_1))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream2))
						{
							int num2 = binaryReader.ReadInt32();
							byte[] array2 = Class178.smethod_2(array, num2 * 4, 209);
							if (!Class34.smethod_24(array2, this.method_2()))
							{
								throw new IOException("File failed integrity check.");
							}
							int num3 = binaryReader.ReadInt32();
							int k = 0;
							while (k < num2)
							{
								string text = binaryReader.ReadString();
								byte[] array3 = binaryReader.ReadBytes(16);
								DateTime dateTime_ = DateTime.FromBinary(binaryReader.ReadInt64());
								DateTime dateTime_2 = DateTime.FromBinary(binaryReader.ReadInt64());
								int num4;
								if (k + 1 < num2)
								{
									num4 = binaryReader.ReadInt32();
								}
								else
								{
									num4 = (int)binaryReader_0.BaseStream.Length - this.int_0;
								}
								int num5 = num4 - num3;
								if (!Class178.smethod_7(text))
								{
									goto IL_2FA;
								}
								long position = binaryReader_0.BaseStream.Position;
								long num6 = (long)(this.int_0 + num3 + num5 / 2 - 512 + 4);
								bool flag;
								if (num6 < binaryReader_0.BaseStream.Length && num5 >= 1024)
								{
									byte[] buffer2 = new byte[1024];
									using (Stream9 stream3 = new Stream9(this.method_15(), this.int_0 + num3, num5 - 4, this.byte_3, this.byte_1))
									{
										int num7 = (num5 - 4) / 2;
										stream3.Seek((long)(num7 - num7 % 16 - 512 + 16), SeekOrigin.Begin);
										stream3.Read(buffer2, 0, 1024);
										binaryReader_0.BaseStream.Position = position;
									}
									string text2 = BitConverter.ToString(Class178.md5CryptoServiceProvider_0.ComputeHash(buffer2)).Replace("-", "");
									flag = !text2.Equals(this.dictionary_5[Enum9.const_8]);
								}
								else
								{
									flag = true;
								}
								if (!flag)
								{
									goto IL_2FA;
								}
								this.bool_1 = false;
								this.method_8(true);
								num3 = num4;
								IL_31C:
								k++;
								continue;
								IL_2FA:
								this.dictionary_0.Add(text, new Struct20(text, num3, num5, array3, dateTime_, dateTime_2));
								num3 = num4;
								goto IL_31C;
							}
							binaryReader.Close();
						}
					}
				}
				class.Clear();
			}
			this.stream_0.Seek(0L, SeekOrigin.Begin);
		}

		// Token: 0x060013C0 RID: 5056
		// RVA: 0x000657F0 File Offset: 0x000639F0
		private void method_11(Dictionary<string, byte[]> dictionary_6, ICryptoTransform icryptoTransform_0)
		{
			string[] array = new string[dictionary_6.Keys.Count];
			dictionary_6.Keys.CopyTo(array, 0);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string key = array2[i];
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (Stream stream = new Stream1(memoryStream, Enum4.const_1, this.byte_1))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							binaryWriter.Write(dictionary_6[key].Length);
							if (!this.dictionary_4[key])
							{
								binaryWriter.Write(dictionary_6[key]);
							}
							else
							{
								memoryStream.Write(dictionary_6[key], 0, dictionary_6[key].Length);
							}
							stream.Flush();
							dictionary_6[key] = memoryStream.ToArray();
							binaryWriter.Close();
						}
					}
				}
			}
		}

		// Token: 0x060013C2 RID: 5058
		// RVA: 0x000659B0 File Offset: 0x00063BB0
		private byte[] method_12(SortedDictionary<string, byte[]> sortedDictionary_1, Dictionary<string, byte[]> dictionary_6, Dictionary<string, DateTime> dictionary_7, Dictionary<string, DateTime> dictionary_8, ICryptoTransform icryptoTransform_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (Stream1 stream = new Stream1(memoryStream, Enum4.const_1, this.byte_1))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(stream))
					{
						binaryWriter.Write(sortedDictionary_1.Count);
						int num = 0;
						foreach (KeyValuePair<string, byte[]> current in sortedDictionary_1)
						{
							binaryWriter.Write(num);
							binaryWriter.Write(current.Key);
							using (Stream1 stream2 = new Stream1(new MemoryStream(current.Value, false), Enum4.const_1, this.byte_1))
							{
								byte[] buffer = new byte[current.Value.Length];
								stream2.Read(buffer, 0, current.Value.Length);
								byte[] array = Class178.md5CryptoServiceProvider_0.ComputeHash(buffer, 4, current.Value.Length - 4);
								binaryWriter.Write(array);
								binaryWriter.Write(dictionary_7[current.Key].ToBinary());
								binaryWriter.Write(dictionary_8[current.Key].ToBinary());
								dictionary_6[current.Key] = array;
							}
							num += current.Value.Length;
						}
						stream.Flush();
						binaryWriter.Flush();
						byte[] array2 = memoryStream.ToArray();
						stream.Close();
						binaryWriter.Close();
						result = array2;
					}
				}
			}
			return result;
		}

		// Token: 0x060013C5 RID: 5061
		// RVA: 0x00065D10 File Offset: 0x00063F10
		private byte[] method_13(Stream stream_1, int int_2, byte byte_7)
		{
			long position = stream_1.Position;
			long num = stream_1.Length - position;
			string value = this.method_20(Enum9.const_6);
			byte[] array;
			if (!string.IsNullOrEmpty(value))
			{
				long num2 = Convert.ToInt64(value);
				long num3 = Convert.ToInt64(this.method_20(Enum9.const_7));
				array = new byte[num - num3];
				stream_1.Read(array, 0, (int)num2);
				long num4 = stream_1.Position + num3;
				if (num4 >= stream_1.Length)
				{
					stream_1.Position = num4;
					stream_1.Read(array, (int)(stream_1.Position - position - num3), (int)(stream_1.Length - stream_1.Position));
				}
				int_2 %= (int)(num - num3);
			}
			else
			{
				array = new byte[num];
				stream_1.Read(array, 0, array.Length);
			}
			return Class178.smethod_2(array, int_2, byte_7);
		}

		// Token: 0x060013CB RID: 5067
		// RVA: 0x0001220D File Offset: 0x0001040D
		[CompilerGenerated]
		private void method_14(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x060013CC RID: 5068
		// RVA: 0x00012216 File Offset: 0x00010416
		public string method_15()
		{
			return this.string_0;
		}

		// Token: 0x060013CD RID: 5069
		// RVA: 0x00065E7C File Offset: 0x0006407C
		public string[] method_16()
		{
			this.method_35();
			string[] array = new string[this.sortedDictionary_0.Count];
			this.sortedDictionary_0.Keys.CopyTo(array, 0);
			return array;
		}

		// Token: 0x060013CE RID: 5070
		// RVA: 0x0001221E File Offset: 0x0001041E
		public int method_17(string string_1)
		{
			if (!this.sortedDictionary_0.ContainsKey(string_1))
			{
				return -2;
			}
			return this.sortedDictionary_0[string_1];
		}

		// Token: 0x060013CF RID: 5071
		// RVA: 0x00065EB4 File Offset: 0x000640B4
		public void method_18(string string_1, int int_2)
		{
			if (!this.sortedDictionary_0.ContainsKey(string_1))
			{
				throw new Exception("Map does not exist in this mappackage");
			}
			if (this.sortedDictionary_0.ContainsValue(int_2) && int_2 != -1 && this.method_17(string_1) != int_2)
			{
				throw new Exception("An other map already has this ID set");
			}
			this.sortedDictionary_0[string_1] = int_2;
		}

		// Token: 0x060013D0 RID: 5072
		// RVA: 0x0001223D File Offset: 0x0001043D
		public bool method_19(string string_1)
		{
			return this.dictionary_0.ContainsKey(string_1) || this.dictionary_1.ContainsKey(string_1);
		}

		// Token: 0x060013B2 RID: 5042
		// RVA: 0x00012189 File Offset: 0x00010389
		[CompilerGenerated]
		public byte[] method_2()
		{
			return this.byte_5;
		}

		// Token: 0x060013D1 RID: 5073
		// RVA: 0x00065F10 File Offset: 0x00064110
		public string method_20(Enum9 enum9_0)
		{
			this.method_35();
			string result;
			this.dictionary_5.TryGetValue(enum9_0, out result);
			return result;
		}

		// Token: 0x060013D2 RID: 5074
		// RVA: 0x0001225B File Offset: 0x0001045B
		public Stream method_21(string string_1)
		{
			return this.method_22(string_1, false);
		}

		// Token: 0x060013D3 RID: 5075
		// RVA: 0x00065F34 File Offset: 0x00064134
		public Stream method_22(string string_1, bool bool_7)
		{
			this.method_35();
			Stream result = null;
			if (this.dictionary_0.ContainsKey(string_1))
			{
				if (!bool_7)
				{
					Stream9 stream = new Stream9(this.stream_0, this.int_0 + this.dictionary_0[string_1].method_3(), this.dictionary_0[string_1].Length, this.byte_3, this.byte_1);
					this.list_0.Add(stream);
					stream.method_2(new Stream9.Delegate18(this.method_23));
					result = stream;
				}
				else
				{
					byte[] array = new byte[this.dictionary_0[string_1].Length - 4];
					FileStream fileStream = File.Open(this.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
					fileStream.Seek((long)(this.int_0 + this.dictionary_0[string_1].method_3() + 4), SeekOrigin.Begin);
					fileStream.Read(array, 0, array.Length);
					result = new MemoryStream(array, false);
				}
			}
			else if (this.dictionary_1.ContainsKey(string_1))
			{
				result = new MemoryStream(this.dictionary_1[string_1], false);
			}
			return result;
		}

		// Token: 0x060013D4 RID: 5076
		// RVA: 0x00012265 File Offset: 0x00010465
		private void method_23(Stream9 stream9_0)
		{
			if (this.bool_0)
			{
				return;
			}
			if (this.list_0.Contains(stream9_0))
			{
				this.list_0.Remove(stream9_0);
			}
		}

		// Token: 0x060013D5 RID: 5077
		// RVA: 0x00066058 File Offset: 0x00064258
		public void method_24(Enum9 enum9_0, string string_1)
		{
			this.method_35();
			this.dictionary_5[enum9_0] = string_1;
			this.bool_3 = true;
			if (enum9_0 != Enum9.const_2 && enum9_0 != Enum9.const_9)
			{
				return;
			}
			string text;
			this.dictionary_5.TryGetValue(Enum9.const_2, out text);
			string text2;
			this.dictionary_5.TryGetValue(Enum9.const_9, out text2);
			if (text != null && text2 != null)
			{
				if (this.byte_1 == null || this.byte_1 == Class178.byte_0)
				{
					string s = text + "yhxyfjo5" + text2;
					this.byte_1 = Class178.smethod_3(Encoding.ASCII.GetBytes(s));
				}
				return;
			}
		}

		// Token: 0x060013D6 RID: 5078
		// RVA: 0x000660EC File Offset: 0x000642EC
		public void method_25(string string_1, bool bool_7)
		{
			this.method_35();
			string_1 = Class34.smethod_16(string_1);
			string[] array;
			if (!bool_7)
			{
				array = Directory.GetFiles(string_1);
			}
			else
			{
				List<string> list = new List<string>();
				Stack<string> stack = new Stack<string>();
				stack.Push(string_1);
				while (stack.Count > 0)
				{
					string path = stack.Pop();
					string[] files = Directory.GetFiles(path);
					for (int i = 0; i < files.Length; i++)
					{
						string item = files[i];
						list.Add(item);
					}
					string[] directories = Directory.GetDirectories(path);
					for (int j = 0; j < directories.Length; j++)
					{
						string item2 = directories[j];
						stack.Push(item2);
					}
				}
				array = list.ToArray();
			}
			string[] array2 = array;
			for (int k = 0; k < array2.Length; k++)
			{
				string text = array2[k];
				if (!Class178.smethod_6(text))
				{
					this.method_26(Class34.smethod_26(text, string_1), text, File.GetCreationTimeUtc(text), File.GetLastWriteTimeUtc(text));
				}
			}
			this.bool_2 = true;
		}

		// Token: 0x060013D7 RID: 5079
		// RVA: 0x000661E4 File Offset: 0x000643E4
		public void method_26(string string_1, string string_2, DateTime dateTime_0, DateTime dateTime_1)
		{
			this.method_35();
			if (Class178.smethod_6(string_1))
			{
				throw new IOException("Cannot add other map packages to a map package.");
			}
			byte[] array;
			using (FileStream fileStream = File.OpenRead(string_2))
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, (int)fileStream.Length);
				fileStream.Close();
			}
			this.method_27(string_1, array, dateTime_0, dateTime_1);
			this.bool_2 = true;
		}

		// Token: 0x060013D8 RID: 5080
		// RVA: 0x0001228B File Offset: 0x0001048B
		public void method_27(string string_1, byte[] byte_7, DateTime dateTime_0, DateTime dateTime_1)
		{
			this.method_28(string_1, byte_7, dateTime_0, dateTime_1, false);
		}

		// Token: 0x060013D9 RID: 5081
		// RVA: 0x00066264 File Offset: 0x00064464
		public void method_28(string string_1, byte[] byte_7, DateTime dateTime_0, DateTime dateTime_1, bool bool_7)
		{
			this.method_35();
			if (Class178.smethod_6(string_1))
			{
				throw new IOException("Cannot add other map packages to a map package.");
			}
			if (Class178.smethod_4(string_1) && !this.sortedDictionary_0.ContainsKey(string_1))
			{
				this.sortedDictionary_0.Add(string_1, -1);
			}
			if (Class178.smethod_7(string_1))
			{
				if (byte_7.Length < 1024)
				{
					throw new IOException("Video needs to be atleast 1024 bytes big");
				}
				long num = this.long_0;
				foreach (KeyValuePair<string, Struct20> current in this.dictionary_0)
				{
					num += (long)current.Value.Length;
				}
				byte[] array = new byte[1024];
				Array.Copy(byte_7, byte_7.LongLength / 2L - byte_7.LongLength / 2L % 16L - 512L + 16L, array, 0L, 1024L);
				byte[] value = Class178.md5CryptoServiceProvider_0.ComputeHash(array);
				this.method_24(Enum9.const_6, Convert.ToString(num));
				this.method_24(Enum9.const_7, Convert.ToString(byte_7.Length));
				this.method_24(Enum9.const_8, BitConverter.ToString(value).Replace("-", ""));
				this.bool_3 = true;
			}
			this.dictionary_1[string_1] = byte_7;
			this.dictionary_2[string_1] = dateTime_0;
			this.dictionary_3[string_1] = dateTime_1;
			this.dictionary_4[string_1] = bool_7;
			this.long_0 += byte_7.LongLength;
			if (this.dictionary_0.ContainsKey(string_1))
			{
				this.dictionary_0.Remove(string_1);
			}
			this.bool_2 = true;
		}

		// Token: 0x060013DA RID: 5082
		// RVA: 0x00066444 File Offset: 0x00064644
		public void method_29(string string_1)
		{
			this.method_35();
			bool flag = false;
			if (this.dictionary_0.ContainsKey(string_1))
			{
				this.dictionary_0.Remove(string_1);
				flag = true;
			}
			if (this.dictionary_1.ContainsKey(string_1))
			{
				this.dictionary_1.Remove(string_1);
				this.dictionary_2.Remove(string_1);
				this.dictionary_3.Remove(string_1);
				this.dictionary_4.Remove(string_1);
				flag = true;
			}
			if (flag)
			{
				this.bool_2 = true;
				if (this.sortedDictionary_0.ContainsKey(string_1))
				{
					this.sortedDictionary_0.Remove(string_1);
				}
			}
		}

		// Token: 0x060013B3 RID: 5043
		// RVA: 0x00012191 File Offset: 0x00010391
		[CompilerGenerated]
		private void method_3(byte[] byte_7)
		{
			this.byte_5 = byte_7;
		}

		// Token: 0x060013DC RID: 5084
		// RVA: 0x00066714 File Offset: 0x00064914
		public List<Struct20> method_30()
		{
			List<Struct20> list = new List<Struct20>();
			foreach (Struct20 current in this.dictionary_0.Values)
			{
				list.Add(current);
			}
			return list;
		}

		// Token: 0x060013DD RID: 5085
		// RVA: 0x00012299 File Offset: 0x00010499
		public bool method_31()
		{
			return this.method_32(false);
		}

		// Token: 0x060013DE RID: 5086
		// RVA: 0x00066774 File Offset: 0x00064974
		public bool method_32(bool bool_7)
		{
			this.method_35();
			if (!this.bool_1 && !bool_7)
			{
				throw new Exception("Cannot save a no-video beatmap if it's missing videodata when ignoreHeader is set to false");
			}
			if (!this.bool_2 && !this.bool_3)
			{
				return false;
			}
			if (this.list_0.Count != 0)
			{
				throw new IOException("Cannot save while streams are open.");
			}
			if (this.dictionary_0.Count + this.dictionary_1.Count == 0)
			{
				throw new IOException("Cannot save an empty package.");
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
			}
			byte[] array = null;
			if (this.bool_4)
			{
				this.bool_2 = true;
				this.bool_3 = true;
			}
			else
			{
				array = File.ReadAllBytes(this.string_0);
			}
			using (Class49 class = new Class50())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream()))
				{
					class.IV = this.byte_3;
					class.Key = this.byte_1;
					binaryWriter.Write(new byte[]
					{
						236,
						72,
						79
					});
					binaryWriter.Write(0);
					SortedDictionary<string, byte[]> sortedDictionary = new SortedDictionary<string, byte[]>(new Class178.Class179());
					Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
					Dictionary<string, DateTime> dictionary2 = new Dictionary<string, DateTime>();
					Dictionary<string, DateTime> dictionary3 = new Dictionary<string, DateTime>();
					byte[] array3;
					if (this.bool_2)
					{
						foreach (KeyValuePair<string, Struct20> current in this.dictionary_0)
						{
							byte[] array2 = new byte[current.Value.Length];
							Array.Copy(array, this.int_0 + current.Value.method_3(), array2, 0, array2.Length);
							sortedDictionary.Add(current.Key, array2);
							dictionary2[current.Key] = current.Value.method_7();
							dictionary3[current.Key] = current.Value.method_9();
						}
						this.method_11(this.dictionary_1, class.CreateEncryptor());
						foreach (KeyValuePair<string, byte[]> current2 in this.dictionary_1)
						{
							sortedDictionary.Add(current2.Key, current2.Value);
							dictionary2[current2.Key] = this.dictionary_2[current2.Key];
							dictionary3[current2.Key] = this.dictionary_3[current2.Key];
						}
						array3 = Class178.smethod_0(sortedDictionary);
					}
					else
					{
						array3 = new byte[array.Length - this.int_0];
						Array.Copy(array, this.int_0, array3, 0, array3.Length);
					}
					byte[] array4 = new byte[this.byte_3.Length];
					for (int i = 0; i < array4.Length; i++)
					{
						array4[i] = (this.byte_3[i] ^ array3[i]);
					}
					binaryWriter.Write(array4);
					byte[] array5;
					if (!this.bool_3 && !this.bool_2)
					{
						array5 = new byte[this.int_1 - 68];
						Array.Copy(array, 68, array5, 0, array5.Length);
						binaryWriter.Write(array5);
					}
					else
					{
						array5 = Class178.smethod_1(this.dictionary_5);
						binaryWriter.Write(array5);
						binaryWriter.Write(this.sortedDictionary_0.Count);
						foreach (KeyValuePair<string, int> current3 in this.sortedDictionary_0)
						{
							binaryWriter.Write(current3.Key);
							binaryWriter.Write(current3.Value);
						}
						using (Stream1 stream = new Stream1(binaryWriter.BaseStream, Enum4.const_0, this.byte_1))
						{
							stream.Write(Class178.byte_2, 0, 64);
						}
					}
					int num = (int)binaryWriter.BaseStream.Position;
					if (this.bool_2)
					{
						byte[] array6 = this.method_12(sortedDictionary, dictionary, dictionary2, dictionary3, class.CreateEncryptor());
						this.method_3(Class178.smethod_2(array6, sortedDictionary.Count * 4, 209));
						int num2 = array6.Length;
						for (int j = 0; j < 16; j += 2)
						{
							num2 += ((int)this.method_2()[j] | (int)this.method_2()[j + 1] << 17);
						}
						binaryWriter.Write(num2);
						binaryWriter.Write(array6);
					}
					else
					{
						byte[] array6 = new byte[this.int_0 - this.int_1];
						Array.Copy(array, this.int_1, array6, 0, array6.Length);
						binaryWriter.Write(array6);
					}
					int num3 = (int)binaryWriter.BaseStream.Position;
					binaryWriter.Write(array3);
					if (!bool_7)
					{
						this.method_1(Class178.smethod_2(array5, this.dictionary_5.Count * 3, 167));
						this.method_5(this.method_13(new MemoryStream(array3, false), array3.Length / 2, 159));
					}
					using (FileStream fileStream = File.Open(this.string_0, FileMode.Create, FileAccess.Write, FileShare.None))
					{
						byte[] buffer = new byte[524288];
						binaryWriter.Seek(0, SeekOrigin.Begin);
						Stream baseStream = binaryWriter.BaseStream;
						baseStream.Read(buffer, 0, 20);
						fileStream.Write(buffer, 0, 20);
						fileStream.Write(this.method_0(), 0, 16);
						fileStream.Write(this.method_2(), 0, 16);
						fileStream.Write(this.method_4(), 0, 16);
						int count;
						while ((count = baseStream.Read(buffer, 0, 524288)) > 0)
						{
							fileStream.Write(buffer, 0, count);
						}
					}
					binaryWriter.Close();
					class.Clear();
					if (this.bool_2)
					{
						this.dictionary_0.Clear();
						int num4 = 0;
						foreach (KeyValuePair<string, byte[]> current4 in sortedDictionary)
						{
							this.dictionary_0.Add(current4.Key, new Struct20(current4.Key, num4, current4.Value.Length, dictionary[current4.Key], dictionary2[current4.Key], dictionary3[current4.Key]));
							num4 += current4.Value.Length;
						}
					}
					this.int_1 = num;
					this.int_0 = num3;
					this.bool_4 = false;
					this.bool_3 = false;
					this.bool_2 = false;
					this.dictionary_2.Clear();
					this.dictionary_3.Clear();
					this.dictionary_1.Clear();
				}
			}
			this.stream_0 = File.Open(this.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			return true;
		}

		// Token: 0x060013E0 RID: 5088
		// RVA: 0x00066FD8 File Offset: 0x000651D8
		public bool method_33(int int_2, bool bool_7)
		{
			try
			{
				lock (this.object_0)
				{
					if (!Monitor.TryEnter(this.object_0, int_2))
					{
						bool result = false;
						return result;
					}
				}
			}
			catch
			{
				bool result = false;
				return result;
			}
			if (bool_7 && this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0 = null;
			}
			return true;
		}

		// Token: 0x060013E1 RID: 5089
		// RVA: 0x00067050 File Offset: 0x00065250
		public void method_34()
		{
			if (this.stream_0 == null)
			{
				this.stream_0 = File.Open(this.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			lock (this.object_0)
			{
				Monitor.Exit(this.object_0);
			}
		}

		// Token: 0x060013E4 RID: 5092
		// RVA: 0x000122B9 File Offset: 0x000104B9
		private void method_35()
		{
			if (this.bool_0)
			{
				throw new Exception("Object is closed.");
			}
		}

		// Token: 0x060013B4 RID: 5044
		// RVA: 0x0001219A File Offset: 0x0001039A
		[CompilerGenerated]
		public byte[] method_4()
		{
			return this.byte_6;
		}

		// Token: 0x060013B5 RID: 5045
		// RVA: 0x000121A2 File Offset: 0x000103A2
		[CompilerGenerated]
		private void method_5(byte[] byte_7)
		{
			this.byte_6 = byte_7;
		}

		// Token: 0x060013B6 RID: 5046
		// RVA: 0x000121AB File Offset: 0x000103AB
		public int method_6()
		{
			return this.int_0;
		}

		// Token: 0x060013B7 RID: 5047
		// RVA: 0x000121B3 File Offset: 0x000103B3
		[CompilerGenerated]
		public bool method_7()
		{
			return this.bool_5;
		}

		// Token: 0x060013B8 RID: 5048
		// RVA: 0x000121BB File Offset: 0x000103BB
		[CompilerGenerated]
		private void method_8(bool bool_7)
		{
			this.bool_5 = bool_7;
		}

		// Token: 0x060013BE RID: 5054
		// RVA: 0x000650D0 File Offset: 0x000632D0
		private void method_9(bool bool_7)
		{
			this.dictionary_5 = new Dictionary<Enum9, string>();
			this.dictionary_0 = new Dictionary<string, Struct20>(StringComparer.CurrentCultureIgnoreCase);
			this.sortedDictionary_0 = new SortedDictionary<string, int>();
			this.dictionary_2 = new Dictionary<string, DateTime>();
			this.dictionary_3 = new Dictionary<string, DateTime>();
			this.dictionary_4 = new Dictionary<string, bool>();
			this.list_0 = new List<Stream9>();
			this.dictionary_1 = new Dictionary<string, byte[]>(StringComparer.CurrentCultureIgnoreCase);
			this.bool_3 = false;
			this.bool_2 = false;
			this.bool_0 = false;
			if (this.bool_4)
			{
				this.int_0 = 0;
				this.int_1 = 0;
				using (Class49 class = new Class50())
				{
					class.GenerateIV();
					this.byte_3 = new byte[class.IV.Length];
					Array.Copy(class.IV, this.byte_3, this.byte_3.Length);
					class.Clear();
				}
				return;
			}
			BinaryReader binaryReader = new BinaryReader(this.stream_0);
			byte[] array = binaryReader.ReadBytes(3);
			if (array.Length >= 3 && array[0] == 236 && array[1] == 72)
			{
				if (array[2] == 79)
				{
					binaryReader.ReadByte();
					this.byte_3 = binaryReader.ReadBytes(16);
					this.method_1(binaryReader.ReadBytes(16));
					this.method_3(binaryReader.ReadBytes(16));
					this.method_5(binaryReader.ReadBytes(16));
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
						{
							int num = binaryReader.ReadInt32();
							binaryWriter.Write(num);
							for (int i = 0; i < num; i++)
							{
								short num2 = binaryReader.ReadInt16();
								string value = binaryReader.ReadString();
								if (Enum.IsDefined(typeof(Enum9), (int)num2))
								{
									this.dictionary_5.Add((Enum9)num2, value);
								}
								binaryWriter.Write(num2);
								binaryWriter.Write(value);
							}
							binaryWriter.Flush();
							byte[] array2 = Class178.smethod_2(memoryStream.ToArray(), num * 3, 167);
							if (!Class34.smethod_24(array2, this.method_0()))
							{
								throw new IOException("File failed integrity check.");
							}
							binaryWriter.Close();
						}
					}
					int num3 = binaryReader.ReadInt32();
					for (int j = 0; j < num3; j++)
					{
						this.sortedDictionary_0.Add(binaryReader.ReadString(), binaryReader.ReadInt32());
					}
					if (this.byte_1 == null)
					{
						string s = this.dictionary_5[Enum9.const_2] + "yhxyfjo5" + this.dictionary_5[Enum9.const_9];
						this.byte_1 = Class178.smethod_3(Encoding.ASCII.GetBytes(s));
					}
					if (bool_7)
					{
						this.long_1 = binaryReader.BaseStream.Position;
						return;
					}
					this.method_10(binaryReader);
					return;
				}
			}
			throw new IOException("Invalid file.");
		}

		// Token: 0x060013C1 RID: 5057
		// RVA: 0x00065908 File Offset: 0x00063B08
		private static byte[] smethod_0(SortedDictionary<string, byte[]> sortedDictionary_1)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					foreach (byte[] current in sortedDictionary_1.Values)
					{
						binaryWriter.Write(current);
					}
					binaryWriter.Flush();
					byte[] array = memoryStream.ToArray();
					binaryWriter.Close();
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060013C3 RID: 5059
		// RVA: 0x00065BB4 File Offset: 0x00063DB4
		private static byte[] smethod_1(Dictionary<Enum9, string> dictionary_6)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(dictionary_6.Count);
					foreach (KeyValuePair<Enum9, string> current in dictionary_6)
					{
						binaryWriter.Write((ushort)current.Key);
						binaryWriter.Write(current.Value ?? string.Empty);
					}
					binaryWriter.Close();
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060013E6 RID: 5094
		// RVA: 0x00010503 File Offset: 0x0000E703
		[CompilerGenerated]
		private static void smethod_10(Stream9 stream9_0)
		{
			stream9_0.Close();
		}

		// Token: 0x060013C4 RID: 5060
		// RVA: 0x00065C78 File Offset: 0x00063E78
		private static byte[] smethod_2(byte[] byte_7, int int_2, byte byte_8)
		{
			byte[] result;
			try
			{
				byte_7[int_2] ^= byte_8;
				byte[] array = Class178.md5CryptoServiceProvider_0.ComputeHash(byte_7);
				byte_7[int_2] ^= byte_8;
				for (int i = 0; i < 8; i++)
				{
					byte b = array[i];
					array[i] = array[i + 8];
					array[i + 8] = b;
				}
				byte[] expr_5B_cp_0 = array;
				int expr_5B_cp_1 = 5;
				expr_5B_cp_0[expr_5B_cp_1] ^= 45;
				result = array;
			}
			catch (Exception)
			{
				throw new IOException("File failed integrity check.");
			}
			return result;
		}

		// Token: 0x060013C6 RID: 5062
		// RVA: 0x000121D0 File Offset: 0x000103D0
		public static byte[] smethod_3(byte[] byte_7)
		{
			return Class178.md5CryptoServiceProvider_0.ComputeHash(byte_7);
		}

		// Token: 0x060013C7 RID: 5063
		// RVA: 0x00065DD4 File Offset: 0x00063FD4
		public static bool smethod_4(string string_1)
		{
			string a = Path.GetExtension(string_1).ToLower();
			return a == ".osu" || a == ".osc";
		}

		// Token: 0x060013C8 RID: 5064
		// RVA: 0x00065E08 File Offset: 0x00064008
		public static bool smethod_5(string string_1)
		{
			string a = Path.GetExtension(string_1).ToLower();
			return a == ".mp3" || a == ".ogg";
		}

		// Token: 0x060013C9 RID: 5065
		// RVA: 0x000121DD File Offset: 0x000103DD
		public static bool smethod_6(string string_1)
		{
			return Path.GetExtension(string_1).ToLower() == ".osz2" || Path.GetExtension(string_1).ToLower() == "osz";
		}

		// Token: 0x060013CA RID: 5066
		// RVA: 0x00065E3C File Offset: 0x0006403C
		public static bool smethod_7(string string_1)
		{
			string a = Path.GetExtension(string_1).ToLower();
			return a == ".avi" || a == ".flv" || a == ".mpg";
		}

		// Token: 0x060013DB RID: 5083
		// RVA: 0x000664E0 File Offset: 0x000646E0
		public static void smethod_8(string string_1, List<Struct20> list_1, int int_2, long long_2)
		{
			if (Class178.comparison_0 == null)
			{
				Class178.comparison_0 = new Comparison<Struct20>(Class178.smethod_9);
			}
			list_1.Sort(Class178.comparison_0);
			using (BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream()))
			{
				binaryWriter.Write(new byte[int_2]);
				using (Class178 class = new Class178(string_1))
				{
					using (FileStream fileStream = File.OpenRead(string_1))
					{
						int num = class.method_6();
						foreach (Struct20 current in list_1)
						{
							if (class.dictionary_0.ContainsKey(current.method_0()))
							{
								Struct20 struct = class.dictionary_0[current.method_0()];
								long num2 = (long)current.method_3() - binaryWriter.BaseStream.Position;
								if (num2 > 0L)
								{
									binaryWriter.Write(new byte[num2]);
								}
								byte[] array = new byte[current.Length];
								binaryWriter.Seek(current.method_3() + int_2, SeekOrigin.Begin);
								fileStream.Seek((long)(struct.method_3() + num), SeekOrigin.Begin);
								fileStream.Read(array, 0, array.Length);
								binaryWriter.Write(array);
							}
						}
					}
				}
				binaryWriter.Seek(0, SeekOrigin.Begin);
				using (FileStream fileStream2 = File.Open(string_1, FileMode.Create))
				{
					byte[] buffer = new byte[524288];
					Stream baseStream = binaryWriter.BaseStream;
					int count;
					while ((count = baseStream.Read(buffer, 0, 524288)) > 0)
					{
						fileStream2.Write(buffer, 0, count);
					}
					long arg_18D_0 = fileStream2.Position;
				}
			}
		}

		// Token: 0x060013E5 RID: 5093
		// RVA: 0x000122CE File Offset: 0x000104CE
		[CompilerGenerated]
		private static int smethod_9(Struct20 struct20_0, Struct20 struct20_1)
		{
			return struct20_0.method_3() - struct20_1.method_3();
		}
	}
}
