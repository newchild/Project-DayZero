using ns37;
using ns38;
using ns39;
using System;
using System.Collections;
using System.Globalization;
using System.IO;

namespace ns35
{
	// Token: 0x0200026B RID: 619
	internal sealed class Class208 : IDisposable, IEnumerable
	{
		// Token: 0x0200026E RID: 622
		private sealed class Class209 : IComparer
		{
			// Token: 0x06001592 RID: 5522
			// RVA: 0x0006E680 File Offset: 0x0006C880
			public int Compare(object x, object y)
			{
				Class208.Class210 class = x as Class208.Class210;
				Class208.Class210 class2 = y as Class208.Class210;
				int num;
				if (class == null)
				{
					if (class2 == null)
					{
						num = 0;
					}
					else
					{
						num = -1;
					}
				}
				else if (class2 == null)
				{
					num = 1;
				}
				else
				{
					int num2 = (class.method_0() == Class208.Enum29.const_0 || class.method_0() == Class208.Enum29.const_1) ? 0 : 1;
					int num3 = (class2.method_0() == Class208.Enum29.const_0 || class2.method_0() == Class208.Enum29.const_1) ? 0 : 1;
					num = num2 - num3;
					if (num == 0)
					{
						long num4 = class.Entry.method_8() - class2.Entry.method_8();
						if (num4 < 0L)
						{
							num = -1;
						}
						else if (num4 == 0L)
						{
							num = 0;
						}
						else
						{
							num = 1;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x0200026F RID: 623
		private sealed class Class210
		{
			// Token: 0x04001002 RID: 4098
			private Class205 class205_0;

			// Token: 0x04001003 RID: 4099
			private Class208.Enum29 enum29_0;

			// Token: 0x170002E6 RID: 742
			public Class205 Entry
			{
				// Token: 0x06001593 RID: 5523
				// RVA: 0x000133A3 File Offset: 0x000115A3
				get
				{
					return this.class205_0;
				}
			}

			// Token: 0x06001594 RID: 5524
			// RVA: 0x000133AB File Offset: 0x000115AB
			public Class208.Enum29 method_0()
			{
				return this.enum29_0;
			}
		}

		// Token: 0x02000270 RID: 624
		private sealed class Class211 : IEnumerator
		{
			// Token: 0x04001004 RID: 4100
			private Class205[] class205_0;

			// Token: 0x04001005 RID: 4101
			private int int_0 = -1;

			// Token: 0x170002E7 RID: 743
			public object Current
			{
				// Token: 0x06001596 RID: 5526
				// RVA: 0x000133C9 File Offset: 0x000115C9
				get
				{
					return this.class205_0[this.int_0];
				}
			}

			// Token: 0x06001595 RID: 5525
			// RVA: 0x000133B3 File Offset: 0x000115B3
			public Class211(Class205[] class205_1)
			{
				this.class205_0 = class205_1;
			}

			// Token: 0x06001598 RID: 5528
			// RVA: 0x0006E724 File Offset: 0x0006C924
			public bool MoveNext()
			{
				return ++this.int_0 < this.class205_0.Length;
			}

			// Token: 0x06001597 RID: 5527
			// RVA: 0x000133D8 File Offset: 0x000115D8
			public void Reset()
			{
				this.int_0 = -1;
			}
		}

		// Token: 0x0200026C RID: 620
		[Flags]
		private enum Enum28
		{
			// Token: 0x04000FFC RID: 4092
			flag_0 = 1,
			// Token: 0x04000FFD RID: 4093
			flag_1 = 2
		}

		// Token: 0x0200026D RID: 621
		private enum Enum29
		{
			// Token: 0x04000FFF RID: 4095
			const_0,
			// Token: 0x04001000 RID: 4096
			const_1,
			// Token: 0x04001001 RID: 4097
			const_2
		}

		// Token: 0x02000271 RID: 625
		private sealed class Stream14 : Stream13
		{
			// Token: 0x04001007 RID: 4103
			private long long_0;

			// Token: 0x04001008 RID: 4104
			private long long_1;

			// Token: 0x04001006 RID: 4102
			private Stream stream_1;

			// Token: 0x06001599 RID: 5529
			// RVA: 0x000133E1 File Offset: 0x000115E1
			public Stream14(Stream stream_2, long long_2, long long_3) : base(stream_2)
			{
				this.stream_1 = stream_2;
				this.long_0 = long_2;
				this.long_1 = long_2 + long_3;
			}

			// Token: 0x0600159B RID: 5531
			// RVA: 0x0000653E File Offset: 0x0000473E
			public override void Close()
			{
			}

			// Token: 0x0600159C RID: 5532
			// RVA: 0x0006E7C4 File Offset: 0x0006C9C4
			public override int Read(byte[] array, int offset, int count)
			{
				if ((long)count > this.long_1 - this.long_0)
				{
					count = (int)(this.long_1 - this.long_0);
					if (count == 0)
					{
						return 0;
					}
				}
				int result;
				lock (this.stream_1)
				{
					this.stream_1.Seek(this.long_0, SeekOrigin.Begin);
					int num = this.stream_1.Read(array, offset, count);
					if (num > 0)
					{
						this.long_0 += (long)num;
					}
					result = num;
				}
				return result;
			}

			// Token: 0x0600159A RID: 5530
			// RVA: 0x0006E74C File Offset: 0x0006C94C
			public override int ReadByte()
			{
				if (this.long_0 == this.long_1)
				{
					return -1;
				}
				int result;
				lock (this.stream_1)
				{
					Stream arg_3D_0 = this.stream_1;
					long offset;
					this.long_0 = (offset = this.long_0) + 1L;
					arg_3D_0.Seek(offset, SeekOrigin.Begin);
					result = this.stream_1.ReadByte();
				}
				return result;
			}
		}

		// Token: 0x04000FF0 RID: 4080
		private bool bool_0;

		// Token: 0x04000FF4 RID: 4084
		private bool bool_1;

		// Token: 0x04000FF6 RID: 4086
		private Class205[] class205_0;

		// Token: 0x04000FF7 RID: 4087
		private Enum24 enum24_0 = Enum24.const_2;

		// Token: 0x04000FF9 RID: 4089
		private Interface13 interface13_0 = new Class206();

		// Token: 0x04000FF8 RID: 4088
		private int int_0 = 4096;

		// Token: 0x04000FF5 RID: 4085
		private long long_0;

		// Token: 0x04000FF3 RID: 4083
		private Stream stream_0;

		// Token: 0x04000FF1 RID: 4081
		private string string_0;

		// Token: 0x04000FF2 RID: 4082
		private string string_1;

		// Token: 0x04000FFA RID: 4090
		private string string_2 = string.Empty;

		// Token: 0x170002E5 RID: 741
		public Class205 this[int int_1]
		{
			// Token: 0x06001583 RID: 5507
			// RVA: 0x0001332E File Offset: 0x0001152E
			get
			{
				return (Class205)this.class205_0[int_1].Clone();
			}
		}

		// Token: 0x0600157F RID: 5503
		// RVA: 0x0006DAA4 File Offset: 0x0006BCA4
		public Class208(string string_3)
		{
			this.string_0 = string_3;
			this.stream_0 = File.OpenRead(string_3);
			this.bool_1 = true;
			try
			{
				this.method_10();
			}
			catch
			{
				this.method_5(true);
				throw;
			}
		}

		// Token: 0x06001581 RID: 5505
		// RVA: 0x00013317 File Offset: 0x00011517
		public void Close()
		{
			this.method_5(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600158B RID: 5515
		// RVA: 0x0001336A File Offset: 0x0001156A
		protected virtual void Dispose(bool bool_2)
		{
			this.method_5(bool_2);
		}

		// Token: 0x06001580 RID: 5504
		// RVA: 0x0006DB1C File Offset: 0x0006BD1C
		~Class208()
		{
			this.Dispose(false);
		}

		// Token: 0x06001584 RID: 5508
		// RVA: 0x00013342 File Offset: 0x00011542
		public IEnumerator GetEnumerator()
		{
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("ZipFile has closed");
			}
			return new Class208.Class211(this.class205_0);
		}

		// Token: 0x06001582 RID: 5506
		// RVA: 0x00013326 File Offset: 0x00011526
		public bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x06001585 RID: 5509
		// RVA: 0x0006DB4C File Offset: 0x0006BD4C
		public int method_1(string string_3, bool bool_2)
		{
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("ZipFile has been closed");
			}
			for (int i = 0; i < this.class205_0.Length; i++)
			{
				if (string.Compare(string_3, this.class205_0[i].Name, bool_2, CultureInfo.InvariantCulture) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001590 RID: 5520
		// RVA: 0x0006E258 File Offset: 0x0006C458
		private void method_10()
		{
			if (!this.stream_0.CanSeek)
			{
				throw new Exception8("ZipFile stream must be seekable");
			}
			long num = this.method_9(101010256, this.stream_0.Length, 22, 65535);
			if (num < 0L)
			{
				throw new Exception8("Cannot find central directory");
			}
			ushort num2 = this.method_6();
			ushort num3 = this.method_6();
			ulong num4 = (ulong)this.method_6();
			ulong num5 = (ulong)this.method_6();
			ulong num6 = (ulong)this.method_7();
			long num7 = (long)((ulong)this.method_7());
			uint num8 = (uint)this.method_6();
			if (num8 > 0u)
			{
				byte[] byte_ = new byte[num8];
				Class188.smethod_0(this.stream_0, byte_);
				this.string_1 = Class204.smethod_3(byte_);
			}
			else
			{
				this.string_1 = string.Empty;
			}
			bool flag = false;
			if (num2 == 65535 || num3 == 65535 || num4 == 65535uL || num5 == 65535uL || num6 == 4294967295uL || num7 == 4294967295L)
			{
				flag = true;
				long num9 = this.method_9(117853008, num, 0, 4096);
				if (num9 < 0L)
				{
					throw new Exception8("Cannot find Zip64 locator");
				}
				this.method_7();
				ulong num10 = this.method_8();
				this.method_7();
				this.stream_0.Position = (long)num10;
				long num11 = (long)((ulong)this.method_7());
				if (num11 != 101075792L)
				{
					throw new Exception8(string.Format("Invalid Zip64 Central directory signature at {0:X}", num10));
				}
				this.method_8();
				this.method_6();
				this.method_6();
				this.method_7();
				this.method_7();
				num4 = this.method_8();
				num5 = this.method_8();
				num6 = this.method_8();
				num7 = (long)this.method_8();
			}
			this.class205_0 = new Class205[num4];
			if (!flag && num7 < num - (long)(4uL + num6))
			{
				this.long_0 = num - (long)(4uL + num6 + (ulong)num7);
				if (this.long_0 <= 0L)
				{
					throw new Exception8("Invalid embedded zip archive");
				}
			}
			this.stream_0.Seek(this.long_0 + num7, SeekOrigin.Begin);
			for (ulong num12 = 0uL; num12 < num4; num12 += 1uL)
			{
				if (this.method_7() != 33639248u)
				{
					throw new Exception8("Wrong Central Directory signature");
				}
				int int_ = (int)this.method_6();
				int int_2 = (int)this.method_6();
				int num13 = (int)this.method_6();
				int enum25_ = (int)this.method_6();
				uint num14 = this.method_7();
				uint num15 = this.method_7();
				long num16 = (long)((ulong)this.method_7());
				long num17 = (long)((ulong)this.method_7());
				int num18 = (int)this.method_6();
				int num19 = (int)this.method_6();
				int num20 = (int)this.method_6();
				this.method_6();
				this.method_6();
				uint int_3 = this.method_7();
				long long_ = (long)((ulong)this.method_7());
				byte[] byte_2 = new byte[Math.Max(num18, num20)];
				Class188.smethod_1(this.stream_0, byte_2, 0, num18);
				string text = Class204.smethod_4(num13, byte_2, num18);
				Class205 class = new Class205(text, int_2, int_, (Enum25)enum25_);
				class.method_28((long)((ulong)num15 & 4294967295uL));
				class.method_24(num17 & 4294967295L);
				class.method_26(num16 & 4294967295L);
				class.method_5(num13);
				class.method_20((long)((ulong)num14));
				class.method_7((long)num12);
				class.method_9(long_);
				class.method_11((int)int_3);
				if ((num13 & 8) == 0)
				{
					class.method_3((byte)(num15 >> 24));
				}
				else
				{
					class.method_3((byte)(num14 >> 8 & 255u));
				}
				if (num19 > 0)
				{
					byte[] array = new byte[num19];
					Class188.smethod_0(this.stream_0, array);
					class.method_32(array);
				}
				class.method_33(false);
				if (num20 > 0)
				{
					Class188.smethod_1(this.stream_0, byte_2, 0, num20);
					class.method_35(Class204.smethod_4(num13, byte_2, num20));
				}
				this.class205_0[(int)(checked((IntPtr)num12))] = class;
			}
		}

		// Token: 0x06001591 RID: 5521
		// RVA: 0x00013399 File Offset: 0x00011599
		private long method_11(Class205 class205_1)
		{
			return this.method_4(class205_1, Class208.Enum28.flag_0);
		}

		// Token: 0x06001586 RID: 5510
		// RVA: 0x0006DBA0 File Offset: 0x0006BDA0
		public Stream method_2(Class205 class205_1)
		{
			if (class205_1 == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("ZipFile has closed");
			}
			long num = class205_1.method_6();
			if (num < 0L || num >= (long)this.class205_0.Length || this.class205_0[(int)(checked((IntPtr)num))].Name != class205_1.Name)
			{
				num = (long)this.method_1(class205_1.Name, true);
				if (num < 0L)
				{
					throw new Exception8("Entry cannot be found");
				}
			}
			return this.method_3(num);
		}

		// Token: 0x06001587 RID: 5511
		// RVA: 0x0006DC38 File Offset: 0x0006BE38
		public Stream method_3(long long_1)
		{
			if (this.class205_0 == null)
			{
				throw new InvalidOperationException("ZipFile is not open");
			}
			checked
			{
				long long_2 = this.method_11(this.class205_0[(int)((IntPtr)long_1)]);
				Enum25 enum = this.class205_0[(int)((IntPtr)long_1)].method_29();
				Stream stream = new Class208.Stream14(this.stream_0, long_2, this.class205_0[(int)((IntPtr)long_1)].method_25());
				Enum25 enum2 = enum;
				if (enum2 != Enum25.const_0)
				{
					if (enum2 != Enum25.const_1)
					{
						throw new Exception8("Unsupported compression method " + enum);
					}
					stream = new Stream13(stream, new Class196(true));
				}
				return stream;
			}
		}

		// Token: 0x06001588 RID: 5512
		// RVA: 0x0006DCC4 File Offset: 0x0006BEC4
		private long method_4(Class205 class205_1, Class208.Enum28 enum28_0)
		{
			long result;
			lock (this.stream_0)
			{
				bool flag = (enum28_0 & Class208.Enum28.flag_1) != (Class208.Enum28)0;
				bool flag2 = (enum28_0 & Class208.Enum28.flag_0) != (Class208.Enum28)0;
				this.stream_0.Seek(this.long_0 + class205_1.method_8(), SeekOrigin.Begin);
				if (this.method_7() != 67324752u)
				{
					throw new Exception8(string.Format("Wrong local header signature @{0:X}", this.long_0 + class205_1.method_8()));
				}
				short num = (short)this.method_6();
				short num2 = (short)this.method_6();
				short num3 = (short)this.method_6();
				short num4 = (short)this.method_6();
				short num5 = (short)this.method_6();
				uint num6 = this.method_7();
				long num7 = (long)((ulong)this.method_7());
				long num8 = (long)((ulong)this.method_7());
				int num9 = (int)this.method_6();
				int num10 = (int)this.method_6();
				byte[] byte_ = new byte[num9];
				Class188.smethod_0(this.stream_0, byte_);
				byte[] array = new byte[num10];
				Class188.smethod_0(this.stream_0, array);
				Class207 class = new Class207(array);
				if (class.Find(1))
				{
					if (num < 45)
					{
						throw new Exception8(string.Format("Extra data contains Zip64 information but version {0}.{1} is not high enough", (int)(num / 10), (int)(num % 10)));
					}
					if ((uint)num8 != 4294967295u && (uint)num7 != 4294967295u)
					{
						throw new Exception8("Entry sizes not correct for Zip64");
					}
					num8 = class.method_10();
					num7 = class.method_10();
				}
				else if (num >= 45 && ((uint)num8 == 4294967295u || (uint)num7 == 4294967295u))
				{
					throw new Exception8("Required Zip64 extended information missing");
				}
				if (flag2 && class205_1.method_37())
				{
					if (!class205_1.method_38())
					{
						throw new Exception8("Compression method not supported");
					}
					if (num > 45 || (num > 20 && num < 45))
					{
						throw new Exception8(string.Format("Version required to extract this entry not supported ({0})", num));
					}
					if ((num2 & 12384) != 0)
					{
						throw new Exception8("The library does not support the zip version required to extract this entry");
					}
				}
				if (flag)
				{
					if (num <= 63 && num != 10 && num != 11 && num != 20 && num != 21 && num != 25 && num != 27 && num != 45 && num != 46 && num != 50 && num != 51 && num != 52 && num != 61 && num != 62 && num != 63)
					{
						throw new Exception8(string.Format("Version required to extract this entry is invalid ({0})", num));
					}
					if (((int)num2 & 49168) != 0)
					{
						throw new Exception8("Reserved bit flags cannot be set.");
					}
					if ((num2 & 1) != 0 && num < 20)
					{
						throw new Exception8(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
					}
					if ((num2 & 64) != 0)
					{
						if ((num2 & 1) == 0)
						{
							throw new Exception8("Strong encryption flag set but encryption flag is not set");
						}
						if (num < 50)
						{
							throw new Exception8(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
						}
					}
					if ((num2 & 32) != 0 && num < 27)
					{
						throw new Exception8(string.Format("Patched data requires higher version than ({0})", num));
					}
					if ((int)num2 != class205_1.method_4())
					{
						throw new Exception8("Central header/local header flags mismatch");
					}
					if (class205_1.method_29() != (Enum25)num3)
					{
						throw new Exception8("Central header/local header compression method mismatch");
					}
					if ((num2 & 64) != 0 && num < 62)
					{
						throw new Exception8("Strong encryption flag set but version not high enough");
					}
					if ((num2 & 8192) != 0 && (num4 != 0 || num5 != 0))
					{
						throw new Exception8("Header masked set but date/time values non-zero");
					}
					if ((num2 & 8) == 0 && num6 != (uint)class205_1.method_27())
					{
						throw new Exception8("Central header/local header crc mismatch");
					}
					if (num8 == 0L && num7 == 0L && num6 != 0u)
					{
						throw new Exception8("Invalid CRC for empty entry");
					}
					if (class205_1.Name.Length > num9)
					{
						throw new Exception8("File name length mismatch");
					}
					string a = Class204.smethod_5((int)num2, byte_);
					if (a != class205_1.Name)
					{
						throw new Exception8("Central header and local header file name mismatch");
					}
					if (class205_1.method_36() && (num7 != 0L || num8 != 0L))
					{
						throw new Exception8("Directory cannot have size");
					}
					if (!Class212.smethod_1(a, true))
					{
						throw new Exception8("Name is invalid");
					}
				}
				if ((num2 & 8) == 0 || num8 != 0L || num7 != 0L)
				{
					if (num8 != class205_1.method_23())
					{
						throw new Exception8(string.Format("Size mismatch between central header({0}) and local header({1})", class205_1.method_23(), num8));
					}
					if (num7 != class205_1.method_25())
					{
						throw new Exception8(string.Format("Compressed size mismatch between central header({0}) and local header({1})", class205_1.method_25(), num7));
					}
				}
				int num11 = num9 + num10;
				result = this.long_0 + class205_1.method_8() + 30L + (long)num11;
			}
			return result;
		}

		// Token: 0x0600158A RID: 5514
		// RVA: 0x0006E164 File Offset: 0x0006C364
		private void method_5(bool bool_2)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				this.class205_0 = null;
				if (this.method_0() && this.stream_0 != null)
				{
					lock (this.stream_0)
					{
						this.stream_0.Close();
					}
				}
			}
		}

		// Token: 0x0600158C RID: 5516
		// RVA: 0x0006E1C8 File Offset: 0x0006C3C8
		private ushort method_6()
		{
			int num = this.stream_0.ReadByte();
			if (num < 0)
			{
				throw new EndOfStreamException("End of stream");
			}
			int num2 = this.stream_0.ReadByte();
			if (num2 < 0)
			{
				throw new EndOfStreamException("End of stream");
			}
			return (ushort)num | (ushort)(num2 << 8);
		}

		// Token: 0x0600158D RID: 5517
		// RVA: 0x00013373 File Offset: 0x00011573
		private uint method_7()
		{
			return (uint)((int)this.method_6() | (int)this.method_6() << 16);
		}

		// Token: 0x0600158E RID: 5518
		// RVA: 0x00013385 File Offset: 0x00011585
		private ulong method_8()
		{
			return (ulong)this.method_7() | (ulong)this.method_7() << 32;
		}

		// Token: 0x0600158F RID: 5519
		// RVA: 0x0006E214 File Offset: 0x0006C414
		private long method_9(int int_1, long long_1, int int_2, int int_3)
		{
			long result;
			using (Stream15 stream = new Stream15(this.stream_0))
			{
				result = stream.method_0(int_1, long_1, int_2, int_3);
			}
			return result;
		}

		// Token: 0x06001589 RID: 5513
		// RVA: 0x00013362 File Offset: 0x00011562
		void IDisposable.Dispose()
		{
			this.Close();
		}
	}
}
