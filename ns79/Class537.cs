using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns30;
using ns77;
using ns8;
using osu_common.Helpers;
using osu_common.Libraries.NetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns79
{
	// Token: 0x0200057A RID: 1402
	internal sealed class Class537 : Class532
	{
		// Token: 0x04002585 RID: 9605
		public bool bool_15;

		// Token: 0x04002586 RID: 9606
		private FileNetRequest fileNetRequest_0;

		// Token: 0x04002584 RID: 9604
		internal float float_7;

		// Token: 0x0400257F RID: 9599
		internal int int_7;

		// Token: 0x04002582 RID: 9602
		private int int_8;

		// Token: 0x04002583 RID: 9603
		private int int_9;

		// Token: 0x04002587 RID: 9607
		private static List<FileNetRequest> list_3 = new List<FileNetRequest>();

		// Token: 0x04002580 RID: 9600
		private string string_1;

		// Token: 0x04002581 RID: 9601
		private string string_2;

		// Token: 0x04002588 RID: 9608
		private VoidDelegate voidDelegate_1;

		// Token: 0x06002D16 RID: 11542
		// RVA: 0x00124BB0 File Offset: 0x00122DB0
		internal Class537(string string_3, string string_4, int int_10, Vector2 vector2_9, float float_8) : base(null, vector2_9, float_8, true, Color.get_White())
		{
			if (string.IsNullOrEmpty(string_4) && !string.IsNullOrEmpty(string_3))
			{
				string_4 = "Data/a/dynamic_sprite_" + Class33.smethod_2(string_3);
			}
			this.string_2 = string_4;
			this.string_1 = string_3;
			this.int_7 = int_10;
			this.bool_6 = true;
			if (string_3 == null)
			{
				this.enum69_0 = Enum69.const_4;
			}
		}

		// Token: 0x06002D1C RID: 11548
		// RVA: 0x00124F24 File Offset: 0x00123124
		public override void Dispose()
		{
			if (this.fileNetRequest_0 != null)
			{
				this.fileNetRequest_0.Abort();
				lock (Class537.list_3)
				{
					Class537.list_3.Remove(this.fileNetRequest_0);
				}
				this.enum69_0 = Enum69.const_0;
			}
		}

		// Token: 0x06002D17 RID: 11543
		// RVA: 0x000221F8 File Offset: 0x000203F8
		internal override void Dispose(bool bool_16)
		{
			Class742.Remove(this);
			base.Dispose(bool_16);
		}

		// Token: 0x06002D12 RID: 11538
		// RVA: 0x000221CA File Offset: 0x000203CA
		internal string method_51()
		{
			return this.string_1;
		}

		// Token: 0x06002D13 RID: 11539
		// RVA: 0x00124B58 File Offset: 0x00122D58
		internal void method_52(string string_3)
		{
			if (this.string_1 != string_3)
			{
				if (this.class731_0 != null)
				{
					this.class731_0.Dispose();
					this.class731_0 = null;
				}
				this.string_1 = string_3;
				this.enum69_0 = Enum69.const_0;
			}
			if (string.IsNullOrEmpty(this.string_1))
			{
				this.enum69_0 = Enum69.const_4;
			}
		}

		// Token: 0x06002D14 RID: 11540
		// RVA: 0x000221D2 File Offset: 0x000203D2
		internal string method_53()
		{
			return this.string_2;
		}

		// Token: 0x06002D15 RID: 11541
		// RVA: 0x000221DA File Offset: 0x000203DA
		internal void method_54(string string_3)
		{
			if (this.string_2 != string_3)
			{
				this.string_2 = string_3;
				this.enum69_0 = Enum69.const_0;
			}
		}

		// Token: 0x06002D1A RID: 11546
		// RVA: 0x00124EC8 File Offset: 0x001230C8
		internal void method_55(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = this.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06002D1B RID: 11547
		// RVA: 0x00124F00 File Offset: 0x00123100
		private void method_56()
		{
			VoidDelegate voidDelegate = this.voidDelegate_1;
			if (voidDelegate != null)
			{
				voidDelegate();
			}
			this.voidDelegate_1 = null;
		}

		// Token: 0x06002D1D RID: 11549
		// RVA: 0x00022211 File Offset: 0x00020411
		[CompilerGenerated]
		private bool method_57(FileNetRequest fileNetRequest_1)
		{
			return fileNetRequest_1 != null && fileNetRequest_1.string_1 == this.string_2 && fileNetRequest_1.string_0 == this.string_1;
		}

		// Token: 0x06002D1E RID: 11550
		// RVA: 0x00124F84 File Offset: 0x00123184
		[CompilerGenerated]
		private void method_58(string string_3, Exception exception_0)
		{
			this.enum69_0 = Enum69.const_3;
			lock (Class537.list_3)
			{
				Class537.list_3.Remove(this.fileNetRequest_0);
			}
			this.fileNetRequest_0 = null;
		}

		// Token: 0x06002D18 RID: 11544
		// RVA: 0x00124C18 File Offset: 0x00122E18
		internal override Class731 vmethod_6()
		{
			Predicate<FileNetRequest> predicate = null;
			FileNetRequest.Delegate10 delegate = null;
			if (this.enum69_0 == Enum69.const_0)
			{
				if (this.string_1 == null)
				{
					return null;
				}
				if (this.int_8 > 0 && Class115.int_1 - this.int_8 < 200)
				{
					this.int_9 += Class115.int_1 - this.int_8;
				}
				else
				{
					this.int_9 = 0;
				}
				this.int_8 = Class115.int_1;
				if (this.int_9 < this.int_7)
				{
					return null;
				}
				if (this.class731_0 != null)
				{
					this.class731_0.Dispose();
				}
				List<FileNetRequest> arg_9C_0 = Class537.list_3;
				if (predicate == null)
				{
					predicate = new Predicate<FileNetRequest>(this.method_57);
				}
				this.fileNetRequest_0 = arg_9C_0.Find(predicate);
				if (this.fileNetRequest_0 != null)
				{
					return null;
				}
				if (!File.Exists(this.method_53()))
				{
					string directoryName = Path.GetDirectoryName(this.method_53());
					if (!Directory.Exists(Path.GetDirectoryName(this.method_53())))
					{
						Directory.CreateDirectory(directoryName);
					}
					this.enum69_0 = Enum69.const_1;
					this.fileNetRequest_0 = new FileNetRequest(this.method_53(), this.method_51());
					FileNetRequest arg_11A_0 = this.fileNetRequest_0;
					if (delegate == null)
					{
						delegate = new FileNetRequest.Delegate10(this.method_58);
					}
					arg_11A_0.method_2(delegate);
					Class169.smethod_0(this.fileNetRequest_0);
					lock (Class537.list_3)
					{
						Class537.list_3.Add(this.fileNetRequest_0);
						goto IL_159;
					}
				}
				this.enum69_0 = Enum69.const_3;
			}
			IL_159:
			if (this.enum69_0 == Enum69.const_3)
			{
				this.enum69_0 = Enum69.const_2;
				Class731 result;
				try
				{
					this.vmethod_7(Class731.smethod_2(this.method_53()));
					if (this.vmethod_6() != null)
					{
						if (!this.bool_15)
						{
							base.vmethod_6().bool_3 = true;
						}
						Class742.Load(this, !this.bool_15);
						if (this.float_7 != 0f)
						{
							this.float_2 = this.float_7 / (float)Math.Max(this.int_6, this.int_5);
						}
						if (this.float_3 == 1f && this.class26_0.Count == 0)
						{
							this.color_1 = new Color(this.color_1.get_R(), this.color_1.get_G(), this.color_1.get_B(), 0);
							base.method_15(200);
						}
						this.method_56();
						goto IL_269;
					}
					try
					{
						File.Delete(this.method_53());
					}
					catch
					{
					}
					this.enum69_0 = Enum69.const_4;
					result = null;
				}
				catch
				{
					try
					{
						File.Delete(this.method_53());
					}
					catch
					{
					}
					this.enum69_0 = Enum69.const_4;
					goto IL_269;
				}
				return result;
			}
			IL_269:
			return base.vmethod_6();
		}

		// Token: 0x06002D19 RID: 11545
		// RVA: 0x00022208 File Offset: 0x00020408
		internal override void vmethod_7(Class731 class731_1)
		{
			base.vmethod_7(class731_1);
		}
	}
}
