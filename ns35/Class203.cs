using ns37;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ns35
{
	// Token: 0x0200025E RID: 606
	internal sealed class Class203
	{
		// Token: 0x02000260 RID: 608
		// Token: 0x06001524 RID: 5412
		internal delegate bool Delegate25(string string_0);

		// Token: 0x0200025F RID: 607
		internal enum Enum23
		{
			// Token: 0x04000FB7 RID: 4023
			const_0,
			// Token: 0x04000FB8 RID: 4024
			const_1,
			// Token: 0x04000FB9 RID: 4025
			const_2
		}

		// Token: 0x04000FA6 RID: 4006
		private bool bool_0;

		// Token: 0x04000FB0 RID: 4016
		private bool bool_1;

		// Token: 0x04000FB1 RID: 4017
		private bool bool_2;

		// Token: 0x04000FB2 RID: 4018
		private bool bool_3;

		// Token: 0x04000FA7 RID: 4007
		private byte[] byte_0;

		// Token: 0x04000FAC RID: 4012
		private Class186 class186_0;

		// Token: 0x04000FAD RID: 4013
		private Class186 class186_1;

		// Token: 0x04000FB3 RID: 4019
		private Class202 class202_0;

		// Token: 0x04000FA9 RID: 4009
		private Class208 class208_0;

		// Token: 0x04000FAF RID: 4015
		private Class203.Delegate25 delegate25_0;

		// Token: 0x04000FAE RID: 4014
		private Class203.Enum23 enum23_0;

		// Token: 0x04000FB4 RID: 4020
		private Interface13 interface13_0 = new Class206();

		// Token: 0x04000FA4 RID: 4004
		private int int_0;

		// Token: 0x04000FA5 RID: 4005
		public List<string> list_0;

		// Token: 0x04000FA8 RID: 4008
		private Stream12 stream12_0;

		// Token: 0x04000FAA RID: 4010
		private string string_0;

		// Token: 0x04000FAB RID: 4011
		private string string_1;

		// Token: 0x04000FB5 RID: 4021
		private string string_2;

		// Token: 0x06001513 RID: 5395
		// RVA: 0x00012D24 File Offset: 0x00010F24
		public Class203()
		{
			this.list_0 = new List<string>();
		}

		// Token: 0x06001514 RID: 5396
		// RVA: 0x00012D42 File Offset: 0x00010F42
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06001515 RID: 5397
		// RVA: 0x00012D4A File Offset: 0x00010F4A
		public bool method_1()
		{
			return this.bool_3;
		}

		// Token: 0x0600151E RID: 5406
		// RVA: 0x0006CB10 File Offset: 0x0006AD10
		private void method_10(string string_3)
		{
			if (this.byte_0 == null)
			{
				this.byte_0 = new byte[4096];
			}
			using (FileStream fileStream = File.OpenRead(string_3))
			{
				if (this.class202_0 != null && this.class202_0.delegate21_0 != null)
				{
					Class188.smethod_2(fileStream, this.stream12_0, this.byte_0, this.class202_0.delegate21_0, this.class202_0.method_5(), this, string_3);
				}
				else
				{
					Class188.smethod_3(fileStream, this.stream12_0, this.byte_0);
				}
			}
			if (this.class202_0 != null)
			{
				this.bool_0 = this.class202_0.method_3(string_3);
			}
		}

		// Token: 0x0600151F RID: 5407
		// RVA: 0x0006CBC8 File Offset: 0x0006ADC8
		private void method_11(Class205 class205_0, string string_3)
		{
			bool flag = true;
			if (this.enum23_0 != Class203.Enum23.const_2 && File.Exists(string_3))
			{
				flag = (this.enum23_0 == Class203.Enum23.const_0 && this.delegate25_0 != null && this.delegate25_0(string_3));
			}
			if (flag)
			{
				if (this.class202_0 != null)
				{
					this.bool_0 = this.class202_0.method_2(class205_0.Name);
				}
				if (this.bool_0)
				{
					try
					{
						using (FileStream fileStream = File.Create(string_3))
						{
							if (this.byte_0 == null)
							{
								this.byte_0 = new byte[65536];
							}
							if (this.class202_0 != null && this.class202_0.delegate21_0 != null)
							{
								Class188.smethod_2(this.class208_0.method_2(class205_0), fileStream, this.byte_0, this.class202_0.delegate21_0, this.class202_0.method_5(), this, class205_0.Name);
							}
							else
							{
								Class188.smethod_3(this.class208_0.method_2(class205_0), fileStream, this.byte_0);
							}
							if (this.class202_0 != null)
							{
								this.bool_0 = this.class202_0.method_3(class205_0.Name);
							}
						}
						if (this.bool_1)
						{
							File.SetLastWriteTime(string_3, class205_0.method_21());
						}
						if (this.method_3() && class205_0.method_12() && class205_0.method_10() != -1)
						{
							FileAttributes fileAttributes = (FileAttributes)class205_0.method_10();
							fileAttributes &= (FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.Archive | FileAttributes.Normal);
							File.SetAttributes(string_3, fileAttributes);
						}
					}
					catch (Exception exception_)
					{
						if (this.class202_0 != null)
						{
							this.bool_0 = this.class202_0.method_1(string_3, exception_);
						}
					}
				}
			}
		}

		// Token: 0x06001520 RID: 5408
		// RVA: 0x0006CD68 File Offset: 0x0006AF68
		private void method_12(Class205 class205_0)
		{
			bool flag = false;
			string text = class205_0.Name;
			if (class205_0.method_37())
			{
				if (!(flag = (Class203.smethod_0(text) && class205_0.method_38())))
				{
					this.int_0++;
					this.list_0.Add(text);
				}
			}
			else if (class205_0.method_36())
			{
				flag = Class203.smethod_0(text);
			}
			string path = null;
			string text2 = null;
			if (flag)
			{
				if (Path.IsPathRooted(text))
				{
					string pathRoot = Path.GetPathRoot(text);
					text = text.Substring(pathRoot.Length);
				}
				if (text.Length > 0)
				{
					try
					{
						text2 = Path.Combine(this.string_0, text);
						if (class205_0.method_36())
						{
							path = text2;
						}
						else
						{
							path = Path.GetDirectoryName(Path.GetFullPath(text2));
						}
						goto IL_C7;
					}
					catch (Exception)
					{
						flag = false;
						this.int_0++;
						this.list_0.Add(text);
						goto IL_C7;
					}
				}
				flag = false;
			}
			IL_C7:
			if (flag && !Directory.Exists(path))
			{
				if (class205_0.method_36())
				{
					if (!this.method_1())
					{
						goto IL_134;
					}
				}
				try
				{
					Directory.CreateDirectory(path);
				}
				catch (Exception exception_)
				{
					flag = false;
					if (this.class202_0 != null)
					{
						if (class205_0.method_36())
						{
							this.bool_0 = this.class202_0.method_0(text2, exception_);
						}
						else
						{
							this.bool_0 = this.class202_0.method_1(text2, exception_);
						}
					}
					else
					{
						this.bool_0 = false;
					}
				}
			}
			IL_134:
			if (flag && class205_0.method_37())
			{
				this.method_11(class205_0, text2);
			}
		}

		// Token: 0x06001521 RID: 5409
		// RVA: 0x00012D8F File Offset: 0x00010F8F
		public void method_13()
		{
			this.int_0 = 0;
			this.list_0.Clear();
		}

		// Token: 0x06001516 RID: 5398
		// RVA: 0x00012D52 File Offset: 0x00010F52
		public void method_2(Interface11 interface11_0)
		{
			this.interface13_0.imethod_2(interface11_0);
		}

		// Token: 0x06001517 RID: 5399
		// RVA: 0x00012D60 File Offset: 0x00010F60
		public bool method_3()
		{
			return this.bool_2;
		}

		// Token: 0x06001518 RID: 5400
		// RVA: 0x00012D68 File Offset: 0x00010F68
		public void method_4(string string_3, string string_4, bool bool_4, string string_5)
		{
			this.method_5(File.Create(string_3), string_4, bool_4, string_5, null);
		}

		// Token: 0x06001519 RID: 5401
		// RVA: 0x0006C7E8 File Offset: 0x0006A9E8
		public void method_5(Stream stream_0, string string_3, bool bool_4, string string_4, string string_5)
		{
			this.method_2(new Class212(string_3));
			this.string_1 = string_3;
			using (this.stream12_0 = new Stream12(stream_0))
			{
				if (this.string_2 != null)
				{
					this.stream12_0.method_2(this.string_2);
				}
				Class185 class = new Class185(string_4, string_5);
				Class185 expr_47 = class;
				expr_47.delegate20_0 = (Delegate20)Delegate.Combine(expr_47.delegate20_0, new Delegate20(this.method_9));
				if (this.method_1())
				{
					Class185 expr_71 = class;
					expr_71.delegate19_0 = (Delegate19)Delegate.Combine(expr_71.delegate19_0, new Delegate19(this.method_8));
				}
				if (this.class202_0 != null)
				{
					if (this.class202_0.delegate24_0 != null)
					{
						Class185 expr_A8 = class;
						expr_A8.delegate24_0 = (Delegate24)Delegate.Combine(expr_A8.delegate24_0, this.class202_0.delegate24_0);
					}
					if (this.class202_0.delegate23_0 != null)
					{
						Class185 expr_D6 = class;
						expr_D6.delegate23_0 = (Delegate23)Delegate.Combine(expr_D6.delegate23_0, this.class202_0.delegate23_0);
					}
				}
				class.method_4(string_3, bool_4);
			}
		}

		// Token: 0x0600151A RID: 5402
		// RVA: 0x00012D7B File Offset: 0x00010F7B
		public void method_6(string string_3, string string_4, string string_5)
		{
			this.method_7(string_3, string_4, Class203.Enum23.const_2, null, string_5, null, this.bool_1);
		}

		// Token: 0x0600151B RID: 5403
		// RVA: 0x0006C910 File Offset: 0x0006AB10
		public void method_7(string string_3, string string_4, Class203.Enum23 enum23_1, Class203.Delegate25 delegate25_1, string string_5, string string_6, bool bool_4)
		{
			if (enum23_1 == Class203.Enum23.const_0 && delegate25_1 == null)
			{
				throw new ArgumentNullException("confirmDelegate");
			}
			this.bool_0 = true;
			this.enum23_0 = enum23_1;
			this.delegate25_0 = delegate25_1;
			this.string_0 = string_4;
			this.class186_0 = new Class186(string_5);
			this.class186_1 = new Class186(string_6);
			this.bool_1 = bool_4;
			using (this.class208_0 = new Class208(string_3))
			{
				IEnumerator enumerator = this.class208_0.GetEnumerator();
				while (this.bool_0 && enumerator.MoveNext())
				{
					Class205 class2 = (Class205)enumerator.Current;
					if (class2.method_37())
					{
						if (this.class186_1.IsMatch(Path.GetDirectoryName(class2.Name)) && this.class186_0.IsMatch(class2.Name))
						{
							this.method_12(class2);
						}
					}
					else if (class2.method_36() && this.class186_1.IsMatch(class2.Name) && this.method_1())
					{
						this.method_12(class2);
					}
				}
			}
		}

		// Token: 0x0600151C RID: 5404
		// RVA: 0x0006CA30 File Offset: 0x0006AC30
		private void method_8(object sender, EventArgs8 e)
		{
			if (!e.method_1() && this.method_1())
			{
				if (this.class202_0 != null)
				{
					this.class202_0.method_4(e.Name, e.method_1());
				}
				if (e.method_0() && e.Name != this.string_1)
				{
					Class205 class205_ = this.interface13_0.imethod_1(e.Name);
					this.stream12_0.method_8(class205_);
				}
			}
		}

		// Token: 0x0600151D RID: 5405
		// RVA: 0x0006CAA8 File Offset: 0x0006ACA8
		private void method_9(object sender, EventArgs7 e)
		{
			if (this.class202_0 != null && this.class202_0.delegate20_0 != null)
			{
				this.class202_0.delegate20_0(sender, e);
			}
			if (e.method_0())
			{
				Class205 class205_ = this.interface13_0.imethod_0(e.Name);
				this.stream12_0.method_8(class205_);
				this.method_10(e.Name);
			}
		}

		// Token: 0x06001522 RID: 5410
		// RVA: 0x00012DA3 File Offset: 0x00010FA3
		private static bool smethod_0(string string_3)
		{
			return string_3 != null && string_3.Length > 0 && string_3.IndexOfAny(Path.GetInvalidPathChars()) < 0;
		}
	}
}
