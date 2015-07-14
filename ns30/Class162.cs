using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ns30
{
	// Token: 0x0200020B RID: 523
	internal sealed class Class162 : Class161
	{
		// Token: 0x0200020C RID: 524
		protected enum Enum19
		{
			// Token: 0x04000E36 RID: 3638
			const_0,
			// Token: 0x04000E37 RID: 3639
			const_1,
			// Token: 0x04000E38 RID: 3640
			const_2
		}

		// Token: 0x04000E21 RID: 3617
		private bool bool_1;

		// Token: 0x04000E22 RID: 3618
		private bool bool_2;

		// Token: 0x04000E23 RID: 3619
		private bool bool_3;

		// Token: 0x04000E24 RID: 3620
		private bool bool_4;

		// Token: 0x04000E27 RID: 3623
		private bool bool_5;

		// Token: 0x04000E2E RID: 3630
		private bool bool_6;

		// Token: 0x04000E1D RID: 3613
		private readonly Class154 class154_0;

		// Token: 0x04000E1F RID: 3615
		private readonly Class165 class165_0;

		// Token: 0x04000E1E RID: 3614
		private readonly Class166 class166_0;

		// Token: 0x04000E2F RID: 3631
		private Class167 class167_0;

		// Token: 0x04000E20 RID: 3616
		private readonly Class176 class176_0;

		// Token: 0x04000E25 RID: 3621
		private Enum18 enum18_0;

		// Token: 0x04000E26 RID: 3622
		private Enum20 enum20_0;

		// Token: 0x04000E30 RID: 3632
		private Enum20 enum20_1;

		// Token: 0x04000E28 RID: 3624
		private int int_1;

		// Token: 0x04000E29 RID: 3625
		private int int_2;

		// Token: 0x04000E2B RID: 3627
		private int int_3;

		// Token: 0x04000E31 RID: 3633
		private int int_4;

		// Token: 0x04000E18 RID: 3608
		private static readonly object object_3 = new object();

		// Token: 0x04000E19 RID: 3609
		private static readonly object object_4 = new object();

		// Token: 0x04000E1A RID: 3610
		private static readonly object object_5 = new object();

		// Token: 0x04000E1B RID: 3611
		private static readonly object object_6 = new object();

		// Token: 0x04000E1C RID: 3612
		private static readonly object object_7 = new object();

		// Token: 0x04000E15 RID: 3605
		private static readonly string[] string_1 = new string[]
		{
			"Pragma",
			"Cache-Control"
		};

		// Token: 0x04000E16 RID: 3606
		private static readonly string[] string_2 = new string[]
		{
			"Connection",
			"Proxy-Connection"
		};

		// Token: 0x04000E17 RID: 3607
		private static readonly string[] string_3 = new string[]
		{
			"HTTP/1.0",
			"HTTP/1.1"
		};

		// Token: 0x04000E2A RID: 3626
		private string string_4;

		// Token: 0x04000E2C RID: 3628
		private string string_5;

		// Token: 0x04000E2D RID: 3629
		private string string_6;

		// Token: 0x04000E32 RID: 3634
		private string string_7;

		// Token: 0x04000E33 RID: 3635
		private string string_8;

		// Token: 0x04000E34 RID: 3636
		private string string_9;

		// Token: 0x0600125E RID: 4702
		// RVA: 0x0006165C File Offset: 0x0005F85C
		public Class162()
		{
			this.class165_0 = new Class165();
			this.class154_0 = new Class154();
			this.class166_0 = new Class166();
			this.class176_0 = new Class176();
			this.enum20_0 = Enum20.const_1;
			this.enum18_0 = Enum18.const_1;
			this.string_7 = "osu!";
			this.bool_5 = true;
			this.bool_1 = true;
			this.bool_4 = true;
			this.bool_3 = true;
			this.bool_2 = true;
			this.int_2 = 15;
			this.int_1 = 0;
			this.string_8 = string.Empty;
			this.string_6 = string.Empty;
		}

		// Token: 0x06001277 RID: 4727
		// RVA: 0x000617F4 File Offset: 0x0005F9F4
		public string[] Get(string string_10)
		{
			Stream stream = new MemoryStream();
			this.Get(string_10, stream);
			stream.Position = 0L;
			Class173 class = new Class173();
			class.method_2(stream, this.method_27().method_11());
			return class.ToArray();
		}

		// Token: 0x06001278 RID: 4728
		// RVA: 0x00061840 File Offset: 0x0005FA40
		public void Get(string string_10, Stream stream_0)
		{
			Class167 class = this.method_25();
			try
			{
				if (class == null)
				{
					class = new Class167();
				}
				this.method_60("GET", string_10, class, stream_0);
			}
			finally
			{
				if (this.class167_0 != null)
				{
					this.class167_0.Dispose();
				}
			}
		}

		// Token: 0x0600125F RID: 4703
		// RVA: 0x0001135A File Offset: 0x0000F55A
		public bool method_15()
		{
			return this.bool_1;
		}

		// Token: 0x06001260 RID: 4704
		// RVA: 0x00011362 File Offset: 0x0000F562
		public bool method_16()
		{
			return this.bool_2;
		}

		// Token: 0x06001261 RID: 4705
		// RVA: 0x0001136A File Offset: 0x0000F56A
		public bool method_17()
		{
			return this.bool_3;
		}

		// Token: 0x06001262 RID: 4706
		// RVA: 0x00011372 File Offset: 0x0000F572
		public bool method_18()
		{
			return this.bool_4;
		}

		// Token: 0x06001263 RID: 4707
		// RVA: 0x0001137A File Offset: 0x0000F57A
		public Class154 method_19()
		{
			return this.class154_0;
		}

		// Token: 0x06001264 RID: 4708
		// RVA: 0x00011382 File Offset: 0x0000F582
		public Enum20 method_20()
		{
			return this.enum20_0;
		}

		// Token: 0x06001265 RID: 4709
		// RVA: 0x0001138A File Offset: 0x0000F58A
		public bool method_21()
		{
			return this.bool_5;
		}

		// Token: 0x06001266 RID: 4710
		// RVA: 0x00011392 File Offset: 0x0000F592
		public int method_22()
		{
			return this.int_1;
		}

		// Token: 0x06001267 RID: 4711
		// RVA: 0x0001139A File Offset: 0x0000F59A
		public int method_23()
		{
			return this.int_2;
		}

		// Token: 0x06001268 RID: 4712
		// RVA: 0x000113A2 File Offset: 0x0000F5A2
		public Class166 method_24()
		{
			return this.class166_0;
		}

		// Token: 0x06001269 RID: 4713
		// RVA: 0x000113AA File Offset: 0x0000F5AA
		public Class167 method_25()
		{
			return this.class167_0;
		}

		// Token: 0x0600126A RID: 4714
		// RVA: 0x000113B2 File Offset: 0x0000F5B2
		public void method_26(Class167 class167_1)
		{
			this.class167_0 = class167_1;
			this.vmethod_3(new PropertyChangedEventArgs("Request"));
		}

		// Token: 0x0600126B RID: 4715
		// RVA: 0x000113CB File Offset: 0x0000F5CB
		public Class165 method_27()
		{
			return this.class165_0;
		}

		// Token: 0x0600126C RID: 4716
		// RVA: 0x000113D3 File Offset: 0x0000F5D3
		public Enum20 method_28()
		{
			return this.enum20_1;
		}

		// Token: 0x0600126D RID: 4717
		// RVA: 0x000113DB File Offset: 0x0000F5DB
		public int method_29()
		{
			return this.int_4;
		}

		// Token: 0x0600126E RID: 4718
		// RVA: 0x000113E3 File Offset: 0x0000F5E3
		internal Class176 method_30()
		{
			return this.class176_0;
		}

		// Token: 0x0600126F RID: 4719
		// RVA: 0x000113EB File Offset: 0x0000F5EB
		public string method_31()
		{
			return this.string_7;
		}

		// Token: 0x06001270 RID: 4720
		// RVA: 0x000113F3 File Offset: 0x0000F5F3
		public void method_32(Delegate16 delegate16_0)
		{
			base.Events.AddHandler(Class162.object_3, delegate16_0);
		}

		// Token: 0x06001271 RID: 4721
		// RVA: 0x00011406 File Offset: 0x0000F606
		public void method_33(Delegate16 delegate16_0)
		{
			base.Events.AddHandler(Class162.object_7, delegate16_0);
		}

		// Token: 0x06001272 RID: 4722
		// RVA: 0x00011419 File Offset: 0x0000F619
		public void method_34(Delegate16 delegate16_0)
		{
			base.Events.RemoveHandler(Class162.object_7, delegate16_0);
		}

		// Token: 0x06001273 RID: 4723
		// RVA: 0x0001142C File Offset: 0x0000F62C
		private void method_35(object sender, EventArgs6 e)
		{
			this.vmethod_7(e);
		}

		// Token: 0x06001274 RID: 4724
		// RVA: 0x00011435 File Offset: 0x0000F635
		private void method_36(object sender, EventArgs6 e)
		{
			this.vmethod_11(e);
		}

		// Token: 0x06001275 RID: 4725
		// RVA: 0x000616FC File Offset: 0x0005F8FC
		private Enum20 method_37(byte[] byte_0, int int_5)
		{
			int num = Class177.smethod_1(new byte[]
			{
				32
			}, byte_0, int_5);
			if (num > -1)
			{
				string b = Encoding.ASCII.GetString(byte_0, 0, num).Trim().ToUpper(CultureInfo.InvariantCulture);
				IEnumerator enumerator = Enum.GetValues(typeof(Enum20)).GetEnumerator();
				Enum20 result;
				try
				{
					while (enumerator.MoveNext())
					{
						Enum20 enum = (Enum20)enumerator.Current;
						if (Class162.string_3[(int)enum] == b)
						{
							result = enum;
							return result;
						}
					}
					goto IL_94;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				return result;
			}
			IL_94:
			return this.method_20();
		}

		// Token: 0x06001276 RID: 4726
		// RVA: 0x000617B4 File Offset: 0x0005F9B4
		private int method_38(byte[] byte_0, int int_5)
		{
			int num = Class177.smethod_1(new byte[]
			{
				32
			}, byte_0, int_5);
			if (num > -1)
			{
				return Class174.smethod_4(Encoding.ASCII.GetString(byte_0, num + 1, 3), 0);
			}
			return 0;
		}

		// Token: 0x0600127A RID: 4730
		// RVA: 0x00061894 File Offset: 0x0005FA94
		private bool method_39()
		{
			bool flag;
			if (this.method_20() == Enum20.const_1 && this.method_28() == Enum20.const_1)
			{
				if (this.method_47())
				{
					flag = (string.Compare("close", this.method_27().method_33(), true, CultureInfo.InvariantCulture) != 0);
				}
				else
				{
					flag = (string.Compare("close", this.method_27().method_13(), true, CultureInfo.InvariantCulture) != 0);
				}
			}
			else if (this.method_47())
			{
				flag = (string.Compare("Keep-Alive", this.method_27().method_33(), true, CultureInfo.InvariantCulture) != 0);
			}
			else
			{
				flag = (string.Compare("Keep-Alive", this.method_27().method_13(), true, CultureInfo.InvariantCulture) != 0);
			}
			return flag && this.method_21();
		}

		// Token: 0x0600127B RID: 4731
		// RVA: 0x00011442 File Offset: 0x0000F642
		private string method_40(int int_5)
		{
			if (int_5 != 80 && int_5 != 443)
			{
				return string.Format(":{0}", int_5);
			}
			return string.Empty;
		}

		// Token: 0x0600127D RID: 4733
		// RVA: 0x0006195C File Offset: 0x0005FB5C
		private string method_41()
		{
			string text = this.method_30().method_2();
			int length = text.LastIndexOf('/');
			text = text.Substring(0, length);
			if (text.Length > 0 && text[text.Length - 1] != '/')
			{
				text += '/';
			}
			return text;
		}

		// Token: 0x0600127E RID: 4734
		// RVA: 0x000619B4 File Offset: 0x0005FBB4
		private long method_42()
		{
			if (string.Compare("CONNECT", this.string_4, true, CultureInfo.InvariantCulture) == 0 && this.method_29() == 200)
			{
				return 0L;
			}
			if (string.Compare("HEAD", this.string_4, true, CultureInfo.InvariantCulture) != 0)
			{
				if (this.method_29() != 304)
				{
					if ((this.method_20() == Enum20.const_0 || this.method_28() == Enum20.const_0) && Class174.smethod_2(this.method_27().method_19()))
					{
						return -1L;
					}
					if (Class174.smethod_2(this.method_27().method_19()) && (this.method_29() & 200) == 200)
					{
						return -1L;
					}
					return Class174.smethod_3(this.method_27().method_19(), 0L);
				}
			}
			return 0L;
		}

		// Token: 0x0600127F RID: 4735
		// RVA: 0x00061A98 File Offset: 0x0005FC98
		private Class162.Enum19 method_43()
		{
			if (!this.method_47() || string.Compare("https", this.method_30().method_5(), true, CultureInfo.InvariantCulture) != 0)
			{
				return Class162.Enum19.const_0;
			}
			if (string.Compare("CONNECT", this.string_4, true, CultureInfo.InvariantCulture) == 0)
			{
				return Class162.Enum19.const_1;
			}
			return Class162.Enum19.const_2;
		}

		// Token: 0x06001280 RID: 4736
		// RVA: 0x00061AE8 File Offset: 0x0005FCE8
		private void method_44(Class162.Enum19 enum19_0)
		{
			if (this.method_47())
			{
				if (this.string_5 != this.method_24().method_1() || this.int_3 != this.method_24().method_0())
				{
					base.Close();
				}
				this.string_5 = this.method_24().method_1();
				this.int_3 = this.method_24().method_0();
			}
			if (!Class174.smethod_2(this.method_30().method_3()) && this.method_30().method_3() != "*")
			{
				if (base.method_8() != this.method_30().method_3() || base.method_6() != this.method_30().method_4())
				{
					base.Close();
				}
				base.method_9(this.method_30().method_3());
				base.method_7(this.method_30().method_4());
			}
			base.method_14();
		}

		// Token: 0x06001281 RID: 4737
		// RVA: 0x00011480 File Offset: 0x0000F680
		private void method_45(long long_0, long long_1)
		{
			this.bool_6 = false;
			base.method_5().method_13(long_0, long_1);
		}

		// Token: 0x06001282 RID: 4738
		// RVA: 0x00061BD4 File Offset: 0x0005FDD4
		private string[] method_46(string string_10, string[] string_11, Stream stream_0, Stream stream_1)
		{
			string[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Class173 class = new Class173();
				if (string_11 != null)
				{
					class.AddRange(string_11);
				}
				Class173 class2 = new Class173();
				this.string_4 = string_10;
				if (stream_0 == null)
				{
					stream_0 = Stream.Null;
				}
				if (stream_1 == null)
				{
					stream_1 = Stream.Null;
				}
				long position = stream_0.Position;
				bool flag = false;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Class162.Enum19 enum = Class162.Enum19.const_0;
				try
				{
					long long_;
					while (true)
					{
						enum = this.method_43();
						this.method_63(enum, class, stream_0);
						stream_0.Position = position;
						this.method_62(stream_0);
						this.vmethod_9(new EventArgs4(this.string_4, this.method_30().method_6(), class.ToArray()));
						this.method_55(class2, memoryStream);
						long_ = memoryStream.Length - memoryStream.Position;
						flag = !this.method_39();
						if (this.method_29() / 100 == 3 && this.method_29() != 304 && this.method_29() != 305)
						{
							num++;
							string[] string_12 = this.method_56(class2, long_, memoryStream);
							if (this.method_23() > 0 && num > this.method_23())
							{
								this.method_52(this.method_29(), class2, string_12);
							}
							string strA = this.string_4;
							if (!this.method_18() || !this.method_57(class, string_12, ref strA))
							{
								this.method_52(this.method_29(), class2, string_12);
							}
							if (string.Compare(strA, "GET", true, CultureInfo.InvariantCulture) == 0)
							{
								stream_0 = Stream.Null;
							}
							this.string_4 = strA;
							if (this.method_47())
							{
								flag = true;
							}
						}
						else if (this.method_29() == 401)
						{
							num2++;
							string[] string_12 = this.method_56(class2, long_, memoryStream);
							if (this.method_22() > 0 && num2 > this.method_22())
							{
								this.method_52(this.method_29(), class2, string_12);
							}
						}
						else if (this.method_29() == 407)
						{
							num3++;
							string[] string_12 = this.method_56(class2, long_, memoryStream);
							if (this.method_22() > 0 && num3 > this.method_22())
							{
								this.method_52(this.method_29(), class2, string_12);
							}
						}
						else
						{
							if (this.method_29() < 400)
							{
								break;
							}
							string[] string_12 = this.method_56(class2, long_, memoryStream);
							this.method_52(this.method_29(), class2, string_12);
						}
						if (flag)
						{
							base.Close();
						}
					}
					this.method_54(class2, long_, memoryStream, stream_1);
				}
				finally
				{
					if (flag && enum != Class162.Enum19.const_1)
					{
						base.Close();
					}
				}
				result = class2.ToArray();
			}
			return result;
		}

		// Token: 0x06001283 RID: 4739
		// RVA: 0x00011496 File Offset: 0x0000F696
		private bool method_47()
		{
			return !Class174.smethod_2(this.method_24().method_1());
		}

		// Token: 0x0600128A RID: 4746
		// RVA: 0x00061F98 File Offset: 0x00060198
		public string[] method_48(string string_10)
		{
			Stream stream = new MemoryStream();
			this.method_49(string_10, stream);
			stream.Position = 0L;
			Class173 class = new Class173();
			class.method_2(stream, this.method_27().method_11());
			return class.ToArray();
		}

		// Token: 0x0600128B RID: 4747
		// RVA: 0x000114DA File Offset: 0x0000F6DA
		public void method_49(string string_10, Stream stream_0)
		{
			this.method_50(string_10, this.method_25(), stream_0);
		}

		// Token: 0x0600128C RID: 4748
		// RVA: 0x00061FE4 File Offset: 0x000601E4
		public void method_50(string string_10, Class167 class167_1, Stream stream_0)
		{
			Class167 class = null;
			Class167 class2 = class167_1;
			try
			{
				if (class2 == null)
				{
					class = new Class167();
					class2 = class;
				}
				this.method_60("POST", string_10, class2, stream_0);
			}
			finally
			{
				if (class != null)
				{
					class.Dispose();
				}
			}
		}

		// Token: 0x0600128D RID: 4749
		// RVA: 0x0006202C File Offset: 0x0006022C
		private void method_51(Class162.Enum19 enum19_0, StringCollection stringCollection_0, Stream stream_0)
		{
			this.method_59(stringCollection_0);
			this.method_58(stringCollection_0);
			string text = this.method_30().method_1();
			if (this.method_47())
			{
				switch (enum19_0)
				{
				case Class162.Enum19.const_0:
					text = this.method_30().method_2();
					break;
				case Class162.Enum19.const_1:
					text = string.Format("{0}:{1}", this.method_30().method_3(), this.method_30().method_4());
					break;
				}
			}
			if (Class174.smethod_2(text))
			{
				text = "/";
			}
			stringCollection_0.Insert(0, string.Format("{0} {1} {2}", this.string_4, text, Class162.string_3[(int)this.method_20()]));
			Class158 class = new Class158();
			Class158.smethod_2(0, stringCollection_0, class);
			Class158.smethod_8(stringCollection_0, class, "Host");
			class.Clear();
			Class158.smethod_2(0, stringCollection_0, class);
			if (this.method_16() && Class174.smethod_2(Class158.smethod_4(stringCollection_0, class, "Accept-Encoding")))
			{
				Class158.smethod_0(stringCollection_0, "Accept-Encoding", "gzip");
			}
			string text2;
			if (!Class174.smethod_2(this.method_30().method_3()))
			{
				text2 = this.method_30().method_3() + this.method_40(this.method_30().method_4());
			}
			else
			{
				text2 = base.method_8() + this.method_40(base.method_6());
			}
			Class158.smethod_0(stringCollection_0, "Host", text2);
			if (Class174.smethod_2(Class158.smethod_4(stringCollection_0, class, "User-Agent")))
			{
				Class158.smethod_0(stringCollection_0, "User-Agent", this.method_31());
			}
			string string_ = Class158.smethod_4(stringCollection_0, class, "Content-Length");
			if (stream_0.Length == 0L)
			{
				Class158.smethod_8(stringCollection_0, class, "Content-Length");
				class.Clear();
				Class158.smethod_2(0, stringCollection_0, class);
				Class158.smethod_8(stringCollection_0, class, "Content-Type");
				class.Clear();
				Class158.smethod_2(0, stringCollection_0, class);
			}
			else if (Class174.smethod_2(string_) && (enum19_0 == Class162.Enum19.const_1 || stream_0.Length > 0L))
			{
				Class158.smethod_0(stringCollection_0, "Content-Length", stream_0.Length.ToString());
			}
			if (!this.method_15() && Class174.smethod_2(Class158.smethod_4(stringCollection_0, class, Class162.string_1[(int)this.method_20()])))
			{
				Class158.smethod_0(stringCollection_0, Class162.string_1[(int)this.method_20()], "no-cache");
			}
			if (this.method_21() && Class174.smethod_2(Class158.smethod_4(stringCollection_0, class, Class162.string_2[this.method_47() ? 1 : 0])))
			{
				Class158.smethod_0(stringCollection_0, Class162.string_2[this.method_47() ? 1 : 0], "Keep-Alive");
			}
			if (this.method_17())
			{
				this.method_19().method_4(stringCollection_0);
			}
			stringCollection_0.Add("");
		}

		// Token: 0x0600128E RID: 4750
		// RVA: 0x000622D4 File Offset: 0x000604D4
		private void method_52(int int_5, StringCollection stringCollection_0, string[] string_10)
		{
			string text = string.Empty;
			if (stringCollection_0.Count > 0)
			{
				text = stringCollection_0[0];
			}
			throw new Exception3(text, int_5, string_10);
		}

		// Token: 0x0600128F RID: 4751
		// RVA: 0x00062300 File Offset: 0x00060500
		private void method_53(Class173 class173_0)
		{
			Class154 class = new Class154();
			if (this.method_17())
			{
				class.method_1(class173_0);
			}
			this.vmethod_10(new EventArgs5(this.string_4, this.method_30().method_6(), class173_0.ToArray(), class));
		}

		// Token: 0x06001290 RID: 4752
		// RVA: 0x00062348 File Offset: 0x00060548
		private void method_54(Class173 class173_0, long long_0, Stream stream_0, Stream stream_1)
		{
			Stream stream = null;
			Class152 class = base.method_5();
			class.delegate16_0 = (Delegate16)Delegate.Combine(class.delegate16_0, new Delegate16(this.method_35));
			Stream stream2 = new MemoryStream();
			try
			{
				if (string.Compare("chunked", this.method_27().method_35(), true, CultureInfo.InvariantCulture) == 0)
				{
					using (Stream6 stream3 = new Stream6(stream2))
					{
						if (long_0 > 0L)
						{
							Class172.smethod_0(stream_0, stream3, long_0);
						}
						this.method_45(long_0, -1L);
						if (base.method_0())
						{
							while (!stream3.IsCompleted)
							{
								base.method_5().ReadData(stream3);
							}
						}
						if (!this.bool_6)
						{
							this.vmethod_7(new EventArgs6(base.method_5().method_5(), -1L));
						}
						goto IL_1B6;
					}
				}
				if (long_0 > 0L)
				{
					Class172.smethod_0(stream_0, stream2, long_0);
				}
				long num = this.method_42();
				long num2 = num;
				this.method_45(long_0, num2);
				if (num < 0L)
				{
					if (base.method_0())
					{
						base.method_5().method_18(true);
						base.method_5().ReadData(stream2);
					}
				}
				else
				{
					long num3 = base.method_5().method_5();
					num -= long_0;
					if (base.method_0())
					{
						while (base.method_5().method_5() - num3 < num)
						{
							base.method_5().ReadData(stream2);
						}
					}
				}
				if (!this.bool_6)
				{
					this.vmethod_7(new EventArgs6(num2, num2));
				}
			}
			finally
			{
				Class152 class2 = base.method_5();
				class2.delegate16_0 = (Delegate16)Delegate.Remove(class2.delegate16_0, new Delegate16(this.method_35));
				if (stream != null)
				{
					stream.Close();
				}
				stream = null;
			}
			IL_1B6:
			this.method_53(class173_0);
			stream2.Position = 0L;
			if (this.method_27().method_15() == "gzip")
			{
				GZipStream gZipStream = new GZipStream(stream2, CompressionMode.Decompress);
				int num4 = 0;
				byte[] buffer = new byte[512];
				while (true)
				{
					int num5 = gZipStream.Read(buffer, 0, 512);
					if (num5 == 0)
					{
						break;
					}
					num4 += num5;
					stream_1.Write(buffer, 0, num5);
				}
				gZipStream.Close();
				return;
			}
			Class172.smethod_0(stream2, stream_1, stream2.Length);
		}

		// Token: 0x06001291 RID: 4753
		// RVA: 0x000625C8 File Offset: 0x000607C8
		private void method_55(Class173 class173_0, MemoryStream memoryStream_0)
		{
			memoryStream_0.SetLength(0L);
			memoryStream_0.Position = 0L;
			int num = 0;
			this.int_4 = 0;
			this.enum20_1 = this.method_20();
			base.method_5().method_18(false);
			int num2;
			do
			{
				base.method_5().ReadData(memoryStream_0);
				while (true)
				{
					num2 = Class177.smethod_2(Encoding.ASCII.GetBytes("\r\n\r\n"), memoryStream_0.GetBuffer(), num, (int)memoryStream_0.Length);
					if (num2 <= 0)
					{
						break;
					}
					this.int_4 = this.method_38(memoryStream_0.GetBuffer(), num);
					this.enum20_1 = this.method_37(memoryStream_0.GetBuffer(), num);
					if (this.int_4 != 100)
					{
						break;
					}
					num = num2 + "\r\n\r\n".Length;
				}
			}
			while (this.int_4 == 0 || this.int_4 == 100);
			memoryStream_0.Position = (long)num;
			class173_0.Clear();
			class173_0.method_3(memoryStream_0, (long)(num2 + "\r\n\r\n".Length - num), false, string.Empty);
			this.method_27().method_4(class173_0);
		}

		// Token: 0x06001292 RID: 4754
		// RVA: 0x000626D8 File Offset: 0x000608D8
		private string[] method_56(Class173 class173_0, long long_0, Stream stream_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			this.method_54(class173_0, long_0, stream_0, memoryStream);
			memoryStream.Position = 0L;
			return Class174.smethod_0(Class175.GetString(memoryStream.GetBuffer(), this.method_27().method_11()));
		}

		// Token: 0x06001293 RID: 4755
		// RVA: 0x00062720 File Offset: 0x00060920
		private bool method_57(Class173 class173_0, string[] string_10, ref string string_11)
		{
			string location = this.method_27().Location;
			EventArgs3 eventArgs = new EventArgs3(class173_0.ToArray(), this.int_4, this.method_27(), string_10, string_11, false, false);
			string value = this.method_41();
			this.vmethod_8(eventArgs);
			string_11 = eventArgs.method_1();
			if (eventArgs.Handled || Class174.smethod_2(location))
			{
				return eventArgs.method_0();
			}
			this.class176_0.Parse(this.method_30().method_6(), location);
			if (Class174.smethod_2(this.method_30().method_2()))
			{
				return false;
			}
			string_11 = this.vmethod_6(this.method_29(), string_11);
			if (this.method_41().IndexOf(value) != 0)
			{
				Class158 class158_ = new Class158();
				Class158.smethod_2(0, class173_0, class158_);
				Class158.smethod_8(class173_0, class158_, "Authorization");
			}
			return true;
		}

		// Token: 0x06001294 RID: 4756
		// RVA: 0x000114EA File Offset: 0x0000F6EA
		private void method_58(StringCollection stringCollection_0)
		{
			while (stringCollection_0.Count > 0 && Class174.smethod_2(stringCollection_0[stringCollection_0.Count - 1]))
			{
				stringCollection_0.RemoveAt(stringCollection_0.Count - 1);
			}
		}

		// Token: 0x06001295 RID: 4757
		// RVA: 0x000627E8 File Offset: 0x000609E8
		private void method_59(StringCollection stringCollection_0)
		{
			if (stringCollection_0.Count > 0)
			{
				int num = stringCollection_0[0].IndexOf(' ');
				int num2 = stringCollection_0[0].IndexOf(':');
				if (num >= 0 && (num2 < 0 || num < num2))
				{
					stringCollection_0.RemoveAt(0);
				}
			}
		}

		// Token: 0x06001296 RID: 4758
		// RVA: 0x00062830 File Offset: 0x00060A30
		public string[] method_60(string string_10, string string_11, Class167 class167_1, Stream stream_0)
		{
			string[] string_12 = class167_1.method_1();
			string[] result;
			using (Stream stream = class167_1.method_2())
			{
				result = this.method_61(string_10, string_11, string_12, stream, stream_0);
			}
			return result;
		}

		// Token: 0x06001297 RID: 4759
		// RVA: 0x0001151B File Offset: 0x0000F71B
		public string[] method_61(string string_10, string string_11, string[] string_12, Stream stream_0, Stream stream_1)
		{
			if (string_11 != null && string_11 != this.string_9)
			{
				this.string_9 = string_11;
				this.method_30().Parse(string_11);
			}
			return this.method_46(string_10, string_12, stream_0, stream_1);
		}

		// Token: 0x06001298 RID: 4760
		// RVA: 0x00062878 File Offset: 0x00060A78
		private void method_62(Stream stream_0)
		{
			if (stream_0.Length > 0L)
			{
				this.method_45(stream_0.Position, stream_0.Length);
				Class152 class = base.method_5();
				class.delegate16_0 = (Delegate16)Delegate.Combine(class.delegate16_0, new Delegate16(this.method_36));
				try
				{
					base.method_5().vmethod_6(stream_0);
					if (!this.bool_6)
					{
						this.vmethod_11(new EventArgs6(stream_0.Length, stream_0.Length));
					}
				}
				finally
				{
					Class152 class2 = base.method_5();
					class2.delegate16_0 = (Delegate16)Delegate.Remove(class2.delegate16_0, new Delegate16(this.method_36));
				}
			}
		}

		// Token: 0x06001299 RID: 4761
		// RVA: 0x0006293C File Offset: 0x00060B3C
		private void method_63(Class162.Enum19 enum19_0, StringCollection stringCollection_0, Stream stream_0)
		{
			bool flag = base.method_0();
			this.method_44(enum19_0);
			this.method_51(enum19_0, stringCollection_0, stream_0);
			try
			{
				base.method_5().WriteString(stringCollection_0.ToString());
			}
			catch (Exception2 exception)
			{
				if (!flag || exception.method_0() != 10053)
				{
					throw;
				}
				base.Close();
				base.method_14();
				base.method_5().WriteString(stringCollection_0.ToString());
			}
		}

		// Token: 0x06001279 RID: 4729
		// RVA: 0x0001143E File Offset: 0x0000F63E
		protected override int vmethod_0()
		{
			return 80;
		}

		// Token: 0x06001287 RID: 4743
		// RVA: 0x00061F30 File Offset: 0x00060130
		protected virtual void vmethod_10(EventArgs5 eventArgs5_0)
		{
			Delegate15 delegate = (Delegate15)base.Events[Class162.object_6];
			if (delegate != null)
			{
				delegate(this, eventArgs5_0);
			}
		}

		// Token: 0x06001288 RID: 4744
		// RVA: 0x00061F60 File Offset: 0x00060160
		protected virtual void vmethod_11(EventArgs6 eventArgs6_0)
		{
			this.bool_6 = true;
			Delegate16 delegate = (Delegate16)base.Events[Class162.object_7];
			if (delegate != null)
			{
				delegate(this, eventArgs6_0);
			}
		}

		// Token: 0x06001289 RID: 4745
		// RVA: 0x000114AB File Offset: 0x0000F6AB
		protected override void vmethod_5(string string_10, int int_5)
		{
			if (this.method_47())
			{
				base.vmethod_5(this.method_24().method_1(), this.method_24().method_0());
				return;
			}
			base.vmethod_5(string_10, int_5);
		}

		// Token: 0x0600127C RID: 4732
		// RVA: 0x00011467 File Offset: 0x0000F667
		protected virtual string vmethod_6(int int_5, string string_10)
		{
			if (int_5 != 302 && int_5 != 303)
			{
				return string_10;
			}
			return "GET";
		}

		// Token: 0x06001284 RID: 4740
		// RVA: 0x00061E98 File Offset: 0x00060098
		protected virtual void vmethod_7(EventArgs6 eventArgs6_0)
		{
			this.bool_6 = true;
			Delegate16 delegate = (Delegate16)base.Events[Class162.object_3];
			if (delegate != null)
			{
				delegate(this, eventArgs6_0);
			}
		}

		// Token: 0x06001285 RID: 4741
		// RVA: 0x00061ED0 File Offset: 0x000600D0
		protected virtual void vmethod_8(EventArgs3 eventArgs3_0)
		{
			Delegate13 delegate = (Delegate13)base.Events[Class162.object_4];
			if (delegate != null)
			{
				delegate(this, eventArgs3_0);
			}
		}

		// Token: 0x06001286 RID: 4742
		// RVA: 0x00061F00 File Offset: 0x00060100
		protected virtual void vmethod_9(EventArgs4 eventArgs4_0)
		{
			Delegate14 delegate = (Delegate14)base.Events[Class162.object_5];
			if (delegate != null)
			{
				delegate(this, eventArgs4_0);
			}
		}
	}
}
